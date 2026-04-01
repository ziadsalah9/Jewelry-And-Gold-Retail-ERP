Imports Microsoft.Reporting.WinForms
Public Class FrmReportSilvertemAvailable
    Dim SQLCommend As String
    Private Sub FrmReportSilvertemAvailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptView.Visible = False
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        GetCastomAccReportPath()
        'BackWorkSearchParameters.RunWorkerAsync()
        Me.RptView.RefreshReport()
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
        Me.RptView.RefreshReport()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        RptView.PrintDialog()
    End Sub
    Sub SetParametersAll()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub
    Sub SetParametersDate()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        RptView.SetDisplayMode(DisplayMode.Normal)
    End Sub

    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        RptView.SetDisplayMode(DisplayMode.Normal)
    End Sub
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path19")
        RptView.LocalReport.ReportPath = ReportPath
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        SQLCommend = "SELECT * FROM ReportSilvertemAvailable"
        ReportPrint()
        RptView.Visible = True
    End Sub
    Public Sub ReportPrint()
        'SetParametersAll()
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.RefreshReport()
            RptView.SetDisplayMode(DisplayMode.Normal)
        Else
        End If
    End Sub

    Private Sub FrmReportSilvertemAvailable_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        RptView.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub FrmReportSilvertemAvailable_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()

        Dispose()
    End Sub
End Class