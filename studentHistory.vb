Imports MySql.Data.MySqlClient
Public Class studentHistory
    Public Property loggedUserId As Integer
    Private Sub viewBtn_Click(sender As Object, e As EventArgs)
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
            WHERE complainer = @complainer AND status = 'completed'", conn)
            fetchCmd.Parameters.AddWithValue("@complainer", complainerName)

            Dim adapter As New MySqlDataAdapter(fetchCmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            historyTbl.DataSource = table

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim studentHP As New studentHP()
        studentHP.loggedUserId = Me.loggedUserId
        Me.Dispose()
        studentHP.Show()
    End Sub

    Private Sub historyTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles historyTbl.CellContentClick

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If historyTbl.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected complaint?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim selectedRow As DataGridViewRow = historyTbl.SelectedRows(0)
            Dim complaint_id As Integer = Convert.ToInt32(selectedRow.Cells("complaint_id").Value)
            Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM complaints WHERE complaint_id = @complaint_id"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@complaint_id", complaint_id)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Complaint deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        historyTbl.Rows.Remove(selectedRow)
                    Else
                        MessageBox.Show("Failed to delete the complaint. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub studentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCompletedComplaints()
    End Sub
    Private Sub LoadCompletedComplaints()
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
            WHERE complainer = @complainer AND status = 'completed'", conn)
            fetchCmd.Parameters.AddWithValue("@complainer", complainerName)

            Dim adapter As New MySqlDataAdapter(fetchCmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            historyTbl.DataSource = table

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class