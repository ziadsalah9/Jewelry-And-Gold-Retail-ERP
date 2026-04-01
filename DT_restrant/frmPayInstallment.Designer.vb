<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayInstallment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayInstallment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbInvoicePay = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblPayDate = New System.Windows.Forms.Label()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.gbInvoiceData = New System.Windows.Forms.GroupBox()
        Me.txtBankPaid = New System.Windows.Forms.Label()
        Me.lblBankPaid = New System.Windows.Forms.Label()
        Me.txtCashPaid = New System.Windows.Forms.Label()
        Me.lblCashPaid = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCID = New System.Windows.Forms.Label()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.lstInvoiceNo = New System.Windows.Forms.ListBox()
        Me.txtTotalPaid = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblRemianing = New System.Windows.Forms.Label()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colInvoiceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKNET = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayMethodAr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayMethodEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPayDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbInvoicePay.SuspendLayout()
        Me.gbInvoiceData.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbInvoicePay
        '
        Me.gbInvoicePay.BackColor = System.Drawing.Color.LightYellow
        Me.gbInvoicePay.Controls.Add(Me.btnPrint)
        Me.gbInvoicePay.Controls.Add(Me.cmbCashier)
        Me.gbInvoicePay.Controls.Add(Me.lblCashier)
        Me.gbInvoicePay.Controls.Add(Me.DateTimePicker1)
        Me.gbInvoicePay.Controls.Add(Me.lblPayDate)
        Me.gbInvoicePay.Controls.Add(Me.lblPayMethod)
        Me.gbInvoicePay.Controls.Add(Me.btnSave)
        Me.gbInvoicePay.Controls.Add(Me.cmbPayMethod)
        Me.gbInvoicePay.Controls.Add(Me.lblCash)
        Me.gbInvoicePay.Controls.Add(Me.lblBank)
        Me.gbInvoicePay.Controls.Add(Me.txtCash)
        Me.gbInvoicePay.Controls.Add(Me.txtBank)
        Me.gbInvoicePay.Location = New System.Drawing.Point(5, 3)
        Me.gbInvoicePay.Name = "gbInvoicePay"
        Me.gbInvoicePay.Size = New System.Drawing.Size(240, 253)
        Me.gbInvoicePay.TabIndex = 99
        Me.gbInvoicePay.TabStop = False
        Me.gbInvoicePay.Text = "بيانات الدفع"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(12, 194)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(109, 52)
        Me.btnPrint.TabIndex = 102
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(12, 63)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(109, 27)
        Me.cmbCashier.TabIndex = 101
        '
        'lblCashier
        '
        Me.lblCashier.Location = New System.Drawing.Point(127, 63)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(82, 27)
        Me.lblCashier.TabIndex = 100
        Me.lblCashier.Text = "الكاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 27)
        Me.DateTimePicker1.TabIndex = 99
        '
        'lblPayDate
        '
        Me.lblPayDate.Location = New System.Drawing.Point(127, 36)
        Me.lblPayDate.Name = "lblPayDate"
        Me.lblPayDate.Size = New System.Drawing.Size(82, 27)
        Me.lblPayDate.TabIndex = 98
        Me.lblPayDate.Text = "تاريخ الدفع"
        Me.lblPayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayMethod
        '
        Me.lblPayMethod.Location = New System.Drawing.Point(127, 158)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(82, 27)
        Me.lblPayMethod.TabIndex = 97
        Me.lblPayMethod.Text = "الطريقة"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(125, 194)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 52)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(12, 158)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(109, 27)
        Me.cmbPayMethod.TabIndex = 96
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(127, 104)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(82, 27)
        Me.lblCash.TabIndex = 95
        Me.lblCash.Text = "كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(127, 131)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(82, 27)
        Me.lblBank.TabIndex = 94
        Me.lblBank.Text = "بنكي"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCash.ForeColor = System.Drawing.Color.Red
        Me.txtCash.Location = New System.Drawing.Point(12, 104)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(109, 27)
        Me.txtCash.TabIndex = 17
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtBank.ForeColor = System.Drawing.Color.Red
        Me.txtBank.Location = New System.Drawing.Point(12, 131)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(109, 27)
        Me.txtBank.TabIndex = 16
        Me.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbInvoiceData
        '
        Me.gbInvoiceData.BackColor = System.Drawing.Color.LightYellow
        Me.gbInvoiceData.Controls.Add(Me.txtBankPaid)
        Me.gbInvoiceData.Controls.Add(Me.lblBankPaid)
        Me.gbInvoiceData.Controls.Add(Me.txtCashPaid)
        Me.gbInvoiceData.Controls.Add(Me.lblCashPaid)
        Me.gbInvoiceData.Controls.Add(Me.txtCustomerName)
        Me.gbInvoiceData.Controls.Add(Me.lblCustomerName)
        Me.gbInvoiceData.Controls.Add(Me.txtCID)
        Me.gbInvoiceData.Controls.Add(Me.lblCID)
        Me.gbInvoiceData.Controls.Add(Me.lstInvoiceNo)
        Me.gbInvoiceData.Controls.Add(Me.txtTotalPaid)
        Me.gbInvoiceData.Controls.Add(Me.txtRemaining)
        Me.gbInvoiceData.Controls.Add(Me.txtPrice)
        Me.gbInvoiceData.Controls.Add(Me.lblPaid)
        Me.gbInvoiceData.Controls.Add(Me.lblRemianing)
        Me.gbInvoiceData.Controls.Add(Me.lblInvNo)
        Me.gbInvoiceData.Controls.Add(Me.lblPrice)
        Me.gbInvoiceData.Location = New System.Drawing.Point(248, 3)
        Me.gbInvoiceData.Name = "gbInvoiceData"
        Me.gbInvoiceData.Size = New System.Drawing.Size(721, 253)
        Me.gbInvoiceData.TabIndex = 98
        Me.gbInvoiceData.TabStop = False
        Me.gbInvoiceData.Text = "بيان الفاتورة"
        '
        'txtBankPaid
        '
        Me.txtBankPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBankPaid.Location = New System.Drawing.Point(108, 149)
        Me.txtBankPaid.Name = "txtBankPaid"
        Me.txtBankPaid.Size = New System.Drawing.Size(256, 27)
        Me.txtBankPaid.TabIndex = 108
        Me.txtBankPaid.Text = "000"
        Me.txtBankPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBankPaid
        '
        Me.lblBankPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBankPaid.Location = New System.Drawing.Point(366, 149)
        Me.lblBankPaid.Name = "lblBankPaid"
        Me.lblBankPaid.Size = New System.Drawing.Size(135, 27)
        Me.lblBankPaid.TabIndex = 107
        Me.lblBankPaid.Text = "المدفوع - بنكي"
        Me.lblBankPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCashPaid
        '
        Me.txtCashPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCashPaid.Location = New System.Drawing.Point(108, 120)
        Me.txtCashPaid.Name = "txtCashPaid"
        Me.txtCashPaid.Size = New System.Drawing.Size(256, 27)
        Me.txtCashPaid.TabIndex = 106
        Me.txtCashPaid.Text = "000"
        Me.txtCashPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashPaid
        '
        Me.lblCashPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCashPaid.Location = New System.Drawing.Point(366, 120)
        Me.lblCashPaid.Name = "lblCashPaid"
        Me.lblCashPaid.Size = New System.Drawing.Size(135, 27)
        Me.lblCashPaid.TabIndex = 105
        Me.lblCashPaid.Text = "المدفوع - كاش"
        Me.lblCashPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomerName.ForeColor = System.Drawing.Color.Blue
        Me.txtCustomerName.Location = New System.Drawing.Point(108, 62)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(256, 27)
        Me.txtCustomerName.TabIndex = 104
        Me.txtCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerName
        '
        Me.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustomerName.Location = New System.Drawing.Point(366, 62)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(135, 27)
        Me.lblCustomerName.TabIndex = 103
        Me.lblCustomerName.Text = "اسم العميل"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCID
        '
        Me.txtCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCID.ForeColor = System.Drawing.Color.Blue
        Me.txtCID.Location = New System.Drawing.Point(108, 33)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(256, 27)
        Me.txtCID.TabIndex = 102
        Me.txtCID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCID
        '
        Me.lblCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCID.Location = New System.Drawing.Point(366, 33)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(135, 27)
        Me.lblCID.TabIndex = 101
        Me.lblCID.Text = "الرقم المدني"
        Me.lblCID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstInvoiceNo
        '
        Me.lstInvoiceNo.FormattingEnabled = True
        Me.lstInvoiceNo.ItemHeight = 19
        Me.lstInvoiceNo.Location = New System.Drawing.Point(566, 49)
        Me.lstInvoiceNo.Name = "lstInvoiceNo"
        Me.lstInvoiceNo.ScrollAlwaysVisible = True
        Me.lstInvoiceNo.Size = New System.Drawing.Size(138, 175)
        Me.lstInvoiceNo.TabIndex = 100
        '
        'txtTotalPaid
        '
        Me.txtTotalPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotalPaid.Location = New System.Drawing.Point(108, 178)
        Me.txtTotalPaid.Name = "txtTotalPaid"
        Me.txtTotalPaid.Size = New System.Drawing.Size(256, 27)
        Me.txtTotalPaid.TabIndex = 99
        Me.txtTotalPaid.Text = "000"
        Me.txtTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemaining.ForeColor = System.Drawing.Color.Red
        Me.txtRemaining.Location = New System.Drawing.Point(108, 207)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(256, 27)
        Me.txtRemaining.TabIndex = 98
        Me.txtRemaining.Text = "000"
        Me.txtRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(108, 91)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(256, 27)
        Me.txtPrice.TabIndex = 97
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPaid
        '
        Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaid.Location = New System.Drawing.Point(366, 178)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(135, 27)
        Me.lblPaid.TabIndex = 96
        Me.lblPaid.Text = "إجمالي المدفوع"
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRemianing
        '
        Me.lblRemianing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemianing.Location = New System.Drawing.Point(366, 207)
        Me.lblRemianing.Name = "lblRemianing"
        Me.lblRemianing.Size = New System.Drawing.Size(135, 27)
        Me.lblRemianing.TabIndex = 93
        Me.lblRemianing.Text = "المبلغ المتبقي"
        Me.lblRemianing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvNo
        '
        Me.lblInvNo.Location = New System.Drawing.Point(566, 24)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(138, 22)
        Me.lblInvNo.TabIndex = 91
        Me.lblInvNo.Text = "أرقام الفواتير"
        Me.lblInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(366, 91)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(135, 27)
        Me.lblPrice.TabIndex = 92
        Me.lblPrice.Text = "مبلغ الفاتورة"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceNo, Me.colInvoiceType, Me.colPayPrice, Me.colCash, Me.colKNET, Me.colPayMethodAr, Me.colPayMethodEn, Me.colPayDateTime, Me.colCashier, Me.colActive})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.Location = New System.Drawing.Point(5, 262)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 10
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(964, 354)
        Me.grid.TabIndex = 100
        '
        'colInvoiceNo
        '
        Me.colInvoiceNo.HeaderText = "رقم الفاتورة"
        Me.colInvoiceNo.Name = "colInvoiceNo"
        Me.colInvoiceNo.ReadOnly = True
        '
        'colInvoiceType
        '
        Me.colInvoiceType.HeaderText = "النوع"
        Me.colInvoiceType.Name = "colInvoiceType"
        Me.colInvoiceType.ReadOnly = True
        Me.colInvoiceType.Visible = False
        '
        'colPayPrice
        '
        Me.colPayPrice.HeaderText = "المدفوع"
        Me.colPayPrice.Name = "colPayPrice"
        Me.colPayPrice.ReadOnly = True
        '
        'colCash
        '
        Me.colCash.HeaderText = "الكاش"
        Me.colCash.Name = "colCash"
        Me.colCash.ReadOnly = True
        '
        'colKNET
        '
        Me.colKNET.HeaderText = "البنك"
        Me.colKNET.Name = "colKNET"
        Me.colKNET.ReadOnly = True
        '
        'colPayMethodAr
        '
        Me.colPayMethodAr.HeaderText = "طريقة الدفع البنكي"
        Me.colPayMethodAr.Name = "colPayMethodAr"
        Me.colPayMethodAr.ReadOnly = True
        '
        'colPayMethodEn
        '
        Me.colPayMethodEn.HeaderText = "Bank Pay By"
        Me.colPayMethodEn.Name = "colPayMethodEn"
        Me.colPayMethodEn.ReadOnly = True
        '
        'colPayDateTime
        '
        Me.colPayDateTime.FillWeight = 150.0!
        Me.colPayDateTime.HeaderText = "التاريخ والوقت"
        Me.colPayDateTime.Name = "colPayDateTime"
        Me.colPayDateTime.ReadOnly = True
        '
        'colCashier
        '
        Me.colCashier.HeaderText = "الكاشير"
        Me.colCashier.Name = "colCashier"
        Me.colCashier.ReadOnly = True
        '
        'colActive
        '
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Visible = False
        '
        'frmPayInstallment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(974, 621)
        Me.Controls.Add(Me.gbInvoicePay)
        Me.Controls.Add(Me.gbInvoiceData)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayInstallment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الدفع الآجل"
        Me.gbInvoicePay.ResumeLayout(False)
        Me.gbInvoicePay.PerformLayout()
        Me.gbInvoiceData.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbInvoicePay As System.Windows.Forms.GroupBox
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents gbInvoiceData As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
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
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalPaid As Label
    Friend WithEvents txtRemaining As Label
    Friend WithEvents txtPrice As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents lstInvoiceNo As ListBox
    Friend WithEvents txtCustomerName As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents txtCID As Label
    Friend WithEvents lblCID As Label
    Friend WithEvents lblPayDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblCashier As Label
    Friend WithEvents cmbCashier As ComboBox
    Friend WithEvents txtBankPaid As Label
    Friend WithEvents lblBankPaid As Label
    Friend WithEvents txtCashPaid As Label
    Friend WithEvents lblCashPaid As Label
    Friend WithEvents colInvoiceNo As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceType As DataGridViewTextBoxColumn
    Friend WithEvents colPayPrice As DataGridViewTextBoxColumn
    Friend WithEvents colCash As DataGridViewTextBoxColumn
    Friend WithEvents colKNET As DataGridViewTextBoxColumn
    Friend WithEvents colPayMethodAr As DataGridViewTextBoxColumn
    Friend WithEvents colPayMethodEn As DataGridViewTextBoxColumn
    Friend WithEvents colPayDateTime As DataGridViewTextBoxColumn
    Friend WithEvents colCashier As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
End Class
