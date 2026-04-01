<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyDetails
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
        Dim Co_instagramLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyDetails))
        Me.Co_nameLabel = New System.Windows.Forms.Label()
        Me.Co_adressLabel = New System.Windows.Forms.Label()
        Me.Co_shonameLabel = New System.Windows.Forms.Label()
        Me.Co_nompLabel = New System.Windows.Forms.Label()
        Me.Co_fasxLabel = New System.Windows.Forms.Label()
        Me.Co_depLabel = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.Co_instagramTextBox = New System.Windows.Forms.TextBox()
        Me.lnkLogo = New System.Windows.Forms.LinkLabel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Comp_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_adrsTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_faxTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_emailTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_note11TextBox = New System.Windows.Forms.TextBox()
        Me.Comp_note1TextBox = New System.Windows.Forms.TextBox()
        Me.GroRptDetels = New System.Windows.Forms.GroupBox()
        Me.BtnFooterReport = New System.Windows.Forms.Button()
        Me.BtnHeaderReport = New System.Windows.Forms.Button()
        Me.PicFooterReport = New System.Windows.Forms.PictureBox()
        Me.PicHeaderReport = New System.Windows.Forms.PictureBox()
        Co_instagramLabel = New System.Windows.Forms.Label()
        Me.gb.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroRptDetels.SuspendLayout()
        CType(Me.PicFooterReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHeaderReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Co_instagramLabel
        '
        Co_instagramLabel.Location = New System.Drawing.Point(245, 256)
        Co_instagramLabel.Name = "Co_instagramLabel"
        Co_instagramLabel.Size = New System.Drawing.Size(128, 19)
        Co_instagramLabel.TabIndex = 14
        Co_instagramLabel.Text = "انستجرام"
        Co_instagramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_nameLabel
        '
        Me.Co_nameLabel.Location = New System.Drawing.Point(245, 64)
        Me.Co_nameLabel.Name = "Co_nameLabel"
        Me.Co_nameLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_nameLabel.TabIndex = 2
        Me.Co_nameLabel.Text = "اسم الشركة"
        Me.Co_nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_adressLabel
        '
        Me.Co_adressLabel.Location = New System.Drawing.Point(245, 102)
        Me.Co_adressLabel.Name = "Co_adressLabel"
        Me.Co_adressLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_adressLabel.TabIndex = 4
        Me.Co_adressLabel.Text = "العنوان"
        Me.Co_adressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_shonameLabel
        '
        Me.Co_shonameLabel.Location = New System.Drawing.Point(245, 26)
        Me.Co_shonameLabel.Name = "Co_shonameLabel"
        Me.Co_shonameLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_shonameLabel.TabIndex = 6
        Me.Co_shonameLabel.Text = "اسم المعرض"
        Me.Co_shonameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_nompLabel
        '
        Me.Co_nompLabel.Location = New System.Drawing.Point(245, 140)
        Me.Co_nompLabel.Name = "Co_nompLabel"
        Me.Co_nompLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_nompLabel.TabIndex = 8
        Me.Co_nompLabel.Text = "رقم التلفون"
        Me.Co_nompLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_fasxLabel
        '
        Me.Co_fasxLabel.Location = New System.Drawing.Point(245, 178)
        Me.Co_fasxLabel.Name = "Co_fasxLabel"
        Me.Co_fasxLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_fasxLabel.TabIndex = 10
        Me.Co_fasxLabel.Text = "فاكس"
        Me.Co_fasxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Co_depLabel
        '
        Me.Co_depLabel.Location = New System.Drawing.Point(245, 216)
        Me.Co_depLabel.Name = "Co_depLabel"
        Me.Co_depLabel.Size = New System.Drawing.Size(128, 22)
        Me.Co_depLabel.TabIndex = 12
        Me.Co_depLabel.Text = "البريد الالكتروني"
        Me.Co_depLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Location = New System.Drawing.Point(5, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(744, 33)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'gb
        '
        Me.gb.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gb.Controls.Add(Co_instagramLabel)
        Me.gb.Controls.Add(Me.Co_instagramTextBox)
        Me.gb.Controls.Add(Me.lnkLogo)
        Me.gb.Controls.Add(Me.LogoPictureBox)
        Me.gb.Controls.Add(Me.Co_depLabel)
        Me.gb.Controls.Add(Me.Comp_nameTextBox)
        Me.gb.Controls.Add(Me.Comp_adrsTextBox)
        Me.gb.Controls.Add(Me.Comp_faxTextBox)
        Me.gb.Controls.Add(Me.Comp_emailTextBox)
        Me.gb.Controls.Add(Me.Co_fasxLabel)
        Me.gb.Controls.Add(Me.Co_nameLabel)
        Me.gb.Controls.Add(Me.Co_nompLabel)
        Me.gb.Controls.Add(Me.Co_adressLabel)
        Me.gb.Controls.Add(Me.Co_shonameLabel)
        Me.gb.Controls.Add(Me.Comp_note11TextBox)
        Me.gb.Controls.Add(Me.Comp_note1TextBox)
        Me.gb.Location = New System.Drawing.Point(5, 40)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(744, 286)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        Me.gb.Text = "بيانات الشركة"
        '
        'Co_instagramTextBox
        '
        Me.Co_instagramTextBox.Location = New System.Drawing.Point(18, 252)
        Me.Co_instagramTextBox.Name = "Co_instagramTextBox"
        Me.Co_instagramTextBox.Size = New System.Drawing.Size(221, 32)
        Me.Co_instagramTextBox.TabIndex = 6
        Me.Co_instagramTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnkLogo
        '
        Me.lnkLogo.LinkColor = System.Drawing.Color.Red
        Me.lnkLogo.Location = New System.Drawing.Point(379, 23)
        Me.lnkLogo.Name = "lnkLogo"
        Me.lnkLogo.Size = New System.Drawing.Size(359, 38)
        Me.lnkLogo.TabIndex = 7
        Me.lnkLogo.TabStop = True
        Me.lnkLogo.Text = "خلفية البرنامج"
        Me.lnkLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.White
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Location = New System.Drawing.Point(379, 64)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(359, 215)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 14
        Me.LogoPictureBox.TabStop = False
        '
        'Comp_nameTextBox
        '
        Me.Comp_nameTextBox.Location = New System.Drawing.Point(18, 24)
        Me.Comp_nameTextBox.Name = "Comp_nameTextBox"
        Me.Comp_nameTextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_nameTextBox.TabIndex = 0
        Me.Comp_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comp_adrsTextBox
        '
        Me.Comp_adrsTextBox.Location = New System.Drawing.Point(18, 100)
        Me.Comp_adrsTextBox.Name = "Comp_adrsTextBox"
        Me.Comp_adrsTextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_adrsTextBox.TabIndex = 2
        Me.Comp_adrsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comp_faxTextBox
        '
        Me.Comp_faxTextBox.Location = New System.Drawing.Point(18, 176)
        Me.Comp_faxTextBox.Name = "Comp_faxTextBox"
        Me.Comp_faxTextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_faxTextBox.TabIndex = 4
        Me.Comp_faxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comp_emailTextBox
        '
        Me.Comp_emailTextBox.Location = New System.Drawing.Point(18, 214)
        Me.Comp_emailTextBox.Name = "Comp_emailTextBox"
        Me.Comp_emailTextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_emailTextBox.TabIndex = 5
        Me.Comp_emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comp_note11TextBox
        '
        Me.Comp_note11TextBox.Location = New System.Drawing.Point(18, 138)
        Me.Comp_note11TextBox.Name = "Comp_note11TextBox"
        Me.Comp_note11TextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_note11TextBox.TabIndex = 3
        Me.Comp_note11TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Comp_note1TextBox
        '
        Me.Comp_note1TextBox.Location = New System.Drawing.Point(18, 62)
        Me.Comp_note1TextBox.Name = "Comp_note1TextBox"
        Me.Comp_note1TextBox.Size = New System.Drawing.Size(221, 32)
        Me.Comp_note1TextBox.TabIndex = 1
        Me.Comp_note1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroRptDetels
        '
        Me.GroRptDetels.Controls.Add(Me.BtnFooterReport)
        Me.GroRptDetels.Controls.Add(Me.BtnHeaderReport)
        Me.GroRptDetels.Controls.Add(Me.PicFooterReport)
        Me.GroRptDetels.Controls.Add(Me.PicHeaderReport)
        Me.GroRptDetels.Location = New System.Drawing.Point(5, 333)
        Me.GroRptDetels.Name = "GroRptDetels"
        Me.GroRptDetels.Size = New System.Drawing.Size(738, 259)
        Me.GroRptDetels.TabIndex = 2
        Me.GroRptDetels.TabStop = False
        Me.GroRptDetels.Text = "RptDetels"
        '
        'BtnFooterReport
        '
        Me.BtnFooterReport.Location = New System.Drawing.Point(636, 158)
        Me.BtnFooterReport.Name = "BtnFooterReport"
        Me.BtnFooterReport.Size = New System.Drawing.Size(92, 35)
        Me.BtnFooterReport.TabIndex = 3
        Me.BtnFooterReport.Text = "تزييل التقرير"
        Me.BtnFooterReport.UseVisualStyleBackColor = True
        '
        'BtnHeaderReport
        '
        Me.BtnHeaderReport.Location = New System.Drawing.Point(645, 30)
        Me.BtnHeaderReport.Name = "BtnHeaderReport"
        Me.BtnHeaderReport.Size = New System.Drawing.Size(85, 35)
        Me.BtnHeaderReport.TabIndex = 2
        Me.BtnHeaderReport.Text = "رأس التقرير"
        Me.BtnHeaderReport.UseVisualStyleBackColor = True
        '
        'PicFooterReport
        '
        Me.PicFooterReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFooterReport.Location = New System.Drawing.Point(7, 154)
        Me.PicFooterReport.Name = "PicFooterReport"
        Me.PicFooterReport.Size = New System.Drawing.Size(724, 105)
        Me.PicFooterReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFooterReport.TabIndex = 1
        Me.PicFooterReport.TabStop = False
        '
        'PicHeaderReport
        '
        Me.PicHeaderReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicHeaderReport.Location = New System.Drawing.Point(8, 27)
        Me.PicHeaderReport.Name = "PicHeaderReport"
        Me.PicHeaderReport.Size = New System.Drawing.Size(724, 105)
        Me.PicHeaderReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicHeaderReport.TabIndex = 0
        Me.PicHeaderReport.TabStop = False
        '
        'CompanyDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 599)
        Me.Controls.Add(Me.GroRptDetels)
        Me.Controls.Add(Me.gb)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات الشركة"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroRptDetels.ResumeLayout(False)
        CType(Me.PicFooterReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHeaderReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents lnkLogo As System.Windows.Forms.LinkLabel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Comp_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_adrsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_note1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_note11TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_nameLabel As System.Windows.Forms.Label
    Friend WithEvents Co_adressLabel As System.Windows.Forms.Label
    Friend WithEvents Co_shonameLabel As System.Windows.Forms.Label
    Friend WithEvents Co_nompLabel As System.Windows.Forms.Label
    Friend WithEvents Co_fasxLabel As System.Windows.Forms.Label
    Friend WithEvents Co_depLabel As System.Windows.Forms.Label
    Friend WithEvents Co_instagramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Comp_emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroRptDetels As GroupBox
    Friend WithEvents BtnFooterReport As Button
    Friend WithEvents BtnHeaderReport As Button
    Friend WithEvents PicFooterReport As PictureBox
    Friend WithEvents PicHeaderReport As PictureBox
End Class
