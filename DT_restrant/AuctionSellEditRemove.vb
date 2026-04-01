Public Class AuctionSellEditRemove

    Sub DeleteInvoice()

        Try
            AuctionInvoiceDetailsBindingSource.RemoveCurrent()
            ValidateChildren()
            AuctionInvoiceDetailsBindingSource.EndEdit()
            AuctionInvoiceDetailsTableAdapter.Update(DT_restrantDataSet)
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Deleted Successfully", , AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub AuctionSellEditRemove_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            If Val(txtPriceRequired.Text) <> Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtLink.Text) Then
                If MsgBox("لم يتم الحفظ..هل تريد الإغلاق بدون حفظ؟" & vbCrLf & "Do You want to close Without Saving?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) <> MsgBoxResult.Yes Then
                    e.Cancel = True
                    Exit Sub
                End If
            End If
            frmMain.Timer1.Start()
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub AuctionSellEditRemove_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        txtCustomerAddress.Enabled = False
        txtCustomerPhone.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            If Val(txtPriceRequired.Text) <> Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtLink.Text) Then
                MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع كاش و كي نت ورابط" & vbCrLf & "Check Price and Paid amounts (Cash/K-Net/Link)", , Apptitle)
                Exit Sub
            End If

            TotalPriceArTextBox.Text = kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True)
            TotalPriceTextBox.Text = txtPriceRequired.Text
            CashTextBox.Text = txtCash.Text
            K_netTextBox.Text = txtKnet.Text
            LinkTextBox.Text = txtLink.Text

            ValidateChildren()
            AuctionInvoiceDetailsBindingSource.EndEdit()
            AuctionInvoiceDetailsTableAdapter.Update(DT_restrantDataSet.AuctionInvoiceDetails)
            IDTextBoxVw.Text = IDTextBox.Text
            MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        Catch ex As Exception
            MsgBox("خطا 132", , AppTitle)
        End Try

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , Apptitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        If Val(txtKnet.Text) + Val(txtCash.Text) + Val(txtLink.Text) <> Val(txtPriceRequired.Text) Then
            MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , Apptitle)
            Exit Sub
        End If
        Try
            With AuctionViewSellInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text
                .InvoiceNoSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , Apptitle)
        End Try
    End Sub


    Private Sub btnDeleteInvoice_Click(sender As Object, e As EventArgs)
        If grid.RowCount > 0 Then
            If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                DeleteInvoice()
                'txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
            Else
                MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , Apptitle)
                'txtPriceReturn.Text = Val(TOTAL_monyTextBox.Text) - Val(txtPriceRequired.Text)
                Beep()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub AuctionInvoiceDetailsBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        AuctionInvoiceDetailsBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)

    End Sub
    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف الفاتورة؟ " & vbCrLf & "Do You Want to Delete Invoice? ", vbYesNo) = vbYes Then
                Try
                    If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                        DeleteInvoice()
                        Beep()
                    Else
                        MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , Apptitle)
                        Beep()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If
    End Sub

    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If grid.RowCount <= 0 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ViewInvoice()
    End Sub
    Private Sub ViewInvoice()
        If txtInvoiceNo.Text.Trim = "" Then
            Exit Sub
        End If
        Try
            btnPrint.Visible = True
            AuctionInvoiceDetailsTableAdapter.FillBy(DT_restrantDataSet.AuctionInvoiceDetails, Val(txtInvoiceNo.Text.Trim))
            AuctionInvoiceDetailsVwTableAdapter.FillBy(DT_restrantDataSet.AuctionInvoiceDetailsVw, Val(txtInvoiceNo.Text.Trim))
            If grid.RowCount <> 0 Then
                btnPrint.Enabled = True
                txtPriceRequired.Text = grid.Rows(0).Cells("colTotalPrice").Value
                txtCash.Text = If(IsDBNull(grid.Rows(0).Cells("colCash").Value), "0", grid.Rows(0).Cells("colCash").Value)
                txtKnet.Text = If(IsDBNull(grid.Rows(0).Cells("colK_Net").Value), "0", grid.Rows(0).Cells("colK_Net").Value)
                txtLink.Text = If(IsDBNull(grid.Rows(0).Cells("colLink").Value), "0", grid.Rows(0).Cells("colLink").Value)

                txtCustomerName.Text = AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colCastomerNAme").Value
                txtCustomerAddress.Text = AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colCastomerADr").Value
                txtCustomerPhone.Text = AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colCastomerTE").Value
                txtCustomerNationality.Text = AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colCastomerNA").Value
                txtCustomerCIDPhoto.Image = If(IsDBNull(AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colfoto").Value), Nothing, ByteToImage(AuctionInvoiceDetailsVwDataGridView.Rows(0).Cells("colfoto").Value))
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , Apptitle)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub txtInvoiceNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInvoiceNo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ViewInvoice()
        End If
    End Sub
End Class