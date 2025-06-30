
Imports System.Data.SqlClient


Public Class Form2
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim connexion As New Form1()
        connexion.Show()
        Me.Hide()
    End Sub
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
            con.Open()
            MessageBox.Show("Base de données connectée !")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        End Try
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim retour1 As New Form1()
        retour1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_retour1_Click(sender As Object, e As EventArgs)
        Dim retour2 As New Form1()
        retour2.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
    Private Function ValiderMotDePasse(mdp As String) As Boolean
        ' Vérifie longueur minimale
        If mdp.Length < 6 Then
            MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.")
            Return False
        End If

        ' Vérifie présence d'une majuscule
        If Not mdp.Any(Function(c) Char.IsUpper(c)) Then
            MessageBox.Show("Le mot de passe doit contenir au moins une lettre majuscule.")
            Return False
        End If

        ' Vérifie présence d'un chiffre
        If Not mdp.Any(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Le mot de passe doit contenir au moins un chiffre.")
            Return False
        End If

        ' Mot de passe valide
        Return True
    End Function

    Private Sub Btn_inscription_Click(sender As Object, e As EventArgs) Handles btn_inscription.Click
        Dim nom As String = tbx_lastname.Text
        Dim prenom As String = tbx_firstname.Text
        Dim dateNaissance As Date = DateTimePicker1.Value
        Dim sexe As String = cmb_sexe.Text
        Dim telephone As String = MaskedTextBox1.Text
        Dim pseudo As String = tbx_pseudo.Text
        Dim motDePasse As String = tbx_password2.Text
        Dim confirmerMDP As String = tbx_password3.Text
        Dim role As String = cmb_role.Text ' 

        If motDePasse <> confirmerMDP Then
            MessageBox.Show("Les mots de passe ne correspondent pas.")
            Exit Sub
        End If

        If Not ValiderMotDePasse(motDePasse) Then
            Exit Sub ' ⛔ Stop si le mot de passe n’est pas valide
        End If

        Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
        Dim cmdCheck As New SqlCommand("SELECT COUNT(*) FROM Utilisateurs WHERE pseudo=@pseudo", con)
        cmdCheck.Parameters.AddWithValue("@pseudo", pseudo)

        con.Open()
        Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
        con.Close()

        If count > 0 Then
            MessageBox.Show("Ce pseudo est déjà utilisé.")
            Exit Sub
        End If

        Dim cmdInsert As New SqlCommand("
INSERT INTO Utilisateurs (nom, prenom, date_naissance, sexe, telephone, pseudo, mot_de_passe, role)
VALUES (@nom, @prenom, @date_naissance, @sexe, @telephone, @pseudo, @mdp, @role)", con)

        cmdInsert.Parameters.AddWithValue("@nom", nom)
        cmdInsert.Parameters.AddWithValue("@prenom", prenom)
        cmdInsert.Parameters.AddWithValue("@date_naissance", dateNaissance)
        cmdInsert.Parameters.AddWithValue("@sexe", sexe)
        cmdInsert.Parameters.AddWithValue("@telephone", telephone)
        cmdInsert.Parameters.AddWithValue("@pseudo", pseudo)
        cmdInsert.Parameters.AddWithValue("@mdp", motDePasse) ' ou hashé
        cmdInsert.Parameters.AddWithValue("@role", role)

        con.Open()
        cmdInsert.ExecuteNonQuery()
        con.Close()

        MessageBox.Show("Compte créé avec succès.")
        Dim connexion As New Form1() ' Change le nom selon ta Form
        connexion.Show()

        ' Fermer la page inscription
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class