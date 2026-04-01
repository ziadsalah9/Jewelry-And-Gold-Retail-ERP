<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Expenses))
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnlItemDetails = New System.Windows.Forms.Panel()
        Me.laltotal = New System.Windows.Forms.Label()
        Me.LabSndNo = New System.Windows.Forms.Label()
        Me.btnCashVoucherShow = New System.Windows.Forms.Button()
        Me.CmbCashVoucherNo = New System.Windows.Forms.ComboBox()
        Me.LabCasher = New System.Windows.Forms.Label()
        Me.ComCasher = New System.Windows.Forms.ComboBox()
        Me.LabBank = New System.Windows.Forms.Label()
        Me.ComPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.lblKNET = New System.Windows.Forms.Label()
        Me.txtExpensesKNETValue = New System.Windows.Forms.TextBox()
        Me.btnExpensesPhoto = New System.Windows.Forms.Button()
        Me.dtExpensesDate = New System.Windows.Forms.DateTimePicker()
        Me.pbExpensesPhoto = New System.Windows.Forms.PictureBox()
        Me.btnItemName = New System.Windows.Forms.Button()
        Me.cmbExpensesType = New System.Windows.Forms.ComboBox()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.txtExpensesCashValue = New System.Windows.Forms.TextBox()
        Me.txtExpensesDescription = New System.Windows.Forms.TextBox()
        Me.labExpeNo = New System.Windows.Forms.Label()
        Me.labExpInvNo = New System.Windows.Forms.Label()
        Me.btnItemNew = New System.Windows.Forms.Button()
        Me.btnItemSave = New System.Windows.Forms.Button()
        Me.pnlItemDetails.SuspendLayout()
        CType(Me.pbExpensesPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(6, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(118, 27)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "التاريخ"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(198, 59)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(530, 28)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "الوصف"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.pnlItemDetails.Controls.Add(Me.lblKNET)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesKNETValue)
        Me.pnlItemDetails.Controls.Add(Me.btnExpensesPhoto)
        Me.pnlItemDetails.Controls.Add(Me.dtExpensesDate)
        Me.pnlItemDetails.Controls.Add(Me.pbExpensesPhoto)
        Me.pnlItemDetails.Controls.Add(Me.btnItemName)
        Me.pnlItemDetails.Controls.Add(Me.cmbExpensesType)
        Me.pnlItemDetails.Controls.Add(Me.lblCash)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesCashValue)
        Me.pnlItemDetails.Controls.Add(Me.txtExpensesDescription)
        Me.pnlItemDetails.Controls.Add(Me.lblCategory)
        Me.pnlItemDetails.Controls.Add(Me.lblDate)
        Me.pnlItemDetails.Controls.Add(Me.lblDescription)
        Me.pnlItemDetails.Location = New System.Drawing.Point(12, 61)
        Me.pnlItemDetails.Name = "pnlItemDetails"
        Me.pnlItemDetails.Size = New System.Drawing.Size(739, 253)
        Me.pnlItemDetails.TabIndex = 4
        '
        'laltotal
        '
        Me.laltotal.BackColor = System.Drawing.Color.Moccasin
        Me.laltotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laltotal.Location = New System.Drawing.Point(198, 187)
        Me.laltotal.Name = "laltotal"
        Me.laltotal.Size = New System.Drawing.Size(129, 59)
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
        Me.CmbCashVoucherNo.Size = New System.Drawing.Size(112, 27)
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
        Me.ComCasher.Size = New System.Drawing.Size(173, 27)
        Me.ComCasher.TabIndex = 45
        '
        'LabBank
        '
        Me.LabBank.BackColor = System.Drawing.Color.Brown
        Me.LabBank.Location = New System.Drawing.Point(619, 187)
        Me.LabBank.Name = "LabBank"
        Me.LabBank.Size = New System.Drawing.Size(108, 33)
        Me.LabBank.TabIndex = 63
        Me.LabBank.Text = "المبلغ كاش"
        Me.LabBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComPaymentMethod
        '
        Me.ComPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPaymentMethod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComPaymentMethod.FormattingEnabled = True
        Me.ComPaymentMethod.Location = New System.Drawing.Point(476, 222)
        Me.ComPaymentMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.ComPaymentMethod.Name = "ComPaymentMethod"
        Me.ComPaymentMethod.Size = New System.Drawing.Size(141, 27)
        Me.ComPaymentMethod.TabIndex = 46
        '
        'lblKNET
        '
        Me.lblKNET.BackColor = System.Drawing.Color.Brown
        Me.lblKNET.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblKNET.ForeColor = System.Drawing.Color.White
        Me.lblKNET.Location = New System.Drawing.Point(476, 187)
        Me.lblKNET.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKNET.Name = "lblKNET"
        Me.lblKNET.Size = New System.Drawing.Size(141, 33)
        Me.lblKNET.TabIndex = 45
        Me.lblKNET.Text = "طريقة الدفع"
        Me.lblKNET.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtExpensesKNETValue
        '
        Me.txtExpensesKNETValue.Location = New System.Drawing.Point(619, 222)
        Me.txtExpensesKNETValue.Name = "txtExpensesKNETValue"
        Me.txtExpensesKNETValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesKNETValue.Size = New System.Drawing.Size(108, 27)
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
        Me.dtExpensesDate.Size = New System.Drawing.Size(118, 27)
        Me.dtExpensesDate.TabIndex = 61
        '
        'pbExpensesPhoto
        '
        Me.pbExpensesPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbExpensesPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbExpensesPhoto.Location = New System.Drawing.Point(3, 63)
        Me.pbExpensesPhoto.Name = "pbExpensesPhoto"
        Me.pbExpensesPhoto.Size = New System.Drawing.Size(192, 186)
        Me.pbExpensesPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        Me.cmbExpensesType.Size = New System.Drawing.Size(259, 27)
        Me.cmbExpensesType.TabIndex = 0
        '
        'lblCash
        '
        Me.lblCash.BackColor = System.Drawing.Color.Turquoise
        Me.lblCash.Location = New System.Drawing.Point(333, 187)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(140, 33)
        Me.lblCash.TabIndex = 46
        Me.lblCash.Text = "المبلغ كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExpensesCashValue
        '
        Me.txtExpensesCashValue.Location = New System.Drawing.Point(333, 222)
        Me.txtExpensesCashValue.Name = "txtExpensesCashValue"
        Me.txtExpensesCashValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesCashValue.Size = New System.Drawing.Size(140, 27)
        Me.txtExpensesCashValue.TabIndex = 2
        Me.txtExpensesCashValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExpensesDescription
        '
        Me.txtExpensesDescription.Location = New System.Drawing.Point(198, 92)
        Me.txtExpensesDescription.MaxLength = 255
        Me.txtExpensesDescription.Multiline = True
        Me.txtExpensesDescription.Name = "txtExpensesDescription"
        Me.txtExpensesDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExpensesDescription.Size = New System.Drawing.Size(530, 94)
        Me.txtExpensesDescription.TabIndex = 10
        Me.txtExpensesDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labExpeNo
        '
        Me.labExpeNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labExpeNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labExpeNo.Location = New System.Drawing.Point(16, 30)
        Me.labExpeNo.Name = "labExpeNo"
        Me.labExpeNo.Size = New System.Drawing.Size(89, 28)
        Me.labExpeNo.TabIndex = 68
        Me.labExpeNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labExpInvNo
        '
        Me.labExpInvNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labExpInvNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.labExpInvNo.Location = New System.Drawing.Point(16, 2)
        Me.labExpInvNo.Name = "labExpInvNo"
        Me.labExpInvNo.Size = New System.Drawing.Size(89, 28)
        Me.labExpInvNo.TabIndex = 69
        Me.labExpInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnItemNew
        '
        Me.btnItemNew.BackColor = System.Drawing.Color.White
        Me.btnItemNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnItemNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemNew.Location = New System.Drawing.Point(616, 10)
        Me.btnItemNew.Name = "btnItemNew"
        Me.btnItemNew.Size = New System.Drawing.Size(135, 45)
        Me.btnItemNew.TabIndex = 0
        Me.btnItemNew.Text = "إضافة جديد"
        Me.btnItemNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemNew.UseVisualStyleBackColor = False
        '
        'btnItemSave
        '
        Me.btnItemSave.BackColor = System.Drawing.Color.White
        Me.btnItemSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnItemSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItemSave.Location = New System.Drawing.Point(378, 10)
        Me.btnItemSave.Name = "btnItemSave"
        Me.btnItemSave.Size = New System.Drawing.Size(135, 45)
        Me.btnItemSave.TabIndex = 3
        Me.btnItemSave.Text = "حفظ"
        Me.btnItemSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItemSave.UseVisualStyleBackColor = False
        '
        'Expenses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(754, 318)
        Me.Controls.Add(Me.labExpInvNo)
        Me.Controls.Add(Me.labExpeNo)
        Me.Controls.Add(Me.pnlItemDetails)
        Me.Controls.Add(Me.btnItemNew)
        Me.Controls.Add(Me.btnItemSave)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Expenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المصروفات"
        Me.pnlItemDetails.ResumeLayout(False)
        Me.pnlItemDetails.PerformLayout()
        CType(Me.pbExpensesPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnItemSave As System.Windows.Forms.Button
    Friend WithEvents btnItemNew As System.Windows.Forms.Button
    Friend WithEvents txtExpensesDescription As System.Windows.Forms.TextBox
    Friend WithEvents pbExpensesPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnExpensesPhoto As System.Windows.Forms.Button
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents pnlItemDetails As System.Windows.Forms.Panel
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents txtExpensesCashValue As System.Windows.Forms.TextBox
    Friend WithEvents btnItemName As Button
    Friend WithEvents cmbExpensesType As ComboBox
    Friend WithEvents dtExpensesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents colExpensesValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtExpensesKNETValue As System.Windows.Forms.TextBox
    Friend WithEvents ComPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents lblKNET As System.Windows.Forms.Label
    Friend WithEvents LabBank As System.Windows.Forms.Label
    Friend WithEvents ComCasher As System.Windows.Forms.ComboBox
    Friend WithEvents LabCasher As System.Windows.Forms.Label
    Friend WithEvents CmbCashVoucherNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnCashVoucherShow As System.Windows.Forms.Button
    Friend WithEvents labExpeNo As System.Windows.Forms.Label
    Friend WithEvents LabSndNo As System.Windows.Forms.Label
    Friend WithEvents labExpInvNo As System.Windows.Forms.Label
    Friend WithEvents laltotal As System.Windows.Forms.Label
End Class
