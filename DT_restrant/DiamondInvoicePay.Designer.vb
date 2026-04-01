<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiamondInvoicePay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiamondInvoicePay))
        Me.For_print_dimon_finelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.gbInvoicePay = New System.Windows.Forms.GroupBox()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.rbtnCash = New System.Windows.Forms.RadioButton()
        Me.rbtnInstallment = New System.Windows.Forms.RadioButton()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.gbInvoiceData = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblRemianing = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.LinkLabel()
        Me.pnlSavePrint = New System.Windows.Forms.Panel()
        Me.ChkWholeSale = New System.Windows.Forms.CheckBox()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.chkAutoClose = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SET_INVARCHR144TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR165TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR141TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR146TextBox = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.For_print_dimon_finelTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.for_print_dimon_finelTableAdapter()
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.For_print_dimon_finelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInvoicePay.SuspendLayout()
        Me.gbInvoiceData.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlSavePrint.SuspendLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'For_print_dimon_finelBindingSource
        '
        Me.For_print_dimon_finelBindingSource.DataMember = "for_print_dimon_finel"
        Me.For_print_dimon_finelBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbInvoicePay
        '
        Me.gbInvoicePay.BackColor = System.Drawing.Color.LightYellow
        Me.gbInvoicePay.Controls.Add(Me.lblPayMethod)
        Me.gbInvoicePay.Controls.Add(Me.cmbPayMethod)
        Me.gbInvoicePay.Controls.Add(Me.lblCash)
        Me.gbInvoicePay.Controls.Add(Me.lblBank)
        Me.gbInvoicePay.Controls.Add(Me.rbtnCash)
        Me.gbInvoicePay.Controls.Add(Me.rbtnInstallment)
        Me.gbInvoicePay.Controls.Add(Me.txtCash)
        Me.gbInvoicePay.Controls.Add(Me.txtKnet)
        Me.gbInvoicePay.Location = New System.Drawing.Point(4, 80)
        Me.gbInvoicePay.Name = "gbInvoicePay"
        Me.gbInvoicePay.Size = New System.Drawing.Size(636, 99)
        Me.gbInvoicePay.TabIndex = 99
        Me.gbInvoicePay.TabStop = False
        Me.gbInvoicePay.Text = "بيانات الدفع"
        '
        'lblPayMethod
        '
        Me.lblPayMethod.Location = New System.Drawing.Point(547, 71)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(82, 22)
        Me.lblPayMethod.TabIndex = 97
        Me.lblPayMethod.Text = "الطريقة"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(215, 69)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(329, 27)
        Me.cmbPayMethod.TabIndex = 96
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(172, 9)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(85, 22)
        Me.lblCash.TabIndex = 95
        Me.lblCash.Text = "كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCash.Visible = False
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(550, 40)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(79, 22)
        Me.lblBank.TabIndex = 94
        Me.lblBank.Text = "بنكي"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtnCash
        '
        Me.rbtnCash.AutoSize = True
        Me.rbtnCash.Checked = True
        Me.rbtnCash.Location = New System.Drawing.Point(117, 41)
        Me.rbtnCash.Name = "rbtnCash"
        Me.rbtnCash.Size = New System.Drawing.Size(49, 23)
        Me.rbtnCash.TabIndex = 84
        Me.rbtnCash.TabStop = True
        Me.rbtnCash.Text = "نقدا"
        Me.rbtnCash.UseVisualStyleBackColor = True
        '
        'rbtnInstallment
        '
        Me.rbtnInstallment.AutoSize = True
        Me.rbtnInstallment.Location = New System.Drawing.Point(35, 41)
        Me.rbtnInstallment.Name = "rbtnInstallment"
        Me.rbtnInstallment.Size = New System.Drawing.Size(51, 23)
        Me.rbtnInstallment.TabIndex = 83
        Me.rbtnInstallment.Text = "آجل"
        Me.rbtnInstallment.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCash.ForeColor = System.Drawing.Color.Red
        Me.txtCash.Location = New System.Drawing.Point(127, 4)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(39, 27)
        Me.txtCash.TabIndex = 17
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Visible = False
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtKnet.ForeColor = System.Drawing.Color.Red
        Me.txtKnet.Location = New System.Drawing.Point(215, 40)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(329, 27)
        Me.txtKnet.TabIndex = 16
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbInvoiceData
        '
        Me.gbInvoiceData.BackColor = System.Drawing.Color.LightYellow
        Me.gbInvoiceData.Controls.Add(Me.Panel4)
        Me.gbInvoiceData.Controls.Add(Me.Panel3)
        Me.gbInvoiceData.Controls.Add(Me.Panel2)
        Me.gbInvoiceData.Location = New System.Drawing.Point(4, 3)
        Me.gbInvoiceData.Name = "gbInvoiceData"
        Me.gbInvoiceData.Size = New System.Drawing.Size(636, 75)
        Me.gbInvoiceData.TabIndex = 98
        Me.gbInvoiceData.TabStop = False
        Me.gbInvoiceData.Text = "بيان الفاتورة"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblRemianing)
        Me.Panel4.Controls.Add(Me.txtRemaining)
        Me.Panel4.Location = New System.Drawing.Point(7, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(203, 50)
        Me.Panel4.TabIndex = 95
        '
        'lblRemianing
        '
        Me.lblRemianing.Location = New System.Drawing.Point(3, 2)
        Me.lblRemianing.Name = "lblRemianing"
        Me.lblRemianing.Size = New System.Drawing.Size(197, 22)
        Me.lblRemianing.TabIndex = 93
        Me.lblRemianing.Text = "المتبقي"
        Me.lblRemianing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.ForeColor = System.Drawing.Color.Maroon
        Me.txtRemaining.LinkColor = System.Drawing.Color.Red
        Me.txtRemaining.Location = New System.Drawing.Point(3, 24)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(197, 24)
        Me.txtRemaining.TabIndex = 92
        Me.txtRemaining.TabStop = True
        Me.txtRemaining.Text = "000"
        Me.txtRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblInvNo)
        Me.Panel3.Controls.Add(Me.txtInvoiceNo)
        Me.Panel3.Location = New System.Drawing.Point(426, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(203, 50)
        Me.Panel3.TabIndex = 94
        '
        'lblInvNo
        '
        Me.lblInvNo.Location = New System.Drawing.Point(3, 2)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(197, 22)
        Me.lblInvNo.TabIndex = 91
        Me.lblInvNo.Text = "رقم الفاتورة"
        Me.lblInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Maroon
        Me.txtInvoiceNo.LinkColor = System.Drawing.Color.Red
        Me.txtInvoiceNo.Location = New System.Drawing.Point(3, 24)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(197, 24)
        Me.txtInvoiceNo.TabIndex = 90
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Location = New System.Drawing.Point(217, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(203, 50)
        Me.Panel2.TabIndex = 93
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(3, 2)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(197, 22)
        Me.lblPrice.TabIndex = 92
        Me.lblPrice.Text = "المبلغ"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.ForeColor = System.Drawing.Color.Maroon
        Me.txtPrice.LinkColor = System.Drawing.Color.Red
        Me.txtPrice.Location = New System.Drawing.Point(3, 24)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(197, 24)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TabStop = True
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSavePrint
        '
        Me.pnlSavePrint.BackColor = System.Drawing.Color.LightYellow
        Me.pnlSavePrint.Controls.Add(Me.ChkWholeSale)
        Me.pnlSavePrint.Controls.Add(Me.chkEngInvoice)
        Me.pnlSavePrint.Controls.Add(Me.chkAutoClose)
        Me.pnlSavePrint.Controls.Add(Me.btnPrint)
        Me.pnlSavePrint.Controls.Add(Me.btnSave)
        Me.pnlSavePrint.Location = New System.Drawing.Point(645, 3)
        Me.pnlSavePrint.Name = "pnlSavePrint"
        Me.pnlSavePrint.Size = New System.Drawing.Size(145, 176)
        Me.pnlSavePrint.TabIndex = 97
        '
        'ChkWholeSale
        '
        Me.ChkWholeSale.AutoSize = True
        Me.ChkWholeSale.Location = New System.Drawing.Point(21, 147)
        Me.ChkWholeSale.Name = "ChkWholeSale"
        Me.ChkWholeSale.Size = New System.Drawing.Size(93, 23)
        Me.ChkWholeSale.TabIndex = 99
        Me.ChkWholeSale.Text = "فاتورة جملة"
        Me.ChkWholeSale.UseVisualStyleBackColor = True
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.AutoSize = True
        Me.chkEngInvoice.Location = New System.Drawing.Point(21, 124)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(106, 23)
        Me.chkEngInvoice.TabIndex = 98
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'chkAutoClose
        '
        Me.chkAutoClose.AutoSize = True
        Me.chkAutoClose.Location = New System.Drawing.Point(21, 101)
        Me.chkAutoClose.Name = "chkAutoClose"
        Me.chkAutoClose.Size = New System.Drawing.Size(93, 23)
        Me.chkAutoClose.TabIndex = 95
        Me.chkAutoClose.Text = "إغلاق تلقائي"
        Me.chkAutoClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(9, 52)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(126, 45)
        Me.btnPrint.TabIndex = 93
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(9, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 45)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR148", True))
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-57, 83)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(39, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 181
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.SET_INVARCHR144TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR165TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR141TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR146TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Location = New System.Drawing.Point(844, 48)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(62, 66)
        Me.pnl.TabIndex = 182
        '
        'SET_INVARCHR144TextBox
        '
        Me.SET_INVARCHR144TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR144TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR144", True))
        Me.SET_INVARCHR144TextBox.Location = New System.Drawing.Point(-57, 164)
        Me.SET_INVARCHR144TextBox.Name = "SET_INVARCHR144TextBox"
        Me.SET_INVARCHR144TextBox.Size = New System.Drawing.Size(39, 27)
        Me.SET_INVARCHR144TextBox.TabIndex = 189
        '
        'SET_INVARCHR165TextBox
        '
        Me.SET_INVARCHR165TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR165TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR165", True))
        Me.SET_INVARCHR165TextBox.Location = New System.Drawing.Point(-57, 110)
        Me.SET_INVARCHR165TextBox.Name = "SET_INVARCHR165TextBox"
        Me.SET_INVARCHR165TextBox.Size = New System.Drawing.Size(39, 27)
        Me.SET_INVARCHR165TextBox.TabIndex = 188
        '
        'SET_INVARCHR141TextBox
        '
        Me.SET_INVARCHR141TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR141TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR141", True))
        Me.SET_INVARCHR141TextBox.Location = New System.Drawing.Point(-57, 137)
        Me.SET_INVARCHR141TextBox.Name = "SET_INVARCHR141TextBox"
        Me.SET_INVARCHR141TextBox.Size = New System.Drawing.Size(39, 27)
        Me.SET_INVARCHR141TextBox.TabIndex = 187
        '
        'SET_INVARCHR146TextBox
        '
        Me.SET_INVARCHR146TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR146TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR146", True))
        Me.SET_INVARCHR146TextBox.Location = New System.Drawing.Point(-57, 56)
        Me.SET_INVARCHR146TextBox.Name = "SET_INVARCHR146TextBox"
        Me.SET_INVARCHR146TextBox.Size = New System.Drawing.Size(39, 27)
        Me.SET_INVARCHR146TextBox.TabIndex = 185
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(8, 577)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 183
        Me.btnPDF.UseVisualStyleBackColor = False
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
        'For_print_dimon_finelTableAdapter
        '
        Me.For_print_dimon_finelTableAdapter.ClearBeforeFill = True
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 182)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 438)
        Me.ReportViewer1.TabIndex = 183
        '
        'DiamondInvoicePay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(794, 621)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.gbInvoicePay)
        Me.Controls.Add(Me.gbInvoiceData)
        Me.Controls.Add(Me.pnlSavePrint)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiamondInvoicePay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الدفع"
        CType(Me.For_print_dimon_finelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInvoicePay.ResumeLayout(False)
        Me.gbInvoicePay.PerformLayout()
        Me.gbInvoiceData.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.pnlSavePrint.ResumeLayout(False)
        Me.pnlSavePrint.PerformLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents gbInvoicePay As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnInstallment As System.Windows.Forms.RadioButton
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents gbInvoiceData As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemaining As System.Windows.Forms.LinkLabel
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPrice As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlSavePrint As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents For_print_dimon_finelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents For_print_dimon_finelTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.for_print_dimon_finelTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRemianing As System.Windows.Forms.Label
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR148TextBox As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents chkAutoClose As System.Windows.Forms.CheckBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents SET_INVARCHR146TextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents SET_INVARCHR141TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR165TextBox As TextBox
    Friend WithEvents SET_INVARCHR144TextBox As TextBox
    Friend WithEvents ChkWholeSale As CheckBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
