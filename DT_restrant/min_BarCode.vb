Public Class min_BarCode

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        ke()
        'GoldOrSilver = True
        'NewForm = True
        'GoldBarCode.ShowDialog()
        'Close()

        GoldOrSilver = True
        NewForm = True
        If GoldOrSilver = True Then
            Barcode.TPCategory = 1
            Barcode.SQLTP = "FO_min"
            Barcode.ShowDialog()
            'فضه
        ElseIf GoldOrSilver = False Then
            Barcode.TPCategory = 2
            Barcode.SQLTP = "SilverItem"
            Barcode.ShowDialog()
        End If
        Close()
    End Sub

    Private Sub btnSilver_Click(sender As Object, e As EventArgs) Handles btnSilver.Click
        ke()
        GoldOrSilver = False
        NewForm = True
        'ذهب
        If GoldOrSilver = True Then
            Barcode.TPCategory = 1
            Barcode.SQLTP = "FO_min"
            Barcode.ShowDialog()
            'فضه
        ElseIf GoldOrSilver = False Then
            Barcode.TPCategory = 2
            Barcode.SQLTP = "SilverItem"
            Barcode.ShowDialog()

        End If
        Close()
    End Sub

    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click
        ke()
        NewForm = True
        DiamondBarCode.ShowDialog()
        Close()
    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Close()
    End Sub

    Private Sub parcood_min_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub parcood_min_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
    End Sub

    Private Sub btnAuction_Click(sender As Object, e As EventArgs) Handles btnAuction.Click
        AuctionBarCode.ShowDialog()
        Close()
    End Sub

    Private Sub btnClock_Click(sender As Object, e As EventArgs) Handles btnAccessories.Click
        NewForm = True
        AccessoriesBarCode.ShowDialog()
        Close()
    End Sub
End Class