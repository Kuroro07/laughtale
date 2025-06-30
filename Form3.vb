Imports System.Data.SqlClient

Public Class Form3

    Private Sub Btn_new_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnaccueil_Click(sender As Object, e As EventArgs) Handles btnaccueil.Click
        Dim accueil As New Form3()
        accueil.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btndeconnexion.Click
        ' Confirmer la déconnexion (optionnel)
        Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Fermer le menu actuel
            Me.Hide()
            ' Réafficher la page de connexion
            Dim loginForm As New Form1()
            loginForm.Show()
        End If

    End Sub

    Private Sub Btn_notif_Click_1(sender As Object, e As EventArgs) Handles btn_notif.Click
        Dim notifications As New Form6()
        notifications.ShowDialog()
    End Sub

    Private Sub Btnadmissions_Click(sender As Object, e As EventArgs) Handles btnadmissions.Click
        Dim admissions As New Form7
        admissions.ShowDialog()
    End Sub

    Private Sub Btninformations_Click(sender As Object, e As EventArgs) Handles btninformations.Click
        Dim facturation As New Form4()
        facturation.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnfants.CellContentClick
        Try
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            con.Open()

            ' Charger toutes les données sauf l’âge (on va le calculer après)
            Dim cmd As New SqlCommand("SELECT id_enfant, nom_enfant, prenom_enfant, date_naissance, sexe, photo, nom_parent, tel_parent, adresse, numero_parent2, heure_arrivee, heure_depart FROM Enfants", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Créer le DataTable manuellement
            Dim dt As New DataTable()
            dt.Columns.Add("id_enfant")
            dt.Columns.Add("nomEnfant")
            dt.Columns.Add("prenomEnfant")
            dt.Columns.Add("Age")
            dt.Columns.Add("sexe")
            dt.Columns.Add("adresse")
            dt.Columns.Add("Photo", GetType(Image)) ' Afficher la photo
            dt.Columns.Add("nomParent")
            dt.Columns.Add("numeroParent1")
            dt.Columns.Add("numeroParent2")
            dt.Columns.Add("heureArrivee")
            dt.Columns.Add("heureDepart")

            While reader.Read()
                Dim id As Integer = reader("id_enfant")
                Dim nom As String = reader("nom_enfant").ToString()
                Dim prenom As String = reader("prenom_enfant").ToString()
                Dim dateNaissance As Date = Convert.ToDateTime(reader("date_naissance"))
                Dim age As Integer = DateDiff(DateInterval.Year, dateNaissance, Date.Now)

                Dim sexe As String = reader("sexe").ToString()

                ' Photo : convertir en image si non null
                Dim imageEnfant As Image = Nothing
                If Not IsDBNull(reader("photo")) Then
                    Dim bytes() As Byte = CType(reader("photo"), Byte())
                    Using ms As New IO.MemoryStream(bytes)
                        imageEnfant = Image.FromStream(ms)
                    End Using
                End If

                Dim nomParent As String = reader("nom_parent").ToString()
                Dim adresse As String = reader("adresse").ToString()
                Dim num1 As String = reader("numero_parent1").ToString()
                Dim num2 As String = reader("numero_parent2").ToString()
                Dim arrivee As String = reader("heure_arrivee").ToString()
                Dim depart As String = reader("heure_depart").ToString()

                dt.Rows.Add(id, nom, prenom, age, sexe, imageEnfant, nomParent, adresse, num2, arrivee, depart)
            End While
            reader.Close()
            con.Close()

            dgvEnfants.DataSource = dt

            ' Adapter la colonne Photo (taille d’affichage)
            Dim imgCol As DataGridViewImageColumn = CType(dgvEnfants.Columns("photo"), DataGridViewImageColumn)
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom

            dgvEnfants.RowTemplate.Height = 70 ' Hauteur pour bien afficher la photo

        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement : " & ex.Message)
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LAUGH_TALEDataSet5.Enfants' table. You can move, or remove it, as needed.
        Me.EnfantsTableAdapter1.Fill(Me.LAUGH_TALEDataSet5.Enfants)
        'TODO: This line of code loads data into the 'LAUGH_TALEDataSet2.Enfants' table. You can move, or remove it, as needed.
        Me.EnfantsTableAdapter.Fill(Me.LAUGH_TALEDataSet2.Enfants)

    End Sub

    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        ' Vérifie si une ligne est sélectionnée dans le DataGridView
        If dgvEnfants.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un enfant à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Récupère l'ID de l'enfant sélectionné
        Dim idEnfant As Integer = CInt(dgvEnfants.SelectedRows(0).Cells("id_enfant").Value)

        ' Confirmation avant suppression
        Dim confirm As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet enfant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                ' Connexion à la BD
                Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
                Dim cmd As New SqlCommand("DELETE FROM Enfants WHERE id_enfant = @id_enfant", con)
                cmd.Parameters.AddWithValue("@id_enfant", idEnfant)

                con.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                con.Close()

                ' Vérifie si la suppression a réussi
                If rowsAffected > 0 Then
                    MessageBox.Show("Enfant supprimé avec succès ✅", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ChargerEnfants() ' Recharge la liste après suppression
                Else
                    MessageBox.Show("Échec de la suppression ❌", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Erreur lors de la suppression : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub ChargerEnfants()
        Try
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT * FROM Enfants", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            con.Open()
            adapter.Fill(dt)
            con.Close()

            dgvEnfants.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Erreur chargement des enfants : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_facturer_Click(sender As Object, e As EventArgs)
        ' Vérifier qu’un enfant est sélectionné
        If dgvEnfants.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un enfant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Récupérer les données de l’enfant sélectionné
        Dim nomEnfant As String = dgvEnfants.SelectedRows(0).Cells("nomEnfant").Value.ToString()
        Dim nomParent As String = dgvEnfants.SelectedRows(0).Cells("nomParent").Value.ToString()

        ' Ouvrir la Form de facturation avec les infos
        Dim frmFacturation As New Form4()
        frmFacturation.tbx_nomEnfant.Text = nomEnfant
        frmFacturation.tbx_nomParent.Text = nomParent
        frmFacturation.tbx_montant.Text = "5000" ' Exemple de tarif par défaut
        frmFacturation.dtp_facture.Value = DateTime.Now ' Date du jour

        frmFacturation.Show() ' Ouvrir la fenêtre de facturation
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim accueil As New Form3()
        accueil.Show()
        Me.Hide()
    End Sub
End Class