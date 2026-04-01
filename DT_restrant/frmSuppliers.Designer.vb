<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colModify = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colBranchID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompanyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLicenseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCommercialRegisterNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreationDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastEditDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesCivilID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeCreationDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.txtTelNumber = New System.Windows.Forms.TextBox()
        Me.txtCommercialRegisterNo = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.lblCommercialRegister = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.lblAdre = New System.Windows.Forms.Label()
        Me.txtBranchAddress = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPreviousItem = New System.Windows.Forms.Button()
        Me.btnNextItem = New System.Windows.Forms.Button()
        Me.btnFirstItem = New System.Windows.Forms.Button()
        Me.btnLastItem = New System.Windows.Forms.Button()
        Me.btnCompName = New System.Windows.Forms.Button()
        Me.cmbCompName = New System.Windows.Forms.ComboBox()
        Me.txtLicenseNumber = New System.Windows.Forms.TextBox()
        Me.lblLicenseNumber = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(957, 41)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "بيانات المفوض او مندوب الورشه / الشركه / التاجر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colModify, Me.colBranchID, Me.colCompanyID, Me.colCompanyName, Me.colBranchName, Me.colBranchAddress, Me.colTelNumber, Me.colLicenseNumber, Me.colCommercialRegisterNo, Me.colCreationDate, Me.colLastEditDate, Me.colSalesCivilID})
        Me.Grid.Location = New System.Drawing.Point(4, 438)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.Size = New System.Drawing.Size(927, 216)
        Me.Grid.TabIndex = 188
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
        Me.colModify.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colModify.Width = 45
        '
        'colBranchID
        '
        Me.colBranchID.HeaderText = "BranchID"
        Me.colBranchID.Name = "colBranchID"
        Me.colBranchID.ReadOnly = True
        Me.colBranchID.Visible = False
        '
        'colCompanyID
        '
        Me.colCompanyID.HeaderText = "CompanyID"
        Me.colCompanyID.Name = "colCompanyID"
        Me.colCompanyID.ReadOnly = True
        Me.colCompanyID.Visible = False
        '
        'colCompanyName
        '
        Me.colCompanyName.HeaderText = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.ReadOnly = True
        '
        'colBranchName
        '
        Me.colBranchName.HeaderText = "BranchName"
        Me.colBranchName.Name = "colBranchName"
        Me.colBranchName.ReadOnly = True
        '
        'colBranchAddress
        '
        Me.colBranchAddress.HeaderText = "BranchAddress"
        Me.colBranchAddress.Name = "colBranchAddress"
        Me.colBranchAddress.ReadOnly = True
        '
        'colTelNumber
        '
        Me.colTelNumber.HeaderText = "TelNumber"
        Me.colTelNumber.Name = "colTelNumber"
        Me.colTelNumber.ReadOnly = True
        '
        'colLicenseNumber
        '
        Me.colLicenseNumber.HeaderText = "LicenseNumber"
        Me.colLicenseNumber.Name = "colLicenseNumber"
        Me.colLicenseNumber.ReadOnly = True
        '
        'colCommercialRegisterNo
        '
        Me.colCommercialRegisterNo.HeaderText = "CommercialRegisterNo"
        Me.colCommercialRegisterNo.Name = "colCommercialRegisterNo"
        Me.colCommercialRegisterNo.ReadOnly = True
        '
        'colCreationDate
        '
        Me.colCreationDate.HeaderText = "CreationDate"
        Me.colCreationDate.Name = "colCreationDate"
        Me.colCreationDate.ReadOnly = True
        '
        'colLastEditDate
        '
        Me.colLastEditDate.HeaderText = "LastEditDate"
        Me.colLastEditDate.Name = "colLastEditDate"
        Me.colLastEditDate.ReadOnly = True
        Me.colLastEditDate.Visible = False
        '
        'colSalesCivilID
        '
        Me.colSalesCivilID.HeaderText = "SalesCivilID"
        Me.colSalesCivilID.Name = "colSalesCivilID"
        Me.colSalesCivilID.ReadOnly = True
        Me.colSalesCivilID.Visible = False
        '
        'DateTimeCreationDate
        '
        Me.DateTimeCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeCreationDate.Location = New System.Drawing.Point(159, 346)
        Me.DateTimeCreationDate.Name = "DateTimeCreationDate"
        Me.DateTimeCreationDate.Size = New System.Drawing.Size(168, 27)
        Me.DateTimeCreationDate.TabIndex = 190
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(4, 381)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(153, 57)
        Me.BtnSave.TabIndex = 192
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.Gray
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdd.Location = New System.Drawing.Point(4, 324)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(153, 55)
        Me.BtnAdd.TabIndex = 191
        Me.BtnAdd.Text = "اضافة فرع"
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(327, 346)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(240, 27)
        Me.txtBranchName.TabIndex = 195
        Me.txtBranchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelNumber
        '
        Me.txtTelNumber.Location = New System.Drawing.Point(496, 410)
        Me.txtTelNumber.Name = "txtTelNumber"
        Me.txtTelNumber.Size = New System.Drawing.Size(147, 27)
        Me.txtTelNumber.TabIndex = 197
        Me.txtTelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCommercialRegisterNo
        '
        Me.txtCommercialRegisterNo.Location = New System.Drawing.Point(644, 410)
        Me.txtCommercialRegisterNo.Name = "txtCommercialRegisterNo"
        Me.txtCommercialRegisterNo.Size = New System.Drawing.Size(156, 27)
        Me.txtCommercialRegisterNo.TabIndex = 198
        Me.txtCommercialRegisterNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(159, 318)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(168, 28)
        Me.lblDate.TabIndex = 201
        Me.lblDate.Text = "التاريخ"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompName
        '
        Me.lblCompName.Location = New System.Drawing.Point(566, 318)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(391, 28)
        Me.lblCompName.TabIndex = 202
        Me.lblCompName.Text = "اسم الشركه"
        Me.lblCompName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommercialRegister
        '
        Me.lblCommercialRegister.Location = New System.Drawing.Point(644, 379)
        Me.lblCommercialRegister.Name = "lblCommercialRegister"
        Me.lblCommercialRegister.Size = New System.Drawing.Size(156, 28)
        Me.lblCommercialRegister.TabIndex = 203
        Me.lblCommercialRegister.Text = "سجل تجاري"
        Me.lblCommercialRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTel
        '
        Me.lblTel.Location = New System.Drawing.Point(496, 379)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(147, 28)
        Me.lblTel.TabIndex = 204
        Me.lblTel.Text = "رقم الهاتف"
        Me.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShopName
        '
        Me.lblShopName.Location = New System.Drawing.Point(327, 318)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(240, 28)
        Me.lblShopName.TabIndex = 205
        Me.lblShopName.Text = "اسم الفرع"
        Me.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdre
        '
        Me.lblAdre.Location = New System.Drawing.Point(159, 379)
        Me.lblAdre.Name = "lblAdre"
        Me.lblAdre.Size = New System.Drawing.Size(335, 28)
        Me.lblAdre.TabIndex = 208
        Me.lblAdre.Text = "عنوان فرع الشركه"
        Me.lblAdre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBranchAddress
        '
        Me.txtBranchAddress.Location = New System.Drawing.Point(159, 410)
        Me.txtBranchAddress.Name = "txtBranchAddress"
        Me.txtBranchAddress.Size = New System.Drawing.Size(335, 27)
        Me.txtBranchAddress.TabIndex = 207
        Me.txtBranchAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Location = New System.Drawing.Point(931, 441)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(25, 25)
        Me.btnSearch.TabIndex = 213
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnPreviousItem
        '
        Me.btnPreviousItem.BackColor = System.Drawing.Color.White
        Me.btnPreviousItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnPreviousItem.Location = New System.Drawing.Point(931, 540)
        Me.btnPreviousItem.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnPreviousItem.Name = "btnPreviousItem"
        Me.btnPreviousItem.Size = New System.Drawing.Size(25, 25)
        Me.btnPreviousItem.TabIndex = 212
        Me.btnPreviousItem.UseVisualStyleBackColor = False
        '
        'btnNextItem
        '
        Me.btnNextItem.BackColor = System.Drawing.Color.White
        Me.btnNextItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnNextItem.Location = New System.Drawing.Point(931, 568)
        Me.btnNextItem.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnNextItem.Name = "btnNextItem"
        Me.btnNextItem.Size = New System.Drawing.Size(25, 25)
        Me.btnNextItem.TabIndex = 210
        Me.btnNextItem.UseVisualStyleBackColor = False
        '
        'btnFirstItem
        '
        Me.btnFirstItem.BackColor = System.Drawing.Color.White
        Me.btnFirstItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnFirstItem.Location = New System.Drawing.Point(931, 487)
        Me.btnFirstItem.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnFirstItem.Name = "btnFirstItem"
        Me.btnFirstItem.Size = New System.Drawing.Size(25, 25)
        Me.btnFirstItem.TabIndex = 209
        Me.btnFirstItem.UseVisualStyleBackColor = False
        '
        'btnLastItem
        '
        Me.btnLastItem.BackColor = System.Drawing.Color.White
        Me.btnLastItem.ForeColor = System.Drawing.Color.Transparent
        Me.btnLastItem.Location = New System.Drawing.Point(931, 622)
        Me.btnLastItem.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnLastItem.Name = "btnLastItem"
        Me.btnLastItem.Size = New System.Drawing.Size(25, 25)
        Me.btnLastItem.TabIndex = 211
        Me.btnLastItem.UseVisualStyleBackColor = False
        '
        'btnCompName
        '
        Me.btnCompName.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCompName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompName.ForeColor = System.Drawing.Color.Black
        Me.btnCompName.Location = New System.Drawing.Point(566, 346)
        Me.btnCompName.Name = "btnCompName"
        Me.btnCompName.Size = New System.Drawing.Size(31, 27)
        Me.btnCompName.TabIndex = 214
        Me.btnCompName.Text = "+"
        Me.btnCompName.UseVisualStyleBackColor = False
        '
        'cmbCompName
        '
        Me.cmbCompName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCompName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCompName.FormattingEnabled = True
        Me.cmbCompName.Location = New System.Drawing.Point(597, 346)
        Me.cmbCompName.Name = "cmbCompName"
        Me.cmbCompName.Size = New System.Drawing.Size(360, 27)
        Me.cmbCompName.TabIndex = 215
        '
        'txtLicenseNumber
        '
        Me.txtLicenseNumber.Location = New System.Drawing.Point(801, 410)
        Me.txtLicenseNumber.Name = "txtLicenseNumber"
        Me.txtLicenseNumber.Size = New System.Drawing.Size(158, 27)
        Me.txtLicenseNumber.TabIndex = 216
        Me.txtLicenseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLicenseNumber
        '
        Me.lblLicenseNumber.Location = New System.Drawing.Point(801, 379)
        Me.lblLicenseNumber.Name = "lblLicenseNumber"
        Me.lblLicenseNumber.Size = New System.Drawing.Size(156, 28)
        Me.lblLicenseNumber.TabIndex = 217
        Me.lblLicenseNumber.Text = "رقم الرخصه"
        Me.lblLicenseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSuppliers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(960, 655)
        Me.Controls.Add(Me.lblLicenseNumber)
        Me.Controls.Add(Me.txtLicenseNumber)
        Me.Controls.Add(Me.cmbCompName)
        Me.Controls.Add(Me.btnCompName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnPreviousItem)
        Me.Controls.Add(Me.btnNextItem)
        Me.Controls.Add(Me.btnFirstItem)
        Me.Controls.Add(Me.btnLastItem)
        Me.Controls.Add(Me.lblAdre)
        Me.Controls.Add(Me.txtBranchAddress)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblCommercialRegister)
        Me.Controls.Add(Me.lblCompName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtCommercialRegisterNo)
        Me.Controls.Add(Me.txtTelNumber)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DateTimeCreationDate)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات الموردين/الشركات"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Grid As DataGridView
    Friend WithEvents DateTimeCreationDate As DateTimePicker
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents txtTelNumber As TextBox
    Friend WithEvents txtCommercialRegisterNo As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCompName As Label
    Friend WithEvents lblCommercialRegister As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblShopName As Label
    Friend WithEvents lblAdre As Label
    Friend WithEvents txtBranchAddress As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnPreviousItem As Button
    Friend WithEvents btnNextItem As Button
    Friend WithEvents btnFirstItem As Button
    Friend WithEvents btnLastItem As Button
    Friend WithEvents btnCompName As Button
    Friend WithEvents cmbCompName As ComboBox
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colModify As DataGridViewButtonColumn
    Friend WithEvents colBranchID As DataGridViewTextBoxColumn
    Friend WithEvents colCompanyID As DataGridViewTextBoxColumn
    Friend WithEvents colCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents colBranchName As DataGridViewTextBoxColumn
    Friend WithEvents colBranchAddress As DataGridViewTextBoxColumn
    Friend WithEvents colTelNumber As DataGridViewTextBoxColumn
    Friend WithEvents colLicenseNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCommercialRegisterNo As DataGridViewTextBoxColumn
    Friend WithEvents colCreationDate As DataGridViewTextBoxColumn
    Friend WithEvents colLastEditDate As DataGridViewTextBoxColumn
    Friend WithEvents colSalesCivilID As DataGridViewTextBoxColumn
End Class
