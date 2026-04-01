Public Class GoldAddItem
    Dim CustomerCID As String
    Dim CashierID As String
    Dim UserID As String
    Dim InvoiceNo As String
    Dim InvoiceTimeStamp As Date
    Dim InvoiceDate As Date
    Dim ShowRoomName As String
    Dim CountryOfOrigin As String
    Private Sub GoldAddItem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        LoadItems()
        LoadData()
        InitialState()
        GetTotalInvoicePrice()
        txtBarCode.Focus()
    End Sub
    Private Sub InitialState()
        grid.Enabled = False
        txtBarCode.Text = ""
    End Sub

    Private Sub GetTotalPrice()
        If Val(txtMetalPrice.Text) = 0 Then
            txtTotalPrice.Text = ""
            Exit Sub
        End If
        txtTotalPrice.Text = Val(txtMetalPrice.Text) + Val(txtStonePrice1.Text) + Val(txtStonePrice2.Text) + Val(txtStonePrice3.Text)
    End Sub
    Private Sub GetTotalInvoicePrice()
        Dim TotalInvoicePrice As Decimal
        For i As Integer = 0 To grid.Rows.Count - 1
            TotalInvoicePrice += grid.Rows(i).Cells("item_totalPrice").Value
        Next
        Add_ITEMtxtTotalPrice.Text = TotalInvoicePrice
    End Sub
    Private Sub GetGramPrice()
        If txtKarat.Text = "24" Then
            txtPricePerGram.Text = gold24
        ElseIf txtKarat.Text = "22" Then
            txtPricePerGram.Text = gold22
        ElseIf txtKarat.Text = "21" Then
            txtPricePerGram.Text = gold21
        ElseIf txtKarat.Text = "18" Then
            txtPricePerGram.Text = gold18
        End If
    End Sub
    Public Sub FillStones()
        GetStoneName1()
        GetStoneName2()
        GetStoneName3()
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
    Public Sub LoadData()
        'MsgBox(GoldSellEditRemove.txtInvoiceNo.Text.Trim)
        FillStones()
        'Try

        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [Castomerid] , [invoc_time] , [Gram_Valu] , [itemID] , [item_name] " &
                                                   ", [item_desp] , [item_GramPrice] , [item_gram] , [item_gramMade] , [item_totalPrice], [item_cantrey] " &
                                                   ", [cacher] , [date] , [invoc_date_time] , [Cash] , [qunt] " &
                                                   ", [nots] , [sroom_name] " &
                                                   ", [item_extrasMAZAN] , [StoneName1] , [StoneColor1]  " &
                                                   ", [item_extrasPRICE] , [StoneWeight2] , [StoneName2]  " &
                                                   ", [StoneColor2] , [StonePrice2] , [StoneWeight3] , [StoneName3] , [StoneColor3] , [StonePrice3] " &
                                                   ", [BarCode] , [userID],[Active] FROM [invoce_report] " &
                                                     " WHERE [invoc_time] = '" & GoldSellEditRemove.txtInvoiceNo.Text.Trim & "' AND (Active = 1)")
       
        If dt1.Rows.Count > 0 Then

            grid.DataSource = dt1

            InvoiceTimeStamp = dt1.Rows(0)("invoc_date_time").ToString
            CustomerCID = dt1.Rows(0)("Castomerid").ToString
            CashierID = dt1.Rows(0)("cacher").ToString
            InvoiceNo = dt1.Rows(0)("invoc_time").ToString
            UserID = dt1.Rows(0)("userID").ToString
            InvoiceDate = dt1.Rows(0)("date").ToString
            InvoiceTimeStamp = dt1.Rows(0)("invoc_date_time").ToString
            ShowRoomName = dt1.Rows(0)("sroom_name").ToString
            CountryOfOrigin = dt1.Rows(0)("item_cantrey").ToString
            txtInvoiceNo.Text = InvoiceNo
            grid.Columns("ID").Visible = False
            grid.Columns("Castomerid").Visible = False
            grid.Columns("invoc_time").Visible = False
        End If
        'Catch ex As Exception
        '    MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub LoadItems()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Fo_name] , [BarCode] FROM [Fo_min]")
        If dt1.Rows.Count > 0 Then
            cmbItemName.DisplayMember = "Fo_name"
            cmbItemName.ValueMember = "BarCode"
            cmbItemName.DataSource = dt1
        End If
    End Sub
    Private Sub txtBarCode_TextChanged(sender As Object, e As EventArgs) Handles txtBarCode.TextChanged
        Try
            cmbItemName.SelectedValue = txtBarCode.Text.Trim
        Catch ex As Exception
            cmbItemName.SelectedIndex = -1
            ClearControls(gbItemData)
        End Try
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [userID] , [FO_name] , [FO_desp] , [FO_price] , [FO_GramPrice] , [FO_gram] " &
                                            ",[FO_gramMade] , [FO_made] , [FO_extras] , [FO_totalPrice] , [Gram_valu] , [ITEM_IMGE] , [date_care] " &
                                            ",[FO_ItemNo] , [StoneColor1] , [StonePrice1] , [StoneWeight2] , [StoneName2] , [StoneColor2] , [StonePrice2] " &
                                            ",[StoneWeight3] , [StoneName3] , [StoneColor3] , [StonePrice3] , [Qty] , [BarCode]" &
                                            " FROM [Fo_min] WHERE [BarCode] = N'" & txtBarCode.Text.Trim & "'")
        If dt1.Rows.Count > 0 Then
            ClearTextBox(gbItemData)
            txtMetalWeight.Text = dt1.Rows(0)("FO_gram").ToString
            txtKarat.Text = dt1.Rows(0)("Gram_valu").ToString
            txtMakeCharge.Text = dt1.Rows(0)("FO_gramMade").ToString
            txtQty.Text = dt1.Rows(0)("Qty").ToString

            txtStoneWeight1.Text = dt1.Rows(0)("FO_extras").ToString
            cmbStoneName1.Text = dt1.Rows(0)("FO_price").ToString
            txtStoneColor1.Text = dt1.Rows(0)("StoneColor1").ToString
            txtStonePrice1.Text = dt1.Rows(0)("StonePrice1").ToString

            txtStoneWeight2.Text = dt1.Rows(0)("StoneWeight2").ToString
            cmbStoneName2.Text = dt1.Rows(0)("StoneName2").ToString
            txtStoneColor2.Text = dt1.Rows(0)("StoneColor2").ToString
            txtStonePrice2.Text = dt1.Rows(0)("StonePrice2").ToString

            txtStoneWeight3.Text = dt1.Rows(0)("StoneWeight3").ToString
            cmbStoneName3.Text = dt1.Rows(0)("StoneName3").ToString
            txtStoneColor3.Text = dt1.Rows(0)("StoneColor3").ToString
            txtStonePrice3.Text = dt1.Rows(0)("StonePrice3").ToString

            txtCostPerItem.Text = dt1.Rows(0)("FO_totalPrice").ToString

            If txtKarat.Text = "" Then txtPricePerGram.Text = ""


            txtMetalPrice.Text = If(Val(txtMetalWeight.Text) = 0, "", (Val(txtMakeCharge.Text) + Val(txtPricePerGram.Text)) * Val(txtMetalWeight.Text))

            GetGramPrice()
            GetMetalPrice()
            StoneAsGoldPrice()
            GetTotalPrice()
        End If


    End Sub
    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex = -1 Then
            ClearControls(gbItemData)
            Exit Sub
        End If
        txtBarCode.Text = cmbItemName.SelectedValue
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbItemName.Text = "اخترالصنف" OrElse cmbItemName.Text = "Select Item" OrElse cmbItemName.Text.Trim = "" Then
            MsgBox("اختر اسم الصنف اولا" & vbCrLf & "Select Item Name", , AppTitle)
            cmbItemName.DroppedDown = True
            Exit Sub
        End If

        If Val(txtPricePerGram.Text.Trim) = 0 OrElse IsNumeric(txtPricePerGram.Text.Trim) = False Then
            If txtKarat.Text <> "0" Then
                MsgBox("اكتب سعر جرام الذهب" & vbCrLf & "Enter G.Price Per Gram", , AppTitle)
                txtPricePerGram.SelectAll()
                txtPricePerGram.Focus()
                Exit Sub
            Else
                txtPricePerGram.Text = "0"
            End If
        End If

        If Val(txtMetalPrice.Text.Trim) = 0 OrElse IsNumeric(txtMetalPrice.Text.Trim) = False Then
            MsgBox("اكتب سعر الذهب" & vbCrLf & "Enter Gold Price", , AppTitle)
            txtMetalPrice.SelectAll()
            txtMetalPrice.Focus()
            Exit Sub
        End If

        'If Settings.SET_INVARCHR151TextBox.Text.Trim = "1" Then
        '    For i As Integer = 0 To grid.RowCount - 1
        '        If txtBarCode.Text.Trim = grid.Rows(i).Cells("BarCode").Value.ToString.Trim Then
        '            MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , AppTitle)
        '            Exit Sub
        '        End If
        '    Next
        'End If

        Select Case grid.Enabled
            'Case True ' Edit
            '    GlCommand.CommandText = "UPDATE [selInvoceDetels] SET " &
            '                            "[item_GramPrice] = @item_GramPrice , " &
            '                            "[item_gram] = @item_gram , " &
            '                            "[item_gramMade] = @item_gramMade , " &
            '                            "[item_totalPrice] = @item_totalPrice , " &
            '                            "[nots] = @nots , " &
            '                            "[item_extrasMAZAN] = @item_extrasMAZAN , " &
            '                            "[StoneName1] = @StoneName1 , " &
            '                            "[StoneColor1] = @StoneColor1 , " &
            '                            "[item_extrasPRICE] = @item_extrasPRICE , " &
            '                            "[StoneWeight2] = @StoneWeight2 , " &
            '                            "[StoneName2] = @StoneName2 , " &
            '                            "[StoneColor2] = @StoneColor2 , " &
            '                            "[StonePrice2] = @StonePrice2 , " &
            '                            "[StoneWeight3] = @StoneWeight3 , " &
            '                            "[StoneName3] = @StoneName3 , " &
            '                            "[StoneColor3] = @StoneColor3 , " &
            '                            "[StonePrice3] = @StonePrice3 " &
            '                            "WHERE [ID] = '" & grid.SelectedRows(0).Cells("ID").Value & "'"

            '    With GlCommand.Parameters
            '        .Clear()
            '        .AddWithValue("@item_GramPrice", Val(txtPricePerGram.Text.Trim))
            '        .AddWithValue("@item_gram", Val(txtMetalWeight.Text.Trim))
            '        .AddWithValue("@item_gramMade", Val(txtMakeCharge.Text.Trim))
            '        .AddWithValue("@item_totalPrice", Val(txtTotalPrice.Text.Trim))
            '        .AddWithValue("@nots", txtNotes.Text.Trim)
            '        .AddWithValue("@item_extrasMAZAN", Val(txtStoneWeight1.Text.Trim))
            '        .AddWithValue("@StoneName1", cmbStoneName1.Text.Trim)
            '        .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
            '        .AddWithValue("@item_extrasPRICE", Val(txtStonePrice1.Text.Trim))
            '        .AddWithValue("@StoneWeight2", Val(txtStoneWeight2.Text.Trim))
            '        .AddWithValue("@StoneName2", cmbStoneName2.Text.Trim)
            '        .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
            '        .AddWithValue("@StonePrice2", Val(txtStonePrice2.Text.Trim))
            '        .AddWithValue("@StoneWeight3", Val(txtStoneWeight3.Text.Trim))
            '        .AddWithValue("@StoneName3", cmbStoneName3.Text.Trim)
            '        .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
            '        .AddWithValue("@StonePrice3", Val(txtStonePrice3.Text.Trim))
            '    End With
            '    GlCommand.ExecuteNonQuery()
            Case False 'Add
                GlCommand.CommandText = "INSERT INTO [selInvoceDetels] (" &
                                        "[Castomerid] , " &
                                        "[itemID] , " &
                                        "[userID]  , " &
                                        "[invoc_time] , " &
                                        "[item_name] , " &
                                        "[item_desp] , " &
                                        "[item_GramPrice] , " &
                                        "[item_gram] , " &
                                        "[item_gramMade] , " &
                                        "[item_totalPrice] , " &
                                        "[item_cantrey] , " &
                                        "[cacher] , " &
                                        "[date] , " &
                                        "[invoc_date_time] , " &
                                        "[Cash] , " &
                                        "[qunt] , " &
                                        "[sroom_name] , " &
                                        "[nots] , " &
                                        "[item_extrasMAZAN] , " &
                                        "[StoneName1] , " &
                                        "[StoneColor1] , " &
                                        "[item_extrasPRICE] , " &
                                        "[StoneWeight2] , " &
                                        "[StoneName2] , " &
                                        "[StoneColor2] , " &
                                        "[StonePrice2] , " &
                                        "[StoneWeight3] , " &
                                        "[StoneName3] , " &
                                        "[StoneColor3] , " &
                                        "[StonePrice3] , " &
                                         "[GoledKarat] , " &
                                        "[Active] " &
                                        ") VALUES ( " &
                                        "@Castomerid , " &
                                        "@itemID , " &
                                        "@userID  , " &
                                        "@invoc_time , " &
                                        "@item_name , " &
                                        "@item_desp , " &
                                        "@item_GramPrice , " &
                                        "@item_gram , " &
                                        "@item_gramMade , " &
                                        "@item_totalPrice , " &
                                        "@item_cantrey , " &
                                        "@cacher , " &
                                        "@date , " &
                                        "@invoc_date_time , " &
                                        "@Cash , " &
                                        "@qunt , " &
                                        "@sroom_name , " &
                                        "@nots , " &
                                        "@item_extrasMAZAN , " &
                                        "@StoneName1 , " &
                                        "@StoneColor1 , " &
                                        "@item_extrasPRICE , " &
                                        "@StoneWeight2 , " &
                                        "@StoneName2 , " &
                                        "@StoneColor2 , " &
                                        "@StonePrice2 , " &
                                        "@StoneWeight3 , " &
                                        "@StoneName3 , " &
                                        "@StoneColor3 , " &
                                        "@StonePrice3 , " &
                                        "@GoledKarat , " &
                                        "@Active)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@Castomerid", CustomerCID)
                    .AddWithValue("@itemID", txtBarCode.Text.Trim)
                    .AddWithValue("@userID", UserID)
                    .AddWithValue("@invoc_time", InvoiceNo)
                    .AddWithValue("@item_name", cmbItemName.Text.Trim)
                    .AddWithValue("@item_desp", 0)
                    .AddWithValue("@item_GramPrice", Val(txtPricePerGram.Text.Trim))
                    .AddWithValue("@item_gram", Val(txtMetalWeight.Text.Trim))
                    .AddWithValue("@item_gramMade", Val(txtMakeCharge.Text.Trim))
                    .AddWithValue("@item_totalPrice", Val(txtTotalPrice.Text.Trim))
                    .AddWithValue("@item_cantrey", CountryOfOrigin)
                    .AddWithValue("@cacher", CashierID)
                    .AddWithValue("@date", InvoiceDate)
                    .AddWithValue("@invoc_date_time", Format(InvoiceTimeStamp, "dd/MM/yyyy hh:mm:ss tt"))
                    .AddWithValue("@Cash", Format(InvoiceDate, "dd/MM/yyyy hh:mm:ss tt"))
                    .AddWithValue("@qunt", If(Val(txtQty.Text.Trim) = 0, "1", Val(txtQty.Text.Trim)))
                    .AddWithValue("@sroom_name", ShowRoomName)
                    .AddWithValue("@nots", txtNotes.Text.Trim)
                    .AddWithValue("@item_extrasMAZAN", Val(txtStoneWeight1.Text.Trim))
                    .AddWithValue("@StoneName1", cmbStoneName1.Text.Trim)
                    .AddWithValue("@StoneColor1", txtStoneColor1.Text.Trim)
                    .AddWithValue("@item_extrasPRICE", Val(txtStonePrice1.Text.Trim))
                    .AddWithValue("@StoneWeight2", Val(txtStoneWeight2.Text.Trim))
                    .AddWithValue("@StoneName2", cmbStoneName2.Text.Trim)
                    .AddWithValue("@StoneColor2", txtStoneColor2.Text.Trim)
                    .AddWithValue("@StonePrice2", Val(txtStonePrice2.Text.Trim))
                    .AddWithValue("@StoneWeight3", Val(txtStoneWeight3.Text.Trim))
                    .AddWithValue("@StoneName3", cmbStoneName3.Text.Trim)
                    .AddWithValue("@StoneColor3", txtStoneColor3.Text.Trim)
                    .AddWithValue("@StonePrice3", Val(txtStonePrice3.Text.Trim))
                    .AddWithValue("@GoledKarat", Val(txtKarat.Text.Trim))
                    .AddWithValue("@Active", 1)

                End With
                GlCommand.ExecuteNonQuery()
        End Select
        LoadData()
        GetTotalInvoicePrice()
        'GoldSellEditRemove.ViewInvoice()
        'GoldSellEditRemove.payment_process()
        InitialState()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        btnSave.Enabled = True
        gbItemData.Enabled = True
        gbSelectItem.Enabled = True
        grid.Enabled = False
        txtBarCode.Text = ""
        cmbStoneName1.SelectedIndex = -1
        cmbStoneName2.SelectedIndex = -1
        cmbStoneName3.SelectedIndex = -1
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick

        'txtMetalWeight.Text = grid.SelectedRows(0).Cells("item_gram").ToString
        'txtKarat.Text = grid.SelectedRows(0).Cells("Gram_valu").ToString
        'txtMakeCharge.Text = grid.SelectedRows(0).Cells("item_gramMade").ToString
        'txtQty.Text = grid.SelectedRows(0).Cells("qunt").ToString

        'txtStoneWeight1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("item_extrasMAZAN").Value), "", grid.SelectedRows(0).Cells("item_extrasMAZAN").Value)
        'cmbStoneName1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("StoneName1").Value), "", grid.SelectedRows(0).Cells("StoneName1").Value)
        'txtStoneColor1.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor1").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor1").Value)
        'txtStonePrice1.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("item_extrasPRICE").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("item_extrasPRICE").Value)

        'txtStoneWeight2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("StoneWeight2").Value), "", grid.SelectedRows(0).Cells("StoneWeight2").Value)
        'cmbStoneName2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("StoneName2").Value), "", grid.SelectedRows(0).Cells("StoneName2").Value)
        'txtStoneColor2.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor2").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor2").Value)
        'txtStonePrice2.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("StonePrice2").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("StonePrice2").Value)

        'txtStoneWeight3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("StoneWeight3").Value), "", grid.SelectedRows(0).Cells("StoneWeight3").Value)
        'cmbStoneName3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("StoneName3").Value), "", grid.SelectedRows(0).Cells("StoneName3").Value)
        'txtStoneColor3.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor3").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("StoneColor3").Value)
        'txtStonePrice3.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("StonePrice3").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("StonePrice3").Value)

        'txtCostPerItem.Text = grid.SelectedRows(0).Cells("item_totalPrice").ToString
        'txtBarCode.Text = grid.SelectedRows(0).Cells("BarCode").Value

        'GetGramPrice()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        btnSave.Enabled = True
        gbItemData.Enabled = True
        gbSelectItem.Enabled = True
        grid.Enabled = True
        cmbItemName.Enabled = False
        txtBarCode.Enabled = False
    End Sub
    Private Sub GoldAddItem_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        GoldSellEditRemove.PerformSearch()
        Dispose()
    End Sub
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub GetMakeValue()
        If Val(txtMetalWeight.Text) = 0 Then
            txtMakeCharge.Text = ""
            Exit Sub
        End If
        If txtMetalPrice.Text = "" Then
            'txtMakeCharge.Text = FO_gramMadeTextBox.Text
            Exit Sub
        End If
        If Settings.SET_INVARCHR168TextBox.Text = "1" Then
            txtMakeCharge.Text = Format((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * (Val(txtMetalWeight.Text) + AsGoldStoneWeight())) / (Val(txtMetalWeight.Text) + AsGoldStoneWeight()), "0.000")
        Else
            txtMakeCharge.Text = Format((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * Val(txtMetalWeight.Text)) / Val(txtMetalWeight.Text), "0.000")
        End If
    End Sub
    Private Function AsGoldStoneWeight() As Decimal
        AsGoldStoneWeight = 0
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
        Return AsGoldStoneWeight = StoneWeight1 + StoneWeight2 + StoneWeight3
    End Function
    Private Sub GetMetalPrice()
        txtMetalPrice.Text = If(Val(txtMetalWeight.Text) = 0, "", (Val(txtMakeCharge.Text) + Val(txtPricePerGram.Text)) * Val(txtMetalWeight.Text))
    End Sub
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtMetalPrice.TextChanged
        If txtMetalPrice.Focused = True Then
            GetMakeValue()
            StoneAsGoldPrice()
            GetTotalPrice()
        End If
    End Sub
    Private Sub txtMakeCharge_TextChanged(sender As Object, e As EventArgs) Handles txtMakeCharge.TextChanged
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
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtMetalWeight.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        GetMakeValue()
    End Sub
    Private Sub txtNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMakeCharge.KeyPress, txtStoneWeight1.KeyPress, txtStoneWeight2.KeyPress, txtStoneWeight3.KeyPress, txtStonePrice1.KeyPress, txtStonePrice2.KeyPress, txtStonePrice3.KeyPress, txtMetalWeight.KeyPress, txtPricePerGram.KeyPress, txtMetalPrice.KeyPress, txtTotalPrice.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        ValidateTextbox(sender, 2, e)
    End Sub


    Private Sub txtPricePerGram_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerGram.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        GetMetalPrice()
        StoneAsGoldPrice()
        GetTotalPrice()
    End Sub

    Private Sub txtStonePrice_TextChanged(sender As Object, e As EventArgs) Handles txtStonePrice1.TextChanged, txtStonePrice2.TextChanged, txtStonePrice3.TextChanged
        If sender.Focused = True Then
            If Settings.SET_INVARCHR168TextBox.Text = "1" Then
                CalculatePricesAndMC()
            Else
                GetTotalPrice()
            End If

        End If
    End Sub

    Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
        If txtTotalPrice.Focused = True Then
            CalculatePricesAndMC()
        End If
    End Sub

    Private Sub cmbStoneName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStoneName1.SelectedIndexChanged, cmbStoneName2.SelectedIndexChanged, cmbStoneName3.SelectedIndexChanged
        If sender.Focused = True Then
            CalculatePricesAndMC()
        End If
    End Sub
    Private Sub CalculatePricesAndMC()
        Dim TotalWeight As Double = Val(txtMetalWeight.Text)
        Dim TotalNonAsGoldPrice As Double
        If Settings.SET_INVARCHR168TextBox.Text = "1" Then
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

        txtMakeCharge.Text = ((Val(txtTotalPrice.Text) - TotalNonAsGoldPrice) / TotalWeight) - Val(txtPricePerGram.Text)
        GetMetalPrice()
        StoneAsGoldPrice()
    End Sub

    Private Sub txtStoneWeight_TextChanged(sender As Object, e As EventArgs) Handles txtStoneWeight1.TextChanged, txtStoneWeight2.TextChanged, txtStoneWeight3.TextChanged
        If sender.Focused = True Then
            CalculatePricesAndMC()
        End If
    End Sub
    Private Sub StoneAsGoldPrice()
        If Settings.SET_INVARCHR168TextBox.Text = "1" Then
            If cmbStoneName1.SelectedValue = True Then
                txtStonePrice1.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight1.Text)
            End If
            If cmbStoneName2.SelectedValue = True Then
                txtStonePrice2.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight2.Text)
            End If
            If cmbStoneName3.SelectedValue = True Then
                txtStonePrice3.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight3.Text)
            End If
        End If
    End Sub

    Private Sub GoldAddItem_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        GoldSellEditRemove.PerformSearch()
        Dispose()
    End Sub
End Class