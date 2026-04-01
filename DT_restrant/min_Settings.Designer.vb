<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class min_Settings
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
        Dim Inv_startLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(min_Settings))
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Inv_startBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_startTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.inv_startTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Inv_startTextBox = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Inv_startDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Inv_startLabel = New System.Windows.Forms.Label()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_startBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_startDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inv_startLabel
        '
        Inv_startLabel.AutoSize = True
        Inv_startLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Inv_startLabel.ForeColor = System.Drawing.Color.White
        Inv_startLabel.Location = New System.Drawing.Point(538, 345)
        Inv_startLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Inv_startLabel.Name = "Inv_startLabel"
        Inv_startLabel.Size = New System.Drawing.Size(87, 22)
        Inv_startLabel.TabIndex = 1
        Inv_startLabel.Text = "رقم المعرض"
        AddHandler Inv_startLabel.Click, AddressOf Me.Inv_startLabel_Click
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.EXTR_NAMETableAdapter = Nothing

        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Me.Inv_startTableAdapter
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
        'Inv_startTextBox
        '
        Me.Inv_startTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_startBindingSource, "inv_start", True))
        Me.Inv_startTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inv_startTextBox.Location = New System.Drawing.Point(428, 359)
        Me.Inv_startTextBox.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Inv_startTextBox.Name = "Inv_startTextBox"
        Me.Inv_startTextBox.Size = New System.Drawing.Size(52, 29)
        Me.Inv_startTextBox.TabIndex = 2
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(6, 5)
        Me.btnSettings.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(292, 34)
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.Text = "إعدادات الباركود"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Inv_startDataGridView
        '
        Me.Inv_startDataGridView.AutoGenerateColumns = False
        Me.Inv_startDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inv_startDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Inv_startDataGridView.DataSource = Me.Inv_startBindingSource
        Me.Inv_startDataGridView.Location = New System.Drawing.Point(512, 24)
        Me.Inv_startDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Inv_startDataGridView.Name = "Inv_startDataGridView"
        Me.Inv_startDataGridView.Size = New System.Drawing.Size(220, 183)
        Me.Inv_startDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "inv_start"
        Me.DataGridViewTextBoxColumn1.HeaderText = "inv_start"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_start"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_start"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Location = New System.Drawing.Point(12, 47)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 95)
        Me.Panel1.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(460, 264)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(72, 27)
        Me.TextBox3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(410, 212)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 47)
        Me.Panel2.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.DT_restrant.My.Resources.Resources.ArrowDown
        Me.Button3.Location = New System.Drawing.Point(4, 3)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(52, 41)
        Me.Button3.TabIndex = 9
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.DT_restrant.My.Resources.Resources.ArrowUp
        Me.Button2.Location = New System.Drawing.Point(588, 272)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(52, 41)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 27)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_startBindingSource, "inv_start", True))
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(744, 59)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 29)
        Me.TextBox2.TabIndex = 7
        '
        'min_Settings
        '
        Me.AcceptButton = Me.btnSettings
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(328, 151)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Inv_startLabel)
        Me.Controls.Add(Me.Inv_startTextBox)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Inv_startDataGridView)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "min_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاعدادات"
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_startBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_startDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Inv_startBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_startTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.inv_startTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Inv_startTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents Inv_startDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
