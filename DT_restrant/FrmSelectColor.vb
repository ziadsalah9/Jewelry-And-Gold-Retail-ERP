Public Class FrmSelectColor

    Private Sub BtnSetBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetBackColor.Click
       
    End Sub

    Private Sub BtnSetFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FontColor.ShowDialog() = DialogResult.OK Then
            My.MySettings.Default.FontColor = FontColor.Color
            My.MySettings.Default.Save()
        End If
    End Sub
    Private Sub FrmSelectColor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.Timer1.Stop()
    End Sub

    Private Sub FrmSelectColor_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Discoloration()
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub FrmSelectColor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Discoloration()
        frmMain.Timer1.Start()
        Dispose()
    End Sub
End Class