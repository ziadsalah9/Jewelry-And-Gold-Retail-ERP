Public Class DiamondAddItemDetails
    Public EditControl As Boolean = False
    Public GetDataBayUser As DataTable
    Public GetAllData As DataTable
    Private Sub dimond_detels_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        TrueFalse = False
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub AddNew()
        With (grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colBarCodeString").Value = ""
            .Rows(.Rows.Count - 1).Cells("colItemName").Value = ""
            .Rows(.Rows.Count - 1).Cells("colItemNo").Value = ""
            .Rows(.Rows.Count - 1).Cells("colKarat").Value = ""
            .Rows(.Rows.Count - 1).Cells("colGWeight").Value = ""
            .Rows(.Rows.Count - 1).Cells("colDCut").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCalrity").Value = ""
            .Rows(.Rows.Count - 1).Cells("colDWeight").Value = ""
            .Rows(.Rows.Count - 1).Cells("colColor").Value = ""
            .Rows(.Rows.Count - 1).Cells("colTotalWeight").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCost").Value = ""
            .Rows(.Rows.Count - 1).Cells("colQty").Value = ""
            .Rows(.Rows.Count - 1).Cells("colPrice").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCostToSeller").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSW1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSN1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSC1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSW2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSN2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSC2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSW3").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSN3").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSC3").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSWType1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSWType2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSWType3").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCut1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCut2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCut3").Value = ""
            .Rows(.Rows.Count - 1).Cells("colClarity1").Value = ""
            .Rows(.Rows.Count - 1).Cells("colClarity2").Value = ""
            .Rows(.Rows.Count - 1).Cells("colClarity3").Value = ""
            .Rows(.Rows.Count - 1).Cells("ColCertificateNo").Value = ""
            .Rows(.Rows.Count - 1).Cells("colTaxExempt").Value = False
            .Rows(.Rows.Count - 1).Cells("colSupplier").Value = ""
            .Rows(.Rows.Count - 1).Cells("colItemNote").Value = ""
            '.Rows(.Rows.Count - 1).Cells("colMetalType").Value = ""

            pbImage.Image = Nothing
            pbDocumentsImage.Image = Nothing
            Supplier()
        End With
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            grid.CurrentCell = grid(0, grid.Rows.Count - 1)
        Else
        End If
    End Sub
    Private Sub GetImg()
        pbImage.Image = Nothing
        pbDocumentsImage.Image = Nothing
        Dim GetImge As DataTable = GetRecordSet("SELECT [DIMOND_ID],[test_119],[Documents],[ITEM_IMGE] FROM [DIMON_detels] where [test_119]=N'" & txtBarCode.Text.Trim & "'")
        If GetImge.Rows.Count > 0 Then

            If Not IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                pbImage.Image = ByteToImage(GetImge.Rows(0)("ITEM_IMGE"))
            ElseIf IsDBNull((GetImge.Rows(0)("ITEM_IMGE"))) Then
                'Exit Sub
            End If
            If Not IsDBNull((GetImge.Rows(0)("Documents"))) Then
                pbDocumentsImage.Image = ByteToImage(GetImge.Rows(0)("Documents"))
            ElseIf IsDBNull((GetImge.Rows(0)("Documents"))) Then
                'Exit Sub
            End If
        End If
    End Sub

    Private Sub dimond_detels_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        ChkBar.Checked = True
        frmMain.Timer1.Stop()
        language_start(Name)
        LoadData()
        BackWorker.RunWorkerAsync()
        btnSave.Enabled = False
        btnPrintBarCode.Enabled = True
        gbItemData.Enabled = False
        min_Items.Hide()
        EditControl = False
        DGV_Style.ApplyGoldenStyle(grid) : DGV_Style.AutoFitColumns(grid)
        cmbStoneWeightType1.SelectedIndex = 0
        cmbStoneWeightType2.SelectedIndex = 0
        cmbStoneWeightType3.SelectedIndex = 0
    End Sub
    Private Sub GridSelectionChanged()
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            cmbCut.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colDCut").Value), "", grid.SelectedRows(0).Cells("colDCut").Value)
            cmbStoneWeightType1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSWType1").Value), "", If(grid.SelectedRows(0).Cells("colSWType1").Value = "", "", grid.SelectedRows(0).Cells("colSWType1").Value))
            cmbStoneWeightType2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSWType2").Value), "", If(grid.SelectedRows(0).Cells("colSWType2").Value = "", "", grid.SelectedRows(0).Cells("colSWType2").Value))
            cmbStoneWeightType3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSWType3").Value), "", If(grid.SelectedRows(0).Cells("colSWType3").Value = "", "", grid.SelectedRows(0).Cells("colSWType3").Value))
            cmbStoneName1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSN1").Value), "", If(grid.SelectedRows(0).Cells("colSN1").Value = "", "", grid.SelectedRows(0).Cells("colSN1").Value))
            cmbStoneName2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSN2").Value), "", If(grid.SelectedRows(0).Cells("colSN2").Value = "", "", grid.SelectedRows(0).Cells("colSN2").Value))
            cmbStoneName3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSN3").Value), "", If(grid.SelectedRows(0).Cells("colSN3").Value = "", "", grid.SelectedRows(0).Cells("colSN3").Value))
            cmbStoneColor1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSC1").Value), "", If(grid.SelectedRows(0).Cells("colSC1").Value = "", "", grid.SelectedRows(0).Cells("colSC1").Value))
            cmbStoneColor2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSC2").Value), "", If(grid.SelectedRows(0).Cells("colSC2").Value = "", "", grid.SelectedRows(0).Cells("colSC2").Value))
            cmbStoneColor3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSC3").Value), "", If(grid.SelectedRows(0).Cells("colSC3").Value = "", "", grid.SelectedRows(0).Cells("colSC3").Value))
            cmbStoneCut1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCut1").Value), "", If(grid.SelectedRows(0).Cells("colCut1").Value = "", "", grid.SelectedRows(0).Cells("colCut1").Value))
            cmbStoneCut2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCut2").Value), "", If(grid.SelectedRows(0).Cells("colCut2").Value = "", "", grid.SelectedRows(0).Cells("colCut2").Value))
            cmbStoneCut3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCut3").Value), "", If(grid.SelectedRows(0).Cells("colCut3").Value = "", "", grid.SelectedRows(0).Cells("colCut3").Value))
            txtStoneWeight1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSW1").Value), "", If(grid.SelectedRows(0).Cells("colSW1").Value = "", "0", grid.SelectedRows(0).Cells("colSW1").Value))
            txtStoneWeight2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSW2").Value), "", If(grid.SelectedRows(0).Cells("colSW2").Value = "", "0", grid.SelectedRows(0).Cells("colSW2").Value))
            txtStoneWeight3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSW3").Value), "", If(grid.SelectedRows(0).Cells("colSW3").Value = "", "0", grid.SelectedRows(0).Cells("colSW3").Value))
            txtClarity1.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colClarity1").Value), "", If(grid.SelectedRows(0).Cells("colClarity1").Value = "", "", grid.SelectedRows(0).Cells("colClarity1").Value))
            txtClarity2.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colClarity2").Value), "", If(grid.SelectedRows(0).Cells("colClarity2").Value = "", "", grid.SelectedRows(0).Cells("colClarity2").Value))
            txtClarity3.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colClarity3").Value), "", If(grid.SelectedRows(0).Cells("colClarity3").Value = "", "", grid.SelectedRows(0).Cells("colClarity3").Value))
            txtItemName.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colItemName").Value), "", grid.SelectedRows(0).Cells("colItemName").Value)
            txtItemNo.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colItemNo").Value), "", grid.SelectedRows(0).Cells("colItemNo").Value)
            txtItemGKarat.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colKarat").Value), "", grid.SelectedRows(0).Cells("colKarat").Value)
            txtItemClarity.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCalrity").Value), "", grid.SelectedRows(0).Cells("colCalrity").Value)
            txtItemDCarat.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colDWeight").Value), "", grid.SelectedRows(0).Cells("colDWeight").Value)
            cmbKarat.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colKarat").Value), "", grid.SelectedRows(0).Cells("colKarat").Value)
            txtItemGWeight.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colGWeight").Value), "", grid.SelectedRows(0).Cells("colGWeight").Value)
            txtItemColor.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colColor").Value), "", grid.SelectedRows(0).Cells("colColor").Value)
            txtItemCost.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCost").Value), "", grid.SelectedRows(0).Cells("colCost").Value)
            txtQty.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colQty").Value), "", grid.SelectedRows(0).Cells("colQty").Value)
            TxtCertificateNo.Text = If(IsDBNull(grid.SelectedRows(0).Cells("ColCertificateNo").Value), "", grid.SelectedRows(0).Cells("ColCertificateNo").Value)
            txtItemPrice.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colPrice").Value), "", grid.SelectedRows(0).Cells("colPrice").Value)
            txtBarCode.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colBarCodeString").Value), "", grid.SelectedRows(0).Cells("colBarCodeString").Value)
            CostToSellerTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colCostToSeller").Value), "", grid.SelectedRows(0).Cells("colCostToSeller").Value)
            TaxExemptCheckBox.Checked = (grid.SelectedRows(0).Cells("colTaxExempt").Value)
            CobUser.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colUser").Value), "", grid.SelectedRows(0).Cells("colUser").Value)
            cobSupplier.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colSupplier").Value), "", (grid.SelectedRows(0).Cells("colSupplier").Value))
            txtItemNote.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colItemNote").Value), "", (grid.SelectedRows(0).Cells("colItemNote").Value))
            cmbMetalType.SelectedIndex = If(IsDBNull(grid.SelectedRows(0).Cells("colMetalType").Value), "1", (grid.SelectedRows(0).Cells("colMetalType").Value))
            If grid.SelectedRows(0).Cells("colItemStatus").Value = 1 Then
                btnSave.Enabled = False
            ElseIf grid.SelectedRows(0).Cells("colItemStatus").Value = 0 Then
                btnSave.Enabled = True
            End If
            GetImg()
        End If
    End Sub
    Public Sub LoadData()

        GetFillComboBox(ComboBoxName:=CobUser, SqlCom:="SELECT [user_id],[user_name],[Active] FROM [user] where Active='True'", DisMem:="user_name", ValMem:="user_name")
        Dim dt1 As DataTable = GetRecordSet("SELECT [chkLimitStock] FROM [user] WHERE [user_name] = N'" & UserName & "'")
        If dt1.Rows.Count > 0 Then
            Select Case dt1.Rows(0)(0)
                Case True
                    GetDataBayUser = GetRecordSet("SELECT * FROM DIMON_detels WHERE(Item_Actv = 1) AND (qult = N'" & UserName & "')")
                    If GetDataBayUser.Rows.Count > 0 Then
                        For i As Integer = 0 To GetDataBayUser.Rows.Count - 1
                            With (grid)
                                .Rows.Add()
                                .Rows(i).Cells("colBarCodeString").Value = (GetDataBayUser.Rows(i)("test_119").ToString)
                                .Rows(i).Cells("colItemName").Value = (GetDataBayUser.Rows(i)("DIMO_dep").ToString)
                                .Rows(i).Cells("colItemNo").Value = (GetDataBayUser.Rows(i)("sarual").ToString)
                                .Rows(i).Cells("colKarat").Value = (GetDataBayUser.Rows(i)("val_gold").ToString)
                                .Rows(i).Cells("colGWeight").Value = (GetDataBayUser.Rows(i)("GOLD_mezan").ToString)
                                .Rows(i).Cells("colDCut").Value = (GetDataBayUser.Rows(i)("test_11").ToString)
                                .Rows(i).Cells("colCalrity").Value = (GetDataBayUser.Rows(i)("DIM_na9awa").ToString)
                                .Rows(i).Cells("colDWeight").Value = (GetDataBayUser.Rows(i)("DIMO_mezan").ToString)
                                .Rows(i).Cells("colColor").Value = (GetDataBayUser.Rows(i)("ext_coler").ToString)
                                .Rows(i).Cells("colTotalWeight").Value = (GetDataBayUser.Rows(i)("test_116").ToString)
                                .Rows(i).Cells("colCost").Value = (GetDataBayUser.Rows(i)("test_12").ToString)
                                .Rows(i).Cells("colQty").Value = (GetDataBayUser.Rows(i)("test_117").ToString)
                                .Rows(i).Cells("colPrice").Value = (GetDataBayUser.Rows(i)("test_1").ToString)
                                .Rows(i).Cells("colCostToSeller").Value = (GetDataBayUser.Rows(i)("CostToSeller").ToString)
                                .Rows(i).Cells("colSW1").Value = (GetDataBayUser.Rows(i)("test_13").ToString)
                                .Rows(i).Cells("colSN1").Value = (GetDataBayUser.Rows(i)("test_14").ToString)
                                .Rows(i).Cells("colSC1").Value = (GetDataBayUser.Rows(i)("test_15").ToString)
                                .Rows(i).Cells("colSW2").Value = (GetDataBayUser.Rows(i)("test_16").ToString)
                                .Rows(i).Cells("colSN2").Value = (GetDataBayUser.Rows(i)("test_17").ToString)
                                .Rows(i).Cells("colSC2").Value = (GetDataBayUser.Rows(i)("test_18").ToString)
                                .Rows(i).Cells("colSW3").Value = (GetDataBayUser.Rows(i)("test_19").ToString)
                                .Rows(i).Cells("colSN3").Value = (GetDataBayUser.Rows(i)("test_110").ToString)
                                .Rows(i).Cells("colSC3").Value = (GetDataBayUser.Rows(i)("test_111").ToString)
                                .Rows(i).Cells("colSWType1").Value = (GetDataBayUser.Rows(i)("test_112").ToString)
                                .Rows(i).Cells("colSWType2").Value = (GetDataBayUser.Rows(i)("test_113").ToString)
                                .Rows(i).Cells("colSWType3").Value = (GetDataBayUser.Rows(i)("test_114").ToString)
                                .Rows(i).Cells("colCut1").Value = (GetDataBayUser.Rows(i)("Cut1").ToString)
                                .Rows(i).Cells("colCut2").Value = (GetDataBayUser.Rows(i)("Cut2").ToString)
                                .Rows(i).Cells("colCut3").Value = (GetDataBayUser.Rows(i)("Cut3").ToString)
                                .Rows(i).Cells("colClarity1").Value = (GetDataBayUser.Rows(i)("Clarity1").ToString)
                                .Rows(i).Cells("colClarity2").Value = (GetDataBayUser.Rows(i)("Clarity2").ToString)
                                .Rows(i).Cells("colClarity3").Value = (GetDataBayUser.Rows(i)("Clarity3").ToString)
                                .Rows(i).Cells("ColCertificateNo").Value = (GetDataBayUser.Rows(i)("test_115"))
                                .Rows(i).Cells("colTaxExempt").Value = (GetDataBayUser.Rows(i)("TaxExempt"))
                                .Rows(i).Cells("colUser").Value = (GetDataBayUser.Rows(i)("qult"))
                                .Rows(i).Cells("colID").Value = (GetDataBayUser.Rows(i)("DIMOND_ID"))
                                .Rows(i).Cells("colSupplier").Value = (GetDataBayUser.Rows(i)("Supplier"))
                                .Rows(i).Cells("colItemNote").Value = (GetDataBayUser.Rows(i)("ItemNote"))
                                .Rows(i).Cells("colMetalType").Value = (GetDataBayUser.Rows(i)("MetalType"))
                            End With
                        Next
                    End If
                Case False
                    GetAllData = GetRecordSet("SELECT * FROM [DIMON_detels] where Item_Actv=1")
                    If GetAllData.Rows.Count > 0 Then
                        For i As Integer = 0 To GetAllData.Rows.Count - 1
                            With (grid)
                                .Rows.Add()
                                .Rows(i).Cells("colBarCodeString").Value = (GetAllData.Rows(i)("test_119").ToString)
                                .Rows(i).Cells("colItemName").Value = (GetAllData.Rows(i)("DIMO_dep").ToString)
                                .Rows(i).Cells("colItemNo").Value = (GetAllData.Rows(i)("sarual").ToString)
                                .Rows(i).Cells("colKarat").Value = (GetAllData.Rows(i)("val_gold").ToString)
                                .Rows(i).Cells("colGWeight").Value = (GetAllData.Rows(i)("GOLD_mezan").ToString)
                                .Rows(i).Cells("colDCut").Value = (GetAllData.Rows(i)("test_11").ToString)
                                .Rows(i).Cells("colCalrity").Value = (GetAllData.Rows(i)("DIM_na9awa").ToString)
                                .Rows(i).Cells("colDWeight").Value = (GetAllData.Rows(i)("DIMO_mezan").ToString)
                                .Rows(i).Cells("colColor").Value = (GetAllData.Rows(i)("ext_coler").ToString)
                                .Rows(i).Cells("colTotalWeight").Value = (GetAllData.Rows(i)("test_116").ToString)
                                .Rows(i).Cells("colCost").Value = (GetAllData.Rows(i)("test_12").ToString)
                                .Rows(i).Cells("colQty").Value = (GetAllData.Rows(i)("test_117").ToString)
                                .Rows(i).Cells("colPrice").Value = (GetAllData.Rows(i)("test_1").ToString)
                                .Rows(i).Cells("colCostToSeller").Value = (GetAllData.Rows(i)("CostToSeller").ToString)
                                .Rows(i).Cells("colSW1").Value = (GetAllData.Rows(i)("test_13").ToString)
                                .Rows(i).Cells("colSN1").Value = (GetAllData.Rows(i)("test_14").ToString)
                                .Rows(i).Cells("colSC1").Value = (GetAllData.Rows(i)("test_15").ToString)
                                .Rows(i).Cells("colSW2").Value = (GetAllData.Rows(i)("test_16").ToString)
                                .Rows(i).Cells("colSN2").Value = (GetAllData.Rows(i)("test_17").ToString)
                                .Rows(i).Cells("colSC2").Value = (GetAllData.Rows(i)("test_18").ToString)
                                .Rows(i).Cells("colSW3").Value = (GetAllData.Rows(i)("test_19").ToString)
                                .Rows(i).Cells("colSN3").Value = (GetAllData.Rows(i)("test_110").ToString)
                                .Rows(i).Cells("colSC3").Value = (GetAllData.Rows(i)("test_111").ToString)
                                .Rows(i).Cells("colSWType1").Value = (GetAllData.Rows(i)("test_112").ToString)
                                .Rows(i).Cells("colSWType2").Value = (GetAllData.Rows(i)("test_113").ToString)
                                .Rows(i).Cells("colSWType3").Value = (GetAllData.Rows(i)("test_114").ToString)
                                .Rows(i).Cells("colCut1").Value = (GetAllData.Rows(i)("Cut1").ToString)
                                .Rows(i).Cells("colCut2").Value = (GetAllData.Rows(i)("Cut2").ToString)
                                .Rows(i).Cells("colCut3").Value = (GetAllData.Rows(i)("Cut3").ToString)
                                .Rows(i).Cells("colClarity1").Value = (GetAllData.Rows(i)("Clarity1").ToString)
                                .Rows(i).Cells("colClarity2").Value = (GetAllData.Rows(i)("Clarity2").ToString)
                                .Rows(i).Cells("colClarity3").Value = (GetAllData.Rows(i)("Clarity3").ToString)
                                .Rows(i).Cells("ColCertificateNo").Value = (GetAllData.Rows(i)("test_115"))
                                .Rows(i).Cells("colTaxExempt").Value = (GetAllData.Rows(i)("TaxExempt"))
                                .Rows(i).Cells("colUser").Value = (GetAllData.Rows(i)("qult"))
                                .Rows(i).Cells("colID").Value = (GetAllData.Rows(i)("DIMOND_ID"))
                                .Rows(i).Cells("colSupplier").Value = (GetAllData.Rows(i)("Supplier"))
                                .Rows(i).Cells("colItemNote").Value = (GetAllData.Rows(i)("ItemNote"))
                                .Rows(i).Cells("colMetalType").Value = (GetAllData.Rows(i)("MetalType"))
                                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                            End With
                        Next
                    End If
            End Select
        End If
        GetDiamondCuts()
        GetStoneName()
        GetKarat()
        GetStoneColor()
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            grid.CurrentCell = grid(0, grid.Rows.Count - 1)
        Else
        End If
        GetFillComboBox(ComboBoxName:=txtItemName, SqlCom:="SELECT DIMO_dep FROM DIMON_detels", DisMem:="DIMO_dep", ValMem:="DIMO_dep")
        Dim GetItemStatus As DataTable = GetRecordSet("SELECT dimo_id, Item_Actv FROM dimon_invce GROUP BY dimo_id, Item_Actv HAVING (Item_Actv = 1)")
        If GetItemStatus.Rows.Count > 0 Then
            For i As Integer = 0 To GetItemStatus.Rows.Count - 1
                For GredItem = 0 To grid.Rows.Count - 1
                    If grid.Rows(GredItem).Cells("colBarCodeString").Value = GetItemStatus.Rows(i)("dimo_id").ToString Then
                        grid.Rows(GredItem).DefaultCellStyle.BackColor = Color.OrangeRed
                        grid.Rows(GredItem).DefaultCellStyle.ForeColor = Color.Black
                        grid.Rows(GredItem).Cells("colItemStatus").Value = 1
                    End If
                Next
            Next
        End If
        '
    End Sub
    Private Sub GetDiamondCuts()
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
    Private Sub GetStoneName()
        Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME], [IsDiamond] FROM [EXTR_NAME] where Activ=1")
        If dt1.Rows.Count > 0 Then
            With cmbStoneName1
                .DataSource = dt1
                .DisplayMember = "EXTR_NAME"
                .ValueMember = "IsDiamond"
            End With
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [EXTR_NAME], [IsDiamond] FROM [EXTR_NAME]where Activ=1")
        If dt2.Rows.Count > 0 Then
            With cmbStoneName2
                .DataSource = dt2
                .DisplayMember = "EXTR_NAME"
                .ValueMember = "IsDiamond"
            End With
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [EXTR_NAME], [IsDiamond] FROM [EXTR_NAME]where Activ=1")
        If dt3.Rows.Count > 0 Then
            With cmbStoneName3
                .DataSource = dt3
                .DisplayMember = "EXTR_NAME"
                .ValueMember = "IsDiamond"
            End With
        End If
    End Sub
    Private Sub GetKarat()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Gram_valu] FROM [Gram_val] WHERE Gram_valu NOT LIKE 0 OR Gram_valu NOT LIKE NULL ORDER BY [Gram_valu] ASC")
        If dt1.Rows.Count > 0 Then
            cmbKarat.DataSource = dt1
            cmbKarat.DisplayMember = "Gram_valu"
            cmbKarat.ValueMember = "Gram_valu"
        End If
    End Sub
    Private Sub GetStoneColor()
        Dim dt1 As DataTable = GetRecordSet("SELECT [StoneColor] FROM [StoneColor] ")
        If dt1.Rows.Count > 0 Then
            cmbStoneColor1.DataSource = dt1
            cmbStoneColor1.DisplayMember = "StoneColor"
            cmbStoneColor1.ValueMember = "StoneColor"
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [StoneColor] FROM [StoneColor] ")
        If dt2.Rows.Count > 0 Then
            cmbStoneColor2.DataSource = dt2
            cmbStoneColor2.DisplayMember = "StoneColor"
            cmbStoneColor2.ValueMember = "StoneColor"
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [StoneColor] FROM [StoneColor] ")
        If dt3.Rows.Count > 0 Then
            cmbStoneColor3.DataSource = dt3
            cmbStoneColor3.DisplayMember = "StoneColor"
            cmbStoneColor3.ValueMember = "StoneColor"
        End If
    End Sub
    Private Sub Supplier()
        GetFillComboBox(ComboBoxName:=cobSupplier, SqlCom:="SELECT [BranchName]  FROM [TPCompanyBranches]", DisMem:="BranchName", ValMem:="BranchName")
    End Sub
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Try
            btnNew.Enabled = False
            btnSave.Enabled = True
            gbItemData.Enabled = True
            btnSave.Enabled = True
            btnNew.Enabled = False
            btnFirstItem.Enabled = False
            btnLastItem.Enabled = False
            btnNextItem.Enabled = False
            btnPreviousItem.Enabled = False
            btnEdit.Enabled = False
            gbItemData.Enabled = True
            cmbKarat.SelectedIndex = 0
            IsDiamond1CheckBox.Checked = True
            IsDiamond1CheckBox.Checked = False
            IsDiamond2CheckBox.Checked = True
            IsDiamond2CheckBox.Checked = False
            IsDiamond3CheckBox.Checked = True
            IsDiamond3CheckBox.Checked = False
            TaxExemptCheckBox.Checked = False
            TaxExemptCheckBox.Checked = True
            txtItemName.SelectAll()
            txtItemName.Focus()
            AddNew()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub SaveNewData()
        If cmbCut.Text.Trim = "" Then
            MsgBox("حدد نوع القص" & vbCrLf & "Select Cut Type", , AppTitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("اكتب اسم الصنف أولا " & vbCrLf & "Add Item Name First", , AppTitle)
            txtItemName.SelectAll()
            txtItemName.Focus()
            Exit Sub
        End If

        If txtItemClarity.Text.Trim = "" Then
            MsgBox("اكتب النقاوة أولا " & vbCrLf & "Add Item Clarity First", , AppTitle)
            txtItemClarity.SelectAll()
            txtItemClarity.Focus()
            Exit Sub
        End If

        If txtItemColor.Text.Trim = "" Then
            MsgBox("اكتب اللون أولا " & vbCrLf & "Add Diamond Color First", , AppTitle)
            txtItemColor.SelectAll()
            txtItemColor.Focus()
            Exit Sub
        End If

        If txtItemCost.Text.Trim = "" Then
            MsgBox("اكتب التكلفة أولا " & vbCrLf & "Add Item Cost First", , AppTitle)
            txtItemCost.SelectAll()
            txtItemCost.Focus()
            Exit Sub
        End If

        If txtItemDCarat.Text.Trim = "" Then
            MsgBox("اكتب القيراط أولا " & vbCrLf & "Add Diamond Carat First", , AppTitle)
            txtItemDCarat.SelectAll()
            txtItemDCarat.Focus()
            Exit Sub
        End If

        If cmbKarat.Text.Trim = "" Then
            MsgBox("اكتب عيار الذهب أولا " & vbCrLf & "Add Gold Carat First", , AppTitle)
            cmbKarat.SelectAll()
            cmbKarat.Focus()
            Exit Sub
        End If

        If txtItemGWeight.Text.Trim = "" Then
            MsgBox("اكتب وزن الذهب أولا " & vbCrLf & "Add Gold Weight First", , AppTitle)
            txtItemGWeight.SelectAll()
            txtItemGWeight.Focus()
            Exit Sub
        End If
        If txtItemPrice.Text.Trim = "" OrElse IsNumeric(txtItemPrice.Text) = False Then
            MsgBox("اكتب إجمالي السعر أولا " & vbCrLf & "Add Item Price First", , AppTitle)
            txtItemPrice.SelectAll()
            txtItemPrice.Focus()
            Exit Sub
        End If
        If txtStoneWeight1.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight1.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight1.SelectAll()
            txtStoneWeight1.Focus()
            Exit Sub
        End If
        If txtStoneWeight2.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight2.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight2.SelectAll()
            txtStoneWeight2.Focus()
            Exit Sub
        End If
        If txtStoneWeight3.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight3.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight3.SelectAll()
            txtStoneWeight3.Focus()
            Exit Sub
        End If
        If txtTotalWeight.Text.Trim <> "" AndAlso IsNumeric(txtTotalWeight.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtTotalWeight.SelectAll()
            txtTotalWeight.Focus()
            Exit Sub
        End If
        If txtStoneWeight1.Text.Trim <> "" AndAlso cmbStoneWeightType1.SelectedIndex = -1 Then
            cmbStoneWeightType1.SelectedIndex = 0
        End If
        If txtStoneWeight2.Text.Trim <> "" AndAlso cmbStoneWeightType2.SelectedIndex = -1 Then
            cmbStoneWeightType2.SelectedIndex = 0
        End If
        If txtStoneWeight3.Text.Trim <> "" AndAlso cmbStoneWeightType3.SelectedIndex = -1 Then
            cmbStoneWeightType3.SelectedIndex = 0
        End If
        IsDiamond1CheckBox.Checked = If(cmbStoneName1.SelectedIndex = -1, False, cmbStoneName1.SelectedValue)
        IsDiamond2CheckBox.Checked = If(cmbStoneName2.SelectedIndex = -1, False, cmbStoneName2.SelectedValue)
        IsDiamond3CheckBox.Checked = If(cmbStoneName3.SelectedIndex = -1, False, cmbStoneName3.SelectedValue)
        If txtStoneWeight1.Text.Trim = "" Then txtStoneWeight1.Text = "0"
        If txtStoneWeight2.Text.Trim = "" Then txtStoneWeight2.Text = "0"
        If txtStoneWeight3.Text.Trim = "" Then txtStoneWeight3.Text = "0"
        If txtTotalWeight.Text.Trim = "" Then
            txtTotalWeight.Text = "0"
        End If
        If txtQty.Text.Trim = "" Then
            txtQty.Text = "1"
        End If
        Dim Barcood As String
        '''''''' بحث عن الباركود المدخل

        Dim dt1 As DataTable = GetRecordSet("SELECT [test_119] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text & "'")
        If dt1.Rows.Count > 0 Then
            MsgBox("الباركود المدخل مكرر!... أدخل باركود جديد أو اتركه خاليا ليتم إدخال باركود آلي" & vbCrLf & "BarCode is Duplicated!.. Enter a New BarCode Or Leave It Empty to Make It Automatic", , AppTitle)
            txtBarCode.SelectAll()
            txtBarCode.Focus()
            Exit Sub
        End If
        'Try
        ''''''''''باركود فريد
        Dim GetNewBarcood As DataTable = GetRecordSet("SELECT DIMOND_ID +1 AS DIMOND_ID FROM DIMON_detels WHERE DIMOND_ID=(SELECT max(DIMOND_ID) FROM DIMON_detels)")
        If GetNewBarcood.Rows.Count > 0 Then
            Barcood = Val(GetNewBarcood.Rows(0)(0).ToString)
        Else
            Barcood = "100"
        End If
        GlCommand.CommandText = "INSERT INTO [DIMON_detels]" &
                                "([DIMO_dep]" &
                                ",[DIM_na9awa]" &
                                ",[DIMO_mezan]" &
                                ",[ext_coler]" &
                                ",[qult]" &
                                ",[sarual]" &
                                ",[val_gold]" &
                                ",[GOLD_mezan]" &
                                ",[test_1]" &
                                ",[test_11]" &
                                ",[test_12]" &
                                ",[test_13]" &
                                ",[test_14]" &
                                ",[test_15]" &
                                ",[test_16]" &
                                ",[test_17]" &
                                ",[test_18]" &
                                ",[test_19]" &
                                ",[test_110]" &
                                ",[test_111]" &
                                ",[test_112]" &
                                ",[test_113]" &
                                ",[test_114]" &
                                ",[test_115]" &
                                ",[test_116]" &
                                ",[test_117]" &
                                ",[test_118]" &
                                ",[test_119]" &
                                ",[date_creted]" &
                                ",[ITEM_IMGE]" &
                                ",[Item_Actv]" &
                                ",[CostToSeller]" &
                                ",[TaxExempt]" &
                                ",[Documents]" &
                                ",[Cut1]" &
                                ",[Clarity1]" &
                                ",[Cut2]" &
                                ",[Clarity2]" &
                                ",[Cut3]" &
                                ",[Clarity3]" &
                                ",[IsDiamond1]" &
                                ",[IsDiamond2]" &
                                ",[IsDiamond3]" &
                                ",[CreationDate]" &
                                ",[Supplier]" &
                                ",[ItemNote]" &
                                ",[MetalType])" &
                                  "VALUES " &
        "(@DIMO_dep" &
        ",@DIM_na9awa  " &
        ",@DIMO_mezan  " &
        ",@ext_coler  " &
        ",@qult  " &
        ",@sarual  " &
        ",@val_gold  " &
        ",@GOLD_mezan " &
        ",@test_1  " &
        ",@test_11  " &
        ",@test_12  " &
        ",@test_13  " &
        ",@test_14  " &
        ",@test_15  " &
        ",@test_16  " &
        ",@test_17  " &
        ",@test_18  " &
        ",@test_19  " &
        ",@test_110  " &
        ",@test_111  " &
        ",@test_112  " &
        ",@test_113  " &
        ",@test_114  " &
        ",@test_115  " &
        ",@test_116  " &
        ",@test_117  " &
        ",@test_118  " &
        ",@test_119  " &
        ",@date_creted  " &
        ",@ITEM_IMGE  " &
        ",@Item_Actv  " &
        ",@CostToSeller  " &
        ",@TaxExempt  " &
        ",@Documents  " &
        ",@Cut1  " &
        ",@Clarity1  " &
        ",@Cut2  " &
        ",@Clarity2  " &
        ",@Cut3  " &
        ",@Clarity3  " &
        ",@IsDiamond1  " &
        ",@IsDiamond2  " &
        ",@IsDiamond3  " &
        ",@CreationDate " &
        ",@Supplier " &
        ",@ItemNote " &
        ",@MetalType)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@DIMO_dep", txtItemName.Text.Trim)
            .AddWithValue("@DIM_na9awa", txtItemClarity.Text.Trim)
            .AddWithValue("@DIMO_mezan", txtItemDCarat.Text.Trim)
            .AddWithValue("@ext_coler", txtItemColor.Text.Trim)
            .AddWithValue("@qult", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
            .AddWithValue("@sarual", txtItemNo.Text.Trim)
            .AddWithValue("@val_gold", cmbKarat.Text.Trim)
            .AddWithValue("@GOLD_mezan", txtItemGWeight.Text.Trim)
            .AddWithValue("@test_1", txtItemPrice.Text.Trim)
            .AddWithValue("@test_11", cmbCut.Text.Trim)
            .AddWithValue("@test_12", txtItemCost.Text.Trim)
            .AddWithValue("@test_13", txtStoneWeight1.Text.Trim)
            .AddWithValue("@test_14", cmbStoneName1.Text.Trim)
            .AddWithValue("@test_15", cmbStoneColor1.Text.Trim)
            .AddWithValue("@test_16", txtStoneWeight2.Text.Trim)
            .AddWithValue("@test_17", cmbStoneName2.Text.Trim)
            .AddWithValue("@test_18", cmbStoneColor2.Text.Trim)
            .AddWithValue("@test_19", txtStoneWeight3.Text.Trim)
            .AddWithValue("@test_110", cmbStoneName3.Text.Trim)
            .AddWithValue("@test_111", cmbStoneColor3.Text.Trim)
            .AddWithValue("@test_112", cmbStoneWeightType1.SelectedIndex)
            .AddWithValue("@test_113", cmbStoneWeightType2.SelectedIndex)
            .AddWithValue("@test_114", cmbStoneWeightType3.SelectedIndex)
            .AddWithValue("@test_115", TxtCertificateNo.Text.Trim)
            .AddWithValue("@test_116", txtTotalWeight.Text.Trim)
            .AddWithValue("@test_117", txtQty.Text.Trim)
            .AddWithValue("@test_118", "")
            .AddWithValue("@test_119", If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text))
            .AddWithValue("@date_creted", DateToSave(DateDiamItem.Value))
            .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
            .AddWithValue("@Item_Actv", "1")
            .AddWithValue("@CostToSeller", If(IsDBNull(CostToSellerTextBox.Text.Trim) Or CostToSellerTextBox.Text.Trim = "", txtItemCost.Text.Trim, CostToSellerTextBox.Text.Trim))
            .AddWithValue("@TaxExempt", TaxExemptCheckBox.Checked)
            .Add("@Documents", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
            .AddWithValue("@Cut1", cmbStoneCut1.Text.Trim)
            .AddWithValue("@Clarity1", txtClarity1.Text.Trim)
            .AddWithValue("@Cut2", cmbStoneCut2.Text.Trim)
            .AddWithValue("@Clarity2", txtClarity2.Text.Trim)
            .AddWithValue("@Cut3", cmbStoneCut3.Text.Trim)
            .AddWithValue("@Clarity3", txtClarity3.Text.Trim)
            .AddWithValue("@IsDiamond1", "1")
            .AddWithValue("@IsDiamond2", "1")
            .AddWithValue("@IsDiamond3", "1")
            .AddWithValue("@CreationDate", Date.UtcNow)
            .AddWithValue("@Supplier", cobSupplier.Text.Trim)
            .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
            .AddWithValue("@MetalType", cmbMetalType.SelectedIndex)
        End With
        GlCommand.ExecuteNonQuery()
        Dim UpdateRows As DataGridViewRow = grid.SelectedRows(0)
        With (UpdateRows)
            .Cells("colBarCodeString").Value = If(IsDBNull(txtBarCode.Text) Or txtBarCode.Text.Trim = "", Barcood, txtBarCode.Text)
            .Cells("colItemName").Value = txtItemName.Text.Trim
            .Cells("colItemNo").Value = txtItemNo.Text.Trim
            .Cells("coluser").Value = If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim)
            .Cells("colKarat").Value = cmbKarat.Text.Trim
            .Cells("colGWeight").Value = txtItemGWeight.Text.Trim
            .Cells("colDCut").Value = cmbCut.Text.Trim
            .Cells("colCalrity").Value = txtItemClarity.Text.Trim
            .Cells("colDWeight").Value = txtItemDCarat.Text.Trim
            .Cells("colColor").Value = txtItemColor.Text.Trim
            .Cells("colTotalWeight").Value = txtTotalWeight.Text.Trim
            .Cells("colCost").Value = txtItemCost.Text.Trim
            .Cells("colQty").Value = txtQty.Text.Trim
            .Cells("colPrice").Value = txtItemPrice.Text.Trim
            .Cells("colCostToSeller").Value = CostToSellerTextBox.Text.Trim
            .Cells("colSW1").Value = txtStoneWeight1.Text.Trim
            .Cells("colSN1").Value = cmbStoneName1.Text.Trim
            .Cells("colSC1").Value = cmbStoneCut1.Text.Trim
            .Cells("colSW2").Value = txtStoneWeight2.Text.Trim
            .Cells("colSN2").Value = cmbStoneName2.Text.Trim
            .Cells("colSC2").Value = cmbStoneColor2.Text.Trim
            .Cells("colSW3").Value = txtStoneWeight3.Text.Trim
            .Cells("colSN3").Value = cmbStoneName3.Text.Trim
            .Cells("colSC3").Value = cmbStoneColor3.Text.Trim
            .Cells("colSWType1").Value = cmbStoneWeightType1.Text.Trim
            .Cells("colSWType2").Value = cmbStoneWeightType2.Text.Trim
            .Cells("colSWType3").Value = cmbStoneWeightType3.Text.Trim
            .Cells("colCut1").Value = cmbStoneCut1.Text.Trim
            .Cells("colCut2").Value = cmbStoneCut2.Text.Trim
            .Cells("colCut3").Value = cmbStoneCut3.Text.Trim
            .Cells("colClarity1").Value = txtClarity1.Text.Trim
            .Cells("colClarity2").Value = txtClarity2.Text.Trim
            .Cells("colClarity3").Value = txtClarity3.Text.Trim
            .Cells("ColCertificateNo").Value = TxtCertificateNo.Text.Trim
            .Cells("colTaxExempt").Value = TaxExemptCheckBox.Checked
            .Cells("colSupplier").Value = cobSupplier.Text.Trim
            .Cells("colItemNote").Value = txtItemNote.Text.Trim
            .Cells("colMetalType").Value = cmbMetalType.SelectedIndex()
        End With
        If (IsDBNull(txtBarCode.Text) Or (txtBarCode.Text.Trim = "")) Then txtBarCode.Text = Barcood
        'End If
        grid.RefreshEdit()
        grid.EndEdit()
        btnSave.Enabled = False
        btnPrintBarCode.Enabled = True
        gbItemData.Enabled = False
        btnNew.Enabled = True
        pbImage.Enabled = True
        btnEdit.Enabled = True
        pbDocumentsImage.Enabled = True
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    Private Sub EditData()
        If cmbCut.Text.Trim = "" Then
            MsgBox("حدد نوع القص" & vbCrLf & "Select Cut Type", , AppTitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If
        If txtItemName.Text.Trim = "" Then
            MsgBox("اكتب اسم الصنف أولا " & vbCrLf & "Add Item Name First", , AppTitle)
            txtItemName.SelectAll()
            txtItemName.Focus()
            Exit Sub
        End If

        If txtItemClarity.Text.Trim = "" Then
            MsgBox("اكتب النقاوة أولا " & vbCrLf & "Add Item Clarity First", , AppTitle)
            txtItemClarity.SelectAll()
            txtItemClarity.Focus()
            Exit Sub
        End If

        If txtItemColor.Text.Trim = "" Then
            MsgBox("اكتب اللون أولا " & vbCrLf & "Add Diamond Color First", , AppTitle)
            txtItemColor.SelectAll()
            txtItemColor.Focus()
            Exit Sub
        End If

        If txtItemCost.Text.Trim = "" Then
            MsgBox("اكتب التكلفة أولا " & vbCrLf & "Add Item Cost First", , AppTitle)
            txtItemCost.SelectAll()
            txtItemCost.Focus()
            Exit Sub
        End If

        If txtItemDCarat.Text.Trim = "" Then
            MsgBox("اكتب القيراط أولا " & vbCrLf & "Add Diamond Carat First", , AppTitle)
            txtItemDCarat.SelectAll()
            txtItemDCarat.Focus()
            Exit Sub
        End If

        If cmbKarat.Text.Trim = "" Then
            MsgBox("اكتب عيار الذهب أولا " & vbCrLf & "Add Gold Carat First", , AppTitle)
            cmbKarat.SelectAll()
            cmbKarat.Focus()
            Exit Sub
        End If

        If txtItemGWeight.Text.Trim = "" Then
            MsgBox("اكتب وزن الذهب أولا " & vbCrLf & "Add Gold Weight First", , AppTitle)
            txtItemGWeight.SelectAll()
            txtItemGWeight.Focus()
            Exit Sub
        End If
        If txtItemPrice.Text.Trim = "" OrElse IsNumeric(txtItemPrice.Text) = False Then
            MsgBox("اكتب إجمالي السعر أولا " & vbCrLf & "Add Item Price First", , AppTitle)
            txtItemPrice.SelectAll()
            txtItemPrice.Focus()
            Exit Sub
        End If
        If txtStoneWeight1.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight1.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight1.SelectAll()
            txtStoneWeight1.Focus()
            Exit Sub
        End If

        If txtStoneWeight2.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight2.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight2.SelectAll()
            txtStoneWeight2.Focus()
            Exit Sub
        End If

        If txtStoneWeight3.Text.Trim <> "" AndAlso IsNumeric(txtStoneWeight3.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtStoneWeight3.SelectAll()
            txtStoneWeight3.Focus()
            Exit Sub
        End If
        If txtTotalWeight.Text.Trim <> "" AndAlso IsNumeric(txtTotalWeight.Text.Trim) = False Then
            MsgBox("اكتب أرقاما للوزن فقط" & vbCrLf & "Add Stone Weight in Numbers ONLY", , AppTitle)
            txtTotalWeight.SelectAll()
            txtTotalWeight.Focus()
            Exit Sub
        End If
        If txtStoneWeight1.Text.Trim <> "" AndAlso cmbStoneWeightType1.SelectedIndex = -1 Then
            cmbStoneWeightType1.SelectedIndex = 0
        End If
        If txtStoneWeight2.Text.Trim <> "" AndAlso cmbStoneWeightType2.SelectedIndex = -1 Then
            cmbStoneWeightType2.SelectedIndex = 0
        End If
        If txtStoneWeight3.Text.Trim <> "" AndAlso cmbStoneWeightType3.SelectedIndex = -1 Then
            cmbStoneWeightType3.SelectedIndex = 0
        End If
        If CostToSellerTextBox.Text = "" Then CostToSellerTextBox.Text = "0"
        IsDiamond1CheckBox.Checked = If(cmbStoneName1.SelectedIndex = -1, False, cmbStoneName1.SelectedValue)
        IsDiamond2CheckBox.Checked = If(cmbStoneName2.SelectedIndex = -1, False, cmbStoneName2.SelectedValue)
        IsDiamond3CheckBox.Checked = If(cmbStoneName3.SelectedIndex = -1, False, cmbStoneName3.SelectedValue)
        If txtStoneWeight1.Text.Trim = "" Then txtStoneWeight1.Text = "0"
        If txtStoneWeight2.Text.Trim = "" Then txtStoneWeight2.Text = "0"
        If txtStoneWeight3.Text.Trim = "" Then txtStoneWeight3.Text = "0"
        If txtTotalWeight.Text.Trim = "" Then
            txtTotalWeight.Text = "0"
        End If
        If txtQty.Text.Trim = "" Then
            txtQty.Text = "1"
        End If
        txtItemGKarat.Text = cmbKarat.Text
        Item_ActvTextBox.Text = "1"
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim UpdateRows As DataGridViewRow = grid.SelectedRows(0)
            UpdateRows.Cells("colBarCodeString").Value = txtBarCode.Text.Trim
            UpdateRows.Cells("colItemName").Value = txtItemName.Text.Trim
            UpdateRows.Cells("colItemNo").Value = txtItemNo.Text.Trim
            UpdateRows.Cells("colKarat").Value = cmbKarat.Text.Trim
            UpdateRows.Cells("colGWeight").Value = txtItemGWeight.Text.Trim
            UpdateRows.Cells("colDCut").Value = cmbCut.Text.Trim
            UpdateRows.Cells("colDWeight").Value = txtItemDCarat.Text.Trim
            UpdateRows.Cells("colCalrity").Value = txtItemClarity.Text.Trim
            UpdateRows.Cells("colColor").Value = txtItemColor.Text.Trim
            UpdateRows.Cells("colCost").Value = txtItemCost.Text.Trim
            UpdateRows.Cells("colPrice").Value = Val(txtItemPrice.Text.Trim)
            UpdateRows.Cells("colSW1").Value = txtStoneWeight1.Text.Trim
            UpdateRows.Cells("colSN1").Value = cmbStoneName1.Text.Trim
            UpdateRows.Cells("colSC1").Value = cmbStoneColor1.Text.Trim
            UpdateRows.Cells("colSW2").Value = txtStoneWeight2.Text.Trim
            UpdateRows.Cells("colSN2").Value = cmbStoneName2.Text.Trim
            UpdateRows.Cells("colSC2").Value = cmbStoneColor2.Text.Trim
            UpdateRows.Cells("colSW3").Value = txtStoneWeight3.Text.Trim
            UpdateRows.Cells("colSN3").Value = cmbStoneName3.Text.Trim
            UpdateRows.Cells("colSC3").Value = cmbStoneColor3.Text.Trim
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            UpdateRows.Cells("colSWType1").Value = cmbStoneWeightType1.Text.Trim
            UpdateRows.Cells("colSWType2").Value = cmbStoneWeightType2.Text.Trim
            UpdateRows.Cells("colSWType3").Value = cmbStoneWeightType3.Text.Trim
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            UpdateRows.Cells("colTotalWeight").Value = txtTotalWeight.Text.Trim
            UpdateRows.Cells("colQty").Value = txtQty.Text.Trim
            UpdateRows.Cells("colpbImage").Value = pbImage.Image
            UpdateRows.Cells("colCostToSeller").Value = CostToSellerTextBox.Text.Trim
            UpdateRows.Cells("colTaxExempt").Value = TaxExemptCheckBox.Checked
            UpdateRows.Cells("colpbDocumentsImage").Value = pbDocumentsImage.Image
            UpdateRows.Cells("colCut1").Value = cmbStoneCut1.Text.Trim
            UpdateRows.Cells("colClarity1").Value = txtClarity1.Text.Trim
            UpdateRows.Cells("colCut2").Value = cmbStoneCut2.Text.Trim
            UpdateRows.Cells("colClarity2").Value = txtClarity2.Text.Trim
            UpdateRows.Cells("colCut3").Value = cmbStoneCut3.Text.Trim
            UpdateRows.Cells("colClarity3").Value = txtClarity3.Text.Trim
            UpdateRows.Cells("colSupplier").Value = cobSupplier.Text
            UpdateRows.Cells("colItemNote").Value = txtItemNote.Text.Trim
            UpdateRows.Cells("colMetalType").Value = cmbMetalType.SelectedIndex
            GlCommand.CommandText = "UPDATE [DIMON_detels] Set" & vbCrLf &
                                   "[DIMO_dep]=@DIMO_dep" & vbCrLf &
                                   ",[DIM_na9awa]=@DIM_na9awa " & vbCrLf &
                                   ",[DIMO_mezan]=@DIMO_mezan" & vbCrLf &
                                   ",[ext_coler]=@ext_coler" & vbCrLf &
                                   ",[qult]=@qult" & vbCrLf &
                                   ",[sarual]=@sarual" & vbCrLf &
                                   ",[val_gold]=@val_gold" & vbCrLf &
                                   ",[GOLD_mezan]=@GOLD_mezan" & vbCrLf &
                                   ",[test_1]=@test_1" & vbCrLf &
                                   ",[test_11]=@test_11" & vbCrLf &
                                   ",[test_12]=@test_12" & vbCrLf &
                                   ",[test_13]=@test_13" & vbCrLf &
                                   ",[test_14]=@test_14" & vbCrLf &
                                   ",[test_15]=@test_15" & vbCrLf &
                                   ",[test_16]=@test_16" & vbCrLf &
                                   ",[test_17]=@test_17" & vbCrLf &
                                   ",[test_18]=@test_18" & vbCrLf &
                                   ",[test_19]=@test_19" & vbCrLf &
                                   ",[test_110]=@test_110" & vbCrLf &
                                   ",[test_111]=@test_111" & vbCrLf &
                                   ",[test_112]=@test_112" & vbCrLf &
                                   ",[test_113]=@test_113" & vbCrLf &
                                   ",[test_114]=@test_114" & vbCrLf &
                                   ",[test_115]=@test_115" & vbCrLf &
                                   ",[test_116]=@test_116" & vbCrLf &
                                   ",[test_117]=@test_117" & vbCrLf &
                                   ",[test_118]=@test_118" & vbCrLf &
                                   ",[ITEM_IMGE]=@ITEM_IMGE" & vbCrLf &
                                   ",[Item_Actv]=@Item_Actv" & vbCrLf &
                                   ",[CostToSeller]=@CostToSeller" & vbCrLf &
                                   ",[TaxExempt]=@TaxExempt" & vbCrLf &
                                   ",[Documents]=@Documents" & vbCrLf &
                                   ",[Cut1]=@Cut1" & vbCrLf &
                                   ",[Clarity1]=@Clarity1" & vbCrLf &
                                   ",[Cut2]=@Cut2" & vbCrLf &
                                   ",[Clarity2]=@Clarity2" & vbCrLf &
                                   ",[Cut3]=@Cut3" & vbCrLf &
                                   ",[Clarity3]=@Clarity3" & vbCrLf &
                                   ",[IsDiamond1]=@IsDiamond1" & vbCrLf &
                                   ",[IsDiamond2]=@IsDiamond2" & vbCrLf &
                                   ",[IsDiamond3]=@IsDiamond3" & vbCrLf &
                                   ",[LastEditDate]=@LastEditDate" & vbCrLf &
                                   ",[Supplier]=@Supplier" & vbCrLf &
                                   ",[ItemNote]=@ItemNote" & vbCrLf &
                                   ",[MetalType]=@MetalType" & vbCrLf &
                                    "WHERE[DIMOND_ID]= '" & grid.SelectedRows(0).Cells("colID").Value & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@DIMO_dep", txtItemName.Text.Trim)
                .AddWithValue("@DIM_na9awa", txtItemClarity.Text.Trim)
                .AddWithValue("@DIMO_mezan", txtItemDCarat.Text.Trim)
                .AddWithValue("@ext_coler", txtItemColor.Text.Trim)
                .AddWithValue("@qult", If(IsDBNull(CobUser.Text) Or CobUser.Text.Trim = "", UserName, CobUser.Text.Trim))
                .AddWithValue("@sarual", txtItemNo.Text.Trim)
                .AddWithValue("@val_gold", cmbKarat.Text.Trim)
                .AddWithValue("@GOLD_mezan", txtItemGWeight.Text.Trim)
                .AddWithValue("@test_1", Val(txtItemPrice.Text.Trim))
                .AddWithValue("@test_11", cmbCut.Text.Trim)
                .AddWithValue("@test_12", txtItemCost.Text.Trim)
                .AddWithValue("@test_13", txtStoneWeight1.Text.Trim)
                .AddWithValue("@test_14", cmbStoneName1.Text.Trim)
                .AddWithValue("@test_15", cmbStoneColor1.Text.Trim)
                .AddWithValue("@test_16", txtStoneWeight2.Text.Trim)
                .AddWithValue("@test_17", cmbStoneName2.Text.Trim)
                .AddWithValue("@test_18", cmbStoneColor2.Text.Trim)
                .AddWithValue("@test_19", txtStoneWeight3.Text.Trim)
                .AddWithValue("@test_110", cmbStoneName3.Text.Trim)
                .AddWithValue("@test_111", cmbStoneColor3.Text.Trim)
                .AddWithValue("@test_112", cmbStoneWeightType1.SelectedIndex)
                .AddWithValue("@test_113", cmbStoneWeightType2.SelectedIndex)
                .AddWithValue("@test_114", cmbStoneWeightType3.SelectedIndex)
                .AddWithValue("@test_115", TxtCertificateNo.Text.Trim)
                .AddWithValue("@test_116", txtTotalWeight.Text.Trim)
                .AddWithValue("@test_117", txtQty.Text.Trim)
                .AddWithValue("@test_118", "")
                .Add("@ITEM_IMGE", SqlDbType.Image).Value = If(pbImage.Image Is Nothing, DBNull.Value, ImageToByte(pbImage.Image))
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@CostToSeller", CostToSellerTextBox.Text.Trim)
                .AddWithValue("@TaxExempt", TaxExemptCheckBox.Checked)
                .Add("@Documents", SqlDbType.Image).Value = If(pbDocumentsImage.Image Is Nothing, DBNull.Value, ImageToByte(pbDocumentsImage.Image))
                .AddWithValue("@Cut1", cmbStoneCut1.Text.Trim)
                .AddWithValue("@Clarity1", txtClarity1.Text.Trim)
                .AddWithValue("@Cut2", cmbStoneCut2.Text.Trim)
                .AddWithValue("@Clarity2", txtClarity2.Text.Trim)
                .AddWithValue("@Cut3", cmbStoneCut3.Text.Trim)
                .AddWithValue("@Clarity3", txtClarity3.Text.Trim)
                .AddWithValue("@IsDiamond1", cmbStoneWeightType1.SelectedIndex)
                .AddWithValue("@IsDiamond2", cmbStoneWeightType2.SelectedIndex)
                .AddWithValue("@IsDiamond3", cmbStoneWeightType3.SelectedIndex)
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@Supplier", cobSupplier.Text)
                .AddWithValue("@ItemNote", txtItemNote.Text.Trim)
                .AddWithValue("@MetalType", cmbMetalType.SelectedIndex)
            End With
            GlCommand.ExecuteNonQuery()
            MsgBox("تم الحفظ التعديل بنجاح" & vbCrLf & "Save Edit successfully", , AppTitle)
            grid.RefreshEdit()
            grid.EndEdit()
            NewData()
            EditControl = False
        Catch ex As Exception
            MsgBox(ex.Message, , AppTitle)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If EditControl = False Then
            SaveNewData()
        ElseIf EditControl = True Then
            EditData()
        End If
        btnEdit.Enabled = True
    End Sub

    Private Sub btnFirstItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirstItem.Click
        grid.Rows(0).Selected = True
    End Sub

    Private Sub btnLastItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLastItem.Click
        grid.CurrentCell = grid(0, grid.Rows.Count - 1)
    End Sub

    Private Sub btnNextItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNextItem.Click

    End Sub

    Private Sub btnPreviousItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreviousItem.Click

    End Sub

    Private Sub btnPrintBarCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrintBarCode.Click

        If grid.RowCount = 0 Then
            MsgBox("أضف أصناف أولا" & vbCrLf & "Add Items First", , AppTitle)
            Exit Sub
        End If
        DiamondBarCode.DIMON_BARICOOD_RIGHTTableAdapter.Fill(DiamondBarCode.DT_restrantDataSet.DIMON_BARICOOD_RIGHT)
        DiamondBarCode.DIMON_BARICOOD_LEFTTableAdapter.Fill(DiamondBarCode.DT_restrantDataSet.DIMON_BARICOOD_LEFT)
        language_start(Name)
        NewForm = False
        DiamondBarCode.Show()
        DiamondBarCode.txtBarCodeLeft.Text = grid.CurrentRow.Cells("colBarCodeString").Value
        If grid.CurrentRow.Index >= 1 Then
            DiamondBarCode.txtBarCodeRight.Text = grid.Rows(grid.CurrentRow.Index - 1).Cells("colBarCodeString").Value
        Else
            DiamondBarCode.txtBarCodeRight.Text = grid.CurrentRow.Cells("colBarCodeString").Value
        End If
        DiamondBarCode.PrintBarCodeDiamond()
        DiamondBarCode.Dispose()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows(0).Cells("colItemStatus").Value = 1 Then
            MsgBox("لا يمكن تعديل صنف سبق بيعه" & vbCrLf & "Can't Edit an Already Sold Item", , AppTitle)
            Exit Sub
        End If
        gbItemData.Enabled = True
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnEdit.Enabled = False
        EditControl = True
    End Sub

    Private Sub gridDIMON_detels_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles grid.DataError
        'Try
        '    DIMON_detelsBindingSource.RemoveCurrent()
        '    NewData()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub
    Sub NewData()
        gbItemData.Enabled = False
        btnSave.Enabled = False
        btnNew.Enabled = True
        btnFirstItem.Enabled = True
        btnLastItem.Enabled = True
        btnNextItem.Enabled = True
        btnPreviousItem.Enabled = True
        btnEdit.Enabled = True
    End Sub

    Private Sub gridDIMON_detels_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grid.SelectionChanged
        GridSelectionChanged()
    End Sub

    Private Sub btnPhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPhoto.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OpenFileDialog1
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbImage.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbImage.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub btnDocumentsImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDocumentsImage.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OpenFileDialog1
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbDocumentsImage.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbDocumentsImage.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub txtStoneWeight_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtStoneWeight1.KeyPress, txtStoneWeight2.KeyPress, txtStoneWeight3.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub

    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("colBarCodeString").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("colBarCodeString").Value, vbYesNo) = vbYes Then
                Try
                    GlCommand.CommandText = "UPDATE [DIMON_detels] SET [Item_Actv]='0' WHERE DIMOND_ID='" & grid.CurrentRow.Cells("colID").Value & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    grid.Rows.Remove(grid.SelectedRows(0))
                Catch ex As Exception
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                End Try
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        If ChkBar.Checked = True Then
            Dim SearchBarCode As String = InputBox("أدخل الباركود المطلوب البحث عنه" & vbCrLf & "Enter a Barcode to search", AppTitle)
            If SearchBarCode = "" Then Exit Sub
            For Each row As DataGridViewRow In grid.Rows
                If row.Cells("colBarCodeString").Value.ToString = SearchBarCode Then
                    row.Selected = True
                    grid.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ElseIf chkItemNO.Checked = True Then
            Dim SearchBarCode As String = InputBox("أدخل رقم القطعه المطلوب البحث عنه" & vbCrLf & "Enter a Item NO. to search", AppTitle)
            If SearchBarCode = "" Then Exit Sub
            For Each row As DataGridViewRow In grid.Rows
                If row.Cells("colItemNo").Value.ToString = SearchBarCode Then
                    row.Selected = True
                    grid.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next
        ElseIf ChkCertificateNo.Checked = True Then
            Dim SearchBarCode As String = InputBox("أدخل رقم الشهاده المطلوب البحث عنه" & vbCrLf & "Enter a Certificate No. to search", AppTitle)
            If SearchBarCode = "" Then Exit Sub
            For Each row As DataGridViewRow In grid.Rows
                If row.Cells("ColCertificateNo").Value.ToString = SearchBarCode Then
                    row.Selected = True
                    grid.FirstDisplayedScrollingRowIndex = row.Index
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub btnExcelImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExcelImport.Click
        ExcelImportType = "DIAMOND"
        frmExcelImport.ShowDialog()
    End Sub
    Private Sub txtItemDCarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemDCarat.TextChanged
        TotalWeight()
    End Sub
    Private Sub TotalWeight()
        Select Case cmbStoneWeightType1.SelectedIndex
            Case 0
                Try
                    Dim CaratToGram, SumTotal, TotalWeight, StonWeight As Double
                    CaratToGram = Math.Round((Val(txtItemDCarat.Text.Trim) / 5), 4)
                    SumTotal = Math.Round((Val(txtItemGWeight.Text)), 4)
                    StonWeight = Math.Round(Val(txtStoneWeight1.Text) + Val(txtStoneWeight2.Text) + Val(txtStoneWeight3.Text), 4)
                    TotalWeight = CaratToGram + SumTotal
                    txtTotalWeight.Text = TotalWeight + ((StonWeight) / 5)
                Catch ex As Exception
                End Try
            Case 1
                Try
                    Dim CaratToGram, SumTotal, TotalWeight, StonWeight As Double
                    CaratToGram = Math.Round(Val(txtItemDCarat.Text.Trim), 4)
                    SumTotal = Math.Round((Val(txtItemGWeight.Text)), 4)
                    StonWeight = Math.Round(Val(txtStoneWeight1.Text) + Val(txtStoneWeight2.Text) + Val(txtStoneWeight3.Text), 4)
                    TotalWeight = CaratToGram + SumTotal
                    txtTotalWeight.Text = TotalWeight + ((StonWeight))
                Catch ex As Exception
                End Try
        End Select
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick
        GetImg()
    End Sub
    Private Sub txtItemGWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemGWeight.TextChanged
        TotalWeight()
    End Sub

    Private Sub CobUser_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CobUser.MouseClick

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorker.DoWork

        'Invoke(Sub(GetImg())




    End Sub
    Private Sub btnItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemName.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub cmbKarat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKarat.Leave
        If cmbKarat.Text.Trim = "" OrElse IsNumeric(cmbKarat.Text.Trim) = False Then
            MsgBox("اكتب عيار الذهب أولا " & vbCrLf & "Add Gold Carat First", , AppTitle)
            cmbKarat.SelectAll()
            cmbKarat.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtItemGWeight_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemGWeight.Leave
        If txtItemGWeight.Text.Trim = "" OrElse IsNumeric(txtItemGWeight.Text.Trim) = False Then
            MsgBox("اكتب وزن الذهب أولا " & vbCrLf & "Add Gold Weight First", , AppTitle)
            txtItemGWeight.SelectAll()
            txtItemGWeight.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub cmbCut_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCut.Leave
        If cmbCut.Text.Trim = "" Then
            MsgBox("حدد نوع القص" & vbCrLf & "Select Cut Type", , AppTitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If
    End Sub

    Private Sub txtItemClarity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemClarity.Leave
        If txtItemClarity.Text.Trim = "" Then
            MsgBox("اكتب النقاوة أولا " & vbCrLf & "Add Item Clarity First", , AppTitle)
            txtItemClarity.SelectAll()
            txtItemClarity.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtItemDCarat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemDCarat.Leave
        If txtItemDCarat.Text.Trim = "" OrElse IsNumeric(txtItemDCarat.Text.Trim) = False Then
            MsgBox("اكتب القيراط أولا " & vbCrLf & "Add Diamond Carat First", , AppTitle)
            txtItemDCarat.SelectAll()
            txtItemDCarat.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtItemColor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemColor.Leave
        If txtItemColor.Text.Trim = "" Then
            MsgBox("اكتب اللون أولا " & vbCrLf & "Add Diamond Color First", , AppTitle)
            txtItemColor.SelectAll()
            txtItemColor.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtTotalWeight_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalWeight.Leave
        If txtTotalWeight.Text.Trim = "" OrElse IsNumeric(txtTotalWeight.Text.Trim) = False Then
            txtTotalWeight.SelectAll()
            txtTotalWeight.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtQty_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.Leave
        If txtQty.Text.Trim = "" OrElse IsNumeric(txtQty.Text.Trim) = False Then
            txtQty.SelectAll()
            txtQty.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtItemPrice_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemPrice.Leave
        If txtItemPrice.Text.Trim = "" OrElse IsNumeric(txtItemPrice.Text.Trim) = False Then
            txtItemPrice.SelectAll()
            txtItemPrice.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub txtItemCost_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCost.Leave
        If txtItemCost.Text.Trim = "" OrElse IsNumeric(txtItemCost.Text.Trim) = False Then
            txtItemCost.SelectAll()
            txtItemCost.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub pbImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbImage.Click
        FrmViewImages.PicBoxViewImages.Image = pbImage.Image
        FrmViewImages.ShowDialog()
    End Sub

    Private Sub cobSupplier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cobSupplier.MouseClick
        Supplier()
    End Sub

    Private Sub cobSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobSupplier.SelectedIndexChanged

    End Sub

    Private Sub pbDocumentsImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbDocumentsImage.Click
        FrmViewImages.PicBoxViewImages.Image = pbDocumentsImage.Image
        FrmViewImages.ShowDialog()
    End Sub

    Private Sub btnPhoto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnPhoto.LinkClicked

    End Sub

    Private Sub btnDocumentsImage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnDocumentsImage.LinkClicked

    End Sub

    Private Sub cmbMetalType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMetalType.SelectedIndexChanged

    End Sub

    Private Sub txtStoneWeight1_TextChanged(sender As Object, e As EventArgs) Handles txtStoneWeight1.TextChanged
        TotalWeight()
    End Sub

    Private Sub txtStoneWeight2_TextChanged(sender As Object, e As EventArgs) Handles txtStoneWeight2.TextChanged
        TotalWeight()
    End Sub
    Private Sub txtStoneWeight3_TextChanged(sender As Object, e As EventArgs) Handles txtStoneWeight3.TextChanged
        TotalWeight()
    End Sub

    Private Sub cmbStoneWeightType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStoneWeightType1.SelectedIndexChanged
        cmbStoneWeightType2.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        cmbStoneWeightType3.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        TotalWeight()
    End Sub

    Private Sub cmbStoneWeightType2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStoneWeightType2.SelectedIndexChanged
        cmbStoneWeightType2.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        cmbStoneWeightType3.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        TotalWeight()
    End Sub
    Private Sub cmbStoneWeightType3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStoneWeightType3.SelectedIndexChanged
        cmbStoneWeightType2.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        cmbStoneWeightType3.SelectedIndex = cmbStoneWeightType1.SelectedIndex
        TotalWeight()
    End Sub
End Class