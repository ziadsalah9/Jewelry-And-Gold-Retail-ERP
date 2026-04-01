Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondBuyDetailed
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
            ReportDiamondBuyInvoiceTableAdapter.Fill(DT_restrantDataSet.ReportDiamondBuyInvoice)
            ReportDiamondBuyInvoiceBindingSource.RemoveFilter()
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , Apptitle)
            End If
        End Try
    End Sub
    Private Sub btnDate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDate.Click
        Try
            SetParametersDate()
            ReportDiamondBuyInvoiceBindingSource.RemoveFilter()
            ReportDiamondBuyInvoiceBindingSource.Filter = "[date] >= '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND [date] <='" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "'"
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , Apptitle)
            End If
        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelPreview.Click
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
    Private Sub shr_all_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
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
        ReportDiamondBuyInvoiceTableAdapter.Fill(DT_restrantDataSet.ReportDiamondBuyInvoice)
        ReportDiamondBuyInvoiceBindingSource.RemoveFilter()
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                ReportDiamondBuyInvoiceBindingSource.Filter = " [CastomerNAme] LIKE '%" & txtSearch.Text & "%'"
            Case 1 'الرقم المدني
                ReportDiamondBuyInvoiceBindingSource.Filter = " [castomr_id] ='" & txtSearch.Text & "'"
            Case 2 'رقم الهاتف
                ReportDiamondBuyInvoiceBindingSource.Filter = " [CastomerTE] ='" & txtSearch.Text & "'"
            Case 3 ' النوع
                ReportDiamondBuyInvoiceBindingSource.Filter = " [DIMO_Type] LIKE '%" & txtSearch.Text & "%'"
            Case 4 'رقم القطعة
                ReportDiamondBuyInvoiceBindingSource.Filter = " [sarual] = '" & txtSearch.Text & "'"
            Case 5 ' الباركود
                ReportDiamondBuyInvoiceBindingSource.Filter = " [dimo_id] ='" & txtSearch.Text & "'"
            Case 6 ' الكاشير
                ReportDiamondBuyInvoiceBindingSource.Filter = " [baguette] LIKE '%" & txtSearch.Text & "%'"
            Case 7 'رقم الفاتورة
                ReportDiamondBuyInvoiceBindingSource.Filter = " [BAY_SARYAL] = '" & txtSearch.Text & "'"
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