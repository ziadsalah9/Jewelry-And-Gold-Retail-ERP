<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuctionInvoice
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuctionInvoice))
        Me.AuctionInvoiceDetailsVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.lblItemPicture = New System.Windows.Forms.Label()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.CacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbInvoice = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.dtGuaranteeDate = New System.Windows.Forms.TextBox()
        Me.dtSellDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSellDate = New System.Windows.Forms.Label()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.txtLink = New System.Windows.Forms.TextBox()
        Me.dtReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblKNET = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.lblSerialNo = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.txtItemDetails = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeStatus = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.lblReceiveDate = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeDate = New System.Windows.Forms.Label()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.txtItemStatus = New System.Windows.Forms.TextBox()
        Me.txtAuction_Type = New System.Windows.Forms.TextBox()
        Me.txtBrand_Name = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeStatus = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.pbItemPhoto = New System.Windows.Forms.PictureBox()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnPayPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceTitle = New System.Windows.Forms.Label()
        Me.lblInvoiceValue = New System.Windows.Forms.Label()
        Me.CastomerDETELSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CastomerDETELSTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.CastomerDETELSTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Auction_AddItemDetailsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_AddItemDetailsTableAdapter()
        Me.CacherTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter()
        Me.Auction_AddItemDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAuction_TypeDB = New System.Windows.Forms.TextBox()
        Me.txtBrand_NameDB = New System.Windows.Forms.TextBox()
        Me.txtModelDB = New System.Windows.Forms.TextBox()
        Me.txtSerialNoDB = New System.Windows.Forms.TextBox()
        Me.txtItemStatusDB = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeStatusDB = New System.Windows.Forms.TextBox()
        Me.dtReceiveDateDB = New System.Windows.Forms.DateTimePicker()
        Me.txtItemDetailsDB = New System.Windows.Forms.TextBox()
        Me.pbItemPhotoDB = New System.Windows.Forms.PictureBox()
        Me.PriceTextBoxDB = New System.Windows.Forms.TextBox()
        Me.AuctionInvoiceDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuctionInvoiceDetailsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsTableAdapter()
        Me.AuctionInvoiceDetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CastomeridTextBox = New System.Windows.Forms.TextBox()
        Me.Auction_IDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.SerialNoTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNewUsedTextBox = New System.Windows.Forms.TextBox()
        Me.GuaranteeStatusTextBox = New System.Windows.Forms.TextBox()
        Me.ReceiveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.K_netTextBox = New System.Windows.Forms.TextBox()
        Me.CacherTextBox = New System.Windows.Forms.TextBox()
        Me.SellDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Invoic_date_timeTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Sroom_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Invoic_NoTextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CashTextBox = New System.Windows.Forms.TextBox()
        Me.AuctionInvoiceDetailsVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.ChequeTextBox = New System.Windows.Forms.TextBox()
        Me.GuaranteeDateTextBox = New System.Windows.Forms.TextBox()
        Me.GuaranteeDatetxtDB = New System.Windows.Forms.TextBox()
        Me.TotalPriceTextBoxAr = New System.Windows.Forms.TextBox()
        Me.LinkTextBox = New System.Windows.Forms.TextBox()
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInvoice.SuspendLayout()
        CType(Me.pbItemPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CastomerDETELSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Auction_AddItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbItemPhotoDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionInvoiceDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionInvoiceDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuctionInvoiceDetailsVwBindingSource
        '
        Me.AuctionInvoiceDetailsVwBindingSource.DataMember = "AuctionInvoiceDetailsVw"
        Me.AuctionInvoiceDetailsVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblItemPicture
        '
        Me.lblItemPicture.ForeColor = System.Drawing.Color.Black
        Me.lblItemPicture.Location = New System.Drawing.Point(16, 19)
        Me.lblItemPicture.Name = "lblItemPicture"
        Me.lblItemPicture.Size = New System.Drawing.Size(254, 22)
        Me.lblItemPicture.TabIndex = 7
        Me.lblItemPicture.Text = "الصورة"
        Me.lblItemPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(696, 42)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(136, 24)
        Me.txtBarCode.TabIndex = 1
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCashier
        '
        Me.cmbCashier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbCashier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCashier.DataSource = Me.CacherBindingSource
        Me.cmbCashier.DisplayMember = "cacher_name"
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(836, 42)
        Me.cmbCashier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(136, 23)
        Me.cmbCashier.TabIndex = 0
        Me.cmbCashier.ValueMember = "cacherID"
        '
        'CacherBindingSource
        '
        Me.CacherBindingSource.DataMember = "cacher"
        Me.CacherBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'gbInvoice
        '
        Me.gbInvoice.BackColor = System.Drawing.Color.Transparent
        Me.gbInvoice.Controls.Add(Me.Label1)
        Me.gbInvoice.Controls.Add(Me.txtCheque)
        Me.gbInvoice.Controls.Add(Me.dtGuaranteeDate)
        Me.gbInvoice.Controls.Add(Me.dtSellDate)
        Me.gbInvoice.Controls.Add(Me.lblSellDate)
        Me.gbInvoice.Controls.Add(Me.lblLink)
        Me.gbInvoice.Controls.Add(Me.txtLink)
        Me.gbInvoice.Controls.Add(Me.dtReceiveDate)
        Me.gbInvoice.Controls.Add(Me.lblDetails)
        Me.gbInvoice.Controls.Add(Me.lblTotalPrice)
        Me.gbInvoice.Controls.Add(Me.lblKNET)
        Me.gbInvoice.Controls.Add(Me.lblCash)
        Me.gbInvoice.Controls.Add(Me.lblItemStatus)
        Me.gbInvoice.Controls.Add(Me.lblSerialNo)
        Me.gbInvoice.Controls.Add(Me.lblModel)
        Me.gbInvoice.Controls.Add(Me.lblItemName)
        Me.gbInvoice.Controls.Add(Me.lblBrand)
        Me.gbInvoice.Controls.Add(Me.txtItemDetails)
        Me.gbInvoice.Controls.Add(Me.lblGuaranteeStatus)
        Me.gbInvoice.Controls.Add(Me.txtTotalPrice)
        Me.gbInvoice.Controls.Add(Me.txtKnet)
        Me.gbInvoice.Controls.Add(Me.lblReceiveDate)
        Me.gbInvoice.Controls.Add(Me.txtCash)
        Me.gbInvoice.Controls.Add(Me.lblGuaranteeDate)
        Me.gbInvoice.Controls.Add(Me.txtSerialNo)
        Me.gbInvoice.Controls.Add(Me.txtItemStatus)
        Me.gbInvoice.Controls.Add(Me.txtAuction_Type)
        Me.gbInvoice.Controls.Add(Me.txtBrand_Name)
        Me.gbInvoice.Controls.Add(Me.txtGuaranteeStatus)
        Me.gbInvoice.Controls.Add(Me.txtModel)
        Me.gbInvoice.Controls.Add(Me.lblItemPicture)
        Me.gbInvoice.Controls.Add(Me.lblNote)
        Me.gbInvoice.Controls.Add(Me.pbItemPhoto)
        Me.gbInvoice.Controls.Add(Me.lblBarCode)
        Me.gbInvoice.Controls.Add(Me.lblCashier)
        Me.gbInvoice.Controls.Add(Me.txtNotes)
        Me.gbInvoice.Controls.Add(Me.cmbCashier)
        Me.gbInvoice.Controls.Add(Me.txtBarCode)
        Me.gbInvoice.Controls.Add(Me.btnPayPrint)
        Me.gbInvoice.ForeColor = System.Drawing.Color.Black
        Me.gbInvoice.Location = New System.Drawing.Point(0, 255)
        Me.gbInvoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbInvoice.Name = "gbInvoice"
        Me.gbInvoice.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbInvoice.Size = New System.Drawing.Size(995, 300)
        Me.gbInvoice.TabIndex = 0
        Me.gbInvoice.TabStop = False
        Me.gbInvoice.Text = "بيانات الفاتورة"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "شيك"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.Color.White
        Me.txtCheque.ForeColor = System.Drawing.Color.Black
        Me.txtCheque.Location = New System.Drawing.Point(16, 202)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(60, 24)
        Me.txtCheque.TabIndex = 17
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtGuaranteeDate
        '
        Me.dtGuaranteeDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtGuaranteeDate.ForeColor = System.Drawing.Color.Black
        Me.dtGuaranteeDate.Location = New System.Drawing.Point(556, 107)
        Me.dtGuaranteeDate.Name = "dtGuaranteeDate"
        Me.dtGuaranteeDate.ReadOnly = True
        Me.dtGuaranteeDate.Size = New System.Drawing.Size(136, 24)
        Me.dtGuaranteeDate.TabIndex = 7
        Me.dtGuaranteeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtSellDate
        '
        Me.dtSellDate.CustomFormat = "dd/MM/yyyy"
        Me.dtSellDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSellDate.Location = New System.Drawing.Point(836, 164)
        Me.dtSellDate.Name = "dtSellDate"
        Me.dtSellDate.Size = New System.Drawing.Size(136, 24)
        Me.dtSellDate.TabIndex = 10
        '
        'lblSellDate
        '
        Me.lblSellDate.Location = New System.Drawing.Point(836, 140)
        Me.lblSellDate.Name = "lblSellDate"
        Me.lblSellDate.Size = New System.Drawing.Size(136, 22)
        Me.lblSellDate.TabIndex = 195
        Me.lblSellDate.Text = "تاريخ البيع"
        Me.lblSellDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLink
        '
        Me.lblLink.Location = New System.Drawing.Point(80, 180)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(60, 19)
        Me.lblLink.TabIndex = 193
        Me.lblLink.Text = "رابط"
        Me.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLink
        '
        Me.txtLink.BackColor = System.Drawing.Color.White
        Me.txtLink.ForeColor = System.Drawing.Color.Black
        Me.txtLink.Location = New System.Drawing.Point(80, 202)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(60, 24)
        Me.txtLink.TabIndex = 16
        Me.txtLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtReceiveDate
        '
        Me.dtReceiveDate.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDate.Location = New System.Drawing.Point(696, 107)
        Me.dtReceiveDate.Name = "dtReceiveDate"
        Me.dtReceiveDate.Size = New System.Drawing.Size(136, 24)
        Me.dtReceiveDate.TabIndex = 6
        '
        'lblDetails
        '
        Me.lblDetails.Location = New System.Drawing.Point(276, 142)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(556, 19)
        Me.lblDetails.TabIndex = 184
        Me.lblDetails.Text = "تفاصيل"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Location = New System.Drawing.Point(16, 133)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(254, 19)
        Me.lblTotalPrice.TabIndex = 183
        Me.lblTotalPrice.Text = "سعر البيع"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKNET
        '
        Me.lblKNET.Location = New System.Drawing.Point(144, 180)
        Me.lblKNET.Name = "lblKNET"
        Me.lblKNET.Size = New System.Drawing.Size(60, 19)
        Me.lblKNET.TabIndex = 183
        Me.lblKNET.Text = "كي نت"
        Me.lblKNET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(210, 180)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(60, 19)
        Me.lblCash.TabIndex = 183
        Me.lblCash.Text = "كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCash.Visible = False
        '
        'lblItemStatus
        '
        Me.lblItemStatus.Location = New System.Drawing.Point(836, 84)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(136, 22)
        Me.lblItemStatus.TabIndex = 182
        Me.lblItemStatus.Text = "حالة السلعة"
        Me.lblItemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSerialNo
        '
        Me.lblSerialNo.Location = New System.Drawing.Point(276, 84)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(136, 22)
        Me.lblSerialNo.TabIndex = 185
        Me.lblSerialNo.Text = "رقم السيريال"
        Me.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(276, 19)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(136, 22)
        Me.lblModel.TabIndex = 181
        Me.lblModel.Text = "الموديل"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemName
        '
        Me.lblItemName.Location = New System.Drawing.Point(556, 19)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(136, 22)
        Me.lblItemName.TabIndex = 180
        Me.lblItemName.Text = "النوع"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrand
        '
        Me.lblBrand.Location = New System.Drawing.Point(416, 19)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(136, 22)
        Me.lblBrand.TabIndex = 179
        Me.lblBrand.Text = "الماركة"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemDetails
        '
        Me.txtItemDetails.BackColor = System.Drawing.Color.White
        Me.txtItemDetails.ForeColor = System.Drawing.Color.Black
        Me.txtItemDetails.Location = New System.Drawing.Point(276, 164)
        Me.txtItemDetails.Name = "txtItemDetails"
        Me.txtItemDetails.Size = New System.Drawing.Size(556, 24)
        Me.txtItemDetails.TabIndex = 11
        Me.txtItemDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGuaranteeStatus
        '
        Me.lblGuaranteeStatus.Location = New System.Drawing.Point(416, 84)
        Me.lblGuaranteeStatus.Name = "lblGuaranteeStatus"
        Me.lblGuaranteeStatus.Size = New System.Drawing.Size(136, 22)
        Me.lblGuaranteeStatus.TabIndex = 188
        Me.lblGuaranteeStatus.Text = "حالة الضمان"
        Me.lblGuaranteeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.Color.White
        Me.txtTotalPrice.ForeColor = System.Drawing.Color.Black
        Me.txtTotalPrice.Location = New System.Drawing.Point(16, 154)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(254, 24)
        Me.txtTotalPrice.TabIndex = 13
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.Color.White
        Me.txtKnet.ForeColor = System.Drawing.Color.Black
        Me.txtKnet.Location = New System.Drawing.Point(144, 202)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(60, 24)
        Me.txtKnet.TabIndex = 15
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReceiveDate
        '
        Me.lblReceiveDate.Location = New System.Drawing.Point(696, 84)
        Me.lblReceiveDate.Name = "lblReceiveDate"
        Me.lblReceiveDate.Size = New System.Drawing.Size(136, 22)
        Me.lblReceiveDate.TabIndex = 186
        Me.lblReceiveDate.Text = "تاريخ الاستلام"
        Me.lblReceiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        Me.txtCash.ForeColor = System.Drawing.Color.Black
        Me.txtCash.Location = New System.Drawing.Point(208, 202)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(60, 24)
        Me.txtCash.TabIndex = 14
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Visible = False
        '
        'lblGuaranteeDate
        '
        Me.lblGuaranteeDate.Location = New System.Drawing.Point(556, 84)
        Me.lblGuaranteeDate.Name = "lblGuaranteeDate"
        Me.lblGuaranteeDate.Size = New System.Drawing.Size(136, 22)
        Me.lblGuaranteeDate.TabIndex = 187
        Me.lblGuaranteeDate.Text = "تاريخ الضمان"
        Me.lblGuaranteeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSerialNo
        '
        Me.txtSerialNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSerialNo.ForeColor = System.Drawing.Color.Black
        Me.txtSerialNo.Location = New System.Drawing.Point(276, 107)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.ReadOnly = True
        Me.txtSerialNo.Size = New System.Drawing.Size(136, 24)
        Me.txtSerialNo.TabIndex = 9
        Me.txtSerialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemStatus
        '
        Me.txtItemStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtItemStatus.ForeColor = System.Drawing.Color.Black
        Me.txtItemStatus.Location = New System.Drawing.Point(836, 107)
        Me.txtItemStatus.Name = "txtItemStatus"
        Me.txtItemStatus.ReadOnly = True
        Me.txtItemStatus.Size = New System.Drawing.Size(136, 24)
        Me.txtItemStatus.TabIndex = 5
        Me.txtItemStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAuction_Type
        '
        Me.txtAuction_Type.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAuction_Type.ForeColor = System.Drawing.Color.Black
        Me.txtAuction_Type.Location = New System.Drawing.Point(556, 42)
        Me.txtAuction_Type.Name = "txtAuction_Type"
        Me.txtAuction_Type.ReadOnly = True
        Me.txtAuction_Type.Size = New System.Drawing.Size(136, 24)
        Me.txtAuction_Type.TabIndex = 2
        Me.txtAuction_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBrand_Name
        '
        Me.txtBrand_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBrand_Name.ForeColor = System.Drawing.Color.Black
        Me.txtBrand_Name.Location = New System.Drawing.Point(416, 42)
        Me.txtBrand_Name.Name = "txtBrand_Name"
        Me.txtBrand_Name.ReadOnly = True
        Me.txtBrand_Name.Size = New System.Drawing.Size(136, 24)
        Me.txtBrand_Name.TabIndex = 3
        Me.txtBrand_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuaranteeStatus
        '
        Me.txtGuaranteeStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGuaranteeStatus.ForeColor = System.Drawing.Color.Black
        Me.txtGuaranteeStatus.Location = New System.Drawing.Point(416, 107)
        Me.txtGuaranteeStatus.Name = "txtGuaranteeStatus"
        Me.txtGuaranteeStatus.ReadOnly = True
        Me.txtGuaranteeStatus.Size = New System.Drawing.Size(136, 24)
        Me.txtGuaranteeStatus.TabIndex = 8
        Me.txtGuaranteeStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtModel.ForeColor = System.Drawing.Color.Black
        Me.txtModel.Location = New System.Drawing.Point(276, 42)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(136, 24)
        Me.txtModel.TabIndex = 4
        Me.txtModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNote
        '
        Me.lblNote.ForeColor = System.Drawing.Color.Black
        Me.lblNote.Location = New System.Drawing.Point(276, 206)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(698, 24)
        Me.lblNote.TabIndex = 161
        Me.lblNote.Text = "ملاحظات"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbItemPhoto
        '
        Me.pbItemPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbItemPhoto.Location = New System.Drawing.Point(16, 42)
        Me.pbItemPhoto.Name = "pbItemPhoto"
        Me.pbItemPhoto.Size = New System.Drawing.Size(254, 88)
        Me.pbItemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbItemPhoto.TabIndex = 171
        Me.pbItemPhoto.TabStop = False
        '
        'lblBarCode
        '
        Me.lblBarCode.ForeColor = System.Drawing.Color.Black
        Me.lblBarCode.Location = New System.Drawing.Point(696, 19)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(136, 22)
        Me.lblBarCode.TabIndex = 160
        Me.lblBarCode.Text = "باركود"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashier
        '
        Me.lblCashier.ForeColor = System.Drawing.Color.Black
        Me.lblCashier.Location = New System.Drawing.Point(836, 19)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(136, 22)
        Me.lblCashier.TabIndex = 159
        Me.lblCashier.Text = "كاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(276, 232)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(698, 46)
        Me.txtNotes.TabIndex = 12
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPayPrint
        '
        Me.btnPayPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPayPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPayPrint.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnPayPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayPrint.Location = New System.Drawing.Point(16, 232)
        Me.btnPayPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayPrint.Name = "btnPayPrint"
        Me.btnPayPrint.Size = New System.Drawing.Size(252, 46)
        Me.btnPayPrint.TabIndex = 18
        Me.btnPayPrint.Text = "دفع طباعة الفاتورة"
        Me.btnPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceTitle
        '
        Me.lblInvoiceTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceTitle.AutoSize = True
        Me.lblInvoiceTitle.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceTitle.Location = New System.Drawing.Point(-160, 384)
        Me.lblInvoiceTitle.Name = "lblInvoiceTitle"
        Me.lblInvoiceTitle.Size = New System.Drawing.Size(62, 17)
        Me.lblInvoiceTitle.TabIndex = 169
        Me.lblInvoiceTitle.Text = "رقم الفاتورة"
        '
        'lblInvoiceValue
        '
        Me.lblInvoiceValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceValue.AutoSize = True
        Me.lblInvoiceValue.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceValue.Location = New System.Drawing.Point(-91, 432)
        Me.lblInvoiceValue.Name = "lblInvoiceValue"
        Me.lblInvoiceValue.Size = New System.Drawing.Size(83, 17)
        Me.lblInvoiceValue.TabIndex = 138
        Me.lblInvoiceValue.Text = "InvoiceValue"
        '
        'CastomerDETELSBindingSource
        '
        Me.CastomerDETELSBindingSource.DataMember = "CastomerDETELS"
        Me.CastomerDETELSBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'CastomerDETELSTableAdapter
        '
        Me.CastomerDETELSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ADS_SERVICESTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Me.Auction_AddItemDetailsTableAdapter
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
        Me.TableAdapterManager.cacherTableAdapter = Me.CacherTableAdapter
        Me.TableAdapterManager.CANTRYTableAdapter = Nothing
        Me.TableAdapterManager.CastomerDETELSTableAdapter = Me.CastomerDETELSTableAdapter
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
        'Auction_AddItemDetailsTableAdapter
        '
        Me.Auction_AddItemDetailsTableAdapter.ClearBeforeFill = True
        '
        'CacherTableAdapter
        '
        Me.CacherTableAdapter.ClearBeforeFill = True
        '
        'Auction_AddItemDetailsBindingSource
        '
        Me.Auction_AddItemDetailsBindingSource.DataMember = "Auction_AddItemDetails"
        Me.Auction_AddItemDetailsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'txtAuction_TypeDB
        '
        Me.txtAuction_TypeDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuction_TypeDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "Name", True))
        Me.txtAuction_TypeDB.Location = New System.Drawing.Point(-157, 83)
        Me.txtAuction_TypeDB.Name = "txtAuction_TypeDB"
        Me.txtAuction_TypeDB.Size = New System.Drawing.Size(55, 24)
        Me.txtAuction_TypeDB.TabIndex = 169
        '
        'txtBrand_NameDB
        '
        Me.txtBrand_NameDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrand_NameDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "Brand", True))
        Me.txtBrand_NameDB.Location = New System.Drawing.Point(-157, 110)
        Me.txtBrand_NameDB.Name = "txtBrand_NameDB"
        Me.txtBrand_NameDB.Size = New System.Drawing.Size(55, 24)
        Me.txtBrand_NameDB.TabIndex = 170
        '
        'txtModelDB
        '
        Me.txtModelDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtModelDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "Model", True))
        Me.txtModelDB.Location = New System.Drawing.Point(-157, 137)
        Me.txtModelDB.Name = "txtModelDB"
        Me.txtModelDB.Size = New System.Drawing.Size(55, 24)
        Me.txtModelDB.TabIndex = 171
        '
        'txtSerialNoDB
        '
        Me.txtSerialNoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerialNoDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "SerialNo", True))
        Me.txtSerialNoDB.Location = New System.Drawing.Point(-157, 164)
        Me.txtSerialNoDB.Name = "txtSerialNoDB"
        Me.txtSerialNoDB.Size = New System.Drawing.Size(55, 24)
        Me.txtSerialNoDB.TabIndex = 172
        '
        'txtItemStatusDB
        '
        Me.txtItemStatusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemStatusDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "ItemNewUsed", True))
        Me.txtItemStatusDB.Location = New System.Drawing.Point(-157, 191)
        Me.txtItemStatusDB.Name = "txtItemStatusDB"
        Me.txtItemStatusDB.Size = New System.Drawing.Size(55, 24)
        Me.txtItemStatusDB.TabIndex = 173
        '
        'txtGuaranteeStatusDB
        '
        Me.txtGuaranteeStatusDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuaranteeStatusDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "GuaranteeStatus", True))
        Me.txtGuaranteeStatusDB.Location = New System.Drawing.Point(-157, 218)
        Me.txtGuaranteeStatusDB.Name = "txtGuaranteeStatusDB"
        Me.txtGuaranteeStatusDB.Size = New System.Drawing.Size(55, 24)
        Me.txtGuaranteeStatusDB.TabIndex = 174
        '
        'dtReceiveDateDB
        '
        Me.dtReceiveDateDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtReceiveDateDB.CustomFormat = "dd/MM/yyyy"
        Me.dtReceiveDateDB.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Auction_AddItemDetailsBindingSource, "ReceiveDate", True))
        Me.dtReceiveDateDB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReceiveDateDB.Location = New System.Drawing.Point(-157, 272)
        Me.dtReceiveDateDB.Name = "dtReceiveDateDB"
        Me.dtReceiveDateDB.Size = New System.Drawing.Size(55, 24)
        Me.dtReceiveDateDB.TabIndex = 176
        '
        'txtItemDetailsDB
        '
        Me.txtItemDetailsDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtItemDetailsDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "Details", True))
        Me.txtItemDetailsDB.Location = New System.Drawing.Point(-157, 299)
        Me.txtItemDetailsDB.Name = "txtItemDetailsDB"
        Me.txtItemDetailsDB.Size = New System.Drawing.Size(55, 24)
        Me.txtItemDetailsDB.TabIndex = 177
        '
        'pbItemPhotoDB
        '
        Me.pbItemPhotoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbItemPhotoDB.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Auction_AddItemDetailsBindingSource, "ItemPhoto", True))
        Me.pbItemPhotoDB.Location = New System.Drawing.Point(-157, 326)
        Me.pbItemPhotoDB.Name = "pbItemPhotoDB"
        Me.pbItemPhotoDB.Size = New System.Drawing.Size(55, 28)
        Me.pbItemPhotoDB.TabIndex = 178
        Me.pbItemPhotoDB.TabStop = False
        '
        'PriceTextBoxDB
        '
        Me.PriceTextBoxDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceTextBoxDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "Price", True))
        Me.PriceTextBoxDB.Location = New System.Drawing.Point(-157, 353)
        Me.PriceTextBoxDB.Name = "PriceTextBoxDB"
        Me.PriceTextBoxDB.Size = New System.Drawing.Size(55, 24)
        Me.PriceTextBoxDB.TabIndex = 179
        '
        'AuctionInvoiceDetailsBindingSource
        '
        Me.AuctionInvoiceDetailsBindingSource.DataMember = "AuctionInvoiceDetails"
        Me.AuctionInvoiceDetailsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'AuctionInvoiceDetailsTableAdapter
        '
        Me.AuctionInvoiceDetailsTableAdapter.ClearBeforeFill = True
        '
        'AuctionInvoiceDetailsDataGridView
        '
        Me.AuctionInvoiceDetailsDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AuctionInvoiceDetailsDataGridView.AutoGenerateColumns = False
        Me.AuctionInvoiceDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuctionInvoiceDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40})
        Me.AuctionInvoiceDetailsDataGridView.DataSource = Me.AuctionInvoiceDetailsBindingSource
        Me.AuctionInvoiceDetailsDataGridView.Location = New System.Drawing.Point(-26, 83)
        Me.AuctionInvoiceDetailsDataGridView.Name = "AuctionInvoiceDetailsDataGridView"
        Me.AuctionInvoiceDetailsDataGridView.RowHeadersVisible = False
        Me.AuctionInvoiceDetailsDataGridView.Size = New System.Drawing.Size(55, 28)
        Me.AuctionInvoiceDetailsDataGridView.TabIndex = 179
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Castomerid"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Castomerid"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Auction_ID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Auction_ID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "SerialNo"
        Me.DataGridViewTextBoxColumn25.HeaderText = "SerialNo"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ItemNewUsed"
        Me.DataGridViewTextBoxColumn26.HeaderText = "ItemNewUsed"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "GuaranteeStatus"
        Me.DataGridViewTextBoxColumn27.HeaderText = "GuaranteeStatus"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "GuaranteeDate"
        Me.DataGridViewTextBoxColumn28.HeaderText = "GuaranteeDate"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ReceiveDate"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ReceiveDate"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Details"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Details"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "K_net"
        Me.DataGridViewTextBoxColumn32.HeaderText = "K_net"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "cacher"
        Me.DataGridViewTextBoxColumn33.HeaderText = "cacher"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "SellDate"
        Me.DataGridViewTextBoxColumn34.HeaderText = "SellDate"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "invoic_date_time"
        Me.DataGridViewTextBoxColumn35.HeaderText = "invoic_date_time"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "sroom_name"
        Me.DataGridViewTextBoxColumn39.HeaderText = "sroom_name"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Invoic_No"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Invoic_No"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'CastomeridTextBox
        '
        Me.CastomeridTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomeridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Castomerid", True))
        Me.CastomeridTextBox.Location = New System.Drawing.Point(-26, 111)
        Me.CastomeridTextBox.Name = "CastomeridTextBox"
        Me.CastomeridTextBox.Size = New System.Drawing.Size(55, 24)
        Me.CastomeridTextBox.TabIndex = 180
        '
        'Auction_IDTextBox
        '
        Me.Auction_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Auction_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Auction_ID", True))
        Me.Auction_IDTextBox.Location = New System.Drawing.Point(-26, 138)
        Me.Auction_IDTextBox.Name = "Auction_IDTextBox"
        Me.Auction_IDTextBox.Size = New System.Drawing.Size(55, 24)
        Me.Auction_IDTextBox.TabIndex = 181
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "userID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(-26, 165)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(55, 24)
        Me.UserIDTextBox.TabIndex = 182
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(-26, 192)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(55, 24)
        Me.NameTextBox.TabIndex = 183
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Brand", True))
        Me.BrandTextBox.Location = New System.Drawing.Point(-26, 219)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(55, 24)
        Me.BrandTextBox.TabIndex = 184
        '
        'ModelTextBox
        '
        Me.ModelTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(-26, 246)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(55, 24)
        Me.ModelTextBox.TabIndex = 185
        '
        'SerialNoTextBox
        '
        Me.SerialNoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "SerialNo", True))
        Me.SerialNoTextBox.Location = New System.Drawing.Point(-26, 273)
        Me.SerialNoTextBox.Name = "SerialNoTextBox"
        Me.SerialNoTextBox.Size = New System.Drawing.Size(55, 24)
        Me.SerialNoTextBox.TabIndex = 186
        '
        'ItemNewUsedTextBox
        '
        Me.ItemNewUsedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemNewUsedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "ItemNewUsed", True))
        Me.ItemNewUsedTextBox.Location = New System.Drawing.Point(-26, 300)
        Me.ItemNewUsedTextBox.Name = "ItemNewUsedTextBox"
        Me.ItemNewUsedTextBox.Size = New System.Drawing.Size(55, 24)
        Me.ItemNewUsedTextBox.TabIndex = 187
        '
        'GuaranteeStatusTextBox
        '
        Me.GuaranteeStatusTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuaranteeStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "GuaranteeStatus", True))
        Me.GuaranteeStatusTextBox.Location = New System.Drawing.Point(-26, 327)
        Me.GuaranteeStatusTextBox.Name = "GuaranteeStatusTextBox"
        Me.GuaranteeStatusTextBox.Size = New System.Drawing.Size(55, 24)
        Me.GuaranteeStatusTextBox.TabIndex = 188
        '
        'ReceiveDateDateTimePicker
        '
        Me.ReceiveDateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReceiveDateDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.ReceiveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AuctionInvoiceDetailsBindingSource, "ReceiveDate", True))
        Me.ReceiveDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiveDateDateTimePicker.Location = New System.Drawing.Point(-26, 381)
        Me.ReceiveDateDateTimePicker.Name = "ReceiveDateDateTimePicker"
        Me.ReceiveDateDateTimePicker.Size = New System.Drawing.Size(55, 24)
        Me.ReceiveDateDateTimePicker.TabIndex = 190
        '
        'DetailsTextBox
        '
        Me.DetailsTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Details", True))
        Me.DetailsTextBox.Location = New System.Drawing.Point(-96, 404)
        Me.DetailsTextBox.Name = "DetailsTextBox"
        Me.DetailsTextBox.Size = New System.Drawing.Size(55, 24)
        Me.DetailsTextBox.TabIndex = 191
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "TotalPrice", True))
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(-96, 107)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(55, 24)
        Me.TotalPriceTextBox.TabIndex = 192
        '
        'K_netTextBox
        '
        Me.K_netTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.K_netTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "K_net", True))
        Me.K_netTextBox.Location = New System.Drawing.Point(-96, 134)
        Me.K_netTextBox.Name = "K_netTextBox"
        Me.K_netTextBox.Size = New System.Drawing.Size(55, 24)
        Me.K_netTextBox.TabIndex = 193
        '
        'CacherTextBox
        '
        Me.CacherTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CacherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "cacher", True))
        Me.CacherTextBox.Location = New System.Drawing.Point(-96, 161)
        Me.CacherTextBox.Name = "CacherTextBox"
        Me.CacherTextBox.Size = New System.Drawing.Size(55, 24)
        Me.CacherTextBox.TabIndex = 194
        '
        'SellDateDateTimePicker
        '
        Me.SellDateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SellDateDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.SellDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AuctionInvoiceDetailsBindingSource, "SellDate", True))
        Me.SellDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SellDateDateTimePicker.Location = New System.Drawing.Point(-96, 188)
        Me.SellDateDateTimePicker.Name = "SellDateDateTimePicker"
        Me.SellDateDateTimePicker.Size = New System.Drawing.Size(55, 24)
        Me.SellDateDateTimePicker.TabIndex = 195
        '
        'Invoic_date_timeTextBox
        '
        Me.Invoic_date_timeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoic_date_timeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "invoic_date_time", True))
        Me.Invoic_date_timeTextBox.Location = New System.Drawing.Point(-96, 215)
        Me.Invoic_date_timeTextBox.Name = "Invoic_date_timeTextBox"
        Me.Invoic_date_timeTextBox.Size = New System.Drawing.Size(55, 24)
        Me.Invoic_date_timeTextBox.TabIndex = 196
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(-96, 242)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(55, 24)
        Me.QuantityTextBox.TabIndex = 198
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(-96, 269)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(55, 24)
        Me.NotesTextBox.TabIndex = 199
        '
        'Sroom_nameTextBox
        '
        Me.Sroom_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sroom_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "sroom_name", True))
        Me.Sroom_nameTextBox.Location = New System.Drawing.Point(-96, 296)
        Me.Sroom_nameTextBox.Name = "Sroom_nameTextBox"
        Me.Sroom_nameTextBox.Size = New System.Drawing.Size(55, 24)
        Me.Sroom_nameTextBox.TabIndex = 200
        '
        'Invoic_NoTextBox
        '
        Me.Invoic_NoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoic_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Invoic_No", True))
        Me.Invoic_NoTextBox.Location = New System.Drawing.Point(-96, 323)
        Me.Invoic_NoTextBox.Name = "Invoic_NoTextBox"
        Me.Invoic_NoTextBox.Size = New System.Drawing.Size(55, 24)
        Me.Invoic_NoTextBox.TabIndex = 201
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.DocumentMapWidth = 53
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AuctionInvoiceDetailsVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptAuctionSellPay.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-157, 410)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(55, 28)
        Me.ReportViewer1.TabIndex = 210
        '
        'CashTextBox
        '
        Me.CashTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CashTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Cash", True))
        Me.CashTextBox.Location = New System.Drawing.Point(-96, 350)
        Me.CashTextBox.Name = "CashTextBox"
        Me.CashTextBox.Size = New System.Drawing.Size(55, 24)
        Me.CashTextBox.TabIndex = 211
        '
        'AuctionInvoiceDetailsVwTableAdapter
        '
        Me.AuctionInvoiceDetailsVwTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(-96, 377)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(55, 24)
        Me.IDTextBox.TabIndex = 212
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.ChequeTextBox)
        Me.pnl.Controls.Add(Me.GuaranteeDateTextBox)
        Me.pnl.Controls.Add(Me.GuaranteeDatetxtDB)
        Me.pnl.Controls.Add(Me.TotalPriceTextBoxAr)
        Me.pnl.Controls.Add(Me.LinkTextBox)
        Me.pnl.Controls.Add(Me.lblInvoiceTitle)
        Me.pnl.Controls.Add(Me.lblInvoiceValue)
        Me.pnl.Controls.Add(Me.AuctionInvoiceDetailsDataGridView)
        Me.pnl.Controls.Add(Me.IDTextBox)
        Me.pnl.Controls.Add(Me.txtAuction_TypeDB)
        Me.pnl.Controls.Add(Me.CashTextBox)
        Me.pnl.Controls.Add(Me.txtBrand_NameDB)
        Me.pnl.Controls.Add(Me.ReportViewer1)
        Me.pnl.Controls.Add(Me.txtModelDB)
        Me.pnl.Controls.Add(Me.Invoic_NoTextBox)
        Me.pnl.Controls.Add(Me.txtSerialNoDB)
        Me.pnl.Controls.Add(Me.Sroom_nameTextBox)
        Me.pnl.Controls.Add(Me.txtItemStatusDB)
        Me.pnl.Controls.Add(Me.NotesTextBox)
        Me.pnl.Controls.Add(Me.txtGuaranteeStatusDB)
        Me.pnl.Controls.Add(Me.QuantityTextBox)
        Me.pnl.Controls.Add(Me.Invoic_date_timeTextBox)
        Me.pnl.Controls.Add(Me.dtReceiveDateDB)
        Me.pnl.Controls.Add(Me.SellDateDateTimePicker)
        Me.pnl.Controls.Add(Me.txtItemDetailsDB)
        Me.pnl.Controls.Add(Me.CacherTextBox)
        Me.pnl.Controls.Add(Me.pbItemPhotoDB)
        Me.pnl.Controls.Add(Me.K_netTextBox)
        Me.pnl.Controls.Add(Me.PriceTextBoxDB)
        Me.pnl.Controls.Add(Me.TotalPriceTextBox)
        Me.pnl.Controls.Add(Me.CastomeridTextBox)
        Me.pnl.Controls.Add(Me.DetailsTextBox)
        Me.pnl.Controls.Add(Me.Auction_IDTextBox)
        Me.pnl.Controls.Add(Me.ReceiveDateDateTimePicker)
        Me.pnl.Controls.Add(Me.UserIDTextBox)
        Me.pnl.Controls.Add(Me.NameTextBox)
        Me.pnl.Controls.Add(Me.GuaranteeStatusTextBox)
        Me.pnl.Controls.Add(Me.BrandTextBox)
        Me.pnl.Controls.Add(Me.ItemNewUsedTextBox)
        Me.pnl.Controls.Add(Me.ModelTextBox)
        Me.pnl.Controls.Add(Me.SerialNoTextBox)
        Me.pnl.Location = New System.Drawing.Point(1479, 51)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(32, 70)
        Me.pnl.TabIndex = 213
        '
        'ChequeTextBox
        '
        Me.ChequeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChequeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Cheque", True))
        Me.ChequeTextBox.Location = New System.Drawing.Point(-157, 436)
        Me.ChequeTextBox.Name = "ChequeTextBox"
        Me.ChequeTextBox.Size = New System.Drawing.Size(55, 24)
        Me.ChequeTextBox.TabIndex = 217
        '
        'GuaranteeDateTextBox
        '
        Me.GuaranteeDateTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuaranteeDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "GuaranteeDate", True))
        Me.GuaranteeDateTextBox.Location = New System.Drawing.Point(-26, 354)
        Me.GuaranteeDateTextBox.Name = "GuaranteeDateTextBox"
        Me.GuaranteeDateTextBox.Size = New System.Drawing.Size(55, 24)
        Me.GuaranteeDateTextBox.TabIndex = 216
        '
        'GuaranteeDatetxtDB
        '
        Me.GuaranteeDatetxtDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GuaranteeDatetxtDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Auction_AddItemDetailsBindingSource, "GuaranteeDate", True))
        Me.GuaranteeDatetxtDB.Location = New System.Drawing.Point(-157, 245)
        Me.GuaranteeDatetxtDB.Name = "GuaranteeDatetxtDB"
        Me.GuaranteeDatetxtDB.Size = New System.Drawing.Size(55, 24)
        Me.GuaranteeDatetxtDB.TabIndex = 215
        '
        'TotalPriceTextBoxAr
        '
        Me.TotalPriceTextBoxAr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalPriceTextBoxAr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "TotalPriceAr", True))
        Me.TotalPriceTextBoxAr.Location = New System.Drawing.Point(-96, 83)
        Me.TotalPriceTextBoxAr.Name = "TotalPriceTextBoxAr"
        Me.TotalPriceTextBoxAr.Size = New System.Drawing.Size(55, 24)
        Me.TotalPriceTextBoxAr.TabIndex = 214
        '
        'LinkTextBox
        '
        Me.LinkTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionInvoiceDetailsBindingSource, "Link", True))
        Me.LinkTextBox.Location = New System.Drawing.Point(-26, 406)
        Me.LinkTextBox.Name = "LinkTextBox"
        Me.LinkTextBox.Size = New System.Drawing.Size(55, 24)
        Me.LinkTextBox.TabIndex = 213
        '
        'AuctionInvoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 556)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.gbInvoice)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AuctionInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيع مقتنيات ثمينة-مزادات"
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInvoice.ResumeLayout(False)
        Me.gbInvoice.PerformLayout()
        CType(Me.pbItemPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CastomerDETELSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Auction_AddItemDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbItemPhotoDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionInvoiceDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionInvoiceDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents gbInvoice As System.Windows.Forms.GroupBox
    Friend WithEvents lblInvoiceValue As System.Windows.Forms.Label
    Friend WithEvents btnPayPrint As System.Windows.Forms.Button
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNationality As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceTitle As System.Windows.Forms.Label
    Friend WithEvents lblCID As System.Windows.Forms.Label


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
    Friend WithEvents pbItemPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblItemPicture As System.Windows.Forms.Label
    Friend WithEvents dtReceiveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDetails As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblItemStatus As System.Windows.Forms.Label
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents txtItemDetails As System.Windows.Forms.TextBox
    Friend WithEvents lblGuaranteeStatus As System.Windows.Forms.Label
    Friend WithEvents lblReceiveDate As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents lblGuaranteeDate As System.Windows.Forms.Label
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents CastomerDETELSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CastomerDETELSTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.CastomerDETELSTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Auction_AddItemDetailsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_AddItemDetailsTableAdapter
    Friend WithEvents Auction_AddItemDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CacherTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.cacherTableAdapter
    Friend WithEvents CacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtAuction_TypeDB As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand_NameDB As System.Windows.Forms.TextBox
    Friend WithEvents txtModelDB As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialNoDB As System.Windows.Forms.TextBox
    Friend WithEvents txtItemStatusDB As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeStatusDB As System.Windows.Forms.TextBox
    Friend WithEvents dtReceiveDateDB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtItemDetailsDB As System.Windows.Forms.TextBox
    Friend WithEvents pbItemPhotoDB As System.Windows.Forms.PictureBox
    Friend WithEvents PriceTextBoxDB As System.Windows.Forms.TextBox
    Friend WithEvents AuctionInvoiceDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuctionInvoiceDetailsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsTableAdapter
    Friend WithEvents AuctionInvoiceDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomeridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Auction_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerialNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemNewUsedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuaranteeStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceiveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents K_netTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CacherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SellDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Invoic_date_timeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sroom_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Invoic_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtAuction_Type As System.Windows.Forms.TextBox
    Friend WithEvents txtBrand_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtItemStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeStatus As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblKNET As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents CashTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuctionInvoiceDetailsVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuctionInvoiceDetailsVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents lblLink As System.Windows.Forms.Label
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents LinkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalPriceTextBoxAr As System.Windows.Forms.TextBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtSellDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSellDate As System.Windows.Forms.Label
    Friend WithEvents GuaranteeDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GuaranteeDatetxtDB As System.Windows.Forms.TextBox
    Friend WithEvents dtGuaranteeDate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents ChequeTextBox As System.Windows.Forms.TextBox
End Class


