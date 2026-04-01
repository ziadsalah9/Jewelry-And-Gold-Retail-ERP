<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGoldVoucherReserve
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MinPanel = New System.Windows.Forms.Panel()
        Me.lblEdit = New System.Windows.Forms.Label()
        Me.CmbVoucherNumber = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.pnlItemDetails = New System.Windows.Forms.Panel()
        Me.ChkAutocalculation = New System.Windows.Forms.CheckBox()
        Me.txtGoldPrice = New System.Windows.Forms.TextBox()
        Me.lblGoldPrice = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.txtTMakeCharge = New System.Windows.Forms.TextBox()
        Me.lblTMakeCharge = New System.Windows.Forms.Label()
        Me.txtMakeCharge = New System.Windows.Forms.TextBox()
        Me.lblMakeCharge = New System.Windows.Forms.Label()
        Me.txtGramPrice = New System.Windows.Forms.TextBox()
        Me.lblGramPrice = New System.Windows.Forms.Label()
        Me.txtQuntt = New System.Windows.Forms.TextBox()
        Me.lblQuntt = New System.Windows.Forms.Label()
        Me.lblNetCaret = New System.Windows.Forms.Label()
        Me.cmbKarat = New System.Windows.Forms.ComboBox()
        Me.ComBxGoCaret999 = New System.Windows.Forms.ComboBox()
        Me.TXTGoCaret999 = New System.Windows.Forms.TextBox()
        Me.lblNetWeight = New System.Windows.Forms.Label()
        Me.LblKart = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Bay_mazanLabel = New System.Windows.Forms.Label()
        Me.dtExpensesDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.LabDate = New System.Windows.Forms.Label()
        Me.LabDescription = New System.Windows.Forms.Label()
        Me.ComCasher = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabCasher = New System.Windows.Forms.Label()
        Me.ComGoldype = New System.Windows.Forms.ComboBox()
        Me.LabSndName = New System.Windows.Forms.Label()
        Me.Cob_Comp_nam = New System.Windows.Forms.ComboBox()
        Me.LabComName = New System.Windows.Forms.Label()
        Me.btnCompName = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colModify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colComGoldype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCob_Comp_nam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComCasher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcmbKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComBxGoCaret999 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTXTGoCaret999 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtQuntt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldtExpensesDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTxtNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtGramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtGoldPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtMakeCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtTMakeCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltxtTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeightArletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeightEnletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPriceArletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPriceEnletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPurWeightArletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPurWeightEnletters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorkerGetInv = New System.ComponentModel.BackgroundWorker()
        Me.MinPanel.SuspendLayout()
        Me.pnlItemDetails.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinPanel
        '
        Me.MinPanel.BackColor = System.Drawing.Color.Transparent
        Me.MinPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MinPanel.Controls.Add(Me.lblEdit)
        Me.MinPanel.Controls.Add(Me.CmbVoucherNumber)
        Me.MinPanel.Controls.Add(Me.BtnSave)
        Me.MinPanel.Controls.Add(Me.BtnAdd)
        Me.MinPanel.Controls.Add(Me.pnlItemDetails)
        Me.MinPanel.Controls.Add(Me.ComCasher)
        Me.MinPanel.Controls.Add(Me.Button1)
        Me.MinPanel.Controls.Add(Me.LabCasher)
        Me.MinPanel.Controls.Add(Me.ComGoldype)
        Me.MinPanel.Controls.Add(Me.LabSndName)
        Me.MinPanel.Controls.Add(Me.Cob_Comp_nam)
        Me.MinPanel.Controls.Add(Me.LabComName)
        Me.MinPanel.Controls.Add(Me.btnCompName)
        Me.MinPanel.ForeColor = System.Drawing.Color.Transparent
        Me.MinPanel.Location = New System.Drawing.Point(3, 257)
        Me.MinPanel.Name = "MinPanel"
        Me.MinPanel.Size = New System.Drawing.Size(964, 200)
        Me.MinPanel.TabIndex = 18
        '
        'lblEdit
        '
        Me.lblEdit.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEdit.Location = New System.Drawing.Point(843, -3)
        Me.lblEdit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(114, 29)
        Me.lblEdit.TabIndex = 72
        Me.lblEdit.Text = "تعديل سند"
        Me.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbVoucherNumber
        '
        Me.CmbVoucherNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbVoucherNumber.FormattingEnabled = True
        Me.CmbVoucherNumber.Location = New System.Drawing.Point(843, 30)
        Me.CmbVoucherNumber.Name = "CmbVoucherNumber"
        Me.CmbVoucherNumber.Size = New System.Drawing.Size(114, 27)
        Me.CmbVoucherNumber.TabIndex = 21
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(3, 4)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 53)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "حفظ السند"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Gray
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(137, 4)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(133, 53)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "اضافة صنف"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'pnlItemDetails
        '
        Me.pnlItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlItemDetails.Controls.Add(Me.ChkAutocalculation)
        Me.pnlItemDetails.Controls.Add(Me.txtGoldPrice)
        Me.pnlItemDetails.Controls.Add(Me.lblGoldPrice)
        Me.pnlItemDetails.Controls.Add(Me.txtTotalPrice)
        Me.pnlItemDetails.Controls.Add(Me.lblTotalPrice)
        Me.pnlItemDetails.Controls.Add(Me.txtTMakeCharge)
        Me.pnlItemDetails.Controls.Add(Me.lblTMakeCharge)
        Me.pnlItemDetails.Controls.Add(Me.txtMakeCharge)
        Me.pnlItemDetails.Controls.Add(Me.lblMakeCharge)
        Me.pnlItemDetails.Controls.Add(Me.txtGramPrice)
        Me.pnlItemDetails.Controls.Add(Me.lblGramPrice)
        Me.pnlItemDetails.Controls.Add(Me.txtQuntt)
        Me.pnlItemDetails.Controls.Add(Me.lblQuntt)
        Me.pnlItemDetails.Controls.Add(Me.lblNetCaret)
        Me.pnlItemDetails.Controls.Add(Me.cmbKarat)
        Me.pnlItemDetails.Controls.Add(Me.ComBxGoCaret999)
        Me.pnlItemDetails.Controls.Add(Me.TXTGoCaret999)
        Me.pnlItemDetails.Controls.Add(Me.lblNetWeight)
        Me.pnlItemDetails.Controls.Add(Me.LblKart)
        Me.pnlItemDetails.Controls.Add(Me.txtWeight)
        Me.pnlItemDetails.Controls.Add(Me.Bay_mazanLabel)
        Me.pnlItemDetails.Controls.Add(Me.dtExpensesDate)
        Me.pnlItemDetails.Controls.Add(Me.TxtNote)
        Me.pnlItemDetails.Controls.Add(Me.LabDate)
        Me.pnlItemDetails.Controls.Add(Me.LabDescription)
        Me.pnlItemDetails.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlItemDetails.Location = New System.Drawing.Point(3, 63)
        Me.pnlItemDetails.Name = "pnlItemDetails"
        Me.pnlItemDetails.Size = New System.Drawing.Size(954, 131)
        Me.pnlItemDetails.TabIndex = 1
        '
        'ChkAutocalculation
        '
        Me.ChkAutocalculation.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ChkAutocalculation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkAutocalculation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChkAutocalculation.Location = New System.Drawing.Point(367, 63)
        Me.ChkAutocalculation.Name = "ChkAutocalculation"
        Me.ChkAutocalculation.Size = New System.Drawing.Size(67, 58)
        Me.ChkAutocalculation.TabIndex = 211
        Me.ChkAutocalculation.Text = "حساب تلقائي"
        Me.ChkAutocalculation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ChkAutocalculation.UseVisualStyleBackColor = True
        '
        'txtGoldPrice
        '
        Me.txtGoldPrice.Location = New System.Drawing.Point(752, 94)
        Me.txtGoldPrice.Name = "txtGoldPrice"
        Me.txtGoldPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGoldPrice.Size = New System.Drawing.Size(97, 27)
        Me.txtGoldPrice.TabIndex = 6
        Me.txtGoldPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGoldPrice
        '
        Me.lblGoldPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGoldPrice.Location = New System.Drawing.Point(752, 63)
        Me.lblGoldPrice.Name = "lblGoldPrice"
        Me.lblGoldPrice.Size = New System.Drawing.Size(97, 20)
        Me.lblGoldPrice.TabIndex = 210
        Me.lblGoldPrice.Text = "سعر الذهب"
        Me.lblGoldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(435, 94)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotalPrice.Size = New System.Drawing.Size(108, 27)
        Me.txtTotalPrice.TabIndex = 9
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalPrice.Location = New System.Drawing.Point(435, 63)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(108, 20)
        Me.lblTotalPrice.TabIndex = 208
        Me.lblTotalPrice.Text = "اجمالي السعر"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTMakeCharge
        '
        Me.txtTMakeCharge.Location = New System.Drawing.Point(545, 94)
        Me.txtTMakeCharge.Name = "txtTMakeCharge"
        Me.txtTMakeCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTMakeCharge.Size = New System.Drawing.Size(108, 27)
        Me.txtTMakeCharge.TabIndex = 8
        Me.txtTMakeCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTMakeCharge
        '
        Me.lblTMakeCharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTMakeCharge.Location = New System.Drawing.Point(545, 63)
        Me.lblTMakeCharge.Name = "lblTMakeCharge"
        Me.lblTMakeCharge.Size = New System.Drawing.Size(108, 20)
        Me.lblTMakeCharge.TabIndex = 206
        Me.lblTMakeCharge.Text = "اجمالي المصنعيه"
        Me.lblTMakeCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMakeCharge
        '
        Me.txtMakeCharge.Location = New System.Drawing.Point(654, 94)
        Me.txtMakeCharge.Name = "txtMakeCharge"
        Me.txtMakeCharge.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMakeCharge.Size = New System.Drawing.Size(97, 27)
        Me.txtMakeCharge.TabIndex = 7
        Me.txtMakeCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMakeCharge
        '
        Me.lblMakeCharge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMakeCharge.Location = New System.Drawing.Point(654, 63)
        Me.lblMakeCharge.Name = "lblMakeCharge"
        Me.lblMakeCharge.Size = New System.Drawing.Size(97, 20)
        Me.lblMakeCharge.TabIndex = 204
        Me.lblMakeCharge.Text = "المصنعيه"
        Me.lblMakeCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGramPrice
        '
        Me.txtGramPrice.Location = New System.Drawing.Point(850, 94)
        Me.txtGramPrice.Name = "txtGramPrice"
        Me.txtGramPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGramPrice.Size = New System.Drawing.Size(97, 27)
        Me.txtGramPrice.TabIndex = 5
        Me.txtGramPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGramPrice
        '
        Me.lblGramPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGramPrice.Location = New System.Drawing.Point(850, 63)
        Me.lblGramPrice.Name = "lblGramPrice"
        Me.lblGramPrice.Size = New System.Drawing.Size(97, 20)
        Me.lblGramPrice.TabIndex = 202
        Me.lblGramPrice.Text = "سعر الجرام"
        Me.lblGramPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuntt
        '
        Me.txtQuntt.Location = New System.Drawing.Point(492, 31)
        Me.txtQuntt.Name = "txtQuntt"
        Me.txtQuntt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQuntt.Size = New System.Drawing.Size(82, 27)
        Me.txtQuntt.TabIndex = 4
        Me.txtQuntt.Text = "1"
        Me.txtQuntt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQuntt
        '
        Me.lblQuntt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQuntt.Location = New System.Drawing.Point(492, 0)
        Me.lblQuntt.Name = "lblQuntt"
        Me.lblQuntt.Size = New System.Drawing.Size(82, 20)
        Me.lblQuntt.TabIndex = 200
        Me.lblQuntt.Text = "العدد"
        Me.lblQuntt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetCaret
        '
        Me.lblNetCaret.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNetCaret.Location = New System.Drawing.Point(659, 0)
        Me.lblNetCaret.Name = "lblNetCaret"
        Me.lblNetCaret.Size = New System.Drawing.Size(114, 20)
        Me.lblNetCaret.TabIndex = 198
        Me.lblNetCaret.Text = "العيار الصافي"
        Me.lblNetCaret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbKarat
        '
        Me.cmbKarat.FormattingEnabled = True
        Me.cmbKarat.Location = New System.Drawing.Point(865, 31)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.Size = New System.Drawing.Size(83, 27)
        Me.cmbKarat.TabIndex = 0
        '
        'ComBxGoCaret999
        '
        Me.ComBxGoCaret999.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBxGoCaret999.FormattingEnabled = True
        Me.ComBxGoCaret999.Location = New System.Drawing.Point(659, 31)
        Me.ComBxGoCaret999.Name = "ComBxGoCaret999"
        Me.ComBxGoCaret999.Size = New System.Drawing.Size(114, 27)
        Me.ComBxGoCaret999.TabIndex = 2
        '
        'TXTGoCaret999
        '
        Me.TXTGoCaret999.Location = New System.Drawing.Point(575, 31)
        Me.TXTGoCaret999.Name = "TXTGoCaret999"
        Me.TXTGoCaret999.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTGoCaret999.Size = New System.Drawing.Size(83, 27)
        Me.TXTGoCaret999.TabIndex = 3
        Me.TXTGoCaret999.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNetWeight
        '
        Me.lblNetWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNetWeight.Location = New System.Drawing.Point(575, 0)
        Me.lblNetWeight.Name = "lblNetWeight"
        Me.lblNetWeight.Size = New System.Drawing.Size(83, 20)
        Me.lblNetWeight.TabIndex = 196
        Me.lblNetWeight.Text = "الوزن الصافي"
        Me.lblNetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblKart
        '
        Me.LblKart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblKart.Location = New System.Drawing.Point(865, 0)
        Me.LblKart.Name = "LblKart"
        Me.LblKart.Size = New System.Drawing.Size(82, 20)
        Me.LblKart.TabIndex = 193
        Me.LblKart.Text = "العيار"
        Me.LblKart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(774, 31)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWeight.Size = New System.Drawing.Size(90, 27)
        Me.txtWeight.TabIndex = 1
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bay_mazanLabel
        '
        Me.Bay_mazanLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Bay_mazanLabel.Location = New System.Drawing.Point(774, 0)
        Me.Bay_mazanLabel.Name = "Bay_mazanLabel"
        Me.Bay_mazanLabel.Size = New System.Drawing.Size(90, 20)
        Me.Bay_mazanLabel.TabIndex = 192
        Me.Bay_mazanLabel.Text = "الوزن"
        Me.Bay_mazanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtExpensesDate
        '
        Me.dtExpensesDate.CustomFormat = "dd/MM/yyyy"
        Me.dtExpensesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpensesDate.Location = New System.Drawing.Point(367, 31)
        Me.dtExpensesDate.Name = "dtExpensesDate"
        Me.dtExpensesDate.Size = New System.Drawing.Size(124, 27)
        Me.dtExpensesDate.TabIndex = 5
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(3, 30)
        Me.TxtNote.MaxLength = 255
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNote.Size = New System.Drawing.Size(360, 94)
        Me.TxtNote.TabIndex = 10
        Me.TxtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabDate
        '
        Me.LabDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabDate.Location = New System.Drawing.Point(371, 0)
        Me.LabDate.Name = "LabDate"
        Me.LabDate.Size = New System.Drawing.Size(120, 21)
        Me.LabDate.TabIndex = 6
        Me.LabDate.Text = "التاريخ"
        Me.LabDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabDescription
        '
        Me.LabDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabDescription.Location = New System.Drawing.Point(2, 0)
        Me.LabDescription.Name = "LabDescription"
        Me.LabDescription.Size = New System.Drawing.Size(361, 27)
        Me.LabDescription.TabIndex = 8
        Me.LabDescription.Text = "البيان"
        Me.LabDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComCasher
        '
        Me.ComCasher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComCasher.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComCasher.FormattingEnabled = True
        Me.ComCasher.Location = New System.Drawing.Point(270, 30)
        Me.ComCasher.Name = "ComCasher"
        Me.ComCasher.Size = New System.Drawing.Size(130, 27)
        Me.ComCasher.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(610, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 27)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabCasher
        '
        Me.LabCasher.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabCasher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabCasher.Location = New System.Drawing.Point(270, -1)
        Me.LabCasher.Name = "LabCasher"
        Me.LabCasher.Size = New System.Drawing.Size(130, 29)
        Me.LabCasher.TabIndex = 64
        Me.LabCasher.Text = "الكاشير"
        Me.LabCasher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComGoldype
        '
        Me.ComGoldype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComGoldype.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComGoldype.FormattingEnabled = True
        Me.ComGoldype.Location = New System.Drawing.Point(643, 30)
        Me.ComGoldype.Margin = New System.Windows.Forms.Padding(4)
        Me.ComGoldype.Name = "ComGoldype"
        Me.ComGoldype.Size = New System.Drawing.Size(198, 27)
        Me.ComGoldype.TabIndex = 0
        '
        'LabSndName
        '
        Me.LabSndName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabSndName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabSndName.Location = New System.Drawing.Point(610, -1)
        Me.LabSndName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSndName.Name = "LabSndName"
        Me.LabSndName.Size = New System.Drawing.Size(231, 29)
        Me.LabSndName.TabIndex = 1
        Me.LabSndName.Text = "نوع السند"
        Me.LabSndName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cob_Comp_nam
        '
        Me.Cob_Comp_nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cob_Comp_nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cob_Comp_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cob_Comp_nam.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cob_Comp_nam.FormattingEnabled = True
        Me.Cob_Comp_nam.Location = New System.Drawing.Point(430, 30)
        Me.Cob_Comp_nam.Margin = New System.Windows.Forms.Padding(4)
        Me.Cob_Comp_nam.Name = "Cob_Comp_nam"
        Me.Cob_Comp_nam.Size = New System.Drawing.Size(182, 27)
        Me.Cob_Comp_nam.TabIndex = 1
        '
        'LabComName
        '
        Me.LabComName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabComName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabComName.Location = New System.Drawing.Point(403, -1)
        Me.LabComName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabComName.Name = "LabComName"
        Me.LabComName.Size = New System.Drawing.Size(209, 29)
        Me.LabComName.TabIndex = 13
        Me.LabComName.Text = "اسم المورد/الشركه/الورشه"
        Me.LabComName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompName
        '
        Me.btnCompName.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCompName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompName.ForeColor = System.Drawing.Color.Black
        Me.btnCompName.Location = New System.Drawing.Point(399, 30)
        Me.btnCompName.Name = "btnCompName"
        Me.btnCompName.Size = New System.Drawing.Size(31, 27)
        Me.btnCompName.TabIndex = 16
        Me.btnCompName.Text = "+"
        Me.btnCompName.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colModify, Me.colComGoldype, Me.colCob_Comp_nam, Me.colComCasher, Me.colcmbKarat, Me.coltxtWeight, Me.colComBxGoCaret999, Me.colTXTGoCaret999, Me.coltxtQuntt, Me.coldtExpensesDate, Me.colTxtNote, Me.coltxtGramPrice, Me.coltxtGoldPrice, Me.coltxtMakeCharge, Me.coltxtTMakeCharge, Me.coltxtTotalPrice, Me.colCastomerid, Me.colWeightArletters, Me.colWeightEnletters, Me.colTotalPriceArletters, Me.colTotalPriceEnletters, Me.colPurWeightArletters, Me.colPurWeightEnletters})
        Me.Grid.Location = New System.Drawing.Point(3, 459)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(964, 187)
        Me.Grid.TabIndex = 7
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "coldel"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 50
        '
        'colModify
        '
        Me.colModify.HeaderText = "Modify"
        Me.colModify.Name = "colModify"
        Me.colModify.ReadOnly = True
        '
        'colComGoldype
        '
        Me.colComGoldype.HeaderText = "ComGoldype"
        Me.colComGoldype.Name = "colComGoldype"
        Me.colComGoldype.ReadOnly = True
        Me.colComGoldype.Visible = False
        '
        'colCob_Comp_nam
        '
        Me.colCob_Comp_nam.HeaderText = "Cob_Comp_nam"
        Me.colCob_Comp_nam.Name = "colCob_Comp_nam"
        Me.colCob_Comp_nam.ReadOnly = True
        Me.colCob_Comp_nam.Width = 200
        '
        'colComCasher
        '
        Me.colComCasher.HeaderText = "ComCasher"
        Me.colComCasher.Name = "colComCasher"
        Me.colComCasher.ReadOnly = True
        Me.colComCasher.Visible = False
        '
        'colcmbKarat
        '
        Me.colcmbKarat.HeaderText = "cmbKarat"
        Me.colcmbKarat.Name = "colcmbKarat"
        Me.colcmbKarat.ReadOnly = True
        '
        'coltxtWeight
        '
        Me.coltxtWeight.HeaderText = "txtWeight"
        Me.coltxtWeight.Name = "coltxtWeight"
        Me.coltxtWeight.ReadOnly = True
        '
        'colComBxGoCaret999
        '
        Me.colComBxGoCaret999.HeaderText = "ComBxGoCaret999"
        Me.colComBxGoCaret999.Name = "colComBxGoCaret999"
        Me.colComBxGoCaret999.ReadOnly = True
        Me.colComBxGoCaret999.Width = 150
        '
        'colTXTGoCaret999
        '
        Me.colTXTGoCaret999.HeaderText = "TXTGoCaret999"
        Me.colTXTGoCaret999.Name = "colTXTGoCaret999"
        Me.colTXTGoCaret999.ReadOnly = True
        '
        'coltxtQuntt
        '
        Me.coltxtQuntt.HeaderText = "txtQuntt"
        Me.coltxtQuntt.Name = "coltxtQuntt"
        Me.coltxtQuntt.ReadOnly = True
        '
        'coldtExpensesDate
        '
        Me.coldtExpensesDate.HeaderText = "dtExpensesDate"
        Me.coldtExpensesDate.Name = "coldtExpensesDate"
        Me.coldtExpensesDate.ReadOnly = True
        '
        'colTxtNote
        '
        Me.colTxtNote.HeaderText = "TxtNote"
        Me.colTxtNote.Name = "colTxtNote"
        Me.colTxtNote.ReadOnly = True
        Me.colTxtNote.Visible = False
        '
        'coltxtGramPrice
        '
        Me.coltxtGramPrice.HeaderText = "txtGramPrice"
        Me.coltxtGramPrice.Name = "coltxtGramPrice"
        Me.coltxtGramPrice.ReadOnly = True
        '
        'coltxtGoldPrice
        '
        Me.coltxtGoldPrice.HeaderText = "txtGoldPrice"
        Me.coltxtGoldPrice.Name = "coltxtGoldPrice"
        Me.coltxtGoldPrice.ReadOnly = True
        '
        'coltxtMakeCharge
        '
        Me.coltxtMakeCharge.HeaderText = "txtMakeCharge"
        Me.coltxtMakeCharge.Name = "coltxtMakeCharge"
        Me.coltxtMakeCharge.ReadOnly = True
        '
        'coltxtTMakeCharge
        '
        Me.coltxtTMakeCharge.HeaderText = "txtTMakeCharge"
        Me.coltxtTMakeCharge.Name = "coltxtTMakeCharge"
        Me.coltxtTMakeCharge.ReadOnly = True
        '
        'coltxtTotalPrice
        '
        Me.coltxtTotalPrice.HeaderText = "txtTotalPrice"
        Me.coltxtTotalPrice.Name = "coltxtTotalPrice"
        Me.coltxtTotalPrice.ReadOnly = True
        '
        'colCastomerid
        '
        Me.colCastomerid.HeaderText = "colCastomerid"
        Me.colCastomerid.Name = "colCastomerid"
        Me.colCastomerid.ReadOnly = True
        Me.colCastomerid.Visible = False
        '
        'colWeightArletters
        '
        Me.colWeightArletters.HeaderText = "WeightArletters"
        Me.colWeightArletters.Name = "colWeightArletters"
        Me.colWeightArletters.ReadOnly = True
        Me.colWeightArletters.Visible = False
        '
        'colWeightEnletters
        '
        Me.colWeightEnletters.HeaderText = "WeightEnletters"
        Me.colWeightEnletters.Name = "colWeightEnletters"
        Me.colWeightEnletters.ReadOnly = True
        Me.colWeightEnletters.Visible = False
        '
        'colTotalPriceArletters
        '
        Me.colTotalPriceArletters.HeaderText = "TotalPriceArletters"
        Me.colTotalPriceArletters.Name = "colTotalPriceArletters"
        Me.colTotalPriceArletters.ReadOnly = True
        Me.colTotalPriceArletters.Visible = False
        '
        'colTotalPriceEnletters
        '
        Me.colTotalPriceEnletters.HeaderText = "TotalPriceEnletters"
        Me.colTotalPriceEnletters.Name = "colTotalPriceEnletters"
        Me.colTotalPriceEnletters.ReadOnly = True
        Me.colTotalPriceEnletters.Visible = False
        '
        'colPurWeightArletters
        '
        Me.colPurWeightArletters.HeaderText = "PurWeightArletters"
        Me.colPurWeightArletters.Name = "colPurWeightArletters"
        Me.colPurWeightArletters.ReadOnly = True
        Me.colPurWeightArletters.Visible = False
        '
        'colPurWeightEnletters
        '
        Me.colPurWeightEnletters.HeaderText = "PurWeightEnletters"
        Me.colPurWeightEnletters.Name = "colPurWeightEnletters"
        Me.colPurWeightEnletters.ReadOnly = True
        Me.colPurWeightEnletters.Visible = False
        '
        'BackgroundWorkerGetInv
        '
        '
        'FrmGoldVoucherReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 649)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.MinPanel)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(2000, 800)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(976, 200)
        Me.Name = "FrmGoldVoucherReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سند صرف ذهب"
        Me.MinPanel.ResumeLayout(False)
        Me.pnlItemDetails.ResumeLayout(False)
        Me.pnlItemDetails.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MinPanel As Panel
    Friend WithEvents BtnAdd As Button
    Friend WithEvents pnlItemDetails As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCompName As Button
    Friend WithEvents LabCasher As Label
    Friend WithEvents ComCasher As ComboBox
    Friend WithEvents LabComName As Label
    Friend WithEvents Cob_Comp_nam As ComboBox
    Friend WithEvents ComGoldype As ComboBox
    Friend WithEvents dtExpensesDate As DateTimePicker
    Friend WithEvents LabSndName As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents LabDate As Label
    Friend WithEvents LabDescription As Label
    Friend WithEvents lblNetCaret As Label
    Friend WithEvents cmbKarat As ComboBox
    Friend WithEvents ComBxGoCaret999 As ComboBox
    Friend WithEvents TXTGoCaret999 As TextBox
    Friend WithEvents lblNetWeight As Label
    Friend WithEvents LblKart As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Bay_mazanLabel As Label
    Friend WithEvents txtQuntt As TextBox
    Friend WithEvents lblQuntt As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents txtMakeCharge As TextBox
    Friend WithEvents lblMakeCharge As Label
    Friend WithEvents txtGramPrice As TextBox
    Friend WithEvents lblGramPrice As Label
    Friend WithEvents ChkAutocalculation As CheckBox
    Friend WithEvents txtGoldPrice As TextBox
    Friend WithEvents lblGoldPrice As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents txtTMakeCharge As TextBox
    Friend WithEvents lblTMakeCharge As Label
    Friend WithEvents CmbVoucherNumber As ComboBox
    Friend WithEvents BackgroundWorkerGetInv As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblEdit As Label
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colModify As DataGridViewButtonColumn
    Friend WithEvents colComGoldype As DataGridViewTextBoxColumn
    Friend WithEvents colCob_Comp_nam As DataGridViewTextBoxColumn
    Friend WithEvents colComCasher As DataGridViewTextBoxColumn
    Friend WithEvents colcmbKarat As DataGridViewTextBoxColumn
    Friend WithEvents coltxtWeight As DataGridViewTextBoxColumn
    Friend WithEvents colComBxGoCaret999 As DataGridViewTextBoxColumn
    Friend WithEvents colTXTGoCaret999 As DataGridViewTextBoxColumn
    Friend WithEvents coltxtQuntt As DataGridViewTextBoxColumn
    Friend WithEvents coldtExpensesDate As DataGridViewTextBoxColumn
    Friend WithEvents colTxtNote As DataGridViewTextBoxColumn
    Friend WithEvents coltxtGramPrice As DataGridViewTextBoxColumn
    Friend WithEvents coltxtGoldPrice As DataGridViewTextBoxColumn
    Friend WithEvents coltxtMakeCharge As DataGridViewTextBoxColumn
    Friend WithEvents coltxtTMakeCharge As DataGridViewTextBoxColumn
    Friend WithEvents coltxtTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents colCastomerid As DataGridViewTextBoxColumn
    Friend WithEvents colWeightArletters As DataGridViewTextBoxColumn
    Friend WithEvents colWeightEnletters As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPriceArletters As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPriceEnletters As DataGridViewTextBoxColumn
    Friend WithEvents colPurWeightArletters As DataGridViewTextBoxColumn
    Friend WithEvents colPurWeightEnletters As DataGridViewTextBoxColumn
End Class
