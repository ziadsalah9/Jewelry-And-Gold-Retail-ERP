
Imports System.ServiceProcess
Imports PACICardLibrary
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Imports DT_restrant.DT_restrantDataSetTableAdapters

Public Class GoldAddItemDetails
    Dim ItemName As String
    Dim ProcessingCost As String
    Dim CostPerGram As String
    Dim Karat As String
    Dim Country As String
    Dim StoneWeight As String
    Dim Stone1 As String
    Dim Supplier As String
    Dim Code As String
    Dim BarCodeUpdate As String
    Dim DateNaw As Date = Format(Date.Now, "yyyy-MM-dd")
    Dim ItemRep As Integer = 1
    Public EditControl As Boolean = False
    Public ItemLod As String

#Region "Goled"

    Public Sub GetGoldItemName()
        Dim DtGoldItemName As DataTable = GetRecordSet("SELECT FO_name FROM FO_min WHERE (Item_Actv = 1) GROUP BY FO_name")
        If DtGoldItemName.Rows.Count > 0 Then
            txtItemName.DataSource = DtGoldItemName
            txtItemName.DisplayMember = "FO_name"
        End If
        txtItemName.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="FO_name", ComboBoxName:=txtItemName)
    End Sub

    Public Sub GoldCaret999()
        Dim ComBx999 As DataTable = GetRecordSet("SELECT FractionValues FROM Gram_val GROUP BY FractionValues ORDER BY FractionValues DESC")
        If ComBx999.Rows.Count > 0 Then
            ComBxGoCaret999.DataSource = ComBx999
            ComBxGoCaret999.DisplayMember = "FractionValues"
        End If
    End Sub
    Public Sub GoldCaret()
        Dim GoldCaretDt As DataTable = GetRecordSet("SELECT Gram_valu FROM Gram_val  GROUP BY Gram_valu")
        If GoldCaretDt.Rows.Count > 0 Then
            cmbKarat.DataSource = GoldCaretDt
            cmbKarat.DisplayMember = "Gram_valu"
            cmbKarat.ValueMember = "Gram_valu"
        End If
    End Sub
    Private Sub AddItemData()
        If cmbKarat.SelectedIndex = -1 Then
            MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
            cmbKarat.DroppedDown = True
            Exit Sub
        End If
        If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
            MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
            txtItemName.Focus()
            Exit Sub
        End If

        If txtMetalWeight.Text.Trim = "" Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
            txtMetalWeight.Focus()
            Exit Sub
        End If

        If txtMakeCharge.Text.Trim = "" Then
            MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
            txtMakeCharge.Focus()
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then
            MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
            txtCostPerGram.Focus()
            Exit Sub
        End If

        If cmbCountry.SelectedIndex = -1 Then
            MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
            cmbCountry.DroppedDown = True
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
        If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
        If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
        If txtQty.Text.Trim = "" Then txtQty.Text = "1"
        Dim Barcood As String
        'باركود يدوي
        Dim dt1 As DataTable = GetRecordSet("SELECT [BarCode] FROM [FO_min] WHERE [BarCode] = N'" & txtBarCode.Text & "'")
        If dt1.Rows.Count > 0 Then
            MsgBox("الباركود المدخل مكرر!... أدخل باركود جديد أو اتركه خاليا ليتم إدخال باركود آلي" & vbCrLf & "BarCode is Duplicated!.. Enter a New BarCode Or Leave It Empty to Make It Automatic", , AppTitle)
            txtBarCode.SelectAll()
            txtBarCode.Focus()
            Exit Sub
        End If
        'Try
        ''''''''''باركود فريد
        Dim GetNewBarcood As DataTable = GetRecordSet("SELECT ID +1 AS GoldID FROM FO_min WHERE ID=(SELECT max(ID) FROM FO_min)")
        If GetNewBarcood.Rows.Count > 0 Then
            Barcood = (txtBarcodTag.Text & GetNewBarcood.Rows(0)(0).ToString)
        Else
            Barcood = txtBarcodTag.Text & "100"
        End If
        '>>>>>>>
        GlCommand.CommandText = "INSERT INTO [FO_min]" &
           " ([userID]" &
           ",[FO_name]" &
           ",[FO_desp]" &
           ",[FO_price]" &
           ",[FO_GramPrice]" &
           ",[FO_gram]" &
           ",[FO_gramMade]" &
           ",[FO_made]" &
           ",[FO_extras]" &
           ",[FO_totalPrice]" &
           ",[Gram_valu]" &
           ",[ITEM_IMGE]" &
           ",[date_care]" &
           ",[FO_ItemNo]" &
           ",[Item_Actv]" &
           ",[StoneColor1]" &
           ",[StonePrice1]" &
           ",[StoneWeight2]" &
           ",[StoneName2]" &
           ",[StoneColor2]" &
           ",[StonePrice2]" &
           ",[StoneWeight3]" &
           ",[StoneName3]" &
           ",[StoneColor3]" &
           ",[StonePrice3]" &
           ",[Qty]" &
           ",[BarCode]" &
           ",[LastEditDate]" &
           ",[ItemNote]" &
           ",[GoldCaret999]" &
           ",[GoldWeight999]" &
           ",[PurInvNumber]" &
           ",[MultiItem])" &
           "VALUES" &
           "(@userID" &
           ",@FO_name" &
           ",@FO_desp" &
           ",@FO_price" &
           ",@FO_GramPrice" &
           ",@FO_gram" &
           ",@FO_gramMade" &
           ",@FO_made" &
           ",@FO_extras" &
           ",@FO_totalPrice" &
           ",@Gram_valu" &
           ",@ITEM_IMGE" &
           ",@date_care" &
           ",@FO_ItemNo" &
           ",@Item_Actv" &
           ",@StoneColor1" &
           ",@StonePrice1" &
           ",@StoneWeight2" &
           ",@StoneName2" &
           ",@StoneColor2" &
           ",@StonePrice2" &
           ",@StoneWeight3" &
           ",@StoneName3" &
           ",@StoneColor3" &
           ",@StonePrice3" &
           ",@Qty" &
           ",@BarCode" &
           ",@LastEditDate" &
           ",@ItemNote" &
           ",@GoldCaret999" &
           ",@GoldWeight999" &
           ",@PurInvNumber" &
           ",@MultiItem)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
            .AddWithValue("@FO_name", txtItemName.Text.Trim)
            .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
            .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
            .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
            .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
            .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
            .AddWithValue("@FO_made", cmbCountry.Text.Trim)
            .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
            .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
            .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
            .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
            .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
            .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
            .AddWithValue("@Item_Actv", "1")
            .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
            .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
            .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
            .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
            .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
            .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
            .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
            .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
            .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
            .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
            .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
            .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text))
            .AddWithValue("@LastEditDate", Date.UtcNow)
            .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
            .AddWithValue("@GoldCaret999", If(IsDBNull(ComBxGoCaret999.Text.Trim) Or ComBxGoCaret999.Text.Trim = "", "999", ComBxGoCaret999.Text.Trim))
            .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
            .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
            .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
        End With
        GlCommand.ExecuteNonQuery()
        Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
        With (UpdateRows)
            If (IsDBNull(txtBarCode.Text) Or (txtBarCode.Text.Trim = "")) Then txtBarCode.Text = Barcood
            .Cells("colBarCode").Value = Barcood
            .Cells("colFO_name").Value = txtItemName.Text.Trim
            .Cells("colFO_desp").Value = txtCostPerGram.Text.Trim
            .Cells("colFO_price").Value = cmbStoneName1.Text.Trim
            .Cells("colFO_GramPrice").Value = cmbSupplier.Text.Trim
            .Cells("colFO_gram").Value = txtMetalWeight.Text.Trim
            .Cells("colFO_gramMade").Value = txtMakeCharge.Text.Trim
            .Cells("colFO_made").Value = cmbCountry.Text.Trim
            .Cells("colFO_extras").Value = txtStoneWeight1.Text.Trim
            .Cells("colFO_totalPrice").Value = txtCostPerItem.Text.Trim
            .Cells("colGram_valu").Value = cmbKarat.Text.Trim
            .Cells("coldate_care").Value = DateToSave(DateDiamItem.Value)
            .Cells("colFO_ItemNo").Value = txtCode.Text.Trim
            .Cells("colStoneColor1").Value = txtStoneColor1.Text.Trim
            .Cells("colStonePrice1").Value = txtStonePrice1.Text.Trim
            .Cells("colStoneWeight2").Value = txtStoneWeight2.Text.Trim
            .Cells("colStoneName2").Value = cmbStoneName2.Text.Trim
            .Cells("colStoneColor2").Value = txtStoneColor2.Text.Trim
            .Cells("colStonePrice2").Value = txtStonePrice2.Text.Trim
            .Cells("colStoneWeight3").Value = txtStoneWeight3.Text.Trim
            .Cells("colStoneName3").Value = cmbStoneName3.Text.Trim
            .Cells("colStoneColor3").Value = txtStoneColor3.Text.Trim
            .Cells("colStonePrice3").Value = txtStonePrice3.Text.Trim
            .Cells("colQty").Value = txtQty.Text.Trim
            .Cells("colBarCode").Value = (txtBarCode.Text.Trim)
            .Cells("colLastEditDate").Value = Format(DateDiamItem.Value, "dd/MM/yyyy hh:mm:ss")
            .Cells("colItemNote").Value = txtItemNote.Text.Trim
            .Cells("colGoldCart999").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim) Or ComBxGoCaret999.Text.Trim = "", "999", ComBxGoCaret999.Text.Trim)
            .Cells("colGoldWeight999").Value = TXTGoCaret999.Text.Trim
            .Cells("colPurInvNumber").Value = CmbPurInvNumber.Text.Trim
            .Cells("colcbklblMultiItem").Value = cbklblMultiItem.Checked
        End With
        btnNew.Enabled = True
        btnSave.Enabled = False
        MsgBox("تم اضافة الاصناف بنجاح" & vbCrLf & "Items added successfully", , AppTitle)
        gbItemData.Enabled = False
    End Sub
    Private Sub EditData()
        If cmbKarat.SelectedIndex = -1 Then
            MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
            cmbKarat.DroppedDown = True
            Exit Sub
        End If
        If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
            MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
            txtItemName.Focus()
            Exit Sub
        End If

        If txtMetalWeight.Text.Trim = "" Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
            txtMetalWeight.Focus()
            Exit Sub
        End If

        If txtMakeCharge.Text.Trim = "" Then
            MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
            txtMakeCharge.Focus()
            Exit Sub
        End If

        If txtCostPerGram.Text.Trim = "" Then
            MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
            txtCostPerGram.Focus()
            Exit Sub
        End If

        If cmbCountry.SelectedIndex = -1 Then
            MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
            cmbCountry.DroppedDown = True
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
        If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
        If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
        If txtQty.Text.Trim = "" Then txtQty.Text = "1"
        Try
            Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
            UpdateRows.Cells("coluserID").Value = CobUser.Text.Trim
            UpdateRows.Cells("colBarCode").Value = txtBarCode.Text.Trim
            UpdateRows.Cells("colFO_name").Value = txtItemName.Text.Trim
            UpdateRows.Cells("colFO_desp").Value = txtCostPerGram.Text.Trim
            UpdateRows.Cells("colFO_price").Value = cmbStoneName1.Text.Trim
            UpdateRows.Cells("colFO_GramPrice").Value = cmbSupplier.Text.Trim
            UpdateRows.Cells("colFO_gram").Value = txtMetalWeight.Text.Trim
            UpdateRows.Cells("colFO_gramMade").Value = txtMakeCharge.Text.Trim
            UpdateRows.Cells("colFO_made").Value = cmbCountry.Text.Trim
            UpdateRows.Cells("colFO_extras").Value = txtStoneWeight1.Text.Trim
            UpdateRows.Cells("colFO_totalPrice").Value = txtCostPerItem.Text.Trim
            UpdateRows.Cells("colGram_valu").Value = cmbKarat.Text.Trim
            UpdateRows.Cells("colFO_ItemNo").Value = txtCode.Text.Trim
            UpdateRows.Cells("colStoneColor1").Value = txtStoneColor1.Text.Trim
            UpdateRows.Cells("colStonePrice1").Value = txtStonePrice1.Text.Trim
            UpdateRows.Cells("colStoneWeight2").Value = txtStoneWeight2.Text.Trim
            UpdateRows.Cells("colStoneName2").Value = cmbStoneName2.Text.Trim
            UpdateRows.Cells("colStoneColor2").Value = txtStoneColor2.Text.Trim
            UpdateRows.Cells("colStonePrice2").Value = txtStonePrice2.Text.Trim
            UpdateRows.Cells("colStoneWeight3").Value = txtStoneWeight3.Text.Trim
            UpdateRows.Cells("colStoneName3").Value = cmbStoneName3.Text.Trim
            UpdateRows.Cells("colStoneColor3").Value = txtStoneColor3.Text.Trim
            UpdateRows.Cells("colStonePrice3").Value = txtStonePrice3.Text.Trim
            UpdateRows.Cells("colQty").Value = txtQty.Text.Trim
            UpdateRows.Cells("colLastEditDate").Value = Format(DateDiamItem.Value, "dd/MM/yyyy hh:mm:ss")
            UpdateRows.Cells("colItemNote").Value = txtItemNote.Text.Trim
            UpdateRows.Cells("colGoldCart999").Value = ComBxGoCaret999.Text.Trim
            UpdateRows.Cells("colGoldWeight999").Value = TXTGoCaret999.Text.Trim
            UpdateRows.Cells("colPurInvNumber").Value = CmbPurInvNumber.Text.Trim
            UpdateRows.Cells("colcbklblMultiItem").Value = cbklblMultiItem.Checked
            GlCommand.CommandText = "UPDATE [FO_min] SET [userID] = @userID" & vbCrLf &
                                                     ",[FO_name] = @FO_name" & vbCrLf &
                                                     ",[FO_desp] = @FO_desp" & vbCrLf &
                                                     ",[FO_price] = @FO_price" & vbCrLf &
                                                     ",[FO_GramPrice] = @FO_GramPrice" & vbCrLf &
                                                     ",[FO_gram] = @FO_gram" & vbCrLf &
                                                     ",[FO_gramMade] = @FO_gramMade" & vbCrLf &
                                                     ",[FO_made] = @FO_made" & vbCrLf &
                                                     ",[FO_extras] = @FO_extras" & vbCrLf &
                                                     ",[FO_totalPrice] = @FO_totalPrice" & vbCrLf &
                                                     ",[Gram_valu] = @Gram_valu" & vbCrLf &
                                                     ",[ITEM_IMGE] = @ITEM_IMGE" & vbCrLf &
                                                     ",[FO_ItemNo] = @FO_ItemNo" & vbCrLf &
                                                     ",[Item_Actv] = @Item_Actv" & vbCrLf &
                                                     ",[StoneColor1] = @StoneColor1" & vbCrLf &
                                                     ",[StonePrice1] = @StonePrice1" & vbCrLf &
                                                     ",[StoneWeight2] = @StoneWeight2" & vbCrLf &
                                                     ",[StoneName2] = @StoneName2" & vbCrLf &
                                                     ",[StoneColor2] = @StoneColor2" & vbCrLf &
                                                     ",[StonePrice2] = @StonePrice2" & vbCrLf &
                                                     ",[StoneWeight3] = @StoneWeight3" & vbCrLf &
                                                     ",[StoneName3] = @StoneName3" & vbCrLf &
                                                     ",[StoneColor3] = @StoneColor3" & vbCrLf &
                                                     ",[StonePrice3] = @StonePrice3" & vbCrLf &
                                                     ",[Qty] = @Qty" & vbCrLf &
                                                     ",[BarCode] = @BarCode" & vbCrLf &
                                                     ",[LastEditDate] = @LastEditDate" & vbCrLf &
                                                     ",[ItemNote] = @ItemNote" & vbCrLf &
                                                     ",[GoldCaret999] = @GoldCaret999" & vbCrLf &
                                                     ",[GoldWeight999] = @GoldWeight999" & vbCrLf &
                                                     ",[PurInvNumber] = @PurInvNumber" & vbCrLf &
                                                     ",[MultiItem] = @MultiItem" & vbCrLf &
                                                     "WHERE [ID] ='" & Grid.SelectedRows(0).Cells("colID").Value & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
                .AddWithValue("@FO_name", txtItemName.Text.Trim)
                .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
                .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
                .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
                .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
                .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
                .AddWithValue("@FO_made", cmbCountry.Text.Trim)
                .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
                .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
                .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
                .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
                .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
                .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
                .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
                .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
                .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
                .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
                .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
                .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
                .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
                .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
                .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
                .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
                .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", txtBarcodTag.Text & txtBarCode.Text.Trim, txtBarCode.Text.Trim))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
                .AddWithValue("@GoldCaret999", ComBxGoCaret999.Text.Trim)
                .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
                .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
                .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
            End With
            GlCommand.ExecuteNonQuery()
            btnNew.Enabled = True
            btnSave.Enabled = False
            MsgBox("تم الحفظ التعديل بنجاح" & vbCrLf & "Save Edit successfully", , AppTitle)
            Grid.RefreshEdit()
            Grid.EndEdit()
            NewData()
            EditControl = False
            gbItemData.Enabled = False
            btnEdit.Enabled = True
        Catch ex As Exception
            RecordRrrors(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub GoldWeight()
        If GoldOrSilver = True Then
            Dim GoledCart As Decimal = Val(cmbKarat.Text) / 24 * 1000
            Try
                TXTGoCaret999.Text = If(IsDBNull(txtMetalWeight.Text), 0, Val(txtMetalWeight.Text) * Val(GoledCart / ComBxGoCaret999.Text).ToString("#,###,###,###.000"))
            Catch ex As Exception
                'Return
            End Try
        ElseIf GoldOrSilver = False Then
            TXTGoCaret999.Text = 0
            TXTGoCaret999.Enabled = False
        End If

    End Sub
    Private Sub AddItemReb()
        Do Until ItemRep = (NumItemRep.Value) + 1
            txtBarCode.Clear()
            If cmbKarat.SelectedIndex = -1 Then
                MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
                cmbKarat.DroppedDown = True
                Exit Sub
            End If
            If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
                MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
                Exit Sub
            End If
            If txtItemName.Text.Trim = "" Then
                MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
                txtItemName.Focus()
                Exit Sub
            End If

            If txtMetalWeight.Text.Trim = "" Then
                MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
                txtMetalWeight.Focus()
                Exit Sub
            End If

            If txtMakeCharge.Text.Trim = "" Then
                MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
                txtMakeCharge.Focus()
                Exit Sub
            End If

            If txtCostPerGram.Text.Trim = "" Then
                MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
                txtCostPerGram.Focus()
                Exit Sub
            End If

            If cmbCountry.SelectedIndex = -1 Then
                MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
                cmbCountry.DroppedDown = True
                Exit Sub
            End If
            If (IsDBNull(TXTGoCaret999.Text) Or TXTGoCaret999.Text.Trim = "") Then
                MsgBox("ادخل وزن الذهب الصافي" & vbCrLf & "Enter the weight of pure gold", , AppTitle)
                TXTGoCaret999.Focus()
            End If
            If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
            If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
            If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
            If txtQty.Text.Trim = "" Then txtQty.Text = "1"

            Dim dt1 As DataTable = GetRecordSet("SELECT [BarCode] FROM [FO_min] WHERE [BarCode] = N'" & txtBarCode.Text & "'")
            If dt1.Rows.Count > 0 Then
                MsgBox("الباركود المدخل مكرر!... أدخل باركود جديد أو اتركه خاليا ليتم إدخال باركود آلي" & vbCrLf & "BarCode is Duplicated!.. Enter a New BarCode Or Leave It Empty to Make It Automatic", , AppTitle)
                txtBarCode.SelectAll()
                txtBarCode.Focus()
                Exit Sub
            End If
            Dim Barcood As String
            Dim GetNewBarcood As DataTable = GetRecordSet("SELECT [ID] +1 AS ID FROM FO_min WHERE [ID]=(SELECT max([ID]) FROM FO_min)")
            If GetNewBarcood.Rows.Count > 0 Then
                Barcood = (txtBarcodTag.Text & GetNewBarcood.Rows(0)(0).ToString)
            Else
                Barcood = (txtBarcodTag.Text & "100")
            End If
            GlCommand.CommandText = "INSERT INTO [FO_min]" &
               " ([userID]" &
               ",[FO_name]" &
               ",[FO_desp]" &
               ",[FO_price]" &
               ",[FO_GramPrice]" &
               ",[FO_gram]" &
               ",[FO_gramMade]" &
               ",[FO_made]" &
               ",[FO_extras]" &
               ",[FO_totalPrice]" &
               ",[Gram_valu]" &
               ",[ITEM_IMGE]" &
               ",[date_care]" &
               ",[FO_ItemNo]" &
               ",[Item_Actv]" &
               ",[StoneColor1]" &
               ",[StonePrice1]" &
               ",[StoneWeight2]" &
               ",[StoneName2]" &
               ",[StoneColor2]" &
               ",[StonePrice2]" &
               ",[StoneWeight3]" &
               ",[StoneName3]" &
               ",[StoneColor3]" &
               ",[StonePrice3]" &
               ",[Qty]" &
               ",[BarCode]" &
               ",[LastEditDate]" &
               ",[ItemNote]" &
               ",[GoldCaret999]" &
               ",[GoldWeight999]" &
               ",[PurInvNumber]" &
               ",[MultiItem])" &
               "VALUES" &
               "(@userID" &
               ",@FO_name" &
               ",@FO_desp" &
               ",@FO_price" &
               ",@FO_GramPrice" &
               ",@FO_gram" &
               ",@FO_gramMade" &
               ",@FO_made" &
               ",@FO_extras" &
               ",@FO_totalPrice" &
               ",@Gram_valu" &
               ",@ITEM_IMGE" &
               ",@date_care" &
               ",@FO_ItemNo" &
               ",@Item_Actv" &
               ",@StoneColor1" &
               ",@StonePrice1" &
               ",@StoneWeight2" &
               ",@StoneName2" &
               ",@StoneColor2" &
               ",@StonePrice2" &
               ",@StoneWeight3" &
               ",@StoneName3" &
               ",@StoneColor3" &
               ",@StonePrice3" &
               ",@Qty" &
               ",@BarCode" &
               ",@LastEditDate" &
               ",@ItemNote" &
               ",@GoldCaret999" &
               ",@GoldWeight999" &
               ",@PurInvNumber" &
               ",@MultiItem)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
                .AddWithValue("@FO_name", txtItemName.Text.Trim)
                .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
                .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
                .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
                .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
                .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
                .AddWithValue("@FO_made", cmbCountry.Text.Trim)
                .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
                .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
                .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
                .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
                .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
                .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
                .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
                .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
                .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
                .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
                .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
                .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
                .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
                .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
                .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
                .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
                .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
                .AddWithValue("@GoldCaret999", If(IsDBNull(ComBxGoCaret999.Text.Trim) Or ComBxGoCaret999.Text.Trim = "", "999", ComBxGoCaret999.Text.Trim))
                .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
                .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
                .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
            End With
            GlCommand.ExecuteNonQuery()
            ItemRep += 1
        Loop
        btnNew.Enabled = True
        btnSave.Enabled = False
        CheItemRepeat.Checked = False
        MsgBox("تم اضافة الاصناف بنجاح" & vbCrLf & "Items added successfully", , AppTitle)
        gbItemData.Enabled = False
        Me.Close()
    End Sub


    Private Sub GetImg()
        If GoldOrSilver = True Then
            pbImage.Image = Nothing
            Dim GetImge As DataTable = GetRecordSet("SELECT [ID],[ITEM_IMGE],[BarCode] FROM [FO_min] where [BarCode]=N'" & txtBarCode.Text.Trim & "'")
            If GetImge.Rows.Count > 0 Then
                If Not IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                    pbImage.Image = ByteToImage(GetImge.Rows(0)("ITEM_IMGE"))
                ElseIf IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                End If
            End If
        ElseIf GoldOrSilver = False Then
            pbImage.Image = Nothing
            Dim GetImge As DataTable = GetRecordSet("SELECT [ID],[ITEM_IMGE],[BarCode] FROM [SilverItem] where [BarCode]=N'" & txtBarCode.Text.Trim & "'")
            If GetImge.Rows.Count > 0 Then
                If Not IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                    pbImage.Image = ByteToImage(GetImge.Rows(0)("ITEM_IMGE"))
                ElseIf IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                End If
            End If
        End If
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Grid.CurrentRow.Cells(Grid.CurrentCellAddress.X + 1).Selected = True
        'End If
        If e.KeyCode = Keys.Enter Then
            Grid.CurrentRow.Cells(Grid.CurrentCellAddress.X + 1).Selected = True
        End If

    End Sub
    Private Sub gridSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Grid.SelectionChanged
        GridSelectionChanged()
    End Sub

    Public Sub LoadData()
        CleaningFields()
        Dim GetGoldData As DataTable = GetRecordSet(ItemLod)
        If GetGoldData.Rows.Count > 0 Then
            For i As Integer = 0 To GetGoldData.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colID").Value = (GetGoldData.Rows(i)("ID").ToString)
                    .Rows(i).Cells("coluserID").Value = (GetGoldData.Rows(i)("userID").ToString)
                    .Rows(i).Cells("colFO_name").Value = (GetGoldData.Rows(i)("FO_name").ToString)
                    .Rows(i).Cells("colFO_desp").Value = (GetGoldData.Rows(i)("FO_desp").ToString)
                    .Rows(i).Cells("colFO_price").Value = (GetGoldData.Rows(i)("FO_price").ToString)
                    .Rows(i).Cells("colFO_GramPrice").Value = (GetGoldData.Rows(i)("FO_GramPrice").ToString)
                    .Rows(i).Cells("colFO_gram").Value = (GetGoldData.Rows(i)("FO_gram").ToString)
                    .Rows(i).Cells("colFO_gramMade").Value = (GetGoldData.Rows(i)("FO_gramMade").ToString)
                    .Rows(i).Cells("colFO_made").Value = (GetGoldData.Rows(i)("FO_made").ToString)
                    .Rows(i).Cells("colFO_extras").Value = (GetGoldData.Rows(i)("FO_extras").ToString)
                    .Rows(i).Cells("colFO_totalPrice").Value = (GetGoldData.Rows(i)("FO_totalPrice").ToString)
                    .Rows(i).Cells("colGram_valu").Value = (GetGoldData.Rows(i)("Gram_valu").ToString)
                    .Rows(i).Cells("coldate_care").Value = (DateToView(GetGoldData.Rows(i)("date_care").ToString))
                    .Rows(i).Cells("colFO_ItemNo").Value = (GetGoldData.Rows(i)("FO_ItemNo").ToString)
                    .Rows(i).Cells("colStoneColor1").Value = (GetGoldData.Rows(i)("StoneColor1").ToString)
                    .Rows(i).Cells("colStonePrice1").Value = (GetGoldData.Rows(i)("StonePrice1").ToString)
                    .Rows(i).Cells("colStoneWeight2").Value = (GetGoldData.Rows(i)("StoneWeight2").ToString)
                    .Rows(i).Cells("colStoneName2").Value = (GetGoldData.Rows(i)("StoneName2").ToString)
                    .Rows(i).Cells("colStoneColor2").Value = (GetGoldData.Rows(i)("StoneColor2").ToString)
                    .Rows(i).Cells("colStonePrice2").Value = (GetGoldData.Rows(i)("StonePrice2").ToString)
                    .Rows(i).Cells("colStoneName3").Value = (GetGoldData.Rows(i)("StoneName3").ToString)
                    .Rows(i).Cells("colStoneWeight3").Value = (GetGoldData.Rows(i)("StoneWeight3").ToString)
                    .Rows(i).Cells("colStoneColor3").Value = (GetGoldData.Rows(i)("StoneColor3").ToString)
                    .Rows(i).Cells("colStonePrice3").Value = (GetGoldData.Rows(i)("StonePrice3").ToString)
                    .Rows(i).Cells("colQty").Value = (GetGoldData.Rows(i)("Qty").ToString)
                    .Rows(i).Cells("colBarCode").Value = (GetGoldData.Rows(i)("BarCode").ToString)
                    .Rows(i).Cells("colItem_Actv").Value = (GetGoldData.Rows(i)("Item_Actv").ToString)
                    .Rows(i).Cells("colGoldCart999").Value = (GetGoldData.Rows(i)("GoldCaret999").ToString)
                    .Rows(i).Cells("colGoldWeight999").Value = (GetGoldData.Rows(i)("GoldWeight999").ToString)
                    .Rows(i).Cells("colLastEditDate").Value = (GetGoldData.Rows(i)("LastEditDate").ToString)
                    .Rows(i).Cells("colItemNote").Value = (GetGoldData.Rows(i)("ItemNote").ToString)
                    .Rows(i).Cells("colPurInvNumber").Value = (GetGoldData.Rows(i)("PurInvNumber").ToString)
                    .Rows(i).Cells("colcbklblMultiItem").Value = (GetGoldData.Rows(i)("MultiItem"))
                End With
            Next
        End If
        Dim GetItemStatus As DataTable = GetRecordSet("SELECT itemID, Active FROM SilverInvoceDetels GROUP BY itemID,Active HAVING (Active = 1)")
        If GetItemStatus.Rows.Count > 0 Then
            For i As Integer = 0 To GetItemStatus.Rows.Count - 1
                For GredItem = 0 To Grid.Rows.Count - 1
                    If Grid.Rows(GredItem).Cells("colBarCode").Value = GetItemStatus.Rows(i)("itemID").ToString Then
                        Grid.Rows(GredItem).DefaultCellStyle.BackColor = Color.OrangeRed
                        Grid.Rows(GredItem).DefaultCellStyle.ForeColor = Color.Black
                        Grid.Rows(GredItem).Cells("colItemStatus").Value = 1
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub GetStoneName1()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] FROM [EXTR_NAME] where Activ=1")
        If dt1.Rows.Count > 0 Then
            cmbStoneName1.DataSource = dt1
            cmbStoneName1.DisplayMember = "EXTR_NAME"
            cmbStoneName1.ValueMember = "EXTR_NAME"
        End If
    End Sub
    Private Sub GetStoneName2()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] FROM [EXTR_NAME] where Activ=1")
        If dt1.Rows.Count > 0 Then
            cmbStoneName2.DataSource = dt1
            cmbStoneName2.DisplayMember = "EXTR_NAME"
            cmbStoneName2.ValueMember = "EXTR_NAME"
        End If
    End Sub
    Private Sub GetStoneName3()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] FROM [EXTR_NAME] where Activ=1")
        If dt1.Rows.Count > 0 Then
            cmbStoneName3.DataSource = dt1
            cmbStoneName3.DisplayMember = "EXTR_NAME"
            cmbStoneName3.ValueMember = "EXTR_NAME"
        End If
    End Sub
    Private Sub AddNew()
        If CheItemRepeat.Checked = False Then
            txtBarCode.Clear()
            With (Grid)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colBarCode").Value = ""
                .Rows(.Rows.Count - 1).Cells("colGram_valu").Value = ""
                .Rows(.Rows.Count - 1).Cells("colGoldCart999").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_name").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_gram").Value = ""
                .Rows(.Rows.Count - 1).Cells("colGoldWeight999").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_gramMade").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_desp").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_made").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_GramPrice").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_ItemNo").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_totalPrice").Value = ""
                .Rows(.Rows.Count - 1).Cells("colQty").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_price").Value = ""
                .Rows(.Rows.Count - 1).Cells("colFO_extras").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneColor1").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStonePrice1").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneName2").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneWeight2").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneColor2").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStonePrice2").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneName3").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneWeight3").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStoneColor3").Value = ""
                .Rows(.Rows.Count - 1).Cells("colStonePrice3").Value = ""
                .Rows(.Rows.Count - 1).Cells("coldate_care").Value = ""
                .Rows(.Rows.Count - 1).Cells("colLastEditDate").Value = ""
                .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = ""
                .Rows(.Rows.Count - 1).Cells("colID").Value = ""
                .Rows(.Rows.Count - 1).Cells("coluserID").Value = ""
                pbImage.Image = Nothing
            End With
            If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
                Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
            Else
            End If
        End If
        cbklblMultiItem.Checked = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ''''''الذهب
        If GoldOrSilver = True Then
            If EditControl = False Then
                If TrueFalse = False Then
                    If CheItemRepeat.Checked = False Then
                        AddItemData()
                    ElseIf CheItemRepeat.Checked = True Then
                        AddItemReb()
                    End If
                ElseIf TrueFalse = True Then
                    If CheItemRepeat.Checked = False Then
                        AddItemData()
                        GoldInvoice.GoldInvoiceLoad()
                        GoldInvoice.txtBarCode.Text = txtBarCode.Text
                        TrueFalse = False
                        Me.Close()
                    ElseIf CheItemRepeat.Checked = True Then
                        AddItemReb()
                    End If
                End If
            ElseIf EditControl = True Then
                EditData()
            End If

            'EditDataSilver()


            '''''''''حفظ الفضه
        ElseIf GoldOrSilver = False Then
            If EditControl = False Then
                If TrueFalse = False Then
                    If CheItemRepeat.Checked = False Then
                        AddItemDataSilver()
                    ElseIf CheItemRepeat.Checked = True Then
                        AddItemRebSilver()
                    End If
                ElseIf TrueFalse = True Then
                    If CheItemRepeat.Checked = False Then
                        AddItemDataSilver()
                        SilverInvoice.GoldInvoiceLoad()
                        SilverInvoice.txtBarCode.Text = txtBarCode.Text
                        TrueFalse = False
                        Me.Close()
                    ElseIf CheItemRepeat.Checked = True Then
                        AddItemRebSilver()
                    End If
                End If
            ElseIf EditControl = True Then
                EditDataSilver()
            End If
        End If
        Grid.Enabled = True
    End Sub

    Private Sub btnBarCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBarCode.Click
        NewForm = False
        If GoldOrSilver = True Then
            Barcode.TPCategory = 1
            Barcode.SQLTP = "FO_min"
        ElseIf GoldOrSilver = False Then
            Barcode.TPCategory = 2
            Barcode.SQLTP = "SilverItem"
        End If
        Barcode.WindowState = FormWindowState.Minimized
        Barcode.Show()
        Barcode.txtBarCodeLeft.Text = Grid.CurrentRow.Cells("colBarCode").Value
        If Grid.CurrentRow.Index >= 1 Then
            Barcode.txtBarCodeRight.Text = Grid.Rows(Grid.CurrentRow.Index - 1).Cells("colBarCode").Value
        Else
            Barcode.txtBarCodeRight.Text = Grid.CurrentRow.Cells("colBarCode").Value
        End If
        Barcode.PrintBarCode()
        Barcode.Dispose()
    End Sub
    Private Sub CleaningFields()
        txtItemNote.Text = ""
        cmbKarat.SelectedIndex = -1
        cmbCountry.SelectedIndex = -1
        cmbSupplier.SelectedIndex = -1
        cmbStoneName1.SelectedIndex = -1
        cmbStoneName2.SelectedIndex = -1
        cmbStoneName3.SelectedIndex = -1
        txtItemName.SelectedIndex = -1
        txtStoneColor1.SelectedIndex = -1
        txtStoneColor2.SelectedIndex = -1
        txtStoneColor3.SelectedIndex = -1
        ClearControlsOnlyTextBox(Container:=gbItemData)
    End Sub
    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        If ChkItemDataSave.Checked = False Then
            CleaningFields()

        ElseIf ChkItemDataSave.Checked = True Then

        End If
        NumItemRep.Enabled = False
        Date_careDateTimePicker.Value = Format(Date.Now, "yyyy-MM-dd")
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnFirstItem.Enabled = False
        btnLastItem.Enabled = False
        btnNextItem.Enabled = False
        gbItemData.Enabled = True
        Grid.Enabled = False
        If ItemName <> "" Then txtMetalWeight.Focus()
        AddNew()
        txtBarcodTag.Enabled = False
    End Sub
    Private Sub btnGramPrice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelImport.Click
        ExcelImportType = "GOLD"
        frmExcelImport.ShowDialog()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirstItem.Click
        Grid.Rows(0).Selected = True
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLastItem.Click
        Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
    End Sub



    Private Sub lblPhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblPhoto.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbImage.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbImage.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub grid_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
        Try
            ' FO_minBindingSource.RemoveCurrent()
            NewData()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub NewData()
        gbItemData.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnFirstItem.Enabled = True
        btnLastItem.Enabled = True
        btnNextItem.Enabled = True
        btnBarCode.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If Grid.SelectedRows(0).Cells("colItemStatus").Value = 1 Then
            MsgBox("لا يمكن تعديل صنف سبق بيعه" & vbCrLf & "Can't Edit an Already Sold Item", , AppTitle)
            Exit Sub
        End If
        gbItemData.Enabled = True
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnBarCode.Enabled = False
        EditControl = True
        ChkItemDataSave.Checked = False
        GridSelectionChanged()
    End Sub
    Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
            cmbKarat.SelectedValue = Grid.SelectedRows(0).Cells("colKarat").Value
            cmbCountry.SelectedValue = Grid.SelectedRows(0).Cells("colCountry").Value
            cmbStoneName1.SelectedValue = Grid.SelectedRows(0).Cells("colStoneName1").Value
            cmbStoneName2.SelectedValue = Grid.SelectedRows(0).Cells("colStoneName2").Value
            cmbStoneName3.SelectedValue = Grid.SelectedRows(0).Cells("colStoneName3").Value
            cmbSupplier.SelectedValue = Grid.SelectedRows(0).Cells("colSupplier").Value
            BarCodeUpdate = If(IsDBNull(Grid.SelectedRows(0).Cells("colBarCode").Value), "", Grid.SelectedRows(0).Cells("colBarCode").Value)
        End If
    End Sub

    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If PermissionsDt.Rows.Count > 0 Then
            If PermissionsDt.Rows(0)("chkDelItem") = False Then
                MsgBox("؟" & frmMain.lblUserName.Text.Trim & "لا توجد صلاحيات الحزف الي المستخدم" & vbCrLf & "There Are No User Delete Permissions." & frmMain.lblUserName.Text.Trim & "؟", , AppTitle)
                Exit Sub
            Else
            End If
        End If

        If GoldOrSilver = True Then
            If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
                If MsgBox("هل تريد حذف القطعة رقم " & Grid.Rows(e.RowIndex).Cells("colBarCode").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & Grid.Rows(e.RowIndex).Cells("colBarCode").Value, vbYesNo) = vbYes Then
                    Try
                        GlCommand.CommandText = "UPDATE [FO_min] SET [Item_Actv]='0' WHERE ID='" & Grid.CurrentRow.Cells("colID").Value & "'"
                        GlCommand.ExecuteNonQuery()
                        MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                        Grid.Rows.Remove(Grid.SelectedRows(0))
                    Catch ex As Exception
                        MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    End Try
                End If
            End If
        ElseIf GoldOrSilver = False Then
            If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
                If MsgBox("هل تريد حذف القطعة رقم " & Grid.Rows(e.RowIndex).Cells("colBarCode").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & Grid.Rows(e.RowIndex).Cells("colBarCode").Value, vbYesNo) = vbYes Then
                    Try
                        GlCommand.CommandText = "UPDATE [SilverItem] SET [Item_Actv]='0' WHERE ID='" & Grid.CurrentRow.Cells("colID").Value & "'"
                        GlCommand.ExecuteNonQuery()
                        MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                        Grid.Rows.Remove(Grid.SelectedRows(0))
                    Catch ex As Exception
                        MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If

    End Sub

    Private Sub txtWeight_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtMetalWeight.KeyDown
        If ItemName = "" Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If chkItemNO.Checked = False And ChkBar.Checked = False Then
            MsgBox("اختر معيار للبحث" & vbCrLf & "Select a Search Criteria")
            Exit Sub
        Else
            If ChkBar.Checked = True Then
                Dim SearchBarCode As String = InputBox("أدخل الباركود المطلوب البحث عنه" & vbCrLf & "Enter a Barcode to search", AppTitle)
                If SearchBarCode = "" Then Exit Sub
                For Each row As DataGridViewRow In Grid.Rows
                    If row.Cells("colBarCode").Value.ToString = SearchBarCode Then
                        row.Selected = True
                        Grid.FirstDisplayedScrollingRowIndex = row.Index
                        Exit For
                    End If
                Next
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf chkItemNO.Checked = True Then
                Dim SearchBarCode As String = InputBox("أدخل رمز القطعه المطلوب البحث عنه" & vbCrLf & "Enter a Item Code. to search", AppTitle)
                If SearchBarCode = "" Then Exit Sub
                For Each row As DataGridViewRow In Grid.Rows
                    If row.Cells("colFO_ItemNo").Value.ToString = SearchBarCode Then
                        row.Selected = True
                        Grid.FirstDisplayedScrollingRowIndex = row.Index
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub CheItemRepeat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheItemRepeat.CheckedChanged
        If NumItemRep.Enabled = False Then
            NumItemRep.Enabled = True
            txtBarCode.Clear()
            txtBarCode.Enabled = False
        ElseIf NumItemRep.Enabled = True Then
            ChkItemDataSave.Checked = True
            NumItemRep.Enabled = False
            txtBarCode.Enabled = True
        End If
    End Sub
#End Region
#Region "SILVER"
    Public Sub GetSilvertemName()
        Dim DtGoldItemName As DataTable = GetRecordSet("SELECT FO_name FROM dbo.SilverItem GROUP BY FO_name")
        If DtGoldItemName.Rows.Count > 0 Then
            txtItemName.DataSource = DtGoldItemName
            txtItemName.DisplayMember = "FO_name"
        End If
        txtItemName.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="FO_name", ComboBoxName:=txtItemName)
    End Sub
    Private Sub AddItemDataSilver()
        If cmbKarat.SelectedIndex = -1 Then
            MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
            cmbKarat.DroppedDown = True
            Exit Sub
        End If
        If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
            MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
            txtItemName.Focus()
            Exit Sub
        End If

        If txtMetalWeight.Text.Trim = "" Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
            txtMetalWeight.Focus()
            Exit Sub
        End If

        If txtMakeCharge.Text.Trim = "" Then
            MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
            txtMakeCharge.Focus()
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then
            MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
            txtCostPerGram.Focus()
            Exit Sub
        End If

        If cmbCountry.SelectedIndex = -1 Then
            MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
            cmbCountry.DroppedDown = True
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
        If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
        If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
        If txtQty.Text.Trim = "" Then txtQty.Text = "1"

        Dim dt1 As DataTable = GetRecordSet("SELECT [BarCode] FROM [SilverItem] WHERE [BarCode] = N'" & txtBarCode.Text & "'")
        If dt1.Rows.Count > 0 Then
            MsgBox("الباركود المدخل مكرر!... أدخل باركود جديد أو اتركه خاليا ليتم إدخال باركود آلي" & vbCrLf & "BarCode is Duplicated!.. Enter a New BarCode Or Leave It Empty to Make It Automatic", , AppTitle)
            txtBarCode.SelectAll()
            txtBarCode.Focus()
            Exit Sub
        End If
        'Try
        ''''''''''باركود فريد

        Dim Barcood As String
        Dim GetNewBarcood As DataTable = GetRecordSet("SELECT [ID] +1 AS ID FROM SilverItem WHERE [ID]=(SELECT max([ID]) FROM SilverItem)")
        If GetNewBarcood.Rows.Count > 0 Then
            Barcood = Val(GetNewBarcood.Rows(0)(0).ToString)
        Else
            Barcood = "100"
        End If
        GlCommand.CommandText = "INSERT INTO [SilverItem]" &
           " ([userID]" &
           ",[FO_name]" &
           ",[FO_desp]" &
           ",[FO_price]" &
           ",[FO_GramPrice]" &
           ",[FO_gram]" &
           ",[FO_gramMade]" &
           ",[FO_made]" &
           ",[FO_extras]" &
           ",[FO_totalPrice]" &
           ",[Gram_valu]" &
           ",[ITEM_IMGE]" &
           ",[date_care]" &
           ",[FO_ItemNo]" &
           ",[Item_Actv]" &
           ",[StoneColor1]" &
           ",[StonePrice1]" &
           ",[StoneWeight2]" &
           ",[StoneName2]" &
           ",[StoneColor2]" &
           ",[StonePrice2]" &
           ",[StoneWeight3]" &
           ",[StoneName3]" &
           ",[StoneColor3]" &
           ",[StonePrice3]" &
           ",[Qty]" &
           ",[BarCode]" &
           ",[LastEditDate]" &
           ",[ItemNote]" &
           ",[GoldCaret999]" &
           ",[GoldWeight999]" &
           ",[PurInvNumber]" &
           ",[MultiItem])" &
           "VALUES" &
           "(@userID" &
           ",@FO_name" &
           ",@FO_desp" &
           ",@FO_price" &
           ",@FO_GramPrice" &
           ",@FO_gram" &
           ",@FO_gramMade" &
           ",@FO_made" &
           ",@FO_extras" &
           ",@FO_totalPrice" &
           ",@Gram_valu" &
           ",@ITEM_IMGE" &
           ",@date_care" &
           ",@FO_ItemNo" &
           ",@Item_Actv" &
           ",@StoneColor1" &
           ",@StonePrice1" &
           ",@StoneWeight2" &
           ",@StoneName2" &
           ",@StoneColor2" &
           ",@StonePrice2" &
           ",@StoneWeight3" &
           ",@StoneName3" &
           ",@StoneColor3" &
           ",@StonePrice3" &
           ",@Qty" &
           ",@BarCode" &
           ",@LastEditDate" &
           ",@ItemNote" &
           ",@GoldCaret999" &
           ",@GoldWeight999" &
           ",@PurInvNumber" &
           ",@MultiItem)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
            .AddWithValue("@FO_name", txtItemName.Text.Trim)
            .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
            .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
            .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
            .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
            .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
            .AddWithValue("@FO_made", cmbCountry.Text.Trim)
            .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
            .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
            .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
            .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
            .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
            .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
            .AddWithValue("@Item_Actv", "1")
            .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
            .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
            .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
            .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
            .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
            .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
            .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
            .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
            .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
            .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
            .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
            .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text))
            .AddWithValue("@LastEditDate", Date.UtcNow)
            .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
            .AddWithValue("@GoldCaret999", If(IsDBNull(ComBxGoCaret999.Text.Trim) Or ComBxGoCaret999.Text.Trim = "", "999", ComBxGoCaret999.Text.Trim))
            .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
            .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
            .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
        End With
        GlCommand.ExecuteNonQuery()
        Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
        With (UpdateRows)
            If (IsDBNull(txtBarCode.Text) Or (txtBarCode.Text.Trim = "")) Then txtBarCode.Text = Barcood
            .Cells("colBarCode").Value = Barcood
            .Cells("colFO_name").Value = txtItemName.Text.Trim
            .Cells("colFO_desp").Value = txtCostPerGram.Text.Trim
            .Cells("colFO_price").Value = cmbStoneName1.Text.Trim
            .Cells("colFO_GramPrice").Value = cmbSupplier.Text.Trim
            .Cells("colFO_gram").Value = txtMetalWeight.Text.Trim
            .Cells("colFO_gramMade").Value = txtMakeCharge.Text.Trim
            .Cells("colFO_made").Value = cmbCountry.Text.Trim
            .Cells("colFO_extras").Value = txtStoneWeight1.Text.Trim
            .Cells("colFO_totalPrice").Value = txtCostPerItem.Text.Trim
            .Cells("colGram_valu").Value = cmbKarat.Text.Trim
            .Cells("coldate_care").Value = DateToSave(DateDiamItem.Value)
            .Cells("colFO_ItemNo").Value = txtCode.Text.Trim
            .Cells("colStoneColor1").Value = txtStoneColor1.Text.Trim
            .Cells("colStonePrice1").Value = txtStonePrice1.Text.Trim
            .Cells("colStoneWeight2").Value = txtStoneWeight2.Text.Trim
            .Cells("colStoneName2").Value = cmbStoneName2.Text.Trim
            .Cells("colStoneColor2").Value = txtStoneColor2.Text.Trim
            .Cells("colStonePrice2").Value = txtStonePrice2.Text.Trim
            .Cells("colStoneWeight3").Value = txtStoneWeight3.Text.Trim
            .Cells("colStoneName3").Value = cmbStoneName3.Text.Trim
            .Cells("colStoneColor3").Value = txtStoneColor3.Text.Trim
            .Cells("colStonePrice3").Value = txtStonePrice3.Text.Trim
            .Cells("colQty").Value = txtQty.Text.Trim
            .Cells("colBarCode").Value = txtBarCode.Text.Trim
            .Cells("colLastEditDate").Value = Format(DateDiamItem.Value, "dd/MM/yyyy hh:mm:ss")
            .Cells("colItemNote").Value = txtItemNote.Text.Trim
            .Cells("colGoldCart999").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim) Or ComBxGoCaret999.Text.Trim = "", "999", ComBxGoCaret999.Text.Trim)
            .Cells("colGoldWeight999").Value = TXTGoCaret999.Text.Trim
            .Cells("colPurInvNumber").Value = CmbPurInvNumber.Text.Trim
            .Cells("colcbklblMultiItem").Value = cbklblMultiItem.Checked
        End With
        btnNew.Enabled = True
        btnSave.Enabled = False
        MsgBox("تم اضافة الاصناف بنجاح" & vbCrLf & "Items added successfully", , AppTitle)
        gbItemData.Enabled = False
    End Sub
    Private Sub AddItemRebSilver()
        Do Until ItemRep = (NumItemRep.Value) + 1
            txtBarCode.Clear()
            If cmbKarat.SelectedIndex = -1 Then
                MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
                cmbKarat.DroppedDown = True
                Exit Sub
            End If
            If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
                MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
                Exit Sub
            End If
            If txtItemName.Text.Trim = "" Then
                MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
                txtItemName.Focus()
                Exit Sub
            End If

            If txtMetalWeight.Text.Trim = "" Then
                MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
                txtMetalWeight.Focus()
                Exit Sub
            End If

            If txtMakeCharge.Text.Trim = "" Then
                MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
                txtMakeCharge.Focus()
                Exit Sub
            End If

            If txtCostPerGram.Text.Trim = "" Then
                MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
                txtCostPerGram.Focus()
                Exit Sub
            End If

            If cmbCountry.SelectedIndex = -1 Then
                MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
                cmbCountry.DroppedDown = True
                Exit Sub
            End If
            If (IsDBNull(TXTGoCaret999.Text) Or TXTGoCaret999.Text.Trim = "") Then
                MsgBox("ادخل وزن الذهب الصافي" & vbCrLf & "Enter the weight of pure gold", , AppTitle)
                TXTGoCaret999.Focus()
            End If
            If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
            If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
            If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
            If txtQty.Text.Trim = "" Then txtQty.Text = "1"

            Dim dt1 As DataTable = GetRecordSet("SELECT [BarCode] FROM [SilverItem] WHERE [BarCode] = N'" & txtBarCode.Text & "'")
            If dt1.Rows.Count > 0 Then
                MsgBox("الباركود المدخل مكرر!... أدخل باركود جديد أو اتركه خاليا ليتم إدخال باركود آلي" & vbCrLf & "BarCode is Duplicated!.. Enter a New BarCode Or Leave It Empty to Make It Automatic", , AppTitle)
                txtBarCode.SelectAll()
                txtBarCode.Focus()
                Exit Sub
            End If
            Dim Barcood As String
            Dim GetNewBarcood As DataTable = GetRecordSet("SELECT [ID] +1 AS ID FROM SilverItem WHERE [ID]=(SELECT max([ID]) FROM SilverItem)")
            If GetNewBarcood.Rows.Count > 0 Then
                Barcood = Val(GetNewBarcood.Rows(0)(0).ToString)
            Else
                Barcood = "100"
            End If
            GlCommand.CommandText = "INSERT INTO [SilverItem]" &
               " ([userID]" &
               ",[FO_name]" &
               ",[FO_desp]" &
               ",[FO_price]" &
               ",[FO_GramPrice]" &
               ",[FO_gram]" &
               ",[FO_gramMade]" &
               ",[FO_made]" &
               ",[FO_extras]" &
               ",[FO_totalPrice]" &
               ",[Gram_valu]" &
               ",[ITEM_IMGE]" &
               ",[date_care]" &
               ",[FO_ItemNo]" &
               ",[Item_Actv]" &
               ",[StoneColor1]" &
               ",[StonePrice1]" &
               ",[StoneWeight2]" &
               ",[StoneName2]" &
               ",[StoneColor2]" &
               ",[StonePrice2]" &
               ",[StoneWeight3]" &
               ",[StoneName3]" &
               ",[StoneColor3]" &
               ",[StonePrice3]" &
               ",[Qty]" &
               ",[BarCode]" &
               ",[LastEditDate]" &
               ",[ItemNote]" &
               ",[GoldCaret999]" &
               ",[GoldWeight999]" &
               ",[PurInvNumber]" &
               ",[MultiItem])" &
               "VALUES" &
               "(@userID" &
               ",@FO_name" &
               ",@FO_desp" &
               ",@FO_price" &
               ",@FO_GramPrice" &
               ",@FO_gram" &
               ",@FO_gramMade" &
               ",@FO_made" &
               ",@FO_extras" &
               ",@FO_totalPrice" &
               ",@Gram_valu" &
               ",@ITEM_IMGE" &
               ",@date_care" &
               ",@FO_ItemNo" &
               ",@Item_Actv" &
               ",@StoneColor1" &
               ",@StonePrice1" &
               ",@StoneWeight2" &
               ",@StoneName2" &
               ",@StoneColor2" &
               ",@StonePrice2" &
               ",@StoneWeight3" &
               ",@StoneName3" &
               ",@StoneColor3" &
               ",@StonePrice3" &
               ",@Qty" &
               ",@BarCode" &
               ",@LastEditDate" &
               ",@ItemNote" &
               ",@GoldCaret999" &
               ",@GoldWeight999" &
               ",@PurInvNumber" &
               ",@MultiItem)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
                .AddWithValue("@FO_name", txtItemName.Text.Trim)
                .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
                .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
                .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
                .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
                .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
                .AddWithValue("@FO_made", cmbCountry.Text.Trim)
                .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
                .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
                .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
                .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
                .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
                .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
                .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
                .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
                .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
                .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
                .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
                .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
                .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
                .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
                .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
                .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
                .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
                .AddWithValue("@GoldCaret999", ComBxGoCaret999.Text.Trim)
                .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
                .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
                .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
            End With
            GlCommand.ExecuteNonQuery()
            ItemRep += 1
        Loop
        btnNew.Enabled = True
        btnSave.Enabled = False
        CheItemRepeat.Checked = False
        MsgBox("تم اضافة الاصناف بنجاح" & vbCrLf & "Items added successfully", , AppTitle)
        gbItemData.Enabled = False
        Me.Close()
    End Sub
    Private Sub EditDataSilver()
        If cmbKarat.SelectedIndex = -1 Then
            MsgBox("يرجى اختيار العيار" & vbCrLf & "Please Select Carat", , AppTitle)
            cmbKarat.DroppedDown = True
            Exit Sub
        End If
        If Val(txtMakeCharge.Text) < Val(txtCostPerGram.Text) Then
            MsgBox("لايمكن أن تكون قيمة مصنعية الجرام أقل من تكلفة الجرام" & vbCrLf & "Processing Cost/gm can't be less than Purchase Cost/gm.", , AppTitle)
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الصنف" & vbCrLf & "Please Enter Item Name", , AppTitle)
            txtItemName.Focus()
            Exit Sub
        End If

        If txtMetalWeight.Text.Trim = "" Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Item Weight", , AppTitle)
            txtMetalWeight.Focus()
            Exit Sub
        End If

        If txtMakeCharge.Text.Trim = "" Then
            MsgBox("يرجى إدخال مصنعية الجرام" & vbCrLf & "Please Enter Cost", , AppTitle)
            txtMakeCharge.Focus()
            Exit Sub
        End If

        If txtCostPerGram.Text.Trim = "" Then
            MsgBox("يرجى إدخال تكلفة شراء الجرام" & vbCrLf & "Please Enter Purchase Cost", , AppTitle)
            txtCostPerGram.Focus()
            Exit Sub
        End If

        If cmbCountry.SelectedIndex = -1 Then
            MsgBox("يرجى إدخال بلد المنشأ" & vbCrLf & "Please Enter Country Of Origin", , AppTitle)
            cmbCountry.DroppedDown = True
            Exit Sub
        End If
        If txtCostPerGram.Text.Trim = "" Then txtCostPerGram.Text = "0"
        If txtCostPerItem.Text.Trim = "" Then txtCostPerItem.Text = "0"
        If TXTGoCaret999.Text.Trim = "" Then TXTGoCaret999.Text = "0"
        If txtQty.Text.Trim = "" Then txtQty.Text = "1"
        Try
            Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
            UpdateRows.Cells("coluserID").Value = CobUser.Text.Trim
            UpdateRows.Cells("colBarCode").Value = txtBarCode.Text.Trim
            UpdateRows.Cells("colFO_name").Value = txtItemName.Text.Trim
            UpdateRows.Cells("colFO_desp").Value = txtCostPerGram.Text.Trim
            UpdateRows.Cells("colFO_price").Value = cmbStoneName1.Text.Trim
            UpdateRows.Cells("colFO_GramPrice").Value = cmbSupplier.Text.Trim
            UpdateRows.Cells("colFO_gram").Value = txtMetalWeight.Text.Trim
            UpdateRows.Cells("colFO_gramMade").Value = txtMakeCharge.Text.Trim
            UpdateRows.Cells("colFO_made").Value = cmbCountry.Text.Trim
            UpdateRows.Cells("colFO_extras").Value = txtStoneWeight1.Text.Trim
            UpdateRows.Cells("colFO_totalPrice").Value = txtCostPerItem.Text.Trim
            UpdateRows.Cells("colGram_valu").Value = cmbKarat.Text.Trim
            UpdateRows.Cells("colFO_ItemNo").Value = txtCode.Text.Trim
            UpdateRows.Cells("colStoneColor1").Value = txtStoneColor1.Text.Trim
            UpdateRows.Cells("colStonePrice1").Value = txtStonePrice1.Text.Trim
            UpdateRows.Cells("colStoneWeight2").Value = txtStoneWeight2.Text.Trim
            UpdateRows.Cells("colStoneName2").Value = cmbStoneName2.Text.Trim
            UpdateRows.Cells("colStoneColor2").Value = txtStoneColor2.Text.Trim
            UpdateRows.Cells("colStonePrice2").Value = txtStonePrice2.Text.Trim
            UpdateRows.Cells("colStoneWeight3").Value = txtStoneWeight3.Text.Trim
            UpdateRows.Cells("colStoneName3").Value = cmbStoneName3.Text.Trim
            UpdateRows.Cells("colStoneColor3").Value = txtStoneColor3.Text.Trim
            UpdateRows.Cells("colStonePrice3").Value = txtStonePrice3.Text.Trim
            UpdateRows.Cells("colQty").Value = txtQty.Text.Trim
            UpdateRows.Cells("colLastEditDate").Value = Format(DateDiamItem.Value, "dd/MM/yyyy hh:mm:ss")
            UpdateRows.Cells("colItemNote").Value = txtItemNote.Text.Trim
            UpdateRows.Cells("colGoldCart999").Value = ComBxGoCaret999.Text.Trim
            UpdateRows.Cells("colGoldWeight999").Value = TXTGoCaret999.Text.Trim
            UpdateRows.Cells("colPurInvNumber").Value = CmbPurInvNumber.Text.Trim
            UpdateRows.Cells("colcbklblMultiItem").Value = cbklblMultiItem.Checked
            GlCommand.CommandText = "UPDATE [SilverItem] SET [userID] = @userID" & vbCrLf &
                                                     ",[FO_name] = @FO_name" & vbCrLf &
                                                     ",[FO_desp] = @FO_desp" & vbCrLf &
                                                     ",[FO_price] = @FO_price" & vbCrLf &
                                                     ",[FO_GramPrice] = @FO_GramPrice" & vbCrLf &
                                                     ",[FO_gram] = @FO_gram" & vbCrLf &
                                                     ",[FO_gramMade] = @FO_gramMade" & vbCrLf &
                                                     ",[FO_made] = @FO_made" & vbCrLf &
                                                     ",[FO_extras] = @FO_extras" & vbCrLf &
                                                     ",[FO_totalPrice] = @FO_totalPrice" & vbCrLf &
                                                     ",[Gram_valu] = @Gram_valu" & vbCrLf &
                                                     ",[ITEM_IMGE] = @ITEM_IMGE" & vbCrLf &
                                                     ",[FO_ItemNo] = @FO_ItemNo" & vbCrLf &
                                                     ",[Item_Actv] = @Item_Actv" & vbCrLf &
                                                     ",[StoneColor1] = @StoneColor1" & vbCrLf &
                                                     ",[StonePrice1] = @StonePrice1" & vbCrLf &
                                                     ",[StoneWeight2] = @StoneWeight2" & vbCrLf &
                                                     ",[StoneName2] = @StoneName2" & vbCrLf &
                                                     ",[StoneColor2] = @StoneColor2" & vbCrLf &
                                                     ",[StonePrice2] = @StonePrice2" & vbCrLf &
                                                     ",[StoneWeight3] = @StoneWeight3" & vbCrLf &
                                                     ",[StoneName3] = @StoneName3" & vbCrLf &
                                                     ",[StoneColor3] = @StoneColor3" & vbCrLf &
                                                     ",[StonePrice3] = @StonePrice3" & vbCrLf &
                                                     ",[Qty] = @Qty" & vbCrLf &
                                                     ",[BarCode] = @BarCode" & vbCrLf &
                                                     ",[LastEditDate] = @LastEditDate" & vbCrLf &
                                                     ",[ItemNote] = @ItemNote" & vbCrLf &
                                                     ",[GoldCaret999] = @GoldCaret999" & vbCrLf &
                                                     ",[GoldWeight999] = @GoldWeight999" & vbCrLf &
                                                     ",[PurInvNumber] = @PurInvNumber" & vbCrLf &
                                                     ",[MultiItem] = @MultiItem" & vbCrLf &
                                                     "WHERE [ID] ='" & Grid.SelectedRows(0).Cells("colID").Value & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@userID", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
                .AddWithValue("@FO_name", txtItemName.Text.Trim)
                .AddWithValue("@FO_desp", txtCostPerGram.Text.Trim)
                .AddWithValue("@FO_price", If(IsDBNull(cmbStoneName1.Text.Trim), "", cmbStoneName1.Text.Trim))
                .AddWithValue("@FO_GramPrice", cmbSupplier.Text.Trim)
                .AddWithValue("@FO_gram", txtMetalWeight.Text.Trim)
                .AddWithValue("@FO_gramMade", txtMakeCharge.Text.Trim)
                .AddWithValue("@FO_made", cmbCountry.Text.Trim)
                .AddWithValue("@FO_extras", If(IsDBNull(txtStoneWeight1.Text.Trim) Or (txtStoneWeight1.Text.Trim = ""), 0, (txtStoneWeight1.Text.Trim)))
                .AddWithValue("@FO_totalPrice", txtCostPerItem.Text.Trim)
                .AddWithValue("@Gram_valu", cmbKarat.Text.Trim)
                .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
                .AddWithValue("@date_care", DateToSave(DateDiamItem.Value))
                .AddWithValue("@FO_ItemNo", txtCode.Text.Trim)
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
                .AddWithValue("@StonePrice1", If(IsDBNull(txtStonePrice1.Text.Trim) Or (txtStonePrice1.Text.Trim = ""), 0, txtStonePrice1.Text.Trim))
                .AddWithValue("@StoneWeight2", If(IsDBNull(txtStoneWeight2.Text.Trim) Or (txtStoneWeight2.Text.Trim = ""), 0, txtStoneWeight2.Text.Trim))
                .AddWithValue("@StoneName2", If(IsDBNull(cmbStoneName2.Text.Trim), "", cmbStoneName2.Text.Trim))
                .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
                .AddWithValue("@StonePrice2", If(IsDBNull(txtStonePrice2.Text.Trim) Or (txtStonePrice2.Text.Trim = ""), 0, txtStonePrice2.Text.Trim))
                .AddWithValue("@StoneWeight3", If(IsDBNull(txtStoneWeight3.Text.Trim) Or (txtStoneWeight3.Text.Trim = ""), 0, txtStoneWeight3.Text.Trim))
                .AddWithValue("@StoneName3", If(IsDBNull(cmbStoneName3.Text.Trim), "", cmbStoneName3.Text.Trim))
                .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
                .AddWithValue("@StonePrice3", If(IsDBNull(txtStonePrice3.Text.Trim) Or (txtStonePrice3.Text.Trim = ""), 0, txtStonePrice3.Text.Trim))
                .AddWithValue("@Qty", If(IsDBNull(txtQty.Text.Trim), 1, txtQty.Text.Trim))
                .AddWithValue("@BarCode", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", txtBarCode.Text.Trim, txtBarCode.Text.Trim))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
                .AddWithValue("@GoldCaret999", ComBxGoCaret999.Text.Trim)
                .AddWithValue("@GoldWeight999", TXTGoCaret999.Text.Trim)
                .AddWithValue("@PurInvNumber", CmbPurInvNumber.Text.Trim)
                .AddWithValue("@MultiItem", If(cbklblMultiItem.Checked = False, 0, 1))
            End With
            GlCommand.ExecuteNonQuery()
            btnNew.Enabled = True
            btnSave.Enabled = False
            MsgBox("تم الحفظ التعديل بنجاح" & vbCrLf & "Save Edit successfully", , AppTitle)
            Grid.RefreshEdit()
            Grid.EndEdit()
            NewData()
            EditControl = False
            gbItemData.Enabled = False
        Catch ex As Exception
            RecordRrrors(ex.ToString)
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region
    Private Sub GoldAddItemDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        frmMain.Timer1.Stop()
        DGV_Style.ApplyGoldenStyle(Grid)
        DGV_Style.AutoFitColumns(Grid)

        Date_careDateTimePicker.Value = DateNaw
        ControlsAsColor(ColorSelect:=Me)
        btnNew.Enabled = True
        btnSave.Enabled = False
        CheItemRepeat.Checked = False
        gbItemData.Enabled = False
        GoldCaret()
        GoldCaret999()
        GetStoneName1()
        GetStoneName2()
        GetStoneName3()
        language_start(Name)
        GetFillComboBox(ComboBoxName:=cmbSupplier, SqlCom:="SELECT [BranchName]  FROM [TPCompanyBranches]", DisMem:="BranchName", ValMem:="BranchName")
        GetFillComboBox(ComboBoxName:=cmbCountry, SqlCom:="SELECT [CANTRY_name]  FROM [CANTRY]", DisMem:="CANTRY_name", ValMem:="CANTRY_name")
        GetFillComboBox(ComboBoxName:=CobUser, SqlCom:="SELECT [user_id],[user_name] FROM [user] where [Active]=1", DisMem:="user_name", ValMem:="user_id")
        'StonColr
        GetFillComboBox(ComboBoxName:=txtStoneColor1, SqlCom:="SELECT [ID],[StoneColor] FROM [StoneColor]", DisMem:="StoneColor", ValMem:="ID")
        GetFillComboBox(ComboBoxName:=txtStoneColor2, SqlCom:="SELECT [ID],[StoneColor] FROM [StoneColor]", DisMem:="StoneColor", ValMem:="ID")
        GetFillComboBox(ComboBoxName:=txtStoneColor3, SqlCom:="SELECT [ID],[StoneColor] FROM [StoneColor]", DisMem:="StoneColor", ValMem:="ID")
        If GoldOrSilver = True Then
            language_start("GOLDADDITEMDETAILS")
            GetGoldItemName()
            ItemLod = ("SELECT * FROM [FO_min] where [Item_Actv]=1")
            LoadData()
        ElseIf GoldOrSilver = False Then
            language_start("SILVERADDITEMDETAILS")
            GetSilvertemName()
            ItemLod = ("SELECT * FROM [SilverItem] where [Item_Actv]=1")
            LoadData()
        End If
        Ttip.SetToolTip(cbklblMultiItem, "اضغط لاضافة صنف مجمع يحتوي علي اكثر من قطعه" & vbCrLf & "Click here for a group item that contains more than one item.")
        Ttip.SetToolTip(ChkItemDataSave, "حفظ بيانات الصنف لاعادة ادخاله مره اخري" & vbCrLf & "Save item data to re-enter it again")
        Try
            Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
        Catch ex As Exception

        End Try
        If GoldOrSilver = False Then
            TXTGoCaret999.Text = 0
            TXTGoCaret999.Enabled = False
        End If
        lblBarCode.Checked = False
        txtBarCode.Enabled = False
        txtBarcodTag.Enabled = False
        CheckUserPermissions(UserID)

        Dim DTBarCodeNote As DataTable = GetRecordSet("SELECT [BarCodeNote] FROM [Settings]")
        If DTBarCodeNote.Rows.Count > 0 Then
            txtBarcodTag.Text = DTBarCodeNote.Rows(0)(0).ToString
            Exit Sub
        End If



    End Sub
    Private Sub GridSelectionChanged()
        If ChkItemDataSave.Checked = False Then
            If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
                cmbKarat.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colGram_valu").Value), "", (Grid.SelectedRows(0).Cells("colGram_valu").Value))
                ComBxGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colGoldCart999").Value), "", (Grid.SelectedRows(0).Cells("colGoldCart999").Value))
                txtItemName.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_name").Value), "", Grid.SelectedRows(0).Cells("colFO_name").Value)
                txtMetalWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_gram").Value), "", Grid.SelectedRows(0).Cells("colFO_gram").Value)
                TXTGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colGoldWeight999").Value), "", Grid.SelectedRows(0).Cells("colGoldWeight999").Value)
                txtMakeCharge.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_gramMade").Value), "", Grid.SelectedRows(0).Cells("colFO_gramMade").Value)
                txtCostPerGram.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_desp").Value), "", Grid.SelectedRows(0).Cells("colFO_desp").Value)
                cmbCountry.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_made").Value), "", Grid.SelectedRows(0).Cells("colFO_made").Value)
                cmbSupplier.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_GramPrice").Value), "", Grid.SelectedRows(0).Cells("colFO_GramPrice").Value)
                CmbPurInvNumber.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colPurInvNumber").Value), "", Grid.SelectedRows(0).Cells("colPurInvNumber").Value)
                txtCode.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_ItemNo").Value), "", Grid.SelectedRows(0).Cells("colFO_ItemNo").Value)
                txtCostPerItem.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_totalPrice").Value), "", Grid.SelectedRows(0).Cells("colFO_totalPrice").Value)
                txtQty.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colQty").Value), "", Grid.SelectedRows(0).Cells("colQty").Value)
                'الاحجار
                cmbStoneName1.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_price").Value), "", Grid.SelectedRows(0).Cells("colFO_price").Value)
                cmbStoneName2.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneName2").Value), "", Grid.SelectedRows(0).Cells("colStoneName2").Value)
                cmbStoneName3.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneName3").Value), "", Grid.SelectedRows(0).Cells("colStoneName3").Value)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                txtStoneWeight1.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colFO_extras").Value), "", Grid.SelectedRows(0).Cells("colFO_extras").Value)
                txtStoneWeight2.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneWeight2").Value), "", Grid.SelectedRows(0).Cells("colStoneWeight2").Value)
                txtStoneWeight3.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneWeight3").Value), "", Grid.SelectedRows(0).Cells("colStoneWeight3").Value)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                txtStoneColor1.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneColor1").Value), "", Grid.SelectedRows(0).Cells("colStoneColor1").Value)
                txtStoneColor2.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneColor2").Value), "", Grid.SelectedRows(0).Cells("colStoneColor2").Value)
                txtStoneColor3.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneColor3").Value), "", Grid.SelectedRows(0).Cells("colStoneColor3").Value)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                txtStonePrice1.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStonePrice1").Value), "", Grid.SelectedRows(0).Cells("colStonePrice1").Value)
                txtStonePrice2.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStonePrice2").Value), "", Grid.SelectedRows(0).Cells("colStonePrice2").Value)
                txtStonePrice3.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStonePrice3").Value), "", Grid.SelectedRows(0).Cells("colStonePrice3").Value)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'DateDiamItem.Value = If(IsDBNull(Grid.SelectedRows(0).Cells("coldate_care").Value), "", Grid.SelectedRows(0).Cells("coldate_care").Value)
                txtBarCode.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colBarCode").Value), "", Grid.SelectedRows(0).Cells("colBarCode").Value)
                CobUser.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coluserID").Value), "", Grid.SelectedRows(0).Cells("coluserID").Value)
                txtItemNote.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colItemNote").Value), "", Grid.SelectedRows(0).Cells("colItemNote").Value)
                CmbPurInvNumber.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colPurInvNumber").Value), "", Grid.SelectedRows(0).Cells("colPurInvNumber").Value)
                cbklblMultiItem.Checked = (Grid.SelectedRows(0).Cells("colcbklblMultiItem").Value)
                If Grid.SelectedRows(0).Cells("colItemStatus").Value = 1 Then
                    btnSave.Enabled = False
                ElseIf Grid.SelectedRows(0).Cells("colItemStatus").Value = 0 Then
                    btnSave.Enabled = True
                End If
                GetImg()
            End If
        ElseIf ChkItemDataSave.Checked = True Then

        End If
    End Sub
    Private Sub GoldAddItemDetails_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If GoldInvoice.Visible = True Then
            GoldInvoice.GoldInvoiceLoad()
            GoldInvoice.txtBarCodeTextChanged()
            Dispose()
        Else
            frmMain.Timer1.Start()
            Dispose()
        End If
    End Sub

    Private Sub btnItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemName.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub txtMetalWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMetalWeight.TextChanged
        GoldWeight()
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged
        GoldWeight()
    End Sub

    Private Sub cmbKarat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKarat.SelectedIndexChanged
        GoldWeight()
    End Sub

    Private Sub txtBarCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged

    End Sub

    Private Sub btnPreviousItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousItem.Click
        'If Me.Grid.CurrentCell.RowIndex > 0 Then
        '    MoveRow(-1) ' move up in the datagridview (row index is 1 less
        'End If
        If Grid.CurrentRow.Index < Grid.Rows.Count Then
            Grid.Rows(Grid.CurrentRow.Index + 1).Selected = True
            Exit Sub
        End If
    End Sub

    Private Sub txtMetalWeight_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumItemRep.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub

    Private Sub BakWorkItemLod_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BakWorkItemLod.DoWork
    End Sub
    Private Sub MoveRow(ByVal i As Integer)
        Try
            If (Me.Grid.SelectedCells.Count > 0) Then
                Dim curr_index As Integer = Me.Grid.CurrentCell.RowIndex
                Dim curr_col_index As Integer = Me.Grid.CurrentCell.ColumnIndex
                Dim curr_row As DataGridViewRow = Me.Grid.CurrentRow
                'Me.Grid.Rows.GetNextRow(i)
                Me.Grid.Rows.Insert(curr_index + i, curr_row)
                Me.Grid.CurrentCell = Me.Grid(curr_col_index, curr_index + i)
            End If
        Catch ex As Exception

            '  MsgBox("First Record cannot be Moved Up")
            ' do nothing if error encountered while trying to move the row up or down
        End Try
    End Sub

    Private Sub btnNextItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextItem.Click
        If Grid.CurrentRow.Index <> Grid.Rows.Count Then
            Grid.Rows(Grid.CurrentRow.Index + 1).Selected = True
        End If
    End Sub
    Private Sub cmbCountry_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter = True Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub
    Private Sub lblBarCode_CheckedChanged(sender As Object, e As EventArgs) Handles lblBarCode.CheckedChanged
        If lblBarCode.Checked = False Then
            txtBarCode.Enabled = False
            txtBarCode.BackColor = Color.LightGray
        ElseIf lblBarCode.Checked = True Then
            txtBarCode.BackColor = Color.Chartreuse
            txtBarCode.Enabled = True
        End If
    End Sub

    Private Sub lblPhoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblPhoto.LinkClicked

    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub
End Class