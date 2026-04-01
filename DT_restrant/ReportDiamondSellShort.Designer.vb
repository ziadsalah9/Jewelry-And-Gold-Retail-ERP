<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDiamondSellShort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDiamondSellShort))
        Me.For_invoce_report_finelDataGridView = New System.Windows.Forms.DataGridView()
        Me.date_finel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.BackWorkSearchParameters = New System.ComponentModel.BackgroundWorker()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.CmbSearchValu = New System.Windows.Forms.ComboBox()
        Me.ChBoxBayDate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        CType(Me.For_invoce_report_finelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'RptView
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.RptView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RptView.LocalReport.ReportEmbeddedResource = "DT_restrant.rptDiamondSellShort.rdlc"
        Me.RptView.Location = New System.Drawing.Point(1, 96)
        Me.RptView.Name = "RptView"
        Me.RptView.ServerReport.BearerToken = Nothing
        Me.RptView.Size = New System.Drawing.Size(992, 573)
        Me.RptView.TabIndex = 41
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
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.Black
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewAll.Location = New System.Drawing.Point(906, 5)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(87, 89)
        Me.btnViewAll.TabIndex = 66
        Me.btnViewAll.Text = "btnViewAll"
        Me.btnViewAll.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPreview.Location = New System.Drawing.Point(620, 5)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(87, 89)
        Me.btnCancelPreview.TabIndex = 65
        Me.btnCancelPreview.Text = "btnCancelPreview"
        Me.btnCancelPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPreview.Location = New System.Drawing.Point(716, 5)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(87, 89)
        Me.btnPreview.TabIndex = 64
        Me.btnPreview.Text = "btnPreview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.Location = New System.Drawing.Point(811, 5)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 89)
        Me.btnPrint.TabIndex = 63
        Me.btnPrint.Text = "btnPrint"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'CmbSearchValu
        '
        Me.CmbSearchValu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchValu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchValu.FormattingEnabled = True
        Me.CmbSearchValu.Location = New System.Drawing.Point(359, 63)
        Me.CmbSearchValu.Name = "CmbSearchValu"
        Me.CmbSearchValu.Size = New System.Drawing.Size(150, 27)
        Me.CmbSearchValu.TabIndex = 78
        '
        'ChBoxBayDate
        '
        Me.ChBoxBayDate.BackColor = System.Drawing.Color.Gray
        Me.ChBoxBayDate.Location = New System.Drawing.Point(359, 1)
        Me.ChBoxBayDate.Name = "ChBoxBayDate"
        Me.ChBoxBayDate.Size = New System.Drawing.Size(150, 27)
        Me.ChBoxBayDate.TabIndex = 77
        Me.ChBoxBayDate.Text = "CheckBox1"
        Me.ChBoxBayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChBoxBayDate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(510, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 27)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "القيمة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Location = New System.Drawing.Point(510, 31)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(89, 27)
        Me.lblSearchType.TabIndex = 76
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(359, 31)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(150, 27)
        Me.cmbSearch.TabIndex = 74
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.Location = New System.Drawing.Point(271, 1)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 89)
        Me.btnSearch.TabIndex = 73
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(139, 67)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker1.TabIndex = 68
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 66)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker2.TabIndex = 69
        '
        'lblToDate
        '
        Me.lblToDate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblToDate.Location = New System.Drawing.Point(6, 48)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(130, 18)
        Me.lblToDate.TabIndex = 72
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromDate.Location = New System.Drawing.Point(139, 48)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(130, 19)
        Me.lblFromDate.TabIndex = 71
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.Transparent
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.ForeColor = System.Drawing.Color.Black
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate.Location = New System.Drawing.Point(6, 1)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(263, 43)
        Me.btnDate.TabIndex = 70
        Me.btnDate.Text = "عرض التقرير حسب التاريخ"
        Me.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'ReportDiamondSellShort
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 671)
        Me.Controls.Add(Me.CmbSearchValu)
        Me.Controls.Add(Me.ChBoxBayDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnCancelPreview)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.RptView)
        Me.Controls.Add(Me.For_invoce_report_finelDataGridView)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportDiamondSellShort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير مبيعات ألماس مختصر"
        CType(Me.For_invoce_report_finelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents For_invoce_report_finelDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RptView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents date_finel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents ReportDiamondSellShortBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDiamondSellShortTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.ReportDiamondSellShortTableAdapter
    Friend WithEvents BackWorkSearchParameters As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnCancelPreview As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents CmbSearchValu As ComboBox
    Friend WithEvents ChBoxBayDate As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSearchType As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents btnDate As Button
End Class
