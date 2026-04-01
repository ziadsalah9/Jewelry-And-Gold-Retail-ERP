<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblAutoBackup = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.SET_INVARCHR154TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.SET_INVARCHR149TextBox = New System.Windows.Forms.TextBox()
        Me.btnBulkSell = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnKarat = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnBarCode = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.msMenuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettingsMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainCompanyData = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainCountryOfOrigin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainGramPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainAddCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsMainAddBranch = New System.Windows.Forms.ToolStripMenuItem()
        Me.اعداداتالواتسابToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettingsDefinition = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionStoneName = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionStoneColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionDiamondCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionAddItemCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionBrands = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsDefinitionItemName = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettingsLanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsLanguageArabic = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsLanguageEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.اعداداتالتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSettingsProgrammer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportSell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportSellView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewAuction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportSellDetailed = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellDetailedGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellDetailedSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellDetailedDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellDetailedAuction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellDetailedAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportSellShort = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellShortGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellShortSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellShortDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellShortAuction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellShortAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportItemByCarat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemByCaratGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemByCaratSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportSellViewDeleted = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewGoldDeleted = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportSellViewSilverDeleted = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportBuyView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyViewGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyViewSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyViewDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyViewAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportBuyDetailed = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyDetailedGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyDetailedSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyDetailedDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyDetailedAuction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyDetailedAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportBuyShort = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyShortGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyShortSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyShortDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportBuyShortAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportItemsAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAllGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAllSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAllDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAllAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportItemsSold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsSoldGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsSoldSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsSoldDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsSoldAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportItemsAvailable = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAvailableGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAvailableSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAvailableDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportItemsAvailableAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportProfit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportProfitGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportProfitGoldPerPurchaseCost = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportProfitSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportProfitDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportProfitAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpReportSellView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpReportSellDetailed = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReportCivilIDPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.wholesaleReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.wholesaleInvView = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowCashComp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowCashCompPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowDetelsCash = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripBondShowDetelsGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.سندقبضذهبToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مراجعةالسنداتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.بحثمتعددتفصيليToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUserManagementUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUserManagementCashier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactionsSell = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsSellGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsSellSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsSellDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsSellAuction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsSellAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactionsBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsBuyGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsBuySilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsBuyDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsBuyAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsGoldVoucherReceive = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldVoucherReceiveCreateNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldVoucherReceiveEdite = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsGoldVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldVoucherCreateNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoldVoucherEdite = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsPaymentVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.انشاءجديدToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.حزفتعديلسابقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactionsPayInstallment = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsPayInstallmentGoldSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsPayInstallmentDiamond = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTransactionsPayInstallmentAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLicense = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLicenseGet = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.dtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTechSupportEnd = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.pnlPrice = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblBuyOunceUsd = New System.Windows.Forms.LinkLabel()
        Me.LabOunceBuyUsd = New System.Windows.Forms.Label()
        Me.lblCurrencyBuy = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblSellOunceUsd = New System.Windows.Forms.LinkLabel()
        Me.LabSellOunceUsd = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblOunceBUY = New System.Windows.Forms.LinkLabel()
        Me.LIB_OUNCEBUY = New System.Windows.Forms.Label()
        Me.pnlPriceOunce = New System.Windows.Forms.Panel()
        Me.lblOunce = New System.Windows.Forms.LinkLabel()
        Me.LIB_OUNCE = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSilver925BUY = New System.Windows.Forms.LinkLabel()
        Me.lblSilver925KBUY = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl24BUY = New System.Windows.Forms.LinkLabel()
        Me.lbl24KBUY = New System.Windows.Forms.Label()
        Me.lblCurrencySale = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl22BUY = New System.Windows.Forms.LinkLabel()
        Me.lbl22KBUY = New System.Windows.Forms.Label()
        Me.pnlPrice925 = New System.Windows.Forms.Panel()
        Me.lblSilver925 = New System.Windows.Forms.LinkLabel()
        Me.lblSilver925K = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl21BUY = New System.Windows.Forms.LinkLabel()
        Me.lbl21KBUY = New System.Windows.Forms.Label()
        Me.pnlPrice24 = New System.Windows.Forms.Panel()
        Me.lbl24 = New System.Windows.Forms.LinkLabel()
        Me.lbl24K = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl18BUY = New System.Windows.Forms.LinkLabel()
        Me.lbl18KBUY = New System.Windows.Forms.Label()
        Me.pnlPrice22 = New System.Windows.Forms.Panel()
        Me.lbl22 = New System.Windows.Forms.LinkLabel()
        Me.lbl22K = New System.Windows.Forms.Label()
        Me.pnlPrice21 = New System.Windows.Forms.Panel()
        Me.lbl21 = New System.Windows.Forms.LinkLabel()
        Me.lbl21K = New System.Windows.Forms.Label()
        Me.pnlPrice18 = New System.Windows.Forms.Panel()
        Me.lbl18 = New System.Windows.Forms.LinkLabel()
        Me.lbl18K = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.SET_INVARCHR142TextBox = New System.Windows.Forms.TextBox()
        Me.lblTechSupport = New System.Windows.Forms.LinkLabel()
        Me.LepOpencount = New System.Windows.Forms.Label()
        Me.LebMySqlShopNmae = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblServerStatus = New System.Windows.Forms.Label()
        Me.TimDayesLeft = New System.Windows.Forms.Timer(Me.components)
        Me.LabDayesLeft = New System.Windows.Forms.TextBox()
        Me.FrmBackgWork = New System.ComponentModel.BackgroundWorker()
        Me.BackWorkerApi = New System.ComponentModel.BackgroundWorker()
        Me.lblMinm = New System.Windows.Forms.Label()
        Me.PanAdv = New System.Windows.Forms.Panel()
        Me.BtnSalesDetails = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblProfit = New System.Windows.Forms.LinkLabel()
        Me.lblCost = New System.Windows.Forms.LinkLabel()
        Me.lblGoledWh18 = New System.Windows.Forms.LinkLabel()
        Me.lblGoledWh24 = New System.Windows.Forms.LinkLabel()
        Me.lblGoledWh22 = New System.Windows.Forms.LinkLabel()
        Me.lblGoledWh21 = New System.Windows.Forms.LinkLabel()
        Me.lblMakeCharge = New System.Windows.Forms.LinkLabel()
        Me.lblBankAmount = New System.Windows.Forms.LinkLabel()
        Me.lblCachAmount = New System.Windows.Forms.LinkLabel()
        Me.lblTotalAmount = New System.Windows.Forms.LinkLabel()
        Me.lblGold = New System.Windows.Forms.LinkLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblAmountBuy = New System.Windows.Forms.LinkLabel()
        Me.lblWeightBuy = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.PicDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.PicDateTo = New System.Windows.Forms.DateTimePicker()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.picServerStatus = New System.Windows.Forms.PictureBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.WebViewLinek = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.BtnWebView = New System.Windows.Forms.Button()
        Me.TimLodPrice = New System.Windows.Forms.Timer(Me.components)
        Me.المحذوفاتذهبفضهالماسToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlButtons.SuspendLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msMenuMain.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlPrice.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlPriceOunce.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlPrice925.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.pnlPrice24.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.pnlPrice22.SuspendLayout()
        Me.pnlPrice21.SuspendLayout()
        Me.pnlPrice18.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanAdv.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.picServerStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebViewLinek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(1366, 6)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(132, 26)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "User Name"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(1245, 6)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUserName.Size = New System.Drawing.Size(121, 26)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "اسم المستخدم"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(652, 6)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(252, 26)
        Me.lblDateTime.TabIndex = 3
        Me.lblDateTime.Text = "12:00:00"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutoBackup
        '
        Me.lblAutoBackup.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblAutoBackup.BackColor = System.Drawing.Color.Transparent
        Me.lblAutoBackup.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutoBackup.ForeColor = System.Drawing.Color.White
        Me.lblAutoBackup.Location = New System.Drawing.Point(532, 6)
        Me.lblAutoBackup.Name = "lblAutoBackup"
        Me.lblAutoBackup.Size = New System.Drawing.Size(120, 26)
        Me.lblAutoBackup.TabIndex = 163
        Me.lblAutoBackup.Text = "Auto Backup"
        Me.lblAutoBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.White
        Me.lblVersion.Location = New System.Drawing.Point(7, 6)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(142, 26)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version20251212"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'pnlButtons
        '
        Me.pnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlButtons.BackColor = System.Drawing.Color.Transparent
        Me.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlButtons.Controls.Add(Me.SET_INVARCHR154TextBox)
        Me.pnlButtons.Controls.Add(Me.SET_INVARCHR149TextBox)
        Me.pnlButtons.Controls.Add(Me.btnBulkSell)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnBackup)
        Me.pnlButtons.Controls.Add(Me.btnStock)
        Me.pnlButtons.Controls.Add(Me.btnExpense)
        Me.pnlButtons.Controls.Add(Me.btnReport)
        Me.pnlButtons.Controls.Add(Me.btnKarat)
        Me.pnlButtons.Controls.Add(Me.btnItem)
        Me.pnlButtons.Controls.Add(Me.btnBarCode)
        Me.pnlButtons.Controls.Add(Me.btnSell)
        Me.pnlButtons.Controls.Add(Me.btnBuy)
        Me.pnlButtons.Location = New System.Drawing.Point(1297, 1)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(215, 685)
        Me.pnlButtons.TabIndex = 6
        '
        'SET_INVARCHR154TextBox
        '
        Me.SET_INVARCHR154TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR154", True))
        Me.SET_INVARCHR154TextBox.Location = New System.Drawing.Point(256, 64)
        Me.SET_INVARCHR154TextBox.Name = "SET_INVARCHR154TextBox"
        Me.SET_INVARCHR154TextBox.Size = New System.Drawing.Size(37, 27)
        Me.SET_INVARCHR154TextBox.TabIndex = 156
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SET_INVARCHR149TextBox
        '
        Me.SET_INVARCHR149TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR149", True))
        Me.SET_INVARCHR149TextBox.Location = New System.Drawing.Point(243, 63)
        Me.SET_INVARCHR149TextBox.Name = "SET_INVARCHR149TextBox"
        Me.SET_INVARCHR149TextBox.Size = New System.Drawing.Size(22, 27)
        Me.SET_INVARCHR149TextBox.TabIndex = 156
        '
        'btnBulkSell
        '
        Me.btnBulkSell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBulkSell.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBulkSell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBulkSell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBulkSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBulkSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBulkSell.ForeColor = System.Drawing.Color.Black
        Me.btnBulkSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBulkSell.Location = New System.Drawing.Point(3, 389)
        Me.btnBulkSell.Name = "btnBulkSell"
        Me.btnBulkSell.Size = New System.Drawing.Size(205, 48)
        Me.btnBulkSell.TabIndex = 31
        Me.btnBulkSell.Text = "مبيعات الجملة"
        Me.btnBulkSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBulkSell.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(3, 499)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(205, 48)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "تحديث "
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackup.ForeColor = System.Drawing.Color.Black
        Me.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackup.Location = New System.Drawing.Point(3, 444)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(205, 48)
        Me.btnBackup.TabIndex = 25
        Me.btnBackup.Text = "نسخ احتياطي"
        Me.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStock.ForeColor = System.Drawing.Color.Black
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(3, 279)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(205, 48)
        Me.btnStock.TabIndex = 23
        Me.btnStock.Text = "المخزون"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnExpense
        '
        Me.btnExpense.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExpense.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnExpense.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExpense.ForeColor = System.Drawing.Color.Black
        Me.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExpense.Location = New System.Drawing.Point(3, 224)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(205, 48)
        Me.btnExpense.TabIndex = 19
        Me.btnExpense.Text = "مصروفات"
        Me.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExpense.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.ForeColor = System.Drawing.Color.Black
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(3, 554)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(205, 48)
        Me.btnReport.TabIndex = 17
        Me.btnReport.Text = "تقارير"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = True
        Me.btnReport.Visible = False
        '
        'btnKarat
        '
        Me.btnKarat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKarat.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnKarat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnKarat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnKarat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnKarat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKarat.ForeColor = System.Drawing.Color.Black
        Me.btnKarat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKarat.Location = New System.Drawing.Point(3, 169)
        Me.btnKarat.Name = "btnKarat"
        Me.btnKarat.Size = New System.Drawing.Size(205, 48)
        Me.btnKarat.TabIndex = 15
        Me.btnKarat.Text = "التحويلات"
        Me.btnKarat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKarat.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnItem.ForeColor = System.Drawing.Color.Black
        Me.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItem.Location = New System.Drawing.Point(3, 114)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(205, 48)
        Me.btnItem.TabIndex = 13
        Me.btnItem.Text = "الاصناف"
        Me.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnBarCode
        '
        Me.btnBarCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBarCode.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBarCode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBarCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBarCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBarCode.ForeColor = System.Drawing.Color.Black
        Me.btnBarCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarCode.Location = New System.Drawing.Point(3, 59)
        Me.btnBarCode.Name = "btnBarCode"
        Me.btnBarCode.Size = New System.Drawing.Size(205, 48)
        Me.btnBarCode.TabIndex = 11
        Me.btnBarCode.Text = "باركود"
        Me.btnBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBarCode.UseVisualStyleBackColor = True
        '
        'btnSell
        '
        Me.btnSell.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSell.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnSell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSell.ForeColor = System.Drawing.Color.Black
        Me.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSell.Location = New System.Drawing.Point(3, 4)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(205, 48)
        Me.btnSell.TabIndex = 0
        Me.btnSell.Text = "شاشة البيع"
        Me.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'btnBuy
        '
        Me.btnBuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuy.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnBuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuy.ForeColor = System.Drawing.Color.Black
        Me.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuy.Location = New System.Drawing.Point(3, 334)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(205, 48)
        Me.btnBuy.TabIndex = 29
        Me.btnBuy.Text = "المشتريات"
        Me.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'msMenuMain
        '
        Me.msMenuMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msMenuMain.AutoSize = False
        Me.msMenuMain.BackColor = System.Drawing.Color.White
        Me.msMenuMain.Dock = System.Windows.Forms.DockStyle.None
        Me.msMenuMain.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.msMenuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettings, Me.mnuReport, Me.mnuUserManagement, Me.mnuTransactions, Me.mnuLicense, Me.SelectColorToolStripMenuItem})
        Me.msMenuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msMenuMain.Location = New System.Drawing.Point(0, 3)
        Me.msMenuMain.Name = "msMenuMain"
        Me.msMenuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.msMenuMain.Size = New System.Drawing.Size(1285, 51)
        Me.msMenuMain.TabIndex = 8
        Me.msMenuMain.Text = "MenuStrip1"
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSettingsMain, Me.mnuSettingsDefinition, Me.mnuSettingsLanguage, Me.اعداداتالتToolStripMenuItem, Me.tsSettingsProgrammer})
        Me.mnuSettings.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mnuSettings.ForeColor = System.Drawing.Color.Black
        Me.mnuSettings.ImageTransparentColor = System.Drawing.Color.Silver
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(141, 47)
        Me.mnuSettings.Text = "إعدادات البرنامج"
        '
        'mnuSettingsMain
        '
        Me.mnuSettingsMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSettingsMainCompanyData, Me.tsSettingsMainCountryOfOrigin, Me.tsSettingsMainGramPrice, Me.tsSettingsMainCompany, Me.اعداداتالواتسابToolStripMenuItem})
        Me.mnuSettingsMain.Name = "mnuSettingsMain"
        Me.mnuSettingsMain.Size = New System.Drawing.Size(213, 30)
        Me.mnuSettingsMain.Text = "الإعدادات الرئيسة"
        '
        'tsSettingsMainCompanyData
        '
        Me.tsSettingsMainCompanyData.Name = "tsSettingsMainCompanyData"
        Me.tsSettingsMainCompanyData.Size = New System.Drawing.Size(222, 30)
        Me.tsSettingsMainCompanyData.Text = "بيانات الشركة"
        '
        'tsSettingsMainCountryOfOrigin
        '
        Me.tsSettingsMainCountryOfOrigin.Name = "tsSettingsMainCountryOfOrigin"
        Me.tsSettingsMainCountryOfOrigin.Size = New System.Drawing.Size(222, 30)
        Me.tsSettingsMainCountryOfOrigin.Text = "مصادر التصنيع"
        '
        'tsSettingsMainGramPrice
        '
        Me.tsSettingsMainGramPrice.Name = "tsSettingsMainGramPrice"
        Me.tsSettingsMainGramPrice.Size = New System.Drawing.Size(222, 30)
        Me.tsSettingsMainGramPrice.Text = "سعر الجرام"
        '
        'tsSettingsMainCompany
        '
        Me.tsSettingsMainCompany.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSettingsMainAddCompany, Me.tsSettingsMainAddBranch})
        Me.tsSettingsMainCompany.Name = "tsSettingsMainCompany"
        Me.tsSettingsMainCompany.Size = New System.Drawing.Size(222, 30)
        Me.tsSettingsMainCompany.Text = "الشركات"
        '
        'tsSettingsMainAddCompany
        '
        Me.tsSettingsMainAddCompany.Name = "tsSettingsMainAddCompany"
        Me.tsSettingsMainAddCompany.Size = New System.Drawing.Size(178, 30)
        Me.tsSettingsMainAddCompany.Text = "اضافة شركه"
        '
        'tsSettingsMainAddBranch
        '
        Me.tsSettingsMainAddBranch.Name = "tsSettingsMainAddBranch"
        Me.tsSettingsMainAddBranch.Size = New System.Drawing.Size(178, 30)
        Me.tsSettingsMainAddBranch.Text = "اضافة الفروع"
        '
        'اعداداتالواتسابToolStripMenuItem
        '
        Me.اعداداتالواتسابToolStripMenuItem.Name = "اعداداتالواتسابToolStripMenuItem"
        Me.اعداداتالواتسابToolStripMenuItem.Size = New System.Drawing.Size(222, 30)
        Me.اعداداتالواتسابToolStripMenuItem.Text = "اعدادات الواتس اب"
        '
        'mnuSettingsDefinition
        '
        Me.mnuSettingsDefinition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSettingsDefinitionStoneName, Me.tsSettingsDefinitionStoneColor, Me.tsSettingsDefinitionDiamondCut, Me.tsSettingsDefinitionAddItemCategory, Me.tsSettingsDefinitionBrands, Me.tsSettingsDefinitionItemName})
        Me.mnuSettingsDefinition.Name = "mnuSettingsDefinition"
        Me.mnuSettingsDefinition.Size = New System.Drawing.Size(213, 30)
        Me.mnuSettingsDefinition.Text = "تعريفات"
        '
        'tsSettingsDefinitionStoneName
        '
        Me.tsSettingsDefinitionStoneName.Name = "tsSettingsDefinitionStoneName"
        Me.tsSettingsDefinitionStoneName.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionStoneName.Text = "أنواع الأحجار"
        '
        'tsSettingsDefinitionStoneColor
        '
        Me.tsSettingsDefinitionStoneColor.Name = "tsSettingsDefinitionStoneColor"
        Me.tsSettingsDefinitionStoneColor.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionStoneColor.Text = "ألوان الأحجار"
        '
        'tsSettingsDefinitionDiamondCut
        '
        Me.tsSettingsDefinitionDiamondCut.Name = "tsSettingsDefinitionDiamondCut"
        Me.tsSettingsDefinitionDiamondCut.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionDiamondCut.Text = "قصة الألماس"
        '
        'tsSettingsDefinitionAddItemCategory
        '
        Me.tsSettingsDefinitionAddItemCategory.Name = "tsSettingsDefinitionAddItemCategory"
        Me.tsSettingsDefinitionAddItemCategory.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionAddItemCategory.Text = "إضافة صنف -مزادات وساعات"
        '
        'tsSettingsDefinitionBrands
        '
        Me.tsSettingsDefinitionBrands.Name = "tsSettingsDefinitionBrands"
        Me.tsSettingsDefinitionBrands.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionBrands.Text = "إضافة ماركة"
        '
        'tsSettingsDefinitionItemName
        '
        Me.tsSettingsDefinitionItemName.Name = "tsSettingsDefinitionItemName"
        Me.tsSettingsDefinitionItemName.Size = New System.Drawing.Size(299, 30)
        Me.tsSettingsDefinitionItemName.Text = "إضافة أنواع الأصناف"
        '
        'mnuSettingsLanguage
        '
        Me.mnuSettingsLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSettingsLanguageArabic, Me.tsSettingsLanguageEnglish})
        Me.mnuSettingsLanguage.Name = "mnuSettingsLanguage"
        Me.mnuSettingsLanguage.Size = New System.Drawing.Size(213, 30)
        Me.mnuSettingsLanguage.Text = "اختيار اللغة"
        '
        'tsSettingsLanguageArabic
        '
        Me.tsSettingsLanguageArabic.Name = "tsSettingsLanguageArabic"
        Me.tsSettingsLanguageArabic.Size = New System.Drawing.Size(144, 30)
        Me.tsSettingsLanguageArabic.Text = "العربية"
        '
        'tsSettingsLanguageEnglish
        '
        Me.tsSettingsLanguageEnglish.Name = "tsSettingsLanguageEnglish"
        Me.tsSettingsLanguageEnglish.Size = New System.Drawing.Size(144, 30)
        Me.tsSettingsLanguageEnglish.Text = "English"
        '
        'اعداداتالتToolStripMenuItem
        '
        Me.اعداداتالتToolStripMenuItem.Name = "اعداداتالتToolStripMenuItem"
        Me.اعداداتالتToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.اعداداتالتToolStripMenuItem.Text = "اعدادات التقارير"
        '
        'tsSettingsProgrammer
        '
        Me.tsSettingsProgrammer.Name = "tsSettingsProgrammer"
        Me.tsSettingsProgrammer.Size = New System.Drawing.Size(213, 30)
        Me.tsSettingsProgrammer.Text = "إعدادات المبرمج"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportSell, Me.mnuReportBuy, Me.mnuReportItems, Me.mnuReportProfit, Me.tsReportCustomers, Me.tsReportExpenses, Me.tsReportCivilIDPrint, Me.wholesaleReport, Me.ToolStripBondCash, Me.ToolStripBondGold, Me.سندقبضذهبToolStripMenuItem})
        Me.mnuReport.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mnuReport.ForeColor = System.Drawing.Color.Black
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(77, 47)
        Me.mnuReport.Text = "التقارير"
        '
        'mnuReportSell
        '
        Me.mnuReportSell.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportSellView, Me.mnuReportSellDetailed, Me.mnuReportSellShort, Me.mnuReportItemByCarat, Me.mnuReportSellViewDeleted})
        Me.mnuReportSell.Name = "mnuReportSell"
        Me.mnuReportSell.Size = New System.Drawing.Size(282, 30)
        Me.mnuReportSell.Text = "تقارير المبيعات اليومية"
        '
        'mnuReportSellView
        '
        Me.mnuReportSellView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportSellViewGold, Me.tsReportSellViewSilver, Me.tsReportSellViewDiamond, Me.tsReportSellViewAuction, Me.tsReportSellViewAccessories})
        Me.mnuReportSellView.Name = "mnuReportSellView"
        Me.mnuReportSellView.Size = New System.Drawing.Size(238, 30)
        Me.mnuReportSellView.Text = "مراجعة الفواتير"
        '
        'tsReportSellViewGold
        '
        Me.tsReportSellViewGold.Name = "tsReportSellViewGold"
        Me.tsReportSellViewGold.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellViewGold.Text = "دهب"
        '
        'tsReportSellViewSilver
        '
        Me.tsReportSellViewSilver.Name = "tsReportSellViewSilver"
        Me.tsReportSellViewSilver.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellViewSilver.Text = "فضة"
        '
        'tsReportSellViewDiamond
        '
        Me.tsReportSellViewDiamond.Name = "tsReportSellViewDiamond"
        Me.tsReportSellViewDiamond.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellViewDiamond.Text = "ألماس"
        '
        'tsReportSellViewAuction
        '
        Me.tsReportSellViewAuction.Name = "tsReportSellViewAuction"
        Me.tsReportSellViewAuction.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellViewAuction.Text = "مزادات"
        '
        'tsReportSellViewAccessories
        '
        Me.tsReportSellViewAccessories.Name = "tsReportSellViewAccessories"
        Me.tsReportSellViewAccessories.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellViewAccessories.Text = "ساعات"
        '
        'mnuReportSellDetailed
        '
        Me.mnuReportSellDetailed.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportSellDetailedGold, Me.tsReportSellDetailedSilver, Me.tsReportSellDetailedDiamond, Me.tsReportSellDetailedAuction, Me.tsReportSellDetailedAccessories})
        Me.mnuReportSellDetailed.Name = "mnuReportSellDetailed"
        Me.mnuReportSellDetailed.Size = New System.Drawing.Size(238, 30)
        Me.mnuReportSellDetailed.Text = "بحث متعدد تفصيلي"
        '
        'tsReportSellDetailedGold
        '
        Me.tsReportSellDetailedGold.Name = "tsReportSellDetailedGold"
        Me.tsReportSellDetailedGold.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellDetailedGold.Text = "دهب"
        '
        'tsReportSellDetailedSilver
        '
        Me.tsReportSellDetailedSilver.Name = "tsReportSellDetailedSilver"
        Me.tsReportSellDetailedSilver.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellDetailedSilver.Text = "فضة"
        '
        'tsReportSellDetailedDiamond
        '
        Me.tsReportSellDetailedDiamond.Name = "tsReportSellDetailedDiamond"
        Me.tsReportSellDetailedDiamond.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellDetailedDiamond.Text = "ألماس"
        '
        'tsReportSellDetailedAuction
        '
        Me.tsReportSellDetailedAuction.Name = "tsReportSellDetailedAuction"
        Me.tsReportSellDetailedAuction.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellDetailedAuction.Text = "مزادات"
        '
        'tsReportSellDetailedAccessories
        '
        Me.tsReportSellDetailedAccessories.Name = "tsReportSellDetailedAccessories"
        Me.tsReportSellDetailedAccessories.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellDetailedAccessories.Text = "ساعات"
        '
        'mnuReportSellShort
        '
        Me.mnuReportSellShort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportSellShortGold, Me.tsReportSellShortSilver, Me.tsReportSellShortDiamond, Me.tsReportSellShortAuction, Me.tsReportSellShortAccessories})
        Me.mnuReportSellShort.Name = "mnuReportSellShort"
        Me.mnuReportSellShort.Size = New System.Drawing.Size(238, 30)
        Me.mnuReportSellShort.Text = "بحث متعدد  مختصر"
        '
        'tsReportSellShortGold
        '
        Me.tsReportSellShortGold.Name = "tsReportSellShortGold"
        Me.tsReportSellShortGold.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellShortGold.Text = "دهب"
        '
        'tsReportSellShortSilver
        '
        Me.tsReportSellShortSilver.Name = "tsReportSellShortSilver"
        Me.tsReportSellShortSilver.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellShortSilver.Text = "فضة"
        '
        'tsReportSellShortDiamond
        '
        Me.tsReportSellShortDiamond.Name = "tsReportSellShortDiamond"
        Me.tsReportSellShortDiamond.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellShortDiamond.Text = "ألماس"
        '
        'tsReportSellShortAuction
        '
        Me.tsReportSellShortAuction.Name = "tsReportSellShortAuction"
        Me.tsReportSellShortAuction.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellShortAuction.Text = "مزادات"
        '
        'tsReportSellShortAccessories
        '
        Me.tsReportSellShortAccessories.Name = "tsReportSellShortAccessories"
        Me.tsReportSellShortAccessories.Size = New System.Drawing.Size(135, 30)
        Me.tsReportSellShortAccessories.Text = "ساعات"
        '
        'mnuReportItemByCarat
        '
        Me.mnuReportItemByCarat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportItemByCaratGold, Me.tsReportItemByCaratSilver})
        Me.mnuReportItemByCarat.Name = "mnuReportItemByCarat"
        Me.mnuReportItemByCarat.Size = New System.Drawing.Size(238, 30)
        Me.mnuReportItemByCarat.Text = "بيان حركة الصنف"
        '
        'tsReportItemByCaratGold
        '
        Me.tsReportItemByCaratGold.Name = "tsReportItemByCaratGold"
        Me.tsReportItemByCaratGold.Size = New System.Drawing.Size(123, 30)
        Me.tsReportItemByCaratGold.Text = "ذهب"
        '
        'tsReportItemByCaratSilver
        '
        Me.tsReportItemByCaratSilver.Name = "tsReportItemByCaratSilver"
        Me.tsReportItemByCaratSilver.Size = New System.Drawing.Size(123, 30)
        Me.tsReportItemByCaratSilver.Text = "فضة"
        '
        'mnuReportSellViewDeleted
        '
        Me.mnuReportSellViewDeleted.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportSellViewGoldDeleted, Me.tsReportSellViewSilverDeleted})
        Me.mnuReportSellViewDeleted.Name = "mnuReportSellViewDeleted"
        Me.mnuReportSellViewDeleted.Size = New System.Drawing.Size(238, 30)
        Me.mnuReportSellViewDeleted.Text = "الفواتير المحذوفة"
        '
        'tsReportSellViewGoldDeleted
        '
        Me.tsReportSellViewGoldDeleted.Name = "tsReportSellViewGoldDeleted"
        Me.tsReportSellViewGoldDeleted.Size = New System.Drawing.Size(123, 30)
        Me.tsReportSellViewGoldDeleted.Text = "ذهب"
        '
        'tsReportSellViewSilverDeleted
        '
        Me.tsReportSellViewSilverDeleted.Name = "tsReportSellViewSilverDeleted"
        Me.tsReportSellViewSilverDeleted.Size = New System.Drawing.Size(123, 30)
        Me.tsReportSellViewSilverDeleted.Text = "فضة"
        '
        'mnuReportBuy
        '
        Me.mnuReportBuy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportBuyView, Me.mnuReportBuyDetailed, Me.mnuReportBuyShort})
        Me.mnuReportBuy.Name = "mnuReportBuy"
        Me.mnuReportBuy.Size = New System.Drawing.Size(282, 30)
        Me.mnuReportBuy.Text = "المشتريات"
        '
        'mnuReportBuyView
        '
        Me.mnuReportBuyView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportBuyViewGold, Me.tsReportBuyViewSilver, Me.tsReportBuyViewDiamond, Me.tsReportBuyViewAccessories})
        Me.mnuReportBuyView.Name = "mnuReportBuyView"
        Me.mnuReportBuyView.Size = New System.Drawing.Size(249, 30)
        Me.mnuReportBuyView.Text = "عرض الفاتورة"
        '
        'tsReportBuyViewGold
        '
        Me.tsReportBuyViewGold.Name = "tsReportBuyViewGold"
        Me.tsReportBuyViewGold.Size = New System.Drawing.Size(135, 30)
        Me.tsReportBuyViewGold.Text = "ذهب"
        '
        'tsReportBuyViewSilver
        '
        Me.tsReportBuyViewSilver.Name = "tsReportBuyViewSilver"
        Me.tsReportBuyViewSilver.Size = New System.Drawing.Size(135, 30)
        Me.tsReportBuyViewSilver.Text = "فضة"
        '
        'tsReportBuyViewDiamond
        '
        Me.tsReportBuyViewDiamond.Name = "tsReportBuyViewDiamond"
        Me.tsReportBuyViewDiamond.Size = New System.Drawing.Size(135, 30)
        Me.tsReportBuyViewDiamond.Text = "ألماس"
        '
        'tsReportBuyViewAccessories
        '
        Me.tsReportBuyViewAccessories.Name = "tsReportBuyViewAccessories"
        Me.tsReportBuyViewAccessories.Size = New System.Drawing.Size(135, 30)
        Me.tsReportBuyViewAccessories.Text = "ساعات"
        '
        'mnuReportBuyDetailed
        '
        Me.mnuReportBuyDetailed.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportBuyDetailedGold, Me.tsReportBuyDetailedSilver, Me.tsReportBuyDetailedDiamond, Me.tsReportBuyDetailedAuction, Me.tsReportBuyDetailedAccessories})
        Me.mnuReportBuyDetailed.Name = "mnuReportBuyDetailed"
        Me.mnuReportBuyDetailed.Size = New System.Drawing.Size(249, 30)
        Me.mnuReportBuyDetailed.Text = "تقرير مشتريات تفصيلي"
        '
        'tsReportBuyDetailedGold
        '
        Me.tsReportBuyDetailedGold.Name = "tsReportBuyDetailedGold"
        Me.tsReportBuyDetailedGold.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyDetailedGold.Text = "ذهب"
        '
        'tsReportBuyDetailedSilver
        '
        Me.tsReportBuyDetailedSilver.Name = "tsReportBuyDetailedSilver"
        Me.tsReportBuyDetailedSilver.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyDetailedSilver.Text = "فضة"
        '
        'tsReportBuyDetailedDiamond
        '
        Me.tsReportBuyDetailedDiamond.Name = "tsReportBuyDetailedDiamond"
        Me.tsReportBuyDetailedDiamond.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyDetailedDiamond.Text = "ألماس"
        '
        'tsReportBuyDetailedAuction
        '
        Me.tsReportBuyDetailedAuction.Name = "tsReportBuyDetailedAuction"
        Me.tsReportBuyDetailedAuction.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyDetailedAuction.Text = "مزادات"
        '
        'tsReportBuyDetailedAccessories
        '
        Me.tsReportBuyDetailedAccessories.Name = "tsReportBuyDetailedAccessories"
        Me.tsReportBuyDetailedAccessories.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyDetailedAccessories.Text = "ساعات وماركات"
        '
        'mnuReportBuyShort
        '
        Me.mnuReportBuyShort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportBuyShortGold, Me.tsReportBuyShortSilver, Me.tsReportBuyShortDiamond, Me.tsReportBuyShortAccessories})
        Me.mnuReportBuyShort.Name = "mnuReportBuyShort"
        Me.mnuReportBuyShort.Size = New System.Drawing.Size(249, 30)
        Me.mnuReportBuyShort.Text = "تقرير مشتريات مختصر"
        '
        'tsReportBuyShortGold
        '
        Me.tsReportBuyShortGold.Name = "tsReportBuyShortGold"
        Me.tsReportBuyShortGold.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyShortGold.Text = "ذهب"
        '
        'tsReportBuyShortSilver
        '
        Me.tsReportBuyShortSilver.Name = "tsReportBuyShortSilver"
        Me.tsReportBuyShortSilver.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyShortSilver.Text = "فضة"
        '
        'tsReportBuyShortDiamond
        '
        Me.tsReportBuyShortDiamond.Name = "tsReportBuyShortDiamond"
        Me.tsReportBuyShortDiamond.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyShortDiamond.Text = "ألماس"
        '
        'tsReportBuyShortAccessories
        '
        Me.tsReportBuyShortAccessories.Name = "tsReportBuyShortAccessories"
        Me.tsReportBuyShortAccessories.Size = New System.Drawing.Size(196, 30)
        Me.tsReportBuyShortAccessories.Text = "ساعات وماركات"
        '
        'mnuReportItems
        '
        Me.mnuReportItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportItemsAll, Me.mnuReportItemsSold, Me.mnuReportItemsAvailable})
        Me.mnuReportItems.Name = "mnuReportItems"
        Me.mnuReportItems.Size = New System.Drawing.Size(282, 30)
        Me.mnuReportItems.Text = "تقارير الاصناف"
        '
        'mnuReportItemsAll
        '
        Me.mnuReportItemsAll.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportItemsAllGold, Me.tsReportItemsAllSilver, Me.tsReportItemsAllDiamond, Me.tsReportItemsAllAccessories})
        Me.mnuReportItemsAll.Name = "mnuReportItemsAll"
        Me.mnuReportItemsAll.Size = New System.Drawing.Size(210, 30)
        Me.mnuReportItemsAll.Text = "طباعة الاصناف "
        '
        'tsReportItemsAllGold
        '
        Me.tsReportItemsAllGold.Name = "tsReportItemsAllGold"
        Me.tsReportItemsAllGold.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAllGold.Text = "ذهب"
        '
        'tsReportItemsAllSilver
        '
        Me.tsReportItemsAllSilver.Name = "tsReportItemsAllSilver"
        Me.tsReportItemsAllSilver.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAllSilver.Text = "فضة"
        '
        'tsReportItemsAllDiamond
        '
        Me.tsReportItemsAllDiamond.Name = "tsReportItemsAllDiamond"
        Me.tsReportItemsAllDiamond.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAllDiamond.Text = "ألماس"
        '
        'tsReportItemsAllAccessories
        '
        Me.tsReportItemsAllAccessories.Name = "tsReportItemsAllAccessories"
        Me.tsReportItemsAllAccessories.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAllAccessories.Text = "ساعات وماركات"
        '
        'mnuReportItemsSold
        '
        Me.mnuReportItemsSold.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportItemsSoldGold, Me.tsReportItemsSoldSilver, Me.tsReportItemsSoldDiamond, Me.tsReportItemsSoldAccessories})
        Me.mnuReportItemsSold.Name = "mnuReportItemsSold"
        Me.mnuReportItemsSold.Size = New System.Drawing.Size(210, 30)
        Me.mnuReportItemsSold.Text = "الأصناف المباعة"
        '
        'tsReportItemsSoldGold
        '
        Me.tsReportItemsSoldGold.Name = "tsReportItemsSoldGold"
        Me.tsReportItemsSoldGold.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsSoldGold.Text = "ذهب"
        '
        'tsReportItemsSoldSilver
        '
        Me.tsReportItemsSoldSilver.Name = "tsReportItemsSoldSilver"
        Me.tsReportItemsSoldSilver.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsSoldSilver.Text = "فضة"
        '
        'tsReportItemsSoldDiamond
        '
        Me.tsReportItemsSoldDiamond.Name = "tsReportItemsSoldDiamond"
        Me.tsReportItemsSoldDiamond.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsSoldDiamond.Text = "ألماس"
        '
        'tsReportItemsSoldAccessories
        '
        Me.tsReportItemsSoldAccessories.Name = "tsReportItemsSoldAccessories"
        Me.tsReportItemsSoldAccessories.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsSoldAccessories.Text = "ساعات وماركات"
        '
        'mnuReportItemsAvailable
        '
        Me.mnuReportItemsAvailable.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportItemsAvailableGold, Me.tsReportItemsAvailableSilver, Me.tsReportItemsAvailableDiamond, Me.tsReportItemsAvailableAccessories})
        Me.mnuReportItemsAvailable.Name = "mnuReportItemsAvailable"
        Me.mnuReportItemsAvailable.Size = New System.Drawing.Size(210, 30)
        Me.mnuReportItemsAvailable.Text = "الأصناف المتوفرة"
        '
        'tsReportItemsAvailableGold
        '
        Me.tsReportItemsAvailableGold.Name = "tsReportItemsAvailableGold"
        Me.tsReportItemsAvailableGold.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAvailableGold.Text = "ذهب"
        '
        'tsReportItemsAvailableSilver
        '
        Me.tsReportItemsAvailableSilver.Name = "tsReportItemsAvailableSilver"
        Me.tsReportItemsAvailableSilver.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAvailableSilver.Text = "فضة"
        '
        'tsReportItemsAvailableDiamond
        '
        Me.tsReportItemsAvailableDiamond.Name = "tsReportItemsAvailableDiamond"
        Me.tsReportItemsAvailableDiamond.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAvailableDiamond.Text = "ألماس"
        '
        'tsReportItemsAvailableAccessories
        '
        Me.tsReportItemsAvailableAccessories.Name = "tsReportItemsAvailableAccessories"
        Me.tsReportItemsAvailableAccessories.Size = New System.Drawing.Size(196, 30)
        Me.tsReportItemsAvailableAccessories.Text = "ساعات وماركات"
        '
        'mnuReportProfit
        '
        Me.mnuReportProfit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsReportProfitGold, Me.tsReportProfitGoldPerPurchaseCost, Me.tsReportProfitSilver, Me.tsReportProfitDiamond, Me.tsReportProfitAccessories})
        Me.mnuReportProfit.Name = "mnuReportProfit"
        Me.mnuReportProfit.Size = New System.Drawing.Size(282, 30)
        Me.mnuReportProfit.Text = "أرباح المبيعات"
        '
        'tsReportProfitGold
        '
        Me.tsReportProfitGold.Name = "tsReportProfitGold"
        Me.tsReportProfitGold.Size = New System.Drawing.Size(301, 30)
        Me.tsReportProfitGold.Text = "ذهب - أرباح حسب المصنعية"
        '
        'tsReportProfitGoldPerPurchaseCost
        '
        Me.tsReportProfitGoldPerPurchaseCost.Name = "tsReportProfitGoldPerPurchaseCost"
        Me.tsReportProfitGoldPerPurchaseCost.Size = New System.Drawing.Size(301, 30)
        Me.tsReportProfitGoldPerPurchaseCost.Text = "ذهب - حسب سعر الشراء"
        '
        'tsReportProfitSilver
        '
        Me.tsReportProfitSilver.Name = "tsReportProfitSilver"
        Me.tsReportProfitSilver.Size = New System.Drawing.Size(301, 30)
        Me.tsReportProfitSilver.Text = "فضة"
        '
        'tsReportProfitDiamond
        '
        Me.tsReportProfitDiamond.Name = "tsReportProfitDiamond"
        Me.tsReportProfitDiamond.Size = New System.Drawing.Size(301, 30)
        Me.tsReportProfitDiamond.Text = "ألماس"
        '
        'tsReportProfitAccessories
        '
        Me.tsReportProfitAccessories.Name = "tsReportProfitAccessories"
        Me.tsReportProfitAccessories.Size = New System.Drawing.Size(301, 30)
        Me.tsReportProfitAccessories.Text = "ساعات وماركات"
        '
        'tsReportCustomers
        '
        Me.tsReportCustomers.Name = "tsReportCustomers"
        Me.tsReportCustomers.Size = New System.Drawing.Size(282, 30)
        Me.tsReportCustomers.Text = "عرض العملاء المسجلين"
        '
        'tsReportExpenses
        '
        Me.tsReportExpenses.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExpReportSellView, Me.ExpReportSellDetailed})
        Me.tsReportExpenses.Name = "tsReportExpenses"
        Me.tsReportExpenses.Size = New System.Drawing.Size(282, 30)
        Me.tsReportExpenses.Text = "تقارير المصروفات"
        '
        'ExpReportSellView
        '
        Me.ExpReportSellView.Name = "ExpReportSellView"
        Me.ExpReportSellView.Size = New System.Drawing.Size(226, 30)
        Me.ExpReportSellView.Text = "مراجعه الفواتير"
        '
        'ExpReportSellDetailed
        '
        Me.ExpReportSellDetailed.Name = "ExpReportSellDetailed"
        Me.ExpReportSellDetailed.Size = New System.Drawing.Size(226, 30)
        Me.ExpReportSellDetailed.Text = "بحث متعدد تفصلي"
        '
        'tsReportCivilIDPrint
        '
        Me.tsReportCivilIDPrint.Name = "tsReportCivilIDPrint"
        Me.tsReportCivilIDPrint.Size = New System.Drawing.Size(282, 30)
        Me.tsReportCivilIDPrint.Text = "طباعة صور البطاقة المدنية"
        '
        'wholesaleReport
        '
        Me.wholesaleReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.wholesaleInvView})
        Me.wholesaleReport.Name = "wholesaleReport"
        Me.wholesaleReport.Size = New System.Drawing.Size(282, 30)
        Me.wholesaleReport.Text = "جمله"
        '
        'wholesaleInvView
        '
        Me.wholesaleInvView.Name = "wholesaleInvView"
        Me.wholesaleInvView.Size = New System.Drawing.Size(193, 30)
        Me.wholesaleInvView.Text = "مراجعة الفواتير"
        '
        'ToolStripBondCash
        '
        Me.ToolStripBondCash.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBondShowCash, Me.ToolStripBondShowDetelsCash})
        Me.ToolStripBondCash.Name = "ToolStripBondCash"
        Me.ToolStripBondCash.Size = New System.Drawing.Size(282, 30)
        Me.ToolStripBondCash.Text = "سند قبض/صرف"
        '
        'ToolStripBondShowCash
        '
        Me.ToolStripBondShowCash.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBondShowCashComp, Me.ToolStripBondShowCashCompPersonal})
        Me.ToolStripBondShowCash.Name = "ToolStripBondShowCash"
        Me.ToolStripBondShowCash.Size = New System.Drawing.Size(233, 30)
        Me.ToolStripBondShowCash.Text = "مراجعة السند"
        '
        'ToolStripBondShowCashComp
        '
        Me.ToolStripBondShowCashComp.Name = "ToolStripBondShowCashComp"
        Me.ToolStripBondShowCashComp.Size = New System.Drawing.Size(177, 30)
        Me.ToolStripBondShowCashComp.Text = "شركات/ورشه"
        '
        'ToolStripBondShowCashCompPersonal
        '
        Me.ToolStripBondShowCashCompPersonal.Name = "ToolStripBondShowCashCompPersonal"
        Me.ToolStripBondShowCashCompPersonal.Size = New System.Drawing.Size(177, 30)
        Me.ToolStripBondShowCashCompPersonal.Text = "شخصي"
        '
        'ToolStripBondShowDetelsCash
        '
        Me.ToolStripBondShowDetelsCash.Name = "ToolStripBondShowDetelsCash"
        Me.ToolStripBondShowDetelsCash.Size = New System.Drawing.Size(233, 30)
        Me.ToolStripBondShowDetelsCash.Text = "بحث متعدد تفصيلي"
        '
        'ToolStripBondGold
        '
        Me.ToolStripBondGold.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBondShowGold, Me.ToolStripBondShowDetelsGold})
        Me.ToolStripBondGold.Name = "ToolStripBondGold"
        Me.ToolStripBondGold.Size = New System.Drawing.Size(282, 30)
        Me.ToolStripBondGold.Text = "سند صرف ذهب"
        '
        'ToolStripBondShowGold
        '
        Me.ToolStripBondShowGold.Name = "ToolStripBondShowGold"
        Me.ToolStripBondShowGold.Size = New System.Drawing.Size(233, 30)
        Me.ToolStripBondShowGold.Text = "مراجعة السند"
        '
        'ToolStripBondShowDetelsGold
        '
        Me.ToolStripBondShowDetelsGold.Name = "ToolStripBondShowDetelsGold"
        Me.ToolStripBondShowDetelsGold.Size = New System.Drawing.Size(233, 30)
        Me.ToolStripBondShowDetelsGold.Text = "بحث متعدد تفصيلي"
        '
        'سندقبضذهبToolStripMenuItem
        '
        Me.سندقبضذهبToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.مراجعةالسنداتToolStripMenuItem, Me.بحثمتعددتفصيليToolStripMenuItem})
        Me.سندقبضذهبToolStripMenuItem.Name = "سندقبضذهبToolStripMenuItem"
        Me.سندقبضذهبToolStripMenuItem.Size = New System.Drawing.Size(282, 30)
        Me.سندقبضذهبToolStripMenuItem.Text = "سند قبض ذهب"
        '
        'مراجعةالسنداتToolStripMenuItem
        '
        Me.مراجعةالسنداتToolStripMenuItem.Name = "مراجعةالسنداتToolStripMenuItem"
        Me.مراجعةالسنداتToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.مراجعةالسنداتToolStripMenuItem.Text = "مراجعة السندات"
        '
        'بحثمتعددتفصيليToolStripMenuItem
        '
        Me.بحثمتعددتفصيليToolStripMenuItem.Name = "بحثمتعددتفصيليToolStripMenuItem"
        Me.بحثمتعددتفصيليToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.بحثمتعددتفصيليToolStripMenuItem.Text = "بحث متعدد تفصيلي"
        '
        'mnuUserManagement
        '
        Me.mnuUserManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUserManagementUser, Me.tsUserManagementCashier})
        Me.mnuUserManagement.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mnuUserManagement.ForeColor = System.Drawing.Color.Black
        Me.mnuUserManagement.Name = "mnuUserManagement"
        Me.mnuUserManagement.Size = New System.Drawing.Size(153, 47)
        Me.mnuUserManagement.Text = "إدارة المستخدمين"
        '
        'tsUserManagementUser
        '
        Me.tsUserManagementUser.Name = "tsUserManagementUser"
        Me.tsUserManagementUser.Size = New System.Drawing.Size(198, 30)
        Me.tsUserManagementUser.Text = "إضافة مستخدم"
        '
        'tsUserManagementCashier
        '
        Me.tsUserManagementCashier.Name = "tsUserManagementCashier"
        Me.tsUserManagementCashier.Size = New System.Drawing.Size(198, 30)
        Me.tsUserManagementCashier.Text = "إضافة كاشير"
        '
        'mnuTransactions
        '
        Me.mnuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTransactionsSell, Me.mnuTransactionsBuy, Me.tsGoldVoucherReceive, Me.tsGoldVoucher, Me.tsTransactionsPaymentVoucher, Me.mnuTransactionsPayInstallment, Me.ExpensesToolStripMenuItem, Me.المحذوفاتذهبفضهالماسToolStripMenuItem})
        Me.mnuTransactions.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mnuTransactions.ForeColor = System.Drawing.Color.Black
        Me.mnuTransactions.Name = "mnuTransactions"
        Me.mnuTransactions.Size = New System.Drawing.Size(97, 47)
        Me.mnuTransactions.Text = "المعاملات"
        '
        'mnuTransactionsSell
        '
        Me.mnuTransactionsSell.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTransactionsSellGold, Me.tsTransactionsSellSilver, Me.tsTransactionsSellDiamond, Me.tsTransactionsSellAuction, Me.tsTransactionsSellAccessories})
        Me.mnuTransactionsSell.Name = "mnuTransactionsSell"
        Me.mnuTransactionsSell.Size = New System.Drawing.Size(322, 30)
        Me.mnuTransactionsSell.Text = "بيع"
        '
        'tsTransactionsSellGold
        '
        Me.tsTransactionsSellGold.Name = "tsTransactionsSellGold"
        Me.tsTransactionsSellGold.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsSellGold.Text = " حذف/تعديل دهب"
        '
        'tsTransactionsSellSilver
        '
        Me.tsTransactionsSellSilver.Name = "tsTransactionsSellSilver"
        Me.tsTransactionsSellSilver.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsSellSilver.Text = "حذف/تعديل فضة"
        '
        'tsTransactionsSellDiamond
        '
        Me.tsTransactionsSellDiamond.Name = "tsTransactionsSellDiamond"
        Me.tsTransactionsSellDiamond.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsSellDiamond.Text = "حذف/تعديل ألماس"
        '
        'tsTransactionsSellAuction
        '
        Me.tsTransactionsSellAuction.Name = "tsTransactionsSellAuction"
        Me.tsTransactionsSellAuction.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsSellAuction.Text = "حذف/تعديل مزادات"
        '
        'tsTransactionsSellAccessories
        '
        Me.tsTransactionsSellAccessories.Name = "tsTransactionsSellAccessories"
        Me.tsTransactionsSellAccessories.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsSellAccessories.Text = "حذف/تعديل ساعات"
        '
        'mnuTransactionsBuy
        '
        Me.mnuTransactionsBuy.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTransactionsBuyGold, Me.tsTransactionsBuySilver, Me.tsTransactionsBuyDiamond, Me.tsTransactionsBuyAccessories})
        Me.mnuTransactionsBuy.Name = "mnuTransactionsBuy"
        Me.mnuTransactionsBuy.Size = New System.Drawing.Size(322, 30)
        Me.mnuTransactionsBuy.Text = "شراء"
        '
        'tsTransactionsBuyGold
        '
        Me.tsTransactionsBuyGold.Name = "tsTransactionsBuyGold"
        Me.tsTransactionsBuyGold.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsBuyGold.Text = "حذف/تعديل ذهب"
        '
        'tsTransactionsBuySilver
        '
        Me.tsTransactionsBuySilver.Name = "tsTransactionsBuySilver"
        Me.tsTransactionsBuySilver.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsBuySilver.Text = "حذف/تعديل فضة"
        '
        'tsTransactionsBuyDiamond
        '
        Me.tsTransactionsBuyDiamond.Name = "tsTransactionsBuyDiamond"
        Me.tsTransactionsBuyDiamond.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsBuyDiamond.Text = "حذف/تعديل ألماس"
        '
        'tsTransactionsBuyAccessories
        '
        Me.tsTransactionsBuyAccessories.Name = "tsTransactionsBuyAccessories"
        Me.tsTransactionsBuyAccessories.Size = New System.Drawing.Size(236, 30)
        Me.tsTransactionsBuyAccessories.Text = "حذف/تعديل ساعات"
        '
        'tsGoldVoucherReceive
        '
        Me.tsGoldVoucherReceive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoldVoucherReceiveCreateNew, Me.GoldVoucherReceiveEdite})
        Me.tsGoldVoucherReceive.Name = "tsGoldVoucherReceive"
        Me.tsGoldVoucherReceive.Size = New System.Drawing.Size(322, 30)
        Me.tsGoldVoucherReceive.Text = "سند صرف ذهب"
        '
        'GoldVoucherReceiveCreateNew
        '
        Me.GoldVoucherReceiveCreateNew.Name = "GoldVoucherReceiveCreateNew"
        Me.GoldVoucherReceiveCreateNew.Size = New System.Drawing.Size(230, 30)
        Me.GoldVoucherReceiveCreateNew.Text = "انشاء جديد"
        '
        'GoldVoucherReceiveEdite
        '
        Me.GoldVoucherReceiveEdite.Name = "GoldVoucherReceiveEdite"
        Me.GoldVoucherReceiveEdite.Size = New System.Drawing.Size(230, 30)
        Me.GoldVoucherReceiveEdite.Text = "حزف / تعديل سابق"
        '
        'tsGoldVoucher
        '
        Me.tsGoldVoucher.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoldVoucherCreateNew, Me.GoldVoucherEdite})
        Me.tsGoldVoucher.Name = "tsGoldVoucher"
        Me.tsGoldVoucher.Size = New System.Drawing.Size(322, 30)
        Me.tsGoldVoucher.Text = "سند قبض ذهب"
        '
        'GoldVoucherCreateNew
        '
        Me.GoldVoucherCreateNew.Name = "GoldVoucherCreateNew"
        Me.GoldVoucherCreateNew.Size = New System.Drawing.Size(230, 30)
        Me.GoldVoucherCreateNew.Text = "انشاء جديد"
        '
        'GoldVoucherEdite
        '
        Me.GoldVoucherEdite.Name = "GoldVoucherEdite"
        Me.GoldVoucherEdite.Size = New System.Drawing.Size(230, 30)
        Me.GoldVoucherEdite.Text = "حزف / تعديل سابق"
        '
        'tsTransactionsPaymentVoucher
        '
        Me.tsTransactionsPaymentVoucher.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.انشاءجديدToolStripMenuItem1, Me.حزفتعديلسابقToolStripMenuItem})
        Me.tsTransactionsPaymentVoucher.Name = "tsTransactionsPaymentVoucher"
        Me.tsTransactionsPaymentVoucher.Size = New System.Drawing.Size(322, 30)
        Me.tsTransactionsPaymentVoucher.Text = "سند صرف نقدي"
        '
        'انشاءجديدToolStripMenuItem1
        '
        Me.انشاءجديدToolStripMenuItem1.Name = "انشاءجديدToolStripMenuItem1"
        Me.انشاءجديدToolStripMenuItem1.Size = New System.Drawing.Size(230, 30)
        Me.انشاءجديدToolStripMenuItem1.Text = "انشاء جديد"
        '
        'حزفتعديلسابقToolStripMenuItem
        '
        Me.حزفتعديلسابقToolStripMenuItem.Name = "حزفتعديلسابقToolStripMenuItem"
        Me.حزفتعديلسابقToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.حزفتعديلسابقToolStripMenuItem.Text = "حزف / تعديل سابق"
        '
        'mnuTransactionsPayInstallment
        '
        Me.mnuTransactionsPayInstallment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTransactionsPayInstallmentGoldSilver, Me.tsTransactionsPayInstallmentDiamond, Me.tsTransactionsPayInstallmentAccessories})
        Me.mnuTransactionsPayInstallment.Name = "mnuTransactionsPayInstallment"
        Me.mnuTransactionsPayInstallment.Size = New System.Drawing.Size(322, 30)
        Me.mnuTransactionsPayInstallment.Text = "الدفع الآجل"
        '
        'tsTransactionsPayInstallmentGoldSilver
        '
        Me.tsTransactionsPayInstallmentGoldSilver.Name = "tsTransactionsPayInstallmentGoldSilver"
        Me.tsTransactionsPayInstallmentGoldSilver.Size = New System.Drawing.Size(231, 30)
        Me.tsTransactionsPayInstallmentGoldSilver.Text = "ذهب / فضة"
        '
        'tsTransactionsPayInstallmentDiamond
        '
        Me.tsTransactionsPayInstallmentDiamond.Name = "tsTransactionsPayInstallmentDiamond"
        Me.tsTransactionsPayInstallmentDiamond.Size = New System.Drawing.Size(231, 30)
        Me.tsTransactionsPayInstallmentDiamond.Text = "ألماس"
        '
        'tsTransactionsPayInstallmentAccessories
        '
        Me.tsTransactionsPayInstallmentAccessories.Name = "tsTransactionsPayInstallmentAccessories"
        Me.tsTransactionsPayInstallmentAccessories.Size = New System.Drawing.Size(231, 30)
        Me.tsTransactionsPayInstallmentAccessories.Text = "ساعات واكسسوارات"
        '
        'ExpensesToolStripMenuItem
        '
        Me.ExpensesToolStripMenuItem.Name = "ExpensesToolStripMenuItem"
        Me.ExpensesToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.ExpensesToolStripMenuItem.Text = "حزف/تعديل المصروفات"
        '
        'mnuLicense
        '
        Me.mnuLicense.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLicenseGet})
        Me.mnuLicense.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.mnuLicense.ForeColor = System.Drawing.Color.Black
        Me.mnuLicense.Name = "mnuLicense"
        Me.mnuLicense.Size = New System.Drawing.Size(87, 47)
        Me.mnuLicense.Text = "الترخيص"
        '
        'tsLicenseGet
        '
        Me.tsLicenseGet.Name = "tsLicenseGet"
        Me.tsLicenseGet.Size = New System.Drawing.Size(238, 30)
        Me.tsLicenseGet.Text = "طلب مفتاح الترخيص"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SelectColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(115, 47)
        Me.SelectColorToolStripMenuItem.Text = "ضبط الالوان"
        '
        'pnlMenu
        '
        Me.pnlMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenu.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMenu.Controls.Add(Me.dtEndDate)
        Me.pnlMenu.Controls.Add(Me.lblTechSupportEnd)
        Me.pnlMenu.Controls.Add(Me.msMenuMain)
        Me.pnlMenu.ForeColor = System.Drawing.Color.Black
        Me.pnlMenu.Location = New System.Drawing.Point(1, 3)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(1291, 60)
        Me.pnlMenu.TabIndex = 9
        '
        'dtEndDate
        '
        Me.dtEndDate.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.dtEndDate.Enabled = False
        Me.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEndDate.Location = New System.Drawing.Point(1, 15)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(115, 27)
        Me.dtEndDate.TabIndex = 10
        '
        'lblTechSupportEnd
        '
        Me.lblTechSupportEnd.ForeColor = System.Drawing.Color.Black
        Me.lblTechSupportEnd.Location = New System.Drawing.Point(119, 2)
        Me.lblTechSupportEnd.Name = "lblTechSupportEnd"
        Me.lblTechSupportEnd.Size = New System.Drawing.Size(144, 54)
        Me.lblTechSupportEnd.TabIndex = 9
        Me.lblTechSupportEnd.Text = "تاريخ انتهاء الدعم الفني"
        Me.lblTechSupportEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCompanyName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.Black
        Me.lblCompanyName.Location = New System.Drawing.Point(1, 644)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(1291, 45)
        Me.lblCompanyName.TabIndex = 14
        Me.lblCompanyName.Text = "جاري التحميل...يرجى الانتظار"
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPrice
        '
        Me.pnlPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice.BackColor = System.Drawing.Color.Black
        Me.pnlPrice.Controls.Add(Me.Panel8)
        Me.pnlPrice.Controls.Add(Me.lblCurrencyBuy)
        Me.pnlPrice.Controls.Add(Me.Panel9)
        Me.pnlPrice.Controls.Add(Me.Panel2)
        Me.pnlPrice.Controls.Add(Me.pnlPriceOunce)
        Me.pnlPrice.Controls.Add(Me.Panel3)
        Me.pnlPrice.Controls.Add(Me.Panel4)
        Me.pnlPrice.Controls.Add(Me.lblCurrencySale)
        Me.pnlPrice.Controls.Add(Me.Panel5)
        Me.pnlPrice.Controls.Add(Me.pnlPrice925)
        Me.pnlPrice.Controls.Add(Me.Panel6)
        Me.pnlPrice.Controls.Add(Me.pnlPrice24)
        Me.pnlPrice.Controls.Add(Me.Panel7)
        Me.pnlPrice.Controls.Add(Me.pnlPrice22)
        Me.pnlPrice.Controls.Add(Me.pnlPrice21)
        Me.pnlPrice.Controls.Add(Me.pnlPrice18)
        Me.pnlPrice.Controls.Add(Me.btnRefresh)
        Me.pnlPrice.Location = New System.Drawing.Point(1, 62)
        Me.pnlPrice.Name = "pnlPrice"
        Me.pnlPrice.Size = New System.Drawing.Size(1289, 65)
        Me.pnlPrice.TabIndex = 20
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.lblBuyOunceUsd)
        Me.Panel8.Controls.Add(Me.LabOunceBuyUsd)
        Me.Panel8.Location = New System.Drawing.Point(1165, 33)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(122, 30)
        Me.Panel8.TabIndex = 17
        '
        'lblBuyOunceUsd
        '
        Me.lblBuyOunceUsd.AutoSize = True
        Me.lblBuyOunceUsd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuyOunceUsd.ForeColor = System.Drawing.Color.Black
        Me.lblBuyOunceUsd.LinkColor = System.Drawing.Color.Black
        Me.lblBuyOunceUsd.Location = New System.Drawing.Point(4, 4)
        Me.lblBuyOunceUsd.Name = "lblBuyOunceUsd"
        Me.lblBuyOunceUsd.Size = New System.Drawing.Size(21, 15)
        Me.lblBuyOunceUsd.TabIndex = 4
        Me.lblBuyOunceUsd.TabStop = True
        Me.lblBuyOunceUsd.Text = "00"
        '
        'LabOunceBuyUsd
        '
        Me.LabOunceBuyUsd.BackColor = System.Drawing.Color.Transparent
        Me.LabOunceBuyUsd.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabOunceBuyUsd.ForeColor = System.Drawing.Color.Black
        Me.LabOunceBuyUsd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabOunceBuyUsd.Location = New System.Drawing.Point(56, 4)
        Me.LabOunceBuyUsd.Name = "LabOunceBuyUsd"
        Me.LabOunceBuyUsd.Size = New System.Drawing.Size(59, 21)
        Me.LabOunceBuyUsd.TabIndex = 0
        Me.LabOunceBuyUsd.Text = "أونصة"
        Me.LabOunceBuyUsd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrencyBuy
        '
        Me.lblCurrencyBuy.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCurrencyBuy.AutoSize = True
        Me.lblCurrencyBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCurrencyBuy.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencyBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrencyBuy.Location = New System.Drawing.Point(467, 36)
        Me.lblCurrencyBuy.Name = "lblCurrencyBuy"
        Me.lblCurrencyBuy.Size = New System.Drawing.Size(90, 26)
        Me.lblCurrencyBuy.TabIndex = 156
        Me.lblCurrencyBuy.Text = "دينار كويتي"
        Me.lblCurrencyBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.lblSellOunceUsd)
        Me.Panel9.Controls.Add(Me.LabSellOunceUsd)
        Me.Panel9.Location = New System.Drawing.Point(1165, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(122, 30)
        Me.Panel9.TabIndex = 16
        '
        'lblSellOunceUsd
        '
        Me.lblSellOunceUsd.AutoSize = True
        Me.lblSellOunceUsd.DisabledLinkColor = System.Drawing.Color.Black
        Me.lblSellOunceUsd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSellOunceUsd.ForeColor = System.Drawing.Color.Black
        Me.lblSellOunceUsd.LinkColor = System.Drawing.Color.Black
        Me.lblSellOunceUsd.Location = New System.Drawing.Point(4, 4)
        Me.lblSellOunceUsd.Name = "lblSellOunceUsd"
        Me.lblSellOunceUsd.Size = New System.Drawing.Size(21, 15)
        Me.lblSellOunceUsd.TabIndex = 4
        Me.lblSellOunceUsd.TabStop = True
        Me.lblSellOunceUsd.Text = "00"
        '
        'LabSellOunceUsd
        '
        Me.LabSellOunceUsd.BackColor = System.Drawing.Color.Transparent
        Me.LabSellOunceUsd.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSellOunceUsd.ForeColor = System.Drawing.Color.Black
        Me.LabSellOunceUsd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabSellOunceUsd.Location = New System.Drawing.Point(56, 4)
        Me.LabSellOunceUsd.Name = "LabSellOunceUsd"
        Me.LabSellOunceUsd.Size = New System.Drawing.Size(59, 19)
        Me.LabSellOunceUsd.TabIndex = 0
        Me.LabSellOunceUsd.Text = "أونصة"
        Me.LabSellOunceUsd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblOunceBUY)
        Me.Panel2.Controls.Add(Me.LIB_OUNCEBUY)
        Me.Panel2.Location = New System.Drawing.Point(1069, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(96, 30)
        Me.Panel2.TabIndex = 15
        '
        'lblOunceBUY
        '
        Me.lblOunceBUY.AutoSize = True
        Me.lblOunceBUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOunceBUY.ForeColor = System.Drawing.Color.Black
        Me.lblOunceBUY.LinkColor = System.Drawing.Color.Black
        Me.lblOunceBUY.Location = New System.Drawing.Point(1, 4)
        Me.lblOunceBUY.Name = "lblOunceBUY"
        Me.lblOunceBUY.Size = New System.Drawing.Size(21, 15)
        Me.lblOunceBUY.TabIndex = 4
        Me.lblOunceBUY.TabStop = True
        Me.lblOunceBUY.Text = "00"
        '
        'LIB_OUNCEBUY
        '
        Me.LIB_OUNCEBUY.BackColor = System.Drawing.Color.Transparent
        Me.LIB_OUNCEBUY.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIB_OUNCEBUY.ForeColor = System.Drawing.Color.Black
        Me.LIB_OUNCEBUY.Location = New System.Drawing.Point(46, 4)
        Me.LIB_OUNCEBUY.Name = "LIB_OUNCEBUY"
        Me.LIB_OUNCEBUY.Size = New System.Drawing.Size(43, 16)
        Me.LIB_OUNCEBUY.TabIndex = 0
        Me.LIB_OUNCEBUY.Text = "أونصة"
        Me.LIB_OUNCEBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPriceOunce
        '
        Me.pnlPriceOunce.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPriceOunce.BackColor = System.Drawing.Color.Gray
        Me.pnlPriceOunce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPriceOunce.Controls.Add(Me.lblOunce)
        Me.pnlPriceOunce.Controls.Add(Me.LIB_OUNCE)
        Me.pnlPriceOunce.Location = New System.Drawing.Point(1069, 2)
        Me.pnlPriceOunce.Name = "pnlPriceOunce"
        Me.pnlPriceOunce.Size = New System.Drawing.Size(96, 30)
        Me.pnlPriceOunce.TabIndex = 9
        '
        'lblOunce
        '
        Me.lblOunce.AutoSize = True
        Me.lblOunce.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOunce.LinkColor = System.Drawing.Color.Black
        Me.lblOunce.Location = New System.Drawing.Point(1, 4)
        Me.lblOunce.Name = "lblOunce"
        Me.lblOunce.Size = New System.Drawing.Size(21, 15)
        Me.lblOunce.TabIndex = 4
        Me.lblOunce.TabStop = True
        Me.lblOunce.Text = "00"
        '
        'LIB_OUNCE
        '
        Me.LIB_OUNCE.BackColor = System.Drawing.Color.Transparent
        Me.LIB_OUNCE.Font = New System.Drawing.Font("Calibri", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIB_OUNCE.ForeColor = System.Drawing.Color.Black
        Me.LIB_OUNCE.Location = New System.Drawing.Point(46, 4)
        Me.LIB_OUNCE.Name = "LIB_OUNCE"
        Me.LIB_OUNCE.Size = New System.Drawing.Size(43, 18)
        Me.LIB_OUNCE.TabIndex = 0
        Me.LIB_OUNCE.Text = "أونصة"
        Me.LIB_OUNCE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblSilver925BUY)
        Me.Panel3.Controls.Add(Me.lblSilver925KBUY)
        Me.Panel3.Location = New System.Drawing.Point(563, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(119, 30)
        Me.Panel3.TabIndex = 18
        '
        'lblSilver925BUY
        '
        Me.lblSilver925BUY.AutoSize = True
        Me.lblSilver925BUY.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilver925BUY.LinkColor = System.Drawing.Color.Red
        Me.lblSilver925BUY.Location = New System.Drawing.Point(6, 4)
        Me.lblSilver925BUY.Name = "lblSilver925BUY"
        Me.lblSilver925BUY.Size = New System.Drawing.Size(19, 14)
        Me.lblSilver925BUY.TabIndex = 7
        Me.lblSilver925BUY.TabStop = True
        Me.lblSilver925BUY.Text = "00"
        '
        'lblSilver925KBUY
        '
        Me.lblSilver925KBUY.BackColor = System.Drawing.Color.Black
        Me.lblSilver925KBUY.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilver925KBUY.ForeColor = System.Drawing.Color.Transparent
        Me.lblSilver925KBUY.Location = New System.Drawing.Point(45, 5)
        Me.lblSilver925KBUY.Name = "lblSilver925KBUY"
        Me.lblSilver925KBUY.Size = New System.Drawing.Size(70, 17)
        Me.lblSilver925KBUY.TabIndex = 3
        Me.lblSilver925KBUY.Text = "فضه عيار 925"
        Me.lblSilver925KBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lbl24BUY)
        Me.Panel4.Controls.Add(Me.lbl24KBUY)
        Me.Panel4.Location = New System.Drawing.Point(970, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(99, 30)
        Me.Panel4.TabIndex = 13
        '
        'lbl24BUY
        '
        Me.lbl24BUY.AutoSize = True
        Me.lbl24BUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24BUY.ForeColor = System.Drawing.Color.Black
        Me.lbl24BUY.LinkColor = System.Drawing.Color.Black
        Me.lbl24BUY.Location = New System.Drawing.Point(3, 4)
        Me.lbl24BUY.Name = "lbl24BUY"
        Me.lbl24BUY.Size = New System.Drawing.Size(21, 15)
        Me.lbl24BUY.TabIndex = 4
        Me.lbl24BUY.TabStop = True
        Me.lbl24BUY.Text = "00"
        '
        'lbl24KBUY
        '
        Me.lbl24KBUY.BackColor = System.Drawing.Color.Transparent
        Me.lbl24KBUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24KBUY.ForeColor = System.Drawing.Color.Black
        Me.lbl24KBUY.Location = New System.Drawing.Point(38, 4)
        Me.lbl24KBUY.Name = "lbl24KBUY"
        Me.lbl24KBUY.Size = New System.Drawing.Size(59, 18)
        Me.lbl24KBUY.TabIndex = 0
        Me.lbl24KBUY.Text = "عيار 24"
        Me.lbl24KBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrencySale
        '
        Me.lblCurrencySale.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCurrencySale.AutoSize = True
        Me.lblCurrencySale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCurrencySale.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencySale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblCurrencySale.Location = New System.Drawing.Point(467, 3)
        Me.lblCurrencySale.Name = "lblCurrencySale"
        Me.lblCurrencySale.Size = New System.Drawing.Size(90, 26)
        Me.lblCurrencySale.TabIndex = 13
        Me.lblCurrencySale.Text = "دينار كويتي"
        Me.lblCurrencySale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lbl22BUY)
        Me.Panel5.Controls.Add(Me.lbl22KBUY)
        Me.Panel5.Location = New System.Drawing.Point(880, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(90, 30)
        Me.Panel5.TabIndex = 14
        '
        'lbl22BUY
        '
        Me.lbl22BUY.AutoSize = True
        Me.lbl22BUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22BUY.ForeColor = System.Drawing.Color.Black
        Me.lbl22BUY.LinkColor = System.Drawing.Color.Black
        Me.lbl22BUY.Location = New System.Drawing.Point(3, 4)
        Me.lbl22BUY.Name = "lbl22BUY"
        Me.lbl22BUY.Size = New System.Drawing.Size(21, 15)
        Me.lbl22BUY.TabIndex = 5
        Me.lbl22BUY.TabStop = True
        Me.lbl22BUY.Text = "00"
        '
        'lbl22KBUY
        '
        Me.lbl22KBUY.BackColor = System.Drawing.Color.Transparent
        Me.lbl22KBUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22KBUY.ForeColor = System.Drawing.Color.Black
        Me.lbl22KBUY.Location = New System.Drawing.Point(42, 4)
        Me.lbl22KBUY.Name = "lbl22KBUY"
        Me.lbl22KBUY.Size = New System.Drawing.Size(43, 16)
        Me.lbl22KBUY.TabIndex = 1
        Me.lbl22KBUY.Text = "عيار 22"
        Me.lbl22KBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPrice925
        '
        Me.pnlPrice925.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice925.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlPrice925.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrice925.Controls.Add(Me.lblSilver925)
        Me.pnlPrice925.Controls.Add(Me.lblSilver925K)
        Me.pnlPrice925.Location = New System.Drawing.Point(563, 2)
        Me.pnlPrice925.Name = "pnlPrice925"
        Me.pnlPrice925.Size = New System.Drawing.Size(119, 30)
        Me.pnlPrice925.TabIndex = 12
        '
        'lblSilver925
        '
        Me.lblSilver925.AutoSize = True
        Me.lblSilver925.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilver925.LinkColor = System.Drawing.Color.Red
        Me.lblSilver925.Location = New System.Drawing.Point(6, 5)
        Me.lblSilver925.Name = "lblSilver925"
        Me.lblSilver925.Size = New System.Drawing.Size(19, 14)
        Me.lblSilver925.TabIndex = 7
        Me.lblSilver925.TabStop = True
        Me.lblSilver925.Text = "00"
        '
        'lblSilver925K
        '
        Me.lblSilver925K.BackColor = System.Drawing.Color.Black
        Me.lblSilver925K.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSilver925K.ForeColor = System.Drawing.Color.Transparent
        Me.lblSilver925K.Location = New System.Drawing.Point(45, 5)
        Me.lblSilver925K.Name = "lblSilver925K"
        Me.lblSilver925K.Size = New System.Drawing.Size(70, 15)
        Me.lblSilver925K.TabIndex = 3
        Me.lblSilver925K.Text = "فضه عيار 925"
        Me.lblSilver925K.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.lbl21BUY)
        Me.Panel6.Controls.Add(Me.lbl21KBUY)
        Me.Panel6.Location = New System.Drawing.Point(784, 33)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(96, 30)
        Me.Panel6.TabIndex = 16
        '
        'lbl21BUY
        '
        Me.lbl21BUY.AutoSize = True
        Me.lbl21BUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21BUY.ForeColor = System.Drawing.Color.Black
        Me.lbl21BUY.LinkColor = System.Drawing.Color.Black
        Me.lbl21BUY.Location = New System.Drawing.Point(2, 4)
        Me.lbl21BUY.Name = "lbl21BUY"
        Me.lbl21BUY.Size = New System.Drawing.Size(21, 15)
        Me.lbl21BUY.TabIndex = 6
        Me.lbl21BUY.TabStop = True
        Me.lbl21BUY.Text = "00"
        '
        'lbl21KBUY
        '
        Me.lbl21KBUY.BackColor = System.Drawing.Color.Transparent
        Me.lbl21KBUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21KBUY.ForeColor = System.Drawing.Color.Black
        Me.lbl21KBUY.Location = New System.Drawing.Point(47, 4)
        Me.lbl21KBUY.Name = "lbl21KBUY"
        Me.lbl21KBUY.Size = New System.Drawing.Size(43, 16)
        Me.lbl21KBUY.TabIndex = 2
        Me.lbl21KBUY.Text = "عيار 21"
        Me.lbl21KBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPrice24
        '
        Me.pnlPrice24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice24.BackColor = System.Drawing.Color.Gray
        Me.pnlPrice24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrice24.Controls.Add(Me.lbl24)
        Me.pnlPrice24.Controls.Add(Me.lbl24K)
        Me.pnlPrice24.Location = New System.Drawing.Point(970, 2)
        Me.pnlPrice24.Name = "pnlPrice24"
        Me.pnlPrice24.Size = New System.Drawing.Size(99, 30)
        Me.pnlPrice24.TabIndex = 8
        '
        'lbl24
        '
        Me.lbl24.AutoSize = True
        Me.lbl24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24.LinkColor = System.Drawing.Color.Black
        Me.lbl24.Location = New System.Drawing.Point(3, 4)
        Me.lbl24.Name = "lbl24"
        Me.lbl24.Size = New System.Drawing.Size(21, 15)
        Me.lbl24.TabIndex = 4
        Me.lbl24.TabStop = True
        Me.lbl24.Text = "00"
        '
        'lbl24K
        '
        Me.lbl24K.BackColor = System.Drawing.Color.Transparent
        Me.lbl24K.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl24K.ForeColor = System.Drawing.Color.Black
        Me.lbl24K.Location = New System.Drawing.Point(38, 0)
        Me.lbl24K.Name = "lbl24K"
        Me.lbl24K.Size = New System.Drawing.Size(58, 27)
        Me.lbl24K.TabIndex = 0
        Me.lbl24K.Text = "عيار 24"
        Me.lbl24K.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lbl18BUY)
        Me.Panel7.Controls.Add(Me.lbl18KBUY)
        Me.Panel7.Location = New System.Drawing.Point(682, 33)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(102, 30)
        Me.Panel7.TabIndex = 17
        '
        'lbl18BUY
        '
        Me.lbl18BUY.AutoSize = True
        Me.lbl18BUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18BUY.ForeColor = System.Drawing.Color.Black
        Me.lbl18BUY.LinkColor = System.Drawing.Color.Black
        Me.lbl18BUY.Location = New System.Drawing.Point(2, 4)
        Me.lbl18BUY.Name = "lbl18BUY"
        Me.lbl18BUY.Size = New System.Drawing.Size(21, 15)
        Me.lbl18BUY.TabIndex = 7
        Me.lbl18BUY.TabStop = True
        Me.lbl18BUY.Text = "00"
        '
        'lbl18KBUY
        '
        Me.lbl18KBUY.BackColor = System.Drawing.Color.Transparent
        Me.lbl18KBUY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18KBUY.ForeColor = System.Drawing.Color.Black
        Me.lbl18KBUY.Location = New System.Drawing.Point(52, 4)
        Me.lbl18KBUY.Name = "lbl18KBUY"
        Me.lbl18KBUY.Size = New System.Drawing.Size(43, 16)
        Me.lbl18KBUY.TabIndex = 3
        Me.lbl18KBUY.Text = "عيار 18"
        Me.lbl18KBUY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPrice22
        '
        Me.pnlPrice22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice22.BackColor = System.Drawing.Color.Gray
        Me.pnlPrice22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrice22.Controls.Add(Me.lbl22)
        Me.pnlPrice22.Controls.Add(Me.lbl22K)
        Me.pnlPrice22.Location = New System.Drawing.Point(880, 2)
        Me.pnlPrice22.Name = "pnlPrice22"
        Me.pnlPrice22.Size = New System.Drawing.Size(90, 30)
        Me.pnlPrice22.TabIndex = 9
        '
        'lbl22
        '
        Me.lbl22.AutoSize = True
        Me.lbl22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22.LinkColor = System.Drawing.Color.Black
        Me.lbl22.Location = New System.Drawing.Point(3, 4)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(21, 15)
        Me.lbl22.TabIndex = 5
        Me.lbl22.TabStop = True
        Me.lbl22.Text = "00"
        '
        'lbl22K
        '
        Me.lbl22K.BackColor = System.Drawing.Color.Transparent
        Me.lbl22K.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl22K.ForeColor = System.Drawing.Color.Black
        Me.lbl22K.Location = New System.Drawing.Point(42, 4)
        Me.lbl22K.Name = "lbl22K"
        Me.lbl22K.Size = New System.Drawing.Size(43, 16)
        Me.lbl22K.TabIndex = 1
        Me.lbl22K.Text = "عيار 22"
        Me.lbl22K.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPrice21
        '
        Me.pnlPrice21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice21.BackColor = System.Drawing.Color.Gray
        Me.pnlPrice21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrice21.Controls.Add(Me.lbl21)
        Me.pnlPrice21.Controls.Add(Me.lbl21K)
        Me.pnlPrice21.Location = New System.Drawing.Point(784, 2)
        Me.pnlPrice21.Name = "pnlPrice21"
        Me.pnlPrice21.Size = New System.Drawing.Size(96, 30)
        Me.pnlPrice21.TabIndex = 10
        '
        'lbl21
        '
        Me.lbl21.AutoSize = True
        Me.lbl21.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21.LinkColor = System.Drawing.Color.Black
        Me.lbl21.Location = New System.Drawing.Point(2, 4)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(21, 15)
        Me.lbl21.TabIndex = 6
        Me.lbl21.TabStop = True
        Me.lbl21.Text = "00"
        '
        'lbl21K
        '
        Me.lbl21K.BackColor = System.Drawing.Color.Transparent
        Me.lbl21K.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl21K.ForeColor = System.Drawing.Color.Black
        Me.lbl21K.Location = New System.Drawing.Point(47, 4)
        Me.lbl21K.Name = "lbl21K"
        Me.lbl21K.Size = New System.Drawing.Size(43, 16)
        Me.lbl21K.TabIndex = 2
        Me.lbl21K.Text = "عيار 21"
        Me.lbl21K.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlPrice18
        '
        Me.pnlPrice18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrice18.BackColor = System.Drawing.Color.Gray
        Me.pnlPrice18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPrice18.Controls.Add(Me.lbl18)
        Me.pnlPrice18.Controls.Add(Me.lbl18K)
        Me.pnlPrice18.Location = New System.Drawing.Point(682, 2)
        Me.pnlPrice18.Name = "pnlPrice18"
        Me.pnlPrice18.Size = New System.Drawing.Size(102, 30)
        Me.pnlPrice18.TabIndex = 11
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18.LinkColor = System.Drawing.Color.Black
        Me.lbl18.Location = New System.Drawing.Point(2, 4)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(21, 15)
        Me.lbl18.TabIndex = 7
        Me.lbl18.TabStop = True
        Me.lbl18.Text = "00"
        '
        'lbl18K
        '
        Me.lbl18K.BackColor = System.Drawing.Color.Transparent
        Me.lbl18K.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18K.ForeColor = System.Drawing.Color.Black
        Me.lbl18K.Location = New System.Drawing.Point(54, 4)
        Me.lbl18K.Name = "lbl18K"
        Me.lbl18K.Size = New System.Drawing.Size(43, 16)
        Me.lbl18K.TabIndex = 3
        Me.lbl18K.Text = "عيار 18"
        Me.lbl18K.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aquamarine
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(59, 57)
        Me.btnRefresh.TabIndex = 155
        Me.btnRefresh.Text = "تحديث"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accessories_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BAYTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_Buy_PayTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BuyTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_CATTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_DEPTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_INVTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ADS_SERVICESTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BarcodeSetTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
        Me.TableAdapterManager.BAYWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.Buy_DiamondTableAdapter = Nothing
        Me.TableAdapterManager.Buy_GoldTableAdapter = Nothing
        Me.TableAdapterManager.cacherTableAdapter = Nothing
        Me.TableAdapterManager.CANTRYTableAdapter = Nothing
        Me.TableAdapterManager.CastomerDETELSTableAdapter = Nothing
        Me.TableAdapterManager.COMP_BAYTableAdapter = Nothing
        Me.TableAdapterManager.COMP_detels_for_bayTableAdapter = Nothing
        Me.TableAdapterManager.comp_detelsTableAdapter = Nothing
        Me.TableAdapterManager.comp_informTableAdapter = Nothing
        Me.TableAdapterManager.COMP_INVOCE_CACHETableAdapter = Nothing
        Me.TableAdapterManager.COMPANY_BAY_DETELSTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcood_dimonTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcoodTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CurrencyTypeTableAdapter = Nothing
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTypeTableAdapter = Nothing
        Me.TableAdapterManager.EXTR_NAMETableAdapter = Nothing
        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.Item_NameTableAdapter = Nothing
        Me.TableAdapterManager.LICENSE_TTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.PayInstallmentTableAdapter = Nothing
        Me.TableAdapterManager.PayMethodTableAdapter = Nothing
        Me.TableAdapterManager.ReportPathTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.SilverBAYTableAdapter = Nothing
        Me.TableAdapterManager.SilverInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.SilverItemTableAdapter = Nothing
        Me.TableAdapterManager.SndGoldTableAdapter = Nothing
        Me.TableAdapterManager.SndToCustomerTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.TBBondGoldTypeTableAdapter = Nothing
        Me.TableAdapterManager.TBBondTypeTableAdapter = Nothing
        Me.TableAdapterManager.TBErrorDescriptionTableAdapter = Nothing
        Me.TableAdapterManager.TPBank_InfoTableAdapter = Nothing
        Me.TableAdapterManager.TPBranchDetailsTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanyBranchesTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanyInfoTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanylicenseIDTableAdapter = Nothing
        Me.TableAdapterManager.TPGoldVoucherReceiveTableAdapter = Nothing
        Me.TableAdapterManager.TPGoldVoucherTableAdapter = Nothing
        Me.TableAdapterManager.TPSellBuyWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.TpSetGoledPriceDiffTableAdapter = Nothing
        Me.TableAdapterManager.TPTaxTableAdapter = Nothing
        Me.TableAdapterManager.TPTransferTableAdapter = Nothing
        Me.TableAdapterManager.TPWhatsAppMessagesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'SET_INVARCHR142TextBox
        '
        Me.SET_INVARCHR142TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR142TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR142", True))
        Me.SET_INVARCHR142TextBox.Location = New System.Drawing.Point(1704, 59)
        Me.SET_INVARCHR142TextBox.Name = "SET_INVARCHR142TextBox"
        Me.SET_INVARCHR142TextBox.Size = New System.Drawing.Size(31, 27)
        Me.SET_INVARCHR142TextBox.TabIndex = 156
        '
        'lblTechSupport
        '
        Me.lblTechSupport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTechSupport.BackColor = System.Drawing.Color.Transparent
        Me.lblTechSupport.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTechSupport.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTechSupport.LinkColor = System.Drawing.Color.Black
        Me.lblTechSupport.Location = New System.Drawing.Point(4, 128)
        Me.lblTechSupport.Name = "lblTechSupport"
        Me.lblTechSupport.Size = New System.Drawing.Size(1288, 42)
        Me.lblTechSupport.TabIndex = 163
        Me.lblTechSupport.TabStop = True
        Me.lblTechSupport.Text = "(92297481-90083366-91111925)شركة ساب الدوليه للحلول المتكالمه الحاسوبيه ارقام الد" &
    "عم الفني"
        Me.lblTechSupport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LepOpencount
        '
        Me.LepOpencount.BackColor = System.Drawing.Color.Transparent
        Me.LepOpencount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LepOpencount.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LepOpencount.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LepOpencount.ForeColor = System.Drawing.Color.Transparent
        Me.LepOpencount.Location = New System.Drawing.Point(8, 172)
        Me.LepOpencount.Name = "LepOpencount"
        Me.LepOpencount.Size = New System.Drawing.Size(38, 39)
        Me.LepOpencount.TabIndex = 165
        Me.LepOpencount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LebMySqlShopNmae
        '
        Me.LebMySqlShopNmae.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LebMySqlShopNmae.BackColor = System.Drawing.Color.Transparent
        Me.LebMySqlShopNmae.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LebMySqlShopNmae.ForeColor = System.Drawing.Color.White
        Me.LebMySqlShopNmae.Location = New System.Drawing.Point(904, 6)
        Me.LebMySqlShopNmae.Name = "LebMySqlShopNmae"
        Me.LebMySqlShopNmae.Size = New System.Drawing.Size(334, 26)
        Me.LebMySqlShopNmae.TabIndex = 166
        Me.LebMySqlShopNmae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblServerStatus)
        Me.Panel1.Controls.Add(Me.LebMySqlShopNmae)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblUserName)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.lblDateTime)
        Me.Panel1.Controls.Add(Me.lblAutoBackup)
        Me.Panel1.Location = New System.Drawing.Point(3, 692)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1509, 37)
        Me.Panel1.TabIndex = 167
        '
        'lblServerStatus
        '
        Me.lblServerStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblServerStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblServerStatus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerStatus.ForeColor = System.Drawing.Color.White
        Me.lblServerStatus.Location = New System.Drawing.Point(149, 6)
        Me.lblServerStatus.Name = "lblServerStatus"
        Me.lblServerStatus.Size = New System.Drawing.Size(376, 26)
        Me.lblServerStatus.TabIndex = 167
        Me.lblServerStatus.Text = "ServerStatus"
        Me.lblServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimDayesLeft
        '
        '
        'LabDayesLeft
        '
        Me.LabDayesLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabDayesLeft.BackColor = System.Drawing.Color.Green
        Me.LabDayesLeft.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabDayesLeft.Location = New System.Drawing.Point(4, 170)
        Me.LabDayesLeft.Multiline = True
        Me.LabDayesLeft.Name = "LabDayesLeft"
        Me.LabDayesLeft.ReadOnly = True
        Me.LabDayesLeft.Size = New System.Drawing.Size(1292, 72)
        Me.LabDayesLeft.TabIndex = 169
        Me.LabDayesLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LabDayesLeft.Visible = False
        '
        'FrmBackgWork
        '
        '
        'BackWorkerApi
        '
        '
        'lblMinm
        '
        Me.lblMinm.AutoSize = True
        Me.lblMinm.BackColor = System.Drawing.Color.DarkGray
        Me.lblMinm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinm.ForeColor = System.Drawing.Color.Black
        Me.lblMinm.Location = New System.Drawing.Point(343, 2)
        Me.lblMinm.Name = "lblMinm"
        Me.lblMinm.Size = New System.Drawing.Size(15, 15)
        Me.lblMinm.TabIndex = 0
        Me.lblMinm.Text = "_"
        '
        'PanAdv
        '
        Me.PanAdv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanAdv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanAdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanAdv.Controls.Add(Me.lblMinm)
        Me.PanAdv.Location = New System.Drawing.Point(1, 126)
        Me.PanAdv.Name = "PanAdv"
        Me.PanAdv.Size = New System.Drawing.Size(367, 560)
        Me.PanAdv.TabIndex = 172
        '
        'BtnSalesDetails
        '
        Me.BtnSalesDetails.BackColor = System.Drawing.Color.Gray
        Me.BtnSalesDetails.Location = New System.Drawing.Point(1, 128)
        Me.BtnSalesDetails.Name = "BtnSalesDetails"
        Me.BtnSalesDetails.Size = New System.Drawing.Size(148, 36)
        Me.BtnSalesDetails.TabIndex = 172
        Me.BtnSalesDetails.Text = "التحليل المالي للنظام"
        Me.BtnSalesDetails.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.AutoSize = True
        Me.Panel10.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.lblProfit)
        Me.Panel10.Controls.Add(Me.lblCost)
        Me.Panel10.Controls.Add(Me.lblGoledWh18)
        Me.Panel10.Controls.Add(Me.lblGoledWh24)
        Me.Panel10.Controls.Add(Me.lblGoledWh22)
        Me.Panel10.Controls.Add(Me.lblGoledWh21)
        Me.Panel10.Controls.Add(Me.lblMakeCharge)
        Me.Panel10.Controls.Add(Me.lblBankAmount)
        Me.Panel10.Controls.Add(Me.lblCachAmount)
        Me.Panel10.Controls.Add(Me.lblTotalAmount)
        Me.Panel10.Controls.Add(Me.lblGold)
        Me.Panel10.Location = New System.Drawing.Point(759, 289)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(429, 283)
        Me.Panel10.TabIndex = 173
        '
        'lblProfit
        '
        Me.lblProfit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProfit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProfit.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblProfit.LinkColor = System.Drawing.Color.Black
        Me.lblProfit.Location = New System.Drawing.Point(18, 150)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(179, 36)
        Me.lblProfit.TabIndex = 10
        Me.lblProfit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCost
        '
        Me.lblCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCost.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCost.LinkColor = System.Drawing.Color.Black
        Me.lblCost.Location = New System.Drawing.Point(236, 150)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(179, 36)
        Me.lblCost.TabIndex = 9
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGoledWh18
        '
        Me.lblGoledWh18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoledWh18.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGoledWh18.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoledWh18.LinkColor = System.Drawing.Color.Black
        Me.lblGoledWh18.Location = New System.Drawing.Point(286, 194)
        Me.lblGoledWh18.Name = "lblGoledWh18"
        Me.lblGoledWh18.Size = New System.Drawing.Size(139, 36)
        Me.lblGoledWh18.TabIndex = 8
        Me.lblGoledWh18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGoledWh24
        '
        Me.lblGoledWh24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoledWh24.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGoledWh24.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoledWh24.LinkColor = System.Drawing.Color.Black
        Me.lblGoledWh24.Location = New System.Drawing.Point(1, 194)
        Me.lblGoledWh24.Name = "lblGoledWh24"
        Me.lblGoledWh24.Size = New System.Drawing.Size(139, 36)
        Me.lblGoledWh24.TabIndex = 7
        Me.lblGoledWh24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGoledWh22
        '
        Me.lblGoledWh22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoledWh22.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGoledWh22.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoledWh22.LinkColor = System.Drawing.Color.Black
        Me.lblGoledWh22.Location = New System.Drawing.Point(96, 194)
        Me.lblGoledWh22.Name = "lblGoledWh22"
        Me.lblGoledWh22.Size = New System.Drawing.Size(139, 36)
        Me.lblGoledWh22.TabIndex = 6
        Me.lblGoledWh22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGoledWh21
        '
        Me.lblGoledWh21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGoledWh21.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGoledWh21.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoledWh21.LinkColor = System.Drawing.Color.Black
        Me.lblGoledWh21.Location = New System.Drawing.Point(191, 194)
        Me.lblGoledWh21.Name = "lblGoledWh21"
        Me.lblGoledWh21.Size = New System.Drawing.Size(139, 36)
        Me.lblGoledWh21.TabIndex = 5
        Me.lblGoledWh21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMakeCharge
        '
        Me.lblMakeCharge.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMakeCharge.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMakeCharge.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblMakeCharge.LinkColor = System.Drawing.Color.Black
        Me.lblMakeCharge.Location = New System.Drawing.Point(1, 108)
        Me.lblMakeCharge.Name = "lblMakeCharge"
        Me.lblMakeCharge.Size = New System.Drawing.Size(413, 36)
        Me.lblMakeCharge.TabIndex = 4
        Me.lblMakeCharge.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBankAmount
        '
        Me.lblBankAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBankAmount.BackColor = System.Drawing.Color.Yellow
        Me.lblBankAmount.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBankAmount.LinkColor = System.Drawing.Color.Black
        Me.lblBankAmount.Location = New System.Drawing.Point(243, 72)
        Me.lblBankAmount.Name = "lblBankAmount"
        Me.lblBankAmount.Size = New System.Drawing.Size(179, 36)
        Me.lblBankAmount.TabIndex = 3
        Me.lblBankAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCachAmount
        '
        Me.lblCachAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCachAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCachAmount.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCachAmount.LinkColor = System.Drawing.Color.Black
        Me.lblCachAmount.Location = New System.Drawing.Point(3, 72)
        Me.lblCachAmount.Name = "lblCachAmount"
        Me.lblCachAmount.Size = New System.Drawing.Size(179, 36)
        Me.lblCachAmount.TabIndex = 2
        Me.lblCachAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAmount.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmount.LinkColor = System.Drawing.Color.Black
        Me.lblTotalAmount.Location = New System.Drawing.Point(-2, 34)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(416, 36)
        Me.lblTotalAmount.TabIndex = 1
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGold
        '
        Me.lblGold.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGold.BackColor = System.Drawing.Color.Wheat
        Me.lblGold.Font = New System.Drawing.Font("Calibri", 17.75!, System.Drawing.FontStyle.Bold)
        Me.lblGold.LinkColor = System.Drawing.Color.Black
        Me.lblGold.Location = New System.Drawing.Point(-1, -2)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(426, 36)
        Me.lblGold.TabIndex = 0
        Me.lblGold.TabStop = True
        Me.lblGold.Text = "مبيعات ذهب"
        Me.lblGold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel11
        '
        Me.Panel11.AutoSize = True
        Me.Panel11.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.lblAmountBuy)
        Me.Panel11.Controls.Add(Me.lblWeightBuy)
        Me.Panel11.Controls.Add(Me.LinkLabel3)
        Me.Panel11.Location = New System.Drawing.Point(462, 289)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(452, 235)
        Me.Panel11.TabIndex = 174
        '
        'lblAmountBuy
        '
        Me.lblAmountBuy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmountBuy.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAmountBuy.Font = New System.Drawing.Font("Calibri", 17.75!, System.Drawing.FontStyle.Bold)
        Me.lblAmountBuy.LinkColor = System.Drawing.Color.Black
        Me.lblAmountBuy.Location = New System.Drawing.Point(1, 72)
        Me.lblAmountBuy.Name = "lblAmountBuy"
        Me.lblAmountBuy.Size = New System.Drawing.Size(449, 36)
        Me.lblAmountBuy.TabIndex = 2
        Me.lblAmountBuy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWeightBuy
        '
        Me.lblWeightBuy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWeightBuy.BackColor = System.Drawing.Color.White
        Me.lblWeightBuy.Font = New System.Drawing.Font("Calibri", 17.75!, System.Drawing.FontStyle.Bold)
        Me.lblWeightBuy.LinkColor = System.Drawing.Color.Black
        Me.lblWeightBuy.Location = New System.Drawing.Point(-1, 34)
        Me.lblWeightBuy.Name = "lblWeightBuy"
        Me.lblWeightBuy.Size = New System.Drawing.Size(449, 36)
        Me.lblWeightBuy.TabIndex = 1
        Me.lblWeightBuy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.BackColor = System.Drawing.Color.Wheat
        Me.LinkLabel3.Font = New System.Drawing.Font("Calibri", 17.75!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.Location = New System.Drawing.Point(-1, -2)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(449, 36)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "مشتريات ذهب"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PicDateFrom
        '
        Me.PicDateFrom.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.PicDateFrom.Enabled = False
        Me.PicDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PicDateFrom.Location = New System.Drawing.Point(446, 418)
        Me.PicDateFrom.Name = "PicDateFrom"
        Me.PicDateFrom.Size = New System.Drawing.Size(120, 27)
        Me.PicDateFrom.TabIndex = 11
        '
        'PicDateTo
        '
        Me.PicDateTo.CalendarMonthBackground = System.Drawing.Color.Transparent
        Me.PicDateTo.Enabled = False
        Me.PicDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PicDateTo.Location = New System.Drawing.Point(572, 419)
        Me.PicDateTo.Name = "PicDateTo"
        Me.PicDateTo.Size = New System.Drawing.Size(120, 27)
        Me.PicDateTo.TabIndex = 11
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.BackColor = System.Drawing.Color.Black
        Me.lblDateFrom.Location = New System.Drawing.Point(461, 396)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(93, 19)
        Me.lblDateFrom.TabIndex = 175
        Me.lblDateFrom.Text = "lblDateFrom"
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.BackColor = System.Drawing.Color.Black
        Me.lblDateTo.Location = New System.Drawing.Point(587, 396)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(74, 19)
        Me.lblDateTo.TabIndex = 176
        Me.lblDateTo.Text = "lblDateTo"
        '
        'picServerStatus
        '
        Me.picServerStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picServerStatus.Location = New System.Drawing.Point(4, 644)
        Me.picServerStatus.Name = "picServerStatus"
        Me.picServerStatus.Size = New System.Drawing.Size(45, 46)
        Me.picServerStatus.TabIndex = 177
        Me.picServerStatus.TabStop = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 170)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(1291, 471)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 13
        Me.LogoPictureBox.TabStop = False
        '
        'WebViewLinek
        '
        Me.WebViewLinek.AllowExternalDrop = True
        Me.WebViewLinek.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WebViewLinek.CreationProperties = Nothing
        Me.WebViewLinek.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebViewLinek.ForeColor = System.Drawing.Color.Black
        Me.WebViewLinek.Location = New System.Drawing.Point(2, 130)
        Me.WebViewLinek.Name = "WebViewLinek"
        Me.WebViewLinek.Size = New System.Drawing.Size(313, 33)
        Me.WebViewLinek.TabIndex = 178
        Me.WebViewLinek.Visible = False
        Me.WebViewLinek.ZoomFactor = 1.0R
        '
        'BtnWebView
        '
        Me.BtnWebView.BackColor = System.Drawing.Color.Transparent
        Me.BtnWebView.Location = New System.Drawing.Point(180, 266)
        Me.BtnWebView.Name = "BtnWebView"
        Me.BtnWebView.Size = New System.Drawing.Size(26, 29)
        Me.BtnWebView.TabIndex = 179
        Me.BtnWebView.UseVisualStyleBackColor = False
        Me.BtnWebView.Visible = False
        '
        'المحذوفاتذهبفضهالماسToolStripMenuItem
        '
        Me.المحذوفاتذهبفضهالماسToolStripMenuItem.Name = "المحذوفاتذهبفضهالماسToolStripMenuItem"
        Me.المحذوفاتذهبفضهالماسToolStripMenuItem.Size = New System.Drawing.Size(322, 30)
        Me.المحذوفاتذهبفضهالماسToolStripMenuItem.Text = "المحذوفات ذهب / فضه /الماس"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1510, 733)
        Me.Controls.Add(Me.picServerStatus)
        Me.Controls.Add(Me.BtnWebView)
        Me.Controls.Add(Me.BtnSalesDetails)
        Me.Controls.Add(Me.LabDayesLeft)
        Me.Controls.Add(Me.LepOpencount)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.SET_INVARCHR142TextBox)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.pnlPrice)
        Me.Controls.Add(Me.lblTechSupport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.lblDateTo)
        Me.Controls.Add(Me.lblDateFrom)
        Me.Controls.Add(Me.PicDateTo)
        Me.Controls.Add(Me.PicDateFrom)
        Me.Controls.Add(Me.WebViewLinek)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMenuMain
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Golden SAP"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msMenuMain.ResumeLayout(False)
        Me.msMenuMain.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlPrice.ResumeLayout(False)
        Me.pnlPrice.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlPriceOunce.ResumeLayout(False)
        Me.pnlPriceOunce.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlPrice925.ResumeLayout(False)
        Me.pnlPrice925.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.pnlPrice24.ResumeLayout(False)
        Me.pnlPrice24.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.pnlPrice22.ResumeLayout(False)
        Me.pnlPrice22.PerformLayout()
        Me.pnlPrice21.ResumeLayout(False)
        Me.pnlPrice21.PerformLayout()
        Me.pnlPrice18.ResumeLayout(False)
        Me.pnlPrice18.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanAdv.ResumeLayout(False)
        Me.PanAdv.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.picServerStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebViewLinek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSell As System.Windows.Forms.Button
    Friend WithEvents msMenuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuUserManagement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsUserManagementUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettingsMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportSell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnBarCode As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents btnBulkSell As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBuy As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnExpense As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnKarat As System.Windows.Forms.Button
    Friend WithEvents tsSettingsMainCompanyData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsMainCountryOfOrigin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsMainGramPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportSellView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportSellDetailed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItemsAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactionsSell As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsSellGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactionsBuy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsBuyGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsGoldVoucherReceive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsPaymentVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportBuy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportBuyDetailed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportBuyShort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents tsReportSellViewGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellDetailedGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellDetailedDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellDetailedSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsSellDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsSellSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportBuyView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportSellShort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellShortGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellShortSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellShortDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettingsLanguage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsLanguageArabic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsLanguageEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsUserManagementCashier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItemByCarat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemByCaratGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemByCaratSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlPrice As System.Windows.Forms.Panel
    Friend WithEvents pnlPrice24 As System.Windows.Forms.Panel
    Friend WithEvents lbl24 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl24K As System.Windows.Forms.Label
    Friend WithEvents pnlPrice22 As System.Windows.Forms.Panel
    Friend WithEvents lbl22 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl22K As System.Windows.Forms.Label
    Friend WithEvents pnlPrice21 As System.Windows.Forms.Panel
    Friend WithEvents lbl21 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl21K As System.Windows.Forms.Label
    Friend WithEvents pnlPrice18 As System.Windows.Forms.Panel
    Friend WithEvents lbl18 As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl18K As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents pnlPrice925 As System.Windows.Forms.Panel
    Friend WithEvents lblSilver925 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSilver925K As System.Windows.Forms.Label
    Friend WithEvents mnuReportProfit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportProfitGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportProfitSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportProfitDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItemsSold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReportItemsAvailable As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAllGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAllSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAllDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsSoldGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsSoldSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsSoldDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAvailableGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAvailableSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAvailableDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsProgrammer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR149TextBox As System.Windows.Forms.TextBox
    Friend WithEvents tsReportBuyViewGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyViewDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewAuction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsSellAuction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellDetailedAuction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellShortAuction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyDetailedGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyDetailedDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyDetailedAuction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellDetailedAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellShortAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyShortGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyShortDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyDetailedSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsSellAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyViewAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsBuyAccessories As ToolStripMenuItem
    Friend WithEvents tsReportBuyDetailedAccessories As ToolStripMenuItem
    Friend WithEvents tsReportBuyShortAccessories As ToolStripMenuItem
    Friend WithEvents tsReportItemsAllAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsAvailableAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportItemsSoldAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsBuySilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsTransactionsBuyDiamond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyViewSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportBuyShortSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportExpenses As ToolStripMenuItem
    Friend WithEvents mnuSettingsDefinition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionStoneName As ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionDiamondCut As ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionAddItemCategory As ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionBrands As ToolStripMenuItem
    Friend WithEvents SET_INVARCHR154TextBox As System.Windows.Forms.TextBox
    Friend WithEvents mnuReportSellViewDeleted As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewGoldDeleted As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportSellViewSilverDeleted As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportCivilIDPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SET_INVARCHR142TextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrencySale As System.Windows.Forms.Label
    Friend WithEvents lblTechSupportEnd As System.Windows.Forms.Label
    Friend WithEvents dtEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents mnuLicense As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLicenseGet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlPriceOunce As System.Windows.Forms.Panel
    Friend WithEvents lblOunce As System.Windows.Forms.LinkLabel
    Friend WithEvents LIB_OUNCE As System.Windows.Forms.Label
    Friend WithEvents lblAutoBackup As Label
    Friend WithEvents tsReportProfitAccessories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsReportProfitGoldPerPurchaseCost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactionsPayInstallment As ToolStripMenuItem
    Friend WithEvents tsTransactionsPayInstallmentGoldSilver As ToolStripMenuItem
    Friend WithEvents tsTransactionsPayInstallmentDiamond As ToolStripMenuItem
    Friend WithEvents tsTransactionsPayInstallmentAccessories As ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionStoneColor As ToolStripMenuItem
    Friend WithEvents tsSettingsDefinitionItemName As ToolStripMenuItem
    Friend WithEvents lblTechSupport As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblOunceBUY As System.Windows.Forms.LinkLabel
    Friend WithEvents LIB_OUNCEBUY As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblSilver925BUY As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSilver925KBUY As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbl24BUY As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl24KBUY As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbl22BUY As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl22KBUY As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lbl21BUY As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl21KBUY As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lbl18BUY As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl18KBUY As System.Windows.Forms.Label
    Friend WithEvents lblCurrencyBuy As System.Windows.Forms.Label
    Friend WithEvents wholesaleReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wholesaleInvView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LepOpencount As System.Windows.Forms.Label
    Friend WithEvents LebMySqlShopNmae As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ExpReportSellView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpReportSellDetailed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpensesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimDayesLeft As System.Windows.Forms.Timer
    Friend WithEvents LabDayesLeft As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblBuyOunceUsd As System.Windows.Forms.LinkLabel
    Friend WithEvents LabOunceBuyUsd As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lblSellOunceUsd As System.Windows.Forms.LinkLabel
    Friend WithEvents LabSellOunceUsd As System.Windows.Forms.Label
    Friend WithEvents SelectColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmBackgWork As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripBondCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowDetelsCash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowDetelsGold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowCashComp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripBondShowCashCompPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldVoucherReceiveCreateNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoldVoucherReceiveEdite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents انشاءجديدToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حزفتعديلسابقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents BackWorkerApi As System.ComponentModel.BackgroundWorker
    Friend WithEvents PnlAdv As Panel
    Friend WithEvents lblMinm As Label
    Friend WithEvents PanAdv As Panel
    Friend WithEvents BtnSalesDetails As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lblCachAmount As LinkLabel
    Friend WithEvents lblTotalAmount As LinkLabel
    Friend WithEvents lblGold As LinkLabel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblAmountBuy As LinkLabel
    Friend WithEvents lblWeightBuy As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents PicDateFrom As DateTimePicker
    Friend WithEvents PicDateTo As DateTimePicker
    Friend WithEvents lblBankAmount As LinkLabel
    Friend WithEvents lblDateFrom As Label
    Friend WithEvents lblDateTo As Label
    Friend WithEvents lblGoledWh21 As LinkLabel
    Friend WithEvents lblMakeCharge As LinkLabel
    Friend WithEvents lblGoledWh22 As LinkLabel
    Friend WithEvents lblGoledWh18 As LinkLabel
    Friend WithEvents lblGoledWh24 As LinkLabel
    Friend WithEvents lblProfit As LinkLabel
    Friend WithEvents lblCost As LinkLabel
    Friend WithEvents lblServerStatus As Label
    Friend WithEvents picServerStatus As PictureBox
    Friend WithEvents WebViewLinek As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BtnWebView As Button
    Friend WithEvents TimLodPrice As Timer
    Friend WithEvents tsGoldVoucher As ToolStripMenuItem
    Friend WithEvents GoldVoucherCreateNew As ToolStripMenuItem
    Friend WithEvents GoldVoucherEdite As ToolStripMenuItem
    Friend WithEvents tsSettingsMainCompany As ToolStripMenuItem
    Friend WithEvents tsSettingsMainAddCompany As ToolStripMenuItem
    Friend WithEvents tsSettingsMainAddBranch As ToolStripMenuItem
    Friend WithEvents اعداداتالتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents اعداداتالواتسابToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents سندقبضذهبToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents مراجعةالسنداتToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents بحثمتعددتفصيليToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents المحذوفاتذهبفضهالماسToolStripMenuItem As ToolStripMenuItem
End Class
