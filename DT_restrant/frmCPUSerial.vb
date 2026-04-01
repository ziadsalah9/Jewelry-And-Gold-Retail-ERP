Imports System.ComponentModel

Public Class frmCPUSerial

    Private Sub CPU_K_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' في frmCPUSerial_Load
        Me.TopMost = True
        Me.BringToFront()
        Me.Activate()



        ControlsAsColor(ColorSelect:=Me)
        TEXWAR.Text = "It is not allowed to transfer or copy the system from one device to another before informing the owner company" & vbCrLf & "لا يسمح بنقل أو نسخ النظام من جهاز إلى آخر قبل إبلاغ الشركة المالكة للنظام "
        CPU_ID.Text = CpuIdSystemSerialNumber

    End Sub

    Private Sub frmCPUSerial_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


        Environment.Exit(0)
    End Sub
End Class