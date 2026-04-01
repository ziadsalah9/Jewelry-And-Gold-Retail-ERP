<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChangeInvoiceNumber
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
        Me.grpInvoiceType = New System.Windows.Forms.GroupBox()
        Me.radDiamondBuy = New System.Windows.Forms.RadioButton()
        Me.radDiamondSell = New System.Windows.Forms.RadioButton()
        Me.radBuyInvoice = New System.Windows.Forms.RadioButton()
        Me.radSellInvoice = New System.Windows.Forms.RadioButton()
        Me.grpInvoiceList = New System.Windows.Forms.GroupBox()
        Me.lstInvoices = New System.Windows.Forms.ListBox()
        Me.pnlListControls = New System.Windows.Forms.Panel()
        Me.lblInvoiceCount = New System.Windows.Forms.Label()
        Me.numInvoiceCount = New System.Windows.Forms.NumericUpDown()
        Me.btnLoadInvoices = New System.Windows.Forms.Button()
        Me.lblOldInvoiceNo = New System.Windows.Forms.Label()
        Me.txtOldInvoiceNo = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblNewInvoiceNo = New System.Windows.Forms.Label()
        Me.txtNewInvoiceNo = New System.Windows.Forms.TextBox()
        Me.grpInvoiceDetails = New System.Windows.Forms.GroupBox()
        Me.txtInvoiceDetails = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpInvoiceType.SuspendLayout()
        Me.grpInvoiceList.SuspendLayout()
        Me.pnlListControls.SuspendLayout()
        CType(Me.numInvoiceCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoiceDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInvoiceType
        '
        Me.grpInvoiceType.Controls.Add(Me.radDiamondBuy)
        Me.grpInvoiceType.Controls.Add(Me.radDiamondSell)
        Me.grpInvoiceType.Controls.Add(Me.radBuyInvoice)
        Me.grpInvoiceType.Controls.Add(Me.radSellInvoice)
        Me.grpInvoiceType.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpInvoiceType.Location = New System.Drawing.Point(9, 10)
        Me.grpInvoiceType.Margin = New System.Windows.Forms.Padding(2)
        Me.grpInvoiceType.Name = "grpInvoiceType"
        Me.grpInvoiceType.Padding = New System.Windows.Forms.Padding(2)
        Me.grpInvoiceType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpInvoiceType.Size = New System.Drawing.Size(291, 106)
        Me.grpInvoiceType.TabIndex = 0
        Me.grpInvoiceType.TabStop = False
        Me.grpInvoiceType.Text = "نوع الفاتورة - Invoice Type"
        '
        'radDiamondBuy
        '
        Me.radDiamondBuy.AutoSize = True
        Me.radDiamondBuy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.radDiamondBuy.Location = New System.Drawing.Point(9, 79)
        Me.radDiamondBuy.Margin = New System.Windows.Forms.Padding(2)
        Me.radDiamondBuy.Name = "radDiamondBuy"
        Me.radDiamondBuy.Size = New System.Drawing.Size(211, 21)
        Me.radDiamondBuy.TabIndex = 3
        Me.radDiamondBuy.Text = "فاتورة شراء ألماس - Diamond Buy"
        Me.radDiamondBuy.UseVisualStyleBackColor = True
        '
        'radDiamondSell
        '
        Me.radDiamondSell.AutoSize = True
        Me.radDiamondSell.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.radDiamondSell.Location = New System.Drawing.Point(12, 59)
        Me.radDiamondSell.Margin = New System.Windows.Forms.Padding(2)
        Me.radDiamondSell.Name = "radDiamondSell"
        Me.radDiamondSell.Size = New System.Drawing.Size(205, 21)
        Me.radDiamondSell.TabIndex = 2
        Me.radDiamondSell.Text = "فاتورة بيع ألماس - Diamond Sell"
        Me.radDiamondSell.UseVisualStyleBackColor = True
        '
        'radBuyInvoice
        '
        Me.radBuyInvoice.AutoSize = True
        Me.radBuyInvoice.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.radBuyInvoice.Location = New System.Drawing.Point(9, 39)
        Me.radBuyInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radBuyInvoice.Name = "radBuyInvoice"
        Me.radBuyInvoice.Size = New System.Drawing.Size(181, 21)
        Me.radBuyInvoice.TabIndex = 1
        Me.radBuyInvoice.Text = "فاتورة شراء ذهب - Gold Buy"
        Me.radBuyInvoice.UseVisualStyleBackColor = True
        '
        'radSellInvoice
        '
        Me.radSellInvoice.AutoSize = True
        Me.radSellInvoice.Checked = True
        Me.radSellInvoice.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.radSellInvoice.Location = New System.Drawing.Point(12, 18)
        Me.radSellInvoice.Margin = New System.Windows.Forms.Padding(2)
        Me.radSellInvoice.Name = "radSellInvoice"
        Me.radSellInvoice.Size = New System.Drawing.Size(175, 21)
        Me.radSellInvoice.TabIndex = 0
        Me.radSellInvoice.TabStop = True
        Me.radSellInvoice.Text = "فاتورة بيع ذهب - Gold Sell"
        Me.radSellInvoice.UseVisualStyleBackColor = True
        '
        'grpInvoiceList
        '
        Me.grpInvoiceList.Controls.Add(Me.lstInvoices)
        Me.grpInvoiceList.Controls.Add(Me.pnlListControls)
        Me.grpInvoiceList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpInvoiceList.Location = New System.Drawing.Point(9, 122)
        Me.grpInvoiceList.Margin = New System.Windows.Forms.Padding(2)
        Me.grpInvoiceList.Name = "grpInvoiceList"
        Me.grpInvoiceList.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInvoiceList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpInvoiceList.Size = New System.Drawing.Size(291, 436)
        Me.grpInvoiceList.TabIndex = 1
        Me.grpInvoiceList.TabStop = False
        Me.grpInvoiceList.Text = "📋 قائمة الفواتير - Invoices"
        '
        'lstInvoices
        '
        Me.lstInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstInvoices.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lstInvoices.FormattingEnabled = True
        Me.lstInvoices.ItemHeight = 18
        Me.lstInvoices.Location = New System.Drawing.Point(4, 72)
        Me.lstInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.lstInvoices.Name = "lstInvoices"
        Me.lstInvoices.Size = New System.Drawing.Size(283, 360)
        Me.lstInvoices.TabIndex = 0
        '
        'pnlListControls
        '
        Me.pnlListControls.Controls.Add(Me.lblInvoiceCount)
        Me.pnlListControls.Controls.Add(Me.numInvoiceCount)
        Me.pnlListControls.Controls.Add(Me.btnLoadInvoices)
        Me.pnlListControls.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlListControls.Location = New System.Drawing.Point(4, 22)
        Me.pnlListControls.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlListControls.Name = "pnlListControls"
        Me.pnlListControls.Size = New System.Drawing.Size(283, 50)
        Me.pnlListControls.TabIndex = 1
        '
        'lblInvoiceCount
        '
        Me.lblInvoiceCount.AutoSize = True
        Me.lblInvoiceCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInvoiceCount.Location = New System.Drawing.Point(105, 6)
        Me.lblInvoiceCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInvoiceCount.Name = "lblInvoiceCount"
        Me.lblInvoiceCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInvoiceCount.Size = New System.Drawing.Size(85, 15)
        Me.lblInvoiceCount.TabIndex = 0
        Me.lblInvoiceCount.Text = "عدد الفواتير - #:"
        '
        'numInvoiceCount
        '
        Me.numInvoiceCount.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.numInvoiceCount.Location = New System.Drawing.Point(98, 24)
        Me.numInvoiceCount.Margin = New System.Windows.Forms.Padding(2)
        Me.numInvoiceCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numInvoiceCount.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numInvoiceCount.Name = "numInvoiceCount"
        Me.numInvoiceCount.Size = New System.Drawing.Size(75, 27)
        Me.numInvoiceCount.TabIndex = 1
        Me.numInvoiceCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numInvoiceCount.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'btnLoadInvoices
        '
        Me.btnLoadInvoices.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLoadInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadInvoices.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoadInvoices.ForeColor = System.Drawing.Color.White
        Me.btnLoadInvoices.Location = New System.Drawing.Point(8, 24)
        Me.btnLoadInvoices.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadInvoices.Name = "btnLoadInvoices"
        Me.btnLoadInvoices.Size = New System.Drawing.Size(82, 26)
        Me.btnLoadInvoices.TabIndex = 2
        Me.btnLoadInvoices.Text = "📥 تحميل - Load"
        Me.btnLoadInvoices.UseVisualStyleBackColor = False
        '
        'lblOldInvoiceNo
        '
        Me.lblOldInvoiceNo.AutoSize = True
        Me.lblOldInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblOldInvoiceNo.Location = New System.Drawing.Point(487, 10)
        Me.lblOldInvoiceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOldInvoiceNo.Name = "lblOldInvoiceNo"
        Me.lblOldInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblOldInvoiceNo.Size = New System.Drawing.Size(159, 19)
        Me.lblOldInvoiceNo.TabIndex = 2
        Me.lblOldInvoiceNo.Text = "رقم الفاتورة القديم - Old:"
        '
        'txtOldInvoiceNo
        '
        Me.txtOldInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtOldInvoiceNo.Location = New System.Drawing.Point(319, 31)
        Me.txtOldInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOldInvoiceNo.Name = "txtOldInvoiceNo"
        Me.txtOldInvoiceNo.ReadOnly = True
        Me.txtOldInvoiceNo.Size = New System.Drawing.Size(305, 29)
        Me.txtOldInvoiceNo.TabIndex = 3
        Me.txtOldInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(633, 28)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 32)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "🔍 بحث - Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblNewInvoiceNo
        '
        Me.lblNewInvoiceNo.AutoSize = True
        Me.lblNewInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNewInvoiceNo.Location = New System.Drawing.Point(480, 71)
        Me.lblNewInvoiceNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewInvoiceNo.Name = "lblNewInvoiceNo"
        Me.lblNewInvoiceNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNewInvoiceNo.Size = New System.Drawing.Size(165, 19)
        Me.lblNewInvoiceNo.TabIndex = 5
        Me.lblNewInvoiceNo.Text = "رقم الفاتورة الجديد - New:"
        '
        'txtNewInvoiceNo
        '
        Me.txtNewInvoiceNo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNewInvoiceNo.Location = New System.Drawing.Point(319, 92)
        Me.txtNewInvoiceNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewInvoiceNo.Name = "txtNewInvoiceNo"
        Me.txtNewInvoiceNo.Size = New System.Drawing.Size(305, 29)
        Me.txtNewInvoiceNo.TabIndex = 6
        Me.txtNewInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpInvoiceDetails
        '
        Me.grpInvoiceDetails.Controls.Add(Me.txtInvoiceDetails)
        Me.grpInvoiceDetails.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpInvoiceDetails.Location = New System.Drawing.Point(307, 132)
        Me.grpInvoiceDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpInvoiceDetails.Name = "grpInvoiceDetails"
        Me.grpInvoiceDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpInvoiceDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grpInvoiceDetails.Size = New System.Drawing.Size(439, 362)
        Me.grpInvoiceDetails.TabIndex = 7
        Me.grpInvoiceDetails.TabStop = False
        Me.grpInvoiceDetails.Text = "تفاصيل الفاتورة - Invoice Details"
        '
        'txtInvoiceDetails
        '
        Me.txtInvoiceDetails.BackColor = System.Drawing.Color.White
        Me.txtInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvoiceDetails.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.txtInvoiceDetails.Location = New System.Drawing.Point(2, 20)
        Me.txtInvoiceDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInvoiceDetails.Multiline = True
        Me.txtInvoiceDetails.Name = "txtInvoiceDetails"
        Me.txtInvoiceDetails.ReadOnly = True
        Me.txtInvoiceDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInvoiceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInvoiceDetails.Size = New System.Drawing.Size(435, 340)
        Me.txtInvoiceDetails.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(461, 506)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 41)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "💾 حفظ - Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(307, 506)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 41)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "🗑️ مسح - Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'FormChangeInvoiceNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 569)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpInvoiceDetails)
        Me.Controls.Add(Me.txtNewInvoiceNo)
        Me.Controls.Add(Me.lblNewInvoiceNo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOldInvoiceNo)
        Me.Controls.Add(Me.lblOldInvoiceNo)
        Me.Controls.Add(Me.grpInvoiceList)
        Me.Controls.Add(Me.grpInvoiceType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChangeInvoiceNumber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغيير رقم الفاتورة - Change Invoice Number"
        Me.grpInvoiceType.ResumeLayout(False)
        Me.grpInvoiceType.PerformLayout()
        Me.grpInvoiceList.ResumeLayout(False)
        Me.pnlListControls.ResumeLayout(False)
        Me.pnlListControls.PerformLayout()
        CType(Me.numInvoiceCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoiceDetails.ResumeLayout(False)
        Me.grpInvoiceDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpInvoiceType As System.Windows.Forms.GroupBox
    Friend WithEvents radBuyInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents radSellInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents radDiamondBuy As System.Windows.Forms.RadioButton
    Friend WithEvents radDiamondSell As System.Windows.Forms.RadioButton
    Friend WithEvents grpInvoiceList As System.Windows.Forms.GroupBox
    Friend WithEvents lstInvoices As System.Windows.Forms.ListBox
    Friend WithEvents pnlListControls As System.Windows.Forms.Panel
    Friend WithEvents lblInvoiceCount As System.Windows.Forms.Label
    Friend WithEvents numInvoiceCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnLoadInvoices As System.Windows.Forms.Button
    Friend WithEvents lblOldInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents txtOldInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblNewInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents txtNewInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents grpInvoiceDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvoiceDetails As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class

