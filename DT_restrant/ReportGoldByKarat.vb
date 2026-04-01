Imports Microsoft.Reporting.WinForms
Public Class ReportGoldByKarat
    Private Sub shr_all_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Try
            SetParametersAll()
            ReportGoldByKaratTableAdapter.Fill(Me.DT_restrantDataSet.ReportGoldByKarat)
            ReportGoldByKaratBindingSource.RemoveFilter()
            If GoldOrSilver = True Then
                ReportGoldByKaratBindingSource.Filter = " Gram_valu <= '24'"
            Else
                ReportGoldByKaratBindingSource.Filter = " Gram_valu >= '700'"
            End If

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
            ReportGoldByKaratBindingSource.RemoveFilter()
            SetParametersDate()
            ReportGoldByKaratBindingSource.Filter = "[date] >= '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND [date] <='" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "'"
            ReportGoldByKaratTableAdapter.Fill(DT_restrantDataSet.ReportGoldByKarat)
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
        'Dim paramGoldOrSilver As New ReportParameter("GoldOrSilver", If(GoldOrSilver = True, "وزن الذهب", "وزن الفضة"))
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
        'ReportViewer1.LocalReport.SetParameters(paramGoldOrSilver)
    End Sub
    Sub SetParametersDate()
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        'Dim paramGoldOrSilver As New ReportParameter("GoldOrSilver", If(GoldOrSilver = True, "وزن الذهب", "وزن الفضة"))
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
        'ReportViewer1.LocalReport.SetParameters(paramGoldOrSilver)
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
        ReportGoldByKaratTableAdapter.Fill(DT_restrantDataSet.ReportGoldByKarat)
        ReportGoldByKaratBindingSource.RemoveFilter()
        If GoldOrSilver = True Then
            ReportGoldByKaratBindingSource.Filter = " Gram_valu <= '24'"
        Else
            ReportGoldByKaratBindingSource.Filter = " Gram_valu >= '700'"
        End If
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'العيار
                ReportGoldByKaratBindingSource.Filter &= "AND [Gram_valu] = '" & txtSearch.Text & "'"
            Case 1 'الوزن
                ReportGoldByKaratBindingSource.Filter &= "AND [item_gram] ='" & txtSearch.Text & "'"
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