<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSilverProfit
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
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.CmbSearchValu = New System.Windows.Forms.ComboBox()
        Me.ChBoxBayDate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewAll.ForeColor = System.Drawing.Color.Black
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewAll.Location = New System.Drawing.Point(904, 6)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(87, 89)
        Me.btnViewAll.TabIndex = 90
        Me.btnViewAll.Text = "btnViewAll"
        Me.btnViewAll.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'CmbSearchValu
        '
        Me.CmbSearchValu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchValu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchValu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSearchValu.FormattingEnabled = True
        Me.CmbSearchValu.Location = New System.Drawing.Point(356, 72)
        Me.CmbSearchValu.Name = "CmbSearchValu"
        Me.CmbSearchValu.Size = New System.Drawing.Size(150, 27)
        Me.CmbSearchValu.TabIndex = 89
        '
        'ChBoxBayDate
        '
        Me.ChBoxBayDate.BackColor = System.Drawing.Color.Gray
        Me.ChBoxBayDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChBoxBayDate.Location = New System.Drawing.Point(356, 0)
        Me.ChBoxBayDate.Name = "ChBoxBayDate"
        Me.ChBoxBayDate.Size = New System.Drawing.Size(150, 27)
        Me.ChBoxBayDate.TabIndex = 88
        Me.ChBoxBayDate.Text = "CheckBox1"
        Me.ChBoxBayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChBoxBayDate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(510, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 27)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "القيمة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(510, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "طريقة البحث"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(356, 30)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(150, 27)
        Me.cmbSearch.TabIndex = 85
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.Location = New System.Drawing.Point(268, 1)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 98)
        Me.btnSearch.TabIndex = 84
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPreview.Location = New System.Drawing.Point(619, 6)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(87, 89)
        Me.btnCancelPreview.TabIndex = 83
        Me.btnCancelPreview.Text = "btnCancelPreview"
        Me.btnCancelPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPreview.Location = New System.Drawing.Point(714, 6)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(87, 89)
        Me.btnPreview.TabIndex = 82
        Me.btnPreview.Text = "btnPreview"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.Location = New System.Drawing.Point(809, 6)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 89)
        Me.btnPrint.TabIndex = 81
        Me.btnPrint.Text = "btnPrint"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.Transparent
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDate.ForeColor = System.Drawing.Color.Black
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate.Location = New System.Drawing.Point(4, 1)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(263, 40)
        Me.btnDate.TabIndex = 80
        Me.btnDate.Text = "عرض التقرير حسب التاريخ"
        Me.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Nothing
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptGoldProfit.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 102)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(992, 577)
        Me.ReportViewer1.TabIndex = 79
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 73)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker1.TabIndex = 75
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(4, 73)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker2.TabIndex = 76
        '
        'lblToDate
        '
        Me.lblToDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblToDate.Location = New System.Drawing.Point(4, 43)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(130, 27)
        Me.lblToDate.TabIndex = 78
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromDate.Location = New System.Drawing.Point(135, 43)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(130, 27)
        Me.lblFromDate.TabIndex = 77
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportSilverProfit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 682)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.CmbSearchValu)
        Me.Controls.Add(Me.ChBoxBayDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCancelPreview)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportSilverProfit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportSilverProfit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewAll As Button
    Friend WithEvents CmbSearchValu As ComboBox
    Friend WithEvents ChBoxBayDate As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancelPreview As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDate As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
End Class
