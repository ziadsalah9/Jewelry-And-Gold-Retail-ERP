<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSilverSellDetailed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportSilverSellDetailed))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.ReportGoldSellDetailedDataGridView = New System.Windows.Forms.DataGridView()
        Me.date_finel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.rbDown = New System.Windows.Forms.RadioButton()
        Me.rbUp = New System.Windows.Forms.RadioButton()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ChBoxBayDate = New System.Windows.Forms.CheckBox()
        Me.CmbSearchValu = New System.Windows.Forms.ComboBox()
        Me.BackWorkSearchParameters = New System.ComponentModel.BackgroundWorker()
        Me.RptView = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ReportGoldSellDetailedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 65)
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
        Me.DateTimePicker2.Location = New System.Drawing.Point(2, 65)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker2.TabIndex = 21
        '
        'lblToDate
        '
        Me.lblToDate.Location = New System.Drawing.Point(2, 38)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(130, 27)
        Me.lblToDate.TabIndex = 24
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Location = New System.Drawing.Point(161, 38)
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
        Me.btnDate.Location = New System.Drawing.Point(2, 2)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(289, 34)
        Me.btnDate.TabIndex = 22
        Me.btnDate.Text = "عرض التقرير حسب التاريخ"
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAll.Location = New System.Drawing.Point(870, 3)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(114, 27)
        Me.btnViewAll.TabIndex = 36
        Me.btnViewAll.Text = "مراجعة البيانات"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'ReportGoldSellDetailedDataGridView
        '
        Me.ReportGoldSellDetailedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportGoldSellDetailedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date_finel})
        Me.ReportGoldSellDetailedDataGridView.Location = New System.Drawing.Point(1296, 90)
        Me.ReportGoldSellDetailedDataGridView.Name = "ReportGoldSellDetailedDataGridView"
        Me.ReportGoldSellDetailedDataGridView.Size = New System.Drawing.Size(410, 80)
        Me.ReportGoldSellDetailedDataGridView.TabIndex = 40
        '
        'date_finel
        '
        Me.date_finel.DataPropertyName = "date_finel"
        Me.date_finel.HeaderText = "date_finel"
        Me.date_finel.Name = "date_finel"
        '
        'lblSearchText
        '
        Me.lblSearchText.Location = New System.Drawing.Point(593, 60)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(94, 27)
        Me.lblSearchText.TabIndex = 61
        Me.lblSearchText.Text = "القيمة"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Location = New System.Drawing.Point(593, 33)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(94, 27)
        Me.lblSearchType.TabIndex = 62
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(419, 32)
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
        Me.btnSearch.Location = New System.Drawing.Point(342, 3)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 89)
        Me.btnSearch.TabIndex = 59
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'rbDown
        '
        Me.rbDown.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDown.Image = Global.DT_restrant.My.Resources.Resources.Down
        Me.rbDown.Location = New System.Drawing.Point(829, 34)
        Me.rbDown.Name = "rbDown"
        Me.rbDown.Size = New System.Drawing.Size(34, 27)
        Me.rbDown.TabIndex = 64
        Me.rbDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDown.UseVisualStyleBackColor = True
        '
        'rbUp
        '
        Me.rbUp.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbUp.Checked = True
        Me.rbUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbUp.Image = Global.DT_restrant.My.Resources.Resources.Up
        Me.rbUp.Location = New System.Drawing.Point(829, 3)
        Me.rbUp.Name = "rbUp"
        Me.rbUp.Size = New System.Drawing.Size(34, 27)
        Me.rbUp.TabIndex = 63
        Me.rbUp.TabStop = True
        Me.rbUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.White
        Me.btnCancelPreview.Image = Global.DT_restrant.My.Resources.Resources.PrinterPreviewCancel32
        Me.btnCancelPreview.Location = New System.Drawing.Point(870, 34)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(34, 27)
        Me.btnCancelPreview.TabIndex = 29
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Image = Global.DT_restrant.My.Resources.Resources.PrinterPreview32
        Me.btnPreview.Location = New System.Drawing.Point(910, 34)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(34, 27)
        Me.btnPreview.TabIndex = 28
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.Printer_32
        Me.btnPrint.Location = New System.Drawing.Point(950, 34)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(34, 27)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ChBoxBayDate
        '
        Me.ChBoxBayDate.BackColor = System.Drawing.Color.Gray
        Me.ChBoxBayDate.Location = New System.Drawing.Point(419, 3)
        Me.ChBoxBayDate.Name = "ChBoxBayDate"
        Me.ChBoxBayDate.Size = New System.Drawing.Size(168, 27)
        Me.ChBoxBayDate.TabIndex = 66
        Me.ChBoxBayDate.Text = "CheckBox1"
        Me.ChBoxBayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChBoxBayDate.UseVisualStyleBackColor = False
        '
        'CmbSearchValu
        '
        Me.CmbSearchValu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchValu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchValu.FormattingEnabled = True
        Me.CmbSearchValu.Location = New System.Drawing.Point(419, 60)
        Me.CmbSearchValu.Name = "CmbSearchValu"
        Me.CmbSearchValu.Size = New System.Drawing.Size(168, 27)
        Me.CmbSearchValu.TabIndex = 67
        '
        'BackWorkSearchParameters
        '
        '
        'RptView
        '
        Me.RptView.Location = New System.Drawing.Point(2, 100)
        Me.RptView.Name = "RptView"
        Me.RptView.Size = New System.Drawing.Size(982, 564)
        Me.RptView.TabIndex = 68
        '
        'ReportSilverSellDetailed
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(986, 667)
        Me.Controls.Add(Me.RptView)
        Me.Controls.Add(Me.CmbSearchValu)
        Me.Controls.Add(Me.ChBoxBayDate)
        Me.Controls.Add(Me.rbDown)
        Me.Controls.Add(Me.rbUp)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.ReportGoldSellDetailedDataGridView)
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
        Me.Name = "ReportSilverSellDetailed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير مبيعات الفضه تفصيلي"
        CType(Me.ReportGoldSellDetailedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents ReportGoldSellDetailedDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents date_finel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents lblSearchType As System.Windows.Forms.Label
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents rbUp As RadioButton
    Friend WithEvents rbDown As RadioButton
    Friend WithEvents ChBoxBayDate As System.Windows.Forms.CheckBox
    Friend WithEvents CmbSearchValu As System.Windows.Forms.ComboBox
    Friend WithEvents BackWorkSearchParameters As System.ComponentModel.BackgroundWorker
    Friend WithEvents RptView As Microsoft.Reporting.WinForms.ReportViewer
End Class
