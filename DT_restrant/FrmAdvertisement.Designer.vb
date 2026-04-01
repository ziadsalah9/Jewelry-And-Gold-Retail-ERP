<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdvertisement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdvertisement))
        Me.PicAd = New System.Windows.Forms.PictureBox()
        CType(Me.PicAd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicAd
        '
        Me.PicAd.BackgroundImage = Global.DT_restrant.My.Resources.Resources.SAIB_LOGO
        Me.PicAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicAd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicAd.Location = New System.Drawing.Point(0, 0)
        Me.PicAd.Name = "PicAd"
        Me.PicAd.Size = New System.Drawing.Size(763, 833)
        Me.PicAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicAd.TabIndex = 0
        Me.PicAd.TabStop = False
        '
        'FrmAdvertisement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 833)
        Me.Controls.Add(Me.PicAd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdvertisement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advertisement"
        CType(Me.PicAd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicAd As PictureBox
End Class
