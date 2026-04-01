Public Class FrmViewImages

   
    Private Sub FrmViewImages_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        PicBoxViewImages.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class