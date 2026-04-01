<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class min_BarCode
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
        Me.btnClose = New System.Windows.Forms.LinkLabel()
        Me.btnDiamond = New System.Windows.Forms.Button()
        Me.btnSilver = New System.Windows.Forms.Button()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.btnAccessories = New System.Windows.Forms.Button()
        Me.btnAuction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.LinkColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(5, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 19)
        Me.btnClose.TabIndex = 14
        Me.btnClose.TabStop = True
        Me.btnClose.Text = "X"
        '
        'btnDiamond
        '
        Me.btnDiamond.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDiamond.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDiamond.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDiamond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiamond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDiamond.ForeColor = System.Drawing.Color.Black
        Me.btnDiamond.Image = Global.DT_restrant.My.Resources.Resources.IceCube
        Me.btnDiamond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiamond.Location = New System.Drawing.Point(9, 30)
        Me.btnDiamond.Name = "btnDiamond"
        Me.btnDiamond.Size = New System.Drawing.Size(200, 40)
        Me.btnDiamond.TabIndex = 13
        Me.btnDiamond.Text = "ألماس"
        Me.btnDiamond.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDiamond.UseVisualStyleBackColor = False
        '
        'btnSilver
        '
        Me.btnSilver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSilver.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSilver.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSilver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSilver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSilver.ForeColor = System.Drawing.Color.Black
        Me.btnSilver.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnSilver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSilver.Location = New System.Drawing.Point(225, 30)
        Me.btnSilver.Name = "btnSilver"
        Me.btnSilver.Size = New System.Drawing.Size(200, 40)
        Me.btnSilver.TabIndex = 12
        Me.btnSilver.Text = "فضة"
        Me.btnSilver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSilver.UseVisualStyleBackColor = False
        '
        'btnGold
        '
        Me.btnGold.BackColor = System.Drawing.Color.Gold
        Me.btnGold.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnGold.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGold.ForeColor = System.Drawing.Color.Black
        Me.btnGold.Image = Global.DT_restrant.My.Resources.Resources.GoldBars
        Me.btnGold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGold.Location = New System.Drawing.Point(441, 30)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(200, 40)
        Me.btnGold.TabIndex = 11
        Me.btnGold.Text = "ذهب"
        Me.btnGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGold.UseVisualStyleBackColor = False
        '
        'btnAccessories
        '
        Me.btnAccessories.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAccessories.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAccessories.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAccessories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAccessories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAccessories.ForeColor = System.Drawing.Color.Black
        Me.btnAccessories.Image = Global.DT_restrant.My.Resources.Resources.Watch
        Me.btnAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccessories.Location = New System.Drawing.Point(12, 76)
        Me.btnAccessories.Name = "btnAccessories"
        Me.btnAccessories.Size = New System.Drawing.Size(314, 40)
        Me.btnAccessories.TabIndex = 16
        Me.btnAccessories.Text = "ساعات وماركات"
        Me.btnAccessories.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccessories.UseVisualStyleBackColor = False
        '
        'btnAuction
        '
        Me.btnAuction.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAuction.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnAuction.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAuction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAuction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAuction.ForeColor = System.Drawing.Color.Black
        Me.btnAuction.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnAuction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuction.Location = New System.Drawing.Point(352, 78)
        Me.btnAuction.Name = "btnAuction"
        Me.btnAuction.Size = New System.Drawing.Size(289, 40)
        Me.btnAuction.TabIndex = 15
        Me.btnAuction.Text = "مزادات"
        Me.btnAuction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAuction.UseVisualStyleBackColor = False
        '
        'min_BarCode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(650, 130)
        Me.Controls.Add(Me.btnAccessories)
        Me.Controls.Add(Me.btnAuction)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDiamond)
        Me.Controls.Add(Me.btnSilver)
        Me.Controls.Add(Me.btnGold)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "min_BarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "parcood_min"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnDiamond As System.Windows.Forms.Button
    Friend WithEvents btnSilver As System.Windows.Forms.Button
    Friend WithEvents btnGold As System.Windows.Forms.Button
    Friend WithEvents btnAccessories As System.Windows.Forms.Button
    Friend WithEvents btnAuction As System.Windows.Forms.Button
End Class
