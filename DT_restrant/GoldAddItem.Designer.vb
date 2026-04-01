<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldAddItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSelectItem = New System.Windows.Forms.GroupBox()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.lblDiamondName = New System.Windows.Forms.Label()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.FO_minBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbItemData = New System.Windows.Forms.GroupBox()
        Me.txtMakeCharge = New System.Windows.Forms.TextBox()
        Me.lblMakeCharge = New System.Windows.Forms.Label()
        Me.lblKarat = New System.Windows.Forms.Label()
        Me.txtKarat = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblMetalPrice = New System.Windows.Forms.Label()
        Me.lblPricePerGram = New System.Windows.Forms.Label()
        Me.lblMetalWeight = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtMetalPrice = New System.Windows.Forms.TextBox()
        Me.txtMetalWeight = New System.Windows.Forms.TextBox()
        Me.txtPricePerGram = New System.Windows.Forms.TextBox()
        Me.lblCostPerItem = New System.Windows.Forms.Label()
        Me.txtCostPerItem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStoneName3 = New System.Windows.Forms.ComboBox()
        Me.txtStoneColor3 = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.txtStonePrice3 = New System.Windows.Forms.TextBox()
        Me.cmbStoneName2 = New System.Windows.Forms.ComboBox()
        Me.txtStoneColor2 = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.txtStonePrice2 = New System.Windows.Forms.TextBox()
        Me.cmbStoneName1 = New System.Windows.Forms.ComboBox()
        Me.lblStoneColor = New System.Windows.Forms.Label()
        Me.lblStonePrice = New System.Windows.Forms.Label()
        Me.lblStoneName = New System.Windows.Forms.Label()
        Me.lblStoneWeight = New System.Windows.Forms.Label()
        Me.txtStoneColor1 = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.txtStonePrice1 = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Add_ITEMtxtTotalPrice = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.Label()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.selInvoceDetelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.gbSelectItem.SuspendLayout()
        CType(Me.FO_minBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selInvoceDetelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSelectItem
        '
        Me.gbSelectItem.BackColor = System.Drawing.Color.Transparent
        Me.gbSelectItem.Controls.Add(Me.dtpInvoiceDate)
        Me.gbSelectItem.Controls.Add(Me.lblInvoiceDate)
        Me.gbSelectItem.Controls.Add(Me.btnSave)
        Me.gbSelectItem.Controls.Add(Me.lblBarCode)
        Me.gbSelectItem.Controls.Add(Me.lblDiamondName)
        Me.gbSelectItem.Controls.Add(Me.txtBarCode)
        Me.gbSelectItem.Controls.Add(Me.cmbItemName)
        Me.gbSelectItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbSelectItem.ForeColor = System.Drawing.Color.White
        Me.gbSelectItem.Location = New System.Drawing.Point(6, 5)
        Me.gbSelectItem.Name = "gbSelectItem"
        Me.gbSelectItem.Size = New System.Drawing.Size(973, 75)
        Me.gbSelectItem.TabIndex = 4
        Me.gbSelectItem.TabStop = False
        Me.gbSelectItem.Text = "اختر صنف"
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(213, 41)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(117, 27)
        Me.dtpInvoiceDate.TabIndex = 168
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceDate.Location = New System.Drawing.Point(213, 14)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(117, 25)
        Me.lblInvoiceDate.TabIndex = 169
        Me.lblInvoiceDate.Text = "تاريخ الفاتورة"
        Me.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(9, 25)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 39)
        Me.btnSave.TabIndex = 173
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblBarCode
        '
        Me.lblBarCode.Location = New System.Drawing.Point(794, 19)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(150, 20)
        Me.lblBarCode.TabIndex = 167
        Me.lblBarCode.Text = "باركود"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiamondName
        '
        Me.lblDiamondName.Location = New System.Drawing.Point(416, 19)
        Me.lblDiamondName.Name = "lblDiamondName"
        Me.lblDiamondName.Size = New System.Drawing.Size(292, 20)
        Me.lblDiamondName.TabIndex = 166
        Me.lblDiamondName.Text = "النوع"
        Me.lblDiamondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(794, 39)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(150, 27)
        Me.txtBarCode.TabIndex = 2
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbItemName
        '
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(416, 39)
        Me.cmbItemName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(292, 27)
        Me.cmbItemName.TabIndex = 1
        '
        'FO_minBindingSource
        '
        Me.FO_minBindingSource.DataMember = "FO_min"
        '
        'gbItemData
        '
        Me.gbItemData.BackColor = System.Drawing.Color.Transparent
        Me.gbItemData.Controls.Add(Me.txtMakeCharge)
        Me.gbItemData.Controls.Add(Me.lblMakeCharge)
        Me.gbItemData.Controls.Add(Me.lblKarat)
        Me.gbItemData.Controls.Add(Me.txtKarat)
        Me.gbItemData.Controls.Add(Me.lblQty)
        Me.gbItemData.Controls.Add(Me.lblMetalPrice)
        Me.gbItemData.Controls.Add(Me.lblPricePerGram)
        Me.gbItemData.Controls.Add(Me.lblMetalWeight)
        Me.gbItemData.Controls.Add(Me.txtQty)
        Me.gbItemData.Controls.Add(Me.txtMetalPrice)
        Me.gbItemData.Controls.Add(Me.txtMetalWeight)
        Me.gbItemData.Controls.Add(Me.txtPricePerGram)
        Me.gbItemData.Controls.Add(Me.lblCostPerItem)
        Me.gbItemData.Controls.Add(Me.txtCostPerItem)
        Me.gbItemData.Controls.Add(Me.Label1)
        Me.gbItemData.Controls.Add(Me.txtTotalPrice)
        Me.gbItemData.Controls.Add(Me.Label5)
        Me.gbItemData.Controls.Add(Me.Label4)
        Me.gbItemData.Controls.Add(Me.Label3)
        Me.gbItemData.Controls.Add(Me.cmbStoneName3)
        Me.gbItemData.Controls.Add(Me.txtStoneColor3)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight3)
        Me.gbItemData.Controls.Add(Me.txtStonePrice3)
        Me.gbItemData.Controls.Add(Me.cmbStoneName2)
        Me.gbItemData.Controls.Add(Me.txtStoneColor2)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight2)
        Me.gbItemData.Controls.Add(Me.txtStonePrice2)
        Me.gbItemData.Controls.Add(Me.cmbStoneName1)
        Me.gbItemData.Controls.Add(Me.lblStoneColor)
        Me.gbItemData.Controls.Add(Me.lblStonePrice)
        Me.gbItemData.Controls.Add(Me.lblStoneName)
        Me.gbItemData.Controls.Add(Me.lblStoneWeight)
        Me.gbItemData.Controls.Add(Me.txtStoneColor1)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight1)
        Me.gbItemData.Controls.Add(Me.txtStonePrice1)
        Me.gbItemData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbItemData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbItemData.ForeColor = System.Drawing.Color.White
        Me.gbItemData.Location = New System.Drawing.Point(6, 81)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.Size = New System.Drawing.Size(973, 139)
        Me.gbItemData.TabIndex = 5
        Me.gbItemData.TabStop = False
        Me.gbItemData.Text = "بيانات الصنف"
        '
        'txtMakeCharge
        '
        Me.txtMakeCharge.BackColor = System.Drawing.Color.White
        Me.txtMakeCharge.Location = New System.Drawing.Point(298, 102)
        Me.txtMakeCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMakeCharge.Name = "txtMakeCharge"
        Me.txtMakeCharge.Size = New System.Drawing.Size(91, 27)
        Me.txtMakeCharge.TabIndex = 195
        Me.txtMakeCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMakeCharge
        '
        Me.lblMakeCharge.ForeColor = System.Drawing.Color.White
        Me.lblMakeCharge.Location = New System.Drawing.Point(298, 76)
        Me.lblMakeCharge.Name = "lblMakeCharge"
        Me.lblMakeCharge.Size = New System.Drawing.Size(91, 25)
        Me.lblMakeCharge.TabIndex = 213
        Me.lblMakeCharge.Text = "المصنعية"
        Me.lblMakeCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKarat
        '
        Me.lblKarat.ForeColor = System.Drawing.Color.White
        Me.lblKarat.Location = New System.Drawing.Point(393, 76)
        Me.lblKarat.Name = "lblKarat"
        Me.lblKarat.Size = New System.Drawing.Size(91, 25)
        Me.lblKarat.TabIndex = 212
        Me.lblKarat.Text = "العيار"
        Me.lblKarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKarat
        '
        Me.txtKarat.BackColor = System.Drawing.Color.DarkGray
        Me.txtKarat.Location = New System.Drawing.Point(393, 102)
        Me.txtKarat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.ReadOnly = True
        Me.txtKarat.Size = New System.Drawing.Size(91, 27)
        Me.txtKarat.TabIndex = 193
        Me.txtKarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQty
        '
        Me.lblQty.ForeColor = System.Drawing.Color.White
        Me.lblQty.Location = New System.Drawing.Point(203, 76)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(91, 25)
        Me.lblQty.TabIndex = 211
        Me.lblQty.Text = "العدد"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMetalPrice
        '
        Me.lblMetalPrice.ForeColor = System.Drawing.Color.White
        Me.lblMetalPrice.Location = New System.Drawing.Point(203, 21)
        Me.lblMetalPrice.Name = "lblMetalPrice"
        Me.lblMetalPrice.Size = New System.Drawing.Size(91, 25)
        Me.lblMetalPrice.TabIndex = 206
        Me.lblMetalPrice.Text = "سعر الذهب"
        Me.lblMetalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPricePerGram
        '
        Me.lblPricePerGram.ForeColor = System.Drawing.Color.White
        Me.lblPricePerGram.Location = New System.Drawing.Point(298, 21)
        Me.lblPricePerGram.Name = "lblPricePerGram"
        Me.lblPricePerGram.Size = New System.Drawing.Size(91, 25)
        Me.lblPricePerGram.TabIndex = 205
        Me.lblPricePerGram.Text = "سعر الجرام"
        Me.lblPricePerGram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMetalWeight
        '
        Me.lblMetalWeight.ForeColor = System.Drawing.Color.White
        Me.lblMetalWeight.Location = New System.Drawing.Point(393, 21)
        Me.lblMetalWeight.Name = "lblMetalWeight"
        Me.lblMetalWeight.Size = New System.Drawing.Size(91, 25)
        Me.lblMetalWeight.TabIndex = 204
        Me.lblMetalWeight.Text = "وزن الذهب"
        Me.lblMetalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.Location = New System.Drawing.Point(203, 102)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(91, 27)
        Me.txtQty.TabIndex = 203
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMetalPrice
        '
        Me.txtMetalPrice.BackColor = System.Drawing.Color.White
        Me.txtMetalPrice.Location = New System.Drawing.Point(203, 48)
        Me.txtMetalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMetalPrice.Name = "txtMetalPrice"
        Me.txtMetalPrice.Size = New System.Drawing.Size(91, 27)
        Me.txtMetalPrice.TabIndex = 188
        Me.txtMetalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMetalWeight
        '
        Me.txtMetalWeight.BackColor = System.Drawing.Color.White
        Me.txtMetalWeight.Location = New System.Drawing.Point(393, 48)
        Me.txtMetalWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMetalWeight.Name = "txtMetalWeight"
        Me.txtMetalWeight.Size = New System.Drawing.Size(91, 27)
        Me.txtMetalWeight.TabIndex = 186
        Me.txtMetalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPricePerGram
        '
        Me.txtPricePerGram.BackColor = System.Drawing.Color.White
        Me.txtPricePerGram.Location = New System.Drawing.Point(298, 48)
        Me.txtPricePerGram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPricePerGram.Name = "txtPricePerGram"
        Me.txtPricePerGram.Size = New System.Drawing.Size(91, 27)
        Me.txtPricePerGram.TabIndex = 187
        Me.txtPricePerGram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostPerItem
        '
        Me.lblCostPerItem.ForeColor = System.Drawing.Color.White
        Me.lblCostPerItem.Location = New System.Drawing.Point(11, 20)
        Me.lblCostPerItem.Name = "lblCostPerItem"
        Me.lblCostPerItem.Size = New System.Drawing.Size(109, 25)
        Me.lblCostPerItem.TabIndex = 220
        Me.lblCostPerItem.Text = "سعر الشراء"
        Me.lblCostPerItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCostPerItem
        '
        Me.txtCostPerItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtCostPerItem.Location = New System.Drawing.Point(11, 47)
        Me.txtCostPerItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCostPerItem.Name = "txtCostPerItem"
        Me.txtCostPerItem.ReadOnly = True
        Me.txtCostPerItem.Size = New System.Drawing.Size(109, 27)
        Me.txtCostPerItem.TabIndex = 219
        Me.txtCostPerItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "سعر البيع"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.White
        Me.txtTotalPrice.Location = New System.Drawing.Point(11, 101)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(109, 27)
        Me.txtTotalPrice.TabIndex = 217
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(942, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 214
        Me.Label5.Text = "3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(942, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(942, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStoneName3
        '
        Me.cmbStoneName3.FormattingEnabled = True
        Me.cmbStoneName3.Location = New System.Drawing.Point(834, 102)
        Me.cmbStoneName3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName3.Name = "cmbStoneName3"
        Me.cmbStoneName3.Size = New System.Drawing.Size(109, 27)
        Me.cmbStoneName3.TabIndex = 199
        '
        'txtStoneColor3
        '
        Me.txtStoneColor3.BackColor = System.Drawing.Color.White
        Me.txtStoneColor3.Location = New System.Drawing.Point(647, 102)
        Me.txtStoneColor3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor3.Name = "txtStoneColor3"
        Me.txtStoneColor3.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneColor3.TabIndex = 201
        Me.txtStoneColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight3
        '
        Me.txtStoneWeight3.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight3.Location = New System.Drawing.Point(741, 102)
        Me.txtStoneWeight3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight3.Name = "txtStoneWeight3"
        Me.txtStoneWeight3.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneWeight3.TabIndex = 200
        Me.txtStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStonePrice3
        '
        Me.txtStonePrice3.BackColor = System.Drawing.Color.White
        Me.txtStonePrice3.Location = New System.Drawing.Point(553, 102)
        Me.txtStonePrice3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice3.Name = "txtStonePrice3"
        Me.txtStonePrice3.Size = New System.Drawing.Size(91, 27)
        Me.txtStonePrice3.TabIndex = 202
        Me.txtStonePrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStoneName2
        '
        Me.cmbStoneName2.FormattingEnabled = True
        Me.cmbStoneName2.Location = New System.Drawing.Point(834, 75)
        Me.cmbStoneName2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName2.Name = "cmbStoneName2"
        Me.cmbStoneName2.Size = New System.Drawing.Size(109, 27)
        Me.cmbStoneName2.TabIndex = 194
        '
        'txtStoneColor2
        '
        Me.txtStoneColor2.BackColor = System.Drawing.Color.White
        Me.txtStoneColor2.Location = New System.Drawing.Point(647, 75)
        Me.txtStoneColor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor2.Name = "txtStoneColor2"
        Me.txtStoneColor2.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneColor2.TabIndex = 197
        Me.txtStoneColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight2
        '
        Me.txtStoneWeight2.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight2.Location = New System.Drawing.Point(741, 75)
        Me.txtStoneWeight2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight2.Name = "txtStoneWeight2"
        Me.txtStoneWeight2.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneWeight2.TabIndex = 196
        Me.txtStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStonePrice2
        '
        Me.txtStonePrice2.BackColor = System.Drawing.Color.White
        Me.txtStonePrice2.Location = New System.Drawing.Point(553, 75)
        Me.txtStonePrice2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice2.Name = "txtStonePrice2"
        Me.txtStonePrice2.Size = New System.Drawing.Size(91, 27)
        Me.txtStonePrice2.TabIndex = 198
        Me.txtStonePrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStoneName1
        '
        Me.cmbStoneName1.FormattingEnabled = True
        Me.cmbStoneName1.Location = New System.Drawing.Point(834, 48)
        Me.cmbStoneName1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName1.Name = "cmbStoneName1"
        Me.cmbStoneName1.Size = New System.Drawing.Size(109, 27)
        Me.cmbStoneName1.TabIndex = 189
        '
        'lblStoneColor
        '
        Me.lblStoneColor.ForeColor = System.Drawing.Color.White
        Me.lblStoneColor.Location = New System.Drawing.Point(647, 21)
        Me.lblStoneColor.Name = "lblStoneColor"
        Me.lblStoneColor.Size = New System.Drawing.Size(91, 25)
        Me.lblStoneColor.TabIndex = 209
        Me.lblStoneColor.Text = "لون الفص"
        Me.lblStoneColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStonePrice
        '
        Me.lblStonePrice.ForeColor = System.Drawing.Color.White
        Me.lblStonePrice.Location = New System.Drawing.Point(553, 21)
        Me.lblStonePrice.Name = "lblStonePrice"
        Me.lblStonePrice.Size = New System.Drawing.Size(91, 25)
        Me.lblStonePrice.TabIndex = 210
        Me.lblStonePrice.Text = "سعر الفص"
        Me.lblStonePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneName
        '
        Me.lblStoneName.ForeColor = System.Drawing.Color.White
        Me.lblStoneName.Location = New System.Drawing.Point(834, 21)
        Me.lblStoneName.Name = "lblStoneName"
        Me.lblStoneName.Size = New System.Drawing.Size(109, 25)
        Me.lblStoneName.TabIndex = 207
        Me.lblStoneName.Text = "نوع الفص"
        Me.lblStoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneWeight
        '
        Me.lblStoneWeight.ForeColor = System.Drawing.Color.White
        Me.lblStoneWeight.Location = New System.Drawing.Point(741, 21)
        Me.lblStoneWeight.Name = "lblStoneWeight"
        Me.lblStoneWeight.Size = New System.Drawing.Size(91, 25)
        Me.lblStoneWeight.TabIndex = 208
        Me.lblStoneWeight.Text = "وزن الفص"
        Me.lblStoneWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneColor1
        '
        Me.txtStoneColor1.BackColor = System.Drawing.Color.White
        Me.txtStoneColor1.Location = New System.Drawing.Point(647, 48)
        Me.txtStoneColor1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor1.Name = "txtStoneColor1"
        Me.txtStoneColor1.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneColor1.TabIndex = 191
        Me.txtStoneColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight1
        '
        Me.txtStoneWeight1.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight1.Location = New System.Drawing.Point(741, 48)
        Me.txtStoneWeight1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight1.Name = "txtStoneWeight1"
        Me.txtStoneWeight1.Size = New System.Drawing.Size(91, 27)
        Me.txtStoneWeight1.TabIndex = 190
        Me.txtStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStonePrice1
        '
        Me.txtStonePrice1.BackColor = System.Drawing.Color.White
        Me.txtStonePrice1.Location = New System.Drawing.Point(553, 48)
        Me.txtStonePrice1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice1.Name = "txtStonePrice1"
        Me.txtStonePrice1.Size = New System.Drawing.Size(91, 27)
        Me.txtStonePrice1.TabIndex = 192
        Me.txtStonePrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblTotalPrice.Location = New System.Drawing.Point(123, 497)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(136, 29)
        Me.lblTotalPrice.TabIndex = 160
        Me.lblTotalPrice.Text = "إجمالي سعر الفاتورة"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add_ITEMtxtTotalPrice
        '
        Me.Add_ITEMtxtTotalPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_ITEMtxtTotalPrice.ForeColor = System.Drawing.Color.Chartreuse
        Me.Add_ITEMtxtTotalPrice.Location = New System.Drawing.Point(11, 497)
        Me.Add_ITEMtxtTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Add_ITEMtxtTotalPrice.Name = "Add_ITEMtxtTotalPrice"
        Me.Add_ITEMtxtTotalPrice.Size = New System.Drawing.Size(104, 26)
        Me.Add_ITEMtxtTotalPrice.TabIndex = 159
        Me.Add_ITEMtxtTotalPrice.Text = "0.000"
        Me.Add_ITEMtxtTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid.BackgroundColor = System.Drawing.Color.Linen
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 46
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.Location = New System.Drawing.Point(6, 226)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(973, 232)
        Me.grid.TabIndex = 165
        '
        'lblInvNo
        '
        Me.lblInvNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvNo.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblInvNo.Location = New System.Drawing.Point(840, 497)
        Me.lblInvNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(136, 29)
        Me.lblInvNo.TabIndex = 167
        Me.lblInvNo.Text = "رقم الفاتورة"
        Me.lblInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Chartreuse
        Me.txtInvoiceNo.Location = New System.Drawing.Point(724, 498)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(114, 26)
        Me.txtInvoiceNo.TabIndex = 166
        Me.txtInvoiceNo.Text = "0.000"
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        '
        'selInvoceDetelsBindingSource
        '
        Me.selInvoceDetelsBindingSource.DataMember = "selInvoceDetels"
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNotes.Location = New System.Drawing.Point(6, 465)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(832, 27)
        Me.txtNotes.TabIndex = 192
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNotes
        '
        Me.lblNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblNotes.Location = New System.Drawing.Point(845, 469)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(126, 19)
        Me.lblNotes.TabIndex = 191
        Me.lblNotes.Text = "ملاحظات"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoldAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(987, 531)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.lblInvNo)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Add_ITEMtxtTotalPrice)
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.gbSelectItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GoldAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GoldAddItem"
        Me.gbSelectItem.ResumeLayout(False)
        Me.gbSelectItem.PerformLayout()
        CType(Me.FO_minBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selInvoceDetelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSelectItem As System.Windows.Forms.GroupBox
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents lblDiamondName As System.Windows.Forms.Label
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents gbItemData As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Add_ITEMtxtTotalPrice As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents selInvoceDetelsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents FO_minBindingSource As BindingSource
    Friend WithEvents FO_minTableAdapter As DT_restrantDataSetTableAdapters.FO_minTableAdapter
    Friend WithEvents SelInvoceDetelsTableAdapter As DT_restrantDataSetTableAdapters.selInvoceDetelsTableAdapter
    Friend WithEvents txtMakeCharge As TextBox
    Friend WithEvents lblMakeCharge As Label
    Friend WithEvents lblKarat As Label
    Friend WithEvents txtKarat As TextBox
    Friend WithEvents lblQty As Label
    Friend WithEvents lblMetalPrice As Label
    Friend WithEvents lblPricePerGram As Label
    Friend WithEvents lblMetalWeight As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtMetalPrice As TextBox
    Friend WithEvents txtMetalWeight As TextBox
    Friend WithEvents txtPricePerGram As TextBox
    Friend WithEvents lblCostPerItem As Label
    Friend WithEvents txtCostPerItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStoneName3 As ComboBox
    Friend WithEvents txtStoneColor3 As TextBox
    Friend WithEvents txtStoneWeight3 As TextBox
    Friend WithEvents txtStonePrice3 As TextBox
    Friend WithEvents cmbStoneName2 As ComboBox
    Friend WithEvents txtStoneColor2 As TextBox
    Friend WithEvents txtStoneWeight2 As TextBox
    Friend WithEvents txtStonePrice2 As TextBox
    Friend WithEvents cmbStoneName1 As ComboBox
    Friend WithEvents lblStoneColor As Label
    Friend WithEvents lblStonePrice As Label
    Friend WithEvents lblStoneName As Label
    Friend WithEvents lblStoneWeight As Label
    Friend WithEvents txtStoneColor1 As TextBox
    Friend WithEvents txtStoneWeight1 As TextBox
    Friend WithEvents txtStonePrice1 As TextBox
    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents lblInvoiceDate As Label
End Class
