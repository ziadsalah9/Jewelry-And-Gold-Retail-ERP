Imports System.IO
Imports System

Public Class frmReportTXTModify

    Inherits Form
    Public OFD As New OpenFileDialog
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnFilePath As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents EditorRichTextBox As RichTextBox
    <DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmReportTXTModify))
        Me.EditorRichTextBox = New RichTextBox()
        Me.btnFilePath = New Button()
        Me.TextBox1 = New TextBox()
        Me.btnEdit = New Button()
        Me.Button2 = New Button()
        Me.btnSave = New Button()
        Me.SuspendLayout()
        '
        'EditorRichTextBox
        '
        Me.EditorRichTextBox.BackColor = System.Drawing.SystemColors.InfoText
        Me.EditorRichTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EditorRichTextBox.Location = New Point(3, 34)
        Me.EditorRichTextBox.Name = "EditorRichTextBox"
        Me.EditorRichTextBox.Size = New Size(656, 645)
        Me.EditorRichTextBox.TabIndex = 0
        Me.EditorRichTextBox.Text = ""
        '
        'btnFilePath
        '
        Me.btnFilePath.Location = New Point(537, 2)
        Me.btnFilePath.Name = "btnFilePath"
        Me.btnFilePath.Size = New Size(122, 28)
        Me.btnFilePath.TabIndex = 1
        Me.btnFilePath.Text = "تحديد مسار الملف"
        Me.btnFilePath.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Point(329, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Size(202, 27)
        Me.TextBox1.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnEdit.Location = New Point(179, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New Size(144, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New Point(3, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New Size(60, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "تعديل"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Location = New Point(3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New Size(170, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "حفظ النص بعد التعديل"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmReportTXTModify
        '
        Me.AutoScaleBaseSize = New Size(7, 20)
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New Size(664, 683)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnFilePath)
        Me.Controls.Add(Me.EditorRichTextBox)
        Me.Font = New Font("Calibri", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportTXTModify"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعديل التقارير والملفات النصية"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ReplaceDialog As frmReplace

    Public Sub EDIT()

    End Sub


    Private Sub ReplaceMenuItem_Click(sender As Object, e As EventArgs)
        If Not ReplaceDialog Is Nothing Then ReplaceDialog.Close()
        If Not ReplaceDialog Is Nothing Then ReplaceDialog.Close()
        ReplaceDialog = New frmReplace(EditorRichTextBox, Bounds)
        AddOwnedForm(ReplaceDialog)
        ReplaceDialog.Show()
    End Sub

    Private Sub frmReportTXTModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, Button2.Click
        If Not ReplaceDialog Is Nothing Then ReplaceDialog.Close()
        If Not ReplaceDialog Is Nothing Then ReplaceDialog.Close()
        ReplaceDialog = New frmReplace(EditorRichTextBox, Bounds)
        AddOwnedForm(ReplaceDialog)
        ReplaceDialog.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFilePath.Click

        OFD.InitialDirectory = Application.StartupPath
        'OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = OFD.FileName
            Else
                Return
            End If
        End With
        Dim re As New StreamReader(OFD.FileName)
        EditorRichTextBox.Text = re.ReadToEnd()
        re.Close()
    End Sub

    Private Sub EditorRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles EditorRichTextBox.TextChanged
        'If Not String.IsNullOrEmpty(TextBox1.Text.Trim) Then

        'Else
        btnEdit.Enabled = True
        btnEdit.Enabled = True
        Button2.Enabled = True
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim WR As New StreamWriter(OFD.FileName)
        WR.WriteLine(EditorRichTextBox.Text)
        WR.Close()
        Dispose()
    End Sub
End Class
