Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms
Public Class ReportDiamondSellDetailedPortrait
    Public GetReportPath As DataTable = GetRecordSet("SELECT Report_Path7 FROM ReportPath")
    Public Sub ReportPrint()
        'If GetReportPath.Rows.Count > 0 Then
        '    Me.ReportViewer1.LocalReport.ReportPath = GetReportPath.Rows(0)("Report_Path7").ToString
        'End If
        SetParametersAll()
        Dim GetReporData As DataTable = GetRecordSet("select * from ReportDiamondSellDetailed ORDER BY date_creted DESC")
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub ReportDiamondSellDetailedPortrait_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        ChBoxBayDate.Checked = False
        frmMain.Timer1.Stop()
        language_start(Name)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy" 
        If GetReportPath.Rows.Count > 0 Then
            Me.ReportViewer1.LocalReport.ReportPath = GetReportPath.Rows(0)("Report_Path7").ToString
        End If
        'ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnViewAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewAll.Click
        'Try
        ReportPrint()
    End Sub
    Private Sub btnDate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDate.Click
        SqlCommnGetData(Sql_Commn:="SELECT KENT,TOTAL_mony,dimon_bay_cach,BAY_SARYAL,balance  FROM dbo.ReportDiamondSellDetailed WHERE " &
         "(date_creted BETWEEN '" & DateToSave(DateTimePicker1.Value) & "' AND '" & DateToSave(DateTimePicker2.Value) & "')GROUP BY KENT, TOTAL_mony, dimon_bay_cach, BAY_SARYAL, balance")
        Try
            ReportViewer1.LocalReport.DataSources.Clear()
            SetParametersDate()
            Dim GetFilterData As DataTable = GetRecordSet("SELECT * FROM dbo.ReportDiamondSellDetailed WHERE (date_creted BETWEEN '" & DateToSave(DateTimePicker1.Value) & "' AND '" & DateToSave(DateTimePicker2.Value) & "')ORDER BY date_creted")
            If GetFilterData.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", GetFilterData)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Else
            End If
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ في المدخلات النصية 132" & vbCrLf & "Error in data input 123", , AppTitle)
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
    Sub SetParameterForSelect()
        Try
            Dim GetDataSubForUser As DataTable = GetRecordSet("SELECT SUM(CAST(test_116 AS DECIMAL(18, 3))) AS test_116, " & vbCrLf &
                                                              "SUM(GOLD_mezan) AS GOLD_mezan, SUM(DIMO_mezan) AS DIMO_mezan, SUM(DIMO_qult) AS DIMO_qult, " & vbCrLf &
                                                              "SUM(CAST(test_16 AS DECIMAL(18, 3))) AS test_16, " & vbCrLf &
                                                              "SUM(CAST(test_13 AS DECIMAL(18, 3))) AS test_13, " & vbCrLf &
                                                              "SUM(CAST(test_19 AS DECIMAL(18, 3))) AS test_19, Item_Actv, descont " & vbCrLf &
                                                              "FROM dbo.dimon_invce " & vbCrLf &
                                                              "GROUP BY Item_Actv, descont " & vbCrLf &
                                                              "HAVING (Item_Actv = 1) AND (descont = N'" & txtSearch.Text & "'")

            If GetDataSubForUser.Rows.Count > 0 Then
                ''الوزن الكلي
                Dim GrossWi As Decimal = GetDataSubForUser.Rows(0)("test_116")
                Dim GrsWi As New ReportParameter("TotalGrossW", GrossWi)
                ReportViewer1.LocalReport.SetParameters(GrsWi)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'الوزن الكلي للاحجار
                Dim SumStonW As Decimal = GetDataSubForUser.Rows(0)("test_16") + (GetDataSubForUser.Rows(0)("test_13") + GetDataSubForUser.Rows(0)("test_19"))
                Dim ParSumSton As New ReportParameter("TotalStonW", SumStonW)
                ReportViewer1.LocalReport.SetParameters(ParSumSton)
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try


    End Sub
    Sub SetParametersAll()
        SqlCommnGetData(Sql_Commn:="SELECT KENT, TOTAL_mony, dimon_bay_cach,BAY_SARYAL,balance FROM dbo.ReportDiamondSellDetailed GROUP BY KENT, TOTAL_mony, dimon_bay_cach,BAY_SARYAL,balance")
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", "01/01/2020")
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        ReportViewer1.LocalReport.SetParameters(sh_name)
        ReportViewer1.LocalReport.SetParameters(from_date)
        ReportViewer1.LocalReport.SetParameters(to_date)
        ReportViewer1.RefreshReport()
    End Sub
    Sub SetParametersDate()
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
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
        If ChBoxBayDate.Checked = False Then
            PerformSearch()
        ElseIf ChBoxBayDate.Checked = True Then
            PerformSearchBayDate()
        End If

    End Sub
    Public Sub SqlCommnGetData(ByVal Sql_Commn As String)
        Dim GetKenetSumList, BankList, BalanceList, TotalSellList, CACHList As New ListBox
        Dim GetKenetSum, Bank, Balance, TotalSell, CACH As Double
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim GetFilterDataByName As DataTable = GetRecordSet(Sql_Commn)
        ''كي نت
        If GetFilterDataByName.Rows.Count > 0 Then
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                GetKenetSumList.Items.Add(GetFilterDataByName.Rows(i)("KENT").ToString)
                GetKenetSum += CDbl(GetKenetSumList.Items(i))
            Next
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim KNET As New ReportParameter("KNET", GetKenetSum)
            ReportViewer1.LocalReport.SetParameters(KNET)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'الباقي
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                BalanceList.Items.Add(GetFilterDataByName.Rows(i)("balance").ToString)
                Balance += (BalanceList.Items(i))
            Next
            Dim PARBalance As New ReportParameter("TotalRemaining", Balance)
            ReportViewer1.LocalReport.SetParameters(PARBalance)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'الكاش
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                CACHList.Items.Add(GetFilterDataByName.Rows(i)("dimon_bay_cach").ToString)
                CACH += (CACHList.Items(i))
            Next
            Dim PARCACH As New ReportParameter("Cash", CACH)
            ReportViewer1.LocalReport.SetParameters(PARCACH)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'اجمالي المبيعات
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                TotalSellList.Items.Add(GetFilterDataByName.Rows(i)("TOTAL_mony").ToString)
                TotalSell += (TotalSellList.Items(i))
            Next
            Dim PARTotalSell As New ReportParameter("Totalsales", TotalSell)
            ReportViewer1.LocalReport.SetParameters(PARTotalSell)
        End If
    End Sub
    Public Sub GetFilterData(ByVal Sql_Commn As String)
        Dim GetFilterData As DataTable = GetRecordSet(Sql_Commn)
        If GetFilterData.Rows.Count > 0 Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetFilterData)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub PerformSearch()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If txtSearch.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, CastomerNAme " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                            "GROUP BY dimon_bay_cach, KENT, balance, TOTAL_mony, CastomerNAme " & vbCrLf &
                                            "HAVING  (CastomerNAme = N'" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE CastomerNAme LIKE N'%" & txtSearch.Text & "%'")
            Case 1 'الرقم المدني
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, castomr_id " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY dimon_bay_cach, KENT, balance, TOTAL_mony, castomr_id " & vbCrLf &
                                            "HAVING (castomr_id = N'" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE castomr_id ='" & txtSearch.Text & "'")
            Case 2 'رقم الهاتف
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, CastomerTE " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY CastomerTE, dimon_bay_cach, KENT, balance, TOTAL_mony " & vbCrLf &
                                           "HAVING (CastomerTE = '" & txtSearch.Text & "') ")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE CastomerTE ='" & txtSearch.Text & "'")
            Case 3 ' النوع
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                           "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, DIMO_Type " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY DIMO_Type " & vbCrLf &
                                            "HAVING(DIMO_Type = N'%" & txtSearch.Text & "%')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE DIMO_Type LIKE N'%" & txtSearch.Text & "%'")
            Case 4 'رقم القطعة
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                            "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, sarual " & vbCrLf &
                                            "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                             "GROUP BY sarual HAVING (sarual = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE sarual ='" & txtSearch.Text & "'")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case 5 ' الباركود
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                            "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, test_119 " & vbCrLf &
                                            "FROM  dbo.ReportDiamondSellDetailed " & vbCrLf &
                                            "GROUP BY test_119 " & vbCrLf &
                                            "HAVING (test_119 = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE test_119 ='" & txtSearch.Text & "'")
            Case 6 ' الكاشير
                SqlCommnGetData(Sql_Commn:="SELECT KENT, TOTAL_mony, dimon_bay_cach,BAY_SARYAL,balance,cacher_name " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed GROUP BY KENT, TOTAL_mony, dimon_bay_cach,BAY_SARYAL,balance,cacher_name HAVING (cacher_name ='" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE cacher_name LIKE N'%" & txtSearch.Text & "%'")
            Case 7 'رقم الفاتورة
                SqlCommnGetData(Sql_Commn:="SELECT BAY_SARYAL, TOTAL_mony, dimon_bay_cach, KENT, balance, staytes  " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed   " & vbCrLf &
                                           "WHERE (Item_Actv = 1)  " & vbCrLf &
                                           "GROUP BY BAY_SARYAL, TOTAL_mony, dimon_bay_cach, KENT, balance, staytes   " & vbCrLf &
                                           "HAVING (BAY_SARYAL = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE BAY_SARYAL ='" & txtSearch.Text & "'")
            Case 8 ' الشهاده
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, CertificateNumber" & vbCrLf &
                                            "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                            "GROUP BY dimon_bay_cach, KENT, balance, TOTAL_mony, CertificateNumber" & vbCrLf &
                                            "HAVING (CertificateNumber = N'" & txtSearch.Text & "')")

                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE CertificateNumber =N'" & txtSearch.Text & "'")
        End Select
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub PerformSearchBayDate()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If txtSearch.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If
        SetParametersAll()
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, CastomerNAme " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                            "GROUP BY dimon_bay_cach, KENT, balance, TOTAL_mony, CastomerNAme " & vbCrLf &
                                            "HAVING  (CastomerNAme = N'" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE CastomerNAme LIKE N'%" & txtSearch.Text & "%'")
            Case 1 'الرقم المدني
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, castomr_id " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY dimon_bay_cach, KENT, balance, TOTAL_mony, castomr_id " & vbCrLf &
                                            "HAVING (castomr_id = N'" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE castomr_id ='" & txtSearch.Text & "'")
            Case 2 'رقم الهاتف
                SqlCommnGetData(Sql_Commn:="SELECT TOTAL_mony, dimon_bay_cach, KENT, balance, CastomerTE " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY CastomerTE, dimon_bay_cach, KENT, balance, TOTAL_mony " & vbCrLf &
                                           "HAVING (CastomerTE = '" & txtSearch.Text & "') ")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE CastomerTE ='" & txtSearch.Text & "'")
            Case 3 ' النوع
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                           "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, DIMO_Type " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                           "GROUP BY DIMO_Type " & vbCrLf &
                                            "HAVING(DIMO_Type = N'%" & txtSearch.Text & "%')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE DIMO_Type LIKE N'%" & txtSearch.Text & "%'")
            Case 4 'رقم القطعة
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                            "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, sarual " & vbCrLf &
                                            "FROM dbo.ReportDiamondSellDetailed " & vbCrLf &
                                             "GROUP BY sarual HAVING (sarual = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE sarual ='" & txtSearch.Text & "'")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case 5 ' الباركود
                SqlCommnGetData(Sql_Commn:="SELECT SUM(TOTAL_mony) AS TOTAL_mony, SUM(dimon_bay_cach) " & vbCrLf &
                                            "AS dimon_bay_cach, SUM(KENT) AS KENT, SUM(balance) AS balance, test_119 " & vbCrLf &
                                            "FROM  dbo.ReportDiamondSellDetailed " & vbCrLf &
                                            "GROUP BY test_119 " & vbCrLf &
                                            "HAVING (test_119 = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE test_119 ='" & txtSearch.Text & "'")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case 6 ' الكاشير
                SqlCommnGetData(Sql_Commn:="SELECT KENT, TOTAL_mony, dimon_bay_cach, BAY_SARYAL, balance, cacher_name, date_creted FROM  ReportDiamondSellDetailed " &
                                          "GROUP BY KENT, TOTAL_mony, dimon_bay_cach, BAY_SARYAL, balance, cacher_name, date_creted " &
                                          "HAVING (cacher_name = N'" & txtSearch.Text.Trim & "') AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM ReportDiamondSellDetailed WHERE (cacher_name LIKE N'" & txtSearch.Text & "') AND (date_creted BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case 7 'رقم الفاتورة
                SqlCommnGetData(Sql_Commn:="SELECT BAY_SARYAL, TOTAL_mony, dimon_bay_cach, KENT, balance, staytes  " & vbCrLf &
                                           "FROM dbo.ReportDiamondSellDetailed   " & vbCrLf &
                                           "WHERE (Item_Actv = 1)  " & vbCrLf &
                                           "GROUP BY BAY_SARYAL, TOTAL_mony, dimon_bay_cach, KENT, balance, staytes   " & vbCrLf &
                                           "HAVING (BAY_SARYAL = '" & txtSearch.Text & "')")
                GetFilterData(Sql_Commn:="SELECT * FROM dbo.ReportDiamondSellDetailed WHERE BAY_SARYAL ='" & txtSearch.Text & "'")
        End Select
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class