Public Class min_Sales


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Close()
    End Sub

    Private Sub btnGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGold.Click
        Try
            ke()
            'GoldOrSilver = True
            GoldInvoice.ShowDialog()
            Close()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        ke()
        DiamondInvoice.ShowDialog()
        Close()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        ke()
        SilverInvoice.ShowDialog()
        Close()
    End Sub

    Private Sub seles_min_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        GoldInvoice.Dispose()
        Dispose()
    End Sub

    Private Sub seles_min_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub

    Private Sub btnAuction_Click(sender As Object, e As EventArgs) Handles btnAuction.Click
        ke()
        AuctionInvoice.ShowDialog()
        Close()
    End Sub

    Private Sub btnClock_Click(sender As Object, e As EventArgs) Handles btnClock.Click
        ke()
        Accessories_Invoice.ShowDialog()
        Close()
    End Sub


End Class