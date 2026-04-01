Imports System.IO
Imports PACICardLibrary
Imports System.Globalization
Imports System.Text.RegularExpressions


Public Class GoldInvoice
    Dim paci As PACMAN
    Public saryil As Integer
    Private InvoiceNo As String
    Public Notes As String
    Dim dtItemData As DataTable
    Public DataGetFromSet As DataTable = GetRecordSet("SELECT * from Settings")
    Dim GetMakChar As Decimal
    Dim DTtTax As DataTable = GetRecordSet("SELECT *  FROM [TPTax]")
    Dim TaxActive As Boolean
    'Public ActivationPurchase As Boolean = False
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
    Public Sub GetNameCacher()
        Dim DtGetNameCacher As DataTable = GetRecordSet("SELECT * FROM [cacher] where [Active]=1")
        If DtGetNameCacher.Rows.Count > 0 Then
            cmbCashier.DataSource = DtGetNameCacher
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Public Sub txtBarCodeTextChanged()
        Try
            cmbItem.SelectedValue = txtBarCode.Text.Trim
        Catch ex As Exception
            cmbItem.SelectedIndex = -1
        End Try
        If txtBarCode.Text = "" OrElse cmbItem.SelectedValue = Nothing Then
            cmbItem.SelectedIndex = -1
            If (txtBarCode.Text = "") Then
                txtMetalWeight.Text = ""
                txtPricePerGram.Text = ""
                txtMetalPrice.Text = ""
                txtCostPerItem.Text = ""
                txtKarat.Text = ""
                txtMakeCharge.Text = ""
                txtQty.Text = ""
                txtTotalPrice.Text = ""
                'txtNotes.Text = ""
                txtItemNmeInInvoce.Text = ""
            ElseIf (cmbItem.Text = "") Then
                txtMetalWeight.Text = ""
                txtPricePerGram.Text = ""
                txtMetalPrice.Text = ""
                txtCostPerItem.Text = ""
                txtKarat.Text = ""
                txtMakeCharge.Text = ""
                txtQty.Text = ""
                txtTotalPrice.Text = ""
                'txtNotes.Text = ""
                txtItemNmeInInvoce.Text = ""
            End If
            txtQty.Text = "1"

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
        CheckUserPermissions(UserID)
    End Sub

    Public Sub GoldInvoiceLoad()
        language_start(Name)
        Dim ItemSold As DataTable = GetRecordSet("SELECT SET_INVARCHR151 from Settings")
        If ItemSold.Rows.Count > 0 Then
            Dim ItemSoldActiv As Integer = DataGetFromSet.Rows(0)("SET_INVARCHR151").ToString
            If ItemSoldActiv = 0 Then
                Dim dt1 As DataTable = GetRecordSet("SELECT FO_name, BarCode FROM  dbo.FO_min  GROUP BY FO_name, BarCode, ID HAVING (SUM(Item_Actv) = 1) ORDER BY ID")
                cmbItem.DataBindings.Clear()
                cmbItem.DisplayMember = "FO_Name"
                cmbItem.ValueMember = "BarCode"
                cmbItem.DataSource = dt1
            ElseIf ItemSoldActiv = 1 Then
                Dim dt1 As DataTable = GetRecordSet("SELECT dbo.FO_min.FO_name, dbo.FO_min.BarCode " & vbCrLf &
                                                    "FROM dbo.FO_min LEFT OUTER JOIN " & vbCrLf &
                                                    "dbo.selInvoceDetels ON dbo.FO_min.BarCode = dbo.selInvoceDetels.itemID " & vbCrLf &
                                                    "WHERE  (dbo.selInvoceDetels.itemID IS NULL) OR " & vbCrLf &
                                                    "(dbo.FO_min.Gram_valu <= '24') AND (dbo.selInvoceDetels.Active = 0) " & vbCrLf &
                                                    "GROUP BY dbo.FO_min.FO_name, dbo.FO_min.BarCode, dbo.FO_min.ID " & vbCrLf &
                                                    "HAVING(SUM(dbo.FO_min.Item_Actv) = 1) " & vbCrLf &
                                                    "ORDER BY dbo.FO_min.ID")
                cmbItem.DataBindings.Clear()
                cmbItem.DisplayMember = "FO_Name"
                cmbItem.ValueMember = "BarCode"
                cmbItem.DataSource = dt1
            End If
        End If

    End Sub
    Public Sub AddNewItemInDataGred()
        'منع تكرار بيع القطعه
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'ذهب
        If GoldOrSilver = True Then
            If DataGetFromSet.Rows.Count > 0 Then
                Dim ItemSoldActiv As Integer = DataGetFromSet.Rows(0)("SET_INVARCHR151").ToString
                If ItemSoldActiv = "1" Then
                    Dim DT As DataTable = GetRecordSet("SELECT  ItemID, SUM(Active) AS Active FROM dbo.selInvoceDetels GROUP BY ItemID  HAVING  [ItemID] = N'" & txtBarCode.Text.Trim & "'")
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
            'فضه
        ElseIf GoldOrSilver = False Then
            If DataGetFromSet.Rows.Count > 0 Then
                Dim ItemSoldActiv As Integer = DataGetFromSet.Rows(0)("SET_INVARCHR151").ToString
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
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If GoldOrSilver = True Then
                Dim GetItemActvDB As DataTable = GetRecordSet("SELECT BarCode, SUM(Item_Actv) AS Item_Actv FROM dbo.FO_min GROUP BY BarCode HAVING (BarCode = N'" & txtBarCode.Text.Trim & "')")
                If GetItemActvDB.Rows.Count > 0 Then
                    Dim GetItemActv As Integer = GetItemActvDB.Rows(0)("Item_Actv").ToString
                    If GetItemActv = 0 Then
                        MsgBox("لقد تم حزف الصنف مسبقا من قائمة الاصناف" & vbCrLf & "The item has been removed from the list of items entered", , "خطأ")
                        txtBarCode.Text = ""
                        txtBarCode.Text = ""
                        Exit Sub
                    End If
                End If
            ElseIf GoldOrSilver = False Then
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
        If cmbCashier.Text = "اختر اسم الكاشير" OrElse cmbCashier.Text = "Select Cashier" Then
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
        If SET_INVARCHR151TextBox.Text.Trim = "1" Then
            For i As Integer = 0 To grid.RowCount - 1
                If txtBarCode.Text.Trim = grid.Rows(i).Cells("colItemID").Value.ToString.Trim Then
                    MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , AppTitle)
                    Exit Sub
                End If
            Next
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
                .Rows(.Rows.Count - 1).Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
                .Rows(.Rows.Count - 1).Cells("colcacher").Value = cmbCashier.SelectedValue
                .Rows(.Rows.Count - 1).Cells("colItemID").Value = dtItemData.Rows(0)("BarCode").ToString
                .Rows(.Rows.Count - 1).Cells("coluserID").Value = frmLogin.User_nameTextBox.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colItemName").Value = If(txtItemNmeInInvoce.Text.Trim = "", cmbItem.Text.Trim, txtItemNmeInInvoce.Text.Trim)
                .Rows(.Rows.Count - 1).Cells("coldate").Value = CDate(dtpInvoiceDate.Value)
                .Rows(.Rows.Count - 1).Cells("colInvocDateTime").Value = Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss tt")
                .Rows(.Rows.Count - 1).Cells("colSroomName").Value = frmMain.lblCompanyName.Text.Trim
                '.Rows(.Rows.Count - 1).Cells("colNots").Value = txtNotes.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colItemCantrey").Value = dtItemData.Rows(0)("FO_made").ToString
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
                .Rows(.Rows.Count - 1).Cells("colGoledPurchasPrice").Value =
                .Rows(.Rows.Count - 1).Cells("colGoledMakeCharge").Value = Val(txtMakeCharge.Text)
                .Rows(.Rows.Count - 1).Cells("colTotalGoledPrice").Value = Val(txtTotalPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colTaxTextAm").Value = txtTaxTextAm.Text
                .Rows(.Rows.Count - 1).Cells("colTaxAmo").Value = txtTaxAmo.Text
            End With
            Try
                If txtNotes.Text <> "" Then Notes = txtNotes.Text
                txtTotalPriceValue.Text = CalculateTotalGridPrice()
                txtTpriceTtax.Text = CalculateTotalGridPriceTax() + CalculateTotalGridPrice()
                MsgBox("تم إضافة الصنف " & vbCrLf & "Item Added successfully", , AppTitle)
                dtpInvoiceDate.Enabled = False
                lblInvoiceValue.Text = InvoiceNo
                'Panel1.Visible = True
                btnPayPrint.Visible = True
                grid.Visible = True
                If txtNotes.Text.Trim <> "" Then Notes = txtNotes.Text.Trim
                txtBarCode.Text = ""
                txtTotalPrice.Text = ""
                'cmbCashier.Enabled = True
            Catch ex As Exception
                MsgBox("خطأ بعض الحقول المهمة فارغة" & vbCrLf & "Error in Data Entry..", , AppTitle)
                MsgBox(ex.ToString)
            End Try
            CalculateTotalGridPrice()
            txtTpriceTtax.Text = CalculateTotalGridPriceTax() + CalculateTotalGridPrice()
        Catch ex As Exception
            ex.ToString()
        End Try
        txtItemNmeInInvoce.Text = ""
        Try
            Dim DT As DataTable = GetRecordSet("SELECT [DefaultBarcode]FROM [Settings]")
            If DT.Rows.Count > 0 Then
                txtBarCode.SelectedText = DT.Rows(0)("DefaultBarcode").ToString
            Else
                txtBarCode.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Sub BeforeAdding()
        'منع تكرار بيع القطعه
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If SET_INVARCHR151TextBox.Text = "1" Then
            Dim DT As DataTable = GetRecordSet("SELECT  ItemID, SUM(Active) AS Active FROM dbo.selInvoceDetels GROUP BY ItemID  HAVING  [ItemID] = N'" & txtBarCode.Text.Trim & "'")
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
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim GetItemActvDB As DataTable = GetRecordSet("SELECT BarCode, SUM(Item_Actv) AS Item_Actv FROM dbo.FO_min GROUP BY BarCode HAVING (BarCode = N'" & txtBarCode.Text.Trim & "')")
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
        If cmbCashier.Text = "اختر اسم الكاشير" OrElse cmbCashier.Text = "Select Cashier" Then
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
        If SET_INVARCHR151TextBox.Text.Trim = "1" Then
            For i As Integer = 0 To grid.RowCount - 1
                If txtBarCode.Text.Trim = grid.Rows(i).Cells("colItemID").Value.ToString.Trim Then
                    MsgBox("لا يمكن بيع صنف سبق بيعه" & vbCrLf & "Can't Sell an Already Sold Item", , AppTitle)
                    Exit Sub
                End If
            Next
        End If

        If DataGetFromSet.Rows.Count > 0 Then
            Dim DataGet As Integer = DataGetFromSet.Rows(0)("SET4").ToString
            If DataGet = 1 Then
                If txtMakeCharge.Text <= 0 Then
                    MsgBox("قيمة المصنعيه اقل او تساوي صفر " & vbCrLf & "Error in Data Entry..", , AppTitle)
                    Exit Sub
                End If
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
                txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GoldInvoice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        'If Saved = False Then
        '    Do While SelInvoceDetelsBindingSource.Count <> 0 'removes displayed rows
        '        SelInvoceDetelsBindingSource.MoveFirst()
        '        SelInvoceDetelsBindingSource.RemoveCurrent()
        '        Validate()
        '        SelInvoceDetelsBindingSource.EndEdit()
        '        TableAdapterManager.UpdateAll(DT_restrantDataSet)
        '        SelInvoceDetelsBindingSource.EndEdit()
        '        SelInvoceDetelsTableAdapter.Update(DT_restrantDataSet.selInvoceDetels)
        '    Loop
        'End If
        Saved = False
        sc.Dispose()
        Dispose()
    End Sub
    Private Sub GetStoneName1()
        Try
            Dim dt1 As DataTable = GetRecordSet("SELECT [EXTR_NAME] , [AsGold] FROM [EXTR_NAME]")
            If dt1.Rows.Count > 0 Then
                cmbStoneName1.DataSource = dt1
                cmbStoneName1.DisplayMember = "EXTR_NAME"
                cmbStoneName1.ValueMember = "AsGold"
            End If
        Catch ex As Exception

        End Try

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
    Public Sub GetItemName()
        'Dim DtGoldItemName As DataTable = GetRecordSet("SELECT FO_name, BarCode, date_care FROM dbo.FO_min WHERE (Item_Actv = 1) ORDER BY date_care")
        'If DtGoldItemName.Rows.Count > 0 Then
        '    cmbItem.DataSource = DtGoldItemName
        '    cmbItem.DisplayMember = "FO_Name"
        '    cmbItem.ValueMember = "BarCode"
        'End If
        'cmbItem.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="FO_name", ComboBoxName:=cmbItem)
    End Sub
    Private Sub GoldInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(989, 642)
        ApplyIconsToContainer(Me)
        ControlsAsColor(ColorSelect:=Me)
        DGV_Style.ApplyGoldenStyle(grid) : DGV_Style.AutoFitColumns(grid)

        '''''''''''''''''''''''''''''''''''''''''''''''' البطاقة المدنية
        EditForm = False
        Try
            CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 255)}
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        GetStoneName1()
        GetStoneName2()
        GetStoneName3()
        Visible = False
        DateDateTimePicker.CustomFormat = "dd/MM/yyyy"
        DateDateTimePicker.Value = Date.Now
        GoldInvoiceLoad()
        btnPayPrint.Visible = False
        txtTotalPriceValue.Text = ""
        txtNotes.Text = ""
        txtQty.Text = 1
        txtBarCode.Text = "0"
        txtBarCode.Text = ""
        If cmbCashier.Items.Count = 1 Then
            cmbCashier.SelectedIndex = 0
        Else
            If frmLogin.rbtnAr.Checked = True Then
                cmbCashier.Text = "اختر اسم الكاشير"
            ElseIf frmLogin.rbtnEn.Checked = True Then
                cmbCashier.Text = "Select Cashier"
            End If
        End If
        txtStonePrice1.Text = 0
        DateDateTimePicker.Value = Date.Now
        txtMetalWeight.Text = ""
        txtPricePerGram.Text = ""
        txtMetalPrice.Text = ""
        txtStonePrice1.Text = ""
        txtStoneWeight1.Text = ""
        grid.RowHeadersVisible = False
        min_Sales.Hide()
        Visible = True
        If SET_INVARCHR167TextBox.Text <> "1" Then
            lblCostPerItem.Visible = False
            txtCostPerItem.Visible = False
        End If
        CivilIDForm.txtCID.SelectAll()
        CivilIDForm.txtCID.Focus()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT [DefaultBarcode]FROM [Settings]")
            If DT.Rows.Count > 0 Then
                txtBarCode.SelectedText = DT.Rows(0)("DefaultBarcode").ToString
            Else
                txtBarCode.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        cmbStoneName1.SelectedIndex = -1
        cmbStoneName2.SelectedIndex = -1
        cmbStoneName3.SelectedIndex = -1
        TaxSet()
        CheckUserPermissions(UserID)
        GetItemName()
        GetNameCacher()
        txtlblGoldPurPrice.Enabled = False
    End Sub


    Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtBarCode.TextChanged
        txtBarCodeTextChanged()
    End Sub
    Private Sub StoneAsGoldPrice()
        If SET_INVARCHR168TextBox.Text = "1" Then 'If StoneAsGold is Enabled
            If cmbStoneName1.SelectedValue = True Then
                txtStonePrice1.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight1.Text)
            End If
            If cmbStoneName2.SelectedValue = True Then
                txtStonePrice2.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight2.Text)
            End If
            If cmbStoneName3.SelectedValue = True Then
                txtStonePrice3.Text = (Val(txtPricePerGram.Text) + Val(txtMakeCharge.Text)) * Val(txtStoneWeight3.Text)
            End If
            txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
        End If
    End Sub
    Private Sub GetItemData()
        dtItemData = GetRecordSet("SELECT [ID] ,[userID] ,[FO_name] ,[FO_desp] ,[FO_price] ,[FO_GramPrice] ,[FO_gram] ," &
                                  "[FO_gramMade] ,[FO_made] ,[FO_extras] ,[FO_totalPrice] ,[Gram_valu] ,[ITEM_IMGE] ," &
                                  "[date_care] ,[FO_ItemNo] ,[StoneColor1] ,[StonePrice1] ,[StoneWeight2] ,[StoneName2] " &
                                  ",[StoneColor2] ,[StonePrice2] ,[StoneWeight3] ,[StoneName3] ,[StoneColor3] ,[StonePrice3] " &
                                  ",[Qty] ,[BarCode] ,[Item_Actv] FROM [FO_min] WHERE [BarCode] = N'" & txtBarCode.Text.Trim & "' AND (Item_Actv = 1)")
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
        'txtItemNmeInInvoce.Text = dtItemData.Rows(0)("FO_name").ToString
        If SET_INVARCHR169TextBox.Text = "1" Then
            txtStoneWeight1.Text = Format(Val(txtStoneWeight1.Text), "0.00")
            txtStoneWeight2.Text = Format(Val(txtStoneWeight2.Text), "0.00")
            txtStoneWeight3.Text = Format(Val(txtStoneWeight3.Text), "0.00")
            txtMetalWeight.Text = Format(Val(txtMetalWeight.Text), "0.00")
            txtMakeCharge.Text = Format(Val(txtMakeCharge.Text), "0.000")
        End If
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
    Private Sub ClearData()
        txtMetalWeight.Text = ""
        txtPricePerGram.Text = ""
        If GoldOrSilver = True Then
            txtMetalPrice.Text = ""
        End If
        txtStoneWeight1.Text = ""
        txtStonePrice1.Text = ""
        txtKarat.Text = ""
        txtQty.Text = "1"
    End Sub

    Private Sub cmbCashier_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbCashier.SelectedIndexChanged
        'CacherBindingSource.Filter = "cacher_name like'" & cmbCashier.Text & "'"
        DateDateTimePicker.Value = Now

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        AddNewItemInDataGred()
    End Sub


    Private Function CalculateTotalGridPrice() As Decimal
        CalculateTotalGridPrice = 0
        For i As Integer = 0 To grid.RowCount - 1
            CalculateTotalGridPrice += grid.Rows(i).Cells("colTotalGoledPrice").Value
        Next
        Return Math.Round(CalculateTotalGridPrice, 3)
    End Function
    Private Function CalculateTotalGridPriceTax() As Decimal
        CalculateTotalGridPriceTax = 0
        For i As Integer = 0 To grid.RowCount - 1
            CalculateTotalGridPriceTax += grid.Rows(i).Cells("colTaxTextAm").Value
        Next
        Return Math.Round(CalculateTotalGridPriceTax, 3)
    End Function


    Private Sub cmbCashier_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmbCashier.MouseClick
        cmbCashier.SelectAll()
    End Sub

    Private Sub txtPriceGram_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtPricePerGram.MouseClick
        txtPricePerGram.SelectAll()
    End Sub

    Private Sub txt_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles txtMetalPrice.MouseClick, txtStonePrice1.MouseClick, txtStoneColor1.MouseClick, txtStoneWeight1.MouseClick
        sender.SelectAll()
    End Sub

    Private Sub btnPayPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPayPrint.Click
        If Val(txtlblGoldPurPrice.Text.Trim) > Val(txtTpriceTtax.Text.Trim) Then
            Dim message As String = "⚠️ قيمة الذهب المستبدل أكبر من قيمة الذهب المباع!" & vbCrLf &
                                "هل تريد المتابعة؟" & vbCrLf & vbCrLf &
                                "⚠️ The value of the exchanged gold is greater than the sold gold!" & vbCrLf &
                                "Do you want to continue?"
            Dim result As DialogResult = MessageBox.Show(message, "تنبيه / Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.No Then
                ' إذا ضغط على لا → افرغ جدول المشتريات ثم اخرج
                DataGridView1.Rows.Clear()
                txtlblGoldPurPrice.Text = ""
                txtPrice.Text = ""
                txtGramPrice.Text = ""
                txtQunt.Text = ""
                TXTGoCaret999.Text = ""
                txtWeight.Text = ""
                cmbKarat.Text = ""
                If Me.Size = New Size(989, 637) Then
                    Me.Size = New Size(989, 688)
                ElseIf Me.Size = New Size(989, 688) Then
                    Me.Size = New Size(989, 637)
                End If
                Exit Sub
            End If

            Exit Sub
        End If
        Try
            GlCommand.CommandText = "UPDATE [selInvoceDetels] SET [cacher]='" & cmbCashier.SelectedValue & "' WHERE invoc_time= '" & Invoc_timeTextBox.Text & "'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        If GoldOrSilver = True Then
            'Gold
            GoldInvoicePay.ReportViewer1.BackColor = Color.SeaShell
            GoldInvoicePay.InvoiceTime = Invoc_timeTextBox.Text
            GoldInvoicePay.ShowDialog()
        Else
            'Silver
            GoldInvoicePay.ReportViewer1.BackColor = Color.Gainsboro
            GoldInvoicePay.InvoiceTime = Invoc_timeTextBox.Text
            GoldInvoicePay.ShowDialog()
        End If

        'GoldInvoicePay.txtCash.Text = If(String.IsNullOrWhiteSpace(txtlblGoldPurPrice.Text) OrElse Val(txtlblGoldPurPrice.Text) = 0, 0, txtlblGoldPurPrice.Text.Trim())
    End Sub

    Private Sub txtBarCode_Enter(ByVal sender As Object, ByVal e As EventArgs)
        'txtBarCode.SelectAll()
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("colItemID").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("colItemID").Value, vbYesNo) = vbYes Then
                Try
                    grid.Rows.RemoveAt(grid.CurrentRow.Index)
                    txtTotalPriceValue.Text = CalculateTotalGridPrice()
                    txtTpriceTtax.Text = CalculateTotalGridPriceTax()

                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل القطعة رقم " & grid.Rows(e.RowIndex).Cells("colItemID").Value & "؟" & vbCrLf & "Do You Want to Modify Item No. " & grid.Rows(e.RowIndex).Cells("colItemID").Value, vbYesNo) = vbYes Then
                Try
                    txtBarCode.Clear()
                    txtBarCode.Text = grid.Rows(e.RowIndex).Cells("colItemID").Value
                    cmbItem.Text = grid.Rows(e.RowIndex).Cells("colItemName").Value
                    txtItemNmeInInvoce.Text = grid.Rows(e.RowIndex).Cells("colItemName").Value
                    txtMetalWeight.Text = grid.Rows(e.RowIndex).Cells("colGoldWeight").Value
                    txtPricePerGram.Text = grid.Rows(e.RowIndex).Cells("colGramPrice").Value
                    txtMetalPrice.Text = grid.Rows(e.RowIndex).Cells("colGoledPrice").Value
                    txtMakeCharge.Text = grid.Rows(e.RowIndex).Cells("colGoledMakeCharge").Value
                    txtQty.Text = grid.Rows(e.RowIndex).Cells("colGoledPiecesQuantity").Value
                    txtTotalPrice.Text = grid.Rows(e.RowIndex).Cells("colTotalGoledPrice").Value
                    txtNotes.Text = grid.Rows(e.RowIndex).Cells("colNots").Value
                    ''''''''''''''''''اسم الحجر  
                    cmbStoneName1.SelectedText = If(IsDBNull(grid.Rows(e.RowIndex).Cells("colStonName1").Value), cmbStoneName1.SelectedIndex = -1, grid.Rows(e.RowIndex).Cells("colStonName1").Value)
                    cmbStoneName2.SelectedText = If(IsDBNull(grid.Rows(e.RowIndex).Cells("colStonName2").Value), cmbStoneName2.SelectedIndex = -1, grid.Rows(e.RowIndex).Cells("colStonName2").Value)
                    cmbStoneName2.SelectedText = If(IsDBNull(grid.Rows(e.RowIndex).Cells("colStonName3").Value), cmbStoneName3.SelectedIndex = -1, grid.Rows(e.RowIndex).Cells("colStonName3").Value)
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
                    grid.Rows.RemoveAt(grid.CurrentRow.Index)
                    txtTotalPriceValue.Text = CalculateTotalGridPrice()
                    txtTpriceTtax.Text = CalculateTotalGridPriceTax()

                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
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
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Search, CInt((e.CellBounds.Width / 2) - (My.Resources.Search.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Search.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If

    End Sub
    Private Sub GetMakeValue()
        If Val(txtMetalWeight.Text) = 0 Then
            txtMakeCharge.Text = ""
            Exit Sub
        End If
        If txtMetalPrice.Text = "" Then
            txtMakeCharge.Text = dtItemData.Rows(0)("colGoledMakeCharge").ToString
            Exit Sub
        End If
        If SET_INVARCHR168TextBox.Text = "1" Then
            txtMakeCharge.Text = Math.Round((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * (Val(txtMetalWeight.Text) + StoneAsGoldWeight())) / (Val(txtMetalWeight.Text) + StoneAsGoldWeight()), 3)
        Else
            txtMakeCharge.Text = Math.Round((Val(txtMetalPrice.Text) - Val(txtPricePerGram.Text) * Val(txtMetalWeight.Text)) / Val(txtMetalWeight.Text), 3)
        End If
        txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
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
        If SET_INVARCHR169TextBox.Text = "1" Then 'Rounding
            StoneWeight1 = Math.Round(StoneWeight1, 2)
            StoneWeight2 = Math.Round(StoneWeight2, 2)
            StoneWeight3 = Math.Round(StoneWeight3, 2)
        End If
        Return StoneAsGoldWeight = StoneWeight1 + StoneWeight2 + StoneWeight3
    End Function

    Private Function AsGoldStonePrice() As Decimal
        AsGoldStonePrice = 0
        If cmbStoneName1.SelectedValue = True Then
            AsGoldStonePrice += Val(txtStonePrice1.Text)
        End If
        If cmbStoneName2.SelectedValue = True Then
            AsGoldStonePrice += Val(txtStonePrice2.Text)
        End If
        If cmbStoneName3.SelectedValue = True Then
            AsGoldStonePrice += Val(txtStonePrice3.Text)
        End If

        Return Math.Round(AsGoldStonePrice, 3)
    End Function

    Private Sub GetMetalPrice()
        txtMetalPrice.Text = If(Val(txtMetalWeight.Text) = 0, "", Math.Round((Val(txtMakeCharge.Text) + Val(txtPricePerGram.Text)) * Val(txtMetalWeight.Text), 3))
        txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
    End Sub
    Private Sub GetTotalPrice()
        If Val(txtMetalPrice.Text) = 0 Then
            txtTotalPrice.Text = ""
            Exit Sub
        End If
        txtTotalPrice.Text = Val(txtMetalPrice.Text) + Val(txtStonePrice1.Text) + Val(txtStonePrice2.Text) + Val(txtStonePrice3.Text)
        txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
    End Sub
    Private Sub txtPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMetalPrice.TextChanged
        GetMakeCharge()
    End Sub
    Private Sub txtMakeCharge_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMakeCharge.TextChanged
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
    Private Sub txtWeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtMetalWeight.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        If sender.Focused = True Then
            GetMetalPrice()
            GetTotalPrice()
        Else
            GetMakeValue()
        End If

    End Sub
    Private Sub txtNumbers_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtMakeCharge.KeyPress, txtStoneWeight1.KeyPress, txtStoneWeight2.KeyPress, txtStoneWeight3.KeyPress, txtStonePrice1.KeyPress, txtStonePrice2.KeyPress, txtStonePrice3.KeyPress, txtMetalWeight.KeyPress, txtPricePerGram.KeyPress, txtMetalPrice.KeyPress, txtTotalPrice.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtQty.KeyPress
        ValidateTextbox(sender, 2, e)
    End Sub
    Private Sub txtPricePerGram_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPricePerGram.TextChanged
        If txtMetalPrice.Text = "" Then Exit Sub
        GetMetalPrice()
        StoneAsGoldPrice()
        GetTotalPrice()
    End Sub
    Private Sub txtStonePrice1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStonePrice1.TextChanged
        If sender.Focused = True Then
            If SET_INVARCHR168TextBox.Text = "1" Then ' If StoneAsGold is true
                If cmbStoneName1.SelectedValue = True Then
                    CalculatePricesAndMC()
                Else
                    GetTotalPrice()
                End If
            Else
                GetTotalPrice()
            End If
        End If
    End Sub
    Private Sub txtStonePrice2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStonePrice2.TextChanged
        If sender.Focused = True Then
            If SET_INVARCHR168TextBox.Text = "1" Then ' If StoneAsGold is true
                If cmbStoneName2.SelectedValue = True Then
                    CalculatePricesAndMC()
                Else
                    GetTotalPrice()
                End If
            Else
                GetTotalPrice()
            End If
        End If
    End Sub
    Private Sub txtStonePrice3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStonePrice3.TextChanged
        If sender.Focused = True Then
            If SET_INVARCHR168TextBox.Text = "1" Then ' If StoneAsGold is true
                If cmbStoneName3.SelectedValue = True Then
                    CalculatePricesAndMC()
                Else
                    GetTotalPrice()
                End If
            Else
                GetTotalPrice()
            End If
        End If
    End Sub
    Private Sub txtTotalPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTotalPrice.TextChanged
        If txtTotalPrice.Focused = True Then
            CalculatePricesAndMC()
        End If
    End Sub

    Private Sub cmbStoneName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbStoneName1.SelectedIndexChanged, cmbStoneName2.SelectedIndexChanged, cmbStoneName3.SelectedIndexChanged
        If sender.Focused = True Then
            CalculateTotalPrice()
        End If
    End Sub
    Private Sub CalculateTotalPrice()
        Dim TotalWeight As Double = Val(txtMetalWeight.Text)
        Dim TotalNonAsGoldPrice As Double
        If SET_INVARCHR168TextBox.Text = "1" Then
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
        Try
            txtTotalPrice.Text = Math.Round(((Val(txtMakeCharge.Text) + txtPricePerGram.Text) * TotalWeight) + Val(TotalNonAsGoldPrice), 3)
            GetMetalPrice()
            StoneAsGoldPrice()
        Catch ex As Exception
            MsgBox("اختر صنف اولا" & vbCrLf & "Select the Ttem first..", , AppTitle)
            cmbItem.DroppedDown = True
        End Try

    End Sub
    Private Sub CalculatePricesAndMC()
        Dim TotalWeight As Double = Val(txtMetalWeight.Text)
        Dim TotalNonAsGoldPrice As Double
        If SET_INVARCHR168TextBox.Text = "1" Then
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

        txtMakeCharge.Text = Math.Round(((Val(txtTotalPrice.Text) - TotalNonAsGoldPrice) / TotalWeight) - Val(txtPricePerGram.Text), 3)
        GetMetalPrice()
        StoneAsGoldPrice()
        txtTaxTextAm.Text = Val(txtTotalPrice.Text.Trim) * Val(txtTaxAmo.Text.Trim)
    End Sub

    Private Sub txtStoneWeight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStoneWeight1.TextChanged, txtStoneWeight2.TextChanged, txtStoneWeight3.TextChanged
        If sender.Focused = True Then
            'CalculatePricesAndMC()
            CalculateTotalPrice()
        End If
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItem.SelectedIndexChanged
        If cmbItem.SelectedIndex = -1 OrElse cmbItem.ValueMember = "" Then
            Exit Sub
        End If
        If cmbItem.Focused = True Then
            txtBarCode.Text = cmbItem.SelectedValue
        End If
    End Sub
    Private Sub cmbItem_MouseWheelChanged(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmbItem.MouseWheel
        Dim HMEA As HandledMouseEventArgs = DirectCast(e, HandledMouseEventArgs)
        If cmbItem.Focused = False Then
            HMEA.Handled = True
        End If

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
        CalculateTotalGridPriceTax()
    End Sub
    Private Sub DiscountCalculatePricesAndMC(ByVal RowNo As Integer, ByVal MetalWeight As Decimal, ByVal StoneWeight1 As Decimal, ByVal StonePrice1 As Decimal, ByVal StonePriceType1 As Integer, ByVal StoneWeight2 As Decimal, ByVal StonePrice2 As Decimal, ByVal StonePriceType2 As Integer, ByVal StoneWeight3 As Decimal, ByVal StonePrice3 As Decimal, ByVal StonePriceType3 As Integer, ByVal TotalPrice As Decimal, ByVal PricePerGram As Decimal)
        Dim TotalWeight As Double = MetalWeight
        Dim TotalNonAsGoldPrice As Double
        Dim MakeCharge As Decimal
        Dim DiscountMetalPrice As Decimal
        If SET_INVARCHR168TextBox.Text = "1" Then
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
        If SET_INVARCHR168TextBox.Text = "1" Then 'If StoneAsGold is Enabled
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
    End Sub
    Private Sub btnItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemName.Click
        GoldOrSilver = True
        GoldAddItemDetails.ShowDialog()
    End Sub
    Private Sub txtBarCode_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtBarCode.MouseClick
        txtBarCode.SelectAll()
    End Sub


    Private Sub txtBarCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarCode.KeyPress
        txtBarCode.Select()
    End Sub



    Private Sub txtKarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKarat.TextChanged
        GetPricePerGram()
    End Sub

    Private Sub Ctrl_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalPrice.KeyUp, txtQty.KeyUp, txtPricePerGram.KeyUp, txtMetalWeight.KeyUp, txtMetalPrice.KeyUp, txtMakeCharge.KeyUp, txtKarat.KeyUp, txtItemNmeInInvoce.KeyUp, cmbCashier.KeyUp
        If e.KeyCode = Keys.Enter = True Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub btnSave_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnSave.KeyUp

    End Sub

    Private Sub btnSave_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Enter

    End Sub

    Private Sub txtTotalPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotalPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
            cmbCashier.Focus()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Public Sub TaxSet()
        On Error Resume Next
        BtnTax.Text = "الضريبه غير  مفعله"
        BtnTax.BackColor = Color.Black
        BtnTax.ForeColor = Color.Lime
        txtTaxAmo.Text = 0
        lblPr.Enabled = False
        'txtTaxAmo.Enabled = False
        lblTaxAm.Enabled = False
        txtTaxTextAm.Enabled = False

        If DTtTax.Rows.Count > -1 Then
            If DTtTax.Rows(0)("TaxActiv").ToString = "1" Then
                BtnTax.Text = "الضريبه مفعله"
                txtTaxAmo.Text = DTtTax.Rows(0)("TaxType").ToString
                BtnTax.BackColor = Color.Lime
                BtnTax.ForeColor = Color.Black
                lblPr.Enabled = True
                txtTaxAmo.Enabled = True
                lblTaxAm.Enabled = True
                txtTaxTextAm.Enabled = True
            ElseIf DTtTax.Rows(0)("TaxActiv").ToString = "0" Then
                BtnTax.Text = "الضريبه غير  مفعله"
                BtnTax.BackColor = Color.Black
                BtnTax.ForeColor = Color.Lime
                txtTaxAmo.Text = 0
                lblPr.Enabled = False
                'txtTaxAmo.Enabled = False
                lblTaxAm.Enabled = False
                txtTaxTextAm.Enabled = False
            End If
        End If
    End Sub

    Private Sub BtnTax_Click(sender As Object, e As EventArgs) Handles BtnTax.Click
        If DTtTax.Rows(0)("TaxActiv").ToString = "1" Then
            GlCommand.CommandText = "Update [TPTax]  Set [TaxType] = " & txtTaxAmo.Text.Trim & " ,[TaxActiv] = '0'"
            GlCommand.ExecuteNonQuery()
            MsgBox("تم الغاء الضريبه" & vbCrLf & "The Tax Has Been Cancelled.", , AppTitle)
            BtnTax.Text = "الضريبه غير  مفعله"
            BtnTax.BackColor = Color.Black
            BtnTax.ForeColor = Color.Lime
            txtTaxAmo.Text = 0
            lblPr.Enabled = False
            'txtTaxAmo.Enabled = False
            lblTaxAm.Enabled = False
            txtTaxTextAm.Enabled = False

        ElseIf DTtTax.Rows(0)("TaxActiv").ToString = "0" Then
            If txtTaxAmo.Text = 0 Then
                MsgBox("ادخل نسبة الضريبه")
                txtTaxAmo.Select()
                Exit Sub
            Else
                GlCommand.CommandText = "Update [TPTax]  Set [TaxType] = " & txtTaxAmo.Text.Trim & " ,[TaxActiv] = '1'"
                GlCommand.ExecuteNonQuery()
                MsgBox("تم تفعيل الضريبه" & vbCrLf & "The Tax Has Been Activated.", , AppTitle)
                BtnTax.Text = "الضريبه مفعله"
                BtnTax.BackColor = Color.Lime
                BtnTax.ForeColor = Color.Black
                lblPr.Enabled = True
                lblTaxAm.Enabled = True
                txtTaxTextAm.Enabled = True
            End If

        End If
    End Sub

    Private Sub txtTaxAmo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxAmo.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub txtTaxAmo_TextChanged(sender As Object, e As EventArgs) Handles txtTaxAmo.TextChanged
        txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
    End Sub

    Private Sub txtTotalPriceValue_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPriceValue.TextChanged

    End Sub

    Private Sub txtTaxTextAm_TextChanged(sender As Object, e As EventArgs) Handles txtTaxTextAm.TextChanged

    End Sub

    Private Sub txtTpriceTtax_TextChanged(sender As Object, e As EventArgs) Handles txtTpriceTtax.TextChanged

    End Sub

    Private Function CalculateTotalGridPurchasePrice() As Decimal
        CalculateTotalGridPurchasePrice = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            CalculateTotalGridPurchasePrice += DataGridView1.Rows(i).Cells("colTotalPrice").Value
        Next
        Return Math.Round(CalculateTotalGridPurchasePrice, 3)
    End Function
    Private Sub BtnAddPur_Click(sender As Object, e As EventArgs) Handles BtnAddPur.Click
        If String.IsNullOrWhiteSpace(cmbKarat.Text) OrElse Val(cmbKarat.Text) = 0 Then
            MsgBox("أدخل العيار" & vbCrLf & "Enter Karat", , AppTitle)
            cmbKarat.SelectAll()
            cmbKarat.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtWeight.Text) OrElse Val(txtWeight.Text) = 0 Then
            MsgBox("أدخل الوزن" & vbCrLf & "Enter Weight", , AppTitle)
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtQunt.Text) OrElse Val(txtQunt.Text) = 0 Then
            MsgBox("أدخل العدد" & vbCrLf & "Enter Quantity", , AppTitle)
            txtQunt.SelectAll()
            txtQunt.Focus()
            Exit Sub
        End If
        If txtGramPrice.Text = "" Then
            MsgBox("أدخل سعر الجرام" & vbCrLf & "Enter Gram Price", , AppTitle)
            txtGramPrice.SelectAll()
            txtGramPrice.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtPrice.Text) OrElse Val(txtPrice.Text) = 0 Then
            MsgBox("لايمكن ترك قيمة إجمالي المبلغ فارغة" & vbCrLf & "Total Price Can't be empty", , AppTitle)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        If CivilIDForm.txtCID.Text.Trim = "" OrElse IsNumeric(CivilIDForm.txtCID.Text.Trim) = False Then
            MsgBox("أدخل الرقم المدني للعميل أولا" & vbCrLf & "Add Customer Details First.", , AppTitle)
            CivilIDForm.txtCID.SelectAll()
            CivilIDForm.txtCID.Focus()
            Exit Sub
        End If
        'If Val(txtPrice.Text) > Val(txtGramPrice.Text) * Val(txtWeight.Text) Then
        '    If MsgBox("سعر شراء الجرام أكبر من سعر الجرام الحالي، هل تريد الشراء؟" & vbCrLf & "Purchase Price per Gram is More than Gram Price..Proceed with Purchase?", vbYesNo, AppTitle) = vbNo Then
        '        Exit Sub
        '    End If
        'End If
        Dim totalPrice As Decimal
        Dim gramPrice As Decimal
        Dim weight As Decimal
        If Not Decimal.TryParse(txtPrice.Text, totalPrice) Then totalPrice = 0
        If Not Decimal.TryParse(txtGramPrice.Text, gramPrice) Then gramPrice = 0
        If Not Decimal.TryParse(txtWeight.Text, weight) Then weight = 0
        ' مقارنة دقيقة
        If totalPrice > (gramPrice * weight) AndAlso gramPrice > 0 AndAlso weight > 0 Then
            Dim msg As String =
        "سعر شراء الجرام أكبر من السعر الحالي." & vbCrLf &
        "هل تريد المتابعة في الشراء؟" & vbCrLf & vbCrLf &
        "Purchase Price per Gram is greater than the current Gram Price." & vbCrLf &
        "Proceed with purchase?"
            If MessageBox.Show(msg, AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If

        Try
            With (DataGridView1)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colcastomer_id").Value = CivilIDForm.txtCID.Text.Trim()
                .Rows(.Rows.Count - 1).Cells("colbay_mazan").Value = Val(txtWeight.Text)
                .Rows(.Rows.Count - 1).Cells("colbay_gram_price").Value = Val(txtGramPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colbay_val").Value = Val(cmbKarat.Text)
                .Rows(.Rows.Count - 1).Cells("colTotalPrice").Value = Val(txtPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colItem_Des").Value = TeBoxItem_Des.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colGoldCaret999").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim), "999", Val(ComBxGoCaret999.Text.Trim))
                .Rows(.Rows.Count - 1).Cells("colGoldWeight999").Value = If(IsDBNull(TXTGoCaret999.Text.Trim), "0", Val(TXTGoCaret999.Text.Trim))
                .Rows(.Rows.Count - 1).Cells("colQunt").Value = If(IsDBNull(txtQunt.Text.Trim), "1", Val(txtQunt.Text.Trim))
                .Rows(.Rows.Count - 1).Cells("colItem_Des").Value = TeBoxItem_Des.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colQunt").Value = txtQunt.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colAddToItem").Value = 0
                .Rows(.Rows.Count - 1).Cells("colCashier").Value = cmbCashier.SelectedValue
            End With
            CalculateTotalGridPurchasePrice()
            txtlblGoldPurPrice.Text = CalculateTotalGridPurchasePrice()
            txtWeight.Text = ""
            txtGramPrice.Text = ""
            txtQunt.Text = 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnGoldCh_Click(sender As Object, e As EventArgs) Handles btnGoldCh.Click
        If Me.Size = New Size(989, 642) Then
            Me.Size = New Size(989, 688)
        ElseIf Me.Size = New Size(989, 688) Then
            Me.Size = New Size(989, 642)
        End If








        Dim ComBx999 As DataTable = GetRecordSet("SELECT FractionValues FROM Gram_val WHERE FractionValues IS NOT NULL AND LTRIM(RTRIM(FractionValues)) <>'' GROUP BY FractionValues  ORDER BY FractionValues DESC")
        If ComBx999.Rows.Count > 0 Then
            ComBxGoCaret999.DataSource = ComBx999
            ComBxGoCaret999.DisplayMember = "FractionValues"
        End If
        Dim TeBoxItemDes As DataTable = GetRecordSet("SELECT Item_Des FROM dbo.Buy_Gold GROUP BY Item_Des")
        If TeBoxItemDes.Rows.Count > 0 Then
            TeBoxItem_Des.DataSource = TeBoxItemDes
            TeBoxItem_Des.DisplayMember = "Item_Des"
        End If
        'FrmGoldExchange.ShowDialog()
    End Sub
    Private Sub CalculateGramPrice()
        Dim weightText As String = txtWeight.Text.Trim()
        Dim priceText As String = txtPrice.Text.Trim()
        Dim weight As Decimal
        Dim price As Decimal
        If Not Decimal.TryParse(weightText, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, weight) OrElse weight <= 0D Then
            MessageBox.Show("يرجى إدخال وزن صحيح." & vbCrLf & "Please enter a valid weight.",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If
        If Not Decimal.TryParse(priceText, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, price) OrElse price <= 0D Then
            MessageBox.Show("يرجى إدخال سعر صحيح." & vbCrLf & "Please enter a valid price.",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        Dim gramPrice As Decimal = Math.Round(price / weight, 3, MidpointRounding.AwayFromZero)
        txtGramPrice.Text = gramPrice.ToString("N3", Globalization.CultureInfo.InvariantCulture)
    End Sub
    Private Sub GoldWeight()
        Dim karatText As String = If(cmbKarat.Text, "").Trim()
        Dim weightText As String = If(txtWeight.Text, "").Trim()
        Dim denomText As String = If(ComBxGoCaret999.Text, "").Trim()
        karatText = karatText.Replace("K", "").Replace("k", "")
        Dim karat As Decimal
        Dim weight As Decimal
        Dim denom As Decimal
        If Not Decimal.TryParse(karatText, NumberStyles.Any, CultureInfo.InvariantCulture, karat) OrElse karat <= 0D Then
            TXTGoCaret999.Text = "0.000" : Exit Sub
        End If
        weightText = weightText.Replace(",", "").Replace("،", "")
        denomText = denomText.Replace(",", "").Replace("،", "")
        If Not Decimal.TryParse(weightText, NumberStyles.Any, CultureInfo.InvariantCulture, weight) OrElse weight <= 0D Then
            TXTGoCaret999.Text = "0.000" : Exit Sub
        End If
        If Not Decimal.TryParse(denomText, NumberStyles.Any, CultureInfo.InvariantCulture, denom) OrElse denom = 0D Then
            TXTGoCaret999.Text = "0.000" : Exit Sub
        End If
        Dim goledCart As Decimal = (karat / 24D) * 1000D
        Dim factor As Decimal = goledCart / denom
        Dim result As Decimal = weight * factor
        TXTGoCaret999.Text = result.ToString("N3", CultureInfo.InvariantCulture)
    End Sub
    Private Sub WeightCalculateTotalPrice()

        Dim weightText As String = Val(txtWeight.Text.Trim())
        Dim gramPriceText As String = Val(txtGramPrice.Text.Trim())
        Dim weight As Decimal
        Dim gramPrice As Decimal
        If Not Decimal.TryParse(weightText, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, weight) OrElse weight <= 0D Then
            MessageBox.Show("يرجى إدخال وزن صحيح." & vbCrLf & "Please enter a valid weight.",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If
        If Not Decimal.TryParse(gramPriceText, Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, gramPrice) OrElse gramPrice <= 0D Then
            MessageBox.Show("يرجى إدخال سعر جرام صحيح." & vbCrLf & "Please enter a valid gram price.",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGramPrice.SelectAll()
            txtGramPrice.Focus()
            Exit Sub
        End If

        Dim totalPrice As Decimal = Math.Round(Val(weight) * Val(gramPrice), 3)
        txtPrice.Text = Math.Round(Val(txtWeight.Text) * Val(txtGramPrice.Text), 3)
    End Sub
    Private Sub Bay_gram_priceLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Bay_gram_priceLabel.LinkClicked
        CalculateGramPrice()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WeightCalculateTotalPrice()
    End Sub
    Private Sub GetPricePerGramForBay()
        If cmbKarat.Text.Trim = "24" Then
            txtGramPrice.Text = frmMain.lbl24BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "22" Then
            txtGramPrice.Text = frmMain.lbl22BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "21" Then
            txtGramPrice.Text = frmMain.lbl21BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "18" Then
            txtGramPrice.Text = frmMain.lbl18BUY.Text.Trim
        End If
    End Sub
    Private Sub cmbKarat_TextChanged(sender As Object, e As EventArgs) Handles cmbKarat.TextChanged
        GetPricePerGramForBay()
    End Sub
    Private Sub txtWeight_TextChanged_1(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        GoldWeight()
        GetPricePerGramForBay()
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged
        GoldWeight()
    End Sub
End Class