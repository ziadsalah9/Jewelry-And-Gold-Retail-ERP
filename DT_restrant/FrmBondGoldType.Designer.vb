<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBondGoldType
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
        Me.txtlBondType = New System.Windows.Forms.TextBox()
        Me.lblBondType = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtlBondTypeEn = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colBondNameAr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBondNameEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RdCreditor = New System.Windows.Forms.RadioButton()
        Me.RdDebtor = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBondTypeEN = New System.Windows.Forms.Label()
        Me.lblBondTypeAR = New System.Windows.Forms.Label()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtlBondType
        '
        Me.txtlBondType.Location = New System.Drawing.Point(5, 105)
        Me.txtlBondType.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtlBondType.MaxLength = 100
        Me.txtlBondType.Name = "txtlBondType"
        Me.txtlBondType.Size = New System.Drawing.Size(210, 27)
        Me.txtlBondType.TabIndex = 2
        Me.txtlBondType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBondType
        '
        Me.lblBondType.AutoEllipsis = True
        Me.lblBondType.Location = New System.Drawing.Point(4, 48)
        Me.lblBondType.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBondType.Name = "lblBondType"
        Me.lblBondType.Size = New System.Drawing.Size(422, 27)
        Me.lblBondType.TabIndex = 61
        Me.lblBondType.Text = "الفئة"
        Me.lblBondType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBondType.UseWaitCursor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(4, 2)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(101, 42)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(324, 2)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(101, 42)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "جديد"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(156, 2)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(134, 42)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtlBondTypeEn
        '
        Me.txtlBondTypeEn.Location = New System.Drawing.Point(216, 105)
        Me.txtlBondTypeEn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtlBondTypeEn.MaxLength = 100
        Me.txtlBondTypeEn.Name = "txtlBondTypeEn"
        Me.txtlBondTypeEn.Size = New System.Drawing.Size(210, 27)
        Me.txtlBondTypeEn.TabIndex = 1
        Me.txtlBondTypeEn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.ColumnHeadersVisible = False
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBondNameAr, Me.colBondNameEn, Me.colID})
        Me.grid.Location = New System.Drawing.Point(4, 206)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(422, 227)
        Me.grid.TabIndex = 67
        '
        'colBondNameAr
        '
        Me.colBondNameAr.HeaderText = "colBondNameAr"
        Me.colBondNameAr.Name = "colBondNameAr"
        Me.colBondNameAr.ReadOnly = True
        Me.colBondNameAr.Width = 210
        '
        'colBondNameEn
        '
        Me.colBondNameEn.HeaderText = "colBondNameEn"
        Me.colBondNameEn.Name = "colBondNameEn"
        Me.colBondNameEn.ReadOnly = True
        Me.colBondNameEn.Width = 210
        '
        'colID
        '
        Me.colID.HeaderText = "colID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'RdCreditor
        '
        Me.RdCreditor.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RdCreditor.Location = New System.Drawing.Point(4, 167)
        Me.RdCreditor.Name = "RdCreditor"
        Me.RdCreditor.Size = New System.Drawing.Size(211, 34)
        Me.RdCreditor.TabIndex = 0
        Me.RdCreditor.TabStop = True
        Me.RdCreditor.Text = "دائن"
        Me.RdCreditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdCreditor.UseVisualStyleBackColor = False
        '
        'RdDebtor
        '
        Me.RdDebtor.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RdDebtor.Location = New System.Drawing.Point(216, 167)
        Me.RdDebtor.Name = "RdDebtor"
        Me.RdDebtor.Size = New System.Drawing.Size(209, 34)
        Me.RdDebtor.TabIndex = 1
        Me.RdDebtor.TabStop = True
        Me.RdDebtor.Text = "مدين"
        Me.RdDebtor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdDebtor.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(5, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 27)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "تصنيف الفئه"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'lblBondTypeEN
        '
        Me.lblBondTypeEN.AutoEllipsis = True
        Me.lblBondTypeEN.Location = New System.Drawing.Point(216, 75)
        Me.lblBondTypeEN.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBondTypeEN.Name = "lblBondTypeEN"
        Me.lblBondTypeEN.Size = New System.Drawing.Size(211, 26)
        Me.lblBondTypeEN.TabIndex = 75
        Me.lblBondTypeEN.Text = "اسم الفئه انجليزي"
        Me.lblBondTypeEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBondTypeEN.UseWaitCursor = True
        '
        'lblBondTypeAR
        '
        Me.lblBondTypeAR.AutoEllipsis = True
        Me.lblBondTypeAR.Location = New System.Drawing.Point(5, 75)
        Me.lblBondTypeAR.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblBondTypeAR.Name = "lblBondTypeAR"
        Me.lblBondTypeAR.Size = New System.Drawing.Size(211, 26)
        Me.lblBondTypeAR.TabIndex = 74
        Me.lblBondTypeAR.Text = "اسم الفئه عربي"
        Me.lblBondTypeAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBondTypeAR.UseWaitCursor = True
        '
        'FrmBondGoldType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(431, 434)
        Me.Controls.Add(Me.lblBondTypeEN)
        Me.Controls.Add(Me.lblBondTypeAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RdCreditor)
        Me.Controls.Add(Me.RdDebtor)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtlBondTypeEn)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtlBondType)
        Me.Controls.Add(Me.lblBondType)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBondGoldType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBondGoldType"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtlBondType As System.Windows.Forms.TextBox
    Friend WithEvents lblBondType As System.Windows.Forms.Label
    Friend WithEvents txtlBondTypeEn As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents colBondNameAr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBondNameEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RdCreditor As RadioButton
    Friend WithEvents RdDebtor As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBondTypeEN As Label
    Friend WithEvents lblBondTypeAR As Label
End Class
