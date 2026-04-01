<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMissingData
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.btnCopyDetails = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtResults
        '
        Me.txtResults.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResults.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResults.Location = New System.Drawing.Point(0, 50)
        Me.txtResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResults.Size = New System.Drawing.Size(800, 450)
        Me.txtResults.TabIndex = 0
        '
        'btnCopyDetails
        '
        Me.btnCopyDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCopyDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyDetails.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyDetails.ForeColor = System.Drawing.Color.White
        Me.btnCopyDetails.Location = New System.Drawing.Point(550, 10)
        Me.btnCopyDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCopyDetails.Name = "btnCopyDetails"
        Me.btnCopyDetails.Size = New System.Drawing.Size(240, 35)
        Me.btnCopyDetails.TabIndex = 1
        Me.btnCopyDetails.Text = "نسخ تفاصيل فاتورة أخرى"
        Me.btnCopyDetails.UseVisualStyleBackColor = False
        Me.btnCopyDetails.Visible = False
        '
        'FormMissingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.btnCopyDetails)
        Me.Controls.Add(Me.txtResults)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(818, 547)
        Me.Name = "FormMissingData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التحقق من البيانات الناقصة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents btnCopyDetails As System.Windows.Forms.Button
End Class

