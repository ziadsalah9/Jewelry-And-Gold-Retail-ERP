<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViwGoldVoucherReserve
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViwGoldVoucherReserve))
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.RptView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackgroundWorkerGetInv = New System.ComponentModel.BackgroundWorker()
        Me.BackWorkInv = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(419, 33)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(192, 27)
        Me.txtInvoiceNo.TabIndex = 164
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(257, 4)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(158, 59)
        Me.btnView.TabIndex = 161
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(4, 5)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(165, 58)
        Me.btnPrint.TabIndex = 162
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(419, 4)
        Me.lblInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(192, 27)
        Me.lblInvoiceNo.TabIndex = 163
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RptView
        '
        Me.RptView.Location = New System.Drawing.Point(4, 67)
        Me.RptView.Name = "RptView"
        Me.RptView.ServerReport.BearerToken = Nothing
        Me.RptView.Size = New System.Drawing.Size(607, 609)
        Me.RptView.TabIndex = 165
        '
        'BackgroundWorkerGetInv
        '
        '
        'BackWorkInv
        '
        '
        'frmViwGoldVoucherReserve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 688)
        Me.Controls.Add(Me.RptView)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViwGoldVoucherReserve"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmViwGoldVoucherReserve"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtInvoiceNo As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents RptView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BackgroundWorkerGetInv As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackWorkInv As System.ComponentModel.BackgroundWorker
End Class
