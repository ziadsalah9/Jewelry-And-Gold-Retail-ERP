Imports PACICardLibrary

Public Class AuctionInvoice
    Dim paci As PACMAN

    Private Sub AuctionInvoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Saved = False
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub AuctionInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ControlsAsColor(ColorSelect:=Me)
        Auction_AddItemDetailsTableAdapter.Fill(DT_restrantDataSet.Auction_AddItemDetails)
        CacherTableAdapter.Fill(DT_restrantDataSet.cacher)
        cmbCashier.SelectedIndex = -1
        cmbCashier.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.cacher, "cacher_name", cmbCashier)
        '''''''''''''''''''''''''''''''''''''''''''''''' البطاقه المدنيه
        CivilIDForm = New CivilID With {.Bounds = New Rectangle(0, 0, 995, 250)}
        Controls.Add(CivilIDForm)
        CardServiceStart()


        CivilIDForm.txtCID.Focus()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        min_Sales.Hide()
    End Sub

    Private Sub txtBarCode_TextChanged(sender As Object, e As EventArgs) Handles txtBarCode.TextChanged
        LoadItemData()
    End Sub
    Private Sub LoadItemData()
        Try
            Auction_AddItemDetailsTableAdapter.FillBy(DT_restrantDataSet.Auction_AddItemDetails, txtBarCode.Text.Trim)
            If Auction_AddItemDetailsBindingSource.Count = 0 Then
                Exit Sub
            Else
                If GetRecordCount("[AuctionInvoiceDetails] ", " WHERE [Auction_ID] = '" & txtBarCode.Text.Trim & "'") > 0 Then
                    MsgBox("الباركود لقطعة تم بيعها بالفعل!" & vbCrLf & "This Barcode Belongs to an Already Sold Item!", , "خطأ")
                    ClearData()
                    Exit Sub
                End If
            End If
            txtAuction_Type.Text = txtAuction_TypeDB.Text
            txtBrand_Name.Text = txtBrand_NameDB.Text
            txtModel.Text = txtModelDB.Text
            txtItemStatus.Text = txtItemStatusDB.Text
            dtReceiveDate.Value = dtReceiveDateDB.Value
            dtGuaranteeDate.Text = Replace(GuaranteeDatetxtDB.Text, "-", "/")
            txtGuaranteeStatus.Text = txtGuaranteeStatusDB.Text
            txtItemDetails.Text = txtItemDetailsDB.Text
            txtSerialNo.Text = txtSerialNoDB.Text
            txtTotalPrice.SelectAll()
            txtTotalPrice.Focus()
        Catch ex As Exception
            ClearData()
            txtBarCode.Select()
        End Try
    End Sub

    Private Sub ClearData()
        txtAuction_Type.Text = ""
        txtBrand_Name.Text = ""
        txtModel.Text = ""
        txtItemStatus.Text = ""
        dtReceiveDate.Value = Now
        dtGuaranteeDate.Text = ""
        txtGuaranteeStatus.Text = ""
        txtItemDetails.Text = ""
        txtSerialNo.Text = ""
    End Sub

    Private Sub btnPayPrint_Click(sender As Object, e As EventArgs) Handles btnPayPrint.Click
        If IsNumeric(CivilIDForm.txtCID.Text.Trim) = False OrElse CivilIDForm.txtCID.Text.Trim = "" Then
            MsgBox("أدخل الرقم المدني" & vbCrLf & "Please Enter Civi ID", , "خطأ")
            CivilIDForm.txtCID.Focus()
            CivilIDForm.txtCID.SelectAll()
            Exit Sub
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

        If Val(txtTotalPrice.Text) = 0 Then
            MsgBox("أدخل السعر" & vbCrLf & "Please Enter Price", , "خطأ")
            txtTotalPrice.Focus()
            txtTotalPrice.SelectAll()
            Exit Sub
        End If
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 OrElse Val(txtLink.Text) < 0 OrElse Val(txtCheque.Text) < 0 Then
            MsgBox("لا يمكن أن يكون السعر سالبًا" & vbCrLf & "Price Can't Be Negative!", , "خطأ")
            Exit Sub
        End If

        If Val(txtCash.Text) + Val(txtKnet.Text) + Val(txtLink.Text) + Val(txtCheque.Text) <> Val(txtTotalPrice.Text) Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت والرابط والشيك" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET And Link And Cheque", , "خطأ")
            Exit Sub
        End If

        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        End If

        If txtCash.Text.Trim = "" Then txtCash.Text = "0"
        If txtKnet.Text.Trim = "" Then txtKnet.Text = "0"
        If txtLink.Text.Trim = "" Then txtLink.Text = "0"
        If txtCheque.Text.Trim = "" Then txtCheque.Text = "0"

        Try
            AddItemData()
            AuctionInvoiceDetailsBindingSource.EndEdit()
            AuctionInvoiceDetailsTableAdapter.Update(DT_restrantDataSet.AuctionInvoiceDetails)
            lblInvoiceValue.Text = IDTextBox.Text
            Report()
        Catch ex As Exception
            MsgBox("خطأ بعض الحقول المهمة فارغة" & vbCrLf & "Error in Data Entry..", , Apptitle)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub AddItemData()
        Try
            AuctionInvoiceDetailsBindingSource.AddNew()
            CacherTextBox.Text = cmbCashier.SelectedValue
            CastomeridTextBox.Text = CivilIDForm.txtCID.Text.Trim
            Auction_IDTextBox.Text = txtBarCode.Text.Trim
            UserIDTextBox.Text = UserName
            NameTextBox.Text = txtAuction_Type.Text
            BrandTextBox.Text = txtBrand_Name.Text
            ModelTextBox.Text = txtModel.Text
            SerialNoTextBox.Text = txtSerialNo.Text
            ItemNewUsedTextBox.Text = txtItemStatus.Text
            ReceiveDateDateTimePicker.Value = dtReceiveDate.Value
            GuaranteeDateTextBox.Text = If(dtGuaranteeDate.Text = "", "", Replace(dtGuaranteeDate.Text, "/", "-"))
            GuaranteeStatusTextBox.Text = txtGuaranteeStatus.Text
            DetailsTextBox.Text = If(txtItemDetails.Text.Trim = "", "-", txtItemDetails.Text)
            NotesTextBox.Text = txtNotes.Text
            SellDateDateTimePicker.Value = CDate(dtSellDate.Value)
            Invoic_date_timeTextBox.Text = Format(Date.Now, "dd/MM/yyyy hh:mm:ss tt")
            QuantityTextBox.Text = 1
            Sroom_nameTextBox.Text = frmMain.lblCompanyName.Text
            Invoic_NoTextBox.Text = AuctionInvoiceDetailsBindingSource.Count
            lblInvoiceValue.Text = Invoic_NoTextBox.Text
            TotalPriceTextBox.Text = txtTotalPrice.Text
            TotalPriceTextBoxAr.Text = kokotxt(Val(txtTotalPrice.Text), CurrencyMainAr, CurrencySubAr, True)
            CashTextBox.Text = Val(txtCash.Text)
            K_netTextBox.Text = Val(txtKnet.Text)
            LinkTextBox.Text = Val(txtLink.Text)
            ChequeTextBox.Text = Val(txtCheque.Text)
            Validate()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Report()
        AuctionInvoiceDetailsVwTableAdapter.FillBy(DT_restrantDataSet.AuctionInvoiceDetailsVw, lblInvoiceValue.Text)
        ReportViewer1.RefreshReport()
        If MsgBox("هل تريد طباعة الفاتورة؟" & vbCrLf & "Do You Want to Print The Invoice?", vbYesNo) = vbYes Then
            ReportViewer1.PrintDialog()
        End If
    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress, txtKnet.KeyPress, txtTotalPrice.KeyPress, txtLink.KeyPress, txtCheque.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub

    Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
        txtCash.Text = ""
        txtKnet.Text = ""
        txtLink.Text = ""
        txtCheque.Text = ""
    End Sub
End Class