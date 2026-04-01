Imports Microsoft.Reporting.WinForms
Public Class rwsev_mony_show

    Private Sub rwsev_mony_show_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub rwsev_mony_show_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        Resev_mony_max_idTableAdapter.Fill(DT_restrantDataSet.resev_mony_max_id)
        resev_mony_rebortTableAdapter.Fill(DT_restrantDataSet.resev_mony_rebort)
        resev_mony_rebortBindingSource.Filter = " rsev_mony_id ='" & MAX_idTextBox.Text & "'"
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub MAX_idTextBox_TextChanged(sender As Object, e As EventArgs) Handles MAX_idTextBox.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            'Me.Resev_mony_max_idTableAdapter.Fill(Me.DT_restrantDataSet.resev_mony_max_id)
            'TODO: This line of code loads data into the 'DT_restrantDataSet.resev_mony_rebort' table. You can move, or remove it, as needed.
            resev_mony_rebortTableAdapter.Fill(DT_restrantDataSet.resev_mony_rebort)
            resev_mony_rebortBindingSource.Filter = " rsev_mony_id ='" & MAX_idTextBox.Text & "'"
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("يرجي تحديد رقم سند القبض", , Apptitle)
        End Try

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            ReportViewer1.PrintDialog()
        Catch ex As Exception
            MsgBox("لاتوجد طابعة افتراضيه مثبته", , Apptitle)
        End Try

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub
End Class