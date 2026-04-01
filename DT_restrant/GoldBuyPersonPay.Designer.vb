<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldBuyPersonPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoldBuyPersonPay))
        Me.ReportGoldBuyInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.gbInvoiceDetails = New System.Windows.Forms.GroupBox()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.LinkLabel()
        Me.txtInvoiceNo = New System.Windows.Forms.LinkLabel()
        Me.txtPrice = New System.Windows.Forms.LinkLabel()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKnet = New System.Windows.Forms.TextBox()
        Me.gbPayDetails = New System.Windows.Forms.GroupBox()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblKNET = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.cmbPayMethod1 = New System.Windows.Forms.ComboBox()
        Me.txtBank1 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod4 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod3 = New System.Windows.Forms.ComboBox()
        Me.cmbPayMethod2 = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod1 = New System.Windows.Forms.Label()
        Me.txtBank4 = New System.Windows.Forms.TextBox()
        Me.txtBank3 = New System.Windows.Forms.TextBox()
        Me.txtBank2 = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.RadAcc = New System.Windows.Forms.RadioButton()
        Me.RadCastm = New System.Windows.Forms.RadioButton()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.chkAutoClose = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Bay_idTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_goled_monyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaryalTextBox = New System.Windows.Forms.TextBox()
        Me.Total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.CachTextBox = New System.Windows.Forms.TextBox()
        Me.KenetTextBox = New System.Windows.Forms.TextBox()
        Me.ArabikTextBox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerNAmeLabel1 = New System.Windows.Forms.Label()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CastomerTETextBox = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.PicAddReceipt = New System.Windows.Forms.PictureBox()
        Me.BtnAddReceipt = New System.Windows.Forms.Button()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.btnwhasapp_send_pdf = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.INV_ActvTextBox = New System.Windows.Forms.TextBox()
        Me.CashierTextBox = New System.Windows.Forms.TextBox()
        Me.EnglishTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR158TextBox = New System.Windows.Forms.TextBox()
        Me.TIME_INVTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_goled_monyTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.bay_goled_monyTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.ReportGoldBuyInvoiceTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.ReportGoldBuyInvoiceTableAdapter()
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        CType(Me.ReportGoldBuyInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInvoiceDetails.SuspendLayout()
        Me.gbPayDetails.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.Bay_goled_monyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAddReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportGoldBuyInvoiceBindingSource
        '
        Me.ReportGoldBuyInvoiceBindingSource.DataMember = "ReportGoldBuyInvoice"
        Me.ReportGoldBuyInvoiceBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbInvoiceDetails
        '
        Me.gbInvoiceDetails.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbInvoiceDetails.Controls.Add(Me.lblRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.lblPrice)
        Me.gbInvoiceDetails.Controls.Add(Me.lblInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.txtInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtPrice)
        Me.gbInvoiceDetails.Location = New System.Drawing.Point(1, 3)
        Me.gbInvoiceDetails.Name = "gbInvoiceDetails"
        Me.gbInvoiceDetails.Size = New System.Drawing.Size(489, 75)
        Me.gbInvoiceDetails.TabIndex = 95
        Me.gbInvoiceDetails.TabStop = False
        Me.gbInvoiceDetails.Text = "بيان الفاتورة"
        '
        'lblRemaining
        '
        Me.lblRemaining.Location = New System.Drawing.Point(8, 21)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(151, 22)
        Me.lblRemaining.TabIndex = 95
        Me.lblRemaining.Text = "المتبقي"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(159, 21)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(152, 22)
        Me.lblPrice.TabIndex = 94
        Me.lblPrice.Text = "المبلغ"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(311, 21)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(133, 22)
        Me.lblInvoiceNo.TabIndex = 93
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtRemaining.Location = New System.Drawing.Point(8, 45)
        Me.txtRemaining.Name = "txtRemaining"
        Me.txtRemaining.Size = New System.Drawing.Size(151, 22)
        Me.txtRemaining.TabIndex = 92
        Me.txtRemaining.TabStop = True
        Me.txtRemaining.Text = "000"
        Me.txtRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.txtInvoiceNo.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtInvoiceNo.Location = New System.Drawing.Point(311, 45)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(133, 22)
        Me.txtInvoiceNo.TabIndex = 90
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtPrice.Location = New System.Drawing.Point(159, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(152, 22)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TabStop = True
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbCash
        '
        Me.rbCash.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rbCash.Location = New System.Drawing.Point(54, 83)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(54, 23)
        Me.rbCash.TabIndex = 84
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "نقدا"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rbCredit.Location = New System.Drawing.Point(5, 83)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(43, 23)
        Me.rbCredit.TabIndex = 83
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "آجل"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Moccasin
        Me.txtCash.Enabled = False
        Me.txtCash.Location = New System.Drawing.Point(5, 52)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(103, 27)
        Me.txtCash.TabIndex = 17
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.Visible = False
        '
        'txtKnet
        '
        Me.txtKnet.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtKnet.Location = New System.Drawing.Point(356, 51)
        Me.txtKnet.Name = "txtKnet"
        Me.txtKnet.Size = New System.Drawing.Size(132, 27)
        Me.txtKnet.TabIndex = 16
        Me.txtKnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.gbPayDetails.Location = New System.Drawing.Point(1, 80)
        Me.gbPayDetails.Name = "gbPayDetails"
        Me.gbPayDetails.Size = New System.Drawing.Size(489, 118)
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
        Me.cmbPayMethod.Location = New System.Drawing.Point(356, 79)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(132, 22)
        Me.cmbPayMethod.TabIndex = 98
        '
        'lblKNET
        '
        Me.lblKNET.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblKNET.Location = New System.Drawing.Point(356, 18)
        Me.lblKNET.Name = "lblKNET"
        Me.lblKNET.Size = New System.Drawing.Size(132, 31)
        Me.lblKNET.TabIndex = 85
        Me.lblKNET.Text = "كي نت"
        Me.lblKNET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCash
        '
        Me.lblCash.BackColor = System.Drawing.Color.Moccasin
        Me.lblCash.Location = New System.Drawing.Point(5, 18)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(103, 31)
        Me.lblCash.TabIndex = 86
        Me.lblCash.Text = "كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCash.Visible = False
        '
        'cmbPayMethod1
        '
        Me.cmbPayMethod1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod1.FormattingEnabled = True
        Me.cmbPayMethod1.Location = New System.Drawing.Point(294, 79)
        Me.cmbPayMethod1.Name = "cmbPayMethod1"
        Me.cmbPayMethod1.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod1.TabIndex = 110
        '
        'txtBank1
        '
        Me.txtBank1.BackColor = System.Drawing.Color.Orange
        Me.txtBank1.Location = New System.Drawing.Point(294, 51)
        Me.txtBank1.Name = "txtBank1"
        Me.txtBank1.Size = New System.Drawing.Size(61, 27)
        Me.txtBank1.TabIndex = 109
        Me.txtBank1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod4
        '
        Me.cmbPayMethod4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod4.FormattingEnabled = True
        Me.cmbPayMethod4.Location = New System.Drawing.Point(111, 79)
        Me.cmbPayMethod4.Name = "cmbPayMethod4"
        Me.cmbPayMethod4.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod4.TabIndex = 108
        '
        'cmbPayMethod3
        '
        Me.cmbPayMethod3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod3.FormattingEnabled = True
        Me.cmbPayMethod3.Location = New System.Drawing.Point(172, 79)
        Me.cmbPayMethod3.Name = "cmbPayMethod3"
        Me.cmbPayMethod3.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod3.TabIndex = 107
        '
        'cmbPayMethod2
        '
        Me.cmbPayMethod2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayMethod2.FormattingEnabled = True
        Me.cmbPayMethod2.Location = New System.Drawing.Point(233, 79)
        Me.cmbPayMethod2.Name = "cmbPayMethod2"
        Me.cmbPayMethod2.Size = New System.Drawing.Size(61, 22)
        Me.cmbPayMethod2.TabIndex = 106
        '
        'lblPayMethod1
        '
        Me.lblPayMethod1.BackColor = System.Drawing.SystemColors.Info
        Me.lblPayMethod1.Location = New System.Drawing.Point(111, 18)
        Me.lblPayMethod1.Name = "lblPayMethod1"
        Me.lblPayMethod1.Size = New System.Drawing.Size(244, 31)
        Me.lblPayMethod1.TabIndex = 105
        Me.lblPayMethod1.Text = "عمليات اخري"
        Me.lblPayMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBank4
        '
        Me.txtBank4.BackColor = System.Drawing.Color.Orange
        Me.txtBank4.Location = New System.Drawing.Point(111, 51)
        Me.txtBank4.Name = "txtBank4"
        Me.txtBank4.Size = New System.Drawing.Size(61, 27)
        Me.txtBank4.TabIndex = 104
        Me.txtBank4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank3
        '
        Me.txtBank3.BackColor = System.Drawing.Color.Orange
        Me.txtBank3.Location = New System.Drawing.Point(172, 51)
        Me.txtBank3.Name = "txtBank3"
        Me.txtBank3.Size = New System.Drawing.Size(61, 27)
        Me.txtBank3.TabIndex = 102
        Me.txtBank3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBank2
        '
        Me.txtBank2.BackColor = System.Drawing.Color.Orange
        Me.txtBank2.Location = New System.Drawing.Point(233, 51)
        Me.txtBank2.Name = "txtBank2"
        Me.txtBank2.Size = New System.Drawing.Size(61, 27)
        Me.txtBank2.TabIndex = 100
        Me.txtBank2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.pnlButtons.Size = New System.Drawing.Size(116, 195)
        Me.pnlButtons.TabIndex = 94
        '
        'RadAcc
        '
        Me.RadAcc.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadAcc.Location = New System.Drawing.Point(2, 117)
        Me.RadAcc.Name = "RadAcc"
        Me.RadAcc.Size = New System.Drawing.Size(113, 29)
        Me.RadAcc.TabIndex = 99
        Me.RadAcc.TabStop = True
        Me.RadAcc.Text = "نسخة المحاسب"
        Me.RadAcc.UseVisualStyleBackColor = True
        '
        'RadCastm
        '
        Me.RadCastm.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadCastm.Location = New System.Drawing.Point(2, 86)
        Me.RadCastm.Name = "RadCastm"
        Me.RadCastm.Size = New System.Drawing.Size(113, 29)
        Me.RadCastm.TabIndex = 98
        Me.RadCastm.TabStop = True
        Me.RadCastm.Text = "نسخة العميل"
        Me.RadCastm.UseVisualStyleBackColor = True
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkEngInvoice.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkEngInvoice.Location = New System.Drawing.Point(2, 150)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(113, 29)
        Me.chkEngInvoice.TabIndex = 99
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.UseVisualStyleBackColor = False
        '
        'chkAutoClose
        '
        Me.chkAutoClose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkAutoClose.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkAutoClose.Location = New System.Drawing.Point(2, 150)
        Me.chkAutoClose.Name = "chkAutoClose"
        Me.chkAutoClose.Size = New System.Drawing.Size(113, 29)
        Me.chkAutoClose.TabIndex = 96
        Me.chkAutoClose.Text = "إغلاق تلقائي"
        Me.chkAutoClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(2, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(111, 43)
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
        Me.btnSave.Location = New System.Drawing.Point(2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 38)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.SeaShell
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ReportGoldBuyInvoiceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptGoldBuyPay.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 199)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(760, 500)
        Me.ReportViewer1.TabIndex = 87
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Bay_idTextBox
        '
        Me.Bay_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "bay_id", True))
        Me.Bay_idTextBox.Location = New System.Drawing.Point(-40, 121)
        Me.Bay_idTextBox.Name = "Bay_idTextBox"
        Me.Bay_idTextBox.Size = New System.Drawing.Size(47, 27)
        Me.Bay_idTextBox.TabIndex = 102
        '
        'Bay_goled_monyBindingSource
        '
        Me.Bay_goled_monyBindingSource.DataMember = "bay_goled_mony"
        Me.Bay_goled_monyBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'SaryalTextBox
        '
        Me.SaryalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaryalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "saryal", True))
        Me.SaryalTextBox.Location = New System.Drawing.Point(-40, 148)
        Me.SaryalTextBox.Name = "SaryalTextBox"
        Me.SaryalTextBox.Size = New System.Drawing.Size(47, 27)
        Me.SaryalTextBox.TabIndex = 104
        '
        'Total_priceTextBox
        '
        Me.Total_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "total_price", True))
        Me.Total_priceTextBox.Location = New System.Drawing.Point(-40, 175)
        Me.Total_priceTextBox.Name = "Total_priceTextBox"
        Me.Total_priceTextBox.Size = New System.Drawing.Size(47, 27)
        Me.Total_priceTextBox.TabIndex = 106
        '
        'CachTextBox
        '
        Me.CachTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CachTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "cach", True))
        Me.CachTextBox.Location = New System.Drawing.Point(-93, 40)
        Me.CachTextBox.Name = "CachTextBox"
        Me.CachTextBox.Size = New System.Drawing.Size(47, 27)
        Me.CachTextBox.TabIndex = 108
        '
        'KenetTextBox
        '
        Me.KenetTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KenetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "kenet", True))
        Me.KenetTextBox.Location = New System.Drawing.Point(-93, 67)
        Me.KenetTextBox.Name = "KenetTextBox"
        Me.KenetTextBox.Size = New System.Drawing.Size(47, 27)
        Me.KenetTextBox.TabIndex = 110
        '
        'ArabikTextBox
        '
        Me.ArabikTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArabikTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "arabik", True))
        Me.ArabikTextBox.Location = New System.Drawing.Point(-93, 94)
        Me.ArabikTextBox.Name = "ArabikTextBox"
        Me.ArabikTextBox.Size = New System.Drawing.Size(47, 27)
        Me.ArabikTextBox.TabIndex = 112
        '
        'DateTextBox
        '
        Me.DateTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(-93, 148)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(47, 27)
        Me.DateTextBox.TabIndex = 114
        '
        'CastomerNAmeLabel1
        '
        Me.CastomerNAmeLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerNAmeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportGoldBuyInvoiceBindingSource, "CastomerNAme", True))
        Me.CastomerNAmeLabel1.Location = New System.Drawing.Point(-93, 175)
        Me.CastomerNAmeLabel1.Name = "CastomerNAmeLabel1"
        Me.CastomerNAmeLabel1.Size = New System.Drawing.Size(47, 27)
        Me.CastomerNAmeLabel1.TabIndex = 147
        Me.CastomerNAmeLabel1.Text = "CastomerNAmeLabel1"
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR148", True))
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-40, 94)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(47, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 149
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'CastomerTETextBox
        '
        Me.CastomerTETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportGoldBuyInvoiceBindingSource, "CastomerTE", True))
        Me.CastomerTETextBox.Location = New System.Drawing.Point(-93, 202)
        Me.CastomerTETextBox.Name = "CastomerTETextBox"
        Me.CastomerTETextBox.Size = New System.Drawing.Size(47, 27)
        Me.CastomerTETextBox.TabIndex = 150
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(13, 646)
        Me.btnPDF.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(45, 45)
        Me.btnPDF.TabIndex = 154
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'PicAddReceipt
        '
        Me.PicAddReceipt.BackColor = System.Drawing.Color.Pink
        Me.PicAddReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicAddReceipt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicAddReceipt.Location = New System.Drawing.Point(495, 3)
        Me.PicAddReceipt.Name = "PicAddReceipt"
        Me.PicAddReceipt.Size = New System.Drawing.Size(148, 167)
        Me.PicAddReceipt.TabIndex = 111
        Me.PicAddReceipt.TabStop = False
        '
        'BtnAddReceipt
        '
        Me.BtnAddReceipt.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddReceipt.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddReceipt.Location = New System.Drawing.Point(497, 5)
        Me.BtnAddReceipt.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddReceipt.Name = "BtnAddReceipt"
        Me.BtnAddReceipt.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddReceipt.TabIndex = 100
        Me.BtnAddReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddReceipt.UseVisualStyleBackColor = False
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtReceiptNo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(495, 171)
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(148, 26)
        Me.txtReceiptNo.TabIndex = 111
        Me.txtReceiptNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnwhasapp_send_pdf
        '
        Me.btnwhasapp_send_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btnwhasapp_send_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnwhasapp_send_pdf.Location = New System.Drawing.Point(710, 646)
        Me.btnwhasapp_send_pdf.Margin = New System.Windows.Forms.Padding(0)
        Me.btnwhasapp_send_pdf.Name = "btnwhasapp_send_pdf"
        Me.btnwhasapp_send_pdf.Size = New System.Drawing.Size(45, 45)
        Me.btnwhasapp_send_pdf.TabIndex = 155
        Me.btnwhasapp_send_pdf.UseVisualStyleBackColor = False
        Me.btnwhasapp_send_pdf.Visible = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.INV_ActvTextBox)
        Me.pnl.Controls.Add(Me.CashierTextBox)
        Me.pnl.Controls.Add(Me.EnglishTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR158TextBox)
        Me.pnl.Controls.Add(Me.TIME_INVTextBox)
        Me.pnl.Controls.Add(Me.ArabikTextBox)
        Me.pnl.Controls.Add(Me.KenetTextBox)
        Me.pnl.Controls.Add(Me.CachTextBox)
        Me.pnl.Controls.Add(Me.CastomerTETextBox)
        Me.pnl.Controls.Add(Me.Total_priceTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.SaryalTextBox)
        Me.pnl.Controls.Add(Me.Bay_idTextBox)
        Me.pnl.Controls.Add(Me.CastomerNAmeLabel1)
        Me.pnl.Controls.Add(Me.DateTextBox)
        Me.pnl.Location = New System.Drawing.Point(1258, 39)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(52, 39)
        Me.pnl.TabIndex = 158
        '
        'INV_ActvTextBox
        '
        Me.INV_ActvTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.INV_ActvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "INV_Actv", True))
        Me.INV_ActvTextBox.Location = New System.Drawing.Point(-40, 229)
        Me.INV_ActvTextBox.Name = "INV_ActvTextBox"
        Me.INV_ActvTextBox.Size = New System.Drawing.Size(47, 27)
        Me.INV_ActvTextBox.TabIndex = 162
        '
        'CashierTextBox
        '
        Me.CashierTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CashierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "Cashier", True))
        Me.CashierTextBox.Location = New System.Drawing.Point(-40, 202)
        Me.CashierTextBox.Name = "CashierTextBox"
        Me.CashierTextBox.Size = New System.Drawing.Size(47, 27)
        Me.CashierTextBox.TabIndex = 161
        '
        'EnglishTextBox
        '
        Me.EnglishTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "English", True))
        Me.EnglishTextBox.Location = New System.Drawing.Point(-93, 121)
        Me.EnglishTextBox.Name = "EnglishTextBox"
        Me.EnglishTextBox.Size = New System.Drawing.Size(47, 27)
        Me.EnglishTextBox.TabIndex = 160
        '
        'SET_INVARCHR158TextBox
        '
        Me.SET_INVARCHR158TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR158TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR158", True))
        Me.SET_INVARCHR158TextBox.Location = New System.Drawing.Point(-93, 229)
        Me.SET_INVARCHR158TextBox.Name = "SET_INVARCHR158TextBox"
        Me.SET_INVARCHR158TextBox.Size = New System.Drawing.Size(47, 27)
        Me.SET_INVARCHR158TextBox.TabIndex = 159
        '
        'TIME_INVTextBox
        '
        Me.TIME_INVTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TIME_INVTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Bay_goled_monyBindingSource, "TIME_INV", True))
        Me.TIME_INVTextBox.Location = New System.Drawing.Point(-40, 67)
        Me.TIME_INVTextBox.Name = "TIME_INVTextBox"
        Me.TIME_INVTextBox.Size = New System.Drawing.Size(47, 27)
        Me.TIME_INVTextBox.TabIndex = 158
        '
        'Bay_goled_monyTableAdapter
        '
        Me.Bay_goled_monyTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Me.Bay_goled_monyTableAdapter
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
        'ReportGoldBuyInvoiceTableAdapter
        '
        Me.ReportGoldBuyInvoiceTableAdapter.ClearBeforeFill = True
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'GoldBuyPersonPay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 700)
        Me.Controls.Add(Me.btnwhasapp_send_pdf)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.BtnAddReceipt)
        Me.Controls.Add(Me.PicAddReceipt)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.gbPayDetails)
        Me.Controls.Add(Me.gbInvoiceDetails)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pnl)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GoldBuyPersonPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيان فاتورة شراء"
        CType(Me.ReportGoldBuyInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInvoiceDetails.ResumeLayout(False)
        Me.gbPayDetails.ResumeLayout(False)
        Me.gbPayDetails.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.Bay_goled_monyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAddReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbInvoiceDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemaining As System.Windows.Forms.LinkLabel
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPrice As System.Windows.Forms.LinkLabel
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKnet As System.Windows.Forms.TextBox
    Friend WithEvents gbPayDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Bay_goled_monyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bay_goled_monyTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.bay_goled_monyTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Bay_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SaryalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CachTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KenetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ArabikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportGoldBuyInvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportGoldBuyInvoiceTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.ReportGoldBuyInvoiceTableAdapter
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblKNET As System.Windows.Forms.Label
    Friend WithEvents CastomerNAmeLabel1 As System.Windows.Forms.Label
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR148TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastomerTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoClose As System.Windows.Forms.CheckBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents pnl As Panel
    Friend WithEvents TIME_INVTextBox As TextBox
    Friend WithEvents SET_INVARCHR158TextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
    Friend WithEvents EnglishTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents INV_ActvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RadAcc As RadioButton
    Friend WithEvents RadCastm As RadioButton
    Friend WithEvents cmbPayMethod1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtBank1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbPayMethod4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayMethod1 As System.Windows.Forms.Label
    Friend WithEvents txtBank4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank2 As System.Windows.Forms.TextBox
    Friend WithEvents PicAddReceipt As PictureBox
    Friend WithEvents BtnAddReceipt As Button
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents btnwhasapp_send_pdf As Button
End Class
