Imports Microsoft.Reporting.WinForms

Public Class Accessories_ViewSellInvoice
    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            RptPath = dt1.Rows(0)("SET_INVARCHR150").ToString
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
        End If
    End Sub
    Dim RptPath As String
    Dim Check_rbCash_ar As String

    Private Sub Accessories_ViewSellInvoice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub Accessories_Invoice_return_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GetSettings()
        ReportViewer1.LocalReport.ReportPath = RptPath
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ControlsAsColor(ColorSelect:=Me)
    End Sub

    Private Sub btnView_LinkClicked(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        InvoiceSearch()
    End Sub

    Private Sub btnPrint_LinkClicked(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
    End Sub
    Public Sub InvoiceSearch()
        Dim DT As DataTable = GetRecordSet("select * from ViwAccReport WHERE (Accessories_INV_NO_ID = N'" & txtInvoiceNo.Text.Trim & "')")
        ReportViewer1.LocalReport.ReportPath = RptPath
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
        ReportViewer1.LocalReport.ReportPath = RptPath
        ReportViewer1.RefreshReport()
        Dim staytesParameter As New ReportParameter("staytesParameter", "نقدا")
        ReportViewer1.LocalReport.SetParameters(staytesParameter)
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

       
        'btnPrint.Enabled = True
        'ReportViewer1.LocalReport.ReportPath = RptPath
        'ReportViewer1.RefreshReport()
        'Dim staytesParameter As New ReportParameter("staytesParameter", "اجل")
        'ReportViewer1.LocalReport.SetParameters(staytesParameter)
        'ReportViewer1.RefreshReport()
        'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        'End If



        ReportViewer1.LocalReport.ReportPath = RptPath
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            Exit Sub
        End If
        If Accessories_staytesTextBox.Text = "1" Then
            Check_rbCash_ar = "نقدا"
        Else
            Check_rbCash_ar = "آجل"
        End If

        'Dim staytesParameter As New ReportParameter("staytesParameter", Check_rbCash_ar)
        'ReportViewer1.LocalReport.ReportPath = SET_INVARCHR150TextBox.Text
        'ReportViewer1.LocalReport.SetParameters(staytesParameter)
        'ReportViewer1.RefreshReport()
        'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
End Class