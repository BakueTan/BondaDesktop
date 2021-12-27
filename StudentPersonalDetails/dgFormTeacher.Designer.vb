<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dgFormTeacher
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.StudentAcademicReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsSchool = New StudentPersonalDetails.dsSchool()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.rbOneChild = New System.Windows.Forms.RadioButton()
        Me.lbStud = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgStudents = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboFormTeacher = New System.Windows.Forms.ComboBox()
        Me.StudentAcademicReportTableAdapter = New StudentPersonalDetails.dsSchoolTableAdapters.StudentAcademicReportTableAdapter()
        Me.HsExamMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HsExamMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentAcademicReportBindingSource
        '
        Me.StudentAcademicReportBindingSource.DataMember = "StudentAcademicReport"
        Me.StudentAcademicReportBindingSource.DataSource = Me.dsSchool
        '
        'dsSchool
        '
        Me.dsSchool.DataSetName = "dsSchool"
        Me.dsSchool.EnforceConstraints = False
        Me.dsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(834, 592)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(663, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FormTeacher:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Comment:"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(12, 508)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtComment.Size = New System.Drawing.Size(475, 69)
        Me.txtComment.TabIndex = 4
        '
        'rbOneChild
        '
        Me.rbOneChild.AutoSize = True
        Me.rbOneChild.Checked = True
        Me.rbOneChild.Location = New System.Drawing.Point(15, 595)
        Me.rbOneChild.Name = "rbOneChild"
        Me.rbOneChild.Size = New System.Drawing.Size(97, 17)
        Me.rbOneChild.TabIndex = 6
        Me.rbOneChild.TabStop = True
        Me.rbOneChild.Text = "ForThisStudent"
        Me.rbOneChild.UseVisualStyleBackColor = True
        '
        'lbStud
        '
        Me.lbStud.AutoSize = True
        Me.lbStud.Location = New System.Drawing.Point(34, 9)
        Me.lbStud.Name = "lbStud"
        Me.lbStud.Size = New System.Drawing.Size(0, 13)
        Me.lbStud.TabIndex = 8
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.StudentAcademicReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptHsReport_FormTeacher.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 27)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(478, 451)
        Me.ReportViewer1.TabIndex = 9
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'dgStudents
        '
        Me.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgStudents.Location = New System.Drawing.Point(532, 46)
        Me.dgStudents.MultiSelect = False
        Me.dgStudents.Name = "dgStudents"
        Me.dgStudents.ReadOnly = True
        Me.dgStudents.Size = New System.Drawing.Size(432, 531)
        Me.dgStudents.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EnrolRef"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ref"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'cboFormTeacher
        '
        Me.cboFormTeacher.FormattingEnabled = True
        Me.cboFormTeacher.Location = New System.Drawing.Point(742, 19)
        Me.cboFormTeacher.Name = "cboFormTeacher"
        Me.cboFormTeacher.Size = New System.Drawing.Size(222, 21)
        Me.cboFormTeacher.TabIndex = 24
        '
        'StudentAcademicReportTableAdapter
        '
        Me.StudentAcademicReportTableAdapter.ClearBeforeFill = True
        '
        'dgFormTeacher
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(992, 633)
        Me.Controls.Add(Me.cboFormTeacher)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lbStud)
        Me.Controls.Add(Me.rbOneChild)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.dgStudents)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dgFormTeacher"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form Teacher's Comments"
        Me.TopMost = True
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HsExamMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents rbOneChild As System.Windows.Forms.RadioButton
    Friend WithEvents lbStud As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HsExamMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgStudents As Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboFormTeacher As Windows.Forms.ComboBox
    Friend WithEvents StudentAcademicReportBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsSchool As dsSchool
    Friend WithEvents StudentAcademicReportTableAdapter As dsSchoolTableAdapters.StudentAcademicReportTableAdapter
    '  Friend WithEvents dsReports As SMS.dsReports
    '  Friend WithEvents HsExamMarksTableAdapter As SMS.dsReportsTableAdapters.HsExamMarksTableAdapter

End Class
