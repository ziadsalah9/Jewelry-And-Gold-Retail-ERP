<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldBuyPerson
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
        Dim FotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoldBuyPerson))
        Me.Bay_mazanLabel = New System.Windows.Forms.Label()
        Me.Bay_total_priceLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.B_gold_idTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_valTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_mazanTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_gram_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_total_priceTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerCAIVELidTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerCAIVELidTextBox1 = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Loc_idTextBox = New System.Windows.Forms.TextBox()
        Me.Loc_nameTextBox = New System.Windows.Forms.TextBox()
        Me.btnPayPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtGramPrice = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Inv_idTextBox = New System.Windows.Forms.TextBox()
        Me.Bay_gold_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.AddTextBox = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.INV_ActvTextBox = New System.Windows.Forms.TextBox()
        Me.Castomer_idTextBox = New System.Windows.Forms.TextBox()
        Me.Item_DesTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR147TextBox = New System.Windows.Forms.TextBox()
        Me.TIME_INVDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.LabItem_Des = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.cmbCashier = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.TeBoxItem_Des = New System.Windows.Forms.ComboBox()
        Me.txtQunt = New System.Windows.Forms.TextBox()
        Me.lblQunt = New System.Windows.Forms.Label()
        Me.TXTGoCaret999 = New System.Windows.Forms.TextBox()
        Me.lblNetWeight = New System.Windows.Forms.Label()
        Me.ComBxGoCaret999 = New System.Windows.Forms.ComboBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.chkAddToItem = New System.Windows.Forms.CheckBox()
        Me.LblAddToItem = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colItem_Des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbay_val = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbay_mazan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldCaret999 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldWeight999 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colbay_gram_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQunt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddToItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colcastomer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCashier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colB_gold_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbKarat = New System.Windows.Forms.ComboBox()
        Me.lblNetCaret = New System.Windows.Forms.Label()
        Me.Bay_gram_priceLabel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        FotoLabel = New System.Windows.Forms.Label()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(-60, -43)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(42, 19)
        FotoLabel.TabIndex = 134
        FotoLabel.Text = "foto:"
        '
        'Bay_mazanLabel
        '
        Me.Bay_mazanLabel.ForeColor = System.Drawing.Color.Black
        Me.Bay_mazanLabel.Location = New System.Drawing.Point(751, 328)
        Me.Bay_mazanLabel.Name = "Bay_mazanLabel"
        Me.Bay_mazanLabel.Size = New System.Drawing.Size(85, 20)
        Me.Bay_mazanLabel.TabIndex = 7
        Me.Bay_mazanLabel.Text = "الوزن"
        Me.Bay_mazanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bay_total_priceLabel
        '
        Me.Bay_total_priceLabel.ForeColor = System.Drawing.Color.Black
        Me.Bay_total_priceLabel.Location = New System.Drawing.Point(826, 563)
        Me.Bay_total_priceLabel.Name = "Bay_total_priceLabel"
        Me.Bay_total_priceLabel.Size = New System.Drawing.Size(117, 25)
        Me.Bay_total_priceLabel.TabIndex = 11
        Me.Bay_total_priceLabel.Text = "إجمالي سعر الشراء"
        Me.Bay_total_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(838, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "العيار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_gold_idTextBox
        '
        Me.B_gold_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_gold_idTextBox.Location = New System.Drawing.Point(-111, 37)
        Me.B_gold_idTextBox.Name = "B_gold_idTextBox"
        Me.B_gold_idTextBox.Size = New System.Drawing.Size(42, 27)
        Me.B_gold_idTextBox.TabIndex = 2
        '
        'Bay_valTextBox
        '
        Me.Bay_valTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_valTextBox.Location = New System.Drawing.Point(-111, 226)
        Me.Bay_valTextBox.Name = "Bay_valTextBox"
        Me.Bay_valTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Bay_valTextBox.TabIndex = 6
        '
        'Bay_mazanTextBox
        '
        Me.Bay_mazanTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_mazanTextBox.Location = New System.Drawing.Point(-111, 253)
        Me.Bay_mazanTextBox.Name = "Bay_mazanTextBox"
        Me.Bay_mazanTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Bay_mazanTextBox.TabIndex = 8
        '
        'Bay_gram_priceTextBox
        '
        Me.Bay_gram_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_gram_priceTextBox.Location = New System.Drawing.Point(-46, 37)
        Me.Bay_gram_priceTextBox.Name = "Bay_gram_priceTextBox"
        Me.Bay_gram_priceTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Bay_gram_priceTextBox.TabIndex = 10
        '
        'Bay_total_priceTextBox
        '
        Me.Bay_total_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_total_priceTextBox.Location = New System.Drawing.Point(-46, 145)
        Me.Bay_total_priceTextBox.Name = "Bay_total_priceTextBox"
        Me.Bay_total_priceTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Bay_total_priceTextBox.TabIndex = 12
        '
        'CastomerIDTextBox
        '
        Me.CastomerIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerIDTextBox.Location = New System.Drawing.Point(-111, 118)
        Me.CastomerIDTextBox.Name = "CastomerIDTextBox"
        Me.CastomerIDTextBox.Size = New System.Drawing.Size(42, 27)
        Me.CastomerIDTextBox.TabIndex = 15
        '
        'CastomerCAIVELidTextBox
        '
        Me.CastomerCAIVELidTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerCAIVELidTextBox.Location = New System.Drawing.Point(-111, 199)
        Me.CastomerCAIVELidTextBox.Name = "CastomerCAIVELidTextBox"
        Me.CastomerCAIVELidTextBox.Size = New System.Drawing.Size(42, 27)
        Me.CastomerCAIVELidTextBox.TabIndex = 17
        '
        'CastomerCAIVELidTextBox1
        '
        Me.CastomerCAIVELidTextBox1.Location = New System.Drawing.Point(85, -64)
        Me.CastomerCAIVELidTextBox1.Name = "CastomerCAIVELidTextBox1"
        Me.CastomerCAIVELidTextBox1.Size = New System.Drawing.Size(58, 27)
        Me.CastomerCAIVELidTextBox1.TabIndex = 151
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.Location = New System.Drawing.Point(-23, -43)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(10, 10)
        Me.FotoPictureBox.TabIndex = 135
        Me.FotoPictureBox.TabStop = False
        '
        'Loc_idTextBox
        '
        Me.Loc_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Loc_idTextBox.Location = New System.Drawing.Point(-111, 64)
        Me.Loc_idTextBox.Name = "Loc_idTextBox"
        Me.Loc_idTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Loc_idTextBox.TabIndex = 137
        '
        'Loc_nameTextBox
        '
        Me.Loc_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Loc_nameTextBox.Location = New System.Drawing.Point(-111, 91)
        Me.Loc_nameTextBox.Name = "Loc_nameTextBox"
        Me.Loc_nameTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Loc_nameTextBox.TabIndex = 139
        '
        'btnPayPrint
        '
        Me.btnPayPrint.BackColor = System.Drawing.Color.Green
        Me.btnPayPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPayPrint.Image = Global.DT_restrant.My.Resources.Resources.MoneyBag
        Me.btnPayPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayPrint.Location = New System.Drawing.Point(10, 270)
        Me.btnPayPrint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPayPrint.Name = "btnPayPrint"
        Me.btnPayPrint.Size = New System.Drawing.Size(121, 51)
        Me.btnPayPrint.TabIndex = 9
        Me.btnPayPrint.Text = "دفع طباعة"
        Me.btnPayPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(137, 270)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 51)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(751, 350)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWeight.Size = New System.Drawing.Size(85, 27)
        Me.txtWeight.TabIndex = 2
        Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGramPrice
        '
        Me.txtGramPrice.Location = New System.Drawing.Point(350, 350)
        Me.txtGramPrice.Name = "txtGramPrice"
        Me.txtGramPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGramPrice.Size = New System.Drawing.Size(132, 27)
        Me.txtGramPrice.TabIndex = 5
        Me.txtGramPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(705, 563)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox3.Size = New System.Drawing.Size(121, 27)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Inv_idTextBox
        '
        Me.Inv_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_idTextBox.Location = New System.Drawing.Point(-46, 172)
        Me.Inv_idTextBox.Name = "Inv_idTextBox"
        Me.Inv_idTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Inv_idTextBox.TabIndex = 150
        '
        'Bay_gold_idTextBox1
        '
        Me.Bay_gold_idTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bay_gold_idTextBox1.Location = New System.Drawing.Point(-111, 172)
        Me.Bay_gold_idTextBox1.Name = "Bay_gold_idTextBox1"
        Me.Bay_gold_idTextBox1.Size = New System.Drawing.Size(42, 27)
        Me.Bay_gold_idTextBox1.TabIndex = 152
        '
        'AddTextBox
        '
        Me.AddTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddTextBox.Location = New System.Drawing.Point(-111, 145)
        Me.AddTextBox.Name = "AddTextBox"
        Me.AddTextBox.Size = New System.Drawing.Size(42, 27)
        Me.AddTextBox.TabIndex = 153
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(205, 350)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPrice.Size = New System.Drawing.Size(143, 27)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.INV_ActvTextBox)
        Me.pnl.Controls.Add(Me.Castomer_idTextBox)
        Me.pnl.Controls.Add(Me.Item_DesTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR147TextBox)
        Me.pnl.Controls.Add(Me.TIME_INVDateTimePicker)
        Me.pnl.Controls.Add(Me.B_gold_idTextBox)
        Me.pnl.Controls.Add(Me.Inv_idTextBox)
        Me.pnl.Controls.Add(Me.CastomerCAIVELidTextBox1)
        Me.pnl.Controls.Add(Me.AddTextBox)
        Me.pnl.Controls.Add(Me.Bay_gold_idTextBox1)
        Me.pnl.Controls.Add(Me.CastomerCAIVELidTextBox)
        Me.pnl.Controls.Add(Me.Bay_valTextBox)
        Me.pnl.Controls.Add(Me.CastomerIDTextBox)
        Me.pnl.Controls.Add(Me.Bay_mazanTextBox)
        Me.pnl.Controls.Add(Me.FotoPictureBox)
        Me.pnl.Controls.Add(FotoLabel)
        Me.pnl.Controls.Add(Me.Loc_nameTextBox)
        Me.pnl.Controls.Add(Me.Bay_total_priceTextBox)
        Me.pnl.Controls.Add(Me.Loc_idTextBox)
        Me.pnl.Controls.Add(Me.Bay_gram_priceTextBox)
        Me.pnl.Location = New System.Drawing.Point(1061, 31)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(39, 32)
        Me.pnl.TabIndex = 162
        '
        'INV_ActvTextBox
        '
        Me.INV_ActvTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.INV_ActvTextBox.Location = New System.Drawing.Point(-46, 199)
        Me.INV_ActvTextBox.Name = "INV_ActvTextBox"
        Me.INV_ActvTextBox.Size = New System.Drawing.Size(42, 27)
        Me.INV_ActvTextBox.TabIndex = 171
        '
        'Castomer_idTextBox
        '
        Me.Castomer_idTextBox.Location = New System.Drawing.Point(-46, 226)
        Me.Castomer_idTextBox.Name = "Castomer_idTextBox"
        Me.Castomer_idTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Castomer_idTextBox.TabIndex = 170
        '
        'Item_DesTextBox
        '
        Me.Item_DesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_DesTextBox.Location = New System.Drawing.Point(-46, 118)
        Me.Item_DesTextBox.Name = "Item_DesTextBox"
        Me.Item_DesTextBox.Size = New System.Drawing.Size(42, 27)
        Me.Item_DesTextBox.TabIndex = 165
        '
        'SET_INVARCHR147TextBox
        '
        Me.SET_INVARCHR147TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR147TextBox.Location = New System.Drawing.Point(-46, 91)
        Me.SET_INVARCHR147TextBox.Name = "SET_INVARCHR147TextBox"
        Me.SET_INVARCHR147TextBox.Size = New System.Drawing.Size(42, 27)
        Me.SET_INVARCHR147TextBox.TabIndex = 164
        '
        'TIME_INVDateTimePicker
        '
        Me.TIME_INVDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TIME_INVDateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.TIME_INVDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TIME_INVDateTimePicker.Location = New System.Drawing.Point(-46, 64)
        Me.TIME_INVDateTimePicker.Name = "TIME_INVDateTimePicker"
        Me.TIME_INVDateTimePicker.Size = New System.Drawing.Size(42, 27)
        Me.TIME_INVDateTimePicker.TabIndex = 168
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.CustomFormat = "dd/MM/yyyy"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(253, 294)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(172, 27)
        Me.dtDate.TabIndex = 169
        '
        'LabItem_Des
        '
        Me.LabItem_Des.ForeColor = System.Drawing.Color.Black
        Me.LabItem_Des.Location = New System.Drawing.Point(431, 270)
        Me.LabItem_Des.Name = "LabItem_Des"
        Me.LabItem_Des.Size = New System.Drawing.Size(348, 19)
        Me.LabItem_Des.TabIndex = 166
        Me.LabItem_Des.Text = "الوصف"
        Me.LabItem_Des.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashier
        '
        Me.lblCashier.ForeColor = System.Drawing.Color.Black
        Me.lblCashier.Location = New System.Drawing.Point(780, 270)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(171, 25)
        Me.lblCashier.TabIndex = 8
        Me.lblCashier.Text = "كاشير"
        Me.lblCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCashier
        '
        Me.cmbCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCashier.FormattingEnabled = True
        Me.cmbCashier.Location = New System.Drawing.Point(780, 294)
        Me.cmbCashier.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCashier.Name = "cmbCashier"
        Me.cmbCashier.Size = New System.Drawing.Size(174, 27)
        Me.cmbCashier.TabIndex = 9
        '
        'lblDate
        '
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(249, 270)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(172, 21)
        Me.lblDate.TabIndex = 170
        Me.lblDate.Text = "التاريخ"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TeBoxItem_Des
        '
        Me.TeBoxItem_Des.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TeBoxItem_Des.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TeBoxItem_Des.FormattingEnabled = True
        Me.TeBoxItem_Des.Location = New System.Drawing.Point(431, 294)
        Me.TeBoxItem_Des.Name = "TeBoxItem_Des"
        Me.TeBoxItem_Des.Size = New System.Drawing.Size(348, 27)
        Me.TeBoxItem_Des.TabIndex = 0
        '
        'txtQunt
        '
        Me.txtQunt.Location = New System.Drawing.Point(484, 350)
        Me.txtQunt.Name = "txtQunt"
        Me.txtQunt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtQunt.Size = New System.Drawing.Size(67, 27)
        Me.txtQunt.TabIndex = 3
        Me.txtQunt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQunt
        '
        Me.lblQunt.ForeColor = System.Drawing.Color.Black
        Me.lblQunt.Location = New System.Drawing.Point(484, 328)
        Me.lblQunt.Name = "lblQunt"
        Me.lblQunt.Size = New System.Drawing.Size(67, 20)
        Me.lblQunt.TabIndex = 173
        Me.lblQunt.Text = "العدد"
        Me.lblQunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTGoCaret999
        '
        Me.TXTGoCaret999.Location = New System.Drawing.Point(553, 350)
        Me.TXTGoCaret999.Name = "TXTGoCaret999"
        Me.TXTGoCaret999.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXTGoCaret999.Size = New System.Drawing.Size(97, 27)
        Me.TXTGoCaret999.TabIndex = 176
        Me.TXTGoCaret999.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNetWeight
        '
        Me.lblNetWeight.ForeColor = System.Drawing.Color.Black
        Me.lblNetWeight.Location = New System.Drawing.Point(553, 328)
        Me.lblNetWeight.Name = "lblNetWeight"
        Me.lblNetWeight.Size = New System.Drawing.Size(97, 20)
        Me.lblNetWeight.TabIndex = 177
        Me.lblNetWeight.Text = "الوزن الصافي"
        Me.lblNetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComBxGoCaret999
        '
        Me.ComBxGoCaret999.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBxGoCaret999.FormattingEnabled = True
        Me.ComBxGoCaret999.Location = New System.Drawing.Point(652, 350)
        Me.ComBxGoCaret999.Name = "ComBxGoCaret999"
        Me.ComBxGoCaret999.Size = New System.Drawing.Size(97, 27)
        Me.ComBxGoCaret999.TabIndex = 179
        '
        'chkAddToItem
        '
        Me.chkAddToItem.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAddToItem.Location = New System.Drawing.Point(8, 350)
        Me.chkAddToItem.Name = "chkAddToItem"
        Me.chkAddToItem.Size = New System.Drawing.Size(179, 27)
        Me.chkAddToItem.TabIndex = 181
        Me.chkAddToItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAddToItem.UseVisualStyleBackColor = True
        '
        'LblAddToItem
        '
        Me.LblAddToItem.ForeColor = System.Drawing.Color.Black
        Me.LblAddToItem.Location = New System.Drawing.Point(8, 326)
        Me.LblAddToItem.Name = "LblAddToItem"
        Me.LblAddToItem.Size = New System.Drawing.Size(179, 19)
        Me.LblAddToItem.TabIndex = 182
        Me.LblAddToItem.Text = "اضف الي اصناف الذهب"
        Me.LblAddToItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNote
        '
        Me.lblNote.ForeColor = System.Drawing.Color.Black
        Me.lblNote.Location = New System.Drawing.Point(633, 563)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(72, 25)
        Me.lblNote.TabIndex = 184
        Me.lblNote.Text = "ملاحظات"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(5, 563)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(628, 27)
        Me.txtNote.TabIndex = 185
        Me.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colItem_Des, Me.colbay_val, Me.colbay_mazan, Me.colGoldCaret999, Me.colGoldWeight999, Me.colbay_gram_price, Me.colTotalPrice, Me.colQunt, Me.colAddToItem, Me.colcastomer_id, Me.colCashier, Me.colB_gold_id, Me.colNote})
        Me.grid.Location = New System.Drawing.Point(5, 383)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(949, 178)
        Me.grid.TabIndex = 186
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Width = 59
        '
        'colItem_Des
        '
        Me.colItem_Des.HeaderText = "Item_Des"
        Me.colItem_Des.Name = "colItem_Des"
        Me.colItem_Des.ReadOnly = True
        Me.colItem_Des.Width = 97
        '
        'colbay_val
        '
        Me.colbay_val.HeaderText = "bay_val"
        Me.colbay_val.Name = "colbay_val"
        Me.colbay_val.ReadOnly = True
        Me.colbay_val.Width = 87
        '
        'colbay_mazan
        '
        Me.colbay_mazan.HeaderText = "bay_mazan"
        Me.colbay_mazan.Name = "colbay_mazan"
        Me.colbay_mazan.ReadOnly = True
        Me.colbay_mazan.Width = 111
        '
        'colGoldCaret999
        '
        Me.colGoldCaret999.HeaderText = "GoldCaret999"
        Me.colGoldCaret999.Name = "colGoldCaret999"
        Me.colGoldCaret999.ReadOnly = True
        Me.colGoldCaret999.Width = 126
        '
        'colGoldWeight999
        '
        Me.colGoldWeight999.HeaderText = "GoldWeight999"
        Me.colGoldWeight999.Name = "colGoldWeight999"
        Me.colGoldWeight999.ReadOnly = True
        Me.colGoldWeight999.Width = 139
        '
        'colbay_gram_price
        '
        Me.colbay_gram_price.HeaderText = "bay_gram_price"
        Me.colbay_gram_price.Name = "colbay_gram_price"
        Me.colbay_gram_price.ReadOnly = True
        Me.colbay_gram_price.Width = 144
        '
        'colTotalPrice
        '
        Me.colTotalPrice.HeaderText = "TotalPrice"
        Me.colTotalPrice.Name = "colTotalPrice"
        Me.colTotalPrice.ReadOnly = True
        Me.colTotalPrice.Width = 102
        '
        'colQunt
        '
        Me.colQunt.HeaderText = "Qunt"
        Me.colQunt.Name = "colQunt"
        Me.colQunt.ReadOnly = True
        Me.colQunt.Width = 69
        '
        'colAddToItem
        '
        Me.colAddToItem.HeaderText = "AddToItem"
        Me.colAddToItem.Name = "colAddToItem"
        Me.colAddToItem.ReadOnly = True
        Me.colAddToItem.Visible = False
        Me.colAddToItem.Width = 109
        '
        'colcastomer_id
        '
        Me.colcastomer_id.HeaderText = "castomer_id"
        Me.colcastomer_id.Name = "colcastomer_id"
        Me.colcastomer_id.ReadOnly = True
        Me.colcastomer_id.Visible = False
        Me.colcastomer_id.Width = 118
        '
        'colCashier
        '
        Me.colCashier.HeaderText = "Cashier"
        Me.colCashier.Name = "colCashier"
        Me.colCashier.ReadOnly = True
        Me.colCashier.Visible = False
        Me.colCashier.Width = 83
        '
        'colB_gold_id
        '
        Me.colB_gold_id.HeaderText = "B_gold_id"
        Me.colB_gold_id.Name = "colB_gold_id"
        Me.colB_gold_id.ReadOnly = True
        Me.colB_gold_id.Visible = False
        Me.colB_gold_id.Width = 102
        '
        'colNote
        '
        Me.colNote.HeaderText = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.Visible = False
        Me.colNote.Width = 68
        '
        'cmbKarat
        '
        Me.cmbKarat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKarat.FormattingEnabled = True
        Me.cmbKarat.Location = New System.Drawing.Point(838, 350)
        Me.cmbKarat.Name = "cmbKarat"
        Me.cmbKarat.Size = New System.Drawing.Size(114, 27)
        Me.cmbKarat.TabIndex = 1
        '
        'lblNetCaret
        '
        Me.lblNetCaret.Location = New System.Drawing.Point(653, 328)
        Me.lblNetCaret.Name = "lblNetCaret"
        Me.lblNetCaret.Size = New System.Drawing.Size(96, 20)
        Me.lblNetCaret.TabIndex = 188
        Me.lblNetCaret.Text = "العيار الصافي"
        Me.lblNetCaret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bay_gram_priceLabel
        '
        Me.Bay_gram_priceLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Bay_gram_priceLabel.LinkColor = System.Drawing.Color.PaleGreen
        Me.Bay_gram_priceLabel.Location = New System.Drawing.Point(350, 328)
        Me.Bay_gram_priceLabel.Name = "Bay_gram_priceLabel"
        Me.Bay_gram_priceLabel.Size = New System.Drawing.Size(132, 20)
        Me.Bay_gram_priceLabel.TabIndex = 189
        Me.Bay_gram_priceLabel.TabStop = True
        Me.Bay_gram_priceLabel.Text = "حساب سعر الجرام"
        Me.Bay_gram_priceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.OliveDrab
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.Location = New System.Drawing.Point(205, 328)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(143, 20)
        Me.LinkLabel1.TabIndex = 190
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "حساب السعر"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GoldBuyPerson
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(964, 591)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Bay_gram_priceLabel)
        Me.Controls.Add(Me.lblNetCaret)
        Me.Controls.Add(Me.cmbKarat)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.LblAddToItem)
        Me.Controls.Add(Me.chkAddToItem)
        Me.Controls.Add(Me.ComBxGoCaret999)
        Me.Controls.Add(Me.TXTGoCaret999)
        Me.Controls.Add(Me.lblNetWeight)
        Me.Controls.Add(Me.txtQunt)
        Me.Controls.Add(Me.lblQunt)
        Me.Controls.Add(Me.TeBoxItem_Des)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.cmbCashier)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.LabItem_Des)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.txtGramPrice)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.btnPayPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Bay_mazanLabel)
        Me.Controls.Add(Me.Bay_total_priceLabel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GoldBuyPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشتريات ذهب"
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_gold_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bay_valTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bay_mazanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bay_gram_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bay_total_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastomerCAIVELidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Loc_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Loc_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPayPrint As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtGramPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Inv_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bay_gold_idTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents CastomerCAIVELidTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Bay_mazanLabel As System.Windows.Forms.Label
    Friend WithEvents Bay_total_priceLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents SET_INVARCHR147TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Item_DesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabItem_Des As System.Windows.Forms.Label
    Friend WithEvents TIME_INVDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Castomer_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents cmbCashier As System.Windows.Forms.ComboBox
    Friend WithEvents INV_ActvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtQunt As System.Windows.Forms.TextBox
    Friend WithEvents lblQunt As System.Windows.Forms.Label
    Friend WithEvents TXTGoCaret999 As System.Windows.Forms.TextBox
    Friend WithEvents lblNetWeight As System.Windows.Forms.Label
    Friend WithEvents ComBxGoCaret999 As System.Windows.Forms.ComboBox
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents chkAddToItem As System.Windows.Forms.CheckBox
    Friend WithEvents LblAddToItem As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents cmbKarat As System.Windows.Forms.ComboBox
    Friend WithEvents TeBoxItem_Des As System.Windows.Forms.ComboBox
    Friend WithEvents lblNetCaret As System.Windows.Forms.Label
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colItem_Des As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbay_val As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbay_mazan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoldCaret999 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoldWeight999 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colbay_gram_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQunt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddToItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colcastomer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCashier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colB_gold_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bay_gram_priceLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
