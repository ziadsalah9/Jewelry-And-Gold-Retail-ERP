<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuctionAddItemDetails
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuctionAddItemDetails))
        Me.AuctionAddItemDetailsVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbBrand_Name = New System.Windows.Forms.ComboBox()
        Me.AuctionBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Auction_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNewUsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuaranteeStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuaranteeDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiveDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPhoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomerNAme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomerADr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomerTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomerNA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Signature = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AuctionAddItemDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbItemData = New System.Windows.Forms.GroupBox()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.CacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.dtReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbAuction_Type = New System.Windows.Forms.ComboBox()
        Me.AuctionItemTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPhoto = New System.Windows.Forms.LinkLabel()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.txtItemDetails = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeStatus = New System.Windows.Forms.Label()
        Me.lblReceiveDate = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeDate = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmbGuaranteeStatus = New System.Windows.Forms.ComboBox()
        Me.AuctionGuaranteeStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbItemStatus = New System.Windows.Forms.ComboBox()
        Me.AuctionItemStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnItemStatus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddItemName = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnGuaranteeStatus = New System.Windows.Forms.Button()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Auction_AddItemDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAuction_TypeDB = New System.Windows.Forms.TextBox()
        Me.txtBrand_NameDB = New System.Windows.Forms.TextBox()
        Me.txtModelDB = New System.Windows.Forms.TextBox()
        Me.txtSerialNoDB = New System.Windows.Forms.TextBox()
        Me.txtItemStatusDB = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeStatusDB = New System.Windows.Forms.TextBox()
        Me.txtItemDetailsDB = New System.Windows.Forms.TextBox()
        Me.txtPriceDB = New System.Windows.Forms.TextBox()
        Me.txtAuction_IDDB = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtAuctionIDVw = New System.Windows.Forms.TextBox()
        Me.Auction_ItemTypeTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter()
        Me.Auction_BrandTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter()
        Me.Auction_GuaranteeStatusTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_GuaranteeStatusTableAdapter()
        Me.Auction_ItemStatusTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemStatusTableAdapter()
        Me.AuctionAddItemDetailsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_AddItemDetailsTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.AuctionAddItemDetailsVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AuctionAddItemDetailsVwTableAdapter()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.txtGuaranteeDateDB = New System.Windows.Forms.TextBox()
        Me.CacherIDTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.pbImageDB = New System.Windows.Forms.PictureBox()
        Me.dtReceiveDateDB = New System.Windows.Forms.DateTimePicker()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.CacherTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dtGuaranteeDate = New System.Windows.Forms.TextBox()
        CType(Me.AuctionAddItemDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionAddItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionGuaranteeStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionItemStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Auction_AddItemDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.pbImageDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuctionAddItemDetailsVwBindingSource
        '
        Me.AuctionAddItemDetailsVwBindingSource.DataMember = "AuctionAddItemDetailsVw"
        Me.AuctionAddItemDetailsVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.White
        Me.txtModel.ForeColor = System.Drawing.Color.Black
        Me.txtModel.Location = New System.Drawing.Point(725, 69)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(125, 24)
        Me.txtModel.TabIndex = 2
        Me.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbBrand_Name
        '
        Me.cmbBrand_Name.BackColor = System.Drawing.Color.White
        Me.cmbBrand_Name.DataSource = Me.AuctionBrandBindingSource
        Me.cmbBrand_Name.DisplayMember = "Brand_Name"
        Me.cmbBrand_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrand_Name.ForeColor = System.Drawing.Color.Black
        Me.cmbBrand_Name.FormattingEnabled = True
        Me.cmbBrand_Name.Location = New System.Drawing.Point(725, 46)
        Me.cmbBrand_Name.Name = "cmbBrand_Name"
        Me.cmbBrand_Name.Size = New System.Drawing.Size(125, 23)
        Me.cmbBrand_Name.TabIndex = 1
        Me.cmbBrand_Name.ValueMember = "Brand_ID"
        '
        'AuctionBrandBindingSource
        '
        Me.AuctionBrandBindingSource.DataMember = "Auction_Brand"
        Me.AuctionBrandBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'txtSerialNo
        '
        Me.txtSerialNo.BackColor = System.Drawing.Color.White
        Me.txtSerialNo.ForeColor = System.Drawing.Color.Black
        Me.txtSerialNo.Location = New System.Drawing.Point(725, 93)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerialNo.Size = New System.Drawing.Size(125, 24)
        Me.txtSerialNo.TabIndex = 3
        Me.txtSerialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.AutoGenerateColumns = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.Silver
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid.CausesValidation = False
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeight = 30
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Auction_ID, Me.NameType, Me.Brand, Me.Model, Me.SerialNo, Me.ItemNewUsed, Me.GuaranteeStatus, Me.GuaranteeDate, Me.ReceiveDate, Me.Details, Me.ItemPhoto, Me.Price, Me.CastomerID, Me.CastomerNAme, Me.CastomerADr, Me.CastomerTE, Me.CastomerNA, Me.foto, Me.Signature, Me.Delete})
        Me.grid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid.DataSource = Me.AuctionAddItemDetailsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.GridColor = System.Drawing.Color.Silver
        Me.grid.Location = New System.Drawing.Point(0, 491)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 10
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(995, 179)
        Me.grid.TabIndex = 8
        Me.grid.TabStop = False
        '
        'Auction_ID
        '
        Me.Auction_ID.DataPropertyName = "Auction_ID"
        Me.Auction_ID.FillWeight = 94.44572!
        Me.Auction_ID.HeaderText = "باركود"
        Me.Auction_ID.Name = "Auction_ID"
        Me.Auction_ID.ReadOnly = True
        '
        'NameType
        '
        Me.NameType.DataPropertyName = "Name"
        Me.NameType.FillWeight = 94.44572!
        Me.NameType.HeaderText = "النوع"
        Me.NameType.Name = "NameType"
        Me.NameType.ReadOnly = True
        '
        'Brand
        '
        Me.Brand.DataPropertyName = "Brand"
        Me.Brand.FillWeight = 94.44572!
        Me.Brand.HeaderText = "الماركة"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        '
        'Model
        '
        Me.Model.DataPropertyName = "Model"
        Me.Model.FillWeight = 94.44572!
        Me.Model.HeaderText = "الموديل"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        '
        'SerialNo
        '
        Me.SerialNo.DataPropertyName = "SerialNo"
        Me.SerialNo.FillWeight = 94.44572!
        Me.SerialNo.HeaderText = "السيريال"
        Me.SerialNo.Name = "SerialNo"
        Me.SerialNo.ReadOnly = True
        '
        'ItemNewUsed
        '
        Me.ItemNewUsed.DataPropertyName = "ItemNewUsed"
        Me.ItemNewUsed.FillWeight = 94.44572!
        Me.ItemNewUsed.HeaderText = "ح. السلعة"
        Me.ItemNewUsed.Name = "ItemNewUsed"
        Me.ItemNewUsed.ReadOnly = True
        '
        'GuaranteeStatus
        '
        Me.GuaranteeStatus.DataPropertyName = "GuaranteeStatus"
        Me.GuaranteeStatus.FillWeight = 94.44572!
        Me.GuaranteeStatus.HeaderText = "ح. الضمان"
        Me.GuaranteeStatus.Name = "GuaranteeStatus"
        Me.GuaranteeStatus.ReadOnly = True
        '
        'GuaranteeDate
        '
        Me.GuaranteeDate.DataPropertyName = "GuaranteeDate"
        Me.GuaranteeDate.FillWeight = 94.44572!
        Me.GuaranteeDate.HeaderText = "ت.الضمان"
        Me.GuaranteeDate.Name = "GuaranteeDate"
        Me.GuaranteeDate.ReadOnly = True
        '
        'ReceiveDate
        '
        Me.ReceiveDate.DataPropertyName = "ReceiveDate"
        Me.ReceiveDate.FillWeight = 94.44572!
        Me.ReceiveDate.HeaderText = "ت.الاستلام"
        Me.ReceiveDate.Name = "ReceiveDate"
        Me.ReceiveDate.ReadOnly = True
        '
        'Details
        '
        Me.Details.DataPropertyName = "Details"
        Me.Details.FillWeight = 94.44572!
        Me.Details.HeaderText = "تفاصيل"
        Me.Details.Name = "Details"
        Me.Details.ReadOnly = True
        '
        'ItemPhoto
        '
        Me.ItemPhoto.DataPropertyName = "ItemPhoto"
        Me.ItemPhoto.HeaderText = "ItemPhoto"
        Me.ItemPhoto.Name = "ItemPhoto"
        Me.ItemPhoto.ReadOnly = True
        Me.ItemPhoto.Visible = False
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.FillWeight = 94.44572!
        Me.Price.HeaderText = "السعر"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'CastomerID
        '
        Me.CastomerID.DataPropertyName = "CastomerID"
        Me.CastomerID.FillWeight = 97.03159!
        Me.CastomerID.HeaderText = "رقم مدني"
        Me.CastomerID.Name = "CastomerID"
        Me.CastomerID.ReadOnly = True
        '
        'CastomerNAme
        '
        Me.CastomerNAme.DataPropertyName = "CastomerNAme"
        Me.CastomerNAme.FillWeight = 97.33502!
        Me.CastomerNAme.HeaderText = "CastomerNAme"
        Me.CastomerNAme.Name = "CastomerNAme"
        Me.CastomerNAme.ReadOnly = True
        Me.CastomerNAme.Visible = False
        '
        'CastomerADr
        '
        Me.CastomerADr.DataPropertyName = "CastomerADr"
        Me.CastomerADr.HeaderText = "CastomerADr"
        Me.CastomerADr.Name = "CastomerADr"
        Me.CastomerADr.ReadOnly = True
        Me.CastomerADr.Visible = False
        '
        'CastomerTE
        '
        Me.CastomerTE.DataPropertyName = "CastomerTE"
        Me.CastomerTE.HeaderText = "CastomerTE"
        Me.CastomerTE.Name = "CastomerTE"
        Me.CastomerTE.ReadOnly = True
        Me.CastomerTE.Visible = False
        '
        'CastomerNA
        '
        Me.CastomerNA.DataPropertyName = "CastomerNA"
        Me.CastomerNA.HeaderText = "CastomerNA"
        Me.CastomerNA.Name = "CastomerNA"
        Me.CastomerNA.ReadOnly = True
        Me.CastomerNA.Visible = False
        '
        'foto
        '
        Me.foto.DataPropertyName = "foto"
        Me.foto.HeaderText = "foto"
        Me.foto.Name = "foto"
        Me.foto.ReadOnly = True
        Me.foto.Visible = False
        '
        'Signature
        '
        Me.Signature.DataPropertyName = "Signature"
        Me.Signature.HeaderText = "Signature"
        Me.Signature.Name = "Signature"
        Me.Signature.ReadOnly = True
        Me.Signature.Visible = False
        '
        'Delete
        '
        Me.Delete.FillWeight = 50.0!
        Me.Delete.HeaderText = "حذف"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'AuctionAddItemDetailsBindingSource
        '
        Me.AuctionAddItemDetailsBindingSource.DataMember = "Auction_AddItemDetails"
        Me.AuctionAddItemDetailsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'gbItemData
        '
        Me.gbItemData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gbItemData.Controls.Add(Me.dtGuaranteeDate)
        Me.gbItemData.Controls.Add(Me.cmbCashier)
        Me.gbItemData.Controls.Add(Me.lblReceiver)
        Me.gbItemData.Controls.Add(Me.dtReceiveDate)
        Me.gbItemData.Controls.Add(Me.cmbAuction_Type)
        Me.gbItemData.Controls.Add(Me.lblPhoto)
        Me.gbItemData.Controls.Add(Me.lblDetails)
        Me.gbItemData.Controls.Add(Me.lblPrice)
        Me.gbItemData.Controls.Add(Me.lblItemStatus)
        Me.gbItemData.Controls.Add(Me.lblSerialNo)
        Me.gbItemData.Controls.Add(Me.lblModel)
        Me.gbItemData.Controls.Add(Me.lblItemName)
        Me.gbItemData.Controls.Add(Me.lblBrand)
        Me.gbItemData.Controls.Add(Me.txtItemDetails)
        Me.gbItemData.Controls.Add(Me.lblGuaranteeStatus)
        Me.gbItemData.Controls.Add(Me.lblReceiveDate)
        Me.gbItemData.Controls.Add(Me.txtPrice)
        Me.gbItemData.Controls.Add(Me.lblGuaranteeDate)
        Me.gbItemData.Controls.Add(Me.txtSerialNo)
        Me.gbItemData.Controls.Add(Me.pbImage)
        Me.gbItemData.Controls.Add(Me.txtModel)
        Me.gbItemData.Controls.Add(Me.cmbGuaranteeStatus)
        Me.gbItemData.Controls.Add(Me.cmbBrand_Name)
        Me.gbItemData.Controls.Add(Me.cmbItemStatus)
        Me.gbItemData.Controls.Add(Me.btnSave)
        Me.gbItemData.ForeColor = System.Drawing.Color.Black
        Me.gbItemData.Location = New System.Drawing.Point(0, 303)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbItemData.Size = New System.Drawing.Size(995, 151)
        Me.gbItemData.TabIndex = 6
        Me.gbItemData.TabStop = False
        Me.gbItemData.Text = "بيانات الصنف"
        '
        'cmbCashier
        '
        Me.cmbCashier.DataSource = Me.CacherBindingSource
        Me.cmbCashier.DisplayMember = "cacher_name"
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(200, 23)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(121, 23)
        Me.cmbCashier.TabIndex = 10
        Me.cmbCashier.ValueMember = "cacherID"
        '
        'CacherBindingSource
        '
        Me.CacherBindingSource.DataMember = "cacher"
        Me.CacherBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'lblReceiver
        '
        Me.lblReceiver.Location = New System.Drawing.Point(320, 25)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(125, 19)
        Me.lblReceiver.TabIndex = 227
        Me.lblReceiver.Text = "المستلم"
        Me.lblReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtReceiveDate
        '
        Me.dtReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDate.Location = New System.Drawing.Point(448, 22)
        Me.dtReceiveDate.Name = "dtReceiveDate"
        Me.dtReceiveDate.Size = New System.Drawing.Size(125, 24)
        Me.dtReceiveDate.TabIndex = 5
        '
        'cmbAuction_Type
        '
        Me.cmbAuction_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAuction_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAuction_Type.DataSource = Me.AuctionItemTypeBindingSource
        Me.cmbAuction_Type.DisplayMember = "Auction_Type"
        Me.cmbAuction_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuction_Type.FormattingEnabled = True
        Me.cmbAuction_Type.Location = New System.Drawing.Point(725, 23)
        Me.cmbAuction_Type.Name = "cmbAuction_Type"
        Me.cmbAuction_Type.Size = New System.Drawing.Size(125, 23)
        Me.cmbAuction_Type.TabIndex = 0
        Me.cmbAuction_Type.ValueMember = "Item_Name"
        '
        'AuctionItemTypeBindingSource
        '
        Me.AuctionItemTypeBindingSource.DataMember = "Auction_ItemType"
        Me.AuctionItemTypeBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'lblPhoto
        '
        Me.lblPhoto.DisabledLinkColor = System.Drawing.Color.Black
        Me.lblPhoto.Location = New System.Drawing.Point(13, 21)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(180, 22)
        Me.lblPhoto.TabIndex = 11
        Me.lblPhoto.TabStop = True
        Me.lblPhoto.Text = "الصورة"
        Me.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(579, 96)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(125, 19)
        Me.lblDetails.TabIndex = 53
        Me.lblDetails.Text = "تفاصيل"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(579, 120)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(125, 19)
        Me.lblPrice.TabIndex = 53
        Me.lblPrice.Text = "السعر"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemStatus
        '
        Me.lblItemStatus.Location = New System.Drawing.Point(856, 118)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(125, 22)
        Me.lblItemStatus.TabIndex = 53
        Me.lblItemStatus.Text = "حالة السلعة"
        Me.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSerialNo
        '
        Me.lblSerialNo.Location = New System.Drawing.Point(856, 94)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(125, 22)
        Me.lblSerialNo.TabIndex = 53
        Me.lblSerialNo.Text = "رقم السيريال"
        Me.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(856, 70)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(125, 22)
        Me.lblModel.TabIndex = 52
        Me.lblModel.Text = "الموديل"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblItemName
        '
        Me.lblItemName.Location = New System.Drawing.Point(856, 23)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(125, 22)
        Me.lblItemName.TabIndex = 51
        Me.lblItemName.Text = "النوع"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBrand
        '
        Me.lblBrand.Location = New System.Drawing.Point(856, 46)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(125, 22)
        Me.lblBrand.TabIndex = 50
        Me.lblBrand.Text = "الماركة"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItemDetails
        '
        Me.txtItemDetails.BackColor = System.Drawing.Color.White
        Me.txtItemDetails.ForeColor = System.Drawing.Color.Black
        Me.txtItemDetails.Location = New System.Drawing.Point(448, 93)
        Me.txtItemDetails.Name = "txtItemDetails"
        Me.txtItemDetails.Size = New System.Drawing.Size(125, 24)
        Me.txtItemDetails.TabIndex = 8
        Me.txtItemDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuaranteeStatus
        '
        Me.lblGuaranteeStatus.Location = New System.Drawing.Point(579, 48)
        Me.lblGuaranteeStatus.Name = "lblGuaranteeStatus"
        Me.lblGuaranteeStatus.Size = New System.Drawing.Size(125, 19)
        Me.lblGuaranteeStatus.TabIndex = 56
        Me.lblGuaranteeStatus.Text = "حالة الضمان"
        Me.lblGuaranteeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReceiveDate
        '
        Me.lblReceiveDate.Location = New System.Drawing.Point(579, 23)
        Me.lblReceiveDate.Name = "lblReceiveDate"
        Me.lblReceiveDate.Size = New System.Drawing.Size(125, 22)
        Me.lblReceiveDate.TabIndex = 55
        Me.lblReceiveDate.Text = "تاريخ الاستلام"
        Me.lblReceiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(448, 117)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrice.Size = New System.Drawing.Size(125, 24)
        Me.txtPrice.TabIndex = 9
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuaranteeDate
        '
        Me.lblGuaranteeDate.Location = New System.Drawing.Point(579, 72)
        Me.lblGuaranteeDate.Name = "lblGuaranteeDate"
        Me.lblGuaranteeDate.Size = New System.Drawing.Size(125, 19)
        Me.lblGuaranteeDate.TabIndex = 56
        Me.lblGuaranteeDate.Text = "تاريخ الضمان"
        Me.lblGuaranteeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImage.Location = New System.Drawing.Point(13, 46)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(180, 95)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 50
        Me.pbImage.TabStop = False
        '
        'cmbGuaranteeStatus
        '
        Me.cmbGuaranteeStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbGuaranteeStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGuaranteeStatus.DataSource = Me.AuctionGuaranteeStatusBindingSource
        Me.cmbGuaranteeStatus.DisplayMember = "GuaranteeStatus"
        Me.cmbGuaranteeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGuaranteeStatus.FormattingEnabled = True
        Me.cmbGuaranteeStatus.Location = New System.Drawing.Point(448, 46)
        Me.cmbGuaranteeStatus.Name = "cmbGuaranteeStatus"
        Me.cmbGuaranteeStatus.Size = New System.Drawing.Size(125, 23)
        Me.cmbGuaranteeStatus.TabIndex = 6
        Me.cmbGuaranteeStatus.ValueMember = "GuaranteeStatus"
        '
        'AuctionGuaranteeStatusBindingSource
        '
        Me.AuctionGuaranteeStatusBindingSource.DataMember = "Auction_GuaranteeStatus"
        Me.AuctionGuaranteeStatusBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'cmbItemStatus
        '
        Me.cmbItemStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbItemStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemStatus.DataSource = Me.AuctionItemStatusBindingSource
        Me.cmbItemStatus.DisplayMember = "ItemStatus_Name"
        Me.cmbItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemStatus.FormattingEnabled = True
        Me.cmbItemStatus.Location = New System.Drawing.Point(725, 118)
        Me.cmbItemStatus.Name = "cmbItemStatus"
        Me.cmbItemStatus.Size = New System.Drawing.Size(125, 23)
        Me.cmbItemStatus.TabIndex = 4
        Me.cmbItemStatus.ValueMember = "ItemStatus_Name"
        '
        'AuctionItemStatusBindingSource
        '
        Me.AuctionItemStatusBindingSource.DataMember = "Auction_ItemStatus"
        Me.AuctionItemStatusBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(196, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 39)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.BoxAdd
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.Location = New System.Drawing.Point(859, 2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(129, 50)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "صنف جديد"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnItemStatus
        '
        Me.btnItemStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnItemStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItemStatus.ForeColor = System.Drawing.Color.Black
        Me.btnItemStatus.Image = Global.DT_restrant.My.Resources.Resources.UserAdd
        Me.btnItemStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemStatus.Location = New System.Drawing.Point(149, 2)
        Me.btnItemStatus.Name = "btnItemStatus"
        Me.btnItemStatus.Size = New System.Drawing.Size(129, 50)
        Me.btnItemStatus.TabIndex = 5
        Me.btnItemStatus.Text = "حالة السلعة"
        Me.btnItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemStatus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(717, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(129, 50)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAddItemName
        '
        Me.btnAddItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAddItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItemName.ForeColor = System.Drawing.Color.Black
        Me.btnAddItemName.Image = Global.DT_restrant.My.Resources.Resources.BoxAdd
        Me.btnAddItemName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddItemName.Location = New System.Drawing.Point(575, 2)
        Me.btnAddItemName.Name = "btnAddItemName"
        Me.btnAddItemName.Size = New System.Drawing.Size(129, 50)
        Me.btnAddItemName.TabIndex = 2
        Me.btnAddItemName.Text = "إضافة نوع"
        Me.btnAddItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItemName.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrand.ForeColor = System.Drawing.Color.Black
        Me.btnBrand.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnBrand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrand.Location = New System.Drawing.Point(433, 2)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(129, 50)
        Me.btnBrand.TabIndex = 3
        Me.btnBrand.Text = "إضافة ماركة"
        Me.btnBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'btnGuaranteeStatus
        '
        Me.btnGuaranteeStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuaranteeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuaranteeStatus.ForeColor = System.Drawing.Color.Black
        Me.btnGuaranteeStatus.Image = Global.DT_restrant.My.Resources.Resources.Globe
        Me.btnGuaranteeStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuaranteeStatus.Location = New System.Drawing.Point(291, 2)
        Me.btnGuaranteeStatus.Name = "btnGuaranteeStatus"
        Me.btnGuaranteeStatus.Size = New System.Drawing.Size(129, 50)
        Me.btnGuaranteeStatus.TabIndex = 4
        Me.btnGuaranteeStatus.Text = "حالة الضمان"
        Me.btnGuaranteeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuaranteeStatus.UseVisualStyleBackColor = False
        '
        'lblSearchText
        '
        Me.lblSearchText.ForeColor = System.Drawing.Color.Black
        Me.lblSearchText.Location = New System.Drawing.Point(382, 7)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchText.TabIndex = 61
        Me.lblSearchText.Text = "معيار البحث :"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.ForeColor = System.Drawing.Color.Black
        Me.lblSearchType.Location = New System.Drawing.Point(817, 7)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchType.TabIndex = 62
        Me.lblSearchType.Text = "بحث عن :"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"النوع", "الماركة", "الموديل", "السيريال"})
        Me.cmbSearch.Location = New System.Drawing.Point(587, 8)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(224, 23)
        Me.cmbSearch.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(80, 4)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(70, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(174, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearch.Size = New System.Drawing.Size(203, 25)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Auction_AddItemDetailsDataGridView
        '
        Me.Auction_AddItemDetailsDataGridView.AllowUserToAddRows = False
        Me.Auction_AddItemDetailsDataGridView.AllowUserToDeleteRows = False
        Me.Auction_AddItemDetailsDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Auction_AddItemDetailsDataGridView.AutoGenerateColumns = False
        Me.Auction_AddItemDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Auction_AddItemDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn11})
        Me.Auction_AddItemDetailsDataGridView.DataSource = Me.AuctionAddItemDetailsBindingSource
        Me.Auction_AddItemDetailsDataGridView.Location = New System.Drawing.Point(194, 48)
        Me.Auction_AddItemDetailsDataGridView.Name = "Auction_AddItemDetailsDataGridView"
        Me.Auction_AddItemDetailsDataGridView.ReadOnly = True
        Me.Auction_AddItemDetailsDataGridView.RowHeadersVisible = False
        Me.Auction_AddItemDetailsDataGridView.Size = New System.Drawing.Size(50, 27)
        Me.Auction_AddItemDetailsDataGridView.TabIndex = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Auction_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Auction_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SerialNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SerialNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ItemNewUsed"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ItemNewUsed"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "GuaranteeStatus"
        Me.DataGridViewTextBoxColumn7.HeaderText = "GuaranteeStatus"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GuaranteeDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "GuaranteeDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ReceiveDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ReceiveDate"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Details"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ItemPhoto"
        Me.DataGridViewImageColumn1.HeaderText = "ItemPhoto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'txtAuction_TypeDB
        '
        Me.txtAuction_TypeDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuction_TypeDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Name", True))
        Me.txtAuction_TypeDB.Location = New System.Drawing.Point(194, 99)
        Me.txtAuction_TypeDB.Name = "txtAuction_TypeDB"
        Me.txtAuction_TypeDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAuction_TypeDB.TabIndex = 55
        '
        'txtBrand_NameDB
        '
        Me.txtBrand_NameDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrand_NameDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Brand", True))
        Me.txtBrand_NameDB.Location = New System.Drawing.Point(194, 147)
        Me.txtBrand_NameDB.Name = "txtBrand_NameDB"
        Me.txtBrand_NameDB.Size = New System.Drawing.Size(50, 24)
        Me.txtBrand_NameDB.TabIndex = 56
        '
        'txtModelDB
        '
        Me.txtModelDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Model", True))
        Me.txtModelDB.Location = New System.Drawing.Point(194, 171)
        Me.txtModelDB.Name = "txtModelDB"
        Me.txtModelDB.Size = New System.Drawing.Size(50, 24)
        Me.txtModelDB.TabIndex = 57
        '
        'txtSerialNoDB
        '
        Me.txtSerialNoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerialNoDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "SerialNo", True))
        Me.txtSerialNoDB.Location = New System.Drawing.Point(194, 195)
        Me.txtSerialNoDB.Name = "txtSerialNoDB"
        Me.txtSerialNoDB.Size = New System.Drawing.Size(50, 24)
        Me.txtSerialNoDB.TabIndex = 58
        '
        'txtItemStatusDB
        '
        Me.txtItemStatusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemStatusDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "ItemNewUsed", True))
        Me.txtItemStatusDB.Location = New System.Drawing.Point(194, 243)
        Me.txtItemStatusDB.Name = "txtItemStatusDB"
        Me.txtItemStatusDB.Size = New System.Drawing.Size(50, 24)
        Me.txtItemStatusDB.TabIndex = 59
        '
        'txtGuaranteeStatusDB
        '
        Me.txtGuaranteeStatusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuaranteeStatusDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "GuaranteeStatus", True))
        Me.txtGuaranteeStatusDB.Location = New System.Drawing.Point(194, 267)
        Me.txtGuaranteeStatusDB.Name = "txtGuaranteeStatusDB"
        Me.txtGuaranteeStatusDB.Size = New System.Drawing.Size(50, 24)
        Me.txtGuaranteeStatusDB.TabIndex = 60
        '
        'txtItemDetailsDB
        '
        Me.txtItemDetailsDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemDetailsDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Details", True))
        Me.txtItemDetailsDB.Location = New System.Drawing.Point(194, 219)
        Me.txtItemDetailsDB.Name = "txtItemDetailsDB"
        Me.txtItemDetailsDB.Size = New System.Drawing.Size(50, 24)
        Me.txtItemDetailsDB.TabIndex = 63
        '
        'txtPriceDB
        '
        Me.txtPriceDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPriceDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Price", True))
        Me.txtPriceDB.Location = New System.Drawing.Point(194, 123)
        Me.txtPriceDB.Name = "txtPriceDB"
        Me.txtPriceDB.Size = New System.Drawing.Size(50, 24)
        Me.txtPriceDB.TabIndex = 65
        '
        'txtAuction_IDDB
        '
        Me.txtAuction_IDDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuction_IDDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "Auction_ID", True))
        Me.txtAuction_IDDB.Location = New System.Drawing.Point(194, 75)
        Me.txtAuction_IDDB.Name = "txtAuction_IDDB"
        Me.txtAuction_IDDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAuction_IDDB.TabIndex = 221
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.DocumentMapWidth = 51
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AuctionAddItemDetailsVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptAuctionReceive.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(259, 48)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(101, 27)
        Me.ReportViewer1.TabIndex = 222
        '
        'txtAuctionIDVw
        '
        Me.txtAuctionIDVw.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuctionIDVw.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsVwBindingSource, "Auction_ID", True))
        Me.txtAuctionIDVw.Location = New System.Drawing.Point(140, 75)
        Me.txtAuctionIDVw.Name = "txtAuctionIDVw"
        Me.txtAuctionIDVw.Size = New System.Drawing.Size(50, 24)
        Me.txtAuctionIDVw.TabIndex = 223
        '
        'Auction_ItemTypeTableAdapter
        '
        Me.Auction_ItemTypeTableAdapter.ClearBeforeFill = True
        '
        'Auction_BrandTableAdapter
        '
        Me.Auction_BrandTableAdapter.ClearBeforeFill = True
        '
        'Auction_GuaranteeStatusTableAdapter
        '
        Me.Auction_GuaranteeStatusTableAdapter.ClearBeforeFill = True
        '
        'Auction_ItemStatusTableAdapter
        '
        Me.Auction_ItemStatusTableAdapter.ClearBeforeFill = True
        '
        'AuctionAddItemDetailsTableAdapter
        '
        Me.AuctionAddItemDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accessories_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BAYTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_Buy_PayTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BuyTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_CATTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_DEPTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_INVTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Me.AuctionAddItemDetailsTableAdapter
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Me.Auction_BrandTableAdapter
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Me.Auction_GuaranteeStatusTableAdapter
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Me.Auction_ItemStatusTableAdapter
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Me.Auction_ItemTypeTableAdapter
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing

        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
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
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'AuctionAddItemDetailsVwTableAdapter
        '
        Me.AuctionAddItemDetailsVwTableAdapter.ClearBeforeFill = True
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.txtGuaranteeDateDB)
        Me.pnl.Controls.Add(Me.CacherIDTextBox)
        Me.pnl.Controls.Add(Me.txtAuctionIDVw)
        Me.pnl.Controls.Add(Me.Auction_AddItemDetailsDataGridView)
        Me.pnl.Controls.Add(Me.CastomerIDTextBox)
        Me.pnl.Controls.Add(Me.ReportViewer1)
        Me.pnl.Controls.Add(Me.pbImageDB)
        Me.pnl.Controls.Add(Me.txtAuction_TypeDB)
        Me.pnl.Controls.Add(Me.dtReceiveDateDB)
        Me.pnl.Controls.Add(Me.txtAuction_IDDB)
        Me.pnl.Controls.Add(Me.txtBrand_NameDB)
        Me.pnl.Controls.Add(Me.txtModelDB)
        Me.pnl.Controls.Add(Me.txtSerialNoDB)
        Me.pnl.Controls.Add(Me.txtItemStatusDB)
        Me.pnl.Controls.Add(Me.txtGuaranteeStatusDB)
        Me.pnl.Controls.Add(Me.txtItemDetailsDB)
        Me.pnl.Controls.Add(Me.txtPriceDB)
        Me.pnl.Location = New System.Drawing.Point(1148, 54)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(450, 561)
        Me.pnl.TabIndex = 224
        '
        'txtGuaranteeDateDB
        '
        Me.txtGuaranteeDateDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuaranteeDateDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "GuaranteeDate", True))
        Me.txtGuaranteeDateDB.Location = New System.Drawing.Point(194, 291)
        Me.txtGuaranteeDateDB.Name = "txtGuaranteeDateDB"
        Me.txtGuaranteeDateDB.Size = New System.Drawing.Size(50, 24)
        Me.txtGuaranteeDateDB.TabIndex = 225
        '
        'CacherIDTextBox
        '
        Me.CacherIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "CacherID", True))
        Me.CacherIDTextBox.Location = New System.Drawing.Point(193, 396)
        Me.CacherIDTextBox.Name = "CacherIDTextBox"
        Me.CacherIDTextBox.Size = New System.Drawing.Size(51, 24)
        Me.CacherIDTextBox.TabIndex = 224
        '
        'CastomerIDTextBox
        '
        Me.CastomerIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionAddItemDetailsBindingSource, "CastomerID", True))
        Me.CastomerIDTextBox.Location = New System.Drawing.Point(193, 339)
        Me.CastomerIDTextBox.Name = "CastomerIDTextBox"
        Me.CastomerIDTextBox.Size = New System.Drawing.Size(50, 24)
        Me.CastomerIDTextBox.TabIndex = 220
        '
        'pbImageDB
        '
        Me.pbImageDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbImageDB.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AuctionAddItemDetailsBindingSource, "ItemPhoto", True))
        Me.pbImageDB.Location = New System.Drawing.Point(194, 363)
        Me.pbImageDB.Name = "pbImageDB"
        Me.pbImageDB.Size = New System.Drawing.Size(50, 27)
        Me.pbImageDB.TabIndex = 64
        Me.pbImageDB.TabStop = False
        '
        'dtReceiveDateDB
        '
        Me.dtReceiveDateDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtReceiveDateDB.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDateDB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AuctionAddItemDetailsBindingSource, "ReceiveDate", True))
        Me.dtReceiveDateDB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDateDB.Location = New System.Drawing.Point(193, 315)
        Me.dtReceiveDateDB.Name = "dtReceiveDateDB"
        Me.dtReceiveDateDB.Size = New System.Drawing.Size(50, 24)
        Me.dtReceiveDateDB.TabIndex = 62
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.Controls.Add(Me.lblSearchText)
        Me.pnlSearch.Controls.Add(Me.lblSearchType)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.cmbSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(0, 454)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnlSearch.Size = New System.Drawing.Size(995, 38)
        Me.pnlSearch.TabIndex = 7
        '
        'CacherTableAdapter
        '
        Me.CacherTableAdapter.ClearBeforeFill = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(7, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 50)
        Me.btnPrint.TabIndex = 225
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dtGuaranteeDate
        '
        Me.dtGuaranteeDate.Location = New System.Drawing.Point(448, 69)
        Me.dtGuaranteeDate.Name = "dtGuaranteeDate"
        Me.dtGuaranteeDate.Size = New System.Drawing.Size(125, 24)
        Me.dtGuaranteeDate.TabIndex = 7
        Me.dtGuaranteeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AuctionAddItemDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnGuaranteeStatus)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.btnItemStatus)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnBrand)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddItemName)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AuctionAddItemDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة أصناف"
        CType(Me.AuctionAddItemDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionAddItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionGuaranteeStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionItemStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Auction_AddItemDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.pbImageDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents cmbBrand_Name As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents gbItemData As System.Windows.Forms.GroupBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbItemStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeDate As System.Windows.Forms.Label
    Friend WithEvents lblReceiveDate As System.Windows.Forms.Label
    Friend WithEvents pbImage As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhoto As System.Windows.Forms.LinkLabel
    Friend WithEvents btnBrand As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnItemStatus As System.Windows.Forms.Button
    Friend WithEvents cmbAuction_Type As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddItemName As System.Windows.Forms.Button
    Friend WithEvents btnGuaranteeStatus As System.Windows.Forms.Button
    Friend WithEvents lblGuaranteeStatus As System.Windows.Forms.Label
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblItemStatus As System.Windows.Forms.Label
    Friend WithEvents txtItemDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents dtReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGuaranteeStatus As System.Windows.Forms.ComboBox
    Friend WithEvents AuctionItemTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_ItemTypeTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter
    Friend WithEvents AuctionBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_BrandTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter
    Friend WithEvents AuctionGuaranteeStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_GuaranteeStatusTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_GuaranteeStatusTableAdapter
    Friend WithEvents AuctionItemStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_ItemStatusTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemStatusTableAdapter
    Friend WithEvents AuctionAddItemDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuctionAddItemDetailsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_AddItemDetailsTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Auction_AddItemDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAuction_TypeDB As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand_NameDB As System.Windows.Forms.TextBox
    Friend WithEvents txtModelDB As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialNoDB As System.Windows.Forms.TextBox
    Friend WithEvents txtItemStatusDB As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeStatusDB As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDetailsDB As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceDB As System.Windows.Forms.TextBox
    Friend WithEvents AuctionAddItemDetailsVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuctionAddItemDetailsVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.AuctionAddItemDetailsVwTableAdapter
    Friend WithEvents txtAuction_IDDB As System.Windows.Forms.TextBox
    Friend WithEvents txtAuctionIDVw As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents CastomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pbImageDB As System.Windows.Forms.PictureBox
    Friend WithEvents dtReceiveDateDB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents CacherIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeDateDB As System.Windows.Forms.TextBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CacherTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Auction_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Model As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemNewUsed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuaranteeStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuaranteeDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiveDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemPhoto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerNAme As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerADr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerNA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents foto As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Signature As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dtGuaranteeDate As System.Windows.Forms.TextBox
End Class
