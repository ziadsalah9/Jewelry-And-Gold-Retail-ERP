<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiamondSellEditRemove
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiamondSellEditRemove))
        Me.lblKnet = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblPriceRequired = New System.Windows.Forms.Label()
        Me.lblPriceReturn = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.coldim_inv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldimo_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcastomr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldescont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colar_taype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIMO_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIM_na9awa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIMO_mezan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIMO_coler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIMO_qult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsarual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colval_gold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGOLD_mezan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluser_creted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate_creted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldim_foto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_111 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_112 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_116 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_117 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_118 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_119 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colnotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItem_Actv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colstaytes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoldItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCut1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClarity1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCut2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClarity2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCut3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClarity3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsDiamond1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsDiamond2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsDiamond3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dimon_invceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.dimon_bayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Diamond_sum_total_priceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPriceReturn = New System.Windows.Forms.TextBox()
        Me.txtPriceRequired = New System.Windows.Forms.TextBox()
        Me.gbInvoiceData = New System.Windows.Forms.GroupBox()
        Me.rbtnCash = New System.Windows.Forms.RadioButton()
        Me.rbtnInstallment = New System.Windows.Forms.RadioButton()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.for_dimon_invBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Dimon_bayTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.dimon_bayTableAdapter()
        Me.Dimon_invceTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.dimon_invceTableAdapter()
        Me.For_dimon_invTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.for_dimon_invTableAdapter()
        Me.Diamond_sum_total_priceTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Diamond_sum_total_priceTableAdapter()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimon_invceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimon_bayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diamond_sum_total_priceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInvoiceData.SuspendLayout()
        CType(Me.for_dimon_invBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKnet
        '
        Me.lblKnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKnet.ForeColor = System.Drawing.Color.Blue
        Me.lblKnet.Location = New System.Drawing.Point(280, 104)
        Me.lblKnet.Name = "lblKnet"
        Me.lblKnet.Size = New System.Drawing.Size(204, 27)
        Me.lblKnet.TabIndex = 14
        Me.lblKnet.Text = "المدفوع بنكي"
        Me.lblKnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCash.ForeColor = System.Drawing.Color.Blue
        Me.lblCash.Location = New System.Drawing.Point(280, 77)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(204, 27)
        Me.lblCash.TabIndex = 16
        Me.lblCash.Text = "المدفوع كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPriceRequired
        '
        Me.lblPriceRequired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceRequired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPriceRequired.Location = New System.Drawing.Point(280, 50)
        Me.lblPriceRequired.Name = "lblPriceRequired"
        Me.lblPriceRequired.Size = New System.Drawing.Size(204, 27)
        Me.lblPriceRequired.TabIndex = 24
        Me.lblPriceRequired.Text = "مبلغ الفاتورة"
        Me.lblPriceRequired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPriceReturn
        '
        Me.lblPriceReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPriceReturn.Location = New System.Drawing.Point(280, 23)
        Me.lblPriceReturn.Name = "lblPriceReturn"
        Me.lblPriceReturn.Size = New System.Drawing.Size(204, 27)
        Me.lblPriceReturn.TabIndex = 26
        Me.lblPriceReturn.Text = "ارجع للعميل"
        Me.lblPriceReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid.BackgroundColor = System.Drawing.Color.Linen
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.coldim_inv_id, Me.coldimo_id, Me.colcastomr_id, Me.coldescont, Me.colar_taype, Me.colDIMO_Type, Me.colDIM_na9awa, Me.colDIMO_mezan, Me.colDIMO_coler, Me.colDIMO_qult, Me.coltotal, Me.colsarual, Me.colval_gold, Me.colGOLD_mezan, Me.coluser_creted, Me.coldate_creted, Me.coltime, Me.coldim_foto, Me.coltest_13, Me.coltest_14, Me.coltest_15, Me.coltest_16, Me.coltest_17, Me.coltest_18, Me.coltest_19, Me.coltest_110, Me.coltest_111, Me.coltest_112, Me.coltest_116, Me.coltest_117, Me.coltest_118, Me.coltest_119, Me.colnotes, Me.colItem_Actv, Me.colstaytes, Me.colGramPrice, Me.colSoldItem, Me.colCut1, Me.colClarity1, Me.colCut2, Me.colClarity2, Me.colCut3, Me.colClarity3, Me.colIsDiamond1, Me.colIsDiamond2, Me.colIsDiamond3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.GridColor = System.Drawing.SystemColors.Info
        Me.grid.Location = New System.Drawing.Point(2, 320)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid.RowHeadersWidth = 5
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(960, 150)
        Me.grid.TabIndex = 6
        '
        'colDelete
        '
        Me.colDelete.FillWeight = 40.0!
        Me.colDelete.HeaderText = "حذف"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Width = 47
        '
        'coldim_inv_id
        '
        Me.coldim_inv_id.HeaderText = "ID"
        Me.coldim_inv_id.Name = "coldim_inv_id"
        Me.coldim_inv_id.Visible = False
        Me.coldim_inv_id.Width = 48
        '
        'coldimo_id
        '
        Me.coldimo_id.HeaderText = "DiamondID"
        Me.coldimo_id.Name = "coldimo_id"
        Me.coldimo_id.Visible = False
        Me.coldimo_id.Width = 110
        '
        'colcastomr_id
        '
        Me.colcastomr_id.HeaderText = "CID"
        Me.colcastomr_id.Name = "colcastomr_id"
        Me.colcastomr_id.Visible = False
        Me.colcastomr_id.Width = 56
        '
        'coldescont
        '
        Me.coldescont.HeaderText = "InvoiceNo"
        Me.coldescont.Name = "coldescont"
        Me.coldescont.Visible = False
        Me.coldescont.Width = 103
        '
        'colar_taype
        '
        Me.colar_taype.HeaderText = "ar_taype"
        Me.colar_taype.Name = "colar_taype"
        Me.colar_taype.Visible = False
        Me.colar_taype.Width = 95
        '
        'colDIMO_Type
        '
        Me.colDIMO_Type.HeaderText = "الصنف"
        Me.colDIMO_Type.Name = "colDIMO_Type"
        Me.colDIMO_Type.Width = 74
        '
        'colDIM_na9awa
        '
        Me.colDIM_na9awa.HeaderText = "النقاوة"
        Me.colDIM_na9awa.Name = "colDIM_na9awa"
        Me.colDIM_na9awa.Width = 69
        '
        'colDIMO_mezan
        '
        Me.colDIMO_mezan.HeaderText = "وزن الألماس"
        Me.colDIMO_mezan.Name = "colDIMO_mezan"
        '
        'colDIMO_coler
        '
        Me.colDIMO_coler.HeaderText = "لون الألماس"
        Me.colDIMO_coler.Name = "colDIMO_coler"
        '
        'colDIMO_qult
        '
        Me.colDIMO_qult.HeaderText = "العدد"
        Me.colDIMO_qult.Name = "colDIMO_qult"
        Me.colDIMO_qult.Width = 63
        '
        'coltotal
        '
        Me.coltotal.HeaderText = "السعر"
        Me.coltotal.Name = "coltotal"
        Me.coltotal.Width = 67
        '
        'colsarual
        '
        Me.colsarual.HeaderText = "رقم القطعة"
        Me.colsarual.Name = "colsarual"
        Me.colsarual.Width = 97
        '
        'colval_gold
        '
        Me.colval_gold.HeaderText = "العيار"
        Me.colval_gold.Name = "colval_gold"
        Me.colval_gold.Width = 64
        '
        'colGOLD_mezan
        '
        Me.colGOLD_mezan.HeaderText = "وزن الذهب"
        Me.colGOLD_mezan.Name = "colGOLD_mezan"
        Me.colGOLD_mezan.Width = 96
        '
        'coluser_creted
        '
        Me.coluser_creted.HeaderText = "User"
        Me.coluser_creted.Name = "coluser_creted"
        Me.coluser_creted.Visible = False
        Me.coluser_creted.Width = 64
        '
        'coldate_creted
        '
        Me.coldate_creted.HeaderText = "Date"
        Me.coldate_creted.Name = "coldate_creted"
        Me.coldate_creted.Visible = False
        Me.coldate_creted.Width = 66
        '
        'coltime
        '
        Me.coltime.HeaderText = "DateTime"
        Me.coltime.Name = "coltime"
        Me.coltime.Visible = False
        Me.coltime.Width = 99
        '
        'coldim_foto
        '
        Me.coldim_foto.HeaderText = "Photo"
        Me.coldim_foto.Name = "coldim_foto"
        Me.coldim_foto.Visible = False
        Me.coldim_foto.Width = 76
        '
        'coltest_13
        '
        Me.coltest_13.HeaderText = "وزن الحجر1"
        Me.coltest_13.Name = "coltest_13"
        Me.coltest_13.Width = 103
        '
        'coltest_14
        '
        Me.coltest_14.HeaderText = "نوع الحجر1"
        Me.coltest_14.Name = "coltest_14"
        Me.coltest_14.Width = 101
        '
        'coltest_15
        '
        Me.coltest_15.HeaderText = "لون الحجر1"
        Me.coltest_15.Name = "coltest_15"
        Me.coltest_15.Width = 103
        '
        'coltest_16
        '
        Me.coltest_16.HeaderText = "وزن الحجر2"
        Me.coltest_16.Name = "coltest_16"
        Me.coltest_16.Width = 103
        '
        'coltest_17
        '
        Me.coltest_17.HeaderText = "نوع الحجر2"
        Me.coltest_17.Name = "coltest_17"
        Me.coltest_17.Width = 101
        '
        'coltest_18
        '
        Me.coltest_18.HeaderText = "لون الحجر2"
        Me.coltest_18.Name = "coltest_18"
        Me.coltest_18.Width = 103
        '
        'coltest_19
        '
        Me.coltest_19.HeaderText = "وزن الحجر3"
        Me.coltest_19.Name = "coltest_19"
        Me.coltest_19.Width = 103
        '
        'coltest_110
        '
        Me.coltest_110.HeaderText = "نوع الحجر3"
        Me.coltest_110.Name = "coltest_110"
        Me.coltest_110.Width = 101
        '
        'coltest_111
        '
        Me.coltest_111.HeaderText = "لون الحجر3"
        Me.coltest_111.Name = "coltest_111"
        Me.coltest_111.Width = 103
        '
        'coltest_112
        '
        Me.coltest_112.HeaderText = "test_112"
        Me.coltest_112.Name = "coltest_112"
        Me.coltest_112.Visible = False
        Me.coltest_112.Width = 92
        '
        'coltest_116
        '
        Me.coltest_116.HeaderText = "الوزن الكلي"
        Me.coltest_116.Name = "coltest_116"
        Me.coltest_116.Width = 91
        '
        'coltest_117
        '
        Me.coltest_117.HeaderText = "قصة الألماس"
        Me.coltest_117.Name = "coltest_117"
        Me.coltest_117.Width = 107
        '
        'coltest_118
        '
        Me.coltest_118.HeaderText = "CashierCID"
        Me.coltest_118.Name = "coltest_118"
        Me.coltest_118.Visible = False
        Me.coltest_118.Width = 105
        '
        'coltest_119
        '
        Me.coltest_119.HeaderText = "الباركود"
        Me.coltest_119.Name = "coltest_119"
        Me.coltest_119.Width = 75
        '
        'colnotes
        '
        Me.colnotes.HeaderText = "ملاحظات"
        Me.colnotes.Name = "colnotes"
        Me.colnotes.Width = 87
        '
        'colItem_Actv
        '
        Me.colItem_Actv.HeaderText = "Item_Actv"
        Me.colItem_Actv.Name = "colItem_Actv"
        Me.colItem_Actv.Visible = False
        Me.colItem_Actv.Width = 104
        '
        'colstaytes
        '
        Me.colstaytes.HeaderText = "staytes"
        Me.colstaytes.Name = "colstaytes"
        Me.colstaytes.Visible = False
        Me.colstaytes.Width = 82
        '
        'colGramPrice
        '
        Me.colGramPrice.HeaderText = "سعر الجرام"
        Me.colGramPrice.Name = "colGramPrice"
        Me.colGramPrice.Width = 97
        '
        'colSoldItem
        '
        Me.colSoldItem.HeaderText = "القطع المباعة"
        Me.colSoldItem.Name = "colSoldItem"
        Me.colSoldItem.Width = 109
        '
        'colCut1
        '
        Me.colCut1.HeaderText = "قصة الحجر1"
        Me.colCut1.Name = "colCut1"
        Me.colCut1.Width = 110
        '
        'colClarity1
        '
        Me.colClarity1.HeaderText = "نقاوة الحجر1"
        Me.colClarity1.Name = "colClarity1"
        Me.colClarity1.Width = 110
        '
        'colCut2
        '
        Me.colCut2.HeaderText = "قصة الحجر2"
        Me.colCut2.Name = "colCut2"
        Me.colCut2.Width = 110
        '
        'colClarity2
        '
        Me.colClarity2.HeaderText = "نقاوة الحجر2"
        Me.colClarity2.Name = "colClarity2"
        Me.colClarity2.Width = 110
        '
        'colCut3
        '
        Me.colCut3.HeaderText = "قصة الحجر3"
        Me.colCut3.Name = "colCut3"
        Me.colCut3.Width = 110
        '
        'colClarity3
        '
        Me.colClarity3.HeaderText = "نقاوة الحجر3"
        Me.colClarity3.Name = "colClarity3"
        Me.colClarity3.Width = 110
        '
        'colIsDiamond1
        '
        Me.colIsDiamond1.HeaderText = "IsDiamond1"
        Me.colIsDiamond1.Name = "colIsDiamond1"
        Me.colIsDiamond1.Visible = False
        Me.colIsDiamond1.Width = 114
        '
        'colIsDiamond2
        '
        Me.colIsDiamond2.HeaderText = "IsDiamond2"
        Me.colIsDiamond2.Name = "colIsDiamond2"
        Me.colIsDiamond2.Visible = False
        Me.colIsDiamond2.Width = 114
        '
        'colIsDiamond3
        '
        Me.colIsDiamond3.HeaderText = "IsDiamond3"
        Me.colIsDiamond3.Name = "colIsDiamond3"
        Me.colIsDiamond3.Visible = False
        Me.colIsDiamond3.Width = 114
        '
        'dimon_invceBindingSource
        '
        Me.dimon_invceBindingSource.DataMember = "dimon_invce"
        Me.dimon_invceBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.Location = New System.Drawing.Point(778, 29)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(184, 27)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dimon_bayBindingSource
        '
        Me.dimon_bayBindingSource.DataMember = "dimon_bay"
        Me.dimon_bayBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.Color.White
        Me.txtKnet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dimon_bayBindingSource, "KENT", True))
        Me.txtKnet.ForeColor = System.Drawing.Color.Blue
        Me.txtKnet.Location = New System.Drawing.Point(33, 104)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKnet.Size = New System.Drawing.Size(241, 27)
        Me.txtKnet.TabIndex = 5
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dimon_bayBindingSource, "CACH", True))
        Me.txtCash.ForeColor = System.Drawing.Color.Blue
        Me.txtCash.Location = New System.Drawing.Point(33, 77)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCash.Size = New System.Drawing.Size(241, 27)
        Me.txtCash.TabIndex = 4
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Diamond_sum_total_priceBindingSource
        '
        Me.Diamond_sum_total_priceBindingSource.DataMember = "Diamond_sum_total_price"
        Me.Diamond_sum_total_priceBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'txtPriceReturn
        '
        Me.txtPriceReturn.BackColor = System.Drawing.SystemColors.Info
        Me.txtPriceReturn.Enabled = False
        Me.txtPriceReturn.ForeColor = System.Drawing.Color.Red
        Me.txtPriceReturn.Location = New System.Drawing.Point(33, 23)
        Me.txtPriceReturn.Name = "txtPriceReturn"
        Me.txtPriceReturn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPriceReturn.Size = New System.Drawing.Size(241, 27)
        Me.txtPriceReturn.TabIndex = 2
        Me.txtPriceReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPriceRequired
        '
        Me.txtPriceRequired.BackColor = System.Drawing.SystemColors.Info
        Me.txtPriceRequired.Location = New System.Drawing.Point(33, 50)
        Me.txtPriceRequired.Name = "txtPriceRequired"
        Me.txtPriceRequired.ReadOnly = True
        Me.txtPriceRequired.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPriceRequired.Size = New System.Drawing.Size(241, 27)
        Me.txtPriceRequired.TabIndex = 3
        Me.txtPriceRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbInvoiceData
        '
        Me.gbInvoiceData.BackColor = System.Drawing.Color.Gainsboro
        Me.gbInvoiceData.Controls.Add(Me.rbtnCash)
        Me.gbInvoiceData.Controls.Add(Me.rbtnInstallment)
        Me.gbInvoiceData.Controls.Add(Me.cmbCashier)
        Me.gbInvoiceData.Controls.Add(Me.lblCashier)
        Me.gbInvoiceData.Controls.Add(Me.dtpInvoiceDate)
        Me.gbInvoiceData.Controls.Add(Me.lblDate)
        Me.gbInvoiceData.Controls.Add(Me.cmbPayMethod)
        Me.gbInvoiceData.Controls.Add(Me.lblPayMethod)
        Me.gbInvoiceData.Controls.Add(Me.lblCash)
        Me.gbInvoiceData.Controls.Add(Me.txtCash)
        Me.gbInvoiceData.Controls.Add(Me.txtKnet)
        Me.gbInvoiceData.Controls.Add(Me.lblKnet)
        Me.gbInvoiceData.Controls.Add(Me.txtPriceReturn)
        Me.gbInvoiceData.Controls.Add(Me.lblPriceRequired)
        Me.gbInvoiceData.Controls.Add(Me.lblPriceReturn)
        Me.gbInvoiceData.Controls.Add(Me.txtPriceRequired)
        Me.gbInvoiceData.Location = New System.Drawing.Point(2, 473)
        Me.gbInvoiceData.Name = "gbInvoiceData"
        Me.gbInvoiceData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbInvoiceData.Size = New System.Drawing.Size(960, 185)
        Me.gbInvoiceData.TabIndex = 7
        Me.gbInvoiceData.TabStop = False
        Me.gbInvoiceData.Text = "تعديل فاتورة"
        '
        'rbtnCash
        '
        Me.rbtnCash.Checked = True
        Me.rbtnCash.Location = New System.Drawing.Point(633, 131)
        Me.rbtnCash.Name = "rbtnCash"
        Me.rbtnCash.Size = New System.Drawing.Size(96, 23)
        Me.rbtnCash.TabIndex = 165
        Me.rbtnCash.TabStop = True
        Me.rbtnCash.Text = "نقدا"
        Me.rbtnCash.UseVisualStyleBackColor = True
        '
        'rbtnInstallment
        '
        Me.rbtnInstallment.Location = New System.Drawing.Point(525, 131)
        Me.rbtnInstallment.Name = "rbtnInstallment"
        Me.rbtnInstallment.Size = New System.Drawing.Size(98, 23)
        Me.rbtnInstallment.TabIndex = 164
        Me.rbtnInstallment.Text = "آجل"
        Me.rbtnInstallment.UseVisualStyleBackColor = True
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(525, 50)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(204, 27)
        Me.cmbCashier.TabIndex = 1
        '
        'lblCashier
        '
        Me.lblCashier.Location = New System.Drawing.Point(732, 50)
        Me.lblCashier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(204, 27)
        Me.lblCashier.TabIndex = 163
        Me.lblCashier.Text = "الكاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(525, 23)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(204, 27)
        Me.dtpInvoiceDate.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(732, 23)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(204, 27)
        Me.lblDate.TabIndex = 162
        Me.lblDate.Text = "تاريخ الفاتورة"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(33, 131)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(241, 27)
        Me.cmbPayMethod.TabIndex = 6
        '
        'lblPayMethod
        '
        Me.lblPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayMethod.ForeColor = System.Drawing.Color.Blue
        Me.lblPayMethod.Location = New System.Drawing.Point(280, 131)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(204, 26)
        Me.lblPayMethod.TabIndex = 100
        Me.lblPayMethod.Text = "طريقة الدفع"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddItem.Image = Global.DT_restrant.My.Resources.Resources.BoxAdd
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Location = New System.Drawing.Point(488, 6)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(125, 50)
        Me.btnAddItem.TabIndex = 2
        Me.btnAddItem.Text = "إضافة صنف"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(166, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 50)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(327, 6)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(125, 50)
        Me.btnDeleteInvoice.TabIndex = 3
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'for_dimon_invBindingSource
        '
        Me.for_dimon_invBindingSource.DataMember = "for_dimon_inv"
        Me.for_dimon_invBindingSource.DataSource = Me.DT_restrantDataSet
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
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.dimon_bayTableAdapter = Me.Dimon_bayTableAdapter
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Me.Dimon_invceTableAdapter
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
        Me.TableAdapterManager.TPSellBuyWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.TpSetGoledPriceDiffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Dimon_bayTableAdapter
        '
        Me.Dimon_bayTableAdapter.ClearBeforeFill = True
        '
        'Dimon_invceTableAdapter
        '
        Me.Dimon_invceTableAdapter.ClearBeforeFill = True
        '
        'For_dimon_invTableAdapter
        '
        Me.For_dimon_invTableAdapter.ClearBeforeFill = True
        '
        'Diamond_sum_total_priceTableAdapter
        '
        Me.Diamond_sum_total_priceTableAdapter.ClearBeforeFill = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(5, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 50)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceNo.Location = New System.Drawing.Point(778, 6)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(184, 19)
        Me.lblInvoiceNo.TabIndex = 91
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(649, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(125, 50)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'DiamondSellEditRemove
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 661)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gbInvoiceData)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiamondSellEditRemove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تعديل"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimon_invceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimon_bayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diamond_sum_total_priceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInvoiceData.ResumeLayout(False)
        Me.gbInvoiceData.PerformLayout()
        CType(Me.for_dimon_invBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents dimon_invceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dimon_bayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Diamond_sum_total_priceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtPriceReturn As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceRequired As System.Windows.Forms.TextBox
    Friend WithEvents gbInvoiceData As System.Windows.Forms.GroupBox
    Friend WithEvents for_dimon_invBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblPriceRequired As System.Windows.Forms.Label
    Friend WithEvents lblPriceReturn As System.Windows.Forms.Label
    Friend WithEvents lblKnet As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents Dimon_invceTableAdapter As DT_restrantDataSetTableAdapters.dimon_invceTableAdapter
    Friend WithEvents Dimon_bayTableAdapter As DT_restrantDataSetTableAdapters.dimon_bayTableAdapter
    Friend WithEvents For_dimon_invTableAdapter As DT_restrantDataSetTableAdapters.for_dimon_invTableAdapter
    Friend WithEvents Diamond_sum_total_priceTableAdapter As DT_restrantDataSetTableAdapters.Diamond_sum_total_priceTableAdapter
    Friend WithEvents Test113DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Test114DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Test115DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CachDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KenetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents btnView As Button
    Friend WithEvents cmbPayMethod As ComboBox
    Friend WithEvents lblPayMethod As Label
    Friend WithEvents cmbCashier As ComboBox
    Friend WithEvents lblCashier As Label
    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents rbtnInstallment As RadioButton
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents coldim_inv_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldimo_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcastomr_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldescont As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colar_taype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIMO_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIM_na9awa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIMO_mezan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIMO_coler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIMO_qult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsarual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colval_gold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGOLD_mezan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coluser_creted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate_creted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldim_foto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_110 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_111 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_112 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_116 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_117 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_118 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_119 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colnotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItem_Actv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colstaytes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGramPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSoldItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCut1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClarity1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCut2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClarity2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCut3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClarity3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIsDiamond1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIsDiamond2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIsDiamond3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
