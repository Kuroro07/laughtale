Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports ButtonCircle.FormsPlugin.Abstractions
Imports System.Windows.Controls


Public Class Form4
    Dim WithEvents doc As New Printing.PrintDocument
    Dim factureTexte As String = ""
    Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_retour3_Click(sender As Object, e As EventArgs)
        Dim retour2 As New Form3
        retour2.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_retour_Click(sender As Object, e As EventArgs) Handles btn_retour.Click
        Dim retour As New Form3()
        retour.Show()
        Me.Hide()
    End Sub

    Private WithEvents PrintDoc As New PrintDocument
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_imprimer.Click
        If factureTexte = "" Then
            MessageBox.Show("Veuillez d'abord générer la facture.", "Facture vide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        doc.Print()
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim fontTitre As New Font("Arial", 14, FontStyle.Bold)
        Dim fontCorps As New Font("Arial", 11)
        Dim y As Integer = 100

        e.Graphics.DrawString("FACTURE DE CRECHE", fontTitre, Brushes.Black, 100, y)
        y += 40

        Dim lignes() As String = factureTexte.Split(New String() {vbCrLf}, StringSplitOptions.None)
        For Each ligne As String In lignes
            e.Graphics.DrawString(ligne, fontCorps, Brushes.Black, 100, y)
            y += 25
        Next
    End Sub
    Private Sub ChargerFactures()
        Try
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            Dim da As New SqlDataAdapter("SELECT * FROM Factures", con)
            Dim dt As New DataTable()

            con.Open()
            da.Fill(dt)
            con.Close()

            dgv_factures.DataSource = dt ' Lier les données au DataGridView
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des factures : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        If tbx_nomParent.Text = "" Or tbx_nomEnfant.Text = "" Or mtbxTel.Text = "" Or
           tbx_id.Text = "" Or tbx_montant.Text = "" Or cbx_modePaiement.Text = "" Or cbx_statut.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim query As String = "INSERT INTO Factures (nom_enfant, nom_parent, date_facture, mode_paiement, montant) VALUES (@nom_enfant, @nom_parent, @date_facture, @mode_paiement, @montant)"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@nom_enfant", tbx_nomEnfant.Text)
        cmd.Parameters.AddWithValue("@nom_parent", tbx_nomParent.Text)
        cmd.Parameters.AddWithValue("@montant", Convert.ToDecimal(tbx_montant.Text))
        cmd.Parameters.AddWithValue("@date_facture", dtp_facture.Value)
        cmd.Parameters.AddWithValue("@mode_paiement", cbx_modePaiement.SelectedItem.ToString())
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Facture enregistrée avec succès !")
        ChargerFactures()
    End Sub

    Private Sub Btn_facturer_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_factures.CellContentClick

    End Sub

    Private Sub Btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        If dgv_factures.SelectedRows.Count > 0 Then
            Dim idFacture As Integer = Convert.ToInt32(dgv_factures.SelectedRows(0).Cells("id_facture").Value)
            Dim query As String = "DELETE FROM Factures WHERE id_facture = @id_facture"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id_facture", idFacture)

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Facture supprimée !")
            ChargerFactures()
        Else
            MessageBox.Show("Veuillez sélectionner une facture à supprimer.")
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub BtnGenererFacture_Click(sender As Object, e As EventArgs) Handles btn_facturer.Click
        ' Vérifier que tous les champs sont remplis
        If tbx_nomParent.Text = "" Or tbx_nomEnfant.Text = "" Or mtbxTel.Text = "" Or
           tbx_id.Text = "" Or tbx_montant.Text = "" Or cbx_modePaiement.Text = "" Or cbx_statut.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Construire le texte de la facture
        factureTexte = "FACTURE DE CRECHE - LAUGH TALE" & vbCrLf & vbCrLf &
                       "Date : " & dtp_facture.Value.ToShortDateString() & vbCrLf &
                       "Nom du Parent : " & tbx_nomParent.Text & vbCrLf &
                       "Nom de l'enfant : " & tbx_nomEnfant.Text & vbCrLf &
                       "Téléphone : " & mtbxTel.Text & vbCrLf &
                       "ID de l'enfant : " & tbx_id.Text & vbCrLf &
                       "Montant : " & tbx_montant.Text & " FCFA" & vbCrLf &
                       "Mode de paiement : " & cbx_modePaiement.Text & vbCrLf &
                       "Statut : " & cbx_statut.Text & vbCrLf &
                       "----------------------------------------" & vbCrLf &
                       "Merci de votre confiance ! 😊"

        ' Afficher l'aperçu
        PrintPreviewDialog1.Document = doc
        PrintPreviewDialog1.ShowDialog()
    End Sub

    ' Impression réelle
    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim yPos As Integer = 100
        Dim fontTitre As New Font("Arial", 14, FontStyle.Bold)
        Dim fontTexte As New Font("Arial", 11)

        Dim lignes() As String = factureTexte.Split(New String() {vbCrLf}, StringSplitOptions.None)

        For Each ligne In lignes
            e.Graphics.DrawString(ligne, fontTexte, Brushes.Black, 100, yPos)
            yPos += 25
        Next
    End Sub


    Private Sub Btn_facturer_Click_1(sender As Object, e As EventArgs) Handles btn_facturer.Click

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LAUGH_TALEDataSet6.Factures' table. You can move, or remove it, as needed.
        Me.FacturesTableAdapter.Fill(Me.LAUGH_TALEDataSet6.Factures)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_refresh2.Click
        Dim facturation As New Form4()
        facturation.Show()
        Me.Hide()
    End Sub
End Class