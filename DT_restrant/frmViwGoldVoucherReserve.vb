
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Drawing.Printing

Public Class frmViwGoldVoucherReserve
    Private Sub GetReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path21")
        RptView.LocalReport.ReportPath = ReportPath
    End Sub

    Public Sub ReportPrint()
        Dim GetReporData As DataTable = GetRecordSet("select * from ViwGoldVoucherReserve where VoucherNumber ='" & txtInvoiceNo.Text.Trim & "' and Activite=1")
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.RefreshReport()
            RptView.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub frmViwGoldVoucherReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        GetReportPath()
        If FrmGoldVoucherReserve.Visible = True Then
            Me.RptView.RefreshReport()
        ElseIf FrmGoldVoucherReserve.Visible = False Then
            BackgroundWorkerGetInv.RunWorkerAsync()
            BackWorkInv.RunWorkerAsync()
            Me.RptView.RefreshReport()
        End If
    End Sub
    Private Sub BackgroundWorkerGetInv_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerGetInv.DoWork
        Dim GetInvNo As DataTable = GetRecordSet("SELECT MIN(GoldVoucherReceiveID) AS GoldVoucherReceiveID, VoucherNumber" & vbCrLf &
                                               "FROM TPGoldVoucher" & vbCrLf &
                                               "WHERE Activite = 1" & vbCrLf &
                                               "GROUP BY VoucherNumber" & vbCrLf &
                                               "ORDER BY MIN(GoldVoucherReceiveID) DESC")
        If GetInvNo.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = GetInvNo)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "VoucherNumber")
        End If
    End Sub

    Private Sub BackWorkInv_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkInv.DoWork
        RptView.Invoke(Sub() RptView.SetDisplayMode(DisplayMode.PrintLayout))
        txtInvoiceNo.Invoke(Sub() txtInvoiceNo.SelectAll())
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ReportPrint()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintReport()
    End Sub
    Private Sub PrintReport()
        Try
            Dim printerSettings As New PrinterSettings()
            printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
            RptView.PrinterSettings = printerSettings
            RptView.PrintDialog()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub
End Class