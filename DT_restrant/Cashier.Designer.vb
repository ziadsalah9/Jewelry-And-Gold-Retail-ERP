<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cashier))
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colcacherID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcacher_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coladr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colsvil_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCashierSignature = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Cacher_nameTextBox = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.AdrTextBox = New System.Windows.Forms.TextBox()
        Me.Start_warkDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.pbSignature = New System.Windows.Forms.PictureBox()
        Me.lnkSignature = New System.Windows.Forms.LinkLabel()
        Me.lnkSignature2 = New System.Windows.Forms.LinkLabel()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCashierName
        '
        Me.lblCashierName.Location = New System.Drawing.Point(394, 63)
        Me.lblCashierName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(95, 27)
        Me.lblCashierName.TabIndex = 45
        Me.lblCashierName.Text = "اسم الكاشير"
        Me.lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(394, 94)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(95, 27)
        Me.lblAddress.TabIndex = 51
        Me.lblAddress.Text = "العنوان"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCID
        '
        Me.lblCID.Location = New System.Drawing.Point(394, 126)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(95, 27)
        Me.lblCID.TabIndex = 56
        Me.lblCID.Text = "الرقم المدني"
        Me.lblCID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.Honeydew
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colcacherID, Me.colcacher_name, Me.coladr, Me.colsvil_id, Me.colCashierSignature})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid.GridColor = System.Drawing.Color.Black
        Me.grid.Location = New System.Drawing.Point(3, 157)
        Me.grid.Margin = New System.Windows.Forms.Padding(4)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersWidth = 10
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(488, 236)
        Me.grid.TabIndex = 9
        '
        'colcacherID
        '
        Me.colcacherID.HeaderText = "cacherID"
        Me.colcacherID.Name = "colcacherID"
        Me.colcacherID.ReadOnly = True
        Me.colcacherID.Visible = False
        '
        'colcacher_name
        '
        Me.colcacher_name.HeaderText = "cacher_name"
        Me.colcacher_name.Name = "colcacher_name"
        Me.colcacher_name.ReadOnly = True
        '
        'coladr
        '
        Me.coladr.HeaderText = "adr"
        Me.coladr.Name = "coladr"
        Me.coladr.ReadOnly = True
        '
        'colsvil_id
        '
        Me.colsvil_id.HeaderText = "svil_id"
        Me.colsvil_id.Name = "colsvil_id"
        Me.colsvil_id.ReadOnly = True
        '
        'colCashierSignature
        '
        Me.colCashierSignature.HeaderText = "CashierSignature"
        Me.colCashierSignature.Name = "colCashierSignature"
        Me.colCashierSignature.ReadOnly = True
        Me.colCashierSignature.Visible = False
        '
        'Cacher_nameTextBox
        '
        Me.Cacher_nameTextBox.Location = New System.Drawing.Point(220, 63)
        Me.Cacher_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cacher_nameTextBox.Name = "Cacher_nameTextBox"
        Me.Cacher_nameTextBox.Size = New System.Drawing.Size(174, 27)
        Me.Cacher_nameTextBox.TabIndex = 0
        Me.Cacher_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(403, 3)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(89, 57)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "جديد"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(314, 3)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 57)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(220, 126)
        Me.txtCID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCID.MaxLength = 12
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(174, 27)
        Me.txtCID.TabIndex = 2
        Me.txtCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AdrTextBox
        '
        Me.AdrTextBox.Location = New System.Drawing.Point(220, 94)
        Me.AdrTextBox.Name = "AdrTextBox"
        Me.AdrTextBox.Size = New System.Drawing.Size(174, 27)
        Me.AdrTextBox.TabIndex = 1
        Me.AdrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Start_warkDateTimePicker
        '
        Me.Start_warkDateTimePicker.Location = New System.Drawing.Point(743, 12)
        Me.Start_warkDateTimePicker.Name = "Start_warkDateTimePicker"
        Me.Start_warkDateTimePicker.Size = New System.Drawing.Size(58, 27)
        Me.Start_warkDateTimePicker.TabIndex = 53
        '
        'pbSignature
        '
        Me.pbSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSignature.Location = New System.Drawing.Point(3, 63)
        Me.pbSignature.Name = "pbSignature"
        Me.pbSignature.Size = New System.Drawing.Size(214, 90)
        Me.pbSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSignature.TabIndex = 54
        Me.pbSignature.TabStop = False
        '
        'lnkSignature
        '
        Me.lnkSignature.Location = New System.Drawing.Point(3, 5)
        Me.lnkSignature.Name = "lnkSignature"
        Me.lnkSignature.Size = New System.Drawing.Size(214, 26)
        Me.lnkSignature.TabIndex = 55
        Me.lnkSignature.TabStop = True
        Me.lnkSignature.Text = "التوقيع"
        Me.lnkSignature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lnkSignature2
        '
        Me.lnkSignature2.Location = New System.Drawing.Point(3, 31)
        Me.lnkSignature2.Name = "lnkSignature2"
        Me.lnkSignature2.Size = New System.Drawing.Size(214, 29)
        Me.lnkSignature2.TabIndex = 57
        Me.lnkSignature2.TabStop = True
        Me.lnkSignature2.Text = "التوقيع"
        Me.lnkSignature2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Crimson
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.ForeColor = System.Drawing.Color.White
        Me.btnDel.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(220, 3)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(94, 57)
        Me.btnDel.TabIndex = 58
        Me.btnDel.Text = "حذف"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'Cashier
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 395)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.lnkSignature2)
        Me.Controls.Add(Me.lblCID)
        Me.Controls.Add(Me.lnkSignature)
        Me.Controls.Add(Me.pbSignature)
        Me.Controls.Add(Me.Start_warkDateTimePicker)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.AdrTextBox)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCashierName)
        Me.Controls.Add(Me.txtCID)
        Me.Controls.Add(Me.Cacher_nameTextBox)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة كاشير"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Cacher_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents AdrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Start_warkDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents pbSignature As System.Windows.Forms.PictureBox
    Friend WithEvents lnkSignature As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCashierName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCID As System.Windows.Forms.Label
    Friend WithEvents lnkSignature2 As LinkLabel
    Friend WithEvents colcacherID As DataGridViewTextBoxColumn
    Friend WithEvents colcacher_name As DataGridViewTextBoxColumn
    Friend WithEvents coladr As DataGridViewTextBoxColumn
    Friend WithEvents colsvil_id As DataGridViewTextBoxColumn
    Friend WithEvents btnDel As Button
    Friend WithEvents colCashierSignature As DataGridViewImageColumn
End Class
