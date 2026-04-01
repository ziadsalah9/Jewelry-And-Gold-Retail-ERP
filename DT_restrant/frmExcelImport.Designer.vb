<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExcelImport
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblSheetName = New System.Windows.Forms.Label()
        Me.gbLoad = New System.Windows.Forms.GroupBox()
        Me.btnAlign = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ChkDuplicate = New System.Windows.Forms.CheckBox()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFileName
        '
        Me.lblFileName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(885, 35)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(77, 19)
        Me.lblFileName.TabIndex = 0
        Me.lblFileName.Text = "اسم الملف :"
        '
        'txtFilePath
        '
        Me.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtFilePath.Location = New System.Drawing.Point(596, 30)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(287, 27)
        Me.txtFilePath.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBrowse.Image = Global.DT_restrant.My.Resources.Resources.Folder_icon
        Me.btnBrowse.Location = New System.Drawing.Point(551, 23)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(40, 40)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid.Location = New System.Drawing.Point(12, 101)
        Me.grid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersWidth = 20
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.Size = New System.Drawing.Size(968, 508)
        Me.grid.TabIndex = 3
        '
        'lblSheetName
        '
        Me.lblSheetName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSheetName.AutoSize = True
        Me.lblSheetName.Location = New System.Drawing.Point(423, 33)
        Me.lblSheetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSheetName.Name = "lblSheetName"
        Me.lblSheetName.Size = New System.Drawing.Size(77, 19)
        Me.lblSheetName.TabIndex = 0
        Me.lblSheetName.Text = "اسم الورقة :"
        '
        'gbLoad
        '
        Me.gbLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLoad.Controls.Add(Me.ChkDuplicate)
        Me.gbLoad.Controls.Add(Me.btnAlign)
        Me.gbLoad.Controls.Add(Me.btnHelp)
        Me.gbLoad.Controls.Add(Me.cmbSheet)
        Me.gbLoad.Controls.Add(Me.lblFileName)
        Me.gbLoad.Controls.Add(Me.lblSheetName)
        Me.gbLoad.Controls.Add(Me.txtFilePath)
        Me.gbLoad.Controls.Add(Me.btnBrowse)
        Me.gbLoad.Location = New System.Drawing.Point(12, 13)
        Me.gbLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLoad.Name = "gbLoad"
        Me.gbLoad.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gbLoad.Size = New System.Drawing.Size(968, 80)
        Me.gbLoad.TabIndex = 5
        Me.gbLoad.TabStop = False
        Me.gbLoad.Text = "تحديد الملف"
        '
        'btnAlign
        '
        Me.btnAlign.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAlign.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.btnAlign.Location = New System.Drawing.Point(7, 20)
        Me.btnAlign.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlign.Name = "btnAlign"
        Me.btnAlign.Size = New System.Drawing.Size(58, 49)
        Me.btnAlign.TabIndex = 8
        Me.btnAlign.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnHelp.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnHelp.Location = New System.Drawing.Point(507, 23)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 40)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'cmbSheet
        '
        Me.cmbSheet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbSheet.DropDownHeight = 120
        Me.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.IntegralHeight = False
        Me.cmbSheet.Location = New System.Drawing.Point(283, 28)
        Me.cmbSheet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(137, 27)
        Me.cmbSheet.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(445, 616)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 48)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ChkDuplicate
        '
        Me.ChkDuplicate.Location = New System.Drawing.Point(72, 32)
        Me.ChkDuplicate.Name = "ChkDuplicate"
        Me.ChkDuplicate.Size = New System.Drawing.Size(204, 25)
        Me.ChkDuplicate.TabIndex = 9
        Me.ChkDuplicate.Text = "CheckBox1"
        Me.ChkDuplicate.UseVisualStyleBackColor = True
        '
        'frmExcelImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbLoad)
        Me.Controls.Add(Me.grid)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmExcelImport"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استيراد بيانات من ملف إكسل"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLoad.ResumeLayout(False)
        Me.gbLoad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblSheetName As System.Windows.Forms.Label
    Friend WithEvents gbLoad As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSheet As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnAlign As Button
    Friend WithEvents ChkDuplicate As System.Windows.Forms.CheckBox
End Class
