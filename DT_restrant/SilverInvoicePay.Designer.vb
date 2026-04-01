<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SilverInvoicePay
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SilverInvoicePay))
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtPrice = New System.Windows.Forms.LinkLabel()
        Me.txtInvoiceNo = New System.Windows.Forms.LinkLabel()
        Me.txtRemaining = New System.Windows.Forms.LinkLabel()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.RadAcc = New System.Windows.Forms.RadioButton()
        Me.RadCastm = New System.Windows.Forms.RadioButton()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.chkAutoClose = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbInvoiceDetails = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.gbPayDetails = New System.Windows.Forms.GroupBox()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblKNET = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.cmbPayMethod1 = New System.Windows.Forms.ComboBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.txtBank1 = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod4 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod3 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod2 = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod1 = New System.Windows.Forms.Label()
        Me.txtBank4 = New System.Windows.Forms.TextBox()
        Me.txtBank3 = New System.Windows.Forms.TextBox()
        Me.txtBank2 = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.BtnAddReceipt = New System.Windows.Forms.Button()
        Me.PicAddReceipt = New System.Windows.Forms.PictureBox()
        Me.pnlButtons.SuspendLayout()
        Me.gbInvoiceDetails.SuspendLayout()
        Me.gbPayDetails.SuspendLayout()
        CType(Me.PicAddReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbCredit
        '
        Me.rbCredit.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rbCredit.Location = New System.Drawing.Point(3, 91)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(51, 23)
        Me.rbCredit.TabIndex = 83
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "آجل"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'rbCash
        '
        Me.rbCash.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rbCash.Location = New System.Drawing.Point(57, 91)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(52, 23)
        Me.rbCash.TabIndex = 84
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "نقدا"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.SeaShell
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 199)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 496)
        Me.ReportViewer1.TabIndex = 87
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'txtPrice
        '
        Me.txtPrice.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtPrice.Location = New System.Drawing.Point(201, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(116, 22)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TabStop = True
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtInvoiceNo.Location = New System.Drawing.Point(349, 45)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(135, 22)
        Me.txtInvoiceNo.TabIndex = 90
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtRemaining.Location = New System.Drawing.Point(24, 45)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(124, 22)
        Me.txtRemaining.TabIndex = 92
        Me.txtRemaining.TabStop = True
        Me.txtRemaining.Text = "000"
        Me.txtRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlButtons.Controls.Add(Me.RadAcc)
        Me.pnlButtons.Controls.Add(Me.RadCastm)
        Me.pnlButtons.Controls.Add(Me.chkEngInvoice)
        Me.pnlButtons.Controls.Add(Me.chkAutoClose)
        Me.pnlButtons.Controls.Add(Me.btnPrint)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Location = New System.Drawing.Point(645, 3)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(145, 195)
        Me.pnlButtons.TabIndex = 94
        '
        'RadAcc
        '
        Me.RadAcc.Location = New System.Drawing.Point(4, 115)
        Me.RadAcc.Name = "RadAcc"
        Me.RadAcc.Size = New System.Drawing.Size(131, 29)
        Me.RadAcc.TabIndex = 99
        Me.RadAcc.TabStop = True
        Me.RadAcc.Text = "نسخة المحاسب"
        Me.RadAcc.UseVisualStyleBackColor = True
        '
        'RadCastm
        '
        Me.RadCastm.Location = New System.Drawing.Point(4, 86)
        Me.RadCastm.Name = "RadCastm"
        Me.RadCastm.Size = New System.Drawing.Size(131, 29)
        Me.RadCastm.TabIndex = 98
        Me.RadCastm.TabStop = True
        Me.RadCastm.Text = "نسخة العميل"
        Me.RadCastm.UseVisualStyleBackColor = True
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.Location = New System.Drawing.Point(3, 168)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(134, 23)
        Me.chkEngInvoice.TabIndex = 97
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'chkAutoClose
        '
        Me.chkAutoClose.Location = New System.Drawing.Point(3, 144)
        Me.chkAutoClose.Name = "chkAutoClose"
        Me.chkAutoClose.Size = New System.Drawing.Size(134, 23)
        Me.chkAutoClose.TabIndex = 96
        Me.chkAutoClose.Text = "إغلاق تلقائي"
        Me.chkAutoClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(9, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(126, 43)
        Me.btnPrint.TabIndex = 93
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSalmon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(9, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 38)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'gbInvoiceDetails
        '
        Me.gbInvoiceDetails.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbInvoiceDetails.Controls.Add(Me.Button1)
        Me.gbInvoiceDetails.Controls.Add(Me.lblRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.lblPrice)
        Me.gbInvoiceDetails.Controls.Add(Me.lblInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.txtInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtPrice)
        Me.gbInvoiceDetails.Location = New System.Drawing.Point(4, 3)
        Me.gbInvoiceDetails.Name = "gbInvoiceDetails"
        Me.gbInvoiceDetails.Size = New System.Drawing.Size(490, 75)
        Me.gbInvoiceDetails.TabIndex = 95
        Me.gbInvoiceDetails.TabStop = False
        Me.gbInvoiceDetails.Text = "بيان الفاتورة"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 10)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRemaining
        '
        Me.lblRemaining.Location = New System.Drawing.Point(24, 21)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(124, 22)
        Me.lblRemaining.TabIndex = 95
        Me.lblRemaining.Text = "المتبقي"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(201, 21)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(116, 22)
        Me.lblPrice.TabIndex = 94
        Me.lblPrice.Text = "المبلغ"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(349, 21)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(135, 22)
        Me.lblInvoiceNo.TabIndex = 93
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbPayDetails
        '
        Me.gbPayDetails.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod)
        Me.gbPayDetails.Controls.Add(Me.lblKNET)
        Me.gbPayDetails.Controls.Add(Me.lblCash)
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod1)
        Me.gbPayDetails.Controls.Add(Me.txtKnet)
        Me.gbPayDetails.Controls.Add(Me.txtBank1)
        Me.gbPayDetails.Controls.Add(Me.txtCash)
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod4)
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod3)
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod2)
        Me.gbPayDetails.Controls.Add(Me.lblPayMethod1)
        Me.gbPayDetails.Controls.Add(Me.txtBank4)
        Me.gbPayDetails.Controls.Add(Me.txtBank3)
        Me.gbPayDetails.Controls.Add(Me.txtBank2)
        Me.gbPayDetails.Controls.Add(Me.rbCash)
        Me.gbPayDetails.Controls.Add(Me.rbCredit)
        Me.gbPayDetails.Location = New System.Drawing.Point(4, 80)
        Me.gbPayDetails.Name = "gbPayDetails"
        Me.gbPayDetails.Size = New System.Drawing.Size(490, 118)
        Me.gbPayDetails.TabIndex = 96
        Me.gbPayDetails.TabStop = False
        Me.gbPayDetails.Text = "بيانات الدفع"
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(357, 83)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(128, 22)
        Me.cmbPayMethod.TabIndex = 115
        '
        'lblKNET
        '
        Me.lblKNET.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblKNET.Location = New System.Drawing.Point(357, 22)
        Me.lblKNET.Name = "lblKNET"
        Me.lblKNET.Size = New System.Drawing.Size(128, 31)
        Me.lblKNET.TabIndex = 113
        Me.lblKNET.Text = "كي نت"
        Me.lblKNET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BackColor = System.Drawing.Color.Moccasin
        Me.lblCash.Location = New System.Drawing.Point(6, 22)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(103, 31)
        Me.lblCash.TabIndex = 114
        Me.lblCash.Text = "تبديل ذهب"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCash.Visible = False
        '
        'cmbPayMethod1
        '
        Me.cmbPayMethod1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod1.FormattingEnabled = True
        Me.cmbPayMethod1.Location = New System.Drawing.Point(295, 83)
        Me.cmbPayMethod1.Name = "cmbPayMethod1"
        Me.cmbPayMethod1.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod1.TabIndex = 124
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtKnet.Location = New System.Drawing.Point(357, 55)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(128, 27)
        Me.txtKnet.TabIndex = 111
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank1
        '
        Me.txtBank1.BackColor = System.Drawing.Color.Orange
        Me.txtBank1.Location = New System.Drawing.Point(295, 55)
        Me.txtBank1.Name = "txtBank1"
        Me.txtBank1.Size = New System.Drawing.Size(61, 27)
        Me.txtBank1.TabIndex = 123
        Me.txtBank1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Moccasin
        Me.txtCash.Enabled = False
        Me.txtCash.Location = New System.Drawing.Point(6, 56)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(103, 27)
        Me.txtCash.TabIndex = 112
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Visible = False
        '
        'cmbPayMethod4
        '
        Me.cmbPayMethod4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod4.FormattingEnabled = True
        Me.cmbPayMethod4.Location = New System.Drawing.Point(112, 83)
        Me.cmbPayMethod4.Name = "cmbPayMethod4"
        Me.cmbPayMethod4.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod4.TabIndex = 122
        '
        'cmbPayMethod3
        '
        Me.cmbPayMethod3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod3.FormattingEnabled = True
        Me.cmbPayMethod3.Location = New System.Drawing.Point(173, 83)
        Me.cmbPayMethod3.Name = "cmbPayMethod3"
        Me.cmbPayMethod3.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod3.TabIndex = 121
        '
        'cmbPayMethod2
        '
        Me.cmbPayMethod2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod2.FormattingEnabled = True
        Me.cmbPayMethod2.Location = New System.Drawing.Point(234, 83)
        Me.cmbPayMethod2.Name = "cmbPayMethod2"
        Me.cmbPayMethod2.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod2.TabIndex = 120
        '
        'lblPayMethod1
        '
        Me.lblPayMethod1.BackColor = System.Drawing.SystemColors.Info
        Me.lblPayMethod1.Location = New System.Drawing.Point(112, 22)
        Me.lblPayMethod1.Name = "lblPayMethod1"
        Me.lblPayMethod1.Size = New System.Drawing.Size(244, 31)
        Me.lblPayMethod1.TabIndex = 119
        Me.lblPayMethod1.Text = "عمليات اخري"
        Me.lblPayMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBank4
        '
        Me.txtBank4.BackColor = System.Drawing.Color.Orange
        Me.txtBank4.Location = New System.Drawing.Point(112, 55)
        Me.txtBank4.Name = "txtBank4"
        Me.txtBank4.Size = New System.Drawing.Size(61, 27)
        Me.txtBank4.TabIndex = 118
        Me.txtBank4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank3
        '
        Me.txtBank3.BackColor = System.Drawing.Color.Orange
        Me.txtBank3.Location = New System.Drawing.Point(173, 55)
        Me.txtBank3.Name = "txtBank3"
        Me.txtBank3.Size = New System.Drawing.Size(61, 27)
        Me.txtBank3.TabIndex = 117
        Me.txtBank3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank2
        '
        Me.txtBank2.BackColor = System.Drawing.Color.Orange
        Me.txtBank2.Location = New System.Drawing.Point(234, 55)
        Me.txtBank2.Name = "txtBank2"
        Me.txtBank2.Size = New System.Drawing.Size(61, 27)
        Me.txtBank2.TabIndex = 116
        Me.txtBank2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(10, 644)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 154
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(831, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 155
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtReceiptNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(495, 173)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(148, 26)
        Me.txtReceiptNo.TabIndex = 157
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddReceipt
        '
        Me.BtnAddReceipt.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddReceipt.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddReceipt.Location = New System.Drawing.Point(497, 7)
        Me.BtnAddReceipt.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddReceipt.Name = "BtnAddReceipt"
        Me.BtnAddReceipt.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddReceipt.TabIndex = 156
        Me.BtnAddReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddReceipt.UseVisualStyleBackColor = False
        '
        'PicAddReceipt
        '
        Me.PicAddReceipt.BackColor = System.Drawing.Color.Pink
        Me.PicAddReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicAddReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicAddReceipt.Location = New System.Drawing.Point(495, 5)
        Me.PicAddReceipt.Name = "PicAddReceipt"
        Me.PicAddReceipt.Size = New System.Drawing.Size(148, 167)
        Me.PicAddReceipt.TabIndex = 158
        Me.PicAddReceipt.TabStop = False
        '
        'SilverInvoicePay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 705)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.BtnAddReceipt)
        Me.Controls.Add(Me.PicAddReceipt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.gbPayDetails)
        Me.Controls.Add(Me.gbInvoiceDetails)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SilverInvoicePay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الدفع الفضه"
        Me.pnlButtons.ResumeLayout(False)
        Me.gbInvoiceDetails.ResumeLayout(False)
        Me.gbPayDetails.ResumeLayout(False)
        Me.gbPayDetails.PerformLayout()
        CType(Me.PicAddReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPrice As System.Windows.Forms.LinkLabel
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtRemaining As System.Windows.Forms.LinkLabel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents gbInvoiceDetails As System.Windows.Forms.GroupBox
    Friend WithEvents gbPayDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnPDF As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents chkAutoClose As System.Windows.Forms.CheckBox
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadAcc As System.Windows.Forms.RadioButton
    Friend WithEvents RadCastm As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbPayMethod As ComboBox
    Friend WithEvents lblKNET As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents cmbPayMethod1 As ComboBox
    Friend WithEvents txtKnet As TextBox
    Friend WithEvents txtBank1 As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents cmbPayMethod4 As ComboBox
    Friend WithEvents cmbPayMethod3 As ComboBox
    Friend WithEvents cmbPayMethod2 As ComboBox
    Friend WithEvents lblPayMethod1 As Label
    Friend WithEvents txtBank4 As TextBox
    Friend WithEvents txtBank3 As TextBox
    Friend WithEvents txtBank2 As TextBox
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents BtnAddReceipt As Button
    Friend WithEvents PicAddReceipt As PictureBox
End Class
