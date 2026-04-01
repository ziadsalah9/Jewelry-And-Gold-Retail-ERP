Public Class FrmCompanyInfo
    Private EditControl As Boolean = False
    Private Async Sub LodData()
        Dim DT As DataTable = GetRecordSet("SELECT *FROM TPCompanyInfo where Activite=1")
        If DT.Rows.Count > 0 Then
            For i As Integer = 0 To DT.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colCompanyID").Value = (DT.Rows(i)("CompanyID").ToString)
                    .Rows(i).Cells("colCompanyName").Value = (DT.Rows(i)("CompanyName").ToString)
                    .Rows(i).Cells("colCompanyAddress").Value = (DT.Rows(i)("CompanyAddress").ToString)
                    .Rows(i).Cells("colLicenseNumber").Value = (DT.Rows(i)("LicenseNumber").ToString)
                    .Rows(i).Cells("colCommercialRegisterNo").Value = (DT.Rows(i)("CommercialRegisterNo").ToString)
                End With
            Next
        End If
        If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
            Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
        Else
        End If
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف شركة" & Grid.Rows(e.RowIndex).Cells("colCompanyName").Value & "؟" & vbCrLf & "Do You Want To Delete The CO. " & Grid.Rows(e.RowIndex).Cells("colCompanyName").Value, vbYesNo) = vbYes Then
                Try
                    GlCommand.CommandText = "UPDATE [TPCompanyInfo] SET [Activite] = 0 WHERE CompanyID ='" & Grid.CurrentRow.Cells("colCompanyID").Value & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    Grid.Rows.Remove(Grid.SelectedRows(0))
                Catch ex As Exception
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                End Try
            End If
        End If
        If Grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل شركة" & Grid.Rows(e.RowIndex).Cells("colCompanyName").Value & "؟" & vbCrLf & "Do You Want To Edit The CO." & Grid.Rows(e.RowIndex).Cells("colCompanyName").Value, vbYesNo) = vbYes Then
                Try
                    txtCompanyName.Text = Grid.Rows(e.RowIndex).Cells("colCompanyName").Value
                    txtLicenseNumber.Text = Grid.Rows(e.RowIndex).Cells("colLicenseNumber").Value
                    txtCompanyAddress.Text = Grid.Rows(e.RowIndex).Cells("colCompanyAddress").Value
                    txtCommercialRegisterNo.Text = Grid.Rows(e.RowIndex).Cells("colCommercialRegisterNo").Value
                    txtCompanyName.Enabled = True
                    txtLicenseNumber.Enabled = True
                    txtCompanyAddress.Enabled = True
                    txtCommercialRegisterNo.Enabled = True
                    EditControl = True
                    BtnAdd.Enabled = False
                    BtnSave.Enabled = True
                    If Grid.Rows.Count = 0 Then
                        CivilIDForm.txtCID.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
    End Sub
    Private Sub FrmCompanyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        ApplyIconsToContainer(Me)
        txtCompanyName.Enabled = False
        txtLicenseNumber.Enabled = False
        txtCompanyAddress.Enabled = False
        txtCommercialRegisterNo.Enabled = False
        BtnSave.Enabled = False
        LodData()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.Enter, AddressOf SelectAllText
                AddHandler ctrl.Click, AddressOf SelectAllText
            End If
        Next
    End Sub
    Private Sub SelectAllText(sender As Object, e As EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        txt.SelectAll()
    End Sub
    Private Sub FrmCompanyInfo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub FrmCompanyInfo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(imgDeleteGrid, CInt((e.CellBounds.Width / 2) - (imgDeleteGrid.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (imgDeleteGrid.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(imgModifyGrid, CInt((e.CellBounds.Width / 2) - (imgModifyGrid.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (imgModifyGrid.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub AddNew()
        With (Grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colCompanyName").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCompanyAddress").Value = ""
            .Rows(.Rows.Count - 1).Cells("colLicenseNumber").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCommercialRegisterNo").Value = ""
        End With
        If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
            Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
        Else
        End If
        txtCompanyName.Enabled = True
        txtLicenseNumber.Enabled = True
        txtCompanyAddress.Enabled = True
        txtCommercialRegisterNo.Enabled = True
        BtnSave.Enabled = True
        BtnAdd.Enabled = False
        EditControl = False
        ClearAllText(Me)
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddNew()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not ValidateField(txtCompanyName, "لم يتم إدخال اسم الشركة. هل تريد الاستمرار؟", "Company name is missing. Do you want to continue?", isRequired:=True) Then
            txtCompanyName.Select()
            txtCompanyName.BackColor = Color.FromArgb(212, 175, 55)
            Exit Sub
        End If

        If Not ValidateField(txtLicenseNumber, "لم يتم إدخال رقم الترخيص. هل تريد الاستمرار؟", "License number is missing. Do you want to continue?", isRequired:=False) Then
            txtLicenseNumber.BackColor = Color.FromArgb(212, 175, 55)
            Exit Sub
        End If
        If Not ValidateField(txtCompanyAddress, "لم يتم إدخال عنوان الشركة. هل تريد الاستمرار؟", "Company address is missing. Do you want to continue?", isRequired:=False) Then
            txtCompanyAddress.BackColor = Color.FromArgb(212, 175, 55)
            Exit Sub
        End If
        If Not ValidateField(txtCommercialRegisterNo, "لم يتم إدخال رقم السجل التجاري. هل تريد الاستمرار؟", "Commercial register number is missing. Do you want to continue?", isRequired:=False) Then
            txtCommercialRegisterNo.BackColor = Color.FromArgb(212, 175, 55)
            Exit Sub
        End If
        SaveCompanyInfo()
        UpdateSelectedGridRow()
        ClearAllText(Me)
        BtnAdd.Enabled = True
        BtnSave.Enabled = False
        frmSuppliers.GetCompDetels()
    End Sub
    Public Sub SaveCompanyInfo()
        Try
            GlCommand.Parameters.Clear()
            If EditControl = False Then
                GlCommand.CommandText =
            "INSERT INTO TPCompanyInfo " &
            "([CompanyName],[CompanyAddress],[LicenseNumber],[CommercialRegisterNo]," &
            "[LicenseImage],[CreationDate],[LastEditDate],[Activite]) " &
            "VALUES (@CompanyName, @CompanyAddress, @LicenseNumber, @CommercialRegisterNo," &
            "@LicenseImage, @CreationDate, @LastEditDate, @Activite); " &
            "SELECT SCOPE_IDENTITY();"
                GlCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim)
                GlCommand.Parameters.AddWithValue("@CompanyAddress", txtCompanyAddress.Text.Trim)
            GlCommand.Parameters.AddWithValue("@LicenseNumber", txtLicenseNumber.Text.Trim)
            GlCommand.Parameters.AddWithValue("@CommercialRegisterNo", txtCommercialRegisterNo.Text.Trim)
            GlCommand.Parameters.Add("@LicenseImage", SqlDbType.Image).Value = DBNull.Value
            GlCommand.Parameters.AddWithValue("@CreationDate", DateToSave(Format(dtLastEditDate.Value)))
            GlCommand.Parameters.AddWithValue("@LastEditDate", DateToSave(Format(DateTime.Now)))
            GlCommand.Parameters.AddWithValue("@Activite", 1)
            Dim NewCompanyID As Integer = CInt(GlCommand.ExecuteScalar())
            MsgBox("تمت الإضافة بنجاح ✔", MsgBoxStyle.Information)
        ElseIf EditControl = True Then
            '=================== UPDATE ===================
            Dim CompanyID As Integer = CInt(Grid.CurrentRow.Cells("colCompanyID").Value)
                GlCommand.CommandText =
                "UPDATE TPCompanyInfo SET " &
                "CompanyName = @CompanyName, " &
                "CompanyAddress = @CompanyAddress, " &
                "LicenseNumber = @LicenseNumber, " &
                "CommercialRegisterNo = @CommercialRegisterNo, " &
                "LastEditDate = @LastEditDate " &
                "WHERE CompanyID = @CompanyID"
                GlCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim)
                GlCommand.Parameters.AddWithValue("@CompanyAddress", txtCompanyAddress.Text.Trim)
                GlCommand.Parameters.AddWithValue("@LicenseNumber", txtLicenseNumber.Text.Trim)
                GlCommand.Parameters.AddWithValue("@CommercialRegisterNo", txtCommercialRegisterNo.Text.Trim)
            GlCommand.Parameters.AddWithValue("@LastEditDate", DateToSave(Format(DateTime.Now)))
            GlCommand.Parameters.AddWithValue("@CompanyID", CompanyID)
                GlCommand.ExecuteNonQuery()
                MsgBox("تم التعديل بنجاح ✔", MsgBoxStyle.Information)
            UpdateSelectedGridRow()
        End If
        Catch ex As Exception
        MsgBox("حدث خطأ أثناء الحفظ:" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub AddNewRowToGrid(NewCompanyID As Integer)
        Dim R As DataGridViewRow = Grid.Rows(Grid.Rows.Add())
        R.Cells("colCompanyID").Value = NewCompanyID
        R.Cells("colCompanyName").Value = txtCompanyName.Text.Trim
        R.Cells("colCompanyAddress").Value = txtCompanyAddress.Text.Trim
        R.Cells("colLicenseNumber").Value = txtLicenseNumber.Text.Trim
        R.Cells("colCommercialRegisterNo").Value = txtCommercialRegisterNo.Text.Trim
        R.Cells("colCreationDate").Value = Format(DateTime.Now, "dd/MM/yyyy")
        R.Cells("colLastEditDate").Value = Format(DateTime.Now, "dd/MM/yyyy")
        R.Cells("colActivite").Value = True
        Grid.ClearSelection()
        R.Selected = True
    End Sub
    Private Sub UpdateSelectedGridRow()
        Dim R As DataGridViewRow = Grid.CurrentRow
        R.Cells("colCompanyName").Value = txtCompanyName.Text.Trim
        R.Cells("colCompanyAddress").Value = txtCompanyAddress.Text.Trim
        R.Cells("colLicenseNumber").Value = txtLicenseNumber.Text.Trim
        R.Cells("colCommercialRegisterNo").Value = txtCommercialRegisterNo.Text.Trim
        R.Cells("colLastEditDate").Value = Format(DateTime.Now, "dd/MM/yyyy")
    End Sub

    Private Sub BtnAddLicenseImage_Click(sender As Object, e As EventArgs) Handles BtnAddLicenseImage.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OpenFileDialog1
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                picLicenseImage.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        picLicenseImage.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
End Class