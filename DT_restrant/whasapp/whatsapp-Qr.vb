Imports System.Net.Http
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks

Public Class whatsapp_Qr

    Private Sub whatsapp_Qr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim keys = GetAppKeys()

        Dim authKey As String = keys.AuthKey
        Dim appKey As String = keys.AppKey
        Dim uuid As String = keys.UUID

        txtAuthKey.Text = authKey
        txtAppKey.Text = appKey
        txtUUID.Text = uuid
        ' تحسين التصميم
        ApplyModernDesign()

        ' تحميل QR Code عند فتح النموذج
        RefreshQRCode()
    End Sub

    Private Sub btnLoadLastImages_Click(sender As Object, e As EventArgs) Handles btnLoadLastImages.Click
        Try
            ' التحقق من وجود UUID
            If String.IsNullOrWhiteSpace(txtUUID.Text) Then
                MessageBox.Show("يرجى إدخال UUID أولاً" & vbCrLf &
                               "Please enter UUID first",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUUID.Focus()
                Return
            End If

            ' تعطيل الزر أثناء التحميل
            btnLoadLastImages.Enabled = False
            btnLoadLastImages.Text = "⏳ جاري التحميل..."

            ' جلب الصور من API (بدون phone - جلب آخر الصور عموماً)
            LoadLastImagesAsync(txtUUID.Text.Trim(), Nothing)

        Catch ex As Exception
            MessageBox.Show("خطأ في جلب الصور: " & ex.Message & vbCrLf & "Error loading images: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLoadLastImages.Enabled = True
            btnLoadLastImages.Text = "🔄 جلب آخر الصور"
        End Try
    End Sub

    Private Sub btnGetIDFromWhatsApp_Click(sender As Object, e As EventArgs) Handles btnGetIDFromWhatsApp.Click
        Try
            ' التحقق من وجود UUID و Phone
            If String.IsNullOrWhiteSpace(txtUUID.Text) Then
                MessageBox.Show("يرجى إدخال UUID أولاً" & vbCrLf &
                               "Please enter UUID first",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUUID.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPhoneForID.Text) Then
                MessageBox.Show("يرجى إدخال رقم الهاتف" & vbCrLf &
                               "Please enter phone number",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhoneForID.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtAuthKey.Text) OrElse String.IsNullOrWhiteSpace(txtAppKey.Text) Then
                MessageBox.Show("يرجى إدخال Auth Key و App Key" & vbCrLf &
                               "Please enter Auth Key and App Key",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' تعطيل الزر أثناء العملية
            btnGetIDFromWhatsApp.Enabled = False
            btnGetIDFromWhatsApp.Text = "⏳ جاري الإرسال..."

            ' إرسال الرسالة وجلب الهوية
            GetIDFromWhatsAppAsync(txtPhoneForID.Text.Trim(), txtUUID.Text.Trim(), txtAuthKey.Text.Trim(), txtAppKey.Text.Trim())

        Catch ex As Exception
            MessageBox.Show("خطأ في جلب الهوية: " & ex.Message & vbCrLf & "Error getting ID: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnGetIDFromWhatsApp.Enabled = True
            btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
        End Try
    End Sub

    Private Async Sub GetIDFromWhatsAppAsync(phone As String, deviceId As String, authKey As String, appKey As String)
        Try
            Dim apiBaseUrl As String = "https://wplus.sabpay.net"
            Dim requestMessage As String = "برجاء ارسال هويتيك"

            ' جلب آخر صورتين الحاليتين قبل إرسال الرسالة
            Dim oldMessageIds As New List(Of String)
            Try
                Dim oldImagesResult = Await GetCurrentLastImagesAsync(deviceId, phone)
                If oldImagesResult.Success AndAlso oldImagesResult.MessageIds IsNot Nothing Then
                    oldMessageIds = oldImagesResult.MessageIds
                    Me.Invoke(Sub()
                                  lblLastImages.Text = "تم حفظ " & oldMessageIds.Count & " صورة قديمة - جاري إرسال الرسالة..."
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
                              btnGetIDFromWhatsApp.Enabled = True
                              btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
                          End Sub)
                Return
            End If

            ' تحديث حالة الزر
            Me.Invoke(Sub()
                          btnGetIDFromWhatsApp.Text = "⏳ في انتظار الصور..."
                          lblLastImages.Text = "تم إرسال الرسالة - في انتظار الصور الجديدة..."
                      End Sub)

            ' عمل loop لمدة 20 ثانية للتحقق من الصور الجديدة
            Dim maxWaitTime As TimeSpan = TimeSpan.FromSeconds(20)
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
                                  lblLastImages.Text = "تم العثور على الصور الجديدة!"
                                  btnGetIDFromWhatsApp.Enabled = True
                                  btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
                              End Sub)
                    Exit While
                End If

                ' تحديث حالة الانتظار
                Dim remainingSeconds As Integer = CInt((maxWaitTime.TotalSeconds - elapsedTime.TotalSeconds))
                Me.Invoke(Sub()
                              btnGetIDFromWhatsApp.Text = "⏳ في انتظار الصور... (" & remainingSeconds & "s)"
                          End Sub)
            End While

            If Not imagesFound Then
                Me.Invoke(Sub()
                              MessageBox.Show("لم يتم استلام الصور خلال 15 ثانية" & vbCrLf & "Images not received within 15 seconds", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                              btnGetIDFromWhatsApp.Enabled = True
                              btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
                              lblLastImages.Text = "انتهى وقت الانتظار"
                          End Sub)
            End If

        Catch ex As Exception
            Me.Invoke(Sub()
                          MessageBox.Show("خطأ في جلب الهوية: " & ex.Message & vbCrLf & "Error getting ID: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                          btnGetIDFromWhatsApp.Enabled = True
                          btnGetIDFromWhatsApp.Text = "🆔 جلب هوية من واتساب"
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

                ' إنشاء form data مع device_id و phone
                Dim formData As New List(Of KeyValuePair(Of String, String))()
                formData.Add(New KeyValuePair(Of String, String)("device_id", deviceId))
                formData.Add(New KeyValuePair(Of String, String)("phone", phone))
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
                            ' التحقق من أن الصور من نفس الرقم المرسل إليه
                            Dim image1FromPhone As String = imagesArray(0)("from_phone").ToString()
                            Dim image2FromPhone As String = imagesArray(1)("from_phone").ToString()

                            ' التحقق من أن الصور من نفس الرقم
                            If image1FromPhone = phone AndAlso image2FromPhone = phone Then
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

                                If areNewImages Then
                                    ' الصور جديدة - عرضها
                                    Dim image1Url As String = imagesArray(0)("image_url").ToString()
                                    Dim image2Url As String = imagesArray(1)("image_url").ToString()
                                    Dim image1CreatedAt As String = imagesArray(0)("created_at").ToString()

                                    ' تحميل وعرض الصورة الأولى
                                    Await LoadImageFromUrlAsync(image1Url, picImage2)

                                    ' تحميل وعرض الصورة الثانية
                                    Await LoadImageFromUrlAsync(image2Url, picImage1)

                                    ' تحديث التسمية
                                    Dim totalImages As Integer = CInt(dataObj("total_images"))
                                    Dim displayText As String = "تم جلب " & totalImages & " صورة جديدة - " & image1CreatedAt

                                    Me.Invoke(Sub()
                                                  lblLastImages.Text = displayText
                                              End Sub)

                                    Return (True, True)
                                Else
                                    ' الصور قديمة (نفس message_id)
                                    Return (True, False)
                                End If
                            Else
                                ' الصور ليست من نفس الرقم
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

    Private Async Sub LoadLastImagesAsync(deviceId As String, phone As String)
        Try
            Dim apiUrl As String = "https://wplus.sabpay.net/api/get-last-images"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(30)

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
                            ' جلب URL الصورة الأولى
                            Dim image1Url As String = imagesArray(0)("image_url").ToString()
                            Dim image2Url As String = imagesArray(1)("image_url").ToString()

                            ' تحميل وعرض الصورة الأولى
                            Await LoadImageFromUrlAsync(image1Url, picImage1)

                            ' تحميل وعرض الصورة الثانية
                            Await LoadImageFromUrlAsync(image2Url, picImage2)

                            ' تحديث التسمية
                            Dim totalImages As Integer = CInt(dataObj("total_images"))
                            Me.Invoke(Sub()
                                          lblLastImages.Text = "تم جلب " & totalImages & " صورة"
                                          btnLoadLastImages.Enabled = True
                                          btnLoadLastImages.Text = "🔄 جلب آخر الصور"
                                      End Sub)
                        Else
                            Me.Invoke(Sub()
                                          MessageBox.Show("لم يتم العثور على صورتين" & vbCrLf & "Two images not found", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                          btnLoadLastImages.Enabled = True
                                          btnLoadLastImages.Text = "🔄 جلب آخر الصور"
                                      End Sub)
                        End If
                    Else
                        Dim errorMsg As String = If(jsonObj("message") IsNot Nothing, jsonObj("message").ToString(), "Unknown error")
                        Me.Invoke(Sub()
                                      MessageBox.Show("فشل في جلب الصور: " & errorMsg & vbCrLf & "Failed to load images: " & errorMsg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                      btnLoadLastImages.Enabled = True
                                      btnLoadLastImages.Text = "🔄 جلب آخر الصور"
                                  End Sub)
                    End If
                Else
                    Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                    Me.Invoke(Sub()
                                  MessageBox.Show("فشل في جلب الصور" & vbCrLf &
                                                "Status: " & response.StatusCode.ToString() & vbCrLf &
                                                "Error: " & errorContent & vbCrLf &
                                                "Failed to load images",
                                                "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                  btnLoadLastImages.Enabled = True
                                  btnLoadLastImages.Text = "🔄 جلب آخر الصور"
                              End Sub)
                End If
            End Using

        Catch ex As Exception
            Me.Invoke(Sub()
                          MessageBox.Show("خطأ في جلب الصور من API: " & ex.Message & vbCrLf & "Error loading images from API: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                          btnLoadLastImages.Enabled = True
                          btnLoadLastImages.Text = "🔄 جلب آخر الصور"
                      End Sub)
        End Try
    End Sub

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
                      End Sub)
        End Try
    End Function

    Private Sub ApplyModernDesign()
        ' تحسين مظهر النموذج
        Me.BackColor = Color.FromArgb(240, 242, 245)

        ' تحسين مظهر GroupBoxes
        For Each ctrl As Control In pnlMain.Controls
            If TypeOf ctrl Is GroupBox Then
                Dim gb As GroupBox = DirectCast(ctrl, GroupBox)
                gb.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshQRCode()
    End Sub

    Private Sub RefreshQRCode()
        Try
            ' التحقق من وجود UUID
            If String.IsNullOrWhiteSpace(txtUUID.Text) Then
                MessageBox.Show("يرجى إدخال UUID أولاً" & vbCrLf &
                               "Please enter UUID first",
                               "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUUID.Focus()
                Return
            End If

            ' تعطيل زر التحديث أثناء التحميل
            btnRefresh.Enabled = False
            btnRefresh.Text = "⏳ جاري التحميل..."

            ' جلب QR Code من API (Async)
            LoadQRImageFromAPIAsync(txtUUID.Text.Trim())

        Catch ex As Exception
            MessageBox.Show("خطأ في تحديث QR Code: " & ex.Message & vbCrLf & "Error updating QR Code: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnRefresh.Enabled = True
            btnRefresh.Text = "🔄 تحديث QR Code"
        End Try
    End Sub

    Private Async Sub LoadQRImageFromAPIAsync(deviceUUID As String)
        Try
            Dim apiUrl As String = "https://wplus.sabpay.net/api/qrimage"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(30)

                ' استخدام POST method مع form-urlencoded مثل Postman
                Dim formData As New List(Of KeyValuePair(Of String, String))()
                formData.Add(New KeyValuePair(Of String, String)("device", deviceUUID))
                Dim formContent As New FormUrlEncodedContent(formData)

                ' إرسال الطلب
                Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl, formContent)

                ' قراءة الـ response
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                Dim responseBytes As Byte() = Await response.Content.ReadAsByteArrayAsync()

                ' الحصول على Content-Type
                Dim contentType As String = "N/A"
                Try
                    If response.Content.Headers.ContentType IsNot Nothing Then
                        contentType = response.Content.Headers.ContentType.ToString()
                    End If
                Catch
                End Try

                ' التحقق من نوع المحتوى قبل محاولة عرض الصورة
                If response.IsSuccessStatusCode Then
                    ' التحقق من Content-Type
                    Dim isImage As Boolean = False
                    If response.Content.Headers.ContentType IsNot Nothing Then
                        Dim mediaType As String = response.Content.Headers.ContentType.MediaType.ToLower()
                        isImage = mediaType.StartsWith("image/")
                    End If

                    ' إذا كان المحتوى JSON (مثل حالة الجهاز المتصل)، عرض رسالة بدلاً من الصورة
                    If contentType.ToLower().Contains("application/json") OrElse
                       responseContent.Trim().StartsWith("{") OrElse
                       responseContent.Trim().StartsWith("[") Then
                        ' الجهاز متصل بالفعل - لا حاجة لـ QR Code
                        picQRCode.Image = Nothing
                        Try
                            ' محاولة قراءة JSON
                            Dim jsonObj As JObject = JObject.Parse(responseContent)
                            Dim statusMsg As String = ""


                            If jsonObj("message") IsNot Nothing Then
                                statusMsg = jsonObj("message").ToString()
                            ElseIf jsonObj("status") IsNot Nothing Then
                                statusMsg = jsonObj("status").ToString()
                            End If


                            If jsonObj("phone").ToString() <> "" Then
                                statusMsg += vbCrLf & jsonObj("phone").ToString()
                            End If

                            ' عرض رسالة في PictureBox بدلاً من الصورة
                            Dim bmp As New Bitmap(picQRCode.Width, picQRCode.Height)
                            Using g As Graphics = Graphics.FromImage(bmp)
                                g.Clear(Color.White)
                                g.SmoothingMode = SmoothingMode.AntiAlias
                                Dim font As New Font("Segoe UI", 10, FontStyle.Bold)
                                Dim brush As New SolidBrush(Color.FromArgb(37, 211, 102))
                                Dim sf As New StringFormat()
                                sf.Alignment = StringAlignment.Center
                                sf.LineAlignment = StringAlignment.Center
                                Dim displayText As String = "✅ الجهاز متصل" & vbCrLf & vbCrLf & statusMsg
                                g.DrawString(displayText, font, brush, New RectangleF(0, 0, bmp.Width, bmp.Height), sf)
                            End Using
                            picQRCode.Image = bmp
                        Catch
                            ' إذا فشل تحليل JSON، عرض رسالة بسيطة
                            picQRCode.Image = Nothing
                        End Try
                    ElseIf isImage Then
                        ' محاولة قراءة الصورة من الـ bytes
                        Try

                            Using stream As New MemoryStream(responseBytes)
                                Dim img As Image = Image.FromStream(stream)
                                picQRCode.Image = img
                                picQRCode.BackColor = Color.White
                            End Using

                        Catch imgEx As Exception
                            ' إذا فشل تحميل الصورة
                            picQRCode.Image = Nothing
                            MessageBox.Show("فشل في تحويل الـ response إلى صورة" & vbCrLf & vbCrLf &
                                          "Error: " & imgEx.Message,
                                          "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        ' نوع محتوى غير معروف
                        picQRCode.Image = Nothing
                        MessageBox.Show("نوع المحتوى غير مدعوم: " & contentType & vbCrLf &
                                      "Content type not supported: " & contentType,
                                      "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    ' إذا فشل الطلب
                    picQRCode.Image = Nothing
                    Dim errorContent As String = responseContent
                    MessageBox.Show("فشل في تحميل QR Code" & vbCrLf &
                                  "Status: " & response.StatusCode.ToString() & vbCrLf &
                                  "Error: " & errorContent & vbCrLf &
                                  "Failed to load QR Code",
                                  "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            picQRCode.Image = Nothing
            MessageBox.Show("خطأ في جلب QR Code من API: " & ex.Message & vbCrLf &
                          "Error loading QR Code from API: " & ex.Message,
                          "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' إعادة تفعيل زر التحديث
            btnRefresh.Enabled = True
            btnRefresh.Text = "🔄 تحديث QR Code"
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' التحقق من صحة جميع الحقول
            If String.IsNullOrWhiteSpace(txtPhoneNumber.Text) Then
                MessageBox.Show("يرجى إدخال رقم الهاتف" & vbCrLf & "Please enter phone number", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPhoneNumber.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtAuthKey.Text) Then
                MessageBox.Show("يرجى إدخال Auth Key" & vbCrLf & "Please enter Auth Key", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAuthKey.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtAppKey.Text) Then
                MessageBox.Show("يرجى إدخال App Key" & vbCrLf & "Please enter App Key", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAppKey.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtUUID.Text) Then
                MessageBox.Show("يرجى إدخال UUID" & vbCrLf & "Please enter UUID", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUUID.Focus()
                Return
            End If

            ' حفظ الإعدادات في قاعدة البيانات
            Dim result As Boolean = UpdateAppKeys(txtAuthKey.Text.Trim(), txtAppKey.Text.Trim(), txtUUID.Text.Trim())

            If result Then
                ' عرض ملخص الإعدادات المحفوظة
                Dim summary As String = "تم حفظ الإعدادات بنجاح:" & vbCrLf & vbCrLf &
                                        "Auth Key: " & txtAuthKey.Text.Substring(0, Math.Min(20, txtAuthKey.Text.Length)) & "..." & vbCrLf &
                                        "App Key: " & txtAppKey.Text & vbCrLf &
                                        "UUID: " & txtUUID.Text & vbCrLf &
                                        "Phone: " & txtPhoneNumber.Text

                MessageBox.Show(summary & vbCrLf & vbCrLf & "Settings saved successfully", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("فشل حفظ الإعدادات في قاعدة البيانات" & vbCrLf & "Failed to save settings to database", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في حفظ الإعدادات: " & ex.Message & vbCrLf & "Error saving settings: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function UpdateAppKeys(authKey As String, appKey As String, uuid As String) As Boolean
        Try

            GlCommand.Parameters.Clear()

            GlCommand.CommandText =
            "UPDATE dbo.comp_inform SET " &
            "AuthKey = @AuthKey, " &
            "AppKey  = @AppKey, " &
            "UUID    = @UUID"

            With GlCommand.Parameters
                .AddWithValue("@AuthKey", authKey)
                .AddWithValue("@AppKey", appKey)
                .AddWithValue("@UUID", uuid)
            End With

            GlCommand.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MessageBox.Show("خطأ في تحديث المفاتيح: " & ex.Message & vbCrLf & "Update App Keys Error: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnTestSend_Click(sender As Object, e As EventArgs) Handles btnTestSend.Click
        Try
            ' التحقق من أن جميع الحقول مملوءة
            If String.IsNullOrWhiteSpace(txtAuthKey.Text) OrElse
               String.IsNullOrWhiteSpace(txtAppKey.Text) OrElse
               String.IsNullOrWhiteSpace(txtPhoneNumber.Text) OrElse
               String.IsNullOrWhiteSpace(txtTestMessage.Text) Then
                MessageBox.Show("يرجى ملء جميع الحقول" & vbCrLf & "Please fill all fields", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' تعطيل الزر أثناء الإرسال
            btnTestSend.Enabled = False
            btnTestSend.Text = "⏳ جاري الإرسال..."

            ' إرسال الرسالة في thread منفصل بدون انتظار
            Task.Run(Async Function() As Task
                         Try
                             ' حفظ القيم قبل الإرسال
                             Dim phone As String = txtPhoneNumber.Text.Trim()
                             Dim message As String = txtTestMessage.Text.Trim()
                             Dim authKey As String = txtAuthKey.Text.Trim()
                             Dim appKey As String = txtAppKey.Text.Trim()
                             Dim apiBaseUrl As String = "https://wplus.sabpay.net"

                             ' إرسال رسالة فقط (بدون ملف)
                             Dim result As Boolean = Await SendWhatsAppMessageAsync(phone, message, authKey, appKey, apiBaseUrl)

                             Dim resultText As String = If(result, "تم الإرسال بنجاح" & vbCrLf & "Message sent successfully", "فشل الإرسال" & vbCrLf & "Failed to send")

                             ' عرض النتيجة في UI thread
                             Me.Invoke(Sub()
                                           btnTestSend.Enabled = True
                                           btnTestSend.Text = "📤 اختبار الإرسال"
                                           MessageBox.Show("نتيجة الإرسال:" & vbCrLf & resultText & vbCrLf & vbCrLf & "Send Result:" & vbCrLf & resultText, "نتيجة الإرسال", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                       End Sub)
                         Catch ex As Exception
                             ' عرض الخطأ في UI thread
                             Me.Invoke(Sub()
                                           btnTestSend.Enabled = True
                                           btnTestSend.Text = "📤 اختبار الإرسال"
                                           MessageBox.Show("خطأ في إرسال الرسالة: " & ex.Message & vbCrLf & "Error sending message: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                           RecordRrrors(DescriptionRrrors:=ex.ToString)
                                       End Sub)
                         End Try
                     End Function)
        Catch ex As Exception
            ' في حالة خطأ في بدء الإرسال
            btnTestSend.Enabled = True
            btnTestSend.Text = "📤 اختبار الإرسال"
            MessageBox.Show("خطأ في بدء الإرسال: " & ex.Message & vbCrLf & "Error starting send: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
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

    ' دالة إرسال رسالة WhatsApp مع ملف (Async)
    Private Async Function SendWhatsAppFileAsync(phone As String, message As String, filePath As String, authKey As String, appKey As String, apiBaseUrl As String) As Task(Of Boolean)
        Try
            If Not File.Exists(filePath) Then
                Return False
            End If

            Dim url As String = apiBaseUrl & "/api/create-message"

            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(60) ' timeout أطول للملفات

                ' إنشاء form data
                Dim formData As New MultipartFormDataContent()
                formData.Add(New StringContent(appKey), "appkey")
                formData.Add(New StringContent(authKey), "authkey")
                formData.Add(New StringContent(phone), "to")
                formData.Add(New StringContent(message), "message")

                ' إضافة الملف
                Dim fileName As String = Path.GetFileName(filePath)
                Dim fileBytes As Byte() = File.ReadAllBytes(filePath)
                Dim fileContent As New ByteArrayContent(fileBytes)
                formData.Add(fileContent, "data", fileName)

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

End Class
