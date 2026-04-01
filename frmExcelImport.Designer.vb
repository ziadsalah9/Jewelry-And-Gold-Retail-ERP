<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExcelImport
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colSerial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFlatNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerNameEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWork = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWorkEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.lblFormName = New System.Windows.Forms.Label()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(859, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم الملف :"
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFilePath.Location = New System.Drawing.Point(555, 24)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(304, 23)
        Me.txtFilePath.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.Image = Global.BuildingManagement.My.Resources.Resources.Browse24
        Me.btnBrowse.Location = New System.Drawing.Point(521, 22)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 28)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Excel 2007/2010/2013 Files|*.xlsx"
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSerial, Me.colCustomerName, Me.colID, Me.colFlatNo, Me.colRentDate, Me.colPrice, Me.colCustomerNameEn, Me.colPhone, Me.colWork, Me.colWorkEn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.Location = New System.Drawing.Point(11, 104)
        Me.Grid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Grid.Name = "Grid"
        Me.Grid.RowHeadersWidth = 20
        Me.Grid.Size = New System.Drawing.Size(1142, 336)
        Me.Grid.TabIndex = 3
        '
        'colSerial
        '
        Me.colSerial.HeaderText = "م"
        Me.colSerial.Name = "colSerial"
        Me.colSerial.ReadOnly = True
        Me.colSerial.Width = 39
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "الاسم"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.Width = 59
        '
        'colID
        '
        Me.colID.HeaderText = "الرقم المدني"
        Me.colID.MaxInputLength = 12
        Me.colID.Name = "colID"
        Me.colID.Width = 93
        '
        'colFlatNo
        '
        Me.colFlatNo.HeaderText = "رقم الشقة"
        Me.colFlatNo.Name = "colFlatNo"
        Me.colFlatNo.Width = 81
        '
        'colRentDate
        '
        Me.colRentDate.HeaderText = "تاريخ الإيجار"
        Me.colRentDate.Name = "colRentDate"
        Me.colRentDate.Width = 88
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "الإيجار"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 61
        '
        'colCustomerNameEn
        '
        Me.colCustomerNameEn.HeaderText = "Name"
        Me.colCustomerNameEn.Name = "colCustomerNameEn"
        Me.colCustomerNameEn.Width = 64
        '
        'colPhone
        '
        Me.colPhone.HeaderText = "الهاتف"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.Width = 64
        '
        'colWork
        '
        Me.colWork.HeaderText = "جهة العمل"
        Me.colWork.Name = "colWork"
        Me.colWork.Width = 83
        '
        'colWorkEn
        '
        Me.colWorkEn.HeaderText = "Works At"
        Me.colWorkEn.Name = "colWorkEn"
        Me.colWorkEn.Width = 80
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم الورقة :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbSheet)
        Me.GroupBox1.Controls.Add(Me.btnHelp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFilePath)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(1142, 63)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تحديد الملف"
        '
        'cmbSheet
        '
        Me.cmbSheet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSheet.DropDownHeight = 120
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.IntegralHeight = False
        Me.cmbSheet.Location = New System.Drawing.Point(201, 24)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(121, 23)
        Me.cmbSheet.TabIndex = 6
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHelp.Image = Global.BuildingManagement.My.Resources.Resources.Help24
        Me.btnHelp.Location = New System.Drawing.Point(485, 22)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(30, 28)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnClose.Image = Global.BuildingManagement.My.Resources.Resources.Close32
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(638, 446)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 38)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "إغلاق"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'CmdSave
        '
        Me.CmdSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.Image = Global.BuildingManagement.My.Resources.Resources.Save32
        Me.CmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmdSave.Location = New System.Drawing.Point(436, 446)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(91, 38)
        Me.CmdSave.TabIndex = 12
        Me.CmdSave.Text = "حفظ"
        Me.CmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Image = Global.BuildingManagement.My.Resources.Resources.RefreshIcon
        Me.btnRefresh.Location = New System.Drawing.Point(1123, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(30, 29)
        Me.btnRefresh.TabIndex = 24
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lblFormName
        '
        Me.lblFormName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFormName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFormName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(11, 4)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(1106, 29)
        Me.lblFormName.TabIndex = 23
        Me.lblFormName.Text = "lblFormName"
        Me.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmImportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 490)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblFormName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "frmImportData"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استيراد بيانات مستأجرين من ملف إكسل"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents colSerial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFlatNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRentDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCustomerNameEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWork As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWorkEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbSheet As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblFormName As System.Windows.Forms.Label
End Class
