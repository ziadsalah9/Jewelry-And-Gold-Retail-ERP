Imports System.Windows.Forms.Design
Imports PACICardLibrary
Imports System.IO
Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.Encoding
Imports Microsoft.Reporting.WinForms
Imports System.Net.Http
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports System.Net.NetworkInformation
Public Class CivilID
    Dim paci As PACMAN
    Dim CustomerPhoto As Image
    Dim CustomerSignature As Image
    Dim CustomerPhotoBack As Image
    Dim act_sta As String
    Dim uuid, authKey, appKey As String

    Dim apiBaseUrl As String = "https://wplus.sabpay.net"
    Dim requestMessage As String = "برجاء ارسال هويتيك"

    Private Sub CivilID_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            Dim keys = GetAppKeys()
            uuid = keys.UUID
            authKey = keys.AuthKey
            appKey = keys.AppKey
            If uuid = "" Or authKey = "" Or appKey = "" Then
                whawiti.Enabled = True
            End If
        Catch ex As Exception
            whawiti.Enabled = True
        End Try

        ControlsAsColor(ColorSelect:=Me)
        Try
            If EditForm = True Then
                Width = 650
                Height = 680
                gbCustomerData.Width = Width
                gbCustomerData.Height = 380
                pnlData.Left = 0
                pnlData.Top = 20
                pnlData.Height = 220
                pnlPhotoData.Width = Width
                pnlPhotoData.Height = 200
                pnlPhotoData.Top = pnlData.Top + pnlData.Height
                pnlPhotoData.Left = 0
                pnlPhotoControl.Left = 315
                pnlPhotoControl.Top = 50
                btnScanner.Height = 45
                btnArEn.Height = btnScanner.Height
                btnMobID.Height = btnScanner.Height
                btnSaveCID.Height = btnScanner.Height
                pbBackCIDPhoto.Height = 140
                pbCIDPhoto.Height = 140
            End If
            CardServiceStart()
            paci = New PACMAN
            CIDLanguage()
        Catch ex As Exception

        End Try
    End Sub



    Public Function SaveCustomerData() As Boolean



        If txtCID.Text.Trim = "" Then
            MsgBox("أدخل الرقم المدني بشكل صحيح" & vbCrLf & "Entar a Valid Civil ID No.", , AppTitle)
            txtCID.Focus()
            txtCID.SelectAll()
            Return False
        End If

        If IsNumeric(txtCID.Text.Trim) = False Then
            If MsgBox("الرقم المدخل ليس رقمًا مدنيًا صحيحا..هل تريد استخدامه؟" & vbCrLf & "Entar a Valid Civil ID No.", vbYesNo, AppTitle) = vbNo Then
                txtCID.Focus()
                txtCID.SelectAll()
                Return False
            End If
        End If

        If txtName.Text.Trim = "" Then
            MsgBox("أدخل اسم العميل بشكل صحيح" & vbCrLf & "Entar a Customer Name", , AppTitle)
            txtName.Focus()
            txtName.SelectAll()
            Return False
        End If
        If txtNationality.Text.Trim = "" Then
            MsgBox("أدخل جنسية العميل", , AppTitle)
            txtNationality.Focus()
            txtNationality.SelectAll()
            Return False
        End If

        If txtAddress.Text.Trim = "" Then
            MsgBox("أدخل عنوانا صحيحا" & vbCrLf & "Entar a Valid Address", , AppTitle)
            txtAddress.Focus()
            txtAddress.SelectAll()
            Return False
        End If
        If IsNumeric(txtPhone.Text.Trim) = False Then
            MsgBox("أدخل رقم هاتف صحيح" & vbCrLf & "Entar a Valid Phone No.", , AppTitle)
            txtPhone.Focus()
            txtPhone.SelectAll()
            Return False
        End If

        If txtPhone.Text.Trim = "" OrElse IsNumeric(txtPhone.Text.Trim) = False Then
            MsgBox("أدخل رقم هاتف صحيح" & vbCrLf & "Entar a Valid Phone No.", , AppTitle)
            txtPhone.Focus()
            txtPhone.SelectAll()
            Return False
        End If

        StrSQL = "SELECT [CastomerCAIVELid] FROM [CastomerDETELS] WHERE [CastomerCAIVELid] = '" & txtCID.Text.Trim & "'"
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        If dt1.Rows.Count > 0 Then 'UPDATE
            GlCommand.CommandText = "UPDATE [CastomerDETELS] SET " &
                                    "[CastomerCAIVELid] = @CustomerCivilID , " &
                                    "[CastomerNAme] =  @CustomerName , " &
                                    "[CastomerNameEn] = @CastomerNameEn , " &
                                    "[CastomerADr] =  @CustomerAddress , " &
                                    "[CastomerTE] = @CustomerPhone , " &
                                    "[CastomerNA] = @CustomerNationality , " &
                                    "[CastomerCAIVELidKYC] = @CustomerCivilIDKYC , " &
                                    "[CastomerNAmeKYC] =  @CustomerNameKYC , " &
                                    "[CastomerNameEnKYC] = @CastomerNameEnKYC , " &
                                    "[CastomerADrKYC] =  @CustomerAddressKYC , " &
                                    "[CastomerTEKYC] = @CustomerPhoneKYC , " &
                                    "[CastomerNAKYC] = @CustomerNationalityKYC , " &
                                    "[foto] = @CustomerPhoto , " &
                                    "[Signature] = @CustomerSignature ," &
                                    "[fotoBack] = @CustomerPhotoBack " &
                                    "WHERE [CastomerCAIVELid] = '" & txtCID.Text.Trim & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@CustomerCivilID", txtCID.Text.Trim)
                .AddWithValue("@CustomerName", txtName.Text.Trim)
                .AddWithValue("@CastomerNameEn", txtNameEn.Text.Trim)
                .AddWithValue("@CustomerAddress", txtAddress.Text.Trim)
                .AddWithValue("@CustomerPhone", txtPhone.Text.Trim)
                .AddWithValue("@CustomerNationality", txtNationality.Text.Trim)
                'KYC''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .AddWithValue("@CustomerCivilIDKYC", txtCIDKYC.Text.Trim)
                .AddWithValue("@CustomerNameKYC", txtNameKYC.Text.Trim)
                .AddWithValue("@CastomerNameEnKYC", txtEnNameKYC.Text.Trim)
                .AddWithValue("@CustomerAddressKYC", txtAddressKYC.Text.Trim)
                .AddWithValue("@CustomerPhoneKYC", txtPhoneKYC.Text.Trim)
                .AddWithValue("@CustomerNationalityKYC", txtNationalityKYC.Text.Trim)
                .Add("@CustomerSignature", SqlDbType.Image).Value = If(pbSignature.Image Is Nothing, DBNull.Value, ImageToByte(pbSignature.Image))

                'ziads2
                ' .Add("@CustomerPhoto", SqlDbType.Image).Value = If(pbCIDPhoto.Image Is Nothing, DBNull.Value, ImageToByte(pbCIDPhoto.Image))
                '.Add("@CustomerPhotoBack", SqlDbType.Image).Value = If(pbBackCIDPhoto.Image Is Nothing, DBNull.Value, ImageToByte(pbBackCIDPhoto.Image))
                .Add("@CustomerPhoto", SqlDbType.Image).Value = If(CustomerPhoto Is Nothing, DBNull.Value, ImageToByte(CustomerPhoto))

                'If CustomerPhotoBack Is Nothing Then
                '    MsgBox("الصورة الخلفية فاضية")
                'Else
                '    MsgBox("الصورة الخلفية موجودة")
                'End If
                .Add("@CustomerPhotoBack", SqlDbType.Image).Value = If(CustomerPhotoBack Is Nothing, DBNull.Value, ImageToByte(CustomerPhotoBack))

            End With
            GlCommand.ExecuteNonQuery()
            Return True

        Else 'INSERT
            GlCommand.CommandText = "INSERT INTO CastomerDETELS (" &
                                    "[CastomerCAIVELid] , " &
                                    "[CastomerNAme]  , " &
                                    "[CastomerADr]  , " &
                                    "[CastomerTE] , " &
                                    "[CastomerNA] , " &
                                    "[CastomerCAIVELidKYC] , " &
                                    "[CastomerNAmeKYC]  , " &
                                    "[CastomerADrKYC]  , " &
                                    "[CastomerTEKYC] , " &
                                    "[CastomerNAKYC] , " &
                                    "[foto] , " &
                                    "[Signature] ," &
                                    "[fotoBack] ," &
                                    "[CastomerNameEn], " &
                                    "[CastomerNameEnKYC] " &
                                    ") VALUES" &
                                    "(" &
                                    "@CustomerCivilID ," &
                                    "@CustomerName ," &
                                    "@CustomerAddress ," &
                                    "@CustomerPhone ," &
                                    "@CustomerNationality ," &
                                    "@CustomerCivilIDKYC ," &
                                    "@CustomerNameKYC ," &
                                    "@CustomerAddressKYC ," &
                                    "@CustomerPhoneKYC ," &
                                    "@CustomerNationalityKYC ," &
                                    "@CustomerPhoto ," &
                                    "@CustomerSignature ," &
                                    "@CustomerPhotoBack ," &
                                    "@CustomerNameEn," &
                                    "@CustomerNameEnKYC" &
                                    ")"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@CustomerCivilID", txtCID.Text.Trim)
                .AddWithValue("@CustomerName", txtName.Text.Trim)
                .AddWithValue("@CustomerNameEn", txtNameEn.Text.Trim)
                .AddWithValue("@CustomerAddress", txtAddress.Text.Trim)
                .AddWithValue("@CustomerPhone", txtPhone.Text.Trim)
                .AddWithValue("@CustomerNationality", txtNationality.Text.Trim)
                'KYC'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                .AddWithValue("@CustomerCivilIDKYC", txtCIDKYC.Text.Trim)
                .AddWithValue("@CustomerNameKYC", txtNameKYC.Text.Trim)
                .AddWithValue("@CustomerNameEnKYC", txtEnNameKYC.Text.Trim)
                .AddWithValue("@CustomerAddressKYC", txtAddressKYC.Text.Trim)
                .AddWithValue("@CustomerPhoneKYC", txtPhoneKYC.Text.Trim)
                .AddWithValue("@CustomerNationalityKYC", txtNationalityKYC.Text.Trim)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'Add("@CustomerPhoto", SqlDbType.Image).Value = If(pbCIDPhoto.Image Is Nothing, DBNull.Value, ImageToByte(pbCIDPhoto.Image))
                .Add("@CustomerSignature", SqlDbType.Image).Value = If(pbSignature.Image Is Nothing, DBNull.Value, ImageToByte(pbSignature.Image))
                '.Add("@CustomerPhotoBack", SqlDbType.Image).Value = If(pbBackCIDPhoto.Image Is Nothing, DBNull.Value, ImageToByte(pbBackCIDPhoto.Image))
                .Add("@CustomerPhoto", SqlDbType.Image).Value = If(CustomerPhoto Is Nothing, DBNull.Value, ImageToByte(CustomerPhoto))

                'If CustomerPhotoBack Is Nothing Then
                '    MsgBox("الصورة الخلفية فاضية")
                'Else
                '    MsgBox("الصورة الخلفية موجودة")
                'End If
                .Add("@CustomerPhotoBack", SqlDbType.Image).Value = If(CustomerPhotoBack Is Nothing, DBNull.Value, ImageToByte(CustomerPhotoBack))
            End With
            GlCommand.ExecuteNonQuery()
            Return True
        End If
    End Function
    Private Sub btnSaveCID_Click(sender As Object, e As EventArgs) Handles btnSaveCID.Click
        txtCIDKYC.Text = If(String.IsNullOrWhiteSpace(txtCIDKYC.Text), txtCID.Text, txtCIDKYC.Text)

        'If pbCIDPhoto.Image IsNot Nothing Then
        '    If showingFront Then
        '        CustomerPhoto = pbCIDPhoto.Image
        '    Else
        '        CustomerPhotoBack = pbCIDPhoto.Image
        '    End If
        'End If
        'If pbBackCIDPhoto.Image IsNot Nothing Then
        '    CustomerPhotoBack = pbBackCIDPhoto.Image
        'End If

        If showingFront Then
            If pbCIDPhoto.Image IsNot Nothing Then CustomerPhoto = pbCIDPhoto.Image
        Else
            If pbCIDPhoto.Image IsNot Nothing Then CustomerPhotoBack = pbCIDPhoto.Image
        End If

        ' ← Validation الصور - لازم الاتنين موجودين
        If CustomerPhoto Is Nothing Then
            MsgBox("يرجى رفع صورة الوجه أولاً ثم صورة الظهر" & vbCrLf & "Please upload the Front photo first", , AppTitle)
            Return
        End If

        If CustomerPhotoBack Is Nothing Then
            MsgBox("يرجى رفع صورة الظهر أيضاً" & vbCrLf & "Please upload the Back photo as well", , AppTitle)
            Return
        End If

        txtNameKYC.Text = If(String.IsNullOrWhiteSpace(txtNameKYC.Text), txtName.Text, txtNameKYC.Text)
        txtEnNameKYC.Text = If(String.IsNullOrWhiteSpace(txtEnNameKYC.Text), txtNameEn.Text, txtEnNameKYC.Text)
        txtNationalityKYC.Text = If(String.IsNullOrWhiteSpace(txtNationalityKYC.Text), txtNationality.Text, txtNationalityKYC.Text)
        txtAddressKYC.Text = If(String.IsNullOrWhiteSpace(txtAddressKYC.Text), txtAddress.Text, txtAddressKYC.Text)
        txtPhoneKYC.Text = If(String.IsNullOrWhiteSpace(txtPhoneKYC.Text), txtPhone.Text, txtPhoneKYC.Text)
        If SaveCustomerData() = True Then
            Message("تم الحفظ بنجاح" & vbCrLf & "Saved Successfully")
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        paci = New PACMAN
        If CivilIDactivat = "1" Then
        ElseIf CivilIDactivat = "0" Then
            MsgBox(MsgBox("لم يتم تفعيل قارئ البطاقة المدنية" & vbCrLf & "Card Reader is not Activated", , "خطأ"))
            Exit Sub
        End If
        Try
            act_sta = "1"
            If act_sta = "1" Then
                If cardConnected Then
                    txtCID.Text = paci.Civil_ID(0)
                Else
                    Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
                    Exit Sub
                End If
                GetCustomerData()
            ElseIf act_sta = "0" Then
                Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
            End If
        Catch ex As Exception
            Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
        End Try
    End Sub

    Public Sub GetCustomerData()
        StrSQL = "SELECT * FROM [CastomerDETELS] WHERE [CastomerCAIVELid] = '" & txtCID.Text.Trim & "'"
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        If dt1.Rows.Count > 0 Then
            txtName.Text = dt1.Rows(0)("CastomerNAme").ToString
            txtNameEn.Text = dt1.Rows(0)("CastomerNameEn").ToString
            txtAddress.Text = dt1.Rows(0)("CastomerADr").ToString
            txtPhone.Text = dt1.Rows(0)("CastomerTE").ToString
            txtNationality.Text = dt1.Rows(0)("CastomerNA").ToString
            'KYC''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txtNameKYC.Text = dt1.Rows(0)("CastomerNAmeKYC").ToString
            txtEnNameKYC.Text = dt1.Rows(0)("CastomerNameEnKYC").ToString
            txtAddressKYC.Text = dt1.Rows(0)("CastomerADrKYC").ToString
            txtPhoneKYC.Text = dt1.Rows(0)("CastomerTEKYC").ToString
            txtNationalityKYC.Text = dt1.Rows(0)("CastomerNAKYC").ToString
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            pbCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("foto")), Nothing, ByteToImage(dt1.Rows(0)("foto")))
            pbSignature.Image = If(IsDBNull(dt1.Rows(0)("Signature")), Nothing, ByteToImage(dt1.Rows(0)("Signature")))
            pbBackCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("fotoBack")), Nothing, ByteToImage(dt1.Rows(0)("fotoBack")))

            'zizo
            CustomerPhoto = pbCIDPhoto.Image
            CustomerPhotoBack = pbBackCIDPhoto.Image
            showingFront = True


            chkCIDPhoto.Checked = True
            chkSignature.Checked = True
            GetLastInvoceData()
        Else
            ClearData()
        End If
    End Sub
    Public Sub GetCustomerDataBayCastomerTE()
        StrSQL = "SELECT * FROM [CastomerDETELS] WHERE [CastomerTE] = '" & txtPhone.Text.Trim & "'"
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        If dt1.Rows.Count > 0 Then
            txtCID.Text = dt1.Rows(0)("CastomerCAIVELid").ToString
            txtName.Text = dt1.Rows(0)("CastomerNAme").ToString
            txtNameEn.Text = dt1.Rows(0)("CastomerNameEn").ToString
            txtAddress.Text = dt1.Rows(0)("CastomerADr").ToString
            txtNationality.Text = dt1.Rows(0)("CastomerNA").ToString
            'KYC''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txtCIDKYC.Text = dt1.Rows(0)("CastomerCAIVELidKYC").ToString
            txtNameKYC.Text = dt1.Rows(0)("CastomerNAmeKYC").ToString
            txtEnNameKYC.Text = dt1.Rows(0)("CastomerNameEnKYC").ToString
            txtAddressKYC.Text = dt1.Rows(0)("CastomerADrKYC").ToString
            txtPhoneKYC.Text = dt1.Rows(0)("CastomerTEKYC").ToString
            txtNationalityKYC.Text = dt1.Rows(0)("CastomerNAKYC").ToString
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            pbCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("foto")), Nothing, ByteToImage(dt1.Rows(0)("foto")))
            pbSignature.Image = If(IsDBNull(dt1.Rows(0)("Signature")), Nothing, ByteToImage(dt1.Rows(0)("Signature")))
            pbBackCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("fotoBack")), Nothing, ByteToImage(dt1.Rows(0)("fotoBack")))
            CustomerPhoto = pbCIDPhoto.Image
            CustomerPhotoBack = pbBackCIDPhoto.Image
            showingFront = True

            chkCIDPhoto.Checked = True
            chkSignature.Checked = True
        Else
            'MsgBox("لا يوجد عميل مسجل بهذا الرقم" & vbCrLf & "No Customer is Registered With That Phone No.")
            'ClearData()
        End If

    End Sub
    Private Sub btnCID_Click(sender As Object, e As EventArgs) Handles btnCID.Click
        paci = New PACMAN
        If CivilIDactivat = "1" Then
        ElseIf CivilIDactivat = "0" Then
            MsgBox(MsgBox("لم يتم تفعيل قارئ البطاقة المدنية" & vbCrLf & "Card Reader is not Activated", , "خطأ"))
            Exit Sub
        End If
        act_sta = "1"
        If act_sta = "1" Then
            lblPCID.ForeColor = Color.Black
            lblPNameAr.ForeColor = Color.Black
            lblPNameEn.ForeColor = Color.Black
            lblPPassport.ForeColor = Color.Black
            lblPNationalityAr.ForeColor = Color.Black
            pnlBackCIDKWT.ForeColor = Color.Black
            pnlCID.ForeColor = Color.Black
            txtCID.ForeColor = Color.Black
            'KYC
            Dim dt1 As DataTable = GetRecordSet("SELECT [SET_INVARCHR143] FROM [Settings]")
            If dt1.Rows.Count > 0 Then
                If dt1.Rows(0)(0).ToString <> "1" Then
                    MsgBox("لم يتم تفعيل قارئ البطاقة المدنية" & vbCrLf & "Card Reader is not Activated", , "خطأ")
                    Exit Sub
                End If
            End If
            Try
                If cardConnected Then
                    txtCID.Text = paci.Civil_ID(0).Trim
                    txtName.Text = paci.Arabic_Name_1(0).Trim & " " & paci.Arabic_Name_2(0).Trim & " " & paci.Arabic_Name_3(0).Trim & " " & paci.Arabic_Name_4(0).Trim
                    txtNameEn.Text = paci.English_Name_1(0).Trim & " " & paci.English_Name_2(0).Trim & " " & paci.English_Name_3(0).Trim & " " & paci.English_Name_4(0).Trim
                    txtAddress.Text = paci.District(0).Trim & ",مبنى" & paci.Building_Plot_Number(0).Trim & "," & paci.Street_Name(0).Trim
                    txtPhone.Text = paci.Telephone_1(0).Trim
                    txtNationality.Text = paci.Nationality_Arabic(0).Trim '& " ,  الوظيفة/ " & paci.Additional_F_1(0).Trim
                    'txtNationality.Text = "الجنسية" & "  " & paci.Nationality_Arabic(0).Trim & " " & Replace(paci.Additional_F_1(0).Trim, "  ", "")
                    lblPCID.Text = paci.Civil_ID(0).Trim
                    lblPNameAr.Text = paci.Arabic_Name_Full(0).Trim
                    lblPNameEn.Text = paci.English_Name_Full(0).Trim
                    lblPSexAr.Text = paci.Sex_Arabic(0).Trim
                    lblPSexEn.Text = paci.Sex_English(0).Trim
                    lblPNationalityAr.Text = paci.Nationality_Arabic(0).Trim
                    lblPNationalityEn.Text = paci.Nationality_English(0).Trim
                    lblPBirthDate.Text = paci.Birthdate(0).Trim
                    lblPExpiryDate.Text = paci.Card_Expiry_Date(0).Trim
                    lblPPassport.Text = paci.Passport(0).Trim
                    'KYC
                    txtCIDKYC.Text = paci.Civil_ID(0).Trim
                    txtNameKYC.Text = paci.Arabic_Name_1(0).Trim & " " & paci.Arabic_Name_2(0).Trim & " " & paci.Arabic_Name_3(0).Trim & " " & paci.Arabic_Name_4(0).Trim
                    txtEnNameKYC.Text = paci.English_Name_1(0).Trim & " " & paci.English_Name_2(0).Trim & " " & paci.English_Name_3(0).Trim & " " & paci.English_Name_4(0).Trim
                    txtAddressKYC.Text = paci.District(0).Trim & ",مبنى" & paci.Building_Plot_Number(0).Trim & "," & paci.Street_Name(0).Trim
                    txtPhoneKYC.Text = paci.Telephone_1(0).Trim
                    txtNationalityKYC.Text = paci.Nationality_Arabic(0).Trim '& " ,  الوظيفة/ " & paci.Additional_F_1(0).Trim
                    'txtNationality.Text = "الجنسية" & "  " & paci.Nationality_Arabic(0).Trim & " " & Replace(paci.Additional_F_1(0).Trim, "  ", "")
                    'Back Side Of CID
                    If lblPNationalityEn.Text.ToUpper = "KWT" Then
                        lblBackCIDKWT.Text = paci.Civil_ID(0).Trim
                        lblBackBloodTypeKWT.Text = paci.Blood_Type(0).Trim
                        lblBackDistrictKWT.Text = paci.District(0).Trim
                        lblBackBlockNoKWT.Text = paci.Block_Number(0).Trim
                        lblBackStreetNameKWT.Text = paci.Street_Name(0).Trim
                        lblBackBuildingPlotNoKWT.Text = paci.Building_Plot_Number(0).Trim
                        lblBackUnitTypeKWT.Text = paci.Unit_Type(0).Trim
                        lblBackUnitNoKWT.Text = paci.Unit_Number(0).Trim
                        lblBackFloorNoKWT.Text = paci.Floor_Number(0).Trim
                        lblBackAddressUniqueKeyKWT.Text = paci.Address_Unique_Key(0).Trim
                        lblPhoneNoKWT.Text = paci.Telephone_1(0).Trim
                        lblBackCardSerialNoKWT.Text = paci.Card_Serial_Number(0).Trim
                        Dim StringSerial1 As String = "IDKWT" & paci.Document_Number(0).Trim & "0" & paci.Civil_ID(0).Trim & "<<<"
                        Dim StringSerial2 As String = Mid(paci.Civil_ID(0).Trim, 2, 7) & paci.Sex_English(0).Trim & Mid(paci.Card_Expiry_Date(0).Trim, 3, 6) & "0" & paci.Nationality_English(0).Trim & paci.Address_Unique_Key(0).Trim & "<<<0"
                        Dim StringSerial3 As String = paci.English_Name_4(0).Trim.Replace(" "c, "<"c) & "<<" & paci.English_Name_1(0).Trim.Replace(" "c, "<"c) & StrDup(30 - (paci.English_Name_4(0).Length + paci.English_Name_1(0).Length + 2), "<")
                        Dim narrow_nbr_space As Char = ChrW(&H202F)
                        lblBackLONGSerial1KWT.Text = AddSpaceBetweenString(StringSerial1, 1, narrow_nbr_space)
                        lblBackLONGSerial2KWT.Text = AddSpaceBetweenString(StringSerial2, 1, narrow_nbr_space)
                        lblBackLONGSerial3KWT.Text = AddSpaceBetweenString(StringSerial3, 1, narrow_nbr_space)
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        'اللون علي نصوص البطاقه
                        lblBackCIDKWT.ForeColor = Color.Black
                        lblBackBloodTypeKWT.ForeColor = Color.Black
                        lblBackDistrictKWT.ForeColor = Color.Black
                        lblBackBlockNoKWT.ForeColor = Color.Black
                        lblBackStreetNameKWT.ForeColor = Color.Black
                        lblBackBuildingPlotNoKWT.ForeColor = Color.Black
                        lblBackUnitTypeKWT.ForeColor = Color.Black
                        lblBackUnitNoKWT.ForeColor = Color.Black
                        lblBackFloorNoKWT.ForeColor = Color.Black
                        lblBackAddressUniqueKeyKWT.ForeColor = Color.Black
                        lblPhoneNoKWT.ForeColor = Color.Black
                        lblBackCardSerialNoKWT.ForeColor = Color.Black
                        lblBackLONGSerial1KWT.ForeColor = Color.Black
                        lblBackLONGSerial2KWT.ForeColor = Color.Black
                        lblBackLONGSerial3KWT.ForeColor = Color.Black
                    Else
                        lblBackCID.Text = paci.Civil_ID(0).Trim
                        lblBackBloodType.Text = paci.Blood_Type(0).Trim
                        lblBackProfession.Text = Strings.Left(paci.Additional_F_1(0).Trim, paci.Additional_F_1(0).Length - 6).Trim
                        lblBackProfessionNo.Text = Strings.Right(paci.Additional_F_1(0).Trim, 6)
                        lblBackKafeel.Text = paci.Additional_F_2(0).Trim
                        lblBackDistrict.Text = paci.District(0).Trim
                        lblBackBlockNo.Text = paci.Block_Number(0).Trim
                        lblBackStreetName.Text = paci.Street_Name(0).Trim
                        lblBackBuildingPlotNo.Text = paci.Building_Plot_Number(0).Trim
                        lblBackUnitType.Text = paci.Unit_Type(0).Trim
                        lblBackUnitNo.Text = paci.Unit_Number(0).Trim
                        lblBackFloorNo.Text = paci.Floor_Number(0).Trim
                        lblBackAddressUniqueKey.Text = paci.Address_Unique_Key(0).Trim
                        lblBackCardSerialNo.Text = paci.Card_Serial_Number(0).Trim
                        Dim StringSerial1 As String = "IDKWT" & paci.Document_Number(0).Trim & "0" & paci.Civil_ID(0).Trim & "<<<"
                        Dim StringSerial2 As String = Mid(paci.Civil_ID(0).Trim, 2, 7) & paci.Sex_English(0).Trim & Mid(paci.Card_Expiry_Date(0).Trim, 3, 6) & "0" & paci.Nationality_English(0).Trim & paci.Address_Unique_Key(0).Trim & "<<<0"
                        Dim StringSerial3 As String = paci.English_Name_4(0).Trim.Replace(" "c, "<"c) & "<<" & paci.English_Name_1(0).Trim.Replace(" "c, "<"c) & StrDup(30 - (paci.English_Name_4(0).Length + paci.English_Name_1(0).Length + 2), "<")
                        Dim narrow_nbr_space As Char = ChrW(&H202F)
                        lblBackLONGSerial1.Text = AddSpaceBetweenString(StringSerial1, 1, narrow_nbr_space)
                        lblBackLONGSerial2.Text = AddSpaceBetweenString(StringSerial2, 1, narrow_nbr_space)
                        lblBackLONGSerial3.Text = AddSpaceBetweenString(StringSerial3, 1, narrow_nbr_space)
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        'اللون علي نصوص البطاقه
                        lblBackCID.ForeColor = Color.Black
                        lblBackBloodType.ForeColor = Color.Black
                        lblBackProfession.ForeColor = Color.Black
                        lblBackProfessionNo.ForeColor = Color.Black
                        lblBackKafeel.ForeColor = Color.Black
                        lblBackDistrict.ForeColor = Color.Black
                        lblBackBlockNo.ForeColor = Color.Black
                        lblBackStreetName.ForeColor = Color.Black
                        lblBackBuildingPlotNo.ForeColor = Color.Black
                        lblBackUnitType.ForeColor = Color.Black
                        lblBackUnitNo.ForeColor = Color.Black
                        lblBackFloorNo.ForeColor = Color.Black
                        lblBackAddressUniqueKey.ForeColor = Color.Black
                        lblBackCardSerialNo.ForeColor = Color.Black
                        lblBackLONGSerial1.ForeColor = Color.Black
                        lblBackLONGSerial2.ForeColor = Color.Black
                        lblBackLONGSerial3.ForeColor = Color.Black
                    End If
                    GetLastInvoceData()
                    Dim bart1 As String
                    Dim bart2 As String
                    Dim bart3 As String
                    Dim s As String = paci.Birthdate(0)
                    bart1 = Mid(s, 5, 2)
                    bart2 = Mid(s, 7, 2)
                    bart3 = Mid(s, 1, 4)
                    lblPBirthDate.Text = bart2 & "/" & bart1 & "/" & bart3
                    Dim t1 As String
                    Dim t2 As String
                    Dim t3 As String
                    Dim exbir As String = paci.Card_Expiry_Date(0)
                    t1 = Mid(exbir, 5, 2)
                    t2 = Mid(exbir, 7, 2)
                    t3 = Mid(exbir, 1, 4)
                    lblPExpiryDate.Text = t2 & "/" & t1 & "/" & t3
                    Dim photo As String = paci.Photo(0)
                    Dim photoBytes() As Byte = PACMAN.ConvertToByteArray(photo)
                    CSJ2K.Util.BitmapImageCreator.Register()
                    Dim decodedImage = CSJ2K.J2kImage.FromBytes(photoBytes)
                    Dim bitmap = decodedImage.As(Of Bitmap)()
                    pbPhoto.Image = bitmap
                    pbPhoto.Visible = True

                    If lblPNationalityEn.Text.ToUpper = "KWT" Then
                        pnlCID.BackgroundImage = My.Resources.kw
                    Else
                        pnlCID.BackgroundImage = My.Resources.eg
                    End If
                    Dim img As New Bitmap(pnlCID.Width, pnlCID.Height)
                    pnlCID.DrawToBitmap(img, New Rectangle(Point.Empty, pnlCID.Size))
                    pbCIDPhoto.Image = img


                    If lblPNationalityEn.Text.ToUpper = "KWT" Then
                        Dim imgBackKWT As New Bitmap(pnlBackCIDKWT.Width, pnlBackCIDKWT.Height)
                        pnlBackCIDKWT.DrawToBitmap(imgBackKWT, New Rectangle(Point.Empty, pnlBackCIDKWT.Size))
                        pbBackCIDPhoto.Image = imgBackKWT
                    Else
                        Dim imgBack As New Bitmap(pnlBackCID.Width, pnlBackCID.Height)
                        pnlBackCID.DrawToBitmap(imgBack, New Rectangle(Point.Empty, pnlBackCID.Size))
                        pbBackCIDPhoto.Image = imgBack
                    End If

                    ''zizo
                    CustomerPhoto = pbCIDPhoto.Image
                    CustomerPhotoBack = pbBackCIDPhoto.Image
                Else
                    Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
                End If
            Catch ex As Exception
                Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
                MsgBox(ex.Message)
            End Try
        ElseIf act_sta = "0" Then
            Exclamation("قارئ البطاقة غير متصل أو البطاقة المدنية غير مدخلة بشكل صحيح" & vbCrLf & "Card Reader Not Connected or Civil ID Not Inserted Properly..")
        End If
    End Sub
    Private Sub btnSignature_Click(sender As Object, e As EventArgs) Handles btnSignature.Click
        If txtCID.Text.Trim = "" OrElse IsNumeric(txtCID.Text.Trim) = False Then
            MsgBox("أدخل الرقم المدني بشكل صحيح أولا" & vbCrLf & "Please Enter a valid Civil ID First.", , AppTitle)
            txtCID.SelectAll()
            txtCID.Focus()
            Exit Sub
        End If
        TestSigCapt.TestSigCapt.ShowDialog(Me)
        If IsNothing(SignatureImage) = False Then
            pbSignature.Image = SignatureImage
        End If
        TestSigCapt.TestSigCapt.Dispose()

    End Sub

    Private Sub pbSignature_DoubleClick(sender As Object, e As EventArgs) Handles pbSignature.DoubleClick
        If pbSignature.Image Is Nothing Then
            pbSignature.Image = Nothing
        Else
            If MsgBox("هل تريد حذف صورة العميل؟", vbYesNo) = MsgBoxResult.Yes Then
                pbSignature.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btnScanner_Click(sender As Object, e As EventArgs) Handles btnScanner.Click
        If txtCID.Text.Trim = "" OrElse IsNumeric(txtCID.Text.Trim) = False Then
            MsgBox("أدخل الرقم المدني بشكل صحيح أولا" & vbCrLf & "Please Enter a valid Civil ID First.", , AppTitle)
            txtCID.SelectAll()
            txtCID.Focus()
            Exit Sub
        End If

        Dim filePath As String = Application.StartupPath & "\MyImage.JPG"

        Try
            '   If pbCIDPhoto.Image IsNot Nothing Then pbCIDPhoto.Image.Dispose()
            pbCIDPhoto.Image = Nothing
            If My.Computer.FileSystem.FileExists(filePath) Then
                My.Computer.FileSystem.DeleteFile(filePath)
            End If
        Catch ex As Exception
        End Try

        '   Process.Start(Application.StartupPath & "\Scanner.exe").WaitForExit()
        Dim p As Process = Process.Start(Application.StartupPath & "\Scanner.exe")
        p.WaitForExit()
        If My.Computer.FileSystem.FileExists(filePath) Then
            Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(filePath)
            Using ms As New MemoryStream(bytes)
                Dim tempImg As Image = Image.FromStream(ms)

                If showingFront Then
                    pbCIDPhoto.Image = Nothing           ' ← افصل الـ PictureBox أولاً
                    If CustomerPhoto IsNot Nothing Then CustomerPhoto.Dispose()
                    CustomerPhoto = New Bitmap(tempImg)
                    pbCIDPhoto.Image = CustomerPhoto
                Else
                    pbCIDPhoto.Image = Nothing           ' ← افصل الـ PictureBox أولاً
                    If CustomerPhotoBack IsNot Nothing Then CustomerPhotoBack.Dispose()
                    CustomerPhotoBack = New Bitmap(tempImg)
                    pbCIDPhoto.Image = CustomerPhotoBack
                End If
            End Using

            MsgBox(If(showingFront, "تم سحب صورة الوش بنجاح", "تم سحب صورة الضهر بنجاح"))
        End If
        'If My.Computer.FileSystem.FileExists(Application.StartupPath & "\MyImage.JPG") = True Then
        '    pbCIDPhoto.Image = Image.FromFile(Application.StartupPath & "\MyImage.JPG")
        'End If
    End Sub

    Private Sub chkCIDPhoto_CheckedChanged(sender As Object, e As EventArgs) Handles chkCIDPhoto.CheckedChanged
        'If chkCIDPhoto.Checked = True Then
        '    pbCIDPhoto.Image = CustomerPhoto
        '    pbBackCIDPhoto.Image = CustomerPhotoBack
        'Else
        '    CustomerPhoto = pbCIDPhoto.Image
        '    CustomerPhotoBack = pbBackCIDPhoto.Image
        '    pbCIDPhoto.Image = Nothing
        '    pbBackCIDPhoto.Image = Nothing
        'End If

        If chkCIDPhoto.Checked = True Then
            ' ارجع للصورة الصح حسب وضع الفليب الحالي
            pbCIDPhoto.Image = If(showingFront, CustomerPhoto, CustomerPhotoBack)
            pbBackCIDPhoto.Image = CustomerPhotoBack
        Else
            ' احفظ في المتغيرات قبل الإخفاء
            If showingFront Then
                CustomerPhoto = pbCIDPhoto.Image
            Else
                CustomerPhotoBack = pbCIDPhoto.Image
            End If
            'CustomerPhotoBack = pbBackCIDPhoto.Image
            pbCIDPhoto.Image = Nothing
            pbBackCIDPhoto.Image = Nothing
        End If

    End Sub

    Private Sub chkSignature_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignature.CheckedChanged
        If chkSignature.Checked = True Then
            pbSignature.Image = CustomerSignature
            pbSignature.BackColor = Color.White
        Else
            CustomerSignature = pbSignature.Image
            pbSignature.Image = Nothing
            pbSignature.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub txtCID_TextChanged(sender As Object, e As EventArgs) Handles txtCID.TextChanged

        If txtCID.Text.Trim = "" Then
            txtName.Text = ""
            txtAddress.Text = ""
            txtPhone.Text = ""
            txtNationality.Text = ""
            pbCIDPhoto.Image = Nothing
            pbSignature.Image = Nothing
            Exit Sub
        End If

        If Len(txtCID.Text.Trim) = 12 Then
            txtCID.ForeColor = Color.Black
        Else
            txtCID.ForeColor = Color.DarkRed
        End If

        If IsNumeric(txtCID.Text.Trim) = False Then
            Exit Sub
        End If

        GetCustomerData()
    End Sub
    Private Sub CIDLanguage()
        If frmLogin.rbtnEn.Checked = True Then
            btnView.Text = "Query"
            btnCID.Text = "Read CID"
            btnSignature.Text = "E." & vbCrLf & "Sign."
            btnScanner.Text = "Scanner"
            btnSaveCID.Text = "Save"
            btnMobID.Text = "ID Authenticate"
            chkCIDPhoto.Text = "Show Photo"
            chkSignature.Text = "Show Sign."
            gbCustomerData.Text = "Customer Data"
            btnPhoto.Text = "Upload Photo"
            btnPhone.Text = "Search by Phone"
            LinkDate.Text = "Date"
            LinkInvNo.Text = "Invoice Number"
            LinkTotalAmount.Text = "Total Amount"
            LinkCh.Text = "Cash"
            LinkKenet.Text = "Kenet"

        Else
            btnView.Text = "استعلام"
            btnCID.Text = "عرض المدنية"
            btnSignature.Text = "توقيع العميل"
            btnScanner.Text = "الماسح الضوئي"
            btnSaveCID.Text = "حفظ"
            btnMobID.Text = "مصادقة هويتي"
            chkCIDPhoto.Text = "عرض الصورة"
            chkSignature.Text = "عرض التوقيع"
            gbCustomerData.Text = "بيانات العميل"
            btnPhoto.Text = "رفع صورة"
            btnPhone.Text = "بحث برقم الهاتف"
            LinkDate.Text = "تاريخ"
            LinkInvNo.Text = "ر.الفاتوره"
            LinkTotalAmount.Text = "اجمالي السعر"
            LinkCh.Text = "نقدا"
            LinkKenet.Text = "بنكي"
        End If
    End Sub
    Private Sub ClearData()
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtNationality.Text = ""
        pbCIDPhoto.Image = Nothing
        pbSignature.Image = Nothing
    End Sub

    Private Sub txtCID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        'ValidateTextbox(sender, 2, e)
    End Sub

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click, btnPhoto.LinkClicked
        Try
            Dim OFD As New OpenFileDialog
            With OFD
                OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
                If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If OFD.FileName.Trim <> "" Then
                        pbCIDPhoto.Image = Image.FromFile(.FileName)
                    Else
                        MsgBox("يرجى تحديد صورة" & vbCrLf & "Please Select an Image", , AppTitle)
                        Exit Sub
                    End If
                Else
                    Return
                End If
            End With
            pbCIDPhoto.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            MsgBox("الملف المحدد غير صالح" & vbCrLf & "Selected File is Not Valid", , AppTitle)
        End Try
    End Sub

    ' ziad salah
    Dim showingFront As Boolean = True


    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click


        showingFront = Not showingFront

        If showingFront Then
            pbCIDPhoto.Image = CustomerPhoto
            btnFlip.Text = "عرض الضهر"
            btnScanner.Text = "سكان الوش"
        Else
            ' لو الـ CustomerPhotoBack فاضية، الـ PictureBox هيفضى عادي بدون Exception
            pbCIDPhoto.Image = CustomerPhotoBack
            btnFlip.Text = "عرض الوش"
            btnScanner.Text = "سكان الضهر"
        End If

        ''
        '        showingFront = Not showingFront

        '        If showingFront Then
        '            pbCIDPhoto.Image = CustomerPhoto
        '            btnFlip.Text = "عرض الضهر"
        '            btnScanner.Text = "سكان الوش"
        '        Else
        '            pbCIDPhoto.Image = CustomerPhotoBack
        '            btnFlip.Text = "عرض الوش"
        '            btnScanner.Text = "سكان الضهر"
        '        End If
        '


        'pbCIDPhoto.Visible = Not pbCIDPhoto.Visible
        'pbBackCIDPhoto.Visible = Not pbBackCIDPhoto.Visible
    End Sub

    Private Sub lblPhone_Click(sender As Object, e As EventArgs)
        If txtPhone.Text.Trim = "" Then Exit Sub
        If MsgBox("هل تريد البحث عن العميل برقم الهاتف المدخل؟" & vbCrLf & "Do you want to Search Customer By the Entered Phone?", vbYesNo) = vbYes Then
            GetCustomerDataFromPhone(txtPhone.Text.Trim)
        End If

    End Sub
    Public Sub GetCustomerDataFromPhone(PhoneNo As String)
        StrSQL = "SELECT * FROM CastomerDETELS WHERE CastomerTE = '" & txtPhone.Text.Trim & "'"
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        If dt1.Rows.Count > 0 Then
            txtCID.Text = dt1.Rows(0)("CastomerCAIVELid").ToString
            txtName.Text = dt1.Rows(0)("CastomerNAme").ToString
            txtAddress.Text = dt1.Rows(0)("CastomerADr").ToString
            txtNationality.Text = dt1.Rows(0)("CastomerNA").ToString
            pbCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("foto")), Nothing, ByteToImage(dt1.Rows(0)("foto")))
            pbSignature.Image = If(IsDBNull(dt1.Rows(0)("Signature")), Nothing, ByteToImage(dt1.Rows(0)("Signature")))
            pbBackCIDPhoto.Image = If(IsDBNull(dt1.Rows(0)("fotoBack")), Nothing, ByteToImage(dt1.Rows(0)("fotoBack")))

            'zizo
            CustomerPhoto = pbCIDPhoto.Image
            CustomerPhotoBack = pbBackCIDPhoto.Image
            showingFront = True

            chkCIDPhoto.Checked = True
            chkSignature.Checked = True
            'KYC''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            txtNameKYC.Text = dt1.Rows(0)("CastomerNAmeKYC").ToString
            txtEnNameKYC.Text = dt1.Rows(0)("CastomerNameEnKYC").ToString
            txtAddressKYC.Text = dt1.Rows(0)("CastomerADrKYC").ToString
            txtPhoneKYC.Text = dt1.Rows(0)("CastomerTEKYC").ToString
            txtNationalityKYC.Text = dt1.Rows(0)("CastomerNAKYC").ToString
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Else
            MsgBox("لا يوجد عميل مسجل بهذا الرقم" & vbCrLf & "No Customer is Registered With That Phone No.")
        End If

    End Sub

    Private Sub btnPhone_Click(sender As Object, e As EventArgs) Handles btnPhone.Click
        If txtPhone.Text.Trim = "" Then
            txtName.Text = ""
            txtAddress.Text = ""
            'txtCID.Text = ""
            txtNationality.Text = ""
            pbCIDPhoto.Image = Nothing
            pbSignature.Image = Nothing
            Exit Sub
        End If

        If IsNumeric(txtPhone.Text.Trim) = False Then
            Exit Sub
        End If
        GetCustomerDataBayCastomerTE()
        GetLastInvoceData()

    End Sub

    Private Sub lblNationalityAr_DoubleClick(sender As Object, e As EventArgs)
        txtNationality.Text = "كويتي"
        txtAddress.Text = "الكويت"
        txtPhone.Text = "0"
    End Sub

    Private Sub btnArEn_Click(sender As Object, e As EventArgs) Handles btnArEn.Click
        txtName.Visible = Not txtName.Visible
        txtNameEn.Visible = Not txtNameEn.Visible
        If btnArEn.Text = "English" Then
            btnArEn.Text = "عربي"
        Else
            btnArEn.Text = "English"
        End If
    End Sub

    Private Sub gbCustomerData_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbCustomerData.Enter

    End Sub

    Private Sub txtPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPhone.Text.Trim = "" Then
                txtName.Text = ""
                txtAddress.Text = ""
                'txtCID.Text = ""
                txtNationality.Text = ""
                pbCIDPhoto.Image = Nothing
                pbSignature.Image = Nothing
                Exit Sub
            End If
            If IsNumeric(txtPhone.Text.Trim) = False Then
                Exit Sub
            End If
            GetCustomerDataBayCastomerTE()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Ctrl_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyUp, txtCID.KeyUp, txtNationality.KeyUp, txtAddress.KeyUp, txtPhone.KeyUp
        If e.KeyCode = Keys.Enter = True Then
            Me.SelectNextControl(sender, True, True, True, True)
            'btnSaveCID_Click(sender, e)
        End If
    End Sub




    Private Sub btnMobID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMobID.Click
        If DigitalCivilIDactivation = 0 Then
            ShowIdentityWarning()
        ElseIf DigitalCivilIDactivation = 1 Then
            PostCivilID(txtCID.Text.Trim)
            AuthenticationCivilId.lblText.Text = "تم ارسال طلب مصادقه عبر تطبيق هويتي الخاص باالهيئه العامه للمعلومات المدنيه للرقم المدني " & vbCrLf &
                                                 "  " & txtCID.Text.Trim & " " & vbCrLf &
                                               "برجاء القيام بتصديق الطلب عبر تطبيق هويتي ثم اضغط علي تمت المصادقه"
            AuthenticationCivilId.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GetCivilID(GetCivilID(CivilIDForm.txtCID.Text.Trim))
    End Sub
    Public Sub GetLastInvoceData()

        If GoldInvoice.Visible = True Then
            Dim ShortData As DataTable = GetRecordSet("SELECT  MAX(BAY_SARYAL) AS BAY_SARYAL, KENT + Bank1 + Bank2 + Bank3 + Bank4 AS" & vbCrLf &
                                                     "Kenet, CACH, TOTAL_mony, invoc_date_time" & vbCrLf &
                                                     "FROM dbo.ViwGoldInvoceReport" & vbCrLf &
                                                     "WHERE(Castomerid = '" & txtCID.Text.Trim & "')GROUP BY " & vbCrLf &
                                                     "KENT + Bank1 + Bank2 + Bank3 + Bank4, CACH, invoc_date_time, TOTAL_mony" & vbCrLf &
                                                     "ORDER BY BAY_SARYAL DESC")
            If ShortData.Rows.Count > 0 Then
                lblDate.Text = (ShortData.Rows(0)("invoc_date_time").ToString)
                lblInvNo.Text = (ShortData.Rows(0)("BAY_SARYAL").ToString)
                lblTotalAmount.Text = (ShortData.Rows(0)("TOTAL_mony").ToString)
                lblCh.Text = (ShortData.Rows(0)("CACH").ToString)
                lblKenet.Text = (ShortData.Rows(0)("Kenet").ToString)
            End If
        ElseIf DiamondInvoice.Visible = True Then
            Dim ShortData As DataTable = GetRecordSet("SELECT BAY_SARYAL, KENT, dimon_bay_cach, TOTAL_mony, date_creted" & vbCrLf &
                                                      "FROM dbo.ReportDiamondSellDetailed" & vbCrLf &
                                                      "WHERE  (castomr_id = '" & txtCID.Text.Trim & "')" & vbCrLf &
                                                      "GROUP BY BAY_SARYAL, KENT, dimon_bay_cach, TOTAL_mony, date_creted" & vbCrLf &
                                                      "ORDER BY BAY_SARYAL DESC")
            If ShortData.Rows.Count > 0 Then
                lblDate.Text = (ShortData.Rows(0)("date_creted").ToString)
                lblInvNo.Text = (ShortData.Rows(0)("BAY_SARYAL").ToString)
                lblTotalAmount.Text = (ShortData.Rows(0)("TOTAL_mony").ToString)
                lblCh.Text = (ShortData.Rows(0)("dimon_bay_cach").ToString)
                lblKenet.Text = (ShortData.Rows(0)("KENT").ToString)
            End If
        ElseIf SilverInvoice.Visible = True Then
            Dim ShortData As DataTable = GetRecordSet("SELECT  MAX(BAY_SARYAL) AS BAY_SARYAL, KENT + Bank1 + Bank2 + Bank3 + Bank4 AS" & vbCrLf &
                                                     "Kenet, CACH, TOTAL_mony, invoc_date_time" & vbCrLf &
                                                     "FROM dbo.ViwSilverInvoceReport" & vbCrLf &
                                                     "WHERE(Castomerid = '" & txtCID.Text.Trim & "')GROUP BY " & vbCrLf &
                                                     "KENT + Bank1 + Bank2 + Bank3 + Bank4, CACH, invoc_date_time, TOTAL_mony" & vbCrLf &
                                                     "ORDER BY BAY_SARYAL DESC")

            If ShortData.Rows.Count > 0 Then
                lblDate.Text = (ShortData.Rows(0)("invoc_date_time").ToString)
                lblInvNo.Text = (ShortData.Rows(0)("BAY_SARYAL").ToString)
                lblTotalAmount.Text = (ShortData.Rows(0)("TOTAL_mony").ToString)
                lblCh.Text = (ShortData.Rows(0)("CACH").ToString)
                lblKenet.Text = (ShortData.Rows(0)("Kenet").ToString)
            End If
        End If
    End Sub
    Private Sub btnAllInvoce_Click(sender As Object, e As EventArgs) Handles btnAllInvoce.Click
        FrmViwCastomerInvData.ShowDialog()
    End Sub

    Private Sub btnInvSh_Click(sender As Object, e As EventArgs) Handles btnInvSh.Click
        If GoldInvoice.Visible = True Then
            If lblInvNo.Text = "" Then
                MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
                lblInvNo.Focus()
                Exit Sub
            End If
            Try
                With GoldViewSellInvoice
                    .txtInvoiceNo.Text = lblInvNo.Text
                    .InvoiceSearch()
                    .ReportViewer1.RefreshReport()
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            End Try
        ElseIf DiamondInvoice.Visible = True Then
            With DiamondViewSellInvoice
                Try
                    If lblInvNo.Text = "" Then
                        MsgBox("ادخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
                        .txtInvoiceNo.SelectAll()
                        .txtInvoiceNo.Focus()
                    Else
                        .txtInvoiceNo.Text = ""
                        .txtInvoiceNo.Text = lblInvNo.Text.Trim
                        .InvoiceSearch()
                        .WeightSum()

                        DiamondViewSellInvoice.ShowDialog()
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message.ToString)
                    'Exit Sub
                End Try
            End With
        ElseIf SilverInvoice.Visible = True Then






        End If
    End Sub

    Private Sub txtCID_TextChanged_1(sender As Object, e As EventArgs) Handles txtCID.TextChanged

    End Sub

    Private Sub txtPhone_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown

    End Sub

    Private Sub Whawiti_Click(sender As Object, e As EventArgs) Handles whawiti.Click
        Try
            ' التحقق من وجود رقم الهاتف
            If String.IsNullOrWhiteSpace(txtPhone.Text) Then
                MessageBox.Show("يرجى إدخال رقم الهاتف" & vbCrLf &
                               "Please enter phone number",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhone.Focus()
                Return
            End If

            ' التحقق من وجود UUID
            If String.IsNullOrWhiteSpace(uuid) Then
                MessageBox.Show("UUID غير موجود" & vbCrLf &
                               "UUID not found",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            If String.IsNullOrWhiteSpace(authKey) OrElse String.IsNullOrWhiteSpace(appKey) Then
                MessageBox.Show("يرجى إدخال Auth Key و App Key" & vbCrLf &
                               "Please enter Auth Key and App Key",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' تعطيل الزر أثناء العملية
            ' whawiti.Enabled = True
            whawiti.ForeColor = Color.Gold
            whawiti.Text = "⏳ جاري الإرسال..."

            ' إرسال الرسالة وجلب الهوية
            GetIDFromWhatsAppAsync("965" & txtPhone.Text.Trim(), uuid, authKey, appKey)

        Catch ex As Exception
            MessageBox.Show("خطأ في جلب الهوية: " & ex.Message & vbCrLf & "Error getting ID: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            whawiti.Enabled = True
            whawiti.Text = "مطالبه هويتي"
        End Try
    End Sub

    Private Async Sub GetIDFromWhatsAppAsync(phone As String, deviceId As String, authKey As String, appKey As String)
        Try

            ' جلب آخر صورتين الحاليتين قبل إرسال الرسالة
            Dim oldMessageIds As New List(Of String)
            Try
                Dim oldImagesResult = Await GetCurrentLastImagesAsync(deviceId, phone)
                If oldImagesResult.Success AndAlso oldImagesResult.MessageIds IsNot Nothing Then
                    oldMessageIds = oldImagesResult.MessageIds
                    Me.Invoke(Sub()
                                  ' يمكن إضافة رسالة هنا إذا لزم الأمر
                              End Sub)
                End If
            Catch ex As Exception
                ' في حالة فشل جلب الصور القديمة، نستمر على أي حال
            End Try

            ' إرسال الرسالة
            Dim sendResult As Boolean = Await SendWhatsAppMessageAsync(phone, requestMessage, authKey, appKey, apiBaseUrl)

            If Not sendResult Then
                Me.Invoke(Sub()
                              MessageBox.Show("فشل في إرسال الرسالة" & vbCrLf & "Failed to send message", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                              whawiti.Enabled = True
                              whawiti.Text = "مطالبه هويتي"
                          End Sub)
                Return
            End If

            ' تحديث حالة الزر
            Me.Invoke(Sub()
                          whawiti.Text = "⏳ في انتظار الصور..."
                      End Sub)

            ' عمل loop لمدة 45 ثانية للتحقق من الصور الجديدة
            Dim maxWaitTime As TimeSpan = TimeSpan.FromSeconds(35)
            Dim checkInterval As TimeSpan = TimeSpan.FromSeconds(1)
            Dim elapsedTime As TimeSpan = TimeSpan.Zero
            Dim imagesFound As Boolean = False

            While elapsedTime < maxWaitTime AndAlso Not imagesFound
                Await Task.Delay(checkInterval)
                elapsedTime = elapsedTime.Add(checkInterval)

                ' محاولة جلب الصور الجديدة (تجاهل الصور القديمة)
                Dim imagesResult = Await LoadLastImagesWithCheckAsync(deviceId, phone, oldMessageIds)

                If imagesResult.Success AndAlso imagesResult.ImagesFound Then
                    imagesFound = True
                    Me.Invoke(Sub()
                                  MessageBox.Show("تم استلام صور الهوية بنجاح!" & vbCrLf & "ID images received successfully!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                  whawiti.Enabled = True

                                  whawiti.Text = "مطالبه هويتي"
                              End Sub)
                    Exit While
                End If

                ' تحديث حالة الانتظار
                Dim remainingSeconds As Integer = CInt((maxWaitTime.TotalSeconds - elapsedTime.TotalSeconds))
                Me.Invoke(Sub()
                              whawiti.Text = "⏳ في انتظار الصور... (" & remainingSeconds & "s)"
                          End Sub)
            End While

            If Not imagesFound Then
                ' محاولة جلب الصور بدون تحديد رقم معين
                Me.Invoke(Sub()
                              whawiti.Text = "⏳ جاري البحث بدون رقم..."
                          End Sub)

                ' محاولة جلب الصور بدون phone parameter
                Dim imagesResultWithoutPhone = Await LoadLastImagesWithCheckAsync(deviceId, Nothing, oldMessageIds)

                If imagesResultWithoutPhone.Success AndAlso imagesResultWithoutPhone.ImagesFound Then
                    Me.Invoke(Sub()
                                  MessageBox.Show("تم استلام صور الهوية بنجاح!" & vbCrLf & "ID images received successfully!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                  whawiti.Enabled = True
                                  whawiti.Text = "مطالبه هويتي"
                              End Sub)
                Else
                    Me.Invoke(Sub()
                                  MessageBox.Show("لم يتم استلام الصور خلال 15 ثانية" & vbCrLf & "Images not received within 15 seconds", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                  whawiti.Enabled = True
                                  whawiti.Text = "مطالبه هويتي"
                              End Sub)
                End If
            End If

        Catch ex As Exception
            Me.Invoke(Sub()
                          MessageBox.Show("خطأ في جلب الهوية: " & ex.Message & vbCrLf & "Error getting ID: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                          whawiti.Enabled = True
                          whawiti.Text = "مطالبه هويتي"
                      End Sub)
        End Try
    End Sub

    ' دالة لجلب آخر صورتين الحاليتين قبل إرسال الرسالة
    Private Async Function GetCurrentLastImagesAsync(deviceId As String, phone As String) As Task(Of (Success As Boolean, MessageIds As List(Of String)))
        Try
            Dim apiUrl As String = "https://wplus.sabpay.net/api/get-last-images"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(10)
                ' إنشاء form data مع device_id و phone
                Dim formData As New List(Of KeyValuePair(Of String, String))()
                formData.Add(New KeyValuePair(Of String, String)("device_id", deviceId))
                formData.Add(New KeyValuePair(Of String, String)("phone", phone))
                Dim formContent As New FormUrlEncodedContent(formData)
                ' إرسال POST request
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, formContent)
                If response.IsSuccessStatusCode Then
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonObj As JObject = JObject.Parse(responseContent)
                    If jsonObj("success") IsNot Nothing AndAlso CBool(jsonObj("success")) Then
                        Dim dataObj As JObject = jsonObj("data")
                        Dim imagesArray As JArray = dataObj("images")
                        Dim messageIds As New List(Of String)
                        If imagesArray IsNot Nothing AndAlso imagesArray.Count >= 2 Then
                            ' حفظ message_id للصور القديمة
                            messageIds.Add(imagesArray(0)("message_id").ToString())
                            messageIds.Add(imagesArray(1)("message_id").ToString())
                        End If
                        Return (True, messageIds)
                    End If
                End If
            End Using

            Return (False, Nothing)
        Catch ex As Exception
            Return (False, Nothing)
        End Try
    End Function

    Private Async Function LoadLastImagesWithCheckAsync(deviceId As String, phone As String, oldMessageIds As List(Of String)) As Task(Of (Success As Boolean, ImagesFound As Boolean))
        Try
            Dim apiUrl As String = "https://wplus.sabpay.net/api/get-last-images"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(10)

                ' إنشاء form data مع device_id و phone (إذا كان موجوداً)
                Dim formData As New List(Of KeyValuePair(Of String, String))()
                formData.Add(New KeyValuePair(Of String, String)("device_id", deviceId))
                If Not String.IsNullOrWhiteSpace(phone) Then
                    formData.Add(New KeyValuePair(Of String, String)("phone", phone))
                End If
                Dim formContent As New FormUrlEncodedContent(formData)

                ' إرسال POST request
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, formContent)

                If response.IsSuccessStatusCode Then
                    ' قراءة JSON response
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                    ' تحليل JSON
                    Dim jsonObj As JObject = JObject.Parse(responseContent)

                    If jsonObj("success") IsNot Nothing AndAlso CBool(jsonObj("success")) Then
                        Dim dataObj As JObject = jsonObj("data")
                        Dim imagesArray As JArray = dataObj("images")

                        If imagesArray IsNot Nothing AndAlso imagesArray.Count >= 2 Then
                            ' التحقق من message_id - يجب أن تكون مختلفة عن الصور القديمة
                            Dim image1MessageId As String = imagesArray(0)("message_id").ToString()
                            Dim image2MessageId As String = imagesArray(1)("message_id").ToString()

                            ' التحقق من أن الصور جديدة (message_id مختلف عن القديمة)
                            Dim areNewImages As Boolean = True

                            If oldMessageIds IsNot Nothing AndAlso oldMessageIds.Count > 0 Then
                                ' إذا كانت message_id مطابقة للصور القديمة، فهي ليست جديدة
                                If oldMessageIds.Contains(image1MessageId) OrElse oldMessageIds.Contains(image2MessageId) Then
                                    areNewImages = False
                                End If
                            End If

                            ' إذا تم تحديد phone، التحقق من أن الصور من نفس الرقم
                            If Not String.IsNullOrWhiteSpace(phone) Then
                                Dim image1FromPhone As String = imagesArray(0)("from_phone").ToString()
                                Dim image2FromPhone As String = imagesArray(1)("from_phone").ToString()

                                ' التحقق من أن الصور من نفس الرقم
                                If image1FromPhone <> phone OrElse image2FromPhone <> phone Then
                                    ' الصور ليست من نفس الرقم
                                    Return (True, False)
                                End If
                            End If

                            If areNewImages Then
                                ' الصور جديدة - عرضها في PictureBoxes
                                Dim image1Url As String = imagesArray(0)("image_url").ToString()
                                Dim image2Url As String = imagesArray(1)("image_url").ToString()

                                ' تحميل وعرض الصورة الأولى في pbCIDPhoto
                                Await LoadImageFromUrlAsync(image2Url, pbCIDPhoto)

                                ' تحميل وعرض الصورة الثانية في pbBackCIDPhoto
                                Await LoadImageFromUrlAsync(image1Url, pbBackCIDPhoto)

                                CustomerPhoto = pbCIDPhoto.Image
                                CustomerPhotoBack = pbBackCIDPhoto.Image
                                showingFront = True

                                Return (True, True)
                            Else
                                ' الصور قديمة (نفس message_id)
                                Return (True, False)
                            End If
                        Else
                            Return (True, False)
                        End If
                    Else
                        Return (False, False)
                    End If
                Else
                    Return (False, False)
                End If
            End Using

        Catch ex As Exception
            Return (False, False)
        End Try
    End Function

    Private Sub pnlData_Paint(sender As Object, e As PaintEventArgs) Handles pnlData.Paint

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtCIDKYC_TextChanged(sender As Object, e As EventArgs) Handles txtCIDKYC.TextChanged

    End Sub

    Private Sub txtCIDKYC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCIDKYC.MouseClick
        txtCIDKYC.SelectAll()
        txtCIDKYC.Focus()
    End Sub

    Private Sub txtNameKYC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNameKYC.MouseClick
        txtNameKYC.SelectAll()
        txtNameKYC.Focus()
    End Sub

    Private Sub txtNationalityKYC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtNationalityKYC.MouseClick
        txtNationalityKYC.SelectAll()
        txtNationalityKYC.Focus()
    End Sub

    Private Sub txtAddressKYC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAddressKYC.MouseClick
        txtAddressKYC.SelectAll()
        txtAddressKYC.Focus()
    End Sub

    Private Sub txtPhoneKYC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPhoneKYC.MouseClick
        txtPhoneKYC.SelectAll()
        txtPhoneKYC.Focus()
    End Sub

    ' دالة إرسال رسالة WhatsApp (Async)
    Private Async Function SendWhatsAppMessageAsync(phone As String, message As String, authKey As String, appKey As String, apiBaseUrl As String) As Task(Of Boolean)
        Try
            Dim url As String = apiBaseUrl & "/api/create-message"
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(30)
                ' إنشاء form data
                Dim formData As New MultipartFormDataContent()
                formData.Add(New StringContent(appKey), "appkey")
                formData.Add(New StringContent(authKey), "authkey")
                formData.Add(New StringContent(phone), "to")
                formData.Add(New StringContent(message), "message")
                ' إرسال الطلب
                Dim response As HttpResponseMessage = Await client.PostAsync(url, formData)
                If response.IsSuccessStatusCode Then
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Return True
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    Return False
                End If
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Async Function LoadImageFromUrlAsync(imageUrl As String, pictureBox As PictureBox) As Task
        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(30)
                Dim imageBytes As Byte() = Await client.GetByteArrayAsync(imageUrl)

                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Using ms As New MemoryStream(imageBytes)
                        Dim img As Image = Image.FromStream(ms)
                        Me.Invoke(Sub()
                                      pictureBox.Image = img
                                      pictureBox.BackColor = Color.White
                                  End Sub)
                    End Using
                End If
            End Using
        Catch ex As Exception
            Me.Invoke(Sub()
                          pictureBox.Image = Nothing
                          pictureBox.BackColor = Color.White

                          'zizo

                      End Sub)
        End Try
    End Function


    ' حط الدالة دي في آخر الكلاس قبل سطر End Class
    Private Function GetImageBytes(img As System.Drawing.Image) As Object
        If img Is Nothing Then
            Return System.DBNull.Value
        End If

        Try
            Using ms As New System.IO.MemoryStream()
                ' استخدام المسار الكامل لتجنب الأخطاء
                Using bmp As New System.Drawing.Bitmap(img)
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Return ms.ToArray()
                End Using
            End Using
        Catch ex As Exception
            ' لو حصل أي مشكلة في الصورة نرجع Null عشان السيف ميفشلش
            Return System.DBNull.Value
        End Try
    End Function

End Class


