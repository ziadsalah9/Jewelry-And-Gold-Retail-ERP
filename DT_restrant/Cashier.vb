Public Class Cashier
    Dim CID As String
    Dim isEditMode As Boolean = False
    Dim currentID As Integer = 0
    Dim isLoading As Boolean = False  ' ✅ علم لمنع الأحداث أثناء تحميل البيانات

    Private Sub Cacher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub GridSelectionChanged()
        ' ✅ إذا كنا في وضع التحميل، لا تفعل شيئاً
        If isLoading Then Exit Sub

        If grid.RowCount > 0 AndAlso grid.SelectedRows.Count > 0 Then
            currentID = Val(grid.SelectedRows(0).Cells("colcacherID").Value)
            Cacher_nameTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colcacher_name").Value), "", grid.SelectedRows(0).Cells("colcacher_name").Value)
            txtCID.Text = If(IsDBNull(grid.SelectedRows(0).Cells("colsvil_id").Value), "", grid.SelectedRows(0).Cells("colsvil_id").Value)
            AdrTextBox.Text = If(IsDBNull(grid.SelectedRows(0).Cells("coladr").Value), "", grid.SelectedRows(0).Cells("coladr").Value)
            txttelno.Text = If(IsDBNull(grid.SelectedRows(0).Cells("coltel_no").Value), "", grid.SelectedRows(0).Cells("coltel_no").Value.ToString())

            GetImg()

            isEditMode = False
            ControlsEnabled(False)
            btnSave.Enabled = False
            btnNew.Enabled = True
            btnDel.Enabled = True   ' ✅ تفعيل زر الحذف عند اختيار صف
            btnedit.Enabled = True
        End If
    End Sub

    Private Sub GetImg()
        pbSignature.Image = Nothing
        If txtCID.Text.Trim = "" Then Exit Sub  ' ✅ تجنب الاستعلام بقيمة فارغة

        Try
            Dim GetImge As DataTable = GetRecordSet("Select CashierSignature from cacher where svil_id=N'" & txtCID.Text.Trim & "'")
            If GetImge.Rows.Count > 0 Then
                If Not IsDBNull(GetImge.Rows(0)("CashierSignature")) Then
                    pbSignature.Image = ByteToImage(GetImge.Rows(0)("CashierSignature"))
                End If
            End If
        Catch ex As Exception
            ' لو حصل خطأ في تحميل الصورة نتجاهله فقط
        End Try
    End Sub

    Private Sub LodData()
        isLoading = True  ' ✅ أوقف أحداث الجريد

        grid.Rows.Clear()

        Try
            Dim LodDt As DataTable = GetRecordSet("Select * from cacher where Active=1")
            If LodDt.Rows.Count > 0 Then
                For i As Integer = 0 To LodDt.Rows.Count - 1
                    With grid
                        .Rows.Add()
                        .Rows(i).Cells("colcacherID").Value = LodDt.Rows(i)("cacherID").ToString()
                        .Rows(i).Cells("colcacher_name").Value = If(IsDBNull(LodDt.Rows(i)("cacher_name")), "", LodDt.Rows(i)("cacher_name").ToString())
                        .Rows(i).Cells("coladr").Value = If(IsDBNull(LodDt.Rows(i)("adr")), "", LodDt.Rows(i)("adr").ToString())
                        .Rows(i).Cells("colsvil_id").Value = If(IsDBNull(LodDt.Rows(i)("svil_id")), "", LodDt.Rows(i)("svil_id").ToString())
                        .Rows(i).Cells("coltel_no").Value = If(IsDBNull(LodDt.Rows(i)("tel_no")), "", LodDt.Rows(i)("tel_no").ToString())
                    End With
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            isLoading = False  ' ✅ أعد تفعيل الأحداث دائماً حتى لو حصل خطأ
        End Try

        ' ✅ بعد التحميل، شغّل GridSelectionChanged يدوياً للصف المحدد
        GridSelectionChanged()
    End Sub

    Private Sub Cacher_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GredDsin(grid)
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        LodData()
        ControlsEnabled(False)
        btnDel.Enabled = False
        btnedit.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isEditMode = False
        currentID = 0
        ControlsEnabled(True)
        Cacher_nameTextBox.Text = ""
        AdrTextBox.Text = ""
        txtCID.Text = ""
        txttelno.Text = ""
        pbSignature.Image = Nothing
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDel.Enabled = False
        btnedit.Enabled = False
        Cacher_nameTextBox.Focus()
    End Sub

    Private Function ImageToBytes(img As Image) As Byte()
        If img Is Nothing Then Return Nothing
        Using ms As New IO.MemoryStream()
            img.Save(ms, Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub ResetUIAfterSave()
        ' ✅ إعادة ضبط الواجهة بعد الحفظ
        ControlsEnabled(False)
        btnNew.Enabled = True
        btnSave.Enabled = False
        btnDel.Enabled = True
        btnedit.Enabled = True
        isEditMode = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' --- التحقق من البيانات المطلوبة ---
        If Cacher_nameTextBox.Text.Trim = "" Then
            MsgBox("يرجى إدخال اسم الكاشير" & vbCrLf & "Please Enter Cacher Name", , AppTitle)
            Cacher_nameTextBox.Focus()
            Exit Sub
        End If

        ' --- التحقق من تكرار الرقم المدني (للإضافة فقط) ---
        If isEditMode = False AndAlso txtCID.Text.Trim <> "" Then
            Try
                GlCommand.CommandText = "SELECT COUNT(*) FROM [dbo].[cacher] WHERE [svil_id] = @check_id AND [Active]=1"
                GlCommand.Parameters.Clear()
                GlCommand.Parameters.AddWithValue("@check_id", txtCID.Text.Trim())
                Dim count As Integer = Convert.ToInt32(GlCommand.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("⚠️ هذا الرقم المدني مسجل مسبقاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtCID.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                ' ✅ لا نبلع الخطأ - نُظهره للمستخدم
                MessageBox.Show("خطأ في التحقق من الرقم المدني: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If

        ' --- الحفظ أو التعديل ---
        Try
            GlCommand.Parameters.Clear()

            If isEditMode = True Then
                ' ✅ تعديل
                GlCommand.CommandText =
                    "UPDATE [dbo].[cacher] SET " &
                    "[cacher_name]=@cacher_name, [full_name]=@full_name, " &
                    "[adr]=@adr, [svil_id]=@svil_id, [tel_no]=@tel_no, " &
                    "[CashierSignature]=@CashierSignature " &
                    "WHERE [cacherID]=@id"
                GlCommand.Parameters.AddWithValue("@id", currentID)
            Else
                ' ✅ إضافة جديدة
                GlCommand.CommandText =
                    "INSERT INTO [dbo].[cacher] " &
                    "([cacher_name],[start_wark],[full_name],[adr],[svil_id],[tel_no],[CashierSignature],[Active]) " &
                    "VALUES (@cacher_name,@start_wark,@full_name,@adr,@svil_id,@tel_no,@CashierSignature,@Active)"
                GlCommand.Parameters.AddWithValue("@start_wark", DateTime.Now)
                GlCommand.Parameters.AddWithValue("@Active", 1)
            End If

            ' المعاملات المشتركة
            GlCommand.Parameters.AddWithValue("@cacher_name", Cacher_nameTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@full_name", Cacher_nameTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@adr", AdrTextBox.Text.Trim())
            GlCommand.Parameters.AddWithValue("@svil_id", txtCID.Text.Trim())
            GlCommand.Parameters.AddWithValue("@tel_no", txttelno.Text.Trim())

            ' الصورة
            If pbSignature.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    pbSignature.Image.Save(ms, Imaging.ImageFormat.Png)
                    GlCommand.Parameters.Add("@CashierSignature", SqlDbType.Image).Value = ms.ToArray()
                End Using
            Else
                GlCommand.Parameters.Add("@CashierSignature", SqlDbType.Image).Value = DBNull.Value
            End If

            GlCommand.ExecuteNonQuery()

            ' ✅ إعادة تحميل الجريد
            LodData()

            MessageBox.Show(If(isEditMode, "تم التعديل بنجاح ✅", "تمت الإضافة بنجاح ✅"),
                            "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ResetUIAfterSave()

        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString())
            MessageBox.Show("خطأ أثناء الحفظ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ✅ isEditMode مش محتاج تتغير هنا، بتتغير في GridSelectionChanged
    Private Sub ControlsEnabled(Status As Boolean)
        Cacher_nameTextBox.Enabled = Status
        AdrTextBox.Enabled = Status
        txtCID.Enabled = Status
        txttelno.Enabled = Status  ' ✅ كانت ناقصة!
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
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                If OFD.FileName.Trim <> "" Then
                    pbSignature.Image = Image.FromFile(OFD.FileName)
                End If
            End If
            pbSignature.BackgroundImageLayout = ImageLayout.Zoom
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , AppTitle)
        End Try
    End Sub

    Private Sub lnkSignature2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignature2.LinkClicked
        TestSigCapt.TestSigCapt.ShowDialog(Me)
        If IsNothing(SignatureImage) = False Then
            pbSignature.Image = SignatureImage
        End If
        TestSigCapt.TestSigCapt.Dispose()
    End Sub

    Private Sub grid_SelectionChanged(sender As Object, e As EventArgs) Handles grid.SelectionChanged
        GridSelectionChanged()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If currentID = 0 Then
            MsgBox("الرجاء اختيار كاشير من القائمة أولاً", MsgBoxStyle.Exclamation, "تنبيه")
            Exit Sub
        End If

        If MsgBox("هل تريد حذف الكاشير المحدد؟" & vbCrLf & "Do You Want To Delete?",
                  MsgBoxStyle.OkCancel, AppTitle) = MsgBoxResult.Ok Then
            Try
                GlCommand.CommandText = "UPDATE [dbo].[cacher] SET [Active]=0 WHERE [cacherID]=@id"
                GlCommand.Parameters.Clear()
                GlCommand.Parameters.AddWithValue("@id", currentID)
                GlCommand.ExecuteNonQuery()

                MessageBox.Show("تم الحذف بنجاح ✅", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                currentID = 0
                LodData()

                ' تفريغ الحقول
                Cacher_nameTextBox.Text = ""
                AdrTextBox.Text = ""
                txtCID.Text = ""
                txttelno.Text = ""
                pbSignature.Image = Nothing
                btnDel.Enabled = False
                btnedit.Enabled = False

            Catch ex As Exception
                RecordRrrors(DescriptionRrrors:=ex.ToString())
                MsgBox("خطأ أثناء الحذف: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnedit_Click_1(sender As Object, e As EventArgs) Handles btnedit.Click
        If currentID = 0 Then
            MsgBox("الرجاء اختيار كاشير من القائمة أولاً", MsgBoxStyle.Exclamation, "تنبيه")
            Exit Sub
        End If

        isEditMode = True
        ControlsEnabled(True)
        btnSave.Enabled = True
        btnNew.Enabled = False
        btnDel.Enabled = False
        Cacher_nameTextBox.Focus()
    End Sub
End Class