<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SilverViewSellInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SilverViewSellInvoice))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.Invoce_reportDataGridView = New System.Windows.Forms.DataGridView()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.CastomeridTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerNAmeLabel = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SET_INVARCHR156TextBox = New System.Windows.Forms.TextBox()
        Me.CastomerTETextBox = New System.Windows.Forms.TextBox()
        Me.BAY_SARYALTextBox = New System.Windows.Forms.TextBox()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.RadAcc = New System.Windows.Forms.RadioButton()
        Me.RadCastm = New System.Windows.Forms.RadioButton()
        Me.BackWorkInv = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorkerGetInvoceNo = New System.ComponentModel.BackgroundWorker()
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.LightBlue
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 85)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(595, 564)
        Me.ReportViewer1.TabIndex = 3
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(12, 601)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 5
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'Invoce_reportDataGridView
        '
        Me.Invoce_reportDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoce_reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Invoce_reportDataGridView.Location = New System.Drawing.Point(-103, 46)
        Me.Invoce_reportDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Invoce_reportDataGridView.Name = "Invoce_reportDataGridView"
        Me.Invoce_reportDataGridView.RowHeadersVisible = False
        Me.Invoce_reportDataGridView.Size = New System.Drawing.Size(65, 30)
        Me.Invoce_reportDataGridView.TabIndex = 2
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-103, 76)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(65, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 3
        '
        'CastomeridTextBox
        '
        Me.CastomeridTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomeridTextBox.Location = New System.Drawing.Point(-103, 103)
        Me.CastomeridTextBox.Name = "CastomeridTextBox"
        Me.CastomeridTextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomeridTextBox.TabIndex = 4
        '
        'CastomerNAmeLabel
        '
        Me.CastomerNAmeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerNAmeLabel.Location = New System.Drawing.Point(-103, 130)
        Me.CastomerNAmeLabel.Name = "CastomerNAmeLabel"
        Me.CastomerNAmeLabel.Size = New System.Drawing.Size(65, 27)
        Me.CastomerNAmeLabel.TabIndex = 5
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.SET_INVARCHR156TextBox)
        Me.pnl.Controls.Add(Me.CastomerTETextBox)
        Me.pnl.Controls.Add(Me.BAY_SARYALTextBox)
        Me.pnl.Controls.Add(Me.CastomerNAmeLabel)
        Me.pnl.Controls.Add(Me.CastomeridTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.Invoce_reportDataGridView)
        Me.pnl.Location = New System.Drawing.Point(858, 29)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(84, 53)
        Me.pnl.TabIndex = 157
        '
        'SET_INVARCHR156TextBox
        '
        Me.SET_INVARCHR156TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR156TextBox.Location = New System.Drawing.Point(-103, 211)
        Me.SET_INVARCHR156TextBox.Name = "SET_INVARCHR156TextBox"
        Me.SET_INVARCHR156TextBox.Size = New System.Drawing.Size(65, 27)
        Me.SET_INVARCHR156TextBox.TabIndex = 8
        '
        'CastomerTETextBox
        '
        Me.CastomerTETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerTETextBox.Location = New System.Drawing.Point(-103, 157)
        Me.CastomerTETextBox.Name = "CastomerTETextBox"
        Me.CastomerTETextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomerTETextBox.TabIndex = 7
        '
        'BAY_SARYALTextBox
        '
        Me.BAY_SARYALTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAY_SARYALTextBox.Location = New System.Drawing.Point(-103, 184)
        Me.BAY_SARYALTextBox.Name = "BAY_SARYALTextBox"
        Me.BAY_SARYALTextBox.Size = New System.Drawing.Size(65, 27)
        Me.BAY_SARYALTextBox.TabIndex = 6
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.Location = New System.Drawing.Point(471, 59)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(131, 27)
        Me.chkEngInvoice.TabIndex = 1
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEngInvoice.UseVisualStyleBackColor = True
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(321, 6)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(144, 41)
        Me.lblInvoiceNo.TabIndex = 159
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(7, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(143, 62)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(177, 17)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 63)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(320, 50)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(145, 27)
        Me.txtInvoiceNo.TabIndex = 160
        '
        'RadAcc
        '
        Me.RadAcc.Location = New System.Drawing.Point(471, 30)
        Me.RadAcc.Name = "RadAcc"
        Me.RadAcc.Size = New System.Drawing.Size(131, 29)
        Me.RadAcc.TabIndex = 162
        Me.RadAcc.TabStop = True
        Me.RadAcc.Text = "نسخة المحاسب"
        Me.RadAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadAcc.UseVisualStyleBackColor = True
        '
        'RadCastm
        '
        Me.RadCastm.Location = New System.Drawing.Point(471, 1)
        Me.RadCastm.Name = "RadCastm"
        Me.RadCastm.Size = New System.Drawing.Size(131, 29)
        Me.RadCastm.TabIndex = 161
        Me.RadCastm.TabStop = True
        Me.RadCastm.Text = "نسخة العميل"
        Me.RadCastm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadCastm.UseVisualStyleBackColor = True
        '
        'BackWorkInv
        '
        '
        'BackgroundWorkerGetInvoceNo
        '
        '
        'SilverViewSellInvoice
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(608, 653)
        Me.Controls.Add(Me.RadAcc)
        Me.Controls.Add(Me.RadCastm)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.chkEngInvoice)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SilverViewSellInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مراجعة فواتير البيع"
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPDF As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Invoce_reportDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SET_INVARCHR148TextBox As TextBox
    Friend WithEvents CastomeridTextBox As TextBox
    Friend WithEvents CastomerNAmeLabel As TextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents BAY_SARYALTextBox As TextBox
    Friend WithEvents CastomerTETextBox As TextBox
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents SET_INVARCHR156TextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.ComboBox
    Friend WithEvents RadAcc As System.Windows.Forms.RadioButton
    Friend WithEvents RadCastm As System.Windows.Forms.RadioButton
    Friend WithEvents BackWorkInv As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorkerGetInvoceNo As System.ComponentModel.BackgroundWorker
End Class
