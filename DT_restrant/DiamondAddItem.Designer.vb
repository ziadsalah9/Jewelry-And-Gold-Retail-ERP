<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiamondAddItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSelectItem = New System.Windows.Forms.GroupBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.lblDiamondName = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.DIMON_NAME_FILTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbItemData = New System.Windows.Forms.GroupBox()
        Me.lblTotalWeight = New System.Windows.Forms.Label()
        Me.txtTotalWeight = New System.Windows.Forms.TextBox()
        Me.cmbStone3 = New System.Windows.Forms.ComboBox()
        Me.txtStoneColor3 = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.cmbStone2 = New System.Windows.Forms.ComboBox()
        Me.txtStoneColor2 = New System.Windows.Forms.TextBox()
        Me.txtStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.lblStoneName = New System.Windows.Forms.Label()
        Me.cmbStone1 = New System.Windows.Forms.ComboBox()
        Me.lblStoneColor = New System.Windows.Forms.Label()
        Me.txtStoneColor1 = New System.Windows.Forms.TextBox()
        Me.lblStoneWeight = New System.Windows.Forms.Label()
        Me.txtStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.lblImage = New System.Windows.Forms.Label()
        Me.ITEM_IMGEPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblDiamondCut = New System.Windows.Forms.Label()
        Me.cmbCut = New System.Windows.Forms.ComboBox()
        Me.lblGoldGramPrice = New System.Windows.Forms.Label()
        Me.lblGoldWeight = New System.Windows.Forms.Label()
        Me.lblGoldCarat = New System.Windows.Forms.Label()
        Me.lblItemNo = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.lblDiamondClarity = New System.Windows.Forms.Label()
        Me.lblDiamondWeight = New System.Windows.Forms.Label()
        Me.lblDiamondColor = New System.Windows.Forms.Label()
        Me.txtGoldCarat = New System.Windows.Forms.TextBox()
        Me.txtGoldWeight = New System.Windows.Forms.TextBox()
        Me.txtGramPrice = New System.Windows.Forms.TextBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.txtDiamondColor = New System.Windows.Forms.TextBox()
        Me.txtDiamondWeight = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtDiamondClarity = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Add_ITEMtxtTotalPrice = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.Label()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Dimon_invceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dimon_invceTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.dimon_invceTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SET_INVARCHR152TextBox = New System.Windows.Forms.TextBox()
        Me.Dim_inv_idTextBox = New System.Windows.Forms.TextBox()
        Me.Dimo_idTextBox = New System.Windows.Forms.TextBox()
        Me.Castomr_idTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awaTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezanTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_colerTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_qultTextBox = New System.Windows.Forms.TextBox()
        Me.SarualTextBox = New System.Windows.Forms.TextBox()
        Me.Val_goldTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezanTextBox = New System.Windows.Forms.TextBox()
        Me.User_cretedTextBox = New System.Windows.Forms.TextBox()
        Me.Date_cretedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Test_13TextBox = New System.Windows.Forms.TextBox()
        Me.Test_14TextBox = New System.Windows.Forms.TextBox()
        Me.Test_15TextBox = New System.Windows.Forms.TextBox()
        Me.Test_16TextBox = New System.Windows.Forms.TextBox()
        Me.Test_17TextBox = New System.Windows.Forms.TextBox()
        Me.Test_18TextBox = New System.Windows.Forms.TextBox()
        Me.Test_19TextBox = New System.Windows.Forms.TextBox()
        Me.Test_110TextBox = New System.Windows.Forms.TextBox()
        Me.Test_111TextBox = New System.Windows.Forms.TextBox()
        Me.Test_112TextBox = New System.Windows.Forms.TextBox()
        Me.Test_116TextBox = New System.Windows.Forms.TextBox()
        Me.Test_117TextBox = New System.Windows.Forms.TextBox()
        Me.Test_118TextBox = New System.Windows.Forms.TextBox()
        Me.Test_119TextBox = New System.Windows.Forms.TextBox()
        Me.DescontTextBox = New System.Windows.Forms.TextBox()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.txtDimonID = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.DIMON_NAME_FILTERTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.DIMON_NAME_FILTERTableAdapter()
        Me.gbSelectItem.SuspendLayout()
        CType(Me.DIMON_NAME_FILTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbItemData.SuspendLayout()
        CType(Me.ITEM_IMGEPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dimon_invceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSelectItem
        '
        Me.gbSelectItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbSelectItem.Controls.Add(Me.lblCost)
        Me.gbSelectItem.Controls.Add(Me.txtCost)
        Me.gbSelectItem.Controls.Add(Me.lblPrice)
        Me.gbSelectItem.Controls.Add(Me.lblBarCode)
        Me.gbSelectItem.Controls.Add(Me.lblDiamondName)
        Me.gbSelectItem.Controls.Add(Me.txtPrice)
        Me.gbSelectItem.Controls.Add(Me.txtBarCode)
        Me.gbSelectItem.Controls.Add(Me.cmbItemName)
        Me.gbSelectItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbSelectItem.ForeColor = System.Drawing.Color.White
        Me.gbSelectItem.Location = New System.Drawing.Point(6, 66)
        Me.gbSelectItem.Name = "gbSelectItem"
        Me.gbSelectItem.Size = New System.Drawing.Size(973, 75)
        Me.gbSelectItem.TabIndex = 4
        Me.gbSelectItem.TabStop = False
        Me.gbSelectItem.Text = "اختر صنف"
        '
        'lblCost
        '
        Me.lblCost.Location = New System.Drawing.Point(233, 20)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(150, 20)
        Me.lblCost.TabIndex = 170
        Me.lblCost.Text = "التكلفة"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCost
        '
        Me.txtCost.Enabled = False
        Me.txtCost.Location = New System.Drawing.Point(233, 40)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(150, 27)
        Me.txtCost.TabIndex = 3
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(19, 20)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(150, 20)
        Me.lblPrice.TabIndex = 168
        Me.lblPrice.Text = "إجمالي السعر"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBarCode
        '
        Me.lblBarCode.Location = New System.Drawing.Point(447, 20)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(150, 20)
        Me.lblBarCode.TabIndex = 167
        Me.lblBarCode.Text = "باركود"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiamondName
        '
        Me.lblDiamondName.Location = New System.Drawing.Point(661, 20)
        Me.lblDiamondName.Name = "lblDiamondName"
        Me.lblDiamondName.Size = New System.Drawing.Size(292, 20)
        Me.lblDiamondName.TabIndex = 166
        Me.lblDiamondName.Text = "النوع"
        Me.lblDiamondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(19, 40)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(150, 27)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarCode
        '
        Me.txtBarCode.Location = New System.Drawing.Point(447, 40)
        Me.txtBarCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(150, 27)
        Me.txtBarCode.TabIndex = 2
        Me.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbItemName
        '
        Me.cmbItemName.DataSource = Me.DIMON_NAME_FILTERBindingSource
        Me.cmbItemName.DisplayMember = "DIMO_dep"
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(661, 40)
        Me.cmbItemName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(292, 27)
        Me.cmbItemName.TabIndex = 1
        Me.cmbItemName.ValueMember = "test_119"
        '
        'DIMON_NAME_FILTERBindingSource
        '
        Me.DIMON_NAME_FILTERBindingSource.DataMember = "DIMON_NAME_FILTER"
        Me.DIMON_NAME_FILTERBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(809, 11)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 50)
        Me.btnAdd.TabIndex = 166
        Me.btnAdd.Text = "إضافة"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gbItemData
        '
        Me.gbItemData.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbItemData.Controls.Add(Me.lblTotalWeight)
        Me.gbItemData.Controls.Add(Me.txtTotalWeight)
        Me.gbItemData.Controls.Add(Me.cmbStone3)
        Me.gbItemData.Controls.Add(Me.txtStoneColor3)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight3)
        Me.gbItemData.Controls.Add(Me.cmbStone2)
        Me.gbItemData.Controls.Add(Me.txtStoneColor2)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight2)
        Me.gbItemData.Controls.Add(Me.lblStoneName)
        Me.gbItemData.Controls.Add(Me.cmbStone1)
        Me.gbItemData.Controls.Add(Me.lblStoneColor)
        Me.gbItemData.Controls.Add(Me.txtStoneColor1)
        Me.gbItemData.Controls.Add(Me.lblStoneWeight)
        Me.gbItemData.Controls.Add(Me.txtStoneWeight1)
        Me.gbItemData.Controls.Add(Me.lblImage)
        Me.gbItemData.Controls.Add(Me.ITEM_IMGEPictureBox)
        Me.gbItemData.Controls.Add(Me.lblDiamondCut)
        Me.gbItemData.Controls.Add(Me.cmbCut)
        Me.gbItemData.Controls.Add(Me.lblGoldGramPrice)
        Me.gbItemData.Controls.Add(Me.lblGoldWeight)
        Me.gbItemData.Controls.Add(Me.lblGoldCarat)
        Me.gbItemData.Controls.Add(Me.lblItemNo)
        Me.gbItemData.Controls.Add(Me.lblQty)
        Me.gbItemData.Controls.Add(Me.lblDiamondClarity)
        Me.gbItemData.Controls.Add(Me.lblDiamondWeight)
        Me.gbItemData.Controls.Add(Me.lblDiamondColor)
        Me.gbItemData.Controls.Add(Me.txtGoldCarat)
        Me.gbItemData.Controls.Add(Me.txtGoldWeight)
        Me.gbItemData.Controls.Add(Me.txtGramPrice)
        Me.gbItemData.Controls.Add(Me.txtItemNo)
        Me.gbItemData.Controls.Add(Me.txtDiamondColor)
        Me.gbItemData.Controls.Add(Me.txtDiamondWeight)
        Me.gbItemData.Controls.Add(Me.txtQty)
        Me.gbItemData.Controls.Add(Me.txtDiamondClarity)
        Me.gbItemData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbItemData.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbItemData.ForeColor = System.Drawing.Color.White
        Me.gbItemData.Location = New System.Drawing.Point(6, 141)
        Me.gbItemData.Name = "gbItemData"
        Me.gbItemData.Size = New System.Drawing.Size(973, 199)
        Me.gbItemData.TabIndex = 5
        Me.gbItemData.TabStop = False
        Me.gbItemData.Text = "بيانات الصنف"
        '
        'lblTotalWeight
        '
        Me.lblTotalWeight.Location = New System.Drawing.Point(198, 136)
        Me.lblTotalWeight.Name = "lblTotalWeight"
        Me.lblTotalWeight.Size = New System.Drawing.Size(100, 22)
        Me.lblTotalWeight.TabIndex = 211
        Me.lblTotalWeight.Text = "الوزن الكلي"
        Me.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(198, 158)
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(100, 27)
        Me.txtTotalWeight.TabIndex = 210
        Me.txtTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStone3
        '
        Me.cmbStone3.DisplayMember = "EXTR_NAME"
        Me.cmbStone3.FormattingEnabled = True
        Me.cmbStone3.Location = New System.Drawing.Point(460, 160)
        Me.cmbStone3.Name = "cmbStone3"
        Me.cmbStone3.Size = New System.Drawing.Size(100, 27)
        Me.cmbStone3.TabIndex = 208
        Me.cmbStone3.ValueMember = "EXTR_NAME"
        '
        'txtStoneColor3
        '
        Me.txtStoneColor3.Location = New System.Drawing.Point(329, 160)
        Me.txtStoneColor3.Name = "txtStoneColor3"
        Me.txtStoneColor3.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneColor3.TabIndex = 209
        Me.txtStoneColor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight3
        '
        Me.txtStoneWeight3.Location = New System.Drawing.Point(591, 160)
        Me.txtStoneWeight3.Name = "txtStoneWeight3"
        Me.txtStoneWeight3.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneWeight3.TabIndex = 207
        Me.txtStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStone2
        '
        Me.cmbStone2.DisplayMember = "EXTR_NAME"
        Me.cmbStone2.FormattingEnabled = True
        Me.cmbStone2.Location = New System.Drawing.Point(460, 133)
        Me.cmbStone2.Name = "cmbStone2"
        Me.cmbStone2.Size = New System.Drawing.Size(100, 27)
        Me.cmbStone2.TabIndex = 205
        Me.cmbStone2.ValueMember = "EXTR_NAME"
        '
        'txtStoneColor2
        '
        Me.txtStoneColor2.Location = New System.Drawing.Point(329, 133)
        Me.txtStoneColor2.Name = "txtStoneColor2"
        Me.txtStoneColor2.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneColor2.TabIndex = 206
        Me.txtStoneColor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneWeight2
        '
        Me.txtStoneWeight2.Location = New System.Drawing.Point(591, 133)
        Me.txtStoneWeight2.Name = "txtStoneWeight2"
        Me.txtStoneWeight2.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneWeight2.TabIndex = 204
        Me.txtStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStoneName
        '
        Me.lblStoneName.Location = New System.Drawing.Point(460, 84)
        Me.lblStoneName.Name = "lblStoneName"
        Me.lblStoneName.Size = New System.Drawing.Size(100, 22)
        Me.lblStoneName.TabIndex = 203
        Me.lblStoneName.Text = "نوع الحجر"
        Me.lblStoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbStone1
        '
        Me.cmbStone1.DisplayMember = "EXTR_NAME"
        Me.cmbStone1.FormattingEnabled = True
        Me.cmbStone1.Location = New System.Drawing.Point(460, 106)
        Me.cmbStone1.Name = "cmbStone1"
        Me.cmbStone1.Size = New System.Drawing.Size(100, 27)
        Me.cmbStone1.TabIndex = 9
        Me.cmbStone1.ValueMember = "EXTR_NAME"
        '
        'lblStoneColor
        '
        Me.lblStoneColor.Location = New System.Drawing.Point(329, 84)
        Me.lblStoneColor.Name = "lblStoneColor"
        Me.lblStoneColor.Size = New System.Drawing.Size(100, 22)
        Me.lblStoneColor.TabIndex = 201
        Me.lblStoneColor.Text = "لون الحجر"
        Me.lblStoneColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneColor1
        '
        Me.txtStoneColor1.Location = New System.Drawing.Point(329, 106)
        Me.txtStoneColor1.Name = "txtStoneColor1"
        Me.txtStoneColor1.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneColor1.TabIndex = 10
        Me.txtStoneColor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStoneWeight
        '
        Me.lblStoneWeight.Location = New System.Drawing.Point(591, 84)
        Me.lblStoneWeight.Name = "lblStoneWeight"
        Me.lblStoneWeight.Size = New System.Drawing.Size(100, 22)
        Me.lblStoneWeight.TabIndex = 199
        Me.lblStoneWeight.Text = "وزن الحجر"
        Me.lblStoneWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStoneWeight1
        '
        Me.txtStoneWeight1.Location = New System.Drawing.Point(591, 106)
        Me.txtStoneWeight1.Name = "txtStoneWeight1"
        Me.txtStoneWeight1.Size = New System.Drawing.Size(100, 27)
        Me.txtStoneWeight1.TabIndex = 8
        Me.txtStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblImage
        '
        Me.lblImage.Location = New System.Drawing.Point(19, 19)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(148, 19)
        Me.lblImage.TabIndex = 9
        Me.lblImage.Text = "الصورة"
        Me.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ITEM_IMGEPictureBox
        '
        Me.ITEM_IMGEPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ITEM_IMGEPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ITEM_IMGEPictureBox.Location = New System.Drawing.Point(19, 43)
        Me.ITEM_IMGEPictureBox.Name = "ITEM_IMGEPictureBox"
        Me.ITEM_IMGEPictureBox.Size = New System.Drawing.Size(148, 90)
        Me.ITEM_IMGEPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ITEM_IMGEPictureBox.TabIndex = 197
        Me.ITEM_IMGEPictureBox.TabStop = False
        '
        'lblDiamondCut
        '
        Me.lblDiamondCut.Location = New System.Drawing.Point(460, 21)
        Me.lblDiamondCut.Name = "lblDiamondCut"
        Me.lblDiamondCut.Size = New System.Drawing.Size(100, 22)
        Me.lblDiamondCut.TabIndex = 196
        Me.lblDiamondCut.Text = "القص"
        Me.lblDiamondCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCut
        '
        Me.cmbCut.DisplayMember = "dimon_cat_name"
        Me.cmbCut.FormattingEnabled = True
        Me.cmbCut.Location = New System.Drawing.Point(460, 43)
        Me.cmbCut.Name = "cmbCut"
        Me.cmbCut.Size = New System.Drawing.Size(100, 27)
        Me.cmbCut.TabIndex = 3
        Me.cmbCut.ValueMember = "dimon_cat_name"
        '
        'lblGoldGramPrice
        '
        Me.lblGoldGramPrice.Location = New System.Drawing.Point(198, 84)
        Me.lblGoldGramPrice.Name = "lblGoldGramPrice"
        Me.lblGoldGramPrice.Size = New System.Drawing.Size(100, 22)
        Me.lblGoldGramPrice.TabIndex = 194
        Me.lblGoldGramPrice.Text = "سعر الجرام"
        Me.lblGoldGramPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoldWeight
        '
        Me.lblGoldWeight.Location = New System.Drawing.Point(722, 84)
        Me.lblGoldWeight.Name = "lblGoldWeight"
        Me.lblGoldWeight.Size = New System.Drawing.Size(100, 22)
        Me.lblGoldWeight.TabIndex = 193
        Me.lblGoldWeight.Text = "وزن الذهب"
        Me.lblGoldWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGoldCarat
        '
        Me.lblGoldCarat.Location = New System.Drawing.Point(853, 84)
        Me.lblGoldCarat.Name = "lblGoldCarat"
        Me.lblGoldCarat.Size = New System.Drawing.Size(100, 22)
        Me.lblGoldCarat.TabIndex = 192
        Me.lblGoldCarat.Text = "عيار الذهب"
        Me.lblGoldCarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemNo
        '
        Me.lblItemNo.Location = New System.Drawing.Point(329, 20)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(100, 22)
        Me.lblItemNo.TabIndex = 191
        Me.lblItemNo.Text = "رقم القطعة"
        Me.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQty
        '
        Me.lblQty.Location = New System.Drawing.Point(198, 21)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(100, 22)
        Me.lblQty.TabIndex = 190
        Me.lblQty.Text = "العدد"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiamondClarity
        '
        Me.lblDiamondClarity.Location = New System.Drawing.Point(591, 21)
        Me.lblDiamondClarity.Name = "lblDiamondClarity"
        Me.lblDiamondClarity.Size = New System.Drawing.Size(100, 22)
        Me.lblDiamondClarity.TabIndex = 189
        Me.lblDiamondClarity.Text = "النقاوة"
        Me.lblDiamondClarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiamondWeight
        '
        Me.lblDiamondWeight.Location = New System.Drawing.Point(722, 21)
        Me.lblDiamondWeight.Name = "lblDiamondWeight"
        Me.lblDiamondWeight.Size = New System.Drawing.Size(100, 22)
        Me.lblDiamondWeight.TabIndex = 188
        Me.lblDiamondWeight.Text = "قيراط الألماس"
        Me.lblDiamondWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDiamondColor
        '
        Me.lblDiamondColor.Location = New System.Drawing.Point(853, 21)
        Me.lblDiamondColor.Name = "lblDiamondColor"
        Me.lblDiamondColor.Size = New System.Drawing.Size(100, 22)
        Me.lblDiamondColor.TabIndex = 187
        Me.lblDiamondColor.Text = "لون الألماس"
        Me.lblDiamondColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGoldCarat
        '
        Me.txtGoldCarat.Location = New System.Drawing.Point(853, 106)
        Me.txtGoldCarat.Name = "txtGoldCarat"
        Me.txtGoldCarat.Size = New System.Drawing.Size(100, 27)
        Me.txtGoldCarat.TabIndex = 6
        Me.txtGoldCarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGoldWeight
        '
        Me.txtGoldWeight.Location = New System.Drawing.Point(722, 106)
        Me.txtGoldWeight.Name = "txtGoldWeight"
        Me.txtGoldWeight.Size = New System.Drawing.Size(100, 27)
        Me.txtGoldWeight.TabIndex = 7
        Me.txtGoldWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGramPrice
        '
        Me.txtGramPrice.Location = New System.Drawing.Point(198, 106)
        Me.txtGramPrice.Name = "txtGramPrice"
        Me.txtGramPrice.Size = New System.Drawing.Size(100, 27)
        Me.txtGramPrice.TabIndex = 11
        Me.txtGramPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(329, 43)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(100, 27)
        Me.txtItemNo.TabIndex = 4
        Me.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiamondColor
        '
        Me.txtDiamondColor.Location = New System.Drawing.Point(853, 43)
        Me.txtDiamondColor.Name = "txtDiamondColor"
        Me.txtDiamondColor.Size = New System.Drawing.Size(100, 27)
        Me.txtDiamondColor.TabIndex = 0
        Me.txtDiamondColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiamondWeight
        '
        Me.txtDiamondWeight.Location = New System.Drawing.Point(722, 43)
        Me.txtDiamondWeight.Name = "txtDiamondWeight"
        Me.txtDiamondWeight.Size = New System.Drawing.Size(100, 27)
        Me.txtDiamondWeight.TabIndex = 1
        Me.txtDiamondWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(198, 43)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 27)
        Me.txtQty.TabIndex = 5
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiamondClarity
        '
        Me.txtDiamondClarity.Location = New System.Drawing.Point(591, 43)
        Me.txtDiamondClarity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiamondClarity.Name = "txtDiamondClarity"
        Me.txtDiamondClarity.Size = New System.Drawing.Size(100, 27)
        Me.txtDiamondClarity.TabIndex = 2
        Me.txtDiamondClarity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblTotalPrice.Location = New System.Drawing.Point(123, 557)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(136, 29)
        Me.lblTotalPrice.TabIndex = 160
        Me.lblTotalPrice.Text = "إجمالي سعر الفاتورة"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add_ITEMtxtTotalPrice
        '
        Me.Add_ITEMtxtTotalPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_ITEMtxtTotalPrice.ForeColor = System.Drawing.Color.Chartreuse
        Me.Add_ITEMtxtTotalPrice.Location = New System.Drawing.Point(11, 557)
        Me.Add_ITEMtxtTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Add_ITEMtxtTotalPrice.Name = "Add_ITEMtxtTotalPrice"
        Me.Add_ITEMtxtTotalPrice.Size = New System.Drawing.Size(104, 26)
        Me.Add_ITEMtxtTotalPrice.TabIndex = 159
        Me.Add_ITEMtxtTotalPrice.Text = "0.000"
        Me.Add_ITEMtxtTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeight = 46
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.Location = New System.Drawing.Point(6, 346)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(973, 172)
        Me.grid.TabIndex = 165
        '
        'lblInvNo
        '
        Me.lblInvNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInvNo.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblInvNo.Location = New System.Drawing.Point(840, 557)
        Me.lblInvNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(136, 29)
        Me.lblInvNo.TabIndex = 167
        Me.lblInvNo.Text = "رقم الفاتورة"
        Me.lblInvNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.Chartreuse
        Me.txtInvoiceNo.Location = New System.Drawing.Point(724, 558)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(114, 26)
        Me.txtInvoiceNo.TabIndex = 166
        Me.txtInvoiceNo.Text = "0.000"
        Me.txtInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
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
        Me.TableAdapterManager.SettingsTableAdapter = Me.SettingsTableAdapter
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(407, 11)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 50)
        Me.btnUpdate.TabIndex = 171
        Me.btnUpdate.Text = "تعديل"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Dimon_invceBindingSource
        '
        Me.Dimon_invceBindingSource.DataMember = "dimon_invce"
        Me.Dimon_invceBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Dimon_invceTableAdapter
        '
        Me.Dimon_invceTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(6, 10)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 50)
        Me.btnSave.TabIndex = 173
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SET_INVARCHR152TextBox
        '
        Me.SET_INVARCHR152TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR152TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR152", True))
        Me.SET_INVARCHR152TextBox.Location = New System.Drawing.Point(-142, 71)
        Me.SET_INVARCHR152TextBox.Name = "SET_INVARCHR152TextBox"
        Me.SET_INVARCHR152TextBox.Size = New System.Drawing.Size(41, 20)
        Me.SET_INVARCHR152TextBox.TabIndex = 170
        '
        'Dim_inv_idTextBox
        '
        Me.Dim_inv_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dim_inv_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "dim_inv_id", True))
        Me.Dim_inv_idTextBox.Location = New System.Drawing.Point(-38, 51)
        Me.Dim_inv_idTextBox.Name = "Dim_inv_idTextBox"
        Me.Dim_inv_idTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Dim_inv_idTextBox.TabIndex = 171
        '
        'Dimo_idTextBox
        '
        Me.Dimo_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dimo_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "dimo_id", True))
        Me.Dimo_idTextBox.Location = New System.Drawing.Point(-38, 71)
        Me.Dimo_idTextBox.Name = "Dimo_idTextBox"
        Me.Dimo_idTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Dimo_idTextBox.TabIndex = 172
        '
        'Castomr_idTextBox
        '
        Me.Castomr_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Castomr_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "castomr_id", True))
        Me.Castomr_idTextBox.Location = New System.Drawing.Point(-38, 91)
        Me.Castomr_idTextBox.Name = "Castomr_idTextBox"
        Me.Castomr_idTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Castomr_idTextBox.TabIndex = 173
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(-38, 111)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(41, 20)
        Me.TotalTextBox.TabIndex = 175
        '
        'DIMO_TypeTextBox
        '
        Me.DIMO_TypeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "DIMO_Type", True))
        Me.DIMO_TypeTextBox.Location = New System.Drawing.Point(-38, 131)
        Me.DIMO_TypeTextBox.Name = "DIMO_TypeTextBox"
        Me.DIMO_TypeTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DIMO_TypeTextBox.TabIndex = 176
        '
        'DIM_na9awaTextBox
        '
        Me.DIM_na9awaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIM_na9awaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "DIM_na9awa", True))
        Me.DIM_na9awaTextBox.Location = New System.Drawing.Point(-38, 151)
        Me.DIM_na9awaTextBox.Name = "DIM_na9awaTextBox"
        Me.DIM_na9awaTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DIM_na9awaTextBox.TabIndex = 177
        '
        'DIMO_mezanTextBox
        '
        Me.DIMO_mezanTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_mezanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "DIMO_mezan", True))
        Me.DIMO_mezanTextBox.Location = New System.Drawing.Point(-38, 171)
        Me.DIMO_mezanTextBox.Name = "DIMO_mezanTextBox"
        Me.DIMO_mezanTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DIMO_mezanTextBox.TabIndex = 178
        '
        'DIMO_colerTextBox
        '
        Me.DIMO_colerTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_colerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "DIMO_coler", True))
        Me.DIMO_colerTextBox.Location = New System.Drawing.Point(-38, 191)
        Me.DIMO_colerTextBox.Name = "DIMO_colerTextBox"
        Me.DIMO_colerTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DIMO_colerTextBox.TabIndex = 179
        '
        'DIMO_qultTextBox
        '
        Me.DIMO_qultTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_qultTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "DIMO_qult", True))
        Me.DIMO_qultTextBox.Location = New System.Drawing.Point(-38, 211)
        Me.DIMO_qultTextBox.Name = "DIMO_qultTextBox"
        Me.DIMO_qultTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DIMO_qultTextBox.TabIndex = 180
        '
        'SarualTextBox
        '
        Me.SarualTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SarualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "sarual", True))
        Me.SarualTextBox.Location = New System.Drawing.Point(-38, 231)
        Me.SarualTextBox.Name = "SarualTextBox"
        Me.SarualTextBox.Size = New System.Drawing.Size(41, 20)
        Me.SarualTextBox.TabIndex = 181
        '
        'Val_goldTextBox
        '
        Me.Val_goldTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Val_goldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "val_gold", True))
        Me.Val_goldTextBox.Location = New System.Drawing.Point(-38, 251)
        Me.Val_goldTextBox.Name = "Val_goldTextBox"
        Me.Val_goldTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Val_goldTextBox.TabIndex = 182
        '
        'GOLD_mezanTextBox
        '
        Me.GOLD_mezanTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GOLD_mezanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "GOLD_mezan", True))
        Me.GOLD_mezanTextBox.Location = New System.Drawing.Point(-38, 271)
        Me.GOLD_mezanTextBox.Name = "GOLD_mezanTextBox"
        Me.GOLD_mezanTextBox.Size = New System.Drawing.Size(41, 20)
        Me.GOLD_mezanTextBox.TabIndex = 183
        '
        'User_cretedTextBox
        '
        Me.User_cretedTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.User_cretedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "user_creted", True))
        Me.User_cretedTextBox.Location = New System.Drawing.Point(-38, 291)
        Me.User_cretedTextBox.Name = "User_cretedTextBox"
        Me.User_cretedTextBox.Size = New System.Drawing.Size(41, 20)
        Me.User_cretedTextBox.TabIndex = 184
        '
        'Date_cretedDateTimePicker
        '
        Me.Date_cretedDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_cretedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dimon_invceBindingSource, "date_creted", True))
        Me.Date_cretedDateTimePicker.Location = New System.Drawing.Point(-38, 311)
        Me.Date_cretedDateTimePicker.Name = "Date_cretedDateTimePicker"
        Me.Date_cretedDateTimePicker.Size = New System.Drawing.Size(41, 20)
        Me.Date_cretedDateTimePicker.TabIndex = 185
        '
        'TimeDateTimePicker
        '
        Me.TimeDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dimon_invceBindingSource, "time", True))
        Me.TimeDateTimePicker.Location = New System.Drawing.Point(-38, 331)
        Me.TimeDateTimePicker.Name = "TimeDateTimePicker"
        Me.TimeDateTimePicker.Size = New System.Drawing.Size(41, 20)
        Me.TimeDateTimePicker.TabIndex = 186
        '
        'Test_13TextBox
        '
        Me.Test_13TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_13", True))
        Me.Test_13TextBox.Location = New System.Drawing.Point(-95, 170)
        Me.Test_13TextBox.Name = "Test_13TextBox"
        Me.Test_13TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_13TextBox.TabIndex = 187
        '
        'Test_14TextBox
        '
        Me.Test_14TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_14", True))
        Me.Test_14TextBox.Location = New System.Drawing.Point(-95, 190)
        Me.Test_14TextBox.Name = "Test_14TextBox"
        Me.Test_14TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_14TextBox.TabIndex = 188
        '
        'Test_15TextBox
        '
        Me.Test_15TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_15", True))
        Me.Test_15TextBox.Location = New System.Drawing.Point(-95, 210)
        Me.Test_15TextBox.Name = "Test_15TextBox"
        Me.Test_15TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_15TextBox.TabIndex = 189
        '
        'Test_16TextBox
        '
        Me.Test_16TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_16TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_16", True))
        Me.Test_16TextBox.Location = New System.Drawing.Point(-95, 230)
        Me.Test_16TextBox.Name = "Test_16TextBox"
        Me.Test_16TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_16TextBox.TabIndex = 190
        '
        'Test_17TextBox
        '
        Me.Test_17TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_17TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_17", True))
        Me.Test_17TextBox.Location = New System.Drawing.Point(-95, 250)
        Me.Test_17TextBox.Name = "Test_17TextBox"
        Me.Test_17TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_17TextBox.TabIndex = 191
        '
        'Test_18TextBox
        '
        Me.Test_18TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_18TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_18", True))
        Me.Test_18TextBox.Location = New System.Drawing.Point(-95, 270)
        Me.Test_18TextBox.Name = "Test_18TextBox"
        Me.Test_18TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_18TextBox.TabIndex = 192
        '
        'Test_19TextBox
        '
        Me.Test_19TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_19TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_19", True))
        Me.Test_19TextBox.Location = New System.Drawing.Point(-95, 290)
        Me.Test_19TextBox.Name = "Test_19TextBox"
        Me.Test_19TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_19TextBox.TabIndex = 193
        '
        'Test_110TextBox
        '
        Me.Test_110TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_110TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_110", True))
        Me.Test_110TextBox.Location = New System.Drawing.Point(-95, 310)
        Me.Test_110TextBox.Name = "Test_110TextBox"
        Me.Test_110TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_110TextBox.TabIndex = 194
        '
        'Test_111TextBox
        '
        Me.Test_111TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_111TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_111", True))
        Me.Test_111TextBox.Location = New System.Drawing.Point(-95, 330)
        Me.Test_111TextBox.Name = "Test_111TextBox"
        Me.Test_111TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_111TextBox.TabIndex = 195
        '
        'Test_112TextBox
        '
        Me.Test_112TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_112TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_112", True))
        Me.Test_112TextBox.Location = New System.Drawing.Point(-95, 51)
        Me.Test_112TextBox.Name = "Test_112TextBox"
        Me.Test_112TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_112TextBox.TabIndex = 196
        '
        'Test_116TextBox
        '
        Me.Test_116TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_116TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_116", True))
        Me.Test_116TextBox.Location = New System.Drawing.Point(-95, 71)
        Me.Test_116TextBox.Name = "Test_116TextBox"
        Me.Test_116TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_116TextBox.TabIndex = 197
        '
        'Test_117TextBox
        '
        Me.Test_117TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_117TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_117", True))
        Me.Test_117TextBox.Location = New System.Drawing.Point(-95, 91)
        Me.Test_117TextBox.Name = "Test_117TextBox"
        Me.Test_117TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_117TextBox.TabIndex = 198
        '
        'Test_118TextBox
        '
        Me.Test_118TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_118TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_118", True))
        Me.Test_118TextBox.Location = New System.Drawing.Point(-95, 111)
        Me.Test_118TextBox.Name = "Test_118TextBox"
        Me.Test_118TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_118TextBox.TabIndex = 199
        '
        'Test_119TextBox
        '
        Me.Test_119TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_119TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "test_119", True))
        Me.Test_119TextBox.Location = New System.Drawing.Point(-95, 131)
        Me.Test_119TextBox.Name = "Test_119TextBox"
        Me.Test_119TextBox.Size = New System.Drawing.Size(41, 20)
        Me.Test_119TextBox.TabIndex = 200
        '
        'DescontTextBox
        '
        Me.DescontTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescontTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dimon_invceBindingSource, "descont", True))
        Me.DescontTextBox.Location = New System.Drawing.Point(-95, 151)
        Me.DescontTextBox.Name = "DescontTextBox"
        Me.DescontTextBox.Size = New System.Drawing.Size(41, 20)
        Me.DescontTextBox.TabIndex = 201
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.txtDimonID)
        Me.pnl.Controls.Add(Me.DescontTextBox)
        Me.pnl.Controls.Add(Me.Test_119TextBox)
        Me.pnl.Controls.Add(Me.Test_118TextBox)
        Me.pnl.Controls.Add(Me.Test_117TextBox)
        Me.pnl.Controls.Add(Me.Test_116TextBox)
        Me.pnl.Controls.Add(Me.Test_112TextBox)
        Me.pnl.Controls.Add(Me.Test_111TextBox)
        Me.pnl.Controls.Add(Me.Test_110TextBox)
        Me.pnl.Controls.Add(Me.Test_19TextBox)
        Me.pnl.Controls.Add(Me.Test_18TextBox)
        Me.pnl.Controls.Add(Me.Test_17TextBox)
        Me.pnl.Controls.Add(Me.Test_16TextBox)
        Me.pnl.Controls.Add(Me.Test_15TextBox)
        Me.pnl.Controls.Add(Me.Test_14TextBox)
        Me.pnl.Controls.Add(Me.Test_13TextBox)
        Me.pnl.Controls.Add(Me.TimeDateTimePicker)
        Me.pnl.Controls.Add(Me.Date_cretedDateTimePicker)
        Me.pnl.Controls.Add(Me.User_cretedTextBox)
        Me.pnl.Controls.Add(Me.GOLD_mezanTextBox)
        Me.pnl.Controls.Add(Me.Val_goldTextBox)
        Me.pnl.Controls.Add(Me.SarualTextBox)
        Me.pnl.Controls.Add(Me.DIMO_qultTextBox)
        Me.pnl.Controls.Add(Me.DIMO_colerTextBox)
        Me.pnl.Controls.Add(Me.DIMO_mezanTextBox)
        Me.pnl.Controls.Add(Me.DIM_na9awaTextBox)
        Me.pnl.Controls.Add(Me.DIMO_TypeTextBox)
        Me.pnl.Controls.Add(Me.TotalTextBox)
        Me.pnl.Controls.Add(Me.Castomr_idTextBox)
        Me.pnl.Controls.Add(Me.Dimo_idTextBox)
        Me.pnl.Controls.Add(Me.Dim_inv_idTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR152TextBox)
        Me.pnl.Location = New System.Drawing.Point(1023, 29)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(53, 43)
        Me.pnl.TabIndex = 172
        '
        'txtDimonID
        '
        Me.txtDimonID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDimonID.Location = New System.Drawing.Point(-143, 51)
        Me.txtDimonID.Name = "txtDimonID"
        Me.txtDimonID.Size = New System.Drawing.Size(41, 20)
        Me.txtDimonID.TabIndex = 202
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNotes.Location = New System.Drawing.Point(6, 525)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(832, 27)
        Me.txtNotes.TabIndex = 192
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNotes
        '
        Me.lblNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblNotes.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblNotes.Location = New System.Drawing.Point(845, 529)
        Me.lblNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(126, 19)
        Me.lblNotes.TabIndex = 191
        Me.lblNotes.Text = "ملاحظات"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DIMON_NAME_FILTERTableAdapter
        '
        Me.DIMON_NAME_FILTERTableAdapter.ClearBeforeFill = True
        '
        'DiamondAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(984, 591)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblInvNo)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Add_ITEMtxtTotalPrice)
        Me.Controls.Add(Me.gbItemData)
        Me.Controls.Add(Me.gbSelectItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DiamondAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiamondAddItem"
        Me.gbSelectItem.ResumeLayout(False)
        Me.gbSelectItem.PerformLayout()
        CType(Me.DIMON_NAME_FILTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbItemData.ResumeLayout(False)
        Me.gbItemData.PerformLayout()
        CType(Me.ITEM_IMGEPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dimon_invceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbSelectItem As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblBarCode As System.Windows.Forms.Label
    Friend WithEvents lblDiamondName As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbItemName As System.Windows.Forms.ComboBox
    Friend WithEvents gbItemData As System.Windows.Forms.GroupBox
    Friend WithEvents lblStoneName As System.Windows.Forms.Label
    Friend WithEvents cmbStone1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblStoneColor As System.Windows.Forms.Label
    Friend WithEvents txtStoneColor1 As System.Windows.Forms.TextBox
    Friend WithEvents lblStoneWeight As System.Windows.Forms.Label
    Friend WithEvents txtStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents lblImage As System.Windows.Forms.Label
    Friend WithEvents ITEM_IMGEPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblDiamondCut As System.Windows.Forms.Label
    Friend WithEvents cmbCut As System.Windows.Forms.ComboBox
    Friend WithEvents lblGoldGramPrice As System.Windows.Forms.Label
    Friend WithEvents lblGoldWeight As System.Windows.Forms.Label
    Friend WithEvents lblGoldCarat As System.Windows.Forms.Label
    Friend WithEvents lblItemNo As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblDiamondClarity As System.Windows.Forms.Label
    Friend WithEvents lblDiamondWeight As System.Windows.Forms.Label
    Friend WithEvents lblDiamondColor As System.Windows.Forms.Label
    Friend WithEvents txtGoldCarat As System.Windows.Forms.TextBox
    Friend WithEvents txtGoldWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtGramPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDiamondColor As System.Windows.Forms.TextBox
    Friend WithEvents txtDiamondWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDiamondClarity As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents Add_ITEMtxtTotalPrice As System.Windows.Forms.Label
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Dimon_invceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Dimon_invceTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.dimon_invceTableAdapter
    Friend WithEvents btnSave As Button
    Friend WithEvents SET_INVARCHR152TextBox As TextBox
    Friend WithEvents Dim_inv_idTextBox As TextBox
    Friend WithEvents Dimo_idTextBox As TextBox
    Friend WithEvents Castomr_idTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents DIMO_TypeTextBox As TextBox
    Friend WithEvents DIM_na9awaTextBox As TextBox
    Friend WithEvents DIMO_mezanTextBox As TextBox
    Friend WithEvents DIMO_colerTextBox As TextBox
    Friend WithEvents DIMO_qultTextBox As TextBox
    Friend WithEvents SarualTextBox As TextBox
    Friend WithEvents Val_goldTextBox As TextBox
    Friend WithEvents GOLD_mezanTextBox As TextBox
    Friend WithEvents User_cretedTextBox As TextBox
    Friend WithEvents Date_cretedDateTimePicker As DateTimePicker
    Friend WithEvents TimeDateTimePicker As DateTimePicker
    Friend WithEvents Test_13TextBox As TextBox
    Friend WithEvents Test_14TextBox As TextBox
    Friend WithEvents Test_15TextBox As TextBox
    Friend WithEvents Test_16TextBox As TextBox
    Friend WithEvents Test_17TextBox As TextBox
    Friend WithEvents Test_18TextBox As TextBox
    Friend WithEvents Test_19TextBox As TextBox
    Friend WithEvents Test_110TextBox As TextBox
    Friend WithEvents Test_111TextBox As TextBox
    Friend WithEvents Test_112TextBox As TextBox
    Friend WithEvents Test_116TextBox As TextBox
    Friend WithEvents Test_117TextBox As TextBox
    Friend WithEvents Test_118TextBox As TextBox
    Friend WithEvents Test_119TextBox As TextBox
    Friend WithEvents DescontTextBox As TextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents cmbStone3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtStoneColor3 As System.Windows.Forms.TextBox
    Friend WithEvents txtStoneWeight3 As System.Windows.Forms.TextBox
    Friend WithEvents cmbStone2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtStoneColor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStoneWeight2 As System.Windows.Forms.TextBox
    Friend WithEvents DIMON_NAME_FILTERBindingSource As BindingSource
    Friend WithEvents DIMON_NAME_FILTERTableAdapter As DT_restrantDataSetTableAdapters.DIMON_NAME_FILTERTableAdapter
    Friend WithEvents lblTotalWeight As System.Windows.Forms.Label
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtDimonID As TextBox
End Class
