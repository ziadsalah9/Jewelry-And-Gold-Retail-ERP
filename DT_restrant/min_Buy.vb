Public Class min_Buy

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Close()
    End Sub

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        GoldOrSilver = True
        GoldBuyPerson.ShowDialog()
        Close()
    End Sub
    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        GoldOrSilver = False
        GoldBuyPerson.ShowDialog()
        Close()
    End Sub

    Private Sub btnCompanies_Click(sender As Object, e As EventArgs) Handles btnCompanies.Click
        COMP_INVOCE_CACHE.ShowDialog()
        Close()
    End Sub

    Private Sub pay_min_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub pay_min_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        DiamondBuyPerson.ShowDialog()
        Close()
    End Sub


    Private Sub btnAccessories_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click
        AccessoriesBuy.ShowDialog()
        Close()
    End Sub
End Class