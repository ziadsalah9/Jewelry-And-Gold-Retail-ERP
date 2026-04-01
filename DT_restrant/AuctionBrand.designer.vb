<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuctionBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AuctionBrand))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtDB1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AuctionBrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.AuctionBrandTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.txtDB2 = New System.Windows.Forms.TextBox()
        Me.BrandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand_Name_Short = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(404, 8)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 47)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "جديد"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(209, 8)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 47)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(13, 66)
        Me.txt1.Margin = New System.Windows.Forms.Padding(4)
        Me.txt1.MaxLength = 50
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(326, 27)
        Me.txt1.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Location = New System.Drawing.Point(347, 66)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(134, 27)
        Me.lblName.TabIndex = 53
        Me.lblName.Text = "الاسم"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblName.UseWaitCursor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grid.AutoGenerateColumns = False
        Me.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid.BackgroundColor = System.Drawing.Color.Linen
        Me.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.ColumnHeadersVisible = False
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandIDDataGridViewTextBoxColumn, Me.BrandNameDataGridViewTextBoxColumn, Me.Brand_Name_Short})
        Me.grid.DataSource = Me.AuctionBrandBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grid.GridColor = System.Drawing.Color.Black
        Me.grid.Location = New System.Drawing.Point(13, 128)
        Me.grid.Margin = New System.Windows.Forms.Padding(4)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(468, 330)
        Me.grid.TabIndex = 4
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(13, 8)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(77, 47)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtDB1
        '
        Me.txtDB1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionBrandBindingSource, "Brand_Name", True))
        Me.txtDB1.Location = New System.Drawing.Point(598, 159)
        Me.txtDB1.Name = "txtDB1"
        Me.txtDB1.Size = New System.Drawing.Size(100, 27)
        Me.txtDB1.TabIndex = 58
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(13, 93)
        Me.txt2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt2.MaxLength = 8
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(326, 27)
        Me.txt2.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.Location = New System.Drawing.Point(347, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 27)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "الاسم المختصر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'AuctionBrandBindingSource
        '
        Me.AuctionBrandBindingSource.DataMember = "Auction_Brand"
        Me.AuctionBrandBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuctionBrandTableAdapter
        '
        Me.AuctionBrandTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Auction_BrandTableAdapter = Me.AuctionBrandTableAdapter
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
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'txtDB2
        '
        Me.txtDB2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuctionBrandBindingSource, "Brand_Name_Short", True))
        Me.txtDB2.Location = New System.Drawing.Point(598, 185)
        Me.txtDB2.Name = "txtDB2"
        Me.txtDB2.Size = New System.Drawing.Size(100, 27)
        Me.txtDB2.TabIndex = 61
        '
        'BrandIDDataGridViewTextBoxColumn
        '
        Me.BrandIDDataGridViewTextBoxColumn.DataPropertyName = "Brand_ID"
        Me.BrandIDDataGridViewTextBoxColumn.HeaderText = "Brand_ID"
        Me.BrandIDDataGridViewTextBoxColumn.Name = "BrandIDDataGridViewTextBoxColumn"
        Me.BrandIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        Me.BrandNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Brand_Name_Short
        '
        Me.Brand_Name_Short.DataPropertyName = "Brand_Name_Short"
        Me.Brand_Name_Short.HeaderText = "Brand_Name_Short"
        Me.Brand_Name_Short.Name = "Brand_Name_Short"
        Me.Brand_Name_Short.ReadOnly = True
        '
        'AuctionBrand
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(494, 478)
        Me.Controls.Add(Me.txtDB2)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDB1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btnEdit)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AuctionBrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الأنواع"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuctionBrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents txtDB1 As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents AuctionBrandTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Auction_BrandTableAdapter
    Friend WithEvents AuctionBrandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtDB2 As System.Windows.Forms.TextBox
    Friend WithEvents BrandIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Brand_Name_Short As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
