<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class whatsapp_Qr
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.gbQRCode = New System.Windows.Forms.GroupBox()
        Me.picQRCode = New System.Windows.Forms.PictureBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.gbLastImages = New System.Windows.Forms.GroupBox()
        Me.txtPhoneForID = New System.Windows.Forms.TextBox()
        Me.lblPhoneForID = New System.Windows.Forms.Label()
        Me.btnGetIDFromWhatsApp = New System.Windows.Forms.Button()
        Me.picImage2 = New System.Windows.Forms.PictureBox()
        Me.picImage1 = New System.Windows.Forms.PictureBox()
        Me.btnLoadLastImages = New System.Windows.Forms.Button()
        Me.lblLastImages = New System.Windows.Forms.Label()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.txtTestMessage = New System.Windows.Forms.TextBox()
        Me.lblTestMessage = New System.Windows.Forms.Label()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.lblUUID = New System.Windows.Forms.Label()
        Me.txtAppKey = New System.Windows.Forms.TextBox()
        Me.lblAppKey = New System.Windows.Forms.Label()
        Me.txtAuthKey = New System.Windows.Forms.TextBox()
        Me.lblAuthKey = New System.Windows.Forms.Label()
        Me.dtpExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTestSend = New System.Windows.Forms.Button()
        Me.pnlMain.SuspendLayout()
        Me.gbQRCode.SuspendLayout()
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLastImages.SuspendLayout()
        CType(Me.picImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.gbQRCode)
        Me.pnlMain.Controls.Add(Me.gbLastImages)
        Me.pnlMain.Controls.Add(Me.gbSettings)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(1154, 600)
        Me.pnlMain.TabIndex = 0
        '
        'gbQRCode
        '
        Me.gbQRCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbQRCode.BackColor = System.Drawing.Color.White
        Me.gbQRCode.Controls.Add(Me.picQRCode)
        Me.gbQRCode.Controls.Add(Me.btnRefresh)
        Me.gbQRCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbQRCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbQRCode.Location = New System.Drawing.Point(20, 20)
        Me.gbQRCode.Name = "gbQRCode"
        Me.gbQRCode.Padding = New System.Windows.Forms.Padding(15)
        Me.gbQRCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbQRCode.Size = New System.Drawing.Size(414, 560)
        Me.gbQRCode.TabIndex = 0
        Me.gbQRCode.TabStop = False
        Me.gbQRCode.Text = "📱 رمز QR Code"
        '
        'picQRCode
        '
        Me.picQRCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picQRCode.BackColor = System.Drawing.Color.White
        Me.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQRCode.Location = New System.Drawing.Point(15, 50)
        Me.picQRCode.Name = "picQRCode"
        Me.picQRCode.Size = New System.Drawing.Size(384, 450)
        Me.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQRCode.TabIndex = 0
        Me.picQRCode.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(15, 510)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(381, 40)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "🔄 تحديث QR Code"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'gbLastImages
        '
        Me.gbLastImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLastImages.BackColor = System.Drawing.Color.White
        Me.gbLastImages.Controls.Add(Me.txtPhoneForID)
        Me.gbLastImages.Controls.Add(Me.lblPhoneForID)
        Me.gbLastImages.Controls.Add(Me.btnGetIDFromWhatsApp)
        Me.gbLastImages.Controls.Add(Me.picImage2)
        Me.gbLastImages.Controls.Add(Me.picImage1)
        Me.gbLastImages.Controls.Add(Me.btnLoadLastImages)
        Me.gbLastImages.Controls.Add(Me.lblLastImages)
        Me.gbLastImages.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLastImages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbLastImages.Location = New System.Drawing.Point(739, 20)
        Me.gbLastImages.Name = "gbLastImages"
        Me.gbLastImages.Padding = New System.Windows.Forms.Padding(15)
        Me.gbLastImages.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbLastImages.Size = New System.Drawing.Size(395, 560)
        Me.gbLastImages.TabIndex = 2
        Me.gbLastImages.TabStop = False
        Me.gbLastImages.Text = "🖼️ آخر الصور المستلمة"
        '
        'txtPhoneForID
        '
        Me.txtPhoneForID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneForID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneForID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneForID.Location = New System.Drawing.Point(15, 475)
        Me.txtPhoneForID.Name = "txtPhoneForID"
        Me.txtPhoneForID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhoneForID.Size = New System.Drawing.Size(200, 25)
        Me.txtPhoneForID.TabIndex = 5
        Me.txtPhoneForID.Text = "96590083366"
        '
        'lblPhoneForID
        '
        Me.lblPhoneForID.AutoSize = True
        Me.lblPhoneForID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneForID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblPhoneForID.Location = New System.Drawing.Point(15, 453)
        Me.lblPhoneForID.Name = "lblPhoneForID"
        Me.lblPhoneForID.Size = New System.Drawing.Size(94, 19)
        Me.lblPhoneForID.TabIndex = 4
        Me.lblPhoneForID.Text = "📱 رقم الهاتف:"
        '
        'btnGetIDFromWhatsApp
        '
        Me.btnGetIDFromWhatsApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetIDFromWhatsApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnGetIDFromWhatsApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetIDFromWhatsApp.FlatAppearance.BorderSize = 0
        Me.btnGetIDFromWhatsApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnGetIDFromWhatsApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGetIDFromWhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetIDFromWhatsApp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetIDFromWhatsApp.ForeColor = System.Drawing.Color.White
        Me.btnGetIDFromWhatsApp.Location = New System.Drawing.Point(221, 475)
        Me.btnGetIDFromWhatsApp.Name = "btnGetIDFromWhatsApp"
        Me.btnGetIDFromWhatsApp.Size = New System.Drawing.Size(150, 25)
        Me.btnGetIDFromWhatsApp.TabIndex = 6
        Me.btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
        Me.btnGetIDFromWhatsApp.UseVisualStyleBackColor = False
        '
        'picImage2
        '
        Me.picImage2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage2.BackColor = System.Drawing.Color.White
        Me.picImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage2.Location = New System.Drawing.Point(18, 238)
        Me.picImage2.Name = "picImage2"
        Me.picImage2.Size = New System.Drawing.Size(355, 200)
        Me.picImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage2.TabIndex = 3
        Me.picImage2.TabStop = False
        '
        'picImage1
        '
        Me.picImage1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage1.BackColor = System.Drawing.Color.White
        Me.picImage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage1.Location = New System.Drawing.Point(18, 33)
        Me.picImage1.Name = "picImage1"
        Me.picImage1.Size = New System.Drawing.Size(355, 200)
        Me.picImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage1.TabIndex = 2
        Me.picImage1.TabStop = False
        '
        'btnLoadLastImages
        '
        Me.btnLoadLastImages.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoadLastImages.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadLastImages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadLastImages.FlatAppearance.BorderSize = 0
        Me.btnLoadLastImages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLoadLastImages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadLastImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadLastImages.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadLastImages.ForeColor = System.Drawing.Color.White
        Me.btnLoadLastImages.Location = New System.Drawing.Point(15, 520)
        Me.btnLoadLastImages.Name = "btnLoadLastImages"
        Me.btnLoadLastImages.Size = New System.Drawing.Size(355, 30)
        Me.btnLoadLastImages.TabIndex = 1
        Me.btnLoadLastImages.Text = "🔄 جلب آخر الصور"
        Me.btnLoadLastImages.UseVisualStyleBackColor = False
        '
        'lblLastImages
        '
        Me.lblLastImages.AutoSize = True
        Me.lblLastImages.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastImages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblLastImages.Location = New System.Drawing.Point(15, 30)
        Me.lblLastImages.Name = "lblLastImages"
        Me.lblLastImages.Size = New System.Drawing.Size(0, 15)
        Me.lblLastImages.TabIndex = 0
        '
        'gbSettings
        '
        Me.gbSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSettings.BackColor = System.Drawing.Color.White
        Me.gbSettings.Controls.Add(Me.txtTestMessage)
        Me.gbSettings.Controls.Add(Me.lblTestMessage)
        Me.gbSettings.Controls.Add(Me.txtUUID)
        Me.gbSettings.Controls.Add(Me.lblUUID)
        Me.gbSettings.Controls.Add(Me.txtAppKey)
        Me.gbSettings.Controls.Add(Me.lblAppKey)
        Me.gbSettings.Controls.Add(Me.txtAuthKey)
        Me.gbSettings.Controls.Add(Me.lblAuthKey)
        Me.gbSettings.Controls.Add(Me.dtpExpireDate)
        Me.gbSettings.Controls.Add(Me.lblExpireDate)
        Me.gbSettings.Controls.Add(Me.txtPhoneNumber)
        Me.gbSettings.Controls.Add(Me.lblPhoneNumber)
        Me.gbSettings.Controls.Add(Me.btnSave)
        Me.gbSettings.Controls.Add(Me.btnTestSend)
        Me.gbSettings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbSettings.Location = New System.Drawing.Point(440, 23)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Padding = New System.Windows.Forms.Padding(20)
        Me.gbSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbSettings.Size = New System.Drawing.Size(293, 557)
        Me.gbSettings.TabIndex = 1
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "⚙️ الإعدادات"
        '
        'txtTestMessage
        '
        Me.txtTestMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTestMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestMessage.Location = New System.Drawing.Point(20, 110)
        Me.txtTestMessage.Multiline = True
        Me.txtTestMessage.Name = "txtTestMessage"
        Me.txtTestMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTestMessage.Size = New System.Drawing.Size(253, 30)
        Me.txtTestMessage.TabIndex = 5
        Me.txtTestMessage.Text = "رسالة اختبار"
        '
        'lblTestMessage
        '
        Me.lblTestMessage.AutoSize = True
        Me.lblTestMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblTestMessage.Location = New System.Drawing.Point(20, 95)
        Me.lblTestMessage.Name = "lblTestMessage"
        Me.lblTestMessage.Size = New System.Drawing.Size(79, 19)
        Me.lblTestMessage.TabIndex = 11
        Me.lblTestMessage.Text = "💬 الرسالة:"
        '
        'txtUUID
        '
        Me.txtUUID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUUID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUUID.Location = New System.Drawing.Point(23, 444)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUUID.Size = New System.Drawing.Size(253, 25)
        Me.txtUUID.TabIndex = 4
        Me.txtUUID.Text = " "
        '
        'lblUUID
        '
        Me.lblUUID.AutoSize = True
        Me.lblUUID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUUID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblUUID.Location = New System.Drawing.Point(23, 419)
        Me.lblUUID.Name = "lblUUID"
        Me.lblUUID.Size = New System.Drawing.Size(71, 19)
        Me.lblUUID.TabIndex = 9
        Me.lblUUID.Text = "🔑 UUID:"
        '
        'txtAppKey
        '
        Me.txtAppKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAppKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppKey.Location = New System.Drawing.Point(23, 384)
        Me.txtAppKey.Name = "txtAppKey"
        Me.txtAppKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAppKey.Size = New System.Drawing.Size(253, 25)
        Me.txtAppKey.TabIndex = 3
        Me.txtAppKey.Text = " "
        '
        'lblAppKey
        '
        Me.lblAppKey.AutoSize = True
        Me.lblAppKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblAppKey.Location = New System.Drawing.Point(23, 359)
        Me.lblAppKey.Name = "lblAppKey"
        Me.lblAppKey.Size = New System.Drawing.Size(94, 19)
        Me.lblAppKey.TabIndex = 7
        Me.lblAppKey.Text = "🔑 App Key:"
        '
        'txtAuthKey
        '
        Me.txtAuthKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthKey.Location = New System.Drawing.Point(23, 324)
        Me.txtAuthKey.Name = "txtAuthKey"
        Me.txtAuthKey.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAuthKey.Size = New System.Drawing.Size(253, 25)
        Me.txtAuthKey.TabIndex = 2
        Me.txtAuthKey.Text = " "
        '
        'lblAuthKey
        '
        Me.lblAuthKey.AutoSize = True
        Me.lblAuthKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblAuthKey.Location = New System.Drawing.Point(23, 299)
        Me.lblAuthKey.Name = "lblAuthKey"
        Me.lblAuthKey.Size = New System.Drawing.Size(97, 19)
        Me.lblAuthKey.TabIndex = 5
        Me.lblAuthKey.Text = "🔑 Auth Key:"
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Location = New System.Drawing.Point(220, 30)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(200, 29)
        Me.dtpExpireDate.TabIndex = 12
        Me.dtpExpireDate.Visible = False
        '
        'lblExpireDate
        '
        Me.lblExpireDate.Location = New System.Drawing.Point(0, 0)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(100, 23)
        Me.lblExpireDate.TabIndex = 13
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(20, 65)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhoneNumber.Size = New System.Drawing.Size(253, 27)
        Me.txtPhoneNumber.TabIndex = 0
        Me.txtPhoneNumber.Text = "96590083366"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(20, 40)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(123, 19)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "📱 رقم المرسل إليه:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(20, 477)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(253, 40)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "💾 حفظ الإعدادات"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnTestSend
        '
        Me.btnTestSend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTestSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnTestSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTestSend.FlatAppearance.BorderSize = 0
        Me.btnTestSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnTestSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnTestSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestSend.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestSend.ForeColor = System.Drawing.Color.White
        Me.btnTestSend.Location = New System.Drawing.Point(17, 146)
        Me.btnTestSend.Name = "btnTestSend"
        Me.btnTestSend.Size = New System.Drawing.Size(253, 45)
        Me.btnTestSend.TabIndex = 6
        Me.btnTestSend.Text = "📤 اختبار الإرسال"
        Me.btnTestSend.UseVisualStyleBackColor = False
        '
        'whatsapp_Qr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "whatsapp_Qr"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WhatsApp QR Code - إعدادات واتساب"
        Me.pnlMain.ResumeLayout(False)
        Me.gbQRCode.ResumeLayout(False)
        CType(Me.picQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLastImages.ResumeLayout(False)
        Me.gbLastImages.PerformLayout()
        CType(Me.picImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents gbQRCode As GroupBox
    Friend WithEvents picQRCode As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents gbLastImages As GroupBox
    Friend WithEvents txtPhoneForID As TextBox
    Friend WithEvents lblPhoneForID As Label
    Friend WithEvents btnGetIDFromWhatsApp As Button
    Friend WithEvents picImage2 As PictureBox
    Friend WithEvents picImage1 As PictureBox
    Friend WithEvents btnLoadLastImages As Button
    Friend WithEvents lblLastImages As Label
    Friend WithEvents gbSettings As GroupBox
    Friend WithEvents txtTestMessage As TextBox
    Friend WithEvents lblTestMessage As Label
    Friend WithEvents txtUUID As TextBox
    Friend WithEvents lblUUID As Label
    Friend WithEvents txtAppKey As TextBox
    Friend WithEvents lblAppKey As Label
    Friend WithEvents txtAuthKey As TextBox
    Friend WithEvents lblAuthKey As Label
    Friend WithEvents dtpExpireDate As DateTimePicker
    Friend WithEvents lblExpireDate As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnTestSend As Button
End Class
