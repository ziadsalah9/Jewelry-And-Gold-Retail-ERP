<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SilverInvoice
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SilverInvoice))
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.CastomeridTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Item_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Item_despTextBox = New System.Windows.Forms.TextBox()
        Me.Item_GramPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Item_gramTextBox = New System.Windows.Forms.TextBox()
        Me.Item_gramMadeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_extrasPRICETextBox = New System.Windows.Forms.TextBox()
        Me.Item_extrasMAZANTextBox = New System.Windows.Forms.TextBox()
        Me.Item_totalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.CashTextBox = New System.Windows.Forms.TextBox()
        Me.Item_cantreyTextBox = New System.Windows.Forms.TextBox()
        Me.Invoc_timeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CacherIDTextBox = New System.Windows.Forms.TextBox()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Invoc_timeTextBox = New System.Windows.Forms.TextBox()
        Me.Item_totalPriceTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Invoc_date_timeTextBox = New System.Windows.Forms.TextBox()
        Me.CashTextBox1 = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colModify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCastomerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcacher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledMakeCharge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalGoledPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledPiecesQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonWeight1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonColor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonPrice1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonWeight2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonColor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonPrice2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonName3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonWeight3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonColor3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonPrice3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledPurchasPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSroomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvocDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemCantrey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePriceType1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePriceType2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePriceType3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTaxTextAm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTaxAmo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.BtnTax = New System.Windows.Forms.Button()
        Me.lblPr = New System.Windows.Forms.Label()
        Me.txtTaxAmo = New System.Windows.Forms.TextBox()
        Me.txtTaxTextAm = New System.Windows.Forms.TextBox()
        Me.lblTaxAm = New System.Windows.Forms.Label()
        Me.txtMakeCharge = New System.Windows.Forms.TextBox()
        Me.btnItemName = New System.Windows.Forms.Button()
        Me.btnPayPrint = New System.Windows.Forms.Button()
        Me.lblMakeCharge = New System.Windows.Forms.Label()
        Me.labItemNmeInInvoce = New System.Windows.Forms.Label()
        Me.txtItemNmeInInvoce = New System.Windows.Forms.TextBox()
        Me.lblKarat = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtKarat = New System.Windows.Forms.TextBox()
        Me.lblInvoiceDate = New System.Windows.Forms.Label()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.lblMetalPrice = New System.Windows.Forms.Label()
        Me.lblPricePerGram = New System.Windows.Forms.Label()
        Me.cmbStoneName3 = New System.Windows.Forms.ComboBox()
        Me.txtStonePrice3 = New System.Windows.Forms.TextBox()
        Me.lblMetalWeight = New System.Windows.Forms.Label()
        Me.cmbStoneName2 = New System.Windows.Forms.ComboBox()
        Me.txtStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtStoneColor2 = New System.Windows.Forms.TextBox()
        Me.txtStoneColor3 = New System.Windows.Forms.TextBox()
        Me.txtMetalPrice = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.txtCostPerItem = New System.Windows.Forms.TextBox()
        Me.txtStonePrice2 = New System.Windows.Forms.TextBox()
        Me.txtMetalWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStonePrice1 = New System.Windows.Forms.TextBox()
        Me.cmbStoneName1 = New System.Windows.Forms.ComboBox()
        Me.txtPricePerGram = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.lblStoneColor = New System.Windows.Forms.Label()
        Me.lblCostPerItem = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStoneColor1 = New System.Windows.Forms.TextBox()
        Me.lblStonePrice = New System.Windows.Forms.Label()
        Me.lblStoneWeight = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblStoneName = New System.Windows.Forms.Label()
        Me.NotsTextBox = New System.Windows.Forms.TextBox()
        Me.QuntTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Inv_startTextBox = New System.Windows.Forms.TextBox()
        Me.Saryal_maxTextBox = New System.Windows.Forms.TextBox()
        Me.Loc_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Comp_note1TextBox = New System.Windows.Forms.TextBox()
        Me.Sroom_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Inv_startTextBox1 = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR147TextBox = New System.Windows.Forms.TextBox()
        Me.SignaturePictureBox = New System.Windows.Forms.PictureBox()
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.StonePriceType3TextBox = New System.Windows.Forms.TextBox()
        Me.StonePriceType2TextBox = New System.Windows.Forms.TextBox()
        Me.StonePriceType1TextBox = New System.Windows.Forms.TextBox()
        Me.CacherTextBox = New System.Windows.Forms.TextBox()
        Me.ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR169TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR168TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR167TextBox = New System.Windows.Forms.TextBox()
        Me.StoneWeight3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StonePrice3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneColor3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneName3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneWeight2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StonePrice2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneColor2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneName2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneColor1TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneName1TextBox = New System.Windows.Forms.TextBox()
        Me.ActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SET_INVARCHR151TextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTotalPriceTitle = New System.Windows.Forms.Label()
        Me.txtTotalPriceValue = New System.Windows.Forms.TextBox()
        Me.txtTpriceTtax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblInvoiceValue = New System.Windows.Forms.Label()
        Me.lblInvoiceTitle = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignaturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBarCode
        '
        Me.txtBarCode.BackColor = System.Drawing.Color.White
        Me.txtBarCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBarCode.Location = New System.Drawing.Point(676, 50)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(144, 27)
        Me.txtBarCode.TabIndex = 20
        Me.txtBarCode.TabStop = False
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDTextBox1
        '
        Me.IDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDTextBox1.Location = New System.Drawing.Point(25, 50)
        Me.IDTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(51, 27)
        Me.IDTextBox1.TabIndex = 48
        '
        'CastomeridTextBox
        '
        Me.CastomeridTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomeridTextBox.Location = New System.Drawing.Point(25, 77)
        Me.CastomeridTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CastomeridTextBox.Name = "CastomeridTextBox"
        Me.CastomeridTextBox.Size = New System.Drawing.Size(51, 27)
        Me.CastomeridTextBox.TabIndex = 50
        '
        'UserIDTextBox1
        '
        Me.UserIDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDTextBox1.Location = New System.Drawing.Point(25, 131)
        Me.UserIDTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UserIDTextBox1.Name = "UserIDTextBox1"
        Me.UserIDTextBox1.Size = New System.Drawing.Size(51, 27)
        Me.UserIDTextBox1.TabIndex = 54
        '
        'Item_nameTextBox
        '
        Me.Item_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_nameTextBox.Location = New System.Drawing.Point(25, 158)
        Me.Item_nameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_nameTextBox.Name = "Item_nameTextBox"
        Me.Item_nameTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_nameTextBox.TabIndex = 56
        '
        'Item_despTextBox
        '
        Me.Item_despTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_despTextBox.Location = New System.Drawing.Point(25, 185)
        Me.Item_despTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_despTextBox.Name = "Item_despTextBox"
        Me.Item_despTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_despTextBox.TabIndex = 58
        '
        'Item_GramPriceTextBox
        '
        Me.Item_GramPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_GramPriceTextBox.Location = New System.Drawing.Point(25, 401)
        Me.Item_GramPriceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_GramPriceTextBox.Name = "Item_GramPriceTextBox"
        Me.Item_GramPriceTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_GramPriceTextBox.TabIndex = 60
        '
        'Item_gramTextBox
        '
        Me.Item_gramTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_gramTextBox.Location = New System.Drawing.Point(25, 374)
        Me.Item_gramTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_gramTextBox.Name = "Item_gramTextBox"
        Me.Item_gramTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_gramTextBox.TabIndex = 62
        '
        'Item_gramMadeTextBox
        '
        Me.Item_gramMadeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_gramMadeTextBox.Location = New System.Drawing.Point(25, 347)
        Me.Item_gramMadeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_gramMadeTextBox.Name = "Item_gramMadeTextBox"
        Me.Item_gramMadeTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_gramMadeTextBox.TabIndex = 64
        '
        'Item_extrasPRICETextBox
        '
        Me.Item_extrasPRICETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_extrasPRICETextBox.Location = New System.Drawing.Point(-26, 104)
        Me.Item_extrasPRICETextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_extrasPRICETextBox.Name = "Item_extrasPRICETextBox"
        Me.Item_extrasPRICETextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_extrasPRICETextBox.TabIndex = 66
        '
        'Item_extrasMAZANTextBox
        '
        Me.Item_extrasMAZANTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_extrasMAZANTextBox.Location = New System.Drawing.Point(-26, 131)
        Me.Item_extrasMAZANTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_extrasMAZANTextBox.Name = "Item_extrasMAZANTextBox"
        Me.Item_extrasMAZANTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_extrasMAZANTextBox.TabIndex = 68
        '
        'Item_totalPriceTextBox
        '
        Me.Item_totalPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_totalPriceTextBox.Location = New System.Drawing.Point(25, 266)
        Me.Item_totalPriceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_totalPriceTextBox.Name = "Item_totalPriceTextBox"
        Me.Item_totalPriceTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_totalPriceTextBox.TabIndex = 70
        '
        'CashTextBox
        '
        Me.CashTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CashTextBox.Location = New System.Drawing.Point(-26, 374)
        Me.CashTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.Size = New System.Drawing.Size(51, 27)
        Me.CashTextBox.TabIndex = 72
        '
        'Item_cantreyTextBox
        '
        Me.Item_cantreyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_cantreyTextBox.Location = New System.Drawing.Point(25, 212)
        Me.Item_cantreyTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_cantreyTextBox.Name = "Item_cantreyTextBox"
        Me.Item_cantreyTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Item_cantreyTextBox.TabIndex = 75
        '
        'Invoc_timeDateTimePicker
        '
        Me.Invoc_timeDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoc_timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Invoc_timeDateTimePicker.Location = New System.Drawing.Point(-26, 401)
        Me.Invoc_timeDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Invoc_timeDateTimePicker.Name = "Invoc_timeDateTimePicker"
        Me.Invoc_timeDateTimePicker.Size = New System.Drawing.Size(51, 27)
        Me.Invoc_timeDateTimePicker.TabIndex = 102
        '
        'CacherIDTextBox
        '
        Me.CacherIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacherIDTextBox.Location = New System.Drawing.Point(-159, 149)
        Me.CacherIDTextBox.Name = "CacherIDTextBox"
        Me.CacherIDTextBox.Size = New System.Drawing.Size(51, 27)
        Me.CacherIDTextBox.TabIndex = 205
        '
        'cmbCashier
        '
        Me.cmbCashier.BackColor = System.Drawing.Color.White
        Me.cmbCashier.DisplayMember = "svil_id"
        Me.cmbCashier.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(820, 50)
        Me.cmbCashier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(139, 27)
        Me.cmbCashier.TabIndex = 0
        Me.cmbCashier.ValueMember = "svil_id"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(127, 348)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 50)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Invoc_timeTextBox
        '
        Me.Invoc_timeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoc_timeTextBox.Location = New System.Drawing.Point(25, 293)
        Me.Invoc_timeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Invoc_timeTextBox.Name = "Invoc_timeTextBox"
        Me.Invoc_timeTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Invoc_timeTextBox.TabIndex = 118
        '
        'Item_totalPriceTextBox1
        '
        Me.Item_totalPriceTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_totalPriceTextBox1.Location = New System.Drawing.Point(25, 509)
        Me.Item_totalPriceTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Item_totalPriceTextBox1.Name = "Item_totalPriceTextBox1"
        Me.Item_totalPriceTextBox1.Size = New System.Drawing.Size(51, 27)
        Me.Item_totalPriceTextBox1.TabIndex = 121
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDateTimePicker.Location = New System.Drawing.Point(24, 428)
        Me.DateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(52, 27)
        Me.DateDateTimePicker.TabIndex = 123
        Me.DateDateTimePicker.Value = New Date(2022, 2, 7, 0, 0, 0, 0)
        '
        'Invoc_date_timeTextBox
        '
        Me.Invoc_date_timeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoc_date_timeTextBox.Location = New System.Drawing.Point(-26, 428)
        Me.Invoc_date_timeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Invoc_date_timeTextBox.Name = "Invoc_date_timeTextBox"
        Me.Invoc_date_timeTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Invoc_date_timeTextBox.TabIndex = 124
        '
        'CashTextBox1
        '
        Me.CashTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CashTextBox1.Location = New System.Drawing.Point(25, 239)
        Me.CashTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CashTextBox1.Name = "CashTextBox1"
        Me.CashTextBox1.Size = New System.Drawing.Size(51, 27)
        Me.CashTextBox1.TabIndex = 128
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid.BackgroundColor = System.Drawing.Color.Silver
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colModify, Me.colCastomerid, Me.colcacher, Me.colItemID, Me.colItemName, Me.colGramPrice, Me.colGoldWeight, Me.colGoledKarat, Me.colGoledPrice, Me.colGoledMakeCharge, Me.colTotalGoledPrice, Me.colGoledPiecesQuantity, Me.colStonName1, Me.colStonWeight1, Me.colStonColor1, Me.colStonPrice1, Me.colStonName2, Me.colStonWeight2, Me.colStonColor2, Me.colStonPrice2, Me.colStonName3, Me.colStonWeight3, Me.colStonColor3, Me.colStonPrice3, Me.colGoledPurchasPrice, Me.coldate, Me.coluserID, Me.colSroomName, Me.colInvocDateTime, Me.colNots, Me.colItemCantrey, Me.colStonePriceType1, Me.colStonePriceType2, Me.colStonePriceType3, Me.colTaxTextAm, Me.colTaxAmo})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle4
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(6, 468)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.RowHeadersWidth = 10
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(963, 145)
        Me.grid.TabIndex = 1
        '
        'colDelete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDelete.FillWeight = 50.0!
        Me.colDelete.HeaderText = "حذف"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 47
        '
        'colModify
        '
        Me.colModify.HeaderText = "Modify"
        Me.colModify.Name = "colModify"
        Me.colModify.ReadOnly = True
        Me.colModify.Width = 64
        '
        'colCastomerid
        '
        Me.colCastomerid.HeaderText = "Castomerid"
        Me.colCastomerid.Name = "colCastomerid"
        Me.colCastomerid.ReadOnly = True
        Me.colCastomerid.Visible = False
        Me.colCastomerid.Width = 111
        '
        'colcacher
        '
        Me.colcacher.HeaderText = "cacher"
        Me.colcacher.Name = "colcacher"
        Me.colcacher.ReadOnly = True
        Me.colcacher.Visible = False
        Me.colcacher.Width = 79
        '
        'colItemID
        '
        Me.colItemID.HeaderText = "ItemID"
        Me.colItemID.Name = "colItemID"
        Me.colItemID.ReadOnly = True
        Me.colItemID.Width = 79
        '
        'colItemName
        '
        Me.colItemName.HeaderText = "temName"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.ReadOnly = True
        Me.colItemName.Width = 101
        '
        'colGramPrice
        '
        Me.colGramPrice.HeaderText = "GramPrice"
        Me.colGramPrice.Name = "colGramPrice"
        Me.colGramPrice.ReadOnly = True
        Me.colGramPrice.Width = 105
        '
        'colGoldWeight
        '
        Me.colGoldWeight.HeaderText = "GoldWeight"
        Me.colGoldWeight.Name = "colGoldWeight"
        Me.colGoldWeight.ReadOnly = True
        Me.colGoldWeight.Width = 115
        '
        'colGoledKarat
        '
        Me.colGoledKarat.HeaderText = "GoledKarat"
        Me.colGoledKarat.Name = "colGoledKarat"
        Me.colGoledKarat.ReadOnly = True
        Me.colGoledKarat.Width = 111
        '
        'colGoledPrice
        '
        Me.colGoledPrice.HeaderText = "GoledPrice"
        Me.colGoledPrice.Name = "colGoledPrice"
        Me.colGoledPrice.ReadOnly = True
        Me.colGoledPrice.Width = 108
        '
        'colGoledMakeCharge
        '
        Me.colGoledMakeCharge.HeaderText = "GoledMakeCharge"
        Me.colGoledMakeCharge.Name = "colGoledMakeCharge"
        Me.colGoledMakeCharge.ReadOnly = True
        Me.colGoledMakeCharge.Width = 159
        '
        'colTotalGoledPrice
        '
        Me.colTotalGoledPrice.HeaderText = "TotalGoledPrice"
        Me.colTotalGoledPrice.Name = "colTotalGoledPrice"
        Me.colTotalGoledPrice.ReadOnly = True
        Me.colTotalGoledPrice.Width = 142
        '
        'colGoledPiecesQuantity
        '
        Me.colGoledPiecesQuantity.HeaderText = "GoledPiecesQuantity"
        Me.colGoledPiecesQuantity.Name = "colGoledPiecesQuantity"
        Me.colGoledPiecesQuantity.ReadOnly = True
        Me.colGoledPiecesQuantity.Width = 176
        '
        'colStonName1
        '
        Me.colStonName1.HeaderText = "StonName1"
        Me.colStonName1.Name = "colStonName1"
        Me.colStonName1.ReadOnly = True
        Me.colStonName1.Width = 114
        '
        'colStonWeight1
        '
        Me.colStonWeight1.HeaderText = "StonWeight1"
        Me.colStonWeight1.Name = "colStonWeight1"
        Me.colStonWeight1.ReadOnly = True
        Me.colStonWeight1.Width = 123
        '
        'colStonColor1
        '
        Me.colStonColor1.HeaderText = "StonColor1"
        Me.colStonColor1.Name = "colStonColor1"
        Me.colStonColor1.ReadOnly = True
        Me.colStonColor1.Width = 110
        '
        'colStonPrice1
        '
        Me.colStonPrice1.HeaderText = "StonPrice1"
        Me.colStonPrice1.Name = "colStonPrice1"
        Me.colStonPrice1.ReadOnly = True
        Me.colStonPrice1.Width = 108
        '
        'colStonName2
        '
        Me.colStonName2.HeaderText = "StonName2"
        Me.colStonName2.Name = "colStonName2"
        Me.colStonName2.ReadOnly = True
        Me.colStonName2.Width = 114
        '
        'colStonWeight2
        '
        Me.colStonWeight2.HeaderText = "StonWeight2"
        Me.colStonWeight2.Name = "colStonWeight2"
        Me.colStonWeight2.ReadOnly = True
        Me.colStonWeight2.Width = 123
        '
        'colStonColor2
        '
        Me.colStonColor2.HeaderText = "StonColor2"
        Me.colStonColor2.Name = "colStonColor2"
        Me.colStonColor2.ReadOnly = True
        Me.colStonColor2.Width = 110
        '
        'colStonPrice2
        '
        Me.colStonPrice2.HeaderText = "StonPrice2"
        Me.colStonPrice2.Name = "colStonPrice2"
        Me.colStonPrice2.ReadOnly = True
        Me.colStonPrice2.Width = 108
        '
        'colStonName3
        '
        Me.colStonName3.HeaderText = "StonName3"
        Me.colStonName3.Name = "colStonName3"
        Me.colStonName3.ReadOnly = True
        Me.colStonName3.Width = 114
        '
        'colStonWeight3
        '
        Me.colStonWeight3.HeaderText = "StonWeight3"
        Me.colStonWeight3.Name = "colStonWeight3"
        Me.colStonWeight3.ReadOnly = True
        Me.colStonWeight3.Width = 123
        '
        'colStonColor3
        '
        Me.colStonColor3.HeaderText = "StonColor3"
        Me.colStonColor3.Name = "colStonColor3"
        Me.colStonColor3.ReadOnly = True
        Me.colStonColor3.Width = 110
        '
        'colStonPrice3
        '
        Me.colStonPrice3.HeaderText = "StonPrice3"
        Me.colStonPrice3.Name = "colStonPrice3"
        Me.colStonPrice3.ReadOnly = True
        Me.colStonPrice3.Width = 108
        '
        'colGoledPurchasPrice
        '
        Me.colGoledPurchasPrice.HeaderText = "GoledPurchasPrice"
        Me.colGoledPurchasPrice.Name = "colGoledPurchasPrice"
        Me.colGoledPurchasPrice.ReadOnly = True
        Me.colGoledPurchasPrice.Visible = False
        Me.colGoledPurchasPrice.Width = 162
        '
        'coldate
        '
        Me.coldate.HeaderText = "date"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Visible = False
        Me.coldate.Width = 65
        '
        'coluserID
        '
        Me.coluserID.HeaderText = "userID"
        Me.coluserID.Name = "coluserID"
        Me.coluserID.ReadOnly = True
        Me.coluserID.Visible = False
        Me.coluserID.Width = 77
        '
        'colSroomName
        '
        Me.colSroomName.HeaderText = "SroomName"
        Me.colSroomName.Name = "colSroomName"
        Me.colSroomName.ReadOnly = True
        Me.colSroomName.Visible = False
        Me.colSroomName.Width = 119
        '
        'colInvocDateTime
        '
        Me.colInvocDateTime.HeaderText = "InvocDateTime"
        Me.colInvocDateTime.Name = "colInvocDateTime"
        Me.colInvocDateTime.ReadOnly = True
        Me.colInvocDateTime.Width = 136
        '
        'colNots
        '
        Me.colNots.HeaderText = "Nots"
        Me.colNots.Name = "colNots"
        Me.colNots.ReadOnly = True
        Me.colNots.Visible = False
        Me.colNots.Width = 66
        '
        'colItemCantrey
        '
        Me.colItemCantrey.HeaderText = "ItemCantrey"
        Me.colItemCantrey.Name = "colItemCantrey"
        Me.colItemCantrey.ReadOnly = True
        Me.colItemCantrey.Visible = False
        Me.colItemCantrey.Width = 118
        '
        'colStonePriceType1
        '
        Me.colStonePriceType1.HeaderText = "StonePriceType1"
        Me.colStonePriceType1.Name = "colStonePriceType1"
        Me.colStonePriceType1.ReadOnly = True
        Me.colStonePriceType1.Visible = False
        Me.colStonePriceType1.Width = 149
        '
        'colStonePriceType2
        '
        Me.colStonePriceType2.HeaderText = "StonePriceType2"
        Me.colStonePriceType2.Name = "colStonePriceType2"
        Me.colStonePriceType2.ReadOnly = True
        Me.colStonePriceType2.Visible = False
        Me.colStonePriceType2.Width = 149
        '
        'colStonePriceType3
        '
        Me.colStonePriceType3.HeaderText = "StonePriceType3"
        Me.colStonePriceType3.Name = "colStonePriceType3"
        Me.colStonePriceType3.ReadOnly = True
        Me.colStonePriceType3.Visible = False
        Me.colStonePriceType3.Width = 149
        '
        'colTaxTextAm
        '
        Me.colTaxTextAm.HeaderText = "TaxTextAm"
        Me.colTaxTextAm.Name = "colTaxTextAm"
        Me.colTaxTextAm.ReadOnly = True
        Me.colTaxTextAm.Visible = False
        Me.colTaxTextAm.Width = 107
        '
        'colTaxAmo
        '
        Me.colTaxAmo.HeaderText = "TaxAmo"
        Me.colTaxAmo.Name = "colTaxAmo"
        Me.colTaxAmo.ReadOnly = True
        Me.colTaxAmo.Visible = False
        Me.colTaxAmo.Width = 88
        '
        'gbData
        '
        Me.gbData.BackColor = System.Drawing.Color.Black
        Me.gbData.Controls.Add(Me.BtnTax)
        Me.gbData.Controls.Add(Me.lblPr)
        Me.gbData.Controls.Add(Me.txtTaxAmo)
        Me.gbData.Controls.Add(Me.txtTaxTextAm)
        Me.gbData.Controls.Add(Me.lblTaxAm)
        Me.gbData.Controls.Add(Me.txtMakeCharge)
        Me.gbData.Controls.Add(Me.btnItemName)
        Me.gbData.Controls.Add(Me.btnPayPrint)
        Me.gbData.Controls.Add(Me.lblMakeCharge)
        Me.gbData.Controls.Add(Me.labItemNmeInInvoce)
        Me.gbData.Controls.Add(Me.txtItemNmeInInvoce)
        Me.gbData.Controls.Add(Me.lblKarat)
        Me.gbData.Controls.Add(Me.dtpInvoiceDate)
        Me.gbData.Controls.Add(Me.lblItem)
        Me.gbData.Controls.Add(Me.txtKarat)
        Me.gbData.Controls.Add(Me.lblInvoiceDate)
        Me.gbData.Controls.Add(Me.lblBarCode)
        Me.gbData.Controls.Add(Me.lblQty)
        Me.gbData.Controls.Add(Me.lblCashier)
        Me.gbData.Controls.Add(Me.cmbItem)
        Me.gbData.Controls.Add(Me.lblMetalPrice)
        Me.gbData.Controls.Add(Me.cmbCashier)
        Me.gbData.Controls.Add(Me.txtBarCode)
        Me.gbData.Controls.Add(Me.lblPricePerGram)
        Me.gbData.Controls.Add(Me.cmbStoneName3)
        Me.gbData.Controls.Add(Me.txtStonePrice3)
        Me.gbData.Controls.Add(Me.lblMetalWeight)
        Me.gbData.Controls.Add(Me.cmbStoneName2)
        Me.gbData.Controls.Add(Me.txtStoneWeight3)
        Me.gbData.Controls.Add(Me.txtQty)
        Me.gbData.Controls.Add(Me.txtStoneColor2)
        Me.gbData.Controls.Add(Me.txtStoneColor3)
        Me.gbData.Controls.Add(Me.txtMetalPrice)
        Me.gbData.Controls.Add(Me.txtStoneWeight2)
        Me.gbData.Controls.Add(Me.txtCostPerItem)
        Me.gbData.Controls.Add(Me.txtStonePrice2)
        Me.gbData.Controls.Add(Me.txtMetalWeight)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.txtStonePrice1)
        Me.gbData.Controls.Add(Me.cmbStoneName1)
        Me.gbData.Controls.Add(Me.txtPricePerGram)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.txtStoneWeight1)
        Me.gbData.Controls.Add(Me.lblStoneColor)
        Me.gbData.Controls.Add(Me.lblCostPerItem)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.txtStoneColor1)
        Me.gbData.Controls.Add(Me.lblStonePrice)
        Me.gbData.Controls.Add(Me.lblStoneWeight)
        Me.gbData.Controls.Add(Me.txtTotalPrice)
        Me.gbData.Controls.Add(Me.lblTotalPrice)
        Me.gbData.Controls.Add(Me.lblStoneName)
        Me.gbData.ForeColor = System.Drawing.Color.Lime
        Me.gbData.Location = New System.Drawing.Point(6, 266)
        Me.gbData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbData.Name = "gbData"
        Me.gbData.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbData.Size = New System.Drawing.Size(963, 201)
        Me.gbData.TabIndex = 2
        Me.gbData.TabStop = False
        Me.gbData.Text = "بيانات الفاتورة"
        '
        'BtnTax
        '
        Me.BtnTax.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTax.Location = New System.Drawing.Point(6, 81)
        Me.BtnTax.Name = "BtnTax"
        Me.BtnTax.Size = New System.Drawing.Size(109, 29)
        Me.BtnTax.TabIndex = 194
        Me.BtnTax.Text = "Button1"
        Me.BtnTax.UseVisualStyleBackColor = True
        '
        'lblPr
        '
        Me.lblPr.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblPr.ForeColor = System.Drawing.Color.Black
        Me.lblPr.Location = New System.Drawing.Point(76, 111)
        Me.lblPr.Name = "lblPr"
        Me.lblPr.Size = New System.Drawing.Size(39, 26)
        Me.lblPr.TabIndex = 193
        Me.lblPr.Text = "%"
        Me.lblPr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTaxAmo
        '
        Me.txtTaxAmo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtTaxAmo.Location = New System.Drawing.Point(7, 111)
        Me.txtTaxAmo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTaxAmo.Name = "txtTaxAmo"
        Me.txtTaxAmo.Size = New System.Drawing.Size(68, 27)
        Me.txtTaxAmo.TabIndex = 190
        Me.txtTaxAmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTaxTextAm
        '
        Me.txtTaxTextAm.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtTaxTextAm.Location = New System.Drawing.Point(6, 166)
        Me.txtTaxTextAm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTaxTextAm.Name = "txtTaxTextAm"
        Me.txtTaxTextAm.Size = New System.Drawing.Size(109, 27)
        Me.txtTaxTextAm.TabIndex = 191
        Me.txtTaxTextAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTaxAm
        '
        Me.lblTaxAm.BackColor = System.Drawing.Color.DimGray
        Me.lblTaxAm.ForeColor = System.Drawing.Color.Black
        Me.lblTaxAm.Location = New System.Drawing.Point(6, 140)
        Me.lblTaxAm.Name = "lblTaxAm"
        Me.lblTaxAm.Size = New System.Drawing.Size(109, 25)
        Me.lblTaxAm.TabIndex = 192
        Me.lblTaxAm.Text = "مبلغ الضريبه"
        Me.lblTaxAm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMakeCharge
        '
        Me.txtMakeCharge.BackColor = System.Drawing.Color.White
        Me.txtMakeCharge.Location = New System.Drawing.Point(492, 167)
        Me.txtMakeCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMakeCharge.Name = "txtMakeCharge"
        Me.txtMakeCharge.Size = New System.Drawing.Size(91, 27)
        Me.txtMakeCharge.TabIndex = 7
        Me.txtMakeCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnItemName
        '
        Me.btnItemName.BackColor = System.Drawing.Color.Chartreuse
        Me.btnItemName.ForeColor = System.Drawing.Color.Black
        Me.btnItemName.Location = New System.Drawing.Point(450, 50)
        Me.btnItemName.Name = "btnItemName"
        Me.btnItemName.Size = New System.Drawing.Size(26, 27)
        Me.btnItemName.TabIndex = 166
        Me.btnItemName.Text = "+"
        Me.btnItemName.UseVisualStyleBackColor = False
        '
        'btnPayPrint
        '
        Me.btnPayPrint.BackColor = System.Drawing.Color.Black
        Me.btnPayPrint.ForeColor = System.Drawing.Color.White
        Me.btnPayPrint.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnPayPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayPrint.Location = New System.Drawing.Point(121, 132)
        Me.btnPayPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayPrint.Name = "btnPayPrint"
        Me.btnPayPrint.Size = New System.Drawing.Size(186, 62)
        Me.btnPayPrint.TabIndex = 23
        Me.btnPayPrint.Text = "دفع طباعة الفاتورة"
        Me.btnPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayPrint.UseVisualStyleBackColor = False
        '
        'lblMakeCharge
        '
        Me.lblMakeCharge.ForeColor = System.Drawing.Color.White
        Me.lblMakeCharge.Location = New System.Drawing.Point(492, 141)
        Me.lblMakeCharge.Name = "lblMakeCharge"
        Me.lblMakeCharge.Size = New System.Drawing.Size(91, 25)
        Me.lblMakeCharge.TabIndex = 171
        Me.lblMakeCharge.Text = "المصنعية"
        Me.lblMakeCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labItemNmeInInvoce
        '
        Me.labItemNmeInInvoce.ForeColor = System.Drawing.Color.White
        Me.labItemNmeInInvoce.Location = New System.Drawing.Point(123, 18)
        Me.labItemNmeInInvoce.Name = "labItemNmeInInvoce"
        Me.labItemNmeInInvoce.Size = New System.Drawing.Size(356, 25)
        Me.labItemNmeInInvoce.TabIndex = 165
        Me.labItemNmeInInvoce.Text = "اسم الصنف بالفاتوره"
        Me.labItemNmeInInvoce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemNmeInInvoce
        '
        Me.txtItemNmeInInvoce.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtItemNmeInInvoce.Location = New System.Drawing.Point(123, 50)
        Me.txtItemNmeInInvoce.Name = "txtItemNmeInInvoce"
        Me.txtItemNmeInInvoce.Size = New System.Drawing.Size(327, 27)
        Me.txtItemNmeInInvoce.TabIndex = 1
        Me.txtItemNmeInInvoce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKarat
        '
        Me.lblKarat.ForeColor = System.Drawing.Color.White
        Me.lblKarat.Location = New System.Drawing.Point(584, 141)
        Me.lblKarat.Name = "lblKarat"
        Me.lblKarat.Size = New System.Drawing.Size(91, 25)
        Me.lblKarat.TabIndex = 170
        Me.lblKarat.Text = "العيار"
        Me.lblKarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(6, 50)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(117, 27)
        Me.dtpInvoiceDate.TabIndex = 10
        '
        'lblItem
        '
        Me.lblItem.ForeColor = System.Drawing.Color.White
        Me.lblItem.Location = New System.Drawing.Point(479, 18)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(198, 25)
        Me.lblItem.TabIndex = 162
        Me.lblItem.Text = "اسم الصنف"
        Me.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKarat
        '
        Me.txtKarat.BackColor = System.Drawing.Color.DarkGray
        Me.txtKarat.Location = New System.Drawing.Point(584, 167)
        Me.txtKarat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.Size = New System.Drawing.Size(91, 27)
        Me.txtKarat.TabIndex = 2
        Me.txtKarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInvoiceDate
        '
        Me.lblInvoiceDate.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceDate.Location = New System.Drawing.Point(6, 18)
        Me.lblInvoiceDate.Name = "lblInvoiceDate"
        Me.lblInvoiceDate.Size = New System.Drawing.Size(117, 25)
        Me.lblInvoiceDate.TabIndex = 163
        Me.lblInvoiceDate.Text = "تاريخ الفاتورة"
        Me.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBarCode
        '
        Me.lblBarCode.ForeColor = System.Drawing.Color.White
        Me.lblBarCode.Location = New System.Drawing.Point(677, 18)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(144, 25)
        Me.lblBarCode.TabIndex = 160
        Me.lblBarCode.Text = "باركود"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQty
        '
        Me.lblQty.ForeColor = System.Drawing.Color.White
        Me.lblQty.Location = New System.Drawing.Point(399, 141)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(91, 25)
        Me.lblQty.TabIndex = 12
        Me.lblQty.Text = "العدد"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashier
        '
        Me.lblCashier.ForeColor = System.Drawing.Color.White
        Me.lblCashier.Location = New System.Drawing.Point(821, 18)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(125, 25)
        Me.lblCashier.TabIndex = 159
        Me.lblCashier.Text = "كاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbItem
        '
        Me.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItem.BackColor = System.Drawing.Color.White
        Me.cmbItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(476, 50)
        Me.cmbItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(200, 27)
        Me.cmbItem.TabIndex = 21
        Me.cmbItem.TabStop = False
        '
        'lblMetalPrice
        '
        Me.lblMetalPrice.ForeColor = System.Drawing.Color.White
        Me.lblMetalPrice.Location = New System.Drawing.Point(399, 86)
        Me.lblMetalPrice.Name = "lblMetalPrice"
        Me.lblMetalPrice.Size = New System.Drawing.Size(91, 25)
        Me.lblMetalPrice.TabIndex = 10
        Me.lblMetalPrice.Text = "سعر الذهب"
        Me.lblMetalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPricePerGram
        '
        Me.lblPricePerGram.ForeColor = System.Drawing.Color.White
        Me.lblPricePerGram.Location = New System.Drawing.Point(492, 86)
        Me.lblPricePerGram.Name = "lblPricePerGram"
        Me.lblPricePerGram.Size = New System.Drawing.Size(91, 25)
        Me.lblPricePerGram.TabIndex = 13
        Me.lblPricePerGram.Text = "سعر الجرام"
        Me.lblPricePerGram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStoneName3
        '
        Me.cmbStoneName3.FormattingEnabled = True
        Me.cmbStoneName3.Location = New System.Drawing.Point(855, 167)
        Me.cmbStoneName3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName3.Name = "cmbStoneName3"
        Me.cmbStoneName3.Size = New System.Drawing.Size(91, 27)
        Me.cmbStoneName3.TabIndex = 10
        Me.cmbStoneName3.TabStop = False
        '
        'txtStonePrice3
        '
        Me.txtStonePrice3.BackColor = System.Drawing.Color.White
        Me.txtStonePrice3.Location = New System.Drawing.Point(677, 167)
        Me.txtStonePrice3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice3.Name = "txtStonePrice3"
        Me.txtStonePrice3.Size = New System.Drawing.Size(56, 27)
        Me.txtStonePrice3.TabIndex = 19
        Me.txtStonePrice3.TabStop = False
        Me.txtStonePrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMetalWeight
        '
        Me.lblMetalWeight.ForeColor = System.Drawing.Color.White
        Me.lblMetalWeight.Location = New System.Drawing.Point(584, 86)
        Me.lblMetalWeight.Name = "lblMetalWeight"
        Me.lblMetalWeight.Size = New System.Drawing.Size(91, 25)
        Me.lblMetalWeight.TabIndex = 12
        Me.lblMetalWeight.Text = "وزن الذهب"
        Me.lblMetalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStoneName2
        '
        Me.cmbStoneName2.FormattingEnabled = True
        Me.cmbStoneName2.Location = New System.Drawing.Point(855, 140)
        Me.cmbStoneName2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName2.Name = "cmbStoneName2"
        Me.cmbStoneName2.Size = New System.Drawing.Size(91, 27)
        Me.cmbStoneName2.TabIndex = 9
        Me.cmbStoneName2.TabStop = False
        '
        'txtStoneWeight3
        '
        Me.txtStoneWeight3.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight3.Location = New System.Drawing.Point(801, 167)
        Me.txtStoneWeight3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight3.Name = "txtStoneWeight3"
        Me.txtStoneWeight3.Size = New System.Drawing.Size(53, 27)
        Me.txtStoneWeight3.TabIndex = 13
        Me.txtStoneWeight3.TabStop = False
        Me.txtStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.Location = New System.Drawing.Point(399, 167)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(91, 27)
        Me.txtQty.TabIndex = 6
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneColor2
        '
        Me.txtStoneColor2.BackColor = System.Drawing.Color.White
        Me.txtStoneColor2.Location = New System.Drawing.Point(735, 140)
        Me.txtStoneColor2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor2.Name = "txtStoneColor2"
        Me.txtStoneColor2.Size = New System.Drawing.Size(64, 27)
        Me.txtStoneColor2.TabIndex = 15
        Me.txtStoneColor2.TabStop = False
        Me.txtStoneColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneColor3
        '
        Me.txtStoneColor3.BackColor = System.Drawing.Color.White
        Me.txtStoneColor3.Location = New System.Drawing.Point(735, 167)
        Me.txtStoneColor3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor3.Name = "txtStoneColor3"
        Me.txtStoneColor3.Size = New System.Drawing.Size(64, 27)
        Me.txtStoneColor3.TabIndex = 16
        Me.txtStoneColor3.TabStop = False
        Me.txtStoneColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMetalPrice
        '
        Me.txtMetalPrice.BackColor = System.Drawing.Color.White
        Me.txtMetalPrice.Location = New System.Drawing.Point(399, 113)
        Me.txtMetalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMetalPrice.Name = "txtMetalPrice"
        Me.txtMetalPrice.Size = New System.Drawing.Size(91, 27)
        Me.txtMetalPrice.TabIndex = 5
        Me.txtMetalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight2
        '
        Me.txtStoneWeight2.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight2.Location = New System.Drawing.Point(801, 140)
        Me.txtStoneWeight2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight2.Name = "txtStoneWeight2"
        Me.txtStoneWeight2.Size = New System.Drawing.Size(53, 27)
        Me.txtStoneWeight2.TabIndex = 12
        Me.txtStoneWeight2.TabStop = False
        Me.txtStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostPerItem
        '
        Me.txtCostPerItem.BackColor = System.Drawing.Color.DarkGray
        Me.txtCostPerItem.Location = New System.Drawing.Point(308, 113)
        Me.txtCostPerItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCostPerItem.Name = "txtCostPerItem"
        Me.txtCostPerItem.Size = New System.Drawing.Size(89, 27)
        Me.txtCostPerItem.TabIndex = 8
        Me.txtCostPerItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStonePrice2
        '
        Me.txtStonePrice2.BackColor = System.Drawing.Color.White
        Me.txtStonePrice2.Location = New System.Drawing.Point(677, 140)
        Me.txtStonePrice2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice2.Name = "txtStonePrice2"
        Me.txtStonePrice2.Size = New System.Drawing.Size(56, 27)
        Me.txtStonePrice2.TabIndex = 18
        Me.txtStonePrice2.TabStop = False
        Me.txtStonePrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMetalWeight
        '
        Me.txtMetalWeight.BackColor = System.Drawing.Color.White
        Me.txtMetalWeight.Location = New System.Drawing.Point(584, 113)
        Me.txtMetalWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMetalWeight.Name = "txtMetalWeight"
        Me.txtMetalWeight.Size = New System.Drawing.Size(91, 27)
        Me.txtMetalWeight.TabIndex = 3
        Me.txtMetalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(945, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStonePrice1
        '
        Me.txtStonePrice1.BackColor = System.Drawing.Color.White
        Me.txtStonePrice1.Location = New System.Drawing.Point(677, 113)
        Me.txtStonePrice1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStonePrice1.Name = "txtStonePrice1"
        Me.txtStonePrice1.Size = New System.Drawing.Size(56, 27)
        Me.txtStonePrice1.TabIndex = 17
        Me.txtStonePrice1.TabStop = False
        Me.txtStonePrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStoneName1
        '
        Me.cmbStoneName1.FormattingEnabled = True
        Me.cmbStoneName1.Location = New System.Drawing.Point(855, 113)
        Me.cmbStoneName1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStoneName1.Name = "cmbStoneName1"
        Me.cmbStoneName1.Size = New System.Drawing.Size(91, 27)
        Me.cmbStoneName1.TabIndex = 0
        Me.cmbStoneName1.TabStop = False
        '
        'txtPricePerGram
        '
        Me.txtPricePerGram.BackColor = System.Drawing.Color.White
        Me.txtPricePerGram.Location = New System.Drawing.Point(492, 113)
        Me.txtPricePerGram.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPricePerGram.Name = "txtPricePerGram"
        Me.txtPricePerGram.Size = New System.Drawing.Size(91, 27)
        Me.txtPricePerGram.TabIndex = 4
        Me.txtPricePerGram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(945, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 19)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneWeight1
        '
        Me.txtStoneWeight1.BackColor = System.Drawing.Color.White
        Me.txtStoneWeight1.Location = New System.Drawing.Point(801, 113)
        Me.txtStoneWeight1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneWeight1.Name = "txtStoneWeight1"
        Me.txtStoneWeight1.Size = New System.Drawing.Size(53, 27)
        Me.txtStoneWeight1.TabIndex = 11
        Me.txtStoneWeight1.TabStop = False
        Me.txtStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStoneColor
        '
        Me.lblStoneColor.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneColor.ForeColor = System.Drawing.Color.White
        Me.lblStoneColor.Location = New System.Drawing.Point(735, 86)
        Me.lblStoneColor.Name = "lblStoneColor"
        Me.lblStoneColor.Size = New System.Drawing.Size(64, 25)
        Me.lblStoneColor.TabIndex = 167
        Me.lblStoneColor.Text = "لون الفص"
        Me.lblStoneColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCostPerItem
        '
        Me.lblCostPerItem.ForeColor = System.Drawing.Color.White
        Me.lblCostPerItem.Location = New System.Drawing.Point(308, 86)
        Me.lblCostPerItem.Name = "lblCostPerItem"
        Me.lblCostPerItem.Size = New System.Drawing.Size(89, 25)
        Me.lblCostPerItem.TabIndex = 14
        Me.lblCostPerItem.Text = "سعر الشراء"
        Me.lblCostPerItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(945, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneColor1
        '
        Me.txtStoneColor1.BackColor = System.Drawing.Color.White
        Me.txtStoneColor1.Location = New System.Drawing.Point(735, 113)
        Me.txtStoneColor1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStoneColor1.Name = "txtStoneColor1"
        Me.txtStoneColor1.Size = New System.Drawing.Size(64, 27)
        Me.txtStoneColor1.TabIndex = 14
        Me.txtStoneColor1.TabStop = False
        Me.txtStoneColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStonePrice
        '
        Me.lblStonePrice.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStonePrice.ForeColor = System.Drawing.Color.White
        Me.lblStonePrice.Location = New System.Drawing.Point(677, 86)
        Me.lblStonePrice.Name = "lblStonePrice"
        Me.lblStonePrice.Size = New System.Drawing.Size(56, 25)
        Me.lblStonePrice.TabIndex = 167
        Me.lblStonePrice.Text = "سعر الفص"
        Me.lblStonePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneWeight
        '
        Me.lblStoneWeight.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneWeight.ForeColor = System.Drawing.Color.White
        Me.lblStoneWeight.Location = New System.Drawing.Point(801, 86)
        Me.lblStoneWeight.Name = "lblStoneWeight"
        Me.lblStoneWeight.Size = New System.Drawing.Size(53, 25)
        Me.lblStoneWeight.TabIndex = 166
        Me.lblStoneWeight.Text = "وزن الفص"
        Me.lblStoneWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.White
        Me.txtTotalPrice.Location = New System.Drawing.Point(308, 167)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(89, 27)
        Me.txtTotalPrice.TabIndex = 9
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.White
        Me.lblTotalPrice.Location = New System.Drawing.Point(308, 141)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(89, 25)
        Me.lblTotalPrice.TabIndex = 183
        Me.lblTotalPrice.Text = "سعر البيع"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStoneName
        '
        Me.lblStoneName.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblStoneName.ForeColor = System.Drawing.Color.White
        Me.lblStoneName.Location = New System.Drawing.Point(855, 86)
        Me.lblStoneName.Name = "lblStoneName"
        Me.lblStoneName.Size = New System.Drawing.Size(91, 25)
        Me.lblStoneName.TabIndex = 166
        Me.lblStoneName.Text = "نوع الفص"
        Me.lblStoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotsTextBox
        '
        Me.NotsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotsTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.NotsTextBox.Location = New System.Drawing.Point(24, 482)
        Me.NotsTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NotsTextBox.Name = "NotsTextBox"
        Me.NotsTextBox.Size = New System.Drawing.Size(52, 27)
        Me.NotsTextBox.TabIndex = 142
        '
        'QuntTextBox
        '
        Me.QuntTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuntTextBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.QuntTextBox.Location = New System.Drawing.Point(24, 455)
        Me.QuntTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuntTextBox.Name = "QuntTextBox"
        Me.QuntTextBox.Size = New System.Drawing.Size(52, 27)
        Me.QuntTextBox.TabIndex = 135
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.Location = New System.Drawing.Point(2, -2)
        Me.FotoPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(1, 1)
        Me.FotoPictureBox.TabIndex = 138
        Me.FotoPictureBox.TabStop = False
        '
        'Inv_startTextBox
        '
        Me.Inv_startTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_startTextBox.Location = New System.Drawing.Point(-159, 322)
        Me.Inv_startTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Inv_startTextBox.Name = "Inv_startTextBox"
        Me.Inv_startTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Inv_startTextBox.TabIndex = 143
        '
        'Saryal_maxTextBox
        '
        Me.Saryal_maxTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Saryal_maxTextBox.Location = New System.Drawing.Point(-159, 253)
        Me.Saryal_maxTextBox.Name = "Saryal_maxTextBox"
        Me.Saryal_maxTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Saryal_maxTextBox.TabIndex = 145
        '
        'Loc_nameTextBox
        '
        Me.Loc_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Loc_nameTextBox.Location = New System.Drawing.Point(-159, 290)
        Me.Loc_nameTextBox.Name = "Loc_nameTextBox"
        Me.Loc_nameTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Loc_nameTextBox.TabIndex = 146
        '
        'Comp_note1TextBox
        '
        Me.Comp_note1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Comp_note1TextBox.Location = New System.Drawing.Point(-159, 50)
        Me.Comp_note1TextBox.Name = "Comp_note1TextBox"
        Me.Comp_note1TextBox.Size = New System.Drawing.Size(51, 27)
        Me.Comp_note1TextBox.TabIndex = 147
        '
        'Sroom_nameTextBox
        '
        Me.Sroom_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sroom_nameTextBox.Location = New System.Drawing.Point(-26, 455)
        Me.Sroom_nameTextBox.Name = "Sroom_nameTextBox"
        Me.Sroom_nameTextBox.Size = New System.Drawing.Size(51, 27)
        Me.Sroom_nameTextBox.TabIndex = 148
        '
        'Inv_startTextBox1
        '
        Me.Inv_startTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_startTextBox1.Location = New System.Drawing.Point(-159, 203)
        Me.Inv_startTextBox1.Name = "Inv_startTextBox1"
        Me.Inv_startTextBox1.Size = New System.Drawing.Size(51, 27)
        Me.Inv_startTextBox1.TabIndex = 165
        '
        'SET_INVARCHR147TextBox
        '
        Me.SET_INVARCHR147TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR147TextBox.Location = New System.Drawing.Point(25, 320)
        Me.SET_INVARCHR147TextBox.Name = "SET_INVARCHR147TextBox"
        Me.SET_INVARCHR147TextBox.Size = New System.Drawing.Size(51, 27)
        Me.SET_INVARCHR147TextBox.TabIndex = 166
        '
        'SignaturePictureBox
        '
        Me.SignaturePictureBox.Location = New System.Drawing.Point(2, 2)
        Me.SignaturePictureBox.Name = "SignaturePictureBox"
        Me.SignaturePictureBox.Size = New System.Drawing.Size(1, 1)
        Me.SignaturePictureBox.TabIndex = 167
        Me.SignaturePictureBox.TabStop = False
        '
        'btnNextItem
        '
        Me.btnNextItem.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnNextItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNextItem.ForeColor = System.Drawing.Color.White
        Me.btnNextItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNextItem.Location = New System.Drawing.Point(369, 20)
        Me.btnNextItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(80, 46)
        Me.btnNextItem.TabIndex = 7
        Me.btnNextItem.Text = "السابق"
        Me.btnNextItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNextItem.UseVisualStyleBackColor = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.StonePriceType3TextBox)
        Me.pnl.Controls.Add(Me.StonePriceType2TextBox)
        Me.pnl.Controls.Add(Me.StonePriceType1TextBox)
        Me.pnl.Controls.Add(Me.CacherTextBox)
        Me.pnl.Controls.Add(Me.ItemIDTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR169TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR168TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR167TextBox)
        Me.pnl.Controls.Add(Me.StoneWeight3TextBox1)
        Me.pnl.Controls.Add(Me.StonePrice3TextBox1)
        Me.pnl.Controls.Add(Me.StoneColor3TextBox1)
        Me.pnl.Controls.Add(Me.StoneName3TextBox1)
        Me.pnl.Controls.Add(Me.StoneWeight2TextBox1)
        Me.pnl.Controls.Add(Me.StonePrice2TextBox1)
        Me.pnl.Controls.Add(Me.StoneColor2TextBox1)
        Me.pnl.Controls.Add(Me.StoneName2TextBox1)
        Me.pnl.Controls.Add(Me.StoneColor1TextBox1)
        Me.pnl.Controls.Add(Me.StoneName1TextBox)
        Me.pnl.Controls.Add(Me.ActiveCheckBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR147TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR151TextBox)
        Me.pnl.Controls.Add(Me.DateDateTimePicker)
        Me.pnl.Controls.Add(Me.Inv_startTextBox1)
        Me.pnl.Controls.Add(Me.Sroom_nameTextBox)
        Me.pnl.Controls.Add(Me.Comp_note1TextBox)
        Me.pnl.Controls.Add(Me.Loc_nameTextBox)
        Me.pnl.Controls.Add(Me.Saryal_maxTextBox)
        Me.pnl.Controls.Add(Me.Inv_startTextBox)
        Me.pnl.Controls.Add(Me.CashTextBox)
        Me.pnl.Controls.Add(Me.QuntTextBox)
        Me.pnl.Controls.Add(Me.Item_totalPriceTextBox)
        Me.pnl.Controls.Add(Me.Item_extrasMAZANTextBox)
        Me.pnl.Controls.Add(Me.Item_extrasPRICETextBox)
        Me.pnl.Controls.Add(Me.NotsTextBox)
        Me.pnl.Controls.Add(Me.Item_gramMadeTextBox)
        Me.pnl.Controls.Add(Me.Item_gramTextBox)
        Me.pnl.Controls.Add(Me.Item_GramPriceTextBox)
        Me.pnl.Controls.Add(Me.Item_despTextBox)
        Me.pnl.Controls.Add(Me.Item_nameTextBox)
        Me.pnl.Controls.Add(Me.UserIDTextBox1)
        Me.pnl.Controls.Add(Me.CastomeridTextBox)
        Me.pnl.Controls.Add(Me.IDTextBox1)
        Me.pnl.Controls.Add(Me.CashTextBox1)
        Me.pnl.Controls.Add(Me.Item_cantreyTextBox)
        Me.pnl.Controls.Add(Me.Invoc_date_timeTextBox)
        Me.pnl.Controls.Add(Me.Item_totalPriceTextBox1)
        Me.pnl.Controls.Add(Me.Invoc_timeTextBox)
        Me.pnl.Controls.Add(Me.CacherIDTextBox)
        Me.pnl.Controls.Add(Me.Invoc_timeDateTimePicker)
        Me.pnl.Location = New System.Drawing.Point(1392, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(103, 56)
        Me.pnl.TabIndex = 168
        '
        'StonePriceType3TextBox
        '
        Me.StonePriceType3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StonePriceType3TextBox.Location = New System.Drawing.Point(-77, 104)
        Me.StonePriceType3TextBox.Name = "StonePriceType3TextBox"
        Me.StonePriceType3TextBox.Size = New System.Drawing.Size(51, 27)
        Me.StonePriceType3TextBox.TabIndex = 211
        '
        'StonePriceType2TextBox
        '
        Me.StonePriceType2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StonePriceType2TextBox.Location = New System.Drawing.Point(-77, 77)
        Me.StonePriceType2TextBox.Name = "StonePriceType2TextBox"
        Me.StonePriceType2TextBox.Size = New System.Drawing.Size(51, 27)
        Me.StonePriceType2TextBox.TabIndex = 210
        '
        'StonePriceType1TextBox
        '
        Me.StonePriceType1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StonePriceType1TextBox.Location = New System.Drawing.Point(-77, 50)
        Me.StonePriceType1TextBox.Name = "StonePriceType1TextBox"
        Me.StonePriceType1TextBox.Size = New System.Drawing.Size(51, 27)
        Me.StonePriceType1TextBox.TabIndex = 209
        '
        'CacherTextBox
        '
        Me.CacherTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacherTextBox.Location = New System.Drawing.Point(-26, 482)
        Me.CacherTextBox.Name = "CacherTextBox"
        Me.CacherTextBox.Size = New System.Drawing.Size(51, 27)
        Me.CacherTextBox.TabIndex = 208
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemIDTextBox.Location = New System.Drawing.Point(25, 104)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.Size = New System.Drawing.Size(51, 27)
        Me.ItemIDTextBox.TabIndex = 207
        '
        'SET_INVARCHR169TextBox
        '
        Me.SET_INVARCHR169TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR169TextBox.Location = New System.Drawing.Point(-159, 354)
        Me.SET_INVARCHR169TextBox.Name = "SET_INVARCHR169TextBox"
        Me.SET_INVARCHR169TextBox.Size = New System.Drawing.Size(51, 27)
        Me.SET_INVARCHR169TextBox.TabIndex = 0
        '
        'SET_INVARCHR168TextBox
        '
        Me.SET_INVARCHR168TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR168TextBox.Location = New System.Drawing.Point(-159, 414)
        Me.SET_INVARCHR168TextBox.Name = "SET_INVARCHR168TextBox"
        Me.SET_INVARCHR168TextBox.Size = New System.Drawing.Size(51, 27)
        Me.SET_INVARCHR168TextBox.TabIndex = 191
        '
        'SET_INVARCHR167TextBox
        '
        Me.SET_INVARCHR167TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR167TextBox.Location = New System.Drawing.Point(-159, 387)
        Me.SET_INVARCHR167TextBox.Name = "SET_INVARCHR167TextBox"
        Me.SET_INVARCHR167TextBox.Size = New System.Drawing.Size(51, 27)
        Me.SET_INVARCHR167TextBox.TabIndex = 190
        '
        'StoneWeight3TextBox1
        '
        Me.StoneWeight3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight3TextBox1.Location = New System.Drawing.Point(-26, 347)
        Me.StoneWeight3TextBox1.Name = "StoneWeight3TextBox1"
        Me.StoneWeight3TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneWeight3TextBox1.TabIndex = 189
        '
        'StonePrice3TextBox1
        '
        Me.StonePrice3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StonePrice3TextBox1.Location = New System.Drawing.Point(-26, 320)
        Me.StonePrice3TextBox1.Name = "StonePrice3TextBox1"
        Me.StonePrice3TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StonePrice3TextBox1.TabIndex = 188
        '
        'StoneColor3TextBox1
        '
        Me.StoneColor3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneColor3TextBox1.Location = New System.Drawing.Point(-26, 293)
        Me.StoneColor3TextBox1.Name = "StoneColor3TextBox1"
        Me.StoneColor3TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneColor3TextBox1.TabIndex = 187
        '
        'StoneName3TextBox1
        '
        Me.StoneName3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName3TextBox1.Location = New System.Drawing.Point(-26, 266)
        Me.StoneName3TextBox1.Name = "StoneName3TextBox1"
        Me.StoneName3TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneName3TextBox1.TabIndex = 186
        '
        'StoneWeight2TextBox1
        '
        Me.StoneWeight2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight2TextBox1.Location = New System.Drawing.Point(-26, 239)
        Me.StoneWeight2TextBox1.Name = "StoneWeight2TextBox1"
        Me.StoneWeight2TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneWeight2TextBox1.TabIndex = 185
        '
        'StonePrice2TextBox1
        '
        Me.StonePrice2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StonePrice2TextBox1.Location = New System.Drawing.Point(-26, 212)
        Me.StonePrice2TextBox1.Name = "StonePrice2TextBox1"
        Me.StonePrice2TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StonePrice2TextBox1.TabIndex = 184
        '
        'StoneColor2TextBox1
        '
        Me.StoneColor2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneColor2TextBox1.Location = New System.Drawing.Point(-26, 185)
        Me.StoneColor2TextBox1.Name = "StoneColor2TextBox1"
        Me.StoneColor2TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneColor2TextBox1.TabIndex = 183
        '
        'StoneName2TextBox1
        '
        Me.StoneName2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName2TextBox1.Location = New System.Drawing.Point(-26, 158)
        Me.StoneName2TextBox1.Name = "StoneName2TextBox1"
        Me.StoneName2TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneName2TextBox1.TabIndex = 182
        '
        'StoneColor1TextBox1
        '
        Me.StoneColor1TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneColor1TextBox1.Location = New System.Drawing.Point(-26, 77)
        Me.StoneColor1TextBox1.Name = "StoneColor1TextBox1"
        Me.StoneColor1TextBox1.Size = New System.Drawing.Size(51, 27)
        Me.StoneColor1TextBox1.TabIndex = 181
        '
        'StoneName1TextBox
        '
        Me.StoneName1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName1TextBox.Location = New System.Drawing.Point(-26, 50)
        Me.StoneName1TextBox.Name = "StoneName1TextBox"
        Me.StoneName1TextBox.Size = New System.Drawing.Size(51, 27)
        Me.StoneName1TextBox.TabIndex = 180
        '
        'ActiveCheckBox
        '
        Me.ActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActiveCheckBox.Checked = True
        Me.ActiveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActiveCheckBox.Location = New System.Drawing.Point(-26, 509)
        Me.ActiveCheckBox.Name = "ActiveCheckBox"
        Me.ActiveCheckBox.Size = New System.Drawing.Size(51, 24)
        Me.ActiveCheckBox.TabIndex = 167
        Me.ActiveCheckBox.Text = "CheckBox1"
        Me.ActiveCheckBox.UseVisualStyleBackColor = True
        '
        'SET_INVARCHR151TextBox
        '
        Me.SET_INVARCHR151TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR151TextBox.Location = New System.Drawing.Point(-159, 83)
        Me.SET_INVARCHR151TextBox.Name = "SET_INVARCHR151TextBox"
        Me.SET_INVARCHR151TextBox.Size = New System.Drawing.Size(51, 27)
        Me.SET_INVARCHR151TextBox.TabIndex = 166
        '
        'lblTotalPriceTitle
        '
        Me.lblTotalPriceTitle.BackColor = System.Drawing.Color.DimGray
        Me.lblTotalPriceTitle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPriceTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTotalPriceTitle.Location = New System.Drawing.Point(412, 643)
        Me.lblTotalPriceTitle.Name = "lblTotalPriceTitle"
        Me.lblTotalPriceTitle.Size = New System.Drawing.Size(129, 27)
        Me.lblTotalPriceTitle.TabIndex = 198
        Me.lblTotalPriceTitle.Text = "مبلغ الضريبه"
        Me.lblTotalPriceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPriceValue
        '
        Me.txtTotalPriceValue.BackColor = System.Drawing.Color.White
        Me.txtTotalPriceValue.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPriceValue.Location = New System.Drawing.Point(284, 643)
        Me.txtTotalPriceValue.Name = "txtTotalPriceValue"
        Me.txtTotalPriceValue.Size = New System.Drawing.Size(124, 27)
        Me.txtTotalPriceValue.TabIndex = 195
        Me.txtTotalPriceValue.Text = "0.000"
        Me.txtTotalPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTpriceTtax
        '
        Me.txtTpriceTtax.BackColor = System.Drawing.Color.DarkOrange
        Me.txtTpriceTtax.Location = New System.Drawing.Point(6, 643)
        Me.txtTpriceTtax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTpriceTtax.Name = "txtTpriceTtax"
        Me.txtTpriceTtax.Size = New System.Drawing.Size(127, 27)
        Me.txtTpriceTtax.TabIndex = 196
        Me.txtTpriceTtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(137, 643)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 27)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "اجمالي الفاتوره مع الضريبه"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNote
        '
        Me.lblNote.ForeColor = System.Drawing.Color.White
        Me.lblNote.Location = New System.Drawing.Point(903, 614)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(67, 27)
        Me.lblNote.TabIndex = 193
        Me.lblNote.Text = "ملاحظات"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(6, 614)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(891, 27)
        Me.txtNotes.TabIndex = 194
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInvoiceValue
        '
        Me.lblInvoiceValue.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceValue.Location = New System.Drawing.Point(1025, 519)
        Me.lblInvoiceValue.Name = "lblInvoiceValue"
        Me.lblInvoiceValue.Size = New System.Drawing.Size(67, 27)
        Me.lblInvoiceValue.TabIndex = 199
        Me.lblInvoiceValue.Text = "ملاحظات"
        Me.lblInvoiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvoiceTitle
        '
        Me.lblInvoiceTitle.AutoSize = True
        Me.lblInvoiceTitle.Location = New System.Drawing.Point(1046, 585)
        Me.lblInvoiceTitle.Name = "lblInvoiceTitle"
        Me.lblInvoiceTitle.Size = New System.Drawing.Size(53, 19)
        Me.lblInvoiceTitle.TabIndex = 200
        Me.lblInvoiceTitle.Text = "Label2"
        '
        'SilverInvoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(971, 673)
        Me.Controls.Add(Me.lblInvoiceTitle)
        Me.Controls.Add(Me.lblInvoiceValue)
        Me.Controls.Add(Me.lblTotalPriceTitle)
        Me.Controls.Add(Me.txtTotalPriceValue)
        Me.Controls.Add(Me.txtTpriceTtax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.SignaturePictureBox)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.grid)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SilverInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignaturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CastomeridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Item_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_despTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_GramPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_gramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_gramMadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_extrasPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_extrasMAZANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_totalPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_cantreyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoc_timeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CacherIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button

    Friend WithEvents Invoc_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_totalPriceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Invoc_date_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents btnPayPrint As System.Windows.Forms.Button
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox

    Friend WithEvents NotsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuntTextBox As System.Windows.Forms.TextBox

    Friend WithEvents Inv_startTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox

    Friend WithEvents Saryal_maxTextBox As System.Windows.Forms.TextBox

    Friend WithEvents Loc_nameTextBox As System.Windows.Forms.TextBox

    Friend WithEvents Comp_note1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sroom_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents Inv_startTextBox1 As System.Windows.Forms.TextBox

    Friend WithEvents SET_INVARCHR147TextBox As System.Windows.Forms.TextBox


    'Partial Public Class TestSigCapt
    '    ''' <summary>
    '    ''' Required designer variable.
    '    ''' </summary>
    '    Private components As System.ComponentModel.IContainer = Nothing

    '    ''' <summary>
    '    ''' Clean up any resources being used.
    '    ''' </summary>
    '    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    '    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '        If disposing AndAlso (components IsNot Nothing) Then
    '            components.Dispose()
    '        End If
    '        MyBase.Dispose(disposing)
    '    End Sub

    '#Region "Windows Form Designer generated code"

    '    ''' <summary>
    '    ''' Required method for Designer support - do not modify
    '    ''' the contents of this method with the code editor.
    '    ''' </summary>

    '    'Private Sub InitializeComponent()
    '    '    Me.sigImage = New System.Windows.Forms.PictureBox()
    '    '    Me.btnSign = New System.Windows.Forms.Button()
    '    Me.txtDisplay = New System.Windows.Forms.TextBox()
    '    Me.btnExit = New System.Windows.Forms.Button()
    '    CType(Me.sigImage, System.ComponentModel.ISupportInitialize).BeginInit()
    'Me.SuspendLayout()
    '
    'sigImage
    '
    '    Me.sigImage.BackColor = System.Drawing.Color.Black
    '    Me.sigImage.Location = New System.Drawing.Point(19, 242)
    '    Me.sigImage.Name = "sigImage"
    '    Me.sigImage.Size = New System.Drawing.Size(161, 109)
    '    Me.sigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    '    Me.sigImage.TabIndex = 0
    '    Me.sigImage.TabStop = False
    ''
    ''btnSign
    ''
    '    Me.btnSign.Location = New System.Drawing.Point(19, 143)
    '    Me.btnSign.Name = "btnSign"
    '    Me.btnSign.Size = New System.Drawing.Size(94, 44)
    '    Me.btnSign.TabIndex = 1
    '    Me.btnSign.Text = "Sign"
    '    Me.btnSign.UseVisualStyleBackColor = True
    ''
    ''txtDisplay
    ''
    '    Me.txtDisplay.Location = New System.Drawing.Point(358, 67)
    '    Me.txtDisplay.Multiline = True
    '    Me.txtDisplay.Name = "txtDisplay"
    '    Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    '    Me.txtDisplay.Size = New System.Drawing.Size(402, 212)
    '    Me.txtDisplay.TabIndex = 2
    ''
    ''btnExit
    ''
    '    Me.btnExit.Location = New System.Drawing.Point(119, 143)
    '    Me.btnExit.Name = "btnExit"
    '    Me.btnExit.Size = New System.Drawing.Size(94, 44)
    '    Me.btnExit.TabIndex = 3
    '    Me.btnExit.Text = "Exit"
    '    Me.btnExit.UseVisualStyleBackColor = True
    '
    'TestSigCapt
    '
    'Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    'Me.ClientSize = New System.Drawing.Size(869, 557)
    'Me.Controls.Add(Me.btnExit)
    'Me.Controls.Add(Me.txtDisplay)
    'Me.Controls.Add(Me.btnSign)
    'Me.Controls.Add(Me.sigImage)
    'Me.Name = "TestSigCapt"
    'Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    'Me.Text = "TestSigCapt"
    'CType(Me.sigImage, System.ComponentModel.ISupportInitialize).EndInit()
    'Me.ResumeLayout(False)
    'Me.PerformLayout()

    '    End Sub

    '#End Region

    Private sigImage As System.Windows.Forms.PictureBox
    Private WithEvents btnSign As System.Windows.Forms.Button
    Private txtDisplay As System.Windows.Forms.TextBox
    Private WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents SignaturePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnNextItem As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents SET_INVARCHR151TextBox As System.Windows.Forms.TextBox
    Friend WithEvents GoldSilverAvailableTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.GoldSilverAvailableTableAdapter
    Friend WithEvents ActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents lblInvoiceDate As System.Windows.Forms.Label
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents StoneColor3TextBox1 As TextBox
    Friend WithEvents StoneName3TextBox1 As TextBox
    Friend WithEvents StoneWeight2TextBox1 As TextBox
    Friend WithEvents StonePrice2TextBox1 As TextBox
    Friend WithEvents StoneColor2TextBox1 As TextBox
    Friend WithEvents StoneName2TextBox1 As TextBox
    Friend WithEvents StoneColor1TextBox1 As TextBox
    Friend WithEvents StoneName1TextBox As TextBox
    Friend WithEvents StoneWeight3TextBox1 As TextBox
    Friend WithEvents StonePrice3TextBox1 As TextBox
    Friend WithEvents SET_INVARCHR167TextBox As TextBox
    Friend WithEvents SET_INVARCHR168TextBox As TextBox
    Friend WithEvents SET_INVARCHR169TextBox As TextBox
    Friend WithEvents ItemIDTextBox As TextBox
    Friend WithEvents CacherTextBox As TextBox
    Friend WithEvents StonePriceType3TextBox As TextBox
    Friend WithEvents StonePriceType2TextBox As TextBox
    Friend WithEvents StonePriceType1TextBox As TextBox
    Friend WithEvents labItemNmeInInvoce As System.Windows.Forms.Label
    Friend WithEvents txtItemNmeInInvoce As System.Windows.Forms.TextBox
    Friend WithEvents btnItemName As System.Windows.Forms.Button
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colModify As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colCastomerid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcacher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGramPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoldWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledKarat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledMakeCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalGoledPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledPiecesQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonWeight1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonColor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonPrice1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonWeight2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonColor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonPrice2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonName3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonWeight3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonColor3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonPrice3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledPurchasPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coluserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSroomName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvocDateTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNots As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemCantrey As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePriceType1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePriceType2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePriceType3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMakeCharge As System.Windows.Forms.TextBox
    Friend WithEvents lblMakeCharge As System.Windows.Forms.Label
    Friend WithEvents lblKarat As System.Windows.Forms.Label
    Friend WithEvents txtKarat As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblMetalPrice As System.Windows.Forms.Label
    Friend WithEvents lblPricePerGram As System.Windows.Forms.Label
    Friend WithEvents cmbStoneName3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtStonePrice3 As System.Windows.Forms.TextBox
    Friend WithEvents lblMetalWeight As System.Windows.Forms.Label
    Friend WithEvents cmbStoneName2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtStoneWeight3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtStoneColor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStoneColor3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMetalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStoneWeight2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPerItem As System.Windows.Forms.TextBox
    Friend WithEvents txtStonePrice2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMetalWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStonePrice1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbStoneName1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPricePerGram As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents lblStoneColor As System.Windows.Forms.Label
    Friend WithEvents lblCostPerItem As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStoneColor1 As System.Windows.Forms.TextBox
    Friend WithEvents lblStonePrice As System.Windows.Forms.Label
    Friend WithEvents lblStoneWeight As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblStoneName As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BtnTax As Button
    Friend WithEvents lblPr As Label
    Friend WithEvents txtTaxAmo As TextBox
    Friend WithEvents txtTaxTextAm As TextBox
    Friend WithEvents lblTaxAm As Label
    Friend WithEvents lblTotalPriceTitle As Label
    Friend WithEvents txtTotalPriceValue As TextBox
    Friend WithEvents txtTpriceTtax As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNote As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblInvoiceValue As Label
    Friend WithEvents lblInvoiceTitle As Label
    Friend WithEvents colTaxTextAm As DataGridViewTextBoxColumn
    Friend WithEvents colTaxAmo As DataGridViewTextBoxColumn
End Class


