<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditDelete))
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteInvoice = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmbInvNo = New System.Windows.Forms.ComboBox()
        Me.pnlItemDetails = New System.Windows.Forms.Panel()
        Me.laltotal = New System.Windows.Forms.Label()
        Me.LabSndNo = New System.Windows.Forms.Label()
        Me.btnCashVoucherShow = New System.Windows.Forms.Button()
        Me.CmbCashVoucherNo = New System.Windows.Forms.ComboBox()
        Me.LabCasher = New System.Windows.Forms.Label()
        Me.ComCasher = New System.Windows.Forms.ComboBox()
        Me.LabBank = New System.Windows.Forms.Label()
        Me.ComPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.LabPayMethod = New System.Windows.Forms.Label()
        Me.txtExpensesKNETValue = New System.Windows.Forms.TextBox()
        Me.btnExpensesPhoto = New System.Windows.Forms.Button()
        Me.dtExpensesDate = New System.Windows.Forms.DateTimePicker()
        Me.pbExpensesPhoto = New System.Windows.Forms.PictureBox()
        Me.btnItemName = New System.Windows.Forms.Button()
        Me.cmbExpensesType = New System.Windows.Forms.ComboBox()
        Me.labCash = New System.Windows.Forms.Label()
        Me.txtExpensesCashValue = New System.Windows.Forms.TextBox()
        Me.txtExpensesDescription = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.labDate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlItemDetails.SuspendLayout()
        CType(Me.pbExpensesPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(414, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(135, 55)
        Me.btnView.TabIndex = 92
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.ForeColor = System.Drawing.Color.Black
        Me.lblInvoiceNo.Location = New System.Drawing.Point(551, 3)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(182, 27)
        Me.lblInvoiceNo.TabIndex = 97
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(6, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(135, 55)
        Me.btnPrint.TabIndex = 96
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(142, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 55)
        Me.btnSave.TabIndex = 95
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.BackColor = System.Drawing.Color.LightCoral
        Me.btnDeleteInvoice.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteInvoice.Location = New System.Drawing.Point(278, 5)
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Size = New System.Drawing.Size(135, 55)
        Me.btnDeleteInvoice.TabIndex = 94
        Me.btnDeleteInvoice.Text = "حذف الفاتورة"
        Me.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteInvoice.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CmbInvNo)
        Me.Panel1.Controls.Add(Me.lblInvoiceNo)
        Me.Panel1.Controls.Add(Me.btnDeleteInvoice)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 76)
        Me.Panel1.TabIndex = 98
        '
        'CmbInvNo
        '
        Me.CmbInvNo.FormattingEnabled = True
        Me.CmbInvNo.Location = New System.Drawing.Point(551, 30)
        Me.CmbInvNo.Name = "CmbInvNo"
        Me.CmbInvNo.Size = New System.Drawing.Size(182, 27)
        Me.CmbInvNo.TabIndex = 99
        '
        'pnlItemDetails
        '
        Me.pnlItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlItemDetails.Controls.Add(Me.laltotal)
        Me.pnlItemDetails.Controls.Add(Me.LabSndNo)
        Me.pnlItemDetails.Controls.Add(Me.btnCashVoucherShow)
        Me.pnlItemDetails.Controls.Add(Me.CmbCashVoucherNo)
        Me.pnlItemDetails.Controls.Add(Me.LabCasher)
        Me.pnlItemDetails.Controls.Add(Me.ComCasher)
        Me.pnlItemDetails.Controls.Add(Me.LabBank)
        Me.pnlItemDetails.Controls.Add(Me.ComPaymentMethod)
        Me.pnlItemDetails.Controls.Add(Me.LabPayMethod)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesKNETValue)
        Me.pnlItemDetails.Controls.Add(Me.btnExpensesPhoto)
        Me.pnlItemDetails.Controls.Add(Me.dtExpensesDate)
        Me.pnlItemDetails.Controls.Add(Me.pbExpensesPhoto)
        Me.pnlItemDetails.Controls.Add(Me.btnItemName)
        Me.pnlItemDetails.Controls.Add(Me.cmbExpensesType)
        Me.pnlItemDetails.Controls.Add(Me.labCash)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesCashValue)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesDescription)
        Me.pnlItemDetails.Controls.Add(Me.lblCategory)
        Me.pnlItemDetails.Controls.Add(Me.labDate)
        Me.pnlItemDetails.Controls.Add(Me.lblDescription)
        Me.pnlItemDetails.Location = New System.Drawing.Point(5, 86)
        Me.pnlItemDetails.Name = "pnlItemDetails"
        Me.pnlItemDetails.Size = New System.Drawing.Size(739, 265)
        Me.pnlItemDetails.TabIndex = 101
        '
        'laltotal
        '
        Me.laltotal.BackColor = System.Drawing.Color.Moccasin
        Me.laltotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laltotal.Location = New System.Drawing.Point(3, 187)
        Me.laltotal.Name = "laltotal"
        Me.laltotal.Size = New System.Drawing.Size(129, 62)
        Me.laltotal.TabIndex = 69
        Me.laltotal.Text = "000"
        Me.laltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabSndNo
        '
        Me.LabSndNo.Location = New System.Drawing.Point(155, 0)
        Me.LabSndNo.Name = "LabSndNo"
        Me.LabSndNo.Size = New System.Drawing.Size(112, 22)
        Me.LabSndNo.TabIndex = 68
        Me.LabSndNo.Text = "التصنيف"
        Me.LabSndNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCashVoucherShow
        '
        Me.btnCashVoucherShow.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.btnCashVoucherShow.Location = New System.Drawing.Point(126, 28)
        Me.btnCashVoucherShow.Name = "btnCashVoucherShow"
        Me.btnCashVoucherShow.Size = New System.Drawing.Size(27, 29)
        Me.btnCashVoucherShow.TabIndex = 67
        Me.btnCashVoucherShow.UseVisualStyleBackColor = True
        '
        'CmbCashVoucherNo
        '
        Me.CmbCashVoucherNo.FormattingEnabled = True
        Me.CmbCashVoucherNo.Location = New System.Drawing.Point(155, 29)
        Me.CmbCashVoucherNo.Name = "CmbCashVoucherNo"
        Me.CmbCashVoucherNo.Size = New System.Drawing.Size(112, 26)
        Me.CmbCashVoucherNo.TabIndex = 65
        '
        'LabCasher
        '
        Me.LabCasher.Location = New System.Drawing.Point(554, 0)
        Me.LabCasher.Name = "LabCasher"
        Me.LabCasher.Size = New System.Drawing.Size(180, 22)
        Me.LabCasher.TabIndex = 64
        Me.LabCasher.Text = "الكاشير"
        Me.LabCasher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComCasher
        '
        Me.ComCasher.FormattingEnabled = True
        Me.ComCasher.Location = New System.Drawing.Point(555, 29)
        Me.ComCasher.Name = "ComCasher"
        Me.ComCasher.Size = New System.Drawing.Size(173, 26)
        Me.ComCasher.TabIndex = 45
        '
        'LabBank
        '
        Me.LabBank.BackColor = System.Drawing.Color.Brown
        Me.LabBank.Location = New System.Drawing.Point(628, 187)
        Me.LabBank.Name = "LabBank"
        Me.LabBank.Size = New System.Drawing.Size(100, 33)
        Me.LabBank.TabIndex = 63
        Me.LabBank.Text = "المبلغ كاش"
        Me.LabBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComPaymentMethod
        '
        Me.ComPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPaymentMethod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComPaymentMethod.FormattingEnabled = True
        Me.ComPaymentMethod.Location = New System.Drawing.Point(416, 222)
        Me.ComPaymentMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.ComPaymentMethod.Name = "ComPaymentMethod"
        Me.ComPaymentMethod.Size = New System.Drawing.Size(106, 27)
        Me.ComPaymentMethod.TabIndex = 46
        '
        'LabPayMethod
        '
        Me.LabPayMethod.BackColor = System.Drawing.Color.Brown
        Me.LabPayMethod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabPayMethod.ForeColor = System.Drawing.Color.White
        Me.LabPayMethod.Location = New System.Drawing.Point(416, 187)
        Me.LabPayMethod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabPayMethod.Name = "LabPayMethod"
        Me.LabPayMethod.Size = New System.Drawing.Size(106, 33)
        Me.LabPayMethod.TabIndex = 45
        Me.LabPayMethod.Text = "طريقة الدفع"
        Me.LabPayMethod.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtExpensesKNETValue
        '
        Me.txtExpensesKNETValue.Location = New System.Drawing.Point(628, 223)
        Me.txtExpensesKNETValue.Name = "txtExpensesKNETValue"
        Me.txtExpensesKNETValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesKNETValue.Size = New System.Drawing.Size(100, 26)
        Me.txtExpensesKNETValue.TabIndex = 62
        Me.txtExpensesKNETValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExpensesPhoto
        '
        Me.btnExpensesPhoto.Location = New System.Drawing.Point(5, 65)
        Me.btnExpensesPhoto.Name = "btnExpensesPhoto"
        Me.btnExpensesPhoto.Size = New System.Drawing.Size(27, 29)
        Me.btnExpensesPhoto.TabIndex = 11
        Me.btnExpensesPhoto.Text = "+"
        Me.btnExpensesPhoto.UseVisualStyleBackColor = True
        '
        'dtExpensesDate
        '
        Me.dtExpensesDate.CustomFormat = "dd/MM/yyyy"
        Me.dtExpensesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpensesDate.Location = New System.Drawing.Point(6, 29)
        Me.dtExpensesDate.Name = "dtExpensesDate"
        Me.dtExpensesDate.Size = New System.Drawing.Size(118, 26)
        Me.dtExpensesDate.TabIndex = 61
        '
        'pbExpensesPhoto
        '
        Me.pbExpensesPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbExpensesPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbExpensesPhoto.Location = New System.Drawing.Point(3, 63)
        Me.pbExpensesPhoto.Name = "pbExpensesPhoto"
        Me.pbExpensesPhoto.Size = New System.Drawing.Size(192, 123)
        Me.pbExpensesPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExpensesPhoto.TabIndex = 31
        Me.pbExpensesPhoto.TabStop = False
        '
        'btnItemName
        '
        Me.btnItemName.Location = New System.Drawing.Point(267, 28)
        Me.btnItemName.Name = "btnItemName"
        Me.btnItemName.Size = New System.Drawing.Size(27, 29)
        Me.btnItemName.TabIndex = 51
        Me.btnItemName.Text = "+"
        Me.btnItemName.UseVisualStyleBackColor = True
        '
        'cmbExpensesType
        '
        Me.cmbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExpensesType.FormattingEnabled = True
        Me.cmbExpensesType.Location = New System.Drawing.Point(294, 29)
        Me.cmbExpensesType.Name = "cmbExpensesType"
        Me.cmbExpensesType.Size = New System.Drawing.Size(259, 26)
        Me.cmbExpensesType.TabIndex = 0
        '
        'labCash
        '
        Me.labCash.BackColor = System.Drawing.Color.Turquoise
        Me.labCash.Location = New System.Drawing.Point(525, 187)
        Me.labCash.Name = "labCash"
        Me.labCash.Size = New System.Drawing.Size(100, 33)
        Me.labCash.TabIndex = 46
        Me.labCash.Text = "المبلغ كاش"
        Me.labCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExpensesCashValue
        '
        Me.txtExpensesCashValue.Location = New System.Drawing.Point(525, 223)
        Me.txtExpensesCashValue.Name = "txtExpensesCashValue"
        Me.txtExpensesCashValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesCashValue.Size = New System.Drawing.Size(100, 26)
        Me.txtExpensesCashValue.TabIndex = 2
        Me.txtExpensesCashValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExpensesDescription
        '
        Me.txtExpensesDescription.BackColor = System.Drawing.Color.White
        Me.txtExpensesDescription.Location = New System.Drawing.Point(198, 105)
        Me.txtExpensesDescription.MaxLength = 255
        Me.txtExpensesDescription.Multiline = True
        Me.txtExpensesDescription.Name = "txtExpensesDescription"
        Me.txtExpensesDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesDescription.Size = New System.Drawing.Size(530, 81)
        Me.txtExpensesDescription.TabIndex = 10
        Me.txtExpensesDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(294, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(259, 22)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "التصنيف"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDate
        '
        Me.labDate.Location = New System.Drawing.Point(6, 0)
        Me.labDate.Name = "labDate"
        Me.labDate.Size = New System.Drawing.Size(118, 27)
        Me.labDate.TabIndex = 6
        Me.labDate.Text = "التاريخ"
        Me.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(198, 65)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(530, 37)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "الوصف"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEditDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(749, 356)
        Me.Controls.Add(Me.pnlItemDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEditDelete"
        Me.Panel1.ResumeLayout(False)
        Me.pnlItemDetails.ResumeLayout(False)
        Me.pnlItemDetails.PerformLayout()
        CType(Me.pbExpensesPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDeleteInvoice As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbInvNo As System.Windows.Forms.ComboBox
    Friend WithEvents pnlItemDetails As System.Windows.Forms.Panel
    Friend WithEvents laltotal As System.Windows.Forms.Label
    Friend WithEvents LabSndNo As System.Windows.Forms.Label
    Friend WithEvents btnCashVoucherShow As System.Windows.Forms.Button
    Friend WithEvents CmbCashVoucherNo As System.Windows.Forms.ComboBox
    Friend WithEvents LabCasher As System.Windows.Forms.Label
    Friend WithEvents ComCasher As System.Windows.Forms.ComboBox
    Friend WithEvents LabBank As System.Windows.Forms.Label
    Friend WithEvents ComPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents LabPayMethod As System.Windows.Forms.Label
    Friend WithEvents txtExpensesKNETValue As System.Windows.Forms.TextBox
    Friend WithEvents btnExpensesPhoto As System.Windows.Forms.Button
    Friend WithEvents dtExpensesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbExpensesPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnItemName As System.Windows.Forms.Button
    Friend WithEvents cmbExpensesType As System.Windows.Forms.ComboBox
    Friend WithEvents labCash As System.Windows.Forms.Label
    Friend WithEvents txtExpensesCashValue As System.Windows.Forms.TextBox
    Friend WithEvents txtExpensesDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents labDate As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
End Class
