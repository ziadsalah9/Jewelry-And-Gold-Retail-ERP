Public Class loc

    Private Sub Loc_nameBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        Loc_nameBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)

    End Sub

    Private Sub loc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DT_restrantDataSet.loc_name' table. You can move, or remove it, as needed.

        Dim a As String
        a = Val(Loc_nameTextBox.Text)
        Loc_nameTableAdapter.Fill(DT_restrantDataSet.loc_name)
        TextBox1.Text = Loc_nameTextBox.Text
    End Sub
End Class