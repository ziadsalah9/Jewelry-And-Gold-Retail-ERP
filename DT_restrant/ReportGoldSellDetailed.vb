Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Threading.Tasks
Public Class ReportGoldSellDetailed
    Public Sub New()
        InitializeComponent()
        ApplyIconsToContainer(Me)
    End Sub
    Dim Selectvalus As String
    Dim SQLCommend As String
    Dim SQLSetParaWeight As String
    Dim SQLSetParaPayment As String

    Private Sub AdvancedDateSearch()
        On Error Resume Next
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  BAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim sh_name As New ReportParameter("sh_name", CurrentCompanyName)
        Dim from_date As New ReportParameter("from_date", DateTimePicker1.Value.Date)
        Dim to_date As New ReportParameter("to_date", DateTimePicker2.Value.Date)
        RptView.LocalReport.SetParameters(sh_name)
        RptView.LocalReport.SetParameters(from_date)
        RptView.LocalReport.SetParameters(to_date)
    End Sub
    'Dim SqlParaAll As String
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path17")
        RptView.LocalReport.ReportPath = ReportPath
    End Sub
    Public Sub ReportPrint()
        AdvancedDateSearch()
        Dim GetReporData As DataTable = GetRecordSet(SQLCommend)
        If GetReporData.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", GetReporData)
            RptView.LocalReport.DataSources.Clear()
            RptView.LocalReport.DataSources.Add(ReportDataSource)
            RptView.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            RptView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            RptView.RefreshReport()
        Else
        End If
    End Sub
    Private Sub ReportGoldSellDetailed_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        RptView.Visible = False
        ApplyIconsToContainer(Me)
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        GetCastomAccReportPath()
        BackWorkSearchParameters.RunWorkerAsync()
        RptView.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        RptView.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.RptView.RefreshReport()
        Me.RptView.RefreshReport()
    End Sub
    Private Sub btnViewAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewAll.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  BAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM ViwGoldInvoceReport")
        ReportPrint()
        RptView.Visible = True
    End Sub
    Private Sub btnDate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDate.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  BAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
        SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
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
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE CastomerNAme = N'" & CmbSearchValu.Text & "' AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                   "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                   "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, CastomerNAme, date" & vbCrLf &
                                   "FROM  dbo.ViwGoldInvoceReport GROUP BY CastomerNAme, date HAVING  " & vbCrLf &
                                   "(CastomerNAme = N'" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, CastomerNAme, date " & vbCrLf &
                                   "FROM dbo.ViwGoldInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, CastomerNAme, date HAVING   " & vbCrLf &
                                   "(CastomerNAme = N'" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE Castomerid ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                  "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                  "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, Castomerid, date" & vbCrLf &
                                  "FROM  dbo.ViwGoldInvoceReport GROUP BY Castomerid, date HAVING  " & vbCrLf &
                                  "(Castomerid = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, Castomerid, date " & vbCrLf &
                                   "FROM dbo.ViwGoldInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, Castomerid, date HAVING  " & vbCrLf &
                                   "(Castomerid = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 2 'رقم الهاتف

                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE CastomerTE ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                  "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                  "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, CastomerTE, date" & vbCrLf &
                                  "FROM dbo.ViwGoldInvoceReport GROUP BY CastomerTE, date HAVING  " & vbCrLf &
                                  "(CastomerTE = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, CastomerTE, date " & vbCrLf &
                                   "FROM dbo.ViwGoldInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, CastomerTE, date HAVING  " & vbCrLf &
                                   "(CastomerTE = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 3 'الكاشير

                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE cacher_name =N'" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                SQLSetParaWeight = ("SELECT SUM(item_gram) AS item_gram, SUM(item_extrasMAZAN) + SUM(StoneWeight2) + " & vbCrLf &
                                 "SUM(StoneWeight3) AS StoneWeight, SUM(item_extrasPRICE) + SUM(StonePrice2) + SUM(StonePrice3) AS StonePrice, " & vbCrLf &
                                 "SUM(item_extrasMAZAN) + SUM(StoneWeight2) + SUM(StoneWeight3) + SUM(item_gram) AS TotalWeight, cacher_name, date" & vbCrLf &
                                 "FROM dbo.ViwGoldInvoceReport GROUP BY cacher_name, date HAVING  " & vbCrLf &
                                 "(cacher_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")

                SQLSetParaPayment = ("SELECT Bank1 + Bank2 + Bank3 + Bank4 + KENT AS " & vbCrLf &
                                   "Bank, TOTAL_mony, CACH, balance, cacher_name, date " & vbCrLf &
                                   "FROM dbo.ViwGoldInvoceReport " & vbCrLf &
                                   "GROUP BY TOTAL_mony, CACH, balance, Bank1 + Bank2 + Bank3 + Bank4 + KENT, cacher_name, date HAVING  " & vbCrLf &
                                  "(cacher_name = '" & CmbSearchValu.Text & "') AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                AdvancedDateSearch()
                ReportPrint()
            Case 4 'رقم الفاتوره

                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'AND (date BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "')")
                ReportPrint()
        End Select
        RptView.RefreshReport()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        Dim ShowData As DataTable = GetRecordSet("Select BAY_ID from  BAY")
        If ShowData.Rows.Count < 1 Then
            MsgBox("لا توجد بيانات حسب القيم المدخله" & vbCrLf & "There Are No Sales According To The Entered Values.", , AppTitle)
            Exit Sub
        End If
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
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE CastomerNAme = N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 1 'الرقم المدني
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE Castomerid ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 2 'رقم الهاتف
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE CastomerTE ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 3 'الكاشير
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE cacher_name =N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 4 'رقم الفاتوره
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE BAY_SARYAL ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 5 'اسم الصنف
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE item_name =N'" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 6 'الباركود
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE BarCode ='" & CmbSearchValu.Text & "'")
                ReportPrint()
            Case 7 'عيار الفضه
                SQLCommend = ("SELECT * FROM dbo.ViwGoldInvoceReport WHERE GoledKarat ='" & CmbSearchValu.Text & "'")
                ReportPrint()
        End Select
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
        Dim DtGoldItemName As DataTable = GetRecordSet("SELECT CastomerNAme,Castomerid,CastomerTE,cacher_name,BAY_SARYAL,item_name,BarCode,GoledKarat FROM ViwGoldInvoceReport")
        If ChBoxBayDate.Checked = True Then
            Select Case cmbSearch.SelectedIndex
                Case 0 'اسم العميل
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerNAme", SqlCom:="SELECT CastomerNAme, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY CastomerNAme HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY CastomerNAme", ValMem:="CastomerNAme")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerNAme", ComboBoxName:=CmbSearchValu)
                Case 1 'الرقم المدني
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="Castomerid", SqlCom:="SELECT Castomerid, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY Castomerid HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY Castomerid", ValMem:="Castomerid")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="Castomerid", ComboBoxName:=CmbSearchValu)
                Case 2 'رقم الهاتف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerTE", SqlCom:="SELECT CastomerTE, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY CastomerTE HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY CastomerTE", ValMem:="CastomerTE")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerTE", ComboBoxName:=CmbSearchValu)
                Case 3 'الكاشير
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="cacher_name", SqlCom:="SELECT cacher_name, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY cacher_name HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY cacher_name", ValMem:="cacher_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="cacher_name", ComboBoxName:=CmbSearchValu)
                Case 4 'رقم الفاتوره
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BAY_SARYAL", SqlCom:="SELECT BAY_SARYAL, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY BAY_SARYAL HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY BAY_SARYAL", ValMem:="BAY_SARYAL")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BAY_SARYAL", ComboBoxName:=CmbSearchValu)
                Case 5 'اسم الصنف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="item_name", SqlCom:="SELECT item_name, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY item_name HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY item_name", ValMem:="item_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="item_name", ComboBoxName:=CmbSearchValu)
                Case 6 'الباركود
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BarCode", SqlCom:="SELECT BarCode, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY BarCode HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY BarCode", ValMem:="BarCode")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BarCode", ComboBoxName:=CmbSearchValu)
                Case 7 'عيار الذهب
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="GoledKarat", SqlCom:="SELECT GoledKarat, MIN(DISTINCT date) AS date FROM dbo.ViwGoldInvoceReport GROUP BY GoledKarat HAVING (MIN(DISTINCT date) BETWEEN '" & Format(DateTimePicker1.Value, "yyyy/MM/dd") & "' AND '" & Format(DateTimePicker2.Value, "yyyy/MM/dd") & "') ORDER BY GoledKarat", ValMem:="GoledKarat")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="GoledKarat", ComboBoxName:=CmbSearchValu)
            End Select
        ElseIf ChBoxBayDate.Checked = False Then
            Select Case cmbSearch.SelectedIndex
                Case 0 'اسم العميل
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerNAme", SqlCom:="SELECT CastomerNAme FROM dbo.ViwGoldInvoceReport GROUP BY CastomerNAme ORDER BY CastomerNAme", ValMem:="CastomerNAme")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerNAme", ComboBoxName:=CmbSearchValu)
                Case 1 'الرقم المدني
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="Castomerid", SqlCom:="SELECT Castomerid  FROM dbo.ViwGoldInvoceReport GROUP BY Castomerid ORDER BY Castomerid", ValMem:="Castomerid")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="Castomerid", ComboBoxName:=CmbSearchValu)
                Case 2 'رقم الهاتف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="CastomerTE", SqlCom:="SELECT CastomerTE FROM dbo.ViwGoldInvoceReport GROUP BY CastomerTE  ORDER BY CastomerTE", ValMem:="CastomerTE")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CastomerTE", ComboBoxName:=CmbSearchValu)
                Case 3 'الكاشير
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="cacher_name", SqlCom:="SELECT cacher_name  FROM dbo.ViwGoldInvoceReport GROUP BY cacher_name ORDER BY cacher_name", ValMem:="cacher_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="cacher_name", ComboBoxName:=CmbSearchValu)
                Case 4 'رقم الفاتوره
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BAY_SARYAL", SqlCom:="SELECT BAY_SARYAL  FROM dbo.ViwGoldInvoceReport GROUP BY BAY_SARYAL  ORDER BY BAY_SARYAL", ValMem:="BAY_SARYAL")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BAY_SARYAL", ComboBoxName:=CmbSearchValu)
                Case 5 'اسم الصنف
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="item_name", SqlCom:="SELECT item_name  FROM dbo.ViwGoldInvoceReport GROUP BY item_name  ORDER BY item_name", ValMem:="item_name")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="item_name", ComboBoxName:=CmbSearchValu)
                Case 6 'الباركود
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="BarCode", SqlCom:="SELECT BarCode  FROM dbo.ViwGoldInvoceReport GROUP BY BarCode  ORDER BY BarCode", ValMem:="BarCode")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="BarCode", ComboBoxName:=CmbSearchValu)
                Case 7 'عيار الفضه
                    GetFillComboBox(ComboBoxName:=CmbSearchValu, DisMem:="GoledKarat", SqlCom:="SELECT GoledKarat  FROM dbo.ViwGoldInvoceReport GROUP BY GoledKarat ORDER BY GoledKarat", ValMem:="GoledKarat")
                    CmbSearchValu.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="GoledKarat", ComboBoxName:=CmbSearchValu)
            End Select
        End If
    End Sub
    Private Sub cmbSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
        AdvancedSearch()
    End Sub

    Private Sub ChBoxBayDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChBoxBayDate.CheckedChanged
        AdvancedSearch()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        language_start(Name)
    End Sub
    Private Sub BgLoadGoldData_DoWork(sender As Object, e As DoWorkEventArgs) Handles BgLoadGoldData.DoWork
    End Sub
    Private Sub BackWorkSearchParameters_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackWorkSearchParameters.DoWork
    End Sub
End Class