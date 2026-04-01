
Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class AuctionViewSellInvoice

    Private Sub GoldViewSellInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub GoldViewSellInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        language_start(Name)
        frmMain.Timer1.Stop()
        GetReportPath()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        txtInvoiceNo.SelectAll()
        txtInvoiceNo.Focus()
        btnPDF.Visible = False
        btnWhatsapp.Visible = False
    End Sub

    Private Sub btnView_LinkClicked(sender As Object, e As EventArgs) Handles btnView.Click
        If rbInvoiceNo.Checked = True Then
            InvoiceNoSearch()
        Else
            BarCodeSearch()
        End If

    End Sub

    Private Sub btnPrint_LinkClicked(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If DT_restrantDataSet.invoce_report.Rows.Count = 0 Then
                MsgBox("لا يوجد فاتورة لطباعتها" & vbCrLf & "No Invoice To Print.", , Apptitle)
                Exit Sub
            Else
                ReportViewer1.PrintDialog()
            End If
        Catch ex As Exception
            MsgBox("تجري الطباعة الآن" & vbCrLf & "Printing In Progress", , AppTitle)
        End Try

    End Sub
    Public Sub InvoiceNoSearch()
        Try
            AuctionInvoiceDetailsVwTableAdapter.FillBy(DT_restrantDataSet.AuctionInvoiceDetailsVw, txtInvoiceNo.Text)
            If AuctionInvoiceDetailsVwBindingSource.Count = 0 Then
                btnPDF.Visible = False
                btnWhatsapp.Visible = False
                ReportViewer1.Visible = False
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , Apptitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                Exit Sub
            Else
                btnPDF.Visible = True
                btnWhatsapp.Visible = True
                GetReportPath()
                ReportViewer1.Visible = True
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Please Enter Invoice No.", , Apptitle)
        End Try
    End Sub
    Private Sub BarCodeSearch()
        Try
            AuctionInvoiceDetailsVwTableAdapter.FillByBarCode(DT_restrantDataSet.AuctionInvoiceDetailsVw, txtInvoiceNo.Text)
            If AuctionInvoiceDetailsVwBindingSource.Count = 0 Then
                btnPDF.Visible = False
                btnWhatsapp.Visible = False
                ReportViewer1.Visible = False
                MsgBox("لا يوجد فاتورة مسجل بها باركود بهذا الرقم" & vbCrLf & "No Invoice with That No.", , Apptitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                Exit Sub
            Else
                btnPDF.Visible = True
                btnWhatsapp.Visible = True
                GetReportPath()
                ReportViewer1.Visible = True
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("أدخل رقم الباركود" & vbCrLf & "Please Enter BarCode No.", , Apptitle)
        End Try
    End Sub

    Private Sub BtnWhatsapp_Click(sender As Object, e As EventArgs) Handles btnWhatsapp.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeLabel.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        ' الحفظ ولالرسال عبر الوتس اب
        Try
            Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeLabel.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text) = False Then Directory.CreateDirectory(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
            Dim newFile As New FileStream(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)

            Exit Sub
        End Try
        Try
            If IsNumeric(CastomerTETextBox.Text.Trim) = False OrElse Len(CastomerTETextBox.Text.Trim) <> 8 Then
                MsgBox("رقم هاتف العميل مسجل بشكل غير صحيح" & vbCrLf & "Registered Customer Phone is Not Valid.", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End If
            Dim webAddress As String = "https://api.whatsapp.com/send?phone= " & "965" & CastomerTETextBox.Text & ""
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("تحقق من الاتصال بالإنترنت" & vbCrLf & "Please Check Internet Connection.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeLabel.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeLabel.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text) = False Then Directory.CreateDirectory(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
            Dim newFile As New FileStream(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Auctions\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub
    Private Sub chkEngInvoice_CheckedChanged(sender As Object, e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()
        If chkEngInvoice.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\rptAuctionSellPay-EN.rdlc"
        Else
            ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\report\rptAuctionSellPay.rdlc"
        End If

    End Sub

    Private Sub txtInvoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            InvoiceNoSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class