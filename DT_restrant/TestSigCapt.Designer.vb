Namespace TestSigCapt
	Partial Public Class TestSigCapt
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.btnSign = New System.Windows.Forms.Button()
            Me.txtDisplay = New System.Windows.Forms.TextBox()
            Me.sigImage = New System.Windows.Forms.PictureBox()
            CType(Me.sigImage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnSign
            '
            Me.btnSign.Location = New System.Drawing.Point(109, 388)
            Me.btnSign.Name = "btnSign"
            Me.btnSign.Size = New System.Drawing.Size(94, 44)
            Me.btnSign.TabIndex = 1
            Me.btnSign.Text = "Sign"
            Me.btnSign.UseVisualStyleBackColor = True
            '
            'txtDisplay
            '
            Me.txtDisplay.Location = New System.Drawing.Point(12, 369)
            Me.txtDisplay.Multiline = True
            Me.txtDisplay.Name = "txtDisplay"
            Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDisplay.Size = New System.Drawing.Size(72, 53)
            Me.txtDisplay.TabIndex = 2
            '
            'sigImage
            '
            Me.sigImage.BackColor = System.Drawing.SystemColors.ControlLightLight
            Me.sigImage.Location = New System.Drawing.Point(3, 3)
            Me.sigImage.Name = "sigImage"
            Me.sigImage.Size = New System.Drawing.Size(603, 360)
            Me.sigImage.TabIndex = 0
            Me.sigImage.TabStop = False
            '
            'TestSigCapt
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(611, 365)
            Me.Controls.Add(Me.txtDisplay)
            Me.Controls.Add(Me.btnSign)
            Me.Controls.Add(Me.sigImage)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "TestSigCapt"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "TestSigCapt"
            Me.TopMost = True
            CType(Me.sigImage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private sigImage As System.Windows.Forms.PictureBox
		Private WithEvents btnSign As System.Windows.Forms.Button
		Private txtDisplay As System.Windows.Forms.TextBox
	End Class
End Namespace

