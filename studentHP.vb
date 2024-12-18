Imports MySql.Data.MySqlClient
Public Class studentHP
    Public Property loggedUserId As Integer
    Private Sub studentHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecentComplaints()
    End Sub
    Private Sub LoadRecentComplaints()
        Try
            Dim conn As New MySqlConnection("server=localhost;userid=root;password=Yoyopogi2005;database=studentscomplaints")
            conn.Open()
            Dim getNameCmd As New MySqlCommand("SELECT name FROM users WHERE user_id = @user_id", conn)
            getNameCmd.Parameters.AddWithValue("@user_id", loggedUserId)
            Dim complainerName As String = getNameCmd.ExecuteScalar()?.ToString()

            If String.IsNullOrEmpty(complainerName) Then
                MessageBox.Show("User not found.")
                conn.Close()
                Return
            End If
            Dim fetchCmd As New MySqlCommand("
            SELECT complaint_id, category, complaint_text, status, submission_datetime
            FROM complaints
            WHERE complainer = @complainer AND status = 'pending'", conn)
            fetchCmd.Parameters.AddWithValue("@complainer", complainerName)

            Dim adapter As New MySqlDataAdapter(fetchCmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            pendingTbl.DataSource = table

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        Dim settingsPage As New settingsPage()
        settingsPage.loggedUserId = Me.loggedUserId
        Me.Dispose()
        settingsPage.Show()
    End Sub

    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click
        Dim studentHistory As New studentHistory()
        studentHistory.loggedUserId = Me.loggedUserId
        Me.Dispose()
        studentHistory.Show()
    End Sub

    Private Sub complaintsBtn_Click(sender As Object, e As EventArgs) Handles complaintsBtn.Click
        Dim studentsComplaints As New studentsComplaints()
        studentsComplaints.loggedUserId = Me.loggedUserId
        Me.Dispose()
        studentsComplaints.Show()
    End Sub

    Private Sub pendingTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles pendingTbl.CellContentClick

    End Sub
End Class