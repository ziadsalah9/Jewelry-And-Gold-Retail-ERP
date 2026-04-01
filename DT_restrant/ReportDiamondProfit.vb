Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondProfit
    Private Sub shr_all_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            ReportDiamondProfitTableAdapter.Fill(DT_restrantDataSet.ReportDiamondProfit)
            ReportDiamondProfitBindingSource.RemoveFilter()
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
            ReportDiamondProfitBindingSource.RemoveFilter()
            ReportDiamondProfitTableAdapter.Fill(DT_restrantDataSet.ReportDiamondProfit)
            ReportDiamondProfitBindingSource.Filter = "[date_creted] >= '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND [date_creted] <='" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "'"
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
        If txtSearch.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , Apptitle)
            Exit Sub
        End If
        ReportDiamondProfitTableAdapter.Fill(DT_restrantDataSet.ReportDiamondProfit)
        ReportDiamondProfitBindingSource.RemoveFilter()
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'النوع
                ReportDiamondProfitBindingSource.Filter = " [DIMO_Type] LIKE '%" & txtSearch.Text & "%'"
            Case 1 'القيراط
                ReportDiamondProfitBindingSource.Filter = " [DIMO_mezan] ='" & txtSearch.Text & "'"
            Case 2 'النقاوة
                ReportDiamondProfitBindingSource.Filter = " [DIM_na9awa] ='" & txtSearch.Text & "'"
            Case 3 'الباركود
                ReportDiamondProfitBindingSource.Filter = " [test_119] = '" & txtSearch.Text & "'"
            Case 4 'القص
                ReportDiamondProfitBindingSource.Filter = " [test_117] = '" & txtSearch.Text & "'"
            Case 5 'الكاشير
                ReportDiamondProfitBindingSource.Filter = " [test_118] = '" & txtSearch.Text & "'"
            Case 6 'رقم الفاتورة
                ReportDiamondProfitBindingSource.Filter = " [BAY_SARYAL] = '" & txtSearch.Text & "'"
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