<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthenticationCivilId
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblText = New System.Windows.Forms.Label()
        Me.BtnAuth = New System.Windows.Forms.Button()
        Me.BtnCloce = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.DT_restrant.My.Resources.Resources.CivilIdAuth
        Me.PictureBox1.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(268, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblText.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(2, 211)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(268, 163)
        Me.lblText.TabIndex = 1
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnAuth
        '
        Me.BtnAuth.BackColor = System.Drawing.Color.Lime
        Me.BtnAuth.ForeColor = System.Drawing.Color.Black
        Me.BtnAuth.Location = New System.Drawing.Point(137, 377)
        Me.BtnAuth.Name = "BtnAuth"
        Me.BtnAuth.Size = New System.Drawing.Size(133, 49)
        Me.BtnAuth.TabIndex = 2
        Me.BtnAuth.Text = "تمت المصادقه"
        Me.BtnAuth.UseVisualStyleBackColor = False
        '
        'BtnCloce
        '
        Me.BtnCloce.Location = New System.Drawing.Point(2, 377)
        Me.BtnCloce.Name = "BtnCloce"
        Me.BtnCloce.Size = New System.Drawing.Size(133, 49)
        Me.BtnCloce.TabIndex = 3
        Me.BtnCloce.Text = "اغلاق"
        Me.BtnCloce.UseVisualStyleBackColor = True
        '
        'AuthenticationCivilId
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCloce)
        Me.Controls.Add(Me.BtnAuth)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AuthenticationCivilId"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuthenticationCivilId"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblText As Label
    Friend WithEvents BtnAuth As Button
    Friend WithEvents BtnCloce As Button
End Class
