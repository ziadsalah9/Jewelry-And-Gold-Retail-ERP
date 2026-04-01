<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loc
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
        Dim Loc_idLabel As System.Windows.Forms.Label
        Dim Loc_nameLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Loc_nameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Loc_nameTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.loc_nameTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Loc_nameDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Loc_idTextBox = New System.Windows.Forms.TextBox()
        Me.Loc_nameTextBox = New System.Windows.Forms.TextBox()
        Loc_idLabel = New System.Windows.Forms.Label()
        Loc_nameLabel = New System.Windows.Forms.Label()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loc_nameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loc_nameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Loc_idLabel
        '
        Loc_idLabel.AutoSize = True
        Loc_idLabel.Location = New System.Drawing.Point(403, 161)
        Loc_idLabel.Name = "Loc_idLabel"
        Loc_idLabel.Size = New System.Drawing.Size(35, 13)
        Loc_idLabel.TabIndex = 2
        Loc_idLabel.Text = "loc id:"
        '
        'Loc_nameLabel
        '
        Loc_nameLabel.AutoSize = True
        Loc_nameLabel.Location = New System.Drawing.Point(403, 187)
        Loc_nameLabel.Name = "Loc_nameLabel"
        Loc_nameLabel.Size = New System.Drawing.Size(53, 13)
        Loc_nameLabel.TabIndex = 4
        Loc_nameLabel.Text = "loc name:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(872, 35)
        Me.TextBox1.TabIndex = 0
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Loc_nameBindingSource
        '
        Me.Loc_nameBindingSource.DataMember = "loc_name"
        Me.Loc_nameBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Loc_nameTableAdapter
        '
        Me.Loc_nameTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Me.Loc_nameTableAdapter
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
        'Loc_nameDataGridView
        '
        Me.Loc_nameDataGridView.AutoGenerateColumns = False
        Me.Loc_nameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Loc_nameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Loc_nameDataGridView.DataSource = Me.Loc_nameBindingSource
        Me.Loc_nameDataGridView.Location = New System.Drawing.Point(41, 112)
        Me.Loc_nameDataGridView.Name = "Loc_nameDataGridView"
        Me.Loc_nameDataGridView.Size = New System.Drawing.Size(300, 54)
        Me.Loc_nameDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "loc_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "loc_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "loc_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "loc_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Loc_idTextBox
        '
        Me.Loc_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loc_nameBindingSource, "loc_id", True))
        Me.Loc_idTextBox.Location = New System.Drawing.Point(462, 158)
        Me.Loc_idTextBox.Name = "Loc_idTextBox"
        Me.Loc_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Loc_idTextBox.TabIndex = 3
        '
        'Loc_nameTextBox
        '
        Me.Loc_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Loc_nameBindingSource, "loc_name", True))
        Me.Loc_nameTextBox.Location = New System.Drawing.Point(12, 53)
        Me.Loc_nameTextBox.Name = "Loc_nameTextBox"
        Me.Loc_nameTextBox.Size = New System.Drawing.Size(872, 20)
        Me.Loc_nameTextBox.TabIndex = 5
        '
        'loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1214, 444)
        Me.Controls.Add(Loc_idLabel)
        Me.Controls.Add(Me.Loc_idTextBox)
        Me.Controls.Add(Loc_nameLabel)
        Me.Controls.Add(Me.Loc_nameTextBox)
        Me.Controls.Add(Me.Loc_nameDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loc"
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loc_nameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loc_nameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Loc_nameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Loc_nameTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.loc_nameTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Loc_nameDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loc_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Loc_nameTextBox As System.Windows.Forms.TextBox
End Class
