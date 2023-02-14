<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsPreview
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GLStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCoA = New IncomeExpenditure.dsCoA()
        Me.GLStatementTableAdapter = New IncomeExpenditure.dsCoATableAdapters.GLStatementTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 375)
        Me.Panel1.TabIndex = 0
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GLStatementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IncomeExpenditure.rptProfitLoss.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(88, 18)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(622, 389)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
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
        'GLStatementTableAdapter
        '
        Me.GLStatementTableAdapter.ClearBeforeFill = True
        '
        'frmReportsPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReportsPreview"
        Me.Text = "frmReportsPreview"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GLStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents GLStatementBindingSource As Windows.Forms.BindingSource
    Friend WithEvents dsCoA As dsCoA
    Friend WithEvents GLStatementTableAdapter As dsCoATableAdapters.GLStatementTableAdapter
End Class
