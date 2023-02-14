Imports System.Windows.Forms
Imports Miscelleneous

Public Class dgAdjustInvoice
    Public VendorNumber As String
    Public InvoiceRef As Guid
    Public blnEditInvoice As Boolean
    Public blnAdjustInvoice As Boolean
    Public blnCancelInvoice As Boolean

    Public isVendorTrans As Boolean



    Private Sub LoadCurrencies()
        With cboInvCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        With cboCreditMemoCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With


    End Sub



    Private Sub LoadAccountCartegories()

        'With cboInvCartegory
        '    .DataSource = ChartOfAccounts(" where acctype = 'Expense'")
        '    .DisplayMember = "Text"
        '    .ValueMember = "Value"
        'End With
    End Sub

    Private Sub LoadAccountingPeriods()
        With cboCreditMemoPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboInvPeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
        With cboCancelInvoicePeriod
            .DataSource = AccountingPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgAdjustInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCoA.ChartOfAccounts' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsAccountsPayable.VendorInvoices' table. You can move, or remove it, as needed.
        LoadCurrencies()


        LoadAccountingPeriods()


        LoadDataSets()

        LoadInvoice()





    End Sub
    Private Sub LoadDataSets()

        Me.ChartOfAccountsTableAdapter.FillByAccount(Me.DsCoA.ChartOfAccounts, "")
        'TODO: This line of code loads data into the 'DsAccountsReceivable.CustomerTransactions' table. You can move, or remove it, as needed.


    End Sub
    Private Sub LoadInvoice()
        Dim VENDORINV As dsAccountsPayable.VendorInvoicesRow

        Dim CustomerInv As dsAccountsReceivable.CustomerTransactionsRow

        If isVendorTrans Then
            Me.VendorInvoicesTableAdapter.FillByInvoice(Me.DsAccountsPayable.VendorInvoices, "")

            VENDORINV = DsAccountsPayable.VendorInvoices.Where(Function(x) x.InvRef = InvoiceRef And x.InvVendorAccNumber = VendorNumber).ToList().SingleOrDefault

            If blnAdjustInvoice Then
                With VENDORINV
                    cboCreditMemoVendor.SelectedValue = .InvVendorAccNumber
                    txtCreditMemoDoc.Text = .InvDocNumber
                    txtCreditMemoAmount.Text = .InvAmount
                    cboCreditMemoCurrency.Text = .InvCurrency
                    cboCreditMemoPeriod.SelectedValue = .Period
                    txtCreditMemoInvRef.Text = .InvRef.ToString()

                End With

            ElseIf blnCancelInvoice Then
                With VENDORINV
                    txtCancelInvoiceInvRef.Text = .InvRef.ToString
                    mskCancelInvoiceDate.Text = Now().ToShortDateString
                    txtCancelInvoiceNotes.Text = Me.Text
                End With

            ElseIf blnEditInvoice Then

                With VENDORINV
                    txtInvref.Text = .InvRef.ToString
                    cboVendorCCOUNT.SelectedValue = .InvVendorAccNumber
                    txtInvNotes.Text = .InvNotes
                    txtInvAmnt.Text = .InvAmount
                    cboInvCurrency.Text = .InvCurrency
                    txtInvref.Text = .InvRef.ToString()
                    txtInvNumber.Text = .InvDocNumber
                    mskInvDate.Text = .InvDate.ToShortDateString
                    mskInvDueDate.Text = .InvDueDate.ToShortDateString
                End With

            End If


        Else

            Me.CustomerTransactionsTableAdapter.FillCustomerTransactions(Me.DsAccountsReceivable.CustomerTransactions, "")

            CustomerInv = DsAccountsReceivable.CustomerTransactions.Where(Function(x) x.InvRef = InvoiceRef And x.CustAccNumber = VendorNumber).ToList().SingleOrDefault


            If blnAdjustInvoice Then
                With CustomerInv
                    cboCreditMemoVendor.SelectedValue = .CustAccNumber
                    txtCreditMemoDoc.Text = .InvDocNumber
                    txtCreditMemoAmount.Text = .InvAmount
                    cboCreditMemoCurrency.Text = .InvCurrency
                    cboCreditMemoPeriod.SelectedValue = .Period
                    txtCreditMemoInvRef.Text = .InvRef.ToString()

                End With

            ElseIf blnCancelInvoice Then
                With CustomerInv
                    txtCancelInvoiceInvRef.Text = .InvRef.ToString
                    mskCancelInvoiceDate.Text = Now().ToShortDateString
                    txtCancelInvoiceNotes.Text = Me.Text
                End With

            End If


        End If




    End Sub

    Private Sub txtCancelInvoiceInvRef_TextChanged(sender As Object, e As EventArgs) Handles txtCancelInvoiceInvRef.TextChanged

    End Sub
End Class
