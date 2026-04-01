Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class GoldBuyPersonPay
    Public CurrentInvoiceNo As String = "0"
    'Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
    Dim RptPath As String
    Dim Stautes As String
    Dim AutoClose As String
    Dim Multiplepayment As Boolean
    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            RptPath = dt1.Rows(0)("SET_INVARCHR158").ToString
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
            AutoClose = dt1.Rows(0)("SET_INVARCHR144").ToString
            Multiplepayment = dt1.Rows(0)("SET9").ToString
        End If
    End Sub
    Private Sub GoldBuyPersonPay_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved Then GoldBuyPerson.Close()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub GoldBuyPersonPay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ApplyIconsToButtons(Me)
        GetSettings()
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        rbCash.Checked = True
        btnPrint.Enabled = False
        txtKnet.Text = "0"
        txtCash.Text = "0"
        btnPDF.Visible = False
        If Settings.SET_INVARCHR144TextBox.Text <> "0" Then
            chkAutoClose.Checked = True
        End If
        GetPayMethod()
        GetPayMethodSelect()
        RadCastm.Checked = True
        GetCastomAccReportPath()
        
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
            End If
        End If
        
        txtReceiptNo.Text = If(frmLogin.rbtnAr.Checked = True, "رقم ايصال الدفع", "Payment Receipt Number")
        
        txtPrice.Text = Val(GoldBuyPerson.TextBox3.Text)
        txtCash.Text = If(String.IsNullOrWhiteSpace(GoldBuyPerson.TextBox3.Text) OrElse Val(GoldBuyPerson.TextBox3.Text) = 0, 0, GoldBuyPerson.TextBox3.Text.Trim())
        txtKnet.Text = Math.Abs(Val(txtRemaining.Text))

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)


        Try
            txtKnet.Text = Val(txtPrice.Text)
            txtCash.Text = "0"
            txtBank1.Text = ""
            txtBank2.Text = ""
            txtBank3.Text = ""
            txtBank4.Text = ""
            NegativeColor()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub RadCastm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCastm.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAcc.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub GetCastomAccReportPath()
        Dim GetCastomAccPath As String = RptPath
        If RadCastm.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = GetCastomAccPath
        ElseIf RadAcc.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Replace(GetCastomAccPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub
    Private Sub AddToItem()
        Dim BarcodLast As String
        For i = 0 To GoldBuyPerson.grid.Rows.Count - 1
            Dim dt1 As DataTable = GetRecordSet("SELECT ID +1 AS Barcod FROM FO_min WHERE ID=(SELECT max(ID) FROM FO_min)")
            If dt1.Rows.Count > 0 Then
                BarcodLast = Val(dt1.Rows(0)(0).ToString)
            End If
            Try
                If GoldBuyPerson.grid.Rows(i).Cells("colAddToItem").Value = "1" Then
                    GoldBuyPerson.grid.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                    GoldBuyPerson.grid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    GlCommand.CommandText = "INSERT INTO [FO_min]" & vbCrLf &
                                            "([userID]" & vbCrLf &
                                            ",[FO_name]" & vbCrLf &
                                            ",[FO_gram]" & vbCrLf &
                                            ",[Gram_valu]" & vbCrLf &
                                            ",[date_care]" & vbCrLf &
                                            ",[Item_Actv]" & vbCrLf &
                                            ",[FO_desp]" & vbCrLf &
                                            ",[FO_gramMade]" & vbCrLf &
                                            ",[FO_made]" & vbCrLf &
                                            ",[FO_extras]" & vbCrLf &
                                            ",[FO_totalPrice]" & vbCrLf &
                                            ",[Qty]" & vbCrLf &
                                            ",[BarCode])" & vbCrLf &
                                            " VALUES" & vbCrLf &
                                            "(@userID" & vbCrLf &
                                            ",@FO_name" & vbCrLf &
                                            ",@FO_gram" & vbCrLf &
                                            ",@Gram_valu" & vbCrLf &
                                            ",@date_care" & vbCrLf &
                                            ",@Item_Actv" & vbCrLf &
                                            ",@FO_desp" & vbCrLf &
                                            ",@FO_gramMade" & vbCrLf &
                                            ",@FO_made" & vbCrLf &
                                            ",@FO_extras" & vbCrLf &
                                            ",@FO_totalPrice" & vbCrLf &
                                            ",@Qty" & vbCrLf &
                                            ",@BarCode)"
                    With GlCommand.Parameters
                        .Clear()
                        .AddWithValue("@userID", frmLogin.User_nameTextBox.Text)
                        .AddWithValue("@FO_name", GoldBuyPerson.grid.Rows(i).Cells("colItem_Des").Value)
                        .AddWithValue("@FO_gram", GoldBuyPerson.grid.Rows(i).Cells("colbay_mazan").Value)
                        .AddWithValue("@Gram_valu", GoldBuyPerson.grid.Rows(i).Cells("colbay_val").Value)
                        .AddWithValue("@date_care", DateToSave(Date.Now))
                        .AddWithValue("@Item_Actv", "1")
                        .AddWithValue("@FO_desp", "00")
                        .AddWithValue("@FO_gramMade", "00")
                        .AddWithValue("@FO_made", "00")
                        .AddWithValue("@FO_extras", "00")
                        .AddWithValue("@FO_totalPrice", "00")
                        .AddWithValue("@Qty", GoldBuyPerson.grid.Rows(i).Cells("colQunt").Value)
                        .AddWithValue("@BarCode", BarcodLast)
                    End With
                    GlCommand.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                RecordRrrors(ex.ToString)
            End Try
        Next
    End Sub

    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
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
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim ReceiptNo As String = If(txtReceiptNo.Text = "رقم ايصال الدفع" Or txtReceiptNo.Text = "Payment Receipt Number", "", txtReceiptNo.Text.Trim())
        
        If Val(txtRemaining.Text) > 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        GetReportPath()
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 OrElse Val(txtBank1.Text) < 0 OrElse Val(txtBank2.Text) < 0 OrElse Val(txtBank3.Text) < 0 OrElse Val(txtBank4.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If rbCash.Checked = True Then
            If Val(txtCash.Text) + Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text) <> Val(txtPrice.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
                MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
                Exit Sub
            End If
        ElseIf rbCredit.Checked = True Then
        End If
        Dim dt1 As DataTable = GetRecordSet("SELECT ID_MAX +1 AS ID_MAX FROM bay_goled_mony WHERE bay_id=(SELECT max(bay_id) FROM bay_goled_mony)")
        If dt1.Rows.Count > 0 Then
            CurrentInvoiceNo = Val(dt1.Rows(0)(0).ToString)
        Else
            CurrentInvoiceNo = "1"
        End If
        Try
            txtInvoiceNo.Text = InvoiceStringNo(Val(CurrentInvoiceNo))
            GlCommand.CommandText = " INSERT INTO [bay_goled_mony]" &
                                               " ([saryal]" &
                                               " ,[total_price]" &
                                               " ,[cach]" &
                                               " ,[kenet]" &
                                               " ,[arabik]" &
                                               " ,[date]" &
                                               " ,[English]" &
                                               " ,[Cashier]" &
                                               " ,[TIME_INV]" &
                                               " ,[INV_Actv]" &
                                               " ,[PayMethod]" &
                                               " ,[PayMethod1]" &
                                               " ,[PayMethod2]" &
                                               " ,[PayMethod3]" &
                                               " ,[PayMethod4]" &
                                               " ,[Bank1]" &
                                               " ,[Bank2]" &
                                               " ,[Bank3]" &
                                               " ,[Bank4]" &
                                               " ,[PaymentReceipt]" &
                                               " ,[PaymentTransNumber]" &
                                               " ,[ID_MAX])" &
                                         "VALUES" &
                                               "(@saryal" &
                                               " ,@total_price" &
                                               " ,@cach" &
                                               " ,@kenet" &
                                               " ,@arabik" &
                                               " ,@date" &
                                               " ,@English" &
                                               " ,@Cashier" &
                                               " ,@TIME_INV" &
                                               " ,@INV_Actv" &
                                               " ,@PayMethod" &
                                               " ,@PayMethod1" &
                                               " ,@PayMethod2" &
                                               " ,@PayMethod3" &
                                               " ,@PayMethod4" &
                                               " ,@Bank1" &
                                               " ,@Bank2" &
                                               " ,@Bank3" &
                                               " ,@Bank4" &
                                               " ,@PaymentReceipt" &
                                               " ,@PaymentTransNumber" &
                                               " ,@ID_MAX)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@saryal", InvoiceStringNo(Val(CurrentInvoiceNo)))
                .AddWithValue("@total_price", Val(txtPrice.Text))
                .AddWithValue("@cach", Val(txtCash.Text))
                .AddWithValue("@kenet", If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)))
                .AddWithValue("@arabik", kokotxt(Val(GoldBuyPerson.TextBox3.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@date", GoldBuyPerson.dtDate.Value)
                .AddWithValue("@English", ConvertNumberToENG(Val(GoldBuyPerson.TextBox3.Text)))
                .AddWithValue("@Cashier", GoldBuyPerson.cmbCashier.SelectedValue)
                .AddWithValue("@TIME_INV", Format(GoldBuyPerson.dtDate.Value, "dd/MM/yyyy hh:mm:ss"))
                .AddWithValue("@INV_Actv", "1")
                .AddWithValue("@PayMethod", cmbPayMethod.SelectedValue)
                .AddWithValue("@PayMethod1", cmbPayMethod1.SelectedValue)
                .AddWithValue("@PayMethod2", cmbPayMethod2.SelectedValue)
                .AddWithValue("@PayMethod3", cmbPayMethod3.SelectedValue)
                .AddWithValue("@PayMethod4", cmbPayMethod4.SelectedValue)
                .AddWithValue("@Bank1", If(IsDBNull(txtBank1.Text.Trim), "0", Val(txtBank1.Text.Trim)))
                .AddWithValue("@Bank2", If(IsDBNull(txtBank2.Text.Trim), "0", Val(txtBank2.Text.Trim)))
                .AddWithValue("@Bank3", If(IsDBNull(txtBank3.Text.Trim), "0", Val(txtBank3.Text.Trim)))
                .AddWithValue("@Bank4", If(IsDBNull(txtBank4.Text.Trim), "0", Val(txtBank4.Text.Trim)))
                .Add("@PaymentReceipt", SqlDbType.Image).Value = If(PicAddReceipt.Image Is Nothing, DBNull.Value, ImageToByte(PicAddReceipt.Image))
                .AddWithValue("@PaymentTransNumber", ReceiptNo)
                .AddWithValue("@ID_MAX", Val(CurrentInvoiceNo))
            End With
            GlCommand.ExecuteNonQuery()
            For I As Integer = 0 To GoldBuyPerson.grid.Rows.Count - 1
                GlCommand.CommandText = "INSERT INTO  [Buy_Gold]" &
                                                              "([castomer_id]" &
                                                              " ,[bay_val]" &
                                                              " ,[bay_mazan]" &
                                                              " ,[bay_gram_price]" &
                                                              " ,[bay_total_price]" &
                                                              " ,[inv_id]" &
                                                              " ,[Item_Des]" &
                                                              " ,[INV_Actv]" &
                                                              " ,[AddToItem]" &
                                                              " ,[Note]" &
                                                              " ,[GoldWeight999]" &
                                                              " ,[GoldCaret999]" &
                                                              " ,[Qunt])" &
                                                        " VALUES" &
                                                              " (@castomer_id " &
                                                              " ,@bay_val " &
                                                              " ,@bay_mazan " &
                                                              " ,@bay_gram_price " &
                                                              " ,@bay_total_price " &
                                                              " ,@inv_id " &
                                                              " ,@Item_Des " &
                                                              " ,@INV_Actv" &
                                                              " ,@AddToItem" &
                                                              " ,@Note" &
                                                              " ,@GoldWeight999" &
                                                              " ,@GoldCaret999" &
                                                              " ,@Qunt)"

                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@castomer_id", GoldBuyPerson.grid.Rows(I).Cells("colcastomer_id").Value)
                    .AddWithValue("@bay_val", GoldBuyPerson.grid.Rows(I).Cells("colbay_val").Value)
                    .AddWithValue("@bay_mazan", GoldBuyPerson.grid.Rows(I).Cells("colbay_mazan").Value)
                    .AddWithValue("@bay_gram_price", GoldBuyPerson.grid.Rows(I).Cells("colbay_gram_price").Value)
                    .AddWithValue("@bay_total_price", GoldBuyPerson.grid.Rows(I).Cells("colTotalPrice").Value)
                    .AddWithValue("@inv_id", InvoiceStringNo(Val(CurrentInvoiceNo)))
                    .AddWithValue("@Item_Des", GoldBuyPerson.grid.Rows(I).Cells("colItem_Des").Value)
                    .AddWithValue("@INV_Actv", "1")
                    .AddWithValue("@AddToItem", GoldBuyPerson.grid.Rows(I).Cells("colAddToItem").Value)
                    .AddWithValue("@Note", GoldBuyPerson.txtNote.Text.Trim)
                    .AddWithValue("@GoldWeight999", GoldBuyPerson.grid.Rows(I).Cells("colGoldWeight999").Value)
                    .AddWithValue("@GoldCaret999", GoldBuyPerson.grid.Rows(I).Cells("colGoldCaret999").Value)
                    .AddWithValue("@Qunt", GoldBuyPerson.grid.Rows(I).Cells("colQunt").Value)
                End With
                GlCommand.ExecuteNonQuery()
            Next
        Catch ex As Exception
          MsgBox(ex.Message)
            RecordRrrors(ex.ToString)
            Return
        End Try
        AddToItem()
        GetReportPath()
        Dim DT As DataTable = GetRecordSet("select * from ViwGoldPurchaseInvoice  WHERE  [inv_id]='" & InvoiceStringNo(Val(CurrentInvoiceNo)) & "'")
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            SetReportPaper(ReportViewer1)
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
        btnPrint.Enabled = True
        btnSave.Enabled = False
        txtKnet.Enabled = False
        txtCash.Enabled = False
        rbCash.Enabled = False
        rbCredit.Enabled = False
        btnPDF.Visible = True
        Saved = True
        cmbPayMethod.Enabled = False
        BtnAddReceipt.Enabled = False
        txtBank1.Enabled = False
        txtBank2.Enabled = False
        txtBank3.Enabled = False
        txtBank4.Enabled = False
        cmbPayMethod1.Enabled = False
        cmbPayMethod2.Enabled = False
        cmbPayMethod3.Enabled = False
        cmbPayMethod4.Enabled = False
        txtReceiptNo.Enabled = False
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        'Try
        '    ReportViewer1.PrintDialog()
        '    GoldBuyPerson.Close()
        'Catch ex As Exception
        '    MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        '    RecordRrrors(ex.ToString)
        'End Try

        Saved = True
        PrintReport()
    End Sub
    Private Sub PrintReport()
        Try
            Dim printerSettings As New PrinterSettings()
            printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
            ReportViewer1.PrinterSettings = printerSettings
            ReportViewer1.PrintDialog()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtKnet.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPrice_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtKnet.Text = Val(txtPrice.Text)
        txtCash.Text = "0"
        txtBank1.Text = ""
        txtBank2.Text = ""
        txtBank3.Text = ""
        txtBank4.Text = ""
        NegativeColor()
    End Sub

    Private Sub txtCash_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCash.KeyUp
        If rbCash.Checked = True Then
            If Multiplepayment = 0 Then
                Dim Cash As Decimal = Val(txtCash.Text)
                Dim Price As Decimal = Val(txtPrice.Text)
                txtKnet.Text = Price - Cash
                NegativeColor()
            ElseIf Multiplepayment = 1 Then
                NegativeColor()
            End If
        ElseIf rbCredit.Checked = True Then
        End If
    End Sub

    Private Sub txtKnet_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKnet.KeyUp
        If rbCash.Checked = True Then
            If Multiplepayment = 0 Then
                Dim KNET As Decimal = Val(txtKnet.Text)
                Dim Price As Decimal = Val(txtPrice.Text)
                txtCash.Text = Price - KNET
                NegativeColor()
            ElseIf Multiplepayment = 1 Then
                NegativeColor()
            End If
        ElseIf rbCredit.Checked = True Then
        End If
    End Sub
    Private Sub NegativeColor()
        If Val(txtKnet.Text) < 0 Then
            txtKnet.ForeColor = Color.Red
        Else
            txtKnet.ForeColor = Color.Black
        End If
        If Val(txtCash.Text) < 0 Then
            txtCash.ForeColor = Color.Red
        Else
            txtCash.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeLabel1.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            If Strings.Right(RptPath, 1) <> "\" Then RptPath &= "\"
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeLabel1.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(RptPath & "Gold-Silver\Buy") = False Then Directory.CreateDirectory(RptPath & "Gold-Silver\Buy")
            Dim newFile As New FileStream(RptPath & "Gold-Silver\Buy\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            MsgBox("PDF تم التصدير بصيغة" & vbCrLf & "PDF Export Done.", MsgBoxStyle.Information, AppTitle)
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            RecordRrrors(ex.ToString)
            Exit Sub
        End Try
    End Sub
             
    Private Sub btnWhatsApp_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeLabel1.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        ' الحفظ ولالرسال عبر الوتس اب
        Try
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CastomerNAmeLabel1.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(RptPath & "Gold-Silver\Buy\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            RecordRrrors(ex.ToString)
            Exit Sub
        End Try
        Try
            If IsNumeric(CastomerTETextBox.Text.Trim) = False OrElse Len(CastomerTETextBox.Text.Trim) <> 8 Then
                MsgBox("رقم هاتف العميل مسجل بشكل غير صحيح" & vbCrLf & "Registered Customer Phone is Not Valid.", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End If
            Dim webAddress As String = "https://api.whatsapp.com/send?phone= " & "965" & CastomerTETextBox.Text & ""
            Process.Start(webAddress)
        Catch ex As Exception
            RecordRrrors(ex.ToString)
            MsgBox("تحقق من الاتصال بالإنترنت" & vbCrLf & "Please Check Internet Connection.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()
        GetCastomAccReportPath()
    End Sub

    Private Sub cmbPayMethod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayMethod.SelectedIndexChanged

    End Sub
    
    Private Sub txtBank1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank1.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtBank2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank2.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtBank3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank3.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtBank4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank4.TextChanged
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
        End Try
    End Sub
    
    Private Sub BtnAddReceipt_Click(sender As Object, e As EventArgs) Handles BtnAddReceipt.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        With OpenFileDialog1
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                PicAddReceipt.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        PicAddReceipt.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtReceiptNo_MouseClick(sender As Object, e As MouseEventArgs) Handles txtReceiptNo.MouseClick, txtKnet.MouseClick, txtBank4.MouseClick, txtBank3.MouseClick, txtBank2.MouseClick, txtBank1.MouseClick
        sender.SelectAll()
    End Sub
End Class