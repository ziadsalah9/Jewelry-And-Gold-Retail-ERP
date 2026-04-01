Public Class AuthenticationCivilId
    Private Sub AuthenticationCivilId_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCloce_Click(sender As Object, e As EventArgs) Handles BtnCloce.Click
        Me.Close()
    End Sub

    Private Sub BtnAuth_Click(sender As Object, e As EventArgs) Handles BtnAuth.Click
        GetCivilID(GetCivilID(CivilIDForm.txtCID.Text.Trim))
        Me.Close()
    End Sub

    Private Sub AuthenticationCivilId_Validated(sender As Object, e As EventArgs) Handles MyBase.Validated
        GetCivilID(GetCivilID(CivilIDForm.txtCID.Text.Trim))
    End Sub

    Private Sub AuthenticationCivilId_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GetCivilID(GetCivilID(CivilIDForm.txtCID.Text.Trim))
    End Sub

    Private Sub AuthenticationCivilId_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        GetCivilID(GetCivilID(CivilIDForm.txtCID.Text.Trim))
    End Sub
End Class