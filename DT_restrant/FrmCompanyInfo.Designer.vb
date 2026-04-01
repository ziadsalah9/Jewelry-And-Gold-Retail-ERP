<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompanyInfo
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colModify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompanyAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLicenseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCommercialRegisterNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastEditDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCompanyAddress = New System.Windows.Forms.TextBox()
        Me.txtLicenseNumber = New System.Windows.Forms.TextBox()
        Me.txtCommercialRegisterNo = New System.Windows.Forms.TextBox()
        Me.picLicenseImage = New System.Windows.Forms.PictureBox()
        Me.dtLastEditDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCompanyAddress = New System.Windows.Forms.Label()
        Me.lblLicenseNumber = New System.Windows.Forms.Label()
        Me.lblCommercialRegisterNo = New System.Windows.Forms.Label()
        Me.BtnAddLicenseImage = New System.Windows.Forms.Button()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLicenseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(2, 54)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(126, 57)
        Me.BtnSave.TabIndex = 194
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Gray
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(2, 1)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(126, 55)
        Me.BtnAdd.TabIndex = 193
        Me.BtnAdd.Text = "اضافة"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colModify, Me.colCompanyID, Me.colCompanyName, Me.colCompanyAddress, Me.colLicenseNumber, Me.colCommercialRegisterNo, Me.colCreationDate, Me.colLastEditDate, Me.colActivite})
        Me.Grid.Location = New System.Drawing.Point(2, 146)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(798, 302)
        Me.Grid.TabIndex = 195
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 45
        '
        'colModify
        '
        Me.colModify.HeaderText = "Modify"
        Me.colModify.Name = "colModify"
        Me.colModify.ReadOnly = True
        Me.colModify.Width = 45
        '
        'colCompanyID
        '
        Me.colCompanyID.HeaderText = "CompanyID"
        Me.colCompanyID.Name = "colCompanyID"
        Me.colCompanyID.ReadOnly = True
        '
        'colCompanyName
        '
        Me.colCompanyName.HeaderText = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.ReadOnly = True
        Me.colCompanyName.Width = 200
        '
        'colCompanyAddress
        '
        Me.colCompanyAddress.HeaderText = "CompanyAddress"
        Me.colCompanyAddress.Name = "colCompanyAddress"
        Me.colCompanyAddress.ReadOnly = True
        Me.colCompanyAddress.Width = 250
        '
        'colLicenseNumber
        '
        Me.colLicenseNumber.HeaderText = "LicenseNumber"
        Me.colLicenseNumber.Name = "colLicenseNumber"
        Me.colLicenseNumber.ReadOnly = True
        Me.colLicenseNumber.Width = 150
        '
        'colCommercialRegisterNo
        '
        Me.colCommercialRegisterNo.HeaderText = "CommercialRegisterNo"
        Me.colCommercialRegisterNo.Name = "colCommercialRegisterNo"
        Me.colCommercialRegisterNo.ReadOnly = True
        Me.colCommercialRegisterNo.Width = 150
        '
        'colCreationDate
        '
        Me.colCreationDate.HeaderText = "CreationDate"
        Me.colCreationDate.Name = "colCreationDate"
        Me.colCreationDate.ReadOnly = True
        Me.colCreationDate.Visible = False
        '
        'colLastEditDate
        '
        Me.colLastEditDate.HeaderText = "LastEditDate"
        Me.colLastEditDate.Name = "colLastEditDate"
        Me.colLastEditDate.ReadOnly = True
        Me.colLastEditDate.Visible = False
        '
        'colActivite
        '
        Me.colActivite.HeaderText = "Activite"
        Me.colActivite.Name = "colActivite"
        Me.colActivite.ReadOnly = True
        Me.colActivite.Visible = False
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyName.Location = New System.Drawing.Point(476, 30)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(320, 31)
        Me.txtCompanyName.TabIndex = 196
        Me.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCompanyAddress.Location = New System.Drawing.Point(480, 112)
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.Size = New System.Drawing.Size(320, 31)
        Me.txtCompanyAddress.TabIndex = 197
        Me.txtCompanyAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLicenseNumber
        '
        Me.txtLicenseNumber.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtLicenseNumber.Location = New System.Drawing.Point(295, 30)
        Me.txtLicenseNumber.Name = "txtLicenseNumber"
        Me.txtLicenseNumber.Size = New System.Drawing.Size(185, 31)
        Me.txtLicenseNumber.TabIndex = 198
        Me.txtLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCommercialRegisterNo
        '
        Me.txtCommercialRegisterNo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txtCommercialRegisterNo.Location = New System.Drawing.Point(295, 112)
        Me.txtCommercialRegisterNo.Name = "txtCommercialRegisterNo"
        Me.txtCommercialRegisterNo.Size = New System.Drawing.Size(185, 31)
        Me.txtCommercialRegisterNo.TabIndex = 199
        Me.txtCommercialRegisterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picLicenseImage
        '
        Me.picLicenseImage.BackColor = System.Drawing.Color.LavenderBlush
        Me.picLicenseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLicenseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picLicenseImage.Location = New System.Drawing.Point(127, 4)
        Me.picLicenseImage.Name = "picLicenseImage"
        Me.picLicenseImage.Size = New System.Drawing.Size(166, 140)
        Me.picLicenseImage.TabIndex = 202
        Me.picLicenseImage.TabStop = False
        '
        'dtLastEditDate
        '
        Me.dtLastEditDate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.dtLastEditDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLastEditDate.Location = New System.Drawing.Point(2, 113)
        Me.dtLastEditDate.Name = "dtLastEditDate"
        Me.dtLastEditDate.Size = New System.Drawing.Size(126, 31)
        Me.dtLastEditDate.TabIndex = 203
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyName.Location = New System.Drawing.Point(476, 4)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(320, 23)
        Me.lblCompanyName.TabIndex = 204
        Me.lblCompanyName.Text = "اسم الشركه"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCompanyAddress
        '
        Me.lblCompanyAddress.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCompanyAddress.Location = New System.Drawing.Point(476, 86)
        Me.lblCompanyAddress.Name = "lblCompanyAddress"
        Me.lblCompanyAddress.Size = New System.Drawing.Size(320, 23)
        Me.lblCompanyAddress.TabIndex = 205
        Me.lblCompanyAddress.Text = "عنوان الشركه"
        Me.lblCompanyAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLicenseNumber
        '
        Me.lblLicenseNumber.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblLicenseNumber.Location = New System.Drawing.Point(295, 4)
        Me.lblLicenseNumber.Name = "lblLicenseNumber"
        Me.lblLicenseNumber.Size = New System.Drawing.Size(185, 23)
        Me.lblLicenseNumber.TabIndex = 206
        Me.lblLicenseNumber.Text = "رقم الرخصه"
        Me.lblLicenseNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCommercialRegisterNo
        '
        Me.lblCommercialRegisterNo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblCommercialRegisterNo.Location = New System.Drawing.Point(295, 86)
        Me.lblCommercialRegisterNo.Name = "lblCommercialRegisterNo"
        Me.lblCommercialRegisterNo.Size = New System.Drawing.Size(185, 23)
        Me.lblCommercialRegisterNo.TabIndex = 207
        Me.lblCommercialRegisterNo.Text = "رقم السجل التجاري"
        Me.lblCommercialRegisterNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnAddLicenseImage
        '
        Me.BtnAddLicenseImage.BackColor = System.Drawing.Color.Transparent
        Me.BtnAddLicenseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAddLicenseImage.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAddLicenseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddLicenseImage.Location = New System.Drawing.Point(130, 7)
        Me.BtnAddLicenseImage.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAddLicenseImage.Name = "BtnAddLicenseImage"
        Me.BtnAddLicenseImage.Size = New System.Drawing.Size(28, 28)
        Me.BtnAddLicenseImage.TabIndex = 208
        Me.BtnAddLicenseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddLicenseImage.UseVisualStyleBackColor = False
        '
        'FrmCompanyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAddLicenseImage)
        Me.Controls.Add(Me.lblCommercialRegisterNo)
        Me.Controls.Add(Me.lblLicenseNumber)
        Me.Controls.Add(Me.lblCompanyAddress)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.dtLastEditDate)
        Me.Controls.Add(Me.picLicenseImage)
        Me.Controls.Add(Me.txtCommercialRegisterNo)
        Me.Controls.Add(Me.txtLicenseNumber)
        Me.Controls.Add(Me.txtCompanyAddress)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCompanyInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCompanyInfo"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLicenseImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents txtCommercialRegisterNo As TextBox
    Friend WithEvents picLicenseImage As PictureBox
    Friend WithEvents dtLastEditDate As DateTimePicker
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCompanyAddress As Label
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents lblCommercialRegisterNo As Label
    Friend WithEvents BtnAddLicenseImage As Button
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colModify As DataGridViewButtonColumn
    Friend WithEvents colCompanyID As DataGridViewTextBoxColumn
    Friend WithEvents colCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents colCompanyAddress As DataGridViewTextBoxColumn
    Friend WithEvents colLicenseNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCommercialRegisterNo As DataGridViewTextBoxColumn
    Friend WithEvents colCreationDate As DataGridViewTextBoxColumn
    Friend WithEvents colLastEditDate As DataGridViewTextBoxColumn
    Friend WithEvents colActivite As DataGridViewTextBoxColumn
End Class
