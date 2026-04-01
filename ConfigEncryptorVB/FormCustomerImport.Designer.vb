Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerImport
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlFileSelection = New System.Windows.Forms.Panel()
        Me.grpFileSelection = New System.Windows.Forms.GroupBox()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.lblSheet = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabImport = New System.Windows.Forms.TabPage()
        Me.pnlLog = New System.Windows.Forms.Panel()
        Me.grpLog = New System.Windows.Forms.GroupBox()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.grpPreview = New System.Windows.Forms.GroupBox()
        Me.dgvPreview = New System.Windows.Forms.DataGridView()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.tabCustomers = New System.Windows.Forms.TabPage()
        Me.pnlCustomers = New System.Windows.Forms.Panel()
        Me.grpCustomers = New System.Windows.Forms.GroupBox()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.pnlTop.SuspendLayout()
        Me.pnlFileSelection.SuspendLayout()
        Me.grpFileSelection.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabImport.SuspendLayout()
        Me.pnlLog.SuspendLayout()
        Me.grpLog.SuspendLayout()
        Me.pnlPreview.SuspendLayout()
        Me.grpPreview.SuspendLayout()
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.tabCustomers.SuspendLayout()
        Me.pnlCustomers.SuspendLayout()
        Me.grpCustomers.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblStatus)
        Me.pnlTop.Controls.Add(Me.btnClose)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlTop.Size = New System.Drawing.Size(1000, 40)
        Me.pnlTop.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(5, 5)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(5, 8, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(37, 22)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "جاهز"
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Location = New System.Drawing.Point(900, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(95, 30)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "إغلاق"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlFileSelection
        '
        Me.pnlFileSelection.Controls.Add(Me.grpFileSelection)
        Me.pnlFileSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFileSelection.Location = New System.Drawing.Point(0, 40)
        Me.pnlFileSelection.Name = "pnlFileSelection"
        Me.pnlFileSelection.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlFileSelection.Size = New System.Drawing.Size(1000, 80)
        Me.pnlFileSelection.TabIndex = 1
        '
        'grpFileSelection
        '
        Me.grpFileSelection.Controls.Add(Me.cmbSheet)
        Me.grpFileSelection.Controls.Add(Me.lblSheet)
        Me.grpFileSelection.Controls.Add(Me.btnBrowse)
        Me.grpFileSelection.Controls.Add(Me.txtFilePath)
        Me.grpFileSelection.Controls.Add(Me.lblFilePath)
        Me.grpFileSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFileSelection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFileSelection.Location = New System.Drawing.Point(5, 5)
        Me.grpFileSelection.Name = "grpFileSelection"
        Me.grpFileSelection.Size = New System.Drawing.Size(990, 70)
        Me.grpFileSelection.TabIndex = 0
        Me.grpFileSelection.TabStop = False
        Me.grpFileSelection.Text = "اختيار ملف Excel"
        '
        'cmbSheet
        '
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.Location = New System.Drawing.Point(10, 40)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(200, 22)
        Me.cmbSheet.TabIndex = 4
        '
        'lblSheet
        '
        Me.lblSheet.AutoSize = True
        Me.lblSheet.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSheet.Location = New System.Drawing.Point(220, 43)
        Me.lblSheet.Name = "lblSheet"
        Me.lblSheet.Size = New System.Drawing.Size(64, 14)
        Me.lblSheet.TabIndex = 3
        Me.lblSheet.Text = "ورقة العمل:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(770, 15)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(95, 25)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "تصفح..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilePath.Location = New System.Drawing.Point(10, 15)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(750, 22)
        Me.txtFilePath.TabIndex = 1
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(770, 18)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(70, 14)
        Me.lblFilePath.TabIndex = 0
        Me.lblFilePath.Text = "مسار الملف:"
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabImport)
        Me.tabMain.Controls.Add(Me.tabCustomers)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(0, 120)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.RightToLeftLayout = True
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1000, 450)
        Me.tabMain.TabIndex = 2
        '
        'tabImport
        '
        Me.tabImport.Controls.Add(Me.pnlLog)
        Me.tabImport.Controls.Add(Me.pnlPreview)
        Me.tabImport.Controls.Add(Me.pnlButtons)
        Me.tabImport.Location = New System.Drawing.Point(4, 23)
        Me.tabImport.Name = "tabImport"
        Me.tabImport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabImport.Size = New System.Drawing.Size(992, 423)
        Me.tabImport.TabIndex = 0
        Me.tabImport.Text = "استيراد من Excel"
        Me.tabImport.UseVisualStyleBackColor = True
        '
        'pnlLog
        '
        Me.pnlLog.Controls.Add(Me.grpLog)
        Me.pnlLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLog.Location = New System.Drawing.Point(3, 153)
        Me.pnlLog.Name = "pnlLog"
        Me.pnlLog.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlLog.Size = New System.Drawing.Size(986, 220)
        Me.pnlLog.TabIndex = 4
        '
        'grpLog
        '
        Me.grpLog.Controls.Add(Me.rtbLog)
        Me.grpLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLog.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLog.Location = New System.Drawing.Point(5, 5)
        Me.grpLog.Name = "grpLog"
        Me.grpLog.Size = New System.Drawing.Size(976, 210)
        Me.grpLog.TabIndex = 0
        Me.grpLog.TabStop = False
        Me.grpLog.Text = "سجل الاستيراد"
        '
        'rtbLog
        '
        Me.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbLog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLog.Location = New System.Drawing.Point(3, 18)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.ReadOnly = True
        Me.rtbLog.Size = New System.Drawing.Size(970, 189)
        Me.rtbLog.TabIndex = 0
        Me.rtbLog.Text = ""
        '
        'pnlPreview
        '
        Me.pnlPreview.Controls.Add(Me.grpPreview)
        Me.pnlPreview.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPreview.Location = New System.Drawing.Point(3, 3)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlPreview.Size = New System.Drawing.Size(986, 150)
        Me.pnlPreview.TabIndex = 2
        '
        'grpPreview
        '
        Me.grpPreview.Controls.Add(Me.dgvPreview)
        Me.grpPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPreview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPreview.Location = New System.Drawing.Point(5, 5)
        Me.grpPreview.Name = "grpPreview"
        Me.grpPreview.Size = New System.Drawing.Size(976, 140)
        Me.grpPreview.TabIndex = 0
        Me.grpPreview.TabStop = False
        Me.grpPreview.Text = "معاينة البيانات"
        '
        'dgvPreview
        '
        Me.dgvPreview.AllowUserToAddRows = False
        Me.dgvPreview.AllowUserToDeleteRows = False
        Me.dgvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPreview.Location = New System.Drawing.Point(3, 18)
        Me.dgvPreview.Name = "dgvPreview"
        Me.dgvPreview.ReadOnly = True
        Me.dgvPreview.RowTemplate.Height = 24
        Me.dgvPreview.Size = New System.Drawing.Size(970, 119)
        Me.dgvPreview.TabIndex = 0
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnClearLog)
        Me.pnlButtons.Controls.Add(Me.btnImport)
        Me.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlButtons.Location = New System.Drawing.Point(3, 373)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlButtons.Size = New System.Drawing.Size(986, 47)
        Me.pnlButtons.TabIndex = 3
        '
        'btnClearLog
        '
        Me.btnClearLog.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearLog.Location = New System.Drawing.Point(170, 10)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(120, 35)
        Me.btnClearLog.TabIndex = 1
        Me.btnClearLog.Text = "مسح السجل"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.Location = New System.Drawing.Point(10, 10)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(150, 35)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "استيراد البيانات"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'tabCustomers
        '
        Me.tabCustomers.Controls.Add(Me.pnlCustomers)
        Me.tabCustomers.Controls.Add(Me.pnlSearch)
        Me.tabCustomers.Location = New System.Drawing.Point(4, 23)
        Me.tabCustomers.Name = "tabCustomers"
        Me.tabCustomers.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustomers.Size = New System.Drawing.Size(992, 373)
        Me.tabCustomers.TabIndex = 1
        Me.tabCustomers.Text = "عرض العملاء"
        Me.tabCustomers.UseVisualStyleBackColor = True
        '
        'pnlCustomers
        '
        Me.pnlCustomers.Controls.Add(Me.grpCustomers)
        Me.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomers.Location = New System.Drawing.Point(3, 60)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlCustomers.Size = New System.Drawing.Size(986, 310)
        Me.pnlCustomers.TabIndex = 1
        '
        'grpCustomers
        '
        Me.grpCustomers.Controls.Add(Me.dgvCustomers)
        Me.grpCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCustomers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomers.Location = New System.Drawing.Point(5, 5)
        Me.grpCustomers.Name = "grpCustomers"
        Me.grpCustomers.Size = New System.Drawing.Size(976, 300)
        Me.grpCustomers.TabIndex = 0
        Me.grpCustomers.TabStop = False
        Me.grpCustomers.Text = "قائمة العملاء"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomers.Location = New System.Drawing.Point(3, 18)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowTemplate.Height = 24
        Me.dgvCustomers.Size = New System.Drawing.Size(970, 279)
        Me.dgvCustomers.TabIndex = 0
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.grpSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(3, 3)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(5)
        Me.pnlSearch.Size = New System.Drawing.Size(986, 57)
        Me.pnlSearch.TabIndex = 0
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnRefresh)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Controls.Add(Me.lblSearch)
        Me.grpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(5, 5)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(976, 47)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "بحث"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(10, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 25)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "تحديث القائمة"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(120, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 25)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "بحث"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(230, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(400, 22)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(640, 23)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(153, 14)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "ابحث بالرقم المدني أو الاسم:"
        '
        'FormCustomerImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 570)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlFileSelection)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormCustomerImport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استيراد بيانات العملاء من Excel"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlFileSelection.ResumeLayout(False)
        Me.grpFileSelection.ResumeLayout(False)
        Me.grpFileSelection.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabImport.ResumeLayout(False)
        Me.pnlLog.ResumeLayout(False)
        Me.grpLog.ResumeLayout(False)
        Me.pnlPreview.ResumeLayout(False)
        Me.grpPreview.ResumeLayout(False)
        CType(Me.dgvPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.tabCustomers.ResumeLayout(False)
        Me.pnlCustomers.ResumeLayout(False)
        Me.grpCustomers.ResumeLayout(False)
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlFileSelection As Panel
    Friend WithEvents grpFileSelection As GroupBox
    Friend WithEvents cmbSheet As ComboBox
    Friend WithEvents lblSheet As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents lblFilePath As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabImport As TabPage
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents grpPreview As GroupBox
    Friend WithEvents dgvPreview As DataGridView
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnClearLog As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents pnlLog As Panel
    Friend WithEvents grpLog As GroupBox
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents tabCustomers As TabPage
    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents grpCustomers As GroupBox
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label

End Class

