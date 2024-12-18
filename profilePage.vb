Imports MySql.Data.MySqlClient

Public Class profilePage
    Public Property loggedUserId As Integer

    Private Sub accverifyPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT username, password, name FROM users WHERE user_id = @user_id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@user_id", loggedUserId)
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    unameText.Text = reader("username").ToString()
                    passText.Text = reader("password").ToString()
                    nameText.Text = reader("name").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "UPDATE users SET username = IF(@newUsername != '', @newUsername, username), 
                                               password = IF(@newPassword != '', @newPassword, password),
                                              name = IF(@newName != '', @newName, name)
                               WHERE user_id = @user_id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@newUsername", unameBox.Text.Trim())
                command.Parameters.AddWithValue("@newPassword", passBox.Text.Trim())
                command.Parameters.AddWithValue("@newName", nameBox.Text.Trim())
                command.Parameters.AddWithValue("@user_id", loggedUserId)

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Account details updated successfully.")
                Else
                    MessageBox.Show("Failed to update account details.")
                End If
            End Using
        End Using
    End Sub

    Private Sub bBtn_Click(sender As Object, e As EventArgs) Handles bBtn.Click
        Dim settings As New settingsPage()
        settings.loggedUserId = loggedUserId
        Me.Dispose()
        settings.Show()
    End Sub

    Private Sub unameText_Click(sender As Object, e As EventArgs) Handles unameText.Click

    End Sub
End Class
