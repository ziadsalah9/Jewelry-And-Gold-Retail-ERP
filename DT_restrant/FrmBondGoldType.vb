Public Class FrmBondGoldType
    Dim BondTypeEdit As Boolean
    Dim BondType As Integer

    Private Sub FrmBondGoldType_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FrmSnd.Visible = True Then
            FrmSnd.GetBondType()
            Dispose()
            sc.Dispose()
        ElseIf FrmSnd.Visible = False Then
            frmMain.Timer1.Start()
            Dispose()
            sc.Dispose()
        End If
    End Sub
    Private Sub AddNew()
        With (grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colBondNameAr").Value = ""
            .Rows(.Rows.Count - 1).Cells("colBondNameEn").Value = ""
        End With
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            grid.CurrentCell = grid(0, grid.Rows.Count - 1)
        Else
        End If
    End Sub
    Private Sub FillGrid()
        Dim DTBondType As DataTable = GetRecordSet("select * from TBBondGoldType WHERE BondTypeActiv='1' ")
        If DTBondType.Rows.Count > 0 Then
            For i As Integer = 0 To DTBondType.Rows.Count - 1
                With (grid)
                    .Rows.Add()
                    .Rows(i).Cells("colBondNameAr").Value = (DTBondType.Rows(i)("BondTypeArName").ToString)
                    .Rows(i).Cells("colBondNameEn").Value = (DTBondType.Rows(i)("BondTypeEnName").ToString)
                    .Rows(i).Cells("colID").Value = (DTBondType.Rows(i)("BondGoldTypeID").ToString)
                End With
            Next
        End If
    End Sub
    Private Sub FrmBondGoldType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        FillGrid()
        GridSelectionChanged()

         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        txtlBondType.Enabled = False
        txtlBondTypeEn.Enabled = False
        btnSave.Enabled = False
        If grid.Rows.Count > 0 Then
            grid.Rows(0).Selected = True
        Else

        End If
    End Sub
    Private Sub GridSelectionChanged()
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            txtlBondType.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colBondNameAr").Value), "", grid.SelectedRows(0).Cells("colBondNameAr").Value)
            txtlBondTypeEn.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colBondNameEn").Value), "", grid.SelectedRows(0).Cells("colBondNameEn").Value)
        End If
    End Sub
    Private Sub FrmBondGoldType_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If FrmGoldVoucherReserve.Visible = True Then
            FrmGoldVoucherReserve.GetBondType()
            Dispose()
            sc.Dispose()
        ElseIf FrmGoldVoucherReserve.Visible = False Then
            frmMain.Timer1.Start()
            Dispose()
            sc.Dispose()
        End If
    End Sub
    Private Sub grid_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridSelectionChanged()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtlBondType.Enabled = True
        txtlBondTypeEn.Enabled = True
        btnSave.Enabled = True
        BondTypeEdit = False
        btnNew.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        BondTypeEdit = True
        txtlBondType.Enabled = True
        txtlBondTypeEn.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnNew.Enabled = False
        RdCreditor.Checked = False
        RdDebtor.Checked = False

        AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Rd_Checked()
        If txtlBondTypeEn.Text.Trim = "" Then
            MsgBox("اكتب اسم المعامله بلانجليزيه" & vbCrLf & "Write the name of the Bond in English", , AppTitle)
            txtlBondTypeEn.SelectAll()
            txtlBondTypeEn.Focus()
            Exit Sub
        End If
        If txtlBondType.Text.Trim = "" Then
            MsgBox("اكتب اسم المعامله بالعربيه" & vbCrLf & "Writing the name of the bond in Arabic", , AppTitle)
            txtlBondType.SelectAll()
            txtlBondType.Focus()
            Exit Sub
        End If

        If RdDebtor.Checked = False AndAlso RdCreditor.Checked = False Then
            MsgBox("اختر تصنيف الفئه" & vbCrLf & "Select category classification", , AppTitle)
            Exit Sub
        End If


        Try
            'If BondTypeEdit = True Then
            '    DeleteUpdateSqlCommend(SqlComm:=("INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv])VALUES(N'" & txtlBondType.Text.Trim & "',N'" & txtlBondTypeEn.Text.Trim & "','1')"))
            '    LocSqlGlCom.ExecuteReader()
            '    MsgBox("تم اضافة نوع سند بنجاح" & vbCrLf & "Aded New Bond successfully", , AppTitle)
            'ElseIf BondTypeEdit = False Then
            '    DeleteUpdateSqlCommend(SqlComm:=("UPDATE [TBBondGoldType]SET[BondTypeArName] = N'" & txtlBondType.Text.Trim & "',[BondTypeEnName] = N'" & txtlBondTypeEn.Text.Trim & "',[BondTypeActiv] = '1'WHERE BondGoldTypeID='" & grid.SelectedRows(0).Cells("colID").Value & "'"))
            '    LocSqlGlCom.ExecuteReader()
            '    MsgBox("تم التعديل بنجاح" & vbCrLf & "Bond Modified successfully. ", , AppTitle)
            'End If




            If BondTypeEdit = True Then
                DeleteUpdateSqlCommend(SqlComm:=("INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'" & txtlBondType.Text.Trim & "',N'" & txtlBondTypeEn.Text.Trim & "','1','" & BondType & "')"))
                LocSqlGlCom.ExecuteReader()
                MsgBox("تم اضافة نوع سند بنجاح" & vbCrLf & "Aded New Bond successfully", , AppTitle)
            ElseIf BondTypeEdit = False Then
                DeleteUpdateSqlCommend(SqlComm:=("UPDATE [TBBondGoldType]SET[BondTypeArName] = N'" & txtlBondType.Text.Trim & "',[BondTypeEnName] = N'" & txtlBondTypeEn.Text.Trim & "',[BondTypeActiv] = '1',[BondType]='" & BondType & "'WHERE BondGoldTypeID='" & grid.SelectedRows(0).Cells("colID").Value & "'"))
                LocSqlGlCom.ExecuteReader()
                MsgBox("تم التعديل بنجاح" & vbCrLf & "Bond Modified successfully. ", , AppTitle)
            End If



            txtlBondType.Enabled = False
            txtlBondTypeEn.Enabled = False
            Dim UpdateRows As DataGridViewRow = grid.SelectedRows(0)
            UpdateRows.Cells("colBondNameAr").Value = txtlBondType.Text.Trim
            UpdateRows.Cells("colBondNameEn").Value = txtlBondTypeEn.Text.Trim
            btnEdit.Enabled = True
            btnSave.Enabled = False
            BondTypeEdit = True
            btnNew.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Rd_Checked()
        If RdDebtor.Checked = True Then
            BondType = 1
        ElseIf RdCreditor.Checked = True Then
            BondType = 0
        Else
            MsgBox("اختر تصنيف الفئه" & vbCrLf & "Select category classification", , AppTitle)
        End If
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        GridSelectionChanged()
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick
        GridSelectionChanged()
    End Sub
End Class