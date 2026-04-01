Public Class frmLlnk

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Clipboard.SetText(LinkLabel1.Text)
    End Sub
End Class