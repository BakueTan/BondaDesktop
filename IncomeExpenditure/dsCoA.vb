Partial Class dsCoA
    Partial Public Class GLTransactionsDataTable
        Private Sub GLTransactionsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.TransTypeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
