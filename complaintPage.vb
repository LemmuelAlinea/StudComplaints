Imports MySql.Data.MySqlClient
Public Class complaintPage
    Public Property loggedUserId As Integer
    Private Sub adminComplaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComplaints()
    End Sub
    Private Sub LoadComplaints()
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT * FROM complaints WHERE status = 'pending'"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim dataAdapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                recentConcerns.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Function IsUserAdmin(userId As Integer) As Boolean
        Return True
    End Function

    Private Function IsUserOSAOfficer(userId As Integer) As Boolean
        Return False
    End Function

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"

        For Each row As DataGridViewRow In recentConcerns.Rows
            If row.IsNewRow Then Continue For
            Dim complaint_id As Integer = Convert.ToInt32(row.Cells("complaint_id").Value)
            Dim submission_datetime As String = Convert.ToString(row.Cells("submission_datetime").Value)
            Dim category As String = Convert.ToString(row.Cells("category").Value)
            Dim complainer As String = Convert.ToString(row.Cells("complainer").Value)
            Dim complaint_text As String = Convert.ToString(row.Cells("complaint_text").Value)
            Dim status As String = Convert.ToString(row.Cells("status").Value)
            Dim formattedDateTime As String = ""
            If DateTime.TryParse(submission_datetime, Nothing) Then
                formattedDateTime = DateTime.Parse(submission_datetime).ToString("yyyy-MM-dd HH:mm:ss")
            End If
            Dim query As String = "UPDATE complaints SET "

            Dim setClause As New List(Of String)

            If Not String.IsNullOrEmpty(formattedDateTime) Then
                setClause.Add("submission_datetime = @submission_datetime")
            End If
            If Not String.IsNullOrEmpty(category) Then
                setClause.Add("category = @category")
            End If
            If Not String.IsNullOrEmpty(complainer) Then
                setClause.Add("complainer = @complainer")
            End If
            If Not String.IsNullOrEmpty(complaint_text) Then
                setClause.Add("complaint_text = @complaint_text")
            End If
            If Not String.IsNullOrEmpty(status) Then
                setClause.Add("status = @status")
            End If
            If setClause.Count > 0 Then
                query &= String.Join(", ", setClause) & " WHERE complaint_id = @complaint_id"
                Using connection As New MySqlConnection(connectionString)
                    Try
                        connection.Open()
                        Using command As New MySqlCommand(query, connection)
                            If Not String.IsNullOrEmpty(formattedDateTime) Then
                                command.Parameters.AddWithValue("@submission_datetime", formattedDateTime)
                            End If
                            If Not String.IsNullOrEmpty(category) Then
                                command.Parameters.AddWithValue("@category", category)
                            End If
                            If Not String.IsNullOrEmpty(complainer) Then
                                command.Parameters.AddWithValue("@complainer", complainer)
                            End If
                            If Not String.IsNullOrEmpty(complaint_text) Then
                                command.Parameters.AddWithValue("@complaint_text", complaint_text)
                            End If
                            If Not String.IsNullOrEmpty(status) Then
                                command.Parameters.AddWithValue("@status", status)
                            End If
                            command.Parameters.AddWithValue("@complaint_id", complaint_id)
                            command.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while saving changes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End If
        Next
        MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim userType As String = GetUserType(loggedUserId)

        Select Case userType
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
    Private Function GetUserType(userID As Integer) As String
        Dim userType As String = String.Empty
        Dim connectionString As String = "server=localhost;userid=root;password=Yoyopogi2005;database=studentscomplaints"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT user_type FROM users WHERE user_id = @user_id LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user_id", userID)
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

    Private Sub recentConcerns_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles recentConcerns.CellContentClick

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ' Ensure a row is selected
        If recentConcerns.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected complaint?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            ' Get the selected complaint_id
            Dim selectedRow As DataGridViewRow = recentConcerns.SelectedRows(0) ' Only the first selected row
            Dim complaint_id As Integer = Convert.ToInt32(selectedRow.Cells("complaint_id").Value)

            ' Database connection
            Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Delete query
                Dim query As String = "DELETE FROM complaints WHERE complaint_id = @complaint_id"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@complaint_id", complaint_id)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Complaint deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh the DataGridView
                        recentConcerns.Rows.Remove(selectedRow)
                    Else
                        MessageBox.Show("Failed to delete the complaint. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class