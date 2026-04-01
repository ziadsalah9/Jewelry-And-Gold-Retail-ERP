Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class From_ReportSndToCustomer
    Dim MAX As String = FrmSnd.MAX_ID
    Public GetReportPath As DataTable = GetRecordSet("SELECT Report_Path5,Report_Path6 FROM ReportPath")
    Private Sub GetRePath()
        Dim GetReportNullData As DataTable = GetRecordSet("SELECT Id,SndNumber,CompName FROM dbo.SndToCustomer WHERE SndNumber like N'" & txtInvoiceNo.Text.Trim & "'")
        Dim ms As String
        If GetReportNullData.Rows.Count > 0 Then
            ms = GetReportNullData.Rows(0)("CompName").ToString
            If ms.ToString = "" Then
                Re_View_SndToCustomer.LocalReport.ReportPath = GetReportPath.Rows(0)("Report_Path5").ToString()
                Re_View_SndToCustomer.RefreshReport()
            Else
                Re_View_SndToCustomer.LocalReport.ReportPath = GetReportPath.Rows(0)("Report_Path6").ToString()
                Re_View_SndToCustomer.RefreshReport()
            End If
        End If
    End Sub


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub From_ReportSndToCustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub From_ReportSndToCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Re_View_SndToCustomer.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub From_ReportSndToCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        GetRePath()
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If LblFilter.Text = 0 Then
            OpenReportCash("")
        ElseIf LblFilter.Text = 1 Then
            OpenReport("")
        ElseIf LblFilter.Text = 2 Then
            OpenReport(" and (SndGold.SndType = N'قبض ذهب  من')")
        ElseIf LblFilter.Text = 3 Then
            OpenReport(" and (SndGold.SndType = N'صرف ذهب  الى')")
        ElseIf LblFilter.Text = 4 Then
            OpenReportCash(" and (SndToCustomer.SndType = N'سند قبض')")
        ElseIf LblFilter.Text = 5 Then
            OpenReportCash(" and (SndToCustomer.SndType = N'سند صرف')")
        End If
        GetRePath()
    End Sub
    
    Sub OpenReport(filter As String)
        Dim DT As DataTable = GetRecordSet("SELECT TOP (100) PERCENT dbo.SndToCustomer.Id, dbo.SndToCustomer.SndNumber, dbo.SndToCustomer.Amount, dbo.SndToCustomer.Cash, dbo.SndToCustomer.Kent, dbo.SndToCustomer.Date_," &
                                           "dbo.SndToCustomer.Time_, dbo.SndToCustomer.Note_, dbo.SndToCustomer.NumToWorld_AR, dbo.SndToCustomer.NumToWorld_EN, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn," &
                                           " dbo.SndToCustomer.Activite, dbo.SndToCustomer.SndType, dbo.cacher.cacher_name, dbo.[user].user_name, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr," &
                                           " dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack," &
                                           " dbo.CastomerDETELS.CastomerNameEn, dbo.CastomerDETELS.CastomerCAIVELid, dbo.SndToCustomer.CompName" &
                                           " FROM  dbo.SndToCustomer INNER JOIN" &
                                           " dbo.PayMethod ON dbo.SndToCustomer.PayMID = dbo.PayMethod.ID INNER JOIN" &
                                           " dbo.CastomerDETELS ON dbo.SndToCustomer.civilid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" &
                                           " dbo.cacher ON dbo.SndToCustomer.Casher = dbo.cacher.svil_id INNER JOIN" &
                                           " dbo.[user] ON dbo.SndToCustomer.UserId = dbo.[user].user_id " &
                                           " WHERE(dbo.SndToCustomer.Activite = 1) and (SndToCustomer.SndNumber = N'" & txtInvoiceNo.Text & "') ORDER BY dbo.SndToCustomer.Date_ DESC, dbo.SndToCustomer.SndNumber DESC ")
        GetRePath()
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            Re_View_SndToCustomer.LocalReport.DataSources.Clear()
            Re_View_SndToCustomer.LocalReport.DataSources.Add(ReportDataSource)
            Re_View_SndToCustomer.RefreshReport()
            Re_View_SndToCustomer.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Sub OpenReportCash(filter As String)
        Dim DT As DataTable = GetRecordSet("SELECT TOP (100) PERCENT dbo.SndToCustomer.Id, dbo.SndToCustomer.SndNumber, dbo.SndToCustomer.Amount, dbo.SndToCustomer.Cash, dbo.SndToCustomer.Kent, dbo.SndToCustomer.Date_," &
                                           "dbo.SndToCustomer.Time_, dbo.SndToCustomer.Note_, dbo.SndToCustomer.NumToWorld_AR, dbo.SndToCustomer.NumToWorld_EN, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn," &
                                           " dbo.SndToCustomer.Activite, dbo.SndToCustomer.SndType, dbo.cacher.cacher_name, dbo.[user].user_name, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr," &
                                           " dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack," &
                                           " dbo.CastomerDETELS.CastomerNameEn, dbo.CastomerDETELS.CastomerCAIVELid, dbo.SndToCustomer.CompName" &
                                           " FROM  dbo.SndToCustomer INNER JOIN" &
                                           " dbo.PayMethod ON dbo.SndToCustomer.PayMID = dbo.PayMethod.ID INNER JOIN" &
                                           " dbo.CastomerDETELS ON dbo.SndToCustomer.civilid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" &
                                           " dbo.cacher ON dbo.SndToCustomer.Casher = dbo.cacher.svil_id INNER JOIN" &
                                           " dbo.[user] ON dbo.SndToCustomer.UserId = dbo.[user].user_id " &
                                           " WHERE(dbo.SndToCustomer.Activite = 1) and (SndToCustomer.SndNumber = N'" & txtInvoiceNo.Text & "')  ORDER BY dbo.SndToCustomer.Date_ DESC, dbo.SndToCustomer.SndNumber DESC ")
        GetRePath()
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            Re_View_SndToCustomer.LocalReport.DataSources.Clear()
            Re_View_SndToCustomer.LocalReport.DataSources.Add(ReportDataSource)
            Re_View_SndToCustomer.RefreshReport()
            Re_View_SndToCustomer.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Re_View_SndToCustomer.PrintDialog()
    End Sub
    Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
    Dim a As Decimal
    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            Re_View_SndToCustomer.LocalReport.DisplayName = "" ' اسم المورد
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try

            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            Re_View_SndToCustomer.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = Re_View_SndToCustomer.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = "" ' اسم المورد
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Gold-Silver\Sell") = False Then Directory.CreateDirectory(Path & "Gold-Silver\Sell")
            Dim newFile As New FileStream(Path & "Gold-Silver\Sell\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            MsgBox("PDF تم التصدير بصيغة" & vbCrLf & "PDF Export Done.", MsgBoxStyle.Information, AppTitle)
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub
End Class