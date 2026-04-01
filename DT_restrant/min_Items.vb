Public Class min_Items
    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        GoldOrSilver = True
        GoldAddItemDetails.ShowDialog()
        Close()
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        DiamondAddItemDetails.ShowDialog()
        Close()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        GoldOrSilver = False
        GoldAddItemDetails.ShowDialog()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
    End Sub

    Private Sub min_Items_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub min_Items_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub


    Private Sub btnAuction_Click(sender As Object, e As EventArgs) Handles btnAuction.Click
        AuctionAddItemDetails.ShowDialog()
        Close()
    End Sub

    Private Sub btnClock_Click(sender As Object, e As EventArgs) Handles btnClock.Click
        Accessories_AddItems.ShowDialog()
        Close()
    End Sub
End Class