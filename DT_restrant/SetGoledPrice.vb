Public Class SetGoledPrice
    Public Sub PriceEdit()
        Try
            GlCommand.CommandText = " UPDATE [TpSetGoledPriceDiff] SET [TEX24BUY] = " & TXT24KBAY.Text & " ," & vbCrLf &
                                    " [TEX22BUY] = " & TXT22KBAY.Text & ",[TEX21BUY] = " & TXT21KBAY.Text & ",[TEX18BUY] =" & TXT18KBAY.Text & ",[TEX925BUY] = " & TXT925KBAY.Text & ",[TEXOnceBUY] = " & TXtOncaBAY.Text & ", " & vbCrLf &
                                    "[TEX24Sell] = " & TEX24KSale.Text & ",[TEX22Sell] = " & TXT22KSale.Text & ",[TEX21Sell] = " & TXT21KSale.Text & ",[TEX18Sell] = " & TXT18KSale.Text & ",[TEX925Sell] = " & TXT925KSale.Text & ",[TEXOnceSell] = " & TXTOncaSale.Text & ",[TEXOnceSellUsd] = " & TEXOnceSellUsd.Text & ",[TEXOnceBUYUsd] = " & TEXOnceBUYUsd.Text & ""
            GlCommand.ExecuteNonQuery()
            'MsgBox("تم حفظ تعديل فرق الاسعار" & vbCrLf & "Pricing Edit has been saved", , "successful,تم التعديل")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetGoledPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        Try

            Dim DT_SetGoledPrice As DataTable = GetRecordSet(" SELECT * FROM [TpSetGoledPriceDiff]")

            If DT_SetGoledPrice.Rows.Count > 0 Then
                TXT24KBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEX24BUY").ToString
                TXT22KBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEX22BUY").ToString
                TXT21KBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEX21BUY").ToString
                TXT18KBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEX18BUY").ToString
                TXT925KBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEX925BUY").ToString
                TXtOncaBAY.SelectedText = DT_SetGoledPrice.Rows(0)("TEXOnceBUY").ToString
                TEXOnceBUYUsd.SelectedText = DT_SetGoledPrice.Rows(0)("TEXOnceBUYUsd").ToString
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TEX24KSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEX24Sell").ToString
                TXT22KSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEX22Sell").ToString
                TXT21KSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEX21Sell").ToString
                TXT18KSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEX18Sell").ToString
                TXT925KSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEX925Sell").ToString
                TXTOncaSale.SelectedText = DT_SetGoledPrice.Rows(0)("TEXOnceSell").ToString
                TEXOnceSellUsd.SelectedText = DT_SetGoledPrice.Rows(0)("TEXOnceSellUsd").ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub SetGoledPrice_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
   

    Private Sub SetGoledPrice_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        PriceEdit()
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        PriceEdit()
    End Sub

    Private Sub TEXOnceSellUsd_TextChanged(sender As Object, e As EventArgs) Handles TEXOnceSellUsd.TextChanged

    End Sub
End Class