<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoldViewBuyInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoldViewBuyInvoice))
        Me.ReportGoldBuyInvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.Inv_idTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerTETextBox = New System.Windows.Forms.TextBox()
        Me.Castomer_idTextBox = New System.Windows.Forms.TextBox()
        Me.CastomerNAmeTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR148TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR158TextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackWorkInv = New System.ComponentModel.BackgroundWorker()
        Me.RadAcc = New System.Windows.Forms.RadioButton()
        Me.RadCastm = New System.Windows.Forms.RadioButton()
        Me.txtInvoiceNo = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        CType(Me.ReportGoldBuyInvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportGoldBuyInvoiceDataGridView
        '
        Me.ReportGoldBuyInvoiceDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportGoldBuyInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportGoldBuyInvoiceDataGridView.Location = New System.Drawing.Point(-86, 78)
        Me.ReportGoldBuyInvoiceDataGridView.Name = "ReportGoldBuyInvoiceDataGridView"
        Me.ReportGoldBuyInvoiceDataGridView.RowHeadersVisible = False
        Me.ReportGoldBuyInvoiceDataGridView.Size = New System.Drawing.Size(45, 27)
        Me.ReportGoldBuyInvoiceDataGridView.TabIndex = 11
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(741, 418)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 164
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Inv_idTextBox)
        Me.pnl.Controls.Add(Me.CastomerTETextBox)
        Me.pnl.Controls.Add(Me.Castomer_idTextBox)
        Me.pnl.Controls.Add(Me.CastomerNAmeTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR148TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR158TextBox)
        Me.pnl.Controls.Add(Me.ReportGoldBuyInvoiceDataGridView)
        Me.pnl.Location = New System.Drawing.Point(815, 21)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(70, 73)
        Me.pnl.TabIndex = 166
        '
        'Inv_idTextBox
        '
        Me.Inv_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_idTextBox.Location = New System.Drawing.Point(-86, 240)
        Me.Inv_idTextBox.Name = "Inv_idTextBox"
        Me.Inv_idTextBox.Size = New System.Drawing.Size(45, 27)
        Me.Inv_idTextBox.TabIndex = 17
        '
        'CastomerTETextBox
        '
        Me.CastomerTETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerTETextBox.Location = New System.Drawing.Point(-86, 213)
        Me.CastomerTETextBox.Name = "CastomerTETextBox"
        Me.CastomerTETextBox.Size = New System.Drawing.Size(45, 27)
        Me.CastomerTETextBox.TabIndex = 16
        '
        'Castomer_idTextBox
        '
        Me.Castomer_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Castomer_idTextBox.Location = New System.Drawing.Point(-86, 186)
        Me.Castomer_idTextBox.Name = "Castomer_idTextBox"
        Me.Castomer_idTextBox.Size = New System.Drawing.Size(45, 27)
        Me.Castomer_idTextBox.TabIndex = 15
        '
        'CastomerNAmeTextBox
        '
        Me.CastomerNAmeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CastomerNAmeTextBox.Location = New System.Drawing.Point(-86, 159)
        Me.CastomerNAmeTextBox.Name = "CastomerNAmeTextBox"
        Me.CastomerNAmeTextBox.Size = New System.Drawing.Size(45, 27)
        Me.CastomerNAmeTextBox.TabIndex = 14
        '
        'SET_INVARCHR148TextBox
        '
        Me.SET_INVARCHR148TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR148TextBox.Location = New System.Drawing.Point(-86, 132)
        Me.SET_INVARCHR148TextBox.Name = "SET_INVARCHR148TextBox"
        Me.SET_INVARCHR148TextBox.Size = New System.Drawing.Size(45, 27)
        Me.SET_INVARCHR148TextBox.TabIndex = 13
        '
        'SET_INVARCHR158TextBox
        '
        Me.SET_INVARCHR158TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR158TextBox.Location = New System.Drawing.Point(-86, 105)
        Me.SET_INVARCHR158TextBox.Name = "SET_INVARCHR158TextBox"
        Me.SET_INVARCHR158TextBox.Size = New System.Drawing.Size(45, 27)
        Me.SET_INVARCHR158TextBox.TabIndex = 12
        '
        'ReportViewer
        '
        Me.ReportViewer.Location = New System.Drawing.Point(6, 79)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ServerReport.BearerToken = Nothing
        Me.ReportViewer.Size = New System.Drawing.Size(653, 601)
        Me.ReportViewer.TabIndex = 170
        '
        'BackWorkInv
        '
        '
        'RadAcc
        '
        Me.RadAcc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadAcc.Location = New System.Drawing.Point(470, 40)
        Me.RadAcc.Name = "RadAcc"
        Me.RadAcc.Size = New System.Drawing.Size(131, 29)
        Me.RadAcc.TabIndex = 177
        Me.RadAcc.TabStop = True
        Me.RadAcc.Text = "نسخة العميل"
        Me.RadAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadAcc.UseVisualStyleBackColor = True
        '
        'RadCastm
        '
        Me.RadCastm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCastm.Location = New System.Drawing.Point(470, 1)
        Me.RadCastm.Name = "RadCastm"
        Me.RadCastm.Size = New System.Drawing.Size(131, 29)
        Me.RadCastm.TabIndex = 176
        Me.RadCastm.TabStop = True
        Me.RadCastm.Text = "نسخة العميل"
        Me.RadCastm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadCastm.UseVisualStyleBackColor = True
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.FormattingEnabled = True
        Me.txtInvoiceNo.Location = New System.Drawing.Point(319, 46)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(145, 27)
        Me.txtInvoiceNo.TabIndex = 175
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(176, 9)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 63)
        Me.btnView.TabIndex = 172
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(6, 9)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(143, 62)
        Me.btnPrint.TabIndex = 173
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.Location = New System.Drawing.Point(320, 2)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(144, 41)
        Me.lblInvoiceNo.TabIndex = 174
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        Me.lblInvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoldViewBuyInvoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(664, 684)
        Me.Controls.Add(Me.RadAcc)
        Me.Controls.Add(Me.RadCastm)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.ReportViewer)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnPDF)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GoldViewBuyInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مراجعة فواتير الشراء"
        CType(Me.ReportGoldBuyInvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportGoldBuyInvoiceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents SET_INVARCHR158TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR148TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastomerNAmeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Castomer_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CastomerTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inv_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BackWorkInv As System.ComponentModel.BackgroundWorker
    Friend WithEvents RadAcc As RadioButton
    Friend WithEvents RadCastm As RadioButton
    Friend WithEvents txtInvoiceNo As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblInvoiceNo As Label
End Class
