Imports MySql.Data.MySqlClient

Public Class OSAOfficerHP
    Public Property loggedUserId As Integer
    Private Sub OSAOfficerHP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecentComplaints()
    End Sub
    Private Sub LoadRecentComplaints()
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT category, complaint_id FROM complaints WHERE status = 'pending'"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim dataAdapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                recentComplaints.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        Dim settingsPage As New settingsPage()
        settingsPage.loggedUserId = Me.loggedUserId
        Me.Dispose()
        settingsPage.Show()
    End Sub

    Private Sub recentComplaints_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles recentComplaints.CellContentClick

    End Sub

    Private Sub complaintsBtn_Click(sender As Object, e As EventArgs) Handles complaintsBtn.Click
        Dim osaComplaint As New complaintPage()
        osaComplaint.loggedUserId = Me.loggedUserId
        Me.Dispose()
        osaComplaint.Show()
    End Sub

    Private Sub reportsBtn_Click(sender As Object, e As EventArgs) Handles reportsBtn.Click
        Dim CrystalReport As New CrystalReport()
        CrystalReport.loggedUserId = Me.loggedUserId
        Me.Dispose()
        CrystalReport.Show()
    End Sub

    Private Sub historyBtn_Click(sender As Object, e As EventArgs) Handles historyBtn.Click
        Dim osaHistory As New historyPage()
        osaHistory.loggedUserId = Me.loggedUserId
        Me.Dispose()
        osaHistory.Show()
    End Sub

End Class
