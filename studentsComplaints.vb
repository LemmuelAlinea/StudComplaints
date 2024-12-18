Imports MySql.Data.MySqlClient
Public Class studentsComplaints
    Public Property loggedUserId As Integer

    Private Sub studentsComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOngoingComplaints()
    End Sub
    Private Sub LoadOngoingComplaints()
        Try
            Dim conn As New MySqlConnection("server=localhost;userid=root;password=Yoyopogi2005;database=studentscomplaints")
            conn.Open()
            Dim getNameCmd As New MySqlCommand("SELECT name FROM users WHERE user_id = @user_id", conn)
            getNameCmd.Parameters.AddWithValue("@user_id", loggedUserId)
            Dim complainer As String = getNameCmd.ExecuteScalar()?.ToString()

            If String.IsNullOrEmpty(complainer) Then
                MessageBox.Show("User not found.")
                conn.Close()
                Return
            End If
            Dim fetchCmd As New MySqlCommand("
            SELECT complaint_id, complainer, category, complaint_text, status, submission_datetime
            FROM complaints
            WHERE complainer = @complainer AND status = 'ongoing'", conn)
            fetchCmd.Parameters.AddWithValue("@complainer", complainer)

            Dim adapter As New MySqlDataAdapter(fetchCmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            recentTbl.DataSource = table

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
    Private Sub bullyingCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles bullyingCheckBox.CheckedChanged
        If bullyingCheckBox.Checked Then
            roomCheckBox.Checked = False
            ppCheckBox.Checked = False
            commotionCheckBox.Checked = False
        End If
    End Sub

    Private Sub roomCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles roomCheckBox.CheckedChanged
        If roomCheckBox.Checked Then
            bullyingCheckBox.Checked = False
            ppCheckBox.Checked = False
            commotionCheckBox.Checked = False
        End If
    End Sub

    Private Sub ppCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ppCheckBox.CheckedChanged
        If ppCheckBox.Checked Then
            bullyingCheckBox.Checked = False
            roomCheckBox.Checked = False
            commotionCheckBox.Checked = False
        End If
    End Sub

    Private Sub commotionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles commotionCheckBox.CheckedChanged
        If commotionCheckBox.Checked Then
            bullyingCheckBox.Checked = False
            roomCheckBox.Checked = False
            ppCheckBox.Checked = False
        End If
    End Sub

    Private Sub descriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles descriptionTextBox.TextChanged

    End Sub

    Private Sub recentTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles recentTbl.CellContentClick

    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim category As String = ""
        If bullyingCheckBox.Checked Then
            category = "Bullying"
        ElseIf roomCheckBox.Checked Then
            category = "Room"
        ElseIf ppCheckBox.Checked Then
            category = "Personal Problem"
        ElseIf commotionCheckBox.Checked Then
            category = "Commotion"
        ElseIf otherCheckBox.Checked Then
            category = "Other"
        End If

        Dim description As String = descriptionTextBox.Text.Trim()
        If String.IsNullOrEmpty(description) Then
            MessageBox.Show("Please enter a description.")
            Return
        End If

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

            Dim nextIdCmd As New MySqlCommand("
            SELECT MIN(t1.complaint_id + 1) AS next_id
            FROM complaints t1
            LEFT JOIN complaints t2 ON t1.complaint_id+ 1 = t2.complaint_id
            WHERE t2.complaint_id IS NULL", conn)
            Dim nextComplaintId As Integer = If(nextIdCmd.ExecuteScalar(), 1)
            Dim insertCmd As New MySqlCommand("
            INSERT INTO complaints (complaint_id, complainer, category, complaint_text, status, submission_datetime)
            VALUES (@ID, @complainer, @category, @complaint_text, 'pending', NOW())", conn)
            insertCmd.Parameters.AddWithValue("@ID", nextComplaintId)
            insertCmd.Parameters.AddWithValue("@complainer", complainerName)
            insertCmd.Parameters.AddWithValue("@category", category)
            insertCmd.Parameters.AddWithValue("@complaint_text", description)
            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Complaint submitted successfully!")

            descriptionTextBox.Clear()
            bullyingCheckBox.Checked = False
            roomCheckBox.Checked = False
            ppCheckBox.Checked = False
            commotionCheckBox.Checked = False

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If recentTbl.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the selected complaint?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim selectedRow As DataGridViewRow = recentTbl.SelectedRows(0)
            Dim complaint_Id As Integer = Convert.ToInt32(selectedRow.Cells("complaint_id").Value)
            Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM complaints WHERE complaint_id = @complaint_id"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@complaint_id", complaint_Id)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Complaint deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        recentTbl.Rows.Remove(selectedRow)
                    Else
                        MessageBox.Show("Failed to delete the complaint. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub otherCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles otherCheckBox.CheckedChanged
        If commotionCheckBox.Checked Then
            bullyingCheckBox.Checked = False
            roomCheckBox.Checked = False
            ppCheckBox.Checked = False
        End If
    End Sub
End Class
