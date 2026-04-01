<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectColor))
        Me.BtnSetBackColor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSetBackColor
        '
        Me.BtnSetBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSetBackColor.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetBackColor.Location = New System.Drawing.Point(8, 12)
        Me.BtnSetBackColor.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.BtnSetBackColor.Name = "BtnSetBackColor"
        Me.BtnSetBackColor.Size = New System.Drawing.Size(288, 84)
        Me.BtnSetBackColor.TabIndex = 0
        Me.BtnSetBackColor.Text = "SetBackColor"
        Me.BtnSetBackColor.UseVisualStyleBackColor = True
        '
        'FrmSelectColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 101)
        Me.Controls.Add(Me.BtnSetBackColor)
        Me.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelectColor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSelectColor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSetBackColor As System.Windows.Forms.Button
End Class
