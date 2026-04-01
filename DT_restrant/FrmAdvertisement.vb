Public Class FrmAdvertisement
    Private Sub FrmAdvertisement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim GetFild As DataTable = OnlinGetRecordSet("SELECT * FROM  ADS_SERVICES")
            If GetFild.Rows.Count > 0 Then
                PicAd.Image = ByteToImage(GetFild.Rows(0)("IMGE1"))
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class