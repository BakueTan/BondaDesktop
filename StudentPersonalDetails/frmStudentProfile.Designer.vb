<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentProfile
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentProfile))
        Me.StudentAcademicReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSchool = New StudentPersonalDetails.dsSchool()
        Me.StudBehaviorReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlStudDetails = New System.Windows.Forms.Panel()
        Me.lbStudName = New System.Windows.Forms.Label()
        Me.lbStudDetails = New System.Windows.Forms.ListBox()
        Me.imgStudDetails = New System.Windows.Forms.PictureBox()
        Me.TcStudProfile = New System.Windows.Forms.TabControl()
        Me.tbEnrollmentHistory = New System.Windows.Forms.TabPage()
        Me.tvEnrollemtHistory = New System.Windows.Forms.TreeView()
        Me.tbExms = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgProfileExams = New System.Windows.Forms.DataGridView()
        Me.colExam = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.colClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProgram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbSubjects = New System.Windows.Forms.TabPage()
        Me.tvSubAnalysis = New System.Windows.Forms.TreeView()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbBehavior = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dgStudBehaviorClasses = New System.Windows.Forms.DataGridView()
        Me.colBehaviorCLass = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TbSchoolFees = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbStudPeriods = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StudentAcademicReportTableAdapter = New StudentPersonalDetails.dsSchoolTableAdapters.StudentAcademicReportTableAdapter()
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudBehaviorReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlStudDetails.SuspendLayout()
        CType(Me.imgStudDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcStudProfile.SuspendLayout()
        Me.tbEnrollmentHistory.SuspendLayout()
        Me.tbExms.SuspendLayout()
        CType(Me.dgProfileExams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSubjects.SuspendLayout()
        Me.tbBehavior.SuspendLayout()
        CType(Me.dgStudBehaviorClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbSchoolFees.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentAcademicReportBindingSource
        '
        Me.StudentAcademicReportBindingSource.DataMember = "StudentAcademicReport"
        Me.StudentAcademicReportBindingSource.DataSource = Me.DsSchool
        '
        'DsSchool
        '
        Me.DsSchool.DataSetName = "dsSchool"
        Me.DsSchool.EnforceConstraints = False
        Me.DsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudBehaviorReportBindingSource
        '
        Me.StudBehaviorReportBindingSource.DataMember = "StudBehaviorReport"
        Me.StudBehaviorReportBindingSource.DataSource = Me.DsSchool
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlStudDetails)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TcStudProfile)
        Me.SplitContainer1.Size = New System.Drawing.Size(1154, 819)
        Me.SplitContainer1.SplitterDistance = 268
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlStudDetails
        '
        Me.pnlStudDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStudDetails.Controls.Add(Me.lbStudName)
        Me.pnlStudDetails.Controls.Add(Me.lbStudDetails)
        Me.pnlStudDetails.Controls.Add(Me.imgStudDetails)
        Me.pnlStudDetails.Location = New System.Drawing.Point(14, 14)
        Me.pnlStudDetails.Name = "pnlStudDetails"
        Me.pnlStudDetails.Size = New System.Drawing.Size(1117, 250)
        Me.pnlStudDetails.TabIndex = 0
        '
        'lbStudName
        '
        Me.lbStudName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbStudName.AutoSize = True
        Me.lbStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStudName.Location = New System.Drawing.Point(4, 226)
        Me.lbStudName.Name = "lbStudName"
        Me.lbStudName.Size = New System.Drawing.Size(63, 20)
        Me.lbStudName.TabIndex = 2
        Me.lbStudName.Text = "Label1"
        '
        'lbStudDetails
        '
        Me.lbStudDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbStudDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbStudDetails.FormattingEnabled = True
        Me.lbStudDetails.Location = New System.Drawing.Point(245, 3)
        Me.lbStudDetails.Name = "lbStudDetails"
        Me.lbStudDetails.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbStudDetails.Size = New System.Drawing.Size(858, 221)
        Me.lbStudDetails.TabIndex = 1
        '
        'imgStudDetails
        '
        Me.imgStudDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgStudDetails.Image = Global.StudentPersonalDetails.My.Resources.Resources.noImage
        Me.imgStudDetails.Location = New System.Drawing.Point(3, 3)
        Me.imgStudDetails.Name = "imgStudDetails"
        Me.imgStudDetails.Size = New System.Drawing.Size(246, 220)
        Me.imgStudDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgStudDetails.TabIndex = 0
        Me.imgStudDetails.TabStop = False
        '
        'TcStudProfile
        '
        Me.TcStudProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TcStudProfile.Controls.Add(Me.tbEnrollmentHistory)
        Me.TcStudProfile.Controls.Add(Me.tbExms)
        Me.TcStudProfile.Controls.Add(Me.tbSubjects)
        Me.TcStudProfile.Controls.Add(Me.tbBehavior)
        Me.TcStudProfile.Controls.Add(Me.TbSchoolFees)
        Me.TcStudProfile.Location = New System.Drawing.Point(12, 3)
        Me.TcStudProfile.Name = "TcStudProfile"
        Me.TcStudProfile.SelectedIndex = 0
        Me.TcStudProfile.Size = New System.Drawing.Size(1139, 537)
        Me.TcStudProfile.TabIndex = 0
        '
        'tbEnrollmentHistory
        '
        Me.tbEnrollmentHistory.BackColor = System.Drawing.Color.Transparent
        Me.tbEnrollmentHistory.Controls.Add(Me.tvEnrollemtHistory)
        Me.tbEnrollmentHistory.ForeColor = System.Drawing.Color.Black
        Me.tbEnrollmentHistory.Location = New System.Drawing.Point(4, 22)
        Me.tbEnrollmentHistory.Name = "tbEnrollmentHistory"
        Me.tbEnrollmentHistory.Size = New System.Drawing.Size(1131, 511)
        Me.tbEnrollmentHistory.TabIndex = 4
        Me.tbEnrollmentHistory.Text = "EnrollmentHistory"
        '
        'tvEnrollemtHistory
        '
        Me.tvEnrollemtHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvEnrollemtHistory.Location = New System.Drawing.Point(3, 3)
        Me.tvEnrollemtHistory.Name = "tvEnrollemtHistory"
        Me.tvEnrollemtHistory.Size = New System.Drawing.Size(241, 505)
        Me.tvEnrollemtHistory.TabIndex = 2
        '
        'tbExms
        '
        Me.tbExms.Controls.Add(Me.ReportViewer1)
        Me.tbExms.Controls.Add(Me.dgProfileExams)
        Me.tbExms.Location = New System.Drawing.Point(4, 22)
        Me.tbExms.Name = "tbExms"
        Me.tbExms.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExms.Size = New System.Drawing.Size(1131, 511)
        Me.tbExms.TabIndex = 0
        Me.tbExms.Text = "AcademicReports"
        Me.tbExms.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.StudentAcademicReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptHsReport_Bonda_Olevel.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(457, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(671, 505)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'dgProfileExams
        '
        Me.dgProfileExams.AllowUserToAddRows = False
        Me.dgProfileExams.AllowUserToDeleteRows = False
        Me.dgProfileExams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgProfileExams.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgProfileExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProfileExams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExam, Me.colClass, Me.colProgram})
        Me.dgProfileExams.Location = New System.Drawing.Point(6, 3)
        Me.dgProfileExams.Name = "dgProfileExams"
        Me.dgProfileExams.ReadOnly = True
        Me.dgProfileExams.Size = New System.Drawing.Size(445, 505)
        Me.dgProfileExams.TabIndex = 0
        '
        'colExam
        '
        Me.colExam.HeaderText = "Exam"
        Me.colExam.Name = "colExam"
        Me.colExam.ReadOnly = True
        Me.colExam.Width = 150
        '
        'colClass
        '
        Me.colClass.HeaderText = "Class"
        Me.colClass.Name = "colClass"
        Me.colClass.ReadOnly = True
        Me.colClass.Width = 150
        '
        'colProgram
        '
        Me.colProgram.HeaderText = "Program"
        Me.colProgram.Name = "colProgram"
        Me.colProgram.ReadOnly = True
        '
        'tbSubjects
        '
        Me.tbSubjects.Controls.Add(Me.tvSubAnalysis)
        Me.tbSubjects.Controls.Add(Me.ReportViewer2)
        Me.tbSubjects.Location = New System.Drawing.Point(4, 22)
        Me.tbSubjects.Name = "tbSubjects"
        Me.tbSubjects.Size = New System.Drawing.Size(1131, 511)
        Me.tbSubjects.TabIndex = 3
        Me.tbSubjects.Text = "AcademicPerfomanceAnalysis"
        Me.tbSubjects.UseVisualStyleBackColor = True
        '
        'tvSubAnalysis
        '
        Me.tvSubAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvSubAnalysis.Location = New System.Drawing.Point(6, 3)
        Me.tvSubAnalysis.Name = "tvSubAnalysis"
        Me.tvSubAnalysis.Size = New System.Drawing.Size(241, 329)
        Me.tvSubAnalysis.TabIndex = 1
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.StudentAcademicReportBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptExamSubjectAnalysis.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(259, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(867, 508)
        Me.ReportViewer2.TabIndex = 0
        '
        'tbBehavior
        '
        Me.tbBehavior.Controls.Add(Me.ReportViewer3)
        Me.tbBehavior.Controls.Add(Me.dgStudBehaviorClasses)
        Me.tbBehavior.Location = New System.Drawing.Point(4, 22)
        Me.tbBehavior.Name = "tbBehavior"
        Me.tbBehavior.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBehavior.Size = New System.Drawing.Size(1131, 511)
        Me.tbBehavior.TabIndex = 2
        Me.tbBehavior.Text = "Behavior"
        Me.tbBehavior.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.StudBehaviorReportBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "StudentDetails.rptStudBehaviorPerTerm.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(248, 7)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(877, 498)
        Me.ReportViewer3.TabIndex = 1
        '
        'dgStudBehaviorClasses
        '
        Me.dgStudBehaviorClasses.AllowUserToAddRows = False
        Me.dgStudBehaviorClasses.AllowUserToDeleteRows = False
        Me.dgStudBehaviorClasses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgStudBehaviorClasses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgStudBehaviorClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudBehaviorClasses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBehaviorCLass})
        Me.dgStudBehaviorClasses.Location = New System.Drawing.Point(4, 7)
        Me.dgStudBehaviorClasses.Name = "dgStudBehaviorClasses"
        Me.dgStudBehaviorClasses.ReadOnly = True
        Me.dgStudBehaviorClasses.Size = New System.Drawing.Size(243, 498)
        Me.dgStudBehaviorClasses.TabIndex = 0
        '
        'colBehaviorCLass
        '
        Me.colBehaviorCLass.HeaderText = "Period"
        Me.colBehaviorCLass.Name = "colBehaviorCLass"
        Me.colBehaviorCLass.ReadOnly = True
        Me.colBehaviorCLass.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBehaviorCLass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBehaviorCLass.Width = 200
        '
        'TbSchoolFees
        '
        Me.TbSchoolFees.Controls.Add(Me.SplitContainer2)
        Me.TbSchoolFees.Location = New System.Drawing.Point(4, 22)
        Me.TbSchoolFees.Name = "TbSchoolFees"
        Me.TbSchoolFees.Padding = New System.Windows.Forms.Padding(3)
        Me.TbSchoolFees.Size = New System.Drawing.Size(1131, 511)
        Me.TbSchoolFees.TabIndex = 5
        Me.TbSchoolFees.Text = "School Fees"
        Me.TbSchoolFees.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1125, 505)
        Me.SplitContainer2.SplitterDistance = 253
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lbStudPeriods)
        Me.SplitContainer3.Size = New System.Drawing.Size(253, 505)
        Me.SplitContainer3.SplitterDistance = 80
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(52, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lbStudPeriods
        '
        Me.lbStudPeriods.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbStudPeriods.FormattingEnabled = True
        Me.lbStudPeriods.Location = New System.Drawing.Point(0, 0)
        Me.lbStudPeriods.Name = "lbStudPeriods"
        Me.lbStudPeriods.Size = New System.Drawing.Size(253, 421)
        Me.lbStudPeriods.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(868, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(860, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "StatementGrid"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(761, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(860, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "StatementReport"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StudentAcademicReportTableAdapter
        '
        Me.StudentAcademicReportTableAdapter.ClearBeforeFill = True
        '
        'frmStudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 823)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmStudentProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentProfile"
        Me.TopMost = True
        CType(Me.StudentAcademicReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSchool, System.ComponentModel.ISupportInitialize).EndInit()
 '       CType(Me.StudBehaviorReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlStudDetails.ResumeLayout(False)
        Me.pnlStudDetails.PerformLayout()
        CType(Me.imgStudDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcStudProfile.ResumeLayout(False)
        Me.tbEnrollmentHistory.ResumeLayout(False)
        Me.tbExms.ResumeLayout(False)
        CType(Me.dgProfileExams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSubjects.ResumeLayout(False)
        Me.tbBehavior.ResumeLayout(False)
        CType(Me.dgStudBehaviorClasses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbSchoolFees.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents pnlStudDetails As Windows.Forms.Panel
    Friend WithEvents lbStudDetails As Windows.Forms.ListBox
    Friend WithEvents imgStudDetails As Windows.Forms.PictureBox
    Friend WithEvents TcStudProfile As Windows.Forms.TabControl
    Friend WithEvents tbExms As Windows.Forms.TabPage
    Friend WithEvents tbBehavior As Windows.Forms.TabPage
    Friend WithEvents lbStudName As Windows.Forms.Label
    Friend WithEvents dgProfileExams As Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StudentAcademicReportBindingSource As Windows.Forms.BindingSource
    Friend WithEvents DsSchool As dsSchool
    Friend WithEvents StudentAcademicReportTableAdapter As dsSchoolTableAdapters.StudentAcademicReportTableAdapter
    Friend WithEvents colExam As Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colClass As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProgram As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbSubjects As Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tvSubAnalysis As Windows.Forms.TreeView
    Friend WithEvents dgStudBehaviorClasses As Windows.Forms.DataGridView
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StudBehaviorReportBindingSource As Windows.Forms.BindingSource
    '   Friend WithEvents StudBehaviorReportTableAdapter As dsSchoolTableAdapters.StudBehaviorReportTableAdapter
    Friend WithEvents colBehaviorCLass As Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents tbEnrollmentHistory As Windows.Forms.TabPage
    Friend WithEvents tvEnrollemtHistory As Windows.Forms.TreeView
    Friend WithEvents TbSchoolFees As Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As Windows.Forms.SplitContainer
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbStudPeriods As Windows.Forms.ListBox
End Class
