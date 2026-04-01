Public Class frmReplace
    Inherits Form

#Region " Windows Form Designer generated code "
    Public Sub New(r As RichTextBox, rec As Rectangle)
        MyBase.New()
        rtb = r
        InitializeComponent()
        txtFind.Text = rtb.SelectedText
        Location = New Point(rec.X + (rec.Width - Width) / 2, rec.Y + (rec.Height - Height) / 2)
        txtFind_TextChanged(Nothing, Nothing)
    End Sub
    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private components As System.ComponentModel.IContainer
    Friend WithEvents btnReplaceAll As Button
    Friend WithEvents txtReplace As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFind As TextBox
    <DebuggerStepThrough()> Private Sub InitializeComponent()
        btnReplaceAll = New Button()
        txtReplace = New TextBox()
        txtFind = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        '
        'btnReplaceAll
        '
        btnReplaceAll.BackColor = System.Drawing.Color.Maroon
        btnReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        btnReplaceAll.Font = New Font("Arial Black", 15.2!, System.Drawing.FontStyle.Bold)
        btnReplaceAll.Location = New Point(477, 135)
        btnReplaceAll.Name = "btnReplaceAll"
        btnReplaceAll.Size = New Size(135, 61)
        btnReplaceAll.TabIndex = 16
        btnReplaceAll.Text = "تحديث النص"
        btnReplaceAll.UseVisualStyleBackColor = False
        '
        'txtReplace
        '
        txtReplace.Font = New Font("Arial Black", 15.2!, System.Drawing.FontStyle.Bold)
        txtReplace.Location = New Point(3, 135)
        txtReplace.Multiline = True
        txtReplace.Name = "txtReplace"
        txtReplace.Size = New Size(468, 61)
        txtReplace.TabIndex = 11
        '
        'txtFind
        '
        txtFind.Font = New Font("Arial Black", 15.2!, System.Drawing.FontStyle.Bold)
        txtFind.Location = New Point(3, 40)
        txtFind.Multiline = True
        txtFind.Name = "txtFind"
        txtFind.Size = New Size(602, 58)
        txtFind.TabIndex = 10
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 15.2!, System.Drawing.FontStyle.Bold)
        Label1.Location = New Point(219, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 30)
        Label1.TabIndex = 17
        Label1.Text = "النص المراد تعديله"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 15.2!, System.Drawing.FontStyle.Bold)
        Label2.Location = New Point(249, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 30)
        Label2.TabIndex = 18
        Label2.Text = "النص الجديد"
        '
        'frmReplace
        '
        AutoScaleBaseSize = New Size(5, 13)
        BackColor = System.Drawing.SystemColors.HotTrack
        ClientSize = New Size(617, 199)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReplaceAll)
        Controls.Add(txtReplace)
        Controls.Add(txtFind)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        Name = "frmReplace"
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "تعديل النص"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub
#End Region
    Private rtb As RichTextBox
    Protected Sub MessageNotFound(p As Integer)
        If p = -1 Then
        End If
    End Sub

    Protected Function Find() As Integer
        Return rtb.Find(txtFind.Text, rtb.SelectionStart + rtb.SelectionLength, rtb.MaxLength, RichTextBoxFinds.None)
    End Function

    Protected Function FindForReplace() As Integer
        Return rtb.Find(txtFind.Text, rtb.SelectionStart, rtb.MaxLength, RichTextBoxFinds.None)
    End Function
    Private Sub btnFindNext_Click(sender As Object, e As EventArgs)
        MessageNotFound(Find())
    End Sub
    Private Sub txtFind_TextChanged(sender As Object, e As EventArgs) Handles txtFind.TextChanged
        'btnFindNext1.Enabled = txtFind.Text <> ""
        'btnReplaceAll.Enabled = btnFindNext1.Enabled
        txtReplace.Enabled = True
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub btnReplace_Click(sender As Object, e As EventArgs)
        If FindForReplace() <> -1 Then
            rtb.SelectedText = txtReplace.Text
        Else
            MessageNotFound(-1)
        End If
    End Sub

    Private Sub btnReplaceAll_Click(sender As Object, e As EventArgs) Handles btnReplaceAll.Click
        Dim r As Integer = -1
        Dim p As Integer = 0
        rtb.SelectionStart = 0
        rtb.SelectionLength = 0
        While p <> -1
            p = Find()
            If p <> -1 Then
                r += 1
                rtb.SelectedText = txtReplace.Text

            End If
        End While
        MessageNotFound(r)
        Close()
    End Sub
    Private Sub frmReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtReplace.Enabled = False
    End Sub
End Class
