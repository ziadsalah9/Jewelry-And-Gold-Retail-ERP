Imports System.IO
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports PACICardLibrary
Imports System.Data.SqlClient
Public Class LOOD_FRM

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1.25)
        If ProgressBar1.Value = 100 Then

            frmLogin.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub LOOD_FRM_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
    End Sub

    Private Sub BackWorLodFrm_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorLodFrm.DoWork
        'Timer1.Start()
    End Sub
End Class