<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsserts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AccNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim BankDetailsLabel As System.Windows.Forms.Label
        Dim CurrencyLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim TaxCodeLabel As System.Windows.Forms.Label
        Dim PaymentTermsLabel As System.Windows.Forms.Label
        Dim CustomerBalanceLabel As System.Windows.Forms.Label
        Dim BlockedLabel As System.Windows.Forms.Label
        Dim TaxRegLabel As System.Windows.Forms.Label
        Dim CustomerCompanyLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsserts))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GLStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCoA = New IncomeExpenditure.dsCoA()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbCustomers = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountGroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TaxCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsReceivable = New IncomeExpenditure.dsAccountsReceivable()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboVenStatCurrentPeriod = New System.Windows.Forms.ComboBox()
        Me.chkVenStatShowReversals = New System.Windows.Forms.CheckBox()
        Me.chkVenStatShowPayments = New System.Windows.Forms.CheckBox()
        Me.chkVenStatShowInvoices = New System.Windows.Forms.CheckBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSearchVendor = New System.Windows.Forms.Button()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.BindingNavigator5 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton34 = New System.Windows.Forms.ToolStripButton()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AccNumberTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TbCustContact = New System.Windows.Forms.TabPage()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.tbCustTax = New System.Windows.Forms.TabPage()
        Me.cboCustVatAccount = New System.Windows.Forms.ComboBox()
        Me.TaxRegTextBox = New System.Windows.Forms.TextBox()
        Me.TaxCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.tbCustPayment = New System.Windows.Forms.TabPage()
        Me.CustomerBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTermsComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrencyComboBox = New System.Windows.Forms.ComboBox()
        Me.tbCustBankingDetails = New System.Windows.Forms.TabPage()
        Me.BankDetailsTextBox = New System.Windows.Forms.TextBox()
        Me.tbOthers = New System.Windows.Forms.TabPage()
        Me.CustomerCompanyComboBox = New System.Windows.Forms.ComboBox()
        Me.BlockedCheckBox = New System.Windows.Forms.CheckBox()
        Me.tbCustNotes = New System.Windows.Forms.TabPage()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerRefTextBox = New System.Windows.Forms.TextBox()
        Me.tbCustomerInvoice = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.gbCustomerInvoice = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnCustInvoiceRefeesh = New System.Windows.Forms.Button()
        Me.btnCustInvoiceSearch = New System.Windows.Forms.Button()
        Me.txtCustInvoiceSearchh = New System.Windows.Forms.TextBox()
        Me.gbInvoiceOptions = New System.Windows.Forms.GroupBox()
        Me.chkDisplayCncelledInvoices = New System.Windows.Forms.CheckBox()
        Me.dgVendorInvoices = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustInvVendor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDocNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VatAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCartegoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvTransType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvClearedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colInvRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInvActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvPaymentRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDocDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.InvBankAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVatCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEditInvoice = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCancelInvoice = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustomerTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbFeesPay = New System.Windows.Forms.GroupBox()
        Me.cboInvoiceCompany = New System.Windows.Forms.ComboBox()
        Me.cboInvoiceCustomer = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbNetAmount = New System.Windows.Forms.Label()
        Me.txtNetAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.cboCustVatcode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbInvPath = New System.Windows.Forms.Label()
        Me.mskInvDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskInvDueDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboInvCurrency = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtInvNotes = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtInvNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboInvPeriod = New System.Windows.Forms.ComboBox()
        Me.txtInvAmnt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboInvCartegory = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbCustomerPayment = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pnlInvoicedPayment = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnCustomerPaySearchRefresh = New System.Windows.Forms.Button()
        Me.btnCustomerPaySearch = New System.Windows.Forms.Button()
        Me.txtCustomerPaySearch = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.chkShowPayments = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dgPayInvoice = New System.Windows.Forms.DataGridView()
        Me.chkPayInvoice = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPayCustomerAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCustInvNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustInvCartegory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvConvAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBalanceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvPayCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCustInvRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvPayAmnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayDocNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvPayTransType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPayView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPayEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboPayorCompany = New System.Windows.Forms.ComboBox()
        Me.cboInvPayPeriod = New System.Windows.Forms.ComboBox()
        Me.pnlUnimvoicedPayment = New System.Windows.Forms.Panel()
        Me.lbPaymentsNet = New System.Windows.Forms.Label()
        Me.txtPaymentsNetAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPaymentsVat = New System.Windows.Forms.TextBox()
        Me.cboPaymentsVat = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPayComment = New System.Windows.Forms.TextBox()
        Me.txtPayReceipt = New System.Windows.Forms.TextBox()
        Me.btnPayNonInv = New System.Windows.Forms.Button()
        Me.cboUnivoicedPayCartegory = New System.Windows.Forms.ComboBox()
        Me.cboPaymentsCustomer = New System.Windows.Forms.ComboBox()
        Me.pnlPay = New System.Windows.Forms.Panel()
        Me.cboPayCurrency = New System.Windows.Forms.ComboBox()
        Me.cboCustomerPaymentsPayto = New System.Windows.Forms.ComboBox()
        Me.txtPaymentAmnt = New System.Windows.Forms.TextBox()
        Me.mskInvPayDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboPayTransType = New System.Windows.Forms.ComboBox()
        Me.GLStatementTableAdapter = New IncomeExpenditure.dsCoATableAdapters.GLStatementTableAdapter()
        Me.CustomersTableAdapter = New IncomeExpenditure.dsAccountsReceivableTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New IncomeExpenditure.dsAccountsReceivableTableAdapters.TableAdapterManager()
        Me.CustomerTransactionsTableAdapter = New IncomeExpenditure.dsAccountsReceivableTableAdapters.CustomerTransactionsTableAdapter()
        AccNumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        BankDetailsLabel = New System.Windows.Forms.Label()
        CurrencyLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        TaxCodeLabel = New System.Windows.Forms.Label()
        PaymentTermsLabel = New System.Windows.Forms.Label()
        CustomerBalanceLabel = New System.Windows.Forms.Label()
        BlockedLabel = New System.Windows.Forms.Label()
        TaxRegLabel = New System.Windows.Forms.Label()
        CustomerCompanyLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbCustomers.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsReceivable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TbCustContact.SuspendLayout()
        Me.tbCustTax.SuspendLayout()
        Me.tbCustPayment.SuspendLayout()
        Me.tbCustBankingDetails.SuspendLayout()
        Me.tbOthers.SuspendLayout()
        Me.tbCustNotes.SuspendLayout()
        Me.tbCustomerInvoice.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.gbCustomerInvoice.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.gbInvoiceOptions.SuspendLayout()
        CType(Me.dgVendorInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeesPay.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbCustomerPayment.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlInvoicedPayment.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgPayInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.pnlUnimvoicedPayment.SuspendLayout()
        Me.pnlPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccNumberLabel
        '
        AccNumberLabel.AutoSize = True
        AccNumberLabel.Location = New System.Drawing.Point(14, 67)
        AccNumberLabel.Name = "AccNumberLabel"
        AccNumberLabel.Size = New System.Drawing.Size(90, 13)
        AccNumberLabel.TabIndex = 0
        AccNumberLabel.Text = "Account Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(17, 89)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(17, 115)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(78, 13)
        ContactNameLabel.TabIndex = 4
        ContactNameLabel.Text = "Contact Name:"
        '
        'BankDetailsLabel
        '
        BankDetailsLabel.AutoSize = True
        BankDetailsLabel.Location = New System.Drawing.Point(12, 20)
        BankDetailsLabel.Name = "BankDetailsLabel"
        BankDetailsLabel.Size = New System.Drawing.Size(70, 13)
        BankDetailsLabel.TabIndex = 16
        BankDetailsLabel.Text = "Bank Details:"
        '
        'CurrencyLabel
        '
        CurrencyLabel.AutoSize = True
        CurrencyLabel.Location = New System.Drawing.Point(6, 72)
        CurrencyLabel.Name = "CurrencyLabel"
        CurrencyLabel.Size = New System.Drawing.Size(52, 13)
        CurrencyLabel.TabIndex = 20
        CurrencyLabel.Text = "Currency:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(6, 12)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 16
        ContactNumberLabel.Text = "Contact Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 38)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 18
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 64)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 20
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(6, 124)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 22
        CityLabel.Text = "City:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(3, 150)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 24
        CountryLabel.Text = "Country:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(6, 9)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 24
        NotesLabel.Text = "Notes:"
        '
        'TaxCodeLabel
        '
        TaxCodeLabel.AutoSize = True
        TaxCodeLabel.Location = New System.Drawing.Point(3, 57)
        TaxCodeLabel.Name = "TaxCodeLabel"
        TaxCodeLabel.Size = New System.Drawing.Size(59, 13)
        TaxCodeLabel.TabIndex = 28
        TaxCodeLabel.Text = "VAT Code:"
        '
        'PaymentTermsLabel
        '
        PaymentTermsLabel.AutoSize = True
        PaymentTermsLabel.Location = New System.Drawing.Point(6, 19)
        PaymentTermsLabel.Name = "PaymentTermsLabel"
        PaymentTermsLabel.Size = New System.Drawing.Size(83, 13)
        PaymentTermsLabel.TabIndex = 30
        PaymentTermsLabel.Text = "Payment Terms:"
        '
        'CustomerBalanceLabel
        '
        CustomerBalanceLabel.AutoSize = True
        CustomerBalanceLabel.Location = New System.Drawing.Point(6, 46)
        CustomerBalanceLabel.Name = "CustomerBalanceLabel"
        CustomerBalanceLabel.Size = New System.Drawing.Size(96, 13)
        CustomerBalanceLabel.TabIndex = 32
        CustomerBalanceLabel.Text = "Customer Balance:"
        '
        'BlockedLabel
        '
        BlockedLabel.AutoSize = True
        BlockedLabel.Location = New System.Drawing.Point(6, 59)
        BlockedLabel.Name = "BlockedLabel"
        BlockedLabel.Size = New System.Drawing.Size(49, 13)
        BlockedLabel.TabIndex = 24
        BlockedLabel.Text = "Blocked:"
        '
        'TaxRegLabel
        '
        TaxRegLabel.AutoSize = True
        TaxRegLabel.Location = New System.Drawing.Point(8, 25)
        TaxRegLabel.Name = "TaxRegLabel"
        TaxRegLabel.Size = New System.Drawing.Size(67, 13)
        TaxRegLabel.TabIndex = 29
        TaxRegLabel.Text = "VAT Reg # :"
        '
        'CustomerCompanyLabel
        '
        CustomerCompanyLabel.AutoSize = True
        CustomerCompanyLabel.Location = New System.Drawing.Point(6, 28)
        CustomerCompanyLabel.Name = "CustomerCompanyLabel"
        CustomerCompanyLabel.Size = New System.Drawing.Size(54, 13)
        CustomerCompanyLabel.TabIndex = 25
        CustomerCompanyLabel.Text = "Company:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(3, 16)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 66
        Label4.Text = "Company:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(6, 44)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(54, 13)
        StudentIDLabel1.TabIndex = 0
        StudentIDLabel1.Text = "Customer:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(3, 91)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 13)
        Label3.TabIndex = 31
        Label3.Text = "VAT Account:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Location = New System.Drawing.Point(7, 25)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(54, 13)
        Label31.TabIndex = 75
        Label31.Text = "Company:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(5, 100)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(40, 13)
        Label25.TabIndex = 72
        Label25.Text = "Period:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(960, 14)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(54, 13)
        Label24.TabIndex = 74
        Label24.Text = "Comment:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(762, 14)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(47, 13)
        Label23.TabIndex = 72
        Label23.Text = "Receipt:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(268, 14)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(55, 13)
        Label22.TabIndex = 68
        Label22.Text = "Cartegory:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(1, 37)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(41, 13)
        Label18.TabIndex = 55
        Label18.Text = "PayTo:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(1, 14)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(46, 13)
        Label17.TabIndex = 54
        Label17.Text = "Amount:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(5, 48)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(34, 13)
        Label20.TabIndex = 61
        Label20.Text = "Type:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(5, 74)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(33, 13)
        Label19.TabIndex = 57
        Label19.Text = "Date:"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Location = New System.Drawing.Point(6, 11)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(44, 13)
        Label36.TabIndex = 76
        Label36.Text = "Search:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(66, 14)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(37, 13)
        Label5.TabIndex = 0
        Label5.Text = "Payor:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 11)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(44, 13)
        Label6.TabIndex = 76
        Label6.Text = "Search:"
        '
        'GLStatementBindingSource
        '
        Me.GLStatementBindingSource.DataMember = "GLStatement"
        Me.GLStatementBindingSource.DataSource = Me.dsCoA
        '
        'dsCoA
        '
        Me.dsCoA.DataSetName = "dsCoA"
        Me.dsCoA.EnforceConstraints = False
        Me.dsCoA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbCustomers)
        Me.TabControl1.Controls.Add(Me.tbCustomerInvoice)
        Me.TabControl1.Controls.Add(Me.tbCustomerPayment)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1686, 724)
        Me.TabControl1.TabIndex = 0
        '
        'tbCustomers
        '
        Me.tbCustomers.Controls.Add(Me.GroupBox2)
        Me.tbCustomers.Controls.Add(Me.GroupBox1)
        Me.tbCustomers.Location = New System.Drawing.Point(4, 22)
        Me.tbCustomers.Name = "tbCustomers"
        Me.tbCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustomers.Size = New System.Drawing.Size(1678, 698)
        Me.tbCustomers.TabIndex = 0
        Me.tbCustomers.Text = "Customers"
        Me.tbCustomers.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl3)
        Me.GroupBox2.Location = New System.Drawing.Point(598, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1072, 677)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Location = New System.Drawing.Point(3, 16)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1066, 658)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGridView1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1058, 632)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Customers List"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccNumberDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.BankDetailsDataGridViewTextBoxColumn, Me.AccountGroupDataGridViewTextBoxColumn, Me.CurrencyDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.BlockedDataGridViewCheckBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.PaymentTermsDataGridViewTextBoxColumn, Me.CustomerBalanceDataGridViewTextBoxColumn, Me.AccTypeDataGridViewTextBoxColumn, Me.CustomerRefDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1049, 623)
        Me.DataGridView1.TabIndex = 1
        '
        'AccNumberDataGridViewTextBoxColumn
        '
        Me.AccNumberDataGridViewTextBoxColumn.DataPropertyName = "AccNumber"
        Me.AccNumberDataGridViewTextBoxColumn.HeaderText = "AccNumber"
        Me.AccNumberDataGridViewTextBoxColumn.Name = "AccNumberDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'BankDetailsDataGridViewTextBoxColumn
        '
        Me.BankDetailsDataGridViewTextBoxColumn.DataPropertyName = "BankDetails"
        Me.BankDetailsDataGridViewTextBoxColumn.HeaderText = "BankDetails"
        Me.BankDetailsDataGridViewTextBoxColumn.Name = "BankDetailsDataGridViewTextBoxColumn"
        '
        'AccountGroupDataGridViewTextBoxColumn
        '
        Me.AccountGroupDataGridViewTextBoxColumn.DataPropertyName = "AccountGroup"
        Me.AccountGroupDataGridViewTextBoxColumn.HeaderText = "AccountGroup"
        Me.AccountGroupDataGridViewTextBoxColumn.Name = "AccountGroupDataGridViewTextBoxColumn"
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'BlockedDataGridViewCheckBoxColumn
        '
        Me.BlockedDataGridViewCheckBoxColumn.DataPropertyName = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.HeaderText = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.Name = "BlockedDataGridViewCheckBoxColumn"
        '
        'TaxCodeDataGridViewTextBoxColumn
        '
        Me.TaxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.Name = "TaxCodeDataGridViewTextBoxColumn"
        '
        'PaymentTermsDataGridViewTextBoxColumn
        '
        Me.PaymentTermsDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerms"
        Me.PaymentTermsDataGridViewTextBoxColumn.HeaderText = "PaymentTerms"
        Me.PaymentTermsDataGridViewTextBoxColumn.Name = "PaymentTermsDataGridViewTextBoxColumn"
        '
        'CustomerBalanceDataGridViewTextBoxColumn
        '
        Me.CustomerBalanceDataGridViewTextBoxColumn.DataPropertyName = "CustomerBalance"
        Me.CustomerBalanceDataGridViewTextBoxColumn.HeaderText = "CustomerBalance"
        Me.CustomerBalanceDataGridViewTextBoxColumn.Name = "CustomerBalanceDataGridViewTextBoxColumn"
        '
        'AccTypeDataGridViewTextBoxColumn
        '
        Me.AccTypeDataGridViewTextBoxColumn.DataPropertyName = "AccType"
        Me.AccTypeDataGridViewTextBoxColumn.HeaderText = "AccType"
        Me.AccTypeDataGridViewTextBoxColumn.Name = "AccTypeDataGridViewTextBoxColumn"
        '
        'CustomerRefDataGridViewTextBoxColumn
        '
        Me.CustomerRefDataGridViewTextBoxColumn.DataPropertyName = "CustomerRef"
        Me.CustomerRefDataGridViewTextBoxColumn.HeaderText = "CustomerRef"
        Me.CustomerRefDataGridViewTextBoxColumn.Name = "CustomerRefDataGridViewTextBoxColumn"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.DsAccountsReceivable
        '
        'DsAccountsReceivable
        '
        Me.DsAccountsReceivable.DataSetName = "dsAccountsReceivable"
        Me.DsAccountsReceivable.EnforceConstraints = False
        Me.DsAccountsReceivable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox6)
        Me.TabPage7.Controls.Add(Me.ReportViewer1)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1058, 632)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Customers Statement"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.cboVenStatCurrentPeriod)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowReversals)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowPayments)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowInvoices)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(936, 33)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Statement Options"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(322, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 13)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "BBF CutOff"
        '
        'cboVenStatCurrentPeriod
        '
        Me.cboVenStatCurrentPeriod.FormattingEnabled = True
        Me.cboVenStatCurrentPeriod.Location = New System.Drawing.Point(388, 8)
        Me.cboVenStatCurrentPeriod.Name = "cboVenStatCurrentPeriod"
        Me.cboVenStatCurrentPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboVenStatCurrentPeriod.TabIndex = 3
        '
        'chkVenStatShowReversals
        '
        Me.chkVenStatShowReversals.AutoSize = True
        Me.chkVenStatShowReversals.Checked = True
        Me.chkVenStatShowReversals.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVenStatShowReversals.Location = New System.Drawing.Point(213, 10)
        Me.chkVenStatShowReversals.Name = "chkVenStatShowReversals"
        Me.chkVenStatShowReversals.Size = New System.Drawing.Size(103, 17)
        Me.chkVenStatShowReversals.TabIndex = 2
        Me.chkVenStatShowReversals.Text = "Show Reversals"
        Me.chkVenStatShowReversals.UseVisualStyleBackColor = True
        '
        'chkVenStatShowPayments
        '
        Me.chkVenStatShowPayments.AutoSize = True
        Me.chkVenStatShowPayments.Checked = True
        Me.chkVenStatShowPayments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVenStatShowPayments.Location = New System.Drawing.Point(105, 10)
        Me.chkVenStatShowPayments.Name = "chkVenStatShowPayments"
        Me.chkVenStatShowPayments.Size = New System.Drawing.Size(102, 17)
        Me.chkVenStatShowPayments.TabIndex = 1
        Me.chkVenStatShowPayments.Text = "Show Payments"
        Me.chkVenStatShowPayments.UseVisualStyleBackColor = True
        '
        'chkVenStatShowInvoices
        '
        Me.chkVenStatShowInvoices.AutoSize = True
        Me.chkVenStatShowInvoices.Checked = True
        Me.chkVenStatShowInvoices.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVenStatShowInvoices.Location = New System.Drawing.Point(3, 12)
        Me.chkVenStatShowInvoices.Name = "chkVenStatShowInvoices"
        Me.chkVenStatShowInvoices.Size = New System.Drawing.Size(96, 17)
        Me.chkVenStatShowInvoices.TabIndex = 0
        Me.chkVenStatShowInvoices.Text = "Show Invoices"
        Me.chkVenStatShowInvoices.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GLStatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptGLStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 51)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1043, 575)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnSearchVendor)
        Me.GroupBox1.Controls.Add(Me.txtCustomerSearch)
        Me.GroupBox1.Controls.Add(Me.lstResult)
        Me.GroupBox1.Controls.Add(Me.BindingNavigator5)
        Me.GroupBox1.Controls.Add(Me.ContactNameTextBox)
        Me.GroupBox1.Controls.Add(ContactNameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.AccNumberTextBox)
        Me.GroupBox1.Controls.Add(AccNumberLabel)
        Me.GroupBox1.Controls.Add(Me.TabControl2)
        Me.GroupBox1.Controls.Add(Me.CustomerRefTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 678)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(545, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 20)
        Me.Button3.TabIndex = 40
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSearchVendor
        '
        Me.btnSearchVendor.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnSearchVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchVendor.Location = New System.Drawing.Point(520, 44)
        Me.btnSearchVendor.Name = "btnSearchVendor"
        Me.btnSearchVendor.Size = New System.Drawing.Size(19, 20)
        Me.btnSearchVendor.TabIndex = 39
        Me.btnSearchVendor.UseVisualStyleBackColor = True
        '
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtCustomerSearch.Location = New System.Drawing.Point(363, 44)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtCustomerSearch.TabIndex = 37
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(363, 67)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(201, 69)
        Me.lstResult.TabIndex = 38
        Me.lstResult.Visible = False
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Me.ToolStripButton29
        Me.BindingNavigator5.BindingSource = Me.CustomersBindingSource
        Me.BindingNavigator5.CountItem = Me.ToolStripLabel5
        Me.BindingNavigator5.DeleteItem = Nothing
        Me.BindingNavigator5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripSeparator13, Me.ToolStripTextBox5, Me.ToolStripLabel5, Me.ToolStripSeparator14, Me.ToolStripButton32, Me.ToolStripButton33, Me.ToolStripSeparator15, Me.ToolStripButton29, Me.ToolStripButton34})
        Me.BindingNavigator5.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator5.MoveFirstItem = Me.ToolStripButton30
        Me.BindingNavigator5.MoveLastItem = Me.ToolStripButton33
        Me.BindingNavigator5.MoveNextItem = Me.ToolStripButton32
        Me.BindingNavigator5.MovePreviousItem = Me.ToolStripButton31
        Me.BindingNavigator5.Name = "BindingNavigator5"
        Me.BindingNavigator5.PositionItem = Me.ToolStripTextBox5
        Me.BindingNavigator5.Size = New System.Drawing.Size(571, 25)
        Me.BindingNavigator5.TabIndex = 36
        Me.BindingNavigator5.Text = "BindingNavigator5"
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.BackColor = System.Drawing.Color.Yellow
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton29.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton29.Text = "Add new"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel5.Text = "of {0}"
        Me.ToolStripLabel5.ToolTipText = "Total number of items"
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton30.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton30.Text = "Move first"
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton31.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton31.Text = "Move previous"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Position"
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Current position"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton32.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton32.Text = "Move next"
        '
        'ToolStripButton33
        '
        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton33.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton33.Text = "Move last"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton34
        '
        Me.ToolStripButton34.BackColor = System.Drawing.Color.Green
        Me.ToolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton34.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton34.Image = CType(resources.GetObject("ToolStripButton34.Image"), System.Drawing.Image)
        Me.ToolStripButton34.Name = "ToolStripButton34"
        Me.ToolStripButton34.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton34.Text = "Save Data"
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(110, 112)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(247, 20)
        Me.ContactNameTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(110, 89)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(247, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AccNumberTextBox
        '
        Me.AccNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "AccNumber", True))
        Me.AccNumberTextBox.Enabled = False
        Me.AccNumberTextBox.Location = New System.Drawing.Point(110, 64)
        Me.AccNumberTextBox.Name = "AccNumberTextBox"
        Me.AccNumberTextBox.ReadOnly = True
        Me.AccNumberTextBox.Size = New System.Drawing.Size(247, 20)
        Me.AccNumberTextBox.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TbCustContact)
        Me.TabControl2.Controls.Add(Me.tbCustTax)
        Me.TabControl2.Controls.Add(Me.tbCustPayment)
        Me.TabControl2.Controls.Add(Me.tbCustBankingDetails)
        Me.TabControl2.Controls.Add(Me.tbOthers)
        Me.TabControl2.Controls.Add(Me.tbCustNotes)
        Me.TabControl2.Location = New System.Drawing.Point(17, 142)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(554, 421)
        Me.TabControl2.TabIndex = 2
        '
        'TbCustContact
        '
        Me.TbCustContact.Controls.Add(ContactNumberLabel)
        Me.TbCustContact.Controls.Add(Me.ContactNumberTextBox)
        Me.TbCustContact.Controls.Add(EmailLabel)
        Me.TbCustContact.Controls.Add(Me.EmailTextBox)
        Me.TbCustContact.Controls.Add(AddressLabel)
        Me.TbCustContact.Controls.Add(Me.AddressTextBox)
        Me.TbCustContact.Controls.Add(CityLabel)
        Me.TbCustContact.Controls.Add(Me.CityTextBox)
        Me.TbCustContact.Controls.Add(CountryLabel)
        Me.TbCustContact.Controls.Add(Me.CountryTextBox)
        Me.TbCustContact.Location = New System.Drawing.Point(4, 22)
        Me.TbCustContact.Name = "TbCustContact"
        Me.TbCustContact.Padding = New System.Windows.Forms.Padding(3)
        Me.TbCustContact.Size = New System.Drawing.Size(546, 395)
        Me.TbCustContact.TabIndex = 0
        Me.TbCustContact.Text = "Contact Details"
        Me.TbCustContact.UseVisualStyleBackColor = True
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(108, 9)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ContactNumberTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(108, 35)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EmailTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(108, 61)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(121, 54)
        Me.AddressTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(108, 121)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CityTextBox.TabIndex = 3
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(108, 147)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CountryTextBox.TabIndex = 4
        '
        'tbCustTax
        '
        Me.tbCustTax.Controls.Add(Label3)
        Me.tbCustTax.Controls.Add(Me.cboCustVatAccount)
        Me.tbCustTax.Controls.Add(TaxRegLabel)
        Me.tbCustTax.Controls.Add(Me.TaxRegTextBox)
        Me.tbCustTax.Controls.Add(TaxCodeLabel)
        Me.tbCustTax.Controls.Add(Me.TaxCodeComboBox)
        Me.tbCustTax.Location = New System.Drawing.Point(4, 22)
        Me.tbCustTax.Name = "tbCustTax"
        Me.tbCustTax.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustTax.Size = New System.Drawing.Size(546, 395)
        Me.tbCustTax.TabIndex = 2
        Me.tbCustTax.Text = "VAT Info "
        Me.tbCustTax.UseVisualStyleBackColor = True
        '
        'cboCustVatAccount
        '
        Me.cboCustVatAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "VatAccountName", True))
        Me.cboCustVatAccount.FormattingEnabled = True
        Me.cboCustVatAccount.Location = New System.Drawing.Point(89, 83)
        Me.cboCustVatAccount.Name = "cboCustVatAccount"
        Me.cboCustVatAccount.Size = New System.Drawing.Size(193, 21)
        Me.cboCustVatAccount.TabIndex = 30
        '
        'TaxRegTextBox
        '
        Me.TaxRegTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "TaxReg", True))
        Me.TaxRegTextBox.Location = New System.Drawing.Point(89, 22)
        Me.TaxRegTextBox.Name = "TaxRegTextBox"
        Me.TaxRegTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TaxRegTextBox.TabIndex = 5
        '
        'TaxCodeComboBox
        '
        Me.TaxCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "TaxDescription", True))
        Me.TaxCodeComboBox.FormattingEnabled = True
        Me.TaxCodeComboBox.Location = New System.Drawing.Point(89, 49)
        Me.TaxCodeComboBox.Name = "TaxCodeComboBox"
        Me.TaxCodeComboBox.Size = New System.Drawing.Size(193, 21)
        Me.TaxCodeComboBox.TabIndex = 6
        '
        'tbCustPayment
        '
        Me.tbCustPayment.Controls.Add(CustomerBalanceLabel)
        Me.tbCustPayment.Controls.Add(Me.CustomerBalanceTextBox)
        Me.tbCustPayment.Controls.Add(PaymentTermsLabel)
        Me.tbCustPayment.Controls.Add(Me.PaymentTermsComboBox)
        Me.tbCustPayment.Controls.Add(Me.CurrencyComboBox)
        Me.tbCustPayment.Controls.Add(CurrencyLabel)
        Me.tbCustPayment.Location = New System.Drawing.Point(4, 22)
        Me.tbCustPayment.Name = "tbCustPayment"
        Me.tbCustPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustPayment.Size = New System.Drawing.Size(546, 395)
        Me.tbCustPayment.TabIndex = 3
        Me.tbCustPayment.Text = "Payments&Billing"
        Me.tbCustPayment.UseVisualStyleBackColor = True
        '
        'CustomerBalanceTextBox
        '
        Me.CustomerBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerBalance", True))
        Me.CustomerBalanceTextBox.Enabled = False
        Me.CustomerBalanceTextBox.Location = New System.Drawing.Point(108, 43)
        Me.CustomerBalanceTextBox.Name = "CustomerBalanceTextBox"
        Me.CustomerBalanceTextBox.ReadOnly = True
        Me.CustomerBalanceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CustomerBalanceTextBox.TabIndex = 1
        Me.CustomerBalanceTextBox.TabStop = False
        '
        'PaymentTermsComboBox
        '
        Me.PaymentTermsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "PayTermDescription", True))
        Me.PaymentTermsComboBox.FormattingEnabled = True
        Me.PaymentTermsComboBox.Location = New System.Drawing.Point(108, 16)
        Me.PaymentTermsComboBox.Name = "PaymentTermsComboBox"
        Me.PaymentTermsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentTermsComboBox.TabIndex = 7
        '
        'CurrencyComboBox
        '
        Me.CurrencyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Currency", True))
        Me.CurrencyComboBox.FormattingEnabled = True
        Me.CurrencyComboBox.Location = New System.Drawing.Point(108, 69)
        Me.CurrencyComboBox.Name = "CurrencyComboBox"
        Me.CurrencyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CurrencyComboBox.TabIndex = 8
        '
        'tbCustBankingDetails
        '
        Me.tbCustBankingDetails.AutoScroll = True
        Me.tbCustBankingDetails.Controls.Add(BankDetailsLabel)
        Me.tbCustBankingDetails.Controls.Add(Me.BankDetailsTextBox)
        Me.tbCustBankingDetails.Location = New System.Drawing.Point(4, 22)
        Me.tbCustBankingDetails.Name = "tbCustBankingDetails"
        Me.tbCustBankingDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustBankingDetails.Size = New System.Drawing.Size(546, 395)
        Me.tbCustBankingDetails.TabIndex = 4
        Me.tbCustBankingDetails.Text = "Banking"
        Me.tbCustBankingDetails.UseVisualStyleBackColor = True
        '
        'BankDetailsTextBox
        '
        Me.BankDetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "BankDetails", True))
        Me.BankDetailsTextBox.Location = New System.Drawing.Point(88, 17)
        Me.BankDetailsTextBox.Multiline = True
        Me.BankDetailsTextBox.Name = "BankDetailsTextBox"
        Me.BankDetailsTextBox.Size = New System.Drawing.Size(364, 181)
        Me.BankDetailsTextBox.TabIndex = 9
        '
        'tbOthers
        '
        Me.tbOthers.Controls.Add(CustomerCompanyLabel)
        Me.tbOthers.Controls.Add(Me.CustomerCompanyComboBox)
        Me.tbOthers.Controls.Add(BlockedLabel)
        Me.tbOthers.Controls.Add(Me.BlockedCheckBox)
        Me.tbOthers.Location = New System.Drawing.Point(4, 22)
        Me.tbOthers.Name = "tbOthers"
        Me.tbOthers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOthers.Size = New System.Drawing.Size(546, 395)
        Me.tbOthers.TabIndex = 5
        Me.tbOthers.Text = "Others"
        Me.tbOthers.UseVisualStyleBackColor = True
        '
        'CustomerCompanyComboBox
        '
        Me.CustomerCompanyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CompanyName", True))
        Me.CustomerCompanyComboBox.FormattingEnabled = True
        Me.CustomerCompanyComboBox.Location = New System.Drawing.Point(113, 25)
        Me.CustomerCompanyComboBox.Name = "CustomerCompanyComboBox"
        Me.CustomerCompanyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CustomerCompanyComboBox.TabIndex = 10
        '
        'BlockedCheckBox
        '
        Me.BlockedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustomersBindingSource, "Blocked", True))
        Me.BlockedCheckBox.Location = New System.Drawing.Point(113, 54)
        Me.BlockedCheckBox.Name = "BlockedCheckBox"
        Me.BlockedCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.BlockedCheckBox.TabIndex = 12
        Me.BlockedCheckBox.UseVisualStyleBackColor = True
        '
        'tbCustNotes
        '
        Me.tbCustNotes.Controls.Add(NotesLabel)
        Me.tbCustNotes.Controls.Add(Me.NotesTextBox)
        Me.tbCustNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbCustNotes.Name = "tbCustNotes"
        Me.tbCustNotes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustNotes.Size = New System.Drawing.Size(546, 395)
        Me.tbCustNotes.TabIndex = 1
        Me.tbCustNotes.Text = "Notes"
        Me.tbCustNotes.UseVisualStyleBackColor = True
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(50, 6)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(319, 244)
        Me.NotesTextBox.TabIndex = 12
        '
        'CustomerRefTextBox
        '
        Me.CustomerRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerRef", True))
        Me.CustomerRefTextBox.Location = New System.Drawing.Point(17, 569)
        Me.CustomerRefTextBox.Name = "CustomerRefTextBox"
        Me.CustomerRefTextBox.Size = New System.Drawing.Size(554, 20)
        Me.CustomerRefTextBox.TabIndex = 12
        '
        'tbCustomerInvoice
        '
        Me.tbCustomerInvoice.Controls.Add(Me.GroupBox7)
        Me.tbCustomerInvoice.Location = New System.Drawing.Point(4, 22)
        Me.tbCustomerInvoice.Name = "tbCustomerInvoice"
        Me.tbCustomerInvoice.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustomerInvoice.Size = New System.Drawing.Size(1678, 698)
        Me.tbCustomerInvoice.TabIndex = 1
        Me.tbCustomerInvoice.Text = "Customer Invoice"
        Me.tbCustomerInvoice.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.gbCustomerInvoice)
        Me.GroupBox7.Controls.Add(Me.gbFeesPay)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1662, 686)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Invoice"
        '
        'gbCustomerInvoice
        '
        Me.gbCustomerInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCustomerInvoice.Controls.Add(Me.GroupBox9)
        Me.gbCustomerInvoice.Controls.Add(Me.gbInvoiceOptions)
        Me.gbCustomerInvoice.Controls.Add(Me.dgVendorInvoices)
        Me.gbCustomerInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCustomerInvoice.Location = New System.Drawing.Point(6, 211)
        Me.gbCustomerInvoice.Name = "gbCustomerInvoice"
        Me.gbCustomerInvoice.Size = New System.Drawing.Size(1558, 469)
        Me.gbCustomerInvoice.TabIndex = 47
        Me.gbCustomerInvoice.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Label36)
        Me.GroupBox9.Controls.Add(Me.btnCustInvoiceRefeesh)
        Me.GroupBox9.Controls.Add(Me.btnCustInvoiceSearch)
        Me.GroupBox9.Controls.Add(Me.txtCustInvoiceSearchh)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(263, 32)
        Me.GroupBox9.TabIndex = 46
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Search"
        '
        'btnCustInvoiceRefeesh
        '
        Me.btnCustInvoiceRefeesh.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.btnCustInvoiceRefeesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustInvoiceRefeesh.Location = New System.Drawing.Point(238, 8)
        Me.btnCustInvoiceRefeesh.Name = "btnCustInvoiceRefeesh"
        Me.btnCustInvoiceRefeesh.Size = New System.Drawing.Size(19, 20)
        Me.btnCustInvoiceRefeesh.TabIndex = 75
        Me.btnCustInvoiceRefeesh.UseVisualStyleBackColor = True
        '
        'btnCustInvoiceSearch
        '
        Me.btnCustInvoiceSearch.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnCustInvoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustInvoiceSearch.Location = New System.Drawing.Point(219, 8)
        Me.btnCustInvoiceSearch.Name = "btnCustInvoiceSearch"
        Me.btnCustInvoiceSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnCustInvoiceSearch.TabIndex = 74
        Me.btnCustInvoiceSearch.UseVisualStyleBackColor = True
        '
        'txtCustInvoiceSearchh
        '
        Me.txtCustInvoiceSearchh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCustInvoiceSearchh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtCustInvoiceSearchh.Location = New System.Drawing.Point(56, 8)
        Me.txtCustInvoiceSearchh.Name = "txtCustInvoiceSearchh"
        Me.txtCustInvoiceSearchh.Size = New System.Drawing.Size(157, 20)
        Me.txtCustInvoiceSearchh.TabIndex = 73
        '
        'gbInvoiceOptions
        '
        Me.gbInvoiceOptions.Controls.Add(Me.chkDisplayCncelledInvoices)
        Me.gbInvoiceOptions.Location = New System.Drawing.Point(275, 8)
        Me.gbInvoiceOptions.Name = "gbInvoiceOptions"
        Me.gbInvoiceOptions.Size = New System.Drawing.Size(253, 36)
        Me.gbInvoiceOptions.TabIndex = 3
        Me.gbInvoiceOptions.TabStop = False
        '
        'chkDisplayCncelledInvoices
        '
        Me.chkDisplayCncelledInvoices.AutoSize = True
        Me.chkDisplayCncelledInvoices.Location = New System.Drawing.Point(6, 13)
        Me.chkDisplayCncelledInvoices.Name = "chkDisplayCncelledInvoices"
        Me.chkDisplayCncelledInvoices.Size = New System.Drawing.Size(146, 17)
        Me.chkDisplayCncelledInvoices.TabIndex = 65
        Me.chkDisplayCncelledInvoices.Text = "Show Cancelled Invoices"
        Me.chkDisplayCncelledInvoices.UseVisualStyleBackColor = True
        '
        'dgVendorInvoices
        '
        Me.dgVendorInvoices.AllowUserToAddRows = False
        Me.dgVendorInvoices.AllowUserToDeleteRows = False
        Me.dgVendorInvoices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgVendorInvoices.AutoGenerateColumns = False
        Me.dgVendorInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVendorInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.colCustInvVendor, Me.InvDocNumberDataGridViewTextBoxColumn, Me.colInvNumber, Me.InvAmountDataGridViewTextBoxColumn, Me.InvBalanceDataGridViewTextBoxColumn, Me.VatAmountDataGridViewTextBoxColumn, Me.colInvCurrency, Me.InvDateDataGridViewTextBoxColumn, Me.InvDueDateDataGridViewTextBoxColumn, Me.InvNotesDataGridViewTextBoxColumn, Me.InvCartegoryDataGridViewTextBoxColumn, Me.colInvTransType, Me.PeriodDataGridViewTextBoxColumn, Me.InvPostDateDataGridViewTextBoxColumn, Me.InvClearedDataGridViewCheckBoxColumn, Me.colInvRef, Me.InvPostedByDataGridViewTextBoxColumn, Me.ColInvActive, Me.InvPaymentRefDataGridViewTextBoxColumn, Me.InvDocDataGridViewImageColumn, Me.InvBankAccountDataGridViewTextBoxColumn, Me.InvCompanyDataGridViewTextBoxColumn, Me.colVatCode, Me.btnView, Me.btnEditInvoice, Me.btnCancelInvoice, Me.btnDelete})
        Me.dgVendorInvoices.DataSource = Me.CustomerTransactionsBindingSource
        Me.dgVendorInvoices.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgVendorInvoices.Location = New System.Drawing.Point(6, 50)
        Me.dgVendorInvoices.Name = "dgVendorInvoices"
        Me.dgVendorInvoices.ReadOnly = True
        Me.dgVendorInvoices.Size = New System.Drawing.Size(1546, 413)
        Me.dgVendorInvoices.TabIndex = 4
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Vendorr"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'colCustInvVendor
        '
        Me.colCustInvVendor.DataPropertyName = "CustAccNumber"
        Me.colCustInvVendor.HeaderText = "VendorAcc"
        Me.colCustInvVendor.Name = "colCustInvVendor"
        Me.colCustInvVendor.ReadOnly = True
        Me.colCustInvVendor.Visible = False
        '
        'InvDocNumberDataGridViewTextBoxColumn
        '
        Me.InvDocNumberDataGridViewTextBoxColumn.DataPropertyName = "InvDocNumber"
        Me.InvDocNumberDataGridViewTextBoxColumn.HeaderText = "DocumentNumber"
        Me.InvDocNumberDataGridViewTextBoxColumn.Name = "InvDocNumberDataGridViewTextBoxColumn"
        Me.InvDocNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colInvNumber
        '
        Me.colInvNumber.DataPropertyName = "InvoiceNumber"
        Me.colInvNumber.HeaderText = "PostedDocument"
        Me.colInvNumber.Name = "colInvNumber"
        Me.colInvNumber.ReadOnly = True
        '
        'InvAmountDataGridViewTextBoxColumn
        '
        Me.InvAmountDataGridViewTextBoxColumn.DataPropertyName = "InvConvAmount"
        Me.InvAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.InvAmountDataGridViewTextBoxColumn.Name = "InvAmountDataGridViewTextBoxColumn"
        Me.InvAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvBalanceDataGridViewTextBoxColumn
        '
        Me.InvBalanceDataGridViewTextBoxColumn.DataPropertyName = "InvBalance"
        Me.InvBalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.InvBalanceDataGridViewTextBoxColumn.Name = "InvBalanceDataGridViewTextBoxColumn"
        Me.InvBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VatAmountDataGridViewTextBoxColumn
        '
        Me.VatAmountDataGridViewTextBoxColumn.DataPropertyName = "VatAmount"
        Me.VatAmountDataGridViewTextBoxColumn.HeaderText = "VatAmount"
        Me.VatAmountDataGridViewTextBoxColumn.Name = "VatAmountDataGridViewTextBoxColumn"
        Me.VatAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colInvCurrency
        '
        Me.colInvCurrency.DataPropertyName = "InvCurrency"
        Me.colInvCurrency.HeaderText = "Currency"
        Me.colInvCurrency.Name = "colInvCurrency"
        Me.colInvCurrency.ReadOnly = True
        '
        'InvDateDataGridViewTextBoxColumn
        '
        Me.InvDateDataGridViewTextBoxColumn.DataPropertyName = "InvDate"
        Me.InvDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.InvDateDataGridViewTextBoxColumn.Name = "InvDateDataGridViewTextBoxColumn"
        Me.InvDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvDueDateDataGridViewTextBoxColumn
        '
        Me.InvDueDateDataGridViewTextBoxColumn.DataPropertyName = "InvDueDate"
        Me.InvDueDateDataGridViewTextBoxColumn.HeaderText = "DueDate"
        Me.InvDueDateDataGridViewTextBoxColumn.Name = "InvDueDateDataGridViewTextBoxColumn"
        Me.InvDueDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvNotesDataGridViewTextBoxColumn
        '
        Me.InvNotesDataGridViewTextBoxColumn.DataPropertyName = "InvNotes"
        Me.InvNotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.InvNotesDataGridViewTextBoxColumn.Name = "InvNotesDataGridViewTextBoxColumn"
        Me.InvNotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvCartegoryDataGridViewTextBoxColumn
        '
        Me.InvCartegoryDataGridViewTextBoxColumn.DataPropertyName = "InvCartegory"
        Me.InvCartegoryDataGridViewTextBoxColumn.HeaderText = "Cartegory"
        Me.InvCartegoryDataGridViewTextBoxColumn.Name = "InvCartegoryDataGridViewTextBoxColumn"
        Me.InvCartegoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colInvTransType
        '
        Me.colInvTransType.DataPropertyName = "InvTransType"
        Me.colInvTransType.HeaderText = "TransType"
        Me.colInvTransType.Name = "colInvTransType"
        Me.colInvTransType.ReadOnly = True
        Me.colInvTransType.Visible = False
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodDataGridViewTextBoxColumn.Visible = False
        '
        'InvPostDateDataGridViewTextBoxColumn
        '
        Me.InvPostDateDataGridViewTextBoxColumn.DataPropertyName = "InvPostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.HeaderText = "InvPostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.Name = "InvPostDateDataGridViewTextBoxColumn"
        Me.InvPostDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPostDateDataGridViewTextBoxColumn.Visible = False
        '
        'InvClearedDataGridViewCheckBoxColumn
        '
        Me.InvClearedDataGridViewCheckBoxColumn.DataPropertyName = "InvCleared"
        Me.InvClearedDataGridViewCheckBoxColumn.HeaderText = "InvCleared"
        Me.InvClearedDataGridViewCheckBoxColumn.Name = "InvClearedDataGridViewCheckBoxColumn"
        Me.InvClearedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.InvClearedDataGridViewCheckBoxColumn.Visible = False
        '
        'colInvRef
        '
        Me.colInvRef.DataPropertyName = "InvRef"
        Me.colInvRef.HeaderText = "InvRef"
        Me.colInvRef.Name = "colInvRef"
        Me.colInvRef.ReadOnly = True
        Me.colInvRef.Visible = False
        '
        'InvPostedByDataGridViewTextBoxColumn
        '
        Me.InvPostedByDataGridViewTextBoxColumn.DataPropertyName = "InvPostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.HeaderText = "InvPostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.Name = "InvPostedByDataGridViewTextBoxColumn"
        Me.InvPostedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPostedByDataGridViewTextBoxColumn.Visible = False
        '
        'ColInvActive
        '
        Me.ColInvActive.DataPropertyName = "InvActive"
        Me.ColInvActive.HeaderText = "InvActive"
        Me.ColInvActive.Name = "ColInvActive"
        Me.ColInvActive.ReadOnly = True
        Me.ColInvActive.Visible = False
        '
        'InvPaymentRefDataGridViewTextBoxColumn
        '
        Me.InvPaymentRefDataGridViewTextBoxColumn.DataPropertyName = "InvPaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.HeaderText = "InvPaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.Name = "InvPaymentRefDataGridViewTextBoxColumn"
        Me.InvPaymentRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPaymentRefDataGridViewTextBoxColumn.Visible = False
        '
        'InvDocDataGridViewImageColumn
        '
        Me.InvDocDataGridViewImageColumn.DataPropertyName = "InvDoc"
        Me.InvDocDataGridViewImageColumn.HeaderText = "InvDoc"
        Me.InvDocDataGridViewImageColumn.Name = "InvDocDataGridViewImageColumn"
        Me.InvDocDataGridViewImageColumn.ReadOnly = True
        Me.InvDocDataGridViewImageColumn.Visible = False
        '
        'InvBankAccountDataGridViewTextBoxColumn
        '
        Me.InvBankAccountDataGridViewTextBoxColumn.DataPropertyName = "InvBankAccount"
        Me.InvBankAccountDataGridViewTextBoxColumn.HeaderText = "InvBankAccount"
        Me.InvBankAccountDataGridViewTextBoxColumn.Name = "InvBankAccountDataGridViewTextBoxColumn"
        Me.InvBankAccountDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvBankAccountDataGridViewTextBoxColumn.Visible = False
        '
        'InvCompanyDataGridViewTextBoxColumn
        '
        Me.InvCompanyDataGridViewTextBoxColumn.DataPropertyName = "InvCompany"
        Me.InvCompanyDataGridViewTextBoxColumn.HeaderText = "InvCompany"
        Me.InvCompanyDataGridViewTextBoxColumn.Name = "InvCompanyDataGridViewTextBoxColumn"
        Me.InvCompanyDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvCompanyDataGridViewTextBoxColumn.Visible = False
        '
        'colVatCode
        '
        Me.colVatCode.DataPropertyName = "VatCode"
        Me.colVatCode.HeaderText = "VatCode"
        Me.colVatCode.Name = "colVatCode"
        Me.colVatCode.ReadOnly = True
        Me.colVatCode.Visible = False
        '
        'btnView
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.btnView.DefaultCellStyle = DataGridViewCellStyle4
        Me.btnView.HeaderText = ""
        Me.btnView.Name = "btnView"
        Me.btnView.ReadOnly = True
        Me.btnView.Text = "View"
        Me.btnView.UseColumnTextForButtonValue = True
        '
        'btnEditInvoice
        '
        Me.btnEditInvoice.HeaderText = ""
        Me.btnEditInvoice.Name = "btnEditInvoice"
        Me.btnEditInvoice.ReadOnly = True
        Me.btnEditInvoice.Text = "Edit"
        Me.btnEditInvoice.ToolTipText = "Edit Invoice"
        Me.btnEditInvoice.UseColumnTextForButtonValue = True
        '
        'btnCancelInvoice
        '
        Me.btnCancelInvoice.HeaderText = ""
        Me.btnCancelInvoice.Name = "btnCancelInvoice"
        Me.btnCancelInvoice.ReadOnly = True
        Me.btnCancelInvoice.Text = "Reverse"
        Me.btnCancelInvoice.ToolTipText = "Cancel Invoice"
        Me.btnCancelInvoice.UseColumnTextForButtonValue = True
        '
        'btnDelete
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle5
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Text = "DebitMemo"
        Me.btnDelete.ToolTipText = "Adjust Invoice"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'CustomerTransactionsBindingSource
        '
        Me.CustomerTransactionsBindingSource.DataMember = "CustomerTransactions"
        Me.CustomerTransactionsBindingSource.DataSource = Me.DsAccountsReceivable
        '
        'gbFeesPay
        '
        Me.gbFeesPay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFeesPay.Controls.Add(Me.cboInvoiceCompany)
        Me.gbFeesPay.Controls.Add(Label4)
        Me.gbFeesPay.Controls.Add(Me.cboInvoiceCustomer)
        Me.gbFeesPay.Controls.Add(Me.GroupBox4)
        Me.gbFeesPay.Controls.Add(StudentIDLabel1)
        Me.gbFeesPay.Location = New System.Drawing.Point(6, 19)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(1545, 184)
        Me.gbFeesPay.TabIndex = 0
        Me.gbFeesPay.TabStop = False
        '
        'cboInvoiceCompany
        '
        Me.cboInvoiceCompany.DisplayMember = "Name"
        Me.cboInvoiceCompany.FormattingEnabled = True
        Me.cboInvoiceCompany.Location = New System.Drawing.Point(66, 13)
        Me.cboInvoiceCompany.Name = "cboInvoiceCompany"
        Me.cboInvoiceCompany.Size = New System.Drawing.Size(200, 21)
        Me.cboInvoiceCompany.TabIndex = 0
        Me.cboInvoiceCompany.ValueMember = "AccNumber"
        '
        'cboInvoiceCustomer
        '
        Me.cboInvoiceCustomer.DisplayMember = "Name"
        Me.cboInvoiceCustomer.FormattingEnabled = True
        Me.cboInvoiceCustomer.Location = New System.Drawing.Point(66, 41)
        Me.cboInvoiceCustomer.Name = "cboInvoiceCustomer"
        Me.cboInvoiceCustomer.Size = New System.Drawing.Size(200, 21)
        Me.cboInvoiceCustomer.TabIndex = 1
        Me.cboInvoiceCustomer.ValueMember = "AccNumber"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbNetAmount)
        Me.GroupBox4.Controls.Add(Me.txtNetAmount)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtVatAmount)
        Me.GroupBox4.Controls.Add(Me.cboCustVatcode)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lbInvPath)
        Me.GroupBox4.Controls.Add(Me.mskInvDate)
        Me.GroupBox4.Controls.Add(Me.mskInvDueDate)
        Me.GroupBox4.Controls.Add(Me.cboInvCurrency)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.txtInvNotes)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtInvNumber)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cboInvPeriod)
        Me.GroupBox4.Controls.Add(Me.txtInvAmnt)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cboInvCartegory)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1381, 105)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enter Invoice Details"
        '
        'lbNetAmount
        '
        Me.lbNetAmount.AutoSize = True
        Me.lbNetAmount.Location = New System.Drawing.Point(548, 16)
        Me.lbNetAmount.Name = "lbNetAmount"
        Me.lbNetAmount.Size = New System.Drawing.Size(101, 13)
        Me.lbNetAmount.TabIndex = 80
        Me.lbNetAmount.Text = "Amount Before Tax:"
        '
        'txtNetAmount
        '
        Me.txtNetAmount.Enabled = False
        Me.txtNetAmount.Location = New System.Drawing.Point(548, 32)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtNetAmount.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(446, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Vat Amount:"
        '
        'txtVatAmount
        '
        Me.txtVatAmount.Enabled = False
        Me.txtVatAmount.Location = New System.Drawing.Point(446, 33)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.ReadOnly = True
        Me.txtVatAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtVatAmount.TabIndex = 4
        '
        'cboCustVatcode
        '
        Me.cboCustVatcode.FormattingEnabled = True
        Me.cboCustVatcode.Location = New System.Drawing.Point(344, 32)
        Me.cboCustVatcode.Name = "cboCustVatcode"
        Me.cboCustVatcode.Size = New System.Drawing.Size(96, 21)
        Me.cboCustVatcode.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Vat Code:"
        '
        'lbInvPath
        '
        Me.lbInvPath.AutoSize = True
        Me.lbInvPath.BackColor = System.Drawing.Color.Yellow
        Me.lbInvPath.Location = New System.Drawing.Point(905, 55)
        Me.lbInvPath.Name = "lbInvPath"
        Me.lbInvPath.Size = New System.Drawing.Size(0, 13)
        Me.lbInvPath.TabIndex = 74
        '
        'mskInvDate
        '
        Me.mskInvDate.Location = New System.Drawing.Point(829, 33)
        Me.mskInvDate.Mask = "00/00/0000"
        Me.mskInvDate.Name = "mskInvDate"
        Me.mskInvDate.Size = New System.Drawing.Size(100, 20)
        Me.mskInvDate.TabIndex = 8
        Me.mskInvDate.ValidatingType = GetType(Date)
        '
        'mskInvDueDate
        '
        Me.mskInvDueDate.Location = New System.Drawing.Point(930, 33)
        Me.mskInvDueDate.Mask = "00/00/0000"
        Me.mskInvDueDate.Name = "mskInvDueDate"
        Me.mskInvDueDate.Size = New System.Drawing.Size(100, 20)
        Me.mskInvDueDate.TabIndex = 9
        Me.mskInvDueDate.ValidatingType = GetType(Date)
        '
        'cboInvCurrency
        '
        Me.cboInvCurrency.FormattingEnabled = True
        Me.cboInvCurrency.Location = New System.Drawing.Point(654, 32)
        Me.cboInvCurrency.Name = "cboInvCurrency"
        Me.cboInvCurrency.Size = New System.Drawing.Size(77, 21)
        Me.cboInvCurrency.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(651, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Currency:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1250, 65)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 34)
        Me.Button2.TabIndex = 11
        Me.Button2.Tag = " "
        Me.Button2.Text = "Save Invoice"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtInvNotes
        '
        Me.txtInvNotes.Location = New System.Drawing.Point(1045, 30)
        Me.txtInvNotes.Multiline = True
        Me.txtInvNotes.Name = "txtInvNotes"
        Me.txtInvNotes.Size = New System.Drawing.Size(199, 69)
        Me.txtInvNotes.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1042, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Notes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(930, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Due Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Document Number:"
        '
        'txtInvNumber
        '
        Me.txtInvNumber.Location = New System.Drawing.Point(9, 32)
        Me.txtInvNumber.Name = "txtInvNumber"
        Me.txtInvNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInvNumber.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(829, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Invoice Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(238, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Amount:"
        '
        'cboInvPeriod
        '
        Me.cboInvPeriod.FormattingEnabled = True
        Me.cboInvPeriod.Location = New System.Drawing.Point(732, 32)
        Me.cboInvPeriod.Name = "cboInvPeriod"
        Me.cboInvPeriod.Size = New System.Drawing.Size(96, 21)
        Me.cboInvPeriod.TabIndex = 7
        '
        'txtInvAmnt
        '
        Me.txtInvAmnt.Location = New System.Drawing.Point(238, 32)
        Me.txtInvAmnt.Name = "txtInvAmnt"
        Me.txtInvAmnt.Size = New System.Drawing.Size(100, 20)
        Me.txtInvAmnt.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(732, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Period:"
        '
        'cboInvCartegory
        '
        Me.cboInvCartegory.FormattingEnabled = True
        Me.cboInvCartegory.Location = New System.Drawing.Point(110, 31)
        Me.cboInvCartegory.Name = "cboInvCartegory"
        Me.cboInvCartegory.Size = New System.Drawing.Size(126, 21)
        Me.cboInvCartegory.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(110, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Cartegory:"
        '
        'tbCustomerPayment
        '
        Me.tbCustomerPayment.Controls.Add(Me.GroupBox3)
        Me.tbCustomerPayment.Location = New System.Drawing.Point(4, 22)
        Me.tbCustomerPayment.Name = "tbCustomerPayment"
        Me.tbCustomerPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCustomerPayment.Size = New System.Drawing.Size(1678, 698)
        Me.tbCustomerPayment.TabIndex = 2
        Me.tbCustomerPayment.Text = "Customer Payment"
        Me.tbCustomerPayment.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.pnlInvoicedPayment)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1654, 682)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payments"
        '
        'pnlInvoicedPayment
        '
        Me.pnlInvoicedPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlInvoicedPayment.Controls.Add(Me.GroupBox8)
        Me.pnlInvoicedPayment.Controls.Add(Me.GroupBox10)
        Me.pnlInvoicedPayment.Controls.Add(Me.Label27)
        Me.pnlInvoicedPayment.Controls.Add(Me.dgPayInvoice)
        Me.pnlInvoicedPayment.Controls.Add(Me.Button4)
        Me.pnlInvoicedPayment.Location = New System.Drawing.Point(6, 289)
        Me.pnlInvoicedPayment.Name = "pnlInvoicedPayment"
        Me.pnlInvoicedPayment.Size = New System.Drawing.Size(1371, 387)
        Me.pnlInvoicedPayment.TabIndex = 7
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Label6)
        Me.GroupBox8.Controls.Add(Me.btnCustomerPaySearchRefresh)
        Me.GroupBox8.Controls.Add(Me.btnCustomerPaySearch)
        Me.GroupBox8.Controls.Add(Me.txtCustomerPaySearch)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(263, 32)
        Me.GroupBox8.TabIndex = 48
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Search"
        '
        'btnCustomerPaySearchRefresh
        '
        Me.btnCustomerPaySearchRefresh.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.btnCustomerPaySearchRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerPaySearchRefresh.Location = New System.Drawing.Point(238, 8)
        Me.btnCustomerPaySearchRefresh.Name = "btnCustomerPaySearchRefresh"
        Me.btnCustomerPaySearchRefresh.Size = New System.Drawing.Size(19, 20)
        Me.btnCustomerPaySearchRefresh.TabIndex = 75
        Me.btnCustomerPaySearchRefresh.UseVisualStyleBackColor = True
        '
        'btnCustomerPaySearch
        '
        Me.btnCustomerPaySearch.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnCustomerPaySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomerPaySearch.Location = New System.Drawing.Point(219, 8)
        Me.btnCustomerPaySearch.Name = "btnCustomerPaySearch"
        Me.btnCustomerPaySearch.Size = New System.Drawing.Size(19, 20)
        Me.btnCustomerPaySearch.TabIndex = 74
        Me.btnCustomerPaySearch.UseVisualStyleBackColor = True
        '
        'txtCustomerPaySearch
        '
        Me.txtCustomerPaySearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtCustomerPaySearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtCustomerPaySearch.Location = New System.Drawing.Point(56, 8)
        Me.txtCustomerPaySearch.Name = "txtCustomerPaySearch"
        Me.txtCustomerPaySearch.Size = New System.Drawing.Size(157, 20)
        Me.txtCustomerPaySearch.TabIndex = 73
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.chkShowPayments)
        Me.GroupBox10.Location = New System.Drawing.Point(357, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(253, 32)
        Me.GroupBox10.TabIndex = 47
        Me.GroupBox10.TabStop = False
        '
        'chkShowPayments
        '
        Me.chkShowPayments.AutoSize = True
        Me.chkShowPayments.Location = New System.Drawing.Point(6, 13)
        Me.chkShowPayments.Name = "chkShowPayments"
        Me.chkShowPayments.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPayments.TabIndex = 65
        Me.chkShowPayments.Text = "Show Payments"
        Me.chkShowPayments.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(984, 22)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 13)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Select invoices to pay"
        '
        'dgPayInvoice
        '
        Me.dgPayInvoice.AllowUserToAddRows = False
        Me.dgPayInvoice.AllowUserToDeleteRows = False
        Me.dgPayInvoice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPayInvoice.AutoGenerateColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayInvoice.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgPayInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkPayInvoice, Me.Customer, Me.ColPayCustomerAcc, Me.ColCustInvNumber, Me.colCustInvCartegory, Me.InvConvAmount, Me.InvBalanceDataGridViewTextBoxColumn1, Me.colInvPayCurrency, Me.ColCustInvRef, Me.colInvPayAmnt, Me.colPayDocNumber, Me.colPayNotes, Me.colInvPayTransType, Me.btnPayView, Me.btnPayEdit})
        Me.dgPayInvoice.DataSource = Me.CustomerTransactionsBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPayInvoice.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgPayInvoice.Location = New System.Drawing.Point(3, 37)
        Me.dgPayInvoice.Name = "dgPayInvoice"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayInvoice.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgPayInvoice.Size = New System.Drawing.Size(1348, 311)
        Me.dgPayInvoice.TabIndex = 1
        '
        'chkPayInvoice
        '
        Me.chkPayInvoice.HeaderText = "Pay Invoice"
        Me.chkPayInvoice.Name = "chkPayInvoice"
        '
        'Customer
        '
        Me.Customer.DataPropertyName = "Description"
        Me.Customer.HeaderText = "Customer"
        Me.Customer.Name = "Customer"
        '
        'ColPayCustomerAcc
        '
        Me.ColPayCustomerAcc.DataPropertyName = "CustAccNumber"
        Me.ColPayCustomerAcc.HeaderText = "CustomerAcc"
        Me.ColPayCustomerAcc.Name = "ColPayCustomerAcc"
        Me.ColPayCustomerAcc.Visible = False
        '
        'ColCustInvNumber
        '
        Me.ColCustInvNumber.DataPropertyName = "InvoiceNumber"
        Me.ColCustInvNumber.HeaderText = "InvoiceNumber"
        Me.ColCustInvNumber.Name = "ColCustInvNumber"
        '
        'colCustInvCartegory
        '
        Me.colCustInvCartegory.DataPropertyName = "Expense"
        Me.colCustInvCartegory.HeaderText = "Cartegory"
        Me.colCustInvCartegory.Name = "colCustInvCartegory"
        Me.colCustInvCartegory.ReadOnly = True
        '
        'InvConvAmount
        '
        Me.InvConvAmount.DataPropertyName = "InvConvAmount"
        Me.InvConvAmount.HeaderText = "Amount"
        Me.InvConvAmount.Name = "InvConvAmount"
        '
        'InvBalanceDataGridViewTextBoxColumn1
        '
        Me.InvBalanceDataGridViewTextBoxColumn1.DataPropertyName = "InvBalance"
        Me.InvBalanceDataGridViewTextBoxColumn1.HeaderText = "Balance"
        Me.InvBalanceDataGridViewTextBoxColumn1.Name = "InvBalanceDataGridViewTextBoxColumn1"
        '
        'colInvPayCurrency
        '
        Me.colInvPayCurrency.DataPropertyName = "InvCurrency"
        Me.colInvPayCurrency.HeaderText = "Currency"
        Me.colInvPayCurrency.Name = "colInvPayCurrency"
        '
        'ColCustInvRef
        '
        Me.ColCustInvRef.DataPropertyName = "InvRef"
        Me.ColCustInvRef.HeaderText = "InvRef"
        Me.ColCustInvRef.Name = "ColCustInvRef"
        Me.ColCustInvRef.Visible = False
        '
        'colInvPayAmnt
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow
        Me.colInvPayAmnt.DefaultCellStyle = DataGridViewCellStyle7
        Me.colInvPayAmnt.HeaderText = "PayAmount"
        Me.colInvPayAmnt.Name = "colInvPayAmnt"
        '
        'colPayDocNumber
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Yellow
        Me.colPayDocNumber.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPayDocNumber.HeaderText = "Receipt/Ref"
        Me.colPayDocNumber.Name = "colPayDocNumber"
        '
        'colPayNotes
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Yellow
        Me.colPayNotes.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPayNotes.HeaderText = "Comment"
        Me.colPayNotes.Name = "colPayNotes"
        '
        'colInvPayTransType
        '
        Me.colInvPayTransType.DataPropertyName = "InvTransType"
        Me.colInvPayTransType.HeaderText = "InvTransType"
        Me.colInvPayTransType.Name = "colInvPayTransType"
        Me.colInvPayTransType.ReadOnly = True
        '
        'btnPayView
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Green
        Me.btnPayView.DefaultCellStyle = DataGridViewCellStyle10
        Me.btnPayView.HeaderText = ""
        Me.btnPayView.Name = "btnPayView"
        Me.btnPayView.Text = "View"
        Me.btnPayView.UseColumnTextForButtonValue = True
        '
        'btnPayEdit
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Red
        Me.btnPayEdit.DefaultCellStyle = DataGridViewCellStyle11
        Me.btnPayEdit.HeaderText = ""
        Me.btnPayEdit.Name = "btnPayEdit"
        Me.btnPayEdit.Text = "Reverse"
        Me.btnPayEdit.UseColumnTextForButtonValue = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(485, 350)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 34)
        Me.Button4.TabIndex = 2
        Me.Button4.Tag = " "
        Me.Button4.Text = "Pay Selected "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox5.Controls.Add(Label31)
        Me.GroupBox5.Controls.Add(Me.cboPayorCompany)
        Me.GroupBox5.Controls.Add(Me.cboInvPayPeriod)
        Me.GroupBox5.Controls.Add(Label25)
        Me.GroupBox5.Controls.Add(Me.pnlUnimvoicedPayment)
        Me.GroupBox5.Controls.Add(Me.pnlPay)
        Me.GroupBox5.Controls.Add(Label20)
        Me.GroupBox5.Controls.Add(Label19)
        Me.GroupBox5.Controls.Add(Me.mskInvPayDate)
        Me.GroupBox5.Controls.Add(Me.cboPayTransType)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1371, 268)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'cboPayorCompany
        '
        Me.cboPayorCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayorCompany.FormattingEnabled = True
        Me.cboPayorCompany.Items.AddRange(New Object() {"Invoiced", "UnInvoiced"})
        Me.cboPayorCompany.Location = New System.Drawing.Point(72, 22)
        Me.cboPayorCompany.Name = "cboPayorCompany"
        Me.cboPayorCompany.Size = New System.Drawing.Size(113, 21)
        Me.cboPayorCompany.TabIndex = 0
        '
        'cboInvPayPeriod
        '
        Me.cboInvPayPeriod.DisplayMember = "Description"
        Me.cboInvPayPeriod.FormattingEnabled = True
        Me.cboInvPayPeriod.Location = New System.Drawing.Point(72, 92)
        Me.cboInvPayPeriod.Name = "cboInvPayPeriod"
        Me.cboInvPayPeriod.Size = New System.Drawing.Size(114, 21)
        Me.cboInvPayPeriod.TabIndex = 4
        Me.cboInvPayPeriod.ValueMember = "AccountNumber"
        '
        'pnlUnimvoicedPayment
        '
        Me.pnlUnimvoicedPayment.Controls.Add(Me.lbPaymentsNet)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.txtPaymentsNetAmount)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.Label8)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.txtPaymentsVat)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.cboPaymentsVat)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.Label21)
        Me.pnlUnimvoicedPayment.Controls.Add(Label24)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.txtPayComment)
        Me.pnlUnimvoicedPayment.Controls.Add(Label23)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.txtPayReceipt)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.btnPayNonInv)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.cboUnivoicedPayCartegory)
        Me.pnlUnimvoicedPayment.Controls.Add(Label22)
        Me.pnlUnimvoicedPayment.Controls.Add(Label5)
        Me.pnlUnimvoicedPayment.Controls.Add(Me.cboPaymentsCustomer)
        Me.pnlUnimvoicedPayment.Location = New System.Drawing.Point(4, 175)
        Me.pnlUnimvoicedPayment.Name = "pnlUnimvoicedPayment"
        Me.pnlUnimvoicedPayment.Size = New System.Drawing.Size(1361, 89)
        Me.pnlUnimvoicedPayment.TabIndex = 6
        '
        'lbPaymentsNet
        '
        Me.lbPaymentsNet.AutoSize = True
        Me.lbPaymentsNet.Location = New System.Drawing.Point(663, 14)
        Me.lbPaymentsNet.Name = "lbPaymentsNet"
        Me.lbPaymentsNet.Size = New System.Drawing.Size(101, 13)
        Me.lbPaymentsNet.TabIndex = 86
        Me.lbPaymentsNet.Text = "Amount Before Tax:"
        '
        'txtPaymentsNetAmount
        '
        Me.txtPaymentsNetAmount.Enabled = False
        Me.txtPaymentsNetAmount.Location = New System.Drawing.Point(664, 30)
        Me.txtPaymentsNetAmount.Name = "txtPaymentsNetAmount"
        Me.txtPaymentsNetAmount.ReadOnly = True
        Me.txtPaymentsNetAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsNetAmount.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(560, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Vat Amount:"
        '
        'txtPaymentsVat
        '
        Me.txtPaymentsVat.Enabled = False
        Me.txtPaymentsVat.Location = New System.Drawing.Point(563, 30)
        Me.txtPaymentsVat.Name = "txtPaymentsVat"
        Me.txtPaymentsVat.ReadOnly = True
        Me.txtPaymentsVat.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsVat.TabIndex = 82
        '
        'cboPaymentsVat
        '
        Me.cboPaymentsVat.FormattingEnabled = True
        Me.cboPaymentsVat.Location = New System.Drawing.Point(466, 30)
        Me.cboPaymentsVat.Name = "cboPaymentsVat"
        Me.cboPaymentsVat.Size = New System.Drawing.Size(96, 21)
        Me.cboPaymentsVat.TabIndex = 81
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(463, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "Vat Code:"
        '
        'txtPayComment
        '
        Me.txtPayComment.Location = New System.Drawing.Point(963, 30)
        Me.txtPayComment.Multiline = True
        Me.txtPayComment.Name = "txtPayComment"
        Me.txtPayComment.Size = New System.Drawing.Size(196, 53)
        Me.txtPayComment.TabIndex = 2
        '
        'txtPayReceipt
        '
        Me.txtPayReceipt.Location = New System.Drawing.Point(765, 30)
        Me.txtPayReceipt.Name = "txtPayReceipt"
        Me.txtPayReceipt.Size = New System.Drawing.Size(196, 20)
        Me.txtPayReceipt.TabIndex = 1
        '
        'btnPayNonInv
        '
        Me.btnPayNonInv.BackColor = System.Drawing.Color.Green
        Me.btnPayNonInv.ForeColor = System.Drawing.Color.White
        Me.btnPayNonInv.Location = New System.Drawing.Point(1165, 51)
        Me.btnPayNonInv.Name = "btnPayNonInv"
        Me.btnPayNonInv.Size = New System.Drawing.Size(125, 34)
        Me.btnPayNonInv.TabIndex = 3
        Me.btnPayNonInv.Tag = " "
        Me.btnPayNonInv.Text = "Pay"
        Me.btnPayNonInv.UseVisualStyleBackColor = False
        '
        'cboUnivoicedPayCartegory
        '
        Me.cboUnivoicedPayCartegory.DisplayMember = "AccountNumber"
        Me.cboUnivoicedPayCartegory.FormattingEnabled = True
        Me.cboUnivoicedPayCartegory.Location = New System.Drawing.Point(267, 30)
        Me.cboUnivoicedPayCartegory.Name = "cboUnivoicedPayCartegory"
        Me.cboUnivoicedPayCartegory.Size = New System.Drawing.Size(198, 21)
        Me.cboUnivoicedPayCartegory.TabIndex = 0
        Me.cboUnivoicedPayCartegory.ValueMember = "AccountNumber"
        '
        'cboPaymentsCustomer
        '
        Me.cboPaymentsCustomer.DisplayMember = "Name"
        Me.cboPaymentsCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentsCustomer.FormattingEnabled = True
        Me.cboPaymentsCustomer.Location = New System.Drawing.Point(65, 30)
        Me.cboPaymentsCustomer.Name = "cboPaymentsCustomer"
        Me.cboPaymentsCustomer.Size = New System.Drawing.Size(200, 21)
        Me.cboPaymentsCustomer.TabIndex = 2
        Me.cboPaymentsCustomer.ValueMember = "AccNumber"
        '
        'pnlPay
        '
        Me.pnlPay.Controls.Add(Me.cboPayCurrency)
        Me.pnlPay.Controls.Add(Me.cboCustomerPaymentsPayto)
        Me.pnlPay.Controls.Add(Label18)
        Me.pnlPay.Controls.Add(Label17)
        Me.pnlPay.Controls.Add(Me.txtPaymentAmnt)
        Me.pnlPay.Location = New System.Drawing.Point(8, 116)
        Me.pnlPay.Name = "pnlPay"
        Me.pnlPay.Size = New System.Drawing.Size(471, 53)
        Me.pnlPay.TabIndex = 5
        Me.pnlPay.Visible = False
        '
        'cboPayCurrency
        '
        Me.cboPayCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayCurrency.FormattingEnabled = True
        Me.cboPayCurrency.Location = New System.Drawing.Point(179, 2)
        Me.cboPayCurrency.Name = "cboPayCurrency"
        Me.cboPayCurrency.Size = New System.Drawing.Size(84, 21)
        Me.cboPayCurrency.TabIndex = 1
        '
        'cboCustomerPaymentsPayto
        '
        Me.cboCustomerPaymentsPayto.DisplayMember = "Description"
        Me.cboCustomerPaymentsPayto.FormattingEnabled = True
        Me.cboCustomerPaymentsPayto.Location = New System.Drawing.Point(65, 29)
        Me.cboCustomerPaymentsPayto.Name = "cboCustomerPaymentsPayto"
        Me.cboCustomerPaymentsPayto.Size = New System.Drawing.Size(198, 21)
        Me.cboCustomerPaymentsPayto.TabIndex = 2
        Me.cboCustomerPaymentsPayto.ValueMember = "AccountNumber"
        '
        'txtPaymentAmnt
        '
        Me.txtPaymentAmnt.Location = New System.Drawing.Point(64, 3)
        Me.txtPaymentAmnt.Name = "txtPaymentAmnt"
        Me.txtPaymentAmnt.Size = New System.Drawing.Size(113, 20)
        Me.txtPaymentAmnt.TabIndex = 0
        '
        'mskInvPayDate
        '
        Me.mskInvPayDate.Location = New System.Drawing.Point(72, 68)
        Me.mskInvPayDate.Mask = "00/00/0000"
        Me.mskInvPayDate.Name = "mskInvPayDate"
        Me.mskInvPayDate.Size = New System.Drawing.Size(113, 20)
        Me.mskInvPayDate.TabIndex = 3
        Me.mskInvPayDate.ValidatingType = GetType(Date)
        '
        'cboPayTransType
        '
        Me.cboPayTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayTransType.FormattingEnabled = True
        Me.cboPayTransType.Items.AddRange(New Object() {"Invoiced", "UnInvoiced"})
        Me.cboPayTransType.Location = New System.Drawing.Point(72, 45)
        Me.cboPayTransType.Name = "cboPayTransType"
        Me.cboPayTransType.Size = New System.Drawing.Size(113, 21)
        Me.cboPayTransType.TabIndex = 1
        '
        'GLStatementTableAdapter
        '
        Me.GLStatementTableAdapter.ClearBeforeFill = True
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = IncomeExpenditure.dsAccountsReceivableTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTransactionsTableAdapter
        '
        Me.CustomerTransactionsTableAdapter.ClearBeforeFill = True
        '
        'frmAsserts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1686, 724)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmAsserts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receivables"
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbCustomers.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsReceivable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TbCustContact.ResumeLayout(False)
        Me.TbCustContact.PerformLayout()
        Me.tbCustTax.ResumeLayout(False)
        Me.tbCustTax.PerformLayout()
        Me.tbCustPayment.ResumeLayout(False)
        Me.tbCustPayment.PerformLayout()
        Me.tbCustBankingDetails.ResumeLayout(False)
        Me.tbCustBankingDetails.PerformLayout()
        Me.tbOthers.ResumeLayout(False)
        Me.tbOthers.PerformLayout()
        Me.tbCustNotes.ResumeLayout(False)
        Me.tbCustNotes.PerformLayout()
        Me.tbCustomerInvoice.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.gbCustomerInvoice.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.gbInvoiceOptions.ResumeLayout(False)
        Me.gbInvoiceOptions.PerformLayout()
        CType(Me.dgVendorInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbCustomerPayment.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.pnlInvoicedPayment.ResumeLayout(False)
        Me.pnlInvoicedPayment.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.dgPayInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.pnlUnimvoicedPayment.ResumeLayout(False)
        Me.pnlUnimvoicedPayment.PerformLayout()
        Me.pnlPay.ResumeLayout(False)
        Me.pnlPay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents tbCustomers As Windows.Forms.TabPage
    Friend WithEvents tbCustomerInvoice As Windows.Forms.TabPage
    Friend WithEvents tbCustomerPayment As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents TbCustContact As Windows.Forms.TabPage
    Friend WithEvents tbCustNotes As Windows.Forms.TabPage
    Friend WithEvents tbCustTax As Windows.Forms.TabPage
    Friend WithEvents tbCustPayment As Windows.Forms.TabPage
    Friend WithEvents tbCustBankingDetails As Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents TabControl3 As Windows.Forms.TabControl
    Friend WithEvents TabPage6 As Windows.Forms.TabPage
    Friend WithEvents TabPage7 As Windows.Forms.TabPage
    Friend WithEvents DsAccountsReceivable As dsAccountsReceivable
    Friend WithEvents CustomersBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As dsAccountsReceivableTableAdapters.CustomersTableAdapter
    Friend WithEvents ContactNameTextBox As Windows.Forms.TextBox
    Friend WithEvents NameTextBox As Windows.Forms.TextBox
    Friend WithEvents AccNumberTextBox As Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As Windows.Forms.TextBox
    Friend WithEvents CityTextBox As Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As Windows.Forms.TextBox
    Friend WithEvents TaxCodeComboBox As Windows.Forms.ComboBox
    Friend WithEvents CustomerBalanceTextBox As Windows.Forms.TextBox
    Friend WithEvents PaymentTermsComboBox As Windows.Forms.ComboBox
    Friend WithEvents CurrencyComboBox As Windows.Forms.ComboBox
    Friend WithEvents BankDetailsTextBox As Windows.Forms.TextBox
    Friend WithEvents CustomerRefTextBox As Windows.Forms.TextBox
    Friend WithEvents BlockedCheckBox As Windows.Forms.CheckBox
    Friend WithEvents TableAdapterManager As dsAccountsReceivableTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator5 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton29 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel5 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton30 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton31 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton32 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton33 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton34 As Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents btnSearchVendor As Windows.Forms.Button
    Friend WithEvents txtCustomerSearch As Windows.Forms.TextBox
    Friend WithEvents lstResult As Windows.Forms.ListBox
    Friend WithEvents tbOthers As Windows.Forms.TabPage
    Friend WithEvents TaxRegTextBox As Windows.Forms.TextBox
    Friend WithEvents CustomerCompanyComboBox As Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents AccNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankDetailsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountGroupDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlockedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TaxCodeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentTermsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerBalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents gbInvoiceOptions As Windows.Forms.GroupBox
    Friend WithEvents chkDisplayCncelledInvoices As Windows.Forms.CheckBox
    Friend WithEvents dgVendorInvoices As Windows.Forms.DataGridView
    Friend WithEvents gbFeesPay As Windows.Forms.GroupBox
    Friend WithEvents cboInvoiceCompany As Windows.Forms.ComboBox
    Friend WithEvents cboInvoiceCustomer As Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents lbInvPath As Windows.Forms.Label
    Friend WithEvents mskInvDate As Windows.Forms.MaskedTextBox
    Friend WithEvents mskInvDueDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboInvCurrency As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents txtInvNotes As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtInvNumber As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents cboInvPeriod As Windows.Forms.ComboBox
    Friend WithEvents txtInvAmnt As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents cboInvCartegory As Windows.Forms.ComboBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents lbNetAmount As Windows.Forms.Label
    Friend WithEvents txtNetAmount As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtVatAmount As Windows.Forms.TextBox
    Friend WithEvents cboCustVatcode As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents cboCustVatAccount As Windows.Forms.ComboBox
    Friend WithEvents CustomerTransactionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CustomerTransactionsTableAdapter As dsAccountsReceivableTableAdapters.CustomerTransactionsTableAdapter
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents pnlInvoicedPayment As Windows.Forms.Panel
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents dgPayInvoice As Windows.Forms.DataGridView
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents cboPayorCompany As Windows.Forms.ComboBox
    Friend WithEvents cboInvPayPeriod As Windows.Forms.ComboBox
    Friend WithEvents pnlUnimvoicedPayment As Windows.Forms.Panel
    Friend WithEvents txtPayComment As Windows.Forms.TextBox
    Friend WithEvents txtPayReceipt As Windows.Forms.TextBox
    Friend WithEvents btnPayNonInv As Windows.Forms.Button
    Friend WithEvents cboUnivoicedPayCartegory As Windows.Forms.ComboBox
    Friend WithEvents pnlPay As Windows.Forms.Panel
    Friend WithEvents cboPayCurrency As Windows.Forms.ComboBox
    Friend WithEvents cboCustomerPaymentsPayto As Windows.Forms.ComboBox
    Friend WithEvents txtPaymentAmnt As Windows.Forms.TextBox
    Friend WithEvents mskInvPayDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboPayTransType As Windows.Forms.ComboBox
    Friend WithEvents cboPaymentsCustomer As Windows.Forms.ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GLStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsCoA As dsCoA
    Friend WithEvents GLStatementTableAdapter As dsCoATableAdapters.GLStatementTableAdapter
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents cboVenStatCurrentPeriod As Windows.Forms.ComboBox
    Friend WithEvents chkVenStatShowReversals As Windows.Forms.CheckBox
    Friend WithEvents chkVenStatShowPayments As Windows.Forms.CheckBox
    Friend WithEvents chkVenStatShowInvoices As Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As Windows.Forms.GroupBox
    Friend WithEvents btnCustInvoiceRefeesh As Windows.Forms.Button
    Friend WithEvents btnCustInvoiceSearch As Windows.Forms.Button
    Friend WithEvents txtCustInvoiceSearchh As Windows.Forms.TextBox
    Friend WithEvents gbCustomerInvoice As Windows.Forms.GroupBox
    Friend WithEvents Description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustInvVendor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDocNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VatAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvCurrency As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDueDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNotesDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCartegoryDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvTransType As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvClearedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colInvRef As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostedByDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColInvActive As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InvPaymentRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDocDataGridViewImageColumn As Windows.Forms.DataGridViewImageColumn
    Friend WithEvents InvBankAccountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCompanyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVatCode As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnView As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnEditInvoice As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCancelInvoice As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnDelete As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents btnCustomerPaySearchRefresh As Windows.Forms.Button
    Friend WithEvents btnCustomerPaySearch As Windows.Forms.Button
    Friend WithEvents txtCustomerPaySearch As Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As Windows.Forms.GroupBox
    Friend WithEvents chkShowPayments As Windows.Forms.CheckBox
    Friend WithEvents chkPayInvoice As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Customer As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPayCustomerAcc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCustInvNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustInvCartegory As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvConvAmount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBalanceDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvPayCurrency As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCustInvRef As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvPayAmnt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayDocNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayNotes As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvPayTransType As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPayView As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnPayEdit As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lbPaymentsNet As Windows.Forms.Label
    Friend WithEvents txtPaymentsNetAmount As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtPaymentsVat As Windows.Forms.TextBox
    Friend WithEvents cboPaymentsVat As Windows.Forms.ComboBox
    Friend WithEvents Label21 As Windows.Forms.Label
End Class
