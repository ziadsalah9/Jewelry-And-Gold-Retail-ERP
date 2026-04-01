Public Class FrmModifyItemNameGoledSelvir

    Private Sub FrmModifyItemNameGoledSelvir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DtGetItemName As DataTable = GetRecordSet("SELECT [FO_name],[BarCode] FROM [FO_min] where BarCode='103'")
        If DtGetItemName.Rows.Count > 0 Then
            txtItemEdit.SelectedText = DtGetItemName.Rows(0)("FO_name").ToString
        End If
        txtItemEdit.Select()
    End Sub
End Class