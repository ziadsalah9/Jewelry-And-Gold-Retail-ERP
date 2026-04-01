<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiamondViewSellInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiamondViewSellInvoice))
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.ChkWholeSale = New System.Windows.Forms.CheckBox()
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.BackWorkLoodInv = New System.ComponentModel.BackgroundWorker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(300, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 60)
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
        Me.btnPrint.Location = New System.Drawing.Point(8, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 60)
        Me.btnPrint.TabIndex = 162
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(602, 9)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(73, 19)
        Me.lblInvoiceNo.TabIndex = 163
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.Location = New System.Drawing.Point(543, 38)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(134, 25)
        Me.chkEngInvoice.TabIndex = 160
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(928, 90)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 165
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'ChkWholeSale
        '
        Me.ChkWholeSale.AutoSize = True
        Me.ChkWholeSale.Location = New System.Drawing.Point(444, 38)
        Me.ChkWholeSale.Name = "ChkWholeSale"
        Me.ChkWholeSale.Size = New System.Drawing.Size(93, 23)
        Me.ChkWholeSale.TabIndex = 168
        Me.ChkWholeSale.Text = "فاتورة جملة"
        Me.ChkWholeSale.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(444, 5)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(152, 27)
        Me.txtInvoiceNo.TabIndex = 169
        '
        'BackWorkLoodInv
        '
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(669, 657)
        Me.ReportViewer1.TabIndex = 170
        '
        'DiamondViewSellInvoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 724)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.ChkWholeSale)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.chkEngInvoice)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DiamondViewSellInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مراجعة فواتير الألماس"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents ChkWholeSale As System.Windows.Forms.CheckBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents BackWorkLoodInv As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
