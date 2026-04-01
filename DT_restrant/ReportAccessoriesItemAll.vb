Imports Microsoft.Reporting.WinForms
Public Class ReportAccessoriesItemAll
    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        AccessoriesItemAllVwTableAdapter.Fill(DT_restrantDataSet.AccessoriesItemAllVw)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            AccessoriesItemAllVwTableAdapter.Fill(DT_restrantDataSet.AccessoriesItemAllVw)
            AccessoriesItemAllVwBindingSource.RemoveFilter()
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , Apptitle)
            End If
        End Try
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Try
            SetParametersDate()
            AccessoriesItemAllVwBindingSource.RemoveFilter()
            AccessoriesItemAllVwBindingSource.Filter = "[Accessories_DATE_CRE] >= '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND [Accessories_DATE_CRE] <='" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "'"
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , Apptitle)
            End If
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(sender As Object, e As EventArgs) Handles btnCancelPreview.Click
        ReportViewer1.SetDisplayMode(DisplayMode.Normal)
    End Sub
    Sub SetParametersAll()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Sub SetParametersDate()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub shr_all_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub
    Private Sub PerformSearch()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , Apptitle)
            Exit Sub
        End If
        If txtSearch.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , Apptitle)
            Exit Sub
        End If
        AccessoriesItemAllVwTableAdapter.Fill(DT_restrantDataSet.AccessoriesItemAllVw)
        AccessoriesItemAllVwBindingSource.RemoveFilter()
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم الصنف
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_NAME] LIKE '%" & txtSearch.Text & "%'"
            Case 1 'الماركة
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_BRAND] LIKE '%" & txtSearch.Text & "%'"
            Case 2 'الموديل
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_model_no] LIKE '%" & txtSearch.Text & "%'"
            Case 3 'رقم القطعة
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_nom] LIKE '%" & txtSearch.Text & "%'"
            Case 4 'الرمز
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_Code] LIKE '%" & txtSearch.Text & "%'"
            Case 5 'التكلفة
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_Cost] LIKE '%" & txtSearch.Text & "%'"
            Case 6 'السعر
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_Price] LIKE '%" & txtSearch.Text & "%'"
            Case 7 'الباركود
                AccessoriesItemAllVwBindingSource.Filter = " [AccessoriesID] LIKE '%" & txtSearch.Text & "%'"
            Case 8 'المورد
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_Supplier] LIKE '%" & txtSearch.Text & "%'"
            Case 9 'المرفقات
                AccessoriesItemAllVwBindingSource.Filter = " [Accessories_Attachments] LIKE '%" & txtSearch.Text & "%'"
        End Select
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class