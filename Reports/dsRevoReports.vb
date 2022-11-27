Partial Class dsRevoReports
    Partial Public Class SchoolFeesDebtorsDataTable
        Private Sub SchoolFeesDebtorsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BillingCurrencyColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace dsRevoReportsTableAdapters

    Partial Public Class SchoolFeesStatementTableAdapter
    End Class
End Namespace

Namespace dsRevoReportsTableAdapters
    Partial Public Class AcademicReportTableAdapter
    End Class

    Partial Public Class EnrollmentAnalysisTableAdapter
    End Class
End Namespace
