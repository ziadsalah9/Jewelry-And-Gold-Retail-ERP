Public Class AccessoriesCATAdd
    Public Sub save()
        ValidateChildren()
        Accessories_CATBindingSource.EndEdit()
        Accessories_CATTableAdapter.Update(DT_restrantDataSet.Accessories_CAT)

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        Accessories_CATTableAdapter.Fill(DT_restrantDataSet.Accessories_CAT)
        language_start(Name)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        CANTRY_nameTextBox.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        Accessories_CATBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        CANTRY_nameTextBox.Text = ""
        CANTRY_nameTextBox.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        CANTRY_nameTextBox.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CANTRY_nameTextBox.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        TextBox.Text = CANTRY_nameTextBox.Text
        Validate()
        save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        CANTRY_nameTextBox.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            Accessories_CATBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            CANTRY_nameTextBox.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر صنف أولا" & vbCrLf & "Select a Category First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            CANTRY_nameTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells(1).Value), "", grid.SelectedRows(0).Cells(1).Value)
        End If
    End Sub
End Class