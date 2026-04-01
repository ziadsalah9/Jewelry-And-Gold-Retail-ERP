Imports Microsoft.Reporting.WinForms
Public Class ReportAuctionSellDetailed
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            AuctionInvoiceDetailsVwBindingSource.RemoveFilter()
            AuctionInvoiceDetailsVwTableAdapter.Fill(DT_restrantDataSet.AuctionInvoiceDetailsVw)
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
            AuctionInvoiceDetailsVwBindingSource.RemoveFilter()
            AuctionInvoiceDetailsVwTableAdapter.FillByDate(DT_restrantDataSet.AuctionInvoiceDetailsVw, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
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
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Sub SetParametersDate()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        SetParametersAll()
        AuctionInvoiceDetailsVwTableAdapter.Fill(DT_restrantDataSet.AuctionInvoiceDetailsVw)
        AuctionInvoiceDetailsVwBindingSource.RemoveFilter()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SetParametersAll()
                AuctionInvoiceDetailsVwBindingSource.Filter = " CastomerNAme LIKE '%" & txtSearch.Text & "%'"
                ReportViewer1.RefreshReport()
            Case 1 'الرقم المدني
                SetParametersAll()
                AuctionInvoiceDetailsVwBindingSource.Filter = " CastomerCAIVELid LIKE '%" & txtSearch.Text & "%'"
                ReportViewer1.RefreshReport()
            Case 2 'الباركود
                SetParametersAll()
                AuctionInvoiceDetailsVwBindingSource.Filter = " Auction_ID = '" & txtSearch.Text & "'"
                ReportViewer1.RefreshReport()
            Case 3 'السعر
                SetParametersAll()
                AuctionInvoiceDetailsVwBindingSource.Filter = " TotalPrice = '" & txtSearch.Text & "'"
                ReportViewer1.RefreshReport()
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