<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldBuyEditRemove
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colB_gold_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKarat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGramPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblRequired = New System.Windows.Forms.Label()
        Me.tbtReturnedWeight = New System.Windows.Forms.Label()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKNET = New System.Windows.Forms.TextBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.pnlPrice = New System.Windows.Forms.Panel()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.dtpInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtPriceNew = New System.Windows.Forms.Label()
        Me.lblPriceNew = New System.Windows.Forms.Label()
        Me.txtReturnPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.Label()
        Me.pnlWeight = New System.Windows.Forms.Panel()
        Me.txtReturnedWeight = New System.Windows.Forms.Label()
        Me.txtTotalWeight = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbData.SuspendLayout()
        Me.pnlPrice.SuspendLayout()
        Me.pnlWeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeight = 30
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colB_gold_id, Me.colCID, Me.colInvoiceNo, Me.colKarat, Me.colWeight, Me.colGramPrice, Me.colPrice, Me.colItemDescription, Me.colInvID, Me.Delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grid.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grid.Location = New System.Drawing.Point(2, 320)
        Me.grid.Margin = New System.Windows.Forms.Padding(4)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(960, 150)
        Me.grid.TabIndex = 3
        '
        'colB_gold_id
        '
        Me.colB_gold_id.HeaderText = "colB_gold_id"
        Me.colB_gold_id.Name = "colB_gold_id"
        Me.colB_gold_id.Visible = False
        '
        'colCID
        '
        Me.colCID.HeaderText = "colCID"
        Me.colCID.Name = "colCID"
        Me.colCID.Visible = False
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.HeaderText = "رقم الفاتورة"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.Visible = False
        '
        'colKarat
        '
        Me.colKarat.HeaderText = "العيار"
        Me.colKarat.Name = "colKarat"
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "الوزن"
        Me.colWeight.Name = "colWeight"
        '
        'colGramPrice
        '
        Me.colGramPrice.HeaderText = "سعر الجرام"
        Me.colGramPrice.Name = "colGramPrice"
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "السعر"
        Me.colPrice.Name = "colPrice"
        '
        'colItemDescription
        '
        Me.colItemDescription.HeaderText = "وصف الصنف"
        Me.colItemDescription.Name = "colItemDescription"
        '
        'colInvID
        '
        Me.colInvID.HeaderText = "colInvID"
        Me.colInvID.Name = "colInvID"
        Me.colInvID.Visible = False
        '
        'Delete
        '
        Me.Delete.FillWeight = 50.0!
        Me.Delete.HeaderText = "حذف"
        Me.Delete.Name = "Delete"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(775, 31)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(184, 27)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(425, 13)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(197, 19)
        Me.lblPrice.TabIndex = 29
        Me.lblPrice.Text = "قيمة الفاتورة الأصلية"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRequired
        '
        Me.lblRequired.Location = New System.Drawing.Point(425, 57)
        Me.lblRequired.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRequired.Name = "lblRequired"
        Me.lblRequired.Size = New System.Drawing.Size(197, 19)
        Me.lblRequired.TabIndex = 31
        Me.lblRequired.Text = "المطلوب من العميل"
        Me.lblRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbtReturnedWeight
        '
        Me.tbtReturnedWeight.Location = New System.Drawing.Point(148, 38)
        Me.tbtReturnedWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbtReturnedWeight.Name = "tbtReturnedWeight"
        Me.tbtReturnedWeight.Size = New System.Drawing.Size(135, 19)
        Me.tbtReturnedWeight.TabIndex = 36
        Me.tbtReturnedWeight.Text = "الوزن المرتجع"
        Me.tbtReturnedWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.Location = New System.Drawing.Point(148, 16)
        Me.lblTotalWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(135, 19)
        Me.lblTotalWeight.TabIndex = 38
        Me.lblTotalWeight.Text = "إجمالي الوزن بالفاتورة"
        Me.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(296, 77)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(122, 27)
        Me.txtCash.TabIndex = 0
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKNET
        '
        Me.txtKNET.Location = New System.Drawing.Point(296, 104)
        Me.txtKNET.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKNET.Name = "txtKNET"
        Me.txtKNET.Size = New System.Drawing.Size(122, 27)
        Me.txtKNET.TabIndex = 1
        Me.txtKNET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(425, 81)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(197, 19)
        Me.lblCash.TabIndex = 42
        Me.lblCash.Text = "المدفوع كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(425, 108)
        Me.lblBank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(197, 19)
        Me.lblBank.TabIndex = 43
        Me.lblBank.Text = "المدفوع بنكي"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbData
        '
        Me.gbData.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbData.Controls.Add(Me.pnlPrice)
        Me.gbData.Controls.Add(Me.pnlWeight)
        Me.gbData.Location = New System.Drawing.Point(2, 473)
        Me.gbData.Margin = New System.Windows.Forms.Padding(4)
        Me.gbData.Name = "gbData"
        Me.gbData.Padding = New System.Windows.Forms.Padding(4)
        Me.gbData.Size = New System.Drawing.Size(960, 185)
        Me.gbData.TabIndex = 2
        Me.gbData.TabStop = False
        Me.gbData.Text = "بيانات الدفع"
        '
        'pnlPrice
        '
        Me.pnlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPrice.Controls.Add(Me.cmbCashier)
        Me.pnlPrice.Controls.Add(Me.lblCashier)
        Me.pnlPrice.Controls.Add(Me.dtpInvoiceDate)
        Me.pnlPrice.Controls.Add(Me.lblDate)
        Me.pnlPrice.Controls.Add(Me.txtPriceNew)
        Me.pnlPrice.Controls.Add(Me.lblPriceNew)
        Me.pnlPrice.Controls.Add(Me.txtReturnPrice)
        Me.pnlPrice.Controls.Add(Me.txtPrice)
        Me.pnlPrice.Controls.Add(Me.lblRequired)
        Me.pnlPrice.Controls.Add(Me.lblPrice)
        Me.pnlPrice.Controls.Add(Me.txtCash)
        Me.pnlPrice.Controls.Add(Me.txtKNET)
        Me.pnlPrice.Controls.Add(Me.lblBank)
        Me.pnlPrice.Controls.Add(Me.lblCash)
        Me.pnlPrice.Location = New System.Drawing.Point(11, 22)
        Me.pnlPrice.Name = "pnlPrice"
        Me.pnlPrice.Size = New System.Drawing.Size(628, 152)
        Me.pnlPrice.TabIndex = 45
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(30, 33)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(109, 27)
        Me.cmbCashier.TabIndex = 161
        '
        'lblCashier
        '
        Me.lblCashier.Location = New System.Drawing.Point(139, 37)
        Me.lblCashier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(99, 19)
        Me.lblCashier.TabIndex = 51
        Me.lblCashier.Text = "الكاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.CustomFormat = "yyyy/MM/dd"
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(30, 6)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(109, 27)
        Me.dtpInvoiceDate.TabIndex = 160
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(139, 10)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(99, 19)
        Me.lblDate.TabIndex = 50
        Me.lblDate.Text = "تاريخ الفاتورة"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPriceNew
        '
        Me.txtPriceNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPriceNew.Location = New System.Drawing.Point(296, 33)
        Me.txtPriceNew.Name = "txtPriceNew"
        Me.txtPriceNew.Size = New System.Drawing.Size(122, 22)
        Me.txtPriceNew.TabIndex = 49
        Me.txtPriceNew.Text = "000"
        Me.txtPriceNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPriceNew
        '
        Me.lblPriceNew.Location = New System.Drawing.Point(425, 35)
        Me.lblPriceNew.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceNew.Name = "lblPriceNew"
        Me.lblPriceNew.Size = New System.Drawing.Size(197, 19)
        Me.lblPriceNew.TabIndex = 48
        Me.lblPriceNew.Text = "قيمة الفاتورة بعد التعديل"
        Me.lblPriceNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReturnPrice
        '
        Me.txtReturnPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnPrice.Location = New System.Drawing.Point(296, 55)
        Me.txtReturnPrice.Name = "txtReturnPrice"
        Me.txtReturnPrice.Size = New System.Drawing.Size(122, 22)
        Me.txtReturnPrice.TabIndex = 47
        Me.txtReturnPrice.Text = "000"
        Me.txtReturnPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(296, 11)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(122, 22)
        Me.txtPrice.TabIndex = 46
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlWeight
        '
        Me.pnlWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWeight.Controls.Add(Me.txtReturnedWeight)
        Me.pnlWeight.Controls.Add(Me.txtTotalWeight)
        Me.pnlWeight.Controls.Add(Me.lblTotalWeight)
        Me.pnlWeight.Controls.Add(Me.tbtReturnedWeight)
        Me.pnlWeight.Location = New System.Drawing.Point(645, 22)
        Me.pnlWeight.Name = "pnlWeight"
        Me.pnlWeight.Size = New System.Drawing.Size(305, 152)
        Me.pnlWeight.TabIndex = 44
        '
        'txtReturnedWeight
        '
        Me.txtReturnedWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturnedWeight.Location = New System.Drawing.Point(19, 35)
        Me.txtReturnedWeight.Name = "txtReturnedWeight"
        Me.txtReturnedWeight.Size = New System.Drawing.Size(122, 22)
        Me.txtReturnedWeight.TabIndex = 39
        Me.txtReturnedWeight.Text = "000"
        Me.txtReturnedWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalWeight.Location = New System.Drawing.Point(19, 13)
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(122, 22)
        Me.txtTotalWeight.TabIndex = 39
        Me.txtTotalWeight.Text = "000"
        Me.txtTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(217, 6)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 50)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(429, 6)
        Me.btnDeleteInvoice.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(125, 50)
        Me.btnDeleteInvoice.TabIndex = 4
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(5, 6)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(125, 50)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(647, 8)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(125, 50)
        Me.btnView.TabIndex = 158
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.White
        Me.lblInvoiceNo.Location = New System.Drawing.Point(775, 9)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(184, 19)
        Me.lblInvoiceNo.TabIndex = 159
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoldBuyEditRemove
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(964, 661)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDeleteInvoice)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "GoldBuyEditRemove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف/تعديل المشتريات"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbData.ResumeLayout(False)
        Me.pnlPrice.ResumeLayout(False)
        Me.pnlPrice.PerformLayout()
        Me.pnlWeight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblRequired As System.Windows.Forms.Label
    Friend WithEvents tbtReturnedWeight As System.Windows.Forms.Label
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKNET As System.Windows.Forms.TextBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents gbData As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents pnlWeight As Panel
    Friend WithEvents txtReturnedWeight As Label
    Friend WithEvents txtTotalWeight As Label
    Friend WithEvents pnlPrice As Panel
    Friend WithEvents txtPrice As Label
    Friend WithEvents txtReturnPrice As Label
    Friend WithEvents txtPriceNew As Label
    Friend WithEvents lblPriceNew As Label
    Friend WithEvents btnView As Button
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents colB_gold_id As DataGridViewTextBoxColumn
    Friend WithEvents colCID As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents colKarat As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colGramPrice As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents colInvID As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents lblCashier As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents cmbCashier As ComboBox
    Friend WithEvents dtpInvoiceDate As DateTimePicker
End Class
