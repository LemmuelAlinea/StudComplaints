Imports MySql.Data.MySqlClient
Public Class CrystalReport
    Public Property loggedUserId As Integer
    Private Sub CrystalReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusBox.Items.AddRange(New String() {"pending", "ongoing", "completed"})
        categoryBox.Items.AddRange(New String() {"Room", "Personal Problem", "Bullying", "Commotion", "Other"})
        dateBox.Items.AddRange(New String() {"2020", "2021", "2022", "2023", "2024"})
    End Sub

    Private Sub showBtn_Click(sender As Object, e As EventArgs) Handles showBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT category, complainer, complaint_id, status, submission_datetime FROM complaints WHERE 1=1"
        If Not String.IsNullOrEmpty(statusBox.SelectedItem) Then
            query &= " AND status = @status"
        End If

        If Not String.IsNullOrEmpty(categoryBox.SelectedItem) Then
            query &= " AND category = @category"
        End If

        If Not String.IsNullOrEmpty(dateBox.SelectedItem) Then
            query &= " AND YEAR(submission_datetime) = @year"
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(statusBox.SelectedItem) Then
                    command.Parameters.AddWithValue("@status", statusBox.SelectedItem.ToString())
                End If

                If Not String.IsNullOrEmpty(categoryBox.SelectedItem) Then
                    command.Parameters.AddWithValue("@category", categoryBox.SelectedItem.ToString())
                End If

                If Not String.IsNullOrEmpty(dateBox.SelectedItem) Then
                    command.Parameters.AddWithValue("@year", dateBox.SelectedItem.ToString())
                End If

                Dim dataAdapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                CrystalReportViewer1.ReportSource = Nothing
                CrystalReportViewer1.Refresh()
                Dim reportDocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument()

                reportDocument.Load("C:\Users\Lemmuel Alinea\source\repos\StudComplaints\CrystalReport4.rpt")
                reportDocument.SetDataSource(dataTable)
                CrystalReportViewer1.ReportSource = reportDocument
                CrystalReportViewer1.RefreshReport()
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading the report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dateBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dateBox.SelectedIndexChanged

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
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
            Case Else
                MessageBox.Show("Invalid user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Function GetUserType(user_id As Integer) As String
        Dim user_type As String = String.Empty
        Dim connectionString As String = "server=localhost;userid=root;password=Yoyopogi2005;database=studentscomplaints"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT user_type FROM users WHERE user_id = @user_id LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user_id", user_id)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        user_type = result.ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving user type: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        Return user_type
    End Function
End Class