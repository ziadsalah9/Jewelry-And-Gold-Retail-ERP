Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class GoldViewSellInvoice
    Public GetInvoce As DataTable
    Dim RptPath As String
    Dim Stautes As String
    Dim AutoClose As String
    Dim Multiplepayment As Boolean
    Private Sub GoldViewSellInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            RptPath = dt1.Rows(0)("SET_INVARCHR156").ToString
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
            AutoClose = dt1.Rows(0)("SET_INVARCHR144").ToString
            Multiplepayment = dt1.Rows(0)("SET9").ToString
        End If
    End Sub

    Private Sub GoldViewSellInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        If DeletedInvoice = True Then
            If UILanguage = "A" Then
                Text = "عرض الفواتير المحذوفة"
            Else
                Text = "View Deleted Invoices"
            End If
        End If
        GetReportPath()
        BackWorkInv.RunWorkerAsync()
        RadCastm.Checked = True
    End Sub

    Private Sub btnView_LinkClicked(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        GetCastomAccReportPath()
        InvoiceSearch()
        SetReportPaper(ReportViewer1)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        'Try
        If GetInvoce.Rows.Count = 0 Then
            MsgBox("لا يوجد فاتورة لطباعتها" & vbCrLf & "No Invoice To Print.", , AppTitle)
            Exit Sub
        Else
            ReportViewer1.PrintDialog()
        End If
    End Sub
    Public Sub InvoiceSearch()
        'select * from ViwSilverInvoceReport WHERE(invoc_time = " & txtInvoiceNo.Text.Trim & ") AND (Active = 1) AND (SilverBAYActive = 1)
        Try
            GetInvoce = GetRecordSet("select * from ViwGoldInvoceReport WHERE(invoc_time like '" & txtInvoiceNo.Text.Trim & "') AND (BAYActive = 1) AND (Active = 1)")
            If GetInvoce.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", GetInvoce)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.RefreshReport()
            ElseIf GetInvoce.Rows.Count < 0 Then
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                ReportViewer1.Visible = False
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
            MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
        End Try
    End Sub
    Public Sub DeletedInvoiceSearch()

    End Sub

    Private Sub BtnWhatsapp_Click(sender As Object, e As EventArgs)
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
            If IO.Directory.Exists(Path & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text) = False Then IO.Directory.CreateDirectory(Path & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
            Dim newFile As New FileStream(Path & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text & "\" & BAY_SARYALTextBox.Text & ".PDF", IO.FileMode.Create)
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
            Dim webAddress As String = "https://wa.me/" & "965" & CastomerTETextBox.Text & ""
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("تحقق من الاتصال بالإنترنت" & vbCrLf & "Please Check Internet Connection.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub BtnPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF.Click
        
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
            If Directory.Exists(Path & "Gold-Silver\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text) = False Then Directory.CreateDirectory(Path & "Gold-Silver\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
            Dim newFile As New FileStream(Path & "Gold-Silver\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Gold-Silver\" & CastomerNAmeLabel.Text & "-" & CastomeridTextBox.Text)
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
        Dim GoldArPath As String = SET_INVARCHR156TextBox.Text.Trim
        Dim GoldEnPath As String = If(File.Exists(Replace(GoldArPath, ".rdlc", "-EN.rdlc")), Replace(GoldArPath, ".rdlc", "-EN.rdlc"), GoldArPath)
        Dim SilverArPath As String = Replace(GoldArPath, "Gold", "Silver")
        Dim SilverEnPath As String = If(File.Exists(Replace(SilverArPath, ".rdlc", "-EN.rdlc")), Replace(SilverArPath, ".rdlc", "-EN.rdlc"), SilverArPath)
        If GoldOrSilver = True Then
            If chkEngInvoice.Checked = True Then
                'Gold-Eng
                ReportViewer1.LocalReport.ReportPath = GoldEnPath
            Else
                'Gold-Ar
                ReportViewer1.LocalReport.ReportPath = GoldArPath
            End If
        Else
            If chkEngInvoice.Checked = True Then
                'Silver-Eng
                ReportViewer1.LocalReport.ReportPath = SilverEnPath
            Else
                'Silver-Ar
                ReportViewer1.LocalReport.ReportPath = SilverArPath
            End If
            GetCastomAccReportPath()
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            InvoiceSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub GetCastomAccReportPath()
        GetInvoceReportSettings(PathFiled:="SET_INVARCHR156")
        If RadCastm.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = ReportPath
        ElseIf RadAcc.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    'Do While -1
    '    '    txtInvoiceNo.Text = Val(TextBox1.Text) + 1
    '    '    btnPDF.PerformClick()
    '    '    If txtInvoiceNo.Text = "10" Then
    '    '        Exit Do
    '    '        Exit Sub
    '    '    End If
    '    'Loop
    'End Sub

    Private Sub RadCastm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCastm.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub BackWorkInv_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkInv.DoWork
        ReportViewer1.Invoke(Sub() ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout))
        txtInvoiceNo.Invoke(Sub() txtInvoiceNo.SelectAll())
        btnPDF.Invoke(Sub() btnPDF.Visible = False)
    End Sub

    Private Sub BackgroundWorkerGetInvoceNo_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerGetInvoceNo.DoWork
        Dim GetInvNo As DataTable = GetRecordSet("SELECT BAY_SARYAL FROM dbo.BAY WHERE (Active = 1) ORDER BY BAY_ID DESC")
        If GetInvNo.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = GetInvNo)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "BAY_SARYAL")
        End If
    End Sub

    Private Sub txtInvoiceNo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.DropDown
        If txtInvoiceNo.Items.Count <> 0 Then
            txtInvoiceNo.SelectedIndex = txtInvoiceNo.Items.Count - 1
        ElseIf txtInvoiceNo.Items.Count <= 0 Then
            BackgroundWorkerGetInvoceNo.RunWorkerAsync()
            txtInvoiceNo.SelectedIndex = txtInvoiceNo.Items.Count - 1
        End If
    End Sub

    Private Sub txtInvoiceNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.SelectedIndexChanged

    End Sub
End Class