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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TcStudProfile = New System.Windows.Forms.TabControl()
        Me.tbExms = New System.Windows.Forms.TabPage()
        Me.tbFess = New System.Windows.Forms.TabPage()
        Me.tbBehavior = New System.Windows.Forms.TabPage()
        Me.pnlStudDetails = New System.Windows.Forms.Panel()
        Me.imgStudDetails = New System.Windows.Forms.PictureBox()
        Me.lbStudDetails = New System.Windows.Forms.ListBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TcStudProfile.SuspendLayout()
        Me.pnlStudDetails.SuspendLayout()
        CType(Me.imgStudDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1154, 849)
        Me.SplitContainer1.SplitterDistance = 353
        Me.SplitContainer1.TabIndex = 0
        '
        'TcStudProfile
        '
        Me.TcStudProfile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TcStudProfile.Controls.Add(Me.tbExms)
        Me.TcStudProfile.Controls.Add(Me.tbFess)
        Me.TcStudProfile.Controls.Add(Me.tbBehavior)
        Me.TcStudProfile.Location = New System.Drawing.Point(12, 29)
        Me.TcStudProfile.Name = "TcStudProfile"
        Me.TcStudProfile.SelectedIndex = 0
        Me.TcStudProfile.Size = New System.Drawing.Size(1118, 451)
        Me.TcStudProfile.TabIndex = 0
        '
        'tbExms
        '
        Me.tbExms.Location = New System.Drawing.Point(4, 22)
        Me.tbExms.Name = "tbExms"
        Me.tbExms.Padding = New System.Windows.Forms.Padding(3)
        Me.tbExms.Size = New System.Drawing.Size(1110, 425)
        Me.tbExms.TabIndex = 0
        Me.tbExms.Text = "Exams"
        Me.tbExms.UseVisualStyleBackColor = True
        '
        'tbFess
        '
        Me.tbFess.Location = New System.Drawing.Point(4, 22)
        Me.tbFess.Name = "tbFess"
        Me.tbFess.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFess.Size = New System.Drawing.Size(1110, 425)
        Me.tbFess.TabIndex = 1
        Me.tbFess.Text = "Fees Payments"
        Me.tbFess.UseVisualStyleBackColor = True
        '
        'tbBehavior
        '
        Me.tbBehavior.Location = New System.Drawing.Point(4, 22)
        Me.tbBehavior.Name = "tbBehavior"
        Me.tbBehavior.Padding = New System.Windows.Forms.Padding(3)
        Me.tbBehavior.Size = New System.Drawing.Size(1110, 425)
        Me.tbBehavior.TabIndex = 2
        Me.tbBehavior.Text = "Behavior"
        Me.tbBehavior.UseVisualStyleBackColor = True
        '
        'pnlStudDetails
        '
        Me.pnlStudDetails.Controls.Add(Me.lbStudDetails)
        Me.pnlStudDetails.Controls.Add(Me.imgStudDetails)
        Me.pnlStudDetails.Location = New System.Drawing.Point(14, 14)
        Me.pnlStudDetails.Name = "pnlStudDetails"
        Me.pnlStudDetails.Size = New System.Drawing.Size(1127, 329)
        Me.pnlStudDetails.TabIndex = 0
        '
        'imgStudDetails
        '
        Me.imgStudDetails.Location = New System.Drawing.Point(38, 38)
        Me.imgStudDetails.Name = "imgStudDetails"
        Me.imgStudDetails.Size = New System.Drawing.Size(270, 220)
        Me.imgStudDetails.TabIndex = 0
        Me.imgStudDetails.TabStop = False
        '
        'lbStudDetails
        '
        Me.lbStudDetails.FormattingEnabled = True
        Me.lbStudDetails.Location = New System.Drawing.Point(372, 38)
        Me.lbStudDetails.Name = "lbStudDetails"
        Me.lbStudDetails.Size = New System.Drawing.Size(456, 225)
        Me.lbStudDetails.TabIndex = 1
        '
        'frmStudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 849)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentProfile"
        Me.TopMost = True
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TcStudProfile.ResumeLayout(False)
        Me.pnlStudDetails.ResumeLayout(False)
        CType(Me.imgStudDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents pnlStudDetails As Windows.Forms.Panel
    Friend WithEvents lbStudDetails As Windows.Forms.ListBox
    Friend WithEvents imgStudDetails As Windows.Forms.PictureBox
    Friend WithEvents TcStudProfile As Windows.Forms.TabControl
    Friend WithEvents tbExms As Windows.Forms.TabPage
    Friend WithEvents tbFess As Windows.Forms.TabPage
    Friend WithEvents tbBehavior As Windows.Forms.TabPage
End Class
