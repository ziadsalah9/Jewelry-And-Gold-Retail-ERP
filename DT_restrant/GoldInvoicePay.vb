Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class GoldInvoicePay
    Dim GoldExchangeRptPath As String
    Dim RptPath As String
    Dim Stautes As String
    Dim AutoClose As String
    Dim Multiplepayment As Boolean
    Dim CurrentInvoiceNo As String = "0"
    Dim ReceiptNo As String

    Private Sub GetCastomAccReportPath()
        Dim GetCastomAccPath As String = RptPath
        If RadCastm.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = GetCastomAccPath
        ElseIf RadAcc.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Replace(GetCastomAccPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub
    Private Sub ExchangeRptPathGetCastomAccReportPath()
        Dim GetCastomAccPath As String = GoldExchangeRptPath
        If RadCastm.Checked = True Then
            RptGoldExchange.LocalReport.ReportPath = GetCastomAccPath
        ElseIf RadAcc.Checked = True Then
            RptGoldExchange.LocalReport.ReportPath = Replace(GetCastomAccPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub
    Private Sub GetReportPath()
        GetCastomAccReportPath()
        ExchangeRptPathGetCastomAccReportPath()
    End Sub
    Private Sub AddPurchase()
        If String.IsNullOrWhiteSpace(txtCash.Text.Trim) Or Val(txtCash.Text.Trim) = 0 Then
            Exit Sub
        ElseIf Val(txtCash.Text.Trim) >= 0 Then
            Dim dt1 As DataTable = GetRecordSet("SELECT ID_MAX +1 AS ID_MAX FROM bay_goled_mony WHERE bay_id=(SELECT max(bay_id) FROM bay_goled_mony)")
            If dt1.Rows.Count > 0 Then
                CurrentInvoiceNo = Val(dt1.Rows(0)(0).ToString)
            Else
                CurrentInvoiceNo = "1"
            End If
            Try
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
                                                   " ,[SalesInvNumber]" &
                                                   " ,[PurchaseInvNumber]" &
                                                   " ,[PurchaseGold]" &
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
                                                   " ,@SalesInvNumber" &
                                                   " ,@PurchaseInvNumber" &
                                                   " ,@PurchaseGold" &
                                                   " ,@PaymentTransNumber" &
                                                   " ,@ID_MAX)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@saryal", InvoiceStringNo(Val(CurrentInvoiceNo)))
                    .AddWithValue("@total_price", Val(GoldInvoice.txtlblGoldPurPrice.Text))
                    .AddWithValue("@cach", (0))
                    .AddWithValue("@kenet", (0))
                    .AddWithValue("@arabik", kokotxt(Val(GoldInvoice.txtlblGoldPurPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                    .AddWithValue("@date", GoldInvoice.DateDateTimePicker.Value)
                    .AddWithValue("@English", ConvertNumberToENG(Val(GoldInvoice.txtlblGoldPurPrice.Text)))
                    .AddWithValue("@Cashier", GoldInvoice.cmbCashier.SelectedValue)
                    .AddWithValue("@TIME_INV", Format(GoldInvoice.DateDateTimePicker.Value, "dd/MM/yyyy hh:mm:ss"))
                    .AddWithValue("@INV_Actv", "1")
                    .AddWithValue("@PayMethod", cmbPayMethod.SelectedValue)
                    .AddWithValue("@SalesInvNumber", InvoiceStringNo(Val(InvID)) & " رقم فاتورة البيع " & " Sales Invoice Number ")
                    .AddWithValue("@PurchaseInvNumber", InvoiceStringNo(Val(InvID)))
                    .AddWithValue("@PurchaseGold", Val(GoldInvoice.txtlblGoldPurPrice.Text))
                    .AddWithValue("@PaymentTransNumber", "0")
                    .AddWithValue("@ID_MAX", Val(CurrentInvoiceNo))
                End With
                GlCommand.ExecuteNonQuery()
                For I As Integer = 0 To GoldInvoice.DataGridView1.Rows.Count - 1
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
                        .AddWithValue("@castomer_id", GoldInvoice.DataGridView1.Rows(I).Cells("colcastomer_id").Value)
                        .AddWithValue("@bay_val", GoldInvoice.DataGridView1.Rows(I).Cells("colbay_val").Value)
                        .AddWithValue("@bay_mazan", GoldInvoice.DataGridView1.Rows(I).Cells("colbay_mazan").Value)
                        .AddWithValue("@bay_gram_price", GoldInvoice.DataGridView1.Rows(I).Cells("colbay_gram_price").Value)
                        .AddWithValue("@bay_total_price", GoldInvoice.DataGridView1.Rows(I).Cells("colTotalPrice").Value)
                        .AddWithValue("@inv_id", InvoiceStringNo(Val(CurrentInvoiceNo)))
                        .AddWithValue("@Item_Des", GoldInvoice.DataGridView1.Rows(I).Cells("colItem_Des").Value)
                        .AddWithValue("@INV_Actv", "1")
                        .AddWithValue("@AddToItem", GoldInvoice.DataGridView1.Rows(I).Cells("colAddToItem").Value)
                        .AddWithValue("@Note", " تبديل ذهب " & "  Gold exchange " & InvoiceStringNo(Val(InvID)))
                        .AddWithValue("@GoldWeight999", GoldInvoice.DataGridView1.Rows(I).Cells("colGoldWeight999").Value)
                        .AddWithValue("@GoldCaret999", GoldInvoice.DataGridView1.Rows(I).Cells("colGoldCaret999").Value)
                        .AddWithValue("@Qunt", GoldInvoice.DataGridView1.Rows(I).Cells("colQunt").Value)
                    End With
                    GlCommand.ExecuteNonQuery()
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
                RecordRrrors(ex.ToString)
                'Return
            End Try
        End If
    End Sub
    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            RptPath = dt1.Rows(0)("SET_INVARCHR156").ToString
            GoldExchangeRptPath = dt1.Rows(0)("SET_INVARCHR158").ToString
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
            AutoClose = dt1.Rows(0)("SET_INVARCHR144").ToString
            Multiplepayment = dt1.Rows(0)("SET9").ToString
        End If
    End Sub
    Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
    Public InvoiceTime As String
    Public Sub Radio()
        If rbCash.Checked = True Then
            Stautes = "نقدا"
            rbCredit.Checked = False
        ElseIf rbCash.Checked = False Then
            Stautes = "أجل"
            rbCredit.Checked = True
        End If
    End Sub
    Private Sub baymony_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved Then GoldInvoice.Close()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        RptGoldExchange.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub GoldInvoicePay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ApplyIconsToButtons(Me)
        GetSettings()
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        'GetReportPath()
        GetPayMethod()
        GetPayMethodSelect()
        btnPrint.Enabled = False
        txtPrice.Text = Val(GoldInvoice.txtTotalPriceValue.Text)
        'txtKnet.Text = 0
        btnPDF.Visible = False
        rbCash.Checked = True
        cmbPayMethod.SelectedIndex = 0
        Try

        Catch ex As Exception

        End Try

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
        If AutoClose <> "0" Then
            chkAutoClose.Checked = True
        End If
        RadCastm.Checked = True
        GetCastomAccReportPath()
        txtCash.Text = If(String.IsNullOrWhiteSpace(GoldInvoice.txtlblGoldPurPrice.Text) OrElse Val(GoldInvoice.txtlblGoldPurPrice.Text) = 0, 0, GoldInvoice.txtlblGoldPurPrice.Text.Trim())
        'txtKnet.Text = Math.Abs(Val(txtRemaining.Text))
        txtKnet.Text = Math.Abs(CDec(Val(txtRemaining.Text))).ToString("0.000")
        txtReceiptNo.Text = If(frmLogin.rbtnAr.Checked = True, "رقم ايصال الدفع", "Payment Receipt Number")
        If Val(GoldInvoice.txtlblGoldPurPrice.Text) > 0 Then
            ReportViewer1.Size = New Size(381, 500)
        Else
            ReportViewer1.Size = New Size(760, 500)
            RptGoldExchange.Visible = False
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
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim total As Decimal = Math.Round(Val(txtCash.Text) + Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text), 3)
        ReceiptNo = If(txtReceiptNo.Text = "رقم ايصال الدفع" Or txtReceiptNo.Text = "Payment Receipt Number", "", txtReceiptNo.Text.Trim())
        If Val(txtRemaining.Text) > 0.000 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        GetReportPath()
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 OrElse Val(txtBank1.Text) < 0 OrElse Val(txtBank2.Text) < 0 OrElse Val(txtBank3.Text) < 0 OrElse Val(txtBank4.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If rbCash.Checked = True Then
            If Val(total) <> Val(txtPrice.Text) Then
                MsgBox("إجمالي السعر لا يساوي مجموع تبديل الذهب و الكي نت" & vbCrLf & "Total Price is NOT Equal to Gold Exchange And K-NET", , "خطأ")
                Exit Sub
            End If
        ElseIf rbCredit.Checked = True Then

        End If
        Dim DtInvID As DataTable = GetRecordSet("SELECT MaxID +1 AS InvIDAuto FROM BAY WHERE BAY_ID=(SELECT max(BAY_ID) FROM BAY)")
        If DtInvID.Rows.Count > 0 Then
            InvID = Val(DtInvID.Rows(0)(0).ToString)
        Else
            InvID = "1"
        End If
        AddPurchase()
        Try
            GlCommand.CommandText = " INSERT INTO [BAY]" &
                                           " ([BAY_SARYAL]" &
                                           " ,[TOTAL_mony]" &
                                           " ,[KENT]" &
                                           " ,[CACH]" &
                                           " ,[PurchaseGold]" &
                                           " ,[arbic_tayb]" &
                                           " ,[balance]" &
                                           " ,[staytes]" &
                                           " ,[English_tayb]" &
                                           " ,[Active]" &
                                           " ,[Notes]" &
                                           " ,[PayMethod]" &
                                           " ,[PayMethod1]" &
                                           " ,[PayMethod2]" &
                                           " ,[PayMethod3]" &
                                           " ,[PayMethod4]" &
                                           " ,[Bank1]" &
                                           " ,[Bank2]" &
                                           " ,[Bank3]" &
                                           " ,[Bank4]" &
                                           " ,[InvVatType]" &
                                           " ,[MaxID]" &
                                           " ,[PurchaseInvNumber]" &
                                           " ,[PaymentReceipt]" &
                                           " ,[InvVat]" &
                                           " ,[PaymentTransNumber])" &
                                      " VALUES" &
                                          "(@BAY_SARYAL" &
                                           " ,@TOTAL_mony" &
                                           " ,@KENT" &
                                           " ,@CACH" &
                                           " ,@PurchaseGold" &
                                           " ,@arbic_tayb" &
                                           " ,@balance" &
                                           " ,@staytes" &
                                           " ,@English_tayb" &
                                           " ,@Active" &
                                           " ,@Notes" &
                                           " ,@PayMethod" &
                                           " ,@PayMethod1" &
                                           " ,@PayMethod2" &
                                           " ,@PayMethod3" &
                                           " ,@PayMethod4" &
                                           " ,@Bank1" &
                                           " ,@Bank2" &
                                           " ,@Bank3" &
                                           " ,@Bank4" &
                                           " ,@InvVatType" &
                                           " ,@MaxID" &
                                           " ,@PurchaseInvNumber" &
                                           " ,@PaymentReceipt" &
                                           " ,@InvVat" &
                                           " ,@PaymentTransNumber)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@BAY_SARYAL", InvoiceStringNo(Val(InvID)))
                .AddWithValue("@TOTAL_mony", Val(txtPrice.Text.Trim))
                .AddWithValue("@KENT", If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)))
                .AddWithValue("@CACH", 0)
                .AddWithValue("@PurchaseGold", If(IsDBNull(txtCash.Text.Trim), 0, Val(txtCash.Text.Trim)))
                .AddWithValue("@arbic_tayb", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@balance", txtRemaining.Text.Trim)
                .AddWithValue("@staytes", If(rbCash.Checked = True, "1", "0"))
                .AddWithValue("@English_tayb", ConvertNumberToENG(txtPrice.Text.Trim))
                .AddWithValue("@Active", "1")
                .AddWithValue("@Notes", "0")
                .AddWithValue("@PayMethod", cmbPayMethod.SelectedValue)
                .AddWithValue("@PayMethod1", cmbPayMethod1.SelectedValue)
                .AddWithValue("@PayMethod2", cmbPayMethod2.SelectedValue)
                .AddWithValue("@PayMethod3", cmbPayMethod3.SelectedValue)
                .AddWithValue("@PayMethod4", cmbPayMethod4.SelectedValue)
                .AddWithValue("@Bank1", If(IsDBNull(txtBank1.Text.Trim), "0", Val(txtBank1.Text.Trim)))
                .AddWithValue("@Bank2", If(IsDBNull(txtBank2.Text.Trim), "0", Val(txtBank2.Text.Trim)))
                .AddWithValue("@Bank3", If(IsDBNull(txtBank3.Text.Trim), "0", Val(txtBank3.Text.Trim)))
                .AddWithValue("@Bank4", If(IsDBNull(txtBank4.Text.Trim), "0", Val(txtBank4.Text.Trim)))
                .AddWithValue("@InvVatType", If(IsDBNull(GoldInvoice.txtTaxAmo.Text.Trim), "0", Val(GoldInvoice.txtTaxAmo.Text.Trim)))
                .AddWithValue("@InvVat", If(IsDBNull(GoldInvoice.txtTpriceTtax.Text.Trim), "0", Val(GoldInvoice.txtTpriceTtax.Text.Trim)))
                .AddWithValue("@PurchaseInvNumber", If(String.IsNullOrWhiteSpace(InvoiceStringNo(Val(CurrentInvoiceNo))) OrElse Val(InvoiceStringNo(Val(CurrentInvoiceNo))) = 0, "", "رقم فاتورة الشراء Purchase Invoice Number " & InvoiceStringNo(Val(CurrentInvoiceNo))))
                .Add("@PaymentReceipt", SqlDbType.Image).Value = If(PicAddReceipt.Image Is Nothing, DBNull.Value, ImageToByte(PicAddReceipt.Image))
                .AddWithValue("@MaxID", InvID)
                .AddWithValue("@PaymentTransNumber", ReceiptNo)
            End With
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        For i As Integer = 0 To GoldInvoice.grid.Rows.Count - 1
            GlCommand.CommandText = "INSERT INTO [selInvoceDetels]" &
               "([Castomerid]" &
               ",[ItemID]" &
               ",[userID]" &
               ",[item_name]" &
               ",[item_desp]" &
               ",[item_GramPrice]" &
               ",[item_gram]" &
               ",[item_gramMade]" &
               ",[item_totalPrice]" &
               ",[item_cantrey]" &
               ",[cacher]" &
               ",[date]" &
               ",[invoc_date_time]" &
               ",[Cash]" &
               ",[qunt]" &
               ",[sroom_name]" &
               ",[invoc_time]" &
               ",[item_extrasMAZAN]" &
               ",[StoneName1]" &
               ",[StoneColor1]" &
               ",[item_extrasPRICE]" &
               ",[StonePriceType1]" &
               ",[StoneWeight2]" &
               ",[StoneName2]" &
               ",[StoneColor2]" &
               ",[StonePrice2]" &
               ",[StonePriceType2]" &
               ",[StoneWeight3]" &
               ",[StoneName3]" &
               ",[StoneColor3]" &
               ",[StonePrice3]" &
               ",[StonePriceType3]" &
               ",[GoledKarat]" &
               ",[MetalPrice]" &
               ",[Active]" &
               ",[ItemVatType]" &
               ",[ItemVat])" &
         "VALUES" &
               "(@Castomerid" &
               ",@ItemID" &
               ",@userID" &
               ",@item_name" &
               ",@item_desp" &
               ",@item_GramPrice" &
               ",@item_gram" &
               ",@item_gramMade" &
               ",@item_totalPrice" &
               ",@item_cantrey" &
               ",@cacher" &
               ",@date" &
               ",@invoc_date_time" &
               ",@Cash" &
               ",@qunt" &
               ",@sroom_name" &
               ",@invoc_time" &
               ",@item_extrasMAZAN" &
               ",@StoneName1" &
               ",@StoneColor1" &
               ",@item_extrasPRICE" &
               ",@StonePriceType1" &
               ",@StoneWeight2" &
               ",@StoneName2" &
               ",@StoneColor2" &
               ",@StonePrice2" &
               ",@StonePriceType2" &
               ",@StoneWeight3" &
               ",@StoneName3" &
               ",@StoneColor3" &
               ",@StonePrice3" &
               ",@StonePriceType3" &
               ",@GoledKarat" &
               ",@MetalPrice" &
               ",@Active" &
               ",@ItemVatType" &
               ",@ItemVat)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@Castomerid", GoldInvoice.grid.Rows(i).Cells("colCastomerid").Value)
                .AddWithValue("@ItemID", GoldInvoice.grid.Rows(i).Cells("colItemID").Value)
                .AddWithValue("@userID", GoldInvoice.grid.Rows(i).Cells("coluserID").Value)
                .AddWithValue("@item_name", GoldInvoice.grid.Rows(i).Cells("colItemName").Value)
                .AddWithValue("@item_desp", GoldInvoice.grid.Rows(i).Cells("colGoledPurchasPrice").Value)
                .AddWithValue("@item_GramPrice", GoldInvoice.grid.Rows(i).Cells("colGramPrice").Value)
                .AddWithValue("@item_gram", GoldInvoice.grid.Rows(i).Cells("colGoldWeight").Value)
                .AddWithValue("@item_gramMade", GoldInvoice.grid.Rows(i).Cells("colGoledMakeCharge").Value)
                .AddWithValue("@item_totalPrice", GoldInvoice.grid.Rows(i).Cells("colTotalGoledPrice").Value)
                .AddWithValue("@item_cantrey", GoldInvoice.grid.Rows(i).Cells("colItemCantrey").Value)
                .AddWithValue("@cacher", GoldInvoice.grid.Rows(i).Cells("colcacher").Value)
                .AddWithValue("@date", GoldInvoice.grid.Rows(i).Cells("coldate").Value)
                .AddWithValue("@invoc_date_time", GoldInvoice.grid.Rows(i).Cells("colInvocDateTime").Value)
                .AddWithValue("@Cash", GoldInvoice.grid.Rows(i).Cells("coldate").Value)
                .AddWithValue("@qunt", GoldInvoice.grid.Rows(i).Cells("colGoledPiecesQuantity").Value)
                .AddWithValue("@sroom_name", GoldInvoice.grid.Rows(i).Cells("colSroomName").Value)
                .AddWithValue("@invoc_time", InvoiceStringNo(Val(InvID)))
                .AddWithValue("@item_extrasMAZAN", GoldInvoice.grid.Rows(i).Cells("colStonWeight1").Value)
                .AddWithValue("@StoneName1", GoldInvoice.grid.Rows(i).Cells("colStonName1").Value)
                .AddWithValue("@StoneColor1", GoldInvoice.grid.Rows(i).Cells("colStonColor1").Value)
                .AddWithValue("@item_extrasPRICE", GoldInvoice.grid.Rows(i).Cells("colStonPrice1").Value)
                .AddWithValue("@StonePriceType1", GoldInvoice.grid.Rows(i).Cells("colStonePriceType1").Value)
                .AddWithValue("@StoneWeight2", GoldInvoice.grid.Rows(i).Cells("colStonWeight2").Value)
                .AddWithValue("@StoneName2", GoldInvoice.grid.Rows(i).Cells("colStonName2").Value)
                .AddWithValue("@StoneColor2", GoldInvoice.grid.Rows(i).Cells("colStonColor2").Value)
                .AddWithValue("@StonePrice2", GoldInvoice.grid.Rows(i).Cells("colStonPrice2").Value)
                .AddWithValue("@StonePriceType2", GoldInvoice.grid.Rows(i).Cells("colStonePriceType2").Value)
                .AddWithValue("@StoneWeight3", GoldInvoice.grid.Rows(i).Cells("colStonWeight3").Value)
                .AddWithValue("@StoneName3", GoldInvoice.grid.Rows(i).Cells("colStonName3").Value)
                .AddWithValue("@StoneColor3", GoldInvoice.grid.Rows(i).Cells("colStonColor3").Value)
                .AddWithValue("@StonePrice3", GoldInvoice.grid.Rows(i).Cells("colStonPrice3").Value)
                .AddWithValue("@StonePriceType3", GoldInvoice.grid.Rows(i).Cells("colStonePriceType3").Value)
                .AddWithValue("@GoledKarat", GoldInvoice.grid.Rows(i).Cells("colGoledKarat").Value)
                .AddWithValue("@MetalPrice", GoldInvoice.grid.Rows(i).Cells("colGoledPrice").Value)
                .AddWithValue("@Active", "1")
                .AddWithValue("@ItemVatType", GoldInvoice.grid.Rows(i).Cells("colTaxAmo").Value)
                .AddWithValue("@ItemVat", GoldInvoice.grid.Rows(i).Cells("colTaxTextAm").Value)
            End With
            GlCommand.ExecuteNonQuery()
        Next

        GlCommand.CommandText = ("UPDATE [selInvoceDetels] SET [nots] =N'" & GoldInvoice.txtNotes.Text.Trim & "' WHERE  [invoc_time]='" & InvoiceStringNo(Val(InvID)) & "'")
        GlCommand.ExecuteNonQuery()
        txtInvoiceNo.Text = InvoiceStringNo(Val(InvID))
        InvoiceTime = InvoiceStringNo(Val(InvID))






        Dim DT As DataTable = GetRecordSet("select * from ViwGoldInvoceReport  WHERE  [invoc_time]='" & InvoiceStringNo(Val(InvID)) & "'")
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            SetReportPaper(ReportViewer1)
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If


        If Val(GoldInvoice.txtlblGoldPurPrice.Text) > 0 Then
            Dim PurchaseInvoice As DataTable = GetRecordSet("select * from ViwGoldPurchaseInvoice  WHERE  [inv_id]='" & InvoiceStringNo(Val(CurrentInvoiceNo)) & "'")
            If PurchaseInvoice.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", PurchaseInvoice)
                RptGoldExchange.LocalReport.DataSources.Clear()
                RptGoldExchange.LocalReport.DataSources.Add(ReportDataSource)
                SetReportPaper(RptGoldExchange)
                RptGoldExchange.RefreshReport()
                RptGoldExchange.SetDisplayMode(DisplayMode.PrintLayout)
            Else
            End If
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
        'End If
        'With btnPDF
        '    .FlatStyle = FlatStyle.Flat
        '    .FlatAppearance.BorderSize = 0
        '    .FlatAppearance.MouseDownBackColor = Color.Transparent
        '    .FlatAppearance.MouseOverBackColor = Color.Transparent
        '    .BackColor = Color.Transparent
        '    .Text = ""
        '    .ImageAlign = ContentAlignment.MiddleCenter
        'End With
    End Sub



    Private Sub rbNow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCash.CheckedChanged
        'Radio()
    End Sub

    Private Sub rbLater_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCredit.CheckedChanged
        'Radio()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try
            If ReportViewer1.PrintDialog() = Windows.Forms.DialogResult.Cancel Then
                'Put your stuff here
            End If
        Catch ex As Exception
            MsgBox("تجري الطباعة الان" & vbCrLf & "Printing in Progress..", , AppTitle)
        End Try
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
    Private Sub GoldExchangePrintReport()
        'Try
        If Val(GoldInvoice.txtlblGoldPurPrice.Text) > 0 Then
                Dim printerSettings As New PrinterSettings()
                printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
                RptGoldExchange.PrinterSettings = printerSettings
                RptGoldExchange.PrintDialog()
            Else

            End If
        'Catch ex As Exception
        '    MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        'End Try
    End Sub

    ' Call this method whenever you want to print the report
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        PrintReport()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Saved = True
        PrintReport()
        GoldExchangePrintReport()
    End Sub
    Private Sub txtPrice_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtKnet.Text = Val(GoldInvoice.txtTotalPriceValue.Text)
        'txtKnet.Text = "0"
        txtBank1.Text = ""
        txtBank2.Text = ""
        txtBank3.Text = ""
        txtBank4.Text = ""
        NegativeColor()
    End Sub
    Private Sub lblKNET_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblKNET.Click
        txtKnet.Text = txtPrice.Text
        'txtCash.Text = "0"
        NegativeColor()
    End Sub

    Private Sub lblCash_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblCash.Click
        txtKnet.Text = txtPrice.Text
        NegativeColor()
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtCash_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCash.KeyUp

        If rbCash.Checked = True Then
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            txtKnet.Text = Price - Cash
            NegativeColor()
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

    Private Sub BtnPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CivilIDForm.txtName.Text.Trim
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        'Try
        Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
        If Strings.Right(Path, 1) <> "\" Then Path &= "\"
        ReportViewer1.LocalReport.EnableExternalImages = True
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
        saveFileDialog1.FileName = CivilIDForm.txtName.Text.Trim
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If Directory.Exists(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim) = False Then Directory.CreateDirectory(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim)
        Dim pdfFilePath As String = Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim & "\" & txtInvoiceNo.Text & ".PDF"
        Dim newFile As New FileStream(pdfFilePath, FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()

        ' إرسال PDF عبر WhatsApp API تلقائياً (بدون رسائل)
        Dim phoneNumber As String = CivilIDForm.txtPhone.Text.Trim()
        '    If Not String.IsNullOrWhiteSpace(phoneNumber) Then
        '        ' إرسال PDF في thread منفصل بدون انتظار
        '        Task.Run(Async Function() As Task
        ''                     Try
        '                         ' رسالة الفاتورة
        '                         Dim message As String = "مرحباً " & CivilIDForm.txtName.Text.Trim() & vbCrLf &
        '                                               "فاتورة رقم: " & txtInvoiceNo.Text & vbCrLf &
        '                                               "شكراً لتعاملكم معنا" & vbCrLf &
        '                                               "Thank you for your business"

        '                         ' إرسال PDF عبر WhatsApp API باستخدام الدالة من ModuleMain
        '                         ' لا نعرض رسالة - الإرسال تلقائي وصامت
        '                         'Dim result As String = Await SendWhatsAppFileAsync(phoneNumber, message, pdfFilePath)
        '                         ' تسجيل النتيجة فقط
        '                         If result.StartsWith("SUCCESS:") Then
        '                             ' تم الإرسال بنجاح - لا حاجة لعرض رسالة

        '                             MsgBox(result)
        '                         Else
        '                             ' فشل الإرسال - تسجيل الخطأ فقط
        '                             RecordRrrors(DescriptionRrrors:="WhatsApp send failed: " & result)
        '                         End If
        '                     Catch ex As Exception
        '                         ' تسجيل الخطأ فقط بدون عرض رسالة
        '                         RecordRrrors(DescriptionRrrors:="Error sending WhatsApp invoice: " & ex.ToString)
        '                     End Try
        '                 End Function)
        '    End If
        'Catch ex As Exception
        '    MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()

    End Sub






    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    'MsgBox("https://saponlin.net/payment" / "SAP_COP" / "" & CastomerNAmeLabel.Text & "" & lblInvoiceNo.Text.Trim & "" / "" & Val(txtKnet.Text) & "".ToString)



    '    'Dim webAddress As String = "https://saponlin.net/payment " & "SAP_COP" & "/" & "HOSAM" & "/" & txtKnet.Text & ""
    '    'Process.Start(webAddress)





    '    Dim COOD As String = ("https://saponlin.net/payment/ " & "SAP_COMP" & "/" & CastomeridTextBox.Text.Trim & "-DATE-2023-01-29" & txtInvoiceNo.Text & "/" & txtKnet.Text.Trim)
    '    MsgBox(COOD)
    '    'Dim webAddress As String = "https://saponlin.net/payment/ " & COOD.ToString
    '    'Process.Start(webAddress)
    '    Clipboard.SetText(COOD)
    '    frmLlnk.LinkLabel1.Text = COOD
    '    frmLlnk.ShowDialog()





    'End Sub



#Region "BankSum"
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
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
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
#End Region

    Private Sub RadCastm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCastm.CheckedChanged
        GetCastomAccReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAcc.CheckedChanged
        GetCastomAccReportPath()
        If Saved Then ReportViewer1.RefreshReport()
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

    Private Sub Btnwhasapp_send_pdf_Click(sender As Object, e As EventArgs) Handles btnwhasapp_send_pdf.Click
        Try
            ' التحقق من وجود رقم الهاتف
            Dim phoneNumber As String = CivilIDForm.txtPhone.Text.Trim()
            If String.IsNullOrWhiteSpace(phoneNumber) Then
                MsgBox("لا يوجد رقم هاتف للعميل" & vbCrLf & "No phone number for customer", MsgBoxStyle.Exclamation, AppTitle)
                Return
            End If

            ' التحقق من وجود رقم الفاتورة
            If String.IsNullOrWhiteSpace(txtInvoiceNo.Text.Trim()) Then
                MsgBox("لا يوجد رقم فاتورة" & vbCrLf & "No invoice number", MsgBoxStyle.Exclamation, AppTitle)
                Return
            End If

            ' تعطيل الزر أثناء الإرسال
            btnwhasapp_send_pdf.Enabled = False
            btnwhasapp_send_pdf.Text = "جاري الإرسال..."

            ' إرسال PDF في thread منفصل باستخدام Async Sub
            SendWhatsAppPDFAsync()
        Catch ex As Exception
            btnwhasapp_send_pdf.Enabled = True
            btnwhasapp_send_pdf.Text = "إرسال PDF عبر WhatsApp"
            MsgBox("خطأ في بدء الإرسال: " & ex.Message & vbCrLf & "Error starting send: " & ex.Message, MsgBoxStyle.Critical, AppTitle)
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub

    ' دالة إرسال PDF عبر WhatsApp (Async)
    Private Async Sub SendWhatsAppPDFAsync()
        'Try
        ' إنشاء/التحقق من وجود PDF
        Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
        If Strings.Right(Path, 1) <> "\" Then Path &= "\"
        Dim pdfFilePath As String = Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim & "\" & txtInvoiceNo.Text & ".PDF"

        ' إذا لم يكن PDF موجوداً، إنشاؤه
        If Not File.Exists(pdfFilePath) Then
            Try
                ReportViewer1.LocalReport.DisplayName = CivilIDForm.txtName.Text.Trim
                ReportViewer1.LocalReport.EnableExternalImages = True
                Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
                If Directory.Exists(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim) = False Then
                    Directory.CreateDirectory(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim)
                End If
                Using newFile As New FileStream(pdfFilePath, FileMode.Create)
                    newFile.Write(byteViewer, 0, byteViewer.Length)
                End Using
            Catch pdfEx As Exception
                btnwhasapp_send_pdf.Enabled = True
                btnwhasapp_send_pdf.Text = "إرسال PDF عبر WhatsApp"
                MsgBox("خطأ في إنشاء PDF: " & pdfEx.Message & vbCrLf & "Error creating PDF: " & pdfEx.Message, MsgBoxStyle.Critical, AppTitle)
                RecordRrrors(DescriptionRrrors:=pdfEx.ToString)
                Return
            End Try
        End If

        ' رسالة الفاتورة
        Dim phoneNumber As String = CivilIDForm.txtPhone.Text.Trim()
        Dim message As String = "مرحباً " & CivilIDForm.txtName.Text.Trim() & vbCrLf &
                                "فاتورة رقم: " & txtInvoiceNo.Text & vbCrLf &
                                "شكراً لتعاملكم معنا" & vbCrLf &
                                 If(frmMain.lblCompanyName.Text = "", "", frmMain.lblCompanyName.Text) & vbCrLf &
                                "Thank you for your business"
        ' إرسال PDF عبر WhatsApp API
        'Dim result As String = Await SendWhatsAppFileAsync(phoneNumber, message, pdfFilePath)

        ' عرض النتيجة
        btnwhasapp_send_pdf.Enabled = True
        btnwhasapp_send_pdf.Text = "إرسال PDF عبر WhatsApp"

        'If result.StartsWith("SUCCESS:") Then
        '    Dim responseContent As String = result.Substring(8) ' إزالة "SUCCESS:"
        '    MsgBox("✅ تم إرسال الفاتورة بنجاح" & vbCrLf & vbCrLf &
        '          "Response from server:" & vbCrLf & responseContent & vbCrLf & vbCrLf &
        '          "✅ Invoice sent successfully" & vbCrLf & vbCrLf &
        '          "Server Response:" & vbCrLf & responseContent, 
        '          MsgBoxStyle.Information, "نجاح الإرسال")
        'ElseIf result.StartsWith("ERROR:") Then
        '    Dim errorMsg As String = result.Substring(6) ' إزالة "ERROR:"
        '    ' محاولة استخراج رسالة الخطأ من JSON إذا كان موجوداً
        '    Dim displayError As String = errorMsg
        '    Try
        '        If errorMsg.Contains("{") AndAlso errorMsg.Contains("}") Then
        '            Dim jsonStart As Integer = errorMsg.IndexOf("{")
        '            Dim jsonPart As String = errorMsg.Substring(jsonStart)
        '            Dim jsonResponse As JObject = JObject.Parse(jsonPart)
        '            Dim errorMessage As String = If(jsonResponse("message") IsNot Nothing, jsonResponse("message").ToString(), "")
        '            Dim data As JToken = jsonResponse("data")
        '            If data IsNot Nothing Then
        '                Dim dataStr As String = data.ToString()
        '                displayError = If(String.IsNullOrWhiteSpace(errorMessage), errorMsg, errorMessage & vbCrLf & vbCrLf & "Details: " & dataStr)
        '            ElseIf Not String.IsNullOrWhiteSpace(errorMessage) Then
        '                displayError = errorMessage
        '            End If
        '        End If
        '    Catch
        '        ' إذا فشل تحليل JSON، استخدم الرسالة الأصلية
        '    End Try
        '        MsgBox("❌ فشل إرسال الفاتورة" & vbCrLf & vbCrLf &
        '              displayError & vbCrLf & vbCrLf &
        '              "❌ Failed to send invoice" & vbCrLf & vbCrLf &
        '              displayError,
        '              MsgBoxStyle.Critical, "فشل الإرسال")
        '        RecordRrrors(DescriptionRrrors:="WhatsApp send error: " & errorMsg)
        '    ElseIf result.StartsWith("EXCEPTION:") Then
        '        Dim exceptionMsg As String = result.Substring(10) ' إزالة "EXCEPTION:"
        '        MsgBox("⚠️ خطأ في الإرسال" & vbCrLf & vbCrLf &
        '              "Error: " & exceptionMsg & vbCrLf & vbCrLf &
        '              "⚠️ Send error" & vbCrLf & vbCrLf &
        '              "Error: " & exceptionMsg, 
        '              MsgBoxStyle.Critical, "خطأ")
        '        RecordRrrors(DescriptionRrrors:="WhatsApp send exception: " & exceptionMsg)
        '    Else
        '        MsgBox("❓ استجابة غير معروفة من السيرفر" & vbCrLf & vbCrLf &
        '              "Response: " & result & vbCrLf & vbCrLf &
        '              "❓ Unknown server response" & vbCrLf & vbCrLf &
        '              "Response: " & result, 
        '              MsgBoxStyle.Exclamation, "تنبيه")
        '    End If
        'Catch ex As Exception
        '    btnwhasapp_send_pdf.Enabled = True
        '    btnwhasapp_send_pdf.Text = "إرسال PDF عبر WhatsApp"
        '    MsgBox("خطأ في إرسال الفاتورة: " & ex.Message & vbCrLf & "Error sending invoice: " & ex.Message, MsgBoxStyle.Critical, AppTitle)
        '    RecordRrrors(DescriptionRrrors:=ex.ToString)
        'End Try
    End Sub
End Class