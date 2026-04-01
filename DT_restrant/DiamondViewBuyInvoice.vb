
Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class DiamondViewBuyInvoice
    Private Sub DiamondViewBuyInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub DiamondViewBuyInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        language_start(Name)
        frmMain.Timer1.Stop()
        GetReportPath()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        txtInvoiceNo.SelectAll()
        txtInvoiceNo.Focus()
    End Sub


    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        InvoiceSearch()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            If DT_restrantDataSet.ReportDiamondBuyInvoice.Rows.Count = 0 Then
                MsgBox("لا يوجد فاتورة لطباعتها" & vbCrLf & "No Invoice To Print.", , AppTitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                Exit Sub
            Else
                ReportViewer1.PrintDialog()
            End If
        Catch ex As Exception
            MsgBox("خطا في مدخلات الفاتورة" & vbCrLf & "Error in invoice entries", , Apptitle)
            Exit Sub
        End Try
    End Sub
    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        ReportViewer1.RefreshReport()
        'ReportViewer1.SetDisplayMode(DisplayMode.Normal)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()
        Dim DiamondArPath As String = SET_INVARCHR157TextBox.Text.Trim
        Dim DiamondEnPath As String = If(File.Exists(Replace(DiamondArPath, ".rdlc", "-EN.rdlc")), Replace(DiamondArPath, ".rdlc", "-EN.rdlc"), DiamondArPath)
        If chkEngInvoice.Checked = True Then
            'Diamond-Eng
            ReportViewer1.LocalReport.ReportPath = DiamondEnPath
        Else
            'Diamond-Ar
            ReportViewer1.LocalReport.ReportPath = DiamondArPath
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            InvoiceSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Public Sub InvoiceSearch()
        GetReportPath()
        Me.ReportDiamondBuyInvoiceTableAdapter.SearchInvoiceNumber(DT_restrantDataSet.ReportDiamondBuyInvoice, txtInvoiceNo.Text)
        Try
            '    If DT_restrantDataSet.ReportGoldBuyInvoice.Rows.Count = 0 Then
            '        ReportViewer1.Visible = False
            '        MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
            '        txtInvoiceNo.SelectAll()
            '        txtInvoiceNo.Focus()
            '        Exit Sub
            '    Else
            '    End If
            ReportViewer1.Visible = True
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'End If
        Catch ex As Exception
            MsgBox("خطا في مدخلات الفاتورة" & vbCrLf & "Error in invoice entries", , AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click

        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeTextBox.Text
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
            saveFileDialog1.FileName = CastomerNAmeTextBox.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text) = False Then Directory.CreateDirectory(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text)
            Dim newFile As New FileStream(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub
    Private Sub BtnWhatsapp_Click(sender As Object, e As EventArgs)
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeTextBox.Text
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
            saveFileDialog1.FileName = CastomerNAmeTextBox.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text) = False Then Directory.CreateDirectory(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text)
            Dim newFile As New FileStream(Path & "Diamond-Buy\" & CastomerNAmeTextBox.Text & "-" & CastomerIDTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
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
End Class