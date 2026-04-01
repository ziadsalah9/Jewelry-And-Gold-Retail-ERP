
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Microsoft.SqlServer.Types

Public Class ReportGoldSellShort
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String

    Private Sub GetReportPath()
        RptView.Reset()
        RptView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        If ChbKYC.Checked Then
            GetInvoceReportPath(PathFiled:="Report_Path26")
        Else
            GetInvoceReportPath(PathFiled:="Report_Path20")
        End If
        RptView.LocalReport.ReportPath = ReportPath
        ''مهم لو أنت بتضيف DataSources باليد
        'RptView.LocalReport.DataSources.Clear()
        ''لو عندك باراميترات ثابتة أعد تعيينها هنا (اختياري)
        ''RptView.LocalReport.SetParameters(...)
        RptView.RefreshReport()
    End Sub
    Public Sub ReportPrint()
        SQLCommend = "select * from ViwGoldInvoceReportShort"
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)

            Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
            Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
            Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
            RptView.LocalReport.SetParameters(sh_name)
            RptView.LocalReport.SetParameters(from_date)
            RptView.LocalReport.SetParameters(to_date)

            RptView.RefreshReport()
        Else
        End If
    End Sub
    Private Sub ReportGoldSellShort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyIconsToContainer(Me)
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        GetReportPath()
        RptView.RefreshReport()
    End Sub
    Private Sub ParaByDate()
        SQLCommend = ("SELECT * FROM ViwGoldInvoceReportShort WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY date DESC, BAY_SARYAL DESC")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.RefreshReport()
        Else
        End If
    End Sub


    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  BAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM ViwGoldInvoceReportShort")
        ReportPrint()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        RptView.PrintDialog()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        RptView.SetDisplayMode(DisplayMode.Normal)
    End Sub

    Private Sub ReportGoldSellShort_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Try
            RptView.LocalReport.ReleaseSandboxAppDomain()
            Dispose()
        Catch
        End Try
    End Sub

    Private Sub ReportGoldSellShort_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        Try
            RptView.LocalReport.ReleaseSandboxAppDomain()
            Dispose()
        Catch
        End Try
    End Sub

    Private Sub ChbKYC_CheckedChanged(sender As Object, e As EventArgs) Handles ChbKYC.CheckedChanged
        GetReportPath()
        ReportPrint()        ' إذا هذه الدالة تعبي الداتا وتضيف DataSources
        RptView.RefreshReport()
    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        ParaByDate()
    End Sub
End Class