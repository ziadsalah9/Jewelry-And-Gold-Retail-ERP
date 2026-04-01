Imports PACICardLibrary
Imports Microsoft.Reporting.WinForms

Public Class DiamondSellEditRemove
    Dim BAY_ID As String = "0"
    Private Sub DiamondSellEditRemove_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Try
            CivilIDForm = New CivilID
            CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
            CivilIDForm.Bounds = New Rectangle(2, 60, 995, 255)
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
       
        btnPrint.Enabled = False
        gbInvoiceData.Enabled = False
        GetCashier()
        GetPayMethod()
    End Sub

    Public Sub payment_process()
        Dim wanted As Decimal
        Dim Cash As Decimal
        Dim KENT As Decimal
        Dim BALNCE As Decimal
        wanted = Val(txtPriceRequired.Text)
        Cash = Val(txtCash.Text)
        KENT = Val(txtKnet.Text)
        BALNCE = Cash + KENT - wanted
        txtPriceReturn.Text = BALNCE
        txtPriceReturn.Visible = True
        If txtPriceReturn.Text < 0 Then
            lblPriceReturn.Text = "المطلوب من العميل"
            lblPriceReturn.ForeColor = Color.Green
        ElseIf txtPriceReturn.Text > 0 Then
            lblPriceReturn.Text = "ارجع للعميل"
            lblPriceReturn.ForeColor = Color.Red
        End If
    End Sub

    Private Sub DiamondSellEditRemove_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If cmbCashier.Text = "اختر اسم الكاشير" OrElse cmbCashier.Text = "Select Cashier" Then
            MsgBox("اسم الكاشير لم يتم إدخاله" & vbCrLf & "Please Select Cashier", , "خطأ")
            cmbCashier.DroppedDown = True
            Exit Sub
        End If

        If CivilIDForm.SaveCustomerData() = False Then
            MsgBox("أدخل الرقم المدني بشكل صحيح" & vbCrLf & "Enter a valid Civil ID", , AppTitle)
            Exit Sub
        End If

        If Val(txtCash.Text) > 3000 Then
            MsgBox("According to Kuwaiti law, cash payments are not allowed more than three thousand Kuwaiti dinars in cash" & vbCrLf & "!حسب القانون الكويتي، لايسمح بالدفع كاش أكثر من ثلاثة آلاف دينار كويتي نقدًا", , AppTitle)
            txtCash.Focus()
            txtCash.SelectAll()
            Exit Sub
        End If
        'Try
        If Val(txtPriceRequired.Text) <> Val(txtKnet.Text) + Val(txtCash.Text) AndAlso rbtnCash.Checked = True Then
            MsgBox("يوجد اختلاف في السعر المطلوب والمدفوع" & vbCrLf & "Check Price and Paid amounts", , AppTitle)
            Exit Sub
        End If
        For i As Integer = 0 To grid.Rows.Count - 1
            GlCommand.CommandText = "UPDATE [dimon_invce] SET " &
                                    "[castomr_id] = @castomr_id , " &
                                    "[total] = @total , " &
                                    "[ar_taype] = @ar_taype , " &
                                    "[DIMO_Type] = @DIMO_Type , " &
                                    "[DIM_na9awa] = @DIM_na9awa , " &
                                    "[DIMO_mezan] = @DIMO_mezan , " &
                                    "[DIMO_coler] = @DIMO_coler , " &
                                    "[DIMO_qult] = @DIMO_qult , " &
                                    "[sarual] = @sarual , " &
                                    "[SoldItem] = @SoldItem , " &
                                    "[val_gold] = @val_gold , " &
                                    "[GOLD_mezan] = @GOLD_mezan , " &
                                    "[date_creted] = @date_creted , " &
                                    "[time] = @time , " &
                                    "[test_13] = @test_13 , " &
                                    "[test_14] = @test_14 , " &
                                    "[test_15] = @test_15 , " &
                                    "[test_16] = @test_16 , " &
                                    "[test_17] = @test_17 , " &
                                    "[test_18] = @test_18 , " &
                                    "[test_19] = @test_19 , " &
                                    "[test_110] = @test_110 , " &
                                    "[test_111] = @test_111 , " &
                                    "[test_112] = @test_112 , " &
                                    "[test_116] = @test_116 , " &
                                    "[test_117] = @test_117 , " &
                                    "[test_118] = @test_118 , " &
                                    "[test_119] = @test_119 , " &
                                    "[notes] = @notes , " &
                                    "[Item_Actv] = @Item_Actv , " &
                                    "[staytes] = @staytes " &
                                    "WHERE [dim_inv_id] = '" & grid.Rows(i).Cells("coldim_inv_id").Value & "'"

            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@castomr_id", CivilIDForm.txtCID.Text.Trim)
                .AddWithValue("@total", grid.Rows(i).Cells("coltotal").Value)
                .AddWithValue("@ar_taype", kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@DIMO_Type", grid.Rows(i).Cells("colDIMO_Type").Value)
                .AddWithValue("@DIM_na9awa", grid.Rows(i).Cells("colDIM_na9awa").Value)
                .AddWithValue("@DIMO_mezan", grid.Rows(i).Cells("colDIMO_mezan").Value)
                .AddWithValue("@DIMO_coler", grid.Rows(i).Cells("colDIMO_coler").Value)
                .AddWithValue("@DIMO_qult", grid.Rows(i).Cells("colDIMO_qult").Value)
                .AddWithValue("@sarual", grid.Rows(i).Cells("colsarual").Value)
                .AddWithValue("@SoldItem", grid.Rows(i).Cells("colDIMO_Type").Value)
                .AddWithValue("@val_gold", grid.Rows(i).Cells("colval_gold").Value)
                .AddWithValue("@GOLD_mezan", grid.Rows(i).Cells("colGOLD_mezan").Value)
                .AddWithValue("@date_creted", DateToSave(dtpInvoiceDate.Value))
                .AddWithValue("@time", Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss tt"))
                .AddWithValue("@test_13", grid.Rows(i).Cells("coltest_13").Value)
                .AddWithValue("@test_14", grid.Rows(i).Cells("coltest_14").Value)
                .AddWithValue("@test_15", grid.Rows(i).Cells("coltest_15").Value)
                .AddWithValue("@test_16", grid.Rows(i).Cells("coltest_16").Value)
                .AddWithValue("@test_17", grid.Rows(i).Cells("coltest_17").Value)
                .AddWithValue("@test_18", grid.Rows(i).Cells("coltest_18").Value)
                .AddWithValue("@test_19", grid.Rows(i).Cells("coltest_19").Value)
                .AddWithValue("@test_110", grid.Rows(i).Cells("coltest_110").Value)
                .AddWithValue("@test_111", grid.Rows(i).Cells("coltest_111").Value)
                .AddWithValue("@test_112", DBNull.Value)
                .AddWithValue("@test_116", grid.Rows(i).Cells("coltest_116").Value)
                .AddWithValue("@test_117", grid.Rows(i).Cells("coltest_117").Value)
                .AddWithValue("@test_118", cmbCashier.SelectedValue)
                .AddWithValue("@test_119", grid.Rows(i).Cells("coltest_119").Value)
                .AddWithValue("@notes", grid.Rows(i).Cells("colnotes").Value)
                .AddWithValue("@Item_Actv", grid.Rows(i).Cells("colItem_Actv").Value)
                .AddWithValue("@staytes", grid.Rows(i).Cells("colstaytes").Value)
            End With
            GlCommand.ExecuteNonQuery()
        Next
        'Format(dtpInvoiceDate.Value, "dd/MM/yyyy hh:mm:ss").ToString)
        GlCommand.CommandText = "UPDATE [dimon_bay] SET " &
                                "[BAY_SARYAL] = @BAY_SARYAL , " &
                                "[TOTAL_mony] = @TOTAL_mony , " &
                                "[KENT] = @KENT , " &
                                "[CACH] = @CACH , " &
                                "[arbic_tayb] = @arbic_tayb , " &
                                "[balance] = @balance , " &
                                "[staytes] = @staytes , " &
                                "[English_tayb] = @English_tayb , " &
                                "[PayMethod] = @PayMethod , " &
                                "[Item_Actv] = 1 " &
                                "WHERE [BAY_ID] = N'" & BAY_ID & "'"

        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@BAY_SARYAL", txtInvoiceNo.Text.Trim)
            .AddWithValue("@TOTAL_mony", Val(txtPriceRequired.Text.Trim))
            .AddWithValue("@KENT", Val(txtKnet.Text.Trim))
            .AddWithValue("@CACH", Val(txtCash.Text.Trim))
            .AddWithValue("@arbic_tayb", kokotxt(Val(txtPriceRequired.Text), CurrencyMainAr, CurrencySubAr, True))
            .AddWithValue("@balance", Val(txtPriceRequired.Text.Trim) - Val(txtKnet.Text.Trim) - Val(txtCash.Text.Trim))
            .AddWithValue("@staytes", If(rbtnInstallment.Checked = True, "1", "0"))
            .AddWithValue("@English_tayb", ConvertNumberToENG(Val(txtPriceRequired.Text)))
            .AddWithValue("@PayMethod", If(cmbPayMethod.SelectedIndex = -1, 0, cmbPayMethod.SelectedValue))
        End With
        GlCommand.ExecuteNonQuery()
        MsgBox("تم الحفظ بنجاح" & vbCrLf & "Save successfully", , AppTitle)
        'Catch ex As Exception
        '    MsgBox(ex.Message, , AppTitle)
        'End Try

    End Sub
    Private Sub ClearInvoice()
        grid.Rows.Clear()
        txtPriceReturn.Text = "0"
        txtPriceRequired.Text = "0"
        txtCash.Text = "0"
        txtKnet.Text = "0"
        cmbPayMethod.SelectedIndex = -1
        rbtnCash.Checked = False
        rbtnInstallment.Checked = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
       

        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        Try
            With DiamondViewSellInvoice
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


    Private Sub btnDeleteInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteInvoice.Click
        If grid.RowCount > 0 Then
            If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                GlCommand.CommandText = "UPDATE [dimon_invce] SET [Item_Actv] = '0' WHERE [descont] = '" & grid.Rows(0).Cells("coldescont").Value & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [dimon_bay] SET [Item_Actv] = '0' WHERE [BAY_SARYAL] = '" & grid.Rows(0).Cells("coldescont").Value & "'"
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

    Private Sub btnAddItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddItem.Click
        If grid.Rows.Count > 0 Then
            DiamondEditAddItem.ShowDialog()
            CalculatePrice()
        Else
            Beep()
        End If

    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewInvoice()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        ViewInvoice()
    End Sub
    Public Sub ViewInvoice()
        ClearInvoice()
        If txtInvoiceNo.Text.Trim = "" Then
            Exit Sub
        End If

        Try
            Dim dtInvoice As DataTable = GetRecordSet("SELECT [dim_inv_id], [dimo_id], [castomr_id], [descont] ,[total], [ar_taype], [DIMO_Type], [DIM_na9awa], " &
                                                      "[DIMO_mezan] , [DIMO_coler] , [DIMO_qult] , [sarual] , [val_gold] , [GOLD_mezan] , [user_creted] , [date_creted] , [time], " &
                                                      "[dim_foto] , [test_13] , [test_14] , [test_15] , [test_16] , [test_17] , [test_18] , [test_19] , [test_110] , [test_111], " &
                                                      "[test_112] , [test_116] , [test_117] , [test_118] , [test_119] , [notes] , [Item_Actv] , [staytes] , [GramPrice] , [SoldItem]," &
                                                      "[Cut1] , [Clarity1] , [Cut2] , [Clarity2] , [Cut3] , [Clarity3] , [IsDiamond1] , [IsDiamond2] , [IsDiamond3] " &
                                                      "FROM [dimon_invce] WHERE [descont] = N'" & txtInvoiceNo.Text.Trim & "' AND Item_Actv = '1'")
            If dtInvoice.Rows.Count > 0 Then
                For i As Integer = 0 To dtInvoice.Rows.Count - 1
                    With grid
                        .Rows.Add()
                        .Rows(.Rows.Count - 1).Cells("coldim_inv_id").Value = dtInvoice.Rows(i)("dim_inv_id").ToString
                        .Rows(.Rows.Count - 1).Cells("coldimo_id").Value = dtInvoice.Rows(i)("dimo_id").ToString
                        .Rows(.Rows.Count - 1).Cells("colcastomr_id").Value = dtInvoice.Rows(i)("castomr_id").ToString
                        .Rows(.Rows.Count - 1).Cells("coldescont").Value = dtInvoice.Rows(i)("descont").ToString
                        .Rows(.Rows.Count - 1).Cells("coltotal").Value = dtInvoice.Rows(i)("total").ToString
                        .Rows(.Rows.Count - 1).Cells("colar_taype").Value = dtInvoice.Rows(i)("ar_taype").ToString
                        .Rows(.Rows.Count - 1).Cells("colDIMO_Type").Value = dtInvoice.Rows(i)("DIMO_Type").ToString
                        .Rows(.Rows.Count - 1).Cells("colDIM_na9awa").Value = dtInvoice.Rows(i)("DIM_na9awa").ToString
                        .Rows(.Rows.Count - 1).Cells("colDIMO_mezan").Value = dtInvoice.Rows(i)("DIMO_mezan").ToString
                        .Rows(.Rows.Count - 1).Cells("colDIMO_coler").Value = dtInvoice.Rows(i)("DIMO_coler").ToString
                        .Rows(.Rows.Count - 1).Cells("colDIMO_qult").Value = dtInvoice.Rows(i)("DIMO_qult").ToString
                        .Rows(.Rows.Count - 1).Cells("colsarual").Value = dtInvoice.Rows(i)("sarual").ToString
                        .Rows(.Rows.Count - 1).Cells("colval_gold").Value = dtInvoice.Rows(i)("val_gold").ToString
                        .Rows(.Rows.Count - 1).Cells("colGOLD_mezan").Value = dtInvoice.Rows(i)("GOLD_mezan").ToString
                        .Rows(.Rows.Count - 1).Cells("coluser_creted").Value = dtInvoice.Rows(i)("user_creted").ToString
                        .Rows(.Rows.Count - 1).Cells("coldate_creted").Value = dtInvoice.Rows(i)("date_creted").ToString
                        .Rows(.Rows.Count - 1).Cells("coltime").Value = DateTimeToView(dtpInvoiceDate.Value)
                        .Rows(.Rows.Count - 1).Cells("coldim_foto").Value = dtInvoice.Rows(i)("dim_foto").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_13").Value = dtInvoice.Rows(i)("test_13").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_14").Value = dtInvoice.Rows(i)("test_14").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_15").Value = dtInvoice.Rows(i)("test_15").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_16").Value = dtInvoice.Rows(i)("test_16").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_17").Value = dtInvoice.Rows(i)("test_17").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_18").Value = dtInvoice.Rows(i)("test_18").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_19").Value = dtInvoice.Rows(i)("test_19").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_110").Value = dtInvoice.Rows(i)("test_110").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_111").Value = dtInvoice.Rows(i)("test_111").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_112").Value = dtInvoice.Rows(i)("test_112").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_116").Value = dtInvoice.Rows(i)("test_116").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_117").Value = dtInvoice.Rows(i)("test_117").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_118").Value = dtInvoice.Rows(i)("test_118").ToString
                        .Rows(.Rows.Count - 1).Cells("coltest_119").Value = dtInvoice.Rows(i)("test_119").ToString
                        .Rows(.Rows.Count - 1).Cells("colnotes").Value = dtInvoice.Rows(i)("notes").ToString
                        .Rows(.Rows.Count - 1).Cells("colstaytes").Value = dtInvoice.Rows(i)("staytes").ToString
                        .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = dtInvoice.Rows(i)("GramPrice").ToString
                        .Rows(.Rows.Count - 1).Cells("colSoldItem").Value = dtInvoice.Rows(i)("SoldItem").ToString
                        .Rows(.Rows.Count - 1).Cells("colCut1").Value = dtInvoice.Rows(i)("Cut1").ToString
                        .Rows(.Rows.Count - 1).Cells("colClarity1").Value = dtInvoice.Rows(i)("Clarity1").ToString
                        .Rows(.Rows.Count - 1).Cells("colCut2").Value = dtInvoice.Rows(i)("Cut2").ToString
                        .Rows(.Rows.Count - 1).Cells("colClarity2").Value = dtInvoice.Rows(i)("Clarity2").ToString
                        .Rows(.Rows.Count - 1).Cells("colCut3").Value = dtInvoice.Rows(i)("Cut3").ToString
                        .Rows(.Rows.Count - 1).Cells("colClarity3").Value = dtInvoice.Rows(i)("Clarity3").ToString
                        .Rows(.Rows.Count - 1).Cells("colIsDiamond1").Value = dtInvoice.Rows(i)("IsDiamond1").ToString
                        .Rows(.Rows.Count - 1).Cells("colIsDiamond2").Value = dtInvoice.Rows(i)("IsDiamond2").ToString
                        .Rows(.Rows.Count - 1).Cells("colIsDiamond3").Value = dtInvoice.Rows(i)("IsDiamond3").ToString
                        .Rows(.Rows.Count - 1).Cells("colItem_Actv").Value = 1 'Active Item
                    End With
                Next
            End If

            Dim dtInvoicePay As DataTable = GetRecordSet("SELECT [BAY_ID] , [BAY_SARYAL] , [TOTAL_mony] , [KENT] , [CACH] , [arbic_tayb] , [balance] , [staytes] , [English_tayb] , [PayMethod] , [Item_Actv] FROM [dimon_bay] WHERE [BAY_SARYAL] = N'" & txtInvoiceNo.Text.Trim & "' AND Item_Actv = '1'")
            If dtInvoicePay.Rows.Count > 0 Then
                BAY_ID = dtInvoicePay.Rows(0)("BAY_ID").ToString
                txtPriceReturn.Text = "0.000"
                txtPriceRequired.Text = Math.Round(Val(dtInvoicePay.Rows(0)("TOTAL_mony").ToString), 3)
                txtCash.Text = Math.Round(Val(dtInvoicePay.Rows(0)("CACH").ToString), 3)
                txtKnet.Text = Math.Round(Val(dtInvoicePay.Rows(0)("KENT").ToString), 3)
                cmbPayMethod.SelectedValue = If(dtInvoicePay.Rows(0)("PayMethod").ToString = "", 0, dtInvoicePay.Rows(0)("PayMethod").ToString)
                rbtnCash.Checked = If(dtInvoicePay.Rows(0)("staytes").ToString = "1", False, True)
                rbtnInstallment.Checked = If(dtInvoicePay.Rows(0)("staytes").ToString = "1", True, False)
            End If




            If grid.RowCount <> 0 Then
                CivilIDForm.txtCID.Text = dtInvoice.Rows(0)("castomr_id").ToString
                cmbCashier.SelectedValue = dtInvoice.Rows(0)("test_118").ToString
                dtpInvoiceDate.Value = CDate(dtInvoice.Rows(0)("date_creted"))
                btnPrint.Enabled = True
                gbInvoiceData.Enabled = True
            Else
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                gbInvoiceData.Enabled = False
                btnPrint.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Rows(e.RowIndex).Cells("coldim_inv_id").Value = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            Try
                If grid.RowCount = 1 Then
                    btnDeleteInvoice.PerformClick()
                    Exit Sub
                End If
                If grid.RowCount > 0 Then
                    If MsgBox("سوف يتم حذف صنف..اضغط نعم للاستمرار أو قم بإلغاء الأمر" & vbCrLf & "Item will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف صنف لايمكن استرداده" & vbCrLf & "Warning! Deleted an item can not be undone.") = MsgBoxResult.Ok Then
                        txtPriceReturn.Visible = True
                        grid.Rows(e.RowIndex).Cells("colItem_Actv").Value = "0"
                        grid.Rows(e.RowIndex).Visible = False
                        txtPriceReturn.Text = grid.Rows(e.RowIndex).Cells("coltotal").Value + Val(txtPriceReturn.Text)
                        CalculatePrice()
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
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub grid_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellEndEdit
        If e.ColumnIndex = grid.Columns("coltotal").Index Then
            CalculatePrice()
        End If
    End Sub
    Private Sub CalculatePrice()
        Dim TotalPrice As Decimal
        For i As Integer = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells("colItem_Actv").Value = "1" Then
                TotalPrice += Val(grid.Rows(i).Cells("coltotal").Value)
            End If
        Next
        txtPriceRequired.Text = TotalPrice
    End Sub
End Class