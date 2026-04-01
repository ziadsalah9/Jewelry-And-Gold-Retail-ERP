<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class min_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(min_Items))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnDiamond = New System.Windows.Forms.Button()
        Me.btnSilver = New System.Windows.Forms.Button()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.btnAuction = New System.Windows.Forms.Button()
        Me.btnClock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(5, 4)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(20, 19)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        '
        'btnDiamond
        '
        Me.btnDiamond.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDiamond.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDiamond.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDiamond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiamond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDiamond.ForeColor = System.Drawing.Color.Black
        Me.btnDiamond.Image = Global.DT_restrant.My.Resources.Resources.IceCube
        Me.btnDiamond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiamond.Location = New System.Drawing.Point(7, 30)
        Me.btnDiamond.Name = "btnDiamond"
        Me.btnDiamond.Size = New System.Drawing.Size(213, 40)
        Me.btnDiamond.TabIndex = 9
        Me.btnDiamond.Text = "ألماس"
        Me.btnDiamond.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDiamond.UseVisualStyleBackColor = False
        '
        'btnSilver
        '
        Me.btnSilver.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSilver.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSilver.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSilver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSilver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSilver.ForeColor = System.Drawing.Color.Black
        Me.btnSilver.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnSilver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSilver.Location = New System.Drawing.Point(226, 30)
        Me.btnSilver.Name = "btnSilver"
        Me.btnSilver.Size = New System.Drawing.Size(211, 40)
        Me.btnSilver.TabIndex = 8
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
        Me.btnGold.Location = New System.Drawing.Point(443, 30)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(200, 40)
        Me.btnGold.TabIndex = 7
        Me.btnGold.Text = "ذهب"
        Me.btnGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGold.UseVisualStyleBackColor = False
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
        Me.btnAuction.Location = New System.Drawing.Point(339, 80)
        Me.btnAuction.Name = "btnAuction"
        Me.btnAuction.Size = New System.Drawing.Size(304, 40)
        Me.btnAuction.TabIndex = 11
        Me.btnAuction.Text = "مزادات"
        Me.btnAuction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAuction.UseVisualStyleBackColor = False
        '
        'btnClock
        '
        Me.btnClock.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnClock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClock.ForeColor = System.Drawing.Color.Black
        Me.btnClock.Image = Global.DT_restrant.My.Resources.Resources.Watch
        Me.btnClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClock.Location = New System.Drawing.Point(7, 80)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(326, 40)
        Me.btnClock.TabIndex = 16
        Me.btnClock.Text = "ساعات وماركات"
        Me.btnClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClock.UseVisualStyleBackColor = False
        '
        'min_Items
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.LinkLabel1
        Me.ClientSize = New System.Drawing.Size(650, 132)
        Me.Controls.Add(Me.btnClock)
        Me.Controls.Add(Me.btnAuction)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnDiamond)
        Me.Controls.Add(Me.btnSilver)
        Me.Controls.Add(Me.btnGold)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "min_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "min_detels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnDiamond As System.Windows.Forms.Button
    Friend WithEvents btnSilver As System.Windows.Forms.Button
    Friend WithEvents btnGold As System.Windows.Forms.Button
    Friend WithEvents btnAuction As System.Windows.Forms.Button
    Friend WithEvents btnClock As System.Windows.Forms.Button
End Class
