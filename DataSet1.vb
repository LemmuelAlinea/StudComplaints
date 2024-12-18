Partial Class DataSet1
    Partial Public Class concernsDataTable
        Private Sub concernsDataTable_concernsRowChanging(sender As Object, e As concernsRowChangeEvent) Handles Me.concernsRowChanging

        End Sub

        Private Sub concernsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.studNameColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
