Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports PACICardLibrary
Imports System.Data.SqlClient
Imports CefSharp
Imports CefSharp.WinForms
Imports System.Drawing.Drawing2D

Public Class frmMain
    Public txtTotalAmoun As New Label
    Public txtCachAmount As New Label
    Public txtBankAmount As New Label
    Public txtMakeCharge As New Label
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub Discoloration()
        ControlsAsColor(ColorSelect:=Me)
    End Sub
    Public Update_url As String
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ApplyIconsToButtons(Me)
        PicDateFrom.Enabled = True
        PicDateTo.Enabled = True
        Timer1.Start()
        Companylicense()
        CpuIdSystemSerialNumber = (CpuId.Trim & SystemSerialNumber.Trim & licenseID).Replace(" ", "")
        Permissions()
        'If My.Computer.Keyboard.CtrlKeyDown Then

        'End If

        If My.Computer.Keyboard.CtrlKeyDown = False Then
            GetMySQLData()
        End If
        DaysRemaining(EndDate:=DateToSave(Date.Now).ToString, TodayDate:=DateToSave(EndDate).ToString)
        Me.BackColor = My.MySettings.Default.ColorSet
        FrmBackgWork.RunWorkerAsync()
        CheckUserPermissions(userID:=UserID)
        language_start(Name)
        Try
            Dim Active As Integer
            Dim GetFild As DataTable = OnlinGetRecordSet("SELECT IMGEActive FROM  ADS_SERVICES")
            If GetFild.Rows.Count > 0 Then
                Active = GetFild.Rows(0)("IMGEActive").ToString
                If Active = 1 Then
                    FrmAdvertisement.ShowDialog()
                ElseIf Active = 1 Then

                End If
            End If
        Catch ex As Exception
        End Try

        Try
            GoldPrice.ClearBindings()
            GoldPrice.Bind(pnlPrice24, lbl24, "24_buy")
            GoldPrice.Bind(pnlPrice22, lbl22, "22_buy")
            GoldPrice.Bind(pnlPrice21, lbl21, "21_buy")
            GoldPrice.Bind(pnlPrice18, lbl18, "18_buy")
            GoldPrice.Bind(pnlPrice925, lblSilver925, "silver925_buy")
            GoldPrice.Bind(pnlPriceOunce, lblOunce, "ounce_buy")
            GoldPrice.Bind(Panel9, lblSellOunceUsd, "OZK_buy")

            GoldPrice.Bind(Panel4, lbl24BUY, "24_sell")
            GoldPrice.Bind(Panel5, lbl22BUY, "22_sell")
            GoldPrice.Bind(Panel6, lbl21BUY, "21_sell")
            GoldPrice.Bind(Panel7, lbl18BUY, "18_sell")
            GoldPrice.Bind(Panel3, lblSilver925BUY, "silver925_sell")
            GoldPrice.Bind(Panel2, lblOunceBUY, "ounce_sell")
            GoldPrice.Bind(Panel8, lblBuyOunceUsd, "OZK_sell")
            Dim adj As GoldPrice.Adjustments
            adj.TEX24BUY = Val(lbl24BUY.Text)
            adj.TEX22BUY = Val(lbl22BUY.Text)
            adj.TEX21BUY = Val(lbl21BUY.Text)
            adj.TEX18BUY = Val(lbl18BUY.Text)
            adj.TEX925BUY = Val(lblSilver925BUY.Text)
            adj.TEXOnceBUYUsd = Val(lblSellOunceUsd.Text)
            adj.EX24Sell = Val(lbl24.Text)
            adj.TEX22Sell = Val(lbl22.Text)
            adj.TTEX21Sell = Val(lbl21.Text)
            adj.TEX18Sell = Val(lbl18.Text)
            adj.TEX925Sell = Val(lblSilver925.Text)
            adj.TEXOnceBUY = Val(lblOunce.Text)
            adj.TEXOnceSell = Val(lblSellOunceUsd.Text)
            adj.TEXOnceBUYUsd = Val(lblBuyOunceUsd.Text)
            GoldPrice.StartAutoUpdate(PriceLinek, PriceCurrency, adj)
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try

        UpdateLicenseIDGoldApiAsync()
    End Sub
    Private Sub FrmBackgWork_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles FrmBackgWork.DoWork
        Discoloration()
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        lblUserName.Invoke(Sub() lblUserName.Text = frmLogin.txtUserName.Text)
        AutoUpdatePrice = If(SET_INVARCHR142TextBox.Text = "", "1", SET_INVARCHR142TextBox.Text)
        GetCurrency()
        Try
            dtEndDate.Value = EndDate
        Catch ex As Exception
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            lblVersion.Invoke(Sub() lblVersion.Text = "VersionNo" & Format(File.GetLastWriteTime(Application.ExecutablePath), "yyyyMMdd"))
            Dim DtCompanyName As DataTable = GetRecordSet(" select * from [comp_inform]")
            If DtCompanyName.Rows.Count > 0 Then
                CurrentCompanyName = DtCompanyName.Rows(0)("comp_name").ToString
                If Not IsDBNull((DtCompanyName.Rows(0)("logo"))) Then
                    LogoPictureBox.Image = ByteToImage(DtCompanyName.Rows(0)("logo"))
                ElseIf IsDBNull((DtCompanyName.Rows(0)("logo"))) Or Nothing Then
                    LogoPictureBox.Image = Drawing.Image.FromFile(Application.StartupPath & "\SAIBLOGOlast.png")
                End If
                lblCompanyName.Invoke(Sub() lblCompanyName.Text = CurrentCompanyName)
            End If
        Catch ex As Exception
            RecordRrrors(ex.ToString)
            Return
        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ADD_CARET_PRICE()
        lood_add_price()
        ADS_SERVICES_Get_Now()
        Report_Path.LOOD_DATA()
        GetBackupValues()
        CleanSignatureImages()
        UpdateLastOpenAsync()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        If HaveInternetConnection() = True Then
            Try
                Dim mysqlcon As New SqlConnection
                Dim mySqlcmd As New SqlCommand
                Dim myD_Reader As SqlDataReader
                Dim myD_Table As New DataTable
                Dim myD_Adapter As New SqlDataAdapter
                mysqlcon.ConnectionString = OnLineSqlConnection
                mysqlcon.Open()
                mySqlcmd.Connection = mysqlcon
                mySqlcmd.CommandText = "SELECT * FROM ADS_SERVICES"
                myD_Reader = mySqlcmd.ExecuteReader
                myD_Table.Load(myD_Reader)
                myD_Reader.Close()
                mysqlcon.Close()
                lblTechSupport.Invoke(Sub() lblTechSupport.Text = myD_Table.Rows(0)("TEL").ToString)
                Update_url = myD_Table.Rows(0)("Update_url").ToString

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                GlCommand.CommandText = "DELETE FROM [ADS_SERVICES]"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [ADS_SERVICES]" & vbCrLf &
                                                  "([ID]" & vbCrLf &
                                                  ",[IMGE1]" & vbCrLf &
                                                  ",[IMGE2]" & vbCrLf &
                                                  ",[IMGE3]" & vbCrLf &
                                                  ",[IMGE4]" & vbCrLf &
                                                  ",[IMGE5]" & vbCrLf &
                                                  ",[IMGE6]" & vbCrLf &
                                                  ",[TEXT_LINE]" & vbCrLf &
                                                  ",[TEL]" & vbCrLf &
                                                  ",[TEL2]" & vbCrLf &
                                                  ",[Update_url])" & vbCrLf &
                                                  "VALUES" & vbCrLf &
                                                  "(@ID" & vbCrLf &
                                                  ",@IMGE1" & vbCrLf &
                                                  ",@IMGE2" & vbCrLf &
                                                  ",@IMGE3" & vbCrLf &
                                                  ",@IMGE4" & vbCrLf &
                                                  ",@IMGE5" & vbCrLf &
                                                  ",@IMGE6" & vbCrLf &
                                                  ",@TEXT_LINE" & vbCrLf &
                                                  ",@TEL" & vbCrLf &
                                                  ",@TEL2" & vbCrLf &
                                                  ",@Update_url)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@ID", myD_Table.Rows(0)("ID").ToString)
                    .AddWithValue("@IMGE1", myD_Table.Rows(0)("IMGE1").ToString)
                    .AddWithValue("@IMGE2", myD_Table.Rows(0)("IMGE2").ToString)
                    .AddWithValue("@IMGE3", myD_Table.Rows(0)("IMGE3").ToString)
                    .AddWithValue("@IMGE4", myD_Table.Rows(0)("IMGE4").ToString)
                    .AddWithValue("@IMGE5", myD_Table.Rows(0)("IMGE5").ToString)
                    .AddWithValue("@IMGE6", myD_Table.Rows(0)("IMGE6").ToString)
                    .AddWithValue("@TEXT_LINE", myD_Table.Rows(0)("TEXT_LINE").ToString)
                    .AddWithValue("@TEL", myD_Table.Rows(0)("TEL").ToString)
                    .AddWithValue("@TEL2", myD_Table.Rows(0)("TEL2").ToString)
                    .AddWithValue("@Update_url", myD_Table.Rows(0)("Update_url").ToString)
                End With
                GlCommand.ExecuteNonQuery()
                Exit Sub
                'End If
            Catch ex As Exception
                '    MsgBox(ex.ToString)
            End Try
        ElseIf HaveInternetConnection() = False Then
            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM ADS_SERVICES ")
            If dt1.Rows.Count > 0 Then
                lblTechSupport.Invoke(Sub() lblTechSupport.Text = dt1.Rows(0)("TEL").ToString)
                Update_url = Decryption(dt1.Rows(0)("Update_url").ToString)
            Else
            End If
        End If
        Exit Sub
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''

        '

    End Sub
    Public Sub CleanSignatureImages()
        Dim myFile As String
        Dim mydir As String = Application.StartupPath
        For Each myFile In Directory.GetFiles(mydir, "sig*.png")
            File.Delete(myFile)
        Next
    End Sub
    Private Sub ShowPrices()
        lblOunce.Text = goldOunce
        lbl24.Text = gold24
        lbl22.Text = gold22
        lbl21.Text = gold21
        lbl18.Text = gold18
        'lblSilver925.Text = silverKg / 1000
        lblSilver925.Text = Format((lblSilver925.Text) / 1000, "#,#.##")
        '''''''''''''''''''''''''''''''''''''''''''
        lblOunceBUY.Text = goldOunce
        lbl24BUY.Text = gold24
        lbl22BUY.Text = gold22
        lbl21BUY.Text = gold21
        lbl18BUY.Text = gold18
        'lblSilver925BUY.Text = silverKg / 1000
        lblSilver925.Text = Format((lblSilver925.Text) / 1000, "#,#.##")
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        Try
            If Date.Now.Second Mod 1000 = 0 Then
                'ADS_SERVICES()
            End If


            If Date.Now.Second Mod 10 = 0 Then
                method_api()
                lood_add_price()
            End If






            lblDateTime.Text = Now
            If lblCompanyName.Left < Width Then
                lblCompanyName.Left += 3
            Else
                lblCompanyName.Left = -lblUser.Width
            End If
            If lblTechSupport.Left < Width Then
                lblTechSupport.Left += 3
            Else
                lblTechSupport.Left = -lblTechSupport.Width
            End If
            If TimeString = BackupHour & ":" & BackupMinute & ":00" Then
                ManualBackup = False
                frmBackup.Show()
                frmBackup.btnSave.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMain_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Leave
        min.Close()
        Close()
        Application.Exit()
    End Sub
#Region "Buttons"
    Private Sub pbClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        LogoPictureBox.Visible = True
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click, lblCurrencySale.Click
        method_api()
        SetGoledPrice.ShowDialog()
    End Sub

    Private Sub btnSell_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSell.Click
        Try
            UpdateLastOpenAsync()

        Catch ex As Exception
        End Try
        Timer1.Stop()
        min_Sales.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub btnSell_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles btnSell.KeyDown
        If e.KeyCode = Keys.S Then
            btnSell.PerformClick()
        End If
    End Sub

    Private Sub btnBarCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBarCode.Click
        Timer1.Stop()
        min_BarCode.ShowDialog()
        Timer1.Start()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Dim URL As String
        Dim GetFild As DataTable = OnlinGetRecordSet("SELECT Update_url FROM  ADS_SERVICES")
        If GetFild.Rows.Count > 0 Then
            URL = (GetFild.Rows(0)("Update_url").ToString)

        End If
        Dim webAddress As String = URL
        Process.Start(webAddress)
    End Sub
    Private Sub btnBulkSell_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBulkSell.Click
        SellBuyWholesale.ShowDialog()
    End Sub
    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
        LogoPictureBox.Visible = False
    End Sub

    Private Sub btnBackup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackup.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            ManualBackup = False
            frmBackup.Show()
            frmBackup.btnSave.PerformClick()
        Else
            ManualBackup = True
            Timer1.Stop()
            frmBackup.ShowDialog()
            Timer1.Start()
        End If
    End Sub
    'Private Sub Button_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btnBarCode.MouseMove, btnItem.MouseMove, btnKarat.MouseMove, btnReport.MouseMove, btnExpense.MouseMove, btnStock.MouseMove, btnBackup.MouseMove, btnBuy.MouseMove, btnUpdate.MouseMove, btnBulkSell.MouseMove, btnSell.MouseMove
    '    sender.Width = 194
    '    sender.Height = 45
    'End Sub

    'Private Sub Button_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles btnBarCode.MouseLeave, btnBarCode.MouseLeave, btnItem.MouseLeave, btnKarat.MouseLeave, btnReport.MouseLeave, btnExpense.MouseLeave, btnStock.MouseLeave, btnBackup.MouseLeave, btnBuy.MouseLeave, btnUpdate.MouseLeave, btnBulkSell.MouseLeave, btnSell.MouseLeave
    '    sender.Width = 184
    '    sender.Height = 35
    'End Sub

    Private Sub btnBuy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuy.Click
        Try
            UpdateLastOpenAsync()
        Catch ex As Exception
        End Try
        Timer1.Stop()
        min_Buy.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub btnStock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStock.Click
        Try
            UpdateLastOpenAsync()
        Catch ex As Exception
        End Try
        Timer1.Stop()
        min_Stock.ShowDialog()
        Timer1.Start()
    End Sub
    Private Sub btnItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItem.Click
        Timer1.Stop()
        min_Items.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub btnCarat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnKarat.Click
        Timer1.Stop()
        GramPrice.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub btnExpense_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpense.Click
        Timer1.Stop()
        Expenses.ShowDialog()
        Timer1.Start()
    End Sub
#End Region

#Region "mnuSettings"
    Private Sub tsSettingsMainCompanyData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsMainCompanyData.Click
        CompanyDetails.ShowDialog()
    End Sub
    Private Sub tsSettingsMainGramPrice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsMainGramPrice.Click
        GramPrice.ShowDialog()
    End Sub

    Private Sub tsSettingsMainCountryOfOrigin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsMainCountryOfOrigin.Click
        CountryMade.ShowDialog()
    End Sub
    Private Sub tsSettingsDefinitionStoneName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionStoneName.Click
        StoneAdd.ShowDialog()
    End Sub
    Private Sub tsSettingsDefinitionStoneColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionStoneColor.Click
        StoneColor.ShowDialog()
    End Sub
    Private Sub tsSettingsDefinitionDiamondCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionDiamondCut.Click
        DiamondCut.ShowDialog()
    End Sub

    Private Sub tsSettingsDefinitionAddItemCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionAddItemCategory.Click
        AuctionCategory.ShowDialog()
    End Sub
    Private Sub tsSettingsDefinitionBrands_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionBrands.Click
        AuctionBrand.ShowDialog()
    End Sub
    Private Sub tsSettingsDefinitionItemName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsDefinitionItemName.Click
        ItemName_ADD.ShowDialog()
    End Sub
    Private Sub tsSettingsLanguageEnglish_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsLanguageEnglish.Click
        frmLogin.rbtnEn.Checked = True
        language_start(Name)
        MsgBox("The English language Was Chosen", , "Language Change")
    End Sub

    Private Sub tsSettingsLanguageArabic_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsLanguageArabic.Click
        frmLogin.rbtnAr.Checked = True
        language_start(Name)
        MsgBox("تم اختيار اللغة العربية", , "تغيير اللغة")
    End Sub
    Private Sub tsSettingsProgrammer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsSettingsProgrammer.Click
        min_Settings.ShowDialog()
    End Sub
#End Region

#Region "mnuReport"

    Private Sub tsReportSellViewGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewGold.Click
        'GoldOrSilver = True
        'DeletedInvoice = False
        GoldViewSellInvoice.ShowDialog()
    End Sub
    Private Sub tsReportSellViewSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewSilver.Click
        'GoldOrSilver = False
        'DeletedInvoice = False
        SilverViewSellInvoice.ShowDialog()
    End Sub
    Private Sub tsReportSellViewDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewDiamond.Click
        DiamondViewSellInvoice.ShowDialog()
    End Sub
    Private Sub tsReportSellViewAuction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewAuction.Click
        AuctionViewSellInvoice.ShowDialog()
    End Sub
    Private Sub tsReportSellViewAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewAccessories.Click
        Accessories_ViewSellInvoice.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportSellDetailedGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellDetailedGold.Click
        ReportGoldSellDetailed.ShowDialog()
    End Sub
    Private Sub tsReportSellDetailedSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellDetailedSilver.Click
        ReportSilverSellDetailed.ShowDialog()
    End Sub
    Private Sub tsReportSellDetailedDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellDetailedDiamond.Click
        'ReportDiamondSellDetailed.ShowDialog()
        ReportDiamondSellDetailedPortrait.ShowDialog()
    End Sub

    Private Sub tsReportSellDetailedDiamondPortrait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReportDiamondSellDetailedPortrait.ShowDialog()
    End Sub
    Private Sub tsReportSellDetailedAuction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellDetailedAuction.Click
        ReportAuctionSellDetailed.ShowDialog()
    End Sub
    Private Sub tsReportSellDetailedAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellDetailedAccessories.Click
        ReportAccessoriesSellDetailed.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportSellShortGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellShortGold.Click
        ReportGoldSellShort.ShowDialog()
    End Sub
    Private Sub tsReportSellShortSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellShortSilver.Click
        ReportSilverSellShort.ShowDialog()
    End Sub
    Private Sub tsReportSellShortDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellShortDiamond.Click
        ReportDiamondSellShort.ShowDialog()
    End Sub
    Private Sub tsReportSellShortAuction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellShortAuction.Click
        ReportAuctionSellShort.ShowDialog()
    End Sub
    Private Sub tsReportSellShortAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellShortAccessories.Click
        ReportAccessoriesSellShort.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportItemByCaratGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemByCaratGold.Click
        GoldOrSilver = True
        ReportGoldByKarat.ShowDialog()
    End Sub
    Private Sub tsReportItemByCaratSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemByCaratSilver.Click
        GoldOrSilver = False
        ReportGoldByKarat.ShowDialog()
    End Sub
    Private Sub tsReportSellViewGoldDeleted_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewGoldDeleted.Click
        GoldOrSilver = True
        DeletedInvoice = True
        GoldViewSellInvoice.ShowDialog()
    End Sub
    Private Sub tsReportSellViewSilverDeleted_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportSellViewSilverDeleted.Click
        GoldOrSilver = False
        DeletedInvoice = True
        GoldViewSellInvoice.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportBuyViewGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyViewGold.Click
        GoldOrSilver = True
        GoldViewBuyInvoice.ShowDialog()
    End Sub
    Private Sub tsReportBuyViewSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyViewSilver.Click
        GoldOrSilver = False
        GoldViewBuyInvoice.ShowDialog()
    End Sub
    Private Sub tsReportBuyViewDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyViewDiamond.Click
        DiamondViewBuyInvoice.ShowDialog()
    End Sub
    Private Sub tsReportBuyViewAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyViewAccessories.Click
        AccessoriesViewBuyInvoice.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportBuyDetailedGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyDetailedGold.Click
        GoldOrSilver = True
        ReportGoldBuyDetailed.ShowDialog()
    End Sub
    Private Sub tsReportBuyDetailedSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyDetailedSilver.Click
        GoldOrSilver = False
        ReportGoldBuyDetailed.ShowDialog()
    End Sub
    Private Sub tsReportBuyDetailedDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyDetailedDiamond.Click
        ReportDiamondBuyDetailed.ShowDialog()
    End Sub

    Private Sub tsReportBuyDetailedAuction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyDetailedAuction.Click
        ReportAuctionReceiveDetailed.ShowDialog()
    End Sub
    Private Sub tsReportBuyDetailedAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyDetailedAccessories.Click
        ReportAccessoriesBuyDetailed.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportBuyShortGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyShortGold.Click
        GoldOrSilver = True
        ReportGoldBuyShort.ShowDialog()
    End Sub
    Private Sub tsReportBuyShortSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyShortSilver.Click
        GoldOrSilver = False
        ReportGoldBuyShort.ShowDialog()
    End Sub
    Private Sub tsReportBuyShortDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyShortDiamond.Click
        'ReportDiamondBuyShort.ShowDialog()
    End Sub
    Private Sub tsReportBuyShortAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportBuyShortAccessories.Click
        ReportAccessoriesBuyShort.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportItemsAllGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAllGold.Click
        GoldOrSilver = True
        ReportGoldItemAll.ShowDialog()
    End Sub
    Private Sub tsReportItemsAllSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAllSilver.Click
        GoldOrSilver = False
        ReportGoldItemAll.ShowDialog()
    End Sub
    Private Sub tsReportItemsAllDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAllDiamond.Click
        ReportDiamondItemAll.ShowDialog()
    End Sub
    Private Sub tsReportItemsAllAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAllAccessories.Click
        ReportAccessoriesItemAll.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportItemsSoldGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsSoldGold.Click
        GoldOrSilver = True
        ReportGoldItemSold.ShowDialog()
    End Sub
    Private Sub tsReportItemsSoldSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsSoldSilver.Click
        GoldOrSilver = False
        ReportGoldItemSold.ShowDialog()
    End Sub
    Private Sub tsReportItemsSoldDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsSoldDiamond.Click
        ReportDiamondItemSold.ShowDialog()
    End Sub
    Private Sub tsReportItemsSoldAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsSoldAccessories.Click
        ReportAccessoriesItemSold.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportItemsAvailableGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAvailableGold.Click
        GoldOrSilver = True
        ReportGoldItemAvailable.ShowDialog()
    End Sub
    Private Sub tsReportItemsAvailableSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAvailableSilver.Click
        GoldOrSilver = False
        ReportGoldItemAvailable.ShowDialog()
    End Sub
    Private Sub tsReportItemsAvailableDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAvailableDiamond.Click
        ReportDiamondItemAvailable.ShowDialog()
    End Sub
    Private Sub tsReportItemsAvailableAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportItemsAvailableAccessories.Click
        ReportAccessoriesItemAvailable.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportProfitGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportProfitGold.Click
        'GoldOrSilver = True
        ReportGoldProfit.ShowDialog()
    End Sub

    Private Sub tsReportProfitGoldPerPurchaseCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportProfitGoldPerPurchaseCost.Click
        GoldOrSilver = True
        ReportGoldProfitPerPurchaseCost.ShowDialog()
    End Sub

    Private Sub tsReportProfitSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportProfitSilver.Click
        ReportSilverProfit.ShowDialog()
    End Sub
    Private Sub tsReportProfitDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportProfitDiamond.Click
        ReportDiamondProfit.ShowDialog()
    End Sub
    Private Sub tsReportProfitAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportProfitAccessories.Click
        ReportAccessoriesProfit.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportCustomers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportCustomers.Click
        ReportCustomer.ShowDialog()
    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportExpenses_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportExpenses.Click

    End Sub
    '//////////////////////////////////////'
    Private Sub tsReportCivilIDPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsReportCivilIDPrint.Click
        CivilIDPrint.ShowDialog()
    End Sub
#End Region

#Region "mnuUserManagement"
    Private Sub tsUserManagementUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsUserManagementUser.Click
        frmUsers.ShowDialog()
    End Sub
    Private Sub tsUserManagementCashier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsUserManagementCashier.Click
        Cashier.ShowDialog()
    End Sub
#End Region

#Region "mnuTransactions"
    Private Sub tsTransactionsSellGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsSellGold.Click
        FrmGoldSellEditRemove.ShowDialog()
    End Sub
    Private Sub tsTransactionsSellSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsSellSilver.Click
        SilverSellEditRemove.ShowDialog()
    End Sub
    Private Sub tsTransactionsBuyGold_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsBuyGold.Click
        DeletEeditGold.ShowDialog()
    End Sub
    Private Sub tsTransactionsSellAuction_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsSellAuction.Click
        AuctionSellEditRemove.ShowDialog()
    End Sub
    Private Sub tsTransactionsSellDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsSellDiamond.Click
        DiamondSellEditRemove.ShowDialog()
    End Sub
    Private Sub tsTransactionsSellAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsSellAccessories.Click
        Accessories_SellEditRemove.ShowDialog()
    End Sub

    Private Sub tsTransactionsBuyAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsBuyAccessories.Click
        AccessoriesBuyEditRemove.ShowDialog()
    End Sub
    Private Sub tsTransactionsPayInstallmentGoldSilver_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsPayInstallmentGoldSilver.Click
        PayInstallmentType = "Gold"
        frmPayInstallment.ShowDialog()
    End Sub
    Private Sub tsTransactionsPayInstallmentDiamond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsPayInstallmentDiamond.Click
        PayInstallmentType = "Diamond"
        frmPayInstallment.ShowDialog()
    End Sub

    Private Sub tsTransactionsPayInstallmentAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsTransactionsPayInstallmentAccessories.Click
        PayInstallmentType = "Accessories"
        frmPayInstallment.ShowDialog()
    End Sub
#End Region

#Region "mnuExpenses"
    Private Sub tsExpensesReceiptVoucherCreateNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        resev_mony.ShowDialog()
    End Sub
    Private Sub tsExpensesReceiptVoucherView_Click(ByVal sender As Object, ByVal e As EventArgs)
        rwsev_mony_show.ShowDialog()
    End Sub

    Private Sub tsExpensesPaymentVoucherCreateNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' sent_mony.ShowDialog()
    End Sub


#End Region
#Region "mnuLicense"
    Private Sub tsLicenseGet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsLicenseGet.Click
        licen_key.ShowDialog()
    End Sub

    Private Sub lbl24_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbl24.TextChanged
        Try


            If Val(lbl24.Text) > 0 Then
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lbl24.Text) & "' WHERE [Gram_valu] = N'24'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lbl24.Text) * 23 / 24 & "' WHERE [Gram_valu] = N'23'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lbl24.Text) * 22 / 24 & "' WHERE [Gram_valu] = N'22'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lbl24.Text) * 21 / 24 & "' WHERE [Gram_valu] = N'21'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lbl24.Text) * 18 / 24 & "' WHERE [Gram_valu] = N'18'"
                GlCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub
    Private Sub lblSilver925_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lblSilver925.TextChanged, lblSilver925.TextChanged
        Try
            If Val(lblSilver925.Text) > 0 Then
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lblSilver925.Text) & "' WHERE [Gram_valu] = N'925'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Gram_val] SET [Gram_price] = '" & Val(lblSilver925.Text) * 800 / 925 & "' WHERE [Gram_valu] = N'800'"
                GlCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub

#End Region

    Private Sub tsTransactionsAddGold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


#Region "FrmSnd"
    Private Sub tsTransactionsPaymentVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTransactionsPaymentVoucher.Click
        'Timer1.Stop()
        'language_start(Name)
        ''ke()
        ''language_start(Name)

    End Sub
#End Region

    Private Sub tsTransactionsBuyDiamond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTransactionsBuyDiamond.Click
        DiamondDeleteEditeInvoceBuy.ShowDialog()
    End Sub

    Private Sub wholesaleInvView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wholesaleInvView.Click
        PaymentWholesalePrinting.ShowDialog()
    End Sub


    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
        End
    End Sub
    Private Sub ExpReportSellDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpReportSellDetailed.Click
        ReportExpenses.ShowDialog()
    End Sub

    Private Sub ExpReportSellView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpReportSellView.Click
        ReportPath = "SELECT [Report_Path9]  FROM [ReportPath]"
        SqlFillCom = "select ExpensesInvID from ReportExpensesAllData where Active='1'"
        SqlComGetInv = "select * from Expenses where ExpensesInvID ='"
        FrmPupPrentInv.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesToolStripMenuItem.Click
        Timer1.Stop()
        FrmEditDelete.ShowDialog()
        Timer1.Start()
    End Sub

    Private Sub TimDayesLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimDayesLeft.Tick
        If Date.Now.Second Mod 2 = 0 Then
            If LabDayesLeft.BackColor = Color.Green Then
                LabDayesLeft.BackColor = Color.Lime
                LabDayesLeft.ForeColor = Color.Red
            ElseIf LabDayesLeft.BackColor = Color.Lime Then
                LabDayesLeft.BackColor = Color.Green
                LabDayesLeft.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub lblUserName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUserName.Click
        FrmViewImages.ShowDialog()
    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectColorToolStripMenuItem.Click
        If SelectColor.ShowDialog() = DialogResult.OK Then
            My.MySettings.Default.ColorSet = SelectColor.Color
            My.MySettings.Default.Save()
        End If
        ControlsAsColor(ColorSelect:=Me)
        Discoloration()
    End Sub
    Private Sub ToolStripBondShowDetelsCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBondShowDetelsCash.Click
        ReportViewDetails.ShowDialog()
    End Sub
    Private Sub ToolStripBondShowCashComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBondShowCashComp.Click
        Dim BondCompLocSave As String = ""
        ReportPath = "SELECT [Report_Path6] FROM [ReportPath]"
        SqlFillCom = "select * from ViwSndToCustomer WHERE TypeTransaction='1'"
        SqlComGetInv = "select * from ViwSndToCustomer WHERE  TypeTransaction = 1 AND SndNumber = N'"
        FrmPupPrentInv.ShowDialog()
    End Sub

    Private Sub ToolStripBondShowCashCompPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripBondShowCashCompPersonal.Click
        Dim BondPersLocSave As String = ""
        ReportPath = "SELECT [Report_Path5] FROM [ReportPath]"
        SqlFillCom = "select * from ViwSndToCustomer WHERE TypeTransaction='0'"
        SqlComGetInv = "select * from ViwSndToCustomer WHERE  TypeTransaction = 0 AND SndNumber = N'"
        FrmPupPrentInv.ShowDialog()
    End Sub



    Private Sub mnuSettings_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SelectColorToolStripMenuItem.MouseMove, mnuUserManagement.MouseMove, mnuTransactions.MouseMove, mnuSettings.MouseMove, mnuReport.MouseMove, mnuLicense.MouseMove
        Timer1.Stop()
    End Sub

    Private Sub mnuSettings_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectColorToolStripMenuItem.MouseLeave, mnuUserManagement.MouseLeave, mnuTransactions.MouseLeave, mnuSettings.MouseLeave, mnuReport.MouseLeave, mnuLicense.MouseLeave
        Timer1.Start()
    End Sub

    Private Sub انشاءجديدToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انشاءجديدToolStripMenuItem1.Click
        FrmSnd.ShowDialog()
    End Sub

    'Private Sub انشاءجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انشاءجديدToolStripMenuItem.Click

    'End Sub

    Private Sub حزفتعديلسابقToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حزفتعديلسابقToolStripMenuItem.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'WhatsAppSettings.Show()
        frmViwGoldVoucher.ShowDialog()
    End Sub

    Private Sub tsTransactionsBuySilver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsTransactionsBuySilver.Click

    End Sub

    Private Sub BtnAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TestCooode.ShowDialog()
    End Sub

    Private Sub BackWorkerApi_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkerApi.DoWork
        ''خاص بالواتساب

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub lblAutoBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAutoBackup.Click

    End Sub

    Private Sub lblTechSupport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblTechSupport.LinkClicked
        Dim URL As String
        Dim IMG As Image
        Dim Note As String
        Dim GetFild As DataTable = OnlinGetRecordSet("SELECT TEL2 FROM  ADS_SERVICES")
        If GetFild.Rows.Count > 0 Then
            URL = (GetFild.Rows(0)("TEL2").ToString)
        End If

        Dim webAddress As String = URL
        Process.Start(webAddress)
    End Sub

    Private Sub lblMinm_Click(sender As Object, e As EventArgs) Handles lblMinm.Click
        ' (69, 29)

    End Sub

    Private Sub lblmin_Click(sender As Object, e As EventArgs)
        'Panel10.Size = New Size(43, 35)
        'Panel10.Location = New Size(6, 654)
        'MsgBox("g")
    End Sub
    Public Sub FinancialSummary()
        If LogoPictureBox.Visible = True Then
            LogoPictureBox.Visible = False
        ElseIf LogoPictureBox.Visible = False Then
            LogoPictureBox.Visible = True
        End If
        '''' المصنعيه
        'Dim DtGoldInvoceReport As DataTable = GetRecordSet("SELECT SUM(item_gram) AS item_gram, SUM(item_gramMade) AS item_gramMade, date FROM  dbo.ViwGoldInvoceReport GROUP BY date HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "')")
        Dim DtGoldInvoceReport As DataTable = GetRecordSet("SELECT date, item_gram, item_gramMade, FO_desp FROM   dbo.ViwGoldInvoceReport GROUP BY date, item_gram, item_gramMade, FO_desp HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "')")
        If DtGoldInvoceReport.Rows.Count >= 0 Then

            Dim MakeCharge As Decimal = DtGoldInvoceReport.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gramMade")) * (DtGoldInvoceReport.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram")))
            Dim Cost As Decimal = DtGoldInvoceReport.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("FO_desp")) * (DtGoldInvoceReport.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram")))
            lblMakeCharge.Text = Val(MakeCharge) & "  " & txtMakeCharge.Text
            lblCost.Text = Val(Cost) & "  " & "التكلفه"
            lblProfit.Text = Val(MakeCharge) - Val(Cost) & "  " & "صافي الربح"
        Else
        End If
        '''تفاصيل الدفع
        Dim DtGoldInvoceReportAmount As DataTable = GetRecordSet("SELECT TOTAL_mony, KENT, CACH, balance FROM dbo.ViwGoldInvoceReport GROUP BY date, TOTAL_mony, KENT, CACH, balance HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "')")
        If DtGoldInvoceReportAmount.Rows.Count >= 0 Then
            Dim TotalAmount As Decimal = DtGoldInvoceReportAmount.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("TOTAL_mony"))
            Dim CachAmount As Decimal = DtGoldInvoceReportAmount.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("CACH"))
            Dim BankAmount As Decimal = DtGoldInvoceReportAmount.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("KENT"))
            Dim Balance As Decimal = DtGoldInvoceReportAmount.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("balance"))
            lblTotalAmount.Text = Math.Round(Val(TotalAmount), 3) & "  " & txtTotalAmoun.Text
            lblCachAmount.Text = Math.Round(Val(CachAmount), 3) & "  " & txtCachAmount.Text
            lblBankAmount.Text = Math.Round(Val(BankAmount), 3) & "  " & txtBankAmount.Text
        End If

        '18
        Dim DtGoldInvoceReportGoledWh18 As DataTable = GetRecordSet("SELECT  date, SUM(item_gram) AS item_gram, GoledKarat FROM  dbo.ViwGoldInvoceReport GROUP BY date, GoledKarat  HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "') AND (GoledKarat = N'18') ORDER BY date ")
        If DtGoldInvoceReportGoledWh18.Rows.Count >= 0 Then
            Dim GoledWh18 As Decimal = DtGoldInvoceReportGoledWh18.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            lblGoledWh18.Text = "عيار 18" & "  " & vbCrLf & Math.Round(Val(GoledWh18), 3)
            ' 
        End If

        '21
        Dim DtGoldInvoceReportGoledWh21 As DataTable = GetRecordSet("SELECT  date, SUM(item_gram) AS item_gram, GoledKarat FROM  dbo.ViwGoldInvoceReport GROUP BY date, GoledKarat  HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "') AND (GoledKarat = N'21') ORDER BY date ")
        If DtGoldInvoceReportGoledWh21.Rows.Count >= 0 Then
            Dim GoledWh21 As Decimal = DtGoldInvoceReportGoledWh21.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            lblGoledWh21.Text = "عيار 21" & "  " & vbCrLf & Math.Round(Val(GoledWh21), 3)
        End If
        '22
        Dim DtGoldInvoceReportGoledWh22 As DataTable = GetRecordSet("SELECT  date, SUM(item_gram) AS item_gram, GoledKarat FROM  dbo.ViwGoldInvoceReport GROUP BY date, GoledKarat  HAVING (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "') AND (GoledKarat = N'22') ORDER BY date ")
        If DtGoldInvoceReportGoledWh22.Rows.Count >= 0 Then
            Dim GoledWh22 As Decimal = DtGoldInvoceReportGoledWh22.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            lblGoledWh22.Text = "عيار 22" & "  " & vbCrLf & Math.Round(Val(GoledWh22), 3)
        End If
        '24
        Dim DtGoldInvoceReportGoledWh24 As DataTable = GetRecordSet("SELECT date, SUM(item_gram) AS item_gram, GoledKarat" & vbCrLf &
                                                                    "FROM  dbo.ViwGoldInvoceReport" & vbCrLf &
                                                                    "GROUP BY date, GoledKarat" & vbCrLf &
                                                                    "HAVING (GoledKarat BETWEEN N'24' AND N'9999') AND (Date BETWEEN '" & Format(PicDateFrom.Value, "yyyy/MM/dd") & "' AND '" & Format(PicDateTo.Value, "yyyy/MM/dd") & "')" & vbCrLf &
                                                                     "ORDER BY date")
        If DtGoldInvoceReportGoledWh24.Rows.Count >= 0 Then
            Dim GoledWh24 As Decimal = DtGoldInvoceReportGoledWh24.AsEnumerable().Sum(Function(roW) roW.Field(Of Decimal)("item_gram"))
            lblGoledWh24.Text = "عيار 24" & "  " & vbCrLf & Math.Round(Val(GoledWh24), 3)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnSalesDetails.Click
        'FinancialSummary()
        'FrmInvDelet.ShowDialog()
    End Sub

    Private Sub GoldVoucherReceiveCreateNew_Click(sender As Object, e As EventArgs) Handles GoldVoucherReceiveCreateNew.Click
        FrmSndGold.ShowDialog()
    End Sub

    Private Sub tsSettingsMainAddCompany_Click(sender As Object, e As EventArgs) Handles tsSettingsMainAddCompany.Click
        FrmCompanyInfo.ShowDialog()
    End Sub

    Private Sub tsSettingsMainAddBranch_Click(sender As Object, e As EventArgs) Handles tsSettingsMainAddBranch.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub GoldVoucherCreateNew_Click(sender As Object, e As EventArgs) Handles GoldVoucherCreateNew.Click
        FrmGoldVoucherReserve.ShowDialog()
    End Sub

    Private Sub اعداداتالتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اعداداتالتToolStripMenuItem.Click
        frm_report_siting.ShowDialog()
    End Sub

    Private Sub اعداداتالواتسابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اعداداتالواتسابToolStripMenuItem.Click
        whatsapp_Qr.ShowDialog()
    End Sub

    Private Sub ToolStripBondShowGold_Click(sender As Object, e As EventArgs) Handles ToolStripBondShowGold.Click
        frmViwGoldVoucher.ShowDialog()
    End Sub

    Private Sub مراجعةالسنداتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مراجعةالسنداتToolStripMenuItem.Click
        frmGoldVoucherReceive.ShowDialog()
    End Sub

    Private Sub المحذوفاتذهبفضهالماسToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المحذوفاتذهبفضهالماسToolStripMenuItem.Click
        FrmInvDelet.ShowDialog()
    End Sub

    Private Sub mnuReport_Click(sender As Object, e As EventArgs) Handles mnuReport.Click

    End Sub

    Private Sub ذهبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ذهبToolStripMenuItem.Click

        ReportGoldShellMinistrial.ShowDialog()

    End Sub
End Class