<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Me.txtUser_name = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkSell = New System.Windows.Forms.CheckBox()
        Me.chkBarCode = New System.Windows.Forms.CheckBox()
        Me.chkModify = New System.Windows.Forms.CheckBox()
        Me.chkGramPrice = New System.Windows.Forms.CheckBox()
        Me.chkReports = New System.Windows.Forms.CheckBox()
        Me.chkSalary = New System.Windows.Forms.CheckBox()
        Me.chkExpenses = New System.Windows.Forms.CheckBox()
        Me.chkStock = New System.Windows.Forms.CheckBox()
        Me.chkWholeSaleBuy = New System.Windows.Forms.CheckBox()
        Me.chkUsers = New System.Windows.Forms.CheckBox()
        Me.chkCashier = New System.Windows.Forms.CheckBox()
        Me.chkWholesale = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gbPrivilage = New System.Windows.Forms.GroupBox()
        Me.chkInvPayInstallment = New System.Windows.Forms.CheckBox()
        Me.chkModifyInvoce = New System.Windows.Forms.CheckBox()
        Me.chkLimitStock = New System.Windows.Forms.CheckBox()
        Me.chkItem = New System.Windows.Forms.CheckBox()
        Me.btnAllPrivilage = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.cmbUserName = New System.Windows.Forms.ComboBox()
        Me.chkDelItem = New System.Windows.Forms.CheckBox()
        Me.chkItemSelectInvo = New System.Windows.Forms.CheckBox()
        Me.gbPrivilage.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUser_name
        '
        Me.txtUser_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUser_name.Location = New System.Drawing.Point(8, 77)
        Me.txtUser_name.Name = "txtUser_name"
        Me.txtUser_name.Size = New System.Drawing.Size(249, 27)
        Me.txtUser_name.TabIndex = 4
        Me.txtUser_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(8, 121)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(249, 27)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'chkSell
        '
        Me.chkSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSell.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkSell.Location = New System.Drawing.Point(209, 53)
        Me.chkSell.Name = "chkSell"
        Me.chkSell.Size = New System.Drawing.Size(136, 23)
        Me.chkSell.TabIndex = 1
        Me.chkSell.Text = "البيع "
        Me.chkSell.UseVisualStyleBackColor = True
        '
        'chkBarCode
        '
        Me.chkBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBarCode.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkBarCode.Location = New System.Drawing.Point(209, 77)
        Me.chkBarCode.Name = "chkBarCode"
        Me.chkBarCode.Size = New System.Drawing.Size(136, 22)
        Me.chkBarCode.TabIndex = 2
        Me.chkBarCode.Text = "باركود"
        Me.chkBarCode.UseVisualStyleBackColor = True
        '
        'chkModify
        '
        Me.chkModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkModify.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkModify.Location = New System.Drawing.Point(209, 99)
        Me.chkModify.Name = "chkModify"
        Me.chkModify.Size = New System.Drawing.Size(136, 22)
        Me.chkModify.TabIndex = 3
        Me.chkModify.Text = "تعديل"
        Me.chkModify.UseVisualStyleBackColor = True
        '
        'chkGramPrice
        '
        Me.chkGramPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGramPrice.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkGramPrice.Location = New System.Drawing.Point(209, 121)
        Me.chkGramPrice.Name = "chkGramPrice"
        Me.chkGramPrice.Size = New System.Drawing.Size(136, 22)
        Me.chkGramPrice.TabIndex = 4
        Me.chkGramPrice.Text = "سعر الجرام"
        Me.chkGramPrice.UseVisualStyleBackColor = True
        '
        'chkReports
        '
        Me.chkReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkReports.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkReports.Location = New System.Drawing.Point(16, 120)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Size = New System.Drawing.Size(178, 22)
        Me.chkReports.TabIndex = 10
        Me.chkReports.Text = "تقارير"
        Me.chkReports.UseVisualStyleBackColor = True
        '
        'chkSalary
        '
        Me.chkSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSalary.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkSalary.Location = New System.Drawing.Point(16, 186)
        Me.chkSalary.Name = "chkSalary"
        Me.chkSalary.Size = New System.Drawing.Size(178, 22)
        Me.chkSalary.TabIndex = 5
        Me.chkSalary.Text = "رواتب"
        Me.chkSalary.UseVisualStyleBackColor = True
        Me.chkSalary.Visible = False
        '
        'chkExpenses
        '
        Me.chkExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkExpenses.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkExpenses.Location = New System.Drawing.Point(16, 142)
        Me.chkExpenses.Name = "chkExpenses"
        Me.chkExpenses.Size = New System.Drawing.Size(178, 22)
        Me.chkExpenses.TabIndex = 11
        Me.chkExpenses.Text = "المصروفات"
        Me.chkExpenses.UseVisualStyleBackColor = True
        '
        'chkStock
        '
        Me.chkStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkStock.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkStock.Location = New System.Drawing.Point(16, 164)
        Me.chkStock.Name = "chkStock"
        Me.chkStock.Size = New System.Drawing.Size(178, 22)
        Me.chkStock.TabIndex = 12
        Me.chkStock.Text = "المخزون"
        Me.chkStock.UseVisualStyleBackColor = True
        '
        'chkWholeSaleBuy
        '
        Me.chkWholeSaleBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWholeSaleBuy.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkWholeSaleBuy.Location = New System.Drawing.Point(209, 143)
        Me.chkWholeSaleBuy.Name = "chkWholeSaleBuy"
        Me.chkWholeSaleBuy.Size = New System.Drawing.Size(136, 22)
        Me.chkWholeSaleBuy.TabIndex = 6
        Me.chkWholeSaleBuy.Text = "مشتريات الجملة"
        Me.chkWholeSaleBuy.UseVisualStyleBackColor = True
        '
        'chkUsers
        '
        Me.chkUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUsers.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkUsers.Location = New System.Drawing.Point(16, 54)
        Me.chkUsers.Name = "chkUsers"
        Me.chkUsers.Size = New System.Drawing.Size(178, 22)
        Me.chkUsers.TabIndex = 7
        Me.chkUsers.Text = "المستخدمين"
        Me.chkUsers.UseVisualStyleBackColor = True
        '
        'chkCashier
        '
        Me.chkCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCashier.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkCashier.Location = New System.Drawing.Point(16, 76)
        Me.chkCashier.Name = "chkCashier"
        Me.chkCashier.Size = New System.Drawing.Size(178, 22)
        Me.chkCashier.TabIndex = 8
        Me.chkCashier.Text = "إدارة الموظفين"
        Me.chkCashier.UseVisualStyleBackColor = True
        '
        'chkWholesale
        '
        Me.chkWholesale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWholesale.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkWholesale.Location = New System.Drawing.Point(16, 98)
        Me.chkWholesale.Name = "chkWholesale"
        Me.chkWholesale.Size = New System.Drawing.Size(178, 22)
        Me.chkWholesale.TabIndex = 9
        Me.chkWholesale.Text = "مبيعات الجملة"
        Me.chkWholesale.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(97, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 38)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(290, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(73, 38)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "جديد"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(7, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'gbPrivilage
        '
        Me.gbPrivilage.BackColor = System.Drawing.Color.LemonChiffon
        Me.gbPrivilage.Controls.Add(Me.chkItemSelectInvo)
        Me.gbPrivilage.Controls.Add(Me.chkDelItem)
        Me.gbPrivilage.Controls.Add(Me.chkInvPayInstallment)
        Me.gbPrivilage.Controls.Add(Me.chkModifyInvoce)
        Me.gbPrivilage.Controls.Add(Me.chkLimitStock)
        Me.gbPrivilage.Controls.Add(Me.chkItem)
        Me.gbPrivilage.Controls.Add(Me.btnAllPrivilage)
        Me.gbPrivilage.Controls.Add(Me.chkWholeSaleBuy)
        Me.gbPrivilage.Controls.Add(Me.chkWholesale)
        Me.gbPrivilage.Controls.Add(Me.chkCashier)
        Me.gbPrivilage.Controls.Add(Me.chkUsers)
        Me.gbPrivilage.Controls.Add(Me.chkStock)
        Me.gbPrivilage.Controls.Add(Me.chkExpenses)
        Me.gbPrivilage.Controls.Add(Me.chkSalary)
        Me.gbPrivilage.Controls.Add(Me.chkReports)
        Me.gbPrivilage.Controls.Add(Me.chkGramPrice)
        Me.gbPrivilage.Controls.Add(Me.chkModify)
        Me.gbPrivilage.Controls.Add(Me.chkBarCode)
        Me.gbPrivilage.Controls.Add(Me.chkSell)
        Me.gbPrivilage.Location = New System.Drawing.Point(8, 153)
        Me.gbPrivilage.Name = "gbPrivilage"
        Me.gbPrivilage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbPrivilage.Size = New System.Drawing.Size(355, 334)
        Me.gbPrivilage.TabIndex = 7
        Me.gbPrivilage.TabStop = False
        Me.gbPrivilage.Text = "صلاحيات المستخدمين"
        '
        'chkInvPayInstallment
        '
        Me.chkInvPayInstallment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInvPayInstallment.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkInvPayInstallment.Location = New System.Drawing.Point(16, 208)
        Me.chkInvPayInstallment.Name = "chkInvPayInstallment"
        Me.chkInvPayInstallment.Size = New System.Drawing.Size(178, 22)
        Me.chkInvPayInstallment.TabIndex = 17
        Me.chkInvPayInstallment.Text = "الدفع الاجل"
        Me.chkInvPayInstallment.UseVisualStyleBackColor = True
        '
        'chkModifyInvoce
        '
        Me.chkModifyInvoce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkModifyInvoce.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkModifyInvoce.Location = New System.Drawing.Point(209, 211)
        Me.chkModifyInvoce.Name = "chkModifyInvoce"
        Me.chkModifyInvoce.Size = New System.Drawing.Size(136, 22)
        Me.chkModifyInvoce.TabIndex = 16
        Me.chkModifyInvoce.Text = "تعديل الصنف بالفاتوره"
        Me.chkModifyInvoce.UseVisualStyleBackColor = True
        '
        'chkLimitStock
        '
        Me.chkLimitStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLimitStock.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkLimitStock.Location = New System.Drawing.Point(209, 187)
        Me.chkLimitStock.Name = "chkLimitStock"
        Me.chkLimitStock.Size = New System.Drawing.Size(136, 22)
        Me.chkLimitStock.TabIndex = 14
        Me.chkLimitStock.Text = "تقييد الأصناف"
        Me.chkLimitStock.UseVisualStyleBackColor = True
        '
        'chkItem
        '
        Me.chkItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkItem.Location = New System.Drawing.Point(209, 165)
        Me.chkItem.Name = "chkItem"
        Me.chkItem.Size = New System.Drawing.Size(136, 22)
        Me.chkItem.TabIndex = 13
        Me.chkItem.Text = "الأصناف"
        Me.chkItem.UseVisualStyleBackColor = True
        '
        'btnAllPrivilage
        '
        Me.btnAllPrivilage.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnAllPrivilage.ForeColor = System.Drawing.Color.White
        Me.btnAllPrivilage.Location = New System.Drawing.Point(6, 15)
        Me.btnAllPrivilage.Name = "btnAllPrivilage"
        Me.btnAllPrivilage.Size = New System.Drawing.Size(342, 33)
        Me.btnAllPrivilage.TabIndex = 0
        Me.btnAllPrivilage.Text = "منح كل الصلاحيات"
        Me.btnAllPrivilage.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(261, 125)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(102, 19)
        Me.lblPassword.TabIndex = 59
        Me.lblPassword.Text = "كلمة المرور"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(261, 81)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(102, 19)
        Me.lblUserName.TabIndex = 60
        Me.lblUserName.Text = "اسم المستخدم"
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.Location = New System.Drawing.Point(192, 6)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(74, 38)
        Me.btnModify.TabIndex = 1
        Me.btnModify.Text = "تعديل"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'cmbUserName
        '
        Me.cmbUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.Location = New System.Drawing.Point(122, 49)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Size = New System.Drawing.Size(32, 27)
        Me.cmbUserName.TabIndex = 5
        Me.cmbUserName.Visible = False
        '
        'chkDelItem
        '
        Me.chkDelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDelItem.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkDelItem.Location = New System.Drawing.Point(209, 239)
        Me.chkDelItem.Name = "chkDelItem"
        Me.chkDelItem.Size = New System.Drawing.Size(136, 22)
        Me.chkDelItem.TabIndex = 18
        Me.chkDelItem.Text = "حزف الاصناف"
        Me.chkDelItem.UseVisualStyleBackColor = True
        '
        'chkItemSelectInvo
        '
        Me.chkItemSelectInvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkItemSelectInvo.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkItemSelectInvo.Location = New System.Drawing.Point(16, 234)
        Me.chkItemSelectInvo.Name = "chkItemSelectInvo"
        Me.chkItemSelectInvo.Size = New System.Drawing.Size(178, 22)
        Me.chkItemSelectInvo.TabIndex = 19
        Me.chkItemSelectInvo.Text = "اختيار الصنف بالفاتوره"
        Me.chkItemSelectInvo.UseVisualStyleBackColor = True
        '
        'frmUsers
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(371, 499)
        Me.Controls.Add(Me.cmbUserName)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.gbPrivilage)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUser_name)
        Me.Controls.Add(Me.txtPassword)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة المستخدمين"
        Me.gbPrivilage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser_name As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkSell As System.Windows.Forms.CheckBox
    Friend WithEvents chkBarCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkModify As System.Windows.Forms.CheckBox
    Friend WithEvents chkGramPrice As System.Windows.Forms.CheckBox
    Friend WithEvents chkReports As System.Windows.Forms.CheckBox
    Friend WithEvents chkSalary As System.Windows.Forms.CheckBox
    Friend WithEvents chkExpenses As System.Windows.Forms.CheckBox
    Friend WithEvents chkStock As System.Windows.Forms.CheckBox
    Friend WithEvents chkWholeSaleBuy As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsers As System.Windows.Forms.CheckBox
    Friend WithEvents chkCashier As System.Windows.Forms.CheckBox
    Friend WithEvents chkWholesale As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gbPrivilage As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents btnAllPrivilage As System.Windows.Forms.Button
    Friend WithEvents btnModify As Button
    Friend WithEvents cmbUserName As ComboBox
    Friend WithEvents chkItem As CheckBox
    Friend WithEvents chkLimitStock As CheckBox
    Friend WithEvents chkModifyInvoce As System.Windows.Forms.CheckBox
    Friend WithEvents chkInvPayInstallment As System.Windows.Forms.CheckBox
    Friend WithEvents chkItemSelectInvo As CheckBox
    Friend WithEvents chkDelItem As CheckBox
End Class
