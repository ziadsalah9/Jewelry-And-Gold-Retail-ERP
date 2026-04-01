Imports PACICardLibrary

Public Class AddCustomer
    Public a As Integer

    Public Sub AD()
        If IsDBNull(CastomerCAIVELidTextBox.Text) Then
            btnAdd.Enabled = True
        ElseIf Not IsDBNull(CastomerCAIVELidTextBox.Text) Then
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub invoce_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub AddCustomer_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        'TODO: This line of code loads data into the 'DT_restrantDataSet.Settings' table. You can move, or remove it, as needed.
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        language_start(Name)
        DateTimePicker1.Value = Date.Now
        txtCID.Select()
        txtCID.Focus()

        CheckBox3.Checked = True
        CheckBox4.Checked = True
        CheckBox5.Checked = True
        label.Visible = False
        If frmLogin.rbtnAr.Checked = True Then
            txtCID.Text = "أدخل الرقم المدني"
        Else
            txtCID.Text = "Enter Civil ID No."
        End If

        ComboBox2.Text = 1
        DateDateTimePicker.Text = Date.Now
        Invoc_date_timeTextBox.Text = Date.Now
        TextBox27.Text = Format(Now, "short Date")
        pbCID.BackgroundImageLayout = ImageLayout.Stretch
        cardConnected = False
        CardServiceStart()
    End Sub
    Private Sub txtCID_TextChanged(sender As Object, e As EventArgs) Handles txtCID.TextChanged
        'If IsNumeric(txtCID.Text.Trim) = True Then
        GetCustomerDetails()
        'End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCID.Text.Trim = "" OrElse IsNumeric(txtCID.Text.Trim) = False Then
            MsgBox("أدخل الرقم المدني بشكل صحيح" & vbCrLf & "Enter CID Correctly!", , Apptitle)
            txtCID.Focus()
            txtCID.SelectAll()
            Exit Sub
        End If
        If txtName.Text.Trim = "" Then
            MsgBox("أدخل اسم العميل بشكل صحيح" & vbCrLf & "Enter Customer Name Correctly!", , Apptitle)
            txtName.Focus()
            txtName.SelectAll()
            Exit Sub
        End If

        If txtAddress.Text.Trim = "" Then
            MsgBox("أدخل عنوانا صحيحا" & vbCrLf & "Enter Address Correctly!", , Apptitle)
            txtAddress.Focus()
            txtAddress.SelectAll()
            Exit Sub
        End If

        If txtPhone.Text.Trim = "" OrElse IsNumeric(txtPhone.Text.Trim) = False Then
            MsgBox("أدخل رقم هاتف صحيح" & vbCrLf & "Enter Phone Correctly!", , Apptitle)
            txtPhone.Focus()
            txtPhone.SelectAll()
            Exit Sub
        End If

        If txtNationality.Text.Trim = "" Then
            MsgBox("أدخل جنسية العميل" & vbCrLf & "Enter Nationality Correctly!", , Apptitle)
            txtNationality.Focus()
            txtNationality.SelectAll()
            Exit Sub
        End If

        If Not IsDBNull(CastomerCAIVELidTextBox.Text.Trim) Then
            CastomerDETELSTableAdapter.GetDataBy(txtCID.Text.Trim)
            If DT_restrantDataSet.Tables("CastomerDETELS").Rows.Count > 0 Then
                If MsgBox("هل تريد تحديث البيانات؟" & vbCrLf & "Update Customer Data?", MsgBoxStyle.YesNo, AppTitle) = MsgBoxResult.Yes Then
                    UpdateCustomer() 'Update
                End If
            Else
                AddNewCustomer() 'Add New
            End If
        Else
            MsgBox("عميل مسجل مسبقا" & vbCrLf & "Customer Already Registered!", , AppTitle)
            Close()
            Exit Sub
        End If
    End Sub

    Private Sub CastomerNAmeTextBox_TextChanged(sender As Object, e As EventArgs) Handles CastomerNAmeTextBox.TextChanged
        txtName.Text = CastomerNAmeTextBox.Text.Trim
        TextBox25.Text = Val(ItemIDTextBox.Text) + 1
    End Sub

    Private Sub CastomerADrTextBox_TextChanged(sender As Object, e As EventArgs) Handles CastomerADrTextBox.TextChanged
        txtAddress.Text = CastomerADrTextBox.Text.Trim
    End Sub

    Private Sub CastomerTETextBox_TextChanged(sender As Object, e As EventArgs) Handles CastomerTETextBox.TextChanged
        txtPhone.Text = CastomerTETextBox.Text.Trim
    End Sub

    Private Sub CastomerNATextBox_TextChanged(sender As Object, e As EventArgs) Handles CastomerNATextBox.TextChanged
        txtNationality.Text = CastomerNATextBox.Text.Trim
    End Sub
    Private Sub IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles IDTextBox.TextChanged
        TextBox9.Text = IDTextBox.Text
    End Sub

    Private Sub FO_nameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FO_nameTextBox.TextChanged
        TextBox11.Text = FO_nameTextBox.Text
    End Sub

    Private Sub FO_despTextBox_TextChanged(sender As Object, e As EventArgs) Handles FO_despTextBox.TextChanged
        TextBox12.Text = FO_despTextBox.Text
    End Sub

    Private Sub FO_madeTextBox_TextChanged(sender As Object, e As EventArgs) Handles FO_madeTextBox.TextChanged
        TextBox19.Text = FO_madeTextBox.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            TextBox26.Text = TextBox24.Text + Val(TextBox23.Text)
            TextBox27.Text = Format(Now, "short Date")
            CashTextBox1.Text = TextBox27.Text
            label.Visible = False
        Catch ex As Exception
            MsgBox("بعض الحقول الهامة مفقودة" & vbCrLf & "Missing Data!", , "خطأ")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnScannerSettings_Click(sender As Object, e As EventArgs) Handles btnScannerSettings.Click
        Process.Start(Application.StartupPath & "\Scanner.exe").WaitForExit()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\MyImage.JPG") = True Then
            pbCID.Image = Image.FromFile(Application.StartupPath & "\MyImage.JPG")
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If SET_INVARCHR143TextBox.Text <> "1" Then
            MsgBox("لم يتم تفعيل قارئ البطاقة المدنية" & vbCrLf & "Card Reader is not Activated", , "خطأ")
            Exit Sub
        End If
        Try
            If cardConnected Then
                txtCID.Text = paci.Civil_ID(0).Trim
                txtName.Text = paci.Arabic_Name_1(0).Trim & " " & paci.Arabic_Name_2(0).Trim & " " & paci.Arabic_Name_3(0).Trim & " " & paci.Arabic_Name_4(0).Trim
                txtAddress.Text = paci.District(0).Trim & ",مبنى" & paci.Building_Plot_Number(0).Trim & "," & paci.Street_Name(0).Trim
                txtPhone.Text = paci.Telephone_1(0).Trim
                txtNationality.Text = paci.Nationality_Arabic(0).Trim '& " ,  الوظيفة/ " & paci.Additional_F_1(0).Trim
                'txtNationality.Text = "الجنسية" & "  " & paci.Nationality_Arabic(0).Trim & " " & paci.Additional_F_1(0).Trim

                Label30.Text = paci.Civil_ID(0).Trim
                Label36.Text = paci.Arabic_Name_Full(0).Trim
                Label35.Text = paci.English_Name_Full(0).Trim
                Label40.Text = paci.Sex_Arabic(0).Trim
                Label41.Text = paci.Sex_English(0).Trim
                Label38.Text = paci.Nationality_Arabic(0).Trim
                Label39.Text = paci.Nationality_English(0).Trim
                Label42.Text = paci.Birthdate(0).Trim
                Label43.Text = paci.Card_Expiry_Date(0).Trim
                Label37.Text = paci.Passport(0).Trim
                Dim bart1 As String
                Dim bart2 As String
                Dim bart3 As String
                Dim s As String = paci.Birthdate(0)
                bart1 = Mid(s, 5, 2)
                bart2 = Mid(s, 7, 2)
                bart3 = Mid(s, 1, 4)
                Label42.Text = bart2 & "/" & bart1 & "/" & bart3
                'label24.Text = bart2 & "/" & bart1 & "/" & bart3
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                Dim t1 As String
                Dim t2 As String
                Dim t3 As String
                Dim exbir As String = paci.Card_Expiry_Date(0)
                t1 = Mid(exbir, 5, 2)
                t2 = Mid(exbir, 7, 2)
                t3 = Mid(exbir, 1, 4)
                Label43.Text = t2 & "/" & t1 & "/" & t3

                Try
                    Dim photo As String = paci.Photo(0)
                    Dim photoBytes() As Byte = PACMAN.ConvertToByteArray(photo)
                    CSJ2K.Util.BitmapImageCreator.Register()
                    Dim decodedImage = CSJ2K.J2kImage.FromBytes(photoBytes)
                    Dim bitmap = decodedImage.As(Of Bitmap)()
                    PictureBox5.Image = bitmap
                    PictureBox6.Image = bitmap
                    PictureBox5.Visible = True
                    PictureBox6.Visible = True
                Catch e1 As Exception
                    MessageBox.Show("An Error Occurred While Fetching The Picture, Please Try Again")
                End Try
            Else

            End If
            Label14.Text = Label30.Text
            Label12.Text = Label36.Text
            Label13.Text = Label35.Text
            Label10.Text = Label38.Text
            Label9.Text = Label39.Text
            Label8.Text = Label40.Text
            Label7.Text = Label41.Text
            Label6.Text = Label42.Text
            Label5.Text = Label43.Text

            If Label39.Text = "KWT" Then
                Dim KUW As New Bitmap(Panel1.Width, Panel1.Height)
                Panel2.DrawToBitmap(KUW, New Rectangle(Point.Empty, Panel2.Size))
                pbCID.Image = KUW

            Else
                Dim img As New Bitmap(Panel1.Width, Panel1.Height)
                Panel1.DrawToBitmap(img, New Rectangle(Point.Empty, Panel1.Size))
                pbCID.Image = img
            End If
        Catch ex As Exception
            MsgBox("تأكد من إدخال البطاقة المدنية" & vbCrLf & "Please Make Sure Civid ID is Inserted Correctly", , "خطأ")
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnAddSignature.LinkClicked
        TestSigCapt.TestSigCapt.ShowDialog()
        TestSigCapt.TestSigCapt.Dispose()
    End Sub
    Public Sub AddNewCustomer()
        Try
            CastomerDETELSBindingSource.AddNew()
            CastomerCAIVELidTextBox.Text = Val(txtCID.Text.Trim)
            CastomerNAmeTextBox.Text = txtName.Text.Trim
            CastomerADrTextBox.Text = txtAddress.Text.Trim
            CastomerTETextBox.Text = Val(txtPhone.Text)
            CastomerNATextBox.Text = txtNationality.Text.Trim
            FotoPictureBox.Image = pbCID.Image
            SignaturePictureBox.Image = pbSignature.Image
            ValidateChildren()
            CastomerDETELSBindingSource.EndEdit()
            CastomerDETELSTableAdapter.Update(DT_restrantDataSet.CastomerDETELS)
            'MsgBox("تم إضافة العميل بنجاح" & vbCrLf & "Customer Added Successfully!", , "إضافة عميل جديد")
            Clipboard.SetText(txtCID.Text.Trim)
            Close()
        Catch ex As Exception
            MsgBox("عميل مسجل مسبقا", , AppTitle)
            MsgBox(ex.Message.ToString, , AppTitle)
            Close()
        End Try
    End Sub
    Public Sub UpdateCustomer()
        Try
            CastomerCAIVELidTextBox.Text = txtCID.Text.Trim
            CastomerNAmeTextBox.Text = txtName.Text.Trim
            CastomerADrTextBox.Text = txtAddress.Text.Trim
            CastomerTETextBox.Text = txtPhone.Text.Trim
            CastomerNATextBox.Text = txtNationality.Text.Trim
            FotoPictureBox.Image = pbCID.Image
            SignaturePictureBox.Image = pbSignature.Image
            ValidateChildren()
            CastomerDETELSBindingSource.EndEdit()
            CastomerDETELSTableAdapter.Update(DT_restrantDataSet.CastomerDETELS)
            'MsgBox("تم تحديث بيانات العميل بنجاح" & vbCrLf & "Customer Updated Successfully", , Apptitle)
            Clipboard.SetText(txtCID.Text.Trim)
            Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub GetCustomerDetails()
        CastomerDETELSTableAdapter.FillBy(DT_restrantDataSet.CastomerDETELS, txtCID.Text.Trim)
        pbCID.Image = FotoPictureBox.Image
        pbSignature.Image = SignaturePictureBox.Image
    End Sub

    Private Sub pbCID_DoubleClick(sender As Object, e As EventArgs) Handles pbCID.DoubleClick
        If pbCID.Image Is Nothing Then
            pbCID.Image = Nothing
        Else
            If MsgBox("هل تريد حذف صورة العميل؟" & vbCrLf & "Delete Customer CID Photo?", vbYesNo) = MsgBoxResult.Yes Then
                pbCID.Image = Nothing
            End If
        End If
    End Sub
End Class