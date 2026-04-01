<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhatsAppSettings
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dtGreid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomCivilID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomAdr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMsgText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFilePath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMsgStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnSignOut = New System.Windows.Forms.Button()
        Me.btnBros = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtphonNom = New System.Windows.Forms.TextBox()
        Me.txtMsges = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackWorkGetQr = New System.ComponentModel.BackgroundWorker()
        Me.CBoxNameActive = New System.Windows.Forms.CheckBox()
        Me.CBoxCivilIdActive = New System.Windows.Forms.CheckBox()
        Me.CBoxAddressActive = New System.Windows.Forms.CheckBox()
        Me.gbLoad = New System.Windows.Forms.GroupBox()
        Me.lblFilePth = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.BtnLoodFromDt = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDell = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colMsg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFillPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.txtFillPath = New System.Windows.Forms.TextBox()
        Me.lblFillPath = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.BtnAddMsg = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.PicQrCode = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtGreid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLoad.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'dtGreid
        '
        Me.dtGreid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGreid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colID, Me.colCastomName, Me.colCastomNo, Me.colCastomCivilID, Me.colCastomAdr, Me.colMsgText, Me.colFilePath, Me.colMsgStatus})
        Me.dtGreid.Location = New System.Drawing.Point(280, 76)
        Me.dtGreid.Name = "dtGreid"
        Me.dtGreid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtGreid.Size = New System.Drawing.Size(692, 241)
        Me.dtGreid.TabIndex = 6
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Width = 40
        '
        'colID
        '
        Me.colID.HeaderText = "NO."
        Me.colID.Name = "colID"
        '
        'colCastomName
        '
        Me.colCastomName.HeaderText = "CastomName"
        Me.colCastomName.Name = "colCastomName"
        Me.colCastomName.Width = 150
        '
        'colCastomNo
        '
        Me.colCastomNo.HeaderText = "CastomNo"
        Me.colCastomNo.Name = "colCastomNo"
        Me.colCastomNo.Width = 150
        '
        'colCastomCivilID
        '
        Me.colCastomCivilID.HeaderText = "CastomCivilID"
        Me.colCastomCivilID.Name = "colCastomCivilID"
        Me.colCastomCivilID.Width = 150
        '
        'colCastomAdr
        '
        Me.colCastomAdr.HeaderText = "CastomAdr"
        Me.colCastomAdr.Name = "colCastomAdr"
        Me.colCastomAdr.Width = 150
        '
        'colMsgText
        '
        Me.colMsgText.HeaderText = "MsgText"
        Me.colMsgText.Name = "colMsgText"
        '
        'colFilePath
        '
        Me.colFilePath.HeaderText = "FilePath"
        Me.colFilePath.Name = "colFilePath"
        '
        'colMsgStatus
        '
        Me.colMsgStatus.HeaderText = "MsgStatus"
        Me.colMsgStatus.Name = "colMsgStatus"
        '
        'BtnSignOut
        '
        Me.BtnSignOut.Location = New System.Drawing.Point(6, 6)
        Me.BtnSignOut.Name = "BtnSignOut"
        Me.BtnSignOut.Size = New System.Drawing.Size(268, 42)
        Me.BtnSignOut.TabIndex = 16
        Me.BtnSignOut.Text = "تسجيل دخول"
        Me.BtnSignOut.UseVisualStyleBackColor = True
        '
        'btnBros
        '
        Me.btnBros.Location = New System.Drawing.Point(1134, 329)
        Me.btnBros.Name = "btnBros"
        Me.btnBros.Size = New System.Drawing.Size(103, 33)
        Me.btnBros.TabIndex = 15
        Me.btnBros.Text = "اضغط لارفاق ملف"
        Me.btnBros.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1092, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ارفاق ملف"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(1243, 329)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(160, 20)
        Me.txtFile.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1099, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "الرساله"
        '
        'btnSent
        '
        Me.btnSent.Location = New System.Drawing.Point(1006, 258)
        Me.btnSent.Name = "btnSent"
        Me.btnSent.Size = New System.Drawing.Size(122, 104)
        Me.btnSent.TabIndex = 8
        Me.btnSent.Text = "ارسال"
        Me.btnSent.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1080, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "الرقم"
        '
        'txtphonNom
        '
        Me.txtphonNom.Location = New System.Drawing.Point(1134, 258)
        Me.txtphonNom.Name = "txtphonNom"
        Me.txtphonNom.Size = New System.Drawing.Size(269, 20)
        Me.txtphonNom.TabIndex = 9
        Me.txtphonNom.Text = "96591111925"
        '
        'txtMsges
        '
        Me.txtMsges.Location = New System.Drawing.Point(1134, 294)
        Me.txtMsges.Name = "txtMsges"
        Me.txtMsges.Size = New System.Drawing.Size(269, 20)
        Me.txtMsges.TabIndex = 10
        Me.txtMsges.Text = "مرحبا بكم فى شركه ساب "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        '
        'BackWorkGetQr
        '
        '
        'CBoxNameActive
        '
        Me.CBoxNameActive.Location = New System.Drawing.Point(798, 29)
        Me.CBoxNameActive.Name = "CBoxNameActive"
        Me.CBoxNameActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBoxNameActive.Size = New System.Drawing.Size(82, 24)
        Me.CBoxNameActive.TabIndex = 17
        Me.CBoxNameActive.Text = "الاسم"
        Me.CBoxNameActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBoxNameActive.UseVisualStyleBackColor = True
        '
        'CBoxCivilIdActive
        '
        Me.CBoxCivilIdActive.Location = New System.Drawing.Point(691, 29)
        Me.CBoxCivilIdActive.Name = "CBoxCivilIdActive"
        Me.CBoxCivilIdActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBoxCivilIdActive.Size = New System.Drawing.Size(104, 24)
        Me.CBoxCivilIdActive.TabIndex = 18
        Me.CBoxCivilIdActive.Text = "الرقم المدني"
        Me.CBoxCivilIdActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBoxCivilIdActive.UseVisualStyleBackColor = True
        '
        'CBoxAddressActive
        '
        Me.CBoxAddressActive.Location = New System.Drawing.Point(606, 29)
        Me.CBoxAddressActive.Name = "CBoxAddressActive"
        Me.CBoxAddressActive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBoxAddressActive.Size = New System.Drawing.Size(82, 24)
        Me.CBoxAddressActive.TabIndex = 19
        Me.CBoxAddressActive.Text = "العنوان"
        Me.CBoxAddressActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBoxAddressActive.UseVisualStyleBackColor = True
        '
        'gbLoad
        '
        Me.gbLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLoad.Controls.Add(Me.lblFilePth)
        Me.gbLoad.Controls.Add(Me.btnBrowse)
        Me.gbLoad.Controls.Add(Me.cmbSheet)
        Me.gbLoad.Controls.Add(Me.lblSheetName)
        Me.gbLoad.Controls.Add(Me.txtFilePath)
        Me.gbLoad.Controls.Add(Me.btnHelp)
        Me.gbLoad.Controls.Add(Me.BtnLoodFromDt)
        Me.gbLoad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbLoad.Location = New System.Drawing.Point(280, 6)
        Me.gbLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLoad.Name = "gbLoad"
        Me.gbLoad.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbLoad.Size = New System.Drawing.Size(693, 69)
        Me.gbLoad.TabIndex = 21
        Me.gbLoad.TabStop = False
        Me.gbLoad.Text = "تحميل جهات الاتصال"
        '
        'lblFilePth
        '
        Me.lblFilePth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFilePth.Location = New System.Drawing.Point(107, 17)
        Me.lblFilePth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilePth.Name = "lblFilePth"
        Me.lblFilePth.Size = New System.Drawing.Size(277, 19)
        Me.lblFilePth.TabIndex = 9
        Me.lblFilePth.Text = "اسم الورقة :"
        Me.lblFilePth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.Location = New System.Drawing.Point(105, 39)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(42, 27)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'cmbSheet
        '
        Me.cmbSheet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSheet.DropDownHeight = 120
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.IntegralHeight = False
        Me.cmbSheet.Location = New System.Drawing.Point(7, 39)
        Me.cmbSheet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(95, 27)
        Me.cmbSheet.TabIndex = 6
        '
        'lblSheetName
        '
        Me.lblSheetName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSheetName.Location = New System.Drawing.Point(7, 17)
        Me.lblSheetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(95, 19)
        Me.lblSheetName.TabIndex = 0
        Me.lblSheetName.Text = "اسم الورقة :"
        Me.lblSheetName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFilePath.Location = New System.Drawing.Point(150, 39)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(233, 27)
        Me.txtFilePath.TabIndex = 1
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHelp.Location = New System.Drawing.Point(541, 17)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(145, 50)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "نموزج فارغ"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'BtnLoodFromDt
        '
        Me.BtnLoodFromDt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLoodFromDt.Location = New System.Drawing.Point(385, 17)
        Me.BtnLoodFromDt.Name = "BtnLoodFromDt"
        Me.BtnLoodFromDt.Size = New System.Drawing.Size(157, 51)
        Me.BtnLoodFromDt.TabIndex = 7
        Me.BtnLoodFromDt.Text = "من البرنامج"
        Me.BtnLoodFromDt.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDell, Me.colMsg, Me.colFillPath})
        Me.Grid.Location = New System.Drawing.Point(7, 71)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Grid.RowHeadersVisible = False
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(963, 121)
        Me.Grid.TabIndex = 22
        '
        'colDell
        '
        Me.colDell.HeaderText = "Dell"
        Me.colDell.MinimumWidth = 40
        Me.colDell.Name = "colDell"
        Me.colDell.ReadOnly = True
        '
        'colMsg
        '
        Me.colMsg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMsg.HeaderText = "msg"
        Me.colMsg.Name = "colMsg"
        Me.colMsg.ReadOnly = True
        Me.colMsg.Width = 504
        '
        'colFillPath
        '
        Me.colFillPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colFillPath.HeaderText = "FillPath"
        Me.colFillPath.Name = "colFillPath"
        Me.colFillPath.ReadOnly = True
        Me.colFillPath.Width = 455
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMsg.Location = New System.Drawing.Point(424, 20)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(544, 19)
        Me.lblMsg.TabIndex = 11
        Me.lblMsg.Text = "نص الرساله"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFillPath
        '
        Me.txtFillPath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFillPath.Location = New System.Drawing.Point(33, 42)
        Me.txtFillPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFillPath.Name = "txtFillPath"
        Me.txtFillPath.ReadOnly = True
        Me.txtFillPath.Size = New System.Drawing.Size(388, 27)
        Me.txtFillPath.TabIndex = 23
        Me.txtFillPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFillPath
        '
        Me.lblFillPath.Location = New System.Drawing.Point(7, 20)
        Me.lblFillPath.Name = "lblFillPath"
        Me.lblFillPath.Size = New System.Drawing.Size(414, 23)
        Me.lblFillPath.TabIndex = 24
        Me.lblFillPath.TabStop = True
        Me.lblFillPath.Text = "اضغط لارفاق ملف"
        Me.lblFillPath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMsg)
        Me.GroupBox1.Controls.Add(Me.BtnAddMsg)
        Me.GroupBox1.Controls.Add(Me.lblFillPath)
        Me.GroupBox1.Controls.Add(Me.txtFillPath)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblMsg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Grid)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(974, 198)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اضافة نص الرساله"
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(424, 43)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(546, 27)
        Me.txtMsg.TabIndex = 25
        Me.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddMsg
        '
        Me.BtnAddMsg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAddMsg.Location = New System.Drawing.Point(7, 42)
        Me.BtnAddMsg.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAddMsg.Name = "BtnAddMsg"
        Me.BtnAddMsg.Size = New System.Drawing.Size(27, 27)
        Me.BtnAddMsg.TabIndex = 10
        Me.BtnAddMsg.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBoxNameActive)
        Me.GroupBox2.Controls.Add(Me.CBoxCivilIdActive)
        Me.GroupBox2.Controls.Add(Me.CBoxAddressActive)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(94, 523)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(886, 72)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ضبط اعدادات الارسال"
        '
        'BtnStart
        '
        Me.BtnStart.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Location = New System.Drawing.Point(6, 528)
        Me.BtnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(81, 67)
        Me.BtnStart.TabIndex = 26
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'PicQrCode
        '
        Me.PicQrCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicQrCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicQrCode.Location = New System.Drawing.Point(6, 54)
        Me.PicQrCode.Name = "PicQrCode"
        Me.PicQrCode.Size = New System.Drawing.Size(268, 263)
        Me.PicQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicQrCode.TabIndex = 0
        Me.PicQrCode.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1062, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WhatsAppSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1449, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbLoad)
        Me.Controls.Add(Me.BtnSignOut)
        Me.Controls.Add(Me.btnBros)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.PicQrCode)
        Me.Controls.Add(Me.dtGreid)
        Me.Controls.Add(Me.txtMsges)
        Me.Controls.Add(Me.txtphonNom)
        Me.Controls.Add(Me.btnSent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WhatsAppSettings"
        Me.Text = "WhatsAppSettings"
        CType(Me.dtGreid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLoad.ResumeLayout(False)
        Me.gbLoad.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicQrCode As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dtGreid As System.Windows.Forms.DataGridView
    Friend WithEvents BtnLoodFromDt As System.Windows.Forms.Button
    Friend WithEvents btnBros As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtphonNom As System.Windows.Forms.TextBox
    Friend WithEvents txtMsges As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BtnSignOut As System.Windows.Forms.Button
    Friend WithEvents BackWorkGetQr As System.ComponentModel.BackgroundWorker
    Friend WithEvents CBoxNameActive As System.Windows.Forms.CheckBox
    Friend WithEvents CBoxCivilIdActive As System.Windows.Forms.CheckBox
    Friend WithEvents CBoxAddressActive As System.Windows.Forms.CheckBox
    Friend WithEvents gbLoad As System.Windows.Forms.GroupBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents cmbSheet As System.Windows.Forms.ComboBox
    Friend WithEvents lblSheetName As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFilePth As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents txtFillPath As System.Windows.Forms.TextBox
    Friend WithEvents lblFillPath As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddMsg As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colDell As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colMsg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFillPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCastomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCastomNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCastomCivilID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCastomAdr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMsgText As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFilePath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMsgStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
