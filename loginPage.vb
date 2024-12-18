Imports MySql.Data.MySqlClient

Public Class loginPage
    Private connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
    Private failedAttempts As Integer = 0

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim username As String = unameBox.Text.Trim()
        Dim password As String = passBox.Text.Trim()

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", username)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim dbPassword As String = reader("password").ToString()
                    Dim userType As String = reader("user_type").ToString()
                    Dim userID As Integer = Convert.ToInt32(reader("user_id"))

                    If dbPassword = password Then
                        failedAttempts = 0
                        Select Case userType
                            Case "admin"
                                Dim adminHP As New adminHP()
                                adminHP.loggedUserId = userID
                                adminHP.Show()
                            Case "OSA Officer"
                                Dim OSAOfficerHP As New OSAOfficerHP()
                                OSAOfficerHP.loggedUserId = userID
                                OSAOfficerHP.Show()
                            Case "student"
                                Dim studentHP As New studentHP()
                                studentHP.loggedUserId = userID
                                studentHP.Show()
                        End Select
                        Me.Hide()
                    Else
                        failedAttempts += 1
                        If failedAttempts >= 5 Then
                            Dim lockForm As New accountLock()
                            lockForm.lockedUserId = userID
                            lockForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Incorrect password.")
                        End If
                    End If
                Else
                    MessageBox.Show("Invalid credentials.")
                End If
            End Using
        End Using
    End Sub

    Private Sub loginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub unameBox_TextChanged(sender As Object, e As EventArgs) Handles unameBox.TextChanged

    End Sub
End Class
