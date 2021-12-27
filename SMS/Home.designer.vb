<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDefinedInputsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAdministationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckFeesBalancesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ssMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "home.png")
        Me.ImageList1.Images.SetKeyName(1, "Arrow Right 4.png")
        Me.ImageList1.Images.SetKeyName(2, "Delete.png")
        Me.ImageList1.Images.SetKeyName(3, "Doc Write 2.png")
        Me.ImageList1.Images.SetKeyName(4, "Dollars.png")
        Me.ImageList1.Images.SetKeyName(5, "Exit 2.png")
        Me.ImageList1.Images.SetKeyName(6, "Exit.png")
        Me.ImageList1.Images.SetKeyName(7, "Folder Blue Arrow Down.png")
        Me.ImageList1.Images.SetKeyName(8, "Green Tick 2.png")
        Me.ImageList1.Images.SetKeyName(9, "home.png")
        Me.ImageList1.Images.SetKeyName(10, "License Agreement.png")
        Me.ImageList1.Images.SetKeyName(11, "Light Bulb 2.png")
        Me.ImageList1.Images.SetKeyName(12, "Links 1.png")
        Me.ImageList1.Images.SetKeyName(13, "Links 2.png")
        Me.ImageList1.Images.SetKeyName(14, "System Tools.png")
        Me.ImageList1.Images.SetKeyName(15, "Tutorials.png")
        Me.ImageList1.Images.SetKeyName(16, "Arrow Right 4.png")
        Me.ImageList1.Images.SetKeyName(17, "Man 9.png")
        Me.ImageList1.Images.SetKeyName(18, "Bar Chart Doc.png")
        Me.ImageList1.Images.SetKeyName(19, "Bar Chart.png")
        Me.ImageList1.Images.SetKeyName(20, "Cash Register Closed 1.png")
        Me.ImageList1.Images.SetKeyName(21, "Cash Register Closed 2.png")
        Me.ImageList1.Images.SetKeyName(22, "Cash Register Closed 3.png")
        Me.ImageList1.Images.SetKeyName(23, "Cash Register Open 1.png")
        Me.ImageList1.Images.SetKeyName(24, "Cash Register Open 2.png")
        Me.ImageList1.Images.SetKeyName(25, "Cash Register Open 3.png")
        Me.ImageList1.Images.SetKeyName(26, "Coins.png")
        Me.ImageList1.Images.SetKeyName(27, "Credit Cards.png")
        Me.ImageList1.Images.SetKeyName(28, "Dollars.png")
        Me.ImageList1.Images.SetKeyName(29, "Euros.png")
        Me.ImageList1.Images.SetKeyName(30, "Folder Closed Dollars.png")
        Me.ImageList1.Images.SetKeyName(31, "Folder Closed Euros.png")
        Me.ImageList1.Images.SetKeyName(32, "Folder Closed Pounds.png")
        Me.ImageList1.Images.SetKeyName(33, "Folder Open Dollars.png")
        Me.ImageList1.Images.SetKeyName(34, "Folder Open Euros.png")
        Me.ImageList1.Images.SetKeyName(35, "Folder Open Pounds.png")
        Me.ImageList1.Images.SetKeyName(36, "Line Chart Doc.png")
        Me.ImageList1.Images.SetKeyName(37, "Money.png")
        Me.ImageList1.Images.SetKeyName(38, "Notes.png")
        Me.ImageList1.Images.SetKeyName(39, "Payment 1.png")
        Me.ImageList1.Images.SetKeyName(40, "Pie Chart 1.png")
        Me.ImageList1.Images.SetKeyName(41, "Pie Chart Doc.png")
        Me.ImageList1.Images.SetKeyName(42, "Pounds.png")
        Me.ImageList1.Images.SetKeyName(43, "Antivirus 1.png")
        Me.ImageList1.Images.SetKeyName(44, "Antivirus 2.png")
        Me.ImageList1.Images.SetKeyName(45, "Businessman 1.png")
        Me.ImageList1.Images.SetKeyName(46, "Businessman 2.png")
        Me.ImageList1.Images.SetKeyName(47, "Businessman 3.png")
        Me.ImageList1.Images.SetKeyName(48, "Businessman 4.png")
        Me.ImageList1.Images.SetKeyName(49, "BusinessWoman 4.png")
        Me.ImageList1.Images.SetKeyName(50, "BusinessWoman 5.png")
        Me.ImageList1.Images.SetKeyName(51, "Edit User.png")
        Me.ImageList1.Images.SetKeyName(52, "Help Person 1.png")
        Me.ImageList1.Images.SetKeyName(53, "Help Person 2.png")
        Me.ImageList1.Images.SetKeyName(54, "Help Person 3.png")
        Me.ImageList1.Images.SetKeyName(55, "Man 1.png")
        Me.ImageList1.Images.SetKeyName(56, "Man 2.png")
        Me.ImageList1.Images.SetKeyName(57, "Man 3.png")
        Me.ImageList1.Images.SetKeyName(58, "Man 4.png")
        Me.ImageList1.Images.SetKeyName(59, "Man 5.png")
        Me.ImageList1.Images.SetKeyName(60, "Man 6.png")
        Me.ImageList1.Images.SetKeyName(61, "Man 7.png")
        Me.ImageList1.Images.SetKeyName(62, "Man 8.png")
        Me.ImageList1.Images.SetKeyName(63, "Man 9.png")
        Me.ImageList1.Images.SetKeyName(64, "Man 10.png")
        Me.ImageList1.Images.SetKeyName(65, "Man 11.png")
        Me.ImageList1.Images.SetKeyName(66, "Man 12.png")
        Me.ImageList1.Images.SetKeyName(67, "Man 14.png")
        Me.ImageList1.Images.SetKeyName(68, "Man 15.png")
        Me.ImageList1.Images.SetKeyName(69, "Painter.png")
        Me.ImageList1.Images.SetKeyName(70, "Password Manager.png")
        Me.ImageList1.Images.SetKeyName(71, "Tutorials.png")
        Me.ImageList1.Images.SetKeyName(72, "Woman 1.png")
        Me.ImageList1.Images.SetKeyName(73, "Woman 2.png")
        Me.ImageList1.Images.SetKeyName(74, "Woman 3.png")
        Me.ImageList1.Images.SetKeyName(75, "Woman 4.png")
        Me.ImageList1.Images.SetKeyName(76, "Woman 5.png")
        Me.ImageList1.Images.SetKeyName(77, "Woman 6.png")
        Me.ImageList1.Images.SetKeyName(78, "Woman 7.png")
        Me.ImageList1.Images.SetKeyName(79, "Woman 8.png")
        Me.ImageList1.Images.SetKeyName(80, "Woman 9.png")
        Me.ImageList1.Images.SetKeyName(81, "Copy 1.png")
        Me.ImageList1.Images.SetKeyName(82, "Copy 2.png")
        Me.ImageList1.Images.SetKeyName(83, "Document 1.png")
        Me.ImageList1.Images.SetKeyName(84, "Document 2.png")
        Me.ImageList1.Images.SetKeyName(85, "Document Blank.png")
        Me.ImageList1.Images.SetKeyName(86, "Document Chart Bar.png")
        Me.ImageList1.Images.SetKeyName(87, "Document Chart Line.png")
        Me.ImageList1.Images.SetKeyName(88, "Document Chart Pie.png")
        Me.ImageList1.Images.SetKeyName(89, "Document Invoice Blue 3.png")
        Me.ImageList1.Images.SetKeyName(90, "Document Invoice Pink 2.png")
        Me.ImageList1.Images.SetKeyName(91, "Document Invoice Pink.png")
        Me.ImageList1.Images.SetKeyName(92, "Document New.png")
        Me.ImageList1.Images.SetKeyName(93, "Document Table.png")
        Me.ImageList1.Images.SetKeyName(94, "Document View 2.png")
        Me.ImageList1.Images.SetKeyName(95, "Document View.png")
        Me.ImageList1.Images.SetKeyName(96, "Document.png")
        Me.ImageList1.Images.SetKeyName(97, "Invoice Blue 1.png")
        Me.ImageList1.Images.SetKeyName(98, "Invoice Blue 2.png")
        Me.ImageList1.Images.SetKeyName(99, "Licence Agreement 1.png")
        Me.ImageList1.Images.SetKeyName(100, "Licence Agreement 2.png")
        Me.ImageList1.Images.SetKeyName(101, "Remove All.png")
        Me.ImageList1.Images.SetKeyName(102, "Remove.png")
        Me.ImageList1.Images.SetKeyName(103, "Car Blue.png")
        Me.ImageList1.Images.SetKeyName(104, "Car Soft Top Red.png")
        Me.ImageList1.Images.SetKeyName(105, "Info 2.png")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UserDefinedInputsToolStripMenuItem, Me.AdministrationToolStripMenuItem1, Me.ReportsToolStripMenuItem, Me.ToolStripMenuItem4, Me.StudentsToolStripMenuItem, Me.StaffToolStripMenuItem, Me.UserManualToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1142, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Checked = True
        Me.FileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogIn, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.RevoEdu.My.Resources.Resources.Folder_Blue_Arrow_Down
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.FileToolStripMenuItem.Tag = "1"
        Me.FileToolStripMenuItem.Text = "&System"
        '
        'mnuLogIn
        '
        Me.mnuLogIn.Image = Global.RevoEdu.My.Resources.Resources.Exit_2
        Me.mnuLogIn.Name = "mnuLogIn"
        Me.mnuLogIn.Size = New System.Drawing.Size(107, 22)
        Me.mnuLogIn.Tag = "2"
        Me.mnuLogIn.Text = "Log In"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Tag = "3"
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UserDefinedInputsToolStripMenuItem
        '
        Me.UserDefinedInputsToolStripMenuItem.Image = Global.RevoEdu.My.Resources.Resources.Light_Bulb_2
        Me.UserDefinedInputsToolStripMenuItem.Name = "UserDefinedInputsToolStripMenuItem"
        Me.UserDefinedInputsToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.UserDefinedInputsToolStripMenuItem.Tag = "4"
        Me.UserDefinedInputsToolStripMenuItem.Text = "S&chool Parameters"
        '
        'AdministrationToolStripMenuItem1
        '
        Me.AdministrationToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAdministationToolStripMenuItem})
        Me.AdministrationToolStripMenuItem1.Name = "AdministrationToolStripMenuItem1"
        Me.AdministrationToolStripMenuItem1.Size = New System.Drawing.Size(98, 20)
        Me.AdministrationToolStripMenuItem1.Tag = "5"
        Me.AdministrationToolStripMenuItem1.Text = "Administration"
        '
        'UserAdministationToolStripMenuItem
        '
        Me.UserAdministationToolStripMenuItem.Name = "UserAdministationToolStripMenuItem"
        Me.UserAdministationToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UserAdministationToolStripMenuItem.Tag = "6"
        Me.UserAdministationToolStripMenuItem.Text = "UserAdministation"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsPageToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Tag = "7"
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ReportsPageToolStripMenuItem
        '
        Me.ReportsPageToolStripMenuItem.Name = "ReportsPageToolStripMenuItem"
        Me.ReportsPageToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ReportsPageToolStripMenuItem.Tag = "8"
        Me.ReportsPageToolStripMenuItem.Text = "ReportsPage"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(81, 20)
        Me.ToolStripMenuItem4.Tag = "95"
        Me.ToolStripMenuItem4.Text = "BookCentre"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentDetailsToolStripMenuItem, Me.CheckFeesBalancesToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.StudentsToolStripMenuItem.Tag = "9"
        Me.StudentsToolStripMenuItem.Text = "StudentsCentre"
        '
        'StudentDetailsToolStripMenuItem
        '
        Me.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem"
        Me.StudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.StudentDetailsToolStripMenuItem.Tag = "10"
        Me.StudentDetailsToolStripMenuItem.Text = "Student Details"
        '
        'CheckFeesBalancesToolStripMenuItem
        '
        Me.CheckFeesBalancesToolStripMenuItem.Name = "CheckFeesBalancesToolStripMenuItem"
        Me.CheckFeesBalancesToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CheckFeesBalancesToolStripMenuItem.Text = "CheckFeesBalances"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.UserManualToolStripMenuItem.Enabled = False
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.UserManualToolStripMenuItem.Tag = "84"
        Me.UserManualToolStripMenuItem.Text = "Help"
        '
        'UserManualToolStripMenuItem1
        '
        Me.UserManualToolStripMenuItem1.Name = "UserManualToolStripMenuItem1"
        Me.UserManualToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UserManualToolStripMenuItem1.Tag = "85"
        Me.UserManualToolStripMenuItem1.Text = "UserManual"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Tag = "86"
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1142, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(14, 652)
        Me.Panel2.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.MenuStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1142, 26)
        Me.Panel4.TabIndex = 13
        '
        'ssMain
        '
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.ssMain.Location = New System.Drawing.Point(0, 630)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(1142, 22)
        Me.ssMain.TabIndex = 15
        Me.ssMain.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'StaffDetailsToolStripMenuItem
        '
        Me.StaffDetailsToolStripMenuItem.Name = "StaffDetailsToolStripMenuItem"
        Me.StaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StaffDetailsToolStripMenuItem.Tag = "53"
        Me.StaffDetailsToolStripMenuItem.Text = "StaffDetails"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffDetailsToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.StaffToolStripMenuItem.Tag = "52"
        Me.StaffToolStripMenuItem.Text = "StaffCentre"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1156, 652)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Friend WithEvents StudentFeesTableAdapter As SMS.dsschoolTableAdapters.StudentFeesTableAdapter

    ' Friend WithEvents DatesTableAdapter As SMS.dsSchoolTableAdapters.DatesTableAdapter


    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserDefinedInputsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAdministationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckFeesBalancesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffDetailsToolStripMenuItem As ToolStripMenuItem
End Class
