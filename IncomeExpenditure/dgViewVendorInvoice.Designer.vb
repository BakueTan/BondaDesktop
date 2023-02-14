<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dgViewVendorInvoice
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GLStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCoA = New IncomeExpenditure.dsCoA()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.rptInvoiceStatement = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptInvoce = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgCustomerTrans = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPaymentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VatAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsReceivable = New IncomeExpenditure.dsAccountsReceivable()
        Me.dgVendorTrans = New System.Windows.Forms.DataGridView()
        Me.InvoiceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDocNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvVendorAccNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvConvAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvDueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPostedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvClearedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InvPaymentRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvTransTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvPaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvVatAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCartegoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvBankAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateLastEditedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastEditedByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsPayable = New IncomeExpenditure.dsAccountsPayable()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbStatement = New System.Windows.Forms.RadioButton()
        Me.rbInvoice = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VendorInvoicesTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter()
        Me.GLStatementTableAdapter = New IncomeExpenditure.dsCoATableAdapters.GLStatementTableAdapter()
        Me.CustomerTransactionsTableAdapter = New IncomeExpenditure.dsAccountsReceivableTableAdapters.CustomerTransactionsTableAdapter()
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCustomerTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsReceivable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVendorTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1280, 750)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rptInvoiceStatement)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rptInvoce)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1419, 730)
        Me.SplitContainer1.SplitterDistance = 597
        Me.SplitContainer1.TabIndex = 1
        '
        'rptInvoiceStatement
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.GLStatementBindingSource
        Me.rptInvoiceStatement.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rptInvoiceStatement.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptInvoiceStatement.rdlc"
        Me.rptInvoiceStatement.Location = New System.Drawing.Point(9, 259)
        Me.rptInvoiceStatement.Name = "rptInvoiceStatement"
        Me.rptInvoiceStatement.ServerReport.BearerToken = Nothing
        Me.rptInvoiceStatement.Size = New System.Drawing.Size(578, 213)
        Me.rptInvoiceStatement.TabIndex = 1
        Me.rptInvoiceStatement.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'rptInvoce
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.GLStatementBindingSource
        Me.rptInvoce.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rptInvoce.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptInvoice.rdlc"
        Me.rptInvoce.Location = New System.Drawing.Point(5, 6)
        Me.rptInvoce.Name = "rptInvoce"
        Me.rptInvoce.ServerReport.BearerToken = Nothing
        Me.rptInvoce.Size = New System.Drawing.Size(578, 213)
        Me.rptInvoce.TabIndex = 0
        Me.rptInvoce.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgCustomerTrans)
        Me.GroupBox1.Controls.Add(Me.dgVendorTrans)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 663)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice"
        '
        'dgCustomerTrans
        '
        Me.dgCustomerTrans.AllowUserToAddRows = False
        Me.dgCustomerTrans.AllowUserToDeleteRows = False
        Me.dgCustomerTrans.AutoGenerateColumns = False
        Me.dgCustomerTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCustomerTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.InvPaymentType, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.VatAmount, Me.NetAmount, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn26})
        Me.dgCustomerTrans.DataSource = Me.CustomerTransactionsBindingSource
        Me.dgCustomerTrans.Location = New System.Drawing.Point(3, 257)
        Me.dgCustomerTrans.Name = "dgCustomerTrans"
        Me.dgCustomerTrans.ReadOnly = True
        Me.dgCustomerTrans.Size = New System.Drawing.Size(785, 149)
        Me.dgCustomerTrans.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNumber"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InvoiceNumber"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'InvPaymentType
        '
        Me.InvPaymentType.DataPropertyName = "InvPaymentType"
        Me.InvPaymentType.HeaderText = "InvPaymentType"
        Me.InvPaymentType.Name = "InvPaymentType"
        Me.InvPaymentType.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "InvDocNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DocNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "InvAmount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "InvConvAmount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ConvAmount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "InvBalance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'VatAmount
        '
        Me.VatAmount.DataPropertyName = "VatAmount"
        Me.VatAmount.HeaderText = "VatAmount"
        Me.VatAmount.Name = "VatAmount"
        Me.VatAmount.ReadOnly = True
        '
        'NetAmount
        '
        Me.NetAmount.DataPropertyName = "NetAmount"
        Me.NetAmount.HeaderText = "NetAmount"
        Me.NetAmount.Name = "NetAmount"
        Me.NetAmount.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "InvCurrency"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Period"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Period"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "InvDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "InvDueDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DueDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "InvPostDate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PostDate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "InvPostedBy"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PostedBy"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "InvNotes"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "InvCleared"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Cleared"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "InvActive"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "InvPaymentRef"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PaymentRef"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "InvTransType"
        Me.DataGridViewTextBoxColumn16.HeaderText = "TransType"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DC"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DC"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "InvPaymentType"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PaymentType"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "InvBankAccount"
        Me.DataGridViewTextBoxColumn19.HeaderText = "BankAccount"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "InvVatAccount"
        Me.DataGridViewTextBoxColumn20.HeaderText = "VatAccount"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "InvCartegory"
        Me.DataGridViewTextBoxColumn15.HeaderText = "RevenueAccount"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "InvCompany"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "DateLastEdited"
        Me.DataGridViewTextBoxColumn22.HeaderText = "DateLastEdited"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "LastEditedBy"
        Me.DataGridViewTextBoxColumn23.HeaderText = "LastEditedBy"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "InvRef"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Ref"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'CustomerTransactionsBindingSource
        '
        Me.CustomerTransactionsBindingSource.DataMember = "CustomerTransactions"
        Me.CustomerTransactionsBindingSource.DataSource = Me.DsAccountsReceivable
        '
        'DsAccountsReceivable
        '
        Me.DsAccountsReceivable.DataSetName = "dsAccountsReceivable"
        Me.DsAccountsReceivable.EnforceConstraints = False
        Me.DsAccountsReceivable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgVendorTrans
        '
        Me.dgVendorTrans.AllowUserToAddRows = False
        Me.dgVendorTrans.AllowUserToDeleteRows = False
        Me.dgVendorTrans.AutoGenerateColumns = False
        Me.dgVendorTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVendorTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNumberDataGridViewTextBoxColumn, Me.InvDocNumberDataGridViewTextBoxColumn, Me.InvVendorAccNumberDataGridViewTextBoxColumn, Me.InvAmountDataGridViewTextBoxColumn, Me.InvConvAmountDataGridViewTextBoxColumn, Me.InvBalanceDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn24, Me.InvCurrencyDataGridViewTextBoxColumn, Me.PeriodDataGridViewTextBoxColumn, Me.InvDateDataGridViewTextBoxColumn, Me.InvDueDateDataGridViewTextBoxColumn, Me.InvPostDateDataGridViewTextBoxColumn, Me.InvPostedByDataGridViewTextBoxColumn, Me.InvNotesDataGridViewTextBoxColumn, Me.InvClearedDataGridViewCheckBoxColumn, Me.InvActiveDataGridViewCheckBoxColumn, Me.InvPaymentRefDataGridViewTextBoxColumn, Me.InvTransTypeDataGridViewTextBoxColumn, Me.InvPaymentTypeDataGridViewTextBoxColumn, Me.DCDataGridViewTextBoxColumn, Me.InvVatAccount, Me.InvCartegoryDataGridViewTextBoxColumn, Me.InvBankAccountDataGridViewTextBoxColumn, Me.InvCompanyDataGridViewTextBoxColumn, Me.DateLastEditedDataGridViewTextBoxColumn, Me.LastEditedByDataGridViewTextBoxColumn, Me.InvRefDataGridViewTextBoxColumn})
        Me.dgVendorTrans.DataSource = Me.VendorInvoicesBindingSource
        Me.dgVendorTrans.Location = New System.Drawing.Point(3, 16)
        Me.dgVendorTrans.Name = "dgVendorTrans"
        Me.dgVendorTrans.ReadOnly = True
        Me.dgVendorTrans.Size = New System.Drawing.Size(785, 149)
        Me.dgVendorTrans.TabIndex = 0
        '
        'InvoiceNumberDataGridViewTextBoxColumn
        '
        Me.InvoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn.Name = "InvoiceNumberDataGridViewTextBoxColumn"
        Me.InvoiceNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvDocNumberDataGridViewTextBoxColumn
        '
        Me.InvDocNumberDataGridViewTextBoxColumn.DataPropertyName = "InvDocNumber"
        Me.InvDocNumberDataGridViewTextBoxColumn.HeaderText = "DocNumber"
        Me.InvDocNumberDataGridViewTextBoxColumn.Name = "InvDocNumberDataGridViewTextBoxColumn"
        Me.InvDocNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvVendorAccNumberDataGridViewTextBoxColumn
        '
        Me.InvVendorAccNumberDataGridViewTextBoxColumn.DataPropertyName = "InvVendorAccNumber"
        Me.InvVendorAccNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber"
        Me.InvVendorAccNumberDataGridViewTextBoxColumn.Name = "InvVendorAccNumberDataGridViewTextBoxColumn"
        Me.InvVendorAccNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvAmountDataGridViewTextBoxColumn
        '
        Me.InvAmountDataGridViewTextBoxColumn.DataPropertyName = "InvAmount"
        Me.InvAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.InvAmountDataGridViewTextBoxColumn.Name = "InvAmountDataGridViewTextBoxColumn"
        Me.InvAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvConvAmountDataGridViewTextBoxColumn
        '
        Me.InvConvAmountDataGridViewTextBoxColumn.DataPropertyName = "InvConvAmount"
        Me.InvConvAmountDataGridViewTextBoxColumn.HeaderText = "ConvAmount"
        Me.InvConvAmountDataGridViewTextBoxColumn.Name = "InvConvAmountDataGridViewTextBoxColumn"
        Me.InvConvAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvBalanceDataGridViewTextBoxColumn
        '
        Me.InvBalanceDataGridViewTextBoxColumn.DataPropertyName = "InvBalance"
        Me.InvBalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.InvBalanceDataGridViewTextBoxColumn.Name = "InvBalanceDataGridViewTextBoxColumn"
        Me.InvBalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VatAmount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "VatAmount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NetAmount"
        Me.DataGridViewTextBoxColumn24.HeaderText = "NetAmount"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'InvCurrencyDataGridViewTextBoxColumn
        '
        Me.InvCurrencyDataGridViewTextBoxColumn.DataPropertyName = "InvCurrency"
        Me.InvCurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.InvCurrencyDataGridViewTextBoxColumn.Name = "InvCurrencyDataGridViewTextBoxColumn"
        Me.InvCurrencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.ReadOnly = True
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
        'InvPostDateDataGridViewTextBoxColumn
        '
        Me.InvPostDateDataGridViewTextBoxColumn.DataPropertyName = "InvPostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.HeaderText = "PostDate"
        Me.InvPostDateDataGridViewTextBoxColumn.Name = "InvPostDateDataGridViewTextBoxColumn"
        Me.InvPostDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvPostedByDataGridViewTextBoxColumn
        '
        Me.InvPostedByDataGridViewTextBoxColumn.DataPropertyName = "InvPostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.HeaderText = "PostedBy"
        Me.InvPostedByDataGridViewTextBoxColumn.Name = "InvPostedByDataGridViewTextBoxColumn"
        Me.InvPostedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvNotesDataGridViewTextBoxColumn
        '
        Me.InvNotesDataGridViewTextBoxColumn.DataPropertyName = "InvNotes"
        Me.InvNotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.InvNotesDataGridViewTextBoxColumn.Name = "InvNotesDataGridViewTextBoxColumn"
        Me.InvNotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvClearedDataGridViewCheckBoxColumn
        '
        Me.InvClearedDataGridViewCheckBoxColumn.DataPropertyName = "InvCleared"
        Me.InvClearedDataGridViewCheckBoxColumn.HeaderText = "Cleared"
        Me.InvClearedDataGridViewCheckBoxColumn.Name = "InvClearedDataGridViewCheckBoxColumn"
        Me.InvClearedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'InvActiveDataGridViewCheckBoxColumn
        '
        Me.InvActiveDataGridViewCheckBoxColumn.DataPropertyName = "InvActive"
        Me.InvActiveDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.InvActiveDataGridViewCheckBoxColumn.Name = "InvActiveDataGridViewCheckBoxColumn"
        Me.InvActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'InvPaymentRefDataGridViewTextBoxColumn
        '
        Me.InvPaymentRefDataGridViewTextBoxColumn.DataPropertyName = "InvPaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.HeaderText = "PaymentRef"
        Me.InvPaymentRefDataGridViewTextBoxColumn.Name = "InvPaymentRefDataGridViewTextBoxColumn"
        Me.InvPaymentRefDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvTransTypeDataGridViewTextBoxColumn
        '
        Me.InvTransTypeDataGridViewTextBoxColumn.DataPropertyName = "InvTransType"
        Me.InvTransTypeDataGridViewTextBoxColumn.HeaderText = "TransType"
        Me.InvTransTypeDataGridViewTextBoxColumn.Name = "InvTransTypeDataGridViewTextBoxColumn"
        Me.InvTransTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvPaymentTypeDataGridViewTextBoxColumn
        '
        Me.InvPaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "InvPaymentType"
        Me.InvPaymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType"
        Me.InvPaymentTypeDataGridViewTextBoxColumn.Name = "InvPaymentTypeDataGridViewTextBoxColumn"
        Me.InvPaymentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DCDataGridViewTextBoxColumn
        '
        Me.DCDataGridViewTextBoxColumn.DataPropertyName = "DC"
        Me.DCDataGridViewTextBoxColumn.HeaderText = "DC"
        Me.DCDataGridViewTextBoxColumn.Name = "DCDataGridViewTextBoxColumn"
        Me.DCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvVatAccount
        '
        Me.InvVatAccount.DataPropertyName = "InvVatAccount"
        Me.InvVatAccount.HeaderText = "VatAccount"
        Me.InvVatAccount.Name = "InvVatAccount"
        Me.InvVatAccount.ReadOnly = True
        '
        'InvCartegoryDataGridViewTextBoxColumn
        '
        Me.InvCartegoryDataGridViewTextBoxColumn.DataPropertyName = "InvCartegory"
        Me.InvCartegoryDataGridViewTextBoxColumn.HeaderText = "ExpenseAccount"
        Me.InvCartegoryDataGridViewTextBoxColumn.Name = "InvCartegoryDataGridViewTextBoxColumn"
        Me.InvCartegoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvBankAccountDataGridViewTextBoxColumn
        '
        Me.InvBankAccountDataGridViewTextBoxColumn.DataPropertyName = "InvBankAccount"
        Me.InvBankAccountDataGridViewTextBoxColumn.HeaderText = "BankAccount"
        Me.InvBankAccountDataGridViewTextBoxColumn.Name = "InvBankAccountDataGridViewTextBoxColumn"
        Me.InvBankAccountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvCompanyDataGridViewTextBoxColumn
        '
        Me.InvCompanyDataGridViewTextBoxColumn.DataPropertyName = "InvCompany"
        Me.InvCompanyDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.InvCompanyDataGridViewTextBoxColumn.Name = "InvCompanyDataGridViewTextBoxColumn"
        Me.InvCompanyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateLastEditedDataGridViewTextBoxColumn
        '
        Me.DateLastEditedDataGridViewTextBoxColumn.DataPropertyName = "DateLastEdited"
        Me.DateLastEditedDataGridViewTextBoxColumn.HeaderText = "DateLastEdited"
        Me.DateLastEditedDataGridViewTextBoxColumn.Name = "DateLastEditedDataGridViewTextBoxColumn"
        Me.DateLastEditedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastEditedByDataGridViewTextBoxColumn
        '
        Me.LastEditedByDataGridViewTextBoxColumn.DataPropertyName = "LastEditedBy"
        Me.LastEditedByDataGridViewTextBoxColumn.HeaderText = "LastEditedBy"
        Me.LastEditedByDataGridViewTextBoxColumn.Name = "LastEditedByDataGridViewTextBoxColumn"
        Me.LastEditedByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvRefDataGridViewTextBoxColumn
        '
        Me.InvRefDataGridViewTextBoxColumn.DataPropertyName = "InvRef"
        Me.InvRefDataGridViewTextBoxColumn.HeaderText = "Ref"
        Me.InvRefDataGridViewTextBoxColumn.Name = "InvRefDataGridViewTextBoxColumn"
        Me.InvRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvRefDataGridViewTextBoxColumn.Visible = False
        '
        'VendorInvoicesBindingSource
        '
        Me.VendorInvoicesBindingSource.DataMember = "VendorInvoices"
        Me.VendorInvoicesBindingSource.DataSource = Me.DsAccountsPayable
        '
        'DsAccountsPayable
        '
        Me.DsAccountsPayable.DataSetName = "dsAccountsPayable"
        Me.DsAccountsPayable.EnforceConstraints = False
        Me.DsAccountsPayable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbStatement)
        Me.GroupBox6.Controls.Add(Me.rbInvoice)
        Me.GroupBox6.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(791, 42)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Statement Options"
        '
        'rbStatement
        '
        Me.rbStatement.AutoSize = True
        Me.rbStatement.Location = New System.Drawing.Point(102, 19)
        Me.rbStatement.Name = "rbStatement"
        Me.rbStatement.Size = New System.Drawing.Size(73, 17)
        Me.rbStatement.TabIndex = 1
        Me.rbStatement.Text = "Statement"
        Me.rbStatement.UseVisualStyleBackColor = True
        '
        'rbInvoice
        '
        Me.rbInvoice.AutoSize = True
        Me.rbInvoice.Checked = True
        Me.rbInvoice.Location = New System.Drawing.Point(6, 19)
        Me.rbInvoice.Name = "rbInvoice"
        Me.rbInvoice.Size = New System.Drawing.Size(60, 17)
        Me.rbInvoice.TabIndex = 0
        Me.rbInvoice.TabStop = True
        Me.rbInvoice.Text = "Invoice"
        Me.rbInvoice.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1419, 730)
        Me.Panel1.TabIndex = 2
        '
        'VendorInvoicesTableAdapter
        '
        Me.VendorInvoicesTableAdapter.ClearBeforeFill = True
        '
        'GLStatementTableAdapter
        '
        Me.GLStatementTableAdapter.ClearBeforeFill = True
        '
        'CustomerTransactionsTableAdapter
        '
        Me.CustomerTransactionsTableAdapter.ClearBeforeFill = True
        '
        'dgViewVendorInvoice
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 791)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dgViewVendorInvoice"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View"
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCustomerTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsReceivable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVendorTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents rptInvoce As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents DsAccountsPayable As dsAccountsPayable
    Friend WithEvents VendorInvoicesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorInvoicesTableAdapter As dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter
    Friend WithEvents GLStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsCoA As dsCoA
    Friend WithEvents GLStatementTableAdapter As dsCoATableAdapters.GLStatementTableAdapter
    Friend WithEvents rptInvoiceStatement As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents rbStatement As Windows.Forms.RadioButton
    Friend WithEvents rbInvoice As Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents dgVendorTrans As Windows.Forms.DataGridView
    Friend WithEvents dgCustomerTrans As Windows.Forms.DataGridView
    Friend WithEvents DsAccountsReceivable As dsAccountsReceivable
    Friend WithEvents CustomerTransactionsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents CustomerTransactionsTableAdapter As dsAccountsReceivableTableAdapters.CustomerTransactionsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPaymentType As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VatAmount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetAmount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDocNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvVendorAccNumberDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvConvAmountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBalanceDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCurrencyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvDueDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostDateDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPostedByDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNotesDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvClearedDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InvActiveDataGridViewCheckBoxColumn As Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InvPaymentRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvTransTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvPaymentTypeDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvVatAccount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCartegoryDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvBankAccountDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvCompanyDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateLastEditedDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastEditedByDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvRefDataGridViewTextBoxColumn As Windows.Forms.DataGridViewTextBoxColumn
End Class
