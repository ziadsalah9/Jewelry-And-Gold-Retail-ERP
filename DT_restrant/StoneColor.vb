Public Class StoneColor
    Public Sub save()
        ValidateChildren()
        StoneColorBindingSource.EndEdit()
        StoneColorTableAdapter.Update(DT_restrantDataSet.StoneColor)

    End Sub

    Private Sub StoneAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub StoneAdd_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        StoneColorTableAdapter.Fill(DT_restrantDataSet.StoneColor)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        StoneColorTextBox.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        StoneColorBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        StoneColorTextBox.Text = ""
        StoneColorTextBox.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        StoneColorTextBox.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If StoneColorTextBox.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        EXTR_NAMETextBox.Text = StoneColorTextBox.Text
        Validate()
        save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        StoneColorTextBox.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            StoneColorBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            StoneColorTextBox.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر نوع حجر أولا" & vbCrLf & "Select a Stone First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            StoneColorTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells(1).Value), "", grid.SelectedRows(0).Cells(1).Value)
        End If
    End Sub
End Class