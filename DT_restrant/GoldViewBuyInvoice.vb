Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class GoldViewBuyInvoice
    Dim RptPath As String
    Public GetInvoce As DataTable
    Private Sub PrintReport()
        Try
            Dim printerSettings As New PrinterSettings()
            printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
            ReportViewer.PrinterSettings = printerSettings
            ReportViewer.PrintDialog()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub

    Private Sub GetCastomAccReportPath()
        GetInvoceReportSettings(PathFiled:="SET_INVARCHR158")
        If RadCastm.Checked = True Then
            ReportViewer.LocalReport.ReportPath = ReportPath
        ElseIf RadAcc.Checked = True Then
            ReportViewer.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub

    Private Sub GoldViewBuyInvoice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub RadCastm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GetCastomAccReportPath()
        ReportViewer.RefreshReport()
        If Saved Then ReportViewer.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' GetCastomAccReportPath()
        ReportViewer.RefreshReport()
        If Saved Then ReportViewer.RefreshReport()
    End Sub

    Private Sub GoldViewBuyInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        GetCastomAccReportPath()
        RadCastm.Checked = True
        BackWorkInv.RunWorkerAsync()
    End Sub
    Public Sub ViwInv()
        InvoiceSearch()
    End Sub
    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs)
        ViwInv()
    End Sub
    Private Sub InvoiceSearch()
        Try
            GetInvoce = GetRecordSet("select * from ViwGoldPurchaseInvoice  where inv_id = '" & txtInvoiceNo.Text & "' AND [INV_Actv] = 1")
            If GetInvoce.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", GetInvoce)
                ReportViewer.LocalReport.DataSources.Clear()
                ReportViewer.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer.RefreshReport()
                ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer.RefreshReport()
            ElseIf GetInvoce.Rows.Count < 0 Then
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                ReportViewer.Visible = False
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
            MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim SqlCom As DataTable = GetRecordSet("select * from ViwGoldPurchaseInvoice  where inv_id = '" & txtInvoiceNo.Text.Trim & "' AND [INV_Actv] = 1")
            If SqlCom.Rows.Count = 0 Then
                ReportViewer.Visible = False
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                'txtInvoiceNo.SelectAll()
                'txtInvoiceNo.Focus()
                Exit Sub
            ElseIf SqlCom.Rows.Count > 0 Then
                ReportViewer.PrintDialog()
            End If
        Catch ex As Exception
            MsgBox("خطا في مدخلات الفاتورة" & vbCrLf & "Error in invoice entries", , AppTitle)

            Exit Sub
        End Try
    End Sub
    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            InvoiceSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub BtnWhatsapp_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer.LocalReport.DisplayName = CastomerNAmeTextBox.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        ' الحفظ ولالرسال عبر الوتس اب
        Try
            Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            ReportViewer.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeTextBox.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If IO.Directory.Exists(Path & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text) = False Then IO.Directory.CreateDirectory(Path & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text)
            Dim newFile As New FileStream(Path & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text & "\" & Inv_idTextBox.Text & ".PDF", IO.FileMode.Create)
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

    Private Sub BtnPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer.LocalReport.DisplayName = CastomerNAmeTextBox.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            ReportViewer.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeTextBox.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Gold-Silver\" & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text) = False Then Directory.CreateDirectory(Path & "Gold-Silver\" & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text)
            Dim newFile As New FileStream(Path & "Gold-Silver\" & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Gold-Silver\" & CastomerNAmeTextBox.Text & "-" & Castomer_idTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' GetReportPath()
        ReportViewer.RefreshReport()
    End Sub

    Private Sub BacWorkInv_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        ' GetInvoiceNumber()
    End Sub

    Private Sub BackWorkInv_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkInv.DoWork
        Dim GetInvNo As DataTable = GetRecordSet("SELECT saryal, bay_id  FROM dbo.bay_goled_mony WHERE INV_Actv = 1 ORDER BY bay_id DESC")
        If GetInvNo.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = GetInvNo)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "saryal")
        End If
    End Sub
    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        GetCastomAccReportPath()
        InvoiceSearch()
        SetReportPaper(ReportViewer)
        ReportViewer.RefreshReport()
    End Sub
    Private Sub RadCastm_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadCastm.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadAcc.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer.RefreshReport()
    End Sub

    Private Sub btnPrint_Click_1(sender As Object, e As EventArgs) Handles btnPrint.Click


        PrintReport()
        'Try
        '    ReportViewer.PrintDialog()
        'Catch ex As Exception
        '    ReportViewer.PrintDialog()
        'End Try
    End Sub
End Class