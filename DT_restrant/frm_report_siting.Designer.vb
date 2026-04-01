<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_siting
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
        Me.gbMargins = New System.Windows.Forms.GroupBox()
        Me.lblPreviewTitle = New System.Windows.Forms.Label()
        Me.pnlPreview = New System.Windows.Forms.Panel()
        Me.pnlMargins = New System.Windows.Forms.Panel()
        Me.nudRight = New System.Windows.Forms.NumericUpDown()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.nudLeft = New System.Windows.Forms.NumericUpDown()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.nudBottom = New System.Windows.Forms.NumericUpDown()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.nudTop = New System.Windows.Forms.NumericUpDown()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbMargins.SuspendLayout()
        Me.pnlMargins.SuspendLayout()
        CType(Me.nudRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMargins
        '
        Me.gbMargins.Controls.Add(Me.lblPreviewTitle)
        Me.gbMargins.Controls.Add(Me.pnlPreview)
        Me.gbMargins.Controls.Add(Me.pnlMargins)
        Me.gbMargins.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gbMargins.Location = New System.Drawing.Point(20, 20)
        Me.gbMargins.Name = "gbMargins"
        Me.gbMargins.Padding = New System.Windows.Forms.Padding(15)
        Me.gbMargins.Size = New System.Drawing.Size(560, 379)
        Me.gbMargins.TabIndex = 0
        Me.gbMargins.TabStop = False
        Me.gbMargins.Text = "إعدادات هوامش التقارير"
        '
        'lblPreviewTitle
        '
        Me.lblPreviewTitle.AutoSize = True
        Me.lblPreviewTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviewTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblPreviewTitle.Location = New System.Drawing.Point(117, 18)
        Me.lblPreviewTitle.Name = "lblPreviewTitle"
        Me.lblPreviewTitle.Size = New System.Drawing.Size(117, 15)
        Me.lblPreviewTitle.TabIndex = 0
        Me.lblPreviewTitle.Text = "معاينة تخطيط الصفحة"
        '
        'pnlPreview
        '
        Me.pnlPreview.BackColor = System.Drawing.Color.White
        Me.pnlPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPreview.Location = New System.Drawing.Point(20, 36)
        Me.pnlPreview.Name = "pnlPreview"
        Me.pnlPreview.Size = New System.Drawing.Size(316, 324)
        Me.pnlPreview.TabIndex = 1
        '
        'pnlMargins
        '
        Me.pnlMargins.Controls.Add(Me.nudRight)
        Me.pnlMargins.Controls.Add(Me.lblRight)
        Me.pnlMargins.Controls.Add(Me.nudLeft)
        Me.pnlMargins.Controls.Add(Me.lblLeft)
        Me.pnlMargins.Controls.Add(Me.nudBottom)
        Me.pnlMargins.Controls.Add(Me.lblBottom)
        Me.pnlMargins.Controls.Add(Me.nudTop)
        Me.pnlMargins.Controls.Add(Me.lblTop)
        Me.pnlMargins.Controls.Add(Me.lblUnit)
        Me.pnlMargins.Location = New System.Drawing.Point(342, 36)
        Me.pnlMargins.Name = "pnlMargins"
        Me.pnlMargins.Size = New System.Drawing.Size(200, 173)
        Me.pnlMargins.TabIndex = 0
        '
        'nudRight
        '
        Me.nudRight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudRight.Location = New System.Drawing.Point(9, 100)
        Me.nudRight.Name = "nudRight"
        Me.nudRight.Size = New System.Drawing.Size(100, 25)
        Me.nudRight.TabIndex = 8
        Me.nudRight.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblRight.Location = New System.Drawing.Point(119, 102)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(48, 19)
        Me.lblRight.TabIndex = 7
        Me.lblRight.Text = "اليمين:"
        '
        'nudLeft
        '
        Me.nudLeft.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudLeft.Location = New System.Drawing.Point(9, 131)
        Me.nudLeft.Name = "nudLeft"
        Me.nudLeft.Size = New System.Drawing.Size(100, 25)
        Me.nudLeft.TabIndex = 6
        Me.nudLeft.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLeft.Location = New System.Drawing.Point(119, 133)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(48, 19)
        Me.lblLeft.TabIndex = 5
        Me.lblLeft.Text = "اليسار:"
        '
        'nudBottom
        '
        Me.nudBottom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudBottom.Location = New System.Drawing.Point(9, 72)
        Me.nudBottom.Name = "nudBottom"
        Me.nudBottom.Size = New System.Drawing.Size(100, 25)
        Me.nudBottom.TabIndex = 4
        Me.nudBottom.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblBottom.Location = New System.Drawing.Point(119, 74)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(53, 19)
        Me.lblBottom.TabIndex = 3
        Me.lblBottom.Text = "الأسفل:"
        '
        'nudTop
        '
        Me.nudTop.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudTop.Location = New System.Drawing.Point(9, 41)
        Me.nudTop.Name = "nudTop"
        Me.nudTop.Size = New System.Drawing.Size(100, 25)
        Me.nudTop.TabIndex = 2
        Me.nudTop.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTop.Location = New System.Drawing.Point(119, 43)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(50, 19)
        Me.lblTop.TabIndex = 1
        Me.lblTop.Text = "الأعلى:"
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblUnit.ForeColor = System.Drawing.Color.Gray
        Me.lblUnit.Location = New System.Drawing.Point(44, 14)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(103, 15)
        Me.lblUnit.TabIndex = 0
        Me.lblUnit.Text = "الوحدات: مليمتر (mm)"
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnReset)
        Me.pnlButtons.Controls.Add(Me.btnCancel)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Location = New System.Drawing.Point(20, 405)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(560, 50)
        Me.pnlButtons.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(20, 10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 35)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "إعادة تعيين"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(160, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(420, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 35)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frm_report_siting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 459)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.gbMargins)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_report_siting"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات هوامش التقارير"
        Me.gbMargins.ResumeLayout(False)
        Me.gbMargins.PerformLayout()
        Me.pnlMargins.ResumeLayout(False)
        Me.pnlMargins.PerformLayout()
        CType(Me.nudRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMargins As GroupBox
    Friend WithEvents pnlPreview As Panel
    Friend WithEvents lblPreviewTitle As Label
    Friend WithEvents pnlMargins As Panel
    Friend WithEvents nudRight As NumericUpDown
    Friend WithEvents lblRight As Label
    Friend WithEvents nudLeft As NumericUpDown
    Friend WithEvents lblLeft As Label
    Friend WithEvents nudBottom As NumericUpDown
    Friend WithEvents lblBottom As Label
    Friend WithEvents nudTop As NumericUpDown
    Friend WithEvents lblTop As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
