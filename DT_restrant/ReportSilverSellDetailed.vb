Imports Microsoft.Reporting.WinForms
Public Class ReportSilverSellDetailed
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String
    Private Sub AdvancedDateSearch()
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  SilverBAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        Dim GetReporParameterData As DataTable = GetRecordSet(SQLSetParaWeight)
        If GetReporParameterData.Rows.Count > 0 Then
            Dim SumSilverWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            Dim SumStonWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StoneWeight"))
            Dim SumPrice As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StonePrice"))
            Dim SumTotalWeight As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("TotalWeight"))

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim TotalSilverW As New ReportParameter("TotalSilverW", SumSilverWt)
            Dim TotalStonW As New ReportParameter("TotalStonW", SumStonWt)
            Dim TotalPrice As New ReportParameter("TotalPrice", SumPrice)
            Dim TotalWeight As New ReportParameter("TotalWeight", SumTotalWeight)
            RptView.LocalReport.SetParameters(TotalSilverW)
            RptView.LocalReport.SetParameters(TotalStonW)
            RptView.LocalReport.SetParameters(TotalPrice)
            RptView.LocalReport.SetParameters(TotalWeight)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
            Dim from_date As New ReportParameter("from_date", "01/01/2020")
            Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
            RptView.LocalReport.SetParameters(sh_name)
            RptView.LocalReport.SetParameters(from_date)
            RptView.LocalReport.SetParameters(to_date)
            GetReporParameterData.Rows.Clear()
        Else
        End If
        Dim GetReporParameterDataPayment As DataTable = GetRecordSet(SQLSetParaPayment)
        If GetReporParameterDataPayment.Rows.Count > 0 Then
            Dim SumBank As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("Bank"))
            Dim SumCash As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("CACH"))
            Dim SumTotalRemaining As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("balance"))
            Dim SumTotalsales As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TOTAL_mony"))
            Dim KNET As New ReportParameter("KNET", SumBank)
            Dim Cash As New ReportParameter("Cash", SumCash)
            Dim TotalRemaining As New ReportParameter("TotalRemaining", SumTotalRemaining)
            Dim Totalsales As New ReportParameter("Totalsales", SumTotalsales)
            RptView.LocalReport.SetParameters(KNET)
            RptView.LocalReport.SetParameters(Cash)
            RptView.LocalReport.SetParameters(TotalRemaining)
            RptView.LocalReport.SetParameters(Totalsales)
            GetReporParameterData.Rows.Clear()
        End If
    End Sub
    Private Sub ParaViwAll()
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  SilverBAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If

            SQLSetParaWeight = ("SELECT SUM( item_gram) AS item_gram, " & vbCrLf &
                                "SUM( item_extrasMAZAN)+" & vbCrLf &
                                "SUM( StoneWeight2)+" & vbCrLf &
                                "SUM( StoneWeight3) AS StoneWeight," & vbCrLf &
                                "SUM( item_extrasPRICE)+" & vbCrLf &
                                "SUM( StonePrice2)+" & vbCrLf &
                                "SUM( StonePrice3) AS StonePrice," & vbCrLf &
                                "SUM( item_extrasMAZAN)+" & vbCrLf &
                                "SUM( StoneWeight2)+" & vbCrLf &
                                "SUM( StoneWeight3) + " & vbCrLf &
                                "SUM( item_gram) AS TotalWeight" & vbCrLf &
                                "FROM dbo.ViwSilverInvoceReport")
            SQLSetParaPayment = "SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS Bank, TOTAL_mony, CACH, balance    FROM dbo.ViwSilverInvoceReport GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT"
            Dim GetReporParameterData As DataTable = GetRecordSet(SQLSetParaWeight)
            If GetReporParameterData.Rows.Count > 0 Then
                Dim SumSilverWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
                Dim SumStonWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StoneWeight"))
                Dim SumPrice As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StonePrice"))
                Dim SumTotalWeight As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("TotalWeight"))

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim TotalSilverW As New ReportParameter("TotalSilverW", SumSilverWt)
                Dim TotalStonW As New ReportParameter("TotalStonW", SumStonWt)
                Dim TotalPrice As New ReportParameter("TotalPrice", SumPrice)
                Dim TotalWeight As New ReportParameter("TotalWeight", SumTotalWeight)
                RptView.LocalReport.SetParameters(TotalSilverW)
                RptView.LocalReport.SetParameters(TotalStonW)
                RptView.LocalReport.SetParameters(TotalPrice)
                RptView.LocalReport.SetParameters(TotalWeight)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
                Dim from_date As New ReportParameter("from_date", "01/01/2020")
                Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
                RptView.LocalReport.SetParameters(sh_name)
                RptView.LocalReport.SetParameters(from_date)
                RptView.LocalReport.SetParameters(to_date)
            Else
            End If
            Dim GetReporParameterDataPayment As DataTable = GetRecordSet(SQLSetParaPayment)
            If GetReporParameterDataPayment.Rows.Count > 0 Then
                Dim SumBank As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("Bank"))
                Dim SumCash As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("CACH"))
                Dim SumTotalRemaining As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("balance"))
                Dim SumTotalsales As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TOTAL_mony"))
                Dim KNET As New ReportParameter("KNET", SumBank)
                Dim Cash As New ReportParameter("Cash", SumCash)
                Dim TotalRemaining As New ReportParameter("TotalRemaining", SumTotalRemaining)
                Dim Totalsales As New ReportParameter("Totalsales", SumTotalsales)

                RptView.LocalReport.SetParameters(KNET)
                RptView.LocalReport.SetParameters(Cash)
                RptView.LocalReport.SetParameters(TotalRemaining)
                RptView.LocalReport.SetParameters(Totalsales)
            End If

    End Sub
    Private Sub ParaByDate()
        SQLCommend = ("SELECT * FROM ViwSilverInvoceReport WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY date DESC, BAY_SARYAL DESC")
        SQLSetParaWeight = ("SELECT SUM( item_gram) AS item_gram, " & vbCrLf &
                     "SUM( item_extrasMAZAN)+" & vbCrLf &
                     "SUM( StoneWeight2)+" & vbCrLf &
                     "SUM( StoneWeight3) AS StoneWeight," & vbCrLf &
                     "SUM( item_extrasPRICE)+" & vbCrLf &
                     "SUM( StonePrice2)+" & vbCrLf &
                     "SUM( StonePrice3) AS StonePrice," & vbCrLf &
                     "SUM( item_extrasMAZAN)+" & vbCrLf &
                     "SUM( StoneWeight2)+" & vbCrLf &
                     "SUM( StoneWeight3) + " & vbCrLf &
                     "SUM( item_gram) AS TotalWeight,date" & vbCrLf &
                     "FROM dbo.ViwSilverInvoceReport GROUP BY date" & vbCrLf &
                     "HAVING (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        SQLSetParaPayment = ("SELECT date, Bank1 + Bank2 + Bank3 + Bank4 + KENT AS Bank, TOTAL_mony, CACH, balance FROM dbo.ViwSilverInvoceReport" & vbCrLf &
                            "GROUP BY date, TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT" & vbCrLf &
                             "HAVING (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        Dim GetReporParameterData As DataTable = GetRecordSet(SQLSetParaWeight)
        If GetReporParameterData.Rows.Count > 0 Then
            Dim SumSilverWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            Dim SumStonWt As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StoneWeight"))
            Dim SumPrice As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StonePrice"))
            Dim SumTotalWeight As Decimal = GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("TotalWeight"))

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim TotalSilverW As New ReportParameter("TotalSilverW", SumSilverWt)
            Dim TotalStonW As New ReportParameter("TotalStonW", SumStonWt)
            Dim TotalPrice As New ReportParameter("TotalPrice", SumPrice)
            Dim TotalWeight As New ReportParameter("TotalWeight", SumTotalWeight)
            RptView.LocalReport.SetParameters(TotalSilverW)
            RptView.LocalReport.SetParameters(TotalStonW)
            RptView.LocalReport.SetParameters(TotalPrice)
            RptView.LocalReport.SetParameters(TotalWeight)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
            Dim from_date As New ReportParameter("from_date", "01/01/2020")
            Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
            RptView.LocalReport.SetParameters(sh_name)
            RptView.LocalReport.SetParameters(from_date)
            RptView.LocalReport.SetParameters(to_date)
        Else
        End If
        Dim GetReporParameterDataPayment As DataTable = GetRecordSet(SQLSetParaPayment)
        If GetReporParameterDataPayment.Rows.Count > 0 Then
            Dim SumBank As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("Bank"))
            Dim SumCash As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("CACH"))
            Dim SumTotalRemaining As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("balance"))
            Dim SumTotalsales As Decimal = GetReporParameterDataPayment.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TOTAL_mony"))
            Dim KNET As New ReportParameter("KNET", SumBank)
            Dim Cash As New ReportParameter("Cash", SumCash)
            Dim TotalRemaining As New ReportParameter("TotalRemaining", SumTotalRemaining)
            Dim Totalsales As New ReportParameter("Totalsales", SumTotalsales)
            RptView.LocalReport.SetParameters(KNET)
            RptView.LocalReport.SetParameters(Cash)
            RptView.LocalReport.SetParameters(TotalRemaining)
            RptView.LocalReport.SetParameters(Totalsales)
        End If
    End Sub
    'Dim SqlParaAll As String
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path13")
        RptView.LocalReport.ReportPath = ReportPath
    End Sub
    Public Sub ReportPrint()
        'SetParametersAll()
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.RefreshReport()
            RptView.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub ReportSilverSellDetailed_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        RptView.Visible = False
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        GetCastomAccReportPath()
        BackWorkSearchParameters.RunWorkerAsync()
        Me.RptView.RefreshReport()
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
        Me.RptView.RefreshReport()
    End Sub

    Private Sub btnViewAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewAll.Click
        SQLCommend = "SELECT * FROM ViwSilverInvoceReport"
        ParaViwAll()
        ReportPrint()
        RptView.Visible = True
    End Sub
    Private Sub btnDate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDate.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  SilverBAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        ParaByDate()
        ReportPrint()
        RptView.Visible = True
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        RptView.PrintDialog()
    End Sub
    Private Sub btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreview.Click
        RptView.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
    Private Sub btnCancelPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelPreview.Click
        RptView.SetDisplayMode(DisplayMode.Normal)
    End Sub
   

    Private Sub shr_all_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        RptView.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Public Sub SqlCommnGetData(ByVal Sql_Commn As String)
        Dim GetKenetSumList, BankList, BalanceList, TotalSellList, CACHList As New ListBox
        Dim GetKenetSum, Bank, Balance, TotalSell, CACH As Double
        RptView.LocalReport.DataSources.Clear()
        Dim GetFilterDataByName As DataTable = GetRecordSet(Sql_Commn)
        ''كي نت
        If GetFilterDataByName.Rows.Count > 0 Then
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                GetKenetSumList.Items.Add(GetFilterDataByName.Rows(i)("KENT").ToString)
                GetKenetSum += CDbl(GetKenetSumList.Items(i))
            Next
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim KNET As New ReportParameter("KNET", GetKenetSum)
            RptView.LocalReport.SetParameters(KNET)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'الباقي
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                BalanceList.Items.Add(GetFilterDataByName.Rows(i)("balance").ToString)
                Balance += (BalanceList.Items(i))
            Next
            Dim PARBalance As New ReportParameter("TotalRemaining", Balance)
            RptView.LocalReport.SetParameters(PARBalance)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'الكاش
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                CACHList.Items.Add(GetFilterDataByName.Rows(i)("dimon_bay_cach").ToString)
                CACH += (CACHList.Items(i))
            Next
            Dim PARCACH As New ReportParameter("Cash", CACH)
            RptView.LocalReport.SetParameters(PARCACH)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'اجمالي المبيعات
            For i As Integer = 0 To GetFilterDataByName.Rows.Count - 1
                TotalSellList.Items.Add(GetFilterDataByName.Rows(i)("TOTAL_mony").ToString)
                TotalSell += (TotalSellList.Items(i))
            Next
            Dim PARTotalSell As New ReportParameter("Totalsales", TotalSell)
            RptView.LocalReport.SetParameters(PARTotalSell)
        End If
    End Sub
    Public Sub GetFilterData(ByVal Sql_Commn As String)
        Dim GetFilterData As DataTable = GetRecordSet(Sql_Commn)
        If GetFilterData.Rows.Count > 0 Then
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetFilterData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            RptView.RefreshReport()
            RptView.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub PerformSearchBayDate()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If CmbSearchValu.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If
        RptView.Visible = True
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerNAme = N'" & CmbSearchValu.Text & "' AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                   "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                   "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, CastomerNAme, date" & vbCrLf &
                                   "FROM  dbo.ViwSilverInvoceReport GROUP BY CastomerNAme, date HAVING  " & vbCrLf &
                                   "(CastomerNAme = N'" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, CastomerNAme, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, CastomerNAme, date HAVING   " & vbCrLf &
                                   "(CastomerNAme = N'" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE Castomerid ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                  "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                  "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, Castomerid, date" & vbCrLf &
                                  "FROM  dbo.ViwSilverInvoceReport GROUP BY Castomerid, date HAVING  " & vbCrLf &
                                  "(Castomerid = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, Castomerid, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, Castomerid, date HAVING  " & vbCrLf &
                                   "(Castomerid = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 2 'رقم الهاتف

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerTE ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                  "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                  "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, CastomerTE, date" & vbCrLf &
                                  "FROM dbo.ViwSilverInvoceReport GROUP BY CastomerTE, date HAVING  " & vbCrLf &
                                  "(CastomerTE = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, CastomerTE, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, CastomerTE, date HAVING  " & vbCrLf &
                                   "(CastomerTE = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 3 'الكاشير

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE cacher_name =N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                 "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                 "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, cacher_name, date" & vbCrLf &
                                 "FROM dbo.ViwSilverInvoceReport GROUP BY cacher_name, date HAVING  " & vbCrLf &
                                 "(cacher_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, cacher_name, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, cacher_name, date HAVING  " & vbCrLf &
                                  "(cacher_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()

            Case 4 'رقم الفاتوره

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                 "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                 "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, BAY_SARYAL, date" & vbCrLf &
                                 "FROM dbo.ViwSilverInvoceReport GROUP BY BAY_SARYAL, date HAVING  " & vbCrLf &
                                 "(BAY_SARYAL = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, BAY_SARYAL, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, BAY_SARYAL, date HAVING  " & vbCrLf &
                                   "(BAY_SARYAL = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                AdvancedDateSearch()
                ReportPrint()
            Case 5 'اسم الصنف

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE item_name =N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, item_name, date" & vbCrLf &
                                "FROM dbo.ViwSilverInvoceReport GROUP BY item_name, date HAVING  " & vbCrLf &
                                "(item_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, item_name, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, item_name, date HAVING  " & vbCrLf &
                                   "(item_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 6 'الباركود

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BarCode ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                               "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                               "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, BarCode, date" & vbCrLf &
                               "FROM dbo.ViwSilverInvoceReport GROUP BY BarCode, date HAVING  " & vbCrLf &
                               "(BarCode = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, BarCode, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, BarCode, date HAVING  " & vbCrLf &
                                   "(BarCode = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 7 'عيار الفضه

                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE GoledKarat ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                              "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                              "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, GoledKarat, date" & vbCrLf &
                              "FROM dbo.ViwSilverInvoceReport GROUP BY GoledKarat, date HAVING  " & vbCrLf &
                              "(GoledKarat = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, GoledKarat, date " & vbCrLf &
                                   "FROM dbo.ViwSilverInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, GoledKarat, date HAVING  " & vbCrLf &
                                   "(GoledKarat = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
        End Select
        RptView.RefreshReport()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If ChBoxBayDate.Checked = False Then
            PerformSearch()
        ElseIf ChBoxBayDate.Checked = True Then
            PerformSearchBayDate()
        End If
    End Sub
    Private Sub PerformSearch()
        If cmbSearch.SelectedIndex = -1 Then
            MsgBox("أدخل معيار البحث" & vbCrLf & "Please add Search Criteria", , AppTitle)
            Exit Sub
        End If
        If CmbSearchValu.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value to search", , AppTitle)
            Exit Sub
        End If

        RptView.Visible = True
        'If ChBoxBayDate.Checked = False Then
        Select Case cmbSearch.SelectedIndex
            Case 0 'اسم العميل
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerNAme = N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE Castomerid ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 2 'رقم الهاتف
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerTE ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 3 'الكاشير
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE cacher_name =N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 4 'رقم الفاتوره
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 5 'اسم الصنف
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE item_name =N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 6 'الباركود
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BarCode ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 7 'عيار الفضه
                SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE GoledKarat ='" & CmbSearchValu.Text & "'")
                ReportPrint()
        End Select
        'ElseIf ChBoxBayDate.Checked = True Then
        '    Select Case cmbSearch.SelectedIndex
        '        Case 0 'اسم العميل
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerNAme = N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 1 'الرقم المدني
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE Castomerid ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 2 'رقم الهاتف
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE CastomerTE ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 3 'الكاشير
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE cacher_name =N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 4 'رقم الفاتوره
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 5 'اسم الصنف
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE item_name =N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 6 'الباركود
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE BarCode ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '        Case 7 'عيار الفضه
        '            SQLCommend = ("SELECT * FROM dbo.ViwSilverInvoceReport WHERE GoledKarat ='" & CmbSearchValu.Text & "'WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
        '            ReportPrint()
        '    End Select
        'End If
        RptView.RefreshReport()
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub AdvancedSearch()
        Dim DtGoldItemName As DataTable = GetRecordSet("SELECT CastomerNAme,Castomerid,CastomerTE,cacher_name,BAY_SARYAL,item_name,BarCode,GoledKarat FROM ViwSilverInvoceReport")
        If ChBoxBayDate.Checked = True Then
            Select Case cmbSearch.SelectedIndex
                Case 0 'اسم العميل
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerNAme", SqlCom:="SELECT CastomerNAme, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY CastomerNAme HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY CastomerNAme", ValMem:="CastomerNAme")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerNAme", ComboBoxName:=CmbSearchValu)
                Case 1 'الرقم المدني
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="Castomerid", SqlCom:="SELECT Castomerid, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY Castomerid HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY Castomerid", ValMem:="Castomerid")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="Castomerid", ComboBoxName:=CmbSearchValu)
                Case 2 'رقم الهاتف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerTE", SqlCom:="SELECT CastomerTE, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY CastomerTE HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY CastomerTE", ValMem:="CastomerTE")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerTE", ComboBoxName:=CmbSearchValu)
                Case 3 'الكاشير
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="cacher_name", SqlCom:="SELECT cacher_name, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY cacher_name HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY cacher_name", ValMem:="cacher_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="cacher_name", ComboBoxName:=CmbSearchValu)
                Case 4 'رقم الفاتوره
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BAY_SARYAL", SqlCom:="SELECT BAY_SARYAL, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY BAY_SARYAL HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY BAY_SARYAL", ValMem:="BAY_SARYAL")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BAY_SARYAL", ComboBoxName:=CmbSearchValu)
                Case 5 'اسم الصنف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="item_name", SqlCom:="SELECT item_name, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY item_name HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY item_name", ValMem:="item_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="item_name", ComboBoxName:=CmbSearchValu)
                Case 6 'الباركود
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BarCode", SqlCom:="SELECT BarCode, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY BarCode HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY BarCode", ValMem:="BarCode")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BarCode", ComboBoxName:=CmbSearchValu)
                Case 7 'عيار الفضه
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="GoledKarat", SqlCom:="SELECT GoledKarat, MIN(DISTINCT date) AS date FROM dbo.ViwSilverInvoceReport GROUP BY GoledKarat HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY GoledKarat", ValMem:="GoledKarat")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="GoledKarat", ComboBoxName:=CmbSearchValu)
            End Select
        ElseIf ChBoxBayDate.Checked = False Then
            Select Case cmbSearch.SelectedIndex
                Case 0 'اسم العميل
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerNAme", SqlCom:="SELECT CastomerNAme FROM dbo.ViwSilverInvoceReport GROUP BY CastomerNAme ORDER BY CastomerNAme", ValMem:="CastomerNAme")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerNAme", ComboBoxName:=CmbSearchValu)
                Case 1 'الرقم المدني
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="Castomerid", SqlCom:="SELECT Castomerid  FROM dbo.ViwSilverInvoceReport GROUP BY Castomerid ORDER BY Castomerid", ValMem:="Castomerid")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="Castomerid", ComboBoxName:=CmbSearchValu)
                Case 2 'رقم الهاتف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerTE", SqlCom:="SELECT CastomerTE FROM dbo.ViwSilverInvoceReport GROUP BY CastomerTE  ORDER BY CastomerTE", ValMem:="CastomerTE")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerTE", ComboBoxName:=CmbSearchValu)
                Case 3 'الكاشير
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="cacher_name", SqlCom:="SELECT cacher_name  FROM dbo.ViwSilverInvoceReport GROUP BY cacher_name ORDER BY cacher_name", ValMem:="cacher_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="cacher_name", ComboBoxName:=CmbSearchValu)
                Case 4 'رقم الفاتوره
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BAY_SARYAL", SqlCom:="SELECT BAY_SARYAL  FROM dbo.ViwSilverInvoceReport GROUP BY BAY_SARYAL  ORDER BY BAY_SARYAL", ValMem:="BAY_SARYAL")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BAY_SARYAL", ComboBoxName:=CmbSearchValu)
                Case 5 'اسم الصنف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="item_name", SqlCom:="SELECT item_name  FROM dbo.ViwSilverInvoceReport GROUP BY item_name  ORDER BY item_name", ValMem:="item_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="item_name", ComboBoxName:=CmbSearchValu)
                Case 6 'الباركود
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BarCode", SqlCom:="SELECT BarCode  FROM dbo.ViwSilverInvoceReport GROUP BY BarCode  ORDER BY BarCode", ValMem:="BarCode")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BarCode", ComboBoxName:=CmbSearchValu)
                Case 7 'عيار الفضه
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="GoledKarat", SqlCom:="SELECT GoledKarat  FROM dbo.ViwSilverInvoceReport GROUP BY GoledKarat ORDER BY GoledKarat", ValMem:="GoledKarat")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="GoledKarat", ComboBoxName:=CmbSearchValu)
            End Select
        End If
    End Sub
    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        AdvancedSearch()
    End Sub

    Private Sub BackWorkSearchParameters_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkSearchParameters.DoWork
        
    End Sub

    Private Sub CmbSearchValu_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchValu.DropDown
       
    End Sub

    Private Sub CmbSearchValu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSearchValu.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim GetReporParameterData As DataTable = GetRecordSet("SELECT SUM(CAST(item_gram AS DECIMAL(18, 3))) AS item_gram, " & vbCrLf &
                     "SUM(CAST(item_extrasMAZAN + StoneWeight2 + StoneWeight3 AS DECIMAL(18, 3))) AS StoneWeight, " & vbCrLf &
                     "SUM(CAST(item_extrasPRICE + StonePrice2 + StonePrice3 AS DECIMAL(18, 3))) AS StonePrice, " & vbCrLf &
                     "CAST(item_totalPrice AS DECIMAL(18, 3)) AS item_totalPrice, " & vbCrLf &
                     "CAST(KENT + Bank1 + Bank2 + Bank3 + Bank4 AS DECIMAL(18, 3)) AS Bank, " & vbCrLf &
                     "CAST(CACH AS DECIMAL(18, 3)) AS CACH, CAST(balance AS DECIMAL(18, 3)) AS balance, " & vbCrLf &
                     "CAST(TOTAL_mony AS DECIMAL(18, 3)) AS TOTAL_mony, date" & vbCrLf &
                     "FROM dbo.ViwSilverInvoceReport" & vbCrLf &
                     "GROUP BY date, CAST(KENT + Bank1 + Bank2 + Bank3 + Bank4 AS DECIMAL(18, 3)), " & vbCrLf &
                     "CAST(CACH AS DECIMAL(18, 3)), CAST(balance AS DECIMAL(18, 3)), " & vbCrLf &
                     "CAST(TOTAL_mony AS DECIMAL(18, 3)), " & vbCrLf &
                     "CAST(item_totalPrice AS DECIMAL(18, 3)), " & vbCrLf &
                     "CAST(item_extrasPRICE + StonePrice2 + StonePrice3 AS DECIMAL(18, 3)), " & vbCrLf &
                     "CAST(item_extrasMAZAN + StoneWeight2 + StoneWeight3 AS DECIMAL(18, 3))" & vbCrLf &
                     "HAVING(date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "')")
        If GetReporParameterData.Rows.Count > 0 Then
            'Dim SumSilverWt As Decimal = GetReporParameterData.Rows(0)("item_gram").ToString
            'Dim SumStonWt As Decimal = GetReporParameterData.Rows(0)("StoneWeight").ToString
            'Dim SumPrice As Decimal = GetReporParameterData.Rows(0)("StonePrice").ToString
            'Dim SumBank As Decimal = GetReporParameterData.Rows(0)("Bank").ToString
            'Dim SumCash As Decimal = GetReporParameterData.Rows(0)("CACH").ToString
            'Dim SumTotalRemaining As Decimal = GetReporParameterData.Rows(0)("balance").ToString
            'Dim SumTotalsales As Decimal = GetReporParameterData.Rows(0)("TOTAL_mony").ToString

            'For I As Decimal = 0 To GetReporParameterData.Rows.Count - 1
            MsgBox(GetReporParameterData.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("StoneWeight")))
            'dt.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("TotalAmount"))
            'Next
        End If

    End Sub

    Private Sub ChBoxBayDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxBayDate.CheckedChanged
        AdvancedSearch()
    End Sub
End Class