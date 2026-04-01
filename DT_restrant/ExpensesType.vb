Public Class ExpType
    Public Sub Save()
        ValidateChildren()
        ExpensesTypeBindingSource.EndEdit()
        ExpensesTypeTableAdapter.Update(DT_restrantDataSet.ExpensesType)

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        ExpensesTypeTableAdapter.Fill(DT_restrantDataSet.ExpensesType)
        grid.Columns(0).Visible = False
        grid.Columns(1).Width = 250
        btnSave.Enabled = False
        txt.Enabled = False
    End Sub

    Private Sub btnNewClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        ExpensesTypeBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        txt.Text = ""
        txt.Enabled = True
        btnEdit.Enabled = False
        txt.SelectAll()
        txt.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If txt.Text.Trim = "" Then
            MsgBox("أدخل تصنيف أولا" & vbCrLf & "Enter a Category Please!", , Apptitle)
            Exit Sub
        End If
        txtDB.Text = txt.Text
        Validate()
        Save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , AppTitle)
        If Expenses.Visible = True Then
            Expenses.ExpensesType()
        ElseIf Expenses.Visible = False Then
        End If
        txt.Enabled = False
        grid.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            ExpensesTypeBindingSource.RemoveCurrent()
            Save()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If grid.SelectedRows.Count > 0 Then
            txt.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر تصنيف أولا" & vbCrLf & "Select an item to Edit First")
        End If

    End Sub

    Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grid.SelectionChanged
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            If IsDBNull(grid.SelectedRows(0).Cells(1).Value) = True Then Exit Sub
            txt.Text = grid.SelectedRows(0).Cells(1).Value
        End If
    End Sub

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt.TextChanged

    End Sub
End Class