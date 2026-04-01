Imports Microsoft.Reporting.WinForms
Public Class ReportAccessoriesSellDetailed
    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        SetParametersAll()
        Dim DT As DataTable = GetRecordSet("select * from ViwAccReport")
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            ReportViewer1.RefreshReport()
        Else
        End If
    End Sub
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Try
            SetParametersDate()
            Dim DT As DataTable = GetRecordSet("select * from ViwAccReport WHERE (Accessories_INV_DATE BETWEEN '" & DateToSave(DateTimePicker1.Value) & "' AND '" & DateToSave(DateTimePicker2.Value) & "')ORDER BY Accessories_INV_DATE")
            If DT.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
            Else
            End If
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
        'AccessoriesSellDetailedTableAdapter.Fill(DT_restrantDataSet.AccessoriesSellDetailed)
        'AccessoriesSellDetailedBindingSource.RemoveFilter()
        'Select Case cmbSearch.SelectedIndex
        '    Case 0 'اسم العميل
        '        AccessoriesSellDetailedBindingSource.Filter = " [CastomerNAme] LIKE '%" & txtSearch.Text & "%'"
        '    Case 1 'الرقم المدني
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_INV_CASTOMER_ID] LIKE '%" & txtSearch.Text & "%'"
        '    Case 2 'رقم الفاتورة
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_BAY_SARYAL] = '" & txtSearch.Text & "'"
        '    Case 3 'السعر
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_INV_total_price] = '" & txtSearch.Text & "'"
        '    Case 4 'باركود
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_INV_ITEM_ID] = '" & txtSearch.Text & "'"
        '    Case 5 'المورد
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_Supplier] LIKE '%" & txtSearch.Text & "%'"
        '    Case 6 'المرفقات
        '        AccessoriesSellDetailedBindingSource.Filter = " [Accessories_Attachments] LIKE '%" & txtSearch.Text & "%'"
        'End Select
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