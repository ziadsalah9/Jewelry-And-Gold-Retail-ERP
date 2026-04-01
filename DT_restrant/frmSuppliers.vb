Imports PACICardLibrary
Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel


Public Class frmSuppliers
    Private EditControl As Boolean = False
    Public Sub GetCompDetels()
        Dim DtGoldItemName As DataTable = GetRecordSet("SELECT CompanyID,CompanyName FROM [TPCompanyInfo] where Activite=1")
        If DtGoldItemName.Rows.Count > 0 Then
            cmbCompName.DataSource = DtGoldItemName
            cmbCompName.DisplayMember = "CompanyName"
            cmbCompName.ValueMember = "CompanyID"
        End If
        cmbCompName.DropDownWidth = GetMaxDataSize(dt:=DtGoldItemName, FieldName:="CompanyName", ComboBoxName:=cmbCompName)
    End Sub
    Private Async Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        ApplyIconsToContainer(Me)
        Try
            EditForm = False
            CivilIDForm = New CivilID
            CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
            CivilIDForm.Bounds = New Rectangle(0, 45, 995, 300)
            Controls.Add(CivilIDForm)
            CivilIDForm.txtCID.ForeColor = Color.Black
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception

        End Try
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        LodData()
        'LoadCompanyTree()
        'txtCompName.Enabled = False
        txtBranchName.Enabled = False
        txtCommercialRegisterNo.Enabled = False
        txtTelNumber.Enabled = False
        txtBranchAddress.Enabled = False
        txtLicenseNumber.Enabled = False
        GetCompDetels()
        BtnSave.Enabled = False
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.Enter, AddressOf SelectAllText
                AddHandler ctrl.Click, AddressOf SelectAllText
            End If
        Next
    End Sub

    Private Async Sub LodData()
        Dim DT As DataTable = GetRecordSet("SELECT dbo.TPCompanyBranches.BranchID, dbo.TPCompanyBranches.CompanyID," & vbCrLf &
                                          "dbo.TPCompanyInfo.CompanyName, dbo.TPCompanyBranches.BranchName," & vbCrLf &
                                          "dbo.TPCompanyBranches.BranchAddress, " & vbCrLf &
                                          "dbo.TPCompanyBranches.TelNumber, dbo.TPCompanyBranches.LicenseNumber," & vbCrLf &
                                          "dbo.TPCompanyBranches.CommercialRegisterNo, dbo.TPCompanyBranches.LicenseImage, dbo.TPCompanyBranches.CreationDate, " & vbCrLf &
                                          "dbo.TPCompanyBranches.LastEditDate, dbo.TPCompanyBranches.Activite" & vbCrLf &
                                          "FROM dbo.TPCompanyInfo INNER JOIN" & vbCrLf &
                                          "dbo.TPCompanyBranches ON dbo.TPCompanyInfo.CompanyID = dbo.TPCompanyBranches.CompanyID" & vbCrLf &
                                          "WHERE (dbo.TPCompanyBranches.Activite = 1)")
        If DT.Rows.Count > 0 Then
            For i As Integer = 0 To DT.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colBranchID").Value = (DT.Rows(i)("BranchID").ToString)
                    .Rows(i).Cells("colCompanyID").Value = (DT.Rows(i)("CompanyID").ToString)
                    .Rows(i).Cells("colCompanyName").Value = (DT.Rows(i)("CompanyName").ToString)
                    .Rows(i).Cells("colBranchName").Value = (DT.Rows(i)("BranchName").ToString)
                    .Rows(i).Cells("colBranchAddress").Value = (DT.Rows(i)("BranchAddress").ToString)
                    .Rows(i).Cells("colTelNumber").Value = (DT.Rows(i)("TelNumber").ToString)
                    .Rows(i).Cells("colLicenseNumber").Value = (DT.Rows(i)("LicenseNumber").ToString)
                    .Rows(i).Cells("colCommercialRegisterNo").Value = (DT.Rows(i)("CommercialRegisterNo").ToString)
                    .Rows(i).Cells("colCreationDate").Value = (DateToView(DT.Rows(i)("CreationDate").ToString))
                    .Rows(i).Cells("colLastEditDate").Value = (DT.Rows(i)("LastEditDate").ToString)
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
            If MsgBox("هل تريد حذف فرع" & Grid.Rows(e.RowIndex).Cells("colBranchName").Value & "؟" & vbCrLf & "Do You Want To Delete The Branch. " & Grid.Rows(e.RowIndex).Cells("colBranchName").Value, vbYesNo) = vbYes Then
                Try
                    GlCommand.CommandText = "UPDATE [TPCompanyBranches] SET [Activite] = 0 WHERE BranchID ='" & Grid.CurrentRow.Cells("colBranchID").Value & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم حذف البيانات المحددة بنجاح." & vbCrLf & "The selected data has been deleted successfully.", MsgBoxStyle.Information, AppTitle)
                    Grid.Rows.Remove(Grid.SelectedRows(0))
                Catch ex As Exception
                    MsgBox("تم حذف البيانات المحددة بنجاح." & vbCrLf & "The selected data has been deleted successfully.", MsgBoxStyle.Information, AppTitle)
                End Try
            End If
        End If


        If Grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل الفرع" & Grid.Rows(e.RowIndex).Cells("colBranchID").Value & "؟" & vbCrLf & "Do You Want To Edit The Branch." & Grid.Rows(e.RowIndex).Cells("colBranchID").Value, vbYesNo) = vbYes Then
                Try
                    'txtCompName.Text = Grid.Rows(e.RowIndex).Cells("colCOMP_NAME").Value
                    txtBranchName.Text = Grid.Rows(e.RowIndex).Cells("colBranchName").Value
                    txtCommercialRegisterNo.Text = Grid.Rows(e.RowIndex).Cells("colCommercialRegisterNo").Value
                    txtTelNumber.Text = Grid.Rows(e.RowIndex).Cells("colTelNumber").Value
                    txtBranchName.Enabled = True
                    txtCommercialRegisterNo.Enabled = True
                    txtTelNumber.Enabled = True
                    txtBranchAddress.Enabled = True
                    txtLicenseNumber.Enabled = True
                    txtLicenseNumber.Enabled = True
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

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtTelNumber.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblTel.Click

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        EditControl = False
        txtBranchName.Enabled = True
        txtCommercialRegisterNo.Enabled = True
        txtTelNumber.Enabled = True
        txtBranchAddress.Enabled = True
        txtLicenseNumber.Enabled = True
        txtLicenseNumber.Enabled = True
        AddNew()
    End Sub

    Private Sub AddNew()
        With (Grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colCompanyID").Value = ""
            .Rows(.Rows.Count - 1).Cells("colBranchName").Value = ""
            .Rows(.Rows.Count - 1).Cells("colBranchAddress").Value = ""
            .Rows(.Rows.Count - 1).Cells("colTelNumber").Value = ""
            .Rows(.Rows.Count - 1).Cells("colLicenseNumber").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCommercialRegisterNo").Value = ""
            .Rows(.Rows.Count - 1).Cells("colCreationDate").Value = ""
            .Rows(.Rows.Count - 1).Cells("colLastEditDate").Value = ""
            .Rows(.Rows.Count - 1).Cells("colSalesCivilID").Value = ""
        End With
        If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
            Grid.CurrentCell = Grid(0, Grid.Rows.Count - 1)
        Else
        End If
        'Grid.Enabled = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = True
    End Sub
    Public Sub SaveOrUpdateBranch()
        GlCommand.Parameters.Clear()
        If EditControl = False Then
            GlCommand.CommandText =
            "INSERT INTO [dbo].[TPCompanyBranches] " &
            "([CompanyID],[SalesCivilID],[BranchName],[BranchAddress],[TelNumber]," &
            "[LicenseNumber],[CommercialRegisterNo],[LicenseImage],[CreationDate]," &
            "[LastEditDate],[Activite]) " &
            "VALUES (@CompanyID,@SalesCivilID,@BranchName,@BranchAddress,@TelNumber," &
            "@LicenseNumber,@CommercialRegisterNo,@LicenseImage,@CreationDate,@LastEditDate,@Activite)"
            With GlCommand.Parameters
                .AddWithValue("@CompanyID", cmbCompName.SelectedValue)
                .AddWithValue("@SalesCivilID", CivilIDForm.txtCID.Text.Trim())
                .AddWithValue("@BranchName", txtBranchName.Text.Trim())
                .AddWithValue("@BranchAddress", txtBranchAddress.Text.Trim())
                .AddWithValue("@TelNumber", txtTelNumber.Text.Trim())
                .AddWithValue("@LicenseNumber", txtLicenseNumber.Text.Trim())
                .AddWithValue("@CommercialRegisterNo", txtCommercialRegisterNo.Text.Trim())
                .Add("@LicenseImage", SqlDbType.Image).Value = DBNull.Value
                .AddWithValue("@CreationDate", DateToSave(DateTimeCreationDate.Value))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@Activite", "1")
            End With
            GlCommand.ExecuteNonQuery()
            Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
            With (UpdateRows)
                .Cells("colCompanyID").Value = cmbCompName.SelectedValue
                .Cells("colCompanyName").Value = cmbCompName.Text.Trim
                .Cells("colBranchName").Value = txtBranchName.Text.Trim
                .Cells("colBranchAddress").Value = txtBranchAddress.Text.Trim
                .Cells("colTelNumber").Value = txtTelNumber.Text.Trim
                .Cells("colLicenseNumber").Value = txtLicenseNumber.Text.Trim
                .Cells("colCommercialRegisterNo").Value = txtCommercialRegisterNo.Text.Trim
                .Cells("colCreationDate").Value = Format(DateTimeCreationDate.Value, "dd/MM/yyyy")
                .Cells("colLastEditDate").Value = Format(DateTimeCreationDate.Value, "dd/MM/yyyy")
                .Cells("colSalesCivilID").Value = CivilIDForm.txtCID.Text.Trim()
            End With
            MsgBox("تمت الإضافة بنجاح ✔", MsgBoxStyle.Information, AppTitle)
        Else
            GlCommand.CommandText =
            "UPDATE [dbo].[TPCompanyBranches] SET " &
            "[CompanyID]=@CompanyID,[SalesCivilID]=@SalesCivilID,[BranchName]=@BranchName," &
            "[BranchAddress]=@BranchAddress,[TelNumber]=@TelNumber,[LicenseNumber]=@LicenseNumber," &
            "[CommercialRegisterNo]=@CommercialRegisterNo,[LicenseImage]=@LicenseImage," &
            "[CreationDate]=@CreationDate,[LastEditDate]=@LastEditDate,[Activite]=@Activite " &
            "WHERE [BranchID] = @BranchID"
            With GlCommand.Parameters
                .AddWithValue("@CompanyID", cmbCompName.SelectedValue)
                .AddWithValue("@SalesCivilID", CivilIDForm.txtCID.Text.Trim())
                .AddWithValue("@BranchName", txtBranchName.Text.Trim())
                .AddWithValue("@BranchAddress", txtBranchAddress.Text.Trim())
                .AddWithValue("@TelNumber", txtTelNumber.Text.Trim())
                .AddWithValue("@LicenseNumber", txtLicenseNumber.Text.Trim())
                .AddWithValue("@CommercialRegisterNo", txtCommercialRegisterNo.Text.Trim())
                .Add("@LicenseImage", SqlDbType.Image).Value = DBNull.Value
                .AddWithValue("@CreationDate", DateToSave(DateTimeCreationDate.Value))
                .AddWithValue("@LastEditDate", Date.UtcNow)
                .AddWithValue("@Activite", "1")
                .AddWithValue("@BranchID", Grid.CurrentRow.Cells("colBranchID").Value)
            End With
            GlCommand.ExecuteNonQuery()
            Dim UpdateRows As DataGridViewRow = Grid.SelectedRows(0)
            With (UpdateRows)
                .Cells("colCompanyID").Value = cmbCompName.SelectedValue
                .Cells("colCompanyName").Value = cmbCompName.Text.Trim
                .Cells("colBranchName").Value = txtBranchName.Text.Trim
                .Cells("colBranchAddress").Value = txtBranchAddress.Text.Trim
                .Cells("colTelNumber").Value = txtTelNumber.Text.Trim
                .Cells("colLicenseNumber").Value = txtLicenseNumber.Text.Trim
                .Cells("colCommercialRegisterNo").Value = txtCommercialRegisterNo.Text.Trim
                .Cells("colCreationDate").Value = Format(DateTimeCreationDate.Value, "dd/MM/yyyy")
                .Cells("colLastEditDate").Value = Format(DateTimeCreationDate.Value, "dd/MM/yyyy")
                .Cells("colSalesCivilID").Value = CivilIDForm.txtCID.Text.Trim()
            End With
            MsgBox("تم التعديل بنجاح ✔", MsgBoxStyle.Information, AppTitle)
        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If EditControl = False Then
            SaveOrUpdateBranch()
            BtnAdd.Enabled = True
            BtnSave.Enabled = False
        ElseIf EditControl = True Then
            SaveOrUpdateBranch()
            BtnAdd.Enabled = False
            BtnSave.Enabled = True
        End If
        SellBuyWholesale.LoadCompanyAndBranches()
    End Sub
    Private Sub SelectAllText(sender As Object, e As EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        txt.SelectAll()
    End Sub

    Private Sub btnCompName_Click(sender As Object, e As EventArgs) Handles btnCompName.Click
        FrmCompanyInfo.ShowDialog()
    End Sub

    Private Sub frmSuppliers_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        sc.Dispose()
        Dispose()
    End Sub
    Private Sub frmSuppliers_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        sc.Dispose()
        Dispose()
    End Sub

End Class