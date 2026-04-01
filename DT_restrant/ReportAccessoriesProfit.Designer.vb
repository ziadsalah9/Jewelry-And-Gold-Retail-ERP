<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportAccessoriesProfit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportAccessoriesProfit))
        Me.Accessories_ProfitVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.For_invoce_report_finelDataGridView = New System.Windows.Forms.DataGridView()
        Me.date_finel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Accessories_ProfitVwTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ProfitVwTableAdapter()
        CType(Me.Accessories_ProfitVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.For_invoce_report_finelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accessories_ProfitVwBindingSource
        '
        Me.Accessories_ProfitVwBindingSource.DataMember = "Accessories_ProfitVw"
        Me.Accessories_ProfitVwBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 78)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker1.TabIndex = 20
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(2, 78)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker2.TabIndex = 21
        '
        'lblToDate
        '
        Me.lblToDate.Location = New System.Drawing.Point(2, 48)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(130, 27)
        Me.lblToDate.TabIndex = 24
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Location = New System.Drawing.Point(161, 48)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(130, 27)
        Me.lblFromDate.TabIndex = 23
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.Blue
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.ForeColor = System.Drawing.Color.White
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.Location = New System.Drawing.Point(2, 10)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(289, 34)
        Me.btnDate.TabIndex = 22
        Me.btnDate.Text = "عرض التقرير حسب التاريخ"
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(870, 52)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(114, 34)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "طباعة التقرير"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.Location = New System.Drawing.Point(748, 10)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(114, 34)
        Me.btnPreview.TabIndex = 28
        Me.btnPreview.Text = "معاينة"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.White
        Me.btnCancelPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelPreview.Location = New System.Drawing.Point(748, 52)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(114, 34)
        Me.btnCancelPreview.TabIndex = 29
        Me.btnCancelPreview.Text = "إلغاء المعاينة"
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAll.Location = New System.Drawing.Point(870, 10)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(114, 34)
        Me.btnViewAll.TabIndex = 36
        Me.btnViewAll.Text = "مراجعة البيانات"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'For_invoce_report_finelDataGridView
        '
        Me.For_invoce_report_finelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.For_invoce_report_finelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date_finel})
        Me.For_invoce_report_finelDataGridView.Location = New System.Drawing.Point(1296, 90)
        Me.For_invoce_report_finelDataGridView.Name = "For_invoce_report_finelDataGridView"
        Me.For_invoce_report_finelDataGridView.Size = New System.Drawing.Size(410, 80)
        Me.For_invoce_report_finelDataGridView.TabIndex = 40
        '
        'date_finel
        '
        Me.date_finel.DataPropertyName = "date_finel"
        Me.date_finel.HeaderText = "date_finel"
        Me.date_finel.Name = "date_finel"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Accessories_ProfitVwBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptAccessoriesProfit.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 119)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(992, 550)
        Me.ReportViewer1.TabIndex = 41
        '
        'lblSearchText
        '
        Me.lblSearchText.Location = New System.Drawing.Point(593, 66)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchText.TabIndex = 61
        Me.lblSearchText.Text = "القيمة"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Location = New System.Drawing.Point(593, 15)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(94, 24)
        Me.lblSearchType.TabIndex = 62
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"اسم الصنف", "الماركة", "رقم الفاتورة", "المورد", "سعر الشراء", "سعر البيع"})
        Me.cmbSearch.Location = New System.Drawing.Point(419, 14)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(168, 27)
        Me.cmbSearch.TabIndex = 60
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(342, 13)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 78)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.Location = New System.Drawing.Point(419, 66)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(168, 25)
        Me.txtSearch.TabIndex = 58
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Accessories_ProfitVwTableAdapter
        '
        Me.Accessories_ProfitVwTableAdapter.ClearBeforeFill = True
        '
        'ReportAccessoriesProfit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.For_invoce_report_finelDataGridView)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnCancelPreview)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.btnDate)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportAccessoriesProfit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير أرباح مبيعات الساعات والماركات"
        CType(Me.Accessories_ProfitVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.For_invoce_report_finelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnCancelPreview As System.Windows.Forms.Button
    Friend WithEvents btnViewAll As System.Windows.Forms.Button
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents For_invoce_report_finelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents date_finel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_ProfitVwBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accessories_ProfitVwTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Accessories_ProfitVwTableAdapter
End Class
