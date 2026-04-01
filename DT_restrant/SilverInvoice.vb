Imports System.IO
Imports PACICardLibrary


Public Class SilverInvoice
    Dim paci As PACMAN
    Public saryil As Integer
    Private InvoiceNo As String
    Public Notes As String
    Dim dtItemData As DataTable
    Public DataGetFromSet As DataTable = GetRecordSet("SELECT * from Settings")
    Dim GetMakChar As Decimal
    Dim DTtTax As DataTable = GetRecordSet("SELECT *  FROM [TPTax]")
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
                txtNotes.Text = ""
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
                txtNotes.Text = ""
                txtItemNmeInInvoce.Text = ""
            End If
                'txtNotes.Text = ""
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
    Public Sub GoldInvoiceLoad()
        language_start(Name)
        If SET_INVARCHR151TextBox.Text <> "1" Then
            Dim dt1 As DataTable = GetRecordSet("SELECT FO_name, BarCode FROM  SilverItem GROUP BY FO_name, BarCode, ID HAVING (SUM(Item_Actv) = 1) ORDER BY ID")
            cmbItem.DataBindings.Clear()
            cmbItem.DataSource = dt1
            cmbItem.DisplayMember = "FO_Name"
            cmbItem.ValueMember = "BarCode"
        Else
            Dim dt1 As DataTable = GetRecordSet("SELECT SilverItem.FO_name,SilverItem.BarCode" & vbCrLf &
                                                "FROM SilverItem LEFT OUTER JOIN" & vbCrLf &
                                                "SilverInvoceDetels ON SilverItem.BarCode = SilverInvoceDetels.ItemID" & vbCrLf &
                                                "WHERE (SilverInvoceDetels.ItemID IS NULL) OR" & vbCrLf &
                                                "(SilverInvoceDetels.Active = 0)" & vbCrLf &
                                                "GROUP BY SilverItem.FO_name, SilverItem.BarCode, SilverItem.ID" & vbCrLf &
                                                "HAVING(SUM(SilverItem.Item_Actv) = 1)" & vbCrLf &
                                                "ORDER BY SilverItem.ID")
            cmbItem.DataBindings.Clear()
            cmbItem.DataSource = dt1
            cmbItem.DisplayMember = "FO_Name"
            cmbItem.ValueMember = "BarCode"
        End If
    End Sub
    Public Sub AddNewItemInDataGred()
        'منع تكرار بيع القطعه
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'ذهب

        If DataGetFromSet.Rows.Count > 0 Then
            If DataGetFromSet.Rows(0)("SET_INVARCHR151").ToString = "1" Then
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
        Dim GetItemActvDB As DataTable = GetRecordSet("SELECT BarCode, SUM(Item_Actv) AS Item_Actv FROM SilverItem GROUP BY BarCode HAVING (BarCode = N'" & txtBarCode.Text.Trim & "')")
        If GetItemActvDB.Rows.Count > 0 Then
            Dim GetItemActv As Integer = GetItemActvDB.Rows(0)("Item_Actv").ToString
            If GetItemActv = 0 Then
                MsgBox("لقد تم حزف الصنف مسبقا من قائمة الاصناف" & vbCrLf & "The item has been removed from the list of items entered", , "خطأ")
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
        If Val(txtTotalPrice.Text) <= 0 Then
            MsgBox("أدخل السعر" & vbCrLf & "Please Enter Price", , "خطأ")
            txtTotalPrice.Focus()
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
                .Rows(.Rows.Count - 1).Cells("colSroomName").Value = Comp_note1TextBox.Text.Trim
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
            Dim DT As DataTable = GetRecordSet("SELECT  ItemID, SUM(Active) AS Active FROM SilverInvoceDetels GROUP BY ItemID  HAVING  [ItemID] = N'" & txtBarCode.Text.Trim & "'")
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
        Dim GetItemActvDB As DataTable = GetRecordSet("SELECT BarCode, SUM(Item_Actv) AS Item_Actv FROM SilverItem GROUP BY BarCode HAVING (BarCode = N'" & txtBarCode.Text.Trim & "')")
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
        If Saved = False Then
            Do While grid.Rows.Count <> 0 

            Loop
        End If
        Saved = False
        sc.Dispose()
        Dispose()
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
    Public Sub GetSILVERtemName()
        Dim DtGoldItemName As DataTable = GetRecordSet("select FO_name,BarCode from SilverItem WHERE (Item_Actv = 1)")
        If DtGoldItemName.Rows.Count > 0 Then
            cmbItem.DataSource = DtGoldItemName
            cmbItem.DisplayMember = "FO_name"
            cmbItem.ValueMember = "BarCode"
        End If
        cmbItem.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="FO_name", ComboBoxName:=cmbItem)
    End Sub
    Public Sub TaxSet()
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
    Private Sub SilverInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
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
        GetStoneName1()
        GetStoneName2()
        GetStoneName3()
        Visible = False
        GetCashier(cmbCashier:=cmbCashier)
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
        GetSILVERtemName()
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
        End If
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
        'InvoiceNo = InvoiceStringNo(Val(Saryal_maxTextBox.Text) + 1)
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
            SilverInvoicePay.ReportViewer1.BackColor = Color.Gainsboro
            SilverInvoicePay.InvoiceTime = Invoc_timeTextBox.Text
            SilverInvoicePay.ShowDialog()
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
    Private Sub txtTotalPriceValue_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub txtTotalPriceValue_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            UpdateGridAfterDiscount()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub txtTotalPriceValue_Leave(ByVal sender As Object, ByVal e As EventArgs)
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
        'If TrueFalse = False Then
        TrueFalse = True
        GoldOrSilver = False
        GoldAddItemDetails.ShowDialog()

        'End If
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

    Private Sub txtTaxAmo_TextChanged(sender As Object, e As EventArgs) Handles txtTaxAmo.TextChanged
        txtTaxTextAm.Text = Math.Round(Val(txtTotalPrice.Text) * Val(txtTaxAmo.Text) / 100, 3)
    End Sub

    Private Sub txtTaxAmo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTaxAmo.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
End Class