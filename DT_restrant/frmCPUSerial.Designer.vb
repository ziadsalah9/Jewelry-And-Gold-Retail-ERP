<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCPUSerial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPUSerial))
        Me.CPU_ID = New System.Windows.Forms.TextBox()
        Me.TEXWAR = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CPU_ID
        '
        Me.CPU_ID.BackColor = System.Drawing.SystemColors.Menu
        Me.CPU_ID.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU_ID.Location = New System.Drawing.Point(7, 172)
        Me.CPU_ID.Name = "CPU_ID"
        Me.CPU_ID.Size = New System.Drawing.Size(888, 38)
        Me.CPU_ID.TabIndex = 0
        Me.CPU_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TEXWAR
        '
        Me.TEXWAR.BackColor = System.Drawing.SystemColors.Menu
        Me.TEXWAR.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TEXWAR.Location = New System.Drawing.Point(7, 3)
        Me.TEXWAR.Multiline = True
        Me.TEXWAR.Name = "TEXWAR"
        Me.TEXWAR.Size = New System.Drawing.Size(888, 116)
        Me.TEXWAR.TabIndex = 1
        Me.TEXWAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(7, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(888, 38)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "كود تسجيل الجهاز - Computer Serial"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmCPUSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(902, 219)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TEXWAR)
        Me.Controls.Add(Me.CPU_ID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmCPUSerial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CPU_ID As System.Windows.Forms.TextBox
    Friend WithEvents TEXWAR As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
