<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From_ReportSndToCustomer
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(From_ReportSndToCustomer))
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Re_View_SndToCustomer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(670, 12)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(50, 13)
        Me.lblInvoiceNo.TabIndex = 166
        Me.lblInvoiceNo.Text = "رقم السند"
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.Location = New System.Drawing.Point(518, 37)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(202, 27)
        Me.chkEngInvoice.TabIndex = 161
        Me.chkEngInvoice.Text = " إنجليزي"
        Me.chkEngInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.LightCyan
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(517, 6)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(150, 26)
        Me.txtInvoiceNo.TabIndex = 160
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Re_View_SndToCustomer
        '
        Me.Re_View_SndToCustomer.BackColor = System.Drawing.Color.Gainsboro
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.Re_View_SndToCustomer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Re_View_SndToCustomer.LocalReport.ReportEmbeddedResource = ""
        Me.Re_View_SndToCustomer.LocalReport.ReportPath = ""
        Me.Re_View_SndToCustomer.Location = New System.Drawing.Point(11, 71)
        Me.Re_View_SndToCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.Re_View_SndToCustomer.Name = "Re_View_SndToCustomer"
        Me.Re_View_SndToCustomer.ShowBackButton = False
        Me.Re_View_SndToCustomer.ShowContextMenu = False
        Me.Re_View_SndToCustomer.ShowCredentialPrompts = False
        Me.Re_View_SndToCustomer.ShowDocumentMapButton = False
        Me.Re_View_SndToCustomer.ShowParameterPrompts = False
        Me.Re_View_SndToCustomer.ShowStopButton = False
        Me.Re_View_SndToCustomer.ShowToolBar = False
        Me.Re_View_SndToCustomer.Size = New System.Drawing.Size(708, 718)
        Me.Re_View_SndToCustomer.TabIndex = 164
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Location = New System.Drawing.Point(921, 379)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(13, 13)
        Me.LblFilter.TabIndex = 166
        Me.LblFilter.Text = "0"
        Me.LblFilter.Visible = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(382, 6)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(130, 58)
        Me.btnView.TabIndex = 162
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
        Me.btnPrint.Location = New System.Drawing.Point(11, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 58)
        Me.btnPrint.TabIndex = 163
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(18, 77)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 165
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'From_ReportSndToCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(724, 792)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.LblFilter)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.chkEngInvoice)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Re_View_SndToCustomer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "From_ReportSndToCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة تقرير القبض والصرف"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Re_View_SndToCustomer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LblFilter As Label
End Class
