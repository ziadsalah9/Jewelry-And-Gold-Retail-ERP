<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class licen_key
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(licen_key))
        Me.tetlicen_key = New System.Windows.Forms.TextBox()
        Me.btnWhatsApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tetlicen_key
        '
        Me.tetlicen_key.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tetlicen_key.Location = New System.Drawing.Point(1, 2)
        Me.tetlicen_key.Name = "tetlicen_key"
        Me.tetlicen_key.Size = New System.Drawing.Size(833, 37)
        Me.tetlicen_key.TabIndex = 0
        Me.tetlicen_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnWhatsApp
        '
        Me.btnWhatsApp.BackColor = System.Drawing.Color.White
        Me.btnWhatsApp.BackgroundImage = Global.DT_restrant.My.Resources.Resources.WhatsApp
        Me.btnWhatsApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWhatsApp.Location = New System.Drawing.Point(835, 2)
        Me.btnWhatsApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWhatsApp.Name = "btnWhatsApp"
        Me.btnWhatsApp.Size = New System.Drawing.Size(41, 37)
        Me.btnWhatsApp.TabIndex = 153
        Me.btnWhatsApp.UseVisualStyleBackColor = False
        '
        'licen_key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(878, 42)
        Me.Controls.Add(Me.btnWhatsApp)
        Me.Controls.Add(Me.tetlicen_key)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "licen_key"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "licen_key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tetlicen_key As System.Windows.Forms.TextBox
    Friend WithEvents btnWhatsApp As System.Windows.Forms.Button
End Class
