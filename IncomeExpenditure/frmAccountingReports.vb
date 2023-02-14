Imports System.Windows.Forms
Imports Miscelleneous

Public Class frmAccountingReports
    Public frmMain As Form
    Private Sub frmAccountingReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Prepareform(Me, frmMain)
        tvAccountingReports.ExpandAll()

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As Windows.Forms.TreeViewEventArgs) Handles tvAccountingReports.AfterSelect
        gbProfitAndLoss.Visible = False
        Select Case tvAccountingReports.SelectedNode.Text
            Case "ProfitLoss"
                InitGroupBox(gbProfitAndLoss, SplitContainer1, 912, 759)
                Me.ChartOfAccountsTableAdapter.FillByAccount(DsCoA.ChartOfAccounts, " where Acctype in ('Revenue','OtherRevenue','Expense','OtherExpense')  ")
                SetDefaultsPL()
        End Select
    End Sub

    Private Sub SetDefaultsPL()
        For Each rw In dgPLaccounts.Rows
            rw.cells("chkSelect").value = True

        Next
        dtpPlDateFrom.Value = Now.ToShortDateString
        DtpPlDateTo.Value = Now.ToShortDateString
    End Sub

    Private Sub loadAccountingPeriods()
        With cboPLPeriodFrom
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboPLPeriodTo
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub



    Public Sub Intit()
        loadAccountingPeriods()
    End Sub

    Private Sub dgPLAccounts_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            gstrTvSelNod = tvAccountingReports.SelectedNode.Text
            Select Case tvAccountingReports.SelectedNode.Text
                Case "ProfitLoss"

                    Dim coas As New List(Of String)

                    strAccountingPeriodFrom = cboPLPeriodFrom.SelectedValue
                    strAccountingPeriodTo = cboPLPeriodTo.SelectedValue
                    DtePostingDateFrom = dtpPlDateFrom.Value.Date
                    '   StrPostingDateFrom = Date.Parse(mskPlDateFrom.Text).ToShortDateString
                    DtePostingDateTo = DtpPlDateTo.Value.Date
                    ''   StrPostingDateTo = Date.Parse(mskPLDateTo.Text).ToShortDateString
                    blnShowZeroTrans = chkPLzeroBalances.Checked

                    For Each rw In dgPLaccounts.Rows
                        If rw.cells("chkSelect").value = True Then
                            coas.Add(rw.cells("colPLAccount").value)

                        End If
                    Next


                    strChartOfAccounts = "('" & coas.Aggregate(Function(x, y) x & "','" & y) & "')"


            End Select

            ShowPreviewScreen()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub ShowPreviewScreen()
        Dim PrevReports As New frmReportsPreview

        Cursor = Cursors.WaitCursor

        With PrevReports
            .frmMain = frmMain
            .SelectReports()
            .Show()
        End With

        Cursor = Cursors.Default

    End Sub
End Class