<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethodsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PnlPyment = New System.Windows.Forms.Panel()
        Me.txtBank1 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod1 = New System.Windows.Forms.ComboBox()
        Me.lblPayMethod1 = New System.Windows.Forms.Label()
        Me.cmbPayMethod4 = New System.Windows.Forms.ComboBox()
        Me.txtBank4 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod3 = New System.Windows.Forms.ComboBox()
        Me.txtBank3 = New System.Windows.Forms.TextBox()
        Me.cmbPayMethod2 = New System.Windows.Forms.ComboBox()
        Me.txtBank2 = New System.Windows.Forms.TextBox()
        Me.PnlPyment.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlPyment
        '
        Me.PnlPyment.Controls.Add(Me.txtBank1)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod1)
        Me.PnlPyment.Controls.Add(Me.lblPayMethod1)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod4)
        Me.PnlPyment.Controls.Add(Me.txtBank4)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod3)
        Me.PnlPyment.Controls.Add(Me.txtBank3)
        Me.PnlPyment.Controls.Add(Me.cmbPayMethod2)
        Me.PnlPyment.Controls.Add(Me.txtBank2)
        Me.PnlPyment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlPyment.Location = New System.Drawing.Point(3, 3)
        Me.PnlPyment.Name = "PnlPyment"
        Me.PnlPyment.Size = New System.Drawing.Size(322, 94)
        Me.PnlPyment.TabIndex = 121
        '
        'txtBank1
        '
        Me.txtBank1.BackColor = System.Drawing.Color.Orange
        Me.txtBank1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBank1.Location = New System.Drawing.Point(238, 35)
        Me.txtBank1.Name = "txtBank1"
        Me.txtBank1.Size = New System.Drawing.Size(78, 27)
        Me.txtBank1.TabIndex = 118
        Me.txtBank1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod1
        '
        Me.cmbPayMethod1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod1.FormattingEnabled = True
        Me.cmbPayMethod1.Location = New System.Drawing.Point(238, 62)
        Me.cmbPayMethod1.Name = "cmbPayMethod1"
        Me.cmbPayMethod1.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod1.TabIndex = 119
        '
        'lblPayMethod1
        '
        Me.lblPayMethod1.BackColor = System.Drawing.Color.Orange
        Me.lblPayMethod1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayMethod1.Location = New System.Drawing.Point(4, 5)
        Me.lblPayMethod1.Name = "lblPayMethod1"
        Me.lblPayMethod1.Size = New System.Drawing.Size(312, 29)
        Me.lblPayMethod1.TabIndex = 114
        Me.lblPayMethod1.Text = "عمليات اخري"
        Me.lblPayMethod1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPayMethod4
        '
        Me.cmbPayMethod4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod4.FormattingEnabled = True
        Me.cmbPayMethod4.Location = New System.Drawing.Point(4, 62)
        Me.cmbPayMethod4.Name = "cmbPayMethod4"
        Me.cmbPayMethod4.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod4.TabIndex = 117
        '
        'txtBank4
        '
        Me.txtBank4.BackColor = System.Drawing.Color.Orange
        Me.txtBank4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBank4.Location = New System.Drawing.Point(4, 35)
        Me.txtBank4.Name = "txtBank4"
        Me.txtBank4.Size = New System.Drawing.Size(78, 27)
        Me.txtBank4.TabIndex = 113
        Me.txtBank4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod3
        '
        Me.cmbPayMethod3.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod3.FormattingEnabled = True
        Me.cmbPayMethod3.Location = New System.Drawing.Point(82, 62)
        Me.cmbPayMethod3.Name = "cmbPayMethod3"
        Me.cmbPayMethod3.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod3.TabIndex = 116
        '
        'txtBank3
        '
        Me.txtBank3.BackColor = System.Drawing.Color.Orange
        Me.txtBank3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBank3.Location = New System.Drawing.Point(82, 35)
        Me.txtBank3.Name = "txtBank3"
        Me.txtBank3.Size = New System.Drawing.Size(78, 27)
        Me.txtBank3.TabIndex = 112
        Me.txtBank3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPayMethod2
        '
        Me.cmbPayMethod2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmbPayMethod2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayMethod2.FormattingEnabled = True
        Me.cmbPayMethod2.Location = New System.Drawing.Point(160, 62)
        Me.cmbPayMethod2.Name = "cmbPayMethod2"
        Me.cmbPayMethod2.Size = New System.Drawing.Size(78, 27)
        Me.cmbPayMethod2.TabIndex = 115
        '
        'txtBank2
        '
        Me.txtBank2.BackColor = System.Drawing.Color.Orange
        Me.txtBank2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtBank2.Location = New System.Drawing.Point(160, 35)
        Me.txtBank2.Name = "txtBank2"
        Me.txtBank2.Size = New System.Drawing.Size(78, 27)
        Me.txtBank2.TabIndex = 111
        Me.txtBank2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaymentMethodsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlPyment)
        Me.Name = "PaymentMethodsControl"
        Me.Size = New System.Drawing.Size(327, 102)
        Me.PnlPyment.ResumeLayout(False)
        Me.PnlPyment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlPyment As Panel
    Friend WithEvents txtBank1 As TextBox
    Friend WithEvents cmbPayMethod1 As ComboBox
    Friend WithEvents lblPayMethod1 As Label
    Friend WithEvents cmbPayMethod4 As ComboBox
    Friend WithEvents txtBank4 As TextBox
    Friend WithEvents cmbPayMethod3 As ComboBox
    Friend WithEvents txtBank3 As TextBox
    Friend WithEvents cmbPayMethod2 As ComboBox
    Friend WithEvents txtBank2 As TextBox
End Class
