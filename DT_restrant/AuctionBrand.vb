Public Class AuctionBrand
    Public Sub Save()
        ValidateChildren()
        AuctionBrandBindingSource.EndEdit()
        AuctionBrandTableAdapter.Update(DT_restrantDataSet.Auction_Brand)
    End Sub

    Private Sub AuctionBrand_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        AuctionBrandTableAdapter.Fill(DT_restrantDataSet.Auction_Brand)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        txt1.Enabled = False
        txt2.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        AuctionBrandBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        txt1.Text = ""
        txt1.Enabled = True
        txt2.Text = ""
        txt2.Enabled = True
        btnEdit.Enabled = False
        txt1.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt1.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        If txt2.Text.Trim = "" Then txt2.Text = Strings.Left(txt1.Text.Trim, 5)
        txtDB1.Text = txt1.Text.Trim
        txtDB2.Text = txt2.Text.Trim
        Validate()
        Save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        txt1.Enabled = False
        txt2.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            AuctionBrandBindingSource.RemoveCurrent()
            Save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            txt1.Enabled = True
            txt2.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر نوع أولا" & vbCrLf & "Select an item to Edit First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            If IsDBNull(grid.SelectedRows(0).Cells(1).Value) = True Then Exit Sub
            txt1.Text = If(IsDBNull(grid.SelectedRows(0).Cells(1).Value), "", grid.SelectedRows(0).Cells(1).Value)
            txt2.Text = If(IsDBNull(grid.SelectedRows(0).Cells(2).Value), "", grid.SelectedRows(0).Cells(2).Value)
        End If
    End Sub
End Class