<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesBuyPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessoriesBuyPay))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Accessories_Buy_PayVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.LinkLabel()
        Me.txtInvoiceNo = New System.Windows.Forms.LinkLabel()
        Me.txtPrice = New System.Windows.Forms.LinkLabel()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbPostPone = New System.Windows.Forms.RadioButton()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKNET = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Accessories_Buy_PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.Accessories_Buy_PayTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_Buy_PayTableAdapter()
        Me.Accessories_Buy_PayVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_Buy_PayVwTableAdapter()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SET_INVARCHR139TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR153TextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_ITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accessories_CostTextBox = New System.Windows.Forms.TextBox()
        Me.AccessoriesIDTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_nomTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_USER_CRETTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_model_noTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_DATE_CREDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Accessories_TIMEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Accessories_DEPTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CATTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Accessories_BRANDTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CasherTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_PaymentTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_staytesTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_balanceTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_Arabic_taybTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CASHTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_KNETTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_TOTAL_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_InvoiceNoTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_Pay_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_Buy_PayDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Accessories_ITEMTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ITEMTableAdapter()
        CType(Me.Accessories_Buy_PayVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Accessories_Buy_PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.Accessories_ITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accessories_Buy_PayDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accessories_Buy_PayVwBindingSource
        '
        Me.Accessories_Buy_PayVwBindingSource.DataMember = "Accessories_Buy_PayVw"
        Me.Accessories_Buy_PayVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRemaining)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 75)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيان الفاتورة"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 22)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "متبقي"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(219, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 25)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "المبلغ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(430, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 25)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "رقم الفاتورة"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtRemaining.Location = New System.Drawing.Point(7, 45)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(200, 22)
        Me.txtRemaining.TabIndex = 92
        Me.txtRemaining.TabStop = True
        Me.txtRemaining.Text = "000"
        Me.txtRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtInvoiceNo.Location = New System.Drawing.Point(429, 45)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(200, 22)
        Me.txtInvoiceNo.TabIndex = 90
        Me.txtInvoiceNo.TabStop = True
        Me.txtInvoiceNo.Text = "000"
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtPrice.Location = New System.Drawing.Point(218, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TabStop = True
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(110, 33)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(49, 23)
        Me.rbCash.TabIndex = 84
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "نقدا"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbPostPone
        '
        Me.rbPostPone.AutoSize = True
        Me.rbPostPone.Location = New System.Drawing.Point(30, 33)
        Me.rbPostPone.Name = "rbPostPone"
        Me.rbPostPone.Size = New System.Drawing.Size(51, 23)
        Me.rbPostPone.TabIndex = 83
        Me.rbPostPone.TabStop = True
        Me.rbPostPone.Text = "آجل"
        Me.rbPostPone.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCash.Location = New System.Drawing.Point(216, 43)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(107, 27)
        Me.txtCash.TabIndex = 17
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Visible = False
        '
        'txtKNET
        '
        Me.txtKNET.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtKNET.Location = New System.Drawing.Point(423, 16)
        Me.txtKNET.Name = "txtKNET"
        Me.txtKNET.Size = New System.Drawing.Size(158, 27)
        Me.txtKNET.TabIndex = 16
        Me.txtKNET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmbPayMethod)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.rbCash)
        Me.GroupBox2.Controls.Add(Me.rbPostPone)
        Me.GroupBox2.Controls.Add(Me.txtCash)
        Me.GroupBox2.Controls.Add(Me.txtKNET)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 81)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات الدفع"
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(423, 43)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(158, 27)
        Me.cmbPayMethod.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(216, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 22)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "كاش"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(645, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 158)
        Me.Panel1.TabIndex = 98
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(9, 59)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 51)
        Me.btnPrint.TabIndex = 93
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(9, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 52)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Accessories_Buy_PayVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptAccessories_BuyPay_A4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 165)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPrintButton = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(785, 450)
        Me.ReportViewer1.TabIndex = 97
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Accessories_Buy_PayBindingSource
        '
        Me.Accessories_Buy_PayBindingSource.DataMember = "Accessories_Buy_Pay"
        Me.Accessories_Buy_PayBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR148", True))
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-164, 247)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(58, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 149
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
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
        Me.TableAdapterManager.Connection = Nothing
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
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'Accessories_Buy_PayTableAdapter
        '
        Me.Accessories_Buy_PayTableAdapter.ClearBeforeFill = True
        '
        'Accessories_Buy_PayVwTableAdapter
        '
        Me.Accessories_Buy_PayVwTableAdapter.ClearBeforeFill = True
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.SET_INVARCHR139TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR153TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.Accessories_PriceTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CostTextBox)
        Me.pnl.Controls.Add(Me.AccessoriesIDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_nomTextBox)
        Me.pnl.Controls.Add(Me.Accessories_USER_CRETTextBox)
        Me.pnl.Controls.Add(Me.Accessories_model_noTextBox)
        Me.pnl.Controls.Add(Me.Accessories_DATE_CREDateTimePicker)
        Me.pnl.Controls.Add(Me.Accessories_TIMEDateTimePicker)
        Me.pnl.Controls.Add(Me.Accessories_DEPTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CATTextBox)
        Me.pnl.Controls.Add(Me.Accessories_DESCTextBox)
        Me.pnl.Controls.Add(Me.txtUserName)
        Me.pnl.Controls.Add(Me.Accessories_BRANDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_NAMETextBox)
        Me.pnl.Controls.Add(Me.Accessories_CasherTextBox)
        Me.pnl.Controls.Add(Me.Accessories_PaymentTypeTextBox)
        Me.pnl.Controls.Add(Me.Accessories_staytesTextBox)
        Me.pnl.Controls.Add(Me.Accessories_balanceTextBox)
        Me.pnl.Controls.Add(Me.Accessories_Arabic_taybTextBox)
        Me.pnl.Controls.Add(Me.Accessories_CASHTextBox)
        Me.pnl.Controls.Add(Me.Accessories_KNETTextBox)
        Me.pnl.Controls.Add(Me.Accessories_TOTAL_PriceTextBox)
        Me.pnl.Controls.Add(Me.Accessories_InvoiceNoTextBox)
        Me.pnl.Controls.Add(Me.Accessories_Pay_IDTextBox)
        Me.pnl.Controls.Add(Me.Accessories_Buy_PayDataGridView)
        Me.pnl.Location = New System.Drawing.Point(1236, 34)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(58, 54)
        Me.pnl.TabIndex = 150
        '
        'SET_INVARCHR139TextBox
        '
        Me.SET_INVARCHR139TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR139TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR139", True))
        Me.SET_INVARCHR139TextBox.Location = New System.Drawing.Point(-228, 220)
        Me.SET_INVARCHR139TextBox.Name = "SET_INVARCHR139TextBox"
        Me.SET_INVARCHR139TextBox.Size = New System.Drawing.Size(58, 27)
        Me.SET_INVARCHR139TextBox.TabIndex = 150
        '
        'SET_INVARCHR153TextBox
        '
        Me.SET_INVARCHR153TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR153TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR153", True))
        Me.SET_INVARCHR153TextBox.Location = New System.Drawing.Point(-164, 220)
        Me.SET_INVARCHR153TextBox.Name = "SET_INVARCHR153TextBox"
        Me.SET_INVARCHR153TextBox.Size = New System.Drawing.Size(58, 27)
        Me.SET_INVARCHR153TextBox.TabIndex = 60
        '
        'Accessories_PriceTextBox
        '
        Me.Accessories_PriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Price", True))
        Me.Accessories_PriceTextBox.Location = New System.Drawing.Point(-228, 166)
        Me.Accessories_PriceTextBox.Name = "Accessories_PriceTextBox"
        Me.Accessories_PriceTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_PriceTextBox.TabIndex = 59
        '
        'Accessories_ITEMBindingSource
        '
        Me.Accessories_ITEMBindingSource.DataMember = "Accessories_ITEM"
        Me.Accessories_ITEMBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Accessories_CostTextBox
        '
        Me.Accessories_CostTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_Cost", True))
        Me.Accessories_CostTextBox.Location = New System.Drawing.Point(-228, 193)
        Me.Accessories_CostTextBox.Name = "Accessories_CostTextBox"
        Me.Accessories_CostTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_CostTextBox.TabIndex = 58
        '
        'AccessoriesIDTextBox
        '
        Me.AccessoriesIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccessoriesIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "AccessoriesID", True))
        Me.AccessoriesIDTextBox.Location = New System.Drawing.Point(-164, 31)
        Me.AccessoriesIDTextBox.Name = "AccessoriesIDTextBox"
        Me.AccessoriesIDTextBox.Size = New System.Drawing.Size(58, 27)
        Me.AccessoriesIDTextBox.TabIndex = 46
        '
        'Accessories_nomTextBox
        '
        Me.Accessories_nomTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_nomTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_nom", True))
        Me.Accessories_nomTextBox.Location = New System.Drawing.Point(-228, 139)
        Me.Accessories_nomTextBox.Name = "Accessories_nomTextBox"
        Me.Accessories_nomTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_nomTextBox.TabIndex = 57
        '
        'Accessories_USER_CRETTextBox
        '
        Me.Accessories_USER_CRETTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_USER_CRETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_USER_CRET", True))
        Me.Accessories_USER_CRETTextBox.Location = New System.Drawing.Point(-228, 85)
        Me.Accessories_USER_CRETTextBox.Name = "Accessories_USER_CRETTextBox"
        Me.Accessories_USER_CRETTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_USER_CRETTextBox.TabIndex = 54
        '
        'Accessories_model_noTextBox
        '
        Me.Accessories_model_noTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_model_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_model_no", True))
        Me.Accessories_model_noTextBox.Location = New System.Drawing.Point(-164, 193)
        Me.Accessories_model_noTextBox.Name = "Accessories_model_noTextBox"
        Me.Accessories_model_noTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_model_noTextBox.TabIndex = 56
        '
        'Accessories_DATE_CREDateTimePicker
        '
        Me.Accessories_DATE_CREDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DATE_CREDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.Accessories_DATE_CREDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_ITEMBindingSource, "Accessories_DATE_CRE", True))
        Me.Accessories_DATE_CREDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Accessories_DATE_CREDateTimePicker.Location = New System.Drawing.Point(-228, 58)
        Me.Accessories_DATE_CREDateTimePicker.Name = "Accessories_DATE_CREDateTimePicker"
        Me.Accessories_DATE_CREDateTimePicker.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_DATE_CREDateTimePicker.TabIndex = 53
        '
        'Accessories_TIMEDateTimePicker
        '
        Me.Accessories_TIMEDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_TIMEDateTimePicker.CustomFormat = "hh:MM:ss tt"
        Me.Accessories_TIMEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_ITEMBindingSource, "Accessories_TIME", True))
        Me.Accessories_TIMEDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Accessories_TIMEDateTimePicker.Location = New System.Drawing.Point(-228, 31)
        Me.Accessories_TIMEDateTimePicker.Name = "Accessories_TIMEDateTimePicker"
        Me.Accessories_TIMEDateTimePicker.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_TIMEDateTimePicker.TabIndex = 52
        '
        'Accessories_DEPTextBox
        '
        Me.Accessories_DEPTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_DEP", True))
        Me.Accessories_DEPTextBox.Location = New System.Drawing.Point(-164, 166)
        Me.Accessories_DEPTextBox.Name = "Accessories_DEPTextBox"
        Me.Accessories_DEPTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_DEPTextBox.TabIndex = 51
        '
        'Accessories_CATTextBox
        '
        Me.Accessories_CATTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_CAT", True))
        Me.Accessories_CATTextBox.Location = New System.Drawing.Point(-164, 139)
        Me.Accessories_CATTextBox.Name = "Accessories_CATTextBox"
        Me.Accessories_CATTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_CATTextBox.TabIndex = 50
        '
        'Accessories_DESCTextBox
        '
        Me.Accessories_DESCTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_DESC", True))
        Me.Accessories_DESCTextBox.Location = New System.Drawing.Point(-164, 112)
        Me.Accessories_DESCTextBox.Name = "Accessories_DESCTextBox"
        Me.Accessories_DESCTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_DESCTextBox.TabIndex = 49
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Location = New System.Drawing.Point(-228, 112)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(58, 27)
        Me.txtUserName.TabIndex = 55
        '
        'Accessories_BRANDTextBox
        '
        Me.Accessories_BRANDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_BRANDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_BRAND", True))
        Me.Accessories_BRANDTextBox.Location = New System.Drawing.Point(-164, 85)
        Me.Accessories_BRANDTextBox.Name = "Accessories_BRANDTextBox"
        Me.Accessories_BRANDTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_BRANDTextBox.TabIndex = 48
        '
        'Accessories_NAMETextBox
        '
        Me.Accessories_NAMETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_ITEMBindingSource, "Accessories_NAME", True))
        Me.Accessories_NAMETextBox.Location = New System.Drawing.Point(-164, 58)
        Me.Accessories_NAMETextBox.Name = "Accessories_NAMETextBox"
        Me.Accessories_NAMETextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_NAMETextBox.TabIndex = 47
        '
        'Accessories_CasherTextBox
        '
        Me.Accessories_CasherTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CasherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_Casher", True))
        Me.Accessories_CasherTextBox.Location = New System.Drawing.Point(-100, 301)
        Me.Accessories_CasherTextBox.Name = "Accessories_CasherTextBox"
        Me.Accessories_CasherTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_CasherTextBox.TabIndex = 14
        '
        'Accessories_PaymentTypeTextBox
        '
        Me.Accessories_PaymentTypeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_PaymentTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_PaymentType", True))
        Me.Accessories_PaymentTypeTextBox.Location = New System.Drawing.Point(-100, 274)
        Me.Accessories_PaymentTypeTextBox.Name = "Accessories_PaymentTypeTextBox"
        Me.Accessories_PaymentTypeTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_PaymentTypeTextBox.TabIndex = 13
        '
        'Accessories_staytesTextBox
        '
        Me.Accessories_staytesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_staytesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_staytes", True))
        Me.Accessories_staytesTextBox.Location = New System.Drawing.Point(-100, 247)
        Me.Accessories_staytesTextBox.Name = "Accessories_staytesTextBox"
        Me.Accessories_staytesTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_staytesTextBox.TabIndex = 12
        '
        'Accessories_balanceTextBox
        '
        Me.Accessories_balanceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_balanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_balance", True))
        Me.Accessories_balanceTextBox.Location = New System.Drawing.Point(-100, 220)
        Me.Accessories_balanceTextBox.Name = "Accessories_balanceTextBox"
        Me.Accessories_balanceTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_balanceTextBox.TabIndex = 11
        '
        'Accessories_Arabic_taybTextBox
        '
        Me.Accessories_Arabic_taybTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_Arabic_taybTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_Arabic_tayb", True))
        Me.Accessories_Arabic_taybTextBox.Location = New System.Drawing.Point(-100, 193)
        Me.Accessories_Arabic_taybTextBox.Name = "Accessories_Arabic_taybTextBox"
        Me.Accessories_Arabic_taybTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_Arabic_taybTextBox.TabIndex = 10
        '
        'Accessories_CASHTextBox
        '
        Me.Accessories_CASHTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_CASHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_CASH", True))
        Me.Accessories_CASHTextBox.Location = New System.Drawing.Point(-100, 166)
        Me.Accessories_CASHTextBox.Name = "Accessories_CASHTextBox"
        Me.Accessories_CASHTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_CASHTextBox.TabIndex = 9
        '
        'Accessories_KNETTextBox
        '
        Me.Accessories_KNETTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_KNETTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_KNET", True))
        Me.Accessories_KNETTextBox.Location = New System.Drawing.Point(-100, 139)
        Me.Accessories_KNETTextBox.Name = "Accessories_KNETTextBox"
        Me.Accessories_KNETTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_KNETTextBox.TabIndex = 7
        '
        'Accessories_TOTAL_PriceTextBox
        '
        Me.Accessories_TOTAL_PriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_TOTAL_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_TOTAL_Price", True))
        Me.Accessories_TOTAL_PriceTextBox.Location = New System.Drawing.Point(-100, 112)
        Me.Accessories_TOTAL_PriceTextBox.Name = "Accessories_TOTAL_PriceTextBox"
        Me.Accessories_TOTAL_PriceTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_TOTAL_PriceTextBox.TabIndex = 5
        '
        'Accessories_InvoiceNoTextBox
        '
        Me.Accessories_InvoiceNoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_InvoiceNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_InvoiceNo", True))
        Me.Accessories_InvoiceNoTextBox.Location = New System.Drawing.Point(-100, 85)
        Me.Accessories_InvoiceNoTextBox.Name = "Accessories_InvoiceNoTextBox"
        Me.Accessories_InvoiceNoTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_InvoiceNoTextBox.TabIndex = 3
        '
        'Accessories_Pay_IDTextBox
        '
        Me.Accessories_Pay_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_Pay_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayBindingSource, "Accessories_Pay_ID", True))
        Me.Accessories_Pay_IDTextBox.Location = New System.Drawing.Point(-100, 58)
        Me.Accessories_Pay_IDTextBox.Name = "Accessories_Pay_IDTextBox"
        Me.Accessories_Pay_IDTextBox.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_Pay_IDTextBox.TabIndex = 2
        '
        'Accessories_Buy_PayDataGridView
        '
        Me.Accessories_Buy_PayDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_Buy_PayDataGridView.AutoGenerateColumns = False
        Me.Accessories_Buy_PayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accessories_Buy_PayDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Accessories_Buy_PayDataGridView.DataSource = Me.Accessories_Buy_PayBindingSource
        Me.Accessories_Buy_PayDataGridView.Location = New System.Drawing.Point(-100, 31)
        Me.Accessories_Buy_PayDataGridView.Name = "Accessories_Buy_PayDataGridView"
        Me.Accessories_Buy_PayDataGridView.RowHeadersVisible = False
        Me.Accessories_Buy_PayDataGridView.Size = New System.Drawing.Size(58, 27)
        Me.Accessories_Buy_PayDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Accessories_Pay_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Accessories_Pay_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Accessories_InvoiceNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Accessories_InvoiceNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Accessories_TOTAL_Price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Accessories_TOTAL_Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Accessories_KNET"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Accessories_KNET"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Accessories_CASH"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Accessories_CASH"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Accessories_Arabic_tayb"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Accessories_Arabic_tayb"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Accessories_balance"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Accessories_balance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Accessories_staytes"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Accessories_staytes"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Accessories_PaymentType"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Accessories_PaymentType"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Accessories_Casher"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Accessories_Casher"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Accessories_ITEMTableAdapter
        '
        Me.Accessories_ITEMTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesBuyPay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(794, 621)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccessoriesBuyPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيان فاتورة شراء"
        CType(Me.Accessories_Buy_PayVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Accessories_Buy_PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.Accessories_ITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accessories_Buy_PayDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemaining As System.Windows.Forms.LinkLabel
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPrice As System.Windows.Forms.LinkLabel
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbPostPone As System.Windows.Forms.RadioButton
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKNET As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Accessories_Buy_PayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR148TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_Buy_PayTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_Buy_PayTableAdapter
    Friend WithEvents Accessories_Buy_PayVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_Buy_PayVwTableAdapter
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Accessories_Buy_PayDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents Accessories_CasherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_PaymentTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_staytesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_balanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_Arabic_taybTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CASHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_KNETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_TOTAL_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_InvoiceNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_Pay_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_Buy_PayVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_ITEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_ITEMTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ITEMTableAdapter
    Friend WithEvents Accessories_PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessoriesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_nomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_USER_CRETTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_model_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_DATE_CREDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Accessories_TIMEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Accessories_DEPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_CATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_BRANDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR153TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR139TextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbPayMethod As ComboBox
End Class
