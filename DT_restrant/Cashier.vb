Public Class Cashier
    Dim CID As String


    Private Sub Cacher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub GridSelectionChanged()
        If grid.RowCount >= 0 AndAlso grid.SelectedRows.Count > 0 Then
            Cacher_nameTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colcacher_name").Value), "", (grid.SelectedRows(0).Cells("colcacher_name").Value))
            txtCID.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colsvil_id").Value), "", grid.SelectedRows(0).Cells("colsvil_id").Value)
            AdrTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells("coladr").Value), "", grid.SelectedRows(0).Cells("coladr").Value)
            GetImg()
        End If
    End Sub
    Private Sub GetImg()
        pbSignature.Image = Nothing
        Dim GetImge As DataTable = GetRecordSet("Select * from cacher where svil_id=N'" & txtCID.Text.Trim & "'")
        If GetImge.Rows.Count > 0 Then
            If Not IsDBNull((GetImge.Rows(0)("CashierSignature"))) Then
                pbSignature.Image = ByteToImage(GetImge.Rows(0)("CashierSignature"))
            ElseIf IsDBNull((GetImge.Rows(0)("CashierSignature"))) Then
            End If
        End If
    End Sub



    Private Sub LodData()
        Dim LodDt As DataTable = GetRecordSet("Select * from cacher where Active =1")
        If LodDt.Rows.Count > 0 Then
            For i As Integer = 0 To LodDt.Rows.Count - 1
                With (grid)
                    .Rows.Add()
                    .Rows(i).Cells("colcacherID").Value = (LodDt.Rows(i)("cacherID").ToString)
                    .Rows(i).Cells("colcacher_name").Value = (LodDt.Rows(i)("cacher_name").ToString)
                    .Rows(i).Cells("coladr").Value = (LodDt.Rows(i)("adr").ToString)
                    .Rows(i).Cells("colsvil_id").Value = (LodDt.Rows(i)("svil_id").ToString)
                    .Rows(i).Cells("colCashierSignature").Value = (LodDt.Rows(i)("CashierSignature").ToString)
                    'CashierSignature
                End With
            Next
        End If

    End Sub
    Private Sub Cacher_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GredDsin(grid)
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        LodData()

        'grid.Columns("cacherID").Visible = False
        ControlsEnabled(False)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'CacherBindingSource.AddNew()
        ControlsEnabled(True)
        Cacher_nameTextBox.Text = ""
        AdrTextBox.Text = ""
        txtCID.Text = ""
        pbSignature.Image = Nothing
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
        Cacher_nameTextBox.Focus()
    End Sub
    Private Function ImageToBytes(img As Image) As Byte()
        If img Is Nothing Then Return Nothing
        Using ms As New IO.MemoryStream()
            img.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Cacher_nameTextBox.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الكاشير " & vbCrLf & "Please Enter Cacher Name", , AppTitle)
            Cacher_nameTextBox.Focus()
            Exit Sub
        End If

        If AdrTextBox.Text.Trim = "" Then
            MsgBox("يرجى إدخال العنوان" & vbCrLf & "Please Enter Address", , AppTitle)
            AdrTextBox.Focus()
            Exit Sub
        End If

        If txtCID.Text.Trim = "" Then
            MsgBox("يرجى إدخال الرقم المدني" & vbCrLf & "Please Enter SivilID", , AppTitle)
            txtCID.Focus()
            Exit Sub
        End If

        GlCommand.CommandText = "SELECT COUNT(*) FROM [dbo].[cacher] WHERE [svil_id] = @svil_id"
        GlCommand.Parameters.Clear()
        GlCommand.Parameters.AddWithValue("@svil_id", txtCID.Text.Trim())
        Dim count As Integer = Convert.ToInt32(GlCommand.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("⚠️ هذا الرقم المدني موجود مسبقًا - Duplicate entry!",
                        "تنبيه / Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            GlCommand.CommandText =
        "INSERT INTO [dbo].[cacher] " &
        "([cacher_name],[start_wark],[full_name],[adr],[svil_id],[CashierSignature],[Active]) " &
        "VALUES (@cacher_name,@start_wark,@full_name,@adr,@svil_id,@CashierSignature,@Active)"
            GlCommand.Parameters.Clear()
            GlCommand.Parameters.AddWithValue("@cacher_name", Cacher_nameTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@start_wark", DateTime.Now) ' أو قيمة من DateTimePicker
            GlCommand.Parameters.AddWithValue("@full_name", Cacher_nameTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@adr", AdrTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@svil_id", txtCID.Text.Trim())
            GlCommand.Parameters.AddWithValue("@Active", 1)

            ' تحويل الصورة إلى بايتات
            Dim imgBytes As Byte() = Nothing
            If pbSignature.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    pbSignature.Image.Save(ms, Imaging.ImageFormat.Png)
                    imgBytes = ms.ToArray()
                End Using
                GlCommand.Parameters.Add("@CashierSignature", SqlDbType.Image).Value = imgBytes
            Else
                GlCommand.Parameters.Add("@CashierSignature", SqlDbType.Image).Value = DBNull.Value
            End If
            GlCommand.ExecuteNonQuery()




            Dim rowIndex As Integer = grid.Rows.Add()
            Dim row As DataGridViewRow = grid.Rows(rowIndex)
            row.Cells("colcacher_name").Value = Cacher_nameTextBox.Text.Trim()
            row.Cells("coladr").Value = AdrTextBox.Text.Trim()
            row.Cells("colsvil_id").Value = txtCID.Text.Trim()
            MessageBox.Show("تمت الإضافة بنجاح - Inserted successfully", "رسالة / Message",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnDel.Enabled = True
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString())
            MessageBox.Show("خطأ أثناء الإضافة: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If grid.RowCount = 0 Then
            MsgBox("لا توجد بيانات" & vbCrLf & "No Data!", , "فارغ ---- Empty")
            Exit Sub
        End If
        If MsgBox("هل تريد حذف الصنف المحدد؟" & vbCrLf & "Do You Want To Delete The Selected Item?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            GlCommand.CommandText = "UPDATE [DT_restrant].[dbo].[cacher] SET [Active]=0 WHERE [svil_id]=N'" & txtCID.Text.Trim & "'"
            GlCommand.ExecuteNonQuery()
            If grid.RowCount = 0 Then
                MsgBox("تم حذف جميع البيانات" & vbCrLf & "All Data Has been Deleted", , "فارغ ---- Empty")
            End If
        Else
            MsgBox("تم الغاء العمليه")
            Exit Sub
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        CID = txtCID.Text.Trim
        ControlsEnabled(True)
    End Sub

    Private Sub ControlsEnabled(Status As Boolean)
        Cacher_nameTextBox.Enabled = Status

        AdrTextBox.Enabled = Status
        txtCID.Enabled = Status
    End Sub

    Private Sub pbSignature_DoubleClick(sender As Object, e As EventArgs) Handles pbSignature.DoubleClick
        If MsgBox("هل تريد حذف التوقيع؟" & vbCrLf & "Delete Signature?", vbYesNo) = MsgBoxResult.Yes Then
            pbSignature.Image = Nothing
        End If
    End Sub

    Private Sub lnkSignature_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignature.LinkClicked
        Try
            Dim OFD As New OpenFileDialog
            OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
            With OFD
                If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If OFD.FileName.Trim <> "" Then
                        pbSignature.Image = Image.FromFile(.FileName)
                    Else
                        MsgBox("يرجى تحديد صورة" & vbCrLf & "Please Select an Image", , Apptitle)
                        Exit Sub
                    End If
                Else
                    Return
                End If
            End With
            pbSignature.BackgroundImageLayout = ImageLayout.Zoom
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , Apptitle)
        End Try
    End Sub

    Private Sub lblCID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCID.Click

    End Sub

    Private Sub lnkSignature2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignature2.LinkClicked
        TestSigCapt.TestSigCapt.ShowDialog(Me)
        If IsNothing(SignatureImage) = False Then
            pbSignature.Image = SignatureImage
        End If
        TestSigCapt.TestSigCapt.Dispose()
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        GridSelectionChanged()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            GlCommand.CommandText = "UPDATE [dbo].[cacher]  SET [Active] =0 WHERE [svil_id]= '" & txtCID.Text.Trim & "'"
            GlCommand.ExecuteNonQuery()
            MessageBox.Show("تم الحذف بنجاح - Deleted successfully", "رسالة / Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If grid.CurrentRow IsNot Nothing AndAlso Not grid.CurrentRow.IsNewRow Then
                grid.Rows.RemoveAt(grid.CurrentRow.Index)
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
            MsgBox(ex.ToString, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class