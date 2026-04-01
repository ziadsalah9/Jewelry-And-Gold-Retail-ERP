Public Class min_Settings

    Private Sub inv_start_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    'Private Sub Inv_startBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.Inv_startBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DT_restrantDataSet)

    'End Sub

    Private Sub inv_start_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        Timer1.Start()
        TextBox1.Text = ""
        Inv_startTableAdapter.Fill(DT_restrantDataSet.inv_start)
        Panel1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'Try
        ''If Inv_startTextBox.Text = "" Then
        'Inv_startTextBox.Text = 1
        'Else
        'End If
        'Me.Inv_startBindingSource.AddNew()
        'Inv_startTextBox.Text = Val(TextBox3.Text)
        'Me.ValidateChildren()
        'Me.Inv_startBindingSource.EndEdit()
        'Me.Inv_startTableAdapter.Update(Me.DT_restrantDataSet.inv_start)
        'MsgBox("تم تحديث ترقيم الفواتير بنجاح", , Apptitle)
        ''Catch ex As Exception
        Settings.ShowDialog()
        Close()
        'End Try
    End Sub
    Private Sub Inv_startLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "@sap2020" Then
            Panel1.Visible = True
            Timer1.Stop()
        ElseIf TextBox1.Text = "hosam0106744284" Then
            Panel1.Visible = True
            Timer1.Stop()
        ElseIf TextBox1.Text = "@SAP2020" Then
            Panel1.Visible = True
            Timer1.Stop()
        ElseIf TextBox1.Text = "@سشح2020" Then
            Panel1.Visible = True
            Timer1.Stop()
        ElseIf TextBox1.Text = "" Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inv_startBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inv_startBindingSource.MovePrevious()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class