Public Class CountryMade

    Private Sub cantry_made_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub


    Private Sub cantry_made_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        CANTRYTableAdapter.Fill(DT_restrantDataSet.CANTRY)
        grid.Columns(0).Visible = False
        txt.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        CANTRYBindingSource.AddNew()
        txt.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Validate()
        CANTRYBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)
        MsgBox("تم الحفظ بنجاح" & vbCrLf & "Saved Successfully", , "تم الاضافة ---- Adding")
        txt.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            CANTRYBindingSource.RemoveCurrent()
        Catch ex As Exception
            MsgBox("تم حذف جميع البيانات" & vbCrLf & "All Data Has been Deleted", , "فارغ ---- Empty")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        txt.Enabled = True
    End Sub
End Class