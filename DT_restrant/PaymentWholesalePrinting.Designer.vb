<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentWholesalePrinting
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
        Me.RepPaymentWholesalePrinting = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comboxInvNO = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.BackWorkerLodInvoce = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'RepPaymentWholesalePrinting
        '
        Me.RepPaymentWholesalePrinting.LocalReport.ReportPath = ""
        Me.RepPaymentWholesalePrinting.Location = New System.Drawing.Point(2, 62)
        Me.RepPaymentWholesalePrinting.Name = "RepPaymentWholesalePrinting"
        Me.RepPaymentWholesalePrinting.ServerReport.BearerToken = Nothing
        Me.RepPaymentWholesalePrinting.ShowBackButton = False
        Me.RepPaymentWholesalePrinting.ShowFindControls = False
        Me.RepPaymentWholesalePrinting.ShowPageNavigationControls = False
        Me.RepPaymentWholesalePrinting.ShowStopButton = False
        Me.RepPaymentWholesalePrinting.ShowZoomControl = False
        Me.RepPaymentWholesalePrinting.Size = New System.Drawing.Size(634, 685)
        Me.RepPaymentWholesalePrinting.TabIndex = 99
        '
        'comboxInvNO
        '
        Me.comboxInvNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboxInvNO.FormattingEnabled = True
        Me.comboxInvNO.Location = New System.Drawing.Point(444, 33)
        Me.comboxInvNO.Margin = New System.Windows.Forms.Padding(4)
        Me.comboxInvNO.Name = "comboxInvNO"
        Me.comboxInvNO.Size = New System.Drawing.Size(192, 26)
        Me.comboxInvNO.TabIndex = 168
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(282, 1)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(158, 59)
        Me.btnView.TabIndex = 165
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(2, 2)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(165, 58)
        Me.btnPrint.TabIndex = 166
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoiceNo.Location = New System.Drawing.Point(444, 1)
        Me.lblInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(192, 33)
        Me.lblInvoiceNo.TabIndex = 167
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackWorkerLodInvoce
        '
        '
        'PaymentWholesalePrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 750)
        Me.Controls.Add(Me.comboxInvNO)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.RepPaymentWholesalePrinting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PaymentWholesalePrinting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentWholesalePrinting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepPaymentWholesalePrinting As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents comboxInvNO As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents BackWorkerLodInvoce As System.ComponentModel.BackgroundWorker
End Class
