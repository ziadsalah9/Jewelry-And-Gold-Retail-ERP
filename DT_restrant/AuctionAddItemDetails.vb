Imports PACICardLibrary

Public Class AuctionAddItemDetails
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

    Private Sub AuctionAddItemDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub AuctionAddItemDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        '''''''''''''''''''''''''''''''''''''''''''''''' البطاقه المدنيه
        CivilIDForm = New CivilID With {.Bounds = New Rectangle(0, 55, 995, 275)}
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        CacherTableAdapter.Fill(DT_restrantDataSet.cacher)
        Auction_ItemStatusTableAdapter.Fill(DT_restrantDataSet.Auction_ItemStatus)
        Auction_GuaranteeStatusTableAdapter.Fill(DT_restrantDataSet.Auction_GuaranteeStatus)
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
        AuctionAddItemDetailsTableAdapter.Fill(DT_restrantDataSet.Auction_AddItemDetails)
        AuctionAddItemDetailsVwTableAdapter.Fill(DT_restrantDataSet.AuctionAddItemDetailsVw)
        dtGuaranteeDate.Text = Now.Year
        dtReceiveDate.Value = Now

        btnNew.Enabled = True
        btnSave.Enabled = False

        gbItemData.Enabled = False
        cmbAuction_Type.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_ItemType, "Auction_Type", cmbAuction_Type)
        cmbBrand_Name.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_Brand, "Brand_Name", cmbBrand_Name)
        cmbItemStatus.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_ItemStatus, "ItemStatus_Name", cmbItemStatus)
        cmbGuaranteeStatus.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Auction_GuaranteeStatus, "GuaranteeStatus", cmbGuaranteeStatus)

        grid.ClearSelection()
        CivilIDForm.Enabled = False
        min_Items.Hide()
        ReportViewer1.RefreshReport()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
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

        If cmbGuaranteeStatus.SelectedIndex = 1 AndAlso dtGuaranteeDate.Text.Trim = "" Then
            MsgBox("يرجى تحديد تاريخ الضمان" & vbCrLf & "Please Type Guarantee Date.", , AppTitle)
            dtGuaranteeDate.Focus()
            Exit Sub
        End If
        If txtPrice.Text.Trim = "" Then
            MsgBox("يرجى إدخال السعر" & vbCrLf & "Please Enter Price", , AppTitle)
            txtPrice.Focus()
            Exit Sub
        End If

        If cmbCashier.SelectedIndex = -1 Then cmbCashier.SelectedIndex = 0

        Try
            If cmbGuaranteeStatus.SelectedIndex = -1 Then
                cmbGuaranteeStatus.SelectedIndex = 0
            End If
            txtAuction_IDDB.Text = grid.SelectedRows(0).Cells("Auction_ID").Value
            txtAuction_TypeDB.Text = cmbAuction_Type.Text
            txtBrand_NameDB.Text = cmbBrand_Name.Text
            txtModelDB.Text = txtModel.Text
            txtSerialNoDB.Text = If(txtSerialNo.Text.Trim = "", "-", txtSerialNo.Text)
            txtItemStatusDB.Text = cmbItemStatus.Text
            dtReceiveDateDB.Value = dtReceiveDate.Value
            txtGuaranteeStatusDB.Text = cmbGuaranteeStatus.SelectedValue
            txtGuaranteeDateDB.Text = If(cmbGuaranteeStatus.SelectedIndex = 0, "", dtGuaranteeDate.Text)
            txtGuaranteeStatusDB.Text = cmbGuaranteeStatus.Text
            txtItemDetailsDB.Text = If(txtItemDetails.Text.Trim = "", "-", txtItemDetails.Text)
            txtPriceDB.Text = txtPrice.Text
            pbImageDB.Image = pbImage.Image
            CastomerIDTextBox.Text = CivilIDForm.txtCID.Text
            CacherIDTextBox.Text = cmbCashier.SelectedValue
            Validate()
            AuctionAddItemDetailsBindingSource.EndEdit()
            AuctionAddItemDetailsTableAdapter.Update(DT_restrantDataSet.Auction_AddItemDetails)
            NewData()
            NewItem = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AddNewItem()
        ClearData()
        btnSave.Enabled = True
        btnNew.Enabled = False
        gbItemData.Enabled = True
        btnEdit.Enabled = False
        CivilIDForm.Enabled = True
        CivilIDForm.txtCID.Focus()
    End Sub

    Private Sub btnGramPrice_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        AuctionBrand.ShowDialog()
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
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
        btnNew.Enabled = True
        btnEdit.Enabled = True
        CivilIDForm.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        gbItemData.Enabled = True
        btnSave.Enabled = True
        btnNew.Enabled = False
        CivilIDForm.Enabled = True
    End Sub

    Private Sub btnItemStatus_Click(sender As Object, e As EventArgs) Handles btnItemStatus.Click
        AuctionItemStatus.ShowDialog()
        Auction_ItemStatusTableAdapter.Fill(DT_restrantDataSet.Auction_ItemStatus)
    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.SelectedRows.Count = 0 Then
            ClearData()
            CivilIDForm.txtCID.Text = ""
            Exit Sub
        End If

        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            SelectItem()
        End If

    End Sub
    Private Sub SelectItem()
        txtAuction_IDDB.Text = If(IsDBNull(grid.SelectedRows(0).Cells("Auction_ID").Value) = True, "", grid.SelectedRows(0).Cells("Auction_ID").Value)
        cmbAuction_Type.Text = If(IsDBNull(grid.SelectedRows(0).Cells("NameType").Value) = True, "", grid.SelectedRows(0).Cells("NameType").Value)
        cmbBrand_Name.Text = If(IsDBNull(grid.SelectedRows(0).Cells("Brand").Value) = True, "", grid.SelectedRows(0).Cells("Brand").Value)
        txtModel.Text = If(IsDBNull(grid.SelectedRows(0).Cells("Model").Value) = True, "", grid.SelectedRows(0).Cells("Model").Value)
        txtSerialNo.Text = If(IsDBNull(grid.SelectedRows(0).Cells("SerialNo").Value) = True, "", grid.SelectedRows(0).Cells("SerialNo").Value)
        cmbItemStatus.Text = If(IsDBNull(grid.SelectedRows(0).Cells("ItemNewUsed").Value) = True, "", grid.SelectedRows(0).Cells("ItemNewUsed").Value)
        dtReceiveDate.Value = If(IsDBNull(grid.SelectedRows(0).Cells("ReceiveDate").Value) = True, Now, grid.SelectedRows(0).Cells("ReceiveDate").Value)
        dtGuaranteeDate.Text = If(IsDBNull(grid.SelectedRows(0).Cells("GuaranteeDate").Value) = True, Now.Year, Strings.Left(grid.SelectedRows(0).Cells("GuaranteeDate").Value, 4))
        cmbGuaranteeStatus.Text = If(IsDBNull(grid.SelectedRows(0).Cells("GuaranteeStatus").Value) = True, "", grid.SelectedRows(0).Cells("GuaranteeStatus").Value)
        txtItemDetails.Text = If(IsDBNull(grid.SelectedRows(0).Cells("Details").Value) = True, "", grid.SelectedRows(0).Cells("Details").Value)
        txtPrice.Text = If(IsDBNull(grid.SelectedRows(0).Cells("Price").Value) = True, "", grid.SelectedRows(0).Cells("Price").Value)
        CivilIDForm.txtCID.Text = If(IsDBNull(grid.SelectedRows(0).Cells("CastomerID").Value) = True, "", grid.SelectedRows(0).Cells("CastomerID").Value)
        txtAuctionIDVw.Text = txtAuction_IDDB.Text
    End Sub
    Private Sub ClearData()
        txtAuction_IDDB.Text = ""
        cmbAuction_Type.SelectedIndex = -1
        cmbBrand_Name.SelectedIndex = -1
        txtModel.Text = ""
        txtSerialNo.Text = ""
        cmbItemStatus.SelectedIndex = -1
        dtReceiveDate.Value = Now
        dtGuaranteeDate.Text = Now.Year
        cmbGuaranteeStatus.SelectedIndex = -1
        txtItemDetails.Text = ""
        txtPrice.Text = ""

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub

    Private Sub PerformSearch()
        If txtSearch.Text = "" Then
            MsgBox("أدخل قيمة للبحث" & vbCrLf & "Please add a value To search", , Apptitle)
            Exit Sub
        End If
        AuctionAddItemDetailsBindingSource.RemoveFilter()
        Select Case cmbSearch.SelectedIndex
            Case 0 'النوع
                AuctionAddItemDetailsBindingSource.Filter = "Name Like '%" & txtSearch.Text & "%'"
            Case 1 'الماركة
                AuctionAddItemDetailsBindingSource.Filter = "Brand LIKE '%" & txtSearch.Text & "%'"
            Case 2 'الموديل
                AuctionAddItemDetailsBindingSource.Filter = "Model LIKE '%" & txtSearch.Text & "%'"
            Case 3 'السيريال
                AuctionAddItemDetailsBindingSource.Filter = "SerialNo = '" & txtSearch.Text & "'"
        End Select
        AuctionAddItemDetailsTableAdapter.Fill(DT_restrantDataSet.Auction_AddItemDetails)
    End Sub
    Private Sub AddNewItem()
        Validate()
        AuctionAddItemDetailsBindingSource.EndEdit()
        AuctionAddItemDetailsTableAdapter.Update(DT_restrantDataSet.Auction_AddItemDetails)
        AuctionAddItemDetailsBindingSource.AddNew()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs)
        AuctionAddItemDetailsBindingSource.RemoveFilter()
    End Sub

    Private Sub btnAddItemName_Click(sender As Object, e As EventArgs) Handles btnAddItemName.Click
        AuctionCategory.ShowDialog()
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Rows(e.RowIndex).Cells("Auction_ID").Value = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("Auction_ID").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("Auction_ID").Value, vbYesNo) = vbYes Then
                Try
                    AuctionAddItemDetailsBindingSource.RemoveCurrent()
                    ValidateChildren()
                    AuctionAddItemDetailsBindingSource.EndEdit()
                    AuctionAddItemDetailsTableAdapter.Update(DT_restrantDataSet)
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
    End Sub

    Private Sub cmbGuaranteeStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGuaranteeStatus.SelectedIndexChanged
        If cmbGuaranteeStatus.SelectedIndex = 0 Then
            dtGuaranteeDate.Text = ""
        End If
    End Sub


    Private Sub btnGuaranteeStatus_Click(sender As Object, e As EventArgs) Handles btnGuaranteeStatus.Click
        AuctionGuarantee.ShowDialog()
        Auction_GuaranteeStatusTableAdapter.Fill(DT_restrantDataSet.Auction_GuaranteeStatus)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If grid.SelectedRows.Count = 0 Then Exit Sub
        ReportViewer1.LocalReport.ReportPath = "report\rptAuctionReceive.rdlc"
        txtAuctionIDVw.Text = grid.SelectedRows(0).Cells("Auction_ID").Value
        AuctionAddItemDetailsVwTableAdapter.FillBy(DT_restrantDataSet.AuctionAddItemDetailsVw, txtAuctionIDVw.Text)
        ReportViewer1.RefreshReport()
        Try
            If grid.SelectedRows.Count = 1 Then
                'صنف واحد بالفاتورة
                If MsgBox("هل تريد طباعة إيصال الاستلام؟" & vbCrLf & "Do You Want to Print Receive Invoice?", vbYesNo) = vbYes Then
                    ReportViewer1.PrintDialog()
                End If
            ElseIf grid.SelectedRows.Count > 1 Then
                For i As Integer = 0 To grid.SelectedRows.Count - 1
                    If grid.SelectedRows(i).Cells("CastomerID").Value <> grid.SelectedRows(0).Cells("CastomerID").Value Then
                        MsgBox("ليتم طباعة أكثر من صنف بإيصال استلام واحد يجب تحديد نفس العميل" & vbCrLf & "To be Able to Print Multiple Items in the Same Receive Invoice You Must Select the Same Customer", , Apptitle)
                        Exit Sub
                    End If
                Next
                ReportViewer1.LocalReport.ReportPath = "report\rptAuctionReceiveMulti.rdlc"
                Dim Invoice1 As String = ""
                Dim Invoice2 As String = ""
                Dim Invoice3 As String = ""
                Dim Invoice4 As String = ""
                Dim Invoice5 As String = ""
                Dim Invoice6 As String = ""
                Dim Invoice7 As String = ""

                Invoice1 = grid.SelectedRows(0).Cells("Auction_ID").Value
                Invoice2 = grid.SelectedRows(1).Cells("Auction_ID").Value
                If grid.SelectedRows.Count = 3 Then
                    Invoice3 = grid.SelectedRows(2).Cells("Auction_ID").Value
                End If
                If grid.SelectedRows.Count = 4 Then
                    Invoice4 = grid.SelectedRows(3).Cells("Auction_ID").Value
                End If
                If grid.SelectedRows.Count = 5 Then
                    Invoice5 = grid.SelectedRows(4).Cells("Auction_ID").Value
                End If
                If grid.SelectedRows.Count = 6 Then
                    Invoice6 = grid.SelectedRows(5).Cells("Auction_ID").Value
                End If
                If grid.SelectedRows.Count = 7 Then
                    Invoice7 = grid.SelectedRows(6).Cells("Auction_ID").Value
                End If

                AuctionAddItemDetailsVwTableAdapter.FillByMulti(DT_restrantDataSet.AuctionAddItemDetailsVw, Invoice1, Invoice2, Invoice3, Invoice4, Invoice5, Invoice6, Invoice7)
                'أكثر من صنف بالفاتورة
                If MsgBox("هل تريد طباعة إيصال الاستلام؟" & vbCrLf & "Do You Want to Print Receive Invoice?", vbYesNo) = vbYes Then
                    ReportViewer1.PrintDialog()
                End If
            End If

        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , Apptitle)
        End Try

    End Sub
End Class

