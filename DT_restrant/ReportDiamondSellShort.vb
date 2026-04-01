Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondSellShort

    Public Sub New()
        InitializeComponent()
        ApplyIconsToContainer(Me)
    End Sub
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String

    Private Sub AdvancedDateSearch()
        On Error Resume Next
        Dim ShowData As DataTable = GetRecordSet("Select BAY_SARYAL from  ViwDiamondInvoceReportShort ORDER BY date_creted DESC, BAY_SARYAL DESC")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path25")
        RptView.LocalReport.ReportPath = ReportPath
    End Sub
    Public Sub ReportPrint()
        AdvancedDateSearch()
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RptView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            RptView.RefreshReport()
        Else
        End If
    End Sub

    Private Sub shr_all_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        RptView.Visible = False
        ControlsAsColor(ColorSelect:=Me)
        ApplyIconsToContainer(Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        GetCastomAccReportPath()
        BackWorkSearchParameters.RunWorkerAsync()
        RptView.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        RptView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.RptView.RefreshReport()
        Me.RptView.RefreshReport()
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Try
            SetParametersAll()
            ReportDiamondSellShortBindingSource.RemoveFilter()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , AppTitle)
            End If
        End Try
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs)
        Try
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            DateTimePicker2.CustomFormat = "dd/MM/yyyy"
            SetParametersDate()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , AppTitle)
            End If
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        RptView.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs)
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs)
        RptView.SetDisplayMode(DisplayMode.Normal)
    End Sub
    Sub SetParametersAll()
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        RptView.LocalReport.ReportPath = Report_Path.Re_Path_DiaSelShort.Text
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub
    Sub SetParametersDate()
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        RptView.LocalReport.ReportPath = Report_Path.Re_Path_DiaSelShort.Text
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub shr_all_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        RptView.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        PerformSearch()
    End Sub
    Private Sub PerformSearch()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If CmbSearchValu.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If
        RptView.Visible = True
        'If ChBoxBayDate.Checked = False Then
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE CastomerNAme LIKE N'" & CmbSearchValu.Text & "%'")
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE castomr_id ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 2 'رقم الهاتف
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE CastomerTE ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 3 'الكاشير
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE cacher_name LIKE N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 4 'رقم الفاتوره
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 5 'اسم الصنف
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE DIMO_Type LIKE N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 6 'الباركود
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE test_119 ='" & CmbSearchValu.Text & "'")
                ReportPrint()
                'Case 7 'عيار الفضه
                '    SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReport WHERE GoledKarat ='" & CmbSearchValu.Text & "'")
                '    ReportPrint()
        End Select
        RptView.RefreshReport()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_SARYAL from  ViwDiamondInvoceReportShort ORDER BY date_creted DESC, BAY_SARYAL DESC")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        If ChBoxBayDate.Checked = False Then
            PerformSearch()
        ElseIf ChBoxBayDate.Checked = True Then
            PerformSearchBayDate()
        End If
    End Sub
    Private Sub PerformSearchBayDate()

        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If CmbSearchValu.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If
        RptView.Visible = True
        'If ChBoxBayDate.Checked = False Then
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE CastomerNAme LIKE N'" & CmbSearchValu.Text & "%' AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE castomr_id ='" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 2 'رقم الهاتف
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE CastomerTE ='" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 3 'الكاشير
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE cacher_name =N'" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 4 'رقم الفاتوره
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 5 'اسم الصنف
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE DIMO_Type =N'" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
            Case 6 'الباركود
                SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE test_119 ='" & CmbSearchValu.Text & "'AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
        End Select
        RptView.RefreshReport()
    End Sub

    Private Sub btnViewAll_Click_1(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_SARYAL from  ViwDiamondInvoceReportShort ORDER BY date_creted DESC, BAY_SARYAL DESC")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM ViwDiamondInvoceReportShort ORDER BY date_creted DESC, BAY_SARYAL DESC")
        ReportPrint()
        RptView.Visible = True
    End Sub

    Private Sub btnDate_Click_1(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim ShowData As DataTable = GetRecordSet("SELECT * FROM ViwDiamondInvoceReportShort ORDER BY date_creted DESC, BAY_SARYAL DESC")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM dbo.ViwDiamondInvoceReportShort WHERE (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        ReportPrint()
        RptView.Visible = True
    End Sub
End Class