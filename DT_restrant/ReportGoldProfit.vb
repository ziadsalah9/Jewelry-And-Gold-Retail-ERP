Imports Microsoft.Reporting.WinForms
Public Class ReportGoldProfit
    Public Sub New()
        InitializeComponent()
        ApplyIconsToContainer(Me)
    End Sub
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String
    Private Sub ReportGoldProfit_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        ApplyIconsToContainer(Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        GetCastomAccReportPath()
        ReportViewer1.Visible = False
        Me.ReportViewer1.RefreshReport()
        SetParametersAll()
    End Sub
    Public Sub GetFilterData(ByVal Sql_Commn As String)
        Dim GetFilterData As DataTable = GetRecordSet(Sql_Commn)
        If GetFilterData.Rows.Count > 0 Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetFilterData)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Public Sub ReportPrint()
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            ReportViewer1.RefreshReport()
        Else
        End If
    End Sub
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path24")
        ReportViewer1.LocalReport.ReportPath = ReportPath
    End Sub
    Private Sub AdvancedDateSearch()
        Dim ShowData As DataTable = GetRecordSet("Select ID from  ViwGoldInvoceReport")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        ReportViewer1.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs)
        ReportViewer1.SetDisplayMode(DisplayMode.Normal)
    End Sub
    Sub SetParametersAll()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Sub SetParametersDate()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub shr_all_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from ViwGoldInvoceReport")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM ViwGoldInvoceReport")
        ReportPrint()
        ReportViewer1.Visible = True
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  ViwGoldInvoceReport")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        ReportPrint()
        ReportViewer1.Visible = True
    End Sub

    Private Sub btnPrint_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnPreview_Click_1(sender As Object, e As EventArgs) Handles btnPreview.Click

    End Sub

    Private Sub btnCancelPreview_Click_1(sender As Object, e As EventArgs) Handles btnCancelPreview.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
End Class