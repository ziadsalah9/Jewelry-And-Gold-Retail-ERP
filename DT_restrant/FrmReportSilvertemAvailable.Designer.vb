<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportSilvertemAvailable
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
        Me.CmbSearchValu = New System.Windows.Forms.ComboBox()
        Me.ChBoxBayDate = New System.Windows.Forms.CheckBox()
        Me.rbDown = New System.Windows.Forms.RadioButton()
        Me.rbUp = New System.Windows.Forms.RadioButton()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.RptView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'CmbSearchValu
        '
        Me.CmbSearchValu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchValu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchValu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSearchValu.FormattingEnabled = True
        Me.CmbSearchValu.Location = New System.Drawing.Point(421, 61)
        Me.CmbSearchValu.Name = "CmbSearchValu"
        Me.CmbSearchValu.Size = New System.Drawing.Size(168, 27)
        Me.CmbSearchValu.TabIndex = 84
        '
        'ChBoxBayDate
        '
        Me.ChBoxBayDate.BackColor = System.Drawing.Color.Gray
        Me.ChBoxBayDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChBoxBayDate.Location = New System.Drawing.Point(421, 4)
        Me.ChBoxBayDate.Name = "ChBoxBayDate"
        Me.ChBoxBayDate.Size = New System.Drawing.Size(168, 27)
        Me.ChBoxBayDate.TabIndex = 83
        Me.ChBoxBayDate.Text = "CheckBox1"
        Me.ChBoxBayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChBoxBayDate.UseVisualStyleBackColor = False
        '
        'rbDown
        '
        Me.rbDown.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbDown.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbDown.Image = Global.DT_restrant.My.Resources.Resources.Down
        Me.rbDown.Location = New System.Drawing.Point(831, 35)
        Me.rbDown.Name = "rbDown"
        Me.rbDown.Size = New System.Drawing.Size(34, 27)
        Me.rbDown.TabIndex = 82
        Me.rbDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbDown.UseVisualStyleBackColor = True
        '
        'rbUp
        '
        Me.rbUp.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbUp.Checked = True
        Me.rbUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rbUp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rbUp.Image = Global.DT_restrant.My.Resources.Resources.Up
        Me.rbUp.Location = New System.Drawing.Point(831, 4)
        Me.rbUp.Name = "rbUp"
        Me.rbUp.Size = New System.Drawing.Size(34, 27)
        Me.rbUp.TabIndex = 81
        Me.rbUp.TabStop = True
        Me.rbUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'lblSearchText
        '
        Me.lblSearchText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchText.Location = New System.Drawing.Point(595, 61)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(94, 27)
        Me.lblSearchText.TabIndex = 79
        Me.lblSearchText.Text = "القيمة"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchType.Location = New System.Drawing.Point(595, 34)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(94, 27)
        Me.lblSearchType.TabIndex = 80
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(421, 33)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(168, 27)
        Me.cmbSearch.TabIndex = 78
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Teal
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.Location = New System.Drawing.Point(356, 3)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 86)
        Me.btnSearch.TabIndex = 77
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewAll.ForeColor = System.Drawing.Color.White
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAll.Location = New System.Drawing.Point(872, 4)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(114, 27)
        Me.btnViewAll.TabIndex = 76
        Me.btnViewAll.Text = "مراجعة البيانات"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.White
        Me.btnCancelPreview.Image = Global.DT_restrant.My.Resources.Resources.PrinterPreviewCancel32
        Me.btnCancelPreview.Location = New System.Drawing.Point(872, 35)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(34, 27)
        Me.btnCancelPreview.TabIndex = 75
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Image = Global.DT_restrant.My.Resources.Resources.PrinterPreview32
        Me.btnPreview.Location = New System.Drawing.Point(912, 35)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(34, 27)
        Me.btnPreview.TabIndex = 74
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.Printer_32
        Me.btnPrint.Location = New System.Drawing.Point(952, 35)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(34, 27)
        Me.btnPrint.TabIndex = 73
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 66)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker1.TabIndex = 68
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(4, 66)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(130, 27)
        Me.DateTimePicker2.TabIndex = 69
        '
        'lblToDate
        '
        Me.lblToDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblToDate.Location = New System.Drawing.Point(4, 39)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(130, 27)
        Me.lblToDate.TabIndex = 72
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromDate.Location = New System.Drawing.Point(163, 39)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(130, 27)
        Me.lblFromDate.TabIndex = 71
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.Blue
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDate.ForeColor = System.Drawing.Color.White
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.Location = New System.Drawing.Point(4, 3)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(289, 34)
        Me.btnDate.TabIndex = 70
        Me.btnDate.Text = "عرض التقرير حسب تاريخ الادخال"
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'RptView
        '
        Me.RptView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RptView.Location = New System.Drawing.Point(4, 94)
        Me.RptView.Name = "RptView"
        Me.RptView.Size = New System.Drawing.Size(982, 593)
        Me.RptView.TabIndex = 85
        '
        'FrmReportSilvertemAvailable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 690)
        Me.Controls.Add(Me.RptView)
        Me.Controls.Add(Me.CmbSearchValu)
        Me.Controls.Add(Me.ChBoxBayDate)
        Me.Controls.Add(Me.rbDown)
        Me.Controls.Add(Me.rbUp)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnCancelPreview)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Controls.Add(Me.btnDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportSilvertemAvailable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportSilvertemAvailable"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmbSearchValu As ComboBox
    Friend WithEvents ChBoxBayDate As CheckBox
    Friend WithEvents rbDown As RadioButton
    Friend WithEvents rbUp As RadioButton
    Friend WithEvents lblSearchText As Label
    Friend WithEvents lblSearchType As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnCancelPreview As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
    Friend WithEvents btnDate As Button
    Friend WithEvents RptView As Microsoft.Reporting.WinForms.ReportViewer
End Class
