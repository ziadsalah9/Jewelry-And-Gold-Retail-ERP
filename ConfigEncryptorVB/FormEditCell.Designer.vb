<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditCell
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
        Me.lblTableName = New System.Windows.Forms.Label()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblOldValue = New System.Windows.Forms.Label()
        Me.txtOldValue = New System.Windows.Forms.TextBox()
        Me.lblNewValue = New System.Windows.Forms.Label()
        Me.txtNewValue = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTableName
        '
        Me.lblTableName.AutoSize = True
        Me.lblTableName.Location = New System.Drawing.Point(12, 15)
        Me.lblTableName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(45, 13)
        Me.lblTableName.TabIndex = 0
        Me.lblTableName.Text = "الجدول:"
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(12, 40)
        Me.lblColumnName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(45, 13)
        Me.lblColumnName.TabIndex = 1
        Me.lblColumnName.Text = "العمود:"
        '
        'lblOldValue
        '
        Me.lblOldValue.AutoSize = True
        Me.lblOldValue.Location = New System.Drawing.Point(12, 75)
        Me.lblOldValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOldValue.Name = "lblOldValue"
        Me.lblOldValue.Size = New System.Drawing.Size(70, 13)
        Me.lblOldValue.TabIndex = 2
        Me.lblOldValue.Text = "القيمة القديمة:"
        '
        'txtOldValue
        '
        Me.txtOldValue.Location = New System.Drawing.Point(12, 90)
        Me.txtOldValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOldValue.Multiline = True
        Me.txtOldValue.Name = "txtOldValue"
        Me.txtOldValue.ReadOnly = True
        Me.txtOldValue.Size = New System.Drawing.Size(460, 60)
        Me.txtOldValue.TabIndex = 3
        '
        'lblNewValue
        '
        Me.lblNewValue.AutoSize = True
        Me.lblNewValue.Location = New System.Drawing.Point(12, 160)
        Me.lblNewValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewValue.Name = "lblNewValue"
        Me.lblNewValue.Size = New System.Drawing.Size(68, 13)
        Me.lblNewValue.TabIndex = 4
        Me.lblNewValue.Text = "القيمة الجديدة:"
        '
        'txtNewValue
        '
        Me.txtNewValue.Location = New System.Drawing.Point(12, 175)
        Me.txtNewValue.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNewValue.Multiline = True
        Me.txtNewValue.Name = "txtNewValue"
        Me.txtNewValue.Size = New System.Drawing.Size(460, 60)
        Me.txtNewValue.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(316, 250)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(397, 250)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 28)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "إلغاء"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FormEditCell
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(484, 290)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtNewValue)
        Me.Controls.Add(Me.lblNewValue)
        Me.Controls.Add(Me.txtOldValue)
        Me.Controls.Add(Me.lblOldValue)
        Me.Controls.Add(Me.lblColumnName)
        Me.Controls.Add(Me.lblTableName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditCell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل القيمة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTableName As System.Windows.Forms.Label
    Friend WithEvents lblColumnName As System.Windows.Forms.Label
    Friend WithEvents lblOldValue As System.Windows.Forms.Label
    Friend WithEvents txtOldValue As System.Windows.Forms.TextBox
    Friend WithEvents lblNewValue As System.Windows.Forms.Label
    Friend WithEvents txtNewValue As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class

