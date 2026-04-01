<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class min_Buy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(min_Buy))
        Me.btnClose = New System.Windows.Forms.LinkLabel()
        Me.btnAccessories = New System.Windows.Forms.Button()
        Me.btnSilver = New System.Windows.Forms.Button()
        Me.btnDiamond = New System.Windows.Forms.Button()
        Me.btnGold = New System.Windows.Forms.Button()
        Me.btnWorkShops = New System.Windows.Forms.Button()
        Me.btnCompanies = New System.Windows.Forms.Button()
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
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = True
        Me.btnClose.Text = "X"
        '
        'btnAccessories
        '
        Me.btnAccessories.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAccessories.Image = Global.DT_restrant.My.Resources.Resources.Watch
        Me.btnAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccessories.Location = New System.Drawing.Point(443, 85)
        Me.btnAccessories.Name = "btnAccessories"
        Me.btnAccessories.Size = New System.Drawing.Size(200, 35)
        Me.btnAccessories.TabIndex = 10
        Me.btnAccessories.Text = "ساعات وماركات"
        Me.btnAccessories.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccessories.UseVisualStyleBackColor = False
        '
        'btnSilver
        '
        Me.btnSilver.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSilver.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnSilver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSilver.Location = New System.Drawing.Point(226, 30)
        Me.btnSilver.Name = "btnSilver"
        Me.btnSilver.Size = New System.Drawing.Size(200, 35)
        Me.btnSilver.TabIndex = 9
        Me.btnSilver.Text = "فضة"
        Me.btnSilver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSilver.UseVisualStyleBackColor = False
        '
        'btnDiamond
        '
        Me.btnDiamond.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDiamond.Image = Global.DT_restrant.My.Resources.Resources.IceCube
        Me.btnDiamond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiamond.Location = New System.Drawing.Point(7, 30)
        Me.btnDiamond.Name = "btnDiamond"
        Me.btnDiamond.Size = New System.Drawing.Size(200, 35)
        Me.btnDiamond.TabIndex = 8
        Me.btnDiamond.Text = "ألماس"
        Me.btnDiamond.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDiamond.UseVisualStyleBackColor = False
        '
        'btnGold
        '
        Me.btnGold.BackColor = System.Drawing.Color.Gold
        Me.btnGold.Image = Global.DT_restrant.My.Resources.Resources.GoldBars
        Me.btnGold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGold.Location = New System.Drawing.Point(443, 30)
        Me.btnGold.Name = "btnGold"
        Me.btnGold.Size = New System.Drawing.Size(200, 35)
        Me.btnGold.TabIndex = 0
        Me.btnGold.Text = "ذهب"
        Me.btnGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGold.UseVisualStyleBackColor = False
        '
        'btnWorkShops
        '
        Me.btnWorkShops.BackColor = System.Drawing.Color.Aquamarine
        Me.btnWorkShops.Image = Global.DT_restrant.My.Resources.Resources.Cubes
        Me.btnWorkShops.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWorkShops.Location = New System.Drawing.Point(7, 85)
        Me.btnWorkShops.Name = "btnWorkShops"
        Me.btnWorkShops.Size = New System.Drawing.Size(200, 35)
        Me.btnWorkShops.TabIndex = 3
        Me.btnWorkShops.Text = "ورش التصنيع"
        Me.btnWorkShops.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWorkShops.UseVisualStyleBackColor = False
        '
        'btnCompanies
        '
        Me.btnCompanies.BackColor = System.Drawing.Color.Aquamarine
        Me.btnCompanies.Image = Global.DT_restrant.My.Resources.Resources.GoldBars
        Me.btnCompanies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompanies.Location = New System.Drawing.Point(226, 85)
        Me.btnCompanies.Name = "btnCompanies"
        Me.btnCompanies.Size = New System.Drawing.Size(200, 35)
        Me.btnCompanies.TabIndex = 1
        Me.btnCompanies.Text = "شركات"
        Me.btnCompanies.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCompanies.UseVisualStyleBackColor = False
        '
        'min_Buy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(650, 132)
        Me.Controls.Add(Me.btnAccessories)
        Me.Controls.Add(Me.btnSilver)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDiamond)
        Me.Controls.Add(Me.btnGold)
        Me.Controls.Add(Me.btnWorkShops)
        Me.Controls.Add(Me.btnCompanies)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "min_Buy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pay_min"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGold As System.Windows.Forms.Button
    Friend WithEvents btnCompanies As System.Windows.Forms.Button
    Friend WithEvents btnWorkShops As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnDiamond As System.Windows.Forms.Button
    Friend WithEvents btnSilver As System.Windows.Forms.Button
    Friend WithEvents btnAccessories As System.Windows.Forms.Button
End Class
