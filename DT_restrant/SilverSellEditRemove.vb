Imports PACICardLibrary

Public Class SilverSellEditRemove
    'Dim GetSettingsData As DataTable
    Dim EditControl As Boolean = False
    Public GetSettingsData As DataTable = GetRecordSet("SELECT * from Settings")
    Public Sub Count()
        Dim TotalPrice As Decimal
        For i As Integer = 0 To grid.RowCount - 1
            TotalPrice += grid.Rows(i).Cells("colitem_totalPrice").Value
        Next
        'txtPriceRequired.Text = TotalPrice
    End Sub
    Private Sub DeleteInvoice()
        GlCommand.CommandText = "UPDATE [SilverBAY] SET [Active] ='0' WHERE [BAY_SARYAL] = '" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [SilverInvoceDetels] SET [Active] ='0' WHERE invoc_time='" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
    End Sub
    Private Sub GetItemData()
        dtItemData = GetRecordSet("SELECT [ID] ,[userID] ,[FO_name] ,[FO_desp] ,[FO_price] ,[FO_GramPrice] ,[FO_gram] ," &
                                  "[FO_gramMade] ,[FO_made] ,[FO_extras] ,[FO_totalPrice] ,[Gram_valu] ,[ITEM_IMGE] ," &
                                  "[date_care] ,[FO_ItemNo] ,[StoneColor1] ,[StonePrice1] ,[StoneWeight2] ,[StoneName2] " &
                                  ",[StoneColor2] ,[StonePrice2] ,[StoneWeight3] ,[StoneName3] ,[StoneColor3] ,[StonePrice3] " &
                                  ",[Qty] ,[BarCode] ,[Item_Actv] FROM [SilverItem] WHERE [BarCode] = N'" & txtBarCode.Text.Trim & "' AND (Item_Actv = 1)")
        txtMetalWeight.Text = dtItemData.Rows(0)("FO_gram").ToString
        txtMakeCharge.Text = dtItemData.Rows(0)("FO_gramMade").ToString
        txtKarat.Text = dtItemData.Rows(0)("Gram_valu").ToString
        txtQty.Text = If(dtItemData.Rows(0)("Qty").ToString = "", "1", dtItemData.Rows(0)("Qty").ToString)
        txtCostPerItem.Text = Val(dtItemData.Rows(0)("FO_totalPrice").ToString)
        cmbStoneName1.Text = dtItemData.Rows(0)("FO_price").ToString
        txtStoneWeight1.Text = dtItemData.Rows(0)("FO_extras").ToString
        txtStoneColor1.Text = dtItemData.Rows(0)("StoneColor1").ToString
        txtStonePrice1.Text = dtItemData.Rows(0)("StonePrice1").ToString
        cmbStoneName2.Text = dtItemData.Rows(0)("StoneName2").ToString
        txtStoneWeight2.Text = dtItemData.Rows(0)("StoneWeight2").ToString
        txtStoneColor2.Text = dtItemData.Rows(0)("StoneColor2").ToString
        txtStonePrice2.Text = dtItemData.Rows(0)("StonePrice2").ToString
        cmbStoneName3.Text = dtItemData.Rows(0)("StoneName3").ToString
        txtStoneWeight3.Text = dtItemData.Rows(0)("StoneWeight3").ToString
        txtStoneColor3.Text = dtItemData.Rows(0)("StoneColor3").ToString
        txtStonePrice3.Text = dtItemData.Rows(0)("StonePrice3").ToString
        txtItemNmeInInvoce.Text = dtItemData.Rows(0)("FO_name").ToString
        'If SET_INVARCHR169TextBox.Text = "1" Then
        'txtStoneWeight1.Text = Format(Val(txtStoneWeight1.Text), "0.00")
        'txtStoneWeight2.Text = Format(Val(txtStoneWeight2.Text), "0.00")
        'txtStoneWeight3.Text = Format(Val(txtStoneWeight3.Text), "0.00")
        'txtMetalWeight.Text = Format(Val(txtMetalWeight.Text), "0.00")
        'txtMakeCharge.Text = Format(Val(txtMakeCharge.Text), "0.000")
        'End If
        If GoldOrSilver = False Then
            txtMetalPrice.Text = txtMakeCharge.Text
        End If
    End Sub
    Private Sub GetGramPrice()
        If txtKarat.Text = "24" Then
            txtPricePerGram.Text = frmMain.lbl24.Text
        ElseIf txtKarat.Text = "22" Then
            txtPricePerGram.Text = frmMain.lbl22.Text
        ElseIf txtKarat.Text = "21" Then
            txtPricePerGram.Text = frmMain.lbl21.Text
        ElseIf txtKarat.Text = "18" Then
            txtPricePerGram.Text = frmMain.lbl18.Text
        ElseIf txtKarat.Text = "925" Then
            txtPricePerGram.Text = frmMain.lblSilver925.Text
        ElseIf Val(txtKarat.Text) >= "700" Then
            txtPricePerGram.Text = Math.Round(Val(frmMain.lblSilver925.Text) * Val(txtKarat.Text) / 925, 3)
        End If
    End Sub
    Private Sub GetMetalPrice()
        txtMetalPrice.Text = If(Val(txtMetalWeight.Text) = 0, "", Math.Round((Val(txtMakeCharge.Text) + Val(txtPricePerGram.Text)) * Val(txtMetalWeight.Text), 3))
    End Sub
    Private Sub StoneAsGoldPrice()
        'If SET_INVARCHR168TextBox.Text = "1" Then 'If StoneAsGold is Enabled
        If cmbStoneName1.SelectedValue = True Then
            txtStonePrice1.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight1.Text)
        End If
        If cmbStoneName2.SelectedValue = True Then
            txtStonePrice2.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight2.Text)
        End If
        If cmbStoneName3.SelectedValue = True Then
            txtStonePrice3.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight3.Text)
        End If
        'End If
    End Sub
    Private Sub GetTotalPrice()
        If Val(txtMetalPrice.Text) = 0 Then
            txtTotalPrice.Text = ""
            Exit Sub
        End If
        txtTotalPrice.Text = Math.Round(Val(txtMetalPrice.Text) + Val(txtStonePrice1.Text) + Val(txtStonePrice2.Text) + Val(txtStonePrice3.Text), 3)
    End Sub

    Public Sub txtBarCodeTextChanged()
        'ClearControls(pnlInvoice)
        Try
            cmbItem.SelectedValue = txtBarCode.Text.Trim
        Catch ex As Exception
            cmbItem.SelectedIndex = -1
        End Try
        If txtBarCode.Text = "" OrElse cmbItem.SelectedValue = Nothing Then
            cmbItem.SelectedIndex = -1
            'ClearControls(pnlInvoice)
            txtQty.Text = "1"
            txtNotes.Text = ""
            Exit Sub
        End If
        Try
            GetItemData()
            If txtKarat.Text = "" Then txtPricePerGram.Text = ""
            If Notes <> "" Then txtNotes.Text = Notes
            txtMetalPrice.Text = If(Val(txtMetalWeight.Text) = 0, "", Math.Round((Val(txtMakeCharge.Text) + Val(txtPricePerGram.Text)) * Val(txtMetalWeight.Text), 3))
            'GetItemData()
            GetGramPrice()
            GetMetalPrice()
            StoneAsGoldPrice()
            GetTotalPrice()
        Catch ex As Exception
            txtBarCode.Select()
        End Try
    End Sub
    Public saryil As Integer
    Private InvoiceNo As String
    Public Notes As String
    Dim dtItemData As DataTable
    Public DataGetFromSet As DataTable = GetRecordSet("SELECT * from Settings")
    Dim GetMakChar As Decimal
    Private Sub GetPricePerGram()
        If txtKarat.Text.Trim = "24" Then
            txtPricePerGram.Text = frmMain.lbl24.Text.Trim
        ElseIf txtKarat.Text.Trim = "22" Then
            txtPricePerGram.Text = frmMain.lbl22.Text.Trim
        ElseIf txtKarat.Text.Trim = "21" Then
            txtPricePerGram.Text = frmMain.lbl21.Text.Trim
        ElseIf txtKarat.Text.Trim = "18" Then
            txtPricePerGram.Text = frmMain.lbl18.Text.Trim
        End If
    End Sub
    Private Function CalculateTotalGridPrice() As Decimal
        grid.Refresh()
        CalculateTotalGridPrice = 0
        For i As Integer = 0 To grid.RowCount - 1
            CalculateTotalGridPrice += grid.Rows(i).Cells("colItemTotalPrice").Value
        Next
        Return Math.Round(CalculateTotalGridPrice, 3)
    End Function
    Public Sub GoldInvoiceLoad()
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As Integer = GetSettingsData.Rows(0)("SET_INVARCHR151").ToString
            If ItemSoldActiv = "1" Then
                Dim dt1 As DataTable = GetRecordSet("SELECT FO_name,BarCode FROM  dbo.SilverItem GROUP BY FO_name, BarCode, ID HAVING (SUM(Item_Actv) = 1) ORDER BY ID")
                cmbItem.DataBindings.Clear()
                cmbItem.DisplayMember = "FO_Name"
                cmbItem.ValueMember = "BarCode"
                cmbItem.DataSource = dt1
            Else
                Dim dt1 As DataTable = GetRecordSet("SELECT dbo.SilverItem.FO_name, dbo.SilverItem.BarCode " & vbCrLf &
                                                    "FROM dbo.SilverItem LEFT OUTER JOIN " & vbCrLf &
                                                    "dbo.SilverInvoceDetels ON dbo.SilverItem.BarCode = dbo.SilverInvoceDetels.itemID " & vbCrLf &
                                                    "WHERE  (dbo.SilverInvoceDetels.itemID IS NULL) OR " & vbCrLf &
                                                    "(dbo.SilverItem.Gram_valu <= '24') AND (dbo.SilverInvoceDetels.Active = 0) " & vbCrLf &
                                                    "GROUP BY dbo.SilverItem.FO_name, dbo.SilverItem.BarCode, dbo.SilverItem.ID " & vbCrLf &
                                                    "HAVING(SUM(dbo.SilverItem.Item_Actv) = 1) " & vbCrLf &
                                                    "ORDER BY dbo.SilverItem.ID ")
                cmbItem.DataBindings.Clear()
                cmbItem.DisplayMember = "FO_Name"
                cmbItem.ValueMember = "BarCode"
                cmbItem.DataSource = dt1
            End If
        End If
    End Sub

    Public Sub AddNewItemInDataGred()
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As Integer = GetSettingsData.Rows(0)("SET_INVARCHR151").ToString
            If ItemSoldActiv = "1" Then
                Dim DT As DataTable = GetRecordSet("SELECT  ItemID, SUM(Active) AS Active FROM dbo.SilverInvoceDetels GROUP BY ItemID  HAVING  [ItemID] = N'" & txtBarCode.Text.Trim & "'")
                If DT.Rows.Count > 0 Then
                    Dim QunChked As Integer = DT.Rows(0)("Active").ToString
                    If QunChked >= 1 Then
                        MsgBox("تم بيع القطعة من قبل" & vbCrLf & "Item sold.", , AppTitle)
                        Exit Sub
                    End If
                Else
                End If
            Else
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim GetItemActvDB As DataTable = GetRecordSet("SELECT BarCode, SUM(Item_Actv) AS Item_Actv FROM dbo.SilverItem GROUP BY BarCode HAVING (BarCode = N'" & txtBarCode.Text.Trim & "')")
        If GetItemActvDB.Rows.Count > 0 Then
            Dim GetItemActv As Integer = GetItemActvDB.Rows(0)("Item_Actv").ToString
            If GetItemActv = 0 Then
                MsgBox("لقد تم حزف الصنف مسبقا من قائمة الاصناف" & vbCrLf & "The item has been removed from the list of items entered", , "خطأ")
                txtBarCode.Text = ""
                txtBarCode.Text = ""
                Exit Sub
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If
        If cmbCashier.Items.Count = 1 AndAlso cmbCashier.SelectedIndex <> 0 Then
            cmbCashier.ResetText()
            cmbCashier.SelectedIndex = -1
            cmbCashier.SelectedIndex = 0
        End If
        If cmbCashier.SelectedIndex - 1 OrElse cmbCashier.Text = "Select Cashier" Then
            MsgBox("اسم الكاشير لم يتم إدخاله" & vbCrLf & "Please Select Cashier", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        If cmbCashier.SelectedIndex = -1 Then
            MsgBox("اختر كاشيرًا من الموجودين..لا تكتب كاشيرًا جديدًا" & vbCrLf & "Please Select Cashier, Don't Enter Manually", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        If cmbItem.Text = "اختر اسم الصنف" OrElse cmbItem.Text = "Select Item" Then
            MsgBox("اختر صنفًا" & vbCrLf & "Please Select an Item", , "خطأ")
            cmbItem.DroppedDown = True
            Exit Sub
        End If

        If cmbItem.SelectedIndex = -1 Then
            MsgBox("اختر صنفًا من المخزن..لا تكتب صنفًا" & vbCrLf & "Please Select an Item, Don't Enter Manually", , "خطأ")
            cmbItem.DroppedDown = True
            Exit Sub
        End If

        If Val(txtMetalWeight.Text) = 0 Then
            MsgBox("أدخل وزنًا" & vbCrLf & "Please Enter Weight", , "خطأ")
            txtMetalWeight.Focus()
            txtMetalWeight.SelectAll()
            Exit Sub
        End If

        If Val(txtPricePerGram.Text) = 0 Then
            MsgBox("أدخل سعر الجرام" & vbCrLf & "Please Enter Gram Price", , "خطأ")
            txtPricePerGram.Focus()
            txtPricePerGram.SelectAll()
            Exit Sub
        End If

        If Val(txtMetalPrice.Text) = 0 Then
            MsgBox("أدخل السعر" & vbCrLf & "Please Enter Price", , "خطأ")
            txtMetalPrice.Focus()
            txtMetalPrice.SelectAll()
            Exit Sub
        End If
        If Val(txtTotalPrice.Text) <= 0 Then
            MsgBox("أدخل السعر" & vbCrLf & "Please Enter Price", , "خطأ")
            txtTotalPrice.Focus()
            'txtTotalPrice.Text.SelectAll()
            Exit Sub
        End If

        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As Integer = GetSettingsData.Rows(0)("SET_INVARCHR151").ToString
            If ItemSoldActiv = "1" Then
                For i As Integer = 0 To grid.RowCount - 1
                    If txtBarCode.Text.Trim = grid.Rows(i).Cells("colItemID").Value.ToString.Trim Then
                        MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , AppTitle)
                        Exit Sub
                    End If
                Next
            End If
        End If
        '
        If DataGetFromSet.Rows.Count > 0 Then
            Dim DataGet As Integer = DataGetFromSet.Rows(0)("SET4").ToString
            If DataGet = 1 Then
                If txtMakeCharge.Text <= 0 Then
                    MsgBox("قيمة المصنعيه اقل او تساوي صفر " & vbCrLf & "Error in Data Entry..", , AppTitle)
                    Exit Sub
                End If
            End If
        End If
        For i As Integer = 0 To grid.RowCount - 1
            If txtBarCode.Text.Trim = grid.Rows(i).Cells("colItemID").Value.ToString.Trim Then
                'MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , AppTitle)
                If MsgBox("صنف سبق بيعه اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Item Already Sold..Click OK to Add Again or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, " Item Already Sold..Click OK to Add Again or Cancel. صنف سبق بيعه اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Item Already Sold..Click OK to Add Again or Cancel.") = MsgBoxResult.Ok Then
                    Beep()
                Else
                    Exit Sub
                End If
            End If
        Next
        Try

            With (grid)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colID").Value = txtInvoiceNo.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
                .Rows(.Rows.Count - 1).Cells("colcacher").Value = If(IsDBNull(cmbCashier.SelectedValue), grid.SelectedRows(0).Cells("colcacher").Value, (cmbCashier.SelectedValue))
                .Rows(.Rows.Count - 1).Cells("colItemID").Value = dtItemData.Rows(0)("BarCode").ToString
                .Rows(.Rows.Count - 1).Cells("coluserID").Value = frmLogin.User_nameTextBox.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colItemName").Value = If(txtItemNmeInInvoce.Text.Trim = "", cmbItem.Text.Trim, txtItemNmeInInvoce.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("coldate").Value = CDate(dtpInvoiceDate.Value)
                .Rows(.Rows.Count - 1).Cells("colInvocDateTime").Value = Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss tt")
                .Rows(.Rows.Count - 1).Cells("colSroomName").Value = frmMain.lblCompanyName.Text
                .Rows(.Rows.Count - 1).Cells("colNots").Value = txtNotes.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colItemCantrey").Value = dtItemData.Rows(0)("FO_made").ToString
                .Rows(.Rows.Count - 1).Cells("colItemTotalPrice").Value = txtTotalPrice.Text.Trim
                'STON1'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Rows(.Rows.Count - 1).Cells("colStonName1").Value = cmbStoneName1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonWeight1").Value = Val(txtStoneWeight1.Text)
                .Rows(.Rows.Count - 1).Cells("colStonColor1").Value = txtStoneColor1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonPrice1").Value = Val(txtStonePrice1.Text)
                .Rows(.Rows.Count - 1).Cells("colStonePriceType1").Value = If(cmbStoneName1.SelectedIndex = -1, "0", If(cmbStoneName1.SelectedValue = True, 1, 0))
                'STON2'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Rows(.Rows.Count - 1).Cells("colStonName2").Value = cmbStoneName2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonWeight2").Value = Val(txtStoneWeight2.Text)
                .Rows(.Rows.Count - 1).Cells("colStonColor2").Value = txtStoneColor2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonPrice2").Value = Val(txtStonePrice2.Text)
                .Rows(.Rows.Count - 1).Cells("colStonePriceType2").Value = If(cmbStoneName2.SelectedIndex = -1, "0", If(cmbStoneName2.SelectedValue = True, 1, 0))
                'STON3'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Rows(.Rows.Count - 1).Cells("colStonName3").Value = cmbStoneName3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonWeight3").Value = Val(txtStoneWeight3.Text)
                .Rows(.Rows.Count - 1).Cells("colStonColor3").Value = txtStoneColor3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colStonPrice3").Value = Val(txtStonePrice3.Text)
                .Rows(.Rows.Count - 1).Cells("colStonePriceType3").Value = If(cmbStoneName3.SelectedIndex = -1, "0", If(cmbStoneName3.SelectedValue = True, 1, 0))
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .Rows(.Rows.Count - 1).Cells("colGoldWeight").Value = Val(txtMetalWeight.Text)
                .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = Val(txtPricePerGram.Text)
                .Rows(.Rows.Count - 1).Cells("colGoledPrice").Value = Val(txtMetalPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colGoledKarat").Value = txtKarat.Text
                .Rows(.Rows.Count - 1).Cells("colGoledMakeCharge").Value = Val(txtMakeCharge.Text)
                .Rows(.Rows.Count - 1).Cells("colGoledPiecesQuantity").Value = Val(txtQty.Text)
                .Rows(.Rows.Count - 1).Cells("colGoledPurchasPrice").Value = If(IsDBNull(txtCostPerItem.Text.Trim), "0", Val(txtCostPerItem.Text))
                .Rows(.Rows.Count - 1).Cells("colGoledMakeCharge").Value = Val(txtMakeCharge.Text)
                .Rows(.Rows.Count - 1).Cells("colTotalGoledPrice").Value = Val(txtTotalPrice.Text)
            End With
            grid.CurrentCell = grid(0, grid.Rows.Count - 1)
            GlCommand.CommandText = "INSERT INTO [SilverInvoceDetels]" &
           "([Castomerid]" &
           ",[ItemID]" &
           ",[userID]" &
           ",[item_name]" &
           ",[item_desp]" &
           ",[item_GramPrice]" &
           ",[item_gram]" &
           ",[item_gramMade]" &
           ",[item_totalPrice]" &
           ",[item_cantrey]" &
           ",[cacher]" &
           ",[date]" &
           ",[invoc_date_time]" &
           ",[Cash]" &
           ",[qunt]" &
           ",[sroom_name]" &
           ",[invoc_time]" &
           ",[item_extrasMAZAN]" &
           ",[StoneName1]" &
           ",[StoneColor1]" &
           ",[item_extrasPRICE]" &
           ",[StonePriceType1]" &
           ",[StoneWeight2]" &
           ",[StoneName2]" &
           ",[StoneColor2]" &
           ",[StonePrice2]" &
           ",[StonePriceType2]" &
           ",[StoneWeight3]" &
           ",[StoneName3]" &
           ",[StoneColor3]" &
           ",[StonePrice3]" &
           ",[StonePriceType3]" &
           ",[GoledKarat]" &
           ",[MetalPrice]" &
           ",[Active])" &
           "VALUES" &
           "(@Castomerid" &
           ",@ItemID" &
           ",@userID" &
           ",@item_name" &
           ",@item_desp" &
           ",@item_GramPrice" &
           ",@item_gram" &
           ",@item_gramMade" &
           ",@item_totalPrice" &
           ",@item_cantrey" &
           ",@cacher" &
           ",@date" &
           ",@invoc_date_time" &
           ",@Cash" &
           ",@qunt" &
           ",@sroom_name" &
           ",@invoc_time" &
           ",@item_extrasMAZAN" &
           ",@StoneName1" &
           ",@StoneColor1" &
           ",@item_extrasPRICE" &
           ",@StonePriceType1" &
           ",@StoneWeight2" &
           ",@StoneName2" &
           ",@StoneColor2" &
           ",@StonePrice2" &
           ",@StonePriceType2" &
           ",@StoneWeight3" &
           ",@StoneName3" &
           ",@StoneColor3" &
           ",@StonePrice3" &
           ",@StonePriceType3" &
           ",@GoledKarat" &
           ",@MetalPrice" &
           ",@Active)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@Castomerid", CivilIDForm.txtCID.Text.Trim)
                .AddWithValue("@ItemID", grid.SelectedRows(0).Cells("colItemID").Value)
                .AddWithValue("@userID", frmLogin.User_nameTextBox.Text.Trim)
                .AddWithValue("@item_name", grid.SelectedRows(0).Cells("colItemName").Value)
                .AddWithValue("@item_desp", grid.SelectedRows(0).Cells("colGoledPurchasPrice").Value)
                .AddWithValue("@item_GramPrice", grid.SelectedRows(0).Cells("colGramPrice").Value)
                .AddWithValue("@item_gram", grid.SelectedRows(0).Cells("colGoldWeight").Value)
                .AddWithValue("@item_gramMade", grid.SelectedRows(0).Cells("colGoledMakeCharge").Value)
                .AddWithValue("@item_totalPrice", grid.SelectedRows(0).Cells("colTotalGoledPrice").Value)
                .AddWithValue("@item_cantrey", grid.SelectedRows(0).Cells("colItemCantrey").Value)
                .AddWithValue("@cacher", grid.SelectedRows(0).Cells("colcacher").Value)
                .AddWithValue("@date", grid.SelectedRows(0).Cells("coldate").Value)
                .AddWithValue("@invoc_date_time", grid.SelectedRows(0).Cells("colInvocDateTime").Value)
                .AddWithValue("@Cash", grid.SelectedRows(0).Cells("coldate").Value)
                .AddWithValue("@qunt", grid.SelectedRows(0).Cells("colGoledPiecesQuantity").Value)
                .AddWithValue("@sroom_name", grid.SelectedRows(0).Cells("colSroomName").Value)
                .AddWithValue("@invoc_time", txtInvoiceNo.Text.Trim)
                .AddWithValue("@item_extrasMAZAN", grid.SelectedRows(0).Cells("colStonWeight1").Value)
                .AddWithValue("@StoneName1", grid.SelectedRows(0).Cells("colStonName1").Value)
                .AddWithValue("@StoneColor1", grid.SelectedRows(0).Cells("colStonColor1").Value)
                .AddWithValue("@item_extrasPRICE", grid.SelectedRows(0).Cells("colStonPrice1").Value)
                .AddWithValue("@StonePriceType1", grid.SelectedRows(0).Cells("colStonePriceType1").Value)
                .AddWithValue("@StoneWeight2", grid.SelectedRows(0).Cells("colStonWeight2").Value)
                .AddWithValue("@StoneName2", grid.SelectedRows(0).Cells("colStonName2").Value)
                .AddWithValue("@StoneColor2", grid.SelectedRows(0).Cells("colStonColor2").Value)
                .AddWithValue("@StonePrice2", grid.SelectedRows(0).Cells("colStonPrice2").Value)
                .AddWithValue("@StonePriceType2", grid.SelectedRows(0).Cells("colStonePriceType2").Value)
                .AddWithValue("@StoneWeight3", grid.SelectedRows(0).Cells("colStonWeight3").Value)
                .AddWithValue("@StoneName3", grid.SelectedRows(0).Cells("colStonName3").Value)
                .AddWithValue("@StoneColor3", grid.SelectedRows(0).Cells("colStonColor3").Value)
                .AddWithValue("@StonePrice3", grid.SelectedRows(0).Cells("colStonPrice3").Value)
                .AddWithValue("@StonePriceType3", grid.SelectedRows(0).Cells("colStonePriceType3").Value)
                .AddWithValue("@GoledKarat", grid.SelectedRows(0).Cells("colGoledKarat").Value)
                .AddWithValue("@MetalPrice", grid.SelectedRows(0).Cells("colGoledPrice").Value)
                .AddWithValue("@Active", "1")
            End With
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = ("UPDATE [SilverInvoceDetels]SET [nots] =N'" & SilverInvoice.txtNotes.Text.Trim & "' WHERE  [invoc_time]='" & txtInvoiceNo.Text.Trim & "'")
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = ("UPDATE [SilverInvoceDetels]SET [Castomerid] =N'" & CivilIDForm.txtCID.Text.Trim & "' WHERE  [invoc_time]='" & txtInvoiceNo.Text.Trim & "'")
            GlCommand.ExecuteNonQuery()


            Try
                If txtNotes.Text <> "" Then Notes = txtNotes.Text
                txtTotalPriceValue.Text = CalculateTotalGridPrice()
                MsgBox("تم إضافة الصنف " & vbCrLf & "Item Added successfully", , AppTitle)
                dtpInvoiceDate.Enabled = False
                btnPayPrint.Visible = True
                grid.Visible = True
                If txtNotes.Text.Trim <> "" Then Notes = txtNotes.Text.Trim
                txtBarCode.Text = ""
                txtTotalPrice.Text = ""
                txtTotalPriceValue.Clear()
                txtTotalPriceValue.Text = CalculateTotalGridPrice()
            Catch ex As Exception
                MsgBox("خطأ بعض الحقول المهمة فارغة" & vbCrLf & "Error in Data Entry..", , AppTitle)
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            ex.ToString()
        End Try
        txtItemNmeInInvoce.Text = ""
        Try
            If GetSettingsData.Rows.Count > 0 Then
                txtBarCode.SelectedText = GetSettingsData.Rows(0)("DefaultBarcode").ToString
            Else
                txtBarCode.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FillDataGred()
        Dim GetInvoceDetels As DataTable = GetRecordSet("select * from ViwSilverInvoceReport where[invoc_time] ='" & txtInvoiceNo.Text.Trim & "' AND Active='1'")
        If GetInvoceDetels.Rows.Count > 0 Then
            For i As Integer = 0 To GetInvoceDetels.Rows.Count - 1
                With (grid)
                    .Rows.Add()
                    .Rows(.Rows.Count - 1).Cells("colID").Value = GetInvoceDetels.Rows(i)("ID").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemID").Value = GetInvoceDetels.Rows(i)("ItemID").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemName").Value = GetInvoceDetels.Rows(i)("item_name").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoldWeight").Value = GetInvoceDetels.Rows(i)("item_gram").ToString
                    .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = GetInvoceDetels.Rows(i)("item_GramPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledPrice").Value = GetInvoceDetels.Rows(i)("item_GramPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledKarat").Value = GetInvoceDetels.Rows(i)("GoledKarat").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledMakeCharge").Value = GetInvoceDetels.Rows(i)("item_gramMade").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledPiecesQuantity").Value = GetInvoceDetels.Rows(i)("qunt").ToString
                    .Rows(.Rows.Count - 1).Cells("colTotalGoledPrice").Value = GetInvoceDetels.Rows(i)("MetalPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colTotalbillamount").Value = GetInvoceDetels.Rows(i)("TOTAL_mony").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemTotalPrice").Value = GetInvoceDetels.Rows(i)("item_totalPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colInvocDateTime").Value = GetInvoceDetels.Rows(i)("invoc_date_time").ToString
                    .Rows(.Rows.Count - 1).Cells("colNots").Value = GetInvoceDetels.Rows(i)("nots").ToString
                    .Rows(.Rows.Count - 1).Cells("colcacher").Value = GetInvoceDetels.Rows(i)("cacher").ToString

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'STON1() '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName1").Value = GetInvoceDetels.Rows(i)("StoneName1").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight1").Value = GetInvoceDetels.Rows(i)("item_extrasMAZAN").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor1").Value = GetInvoceDetels.Rows(i)("StoneColor1").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice1").Value = GetInvoceDetels.Rows(i)("item_extrasPRICE").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType1").Value = If(cmbStoneName1.SelectedIndex = -1, "0", If(cmbStoneName1.SelectedValue = True, 1, 0))
                    'STON2'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName2").Value = GetInvoceDetels.Rows(i)("StoneName2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight2").Value = GetInvoceDetels.Rows(i)("StoneWeight2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor2").Value = GetInvoceDetels.Rows(i)("StoneColor2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice2").Value = GetInvoceDetels.Rows(i)("StonePrice2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType2").Value = If(cmbStoneName2.SelectedIndex = -1, "0", If(cmbStoneName2.SelectedValue = True, 1, 0))
                    'STON3'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName3").Value = GetInvoceDetels.Rows(i)("StoneName3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight3").Value = GetInvoceDetels.Rows(i)("StoneWeight3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor3").Value = GetInvoceDetels.Rows(i)("StoneColor3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice3").Value = GetInvoceDetels.Rows(i)("StonePrice3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType3").Value = If(cmbStoneName3.SelectedIndex = -1, "0", If(cmbStoneName3.SelectedValue = True, 1, 0))
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                End With
            Next
        End If
    End Sub
    Private Sub GetInvoiceNumber()
        Dim dt1 As DataTable = GetRecordSet("SELECT  BAY_SARYAL FROM SilverBAY WHERE (Active = 1) ORDER BY BAY_ID DESC")
        If dt1.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = dt1)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "BAY_SARYAL")
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.ValueMember = "BAY_SARYAL")
        End If
    End Sub
    Private Sub Get_Casher_Data()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM cacher where Active=1")
            If DT.Rows.Count > 0 Then
                cmbCashier.DataSource = DT
                cmbCashier.DisplayMember = "cacher_name"
                cmbCashier.ValueMember = "svil_id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub GetStoneName1()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] , [AsGold] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStoneName1.DataSource = dt1
            cmbStoneName1.DisplayMember = "EXTR_NAME"
            cmbStoneName1.ValueMember = "AsGold"
        End If
    End Sub
    Private Sub GetStoneName2()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] , [AsGold] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStoneName2.DataSource = dt1
            cmbStoneName2.DisplayMember = "EXTR_NAME"
            cmbStoneName2.ValueMember = "AsGold"
        End If
    End Sub
    Private Sub GetStoneName3()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] , [AsGold] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStoneName3.DataSource = dt1
            cmbStoneName3.DisplayMember = "EXTR_NAME"
            cmbStoneName3.ValueMember = "AsGold"
        End If
    End Sub
    Private Sub GetInvoiceData()
        grid.Rows.Clear()
        Dim GetInvoceDetels As DataTable = GetRecordSet("select * from ViwSilverInvoceReport where[invoc_time] ='" & txtInvoiceNo.Text.Trim & "' AND Active='1'")
        If GetInvoceDetels.Rows.Count > 0 Then
            txtNotes.Text = GetInvoceDetels.Rows(0)("nots").ToString
            dtpInvoiceDate.Value = CDate(GetInvoceDetels.Rows(0)("date").ToString)
            CivilIDForm.txtCID.Text = GetInvoceDetels.Rows(0)("Castomerid").ToString
            cmbCashier.SelectedValue = (GetInvoceDetels.Rows(0)("cacher").ToString)
            txtCash.Text = (GetInvoceDetels.Rows(0)("CACH").ToString)
            txtKnet.Text = (GetInvoceDetels.Rows(0)("KENT").ToString)
            cmbPayMethod.SelectedValue = (GetInvoceDetels.Rows(0)("PayMethod").ToString)
            txtBank1.Text = (GetInvoceDetels.Rows(0)("Bank1").ToString)
            txtBank2.Text = (GetInvoceDetels.Rows(0)("Bank2").ToString)
            txtBank3.Text = (GetInvoceDetels.Rows(0)("Bank3").ToString)
            txtBank4.Text = (GetInvoceDetels.Rows(0)("Bank4").ToString)
            txtTotalPriceValue.Text = (GetInvoceDetels.Rows(0)("TOTAL_mony").ToString)
            cmbPayMethod1.SelectedValue = (GetInvoceDetels.Rows(0)("PayMethod1").ToString)
            cmbPayMethod2.SelectedValue = (GetInvoceDetels.Rows(0)("PayMethod2").ToString)
            cmbPayMethod3.SelectedValue = (GetInvoceDetels.Rows(0)("PayMethod3").ToString)
            cmbPayMethod4.SelectedValue = (GetInvoceDetels.Rows(0)("PayMethod4").ToString)
            For i As Integer = 0 To GetInvoceDetels.Rows.Count - 1
                With (grid)
                    .Rows.Add()
                    .Rows(.Rows.Count - 1).Cells("colItemTpID").Value = GetInvoceDetels.Rows(i)("ID").ToString
                    .Rows(.Rows.Count - 1).Cells("colID").Value = GetInvoceDetels.Rows(i)("invoc_time").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemID").Value = GetInvoceDetels.Rows(i)("ItemID").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemName").Value = GetInvoceDetels.Rows(i)("item_name").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoldWeight").Value = GetInvoceDetels.Rows(i)("item_gram").ToString
                    .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = GetInvoceDetels.Rows(i)("item_GramPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledPrice").Value = GetInvoceDetels.Rows(i)("item_GramPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledKarat").Value = GetInvoceDetels.Rows(i)("GoledKarat").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledMakeCharge").Value = GetInvoceDetels.Rows(i)("item_gramMade").ToString
                    .Rows(.Rows.Count - 1).Cells("colGoledPiecesQuantity").Value = GetInvoceDetels.Rows(i)("qunt").ToString
                    .Rows(.Rows.Count - 1).Cells("colTotalGoledPrice").Value = GetInvoceDetels.Rows(i)("MetalPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colTotalbillamount").Value = GetInvoceDetels.Rows(i)("TOTAL_mony").ToString
                    .Rows(.Rows.Count - 1).Cells("colItemTotalPrice").Value = GetInvoceDetels.Rows(i)("item_totalPrice").ToString
                    .Rows(.Rows.Count - 1).Cells("colInvocDateTime").Value = GetInvoceDetels.Rows(i)("invoc_date_time").ToString
                    .Rows(.Rows.Count - 1).Cells("colNots").Value = GetInvoceDetels.Rows(i)("nots").ToString
                    .Rows(.Rows.Count - 1).Cells("colcacher").Value = GetInvoceDetels.Rows(i)("cacher").ToString

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    'STON1() '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName1").Value = GetInvoceDetels.Rows(i)("StoneName1").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight1").Value = GetInvoceDetels.Rows(i)("item_extrasMAZAN").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor1").Value = GetInvoceDetels.Rows(i)("StoneColor1").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice1").Value = GetInvoceDetels.Rows(i)("item_extrasPRICE").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType1").Value = If(cmbStoneName1.SelectedIndex = -1, "0", If(cmbStoneName1.SelectedValue = True, 1, 0))
                    'STON2'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName2").Value = GetInvoceDetels.Rows(i)("StoneName2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight2").Value = GetInvoceDetels.Rows(i)("StoneWeight2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor2").Value = GetInvoceDetels.Rows(i)("StoneColor2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice2").Value = GetInvoceDetels.Rows(i)("StonePrice2").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType2").Value = If(cmbStoneName2.SelectedIndex = -1, "0", If(cmbStoneName2.SelectedValue = True, 1, 0))
                    'STON3'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    .Rows(.Rows.Count - 1).Cells("colStonName3").Value = GetInvoceDetels.Rows(i)("StoneName3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonWeight3").Value = GetInvoceDetels.Rows(i)("StoneWeight3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonColor3").Value = GetInvoceDetels.Rows(i)("StoneColor3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonPrice3").Value = GetInvoceDetels.Rows(i)("StonePrice3").ToString
                    .Rows(.Rows.Count - 1).Cells("colStonePriceType3").Value = If(cmbStoneName3.SelectedIndex = -1, "0", If(cmbStoneName3.SelectedValue = True, 1, 0))
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                End With
            Next
            txtTotalPriceValue.Text = CalculateTotalGridPrice()
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Public Sub PerformSearch()
        If txtInvoiceNo.Text.Trim = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        Try
            btnPayPrint.Visible = True
            GetInvoiceData()
            If grid.RowCount <> 0 Then
                btnPayPrint.Enabled = True
                grid.Enabled = True
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                txtCash.Text = ""
                txtKnet.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Public Function CalculatePriceDifference() As Decimal
        On Error Resume Next
        CalculatePriceDifference = Math.Round((Val(txtBank1.Text) + (txtBank2.Text) + (txtBank3.Text) + (txtBank4.Text) + (txtKnet.Text) + (txtCash.Text)), 3)
        txtPriceReturn.Text = Math.Round(CalculatePriceDifference - Val(txtTotalPriceValue.Text), 3)
        If Val(txtPriceReturn.Text) > 0 Then
            lblReturn.Text = If(frmLogin.rbtnAr.Checked = True, "ارجع الي العميل", "Return To Clients")
        ElseIf Val(txtPriceReturn.Text) < 0 Then
            lblReturn.Text = If(frmLogin.rbtnAr.Checked = True, "مطلوب من العميل", "Required Rrom The Client")
        End If
        Return CalculatePriceDifference
        Beep()
    End Function
    Private Sub GetPayMethodSelect()
        Dim DT1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT2 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT3 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT4 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If DT1.Rows.Count > 0 Then
            cmbPayMethod1.DataSource = DT1
            cmbPayMethod1.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod1.ValueMember = "ID"
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If DT2.Rows.Count > 0 Then
            cmbPayMethod2.DataSource = DT2
            cmbPayMethod2.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod2.ValueMember = "ID"
        End If
        If DT3.Rows.Count > 0 Then
            cmbPayMethod3.DataSource = DT3
            cmbPayMethod3.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod3.ValueMember = "ID"
        End If
        If DT4.Rows.Count > 0 Then
            cmbPayMethod4.DataSource = DT4
            cmbPayMethod4.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod4.ValueMember = "ID"
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
        GetPayMethodSelect()
        Dim PayMethodSet As DataTable = GetRecordSet("select [SET5],[SET6],[SET7],[SET8],[SET9] from [Settings]")
        If PayMethodSet.Rows.Count > 0 Then
            cmbPayMethod1.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET5")), 0, (PayMethodSet.Rows(0)("SET5")))
            cmbPayMethod2.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET6")), 1, (PayMethodSet.Rows(0)("SET6")))
            cmbPayMethod3.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET7")), 2, (PayMethodSet.Rows(0)("SET7")))
            cmbPayMethod4.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET8")), 3, (PayMethodSet.Rows(0)("SET8")))
            If (PayMethodSet.Rows(0)("SET9").ToString) = 0 Then
                txtBank1.Visible = False
                txtBank2.Visible = False
                txtBank3.Visible = False
                txtBank4.Visible = False
                cmbPayMethod1.Visible = False
                cmbPayMethod2.Visible = False
                cmbPayMethod3.Visible = False
                cmbPayMethod4.Visible = False
                lblPayMethod1.Visible = False
                'PnlPyment.Bounds = New Rectangle(175, 15, 243, 97)
            ElseIf (PayMethodSet.Rows(0)("SET9").ToString) = 1 Then
                txtBank1.Visible = True
                txtBank2.Visible = True
                txtBank3.Visible = True
                txtBank4.Visible = True
                cmbPayMethod1.Visible = True
                cmbPayMethod2.Visible = True
                cmbPayMethod3.Visible = True
                cmbPayMethod4.Visible = True
                lblPayMethod1.Visible = True
                'PnlPyment.Bounds = New Rectangle(384, 15, 243, 97)
            End If
        End If
    End Sub
    Public Sub GetMakeCharge()
        Try
            '  تعديل سعر المصنعيه علشان مرامي  الله يحرق مراكب اللجابه
            If txtMetalPrice.Focused = True Then
                GetMakChar = Math.Round(Val(txtMetalPrice.Text) / Val(txtMetalWeight.Text) - Val(txtPricePerGram.Text), 3)
                txtMakeCharge.Text = Val(GetMakChar)
                txtTotalPrice.Text = Val(txtMetalPrice.Text) + Val(txtStonePrice1.Text) + Val(txtStonePrice2.Text) + Val(txtStonePrice3.Text)
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtTotalPriceValue_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtTotalPriceValue.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub txtTotalPriceValue_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtTotalPriceValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            UpdateGridAfterDiscount()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtTotalPriceValue_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotalPriceValue.Leave
        UpdateGridAfterDiscount()
    End Sub
    Private Sub DiscountCalculatePricesAndMC(ByVal RowNo As Integer, ByVal MetalWeight As Decimal, ByVal StoneWeight1 As Decimal, ByVal StonePrice1 As Decimal, ByVal StonePriceType1 As Integer, ByVal StoneWeight2 As Decimal, ByVal StonePrice2 As Decimal, ByVal StonePriceType2 As Integer, ByVal StoneWeight3 As Decimal, ByVal StonePrice3 As Decimal, ByVal StonePriceType3 As Integer, ByVal TotalPrice As Decimal, ByVal PricePerGram As Decimal)
        Dim TotalWeight As Double = MetalWeight
        Dim TotalNonAsGoldPrice As Double
        Dim MakeCharge As Decimal
        Dim DiscountMetalPrice As Decimal
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
            If ItemSoldActiv = "1" Then
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If StonePriceType1 = 1 Then
                    TotalWeight += StoneWeight1
                Else
                    TotalNonAsGoldPrice += StonePrice1
                End If
                If cmbStoneName2.SelectedValue = True Then
                    TotalWeight += StoneWeight2
                Else
                    TotalNonAsGoldPrice += StonePrice2
                End If
                If cmbStoneName3.SelectedValue = True Then
                    TotalWeight += StoneWeight3
                Else
                    TotalNonAsGoldPrice += StonePrice3
                End If
            Else
                TotalNonAsGoldPrice = StonePrice1 + StonePrice2 + StonePrice3
            End If
            MakeCharge = Math.Round(((TotalPrice - TotalNonAsGoldPrice) / TotalWeight) - PricePerGram, 3)
            grid.Rows(RowNo).Cells("colGoledMakeCharge").Value = MakeCharge
            DiscountMetalPrice = If(MetalWeight = 0, "", Math.Round((MakeCharge + PricePerGram) * MetalWeight, 3))
            If GetSettingsData.Rows.Count > 0 Then
                Dim ItemSoldActiv2 As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
                If ItemSoldActiv2 = "1" Then 'If StoneAsGold is Enabled
                    If StonePriceType1 = 1 Then
                        grid.Rows(RowNo).Cells("colStonPrice1").Value = Math.Round((PricePerGram + MakeCharge) * StoneWeight1, 3)
                    End If
                    If StonePriceType2 = 1 Then
                        grid.Rows(RowNo).Cells("colStonPrice2").Value = Math.Round((PricePerGram + MakeCharge) * StoneWeight2, 3)
                    End If
                    If StonePriceType3 = 1 Then
                        grid.Rows(RowNo).Cells("colStonPrice3").Value = Math.Round((PricePerGram + MakeCharge) * StoneWeight3, 3)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub UpdateGridAfterDiscount()
        If Val(txtTotalPriceValue.Text) = CalculateTotalGridPrice() Then Exit Sub
        Dim Discount As Decimal = (CalculateTotalGridPrice() - Val(txtTotalPriceValue.Text)) / CalculateTotalGridPrice()
        For i As Integer = 0 To grid.Rows.Count - 1
            grid.Rows(i).Cells("colTotalGoledPrice").Value = Math.Round(grid.Rows(i).Cells("colTotalGoledPrice").Value * (1 - Discount), 3)
            DiscountCalculatePricesAndMC(i,
                grid.Rows(i).Cells("colGoldWeight").Value,
                grid.Rows(i).Cells("colStonWeight1").Value,
                grid.Rows(i).Cells("colStonPrice1").Value,
                grid.Rows(i).Cells("colStonePriceType1").Value,
                grid.Rows(i).Cells("colStonWeight2").Value,
                grid.Rows(i).Cells("colStonPrice2").Value,
                grid.Rows(i).Cells("colStonePriceType2").Value,
                grid.Rows(i).Cells("colStonWeight3").Value,
                grid.Rows(i).Cells("colStonPrice3").Value,
                grid.Rows(i).Cells("colStonePriceType3").Value,
                grid.Rows(i).Cells("colTotalGoledPrice").Value,
                grid.Rows(i).Cells("colGramPrice").Value)
        Next
    End Sub
    Private Sub SilverSellEditRemove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbCash.Checked = True
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        CheckUserPermissions(UserID)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)
        Try
            CivilIDForm = New CivilID
            CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
            CivilIDForm.Bounds = New Rectangle(2, 40, 995, 255)
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
       
        frmMain.Timer1.Stop()
        Get_Casher_Data()
        GetStoneName1()
        GetStoneName2()
        GetStoneName3()
        BtnSaveEdte.Enabled = False
        GetPayMethod()
        GoldInvoiceLoad()
        txtPriceReturn.Text = "000.000"
        dtpInvoiceDate.CustomFormat = "dd/MM/yyyy"
        btnSave.Enabled = False
    End Sub

    Private Sub BackWorkerInvoceGetNo_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkerInvoceGetNo.DoWork
        GetInvoiceNumber()
    End Sub

    Private Sub txtInvoiceNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtInvoiceNo.MouseClick

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim GetInvDetels As DataTable = GetRecordSet("select * from SilverBAY where BAY_SARYAL ='" & txtInvoiceNo.Text & "'")
        If GetInvDetels.Rows.Count > 0 Then
            Dim InvStutes As Boolean = GetInvDetels.Rows(0)("Active").ToString()
            If InvStutes = False Then
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                Exit Sub
            ElseIf InvStutes = True Then
                ClearControls(gbData) 'Controls.Clear()
                ClearInnerControls(PanPay2)
                ClearInnerControls(PanPay)
                PerformSearch()
                CalculatePriceDifference()
                btnSave.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKnet.TextChanged
        CalculatePriceDifference()
    End Sub

    Private Sub lblBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBank.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveEdte.Click
        If cmbCashier.SelectedIndex = -1 Then
            MsgBox("اختر كاشيرًا من الموجودين..لا تكتب كاشيرًا جديدًا" & vbCrLf & "Please Select Cashier, Don't Enter Manually", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        If EditControl = False Then
            txtBarCode.Enabled = True
            AddNewItemInDataGred()
            txtTotalPriceValue.Text = CalculateTotalGridPrice()
            EditControl = False
            CalculatePriceDifference()
        ElseIf EditControl = True Then
            ModifyData()
            txtTotalPriceValue.Text = CalculateTotalGridPrice()
            EditControl = False
            cmbItem.Enabled = True
            CalculatePriceDifference()
        End If
    End Sub

    Private Sub txtInvoiceNo_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.DropDown
        If txtInvoiceNo.Items.Count <> 0 Then
            txtInvoiceNo.SelectedIndex = txtInvoiceNo.Items.Count - 1
        ElseIf txtInvoiceNo.Items.Count <= 0 Then
            BackWorkerInvoceGetNo.RunWorkerAsync()
            txtInvoiceNo.SelectedIndex = txtInvoiceNo.Items.Count - 1
        End If
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If grid.Rows.Count > 1 Then
                If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("colItemID").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("colItemID").Value, vbYesNo) = vbYes Then
                    Try
                        GlCommand.CommandText = ("UPDATE [SilverInvoceDetels] SET Active='0' WHERE invoc_time='" & (grid.SelectedRows(0).Cells("colID").Value) & "'AND ItemID= '" & (grid.SelectedRows(0).Cells("colItemID").Value) & "'AND ID= '" & (grid.SelectedRows(0).Cells("colItemTpID").Value) & "'")
                        GlCommand.ExecuteNonQuery()
                        grid.Rows.RemoveAt(grid.CurrentRow.Index)
                        Beep()
                        txtTotalPriceValue.Text = CalculateTotalGridPrice()
                        If grid.Rows.Count = 0 Then
                            cmbCashier.Enabled = True
                            CivilIDForm.txtCID.Enabled = True
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            ElseIf grid.Rows.Count = 1 Then
                If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                    GlCommand.CommandText = ("UPDATE [SilverInvoceDetels] SET Active='0' WHERE invoc_time='" & (grid.SelectedRows(0).Cells("colID").Value) & "'AND ItemID= '" & (grid.SelectedRows(0).Cells("colItemID").Value) & "'AND ID= '" & (grid.SelectedRows(0).Cells("colItemTpID").Value) & "'")
                    GlCommand.ExecuteNonQuery()
                    grid.Rows.RemoveAt(grid.CurrentRow.Index)
                    txtTotalPriceValue.Text = CalculateTotalGridPrice()
                    GlCommand.CommandText = ("UPDATE [SilverBAY] SET Active='0' WHERE BAY_SARYAL='" & txtInvoiceNo.Text.Trim & "'")
                    GlCommand.ExecuteNonQuery()
                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                        Me.Close()
                    Else
                        MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
                        Beep()
                    End If
                End If
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل القطعة رقم " & grid.Rows(e.RowIndex).Cells("colItemID").Value & "؟" & vbCrLf & "Do You Want to Modify Item No. " & grid.Rows(e.RowIndex).Cells("colItemID").Value, vbYesNo) = vbYes Then
                Try
                    txtBarCode.Enabled = False
                    EditControl = True
                    txtBarCode.Clear()
                    txtKarat.Text = grid.Rows(e.RowIndex).Cells("colGoledKarat").Value
                    txtBarCode.Text = grid.Rows(e.RowIndex).Cells("colItemID").Value
                    'cmbItem.SelectedValue = grid.Rows(e.RowIndex).Cells("colItemID").Value
                    txtItemNmeInInvoce.Text = grid.Rows(e.RowIndex).Cells("colItemName").Value
                    txtMetalWeight.Text = grid.Rows(e.RowIndex).Cells("colGoldWeight").Value
                    txtPricePerGram.Text = grid.Rows(e.RowIndex).Cells("colGramPrice").Value
                    txtMetalPrice.Text = grid.Rows(e.RowIndex).Cells("colTotalGoledPrice").Value
                    txtMakeCharge.Text = grid.Rows(e.RowIndex).Cells("colGoledMakeCharge").Value
                    txtQty.Text = grid.Rows(e.RowIndex).Cells("colGoledPiecesQuantity").Value
                    txtTotalPrice.Text = grid.Rows(e.RowIndex).Cells("colItemTotalPrice").Value
                    txtNotes.Text = grid.Rows(e.RowIndex).Cells("colNots").Value

                    txtCostPerItem.Text = grid.Rows(e.RowIndex).Cells("colGoledPurchasPrice").Value
                    ''''''''''''''''''اسم الحجر  
                    cmbStoneName1.Text = grid.Rows(e.RowIndex).Cells("colStonName1").Value
                    cmbStoneName2.Text = grid.Rows(e.RowIndex).Cells("colStonName2").Value
                    cmbStoneName3.Text = grid.Rows(e.RowIndex).Cells("colStonName3").Value
                    ''''''''''''''''''''''وزن الحجر 
                    txtStoneWeight1.Text = grid.Rows(e.RowIndex).Cells("colStonWeight1").Value
                    txtStoneWeight2.Text = grid.Rows(e.RowIndex).Cells("colStonWeight2").Value
                    txtStoneWeight3.Text = grid.Rows(e.RowIndex).Cells("colStonWeight3").Value
                    ''''''''''''''''''''''لون الحجر 
                    txtStoneColor1.Text = grid.Rows(e.RowIndex).Cells("colStonColor1").Value
                    txtStoneColor2.Text = grid.Rows(e.RowIndex).Cells("colStonColor2").Value
                    txtStoneColor3.Text = grid.Rows(e.RowIndex).Cells("colStonColor3").Value
                    ''''''''''''''''''''''سعر الحجر 
                    txtStonePrice1.Text = grid.Rows(e.RowIndex).Cells("colStonPrice1").Value
                    txtStonePrice2.Text = grid.Rows(e.RowIndex).Cells("colStonPrice2").Value
                    txtStonePrice3.Text = grid.Rows(e.RowIndex).Cells("colStonPrice3").Value
                    txtTotalPriceValue.Text = CalculateTotalGridPrice()
                    BtnSaveEdte.Enabled = True
                    BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "حفظ التعديل", "Save Edits")
                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                    End If
                    cmbItem.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
        CalculatePriceDifference()
    End Sub
    Private Sub ModifyData()
        Dim UpdateRows As DataGridViewRow = grid.SelectedRows(0)
        UpdateRows.Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim
        UpdateRows.Cells("coluserID").Value = frmLogin.User_nameTextBox.Text.Trim
        UpdateRows.Cells("colItemID").Value = txtBarCode.Text
        UpdateRows.Cells("colItemName").Value = cmbItem.Text
        UpdateRows.Cells("colItemName").Value = txtItemNmeInInvoce.Text
        UpdateRows.Cells("colGoldWeight").Value = txtMetalWeight.Text
        UpdateRows.Cells("colGramPrice").Value = txtPricePerGram.Text
        UpdateRows.Cells("colTotalGoledPrice").Value = txtMetalPrice.Text
        UpdateRows.Cells("colGoledMakeCharge").Value = txtMakeCharge.Text
        UpdateRows.Cells("colGoledPiecesQuantity").Value = txtQty.Text
        UpdateRows.Cells("colItemTotalPrice").Value = txtTotalPrice.Text
        UpdateRows.Cells("colNots").Value = txtNotes.Text
        UpdateRows.Cells("colGoledKarat").Value = txtKarat.Text
        UpdateRows.Cells("colGoledPurchasPrice").Value = txtCostPerItem.Text
        UpdateRows.Cells("colcacher").Value = If(IsDBNull(cmbCashier.SelectedValue), grid.SelectedRows(0).Cells("colcacher").Value, (cmbCashier.SelectedValue))

        ''''''''''''''''''اسم الحجر  
        UpdateRows.Cells("colStonName1").Value = cmbStoneName1.Text
        UpdateRows.Cells("colStonName2").Value = cmbStoneName2.Text
        UpdateRows.Cells("colStonName3").Value = cmbStoneName3.Text
        ''''''''''''''''''''''وزن الحجر 
        UpdateRows.Cells("colStonWeight1").Value = txtStoneWeight1.Text
        UpdateRows.Cells("colStonWeight2").Value = txtStoneWeight2.Text
        UpdateRows.Cells("colStonWeight3").Value = txtStoneWeight3.Text
        ''''''''''''''''''''''لون الحجر 
        UpdateRows.Cells("colStonColor1").Value = txtStoneColor1.Text
        UpdateRows.Cells("colStonColor2").Value = txtStoneColor2.Text
        UpdateRows.Cells("colStonColor3").Value = txtStoneColor3.Text
        ''''''''''''''''''''''سعر الحجر 
        UpdateRows.Cells("colStonPrice1").Value = txtStonePrice1.Text
        UpdateRows.Cells("colStonPrice2").Value = txtStonePrice2.Text
        UpdateRows.Cells("colStonPrice3").Value = txtStonePrice3.Text
        GlCommand.CommandText = " UPDATE [SilverInvoceDetels]SET [item_name] = N'" & grid.SelectedRows(0).Cells("colItemName").Value & "'" &
                                ",[item_desp] = '" & If(IsDBNull(grid.SelectedRows(0).Cells("colGoledPurchasPrice").Value), "0", grid.SelectedRows(0).Cells("colGoledPurchasPrice").Value & "'" &
                                ",[item_GramPrice] = '" & grid.SelectedRows(0).Cells("colGramPrice").Value & "'" &
                                ",[item_gram] = '" & grid.SelectedRows(0).Cells("colGoldWeight").Value & "'" &
                                ",[item_gramMade] = '" & grid.SelectedRows(0).Cells("colGoledMakeCharge").Value & "'" &
                                ",[item_totalPrice] = '" & grid.SelectedRows(0).Cells("colItemTotalPrice").Value & "'" &
                                ",[qunt] = '" & grid.SelectedRows(0).Cells("colGoledPiecesQuantity").Value & "'" &
                                ",[item_extrasMAZAN] = '" & grid.SelectedRows(0).Cells("colStonWeight1").Value & "'" &
                                ",[StoneName1] = N'" & grid.SelectedRows(0).Cells("colStonName1").Value & "'" &
                                ",[StoneColor1] = '" & grid.SelectedRows(0).Cells("colStonColor1").Value & "'" &
                                ",[item_extrasPRICE] = '" & grid.SelectedRows(0).Cells("colStonPrice1").Value & "'" &
                                ",[StonePriceType1] = '" & grid.SelectedRows(0).Cells("colStonePriceType1").Value & "'" &
                                ",[StoneWeight2] = '" & grid.SelectedRows(0).Cells("colStonWeight2").Value & "'" &
                                ",[StoneName2] = N'" & grid.SelectedRows(0).Cells("colStonName2").Value & "'" &
                                ",[StoneColor2] = '" & grid.SelectedRows(0).Cells("colStonColor2").Value & "'" &
                                ",[StonePrice2] = '" & grid.SelectedRows(0).Cells("colStonPrice2").Value & "'" &
                                ",[StonePriceType2] = '" & grid.SelectedRows(0).Cells("colStonePriceType2").Value & "'" &
                                ",[StoneWeight3] = '" & grid.SelectedRows(0).Cells("colStonWeight3").Value & "'" &
                                ",[StoneName3] = N'" & grid.SelectedRows(0).Cells("colStonName3").Value & "'" &
                                ",[StoneColor3] = '" & grid.SelectedRows(0).Cells("colStonColor3").Value & "'" &
                                ",[StonePrice3] = '" & grid.SelectedRows(0).Cells("colStonPrice3").Value & "'" &
                                ",[StonePriceType3] = '" & grid.SelectedRows(0).Cells("colStonePriceType3").Value & "'" &
                                ",[GoledKarat] = '" & grid.SelectedRows(0).Cells("colGoledKarat").Value & "'" &
                                ",[MetalPrice] = '" & grid.SelectedRows(0).Cells("colTotalGoledPrice").Value & "'" &
                                ",[cacher] = '" & If(IsDBNull(cmbCashier.SelectedValue), grid.SelectedRows(0).Cells("colcacher").Value, (cmbCashier.SelectedValue)) & "'" &
                                 " WHERE invoc_time='" & (grid.SelectedRows(0).Cells("colID").Value) & "'AND ItemID= '" & (grid.SelectedRows(0).Cells("colItemID").Value) & "'AND ID= '" & (grid.SelectedRows(0).Cells("colItemTpID").Value) & "'")
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = ("UPDATE [SilverInvoceDetels]SET [nots] =N'" & SilverInvoice.txtNotes.Text.Trim & "',[Castomerid]= N'" & CivilIDForm.txtCID.Text.Trim & "' WHERE  [invoc_time]='" & txtInvoiceNo.Text.Trim & "'")
        GlCommand.ExecuteNonQuery()
        ClearControls(gbData)
        CalculatePriceDifference()

    End Sub

    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Search, CInt((e.CellBounds.Width / 2) - (My.Resources.Search.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Search.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub SilverSellEditRemove_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub SilverSellEditRemove_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItem.SelectedIndexChanged
        If cmbItem.SelectedIndex = -1 OrElse cmbItem.ValueMember = "" Then
            Exit Sub
        End If
        If cmbItem.Focused = True Then
            txtBarCode.Text = cmbItem.SelectedValue
            BtnSaveEdte.Enabled = True
            BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "اضافة صنف جديد", "Add New Items")
        End If
    End Sub

    Private Sub txtBarCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
        txtBarCodeTextChanged()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cmbCashier.SelectedIndex = -1 Then
            MsgBox("اختر كاشيرًا من الموجودين..لا تكتب كاشيرًا جديدًا" & vbCrLf & "Please Select Cashier, Don't Enter Manually", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 OrElse Val(txtBank1.Text) < 0 OrElse Val(txtBank2.Text) < 0 OrElse Val(txtBank3.Text) < 0 OrElse Val(txtBank4.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If Val(txtCash.Text) + Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text) <> Val(txtTotalPriceValue.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        GlCommand.CommandText = "UPDATE [SilverBAY] SET [TOTAL_mony] = '" & Val(txtTotalPriceValue.Text.Trim) & "'" &
                                      ",[KENT] = '" & If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)) & "'" &
                                      ",[CACH] = '" & If(IsDBNull(txtCash.Text.Trim), "0", Val(txtCash.Text.Trim)) & "'" &
                                      ",[arbic_tayb] = N'" & kokotxt(Val(txtTotalPriceValue.Text), CurrencyMainAr, CurrencySubAr, True) & "'" &
                                      ",[balance] = '" & Val(txtPriceReturn.Text.Trim) & "'" &
                                      ",[staytes] = N'" & If(rbCash.Checked = True, "نقدا", "اجل") & "'" &
                                      ",[English_tayb] = '" & ConvertNumberToENG(txtTotalPriceValue.Text.Trim) & "'" &
                                      ",[PayMethod] = '" & cmbPayMethod.SelectedValue & "'" &
                                      ",[Active] = '1'" &
                                      ",[PayMethod1] ='" & cmbPayMethod1.SelectedValue & "'" &
                                      ",[PayMethod2] ='" & cmbPayMethod2.SelectedValue & "'" &
                                      ",[PayMethod3] ='" & cmbPayMethod3.SelectedValue & "'" &
                                      ",[PayMethod4] ='" & cmbPayMethod4.SelectedValue & "'" &
                                      ",[Bank1] ='" & If(IsDBNull(txtBank1.Text.Trim), "0", Val(txtBank1.Text.Trim)) & "'" &
                                      ",[Bank2] ='" & If(IsDBNull(txtBank2.Text.Trim), "0", Val(txtBank2.Text.Trim)) & "'" &
                                      ",[Bank3] ='" & If(IsDBNull(txtBank3.Text.Trim), "0", Val(txtBank3.Text.Trim)) & "'" &
                                      ",[Bank4] ='" & If(IsDBNull(txtBank4.Text.Trim), "0", Val(txtBank4.Text.Trim)) & "'" &
                                      " WHERE [BAY_SARYAL]='" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = ("UPDATE [SilverInvoceDetels] SET [nots] =N'" & txtNotes.Text.Trim & "'" &
                                 ",[Castomerid]=N'" & CivilIDForm.txtCID.Text.Trim & "'" &
                                 ",[date]='" & DateToSave(dtpInvoiceDate.Value) & "'" &
                                 ",[invoc_date_time]='" & Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss") & "'" &
                                 ",[Cash]='" & Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss") & "'" &
                                 ",[cacher]='" & If(IsDBNull(cmbCashier.SelectedValue), grid.SelectedRows(0).Cells("colcacher").Value, (cmbCashier.SelectedValue)) & "'" &
                                 " WHERE  [invoc_time]='" & txtInvoiceNo.Text.Trim & "'")
        GlCommand.ExecuteNonQuery()
        MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        Try
            With SilverViewSellInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text
                .InvoiceSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
        Me.Close()
        '  ",[cacher]='" & cmbCashier.SelectedValue & "'" &
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    Private Function StoneAsGoldWeight() As Decimal
        StoneAsGoldWeight = 0
        Dim StoneWeight1, StoneWeight2, StoneWeight3 As Decimal
        If cmbStoneName1.SelectedValue = True Then
            StoneWeight1 = Val(txtStoneWeight1.Text)
        End If
        If cmbStoneName2.SelectedValue = True Then
            StoneWeight2 = Val(txtStoneWeight2.Text)
        End If
        If cmbStoneName3.SelectedValue = True Then
            StoneWeight3 = Val(txtStoneWeight3.Text)
        End If
        ' Dim GetSettingsData As DataTable = GetRecordSet("SELECT * from Settings")
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As Integer = GetSettingsData.Rows(0)("SET_INVARCHR169").ToString
            If ItemSoldActiv = "1" Then
                'Rounding
                StoneWeight1 = Math.Round(StoneWeight1, 2)
                StoneWeight2 = Math.Round(StoneWeight2, 2)
                StoneWeight3 = Math.Round(StoneWeight3, 2)
            End If
        End If
        Return StoneAsGoldWeight = StoneWeight1 + StoneWeight2 + StoneWeight3
    End Function
    Private Sub GetMakeValue()
        If Val(txtMetalWeight.Text) = 0 Then
            txtMakeCharge.Text = ""
            Exit Sub
        End If
        If txtMetalPrice.Text = "" Then
            txtMakeCharge.Text = dtItemData.Rows(0)("colGoledMakeCharge").ToString
            Exit Sub
        End If
        'If(IsDBNull(PayMethodSet.Rows(0)("SET8")), 3, (PayMethodSet.Rows(0)("SET8")))
        ' Dim GetSettingsData As DataTable = GetRecordSet("SELECT * from Settings")
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As String = If(IsDBNull(GetSettingsData.Rows(0)("SET_INVARCHR168").ToString), "0", (GetSettingsData.Rows(0)("SET_INVARCHR168").ToString))
            If ItemSoldActiv = "1" Then
                'If StoneAsGold is Enabled
                txtMakeCharge.Text = Math.Round((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * (Val(txtMetalWeight.Text) + StoneAsGoldWeight())) / (Val(txtMetalWeight.Text) + StoneAsGoldWeight()), 3)
            Else
                txtMakeCharge.Text = Math.Round((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * Val(txtMetalWeight.Text)) / Val(txtMetalWeight.Text), 3)
            End If
        End If
    End Sub

    Private Sub txtMetalWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMetalWeight.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        If sender.Focused = True Then
            GetMetalPrice()
            GetTotalPrice()
        Else
            GetMakeValue()
        End If
    End Sub

    Private Sub txtPricePerGram_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPricePerGram.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        GetMetalPrice()
        StoneAsGoldPrice()
        GetTotalPrice()
    End Sub
    Private Sub txtKarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKarat.TextChanged
        GetPricePerGram()
    End Sub
    Private Sub txtMakeCharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMakeCharge.TextChanged
        If Val(txtMakeCharge.Text) <= 0 Then
            txtMakeCharge.ForeColor = Color.Red
        Else
            txtMakeCharge.ForeColor = Color.Black
        End If
        If txtMakeCharge.Focused = True Then
            GetMetalPrice()
            StoneAsGoldPrice()
            GetTotalPrice()
        End If
    End Sub
    Private Sub CalculatePricesAndMC()
        Dim TotalWeight As Double = Val(txtMetalWeight.Text)
        Dim TotalNonAsGoldPrice As Double
        'Dim GetSettingsData As DataTable = GetRecordSet("SELECT * from Settings")
        If GetSettingsData.Rows.Count > 0 Then
            Dim ItemSoldActiv As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
            If ItemSoldActiv = "1" Then
                If cmbStoneName1.SelectedValue = True Then
                    TotalWeight += Val(txtStoneWeight1.Text)
                Else
                    TotalNonAsGoldPrice += Val(txtStonePrice1.Text)
                End If
                If cmbStoneName2.SelectedValue = True Then
                    TotalWeight += Val(txtStoneWeight2.Text)
                Else
                    TotalNonAsGoldPrice += Val(txtStonePrice2.Text)
                End If
                If cmbStoneName3.SelectedValue = True Then
                    TotalWeight += Val(txtStoneWeight3.Text)
                Else
                    TotalNonAsGoldPrice += Val(txtStonePrice3.Text)
                End If
            Else
                TotalNonAsGoldPrice = Val(txtStonePrice1.Text) + Val(txtStonePrice2.Text) + Val(txtStonePrice3.Text)
            End If
        End If
        txtMakeCharge.Text = Math.Round(((Val(txtTotalPrice.Text) - TotalNonAsGoldPrice) / TotalWeight) - Val(txtPricePerGram.Text), 3)
        GetMetalPrice()
        StoneAsGoldPrice()
    End Sub

    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged
        If txtTotalPrice.Focused = True Then
            CalculatePricesAndMC()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' (grid.SelectedRows(0).Cells("colTaxExempt").Value)
    End Sub

    Private Sub txtMetalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMetalPrice.TextChanged
        GetMakeCharge()
    End Sub

    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInvoice.Click
        If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
            DeleteInvoice()
            Beep()
            Close()
        Else
            MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
            Beep()
            Exit Sub
        End If
    End Sub

    Private Sub txtStonePrice1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStonePrice1.TextChanged
        If sender.Focused = True Then
            If GetSettingsData.Rows.Count > 0 Then
                Dim ItemSoldActiv As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
                If ItemSoldActiv = "1" Then
                    If cmbStoneName1.SelectedValue = True Then
                        CalculatePricesAndMC()
                    Else
                        GetTotalPrice()
                    End If
                Else
                    GetTotalPrice()
                End If
            End If
        End If
    End Sub

    Private Sub txtStonePrice2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStonePrice2.TextChanged
        If sender.Focused = True Then
            If GetSettingsData.Rows.Count > 0 Then
                Dim ItemSoldActiv As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
                If ItemSoldActiv = "1" Then
                    If cmbStoneName2.SelectedValue = True Then
                        CalculatePricesAndMC()
                    Else
                        GetTotalPrice()
                    End If
                Else
                    GetTotalPrice()
                End If
            End If
        End If
    End Sub

    Private Sub txtStonePrice3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStonePrice3.TextChanged
        If sender.Focused = True Then
            If GetSettingsData.Rows.Count > 0 Then
                Dim ItemSoldActiv As String = GetSettingsData.Rows(0)("SET_INVARCHR168").ToString
                If ItemSoldActiv = "1" Then
                    If cmbStoneName3.SelectedValue = True Then
                        CalculatePricesAndMC()
                    Else
                        GetTotalPrice()
                    End If
                Else
                    GetTotalPrice()
                End If
            End If
        End If
    End Sub

    Private Sub btnPayPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayPrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        Try
            With SilverViewSellInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text
                .InvoiceSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
    End Sub
    Private Sub txtCash_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKnet.Enter, txtCash.Enter, txtBank4.Enter, txtBank3.Enter, txtBank2.Enter, txtBank1.Enter
        CalculatePriceDifference()
    End Sub

    Private Sub txtCash_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKnet.KeyDown, txtCash.KeyDown, txtBank4.KeyDown, txtBank3.KeyDown, txtBank2.KeyDown, txtBank1.KeyDown
        CalculatePriceDifference()
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKnet.KeyPress, txtCash.KeyPress, txtBank4.KeyPress, txtBank3.KeyPress, txtBank2.KeyPress, txtBank1.KeyPress
        CalculatePriceDifference()
    End Sub

    Private Sub txtBank1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBank4.KeyUp, txtBank3.KeyUp, txtBank2.KeyUp, txtBank1.KeyUp
        CalculatePriceDifference()
    End Sub

    Private Sub txtCash_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCash.KeyUp
        CalculatePriceDifference()
    End Sub

    Private Sub txtKnet_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKnet.KeyUp
        CalculatePriceDifference()
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged

    End Sub
End Class