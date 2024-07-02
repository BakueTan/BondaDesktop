<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountingSettings
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
        Dim SchoolLabel As System.Windows.Forms.Label
        Dim DocNameLabel As System.Windows.Forms.Label
        Dim DocFromLabel As System.Windows.Forms.Label
        Dim DocToLabel As System.Windows.Forms.Label
        Dim CurrentDocLabel As System.Windows.Forms.Label
        Dim AccountingPeriodLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim OpenLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim CurrencyLabel As System.Windows.Forms.Label
        Dim FiscalYearLabel As System.Windows.Forms.Label
        Dim TaxDescriptionLabel As System.Windows.Forms.Label
        Dim TaxRateLabel As System.Windows.Forms.Label
        Dim TaxInclusiveLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim CartegoryLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountingSettings))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbAccSettings = New System.Windows.Forms.TabControl()
        Me.tbCompanies = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BindingNavigator5 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton()
        Me.AccountingCompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsSettings = New IncomeExpenditure.dsAccountsSettings()
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
        Me.ToolStripButton35 = New System.Windows.Forms.ToolStripButton()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.CurrencyComboBox = New System.Windows.Forms.ComboBox()
        Me.CompanyRefLabel1 = New System.Windows.Forms.Label()
        Me.tbAccDocuments = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AccountingDocumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.AccountingDocumentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbAccNumbers = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SchoolComboBox = New System.Windows.Forms.ComboBox()
        Me.AccountNumberValueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefIdTextBox = New System.Windows.Forms.TextBox()
        Me.DocNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DocFromTextBox = New System.Windows.Forms.TextBox()
        Me.DocToTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentDocTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.AccountNumberValueDataGridView = New System.Windows.Forms.DataGridView()
        Me.Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RefID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AccountCartegoriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Cartegory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCartegoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CartegoryTextBox = New System.Windows.Forms.TextBox()
        Me.CartRefTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccountingPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FiscalYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountingPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FiscalYearComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton27 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton28 = New System.Windows.Forms.ToolStripButton()
        Me.AccountingPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.OpenCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator6 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton36 = New System.Windows.Forms.ToolStripButton()
        Me.VATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton37 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton38 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton39 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton40 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton41 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton42 = New System.Windows.Forms.ToolStripButton()
        Me.TaxDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.TaxRateTextBox = New System.Windows.Forms.TextBox()
        Me.TaxInclusiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.TaxRefTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BindingNavigator7 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton43 = New System.Windows.Forms.ToolStripButton()
        Me.PaymentTermsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton44 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton45 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton46 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton47 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton48 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton49 = New System.Windows.Forms.ToolStripButton()
        Me.txtPaymentTerm = New System.Windows.Forms.TextBox()
        Me.txtPaymentDays = New System.Windows.Forms.TextBox()
        Me.txtPaymentRef = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BindingNavigator8 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton50 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton51 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton52 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox8 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton53 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton54 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton55 = New System.Windows.Forms.ToolStripButton()
        Me.AccountNumberValueTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountNumberValueTableAdapter()
        Me.TableAdapterManager = New IncomeExpenditure.dsAccountsSettingsTableAdapters.TableAdapterManager()
        Me.AccountCartegoriesTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter()
        Me.AccountingDocumentsTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountingDocumentsTableAdapter()
        Me.AccountingPeriodsTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountingPeriodsTableAdapter()
        Me.AccountingCompaniesTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountingCompaniesTableAdapter()
        Me.DsCoA = New IncomeExpenditure.dsCoA()
        Me.ChartOfAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChartOfAccountsTableAdapter = New IncomeExpenditure.dsCoATableAdapters.ChartOfAccountsTableAdapter()
        Me.VATTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.VATTableAdapter()
        Me.PaymentTermsTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.PaymentTermsTableAdapter()
        Me.btnSettingsRefresh = New System.Windows.Forms.Button()
        Me.AccountSubTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountSubTypeTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountSubTypeTableAdapter()
        Me.SubTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkAccSubTypes = New System.Windows.Forms.CheckedListBox()
        Me.cboAccTypeSubType_AccType = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        SchoolLabel = New System.Windows.Forms.Label()
        DocNameLabel = New System.Windows.Forms.Label()
        DocFromLabel = New System.Windows.Forms.Label()
        DocToLabel = New System.Windows.Forms.Label()
        CurrentDocLabel = New System.Windows.Forms.Label()
        AccountingPeriodLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        OpenLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        CurrencyLabel = New System.Windows.Forms.Label()
        FiscalYearLabel = New System.Windows.Forms.Label()
        TaxDescriptionLabel = New System.Windows.Forms.Label()
        TaxRateLabel = New System.Windows.Forms.Label()
        TaxInclusiveLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CartegoryLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.tbAccSettings.SuspendLayout()
        Me.tbCompanies.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        CType(Me.AccountingCompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAccDocuments.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.AccountingDocumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountingDocumentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAccNumbers.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AccountNumberValueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.AccountNumberValueDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AccountCartegoriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountingPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator6.SuspendLayout()
        CType(Me.VATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator7.SuspendLayout()
        CType(Me.PaymentTermsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator8.SuspendLayout()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountSubTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchoolLabel
        '
        SchoolLabel.AutoSize = True
        SchoolLabel.Location = New System.Drawing.Point(22, 52)
        SchoolLabel.Name = "SchoolLabel"
        SchoolLabel.Size = New System.Drawing.Size(54, 13)
        SchoolLabel.TabIndex = 2
        SchoolLabel.Text = "Company:"
        '
        'DocNameLabel
        '
        DocNameLabel.AutoSize = True
        DocNameLabel.Location = New System.Drawing.Point(22, 79)
        DocNameLabel.Name = "DocNameLabel"
        DocNameLabel.Size = New System.Drawing.Size(61, 13)
        DocNameLabel.TabIndex = 6
        DocNameLabel.Text = "Doc Name:"
        '
        'DocFromLabel
        '
        DocFromLabel.AutoSize = True
        DocFromLabel.Location = New System.Drawing.Point(22, 106)
        DocFromLabel.Name = "DocFromLabel"
        DocFromLabel.Size = New System.Drawing.Size(67, 13)
        DocFromLabel.TabIndex = 8
        DocFromLabel.Text = "Min Number:"
        '
        'DocToLabel
        '
        DocToLabel.AutoSize = True
        DocToLabel.Location = New System.Drawing.Point(22, 136)
        DocToLabel.Name = "DocToLabel"
        DocToLabel.Size = New System.Drawing.Size(70, 13)
        DocToLabel.TabIndex = 10
        DocToLabel.Text = "Max Number:"
        '
        'CurrentDocLabel
        '
        CurrentDocLabel.AutoSize = True
        CurrentDocLabel.Location = New System.Drawing.Point(22, 162)
        CurrentDocLabel.Name = "CurrentDocLabel"
        CurrentDocLabel.Size = New System.Drawing.Size(81, 13)
        CurrentDocLabel.TabIndex = 12
        CurrentDocLabel.Text = "CurrentNumber:"
        '
        'AccountingPeriodLabel
        '
        AccountingPeriodLabel.AutoSize = True
        AccountingPeriodLabel.Location = New System.Drawing.Point(6, 50)
        AccountingPeriodLabel.Name = "AccountingPeriodLabel"
        AccountingPeriodLabel.Size = New System.Drawing.Size(40, 13)
        AccountingPeriodLabel.TabIndex = 0
        AccountingPeriodLabel.Text = "Period:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(6, 100)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "Description:"
        '
        'OpenLabel
        '
        OpenLabel.AutoSize = True
        OpenLabel.Location = New System.Drawing.Point(6, 122)
        OpenLabel.Name = "OpenLabel"
        OpenLabel.Size = New System.Drawing.Size(36, 13)
        OpenLabel.TabIndex = 4
        OpenLabel.Text = "Open:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(6, 61)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 0
        CompanyNameLabel.Text = "Company Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 87)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 2
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(6, 113)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(6, 139)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(6, 165)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        WebsiteLabel.TabIndex = 8
        WebsiteLabel.Text = "Website:"
        '
        'CurrencyLabel
        '
        CurrencyLabel.AutoSize = True
        CurrencyLabel.Location = New System.Drawing.Point(6, 191)
        CurrencyLabel.Name = "CurrencyLabel"
        CurrencyLabel.Size = New System.Drawing.Size(52, 13)
        CurrencyLabel.TabIndex = 10
        CurrencyLabel.Text = "Currency:"
        '
        'FiscalYearLabel
        '
        FiscalYearLabel.AutoSize = True
        FiscalYearLabel.Location = New System.Drawing.Point(6, 73)
        FiscalYearLabel.Name = "FiscalYearLabel"
        FiscalYearLabel.Size = New System.Drawing.Size(62, 13)
        FiscalYearLabel.TabIndex = 8
        FiscalYearLabel.Text = "Fiscal Year:"
        '
        'TaxDescriptionLabel
        '
        TaxDescriptionLabel.AutoSize = True
        TaxDescriptionLabel.Location = New System.Drawing.Point(6, 53)
        TaxDescriptionLabel.Name = "TaxDescriptionLabel"
        TaxDescriptionLabel.Size = New System.Drawing.Size(84, 13)
        TaxDescriptionLabel.TabIndex = 0
        TaxDescriptionLabel.Text = "Tax Description:"
        '
        'TaxRateLabel
        '
        TaxRateLabel.AutoSize = True
        TaxRateLabel.Location = New System.Drawing.Point(6, 79)
        TaxRateLabel.Name = "TaxRateLabel"
        TaxRateLabel.Size = New System.Drawing.Size(54, 13)
        TaxRateLabel.TabIndex = 2
        TaxRateLabel.Text = "Tax Rate:"
        '
        'TaxInclusiveLabel
        '
        TaxInclusiveLabel.AutoSize = True
        TaxInclusiveLabel.Location = New System.Drawing.Point(6, 107)
        TaxInclusiveLabel.Name = "TaxInclusiveLabel"
        TaxInclusiveLabel.Size = New System.Drawing.Size(73, 13)
        TaxInclusiveLabel.TabIndex = 4
        TaxInclusiveLabel.Text = "Tax Inclusive:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(63, 13)
        Label2.TabIndex = 0
        Label2.Text = "Description:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 79)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(34, 13)
        Label3.TabIndex = 2
        Label3.Text = "Days:"
        '
        'CartegoryLabel
        '
        CartegoryLabel.AutoSize = True
        CartegoryLabel.Location = New System.Drawing.Point(0, 62)
        CartegoryLabel.Name = "CartegoryLabel"
        CartegoryLabel.Size = New System.Drawing.Size(55, 13)
        CartegoryLabel.TabIndex = 2
        CartegoryLabel.Text = "Cartegory:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(0, 62)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 2
        Label1.Text = "SubType:"
        '
        'tbAccSettings
        '
        Me.tbAccSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAccSettings.Controls.Add(Me.tbCompanies)
        Me.tbAccSettings.Controls.Add(Me.tbAccDocuments)
        Me.tbAccSettings.Controls.Add(Me.tbAccNumbers)
        Me.tbAccSettings.Controls.Add(Me.TabPage2)
        Me.tbAccSettings.Controls.Add(Me.TabPage5)
        Me.tbAccSettings.Controls.Add(Me.TabPage1)
        Me.tbAccSettings.Controls.Add(Me.TabPage3)
        Me.tbAccSettings.Controls.Add(Me.TabPage4)
        Me.tbAccSettings.Controls.Add(Me.TabPage6)
        Me.tbAccSettings.Location = New System.Drawing.Point(0, 0)
        Me.tbAccSettings.Name = "tbAccSettings"
        Me.tbAccSettings.SelectedIndex = 0
        Me.tbAccSettings.Size = New System.Drawing.Size(1099, 446)
        Me.tbAccSettings.TabIndex = 0
        '
        'tbCompanies
        '
        Me.tbCompanies.Controls.Add(Me.GroupBox5)
        Me.tbCompanies.Location = New System.Drawing.Point(4, 22)
        Me.tbCompanies.Name = "tbCompanies"
        Me.tbCompanies.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCompanies.Size = New System.Drawing.Size(1091, 420)
        Me.tbCompanies.TabIndex = 4
        Me.tbCompanies.Text = "Companies"
        Me.tbCompanies.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox5.Controls.Add(Me.BindingNavigator5)
        Me.GroupBox5.Controls.Add(CompanyNameLabel)
        Me.GroupBox5.Controls.Add(Me.CompanyNameTextBox)
        Me.GroupBox5.Controls.Add(AddressLabel)
        Me.GroupBox5.Controls.Add(Me.AddressTextBox)
        Me.GroupBox5.Controls.Add(PhoneLabel)
        Me.GroupBox5.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox5.Controls.Add(EmailLabel)
        Me.GroupBox5.Controls.Add(Me.EmailTextBox)
        Me.GroupBox5.Controls.Add(WebsiteLabel)
        Me.GroupBox5.Controls.Add(Me.WebsiteTextBox)
        Me.GroupBox5.Controls.Add(CurrencyLabel)
        Me.GroupBox5.Controls.Add(Me.CurrencyComboBox)
        Me.GroupBox5.Controls.Add(Me.CompanyRefLabel1)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1067, 391)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Campanies"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(480, 57)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(226, 147)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 11
        Me.LogoPictureBox.TabStop = False
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Me.ToolStripButton29
        Me.BindingNavigator5.BindingSource = Me.AccountingCompaniesBindingSource
        Me.BindingNavigator5.CountItem = Me.ToolStripLabel5
        Me.BindingNavigator5.DeleteItem = Nothing
        Me.BindingNavigator5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripSeparator13, Me.ToolStripTextBox5, Me.ToolStripLabel5, Me.ToolStripSeparator14, Me.ToolStripButton32, Me.ToolStripButton33, Me.ToolStripSeparator15, Me.ToolStripButton29, Me.ToolStripButton34, Me.ToolStripButton35})
        Me.BindingNavigator5.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator5.MoveFirstItem = Me.ToolStripButton30
        Me.BindingNavigator5.MoveLastItem = Me.ToolStripButton33
        Me.BindingNavigator5.MoveNextItem = Me.ToolStripButton32
        Me.BindingNavigator5.MovePreviousItem = Me.ToolStripButton31
        Me.BindingNavigator5.Name = "BindingNavigator5"
        Me.BindingNavigator5.PositionItem = Me.ToolStripTextBox5
        Me.BindingNavigator5.Size = New System.Drawing.Size(1061, 25)
        Me.BindingNavigator5.TabIndex = 18
        Me.BindingNavigator5.Text = "BindingNavigator5"
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton29.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton29.Text = "Add new"
        '
        'AccountingCompaniesBindingSource
        '
        Me.AccountingCompaniesBindingSource.DataMember = "AccountingCompanies"
        Me.AccountingCompaniesBindingSource.DataSource = Me.DsAccountsSettings
        '
        'DsAccountsSettings
        '
        Me.DsAccountsSettings.DataSetName = "dsAccountsSettings"
        Me.DsAccountsSettings.EnforceConstraints = False
        Me.DsAccountsSettings.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.ToolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton34.Image = CType(resources.GetObject("ToolStripButton34.Image"), System.Drawing.Image)
        Me.ToolStripButton34.Name = "ToolStripButton34"
        Me.ToolStripButton34.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton34.Text = "Save Data"
        '
        'ToolStripButton35
        '
        Me.ToolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton35.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton35.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton35.Name = "ToolStripButton35"
        Me.ToolStripButton35.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton35.Text = "ToolStripButton1"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(156, 58)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CompanyNameTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(156, 84)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(156, 110)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PhoneTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(156, 136)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EmailTextBox.TabIndex = 7
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "Website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(156, 162)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.WebsiteTextBox.TabIndex = 9
        '
        'CurrencyComboBox
        '
        Me.CurrencyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "Currency", True))
        Me.CurrencyComboBox.FormattingEnabled = True
        Me.CurrencyComboBox.Location = New System.Drawing.Point(156, 188)
        Me.CurrencyComboBox.Name = "CurrencyComboBox"
        Me.CurrencyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CurrencyComboBox.TabIndex = 11
        '
        'CompanyRefLabel1
        '
        Me.CompanyRefLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingCompaniesBindingSource, "CompanyRef", True))
        Me.CompanyRefLabel1.Location = New System.Drawing.Point(6, 366)
        Me.CompanyRefLabel1.Name = "CompanyRefLabel1"
        Me.CompanyRefLabel1.Size = New System.Drawing.Size(121, 23)
        Me.CompanyRefLabel1.TabIndex = 17
        Me.CompanyRefLabel1.Text = "Label2"
        '
        'tbAccDocuments
        '
        Me.tbAccDocuments.Controls.Add(Me.GroupBox1)
        Me.tbAccDocuments.Location = New System.Drawing.Point(4, 22)
        Me.tbAccDocuments.Name = "tbAccDocuments"
        Me.tbAccDocuments.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAccDocuments.Size = New System.Drawing.Size(1091, 420)
        Me.tbAccDocuments.TabIndex = 2
        Me.tbAccDocuments.Text = "Accounting Documents"
        Me.tbAccDocuments.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BindingNavigator2)
        Me.GroupBox1.Controls.Add(Me.AccountingDocumentsDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1062, 396)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documents"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator2.BindingSource = Me.AccountingDocumentsBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripButton13, Me.ToolStripButton14})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton9
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton12
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton11
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton10
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator2.Size = New System.Drawing.Size(1056, 25)
        Me.BindingNavigator2.TabIndex = 2
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'AccountingDocumentsBindingSource
        '
        Me.AccountingDocumentsBindingSource.DataMember = "AccountingDocuments"
        Me.AccountingDocumentsBindingSource.DataSource = Me.DsAccountsSettings
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move first"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move next"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Save Data"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "ToolStripButton1"
        '
        'AccountingDocumentsDataGridView
        '
        Me.AccountingDocumentsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountingDocumentsDataGridView.AutoGenerateColumns = False
        Me.AccountingDocumentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountingDocumentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Doc})
        Me.AccountingDocumentsDataGridView.DataSource = Me.AccountingDocumentsBindingSource
        Me.AccountingDocumentsDataGridView.Location = New System.Drawing.Point(6, 44)
        Me.AccountingDocumentsDataGridView.Name = "AccountingDocumentsDataGridView"
        Me.AccountingDocumentsDataGridView.Size = New System.Drawing.Size(1050, 334)
        Me.AccountingDocumentsDataGridView.TabIndex = 0
        '
        'Doc
        '
        Me.Doc.DataPropertyName = "Doc"
        Me.Doc.HeaderText = "Document"
        Me.Doc.Name = "Doc"
        Me.Doc.Width = 200
        '
        'tbAccNumbers
        '
        Me.tbAccNumbers.Controls.Add(Me.GroupBox3)
        Me.tbAccNumbers.Location = New System.Drawing.Point(4, 22)
        Me.tbAccNumbers.Name = "tbAccNumbers"
        Me.tbAccNumbers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAccNumbers.Size = New System.Drawing.Size(1091, 420)
        Me.tbAccNumbers.TabIndex = 0
        Me.tbAccNumbers.Text = "Document Numbers"
        Me.tbAccNumbers.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(SchoolLabel)
        Me.GroupBox3.Controls.Add(Me.SchoolComboBox)
        Me.GroupBox3.Controls.Add(Me.RefIdTextBox)
        Me.GroupBox3.Controls.Add(DocNameLabel)
        Me.GroupBox3.Controls.Add(Me.DocNameComboBox)
        Me.GroupBox3.Controls.Add(DocFromLabel)
        Me.GroupBox3.Controls.Add(Me.DocFromTextBox)
        Me.GroupBox3.Controls.Add(DocToLabel)
        Me.GroupBox3.Controls.Add(Me.DocToTextBox)
        Me.GroupBox3.Controls.Add(CurrentDocLabel)
        Me.GroupBox3.Controls.Add(Me.CurrentDocTextBox)
        Me.GroupBox3.Controls.Add(Me.BindingNavigator3)
        Me.GroupBox3.Controls.Add(Me.AccountNumberValueDataGridView)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1063, 410)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Document Numbers"
        '
        'SchoolComboBox
        '
        Me.SchoolComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "companyname", True))
        Me.SchoolComboBox.DataSource = Me.AccountingCompaniesBindingSource
        Me.SchoolComboBox.DisplayMember = "CompanyName"
        Me.SchoolComboBox.FormattingEnabled = True
        Me.SchoolComboBox.Location = New System.Drawing.Point(104, 49)
        Me.SchoolComboBox.Name = "SchoolComboBox"
        Me.SchoolComboBox.Size = New System.Drawing.Size(155, 21)
        Me.SchoolComboBox.TabIndex = 3
        Me.SchoolComboBox.ValueMember = "CompanyRef"
        '
        'AccountNumberValueBindingSource
        '
        Me.AccountNumberValueBindingSource.DataMember = "AccountNumberValue"
        Me.AccountNumberValueBindingSource.DataSource = Me.DsAccountsSettings
        '
        'RefIdTextBox
        '
        Me.RefIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "RefId", True))
        Me.RefIdTextBox.Enabled = False
        Me.RefIdTextBox.Location = New System.Drawing.Point(104, 181)
        Me.RefIdTextBox.Name = "RefIdTextBox"
        Me.RefIdTextBox.ReadOnly = True
        Me.RefIdTextBox.Size = New System.Drawing.Size(155, 20)
        Me.RefIdTextBox.TabIndex = 5
        '
        'DocNameComboBox
        '
        Me.DocNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DocNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DocNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "DocName", True))
        Me.DocNameComboBox.DataSource = Me.AccountingDocumentsBindingSource
        Me.DocNameComboBox.DisplayMember = "Doc"
        Me.DocNameComboBox.FormattingEnabled = True
        Me.DocNameComboBox.Location = New System.Drawing.Point(104, 76)
        Me.DocNameComboBox.Name = "DocNameComboBox"
        Me.DocNameComboBox.Size = New System.Drawing.Size(155, 21)
        Me.DocNameComboBox.TabIndex = 7
        Me.DocNameComboBox.ValueMember = "Doc"
        '
        'DocFromTextBox
        '
        Me.DocFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "DocFrom", True))
        Me.DocFromTextBox.Location = New System.Drawing.Point(104, 103)
        Me.DocFromTextBox.Name = "DocFromTextBox"
        Me.DocFromTextBox.Size = New System.Drawing.Size(155, 20)
        Me.DocFromTextBox.TabIndex = 9
        '
        'DocToTextBox
        '
        Me.DocToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "DocTo", True))
        Me.DocToTextBox.Location = New System.Drawing.Point(104, 129)
        Me.DocToTextBox.Name = "DocToTextBox"
        Me.DocToTextBox.Size = New System.Drawing.Size(155, 20)
        Me.DocToTextBox.TabIndex = 11
        '
        'CurrentDocTextBox
        '
        Me.CurrentDocTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountNumberValueBindingSource, "CurrentDoc", True))
        Me.CurrentDocTextBox.Location = New System.Drawing.Point(104, 155)
        Me.CurrentDocTextBox.Name = "CurrentDocTextBox"
        Me.CurrentDocTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CurrentDocTextBox.TabIndex = 13
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton15
        Me.BindingNavigator3.BindingSource = Me.AccountNumberValueBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripSeparator9, Me.ToolStripButton15, Me.ToolStripButton20, Me.ToolStripButton21})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton16
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton19
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton18
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton17
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator3.Size = New System.Drawing.Size(1057, 25)
        Me.BindingNavigator3.TabIndex = 2
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Add new"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Move first"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Move next"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Text = "Save Data"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "ToolStripButton1"
        '
        'AccountNumberValueDataGridView
        '
        Me.AccountNumberValueDataGridView.AllowUserToAddRows = False
        Me.AccountNumberValueDataGridView.AllowUserToDeleteRows = False
        Me.AccountNumberValueDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountNumberValueDataGridView.AutoGenerateColumns = False
        Me.AccountNumberValueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountNumberValueDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Company, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.RefID})
        Me.AccountNumberValueDataGridView.DataSource = Me.AccountNumberValueBindingSource
        Me.AccountNumberValueDataGridView.Location = New System.Drawing.Point(281, 44)
        Me.AccountNumberValueDataGridView.MultiSelect = False
        Me.AccountNumberValueDataGridView.Name = "AccountNumberValueDataGridView"
        Me.AccountNumberValueDataGridView.ReadOnly = True
        Me.AccountNumberValueDataGridView.Size = New System.Drawing.Size(776, 351)
        Me.AccountNumberValueDataGridView.TabIndex = 0
        '
        'Company
        '
        Me.Company.DataPropertyName = "companyname"
        Me.Company.HeaderText = "Company"
        Me.Company.Name = "Company"
        Me.Company.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DocName"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.AccountingDocumentsBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Doc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DocName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Doc"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DocFrom"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Min Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DocTo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MaxNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CurrentDoc"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CurrentNumber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'RefID
        '
        Me.RefID.DataPropertyName = "RefId"
        Me.RefID.HeaderText = "RefId"
        Me.RefID.Name = "RefID"
        Me.RefID.ReadOnly = True
        Me.RefID.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AccountCartegoriesDataGridView)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Account Types"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AccountCartegoriesDataGridView
        '
        Me.AccountCartegoriesDataGridView.AllowUserToAddRows = False
        Me.AccountCartegoriesDataGridView.AllowUserToDeleteRows = False
        Me.AccountCartegoriesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountCartegoriesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccountCartegoriesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.AccountCartegoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountCartegoriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cartegory, Me.CartRef})
        Me.AccountCartegoriesDataGridView.DataSource = Me.AccountCartegoriesBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountCartegoriesDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.AccountCartegoriesDataGridView.Location = New System.Drawing.Point(456, 22)
        Me.AccountCartegoriesDataGridView.Name = "AccountCartegoriesDataGridView"
        Me.AccountCartegoriesDataGridView.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccountCartegoriesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.AccountCartegoriesDataGridView.Size = New System.Drawing.Size(612, 392)
        Me.AccountCartegoriesDataGridView.TabIndex = 8
        '
        'Cartegory
        '
        Me.Cartegory.DataPropertyName = "Cartegory"
        Me.Cartegory.HeaderText = "Cartegory"
        Me.Cartegory.Name = "Cartegory"
        Me.Cartegory.ReadOnly = True
        Me.Cartegory.Width = 200
        '
        'CartRef
        '
        Me.CartRef.DataPropertyName = "CartRef"
        Me.CartRef.HeaderText = "CartRef"
        Me.CartRef.Name = "CartRef"
        Me.CartRef.ReadOnly = True
        Me.CartRef.Visible = False
        '
        'AccountCartegoriesBindingSource
        '
        Me.AccountCartegoriesBindingSource.DataMember = "AccountCartegories"
        Me.AccountCartegoriesBindingSource.DataSource = Me.DsAccountsSettings
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(CartegoryLabel)
        Me.GroupBox2.Controls.Add(Me.CartegoryTextBox)
        Me.GroupBox2.Controls.Add(Me.CartRefTextBox)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 392)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account Tyoes"
        '
        'CartegoryTextBox
        '
        Me.CartegoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountCartegoriesBindingSource, "Cartegory", True))
        Me.CartegoryTextBox.Location = New System.Drawing.Point(61, 55)
        Me.CartegoryTextBox.Name = "CartegoryTextBox"
        Me.CartegoryTextBox.Size = New System.Drawing.Size(225, 20)
        Me.CartegoryTextBox.TabIndex = 3
        '
        'CartRefTextBox
        '
        Me.CartRefTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CartRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountCartegoriesBindingSource, "CartRef", True))
        Me.CartRefTextBox.Location = New System.Drawing.Point(0, 366)
        Me.CartRefTextBox.Name = "CartRefTextBox"
        Me.CartRefTextBox.Size = New System.Drawing.Size(399, 20)
        Me.CartRefTextBox.TabIndex = 5
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton2
        Me.BindingNavigator1.BindingSource = Me.AccountCartegoriesBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(399, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Accounting Periods"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(FiscalYearLabel)
        Me.GroupBox4.Controls.Add(Me.FiscalYearComboBox)
        Me.GroupBox4.Controls.Add(Me.BindingNavigator4)
        Me.GroupBox4.Controls.Add(AccountingPeriodLabel)
        Me.GroupBox4.Controls.Add(Me.AccountingPeriodTextBox)
        Me.GroupBox4.Controls.Add(DescriptionLabel)
        Me.GroupBox4.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox4.Controls.Add(OpenLabel)
        Me.GroupBox4.Controls.Add(Me.OpenCheckBox)
        Me.GroupBox4.Controls.Add(Me.RefTextBox)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1077, 403)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "AccountingPeriods"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountingPeriodDataGridViewTextBoxColumn, Me.FiscalYearDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.OpenDataGridViewCheckBoxColumn, Me.RefDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AccountingPeriodsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(307, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(752, 334)
        Me.DataGridView1.TabIndex = 10
        '
        'AccountingPeriodDataGridViewTextBoxColumn
        '
        Me.AccountingPeriodDataGridViewTextBoxColumn.DataPropertyName = "AccountingPeriod"
        Me.AccountingPeriodDataGridViewTextBoxColumn.HeaderText = "AccountingPeriod"
        Me.AccountingPeriodDataGridViewTextBoxColumn.Name = "AccountingPeriodDataGridViewTextBoxColumn"
        Me.AccountingPeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FiscalYearDataGridViewTextBoxColumn
        '
        Me.FiscalYearDataGridViewTextBoxColumn.DataPropertyName = "FiscalYear"
        Me.FiscalYearDataGridViewTextBoxColumn.HeaderText = "FiscalYear"
        Me.FiscalYearDataGridViewTextBoxColumn.Name = "FiscalYearDataGridViewTextBoxColumn"
        Me.FiscalYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OpenDataGridViewCheckBoxColumn
        '
        Me.OpenDataGridViewCheckBoxColumn.DataPropertyName = "Open"
        Me.OpenDataGridViewCheckBoxColumn.HeaderText = "Open"
        Me.OpenDataGridViewCheckBoxColumn.Name = "OpenDataGridViewCheckBoxColumn"
        Me.OpenDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'RefDataGridViewTextBoxColumn
        '
        Me.RefDataGridViewTextBoxColumn.DataPropertyName = "Ref"
        Me.RefDataGridViewTextBoxColumn.HeaderText = "Ref"
        Me.RefDataGridViewTextBoxColumn.Name = "RefDataGridViewTextBoxColumn"
        Me.RefDataGridViewTextBoxColumn.ReadOnly = True
        Me.RefDataGridViewTextBoxColumn.Visible = False
        '
        'AccountingPeriodsBindingSource
        '
        Me.AccountingPeriodsBindingSource.DataMember = "AccountingPeriods"
        Me.AccountingPeriodsBindingSource.DataSource = Me.DsAccountsSettings
        '
        'FiscalYearComboBox
        '
        Me.FiscalYearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingPeriodsBindingSource, "FiscalYear", True))
        Me.FiscalYearComboBox.FormattingEnabled = True
        Me.FiscalYearComboBox.Location = New System.Drawing.Point(109, 70)
        Me.FiscalYearComboBox.Name = "FiscalYearComboBox"
        Me.FiscalYearComboBox.Size = New System.Drawing.Size(104, 21)
        Me.FiscalYearComboBox.TabIndex = 9
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.ToolStripButton22
        Me.BindingNavigator4.BindingSource = Me.AccountingPeriodsBindingSource
        Me.BindingNavigator4.CountItem = Me.ToolStripLabel4
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton25, Me.ToolStripButton26, Me.ToolStripSeparator12, Me.ToolStripButton22, Me.ToolStripButton27, Me.ToolStripButton28})
        Me.BindingNavigator4.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator4.MoveFirstItem = Me.ToolStripButton23
        Me.BindingNavigator4.MoveLastItem = Me.ToolStripButton26
        Me.BindingNavigator4.MoveNextItem = Me.ToolStripButton25
        Me.BindingNavigator4.MovePreviousItem = Me.ToolStripButton24
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.ToolStripTextBox4
        Me.BindingNavigator4.Size = New System.Drawing.Size(1071, 25)
        Me.BindingNavigator4.TabIndex = 8
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Add new"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Move first"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Current position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Text = "Move next"
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton27
        '
        Me.ToolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton27.Image = CType(resources.GetObject("ToolStripButton27.Image"), System.Drawing.Image)
        Me.ToolStripButton27.Name = "ToolStripButton27"
        Me.ToolStripButton27.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton27.Text = "Save Data"
        '
        'ToolStripButton28
        '
        Me.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton28.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton28.Name = "ToolStripButton28"
        Me.ToolStripButton28.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton28.Text = "ToolStripButton1"
        '
        'AccountingPeriodTextBox
        '
        Me.AccountingPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingPeriodsBindingSource, "AccountingPeriod", True))
        Me.AccountingPeriodTextBox.Location = New System.Drawing.Point(109, 47)
        Me.AccountingPeriodTextBox.Name = "AccountingPeriodTextBox"
        Me.AccountingPeriodTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AccountingPeriodTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingPeriodsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(109, 93)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(104, 20)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'OpenCheckBox
        '
        Me.OpenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AccountingPeriodsBindingSource, "Open", True))
        Me.OpenCheckBox.Location = New System.Drawing.Point(109, 117)
        Me.OpenCheckBox.Name = "OpenCheckBox"
        Me.OpenCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.OpenCheckBox.TabIndex = 5
        Me.OpenCheckBox.UseVisualStyleBackColor = True
        '
        'RefTextBox
        '
        Me.RefTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountingPeriodsBindingSource, "Ref", True))
        Me.RefTextBox.Location = New System.Drawing.Point(0, 377)
        Me.RefTextBox.Name = "RefTextBox"
        Me.RefTextBox.ReadOnly = True
        Me.RefTextBox.Size = New System.Drawing.Size(287, 20)
        Me.RefTextBox.TabIndex = 7
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage3.TabIndex = 5
        Me.TabPage3.Text = "VAT"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.BindingNavigator6)
        Me.GroupBox6.Controls.Add(TaxDescriptionLabel)
        Me.GroupBox6.Controls.Add(Me.TaxDescriptionTextBox)
        Me.GroupBox6.Controls.Add(TaxRateLabel)
        Me.GroupBox6.Controls.Add(Me.TaxRateTextBox)
        Me.GroupBox6.Controls.Add(TaxInclusiveLabel)
        Me.GroupBox6.Controls.Add(Me.TaxInclusiveCheckBox)
        Me.GroupBox6.Controls.Add(Me.TaxRefTextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1063, 391)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Taxes"
        '
        'BindingNavigator6
        '
        Me.BindingNavigator6.AddNewItem = Me.ToolStripButton36
        Me.BindingNavigator6.BindingSource = Me.VATBindingSource
        Me.BindingNavigator6.CountItem = Me.ToolStripLabel6
        Me.BindingNavigator6.DeleteItem = Nothing
        Me.BindingNavigator6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton37, Me.ToolStripButton38, Me.ToolStripSeparator16, Me.ToolStripTextBox6, Me.ToolStripLabel6, Me.ToolStripSeparator17, Me.ToolStripButton39, Me.ToolStripButton40, Me.ToolStripSeparator18, Me.ToolStripButton36, Me.ToolStripButton41, Me.ToolStripButton42})
        Me.BindingNavigator6.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator6.MoveFirstItem = Me.ToolStripButton37
        Me.BindingNavigator6.MoveLastItem = Me.ToolStripButton40
        Me.BindingNavigator6.MoveNextItem = Me.ToolStripButton39
        Me.BindingNavigator6.MovePreviousItem = Me.ToolStripButton38
        Me.BindingNavigator6.Name = "BindingNavigator6"
        Me.BindingNavigator6.PositionItem = Me.ToolStripTextBox6
        Me.BindingNavigator6.Size = New System.Drawing.Size(1057, 25)
        Me.BindingNavigator6.TabIndex = 9
        Me.BindingNavigator6.Text = "BindingNavigator6"
        '
        'ToolStripButton36
        '
        Me.ToolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton36.Image = CType(resources.GetObject("ToolStripButton36.Image"), System.Drawing.Image)
        Me.ToolStripButton36.Name = "ToolStripButton36"
        Me.ToolStripButton36.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton36.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton36.Text = "Add new"
        '
        'VATBindingSource
        '
        Me.VATBindingSource.DataMember = "VAT"
        Me.VATBindingSource.DataSource = Me.DsAccountsSettings
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel6.Text = "of {0}"
        Me.ToolStripLabel6.ToolTipText = "Total number of items"
        '
        'ToolStripButton37
        '
        Me.ToolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton37.Image = CType(resources.GetObject("ToolStripButton37.Image"), System.Drawing.Image)
        Me.ToolStripButton37.Name = "ToolStripButton37"
        Me.ToolStripButton37.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton37.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton37.Text = "Move first"
        '
        'ToolStripButton38
        '
        Me.ToolStripButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton38.Image = CType(resources.GetObject("ToolStripButton38.Image"), System.Drawing.Image)
        Me.ToolStripButton38.Name = "ToolStripButton38"
        Me.ToolStripButton38.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton38.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton38.Text = "Move previous"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.AccessibleName = "Position"
        Me.ToolStripTextBox6.AutoSize = False
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox6.Text = "0"
        Me.ToolStripTextBox6.ToolTipText = "Current position"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton39
        '
        Me.ToolStripButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton39.Image = CType(resources.GetObject("ToolStripButton39.Image"), System.Drawing.Image)
        Me.ToolStripButton39.Name = "ToolStripButton39"
        Me.ToolStripButton39.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton39.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton39.Text = "Move next"
        '
        'ToolStripButton40
        '
        Me.ToolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton40.Image = CType(resources.GetObject("ToolStripButton40.Image"), System.Drawing.Image)
        Me.ToolStripButton40.Name = "ToolStripButton40"
        Me.ToolStripButton40.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton40.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton40.Text = "Move last"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton41
        '
        Me.ToolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton41.Image = CType(resources.GetObject("ToolStripButton41.Image"), System.Drawing.Image)
        Me.ToolStripButton41.Name = "ToolStripButton41"
        Me.ToolStripButton41.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton41.Text = "Save Data"
        '
        'ToolStripButton42
        '
        Me.ToolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton42.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton42.Name = "ToolStripButton42"
        Me.ToolStripButton42.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton42.Text = "ToolStripButton1"
        '
        'TaxDescriptionTextBox
        '
        Me.TaxDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VATBindingSource, "TaxDescription", True))
        Me.TaxDescriptionTextBox.Location = New System.Drawing.Point(96, 50)
        Me.TaxDescriptionTextBox.Name = "TaxDescriptionTextBox"
        Me.TaxDescriptionTextBox.Size = New System.Drawing.Size(158, 20)
        Me.TaxDescriptionTextBox.TabIndex = 1
        '
        'TaxRateTextBox
        '
        Me.TaxRateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VATBindingSource, "TaxRate", True))
        Me.TaxRateTextBox.Location = New System.Drawing.Point(96, 76)
        Me.TaxRateTextBox.Name = "TaxRateTextBox"
        Me.TaxRateTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TaxRateTextBox.TabIndex = 3
        '
        'TaxInclusiveCheckBox
        '
        Me.TaxInclusiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VATBindingSource, "TaxInclusive", True))
        Me.TaxInclusiveCheckBox.Location = New System.Drawing.Point(96, 102)
        Me.TaxInclusiveCheckBox.Name = "TaxInclusiveCheckBox"
        Me.TaxInclusiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TaxInclusiveCheckBox.TabIndex = 5
        Me.TaxInclusiveCheckBox.UseVisualStyleBackColor = True
        '
        'TaxRefTextBox
        '
        Me.TaxRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VATBindingSource, "TaxRef", True))
        Me.TaxRefTextBox.Enabled = False
        Me.TaxRefTextBox.Location = New System.Drawing.Point(6, 360)
        Me.TaxRefTextBox.Name = "TaxRefTextBox"
        Me.TaxRefTextBox.ReadOnly = True
        Me.TaxRefTextBox.Size = New System.Drawing.Size(307, 20)
        Me.TaxRefTextBox.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage4.TabIndex = 6
        Me.TabPage4.Text = "Payment Terns"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.BindingNavigator7)
        Me.GroupBox7.Controls.Add(Label2)
        Me.GroupBox7.Controls.Add(Me.txtPaymentTerm)
        Me.GroupBox7.Controls.Add(Label3)
        Me.GroupBox7.Controls.Add(Me.txtPaymentDays)
        Me.GroupBox7.Controls.Add(Me.txtPaymentRef)
        Me.GroupBox7.Location = New System.Drawing.Point(25, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1048, 386)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Terms"
        '
        'BindingNavigator7
        '
        Me.BindingNavigator7.AddNewItem = Me.ToolStripButton43
        Me.BindingNavigator7.BindingSource = Me.PaymentTermsBindingSource
        Me.BindingNavigator7.CountItem = Me.ToolStripLabel7
        Me.BindingNavigator7.DeleteItem = Nothing
        Me.BindingNavigator7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton44, Me.ToolStripButton45, Me.ToolStripSeparator19, Me.ToolStripTextBox7, Me.ToolStripLabel7, Me.ToolStripSeparator20, Me.ToolStripButton46, Me.ToolStripButton47, Me.ToolStripSeparator21, Me.ToolStripButton43, Me.ToolStripButton48, Me.ToolStripButton49})
        Me.BindingNavigator7.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator7.MoveFirstItem = Me.ToolStripButton44
        Me.BindingNavigator7.MoveLastItem = Me.ToolStripButton47
        Me.BindingNavigator7.MoveNextItem = Me.ToolStripButton46
        Me.BindingNavigator7.MovePreviousItem = Me.ToolStripButton45
        Me.BindingNavigator7.Name = "BindingNavigator7"
        Me.BindingNavigator7.PositionItem = Me.ToolStripTextBox7
        Me.BindingNavigator7.Size = New System.Drawing.Size(1042, 25)
        Me.BindingNavigator7.TabIndex = 9
        Me.BindingNavigator7.Text = "BindingNavigator7"
        '
        'ToolStripButton43
        '
        Me.ToolStripButton43.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton43.Image = CType(resources.GetObject("ToolStripButton43.Image"), System.Drawing.Image)
        Me.ToolStripButton43.Name = "ToolStripButton43"
        Me.ToolStripButton43.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton43.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton43.Text = "Add new"
        '
        'PaymentTermsBindingSource
        '
        Me.PaymentTermsBindingSource.DataMember = "PaymentTerms"
        Me.PaymentTermsBindingSource.DataSource = Me.DsAccountsSettings
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel7.Text = "of {0}"
        Me.ToolStripLabel7.ToolTipText = "Total number of items"
        '
        'ToolStripButton44
        '
        Me.ToolStripButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton44.Image = CType(resources.GetObject("ToolStripButton44.Image"), System.Drawing.Image)
        Me.ToolStripButton44.Name = "ToolStripButton44"
        Me.ToolStripButton44.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton44.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton44.Text = "Move first"
        '
        'ToolStripButton45
        '
        Me.ToolStripButton45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton45.Image = CType(resources.GetObject("ToolStripButton45.Image"), System.Drawing.Image)
        Me.ToolStripButton45.Name = "ToolStripButton45"
        Me.ToolStripButton45.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton45.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton45.Text = "Move previous"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.AccessibleName = "Position"
        Me.ToolStripTextBox7.AutoSize = False
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox7.Text = "0"
        Me.ToolStripTextBox7.ToolTipText = "Current position"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton46
        '
        Me.ToolStripButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton46.Image = CType(resources.GetObject("ToolStripButton46.Image"), System.Drawing.Image)
        Me.ToolStripButton46.Name = "ToolStripButton46"
        Me.ToolStripButton46.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton46.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton46.Text = "Move next"
        '
        'ToolStripButton47
        '
        Me.ToolStripButton47.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton47.Image = CType(resources.GetObject("ToolStripButton47.Image"), System.Drawing.Image)
        Me.ToolStripButton47.Name = "ToolStripButton47"
        Me.ToolStripButton47.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton47.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton47.Text = "Move last"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton48
        '
        Me.ToolStripButton48.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton48.Image = CType(resources.GetObject("ToolStripButton48.Image"), System.Drawing.Image)
        Me.ToolStripButton48.Name = "ToolStripButton48"
        Me.ToolStripButton48.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton48.Text = "Save Data"
        '
        'ToolStripButton49
        '
        Me.ToolStripButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton49.Image = Global.IncomeExpenditure.My.Resources.Resources.Delete
        Me.ToolStripButton49.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton49.Name = "ToolStripButton49"
        Me.ToolStripButton49.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton49.Text = "ToolStripButton1"
        '
        'txtPaymentTerm
        '
        Me.txtPaymentTerm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentTermsBindingSource, "PayTermDescription", True))
        Me.txtPaymentTerm.Location = New System.Drawing.Point(96, 50)
        Me.txtPaymentTerm.Name = "txtPaymentTerm"
        Me.txtPaymentTerm.Size = New System.Drawing.Size(158, 20)
        Me.txtPaymentTerm.TabIndex = 1
        '
        'txtPaymentDays
        '
        Me.txtPaymentDays.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentTermsBindingSource, "Days", True))
        Me.txtPaymentDays.Location = New System.Drawing.Point(96, 76)
        Me.txtPaymentDays.Name = "txtPaymentDays"
        Me.txtPaymentDays.Size = New System.Drawing.Size(76, 20)
        Me.txtPaymentDays.TabIndex = 3
        '
        'txtPaymentRef
        '
        Me.txtPaymentRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentTermsBindingSource, "PayTermREf", True))
        Me.txtPaymentRef.Enabled = False
        Me.txtPaymentRef.Location = New System.Drawing.Point(6, 360)
        Me.txtPaymentRef.Name = "txtPaymentRef"
        Me.txtPaymentRef.ReadOnly = True
        Me.txtPaymentRef.Size = New System.Drawing.Size(307, 20)
        Me.txtPaymentRef.TabIndex = 7
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage5.TabIndex = 7
        Me.TabPage5.Text = "Account SubTypes"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubTypeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.AccountSubTypeBindingSource
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView2.Location = New System.Drawing.Point(453, 14)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView2.Size = New System.Drawing.Size(612, 392)
        Me.DataGridView2.TabIndex = 10
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Label1)
        Me.GroupBox8.Controls.Add(Me.TextBox1)
        Me.GroupBox8.Controls.Add(Me.TextBox2)
        Me.GroupBox8.Controls.Add(Me.BindingNavigator8)
        Me.GroupBox8.Location = New System.Drawing.Point(26, 14)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(405, 392)
        Me.GroupBox8.TabIndex = 9
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Account SubTypes"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountSubTypeBindingSource, "SubType", True))
        Me.TextBox1.Location = New System.Drawing.Point(61, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(225, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountCartegoriesBindingSource, "CartRef", True))
        Me.TextBox2.Location = New System.Drawing.Point(0, 366)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(399, 20)
        Me.TextBox2.TabIndex = 5
        '
        'BindingNavigator8
        '
        Me.BindingNavigator8.AddNewItem = Me.ToolStripButton50
        Me.BindingNavigator8.BindingSource = Me.AccountSubTypeBindingSource
        Me.BindingNavigator8.CountItem = Me.ToolStripLabel8
        Me.BindingNavigator8.DeleteItem = Nothing
        Me.BindingNavigator8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton51, Me.ToolStripButton52, Me.ToolStripSeparator22, Me.ToolStripTextBox8, Me.ToolStripLabel8, Me.ToolStripSeparator23, Me.ToolStripButton53, Me.ToolStripButton54, Me.ToolStripSeparator24, Me.ToolStripButton50, Me.ToolStripButton55})
        Me.BindingNavigator8.Location = New System.Drawing.Point(3, 16)
        Me.BindingNavigator8.MoveFirstItem = Me.ToolStripButton51
        Me.BindingNavigator8.MoveLastItem = Me.ToolStripButton54
        Me.BindingNavigator8.MoveNextItem = Me.ToolStripButton53
        Me.BindingNavigator8.MovePreviousItem = Me.ToolStripButton52
        Me.BindingNavigator8.Name = "BindingNavigator8"
        Me.BindingNavigator8.PositionItem = Me.ToolStripTextBox8
        Me.BindingNavigator8.Size = New System.Drawing.Size(399, 25)
        Me.BindingNavigator8.TabIndex = 1
        Me.BindingNavigator8.Text = "BindingNavigator8"
        '
        'ToolStripButton50
        '
        Me.ToolStripButton50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton50.Image = CType(resources.GetObject("ToolStripButton50.Image"), System.Drawing.Image)
        Me.ToolStripButton50.Name = "ToolStripButton50"
        Me.ToolStripButton50.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton50.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton50.Text = "Add new"
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel8.Text = "of {0}"
        Me.ToolStripLabel8.ToolTipText = "Total number of items"
        '
        'ToolStripButton51
        '
        Me.ToolStripButton51.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton51.Image = CType(resources.GetObject("ToolStripButton51.Image"), System.Drawing.Image)
        Me.ToolStripButton51.Name = "ToolStripButton51"
        Me.ToolStripButton51.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton51.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton51.Text = "Move first"
        '
        'ToolStripButton52
        '
        Me.ToolStripButton52.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton52.Image = CType(resources.GetObject("ToolStripButton52.Image"), System.Drawing.Image)
        Me.ToolStripButton52.Name = "ToolStripButton52"
        Me.ToolStripButton52.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton52.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton52.Text = "Move previous"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.AccessibleName = "Position"
        Me.ToolStripTextBox8.AutoSize = False
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox8.Text = "0"
        Me.ToolStripTextBox8.ToolTipText = "Current position"
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton53
        '
        Me.ToolStripButton53.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton53.Image = CType(resources.GetObject("ToolStripButton53.Image"), System.Drawing.Image)
        Me.ToolStripButton53.Name = "ToolStripButton53"
        Me.ToolStripButton53.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton53.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton53.Text = "Move next"
        '
        'ToolStripButton54
        '
        Me.ToolStripButton54.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton54.Image = CType(resources.GetObject("ToolStripButton54.Image"), System.Drawing.Image)
        Me.ToolStripButton54.Name = "ToolStripButton54"
        Me.ToolStripButton54.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton54.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton54.Text = "Move last"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton55
        '
        Me.ToolStripButton55.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton55.Image = CType(resources.GetObject("ToolStripButton55.Image"), System.Drawing.Image)
        Me.ToolStripButton55.Name = "ToolStripButton55"
        Me.ToolStripButton55.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton55.Text = "Save Data"
        '
        'AccountNumberValueTableAdapter
        '
        Me.AccountNumberValueTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountCartegoriesTableAdapter = Nothing
        Me.TableAdapterManager.AccountingCompaniesTableAdapter = Nothing
        Me.TableAdapterManager.AccountingDocumentsTableAdapter = Nothing
        Me.TableAdapterManager.AccountingPeriodsTableAdapter = Nothing
        Me.TableAdapterManager.AccountSubTypeTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PaymentTermsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IncomeExpenditure.dsAccountsSettingsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VATTableAdapter = Nothing
        '
        'AccountCartegoriesTableAdapter
        '
        Me.AccountCartegoriesTableAdapter.ClearBeforeFill = True
        '
        'AccountingDocumentsTableAdapter
        '
        Me.AccountingDocumentsTableAdapter.ClearBeforeFill = True
        '
        'AccountingPeriodsTableAdapter
        '
        Me.AccountingPeriodsTableAdapter.ClearBeforeFill = True
        '
        'AccountingCompaniesTableAdapter
        '
        Me.AccountingCompaniesTableAdapter.ClearBeforeFill = True
        '
        'DsCoA
        '
        Me.DsCoA.DataSetName = "dsCoA"
        Me.DsCoA.EnforceConstraints = False
        Me.DsCoA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartOfAccountsBindingSource
        '
        Me.ChartOfAccountsBindingSource.DataMember = "ChartOfAccounts"
        Me.ChartOfAccountsBindingSource.DataSource = Me.DsCoA
        '
        'ChartOfAccountsTableAdapter
        '
        Me.ChartOfAccountsTableAdapter.ClearBeforeFill = True
        '
        'VATTableAdapter
        '
        Me.VATTableAdapter.ClearBeforeFill = True
        '
        'PaymentTermsTableAdapter
        '
        Me.PaymentTermsTableAdapter.ClearBeforeFill = True
        '
        'btnSettingsRefresh
        '
        Me.btnSettingsRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettingsRefresh.Location = New System.Drawing.Point(977, 448)
        Me.btnSettingsRefresh.Name = "btnSettingsRefresh"
        Me.btnSettingsRefresh.Size = New System.Drawing.Size(118, 30)
        Me.btnSettingsRefresh.TabIndex = 1
        Me.btnSettingsRefresh.Text = "Refresh"
        Me.btnSettingsRefresh.UseVisualStyleBackColor = True
        '
        'AccountSubTypeBindingSource
        '
        Me.AccountSubTypeBindingSource.DataMember = "AccountSubType"
        Me.AccountSubTypeBindingSource.DataSource = Me.DsAccountsSettings
        '
        'AccountSubTypeTableAdapter
        '
        Me.AccountSubTypeTableAdapter.ClearBeforeFill = True
        '
        'SubTypeDataGridViewTextBoxColumn
        '
        Me.SubTypeDataGridViewTextBoxColumn.DataPropertyName = "SubType"
        Me.SubTypeDataGridViewTextBoxColumn.HeaderText = "SubType"
        Me.SubTypeDataGridViewTextBoxColumn.Name = "SubTypeDataGridViewTextBoxColumn"
        Me.SubTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubTypeDataGridViewTextBoxColumn.Width = 150
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox9)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1091, 420)
        Me.TabPage6.TabIndex = 8
        Me.TabPage6.Text = "AccountType SubTypes"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button1)
        Me.GroupBox9.Controls.Add(Me.cboAccTypeSubType_AccType)
        Me.GroupBox9.Controls.Add(Me.chkAccSubTypes)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Location = New System.Drawing.Point(217, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(640, 396)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "GroupBox9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Account Types"
        '
        'chkAccSubTypes
        '
        Me.chkAccSubTypes.FormattingEnabled = True
        Me.chkAccSubTypes.Location = New System.Drawing.Point(147, 79)
        Me.chkAccSubTypes.Name = "chkAccSubTypes"
        Me.chkAccSubTypes.Size = New System.Drawing.Size(305, 259)
        Me.chkAccSubTypes.TabIndex = 1
        '
        'cboAccTypeSubType_AccType
        '
        Me.cboAccTypeSubType_AccType.FormattingEnabled = True
        Me.cboAccTypeSubType_AccType.Location = New System.Drawing.Point(232, 42)
        Me.cboAccTypeSubType_AccType.Name = "cboAccTypeSubType_AccType"
        Me.cboAccTypeSubType_AccType.Size = New System.Drawing.Size(220, 21)
        Me.cboAccTypeSubType_AccType.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(232, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAccountingSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 482)
        Me.Controls.Add(Me.btnSettingsRefresh)
        Me.Controls.Add(Me.tbAccSettings)
        Me.Name = "frmAccountingSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountingSettings"
        Me.tbAccSettings.ResumeLayout(False)
        Me.tbCompanies.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        CType(Me.AccountingCompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAccDocuments.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.AccountingDocumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountingDocumentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAccNumbers.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AccountNumberValueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.AccountNumberValueDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.AccountCartegoriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountingPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.BindingNavigator6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator6.ResumeLayout(False)
        Me.BindingNavigator6.PerformLayout()
        CType(Me.VATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.BindingNavigator7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator7.ResumeLayout(False)
        Me.BindingNavigator7.PerformLayout()
        CType(Me.PaymentTermsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.BindingNavigator8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator8.ResumeLayout(False)
        Me.BindingNavigator8.PerformLayout()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountSubTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbAccSettings As Windows.Forms.TabControl
    Friend WithEvents tbAccNumbers As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents DsAccountsSettings As dsAccountsSettings
    Friend WithEvents AccountNumberValueBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountNumberValueTableAdapter As dsAccountsSettingsTableAdapters.AccountNumberValueTableAdapter
    Friend WithEvents TableAdapterManager As dsAccountsSettingsTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator1 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton3 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As Windows.Forms.ToolStripButton
    Friend WithEvents AccountCartegoriesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountCartegoriesTableAdapter As dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter
    Friend WithEvents CartType As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents tbAccDocuments As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents AccountNumberValueDataGridView As Windows.Forms.DataGridView
    Friend WithEvents AccountingDocumentsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountingDocumentsTableAdapter As dsAccountsSettingsTableAdapters.AccountingDocumentsTableAdapter
    Friend WithEvents BindingNavigator2 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton9 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As Windows.Forms.ToolStripButton
    Friend WithEvents AccountingDocumentsDataGridView As Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator3 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton15 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton16 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton18 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton19 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton20 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton21 As Windows.Forms.ToolStripButton
    Friend WithEvents Doc As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SchoolComboBox As Windows.Forms.ComboBox
    Friend WithEvents RefIdTextBox As Windows.Forms.TextBox
    Friend WithEvents DocNameComboBox As Windows.Forms.ComboBox
    Friend WithEvents DocFromTextBox As Windows.Forms.TextBox
    Friend WithEvents DocToTextBox As Windows.Forms.TextBox
    Friend WithEvents CurrentDocTextBox As Windows.Forms.TextBox
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator4 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton22 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton23 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton24 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton25 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton26 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton27 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton28 As Windows.Forms.ToolStripButton
    Friend WithEvents AccountingPeriodTextBox As Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As Windows.Forms.TextBox
    Friend WithEvents OpenCheckBox As Windows.Forms.CheckBox
    Friend WithEvents RefTextBox As Windows.Forms.TextBox
    Friend WithEvents AccountingPeriodsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountingPeriodsTableAdapter As dsAccountsSettingsTableAdapters.AccountingPeriodsTableAdapter
    Friend WithEvents tbCompanies As Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents AccountingCompaniesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountingCompaniesTableAdapter As dsAccountsSettingsTableAdapters.AccountingCompaniesTableAdapter
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
    Friend WithEvents ToolStripButton35 As Windows.Forms.ToolStripButton
    Friend WithEvents CompanyNameTextBox As Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As Windows.Forms.TextBox
    Friend WithEvents CurrencyComboBox As Windows.Forms.ComboBox
    Friend WithEvents CompanyRefLabel1 As Windows.Forms.Label
    Friend WithEvents FiscalYearComboBox As Windows.Forms.ComboBox
    Friend WithEvents LogoPictureBox As Windows.Forms.PictureBox
    Friend WithEvents DsCoA As dsCoA
    Friend WithEvents ChartOfAccountsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ChartOfAccountsTableAdapter As dsCoATableAdapters.ChartOfAccountsTableAdapter
    Friend WithEvents Company As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RefID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents VATBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VATTableAdapter As dsAccountsSettingsTableAdapters.VATTableAdapter
    Friend WithEvents BindingNavigator6 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton36 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel6 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton37 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton38 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox6 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator17 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton39 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton40 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton41 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton42 As Windows.Forms.ToolStripButton
    Friend WithEvents TaxDescriptionTextBox As Windows.Forms.TextBox
    Friend WithEvents TaxRateTextBox As Windows.Forms.TextBox
    Friend WithEvents TaxInclusiveCheckBox As Windows.Forms.CheckBox
    Friend WithEvents TaxRefTextBox As Windows.Forms.TextBox
    Friend WithEvents TabPage4 As Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator7 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton43 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel7 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton44 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton45 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator19 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox7 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator20 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton46 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton47 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator21 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton48 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton49 As Windows.Forms.ToolStripButton
    Friend WithEvents txtPaymentTerm As Windows.Forms.TextBox
    Friend WithEvents txtPaymentDays As Windows.Forms.TextBox
    Friend WithEvents txtPaymentRef As Windows.Forms.TextBox
    Friend WithEvents PaymentTermsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents PaymentTermsTableAdapter As dsAccountsSettingsTableAdapters.PaymentTermsTableAdapter
    Friend WithEvents AccountCartegoriesDataGridView As Windows.Forms.DataGridView
    Friend WithEvents CartegoryTextBox As Windows.Forms.TextBox
    Friend WithEvents CartRefTextBox As Windows.Forms.TextBox
    Friend WithEvents Cartegory As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartRef As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSettingsRefresh As Windows.Forms.Button
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents AccountingPeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiscalYearDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents BindingNavigator8 As Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton50 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel8 As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton51 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton52 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox8 As Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator23 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton53 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton54 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator24 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton55 As Windows.Forms.ToolStripButton
    Friend WithEvents AccountSubTypeBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountSubTypeTableAdapter As dsAccountsSettingsTableAdapters.AccountSubTypeTableAdapter
    Friend WithEvents SubTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage6 As Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As Windows.Forms.GroupBox
    Friend WithEvents cboAccTypeSubType_AccType As Windows.Forms.ComboBox
    Friend WithEvents chkAccSubTypes As Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
End Class
