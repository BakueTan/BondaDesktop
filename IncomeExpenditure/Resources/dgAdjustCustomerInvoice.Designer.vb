<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgAdjustCustomerInvoice
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInvref = New System.Windows.Forms.TextBox()
        Me.VendorInvoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccountsPayable = New IncomeExpenditure.dsAccountsPayable()
        Me.cboVendorCCOUNT = New System.Windows.Forms.ComboBox()
        Me.VendorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvNotes = New System.Windows.Forms.TextBox()
        Me.mskInvDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskInvDueDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboInvCurrency = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.VendorInvoicesTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter()
        Me.VendorsTableAdapter = New IncomeExpenditure.dsAccountsPayableTableAdapters.VendorsTableAdapter()
        Me.scInvoiceAdjust = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCreditMemoPeriod = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCreditMemoInvRef = New System.Windows.Forms.TextBox()
        Me.cboCreditMemoVendor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCreditMemoNotes = New System.Windows.Forms.TextBox()
        Me.mskCreditMemoDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboCreditMemoCurrency = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCreditMemoDoc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCreditMemoAmount = New System.Windows.Forms.TextBox()
        Me.cboCreditMemoAdjust = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.scInvoicedCancel = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCancelInvoiceInvRef = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCancelInvoiceNotes = New System.Windows.Forms.TextBox()
        Me.mskCancelInvoiceDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCancelInvoiceDoc = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scInvoiceAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scInvoiceAdjust.Panel1.SuspendLayout()
        Me.scInvoiceAdjust.Panel2.SuspendLayout()
        Me.scInvoiceAdjust.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scInvoicedCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scInvoicedCancel.Panel1.SuspendLayout()
        Me.scInvoicedCancel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(730, 443)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(5, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(74, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(93, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(69, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtInvref)
        Me.GroupBox1.Controls.Add(Me.cboVendorCCOUNT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInvNotes)
        Me.GroupBox1.Controls.Add(Me.mskInvDate)
        Me.GroupBox1.Controls.Add(Me.mskInvDueDate)
        Me.GroupBox1.Controls.Add(Me.cboInvCurrency)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Button1)
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 100)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Invoice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Ref"
        '
        'txtInvref
        '
        Me.txtInvref.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvRef", True))
        Me.txtInvref.Enabled = False
        Me.txtInvref.Location = New System.Drawing.Point(94, 346)
        Me.txtInvref.Name = "txtInvref"
        Me.txtInvref.ReadOnly = True
        Me.txtInvref.Size = New System.Drawing.Size(173, 20)
        Me.txtInvref.TabIndex = 81
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
        'cboVendorCCOUNT
        '
        Me.cboVendorCCOUNT.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorInvoicesBindingSource, "InvVendorAccNumber", True))
        Me.cboVendorCCOUNT.DataSource = Me.VendorsBindingSource
        Me.cboVendorCCOUNT.DisplayMember = "Name"
        Me.cboVendorCCOUNT.FormattingEnabled = True
        Me.cboVendorCCOUNT.Location = New System.Drawing.Point(94, 19)
        Me.cboVendorCCOUNT.Name = "cboVendorCCOUNT"
        Me.cboVendorCCOUNT.Size = New System.Drawing.Size(173, 21)
        Me.cboVendorCCOUNT.TabIndex = 79
        Me.cboVendorCCOUNT.ValueMember = "AccNumber"
        '
        'VendorsBindingSource
        '
        Me.VendorsBindingSource.DataMember = "Vendors"
        Me.VendorsBindingSource.DataSource = Me.DsAccountsPayable
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Vendor:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(296, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 194)
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Notes:"
        '
        'txtInvNotes
        '
        Me.txtInvNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvNotes", True))
        Me.txtInvNotes.Location = New System.Drawing.Point(94, 245)
        Me.txtInvNotes.Multiline = True
        Me.txtInvNotes.Name = "txtInvNotes"
        Me.txtInvNotes.Size = New System.Drawing.Size(173, 95)
        Me.txtInvNotes.TabIndex = 75
        '
        'mskInvDate
        '
        Me.mskInvDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvDate", True))
        Me.mskInvDate.Location = New System.Drawing.Point(94, 183)
        Me.mskInvDate.Mask = "00/00/0000"
        Me.mskInvDate.Name = "mskInvDate"
        Me.mskInvDate.Size = New System.Drawing.Size(173, 20)
        Me.mskInvDate.TabIndex = 5
        Me.mskInvDate.ValidatingType = GetType(Date)
        '
        'mskInvDueDate
        '
        Me.mskInvDueDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvDueDate", True))
        Me.mskInvDueDate.Location = New System.Drawing.Point(94, 219)
        Me.mskInvDueDate.Mask = "00/00/0000"
        Me.mskInvDueDate.Name = "mskInvDueDate"
        Me.mskInvDueDate.Size = New System.Drawing.Size(173, 20)
        Me.mskInvDueDate.TabIndex = 6
        Me.mskInvDueDate.ValidatingType = GetType(Date)
        '
        'cboInvCurrency
        '
        Me.cboInvCurrency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvCurrency", True))
        Me.cboInvCurrency.Enabled = False
        Me.cboInvCurrency.FormattingEnabled = True
        Me.cboInvCurrency.Location = New System.Drawing.Point(94, 129)
        Me.cboInvCurrency.Name = "cboInvCurrency"
        Me.cboInvCurrency.Size = New System.Drawing.Size(105, 21)
        Me.cboInvCurrency.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Currency:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(437, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 20)
        Me.Button1.TabIndex = 7
        Me.Button1.Tag = " "
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Due Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Doc Number:"
        '
        'txtInvNumber
        '
        Me.txtInvNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvDocNumber", True))
        Me.txtInvNumber.Location = New System.Drawing.Point(94, 45)
        Me.txtInvNumber.Name = "txtInvNumber"
        Me.txtInvNumber.Size = New System.Drawing.Size(173, 20)
        Me.txtInvNumber.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 186)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Invoice Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Amount:"
        '
        'cboInvPeriod
        '
        Me.cboInvPeriod.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorInvoicesBindingSource, "Period", True))
        Me.cboInvPeriod.FormattingEnabled = True
        Me.cboInvPeriod.Location = New System.Drawing.Point(94, 156)
        Me.cboInvPeriod.Name = "cboInvPeriod"
        Me.cboInvPeriod.Size = New System.Drawing.Size(173, 21)
        Me.cboInvPeriod.TabIndex = 4
        '
        'txtInvAmnt
        '
        Me.txtInvAmnt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvAmount", True))
        Me.txtInvAmnt.Enabled = False
        Me.txtInvAmnt.Location = New System.Drawing.Point(94, 103)
        Me.txtInvAmnt.Name = "txtInvAmnt"
        Me.txtInvAmnt.Size = New System.Drawing.Size(173, 20)
        Me.txtInvAmnt.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Period:"
        '
        'cboInvCartegory
        '
        Me.cboInvCartegory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvCartegory", True))
        Me.cboInvCartegory.FormattingEnabled = True
        Me.cboInvCartegory.Location = New System.Drawing.Point(94, 76)
        Me.cboInvCartegory.Name = "cboInvCartegory"
        Me.cboInvCartegory.Size = New System.Drawing.Size(173, 21)
        Me.cboInvCartegory.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Cartegory:"
        '
        'VendorInvoicesTableAdapter
        '
        Me.VendorInvoicesTableAdapter.ClearBeforeFill = True
        '
        'VendorsTableAdapter
        '
        Me.VendorsTableAdapter.ClearBeforeFill = True
        '
        'scInvoiceAdjust
        '
        Me.scInvoiceAdjust.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scInvoiceAdjust.Location = New System.Drawing.Point(214, 3)
        Me.scInvoiceAdjust.Name = "scInvoiceAdjust"
        '
        'scInvoiceAdjust.Panel1
        '
        Me.scInvoiceAdjust.Panel1.Controls.Add(Me.GroupBox2)
        '
        'scInvoiceAdjust.Panel2
        '
        Me.scInvoiceAdjust.Panel2.Controls.Add(Me.GroupBox1)
        Me.scInvoiceAdjust.Panel2Collapsed = True
        Me.scInvoiceAdjust.Size = New System.Drawing.Size(565, 384)
        Me.scInvoiceAdjust.SplitterDistance = 177
        Me.scInvoiceAdjust.TabIndex = 66
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCreditMemoPeriod)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCreditMemoInvRef)
        Me.GroupBox2.Controls.Add(Me.cboCreditMemoVendor)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCreditMemoNotes)
        Me.GroupBox2.Controls.Add(Me.mskCreditMemoDate)
        Me.GroupBox2.Controls.Add(Me.cboCreditMemoCurrency)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtCreditMemoDoc)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtCreditMemoAmount)
        Me.GroupBox2.Controls.Add(Me.cboCreditMemoAdjust)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 384)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debit Memo"
        '
        'cboCreditMemoPeriod
        '
        Me.cboCreditMemoPeriod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvCurrency", True))
        Me.cboCreditMemoPeriod.FormattingEnabled = True
        Me.cboCreditMemoPeriod.Location = New System.Drawing.Point(94, 182)
        Me.cboCreditMemoPeriod.Name = "cboCreditMemoPeriod"
        Me.cboCreditMemoPeriod.Size = New System.Drawing.Size(105, 21)
        Me.cboCreditMemoPeriod.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Currency:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "InvoiceRef"
        '
        'txtCreditMemoInvRef
        '
        Me.txtCreditMemoInvRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvRef", True))
        Me.txtCreditMemoInvRef.Enabled = False
        Me.txtCreditMemoInvRef.Location = New System.Drawing.Point(94, 320)
        Me.txtCreditMemoInvRef.Name = "txtCreditMemoInvRef"
        Me.txtCreditMemoInvRef.ReadOnly = True
        Me.txtCreditMemoInvRef.Size = New System.Drawing.Size(173, 20)
        Me.txtCreditMemoInvRef.TabIndex = 81
        '
        'cboCreditMemoVendor
        '
        Me.cboCreditMemoVendor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorInvoicesBindingSource, "InvVendorAccNumber", True))
        Me.cboCreditMemoVendor.DataSource = Me.VendorsBindingSource
        Me.cboCreditMemoVendor.DisplayMember = "Name"
        Me.cboCreditMemoVendor.Enabled = False
        Me.cboCreditMemoVendor.FormattingEnabled = True
        Me.cboCreditMemoVendor.Location = New System.Drawing.Point(94, 19)
        Me.cboCreditMemoVendor.Name = "cboCreditMemoVendor"
        Me.cboCreditMemoVendor.Size = New System.Drawing.Size(173, 21)
        Me.cboCreditMemoVendor.TabIndex = 79
        Me.cboCreditMemoVendor.ValueMember = "AccNumber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Customer:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(296, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(330, 194)
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Notes:"
        '
        'txtCreditMemoNotes
        '
        Me.txtCreditMemoNotes.Location = New System.Drawing.Point(94, 209)
        Me.txtCreditMemoNotes.Multiline = True
        Me.txtCreditMemoNotes.Name = "txtCreditMemoNotes"
        Me.txtCreditMemoNotes.Size = New System.Drawing.Size(173, 95)
        Me.txtCreditMemoNotes.TabIndex = 75
        '
        'mskCreditMemoDate
        '
        Me.mskCreditMemoDate.Location = New System.Drawing.Point(94, 156)
        Me.mskCreditMemoDate.Mask = "00/00/0000"
        Me.mskCreditMemoDate.Name = "mskCreditMemoDate"
        Me.mskCreditMemoDate.Size = New System.Drawing.Size(173, 20)
        Me.mskCreditMemoDate.TabIndex = 5
        Me.mskCreditMemoDate.ValidatingType = GetType(Date)
        '
        'cboCreditMemoCurrency
        '
        Me.cboCreditMemoCurrency.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvCurrency", True))
        Me.cboCreditMemoCurrency.FormattingEnabled = True
        Me.cboCreditMemoCurrency.Location = New System.Drawing.Point(94, 129)
        Me.cboCreditMemoCurrency.Name = "cboCreditMemoCurrency"
        Me.cboCreditMemoCurrency.Size = New System.Drawing.Size(105, 21)
        Me.cboCreditMemoCurrency.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Currency:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(437, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 20)
        Me.Button2.TabIndex = 7
        Me.Button2.Tag = " "
        Me.Button2.Text = "..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "Doc Number:"
        '
        'txtCreditMemoDoc
        '
        Me.txtCreditMemoDoc.Location = New System.Drawing.Point(94, 45)
        Me.txtCreditMemoDoc.Name = "txtCreditMemoDoc"
        Me.txtCreditMemoDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtCreditMemoDoc.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 159)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Amount:"
        '
        'txtCreditMemoAmount
        '
        Me.txtCreditMemoAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvAmount", True))
        Me.txtCreditMemoAmount.Location = New System.Drawing.Point(94, 71)
        Me.txtCreditMemoAmount.Name = "txtCreditMemoAmount"
        Me.txtCreditMemoAmount.Size = New System.Drawing.Size(173, 20)
        Me.txtCreditMemoAmount.TabIndex = 2
        '
        'cboCreditMemoAdjust
        '
        Me.cboCreditMemoAdjust.FormattingEnabled = True
        Me.cboCreditMemoAdjust.Items.AddRange(New Object() {"D", "C"})
        Me.cboCreditMemoAdjust.Location = New System.Drawing.Point(94, 102)
        Me.cboCreditMemoAdjust.Name = "cboCreditMemoAdjust"
        Me.cboCreditMemoAdjust.Size = New System.Drawing.Size(105, 21)
        Me.cboCreditMemoAdjust.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 102)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Adjustment:"
        '
        'scInvoicedCancel
        '
        Me.scInvoicedCancel.Location = New System.Drawing.Point(17, 16)
        Me.scInvoicedCancel.Name = "scInvoicedCancel"
        '
        'scInvoicedCancel.Panel1
        '
        Me.scInvoicedCancel.Panel1.Controls.Add(Me.GroupBox3)
        Me.scInvoicedCancel.Panel2Collapsed = True
        Me.scInvoicedCancel.Size = New System.Drawing.Size(116, 41)
        Me.scInvoicedCancel.SplitterDistance = 91
        Me.scInvoicedCancel.TabIndex = 67
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtCancelInvoiceInvRef)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtCancelInvoiceNotes)
        Me.GroupBox3.Controls.Add(Me.mskCancelInvoiceDate)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtCancelInvoiceDoc)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(116, 41)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cancel Invoice"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "InvoiceRef"
        '
        'txtCancelInvoiceInvRef
        '
        Me.txtCancelInvoiceInvRef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorInvoicesBindingSource, "InvRef", True))
        Me.txtCancelInvoiceInvRef.Enabled = False
        Me.txtCancelInvoiceInvRef.Location = New System.Drawing.Point(105, 185)
        Me.txtCancelInvoiceInvRef.Name = "txtCancelInvoiceInvRef"
        Me.txtCancelInvoiceInvRef.ReadOnly = True
        Me.txtCancelInvoiceInvRef.Size = New System.Drawing.Size(173, 20)
        Me.txtCancelInvoiceInvRef.TabIndex = 81
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(296, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(410, 432)
        Me.PictureBox3.TabIndex = 78
        Me.PictureBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Notes:"
        '
        'txtCancelInvoiceNotes
        '
        Me.txtCancelInvoiceNotes.Location = New System.Drawing.Point(105, 75)
        Me.txtCancelInvoiceNotes.Multiline = True
        Me.txtCancelInvoiceNotes.Name = "txtCancelInvoiceNotes"
        Me.txtCancelInvoiceNotes.Size = New System.Drawing.Size(173, 95)
        Me.txtCancelInvoiceNotes.TabIndex = 75
        '
        'mskCancelInvoiceDate
        '
        Me.mskCancelInvoiceDate.Location = New System.Drawing.Point(105, 47)
        Me.mskCancelInvoiceDate.Mask = "00/00/0000"
        Me.mskCancelInvoiceDate.Name = "mskCancelInvoiceDate"
        Me.mskCancelInvoiceDate.Size = New System.Drawing.Size(173, 20)
        Me.mskCancelInvoiceDate.TabIndex = 5
        Me.mskCancelInvoiceDate.ValidatingType = GetType(Date)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 24)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "Doc Number:"
        '
        'txtCancelInvoiceDoc
        '
        Me.txtCancelInvoiceDoc.Location = New System.Drawing.Point(105, 21)
        Me.txtCancelInvoiceDoc.Name = "txtCancelInvoiceDoc"
        Me.txtCancelInvoiceDoc.Size = New System.Drawing.Size(173, 20)
        Me.txtCancelInvoiceDoc.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 52)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 13)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Date:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.scInvoicedCancel)
        Me.Panel1.Controls.Add(Me.scInvoiceAdjust)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 425)
        Me.Panel1.TabIndex = 68
        '
        'dgAdjustCustomerInvoice
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(912, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dgAdjustCustomerInvoice"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adjust"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VendorInvoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccountsPayable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scInvoiceAdjust.Panel1.ResumeLayout(False)
        Me.scInvoiceAdjust.Panel2.ResumeLayout(False)
        CType(Me.scInvoiceAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scInvoiceAdjust.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scInvoicedCancel.Panel1.ResumeLayout(False)
        CType(Me.scInvoicedCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scInvoicedCancel.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents mskInvDate As Windows.Forms.MaskedTextBox
    Friend WithEvents mskInvDueDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboInvCurrency As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
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
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtInvNotes As Windows.Forms.TextBox
    Friend WithEvents DsAccountsPayable As dsAccountsPayable
    Friend WithEvents VendorInvoicesBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorInvoicesTableAdapter As dsAccountsPayableTableAdapters.VendorInvoicesTableAdapter
    Friend WithEvents cboVendorCCOUNT As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtInvref As Windows.Forms.TextBox
    Friend WithEvents VendorsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents VendorsTableAdapter As dsAccountsPayableTableAdapters.VendorsTableAdapter
    Friend WithEvents scInvoiceAdjust As Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtCreditMemoInvRef As Windows.Forms.TextBox
    Friend WithEvents cboCreditMemoVendor As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtCreditMemoNotes As Windows.Forms.TextBox
    Friend WithEvents mskCreditMemoDate As Windows.Forms.MaskedTextBox
    Friend WithEvents cboCreditMemoCurrency As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents txtCreditMemoDoc As Windows.Forms.TextBox
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents txtCreditMemoAmount As Windows.Forms.TextBox
    Friend WithEvents cboCreditMemoAdjust As Windows.Forms.ComboBox
    Friend WithEvents Label22 As Windows.Forms.Label
    Friend WithEvents scInvoicedCancel As Windows.Forms.SplitContainer
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txtCancelInvoiceInvRef As Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As Windows.Forms.PictureBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtCancelInvoiceNotes As Windows.Forms.TextBox
    Friend WithEvents mskCancelInvoiceDate As Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As Windows.Forms.Label
    Friend WithEvents txtCancelInvoiceDoc As Windows.Forms.TextBox
    Friend WithEvents Label24 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents cboCreditMemoPeriod As Windows.Forms.ComboBox
    Friend WithEvents Label15 As Windows.Forms.Label
End Class
