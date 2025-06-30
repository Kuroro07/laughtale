
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click
        Dim pseudo As String = tbx_user.Text.Trim()
        Dim motDePasse As String = tbx_password.Text.Trim()

        If pseudo = "" Or motDePasse = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Utilisateurs WHERE pseudo=@pseudo AND mot_de_passe=@mdp", con)
            cmd.Parameters.AddWithValue("@pseudo", pseudo)
            cmd.Parameters.AddWithValue("@mdp", motDePasse)

            con.Open()
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            con.Close()

            If count = 1 Then
                MessageBox.Show("Connexion réussie !", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Ouvrir le formulaire principal
                Dim accueil As New Form3() ' Change le nom si besoin
                accueil.Show()

                ' Fermer la page de connexion
                Me.Hide()
            Else
                MessageBox.Show("Pseudo ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim creercompte As New Form2()
        creercompte.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tbx_password.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
