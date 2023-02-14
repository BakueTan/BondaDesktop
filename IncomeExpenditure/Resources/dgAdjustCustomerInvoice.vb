Imports System.Windows.Forms
Imports Miscelleneous

Public Class dgAdjustCustomerInvoice
    Public VendorNumber As String
    Public InvoiceRef As Guid
    Public blnEditInvoice As Boolean
    Public blnAdjustInvoice As Boolean
    Public blnCancelInvoice As Boolean



    Private Sub LoadCurrencies()
        With cboInvCurrency
            .DataSource = Currencies()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With




    End Sub

    Private Sub loadPaymentPeriods()
        With cboInvPeriod
            .DataSource = FeesPaymentPeriods()
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadAccountCartegories()

        With cboInvCartegory
            .DataSource = AccountCartegories("Expense")
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With
    End Sub

    Private Sub LoadAccountingPeriods()
        With cboCreditMemoPeriod
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
        'TODO: This line of code loads data into the 'DsAccountsPayable.Vendors' table. You can move, or remove it, as needed.
        Me.VendorsTableAdapter.Fill(Me.DsAccountsPayable.Vendors)
        'TODO: This line of code loads data into the 'DsAccountsPayable.VendorInvoices' table. You can move, or remove it, as needed.
        LoadCurrencies()
        LoadAccountCartegories()
        loadPaymentPeriods()
        LoadAccountingPeriods()
        Me.VendorInvoicesTableAdapter.FillByInvoice(Me.DsAccountsPayable.VendorInvoices, " where InvRef = '" & InvoiceRef.ToString & "' and InvVendorAccNumber = '" & VendorNumber & "'")



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


End Class
