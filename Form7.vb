Imports System.Data.SqlClient

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images (*.jpg;*.png)|*.jpg;*.png"

        If ofd.ShowDialog() = DialogResult.OK Then
            picPhoto.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub tbx_nomenfant_TextChanged(sender As Object, e As EventArgs) Handles tbx_nomenfant.TextChanged

    End Sub

    Private Sub btninformations_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Try
            ' 1. Récupérer les infos du formulaire
            Dim nom As String = tbx_nomenfant.Text.Trim()
            Dim prenom As String = tbx_prenom.Text.Trim()
            Dim dateNaissance As Date = dtp_naiss.Value
            Dim sexe As String = cbx_sexe.Text.Trim()
            Dim domicile As String = tbx_residence.Text.Trim()
            Dim nomParent As String = tbx_tuteur.Text.Trim()
            Dim numeroParent1 As String = mtbx_tuteur1.Text.Trim()
            Dim numeroParent2 As String = mtbx_tuteur2.Text.Trim()
            Dim heureArrivee As String = dtp_debut.Value.ToString("HH:mm")
            Dim heureDepart As String = dtp_fin.Value.ToString("HH:mm")

            ' 2. Convertir la photo en bytes
            Dim photoBytes() As Byte = Nothing
            If Not picPhoto.Image Is Nothing Then
                Using ms As New IO.MemoryStream()
                    picPhoto.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    photoBytes = ms.ToArray()
                End Using
            End If

            ' 3. Connexion et insertion
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            Dim query As String = "INSERT INTO Enfants (nom_enfant, prenom_enfant, date_naissance, sexe, photo, nom_parent, tel_parent, adresse, numero_parent2, heure_arrivee, heure_depart) " &
                              "VALUES (@nom, @prenom, @dateNaissance, @sexe, @photo, @nomParent, @num1, @adresse, @num2, @arrivee, @depart)"

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@nom", nom)
            cmd.Parameters.AddWithValue("@prenom", prenom)
            cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance)
            cmd.Parameters.AddWithValue("@sexe", sexe)
            cmd.Parameters.AddWithValue("@photo", If(photoBytes IsNot Nothing, CType(photoBytes, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@nomParent", nomParent)
            cmd.Parameters.AddWithValue("@num1", numeroParent1)
            cmd.Parameters.AddWithValue("@adresse", domicile)
            cmd.Parameters.AddWithValue("@num2", numeroParent2)
            cmd.Parameters.AddWithValue("@arrivee", heureArrivee)
            cmd.Parameters.AddWithValue("@depart", heureDepart)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Enfant enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionnel : Réinitialiser le formulaire
            tbx_nomenfant.Clear()
            tbx_prenom.Clear()
            tbx_tuteur.Clear()
            mtbx_tuteur1.Clear()
            mtbx_tuteur2.Clear()
            picPhoto.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'enregistrement : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class