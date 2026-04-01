Public Class DiamondCut
    Public Sub save()
        ValidateChildren()
        dimon_catBindingSource.EndEdit()
        Dimon_catTableAdapter.Update(DT_restrantDataSet.dimon_cat)

    End Sub

    Private Sub DiamondCut_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub DiamondCut_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Dimon_catTableAdapter.Fill(DT_restrantDataSet.dimon_cat)
        CANTRYDataGridView.Columns(0).Visible = False
        CANTRYDataGridView.Columns(1).Width = 250
        btnSave.Enabled = False
        CANTRY_nameTextBox.Enabled = False
    End Sub

    Private Sub btnNewClick(sender As Object, e As EventArgs) Handles btnNew.Click
        dimon_catBindingSource.AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        CANTRY_nameTextBox.Text = ""
        CANTRY_nameTextBox.Enabled = True
        btnEdit.Enabled = False
        CANTRY_nameTextBox.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CANTRY_nameTextBox.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , Apptitle)
            Exit Sub
        End If
        DiamondCutTextBox.Text = CANTRY_nameTextBox.Text
        Validate()
        save()
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , Apptitle)
        CANTRY_nameTextBox.Enabled = False
        CANTRYDataGridView.CurrentCell = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then
            dimon_catBindingSource.RemoveCurrent()
            save()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If CANTRYDataGridView.SelectedRows.Count > 0 Then
            CANTRY_nameTextBox.Enabled = True
            btnEdit.Enabled = False
            btnSave.Enabled = True
        Else
            MsgBox("اختر نوع حجر أولا" & vbCrLf & "Select a Stone First")
        End If

    End Sub

    Private Sub CANTRYDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles CANTRYDataGridView.SelectionChanged

        If CANTRYDataGridView.RowCount >= 0 AndAlso CANTRYDataGridView.SelectedRows.Count > 0 Then
            If IsDBNull(CANTRYDataGridView.SelectedRows(0).Cells(1).Value) = True Then Exit Sub
            CANTRY_nameTextBox.Text = CANTRYDataGridView.SelectedRows(0).Cells(1).Value
        End If
    End Sub
End Class