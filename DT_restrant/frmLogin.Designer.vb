<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.User_idTextBox = New System.Windows.Forms.TextBox()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.User_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.userTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.pbLock = New System.Windows.Forms.PictureBox()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.LicensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LicensTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.licensTableAdapter()
        Me.LicensDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Inv_startBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_startTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.inv_startTableAdapter()
        Me.Inv_startDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_startTextBox = New System.Windows.Forms.TextBox()
        Me.rbtnEn = New System.Windows.Forms.RadioButton()
        Me.rbtnAr = New System.Windows.Forms.RadioButton()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.SET_INVARCHR149TextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BackWorker = New System.ComponentModel.BackgroundWorker()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LicensDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_startBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_startDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(367, 85)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(124, 19)
        Me.lblPassword.TabIndex = 20
        Me.lblPassword.Text = "كلمة المرور"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(367, 38)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(124, 19)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.Text = "اسم المستخدم"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(171, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPassword.Size = New System.Drawing.Size(194, 27)
        Me.txtPassword.TabIndex = 17
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Location = New System.Drawing.Point(171, 36)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUserName.Size = New System.Drawing.Size(194, 27)
        Me.txtUserName.TabIndex = 16
        '
        'User_idTextBox
        '
        Me.User_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.User_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "user_id", True))
        Me.User_idTextBox.Location = New System.Drawing.Point(-154, 81)
        Me.User_idTextBox.Name = "User_idTextBox"
        Me.User_idTextBox.Size = New System.Drawing.Size(22, 27)
        Me.User_idTextBox.TabIndex = 22
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_nameTextBox
        '
        Me.User_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.User_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "user_name", True))
        Me.User_nameTextBox.Location = New System.Drawing.Point(-154, 104)
        Me.User_nameTextBox.Name = "User_nameTextBox"
        Me.User_nameTextBox.Size = New System.Drawing.Size(22, 27)
        Me.User_nameTextBox.TabIndex = 24
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(-154, 127)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(22, 27)
        Me.PasswordTextBox.TabIndex = 26
        '
        'UserDataGridView
        '
        Me.UserDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserDataGridView.AutoGenerateColumns = False
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.UserDataGridView.DataSource = Me.UserBindingSource
        Me.UserDataGridView.Location = New System.Drawing.Point(-60, 26)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.Size = New System.Drawing.Size(22, 45)
        Me.UserDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "user_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "user_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "user_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "user_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.userTableAdapter = Me.UserTableAdapter
        '
        'pbLock
        '
        Me.pbLock.BackColor = System.Drawing.Color.Transparent
        Me.pbLock.BackgroundImage = Global.DT_restrant.My.Resources.Resources.lucchetto
        Me.pbLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLock.Location = New System.Drawing.Point(3, 2)
        Me.pbLock.Name = "pbLock"
        Me.pbLock.Size = New System.Drawing.Size(166, 161)
        Me.pbLock.TabIndex = 31
        Me.pbLock.TabStop = False
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkShowPassword.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPassword.ForeColor = System.Drawing.Color.Red
        Me.chkShowPassword.Location = New System.Drawing.Point(174, 89)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(12, 11)
        Me.chkShowPassword.TabIndex = 32
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'LicensBindingSource
        '
        Me.LicensBindingSource.DataMember = "licens"
        Me.LicensBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'LicensTableAdapter
        '
        Me.LicensTableAdapter.ClearBeforeFill = True
        '
        'LicensDataGridView
        '
        Me.LicensDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LicensDataGridView.AutoGenerateColumns = False
        Me.LicensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LicensDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LicensDataGridView.DataSource = Me.LicensBindingSource
        Me.LicensDataGridView.Location = New System.Drawing.Point(-32, 28)
        Me.LicensDataGridView.Name = "LicensDataGridView"
        Me.LicensDataGridView.Size = New System.Drawing.Size(22, 43)
        Me.LicensDataGridView.TabIndex = 55
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LicensBindingSource, "date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(-112, 33)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(22, 27)
        Me.DateDateTimePicker.TabIndex = 57
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(-112, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(22, 27)
        Me.DateTimePicker1.TabIndex = 58
        '
        'Inv_startBindingSource
        '
        Me.Inv_startBindingSource.DataMember = "inv_start"
        Me.Inv_startBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Inv_startTableAdapter
        '
        Me.Inv_startTableAdapter.ClearBeforeFill = True
        '
        'Inv_startDataGridView
        '
        Me.Inv_startDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_startDataGridView.AutoGenerateColumns = False
        Me.Inv_startDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inv_startDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Inv_startDataGridView.DataSource = Me.Inv_startBindingSource
        Me.Inv_startDataGridView.Location = New System.Drawing.Point(-88, 26)
        Me.Inv_startDataGridView.Name = "Inv_startDataGridView"
        Me.Inv_startDataGridView.Size = New System.Drawing.Size(22, 45)
        Me.Inv_startDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "inv_start"
        Me.DataGridViewTextBoxColumn7.HeaderText = "inv_start"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_start"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_start"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Inv_startTextBox
        '
        Me.Inv_startTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_startTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_startBindingSource, "inv_start", True))
        Me.Inv_startTextBox.Location = New System.Drawing.Point(-154, 58)
        Me.Inv_startTextBox.Name = "Inv_startTextBox"
        Me.Inv_startTextBox.Size = New System.Drawing.Size(22, 27)
        Me.Inv_startTextBox.TabIndex = 60
        '
        'rbtnEn
        '
        Me.rbtnEn.AutoSize = True
        Me.rbtnEn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnEn.Location = New System.Drawing.Point(174, 167)
        Me.rbtnEn.Name = "rbtnEn"
        Me.rbtnEn.Size = New System.Drawing.Size(75, 23)
        Me.rbtnEn.TabIndex = 61
        Me.rbtnEn.TabStop = True
        Me.rbtnEn.Text = "English"
        Me.rbtnEn.UseVisualStyleBackColor = False
        '
        'rbtnAr
        '
        Me.rbtnAr.AutoSize = True
        Me.rbtnAr.BackColor = System.Drawing.Color.Transparent
        Me.rbtnAr.Location = New System.Drawing.Point(311, 167)
        Me.rbtnAr.Name = "rbtnAr"
        Me.rbtnAr.Size = New System.Drawing.Size(54, 23)
        Me.rbtnAr.TabIndex = 62
        Me.rbtnAr.TabStop = True
        Me.rbtnAr.Text = "عربي"
        Me.rbtnAr.UseVisualStyleBackColor = False
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'SET_INVARCHR149TextBox
        '
        Me.SET_INVARCHR149TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR149TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR149", True))
        Me.SET_INVARCHR149TextBox.Location = New System.Drawing.Point(-154, 35)
        Me.SET_INVARCHR149TextBox.Name = "SET_INVARCHR149TextBox"
        Me.SET_INVARCHR149TextBox.Size = New System.Drawing.Size(22, 27)
        Me.SET_INVARCHR149TextBox.TabIndex = 64
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SET_INVARCHR149TextBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Inv_startTextBox)
        Me.Panel1.Controls.Add(Me.DateDateTimePicker)
        Me.Panel1.Controls.Add(Me.Inv_startDataGridView)
        Me.Panel1.Controls.Add(Me.User_idTextBox)
        Me.Panel1.Controls.Add(Me.User_nameTextBox)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(Me.LicensDataGridView)
        Me.Panel1.Controls.Add(Me.UserDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(1220, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(42, 45)
        Me.Panel1.TabIndex = 65
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(7, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 29)
        Me.btnClose.TabIndex = 66
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'BackWorker
        '
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 19.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(171, 117)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(194, 46)
        Me.btnLogin.TabIndex = 67
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = Global.DT_restrant.My.Resources.Resources.SAIB_LOGO_last
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(500, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbtnAr)
        Me.Controls.Add(Me.rbtnEn)
        Me.Controls.Add(Me.chkShowPassword)
        Me.Controls.Add(Me.pbLock)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Crimson
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LicensDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_startBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_startDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.userTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents User_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pbLock As System.Windows.Forms.PictureBox
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents LicensBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LicensTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.licensTableAdapter
    Friend WithEvents LicensDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Inv_startBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_startTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.inv_startTableAdapter
    Friend WithEvents Inv_startDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inv_startTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rbtnEn As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAr As System.Windows.Forms.RadioButton
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR149TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents BackWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnLogin As Button
End Class
