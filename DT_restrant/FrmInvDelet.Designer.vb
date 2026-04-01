<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInvDelet
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
        Me.TabDelContr = New System.Windows.Forms.TabControl()
        Me.TabGold = New System.Windows.Forms.TabPage()
        Me.CmbInvRetr = New System.Windows.Forms.ComboBox()
        Me.btnInvRetr = New System.Windows.Forms.Button()
        Me.txtAdvSelGold = New System.Windows.Forms.TextBox()
        Me.BtnViwBayDateGold = New System.Windows.Forms.Button()
        Me.lblToGold = New System.Windows.Forms.Label()
        Me.lblFromGold = New System.Windows.Forms.Label()
        Me.BtnAdvSelGold = New System.Windows.Forms.Button()
        Me.BtnViwAllGold = New System.Windows.Forms.Button()
        Me.cmbAdvSelGold = New System.Windows.Forms.ComboBox()
        Me.DateToGold = New System.Windows.Forms.DateTimePicker()
        Me.DateFromGold = New System.Windows.Forms.DateTimePicker()
        Me.GridGold = New System.Windows.Forms.DataGridView()
        Me.colInvId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCastomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoldWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvAmon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabSilver = New System.Windows.Forms.TabPage()
        Me.TabDaimond = New System.Windows.Forms.TabPage()
        Me.TreeViewInv = New System.Windows.Forms.TreeView()
        Me.RdoSell = New System.Windows.Forms.RadioButton()
        Me.RdoBuy = New System.Windows.Forms.RadioButton()
        Me.TabDelContr.SuspendLayout()
        Me.TabGold.SuspendLayout()
        CType(Me.GridGold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabDelContr
        '
        Me.TabDelContr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabDelContr.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabDelContr.Controls.Add(Me.TabGold)
        Me.TabDelContr.Controls.Add(Me.TabSilver)
        Me.TabDelContr.Controls.Add(Me.TabDaimond)
        Me.TabDelContr.Font = New System.Drawing.Font("Cairo", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabDelContr.HotTrack = True
        Me.TabDelContr.ItemSize = New System.Drawing.Size(170, 44)
        Me.TabDelContr.Location = New System.Drawing.Point(2, 2)
        Me.TabDelContr.Name = "TabDelContr"
        Me.TabDelContr.Padding = New System.Drawing.Point(14, 6)
        Me.TabDelContr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabDelContr.RightToLeftLayout = True
        Me.TabDelContr.SelectedIndex = 0
        Me.TabDelContr.Size = New System.Drawing.Size(877, 657)
        Me.TabDelContr.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabDelContr.TabIndex = 0
        '
        'TabGold
        '
        Me.TabGold.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabGold.Controls.Add(Me.CmbInvRetr)
        Me.TabGold.Controls.Add(Me.btnInvRetr)
        Me.TabGold.Controls.Add(Me.txtAdvSelGold)
        Me.TabGold.Controls.Add(Me.BtnViwBayDateGold)
        Me.TabGold.Controls.Add(Me.lblToGold)
        Me.TabGold.Controls.Add(Me.lblFromGold)
        Me.TabGold.Controls.Add(Me.BtnAdvSelGold)
        Me.TabGold.Controls.Add(Me.BtnViwAllGold)
        Me.TabGold.Controls.Add(Me.cmbAdvSelGold)
        Me.TabGold.Controls.Add(Me.DateToGold)
        Me.TabGold.Controls.Add(Me.DateFromGold)
        Me.TabGold.Controls.Add(Me.GridGold)
        Me.TabGold.Location = New System.Drawing.Point(4, 48)
        Me.TabGold.Name = "TabGold"
        Me.TabGold.Padding = New System.Windows.Forms.Padding(12)
        Me.TabGold.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabGold.Size = New System.Drawing.Size(869, 605)
        Me.TabGold.TabIndex = 0
        Me.TabGold.Text = "ذهب"
        '
        'CmbInvRetr
        '
        Me.CmbInvRetr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInvRetr.FormattingEnabled = True
        Me.CmbInvRetr.Location = New System.Drawing.Point(3, 43)
        Me.CmbInvRetr.Name = "CmbInvRetr"
        Me.CmbInvRetr.Size = New System.Drawing.Size(159, 37)
        Me.CmbInvRetr.TabIndex = 11
        '
        'btnInvRetr
        '
        Me.btnInvRetr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInvRetr.Location = New System.Drawing.Point(3, 2)
        Me.btnInvRetr.Name = "btnInvRetr"
        Me.btnInvRetr.Size = New System.Drawing.Size(159, 38)
        Me.btnInvRetr.TabIndex = 10
        Me.btnInvRetr.Text = "btnInvRetr"
        Me.btnInvRetr.UseVisualStyleBackColor = True
        '
        'txtAdvSelGold
        '
        Me.txtAdvSelGold.Location = New System.Drawing.Point(573, 45)
        Me.txtAdvSelGold.Name = "txtAdvSelGold"
        Me.txtAdvSelGold.Size = New System.Drawing.Size(218, 35)
        Me.txtAdvSelGold.TabIndex = 9
        '
        'BtnViwBayDateGold
        '
        Me.BtnViwBayDateGold.Location = New System.Drawing.Point(162, 0)
        Me.BtnViwBayDateGold.Name = "BtnViwBayDateGold"
        Me.BtnViwBayDateGold.Size = New System.Drawing.Size(87, 80)
        Me.BtnViwBayDateGold.TabIndex = 8
        Me.BtnViwBayDateGold.Text = "Date"
        Me.BtnViwBayDateGold.UseVisualStyleBackColor = True
        '
        'lblToGold
        '
        Me.lblToGold.Location = New System.Drawing.Point(425, 45)
        Me.lblToGold.Name = "lblToGold"
        Me.lblToGold.Size = New System.Drawing.Size(65, 35)
        Me.lblToGold.TabIndex = 7
        Me.lblToGold.Text = "to"
        Me.lblToGold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFromGold
        '
        Me.lblFromGold.Location = New System.Drawing.Point(425, 3)
        Me.lblFromGold.Name = "lblFromGold"
        Me.lblFromGold.Size = New System.Drawing.Size(65, 35)
        Me.lblFromGold.TabIndex = 6
        Me.lblFromGold.Text = "from"
        Me.lblFromGold.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnAdvSelGold
        '
        Me.BtnAdvSelGold.Location = New System.Drawing.Point(492, 0)
        Me.BtnAdvSelGold.Name = "BtnAdvSelGold"
        Me.BtnAdvSelGold.Size = New System.Drawing.Size(81, 80)
        Me.BtnAdvSelGold.TabIndex = 5
        Me.BtnAdvSelGold.Text = "Button1"
        Me.BtnAdvSelGold.UseVisualStyleBackColor = True
        '
        'BtnViwAllGold
        '
        Me.BtnViwAllGold.Location = New System.Drawing.Point(791, 0)
        Me.BtnViwAllGold.Name = "BtnViwAllGold"
        Me.BtnViwAllGold.Size = New System.Drawing.Size(76, 80)
        Me.BtnViwAllGold.TabIndex = 4
        Me.BtnViwAllGold.Text = "ViwAll"
        Me.BtnViwAllGold.UseVisualStyleBackColor = True
        '
        'cmbAdvSelGold
        '
        Me.cmbAdvSelGold.FormattingEnabled = True
        Me.cmbAdvSelGold.Location = New System.Drawing.Point(573, 3)
        Me.cmbAdvSelGold.Name = "cmbAdvSelGold"
        Me.cmbAdvSelGold.Size = New System.Drawing.Size(218, 37)
        Me.cmbAdvSelGold.TabIndex = 3
        '
        'DateToGold
        '
        Me.DateToGold.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateToGold.Location = New System.Drawing.Point(250, 45)
        Me.DateToGold.Name = "DateToGold"
        Me.DateToGold.Size = New System.Drawing.Size(172, 35)
        Me.DateToGold.TabIndex = 2
        '
        'DateFromGold
        '
        Me.DateFromGold.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateFromGold.Location = New System.Drawing.Point(250, 3)
        Me.DateFromGold.Name = "DateFromGold"
        Me.DateFromGold.Size = New System.Drawing.Size(172, 35)
        Me.DateFromGold.TabIndex = 1
        '
        'GridGold
        '
        Me.GridGold.AllowUserToAddRows = False
        Me.GridGold.AllowUserToDeleteRows = False
        Me.GridGold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridGold.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvId, Me.colCastomId, Me.colCastomName, Me.colGoldWeight, Me.colInvAmon, Me.colDate})
        Me.GridGold.Location = New System.Drawing.Point(3, 80)
        Me.GridGold.Name = "GridGold"
        Me.GridGold.ReadOnly = True
        Me.GridGold.Size = New System.Drawing.Size(864, 522)
        Me.GridGold.TabIndex = 0
        '
        'colInvId
        '
        Me.colInvId.HeaderText = "nvId"
        Me.colInvId.Name = "colInvId"
        Me.colInvId.ReadOnly = True
        Me.colInvId.Width = 50
        '
        'colCastomId
        '
        Me.colCastomId.HeaderText = "CastomId"
        Me.colCastomId.Name = "colCastomId"
        Me.colCastomId.ReadOnly = True
        Me.colCastomId.Width = 250
        '
        'colCastomName
        '
        Me.colCastomName.HeaderText = "CastomName"
        Me.colCastomName.Name = "colCastomName"
        Me.colCastomName.ReadOnly = True
        Me.colCastomName.Width = 300
        '
        'colGoldWeight
        '
        Me.colGoldWeight.HeaderText = "GoldWeight"
        Me.colGoldWeight.Name = "colGoldWeight"
        Me.colGoldWeight.ReadOnly = True
        Me.colGoldWeight.Width = 50
        '
        'colInvAmon
        '
        Me.colInvAmon.HeaderText = "InvAmon"
        Me.colInvAmon.Name = "colInvAmon"
        Me.colInvAmon.ReadOnly = True
        Me.colInvAmon.Width = 50
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.Width = 250
        '
        'TabSilver
        '
        Me.TabSilver.BackColor = System.Drawing.Color.Silver
        Me.TabSilver.Location = New System.Drawing.Point(4, 48)
        Me.TabSilver.Name = "TabSilver"
        Me.TabSilver.Padding = New System.Windows.Forms.Padding(12)
        Me.TabSilver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabSilver.Size = New System.Drawing.Size(869, 605)
        Me.TabSilver.TabIndex = 1
        Me.TabSilver.Text = "فضة"
        '
        'TabDaimond
        '
        Me.TabDaimond.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TabDaimond.Location = New System.Drawing.Point(4, 48)
        Me.TabDaimond.Name = "TabDaimond"
        Me.TabDaimond.Padding = New System.Windows.Forms.Padding(12)
        Me.TabDaimond.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabDaimond.Size = New System.Drawing.Size(869, 605)
        Me.TabDaimond.TabIndex = 2
        Me.TabDaimond.Text = "الماس"
        '
        'TreeViewInv
        '
        Me.TreeViewInv.BackColor = System.Drawing.Color.LightCyan
        Me.TreeViewInv.Font = New System.Drawing.Font("Cairo", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TreeViewInv.Location = New System.Drawing.Point(879, 32)
        Me.TreeViewInv.Name = "TreeViewInv"
        Me.TreeViewInv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TreeViewInv.RightToLeftLayout = True
        Me.TreeViewInv.Size = New System.Drawing.Size(326, 623)
        Me.TreeViewInv.TabIndex = 1
        '
        'RdoSell
        '
        Me.RdoSell.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RdoSell.Font = New System.Drawing.Font("Cairo", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RdoSell.Location = New System.Drawing.Point(1044, 2)
        Me.RdoSell.Name = "RdoSell"
        Me.RdoSell.Size = New System.Drawing.Size(144, 24)
        Me.RdoSell.TabIndex = 2
        Me.RdoSell.TabStop = True
        Me.RdoSell.Text = "بيع"
        Me.RdoSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdoSell.UseVisualStyleBackColor = True
        '
        'RdoBuy
        '
        Me.RdoBuy.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RdoBuy.Font = New System.Drawing.Font("Cairo", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RdoBuy.Location = New System.Drawing.Point(900, 2)
        Me.RdoBuy.Name = "RdoBuy"
        Me.RdoBuy.Size = New System.Drawing.Size(144, 24)
        Me.RdoBuy.TabIndex = 3
        Me.RdoBuy.TabStop = True
        Me.RdoBuy.Text = "شراء"
        Me.RdoBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdoBuy.UseVisualStyleBackColor = True
        '
        'FrmInvDelet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 657)
        Me.Controls.Add(Me.RdoBuy)
        Me.Controls.Add(Me.RdoSell)
        Me.Controls.Add(Me.TreeViewInv)
        Me.Controls.Add(Me.TabDelContr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInvDelet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInvDelet"
        Me.TabDelContr.ResumeLayout(False)
        Me.TabGold.ResumeLayout(False)
        Me.TabGold.PerformLayout()
        CType(Me.GridGold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabDelContr As TabControl
    Friend WithEvents TabGold As TabPage
    Friend WithEvents TabSilver As TabPage
    Friend WithEvents TabDaimond As TabPage
    Friend WithEvents GridGold As DataGridView
    Friend WithEvents TreeViewInv As TreeView
    Friend WithEvents RdoSell As RadioButton
    Friend WithEvents RdoBuy As RadioButton
    Friend WithEvents lblToGold As Label
    Friend WithEvents lblFromGold As Label
    Friend WithEvents BtnAdvSelGold As Button
    Friend WithEvents BtnViwAllGold As Button
    Friend WithEvents cmbAdvSelGold As ComboBox
    Friend WithEvents DateToGold As DateTimePicker
    Friend WithEvents DateFromGold As DateTimePicker
    Friend WithEvents BtnViwBayDateGold As Button
    Friend WithEvents txtAdvSelGold As TextBox
    Friend WithEvents CmbInvRetr As ComboBox
    Friend WithEvents btnInvRetr As Button
    Friend WithEvents colInvId As DataGridViewTextBoxColumn
    Friend WithEvents colCastomId As DataGridViewTextBoxColumn
    Friend WithEvents colCastomName As DataGridViewTextBoxColumn
    Friend WithEvents colGoldWeight As DataGridViewTextBoxColumn
    Friend WithEvents colInvAmon As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
End Class
