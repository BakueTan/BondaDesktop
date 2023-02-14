Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountingReports
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ProfitLoss")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CashFlow")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BalanceSheet")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Accounting Reports", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvAccountingReports = New System.Windows.Forms.TreeView()
        Me.gbProfitAndLoss = New System.Windows.Forms.GroupBox()
        Me.chkPLzeroBalances = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPLPeriodTo = New System.Windows.Forms.ComboBox()
        Me.cboPLPeriodFrom = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgPLaccounts = New System.Windows.Forms.DataGridView()
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPLAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPLAccType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartOfAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCoA = New IncomeExpenditure.dsCoA()
        Me.ChartOfAccountsTableAdapter = New IncomeExpenditure.dsCoATableAdapters.ChartOfAccountsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpPlDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.DtpPlDateTo = New System.Windows.Forms.DateTimePicker()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbProfitAndLoss.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgPLaccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvAccountingReports)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbProfitAndLoss)
        Me.SplitContainer1.Size = New System.Drawing.Size(1280, 774)
        Me.SplitContainer1.SplitterDistance = 330
        Me.SplitContainer1.TabIndex = 0
        '
        'tvAccountingReports
        '
        Me.tvAccountingReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvAccountingReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvAccountingReports.Location = New System.Drawing.Point(12, 12)
        Me.tvAccountingReports.Name = "tvAccountingReports"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "ProfitLoss"
        TreeNode2.Name = "CashFlow"
        TreeNode2.Text = "CashFlow"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "BalanceSheet"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Accounting Reports"
        Me.tvAccountingReports.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.tvAccountingReports.Size = New System.Drawing.Size(300, 759)
        Me.tvAccountingReports.TabIndex = 0
        '
        'gbProfitAndLoss
        '
        Me.gbProfitAndLoss.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProfitAndLoss.Controls.Add(Me.chkPLzeroBalances)
        Me.gbProfitAndLoss.Controls.Add(Me.GroupBox2)
        Me.gbProfitAndLoss.Controls.Add(Me.GroupBox1)
        Me.gbProfitAndLoss.Controls.Add(Me.GroupBox5)
        Me.gbProfitAndLoss.Location = New System.Drawing.Point(21, 12)
        Me.gbProfitAndLoss.Name = "gbProfitAndLoss"
        Me.gbProfitAndLoss.Size = New System.Drawing.Size(912, 759)
        Me.gbProfitAndLoss.TabIndex = 50
        Me.gbProfitAndLoss.TabStop = False
        Me.gbProfitAndLoss.Text = "Profit Loss"
        Me.gbProfitAndLoss.Visible = False
        '
        'chkPLzeroBalances
        '
        Me.chkPLzeroBalances.AutoSize = True
        Me.chkPLzeroBalances.Location = New System.Drawing.Point(15, 114)
        Me.chkPLzeroBalances.Name = "chkPLzeroBalances"
        Me.chkPLzeroBalances.Size = New System.Drawing.Size(179, 17)
        Me.chkPLzeroBalances.TabIndex = 5
        Me.chkPLzeroBalances.Text = "Display Zero Value Transactions"
        Me.chkPLzeroBalances.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpPlDateTo)
        Me.GroupBox2.Controls.Add(Me.dtpPlDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(874, 39)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Posted Between"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "And:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboPLPeriodTo)
        Me.GroupBox1.Controls.Add(Me.cboPLPeriodFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(874, 49)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periods Between"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "And:"
        '
        'cboPLPeriodTo
        '
        Me.cboPLPeriodTo.FormattingEnabled = True
        Me.cboPLPeriodTo.Location = New System.Drawing.Point(488, 14)
        Me.cboPLPeriodTo.Name = "cboPLPeriodTo"
        Me.cboPLPeriodTo.Size = New System.Drawing.Size(368, 21)
        Me.cboPLPeriodTo.TabIndex = 2
        '
        'cboPLPeriodFrom
        '
        Me.cboPLPeriodFrom.FormattingEnabled = True
        Me.cboPLPeriodFrom.Location = New System.Drawing.Point(45, 14)
        Me.cboPLPeriodFrom.Name = "cboPLPeriodFrom"
        Me.cboPLPeriodFrom.Size = New System.Drawing.Size(368, 21)
        Me.cboPLPeriodFrom.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.dgPLaccounts)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(865, 606)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Relevent Accounts"
        '
        'dgPLaccounts
        '
        Me.dgPLaccounts.AllowUserToAddRows = False
        Me.dgPLaccounts.AllowUserToDeleteRows = False
        Me.dgPLaccounts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPLaccounts.AutoGenerateColumns = False
        Me.dgPLaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPLaccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.DescriptionDataGridViewTextBoxColumn1, Me.colPLAccount, Me.colPLAccType, Me.CurrencyDataGridViewTextBoxColumn1})
        Me.dgPLaccounts.DataSource = Me.ChartOfAccountsBindingSource
        Me.dgPLaccounts.Location = New System.Drawing.Point(15, 19)
        Me.dgPLaccounts.Name = "dgPLaccounts"
        Me.dgPLaccounts.Size = New System.Drawing.Size(847, 581)
        Me.dgPLaccounts.TabIndex = 2
        '
        'chkSelect
        '
        Me.chkSelect.HeaderText = "Select"
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        Me.DescriptionDataGridViewTextBoxColumn1.Width = 250
        '
        'colPLAccount
        '
        Me.colPLAccount.DataPropertyName = "AccountNumber"
        Me.colPLAccount.HeaderText = "AccountNumber"
        Me.colPLAccount.Name = "colPLAccount"
        Me.colPLAccount.Width = 150
        '
        'colPLAccType
        '
        Me.colPLAccType.DataPropertyName = "AccType"
        Me.colPLAccType.HeaderText = "AccType"
        Me.colPLAccType.Name = "colPLAccType"
        '
        'CurrencyDataGridViewTextBoxColumn1
        '
        Me.CurrencyDataGridViewTextBoxColumn1.DataPropertyName = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn1.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn1.Name = "CurrencyDataGridViewTextBoxColumn1"
        '
        'ChartOfAccountsBindingSource
        '
        Me.ChartOfAccountsBindingSource.DataMember = "ChartOfAccounts"
        Me.ChartOfAccountsBindingSource.DataSource = Me.DsCoA
        '
        'DsCoA
        '
        Me.DsCoA.DataSetName = "dsCoA"
        Me.DsCoA.EnforceConstraints = False
        Me.DsCoA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartOfAccountsTableAdapter
        '
        Me.ChartOfAccountsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(936, 780)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1111, 780)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpPlDateFrom
        '
        Me.dtpPlDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPlDateFrom.Location = New System.Drawing.Point(45, 15)
        Me.dtpPlDateFrom.Name = "dtpPlDateFrom"
        Me.dtpPlDateFrom.Size = New System.Drawing.Size(368, 20)
        Me.dtpPlDateFrom.TabIndex = 7
        '
        'DtpPlDateTo
        '
        Me.DtpPlDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPlDateTo.Location = New System.Drawing.Point(488, 11)
        Me.DtpPlDateTo.Name = "DtpPlDateTo"
        Me.DtpPlDateTo.Size = New System.Drawing.Size(368, 20)
        Me.DtpPlDateTo.TabIndex = 8
        '
        'frmAccountingReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 832)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmAccountingReports"
        Me.Text = "frmAccountingReports"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbProfitAndLoss.ResumeLayout(False)
        Me.gbProfitAndLoss.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgPLaccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartOfAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents tvAccountingReports As TreeView
    Friend WithEvents gbProfitAndLoss As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DsCoA As dsCoA
    Friend WithEvents ChartOfAccountsBindingSource As BindingSource
    Friend WithEvents ChartOfAccountsTableAdapter As dsCoATableAdapters.ChartOfAccountsTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPLPeriodTo As ComboBox
    Friend WithEvents cboPLPeriodFrom As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgPLaccounts As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chkSelect As DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents colPLAccount As DataGridViewTextBoxColumn
    Friend WithEvents colPLAccType As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents chkPLzeroBalances As CheckBox
    Friend WithEvents DtpPlDateTo As DateTimePicker
    Friend WithEvents dtpPlDateFrom As DateTimePicker
End Class
