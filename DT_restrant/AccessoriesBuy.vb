Imports PACICardLibrary
Public Class AccessoriesBuy
    Dim ItemName As String
    Dim ProcessingCost As String
    Dim Cost As String
    Dim Carat As String
    Dim Country As String
    Dim StoneWeight As String
    Dim Stone As String
    Dim Supplier As String
    Dim ItemWeight As String
    Dim printOk As Boolean
    Dim NewItem As Boolean = False
    Dim InvoiceNo As String = ""
    Private Sub AuctionAddItemDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = False AndAlso grid.Rows.Count > 0 Then
            SaveDataToDB("Accessories_Buy", "", "", 1, "Accessories_InvoiceNo = N'" & InvoiceNo & "'")
        End If
        Saved = False
        Dispose()
    End Sub
    Private Sub AuctionAddItemDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ControlsAsColor(ColorSelect:=Me)
        AccessoriesBuyInvoiceMaxTableAdapter.Fill(DT_restrantDataSet.AccessoriesBuyInvoiceMax)
        Accessories_CATTableAdapter.Fill(DT_restrantDataSet.Accessories_CAT)
        Accessories_DEPTableAdapter.Fill(DT_restrantDataSet.Accessories_DEP)
        Accessories_BuyTableAdapter.Fill(DT_restrantDataSet.Accessories_Buy)
        language_start(Name)

        '''''''''''''''''''''''''''''''''''''''''''''''' البطاقه المدنيه
        CivilIDForm = New CivilID With {.Bounds = New Rectangle(20, 0, 995, 255)}
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        InvoiceNo = If(IsDBNull(AccessoriesBuyInvoiceNoTextBox.Text), 0, Val(AccessoriesBuyInvoiceNoTextBox.Text)) + 1
        CacherTableAdapter.Fill(DT_restrantDataSet.cacher)
        Auction_ItemStatusTableAdapter.Fill(DT_restrantDataSet.Auction_ItemStatus)
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
        dtReceiveDate.Value = Now
        cmbAccessories_NAME.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_ItemType, "Auction_Type", cmbAccessories_NAME)
        cmbBrand_Name.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_Brand, "Brand_Name", cmbBrand_Name)
        cmbItemStatus.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_ItemStatus, "ItemStatus_Name", cmbItemStatus)
        cmbAccessories_CAT.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Accessories_CAT, "Accessories_CAT_NAME", cmbAccessories_CAT)
        grid.ClearSelection()
        min_Buy.Hide()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If

        If cmbBrand_Name.SelectedIndex = -1 Then
            MsgBox("يرجى اختيار الماركة" & vbCrLf & "Please Select Brand", , AppTitle)
            cmbBrand_Name.DroppedDown = True
            Exit Sub
        End If

        If txtModel.Text.Trim = "" Then
            MsgBox("يرجى اختيار الموديل" & vbCrLf & "Please Select Model", , AppTitle)
            txtModel.Focus()
            Exit Sub
        End If

        If cmbItemStatus.SelectedIndex = -1 Then
            MsgBox("يرجى تحديد حالة السلعة" & vbCrLf & "Please Select Item Condition.", , AppTitle)
            cmbItemStatus.DroppedDown = True
            Exit Sub
        End If

        If cmbAccessories_CAT.SelectedIndex = -1 Then
            MsgBox("يرجى تحديد الفئة" & vbCrLf & "Please Select Item Category.", , AppTitle)
            cmbAccessories_CAT.DroppedDown = True
            Exit Sub
        End If

        If cmbAccessories_DEP.SelectedIndex = -1 Then
            MsgBox("يرجى تحديد القسم" & vbCrLf & "Please Select Department.", , AppTitle)
            cmbAccessories_DEP.DroppedDown = True
            Exit Sub
        End If

        If txtPrice.Text.Trim = "" Then
            MsgBox("يرجى إدخال السعر" & vbCrLf & "Please Enter Price", , AppTitle)
            txtPrice.Focus()
            Exit Sub
        End If

        If cmbCashier.SelectedIndex = -1 Then cmbCashier.SelectedIndex = 0

        Try
            AddNewItem()
            txtAccessories_NAMEDB.Text = cmbAccessories_NAME.Text
            txtAccessories_BRANDDB.Text = cmbBrand_Name.Text
            txtModelDB.Text = txtModel.Text
            txtSerialNoDB.Text = If(txtSerialNo.Text.Trim = "", "-", txtSerialNo.Text)
            txtItemStatusDB.Text = cmbItemStatus.Text
            dtReceiveDateDB.Value = dtReceiveDate.Value
            Accessories_TIMETextBoxDB.Text = Format(Now, "HH:mm:ss")
            txtAccessories_DEPDB.Text = cmbAccessories_DEP.Text
            txtAccessories_CATDB.Text = cmbAccessories_CAT.Text
            Accessories_DESCTextBox.Text = txtNotes.Text.Trim
            txtPriceDB.Text = txtPrice.Text
            pbImageDB.Image = pbImage.Image
            Accessories_YearOfWarrTextBox.Text = TEXTYearOfWarr.Text.Trim
            Accessories_AttachmentsTextBox.Text = TEXTAttachments.Text.Trim
            ItemNoTextBox.Text = TexltemNO.Text.Trim
            CastomerIDTextBoxDB.Text = CivilIDForm.txtCID.Text
            CacherIDTextBox.Text = cmbCashier.SelectedValue
            txtInvoiceNoDB.Text = InvoiceNo
            CastomerIDTextBoxDB.Text = CivilIDForm.txtCID.Text.Trim
            ValidateChildren()
            Validate()
            Accessories_BuyBindingSource.EndEdit()
            Accessories_BuyTableAdapter.Update(DT_restrantDataSet.Accessories_Buy)
            Accessories_BuyVwTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_BuyVw, InvoiceNo)
            CivilIDForm.txtCID.Text = CID
            dtReceiveDate.Enabled = False
            ClearData()


        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
    Private Sub lblPhoto_Click(sender As Object, e As EventArgs) Handles lblPhoto.Click
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

    Sub NewData()
        gbItemData.Enabled = False
        btnSave.Enabled = False
        CivilIDForm.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs)
        gbItemData.Enabled = True
        btnSave.Enabled = True
        CivilIDForm.Enabled = True
    End Sub

    Private Sub btnItemStatus_Click(sender As Object, e As EventArgs)
        AuctionItemStatus.ShowDialog()
        Auction_ItemStatusTableAdapter.Fill(DT_restrantDataSet.Auction_ItemStatus)
    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.SelectedRows.Count = 0 Then
            'ClearData()
            CivilIDForm.txtCID.Text = ""
            Exit Sub
        End If
    End Sub
   
    Private Sub ClearData()
        
        txtAccessoriesIDDB.Text = ""
        cmbAccessories_NAME.SelectedIndex = -1
        cmbBrand_Name.SelectedIndex = -1
        txtModel.Text = ""
        txtSerialNo.Text = ""
        cmbItemStatus.SelectedIndex = -1
        dtReceiveDate.Value = Now
        cmbAccessories_CAT.SelectedIndex = -1
        txtNotes.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub AddNewItem()
        
        Validate()
        Accessories_BuyBindingSource.EndEdit()
        Accessories_BuyBindingSource.AddNew()
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Rows(e.RowIndex).Cells("colAccessoriesID").Value = -1 Then Exit Sub

        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد الحذف؟" & vbCrLf & "Do You Want to Delete Item ?", vbYesNo) = vbYes Then
                Try
                    Accessories_BuyBindingSource.RemoveCurrent()
                    ValidateChildren()
                    Accessories_BuyBindingSource.EndEdit()
                    Accessories_BuyTableAdapter.Update(DT_restrantDataSet.Accessories_Buy)
                    Accessories_BuyVwTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_BuyVw, InvoiceNo)
                    If grid.Rows.Count = 0 Then
                        dtReceiveDate.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If

    End Sub
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        If grid.Columns(e.ColumnIndex).Name = "View" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.PrinterSmall, CInt((e.CellBounds.Width / 2) - (My.Resources.PrinterSmall.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.PrinterSmall.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub cmbGuaranteeStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccessories_CAT.SelectedIndexChanged
        If cmbAccessories_CAT.SelectedIndex = 0 Then
            'dtGuaranteeDate.CustomFormat = " "
        Else
            'dtGuaranteeDate.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub btnPayPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPayPrint.Click
        Accessories_BuyBindingSource.EndEdit()
        ValidateChildren()
        Accessories_BuyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DT_restrantDataSet)
        If grid.Rows.Count > 0 Then

            AccessoriesBuyPay.txtInvoiceNo.Text = InvoiceNo
            AccessoriesBuyPay.ShowDialog()
        End If
    End Sub

    Private Sub btnItemName_Click(sender As Object, e As EventArgs) Handles btnItemName.Click
        AuctionCategory.ShowDialog()
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        AuctionBrand.ShowDialog()
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        AccessoriesCATAdd.ShowDialog()
        Accessories_CATTableAdapter.Fill(DT_restrantDataSet.Accessories_CAT)
    End Sub

    Private Sub btnDep_Click(sender As Object, e As EventArgs) Handles btnDep.Click
        AccessoriesDepAdd.ShowDialog()
        Accessories_DEPTableAdapter.Fill(DT_restrantDataSet.Accessories_DEP)
    End Sub

    Private Sub gbItemData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbItemData.Enter

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    GlCommand.CommandText = "UPDATE [Accessories_Buy] SET[Accessories_YearOfWarr] =N'" & TEXTYearOfWarr.Text.Trim & "',[Accessories_Attachments] = N'" & TEXTAttachments.Text.Trim & "'  WHERE Accessories_InvoiceNo= N'" & InvoiceNo & "'"
    '    GlCommand.ExecuteNonQuery()
    'End Sub
End Class

