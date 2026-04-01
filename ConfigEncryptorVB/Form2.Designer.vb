<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnChangeInvoiceNumber = New System.Windows.Forms.Button()
        Me.btnImportCustomers = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnShowCashiers = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnCheckEditability = New System.Windows.Forms.Button()
        Me.btnCheckMissingData = New System.Windows.Forms.Button()
        Me.radDiamondBuyInvoice = New System.Windows.Forms.RadioButton()
        Me.radDiamondInvoice = New System.Windows.Forms.RadioButton()
        Me.radSellInvoice = New System.Windows.Forms.RadioButton()
        Me.radBuyInvoice = New System.Windows.Forms.RadioButton()
        Me.btnSearchInvoice = New System.Windows.Forms.Button()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.pnlInactiveInvoices = New System.Windows.Forms.Panel()
        Me.grpInactiveInvoices = New System.Windows.Forms.GroupBox()
        Me.lstInactiveInvoices = New System.Windows.Forms.ListBox()
        Me.btnShowInactiveInvoices = New System.Windows.Forms.Button()
        Me.pnlTables = New System.Windows.Forms.Panel()
        Me.tabInvoiceType = New System.Windows.Forms.TabControl()
        Me.tabBuy = New System.Windows.Forms.TabPage()
        Me.grpBuyTables = New System.Windows.Forms.GroupBox()
        Me.chkBuySelectAll = New System.Windows.Forms.CheckBox()
        Me.chkBuyGold = New System.Windows.Forms.CheckBox()
        Me.chkBuyCastomerDETELS = New System.Windows.Forms.CheckBox()
        Me.chkBuyBayGoledMony = New System.Windows.Forms.CheckBox()
        Me.chkBuyCacher = New System.Windows.Forms.CheckBox()
        Me.chkBuyPayMethod = New System.Windows.Forms.CheckBox()
        Me.chkBuySettings = New System.Windows.Forms.CheckBox()
        Me.chkBuyCompInform = New System.Windows.Forms.CheckBox()
        Me.tabSell = New System.Windows.Forms.TabPage()
        Me.grpSellTables = New System.Windows.Forms.GroupBox()
        Me.chkSellSelectAll = New System.Windows.Forms.CheckBox()
        Me.chkSellBAY = New System.Windows.Forms.CheckBox()
        Me.chkSellInvoceDetels = New System.Windows.Forms.CheckBox()
        Me.chkSellCastomerDETELS = New System.Windows.Forms.CheckBox()
        Me.chkSellFOMin = New System.Windows.Forms.CheckBox()
        Me.chkSellCacher = New System.Windows.Forms.CheckBox()
        Me.chkSellPayMethod = New System.Windows.Forms.CheckBox()
        Me.chkSellSettings = New System.Windows.Forms.CheckBox()
        Me.chkSellCompInform = New System.Windows.Forms.CheckBox()
        Me.tabDiamond = New System.Windows.Forms.TabPage()
        Me.grpDiamondTables = New System.Windows.Forms.GroupBox()
        Me.chkDiamondSelectAll = New System.Windows.Forms.CheckBox()
        Me.chkDiamondInvce = New System.Windows.Forms.CheckBox()
        Me.chkDiamondBay = New System.Windows.Forms.CheckBox()
        Me.chkDiamondCastomerDETELS = New System.Windows.Forms.CheckBox()
        Me.chkDiamondDetels = New System.Windows.Forms.CheckBox()
        Me.chkDiamondCacher = New System.Windows.Forms.CheckBox()
        Me.chkDiamondPayMethod = New System.Windows.Forms.CheckBox()
        Me.chkDiamondSettings = New System.Windows.Forms.CheckBox()
        Me.chkDiamondCompInform = New System.Windows.Forms.CheckBox()
        Me.tabDiamondBuy = New System.Windows.Forms.TabPage()
        Me.grpDiamondBuyTables = New System.Windows.Forms.GroupBox()
        Me.chkDiamondBuySelectAll = New System.Windows.Forms.CheckBox()
        Me.chkBuyDiamond = New System.Windows.Forms.CheckBox()
        Me.chkBayDiamondMony = New System.Windows.Forms.CheckBox()
        Me.chkDiamondBuyCastomerDETELS = New System.Windows.Forms.CheckBox()
        Me.chkDiamondBuyCacher = New System.Windows.Forms.CheckBox()
        Me.chkDiamondBuyPayMethod = New System.Windows.Forms.CheckBox()
        Me.chkDiamondBuySettings = New System.Windows.Forms.CheckBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.pnlInactiveInvoices.SuspendLayout()
        Me.grpInactiveInvoices.SuspendLayout()
        Me.pnlTables.SuspendLayout()
        Me.tabInvoiceType.SuspendLayout()
        Me.tabBuy.SuspendLayout()
        Me.grpBuyTables.SuspendLayout()
        Me.tabSell.SuspendLayout()
        Me.grpSellTables.SuspendLayout()
        Me.tabDiamond.SuspendLayout()
        Me.grpDiamondTables.SuspendLayout()
        Me.tabDiamondBuy.SuspendLayout()
        Me.grpDiamondBuyTables.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(0, 0)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 24
        Me.dgvData.Size = New System.Drawing.Size(1277, 611)
        Me.dgvData.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.btnChangeInvoiceNumber)
        Me.pnlTop.Controls.Add(Me.btnImportCustomers)
        Me.pnlTop.Controls.Add(Me.lblStatus)
        Me.pnlTop.Controls.Add(Me.btnRefresh)
        Me.pnlTop.Controls.Add(Me.btnExport)
        Me.pnlTop.Controls.Add(Me.btnShowCashiers)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New System.Windows.Forms.Padding(4)
        Me.pnlTop.Size = New System.Drawing.Size(1277, 37)
        Me.pnlTop.TabIndex = 1
        '
        'btnChangeInvoiceNumber
        '
        Me.btnChangeInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangeInvoiceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeInvoiceNumber.ForeColor = System.Drawing.Color.Red
        Me.btnChangeInvoiceNumber.Location = New System.Drawing.Point(568, 6)
        Me.btnChangeInvoiceNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChangeInvoiceNumber.Name = "btnChangeInvoiceNumber"
        Me.btnChangeInvoiceNumber.Size = New System.Drawing.Size(135, 23)
        Me.btnChangeInvoiceNumber.TabIndex = 7
        Me.btnChangeInvoiceNumber.Text = "🔄 تغيير رقم الفاتورة"
        Me.btnChangeInvoiceNumber.UseVisualStyleBackColor = True
        '
        'btnImportCustomers
        '
        Me.btnImportCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportCustomers.ForeColor = System.Drawing.Color.Green
        Me.btnImportCustomers.Location = New System.Drawing.Point(707, 8)
        Me.btnImportCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImportCustomers.Name = "btnImportCustomers"
        Me.btnImportCustomers.Size = New System.Drawing.Size(135, 23)
        Me.btnImportCustomers.TabIndex = 8
        Me.btnImportCustomers.Text = "📥 استيراد العملاء"
        Me.btnImportCustomers.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(4, 4)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(4, 8, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(32, 23)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "جاهز"
        '
        'btnRefresh
        '
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(848, 4)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(133, 29)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "تحديث"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExport.Location = New System.Drawing.Point(981, 4)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(113, 29)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "تصدير البنية"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnShowCashiers
        '
        Me.btnShowCashiers.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnShowCashiers.Location = New System.Drawing.Point(1094, 4)
        Me.btnShowCashiers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowCashiers.Name = "btnShowCashiers"
        Me.btnShowCashiers.Size = New System.Drawing.Size(179, 29)
        Me.btnShowCashiers.TabIndex = 3
        Me.btnShowCashiers.Text = "عرض الكاشير"
        Me.btnShowCashiers.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.grpSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 37)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.pnlSearch.Size = New System.Drawing.Size(1277, 69)
        Me.pnlSearch.TabIndex = 2
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnCheckEditability)
        Me.grpSearch.Controls.Add(Me.btnCheckMissingData)
        Me.grpSearch.Controls.Add(Me.radDiamondBuyInvoice)
        Me.grpSearch.Controls.Add(Me.radDiamondInvoice)
        Me.grpSearch.Controls.Add(Me.radSellInvoice)
        Me.grpSearch.Controls.Add(Me.radBuyInvoice)
        Me.grpSearch.Controls.Add(Me.btnSearchInvoice)
        Me.grpSearch.Controls.Add(Me.txtInvoiceNo)
        Me.grpSearch.Controls.Add(Me.lblInvoiceNo)
        Me.grpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(4, 4)
        Me.grpSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSearch.Size = New System.Drawing.Size(1269, 61)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "بحث عن فاتورة"
        '
        'btnCheckEditability
        '
        Me.btnCheckEditability.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheckEditability.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckEditability.Location = New System.Drawing.Point(485, 19)
        Me.btnCheckEditability.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckEditability.Name = "btnCheckEditability"
        Me.btnCheckEditability.Size = New System.Drawing.Size(135, 23)
        Me.btnCheckEditability.TabIndex = 6
        Me.btnCheckEditability.Text = "التحقق من إمكانية التعديل"
        Me.btnCheckEditability.UseVisualStyleBackColor = True
        '
        'btnCheckMissingData
        '
        Me.btnCheckMissingData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheckMissingData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMissingData.Location = New System.Drawing.Point(624, 20)
        Me.btnCheckMissingData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckMissingData.Name = "btnCheckMissingData"
        Me.btnCheckMissingData.Size = New System.Drawing.Size(135, 23)
        Me.btnCheckMissingData.TabIndex = 5
        Me.btnCheckMissingData.Text = "التحقق من البيانات الناقصة"
        Me.btnCheckMissingData.UseVisualStyleBackColor = True
        '
        'radDiamondBuyInvoice
        '
        Me.radDiamondBuyInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radDiamondBuyInvoice.AutoSize = True
        Me.radDiamondBuyInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiamondBuyInvoice.Location = New System.Drawing.Point(967, 20)
        Me.radDiamondBuyInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radDiamondBuyInvoice.Name = "radDiamondBuyInvoice"
        Me.radDiamondBuyInvoice.Size = New System.Drawing.Size(73, 19)
        Me.radDiamondBuyInvoice.TabIndex = 7
        Me.radDiamondBuyInvoice.Text = "شراء الماس"
        Me.radDiamondBuyInvoice.UseVisualStyleBackColor = True
        '
        'radDiamondInvoice
        '
        Me.radDiamondInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radDiamondInvoice.AutoSize = True
        Me.radDiamondInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDiamondInvoice.Location = New System.Drawing.Point(1061, 20)
        Me.radDiamondInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radDiamondInvoice.Name = "radDiamondInvoice"
        Me.radDiamondInvoice.Size = New System.Drawing.Size(63, 19)
        Me.radDiamondInvoice.TabIndex = 6
        Me.radDiamondInvoice.Text = "بيع الماس"
        Me.radDiamondInvoice.UseVisualStyleBackColor = True
        '
        'radSellInvoice
        '
        Me.radSellInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radSellInvoice.AutoSize = True
        Me.radSellInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSellInvoice.Location = New System.Drawing.Point(1132, 20)
        Me.radSellInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radSellInvoice.Name = "radSellInvoice"
        Me.radSellInvoice.Size = New System.Drawing.Size(63, 19)
        Me.radSellInvoice.TabIndex = 4
        Me.radSellInvoice.Text = "فاتورة بيع"
        Me.radSellInvoice.UseVisualStyleBackColor = True
        '
        'radBuyInvoice
        '
        Me.radBuyInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radBuyInvoice.AutoSize = True
        Me.radBuyInvoice.Checked = True
        Me.radBuyInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBuyInvoice.Location = New System.Drawing.Point(1194, 20)
        Me.radBuyInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radBuyInvoice.Name = "radBuyInvoice"
        Me.radBuyInvoice.Size = New System.Drawing.Size(73, 19)
        Me.radBuyInvoice.TabIndex = 3
        Me.radBuyInvoice.TabStop = True
        Me.radBuyInvoice.Text = "فاتورة شراء"
        Me.radBuyInvoice.UseVisualStyleBackColor = True
        '
        'btnSearchInvoice
        '
        Me.btnSearchInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchInvoice.Location = New System.Drawing.Point(763, 19)
        Me.btnSearchInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchInvoice.Name = "btnSearchInvoice"
        Me.btnSearchInvoice.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchInvoice.TabIndex = 2
        Me.btnSearchInvoice.Text = "بحث"
        Me.btnSearchInvoice.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(842, 20)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(121, 21)
        Me.txtInvoiceNo.TabIndex = 1
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(1067, 23)
        Me.lblInvoiceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(57, 15)
        Me.lblInvoiceNo.TabIndex = 0
        Me.lblInvoiceNo.Text = "رقم الفاتورة:"
        '
        'pnlInactiveInvoices
        '
        Me.pnlInactiveInvoices.Controls.Add(Me.grpInactiveInvoices)
        Me.pnlInactiveInvoices.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInactiveInvoices.Location = New System.Drawing.Point(0, 106)
        Me.pnlInactiveInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInactiveInvoices.Name = "pnlInactiveInvoices"
        Me.pnlInactiveInvoices.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.pnlInactiveInvoices.Size = New System.Drawing.Size(188, 505)
        Me.pnlInactiveInvoices.TabIndex = 3
        '
        'grpInactiveInvoices
        '
        Me.grpInactiveInvoices.Controls.Add(Me.lstInactiveInvoices)
        Me.grpInactiveInvoices.Controls.Add(Me.btnShowInactiveInvoices)
        Me.grpInactiveInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInactiveInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpInactiveInvoices.Location = New System.Drawing.Point(4, 0)
        Me.grpInactiveInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.grpInactiveInvoices.Name = "grpInactiveInvoices"
        Me.grpInactiveInvoices.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInactiveInvoices.Size = New System.Drawing.Size(180, 501)
        Me.grpInactiveInvoices.TabIndex = 0
        Me.grpInactiveInvoices.TabStop = False
        Me.grpInactiveInvoices.Text = "الفواتير غير النشطة"
        '
        'lstInactiveInvoices
        '
        Me.lstInactiveInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstInactiveInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInactiveInvoices.FormattingEnabled = True
        Me.lstInactiveInvoices.ItemHeight = 15
        Me.lstInactiveInvoices.Location = New System.Drawing.Point(4, 46)
        Me.lstInactiveInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.lstInactiveInvoices.Name = "lstInactiveInvoices"
        Me.lstInactiveInvoices.Size = New System.Drawing.Size(172, 451)
        Me.lstInactiveInvoices.TabIndex = 1
        '
        'btnShowInactiveInvoices
        '
        Me.btnShowInactiveInvoices.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnShowInactiveInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowInactiveInvoices.Location = New System.Drawing.Point(4, 18)
        Me.btnShowInactiveInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowInactiveInvoices.Name = "btnShowInactiveInvoices"
        Me.btnShowInactiveInvoices.Size = New System.Drawing.Size(172, 28)
        Me.btnShowInactiveInvoices.TabIndex = 0
        Me.btnShowInactiveInvoices.Text = "عرض الفواتير غير النشطة"
        Me.btnShowInactiveInvoices.UseVisualStyleBackColor = True
        '
        'pnlTables
        '
        Me.pnlTables.Controls.Add(Me.tabInvoiceType)
        Me.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTables.Location = New System.Drawing.Point(188, 106)
        Me.pnlTables.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTables.Name = "pnlTables"
        Me.pnlTables.Padding = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.pnlTables.Size = New System.Drawing.Size(1089, 505)
        Me.pnlTables.TabIndex = 4
        '
        'tabInvoiceType
        '
        Me.tabInvoiceType.Controls.Add(Me.tabBuy)
        Me.tabInvoiceType.Controls.Add(Me.tabSell)
        Me.tabInvoiceType.Controls.Add(Me.tabDiamond)
        Me.tabInvoiceType.Controls.Add(Me.tabDiamondBuy)
        Me.tabInvoiceType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabInvoiceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabInvoiceType.Location = New System.Drawing.Point(4, 0)
        Me.tabInvoiceType.Margin = New System.Windows.Forms.Padding(2)
        Me.tabInvoiceType.Name = "tabInvoiceType"
        Me.tabInvoiceType.SelectedIndex = 0
        Me.tabInvoiceType.Size = New System.Drawing.Size(1081, 501)
        Me.tabInvoiceType.TabIndex = 0
        '
        'tabBuy
        '
        Me.tabBuy.Controls.Add(Me.grpBuyTables)
        Me.tabBuy.Location = New System.Drawing.Point(4, 24)
        Me.tabBuy.Margin = New System.Windows.Forms.Padding(2)
        Me.tabBuy.Name = "tabBuy"
        Me.tabBuy.Padding = New System.Windows.Forms.Padding(2)
        Me.tabBuy.Size = New System.Drawing.Size(1073, 473)
        Me.tabBuy.TabIndex = 0
        Me.tabBuy.Text = "فواتير الشراء"
        Me.tabBuy.UseVisualStyleBackColor = True
        '
        'grpBuyTables
        '
        Me.grpBuyTables.Controls.Add(Me.chkBuySelectAll)
        Me.grpBuyTables.Controls.Add(Me.chkBuyGold)
        Me.grpBuyTables.Controls.Add(Me.chkBuyCastomerDETELS)
        Me.grpBuyTables.Controls.Add(Me.chkBuyBayGoledMony)
        Me.grpBuyTables.Controls.Add(Me.chkBuyCacher)
        Me.grpBuyTables.Controls.Add(Me.chkBuyPayMethod)
        Me.grpBuyTables.Controls.Add(Me.chkBuySettings)
        Me.grpBuyTables.Controls.Add(Me.chkBuyCompInform)
        Me.grpBuyTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpBuyTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBuyTables.Location = New System.Drawing.Point(2, 2)
        Me.grpBuyTables.Margin = New System.Windows.Forms.Padding(2)
        Me.grpBuyTables.Name = "grpBuyTables"
        Me.grpBuyTables.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBuyTables.Size = New System.Drawing.Size(1069, 469)
        Me.grpBuyTables.TabIndex = 0
        Me.grpBuyTables.TabStop = False
        Me.grpBuyTables.Text = "اختر الجداول للعرض عند البحث عن فاتورة شراء"
        '
        'chkBuySelectAll
        '
        Me.chkBuySelectAll.AutoSize = True
        Me.chkBuySelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuySelectAll.Location = New System.Drawing.Point(15, 24)
        Me.chkBuySelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuySelectAll.Name = "chkBuySelectAll"
        Me.chkBuySelectAll.Size = New System.Drawing.Size(77, 19)
        Me.chkBuySelectAll.TabIndex = 0
        Me.chkBuySelectAll.Text = "تحديد الكل"
        Me.chkBuySelectAll.UseVisualStyleBackColor = True
        '
        'chkBuyGold
        '
        Me.chkBuyGold.AutoSize = True
        Me.chkBuyGold.Checked = True
        Me.chkBuyGold.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyGold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyGold.Location = New System.Drawing.Point(15, 49)
        Me.chkBuyGold.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyGold.Name = "chkBuyGold"
        Me.chkBuyGold.Size = New System.Drawing.Size(79, 19)
        Me.chkBuyGold.TabIndex = 1
        Me.chkBuyGold.Text = "Buy_Gold"
        Me.chkBuyGold.UseVisualStyleBackColor = True
        '
        'chkBuyCastomerDETELS
        '
        Me.chkBuyCastomerDETELS.AutoSize = True
        Me.chkBuyCastomerDETELS.Checked = True
        Me.chkBuyCastomerDETELS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyCastomerDETELS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyCastomerDETELS.Location = New System.Drawing.Point(15, 73)
        Me.chkBuyCastomerDETELS.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyCastomerDETELS.Name = "chkBuyCastomerDETELS"
        Me.chkBuyCastomerDETELS.Size = New System.Drawing.Size(126, 19)
        Me.chkBuyCastomerDETELS.TabIndex = 2
        Me.chkBuyCastomerDETELS.Text = "CastomerDETELS"
        Me.chkBuyCastomerDETELS.UseVisualStyleBackColor = True
        '
        'chkBuyBayGoledMony
        '
        Me.chkBuyBayGoledMony.AutoSize = True
        Me.chkBuyBayGoledMony.Checked = True
        Me.chkBuyBayGoledMony.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyBayGoledMony.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyBayGoledMony.Location = New System.Drawing.Point(15, 98)
        Me.chkBuyBayGoledMony.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyBayGoledMony.Name = "chkBuyBayGoledMony"
        Me.chkBuyBayGoledMony.Size = New System.Drawing.Size(120, 19)
        Me.chkBuyBayGoledMony.TabIndex = 3
        Me.chkBuyBayGoledMony.Text = "bay_goled_mony"
        Me.chkBuyBayGoledMony.UseVisualStyleBackColor = True
        '
        'chkBuyCacher
        '
        Me.chkBuyCacher.AutoSize = True
        Me.chkBuyCacher.Checked = True
        Me.chkBuyCacher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyCacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyCacher.Location = New System.Drawing.Point(15, 122)
        Me.chkBuyCacher.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyCacher.Name = "chkBuyCacher"
        Me.chkBuyCacher.Size = New System.Drawing.Size(63, 19)
        Me.chkBuyCacher.TabIndex = 4
        Me.chkBuyCacher.Text = "cacher"
        Me.chkBuyCacher.UseVisualStyleBackColor = True
        '
        'chkBuyPayMethod
        '
        Me.chkBuyPayMethod.AutoSize = True
        Me.chkBuyPayMethod.Checked = True
        Me.chkBuyPayMethod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyPayMethod.Location = New System.Drawing.Point(15, 146)
        Me.chkBuyPayMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyPayMethod.Name = "chkBuyPayMethod"
        Me.chkBuyPayMethod.Size = New System.Drawing.Size(88, 19)
        Me.chkBuyPayMethod.TabIndex = 5
        Me.chkBuyPayMethod.Text = "PayMethod"
        Me.chkBuyPayMethod.UseVisualStyleBackColor = True
        '
        'chkBuySettings
        '
        Me.chkBuySettings.AutoSize = True
        Me.chkBuySettings.Checked = True
        Me.chkBuySettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuySettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuySettings.Location = New System.Drawing.Point(15, 171)
        Me.chkBuySettings.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuySettings.Name = "chkBuySettings"
        Me.chkBuySettings.Size = New System.Drawing.Size(70, 19)
        Me.chkBuySettings.TabIndex = 6
        Me.chkBuySettings.Text = "Settings"
        Me.chkBuySettings.UseVisualStyleBackColor = True
        '
        'chkBuyCompInform
        '
        Me.chkBuyCompInform.AutoSize = True
        Me.chkBuyCompInform.Checked = True
        Me.chkBuyCompInform.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyCompInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyCompInform.Location = New System.Drawing.Point(15, 195)
        Me.chkBuyCompInform.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyCompInform.Name = "chkBuyCompInform"
        Me.chkBuyCompInform.Size = New System.Drawing.Size(99, 19)
        Me.chkBuyCompInform.TabIndex = 7
        Me.chkBuyCompInform.Text = "comp_inform"
        Me.chkBuyCompInform.UseVisualStyleBackColor = True
        '
        'tabSell
        '
        Me.tabSell.Controls.Add(Me.grpSellTables)
        Me.tabSell.Location = New System.Drawing.Point(4, 24)
        Me.tabSell.Margin = New System.Windows.Forms.Padding(2)
        Me.tabSell.Name = "tabSell"
        Me.tabSell.Padding = New System.Windows.Forms.Padding(2)
        Me.tabSell.Size = New System.Drawing.Size(1073, 473)
        Me.tabSell.TabIndex = 1
        Me.tabSell.Text = "فواتير البيع"
        Me.tabSell.UseVisualStyleBackColor = True
        '
        'grpSellTables
        '
        Me.grpSellTables.Controls.Add(Me.chkSellSelectAll)
        Me.grpSellTables.Controls.Add(Me.chkSellBAY)
        Me.grpSellTables.Controls.Add(Me.chkSellInvoceDetels)
        Me.grpSellTables.Controls.Add(Me.chkSellCastomerDETELS)
        Me.grpSellTables.Controls.Add(Me.chkSellFOMin)
        Me.grpSellTables.Controls.Add(Me.chkSellCacher)
        Me.grpSellTables.Controls.Add(Me.chkSellPayMethod)
        Me.grpSellTables.Controls.Add(Me.chkSellSettings)
        Me.grpSellTables.Controls.Add(Me.chkSellCompInform)
        Me.grpSellTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSellTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSellTables.Location = New System.Drawing.Point(2, 2)
        Me.grpSellTables.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSellTables.Name = "grpSellTables"
        Me.grpSellTables.Padding = New System.Windows.Forms.Padding(4)
        Me.grpSellTables.Size = New System.Drawing.Size(1069, 469)
        Me.grpSellTables.TabIndex = 0
        Me.grpSellTables.TabStop = False
        Me.grpSellTables.Text = "اختر الجداول للعرض عند البحث عن فاتورة بيع"
        '
        'chkSellSelectAll
        '
        Me.chkSellSelectAll.AutoSize = True
        Me.chkSellSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellSelectAll.Location = New System.Drawing.Point(15, 24)
        Me.chkSellSelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellSelectAll.Name = "chkSellSelectAll"
        Me.chkSellSelectAll.Size = New System.Drawing.Size(77, 19)
        Me.chkSellSelectAll.TabIndex = 0
        Me.chkSellSelectAll.Text = "تحديد الكل"
        Me.chkSellSelectAll.UseVisualStyleBackColor = True
        '
        'chkSellBAY
        '
        Me.chkSellBAY.AutoSize = True
        Me.chkSellBAY.Checked = True
        Me.chkSellBAY.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellBAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellBAY.Location = New System.Drawing.Point(15, 49)
        Me.chkSellBAY.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellBAY.Name = "chkSellBAY"
        Me.chkSellBAY.Size = New System.Drawing.Size(48, 19)
        Me.chkSellBAY.TabIndex = 1
        Me.chkSellBAY.Text = "BAY"
        Me.chkSellBAY.UseVisualStyleBackColor = True
        '
        'chkSellInvoceDetels
        '
        Me.chkSellInvoceDetels.AutoSize = True
        Me.chkSellInvoceDetels.Checked = True
        Me.chkSellInvoceDetels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellInvoceDetels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellInvoceDetels.Location = New System.Drawing.Point(15, 73)
        Me.chkSellInvoceDetels.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellInvoceDetels.Name = "chkSellInvoceDetels"
        Me.chkSellInvoceDetels.Size = New System.Drawing.Size(112, 19)
        Me.chkSellInvoceDetels.TabIndex = 2
        Me.chkSellInvoceDetels.Text = "selInvoceDetels"
        Me.chkSellInvoceDetels.UseVisualStyleBackColor = True
        '
        'chkSellCastomerDETELS
        '
        Me.chkSellCastomerDETELS.AutoSize = True
        Me.chkSellCastomerDETELS.Checked = True
        Me.chkSellCastomerDETELS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellCastomerDETELS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellCastomerDETELS.Location = New System.Drawing.Point(15, 98)
        Me.chkSellCastomerDETELS.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellCastomerDETELS.Name = "chkSellCastomerDETELS"
        Me.chkSellCastomerDETELS.Size = New System.Drawing.Size(126, 19)
        Me.chkSellCastomerDETELS.TabIndex = 3
        Me.chkSellCastomerDETELS.Text = "CastomerDETELS"
        Me.chkSellCastomerDETELS.UseVisualStyleBackColor = True
        '
        'chkSellFOMin
        '
        Me.chkSellFOMin.AutoSize = True
        Me.chkSellFOMin.Checked = True
        Me.chkSellFOMin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellFOMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellFOMin.Location = New System.Drawing.Point(15, 122)
        Me.chkSellFOMin.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellFOMin.Name = "chkSellFOMin"
        Me.chkSellFOMin.Size = New System.Drawing.Size(70, 19)
        Me.chkSellFOMin.TabIndex = 4
        Me.chkSellFOMin.Text = "FO_min"
        Me.chkSellFOMin.UseVisualStyleBackColor = True
        '
        'chkSellCacher
        '
        Me.chkSellCacher.AutoSize = True
        Me.chkSellCacher.Checked = True
        Me.chkSellCacher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellCacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellCacher.Location = New System.Drawing.Point(15, 146)
        Me.chkSellCacher.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellCacher.Name = "chkSellCacher"
        Me.chkSellCacher.Size = New System.Drawing.Size(63, 19)
        Me.chkSellCacher.TabIndex = 5
        Me.chkSellCacher.Text = "cacher"
        Me.chkSellCacher.UseVisualStyleBackColor = True
        '
        'chkSellPayMethod
        '
        Me.chkSellPayMethod.AutoSize = True
        Me.chkSellPayMethod.Checked = True
        Me.chkSellPayMethod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellPayMethod.Location = New System.Drawing.Point(15, 171)
        Me.chkSellPayMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellPayMethod.Name = "chkSellPayMethod"
        Me.chkSellPayMethod.Size = New System.Drawing.Size(88, 19)
        Me.chkSellPayMethod.TabIndex = 6
        Me.chkSellPayMethod.Text = "PayMethod"
        Me.chkSellPayMethod.UseVisualStyleBackColor = True
        '
        'chkSellSettings
        '
        Me.chkSellSettings.AutoSize = True
        Me.chkSellSettings.Checked = True
        Me.chkSellSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellSettings.Location = New System.Drawing.Point(15, 195)
        Me.chkSellSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellSettings.Name = "chkSellSettings"
        Me.chkSellSettings.Size = New System.Drawing.Size(70, 19)
        Me.chkSellSettings.TabIndex = 7
        Me.chkSellSettings.Text = "Settings"
        Me.chkSellSettings.UseVisualStyleBackColor = True
        '
        'chkSellCompInform
        '
        Me.chkSellCompInform.AutoSize = True
        Me.chkSellCompInform.Checked = True
        Me.chkSellCompInform.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSellCompInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSellCompInform.Location = New System.Drawing.Point(15, 219)
        Me.chkSellCompInform.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSellCompInform.Name = "chkSellCompInform"
        Me.chkSellCompInform.Size = New System.Drawing.Size(99, 19)
        Me.chkSellCompInform.TabIndex = 8
        Me.chkSellCompInform.Text = "comp_inform"
        Me.chkSellCompInform.UseVisualStyleBackColor = True
        '
        'tabDiamond
        '
        Me.tabDiamond.Controls.Add(Me.grpDiamondTables)
        Me.tabDiamond.Location = New System.Drawing.Point(4, 24)
        Me.tabDiamond.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDiamond.Name = "tabDiamond"
        Me.tabDiamond.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDiamond.Size = New System.Drawing.Size(1073, 473)
        Me.tabDiamond.TabIndex = 2
        Me.tabDiamond.Text = "فواتير بيع الماس"
        Me.tabDiamond.UseVisualStyleBackColor = True
        '
        'grpDiamondTables
        '
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondSelectAll)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondInvce)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondBay)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondCastomerDETELS)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondDetels)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondCacher)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondPayMethod)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondSettings)
        Me.grpDiamondTables.Controls.Add(Me.chkDiamondCompInform)
        Me.grpDiamondTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDiamondTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiamondTables.Location = New System.Drawing.Point(2, 2)
        Me.grpDiamondTables.Margin = New System.Windows.Forms.Padding(2)
        Me.grpDiamondTables.Name = "grpDiamondTables"
        Me.grpDiamondTables.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDiamondTables.Size = New System.Drawing.Size(1069, 469)
        Me.grpDiamondTables.TabIndex = 0
        Me.grpDiamondTables.TabStop = False
        Me.grpDiamondTables.Text = "اختر الجداول للعرض عند البحث عن فاتورة الماس"
        '
        'chkDiamondSelectAll
        '
        Me.chkDiamondSelectAll.AutoSize = True
        Me.chkDiamondSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondSelectAll.Location = New System.Drawing.Point(15, 24)
        Me.chkDiamondSelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondSelectAll.Name = "chkDiamondSelectAll"
        Me.chkDiamondSelectAll.Size = New System.Drawing.Size(77, 19)
        Me.chkDiamondSelectAll.TabIndex = 0
        Me.chkDiamondSelectAll.Text = "تحديد الكل"
        Me.chkDiamondSelectAll.UseVisualStyleBackColor = True
        '
        'chkDiamondInvce
        '
        Me.chkDiamondInvce.AutoSize = True
        Me.chkDiamondInvce.Checked = True
        Me.chkDiamondInvce.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondInvce.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondInvce.Location = New System.Drawing.Point(15, 49)
        Me.chkDiamondInvce.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondInvce.Name = "chkDiamondInvce"
        Me.chkDiamondInvce.Size = New System.Drawing.Size(96, 19)
        Me.chkDiamondInvce.TabIndex = 1
        Me.chkDiamondInvce.Text = "dimon_invce"
        Me.chkDiamondInvce.UseVisualStyleBackColor = True
        '
        'chkDiamondBay
        '
        Me.chkDiamondBay.AutoSize = True
        Me.chkDiamondBay.Checked = True
        Me.chkDiamondBay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBay.Location = New System.Drawing.Point(15, 73)
        Me.chkDiamondBay.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBay.Name = "chkDiamondBay"
        Me.chkDiamondBay.Size = New System.Drawing.Size(87, 19)
        Me.chkDiamondBay.TabIndex = 2
        Me.chkDiamondBay.Text = "dimon_bay"
        Me.chkDiamondBay.UseVisualStyleBackColor = True
        '
        'chkDiamondCastomerDETELS
        '
        Me.chkDiamondCastomerDETELS.AutoSize = True
        Me.chkDiamondCastomerDETELS.Checked = True
        Me.chkDiamondCastomerDETELS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondCastomerDETELS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondCastomerDETELS.Location = New System.Drawing.Point(15, 98)
        Me.chkDiamondCastomerDETELS.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondCastomerDETELS.Name = "chkDiamondCastomerDETELS"
        Me.chkDiamondCastomerDETELS.Size = New System.Drawing.Size(126, 19)
        Me.chkDiamondCastomerDETELS.TabIndex = 3
        Me.chkDiamondCastomerDETELS.Text = "CastomerDETELS"
        Me.chkDiamondCastomerDETELS.UseVisualStyleBackColor = True
        '
        'chkDiamondDetels
        '
        Me.chkDiamondDetels.AutoSize = True
        Me.chkDiamondDetels.Checked = True
        Me.chkDiamondDetels.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondDetels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondDetels.Location = New System.Drawing.Point(15, 122)
        Me.chkDiamondDetels.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondDetels.Name = "chkDiamondDetels"
        Me.chkDiamondDetels.Size = New System.Drawing.Size(107, 19)
        Me.chkDiamondDetels.TabIndex = 4
        Me.chkDiamondDetels.Text = "DIMON_detels"
        Me.chkDiamondDetels.UseVisualStyleBackColor = True
        '
        'chkDiamondCacher
        '
        Me.chkDiamondCacher.AutoSize = True
        Me.chkDiamondCacher.Checked = True
        Me.chkDiamondCacher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondCacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondCacher.Location = New System.Drawing.Point(15, 146)
        Me.chkDiamondCacher.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondCacher.Name = "chkDiamondCacher"
        Me.chkDiamondCacher.Size = New System.Drawing.Size(63, 19)
        Me.chkDiamondCacher.TabIndex = 5
        Me.chkDiamondCacher.Text = "cacher"
        Me.chkDiamondCacher.UseVisualStyleBackColor = True
        '
        'chkDiamondPayMethod
        '
        Me.chkDiamondPayMethod.AutoSize = True
        Me.chkDiamondPayMethod.Checked = True
        Me.chkDiamondPayMethod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondPayMethod.Location = New System.Drawing.Point(15, 171)
        Me.chkDiamondPayMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondPayMethod.Name = "chkDiamondPayMethod"
        Me.chkDiamondPayMethod.Size = New System.Drawing.Size(88, 19)
        Me.chkDiamondPayMethod.TabIndex = 6
        Me.chkDiamondPayMethod.Text = "PayMethod"
        Me.chkDiamondPayMethod.UseVisualStyleBackColor = True
        '
        'chkDiamondSettings
        '
        Me.chkDiamondSettings.AutoSize = True
        Me.chkDiamondSettings.Checked = True
        Me.chkDiamondSettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondSettings.Location = New System.Drawing.Point(15, 195)
        Me.chkDiamondSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondSettings.Name = "chkDiamondSettings"
        Me.chkDiamondSettings.Size = New System.Drawing.Size(70, 19)
        Me.chkDiamondSettings.TabIndex = 7
        Me.chkDiamondSettings.Text = "Settings"
        Me.chkDiamondSettings.UseVisualStyleBackColor = True
        '
        'chkDiamondCompInform
        '
        Me.chkDiamondCompInform.AutoSize = True
        Me.chkDiamondCompInform.Checked = True
        Me.chkDiamondCompInform.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondCompInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondCompInform.Location = New System.Drawing.Point(15, 219)
        Me.chkDiamondCompInform.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondCompInform.Name = "chkDiamondCompInform"
        Me.chkDiamondCompInform.Size = New System.Drawing.Size(99, 19)
        Me.chkDiamondCompInform.TabIndex = 8
        Me.chkDiamondCompInform.Text = "comp_inform"
        Me.chkDiamondCompInform.UseVisualStyleBackColor = True
        '
        'tabDiamondBuy
        '
        Me.tabDiamondBuy.Controls.Add(Me.grpDiamondBuyTables)
        Me.tabDiamondBuy.Location = New System.Drawing.Point(4, 24)
        Me.tabDiamondBuy.Margin = New System.Windows.Forms.Padding(2)
        Me.tabDiamondBuy.Name = "tabDiamondBuy"
        Me.tabDiamondBuy.Padding = New System.Windows.Forms.Padding(2)
        Me.tabDiamondBuy.Size = New System.Drawing.Size(1073, 473)
        Me.tabDiamondBuy.TabIndex = 3
        Me.tabDiamondBuy.Text = "فواتير شراء الماس"
        Me.tabDiamondBuy.UseVisualStyleBackColor = True
        '
        'grpDiamondBuyTables
        '
        Me.grpDiamondBuyTables.Controls.Add(Me.chkDiamondBuySelectAll)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkBuyDiamond)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkBayDiamondMony)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkDiamondBuyCastomerDETELS)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkDiamondBuyCacher)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkDiamondBuyPayMethod)
        Me.grpDiamondBuyTables.Controls.Add(Me.chkDiamondBuySettings)
        Me.grpDiamondBuyTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDiamondBuyTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiamondBuyTables.Location = New System.Drawing.Point(2, 2)
        Me.grpDiamondBuyTables.Margin = New System.Windows.Forms.Padding(2)
        Me.grpDiamondBuyTables.Name = "grpDiamondBuyTables"
        Me.grpDiamondBuyTables.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDiamondBuyTables.Size = New System.Drawing.Size(1069, 469)
        Me.grpDiamondBuyTables.TabIndex = 0
        Me.grpDiamondBuyTables.TabStop = False
        Me.grpDiamondBuyTables.Text = "اختر الجداول للعرض عند البحث عن فاتورة شراء الماس"
        '
        'chkDiamondBuySelectAll
        '
        Me.chkDiamondBuySelectAll.AutoSize = True
        Me.chkDiamondBuySelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBuySelectAll.Location = New System.Drawing.Point(15, 24)
        Me.chkDiamondBuySelectAll.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBuySelectAll.Name = "chkDiamondBuySelectAll"
        Me.chkDiamondBuySelectAll.Size = New System.Drawing.Size(77, 19)
        Me.chkDiamondBuySelectAll.TabIndex = 0
        Me.chkDiamondBuySelectAll.Text = "تحديد الكل"
        Me.chkDiamondBuySelectAll.UseVisualStyleBackColor = True
        '
        'chkBuyDiamond
        '
        Me.chkBuyDiamond.AutoSize = True
        Me.chkBuyDiamond.Checked = True
        Me.chkBuyDiamond.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBuyDiamond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBuyDiamond.Location = New System.Drawing.Point(15, 49)
        Me.chkBuyDiamond.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBuyDiamond.Name = "chkBuyDiamond"
        Me.chkBuyDiamond.Size = New System.Drawing.Size(104, 19)
        Me.chkBuyDiamond.TabIndex = 1
        Me.chkBuyDiamond.Text = "Buy_Diamond"
        Me.chkBuyDiamond.UseVisualStyleBackColor = True
        '
        'chkBayDiamondMony
        '
        Me.chkBayDiamondMony.AutoSize = True
        Me.chkBayDiamondMony.Checked = True
        Me.chkBayDiamondMony.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBayDiamondMony.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBayDiamondMony.Location = New System.Drawing.Point(15, 73)
        Me.chkBayDiamondMony.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBayDiamondMony.Name = "chkBayDiamondMony"
        Me.chkBayDiamondMony.Size = New System.Drawing.Size(141, 19)
        Me.chkBayDiamondMony.TabIndex = 2
        Me.chkBayDiamondMony.Text = "Bay_Diamond_mony"
        Me.chkBayDiamondMony.UseVisualStyleBackColor = True
        '
        'chkDiamondBuyCastomerDETELS
        '
        Me.chkDiamondBuyCastomerDETELS.AutoSize = True
        Me.chkDiamondBuyCastomerDETELS.Checked = True
        Me.chkDiamondBuyCastomerDETELS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondBuyCastomerDETELS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBuyCastomerDETELS.Location = New System.Drawing.Point(15, 98)
        Me.chkDiamondBuyCastomerDETELS.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBuyCastomerDETELS.Name = "chkDiamondBuyCastomerDETELS"
        Me.chkDiamondBuyCastomerDETELS.Size = New System.Drawing.Size(126, 19)
        Me.chkDiamondBuyCastomerDETELS.TabIndex = 3
        Me.chkDiamondBuyCastomerDETELS.Text = "CastomerDETELS"
        Me.chkDiamondBuyCastomerDETELS.UseVisualStyleBackColor = True
        '
        'chkDiamondBuyCacher
        '
        Me.chkDiamondBuyCacher.AutoSize = True
        Me.chkDiamondBuyCacher.Checked = True
        Me.chkDiamondBuyCacher.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondBuyCacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBuyCacher.Location = New System.Drawing.Point(15, 122)
        Me.chkDiamondBuyCacher.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBuyCacher.Name = "chkDiamondBuyCacher"
        Me.chkDiamondBuyCacher.Size = New System.Drawing.Size(63, 19)
        Me.chkDiamondBuyCacher.TabIndex = 4
        Me.chkDiamondBuyCacher.Text = "cacher"
        Me.chkDiamondBuyCacher.UseVisualStyleBackColor = True
        '
        'chkDiamondBuyPayMethod
        '
        Me.chkDiamondBuyPayMethod.AutoSize = True
        Me.chkDiamondBuyPayMethod.Checked = True
        Me.chkDiamondBuyPayMethod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondBuyPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBuyPayMethod.Location = New System.Drawing.Point(15, 146)
        Me.chkDiamondBuyPayMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBuyPayMethod.Name = "chkDiamondBuyPayMethod"
        Me.chkDiamondBuyPayMethod.Size = New System.Drawing.Size(88, 19)
        Me.chkDiamondBuyPayMethod.TabIndex = 5
        Me.chkDiamondBuyPayMethod.Text = "PayMethod"
        Me.chkDiamondBuyPayMethod.UseVisualStyleBackColor = True
        '
        'chkDiamondBuySettings
        '
        Me.chkDiamondBuySettings.AutoSize = True
        Me.chkDiamondBuySettings.Checked = True
        Me.chkDiamondBuySettings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDiamondBuySettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiamondBuySettings.Location = New System.Drawing.Point(15, 171)
        Me.chkDiamondBuySettings.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDiamondBuySettings.Name = "chkDiamondBuySettings"
        Me.chkDiamondBuySettings.Size = New System.Drawing.Size(70, 19)
        Me.chkDiamondBuySettings.TabIndex = 6
        Me.chkDiamondBuySettings.Text = "Settings"
        Me.chkDiamondBuySettings.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 611)
        Me.Controls.Add(Me.pnlTables)
        Me.Controls.Add(Me.pnlInactiveInvoices)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.dgvData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(754, 332)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بيانات قاعدة البيانات"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.pnlInactiveInvoices.ResumeLayout(False)
        Me.grpInactiveInvoices.ResumeLayout(False)
        Me.pnlTables.ResumeLayout(False)
        Me.tabInvoiceType.ResumeLayout(False)
        Me.tabBuy.ResumeLayout(False)
        Me.grpBuyTables.ResumeLayout(False)
        Me.grpBuyTables.PerformLayout()
        Me.tabSell.ResumeLayout(False)
        Me.grpSellTables.ResumeLayout(False)
        Me.grpSellTables.PerformLayout()
        Me.tabDiamond.ResumeLayout(False)
        Me.grpDiamondTables.ResumeLayout(False)
        Me.grpDiamondTables.PerformLayout()
        Me.tabDiamondBuy.ResumeLayout(False)
        Me.grpDiamondBuyTables.ResumeLayout(False)
        Me.grpDiamondBuyTables.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnShowCashiers As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchInvoice As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents pnlInactiveInvoices As System.Windows.Forms.Panel
    Friend WithEvents grpInactiveInvoices As System.Windows.Forms.GroupBox
    Friend WithEvents lstInactiveInvoices As System.Windows.Forms.ListBox
    Friend WithEvents btnShowInactiveInvoices As System.Windows.Forms.Button
    Friend WithEvents pnlTables As System.Windows.Forms.Panel
    Friend WithEvents tabInvoiceType As System.Windows.Forms.TabControl
    Friend WithEvents tabBuy As System.Windows.Forms.TabPage
    Friend WithEvents grpBuyTables As System.Windows.Forms.GroupBox
    Friend WithEvents chkBuyGold As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyCastomerDETELS As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyBayGoledMony As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyCacher As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyPayMethod As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuySettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyCompInform As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuySelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents tabSell As System.Windows.Forms.TabPage
    Friend WithEvents grpSellTables As System.Windows.Forms.GroupBox
    Friend WithEvents chkSellBAY As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellInvoceDetels As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellCastomerDETELS As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellFOMin As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellCacher As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellPayMethod As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellCompInform As System.Windows.Forms.CheckBox
    Friend WithEvents chkSellSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents radBuyInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents radSellInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents radDiamondInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents radDiamondBuyInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents btnCheckMissingData As System.Windows.Forms.Button
    Friend WithEvents btnCheckEditability As System.Windows.Forms.Button
    Friend WithEvents btnChangeInvoiceNumber As System.Windows.Forms.Button
    Friend WithEvents btnImportCustomers As System.Windows.Forms.Button
    Friend WithEvents tabDiamond As System.Windows.Forms.TabPage
    Friend WithEvents tabDiamondBuy As System.Windows.Forms.TabPage
    Friend WithEvents grpDiamondBuyTables As System.Windows.Forms.GroupBox
    Friend WithEvents chkDiamondBuySelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuyDiamond As System.Windows.Forms.CheckBox
    Friend WithEvents chkBayDiamondMony As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondBuyCastomerDETELS As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondBuyCacher As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondBuyPayMethod As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondBuySettings As System.Windows.Forms.CheckBox
    Friend WithEvents grpDiamondTables As System.Windows.Forms.GroupBox
    Friend WithEvents chkDiamondSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondInvce As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondBay As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondCastomerDETELS As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondDetels As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondCacher As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondPayMethod As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiamondCompInform As System.Windows.Forms.CheckBox
End Class
