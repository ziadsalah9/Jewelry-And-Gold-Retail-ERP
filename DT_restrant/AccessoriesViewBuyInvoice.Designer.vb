<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesViewBuyInvoice
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessoriesViewBuyInvoice))
        Me.Accessories_Buy_PayVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnWhatsapp = New System.Windows.Forms.Button()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.CastomeridTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerNAmeLabel = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SET_INVARCHR153TextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_TIMETextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_DATE_CREDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CastomerTETextBox = New System.Windows.Forms.TextBox()
        Me.txtInvoiceNoDB = New System.Windows.Forms.TextBox()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Accessories_Buy_PayVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_Buy_PayVwTableAdapter()
        CType(Me.Accessories_Buy_PayVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Accessories_Buy_PayVwBindingSource
        '
        Me.Accessories_Buy_PayVwBindingSource.DataMember = "Accessories_Buy_PayVw"
        Me.Accessories_Buy_PayVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Snow
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Accessories_Buy_PayVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 70)
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
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 540)
        Me.ReportViewer1.TabIndex = 3
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.LightCyan
        Me.txtInvoiceNo.Location = New System.Drawing.Point(450, 22)
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
        Me.btnPDF.Location = New System.Drawing.Point(58, 74)
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
        Me.btnWhatsapp.Location = New System.Drawing.Point(13, 74)
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accessories_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BAYTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_Buy_PayTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BuyTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_CATTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_DEPTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_INVTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
        Me.TableAdapterManager.Buy_DiamondTableAdapter = Nothing
        Me.TableAdapterManager.Buy_GoldTableAdapter = Nothing
        Me.TableAdapterManager.cacherTableAdapter = Nothing
        Me.TableAdapterManager.CANTRYTableAdapter = Nothing
        Me.TableAdapterManager.CastomerDETELSTableAdapter = Nothing
        Me.TableAdapterManager.COMP_BAYTableAdapter = Nothing
        Me.TableAdapterManager.COMP_detels_for_bayTableAdapter = Nothing
        Me.TableAdapterManager.comp_detelsTableAdapter = Nothing
        Me.TableAdapterManager.comp_informTableAdapter = Nothing
        Me.TableAdapterManager.COMP_INVOCE_CACHETableAdapter = Nothing
        Me.TableAdapterManager.COMPANY_BAY_DETELSTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcood_dimonTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcoodTableAdapter = Nothing
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTypeTableAdapter = Nothing
        Me.TableAdapterManager.EXTR_NAMETableAdapter = Nothing

        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.Item_NameTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Me.SettingsTableAdapter
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'grid
        '
        Me.grid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoGenerateColumns = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewImageColumn1})
        Me.grid.DataSource = Me.Accessories_Buy_PayVwBindingSource
        Me.grid.Location = New System.Drawing.Point(-108, 46)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.Name = "grid"
        Me.grid.RowHeadersVisible = False
        Me.grid.Size = New System.Drawing.Size(65, 30)
        Me.grid.TabIndex = 2
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "CastomerNAme"
        Me.DataGridViewTextBoxColumn18.HeaderText = "CastomerNAme"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CastomerADr"
        Me.DataGridViewTextBoxColumn19.HeaderText = "CastomerADr"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CastomerTE"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CastomerTE"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "CastomerNA"
        Me.DataGridViewTextBoxColumn21.HeaderText = "CastomerNA"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "foto"
        Me.DataGridViewImageColumn1.HeaderText = "foto"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR148", True))
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-108, 76)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(65, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 3
        '
        'CastomeridTextBox
        '
        Me.CastomeridTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomeridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayVwBindingSource, "CastomerCAIVELid", True))
        Me.CastomeridTextBox.Location = New System.Drawing.Point(-108, 103)
        Me.CastomeridTextBox.Name = "CastomeridTextBox"
        Me.CastomeridTextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomeridTextBox.TabIndex = 4
        '
        'CastomerNAmeLabel
        '
        Me.CastomerNAmeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerNAmeLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayVwBindingSource, "CastomerNAme", True))
        Me.CastomerNAmeLabel.Location = New System.Drawing.Point(-108, 130)
        Me.CastomerNAmeLabel.Name = "CastomerNAmeLabel"
        Me.CastomerNAmeLabel.Size = New System.Drawing.Size(65, 27)
        Me.CastomerNAmeLabel.TabIndex = 5
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.SET_INVARCHR153TextBox)
        Me.pnl.Controls.Add(Me.Accessories_TIMETextBox)
        Me.pnl.Controls.Add(Me.Accessories_DATE_CREDateTimePicker)
        Me.pnl.Controls.Add(Me.CastomerTETextBox)
        Me.pnl.Controls.Add(Me.txtInvoiceNoDB)
        Me.pnl.Controls.Add(Me.CastomerNAmeLabel)
        Me.pnl.Controls.Add(Me.CastomeridTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.grid)
        Me.pnl.Location = New System.Drawing.Point(777, 37)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(79, 106)
        Me.pnl.TabIndex = 157
        '
        'SET_INVARCHR153TextBox
        '
        Me.SET_INVARCHR153TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR153TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR153", True))
        Me.SET_INVARCHR153TextBox.Location = New System.Drawing.Point(-108, 265)
        Me.SET_INVARCHR153TextBox.Name = "SET_INVARCHR153TextBox"
        Me.SET_INVARCHR153TextBox.Size = New System.Drawing.Size(65, 27)
        Me.SET_INVARCHR153TextBox.TabIndex = 10
        '
        'Accessories_TIMETextBox
        '
        Me.Accessories_TIMETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_TIMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayVwBindingSource, "Accessories_TIME", True))
        Me.Accessories_TIMETextBox.Location = New System.Drawing.Point(-108, 238)
        Me.Accessories_TIMETextBox.Name = "Accessories_TIMETextBox"
        Me.Accessories_TIMETextBox.Size = New System.Drawing.Size(65, 27)
        Me.Accessories_TIMETextBox.TabIndex = 9
        '
        'Accessories_DATE_CREDateTimePicker
        '
        Me.Accessories_DATE_CREDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Accessories_DATE_CREDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.Accessories_DATE_CREDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Accessories_Buy_PayVwBindingSource, "Accessories_DATE_CRE", True))
        Me.Accessories_DATE_CREDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Accessories_DATE_CREDateTimePicker.Location = New System.Drawing.Point(-108, 211)
        Me.Accessories_DATE_CREDateTimePicker.Name = "Accessories_DATE_CREDateTimePicker"
        Me.Accessories_DATE_CREDateTimePicker.Size = New System.Drawing.Size(65, 27)
        Me.Accessories_DATE_CREDateTimePicker.TabIndex = 8
        '
        'CastomerTETextBox
        '
        Me.CastomerTETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayVwBindingSource, "CastomerTE", True))
        Me.CastomerTETextBox.Location = New System.Drawing.Point(-108, 157)
        Me.CastomerTETextBox.Name = "CastomerTETextBox"
        Me.CastomerTETextBox.Size = New System.Drawing.Size(65, 27)
        Me.CastomerTETextBox.TabIndex = 7
        '
        'txtInvoiceNoDB
        '
        Me.txtInvoiceNoDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceNoDB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_Buy_PayVwBindingSource, "Accessories_InvoiceNo", True))
        Me.txtInvoiceNoDB.Location = New System.Drawing.Point(-108, 184)
        Me.txtInvoiceNoDB.Name = "txtInvoiceNoDB"
        Me.txtInvoiceNoDB.Size = New System.Drawing.Size(65, 27)
        Me.txtInvoiceNoDB.TabIndex = 6
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(602, 26)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(73, 19)
        Me.lblInvoiceNo.TabIndex = 159
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
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
        Me.btnView.Location = New System.Drawing.Point(305, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 60)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Accessories_Buy_PayVwTableAdapter
        '
        Me.Accessories_Buy_PayVwTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesViewBuyInvoice
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.btnWhatsapp)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AccessoriesViewBuyInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مراجعة فواتير البيع"
        CType(Me.Accessories_Buy_PayVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Accessories_Buy_PayVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnWhatsapp As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SettingsBindingSource As BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents grid As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents SET_INVARCHR148TextBox As TextBox
    Friend WithEvents CastomeridTextBox As TextBox
    Friend WithEvents CastomerNAmeLabel As TextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents txtInvoiceNoDB As TextBox
    Friend WithEvents CastomerTETextBox As TextBox
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Accessories_Buy_PayVwTableAdapter As DT_restrantDataSetTableAdapters.Accessories_Buy_PayVwTableAdapter
    Friend WithEvents Accessories_TIMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_DATE_CREDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SET_INVARCHR153TextBox As System.Windows.Forms.TextBox
End Class
