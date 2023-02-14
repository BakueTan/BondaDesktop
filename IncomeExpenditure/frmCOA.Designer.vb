<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCoA
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
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim AccountNumberLabel As System.Windows.Forms.Label
        Dim CurrencyLabel As System.Windows.Forms.Label
        Dim AccTypeLabel As System.Windows.Forms.Label
        Dim ActiveLabel As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim IsSubAccountLabel As System.Windows.Forms.Label
        Dim ParentAccountLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCoA))
        Me.GLStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCoA = New IncomeExpenditure.dsCoA()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbCoA = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AccTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoARefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlockedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OpeningBalAsofDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsSubAccountDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ParentAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartOfAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboGLStatCurrentPeriod = New System.Windows.Forms.ComboBox()
        Me.chkGLShowCredits = New System.Windows.Forms.CheckBox()
        Me.chkGLShowDebits = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.ToolStripButton35 = New System.Windows.Forms.ToolStripButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSearchVendor = New System.Windows.Forms.Button()
        Me.ttxVendorSearchtext = New System.Windows.Forms.TextBox()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.cboAccCompany = New System.Windows.Forms.ComboBox()
        Me.pnlParentAccount = New System.Windows.Forms.Panel()
        Me.ParentAccountComboBox = New System.Windows.Forms.ComboBox()
        Me.IsSubAccountCheckBox = New System.Windows.Forms.CheckBox()
        Me.BankRefTextBox = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.CurrencyComboBox = New System.Windows.Forms.ComboBox()
        Me.AccTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AccountCartegoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsSettings = New IncomeExpenditure.dsAccountsSettings()
        Me.tbJournals = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbFeesPay = New System.Windows.Forms.GroupBox()
        Me.cboTransCompany = New System.Windows.Forms.ComboBox()
        Me.lbAccToBalance = New System.Windows.Forms.Label()
        Me.lbAccFromBalance = New System.Windows.Forms.Label()
        Me.cboTransAccTo = New System.Windows.Forms.ComboBox()
        Me.cboTransAccFrom = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboTransPeriod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskTransDate = New System.Windows.Forms.MaskedTextBox()
        Me.btnTransSave = New System.Windows.Forms.Button()
        Me.txtTransComments = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTransRef = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTansAmount = New System.Windows.Forms.TextBox()
        Me.tbJournal = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboJournalCompany = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgJournalAcounts = New System.Windows.Forms.DataGridView()
        Me.colJournalAccount = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colJournalAdj = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colJournalAmnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJournamMemo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboJournalPeriod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskJournalDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtJournalDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChartOfAccountsTableAdapter = New IncomeExpenditure.dsCoATableAdapters.ChartOfAccountsTableAdapter()
        Me.TableAdapterManager = New IncomeExpenditure.dsCoATableAdapters.TableAdapterManager()
        Me.GLStatementTableAdapter = New IncomeExpenditure.dsCoATableAdapters.GLStatementTableAdapter()
        Me.AccountCartegoriesTableAdapter = New IncomeExpenditure.dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter()
        DescriptionLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        AccountNumberLabel = New System.Windows.Forms.Label()
        CurrencyLabel = New System.Windows.Forms.Label()
        AccTypeLabel = New System.Windows.Forms.Label()
        ActiveLabel = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        IsSubAccountLabel = New System.Windows.Forms.Label()
        ParentAccountLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbCoA.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator5.SuspendLayout()
        Me.pnlParentAccount.SuspendLayout()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbJournals.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbFeesPay.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbJournal.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgJournalAcounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(6, 146)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 0
        DescriptionLabel.Text = "Description:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Location = New System.Drawing.Point(6, 201)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(49, 13)
        BalanceLabel.TabIndex = 2
        BalanceLabel.Text = "Balance:"
        '
        'AccountNumberLabel
        '
        AccountNumberLabel.AutoSize = True
        AccountNumberLabel.Location = New System.Drawing.Point(6, 174)
        AccountNumberLabel.Name = "AccountNumberLabel"
        AccountNumberLabel.Size = New System.Drawing.Size(90, 13)
        AccountNumberLabel.TabIndex = 4
        AccountNumberLabel.Text = "Account Number:"
        '
        'CurrencyLabel
        '
        CurrencyLabel.AutoSize = True
        CurrencyLabel.Location = New System.Drawing.Point(6, 227)
        CurrencyLabel.Name = "CurrencyLabel"
        CurrencyLabel.Size = New System.Drawing.Size(52, 13)
        CurrencyLabel.TabIndex = 6
        CurrencyLabel.Text = "Currency:"
        '
        'AccTypeLabel
        '
        AccTypeLabel.AutoSize = True
        AccTypeLabel.Location = New System.Drawing.Point(6, 117)
        AccTypeLabel.Name = "AccTypeLabel"
        AccTypeLabel.Size = New System.Drawing.Size(77, 13)
        AccTypeLabel.TabIndex = 8
        AccTypeLabel.Text = "Account Type:"
        '
        'ActiveLabel
        '
        ActiveLabel.AutoSize = True
        ActiveLabel.Location = New System.Drawing.Point(6, 314)
        ActiveLabel.Name = "ActiveLabel"
        ActiveLabel.Size = New System.Drawing.Size(49, 13)
        ActiveLabel.TabIndex = 11
        ActiveLabel.Text = "Blocked:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(6, 65)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(76, 13)
        StudentIDLabel1.TabIndex = 0
        StudentIDLabel1.Text = "From Account:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(294, 65)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 13)
        Label3.TabIndex = 66
        Label3.Text = "To Account:"
        '
        'IsSubAccountLabel
        '
        IsSubAccountLabel.AutoSize = True
        IsSubAccountLabel.Location = New System.Drawing.Point(6, 256)
        IsSubAccountLabel.Name = "IsSubAccountLabel"
        IsSubAccountLabel.Size = New System.Drawing.Size(72, 13)
        IsSubAccountLabel.TabIndex = 14
        IsSubAccountLabel.Text = "Sub Account:"
        '
        'ParentAccountLabel
        '
        ParentAccountLabel.AutoSize = True
        ParentAccountLabel.Location = New System.Drawing.Point(0, 7)
        ParentAccountLabel.Name = "ParentAccountLabel"
        ParentAccountLabel.Size = New System.Drawing.Size(84, 13)
        ParentAccountLabel.TabIndex = 16
        ParentAccountLabel.Text = "Parent Account:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(6, 92)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(54, 13)
        Label7.TabIndex = 19
        Label7.Text = "Company:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 37)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(54, 13)
        Label8.TabIndex = 69
        Label8.Text = "Company:"
        '
        'GLStatementBindingSource
        '
        Me.GLStatementBindingSource.DataMember = "GLStatement"
        Me.GLStatementBindingSource.DataSource = Me.DsCoA
        '
        'DsCoA
        '
        Me.DsCoA.DataSetName = "dsCoA"
        Me.DsCoA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbCoA)
        Me.TabControl1.Controls.Add(Me.tbJournals)
        Me.TabControl1.Controls.Add(Me.tbJournal)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1488, 651)
        Me.TabControl1.TabIndex = 0
        '
        'tbCoA
        '
        Me.tbCoA.Controls.Add(Me.GroupBox5)
        Me.tbCoA.Controls.Add(Me.GroupBox1)
        Me.tbCoA.Location = New System.Drawing.Point(4, 22)
        Me.tbCoA.Name = "tbCoA"
        Me.tbCoA.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCoA.Size = New System.Drawing.Size(1480, 625)
        Me.tbCoA.TabIndex = 0
        Me.tbCoA.Text = "Accounts"
        Me.tbCoA.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.TabControl3)
        Me.GroupBox5.Location = New System.Drawing.Point(448, 38)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1014, 569)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage3)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 16)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1008, 550)
        Me.TabControl3.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1000, 524)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "AccountsList"
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccTypeDataGridViewTextBoxColumn, Me.AccountNumberDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.CurrencyDataGridViewTextBoxColumn, Me.CoARefDataGridViewTextBoxColumn, Me.BlockedDataGridViewCheckBoxColumn, Me.OpeningBalAsofDataGridViewTextBoxColumn, Me.IsSubAccountDataGridViewCheckBoxColumn, Me.ParentAccountDataGridViewTextBoxColumn, Me.CompanyRefDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ChartOfAccountsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(6, 15)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(988, 503)
        Me.DataGridView2.TabIndex = 20
        '
        'AccTypeDataGridViewTextBoxColumn
        '
        Me.AccTypeDataGridViewTextBoxColumn.DataPropertyName = "AccType"
        Me.AccTypeDataGridViewTextBoxColumn.HeaderText = "AccType"
        Me.AccTypeDataGridViewTextBoxColumn.Name = "AccTypeDataGridViewTextBoxColumn"
        Me.AccTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountNumberDataGridViewTextBoxColumn
        '
        Me.AccountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber"
        Me.AccountNumberDataGridViewTextBoxColumn.Name = "AccountNumberDataGridViewTextBoxColumn"
        Me.AccountNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 150
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        Me.CurrencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoARefDataGridViewTextBoxColumn
        '
        Me.CoARefDataGridViewTextBoxColumn.DataPropertyName = "CoARef"
        Me.CoARefDataGridViewTextBoxColumn.HeaderText = "CoARef"
        Me.CoARefDataGridViewTextBoxColumn.Name = "CoARefDataGridViewTextBoxColumn"
        Me.CoARefDataGridViewTextBoxColumn.ReadOnly = True
        Me.CoARefDataGridViewTextBoxColumn.Visible = False
        '
        'BlockedDataGridViewCheckBoxColumn
        '
        Me.BlockedDataGridViewCheckBoxColumn.DataPropertyName = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.HeaderText = "Blocked"
        Me.BlockedDataGridViewCheckBoxColumn.Name = "BlockedDataGridViewCheckBoxColumn"
        Me.BlockedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'OpeningBalAsofDataGridViewTextBoxColumn
        '
        Me.OpeningBalAsofDataGridViewTextBoxColumn.DataPropertyName = "OpeningBalAsof"
        Me.OpeningBalAsofDataGridViewTextBoxColumn.HeaderText = "OpeningBalAsof"
        Me.OpeningBalAsofDataGridViewTextBoxColumn.Name = "OpeningBalAsofDataGridViewTextBoxColumn"
        Me.OpeningBalAsofDataGridViewTextBoxColumn.ReadOnly = True
        Me.OpeningBalAsofDataGridViewTextBoxColumn.Visible = False
        '
        'IsSubAccountDataGridViewCheckBoxColumn
        '
        Me.IsSubAccountDataGridViewCheckBoxColumn.DataPropertyName = "isSubAccount"
        Me.IsSubAccountDataGridViewCheckBoxColumn.HeaderText = "isSubAccount"
        Me.IsSubAccountDataGridViewCheckBoxColumn.Name = "IsSubAccountDataGridViewCheckBoxColumn"
        Me.IsSubAccountDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ParentAccountDataGridViewTextBoxColumn
        '
        Me.ParentAccountDataGridViewTextBoxColumn.DataPropertyName = "ParentAccount"
        Me.ParentAccountDataGridViewTextBoxColumn.HeaderText = "ParentAccount"
        Me.ParentAccountDataGridViewTextBoxColumn.Name = "ParentAccountDataGridViewTextBoxColumn"
        Me.ParentAccountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompanyRefDataGridViewTextBoxColumn
        '
        Me.CompanyRefDataGridViewTextBoxColumn.DataPropertyName = "CompanyRef"
        Me.CompanyRefDataGridViewTextBoxColumn.HeaderText = "CompanyRef"
        Me.CompanyRefDataGridViewTextBoxColumn.Name = "CompanyRefDataGridViewTextBoxColumn"
        Me.CompanyRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyRefDataGridViewTextBoxColumn.Visible = False
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "companyname"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "companyname"
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        Me.CompanynameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanynameDataGridViewTextBoxColumn.Width = 150
        '
        'ChartOfAccountsBindingSource
        '
        Me.ChartOfAccountsBindingSource.DataMember = "ChartOfAccounts"
        Me.ChartOfAccountsBindingSource.DataSource = Me.DsCoA
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox6)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1000, 524)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "AccountStatement"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.cboGLStatCurrentPeriod)
        Me.GroupBox6.Controls.Add(Me.chkGLShowCredits)
        Me.GroupBox6.Controls.Add(Me.chkGLShowDebits)
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
        'cboGLStatCurrentPeriod
        '
        Me.cboGLStatCurrentPeriod.FormattingEnabled = True
        Me.cboGLStatCurrentPeriod.Location = New System.Drawing.Point(388, 8)
        Me.cboGLStatCurrentPeriod.Name = "cboGLStatCurrentPeriod"
        Me.cboGLStatCurrentPeriod.Size = New System.Drawing.Size(121, 21)
        Me.cboGLStatCurrentPeriod.TabIndex = 3
        '
        'chkGLShowCredits
        '
        Me.chkGLShowCredits.AutoSize = True
        Me.chkGLShowCredits.Checked = True
        Me.chkGLShowCredits.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGLShowCredits.Location = New System.Drawing.Point(105, 10)
        Me.chkGLShowCredits.Name = "chkGLShowCredits"
        Me.chkGLShowCredits.Size = New System.Drawing.Size(88, 17)
        Me.chkGLShowCredits.TabIndex = 1
        Me.chkGLShowCredits.Text = "Show Credits"
        Me.chkGLShowCredits.UseVisualStyleBackColor = True
        '
        'chkGLShowDebits
        '
        Me.chkGLShowDebits.AutoSize = True
        Me.chkGLShowDebits.Checked = True
        Me.chkGLShowDebits.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGLShowDebits.Location = New System.Drawing.Point(3, 12)
        Me.chkGLShowDebits.Name = "chkGLShowDebits"
        Me.chkGLShowDebits.Size = New System.Drawing.Size(86, 17)
        Me.chkGLShowDebits.TabIndex = 0
        Me.chkGLShowDebits.Text = "Show Debits"
        Me.chkGLShowDebits.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(9, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 472)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.GLStatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptGLStatement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1005, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BindingNavigator5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.btnSearchVendor)
        Me.GroupBox1.Controls.Add(Me.ttxVendorSearchtext)
        Me.GroupBox1.Controls.Add(Me.lstResult)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Me.cboAccCompany)
        Me.GroupBox1.Controls.Add(Me.pnlParentAccount)
        Me.GroupBox1.Controls.Add(IsSubAccountLabel)
        Me.GroupBox1.Controls.Add(Me.IsSubAccountCheckBox)
        Me.GroupBox1.Controls.Add(Me.BankRefTextBox)
        Me.GroupBox1.Controls.Add(ActiveLabel)
        Me.GroupBox1.Controls.Add(Me.ActiveCheckBox)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Controls.Add(BalanceLabel)
        Me.GroupBox1.Controls.Add(Me.BalanceTextBox)
        Me.GroupBox1.Controls.Add(AccountNumberLabel)
        Me.GroupBox1.Controls.Add(Me.AccountNumberTextBox)
        Me.GroupBox1.Controls.Add(CurrencyLabel)
        Me.GroupBox1.Controls.Add(Me.CurrencyComboBox)
        Me.GroupBox1.Controls.Add(AccTypeLabel)
        Me.GroupBox1.Controls.Add(Me.AccTypeComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 579)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chart Of Accounts"
        '
        'BindingNavigator5
        '
        Me.BindingNavigator5.AddNewItem = Me.ToolStripButton29
        Me.BindingNavigator5.BindingSource = Me.ChartOfAccountsBindingSource
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
        Me.BindingNavigator5.Size = New System.Drawing.Size(428, 25)
        Me.BindingNavigator5.TabIndex = 26
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
        Me.ToolStripTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.ToolStripButton34.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButton34.Text = "Save Account"
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
        'Button3
        '
        Me.Button3.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.Refresh
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(409, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 20)
        Me.Button3.TabIndex = 25
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSearchVendor
        '
        Me.btnSearchVendor.BackgroundImage = Global.IncomeExpenditure.My.Resources.Resources.search
        Me.btnSearchVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchVendor.Location = New System.Drawing.Point(390, 45)
        Me.btnSearchVendor.Name = "btnSearchVendor"
        Me.btnSearchVendor.Size = New System.Drawing.Size(19, 20)
        Me.btnSearchVendor.TabIndex = 24
        Me.btnSearchVendor.UseVisualStyleBackColor = True
        '
        'ttxVendorSearchtext
        '
        Me.ttxVendorSearchtext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ttxVendorSearchtext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.ttxVendorSearchtext.Location = New System.Drawing.Point(253, 46)
        Me.ttxVendorSearchtext.Name = "ttxVendorSearchtext"
        Me.ttxVendorSearchtext.Size = New System.Drawing.Size(137, 20)
        Me.ttxVendorSearchtext.TabIndex = 22
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.BackColor = System.Drawing.Color.LightYellow
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(253, 66)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(175, 69)
        Me.lstResult.TabIndex = 23
        Me.lstResult.Visible = False
        '
        'cboAccCompany
        '
        Me.cboAccCompany.CausesValidation = False
        Me.cboAccCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "companyname", True))
        Me.cboAccCompany.FormattingEnabled = True
        Me.cboAccCompany.Items.AddRange(New Object() {"Expense", "Payable", "Revenue", "Receivable", "Equity", "Bank", "CreditCard"})
        Me.cboAccCompany.Location = New System.Drawing.Point(99, 89)
        Me.cboAccCompany.Name = "cboAccCompany"
        Me.cboAccCompany.Size = New System.Drawing.Size(121, 21)
        Me.cboAccCompany.TabIndex = 20
        '
        'pnlParentAccount
        '
        Me.pnlParentAccount.Controls.Add(ParentAccountLabel)
        Me.pnlParentAccount.Controls.Add(Me.ParentAccountComboBox)
        Me.pnlParentAccount.Enabled = False
        Me.pnlParentAccount.Location = New System.Drawing.Point(6, 272)
        Me.pnlParentAccount.Name = "pnlParentAccount"
        Me.pnlParentAccount.Size = New System.Drawing.Size(276, 34)
        Me.pnlParentAccount.TabIndex = 18
        '
        'ParentAccountComboBox
        '
        Me.ParentAccountComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ChartOfAccountsBindingSource, "ParentAccount", True))
        Me.ParentAccountComboBox.FormattingEnabled = True
        Me.ParentAccountComboBox.Location = New System.Drawing.Point(90, 4)
        Me.ParentAccountComboBox.Name = "ParentAccountComboBox"
        Me.ParentAccountComboBox.Size = New System.Drawing.Size(180, 21)
        Me.ParentAccountComboBox.TabIndex = 17
        '
        'IsSubAccountCheckBox
        '
        Me.IsSubAccountCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ChartOfAccountsBindingSource, "isSubAccount", True))
        Me.IsSubAccountCheckBox.Location = New System.Drawing.Point(99, 251)
        Me.IsSubAccountCheckBox.Name = "IsSubAccountCheckBox"
        Me.IsSubAccountCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.IsSubAccountCheckBox.TabIndex = 15
        Me.IsSubAccountCheckBox.UseVisualStyleBackColor = True
        '
        'BankRefTextBox
        '
        Me.BankRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "CoARef", True))
        Me.BankRefTextBox.Location = New System.Drawing.Point(3, 559)
        Me.BankRefTextBox.Name = "BankRefTextBox"
        Me.BankRefTextBox.ReadOnly = True
        Me.BankRefTextBox.Size = New System.Drawing.Size(378, 20)
        Me.BankRefTextBox.TabIndex = 14
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ChartOfAccountsBindingSource, "isSubAccount", True))
        Me.ActiveCheckBox.Location = New System.Drawing.Point(99, 309)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ActiveCheckBox.TabIndex = 12
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(99, 139)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(187, 20)
        Me.DescriptionTextBox.TabIndex = 1
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "Balance", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "C2"))
        Me.BalanceTextBox.Location = New System.Drawing.Point(99, 194)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BalanceTextBox.TabIndex = 3
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "AccountNumber", True))
        Me.AccountNumberTextBox.Enabled = False
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(99, 168)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.ReadOnly = True
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(187, 20)
        Me.AccountNumberTextBox.TabIndex = 5
        '
        'CurrencyComboBox
        '
        Me.CurrencyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "Currency", True))
        Me.CurrencyComboBox.FormattingEnabled = True
        Me.CurrencyComboBox.Location = New System.Drawing.Point(99, 224)
        Me.CurrencyComboBox.Name = "CurrencyComboBox"
        Me.CurrencyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CurrencyComboBox.TabIndex = 7
        '
        'AccTypeComboBox
        '
        Me.AccTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChartOfAccountsBindingSource, "AccType", True))
        Me.AccTypeComboBox.DataSource = Me.AccountCartegoriesBindingSource
        Me.AccTypeComboBox.DisplayMember = "Cartegory"
        Me.AccTypeComboBox.FormattingEnabled = True
        Me.AccTypeComboBox.Location = New System.Drawing.Point(99, 114)
        Me.AccTypeComboBox.Name = "AccTypeComboBox"
        Me.AccTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AccTypeComboBox.TabIndex = 9
        Me.AccTypeComboBox.ValueMember = "Cartegory"
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
        'tbJournals
        '
        Me.tbJournals.Controls.Add(Me.GroupBox2)
        Me.tbJournals.Location = New System.Drawing.Point(4, 22)
        Me.tbJournals.Name = "tbJournals"
        Me.tbJournals.Padding = New System.Windows.Forms.Padding(3)
        Me.tbJournals.Size = New System.Drawing.Size(1480, 625)
        Me.tbJournals.TabIndex = 1
        Me.tbJournals.Text = "Bank Transfers"
        Me.tbJournals.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gbFeesPay)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1451, 606)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bank Tranfer"
        '
        'gbFeesPay
        '
        Me.gbFeesPay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFeesPay.Controls.Add(Label8)
        Me.gbFeesPay.Controls.Add(Me.cboTransCompany)
        Me.gbFeesPay.Controls.Add(Me.lbAccToBalance)
        Me.gbFeesPay.Controls.Add(Me.lbAccFromBalance)
        Me.gbFeesPay.Controls.Add(Me.cboTransAccTo)
        Me.gbFeesPay.Controls.Add(Label3)
        Me.gbFeesPay.Controls.Add(Me.cboTransAccFrom)
        Me.gbFeesPay.Controls.Add(Me.GroupBox3)
        Me.gbFeesPay.Controls.Add(StudentIDLabel1)
        Me.gbFeesPay.Location = New System.Drawing.Point(6, 19)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(861, 215)
        Me.gbFeesPay.TabIndex = 1
        Me.gbFeesPay.TabStop = False
        '
        'cboTransCompany
        '
        Me.cboTransCompany.FormattingEnabled = True
        Me.cboTransCompany.Items.AddRange(New Object() {"Expense", "Payable", "Revenue", "Receivable", "Equity", "Bank", "CreditCard"})
        Me.cboTransCompany.Location = New System.Drawing.Point(88, 34)
        Me.cboTransCompany.Name = "cboTransCompany"
        Me.cboTransCompany.Size = New System.Drawing.Size(121, 21)
        Me.cboTransCompany.TabIndex = 70
        '
        'lbAccToBalance
        '
        Me.lbAccToBalance.AutoSize = True
        Me.lbAccToBalance.Location = New System.Drawing.Point(378, 42)
        Me.lbAccToBalance.Name = "lbAccToBalance"
        Me.lbAccToBalance.Size = New System.Drawing.Size(0, 13)
        Me.lbAccToBalance.TabIndex = 68
        '
        'lbAccFromBalance
        '
        Me.lbAccFromBalance.AutoSize = True
        Me.lbAccFromBalance.Location = New System.Drawing.Point(215, 46)
        Me.lbAccFromBalance.Name = "lbAccFromBalance"
        Me.lbAccFromBalance.Size = New System.Drawing.Size(0, 13)
        Me.lbAccFromBalance.TabIndex = 67
        '
        'cboTransAccTo
        '
        Me.cboTransAccTo.DisplayMember = "AccountNumber"
        Me.cboTransAccTo.FormattingEnabled = True
        Me.cboTransAccTo.Location = New System.Drawing.Point(363, 62)
        Me.cboTransAccTo.Name = "cboTransAccTo"
        Me.cboTransAccTo.Size = New System.Drawing.Size(200, 21)
        Me.cboTransAccTo.TabIndex = 65
        Me.cboTransAccTo.ValueMember = "AccountNumber"
        '
        'cboTransAccFrom
        '
        Me.cboTransAccFrom.DisplayMember = "AccountNumber"
        Me.cboTransAccFrom.FormattingEnabled = True
        Me.cboTransAccFrom.Location = New System.Drawing.Point(88, 62)
        Me.cboTransAccFrom.Name = "cboTransAccFrom"
        Me.cboTransAccFrom.Size = New System.Drawing.Size(200, 21)
        Me.cboTransAccFrom.TabIndex = 0
        Me.cboTransAccFrom.ValueMember = "AccountNumber"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboTransPeriod)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.mskTransDate)
        Me.GroupBox3.Controls.Add(Me.btnTransSave)
        Me.GroupBox3.Controls.Add(Me.txtTransComments)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtTransRef)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtTansAmount)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 111)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction Details"
        '
        'cboTransPeriod
        '
        Me.cboTransPeriod.FormattingEnabled = True
        Me.cboTransPeriod.Items.AddRange(New Object() {"DEBIT", "CREDIT"})
        Me.cboTransPeriod.Location = New System.Drawing.Point(357, 32)
        Me.cboTransPeriod.Name = "cboTransPeriod"
        Me.cboTransPeriod.Size = New System.Drawing.Size(94, 21)
        Me.cboTransPeriod.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Period:"
        '
        'mskTransDate
        '
        Me.mskTransDate.Location = New System.Drawing.Point(252, 32)
        Me.mskTransDate.Mask = "00/00/0000"
        Me.mskTransDate.Name = "mskTransDate"
        Me.mskTransDate.Size = New System.Drawing.Size(100, 20)
        Me.mskTransDate.TabIndex = 5
        Me.mskTransDate.ValidatingType = GetType(Date)
        '
        'btnTransSave
        '
        Me.btnTransSave.Location = New System.Drawing.Point(681, 71)
        Me.btnTransSave.Name = "btnTransSave"
        Me.btnTransSave.Size = New System.Drawing.Size(125, 34)
        Me.btnTransSave.TabIndex = 9
        Me.btnTransSave.Tag = " "
        Me.btnTransSave.Text = "Transfer"
        Me.btnTransSave.UseVisualStyleBackColor = True
        '
        'txtTransComments
        '
        Me.txtTransComments.Location = New System.Drawing.Point(460, 32)
        Me.txtTransComments.Multiline = True
        Me.txtTransComments.Name = "txtTransComments"
        Me.txtTransComments.Size = New System.Drawing.Size(189, 69)
        Me.txtTransComments.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(457, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Memo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Reference Document:"
        '
        'txtTransRef
        '
        Me.txtTransRef.Location = New System.Drawing.Point(9, 32)
        Me.txtTransRef.Name = "txtTransRef"
        Me.txtTransRef.Size = New System.Drawing.Size(112, 20)
        Me.txtTransRef.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(249, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Amount:"
        '
        'txtTansAmount
        '
        Me.txtTansAmount.Location = New System.Drawing.Point(127, 32)
        Me.txtTansAmount.Name = "txtTansAmount"
        Me.txtTansAmount.Size = New System.Drawing.Size(111, 20)
        Me.txtTansAmount.TabIndex = 2
        '
        'tbJournal
        '
        Me.tbJournal.Controls.Add(Me.GroupBox4)
        Me.tbJournal.Location = New System.Drawing.Point(4, 22)
        Me.tbJournal.Name = "tbJournal"
        Me.tbJournal.Padding = New System.Windows.Forms.Padding(3)
        Me.tbJournal.Size = New System.Drawing.Size(1480, 625)
        Me.tbJournal.TabIndex = 2
        Me.tbJournal.Text = "Journals"
        Me.tbJournal.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.cboJournalCompany)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.dgJournalAcounts)
        Me.GroupBox4.Controls.Add(Me.cboJournalPeriod)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.mskJournalDate)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtJournalDoc)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1464, 611)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Journals"
        '
        'cboJournalCompany
        '
        Me.cboJournalCompany.FormattingEnabled = True
        Me.cboJournalCompany.Items.AddRange(New Object() {"DEBIT", "CREDIT"})
        Me.cboJournalCompany.Location = New System.Drawing.Point(115, 13)
        Me.cboJournalCompany.Name = "cboJournalCompany"
        Me.cboJournalCompany.Size = New System.Drawing.Size(94, 21)
        Me.cboJournalCompany.TabIndex = 87
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Company:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 34)
        Me.Button1.TabIndex = 86
        Me.Button1.Tag = " "
        Me.Button1.Text = "Post"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgJournalAcounts
        '
        Me.dgJournalAcounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJournalAcounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colJournalAccount, Me.colJournalAdj, Me.colJournalAmnt, Me.colJournamMemo})
        Me.dgJournalAcounts.Location = New System.Drawing.Point(9, 118)
        Me.dgJournalAcounts.Name = "dgJournalAcounts"
        Me.dgJournalAcounts.Size = New System.Drawing.Size(744, 143)
        Me.dgJournalAcounts.TabIndex = 85
        '
        'colJournalAccount
        '
        Me.colJournalAccount.HeaderText = "Account"
        Me.colJournalAccount.Name = "colJournalAccount"
        Me.colJournalAccount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colJournalAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colJournalAccount.Width = 250
        '
        'colJournalAdj
        '
        Me.colJournalAdj.HeaderText = "D/C"
        Me.colJournalAdj.Items.AddRange(New Object() {"D", "C"})
        Me.colJournalAdj.Name = "colJournalAdj"
        Me.colJournalAdj.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colJournalAdj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colJournalAmnt
        '
        Me.colJournalAmnt.HeaderText = "Amount"
        Me.colJournalAmnt.Name = "colJournalAmnt"
        Me.colJournalAmnt.Width = 150
        '
        'colJournamMemo
        '
        Me.colJournamMemo.HeaderText = "Memo"
        Me.colJournamMemo.Name = "colJournamMemo"
        Me.colJournamMemo.Width = 200
        '
        'cboJournalPeriod
        '
        Me.cboJournalPeriod.FormattingEnabled = True
        Me.cboJournalPeriod.Items.AddRange(New Object() {"DEBIT", "CREDIT"})
        Me.cboJournalPeriod.Location = New System.Drawing.Point(115, 91)
        Me.cboJournalPeriod.Name = "cboJournalPeriod"
        Me.cboJournalPeriod.Size = New System.Drawing.Size(94, 21)
        Me.cboJournalPeriod.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Period:"
        '
        'mskJournalDate
        '
        Me.mskJournalDate.Location = New System.Drawing.Point(115, 65)
        Me.mskJournalDate.Mask = "00/00/0000"
        Me.mskJournalDate.Name = "mskJournalDate"
        Me.mskJournalDate.Size = New System.Drawing.Size(138, 20)
        Me.mskJournalDate.TabIndex = 78
        Me.mskJournalDate.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Document:"
        '
        'txtJournalDoc
        '
        Me.txtJournalDoc.Location = New System.Drawing.Point(115, 42)
        Me.txtJournalDoc.Name = "txtJournalDoc"
        Me.txtJournalDoc.Size = New System.Drawing.Size(138, 20)
        Me.txtJournalDoc.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Date:"
        '
        'ChartOfAccountsTableAdapter
        '
        Me.ChartOfAccountsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.GLTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = IncomeExpenditure.dsCoATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GLStatementTableAdapter
        '
        Me.GLStatementTableAdapter.ClearBeforeFill = True
        '
        'AccountCartegoriesTableAdapter
        '
        Me.AccountCartegoriesTableAdapter.ClearBeforeFill = True
        '
        'frmCoA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 651)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmCoA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CoA"
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbCoA.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingNavigator5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator5.ResumeLayout(False)
        Me.BindingNavigator5.PerformLayout()
        Me.pnlParentAccount.ResumeLayout(False)
        Me.pnlParentAccount.PerformLayout()
        CType(Me.AccountCartegoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbJournals.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbJournal.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgJournalAcounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents tbCoA As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents DescriptionTextBox As Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As Windows.Forms.TextBox
    Friend WithEvents AccountNumberTextBox As Windows.Forms.TextBox
    Friend WithEvents CurrencyComboBox As Windows.Forms.ComboBox
    Friend WithEvents AccTypeComboBox As Windows.Forms.ComboBox
    Friend WithEvents ActiveCheckBox As Windows.Forms.CheckBox
    Friend WithEvents BankRefTextBox As Windows.Forms.TextBox
    Friend WithEvents tbJournals As Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents gbFeesPay As Windows.Forms.GroupBox
    Friend WithEvents cboTransAccFrom As Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents mskTransDate As Windows.Forms.MaskedTextBox
    Friend WithEvents btnTransSave As Windows.Forms.Button
    Friend WithEvents txtTransComments As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txtTransRef As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtTansAmount As Windows.Forms.TextBox
    Friend WithEvents BankAccountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransDocDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransPostedDocDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostedDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransCommentDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostedbyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransActiveDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TransrefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboTransPeriod As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents DsCoA As dsCoA
    Friend WithEvents ChartOfAccountsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ChartOfAccountsTableAdapter As dsCoATableAdapters.ChartOfAccountsTableAdapter
    Friend WithEvents cboTransAccTo As Windows.Forms.ComboBox
    Friend WithEvents lbAccFromBalance As Windows.Forms.Label
    Friend WithEvents lbAccToBalance As Windows.Forms.Label
    Friend WithEvents tbJournal As Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents dgJournalAcounts As Windows.Forms.DataGridView
    Friend WithEvents cboJournalPeriod As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents mskJournalDate As Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txtJournalDoc As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents pnlParentAccount As Windows.Forms.Panel
    Friend WithEvents ParentAccountComboBox As Windows.Forms.ComboBox
    Friend WithEvents IsSubAccountCheckBox As Windows.Forms.CheckBox
    Friend WithEvents TableAdapterManager As dsCoATableAdapters.TableAdapterManager
    Friend WithEvents cboAccCompany As Windows.Forms.ComboBox
    Friend WithEvents cboTransCompany As Windows.Forms.ComboBox
    Friend WithEvents cboJournalCompany As Windows.Forms.ComboBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents colJournalAccount As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colJournalAdj As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colJournalAmnt As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJournamMemo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents TabControl3 As Windows.Forms.TabControl
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents Label30 As Windows.Forms.Label
    Friend WithEvents cboGLStatCurrentPeriod As Windows.Forms.ComboBox
    Friend WithEvents chkGLShowCredits As Windows.Forms.CheckBox
    Friend WithEvents chkGLShowDebits As Windows.Forms.CheckBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents AccTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoARefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlockedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents OpeningBalAsofDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsSubAccountDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ParentAccountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GLStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents GLStatementTableAdapter As dsCoATableAdapters.GLStatementTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents btnSearchVendor As Windows.Forms.Button
    Friend WithEvents ttxVendorSearchtext As Windows.Forms.TextBox
    Friend WithEvents lstResult As Windows.Forms.ListBox
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
    Friend WithEvents DsAccountsSettings As dsAccountsSettings
    Friend WithEvents AccountCartegoriesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents AccountCartegoriesTableAdapter As dsAccountsSettingsTableAdapters.AccountCartegoriesTableAdapter
End Class
