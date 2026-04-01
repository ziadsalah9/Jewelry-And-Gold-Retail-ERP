Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports PACICardLibrary

Public Class GoldSellEditRemove

    Public Sub Count()
        Dim TotalPrice As Decimal
        For i As Integer = 0 To grid.RowCount - 1
            TotalPrice += grid.Rows(i).Cells("colitem_totalPrice").Value
        Next
        txtPriceRequired.Text = TotalPrice
    End Sub
    Private Sub GetInvoiceNumber()
        Dim dt1 As DataTable = GetRecordSet("SELECT BAY_SARYAL FROM BAY WHERE (Active = 1)")
        If dt1.Rows.Count > 0 Then
            txtInvoiceNo.DataSource = dt1
            txtInvoiceNo.DisplayMember = "BAY_SARYAL"
            txtInvoiceNo.ValueMember = "BAY_SARYAL"
        End If
    End Sub
    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Private Sub txtInvoiceNo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.DropDown
        GetInvoiceNumber()
    End Sub

    Sub DeleteItem()
        Try
            SelInvoceActiveCheckBox.Checked = False
            Validate()
            BAYBindingSource.EndEdit()
            SelInvoceDetelsBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.Message, , AppTitle)
        End Try
    End Sub
    Sub DeleteInvoice()
        Try
            BayActiveCheckBox.Checked = False
            ValidateChildren()
            BAYBindingSource.EndEdit()
            BAYTableAdapter.Update(DT_restrantDataSet)
            BAYTableAdapter.FillBy(DT_restrantDataSet.BAY, txtInvoiceNo.Text.Trim)

            For i As Integer = 0 To SelInvoceDetelsBindingSource.Count - 1  'removes displayed rows
                SelInvoceDetelsBindingSource.Position = i
                SelInvoceActiveCheckBox.Checked = False
                Validate()
                SelInvoceDetelsBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DT_restrantDataSet)
            Next
            GetInvoiceData()
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Deleted Successfully", , AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub GoldSellEditRemove_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            Dim a As Decimal = Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)
            If a <> Val(txtPriceRequired.Text) Then
                MsgBox("لايمكن إغلاق الفاتورة قبل تعديل السعر" & vbCrLf & "Can't close the invoice before modifying the price", , AppTitle)
                e.Cancel = True
                Exit Sub
            End If
            TOTAL_monyTextBox.Text = Total_priceTextBox.Text
            Arbic_taybTextBox.Text = kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True)
            ValidateChildren()
            BAYBindingSource.EndEdit()
            BAYTableAdapter.Update(DT_restrantDataSet.BAY)
            frmMain.Timer1.Start()
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub GoldSellEditRemove_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        CheckUserPermissions(UserID)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)
        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
        CivilIDForm.Bounds = New Rectangle(2, 60, 995, 255)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
        language_start(Name)
        frmMain.Timer1.Stop()
        'txtAddress.Enabled = False
        'txtPhone.Enabled = False
        txtPriceReturn.Visible = False
        txtPriceRequired.Enabled = False
        btnPrint.Enabled = False
        GetPayMethod()
    End Sub
    Private Sub GetPayMethodSelect()
        Dim DT1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT2 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT3 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT4 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If DT1.Rows.Count > 0 Then
            cmbPayMethod1.DataSource = DT1
            cmbPayMethod1.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod1.ValueMember = "ID"
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If DT2.Rows.Count > 0 Then
            cmbPayMethod2.DataSource = DT2
            cmbPayMethod2.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod2.ValueMember = "ID"
        End If
        If DT3.Rows.Count > 0 Then
            cmbPayMethod3.DataSource = DT3
            cmbPayMethod3.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod3.ValueMember = "ID"
        End If
        If DT4.Rows.Count > 0 Then
            cmbPayMethod4.DataSource = DT4
            cmbPayMethod4.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod4.ValueMember = "ID"
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
        GetPayMethodSelect()
    Dim PayMethodSet As DataTable = GetRecordSet("select [SET5],[SET6],[SET7],[SET8],[SET9] from [Settings]")
        If PayMethodSet.Rows.Count > 0 Then
            cmbPayMethod1.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET5")), 0, (PayMethodSet.Rows(0)("SET5")))
            cmbPayMethod2.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET6")), 1, (PayMethodSet.Rows(0)("SET6")))
            cmbPayMethod3.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET7")), 2, (PayMethodSet.Rows(0)("SET7")))
            cmbPayMethod4.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET8")), 3, (PayMethodSet.Rows(0)("SET8")))
            If (PayMethodSet.Rows(0)("SET9").ToString) = 0 Then
                txtBank1.Visible = False
                txtBank2.Visible = False
                txtBank3.Visible = False
                txtBank4.Visible = False
                cmbPayMethod1.Visible = False
                cmbPayMethod2.Visible = False
                cmbPayMethod3.Visible = False
                cmbPayMethod4.Visible = False
                lblPayMethod1.Visible = False
    'PnlPyment.Bounds = New Rectangle(175, 15, 243, 97)
            ElseIf (PayMethodSet.Rows(0)("SET9").ToString) = 1 Then
                txtBank1.Visible = True
                txtBank2.Visible = True
                txtBank3.Visible = True
                txtBank4.Visible = True
                cmbPayMethod1.Visible = True
                cmbPayMethod2.Visible = True
                cmbPayMethod3.Visible = True
                cmbPayMethod4.Visible = True
                lblPayMethod1.Visible = True
    'PnlPyment.Bounds = New Rectangle(384, 15, 243, 97)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            Dim a As Decimal = Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)
            If a <> txtPriceRequired.Text Then
                MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , AppTitle)
                Exit Sub
            End If
            GlCommand.CommandText = "UPDATE[selInvoceDetels] SET [nots]=N'" & txtnote.Text.Trim & "',[MetalPrice]='" & grid.CurrentRow.Cells("colitem_totalPrice").Value & "' WHERE(invoc_time = '" & txtInvoiceNo.Text.Trim & "')"
            GlCommand.ExecuteNonQuery()


            DeleteUpdateSqlCommend(SqlComm:="UPDATE [BAY]  SET [PayMethod1] ='" & cmbPayMethod1.SelectedIndex & "'" & vbCrLf &
                                            ",[PayMethod2] = '" & cmbPayMethod2.SelectedIndex & "'" & vbCrLf &
                                           ",[PayMethod3] = '" & cmbPayMethod3.SelectedIndex & "'" & vbCrLf &
                                           ",[PayMethod4] = '" & cmbPayMethod4.SelectedIndex & "'" & vbCrLf &
                                           ",[Bank1] = '" & txtBank1.Text.Trim & "'" & vbCrLf &
                                           ",[Bank2] = '" & txtBank2.Text.Trim & "'" & vbCrLf &
                                           ",[Bank3] ='" & txtBank3.Text.Trim & "'" & vbCrLf &
                                           ",[Bank4] ='" & txtBank4.Text.Trim & "'" & vbCrLf &
                                           " WHERE(BAY_SARYAL = '" & txtInvoiceNo.Text.Trim & "')")
            LocSqlGlCom.ExecuteReader()

            TOTAL_monyTextBox.Text = txtPriceRequired.Text
            Arbic_taybTextBox.Text = kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True)
            English_taybTextBox.Text = ConvertNumberToENG(Val(txtPriceRequired.Text))
            PayMethodTextBox.Text = cmbPayMethod.SelectedValue

            ValidateChildren()
            SelInvoceDetelsBindingSource.EndEdit()
            SelInvoceDetelsTableAdapter.Update(DT_restrantDataSet.selInvoceDetels)
            BAYBindingSource.EndEdit()
            BAYTableAdapter.Update(DT_restrantDataSet.BAY)
            MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        Catch ex As Exception
            MsgBox("خطا 132", , AppTitle)
        End Try
    End Sub

    Private Sub Total_priceTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Total_priceTextBox.TextChanged
        txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        PerformSearch()
    End Sub
    Public Sub PerformSearch()
        If txtInvoiceNo.Text.Trim = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        Try
            btnPrint.Visible = True
            GetInvoiceData()
            If grid.RowCount <> 0 Then
                btnPrint.Enabled = True
                grid.Enabled = True
                gbSave.Enabled = True
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                txtCash.Text = ""
                txtKnet.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub GetInvoiceData()
        SelInvoceDetelsTableAdapter.FillByIDActive(DT_restrantDataSet.selInvoceDetels, txtInvoiceNo.Text.Trim, 1)
        BAYTableAdapter.FillByIDActive(DT_restrantDataSet.BAY, txtInvoiceNo.Text, 1)
        Sum_total_priceTableAdapter.FillBy(DT_restrantDataSet.sum_total_price, txtInvoiceNo.Text.Trim)
        Invoce_reportTableAdapter.FillByIDActive(DT_restrantDataSet.invoce_report, txtInvoiceNo.Text.Trim, 1)
        cmbPayMethod.SelectedValue = If(PayMethodTextBox.Text = "", "1", PayMethodTextBox.Text)
        Dim DT As DataTable = GetRecordSet("SELECT nots,Castomerid FROM selInvoceDetels WHERE(invoc_time = '" & txtInvoiceNo.Text.Trim & "')GROUP BY nots,Castomerid")
        If DT.Rows.Count > 0 Then
            CivilIDForm.txtCID.Text = DT.Rows(0)("Castomerid").ToString
            txtnote.Text = DT.Rows(0)("nots").ToString
        End If
        Dim GetBayDetels As DataTable = GetRecordSet("SELECT * FROM [BAY]  WHERE(BAY_SARYAL = '" & txtInvoiceNo.Text.Trim & "')")
        If GetBayDetels.Rows.Count > 0 Then
            txtBank1.Text = GetBayDetels.Rows(0)("Bank1").ToString
            txtBank2.Text = GetBayDetels.Rows(0)("Bank2").ToString
            txtBank3.Text = GetBayDetels.Rows(0)("Bank3").ToString
            txtBank4.Text = GetBayDetels.Rows(0)("Bank4").ToString
            cmbPayMethod1.SelectedIndex = If(IsDBNull(GetBayDetels.Rows(0)("PayMethod1")), 0, (GetBayDetels.Rows(0)("PayMethod1")))
            cmbPayMethod2.SelectedIndex = If(IsDBNull(GetBayDetels.Rows(0)("PayMethod2")), 1, (GetBayDetels.Rows(0)("PayMethod2")))
            cmbPayMethod3.SelectedIndex = If(IsDBNull(GetBayDetels.Rows(0)("PayMethod3")), 2, (GetBayDetels.Rows(0)("PayMethod3")))
            cmbPayMethod4.SelectedIndex = If(IsDBNull(GetBayDetels.Rows(0)("PayMethod4")), 3, (GetBayDetels.Rows(0)("PayMethod4")))
        End If
        Count()
    End Sub
    Private Sub GetDeletedInvoiceData()
        SelInvoceDetelsTableAdapter.FillByIDActive(DT_restrantDataSet.selInvoceDetels, txtInvoiceNo.Text.Trim, 0)
        BAYTableAdapter.FillByIDActive(DT_restrantDataSet.BAY, txtInvoiceNo.Text, 0)
        Sum_total_priceTableAdapter.FillBy(DT_restrantDataSet.sum_total_price, txtInvoiceNo.Text.Trim)
        Invoce_reportTableAdapter.FillByIDActive(DT_restrantDataSet.invoce_report, txtInvoiceNo.Text.Trim, 0)
        cmbPayMethod.SelectedValue = If(PayMethodTextBox.Text = "", "'", PayMethodTextBox.Text)
        Count()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        If Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text) <> Val(txtPriceRequired.Text) Then
            MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , AppTitle)
            Exit Sub
        End If
        Try
            With GoldViewSellInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text
                .InvoiceSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
    End Sub


    Private Sub btnDeleteInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteInvoice.Click
        If grid.RowCount > 0 Then
            If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                DeleteInvoice()
                Count()
                txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
                Close()
            Else
                MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
                txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub gridGold_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Rows(e.RowIndex).Cells("colID").Value = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            Try
                If grid.RowCount = 1 Then
                    btnDeleteInvoice.PerformClick()
                    Exit Sub
                End If
                If grid.RowCount > 0 Then
                    If MsgBox("سوف يتم حذف صنف..اضغط نعم للاستمرار أو قم بإلغاء الأمر" & vbCrLf & "Item will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف صنف لايمكن استرداده" & vbCrLf & "Warning! Deleted an item can not be undone.") = MsgBoxResult.Ok Then
                        txtPriceReturn.Visible = True
                        DeleteItem()
                        GetInvoiceData()
                        txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                    End If

                End If
            Catch ex As Exception
                MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
            End Try
        End If
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddItem.Click
        GoldAddItem.ShowDialog()
    End Sub

    Private Sub cmbCashier_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCashier.DropDown
        GetCashier()
    End Sub
End Class