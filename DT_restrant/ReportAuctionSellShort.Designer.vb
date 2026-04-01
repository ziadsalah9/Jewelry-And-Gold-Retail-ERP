<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportAuctionSellShort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportAuctionSellShort))
        Me.AuctionInvoiceDetailsVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.AuctionInvoiceDetailsVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter()
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
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
        'btnViewAll
        '
        Me.btnViewAll.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnViewAll.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAll.Location = New System.Drawing.Point(1067, 10)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(184, 46)
        Me.btnViewAll.TabIndex = 54
        Me.btnViewAll.Text = "مراجعة البيانات"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(397, 79)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(303, 25)
        Me.txtSearch.TabIndex = 48
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Lavender
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AuctionInvoiceDetailsVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptAuctionSellShort.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 145)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1263, 521)
        Me.ReportViewer1.TabIndex = 60
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(11, 94)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(147, 27)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 94)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(147, 27)
        Me.DateTimePicker1.TabIndex = 1
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCancelPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.White
        Me.btnCancelPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelPreview.Location = New System.Drawing.Point(823, 75)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(184, 46)
        Me.btnCancelPreview.TabIndex = 47
        Me.btnCancelPreview.Text = "إلغاء المعاينة"
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.Location = New System.Drawing.Point(823, 10)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(184, 46)
        Me.btnPreview.TabIndex = 46
        Me.btnPreview.Text = "معاينة"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'lblToDate
        '
        Me.lblToDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToDate.Location = New System.Drawing.Point(11, 67)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(147, 27)
        Me.lblToDate.TabIndex = 44
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(1067, 75)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(184, 46)
        Me.btnPrint.TabIndex = 45
        Me.btnPrint.Text = "طباعة التقرير"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSearch.Controls.Add(Me.lblSearchText)
        Me.pnlSearch.Controls.Add(Me.lblSearchType)
        Me.pnlSearch.Controls.Add(Me.cmbSearch)
        Me.pnlSearch.Controls.Add(Me.DateTimePicker2)
        Me.pnlSearch.Controls.Add(Me.DateTimePicker1)
        Me.pnlSearch.Controls.Add(Me.btnViewAll)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnCancelPreview)
        Me.pnlSearch.Controls.Add(Me.btnPreview)
        Me.pnlSearch.Controls.Add(Me.btnPrint)
        Me.pnlSearch.Controls.Add(Me.lblToDate)
        Me.pnlSearch.Controls.Add(Me.lblFromDate)
        Me.pnlSearch.Controls.Add(Me.btnDate)
        Me.pnlSearch.Location = New System.Drawing.Point(6, 5)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1263, 135)
        Me.pnlSearch.TabIndex = 61
        '
        'lblSearchText
        '
        Me.lblSearchText.Location = New System.Drawing.Point(706, 79)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchText.TabIndex = 57
        Me.lblSearchText.Text = "القيمة"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Location = New System.Drawing.Point(706, 28)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchType.TabIndex = 57
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"اسم  العميل", "الرقم المدني", "الباركود", "السعر"})
        Me.cmbSearch.Location = New System.Drawing.Point(397, 27)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(303, 27)
        Me.cmbSearch.TabIndex = 56
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(329, 27)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 76)
        Me.btnSearch.TabIndex = 55
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblFromDate
        '
        Me.lblFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFromDate.Location = New System.Drawing.Point(161, 67)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(147, 27)
        Me.lblFromDate.TabIndex = 43
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDate
        '
        Me.btnDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnDate.BackColor = System.Drawing.Color.Blue
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.ForeColor = System.Drawing.Color.White
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.Location = New System.Drawing.Point(11, 10)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(297, 46)
        Me.btnDate.TabIndex = 42
        Me.btnDate.Text = "عرض حسب التاريخ"
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'AuctionInvoiceDetailsVwTableAdapter
        '
        Me.AuctionInvoiceDetailsVwTableAdapter.ClearBeforeFill = True
        '
        'ReportAuctionSellShort
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1274, 671)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.pnlSearch)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportAuctionSellShort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مبيعات مختصر"
        CType(Me.AuctionInvoiceDetailsVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnViewAll As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AuctionInvoiceDetailsVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelPreview As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents AuctionInvoiceDetailsVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.AuctionInvoiceDetailsVwTableAdapter
End Class
