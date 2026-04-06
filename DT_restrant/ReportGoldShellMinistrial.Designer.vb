<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportGoldShellMinistrial
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ChbKYC = New System.Windows.Forms.CheckBox()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnCancelPreview = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.RptView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CmbSearchValu = New System.Windows.Forms.ComboBox()
        Me.ChBoxBayDate = New System.Windows.Forms.CheckBox()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblSearchType = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ChbKYC
        '
        Me.ChbKYC.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChbKYC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChbKYC.Location = New System.Drawing.Point(726, 12)
        Me.ChbKYC.Margin = New System.Windows.Forms.Padding(4)
        Me.ChbKYC.Name = "ChbKYC"
        Me.ChbKYC.Size = New System.Drawing.Size(139, 30)
        Me.ChbKYC.TabIndex = 110
        Me.ChbKYC.Text = "KYC"
        Me.ChbKYC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChbKYC.UseVisualStyleBackColor = True
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.Transparent
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.ForeColor = System.Drawing.Color.Black
        Me.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDate.Location = New System.Drawing.Point(18, 7)
        Me.btnDate.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(321, 47)
        Me.btnDate.TabIndex = 109
        Me.btnDate.Text = "عرض التقرير حسب التاريخ"
        Me.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearch.Location = New System.Drawing.Point(337, 7)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(116, 110)
        Me.btnSearch.TabIndex = 108
        Me.btnSearch.Text = "عرض"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnViewAll
        '
        Me.btnViewAll.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAll.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.ForeColor = System.Drawing.Color.Black
        Me.btnViewAll.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewAll.Location = New System.Drawing.Point(1217, 10)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(5)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(116, 107)
        Me.btnViewAll.TabIndex = 107
        Me.btnViewAll.Text = "عرض الكل"
        Me.btnViewAll.UseVisualStyleBackColor = False
        '
        'btnCancelPreview
        '
        Me.btnCancelPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPreview.ForeColor = System.Drawing.Color.Black
        Me.btnCancelPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelPreview.Location = New System.Drawing.Point(865, 10)
        Me.btnCancelPreview.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancelPreview.Name = "btnCancelPreview"
        Me.btnCancelPreview.Size = New System.Drawing.Size(116, 107)
        Me.btnCancelPreview.TabIndex = 106
        Me.btnCancelPreview.Text = "الغاء المعاينة"
        Me.btnCancelPreview.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPreview.Location = New System.Drawing.Point(982, 10)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(116, 107)
        Me.btnPreview.TabIndex = 105
        Me.btnPreview.Text = "معاينة"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.Location = New System.Drawing.Point(1100, 10)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 107)
        Me.btnPrint.TabIndex = 104
        Me.btnPrint.Text = "طباعة تقرير"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'RptView
        '
        Me.RptView.Location = New System.Drawing.Point(24, 123)
        Me.RptView.Margin = New System.Windows.Forms.Padding(4)
        Me.RptView.Name = "RptView"
        Me.RptView.ServerReport.BearerToken = Nothing
        Me.RptView.Size = New System.Drawing.Size(1309, 685)
        Me.RptView.TabIndex = 103
        '
        'CmbSearchValu
        '
        Me.CmbSearchValu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbSearchValu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSearchValu.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CmbSearchValu.FormattingEnabled = True
        Me.CmbSearchValu.Location = New System.Drawing.Point(454, 83)
        Me.CmbSearchValu.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbSearchValu.Name = "CmbSearchValu"
        Me.CmbSearchValu.Size = New System.Drawing.Size(265, 32)
        Me.CmbSearchValu.TabIndex = 102
        '
        'ChBoxBayDate
        '
        Me.ChBoxBayDate.BackColor = System.Drawing.Color.Gray
        Me.ChBoxBayDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChBoxBayDate.Location = New System.Drawing.Point(454, 7)
        Me.ChBoxBayDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ChBoxBayDate.Name = "ChBoxBayDate"
        Me.ChBoxBayDate.Size = New System.Drawing.Size(267, 33)
        Me.ChBoxBayDate.TabIndex = 101
        Me.ChBoxBayDate.Text = "CheckBox1"
        Me.ChBoxBayDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChBoxBayDate.UseVisualStyleBackColor = False
        '
        'lblSearchText
        '
        Me.lblSearchText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchText.Location = New System.Drawing.Point(725, 83)
        Me.lblSearchText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(131, 33)
        Me.lblSearchText.TabIndex = 99
        Me.lblSearchText.Text = "القيمة"
        Me.lblSearchText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearchType
        '
        Me.lblSearchType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchType.Location = New System.Drawing.Point(725, 46)
        Me.lblSearchType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchType.Name = "lblSearchType"
        Me.lblSearchType.Size = New System.Drawing.Size(131, 33)
        Me.lblSearchType.TabIndex = 100
        Me.lblSearchType.Text = "طريقة البحث"
        Me.lblSearchType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbSearch
        '
        Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(454, 46)
        Me.cmbSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(265, 32)
        Me.cmbSearch.TabIndex = 98
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 84)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 32)
        Me.DateTimePicker1.TabIndex = 94
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(18, 84)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(155, 32)
        Me.DateTimePicker2.TabIndex = 95
        '
        'lblToDate
        '
        Me.lblToDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblToDate.Location = New System.Drawing.Point(18, 51)
        Me.lblToDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(156, 33)
        Me.lblToDate.TabIndex = 97
        Me.lblToDate.Text = "إلى تاريخ"
        Me.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFromDate
        '
        Me.lblFromDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromDate.Location = New System.Drawing.Point(185, 51)
        Me.lblFromDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(155, 33)
        Me.lblFromDate.TabIndex = 96
        Me.lblFromDate.Text = "من تاريخ"
        Me.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportGoldShellMinistrial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 815)
        Me.Controls.Add(Me.ChbKYC)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.btnCancelPreview)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.RptView)
        Me.Controls.Add(Me.CmbSearchValu)
        Me.Controls.Add(Me.ChBoxBayDate)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.lblSearchType)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblToDate)
        Me.Controls.Add(Me.lblFromDate)
        Me.Name = "ReportGoldShellMinistrial"
        Me.Text = "ReportGoldShellMinistrial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChbKYC As CheckBox
    Friend WithEvents btnDate As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnCancelPreview As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents RptView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CmbSearchValu As ComboBox
    Friend WithEvents ChBoxBayDate As CheckBox
    Friend WithEvents lblSearchText As Label
    Friend WithEvents lblSearchType As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
End Class
