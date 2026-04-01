<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMerchants
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpMer = New System.Windows.Forms.TabPage()
        Me.TpBang = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpMer)
        Me.TabControl1.Controls.Add(Me.TpBang)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 589)
        Me.TabControl1.TabIndex = 0
        '
        'TpMer
        '
        Me.TpMer.BackColor = System.Drawing.Color.DimGray
        Me.TpMer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpMer.ForeColor = System.Drawing.Color.Maroon
        Me.TpMer.Location = New System.Drawing.Point(4, 28)
        Me.TpMer.Name = "TpMer"
        Me.TpMer.Padding = New System.Windows.Forms.Padding(3)
        Me.TpMer.Size = New System.Drawing.Size(742, 557)
        Me.TpMer.TabIndex = 1
        Me.TpMer.Text = "التجار"
        '
        'TpBang
        '
        Me.TpBang.BackColor = System.Drawing.Color.Silver
        Me.TpBang.Location = New System.Drawing.Point(4, 28)
        Me.TpBang.Name = "TpBang"
        Me.TpBang.Padding = New System.Windows.Forms.Padding(3)
        Me.TpBang.Size = New System.Drawing.Size(742, 557)
        Me.TpBang.TabIndex = 2
        Me.TpBang.Text = "البنوك"
        '
        'frmMerchants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 597)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMerchants"
        Me.Text = "frmMerchants"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpMer As TabPage
    Friend WithEvents TpBang As TabPage
End Class
