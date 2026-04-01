Imports System.Data.SqlClient

Public Class Accessories_AddItems
    Dim EditMode As Boolean = False
    Public Sub Item_Sel()
        Dim SqlCon As New SqlConnection
        Dim SqlCom As New SqlCommand
        Dim SqlDataRe As SqlDataReader
        Dim DataTab As New DataTable
        Dim SqlDataAda As New SqlDataAdapter
        DataTab.Clear()
        SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
        SqlCon.Open()
        SqlCom.Connection = SqlCon
        SqlCom.CommandText = "SELECT [Accessories_INV_ITEM_ID] FROM [Accessories_INV] WHERE [Accessories_Active] = 'True'"
        SqlDataRe = SqlCom.ExecuteReader
        DataTab.Load(SqlDataRe)
        SqlDataRe.Close()
        SqlCon.Close()
        For i As Integer = 0 To DataTab.Rows.Count - 1
            ListBox1.Items.Add(DataTab.Rows(i)("Accessories_INV_ITEM_ID").ToString)
        Next
        For Each item In ListBox1.Items
            For i = 0 To grid.Rows.Count - 1
                If grid.Rows(i).Cells("colAccessoriesID").Value = item Then
                    grid.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                    grid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
        Next

    End Sub

    Public Sub EnableControls(Status As Boolean)
        btnItemSave.Enabled = Status
        btnItemEdit.Enabled = Status
        pnlItemDetails.Enabled = Status
    End Sub

    Private Sub Accessories_AddItems_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
        Accessories_ITEMTableAdapter.Fill(DT_restrantDataSet.Accessories_ITEM)
        Accessories_DEPTableAdapter.Fill(DT_restrantDataSet.Accessories_DEP)
        Accessories_CATTableAdapter.Fill(DT_restrantDataSet.Accessories_CAT)
        txtUserName.Text = UserID
        btnItemSave.Enabled = False
        btnItemEdit.Enabled = False
        pnlItemDetails.Enabled = False
        btnItemEdit.Enabled = True
        min_Items.Hide()
        Item_Sel()
        sort_item()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' grid.RowHeadersWidth = 50

        'sort_item()
        'For i = 0 To grid.Rows.Count - 1
        '    If grid.Rows(i).Cells(0).Value = ListBox1.Text Then
        '        grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '    End If
        'Next


        'Item_Sel()

        'For Each item In ListBox1.Items
        '    'Do stuff
        '    'MsgBox(item.ToString)
        '    For i = 0 To grid.Rows.Count - 1
        '        If grid.Rows(i).Cells(1).Value = item Then
        '            grid.Rows(i).DefaultCellStyle.BackColor = Color.Plum
        '            grid.Rows(i).DefaultCellStyle.ForeColor = Color.Red
        '        End If
        '    Next
        'Next
        'sort_item()
    End Sub

    Private Sub btnItemSave_Click(sender As Object, e As EventArgs) Handles btnItemSave.Click
        If cmbItemName.SelectedIndex = -1 Then
            MsgBox("اختر اسم الصنف" & vbCrLf & "Please Select Item Name", , "خطأ")
            cmbItemName.DroppedDown = True
            Exit Sub
        End If

        If cmbBrand.SelectedIndex = -1 Then
            MsgBox("اختر الماركة" & vbCrLf & "Please Select Brand", , "خطأ")
            cmbBrand.DroppedDown = True
            Exit Sub
        End If

        If txtCost.Text.Trim = "" Then
            MsgBox("اكتب سعر التكلفة" & vbCrLf & "Please Enter Cost", , "خطأ")
            txtCost.SelectAll()
            txtCost.Focus()
            Exit Sub
        End If

        If txtPrice.Text.Trim = "" Then
            MsgBox("اكتب سعر البيع" & vbCrLf & "Please Enter Price", , "خطأ")
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If

        Try
            If EditMode = False Then
                Accessories_ITEMBindingSource.CancelEdit()
                Accessories_ITEMBindingSource.AddNew()
            End If

            Accessories_NAMETextBox.Text = cmbItemName.Text
            Accessories_BRANDTextBox.Text = cmbBrand.Text
            Accessories_BRAND_SHORTTextBox.Text = cmbBrand.SelectedValue
            Accessories_DESCTextBox.Text = txtDescription.Text
            Accessories_CATTextBox.Text = cmbCategory.Text
            Accessories_DEPTextBox.Text = cmbDepartment.Text
            Accessories_model_noTextBox.Text = txtModelNo.Text
            Accessories_nomTextBox.Text = txtItemNo.Text
            Accessories_PICPictureBox.Image = pbItem.Image
            Accessories_USER_CRETTextBox.Text = txtUserName.Text
            Accessories_TIMEDateTimePicker.Value = Date.Now
            Accessories_DATE_CREDateTimePicker.Value = Date.Now
            Accessories_CostTextBox.Text = txtCost.Text
            Accessories_PriceTextBox.Text = txtPrice.Text
            Accessories_CodeTextBox.Text = txtCode.Text
            Accessories_YearTextBox.Text = txtYear.Text
            Accessories_SupplierTextBox.Text = txtSupplier.Text
            Accessories_AttachmentsTextBox.Text = txtAttachment.Text
            Validate()
            Accessories_ITEMBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            btnItemSave.Enabled = False
            btnItemEdit.Enabled = True
            btnItemNew.Enabled = True
            grid.Enabled = True
            pnlItemDetails.Enabled = False
            CHK_SORT()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Item_Sel()

    End Sub

    Private Sub btnItemNew_Click(sender As Object, e As EventArgs) Handles btnItemNew.Click
        ClearControls(pnlItemDetails)
        btnItemEdit.Enabled = False
        btnItemNew.Enabled = False
        grid.Enabled = False
        btnItemSave.Enabled = True
        EditMode = False
        Accessories_ITEMBindingSource.AddNew()
        pnlItemDetails.Enabled = True
        txtUserName.Text = UserID
        Item_Sel()
    End Sub
    Private Sub btnItemEdit_Click(sender As Object, e As EventArgs) Handles btnItemEdit.Click
        EditMode = True
        btnItemEdit.Enabled = False
        btnItemNew.Enabled = False
        btnItemSave.Enabled = True
        pnlItemDetails.Enabled = True
        grid.Enabled = False
        AccessoriesIDTextBox.Text = grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessoriesID").Value
        cmbItemName.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_NAME").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_NAME").Value)
        cmbBrand.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_BRAND").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_BRAND").Value)
        txtDescription.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_DESC").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_DESC").Value)
        cmbCategory.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_CAT").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_CAT").Value)
        cmbDepartment.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_DEP").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_DEP").Value)
        txtModelNo.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_model_no").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_model_no").Value)
        txtItemNo.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_nom").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_nom").Value)
        txtUserName.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_USER_CRET").Value), UserID, grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_USER_CRET").Value)
        txtCost.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Cost").Value), "0", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Cost").Value)
        txtPrice.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Price").Value), "0", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Price").Value)
        txtCode.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Code").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Code").Value)
        txtYear.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Year").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Year").Value)
        txtSupplier.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Supplier").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Supplier").Value)
        txtAttachment.Text = If(IsDBNull(grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Attachment").Value), "", grid.Rows(grid.SelectedRows(0).Index).Cells("colAccessories_Attachment").Value)
        Item_Sel()
    End Sub
    Private Sub btnItemPhoto_Click(sender As Object, e As EventArgs) Handles btnItemPhoto.Click
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
        Accessories_PICPictureBox.Image = pbItem.Image
    End Sub
    Private Sub Accessories_AddItems_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        AccessoriesCATAdd.ShowDialog()
        Accessories_CATTableAdapter.Fill(DT_restrantDataSet.Accessories_CAT)
    End Sub
    Private Sub btnDep_Click(sender As Object, e As EventArgs) Handles btnDep.Click
        AccessoriesDepAdd.ShowDialog()
        Accessories_DEPTableAdapter.Fill(DT_restrantDataSet.Accessories_DEP)
    End Sub

    Private Sub btnItemName_Click(sender As Object, e As EventArgs) Handles btnItemName.Click
        AuctionCategory.ShowDialog()
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
    End Sub

    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        AuctionBrand.ShowDialog()
        Auction_BrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
    End Sub
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        Try
            If grid.Rows(e.RowIndex).Cells("colAccessoriesID").Value = -1 Then Exit Sub
        Catch ex As Exception

        End Try


        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & grid.Rows(e.RowIndex).Cells("colAccessoriesID").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("colAccessoriesID").Value, vbYesNo) = vbYes Then
                Try
                    Accessories_ITEMBindingSource.RemoveCurrent()
                    ValidateChildren()
                    Accessories_ITEMBindingSource.EndEdit()
                    Accessories_ITEMTableAdapter.Update(DT_restrantDataSet)
                    CHK_SORT()
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If

    End Sub
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub txtMoney_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress, txtPrice.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub

    Private Sub btnBarCode_Click(sender As Object, e As EventArgs) Handles btnBarCode.Click
        NewForm = False
        With AccessoriesBarCode
            .Show()
            .txtBarCodeLeft.Text = grid.CurrentRow.Cells("colAccessoriesID").Value
            If grid.CurrentRow.Index >= 1 Then
                .txtBarCodeRight.Text = grid.Rows(grid.CurrentRow.Index - 1).Cells("colAccessoriesID").Value
            Else
                .txtBarCodeRight.Text = grid.CurrentRow.Cells("colAccessoriesID").Value
            End If
            .PrintBarCode()
            .Dispose()
        End With
        Item_Sel()
    End Sub

    Private Sub pbItem_DoubleClick(sender As Object, e As EventArgs) Handles pbItem.DoubleClick
        If pbItem.Image Is Nothing Then Exit Sub
        If MsgBox("هل تريد حذف الصورة؟" & vbCrLf & "Delete Photo?", vbYesNo, "") = vbYes Then
            pbItem.Image = Nothing
        End If
    End Sub
    Public Sub CHK_SORT()
        Dim CHK_STA As Boolean
        If Chk.Checked = False Then
            CHK_STA = False
        ElseIf Chk.Checked = True Then
            CHK_STA = True
        End If
        Dim SqlCon As New SqlConnection
        Dim SqlCom As New SqlCommand
        Dim SqlDataRe As SqlDataReader
        Dim DataTab As New DataTable
        Dim SqlDataAda As New SqlDataAdapter
        DataTab.Clear()
        SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
        SqlCon.Open()
        SqlCom.Connection = SqlCon
        If CHK_STA = True Then
            SqlCom.CommandText = "UPDATE Settings  SET SET_INVARCHR112='1'"
            SORT_BAY_MAX_VAL()
        ElseIf CHK_STA = False Then
            SqlCom.CommandText = "UPDATE Settings  SET SET_INVARCHR112='0'"
            SORT_BAY_Saryal()
        End If
        SqlDataRe = SqlCom.ExecuteReader
        DataTab.Load(SqlDataRe)
        SqlDataRe.Close()
        SqlCon.Close()
    End Sub
    Public Sub sort_item()
        Dim CHK_STA As String
        Dim SqlCon As New SqlConnection
        Dim SqlCom As New SqlCommand
        Dim SqlDataRe As SqlDataReader
        Dim DataTab As New DataTable
        Dim SqlDataAda As New SqlDataAdapter
        DataTab.Clear()
        SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
        SqlCon.Open()
        SqlCom.Connection = SqlCon
        SqlCom.CommandText = "SELECT [SET_INVARCHR112] FROM Settings "
        SqlDataRe = SqlCom.ExecuteReader
        DataTab.Load(SqlDataRe)
        SqlDataRe.Close()
        SqlCon.Close()
        CHK_STA = If(IsDBNull(DataTab.Rows(0)("SET_INVARCHR112").ToString), "0", DataTab.Rows(0)("SET_INVARCHR112").ToString)
        If CHK_STA = "0" Then
            Chk.Checked = False
            SORT_BAY_Saryal()
        ElseIf CHK_STA = "1" Then
            Chk.Checked = True
            SORT_BAY_MAX_VAL()
        End If
    End Sub
    Public Sub SORT_BAY_MAX_VAL()
        Try
            Dim MaxVal As Integer
            Dim SqlCon As New SqlConnection
            Dim SqlCom As New SqlCommand
            Dim SqlDataRe As SqlDataReader
            Dim DataTab As New DataTable
            Dim SqlDataAda As New SqlDataAdapter
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "SELECT MIN(AccessoriesID) AS MIN_VAL FROM Accessories_ITEM"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            MaxVal = DataTab.Rows(0)("MIN_VAL").ToString
            For i As Integer = 0 To grid.Rows.Count - 1
                If grid.Rows.Count > 0 Then
                    grid.Rows(i).Cells(0).Value = i.ToString + MaxVal
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Public Sub SORT_BAY_Saryal()
        For i As Integer = 0 To grid.Rows.Count - 1
            If grid.Rows.Count > 0 Then
                grid.Rows(i).Cells(0).Value = i.ToString + 1
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Chk.CheckedChanged
        CHK_SORT()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells(1).Value = ListBox1.Text Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Dim i As Integer
        'Dim str As String = ""
        'For i = 0 To ListBox1.SelectedItems.Count - 1
        '    str = ListBox1.SelectedItems(i).ToString()
        '    MessageBox.Show(str)
        'Next



        'Do While -1
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    If grid.Rows(i).Cells(1).Value = DataGridView1.Rows(i).Cells(0).Value Then
        '        grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '        'MsgBox(i.ToString)
        '    End If
        '    'If i = 0 Then
        '    '    'Exit Do
        '    'End If
        'Next

        'Loop

        'Item_Sel()
        'For i = 0 To grid.Rows.Count - 1
        '    If grid.Rows(i).Cells(1).Value = ListBox1.Items.Count - 1 Then
        '        grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
        '    End If
        'Next
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    i = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value
        '    MsgBox(i.ToString)
        'Next

        'For Each row As DataGridViewRow In grid.Rows
        '    If row.Cells(1).Value = DataGridView1.SelectedCells.Count - 1 Then
        '        row.DefaultCellStyle.ForeColor = Color.White
        '        row.DefaultCellStyle.BackColor = Color.Green
        '    End If
        'Next
        'DataGridView1.Select()
        'ListBox1.SelectedIndex = 0
        'Dim Y As String = ListBox1.Text
        'Do While ListBox1.Text
        '    MsgBox(Y.ToString)
        'Loop


        'Do
        '    ListBox1.SelectedIndex = 0
        'Dim s As Integer

        'For i = 0 To DataGridView1.Rows.Count - 1
        '    s = DataGridView1.Rows(DataGridView1.SelectedRows(1).Index).Cells(0).Value

        '    DataGridView1.ge
        '    MsgBox(s.ToString)
        'Next
        'MsgBox(ListBox1.SelectedItem)

        'Exit Do


        'Loop Until ListBox1.Items.Count = 1
        'For i As Integer = 0 To ListBox1.SelectedIndex = 1
        '    MsgBox(ListBox1.SelectedItem)

        'Next

        'Do Until ListBox1.SelectedIndex = 1
        '    ListBox1.GetNextControl()
        '    ListBox1.SelectionMode = SelectionMode.MultiExtended
        '    'ListBox1.SelectedItem = SelectNextControl()
        '    MsgBox(ListBox1.SelectedItem)
        'Loop



    End Sub

    Private Sub ListBox1_ControlAdded(sender As Object, e As ControlEventArgs) Handles ListBox1.ControlAdded
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells(0).Value = ListBox1.Text Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub ListBox1_DisplayMemberChanged(sender As Object, e As EventArgs) Handles ListBox1.DisplayMemberChanged
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells(0).Value = ListBox1.Text Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick
        Item_Sel()
    End Sub
End Class
