<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accessories_ViewSellInvoice
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
        Dim Accessories_staytesLabel As System.Windows.Forms.Label
        Dim SET_INVARCHR150Label As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accessories_ViewSellInvoice))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Accessories_View_prinet_invoceDataGridView = New System.Windows.Forms.DataGridView()
        Me.Accessories_staytesTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR150TextBox = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Accessories_staytesLabel = New System.Windows.Forms.Label()
        SET_INVARCHR150Label = New System.Windows.Forms.Label()
        CType(Me.Accessories_View_prinet_invoceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accessories_staytesLabel
        '
        Accessories_staytesLabel.AutoSize = True
        Accessories_staytesLabel.Location = New System.Drawing.Point(964, 533)
        Accessories_staytesLabel.Name = "Accessories_staytesLabel"
        Accessories_staytesLabel.Size = New System.Drawing.Size(142, 19)
        Accessories_staytesLabel.TabIndex = 13
        Accessories_staytesLabel.Text = "Accessories staytes:"
        '
        'SET_INVARCHR150Label
        '
        SET_INVARCHR150Label.AutoSize = True
        SET_INVARCHR150Label.Location = New System.Drawing.Point(841, 167)
        SET_INVARCHR150Label.Name = "SET_INVARCHR150Label"
        SET_INVARCHR150Label.Size = New System.Drawing.Size(134, 19)
        SET_INVARCHR150Label.TabIndex = 14
        SET_INVARCHR150Label.Text = "SET INVARCHR150:"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ReportViewer1.ForeColor = System.Drawing.SystemColors.HighlightText
        ReportDataSource1.Name = "DataSet1"
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer1.LocalReport.ReportPath = "report\rptAccessories_Invoice_A4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 70)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 540)
        Me.ReportViewer1.TabIndex = 3
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.LightCyan
        Me.txtInvoiceNo.Location = New System.Drawing.Point(448, 22)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(150, 27)
        Me.txtInvoiceNo.TabIndex = 0
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Accessories_View_prinet_invoceDataGridView
        '
        Me.Accessories_View_prinet_invoceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Accessories_View_prinet_invoceDataGridView.Location = New System.Drawing.Point(967, 283)
        Me.Accessories_View_prinet_invoceDataGridView.Name = "Accessories_View_prinet_invoceDataGridView"
        Me.Accessories_View_prinet_invoceDataGridView.Size = New System.Drawing.Size(206, 220)
        Me.Accessories_View_prinet_invoceDataGridView.TabIndex = 13
        '
        'Accessories_staytesTextBox
        '
        Me.Accessories_staytesTextBox.Location = New System.Drawing.Point(1073, 530)
        Me.Accessories_staytesTextBox.Name = "Accessories_staytesTextBox"
        Me.Accessories_staytesTextBox.Size = New System.Drawing.Size(100, 27)
        Me.Accessories_staytesTextBox.TabIndex = 14
        '
        'SET_INVARCHR150TextBox
        '
        Me.SET_INVARCHR150TextBox.Location = New System.Drawing.Point(955, 164)
        Me.SET_INVARCHR150TextBox.Name = "SET_INVARCHR150TextBox"
        Me.SET_INVARCHR150TextBox.Size = New System.Drawing.Size(218, 27)
        Me.SET_INVARCHR150TextBox.TabIndex = 15
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(305, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 60)
        Me.btnView.TabIndex = 1
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
        Me.btnPrint.Location = New System.Drawing.Point(8, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 60)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(604, 26)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(73, 19)
        Me.lblInvoiceNo.TabIndex = 164
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        '
        'Accessories_ViewSellInvoice
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(SET_INVARCHR150Label)
        Me.Controls.Add(Me.SET_INVARCHR150TextBox)
        Me.Controls.Add(Accessories_staytesLabel)
        Me.Controls.Add(Me.Accessories_staytesTextBox)
        Me.Controls.Add(Me.Accessories_View_prinet_invoceDataGridView)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accessories_ViewSellInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عرض فواتير بيع الساعات"
        CType(Me.Accessories_View_prinet_invoceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Accessories_View_prinet_invoceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Accessories_staytesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR150TextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblInvoiceNo As Label
End Class
