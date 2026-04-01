Imports Microsoft.Reporting.WinForms
Public Class ReportSilverProfit
    Public Sub New()
        InitializeComponent()
        ApplyIconsToContainer(Me)
    End Sub
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String
    Private Sub ReportSilverProfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path27")
        ReportViewer1.LocalReport.ReportPath = ReportPath
    End Sub
    Sub SetParametersAll()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
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

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from ViwSilverInvoceReport")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM ViwSilverInvoceReport")
        ReportPrint()
        ReportViewer1.Visible = True
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  ViwSilverInvoceReport")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        ReportPrint()
        ReportViewer1.Visible = True
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        ReportViewer1.SetDisplayMode(DisplayMode.Normal)
    End Sub
    Private Sub ReportSilverProfit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
End Class