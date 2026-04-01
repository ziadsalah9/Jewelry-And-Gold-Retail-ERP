Imports Microsoft.Reporting.WinForms


Public Class CivilIDPrint

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
        Close()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        CastomerDETELSTableAdapter.FillBy(DT_restrantDataSet.CastomerDETELS, txtCID.Text.Trim)
        Dim paramPrintSettings As New ReportParameter("paramPrintSettings", cmbPrintSelection.SelectedIndex)
        ReportViewer1.LocalReport.SetParameters(paramPrintSettings)
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub CivilIDPrint_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        cmbPrintSelection.SelectedIndex = 0
    End Sub
End Class