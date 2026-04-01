<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoneAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StoneAdd))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CANTRY_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Gram_priceLabel = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colStoneID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStoneName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Black
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = Global.DT_restrant.My.Resources.Resources.Add
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(169, 8)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(142, 39)
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
        Me.btnSave.Location = New System.Drawing.Point(5, 8)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(142, 39)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'CANTRY_nameTextBox
        '
        Me.CANTRY_nameTextBox.Location = New System.Drawing.Point(5, 54)
        Me.CANTRY_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CANTRY_nameTextBox.MaxLength = 100
        Me.CANTRY_nameTextBox.Name = "CANTRY_nameTextBox"
        Me.CANTRY_nameTextBox.Size = New System.Drawing.Size(199, 27)
        Me.CANTRY_nameTextBox.TabIndex = 52
        '
        'Gram_priceLabel
        '
        Me.Gram_priceLabel.AutoEllipsis = True
        Me.Gram_priceLabel.Location = New System.Drawing.Point(212, 53)
        Me.Gram_priceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gram_priceLabel.Name = "Gram_priceLabel"
        Me.Gram_priceLabel.Size = New System.Drawing.Size(102, 27)
        Me.Gram_priceLabel.TabIndex = 53
        Me.Gram_priceLabel.Text = "نوع الحجر"
        Me.Gram_priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Gram_priceLabel.UseWaitCursor = True
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colStoneID, Me.colStoneName})
        Me.Grid.Location = New System.Drawing.Point(5, 84)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.Size = New System.Drawing.Size(309, 358)
        Me.Grid.TabIndex = 58
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "Del"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDelete.Width = 40
        '
        'colStoneID
        '
        Me.colStoneID.HeaderText = "StoneID"
        Me.colStoneID.Name = "colStoneID"
        Me.colStoneID.ReadOnly = True
        Me.colStoneID.Visible = False
        Me.colStoneID.Width = 80
        '
        'colStoneName
        '
        Me.colStoneName.HeaderText = "StoneName"
        Me.colStoneName.Name = "colStoneName"
        Me.colStoneName.ReadOnly = True
        Me.colStoneName.Width = 280
        '
        'StoneAdd
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(317, 445)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CANTRY_nameTextBox)
        Me.Controls.Add(Me.Gram_priceLabel)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StoneAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "أنواع الأحجار"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CANTRY_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Gram_priceLabel As System.Windows.Forms.Label
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colStoneID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStoneName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
