Public Class frmPayInstallment
    Dim CashTotalPaid As Decimal
    Dim BankTotalPaid As Decimal
    Private Sub PayInstallment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If Saved = True Then
        'ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
        'End If
    End Sub
    Private Sub PayInstallment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        DGV_Style.ApplyGoldenStyle(grid) : DGV_Style.AutoFitColumns(grid)
        language_start(Name)
        GetPayMethod()
        FillInvoiceNo()
        GetCashier()
        cmbPayMethod.SelectedIndex = 0
        cmbCashier.SelectedIndex = 0
    End Sub
    Private Sub GetCashier()
        Dim dt1 As DataTable = GetRecordSet("SELECT [cacherID] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "cacherID"
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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Val(txtCash.Text) > 3000 Then
            MsgBox("According to Kuwaiti law, cash payments are not allowed more than three thousand Kuwaiti dinars in cash" & vbCrLf & "!حسب القانون الكويتي، لايسمح بالدفع كاش أكثر من ثلاثة آلاف دينار كويتي نقدًا")
            txtCash.Focus()
            txtCash.SelectAll()
            Exit Sub
        End If


        If Val(txtCash.Text) + Val(txtBank.Text) = 0 Then
            MsgBox("لا يمكن أن يكون المدفوع صفر" & vbCrLf & "Paid Amount Can't be Negative!", , AppTitle)
            Exit Sub
        End If



        If Val(txtCash.Text) < 0 OrElse Val(txtBank.Text) < 0 Then
            MsgBox("لا يمكن أن يكون المدفوع بالسالب" & vbCrLf & "Paid Amount Can't be Negative!", , AppTitle)
            Exit Sub
        End If

        If Val(txtCash.Text) + Val(txtBank.Text) > Val(txtRemaining.Text) Then
            MsgBox("المبلغ المدفوع أكبر من المطلوب" & vbCrLf & "Paid Amount is greater than required!", , AppTitle)
            Exit Sub
        End If

        If txtCash.Text = "" Then txtCash.Text = "0"
        If txtBank.Text = "" Then txtBank.Text = "0"

        Try
            GlCommand.CommandText = "INSERT INTO PayInstallment (" &
                                    "[InvoiceNo] , " &
                                    "[InvoiceType]  , " &
                                    "[PayPrice]  , " &
                                    "[KNET] , " &
                                    "[CASH] , " &
                                    "[PayDateTime] , " &
                                    "[PayMethod] ," &
                                    "[Cashier] ," &
                                    "[Item_Actv] " &
                                    ") VALUES" &
                                    "(" &
                                    "@InvoiceNo ," &
                                    "@InvoiceType ," &
                                    "@PayPrice ," &
                                    "@KNET ," &
                                    "@CASH ," &
                                    "@PayDateTime ," &
                                    "@PayMethod ," &
                                    "@Cashier ," &
                                    "@Item_Actv" &
                                    ")"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@InvoiceNo", lstInvoiceNo.SelectedItem.ToString)
                .AddWithValue("@InvoiceType", PayInstallmentType)
                .AddWithValue("@PayPrice", Val(txtCash.Text) + Val(txtBank.Text))
                .AddWithValue("@KNET", Val(txtBank.Text))
                .AddWithValue("@CASH", Val(txtCash.Text))
                .AddWithValue("@PayDateTime", Now)
                .AddWithValue("@PayMethod", cmbPayMethod.SelectedValue)
                .AddWithValue("@Cashier", cmbCashier.SelectedValue)
                .AddWithValue("@Item_Actv", "1")
            End With
            GlCommand.ExecuteNonQuery()
            Select Case PayInstallmentType.ToUpper
                Case "GOLD"
                    BankTotalPaid = Val(txtBank.Text) + Val(txtBankPaid.Text)
                    CashTotalPaid = Val(txtCash.Text) + Val(txtCashPaid.Text)
                    GlCommand.CommandText = "UPDATE [BAY] SET [KENT] = N'" & BankTotalPaid & "' , [CACH] = N'" & CashTotalPaid & "' WHERE BAY_SARYAL = N'" & lstInvoiceNo.SelectedItem.ToString & "'"
                    GlCommand.ExecuteNonQuery()
                Case "DIAMOND"

                    BankTotalPaid = Val(txtBank.Text) + Val(txtBankPaid.Text)
                    CashTotalPaid = Val(txtCash.Text) + Val(txtCashPaid.Text)
                    GlCommand.CommandText = "UPDATE [dimon_bay] SET [KENT] = N'" & BankTotalPaid & "' , [CACH] = N'" & CashTotalPaid & "',[balance]='" & Val(txtRemaining.Text.Trim) & "'WHERE BAY_SARYAL = N'" & lstInvoiceNo.SelectedItem.ToString & "'"
                    GlCommand.ExecuteNonQuery()
                Case "ACCESSORIES"
                    'GlCommand.CommandText = "UPDATE "
                    'GlCommand.ExecuteNonQuery()
            End Select

            Saved = True
            GetCustomerData(lstInvoiceNo.SelectedItem.ToString)
            GetInvoiceData(lstInvoiceNo.SelectedItem.ToString)
            GetInstallmentData(lstInvoiceNo.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                If Val(txtRemaining.Text) = 0 Then
                    GlCommand.CommandText = "UPDATE [BAY] SET [staytes] ='1',[balance]='0' WHERE [BAY_SARYAL]= N'" & lstInvoiceNo.SelectedItem.ToString & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم دفع كامل مبلغ الفاتوره" & vbCrLf & "The full amount of the invoice has been successfully paid!", , AppTitle)
                End If

            Case "DIAMOND"
                If Val(txtRemaining.Text) = 0 Then
                    GlCommand.CommandText = "UPDATE [dimon_bay] SET [staytes] ='0',[balance]='" & Val(txtRemaining.Text.Trim) & "' WHERE [BAY_SARYAL]= N'" & lstInvoiceNo.SelectedItem.ToString & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم دفع كامل مبلغ الفاتوره" & vbCrLf & "The full amount of the invoice has been successfully paid!", , AppTitle)
                End If
            Case "ACCESSORIES"
                'GlCommand.CommandText = "UPDATE "
                'GlCommand.ExecuteNonQuery()
        End Select


        Select Case PayInstallmentType.ToUpper
            Case "DIAMOND"
                GlCommand.CommandText = "UPDATE [dimon_bay] SET [balance]='" & Val(txtRemaining.Text.Trim) & "' WHERE [BAY_SARYAL]= N'" & lstInvoiceNo.SelectedItem.ToString & "'"
                GlCommand.ExecuteNonQuery()
        End Select
    End Sub

    Private Sub txtCash_Keyup(sender As Object, e As KeyEventArgs) Handles txtCash.KeyUp
        NegativeColor()
    End Sub

    Private Sub txtKnet_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBank.KeyUp
        NegativeColor()
    End Sub
    Private Sub NegativeColor()
        If Val(txtBank.Text) < 0 Then
            txtBank.ForeColor = Color.Red
        Else
            txtBank.ForeColor = Color.Black
        End If
        If Val(txtCash.Text) < 0 Then
            txtCash.ForeColor = Color.Red
        Else
            txtCash.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lstInvoiceNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInvoiceNo.SelectedIndexChanged
        If lstInvoiceNo.SelectedIndex = -1 Then
            gbInvoicePay.Enabled = False
            Exit Sub
        End If
        GetCustomerData(lstInvoiceNo.SelectedItem.ToString)
        GetInvoiceData(lstInvoiceNo.SelectedItem.ToString)
        GetInstallmentData(lstInvoiceNo.SelectedItem.ToString)
        If Val(txtRemaining.Text) = 0 Then
            gbInvoicePay.Enabled = False
        Else
            gbInvoicePay.Enabled = True
        End If

    End Sub
    Private Sub FillInvoiceNo()
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                Dim dt1 As DataTable = GetRecordSet("SELECT [BAY_SARYAL],[balance] FROM [BAY] WHERE ([staytes] = N'0')")
                If dt1.Rows.Count > 0 Then
                    lstInvoiceNo.Items.Clear()
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        lstInvoiceNo.Items.Add(dt1.Rows(i)("BAY_SARYAL").ToString)
                    Next
                End If
            Case "DIAMOND"
                Dim dt1 As DataTable = GetRecordSet("SELECT BAY_SARYAL,balance FROM dbo.dimon_bay WHERE (staytes = N'1')")
                If dt1.Rows.Count > 0 Then
                    lstInvoiceNo.Items.Clear()
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        lstInvoiceNo.Items.Add(dt1.Rows(i)("BAY_SARYAL").ToString)
                    Next
                End If
            Case "ACCESSORIES"
        End Select
    End Sub
    Private Sub GetCustomerData(InvoiceNo As String)
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                Dim dt1 As DataTable = GetRecordSet("SELECT [Castomerid],[CastomerNAme]FROM [ViwGoldInvoceReport] WHERE [BAY_SARYAL] like N'" & InvoiceNo & "'")
                If dt1.Rows.Count > 0 Then
                    txtCID.Text = dt1.Rows(0)("Castomerid").ToString
                    txtCustomerName.Text = dt1.Rows(0)("CastomerNAme").ToString
                End If

            Case "DIAMOND"
                Dim dt1 As DataTable = GetRecordSet("SELECT [castomr_id] , [CastomerNAme] FROM [for_dimon_inv] WHERE [descont] like N'" & InvoiceNo & "'")
                If dt1.Rows.Count > 0 Then
                    txtCID.Text = dt1.Rows(0)("castomr_id").ToString
                    txtCustomerName.Text = dt1.Rows(0)("CastomerNAme").ToString
                End If
            Case "ACCESSORIES"
        End Select
    End Sub
    Private Sub GetInvoiceData(InvoiceNo As String)
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                Dim dt1 As DataTable = GetRecordSet("SELECT [TOTAL_mony] , [KENT] , [CACH] FROM [BAY] WHERE [BAY_SARYAL] like N'" & InvoiceNo & "'")
                If dt1.Rows.Count > 0 Then
                    CashTotalPaid = Val(dt1.Rows(0)("CACH").ToString)
                    BankTotalPaid = Val(dt1.Rows(0)("KENT").ToString)
                    txtPrice.Text = dt1.Rows(0)("TOTAL_mony").ToString
                    txtCashPaid.Text = Format(CashTotalPaid, "0.000")
                    txtBankPaid.Text = Format(BankTotalPaid, "0.000")
                    txtTotalPaid.Text = Format(BankTotalPaid + CashTotalPaid, "0.000")
                    txtRemaining.Text = Format(Val(txtPrice.Text) - Val(txtTotalPaid.Text), "0.000")
                End If

            Case "DIAMOND"
                Dim dt1 As DataTable = GetRecordSet("SELECT [TOTAL_mony] , [KENT] , [CACH] FROM [dimon_bay] WHERE [BAY_SARYAL] like N'" & InvoiceNo & "'")
                If dt1.Rows.Count > 0 Then
                    CashTotalPaid = Val(dt1.Rows(0)("CACH").ToString)
                    BankTotalPaid = Val(dt1.Rows(0)("KENT").ToString)
                    txtPrice.Text = dt1.Rows(0)("TOTAL_mony").ToString
                    txtCashPaid.Text = Format(CashTotalPaid, "0.000")
                    txtBankPaid.Text = Format(BankTotalPaid, "0.000")
                    txtTotalPaid.Text = Format(BankTotalPaid + CashTotalPaid, "0.000")
                    txtRemaining.Text = Format(Val(txtPrice.Text) - Val(txtTotalPaid.Text), "0.000")
                End If
            Case "ACCESSORIES"
        End Select
    End Sub
    Private Sub GetInstallmentData(InvoiceNo As String)
        grid.Rows.Clear()
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                Dim dt1 As DataTable = GetRecordSet("SELECT [InvoiceNo] , [PayPrice] , [CASH] , [KNET] , [PayDateTime] , [PayMethodAr] , [PayMethodEn] , [cacher_name] , [Item_Actv] FROM [PayInstallmentVw] WHERE [InvoiceNo] like N'" & InvoiceNo & "' AND InvoiceType = N'" & PayInstallmentType & "'")
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        With grid
                            .Rows.Add()
                            .Rows(.Rows.Count - 1).Cells("colInvoiceNo").Value = InvoiceNo
                            .Rows(.Rows.Count - 1).Cells("colInvoiceType").Value = If(frmLogin.rbtnEn.Checked = True, PayInstallmentType, "ألماس")
                            .Rows(.Rows.Count - 1).Cells("colPayPrice").Value = dt1.Rows(i)("PayPrice").ToString
                            .Rows(.Rows.Count - 1).Cells("colCASH").Value = dt1.Rows(i)("CASH").ToString
                            .Rows(.Rows.Count - 1).Cells("colKNET").Value = dt1.Rows(i)("KNET").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayDateTime").Value = dt1.Rows(i)("PayDateTime").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayMethodAr").Value = dt1.Rows(i)("PayMethodAr").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayMethodEn").Value = dt1.Rows(i)("PayMethodEn").ToString
                            .Rows(.Rows.Count - 1).Cells("colCashier").Value = dt1.Rows(i)("cacher_name").ToString
                            .Rows(.Rows.Count - 1).Cells("colActive").Value = dt1.Rows(i)("Item_Actv").ToString
                        End With
                    Next

                End If

            Case "DIAMOND"
                Dim dt1 As DataTable = GetRecordSet("SELECT [InvoiceNo] , [PayPrice] , [CASH] , [KNET] , [PayDateTime] , [PayMethodAr] , [PayMethodEn] , [cacher_name] , [Item_Actv] FROM [PayInstallmentVw] WHERE [InvoiceNo] = N'" & InvoiceNo & "' AND InvoiceType = N'" & PayInstallmentType & "'")
                If dt1.Rows.Count > 0 Then
                    For i As Integer = 0 To dt1.Rows.Count - 1
                        With grid
                            .Rows.Add()
                            .Rows(.Rows.Count - 1).Cells("colInvoiceNo").Value = InvoiceNo
                            .Rows(.Rows.Count - 1).Cells("colInvoiceType").Value = If(frmLogin.rbtnEn.Checked = True, PayInstallmentType, "ألماس")
                            .Rows(.Rows.Count - 1).Cells("colPayPrice").Value = dt1.Rows(i)("PayPrice").ToString
                            .Rows(.Rows.Count - 1).Cells("colCASH").Value = dt1.Rows(i)("CASH").ToString
                            .Rows(.Rows.Count - 1).Cells("colKNET").Value = dt1.Rows(i)("KNET").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayDateTime").Value = dt1.Rows(i)("PayDateTime").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayMethodAr").Value = dt1.Rows(i)("PayMethodAr").ToString
                            .Rows(.Rows.Count - 1).Cells("colPayMethodEn").Value = dt1.Rows(i)("PayMethodEn").ToString
                            .Rows(.Rows.Count - 1).Cells("colCashier").Value = dt1.Rows(i)("cacher_name").ToString
                            .Rows(.Rows.Count - 1).Cells("colActive").Value = dt1.Rows(i)("Item_Actv").ToString
                        End With
                    Next

                End If
            Case "ACCESSORIES"
        End Select
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If lstInvoiceNo.SelectedItem.ToString = "" Then
            MsgBox("اختر فاتورة أولا" & vbCrLf & "Select Invoice No.", , AppTitle)
            Exit Sub
        End If
        Select Case PayInstallmentType.ToUpper
            Case "GOLD"
                Try
                    With GoldViewSellInvoice
                        .txtInvoiceNo.Text = lstInvoiceNo.SelectedItem.ToString
                        .InvoiceSearch()
                        .ReportViewer1.RefreshReport()
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            Case "DIAMOND"
                Try
                    With DiamondViewSellInvoice
                        .txtInvoiceNo.Text = lstInvoiceNo.SelectedItem.ToString
                        .InvoiceSearch()
                        .ReportViewer1.RefreshReport()
                        .ShowDialog()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            Case "ACCESSORIES"
        End Select

    End Sub
End Class