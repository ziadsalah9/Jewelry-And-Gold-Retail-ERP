<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSnd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComSndType = New System.Windows.Forms.ComboBox()
        Me.LabSndName = New System.Windows.Forms.Label()
        Me.TxtCivilId = New System.Windows.Forms.TextBox()
        Me.LabComName = New System.Windows.Forms.Label()
        Me.Cob_Comp_nam = New System.Windows.Forms.ComboBox()
        Me.RidoComp = New System.Windows.Forms.RadioButton()
        Me.RidoPersonal = New System.Windows.Forms.RadioButton()
        Me.btnCompName = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabSndNo = New System.Windows.Forms.Label()
        Me.LabSndTxtNo = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.pnlItemDetails = New System.Windows.Forms.Panel()
        Me.PnlPyment = New System.Windows.Forms.Panel()
        Me.txtBank1 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod1 = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod1 = New System.Windows.Forms.Label()
        Me.cmbPayMethod4 = New System.Windows.Forms.ComboBox()
        Me.txtBank4 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod3 = New System.Windows.Forms.ComboBox()
        Me.txtBank3 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod2 = New System.Windows.Forms.ComboBox()
        Me.txtBank2 = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabBank = New System.Windows.Forms.Label()
        Me.TxtBank = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.TxtCash = New System.Windows.Forms.TextBox()
        Me.LabCasher = New System.Windows.Forms.Label()
        Me.ComPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.ComCasher = New System.Windows.Forms.ComboBox()
        Me.btnAddPhoto = New System.Windows.Forms.Button()
        Me.dtExpensesDate = New System.Windows.Forms.DateTimePicker()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.LabDate = New System.Windows.Forms.Label()
        Me.LabDescription = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlItemDetails.SuspendLayout()
        Me.PnlPyment.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComSndType
        '
        Me.ComSndType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComSndType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComSndType.FormattingEnabled = True
        Me.ComSndType.Location = New System.Drawing.Point(569, 28)
        Me.ComSndType.Margin = New System.Windows.Forms.Padding(4)
        Me.ComSndType.Name = "ComSndType"
        Me.ComSndType.Size = New System.Drawing.Size(160, 27)
        Me.ComSndType.TabIndex = 2
        '
        'LabSndName
        '
        Me.LabSndName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabSndName.ForeColor = System.Drawing.Color.White
        Me.LabSndName.Location = New System.Drawing.Point(535, 3)
        Me.LabSndName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSndName.Name = "LabSndName"
        Me.LabSndName.Size = New System.Drawing.Size(195, 21)
        Me.LabSndName.TabIndex = 1
        Me.LabSndName.Text = "نوع السند"
        Me.LabSndName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtCivilId
        '
        Me.TxtCivilId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtCivilId.Location = New System.Drawing.Point(1731, 763)
        Me.TxtCivilId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCivilId.Name = "TxtCivilId"
        Me.TxtCivilId.Size = New System.Drawing.Size(197, 27)
        Me.TxtCivilId.TabIndex = 0
        Me.TxtCivilId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabComName
        '
        Me.LabComName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabComName.ForeColor = System.Drawing.Color.White
        Me.LabComName.Location = New System.Drawing.Point(277, 3)
        Me.LabComName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabComName.Name = "LabComName"
        Me.LabComName.Size = New System.Drawing.Size(258, 21)
        Me.LabComName.TabIndex = 13
        Me.LabComName.Text = "اسم المورد/الشركه/الورشه"
        Me.LabComName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Cob_Comp_nam
        '
        Me.Cob_Comp_nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Cob_Comp_nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cob_Comp_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cob_Comp_nam.FormattingEnabled = True
        Me.Cob_Comp_nam.Location = New System.Drawing.Point(310, 28)
        Me.Cob_Comp_nam.Margin = New System.Windows.Forms.Padding(4)
        Me.Cob_Comp_nam.Name = "Cob_Comp_nam"
        Me.Cob_Comp_nam.Size = New System.Drawing.Size(226, 27)
        Me.Cob_Comp_nam.TabIndex = 3
        '
        'RidoComp
        '
        Me.RidoComp.Location = New System.Drawing.Point(5, 1)
        Me.RidoComp.Name = "RidoComp"
        Me.RidoComp.Size = New System.Drawing.Size(95, 23)
        Me.RidoComp.TabIndex = 1
        Me.RidoComp.TabStop = True
        Me.RidoComp.Text = "شركه"
        Me.RidoComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RidoComp.UseVisualStyleBackColor = True
        '
        'RidoPersonal
        '
        Me.RidoPersonal.Location = New System.Drawing.Point(111, 1)
        Me.RidoPersonal.Name = "RidoPersonal"
        Me.RidoPersonal.Size = New System.Drawing.Size(95, 23)
        Me.RidoPersonal.TabIndex = 0
        Me.RidoPersonal.TabStop = True
        Me.RidoPersonal.Text = "شخصي"
        Me.RidoPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RidoPersonal.UseVisualStyleBackColor = True
        '
        'btnCompName
        '
        Me.btnCompName.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCompName.ForeColor = System.Drawing.Color.Black
        Me.btnCompName.Location = New System.Drawing.Point(277, 28)
        Me.btnCompName.Name = "btnCompName"
        Me.btnCompName.Size = New System.Drawing.Size(33, 27)
        Me.btnCompName.TabIndex = 16
        Me.btnCompName.Text = "+"
        Me.btnCompName.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LabSndNo)
        Me.Panel1.Controls.Add(Me.LabSndTxtNo)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.pnlItemDetails)
        Me.Panel1.Location = New System.Drawing.Point(6, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 388)
        Me.Panel1.TabIndex = 17
        '
        'LabSndNo
        '
        Me.LabSndNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabSndNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabSndNo.Location = New System.Drawing.Point(774, 3)
        Me.LabSndNo.Name = "LabSndNo"
        Me.LabSndNo.Size = New System.Drawing.Size(181, 28)
        Me.LabSndNo.TabIndex = 71
        Me.LabSndNo.Text = "LabSndNo"
        Me.LabSndNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabSndTxtNo
        '
        Me.LabSndTxtNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabSndTxtNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabSndTxtNo.Location = New System.Drawing.Point(774, 31)
        Me.LabSndTxtNo.Name = "LabSndTxtNo"
        Me.LabSndTxtNo.Size = New System.Drawing.Size(181, 28)
        Me.LabSndTxtNo.TabIndex = 70
        Me.LabSndTxtNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(4, 4)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(170, 52)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'pnlItemDetails
        '
        Me.pnlItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlItemDetails.Controls.Add(Me.PnlPyment)
        Me.pnlItemDetails.Controls.Add(Me.TxtTotal)
        Me.pnlItemDetails.Controls.Add(Me.Button1)
        Me.pnlItemDetails.Controls.Add(Me.LabBank)
        Me.pnlItemDetails.Controls.Add(Me.TxtBank)
        Me.pnlItemDetails.Controls.Add(Me.Panel2)
        Me.pnlItemDetails.Controls.Add(Me.lblCash)
        Me.pnlItemDetails.Controls.Add(Me.btnCompName)
        Me.pnlItemDetails.Controls.Add(Me.TxtCash)
        Me.pnlItemDetails.Controls.Add(Me.LabCasher)
        Me.pnlItemDetails.Controls.Add(Me.ComPaymentMethod)
        Me.pnlItemDetails.Controls.Add(Me.ComCasher)
        Me.pnlItemDetails.Controls.Add(Me.LabComName)
        Me.pnlItemDetails.Controls.Add(Me.Cob_Comp_nam)
        Me.pnlItemDetails.Controls.Add(Me.ComSndType)
        Me.pnlItemDetails.Controls.Add(Me.btnAddPhoto)
        Me.pnlItemDetails.Controls.Add(Me.dtExpensesDate)
        Me.pnlItemDetails.Controls.Add(Me.pbPhoto)
        Me.pnlItemDetails.Controls.Add(Me.LabSndName)
        Me.pnlItemDetails.Controls.Add(Me.TxtNote)
        Me.pnlItemDetails.Controls.Add(Me.LabDate)
        Me.pnlItemDetails.Controls.Add(Me.LabDescription)
        Me.pnlItemDetails.Location = New System.Drawing.Point(3, 63)
        Me.pnlItemDetails.Name = "pnlItemDetails"
        Me.pnlItemDetails.Size = New System.Drawing.Size(954, 318)
        Me.pnlItemDetails.TabIndex = 1
        '
        'PnlPyment
        '
        Me.PnlPyment.Controls.Add(Me.txtBank1)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod1)
        Me.PnlPyment.Controls.Add(Me.lblPayMethod1)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod4)
        Me.PnlPyment.Controls.Add(Me.txtBank4)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod3)
        Me.PnlPyment.Controls.Add(Me.txtBank3)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod2)
        Me.PnlPyment.Controls.Add(Me.txtBank2)
        Me.PnlPyment.Location = New System.Drawing.Point(197, 217)
        Me.PnlPyment.Name = "PnlPyment"
        Me.PnlPyment.Size = New System.Drawing.Size(322, 94)
        Me.PnlPyment.TabIndex = 120
        '
        'txtBank1
        '
        Me.txtBank1.BackColor = System.Drawing.Color.Orange
        Me.txtBank1.Location = New System.Drawing.Point(238, 35)
        Me.txtBank1.Name = "txtBank1"
        Me.txtBank1.Size = New System.Drawing.Size(78, 27)
        Me.txtBank1.TabIndex = 118
        Me.txtBank1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod1
        '
        Me.cmbPayMethod1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod1.FormattingEnabled = True
        Me.cmbPayMethod1.Location = New System.Drawing.Point(238, 62)
        Me.cmbPayMethod1.Name = "cmbPayMethod1"
        Me.cmbPayMethod1.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod1.TabIndex = 119
        '
        'lblPayMethod1
        '
        Me.lblPayMethod1.BackColor = System.Drawing.Color.Orange
        Me.lblPayMethod1.Location = New System.Drawing.Point(4, 5)
        Me.lblPayMethod1.Name = "lblPayMethod1"
        Me.lblPayMethod1.Size = New System.Drawing.Size(312, 29)
        Me.lblPayMethod1.TabIndex = 114
        Me.lblPayMethod1.Text = "عمليات اخري"
        Me.lblPayMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPayMethod4
        '
        Me.cmbPayMethod4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod4.FormattingEnabled = True
        Me.cmbPayMethod4.Location = New System.Drawing.Point(4, 62)
        Me.cmbPayMethod4.Name = "cmbPayMethod4"
        Me.cmbPayMethod4.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod4.TabIndex = 117
        '
        'txtBank4
        '
        Me.txtBank4.BackColor = System.Drawing.Color.Orange
        Me.txtBank4.Location = New System.Drawing.Point(4, 35)
        Me.txtBank4.Name = "txtBank4"
        Me.txtBank4.Size = New System.Drawing.Size(78, 27)
        Me.txtBank4.TabIndex = 113
        Me.txtBank4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod3
        '
        Me.cmbPayMethod3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod3.FormattingEnabled = True
        Me.cmbPayMethod3.Location = New System.Drawing.Point(82, 62)
        Me.cmbPayMethod3.Name = "cmbPayMethod3"
        Me.cmbPayMethod3.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod3.TabIndex = 116
        '
        'txtBank3
        '
        Me.txtBank3.BackColor = System.Drawing.Color.Orange
        Me.txtBank3.Location = New System.Drawing.Point(82, 35)
        Me.txtBank3.Name = "txtBank3"
        Me.txtBank3.Size = New System.Drawing.Size(78, 27)
        Me.txtBank3.TabIndex = 112
        Me.txtBank3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod2
        '
        Me.cmbPayMethod2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod2.FormattingEnabled = True
        Me.cmbPayMethod2.Location = New System.Drawing.Point(160, 62)
        Me.cmbPayMethod2.Name = "cmbPayMethod2"
        Me.cmbPayMethod2.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod2.TabIndex = 115
        '
        'txtBank2
        '
        Me.txtBank2.BackColor = System.Drawing.Color.Orange
        Me.txtBank2.Location = New System.Drawing.Point(160, 35)
        Me.txtBank2.Name = "txtBank2"
        Me.txtBank2.Size = New System.Drawing.Size(78, 27)
        Me.txtBank2.TabIndex = 111
        Me.txtBank2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Transparent
        Me.TxtTotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(1, 219)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(190, 92)
        Me.TxtTotal.TabIndex = 69
        Me.TxtTotal.Text = "000"
        Me.TxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(536, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 27)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabBank
        '
        Me.LabBank.BackColor = System.Drawing.Color.Brown
        Me.LabBank.Location = New System.Drawing.Point(665, 219)
        Me.LabBank.Name = "LabBank"
        Me.LabBank.Size = New System.Drawing.Size(148, 29)
        Me.LabBank.TabIndex = 63
        Me.LabBank.Text = "المبلغ بنكي"
        Me.LabBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBank
        '
        Me.TxtBank.Location = New System.Drawing.Point(665, 251)
        Me.TxtBank.Name = "TxtBank"
        Me.TxtBank.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtBank.Size = New System.Drawing.Size(148, 27)
        Me.TxtBank.TabIndex = 8
        Me.TxtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.RidoComp)
        Me.Panel2.Controls.Add(Me.RidoPersonal)
        Me.Panel2.Location = New System.Drawing.Point(734, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 29)
        Me.Panel2.TabIndex = 70
        '
        'lblCash
        '
        Me.lblCash.BackColor = System.Drawing.Color.Turquoise
        Me.lblCash.Location = New System.Drawing.Point(815, 219)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(132, 29)
        Me.lblCash.TabIndex = 46
        Me.lblCash.Text = "المبلغ كاش"
        Me.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCash
        '
        Me.TxtCash.Location = New System.Drawing.Point(815, 251)
        Me.TxtCash.Name = "TxtCash"
        Me.TxtCash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCash.Size = New System.Drawing.Size(132, 27)
        Me.TxtCash.TabIndex = 7
        Me.TxtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabCasher
        '
        Me.LabCasher.Location = New System.Drawing.Point(122, 3)
        Me.LabCasher.Name = "LabCasher"
        Me.LabCasher.Size = New System.Drawing.Size(155, 21)
        Me.LabCasher.TabIndex = 64
        Me.LabCasher.Text = "الكاشير"
        Me.LabCasher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComPaymentMethod
        '
        Me.ComPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComPaymentMethod.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComPaymentMethod.FormattingEnabled = True
        Me.ComPaymentMethod.Location = New System.Drawing.Point(665, 281)
        Me.ComPaymentMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.ComPaymentMethod.Name = "ComPaymentMethod"
        Me.ComPaymentMethod.Size = New System.Drawing.Size(282, 27)
        Me.ComPaymentMethod.TabIndex = 9
        '
        'ComCasher
        '
        Me.ComCasher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComCasher.FormattingEnabled = True
        Me.ComCasher.Location = New System.Drawing.Point(122, 28)
        Me.ComCasher.Name = "ComCasher"
        Me.ComCasher.Size = New System.Drawing.Size(155, 27)
        Me.ComCasher.TabIndex = 4
        '
        'btnAddPhoto
        '
        Me.btnAddPhoto.AutoSize = True
        Me.btnAddPhoto.BackColor = System.Drawing.Color.LimeGreen
        Me.btnAddPhoto.ForeColor = System.Drawing.Color.Black
        Me.btnAddPhoto.Location = New System.Drawing.Point(6, 65)
        Me.btnAddPhoto.Name = "btnAddPhoto"
        Me.btnAddPhoto.Size = New System.Drawing.Size(31, 29)
        Me.btnAddPhoto.TabIndex = 11
        Me.btnAddPhoto.Text = "+"
        Me.btnAddPhoto.UseVisualStyleBackColor = False
        '
        'dtExpensesDate
        '
        Me.dtExpensesDate.CustomFormat = "dd/MM/yyyy"
        Me.dtExpensesDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtExpensesDate.Location = New System.Drawing.Point(4, 28)
        Me.dtExpensesDate.Name = "dtExpensesDate"
        Me.dtExpensesDate.Size = New System.Drawing.Size(118, 27)
        Me.dtExpensesDate.TabIndex = 5
        '
        'pbPhoto
        '
        Me.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPhoto.Location = New System.Drawing.Point(2, 61)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(189, 155)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbPhoto.TabIndex = 31
        Me.pbPhoto.TabStop = False
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(197, 94)
        Me.TxtNote.MaxLength = 255
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNote.Size = New System.Drawing.Size(750, 122)
        Me.TxtNote.TabIndex = 6
        Me.TxtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabDate
        '
        Me.LabDate.Location = New System.Drawing.Point(6, 3)
        Me.LabDate.Name = "LabDate"
        Me.LabDate.Size = New System.Drawing.Size(116, 21)
        Me.LabDate.TabIndex = 6
        Me.LabDate.Text = "التاريخ"
        Me.LabDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabDescription
        '
        Me.LabDescription.Location = New System.Drawing.Point(197, 58)
        Me.LabDescription.Name = "LabDescription"
        Me.LabDescription.Size = New System.Drawing.Size(750, 33)
        Me.LabDescription.TabIndex = 8
        Me.LabDescription.Text = "الوصف"
        Me.LabDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmSnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(976, 650)
        Me.Controls.Add(Me.TxtCivilId)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSnd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سند قبض / صرف"
        Me.Panel1.ResumeLayout(False)
        Me.pnlItemDetails.ResumeLayout(False)
        Me.pnlItemDetails.PerformLayout()
        Me.PnlPyment.ResumeLayout(False)
        Me.PnlPyment.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComSndType As ComboBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents LabSndName As Label
    Friend WithEvents TxtCivilId As TextBox
    Friend WithEvents LabComName As System.Windows.Forms.Label
    Friend WithEvents Cob_Comp_nam As System.Windows.Forms.ComboBox
    Friend WithEvents RidoComp As System.Windows.Forms.RadioButton
    Friend WithEvents RidoPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents btnCompName As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlItemDetails As System.Windows.Forms.Panel
    Friend WithEvents TxtTotal As System.Windows.Forms.Label
    Friend WithEvents LabCasher As System.Windows.Forms.Label
    Friend WithEvents ComCasher As System.Windows.Forms.ComboBox
    Friend WithEvents LabBank As System.Windows.Forms.Label
    Friend WithEvents ComPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCash As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPhoto As System.Windows.Forms.Button
    Friend WithEvents dtExpensesDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents TxtBank As System.Windows.Forms.TextBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents LabDate As System.Windows.Forms.Label
    Friend WithEvents LabDescription As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabSndNo As System.Windows.Forms.Label
    Friend WithEvents LabSndTxtNo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbPayMethod1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtBank1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbPayMethod4 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPayMethod2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayMethod1 As System.Windows.Forms.Label
    Friend WithEvents txtBank4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBank2 As System.Windows.Forms.TextBox
    Friend WithEvents PnlPyment As System.Windows.Forms.Panel
End Class
