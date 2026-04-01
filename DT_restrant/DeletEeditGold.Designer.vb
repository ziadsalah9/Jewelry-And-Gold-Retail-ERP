<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeletEeditGold
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletEeditGold))
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPayPrint = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colModify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcacher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldNetWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledNetKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoledPiecesQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvocDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNots = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddToItem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Bay_gram_priceLabel = New System.Windows.Forms.LinkLabel()
        Me.lblNetCaret = New System.Windows.Forms.Label()
        Me.cmbKarat = New System.Windows.Forms.ComboBox()
        Me.LblAddToItem = New System.Windows.Forms.Label()
        Me.chkAddToItem = New System.Windows.Forms.CheckBox()
        Me.ComBxGoCaret999 = New System.Windows.Forms.ComboBox()
        Me.TXTGoCaret999 = New System.Windows.Forms.TextBox()
        Me.lblNetWeight = New System.Windows.Forms.Label()
        Me.txtQunt = New System.Windows.Forms.TextBox()
        Me.lblQunt = New System.Windows.Forms.Label()
        Me.TeBoxItem_Des = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.LabItem_Des = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGramPrice = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Bay_mazanLabel = New System.Windows.Forms.Label()
        Me.BtnSaveEdte = New System.Windows.Forms.Button()
        Me.txtPriceReturn = New System.Windows.Forms.TextBox()
        Me.lblInvoicePrice = New System.Windows.Forms.Label()
        Me.txtTotalPriceValue = New System.Windows.Forms.TextBox()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.PanPay = New System.Windows.Forms.Panel()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(660, 9)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(167, 27)
        Me.txtInvoiceNo.TabIndex = 144
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblInvoiceNo.Location = New System.Drawing.Point(825, 2)
        Me.lblInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(139, 34)
        Me.lblInvoiceNo.TabIndex = 143
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(504, 2)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(148, 37)
        Me.btnView.TabIndex = 142
        Me.btnView.Text = "عرض الفاتورة"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(338, 2)
        Me.btnDeleteInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(148, 37)
        Me.btnDeleteInvoice.TabIndex = 139
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(172, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(148, 37)
        Me.btnSave.TabIndex = 141
        Me.btnSave.Text = "حفظ الفاتوره"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPayPrint
        '
        Me.btnPayPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPayPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnPayPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPayPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayPrint.Location = New System.Drawing.Point(6, 2)
        Me.btnPayPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayPrint.Name = "btnPayPrint"
        Me.btnPayPrint.Size = New System.Drawing.Size(148, 37)
        Me.btnPayPrint.TabIndex = 140
        Me.btnPayPrint.Text = "طباعة"
        Me.btnPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayPrint.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.BackgroundColor = System.Drawing.Color.Silver
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 30
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colModify, Me.colID, Me.colInvId, Me.colCastomerid, Me.colcacher, Me.colItemName, Me.colGramPrice, Me.colGoldWeight, Me.colGoledKarat, Me.colGoldNetWeight, Me.colGoledNetKarat, Me.colGoledPrice, Me.colGoledPiecesQuantity, Me.coldate, Me.coluserID, Me.colInvocDateTime, Me.colNots, Me.colAddToItem})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle4
        Me.grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grid.Location = New System.Drawing.Point(0, 297)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Tomato
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(964, 143)
        Me.grid.TabIndex = 157
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
        Me.colModify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colModify.HeaderText = "Modify"
        Me.colModify.Name = "colModify"
        Me.colModify.ReadOnly = True
        Me.colModify.Width = 64
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        Me.colID.Width = 48
        '
        'colInvId
        '
        Me.colInvId.HeaderText = "InvId"
        Me.colInvId.Name = "colInvId"
        Me.colInvId.ReadOnly = True
        Me.colInvId.Visible = False
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
        'colItemName
        '
        Me.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        'colGoldNetWeight
        '
        Me.colGoldNetWeight.HeaderText = "GoldNetWeight"
        Me.colGoldNetWeight.Name = "colGoldNetWeight"
        Me.colGoldNetWeight.ReadOnly = True
        Me.colGoldNetWeight.Width = 140
        '
        'colGoledNetKarat
        '
        Me.colGoledNetKarat.HeaderText = "GoledNetKarat"
        Me.colGoledNetKarat.Name = "colGoledNetKarat"
        Me.colGoledNetKarat.ReadOnly = True
        Me.colGoledNetKarat.Width = 136
        '
        'colGoledPrice
        '
        Me.colGoledPrice.HeaderText = "GoledPrice"
        Me.colGoledPrice.Name = "colGoledPrice"
        Me.colGoledPrice.ReadOnly = True
        Me.colGoledPrice.Width = 108
        '
        'colGoledPiecesQuantity
        '
        Me.colGoledPiecesQuantity.HeaderText = "GoledPiecesQuantity"
        Me.colGoledPiecesQuantity.Name = "colGoledPiecesQuantity"
        Me.colGoledPiecesQuantity.ReadOnly = True
        Me.colGoledPiecesQuantity.Width = 176
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
        'colInvocDateTime
        '
        Me.colInvocDateTime.HeaderText = "InvocDateTime"
        Me.colInvocDateTime.Name = "colInvocDateTime"
        Me.colInvocDateTime.ReadOnly = True
        Me.colInvocDateTime.Visible = False
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
        'colAddToItem
        '
        Me.colAddToItem.HeaderText = "AddToItem"
        Me.colAddToItem.Name = "colAddToItem"
        Me.colAddToItem.ReadOnly = True
        Me.colAddToItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddToItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colAddToItem.Visible = False
        Me.colAddToItem.Width = 109
        '
        'cmbCashier
        '
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(828, 474)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(136, 27)
        Me.cmbCashier.TabIndex = 158
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.OliveDrab
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.Location = New System.Drawing.Point(382, 503)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(101, 20)
        Me.LinkLabel1.TabIndex = 214
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "حساب السعر"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Bay_gram_priceLabel
        '
        Me.Bay_gram_priceLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Bay_gram_priceLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bay_gram_priceLabel.LinkColor = System.Drawing.Color.PaleGreen
        Me.Bay_gram_priceLabel.Location = New System.Drawing.Point(484, 503)
        Me.Bay_gram_priceLabel.Name = "Bay_gram_priceLabel"
        Me.Bay_gram_priceLabel.Size = New System.Drawing.Size(93, 20)
        Me.Bay_gram_priceLabel.TabIndex = 213
        Me.Bay_gram_priceLabel.TabStop = True
        Me.Bay_gram_priceLabel.Text = "حساب سعر الجرام"
        Me.Bay_gram_priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNetCaret
        '
        Me.lblNetCaret.Location = New System.Drawing.Point(725, 503)
        Me.lblNetCaret.Name = "lblNetCaret"
        Me.lblNetCaret.Size = New System.Drawing.Size(80, 20)
        Me.lblNetCaret.TabIndex = 212
        Me.lblNetCaret.Text = "العيار الصافي"
        Me.lblNetCaret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbKarat
        '
        Me.cmbKarat.FormattingEnabled = True
        Me.cmbKarat.Location = New System.Drawing.Point(877, 528)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.Size = New System.Drawing.Size(87, 27)
        Me.cmbKarat.TabIndex = 192
        '
        'LblAddToItem
        '
        Me.LblAddToItem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblAddToItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAddToItem.ForeColor = System.Drawing.Color.Black
        Me.LblAddToItem.Location = New System.Drawing.Point(207, 445)
        Me.LblAddToItem.Name = "LblAddToItem"
        Me.LblAddToItem.Size = New System.Drawing.Size(171, 24)
        Me.LblAddToItem.TabIndex = 211
        Me.LblAddToItem.Text = "اضف الي اصناف الذهب"
        Me.LblAddToItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkAddToItem
        '
        Me.chkAddToItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.chkAddToItem.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAddToItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAddToItem.Location = New System.Drawing.Point(207, 469)
        Me.chkAddToItem.Name = "chkAddToItem"
        Me.chkAddToItem.Size = New System.Drawing.Size(171, 27)
        Me.chkAddToItem.TabIndex = 210
        Me.chkAddToItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAddToItem.UseVisualStyleBackColor = False
        '
        'ComBxGoCaret999
        '
        Me.ComBxGoCaret999.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBxGoCaret999.FormattingEnabled = True
        Me.ComBxGoCaret999.Location = New System.Drawing.Point(725, 528)
        Me.ComBxGoCaret999.Name = "ComBxGoCaret999"
        Me.ComBxGoCaret999.Size = New System.Drawing.Size(80, 27)
        Me.ComBxGoCaret999.TabIndex = 209
        '
        'TXTGoCaret999
        '
        Me.TXTGoCaret999.Location = New System.Drawing.Point(646, 528)
        Me.TXTGoCaret999.Name = "TXTGoCaret999"
        Me.TXTGoCaret999.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTGoCaret999.Size = New System.Drawing.Size(78, 27)
        Me.TXTGoCaret999.TabIndex = 207
        Me.TXTGoCaret999.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNetWeight
        '
        Me.lblNetWeight.ForeColor = System.Drawing.Color.Black
        Me.lblNetWeight.Location = New System.Drawing.Point(646, 503)
        Me.lblNetWeight.Name = "lblNetWeight"
        Me.lblNetWeight.Size = New System.Drawing.Size(78, 20)
        Me.lblNetWeight.TabIndex = 208
        Me.lblNetWeight.Text = "الوزن الصافي"
        Me.lblNetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQunt
        '
        Me.txtQunt.Location = New System.Drawing.Point(578, 528)
        Me.txtQunt.Name = "txtQunt"
        Me.txtQunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQunt.Size = New System.Drawing.Size(67, 27)
        Me.txtQunt.TabIndex = 194
        Me.txtQunt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQunt
        '
        Me.lblQunt.ForeColor = System.Drawing.Color.Black
        Me.lblQunt.Location = New System.Drawing.Point(578, 503)
        Me.lblQunt.Name = "lblQunt"
        Me.lblQunt.Size = New System.Drawing.Size(67, 20)
        Me.lblQunt.TabIndex = 206
        Me.lblQunt.Text = "العدد"
        Me.lblQunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TeBoxItem_Des
        '
        Me.TeBoxItem_Des.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TeBoxItem_Des.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TeBoxItem_Des.FormattingEnabled = True
        Me.TeBoxItem_Des.Location = New System.Drawing.Point(569, 474)
        Me.TeBoxItem_Des.Name = "TeBoxItem_Des"
        Me.TeBoxItem_Des.Size = New System.Drawing.Size(258, 27)
        Me.TeBoxItem_Des.TabIndex = 191
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(384, 444)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(186, 25)
        Me.lblDate.TabIndex = 205
        Me.lblDate.Text = "التاريخ"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashier
        '
        Me.lblCashier.ForeColor = System.Drawing.Color.Black
        Me.lblCashier.Location = New System.Drawing.Point(828, 444)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(136, 25)
        Me.lblCashier.TabIndex = 199
        Me.lblCashier.Text = "كاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.CustomFormat = "dd/MM/yyyy"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(381, 474)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(186, 27)
        Me.dtDate.TabIndex = 204
        '
        'LabItem_Des
        '
        Me.LabItem_Des.ForeColor = System.Drawing.Color.Black
        Me.LabItem_Des.Location = New System.Drawing.Point(569, 444)
        Me.LabItem_Des.Name = "LabItem_Des"
        Me.LabItem_Des.Size = New System.Drawing.Size(258, 25)
        Me.LabItem_Des.TabIndex = 203
        Me.LabItem_Des.Text = "الوصف"
        Me.LabItem_Des.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(382, 528)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrice.Size = New System.Drawing.Size(101, 27)
        Me.txtPrice.TabIndex = 195
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(877, 503)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "العيار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGramPrice
        '
        Me.txtGramPrice.Location = New System.Drawing.Point(484, 528)
        Me.txtGramPrice.Name = "txtGramPrice"
        Me.txtGramPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGramPrice.Size = New System.Drawing.Size(93, 27)
        Me.txtGramPrice.TabIndex = 196
        Me.txtGramPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(806, 528)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWeight.Size = New System.Drawing.Size(70, 27)
        Me.txtWeight.TabIndex = 193
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bay_mazanLabel
        '
        Me.Bay_mazanLabel.ForeColor = System.Drawing.Color.Black
        Me.Bay_mazanLabel.Location = New System.Drawing.Point(806, 503)
        Me.Bay_mazanLabel.Name = "Bay_mazanLabel"
        Me.Bay_mazanLabel.Size = New System.Drawing.Size(70, 20)
        Me.Bay_mazanLabel.TabIndex = 198
        Me.Bay_mazanLabel.Text = "الوزن"
        Me.Bay_mazanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSaveEdte
        '
        Me.BtnSaveEdte.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSaveEdte.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveEdte.ForeColor = System.Drawing.Color.White
        Me.BtnSaveEdte.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.BtnSaveEdte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSaveEdte.Location = New System.Drawing.Point(0, 442)
        Me.BtnSaveEdte.Name = "BtnSaveEdte"
        Me.BtnSaveEdte.Size = New System.Drawing.Size(201, 52)
        Me.BtnSaveEdte.TabIndex = 219
        Me.BtnSaveEdte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSaveEdte.UseVisualStyleBackColor = False
        '
        'txtPriceReturn
        '
        Me.txtPriceReturn.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtPriceReturn.Enabled = False
        Me.txtPriceReturn.ForeColor = System.Drawing.Color.White
        Me.txtPriceReturn.Location = New System.Drawing.Point(203, 559)
        Me.txtPriceReturn.Name = "txtPriceReturn"
        Me.txtPriceReturn.Size = New System.Drawing.Size(175, 27)
        Me.txtPriceReturn.TabIndex = 218
        Me.txtPriceReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblInvoicePrice
        '
        Me.lblInvoicePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoicePrice.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoicePrice.ForeColor = System.Drawing.Color.Black
        Me.lblInvoicePrice.Location = New System.Drawing.Point(297, 499)
        Me.lblInvoicePrice.Name = "lblInvoicePrice"
        Me.lblInvoicePrice.Size = New System.Drawing.Size(81, 27)
        Me.lblInvoicePrice.TabIndex = 216
        Me.lblInvoicePrice.Text = "مبلغ الفاتورة"
        Me.lblInvoicePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalPriceValue
        '
        Me.txtTotalPriceValue.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalPriceValue.Location = New System.Drawing.Point(203, 499)
        Me.txtTotalPriceValue.Name = "txtTotalPriceValue"
        Me.txtTotalPriceValue.Size = New System.Drawing.Size(93, 27)
        Me.txtTotalPriceValue.TabIndex = 215
        Me.txtTotalPriceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReturn
        '
        Me.lblReturn.BackColor = System.Drawing.Color.White
        Me.lblReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReturn.ForeColor = System.Drawing.Color.Black
        Me.lblReturn.Location = New System.Drawing.Point(203, 528)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(175, 27)
        Me.lblReturn.TabIndex = 217
        Me.lblReturn.Text = "ــــــــــــــــــــــــــــــــــــــــ"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanPay
        '
        Me.PanPay.Controls.Add(Me.cmbPayMethod)
        Me.PanPay.Controls.Add(Me.lblBank)
        Me.PanPay.Controls.Add(Me.txtKnet)
        Me.PanPay.Controls.Add(Me.txtCash)
        Me.PanPay.Controls.Add(Me.lblCash)
        Me.PanPay.Controls.Add(Me.lblPayMethod)
        Me.PanPay.Location = New System.Drawing.Point(0, 494)
        Me.PanPay.Name = "PanPay"
        Me.PanPay.Size = New System.Drawing.Size(201, 92)
        Me.PanPay.TabIndex = 220
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(3, 59)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(86, 27)
        Me.cmbPayMethod.TabIndex = 148
        '
        'lblBank
        '
        Me.lblBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBank.ForeColor = System.Drawing.Color.Blue
        Me.lblBank.Location = New System.Drawing.Point(92, 31)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(105, 27)
        Me.lblBank.TabIndex = 142
        Me.lblBank.Text = "المدفوع بنكي"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.SystemColors.Info
        Me.txtKnet.ForeColor = System.Drawing.Color.Blue
        Me.txtKnet.Location = New System.Drawing.Point(3, 32)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(86, 27)
        Me.txtKnet.TabIndex = 141
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.Info
        Me.txtCash.ForeColor = System.Drawing.Color.Blue
        Me.txtCash.Location = New System.Drawing.Point(3, 5)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(86, 27)
        Me.txtCash.TabIndex = 140
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCash
        '
        Me.lblCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCash.ForeColor = System.Drawing.Color.Blue
        Me.lblCash.Location = New System.Drawing.Point(92, 5)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(105, 26)
        Me.lblCash.TabIndex = 143
        Me.lblCash.Text = "المدفوع كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayMethod
        '
        Me.lblPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayMethod.ForeColor = System.Drawing.Color.Blue
        Me.lblPayMethod.Location = New System.Drawing.Point(92, 58)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(105, 27)
        Me.lblPayMethod.TabIndex = 147
        Me.lblPayMethod.Text = "طريقة الدفع"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(382, 559)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(497, 27)
        Me.txtNotes.TabIndex = 153
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNote
        '
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNote.ForeColor = System.Drawing.Color.Red
        Me.lblNote.Location = New System.Drawing.Point(882, 559)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(82, 27)
        Me.lblNote.TabIndex = 152
        Me.lblNote.Text = "ملاحظات"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeletEeditGold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(966, 588)
        Me.Controls.Add(Me.lblInvoicePrice)
        Me.Controls.Add(Me.txtTotalPriceValue)
        Me.Controls.Add(Me.PanPay)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.txtPriceReturn)
        Me.Controls.Add(Me.BtnSaveEdte)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Bay_gram_priceLabel)
        Me.Controls.Add(Me.lblNetCaret)
        Me.Controls.Add(Me.cmbKarat)
        Me.Controls.Add(Me.LblAddToItem)
        Me.Controls.Add(Me.chkAddToItem)
        Me.Controls.Add(Me.ComBxGoCaret999)
        Me.Controls.Add(Me.TXTGoCaret999)
        Me.Controls.Add(Me.lblNetWeight)
        Me.Controls.Add(Me.txtQunt)
        Me.Controls.Add(Me.lblQunt)
        Me.Controls.Add(Me.TeBoxItem_Des)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabItem_Des)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGramPrice)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Bay_mazanLabel)
        Me.Controls.Add(Me.cmbCashier)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPayPrint)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeletEeditGold"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeletEeditGold"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanPay.ResumeLayout(False)
        Me.PanPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPayPrint As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Bay_gram_priceLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents lblNetCaret As System.Windows.Forms.Label
    Friend WithEvents cmbKarat As System.Windows.Forms.ComboBox
    Friend WithEvents LblAddToItem As System.Windows.Forms.Label
    Friend WithEvents chkAddToItem As System.Windows.Forms.CheckBox
    Friend WithEvents ComBxGoCaret999 As System.Windows.Forms.ComboBox
    Friend WithEvents TXTGoCaret999 As System.Windows.Forms.TextBox
    Friend WithEvents lblNetWeight As System.Windows.Forms.Label
    Friend WithEvents txtQunt As System.Windows.Forms.TextBox
    Friend WithEvents lblQunt As System.Windows.Forms.Label
    Friend WithEvents TeBoxItem_Des As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabItem_Des As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGramPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Bay_mazanLabel As System.Windows.Forms.Label
    Friend WithEvents BtnSaveEdte As System.Windows.Forms.Button
    Friend WithEvents txtPriceReturn As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoicePrice As System.Windows.Forms.Label
    Friend WithEvents txtTotalPriceValue As System.Windows.Forms.TextBox
    Friend WithEvents lblReturn As System.Windows.Forms.Label
    Friend WithEvents PanPay As System.Windows.Forms.Panel
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colModify As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCastomerid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcacher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGramPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoldWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledKarat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoldNetWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledNetKarat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoledPiecesQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coluserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInvocDateTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNots As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddToItem As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
