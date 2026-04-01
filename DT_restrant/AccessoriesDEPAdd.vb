Public Class AccessoriesDepAdd
    Public Sub save()
        ValidateChildren()
        Accessories_DEPBindingSource.EndEdit()
        Accessories_DEPTableAdapter.Update(DT_restrantDataSet.Accessories_DEP)

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        Accessories_DEPTableAdapter.Fill(DT_restrantDataSet.Accessories_DEP)
        language_start(Name)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        txt.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        Accessories_DEPBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        txt.Text = ""
        txt.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txt.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txt.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        TextBox.Text = txt.Text
        Validate()
        save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        txt.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            Accessories_DEPBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            txt.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر قسم أولا" & vbCrLf & "Select a Department First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            txt.Text = If(IsDBNull(grid.SelectedRows(0).Cells(1).Value), "", grid.SelectedRows(0).Cells(1).Value)
        End If
    End Sub
End Class