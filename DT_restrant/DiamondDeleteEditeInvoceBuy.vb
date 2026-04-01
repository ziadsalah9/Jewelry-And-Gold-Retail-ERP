Imports System.IO
Imports PACICardLibrary
Imports Microsoft.Reporting.WinForms
Public Class DiamondDeleteEditeInvoceBuy
    Dim PaymentsDifference As Decimal

    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Private Sub GetInvoiceNumber()
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM Bay_Diamond_mony WHERE (Active = 1)")
        If dt1.Rows.Count > 0 Then
            txtInvoiceNo.DataSource = dt1
            txtInvoiceNo.DisplayMember = "saryal"
            txtInvoiceNo.ValueMember = "saryal"
            'txtPriceRequired.Text = dt1.Rows(0)("total_price").ToString
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM  PayMethod WHERE (Active = '1') AND (ID = N'" & txtInvoiceNo.Text.Trim & "')")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub GetInvoicePyment()
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM  Bay_Diamond_mony WHERE (Active = 1) AND (saryal = N'" & txtInvoiceNo.Text.Trim & "')")
        If dt1.Rows.Count > 0 Then
            txtCash.Text = Val(dt1.Rows(0)("cach").ToString)
            txtKnet.Text = Val(dt1.Rows(0)("kenet").ToString)
            dtpInvoiceDate.Value = CDate(dt1.Rows(0)("date"))
        End If
    End Sub
    Private Sub CalculatePricePaymentsDifference()
        Dim TotalPrice As Decimal = Val(txtKnet.Text) + Val(txtCash.Text)
        Dim PriceRequired As Decimal = Val(txtPriceRequired.Text)
        txtPriceReturn.Text = PriceRequired - TotalPrice
    End Sub
    Private Sub CalculatePrice()
        Dim TotalPrice As Decimal
        For i As Integer = 0 To DGridItemDetels.Rows.Count - 1
            If DGridItemDetels.Rows(i).Cells("colActive").Value = "1" Then
                TotalPrice += Val(DGridItemDetels.Rows(i).Cells("colbay_total_price").Value)
            End If
        Next
        txtPriceRequired.Text = TotalPrice
        CalculatePricePaymentsDifference()
    End Sub
    Private Sub DiamondDeleteEditeInvoce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        GredDsin(GredName:=DGridItemDetels)
        CheckUserPermissions(UserID)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)
        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
        CivilIDForm.Bounds = New Rectangle(2, 60, 995, 255)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
        btnPrint.Enabled = False
        GetCashier()
        txtInvoiceNo.Text = ""
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        GredDsin(GredName:=DGridItemDetels)
        DGridItemDetels.Rows.Clear()
        Dim dtInvoice As DataTable = GetRecordSet("SELECT  * FROM [Buy_Diamond] WHERE [inv_id] = N'" & txtInvoiceNo.Text.Trim & "' AND Active = '1'")
        If dtInvoice.Rows.Count > 0 Then
            For i As Integer = 0 To dtInvoice.Rows.Count - 1
                With DGridItemDetels
                    .Rows.Add()
                    .Rows(.Rows.Count - 1).Cells("colcastomer_id").Value = dtInvoice.Rows(i)("castomer_id").ToString
                    .Rows(.Rows.Count - 1).Cells("colval_gold").Value = dtInvoice.Rows(i)("val_gold").ToString
                    .Rows(.Rows.Count - 1).Cells("colGOLD_mezan").Value = dtInvoice.Rows(i)("GOLD_mezan").ToString
                    .Rows(.Rows.Count - 1).Cells("colbay_total_price").Value = dtInvoice.Rows(i)("bay_total_price").ToString
                    .Rows(.Rows.Count - 1).Cells("colDIMO_dep").Value = dtInvoice.Rows(i)("DIMO_dep").ToString
                    .Rows(.Rows.Count - 1).Cells("colDIM_na9awa").Value = dtInvoice.Rows(i)("DIM_na9awa").ToString
                    .Rows(.Rows.Count - 1).Cells("colDIMO_mezan").Value = dtInvoice.Rows(i)("DIMO_mezan").ToString
                    .Rows(.Rows.Count - 1).Cells("colext_coler").Value = dtInvoice.Rows(i)("ext_coler").ToString
                    .Rows(.Rows.Count - 1).Cells("colqult").Value = dtInvoice.Rows(i)("qult").ToString
                    .Rows(.Rows.Count - 1).Cells("colsarual").Value = dtInvoice.Rows(i)("sarual").ToString
                    .Rows(.Rows.Count - 1).Cells("coltest_12").Value = dtInvoice.Rows(i)("test_12").ToString
                    .Rows(.Rows.Count - 1).Cells("coltest_11").Value = dtInvoice.Rows(i)("test_11").ToString
                    .Rows(.Rows.Count - 1).Cells("colinv_id").Value = dtInvoice.Rows(i)("inv_id").ToString
                    .Rows(.Rows.Count - 1).Cells("colNotes").Value = dtInvoice.Rows(i)("Notes").ToString
                    .Rows(.Rows.Count - 1).Cells("colB_Diamond_id").Value = dtInvoice.Rows(i)("B_Diamond_id").ToString
                    .Rows(.Rows.Count - 1).Cells("colActive").Value = dtInvoice.Rows(i)("Active").ToString
                End With
            Next
        End If
        Try
            If DGridItemDetels.RowCount <> 0 Then
                CivilIDForm.txtCID.Text = dtInvoice.Rows(0)("castomer_id").ToString
                Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [cacher_name] ='" & dtInvoice.Rows(0)("qult").ToString & "'")
                If dt1.Rows.Count > 0 Then
                    cmbCashier.DataSource = dt1
                    cmbCashier.DisplayMember = "cacher_name"
                    cmbCashier.ValueMember = "svil_id"
                End If
                'cmbCashier.DisplayMember = dtInvoice.Rows(0)("qult").ToString
                'dtpInvoiceDate.Value = CDate(dtInvoice.Rows(0)("date_creted"))
                btnPrint.Enabled = True
                gbInvoiceData.Enabled = True
                GetInvoicePyment()
                CalculatePrice()
                GetPayMethod()
                txtPriceReturn.Text = 0
                txtPriceReturn.Clear()

            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                gbInvoiceData.Enabled = False
                btnPrint.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
            Exit Sub
        End Try
    End Sub
    Private Sub cmbCashier_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCashier.MouseClick
        GetCashier()
    End Sub
    Private Sub DiamondDeleteEditeInvoce_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub DiamondDeleteEditeInvoce_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub DGridItemDetels_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridItemDetels.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If DGridItemDetels.Rows(e.RowIndex).Cells("colB_Diamond_id").Value = -1 Then Exit Sub
        If DGridItemDetels.Columns(e.ColumnIndex).Name = "ColDel" AndAlso e.RowIndex >= 0 Then
            Try
                If DGridItemDetels.RowCount = 1 Then
                    btnDeleteInvoice.PerformClick()
                    Exit Sub
                End If
                If DGridItemDetels.RowCount > 0 Then
                    If MsgBox("سوف يتم حذف صنف..اضغط نعم للاستمرار أو قم بإلغاء الأمر" & vbCrLf & "Item will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف صنف لايمكن استرداده" & vbCrLf & "Warning! Deleted an item can not be undone.") = MsgBoxResult.Ok Then
                        txtPriceReturn.Visible = True
                        DGridItemDetels.Rows(e.RowIndex).Cells("colActive").Value = "0"
                        DGridItemDetels.Rows(e.RowIndex).Visible = False
                        'txtPriceReturn.Text = DGridItemDetels.Rows(e.RowIndex).Cells("colbay_total_price").Value + Val(txtPriceReturn.Text)
                        CalculatePrice()
                    End If
                End If
            Catch ex As Exception
                MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
            End Try
        End If
    End Sub
    Private Sub DGridItemDetels_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridItemDetels.CellValueChanged
        CalculatePrice()
        'Dim t As Double = Val(txtCash.Text + txtKnet.Text) - Val(txtPriceReturn.Text)
        'txtPriceReturn.Text = t
    End Sub

    Private Sub txtInvoiceNo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.DropDown
        GetInvoiceNumber()
    End Sub
    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInvoice.Click
        If DGridItemDetels.RowCount > 0 Then
            If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                GlCommand.CommandText = "UPDATE [Bay_Diamond_mony] SET [Active] = '0' WHERE [saryal] = N'" & txtInvoiceNo.Text.Trim & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Buy_Diamond] SET [Active] = '0' WHERE [inv_id] = N'" & txtInvoiceNo.Text.Trim & "'"
                GlCommand.ExecuteNonQuery()
                Beep()
                Close()
            Else
                MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
                Beep()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub DGridItemDetels_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridItemDetels.CellContentClick

    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If CivilIDForm.SaveCustomerData() = False Then
            MsgBox("أدخل الرقم المدني بشكل صحيح" & vbCrLf & "Enter a valid Civil ID", , AppTitle)
            Exit Sub
        End If
        Try
            If Val(txtPriceRequired.Text) <> Val(txtKnet.Text.Trim) + Val(txtCash.Text.Trim) AndAlso rbtnCash.Checked = True Then
                MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , AppTitle)

                Exit Sub
            End If
            For i As Integer = 0 To DGridItemDetels.Rows.Count - 1
                GlCommand.CommandText = "UPDATE [Buy_Diamond] SET [castomer_id] = @castomer_id" &
                                              ",[val_gold] = @val_gold" &
                                              ",[GOLD_mezan] = @GOLD_mezan" &
                                              ",[bay_total_price] = @bay_total_price" &
                                              ",[DIMO_dep] = @DIMO_dep" &
                                              ",[DIM_na9awa] = @DIM_na9awa" &
                                              ",[DIMO_mezan] = @DIMO_mezan" &
                                              ",[ext_coler] = @ext_coler" &
                                              ",[qult] = @qult" &
                                              ",[sarual] = @sarual" &
                                              ",[test_12] = @test_12" &
                                              ",[test_11] = @test_11" &
                                              ",[inv_id] = @inv_id" &
                                              ",[Notes] = @Notes" &
                                              ",[Active] = @Active" &
                                              " WHERE [B_Diamond_id]= '" & DGridItemDetels.Rows(i).Cells("colB_Diamond_id").Value & "'"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@castomer_id", CivilIDForm.txtCID.Text.Trim)
                    .AddWithValue("@val_gold", DGridItemDetels.Rows(i).Cells("colval_gold").Value)
                    .AddWithValue("@GOLD_mezan", DGridItemDetels.Rows(i).Cells("colGOLD_mezan").Value)
                    .AddWithValue("@bay_total_price", DGridItemDetels.Rows(i).Cells("colbay_total_price").Value)
                    .AddWithValue("@DIMO_dep", DGridItemDetels.Rows(i).Cells("colDIMO_dep").Value)
                    .AddWithValue("@DIM_na9awa", DGridItemDetels.Rows(i).Cells("colDIM_na9awa").Value)
                    .AddWithValue("@DIMO_mezan", DGridItemDetels.Rows(i).Cells("colDIMO_mezan").Value)
                    .AddWithValue("@ext_coler", DGridItemDetels.Rows(i).Cells("colext_coler").Value)
                    .AddWithValue("@qult", DGridItemDetels.Rows(i).Cells("colqult").Value)
                    .AddWithValue("@sarual", DGridItemDetels.Rows(i).Cells("colsarual").Value)
                    .AddWithValue("@test_12", DGridItemDetels.Rows(i).Cells("coltest_12").Value)
                    .AddWithValue("@test_11", DGridItemDetels.Rows(i).Cells("coltest_11").Value)
                    .AddWithValue("@inv_id", DGridItemDetels.Rows(i).Cells("colinv_id").Value)
                    .AddWithValue("@Notes", DGridItemDetels.Rows(i).Cells("colNotes").Value)
                    .AddWithValue("@Active", DGridItemDetels.Rows(i).Cells("colActive").Value)
                End With
                GlCommand.ExecuteNonQuery()
            Next

            GlCommand.CommandText = " UPDATE [Bay_Diamond_mony] SET  " &
                                   " [total_price] = @total_price " &
                                   ",[cach] = @cach " &
                                   ",[kenet] = @kenet " &
                                   ",[arabik] = @arabik " &
                                   ",[date] = @date " &
                                   ",[English] = @English " &
                                   ",[Active] = @Active " &
                                   ",[PayMethod] = @PayMethod " &
                                   " WHERE [saryal] = N'" & txtInvoiceNo.Text.Trim & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@total_price", txtPriceRequired.Text.Trim)
                .AddWithValue("@cach", Val(txtCash.Text.Trim))
                .AddWithValue("@kenet", Val(txtKnet.Text.Trim))
                .AddWithValue("@arabik", kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@date", dtpInvoiceDate.Value)
                .AddWithValue("@English", ConvertNumberToENG(Val(txtPriceRequired.Text)))
                .AddWithValue("@Active", "1")
                .AddWithValue("@PayMethod", If(cmbPayMethod.SelectedIndex = -1, 0, cmbPayMethod.SelectedValue))
            End With
            GlCommand.ExecuteNonQuery()
            MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.Message, , AppTitle)
        End Try

    End Sub

    Private Sub txtPriceReturn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPriceReturn.TextChanged

        'txtPriceReturn.Text = Val(txtKnet.Text) + Val(txtCash.Text) - Val(txtPriceRequired.Text)
    End Sub

    Private Sub txtPriceRequired_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPriceRequired.TextChanged
        txtPriceReturn.Text = ""
        txtPriceReturn.Text = Val(txtKnet.Text + txtCash.Text) - Val(txtPriceRequired.Text)
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged

        txtPriceReturn.Text = Val(txtKnet.Text) + Val(txtCash.Text) - Val(txtPriceRequired.Text)
    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKnet.TextChanged

        txtPriceReturn.Text = Val(txtKnet.Text) + Val(txtCash.Text) - Val(txtPriceRequired.Text)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        Try
            With DiamondViewBuyInvoice
                txtInvoiceNo.Focus()
                .txtInvoiceNo.Text = Me.txtInvoiceNo.Text.Trim
                .InvoiceSearch()
                .ReportViewer1.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
    End Sub

    Private Sub txtInvoiceNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInvoiceNo.SelectedIndexChanged

    End Sub
End Class