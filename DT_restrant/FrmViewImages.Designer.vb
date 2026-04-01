<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewImages
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewImages))
        Me.PicBoxViewImages = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxViewImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBoxViewImages
        '
        Me.PicBoxViewImages.BackColor = System.Drawing.Color.LightSlateGray
        Me.PicBoxViewImages.Location = New System.Drawing.Point(4, 3)
        Me.PicBoxViewImages.Name = "PicBoxViewImages"
        Me.PicBoxViewImages.Size = New System.Drawing.Size(709, 647)
        Me.PicBoxViewImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBoxViewImages.TabIndex = 0
        Me.PicBoxViewImages.TabStop = False
        '
        'FrmViewImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 655)
        Me.Controls.Add(Me.PicBoxViewImages)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmViewImages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmViewImages"
        CType(Me.PicBoxViewImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicBoxViewImages As System.Windows.Forms.PictureBox
End Class
