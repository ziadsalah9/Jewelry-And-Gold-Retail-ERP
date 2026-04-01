
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class ReportViewDetails
    Private Sub ReportViewDetails_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub ReportViewDetails_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewerViwAll.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Sub SetParametersDate()
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewerViwAll.LocalReport.SetParameters(sh_name)
        ReportViewerViwAll.LocalReport.SetParameters(from_date)
        ReportViewerViwAll.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub ReportViewDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        ChBoxBayDate.Checked = False
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Dim GetReportPath As DataTable = GetRecordSet("SELECT [Report_Path10] FROM [ReportPath]")
        If GetReportPath.Rows.Count > 0 Then
            ReportViewerViwAll.LocalReport.ReportPath = GetReportPath.Rows(0)(0).ToString
        End If
        RadAllData.Checked = True
        SetParametersDate()
    End Sub

    Private Sub btnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAll.Click
        ViwAll()
    End Sub
    Public Sub ViwAll()
        Dim SqlCom As DataTable = GetRecordSet("SELECT * FROM [ViwSndToCustomer]")
        If SqlCom.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", SqlCom)
            ReportViewerViwAll.LocalReport.DataSources.Clear()
            ReportViewerViwAll.LocalReport.DataSources.Add(ReportDataSource)
            ReportViewerViwAll.RefreshReport()
            ReportViewerViwAll.SetDisplayMode(DisplayMode.PrintLayout)
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        ReportViewerViwAll.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub btnCancelPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPreview.Click
        ReportViewerViwAll.SetDisplayMode(DisplayMode.Normal)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOnlyCastom.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadOnlyComp.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAllData.CheckedChanged

    End Sub
End Class