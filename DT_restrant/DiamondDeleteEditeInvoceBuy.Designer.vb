<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiamondDeleteEditeInvoceBuy
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiamondDeleteEditeInvoceBuy))
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.DGridItemDetels = New System.Windows.Forms.DataGridView()
        Me.ColDel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDIMO_dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGOLD_mezan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIMO_mezan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colval_gold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbay_total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDIM_na9awa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colext_coler = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsarual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltest_12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colqult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcastomer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colinv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colB_Diamond_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbInvoiceData = New System.Windows.Forms.GroupBox()
        Me.rbtnCash = New System.Windows.Forms.RadioButton()
        Me.rbtnInstallment = New System.Windows.Forms.RadioButton()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.lblKnet = New System.Windows.Forms.Label()
        Me.txtPriceReturn = New System.Windows.Forms.TextBox()
        Me.lblPriceRequired = New System.Windows.Forms.Label()
        Me.lblPriceReturn = New System.Windows.Forms.Label()
        Me.txtPriceRequired = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        CType(Me.DGridItemDetels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInvoiceData.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(639, 7)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(125, 50)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(12, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 50)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(221, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 50)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(430, 9)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(125, 50)
        Me.btnDeleteInvoice.TabIndex = 9
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceNo.Location = New System.Drawing.Point(781, 6)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(184, 19)
        Me.lblInvoiceNo.TabIndex = 92
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGridItemDetels
        '
        Me.DGridItemDetels.AllowUserToAddRows = False
        Me.DGridItemDetels.AllowUserToOrderColumns = True
        Me.DGridItemDetels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGridItemDetels.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGridItemDetels.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGridItemDetels.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridItemDetels.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGridItemDetels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridItemDetels.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDel, Me.colDIMO_dep, Me.colGOLD_mezan, Me.colDIMO_mezan, Me.colval_gold, Me.colbay_total_price, Me.colDIM_na9awa, Me.colext_coler, Me.colsarual, Me.coltest_11, Me.colNotes, Me.coltest_12, Me.colqult, Me.colcastomer_id, Me.colinv_id, Me.colB_Diamond_id, Me.colActive})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridItemDetels.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGridItemDetels.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DGridItemDetels.Location = New System.Drawing.Point(7, 322)
        Me.DGridItemDetels.MultiSelect = False
        Me.DGridItemDetels.Name = "DGridItemDetels"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridItemDetels.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGridItemDetels.RowHeadersVisible = False
        Me.DGridItemDetels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGridItemDetels.Size = New System.Drawing.Size(967, 138)
        Me.DGridItemDetels.TabIndex = 93
        '
        'ColDel
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.ColDel.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColDel.FillWeight = 40.0!
        Me.ColDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ColDel.HeaderText = "Del"
        Me.ColDel.Name = "ColDel"
        Me.ColDel.Text = "X"
        Me.ColDel.UseColumnTextForButtonValue = True
        Me.ColDel.Width = 47
        '
        'colDIMO_dep
        '
        Me.colDIMO_dep.HeaderText = "DIMO_dep"
        Me.colDIMO_dep.Name = "colDIMO_dep"
        '
        'colGOLD_mezan
        '
        Me.colGOLD_mezan.HeaderText = "GOLD_mezan"
        Me.colGOLD_mezan.Name = "colGOLD_mezan"
        '
        'colDIMO_mezan
        '
        Me.colDIMO_mezan.HeaderText = "DIMO_mezan"
        Me.colDIMO_mezan.Name = "colDIMO_mezan"
        '
        'colval_gold
        '
        Me.colval_gold.HeaderText = "val_gold"
        Me.colval_gold.Name = "colval_gold"
        '
        'colbay_total_price
        '
        Me.colbay_total_price.HeaderText = "bay_total_price"
        Me.colbay_total_price.Name = "colbay_total_price"
        '
        'colDIM_na9awa
        '
        Me.colDIM_na9awa.HeaderText = "DIM_na9awa"
        Me.colDIM_na9awa.Name = "colDIM_na9awa"
        '
        'colext_coler
        '
        Me.colext_coler.HeaderText = "ext_coler"
        Me.colext_coler.Name = "colext_coler"
        '
        'colsarual
        '
        Me.colsarual.HeaderText = "sarual"
        Me.colsarual.Name = "colsarual"
        '
        'coltest_11
        '
        Me.coltest_11.HeaderText = "test_11"
        Me.coltest_11.Name = "coltest_11"
        '
        'colNotes
        '
        Me.colNotes.HeaderText = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.Width = 150
        '
        'coltest_12
        '
        Me.coltest_12.HeaderText = "test_12"
        Me.coltest_12.Name = "coltest_12"
        Me.coltest_12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coltest_12.Visible = False
        '
        'colqult
        '
        Me.colqult.HeaderText = "qult"
        Me.colqult.Name = "colqult"
        Me.colqult.Visible = False
        '
        'colcastomer_id
        '
        Me.colcastomer_id.HeaderText = "castomer_id"
        Me.colcastomer_id.Name = "colcastomer_id"
        Me.colcastomer_id.Visible = False
        '
        'colinv_id
        '
        Me.colinv_id.HeaderText = "inv_id"
        Me.colinv_id.Name = "colinv_id"
        Me.colinv_id.Visible = False
        '
        'colB_Diamond_id
        '
        Me.colB_Diamond_id.HeaderText = "B_Diamond_id"
        Me.colB_Diamond_id.Name = "colB_Diamond_id"
        Me.colB_Diamond_id.Visible = False
        '
        'colActive
        '
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = False
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
        Me.gbInvoiceData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbInvoiceData.Location = New System.Drawing.Point(7, 466)
        Me.gbInvoiceData.Name = "gbInvoiceData"
        Me.gbInvoiceData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbInvoiceData.Size = New System.Drawing.Size(967, 185)
        Me.gbInvoiceData.TabIndex = 94
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
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        Me.txtCash.ForeColor = System.Drawing.Color.Blue
        Me.txtCash.Location = New System.Drawing.Point(33, 77)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCash.Size = New System.Drawing.Size(241, 27)
        Me.txtCash.TabIndex = 4
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.Color.White
        Me.txtKnet.ForeColor = System.Drawing.Color.Blue
        Me.txtKnet.Location = New System.Drawing.Point(33, 104)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKnet.Size = New System.Drawing.Size(241, 27)
        Me.txtKnet.TabIndex = 5
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(777, 30)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(190, 27)
        Me.txtInvoiceNo.TabIndex = 95
        '
        'DiamondDeleteEditeInvoceBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(979, 654)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.gbInvoiceData)
        Me.Controls.Add(Me.DGridItemDetels)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiamondDeleteEditeInvoceBuy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiamondDeleteEditeInvoce"
        CType(Me.DGridItemDetels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInvoiceData.ResumeLayout(False)
        Me.gbInvoiceData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents DGridItemDetels As System.Windows.Forms.DataGridView
    Friend WithEvents gbInvoiceData As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnInstallment As System.Windows.Forms.RadioButton
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents dtpInvoiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents lblKnet As System.Windows.Forms.Label
    Friend WithEvents txtPriceReturn As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceRequired As System.Windows.Forms.Label
    Friend WithEvents txtPriceRequired As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents ColDel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDIMO_dep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGOLD_mezan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIMO_mezan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colval_gold As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbay_total_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDIM_na9awa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colext_coler As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colsarual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coltest_12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colqult As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcastomer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colinv_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colB_Diamond_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblPriceReturn As System.Windows.Forms.Label
End Class
