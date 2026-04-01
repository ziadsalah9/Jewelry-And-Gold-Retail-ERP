Public Class ItemName_ADD
    Public Sub save()
        ValidateChildren()
        Item_NameBindingSource.EndEdit()
        Item_NameTableAdapter.Update(DT_restrantDataSet.Item_Name)

    End Sub

    Private Sub Item_Name_ADD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub EXTR_NAME_ADD_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Item_NameTableAdapter.Fill(DT_restrantDataSet.Item_Name)
        Item_NameDataGridView.Columns(0).Visible = False
        Item_NameDataGridView.Columns(1).Width = 250
        btnSave.Enabled = False
        Item_NameTextBox.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        Item_NameBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        Item_NameTextBox.Text = ""
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Item_NameTextBox.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        EXTR_NAMETextBox.Text = Item_NameTextBox.Text
        Validate()
        save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        Item_NameTextBox.Enabled = False
        Item_NameDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            Item_NameBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Item_NameDataGridView.SelectedRows.Count > 0 Then
            Item_NameTextBox.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر اسم صنف أولا" & vbCrLf & "Select Item Name First")
        End If

    End Sub

    Private Sub CANTRYDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles Item_NameDataGridView.SelectionChanged
        If Item_NameDataGridView.RowCount >= 0 AndAlso Item_NameDataGridView.SelectedRows.Count > 0 Then
            Item_NameTextBox.Text = Item_NameDataGridView.SelectedRows(0).Cells(1).Value
        End If
    End Sub
End Class