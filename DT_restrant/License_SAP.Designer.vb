<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class License_SAP
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddShop = New System.Windows.Forms.Button()
        Me.btnUpdateShop = New System.Windows.Forms.Button()
        Me.txtSerialSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchContractNo = New System.Windows.Forms.Button()
        Me.LIC = New System.Windows.Forms.TextBox()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtContractNo = New System.Windows.Forms.TextBox()
        Me.txtSearchContract = New System.Windows.Forms.TextBox()
        Me.btnSearchByNo = New System.Windows.Forms.Button()
        Me.btnSearchByName = New System.Windows.Forms.Button()
        Me.cmbNameSearch = New System.Windows.Forms.ComboBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnViewCurrent = New System.Windows.Forms.Button()
        Me.PRICE_LINK = New System.Windows.Forms.TextBox()
        Me.currency_CO = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddShop
        '
        Me.btnAddShop.Location = New System.Drawing.Point(8, 169)
        Me.btnAddShop.Name = "btnAddShop"
        Me.btnAddShop.Size = New System.Drawing.Size(138, 27)
        Me.btnAddShop.TabIndex = 0
        Me.btnAddShop.Text = "إضافة جديد"
        Me.btnAddShop.UseVisualStyleBackColor = True
        '
        'btnUpdateShop
        '
        Me.btnUpdateShop.Location = New System.Drawing.Point(244, 169)
        Me.btnUpdateShop.Name = "btnUpdateShop"
        Me.btnUpdateShop.Size = New System.Drawing.Size(138, 27)
        Me.btnUpdateShop.TabIndex = 1
        Me.btnUpdateShop.Text = "تحديث"
        Me.btnUpdateShop.UseVisualStyleBackColor = True
        '
        'txtSerialSearch
        '
        Me.txtSerialSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSerialSearch.Location = New System.Drawing.Point(8, 3)
        Me.txtSerialSearch.Name = "txtSerialSearch"
        Me.txtSerialSearch.Size = New System.Drawing.Size(501, 27)
        Me.txtSerialSearch.TabIndex = 4
        Me.txtSerialSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchContractNo
        '
        Me.btnSearchContractNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearchContractNo.Location = New System.Drawing.Point(120, 30)
        Me.btnSearchContractNo.Name = "btnSearchContractNo"
        Me.btnSearchContractNo.Size = New System.Drawing.Size(175, 27)
        Me.btnSearchContractNo.TabIndex = 5
        Me.btnSearchContractNo.Text = "بحث برقم العقد"
        Me.btnSearchContractNo.UseVisualStyleBackColor = True
        '
        'LIC
        '
        Me.LIC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIC.Location = New System.Drawing.Point(-140, 132)
        Me.LIC.Name = "LIC"
        Me.LIC.Size = New System.Drawing.Size(132, 29)
        Me.LIC.TabIndex = 6
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(360, 87)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(372, 27)
        Me.txtShopName.TabIndex = 7
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(360, 141)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(372, 27)
        Me.txtSerial.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-154, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "رقم الترخيص المسجل"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(738, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "اسم المحل"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(738, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "تاريخ بدء العقد"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(178, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "تاريخ انتهاء العقد"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(178, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "رقم العقد"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(738, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "كود الجهاز المسجل"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(-140, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 19)
        Me.Label7.TabIndex = 20
        '
        'dtStartDate
        '
        Me.dtStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtStartDate.Location = New System.Drawing.Point(360, 114)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(372, 27)
        Me.dtStartDate.TabIndex = 21
        '
        'dtEndDate
        '
        Me.dtEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtEndDate.Location = New System.Drawing.Point(8, 142)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(164, 27)
        Me.dtEndDate.TabIndex = 22
        '
        'txtContractNo
        '
        Me.txtContractNo.Location = New System.Drawing.Point(8, 115)
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Size = New System.Drawing.Size(164, 27)
        Me.txtContractNo.TabIndex = 24
        '
        'txtSearchContract
        '
        Me.txtSearchContract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSearchContract.Location = New System.Drawing.Point(8, 30)
        Me.txtSearchContract.Name = "txtSearchContract"
        Me.txtSearchContract.Size = New System.Drawing.Size(104, 27)
        Me.txtSearchContract.TabIndex = 23
        Me.txtSearchContract.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearchByNo
        '
        Me.btnSearchByNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearchByNo.Location = New System.Drawing.Point(515, 2)
        Me.btnSearchByNo.Name = "btnSearchByNo"
        Me.btnSearchByNo.Size = New System.Drawing.Size(145, 27)
        Me.btnSearchByNo.TabIndex = 25
        Me.btnSearchByNo.Text = "بحث برقم الجهاز"
        Me.btnSearchByNo.UseVisualStyleBackColor = True
        '
        'btnSearchByName
        '
        Me.btnSearchByName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearchByName.Location = New System.Drawing.Point(515, 30)
        Me.btnSearchByName.Name = "btnSearchByName"
        Me.btnSearchByName.Size = New System.Drawing.Size(145, 27)
        Me.btnSearchByName.TabIndex = 27
        Me.btnSearchByName.Text = "بحث باسم المحل"
        Me.btnSearchByName.UseVisualStyleBackColor = True
        '
        'cmbNameSearch
        '
        Me.cmbNameSearch.FormattingEnabled = True
        Me.cmbNameSearch.Location = New System.Drawing.Point(302, 30)
        Me.cmbNameSearch.Name = "cmbNameSearch"
        Me.cmbNameSearch.Size = New System.Drawing.Size(207, 27)
        Me.cmbNameSearch.TabIndex = 28
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.Location = New System.Drawing.Point(8, 198)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 10
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1001, 323)
        Me.grid.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LIC)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1137, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(67, 56)
        Me.Panel1.TabIndex = 30
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(687, 168)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(138, 27)
        Me.btnViewAll.TabIndex = 31
        Me.btnViewAll.Text = "عرض الكل"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'btnViewCurrent
        '
        Me.btnViewCurrent.Location = New System.Drawing.Point(433, 169)
        Me.btnViewCurrent.Name = "btnViewCurrent"
        Me.btnViewCurrent.Size = New System.Drawing.Size(138, 27)
        Me.btnViewCurrent.TabIndex = 32
        Me.btnViewCurrent.Text = "عرض الحالي"
        Me.btnViewCurrent.UseVisualStyleBackColor = True
        '
        'PRICE_LINK
        '
        Me.PRICE_LINK.Location = New System.Drawing.Point(8, 58)
        Me.PRICE_LINK.Name = "PRICE_LINK"
        Me.PRICE_LINK.Size = New System.Drawing.Size(724, 27)
        Me.PRICE_LINK.TabIndex = 34
        '
        'currency_CO
        '
        Me.currency_CO.FormattingEnabled = True
        Me.currency_CO.Items.AddRange(New Object() {"QAR", "TUR", "EMR", "EGP"})
        Me.currency_CO.Location = New System.Drawing.Point(8, 87)
        Me.currency_CO.Name = "currency_CO"
        Me.currency_CO.Size = New System.Drawing.Size(164, 27)
        Me.currency_CO.TabIndex = 37
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(738, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 19)
        Me.LinkLabel1.TabIndex = 38
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "لينك الاسعار الافتراضي"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(178, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 19)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "رمز العمله المسجل"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'License_SAP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1015, 530)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.currency_CO)
        Me.Controls.Add(Me.PRICE_LINK)
        Me.Controls.Add(Me.btnViewCurrent)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmbNameSearch)
        Me.Controls.Add(Me.btnSearchByName)
        Me.Controls.Add(Me.btnSearchByNo)
        Me.Controls.Add(Me.txtContractNo)
        Me.Controls.Add(Me.txtSearchContract)
        Me.Controls.Add(Me.dtEndDate)
        Me.Controls.Add(Me.dtStartDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.btnSearchContractNo)
        Me.Controls.Add(Me.txtSerialSearch)
        Me.Controls.Add(Me.btnUpdateShop)
        Me.Controls.Add(Me.btnAddShop)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "License_SAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الترخيص"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddShop As System.Windows.Forms.Button
    Friend WithEvents btnUpdateShop As System.Windows.Forms.Button
    Friend WithEvents txtSerialSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchContractNo As System.Windows.Forms.Button
    Friend WithEvents LIC As System.Windows.Forms.TextBox
    Friend WithEvents txtShopName As System.Windows.Forms.TextBox
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContractNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchContract As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchByNo As System.Windows.Forms.Button
    Friend WithEvents btnSearchByName As System.Windows.Forms.Button
    Friend WithEvents cmbNameSearch As System.Windows.Forms.ComboBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnViewAll As System.Windows.Forms.Button
    Friend WithEvents btnViewCurrent As System.Windows.Forms.Button
    Friend WithEvents PRICE_LINK As System.Windows.Forms.TextBox
    Friend WithEvents currency_CO As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
