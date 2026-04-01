Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondItemAll
    Private Sub ReportDiamondItemAll_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        'Try
        '    DIMON_detelsTableAdapter.Fill(DT_restrantDataSet.DIMON_detels)
        'Catch ex As Exception

        'End Try
        'DIMON_detelsTableAdapter.Fill(DT_restrantDataSet.DIMON_detels)
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            DIMON_detelsTableAdapter.Fill(DT_restrantDataSet.DIMON_detels)
            DIMON_detelsBindingSource.RemoveFilter()
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , AppTitle)
            End If
        End Try
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Try
            SetParametersDate()
            DIMON_detelsBindingSource.RemoveFilter()
            DIMON_detelsTableAdapter.FillByDate(DT_restrantDataSet.DIMON_detels, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
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
        DIMON_detelsTableAdapter.Fill(DT_restrantDataSet.DIMON_detels)
        DIMON_detelsBindingSource.RemoveFilter()
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم الصنف
                DIMON_detelsBindingSource.Filter = " [DIMO_dep] LIKE '%" & txtSearch.Text & "%'"
            Case 1 'النقاوة
                DIMON_detelsBindingSource.Filter = " [DIM_na9awa] ='" & txtSearch.Text & "'"
            Case 2 'القيراط
                DIMON_detelsBindingSource.Filter = " [DIMO_mezan] ='" & txtSearch.Text & "'"
            Case 3 'القص
                DIMON_detelsBindingSource.Filter = " [test_11] = '" & txtSearch.Text & "'"
            Case 4 'عيار الذهب
                DIMON_detelsBindingSource.Filter = " [val_gold] = '" & txtSearch.Text & "'"
            Case 5 'التكلفة
                DIMON_detelsBindingSource.Filter = " [test_12] = '" & txtSearch.Text & "'"
            Case 6 'رقم القطعة
                DIMON_detelsBindingSource.Filter = " [sarual] LIKE '%" & txtSearch.Text & "%'"
            Case 7 'الباركود
                DIMON_detelsBindingSource.Filter = " [test_119] = '" & txtSearch.Text & "'"
            Case 8 'المستخدم
                DIMON_detelsBindingSource.Filter = " [qult] LIKE '%" & txtSearch.Text & "%'"
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