<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransfersItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransfersItem))
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.lblDtName = New System.Windows.Forms.Label()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colBranchPublic = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchServerNa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBranchPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnFindServer = New System.Windows.Forms.Button()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cmbDtName = New System.Windows.Forms.ComboBox()
        Me.cmbServerName = New System.Windows.Forms.ComboBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnTransSelect = New System.Windows.Forms.Button()
        Me.BtnSelectAll = New System.Windows.Forms.Button()
        Me.BtnViwData = New System.Windows.Forms.Button()
        Me.RadoDia = New System.Windows.Forms.RadioButton()
        Me.Radosilver = New System.Windows.Forms.RadioButton()
        Me.RadoGold = New System.Windows.Forms.RadioButton()
        Me.TrnsfGrid = New System.Windows.Forms.DataGridView()
        Me.colTrans = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colBarCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGram_valu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFO_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFO_gram = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate_care = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastEditDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coluserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPurInvNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrpTo = New System.Windows.Forms.GroupBox()
        Me.ComBoxTo = New System.Windows.Forms.ComboBox()
        Me.GrpFrom = New System.Windows.Forms.GroupBox()
        Me.ComBoxFrom = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.txtFrmPassword = New System.Windows.Forms.TextBox()
        Me.TabPage2.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.TrnsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTo.SuspendLayout()
        Me.GrpFrom.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.lblUser)
        Me.TabPage2.Controls.Add(Me.lblShopName)
        Me.TabPage2.Controls.Add(Me.lblDtName)
        Me.TabPage2.Controls.Add(Me.lblServerName)
        Me.TabPage2.Controls.Add(Me.lblPassword)
        Me.TabPage2.Controls.Add(Me.BtnSave)
        Me.TabPage2.Controls.Add(Me.Grid)
        Me.TabPage2.Controls.Add(Me.BtnFindServer)
        Me.TabPage2.Controls.Add(Me.txtShopName)
        Me.TabPage2.Controls.Add(Me.txtPassword)
        Me.TabPage2.Controls.Add(Me.txtUser)
        Me.TabPage2.Controls.Add(Me.cmbDtName)
        Me.TabPage2.Controls.Add(Me.cmbServerName)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage2.Size = New System.Drawing.Size(863, 282)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "المحلات"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(783, 62)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(74, 27)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "lblUser"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblShopName
        '
        Me.lblShopName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblShopName.Location = New System.Drawing.Point(783, 202)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblShopName.Size = New System.Drawing.Size(74, 27)
        Me.lblShopName.TabIndex = 12
        Me.lblShopName.Text = "lblShopName"
        Me.lblShopName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDtName
        '
        Me.lblDtName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDtName.Location = New System.Drawing.Point(783, 167)
        Me.lblDtName.Name = "lblDtName"
        Me.lblDtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDtName.Size = New System.Drawing.Size(74, 27)
        Me.lblDtName.TabIndex = 11
        Me.lblDtName.Text = "lblDtName"
        Me.lblDtName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblServerName
        '
        Me.lblServerName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblServerName.Location = New System.Drawing.Point(783, 132)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblServerName.Size = New System.Drawing.Size(74, 27)
        Me.lblServerName.TabIndex = 10
        Me.lblServerName.Text = "lblServerName"
        Me.lblServerName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.Location = New System.Drawing.Point(783, 97)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(74, 27)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "lblPassword"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskGreen
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(566, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(154, 50)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Grid
        '
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDelete, Me.colBranchPublic, Me.colBranchDT, Me.colBranchServerNa, Me.colBranchUser, Me.colBranchPassword})
        Me.Grid.Location = New System.Drawing.Point(0, 3)
        Me.Grid.Name = "Grid"
        Me.Grid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Grid.Size = New System.Drawing.Size(565, 228)
        Me.Grid.TabIndex = 0
        '
        'colDelete
        '
        Me.colDelete.HeaderText = "colDelete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.Width = 50
        '
        'colBranchPublic
        '
        Me.colBranchPublic.HeaderText = "colBranchPublic"
        Me.colBranchPublic.Name = "colBranchPublic"
        Me.colBranchPublic.Width = 130
        '
        'colBranchDT
        '
        Me.colBranchDT.HeaderText = "colBranchDT"
        Me.colBranchDT.Name = "colBranchDT"
        Me.colBranchDT.Width = 130
        '
        'colBranchServerNa
        '
        Me.colBranchServerNa.HeaderText = "colBranchServerNa"
        Me.colBranchServerNa.Name = "colBranchServerNa"
        Me.colBranchServerNa.Width = 130
        '
        'colBranchUser
        '
        Me.colBranchUser.HeaderText = "colBranchUser"
        Me.colBranchUser.Name = "colBranchUser"
        Me.colBranchUser.Width = 130
        '
        'colBranchPassword
        '
        Me.colBranchPassword.HeaderText = "colBranchPassword"
        Me.colBranchPassword.Name = "colBranchPassword"
        Me.colBranchPassword.Width = 130
        '
        'BtnFindServer
        '
        Me.BtnFindServer.BackColor = System.Drawing.Color.DarkGray
        Me.BtnFindServer.Image = Global.DT_restrant.My.Resources.Resources.Search
        Me.BtnFindServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFindServer.Location = New System.Drawing.Point(726, 6)
        Me.BtnFindServer.Name = "BtnFindServer"
        Me.BtnFindServer.Size = New System.Drawing.Size(138, 50)
        Me.BtnFindServer.TabIndex = 6
        Me.BtnFindServer.Text = "BtnFindServer"
        Me.BtnFindServer.UseVisualStyleBackColor = False
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(566, 202)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(211, 27)
        Me.txtShopName.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(566, 97)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(211, 27)
        Me.txtPassword.TabIndex = 4
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(566, 62)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(211, 27)
        Me.txtUser.TabIndex = 3
        '
        'cmbDtName
        '
        Me.cmbDtName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDtName.FormattingEnabled = True
        Me.cmbDtName.Location = New System.Drawing.Point(566, 167)
        Me.cmbDtName.Name = "cmbDtName"
        Me.cmbDtName.Size = New System.Drawing.Size(211, 27)
        Me.cmbDtName.TabIndex = 2
        '
        'cmbServerName
        '
        Me.cmbServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServerName.FormattingEnabled = True
        Me.cmbServerName.Location = New System.Drawing.Point(566, 132)
        Me.cmbServerName.Name = "cmbServerName"
        Me.cmbServerName.Size = New System.Drawing.Size(211, 27)
        Me.cmbServerName.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.BtnTransSelect)
        Me.TabPage1.Controls.Add(Me.BtnSelectAll)
        Me.TabPage1.Controls.Add(Me.BtnViwData)
        Me.TabPage1.Controls.Add(Me.RadoDia)
        Me.TabPage1.Controls.Add(Me.Radosilver)
        Me.TabPage1.Controls.Add(Me.RadoGold)
        Me.TabPage1.Controls.Add(Me.TrnsfGrid)
        Me.TabPage1.Controls.Add(Me.GrpTo)
        Me.TabPage1.Controls.Add(Me.GrpFrom)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(863, 282)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "التحويلات"
        '
        'BtnTransSelect
        '
        Me.BtnTransSelect.Image = Global.DT_restrant.My.Resources.Resources.paper_plane__plus
        Me.BtnTransSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTransSelect.Location = New System.Drawing.Point(731, 228)
        Me.BtnTransSelect.Name = "BtnTransSelect"
        Me.BtnTransSelect.Size = New System.Drawing.Size(126, 46)
        Me.BtnTransSelect.TabIndex = 7
        Me.BtnTransSelect.Text = "تحويل المحدد"
        Me.BtnTransSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTransSelect.UseVisualStyleBackColor = True
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Image = Global.DT_restrant.My.Resources.Resources.Filter
        Me.BtnSelectAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelectAll.Location = New System.Drawing.Point(731, 182)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(126, 46)
        Me.BtnSelectAll.TabIndex = 6
        Me.BtnSelectAll.Text = "تحديد الكل"
        Me.BtnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectAll.UseVisualStyleBackColor = True
        '
        'BtnViwData
        '
        Me.BtnViwData.Image = Global.DT_restrant.My.Resources.Resources.ServerClient
        Me.BtnViwData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnViwData.Location = New System.Drawing.Point(731, 136)
        Me.BtnViwData.Name = "BtnViwData"
        Me.BtnViwData.Size = New System.Drawing.Size(126, 46)
        Me.BtnViwData.TabIndex = 1
        Me.BtnViwData.Text = "عرض الاصناف"
        Me.BtnViwData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnViwData.UseVisualStyleBackColor = True
        '
        'RadoDia
        '
        Me.RadoDia.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadoDia.Location = New System.Drawing.Point(731, 114)
        Me.RadoDia.Name = "RadoDia"
        Me.RadoDia.Size = New System.Drawing.Size(126, 26)
        Me.RadoDia.TabIndex = 5
        Me.RadoDia.TabStop = True
        Me.RadoDia.Text = "الماس"
        Me.RadoDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadoDia.UseVisualStyleBackColor = True
        '
        'Radosilver
        '
        Me.Radosilver.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Radosilver.Location = New System.Drawing.Point(731, 88)
        Me.Radosilver.Name = "Radosilver"
        Me.Radosilver.Size = New System.Drawing.Size(126, 26)
        Me.Radosilver.TabIndex = 4
        Me.Radosilver.TabStop = True
        Me.Radosilver.Text = "فضه"
        Me.Radosilver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Radosilver.UseVisualStyleBackColor = True
        '
        'RadoGold
        '
        Me.RadoGold.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadoGold.Location = New System.Drawing.Point(731, 62)
        Me.RadoGold.Name = "RadoGold"
        Me.RadoGold.Size = New System.Drawing.Size(126, 26)
        Me.RadoGold.TabIndex = 3
        Me.RadoGold.TabStop = True
        Me.RadoGold.Text = "ذهب"
        Me.RadoGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadoGold.UseVisualStyleBackColor = True
        '
        'TrnsfGrid
        '
        Me.TrnsfGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrnsfGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTrans, Me.colSelect, Me.colBarCode, Me.colGram_valu, Me.colFO_name, Me.colFO_gram, Me.colQty, Me.coldate_care, Me.colLastEditDate, Me.coluserID, Me.colPurInvNumber})
        Me.TrnsfGrid.Location = New System.Drawing.Point(6, 62)
        Me.TrnsfGrid.Name = "TrnsfGrid"
        Me.TrnsfGrid.Size = New System.Drawing.Size(719, 217)
        Me.TrnsfGrid.TabIndex = 2
        '
        'colTrans
        '
        Me.colTrans.HeaderText = "colTrans"
        Me.colTrans.Name = "colTrans"
        Me.colTrans.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colTrans.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colTrans.Width = 40
        '
        'colSelect
        '
        Me.colSelect.HeaderText = "colSelect"
        Me.colSelect.Name = "colSelect"
        Me.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSelect.Width = 40
        '
        'colBarCode
        '
        Me.colBarCode.HeaderText = "colBarCode"
        Me.colBarCode.Name = "colBarCode"
        '
        'colGram_valu
        '
        Me.colGram_valu.HeaderText = "colGram_valu"
        Me.colGram_valu.Name = "colGram_valu"
        '
        'colFO_name
        '
        Me.colFO_name.HeaderText = "colFO_name"
        Me.colFO_name.Name = "colFO_name"
        '
        'colFO_gram
        '
        Me.colFO_gram.HeaderText = "colFO_gram"
        Me.colFO_gram.Name = "colFO_gram"
        '
        'colQty
        '
        Me.colQty.HeaderText = "colQty"
        Me.colQty.Name = "colQty"
        '
        'coldate_care
        '
        Me.coldate_care.HeaderText = "coldate_care"
        Me.coldate_care.Name = "coldate_care"
        '
        'colLastEditDate
        '
        Me.colLastEditDate.HeaderText = "colLastEditDate"
        Me.colLastEditDate.Name = "colLastEditDate"
        '
        'coluserID
        '
        Me.coluserID.HeaderText = "coluserID"
        Me.coluserID.Name = "coluserID"
        '
        'colPurInvNumber
        '
        Me.colPurInvNumber.HeaderText = "colPurInvNumber"
        Me.colPurInvNumber.Name = "colPurInvNumber"
        '
        'GrpTo
        '
        Me.GrpTo.Controls.Add(Me.ComBoxTo)
        Me.GrpTo.Location = New System.Drawing.Point(6, 4)
        Me.GrpTo.Name = "GrpTo"
        Me.GrpTo.Size = New System.Drawing.Size(440, 57)
        Me.GrpTo.TabIndex = 1
        Me.GrpTo.TabStop = False
        Me.GrpTo.Text = "تحويل الي"
        '
        'ComBoxTo
        '
        Me.ComBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxTo.FormattingEnabled = True
        Me.ComBoxTo.Location = New System.Drawing.Point(6, 19)
        Me.ComBoxTo.Name = "ComBoxTo"
        Me.ComBoxTo.Size = New System.Drawing.Size(428, 27)
        Me.ComBoxTo.TabIndex = 0
        '
        'GrpFrom
        '
        Me.GrpFrom.Controls.Add(Me.ComBoxFrom)
        Me.GrpFrom.Location = New System.Drawing.Point(452, 4)
        Me.GrpFrom.Name = "GrpFrom"
        Me.GrpFrom.Size = New System.Drawing.Size(411, 57)
        Me.GrpFrom.TabIndex = 0
        Me.GrpFrom.TabStop = False
        Me.GrpFrom.Text = "تحويل من"
        '
        'ComBoxFrom
        '
        Me.ComBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoxFrom.FormattingEnabled = True
        Me.ComBoxFrom.Location = New System.Drawing.Point(6, 21)
        Me.ComBoxFrom.Name = "ComBoxFrom"
        Me.ComBoxFrom.Size = New System.Drawing.Size(401, 27)
        Me.ComBoxFrom.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(871, 314)
        Me.TabControl1.TabIndex = 2
        '
        'txtFrmPassword
        '
        Me.txtFrmPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtFrmPassword.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtFrmPassword.Location = New System.Drawing.Point(2, 317)
        Me.txtFrmPassword.Name = "txtFrmPassword"
        Me.txtFrmPassword.Size = New System.Drawing.Size(871, 20)
        Me.txtFrmPassword.TabIndex = 3
        Me.txtFrmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtFrmPassword.UseSystemPasswordChar = True
        '
        'TransfersItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(875, 339)
        Me.Controls.Add(Me.txtFrmPassword)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TransfersItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التحويلات"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TrnsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTo.ResumeLayout(False)
        Me.GrpFrom.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblUser As Label
    Friend WithEvents lblShopName As Label
    Friend WithEvents lblDtName As Label
    Friend WithEvents lblServerName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents Grid As DataGridView
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colBranchPublic As DataGridViewTextBoxColumn
    Friend WithEvents colBranchDT As DataGridViewTextBoxColumn
    Friend WithEvents colBranchServerNa As DataGridViewTextBoxColumn
    Friend WithEvents colBranchUser As DataGridViewTextBoxColumn
    Friend WithEvents colBranchPassword As DataGridViewTextBoxColumn
    Friend WithEvents BtnFindServer As Button
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cmbDtName As ComboBox
    Friend WithEvents cmbServerName As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GrpTo As GroupBox
    Friend WithEvents ComBoxTo As ComboBox
    Friend WithEvents GrpFrom As GroupBox
    Friend WithEvents ComBoxFrom As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents txtFrmPassword As TextBox
    Friend WithEvents TrnsfGrid As DataGridView
    Friend WithEvents BtnViwData As Button
    Friend WithEvents BtnTransSelect As Button
    Friend WithEvents BtnSelectAll As Button
    Friend WithEvents RadoDia As RadioButton
    Friend WithEvents Radosilver As RadioButton
    Friend WithEvents RadoGold As RadioButton
    Friend WithEvents colTrans As DataGridViewButtonColumn
    Friend WithEvents colSelect As DataGridViewCheckBoxColumn
    Friend WithEvents colBarCode As DataGridViewTextBoxColumn
    Friend WithEvents colGram_valu As DataGridViewTextBoxColumn
    Friend WithEvents colFO_name As DataGridViewTextBoxColumn
    Friend WithEvents colFO_gram As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents coldate_care As DataGridViewTextBoxColumn
    Friend WithEvents colLastEditDate As DataGridViewTextBoxColumn
    Friend WithEvents coluserID As DataGridViewTextBoxColumn
    Friend WithEvents colPurInvNumber As DataGridViewTextBoxColumn
End Class
