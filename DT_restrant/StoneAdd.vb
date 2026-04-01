Public Class StoneAdd
  

    Private Sub StoneAdd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub AddNew()
        btnNew.Enabled = False
        btnSave.Enabled = True
        CANTRY_nameTextBox.Text = ""
        CANTRY_nameTextBox.Enabled = True
        CANTRY_nameTextBox.Focus()
    End Sub

    Private Sub StoneAdd_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        frmMain.Timer1.Stop()
        language_start(Name)
        btnSave.Enabled = False
        CANTRY_nameTextBox.Enabled = False
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة رقم " & Grid.Rows(e.RowIndex).Cells("colStoneName").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & Grid.Rows(e.RowIndex).Cells("colStoneName").Value, vbYesNo) = vbYes Then
                Try
                    GlCommand.CommandText = "UPDATE [EXTR_NAME] SET [Activ]='0' WHERE EXTR_ID='" & Grid.CurrentRow.Cells("colStoneID").Value & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    Grid.Rows.Remove(Grid.SelectedRows(0))
                Catch ex As Exception
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                End Try
            End If
        End If
    End Sub
    Private Sub GridSelectionChanged()
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            CANTRY_nameTextBox.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colStoneName").Value), "", Grid.SelectedRows(0).Cells("colStoneName").Value)
        End If
    End Sub
    Public Sub LoadData()
        Dim LodDate As DataTable = GetRecordSet("select * from EXTR_NAME where Activ=1")
        If LodDate.Rows.Count > 1 Then
            For i As Integer = 0 To LodDate.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colStoneName").Value = (LodDate.Rows(i)("EXTR_NAME").ToString)
                    .Rows(i).Cells("colStoneID").Value = (LodDate.Rows(i)("EXTR_ID").ToString)
                End With
            Next
        End If
    End Sub


    Private Sub btnNewClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If CANTRY_nameTextBox.Text.Trim = "" Then
            MsgBox("أدخل اسم أولا" & vbCrLf & "Enter a Name Please!", , AppTitle)
            Exit Sub
        End If
        Try
            GlCommand.CommandText = "INSERT INTO [EXTR_NAME]([EXTR_NAME] ,[AsGold] ,[IsDiamond],[Activ])VALUES(N'" & CANTRY_nameTextBox.Text.Trim & "','1','1','1')"
            GlCommand.ExecuteNonQuery()
            MsgBox("تم الحفظ بنجاح!" & vbCrLf & "Saved successfully!", , AppTitle)
            With (Grid)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colStoneName").Value = CANTRY_nameTextBox.Text.Trim
            End With
            CANTRY_nameTextBox.Text = ""
            btnSave.Enabled = False
            btnNew.Enabled = True
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("هل تريد الحذف؟!" & vbCrLf & "Do you want to Delete?", vbYesNo) = vbYes Then


        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        'If CANTRYDataGridView.SelectedRows.Count > 0 Then
        '    CANTRY_nameTextBox.Enabled = True
        '    btnEdit.Enabled = False
        '    btnSave.Enabled = True
        'Else
        '    MsgBox("اختر نوع حجر أولا" & vbCrLf & "Select a Stone First")
        'End If
    End Sub

    Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        GridSelectionChanged()
    End Sub
    Private Sub CANTRY_nameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANTRY_nameTextBox.TextChanged

    End Sub
End Class