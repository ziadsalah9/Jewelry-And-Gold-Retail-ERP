<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GramPrice
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
        Dim Gram_valuLabel As System.Windows.Forms.Label
        Dim Gram_priceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GramPrice))
        Me.Gram_valBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Gram_valuTextBox = New System.Windows.Forms.TextBox()
        Me.Gram_priceTextBox = New System.Windows.Forms.TextBox()
        Me.GramvalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gram_valTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Gram_valTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Gram_valDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Gram_valuLabel = New System.Windows.Forms.Label()
        Gram_priceLabel = New System.Windows.Forms.Label()
        CType(Me.Gram_valBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GramvalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gram_valDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gram_valuLabel
        '
        Gram_valuLabel.AutoSize = True
        Gram_valuLabel.Location = New System.Drawing.Point(504, 98)
        Gram_valuLabel.Name = "Gram_valuLabel"
        Gram_valuLabel.Size = New System.Drawing.Size(35, 19)
        Gram_valuLabel.TabIndex = 2
        Gram_valuLabel.Text = "النوع"
        '
        'Gram_priceLabel
        '
        Gram_priceLabel.AutoSize = True
        Gram_priceLabel.Location = New System.Drawing.Point(497, 166)
        Gram_priceLabel.Name = "Gram_priceLabel"
        Gram_priceLabel.Size = New System.Drawing.Size(42, 19)
        Gram_priceLabel.TabIndex = 4
        Gram_priceLabel.Text = "السعر"
        '
        'Gram_valBindingSource
        '
        Me.Gram_valBindingSource.DataMember = "Gram_val"
        Me.Gram_valBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gram_valuTextBox
        '
        Me.Gram_valuTextBox.BackColor = System.Drawing.Color.Linen
        Me.Gram_valuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gram_valBindingSource, "Gram_valu", True))
        Me.Gram_valuTextBox.Location = New System.Drawing.Point(284, 95)
        Me.Gram_valuTextBox.Name = "Gram_valuTextBox"
        Me.Gram_valuTextBox.Size = New System.Drawing.Size(202, 27)
        Me.Gram_valuTextBox.TabIndex = 3
        '
        'Gram_priceTextBox
        '
        Me.Gram_priceTextBox.BackColor = System.Drawing.Color.Linen
        Me.Gram_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gram_valBindingSource, "Gram_price", True))
        Me.Gram_priceTextBox.Location = New System.Drawing.Point(284, 163)
        Me.Gram_priceTextBox.Name = "Gram_priceTextBox"
        Me.Gram_priceTextBox.Size = New System.Drawing.Size(202, 27)
        Me.Gram_priceTextBox.TabIndex = 5
        '
        'GramvalBindingSource
        '
        Me.GramvalBindingSource.DataMember = "Gram_val"
        Me.GramvalBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Gram_valTableAdapter
        '
        Me.Gram_valTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing

        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
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

        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Me.Gram_valTableAdapter
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Gram_valDataGridView
        '
        Me.Gram_valDataGridView.AllowUserToAddRows = False
        Me.Gram_valDataGridView.AllowUserToDeleteRows = False
        Me.Gram_valDataGridView.AutoGenerateColumns = False
        Me.Gram_valDataGridView.BackgroundColor = System.Drawing.Color.Linen
        Me.Gram_valDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Gram_valDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gram_valDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Gram_valDataGridView.DataSource = Me.Gram_valBindingSource
        Me.Gram_valDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Gram_valDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Gram_valDataGridView.Name = "Gram_valDataGridView"
        Me.Gram_valDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Gram_valDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Gram_valDataGridView.RowHeadersVisible = False
        Me.Gram_valDataGridView.RowHeadersWidth = 45
        Me.Gram_valDataGridView.Size = New System.Drawing.Size(245, 181)
        Me.Gram_valDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_gram"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_gram"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Gram_valu"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Gram_valu"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Gram_price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gram_price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Moccasin
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Chocolate
        Me.Button4.Location = New System.Drawing.Point(470, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 38)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "حفظ"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Moccasin
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Chocolate
        Me.Button5.Location = New System.Drawing.Point(371, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 38)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "جديد"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Moccasin
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Chocolate
        Me.Button6.Location = New System.Drawing.Point(273, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 38)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "حذف"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'gramval
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(551, 200)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Gram_valDataGridView)
        Me.Controls.Add(Gram_priceLabel)
        Me.Controls.Add(Me.Gram_priceTextBox)
        Me.Controls.Add(Gram_valuLabel)
        Me.Controls.Add(Me.Gram_valuTextBox)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "gramval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سعر الجرام"
        CType(Me.Gram_valBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GramvalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gram_valDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Gram_valBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gram_valTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Gram_valTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Gram_valuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gram_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GramvalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gram_valDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
