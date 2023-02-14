Imports System.Windows.Forms
Imports Miscelleneous

Public Class dgViewVendorInvoice

    Public invoiceRef As Guid
    Public isVendorInvoice As Boolean
    Public isCustomerInvoice As Boolean
    Public isCustomerReceipt As Boolean
    Public isVendorReceipt As Boolean
    Public Invoicenumber As Long
    Public AccountNumer As Long

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgViewVendorInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsAccountsReceivable.CustomerTransactions' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'dsCoA.GLStatement' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsPayable.VendorInvoices' table. You can move, or remove it, as needed.
        '     Me.VendorInvoicesTableAdapter.FillByInvoice(Me.DsAccountsPayable.VendorInvoices, " where InvRef = '" & invoiceRef.ToString & "'")



        Dim bunsource As New BindingSource

        ''If isVendorInvoice Then

        ''    bunsource.DataSource = GetData("select  case invtranstype when 'CM' then 'CreditMemo' when 'IR' then 'Reversal' when 'R' then 'Payment' end as invtranstype,invoicenumber,invconvamount,invcurrency,invDate,invpostdate,invnotes,invdocnumber from vendorinvoices where invtranstype <> 'I' and invactive = 1 and  invpaymentref = (select convert(nvarchar(50),invoicenumber)from vendorinvoices where invref  =  '" & invoiceRef.ToString & "')", CommandType.Text)
        ''ElseIf iscustomerinvoice Then

        ''    bunsource.DataSource = GetData("select  case invtranstype when 'DM' then 'DebitMemo' when 'IR' then 'Reversal' when 'R' then 'Payment' end as invtranstype,invoicenumber,invconvamount,invcurrency,invDate,invpostdate,invnotes,invdocnumber from CustomerTransactions where invtranstype <> 'I' and invactive = 1 and  invpaymentref = (select convert(nvarchar(50),invoicenumber) from CustomerTransactions where invref  =  '" & invoiceRef.ToString & "')", CommandType.Text)
        ''End If

        ''dgUnderlyingDocs.DataSource = bunsource

        rbStatement.Checked = True
        dgVendorTrans.Visible = False
        dgCustomerTrans.Visible = False

        If isVendorInvoice Or isVendorReceipt Then
            Me.VendorInvoicesTableAdapter.FillByInvoice(DsAccountsPayable.VendorInvoices, " where i.invoicenumber = '" & Invoicenumber & "'")
            dgVendorTrans.Visible = True
            dgVendorTrans.Dock = DockStyle.Fill

        ElseIf isCustomerReceipt Or isCustomerInvoice Then
            Me.CustomerTransactionsTableAdapter.FillCustomerTransactions(Me.DsAccountsReceivable.CustomerTransactions, "  where i.invoicenumber = '" & Invoicenumber & "'")
            dgCustomerTrans.Visible = True
            dgCustomerTrans.Dock = DockStyle.Fill
        End If


    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub rbStatement_CheckedChanged(sender As Object, e As EventArgs) Handles rbStatement.CheckedChanged, rbInvoice.CheckedChanged

        Dim sndr As RadioButton

        sndr = sender

        Dim strwhere As String = ""

        Initreports()

        Select Case sndr.Checked
            Case True
                Select Case sndr.Name
                    Case ""
                        Me.GLStatementTableAdapter.FillByStatement(Me.dsCoA.GLStatement, 0, True, True, -1, -1, 1, 1, " and g.transtype = 'I' and g.Transdoc =  '" & Invoicenumber & "'", 0)
                        With rptInvoce
                            .RefreshReport()
                            .Dock = DockStyle.Fill
                            .Visible = True
                        End With

                    Case rbStatement.Name
                        strwhere = " and g.Account = '" & AccountNumer & "' and (isnull(g.Transdoc ,'')  =  '" & Invoicenumber & "' or isnull(at.invpaymentref,'') = '" & Invoicenumber & "')  "
                        Me.GLStatementTableAdapter.FillByStatement(Me.dsCoA.GLStatement, 0, True, True, -1, -1, 1, 1, strwhere, 0)
                        rptInvoiceStatement.RefreshReport()
                        rptInvoiceStatement.Dock = DockStyle.Fill
                        rptInvoiceStatement.Visible = True

                    Case rbInvoice.Name

                        If isVendorInvoice Or isCustomerInvoice Then
                            Me.GLStatementTableAdapter.FillByStatement(Me.dsCoA.GLStatement, 0, True, True, -1, -1, 1, 1, " and g.transtype = 'I' and g.Transdoc =  '" & Invoicenumber & "'", 0)
                        ElseIf isVendorReceipt Or isCustomerReceipt Then
                            Me.GLStatementTableAdapter.FillByStatement(Me.dsCoA.GLStatement, 0, True, True, -1, -1, 1, 1, " and g.transtype = 'R' and g.Transdoc =  '" & Invoicenumber & "'", 0)
                        End If

                        With rptInvoce
                            .RefreshReport()
                            .Dock = DockStyle.Fill
                            .Visible = True
                        End With


                End Select

        End Select



    End Sub

    Private Sub Initreports()
        rptInvoce.Visible = False
        rptInvoiceStatement.Visible = False
    End Sub

    Private Sub dgVendorTrans_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgVendorTrans.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgCustomerTrans_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgCustomerTrans.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
