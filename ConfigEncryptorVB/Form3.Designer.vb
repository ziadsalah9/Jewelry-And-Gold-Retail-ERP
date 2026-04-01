<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvInvoiceData = New System.Windows.Forms.DataGridView()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.lblInvoiceInfo = New System.Windows.Forms.Label()
        CType(Me.dgvInvoiceData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvoiceData
        '
        Me.dgvInvoiceData.AllowUserToAddRows = False
        Me.dgvInvoiceData.AllowUserToDeleteRows = False
        Me.dgvInvoiceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvInvoiceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoiceData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInvoiceData.Location = New System.Drawing.Point(0, 41)
        Me.dgvInvoiceData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInvoiceData.Name = "dgvInvoiceData"
        Me.dgvInvoiceData.ReadOnly = True
        Me.dgvInvoiceData.RowTemplate.Height = 24
        Me.dgvInvoiceData.Size = New System.Drawing.Size(900, 528)
        Me.dgvInvoiceData.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlHeader.Controls.Add(Me.lblRowCount)
        Me.pnlHeader.Controls.Add(Me.lblInvoiceInfo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(8, 4, 8, 4)
        Me.pnlHeader.Size = New System.Drawing.Size(900, 41)
        Me.pnlHeader.TabIndex = 1
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblRowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowCount.Location = New System.Drawing.Point(818, 4)
        Me.lblRowCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.lblRowCount.Size = New System.Drawing.Size(74, 23)
        Me.lblRowCount.TabIndex = 1
        Me.lblRowCount.Text = "عدد السجلات: 0"
        '
        'lblInvoiceInfo
        '
        Me.lblInvoiceInfo.AutoSize = True
        Me.lblInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInvoiceInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceInfo.Location = New System.Drawing.Point(8, 4)
        Me.lblInvoiceInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInvoiceInfo.Name = "lblInvoiceInfo"
        Me.lblInvoiceInfo.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
        Me.lblInvoiceInfo.Size = New System.Drawing.Size(85, 25)
        Me.lblInvoiceInfo.TabIndex = 0
        Me.lblInvoiceInfo.Text = "بيانات الفاتورة"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 569)
        Me.Controls.Add(Me.dgvInvoiceData)
        Me.Controls.Add(Me.pnlHeader)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(604, 414)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "بيانات الفاتورة"
        CType(Me.dgvInvoiceData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInvoiceData As System.Windows.Forms.DataGridView
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblInvoiceInfo As System.Windows.Forms.Label
    Friend WithEvents lblRowCount As System.Windows.Forms.Label
End Class
