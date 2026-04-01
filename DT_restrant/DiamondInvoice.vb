Imports System.IO
Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports PACICardLibrary
Public Class DiamondInvoice
    ''''''''''''''''''''''''''''''''''''''''''''''بيع الباركود جمله
    Dim OpenFile As New OpenFileDialog
    Dim Read As IO.StreamReader
    Dim ListBox As New ListBox
    Dim switchSave As Boolean
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim paci As PACMAN
    Dim stringReader1 As String
    Public texte As String
    Public saryil As String
    Private InvoiceNo As String
    Public Notes As String
    Dim RemainingGoldWeight As Double
    Public CurrentCustomerName As String
    Public CurrentCustomerID As String
    Private Function txtStoneWeightOne() As Double
        Dim dt1 As DataTable = GetRecordSet("SELECT [test_13] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        txtStoneWeightOne = Val(dt1.Rows(0)(0).ToString)
    End Function
    Private Function txtStoneWeightTwo() As Double
        Dim dt1 As DataTable = GetRecordSet("SELECT [test_16] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        txtStoneWeightTwo = Val(dt1.Rows(0)(0).ToString)
    End Function
    Private Function txtStoneWeightThree() As Double
        Dim dt1 As DataTable = GetRecordSet("SELECT [test_19] FROM [DIMON_detels] WHERE [test_119] = N'" & txtBarCode.Text.Trim & "'")
        txtStoneWeightThree = Val(dt1.Rows(0)(0).ToString)
    End Function
    Private Sub DiamondInvoice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If switchSave = True Then
        ElseIf switchSave = False Then
        End If
        Saved = False
        ResetIDSeed("[dimon_invce]", "[dim_inv_id]")
        sc.Dispose()
        Dispose()
    End Sub
    Public Sub SingleAdd()
        If SET_INVARCHR152TextBox.Text = "1" Then
            If OriginalPiecesQty() - SoldPiecesQty() <= 0 Then
                MsgBox("تم بيع القطعة من قبل" & vbCrLf & "Item sold.", , AppTitle)
                txtBarCode.Clear()
                txtBarCode.Focus()
                Exit Sub
            End If
        End If
        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If
        If cmbCashier.Text = "اختر اسم الكاشير" OrElse cmbCashier.Text = "Select Cashier" Then
            MsgBox("اختر اسم الكاشير اولا" & vbCrLf & "Select Cashier", , AppTitle)
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        If cmbItemName.Text = "اختر الصنف" OrElse cmbItemName.Text = "Select Item" OrElse cmbItemName.Text.Trim = "" Then
            MsgBox("اختر اسم الصنف اولا" & vbCrLf & "Select Item Name", , AppTitle)
            cmbItemName.DroppedDown = True
            Exit Sub
        End If
        If txtQty.Text = "0" OrElse txtQty.Text = "" OrElse txtQty.Text < "1" Then
            MsgBox("اختر عدد القطع اولا" & vbCrLf & "Select Quantity First", , AppTitle)
            'cmbItemName.DroppedDown = True
            txtQty.Focus()
            txtQty.Select()
            Exit Sub
        End If
        If cmbCut.Text = "" Then
            MsgBox("اختر نوع القصة للقطعة" & vbCrLf & "Select Diamond Cut", , AppTitle)
            cmbCut.DroppedDown = True
            Exit Sub
        End If
        If Val(txtGramPrice.Text.Trim) = 0 OrElse IsNumeric(txtGramPrice.Text.Trim) = False Then
            If cmbGoldKarat.Text <> "0" Then
                If MsgBox("سعر الذهب صفر. هل تريد الاستمرار؟" & vbCrLf & "Gold Price is Zero, Continue?", vbYesNo, AppTitle) = vbNo Then
                    txtGramPrice.SelectAll()
                    txtGramPrice.Focus()
                    Exit Sub
                End If
            Else
                txtGramPrice.Text = "0"
            End If

        End If
        If SET_INVARCHR152TextBox.Text = "1" AndAlso (RemainingGoldWeight <= 0 OrElse Val(txtGoldWeight.Text) > RemainingGoldWeight) Then
            'MsgBox("وزن الذهب المكتوب أكبر من وزن ذهب القطعة غير المباع" & vbCrLf & "Gold Weight is greater than not sold gold weight!", , AppTitle)
            If MsgBox("وزن الذهب المكتوب أكبر من وزن ذهب القطعة غير المباع؟" & vbCrLf & "Gold Weight is greater than not sold gold weight!?", vbYesNo, AppTitle) = vbNo Then
                txtGoldWeight.SelectAll()
                txtGoldWeight.Focus()
                Exit Sub
            End If

        End If
        If Val(txtPrice.Text.Trim) = 0 OrElse IsNumeric(txtPrice.Text.Trim) = False Then
            If MsgBox("سعر الذهب صفر. هل تريد الاستمرار؟" & vbCrLf & "Gold Price is Zero, Continue?", vbYesNo, AppTitle) = vbNo Then
                txtPrice.SelectAll()
                txtPrice.Focus()
                Exit Sub
            End If


        End If
        If Val(txtPrice.Text.Trim) <= Val(Test_12TextBox.Text) Then
            If MsgBox("سعر البيع أقل من سعر التكلفة..هل تريد البيع؟" & vbCrLf & "Selling Price is Lower than Cost, Proceed with Selling?", vbYesNo, AppTitle) <> vbYes Then
                txtPrice.SelectAll()
                txtPrice.Focus()
                Exit Sub
            End If
        End If

        If SET_INVARCHR152TextBox.Text = "1" Then
            For i As Integer = 0 To grid.Rows.Count - 1
                If txtBarCode.Text = grid.Rows(i).Cells("coltest_119").Value Then
                    MsgBox("الصنف موجود بنفس الفاتورة ولا يمكن بيعه مرة أخرى" & vbCrLf & "Item Exist in this invoice and Can't be resold", , AppTitle)
                    Exit Sub
                End If
            Next
        End If
        btnPayPrint.Enabled = True
        btnPayPrint.Visible = True
        Try
            With grid
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("coldim_inv_id").Value = grid.Rows.Count
                .Rows(.Rows.Count - 1).Cells("coldimo_id").Value = txtBarCode.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colcastomr_id").Value = CivilIDForm.txtCID.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coldescont").Value = "TEMP"
                .Rows(.Rows.Count - 1).Cells("coltotal").Value = Val(txtPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colar_taype").Value = kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True)
                .Rows(.Rows.Count - 1).Cells("colDIMO_Type").Value = cmbItemName.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIM_na9awa").Value = txtClarity.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_mezan").Value = txtDiamondWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_coler").Value = txtDiamondColor.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_qult").Value = txtQty.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colsarual").Value = If(txtItemNo.Text.Trim = "", "-", txtItemNo.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("colval_gold").Value = cmbGoldKarat.Text
                .Rows(.Rows.Count - 1).Cells("colGOLD_mezan").Value = txtGoldWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coluser_creted").Value = frmLogin.User_idTextBox.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coldate_creted").Value = dtpInvoiceDate.Value
                .Rows(.Rows.Count - 1).Cells("coltime").Value = DateTimeToView(dtpInvoiceDate.Value)
                .Rows(.Rows.Count - 1).Cells("coldim_foto").Value = DBNull.Value
                .Rows(.Rows.Count - 1).Cells("coltest_13").Value = Val(txtStoneWeight1.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_14").Value = cmbStone1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_15").Value = cmbStoneColor1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_16").Value = Val(txtStoneWeight2.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_17").Value = cmbStone2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_18").Value = cmbStoneColor2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_19").Value = Val(txtStoneWeight3.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_110").Value = cmbStone3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_111").Value = cmbStoneColor3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_112").Value = DBNull.Value
                .Rows(.Rows.Count - 1).Cells("coltest_116").Value = txtTotalWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_117").Value = cmbCut.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_118").Value = DBNull.Value
                .Rows(.Rows.Count - 1).Cells("coltest_119").Value = txtBarCode.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colIsCertificateNumber").Value = txtCertificateNo.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colnotes").Value = txtNotes.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colstaytes").Value = "1"
                .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = Val(txtGramPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colSoldItem").Value = If(cmbSoldItemNames.Text.Trim = "", cmbItemName.Text.Trim, cmbSoldItemNames.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("colCut1").Value = cmbStoneCut1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity1").Value = txtStoneClarity1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colCut2").Value = cmbStoneCut2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity2").Value = txtStoneClarity2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colCut3").Value = cmbStoneCut3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity3").Value = txtStoneClarity3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colIsDiamond1").Value = If(cmbStone1.SelectedIndex = -1, False, cmbStone1.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colIsDiamond2").Value = If(cmbStone2.SelectedIndex = -1, False, cmbStone2.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colIsDiamond3").Value = If(cmbStone3.SelectedIndex = -1, False, cmbStone3.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = 1 'Active Item
            End With
            CalculateTotalPrice()
            MsgBox("تم إضافة صنف بنجاح" & vbCrLf & "Item Added Successfully", , AppTitle)
            btnPayPrint.Visible = True
            ClearSelection()
            txtBarCode.Text = String.Empty
            dtpInvoiceDate.Enabled = False
            cmbCashier.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Public Sub FromTextAdd()
        If SET_INVARCHR152TextBox.Text = "1" Then
            If OriginalPiecesQty() - SoldPiecesQty() <= 0 Then
                MsgBox("تم بيع القطعة من قبل" & vbCrLf & "Item sold.", , AppTitle)
                txtBarCode.Clear()
                txtBarCode.Focus()
                Exit Sub
            End If
        End If
        If txtQty.Text = "0" OrElse txtQty.Text = "" OrElse txtQty.Text < "1" Then
            txtQty.Text = "1"
        End If

        If cmbCut.Text = "" Then
            cmbCut.Text = "FC"
        End If
        If SET_INVARCHR152TextBox.Text = "1" Then
            For i As Integer = 0 To grid.Rows.Count - 1
                If txtBarCode.Text = grid.Rows(i).Cells("coltest_119").Value Then
                    MsgBox("الصنف موجود بنفس الفاتورة ولا يمكن بيعه مرة أخرى" & vbCrLf & "Item Exist in this invoice and Can't be resold", , AppTitle)
                    Exit Sub
                End If
            Next
        End If
        btnPayPrint.Enabled = True
        btnPayPrint.Visible = True
        Try
            With grid
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("coldim_inv_id").Value = grid.Rows.Count
                .Rows(.Rows.Count - 1).Cells("coldimo_id").Value = txtBarCode.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colcastomr_id").Value = CivilIDForm.txtCID.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coldescont").Value = "TEMP"
                .Rows(.Rows.Count - 1).Cells("coltotal").Value = Val(txtPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colar_taype").Value = kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True)
                .Rows(.Rows.Count - 1).Cells("colDIMO_Type").Value = cmbItemName.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIM_na9awa").Value = txtClarity.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_mezan").Value = txtDiamondWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_coler").Value = txtDiamondColor.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colDIMO_qult").Value = txtQty.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colsarual").Value = If(txtItemNo.Text.Trim = "", "-", txtItemNo.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("colval_gold").Value = cmbGoldKarat.Text
                .Rows(.Rows.Count - 1).Cells("colGOLD_mezan").Value = txtGoldWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coluser_creted").Value = frmLogin.User_idTextBox.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coldate_creted").Value = dtpInvoiceDate.Value
                .Rows(.Rows.Count - 1).Cells("coltime").Value = DateTimeToView(dtpInvoiceDate.Value)
                .Rows(.Rows.Count - 1).Cells("coldim_foto").Value = If(ITEM_IMGEPictureBox.Image Is Nothing, DBNull.Value, ImageToByte(ITEM_IMGEPictureBox.Image))
                .Rows(.Rows.Count - 1).Cells("coltest_13").Value = Val(txtStoneWeight1.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_14").Value = cmbStone1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_15").Value = cmbStoneColor1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_16").Value = Val(txtStoneWeight2.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_17").Value = cmbStone2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_18").Value = cmbStoneColor2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_19").Value = Val(txtStoneWeight3.Text)
                .Rows(.Rows.Count - 1).Cells("coltest_110").Value = cmbStone3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_111").Value = cmbStoneColor3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_112").Value = DBNull.Value
                .Rows(.Rows.Count - 1).Cells("coltest_116").Value = txtTotalWeight.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_117").Value = cmbCut.Text.Trim
                .Rows(.Rows.Count - 1).Cells("coltest_118").Value = DBNull.Value
                .Rows(.Rows.Count - 1).Cells("coltest_119").Value = txtBarCode.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colIsCertificateNumber").Value = txtCertificateNo.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colnotes").Value = txtNotes.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colstaytes").Value = "1"
                .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = Val(txtGramPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colSoldItem").Value = If(cmbSoldItemNames.Text.Trim = "", cmbItemName.Text.Trim, cmbSoldItemNames.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("colCut1").Value = cmbStoneCut1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity1").Value = txtStoneClarity1.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colCut2").Value = cmbStoneCut2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity2").Value = txtStoneClarity2.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colCut3").Value = cmbStoneCut3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colClarity3").Value = txtStoneClarity3.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colIsDiamond1").Value = If(cmbStone1.SelectedIndex = -1, False, cmbStone1.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colIsDiamond2").Value = If(cmbStone2.SelectedIndex = -1, False, cmbStone2.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colIsDiamond3").Value = If(cmbStone3.SelectedIndex = -1, False, cmbStone3.SelectedValue)
                .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = 1 'Active Item
                .Rows(.Rows.Count - 1).Cells("colDAIimage").Value = If(ITEM_IMGEPictureBox.Image Is Nothing, DBNull.Value, (ITEM_IMGEPictureBox.Image))
                '
            End With
            CalculateTotalPrice()
            btnPayPrint.Visible = True
            ClearSelection()
            txtBarCode.Text = String.Empty
            dtpInvoiceDate.Enabled = False
            cmbCashier.Enabled = False
        Catch ex As Exception

        End Try

    End Sub
    Private Sub DiamondInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        switchSave = False
        CheckUserPermissions(UserID)
        Visible = False
        If Val(gold24) = 0 Then
            GetPricesOffline()
        End If
        language_start(Name)

        '''''''''''''''''''''''''''''''''''''''''''''''' البطاقة المدنية
        EditForm = False
        Try
            CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 255)}
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        GetCashier()
        GetGoldKarat()
        ITEM_IMGEPictureBox.Image = Nothing
        Daymon_bay_saryailTableAdapter.Fill(DT_restrantDataSet.daymon_bay_saryail)

        Dim dt1 As DataTable = GetRecordSet("SELECT [chkLimitStock] FROM [user] WHERE [user_name] = N'" & UserName & "'")
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

        If cmbCashier.Items.Count = 1 Then
            cmbCashier.SelectedIndex = 0
        Else
            If frmLogin.rbtnAr.Checked = True Then
                cmbCashier.Text = "اختر اسم الكاشير"
            ElseIf frmLogin.rbtnEn.Checked = True Then
                cmbCashier.Text = "Select Cashier"
            End If
        End If
        btnPayPrint.Enabled = False
        GetDiamondCut()
        FillStoneName()
        FillStoneColor()
        FillSoldItemNames()
        ClearCombo()
        cmbItemName.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.DIMON_NAME_FILTER, "DIMO_dep", cmbItemName)
        If SET100TextBox.Text = "1" Then
            cmbItemName.DropDownStyle = ComboBoxStyle.Simple
        End If
        Visible = True
        min_Sales.Hide()
        ResetIDSeed("[dimon_invce]", "[dim_inv_id]")
        texte = stringReader1
        CivilIDForm.txtCID.SelectAll()
        CivilIDForm.txtCID.Focus()
    End Sub
    Private Sub FillDiamondItems(ByVal chkLimitItem As Boolean)
        Dim SQLString As String = String.Empty
        If chkLimitItem = True Then
            SQLString = "SELECT DIMON_detels.DIMO_dep AS [ItemName] , DIMON_detels.test_119 AS [BarCode]" &
                        "From DIMON_detels LEFT OUTER Join dimon_invce On DIMON_detels.test_119 = dimon_invce.dimo_id " &
                        "WHERE dimon_invce.dimo_id IS NULL And DIMON_detels.qult=N'" & UserName & "'" &
                        "GROUP BY DIMON_detels.DIMO_dep, DIMON_detels.test_119"
        Else
            SQLString = "SELECT DIMON_detels.DIMO_dep AS [ItemName] , DIMON_detels.test_119 AS [BarCode]" &
                        "From DIMON_detels LEFT OUTER Join dimon_invce On DIMON_detels.test_119 = dimon_invce.dimo_id " &
                        "WHERE dimon_invce.dimo_id IS NULL " &
                        "GROUP BY  DIMON_detels.DIMO_dep, DIMON_detels.test_119"
        End If
        If chkLimitItem = True Then
            SQLString = "SELECT [DIMO_dep] AS [ItemName] , [test_119] AS [BarCode] FROM [DIMON_detels] WHERE [Item_Actv] <> 0 AND [qult] =N'" & UserName & "'"
        Else
            SQLString = "SELECT [DIMO_dep] AS [ItemName] , [test_119] AS [BarCode] FROM [DIMON_detels] WHERE [Item_Actv] <> 0 "
        End If
        'End If

        Dim dt1 As DataTable = GetRecordSet(SQLString)
        If dt1.Rows.Count > 0 Then
            With cmbItemName
                .DataSource = dt1
                .DisplayMember = "ItemName"
                .ValueMember = "BarCode"
            End With
        End If
    End Sub
    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [Active] <> 0")
        If dt1.Rows.Count > 0 Then
            With cmbCashier
                .DataSource = dt1
                .DisplayMember = "cacher_name"
                .ValueMember = "svil_id"
            End With
        End If
    End Sub
    Private Sub GetGoldKarat()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Gram_valu] FROM [Gram_val] WHERE Gram_valu NOT LIKE 0 OR Gram_valu NOT LIKE NULL ORDER BY [Gram_valu] ASC")
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
        Dim dt1 As DataTable = GetRecordSet("SELECT [IsDiamond], [EXTR_NAME] FROM [EXTR_NAME]")
        If dt1.Rows.Count > 0 Then
            cmbStone1.DataSource = dt1
            cmbStone1.DisplayMember = "EXTR_NAME"
            cmbStone1.ValueMember = "IsDiamond"
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [IsDiamond], [EXTR_NAME] FROM [EXTR_NAME]")
        If dt2.Rows.Count > 0 Then
            cmbStone2.DataSource = dt2
            cmbStone2.DisplayMember = "EXTR_NAME"
            cmbStone2.ValueMember = "IsDiamond"
        End If
        Dim dt3 As DataTable = GetRecordSet("SELECT [IsDiamond], [EXTR_NAME] FROM [EXTR_NAME]")
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

    Private Sub cmbItemName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex = -1 Then
            ClearSelection()
            Exit Sub
        End If
        If cmbItemName.Focused = True Then
            txtBarCode.Text = cmbItemName.SelectedValue
        End If
    End Sub

    Private Sub txtBarCode_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtBarCode.MouseClick
        txtBarCode.SelectAll()
    End Sub

    Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarCode.TextChanged
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
                'MsgBox("تم بيع القطعة من قبل" & vbCrLf & "Item sold.", , AppTitle)
                'txtBarCode.Clear()
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
        cmbStone1.Text = Test_14TextBox1.Text
        cmbStoneColor1.Text = Test_15TextBox1.Text
        txtStoneClarity1.Text = Clarity1TextBox.Text
        cmbStoneCut1.Text = Cut1TextBox.Text
        cmbStone2.Text = Test_17TextBox1.Text
        cmbStoneColor2.Text = Test_18TextBox1.Text
        txtStoneClarity2.Text = Clarity2TextBox.Text
        cmbStoneCut2.Text = Cut2TextBox.Text
        txtStoneWeight3.Text = txtStoneWeightThree.ToString
        txtStoneWeight2.Text = txtStoneWeightTwo.ToString
        txtStoneWeight1.Text = txtStoneWeightOne.ToString
        cmbStone3.Text = Test_110TextBox1.Text
        cmbStoneColor3.Text = Test_111TextBox1.Text
        txtStoneClarity3.Text = Clarity3TextBox.Text
        cmbStoneCut3.Text = Cut3TextBox.Text
        txtPrice.Text = Test_1TextBox.Text
        txtCertificateNo.Text = Test_115TextBox.Text
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
    Public Sub SaveGrid(ByVal InvoiceNo As String)
        Try
            For i As Integer = 0 To grid.Rows.Count - 1

                GlCommand.CommandText = "INSERT INTO [dimon_invce] " &
                                        "([dimo_id] " &
                                        ",[castomr_id] " &
                                        ",[descont] " &
                                        ",[total] " &
                                        ",[ar_taype] " &
                                        ",[DIMO_Type] " &
                                        ",[DIM_na9awa] " &
                                        ",[DIMO_mezan] " &
                                        ",[DIMO_coler] " &
                                        ",[DIMO_qult] " &
                                        ",[sarual] " &
                                        ",[val_gold] " &
                                        ",[GOLD_mezan] " &
                                        ",[user_creted] " &
                                        ",[date_creted] " &
                                        ",[time] " &
                                        ",[dim_foto] " &
                                        ",[test_13] " &
                                        ",[test_14] " &
                                        ",[test_15] " &
                                        ",[test_16] " &
                                        ",[test_17] " &
                                        ",[test_18] " &
                                        ",[test_19] " &
                                        ",[test_110] " &
                                        ",[test_111] " &
                                        ",[test_112] " &
                                        ",[test_116] " &
                                        ",[test_117] " &
                                        ",[test_118] " &
                                        ",[test_119] " &
                                        ",[notes] " &
                                        ",[Item_Actv] " &
                                        ",[staytes] " &
                                        ",[GramPrice] " &
                                        ",[SoldItem] " &
                                        ",[Cut1] " &
                                        ",[Clarity1] " &
                                        ",[Cut2] " &
                                        ",[Clarity2] " &
                                        ",[Cut3] " &
                                        ",[Clarity3] " &
                                        ",[IsDiamond1] " &
                                        ",[IsDiamond2] " &
                                        ",[IsDiamond3] " &
                                        ",[CertificateNumber]) " &
                                        "VALUES " &
                                        "(@dimo_id " &
                                        ",@castomr_id " &
                                        ",@descont " &
                                        ",@total " &
                                        ",@ar_taype " &
                                        ",@DIMO_Type " &
                                        ",@DIM_na9awa " &
                                        ",@DIMO_mezan " &
                                        ",@DIMO_coler " &
                                        ",@DIMO_qult " &
                                        ",@sarual " &
                                        ",@val_gold " &
                                        ",@GOLD_mezan " &
                                        ",@user_creted " &
                                        ",@date_creted " &
                                        ",@time " &
                                        ",@dim_foto " &
                                        ",@test_13 " &
                                        ",@test_14 " &
                                        ",@test_15 " &
                                        ",@test_16 " &
                                        ",@test_17 " &
                                        ",@test_18 " &
                                        ",@test_19 " &
                                        ",@test_110 " &
                                        ",@test_111 " &
                                        ",@test_112 " &
                                        ",@test_116 " &
                                        ",@test_117 " &
                                        ",@test_118 " &
                                        ",@test_119 " &
                                        ",@notes " &
                                        ",@Item_Actv " &
                                        ",@staytes " &
                                        ",@GramPrice " &
                                        ",@SoldItem " &
                                        ",@Cut1 " &
                                        ",@Clarity1 " &
                                        ",@Cut2 " &
                                        ",@Clarity2 " &
                                        ",@Cut3 " &
                                        ",@Clarity3 " &
                                        ",@IsDiamond1 " &
                                        ",@IsDiamond2 " &
                                        ",@IsDiamond3 " &
                                        ",@CertificateNumber) "
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@dimo_id", grid.Rows(i).Cells("coldimo_id").Value)
                    .AddWithValue("@castomr_id", grid.Rows(i).Cells("colcastomr_id").Value)
                    .AddWithValue("@descont", InvoiceNo)
                    .AddWithValue("@total", grid.Rows(i).Cells("coltotal").Value)
                    .AddWithValue("@ar_taype", grid.Rows(i).Cells("colar_taype").Value)
                    .AddWithValue("@DIMO_Type", grid.Rows(i).Cells("colDIMO_Type").Value)
                    .AddWithValue("@DIM_na9awa", grid.Rows(i).Cells("colDIM_na9awa").Value)
                    .AddWithValue("@DIMO_mezan", grid.Rows(i).Cells("colDIMO_mezan").Value)
                    .AddWithValue("@DIMO_coler", grid.Rows(i).Cells("colDIMO_coler").Value)
                    .AddWithValue("@DIMO_qult", grid.Rows(i).Cells("colDIMO_qult").Value)
                    .AddWithValue("@sarual", grid.Rows(i).Cells("colsarual").Value)
                    .AddWithValue("@val_gold", grid.Rows(i).Cells("colval_gold").Value)
                    .AddWithValue("@GOLD_mezan", grid.Rows(i).Cells("colGOLD_mezan").Value)
                    .AddWithValue("@user_creted", grid.Rows(i).Cells("coluser_creted").Value)
                    .AddWithValue("@date_creted", dtpInvoiceDate.Value)
                    .AddWithValue("@time", Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss tt"))
                    .Add("@dim_foto", SqlDbType.Image).Value = DBNull.Value
                    .AddWithValue("@test_13", grid.Rows(i).Cells("coltest_13").Value)
                    .AddWithValue("@test_14", grid.Rows(i).Cells("coltest_14").Value)
                    .AddWithValue("@test_15", grid.Rows(i).Cells("coltest_15").Value)
                    .AddWithValue("@test_16", grid.Rows(i).Cells("coltest_16").Value)
                    .AddWithValue("@test_17", grid.Rows(i).Cells("coltest_17").Value)
                    .AddWithValue("@test_18", grid.Rows(i).Cells("coltest_18").Value)
                    .AddWithValue("@test_19", grid.Rows(i).Cells("coltest_19").Value)
                    .AddWithValue("@test_110", grid.Rows(i).Cells("coltest_110").Value)
                    .AddWithValue("@test_111", grid.Rows(i).Cells("coltest_111").Value)
                    .AddWithValue("@test_112", grid.Rows(i).Cells("coltest_112").Value)
                    .AddWithValue("@test_116", grid.Rows(i).Cells("coltest_116").Value)
                    .AddWithValue("@test_117", grid.Rows(i).Cells("coltest_117").Value)
                    .AddWithValue("@test_118", cmbCashier.SelectedValue)
                    .AddWithValue("@test_119", grid.Rows(i).Cells("coltest_119").Value)
                    .AddWithValue("@notes", grid.Rows(i).Cells("colnotes").Value)
                    .AddWithValue("@Item_Actv", 1)
                    .AddWithValue("@staytes", 1)
                    .AddWithValue("@GramPrice", grid.Rows(i).Cells("colGramPrice").Value)
                    .AddWithValue("@SoldItem", grid.Rows(i).Cells("colSoldItem").Value)
                    .AddWithValue("@Cut1", grid.Rows(i).Cells("colCut1").Value)
                    .AddWithValue("@Clarity1", grid.Rows(i).Cells("colClarity1").Value)
                    .AddWithValue("@Cut2", grid.Rows(i).Cells("colCut2").Value)
                    .AddWithValue("@Clarity2", grid.Rows(i).Cells("colClarity2").Value)
                    .AddWithValue("@Cut3", grid.Rows(i).Cells("colCut3").Value)
                    .AddWithValue("@Clarity3", grid.Rows(i).Cells("colClarity3").Value)
                    .AddWithValue("@IsDiamond1", grid.Rows(i).Cells("colIsDiamond1").Value)
                    .AddWithValue("@IsDiamond2", grid.Rows(i).Cells("colIsDiamond2").Value)
                    .AddWithValue("@IsDiamond3", grid.Rows(i).Cells("colIsDiamond3").Value)
                    .AddWithValue("@CertificateNumber", grid.Rows(i).Cells("colIsCertificateNumber").Value)
                End With
                GlCommand.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If switchSave = False Then
            SingleAdd()
        ElseIf switchSave = True Then
            Dim CID As String = CivilIDForm.txtCID.Text.Trim
            If CivilIDForm.SaveCustomerData() = False Then
                Exit Sub
            Else
                CivilIDForm.txtCID.Enabled = False
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If cmbCashier.Text = "اختر اسم الكاشير" OrElse cmbCashier.Text = "Select Cashier" Then
                MsgBox("اختر اسم الكاشير اولا" & vbCrLf & "Select Cashier", , AppTitle)
                cmbCashier.DroppedDown = True
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
            For i = 0 To ListBox.Items.Count - 1
                txtBarCode.Text = (ListBox.Items(i).ToString)
                FromTextAdd()
            Next
            CalculateTotalPrice()
        End If
    End Sub
    Public Sub PayPrintEnable()
        If txtTotalPrice.Text = "0" Then
            btnPayPrint.Visible = False
        Else
            btnPayPrint.Visible = True
        End If
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            CalculateTotalPrice()
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
            PayPrintEnable()
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
        End Try

    End Sub

    Private Sub CalculateTotalPrice()

        Dim TotalPrice As Double
        For i As Integer = 0 To grid.RowCount - 1
            TotalPrice += grid.Rows(i).Cells("coltotal").Value
        Next
        txtTotalPrice.Text = TotalPrice
    End Sub


    Private Sub btnPayPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPayPrint.Click
        CurrentCustomerID = CivilIDForm.txtCID.Text.Trim
        CurrentCustomerName = CivilIDForm.txtName.Text.Trim
        With DiamondInvoicePay
            .txtPrice.Text = txtTotalPrice.Text
            .ShowDialog()
        End With

    End Sub

    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        Try
            If grid.Rows(e.RowIndex).Cells("colID").Value = -1 Then Exit Sub
        Catch ex As Exception

        End Try

        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("coltest_119").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("coltest_119").Value, vbYesNo) = vbYes Then
                Try
                    grid.Rows.RemoveAt(e.RowIndex)
                    CalculateTotalPrice()
                    PayPrintEnable()
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If
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

    Private Sub txtWeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStoneWeight1.TextChanged, txtStoneWeight2.TextChanged, txtStoneWeight3.TextChanged, txtDiamondWeight.TextChanged
        If SET_INVARCHR170TextBox.Text <> "1" Then
            txtTotalWeight.Text = GetTotalWeight()
        Else
            If sender.Focused = True Then
                txtGoldWeight.Text = GetGoldWeight()
            End If
        End If
    End Sub
    Private Sub txtGoldWeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtGoldWeight.TextChanged
        If SET_INVARCHR170TextBox.Text <> "1" Then
            txtTotalWeight.Text = GetTotalWeight()
        End If
    End Sub
    Private Sub txtTotalWeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotalWeight.TextChanged
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

    Private Sub cmbItemName_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cmbItemName.KeyDown
        If SET100TextBox.Text = "1" Then
            If e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Up Then
                e.Handled = True
                e.SuppressKeyPress = True
            End If
        End If
    End Sub


    Private Sub BtnWholesale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWholesale.Click
        If switchSave = False Then
            switchSave = True
        ElseIf switchSave = True Then
        End If
        With OpenFile
            .FileName = ""
            .Filter = "Text File |*.txt"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Path As String = .FileName
                Read = New IO.StreamReader(Path)
                While (Read.Peek() > -1)
                    ListBox.Items.Add(Read.ReadLine)
                End While
                Read.Close()
            End If
        End With
        Try
            txtBarCode.Text = ListBox.Items(0).ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.TextChanged

    End Sub
End Class