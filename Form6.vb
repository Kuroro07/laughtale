Imports System.Data.SqlClient
Imports ButtonCircle.FormsPlugin.Abstractions

Public Class Form6
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LAUGH_TALEDataSet7.Notifications' table. You can move, or remove it, as needed.
        Me.NotificationsTableAdapter.Fill(Me.LAUGH_TALEDataSet7.Notifications)
        Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO Notifications (titre, message, dateNotif, statut) VALUES (@titre, @message, @date, @statut)", con)

        cmd.Parameters.AddWithValue("@titre", "Paiement en attente")
        cmd.Parameters.AddWithValue("@message", "Le parent de Enfant X n’a pas encore payé.")
        cmd.Parameters.AddWithValue("@date", DateTime.Now)
        cmd.Parameters.AddWithValue("@statut", "Non lu")

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Dim con As New SqlConnection("Data Source=KYRA\MSSQLSERVER01;Initial Catalog=LAUGH TALE;Integrated Security=True")
    Sub ChargerNotifications()
        Dim da As New SqlDataAdapter("SELECT * FROM Notifications ORDER BY dateNotif DESC", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgv_notifs.DataSource = dt
    End Sub

    Private Sub Notifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerNotifications()
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        If dgv_notifs.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgv_notifs.SelectedRows(0).Cells("id_notif").Value)
            Dim result As DialogResult = MessageBox.Show("Supprimer cette notification ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim cmd As New SqlCommand("DELETE FROM Notifications WHERE id_notif=@id", con)
                cmd.Parameters.AddWithValue("@id", id)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Notification supprimée.")
                ChargerNotifications()
            End If
        Else
            MessageBox.Show("Veuillez sélectionner une notification.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        If dgv_notifs.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgv_notifs.SelectedRows(0).Cells("id_notif").Value)
            Dim cmd As New SqlCommand("UPDATE Notifications SET statut='Lu' WHERE id_notif=@id", con)
            cmd.Parameters.AddWithValue("@id", id)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Notification marquée comme lue.")
            ChargerNotifications()
        Else
            MessageBox.Show("Veuillez sélectionner une notification.")
        End If
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        ChargerNotifications()
    End Sub
End Class