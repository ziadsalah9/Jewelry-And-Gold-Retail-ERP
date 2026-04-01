Public Class PaymentMethodsControl
    Private Sub PaymentMethodsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        Try
            If EditForm = True Then
                Width = 327
                Height = 102
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
