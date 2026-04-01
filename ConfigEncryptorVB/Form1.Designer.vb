<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtConfigPath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.cboServers = New System.Windows.Forms.ComboBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.cboDatabases = New System.Windows.Forms.ComboBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConnectTimeout = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.btnOpenConnection = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblConnectTimeout = New System.Windows.Forms.Label()
        Me.grpCurrentInfo = New System.Windows.Forms.GroupBox()
        Me.cboConnectionNames = New System.Windows.Forms.ComboBox()
        Me.lblConnectionName = New System.Windows.Forms.Label()
        Me.txtCurrentConnection = New System.Windows.Forms.TextBox()
        Me.lblCurrentConn = New System.Windows.Forms.Label()
        Me.lblCurrentInfo = New System.Windows.Forms.Label()
        Me.rtbErrorDetails = New System.Windows.Forms.RichTextBox()
        Me.grpCurrentInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtConfigPath
        '
        Me.txtConfigPath.Location = New System.Drawing.Point(18, 25)
        Me.txtConfigPath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConfigPath.Name = "txtConfigPath"
        Me.txtConfigPath.ReadOnly = True
        Me.txtConfigPath.Size = New System.Drawing.Size(372, 20)
        Me.txtConfigPath.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(393, 24)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(80, 22)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "تصفح الملف..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'cboServers
        '
        Me.cboServers.FormattingEnabled = True
        Me.cboServers.Location = New System.Drawing.Point(18, 70)
        Me.cboServers.Margin = New System.Windows.Forms.Padding(2)
        Me.cboServers.Name = "cboServers"
        Me.cboServers.Size = New System.Drawing.Size(150, 21)
        Me.cboServers.TabIndex = 2
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(172, 70)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(94, 20)
        Me.txtPort.TabIndex = 14
        '
        'cboDatabases
        '
        Me.cboDatabases.FormattingEnabled = True
        Me.cboDatabases.Location = New System.Drawing.Point(268, 70)
        Me.cboDatabases.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDatabases.Name = "cboDatabases"
        Me.cboDatabases.Size = New System.Drawing.Size(206, 21)
        Me.cboDatabases.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(18, 119)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(206, 20)
        Me.txtUser.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(268, 119)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtConnectTimeout
        '
        Me.txtConnectTimeout.Location = New System.Drawing.Point(422, 119)
        Me.txtConnectTimeout.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConnectTimeout.Name = "txtConnectTimeout"
        Me.txtConnectTimeout.Size = New System.Drawing.Size(52, 20)
        Me.txtConnectTimeout.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(18, 162)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(225, 28)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "حفظ + تشفير connectionStrings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Location = New System.Drawing.Point(248, 162)
        Me.btnTestConnection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(148, 28)
        Me.btnTestConnection.TabIndex = 12
        Me.btnTestConnection.Text = "اختبار الاتصال"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'btnOpenConnection
        '
        Me.btnOpenConnection.Location = New System.Drawing.Point(401, 162)
        Me.btnOpenConnection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOpenConnection.Name = "btnOpenConnection"
        Me.btnOpenConnection.Size = New System.Drawing.Size(72, 28)
        Me.btnOpenConnection.TabIndex = 13
        Me.btnOpenConnection.Text = "فتح الاتصال"
        Me.btnOpenConnection.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(18, 55)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(44, 13)
        Me.lbl1.TabIndex = 7
        Me.lbl1.Text = "السيرفر"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(172, 55)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(30, 13)
        Me.lblPort.TabIndex = 15
        Me.lblPort.Text = "البورت"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(268, 55)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(68, 13)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "قاعدة البيانات"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(18, 102)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(111, 13)
        Me.lbl3.TabIndex = 9
        Me.lbl3.Text = "اسم المستخدم (SQL)"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(268, 102)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(59, 13)
        Me.lbl4.TabIndex = 10
        Me.lbl4.Text = "كلمة المرور"
        '
        'lblConnectTimeout
        '
        Me.lblConnectTimeout.AutoSize = True
        Me.lblConnectTimeout.Location = New System.Drawing.Point(422, 102)
        Me.lblConnectTimeout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConnectTimeout.Name = "lblConnectTimeout"
        Me.lblConnectTimeout.Size = New System.Drawing.Size(52, 13)
        Me.lblConnectTimeout.TabIndex = 17
        Me.lblConnectTimeout.Text = "Timeout"
        '
        'grpCurrentInfo
        '
        Me.grpCurrentInfo.Controls.Add(Me.cboConnectionNames)
        Me.grpCurrentInfo.Controls.Add(Me.lblConnectionName)
        Me.grpCurrentInfo.Controls.Add(Me.txtCurrentConnection)
        Me.grpCurrentInfo.Controls.Add(Me.lblCurrentConn)
        Me.grpCurrentInfo.Controls.Add(Me.lblCurrentInfo)
        Me.grpCurrentInfo.Location = New System.Drawing.Point(18, 195)
        Me.grpCurrentInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCurrentInfo.Name = "grpCurrentInfo"
        Me.grpCurrentInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCurrentInfo.Size = New System.Drawing.Size(455, 200)
        Me.grpCurrentInfo.TabIndex = 11
        Me.grpCurrentInfo.TabStop = False
        Me.grpCurrentInfo.Text = "المعلومات الحالية من ملف الكونفيج"
        '
        'cboConnectionNames
        '
        Me.cboConnectionNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConnectionNames.FormattingEnabled = True
        Me.cboConnectionNames.Location = New System.Drawing.Point(5, 18)
        Me.cboConnectionNames.Margin = New System.Windows.Forms.Padding(2)
        Me.cboConnectionNames.Name = "cboConnectionNames"
        Me.cboConnectionNames.Size = New System.Drawing.Size(445, 21)
        Me.cboConnectionNames.TabIndex = 3
        '
        'lblConnectionName
        '
        Me.lblConnectionName.AutoSize = True
        Me.lblConnectionName.Location = New System.Drawing.Point(5, 3)
        Me.lblConnectionName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConnectionName.Name = "lblConnectionName"
        Me.lblConnectionName.Size = New System.Drawing.Size(87, 13)
        Me.lblConnectionName.TabIndex = 4
        Me.lblConnectionName.Text = "اختر Connection:"
        '
        'txtCurrentConnection
        '
        Me.txtCurrentConnection.BackColor = System.Drawing.SystemColors.Control
        Me.txtCurrentConnection.Location = New System.Drawing.Point(5, 70)
        Me.txtCurrentConnection.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCurrentConnection.Multiline = True
        Me.txtCurrentConnection.Name = "txtCurrentConnection"
        Me.txtCurrentConnection.ReadOnly = True
        Me.txtCurrentConnection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCurrentConnection.Size = New System.Drawing.Size(445, 119)
        Me.txtCurrentConnection.TabIndex = 2
        '
        'lblCurrentConn
        '
        Me.lblCurrentConn.AutoSize = True
        Me.lblCurrentConn.Location = New System.Drawing.Point(5, 55)
        Me.lblCurrentConn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentConn.Name = "lblCurrentConn"
        Me.lblCurrentConn.Size = New System.Drawing.Size(96, 13)
        Me.lblCurrentConn.TabIndex = 1
        Me.lblCurrentConn.Text = "Connection String:"
        '
        'lblCurrentInfo
        '
        Me.lblCurrentInfo.AutoSize = True
        Me.lblCurrentInfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCurrentInfo.Location = New System.Drawing.Point(5, 42)
        Me.lblCurrentInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentInfo.Name = "lblCurrentInfo"
        Me.lblCurrentInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentInfo.TabIndex = 0
        '
        'rtbErrorDetails
        '
        Me.rtbErrorDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.rtbErrorDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbErrorDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbErrorDetails.ForeColor = System.Drawing.Color.White
        Me.rtbErrorDetails.Location = New System.Drawing.Point(18, 400)
        Me.rtbErrorDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbErrorDetails.Name = "rtbErrorDetails"
        Me.rtbErrorDetails.ReadOnly = True
        Me.rtbErrorDetails.Size = New System.Drawing.Size(455, 120)
        Me.rtbErrorDetails.TabIndex = 18
        Me.rtbErrorDetails.Text = ""
        Me.rtbErrorDetails.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 530)
        Me.Controls.Add(Me.rtbErrorDetails)
        Me.Controls.Add(Me.grpCurrentInfo)
        Me.Controls.Add(Me.lblConnectTimeout)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnOpenConnection)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtConnectTimeout)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.cboDatabases)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.cboServers)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtConfigPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Config Encryptor (connectionStrings)"
        Me.grpCurrentInfo.ResumeLayout(False)
        Me.grpCurrentInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtConfigPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents cboServers As System.Windows.Forms.ComboBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents cboDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtConnectTimeout As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lblConnectTimeout As System.Windows.Forms.Label
    Friend WithEvents grpCurrentInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblCurrentInfo As System.Windows.Forms.Label
    Friend WithEvents txtCurrentConnection As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentConn As System.Windows.Forms.Label
    Friend WithEvents cboConnectionNames As System.Windows.Forms.ComboBox
    Friend WithEvents lblConnectionName As System.Windows.Forms.Label
    Friend WithEvents btnTestConnection As System.Windows.Forms.Button
    Friend WithEvents btnOpenConnection As System.Windows.Forms.Button
    Friend WithEvents rtbErrorDetails As System.Windows.Forms.RichTextBox
End Class