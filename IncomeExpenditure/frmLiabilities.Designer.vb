<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiabilities
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label7 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim StudentSurnameLabel As System.Windows.Forms.Label
        Dim NationalIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim TaxRegLabel As System.Windows.Forms.Label
        Dim TaxCodeLabel As System.Windows.Forms.Label
        Dim PaymentTermsLabel As System.Windows.Forms.Label
        Dim Label35 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiabilities))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GLStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCoA = New IncomeExpenditure.dsCoA()
        Me.VendorStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsPayable = New IncomeExpenditure.dsAccountsPayable()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbPayabless = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbVendors = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtVendorAccRef = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchVendor = New System.Windows.Forms.Button()
        Me.ttxVendorSearchtext = New System.Windows.Forms.TextBox()
        Me.gbStudPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.tbVendor = New System.Windows.Forms.TabControl()
        Me.tbVendContact = New System.Windows.Forms.TabPage()
        Me.txtVendorCountry = New System.Windows.Forms.TextBox()
        Me.txtVendorContNummber = New System.Windows.Forms.TextBox()
        Me.txtVendorCity = New System.Windows.Forms.TextBox()
        Me.txtVendorEmail = New System.Windows.Forms.TextBox()
        Me.txtVendorAddress = New System.Windows.Forms.TextBox()
        Me.tbVenVAT = New System.Windows.Forms.TabPage()
        Me.cboVendorVatAccount = New System.Windows.Forms.ComboBox()
        Me.TaxRegTextBox = New System.Windows.Forms.TextBox()
        Me.TaxCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.tbPayments = New System.Windows.Forms.TabPage()
        Me.PaymentTermsComboBox = New System.Windows.Forms.ComboBox()
        Me.txtVendorBalance = New System.Windows.Forms.TextBox()
        Me.cboVendorCurrency = New System.Windows.Forms.ComboBox()
        Me.tbVenBankDetails = New System.Windows.Forms.TabPage()
        Me.txtVendorBankDetails = New System.Windows.Forms.TextBox()
        Me.tbVenOthers = New System.Windows.Forms.TabPage()
        Me.chkVendorIsBLocked = New System.Windows.Forms.CheckBox()
        Me.cboVendorCompany = New System.Windows.Forms.ComboBox()
        Me.tbVenNotes = New System.Windows.Forms.TabPage()
        Me.txtVendorNotes = New System.Windows.Forms.TextBox()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.txtVendorContName = New System.Windows.Forms.TextBox()
        Me.txtVendorName = New System.Windows.Forms.TextBox()
        Me.txtVendorAccNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboVenStatCurrentPeriod = New System.Windows.Forms.ComboBox()
        Me.chkVenStatShowReversals = New System.Windows.Forms.CheckBox()
        Me.chkVenStatShowPayments = New System.Windows.Forms.CheckBox()
        Me.chkVenStatShowInvoices = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbInvoices = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnVenInvSearchRefresh = New System.Windows.Forms.Button()
        Me.gbInvoiceOptions = New System.Windows.Forms.GroupBox()
        Me.chkDisplayCncelledInvoices = New System.Windows.Forms.CheckBox()
        Me.btnVenInvoiceSearch = New System.Windows.Forms.Button()
        Me.dgVendorInvoices = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvVendorNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvCartegory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvConvAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvActive = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvPaymentRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvTransTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEditInvoice = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCancelInvoice = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VendorInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtVenInvoiceSearch = New System.Windows.Forms.TextBox()
        Me.gbFeesPay = New System.Windows.Forms.GroupBox()
        Me.cboInvoiceVendor = New System.Windows.Forms.ComboBox()
        Me.cboInvoiceCompany = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbNetAmount = New System.Windows.Forms.Label()
        Me.txtNetAmount = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.cboVenVatcode = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
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
        Me.tbVendorPayments = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pnlInvoicedExpenditure = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnPayInvoiceRefeesh = New System.Windows.Forms.Button()
        Me.btnPayInvoiceSearch = New System.Windows.Forms.Button()
        Me.txtPayInvoiceSearchh = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkShowPayments = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dgPayInvoice = New System.Windows.Forms.DataGridView()
        Me.chkPayInvoice = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Vendor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvPayAccountNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPayInvTransType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayInvNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExpCartegory = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colInvPayConvAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBalanceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvPayAmnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayDocNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNotesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPayInvRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPayView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnPayCancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboExpenseCompany = New System.Windows.Forms.ComboBox()
        Me.cboInvPayPeriod = New System.Windows.Forms.ComboBox()
        Me.pnlUnimvoicedExpense = New System.Windows.Forms.Panel()
        Me.lbPaymentsNet = New System.Windows.Forms.Label()
        Me.txtPaymentsNetAmount = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtPaymentsVat = New System.Windows.Forms.TextBox()
        Me.cboPaymentsVat = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtPayComment = New System.Windows.Forms.TextBox()
        Me.txtPayReceipt = New System.Windows.Forms.TextBox()
        Me.btnPayNonInv = New System.Windows.Forms.Button()
        Me.cboUnivoicedPayCartegory = New System.Windows.Forms.ComboBox()
        Me.cboPaymentsVendor = New System.Windows.Forms.ComboBox()
        Me.pnlPay = New System.Windows.Forms.Panel()
        Me.txtBankBalance = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboPayCurrency = New System.Windows.Forms.ComboBox()
        Me.cboVendorPaymentsPayFrom = New System.Windows.Forms.ComboBox()
        Me.txtExpenseAmnt = New System.Windows.Forms.TextBox()
        Me.mskInvPayDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboPayTransType = New System.Windows.Forms.ComboBox()
        Me.AccountCartegoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsSettings = New IncomeExpenditure.dsAccountsSettings()
        Me.VendorsTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorsTableAdapter()
        Me.TableAdapterManager = New IncomeExpenditure.dsAccountsPayableTableAdapters.TableAdapterManager()
        Me.VendorInvoicesTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter()
        Me.AccountCartegoriesTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter()
        Me.VendorStatementTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorStatementTableAdapter()
        Me.GLStatementTableAdapter = New IncomeExpenditure.dsCoATableAdapters.GLStatementTableAdapter()
        Label7 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        StudentSurnameLabel = New System.Windows.Forms.Label()
        NationalIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        TaxRegLabel = New System.Windows.Forms.Label()
        TaxCodeLabel = New System.Windows.Forms.Label()
        PaymentTermsLabel = New System.Windows.Forms.Label()
        Label35 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbPayabless.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbVendors.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.gbStudPersonalDetails.SuspendLayout()
        Me.tbVendor.SuspendLayout()
        Me.tbVendContact.SuspendLayout()
        Me.tbVenVAT.SuspendLayout()
        Me.tbPayments.SuspendLayout()
        Me.tbVenBankDetails.SuspendLayout()
        Me.tbVenOthers.SuspendLayout()
        Me.tbVenNotes.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tbInvoices.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.gbInvoiceOptions.SuspendLayout()
        CType(Me.dgVendorInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeesPay.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbVendorPayments.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlInvoicedExpenditure.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgPayInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.pnlUnimvoicedExpense.SuspendLayout()
        Me.pnlPay.SuspendLayout()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(3, 22)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(70, 13)
        Label7.TabIndex = 35
        Label7.Text = "Bank Details:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(3, 66)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 27
        Label3.Text = "Currency:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 35)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 22
        Label2.Text = "Email:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(10, 64)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(78, 13)
        GenderLabel.TabIndex = 17
        GenderLabel.Text = "Contact Name:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(6, 56)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(87, 13)
        ReligionLabel.TabIndex = 14
        ReligionLabel.Text = "Physical Adrress:"
        '
        'StudentSurnameLabel
        '
        StudentSurnameLabel.AutoSize = True
        StudentSurnameLabel.Location = New System.Drawing.Point(10, 43)
        StudentSurnameLabel.Name = "StudentSurnameLabel"
        StudentSurnameLabel.Size = New System.Drawing.Size(57, 13)
        StudentSurnameLabel.TabIndex = 6
        StudentSurnameLabel.Text = "AccName:"
        '
        'NationalIDLabel
        '
        NationalIDLabel.AutoSize = True
        NationalIDLabel.Location = New System.Drawing.Point(6, 14)
        NationalIDLabel.Name = "NationalIDLabel"
        NationalIDLabel.Size = New System.Drawing.Size(87, 13)
        NationalIDLabel.TabIndex = 12
        NationalIDLabel.Text = "Contact Number:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(10, 22)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(66, 13)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "AccNumber:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(12, 36)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(44, 13)
        StudentIDLabel1.TabIndex = 0
        StudentIDLabel1.Text = "Vendor:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 9)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 37
        Label1.Text = "Notes:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 106)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(43, 13)
        Label6.TabIndex = 33
        Label6.Text = "Country"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 81)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(27, 13)
        Label5.TabIndex = 31
        Label5.Text = "City:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(68, 9)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(40, 13)
        Label26.TabIndex = 0
        Label26.Text = "Payee:"
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
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(1, 37)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(51, 13)
        Label18.TabIndex = 55
        Label18.Text = "PayFrom:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(8, 72)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(33, 13)
        Label19.TabIndex = 57
        Label19.Text = "Date:"
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
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(269, 9)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(55, 13)
        Label22.TabIndex = 68
        Label22.Text = "Cartegory:"
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.Location = New System.Drawing.Point(778, 10)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(47, 13)
        Label23.TabIndex = 72
        Label23.Text = "Receipt:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(978, 10)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(54, 13)
        Label24.TabIndex = 74
        Label24.Text = "Comment:"
        '
        'Label25
        '
        Label25.AutoSize = True
        Label25.Location = New System.Drawing.Point(8, 98)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(40, 13)
        Label25.TabIndex = 72
        Label25.Text = "Period:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Location = New System.Drawing.Point(3, 39)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(83, 13)
        Label28.TabIndex = 41
        Label28.Text = "VendorBalance:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(12, 17)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 13)
        Label4.TabIndex = 66
        Label4.Text = "Company:"
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
        'Label32
        '
        Label32.AutoSize = True
        Label32.Location = New System.Drawing.Point(7, 20)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(54, 13)
        Label32.TabIndex = 43
        Label32.Text = "Company:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(7, 44)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(49, 13)
        Label8.TabIndex = 45
        Label8.Text = "Blocked:"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Location = New System.Drawing.Point(13, 87)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(74, 13)
        Label29.TabIndex = 37
        Label29.Text = "VAT Account:"
        '
        'TaxRegLabel
        '
        TaxRegLabel.AutoSize = True
        TaxRegLabel.Location = New System.Drawing.Point(18, 21)
        TaxRegLabel.Name = "TaxRegLabel"
        TaxRegLabel.Size = New System.Drawing.Size(67, 13)
        TaxRegLabel.TabIndex = 35
        TaxRegLabel.Text = "VAT Reg # :"
        '
        'TaxCodeLabel
        '
        TaxCodeLabel.AutoSize = True
        TaxCodeLabel.Location = New System.Drawing.Point(13, 53)
        TaxCodeLabel.Name = "TaxCodeLabel"
        TaxCodeLabel.Size = New System.Drawing.Size(59, 13)
        TaxCodeLabel.TabIndex = 34
        TaxCodeLabel.Text = "VAT Code:"
        '
        'PaymentTermsLabel
        '
        PaymentTermsLabel.AutoSize = True
        PaymentTermsLabel.Location = New System.Drawing.Point(3, 14)
        PaymentTermsLabel.Name = "PaymentTermsLabel"
        PaymentTermsLabel.Size = New System.Drawing.Size(83, 13)
        PaymentTermsLabel.TabIndex = 43
        PaymentTermsLabel.Text = "Payment Terms:"
        '
        'Label35
        '
        Label35.AutoSize = True
        Label35.Location = New System.Drawing.Point(6, 203)
        Label35.Name = "Label35"
        Label35.Size = New System.Drawing.Size(44, 13)
        Label35.TabIndex = 72
        Label35.Text = "Search:"
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
        'GLStatementBindingSource
        '
        Me.GLStatementBindingSource.DataMember = "GLStatement"
        Me.GLStatementBindingSource.DataSource = Me.dsCoA
        '
        'dsCoA
        '
        Me.dsCoA.DataSetName = "dsCoA"
        Me.dsCoA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorStatementBindingSource
        '
        Me.VendorStatementBindingSource.DataMember = "VendorStatement"
        Me.VendorStatementBindingSource.DataSource = Me.DsAccountsPayable
        '
        'DsAccountsPayable
        '
        Me.DsAccountsPayable.DataSetName = "dsAccountsPayable"
        Me.DsAccountsPayable.EnforceConstraints = False
        Me.DsAccountsPayable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.DsAccountsPayable
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbPayabless)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1632, 783)
        Me.TabControl1.TabIndex = 0
        '
        'tbPayabless
        '
        Me.tbPayabless.Controls.Add(Me.TabControl2)
        Me.tbPayabless.Location = New System.Drawing.Point(4, 22)
        Me.tbPayabless.Name = "tbPayabless"
        Me.tbPayabless.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPayabless.Size = New System.Drawing.Size(1624, 757)
        Me.tbPayabless.TabIndex = 0
        Me.tbPayabless.Text = "Payables"
        Me.tbPayabless.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tbVendors)
        Me.TabControl2.Controls.Add(Me.tbInvoices)
        Me.TabControl2.Controls.Add(Me.tbVendorPayments)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1618, 751)
        Me.TabControl2.TabIndex = 1
        '
        'tbVendors
        '
        Me.tbVendors.Controls.Add(Me.SplitContainer1)
        Me.tbVendors.Location = New System.Drawing.Point(4, 22)
        Me.tbVendors.Name = "tbVendors"
        Me.tbVendors.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVendors.Size = New System.Drawing.Size(1610, 725)
        Me.tbVendors.TabIndex = 0
        Me.tbVendors.Text = "Vendors"
        Me.tbVendors.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1604, 719)
        Me.SplitContainer1.SplitterDistance = 260
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtVendorAccRef)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox5.Controls.Add(Me.btnSearchVendor)
        Me.GroupBox5.Controls.Add(Me.ttxVendorSearchtext)
        Me.GroupBox5.Controls.Add(Me.gbStudPersonalDetails)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 29)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(537, 646)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Edit Vendor"
        '
        'txtVendorAccRef
        '
        Me.txtVendorAccRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorAccRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "AccRef", True))
        Me.txtVendorAccRef.Enabled = False
        Me.txtVendorAccRef.Location = New System.Drawing.Point(10, 604)
        Me.txtVendorAccRef.Multiline = True
        Me.txtVendorAccRef.Name = "txtVendorAccRef"
        Me.txtVendorAccRef.Size = New System.Drawing.Size(521, 25)
        Me.txtVendorAccRef.TabIndex = 41
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(512, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 20)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.VendorsBindingSource
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(9, 16)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(151, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.BackColor = System.Drawing.Color.Yellow
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Green
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton1.Text = "Save Vendor"
        Me.ToolStripButton1.ToolTipText = "Save Vendor"
        '
        'btnSearchVendor
        '
        Me.btnSearchVendor.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnSearchVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchVendor.Location = New System.Drawing.Point(492, 18)
        Me.btnSearchVendor.Name = "btnSearchVendor"
        Me.btnSearchVendor.Size = New System.Drawing.Size(19, 20)
        Me.btnSearchVendor.TabIndex = 20
        Me.btnSearchVendor.UseVisualStyleBackColor = True
        '
        'ttxVendorSearchtext
        '
        Me.ttxVendorSearchtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttxVendorSearchtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ttxVendorSearchtext.Location = New System.Drawing.Point(329, 19)
        Me.ttxVendorSearchtext.Name = "ttxVendorSearchtext"
        Me.ttxVendorSearchtext.Size = New System.Drawing.Size(157, 20)
        Me.ttxVendorSearchtext.TabIndex = 18
        '
        'gbStudPersonalDetails
        '
        Me.gbStudPersonalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbStudPersonalDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbStudPersonalDetails.Controls.Add(Me.tbVendor)
        Me.gbStudPersonalDetails.Controls.Add(Me.lstResult)
        Me.gbStudPersonalDetails.Controls.Add(Me.txtVendorContName)
        Me.gbStudPersonalDetails.Controls.Add(GenderLabel)
        Me.gbStudPersonalDetails.Controls.Add(StudentSurnameLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.txtVendorName)
        Me.gbStudPersonalDetails.Controls.Add(StudentIDLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.txtVendorAccNumber)
        Me.gbStudPersonalDetails.Location = New System.Drawing.Point(9, 44)
        Me.gbStudPersonalDetails.Name = "gbStudPersonalDetails"
        Me.gbStudPersonalDetails.Size = New System.Drawing.Size(521, 554)
        Me.gbStudPersonalDetails.TabIndex = 1
        Me.gbStudPersonalDetails.TabStop = False
        Me.gbStudPersonalDetails.Text = "Vendor"
        '
        'tbVendor
        '
        Me.tbVendor.Controls.Add(Me.tbVendContact)
        Me.tbVendor.Controls.Add(Me.tbVenVAT)
        Me.tbVendor.Controls.Add(Me.tbPayments)
        Me.tbVendor.Controls.Add(Me.tbVenBankDetails)
        Me.tbVendor.Controls.Add(Me.tbVenOthers)
        Me.tbVendor.Controls.Add(Me.tbVenNotes)
        Me.tbVendor.Location = New System.Drawing.Point(2, 88)
        Me.tbVendor.Name = "tbVendor"
        Me.tbVendor.SelectedIndex = 0
        Me.tbVendor.Size = New System.Drawing.Size(520, 460)
        Me.tbVendor.TabIndex = 44
        '
        'tbVendContact
        '
        Me.tbVendContact.Controls.Add(NationalIDLabel)
        Me.tbVendContact.Controls.Add(ReligionLabel)
        Me.tbVendContact.Controls.Add(Me.txtVendorCountry)
        Me.tbVendContact.Controls.Add(Me.txtVendorContNummber)
        Me.tbVendContact.Controls.Add(Label6)
        Me.tbVendContact.Controls.Add(Label2)
        Me.tbVendContact.Controls.Add(Me.txtVendorCity)
        Me.tbVendContact.Controls.Add(Me.txtVendorEmail)
        Me.tbVendContact.Controls.Add(Label5)
        Me.tbVendContact.Controls.Add(Me.txtVendorAddress)
        Me.tbVendContact.Location = New System.Drawing.Point(4, 22)
        Me.tbVendContact.Name = "tbVendContact"
        Me.tbVendContact.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVendContact.Size = New System.Drawing.Size(512, 434)
        Me.tbVendContact.TabIndex = 0
        Me.tbVendContact.Text = "Contact Details"
        Me.tbVendContact.UseVisualStyleBackColor = True
        '
        'txtVendorCountry
        '
        Me.txtVendorCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Country", True))
        Me.txtVendorCountry.Location = New System.Drawing.Point(99, 103)
        Me.txtVendorCountry.Multiline = True
        Me.txtVendorCountry.Name = "txtVendorCountry"
        Me.txtVendorCountry.Size = New System.Drawing.Size(412, 24)
        Me.txtVendorCountry.TabIndex = 34
        '
        'txtVendorContNummber
        '
        Me.txtVendorContNummber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorContNummber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "ContactNumber", True))
        Me.txtVendorContNummber.Location = New System.Drawing.Point(99, 11)
        Me.txtVendorContNummber.Name = "txtVendorContNummber"
        Me.txtVendorContNummber.Size = New System.Drawing.Size(412, 20)
        Me.txtVendorContNummber.TabIndex = 21
        '
        'txtVendorCity
        '
        Me.txtVendorCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "City", True))
        Me.txtVendorCity.Location = New System.Drawing.Point(99, 78)
        Me.txtVendorCity.Multiline = True
        Me.txtVendorCity.Name = "txtVendorCity"
        Me.txtVendorCity.Size = New System.Drawing.Size(412, 24)
        Me.txtVendorCity.TabIndex = 32
        '
        'txtVendorEmail
        '
        Me.txtVendorEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Email", True))
        Me.txtVendorEmail.Location = New System.Drawing.Point(99, 32)
        Me.txtVendorEmail.Name = "txtVendorEmail"
        Me.txtVendorEmail.Size = New System.Drawing.Size(412, 20)
        Me.txtVendorEmail.TabIndex = 23
        '
        'txtVendorAddress
        '
        Me.txtVendorAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Address", True))
        Me.txtVendorAddress.Location = New System.Drawing.Point(99, 53)
        Me.txtVendorAddress.Multiline = True
        Me.txtVendorAddress.Name = "txtVendorAddress"
        Me.txtVendorAddress.Size = New System.Drawing.Size(412, 24)
        Me.txtVendorAddress.TabIndex = 26
        '
        'tbVenVAT
        '
        Me.tbVenVAT.Controls.Add(Label29)
        Me.tbVenVAT.Controls.Add(Me.cboVendorVatAccount)
        Me.tbVenVAT.Controls.Add(TaxRegLabel)
        Me.tbVenVAT.Controls.Add(Me.TaxRegTextBox)
        Me.tbVenVAT.Controls.Add(TaxCodeLabel)
        Me.tbVenVAT.Controls.Add(Me.TaxCodeComboBox)
        Me.tbVenVAT.Location = New System.Drawing.Point(4, 22)
        Me.tbVenVAT.Name = "tbVenVAT"
        Me.tbVenVAT.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVenVAT.Size = New System.Drawing.Size(512, 434)
        Me.tbVenVAT.TabIndex = 5
        Me.tbVenVAT.Text = "VAT"
        Me.tbVenVAT.UseVisualStyleBackColor = True
        '
        'cboVendorVatAccount
        '
        Me.cboVendorVatAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VatAccountName", True))
        Me.cboVendorVatAccount.FormattingEnabled = True
        Me.cboVendorVatAccount.Location = New System.Drawing.Point(99, 79)
        Me.cboVendorVatAccount.Name = "cboVendorVatAccount"
        Me.cboVendorVatAccount.Size = New System.Drawing.Size(193, 21)
        Me.cboVendorVatAccount.TabIndex = 36
        '
        'TaxRegTextBox
        '
        Me.TaxRegTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "TaxReg", True))
        Me.TaxRegTextBox.Location = New System.Drawing.Point(99, 18)
        Me.TaxRegTextBox.Name = "TaxRegTextBox"
        Me.TaxRegTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TaxRegTextBox.TabIndex = 32
        '
        'TaxCodeComboBox
        '
        Me.TaxCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "TaxDescription", True))
        Me.TaxCodeComboBox.FormattingEnabled = True
        Me.TaxCodeComboBox.Location = New System.Drawing.Point(99, 45)
        Me.TaxCodeComboBox.Name = "TaxCodeComboBox"
        Me.TaxCodeComboBox.Size = New System.Drawing.Size(193, 21)
        Me.TaxCodeComboBox.TabIndex = 33
        '
        'tbPayments
        '
        Me.tbPayments.Controls.Add(PaymentTermsLabel)
        Me.tbPayments.Controls.Add(Me.PaymentTermsComboBox)
        Me.tbPayments.Controls.Add(Me.txtVendorBalance)
        Me.tbPayments.Controls.Add(Label28)
        Me.tbPayments.Controls.Add(Me.cboVendorCurrency)
        Me.tbPayments.Controls.Add(Label3)
        Me.tbPayments.Location = New System.Drawing.Point(4, 22)
        Me.tbPayments.Name = "tbPayments"
        Me.tbPayments.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPayments.Size = New System.Drawing.Size(512, 434)
        Me.tbPayments.TabIndex = 2
        Me.tbPayments.Text = "Payments&Billing"
        Me.tbPayments.UseVisualStyleBackColor = True
        '
        'PaymentTermsComboBox
        '
        Me.PaymentTermsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "PayTermDescription", True))
        Me.PaymentTermsComboBox.FormattingEnabled = True
        Me.PaymentTermsComboBox.Location = New System.Drawing.Point(119, 14)
        Me.PaymentTermsComboBox.Name = "PaymentTermsComboBox"
        Me.PaymentTermsComboBox.Size = New System.Drawing.Size(135, 21)
        Me.PaymentTermsComboBox.TabIndex = 42
        '
        'txtVendorBalance
        '
        Me.txtVendorBalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorBalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "VendorBalance", True))
        Me.txtVendorBalance.Enabled = False
        Me.txtVendorBalance.Location = New System.Drawing.Point(119, 36)
        Me.txtVendorBalance.Multiline = True
        Me.txtVendorBalance.Name = "txtVendorBalance"
        Me.txtVendorBalance.Size = New System.Drawing.Size(135, 24)
        Me.txtVendorBalance.TabIndex = 40
        '
        'cboVendorCurrency
        '
        Me.cboVendorCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVendorCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVendorCurrency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Currency", True))
        Me.cboVendorCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendorCurrency.FormattingEnabled = True
        Me.cboVendorCurrency.Items.AddRange(New Object() {"USD"})
        Me.cboVendorCurrency.Location = New System.Drawing.Point(119, 63)
        Me.cboVendorCurrency.Name = "cboVendorCurrency"
        Me.cboVendorCurrency.Size = New System.Drawing.Size(135, 21)
        Me.cboVendorCurrency.TabIndex = 7
        '
        'tbVenBankDetails
        '
        Me.tbVenBankDetails.Controls.Add(Me.txtVendorBankDetails)
        Me.tbVenBankDetails.Controls.Add(Label7)
        Me.tbVenBankDetails.Location = New System.Drawing.Point(4, 22)
        Me.tbVenBankDetails.Name = "tbVenBankDetails"
        Me.tbVenBankDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVenBankDetails.Size = New System.Drawing.Size(512, 434)
        Me.tbVenBankDetails.TabIndex = 1
        Me.tbVenBankDetails.Text = "Banking"
        Me.tbVenBankDetails.UseVisualStyleBackColor = True
        '
        'txtVendorBankDetails
        '
        Me.txtVendorBankDetails.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorBankDetails.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "BankDetails", True))
        Me.txtVendorBankDetails.Location = New System.Drawing.Point(94, 19)
        Me.txtVendorBankDetails.Multiline = True
        Me.txtVendorBankDetails.Name = "txtVendorBankDetails"
        Me.txtVendorBankDetails.Size = New System.Drawing.Size(412, 117)
        Me.txtVendorBankDetails.TabIndex = 36
        '
        'tbVenOthers
        '
        Me.tbVenOthers.Controls.Add(Label8)
        Me.tbVenOthers.Controls.Add(Me.chkVendorIsBLocked)
        Me.tbVenOthers.Controls.Add(Me.cboVendorCompany)
        Me.tbVenOthers.Controls.Add(Label32)
        Me.tbVenOthers.Location = New System.Drawing.Point(4, 22)
        Me.tbVenOthers.Name = "tbVenOthers"
        Me.tbVenOthers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVenOthers.Size = New System.Drawing.Size(512, 434)
        Me.tbVenOthers.TabIndex = 3
        Me.tbVenOthers.Text = "Others"
        Me.tbVenOthers.UseVisualStyleBackColor = True
        '
        'chkVendorIsBLocked
        '
        Me.chkVendorIsBLocked.AutoSize = True
        Me.chkVendorIsBLocked.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.VendorsBindingSource, "Blocked", True))
        Me.chkVendorIsBLocked.Location = New System.Drawing.Point(74, 44)
        Me.chkVendorIsBLocked.Name = "chkVendorIsBLocked"
        Me.chkVendorIsBLocked.Size = New System.Drawing.Size(15, 14)
        Me.chkVendorIsBLocked.TabIndex = 44
        Me.chkVendorIsBLocked.UseVisualStyleBackColor = True
        '
        'cboVendorCompany
        '
        Me.cboVendorCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVendorCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVendorCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "CompanyName", True))
        Me.cboVendorCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendorCompany.FormattingEnabled = True
        Me.cboVendorCompany.Items.AddRange(New Object() {"USD"})
        Me.cboVendorCompany.Location = New System.Drawing.Point(74, 17)
        Me.cboVendorCompany.Name = "cboVendorCompany"
        Me.cboVendorCompany.Size = New System.Drawing.Size(135, 21)
        Me.cboVendorCompany.TabIndex = 42
        '
        'tbVenNotes
        '
        Me.tbVenNotes.Controls.Add(Me.txtVendorNotes)
        Me.tbVenNotes.Controls.Add(Label1)
        Me.tbVenNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbVenNotes.Name = "tbVenNotes"
        Me.tbVenNotes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVenNotes.Size = New System.Drawing.Size(512, 434)
        Me.tbVenNotes.TabIndex = 4
        Me.tbVenNotes.Text = "Notes"
        Me.tbVenNotes.UseVisualStyleBackColor = True
        '
        'txtVendorNotes
        '
        Me.txtVendorNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Notes", True))
        Me.txtVendorNotes.Location = New System.Drawing.Point(50, 6)
        Me.txtVendorNotes.Multiline = True
        Me.txtVendorNotes.Name = "txtVendorNotes"
        Me.txtVendorNotes.Size = New System.Drawing.Size(303, 220)
        Me.txtVendorNotes.TabIndex = 38
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(320, 0)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(201, 82)
        Me.lstResult.TabIndex = 19
        Me.lstResult.Visible = False
        '
        'txtVendorContName
        '
        Me.txtVendorContName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorContName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "ContactName", True))
        Me.txtVendorContName.Location = New System.Drawing.Point(103, 61)
        Me.txtVendorContName.Name = "txtVendorContName"
        Me.txtVendorContName.Size = New System.Drawing.Size(412, 20)
        Me.txtVendorContName.TabIndex = 18
        '
        'txtVendorName
        '
        Me.txtVendorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "Name", True))
        Me.txtVendorName.Location = New System.Drawing.Point(103, 40)
        Me.txtVendorName.Name = "txtVendorName"
        Me.txtVendorName.Size = New System.Drawing.Size(412, 20)
        Me.txtVendorName.TabIndex = 1
        '
        'txtVendorAccNumber
        '
        Me.txtVendorAccNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVendorAccNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtVendorAccNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVendorAccNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "AccNumber", True))
        Me.txtVendorAccNumber.Enabled = False
        Me.txtVendorAccNumber.Location = New System.Drawing.Point(103, 19)
        Me.txtVendorAccNumber.Name = "txtVendorAccNumber"
        Me.txtVendorAccNumber.ReadOnly = True
        Me.txtVendorAccNumber.Size = New System.Drawing.Size(412, 20)
        Me.txtVendorAccNumber.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TabControl3)
        Me.GroupBox4.Location = New System.Drawing.Point(546, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1044, 661)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 16)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1038, 642)
        Me.TabControl3.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1030, 616)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "VendorsList"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.AccNumberDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.BankDetailsDataGridViewTextBoxColumn, Me.CurrencyDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.BlockedDataGridViewCheckBoxColumn})
        Me.DataGridView2.DataSource = Me.VendorsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(9, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(1021, 604)
        Me.DataGridView2.TabIndex = 20
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.Frozen = True
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccNumberDataGridViewTextBoxColumn
        '
        Me.AccNumberDataGridViewTextBoxColumn.DataPropertyName = "AccNumber"
        Me.AccNumberDataGridViewTextBoxColumn.Frozen = True
        Me.AccNumberDataGridViewTextBoxColumn.HeaderText = "AccNumber"
        Me.AccNumberDataGridViewTextBoxColumn.Name = "AccNumberDataGridViewTextBoxColumn"
        Me.AccNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        Me.ContactNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        Me.ContactNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BankDetailsDataGridViewTextBoxColumn
        '
        Me.BankDetailsDataGridViewTextBoxColumn.DataPropertyName = "BankDetails"
        Me.BankDetailsDataGridViewTextBoxColumn.HeaderText = "BankDetails"
        Me.BankDetailsDataGridViewTextBoxColumn.Name = "BankDetailsDataGridViewTextBoxColumn"
        Me.BankDetailsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        Me.CurrencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BlockedDataGridViewCheckBoxColumn
        '
        Me.BlockedDataGridViewCheckBoxColumn.DataPropertyName = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.HeaderText = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.Name = "BlockedDataGridViewCheckBoxColumn"
        Me.BlockedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1030, 616)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "VendorStatement"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.cboVenStatCurrentPeriod)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowReversals)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowPayments)
        Me.GroupBox6.Controls.Add(Me.chkVenStatShowInvoices)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1001, 33)
        Me.GroupBox6.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(9, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 545)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.GLStatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptGLStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1005, 545)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbInvoices
        '
        Me.tbInvoices.Controls.Add(Me.SplitContainer2)
        Me.tbInvoices.Location = New System.Drawing.Point(4, 22)
        Me.tbInvoices.Name = "tbInvoices"
        Me.tbInvoices.Padding = New System.Windows.Forms.Padding(3)
        Me.tbInvoices.Size = New System.Drawing.Size(1610, 725)
        Me.tbInvoices.TabIndex = 1
        Me.tbInvoices.Text = "Vendor Invoices"
        Me.tbInvoices.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Panel1Collapsed = True
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer2.Size = New System.Drawing.Size(1604, 719)
        Me.SplitContainer2.SplitterDistance = 275
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Label35)
        Me.GroupBox7.Controls.Add(Me.btnVenInvSearchRefresh)
        Me.GroupBox7.Controls.Add(Me.gbInvoiceOptions)
        Me.GroupBox7.Controls.Add(Me.btnVenInvoiceSearch)
        Me.GroupBox7.Controls.Add(Me.dgVendorInvoices)
        Me.GroupBox7.Controls.Add(Me.txtVenInvoiceSearch)
        Me.GroupBox7.Controls.Add(Me.gbFeesPay)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 18)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1587, 686)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Invoice"
        '
        'btnVenInvSearchRefresh
        '
        Me.btnVenInvSearchRefresh.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.btnVenInvSearchRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVenInvSearchRefresh.Location = New System.Drawing.Point(238, 200)
        Me.btnVenInvSearchRefresh.Name = "btnVenInvSearchRefresh"
        Me.btnVenInvSearchRefresh.Size = New System.Drawing.Size(19, 20)
        Me.btnVenInvSearchRefresh.TabIndex = 71
        Me.btnVenInvSearchRefresh.UseVisualStyleBackColor = True
        '
        'gbInvoiceOptions
        '
        Me.gbInvoiceOptions.Controls.Add(Me.chkDisplayCncelledInvoices)
        Me.gbInvoiceOptions.Location = New System.Drawing.Point(263, 190)
        Me.gbInvoiceOptions.Name = "gbInvoiceOptions"
        Me.gbInvoiceOptions.Size = New System.Drawing.Size(253, 36)
        Me.gbInvoiceOptions.TabIndex = 1
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
        'btnVenInvoiceSearch
        '
        Me.btnVenInvoiceSearch.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnVenInvoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVenInvoiceSearch.Location = New System.Drawing.Point(219, 200)
        Me.btnVenInvoiceSearch.Name = "btnVenInvoiceSearch"
        Me.btnVenInvoiceSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnVenInvoiceSearch.TabIndex = 70
        Me.btnVenInvoiceSearch.UseVisualStyleBackColor = True
        '
        'dgVendorInvoices
        '
        Me.dgVendorInvoices.AllowUserToAddRows = False
        Me.dgVendorInvoices.AllowUserToDeleteRows = False
        Me.dgVendorInvoices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgVendorInvoices.AutoGenerateColumns = False
        Me.dgVendorInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVendorInvoices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.colInvVendorNumber, Me.colDocNumber, Me.colInvNumber, Me.InvAmountDataGridViewTextBoxColumn, Me.InvBalanceDataGridViewTextBoxColumn, Me.InvCurrencyDataGridViewTextBoxColumn, Me.colInvCartegory, Me.InvConvAmountDataGridViewTextBoxColumn, Me.PeriodDataGridViewTextBoxColumn, Me.InvDateDataGridViewTextBoxColumn, Me.InvPostDateDataGridViewTextBoxColumn, Me.InvDueDateDataGridViewTextBoxColumn, Me.InvNotesDataGridViewTextBoxColumn, Me.colInvRef, Me.InvPostedByDataGridViewTextBoxColumn, Me.colInvActive, Me.InvPaymentRefDataGridViewTextBoxColumn, Me.InvTransTypeDataGridViewTextBoxColumn, Me.btnView, Me.btnEditInvoice, Me.btnCancelInvoice, Me.btnDelete})
        Me.dgVendorInvoices.DataSource = Me.VendorInvoicesBindingSource
        Me.dgVendorInvoices.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgVendorInvoices.Location = New System.Drawing.Point(9, 226)
        Me.dgVendorInvoices.Name = "dgVendorInvoices"
        Me.dgVendorInvoices.ReadOnly = True
        Me.dgVendorInvoices.Size = New System.Drawing.Size(1412, 454)
        Me.dgVendorInvoices.TabIndex = 0
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Vendor"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'colInvVendorNumber
        '
        Me.colInvVendorNumber.DataPropertyName = "InvVendorAccNumber"
        Me.colInvVendorNumber.HeaderText = "VendorNumber"
        Me.colInvVendorNumber.Name = "colInvVendorNumber"
        Me.colInvVendorNumber.ReadOnly = True
        Me.colInvVendorNumber.Visible = False
        '
        'colDocNumber
        '
        Me.colDocNumber.DataPropertyName = "InvDocNumber"
        Me.colDocNumber.HeaderText = "DocumentNumber"
        Me.colDocNumber.Name = "colDocNumber"
        Me.colDocNumber.ReadOnly = True
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
        Me.InvAmountDataGridViewTextBoxColumn.DataPropertyName = "InvAmount"
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
        'InvCurrencyDataGridViewTextBoxColumn
        '
        Me.InvCurrencyDataGridViewTextBoxColumn.DataPropertyName = "InvCurrency"
        Me.InvCurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.InvCurrencyDataGridViewTextBoxColumn.Name = "InvCurrencyDataGridViewTextBoxColumn"
        Me.InvCurrencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvCurrencyDataGridViewTextBoxColumn.Width = 50
        '
        'colInvCartegory
        '
        Me.colInvCartegory.DataPropertyName = "InvCartegory"
        Me.colInvCartegory.HeaderText = "Cartegory"
        Me.colInvCartegory.Name = "colInvCartegory"
        Me.colInvCartegory.ReadOnly = True
        '
        'InvConvAmountDataGridViewTextBoxColumn
        '
        Me.InvConvAmountDataGridViewTextBoxColumn.DataPropertyName = "InvConvAmount"
        Me.InvConvAmountDataGridViewTextBoxColumn.HeaderText = "ConvAmount"
        Me.InvConvAmountDataGridViewTextBoxColumn.Name = "InvConvAmountDataGridViewTextBoxColumn"
        Me.InvConvAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvConvAmountDataGridViewTextBoxColumn.Visible = False
        Me.InvConvAmountDataGridViewTextBoxColumn.Width = 50
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeriodDataGridViewTextBoxColumn.Visible = False
        '
        'InvDateDataGridViewTextBoxColumn
        '
        Me.InvDateDataGridViewTextBoxColumn.DataPropertyName = "InvDate"
        Me.InvDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.InvDateDataGridViewTextBoxColumn.Name = "InvDateDataGridViewTextBoxColumn"
        Me.InvDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvPostDateDataGridViewTextBoxColumn
        '
        Me.InvPostDateDataGridViewTextBoxColumn.DataPropertyName = "InvPostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.HeaderText = "PostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.Name = "InvPostDateDataGridViewTextBoxColumn"
        Me.InvPostDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPostDateDataGridViewTextBoxColumn.Visible = False
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
        'colInvRef
        '
        Me.colInvRef.DataPropertyName = "InvRef"
        Me.colInvRef.HeaderText = "Ref"
        Me.colInvRef.Name = "colInvRef"
        Me.colInvRef.ReadOnly = True
        Me.colInvRef.Visible = False
        '
        'InvPostedByDataGridViewTextBoxColumn
        '
        Me.InvPostedByDataGridViewTextBoxColumn.DataPropertyName = "InvPostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.HeaderText = "PostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.Name = "InvPostedByDataGridViewTextBoxColumn"
        Me.InvPostedByDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPostedByDataGridViewTextBoxColumn.Visible = False
        '
        'colInvActive
        '
        Me.colInvActive.DataPropertyName = "InvActive"
        Me.colInvActive.HeaderText = "InvActive"
        Me.colInvActive.Name = "colInvActive"
        Me.colInvActive.ReadOnly = True
        Me.colInvActive.Visible = False
        '
        'InvPaymentRefDataGridViewTextBoxColumn
        '
        Me.InvPaymentRefDataGridViewTextBoxColumn.DataPropertyName = "InvPaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.HeaderText = "InvPaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.Name = "InvPaymentRefDataGridViewTextBoxColumn"
        Me.InvPaymentRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvPaymentRefDataGridViewTextBoxColumn.Visible = False
        '
        'InvTransTypeDataGridViewTextBoxColumn
        '
        Me.InvTransTypeDataGridViewTextBoxColumn.DataPropertyName = "InvTransType"
        Me.InvTransTypeDataGridViewTextBoxColumn.HeaderText = "TransType"
        Me.InvTransTypeDataGridViewTextBoxColumn.Name = "InvTransTypeDataGridViewTextBoxColumn"
        Me.InvTransTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvTransTypeDataGridViewTextBoxColumn.Visible = False
        Me.InvTransTypeDataGridViewTextBoxColumn.Width = 75
        '
        'btnView
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.btnView.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle7
        Me.btnDelete.HeaderText = ""
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Text = "CreditMemo"
        Me.btnDelete.ToolTipText = "Adjust Invoice"
        Me.btnDelete.UseColumnTextForButtonValue = True
        '
        'VendorInvoicesBindingSource
        '
        Me.VendorInvoicesBindingSource.DataMember = "VendorInvoices"
        Me.VendorInvoicesBindingSource.DataSource = Me.DsAccountsPayable
        '
        'txtVenInvoiceSearch
        '
        Me.txtVenInvoiceSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtVenInvoiceSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtVenInvoiceSearch.Location = New System.Drawing.Point(56, 200)
        Me.txtVenInvoiceSearch.Name = "txtVenInvoiceSearch"
        Me.txtVenInvoiceSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtVenInvoiceSearch.TabIndex = 68
        '
        'gbFeesPay
        '
        Me.gbFeesPay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFeesPay.Controls.Add(Me.cboInvoiceVendor)
        Me.gbFeesPay.Controls.Add(Me.cboInvoiceCompany)
        Me.gbFeesPay.Controls.Add(Label4)
        Me.gbFeesPay.Controls.Add(Me.GroupBox1)
        Me.gbFeesPay.Controls.Add(StudentIDLabel1)
        Me.gbFeesPay.Location = New System.Drawing.Point(9, 19)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(1412, 165)
        Me.gbFeesPay.TabIndex = 0
        Me.gbFeesPay.TabStop = False
        '
        'cboInvoiceVendor
        '
        Me.cboInvoiceVendor.FormattingEnabled = True
        Me.cboInvoiceVendor.Location = New System.Drawing.Point(63, 33)
        Me.cboInvoiceVendor.Name = "cboInvoiceVendor"
        Me.cboInvoiceVendor.Size = New System.Drawing.Size(200, 21)
        Me.cboInvoiceVendor.TabIndex = 67
        '
        'cboInvoiceCompany
        '
        Me.cboInvoiceCompany.DataSource = Me.VendorsBindingSource
        Me.cboInvoiceCompany.DisplayMember = "Name"
        Me.cboInvoiceCompany.FormattingEnabled = True
        Me.cboInvoiceCompany.Location = New System.Drawing.Point(63, 9)
        Me.cboInvoiceCompany.Name = "cboInvoiceCompany"
        Me.cboInvoiceCompany.Size = New System.Drawing.Size(200, 21)
        Me.cboInvoiceCompany.TabIndex = 65
        Me.cboInvoiceCompany.ValueMember = "AccNumber"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbNetAmount)
        Me.GroupBox1.Controls.Add(Me.txtNetAmount)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtVatAmount)
        Me.GroupBox1.Controls.Add(Me.cboVenVatcode)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.lbInvPath)
        Me.GroupBox1.Controls.Add(Me.mskInvDate)
        Me.GroupBox1.Controls.Add(Me.mskInvDueDate)
        Me.GroupBox1.Controls.Add(Me.cboInvCurrency)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtInvNotes)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtInvNumber)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboInvPeriod)
        Me.GroupBox1.Controls.Add(Me.txtInvAmnt)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboInvCartegory)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1381, 105)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Invoice Details"
        '
        'lbNetAmount
        '
        Me.lbNetAmount.AutoSize = True
        Me.lbNetAmount.Location = New System.Drawing.Point(544, 14)
        Me.lbNetAmount.Name = "lbNetAmount"
        Me.lbNetAmount.Size = New System.Drawing.Size(101, 13)
        Me.lbNetAmount.TabIndex = 86
        Me.lbNetAmount.Text = "Amount Before Tax:"
        '
        'txtNetAmount
        '
        Me.txtNetAmount.Enabled = False
        Me.txtNetAmount.Location = New System.Drawing.Point(547, 32)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtNetAmount.TabIndex = 83
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(441, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 13)
        Me.Label33.TabIndex = 85
        Me.Label33.Text = "Vat Amount:"
        '
        'txtVatAmount
        '
        Me.txtVatAmount.Enabled = False
        Me.txtVatAmount.Location = New System.Drawing.Point(441, 33)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.ReadOnly = True
        Me.txtVatAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtVatAmount.TabIndex = 82
        '
        'cboVenVatcode
        '
        Me.cboVenVatcode.FormattingEnabled = True
        Me.cboVenVatcode.Location = New System.Drawing.Point(339, 32)
        Me.cboVenVatcode.Name = "cboVenVatcode"
        Me.cboVenVatcode.Size = New System.Drawing.Size(96, 21)
        Me.cboVenVatcode.TabIndex = 81
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(339, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 13)
        Me.Label34.TabIndex = 84
        Me.Label34.Text = "Vat Code:"
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
        Me.mskInvDate.Location = New System.Drawing.Point(806, 29)
        Me.mskInvDate.Mask = "00/00/0000"
        Me.mskInvDate.Name = "mskInvDate"
        Me.mskInvDate.Size = New System.Drawing.Size(100, 20)
        Me.mskInvDate.TabIndex = 5
        Me.mskInvDate.ValidatingType = GetType(Date)
        '
        'mskInvDueDate
        '
        Me.mskInvDueDate.Location = New System.Drawing.Point(912, 30)
        Me.mskInvDueDate.Mask = "00/00/0000"
        Me.mskInvDueDate.Name = "mskInvDueDate"
        Me.mskInvDueDate.Size = New System.Drawing.Size(100, 20)
        Me.mskInvDueDate.TabIndex = 6
        Me.mskInvDueDate.ValidatingType = GetType(Date)
        '
        'cboInvCurrency
        '
        Me.cboInvCurrency.FormattingEnabled = True
        Me.cboInvCurrency.Location = New System.Drawing.Point(654, 29)
        Me.cboInvCurrency.Name = "cboInvCurrency"
        Me.cboInvCurrency.Size = New System.Drawing.Size(53, 21)
        Me.cboInvCurrency.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(651, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Currency:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1223, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 34)
        Me.Button2.TabIndex = 9
        Me.Button2.Tag = " "
        Me.Button2.Text = "Save Invoice"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtInvNotes
        '
        Me.txtInvNotes.Location = New System.Drawing.Point(1018, 29)
        Me.txtInvNotes.Multiline = True
        Me.txtInvNotes.Name = "txtInvNotes"
        Me.txtInvNotes.Size = New System.Drawing.Size(199, 69)
        Me.txtInvNotes.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1015, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Notes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(909, 13)
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
        Me.Label14.Location = New System.Drawing.Point(803, 13)
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
        Me.cboInvPeriod.Location = New System.Drawing.Point(708, 29)
        Me.cboInvPeriod.Name = "cboInvPeriod"
        Me.cboInvPeriod.Size = New System.Drawing.Size(96, 21)
        Me.cboInvPeriod.TabIndex = 4
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
        Me.Label13.Location = New System.Drawing.Point(708, 15)
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
        'tbVendorPayments
        '
        Me.tbVendorPayments.Controls.Add(Me.SplitContainer3)
        Me.tbVendorPayments.Location = New System.Drawing.Point(4, 22)
        Me.tbVendorPayments.Name = "tbVendorPayments"
        Me.tbVendorPayments.Size = New System.Drawing.Size(1610, 725)
        Me.tbVendorPayments.TabIndex = 2
        Me.tbVendorPayments.Text = "Vendor Payments"
        Me.tbVendorPayments.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Panel1Collapsed = True
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(1610, 725)
        Me.SplitContainer3.SplitterDistance = 286
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.pnlInvoicedExpenditure)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1610, 725)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Expenditure"
        '
        'pnlInvoicedExpenditure
        '
        Me.pnlInvoicedExpenditure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlInvoicedExpenditure.Controls.Add(Me.GroupBox9)
        Me.pnlInvoicedExpenditure.Controls.Add(Me.GroupBox8)
        Me.pnlInvoicedExpenditure.Controls.Add(Me.Label27)
        Me.pnlInvoicedExpenditure.Controls.Add(Me.dgPayInvoice)
        Me.pnlInvoicedExpenditure.Controls.Add(Me.Button4)
        Me.pnlInvoicedExpenditure.Location = New System.Drawing.Point(6, 275)
        Me.pnlInvoicedExpenditure.Name = "pnlInvoicedExpenditure"
        Me.pnlInvoicedExpenditure.Size = New System.Drawing.Size(1316, 444)
        Me.pnlInvoicedExpenditure.TabIndex = 43
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Label36)
        Me.GroupBox9.Controls.Add(Me.btnPayInvoiceRefeesh)
        Me.GroupBox9.Controls.Add(Me.btnPayInvoiceSearch)
        Me.GroupBox9.Controls.Add(Me.txtPayInvoiceSearchh)
        Me.GroupBox9.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(263, 32)
        Me.GroupBox9.TabIndex = 45
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Search"
        '
        'btnPayInvoiceRefeesh
        '
        Me.btnPayInvoiceRefeesh.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.btnPayInvoiceRefeesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayInvoiceRefeesh.Location = New System.Drawing.Point(238, 8)
        Me.btnPayInvoiceRefeesh.Name = "btnPayInvoiceRefeesh"
        Me.btnPayInvoiceRefeesh.Size = New System.Drawing.Size(19, 20)
        Me.btnPayInvoiceRefeesh.TabIndex = 75
        Me.btnPayInvoiceRefeesh.UseVisualStyleBackColor = True
        '
        'btnPayInvoiceSearch
        '
        Me.btnPayInvoiceSearch.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnPayInvoiceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayInvoiceSearch.Location = New System.Drawing.Point(219, 8)
        Me.btnPayInvoiceSearch.Name = "btnPayInvoiceSearch"
        Me.btnPayInvoiceSearch.Size = New System.Drawing.Size(19, 20)
        Me.btnPayInvoiceSearch.TabIndex = 74
        Me.btnPayInvoiceSearch.UseVisualStyleBackColor = True
        '
        'txtPayInvoiceSearchh
        '
        Me.txtPayInvoiceSearchh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPayInvoiceSearchh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtPayInvoiceSearchh.Location = New System.Drawing.Point(56, 8)
        Me.txtPayInvoiceSearchh.Name = "txtPayInvoiceSearchh"
        Me.txtPayInvoiceSearchh.Size = New System.Drawing.Size(157, 20)
        Me.txtPayInvoiceSearchh.TabIndex = 73
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkShowPayments)
        Me.GroupBox8.Location = New System.Drawing.Point(276, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(253, 36)
        Me.GroupBox8.TabIndex = 44
        Me.GroupBox8.TabStop = False
        '
        'chkShowPayments
        '
        Me.chkShowPayments.AutoSize = True
        Me.chkShowPayments.Location = New System.Drawing.Point(4, 13)
        Me.chkShowPayments.Name = "chkShowPayments"
        Me.chkShowPayments.Size = New System.Drawing.Size(102, 17)
        Me.chkShowPayments.TabIndex = 65
        Me.chkShowPayments.Text = "Show Payments"
        Me.chkShowPayments.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(563, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 13)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Select invoices to pay"
        '
        'dgPayInvoice
        '
        Me.dgPayInvoice.AllowUserToAddRows = False
        Me.dgPayInvoice.AllowUserToDeleteRows = False
        Me.dgPayInvoice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgPayInvoice.AutoGenerateColumns = False
        Me.dgPayInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkPayInvoice, Me.Vendor, Me.colInvPayAccountNumber, Me.ColPayInvTransType, Me.colPayInvNumber, Me.colExpCartegory, Me.colInvPayConvAmount, Me.InvBalanceDataGridViewTextBoxColumn1, Me.colInvPayAmnt, Me.colPayDocNumber, Me.colPayNotes, Me.InvNotesDataGridViewTextBoxColumn1, Me.ColPayInvRef, Me.btnPayView, Me.btnPayCancel})
        Me.dgPayInvoice.DataSource = Me.VendorInvoicesBindingSource
        Me.dgPayInvoice.Location = New System.Drawing.Point(3, 42)
        Me.dgPayInvoice.Name = "dgPayInvoice"
        Me.dgPayInvoice.Size = New System.Drawing.Size(1259, 350)
        Me.dgPayInvoice.TabIndex = 1
        '
        'chkPayInvoice
        '
        Me.chkPayInvoice.HeaderText = "Pay Invoice"
        Me.chkPayInvoice.Name = "chkPayInvoice"
        '
        'Vendor
        '
        Me.Vendor.DataPropertyName = "Description"
        Me.Vendor.HeaderText = "Vendor"
        Me.Vendor.Name = "Vendor"
        Me.Vendor.ReadOnly = True
        '
        'colInvPayAccountNumber
        '
        Me.colInvPayAccountNumber.DataPropertyName = "InvVendorAccNumber"
        Me.colInvPayAccountNumber.HeaderText = "AccountNumber"
        Me.colInvPayAccountNumber.Name = "colInvPayAccountNumber"
        Me.colInvPayAccountNumber.Visible = False
        '
        'ColPayInvTransType
        '
        Me.ColPayInvTransType.DataPropertyName = "InvTransType"
        Me.ColPayInvTransType.HeaderText = "TransType"
        Me.ColPayInvTransType.Name = "ColPayInvTransType"
        '
        'colPayInvNumber
        '
        Me.colPayInvNumber.DataPropertyName = "InvoiceNumber"
        Me.colPayInvNumber.HeaderText = "InvoiceNumber"
        Me.colPayInvNumber.Name = "colPayInvNumber"
        Me.colPayInvNumber.ReadOnly = True
        '
        'colExpCartegory
        '
        Me.colExpCartegory.DataPropertyName = "InvCartegory"
        Me.colExpCartegory.HeaderText = "ExpenseCartegory"
        Me.colExpCartegory.Name = "colExpCartegory"
        Me.colExpCartegory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colExpCartegory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colInvPayConvAmount
        '
        Me.colInvPayConvAmount.DataPropertyName = "InvConvAmount"
        Me.colInvPayConvAmount.HeaderText = "Amount"
        Me.colInvPayConvAmount.Name = "colInvPayConvAmount"
        Me.colInvPayConvAmount.ReadOnly = True
        '
        'InvBalanceDataGridViewTextBoxColumn1
        '
        Me.InvBalanceDataGridViewTextBoxColumn1.DataPropertyName = "InvBalance"
        Me.InvBalanceDataGridViewTextBoxColumn1.HeaderText = "Balance"
        Me.InvBalanceDataGridViewTextBoxColumn1.Name = "InvBalanceDataGridViewTextBoxColumn1"
        Me.InvBalanceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'colInvPayAmnt
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Yellow
        Me.colInvPayAmnt.DefaultCellStyle = DataGridViewCellStyle8
        Me.colInvPayAmnt.HeaderText = "PayAmount"
        Me.colInvPayAmnt.Name = "colInvPayAmnt"
        '
        'colPayDocNumber
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Yellow
        Me.colPayDocNumber.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPayDocNumber.HeaderText = "Receipt/Ref"
        Me.colPayDocNumber.Name = "colPayDocNumber"
        '
        'colPayNotes
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Yellow
        Me.colPayNotes.DefaultCellStyle = DataGridViewCellStyle10
        Me.colPayNotes.HeaderText = "Comment"
        Me.colPayNotes.Name = "colPayNotes"
        '
        'InvNotesDataGridViewTextBoxColumn1
        '
        Me.InvNotesDataGridViewTextBoxColumn1.DataPropertyName = "InvNotes"
        Me.InvNotesDataGridViewTextBoxColumn1.HeaderText = "Notes"
        Me.InvNotesDataGridViewTextBoxColumn1.Name = "InvNotesDataGridViewTextBoxColumn1"
        Me.InvNotesDataGridViewTextBoxColumn1.ReadOnly = True
        Me.InvNotesDataGridViewTextBoxColumn1.Visible = False
        '
        'ColPayInvRef
        '
        Me.ColPayInvRef.DataPropertyName = "InvRef"
        Me.ColPayInvRef.HeaderText = "InvRef"
        Me.ColPayInvRef.Name = "ColPayInvRef"
        Me.ColPayInvRef.ReadOnly = True
        Me.ColPayInvRef.Visible = False
        '
        'btnPayView
        '
        Me.btnPayView.HeaderText = ""
        Me.btnPayView.Name = "btnPayView"
        Me.btnPayView.Text = "View"
        Me.btnPayView.UseColumnTextForButtonValue = True
        '
        'btnPayCancel
        '
        Me.btnPayCancel.HeaderText = ""
        Me.btnPayCancel.Name = "btnPayCancel"
        Me.btnPayCancel.Text = "Reverse"
        Me.btnPayCancel.UseColumnTextForButtonValue = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(487, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 34)
        Me.Button4.TabIndex = 42
        Me.Button4.Tag = " "
        Me.Button4.Text = "Pay Selected "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.Controls.Add(Label31)
        Me.GroupBox3.Controls.Add(Me.cboExpenseCompany)
        Me.GroupBox3.Controls.Add(Me.cboInvPayPeriod)
        Me.GroupBox3.Controls.Add(Label25)
        Me.GroupBox3.Controls.Add(Me.pnlUnimvoicedExpense)
        Me.GroupBox3.Controls.Add(Me.pnlPay)
        Me.GroupBox3.Controls.Add(Label20)
        Me.GroupBox3.Controls.Add(Label19)
        Me.GroupBox3.Controls.Add(Me.mskInvPayDate)
        Me.GroupBox3.Controls.Add(Me.cboPayTransType)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1316, 250)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'cboExpenseCompany
        '
        Me.cboExpenseCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpenseCompany.FormattingEnabled = True
        Me.cboExpenseCompany.Items.AddRange(New Object() {"Invoiced", "UnInvoiced"})
        Me.cboExpenseCompany.Location = New System.Drawing.Point(72, 22)
        Me.cboExpenseCompany.Name = "cboExpenseCompany"
        Me.cboExpenseCompany.Size = New System.Drawing.Size(113, 21)
        Me.cboExpenseCompany.TabIndex = 74
        '
        'cboInvPayPeriod
        '
        Me.cboInvPayPeriod.DisplayMember = "Description"
        Me.cboInvPayPeriod.FormattingEnabled = True
        Me.cboInvPayPeriod.Location = New System.Drawing.Point(72, 95)
        Me.cboInvPayPeriod.Name = "cboInvPayPeriod"
        Me.cboInvPayPeriod.Size = New System.Drawing.Size(114, 21)
        Me.cboInvPayPeriod.TabIndex = 73
        Me.cboInvPayPeriod.ValueMember = "AccountNumber"
        '
        'pnlUnimvoicedExpense
        '
        Me.pnlUnimvoicedExpense.Controls.Add(Me.lbPaymentsNet)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.txtPaymentsNetAmount)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.Label37)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.txtPaymentsVat)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.cboPaymentsVat)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.Label38)
        Me.pnlUnimvoicedExpense.Controls.Add(Label24)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.txtPayComment)
        Me.pnlUnimvoicedExpense.Controls.Add(Label23)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.txtPayReceipt)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.btnPayNonInv)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.cboUnivoicedPayCartegory)
        Me.pnlUnimvoicedExpense.Controls.Add(Label22)
        Me.pnlUnimvoicedExpense.Controls.Add(Label26)
        Me.pnlUnimvoicedExpense.Controls.Add(Me.cboPaymentsVendor)
        Me.pnlUnimvoicedExpense.Location = New System.Drawing.Point(4, 173)
        Me.pnlUnimvoicedExpense.Name = "pnlUnimvoicedExpense"
        Me.pnlUnimvoicedExpense.Size = New System.Drawing.Size(1304, 63)
        Me.pnlUnimvoicedExpense.TabIndex = 71
        '
        'lbPaymentsNet
        '
        Me.lbPaymentsNet.AutoSize = True
        Me.lbPaymentsNet.Location = New System.Drawing.Point(671, 10)
        Me.lbPaymentsNet.Name = "lbPaymentsNet"
        Me.lbPaymentsNet.Size = New System.Drawing.Size(101, 13)
        Me.lbPaymentsNet.TabIndex = 92
        Me.lbPaymentsNet.Text = "Amount Before Tax:"
        '
        'txtPaymentsNetAmount
        '
        Me.txtPaymentsNetAmount.Enabled = False
        Me.txtPaymentsNetAmount.Location = New System.Drawing.Point(672, 26)
        Me.txtPaymentsNetAmount.Name = "txtPaymentsNetAmount"
        Me.txtPaymentsNetAmount.ReadOnly = True
        Me.txtPaymentsNetAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsNetAmount.TabIndex = 89
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(568, 10)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 13)
        Me.Label37.TabIndex = 91
        Me.Label37.Text = "Vat Amount:"
        '
        'txtPaymentsVat
        '
        Me.txtPaymentsVat.Enabled = False
        Me.txtPaymentsVat.Location = New System.Drawing.Point(571, 26)
        Me.txtPaymentsVat.Name = "txtPaymentsVat"
        Me.txtPaymentsVat.ReadOnly = True
        Me.txtPaymentsVat.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentsVat.TabIndex = 88
        '
        'cboPaymentsVat
        '
        Me.cboPaymentsVat.FormattingEnabled = True
        Me.cboPaymentsVat.Location = New System.Drawing.Point(474, 26)
        Me.cboPaymentsVat.Name = "cboPaymentsVat"
        Me.cboPaymentsVat.Size = New System.Drawing.Size(96, 21)
        Me.cboPaymentsVat.TabIndex = 87
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(471, 10)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(54, 13)
        Me.Label38.TabIndex = 90
        Me.Label38.Text = "Vat Code:"
        '
        'txtPayComment
        '
        Me.txtPayComment.Location = New System.Drawing.Point(970, 26)
        Me.txtPayComment.Multiline = True
        Me.txtPayComment.Name = "txtPayComment"
        Me.txtPayComment.Size = New System.Drawing.Size(196, 33)
        Me.txtPayComment.TabIndex = 73
        '
        'txtPayReceipt
        '
        Me.txtPayReceipt.Location = New System.Drawing.Point(773, 26)
        Me.txtPayReceipt.Name = "txtPayReceipt"
        Me.txtPayReceipt.Size = New System.Drawing.Size(196, 20)
        Me.txtPayReceipt.TabIndex = 71
        '
        'btnPayNonInv
        '
        Me.btnPayNonInv.BackColor = System.Drawing.Color.Green
        Me.btnPayNonInv.ForeColor = System.Drawing.Color.White
        Me.btnPayNonInv.Location = New System.Drawing.Point(1168, 26)
        Me.btnPayNonInv.Name = "btnPayNonInv"
        Me.btnPayNonInv.Size = New System.Drawing.Size(125, 34)
        Me.btnPayNonInv.TabIndex = 70
        Me.btnPayNonInv.Tag = " "
        Me.btnPayNonInv.Text = "Pay"
        Me.btnPayNonInv.UseVisualStyleBackColor = False
        '
        'cboUnivoicedPayCartegory
        '
        Me.cboUnivoicedPayCartegory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorsBindingSource, "AccountGroup", True))
        Me.cboUnivoicedPayCartegory.DisplayMember = "AccountNumber"
        Me.cboUnivoicedPayCartegory.FormattingEnabled = True
        Me.cboUnivoicedPayCartegory.Location = New System.Drawing.Point(272, 26)
        Me.cboUnivoicedPayCartegory.Name = "cboUnivoicedPayCartegory"
        Me.cboUnivoicedPayCartegory.Size = New System.Drawing.Size(198, 21)
        Me.cboUnivoicedPayCartegory.TabIndex = 69
        Me.cboUnivoicedPayCartegory.ValueMember = "AccountNumber"
        '
        'cboPaymentsVendor
        '
        Me.cboPaymentsVendor.DataSource = Me.VendorsBindingSource
        Me.cboPaymentsVendor.DisplayMember = "Name"
        Me.cboPaymentsVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentsVendor.FormattingEnabled = True
        Me.cboPaymentsVendor.Location = New System.Drawing.Point(71, 26)
        Me.cboPaymentsVendor.Name = "cboPaymentsVendor"
        Me.cboPaymentsVendor.Size = New System.Drawing.Size(200, 21)
        Me.cboPaymentsVendor.TabIndex = 59
        Me.cboPaymentsVendor.ValueMember = "AccNumber"
        '
        'pnlPay
        '
        Me.pnlPay.Controls.Add(Me.txtBankBalance)
        Me.pnlPay.Controls.Add(Me.Label21)
        Me.pnlPay.Controls.Add(Me.cboPayCurrency)
        Me.pnlPay.Controls.Add(Me.cboVendorPaymentsPayFrom)
        Me.pnlPay.Controls.Add(Label18)
        Me.pnlPay.Controls.Add(Label17)
        Me.pnlPay.Controls.Add(Me.txtExpenseAmnt)
        Me.pnlPay.Location = New System.Drawing.Point(7, 114)
        Me.pnlPay.Name = "pnlPay"
        Me.pnlPay.Size = New System.Drawing.Size(471, 53)
        Me.pnlPay.TabIndex = 67
        Me.pnlPay.Visible = False
        '
        'txtBankBalance
        '
        Me.txtBankBalance.Location = New System.Drawing.Point(327, 28)
        Me.txtBankBalance.Name = "txtBankBalance"
        Me.txtBankBalance.ReadOnly = True
        Me.txtBankBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtBankBalance.TabIndex = 64
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(272, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Balance:"
        '
        'cboPayCurrency
        '
        Me.cboPayCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayCurrency.FormattingEnabled = True
        Me.cboPayCurrency.Items.AddRange(New Object() {"Payment", "Reversal"})
        Me.cboPayCurrency.Location = New System.Drawing.Point(184, 4)
        Me.cboPayCurrency.Name = "cboPayCurrency"
        Me.cboPayCurrency.Size = New System.Drawing.Size(84, 21)
        Me.cboPayCurrency.TabIndex = 63
        '
        'cboVendorPaymentsPayFrom
        '
        Me.cboVendorPaymentsPayFrom.DisplayMember = "Description"
        Me.cboVendorPaymentsPayFrom.FormattingEnabled = True
        Me.cboVendorPaymentsPayFrom.Location = New System.Drawing.Point(65, 27)
        Me.cboVendorPaymentsPayFrom.Name = "cboVendorPaymentsPayFrom"
        Me.cboVendorPaymentsPayFrom.Size = New System.Drawing.Size(198, 21)
        Me.cboVendorPaymentsPayFrom.TabIndex = 56
        Me.cboVendorPaymentsPayFrom.ValueMember = "AccountNumber"
        '
        'txtExpenseAmnt
        '
        Me.txtExpenseAmnt.Location = New System.Drawing.Point(65, 4)
        Me.txtExpenseAmnt.Name = "txtExpenseAmnt"
        Me.txtExpenseAmnt.Size = New System.Drawing.Size(113, 20)
        Me.txtExpenseAmnt.TabIndex = 53
        '
        'mskInvPayDate
        '
        Me.mskInvPayDate.Location = New System.Drawing.Point(72, 69)
        Me.mskInvPayDate.Mask = "00/00/0000"
        Me.mskInvPayDate.Name = "mskInvPayDate"
        Me.mskInvPayDate.Size = New System.Drawing.Size(113, 20)
        Me.mskInvPayDate.TabIndex = 62
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
        Me.cboPayTransType.TabIndex = 60
        '
        'AccountCartegoriesBindingSource
        '
        Me.AccountCartegoriesBindingSource.DataMember = "AccountCartegories"
        Me.AccountCartegoriesBindingSource.DataSource = Me.DsAccountsSettings
        '
        'DsAccountsSettings
        '
        Me.DsAccountsSettings.DataSetName = "dsAccountsSettings"
        Me.DsAccountsSettings.EnforceConstraints = False
        Me.DsAccountsSettings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = IncomeExpenditure.dsAccountsPayableTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VendorInvoicesTableAdapter
        '
        Me.VendorInvoicesTableAdapter.ClearBeforeFill = True
        '
        'AccountCartegoriesTableAdapter
        '
        Me.AccountCartegoriesTableAdapter.ClearBeforeFill = True
        '
        'VendorStatementTableAdapter
        '
        Me.VendorStatementTableAdapter.ClearBeforeFill = True
        '
        'GLStatementTableAdapter
        '
        Me.GLStatementTableAdapter.ClearBeforeFill = True
        '
        'frmLiabilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1632, 783)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "frmLiabilities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payables"
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbPayabless.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tbVendors.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.gbStudPersonalDetails.ResumeLayout(False)
        Me.gbStudPersonalDetails.PerformLayout()
        Me.tbVendor.ResumeLayout(False)
        Me.tbVendContact.ResumeLayout(False)
        Me.tbVendContact.PerformLayout()
        Me.tbVenVAT.ResumeLayout(False)
        Me.tbVenVAT.PerformLayout()
        Me.tbPayments.ResumeLayout(False)
        Me.tbPayments.PerformLayout()
        Me.tbVenBankDetails.ResumeLayout(False)
        Me.tbVenBankDetails.PerformLayout()
        Me.tbVenOthers.ResumeLayout(False)
        Me.tbVenOthers.PerformLayout()
        Me.tbVenNotes.ResumeLayout(False)
        Me.tbVenNotes.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.tbInvoices.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.gbInvoiceOptions.ResumeLayout(False)
        Me.gbInvoiceOptions.PerformLayout()
        CType(Me.dgVendorInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbVendorPayments.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.pnlInvoicedExpenditure.ResumeLayout(False)
        Me.pnlInvoicedExpenditure.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.dgPayInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.pnlUnimvoicedExpense.ResumeLayout(False)
        Me.pnlUnimvoicedExpense.PerformLayout()
        Me.pnlPay.ResumeLayout(False)
        Me.pnlPay.PerformLayout()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents tbPayabless As Windows.Forms.TabPage
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents tbVendors As Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents gbStudPersonalDetails As Windows.Forms.GroupBox
    Friend WithEvents txtVendorBankDetails As Windows.Forms.TextBox
    Friend WithEvents txtVendorAddress As Windows.Forms.TextBox
    Friend WithEvents txtVendorEmail As Windows.Forms.TextBox
    Friend WithEvents txtVendorContNummber As Windows.Forms.TextBox
    Friend WithEvents txtVendorContName As Windows.Forms.TextBox
    Friend WithEvents cboVendorCurrency As Windows.Forms.ComboBox
    Friend WithEvents txtVendorName As Windows.Forms.TextBox
    Friend WithEvents txtVendorAccNumber As Windows.Forms.TextBox
    Friend WithEvents tbInvoices As Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents dgVendorInvoices As Windows.Forms.DataGridView
    Friend WithEvents gbFeesPay As Windows.Forms.GroupBox
    Friend WithEvents txtVendorBalance As Windows.Forms.TextBox
    Friend WithEvents txtVendorNotes As Windows.Forms.TextBox
    Friend WithEvents txtVendorCountry As Windows.Forms.TextBox
    Friend WithEvents txtVendorCity As Windows.Forms.TextBox
    Friend WithEvents cboInvCartegory As Windows.Forms.ComboBox
    Friend WithEvents txtInvAmnt As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtInvNumber As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents cboInvPeriod As Windows.Forms.ComboBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txtInvNotes As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents tbVendorPayments As Windows.Forms.TabPage
    Friend WithEvents SplitContainer3 As Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents dgPayInvoice As Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents cboVendorPaymentsPayFrom As Windows.Forms.ComboBox
    Friend WithEvents txtExpenseAmnt As Windows.Forms.TextBox
    Friend WithEvents DsAccountsPayable As dsAccountsPayable
    Friend WithEvents VendorsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As dsAccountsPayableTableAdapters.VendorsTableAdapter
    Friend WithEvents TableAdapterManager As dsAccountsPayableTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents txtVendorAccRef As Windows.Forms.TextBox
    Friend WithEvents btnSearchVendor As Windows.Forms.Button
    Friend WithEvents lstResult As Windows.Forms.ListBox
    Friend WithEvents ttxVendorSearchtext As Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents mskInvDate As Windows.Forms.MaskedTextBox
    Friend WithEvents mskInvDueDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboInvCurrency As Windows.Forms.ComboBox
    Friend WithEvents VendorInvoicesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorInvoicesTableAdapter As dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter
    Friend WithEvents InvClearedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DsAccountsSettings As dsAccountsSettings
    Friend WithEvents AccountCartegoriesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountCartegoriesTableAdapter As dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter
    Friend WithEvents mskInvPayDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboPayTransType As Windows.Forms.ComboBox
    Friend WithEvents cboPaymentsVendor As Windows.Forms.ComboBox
    Friend WithEvents cboPayCurrency As Windows.Forms.ComboBox
    Friend WithEvents txtBankBalance As Windows.Forms.TextBox
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents pnlPay As Windows.Forms.Panel
    Friend WithEvents pnlInvoicedExpenditure As Windows.Forms.Panel
    Friend WithEvents pnlUnimvoicedExpense As Windows.Forms.Panel
    Friend WithEvents btnPayNonInv As Windows.Forms.Button
    Friend WithEvents cboUnivoicedPayCartegory As Windows.Forms.ComboBox
    Friend WithEvents txtPayComment As Windows.Forms.TextBox
    Friend WithEvents txtPayReceipt As Windows.Forms.TextBox
    Friend WithEvents gbInvoiceOptions As Windows.Forms.GroupBox
    Friend WithEvents chkDisplayCncelledInvoices As Windows.Forms.CheckBox
    Friend WithEvents Label27 As Windows.Forms.Label
    Friend WithEvents cboInvPayPeriod As Windows.Forms.ComboBox
    Friend WithEvents lbInvPath As Windows.Forms.Label
    Friend WithEvents TabControl3 As Windows.Forms.TabControl
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents cboVenStatCurrentPeriod As Windows.Forms.ComboBox
    Friend WithEvents chkVenStatShowReversals As Windows.Forms.CheckBox
    Friend WithEvents chkVenStatShowPayments As Windows.Forms.CheckBox
    Friend WithEvents chkVenStatShowInvoices As Windows.Forms.CheckBox
    Friend WithEvents VendorStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorStatementTableAdapter As dsAccountsPayableTableAdapters.VendorStatementTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankDetailsDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlockedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cboVendorCompany As Windows.Forms.ComboBox
    Friend WithEvents cboInvoiceCompany As Windows.Forms.ComboBox
    Friend WithEvents cboExpenseCompany As Windows.Forms.ComboBox
    Friend WithEvents GLStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsCoA As dsCoA
    Friend WithEvents GLStatementTableAdapter As dsCoATableAdapters.GLStatementTableAdapter
    Friend WithEvents tbVendor As Windows.Forms.TabControl
    Friend WithEvents tbVendContact As Windows.Forms.TabPage
    Friend WithEvents tbVenBankDetails As Windows.Forms.TabPage
    Friend WithEvents tbPayments As Windows.Forms.TabPage
    Friend WithEvents tbVenOthers As Windows.Forms.TabPage
    Friend WithEvents tbVenNotes As Windows.Forms.TabPage
    Friend WithEvents tbVenVAT As Windows.Forms.TabPage
    Friend WithEvents chkVendorIsBLocked As Windows.Forms.CheckBox
    Friend WithEvents cboVendorVatAccount As Windows.Forms.ComboBox
    Friend WithEvents TaxRegTextBox As Windows.Forms.TextBox
    Friend WithEvents TaxCodeComboBox As Windows.Forms.ComboBox
    Friend WithEvents PaymentTermsComboBox As Windows.Forms.ComboBox
    Friend WithEvents lbNetAmount As Windows.Forms.Label
    Friend WithEvents txtNetAmount As Windows.Forms.TextBox
    Friend WithEvents Label33 As Windows.Forms.Label
    Friend WithEvents txtVatAmount As Windows.Forms.TextBox
    Friend WithEvents cboVenVatcode As Windows.Forms.ComboBox
    Friend WithEvents Label34 As Windows.Forms.Label
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents chkShowPayments As Windows.Forms.CheckBox
    Friend WithEvents cboInvoiceVendor As Windows.Forms.ComboBox
    Friend WithEvents btnVenInvSearchRefresh As Windows.Forms.Button
    Friend WithEvents btnVenInvoiceSearch As Windows.Forms.Button
    Friend WithEvents txtVenInvoiceSearch As Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As Windows.Forms.GroupBox
    Friend WithEvents btnPayInvoiceRefeesh As Windows.Forms.Button
    Friend WithEvents btnPayInvoiceSearch As Windows.Forms.Button
    Friend WithEvents txtPayInvoiceSearchh As Windows.Forms.TextBox
    Friend WithEvents Description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvVendorNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvCartegory As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvConvAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDueDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNotesDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvRef As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostedByDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvActive As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InvPaymentRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvTransTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnView As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnEditInvoice As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCancelInvoice As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnDelete As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents chkPayInvoice As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Vendor As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvPayAccountNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPayInvTransType As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayInvNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colExpCartegory As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colInvPayConvAmount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBalanceDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvPayAmnt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayDocNumber As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPayNotes As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNotesDataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPayInvRef As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPayView As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnPayCancel As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lbPaymentsNet As Windows.Forms.Label
    Friend WithEvents txtPaymentsNetAmount As Windows.Forms.TextBox
    Friend WithEvents Label37 As Windows.Forms.Label
    Friend WithEvents txtPaymentsVat As Windows.Forms.TextBox
    Friend WithEvents cboPaymentsVat As Windows.Forms.ComboBox
    Friend WithEvents Label38 As Windows.Forms.Label
End Class
