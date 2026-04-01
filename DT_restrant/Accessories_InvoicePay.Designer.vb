<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accessories_InvoicePay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accessories_InvoicePay))
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.gbInvoiceDetails = New System.Windows.Forms.GroupBox()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.txtRemaining = New System.Windows.Forms.LinkLabel()
        Me.txtInvoiceNo = New System.Windows.Forms.LinkLabel()
        Me.txtPrice = New System.Windows.Forms.LinkLabel()
        Me.gbPayDetails = New System.Windows.Forms.GroupBox()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.cmbPayMethod = New System.Windows.Forms.ComboBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblKNET = New System.Windows.Forms.Label()
        Me.rbCash = New System.Windows.Forms.RadioButton()
        Me.rbCredit = New System.Windows.Forms.RadioButton()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtKNET = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.chkAutoClose = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.gbInvoiceDetails.SuspendLayout()
        Me.gbPayDetails.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbInvoiceDetails
        '
        Me.gbInvoiceDetails.BackColor = System.Drawing.Color.Sienna
        Me.gbInvoiceDetails.Controls.Add(Me.lblRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.lblPrice)
        Me.gbInvoiceDetails.Controls.Add(Me.lblInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtRemaining)
        Me.gbInvoiceDetails.Controls.Add(Me.txtInvoiceNo)
        Me.gbInvoiceDetails.Controls.Add(Me.txtPrice)
        Me.gbInvoiceDetails.Location = New System.Drawing.Point(4, 3)
        Me.gbInvoiceDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.gbInvoiceDetails.Name = "gbInvoiceDetails"
        Me.gbInvoiceDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.gbInvoiceDetails.Size = New System.Drawing.Size(636, 75)
        Me.gbInvoiceDetails.TabIndex = 150
        Me.gbInvoiceDetails.TabStop = False
        Me.gbInvoiceDetails.Text = "بيان الفاتورة"
        '
        'lblRemaining
        '
        Me.lblRemaining.Location = New System.Drawing.Point(8, 21)
        Me.lblRemaining.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(200, 22)
        Me.lblRemaining.TabIndex = 95
        Me.lblRemaining.Text = "متبقي"
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(218, 21)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(200, 22)
        Me.lblPrice.TabIndex = 94
        Me.lblPrice.Text = "المبلغ"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(428, 21)
        Me.lblInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(200, 22)
        Me.lblInvoiceNo.TabIndex = 93
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRemaining
        '
        Me.txtRemaining.LinkColor = System.Drawing.Color.AliceBlue
        Me.txtRemaining.Location = New System.Drawing.Point(8, 45)
        Me.txtRemaining.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.txtInvoiceNo.Location = New System.Drawing.Point(428, 45)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPrice.TabIndex = 89
        Me.txtPrice.TabStop = True
        Me.txtPrice.Text = "000"
        Me.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbPayDetails
        '
        Me.gbPayDetails.BackColor = System.Drawing.Color.Sienna
        Me.gbPayDetails.Controls.Add(Me.lblPayMethod)
        Me.gbPayDetails.Controls.Add(Me.cmbPayMethod)
        Me.gbPayDetails.Controls.Add(Me.lblCash)
        Me.gbPayDetails.Controls.Add(Me.lblKNET)
        Me.gbPayDetails.Controls.Add(Me.rbCash)
        Me.gbPayDetails.Controls.Add(Me.rbCredit)
        Me.gbPayDetails.Controls.Add(Me.txtCash)
        Me.gbPayDetails.Controls.Add(Me.txtKNET)
        Me.gbPayDetails.Location = New System.Drawing.Point(4, 80)
        Me.gbPayDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.gbPayDetails.Name = "gbPayDetails"
        Me.gbPayDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.gbPayDetails.Size = New System.Drawing.Size(636, 99)
        Me.gbPayDetails.TabIndex = 151
        Me.gbPayDetails.TabStop = False
        Me.gbPayDetails.Text = "بيانات الدفع"
        '
        'lblPayMethod
        '
        Me.lblPayMethod.Location = New System.Drawing.Point(547, 71)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(82, 22)
        Me.lblPayMethod.TabIndex = 99
        Me.lblPayMethod.Text = "الطريقة"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPayMethod
        '
        Me.cmbPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod.FormattingEnabled = True
        Me.cmbPayMethod.Location = New System.Drawing.Point(429, 69)
        Me.cmbPayMethod.Name = "cmbPayMethod"
        Me.cmbPayMethod.Size = New System.Drawing.Size(115, 27)
        Me.cmbPayMethod.TabIndex = 98
        '
        'lblCash
        '
        Me.lblCash.Location = New System.Drawing.Point(218, 14)
        Me.lblCash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(200, 22)
        Me.lblCash.TabIndex = 97
        Me.lblCash.Text = "كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKNET
        '
        Me.lblKNET.Location = New System.Drawing.Point(424, 14)
        Me.lblKNET.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKNET.Name = "lblKNET"
        Me.lblKNET.Size = New System.Drawing.Size(200, 22)
        Me.lblKNET.TabIndex = 96
        Me.lblKNET.Text = "بنكي"
        Me.lblKNET.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbCash
        '
        Me.rbCash.AutoSize = True
        Me.rbCash.Location = New System.Drawing.Point(112, 33)
        Me.rbCash.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCash.Name = "rbCash"
        Me.rbCash.Size = New System.Drawing.Size(49, 23)
        Me.rbCash.TabIndex = 84
        Me.rbCash.TabStop = True
        Me.rbCash.Text = "نقدا"
        Me.rbCash.UseVisualStyleBackColor = True
        '
        'rbCredit
        '
        Me.rbCredit.AutoSize = True
        Me.rbCredit.Location = New System.Drawing.Point(30, 33)
        Me.rbCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.rbCredit.Name = "rbCredit"
        Me.rbCredit.Size = New System.Drawing.Size(51, 23)
        Me.rbCredit.TabIndex = 83
        Me.rbCredit.TabStop = True
        Me.rbCredit.Text = "آجل"
        Me.rbCredit.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtCash.Location = New System.Drawing.Point(218, 39)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(200, 27)
        Me.txtCash.TabIndex = 17
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtKNET
        '
        Me.txtKNET.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtKNET.Location = New System.Drawing.Point(429, 39)
        Me.txtKNET.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKNET.Name = "txtKNET"
        Me.txtKNET.Size = New System.Drawing.Size(200, 27)
        Me.txtKNET.TabIndex = 16
        Me.txtKNET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.Controls.Add(Me.chkEngInvoice)
        Me.Panel1.Controls.Add(Me.chkAutoClose)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Location = New System.Drawing.Point(645, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(145, 176)
        Me.Panel1.TabIndex = 149
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.AutoSize = True
        Me.chkEngInvoice.Location = New System.Drawing.Point(21, 144)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(106, 23)
        Me.chkEngInvoice.TabIndex = 100
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'chkAutoClose
        '
        Me.chkAutoClose.AutoSize = True
        Me.chkAutoClose.Location = New System.Drawing.Point(21, 119)
        Me.chkAutoClose.Name = "chkAutoClose"
        Me.chkAutoClose.Size = New System.Drawing.Size(93, 23)
        Me.chkAutoClose.TabIndex = 99
        Me.chkAutoClose.Text = "إغلاق تلقائي"
        Me.chkAutoClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(9, 59)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(126, 52)
        Me.btnPrint.TabIndex = 93
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(9, 5)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(126, 52)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource2.Name = "DataSet1"
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptAccessories_Invoice_A4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(4, 180)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(786, 437)
        Me.ReportViewer1.TabIndex = 153
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Accessories_InvoicePay
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(793, 621)
        Me.Controls.Add(Me.gbPayDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.gbInvoiceDetails)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accessories_InvoicePay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دفع وطباعة الفاتورة"
        Me.gbInvoiceDetails.ResumeLayout(False)
        Me.gbPayDetails.ResumeLayout(False)
        Me.gbPayDetails.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbInvoiceDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents txtRemaining As System.Windows.Forms.LinkLabel
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPrice As System.Windows.Forms.LinkLabel
    Friend WithEvents gbPayDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblKNET As System.Windows.Forms.Label
    Friend WithEvents rbCash As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents txtKNET As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoClose As System.Windows.Forms.CheckBox
    Friend WithEvents lblPayMethod As System.Windows.Forms.Label
    Friend WithEvents cmbPayMethod As System.Windows.Forms.ComboBox
End Class
