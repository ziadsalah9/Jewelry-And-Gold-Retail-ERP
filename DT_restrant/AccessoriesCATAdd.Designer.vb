<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesCATAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessoriesCATAdd))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CANTRY_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Gram_priceLabel = New System.Windows.Forms.Label()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Accessories_CATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Accessories_CATTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter()
        Me.AccessoriesCATIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATDATECRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesCATUSERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accessories_CATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Global.DT_restrant.My.Resources.Resources.Delete
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(127, 8)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 47)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(371, 8)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 47)
        Me.btnNew.TabIndex = 55
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
        Me.btnSave.Location = New System.Drawing.Point(249, 8)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 47)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'CANTRY_nameTextBox
        '
        Me.CANTRY_nameTextBox.Location = New System.Drawing.Point(5, 66)
        Me.CANTRY_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CANTRY_nameTextBox.MaxLength = 8
        Me.CANTRY_nameTextBox.Name = "CANTRY_nameTextBox"
        Me.CANTRY_nameTextBox.Size = New System.Drawing.Size(301, 27)
        Me.CANTRY_nameTextBox.TabIndex = 52
        '
        'Gram_priceLabel
        '
        Me.Gram_priceLabel.AutoEllipsis = True
        Me.Gram_priceLabel.Location = New System.Drawing.Point(314, 66)
        Me.Gram_priceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gram_priceLabel.Name = "Gram_priceLabel"
        Me.Gram_priceLabel.Size = New System.Drawing.Size(134, 27)
        Me.Gram_priceLabel.TabIndex = 53
        Me.Gram_priceLabel.Text = "الفئة"
        Me.Gram_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Gram_priceLabel.UseWaitCursor = True
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
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccessoriesCATIDDataGridViewTextBoxColumn, Me.AccessoriesCATNAMEDataGridViewTextBoxColumn, Me.AccessoriesCATDESCDataGridViewTextBoxColumn, Me.AccessoriesCATDATECRDataGridViewTextBoxColumn, Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn, Me.AccessoriesCATUSERDataGridViewTextBoxColumn})
        Me.grid.DataSource = Me.Accessories_CATBindingSource
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
        Me.grid.Location = New System.Drawing.Point(5, 98)
        Me.grid.Margin = New System.Windows.Forms.Padding(4)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.RowHeadersVisible = False
        Me.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(443, 367)
        Me.grid.TabIndex = 51
        '
        'Accessories_CATBindingSource
        '
        Me.Accessories_CATBindingSource.DataMember = "Accessories_CAT"
        Me.Accessories_CATBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Image = Global.DT_restrant.My.Resources.Resources.exchange
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(5, 8)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(77, 47)
        Me.btnEdit.TabIndex = 57
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing
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
        'TextBox
        '
        Me.TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accessories_CATBindingSource, "Accessories_CAT_NAME", True))
        Me.TextBox.Location = New System.Drawing.Point(463, 134)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(100, 27)
        Me.TextBox.TabIndex = 58
        '
        'Accessories_CATTableAdapter
        '
        Me.Accessories_CATTableAdapter.ClearBeforeFill = True
        '
        'AccessoriesCATIDDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATIDDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_ID"
        Me.AccessoriesCATIDDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_ID"
        Me.AccessoriesCATIDDataGridViewTextBoxColumn.Name = "AccessoriesCATIDDataGridViewTextBoxColumn"
        Me.AccessoriesCATIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessoriesCATNAMEDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATNAMEDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_NAME"
        Me.AccessoriesCATNAMEDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_NAME"
        Me.AccessoriesCATNAMEDataGridViewTextBoxColumn.Name = "AccessoriesCATNAMEDataGridViewTextBoxColumn"
        '
        'AccessoriesCATDESCDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATDESCDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_DESC"
        Me.AccessoriesCATDESCDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_DESC"
        Me.AccessoriesCATDESCDataGridViewTextBoxColumn.Name = "AccessoriesCATDESCDataGridViewTextBoxColumn"
        Me.AccessoriesCATDESCDataGridViewTextBoxColumn.Visible = False
        '
        'AccessoriesCATDATECRDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATDATECRDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_DATE_CR"
        Me.AccessoriesCATDATECRDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_DATE_CR"
        Me.AccessoriesCATDATECRDataGridViewTextBoxColumn.Name = "AccessoriesCATDATECRDataGridViewTextBoxColumn"
        Me.AccessoriesCATDATECRDataGridViewTextBoxColumn.Visible = False
        '
        'AccessoriesCATTIMECREDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_TIME_CRE"
        Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_TIME_CRE"
        Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn.Name = "AccessoriesCATTIMECREDataGridViewTextBoxColumn"
        Me.AccessoriesCATTIMECREDataGridViewTextBoxColumn.Visible = False
        '
        'AccessoriesCATUSERDataGridViewTextBoxColumn
        '
        Me.AccessoriesCATUSERDataGridViewTextBoxColumn.DataPropertyName = "Accessories_CAT_USER"
        Me.AccessoriesCATUSERDataGridViewTextBoxColumn.HeaderText = "Accessories_CAT_USER"
        Me.AccessoriesCATUSERDataGridViewTextBoxColumn.Name = "AccessoriesCATUSERDataGridViewTextBoxColumn"
        Me.AccessoriesCATUSERDataGridViewTextBoxColumn.Visible = False
        '
        'AccessoriesCATAdd
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(454, 471)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CANTRY_nameTextBox)
        Me.Controls.Add(Me.Gram_priceLabel)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.btnEdit)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccessoriesCATAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إضافة فئة"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accessories_CATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CANTRY_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Accessories_CATBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gram_priceLabel As System.Windows.Forms.Label
    Friend WithEvents Accessories_CATTableAdapter As DT_restrantDataSetTableAdapters.Accessories_CATTableAdapter
    Friend WithEvents AccessoriesCATIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATDESCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATDATECRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATTIMECREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessoriesCATUSERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
