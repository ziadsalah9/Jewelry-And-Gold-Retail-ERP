Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports Microsoft.SqlServer.Types

Public Class ReportGoldShellMinistrial
    Dim SQLCommend As String

    Private Sub GetReportPath()
        RptView.Reset()
        RptView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        If ChbKYC.Checked Then
            GetInvoceReportPath(PathFiled:="Report_Path28")
        Else
            GetInvoceReportPath(PathFiled:="Report_Path28")
        End If
        RptView.LocalReport.ReportPath = ReportPath
        ''مهم لو أنت بتضيف DataSources باليد
        'RptView.LocalReport.DataSources.Clear()
        ''لو عندك باراميترات ثابتة أعد تعيينها هنا (اختياري)
        ''RptView.LocalReport.SetParameters(...)
        RptView.RefreshReport()
    End Sub
    Public Sub ReportPrint()
        ' لاحظ هنا استخدمنا الكويري الشامل (المينستريال) الذي رتبناه سابقاً
        SQLCommend = "SELECT * FROM ViwGoldInvoceMinisterialReport"

        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)

        If GetReporData.Rows.Count > 0 Then
            ' أهم خطوة: تغيير DataSet1 إلى DataSet2 لتطابق التصميم الجديد
            Dim ReportDataSource = New ReportDataSource("DataSet2", GetReporData)

            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)

            ' إضافة الباراميترات
            Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
            Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.ToShortDateString())
            Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.ToShortDateString())

            RptView.LocalReport.SetParameters(New ReportParameter() {sh_name, from_date, to_date})

            RptView.RefreshReport()
        Else
            MsgBox("لا توجد بيانات للعرض")
        End If
    End Sub

    ' 3. حدث تحميل الفورم
    Private Sub ReportGoldShellMinistrial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyIconsToContainer(Me)
            ControlsAsColor(ColorSelect:=Me)
            frmMain.Timer1.Stop()

            GetReportPath()
            '  ReportPrint() ' استدعاء الطباعة عند الفتح
        Catch ex As Exception
            ' لتجنب توقف البرنامج إذا كان هناك خطأ في المسار
        End Try
    End Sub

    ' 4. البحث بالتاريخ مع DataSet2
    Private Sub ParaByDate()
        SQLCommend = ("SELECT * FROM ViwGoldInvoceMinisterialReport WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY date DESC")

        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)

        ' تحديث الباراميترات
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)

        RptView.LocalReport.SetParameters(New ReportParameter() {sh_name, from_date, to_date})

        If GetReporData.Rows.Count > 0 Then
            ' استخدام DataSet2 هنا أيضاً
            Dim ReportDataSource = New ReportDataSource("DataSet2", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.RefreshReport()
        Else
            RptView.LocalReport.DataSources.Clear()
            RptView.RefreshReport()
            MsgBox("لا توجد بيانات في هذه الفترة")
        End If
    End Sub

    ' 5. أزرار التحكم
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        ParaByDate()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        RptView.PrintDialog()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    ' إغلاق الفورم وتشغيل التايمر مرة أخرى
    Private Sub ReportGoldShellMinistrial_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    'Private Sub GetReportPath()
    '    RptView.Reset()
    '    RptView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '    ' استخدام المسار المباشر الذي أرفقته
    '    Dim fullPath As String = "H:\mr-hossam\new1\HOSAM_SAP_2026-main\DT_restrant\bin\debug\Report\rptGoldSellMinistrial.rdlc"
    '    '   Dim fullPath As String = "H:\mr-hossam\new1\HOSAM_SAP_2026-main\DT_restrant\Report\rptGoldSellMinistrial.rdlc"

    '    If File.Exists(fullPath) Then
    '        RptView.LocalReport.ReportPath = fullPath
    '    Else
    '        ' حل احتياطي لو المسار اختلف عند النشر (يقرأ من فولدر الـ Report بجانب البرنامج)
    '        RptView.LocalReport.ReportPath = Path.Combine(Application.StartupPath, "Report\rptGoldSellMinistrial.rdlc")
    '    End If

    '    RptView.RefreshReport()
    'End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            ' 1. إعادة ضبط المسار للتأكد من اختيار التقرير الصحيح
            GetReportPath()

            ' 2. استدعاء دالة الطباعة التي تجلب كل البيانات (بدون فلتر التاريخ)
            ReportPrint()

            ' 3. تنبيه المستخدم في حالة عدم وجود داتا
            ' (تمت معالجتها بالفعل داخل ReportPrint)
        Catch ex As Exception
            MsgBox("خطأ أثناء عرض البيانات: " & ex.Message)
        End Try
    End Sub
End Class


