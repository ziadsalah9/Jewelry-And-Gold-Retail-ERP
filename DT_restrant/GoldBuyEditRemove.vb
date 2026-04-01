Imports Microsoft.Reporting.WinForms
Imports PACICardLibrary

Public Class GoldBuyEditRemove
    Dim DeletedItemList As List(Of String) = New List(Of String)
    Dim InvoiceNo As String
    Private Sub GoldBuyEditRemove_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        EditForm = False
        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
        CivilIDForm.Bounds = New Rectangle(2, 60, 995, 255)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN

        frmMain.Timer1.Stop()
        language_start(Name)
        GetCashier()
        gbData.Enabled = False
        grid.Enabled = False
        txtCash.Text = "0"
        txtKNET.Text = "0"
    End Sub
    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [cacherID] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "cacherID"
        End If
    End Sub
    Private Sub GoldBuyEditRemove_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub GetInvoiceDetails()
        grid.Rows.Clear()
        Try
            Dim dt1 As DataTable = GetRecordSet("SELECT [B_gold_id] , [castomer_id] , [bay_val] , [bay_mazan] , [bay_gram_price] , [bay_total_price] , [inv_id] , [Item_Des] FROM [Buy_Gold] WHERE [inv_id] = N'" & InvoiceNo & "' AND [Inv_Actv] = '1'")
            If dt1.Rows.Count > 0 Then
                For i As Integer = 0 To dt1.Rows.Count - 1
                    With grid
                        .Rows.Add()
                        .Rows(.Rows.Count - 1).Cells("colB_gold_id").Value = dt1.Rows(i)("B_gold_id")
                        .Rows(.Rows.Count - 1).Cells("colCID").Value = dt1.Rows(i)("castomer_id")
                        .Rows(.Rows.Count - 1).Cells("colInvoiceNo").Value = dt1.Rows(i)("inv_id")
                        .Rows(.Rows.Count - 1).Cells("colKarat").Value = dt1.Rows(i)("bay_val")
                        .Rows(.Rows.Count - 1).Cells("colWeight").Value = dt1.Rows(i)("bay_mazan")
                        .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = dt1.Rows(i)("bay_gram_price")
                        .Rows(.Rows.Count - 1).Cells("colPrice").Value = dt1.Rows(i)("bay_total_price")
                        .Rows(.Rows.Count - 1).Cells("colInvID").Value = dt1.Rows(i)("inv_id")
                        .Rows(.Rows.Count - 1).Cells("colItemDescription").Value = dt1.Rows(i)("Item_Des")
                    End With
                Next
                CivilIDForm.txtCID.Text = dt1.Rows(0)("castomer_id")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If InvoiceNo = "" Then
            Exit Sub
        End If

        Try
            GoldViewBuyInvoice.txtInvoiceNo.Text = InvoiceNo
            GoldViewBuyInvoice.ViwInv()
            'GoldViewBuyInvoice.ReportGoldBuyInvoiceTableAdapter.Fill(GoldViewBuyInvoice.DT_restrantDataSet.ReportGoldBuyInvoice)
            'GoldViewBuyInvoice.ReportGoldBuyInvoiceBindingSource.Filter = "inv_id = '" & txtInvoiceNo.Text.Trim & "'"
            'GoldViewBuyInvoice.ReportViewer.RefreshReport()
            'GoldViewBuyInvoice.ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
            'GoldViewBuyInvoice.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, , AppTitle)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If txtInvoiceNo.Text.Trim = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            InvoiceNo = ""
            txtInvoiceNo.SelectAll()
            txtInvoiceNo.Focus()
            Exit Sub
        End If

        InvoiceNo = txtInvoiceNo.Text.Trim
        GetInvoiceDetails()
        If grid.Rows.Count = 0 Then
            Dim dt1 As DataTable = GetRecordSet("SELECT [bay_id] FROM [bay_goled_mony] WHERE [saryal] = N'" & InvoiceNo & "'")
            If dt1.Rows.Count > 0 Then
                MsgBox("الفاتورة محذوفة" & vbCrLf & "Invoice was deleted", , AppTitle)
                Exit Sub
            Else
                MsgBox("لا يوجد فاتورة بهذا الرقم" & vbCrLf & "No Invoice found with that No.", , AppTitle)
            End If
        End If
        GetPayDetails()
        txtTotalWeight.Text = GetTotalWeight()
        txtPrice.Text = GetPrice()
        txtPriceNew.Text = txtPrice.Text

        If grid.RowCount > 0 Then
            gbData.Enabled = True
            grid.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CivilIDForm.txtCID.Text = "" Then
            MessageBox.Show("أدخل بيانات العميل" & vbCrLf & "Enter Customer Data", AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtKNET.Text) + Val(txtCash.Text) <> Val(txtPriceNew.Text) Then
            MessageBox.Show("خطأ المبلغ المطلوب أقل /أكثر من المدخل" & vbCrLf & "Error The amount requested is less / more than the input", AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        SaveInvoice()
    End Sub

    Private Sub DeleteItem(IntNo As Integer, RIndex As Integer)
        If MsgBox("هل تريد حذف الصنف المحدد؟" & vbCrLf & "Do You Want To Delete The Selected Item?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            DeletedItemList.Add(IntNo)
            txtReturnedWeight.Text = Val(txtReturnedWeight.Text) + grid.Rows(RIndex).Cells("colWeight").Value
            txtReturnPrice.Text = Val(txtReturnPrice.Text) + grid.Rows(RIndex).Cells("colPrice").Value
            grid.Rows.RemoveAt(RIndex)
            txtPriceNew.Text = GetReturnPrice() 'Val(txtPrice.Text) - Val(txtPriceNew.Text) - grid.Rows(RIndex).Cells("colPrice").Value
        End If
    End Sub

    Sub DeleteInvoice()
        If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الأمر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! حذف الفاتورة لايمكن استرجاعه" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
            Try
                GlCommand.CommandText = "UPDATE [Buy_Gold] SET [INV_Actv] = '0' WHERE [inv_id] = N'" & InvoiceNo & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [bay_goled_mony] SET [INV_Actv] = '0' WHERE [saryal] = N'" & InvoiceNo & "'"
                GlCommand.ExecuteNonQuery()
                Beep()
                Close()
            Catch ex As Exception
                MsgBox("خطأ 123", MsgBoxStyle.Critical, AppTitle)
            End Try
        Else
            Beep()
            Exit Sub
        End If
    End Sub

    Private Sub btnDeleteInvoice_Click(sender As Object, e As EventArgs) Handles btnDeleteInvoice.Click
        DeleteInvoice()
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Rows(e.RowIndex).Cells("colB_gold_id").Value = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            Try
                If grid.RowCount = 1 Then
                    btnDeleteInvoice.PerformClick()
                    Exit Sub
                End If
                If grid.RowCount > 0 Then
                    DeleteItem(grid.Rows(e.RowIndex).Cells("colB_gold_id").Value, e.RowIndex)
                End If
            Catch ex As Exception
                MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
            End Try
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
    Private Sub GetPayDetails()
        Dim dt1 As DataTable = GetRecordSet("SELECT [bay_id] , [cach] , [kenet] , [arabik] , [English] , [date] , [TIME_INV] , [Cashier] FROM [bay_goled_mony] WHERE [saryal] = N'" & InvoiceNo & "' AND [Inv_Actv] = '1'")
        If dt1.Rows.Count > 0 Then
            txtCash.Text = dt1.Rows(0)("cach").ToString
            txtKNET.Text = dt1.Rows(0)("kenet").ToString
            dtpInvoiceDate.Value = CDate(dt1.Rows(0)("date"))
            Try
                cmbCashier.SelectedValue = dt1.Rows(0)("Cashier").ToString
            Catch ex As Exception
                cmbCashier.SelectedValue = Nothing
            End Try
        End If
    End Sub
    Private Function GetPrice() As Double
        Dim TotalPrice As Double
        For i As Integer = 0 To grid.RowCount - 1
            TotalPrice += grid.Rows(i).Cells("colPrice").Value
        Next
        Return TotalPrice
    End Function
    Private Function GetReturnPrice()
        Dim GridTotalPrice As Double
        For i As Integer = 0 To grid.RowCount - 1
            GridTotalPrice += grid.Rows(i).Cells("colPrice").Value
        Next
        Return GridTotalPrice
    End Function
    Private Function GetReturnedWeight() As Double
        Dim CurrentWeight As Double
        For i As Integer = 0 To grid.RowCount - 1
            CurrentWeight += grid.Rows(i).Cells("colWeight").Value
        Next
        Return Val(txtTotalWeight.Text) - CurrentWeight
    End Function
    Private Function GetTotalWeight() As Double
        Dim TotalWeight As Double
        For i As Integer = 0 To grid.RowCount - 1
            TotalWeight += grid.Rows(i).Cells("colWeight").Value
        Next
        Return TotalWeight
    End Function
    Private Sub SaveInvoice()
        Try
            For Each item In DeletedItemList
                GlCommand.CommandText = "UPDATE [Buy_Gold] SET [INV_Actv] = '0' WHERE [B_gold_id] = N'" & item & "'"
                GlCommand.ExecuteNonQuery()
            Next
            For i As Integer = 0 To grid.Rows.Count - 1
                GlCommand.CommandText = "UPDATE [Buy_Gold] SET " &
                                        "[castomer_id] = @castomer_id , " &
                                        "[bay_val] = @bay_val , " &
                                        "[bay_mazan] = @bay_mazan , " &
                                        "[bay_gram_price] = @bay_gram_price , " &
                                        "[bay_total_price] = @bay_total_price , " &
                                        "[inv_id] = @inv_id , " &
                                        "[Item_Des] = @Item_Des , " &
                                        "[INV_Actv] = '1' " &
                                        "WHERE [B_gold_id] = N'" & grid.Rows(i).Cells("colB_gold_id").Value & "'"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@castomer_id", CivilIDForm.txtCID.Text.Trim)
                    .AddWithValue("@bay_val", grid.Rows(i).Cells("colKarat").Value)
                    .AddWithValue("@bay_mazan", grid.Rows(i).Cells("colWeight").Value)
                    .AddWithValue("@bay_gram_price", grid.Rows(i).Cells("colGramPrice").Value)
                    .AddWithValue("@bay_total_price", grid.Rows(i).Cells("colPrice").Value)
                    .AddWithValue("@inv_id", grid.Rows(i).Cells("colInvID").Value)
                    .AddWithValue("@Item_Des", grid.Rows(i).Cells("colItemDescription").Value)
                End With
                GlCommand.ExecuteNonQuery()
            Next


            GlCommand.CommandText = "UPDATE [bay_goled_mony] SET " &
                                        "[total_price] = @total_price , " &
                                        "[cach] = @cach , " &
                                        "[kenet] = @kenet , " &
                                        "[arabik] = @arabik , " &
                                        "[English] = @English , " &
                                        "[Cashier] = @Cashier , " &
                                        "[date] = @date , " &
                                        "[TIME_INV] = @TIME_INV , " &
                                        "[INV_Actv] = '1' " &
                                        "WHERE [saryal] = N'" & InvoiceNo & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@total_price", txtPriceNew.Text.Trim)
                .AddWithValue("@cach", txtCash.Text.Trim)
                .AddWithValue("@kenet", txtKNET.Text.Trim)
                .AddWithValue("@arabik", kokotxt(Val(txtPriceNew.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@English", ConvertNumberToENG(Val(txtPriceNew.Text)))
                .AddWithValue("@Cashier", cmbCashier.SelectedValue)
                .AddWithValue("@date", dtpInvoiceDate.Value)
                .AddWithValue("@TIME_INV", DateTimeToView(dtpInvoiceDate.Value))
            End With
            GlCommand.ExecuteNonQuery()
            MsgBox("تم الحفظ" & vbCrLf & "Saving Successfully", , AppTitle)
        Catch ex As Exception
            If My.Computer.Keyboard.CtrlKeyDown Then
                MsgBox(ex.Message)
            Else
                MsgBox("خطأ لم يتم الحفظ" & vbCrLf & "Error While saving..", , AppTitle)
            End If
        End Try

    End Sub

    Private Sub grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellEndEdit
        If e.ColumnIndex = 4 Then 'Weight
            Dim TotalWeight As Decimal
            For i As Integer = 0 To grid.Rows.Count - 1
                TotalWeight += Val(grid.Rows(i).Cells(4).Value)
            Next
            txtTotalWeight.Text = TotalWeight
        End If
        If e.ColumnIndex = 6 Then 'Price
            Dim TotalPrice As Decimal
            For i As Integer = 0 To grid.Rows.Count - 1
                TotalPrice += Val(grid.Rows(i).Cells(6).Value)
            Next
            txtPrice.Text = TotalPrice
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnView.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class