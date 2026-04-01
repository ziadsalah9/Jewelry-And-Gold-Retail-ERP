Public Class GramPrice
    Public posi As Integer

    Public Sub save()
        Try
            ValidateChildren()
            Gram_valBindingSource.EndEdit()
            Gram_valTableAdapter.Update(DT_restrantDataSet)
        Catch ex As Exception
            MsgBox("تتم عملية الحذف الآن" & vbCrLf & "Deleting ......", , "جاري المعالجة ---- Processing..")
        End Try

    End Sub

    Private Sub gramval_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub


    Private Sub gramval_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        Gram_valTableAdapter.Fill(DT_restrantDataSet.Gram_val)
        Gram_valDataGridView.Columns(0).Visible = False
        Gram_valBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Gram_valuTextBox.Text.Trim = "" OrElse IsNumeric(Gram_valuTextBox.Text) = False Then
            MsgBox("يجب إدخال أرقام فقط" & vbCrLf & "Must Enter Numbers Only", , "خطأ في نوع البيانات المدخلة ---- Error in Data Entry")
            Gram_valuTextBox.SelectAll()
            Gram_valuTextBox.Focus()
            Exit Sub
        End If
        save()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Gram_valBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Gram_valBindingSource.RemoveCurrent()
            save()
        Catch ex As Exception
            MsgBox("لا توجد بيانات لحذفها " & vbCrLf & "No data to Delete", , "لايوجد بيانات ---- No Data")
        End Try
    End Sub
End Class