<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmptyCellsReport
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
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.colTableName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColumnName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrimaryKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIssueType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDataType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblSummary = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTableName, Me.colColumnName, Me.colPrimaryKey, Me.colIssueType, Me.colDataType})
        Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReport.Location = New System.Drawing.Point(0, 41)
        Me.dgvReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(750, 365)
        Me.dgvReport.TabIndex = 0
        '
        'colTableName
        '
        Me.colTableName.HeaderText = "اسم الجدول"
        Me.colTableName.Name = "colTableName"
        Me.colTableName.ReadOnly = True
        '
        'colColumnName
        '
        Me.colColumnName.HeaderText = "اسم العمود"
        Me.colColumnName.Name = "colColumnName"
        Me.colColumnName.ReadOnly = True
        '
        'colPrimaryKey
        '
        Me.colPrimaryKey.HeaderText = "قيمة المفتاح الأساسي"
        Me.colPrimaryKey.Name = "colPrimaryKey"
        Me.colPrimaryKey.ReadOnly = True
        '
        'colIssueType
        '
        Me.colIssueType.HeaderText = "نوع المشكلة"
        Me.colIssueType.Name = "colIssueType"
        Me.colIssueType.ReadOnly = True
        '
        'colDataType
        '
        Me.colDataType.HeaderText = "نوع البيانات"
        Me.colDataType.Name = "colDataType"
        Me.colDataType.ReadOnly = True
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.lblSummary)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.pnlTop.Size = New System.Drawing.Size(750, 41)
        Me.pnlTop.TabIndex = 1
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(8, 8)
        Me.lblSummary.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Padding = New System.Windows.Forms.Padding(4, 4, 0, 0)
        Me.lblSummary.Size = New System.Drawing.Size(101, 21)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "جاري الفحص..."
        '
        'FormEmptyCellsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 406)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.pnlTop)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(604, 332)
        Me.Name = "FormEmptyCellsReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير الخلايا الفارغة"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents colTableName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colColumnName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPrimaryKey As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIssueType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDataType As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

