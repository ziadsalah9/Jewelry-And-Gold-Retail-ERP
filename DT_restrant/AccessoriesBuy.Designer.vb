<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesBuy
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
        Dim Accessories_YearOfWarrLabel As System.Windows.Forms.Label
        Dim Accessories_AttachmentsLabel As System.Windows.Forms.Label
        Dim ItemNoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessoriesBuy))
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbBrand_Name = New System.Windows.Forms.ComboBox()
        Me.AuctionBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colAccessoriesID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesBRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesItemStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesCAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesDEP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessoriesDESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAccessories_InvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accessories_CID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesBuyVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accessories_BuyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbItemData = New System.Windows.Forms.GroupBox()
        Me.LibltemNO = New System.Windows.Forms.Label()
        Me.TexltemNO = New System.Windows.Forms.TextBox()
        Me.LAIBELAttachments = New System.Windows.Forms.Label()
        Me.TEXTAttachments = New System.Windows.Forms.TextBox()
        Me.LABILYearOfWarr = New System.Windows.Forms.Label()
        Me.TEXTYearOfWarr = New System.Windows.Forms.TextBox()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnPayPrint = New System.Windows.Forms.Button()
        Me.btnItemName = New System.Windows.Forms.Button()
        Me.btnDep = New System.Windows.Forms.Button()
        Me.cmbAccessories_DEP = New System.Windows.Forms.ComboBox()
        Me.AccessoriesDEPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCat = New System.Windows.Forms.Button()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.CacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblReceiver = New System.Windows.Forms.Label()
        Me.dtReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbAccessories_NAME = New System.Windows.Forms.ComboBox()
        Me.AuctionItemTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPhoto = New System.Windows.Forms.LinkLabel()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeStatus = New System.Windows.Forms.Label()
        Me.lblReceiveDate = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeDate = New System.Windows.Forms.Label()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.cmbAccessories_CAT = New System.Windows.Forms.ComboBox()
        Me.AccessoriesCATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbItemStatus = New System.Windows.Forms.ComboBox()
        Me.AuctionItemStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Accessories_BuyDataGridView = New System.Windows.Forms.DataGridView()
        Me.AccessoriesIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesBRANDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesItemStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesDEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesmodelnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesPICDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.AccessoriesTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesDATECREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAccessories_NAMEDB = New System.Windows.Forms.TextBox()
        Me.txtAccessories_BRANDDB = New System.Windows.Forms.TextBox()
        Me.txtModelDB = New System.Windows.Forms.TextBox()
        Me.txtSerialNoDB = New System.Windows.Forms.TextBox()
        Me.txtItemStatusDB = New System.Windows.Forms.TextBox()
        Me.txtAccessories_DEPDB = New System.Windows.Forms.TextBox()
        Me.txtPriceDB = New System.Windows.Forms.TextBox()
        Me.txtAccessoriesIDDB = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Auction_ItemTypeTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter()
        Me.Auction_BrandTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter()
        Me.Auction_ItemStatusTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemStatusTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.Accessories_TIMETextBoxDB = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNoDB = New System.Windows.Forms.TextBox()
        Me.AccessoriesBuyInvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.AccessoriesBuyInvoiceMaxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accessories_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.txtAccessories_CATDB = New System.Windows.Forms.TextBox()
        Me.CacherIDTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerIDTextBoxDB = New System.Windows.Forms.TextBox()
        Me.pbImageDB = New System.Windows.Forms.PictureBox()
        Me.dtReceiveDateDB = New System.Windows.Forms.DateTimePicker()
        Me.CacherTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter()
        Me.Accessories_BuyTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_BuyTableAdapter()
        Me.Accessories_DEPTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_DEPTableAdapter()
        Me.Accessories_CATTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter()
        Me.Accessories_BuyVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_BuyVwTableAdapter()
        Me.AccessoriesBuyInvoiceMaxTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AccessoriesBuyInvoiceMaxTableAdapter()
        Me.Accessories_YearOfWarrTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_AttachmentsTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNoTextBox = New System.Windows.Forms.TextBox()
        Accessories_YearOfWarrLabel = New System.Windows.Forms.Label()
        Accessories_AttachmentsLabel = New System.Windows.Forms.Label()
        ItemNoLabel = New System.Windows.Forms.Label()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBuyVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accessories_BuyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.AccessoriesDEPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesCATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionItemStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accessories_BuyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.AccessoriesBuyInvoiceMaxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImageDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accessories_YearOfWarrLabel
        '
        Accessories_YearOfWarrLabel.AutoSize = True
        Accessories_YearOfWarrLabel.Location = New System.Drawing.Point(30, 419)
        Accessories_YearOfWarrLabel.Name = "Accessories_YearOfWarrLabel"
        Accessories_YearOfWarrLabel.Size = New System.Drawing.Size(156, 17)
        Accessories_YearOfWarrLabel.TabIndex = 224
        Accessories_YearOfWarrLabel.Text = "Accessories Year Of Warr:"
        '
        'Accessories_AttachmentsLabel
        '
        Accessories_AttachmentsLabel.AutoSize = True
        Accessories_AttachmentsLabel.Location = New System.Drawing.Point(28, 449)
        Accessories_AttachmentsLabel.Name = "Accessories_AttachmentsLabel"
        Accessories_AttachmentsLabel.Size = New System.Drawing.Size(158, 17)
        Accessories_AttachmentsLabel.TabIndex = 225
        Accessories_AttachmentsLabel.Text = "Accessories Attachments:"
        '
        'ItemNoLabel
        '
        ItemNoLabel.AutoSize = True
        ItemNoLabel.Location = New System.Drawing.Point(127, 479)
        ItemNoLabel.Name = "ItemNoLabel"
        ItemNoLabel.Size = New System.Drawing.Size(59, 17)
        ItemNoLabel.TabIndex = 226
        ItemNoLabel.Text = "Item No:"
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
        Me.txtModel.Location = New System.Drawing.Point(615, 69)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtModel.Size = New System.Drawing.Size(235, 24)
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
        Me.cmbBrand_Name.Location = New System.Drawing.Point(640, 46)
        Me.cmbBrand_Name.Name = "cmbBrand_Name"
        Me.cmbBrand_Name.Size = New System.Drawing.Size(210, 23)
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
        Me.txtSerialNo.Location = New System.Drawing.Point(615, 93)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerialNo.Size = New System.Drawing.Size(235, 24)
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
        Me.grid.BackgroundColor = System.Drawing.Color.RosyBrown
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
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAccessoriesID, Me.colAccessoriesNAME, Me.colAccessoriesBRAND, Me.colAccessoriesmodel, Me.colAccessoriesnom, Me.colAccessoriesItemStatus, Me.colAccessoriesCAT, Me.colAccessoriesDEP, Me.colAccessoriesDESC, Me.colAccessories_Price, Me.colAccessories_InvoiceNo, Me.Accessories_CID, Me.Delete, Me.AccessoriesTIMEDataGridViewTextBoxColumn1, Me.AccessoriesDATECREDataGridViewTextBoxColumn1, Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1})
        Me.grid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grid.DataSource = Me.AccessoriesBuyVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.GridColor = System.Drawing.Color.Silver
        Me.grid.Location = New System.Drawing.Point(2, 527)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 10
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(993, 182)
        Me.grid.TabIndex = 8
        Me.grid.TabStop = False
        '
        'colAccessoriesID
        '
        Me.colAccessoriesID.DataPropertyName = "AccessoriesID"
        Me.colAccessoriesID.HeaderText = "AccessoriesID"
        Me.colAccessoriesID.Name = "colAccessoriesID"
        Me.colAccessoriesID.ReadOnly = True
        Me.colAccessoriesID.Visible = False
        '
        'colAccessoriesNAME
        '
        Me.colAccessoriesNAME.DataPropertyName = "Accessories_NAME"
        Me.colAccessoriesNAME.HeaderText = "النوع"
        Me.colAccessoriesNAME.Name = "colAccessoriesNAME"
        Me.colAccessoriesNAME.ReadOnly = True
        '
        'colAccessoriesBRAND
        '
        Me.colAccessoriesBRAND.DataPropertyName = "Accessories_BRAND"
        Me.colAccessoriesBRAND.HeaderText = "الماركة"
        Me.colAccessoriesBRAND.Name = "colAccessoriesBRAND"
        Me.colAccessoriesBRAND.ReadOnly = True
        '
        'colAccessoriesmodel
        '
        Me.colAccessoriesmodel.DataPropertyName = "Accessories_model_no"
        Me.colAccessoriesmodel.HeaderText = "الموديل"
        Me.colAccessoriesmodel.Name = "colAccessoriesmodel"
        Me.colAccessoriesmodel.ReadOnly = True
        '
        'colAccessoriesnom
        '
        Me.colAccessoriesnom.DataPropertyName = "Accessories_nom"
        Me.colAccessoriesnom.HeaderText = "السيريال"
        Me.colAccessoriesnom.Name = "colAccessoriesnom"
        Me.colAccessoriesnom.ReadOnly = True
        '
        'colAccessoriesItemStatus
        '
        Me.colAccessoriesItemStatus.DataPropertyName = "Accessories_ItemStatus"
        Me.colAccessoriesItemStatus.HeaderText = "الحالة"
        Me.colAccessoriesItemStatus.Name = "colAccessoriesItemStatus"
        Me.colAccessoriesItemStatus.ReadOnly = True
        '
        'colAccessoriesCAT
        '
        Me.colAccessoriesCAT.DataPropertyName = "Accessories_CAT"
        Me.colAccessoriesCAT.HeaderText = "الفئة"
        Me.colAccessoriesCAT.Name = "colAccessoriesCAT"
        Me.colAccessoriesCAT.ReadOnly = True
        '
        'colAccessoriesDEP
        '
        Me.colAccessoriesDEP.DataPropertyName = "Accessories_DEP"
        Me.colAccessoriesDEP.HeaderText = "القسم"
        Me.colAccessoriesDEP.Name = "colAccessoriesDEP"
        Me.colAccessoriesDEP.ReadOnly = True
        '
        'colAccessoriesDESC
        '
        Me.colAccessoriesDESC.DataPropertyName = "Accessories_DESC"
        Me.colAccessoriesDESC.HeaderText = "ملاحظات"
        Me.colAccessoriesDESC.Name = "colAccessoriesDESC"
        Me.colAccessoriesDESC.ReadOnly = True
        '
        'colAccessories_Price
        '
        Me.colAccessories_Price.DataPropertyName = "Accessories_Price"
        Me.colAccessories_Price.HeaderText = "السعر"
        Me.colAccessories_Price.Name = "colAccessories_Price"
        Me.colAccessories_Price.ReadOnly = True
        '
        'colAccessories_InvoiceNo
        '
        Me.colAccessories_InvoiceNo.DataPropertyName = "Accessories_InvoiceNo"
        Me.colAccessories_InvoiceNo.HeaderText = "رقم الفاتورة"
        Me.colAccessories_InvoiceNo.Name = "colAccessories_InvoiceNo"
        Me.colAccessories_InvoiceNo.ReadOnly = True
        '
        'Accessories_CID
        '
        Me.Accessories_CID.DataPropertyName = "Accessories_CID"
        Me.Accessories_CID.HeaderText = "رقم مدني"
        Me.Accessories_CID.Name = "Accessories_CID"
        Me.Accessories_CID.ReadOnly = True
        '
        'Delete
        '
        Me.Delete.FillWeight = 50.0!
        Me.Delete.HeaderText = "حذف"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'AccessoriesTIMEDataGridViewTextBoxColumn1
        '
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1.DataPropertyName = "Accessories_TIME"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1.HeaderText = "Accessories_TIME"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1.Name = "AccessoriesTIMEDataGridViewTextBoxColumn1"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AccessoriesTIMEDataGridViewTextBoxColumn1.Visible = False
        '
        'AccessoriesDATECREDataGridViewTextBoxColumn1
        '
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1.DataPropertyName = "Accessories_DATE_CRE"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1.HeaderText = "Accessories_DATE_CRE"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1.Name = "AccessoriesDATECREDataGridViewTextBoxColumn1"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AccessoriesDATECREDataGridViewTextBoxColumn1.Visible = False
        '
        'AccessoriesUSERCRETDataGridViewTextBoxColumn1
        '
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1.DataPropertyName = "Accessories_USER_CRET"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1.HeaderText = "Accessories_USER_CRET"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1.Name = "AccessoriesUSERCRETDataGridViewTextBoxColumn1"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn1.Visible = False
        '
        'AccessoriesBuyVwBindingSource
        '
        Me.AccessoriesBuyVwBindingSource.DataMember = "Accessories_BuyVw"
        Me.AccessoriesBuyVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Accessories_BuyBindingSource
        '
        Me.Accessories_BuyBindingSource.DataMember = "Accessories_Buy"
        Me.Accessories_BuyBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'gbItemData
        '
        Me.gbItemData.BackColor = System.Drawing.Color.Tan
        Me.gbItemData.Controls.Add(Me.LibltemNO)
        Me.gbItemData.Controls.Add(Me.TexltemNO)
        Me.gbItemData.Controls.Add(Me.LAIBELAttachments)
        Me.gbItemData.Controls.Add(Me.TEXTAttachments)
        Me.gbItemData.Controls.Add(Me.LABILYearOfWarr)
        Me.gbItemData.Controls.Add(Me.TEXTYearOfWarr)
        Me.gbItemData.Controls.Add(Me.btnBrand)
        Me.gbItemData.Controls.Add(Me.btnPayPrint)
        Me.gbItemData.Controls.Add(Me.btnItemName)
        Me.gbItemData.Controls.Add(Me.btnDep)
        Me.gbItemData.Controls.Add(Me.cmbAccessories_DEP)
        Me.gbItemData.Controls.Add(Me.btnCat)
        Me.gbItemData.Controls.Add(Me.cmbCashier)
        Me.gbItemData.Controls.Add(Me.lblReceiver)
        Me.gbItemData.Controls.Add(Me.dtReceiveDate)
        Me.gbItemData.Controls.Add(Me.cmbAccessories_NAME)
        Me.gbItemData.Controls.Add(Me.lblPhoto)
        Me.gbItemData.Controls.Add(Me.lblDetails)
        Me.gbItemData.Controls.Add(Me.lblPrice)
        Me.gbItemData.Controls.Add(Me.lblItemStatus)
        Me.gbItemData.Controls.Add(Me.lblSerialNo)
        Me.gbItemData.Controls.Add(Me.lblModel)
        Me.gbItemData.Controls.Add(Me.lblItemName)
        Me.gbItemData.Controls.Add(Me.lblBrand)
        Me.gbItemData.Controls.Add(Me.txtNotes)
        Me.gbItemData.Controls.Add(Me.lblGuaranteeStatus)
        Me.gbItemData.Controls.Add(Me.lblReceiveDate)
        Me.gbItemData.Controls.Add(Me.txtPrice)
        Me.gbItemData.Controls.Add(Me.lblGuaranteeDate)
        Me.gbItemData.Controls.Add(Me.txtSerialNo)
        Me.gbItemData.Controls.Add(Me.pbImage)
        Me.gbItemData.Controls.Add(Me.txtModel)
        Me.gbItemData.Controls.Add(Me.cmbAccessories_CAT)
        Me.gbItemData.Controls.Add(Me.cmbBrand_Name)
        Me.gbItemData.Controls.Add(Me.cmbItemStatus)
        Me.gbItemData.Controls.Add(Me.btnSave)
        Me.gbItemData.ForeColor = System.Drawing.Color.Black
        Me.gbItemData.Location = New System.Drawing.Point(2, 264)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbItemData.Size = New System.Drawing.Size(993, 257)
        Me.gbItemData.TabIndex = 6
        Me.gbItemData.TabStop = False
        Me.gbItemData.Text = "بيانات الصنف"
        '
        'LibltemNO
        '
        Me.LibltemNO.Location = New System.Drawing.Point(488, 145)
        Me.LibltemNO.Name = "LibltemNO"
        Me.LibltemNO.Size = New System.Drawing.Size(125, 19)
        Me.LibltemNO.TabIndex = 235
        Me.LibltemNO.Text = "رقم القطعه"
        Me.LibltemNO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TexltemNO
        '
        Me.TexltemNO.BackColor = System.Drawing.Color.White
        Me.TexltemNO.ForeColor = System.Drawing.Color.Black
        Me.TexltemNO.Location = New System.Drawing.Point(274, 141)
        Me.TexltemNO.Name = "TexltemNO"
        Me.TexltemNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TexltemNO.Size = New System.Drawing.Size(209, 24)
        Me.TexltemNO.TabIndex = 234
        Me.TexltemNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LAIBELAttachments
        '
        Me.LAIBELAttachments.Location = New System.Drawing.Point(859, 197)
        Me.LAIBELAttachments.Name = "LAIBELAttachments"
        Me.LAIBELAttachments.Size = New System.Drawing.Size(125, 40)
        Me.LAIBELAttachments.TabIndex = 233
        Me.LAIBELAttachments.Text = "المرفقات"
        Me.LAIBELAttachments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TEXTAttachments
        '
        Me.TEXTAttachments.BackColor = System.Drawing.Color.White
        Me.TEXTAttachments.ForeColor = System.Drawing.Color.Black
        Me.TEXTAttachments.Location = New System.Drawing.Point(272, 203)
        Me.TEXTAttachments.Multiline = True
        Me.TEXTAttachments.Name = "TEXTAttachments"
        Me.TEXTAttachments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TEXTAttachments.Size = New System.Drawing.Size(578, 38)
        Me.TEXTAttachments.TabIndex = 232
        Me.TEXTAttachments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LABILYearOfWarr
        '
        Me.LABILYearOfWarr.Location = New System.Drawing.Point(861, 144)
        Me.LABILYearOfWarr.Name = "LABILYearOfWarr"
        Me.LABILYearOfWarr.Size = New System.Drawing.Size(125, 19)
        Me.LABILYearOfWarr.TabIndex = 231
        Me.LABILYearOfWarr.Text = "سنة الضمان"
        Me.LABILYearOfWarr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TEXTYearOfWarr
        '
        Me.TEXTYearOfWarr.BackColor = System.Drawing.Color.White
        Me.TEXTYearOfWarr.ForeColor = System.Drawing.Color.Black
        Me.TEXTYearOfWarr.Location = New System.Drawing.Point(615, 141)
        Me.TEXTYearOfWarr.Name = "TEXTYearOfWarr"
        Me.TEXTYearOfWarr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TEXTYearOfWarr.Size = New System.Drawing.Size(235, 24)
        Me.TEXTYearOfWarr.TabIndex = 230
        Me.TEXTYearOfWarr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBrand
        '
        Me.btnBrand.Location = New System.Drawing.Point(615, 45)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(25, 25)
        Me.btnBrand.TabIndex = 228
        Me.btnBrand.Text = "+"
        Me.btnBrand.UseVisualStyleBackColor = True
        '
        'btnPayPrint
        '
        Me.btnPayPrint.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnPayPrint.ForeColor = System.Drawing.Color.White
        Me.btnPayPrint.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnPayPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayPrint.Location = New System.Drawing.Point(6, 188)
        Me.btnPayPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayPrint.Name = "btnPayPrint"
        Me.btnPayPrint.Size = New System.Drawing.Size(125, 54)
        Me.btnPayPrint.TabIndex = 229
        Me.btnPayPrint.Text = "دفع وطباعة"
        Me.btnPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayPrint.UseVisualStyleBackColor = False
        '
        'btnItemName
        '
        Me.btnItemName.Location = New System.Drawing.Point(615, 22)
        Me.btnItemName.Name = "btnItemName"
        Me.btnItemName.Size = New System.Drawing.Size(25, 25)
        Me.btnItemName.TabIndex = 227
        Me.btnItemName.Text = "+"
        Me.btnItemName.UseVisualStyleBackColor = True
        '
        'btnDep
        '
        Me.btnDep.Location = New System.Drawing.Point(274, 68)
        Me.btnDep.Name = "btnDep"
        Me.btnDep.Size = New System.Drawing.Size(26, 25)
        Me.btnDep.TabIndex = 225
        Me.btnDep.Text = "+"
        Me.btnDep.UseVisualStyleBackColor = True
        '
        'cmbAccessories_DEP
        '
        Me.cmbAccessories_DEP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAccessories_DEP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccessories_DEP.DataSource = Me.AccessoriesDEPBindingSource
        Me.cmbAccessories_DEP.DisplayMember = "Accessories_DEP_NAME"
        Me.cmbAccessories_DEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessories_DEP.FormattingEnabled = True
        Me.cmbAccessories_DEP.Location = New System.Drawing.Point(299, 69)
        Me.cmbAccessories_DEP.Name = "cmbAccessories_DEP"
        Me.cmbAccessories_DEP.Size = New System.Drawing.Size(184, 23)
        Me.cmbAccessories_DEP.TabIndex = 228
        Me.cmbAccessories_DEP.ValueMember = "Accessories_DEP_NAME"
        '
        'AccessoriesDEPBindingSource
        '
        Me.AccessoriesDEPBindingSource.DataMember = "Accessories_DEP"
        Me.AccessoriesDEPBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'btnCat
        '
        Me.btnCat.Location = New System.Drawing.Point(274, 45)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(26, 25)
        Me.btnCat.TabIndex = 226
        Me.btnCat.Text = "+"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'cmbCashier
        '
        Me.cmbCashier.DataSource = Me.CacherBindingSource
        Me.cmbCashier.DisplayMember = "cacher_name"
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(274, 93)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(209, 23)
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
        Me.lblReceiver.Location = New System.Drawing.Point(488, 95)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(125, 19)
        Me.lblReceiver.TabIndex = 227
        Me.lblReceiver.Text = "المستلم"
        Me.lblReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtReceiveDate
        '
        Me.dtReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDate.Location = New System.Drawing.Point(274, 22)
        Me.dtReceiveDate.Name = "dtReceiveDate"
        Me.dtReceiveDate.Size = New System.Drawing.Size(209, 24)
        Me.dtReceiveDate.TabIndex = 5
        '
        'cmbAccessories_NAME
        '
        Me.cmbAccessories_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAccessories_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccessories_NAME.DataSource = Me.AuctionItemTypeBindingSource
        Me.cmbAccessories_NAME.DisplayMember = "Auction_Type"
        Me.cmbAccessories_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessories_NAME.FormattingEnabled = True
        Me.cmbAccessories_NAME.Location = New System.Drawing.Point(640, 23)
        Me.cmbAccessories_NAME.Name = "cmbAccessories_NAME"
        Me.cmbAccessories_NAME.Size = New System.Drawing.Size(210, 23)
        Me.cmbAccessories_NAME.TabIndex = 0
        Me.cmbAccessories_NAME.ValueMember = "Item_Name"
        '
        'AuctionItemTypeBindingSource
        '
        Me.AuctionItemTypeBindingSource.DataMember = "Auction_ItemType"
        Me.AuctionItemTypeBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'lblPhoto
        '
        Me.lblPhoto.DisabledLinkColor = System.Drawing.Color.Black
        Me.lblPhoto.Location = New System.Drawing.Point(10, 13)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(256, 19)
        Me.lblPhoto.TabIndex = 11
        Me.lblPhoto.TabStop = True
        Me.lblPhoto.Text = "الصورة"
        Me.lblPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(859, 163)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(125, 34)
        Me.lblDetails.TabIndex = 53
        Me.lblDetails.Text = "ملاحظات"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(488, 120)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(125, 19)
        Me.lblPrice.TabIndex = 53
        Me.lblPrice.Text = "السعر"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemStatus
        '
        Me.lblItemStatus.Location = New System.Drawing.Point(861, 117)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(125, 22)
        Me.lblItemStatus.TabIndex = 53
        Me.lblItemStatus.Text = "حالة السلعة"
        Me.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSerialNo
        '
        Me.lblSerialNo.Location = New System.Drawing.Point(861, 94)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(125, 22)
        Me.lblSerialNo.TabIndex = 53
        Me.lblSerialNo.Text = "السيريال"
        Me.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(861, 70)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(125, 22)
        Me.lblModel.TabIndex = 52
        Me.lblModel.Text = "رقم الموديل"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.Location = New System.Drawing.Point(861, 23)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(125, 22)
        Me.lblItemName.TabIndex = 51
        Me.lblItemName.Text = "النوع"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrand
        '
        Me.lblBrand.Location = New System.Drawing.Point(861, 46)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(125, 22)
        Me.lblBrand.TabIndex = 50
        Me.lblBrand.Text = "الماركة"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.BackColor = System.Drawing.Color.White
        Me.txtNotes.ForeColor = System.Drawing.Color.Black
        Me.txtNotes.Location = New System.Drawing.Point(272, 166)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(577, 31)
        Me.txtNotes.TabIndex = 8
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuaranteeStatus
        '
        Me.lblGuaranteeStatus.Location = New System.Drawing.Point(488, 49)
        Me.lblGuaranteeStatus.Name = "lblGuaranteeStatus"
        Me.lblGuaranteeStatus.Size = New System.Drawing.Size(125, 19)
        Me.lblGuaranteeStatus.TabIndex = 56
        Me.lblGuaranteeStatus.Text = "الفئة"
        Me.lblGuaranteeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReceiveDate
        '
        Me.lblReceiveDate.Location = New System.Drawing.Point(488, 24)
        Me.lblReceiveDate.Name = "lblReceiveDate"
        Me.lblReceiveDate.Size = New System.Drawing.Size(125, 22)
        Me.lblReceiveDate.TabIndex = 55
        Me.lblReceiveDate.Text = "تاريخ الشراء"
        Me.lblReceiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.White
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.Location = New System.Drawing.Point(274, 116)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrice.Size = New System.Drawing.Size(209, 24)
        Me.txtPrice.TabIndex = 9
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuaranteeDate
        '
        Me.lblGuaranteeDate.Location = New System.Drawing.Point(488, 73)
        Me.lblGuaranteeDate.Name = "lblGuaranteeDate"
        Me.lblGuaranteeDate.Size = New System.Drawing.Size(125, 19)
        Me.lblGuaranteeDate.TabIndex = 56
        Me.lblGuaranteeDate.Text = "القسم"
        Me.lblGuaranteeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImage
        '
        Me.pbImage.BackColor = System.Drawing.Color.White
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbImage.Location = New System.Drawing.Point(10, 35)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(256, 148)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 50
        Me.pbImage.TabStop = False
        '
        'cmbAccessories_CAT
        '
        Me.cmbAccessories_CAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAccessories_CAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccessories_CAT.DataSource = Me.AccessoriesCATBindingSource
        Me.cmbAccessories_CAT.DisplayMember = "Accessories_CAT_NAME"
        Me.cmbAccessories_CAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccessories_CAT.FormattingEnabled = True
        Me.cmbAccessories_CAT.Location = New System.Drawing.Point(299, 46)
        Me.cmbAccessories_CAT.Name = "cmbAccessories_CAT"
        Me.cmbAccessories_CAT.Size = New System.Drawing.Size(184, 23)
        Me.cmbAccessories_CAT.TabIndex = 6
        Me.cmbAccessories_CAT.ValueMember = "Accessories_CAT_NAME"
        '
        'AccessoriesCATBindingSource
        '
        Me.AccessoriesCATBindingSource.DataMember = "Accessories_CAT"
        Me.AccessoriesCATBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'cmbItemStatus
        '
        Me.cmbItemStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbItemStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemStatus.DataSource = Me.AuctionItemStatusBindingSource
        Me.cmbItemStatus.DisplayMember = "ItemStatus_Name"
        Me.cmbItemStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemStatus.FormattingEnabled = True
        Me.cmbItemStatus.Location = New System.Drawing.Point(615, 117)
        Me.cmbItemStatus.Name = "cmbItemStatus"
        Me.cmbItemStatus.Size = New System.Drawing.Size(235, 23)
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
        Me.btnSave.Location = New System.Drawing.Point(141, 187)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 54)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Accessories_BuyDataGridView
        '
        Me.Accessories_BuyDataGridView.AllowUserToAddRows = False
        Me.Accessories_BuyDataGridView.AllowUserToDeleteRows = False
        Me.Accessories_BuyDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_BuyDataGridView.AutoGenerateColumns = False
        Me.Accessories_BuyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accessories_BuyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccessoriesIDDataGridViewTextBoxColumn, Me.AccessoriesNAMEDataGridViewTextBoxColumn, Me.AccessoriesBRANDDataGridViewTextBoxColumn, Me.AccessoriesDESCDataGridViewTextBoxColumn, Me.AccessoriesItemStatusDataGridViewTextBoxColumn, Me.AccessoriesCATDataGridViewTextBoxColumn, Me.AccessoriesDEPDataGridViewTextBoxColumn, Me.AccessoriesmodelnoDataGridViewTextBoxColumn, Me.AccessoriesnomDataGridViewTextBoxColumn, Me.AccessoriesPICDataGridViewImageColumn, Me.AccessoriesTIMEDataGridViewTextBoxColumn, Me.AccessoriesDATECREDataGridViewTextBoxColumn, Me.AccessoriesUSERCRETDataGridViewTextBoxColumn, Me.AccessoriesCIDDataGridViewTextBoxColumn, Me.AccessoriesPriceDataGridViewTextBoxColumn, Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn})
        Me.Accessories_BuyDataGridView.DataSource = Me.Accessories_BuyBindingSource
        Me.Accessories_BuyDataGridView.Location = New System.Drawing.Point(-58, 4)
        Me.Accessories_BuyDataGridView.Name = "Accessories_BuyDataGridView"
        Me.Accessories_BuyDataGridView.ReadOnly = True
        Me.Accessories_BuyDataGridView.RowHeadersVisible = False
        Me.Accessories_BuyDataGridView.Size = New System.Drawing.Size(50, 24)
        Me.Accessories_BuyDataGridView.TabIndex = 54
        '
        'AccessoriesIDDataGridViewTextBoxColumn
        '
        Me.AccessoriesIDDataGridViewTextBoxColumn.DataPropertyName = "AccessoriesID"
        Me.AccessoriesIDDataGridViewTextBoxColumn.HeaderText = "AccessoriesID"
        Me.AccessoriesIDDataGridViewTextBoxColumn.Name = "AccessoriesIDDataGridViewTextBoxColumn"
        Me.AccessoriesIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesNAMEDataGridViewTextBoxColumn
        '
        Me.AccessoriesNAMEDataGridViewTextBoxColumn.DataPropertyName = "Accessories_NAME"
        Me.AccessoriesNAMEDataGridViewTextBoxColumn.HeaderText = "Accessories_NAME"
        Me.AccessoriesNAMEDataGridViewTextBoxColumn.Name = "AccessoriesNAMEDataGridViewTextBoxColumn"
        Me.AccessoriesNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesBRANDDataGridViewTextBoxColumn
        '
        Me.AccessoriesBRANDDataGridViewTextBoxColumn.DataPropertyName = "Accessories_BRAND"
        Me.AccessoriesBRANDDataGridViewTextBoxColumn.HeaderText = "Accessories_BRAND"
        Me.AccessoriesBRANDDataGridViewTextBoxColumn.Name = "AccessoriesBRANDDataGridViewTextBoxColumn"
        Me.AccessoriesBRANDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesDESCDataGridViewTextBoxColumn
        '
        Me.AccessoriesDESCDataGridViewTextBoxColumn.DataPropertyName = "Accessories_DESC"
        Me.AccessoriesDESCDataGridViewTextBoxColumn.HeaderText = "Accessories_DESC"
        Me.AccessoriesDESCDataGridViewTextBoxColumn.Name = "AccessoriesDESCDataGridViewTextBoxColumn"
        Me.AccessoriesDESCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesItemStatusDataGridViewTextBoxColumn
        '
        Me.AccessoriesItemStatusDataGridViewTextBoxColumn.DataPropertyName = "Accessories_ItemStatus"
        Me.AccessoriesItemStatusDataGridViewTextBoxColumn.HeaderText = "Accessories_ItemStatus"
        Me.AccessoriesItemStatusDataGridViewTextBoxColumn.Name = "AccessoriesItemStatusDataGridViewTextBoxColumn"
        Me.AccessoriesItemStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesCATDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT"
        Me.AccessoriesCATDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT"
        Me.AccessoriesCATDataGridViewTextBoxColumn.Name = "AccessoriesCATDataGridViewTextBoxColumn"
        Me.AccessoriesCATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesDEPDataGridViewTextBoxColumn
        '
        Me.AccessoriesDEPDataGridViewTextBoxColumn.DataPropertyName = "Accessories_DEP"
        Me.AccessoriesDEPDataGridViewTextBoxColumn.HeaderText = "Accessories_DEP"
        Me.AccessoriesDEPDataGridViewTextBoxColumn.Name = "AccessoriesDEPDataGridViewTextBoxColumn"
        Me.AccessoriesDEPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesmodelnoDataGridViewTextBoxColumn
        '
        Me.AccessoriesmodelnoDataGridViewTextBoxColumn.DataPropertyName = "Accessories_model_no"
        Me.AccessoriesmodelnoDataGridViewTextBoxColumn.HeaderText = "Accessories_model_no"
        Me.AccessoriesmodelnoDataGridViewTextBoxColumn.Name = "AccessoriesmodelnoDataGridViewTextBoxColumn"
        Me.AccessoriesmodelnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesnomDataGridViewTextBoxColumn
        '
        Me.AccessoriesnomDataGridViewTextBoxColumn.DataPropertyName = "Accessories_nom"
        Me.AccessoriesnomDataGridViewTextBoxColumn.HeaderText = "Accessories_nom"
        Me.AccessoriesnomDataGridViewTextBoxColumn.Name = "AccessoriesnomDataGridViewTextBoxColumn"
        Me.AccessoriesnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesPICDataGridViewImageColumn
        '
        Me.AccessoriesPICDataGridViewImageColumn.DataPropertyName = "Accessories_PIC"
        Me.AccessoriesPICDataGridViewImageColumn.HeaderText = "Accessories_PIC"
        Me.AccessoriesPICDataGridViewImageColumn.Name = "AccessoriesPICDataGridViewImageColumn"
        Me.AccessoriesPICDataGridViewImageColumn.ReadOnly = True
        '
        'AccessoriesTIMEDataGridViewTextBoxColumn
        '
        Me.AccessoriesTIMEDataGridViewTextBoxColumn.DataPropertyName = "Accessories_TIME"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn.HeaderText = "Accessories_TIME"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn.Name = "AccessoriesTIMEDataGridViewTextBoxColumn"
        Me.AccessoriesTIMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesDATECREDataGridViewTextBoxColumn
        '
        Me.AccessoriesDATECREDataGridViewTextBoxColumn.DataPropertyName = "Accessories_DATE_CRE"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn.HeaderText = "Accessories_DATE_CRE"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn.Name = "AccessoriesDATECREDataGridViewTextBoxColumn"
        Me.AccessoriesDATECREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesUSERCRETDataGridViewTextBoxColumn
        '
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn.DataPropertyName = "Accessories_USER_CRET"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn.HeaderText = "Accessories_USER_CRET"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn.Name = "AccessoriesUSERCRETDataGridViewTextBoxColumn"
        Me.AccessoriesUSERCRETDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesCIDDataGridViewTextBoxColumn
        '
        Me.AccessoriesCIDDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CID"
        Me.AccessoriesCIDDataGridViewTextBoxColumn.HeaderText = "Accessories_CID"
        Me.AccessoriesCIDDataGridViewTextBoxColumn.Name = "AccessoriesCIDDataGridViewTextBoxColumn"
        Me.AccessoriesCIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesPriceDataGridViewTextBoxColumn
        '
        Me.AccessoriesPriceDataGridViewTextBoxColumn.DataPropertyName = "Accessories_Price"
        Me.AccessoriesPriceDataGridViewTextBoxColumn.HeaderText = "Accessories_Price"
        Me.AccessoriesPriceDataGridViewTextBoxColumn.Name = "AccessoriesPriceDataGridViewTextBoxColumn"
        Me.AccessoriesPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesInvoiceNoDataGridViewTextBoxColumn
        '
        Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "Accessories_InvoiceNo"
        Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn.HeaderText = "Accessories_InvoiceNo"
        Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn.Name = "AccessoriesInvoiceNoDataGridViewTextBoxColumn"
        Me.AccessoriesInvoiceNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'txtAccessories_NAMEDB
        '
        Me.txtAccessories_NAMEDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessories_NAMEDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_NAME", True))
        Me.txtAccessories_NAMEDB.Location = New System.Drawing.Point(-58, 52)
        Me.txtAccessories_NAMEDB.Name = "txtAccessories_NAMEDB"
        Me.txtAccessories_NAMEDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAccessories_NAMEDB.TabIndex = 55
        '
        'txtAccessories_BRANDDB
        '
        Me.txtAccessories_BRANDDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessories_BRANDDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_BRAND", True))
        Me.txtAccessories_BRANDDB.Location = New System.Drawing.Point(-58, 76)
        Me.txtAccessories_BRANDDB.Name = "txtAccessories_BRANDDB"
        Me.txtAccessories_BRANDDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAccessories_BRANDDB.TabIndex = 56
        '
        'txtModelDB
        '
        Me.txtModelDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_model_no", True))
        Me.txtModelDB.Location = New System.Drawing.Point(-58, 196)
        Me.txtModelDB.Name = "txtModelDB"
        Me.txtModelDB.Size = New System.Drawing.Size(50, 24)
        Me.txtModelDB.TabIndex = 57
        '
        'txtSerialNoDB
        '
        Me.txtSerialNoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerialNoDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_nom", True))
        Me.txtSerialNoDB.Location = New System.Drawing.Point(-58, 220)
        Me.txtSerialNoDB.Name = "txtSerialNoDB"
        Me.txtSerialNoDB.Size = New System.Drawing.Size(50, 24)
        Me.txtSerialNoDB.TabIndex = 58
        '
        'txtItemStatusDB
        '
        Me.txtItemStatusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemStatusDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_ItemStatus", True))
        Me.txtItemStatusDB.Location = New System.Drawing.Point(-58, 124)
        Me.txtItemStatusDB.Name = "txtItemStatusDB"
        Me.txtItemStatusDB.Size = New System.Drawing.Size(50, 24)
        Me.txtItemStatusDB.TabIndex = 59
        '
        'txtAccessories_DEPDB
        '
        Me.txtAccessories_DEPDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessories_DEPDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_DEP", True))
        Me.txtAccessories_DEPDB.Location = New System.Drawing.Point(-58, 172)
        Me.txtAccessories_DEPDB.Name = "txtAccessories_DEPDB"
        Me.txtAccessories_DEPDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAccessories_DEPDB.TabIndex = 63
        '
        'txtPriceDB
        '
        Me.txtPriceDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPriceDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_Price", True))
        Me.txtPriceDB.Location = New System.Drawing.Point(-58, 367)
        Me.txtPriceDB.Name = "txtPriceDB"
        Me.txtPriceDB.Size = New System.Drawing.Size(50, 24)
        Me.txtPriceDB.TabIndex = 65
        '
        'txtAccessoriesIDDB
        '
        Me.txtAccessoriesIDDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessoriesIDDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "AccessoriesID", True))
        Me.txtAccessoriesIDDB.Location = New System.Drawing.Point(-58, 28)
        Me.txtAccessoriesIDDB.Name = "txtAccessoriesIDDB"
        Me.txtAccessoriesIDDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAccessoriesIDDB.TabIndex = 221
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.DocumentMapWidth = 34
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptAuctionReceive.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(50, 24)
        Me.ReportViewer1.TabIndex = 222
        '
        'Auction_ItemTypeTableAdapter
        '
        Me.Auction_ItemTypeTableAdapter.ClearBeforeFill = True
        '
        'Auction_BrandTableAdapter
        '
        Me.Auction_BrandTableAdapter.ClearBeforeFill = True
        '
        'Auction_ItemStatusTableAdapter
        '
        Me.Auction_ItemStatusTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Me.Auction_BrandTableAdapter
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
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
        Me.TableAdapterManager.PayInstallmentTableAdapter = Nothing
        Me.TableAdapterManager.PayMethodTableAdapter = Nothing
        Me.TableAdapterManager.ReportPathTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.SndGoldTableAdapter = Nothing
        Me.TableAdapterManager.SndToCustomerTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'pnl
        '
        Me.pnl.Controls.Add(ItemNoLabel)
        Me.pnl.Controls.Add(Me.Accessories_TIMETextBoxDB)
        Me.pnl.Controls.Add(Me.ItemNoTextBox)
        Me.pnl.Controls.Add(Accessories_AttachmentsLabel)
        Me.pnl.Controls.Add(Me.txtInvoiceNoDB)
        Me.pnl.Controls.Add(Me.Accessories_AttachmentsTextBox)
        Me.pnl.Controls.Add(Me.AccessoriesBuyInvoiceNoTextBox)
        Me.pnl.Controls.Add(Accessories_YearOfWarrLabel)
        Me.pnl.Controls.Add(Me.Accessories_DESCTextBox)
        Me.pnl.Controls.Add(Me.Accessories_YearOfWarrTextBox)
        Me.pnl.Controls.Add(Me.txtAccessories_CATDB)
        Me.pnl.Controls.Add(Me.CacherIDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_BuyDataGridView)
        Me.pnl.Controls.Add(Me.CastomerIDTextBoxDB)
        Me.pnl.Controls.Add(Me.ReportViewer1)
        Me.pnl.Controls.Add(Me.pbImageDB)
        Me.pnl.Controls.Add(Me.txtAccessories_NAMEDB)
        Me.pnl.Controls.Add(Me.dtReceiveDateDB)
        Me.pnl.Controls.Add(Me.txtAccessoriesIDDB)
        Me.pnl.Controls.Add(Me.txtAccessories_BRANDDB)
        Me.pnl.Controls.Add(Me.txtModelDB)
        Me.pnl.Controls.Add(Me.txtSerialNoDB)
        Me.pnl.Controls.Add(Me.txtItemStatusDB)
        Me.pnl.Controls.Add(Me.txtAccessories_DEPDB)
        Me.pnl.Controls.Add(Me.txtPriceDB)
        Me.pnl.Location = New System.Drawing.Point(1520, 25)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(63, 46)
        Me.pnl.TabIndex = 224
        '
        'Accessories_TIMETextBoxDB
        '
        Me.Accessories_TIMETextBoxDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_TIMETextBoxDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_TIME", True))
        Me.Accessories_TIMETextBoxDB.Location = New System.Drawing.Point(-58, 295)
        Me.Accessories_TIMETextBoxDB.Name = "Accessories_TIMETextBoxDB"
        Me.Accessories_TIMETextBoxDB.Size = New System.Drawing.Size(50, 24)
        Me.Accessories_TIMETextBoxDB.TabIndex = 229
        '
        'txtInvoiceNoDB
        '
        Me.txtInvoiceNoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNoDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_InvoiceNo", True))
        Me.txtInvoiceNoDB.Location = New System.Drawing.Point(-58, 391)
        Me.txtInvoiceNoDB.Name = "txtInvoiceNoDB"
        Me.txtInvoiceNoDB.Size = New System.Drawing.Size(50, 24)
        Me.txtInvoiceNoDB.TabIndex = 228
        '
        'AccessoriesBuyInvoiceNoTextBox
        '
        Me.AccessoriesBuyInvoiceNoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesBuyInvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccessoriesBuyInvoiceMaxBindingSource, "Accessories_InvoiceNoMax", True))
        Me.AccessoriesBuyInvoiceNoTextBox.Location = New System.Drawing.Point(-2, 391)
        Me.AccessoriesBuyInvoiceNoTextBox.Name = "AccessoriesBuyInvoiceNoTextBox"
        Me.AccessoriesBuyInvoiceNoTextBox.Size = New System.Drawing.Size(50, 24)
        Me.AccessoriesBuyInvoiceNoTextBox.TabIndex = 227
        '
        'AccessoriesBuyInvoiceMaxBindingSource
        '
        Me.AccessoriesBuyInvoiceMaxBindingSource.DataMember = "AccessoriesBuyInvoiceMax"
        Me.AccessoriesBuyInvoiceMaxBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Accessories_DESCTextBox
        '
        Me.Accessories_DESCTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_DESC", True))
        Me.Accessories_DESCTextBox.Location = New System.Drawing.Point(-58, 100)
        Me.Accessories_DESCTextBox.Name = "Accessories_DESCTextBox"
        Me.Accessories_DESCTextBox.Size = New System.Drawing.Size(50, 24)
        Me.Accessories_DESCTextBox.TabIndex = 226
        '
        'txtAccessories_CATDB
        '
        Me.txtAccessories_CATDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccessories_CATDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_CAT", True))
        Me.txtAccessories_CATDB.Location = New System.Drawing.Point(-58, 148)
        Me.txtAccessories_CATDB.Name = "txtAccessories_CATDB"
        Me.txtAccessories_CATDB.Size = New System.Drawing.Size(50, 24)
        Me.txtAccessories_CATDB.TabIndex = 225
        '
        'CacherIDTextBox
        '
        Me.CacherIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacherIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_USER_CRET", True))
        Me.CacherIDTextBox.Location = New System.Drawing.Point(-58, 319)
        Me.CacherIDTextBox.Name = "CacherIDTextBox"
        Me.CacherIDTextBox.Size = New System.Drawing.Size(50, 24)
        Me.CacherIDTextBox.TabIndex = 224
        '
        'CastomerIDTextBoxDB
        '
        Me.CastomerIDTextBoxDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerIDTextBoxDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_CID", True))
        Me.CastomerIDTextBoxDB.Location = New System.Drawing.Point(-58, 343)
        Me.CastomerIDTextBoxDB.Name = "CastomerIDTextBoxDB"
        Me.CastomerIDTextBoxDB.Size = New System.Drawing.Size(50, 24)
        Me.CastomerIDTextBoxDB.TabIndex = 220
        '
        'pbImageDB
        '
        Me.pbImageDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbImageDB.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Accessories_BuyBindingSource, "Accessories_PIC", True))
        Me.pbImageDB.Location = New System.Drawing.Point(-58, 244)
        Me.pbImageDB.Name = "pbImageDB"
        Me.pbImageDB.Size = New System.Drawing.Size(50, 27)
        Me.pbImageDB.TabIndex = 64
        Me.pbImageDB.TabStop = False
        '
        'dtReceiveDateDB
        '
        Me.dtReceiveDateDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtReceiveDateDB.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDateDB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_BuyBindingSource, "Accessories_DATE_CRE", True))
        Me.dtReceiveDateDB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDateDB.Location = New System.Drawing.Point(-58, 271)
        Me.dtReceiveDateDB.Name = "dtReceiveDateDB"
        Me.dtReceiveDateDB.Size = New System.Drawing.Size(50, 24)
        Me.dtReceiveDateDB.TabIndex = 62
        '
        'CacherTableAdapter
        '
        Me.CacherTableAdapter.ClearBeforeFill = True
        '
        'Accessories_BuyTableAdapter
        '
        Me.Accessories_BuyTableAdapter.ClearBeforeFill = True
        '
        'Accessories_DEPTableAdapter
        '
        Me.Accessories_DEPTableAdapter.ClearBeforeFill = True
        '
        'Accessories_CATTableAdapter
        '
        Me.Accessories_CATTableAdapter.ClearBeforeFill = True
        '
        'Accessories_BuyVwTableAdapter
        '
        Me.Accessories_BuyVwTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesBuyInvoiceMaxTableAdapter
        '
        Me.AccessoriesBuyInvoiceMaxTableAdapter.ClearBeforeFill = True
        '
        'Accessories_YearOfWarrTextBox
        '
        Me.Accessories_YearOfWarrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_YearOfWarr", True))
        Me.Accessories_YearOfWarrTextBox.Location = New System.Drawing.Point(192, 416)
        Me.Accessories_YearOfWarrTextBox.Name = "Accessories_YearOfWarrTextBox"
        Me.Accessories_YearOfWarrTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Accessories_YearOfWarrTextBox.TabIndex = 225
        '
        'Accessories_AttachmentsTextBox
        '
        Me.Accessories_AttachmentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "Accessories_Attachments", True))
        Me.Accessories_AttachmentsTextBox.Location = New System.Drawing.Point(192, 446)
        Me.Accessories_AttachmentsTextBox.Name = "Accessories_AttachmentsTextBox"
        Me.Accessories_AttachmentsTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Accessories_AttachmentsTextBox.TabIndex = 226
        '
        'ItemNoTextBox
        '
        Me.ItemNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_BuyBindingSource, "ItemNo", True))
        Me.ItemNoTextBox.Location = New System.Drawing.Point(192, 476)
        Me.ItemNoTextBox.Name = "ItemNoTextBox"
        Me.ItemNoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ItemNoTextBox.TabIndex = 227
        '
        'AccessoriesBuy
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(1000, 740)
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AccessoriesBuy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شراء"
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBuyVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accessories_BuyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.AccessoriesDEPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionItemTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesCATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionItemStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accessories_BuyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.AccessoriesBuyInvoiceMaxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImageDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents cmbBrand_Name As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents gbItemData As System.Windows.Forms.GroupBox
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
    Friend WithEvents cmbAccessories_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents lblGuaranteeStatus As System.Windows.Forms.Label
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblItemStatus As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents dtReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbAccessories_CAT As System.Windows.Forms.ComboBox
    Friend WithEvents AuctionItemTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_ItemTypeTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemTypeTableAdapter
    Friend WithEvents AuctionBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_BrandTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter
    Friend WithEvents AuctionItemStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Auction_ItemStatusTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_ItemStatusTableAdapter
    Friend WithEvents Accessories_BuyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Accessories_BuyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtAccessories_NAMEDB As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessories_BRANDDB As System.Windows.Forms.TextBox
    Friend WithEvents txtModelDB As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialNoDB As System.Windows.Forms.TextBox
    Friend WithEvents txtItemStatusDB As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessories_DEPDB As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceDB As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessoriesIDDB As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents CastomerIDTextBoxDB As System.Windows.Forms.TextBox
    Friend WithEvents pbImageDB As System.Windows.Forms.PictureBox
    Friend WithEvents dtReceiveDateDB As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents CacherIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessories_CATDB As System.Windows.Forms.TextBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CacherTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents AccessoriesIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesBRANDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesItemStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesDEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesmodelnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesPICDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents AccessoriesTIMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesDATECREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesUSERCRETDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesInvoiceNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accessories_BuyTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_BuyTableAdapter
    Friend WithEvents cmbAccessories_DEP As System.Windows.Forms.ComboBox
    Friend WithEvents AccessoriesDEPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_DEPTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_DEPTableAdapter
    Friend WithEvents AccessoriesCATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_CATTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter
    Friend WithEvents Accessories_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPayPrint As System.Windows.Forms.Button
    Friend WithEvents AccessoriesInvoiceMaxBindingSource As BindingSource
    Friend WithEvents AccessoriesBuyInvoiceNoTextBox As TextBox
    Friend WithEvents txtInvoiceNoDB As TextBox
    Friend WithEvents AccessoriesBuyVwBindingSource As BindingSource
    Friend WithEvents Accessories_BuyVwTableAdapter As DT_restrantDataSetTableAdapters.Accessories_BuyVwTableAdapter
    Friend WithEvents Accessories_TIMETextBoxDB As TextBox
    Friend WithEvents AccessoriesBuyInvoiceMaxBindingSource As BindingSource
    Friend WithEvents AccessoriesBuyInvoiceMaxTableAdapter As DT_restrantDataSetTableAdapters.AccessoriesBuyInvoiceMaxTableAdapter
    Friend WithEvents btnBrand As System.Windows.Forms.Button
    Friend WithEvents btnItemName As System.Windows.Forms.Button
    Friend WithEvents btnDep As System.Windows.Forms.Button
    Friend WithEvents btnCat As System.Windows.Forms.Button
    Friend WithEvents colAccessoriesID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesBRAND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesmodel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesItemStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesCAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesDEP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessoriesDESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAccessories_InvoiceNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accessories_CID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AccessoriesTIMEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesDATECREDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesUSERCRETDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LAIBELAttachments As System.Windows.Forms.Label
    Friend WithEvents TEXTAttachments As System.Windows.Forms.TextBox
    Friend WithEvents LABILYearOfWarr As System.Windows.Forms.Label
    Friend WithEvents TEXTYearOfWarr As System.Windows.Forms.TextBox
    Friend WithEvents LibltemNO As System.Windows.Forms.Label
    Friend WithEvents TexltemNO As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_YearOfWarrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_AttachmentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemNoTextBox As System.Windows.Forms.TextBox
End Class
