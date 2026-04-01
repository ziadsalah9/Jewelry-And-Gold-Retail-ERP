<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accessories_AddItems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accessories_AddItems))
        Me.Accessories_NAMELabel = New System.Windows.Forms.Label()
        Me.Accessories_BRANDLabel = New System.Windows.Forms.Label()
        Me.Accessories_DESCLabel = New System.Windows.Forms.Label()
        Me.Accessories_CATLabel = New System.Windows.Forms.Label()
        Me.Accessories_nomTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Accessories_model_noTextBox = New System.Windows.Forms.TextBox()
        Me.pnlItemDetails = New System.Windows.Forms.Panel()
        Me.lblSupplier = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.txtAttachment = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblModelYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnItemName = New System.Windows.Forms.Button()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.AuctionItemTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDep = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.AuctionBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblItemNo = New System.Windows.Forms.Label()
        Me.lblModelNo = New System.Windows.Forms.Label()
        Me.txtModelNo = New System.Windows.Forms.TextBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.AccessoriesDEPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.AccessoriesCATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnItemPhoto = New System.Windows.Forms.Button()
        Me.Accessories_DEPLabel = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.pbItem = New System.Windows.Forms.PictureBox()
        Me.btnItemEdit = New System.Windows.Forms.Button()
        Me.btnItemNew = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.AccessoriesIDTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_BRANDTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CATTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_DEPTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_PICPictureBox = New System.Windows.Forms.PictureBox()
        Me.Accessories_TIMEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Accessories_DATE_CREDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Accessories_USER_CRETTextBox = New System.Windows.Forms.TextBox()
        Me.btnItemSave = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_BRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_model_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_CAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_DEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Year = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Attachment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_PIC = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colAccessories_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_DATE_CRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_USER_CRET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Accessories_ITEMTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ITEMTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Accessories_CATTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter()
        Me.Accessories_DEPTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_DEPTableAdapter()
        Me.Auction_BrandTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.Accessories_AttachmentsTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_SupplierTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Accessories_BRAND_SHORTTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_YearTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Auction_ItemTypeTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter()
        Me.btnBarCode = New System.Windows.Forms.Button()
        Me.Chk = New System.Windows.Forms.CheckBox()
        CType(Me.Accessories_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemDetails.SuspendLayout()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesDEPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accessories_PICPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Accessories_NAMELabel
        '
        Me.Accessories_NAMELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_NAMELabel.Location = New System.Drawing.Point(902, 15)
        Me.Accessories_NAMELabel.Name = "Accessories_NAMELabel"
        Me.Accessories_NAMELabel.Size = New System.Drawing.Size(107, 22)
        Me.Accessories_NAMELabel.TabIndex = 4
        Me.Accessories_NAMELabel.Text = "اسم الصنف"
        Me.Accessories_NAMELabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accessories_BRANDLabel
        '
        Me.Accessories_BRANDLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_BRANDLabel.Location = New System.Drawing.Point(902, 42)
        Me.Accessories_BRANDLabel.Name = "Accessories_BRANDLabel"
        Me.Accessories_BRANDLabel.Size = New System.Drawing.Size(107, 22)
        Me.Accessories_BRANDLabel.TabIndex = 6
        Me.Accessories_BRANDLabel.Text = "الماركة"
        Me.Accessories_BRANDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accessories_DESCLabel
        '
        Me.Accessories_DESCLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DESCLabel.Location = New System.Drawing.Point(902, 177)
        Me.Accessories_DESCLabel.Name = "Accessories_DESCLabel"
        Me.Accessories_DESCLabel.Size = New System.Drawing.Size(107, 22)
        Me.Accessories_DESCLabel.TabIndex = 8
        Me.Accessories_DESCLabel.Text = "الوصف"
        Me.Accessories_DESCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accessories_CATLabel
        '
        Me.Accessories_CATLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CATLabel.Location = New System.Drawing.Point(505, 15)
        Me.Accessories_CATLabel.Name = "Accessories_CATLabel"
        Me.Accessories_CATLabel.Size = New System.Drawing.Size(107, 22)
        Me.Accessories_CATLabel.TabIndex = 12
        Me.Accessories_CATLabel.Text = "الفئة"
        Me.Accessories_CATLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Accessories_nomTextBox
        '
        Me.Accessories_nomTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_nomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_nom", True))
        Me.Accessories_nomTextBox.Location = New System.Drawing.Point(-100, 176)
        Me.Accessories_nomTextBox.Name = "Accessories_nomTextBox"
        Me.Accessories_nomTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_nomTextBox.TabIndex = 43
        '
        'Accessories_ITEMBindingSource
        '
        Me.Accessories_ITEMBindingSource.DataMember = "Accessories_ITEM"
        Me.Accessories_ITEMBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Accessories_model_noTextBox
        '
        Me.Accessories_model_noTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_model_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_model_no", True))
        Me.Accessories_model_noTextBox.Location = New System.Drawing.Point(-21, 257)
        Me.Accessories_model_noTextBox.Name = "Accessories_model_noTextBox"
        Me.Accessories_model_noTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_model_noTextBox.TabIndex = 42
        '
        'pnlItemDetails
        '
        Me.pnlItemDetails.Controls.Add(Me.lblSupplier)
        Me.pnlItemDetails.Controls.Add(Me.txtSupplier)
        Me.pnlItemDetails.Controls.Add(Me.lblAttachment)
        Me.pnlItemDetails.Controls.Add(Me.txtAttachment)
        Me.pnlItemDetails.Controls.Add(Me.lblCode)
        Me.pnlItemDetails.Controls.Add(Me.txtCode)
        Me.pnlItemDetails.Controls.Add(Me.lblModelYear)
        Me.pnlItemDetails.Controls.Add(Me.txtYear)
        Me.pnlItemDetails.Controls.Add(Me.lblPrice)
        Me.pnlItemDetails.Controls.Add(Me.lblCost)
        Me.pnlItemDetails.Controls.Add(Me.txtCost)
        Me.pnlItemDetails.Controls.Add(Me.txtPrice)
        Me.pnlItemDetails.Controls.Add(Me.btnBrand)
        Me.pnlItemDetails.Controls.Add(Me.btnItemName)
        Me.pnlItemDetails.Controls.Add(Me.cmbItemName)
        Me.pnlItemDetails.Controls.Add(Me.btnDep)
        Me.pnlItemDetails.Controls.Add(Me.btnCat)
        Me.pnlItemDetails.Controls.Add(Me.cmbBrand)
        Me.pnlItemDetails.Controls.Add(Me.lblItemNo)
        Me.pnlItemDetails.Controls.Add(Me.lblModelNo)
        Me.pnlItemDetails.Controls.Add(Me.txtModelNo)
        Me.pnlItemDetails.Controls.Add(Me.txtItemNo)
        Me.pnlItemDetails.Controls.Add(Me.cmbDepartment)
        Me.pnlItemDetails.Controls.Add(Me.cmbCategory)
        Me.pnlItemDetails.Controls.Add(Me.btnItemPhoto)
        Me.pnlItemDetails.Controls.Add(Me.Accessories_DEPLabel)
        Me.pnlItemDetails.Controls.Add(Me.txtDescription)
        Me.pnlItemDetails.Controls.Add(Me.pbItem)
        Me.pnlItemDetails.Controls.Add(Me.Accessories_NAMELabel)
        Me.pnlItemDetails.Controls.Add(Me.Accessories_BRANDLabel)
        Me.pnlItemDetails.Controls.Add(Me.Accessories_DESCLabel)
        Me.pnlItemDetails.Controls.Add(Me.Accessories_CATLabel)
        Me.pnlItemDetails.Location = New System.Drawing.Point(7, 61)
        Me.pnlItemDetails.Name = "pnlItemDetails"
        Me.pnlItemDetails.Size = New System.Drawing.Size(1052, 217)
        Me.pnlItemDetails.TabIndex = 4
        '
        'lblSupplier
        '
        Me.lblSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSupplier.Location = New System.Drawing.Point(902, 150)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(107, 22)
        Me.lblSupplier.TabIndex = 64
        Me.lblSupplier.Text = "المورد"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSupplier
        '
        Me.txtSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSupplier.Location = New System.Drawing.Point(645, 148)
        Me.txtSupplier.MaxLength = 50
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSupplier.Size = New System.Drawing.Size(250, 32)
        Me.txtSupplier.TabIndex = 5
        Me.txtSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAttachment
        '
        Me.lblAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttachment.Location = New System.Drawing.Point(505, 150)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(107, 22)
        Me.lblAttachment.TabIndex = 63
        Me.lblAttachment.Text = "المرفقات"
        Me.lblAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAttachment
        '
        Me.txtAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAttachment.Location = New System.Drawing.Point(249, 148)
        Me.txtAttachment.MaxLength = 50
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAttachment.Size = New System.Drawing.Size(250, 32)
        Me.txtAttachment.TabIndex = 11
        Me.txtAttachment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.Location = New System.Drawing.Point(902, 123)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(107, 22)
        Me.lblCode.TabIndex = 60
        Me.lblCode.Text = "الرمز"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.Location = New System.Drawing.Point(645, 121)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCode.Size = New System.Drawing.Size(250, 32)
        Me.txtCode.TabIndex = 4
        Me.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblModelYear
        '
        Me.lblModelYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModelYear.Location = New System.Drawing.Point(505, 69)
        Me.lblModelYear.Name = "lblModelYear"
        Me.lblModelYear.Size = New System.Drawing.Size(107, 22)
        Me.lblModelYear.TabIndex = 58
        Me.lblModelYear.Text = "سنة الموديل"
        Me.lblModelYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtYear
        '
        Me.txtYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYear.Location = New System.Drawing.Point(249, 67)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtYear.Size = New System.Drawing.Size(250, 32)
        Me.txtYear.TabIndex = 8
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.Location = New System.Drawing.Point(505, 123)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(107, 22)
        Me.lblPrice.TabIndex = 56
        Me.lblPrice.Text = "سعر البيع"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCost
        '
        Me.lblCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCost.Location = New System.Drawing.Point(505, 96)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(107, 22)
        Me.lblCost.TabIndex = 55
        Me.lblCost.Text = "تكلفة الشراء"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCost
        '
        Me.txtCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCost.Location = New System.Drawing.Point(249, 94)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCost.Size = New System.Drawing.Size(250, 32)
        Me.txtCost.TabIndex = 9
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.Location = New System.Drawing.Point(249, 121)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrice.Size = New System.Drawing.Size(250, 32)
        Me.txtPrice.TabIndex = 10
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBrand
        '
        Me.btnBrand.Location = New System.Drawing.Point(644, 39)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(36, 29)
        Me.btnBrand.TabIndex = 14
        Me.btnBrand.Text = "+"
        Me.btnBrand.UseVisualStyleBackColor = True
        '
        'btnItemName
        '
        Me.btnItemName.Location = New System.Drawing.Point(644, 12)
        Me.btnItemName.Name = "btnItemName"
        Me.btnItemName.Size = New System.Drawing.Size(36, 29)
        Me.btnItemName.TabIndex = 13
        Me.btnItemName.Text = "+"
        Me.btnItemName.UseVisualStyleBackColor = True
        '
        'cmbItemName
        '
        Me.cmbItemName.DataSource = Me.AuctionItemTypeBindingSource
        Me.cmbItemName.DisplayMember = "Auction_Type"
        Me.cmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(680, 13)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(215, 32)
        Me.cmbItemName.TabIndex = 0
        Me.cmbItemName.ValueMember = "Auction_Type"
        '
        'AuctionItemTypeBindingSource
        '
        Me.AuctionItemTypeBindingSource.DataMember = "Auction_ItemType"
        Me.AuctionItemTypeBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'btnDep
        '
        Me.btnDep.Location = New System.Drawing.Point(248, 39)
        Me.btnDep.Name = "btnDep"
        Me.btnDep.Size = New System.Drawing.Size(36, 29)
        Me.btnDep.TabIndex = 16
        Me.btnDep.Text = "+"
        Me.btnDep.UseVisualStyleBackColor = True
        '
        'btnCat
        '
        Me.btnCat.Location = New System.Drawing.Point(248, 12)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(36, 29)
        Me.btnCat.TabIndex = 15
        Me.btnCat.Text = "+"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'cmbBrand
        '
        Me.cmbBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBrand.DataSource = Me.AuctionBrandBindingSource
        Me.cmbBrand.DisplayMember = "Brand_Name"
        Me.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(680, 40)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(215, 32)
        Me.cmbBrand.TabIndex = 1
        Me.cmbBrand.ValueMember = "Brand_Name_Short"
        '
        'AuctionBrandBindingSource
        '
        Me.AuctionBrandBindingSource.DataMember = "Auction_Brand"
        Me.AuctionBrandBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'lblItemNo
        '
        Me.lblItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemNo.Location = New System.Drawing.Point(902, 96)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(107, 22)
        Me.lblItemNo.TabIndex = 47
        Me.lblItemNo.Text = "رقم القطعة"
        Me.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModelNo
        '
        Me.lblModelNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModelNo.Location = New System.Drawing.Point(902, 69)
        Me.lblModelNo.Name = "lblModelNo"
        Me.lblModelNo.Size = New System.Drawing.Size(107, 22)
        Me.lblModelNo.TabIndex = 46
        Me.lblModelNo.Text = "رقم الموديل"
        Me.lblModelNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtModelNo
        '
        Me.txtModelNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelNo.Location = New System.Drawing.Point(645, 67)
        Me.txtModelNo.Name = "txtModelNo"
        Me.txtModelNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtModelNo.Size = New System.Drawing.Size(250, 32)
        Me.txtModelNo.TabIndex = 2
        Me.txtModelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemNo
        '
        Me.txtItemNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemNo.Location = New System.Drawing.Point(645, 94)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtItemNo.Size = New System.Drawing.Size(250, 32)
        Me.txtItemNo.TabIndex = 3
        Me.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDepartment
        '
        Me.cmbDepartment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDepartment.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccessoriesDEPBindingSource, "Accessories_DEP_ID", True))
        Me.cmbDepartment.DataSource = Me.AccessoriesDEPBindingSource
        Me.cmbDepartment.DisplayMember = "Accessories_DEP_NAME"
        Me.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(284, 40)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(215, 32)
        Me.cmbDepartment.TabIndex = 7
        Me.cmbDepartment.ValueMember = "Accessories_DEP_ID"
        '
        'AccessoriesDEPBindingSource
        '
        Me.AccessoriesDEPBindingSource.DataMember = "Accessories_DEP"
        Me.AccessoriesDEPBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'cmbCategory
        '
        Me.cmbCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCategory.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AccessoriesCATBindingSource, "Accessories_CAT_ID", True))
        Me.cmbCategory.DataSource = Me.AccessoriesCATBindingSource
        Me.cmbCategory.DisplayMember = "Accessories_CAT_NAME"
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(284, 13)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(215, 32)
        Me.cmbCategory.TabIndex = 6
        Me.cmbCategory.ValueMember = "Accessories_CAT_ID"
        '
        'AccessoriesCATBindingSource
        '
        Me.AccessoriesCATBindingSource.DataMember = "Accessories_CAT"
        Me.AccessoriesCATBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'btnItemPhoto
        '
        Me.btnItemPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItemPhoto.Location = New System.Drawing.Point(8, 13)
        Me.btnItemPhoto.Name = "btnItemPhoto"
        Me.btnItemPhoto.Size = New System.Drawing.Size(233, 54)
        Me.btnItemPhoto.TabIndex = 17
        Me.btnItemPhoto.Text = "إضافة صورة المنتج"
        Me.btnItemPhoto.UseVisualStyleBackColor = True
        '
        'Accessories_DEPLabel
        '
        Me.Accessories_DEPLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DEPLabel.Location = New System.Drawing.Point(505, 42)
        Me.Accessories_DEPLabel.Name = "Accessories_DEPLabel"
        Me.Accessories_DEPLabel.Size = New System.Drawing.Size(107, 22)
        Me.Accessories_DEPLabel.TabIndex = 42
        Me.Accessories_DEPLabel.Text = "القسم"
        Me.Accessories_DEPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(248, 175)
        Me.txtDescription.MaxLength = 700
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescription.Size = New System.Drawing.Size(647, 32)
        Me.txtDescription.TabIndex = 12
        Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbItem
        '
        Me.pbItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbItem.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Accessories_ITEMBindingSource, "Accessories_PIC", True))
        Me.pbItem.Location = New System.Drawing.Point(8, 69)
        Me.pbItem.Name = "pbItem"
        Me.pbItem.Size = New System.Drawing.Size(233, 133)
        Me.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbItem.TabIndex = 31
        Me.pbItem.TabStop = False
        '
        'btnItemEdit
        '
        Me.btnItemEdit.BackColor = System.Drawing.Color.White
        Me.btnItemEdit.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnItemEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemEdit.Location = New System.Drawing.Point(297, 10)
        Me.btnItemEdit.Name = "btnItemEdit"
        Me.btnItemEdit.Size = New System.Drawing.Size(180, 45)
        Me.btnItemEdit.TabIndex = 1
        Me.btnItemEdit.Text = "تعديل سابق"
        Me.btnItemEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemEdit.UseVisualStyleBackColor = False
        '
        'btnItemNew
        '
        Me.btnItemNew.BackColor = System.Drawing.Color.White
        Me.btnItemNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnItemNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemNew.Location = New System.Drawing.Point(879, 10)
        Me.btnItemNew.Name = "btnItemNew"
        Me.btnItemNew.Size = New System.Drawing.Size(180, 45)
        Me.btnItemNew.TabIndex = 0
        Me.btnItemNew.Text = "إضافة جديد"
        Me.btnItemNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemNew.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Location = New System.Drawing.Point(-100, 149)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(58, 32)
        Me.txtUserName.TabIndex = 34
        '
        'AccessoriesIDTextBox
        '
        Me.AccessoriesIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "AccessoriesID", True))
        Me.AccessoriesIDTextBox.Location = New System.Drawing.Point(-21, 68)
        Me.AccessoriesIDTextBox.Name = "AccessoriesIDTextBox"
        Me.AccessoriesIDTextBox.Size = New System.Drawing.Size(58, 32)
        Me.AccessoriesIDTextBox.TabIndex = 3
        '
        'Accessories_NAMETextBox
        '
        Me.Accessories_NAMETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_NAME", True))
        Me.Accessories_NAMETextBox.Location = New System.Drawing.Point(-21, 95)
        Me.Accessories_NAMETextBox.Name = "Accessories_NAMETextBox"
        Me.Accessories_NAMETextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_NAMETextBox.TabIndex = 5
        '
        'Accessories_BRANDTextBox
        '
        Me.Accessories_BRANDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_BRANDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_BRAND", True))
        Me.Accessories_BRANDTextBox.Location = New System.Drawing.Point(-21, 122)
        Me.Accessories_BRANDTextBox.Name = "Accessories_BRANDTextBox"
        Me.Accessories_BRANDTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_BRANDTextBox.TabIndex = 7
        '
        'Accessories_DESCTextBox
        '
        Me.Accessories_DESCTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_DESC", True))
        Me.Accessories_DESCTextBox.Location = New System.Drawing.Point(-21, 176)
        Me.Accessories_DESCTextBox.Name = "Accessories_DESCTextBox"
        Me.Accessories_DESCTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_DESCTextBox.TabIndex = 9
        '
        'Accessories_CATTextBox
        '
        Me.Accessories_CATTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_CAT", True))
        Me.Accessories_CATTextBox.Location = New System.Drawing.Point(-21, 203)
        Me.Accessories_CATTextBox.Name = "Accessories_CATTextBox"
        Me.Accessories_CATTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_CATTextBox.TabIndex = 13
        '
        'Accessories_DEPTextBox
        '
        Me.Accessories_DEPTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_DEP", True))
        Me.Accessories_DEPTextBox.Location = New System.Drawing.Point(-21, 230)
        Me.Accessories_DEPTextBox.Name = "Accessories_DEPTextBox"
        Me.Accessories_DEPTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_DEPTextBox.TabIndex = 15
        '
        'Accessories_PICPictureBox
        '
        Me.Accessories_PICPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_PICPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Accessories_ITEMBindingSource, "Accessories_PIC", True))
        Me.Accessories_PICPictureBox.Location = New System.Drawing.Point(-21, 284)
        Me.Accessories_PICPictureBox.Name = "Accessories_PICPictureBox"
        Me.Accessories_PICPictureBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_PICPictureBox.TabIndex = 17
        Me.Accessories_PICPictureBox.TabStop = False
        '
        'Accessories_TIMEDateTimePicker
        '
        Me.Accessories_TIMEDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_TIMEDateTimePicker.CustomFormat = "hh:MM:ss tt"
        Me.Accessories_TIMEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_ITEMBindingSource, "Accessories_TIME", True))
        Me.Accessories_TIMEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Accessories_TIMEDateTimePicker.Location = New System.Drawing.Point(-100, 68)
        Me.Accessories_TIMEDateTimePicker.Name = "Accessories_TIMEDateTimePicker"
        Me.Accessories_TIMEDateTimePicker.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_TIMEDateTimePicker.TabIndex = 19
        '
        'Accessories_DATE_CREDateTimePicker
        '
        Me.Accessories_DATE_CREDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DATE_CREDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.Accessories_DATE_CREDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_ITEMBindingSource, "Accessories_DATE_CRE", True))
        Me.Accessories_DATE_CREDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Accessories_DATE_CREDateTimePicker.Location = New System.Drawing.Point(-100, 95)
        Me.Accessories_DATE_CREDateTimePicker.Name = "Accessories_DATE_CREDateTimePicker"
        Me.Accessories_DATE_CREDateTimePicker.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_DATE_CREDateTimePicker.TabIndex = 21
        '
        'Accessories_USER_CRETTextBox
        '
        Me.Accessories_USER_CRETTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_USER_CRETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_USER_CRET", True))
        Me.Accessories_USER_CRETTextBox.Location = New System.Drawing.Point(-100, 122)
        Me.Accessories_USER_CRETTextBox.Name = "Accessories_USER_CRETTextBox"
        Me.Accessories_USER_CRETTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_USER_CRETTextBox.TabIndex = 23
        '
        'btnItemSave
        '
        Me.btnItemSave.BackColor = System.Drawing.Color.White
        Me.btnItemSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnItemSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemSave.Location = New System.Drawing.Point(587, 10)
        Me.btnItemSave.Name = "btnItemSave"
        Me.btnItemSave.Size = New System.Drawing.Size(180, 45)
        Me.btnItemSave.TabIndex = 3
        Me.btnItemSave.Text = "حفظ"
        Me.btnItemSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemSave.UseVisualStyleBackColor = False
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.AutoGenerateColumns = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.colAccessoriesID, Me.colAccessories_NAME, Me.colAccessories_BRAND, Me.colAccessories_model_no, Me.colAccessories_nom, Me.colAccessories_Code, Me.colAccessories_Supplier, Me.colAccessories_CAT, Me.colAccessories_DEP, Me.colAccessories_Year, Me.colAccessories_Cost, Me.colAccessories_Price, Me.colAccessories_Attachment, Me.colAccessories_DESC, Me.colAccessories_PIC, Me.colAccessories_TIME, Me.colAccessories_DATE_CRE, Me.colAccessories_USER_CRET, Me.colDelete})
        Me.grid.DataSource = Me.Accessories_ITEMBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.Location = New System.Drawing.Point(7, 284)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidth = 55
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1054, 330)
        Me.grid.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "#NO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'colAccessoriesID
        '
        Me.colAccessoriesID.DataPropertyName = "AccessoriesID"
        Me.colAccessoriesID.HeaderText = "الباركود"
        Me.colAccessoriesID.MinimumWidth = 6
        Me.colAccessoriesID.Name = "colAccessoriesID"
        Me.colAccessoriesID.ReadOnly = True
        '
        'colAccessories_NAME
        '
        Me.colAccessories_NAME.DataPropertyName = "Accessories_NAME"
        Me.colAccessories_NAME.HeaderText = "اسم الصنف"
        Me.colAccessories_NAME.MinimumWidth = 6
        Me.colAccessories_NAME.Name = "colAccessories_NAME"
        Me.colAccessories_NAME.ReadOnly = True
        '
        'colAccessories_BRAND
        '
        Me.colAccessories_BRAND.DataPropertyName = "Accessories_BRAND"
        Me.colAccessories_BRAND.HeaderText = "الماركة"
        Me.colAccessories_BRAND.MinimumWidth = 6
        Me.colAccessories_BRAND.Name = "colAccessories_BRAND"
        Me.colAccessories_BRAND.ReadOnly = True
        '
        'colAccessories_model_no
        '
        Me.colAccessories_model_no.DataPropertyName = "Accessories_model_no"
        Me.colAccessories_model_no.HeaderText = "رقم الموديل"
        Me.colAccessories_model_no.MinimumWidth = 6
        Me.colAccessories_model_no.Name = "colAccessories_model_no"
        Me.colAccessories_model_no.ReadOnly = True
        '
        'colAccessories_nom
        '
        Me.colAccessories_nom.DataPropertyName = "Accessories_nom"
        Me.colAccessories_nom.HeaderText = "رقم القطعة"
        Me.colAccessories_nom.MinimumWidth = 6
        Me.colAccessories_nom.Name = "colAccessories_nom"
        Me.colAccessories_nom.ReadOnly = True
        '
        'colAccessories_Code
        '
        Me.colAccessories_Code.DataPropertyName = "Accessories_Code"
        Me.colAccessories_Code.HeaderText = "الرمز"
        Me.colAccessories_Code.MinimumWidth = 6
        Me.colAccessories_Code.Name = "colAccessories_Code"
        Me.colAccessories_Code.ReadOnly = True
        '
        'colAccessories_Supplier
        '
        Me.colAccessories_Supplier.DataPropertyName = "Accessories_Supplier"
        Me.colAccessories_Supplier.HeaderText = "المورد"
        Me.colAccessories_Supplier.MinimumWidth = 6
        Me.colAccessories_Supplier.Name = "colAccessories_Supplier"
        Me.colAccessories_Supplier.ReadOnly = True
        '
        'colAccessories_CAT
        '
        Me.colAccessories_CAT.DataPropertyName = "Accessories_CAT"
        Me.colAccessories_CAT.HeaderText = "الفئة"
        Me.colAccessories_CAT.MinimumWidth = 6
        Me.colAccessories_CAT.Name = "colAccessories_CAT"
        Me.colAccessories_CAT.ReadOnly = True
        '
        'colAccessories_DEP
        '
        Me.colAccessories_DEP.DataPropertyName = "Accessories_DEP"
        Me.colAccessories_DEP.HeaderText = "القسم"
        Me.colAccessories_DEP.MinimumWidth = 6
        Me.colAccessories_DEP.Name = "colAccessories_DEP"
        Me.colAccessories_DEP.ReadOnly = True
        '
        'colAccessories_Year
        '
        Me.colAccessories_Year.DataPropertyName = "Accessories_Year"
        Me.colAccessories_Year.HeaderText = "سنة الموديل"
        Me.colAccessories_Year.MinimumWidth = 6
        Me.colAccessories_Year.Name = "colAccessories_Year"
        Me.colAccessories_Year.ReadOnly = True
        '
        'colAccessories_Cost
        '
        Me.colAccessories_Cost.DataPropertyName = "Accessories_Cost"
        Me.colAccessories_Cost.HeaderText = "التكلفة"
        Me.colAccessories_Cost.MinimumWidth = 6
        Me.colAccessories_Cost.Name = "colAccessories_Cost"
        Me.colAccessories_Cost.ReadOnly = True
        '
        'colAccessories_Price
        '
        Me.colAccessories_Price.DataPropertyName = "Accessories_Price"
        Me.colAccessories_Price.HeaderText = "السعر"
        Me.colAccessories_Price.MinimumWidth = 6
        Me.colAccessories_Price.Name = "colAccessories_Price"
        Me.colAccessories_Price.ReadOnly = True
        '
        'colAccessories_Attachment
        '
        Me.colAccessories_Attachment.DataPropertyName = "Accessories_Attachments"
        Me.colAccessories_Attachment.HeaderText = "المرفقات"
        Me.colAccessories_Attachment.MinimumWidth = 6
        Me.colAccessories_Attachment.Name = "colAccessories_Attachment"
        Me.colAccessories_Attachment.ReadOnly = True
        '
        'colAccessories_DESC
        '
        Me.colAccessories_DESC.DataPropertyName = "Accessories_DESC"
        Me.colAccessories_DESC.HeaderText = "الوصف"
        Me.colAccessories_DESC.MinimumWidth = 6
        Me.colAccessories_DESC.Name = "colAccessories_DESC"
        Me.colAccessories_DESC.ReadOnly = True
        '
        'colAccessories_PIC
        '
        Me.colAccessories_PIC.DataPropertyName = "Accessories_PIC"
        Me.colAccessories_PIC.HeaderText = "Accessories_PIC"
        Me.colAccessories_PIC.MinimumWidth = 6
        Me.colAccessories_PIC.Name = "colAccessories_PIC"
        Me.colAccessories_PIC.ReadOnly = True
        Me.colAccessories_PIC.Visible = False
        '
        'colAccessories_TIME
        '
        Me.colAccessories_TIME.DataPropertyName = "Accessories_TIME"
        Me.colAccessories_TIME.HeaderText = "Accessories_TIME"
        Me.colAccessories_TIME.MinimumWidth = 6
        Me.colAccessories_TIME.Name = "colAccessories_TIME"
        Me.colAccessories_TIME.ReadOnly = True
        Me.colAccessories_TIME.Visible = False
        '
        'colAccessories_DATE_CRE
        '
        Me.colAccessories_DATE_CRE.DataPropertyName = "Accessories_DATE_CRE"
        Me.colAccessories_DATE_CRE.HeaderText = "Accessories_DATE_CRE"
        Me.colAccessories_DATE_CRE.MinimumWidth = 6
        Me.colAccessories_DATE_CRE.Name = "colAccessories_DATE_CRE"
        Me.colAccessories_DATE_CRE.ReadOnly = True
        Me.colAccessories_DATE_CRE.Visible = False
        '
        'colAccessories_USER_CRET
        '
        Me.colAccessories_USER_CRET.DataPropertyName = "Accessories_USER_CRET"
        Me.colAccessories_USER_CRET.HeaderText = "Accessories_USER_CRET"
        Me.colAccessories_USER_CRET.MinimumWidth = 6
        Me.colAccessories_USER_CRET.Name = "colAccessories_USER_CRET"
        Me.colAccessories_USER_CRET.ReadOnly = True
        Me.colAccessories_USER_CRET.Visible = False
        '
        'colDelete
        '
        Me.colDelete.FillWeight = 40.0!
        Me.colDelete.HeaderText = "حذف"
        Me.colDelete.MinimumWidth = 6
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        '
        'Accessories_ITEMTableAdapter
        '
        Me.Accessories_ITEMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accessories_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BAYTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_Buy_PayTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BuyTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_CATTableAdapter = Me.Accessories_CATTableAdapter
        Me.TableAdapterManager.Accessories_DEPTableAdapter = Me.Accessories_DEPTableAdapter
        Me.TableAdapterManager.Accessories_INVTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_ITEMTableAdapter = Me.Accessories_ITEMTableAdapter
        Me.TableAdapterManager.ADS_SERVICESTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarcodeSetTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
        Me.TableAdapterManager.BAYWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.Buy_DiamondTableAdapter = Nothing
        Me.TableAdapterManager.Buy_GoldTableAdapter = Nothing
        Me.TableAdapterManager.cacherTableAdapter = Nothing
        Me.TableAdapterManager.CANTRYTableAdapter = Nothing
        Me.TableAdapterManager.CastomerDETELSTableAdapter = Nothing
        Me.TableAdapterManager.COMP_BAYTableAdapter = Nothing
        Me.TableAdapterManager.COMP_detels_for_bayTableAdapter = Nothing
        Me.TableAdapterManager.comp_detelsTableAdapter = Nothing
        Me.TableAdapterManager.comp_informTableAdapter = Nothing
        Me.TableAdapterManager.COMP_INVOCE_CACHETableAdapter = Nothing
        Me.TableAdapterManager.COMPANY_BAY_DETELSTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcood_dimonTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcoodTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTypeTableAdapter = Nothing
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTypeTableAdapter = Nothing
        Me.TableAdapterManager.EXTR_NAMETableAdapter = Nothing
        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.Item_NameTableAdapter = Nothing
        Me.TableAdapterManager.LICENSE_TTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.PayInstallmentTableAdapter = Nothing
        Me.TableAdapterManager.PayMethodTableAdapter = Nothing
        Me.TableAdapterManager.ReportPathTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.SilverBAYTableAdapter = Nothing
        Me.TableAdapterManager.SilverInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.SilverItemTableAdapter = Nothing
        Me.TableAdapterManager.SndGoldTableAdapter = Nothing
        Me.TableAdapterManager.SndToCustomerTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.TBBondGoldTypeTableAdapter = Nothing
        Me.TableAdapterManager.TBBondTypeTableAdapter = Nothing
        Me.TableAdapterManager.TBErrorDescriptionTableAdapter = Nothing
        Me.TableAdapterManager.TPBank_InfoTableAdapter = Nothing
        Me.TableAdapterManager.TPBranchDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanyBranchesTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanyInfoTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanylicenseIDTableAdapter = Nothing
        Me.TableAdapterManager.TPGoldVoucherReceiveTableAdapter = Nothing
        Me.TableAdapterManager.TPGoldVoucherTableAdapter = Nothing
        Me.TableAdapterManager.TPSellBuyWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.TpSetGoledPriceDiffTableAdapter = Nothing
        Me.TableAdapterManager.TPTaxTableAdapter = Nothing
        Me.TableAdapterManager.TPTransferTableAdapter = Nothing
        Me.TableAdapterManager.TPWhatsAppMessagesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Accessories_CATTableAdapter
        '
        Me.Accessories_CATTableAdapter.ClearBeforeFill = True
        '
        'Accessories_DEPTableAdapter
        '
        Me.Accessories_DEPTableAdapter.ClearBeforeFill = True
        '
        'Auction_BrandTableAdapter
        '
        Me.Auction_BrandTableAdapter.ClearBeforeFill = True
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Accessories_AttachmentsTextBox)
        Me.pnl.Controls.Add(Me.Accessories_SupplierTextBox)
        Me.pnl.Controls.Add(Me.ListBox1)
        Me.pnl.Controls.Add(Me.Accessories_BRAND_SHORTTextBox)
        Me.pnl.Controls.Add(Me.Accessories_YearTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CodeTextBox)
        Me.pnl.Controls.Add(Me.Accessories_PriceTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CostTextBox)
        Me.pnl.Controls.Add(Me.AccessoriesIDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_nomTextBox)
        Me.pnl.Controls.Add(Me.Accessories_USER_CRETTextBox)
        Me.pnl.Controls.Add(Me.Accessories_model_noTextBox)
        Me.pnl.Controls.Add(Me.Accessories_DATE_CREDateTimePicker)
        Me.pnl.Controls.Add(Me.Accessories_TIMEDateTimePicker)
        Me.pnl.Controls.Add(Me.Accessories_PICPictureBox)
        Me.pnl.Controls.Add(Me.Accessories_DEPTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CATTextBox)
        Me.pnl.Controls.Add(Me.Accessories_DESCTextBox)
        Me.pnl.Controls.Add(Me.txtUserName)
        Me.pnl.Controls.Add(Me.Accessories_BRANDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_NAMETextBox)
        Me.pnl.Location = New System.Drawing.Point(1133, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(84, 43)
        Me.pnl.TabIndex = 44
        '
        'Accessories_AttachmentsTextBox
        '
        Me.Accessories_AttachmentsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_AttachmentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Attachments", True))
        Me.Accessories_AttachmentsTextBox.Location = New System.Drawing.Point(-21, 311)
        Me.Accessories_AttachmentsTextBox.Name = "Accessories_AttachmentsTextBox"
        Me.Accessories_AttachmentsTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_AttachmentsTextBox.TabIndex = 65
        '
        'Accessories_SupplierTextBox
        '
        Me.Accessories_SupplierTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_SupplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Supplier", True))
        Me.Accessories_SupplierTextBox.Location = New System.Drawing.Point(-100, 311)
        Me.Accessories_SupplierTextBox.Name = "Accessories_SupplierTextBox"
        Me.Accessories_SupplierTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_SupplierTextBox.TabIndex = 64
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(-100, 338)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(137, 4)
        Me.ListBox1.TabIndex = 63
        '
        'Accessories_BRAND_SHORTTextBox
        '
        Me.Accessories_BRAND_SHORTTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_BRAND_SHORTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_BRAND_SHORT", True))
        Me.Accessories_BRAND_SHORTTextBox.Location = New System.Drawing.Point(-21, 149)
        Me.Accessories_BRAND_SHORTTextBox.Name = "Accessories_BRAND_SHORTTextBox"
        Me.Accessories_BRAND_SHORTTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_BRAND_SHORTTextBox.TabIndex = 48
        '
        'Accessories_YearTextBox
        '
        Me.Accessories_YearTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Year", True))
        Me.Accessories_YearTextBox.Location = New System.Drawing.Point(-100, 284)
        Me.Accessories_YearTextBox.Name = "Accessories_YearTextBox"
        Me.Accessories_YearTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_YearTextBox.TabIndex = 47
        '
        'Accessories_CodeTextBox
        '
        Me.Accessories_CodeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Code", True))
        Me.Accessories_CodeTextBox.Location = New System.Drawing.Point(-100, 257)
        Me.Accessories_CodeTextBox.Name = "Accessories_CodeTextBox"
        Me.Accessories_CodeTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_CodeTextBox.TabIndex = 46
        '
        'Accessories_PriceTextBox
        '
        Me.Accessories_PriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Price", True))
        Me.Accessories_PriceTextBox.Location = New System.Drawing.Point(-100, 203)
        Me.Accessories_PriceTextBox.Name = "Accessories_PriceTextBox"
        Me.Accessories_PriceTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_PriceTextBox.TabIndex = 45
        '
        'Accessories_CostTextBox
        '
        Me.Accessories_CostTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Cost", True))
        Me.Accessories_CostTextBox.Location = New System.Drawing.Point(-100, 230)
        Me.Accessories_CostTextBox.Name = "Accessories_CostTextBox"
        Me.Accessories_CostTextBox.Size = New System.Drawing.Size(58, 32)
        Me.Accessories_CostTextBox.TabIndex = 44
        '
        'Auction_ItemTypeTableAdapter
        '
        Me.Auction_ItemTypeTableAdapter.ClearBeforeFill = True
        '
        'btnBarCode
        '
        Me.btnBarCode.BackColor = System.Drawing.Color.White
        Me.btnBarCode.Image = Global.DT_restrant.My.Resources.Resources.BarCode
        Me.btnBarCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBarCode.Location = New System.Drawing.Point(7, 10)
        Me.btnBarCode.Name = "btnBarCode"
        Me.btnBarCode.Size = New System.Drawing.Size(180, 45)
        Me.btnBarCode.TabIndex = 2
        Me.btnBarCode.Text = "طباعة باركود"
        Me.btnBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarCode.UseVisualStyleBackColor = False
        '
        'Chk
        '
        Me.Chk.AutoSize = True
        Me.Chk.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk.Location = New System.Drawing.Point(9, 616)
        Me.Chk.Name = "Chk"
        Me.Chk.Size = New System.Drawing.Size(174, 41)
        Me.Chk.TabIndex = 62
        Me.Chk.Text = "CheckBox1"
        Me.Chk.UseVisualStyleBackColor = True
        '
        'Accessories_AddItems
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1064, 647)
        Me.Controls.Add(Me.Chk)
        Me.Controls.Add(Me.btnBarCode)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.pnlItemDetails)
        Me.Controls.Add(Me.btnItemEdit)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btnItemNew)
        Me.Controls.Add(Me.btnItemSave)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Accessories_AddItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاصناف"
        CType(Me.Accessories_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemDetails.ResumeLayout(False)
        Me.pnlItemDetails.PerformLayout()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesDEPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accessories_PICPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Accessories_ITEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_ITEMTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ITEMTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnItemSave As System.Windows.Forms.Button
    Friend WithEvents btnItemNew As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents pbItem As System.Windows.Forms.PictureBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents AccessoriesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_BRANDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_DEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_PICPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Accessories_TIMEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Accessories_DATE_CREDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Accessories_USER_CRETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnItemPhoto As System.Windows.Forms.Button
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Accessories_CATTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter
    Friend WithEvents AccessoriesCATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_DEPTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_DEPTableAdapter
    Friend WithEvents AccessoriesDEPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_NAMELabel As System.Windows.Forms.Label
    Friend WithEvents Accessories_BRANDLabel As System.Windows.Forms.Label
    Friend WithEvents Accessories_DESCLabel As System.Windows.Forms.Label
    Friend WithEvents Accessories_CATLabel As System.Windows.Forms.Label
    Friend WithEvents btnItemEdit As System.Windows.Forms.Button
    Friend WithEvents pnlItemDetails As System.Windows.Forms.Panel
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Accessories_DEPLabel As System.Windows.Forms.Label
    Friend WithEvents lblItemNo As System.Windows.Forms.Label
    Friend WithEvents lblModelNo As System.Windows.Forms.Label
    Friend WithEvents txtModelNo As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_nomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_model_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents AuctionBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_BrandTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents btnDep As Button
    Friend WithEvents btnCat As Button
    Friend WithEvents btnBrand As Button
    Friend WithEvents btnItemName As Button
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents AuctionItemTypeBindingSource As BindingSource
    Friend WithEvents Auction_ItemTypeTableAdapter As DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBarCode As System.Windows.Forms.Button
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents lblModelYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_BRAND_SHORTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Chk As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Accessories_AttachmentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_SupplierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSupplier As System.Windows.Forms.TextBox
    Friend WithEvents lblAttachment As System.Windows.Forms.Label
    Friend WithEvents txtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_BRAND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_model_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_CAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_DEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Year As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Cost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Attachment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_PIC As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colAccessories_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_DATE_CRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_USER_CRET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
End Class
