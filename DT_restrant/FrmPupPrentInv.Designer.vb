<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPupPrentInv
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblInvoiceNo = New System.Windows.Forms.Label()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.rptPupPrentInv = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinNoDta = New System.Windows.Forms.LinkLabel()
        Me.TxtInv = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.Control
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.Location = New System.Drawing.Point(343, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(138, 60)
        Me.btnView.TabIndex = 161
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
        Me.btnPrint.Location = New System.Drawing.Point(5, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(138, 60)
        Me.btnPrint.TabIndex = 163
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblInvoiceNo
        '
        Me.lblInvoiceNo.AutoSize = True
        Me.lblInvoiceNo.Location = New System.Drawing.Point(543, 9)
        Me.lblInvoiceNo.Name = "lblInvoiceNo"
        Me.lblInvoiceNo.Size = New System.Drawing.Size(71, 19)
        Me.lblInvoiceNo.TabIndex = 165
        Me.lblInvoiceNo.Text = "رقم الفاتورة"
        '
        'btnPDF
        '
        Me.btnPDF.BackColor = System.Drawing.Color.White
        Me.btnPDF.BackgroundImage = Global.DT_restrant.My.Resources.Resources.PDF
        Me.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPDF.Location = New System.Drawing.Point(8, 74)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(40, 40)
        Me.btnPDF.TabIndex = 164
        Me.btnPDF.UseVisualStyleBackColor = False
        '
        'rptPupPrentInv
        '
        Me.rptPupPrentInv.BackColor = System.Drawing.Color.Silver
        Me.rptPupPrentInv.LocalReport.ReportEmbeddedResource = "DT_restrant.rptNull.rdlc"
        Me.rptPupPrentInv.LocalReport.ReportPath = ""
        Me.rptPupPrentInv.Location = New System.Drawing.Point(3, 70)
        Me.rptPupPrentInv.Margin = New System.Windows.Forms.Padding(2)
        Me.rptPupPrentInv.Name = "rptPupPrentInv"
        Me.rptPupPrentInv.ShowBackButton = False
        Me.rptPupPrentInv.ShowContextMenu = False
        Me.rptPupPrentInv.ShowCredentialPrompts = False
        Me.rptPupPrentInv.ShowDocumentMapButton = False
        Me.rptPupPrentInv.ShowParameterPrompts = False
        Me.rptPupPrentInv.ShowStopButton = False
        Me.rptPupPrentInv.ShowToolBar = False
        Me.rptPupPrentInv.Size = New System.Drawing.Size(660, 607)
        Me.rptPupPrentInv.TabIndex = 162
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LinNoDta)
        Me.Panel1.Location = New System.Drawing.Point(12, 252)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(643, 212)
        Me.Panel1.TabIndex = 168
        '
        'LinNoDta
        '
        Me.LinNoDta.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.LinNoDta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinNoDta.AutoSize = True
        Me.LinNoDta.BackColor = System.Drawing.Color.Transparent
        Me.LinNoDta.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinNoDta.LinkColor = System.Drawing.Color.Blue
        Me.LinNoDta.Location = New System.Drawing.Point(188, 73)
        Me.LinNoDta.Name = "LinNoDta"
        Me.LinNoDta.Size = New System.Drawing.Size(0, 39)
        Me.LinNoDta.TabIndex = 0
        '
        'TxtInv
        '
        Me.TxtInv.FormattingEnabled = True
        Me.TxtInv.Location = New System.Drawing.Point(484, 37)
        Me.TxtInv.Name = "TxtInv"
        Me.TxtInv.Size = New System.Drawing.Size(179, 27)
        Me.TxtInv.TabIndex = 169
        '
        'FrmPupPrentInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(667, 680)
        Me.Controls.Add(Me.TxtInv)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblInvoiceNo)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.rptPupPrentInv)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPupPrentInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPupPrentInv"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lblInvoiceNo As System.Windows.Forms.Label
    Friend WithEvents btnPDF As System.Windows.Forms.Button
    Friend WithEvents rptPupPrentInv As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LinNoDta As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtInv As ComboBox
End Class
