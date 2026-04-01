Public Class DiamondAddItem
    Dim CustomerCID As String
    Dim CashierID As String
    Dim INV_ID As String
    Dim TIM_INV As Date
    Dim USER As String
    Dim DATE_INV As Date
    Public Sub count_total_price()
        Dim a As Double
        For i As Integer = 0 To grid.RowCount - 1
            a += grid.Rows(i).Cells("Price").Value
        Next
        Add_ITEMtxtTotalPrice.Text = a
    End Sub
    Private Sub GetGramPrice()
        If txtGoldCarat.Text = "24" Then
            txtGramPrice.Text = gold24
        ElseIf txtGoldCarat.Text = "22" Then
            txtGramPrice.Text = gold22
        ElseIf txtGoldCarat.Text = "21" Then
            txtGramPrice.Text = gold21
        ElseIf txtGoldCarat.Text = "18" Then
            txtGramPrice.Text = gold18
        End If
    End Sub
    Public Sub FillDiamondCut()
        Dim dt1 As DataTable = GetRecordSet("SELECT [dimon_cat_name] FROM [Dimon_cat]")
        If dt1.Rows.Count > 0 Then
            cmbCut.Items.Clear()
            For i As Integer = 0 To dt1.Rows.Count - 1
                cmbCut.Items.Add(dt1.Rows(i)("dimon_cat_name").ToString)
            Next
        End If

    End Sub
    Public Sub FillStones()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStone1.Items.Clear()
            cmbStone2.Items.Clear()
            cmbStone3.Items.Clear()
            For i As Integer = 0 To dt1.Rows.Count - 1
                cmbStone1.Items.Add(dt1.Rows(i)("EXTR_NAME").ToString)
                cmbStone2.Items.Add(dt1.Rows(i)("EXTR_NAME").ToString)
                cmbStone3.Items.Add(dt1.Rows(i)("EXTR_NAME").ToString)
            Next
        End If

    End Sub
    Public Sub LoadData()
        FillDiamondCut()
        FillStones()

        Dim dt1 As DataTable = GetRecordSet("SELECT [dim_inv_id] AS [dim_inv_id] , [descont] AS [Invoice No], [dimo_id] AS [dimo_id] , [DIMO_Type] AS [Item Name] " &
            ", [DIM_na9awa] AS [Clarity] , [DIMO_qult] AS [Qty] , [DIMO_coler] AS [Color] , [DIMO_mezan] AS [D-Carat] , [sarual] AS [Item No], [val_gold] AS [Karat] " &
            ", [GOLD_mezan] AS [G-Weight] , [test_117] AS [D-Cut] , [total] AS [Price] , [time] AS [Time] , [castomr_id] AS [CID] " &
            ", [test_13] AS [S1-Weight] , [test_14] AS [S1-Type] , [test_15] AS [S1-Color]  " &
            ", [test_16] AS [S2-Weight] , [test_17] AS [S2-Type] , [test_18] AS [S2-Color]  " &
            ", [test_19] AS [S3-Weight] , [test_110] AS [S3-Type] , [test_111] AS [S3-Color]  " &
            ", [test_119] AS [BarCode] " &
            ", [user_creted] AS [User] , [test_118] AS [Cashier] , [date_creted] AS [Date] FROM [dimon_invce] " &
            " WHERE [descont] = " & "'" & DiamondSellEditRemove.txtInvoiceNo.Text.Trim & "'")
        If dt1.Rows.Count > 0 Then
            txtInvoiceNo.Text = DiamondSellEditRemove.txtInvoiceNo.Text.Trim
            grid.DataSource = dt1
            TIM_INV = dt1.Rows(0)("Time").ToString
            CustomerCID = dt1.Rows(0)("CID").ToString
            CashierID = dt1.Rows(0)("Cashier").ToString
            INV_ID = dt1.Rows(0)("Invoice No").ToString
            USER = dt1.Rows(0)("User").ToString
            DATE_INV = dt1.Rows(0)("Date").ToString
        End If
    End Sub
    Private Sub DiamondAddItem_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        DIMON_NAME_FILTERTableAdapter.Fill(Me.DT_restrantDataSet.DIMON_NAME_FILTER)
        Dimon_invceTableAdapter.Fill(DT_restrantDataSet.dimon_invce)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        LoadData()
        InitialState()
    End Sub
    Private Sub InitialState()
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnSave.Enabled = False
        gbItemData.Enabled = False
        gbSelectItem.Enabled = False
        grid.Enabled = False
    End Sub
    Private Sub txtBarCode_TextChanged(sender As Object, e As EventArgs) Handles txtBarCode.TextChanged
        Try
            cmbItemName.SelectedValue = txtBarCode.Text.Trim
        Catch ex As Exception
            cmbItemName.SelectedIndex = -1
        End Try
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [DIMON_BARICOOD_LEFT] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        If dt1.Rows.Count > 0 Then

            ClearTextBox(gbItemData)
            txtDimonID.Text = dt1.Rows(0)("Dimond_ID").ToString
            txtCost.Text = dt1.Rows(0)("test_12").ToString
            txtDiamondColor.Text = dt1.Rows(0)("ext_coler").ToString
            txtDiamondWeight.Text = dt1.Rows(0)("DIMO_mezan").ToString
            txtDiamondClarity.Text = dt1.Rows(0)("DIM_na9awa").ToString
            cmbCut.Text = dt1.Rows(0)("test_11").ToString
            txtItemNo.Text = dt1.Rows(0)("DIMOND_ID").ToString
            txtQty.Text = "1"
            txtGoldCarat.Text = dt1.Rows(0)("val_gold").ToString
            txtGoldWeight.Text = dt1.Rows(0)("GOLD_mezan").ToString

            txtStoneWeight1.Text = dt1.Rows(0)("test_13").ToString
            cmbStone1.Text = dt1.Rows(0)("test_14").ToString
            txtStoneColor1.Text = dt1.Rows(0)("test_15").ToString

            txtStoneWeight2.Text = dt1.Rows(0)("test_16").ToString
            cmbStone2.Text = dt1.Rows(0)("test_17").ToString
            txtStoneColor2.Text = dt1.Rows(0)("test_18").ToString

            txtStoneWeight3.Text = dt1.Rows(0)("test_19").ToString
            cmbStone3.Text = dt1.Rows(0)("test_110").ToString
            txtStoneColor3.Text = dt1.Rows(0)("test_111").ToString

            txtPrice.Text = dt1.Rows(0)("test_1").ToString
            txtTotalWeight.Text = dt1.Rows(0)("test_116").ToString
            GetGramPrice()
        End If


    End Sub
    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtBarCode.Text = cmbItemName.SelectedValue
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbItemName.Text = "اخترالصنف" OrElse cmbItemName.Text = "Select Item" OrElse cmbItemName.Text.Trim = "" Then
            MsgBox("اختر اسم الصنف اولا" & vbCrLf & "Select Item Name", , Apptitle)
            cmbItemName.DroppedDown = True
            Exit Sub
        End If

        If cmbCut.Text = "" Then
            MsgBox("اختر نوع القصة للقطعة" & vbCrLf & "Select Diamond Cut", , Apptitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If

        If Val(txtGramPrice.Text.Trim) = 0 OrElse IsNumeric(txtGramPrice.Text.Trim) = False Then
            If txtGoldCarat.Text <> "0" Then
                MsgBox("اكتب سعر جرام الذهب" & vbCrLf & "Enter G.Price Per Gram", , Apptitle)
                txtGramPrice.SelectAll()
                txtGramPrice.Focus()
                Exit Sub
            Else
                txtGramPrice.Text = "0"
            End If
        End If

        If txtPrice.Text.Trim = "" OrElse IsNumeric(txtPrice.Text.Trim) = False Then
            MsgBox("اكتب السعر" & vbCrLf & "Enter Price", , AppTitle)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        If Val(txtPrice.Text.Trim) <= Val(txtCost.Text) Then
            If MsgBox("سعر البيع أقل من سعر التكلفة..هل تريد البيع؟" & vbCrLf & "Selling Price is Lower than Cost, Proceed with Selling?", vbYesNo, Apptitle) <> vbYes Then
                txtPrice.SelectAll()
                txtPrice.Focus()
                Exit Sub
            End If
        End If
        If SET_INVARCHR152TextBox.Text.Trim = "1" Then
            For i As Integer = 0 To grid.RowCount - 1
                If txtBarCode.Text.Trim = grid.Rows(i).Cells("dimo_id").Value.ToString.Trim Then
                    MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , Apptitle)
                    Exit Sub
                End If
            Next
        End If
        Select Case grid.Enabled
            Case True ' Edit
                GlCommand.CommandText = "UPDATE [dimon_invce] SET " &
                                        "[total] = @total , " &
                                        "[ar_taype] = @ar_taype , " &
                                        "[DIMO_Type] = @DIMO_Type , " &
                                        "[DIM_na9awa] = @DIM_na9awa , " &
                                        "[DIMO_mezan] = @DIMO_mezan , " &
                                        "[DIMO_coler] = @DIMO_coler , " &
                                        "[DIMO_qult] = @DIMO_qult , " &
                                        "[sarual] = @sarual , " &
                                        "[val_gold] = @val_gold , " &
                                        "[GOLD_mezan] = @GOLD_mezan , " &
                                        "[test_13] = @test_13 , " &
                                        "[test_14] = @test_14 , " &
                                        "[test_15] = @test_15 , " &
                                        "[test_16] = @test_16 , " &
                                        "[test_17] = @test_17 , " &
                                        "[test_18] = @test_18 , " &
                                        "[test_19] = @test_19 , " &
                                        "[test_110] = @test_110 , " &
                                        "[test_111] = @test_111 , " &
                                        "[test_112] = @test_112 , " &
                                        "[test_116] = @test_116 , " &
                                        "[test_117] = @test_117 , " &
                                        "[test_118] = @test_118 , " &
                                        "[test_119] = @test_119 , " &
                                        "[notes] = @notes , " &
                                        "[Item_Actv] = @Item_Actv , " &
                                        "[staytes] = @staytes " &
                                        "WHERE [dim_inv_id] = '" & grid.SelectedRows(0).Cells("dim_inv_id").Value & "'"

                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@total", Val(txtPrice.Text.Trim))
                    .AddWithValue("@ar_taype", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                    .AddWithValue("@DIMO_Type", cmbItemName.Text.Trim)
                    .AddWithValue("@DIM_na9awa", txtDiamondClarity.Text.Trim)
                    .AddWithValue("@DIMO_mezan", txtDiamondWeight.Text.Trim)
                    .AddWithValue("@DIMO_coler", txtDiamondColor.Text.Trim)
                    .AddWithValue("@DIMO_qult", txtQty.Text.Trim)
                    .AddWithValue("@sarual", txtItemNo.Text.Trim)
                    .AddWithValue("@val_gold", txtGoldCarat.Text.Trim)
                    .AddWithValue("@GOLD_mezan", txtGoldWeight.Text.Trim)
                    .AddWithValue("@test_13", txtStoneWeight1.Text.Trim)
                    .AddWithValue("@test_14", cmbStone1.Text.Trim)
                    .AddWithValue("@test_15", txtStoneColor1.Text.Trim)
                    .AddWithValue("@test_16", txtStoneWeight2.Text.Trim)
                    .AddWithValue("@test_17", cmbStone2.Text.Trim)
                    .AddWithValue("@test_18", txtStoneColor2.Text.Trim)
                    .AddWithValue("@test_19", txtStoneWeight3.Text.Trim)
                    .AddWithValue("@test_110", cmbStone3.Text.Trim)
                    .AddWithValue("@test_111", txtStoneColor3.Text.Trim)
                    .AddWithValue("@test_112", DBNull.Value)
                    .AddWithValue("@test_116", txtTotalWeight.Text.Trim)
                    .AddWithValue("@test_117", cmbCut.Text.Trim)
                    .AddWithValue("@test_118", CashierID)
                    .AddWithValue("@test_119", txtBarCode.Text.Trim)
                    .AddWithValue("@notes", txtNotes.Text.Trim)
                    .AddWithValue("@Item_Actv", 1)
                    .AddWithValue("@staytes", 1)
                End With
                GlCommand.ExecuteNonQuery()
            Case False 'Add
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
                                        "[staytes])" &
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
                                        "@staytes)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@dimo_id", txtDimonID.Text.Trim)
                    .AddWithValue("@castomr_id", CustomerCID)
                    .AddWithValue("@descont", INV_ID)
                    .AddWithValue("@total", Val(txtPrice.Text.Trim))
                    .AddWithValue("@ar_taype", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                    .AddWithValue("@DIMO_Type", cmbItemName.Text.Trim)
                    .AddWithValue("@DIM_na9awa", txtDiamondClarity.Text.Trim)
                    .AddWithValue("@DIMO_mezan", txtDiamondWeight.Text.Trim)
                    .AddWithValue("@DIMO_coler", txtDiamondColor.Text.Trim)
                    .AddWithValue("@DIMO_qult", txtQty.Text.Trim)
                    .AddWithValue("@sarual", txtItemNo.Text.Trim)
                    .AddWithValue("@val_gold", txtGoldCarat.Text.Trim)
                    .AddWithValue("@GOLD_mezan", txtGoldWeight.Text.Trim)
                    .AddWithValue("@user_creted", USER)
                    .AddWithValue("@date_creted", Format(DATE_INV, "yyyy-MM-dd"))
                    .AddWithValue("@time", Format(TIM_INV, "yyyy-MM-dd HH:mm:ss"))
                    .Add("@dim_foto", SqlDbType.Image).Value = DBNull.Value
                    .AddWithValue("@test_13", txtStoneWeight1.Text.Trim)
                    .AddWithValue("@test_14", cmbStone1.Text.Trim)
                    .AddWithValue("@test_15", txtStoneColor1.Text.Trim)
                    .AddWithValue("@test_16", txtStoneWeight2.Text.Trim)
                    .AddWithValue("@test_17", cmbStone2.Text.Trim)
                    .AddWithValue("@test_18", txtStoneColor2.Text.Trim)
                    .AddWithValue("@test_19", txtStoneWeight3.Text.Trim)
                    .AddWithValue("@test_110", cmbStone3.Text.Trim)
                    .AddWithValue("@test_111", txtStoneColor3.Text.Trim)
                    .AddWithValue("@test_112", DBNull.Value)
                    .AddWithValue("@test_116", txtTotalWeight.Text.Trim)
                    .AddWithValue("@test_117", cmbCut.Text.Trim)
                    .AddWithValue("@test_118", CashierID)
                    .AddWithValue("@test_119", txtBarCode.Text.Trim)
                    .AddWithValue("@notes", txtNotes.Text.Trim)
                    .AddWithValue("@Item_Actv", 1)
                    .AddWithValue("@staytes", 1)
                End With
                GlCommand.ExecuteNonQuery()
        End Select
        LoadData()
        count_total_price()
        DiamondSellEditRemove.ViewInvoice()
        DiamondSellEditRemove.payment_process()
        InitialState()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        gbItemData.Enabled = True
        gbSelectItem.Enabled = True
        grid.Enabled = False
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            txtBarCode.Text = grid.SelectedRows(0).Cells("BarCode").Value
            txtPrice.Text = grid.SelectedRows(0).Cells("Price").Value
            txtDiamondColor.Text = grid.SelectedRows(0).Cells("Color").Value
            txtDiamondWeight.Text = grid.SelectedRows(0).Cells("D-Carat").Value
            txtDiamondClarity.Text = grid.SelectedRows(0).Cells("Clarity").Value
            cmbCut.Text = grid.SelectedRows(0).Cells("D-Cut").Value
            txtItemNo.Text = grid.SelectedRows(0).Cells("Item No").Value
            txtQty.Text = grid.SelectedRows(0).Cells("Qty").Value
            txtGoldCarat.Text = grid.SelectedRows(0).Cells("Karat").Value
            txtGoldWeight.Text = grid.SelectedRows(0).Cells("G-Weight").Value

            txtStoneWeight1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S1-Weight").Value), "", grid.SelectedRows(0).Cells("S1-Weight").Value)
            cmbStone1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S1-Type").Value), "", grid.SelectedRows(0).Cells("S1-Type").Value)
            txtStoneColor1.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("S1-Color").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("S1-Color").Value)

            txtStoneWeight2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S2-Weight").Value), "", grid.SelectedRows(0).Cells("S2-Weight").Value)
            cmbStone2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S2-Type").Value), "", grid.SelectedRows(0).Cells("S2-Type").Value)
            txtStoneColor2.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("S2-Color").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("S2-Color").Value)

            txtStoneWeight3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S3-Weight").Value), "", grid.SelectedRows(0).Cells("S3-Weight").Value)
            cmbStone3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("S3-Type").Value), "", grid.SelectedRows(0).Cells("S3-Type").Value)
            txtStoneColor3.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("S3-Color").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("S3-Color").Value)

            GetGramPrice()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnAdd.Enabled = False
        btnSave.Enabled = True
        gbItemData.Enabled = True
        gbSelectItem.Enabled = True
        grid.Enabled = True
        cmbItemName.Enabled = False
        txtBarCode.Enabled = False
    End Sub
    Private Sub DiamondAddItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub


End Class