Public Class licen_key

    Private Sub licen_key_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tetlicen_key.Text = CpuIdSystemSerialNumber
    End Sub

    Private Sub btnWhatsApp_Click(sender As Object, e As EventArgs) Handles btnWhatsApp.Click
        If tetlicen_key.Text.Trim <> "" Then
            Clipboard.SetText(tetlicen_key.Text)
        Else
            Clipboard.Clear()
        End If
        'select_scaner_med()
        TopMost = True
        tetlicen_key.Text = ""
        tetlicen_key.Text = Clipboard.GetText()
        TopMost = False

        Try
            Dim webAddress As String = "https://api.whatsapp.com/send?phone=+96594967926"
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("خطأ انتر نت غير متوفر" & vbCrLf & "Check Internet Connection", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub
End Class