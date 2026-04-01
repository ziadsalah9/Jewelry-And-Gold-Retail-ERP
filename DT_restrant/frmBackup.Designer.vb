<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBackup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtBackupPath = New System.Windows.Forms.TextBox()
        Me.txtRestorePath = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.prbRestore = New System.Windows.Forms.ProgressBar()
        Me.prbBackup = New System.Windows.Forms.ProgressBar()
        Me.gbRestore = New System.Windows.Forms.GroupBox()
        Me.btnRestorePath = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.gbBackup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudBackupHour = New System.Windows.Forms.NumericUpDown()
        Me.nudBackupMinute = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoBackup = New System.Windows.Forms.CheckBox()
        Me.btnSaveDefaultPath = New System.Windows.Forms.Button()
        Me.btnSavePath = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDownloadFromServer = New System.Windows.Forms.Button()
        Me.gbRestore.SuspendLayout()
        Me.gbBackup.SuspendLayout()
        CType(Me.nudBackupHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBackupMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1056, 606)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(58, 27)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1056, 632)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 27)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1056, 658)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(58, 27)
        Me.TextBox3.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1056, 675)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(58, 27)
        Me.TextBox4.TabIndex = 5
        '
        'txtBackupPath
        '
        Me.txtBackupPath.BackColor = System.Drawing.Color.Olive
        Me.txtBackupPath.Location = New System.Drawing.Point(22, 31)
        Me.txtBackupPath.Name = "txtBackupPath"
        Me.txtBackupPath.Size = New System.Drawing.Size(440, 27)
        Me.txtBackupPath.TabIndex = 8
        '
        'txtRestorePath
        '
        Me.txtRestorePath.BackColor = System.Drawing.Color.ForestGreen
        Me.txtRestorePath.Location = New System.Drawing.Point(22, 56)
        Me.txtRestorePath.Name = "txtRestorePath"
        Me.txtRestorePath.Size = New System.Drawing.Size(441, 27)
        Me.txtRestorePath.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1039, 701)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'prbRestore
        '
        Me.prbRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.prbRestore.ForeColor = System.Drawing.Color.Red
        Me.prbRestore.Location = New System.Drawing.Point(22, 116)
        Me.prbRestore.Name = "prbRestore"
        Me.prbRestore.Size = New System.Drawing.Size(440, 42)
        Me.prbRestore.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbRestore.TabIndex = 11
        '
        'prbBackup
        '
        Me.prbBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.prbBackup.ForeColor = System.Drawing.Color.Red
        Me.prbBackup.Location = New System.Drawing.Point(22, 81)
        Me.prbBackup.Name = "prbBackup"
        Me.prbBackup.Size = New System.Drawing.Size(440, 42)
        Me.prbBackup.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbBackup.TabIndex = 12
        '
        'gbRestore
        '
        Me.gbRestore.Controls.Add(Me.Label3)
        Me.gbRestore.Controls.Add(Me.prbRestore)
        Me.gbRestore.Controls.Add(Me.txtRestorePath)
        Me.gbRestore.Controls.Add(Me.btnRestorePath)
        Me.gbRestore.Controls.Add(Me.btnRestore)
        Me.gbRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRestore.Location = New System.Drawing.Point(12, 224)
        Me.gbRestore.Name = "gbRestore"
        Me.gbRestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbRestore.Size = New System.Drawing.Size(686, 185)
        Me.gbRestore.TabIndex = 13
        Me.gbRestore.TabStop = False
        Me.gbRestore.Text = "استعادة النسخ الاحتياطي"
        '
        'btnRestorePath
        '
        Me.btnRestorePath.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRestorePath.Image = Global.DT_restrant.My.Resources.Resources.Folder32
        Me.btnRestorePath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestorePath.Location = New System.Drawing.Point(471, 43)
        Me.btnRestorePath.Name = "btnRestorePath"
        Me.btnRestorePath.Size = New System.Drawing.Size(192, 52)
        Me.btnRestorePath.TabIndex = 6
        Me.btnRestorePath.Text = "مسار الاسترداد"
        Me.btnRestorePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestorePath.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRestore.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestore.Location = New System.Drawing.Point(471, 111)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(192, 52)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "استعادة نسخة احتياطية"
        Me.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'gbBackup
        '
        Me.gbBackup.Controls.Add(Me.btnDownloadFromServer)
        Me.gbBackup.Controls.Add(Me.Label2)
        Me.gbBackup.Controls.Add(Me.Label1)
        Me.gbBackup.Controls.Add(Me.nudBackupHour)
        Me.gbBackup.Controls.Add(Me.nudBackupMinute)
        Me.gbBackup.Controls.Add(Me.chkAutoBackup)
        Me.gbBackup.Controls.Add(Me.btnSaveDefaultPath)
        Me.gbBackup.Controls.Add(Me.prbBackup)
        Me.gbBackup.Controls.Add(Me.btnSavePath)
        Me.gbBackup.Controls.Add(Me.txtBackupPath)
        Me.gbBackup.Controls.Add(Me.btnSave)
        Me.gbBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBackup.Location = New System.Drawing.Point(12, 12)
        Me.gbBackup.Name = "gbBackup"
        Me.gbBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbBackup.Size = New System.Drawing.Size(688, 202)
        Me.gbBackup.TabIndex = 14
        Me.gbBackup.TabStop = False
        Me.gbBackup.Text = "نسخ احتياطي"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "دقيقة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ساعة"
        '
        'nudBackupHour
        '
        Me.nudBackupHour.Enabled = False
        Me.nudBackupHour.Location = New System.Drawing.Point(289, 157)
        Me.nudBackupHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudBackupHour.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudBackupHour.Name = "nudBackupHour"
        Me.nudBackupHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudBackupHour.Size = New System.Drawing.Size(47, 27)
        Me.nudBackupHour.TabIndex = 16
        Me.nudBackupHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudBackupHour.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudBackupMinute
        '
        Me.nudBackupMinute.Enabled = False
        Me.nudBackupMinute.Location = New System.Drawing.Point(342, 157)
        Me.nudBackupMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudBackupMinute.Name = "nudBackupMinute"
        Me.nudBackupMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudBackupMinute.Size = New System.Drawing.Size(47, 27)
        Me.nudBackupMinute.TabIndex = 16
        Me.nudBackupMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkAutoBackup
        '
        Me.chkAutoBackup.AutoSize = True
        Me.chkAutoBackup.Location = New System.Drawing.Point(395, 159)
        Me.chkAutoBackup.Name = "chkAutoBackup"
        Me.chkAutoBackup.Size = New System.Drawing.Size(122, 23)
        Me.chkAutoBackup.TabIndex = 15
        Me.chkAutoBackup.Text = "نسخ احتياطي آلي"
        Me.chkAutoBackup.UseVisualStyleBackColor = True
        '
        'btnSaveDefaultPath
        '
        Me.btnSaveDefaultPath.Location = New System.Drawing.Point(94, 153)
        Me.btnSaveDefaultPath.Name = "btnSaveDefaultPath"
        Me.btnSaveDefaultPath.Size = New System.Drawing.Size(165, 34)
        Me.btnSaveDefaultPath.TabIndex = 13
        Me.btnSaveDefaultPath.Text = "حفظ إعدادات النسخ الآلي"
        Me.btnSaveDefaultPath.UseVisualStyleBackColor = True
        '
        'btnSavePath
        '
        Me.btnSavePath.BackColor = System.Drawing.Color.Olive
        Me.btnSavePath.Image = Global.DT_restrant.My.Resources.Resources.Folder32
        Me.btnSavePath.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSavePath.Location = New System.Drawing.Point(471, 22)
        Me.btnSavePath.Name = "btnSavePath"
        Me.btnSavePath.Size = New System.Drawing.Size(192, 52)
        Me.btnSavePath.TabIndex = 9
        Me.btnSavePath.Text = "مسار الحفظ"
        Me.btnSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSavePath.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Olive
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(471, 76)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 52)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "نسخ احتياطي"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDownloadFromServer
        '
        Me.btnDownloadFromServer.BackColor = System.Drawing.Color.Teal
        Me.btnDownloadFromServer.ForeColor = System.Drawing.Color.White
        Me.btnDownloadFromServer.Location = New System.Drawing.Point(22, 153)
        Me.btnDownloadFromServer.Name = "btnDownloadFromServer"
        Me.btnDownloadFromServer.Size = New System.Drawing.Size(192, 34)
        Me.btnDownloadFromServer.TabIndex = 18
        Me.btnDownloadFromServer.Text = "تنزيل من السيرفر البعيد"
        Me.btnDownloadFromServer.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Label3"
        '
        'frmBackup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(707, 433)
        Me.Controls.Add(Me.gbBackup)
        Me.Controls.Add(Me.gbRestore)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "النسخ الاحتياطي"
        Me.gbRestore.ResumeLayout(False)
        Me.gbRestore.PerformLayout()
        Me.gbBackup.ResumeLayout(False)
        Me.gbBackup.PerformLayout()
        CType(Me.nudBackupHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBackupMinute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePath As System.Windows.Forms.Button
    Friend WithEvents txtBackupPath As System.Windows.Forms.TextBox
    Friend WithEvents txtRestorePath As System.Windows.Forms.TextBox
    Friend WithEvents btnRestorePath As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents prbRestore As System.Windows.Forms.ProgressBar
    Friend WithEvents prbBackup As System.Windows.Forms.ProgressBar
    Friend WithEvents gbRestore As System.Windows.Forms.GroupBox
    Friend WithEvents gbBackup As System.Windows.Forms.GroupBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSaveDefaultPath As Button
    Friend WithEvents chkAutoBackup As CheckBox
    Friend WithEvents nudBackupHour As NumericUpDown
    Friend WithEvents nudBackupMinute As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDownloadFromServer As Button
End Class
