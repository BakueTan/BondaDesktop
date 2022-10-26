<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLedgerAccounts
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim StudentSurnameLabel As System.Windows.Forms.Label
        Dim NationalIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim StudentIDLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Label9 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbReceivabkes = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tbVendors = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbStudPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FeesSourceComboBox = New System.Windows.Forms.ComboBox()
        Me.StudentSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnCancelAllLines = New System.Windows.Forms.Button()
        Me.btnUpdateAllLines = New System.Windows.Forms.Button()
        Me.dgFessDetails = New System.Windows.Forms.DataGridView()
        Me.gbFeesPay = New System.Windows.Forms.GroupBox()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.txtFeesStudID = New System.Windows.Forms.TextBox()
        Me.lbStudFees = New System.Windows.Forms.ListBox()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.tbPayables = New System.Windows.Forms.TabPage()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TransAmnt = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Currency = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TransPeriod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TransDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.LineRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Label7 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        StudentSurnameLabel = New System.Windows.Forms.Label()
        NationalIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        StudentIDLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbReceivabkes.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tbVendors.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbStudPersonalDetails.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFeesPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(6, 298)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(70, 13)
        Label7.TabIndex = 35
        Label7.Text = "Bank Details:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(6, 381)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(82, 13)
        Label4.TabIndex = 29
        Label4.Text = "Account Group:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 408)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(52, 13)
        Label3.TabIndex = 27
        Label3.Text = "Currency:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 138)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 22
        Label2.Text = "Email:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(6, 82)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(78, 13)
        GenderLabel.TabIndex = 17
        GenderLabel.Text = "Contact Name:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.Location = New System.Drawing.Point(6, 170)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(87, 13)
        ReligionLabel.TabIndex = 14
        ReligionLabel.Text = "Physical Adrress:"
        '
        'StudentSurnameLabel
        '
        StudentSurnameLabel.AutoSize = True
        StudentSurnameLabel.Location = New System.Drawing.Point(6, 54)
        StudentSurnameLabel.Name = "StudentSurnameLabel"
        StudentSurnameLabel.Size = New System.Drawing.Size(57, 13)
        StudentSurnameLabel.TabIndex = 6
        StudentSurnameLabel.Text = "AccName:"
        '
        'NationalIDLabel
        '
        NationalIDLabel.AutoSize = True
        NationalIDLabel.Location = New System.Drawing.Point(6, 110)
        NationalIDLabel.Name = "NationalIDLabel"
        NationalIDLabel.Size = New System.Drawing.Size(87, 13)
        NationalIDLabel.TabIndex = 12
        NationalIDLabel.Text = "Contact Number:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(6, 26)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(66, 13)
        StudentIDLabel.TabIndex = 0
        StudentIDLabel.Text = "AccNumber:"
        '
        'StudentIDLabel1
        '
        StudentIDLabel1.AutoSize = True
        StudentIDLabel1.Location = New System.Drawing.Point(6, 60)
        StudentIDLabel1.Name = "StudentIDLabel1"
        StudentIDLabel1.Size = New System.Drawing.Size(50, 13)
        StudentIDLabel1.TabIndex = 0
        StudentIDLabel1.Text = "Account:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbReceivabkes)
        Me.TabControl1.Controls.Add(Me.tbPayables)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1171, 783)
        Me.TabControl1.TabIndex = 0
        '
        'tbReceivabkes
        '
        Me.tbReceivabkes.Controls.Add(Me.TabControl2)
        Me.tbReceivabkes.Location = New System.Drawing.Point(4, 22)
        Me.tbReceivabkes.Name = "tbReceivabkes"
        Me.tbReceivabkes.Padding = New System.Windows.Forms.Padding(3)
        Me.tbReceivabkes.Size = New System.Drawing.Size(1163, 757)
        Me.tbReceivabkes.TabIndex = 0
        Me.tbReceivabkes.Text = "Receivables"
        Me.tbReceivabkes.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.tbVendors)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1157, 751)
        Me.TabControl2.TabIndex = 1
        '
        'tbVendors
        '
        Me.tbVendors.Controls.Add(Me.SplitContainer1)
        Me.tbVendors.Location = New System.Drawing.Point(4, 22)
        Me.tbVendors.Name = "tbVendors"
        Me.tbVendors.Padding = New System.Windows.Forms.Padding(3)
        Me.tbVendors.Size = New System.Drawing.Size(1149, 725)
        Me.tbVendors.TabIndex = 0
        Me.tbVendors.Text = "Vendors"
        Me.tbVendors.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbStudPersonalDetails)
        Me.SplitContainer1.Size = New System.Drawing.Size(1143, 719)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.TabIndex = 0
        '
        'gbStudPersonalDetails
        '
        Me.gbStudPersonalDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbStudPersonalDetails.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox9)
        Me.gbStudPersonalDetails.Controls.Add(Label8)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox8)
        Me.gbStudPersonalDetails.Controls.Add(Label1)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox7)
        Me.gbStudPersonalDetails.Controls.Add(Label7)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox6)
        Me.gbStudPersonalDetails.Controls.Add(Label6)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox4)
        Me.gbStudPersonalDetails.Controls.Add(Label5)
        Me.gbStudPersonalDetails.Controls.Add(Me.CheckBox1)
        Me.gbStudPersonalDetails.Controls.Add(Label4)
        Me.gbStudPersonalDetails.Controls.Add(Me.ComboBox2)
        Me.gbStudPersonalDetails.Controls.Add(Label3)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox5)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox3)
        Me.gbStudPersonalDetails.Controls.Add(Label2)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox2)
        Me.gbStudPersonalDetails.Controls.Add(Me.TextBox1)
        Me.gbStudPersonalDetails.Controls.Add(Me.FeesSourceComboBox)
        Me.gbStudPersonalDetails.Controls.Add(GenderLabel)
        Me.gbStudPersonalDetails.Controls.Add(ReligionLabel)
        Me.gbStudPersonalDetails.Controls.Add(StudentSurnameLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.StudentSurnameTextBox)
        Me.gbStudPersonalDetails.Controls.Add(NationalIDLabel)
        Me.gbStudPersonalDetails.Controls.Add(StudentIDLabel)
        Me.gbStudPersonalDetails.Controls.Add(Me.StudentIDTextBox)
        Me.gbStudPersonalDetails.Location = New System.Drawing.Point(149, 15)
        Me.gbStudPersonalDetails.Name = "gbStudPersonalDetails"
        Me.gbStudPersonalDetails.Size = New System.Drawing.Size(639, 685)
        Me.gbStudPersonalDetails.TabIndex = 1
        Me.gbStudPersonalDetails.TabStop = False
        Me.gbStudPersonalDetails.Text = "Account Details"
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Location = New System.Drawing.Point(148, 255)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(485, 117)
        Me.TextBox7.TabIndex = 36
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(11, 613)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Blocked"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Beam", "Scholarship", "Guardian/Parent"})
        Me.ComboBox2.Location = New System.Drawing.Point(148, 378)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox2.TabIndex = 28
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(148, 159)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(485, 24)
        Me.TextBox5.TabIndex = 26
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(148, 131)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(485, 20)
        Me.TextBox3.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(148, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(485, 20)
        Me.TextBox2.TabIndex = 21
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(148, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(485, 20)
        Me.TextBox1.TabIndex = 18
        '
        'FeesSourceComboBox
        '
        Me.FeesSourceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FeesSourceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FeesSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FeesSourceComboBox.FormattingEnabled = True
        Me.FeesSourceComboBox.Items.AddRange(New Object() {"Beam", "Scholarship", "Guardian/Parent"})
        Me.FeesSourceComboBox.Location = New System.Drawing.Point(148, 405)
        Me.FeesSourceComboBox.Name = "FeesSourceComboBox"
        Me.FeesSourceComboBox.Size = New System.Drawing.Size(135, 21)
        Me.FeesSourceComboBox.TabIndex = 7
        '
        'StudentSurnameTextBox
        '
        Me.StudentSurnameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentSurnameTextBox.Location = New System.Drawing.Point(148, 47)
        Me.StudentSurnameTextBox.Name = "StudentSurnameTextBox"
        Me.StudentSurnameTextBox.Size = New System.Drawing.Size(485, 20)
        Me.StudentSurnameTextBox.TabIndex = 1
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.StudentIDTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StudentIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StudentIDTextBox.Location = New System.Drawing.Point(148, 19)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(485, 20)
        Me.StudentIDTextBox.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1149, 725)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer2.Size = New System.Drawing.Size(1143, 719)
        Me.SplitContainer2.SplitterDistance = 274
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.btnCancelAllLines)
        Me.GroupBox7.Controls.Add(Me.btnUpdateAllLines)
        Me.GroupBox7.Controls.Add(Me.dgFessDetails)
        Me.GroupBox7.Controls.Add(Me.gbFeesPay)
        Me.GroupBox7.Location = New System.Drawing.Point(34, 40)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(725, 561)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Fees Payments"
        '
        'btnCancelAllLines
        '
        Me.btnCancelAllLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelAllLines.Location = New System.Drawing.Point(281, 521)
        Me.btnCancelAllLines.Name = "btnCancelAllLines"
        Me.btnCancelAllLines.Size = New System.Drawing.Size(125, 34)
        Me.btnCancelAllLines.TabIndex = 43
        Me.btnCancelAllLines.Tag = " "
        Me.btnCancelAllLines.Text = "Cancel All Selected Lines"
        Me.btnCancelAllLines.UseVisualStyleBackColor = True
        '
        'btnUpdateAllLines
        '
        Me.btnUpdateAllLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateAllLines.Location = New System.Drawing.Point(103, 521)
        Me.btnUpdateAllLines.Name = "btnUpdateAllLines"
        Me.btnUpdateAllLines.Size = New System.Drawing.Size(125, 34)
        Me.btnUpdateAllLines.TabIndex = 42
        Me.btnUpdateAllLines.Tag = " "
        Me.btnUpdateAllLines.Text = "Update All Selected Lines"
        Me.btnUpdateAllLines.UseVisualStyleBackColor = True
        '
        'dgFessDetails
        '
        Me.dgFessDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFessDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransAmnt, Me.Currency, Me.TransPeriod, Me.TransDetails, Me.btnUpdate, Me.btnDelete, Me.LineRef})
        Me.dgFessDetails.Enabled = False
        Me.dgFessDetails.Location = New System.Drawing.Point(36, 236)
        Me.dgFessDetails.Name = "dgFessDetails"
        Me.dgFessDetails.Size = New System.Drawing.Size(650, 151)
        Me.dgFessDetails.TabIndex = 1
        '
        'gbFeesPay
        '
        Me.gbFeesPay.BackColor = System.Drawing.Color.LightSteelBlue
        Me.gbFeesPay.Controls.Add(Label9)
        Me.gbFeesPay.Controls.Add(Me.Button28)
        Me.gbFeesPay.Controls.Add(Me.txtFeesStudID)
        Me.gbFeesPay.Controls.Add(Me.lbStudFees)
        Me.gbFeesPay.Controls.Add(Me.lblfullname)
        Me.gbFeesPay.Controls.Add(StudentIDLabel1)
        Me.gbFeesPay.Enabled = False
        Me.gbFeesPay.Location = New System.Drawing.Point(36, 19)
        Me.gbFeesPay.Name = "gbFeesPay"
        Me.gbFeesPay.Size = New System.Drawing.Size(482, 190)
        Me.gbFeesPay.TabIndex = 0
        Me.gbFeesPay.TabStop = False
        '
        'Button28
        '
        Me.Button28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button28.Location = New System.Drawing.Point(346, 53)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(19, 20)
        Me.Button28.TabIndex = 52
        Me.Button28.UseVisualStyleBackColor = True
        '
        'txtFeesStudID
        '
        Me.txtFeesStudID.Location = New System.Drawing.Point(140, 53)
        Me.txtFeesStudID.Name = "txtFeesStudID"
        Me.txtFeesStudID.Size = New System.Drawing.Size(200, 20)
        Me.txtFeesStudID.TabIndex = 0
        '
        'lbStudFees
        '
        Me.lbStudFees.FormattingEnabled = True
        Me.lbStudFees.Location = New System.Drawing.Point(420, 19)
        Me.lbStudFees.Name = "lbStudFees"
        Me.lbStudFees.Size = New System.Drawing.Size(341, 69)
        Me.lbStudFees.TabIndex = 22
        Me.lbStudFees.Visible = False
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.ForeColor = System.Drawing.Color.Red
        Me.lblfullname.Location = New System.Drawing.Point(137, 11)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(33, 13)
        Me.lblfullname.TabIndex = 23
        Me.lblfullname.Text = "name"
        '
        'tbPayables
        '
        Me.tbPayables.Location = New System.Drawing.Point(4, 22)
        Me.tbPayables.Name = "tbPayables"
        Me.tbPayables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPayables.Size = New System.Drawing.Size(1163, 757)
        Me.tbPayables.TabIndex = 1
        Me.tbPayables.Text = "Payables"
        Me.tbPayables.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Location = New System.Drawing.Point(148, 432)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(485, 117)
        Me.TextBox8.TabIndex = 38
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(6, 475)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 37
        Label1.Text = "Notes:"
        '
        'TextBox9
        '
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(148, 565)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(485, 24)
        Me.TextBox9.TabIndex = 40
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(6, 568)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(46, 13)
        Label8.TabIndex = 39
        Label8.Text = "Balance"
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Location = New System.Drawing.Point(148, 223)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(485, 24)
        Me.TextBox6.TabIndex = 34
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(148, 191)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(485, 24)
        Me.TextBox4.TabIndex = 32
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(6, 234)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(43, 13)
        Label6.TabIndex = 33
        Label6.Text = "Country"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 202)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(27, 13)
        Label5.TabIndex = 31
        Label5.Text = "City:"
        '
        'TransAmnt
        '
        Me.TransAmnt.HeaderText = "Amount"
        Me.TransAmnt.Name = "TransAmnt"
        '
        'Currency
        '
        Me.Currency.DataPropertyName = "Currency"
        Me.Currency.HeaderText = "Currency"
        Me.Currency.Name = "Currency"
        Me.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Currency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'TransPeriod
        '
        Me.TransPeriod.HeaderText = "Period"
        Me.TransPeriod.Name = "TransPeriod"
        '
        'TransDetails
        '
        Me.TransDetails.HeaderText = "Details"
        Me.TransDetails.Name = "TransDetails"
        '
        'btnUpdate
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.DefaultCellStyle = DataGridViewCellStyle1
        Me.btnUpdate.HeaderText = "Update"
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        Me.btnUpdate.Visible = False
        '
        'btnDelete
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.btnDelete.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnDelete.HeaderText = "Delete"
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        Me.btnDelete.Visible = False
        '
        'LineRef
        '
        Me.LineRef.DataPropertyName = "LineRef"
        Me.LineRef.HeaderText = "LineRef"
        Me.LineRef.Name = "LineRef"
        Me.LineRef.Visible = False
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(6, 36)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(50, 13)
        Label9.TabIndex = 53
        Label9.Text = "Account:"
        '
        'frmLedgerAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 783)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLedgerAccounts"
        Me.Text = "frmLedgerAccounts"
        Me.TabControl1.ResumeLayout(False)
        Me.tbReceivabkes.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tbVendors.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbStudPersonalDetails.ResumeLayout(False)
        Me.gbStudPersonalDetails.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.dgFessDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFeesPay.ResumeLayout(False)
        Me.gbFeesPay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents tbReceivabkes As Windows.Forms.TabPage
    Friend WithEvents TabControl2 As Windows.Forms.TabControl
    Friend WithEvents tbVendors As Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents gbStudPersonalDetails As Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents FeesSourceComboBox As Windows.Forms.ComboBox
    Friend WithEvents StudentSurnameTextBox As Windows.Forms.TextBox
    Friend WithEvents StudentIDTextBox As Windows.Forms.TextBox
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents tbPayables As Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
    Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
    Friend WithEvents btnCancelAllLines As Windows.Forms.Button
    Friend WithEvents btnUpdateAllLines As Windows.Forms.Button
    Friend WithEvents dgFessDetails As Windows.Forms.DataGridView
    Friend WithEvents gbFeesPay As Windows.Forms.GroupBox
    Friend WithEvents Button28 As Windows.Forms.Button
    Friend WithEvents txtFeesStudID As Windows.Forms.TextBox
    Friend WithEvents lbStudFees As Windows.Forms.ListBox
    Friend WithEvents lblfullname As Windows.Forms.Label
    Friend WithEvents TextBox9 As Windows.Forms.TextBox
    Friend WithEvents TextBox8 As Windows.Forms.TextBox
    Friend WithEvents TextBox6 As Windows.Forms.TextBox
    Friend WithEvents TextBox4 As Windows.Forms.TextBox
    Friend WithEvents TransAmnt As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Currency As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TransPeriod As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TransDetails As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnDelete As Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents LineRef As Windows.Forms.DataGridViewTextBoxColumn
End Class
