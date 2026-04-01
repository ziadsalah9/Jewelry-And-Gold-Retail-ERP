Public Class Accessories_SellEditRemove
    'Dim a As Decimal
    Public Sub count()
        Dim a As Double
        For i As Integer = 0 To grid.RowCount - 1
            a += grid.Rows(i).Cells("colitem_totalPrice").Value
        Next
        txtPriceRequired.Text = a

    End Sub
    Private Sub AccessoriesSellEditRemove_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        CastomerADrTextBox.Enabled = False
        CastomerTETextBox.Enabled = False
        txtPriceReturn.Visible = False
        txtPriceRequired.Enabled = False
        btnPrint.Enabled = False
    End Sub
    Sub DeleteItem(ItemID As String)
        Try
            SaveDataToDB("Accessories_INV", "Accessories_Active", "0", 3, "Accessories_INV_ID = N'" & ItemID & "'")
            Accessories_INVActiveCheckBox.Checked = False
            Validate()
            Accessories_BAYBindingSource.EndEdit()
            AccessoriesINVBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
        End Try
    End Sub
    Sub DeleteInvoice()
        Try
            SaveDataToDB("Accessories_BAY", "Accessories_Active", "0", 3, "Accessories_BAY_SARYAL = N'" & txtInvoiceNo.Text.Trim & "'")
            SaveDataToDB("Accessories_INV", "Accessories_Active", "0", 3, "Accessories_INV_NO_ID = N'" & txtInvoiceNo.Text.Trim & "'")
            Accessories_BAYTableAdapter.FillByID(DT_restrantDataSet.Accessories_BAY, txtInvoiceNo.Text.Trim)
            GetInvoiceData()
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Deleted Successfully", , AppTitle)
            Exit Sub
        End Try
    End Sub
    Private Sub GetInvoiceData()
        Accessories_BAYTableAdapter.FillByIDActive(DT_restrantDataSet.Accessories_BAY, txtInvoiceNo.Text.Trim, 1)
        Accessories_INVTableAdapter.FillByIDActive(DT_restrantDataSet.Accessories_INV, txtInvoiceNo.Text.Trim, 1)
        count()
    End Sub
    Private Sub Accessories_SellEditRemove_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Try
            Dim a As Decimal = Val(txtKnet.Text) + Val(txtCash.Text)
            If a <> Val(txtPriceRequired.Text) Then
                MsgBox("لايمكن إغلاق الفاتورة قبل تعديل السعر" & vbCrLf & "Can't close the invoice before modifying the price", , Apptitle)
                e.Cancel = True
                Exit Sub
            Else
            End If
            TOTAL_monyTextBox.Text = Total_priceTextBox.Text
            Arbic_taybTextBox.Text = kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True)
            ValidateChildren()
            Accessories_BAYBindingSource.EndEdit()
            Accessories_BAYTableAdapter.Update(DT_restrantDataSet.Accessories_BAY)
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim a As Decimal = Val(txtKnet.Text) + Val(txtCash.Text)
            If a <> txtPriceRequired.Text Then
                MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , Apptitle)
                Exit Sub
            End If
            TOTAL_monyTextBox.Text = txtPriceRequired.Text
            Arbic_taybTextBox.Text = kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True)
            ValidateChildren()
            Accessories_BAYBindingSource.EndEdit()
            Accessories_BAYTableAdapter.Update(DT_restrantDataSet.Accessories_BAY)
            MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        Catch ex As Exception
            MsgBox("خطا 132", , AppTitle)
        End Try

    End Sub

    Private Sub Total_priceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Total_priceTextBox.TextChanged
        txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
    End Sub

    Private Sub lnkViewInvoice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkViewInvoice.LinkClicked
        If txtInvoiceNo.Text.Trim = "" Then
            Exit Sub
        End If

        'Try
        btnPrint.Visible = True
            GetInvoiceData()

            If grid.RowCount <> 0 Then
                btnPrint.Enabled = True
                grid.Enabled = True
                gbSave.Enabled = True
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , Apptitle)
            End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , Apptitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        If Val(txtKnet.Text) + Val(txtCash.Text) <> Val(txtPriceRequired.Text) Then
            MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , Apptitle)
            Exit Sub
        End If
        Try
            With Accessories_ViewSellInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text
                .InvoiceSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , Apptitle)
        End Try
    End Sub


    Private Sub btnDeleteInvoice_Click(sender As Object, e As EventArgs) Handles btnDeleteInvoice.Click
        If grid.RowCount > 0 Then
            If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                DeleteInvoice()
                count()
                txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
                Close()
            Else
                MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , Apptitle)
                txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub gridGold_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
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
                    txtPriceReturn.Visible = True
                    DeleteItem(grid.Rows(e.RowIndex).Cells("colID").Value)
                    GetInvoiceData()
                    txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                End If
            Catch ex As Exception
                MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
            End Try
        End If
    End Sub

End Class