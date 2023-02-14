Imports System.Windows.Forms
Imports Miscelleneous

Public Class frmReportsPreview

    Public frmMain As Form

    Private Sub frmReportsPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.
        '       Me.GLStatementTableAdapter.Fill(Me.dsCoA.GLStatement)
        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.
        '      Me.GLStatementTableAdapter.Fill(Me.dsCoA.GLStatement)
        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.


        MdiParent = frmMain
        Dock = DockStyle.Fill

    End Sub


    Public Sub SelectReports()

        hidereports()

        Try



            Select Case gstrTvSelNod
                Case "ProfitLoss"
                    Dim strwhere As String = ""

                    strwhere = " and g.TransPeriod between '" & strAccountingPeriodFrom & "' and '" & strAccountingPeriodTo & "' and g.account in " & strChartOfAccounts & " and convert(date,g.PostedDate) between '" & Format(DtePostingDateFrom, "MM/dd/yyyy") & "' and '" & Format(DtePostingDateTo, "MM/dd/yyyy") & "'"

                    Me.GLStatementTableAdapter.FillByStatement(dsCoA.GLStatement, 1, True, True, 1, 2, 1, True, strwhere, blnShowZeroTrans)
                    ReportViewer1.RefreshReport()
                    ReportViewer1.Dock = DockStyle.Fill
                    ReportViewer1.Visible = True

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub hidereports()


        For Each ctrl As Control In Panel1.Controls

            ctrl.Visible = False



        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class