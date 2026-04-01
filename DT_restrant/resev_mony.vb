Public Class resev_mony

    Private Sub Resev_monyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        Resev_monyBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)

    End Sub

    Private Sub resev_mony_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        Resev_monyTableAdapter.Fill(DT_restrantDataSet.resev_mony)
        DateTimePicker1.Text = Date.Now
        Button1.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Date_resevDateTimePicker.Text = Date.Now
        'Dim ca As Double
        'Dim ke As Double
        'ca = Val(KachTextBox.Text)
        'ke = Val(KentTextBox.Text)

        'TextBox6.Text = Val(KachTextBox.Text + KentTextBox.Text)
        Try
            If TextBox7.Text = "" Then
                TextBox7.Text = 0
            Else
            End If
            If TextBox5.Text = "" Then
                TextBox5.Text = 0
            Else
            End If

            Mony_fromTextBox.Text = TextBox1.Text
            DateTextBox.Text = DateTimePicker1.Text
            For_wontTextBox.Text = TextBox2.Text
            NoteTextBox.Text = TextBox3.Text
            KachTextBox.Text = TextBox5.Text
            Total_moneTextBox.Text = TextBox6.Text
            KentTextBox.Text = TextBox7.Text
            Date_resevDateTimePicker.Text = Date.Now
            User_idTextBox.Text = frmLogin.User_idTextBox.Text
            Validate()
            Resev_monyBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Button2.Enabled = True
            GroupBox1.Enabled = False
            msgdin()

        Catch ex As Exception
            msgnotdin()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Resev_monyBindingSource.AddNew()
        Button2.Enabled = False
        GroupBox1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rwsev_mony_show.ShowDialog()
    End Sub

    Private Sub resev_mony_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        frmMain.Timer1.Start()

        Dispose()
    End Sub
End Class