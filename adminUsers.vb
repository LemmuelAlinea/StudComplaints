Imports MySql.Data.MySqlClient
Public Class adminUsers
    Public Property loggedUserId As Integer
    Private Sub adminUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim adminHP As New adminHP()
        adminHP.loggedUserId = Me.loggedUserId
        Me.Dispose()
        adminHP.Show()
    End Sub

    Private Sub usersTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usersTbl.CellContentClick
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT * FROM complaints"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim dataAdapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                usersTbl.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub addTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        If usersTbl.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedUserId As Integer = CInt(usersTbl.SelectedRows(0).Cells("user_id").Value)
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmDelete = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim deleteQuery As String = "DELETE FROM users WHERE user_id = @user_id"
                Using cmd As New MySqlCommand(deleteQuery, connection)
                    cmd.Parameters.AddWithValue("@user_id", selectedUserId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RefreshUsersGrid()
                    Else
                        MessageBox.Show("No user was deleted. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RefreshUsersGrid()
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT user_id, username, name, password, user_type FROM users"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim dataAdapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                usersTbl.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred while refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim uname As String = unameBox.Text.Trim()
        Dim name As String = nameBox.Text.Trim()
        Dim password As String = passBox.Text.Trim()
        Dim userType As String = userTypeBox.Text.Trim()
        If String.IsNullOrEmpty(uname) Or String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(userType) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim findGapQuery As String = "SELECT MIN(t1.user_id + 1) AS next_id
                                              FROM users t1 
                                              WHERE NOT EXISTS (SELECT t2.user_id FROM users t2 WHERE t2.user_id = t1.user_id + 1)"
                Dim nextUserId As Integer

                Using cmd As New MySqlCommand(findGapQuery, connection)
                    Dim result = cmd.ExecuteScalar()
                    If IsDBNull(result) Then
                        nextUserId = CInt(New MySqlCommand("SELECT IFNULL(MAX(user_id), 0) + 1 FROM users", connection).ExecuteScalar())
                    Else
                        nextUserId = CInt(result)
                    End If
                End Using
                Dim insertQuery As String = "INSERT INTO users (user_id, username, name, password, user_type) 
                                             VALUES (@User_id, @Username, @Name, @Password, @User_type)"

                Using cmd As New MySqlCommand(insertQuery, connection)
                    cmd.Parameters.AddWithValue("@User_id", nextUserId)
                    cmd.Parameters.AddWithValue("@Username", uname)
                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@User_type", userType)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub unameBox_TextChanged(sender As Object, e As EventArgs) Handles unameBox.TextChanged

    End Sub

    Private Sub nameBox_TextChanged(sender As Object, e As EventArgs) Handles nameBox.TextChanged

    End Sub

    Private Sub passBox_TextChanged(sender As Object, e As EventArgs) Handles passBox.TextChanged

    End Sub

    Private Sub userTypeBox_TextChanged(sender As Object, e As EventArgs) Handles userTypeBox.TextChanged

    End Sub

    Private Sub viewBtn_Click(sender As Object, e As EventArgs) Handles viewBtn.Click
        Dim connectionString As String = "Server=localhost;Database=studentscomplaints;Uid=root;Pwd=Yoyopogi2005;"
        Dim query As String = "SELECT * FROM users"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim dataAdapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                dataAdapter.Fill(dataTable)
                usersTbl.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class