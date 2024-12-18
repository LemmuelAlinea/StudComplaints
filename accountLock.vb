Imports MySql.Data.MySqlClient

Public Class accountLock
    Public Property lockedUserId As Integer
    Private connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim enteredId As Integer
        Dim enteredUsername As String = unameBox.Text.Trim()
        Dim newPassword As String = cpassBox.Text.Trim()
        If Not Integer.TryParse(idBox.Text.Trim(), enteredId) Then
            MessageBox.Show("ID must be a number.")
            Return
        End If

        If enteredId <> lockedUserId Then
            MessageBox.Show("ID is incorrect.")
            Return
        End If

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT username FROM users WHERE user_id = @ID", conn)
            cmd.Parameters.AddWithValue("@ID", lockedUserId)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim dbUsername As String = reader("username").ToString()
                    If dbUsername <> enteredUsername Then
                        MessageBox.Show("Username is incorrect.")
                        Return
                    End If
                Else
                    MessageBox.Show("User not found.")
                    Return
                End If
            End Using

            Dim updateCmd As New MySqlCommand("UPDATE users SET password = @password WHERE user_id = @ID", conn)
            updateCmd.Parameters.AddWithValue("@password", newPassword)
            updateCmd.Parameters.AddWithValue("@ID", lockedUserId)

            If updateCmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Password updated successfully. Returning to the login page.")
                RestartApplication()
            Else
                MessageBox.Show("Error updating password.")
            End If
        End Using
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        MessageBox.Show("Returning to login page.")
        ReturnToLoginPage()
    End Sub

    Private Sub accountLock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idBox.Text = lockedUserId.ToString()
    End Sub

    Private Sub RestartApplication()
        Application.Restart()
    End Sub

    Private Sub ReturnToLoginPage()
        Me.Dispose()
        Dim loginPage As New loginPage()
        loginPage.Show()
    End Sub
End Class
