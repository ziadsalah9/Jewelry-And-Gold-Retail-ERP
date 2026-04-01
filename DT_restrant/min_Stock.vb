Public Class min_Stock

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        GoldOrSilver = True
        ReportGoldItemAvailable.ShowDialog()
        Close()
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        ReportDiamondItemAvailable.ShowDialog()
        Close()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        GoldOrSilver = False
        ReportGoldItemAvailable.ShowDialog()
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Close()
    End Sub

    Private Sub Stock_min_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub Stock_min_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub

    Private Sub btnAccessories_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click
        ReportAccessoriesItemAvailable.ShowDialog()
        Close()
    End Sub
End Class