Imports DT_restrant.DT_restrantDataSetTableAdapters
Public Class DiamondEditAddItem
    Dim InvoiceNo, CurrentCustomerID, CashierID, InvoiceID, CurrentUser As String
    Dim InvoiceTime, InvoiceDate As Date
    Public Notes As String
    Dim RemainingGoldWeight As Double
    Private Sub DiamondEditAddItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Saved = False
        Dispose()
    End Sub

    Private Sub DiamondEditAddItem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        Visible = False
        If Val(gold24) = 0 Then
            GetPricesOffline()
        End If
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        GetGoldKarat()
        ITEM_IMGEPictureBox.Image = Nothing
        Daymon_bay_saryailTableAdapter.Fill(DT_restrantDataSet.daymon_bay_saryail)
        Dim dt1 As DataTable = GetRecordSet("SELECT [chkLimitStock] FROM [user] WHERE [user_id] = N'" & UserID & "'")
        If dt1.Rows.Count > 0 Then
            Select Case dt1.Rows(0)(0)
                Case True
                    FillDiamondItems(True)

                Case False
                    FillDiamondItems(False)
            End Select
        End If

        If SET_INVARCHR19TextBox.Text = "1" Then 'اخفاء التكلفة
            lblCost.Visible = False
            txtCost.Visible = False
        End If
        If SET_INVARCHR170TextBox.Text = "1" Then 'منع تعديل وزن الذهب
            txtGoldWeight.ReadOnly = True
        End If
        txtBarCode.Text = "1"
        txtBarCode.Text = ""
        txtQty.Text = ""
        GetDiamondCut()
        FillStoneName()
        FillStoneColor()
        FillSoldItemNames()
        ClearCombo()
        LoadData()
        cmbItemName.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.DIMON_NAME_FILTER, "DIMO_dep", cmbItemName)
        If SET100TextBox.Text = "1" Then
            cmbItemName.DropDownStyle = ComboBoxStyle.Simple
        End If
        Visible = True
    End Sub
    Public Sub LoadData()
        Dim dt1 As DataTable = GetRecordSet("SELECT [descont] AS [Invoice No], [time] AS [Time] , [castomr_id] AS [CID] " &
            ", [user_creted] AS [User] , [test_118] AS [Cashier] , [date_creted] AS [Date] FROM [dimon_invce] " &
            " WHERE [descont] = N'" & DiamondSellEditRemove.txtInvoiceNo.Text.Trim & "'")
        If dt1.Rows.Count > 0 Then
            InvoiceNo = DiamondSellEditRemove.txtInvoiceNo.Text.Trim
            InvoiceTime = dt1.Rows(0)("Time").ToString
            CurrentCustomerID = dt1.Rows(0)("CID").ToString
            CashierID = dt1.Rows(0)("Cashier").ToString
            InvoiceID = dt1.Rows(0)("Invoice No").ToString
            CurrentUSER = dt1.Rows(0)("User").ToString
            InvoiceDate = dt1.Rows(0)("Date").ToString
        End If
    End Sub
    Private Sub FillDiamondItems(chkLimitItem As Boolean)
        Dim SQLString As String = String.Empty

        If SET_INVARCHR152TextBox.Text = "1" Then
            If chkLimitItem = True Then
                SQLString = "SELECT DIMON_detels.DIMO_dep AS [ItemName] , DIMON_detels.test_119 AS [BarCode]" &
                            "From DIMON_detels LEFT OUTER Join dimon_invce On DIMON_detels.test_119 = dimon_invce.dimo_id " &
                            "Where dimon_invce.dimo_id Is NULL And DIMON_detels.test_119 LIKE '" & UserName & "%' " &
                            "GROUP BY  DIMON_detels.DIMO_dep, DIMON_detels.test_119"
            Else
                SQLString = "SELECT DIMON_detels.DIMO_dep AS [ItemName] , DIMON_detels.test_119 AS [BarCode]" &
                            "From DIMON_detels LEFT OUTER Join dimon_invce On DIMON_detels.test_119 = dimon_invce.dimo_id " &
                            "Where dimon_invce.dimo_id Is NULL " &
                            "GROUP BY  DIMON_detels.DIMO_dep, DIMON_detels.test_119"
            End If
        Else
            If chkLimitItem = True Then
                SQLString = "SELECT [DIMO_dep] AS [ItemName] , [test_119] AS [BarCode] FROM [DIMON_detels] WHERE [Item_Actv] <> 0  AND [test_119] LIKE '" & UserName & "%'"
            Else
                SQLString = "SELECT [DIMO_dep] AS [ItemName] , [test_119] AS [BarCode] FROM [DIMON_detels] WHERE [Item_Actv] <> 0 "
            End If
        End If

        Dim dt1 As DataTable = GetRecordSet(SQLString)
        If dt1.Rows.Count > 0 Then
            With cmbItemName
                .DataSource = dt1
                .DisplayMember = "ItemName"
                .ValueMember = "BarCode"
            End With
        End If
    End Sub
    Private Sub GetGoldKarat()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Gram_valu] FROM [Gram_val] WHERE [Gram_valu] <= N'24'")
        If dt1.Rows.Count > 0 Then
            With cmbGoldKarat
                .DataSource = dt1
                .DisplayMember = "Gram_valu"
                .ValueMember = "Gram_valu"
            End With
        End If
    End Sub
    Private Sub GetDiamondCut()
        Dim dt0 As DataTable = GetRecordSet("SELECT [dimon_cat_name] FROM [dimon_cat]")
        If dt0.Rows.Count > 0 Then
            With cmbCut
                .DataSource = dt0
                .DisplayMember = "dimon_cat_name"
                .ValueMember = "dimon_cat_name"
            End With
        End If
        Dim dt1 As DataTable = GetRecordSet("SELECT [dimon_cat_name] FROM [dimon_cat]")
        If dt1.Rows.Count > 0 Then
            With cmbStoneCut1
                .DataSource = dt1
                .DisplayMember = "dimon_cat_name"
                .ValueMember = "dimon_cat_name"
            End With
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [dimon_cat_name] FROM [dimon_cat]")
        If dt2.Rows.Count > 0 Then
            With cmbStoneCut2
                .DataSource = dt2
                .DisplayMember = "dimon_cat_name"
                .ValueMember = "dimon_cat_name"
            End With
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [dimon_cat_name] FROM [dimon_cat]")
        If dt3.Rows.Count > 0 Then
            With cmbStoneCut3
                .DataSource = dt3
                .DisplayMember = "dimon_cat_name"
                .ValueMember = "dimon_cat_name"
            End With
        End If
    End Sub
    Private Sub FillStoneName()
        Dim dt1 As DataTable = GetRecordSet("SELECT [IsDiamond] , [EXTR_NAME] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStone1.DataSource = dt1
            cmbStone1.DisplayMember = "EXTR_NAME"
            cmbStone1.ValueMember = "IsDiamond"
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [IsDiamond] , [EXTR_NAME] FROM [EXTR_NAME]")
        If dt2.Rows.Count > 0 Then
            cmbStone2.DataSource = dt2
            cmbStone2.DisplayMember = "EXTR_NAME"
            cmbStone2.ValueMember = "IsDiamond"
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [IsDiamond] , [EXTR_NAME] FROM [EXTR_NAME]")
        If dt3.Rows.Count > 0 Then
            cmbStone3.DataSource = dt3
            cmbStone3.DisplayMember = "EXTR_NAME"
            cmbStone3.ValueMember = "IsDiamond"
        End If
    End Sub
    Private Sub FillStoneColor()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [StoneColor] FROM [StoneColor]")
        If dt1.Rows.Count > 0 Then
            cmbStoneColor1.DataSource = dt1
            cmbStoneColor1.DisplayMember = "StoneColor"
            cmbStoneColor1.ValueMember = "ID"
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [ID] , [StoneColor] FROM [StoneColor]")
        If dt2.Rows.Count > 0 Then
            cmbStoneColor2.DataSource = dt2
            cmbStoneColor2.DisplayMember = "StoneColor"
            cmbStoneColor2.ValueMember = "ID"
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [ID] , [StoneColor] FROM [StoneColor]")
        If dt3.Rows.Count > 0 Then
            cmbStoneColor3.DataSource = dt3
            cmbStoneColor3.DisplayMember = "StoneColor"
            cmbStoneColor3.ValueMember = "ID"
        End If
    End Sub
    Private Sub FillSoldItemNames()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Item_Name_ID] , [Item_Name] FROM [Item_Name]")
        If dt1.Rows.Count > 0 Then
            cmbSoldItemNames.DataSource = dt1
            cmbSoldItemNames.DisplayMember = "Item_Name"
            cmbSoldItemNames.ValueMember = "Item_Name_ID"
        End If
    End Sub

    Private Sub ClearCombo()
        cmbCut.ResetText()
        cmbCut.SelectedIndex = -1
        cmbStone1.ResetText()
        cmbStone1.SelectedIndex = -1
        cmbStone2.ResetText()
        cmbStone2.SelectedIndex = -1
        cmbStone3.ResetText()
        cmbStone3.SelectedIndex = -1
        cmbStoneColor1.ResetText()
        cmbStoneColor1.SelectedIndex = -1
        cmbStoneColor2.ResetText()
        cmbStoneColor2.SelectedIndex = -1
        cmbStoneColor3.ResetText()
        cmbStoneColor3.SelectedIndex = -1
        cmbStoneCut1.ResetText()
        cmbStoneCut1.SelectedIndex = -1
        cmbStoneCut2.ResetText()
        cmbStoneCut2.SelectedIndex = -1
        cmbStoneCut3.ResetText()
        cmbStoneCut3.SelectedIndex = -1
        cmbSoldItemNames.ResetText()
        cmbSoldItemNames.SelectedIndex = -1
    End Sub
    Private Sub ClearSelection()
        cmbItemName.SelectedIndex = -1
        ClearControls(gbItemData)
        ClearCombo()
        txtQty.Text = ""
        txtPrice.Text = ""
        txtCost.Text = ""
        RemainingGoldWeight = 0
        txtTotalWeight.Text = ""
        cmbGoldKarat.SelectedIndex = -1
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex = -1 Then
            ClearSelection()
            Exit Sub
        End If
        If cmbItemName.Focused = True Then
            txtBarCode.Text = cmbItemName.SelectedValue
        End If
    End Sub

    Private Sub txtBarCode_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBarCode.MouseClick
        txtBarCode.SelectAll()
    End Sub

    Private Sub txtBarCode_TextChanged(sender As Object, e As EventArgs) Handles txtBarCode.TextChanged
        Try
            cmbItemName.SelectedValue = txtBarCode.Text.Trim
        Catch ex As Exception
            cmbItemName.SelectedIndex = -1
        End Try

        If txtBarCode.Text = "" OrElse cmbItemName.SelectedValue = Nothing OrElse cmbItemName.SelectedValue.ToString.ToUpper <> txtBarCode.Text.Trim.ToUpper Then
            ClearSelection()
            Exit Sub
        End If

        ClearCombo()
        txtGramPrice.Text = ""

        If SET_INVARCHR152TextBox.Text = "1" Then
            If OriginalPiecesQty() - SoldPiecesQty() <= 0 Then
                MsgBox("تم بيع القطعة من قبل" & vbCrLf & "Item sold.",, AppTitle)
                Exit Sub
            End If
        End If

        Try
            DIMON_detelsTableAdapter.FillBy1(DT_restrantDataSet.DIMON_detels, txtBarCode.Text)
            DIMO_TypeTextBox.Text = DIMO_depTextBox.Text
            DIMO_colerTextBox.Text = Ext_colerTextBox.Text
        Catch ex As Exception
            txtBarCode.Text = 0
            txtBarCode.Select()
        End Try
        cmbSoldItemNames.Text = cmbItemName.Text
        Dimo_idTextBox.Text = DIMOND_IDTextBox.Text
        Castomr_idTextBox.Text = CastomerCAIVELidTextBox.Text
        DIM_na9awaTextBox.Text = txtClarity.Text
        DIMO_mezanTextBox.Text = DIMO_mezanTextBox1.Text
        DIMO_colerTextBox.Text = Ext_colerTextBox.Text
        DIMO_qultTextBox.Text = txtQty.Text
        SarualTextBox.Text = SarualTextBox1.Text
        Val_goldTextBox.Text = Val_goldTextBox1.Text
        If SET_INVARCHR152TextBox.Text = "1" Then
            txtGoldWeight.Text = OriginalGoldWeight() - SoldGoldWeight()
            If Val(txtGoldWeight.Text) <= 0 Then
                txtGoldWeight.ForeColor = Color.Red
            Else
                txtGoldWeight.ForeColor = Color.Black
            End If
        Else
            txtGoldWeight.Text = GOLD_mezanTextBox1.Text
            txtGoldWeight.ForeColor = Color.Black
        End If
        RemainingGoldWeight = txtGoldWeight.Text
        User_cretedTextBox.Text = frmLogin.User_idTextBox.Text
        Castomr_idTextBox.Text = CastomerCAIVELidTextBox.Text
        cmbCut.Text = Test_11TextBox.Text
        txtDiamondWeight.Text = DIMO_mezanTextBox1.Text
        txtDiamondColor.Text = DIMO_colerTextBox.Text
        txtDiamondColor.Text = Ext_colerTextBox.Text
        txtItemNo.Text = SarualTextBox1.Text
        cmbGoldKarat.SelectedValue = Val_goldTextBox1.Text
        txtStoneWeight1.Text = Test_13TextBox1.Text
        cmbStone1.Text = Test_14TextBox1.Text
        cmbStoneColor1.Text = Test_15TextBox1.Text
        txtStoneClarity1.Text = Clarity1TextBox.Text
        cmbStoneCut1.Text = Cut1TextBox.Text
        txtStoneWeight2.Text = Test_16TextBox1.Text
        cmbStone2.Text = Test_17TextBox1.Text
        cmbStoneColor2.Text = Test_18TextBox1.Text
        txtStoneClarity2.Text = Clarity2TextBox.Text
        cmbStoneCut2.Text = Cut2TextBox.Text
        txtStoneWeight3.Text = Test_19TextBox1.Text
        cmbStone3.Text = Test_110TextBox1.Text
        cmbStoneColor3.Text = Test_111TextBox1.Text
        txtStoneClarity3.Text = Clarity3TextBox.Text
        cmbStoneCut3.Text = Cut3TextBox.Text
        txtPrice.Text = Test_1TextBox.Text
        txtCost.Text = If(SET3TextBox.Text = "1", CostToSellerTextBox.Text, Test_12TextBox.Text)

        txtTotalWeight.Text = GetTotalWeight()
        txtQty.Text = OriginalPiecesQty() - SoldPiecesQty()
        GetGramPrice()
        txtBarCode.Select()
    End Sub
    Private Function OriginalGoldWeight() As Double
        Dim dt1 As DataTable = GetRecordSet("SELECT [GOLD_Mezan] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        OriginalGoldWeight = Val(dt1.Rows(0)(0).ToString)
    End Function
    Private Function SoldGoldWeight() As Double
        Dim dt1 As DataTable = GetRecordSet("SELECT SUM(GOLD_Mezan) FROM [dimon_invce] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "' AND [Item_Actv] = N'1'")
        If dt1.Rows.Count > 0 Then
            SoldGoldWeight = Val(dt1.Rows(0)(0).ToString)
        Else
            SoldGoldWeight = 0
        End If
    End Function
    Private Function OriginalPiecesQty() As Integer
        Dim dt1 As DataTable = GetRecordSet("SELECT [test_117] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        OriginalPiecesQty = If(IsDBNull(dt1.Rows(0)(0)), 1, Val(dt1.Rows(0)(0).ToString))
    End Function
    Private Function SoldPiecesQty() As Integer
        Dim dt1 As DataTable = GetRecordSet("SELECT SUM(DIMO_qult) FROM [dimon_invce] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "' AND [Item_Actv] = N'1'")
        If dt1.Rows.Count > 0 Then
            SoldPiecesQty = Val(dt1.Rows(0)(0).ToString)
        Else
            SoldPiecesQty = 0
        End If
    End Function
    Private Sub GetGramPrice()
        If Val_goldTextBox1.Text = "24" Then
            txtGramPrice.Text = gold24
        ElseIf Val_goldTextBox1.Text = "22" Then
            txtGramPrice.Text = gold22
        ElseIf Val_goldTextBox1.Text = "21" Then
            txtGramPrice.Text = gold21
        ElseIf Val_goldTextBox1.Text = "18" Then
            txtGramPrice.Text = gold18
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbItemName.Text = "اختر الصنف" OrElse cmbItemName.Text = "Select Item" OrElse cmbItemName.Text.Trim = "" Then
            MsgBox("اختر اسم الصنف اولا" & vbCrLf & "Select Item Name", , AppTitle)
            cmbItemName.DroppedDown = True
            Exit Sub
        End If

        If txtQty.Text = "0" OrElse txtQty.Text = "" Then
            MsgBox("اختر عدد القطع اولا" & vbCrLf & "Select Quantity First", , AppTitle)
            cmbItemName.DroppedDown = True
            Exit Sub
        End If

        If cmbCut.Text = "" Then
            MsgBox("اختر نوع القصة للقطعة" & vbCrLf & "Select Diamond Cut", , AppTitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If

        If Val(txtGramPrice.Text.Trim) = 0 OrElse IsNumeric(txtGramPrice.Text.Trim) = False Then
            If cmbGoldKarat.Text <> "0" Then
                MsgBox("اكتب سعر جرام الذهب" & vbCrLf & "Enter G.Price Per Gram", , AppTitle)
                txtGramPrice.SelectAll()
                txtGramPrice.Focus()
                Exit Sub
            Else
                txtGramPrice.Text = "0"
            End If
        End If

        If SET_INVARCHR152TextBox.Text = "1" AndAlso (RemainingGoldWeight <= 0 OrElse Val(txtGoldWeight.Text) > RemainingGoldWeight) Then
            MsgBox("وزن الذهب المكتوب أكبر من وزن ذهب القطعة غير المباع" & vbCrLf & "Gold Weight is greater than not sold gold weight!", , AppTitle)
            txtGoldWeight.SelectAll()
            txtGoldWeight.Focus()
            Exit Sub
        End If

        If Val(txtPrice.Text.Trim) = 0 OrElse IsNumeric(txtPrice.Text.Trim) = False Then
            If MsgBox("سعر الذهب صفر. هل تريد الاستمرار؟" & vbCrLf & "Gold Price is Zero, Continue?", vbYesNo, AppTitle) = vbNo Then
                txtPrice.SelectAll()
                txtPrice.Focus()
            End If

            Exit Sub
        End If

        If Val(txtPrice.Text.Trim) < Val(Test_12TextBox.Text) Then
            If MsgBox("سعر البيع أقل من سعر التكلفة..هل تريد البيع؟" & vbCrLf & "Selling Price is Lower than Cost, Proceed with Selling?", vbYesNo, AppTitle) <> vbYes Then
                txtPrice.SelectAll()
                txtPrice.Focus()
                Exit Sub
            End If
        End If
        If txtStoneWeight1.Text.Trim = "" Then txtStoneWeight1.Text = "0"
        If txtStoneWeight2.Text.Trim = "" Then txtStoneWeight2.Text = "0"
        If txtStoneWeight3.Text.Trim = "" Then txtStoneWeight3.Text = "0"
        GlCommand.CommandText = "INSERT INTO dimon_invce (" &
                                        "[dimo_id] , " &
                                        "[castomr_id] , " &
                                        "[descont]  , " &
                                        "[total] , " &
                                        "[ar_taype] , " &
                                        "[DIMO_Type] , " &
                                        "[DIM_na9awa] , " &
                                        "[DIMO_mezan] , " &
                                        "[DIMO_coler] , " &
                                        "[DIMO_qult] , " &
                                        "[sarual] , " &
                                        "[val_gold] , " &
                                        "[GOLD_mezan] , " &
                                        "[user_creted] , " &
                                        "[date_creted] , " &
                                        "[time] , " &
                                        "[dim_foto] , " &
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
                                        "[test_116] , " &
                                        "[test_117] , " &
                                        "[test_118] , " &
                                        "[test_119] , " &
                                        "[notes] , " &
                                        "[Item_Actv] , " &
                                        "[staytes] ," &
                                        "[GramPrice], " &
                                        "[SoldItem], " &
                                        "[Cut1], " &
                                        "[Clarity1], " &
                                        "[Cut2], " &
                                        "[Clarity2], " &
                                        "[Cut3], " &
                                        "[Clarity3], " &
                                        "[IsDiamond1], " &
                                        "[IsDiamond2], " &
                                        "[IsDiamond3]) " &
                                        " VALUES ( " &
                                        "@dimo_id , " &
                                        "@castomr_id , " &
                                        "@descont  , " &
                                        "@total , " &
                                        "@ar_taype , " &
                                        "@DIMO_Type , " &
                                        "@DIM_na9awa , " &
                                        "@DIMO_mezan , " &
                                        "@DIMO_coler , " &
                                        "@DIMO_qult , " &
                                        "@sarual , " &
                                        "@val_gold , " &
                                        "@GOLD_mezan , " &
                                        "@user_creted , " &
                                        "@date_creted , " &
                                        "@time , " &
                                        "@dim_foto , " &
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
                                        "@test_116 , " &
                                        "@test_117 , " &
                                        "@test_118 , " &
                                        "@test_119 , " &
                                        "@notes , " &
                                        "@Item_Actv , " &
                                        "@staytes, " &
                                        "@GramPrice, " &
                                        "@SoldItem, " &
                                        "@Cut1, " &
                                        "@Clarity1, " &
                                        "@Cut2, " &
                                        "@Clarity2, " &
                                        "@Cut3, " &
                                        "@Clarity3, " &
                                        "@IsDiamond1, " &
                                        "@IsDiamond2, " &
                                        "@IsDiamond3) "
        With GlCommand.Parameters
            .Clear()
            '.AddWithValue("@dimo_id", DIMOND_IDTextBox.Text.Trim)
            .AddWithValue("@dimo_id", txtBarCode.Text.Trim)
            .AddWithValue("@castomr_id", CurrentCustomerID)
            .AddWithValue("@descont", InvoiceID)
            .AddWithValue("@total", Val(txtPrice.Text.Trim))
            .AddWithValue("@ar_taype", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
            .AddWithValue("@DIMO_Type", cmbItemName.Text.Trim)
            .AddWithValue("@DIM_na9awa", txtClarity.Text.Trim)
            .AddWithValue("@DIMO_mezan", txtDiamondWeight.Text.Trim)
            .AddWithValue("@DIMO_coler", txtDiamondColor.Text.Trim)
            .AddWithValue("@DIMO_qult", txtQty.Text.Trim)
            .AddWithValue("@sarual", txtItemNo.Text.Trim)
            .AddWithValue("@val_gold", cmbGoldKarat.Text.Trim)
            .AddWithValue("@GOLD_mezan", txtGoldWeight.Text.Trim)
            .AddWithValue("@user_creted", CurrentUSER)
            .AddWithValue("@date_creted", Format(InvoiceDate, "yyyy-MM-dd"))
            .AddWithValue("@time", Format(InvoiceTime, "yyyy-MM-dd HH:mm:ss"))
            .Add("@dim_foto", SqlDbType.Image).Value = DBNull.Value
            .AddWithValue("@test_13", txtStoneWeight1.Text.Trim)
            .AddWithValue("@test_14", cmbStone1.Text.Trim)
            .AddWithValue("@test_15", cmbStoneColor1.Text.Trim)
            .AddWithValue("@test_16", txtStoneWeight2.Text.Trim)
            .AddWithValue("@test_17", cmbStone2.Text.Trim)
            .AddWithValue("@test_18", cmbStoneColor2.Text.Trim)
            .AddWithValue("@test_19", txtStoneWeight3.Text.Trim)
            .AddWithValue("@test_110", cmbStone3.Text.Trim)
            .AddWithValue("@test_111", cmbStoneColor3.Text.Trim)
            .AddWithValue("@test_112", DBNull.Value)
            .AddWithValue("@test_116", txtTotalWeight.Text.Trim)
            .AddWithValue("@test_117", cmbCut.Text.Trim)
            .AddWithValue("@test_118", CashierID)
            .AddWithValue("@test_119", txtBarCode.Text.Trim)
            .AddWithValue("@notes", txtNotes.Text.Trim)
            .AddWithValue("@Item_Actv", 1)
            .AddWithValue("@staytes", 1)
            .AddWithValue("@GramPrice", txtGramPrice.Text.Trim)
            .AddWithValue("@SoldItem", cmbSoldItemNames.Text)
            .AddWithValue("@Cut1", cmbStoneCut1.Text.Trim)
            .AddWithValue("@Clarity1", txtStoneClarity1.Text.Trim)
            .AddWithValue("@Cut2", cmbStoneCut2.Text.Trim)
            .AddWithValue("@Clarity2", txtStoneClarity2.Text.Trim)
            .AddWithValue("@Cut3", cmbStoneCut3.Text.Trim)
            .AddWithValue("@Clarity3", txtStoneClarity3.Text.Trim)
            .AddWithValue("@IsDiamond1", If(cmbStone1.SelectedIndex = -1, False, cmbStone1.SelectedValue))
            .AddWithValue("@IsDiamond2", If(cmbStone2.SelectedIndex = -1, False, cmbStone2.SelectedValue))
            .AddWithValue("@IsDiamond3", If(cmbStone3.SelectedIndex = -1, False, cmbStone3.SelectedValue))
        End With
        GlCommand.ExecuteNonQuery()
        DiamondSellEditRemove.ViewInvoice()
        DiamondSellEditRemove.payment_process()
        Close()
    End Sub
    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtStoneWeight1.TextChanged, txtStoneWeight2.TextChanged, txtStoneWeight3.TextChanged, txtDiamondWeight.TextChanged
        If SET_INVARCHR170TextBox.Text <> "1" Then
            txtTotalWeight.Text = GetTotalWeight()
        Else
            If sender.Focused = True Then
                txtGoldWeight.Text = GetGoldWeight()
            End If
        End If
    End Sub
    Private Sub txtGoldWeight_TextChanged(sender As Object, e As EventArgs) Handles txtGoldWeight.TextChanged
        If SET_INVARCHR170TextBox.Text <> "1" Then
            txtTotalWeight.Text = GetTotalWeight()
        End If
    End Sub
    Private Sub txtTotalWeight_TextChanged(sender As Object, e As EventArgs) Handles txtTotalWeight.TextChanged
        If sender.Focused = True Then
            If SET_INVARCHR170TextBox.Text = "1" Then
                txtGoldWeight.Text = GetGoldWeight()
            End If
        End If
    End Sub
    Private Function GetTotalWeight() As Decimal
        GetTotalWeight = Val(txtDiamondWeight.Text) * 0.2 + Val(txtStoneWeight1.Text) * 0.2 + Val(txtStoneWeight2.Text) * 0.2 + Val(txtStoneWeight3.Text) * 0.2 + Val(txtGoldWeight.Text)
        Return Math.Round(GetTotalWeight, 3)
    End Function
    Private Function GetGoldWeight() As Decimal
        GetGoldWeight = Val(txtTotalWeight.Text) - Val(txtDiamondWeight.Text) * 0.2 - Val(txtStoneWeight1.Text) * 0.2 - Val(txtStoneWeight2.Text) * 0.2 - Val(txtStoneWeight3.Text) * 0.2
        Return Math.Round(GetGoldWeight, 3)
    End Function

    Private Sub cmbItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbItemName.KeyDown
        If SET100TextBox.Text = "1" Then
            If e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Up Then
                e.Handled = True
                e.SuppressKeyPress = True
            End If
        End If
    End Sub
End Class