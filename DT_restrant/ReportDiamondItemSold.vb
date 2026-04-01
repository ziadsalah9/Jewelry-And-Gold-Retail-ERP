Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondItemSold
    Private Sub shr_all_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            ITEM_Sold_DiamondTableAdapter.Fill(DT_restrantDataSet.ITEM_Sold_Diamond)
            ITEM_Sold_DiamondBindingSource.RemoveFilter()
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            SetParametersAll()
            ITEM_Sold_DiamondTableAdapter.Fill(DT_restrantDataSet.ITEM_Sold_Diamond)
            ITEM_Sold_DiamondBindingSource.RemoveFilter()
            ReportViewer1.RefreshReport()
            'If My.Computer.Keyboard.CtrlKeyDown Then
            '    MsgBox(ex.Message)
            'Else
            '    MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , AppTitle)
            'End If
        End Try
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Try
            SetParametersDate()
            ITEM_Sold_DiamondBindingSource.RemoveFilter()
            ITEM_Sold_DiamondTableAdapter.FillByDate(DT_restrantDataSet.ITEM_Sold_Diamond, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            SetParametersDate()
            ITEM_Sold_DiamondBindingSource.RemoveFilter()
            ITEM_Sold_DiamondTableAdapter.FillByDate(DT_restrantDataSet.ITEM_Sold_Diamond, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            ReportViewer1.RefreshReport()
            'If My.Computer.Keyboard.CtrlKeyDown Then
            '    MsgBox(ex.Message)
            'Else
            '    MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , Apptitle)
            'End If
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
        ITEM_Sold_DiamondTableAdapter.Fill(DT_restrantDataSet.ITEM_Sold_Diamond)
        ITEM_Sold_DiamondBindingSource.RemoveFilter()
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم الصنف
                ITEM_Sold_DiamondBindingSource.Filter = " [DIMO_dep] LIKE '%" & txtSearch.Text & "%'"
            Case 1 'النقاوة
                ITEM_Sold_DiamondBindingSource.Filter = " [DIM_na9awa] ='" & txtSearch.Text & "'"
            Case 2 'القيراط
                ITEM_Sold_DiamondBindingSource.Filter = " [DIMO_mezan] ='" & txtSearch.Text & "'"
            Case 3 'القص
                ITEM_Sold_DiamondBindingSource.Filter = " [test_11] = '" & txtSearch.Text & "'"
            Case 4 'عيار الذهب
                ITEM_Sold_DiamondBindingSource.Filter = " [val_gold] = '" & txtSearch.Text & "'"
            Case 5 'التكلفة
                ITEM_Sold_DiamondBindingSource.Filter = " [test_12] = '" & txtSearch.Text & "'"
            Case 6 'رقم القطعة
                ITEM_Sold_DiamondBindingSource.Filter = " [sarual] LIKE '%" & txtSearch.Text & "%'"
            Case 7 'الباركود
                ITEM_Sold_DiamondBindingSource.Filter = " [test_119] = '" & txtSearch.Text & "'"
            Case 8 'المستخدم
                ITEM_Sold_DiamondBindingSource.Filter = " [qult] LIKE '%" & txtSearch.Text & "%'"
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