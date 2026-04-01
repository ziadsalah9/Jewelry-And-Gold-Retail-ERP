<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTableData
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
        Me.dgvTableData = New System.Windows.Forms.DataGridView()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.dgvTableData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTableData
        '
        Me.dgvTableData.AllowUserToAddRows = False
        Me.dgvTableData.AllowUserToDeleteRows = False
        Me.dgvTableData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTableData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTableData.Location = New System.Drawing.Point(0, 18)
        Me.dgvTableData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvTableData.Name = "dgvTableData"
        Me.dgvTableData.ReadOnly = True
        Me.dgvTableData.RowTemplate.Height = 24
        Me.dgvTableData.Size = New System.Drawing.Size(1000, 582)
        Me.dgvTableData.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(87, 18)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "جاري التحميل..."
        '
        'FormTableData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.dgvTableData)
        Me.Controls.Add(Me.lblStatus)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormTableData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "بيانات الجدول"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.dgvTableData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTableData As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatus As System.Windows.Forms.Label
End Class

