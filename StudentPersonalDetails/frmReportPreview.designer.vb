<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.rvStudCheckList = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvFeesStatement = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvBookInfo = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvIssueForm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvStaffProfile = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvClassStudents = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvStudFeesStatement = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvStudDetails = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvEnrolForm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvFeesInoice = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rvFeesReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BookIssueFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsSchool = New StudentPersonalDetails.dsSchool()
        Me.ClassListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintFeesReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassListTableAdapter = New StudentPersonalDetails.dsSchoolTableAdapters.ClassListTableAdapter()
        Me.PrintFeesReceiptTableAdapter = New StudentPersonalDetails.dsSchoolTableAdapters.PrintFeesReceiptTableAdapter()
        Me.BookIssueFormTableAdapter = New StudentPersonalDetails.dsSchoolTableAdapters.BookIssueFormTableAdapter()
        Me.rvBokkReturnForm = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PnlMain.SuspendLayout()
        CType(Me.BookIssueFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintFeesReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMain
        '
        Me.PnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlMain.Controls.Add(Me.rvBokkReturnForm)
        Me.PnlMain.Controls.Add(Me.rvStudCheckList)
        Me.PnlMain.Controls.Add(Me.rvFeesStatement)
        Me.PnlMain.Controls.Add(Me.rvBookInfo)
        Me.PnlMain.Controls.Add(Me.rvIssueForm)
        Me.PnlMain.Controls.Add(Me.rvStaffProfile)
        Me.PnlMain.Controls.Add(Me.rvClassStudents)
        Me.PnlMain.Controls.Add(Me.rvStudFeesStatement)
        Me.PnlMain.Controls.Add(Me.rvStudDetails)
        Me.PnlMain.Controls.Add(Me.rvEnrolForm)
        Me.PnlMain.Controls.Add(Me.rvFeesInoice)
        Me.PnlMain.Controls.Add(Me.rvFeesReceipt)
        Me.PnlMain.Location = New System.Drawing.Point(22, 60)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(497, 338)
        Me.PnlMain.TabIndex = 7
        '
        'rvStudCheckList
        '
        Me.rvStudCheckList.DocumentMapWidth = 74
        Me.rvStudCheckList.LocalReport.ReportEmbeddedResource = "SMS.rptBookTag.rdlc"
        Me.rvStudCheckList.Location = New System.Drawing.Point(232, 236)
        Me.rvStudCheckList.Name = "rvStudCheckList"
        Me.rvStudCheckList.ServerReport.BearerToken = Nothing
        Me.rvStudCheckList.Size = New System.Drawing.Size(76, 63)
        Me.rvStudCheckList.TabIndex = 37
        Me.rvStudCheckList.Visible = False
        '
        'rvFeesStatement
        '
        Me.rvFeesStatement.DocumentMapWidth = 74
        Me.rvFeesStatement.LocalReport.ReportEmbeddedResource = "SMS.rptStudStatementOfAcc.rdlc"
        Me.rvFeesStatement.Location = New System.Drawing.Point(41, 236)
        Me.rvFeesStatement.Name = "rvFeesStatement"
        Me.rvFeesStatement.ServerReport.BearerToken = Nothing
        Me.rvFeesStatement.Size = New System.Drawing.Size(76, 63)
        Me.rvFeesStatement.TabIndex = 36
        Me.rvFeesStatement.Visible = False
        '
        'rvBookInfo
        '
        Me.rvBookInfo.DocumentMapWidth = 74
        Me.rvBookInfo.LocalReport.ReportEmbeddedResource = "SMS.rptBookTag.rdlc"
        Me.rvBookInfo.Location = New System.Drawing.Point(418, 82)
        Me.rvBookInfo.Name = "rvBookInfo"
        Me.rvBookInfo.ServerReport.BearerToken = Nothing
        Me.rvBookInfo.Size = New System.Drawing.Size(76, 63)
        Me.rvBookInfo.TabIndex = 35
        Me.rvBookInfo.Visible = False
        '
        'rvIssueForm
        '
        Me.rvIssueForm.DocumentMapWidth = 74
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.BookIssueFormBindingSource
        Me.rvIssueForm.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvIssueForm.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptIssueForm.rdlc"
        Me.rvIssueForm.Location = New System.Drawing.Point(123, 179)
        Me.rvIssueForm.Name = "rvIssueForm"
        Me.rvIssueForm.ServerReport.BearerToken = Nothing
        Me.rvIssueForm.Size = New System.Drawing.Size(76, 63)
        Me.rvIssueForm.TabIndex = 34
        Me.rvIssueForm.Visible = False
        '
        'rvStaffProfile
        '
        Me.rvStaffProfile.DocumentMapWidth = 74
        Me.rvStaffProfile.Location = New System.Drawing.Point(132, 82)
        Me.rvStaffProfile.Name = "rvStaffProfile"
        Me.rvStaffProfile.ServerReport.BearerToken = Nothing
        Me.rvStaffProfile.Size = New System.Drawing.Size(76, 63)
        Me.rvStaffProfile.TabIndex = 33
        Me.rvStaffProfile.Visible = False
        '
        'rvClassStudents
        '
        Me.rvClassStudents.DocumentMapWidth = 74
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.ClassListBindingSource
        Me.rvClassStudents.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rvClassStudents.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptStudentClasses.rdlc"
        Me.rvClassStudents.Location = New System.Drawing.Point(340, 138)
        Me.rvClassStudents.Name = "rvClassStudents"
        Me.rvClassStudents.ServerReport.BearerToken = Nothing
        Me.rvClassStudents.Size = New System.Drawing.Size(76, 63)
        Me.rvClassStudents.TabIndex = 32
        Me.rvClassStudents.Visible = False
        '
        'rvStudFeesStatement
        '
        Me.rvStudFeesStatement.DocumentMapWidth = 74
        Me.rvStudFeesStatement.Location = New System.Drawing.Point(41, 138)
        Me.rvStudFeesStatement.Name = "rvStudFeesStatement"
        Me.rvStudFeesStatement.ServerReport.BearerToken = Nothing
        Me.rvStudFeesStatement.Size = New System.Drawing.Size(76, 63)
        Me.rvStudFeesStatement.TabIndex = 31
        Me.rvStudFeesStatement.Visible = False
        '
        'rvStudDetails
        '
        Me.rvStudDetails.DocumentMapWidth = 74
        ReportDataSource4.Value = Nothing
        Me.rvStudDetails.LocalReport.DataSources.Add(ReportDataSource4)
        Me.rvStudDetails.LocalReport.ReportEmbeddedResource = "SMS.rptStudDetails.rdlc"
        Me.rvStudDetails.Location = New System.Drawing.Point(210, 138)
        Me.rvStudDetails.Name = "rvStudDetails"
        Me.rvStudDetails.ServerReport.BearerToken = Nothing
        Me.rvStudDetails.Size = New System.Drawing.Size(76, 63)
        Me.rvStudDetails.TabIndex = 30
        Me.rvStudDetails.Visible = False
        '
        'rvEnrolForm
        '
        Me.rvEnrolForm.DocumentMapWidth = 74
        ReportDataSource5.Value = Nothing
        Me.rvEnrolForm.LocalReport.DataSources.Add(ReportDataSource5)
        Me.rvEnrolForm.LocalReport.ReportEmbeddedResource = "SMS.rptEnrollmenForm.rdlc"
        Me.rvEnrolForm.Location = New System.Drawing.Point(340, 38)
        Me.rvEnrolForm.Name = "rvEnrolForm"
        Me.rvEnrolForm.ServerReport.BearerToken = Nothing
        Me.rvEnrolForm.Size = New System.Drawing.Size(76, 63)
        Me.rvEnrolForm.TabIndex = 29
        Me.rvEnrolForm.Visible = False
        '
        'rvFeesInoice
        '
        Me.rvFeesInoice.DocumentMapWidth = 74
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.PrintFeesReceiptBindingSource
        Me.rvFeesInoice.LocalReport.DataSources.Add(ReportDataSource6)
        Me.rvFeesInoice.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptFeesInvoice.rdlc"
        Me.rvFeesInoice.Location = New System.Drawing.Point(214, 38)
        Me.rvFeesInoice.Name = "rvFeesInoice"
        Me.rvFeesInoice.ServerReport.BearerToken = Nothing
        Me.rvFeesInoice.Size = New System.Drawing.Size(76, 63)
        Me.rvFeesInoice.TabIndex = 27
        Me.rvFeesInoice.Visible = False
        '
        'rvFeesReceipt
        '
        Me.rvFeesReceipt.DocumentMapWidth = 74
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.PrintFeesReceiptBindingSource
        Me.rvFeesReceipt.LocalReport.DataSources.Add(ReportDataSource7)
        Me.rvFeesReceipt.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptFeesReceipt.rdlc"
        Me.rvFeesReceipt.Location = New System.Drawing.Point(30, 38)
        Me.rvFeesReceipt.Name = "rvFeesReceipt"
        Me.rvFeesReceipt.ServerReport.BearerToken = Nothing
        Me.rvFeesReceipt.Size = New System.Drawing.Size(76, 63)
        Me.rvFeesReceipt.TabIndex = 26
        Me.rvFeesReceipt.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.LightYellow
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(22, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(416, 23)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "<< Preview >>"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(444, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 25)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BookIssueFormBindingSource
        '
        Me.BookIssueFormBindingSource.DataMember = "BookIssueForm"
        Me.BookIssueFormBindingSource.DataSource = Me.dsSchool
        '
        'dsSchool
        '
        Me.dsSchool.DataSetName = "dsSchool"
        Me.dsSchool.EnforceConstraints = False
        Me.dsSchool.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassListBindingSource
        '
        Me.ClassListBindingSource.DataMember = "ClassList"
        Me.ClassListBindingSource.DataSource = Me.dsSchool
        '
        'PrintFeesReceiptBindingSource
        '
        Me.PrintFeesReceiptBindingSource.DataMember = "PrintFeesReceipt"
        Me.PrintFeesReceiptBindingSource.DataSource = Me.dsSchool
        '
        'ClassListTableAdapter
        '
        Me.ClassListTableAdapter.ClearBeforeFill = True
        '
        'PrintFeesReceiptTableAdapter
        '
        Me.PrintFeesReceiptTableAdapter.ClearBeforeFill = True
        '
        'BookIssueFormTableAdapter
        '
        Me.BookIssueFormTableAdapter.ClearBeforeFill = True
        '
        'rvBokkReturnForm
        '
        Me.rvBokkReturnForm.DocumentMapWidth = 74
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BookIssueFormBindingSource
        Me.rvBokkReturnForm.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvBokkReturnForm.LocalReport.ReportEmbeddedResource = "StudentPersonalDetails.rptReturnForm.rdlc"
        Me.rvBokkReturnForm.Location = New System.Drawing.Point(360, 236)
        Me.rvBokkReturnForm.Name = "rvBokkReturnForm"
        Me.rvBokkReturnForm.ServerReport.BearerToken = Nothing
        Me.rvBokkReturnForm.Size = New System.Drawing.Size(76, 63)
        Me.rvBokkReturnForm.TabIndex = 38
        Me.rvBokkReturnForm.Visible = False
        '
        'frmReportPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(540, 414)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReportPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportPreview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PnlMain.ResumeLayout(False)
        CType(Me.BookIssueFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsSchool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintFeesReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rvFeesReceipt As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvFeesInoice As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rvEnrolForm As Microsoft.Reporting.WinForms.ReportViewer




    Friend WithEvents rvStudDetails As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvStudFeesStatement As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvClassStudents As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvStaffProfile As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvIssueForm As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassListTableAdapter As dsSchoolTableAdapters.ClassListTableAdapter
    Friend WithEvents dsSchool As dsSchool
    Friend WithEvents rvBookInfo As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClassListBindingSource As Windows.Forms.BindingSource
    Friend WithEvents rvFeesStatement As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents rvStudCheckList As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrintFeesReceiptBindingSource As Windows.Forms.BindingSource
    Friend WithEvents PrintFeesReceiptTableAdapter As dsSchoolTableAdapters.PrintFeesReceiptTableAdapter
    Friend WithEvents BookIssueFormBindingSource As Windows.Forms.BindingSource
    Friend WithEvents BookIssueFormTableAdapter As dsSchoolTableAdapters.BookIssueFormTableAdapter
    Friend WithEvents rvBokkReturnForm As Microsoft.Reporting.WinForms.ReportViewer
End Class
