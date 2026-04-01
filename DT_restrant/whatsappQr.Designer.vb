<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class whatsappQr
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
        Me.components = New System.ComponentModel.Container()
        Me.gbSettings = New System.Windows.Forms.GroupBox()
        Me.btnLoadSettings = New System.Windows.Forms.Button()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.txtAppKey = New System.Windows.Forms.TextBox()
        Me.txtAuthKey = New System.Windows.Forms.TextBox()
        Me.lblUUID = New System.Windows.Forms.Label()
        Me.lblAppKey = New System.Windows.Forms.Label()
        Me.lblAuthKey = New System.Windows.Forms.Label()
        Me.gbQR = New System.Windows.Forms.GroupBox()
        Me.btnShowResponse = New System.Windows.Forms.Button()
        Me.btnRefreshQR = New System.Windows.Forms.Button()
        Me.PicQrCode = New System.Windows.Forms.PictureBox()
        Me.gbTestSend = New System.Windows.Forms.GroupBox()
        Me.btnBrowseFile = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.btnTestSend = New System.Windows.Forms.Button()
        Me.txtTestMessage = New System.Windows.Forms.TextBox()
        Me.txtTestPhone = New System.Windows.Forms.TextBox()
        Me.lblTestMessage = New System.Windows.Forms.Label()
        Me.lblTestPhone = New System.Windows.Forms.Label()
        Me.TimerQR = New System.Windows.Forms.Timer(Me.components)
        Me.gbSettings.SuspendLayout()
        Me.gbQR.SuspendLayout()
        CType(Me.PicQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTestSend.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSettings
        '
        Me.gbSettings.Controls.Add(Me.btnLoadSettings)
        Me.gbSettings.Controls.Add(Me.btnSaveSettings)
        Me.gbSettings.Controls.Add(Me.txtUUID)
        Me.gbSettings.Controls.Add(Me.txtAppKey)
        Me.gbSettings.Controls.Add(Me.txtAuthKey)
        Me.gbSettings.Controls.Add(Me.lblUUID)
        Me.gbSettings.Controls.Add(Me.lblAppKey)
        Me.gbSettings.Controls.Add(Me.lblAuthKey)
        Me.gbSettings.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbSettings.Location = New System.Drawing.Point(15, 15)
        Me.gbSettings.Name = "gbSettings"
        Me.gbSettings.Padding = New System.Windows.Forms.Padding(10)
        Me.gbSettings.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbSettings.Size = New System.Drawing.Size(520, 240)
        Me.gbSettings.TabIndex = 0
        Me.gbSettings.TabStop = False
        Me.gbSettings.Text = "⚙️ إعدادات WhatsApp API"
        '
        'btnLoadSettings
        '
        Me.btnLoadSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSettings.FlatAppearance.BorderSize = 0
        Me.btnLoadSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLoadSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadSettings.ForeColor = System.Drawing.Color.White
        Me.btnLoadSettings.Location = New System.Drawing.Point(215, 195)
        Me.btnLoadSettings.Name = "btnLoadSettings"
        Me.btnLoadSettings.Size = New System.Drawing.Size(180, 38)
        Me.btnLoadSettings.TabIndex = 7
        Me.btnLoadSettings.Text = "📂 تحميل الإعدادات"
        Me.btnLoadSettings.UseVisualStyleBackColor = False
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSettings.FlatAppearance.BorderSize = 0
        Me.btnSaveSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSettings.ForeColor = System.Drawing.Color.White
        Me.btnSaveSettings.Location = New System.Drawing.Point(25, 195)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(180, 38)
        Me.btnSaveSettings.TabIndex = 6
        Me.btnSaveSettings.Text = "💾 حفظ الإعدادات"
        Me.btnSaveSettings.UseVisualStyleBackColor = False
        '
        'txtUUID
        '
        Me.txtUUID.BackColor = System.Drawing.Color.White
        Me.txtUUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUUID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUUID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtUUID.Location = New System.Drawing.Point(25, 155)
        Me.txtUUID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.Size = New System.Drawing.Size(360, 25)
        Me.txtUUID.TabIndex = 2
        '
        'txtAppKey
        '
        Me.txtAppKey.BackColor = System.Drawing.Color.White
        Me.txtAppKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAppKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtAppKey.Location = New System.Drawing.Point(25, 105)
        Me.txtAppKey.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAppKey.Name = "txtAppKey"
        Me.txtAppKey.Size = New System.Drawing.Size(360, 25)
        Me.txtAppKey.TabIndex = 1
        '
        'txtAuthKey
        '
        Me.txtAuthKey.BackColor = System.Drawing.Color.White
        Me.txtAuthKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtAuthKey.Location = New System.Drawing.Point(25, 55)
        Me.txtAuthKey.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAuthKey.Name = "txtAuthKey"
        Me.txtAuthKey.Size = New System.Drawing.Size(360, 25)
        Me.txtAuthKey.TabIndex = 0
        '
        'lblUUID
        '
        Me.lblUUID.AutoSize = True
        Me.lblUUID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUUID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblUUID.Location = New System.Drawing.Point(395, 158)
        Me.lblUUID.Name = "lblUUID"
        Me.lblUUID.Size = New System.Drawing.Size(71, 19)
        Me.lblUUID.TabIndex = 5
        Me.lblUUID.Text = "🆔 UUID:"
        '
        'lblAppKey
        '
        Me.lblAppKey.AutoSize = True
        Me.lblAppKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblAppKey.Location = New System.Drawing.Point(395, 108)
        Me.lblAppKey.Name = "lblAppKey"
        Me.lblAppKey.Size = New System.Drawing.Size(94, 19)
        Me.lblAppKey.TabIndex = 4
        Me.lblAppKey.Text = "🔑 App Key:"
        '
        'lblAuthKey
        '
        Me.lblAuthKey.AutoSize = True
        Me.lblAuthKey.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblAuthKey.Location = New System.Drawing.Point(395, 58)
        Me.lblAuthKey.Name = "lblAuthKey"
        Me.lblAuthKey.Size = New System.Drawing.Size(97, 19)
        Me.lblAuthKey.TabIndex = 3
        Me.lblAuthKey.Text = "🔑 Auth Key:"
        '
        'gbQR
        '
        Me.gbQR.Controls.Add(Me.btnShowResponse)
        Me.gbQR.Controls.Add(Me.btnRefreshQR)
        Me.gbQR.Controls.Add(Me.PicQrCode)
        Me.gbQR.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbQR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbQR.Location = New System.Drawing.Point(591, 15)
        Me.gbQR.Name = "gbQR"
        Me.gbQR.Padding = New System.Windows.Forms.Padding(10)
        Me.gbQR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbQR.Size = New System.Drawing.Size(320, 400)
        Me.gbQR.TabIndex = 1
        Me.gbQR.TabStop = False
        Me.gbQR.Text = "📱 QR Code"
        '
        'btnShowResponse
        '
        Me.btnShowResponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShowResponse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowResponse.FlatAppearance.BorderSize = 0
        Me.btnShowResponse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShowResponse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnShowResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowResponse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowResponse.ForeColor = System.Drawing.Color.White
        Me.btnShowResponse.Location = New System.Drawing.Point(165, 320)
        Me.btnShowResponse.Name = "btnShowResponse"
        Me.btnShowResponse.Size = New System.Drawing.Size(130, 42)
        Me.btnShowResponse.TabIndex = 2
        Me.btnShowResponse.Text = "📋 عرض Response"
        Me.btnShowResponse.UseVisualStyleBackColor = False
        '
        'btnRefreshQR
        '
        Me.btnRefreshQR.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnRefreshQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshQR.FlatAppearance.BorderSize = 0
        Me.btnRefreshQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnRefreshQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnRefreshQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshQR.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshQR.ForeColor = System.Drawing.Color.White
        Me.btnRefreshQR.Location = New System.Drawing.Point(25, 320)
        Me.btnRefreshQR.Name = "btnRefreshQR"
        Me.btnRefreshQR.Size = New System.Drawing.Size(130, 42)
        Me.btnRefreshQR.TabIndex = 1
        Me.btnRefreshQR.Text = "🔄 تحديث"
        Me.btnRefreshQR.UseVisualStyleBackColor = False
        '
        'PicQrCode
        '
        Me.PicQrCode.BackColor = System.Drawing.Color.White
        Me.PicQrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicQrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicQrCode.Location = New System.Drawing.Point(25, 40)
        Me.PicQrCode.Name = "PicQrCode"
        Me.PicQrCode.Size = New System.Drawing.Size(270, 270)
        Me.PicQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicQrCode.TabIndex = 0
        Me.PicQrCode.TabStop = False
        '
        'gbTestSend
        '
        Me.gbTestSend.Controls.Add(Me.btnBrowseFile)
        Me.gbTestSend.Controls.Add(Me.txtFilePath)
        Me.gbTestSend.Controls.Add(Me.lblFile)
        Me.gbTestSend.Controls.Add(Me.btnTestSend)
        Me.gbTestSend.Controls.Add(Me.txtTestMessage)
        Me.gbTestSend.Controls.Add(Me.txtTestPhone)
        Me.gbTestSend.Controls.Add(Me.lblTestMessage)
        Me.gbTestSend.Controls.Add(Me.lblTestPhone)
        Me.gbTestSend.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTestSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.gbTestSend.Location = New System.Drawing.Point(15, 270)
        Me.gbTestSend.Name = "gbTestSend"
        Me.gbTestSend.Padding = New System.Windows.Forms.Padding(10)
        Me.gbTestSend.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbTestSend.Size = New System.Drawing.Size(520, 255)
        Me.gbTestSend.TabIndex = 2
        Me.gbTestSend.TabStop = False
        Me.gbTestSend.Text = "📤 اختبار الإرسال"
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowseFile.FlatAppearance.BorderSize = 0
        Me.btnBrowseFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBrowseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFile.ForeColor = System.Drawing.Color.White
        Me.btnBrowseFile.Location = New System.Drawing.Point(310, 148)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(75, 27)
        Me.btnBrowseFile.TabIndex = 7
        Me.btnBrowseFile.Text = "تصفح..."
        Me.btnBrowseFile.UseVisualStyleBackColor = False
        '
        'txtFilePath
        '
        Me.txtFilePath.BackColor = System.Drawing.Color.White
        Me.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilePath.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtFilePath.Location = New System.Drawing.Point(25, 150)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(280, 23)
        Me.txtFilePath.TabIndex = 6
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblFile.Location = New System.Drawing.Point(395, 153)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(110, 19)
        Me.lblFile.TabIndex = 5
        Me.lblFile.Text = "📎 ملف (اختياري):"
        '
        'btnTestSend
        '
        Me.btnTestSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnTestSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTestSend.FlatAppearance.BorderSize = 0
        Me.btnTestSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnTestSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnTestSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestSend.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestSend.ForeColor = System.Drawing.Color.White
        Me.btnTestSend.Location = New System.Drawing.Point(25, 200)
        Me.btnTestSend.Name = "btnTestSend"
        Me.btnTestSend.Size = New System.Drawing.Size(360, 38)
        Me.btnTestSend.TabIndex = 4
        Me.btnTestSend.Text = "🚀 إرسال رسالة اختبار"
        Me.btnTestSend.UseVisualStyleBackColor = False
        '
        'txtTestMessage
        '
        Me.txtTestMessage.BackColor = System.Drawing.Color.White
        Me.txtTestMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtTestMessage.Location = New System.Drawing.Point(25, 95)
        Me.txtTestMessage.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTestMessage.Multiline = True
        Me.txtTestMessage.Name = "txtTestMessage"
        Me.txtTestMessage.Size = New System.Drawing.Size(360, 50)
        Me.txtTestMessage.TabIndex = 1
        Me.txtTestMessage.Text = "مرحبا بكم فى شركه ساب"
        '
        'txtTestPhone
        '
        Me.txtTestPhone.BackColor = System.Drawing.Color.White
        Me.txtTestPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTestPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtTestPhone.Location = New System.Drawing.Point(25, 50)
        Me.txtTestPhone.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTestPhone.Name = "txtTestPhone"
        Me.txtTestPhone.Size = New System.Drawing.Size(360, 25)
        Me.txtTestPhone.TabIndex = 0
        Me.txtTestPhone.Text = "+201017234165"
        '
        'lblTestMessage
        '
        Me.lblTestMessage.AutoSize = True
        Me.lblTestMessage.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblTestMessage.Location = New System.Drawing.Point(395, 98)
        Me.lblTestMessage.Name = "lblTestMessage"
        Me.lblTestMessage.Size = New System.Drawing.Size(79, 19)
        Me.lblTestMessage.TabIndex = 3
        Me.lblTestMessage.Text = "💬 الرسالة:"
        '
        'lblTestPhone
        '
        Me.lblTestPhone.AutoSize = True
        Me.lblTestPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lblTestPhone.Location = New System.Drawing.Point(395, 53)
        Me.lblTestPhone.Name = "lblTestPhone"
        Me.lblTestPhone.Size = New System.Drawing.Size(94, 19)
        Me.lblTestPhone.TabIndex = 2
        Me.lblTestPhone.Text = "📱 رقم الهاتف:"
        '
        'TimerQR
        '
        Me.TimerQR.Interval = 5000
        '
        'whatsappQr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(939, 529)
        Me.Controls.Add(Me.gbTestSend)
        Me.Controls.Add(Me.gbQR)
        Me.Controls.Add(Me.gbSettings)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "whatsappQr"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "💚 إعدادات WhatsApp API"
        Me.gbSettings.ResumeLayout(False)
        Me.gbSettings.PerformLayout()
        Me.gbQR.ResumeLayout(False)
        CType(Me.PicQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTestSend.ResumeLayout(False)
        Me.gbTestSend.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSettings As System.Windows.Forms.GroupBox
    Friend WithEvents txtAuthKey As System.Windows.Forms.TextBox
    Friend WithEvents txtAppKey As System.Windows.Forms.TextBox
    Friend WithEvents txtUUID As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthKey As System.Windows.Forms.Label
    Friend WithEvents lblAppKey As System.Windows.Forms.Label
    Friend WithEvents lblUUID As System.Windows.Forms.Label
    Friend WithEvents btnSaveSettings As System.Windows.Forms.Button
    Friend WithEvents btnLoadSettings As System.Windows.Forms.Button
    Friend WithEvents gbQR As System.Windows.Forms.GroupBox
    Friend WithEvents PicQrCode As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefreshQR As System.Windows.Forms.Button
    Friend WithEvents btnShowResponse As System.Windows.Forms.Button
    Friend WithEvents gbTestSend As System.Windows.Forms.GroupBox
    Friend WithEvents txtTestPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtTestMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblTestPhone As System.Windows.Forms.Label
    Friend WithEvents lblTestMessage As System.Windows.Forms.Label
    Friend WithEvents btnTestSend As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFile As System.Windows.Forms.Button
    Friend WithEvents TimerQR As System.Windows.Forms.Timer
End Class
