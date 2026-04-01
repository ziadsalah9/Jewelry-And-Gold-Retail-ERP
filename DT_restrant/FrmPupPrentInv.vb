Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Drawing.Printing
Public Class FrmPupPrentInv
    Private Sub FrmPupPrentInv_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Public Sub InvShow()
        Dim SqlCom As DataTable = GetRecordSet(SqlComGetInv & TxtInv.Text & "'")
        If SqlCom.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", SqlCom)
            rptPupPrentInv.LocalReport.DataSources.Clear()
            rptPupPrentInv.LocalReport.DataSources.Add(ReportDataSource)
            rptPupPrentInv.RefreshReport()
            rptPupPrentInv.SetDisplayMode(DisplayMode.PrintLayout)
        End If
    End Sub
    Private Sub FrmPupPrentInv_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        rptPupPrentInv.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub FrmPupPrentInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        btnPDF.Visible = True
        rptPupPrentInv.Visible = False
        LinNoDta.Text = If(frmLogin.rbtnEn.Checked = True, "There Is No Data To Display !", "لا توجد بيانات لعرضها !")
        Dim GetReportPath As DataTable = GetRecordSet(ReportPath)
        If GetReportPath.Rows.Count > 0 Then
            rptPupPrentInv.LocalReport.ReportPath = GetReportPath.Rows(0)(0).ToString
            GetReportPath.Clear()
            If rptPupPrentInv.Visible = False Then
                rptPupPrentInv.Visible = True
            End If

        End If
        InvShow()
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        Expenses.PDF()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If rptPupPrentInv.Visible = False Then
            rptPupPrentInv.Visible = True
        End If
        InvShow()
    End Sub

    Private Sub btnView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If rptPupPrentInv.Visible = False Then
                rptPupPrentInv.Visible = True
            End If
            InvShow()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub TxtInv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If rptPupPrentInv.Visible = False Then
                rptPupPrentInv.Visible = True
            End If
            InvShow()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintingPapers()
        Try
            Dim printerSettings1 As New PrinterSettings
            printerSettings1.Copies = If(PrintingPapersNo = "", "2", PrintingPapersNo)
            rptPupPrentInv.PrintDialog(printerSettings1)
        Catch ex As Exception
            MsgBox("تجري الطباعة الان" & vbCrLf & "Printing in Progress..", , AppTitle)
        End Try
    End Sub
End Class