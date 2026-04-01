<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViwCastomerInvData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViwCastomerInvData))
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colViwInv = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colCatomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKenet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.BtnPrint = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colViwInv, Me.colCatomerName, Me.colCastomTel, Me.colCashier, Me.colGoldW, Me.colCash, Me.colKenet, Me.colTotalAmount, Me.colInvNo, Me.colDate})
        Me.grid.Location = New System.Drawing.Point(3, 41)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grid.Size = New System.Drawing.Size(1110, 1122)
        Me.grid.TabIndex = 0
        '
        'colViwInv
        '
        Me.colViwInv.HeaderText = "colViwInv"
        Me.colViwInv.Name = "colViwInv"
        Me.colViwInv.ReadOnly = True
        Me.colViwInv.Width = 50
        '
        'colCatomerName
        '
        Me.colCatomerName.HeaderText = "colCatomerName"
        Me.colCatomerName.Name = "colCatomerName"
        Me.colCatomerName.ReadOnly = True
        Me.colCatomerName.Width = 175
        '
        'colCastomTel
        '
        Me.colCastomTel.HeaderText = "colCastomTel"
        Me.colCastomTel.Name = "colCastomTel"
        Me.colCastomTel.ReadOnly = True
        '
        'colCashier
        '
        Me.colCashier.HeaderText = "colCashier"
        Me.colCashier.Name = "colCashier"
        Me.colCashier.ReadOnly = True
        '
        'colGoldW
        '
        Me.colGoldW.HeaderText = "colGoldW"
        Me.colGoldW.Name = "colGoldW"
        Me.colGoldW.ReadOnly = True
        '
        'colCash
        '
        Me.colCash.HeaderText = "colCash"
        Me.colCash.Name = "colCash"
        Me.colCash.ReadOnly = True
        Me.colCash.Width = 75
        '
        'colKenet
        '
        Me.colKenet.HeaderText = "colKenet"
        Me.colKenet.Name = "colKenet"
        Me.colKenet.ReadOnly = True
        Me.colKenet.Width = 75
        '
        'colTotalAmount
        '
        Me.colTotalAmount.HeaderText = "colTotalAmount"
        Me.colTotalAmount.Name = "colTotalAmount"
        Me.colTotalAmount.ReadOnly = True
        Me.colTotalAmount.Width = 125
        '
        'colInvNo
        '
        Me.colInvNo.HeaderText = "colInvNo"
        Me.colInvNo.Name = "colInvNo"
        Me.colInvNo.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "colDate"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 225
        '
        'PrintDialog
        '
        Me.PrintDialog.Document = Me.PrintDoc
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDoc
        '
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Document = Me.PrintDoc
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PageSetupDialog
        '
        Me.PageSetupDialog.Document = Me.PrintDoc
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.DarkGray
        Me.BtnPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPrint.Image = Global.DT_restrant.My.Resources.Resources.Printer_32
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(3, 0)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(125, 41)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'FrmViwCastomerInvData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1129, 345)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmViwCastomerInvData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmViwCastomerInvData"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PrintDialog As PrintDialog
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PageSetupDialog As PageSetupDialog
    Friend WithEvents colViwInv As DataGridViewButtonColumn
    Friend WithEvents colCatomerName As DataGridViewTextBoxColumn
    Friend WithEvents colCastomTel As DataGridViewTextBoxColumn
    Friend WithEvents colCashier As DataGridViewTextBoxColumn
    Friend WithEvents colGoldW As DataGridViewTextBoxColumn
    Friend WithEvents colCash As DataGridViewTextBoxColumn
    Friend WithEvents colKenet As DataGridViewTextBoxColumn
    Friend WithEvents colTotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents colInvNo As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
End Class
