Imports System.IO
Imports PACICardLibrary
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Public Class SellBuyWholesale
    Public InvID As String = "0"
    Dim InvType As String
    Dim GetMakChar As Decimal
    Dim TotalPrice As Decimal
    Dim CheckedInv As String = "CheckedInv"
    Dim GoledPeiceAndMakChar As Decimal
    Dim ActuaDateTime As DateTime = Date.Now
    Public Sub GetMakeCharge()
        Try
            If ChBoxAutCalculation.Checked = True Then
                If TxtTotalGoledPrice.Focused = True Then
                    'ايجاد المصنعيات من اجمالي السعر
                    GetMakChar = Math.Round(Val(TxtTotalGoledPrice.Text) / Val(TxtGoCaret.Text) - Val(txtGoCaretPrice.Text), 3)
                    TxtMakeCharge.Text = Val(GetMakChar)
                    TxtTotMakeCharge.Text = Val(TxtMakeCharge.Text) * Val(TxtGoCaret.Text)
                ElseIf TxtMakeCharge.Focused = True Then
                    GoledPeiceAndMakChar = Math.Round(Val(txtGoCaretPrice.Text) + Val(TxtMakeCharge.Text), 3)
                    TxtTotalGoledPrice.Text = (GoledPeiceAndMakChar * Val(TxtGoCaret.Text))
                    TxtTotMakeCharge.Text = Math.Round(Val(TxtMakeCharge.Text) * Val(TxtGoCaret.Text), 3)
                    'ايجاد السعر من اجمالي المصنعيات
                ElseIf TxtTotMakeCharge.Focused = True Then
                    TxtMakeCharge.Text = Math.Round(Val(TxtTotMakeCharge.Text) / Val(TxtGoCaret.Text), 3)
                    GoledPeiceAndMakChar = Math.Round(Val(txtGoCaretPrice.Text) + Val(TxtMakeCharge.Text), 3)
                    TxtTotalGoledPrice.Text = Math.Round(Val(GoledPeiceAndMakChar) * Val(TxtGoCaret.Text), 3)
                End If
            ElseIf ChBoxAutCalculation.Checked = False Then
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SaveDataFromTPSellBuyWholesale(ByVal Inv_NO As String)
        DateInv.Value = Date.Now
        Dim DtInvID As DataTable = GetRecordSet("SELECT InvIDAuto +1 AS InvIDAuto FROM BAYWholesale WHERE ID=(SELECT max(ID)FROM BAYWholesale)") ' موقت حتي استكمال جدول الدفع
        If DtInvID.Rows.Count > 0 Then
            InvID = Val(DtInvID.Rows(0)(0).ToString)
        Else
            InvID = "1"
        End If
        'Try
        GlCommand.CommandText = "INSERT INTO [BAYWholesale]" &
          "([InvIDAuto]" &
           ",[InvID]" &
           ",[TOTAL_mony]" &
           ",[KENT]" &
           ",[CACH]" &
           ",[arbic_tayb]" &
           ",[balance]" &
           ",[English_tayb]" &
           ",[Notes]" &
           ",[Active]" &
           ",[PayMethod]" &
           ",[InvType]" &
           ",[PayMethod1]" &
           ",[PayMethod2]" &
           ",[PayMethod3]" &
           ",[PayMethod4]" &
           ",[Bank1]" &
           ",[Bank2]" &
           ",[Bank3]" &
           ",[Bank4]" &
           ",[InvVatType]" &
           ",[InvVat]" &
           ",[PaymentReceipt]" &
           ",[PaymentTransNumber]" &
           ",[PurchaseInvNumber]" &
           ",[PurchaseGold]" &
           ",[PurchaseGoldKarat])" &
           "VALUES" &
           "(@InvIDAuto" &
           ",@InvID" &
           ",@TOTAL_mony" &
           ",@KENT" &
           ",@CACH" &
           ",@arbic_tayb" &
           ",@balance" &
           ",@English_tayb" &
           ",@Notes" &
           ",@Active" &
           ",@PayMethod" &
           ",@InvType" &
           ",@PayMethod1" &
           ",@PayMethod2" &
           ",@PayMethod3" &
           ",@PayMethod4" &
           ",@Bank1" &
           ",@Bank2" &
           ",@Bank3" &
           ",@Bank4" &
           ",@InvVatType" &
           ",@InvVat" &
           ",@PaymentReceipt" &
           ",@PaymentTransNumber" &
           ",@PurchaseInvNumber" &
           ",@PurchaseGold" &
           ",@PurchaseGoldKarat)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@InvIDAuto", Val(InvID))
            .AddWithValue("@InvID", InvoiceStringNo(Val(InvID).ToString))
            .AddWithValue("@TOTAL_mony", Val(LinkTotalInvPricerequired.Text))
            .AddWithValue("@KENT", Val(txtKnet.Text))
            .AddWithValue("@CACH", 0)
            .AddWithValue("@arbic_tayb", kokotxt(Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text), CurrencyMainAr, CurrencySubAr, True))
            .AddWithValue("@balance", Val(LinkTotalInvRemaining.Text))
            .AddWithValue("@English_tayb", ConvertNumberToENG(Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)))
            .AddWithValue("@Notes", "1")
            .AddWithValue("@Active", 1)
            .AddWithValue("@PayMethod", If(cmbPayMethod.SelectedIndex = -1, 0, cmbPayMethod.SelectedValue))
            .AddWithValue("@InvType", If(Val(LinkTotalInvRemaining.Text) <> 0, 0, 1))
            .AddWithValue("@PayMethod1", If(cmbPayMethod1.SelectedIndex = -1, 0, cmbPayMethod1.SelectedValue))
            .AddWithValue("@PayMethod2", If(cmbPayMethod2.SelectedIndex = -1, 0, cmbPayMethod2.SelectedValue))
            .AddWithValue("@PayMethod3", If(cmbPayMethod3.SelectedIndex = -1, 0, cmbPayMethod3.SelectedValue))
            .AddWithValue("@PayMethod4", If(cmbPayMethod4.SelectedIndex = -1, 0, cmbPayMethod4.SelectedValue))
            .AddWithValue("@Bank1", Val(txtBank1.Text))
            .AddWithValue("@Bank2", Val(txtBank2.Text))
            .AddWithValue("@Bank3", Val(txtBank3.Text))
            .AddWithValue("@Bank4", Val(txtBank4.Text))
            .AddWithValue("@InvVatType", 0)   ' مثلاً 0 = بدون، 1 = شامل، 2 = غير شامل
            .AddWithValue("@InvVat", 0)
            .Add("@PaymentReceipt", SqlDbType.Image).Value = DBNull.Value
            .AddWithValue("@PaymentTransNumber", "")
            .AddWithValue("@PurchaseInvNumber", "")
            .AddWithValue("@PurchaseGold", 0)
            .AddWithValue("@PurchaseGoldKarat", "")
        End With
        GlCommand.ExecuteNonQuery()
        For i As Integer = 0 To TPSellBuyWholesale.Rows.Count - 1
            GlCommand.CommandText = "INSERT INTO [TPSellBuyWholesale]" &
          "([InvIDAuto]" &
          ",[InvID] " &
          ",[CashierID] " &
          ",[CastomerCAIVELid] " &
          ",[COM_ID] " &
          ",[ItemDes] " &
          ",[GoldCaretBasic] " &
          ",[GoldCaretBasicValue] " &
          ",[GoldCaretTrans] " &
          ",[GoldCaretTransValue] " &
          ",[GoldCaretPrice] " &
          ",[TotalGoledPrice] " &
          ",[MakeCharge] " &
          ",[TotalMakeCharge] " &
          ",[InvDate] " &
          ",[InvDateTime] " &
          ",[ActualInvDateTime]" &
          ",[UserID] " &
          ",[InvActive] " &
          ",[ItemActive] " &
          ",[InvType] " &
          ",[InvActiveaComp]) " &
       "VALUES " &
        "(@InvIDAuto " &
        ",@InvID" &
        ",@CashierID" &
        ",@CastomerCAIVELid" &
        ",@COM_ID" &
        ",@ItemDes" &
        ",@GoldCaretBasic" &
        ",@GoldCaretBasicValue" &
        ",@GoldCaretTrans" &
        ",@GoldCaretTransValue" &
        ",@GoldCaretPrice" &
        ",@TotalGoledPrice" &
        ",@MakeCharge" &
        ",@TotalMakeCharge" &
        ",@InvDate" &
        ",@InvDateTime" &
        ",@ActualInvDateTime" &
        ",@UserID" &
        ",@InvActive" &
        ",@ItemActive" &
        ",@InvType" &
        ",@InvActiveaComp)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@InvIDAuto", Val(InvID))
                .AddWithValue("@InvID", InvoiceStringNo(Val(InvID).ToString))
                .AddWithValue("@CashierID", ComBxCashier.SelectedValue)
                .AddWithValue("@CastomerCAIVELid", CivilIDForm.txtCID.Text.Trim())
                .AddWithValue("@COM_ID", cmbBranches.SelectedValue)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .AddWithValue("@ItemDes", TPSellBuyWholesale.Rows(i).Cells("ItemDes").Value)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .AddWithValue("@GoldCaretBasic", TPSellBuyWholesale.Rows(i).Cells("GoldCaretBasic").Value)
                .AddWithValue("@GoldCaretBasicValue", TPSellBuyWholesale.Rows(i).Cells("GoldCaretBasicValue").Value)
                .AddWithValue("@GoldCaretTrans", TPSellBuyWholesale.Rows(i).Cells("GoldCaretTrans").Value)
                .AddWithValue("@GoldCaretTransValue", TPSellBuyWholesale.Rows(i).Cells("GoldCaretTransValue").Value)
                .AddWithValue("@GoldCaretPrice", TPSellBuyWholesale.Rows(i).Cells("GoldCaretPrice").Value)
                .AddWithValue("@TotalGoledPrice", TPSellBuyWholesale.Rows(i).Cells("TotalGoledPrice").Value)
                .AddWithValue("@MakeCharge", TPSellBuyWholesale.Rows(i).Cells("MakeCharge").Value)
                .AddWithValue("@TotalMakeCharge", TPSellBuyWholesale.Rows(i).Cells("TotalMakeCharge").Value)
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .AddWithValue("@InvDate", Format(DateInv.Value, "yyyy-MM-dd"))
                .AddWithValue("@InvDateTime", Format(DateInv.Value, "dd-MM-yyyy hh:mm:ss tt"))
                .AddWithValue("@ActualInvDateTime", Format(ActuaDateTime, "dd-MM-yyyy hh:mm:ss tt"))
                .AddWithValue("@UserID", (User))
                .AddWithValue("@InvActive", "1")
                .AddWithValue("@ItemActive", "1")
                .AddWithValue("@InvType", CheckedInv)
                .AddWithValue("@InvActiveaComp", If(ChkBoxComdetels.Checked = True, "1", "0"))
            End With
            GlCommand.ExecuteNonQuery()
        Next
    End Sub

    Private Sub NegativeColor()
        If Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text) < 0 Then
            txtKnet.ForeColor = Color.Red
        Else
            txtKnet.ForeColor = Color.Black
        End If
    End Sub
    Private Sub GetGramPrice()
        If RadButSell.Checked = True Then
            If ComBxGoCaret.Text = "24" Then
                txtGoCaretPrice.Text = frmMain.lbl24.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "995" Then
                txtGoCaretPrice.Text = frmMain.lbl24.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                '''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "22" Then
                txtGoCaretPrice.Text = frmMain.lbl22.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "915" Then
                txtGoCaretPrice.Text = frmMain.lbl22.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                ''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "21" Then
                txtGoCaretPrice.Text = frmMain.lbl21.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "875" Then
                txtGoCaretPrice.Text = frmMain.lbl21.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                ''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "18" Then
                txtGoCaretPrice.Text = frmMain.lbl18.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "750" Then
                txtGoCaretPrice.Text = frmMain.lbl18.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            End If
        End If
        If RadButBuy.Checked = True Then
            If ComBxGoCaret.Text = "24" Then
                txtGoCaretPrice.Text = frmMain.lbl24BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "995" Then
                txtGoCaretPrice.Text = frmMain.lbl24BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                '''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "22" Then
                txtGoCaretPrice.Text = frmMain.lbl22BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "915" Then
                txtGoCaretPrice.Text = frmMain.lbl22BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                ''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "21" Then
                txtGoCaretPrice.Text = frmMain.lbl21BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "875" Then
                txtGoCaretPrice.Text = frmMain.lbl21BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
                ''''''''''''''''''''''''''''''''''''''''''''''''''''
            ElseIf ComBxGoCaret.Text = "18" Then
                txtGoCaretPrice.Text = frmMain.lbl18BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            ElseIf ComBxGoCaret.Text = "750" Then
                txtGoCaretPrice.Text = frmMain.lbl18BUY.Text
                txtGramPrice.Text = frmMain.lbl24.Text
            End If
        End If
    End Sub
    Private Sub SellBuyWholesale_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub SellBuyWholesale_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sc.Dispose()
        Dispose()
    End Sub
    Private Sub TotalPriceFromGred()
        Dim TotalPrice As Double
        Dim TotalPriceMakeCharge As Double
        Dim TotalGoldCaretWeight As Double
        Dim TotalGoldCaretWeight999 As Double
        For i As Integer = 0 To TPSellBuyWholesale.RowCount - 1
            TotalPrice += TPSellBuyWholesale.Rows(i).Cells("TotalGoledPrice").Value
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TotalGoldCaretWeight += TPSellBuyWholesale.Rows(i).Cells("GoldCaretBasicValue").Value
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TotalGoldCaretWeight999 += TPSellBuyWholesale.Rows(i).Cells("GoldCaretTransValue").Value
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TotalPriceMakeCharge += TPSellBuyWholesale.Rows(i).Cells("TotalMakeCharge").Value
        Next
        LinkTotalInvPricerequired.Text = TotalPrice
        LinkLinkTotalInvGoledW.Text = TotalGoldCaretWeight
        TotalInvMakeCharge.Text = TotalPriceMakeCharge
        CalcRemaining()
    End Sub


    Private Sub LoadBranches(ByVal companyID As Integer)
        Try
            Dim dtBranches As DataTable = GetRecordSet("select BranchID, BranchName from viwCompanyNameAndBranches where CompanyID = " & companyID & "'")
            If dtBranches.Rows.Count > 0 Then
                cmbBranches.DataSource = dtBranches
                cmbBranches.DisplayMember = "BranchName"
                cmbBranches.ValueMember = "BranchID"
                cmbBranches.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Sub LoadCompanyAndBranches()
    '    Dim dtCompany As DataTable = GetRecordSet("select distinct CompanyID, CompanyName from viwCompanyNameAndBranches")
    '    If dtCompany.Rows.Count > 0 Then
    '        cmbCompanyInfo.DataSource = dtCompany
    '        cmbCompanyInfo.DisplayMember = "CompanyName"
    '        cmbCompanyInfo.ValueMember = "CompanyID"
    '        cmbCompanyInfo.SelectedIndex = -1
    '        '--- الحدث الخاص بتغيير الشركة ---
    '        AddHandler cmbCompanyInfo.SelectedIndexChanged,
    '        Sub()
    '            If cmbCompanyInfo.SelectedIndex = -1 Then Exit Sub
    '            Dim companyID As Integer = cmbCompanyInfo.SelectedValue

    '            Dim dtBranches As DataTable = GetRecordSet("select BranchID, BranchName From viwCompanyNameAndBranches  where CompanyID = " & companyID)
    '            If dtBranches.Rows.Count > 0 Then
    '                cmbBranches.DataSource = dtBranches
    '                cmbBranches.DisplayMember = "BranchName"
    '                cmbBranches.ValueMember = "BranchID"
    '                cmbBranches.SelectedIndex = -1
    '            End If
    '        End Sub
    '    End If
    'End Sub
    Public Sub LoadCompanyAndBranches()
        Static handlerAdded As Boolean = False
        Try
            cmbCompanyInfo.DataSource = Nothing
            cmbBranches.DataSource = Nothing
            Dim dtCompany As DataTable =
            GetRecordSet("SELECT DISTINCT CompanyID, CompanyName FROM viwCompanyNameAndBranches")
            If dtCompany Is Nothing OrElse dtCompany.Rows.Count = 0 Then
                MessageBox.Show("لا توجد بيانات شركات متاحة." & Environment.NewLine &
                "No company data available.",
                "تنبيه | Notice",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
                Return
            End If
            With cmbCompanyInfo
                .DisplayMember = "CompanyName"
                .ValueMember = "CompanyID"
                .DataSource = dtCompany
                .SelectedIndex = -1
            End With
            If Not handlerAdded Then
                AddHandler cmbCompanyInfo.SelectedIndexChanged,
                Sub(sender As Object, e As EventArgs)
                    Try
                        If cmbCompanyInfo.SelectedIndex < 0 OrElse cmbCompanyInfo.SelectedValue Is Nothing Then
                            cmbBranches.DataSource = Nothing
                            Exit Sub
                        End If
                        Dim companyID As Integer
                        If Not Integer.TryParse(cmbCompanyInfo.SelectedValue.ToString(), companyID) Then
                            cmbBranches.DataSource = Nothing
                            Exit Sub
                        End If
                        Dim dtBranches As DataTable =
                            GetRecordSet("SELECT BranchID, BranchName " &
                                         "FROM viwCompanyNameAndBranches " &
                                         "WHERE CompanyID = " & companyID.ToString())

                        If dtBranches Is Nothing OrElse dtBranches.Rows.Count = 0 Then
                            cmbBranches.DataSource = Nothing
                            Exit Sub
                        End If
                        With cmbBranches
                            .DisplayMember = "BranchName"
                            .ValueMember = "BranchID"
                            .DataSource = dtBranches
                            .SelectedIndex = -1
                        End With
                    Catch exInner As Exception
                        MessageBox.Show("حدث خطأ أثناء تحميل الفروع:" & Environment.NewLine &
                exInner.Message & Environment.NewLine & Environment.NewLine &
                "An error occurred while loading branches:",
                "خطأ | Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                    End Try
                End Sub
                handlerAdded = True
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل الشركات:" & Environment.NewLine &
                ex.Message & Environment.NewLine & Environment.NewLine &
                "An error occurred while loading companies.",
                "خطأ | Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetData()
        LoadCompanyAndBranches()
        Dim cacher As DataTable = GetRecordSet("SELECT cacher_name,svil_id FROM cacher WHERE Active='1'")
        If cacher.Rows.Count > 0 Then
            ComBxCashier.DataSource = cacher
            ComBxCashier.DisplayMember = "cacher_name"
            ComBxCashier.ValueMember = "svil_id"
        End If
        Dim PayMethod As DataTable = GetRecordSet("select * from PayMethod WHERE Active='1'")
        If PayMethod.Rows.Count > 0 Then
            cmbPayMethod.DataSource = PayMethod
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
        Dim Gram_val As DataTable = GetRecordSet("SELECT GoldCaretBasic FROM  dbo.TPSellBuyWholesale GROUP BY GoldCaretBasic")
        If Gram_val.Rows.Count > 0 Then
            ComBxGoCaret.DataSource = Gram_val
            ComBxGoCaret.DisplayMember = "GoldCaretBasic"
            ComBxGoCaretPay999.DataSource = Gram_val
            ComBxGoCaretPay999.DisplayMember = "GoldCaretBasic"
        End If
        Dim ComBx999 As DataTable = GetRecordSet("SELECT GoldCaretTrans FROM  dbo.TPSellBuyWholesale GROUP BY GoldCaretTrans")
        If ComBx999.Rows.Count > 0 Then
            ComBxGoCaret999.DataSource = ComBx999
            ComBxGoCaret999.DisplayMember = "GoldCaretTrans"
            ComBxGoCaretPay.DataSource = ComBx999
            ComBxGoCaretPay.DisplayMember = "GoldCaretTrans"
        End If
    End Sub
    Public Sub ActivInput(ByVal Activ As Boolean)
        If Activ = False Then
            btnPayPrint.Enabled = False
        ElseIf Activ = True Then
            btnPayPrint.Enabled = True
        Else
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

        cmbPayMethod.SelectedIndex = -1
        cmbPayMethod1.SelectedIndex = 0
        cmbPayMethod2.SelectedIndex = 1
        cmbPayMethod3.SelectedIndex = 2
        cmbPayMethod4.SelectedIndex = 3
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Public Sub CalcGoldTotal()
        Dim weight As Decimal = 0D
        Dim gramPrice As Decimal = 0D
        Decimal.TryParse(TxtGoCaretPay.Text.Replace(",", "."),
                         Globalization.NumberStyles.Any,
                         Globalization.CultureInfo.InvariantCulture,
                         weight)
        Decimal.TryParse(txtGramPrice.Text.Replace(",", "."),
                         Globalization.NumberStyles.Any,
                         Globalization.CultureInfo.InvariantCulture,
                         gramPrice)
        ' حساب الإجمالي مع التقريب لثلاث منازل
        Dim total As Decimal = Math.Round(weight * gramPrice, 3)
        TxtBxTotalGoldKD.Text = Math.Round(total, 3)
    End Sub
    Private Sub TPSellBuyWholesale_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles TPSellBuyWholesale.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If TPSellBuyWholesale.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(imgDeleteGrid, CInt((e.CellBounds.Width / 2) - (imgDeleteGrid.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (imgDeleteGrid.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub TPSellBuyWholesale_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TPSellBuyWholesale.CellClick
        If TPSellBuyWholesale.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف فرع" & TPSellBuyWholesale.Rows(e.RowIndex).Cells("ItemDes").Value & "؟" & vbCrLf & "Do You Want To Delete The Branch. " & TPSellBuyWholesale.Rows(e.RowIndex).Cells("ItemDes").Value, vbYesNo) = vbYes Then
                Try
                    MsgBox("تم حذف البيانات المحددة بنجاح." & vbCrLf & "The selected data has been deleted successfully.", MsgBoxStyle.Information, AppTitle)
                    TPSellBuyWholesale.Rows.Remove(TPSellBuyWholesale.SelectedRows(0))
                    TotalPriceFromGred()
                Catch ex As Exception
                    MsgBox("تم حذف البيانات المحددة بنجاح." & vbCrLf & "The selected data has been deleted successfully.", MsgBoxStyle.Information, AppTitle)
                End Try
            End If
        End If
    End Sub

    Private Sub SellBuyWholesale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGV_Style.ApplyGoldenStyle(TPSellBuyWholesale) : DGV_Style.AutoFitColumns(TPSellBuyWholesale)
        ApplyIconsToContainer(Me)
        ControlsAsColor(ColorSelect:=Me)
        ActivInput(Activ:=False)
        ChkBoxCastomerdata.Checked = True
        'Panel1.Location = New System.Drawing.Size(0, 258)
        'Me.Size = New Size(981, 749)
        DateInv.CustomFormat = "dd/MM/yyyy"
        language_start(Name)
        ChkBoxComdetels.Checked = True
        ChBoxAutCalculation.Checked = True
        CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 255)}
        Try
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
        End Try
        txtGoCaretPrice.Text = 0
        TxtTotalGoledPrice.Text = 0
        TxtMakeCharge.Text = 0
        TxtTotMakeCharge.Text = 0
        GetData()
        ComBxGoCaret.Text = ""
        ComBxGoCaret999.Text = ""
        GetPayMethodSelect()
        GetPayMethod()
    End Sub
    Private Sub ComBxGoCaret_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret.DropDown
        GetGramPrice()
    End Sub
    Private Sub TxtBoxWeightPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGramPrice.TextChanged
        CalcGoldTotal()
    End Sub
    Private Sub ComBxGoCaret_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret.SelectedIndexChanged
        Try
            GetGramPrice()
            GoldWeight()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadButSell_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButSell.CheckedChanged
        GetGramPrice()
        If RadButSell.Checked = True Then
            CheckedInv = 0
        End If
    End Sub

    Private Sub RadButBuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButBuy.CheckedChanged
        GetGramPrice()
        If RadButBuy.Checked = True Then
            CheckedInv = 1
        End If
    End Sub

    Private Sub ComBxGoCaret_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComBxGoCaret.SelectedValueChanged
        Try
            GetGramPrice()
            GoldWeight()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComBxGoCaret_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComBxGoCaret.TextChanged
        GetGramPrice()

    End Sub

    Private Sub TxtlKNET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            'Dim KNET As Decimal = Val(TxtlKNET.Text)
            'Dim Cash As Decimal = Val(TxtCash.Text)
            'Dim Price As Decimal = Val(LinkTotalPrice.Text)
            'TxtCash.Text = LinkTotalInvRemaining.Text.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtlKNET_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)
            Dim Price As Decimal = Val(LinkTotalInvPricerequired.Text)
            LinkTotalInvRemaining.Text = Price - (KNET)
        Catch ex As Exception
        End Try
        NegativeColor()
    End Sub

    Private Sub TxtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)
            'Dim KNET As Decimal = Val(TxtlKNET.Text)
            'Dim Cash As Decimal = Val(TxtCash.Text)
            Dim Price As Decimal = Val(LinkTotalInvPricerequired.Text)
            LinkTotalInvRemaining.Text = Price - (KNET)
        Catch ex As Exception
        End Try
        NegativeColor()
    End Sub

    Private Sub btnPayPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayPrint.Click
        Dim Price As Decimal = Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)
        If RadButSell.Checked = True Then
            If Val(LinkTotalInvRemaining.Text) < 0 Then
                MsgBox("القيمه المدخله اكبر من مبلغ الفاتوره" & vbCrLf & "The entered value is greater than the invoice amount", , "خطأ")
                Exit Sub
            ElseIf Val(LinkTotalInvRemaining.Text) > 0 And Val(Price) = 0 Then
                InvType = If(frmLogin.rbtnEn.Checked = True, "Credit" & RadButSell.Text & "Invoice", "أجـل" & RadButSell.Text & "فاتورة")
            ElseIf Val(LinkTotalInvRemaining.Text) = 0 And Val(Price) Then
                InvType = If(frmLogin.rbtnEn.Checked = True, "Cash" & RadButSell.Text & "Invoice", "نقدا" & RadButSell.Text & "فاتورة")
            End If
        ElseIf RadButBuy.Checked Then
            If Val(LinkTotalInvRemaining.Text) < 0 Then
                MsgBox("القيمه المدخله اكبر من مبلغ الفاتوره" & vbCrLf & "The entered value is greater than the invoice amount", , "خطأ")
                Exit Sub
            ElseIf Val(LinkTotalInvRemaining.Text) > 0 And Val(Price) Then
                InvType = If(frmLogin.rbtnEn.Checked = True, "Credit" & RadButBuy.Text & "Invoice", "أجـل" & RadButBuy.Text & "فاتورة")
            ElseIf Val(LinkTotalInvRemaining.Text) = 0 And Val(Price) Then
                InvType = If(frmLogin.rbtnEn.Checked = True, "Cash" & RadButBuy.Text & "Invoice", "نقدا" & RadButBuy.Text & "فاتورة")
            End If
        End If
        SaveDataFromTPSellBuyWholesale(InvID)
        PaymentWholesalePrinting.SaveMode = True
        PaymentWholesalePrinting.comboxInvNO.Text = InvID
        PaymentWholesalePrinting.comboxInvNO.Enabled = False
        PaymentWholesalePrinting.ShowDialog()

    End Sub
    Private Sub TxtGoCaret_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGoCaret.TextChanged
        GoldWeight()
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged
        GetGramPrice()
    End Sub

    Private Sub ComBxGoCaret999_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.TextChanged
        GoldWeight()
        GetGramPrice()
    End Sub
    Private Sub TxtMakeCharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMakeCharge.TextChanged
        GetMakeCharge()
    End Sub

    Private Sub TxtTotalGoledPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotalGoledPrice.TextChanged
        GetMakeCharge()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ChkBoxCastomerdata.Checked = True Then
            Dim CID As String = CivilIDForm.txtCID.Text.Trim
            If CivilIDForm.SaveCustomerData() = False Then
                Exit Sub
            Else
                CivilIDForm.txtCID.Enabled = False
            End If
        ElseIf ChkBoxCastomerdata.Checked = False Then
        Else
        End If
        If CheckedInv = "CheckedInv" Then
            MsgBox("اختر نوع الفاتوره" & vbCrLf & "Select The Invoce type", , "خطأ")
            SelectInvTyp.BackColor = Color.LawnGreen
            RadButSell.BackColor = Color.Chartreuse
            RadButBuy.BackColor = Color.Chartreuse
            SelectInvTyp.BorderStyle = BorderStyle.Fixed3D
            Exit Sub
        End If
        If ComBxCashier.Text = "اختر الكاشير" OrElse ComBxCashier.Text = "" OrElse ComBxCashier.Text = "Select Cashier" Then
            MsgBox("اسم الكاشير لم يتم إدخاله" & vbCrLf & "Please Select Cashier", , "خطأ")
            ComBxCashier.DroppedDown = True
            Exit Sub
        End If
        If cmbBranches.Text = "اختر اسم الفرع" OrElse cmbBranches.Text = "Select the Branches" Then
            MsgBox("اختر اسم الفرع" & vbCrLf & "Select the Branches", , "خطأ")
            cmbBranches.DroppedDown = True
            Exit Sub
        End If
        'ComBxGoCaret
        If ComBxGoCaret.Text = "" OrElse ComBxGoCaret.Text = IsDBNull(ComBxGoCaret.Text) Then
            MsgBox("لم يتم تحديد عيار البيع" & vbCrLf & "sale karat Is Not Select", , "خطأ")
            ComBxGoCaret.DroppedDown = True
            Exit Sub
        End If
        If TxtGoCaret.Text = "" OrElse TxtGoCaret.Text = 0 OrElse TxtGoCaret.Text = "0" OrElse IsDBNull(TxtGoCaret.Text) Then
            MsgBox("ادخل الوزن المباع/المشتري" & vbCrLf & "Enter the Sold/Purchased Weight", , "خطأ")
            TxtGoCaret.Focus()
            Exit Sub
        End If
        If ComBxGoCaret999.Text = "" OrElse ComBxGoCaret999.Text = 0 OrElse ComBxGoCaret999.Text = "0" OrElse IsDBNull(ComBxGoCaret999.Text) Then
            MsgBox("لم يتم تحديد عيار الوزن القائم" & vbCrLf & " Gross Weight Karat Is Not Select", , "خطأ")
            ComBxGoCaret999.Focus()
            Exit Sub
        End If
        If txtGoCaretPrice.Text = "" OrElse txtGoCaretPrice.Text = 0 OrElse txtGoCaretPrice.Text = "0" OrElse IsDBNull(txtGoCaretPrice.Text) Then
            MsgBox("أدخل سعر الجرام" & vbCrLf & "Please Enter Gram Price", , "خطأ")
            txtGoCaretPrice.Focus()
            Exit Sub
        End If
        If Val(TxtTotalGoledPrice.Text) + Val(TxtMakeCharge.Text) + Val(TxtTotMakeCharge.Text) = 0 OrElse Val(TxtTotalGoledPrice.Text) + Val(TxtMakeCharge.Text) + Val(TxtTotMakeCharge.Text) <= 1 Or IsDBNull(Val(TxtTotalGoledPrice.Text) + Val(TxtMakeCharge.Text) + Val(TxtTotMakeCharge.Text) = 0 OrElse Val(TxtTotalGoledPrice.Text) + Val(TxtMakeCharge.Text) + Val(TxtTotMakeCharge.Text)) Then
            MsgBox("أدخل السعر" & vbCrLf & "Please Enter Price", , "خطأ")
            TxtTotalGoledPrice.BackColor = Color.Gold
            TxtMakeCharge.BackColor = Color.Gold
            TxtTotMakeCharge.BackColor = Color.Gold
            Exit Sub
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        With (TPSellBuyWholesale)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("InvIDAuto").Value = Val(InvID)
            .Rows(.Rows.Count - 1).Cells("InvID1").Value = InvoiceStringNo(Val(InvID))
            .Rows(.Rows.Count - 1).Cells("CashierID").Value = ComBxCashier.SelectedValue
            .Rows(.Rows.Count - 1).Cells("CastomerCAIVELid").Value = CivilIDForm.txtCID.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("COM_ID").Value = cmbBranches.SelectedValue
            .Rows(.Rows.Count - 1).Cells("ItemDes").Value = ComBoxItemDes.Text.Trim
            '.Rows(.Rows.Count - 1).Cells("ItemImage").Value = PictureBox.Image
            .Rows(.Rows.Count - 1).Cells("GoldCaretBasic").Value = ComBxGoCaret.Text.Trim
            .Rows(.Rows.Count - 1).Cells("GoldCaretBasicValue").Value = TxtGoCaret.Text.Trim
            .Rows(.Rows.Count - 1).Cells("GoldCaretTrans").Value = ComBxGoCaret999.Text.Trim
            .Rows(.Rows.Count - 1).Cells("GoldCaretTransValue").Value = TXTGoCaret999.Text.Trim
            .Rows(.Rows.Count - 1).Cells("GoldCaretPrice").Value = txtGoCaretPrice.Text.Trim
            .Rows(.Rows.Count - 1).Cells("TotalGoledPrice").Value = TxtTotalGoledPrice.Text.Trim
            .Rows(.Rows.Count - 1).Cells("MakeCharge").Value = TxtMakeCharge.Text.Trim
            .Rows(.Rows.Count - 1).Cells("TotalMakeCharge").Value = TxtTotMakeCharge.Text.Trim
            .Rows(.Rows.Count - 1).Cells("InvDate").Value = DateToSave(DateInv.Value)
            .Rows(.Rows.Count - 1).Cells("InvDateTime").Value = Format(DateInv.Value, "dd/MM/yyyy hh:mm:ss")
            .Rows(.Rows.Count - 1).Cells("ActualInvDateTime").Value = Format(DateInv.Value, "dd/MM/yyyy hh:mm:ss")
            .Rows(.Rows.Count - 1).Cells("UserID").Value = (User)
            .Rows(.Rows.Count - 1).Cells("InvActive").Value = "1"
            .Rows(.Rows.Count - 1).Cells("ItemActive").Value = "1"
            .Rows(.Rows.Count - 1).Cells("InvType1").Value = CheckedInv
            .Rows(.Rows.Count - 1).Cells("InvActiveaComp").Value = If(ChkBoxComdetels.Checked = True, "1", "0")
        End With
        TotalPriceFromGred()
        ActivInput(Activ:=True)
        TxtTotalGoledPrice.Text = ""
        TxtMakeCharge.Text = ""
        TxtTotMakeCharge.Text = ""
        TXTGoCaret999.Text = ""
        TxtGoCaret.Text = ""
        TxtGoCaret.Text = ""
    End Sub

    Private Sub ComBoxItemDes_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBoxItemDes.DropDown
        Dim GetItemDes As DataTable = GetRecordSet("SELECT ItemDes FROM TPSellBuyWholesale GROUP BY ItemDes")
        If GetItemDes.Rows.Count > 0 Then
            ComBoxItemDes.DataSource = GetItemDes
            ComBoxItemDes.DisplayMember = ("ItemDes")
            ComBoxItemDes.ValueMember = "ItemDes"
        End If
    End Sub

    Private Sub btnAddComName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddComName.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub ComBxComName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranches.SelectedIndexChanged

    End Sub

    Private Sub ComBxCashier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxCashier.SelectedIndexChanged

    End Sub

    Private Sub ComBxComName_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranches.DropDown
        'Dim COMPANY_BAY_DETELS As DataTable = GetRecordSet("select COMP_NAME,COM_ID from COMPANY_BAY_DETELS")
        'If COMPANY_BAY_DETELS.Rows.Count > 0 Then
        '    ComBxComName.DataSource = COMPANY_BAY_DETELS
        '    ComBxComName.DisplayMember = "COMP_NAME"
        '    ComBxComName.ValueMember = "COM_ID"
        'End If
    End Sub

    Private Sub TxtTotMakeCharge_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotMakeCharge.TextChanged
        GetMakeCharge()
    End Sub

    Private Sub ChkBoxCastomerdata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBoxCastomerdata.CheckedChanged

    End Sub

    Private Sub LabGoCaret_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LabGoCaret.LinkClicked
        Dim CaretChnge As Decimal
        If Val(ComBxGoCaret.Text) < 100 Then
            CaretChnge = Val(ComBxGoCaret.Text) / 24 * 1000
            ComBxGoCaret.Text = Val(CaretChnge)
        Else

        End If

    End Sub

    Private Sub TxtCash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            'Dim KNET As Decimal = Val(TxtlKNET.Text)
            'Dim Cash As Decimal = Val(TxtCash.Text)
            'Dim Price As Decimal = Val(LinkTotalPrice.Text)
            'TxtlKNET.Text = LinkTotalInvRemaining.Text.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtlKNET_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'TxtCash.Text = Val(LinkTotalInvRemaining.Text)
    End Sub

    Private Sub lblPayMethod1_Click(sender As Object, e As EventArgs) Handles lblPayMethod1.Click

    End Sub

    Private Sub lblLabGoCaret_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLabGoCaret.LinkClicked
        Dim CaretChnge As Decimal
        If Val(ComBxGoCaretPay999.Text) < 100 Then
            CaretChnge = Val(ComBxGoCaretPay999.Text) / 24 * 1000
            ComBxGoCaretPay999.Text = Val(CaretChnge)
        Else
        End If
    End Sub

    Private Sub txtGoldw_TextChanged(sender As Object, e As EventArgs) Handles txtGoldw.TextChanged
        CalcGoldTotal()
        GoldWeightSale()
    End Sub
    Private Sub ComBxGoCaretPay_Changed(sender As Object, e As EventArgs) _
    Handles ComBxGoCaretPay.TextChanged, ComBxGoCaretPay.SelectedIndexChanged
        GoldWeightSale()
    End Sub
    Private Sub ComBxGoCaretPay999_Changed(sender As Object, e As EventArgs) _
    Handles ComBxGoCaretPay999.TextChanged, ComBxGoCaretPay999.SelectedIndexChanged
        GoldWeightSale()
    End Sub


    Private Sub TxtGoCaretPay_TextChanged(sender As Object, e As EventArgs) Handles TxtGoCaretPay.TextChanged
        CalcGoldTotal()

    End Sub

    Private Sub ComBxGoCaretPay999_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBxGoCaretPay999.SelectedIndexChanged
        GetGramPrice()
        GoldWeightSale()
    End Sub
    Private Sub GoldWeightSale()
        Try
            TxtGoCaretPay.Text = Val(txtGoldw.Text) * Val(ComBxGoCaretPay999.Text / ComBxGoCaretPay.Text).ToString("#,###,###,###.000")
        Catch ex As Exception
        End Try
        'Dim weight As Decimal = Val(txtGoldw.Text)
        'Dim num As Decimal = Val(ComBxGoCaretPay999.Text)
        'Dim den As Decimal = Val(ComBxGoCaretPay.Text)
        'Dim result As Decimal = 0D
        'If den <> 0 Then
        '    result = weight * (num / den)
        'End If
        'TxtGoCaretPay.Text = result.ToString("#,###,###,###.000")
    End Sub
    Private Sub GoldWeight()
        Try
            TXTGoCaret999.Text = Val(TxtGoCaret.Text) * Val(ComBxGoCaret.Text / ComBxGoCaret999.Text).ToString("#,###,###,###.000")
        Catch ex As Exception
            'Return
        End Try
    End Sub
    Private Sub CalcRemaining()
        Dim knet As Decimal = Val(txtKnet.Text)
        Dim bank1 As Decimal = Val(txtBank1.Text)
        Dim bank2 As Decimal = Val(txtBank2.Text)
        Dim bank3 As Decimal = Val(txtBank3.Text)
        Dim bank4 As Decimal = Val(txtBank4.Text)
        Dim goldTotal As Decimal = Val(TxtBxTotalGoldKD.Text)
        Dim totalPaid As Decimal = knet + bank1 + bank2 + bank3 + bank4 + goldTotal
        Dim totalInv As Decimal = Val(LinkTotalInvPricerequired.Text)
        Dim remaining As Decimal = totalInv - totalPaid
        If remaining < 0 Then
            MsgBox("لا يمكنك المتابعة لأن المبلغ المدفوع أكبر من إجمالي الفاتورة." & vbCrLf &
               "You cannot continue because the paid amount is greater than the invoice total.",
               MsgBoxStyle.Critical, "خطأ / Error")
            LinkTotalInvRemaining.Text = remaining.ToString("0.000")
            Exit Sub
        End If
        LinkTotalInvRemaining.Text = remaining.ToString("0.000")
    End Sub

    Private Sub Amounts_TextChanged(sender As Object, e As EventArgs) _
    Handles txtKnet.TextChanged,
            txtBank1.TextChanged,
            txtBank2.TextChanged,
            txtBank3.TextChanged,
            txtBank4.TextChanged,
            TxtBxTotalGoldKD.TextChanged,
            LinkTotalInvPricerequired.TextChanged
        CalcRemaining()
    End Sub
End Class

