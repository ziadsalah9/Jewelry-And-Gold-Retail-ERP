Public Class AuctionCategory
    Public Sub Save()
        ValidateChildren()
        Auction_ItemTypeBindingSource.EndEdit()
        Auction_ItemTypeTableAdapter.Update(DT_restrantDataSet.Auction_ItemType)

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Auction_ItemTypeTableAdapter.Fill(DT_restrantDataSet.Auction_ItemType)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        txt.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        Auction_ItemTypeBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        txt.Text = ""
        txt.Enabled = True
        btnEdit.Enabled = False
        txt.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        txtDB.Text = txt.Text
        Validate()
        Save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        txt.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            Auction_ItemTypeBindingSource.RemoveCurrent()
            Save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            txt.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر نوع أولا" & vbCrLf & "Select an item to Edit First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged

        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            If IsDBNull(grid.SelectedRows(0).Cells(1).Value) = True Then Exit Sub
            txt.Text = grid.SelectedRows(0).Cells(1).Value
        End If
    End Sub

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt.TextChanged

    End Sub
End Class