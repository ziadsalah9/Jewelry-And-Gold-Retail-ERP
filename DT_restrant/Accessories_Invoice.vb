Imports PACICardLibrary
Public Class Accessories_Invoice
    Private Sub GetItemDetels()
        Dim GetDetels As DataTable = GetRecordSet("select * from Accessories_ITEM WHERE AccessoriesID='" & cmbItemName.SelectedValue & "'")
        If GetDetels.Rows.Count > 0 Then
            cmbItemName.SelectedText = GetDetels.Rows(0)("Accessories_NAME")
            cmbBrand.Text = GetDetels.Rows(0)("Accessories_BRAND")
            txtModelNo.Text = GetDetels.Rows(0)("Accessories_model_no")
            txtItemNo.Text = GetDetels.Rows(0)("Accessories_nom")
            txtCode.Text = GetDetels.Rows(0)("Accessories_Code")
            txtSupplier.Text = GetDetels.Rows(0)("Accessories_Supplier")
            txtDescription.Text = GetDetels.Rows(0)("Accessories_DESC")
            cmbCategory.Text = GetDetels.Rows(0)("Accessories_CAT")
            cmbDepartment.Text = GetDetels.Rows(0)("Accessories_DEP")
            txtYear.Text = GetDetels.Rows(0)("Accessories_Year")
            txtCost.Text = GetDetels.Rows(0)("Accessories_Cost")
            txtQty.Text = ""
            txtAttachment.Text = GetDetels.Rows(0)("Accessories_Attachments")
            txtPrice.Text = GetDetels.Rows(0)("Accessories_Price")
        End If
    End Sub
    Private Sub LodData()

        GetFillComboBox(ComboBoxName:=cmbBrand, DisMem:="Brand_Name", SqlCom:="select * from Auction_Brand", ValMem:="Brand_ID")

        GetFillComboBox(ComboBoxName:=cmbDepartment, DisMem:="Accessories_DEP_NAME", SqlCom:="select * from Accessories_DEP", ValMem:="Accessories_DEP_ID")

        GetFillComboBox(ComboBoxName:=cmbCategory, DisMem:="Accessories_CAT_NAME", SqlCom:="select * from Accessories_CAT", ValMem:="Accessories_CAT_ID")

        GetFillComboBox(ComboBoxName:=cmbCashier, DisMem:="cacher_name", SqlCom:="select * from cacher", ValMem:="svil_id")

        Dim DT As DataTable = GetRecordSet("select * from Accessories_ITEM")
        If DT.Rows.Count > 0 Then
            cmbItemName.DataSource = DT
            cmbItemName.DisplayMember = "Accessories_NAME"
            cmbItemName.ValueMember = "AccessoriesID"
            'cmbItemName.SelectedValue = ("AccessoriesID").ToString
        End If
    End Sub
    
    Dim paci As PACMAN
    Dim cardConnected As Boolean = False
    Public a As Integer
    Dim stringReader1 As String
    Public texte As Integer
    Public Notes As String = ""

    Private Sub Accessories_Invoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        GredDsin(grid)
        LodData()
        ControlsAsColor(ColorSelect:=Me)

        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)

        CivilIDForm.Bounds = New Rectangle(0, 0, 1500, 500)
        Controls.Add(CivilIDForm)
        CivilIDForm.txtCID.ForeColor = Color.Black
        CardServiceStart()
        paci = New PACMAN
        Visible = False
        language_start(Name)
        
        ' عرض/إخفاء سعر الشراء
        'If SET_INVARCHR162TextBox.Text = "0" Then
        '    lblBuyPrice.Visible = False
        '    txtBuyPrice.Visible = False
        'End If

        '' عرض/إخفاء المكسب
        'If SET_INVARCHR163TextBox.Text = "0" Then
        '    lblEarn.Visible = False
        '    txtEarn.Visible = False
        'End If

        'Try
        '    Accessories_ITEM_AvailableTableAdapter.Fill(DT_restrantDataSet.Accessories_ITEM_Available)
        'Catch ex As Exception

        'End Try
        'Accessories_ITEMVwTableAdapter.Fill(DT_restrantDataSet.Accessories_ITEMVw)
        'texte = stringReader1
        'MAX_Accessories_BAY_IDTableAdapter.Fill(DT_restrantDataSet.MAX_Accessories_BAY_ID)
        'Accessories_ITEMTableAdapter.Fill(DT_restrantDataSet.Accessories_ITEM)
        'cmbItem.SelectedIndex = -1
        'ClearData()
        'CacherTableAdapter.Fill(DT_restrantDataSet.cacher)
        '' خاص للتشغيل من اكتر من جهاز '
        'Accessories_INV_NO_IDTextBox.Text = Val(Accessories_BAY_IDTextBox.Text) + 1
        'cmbItem.DropDownWidth = GetMaxDataSize(DT_restrantDataSet.Accessories_ITEM, "Accessories_ITEM", cmbItem)
        min_Sales.Hide()
        Visible = True
        CivilIDForm.txtCID.SelectAll()
        CivilIDForm.txtCID.Focus()

    End Sub
    Private Sub ClearData()
        pbItem.Image = Nothing
        cmbBrand.SelectedIndex = -1
        txtModelNo.Text = ""
        txtItemNo.Text = ""
        txtCode.Text = ""
        txtSupplier.Text = ""
        txtDescription.Text = ""
        cmbCashier.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        cmbDepartment.SelectedIndex = -1
        txtYear.Text = ""
        txtCost.Text = ""
        txtQty.Text = ""
        txtAttachment.Text = ""
        txtPrice.Text = ""

    End Sub
    Private Sub txtGPrice_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'If Val(txtPrice.Text) = 0 Then
        '    txtEarn.Text = ""
        '    Exit Sub
        'End If
        'txtEarn.Text = Format((Val(txtPrice.Text) - Val(txtBuyPrice.Text)), "0.000")
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Try
        If cmbItemName.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtBarcod.Text = cmbItemName.SelectedValue.ToString
        'Catch ex As Exception

        'End Try



        ''MsgBox(cmbItem.SelectedValue.ToString)
    End Sub

    'Private Sub txtBarCode_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    Try
    '        cmbItemName.SelectedValue = txtBarcod.Text.Trim
    '        GetItemDetels()
    '    Catch ex As Exception
    '        cmbItemName.SelectedIndex = -1
    '    End Try
    '    If txtBarcod.Text = "" OrElse cmbItemName.SelectedValue = Nothing Then
    '        cmbItemName.SelectedIndex = -1

    '        Exit Sub
    '    End If
    '    ClearData()
    '    GetItemDetels()
    'End Sub

    Private Sub txtTotalPrice_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        End If
        If cmbItemName.SelectedIndex = -1 Then
            MsgBox("تأكد من إدخال باركود صحيح او اختر من القائمة" & vbCrLf & "Enter a Valid BarCode Or Select From The Menu", MsgBoxStyle.Exclamation, AppTitle)
            txtBarcod.SelectAll()
            txtBarcod.Focus()
            Exit Sub
        End If
        If txtModelNo.Text = "" Or IsDBNull(txtModelNo.Text) Then
            MsgBox("لم يتم إدخال رقم الموديل" & vbCrLf & "Item Model No. Not Entered.", MsgBoxStyle.Exclamation, AppTitle)
            txtModelNo.SelectAll()
            txtModelNo.Focus()
            Exit Sub
        End If
        'If txtItemNo.Text = "" Or IsDBNull(txtItemNo.Text) Then
        '    MsgBox("لم يتم إدخال رقم القطعة" & vbCrLf & "Item No. Not Entered.", MsgBoxStyle.Exclamation, AppTitle)
        '    txtItemNo.SelectAll()
        '    txtItemNo.Focus()
        '    Exit Sub
        'End If
        If txtQty.Text = "" Or Val(txtQty.Text) < 1 Then
            MsgBox("يرجي إدخال الكمية/العدد" & vbCrLf & "Please enter quantity.", MsgBoxStyle.Exclamation, AppTitle)
            txtQty.SelectAll()
            txtQty.Focus()
            Exit Sub
        End If
        If Val(txtPrice.Text) <= 0 Then
            MsgBox("يرجي إدخال سعر القطعة" & vbCrLf & "Please Enter Item Price .", MsgBoxStyle.Exclamation, AppTitle)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        If cmbCashier.SelectedIndex = -1 Then
            MsgBox("اسم الكاشير لم يتم إدخاله" & vbCrLf & "Please Select Cashier", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If
        With (grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colCivilID").Value = CivilIDForm.txtCID.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colBarcod").Value = txtBarcod.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colItemName").Value = cmbItemName.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colBrand").Value = cmbBrand.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colModelNo").Value = txtModelNo.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colItemNo").Value = txtItemNo.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colItemCode").Value = txtCode.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colSupplier").Value = txtSupplier.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colDescription").Value = txtDescription.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colCashier").Value = cmbCashier.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colCategory").Value = cmbCategory.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colDepartment").Value = cmbDepartment.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colYear").Value = txtYear.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colCost").Value = txtCost.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colQty").Value = If(IsDBNull(txtQty.Text.Trim), "1", Val(txtQty.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("colAttachment").Value = txtAttachment.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colPrice").Value = txtPrice.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colUser").Value = UserName
            .Rows(.Rows.Count - 1).Cells("colDateTime").Value = Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss tt")
            .Rows(.Rows.Count - 1).Cells("colDate").Value = CDate(dtpInvoiceDate.Value)
            .Rows(.Rows.Count - 1).Cells("colItemActv").Value = "1"
            .Rows(.Rows.Count - 1).Cells("colPic").Value = ImageToByte(pbItem.Image)
        End With
        'جمع القيمه من الداتا قريد ووضعها في متغير 
        Dim a As Double
        For i As Integer = 0 To grid.RowCount - 1
            a += grid.Rows(i).Cells("colPrice").Value
        Next
        lblInvoiceValue.Text = a

        'txtQty.Text = "0"
        txtPrice.Text = ""
    End Sub

    Private Sub txtmodel_no_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Accessories_model_noTextBox.Text = txtmodel_no.Text
    End Sub

    Private Sub txtnom_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Accessories_nomTextBox.Text = txtnom.Text
    End Sub

    Private Sub btnPayPrint_Click(sender As Object, e As EventArgs) Handles btnPayPrint.Click
        If grid.Rows.Count = 0 Then
            MsgBox("يرجى إضافة أصناف أولا" & vbCrLf & "Please Add Items First.", MsgBoxStyle.Exclamation, AppTitle)
            Exit Sub
        End If
        ' Accessories_InvoicePay.txtInvoiceNo.Text = lblTotalPriceValue.Text
        Accessories_InvoicePay.txtPrice.Text = lblInvoiceValue.Text
        Accessories_InvoicePay.ShowDialog()
    End Sub
    Private Sub cmbCashier_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        cmbCashier.Enabled = False
    End Sub
    Private Sub Accessories_Invoice_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
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
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Rows(e.RowIndex).Cells("colBarcod").Value = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد الحذف؟" & vbCrLf & "Do You Want to Delete?", vbYesNo) = vbYes Then
                Try
                    grid.Rows.RemoveAt(e.RowIndex)
                    Dim a As Double
                    For i As Integer = 0 To grid.RowCount - 1
                        a += grid.Rows(i).Cells("colPrice").Value
                    Next
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If
    End Sub
    Private Sub btnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AuctionBrand.ShowDialog()
        LodData()
    End Sub

    Private Sub btnCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AccessoriesCATAdd.ShowDialog()
        LodData()
    End Sub

    Private Sub cmbItem_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearData()
        GetItemDetels()
    End Sub

    Private Sub cmbDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepartment.SelectedIndexChanged

    End Sub
    Public Sub txtBarCodeTextChanged()
        ClearData()
        Try
            cmbItemName.SelectedValue = txtBarcod.Text.Trim
        Catch ex As Exception
            cmbItemName.SelectedIndex = -1
        End Try
        If txtBarcod.Text = "" OrElse cmbItemName.SelectedValue = Nothing Then
            cmbItemName.SelectedIndex = -1
            txtQty.Text = "1"

            Exit Sub
        End If
        Try
            GetItemDetels()
        Catch ex As Exception
            txtBarcod.Select()
        End Try
    End Sub
    Private Sub txtBarcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcod.TextChanged
        txtBarCodeTextChanged()
    End Sub
    Private Sub cmbItemName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        If cmbItemName.SelectedIndex = -1 OrElse cmbItemName.ValueMember = "" Then
            Exit Sub
        End If
        If cmbItemName.Focused = True Then
            txtBarcod.Text = cmbItemName.SelectedValue
        End If
    End Sub
    Private Sub btnItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemName.Click
        Accessories_AddItems.ShowDialog()
        GetItemDetels()
    End Sub
    Private Sub btnBrand_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrand.Click
        AuctionBrand.ShowDialog()
        GetItemDetels()
    End Sub
    Private Sub btnCat_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCat.Click
        AccessoriesCATAdd.ShowDialog()
        GetItemDetels()
    End Sub

    Private Sub btnDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDep.Click
        AccessoriesDepAdd.ShowDialog()
        GetItemDetels()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim OFD As New OpenFileDialog
        pbItem.BackgroundImageLayout = ImageLayout.Stretch
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbItem.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbItem.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class