Public Class CompanyDetails

    Private Sub comp_detels_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub comp_detels_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        Dim DT As DataTable = GetRecordSet("Select * from [comp_inform]")
        If DT.Rows.Count > 0 Then
            Comp_nameTextBox.Text = DT.Rows(0)("comp_name").ToString()
            Comp_adrsTextBox.Text = DT.Rows(0)("comp_adrs").ToString()
            Comp_faxTextBox.Text = DT.Rows(0)("comp_fax").ToString()
            Comp_emailTextBox.Text = DT.Rows(0)("comp_email").ToString()
            Comp_note1TextBox.Text = DT.Rows(0)("comp_note1").ToString()
            Comp_note11TextBox.Text = DT.Rows(0)("comp_note11").ToString()
            Co_instagramTextBox.Text = DT.Rows(0)("comp_note13").ToString()
            Dim logoObj = DT.Rows(0)("logo")
            If Not IsDBNull(logoObj) AndAlso logoObj IsNot Nothing Then
                PicHeaderReport.Image = ByteToImage(CType(logoObj, Byte()))
            Else
                LogoPictureBox.Image = Drawing.Image.FromFile(Application.StartupPath & "\Logo.png")
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim logoObj1 = DT.Rows(0)("logo1")
            If Not IsDBNull(logoObj1) AndAlso logoObj1 IsNot Nothing Then
                PicHeaderReport.Image = ByteToImage(CType(logoObj1, Byte()))
            Else
                PicHeaderReport.Image = Nothing
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim logoObj2 = DT.Rows(0)("logo2")
            If Not IsDBNull(logoObj2) AndAlso logoObj2 IsNot Nothing Then
                PicFooterReport.Image = ByteToImage(CType(logoObj2, Byte()))
            Else
                PicFooterReport.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        DeleteUpdateSqlCommend(SqlComm:="DELETE FROM [comp_inform]")
        LocSqlGlCom.ExecuteReader()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            DeleteUpdateSqlCommend(SqlComm:="INSERT INTO[comp_inform] " & vbCrLf &
                                            "([comp_name]" & vbCrLf &
                                            ",[comp_adrs]" & vbCrLf &
                                             ",[comp_fax]" & vbCrLf &
                                             ",[comp_email]" & vbCrLf &
                                             ",[comp_note1]" & vbCrLf &
                                             ",[comp_note11]" & vbCrLf &
                                             ",[comp_note13]" & vbCrLf &
                                             ",[logo]" & vbCrLf &
                                             ",[logo1]" & vbCrLf &
                                             ",[logo2])" & vbCrLf &
                                             "VALUES " & vbCrLf &
                                             "(@comp_name" & vbCrLf &
                                             ",@comp_adrs" & vbCrLf &
                                             ",@comp_fax" & vbCrLf &
                                             ",@comp_email" & vbCrLf &
                                             ",@comp_note1" & vbCrLf &
                                             ",@comp_note11" & vbCrLf &
                                             ",@comp_note13" & vbCrLf &
                                             ",@logo" & vbCrLf &
                                             ",@logo1" & vbCrLf &
                                             ",@logo2)")

            With LocSqlGlCom.Parameters
                .Clear()
                .AddWithValue("@comp_name", Comp_nameTextBox.Text.Trim())
                .AddWithValue("@comp_adrs", Comp_adrsTextBox.Text.Trim())
                .AddWithValue("@comp_fax", Comp_faxTextBox.Text.Trim())
                .AddWithValue("@comp_email", Comp_emailTextBox.Text.Trim())
                .AddWithValue("@comp_note1", Comp_note1TextBox.Text.Trim())
                .AddWithValue("@comp_note11", Comp_note11TextBox.Text.Trim())
                .AddWithValue("@comp_note13", Co_instagramTextBox.Text.Trim())
                .AddWithValue("@logo", SqlDbType.Image).Value = ImageToByte(LogoPictureBox.Image)
                .AddWithValue("@logo1", SqlDbType.Image).Value = ImageToByte(PicHeaderReport.Image)
                .AddWithValue("@logo2", SqlDbType.Image).Value = ImageToByte(PicFooterReport.Image)
            End With
            LocSqlGlCom.ExecuteReader()
            MsgBox("تم حفظ البيانات بنجاح" & vbCrLf & "The data has been saved successfully", , AppTitle)
            frmMain.LogoPictureBox.Image = LogoPictureBox.Image
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogo.LinkClicked
        Try
            Dim OFD As New OpenFileDialog
            OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
            With OFD
                If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If OFD.FileName.Trim <> "" Then
                        LogoPictureBox.Image = Image.FromFile(.FileName)
                    Else
                        MsgBox("يرجى تحديد صورة" & vbCrLf & "Please Select an Image", , AppTitle)
                        Exit Sub
                    End If
                Else
                    Return
                End If
            End With
            LogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch
            'MsgBox("تم إضافة صورة" & vbCrLf & "Picture added Successfully", , Apptitle)
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , AppTitle)
        End Try
    End Sub

    Private Sub LogoPictureBox_DoubleClick(sender As Object, e As EventArgs) Handles LogoPictureBox.DoubleClick
        If MsgBox("هل تريد حذف الصورة؟" & vbCrLf & "Delete Photo?", vbYesNo) = MsgBoxResult.Yes Then
            LogoPictureBox.Image = Nothing
        End If

    End Sub

    Private Sub BtnHeaderReport_Click(sender As Object, e As EventArgs) Handles BtnHeaderReport.Click
        Try
            Dim OFD As New OpenFileDialog
            OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
            With OFD
                If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If OFD.FileName.Trim <> "" Then
                        PicHeaderReport.Image = Image.FromFile(.FileName)
                    Else
                        MsgBox("يرجى تحديد صورة" & vbCrLf & "Please Select an Image", , AppTitle)
                        Exit Sub
                    End If
                Else
                    Return
                End If
            End With
            PicHeaderReport.BackgroundImageLayout = ImageLayout.Stretch
            'MsgBox("تم إضافة صورة" & vbCrLf & "Picture added Successfully", , Apptitle)
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , AppTitle)
        End Try
    End Sub

    Private Sub BtnFooterReport_Click(sender As Object, e As EventArgs) Handles BtnFooterReport.Click
        Try
            Dim OFD As New OpenFileDialog
            OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
            With OFD
                If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If OFD.FileName.Trim <> "" Then
                        PicFooterReport.Image = Image.FromFile(.FileName)
                    Else
                        MsgBox("يرجى تحديد صورة" & vbCrLf & "Please Select an Image", , AppTitle)
                        Exit Sub
                    End If
                Else
                    Return
                End If
            End With
            PicFooterReport.BackgroundImageLayout = ImageLayout.Stretch
            'MsgBox("تم إضافة صورة" & vbCrLf & "Picture added Successfully", , Apptitle)
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , AppTitle)
        End Try
    End Sub

    Private Sub gb_Enter(sender As Object, e As EventArgs) Handles gb.Enter

    End Sub
End Class