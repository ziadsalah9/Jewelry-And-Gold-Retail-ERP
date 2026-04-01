Public Class ColorSettings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SelectColor.ShowDialog() = DialogResult.OK Then
            My.MySettings.Default.ColorSet = SelectColor.Color
            Me.BackColor = My.MySettings.Default.ColorSet
            My.MySettings.Default.Save()
        End If
    End Sub

    Private Sub ColorSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = My.MySettings.Default.ColorSet
    End Sub
End Class