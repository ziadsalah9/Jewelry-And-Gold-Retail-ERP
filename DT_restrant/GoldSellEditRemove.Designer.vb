<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldSellEditRemove
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoldSellEditRemove))
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblInvoicePrice = New System.Windows.Forms.Label()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem_GramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem_gram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem_gramMade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneColor1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneWeight1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePrice1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneColor2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneWeight2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePrice2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneName3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneColor3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneWeight3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStonePrice3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colitem_totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelInvoceDetelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.BAYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BAY_IDTextBox = New System.Windows.Forms.TextBox()
        Me.BAY_SARYALTextBox = New System.Windows.Forms.TextBox()
        Me.TOTAL_monyTextBox = New System.Windows.Forms.TextBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Arbic_taybTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.StaytesTextBox = New System.Windows.Forms.TextBox()
        Me.Sum_total_priceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sum_total_priceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Sum_total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.txtPriceReturn = New System.Windows.Forms.TextBox()
        Me.txtPriceRequired = New System.Windows.Forms.TextBox()
        Me.gbSave = New System.Windows.Forms.GroupBox()
        Me.cmbPayMethod1 = New System.Windows.Forms.ComboBox()
        Me.txtBank1 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod4 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod3 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod2 = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod1 = New System.Windows.Forms.Label()
        Me.txtBank4 = New System.Windows.Forms.TextBox()
        Me.txtBank3 = New System.Windows.Forms.TextBox()
        Me.txtBank2 = New System.Windows.Forms.TextBox()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Invoce_reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Invoce_reportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PayMethodTextBox = New System.Windows.Forms.TextBox()
        Me.English_taybTextBox = New System.Windows.Forms.TextBox()
        Me.SelInvoceActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.BayActiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelInvoceDetelsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.selInvoceDetelsTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.BAYTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.BAYTableAdapter()
        Me.Sum_total_priceTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.sum_total_priceTableAdapter()
        Me.Invoce_reportTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.invoce_reportTableAdapter()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtnote = New System.Windows.Forms.TextBox()
        Me.GoledKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelInvoceDetelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sum_total_priceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sum_total_priceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSave.SuspendLayout()
        CType(Me.Invoce_reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBank
        '
        Me.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBank.ForeColor = System.Drawing.Color.Blue
        Me.lblBank.Location = New System.Drawing.Point(364, 41)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(215, 27)
        Me.lblBank.TabIndex = 14
        Me.lblBank.Text = "المدفوع بنكي"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCash.ForeColor = System.Drawing.Color.Blue
        Me.lblCash.Location = New System.Drawing.Point(364, 15)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(215, 26)
        Me.lblCash.TabIndex = 16
        Me.lblCash.Text = "المدفوع كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvoicePrice
        '
        Me.lblInvoicePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoicePrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInvoicePrice.Location = New System.Drawing.Point(364, 95)
        Me.lblInvoicePrice.Name = "lblInvoicePrice"
        Me.lblInvoicePrice.Size = New System.Drawing.Size(215, 27)
        Me.lblInvoicePrice.TabIndex = 24
        Me.lblInvoicePrice.Text = "مبلغ الفاتورة"
        Me.lblInvoicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturn
        '
        Me.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReturn.ForeColor = System.Drawing.Color.Red
        Me.lblReturn.Location = New System.Drawing.Point(364, 122)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(215, 27)
        Me.lblReturn.TabIndex = 26
        Me.lblReturn.Text = "ارجع للعميل"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoGenerateColumns = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid.BackgroundColor = System.Drawing.Color.MidnightBlue
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
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.colID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.colitem_name, Me.DataGridViewTextBoxColumn6, Me.colitem_GramPrice, Me.colitem_gram, Me.colitem_gramMade, Me.colStoneName1, Me.colStoneColor1, Me.colStoneWeight1, Me.colStonePrice1, Me.colStoneName2, Me.colStoneColor2, Me.colStoneWeight2, Me.colStonePrice2, Me.colStoneName3, Me.colStoneColor3, Me.colStoneWeight3, Me.colStonePrice3, Me.colitem_totalPrice, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.colInvoiceNo, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.colNotes, Me.GoledKarat})
        Me.grid.DataSource = Me.SelInvoceDetelsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.GridColor = System.Drawing.SystemColors.Info
        Me.grid.Location = New System.Drawing.Point(4, 320)
        Me.grid.Name = "grid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(961, 152)
        Me.grid.TabIndex = 0
        '
        'Delete
        '
        Me.Delete.FillWeight = 50.0!
        Me.Delete.HeaderText = "حذف"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 47
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 48
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Castomerid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Castomerid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'colitem_name
        '
        Me.colitem_name.DataPropertyName = "item_name"
        Me.colitem_name.HeaderText = "اسم الصنف"
        Me.colitem_name.Name = "colitem_name"
        Me.colitem_name.ReadOnly = True
        Me.colitem_name.Width = 101
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "item_desp"
        Me.DataGridViewTextBoxColumn6.HeaderText = "item_desp"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 105
        '
        'colitem_GramPrice
        '
        Me.colitem_GramPrice.DataPropertyName = "item_GramPrice"
        Me.colitem_GramPrice.HeaderText = "سعر الجرام"
        Me.colitem_GramPrice.Name = "colitem_GramPrice"
        Me.colitem_GramPrice.Width = 97
        '
        'colitem_gram
        '
        Me.colitem_gram.DataPropertyName = "item_gram"
        Me.colitem_gram.HeaderText = "وزن الذهب"
        Me.colitem_gram.Name = "colitem_gram"
        Me.colitem_gram.Width = 96
        '
        'colitem_gramMade
        '
        Me.colitem_gramMade.DataPropertyName = "item_gramMade"
        Me.colitem_gramMade.HeaderText = "مصنعية"
        Me.colitem_gramMade.Name = "colitem_gramMade"
        Me.colitem_gramMade.Width = 79
        '
        'colStoneName1
        '
        Me.colStoneName1.DataPropertyName = "StoneName1"
        Me.colStoneName1.HeaderText = "فص1"
        Me.colStoneName1.Name = "colStoneName1"
        Me.colStoneName1.Width = 65
        '
        'colStoneColor1
        '
        Me.colStoneColor1.DataPropertyName = "StoneColor1"
        Me.colStoneColor1.HeaderText = "لون فص1"
        Me.colStoneColor1.Name = "colStoneColor1"
        Me.colStoneColor1.Width = 89
        '
        'colStoneWeight1
        '
        Me.colStoneWeight1.DataPropertyName = "item_extrasMAZAN"
        Me.colStoneWeight1.HeaderText = "و.فص1"
        Me.colStoneWeight1.Name = "colStoneWeight1"
        Me.colStoneWeight1.Width = 75
        '
        'colStonePrice1
        '
        Me.colStonePrice1.DataPropertyName = "item_extrasPRICE"
        Me.colStonePrice1.HeaderText = "سعر فص1"
        Me.colStonePrice1.Name = "colStonePrice1"
        Me.colStonePrice1.Width = 94
        '
        'colStoneName2
        '
        Me.colStoneName2.DataPropertyName = "StoneName2"
        Me.colStoneName2.HeaderText = "فص2"
        Me.colStoneName2.Name = "colStoneName2"
        Me.colStoneName2.Width = 65
        '
        'colStoneColor2
        '
        Me.colStoneColor2.DataPropertyName = "StoneColor2"
        Me.colStoneColor2.HeaderText = "لون فص2"
        Me.colStoneColor2.Name = "colStoneColor2"
        Me.colStoneColor2.Width = 89
        '
        'colStoneWeight2
        '
        Me.colStoneWeight2.DataPropertyName = "StoneWeight2"
        Me.colStoneWeight2.HeaderText = "و.فص2"
        Me.colStoneWeight2.Name = "colStoneWeight2"
        Me.colStoneWeight2.Width = 75
        '
        'colStonePrice2
        '
        Me.colStonePrice2.DataPropertyName = "StonePrice2"
        Me.colStonePrice2.HeaderText = "سعر فص2"
        Me.colStonePrice2.Name = "colStonePrice2"
        Me.colStonePrice2.Width = 94
        '
        'colStoneName3
        '
        Me.colStoneName3.DataPropertyName = "StoneName3"
        Me.colStoneName3.HeaderText = "فص3"
        Me.colStoneName3.Name = "colStoneName3"
        Me.colStoneName3.Width = 65
        '
        'colStoneColor3
        '
        Me.colStoneColor3.DataPropertyName = "StoneColor3"
        Me.colStoneColor3.HeaderText = "لون فص3"
        Me.colStoneColor3.Name = "colStoneColor3"
        Me.colStoneColor3.Width = 89
        '
        'colStoneWeight3
        '
        Me.colStoneWeight3.DataPropertyName = "StoneWeight3"
        Me.colStoneWeight3.HeaderText = "و.فص3"
        Me.colStoneWeight3.Name = "colStoneWeight3"
        Me.colStoneWeight3.Width = 75
        '
        'colStonePrice3
        '
        Me.colStonePrice3.DataPropertyName = "StonePrice3"
        Me.colStonePrice3.HeaderText = "سعر فص3"
        Me.colStonePrice3.Name = "colStonePrice3"
        Me.colStonePrice3.Width = 94
        '
        'colitem_totalPrice
        '
        Me.colitem_totalPrice.DataPropertyName = "item_totalPrice"
        Me.colitem_totalPrice.HeaderText = "إجمالي المبلغ"
        Me.colitem_totalPrice.Name = "colitem_totalPrice"
        Me.colitem_totalPrice.Width = 104
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "item_cantrey"
        Me.DataGridViewTextBoxColumn13.HeaderText = "item_cantrey"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "cacher"
        Me.DataGridViewTextBoxColumn15.HeaderText = "cacher"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 79
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn16.HeaderText = "date"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "invoc_date_time"
        Me.DataGridViewTextBoxColumn17.HeaderText = "invoc_date_time"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 148
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.DataPropertyName = "invoc_time"
        Me.colInvoiceNo.HeaderText = "رقم الفاتورة"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.Visible = False
        Me.colInvoiceNo.Width = 98
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Cash"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Cash"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 65
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "qunt"
        Me.DataGridViewTextBoxColumn20.HeaderText = "qunt"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 67
        '
        'colNotes
        '
        Me.colNotes.DataPropertyName = "nots"
        Me.colNotes.HeaderText = "ملاحظات"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Visible = False
        Me.colNotes.Width = 87
        '
        'SelInvoceDetelsBindingSource
        '
        Me.SelInvoceDetelsBindingSource.DataMember = "selInvoceDetels"
        Me.SelInvoceDetelsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BAYDataGridView
        '
        Me.BAYDataGridView.AllowUserToAddRows = False
        Me.BAYDataGridView.AllowUserToDeleteRows = False
        Me.BAYDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAYDataGridView.AutoGenerateColumns = False
        Me.BAYDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.BAYDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BAYDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.BAYDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.BAYDataGridView.ColumnHeadersHeight = 26
        Me.BAYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BAYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.BAYDataGridView.DataSource = Me.BAYBindingSource
        Me.BAYDataGridView.GridColor = System.Drawing.Color.LightYellow
        Me.BAYDataGridView.Location = New System.Drawing.Point(-75, 3)
        Me.BAYDataGridView.MultiSelect = False
        Me.BAYDataGridView.Name = "BAYDataGridView"
        Me.BAYDataGridView.ReadOnly = True
        Me.BAYDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BAYDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BAYDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BAYDataGridView.RowHeadersWidth = 22
        Me.BAYDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BAYDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BAYDataGridView.Size = New System.Drawing.Size(45, 27)
        Me.BAYDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "BAY_ID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "BAY_ID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        Me.DataGridViewTextBoxColumn22.Width = 68
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "BAY_SARYAL"
        Me.DataGridViewTextBoxColumn23.HeaderText = "BAY_SARYAL"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "TOTAL_mony"
        Me.DataGridViewTextBoxColumn24.HeaderText = "اجمالي الفاتوره"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "KENT"
        Me.DataGridViewTextBoxColumn25.HeaderText = "المدفوع كي نت"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CACH"
        Me.DataGridViewTextBoxColumn26.HeaderText = "المدفوع كاش"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "arbic_tayb"
        Me.DataGridViewTextBoxColumn27.HeaderText = "المبلغ بالحروف"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn28.HeaderText = "باقي المبلغ"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "staytes"
        Me.DataGridViewTextBoxColumn29.HeaderText = "نوع العمليه"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'BAYBindingSource
        '
        Me.BAYBindingSource.DataMember = "BAY"
        Me.BAYBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'BAY_IDTextBox
        '
        Me.BAY_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAY_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "BAY_ID", True))
        Me.BAY_IDTextBox.Location = New System.Drawing.Point(-75, 30)
        Me.BAY_IDTextBox.Name = "BAY_IDTextBox"
        Me.BAY_IDTextBox.Size = New System.Drawing.Size(45, 27)
        Me.BAY_IDTextBox.TabIndex = 9
        '
        'BAY_SARYALTextBox
        '
        Me.BAY_SARYALTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAY_SARYALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "BAY_SARYAL", True))
        Me.BAY_SARYALTextBox.Location = New System.Drawing.Point(-75, 57)
        Me.BAY_SARYALTextBox.Name = "BAY_SARYALTextBox"
        Me.BAY_SARYALTextBox.Size = New System.Drawing.Size(45, 27)
        Me.BAY_SARYALTextBox.TabIndex = 11
        '
        'TOTAL_monyTextBox
        '
        Me.TOTAL_monyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TOTAL_monyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "TOTAL_mony", True))
        Me.TOTAL_monyTextBox.Location = New System.Drawing.Point(-75, 219)
        Me.TOTAL_monyTextBox.Name = "TOTAL_monyTextBox"
        Me.TOTAL_monyTextBox.Size = New System.Drawing.Size(45, 27)
        Me.TOTAL_monyTextBox.TabIndex = 13
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.SystemColors.Info
        Me.txtKnet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "KENT", True))
        Me.txtKnet.ForeColor = System.Drawing.Color.Blue
        Me.txtKnet.Location = New System.Drawing.Point(184, 42)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(180, 27)
        Me.txtKnet.TabIndex = 5
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.Info
        Me.txtCash.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "CACH", True))
        Me.txtCash.ForeColor = System.Drawing.Color.Blue
        Me.txtCash.Location = New System.Drawing.Point(184, 15)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(180, 27)
        Me.txtCash.TabIndex = 4
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Arbic_taybTextBox
        '
        Me.Arbic_taybTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Arbic_taybTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "arbic_tayb", True))
        Me.Arbic_taybTextBox.Location = New System.Drawing.Point(-75, 165)
        Me.Arbic_taybTextBox.Name = "Arbic_taybTextBox"
        Me.Arbic_taybTextBox.Size = New System.Drawing.Size(45, 27)
        Me.Arbic_taybTextBox.TabIndex = 19
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(-75, 84)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(45, 27)
        Me.BalanceTextBox.TabIndex = 21
        '
        'StaytesTextBox
        '
        Me.StaytesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaytesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "staytes", True))
        Me.StaytesTextBox.Location = New System.Drawing.Point(-75, 111)
        Me.StaytesTextBox.Name = "StaytesTextBox"
        Me.StaytesTextBox.Size = New System.Drawing.Size(45, 27)
        Me.StaytesTextBox.TabIndex = 23
        '
        'Sum_total_priceDataGridView
        '
        Me.Sum_total_priceDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_total_priceDataGridView.AutoGenerateColumns = False
        Me.Sum_total_priceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sum_total_priceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.Sum_total_priceDataGridView.DataSource = Me.Sum_total_priceBindingSource
        Me.Sum_total_priceDataGridView.Location = New System.Drawing.Point(-75, 329)
        Me.Sum_total_priceDataGridView.Name = "Sum_total_priceDataGridView"
        Me.Sum_total_priceDataGridView.Size = New System.Drawing.Size(45, 27)
        Me.Sum_total_priceDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn30.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "invoc_time"
        Me.DataGridViewTextBoxColumn31.HeaderText = "invoc_time"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'Sum_total_priceBindingSource
        '
        Me.Sum_total_priceBindingSource.DataMember = "sum_total_price"
        Me.Sum_total_priceBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Total_priceTextBox
        '
        Me.Total_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_priceTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.Total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sum_total_priceBindingSource, "total_price", True))
        Me.Total_priceTextBox.Enabled = False
        Me.Total_priceTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_priceTextBox.ForeColor = System.Drawing.Color.Green
        Me.Total_priceTextBox.Location = New System.Drawing.Point(-75, 300)
        Me.Total_priceTextBox.Name = "Total_priceTextBox"
        Me.Total_priceTextBox.Size = New System.Drawing.Size(45, 29)
        Me.Total_priceTextBox.TabIndex = 25
        '
        'Sum_total_priceTextBox
        '
        Me.Sum_total_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sum_total_priceBindingSource, "total_price", True))
        Me.Sum_total_priceTextBox.Location = New System.Drawing.Point(-75, 192)
        Me.Sum_total_priceTextBox.Name = "Sum_total_priceTextBox"
        Me.Sum_total_priceTextBox.Size = New System.Drawing.Size(45, 27)
        Me.Sum_total_priceTextBox.TabIndex = 27
        '
        'txtPriceReturn
        '
        Me.txtPriceReturn.BackColor = System.Drawing.SystemColors.Info
        Me.txtPriceReturn.Enabled = False
        Me.txtPriceReturn.ForeColor = System.Drawing.Color.Red
        Me.txtPriceReturn.Location = New System.Drawing.Point(184, 123)
        Me.txtPriceReturn.Name = "txtPriceReturn"
        Me.txtPriceReturn.Size = New System.Drawing.Size(180, 27)
        Me.txtPriceReturn.TabIndex = 28
        Me.txtPriceReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPriceRequired
        '
        Me.txtPriceRequired.BackColor = System.Drawing.SystemColors.Info
        Me.txtPriceRequired.Location = New System.Drawing.Point(184, 96)
        Me.txtPriceRequired.Name = "txtPriceRequired"
        Me.txtPriceRequired.Size = New System.Drawing.Size(180, 27)
        Me.txtPriceRequired.TabIndex = 3
        Me.txtPriceRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbSave
        '
        Me.gbSave.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gbSave.Controls.Add(Me.cmbPayMethod1)
        Me.gbSave.Controls.Add(Me.txtBank1)
        Me.gbSave.Controls.Add(Me.cmbPayMethod4)
        Me.gbSave.Controls.Add(Me.cmbPayMethod3)
        Me.gbSave.Controls.Add(Me.cmbPayMethod2)
        Me.gbSave.Controls.Add(Me.lblPayMethod1)
        Me.gbSave.Controls.Add(Me.txtBank4)
        Me.gbSave.Controls.Add(Me.txtBank3)
        Me.gbSave.Controls.Add(Me.txtBank2)
        Me.gbSave.Controls.Add(Me.cmbCashier)
        Me.gbSave.Controls.Add(Me.Label1)
        Me.gbSave.Controls.Add(Me.cmbPayMethod)
        Me.gbSave.Controls.Add(Me.lblPayMethod)
        Me.gbSave.Controls.Add(Me.lblCash)
        Me.gbSave.Controls.Add(Me.txtCash)
        Me.gbSave.Controls.Add(Me.txtKnet)
        Me.gbSave.Controls.Add(Me.lblBank)
        Me.gbSave.Controls.Add(Me.txtPriceReturn)
        Me.gbSave.Controls.Add(Me.lblInvoicePrice)
        Me.gbSave.Controls.Add(Me.lblReturn)
        Me.gbSave.Controls.Add(Me.txtPriceRequired)
        Me.gbSave.Location = New System.Drawing.Point(4, 478)
        Me.gbSave.Name = "gbSave"
        Me.gbSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbSave.Size = New System.Drawing.Size(961, 154)
        Me.gbSave.TabIndex = 3
        Me.gbSave.TabStop = False
        Me.gbSave.Text = "تعديل فاتورة"
        '
        'cmbPayMethod1
        '
        Me.cmbPayMethod1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod1.FormattingEnabled = True
        Me.cmbPayMethod1.Location = New System.Drawing.Point(875, 80)
        Me.cmbPayMethod1.Name = "cmbPayMethod1"
        Me.cmbPayMethod1.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod1.TabIndex = 120
        '
        'txtBank1
        '
        Me.txtBank1.BackColor = System.Drawing.Color.Orange
        Me.txtBank1.Location = New System.Drawing.Point(875, 53)
        Me.txtBank1.Name = "txtBank1"
        Me.txtBank1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBank1.Size = New System.Drawing.Size(78, 27)
        Me.txtBank1.TabIndex = 4
        Me.txtBank1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod4
        '
        Me.cmbPayMethod4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod4.FormattingEnabled = True
        Me.cmbPayMethod4.Location = New System.Drawing.Point(641, 80)
        Me.cmbPayMethod4.Name = "cmbPayMethod4"
        Me.cmbPayMethod4.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod4.TabIndex = 118
        '
        'cmbPayMethod3
        '
        Me.cmbPayMethod3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod3.FormattingEnabled = True
        Me.cmbPayMethod3.Location = New System.Drawing.Point(719, 80)
        Me.cmbPayMethod3.Name = "cmbPayMethod3"
        Me.cmbPayMethod3.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod3.TabIndex = 117
        '
        'cmbPayMethod2
        '
        Me.cmbPayMethod2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod2.FormattingEnabled = True
        Me.cmbPayMethod2.Location = New System.Drawing.Point(797, 80)
        Me.cmbPayMethod2.Name = "cmbPayMethod2"
        Me.cmbPayMethod2.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod2.TabIndex = 116
        '
        'lblPayMethod1
        '
        Me.lblPayMethod1.BackColor = System.Drawing.Color.Orange
        Me.lblPayMethod1.Location = New System.Drawing.Point(641, 21)
        Me.lblPayMethod1.Name = "lblPayMethod1"
        Me.lblPayMethod1.Size = New System.Drawing.Size(312, 31)
        Me.lblPayMethod1.TabIndex = 115
        Me.lblPayMethod1.Text = "عمليات اخري"
        Me.lblPayMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBank4
        '
        Me.txtBank4.BackColor = System.Drawing.Color.Orange
        Me.txtBank4.Location = New System.Drawing.Point(641, 53)
        Me.txtBank4.Name = "txtBank4"
        Me.txtBank4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBank4.Size = New System.Drawing.Size(78, 27)
        Me.txtBank4.TabIndex = 4
        Me.txtBank4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank3
        '
        Me.txtBank3.BackColor = System.Drawing.Color.Orange
        Me.txtBank3.Location = New System.Drawing.Point(719, 53)
        Me.txtBank3.Name = "txtBank3"
        Me.txtBank3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBank3.Size = New System.Drawing.Size(78, 27)
        Me.txtBank3.TabIndex = 4
        Me.txtBank3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank2
        '
        Me.txtBank2.BackColor = System.Drawing.Color.Orange
        Me.txtBank2.Location = New System.Drawing.Point(797, 53)
        Me.txtBank2.Name = "txtBank2"
        Me.txtBank2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBank2.Size = New System.Drawing.Size(78, 27)
        Me.txtBank2.TabIndex = 4
        Me.txtBank2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(5, 46)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(173, 27)
        Me.cmbCashier.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(5, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 26)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "الكاشير"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(184, 69)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(180, 27)
        Me.cmbPayMethod.TabIndex = 97
        '
        'lblPayMethod
        '
        Me.lblPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayMethod.ForeColor = System.Drawing.Color.Blue
        Me.lblPayMethod.Location = New System.Drawing.Point(364, 68)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(215, 27)
        Me.lblPayMethod.TabIndex = 29
        Me.lblPayMethod.Text = "طريقة الدفع"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddItem.Image = Global.DT_restrant.My.Resources.Resources.BoxAdd
        Me.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Location = New System.Drawing.Point(493, 5)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(135, 51)
        Me.btnAddItem.TabIndex = 98
        Me.btnAddItem.Text = "إضافة صنف"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(330, 5)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(135, 51)
        Me.btnDeleteInvoice.TabIndex = 2
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(167, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 51)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Invoce_reportBindingSource
        '
        Me.Invoce_reportBindingSource.DataMember = "invoce_report"
        Me.Invoce_reportBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Invoce_reportDataGridView
        '
        Me.Invoce_reportDataGridView.AllowUserToAddRows = False
        Me.Invoce_reportDataGridView.AllowUserToDeleteRows = False
        Me.Invoce_reportDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoce_reportDataGridView.AutoGenerateColumns = False
        Me.Invoce_reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Invoce_reportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57})
        Me.Invoce_reportDataGridView.DataSource = Me.Invoce_reportBindingSource
        Me.Invoce_reportDataGridView.Location = New System.Drawing.Point(-75, 138)
        Me.Invoce_reportDataGridView.Name = "Invoce_reportDataGridView"
        Me.Invoce_reportDataGridView.ReadOnly = True
        Me.Invoce_reportDataGridView.Size = New System.Drawing.Size(45, 27)
        Me.Invoce_reportDataGridView.TabIndex = 85
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn32.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Castomerid"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Castomerid"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "item_GramPrice"
        Me.DataGridViewTextBoxColumn35.HeaderText = "item_GramPrice"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "item_gram"
        Me.DataGridViewTextBoxColumn36.HeaderText = "item_gram"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "item_gramMade"
        Me.DataGridViewTextBoxColumn37.HeaderText = "item_gramMade"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "item_extrasPRICE"
        Me.DataGridViewTextBoxColumn38.HeaderText = "item_extrasPRICE"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "item_extrasMAZAN"
        Me.DataGridViewTextBoxColumn39.HeaderText = "item_extrasMAZAN"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "item_totalPrice"
        Me.DataGridViewTextBoxColumn40.HeaderText = "item_totalPrice"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "item_cantrey"
        Me.DataGridViewTextBoxColumn41.HeaderText = "item_cantrey"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn42.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TOTAL_mony"
        Me.DataGridViewTextBoxColumn43.HeaderText = "TOTAL_mony"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "BAY_SARYAL"
        Me.DataGridViewTextBoxColumn44.HeaderText = "BAY_SARYAL"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.ReadOnly = True
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "KENT"
        Me.DataGridViewTextBoxColumn45.HeaderText = "KENT"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.ReadOnly = True
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "CACH"
        Me.DataGridViewTextBoxColumn46.HeaderText = "CACH"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.ReadOnly = True
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "arbic_tayb"
        Me.DataGridViewTextBoxColumn47.HeaderText = "arbic_tayb"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.ReadOnly = True
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "balance"
        Me.DataGridViewTextBoxColumn48.HeaderText = "balance"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.ReadOnly = True
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "CastomerNAme"
        Me.DataGridViewTextBoxColumn49.HeaderText = "CastomerNAme"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.ReadOnly = True
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "CastomerADr"
        Me.DataGridViewTextBoxColumn50.HeaderText = "CastomerADr"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.ReadOnly = True
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "CastomerTE"
        Me.DataGridViewTextBoxColumn51.HeaderText = "CastomerTE"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "CastomerNA"
        Me.DataGridViewTextBoxColumn52.HeaderText = "CastomerNA"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "staytes"
        Me.DataGridViewTextBoxColumn53.HeaderText = "staytes"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foto"
        Me.DataGridViewImageColumn1.HeaderText = "foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "Cash"
        Me.DataGridViewTextBoxColumn54.HeaderText = "Cash"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Gram_valu"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Gram_valu"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "qunt"
        Me.DataGridViewTextBoxColumn56.HeaderText = "qunt"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "nots"
        Me.DataGridViewTextBoxColumn57.HeaderText = "nots"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PayMethodTextBox)
        Me.Panel1.Controls.Add(Me.English_taybTextBox)
        Me.Panel1.Controls.Add(Me.SelInvoceActiveCheckBox)
        Me.Panel1.Controls.Add(Me.BayActiveCheckBox)
        Me.Panel1.Controls.Add(Me.BAYDataGridView)
        Me.Panel1.Controls.Add(Me.StaytesTextBox)
        Me.Panel1.Controls.Add(Me.Total_priceTextBox)
        Me.Panel1.Controls.Add(Me.BalanceTextBox)
        Me.Panel1.Controls.Add(Me.Sum_total_priceDataGridView)
        Me.Panel1.Controls.Add(Me.Invoce_reportDataGridView)
        Me.Panel1.Controls.Add(Me.Arbic_taybTextBox)
        Me.Panel1.Controls.Add(Me.TOTAL_monyTextBox)
        Me.Panel1.Controls.Add(Me.BAY_SARYALTextBox)
        Me.Panel1.Controls.Add(Me.BAY_IDTextBox)
        Me.Panel1.Controls.Add(Me.Sum_total_priceTextBox)
        Me.Panel1.Location = New System.Drawing.Point(1057, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(29, 22)
        Me.Panel1.TabIndex = 86
        '
        'PayMethodTextBox
        '
        Me.PayMethodTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PayMethodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "PayMethod", True))
        Me.PayMethodTextBox.Location = New System.Drawing.Point(-75, 383)
        Me.PayMethodTextBox.Name = "PayMethodTextBox"
        Me.PayMethodTextBox.Size = New System.Drawing.Size(45, 27)
        Me.PayMethodTextBox.TabIndex = 89
        '
        'English_taybTextBox
        '
        Me.English_taybTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.English_taybTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BAYBindingSource, "English_tayb", True))
        Me.English_taybTextBox.Location = New System.Drawing.Point(-75, 356)
        Me.English_taybTextBox.Name = "English_taybTextBox"
        Me.English_taybTextBox.Size = New System.Drawing.Size(45, 27)
        Me.English_taybTextBox.TabIndex = 88
        '
        'SelInvoceActiveCheckBox
        '
        Me.SelInvoceActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelInvoceActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SelInvoceDetelsBindingSource, "Active", True))
        Me.SelInvoceActiveCheckBox.Location = New System.Drawing.Point(-75, 273)
        Me.SelInvoceActiveCheckBox.Name = "SelInvoceActiveCheckBox"
        Me.SelInvoceActiveCheckBox.Size = New System.Drawing.Size(45, 27)
        Me.SelInvoceActiveCheckBox.TabIndex = 87
        Me.SelInvoceActiveCheckBox.Text = "SelInvoceActive"
        Me.SelInvoceActiveCheckBox.UseVisualStyleBackColor = True
        '
        'BayActiveCheckBox
        '
        Me.BayActiveCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BayActiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BAYBindingSource, "Active", True))
        Me.BayActiveCheckBox.Location = New System.Drawing.Point(-75, 246)
        Me.BayActiveCheckBox.Name = "BayActiveCheckBox"
        Me.BayActiveCheckBox.Size = New System.Drawing.Size(45, 27)
        Me.BayActiveCheckBox.TabIndex = 86
        Me.BayActiveCheckBox.Text = "BayACTIVE"
        Me.BayActiveCheckBox.UseVisualStyleBackColor = True
        '
        'SelInvoceDetelsTableAdapter
        '
        Me.SelInvoceDetelsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Me.SelInvoceDetelsTableAdapter
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.SndGoldTableAdapter = Nothing
        Me.TableAdapterManager.SndToCustomerTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.TBBondTypeTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanylicenseIDTableAdapter = Nothing
        Me.TableAdapterManager.TPSellBuyWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.TpSetGoledPriceDiffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'BAYTableAdapter
        '
        Me.BAYTableAdapter.ClearBeforeFill = True
        '
        'Sum_total_priceTableAdapter
        '
        Me.Sum_total_priceTableAdapter.ClearBeforeFill = True
        '
        'Invoce_reportTableAdapter
        '
        Me.Invoce_reportTableAdapter.ClearBeforeFill = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(4, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(135, 51)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(656, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(135, 51)
        Me.btnView.TabIndex = 87
        Me.btnView.Text = "عرض الفاتورة"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(797, 4)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(159, 19)
        Me.lblInvoiceNo.TabIndex = 99
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(797, 29)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(168, 27)
        Me.txtInvoiceNo.TabIndex = 100
        '
        'lblNote
        '
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNote.ForeColor = System.Drawing.Color.Red
        Me.lblNote.Location = New System.Drawing.Point(820, 635)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(145, 44)
        Me.lblNote.TabIndex = 100
        Me.lblNote.Text = "مبلغ الفاتورة"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnote
        '
        Me.txtnote.Location = New System.Drawing.Point(4, 635)
        Me.txtnote.Multiline = True
        Me.txtnote.Name = "txtnote"
        Me.txtnote.Size = New System.Drawing.Size(812, 44)
        Me.txtnote.TabIndex = 101
        Me.txtnote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GoledKarat
        '
        Me.GoledKarat.DataPropertyName = "GoledKarat"
        Me.GoledKarat.HeaderText = "GoledKarat"
        Me.GoledKarat.Name = "GoledKarat"
        Me.GoledKarat.Width = 111
        '
        'GoldSellEditRemove
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(969, 680)
        Me.Controls.Add(Me.txtnote)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gbSave)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GoldSellEditRemove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تعديل"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelInvoceDetelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sum_total_priceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sum_total_priceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSave.ResumeLayout(False)
        Me.gbSave.PerformLayout()
        CType(Me.Invoce_reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents SelInvoceDetelsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelInvoceDetelsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.selInvoceDetelsTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents BAYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BAYTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.BAYTableAdapter
    Friend WithEvents BAYDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BAY_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BAY_SARYALTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TOTAL_monyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Arbic_taybTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaytesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sum_total_priceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sum_total_priceTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.sum_total_priceTableAdapter
    Friend WithEvents Sum_total_priceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sum_total_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceReturn As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceRequired As System.Windows.Forms.TextBox
    Friend WithEvents gbSave As System.Windows.Forms.GroupBox
    Friend WithEvents Invoce_reportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Invoce_reportTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.invoce_reportTableAdapter
    Friend WithEvents Invoce_reportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblInvoicePrice As System.Windows.Forms.Label
    Friend WithEvents lblReturn As System.Windows.Forms.Label
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SelInvoceActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BayActiveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents English_taybTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents PayMethodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnView As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtnote As System.Windows.Forms.TextBox
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem_GramPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem_gram As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem_gramMade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneColor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneWeight1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePrice1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneColor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneWeight2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePrice2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneName3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneColor3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneWeight3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStonePrice3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colitem_totalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbPayMethod1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtBank1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbPayMethod4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayMethod1 As System.Windows.Forms.Label
    Friend WithEvents txtBank4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank2 As System.Windows.Forms.TextBox
    Friend WithEvents GoledKarat As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
