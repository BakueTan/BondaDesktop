<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvUpload
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboInvupCart = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboInvupFrm = New System.Windows.Forms.ComboBox()
        Me.cboInvupprog = New System.Windows.Forms.ComboBox()
        Me.cboInvUpClas = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(101, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cartegory"
        '
        'cboInvupCart
        '
        Me.cboInvupCart.DisplayMember = "Payment"
        Me.cboInvupCart.FormattingEnabled = True
        Me.cboInvupCart.Location = New System.Drawing.Point(121, 124)
        Me.cboInvupCart.Name = "cboInvupCart"
        Me.cboInvupCart.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupCart.TabIndex = 21
        Me.cboInvupCart.ValueMember = "Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Program:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Class:"
        '
        'cboInvupFrm
        '
        Me.cboInvupFrm.DisplayMember = "Forms"
        Me.cboInvupFrm.FormattingEnabled = True
        Me.cboInvupFrm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboInvupFrm.Location = New System.Drawing.Point(121, 97)
        Me.cboInvupFrm.Name = "cboInvupFrm"
        Me.cboInvupFrm.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupFrm.TabIndex = 16
        Me.cboInvupFrm.ValueMember = "Forms"
        '
        'cboInvupprog
        '
        Me.cboInvupprog.DisplayMember = "Forms"
        Me.cboInvupprog.FormattingEnabled = True
        Me.cboInvupprog.Location = New System.Drawing.Point(121, 70)
        Me.cboInvupprog.Name = "cboInvupprog"
        Me.cboInvupprog.Size = New System.Drawing.Size(121, 21)
        Me.cboInvupprog.TabIndex = 14
        Me.cboInvupprog.ValueMember = "Forms"
        '
        'cboInvUpClas
        '
        Me.cboInvUpClas.FormattingEnabled = True
        Me.cboInvUpClas.Location = New System.Drawing.Point(121, 43)
        Me.cboInvUpClas.Name = "cboInvUpClas"
        Me.cboInvUpClas.Size = New System.Drawing.Size(121, 21)
        Me.cboInvUpClas.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmInvUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboInvupCart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboInvupFrm)
        Me.Controls.Add(Me.cboInvupprog)
        Me.Controls.Add(Me.cboInvUpClas)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmInvUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upload Invoices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboInvupCart As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboInvupFrm As System.Windows.Forms.ComboBox
    Friend WithEvents cboInvupprog As System.Windows.Forms.ComboBox
    Friend WithEvents cboInvUpClas As System.Windows.Forms.ComboBox
    '    Friend WithEvents DsStudentSearches As SMS.dsStudentSearches
    '  Friend WithEvents PaymentTypeBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents PaymentTypeTableAdapter As SMS.dsStudentSearchesTableAdapters.PaymentTypeTableAdapter
    '  Friend WithEvents FormsBindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents FormsTableAdapter As SMS.dsStudentSearchesTableAdapters.formsTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    '   Friend WithEvents SchoolDataSet As SMS.schoolDataSet
    '  Friend WithEvents PaymentType1BindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents PaymentType1TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType1TableAdapter
    '  Friend WithEvents PaymentType2BindingSource As System.Windows.Forms.BindingSource
    '   Friend WithEvents PaymentType2TableAdapter As SMS.schoolDataSetTableAdapters.PaymentType2TableAdapter
End Class
