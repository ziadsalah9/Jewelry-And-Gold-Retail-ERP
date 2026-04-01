Public Class AccessoriesBuyEditRemove
    'Dim a As Decimal
    Public Sub count()
        Dim a As Double
        For i As Integer = 0 To grid.RowCount - 1
            a += grid.Rows(i).Cells("colPrice").Value
        Next
        txtPriceRequired.Text = a

    End Sub

    Sub DeleteItem()
        Dim BarCode As String = grid.SelectedRows(0).Cells("BarCode").Value
        Try
            Accessories_BuyBindingSource.RemoveCurrent()
            Validate()
            Accessories_Buy_PayBindingSource.EndEdit()
            Accessories_BuyBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            SaveDataToDB("Accessories_ITEM", "", "", 1, "AccessoriesID = N'" & BarCode & "'")
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Successfully", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.Message, , AppTitle)
        End Try
    End Sub
    Sub DeleteInvoice()
        Try
            Accessories_Buy_PayBindingSource.RemoveCurrent()
            ValidateChildren()
            Accessories_Buy_PayBindingSource.EndEdit()
            Accessories_Buy_PayTableAdapter.Update(DT_restrantDataSet.Accessories_Buy_Pay)
            Accessories_Buy_PayTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_Buy_Pay, txtInvoiceNo.Text.Trim)

            For i As Integer = 0 To grid.Rows.Count - 1
                SaveDataToDB("Accessories_ITEM", "", "", 1, "AccessoriesID = N'" & grid.Rows(i).Cells("BarCode").Value & "'")
            Next

            Do While Accessories_BuyBindingSource.Count <> 0 'removes displayed rows
                Accessories_BuyBindingSource.MoveFirst()
                Accessories_BuyBindingSource.RemoveCurrent()
                Validate()
                Accessories_BuyBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DT_restrantDataSet)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message, , AppTitle)
        End Try
    End Sub

    Private Sub remov_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

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
            Accessories_Buy_PayBindingSource.EndEdit()
            Accessories_Buy_PayTableAdapter.Update(DT_restrantDataSet.Accessories_Buy_Pay)
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub remov_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        CastomerADrTextBox.Enabled = False
        CastomerTETextBox.Enabled = False
        txtPriceReturn.Visible = False
        txtPriceRequired.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        If grid.RowCount = 1 Then
            btnDeleteInvoice.PerformClick()
            Exit Sub
        End If
        If grid.RowCount > 0 Then
            txtPriceReturn.Visible = True
            DeleteItem()
            count()
            txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
        End If
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
            Accessories_Buy_PayBindingSource.EndEdit()
            Accessories_Buy_PayTableAdapter.Update(DT_restrantDataSet.Accessories_Buy_Pay)
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

        Try
            btnPrint.Visible = True
            Accessories_BuyTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_Buy, txtInvoiceNo.Text.Trim)
            Accessories_Buy_PayTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_Buy_Pay, txtInvoiceNo.Text)
            Accessories_Buy_PayVwTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_Buy_PayVw, txtInvoiceNo.Text.Trim)
            count()
            If grid.RowCount <> 0 Then
                btnPrint.Enabled = True
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , Apptitle)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
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
            With AccessoriesViewBuyInvoice
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

End Class