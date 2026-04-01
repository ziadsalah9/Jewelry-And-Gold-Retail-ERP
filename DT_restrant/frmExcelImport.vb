Imports System.Data.OleDb
Imports System.IO
Public Class frmExcelImport
    Dim connExcel As OleDbConnection
    Dim cmdExcl As OleDbDataAdapter
    Dim dtExcel As New DataTable
    Dim OldFilePath As String
    Dim LastBarCode As String

#Region "Initialize"
    Private Sub frmImportData_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        Initialize()
    End Sub
    Public Sub Initialize()
        Dim dat As Date = Date.Now
        language_start(Name)
        grid.Rows.Clear()
        Dim dt1 As New DataTable
        Select Case ExcelImportType.ToUpper
            Case "GOLD"
                dt1 = GetRecordSet("SELECT MAX(CAST([ID] AS INT)) FROM [Fo_min]")
            Case "DIAMOND"
                dt1 = GetRecordSet("SELECT MAX(CAST([DIMOND_ID] AS INT)) FROM [DIMON_detels]")
        End Select
        If dt1.Rows.Count > 0 Then
            LastBarCode = If(IsDBNull(dt1.Rows(0)(0)) = True, "99", dt1.Rows(0)(0).ToString)
        End If
    End Sub
#End Region
#Region "Editing"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OldFilePath = txtFilePath.Text
        Dim OFD As New OpenFileDialog
        With OFD
            .Filter = "Excel 2007/2010/2013 Files|*.xlsx"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFilePath.Text = .FileName
                GetSheets(.FileName)
            End If
        End With
        If cmbSheet.Items.Count > 0 Then
            Select Case ExcelImportType.ToUpper
                Case "GOLD"
                    cmbSheet.SelectedItem = "Gold"
                Case "DIAMOND"
                    cmbSheet.SelectedItem = "Diamond"
            End Select
        End If
    End Sub
    Public Sub GetSheets(FilePath As String)
        Dim CharToTrim As Char() = {"$"c, "'"c}
        connExcel = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FilePath & ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1';")
        Try
            connExcel.Open()
            If OldFilePath <> FilePath Then dtExcel.Rows.Clear()
            Dim dataSet As DataTable = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cmbSheet.Items.Clear()
            For i As Integer = 0 To dataSet.Rows.Count - 1
                cmbSheet.Items.Add(dataSet.Rows(i)("TABLE_NAME").ToString.Trim(CharToTrim))
            Next
            connExcel.Close()
        Catch ex As Exception
            ' MsgBox("تعذر فتح الملف " & vbCrLf & "إذا كان الملف مفتوحًا داخل إكسل يرجى إغلاقه أولاً", vbExcl, MainTitle)
            MsgBox(ex.Message, vbExclamation, AppTitle)
        End Try
    End Sub
    Public Sub GetData()
        If connExcel.State = ConnectionState.Closed Then connExcel.Open()
        'grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        'grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        Select Case ExcelImportType.ToUpper
            Case "GOLD"
                strField = "[Serial] , [User Name] , [Item Name] , [Cost/gm] , [Supplier] , [Gold Weight] , [M.C.] , [Country] , [Total Price] , " &
                   "[Karat] , [Image] , [Date] , [Code] , [Stone Weight1] , [Stone Name1] , [Stone Color1] , [Stone Price1] , [Stone Weight2] , [Stone Name2] , [Stone Color2] , [Stone Price2] , " &
                   "[Stone Weight3] , [Stone Name3] , [Stone Color3] , [Stone Price3] , [Quantity] , [BarCode] , [Active Item] , " &
                   "[CostToSeller] , [TaxExempt] , [Documents] , [Cut1] , [Clarity1] , [Cut2] , [Clarity2] , [Cut3] , [Clarity3] , [IsDiamond1] , [IsDiamond2] , [IsDiamond1], [Supplier], [ItemNote]"
                cmdExcl = New OleDbDataAdapter("SELECT * FROM [" & cmbSheet.SelectedItem.ToString & "$]", connExcel)
                With grid
                    .Columns.Clear()
                    .Columns.Add("colID", If(frmLogin.rbtnEn.Checked = True, "", "م"))
                    .Columns.Add("coluserID", If(frmLogin.rbtnEn.Checked = True, "User Name", "اسم المستخدم"))
                    .Columns.Add("colFO_name", If(frmLogin.rbtnEn.Checked = True, "Item Name", "اسم الصنف"))
                    .Columns.Add("colFO_desp", If(frmLogin.rbtnEn.Checked = True, "Gram Cost", "تكلفة الجرام"))
                    .Columns.Add("colFO_GramPrice", If(frmLogin.rbtnEn.Checked = True, "Supplier", "المورد"))
                    .Columns.Add("colFO_gram", If(frmLogin.rbtnEn.Checked = True, "Gold Weight", "وزن الذهب"))
                    .Columns.Add("colFO_gramMade", If(frmLogin.rbtnEn.Checked = True, "Making Charge", "مصنعية الجرام"))
                    .Columns.Add("colFO_made", If(frmLogin.rbtnEn.Checked = True, "Origin", "المنشأ"))
                    .Columns.Add("colFO_totalPrice", If(frmLogin.rbtnEn.Checked = True, "Item Total Cost", "سعر شراء القطعة"))
                    .Columns.Add("colGram_valu", If(frmLogin.rbtnEn.Checked = True, "Karat", "العيار"))
                    .Columns.Add("colITEM_IMGE", If(frmLogin.rbtnEn.Checked = True, "Image", "الصورة"))
                    .Columns.Add("coldate_care", If(frmLogin.rbtnEn.Checked = True, "Date Added", "تاريخ الإضافة"))
                    .Columns.Add("colFO_ItemNo", If(frmLogin.rbtnEn.Checked = True, "Code", "الرمز"))
                    .Columns.Add("colFO_extras", If(frmLogin.rbtnEn.Checked = True, "CS Wt1", "وزن الفص1"))
                    .Columns.Add("colFO_price", If(frmLogin.rbtnEn.Checked = True, "CS Type1", "نوع الفص1"))
                    .Columns.Add("colStoneColor1", If(frmLogin.rbtnEn.Checked = True, "CS Color1", "لون الفص1"))
                    .Columns.Add("colStonePrice1", If(frmLogin.rbtnEn.Checked = True, "CS Price1", "سعر الفص1"))
                    .Columns.Add("colStoneWeight2", If(frmLogin.rbtnEn.Checked = True, "CS Wt2", "وزن الفص2"))
                    .Columns.Add("colStoneName2", If(frmLogin.rbtnEn.Checked = True, "CS Type2", "نوع الفص2"))
                    .Columns.Add("colStoneColor2", If(frmLogin.rbtnEn.Checked = True, "CS Color2", "لون الفص2"))
                    .Columns.Add("colStonePrice2", If(frmLogin.rbtnEn.Checked = True, "CS Price2", "سعر الفص2"))
                    .Columns.Add("colStoneWeight3", If(frmLogin.rbtnEn.Checked = True, "CS Wt3", "وزن الفص3"))
                    .Columns.Add("colStoneName3", If(frmLogin.rbtnEn.Checked = True, "CS Type3", "نوع الفص3"))
                    .Columns.Add("colStoneColor3", If(frmLogin.rbtnEn.Checked = True, "CS Color3", "لون الفص 3"))
                    .Columns.Add("colStonePrice3", If(frmLogin.rbtnEn.Checked = True, "CS Price3", "سعر الفص3"))
                    .Columns.Add("colQty", If(frmLogin.rbtnEn.Checked = True, "Qty", "العدد"))
                    .Columns.Add("colBarCode", If(frmLogin.rbtnEn.Checked = True, "BarCode", "الباركود"))
                    .Columns.Add("colItem_Actv", If(frmLogin.rbtnEn.Checked = True, "Exist", "موجود"))
                    .Columns("coluserID").Visible = False
                    .Columns("colITEM_IMGE").Visible = False
                    .Columns("colItem_Actv").Visible = False
                End With
                dtExcel.Reset()
                grid.Rows.Clear()
                Try
                    cmdExcl.Fill(dtExcel)
                    Dim row As DataRow = dtExcel.Rows(0)
                    For i As Integer = 0 To row.ItemArray.Length - 1
                        dtExcel.Columns(i).ColumnName = i 'row.Item(i).ToString()
                    Next
                    dtExcel.Rows.RemoveAt(0)
                    dtExcel.AcceptChanges()
                    If dtExcel.Rows.Count > 0 Then
                        For i As Integer = 0 To dtExcel.Rows.Count - 1
                            If dtExcel.Rows(i).Item(1).ToString <> "" Then
                                With grid
                                    .Rows.Add()
                                    .Rows(.Rows.Count - 1).Cells("colID").Value = i + 1 'Serial
                                    .Rows(.Rows.Count - 1).Cells("coluserID").Value = UserID 'User Name
                                    .Rows(.Rows.Count - 1).Cells("colFO_name").Value = dtExcel.Rows(i)(2).ToString.Trim 'Item Name
                                    .Rows(.Rows.Count - 1).Cells("colFO_desp").Value = Val(dtExcel.Rows(i)(3).ToString.Trim) 'Cost/gm
                                    .Rows(.Rows.Count - 1).Cells("colFO_GramPrice").Value = If(dtExcel.Rows(i)(4).ToString.Trim = "", "-", dtExcel.Rows(i)(4).ToString.Trim) 'Supplier
                                    .Rows(.Rows.Count - 1).Cells("colFO_gram").Value = Val(dtExcel.Rows(i)(5).ToString.Trim) 'Gold Weight
                                    .Rows(.Rows.Count - 1).Cells("colFO_gramMade").Value = Val(dtExcel.Rows(i)(6).ToString.Trim) 'M.C.
                                    .Rows(.Rows.Count - 1).Cells("colFO_made").Value = dtExcel.Rows(i)(7).ToString.Trim 'Country
                                    .Rows(.Rows.Count - 1).Cells("colFO_totalPrice").Value = Val(dtExcel.Rows(i)(8).ToString.Trim) 'Total Price
                                    .Rows(.Rows.Count - 1).Cells("colGram_valu").Value = Val(dtExcel.Rows(i)(9).ToString.Trim) 'Karat
                                    .Rows(.Rows.Count - 1).Cells("colITEM_IMGE").Value = Nothing 'Image
                                    .Rows(.Rows.Count - 1).Cells("coldate_care").Value = If(IsDate(dtExcel.Rows(i)(11).ToString), CDate(dtExcel.Rows(i)(11).ToString).ToShortDateString, Now.ToShortDateString) 'Date
                                    .Rows(.Rows.Count - 1).Cells("colFO_ItemNo").Value = dtExcel.Rows(i)(12).ToString.Trim 'Code
                                    .Rows(.Rows.Count - 1).Cells("colFO_extras").Value = Val(dtExcel.Rows(i)(13).ToString.Trim) 'Stone Weight1
                                    .Rows(.Rows.Count - 1).Cells("colFO_price").Value = dtExcel.Rows(i)(14).ToString.Trim 'Stone Name1
                                    .Rows(.Rows.Count - 1).Cells("colStoneColor1").Value = dtExcel.Rows(i)(15).ToString.Trim 'Stone Color1
                                    .Rows(.Rows.Count - 1).Cells("colStonePrice1").Value = Val(dtExcel.Rows(i)(16).ToString.Trim) 'Stone Price1
                                    .Rows(.Rows.Count - 1).Cells("colStoneWeight2").Value = Val(dtExcel.Rows(i)(17).ToString.Trim) 'Stone Weight2
                                    .Rows(.Rows.Count - 1).Cells("colStoneName2").Value = dtExcel.Rows(i)(18).ToString.Trim 'Stone Name2
                                    .Rows(.Rows.Count - 1).Cells("colStoneColor2").Value = dtExcel.Rows(i)(19).ToString.Trim 'Stone Color2
                                    .Rows(.Rows.Count - 1).Cells("colStonePrice2").Value = Val(dtExcel.Rows(i)(20).ToString.Trim) 'Stone Price2
                                    .Rows(.Rows.Count - 1).Cells("colStoneWeight3").Value = Val(dtExcel.Rows(i)(21).ToString.Trim) 'Stone Weight3
                                    .Rows(.Rows.Count - 1).Cells("colStoneName3").Value = dtExcel.Rows(i)(22).ToString.Trim 'Stone Name3
                                    .Rows(.Rows.Count - 1).Cells("colStoneColor3").Value = dtExcel.Rows(i)(23).ToString.Trim 'Stone Color3
                                    .Rows(.Rows.Count - 1).Cells("colStonePrice3").Value = Val(dtExcel.Rows(i)(24).ToString.Trim) 'Stone Price3
                                    .Rows(.Rows.Count - 1).Cells("colQty").Value = If(dtExcel.Rows(i)(25).ToString.Trim = "", 1, Val(dtExcel.Rows(i)(25).ToString.Trim)) 'Quantity
                                    .Rows(.Rows.Count - 1).Cells("colBarCode").Value = If(dtExcel.Rows(i)(26).ToString.Trim = "", Val(LastBarCode) + 1, dtExcel.Rows(i)(26).ToString.Trim) 'BarCode
                                    .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = 1 'Active Item
                                End With
                                LastBarCode = grid.Rows(grid.Rows.Count - 1).Cells("colBarCode").Value
                            End If
                        Next
                    End If
                Catch ex As Exception
                    If My.Computer.Keyboard.CtrlKeyDown Then
                        MsgBox(ex.Message)
                    Else
                        MsgBox("لا يمكن استيراد بيانات من ورقة إكسل المحددة" & vbCrLf & "تأكد من أن الورقة المحددة تحتوي على حقول بنفس الأسماء في الجدول الموجود بالأسفل", vbCritical, AppTitle)
                    End If

                End Try
            Case "DIAMOND"
                strField = "[Serial] , [Description] , [Diamond Clarity] , [Diamond Wt] , [Diamond Colour] , [UserName] , [Item Code] , [Gold Karat] , [Gold Wt] , " &
                   "[Label Price] , [Diamond Cut] , [Cost] , [StoneWeight1] , [StoneName1] , [StoneColor1] , [StoneWeight2] , [StoneName2] , [StoneColor2] , [StoneWeight3] , [StoneName3] , [StoneColor3] , " &
                   "[StoneWeight1 0Ct 1GM] , [StoneWeight2 0Ct 1GM] , [StoneWeight3 0Ct 1GM] , [Code] , [Total Weight] , [Quantity] , [NULL] , [BarCode] , [Date Added] , [Image] , [Active Item] , " &
                   "[CostToSeller] , [TaxExempt] , [Documents] , [Cut1] , [Clarity1] , [Cut2] , [Clarity2] , [Cut3] , [Clarity3] , [IsDiamond1] , [IsDiamond2] , [IsDiamond3]"
                cmdExcl = New OleDbDataAdapter("SELECT * FROM [" & cmbSheet.SelectedItem.ToString & "$]", connExcel)
                With grid
                    .Columns.Clear()
                    .Columns.Add("colDIMOND_ID", If(frmLogin.rbtnEn.Checked = True, "Serial", "م"))
                    .Columns.Add("colDIMO_dep", If(frmLogin.rbtnEn.Checked = True, "Item Name", "اسم الصنف"))
                    .Columns.Add("colDIM_na9awa", If(frmLogin.rbtnEn.Checked = True, "Clarity", "نقاوة"))
                    .Columns.Add("colDIMO_mezan", If(frmLogin.rbtnEn.Checked = True, "Diamond Wt", "و.ألماس"))
                    .Columns.Add("colext_coler", If(frmLogin.rbtnEn.Checked = True, "Diamond Color", "لون"))
                    .Columns.Add("colqult", If(frmLogin.rbtnEn.Checked = True, "User Name", "اسم المستخدم"))
                    .Columns.Add("colsarual", If(frmLogin.rbtnEn.Checked = True, "Item No", "رقم القطعة"))
                    .Columns.Add("colval_gold", If(frmLogin.rbtnEn.Checked = True, "Karat", "العيار"))
                    .Columns.Add("colGOLD_mezan", If(frmLogin.rbtnEn.Checked = True, "Gold Wt", "و.الذهب"))
                    .Columns.Add("coltest_1", If(frmLogin.rbtnEn.Checked = True, "Tag Price", "سعر البيع"))
                    .Columns.Add("coltest_11", If(frmLogin.rbtnEn.Checked = True, "Diamond Cut", "قصة الألماس"))
                    .Columns.Add("coltest_12", If(frmLogin.rbtnEn.Checked = True, "Cost", "سعر الشراء"))
                    .Columns.Add("coltest_13", If(frmLogin.rbtnEn.Checked = True, "CS Wt1", "و.حجر1"))
                    .Columns.Add("coltest_14", If(frmLogin.rbtnEn.Checked = True, "CS Type1", "نوع حجر1"))
                    .Columns.Add("coltest_15", If(frmLogin.rbtnEn.Checked = True, "CS Color1", "لون حجر1"))
                    .Columns.Add("coltest_16", If(frmLogin.rbtnEn.Checked = True, "CS Wt2", "و.حجر2"))
                    .Columns.Add("coltest_17", If(frmLogin.rbtnEn.Checked = True, "CS Type2", "نوع حجر2"))
                    .Columns.Add("coltest_18", If(frmLogin.rbtnEn.Checked = True, "CS Color2", "لون حجر2"))
                    .Columns.Add("coltest_19", If(frmLogin.rbtnEn.Checked = True, "CS Wt3", "و.حجر3"))
                    .Columns.Add("coltest_110", If(frmLogin.rbtnEn.Checked = True, "CS Type3", "نوع حجر3"))
                    .Columns.Add("coltest_111", If(frmLogin.rbtnEn.Checked = True, "CS Color3", "لون حجر3"))
                    .Columns.Add("coltest_112", If(frmLogin.rbtnEn.Checked = True, "ct Or gm 1", "قيراط أو جرام1"))
                    .Columns.Add("coltest_113", If(frmLogin.rbtnEn.Checked = True, "ct Or gm 2", "قيراط أو جرام2"))
                    .Columns.Add("coltest_114", If(frmLogin.rbtnEn.Checked = True, "ct Or gm 3", "قيراط أو جرام3"))
                    .Columns.Add("coltest_115", If(frmLogin.rbtnEn.Checked = True, "Code", "الرمز"))
                    .Columns.Add("coltest_116", If(frmLogin.rbtnEn.Checked = True, "Total Wt", "الوزن الكلي"))
                    .Columns.Add("coltest_117", If(frmLogin.rbtnEn.Checked = True, "Qty", "عدد القطع"))
                    .Columns.Add("coltest_118", If(frmLogin.rbtnEn.Checked = True, "118", "118"))
                    .Columns.Add("coltest_119", If(frmLogin.rbtnEn.Checked = True, "BarCode", "باركود"))
                    .Columns.Add("coldate_creted", If(frmLogin.rbtnEn.Checked = True, "Date Added", "تاريخ الإضافة"))
                    .Columns.Add("colITEM_IMGE", If(frmLogin.rbtnEn.Checked = True, "Image", "الصورة"))
                    .Columns.Add("colItem_Actv", If(frmLogin.rbtnEn.Checked = True, "Exist", "موجودة"))
                    .Columns.Add("colCostToSeller", If(frmLogin.rbtnEn.Checked = True, "CostToSeller", "التكلفة للبائع"))
                    .Columns.Add("colTaxExempt", If(frmLogin.rbtnEn.Checked = True, "TaxExempt", "معفي"))
                    .Columns.Add("colDocuments", If(frmLogin.rbtnEn.Checked = True, "Documents", "شهادات"))
                    .Columns.Add("colCut1", If(frmLogin.rbtnEn.Checked = True, "Cut1", "قصة1"))
                    .Columns.Add("colClarity1", If(frmLogin.rbtnEn.Checked = True, "Clarity1", "نقاوة1"))
                    .Columns.Add("colCut2", If(frmLogin.rbtnEn.Checked = True, "Cut2", "قصة2"))
                    .Columns.Add("colClarity2", If(frmLogin.rbtnEn.Checked = True, "Clarity2", "نقاوة2"))
                    .Columns.Add("colCut3", If(frmLogin.rbtnEn.Checked = True, "Cut3", "قصة3"))
                    .Columns.Add("colClarity3", If(frmLogin.rbtnEn.Checked = True, "Clarity3", "نقاوة3"))
                    .Columns.Add("colIsDiamond1", If(frmLogin.rbtnEn.Checked = True, "IsDiamond1", "ألماس1"))
                    .Columns.Add("colIsDiamond2", If(frmLogin.rbtnEn.Checked = True, "IsDiamond2", "ألماس2"))
                    .Columns.Add("colIsDiamond3", If(frmLogin.rbtnEn.Checked = True, "IsDiamond3", "ألماس3"))
                    .Columns.Add("Supplier", If(frmLogin.rbtnEn.Checked = True, "Supplier", "المورد"))
                    .Columns.Add("ItemNote", If(frmLogin.rbtnEn.Checked = True, "ItemNote", "الملاحظات"))
                    .Columns("colqult").Visible = False
                    .Columns("coltest_118").Visible = False
                    .Columns("colITEM_IMGE").Visible = False
                    .Columns("colItem_Actv").Visible = False
                    .Columns("colDocuments").Visible = False
                End With
                dtExcel.Reset()
                grid.Rows.Clear()
                Try
                    cmdExcl.Fill(dtExcel)
                    Dim row As DataRow = dtExcel.Rows(0)
                    For i As Integer = 0 To row.ItemArray.Length - 1
                        dtExcel.Columns(i).ColumnName = i 'row.Item(i).ToString()
                    Next
                    dtExcel.Rows.RemoveAt(0)
                    dtExcel.AcceptChanges()
                    If dtExcel.Rows.Count > 0 Then
                        For i As Integer = 0 To dtExcel.Rows.Count - 1
                            If dtExcel.Rows(i).Item(1).ToString <> "" Then
                                With grid
                                    .Rows.Add()
                                    .Rows(.Rows.Count - 1).Cells("colDIMOND_ID").Value = i + 1 'Serial
                                    .Rows(.Rows.Count - 1).Cells("colDIMO_dep").Value = dtExcel.Rows(i)(1).ToString.Trim 'ItemName
                                    .Rows(.Rows.Count - 1).Cells("colDIM_na9awa").Value = dtExcel.Rows(i)(2).ToString.Trim 'Clarity
                                    .Rows(.Rows.Count - 1).Cells("colDIMO_mezan").Value = Val(dtExcel.Rows(i)(3).ToString.Trim) 'D. Wt
                                    .Rows(.Rows.Count - 1).Cells("colext_coler").Value = dtExcel.Rows(i)(4).ToString.Trim 'D.Color
                                    .Rows(.Rows.Count - 1).Cells("colqult").Value = If(dtExcel.Rows(i)(5).ToString.Trim = "", UserName, dtExcel.Rows(i)(5).ToString.Trim) 'USER
                                    .Rows(.Rows.Count - 1).Cells("colsarual").Value = If(dtExcel.Rows(i)(6).ToString.Trim = "", "-", dtExcel.Rows(i)(6).ToString.Trim) 'SerialNo
                                    .Rows(.Rows.Count - 1).Cells("colval_gold").Value = dtExcel.Rows(i)(7).ToString.Trim 'Karat
                                    .Rows(.Rows.Count - 1).Cells("colGOLD_mezan").Value = Val(dtExcel.Rows(i)(8).ToString.Trim) 'G.Wt
                                    .Rows(.Rows.Count - 1).Cells("coltest_1").Value = Val(dtExcel.Rows(i)(9).ToString.Trim) 'Sell Price
                                    .Rows(.Rows.Count - 1).Cells("coltest_11").Value = dtExcel.Rows(i)(10).ToString.Trim 'D.Cut
                                    .Rows(.Rows.Count - 1).Cells("coltest_12").Value = Val(dtExcel.Rows(i)(11).ToString.Trim) 'Buy Price
                                    .Rows(.Rows.Count - 1).Cells("coltest_13").Value = Val(dtExcel.Rows(i)(12).ToString.Trim) 'StoneWeight1
                                    .Rows(.Rows.Count - 1).Cells("coltest_14").Value = dtExcel.Rows(i)(13).ToString.Trim 'StoneName1
                                    .Rows(.Rows.Count - 1).Cells("coltest_15").Value = dtExcel.Rows(i)(14).ToString.Trim 'StoneColor1
                                    .Rows(.Rows.Count - 1).Cells("coltest_16").Value = Val(dtExcel.Rows(i)(15).ToString.Trim) 'StoneWeight2
                                    .Rows(.Rows.Count - 1).Cells("coltest_17").Value = dtExcel.Rows(i)(16).ToString.Trim 'StoneName2
                                    .Rows(.Rows.Count - 1).Cells("coltest_18").Value = dtExcel.Rows(i)(17).ToString.Trim 'StoneColor2
                                    .Rows(.Rows.Count - 1).Cells("coltest_19").Value = Val(dtExcel.Rows(i)(18).ToString.Trim) 'StoneWeight3
                                    .Rows(.Rows.Count - 1).Cells("coltest_110").Value = dtExcel.Rows(i)(19).ToString.Trim 'StoneName3
                                    .Rows(.Rows.Count - 1).Cells("coltest_111").Value = dtExcel.Rows(i)(20).ToString.Trim 'StoneColor3
                                    .Rows(.Rows.Count - 1).Cells("coltest_112").Value = If(dtExcel.Rows(i)(21).ToString.Trim = "", "0", dtExcel.Rows(i)(21).ToString.Trim) 'StoneWeight1 Type
                                    .Rows(.Rows.Count - 1).Cells("coltest_113").Value = If(dtExcel.Rows(i)(22).ToString.Trim = "", "0", dtExcel.Rows(i)(22).ToString.Trim) 'StoneWeight2 Type
                                    .Rows(.Rows.Count - 1).Cells("coltest_114").Value = If(dtExcel.Rows(i)(23).ToString.Trim = "", "0", dtExcel.Rows(i)(23).ToString.Trim) 'StoneWeight3 Type
                                    .Rows(.Rows.Count - 1).Cells("coltest_115").Value = dtExcel.Rows(i)(24).ToString.Trim 'Code
                                    .Rows(.Rows.Count - 1).Cells("coltest_116").Value = Val(dtExcel.Rows(i)(25).ToString.Trim) 'Total Weight
                                    .Rows(.Rows.Count - 1).Cells("coltest_117").Value = If(Val(dtExcel.Rows(i)(26).ToString.Trim) = 0, "1", Val(dtExcel.Rows(i)(26).ToString.Trim)) 'Qty
                                    .Rows(.Rows.Count - 1).Cells("coltest_118").Value = Nothing 'Test_118
                                    .Rows(.Rows.Count - 1).Cells("coltest_119").Value = If(dtExcel.Rows(i)(28).ToString.Trim = "", Val(LastBarCode) + 1, dtExcel.Rows(i)(28).ToString.Trim) 'BarCode
                                    .Rows(.Rows.Count - 1).Cells("coldate_creted").Value = If(IsDate(dtExcel.Rows(i)(29).ToString), CDate(dtExcel.Rows(i)(29).ToString).ToShortDateString, Now.ToShortDateString) 'Date
                                    .Rows(.Rows.Count - 1).Cells("colITEM_IMGE").Value = Nothing 'Image
                                    .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = 1 'Active Item
                                    .Rows(.Rows.Count - 1).Cells("colCostToSeller").Value = If(dtExcel.Rows(i)(32).ToString.Trim = "", "0", Val(dtExcel.Rows(i)(11).ToString.Trim)) 'CostToSeller
                                    .Rows(.Rows.Count - 1).Cells("colTaxExempt").Value = If(dtExcel.Rows(i)(33).ToString.Trim = "", "0", dtExcel.Rows(i)(33).ToString.Trim) 'TaxExempt
                                    .Rows(.Rows.Count - 1).Cells("colDocuments").Value = Nothing 'Documents
                                    .Rows(.Rows.Count - 1).Cells("colCut1").Value = dtExcel.Rows(i)(35).ToString.Trim  'Cut1
                                    .Rows(.Rows.Count - 1).Cells("colClarity1").Value = dtExcel.Rows(i)(36).ToString.Trim  'Clarity1
                                    .Rows(.Rows.Count - 1).Cells("colCut2").Value = dtExcel.Rows(i)(37).ToString.Trim  'Cut2
                                    .Rows(.Rows.Count - 1).Cells("colClarity2").Value = dtExcel.Rows(i)(38).ToString.Trim  'Clarity2
                                    .Rows(.Rows.Count - 1).Cells("colCut3").Value = dtExcel.Rows(i)(39).ToString.Trim  'Cut3
                                    .Rows(.Rows.Count - 1).Cells("colClarity3").Value = dtExcel.Rows(i)(40).ToString.Trim  'Clarity3
                                    .Rows(.Rows.Count - 1).Cells("colIsDiamond1").Value = If(dtExcel.Rows(i)(41).ToString.Trim = "", "0", dtExcel.Rows(i)(41).ToString.Trim) 'IsDiamond1
                                    .Rows(.Rows.Count - 1).Cells("colIsDiamond2").Value = If(dtExcel.Rows(i)(42).ToString.Trim = "", "0", dtExcel.Rows(i)(42).ToString.Trim) 'IsDiamond1
                                    .Rows(.Rows.Count - 1).Cells("colIsDiamond3").Value = If(dtExcel.Rows(i)(43).ToString.Trim = "", "0", dtExcel.Rows(i)(43).ToString.Trim) 'IsDiamond1
                                    .Rows(.Rows.Count - 1).Cells("Supplier").Value = If(dtExcel.Rows(i)(44).ToString.Trim = "", "", dtExcel.Rows(i)(44).ToString.Trim)
                                    .Rows(.Rows.Count - 1).Cells("ItemNote").Value = If(dtExcel.Rows(i)(45).ToString.Trim = "", "", dtExcel.Rows(i)(45).ToString.Trim)
                                End With
                                LastBarCode = grid.Rows(grid.Rows.Count - 1).Cells("coltest_119").Value
                            End If
                        Next
                    End If
                Catch ex As Exception
                    If My.Computer.Keyboard.CtrlKeyDown Then
                        MsgBox(ex.Message)
                    Else
                        MsgBox("لا يمكن استيراد بيانات من ورقة إكسل المحددة" & vbCrLf & "تأكد من أن الورقة المحددة تحتوي على حقول بنفس الأسماء في الجدول الموجود بالأسفل", vbCritical, AppTitle)
                    End If

                End Try
        End Select
        If connExcel.State = ConnectionState.Open Then connExcel.Close()
    End Sub

    Private Sub cmbSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheet.SelectedIndexChanged
        GetData()
    End Sub
#End Region
#Region "Displaying"
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex = 1 Then Exit Sub
        If e.ColumnIndex = 8 Then Exit Sub
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            e.PaintBackground(e.CellBounds, True)
            TextRenderer.DrawText(e.Graphics,
                                  e.FormattedValue.ToString(),
                                  e.CellStyle.Font,
                                  e.CellBounds,
                                  e.CellStyle.ForeColor,
                                  TextFormatFlags.HorizontalCenter)
            e.Handled = True
        End If
    End Sub
    Private Sub btnAlign_Click(sender As Object, e As EventArgs) Handles btnAlign.Click
        Cursor = Cursors.WaitCursor
        grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Cursor = Cursors.Arrow
    End Sub
#End Region
#Region "Validate"
    Private Sub Grid_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellValidated
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 Then Exit Sub
        ValidateCellValue(e.RowIndex, e.ColumnIndex)

    End Sub
    Private Function ValidateCellValue(RowNo As Integer, ColumnNo As Integer) As Boolean
        Dim x As Boolean = False
        grid.Rows(RowNo).Cells(ColumnNo).ErrorText = ""
        Select Case ExcelImportType.ToUpper
            Case "GOLD"
                If IsDate(grid.Rows(RowNo).Cells("coldate_care").Value) = False Then
                    grid.Rows(RowNo).Cells("coldate_care").ErrorText = "يرجى إدخال تاريخ صحيح!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colFO_desp").Value) = False Then
                    grid.Rows(RowNo).Cells("colFO_desp").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colFO_gram").Value) = False Then
                    grid.Rows(RowNo).Cells("colFO_gram").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colFO_gramMade").Value) = False Then
                    grid.Rows(RowNo).Cells("colFO_gramMade").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colFO_extras").Value) = False Then
                    grid.Rows(RowNo).Cells("colFO_extras").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colFO_totalPrice").Value) = False Then
                    grid.Rows(RowNo).Cells("colFO_totalPrice").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colGram_valu").Value) = False Then
                    grid.Rows(RowNo).Cells("colGram_valu").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colStonePrice1").Value) = False Then
                    grid.Rows(RowNo).Cells("colStonePrice1").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colStoneWeight2").Value) = False Then
                    grid.Rows(RowNo).Cells("colStoneWeight2").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colStonePrice2").Value) = False Then
                    grid.Rows(RowNo).Cells("colStonePrice2").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colStoneWeight3").Value) = False Then
                    grid.Rows(RowNo).Cells("colStoneWeight3").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colStonePrice3").Value) = False Then
                    grid.Rows(RowNo).Cells("colStonePrice3").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
            Case "DIAMOND"
                If IsDate(grid.Rows(RowNo).Cells("coldate_creted").Value) = False Then
                    grid.Rows(RowNo).Cells("coldate_creted").ErrorText = "يرجى إدخال تاريخ صحيح!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colDIMO_mezan").Value) = False Then
                    grid.Rows(RowNo).Cells("colDIMO_mezan").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colval_gold").Value) = False Then
                    grid.Rows(RowNo).Cells("colval_gold").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("colGOLD_mezan").Value) = False Then
                    grid.Rows(RowNo).Cells("colGOLD_mezan").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("coltest_1").Value) = False Then
                    grid.Rows(RowNo).Cells("coltest_1").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
                If IsNumeric(grid.Rows(RowNo).Cells("coltest_12").Value) = False Then
                    grid.Rows(RowNo).Cells("coltest_12").ErrorText = "يرجى إدخال أرقام فقط!"
                    x = True
                End If
        End Select
        Return x
    End Function
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("ملف الإكسل يجب أن تتوفر فيه الشروط التالية:" & vbCrLf &
               "1-الملف بتنسيق إكسل 2007 أو ما بعده" & vbCrLf &
               "2-الملف يحتوي على صف رؤوس أعمدة بالأسماء المحددة فقط - تجنب الأخطاء الإملائية" & vbCrLf &
               "3-تأكد أن كل عمود تم تنسيق بياناته بنوع واحد فقط , مثل الأرقام فقط أو النصوص فقط أو التواريخ فقط" & vbCrLf &
               "4-يجب إدخال البيانات في الأعمدة نوع الصنف - والبيانات الفارغة سيتم إدخالها افتراضيًا بالقيمة صفر" & vbCrLf &
               "5-يفضل إدخال البيانات بالكامل" & vbCrLf &
               "سيتم نسخ قالب لملف فارغ على سطح المكتب",
               AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading Or MessageBoxOptions.RightAlign)
        If FileIO.FileSystem.FileExists(FileIO.SpecialDirectories.Desktop & "\Template.xlsx") = True Then
            MsgBox("لم يتم نسخ الملف لوجود ملف بنفس الاسم على سطح المكتب", vbExclamation, AppTitle)
        Else
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\Template.xlsx", FileIO.SpecialDirectories.Desktop & "\Template.xlsx", FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        End If
    End Sub
#End Region
#Region "Saving"
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Desktop & "\DuplicateBarcodes.txt")
        Catch ex As Exception
        End Try
        Dim ErrorFound, DataFound As Boolean
        For i As Integer = 0 To grid.Rows.Count - 1
            For j As Integer = 1 To 27
                If ValidateCellValue(i, j) = True Then
                    ErrorFound = True
                End If
            Next
        Next
        If ErrorFound = True Then
            MsgBox("راجع البيانات المدخلة و صححها", vbExclamation, AppTitle)
            Exit Sub
        End If
        Select Case ExcelImportType.ToUpper
            Case "GOLD"
                Dim dt1 As DataTable = GetRecordSet("SELECT [BarCode] FROM [Fo_min]")
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To grid.Rows.Count - 1
                        DataFound = False
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        For j As Integer = 0 To dt1.Rows.Count - 1
                            If grid.Rows(i).Cells("colBarCode").Value.ToString = dt1.Rows(j).Item("BarCode").ToString Then
                                DataFound = True
                                Exit For
                            End If
                        Next
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        If DataFound = True Then
                            MsgBox("الباركود رقم  " & grid.Rows(i).Cells("colBarCode").Value & " مكرر!", vbExclamation, AppTitle)
                            Exit Sub
                        End If
                    Next
                End If
                Try
                    For i As Integer = 0 To grid.Rows.Count - 1
                        GlCommand.CommandText = "INSERT INTO [FO_min] (" &
                                                "[userID] , " &
                                                "[FO_name]  , " &
                                                "[FO_desp]  , " &
                                                "[FO_price] , " &
                                                "[FO_GramPrice] , " &
                                                "[FO_gram] , " &
                                                "[FO_gramMade] ," &
                                                "[FO_made] ," &
                                                "[FO_extras] ," &
                                                "[FO_totalPrice] ," &
                                                "[Gram_valu] ," &
                                                "[ITEM_IMGE] ," &
                                                "[date_care] ," &
                                                "[FO_ItemNo] ," &
                                                "[StoneColor1] ," &
                                                "[StonePrice1] ," &
                                                "[StoneWeight2] ," &
                                                "[StoneName2] ," &
                                                "[StoneColor2] ," &
                                                "[StonePrice2] ," &
                                                "[StoneWeight3] ," &
                                                "[StoneName3] ," &
                                                "[StoneColor3] ," &
                                                "[StonePrice3] ," &
                                                "[Qty] ," &
                                                "[BarCode] ," &
                                                "[Item_Actv] " &
                                                ") VALUES" &
                                                "(" &
                                                "@userID ," &
                                                "@FO_name ," &
                                                "@FO_desp ," &
                                                "@FO_price ," &
                                                "@FO_GramPrice ," &
                                                "@FO_gram ," &
                                                "@FO_gramMade ," &
                                                "@FO_made ," &
                                                "@FO_extras ," &
                                                "@FO_totalPrice ," &
                                                "@Gram_valu ," &
                                                "@ITEM_IMGE ," &
                                                "@date_care ," &
                                                "@FO_ItemNo ," &
                                                "@StoneColor1 ," &
                                                "@StonePrice1 ," &
                                                "@StoneWeight2 ," &
                                                "@StoneName2 ," &
                                                "@StoneColor2 ," &
                                                "@StonePrice2 ," &
                                                "@StoneWeight3 ," &
                                                "@StoneName3 ," &
                                                "@StoneColor3 ," &
                                                "@StonePrice3 ," &
                                                "@Qty ," &
                                                "@BarCode ," &
                                                "@Item_Actv" &
                                                ")"

                        With GlCommand.Parameters
                            .Clear()
                            .AddWithValue("@userID", grid.Rows(i).Cells("coluserID").Value)
                            .AddWithValue("@FO_name", grid.Rows(i).Cells("colFO_name").Value)
                            .AddWithValue("@FO_desp", grid.Rows(i).Cells("colFO_desp").Value)
                            .AddWithValue("@FO_price", grid.Rows(i).Cells("colFO_price").Value)
                            .AddWithValue("@FO_GramPrice", grid.Rows(i).Cells("colFO_GramPrice").Value)
                            .AddWithValue("@FO_gram", grid.Rows(i).Cells("colFO_gram").Value)
                            .AddWithValue("@FO_gramMade", grid.Rows(i).Cells("colFO_gramMade").Value)
                            .AddWithValue("@FO_made", grid.Rows(i).Cells("colFO_made").Value)
                            .AddWithValue("@FO_extras", grid.Rows(i).Cells("colFO_extras").Value)
                            .AddWithValue("@FO_totalPrice", grid.Rows(i).Cells("colFO_totalPrice").Value)
                            .AddWithValue("@Gram_valu", grid.Rows(i).Cells("colGram_valu").Value)
                            .Add("@ITEM_IMGE", SqlDbType.Image).Value = DBNull.Value
                            .AddWithValue("@date_care", DateToSave(grid.Rows(i).Cells("coldate_care").Value))
                            .AddWithValue("@FO_ItemNo", grid.Rows(i).Cells("colFO_ItemNo").Value)
                            .AddWithValue("@StoneColor1", grid.Rows(i).Cells("colStoneColor1").Value)
                            .AddWithValue("@StonePrice1", grid.Rows(i).Cells("colStonePrice1").Value)
                            .AddWithValue("@StoneWeight2", grid.Rows(i).Cells("colStoneWeight2").Value)
                            .AddWithValue("@StoneName2", grid.Rows(i).Cells("colStoneName2").Value)
                            .AddWithValue("@StoneColor2", grid.Rows(i).Cells("colStoneColor2").Value)
                            .AddWithValue("@StonePrice2", grid.Rows(i).Cells("colStonePrice2").Value)
                            .AddWithValue("@StoneWeight3", grid.Rows(i).Cells("colStoneWeight3").Value)
                            .AddWithValue("@StoneName3", grid.Rows(i).Cells("colStoneName3").Value)
                            .AddWithValue("@StoneColor3", grid.Rows(i).Cells("colStoneColor3").Value)
                            .AddWithValue("@StonePrice3", grid.Rows(i).Cells("colStonePrice3").Value)
                            .AddWithValue("@Qty", grid.Rows(i).Cells("colQty").Value)
                            .AddWithValue("@BarCode", grid.Rows(i).Cells("colBarCode").Value)
                            .AddWithValue("@Item_Actv", grid.Rows(i).Cells("colItem_Actv").Value)
                        End With
                        GlCommand.ExecuteNonQuery()
                    Next
                    MsgBox("تم الحفظ.", vbInformation, AppTitle)
                    GoldAddItemDetails.LoadData()
                    Close()
                Catch ex As Exception
                    If My.Computer.Keyboard.CtrlKeyDown Then
                        MsgBox(ex.Message)
                    Else
                        MsgBox("لم يتم الحفظ , تأكد أن قاعدة البيانات غير مفتوحة", vbCritical, AppTitle)
                    End If
                End Try
            Case "DIAMOND"
                If ChkDuplicate.Checked = False Then
                    Dim dt1 As DataTable = GetRecordSet("SELECT [test_119] FROM [DIMON_detels]")
                    If dt1.Rows.Count > 0 Then
                        For i As Integer = 0 To grid.Rows.Count - 1
                            For j As Integer = 0 To dt1.Rows.Count - 1
                                If grid.Rows(i).Cells("coltest_119").Value.ToString = dt1.Rows(j).Item("test_119").ToString Then
                                    MsgBox("باركود مكرر" & vbCrLf & "Duplicate Barcodes..", , AppTitle)
                                    Exit Sub
                                End If
                            Next
                        Next
                    End If
                ElseIf ChkDuplicate.Checked = True Then
                    Dim dt1 As DataTable = GetRecordSet("SELECT [test_119] FROM [DIMON_detels]")
                    If dt1.Rows.Count > 0 Then
                        For i As Integer = 0 To grid.Rows.Count - 1
                            For j As Integer = 0 To dt1.Rows.Count - 1
                                If grid.Rows(i).Cells("coltest_119").Value.ToString = dt1.Rows(j).Item("test_119").ToString Then
                                    Try
                                        Dim Wr As New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Desktop & "\DuplicateBarcodes.txt", True)
                                        Wr.WriteLine(grid.Rows(i).Cells("coltest_119").Value)
                                        Wr.Close()
                                    Catch ex As Exception
                                    End Try
                                    GlCommand.CommandText = "DELETE FROM [DIMON_detels] WHERE test_119 ='" & grid.Rows(i).Cells("coltest_119").Value & "'"
                                    GlCommand.ExecuteNonQuery()
                                End If
                            Next
                        Next
                    End If
                End If
                Try
                    For i As Integer = 0 To grid.Rows.Count - 1
                        GlCommand.CommandText = "INSERT INTO [DIMON_detels] (" &
                                                "[DIMO_dep] , " &
                                                "[DIM_na9awa]  , " &
                                                "[DIMO_mezan] , " &
                                                "[ext_coler] , " &
                                                "[qult] , " &
                                                "[sarual] , " &
                                                "[val_gold] , " &
                                                "[GOLD_mezan] , " &
                                                "[test_1] , " &
                                                "[test_11] , " &
                                                "[test_12] , " &
                                                "[test_13] , " &
                                                "[test_14] , " &
                                                "[test_15] , " &
                                                "[test_16] , " &
                                                "[test_17] , " &
                                                "[test_18] , " &
                                                "[test_19] , " &
                                                "[test_110] , " &
                                                "[test_111] , " &
                                                "[test_112] , " &
                                                "[test_113] , " &
                                                "[test_114] , " &
                                                "[test_115] , " &
                                                "[test_116] , " &
                                                "[test_117] , " &
                                                "[test_118] , " &
                                                "[test_119] , " &
                                                "[date_creted] , " &
                                                "[ITEM_IMGE] , " &
                                                "[Item_Actv] , " &
                                                "[CostToSeller] , " &
                                                "[TaxExempt] , " &
                                                "[Documents] , " &
                                                "[Cut1] , " &
                                                "[Clarity1] , " &
                                                "[Cut2] , " &
                                                "[Clarity2] , " &
                                                "[Cut3] , " &
                                                "[Clarity3] , " &
                                                "[IsDiamond1] , " &
                                                "[IsDiamond2] , " &
                                                "[IsDiamond3] , " &
                                                "[Supplier] , " &
                                                "[ItemNote]  " &
                                                ") VALUES" &
                                                "(" &
                                                "@DIMO_dep , " &
                                                "@DIM_na9awa  , " &
                                                "@DIMO_mezan , " &
                                                "@ext_coler , " &
                                                "@qult , " &
                                                "@sarual , " &
                                                "@val_gold , " &
                                                "@GOLD_mezan , " &
                                                "@test_1 , " &
                                                "@test_11 , " &
                                                "@test_12 , " &
                                                "@test_13 , " &
                                                "@test_14 , " &
                                                "@test_15 , " &
                                                "@test_16 , " &
                                                "@test_17 , " &
                                                "@test_18 , " &
                                                "@test_19 , " &
                                                "@test_110 , " &
                                                "@test_111 , " &
                                                "@test_112 , " &
                                                "@test_113 , " &
                                                "@test_114 , " &
                                                "@test_115 , " &
                                                "@test_116 , " &
                                                "@test_117 , " &
                                                "@test_118 , " &
                                                "@test_119 , " &
                                                "@date_creted , " &
                                                "@ITEM_IMGE , " &
                                                "@Item_Actv , " &
                                                "@CostToSeller , " &
                                                "@TaxExempt , " &
                                                "@Documents , " &
                                                "@Cut1 , " &
                                                "@Clarity1 , " &
                                                "@Cut2 , " &
                                                "@Clarity2 , " &
                                                "@Cut3 , " &
                                                "@Clarity3 , " &
                                                "@IsDiamond1 , " &
                                                "@IsDiamond2 , " &
                                                "@IsDiamond3 , " &
                                                "@Supplier , " &
                                                "@ItemNote  " &
                                                ")"

                        With GlCommand.Parameters
                            .Clear()
                            .AddWithValue("@DIMO_dep", grid.Rows(i).Cells("colDIMO_dep").Value)
                            .AddWithValue("@DIM_na9awa", grid.Rows(i).Cells("colDIM_na9awa").Value)
                            .AddWithValue("@DIMO_mezan", Val(grid.Rows(i).Cells("colDIMO_mezan").Value))
                            .AddWithValue("@ext_coler", grid.Rows(i).Cells("colext_coler").Value)
                            .AddWithValue("@qult", grid.Rows(i).Cells("colqult").Value)
                            .AddWithValue("@sarual", grid.Rows(i).Cells("colsarual").Value)
                            .AddWithValue("@val_gold", Val(grid.Rows(i).Cells("colval_gold").Value))
                            .AddWithValue("@GOLD_mezan", Val(grid.Rows(i).Cells("colGOLD_mezan").Value))
                            .AddWithValue("@test_1", grid.Rows(i).Cells("coltest_1").Value)
                            .AddWithValue("@test_11", grid.Rows(i).Cells("coltest_11").Value)
                            .AddWithValue("@test_12", Val(grid.Rows(i).Cells("coltest_12").Value))
                            .AddWithValue("@test_13", Val(grid.Rows(i).Cells("coltest_13").Value))
                            .AddWithValue("@test_14", grid.Rows(i).Cells("coltest_14").Value)
                            .AddWithValue("@test_15", grid.Rows(i).Cells("coltest_15").Value)
                            .AddWithValue("@test_16", Val(grid.Rows(i).Cells("coltest_16").Value))
                            .AddWithValue("@test_17", grid.Rows(i).Cells("coltest_17").Value)
                            .AddWithValue("@test_18", grid.Rows(i).Cells("coltest_18").Value)
                            .AddWithValue("@test_19", Val(grid.Rows(i).Cells("coltest_19").Value))
                            .AddWithValue("@test_110", grid.Rows(i).Cells("coltest_110").Value)
                            .AddWithValue("@test_111", grid.Rows(i).Cells("coltest_111").Value)
                            .AddWithValue("@test_112", grid.Rows(i).Cells("coltest_112").Value)
                            .AddWithValue("@test_113", grid.Rows(i).Cells("coltest_113").Value)
                            .AddWithValue("@test_114", grid.Rows(i).Cells("coltest_114").Value)
                            .AddWithValue("@test_115", grid.Rows(i).Cells("coltest_115").Value)
                            .AddWithValue("@test_116", grid.Rows(i).Cells("coltest_116").Value)
                            .AddWithValue("@test_117", grid.Rows(i).Cells("coltest_117").Value)
                            .AddWithValue("@test_118", DBNull.Value)
                            .AddWithValue("@test_119", grid.Rows(i).Cells("coltest_119").Value)
                            .AddWithValue("@date_creted", DateToSave(grid.Rows(i).Cells("coldate_creted").Value))
                            .Add("@ITEM_IMGE", SqlDbType.Image).Value = DBNull.Value
                            .AddWithValue("@Item_Actv", grid.Rows(i).Cells("colItem_Actv").Value)
                            .AddWithValue("@CostToSeller", grid.Rows(i).Cells("colCostToSeller").Value)
                            .AddWithValue("@TaxExempt", grid.Rows(i).Cells("colTaxExempt").Value)
                            .Add("@Documents", SqlDbType.Image).Value = DBNull.Value
                            .AddWithValue("@Cut1", grid.Rows(i).Cells("colCut1").Value)
                            .AddWithValue("@Clarity1", grid.Rows(i).Cells("colClarity1").Value)
                            .AddWithValue("@Cut2", grid.Rows(i).Cells("colCut2").Value)
                            .AddWithValue("@Clarity2", grid.Rows(i).Cells("colClarity2").Value)
                            .AddWithValue("@Cut3", grid.Rows(i).Cells("colCut3").Value)
                            .AddWithValue("@Clarity3", grid.Rows(i).Cells("colClarity3").Value)
                            .AddWithValue("@IsDiamond1", grid.Rows(i).Cells("colIsDiamond1").Value)
                            .AddWithValue("@IsDiamond2", grid.Rows(i).Cells("colIsDiamond2").Value)
                            .AddWithValue("@IsDiamond3", grid.Rows(i).Cells("colIsDiamond3").Value)
                            .AddWithValue("@Supplier", grid.Rows(i).Cells("Supplier").Value)
                            .AddWithValue("@ItemNote", grid.Rows(i).Cells("ItemNote").Value)
                        End With
                        GlCommand.ExecuteNonQuery()
                    Next
                    MsgBox("تم حفظ البانات بنجاح" & vbCrLf & "Data has been saved successfully", , AppTitle)
                    DiamondAddItemDetails.grid.Rows.Clear()
                    DiamondAddItemDetails.LoadData()
                    Close()
                Catch ex As Exception
                    If My.Computer.Keyboard.CtrlKeyDown Then
                        MsgBox(ex.Message)
                    Else
                        MsgBox("لم يتم الحفظ , تأكد أن قاعدة البيانات غير مفتوحة", vbCritical, AppTitle)
                    End If
                End Try
        End Select
    End Sub
#End Region
#Region "Finalize"
    Private Sub frmImportData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
#End Region
End Class