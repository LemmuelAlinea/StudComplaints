Imports MySql.Data.MySqlClient
Public Class settingsPage
    Public Property loggedUserId As Integer
    Private Sub settingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        backBtn.Visible = False
        logoutBtn.Visible = False
    End Sub
    Private Sub outBtn_Click(sender As Object, e As EventArgs) Handles outBtn.Click
        backBtn.Visible = True
        logoutBtn.Visible = True
    End Sub
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        backBtn.Visible = False
        logoutBtn.Visible = False
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        loggedUserId = 0
        Me.Dispose()
        Dim loginPage As New loginPage()
        loginPage.Show()
    End Sub
    Private Sub accBtn_Click(sender As Object, e As EventArgs) Handles accBtn.Click
        Dim accVerify As New profilePage()
        accVerify.loggedUserId = Me.loggedUserId
        Me.Dispose()
        accVerify.Show()
    End Sub
    Private Sub bBtn_Click(sender As Object, e As EventArgs) Handles bBtn.Click
        Dim user_type As String = GetUserType(loggedUserId)

        Select Case user_type
            Case "admin"
                Dim adminHP As New adminHP()
                adminHP.loggedUserId = loggedUserId
                Me.Dispose()
                adminHP.Show()
            Case "OSA Officer"
                Dim OSAOfficerHP As New OSAOfficerHP()
                OSAOfficerHP.loggedUserId = loggedUserId
                Me.Dispose()
                OSAOfficerHP.Show()
            Case "student"
                Dim studentHP As New studentHP()
                studentHP.loggedUserId = loggedUserId
                Me.Dispose()
                studentHP.Show()
            Case Else
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Function GetUserType(user_id As Integer) As String
        Dim userType As String = String.Empty
        Dim connectionString As String = "server=localhost;userid=root;password=Yoyopogi2005;database=studentscomplaints"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT user_type FROM users WHERE user_id = @user_id LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user_id", user_id)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        userType = result.ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving user type: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return userType
    End Function

End Class
