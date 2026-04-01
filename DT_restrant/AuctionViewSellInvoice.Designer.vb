<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuctionViewSellInvoice
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuctionViewSellInvoice))
        Me.AuctionInvoiceDetailsVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnWhatsapp = New System.Windows.Forms.Button()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.Invoce_reportDataGridView = New System.Windows.Forms.DataGridView()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.CastomeridTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerNAmeLabel = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.CastomerTETextBox = New System.Windows.Forms.TextBox()
        Me.BAY_SARYALTextBox = New System.Windows.Forms.TextBox()
        Me.chkEngInvoice = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.AuctionInvoiceDetailsVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter()
        Me.rbInvoiceNo = New System.Windows.Forms.RadioButton()
        Me.rbBarCode = New System.Windows.Forms.RadioButton()
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuctionInvoiceDetailsVwBindingSource
        '
        Me.AuctionInvoiceDetailsVwBindingSource.DataMember = "AuctionInvoiceDetailsVw"
        Me.AuctionInvoiceDetailsVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.LightBlue
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.AuctionInvoiceDetailsVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptAuctionSellPay.rdlc"
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptGoldSellPay.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 70)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowExportButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowPrintButton = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(724, 540)
        Me.ReportViewer1.TabIndex = 3
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.LightCyan
        Me.txtInvoiceNo.Location = New System.Drawing.Point(484, 10)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(150, 27)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(55, 74)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 5
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'btnWhatsapp
        '
        Me.btnWhatsapp.BackColor = System.Drawing.Color.White
        Me.btnWhatsapp.BackgroundImage = CType(resources.GetObject("btnWhatsapp.BackgroundImage"), System.Drawing.Image)
        Me.btnWhatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWhatsapp.Location = New System.Drawing.Point(10, 74)
        Me.btnWhatsapp.Name = "btnWhatsapp"
        Me.btnWhatsapp.Size = New System.Drawing.Size(40, 40)
        Me.btnWhatsapp.TabIndex = 4
        Me.btnWhatsapp.UseVisualStyleBackColor = False
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'Invoce_reportDataGridView
        '
        Me.Invoce_reportDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoce_reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Invoce_reportDataGridView.Location = New System.Drawing.Point(-127, 46)
        Me.Invoce_reportDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Invoce_reportDataGridView.Name = "Invoce_reportDataGridView"
        Me.Invoce_reportDataGridView.RowHeadersVisible = False
        Me.Invoce_reportDataGridView.Size = New System.Drawing.Size(65, 30)
        Me.Invoce_reportDataGridView.TabIndex = 2
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR148", True))
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-127, 76)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(65, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 3
        '
        'CastomeridTextBox
        '
        Me.CastomeridTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomeridTextBox.Location = New System.Drawing.Point(-127, 106)
        Me.CastomeridTextBox.Name = "CastomeridTextBox"
        Me.CastomeridTextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomeridTextBox.TabIndex = 4
        '
        'CastomerNAmeLabel
        '
        Me.CastomerNAmeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerNAmeLabel.Location = New System.Drawing.Point(-127, 136)
        Me.CastomerNAmeLabel.Name = "CastomerNAmeLabel"
        Me.CastomerNAmeLabel.Size = New System.Drawing.Size(65, 27)
        Me.CastomerNAmeLabel.TabIndex = 5
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.CastomerTETextBox)
        Me.pnl.Controls.Add(Me.BAY_SARYALTextBox)
        Me.pnl.Controls.Add(Me.CastomerNAmeLabel)
        Me.pnl.Controls.Add(Me.CastomeridTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.Invoce_reportDataGridView)
        Me.pnl.Location = New System.Drawing.Point(865, 37)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(60, 127)
        Me.pnl.TabIndex = 157
        '
        'CastomerTETextBox
        '
        Me.CastomerTETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerTETextBox.Location = New System.Drawing.Point(-127, 166)
        Me.CastomerTETextBox.Name = "CastomerTETextBox"
        Me.CastomerTETextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomerTETextBox.TabIndex = 7
        '
        'BAY_SARYALTextBox
        '
        Me.BAY_SARYALTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BAY_SARYALTextBox.Location = New System.Drawing.Point(-127, 196)
        Me.BAY_SARYALTextBox.Name = "BAY_SARYALTextBox"
        Me.BAY_SARYALTextBox.Size = New System.Drawing.Size(65, 27)
        Me.BAY_SARYALTextBox.TabIndex = 6
        '
        'chkEngInvoice
        '
        Me.chkEngInvoice.Location = New System.Drawing.Point(484, 37)
        Me.chkEngInvoice.Name = "chkEngInvoice"
        Me.chkEngInvoice.Size = New System.Drawing.Size(149, 27)
        Me.chkEngInvoice.TabIndex = 1
        Me.chkEngInvoice.Text = "فاتورة إنجليزي"
        Me.chkEngInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEngInvoice.UseVisualStyleBackColor = True
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
        Me.btnView.Location = New System.Drawing.Point(340, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 60)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'AuctionInvoiceDetailsVwTableAdapter
        '
        Me.AuctionInvoiceDetailsVwTableAdapter.ClearBeforeFill = True
        '
        'rbInvoiceNo
        '
        Me.rbInvoiceNo.AutoSize = True
        Me.rbInvoiceNo.Checked = True
        Me.rbInvoiceNo.Location = New System.Drawing.Point(639, 10)
        Me.rbInvoiceNo.Name = "rbInvoiceNo"
        Me.rbInvoiceNo.Size = New System.Drawing.Size(91, 23)
        Me.rbInvoiceNo.TabIndex = 160
        Me.rbInvoiceNo.TabStop = True
        Me.rbInvoiceNo.Text = "رقم الفاتورة"
        Me.rbInvoiceNo.UseVisualStyleBackColor = True
        '
        'rbBarCode
        '
        Me.rbBarCode.AutoSize = True
        Me.rbBarCode.Location = New System.Drawing.Point(639, 37)
        Me.rbBarCode.Name = "rbBarCode"
        Me.rbBarCode.Size = New System.Drawing.Size(92, 23)
        Me.rbBarCode.TabIndex = 160
        Me.rbBarCode.TabStop = True
        Me.rbBarCode.Text = "رقم الباركود"
        Me.rbBarCode.UseVisualStyleBackColor = True
        '
        'AuctionViewSellInvoice
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(734, 611)
        Me.Controls.Add(Me.rbBarCode)
        Me.Controls.Add(Me.rbInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkEngInvoice)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.btnWhatsapp)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AuctionViewSellInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مراجعة فواتير البيع"
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Invoce_reportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnWhatsapp As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SettingsBindingSource As BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents Invoce_reportDataGridView As DataGridView
    Friend WithEvents SET_INVARCHR148TextBox As TextBox
    Friend WithEvents CastomeridTextBox As TextBox
    Friend WithEvents CastomerNAmeLabel As TextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents BAY_SARYALTextBox As TextBox
    Friend WithEvents CastomerTETextBox As TextBox
    Friend WithEvents chkEngInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents AuctionInvoiceDetailsVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuctionInvoiceDetailsVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter
    Friend WithEvents rbInvoiceNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbBarCode As System.Windows.Forms.RadioButton
End Class
