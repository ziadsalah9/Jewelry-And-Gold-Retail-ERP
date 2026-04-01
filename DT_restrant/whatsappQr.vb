'Imports System.IO
'Imports System.Net.Http
'Imports System.Net.Http.Headers
'Imports System.Text
'Imports Newtonsoft.Json.Linq
'Imports System.Threading.Tasks
'Imports System.Drawing
'Imports System.Drawing.Drawing2D

'Public Class whatsappQr
'    Private Const SettingsFileName As String = "WhatsAppSettings.txt"
'    Private SettingsFilePath As String
'    Private Const ApiBaseUrl As String = "https://wplus.my-sys.online"

'    Private Sub whatsappQr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' تحديد مسار ملف الإعدادات بجانب البرنامج
'        SettingsFilePath = Path.Combine(Application.StartupPath, SettingsFileName)

'        ' تحسين التصميم
'        ApplyModernDesign()

'        ' تحميل الإعدادات تلقائياً عند فتح النموذج
'        LoadSettings()

'        ' تحديث QR Code تلقائياً
'        RefreshQRCode()
'    End Sub

'    Private Sub ApplyModernDesign()
'        ' تحسين مظهر GroupBoxes
'        For Each ctrl As Control In Me.Controls
'            If TypeOf ctrl Is GroupBox Then
'                Dim gb As GroupBox = DirectCast(ctrl, GroupBox)
'                gb.BackColor = Color.White
'            End If
'        Next
'    End Sub

'    ' حفظ الإعدادات في ملف
'    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
'        Try
'            ' التحقق من أن جميع الحقول مملوءة
'            If String.IsNullOrWhiteSpace(txtAuthKey.Text) OrElse
'               String.IsNullOrWhiteSpace(txtAppKey.Text) OrElse
'               String.IsNullOrWhiteSpace(txtUUID.Text) Then
'                MsgBox("يرجى ملء جميع الحقول" & vbCrLf & "Please fill all fields", MsgBoxStyle.Exclamation, "تنبيه")
'                Return
'            End If

'            ' حفظ الإعدادات في ملف نصي
'            Using writer As New StreamWriter(SettingsFilePath, False, Encoding.UTF8)
'                writer.WriteLine("AuthKey=" & txtAuthKey.Text.Trim)
'                writer.WriteLine("AppKey=" & txtAppKey.Text.Trim)
'                writer.WriteLine("UUID=" & txtUUID.Text.Trim)
'            End Using

'            MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Settings saved successfully", MsgBoxStyle.Information, "نجاح")

'            ' تحديث QR Code بعد الحفظ
'            RefreshQRCode()
'        Catch ex As Exception
'            MsgBox("خطأ في حفظ الإعدادات: " & ex.Message & vbCrLf & "Error saving settings: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub

'    ' تحميل الإعدادات من الملف
'    Private Sub btnLoadSettings_Click(sender As Object, e As EventArgs) Handles btnLoadSettings.Click
'        LoadSettings()
'    End Sub

'    Private Sub LoadSettings()
'        Try
'            If File.Exists(SettingsFilePath) Then
'                Using reader As New StreamReader(SettingsFilePath, Encoding.UTF8)
'                    Dim line As String
'                    While Not reader.EndOfStream
'                        line = reader.ReadLine()
'                        If Not String.IsNullOrWhiteSpace(line) AndAlso line.Contains("=") Then
'                            Dim parts() As String = line.Split("="c)
'                            If parts.Length = 2 Then
'                                Dim key As String = parts(0).Trim()
'                                Dim value As String = parts(1).Trim()

'                                Select Case key
'                                    Case "AuthKey"
'                                        txtAuthKey.Text = value
'                                    Case "AppKey"
'                                        txtAppKey.Text = value
'                                    Case "UUID"
'                                        txtUUID.Text = value
'                                End Select
'                            End If
'                        End If
'                    End While
'                End Using

'                ' تحديث QR Code بعد التحميل
'                RefreshQRCode()
'            Else
'                ' إذا لم يكن الملف موجوداً، استخدام القيم الافتراضية
'                txtAuthKey.Text = "oFgQPau3BFXEGWjvUhwcKpz7eeDLYESnQFHXFIiPtJiq2TMGrZ"
'                txtAppKey.Text = "ada3a78b-0ede-464c-90d1-151f96da25bb"
'                txtUUID.Text = "ffb96a44-5a55-445e-a18e-31e74a811aab"
'            End If
'        Catch ex As Exception
'            MsgBox("خطأ في تحميل الإعدادات: " & ex.Message & vbCrLf & "Error loading settings: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub

'    ' تحديث QR Code
'    Private Sub btnRefreshQR_Click(sender As Object, e As EventArgs) Handles btnRefreshQR.Click
'        RefreshQRCode()
'    End Sub

'    Private Sub RefreshQRCode()
'        Try
'            If String.IsNullOrWhiteSpace(txtUUID.Text) Then
'                MsgBox("يرجى إدخال UUID أولاً" & vbCrLf & "Please enter UUID first", MsgBoxStyle.Exclamation, "تنبيه")
'                Return
'            End If

'            ' تحميل صورة QR Code باستخدام POST method مثل Postman
'            LoadQRImage()
'        Catch ex As Exception
'            MsgBox("خطأ في تحديث QR Code: " & ex.Message & vbCrLf & "Error refreshing QR Code: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub

'    ' متغير لحفظ آخر response
'    Private lastResponseInfo As String = ""
'    Private lastResponseContent As String = ""
'    Private lastResponseBytes As Byte() = Nothing

'    Private Async Sub LoadQRImage()
'        Try
'            Dim qrUrl As String = ApiBaseUrl & "/api/qrimage"

'            Using client As New HttpClient()
'                client.Timeout = TimeSpan.FromSeconds(30)

'                ' استخدام POST method مع form-urlencoded مثل Postman
'                Dim formData As New List(Of KeyValuePair(Of String, String))()
'                formData.Add(New KeyValuePair(Of String, String)("device", txtUUID.Text.Trim()))

'                Dim formContent As New FormUrlEncodedContent(formData)

'                ' إرسال الطلب
'                Dim response As HttpResponseMessage = Await client.PostAsync(qrUrl, formContent)

'                ' قراءة الـ response
'                lastResponseContent = Await response.Content.ReadAsStringAsync()
'                lastResponseBytes = Await response.Content.ReadAsByteArrayAsync()

'                ' حفظ معلومات الـ response للتشخيص
'                Dim contentType As String = "N/A"
'                Try
'                    If response.Content.Headers.ContentType IsNot Nothing Then
'                        contentType = response.Content.Headers.ContentType.ToString()
'                    End If
'                Catch
'                End Try

'                lastResponseInfo = "URL: " & qrUrl & vbCrLf &
'                                 "Method: POST" & vbCrLf &
'                                 "Device Parameter: " & txtUUID.Text.Trim() & vbCrLf &
'                                 "Status Code: " & response.StatusCode.ToString() & " (" & CInt(response.StatusCode) & ")" & vbCrLf &
'                                 "Content Type: " & contentType & vbCrLf &
'                                 "Content Length: " & lastResponseBytes.Length & " bytes" & vbCrLf &
'                                 "Response Headers:" & vbCrLf

'                ' إضافة جميع الـ headers
'                For Each header In response.Headers
'                    lastResponseInfo &= "  " & header.Key & ": " & String.Join(", ", header.Value) & vbCrLf
'                Next

'                ' التحقق من نوع المحتوى قبل محاولة عرض الصورة
'                If response.IsSuccessStatusCode Then
'                    ' التحقق من Content-Type
'                    Dim isImage As Boolean = False
'                    If response.Content.Headers.ContentType IsNot Nothing Then
'                        Dim mediaType As String = response.Content.Headers.ContentType.MediaType.ToLower()
'                        isImage = mediaType.StartsWith("image/")
'                    End If

'                    ' إذا كان المحتوى JSON (مثل حالة الجهاز المتصل)، عرض رسالة بدلاً من الصورة
'                    If contentType.ToLower().Contains("application/json") OrElse 
'                       lastResponseContent.Trim().StartsWith("{") OrElse 
'                       lastResponseContent.Trim().StartsWith("[") Then
'                        ' الجهاز متصل بالفعل - لا حاجة لـ QR Code
'                        PicQrCode.Image = Nothing
'                        Try
'                            ' محاولة قراءة JSON
'                            Dim jsonObj As JObject = JObject.Parse(lastResponseContent)
'                            Dim statusMsg As String = ""
'                            If jsonObj("message") IsNot Nothing Then
'                                statusMsg = jsonObj("message").ToString()
'                            ElseIf jsonObj("status") IsNot Nothing Then
'                                statusMsg = jsonObj("status").ToString()
'                            End If

'                            ' عرض رسالة في PictureBox بدلاً من الصورة
'                            Dim bmp As New Bitmap(PicQrCode.Width, PicQrCode.Height)
'                            Using g As Graphics = Graphics.FromImage(bmp)
'                                g.Clear(Color.White)
'                                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

'                                Dim font As New Font("Segoe UI", 10, FontStyle.Bold)
'                                Dim brush As New SolidBrush(Color.FromArgb(37, 211, 102))
'                                Dim sf As New StringFormat()
'                                sf.Alignment = StringAlignment.Center
'                                sf.LineAlignment = StringAlignment.Center

'                                Dim displayText As String = "✅ الجهاز متصل" & vbCrLf & vbCrLf & statusMsg
'                                g.DrawString(displayText, font, brush, New RectangleF(0, 0, bmp.Width, bmp.Height), sf)
'                            End Using
'                            PicQrCode.Image = bmp
'                        Catch
'                            ' إذا فشل تحليل JSON، عرض رسالة بسيطة
'                            PicQrCode.Image = Nothing
'                        End Try
'                    ElseIf isImage Then
'                        ' محاولة قراءة الصورة من الـ bytes
'                        Try
'                            Using stream As New MemoryStream(lastResponseBytes)
'                                Dim img As Image = Image.FromStream(stream)
'                                PicQrCode.Image = img
'                            End Using
'                        Catch imgEx As Exception
'                            ' إذا فشل تحميل الصورة
'                            PicQrCode.Image = Nothing
'                            ShowResponseDialog("فشل في تحويل الـ response إلى صورة" & vbCrLf & vbCrLf &
'                                              "Error: " & imgEx.Message)
'                        End Try
'                    Else
'                        ' نوع محتوى غير معروف
'                        PicQrCode.Image = Nothing
'                        ShowResponseDialog("نوع المحتوى غير مدعوم: " & contentType)
'                    End If
'                Else
'                    ' إذا فشل الطلب
'                    PicQrCode.Image = Nothing
'                    ShowResponseDialog("فشل في تحميل QR Code")
'                End If
'            End Using
'        Catch ex As Exception
'            PicQrCode.Image = Nothing
'            lastResponseInfo = "Exception: " & ex.Message & vbCrLf &
'                            "Stack Trace: " & ex.StackTrace
'            ShowResponseDialog("خطأ في تحميل QR Code")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub

'    ' عرض Response في نافذة منفصلة
'    Private Sub btnShowResponse_Click(sender As Object, e As EventArgs) Handles btnShowResponse.Click
'        ShowResponseDialog("معلومات Response من السيرفر")
'    End Sub
'    Private Sub ShowResponseDialog(title As String)
'        Dim responseText As String = title & vbCrLf & vbCrLf &
'                                    "=================================" & vbCrLf &
'                                    lastResponseInfo & vbCrLf &
'                                    "=================================" & vbCrLf & vbCrLf

'        If lastResponseBytes IsNot Nothing AndAlso lastResponseBytes.Length > 0 Then
'            ' محاولة عرض أول 500 حرف من الـ response
'            If lastResponseContent.Length > 500 Then
'                responseText &= "Response Content (first 500 chars):" & vbCrLf &
'                              lastResponseContent.Substring(0, 500) & "..." & vbCrLf & vbCrLf &
'                              "Total Length: " & lastResponseContent.Length & " characters"
'            Else
'                responseText &= "Response Content:" & vbCrLf & lastResponseContent
'            End If

'            ' معلومات إضافية عن الـ bytes
'            responseText &= vbCrLf & vbCrLf & "First 50 bytes (hex): " & vbCrLf
'            Dim hexString As String = ""
'            For i As Integer = 0 To Math.Min(49, lastResponseBytes.Length - 1)
'                hexString &= lastResponseBytes(i).ToString("X2") & " "
'            Next
'            responseText &= hexString
'        Else
'            responseText &= "لا توجد بيانات response"
'        End If
'        ' استخدام TextBox لعرض النص الكامل
'        Dim responseForm As New Form()
'        responseForm.Text = "Response Information"
'        responseForm.Size = New Size(700, 500)
'        responseForm.StartPosition = FormStartPosition.CenterParent
'        Dim txtResponse As New TextBox()
'        txtResponse.Multiline = True
'        txtResponse.ScrollBars = ScrollBars.Both
'        txtResponse.Dock = DockStyle.Fill
'        txtResponse.Font = New Font("Consolas", 9)
'        txtResponse.Text = responseText
'        txtResponse.ReadOnly = True
'        responseForm.Controls.Add(txtResponse)
'        responseForm.ShowDialog(Me)
'    End Sub

'    ' إرسال رسالة اختبار (غير متزامن في thread منفصل)
'    Private Sub btnTestSend_Click(sender As Object, e As EventArgs) Handles btnTestSend.Click
'        Try
'            ' التحقق من أن جميع الحقول مملوءة
'            If String.IsNullOrWhiteSpace(txtAuthKey.Text) OrElse
'               String.IsNullOrWhiteSpace(txtAppKey.Text) OrElse
'               String.IsNullOrWhiteSpace(txtTestPhone.Text) OrElse
'               String.IsNullOrWhiteSpace(txtTestMessage.Text) Then
'                MsgBox("يرجى ملء جميع الحقول" & vbCrLf & "Please fill all fields", MsgBoxStyle.Exclamation, "تنبيه")
'                Return
'            End If

'            ' التحقق من وجود الملف إذا تم تحديده
'            Dim filePath As String = txtFilePath.Text.Trim()
'            If Not String.IsNullOrWhiteSpace(filePath) AndAlso Not File.Exists(filePath) Then
'                MsgBox("الملف المحدد غير موجود" & vbCrLf & "Selected file does not exist", MsgBoxStyle.Exclamation, "تنبيه")
'                Return
'            End If

'            ' تعطيل الزر أثناء الإرسال
'            btnTestSend.Enabled = False
'            btnTestSend.Text = "جاري الإرسال..."

'            ' إرسال الرسالة في thread منفصل بدون انتظار
'            Task.Run(Async Function() As Task
'                         Try
'                             ' حفظ القيم قبل الإرسال
'                             Dim phone As String = txtTestPhone.Text.Trim()
'                             Dim message As String = txtTestMessage.Text.Trim()
'                             Dim authKey As String = txtAuthKey.Text.Trim()
'                             Dim appKey As String = txtAppKey.Text.Trim()
'                             Dim selectedFile As String = If(String.IsNullOrWhiteSpace(filePath), Nothing, filePath)

'                             ' إرسال الرسالة (مع الملف إذا كان موجوداً) باستخدام الدالة من ModuleMain
'                             Dim result As Boolean = False
'                             If Not String.IsNullOrWhiteSpace(selectedFile) Then
'                                 ' إرسال مع ملف
'                                 result = Await SendWhatsAppFileAsync(phone, message, selectedFile, authKey, appKey, ApiBaseUrl)
'                             Else
'                                 ' إرسال رسالة فقط (بدون ملف)
'                                 result = Await SendWhatsAppMessageAsync(phone, message, authKey, appKey, ApiBaseUrl)
'                             End If

'                             Dim resultText As String = If(result, "تم الإرسال بنجاح" & vbCrLf & "Message sent successfully", "فشل الإرسال" & vbCrLf & "Failed to send")

'                             ' عرض النتيجة في UI thread
'                             Me.Invoke(Sub()
'                                           btnTestSend.Enabled = True
'                                           btnTestSend.Text = "🚀 إرسال رسالة اختبار"
'                                           MsgBox("نتيجة الإرسال:" & vbCrLf & resultText & vbCrLf & vbCrLf & "Send Result:" & vbCrLf & resultText, MsgBoxStyle.Information, "نتيجة الإرسال")
'                                       End Sub)
'                         Catch ex As Exception
'                             ' عرض الخطأ في UI thread
'                             Me.Invoke(Sub()
'                                           btnTestSend.Enabled = True
'                                           btnTestSend.Text = "🚀 إرسال رسالة اختبار"
'                                           MsgBox("خطأ في إرسال الرسالة: " & ex.Message & vbCrLf & "Error sending message: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'                                           RecordRrrors(DescriptionRrrors:=ex.ToString)
'                                       End Sub)
'                         End Try
'                     End Function)
'        Catch ex As Exception
'            ' في حالة خطأ في بدء الإرسال
'            btnTestSend.Enabled = True
'            btnTestSend.Text = "🚀 إرسال رسالة اختبار"
'            MsgBox("خطأ في بدء الإرسال: " & ex.Message & vbCrLf & "Error starting send: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub

'    ' تم نقل دالة الإرسال إلى ModuleMain.vb - SendWhatsAppFileAsync و SendWhatsAppMessageAsync

'    ' تحديث QR Code تلقائياً كل 5 ثواني
'    Private Sub TimerQR_Tick(sender As Object, e As EventArgs) Handles TimerQR.Tick
'        If Not String.IsNullOrWhiteSpace(txtUUID.Text) Then
'            RefreshQRCode()
'        End If
'    End Sub

'    ' عند تغيير UUID، تحديث QR Code
'    Private Sub txtUUID_TextChanged(sender As Object, e As EventArgs) Handles txtUUID.TextChanged
'        ' يمكن إضافة تحديث تلقائي هنا إذا رغبت
'    End Sub

'    ' اختيار ملف للإرسال
'    Private Sub btnBrowseFile_Click(sender As Object, e As EventArgs) Handles btnBrowseFile.Click
'        Try
'            Using openFileDialog As New OpenFileDialog()
'                openFileDialog.Filter = "جميع الملفات|*.*|صور|*.jpg;*.jpeg;*.png;*.gif;*.bmp|مستندات|*.pdf;*.doc;*.docx;*.xls;*.xlsx|فيديو|*.mp4;*.avi;*.mov|صوت|*.mp3;*.wav"
'                openFileDialog.FilterIndex = 1
'                openFileDialog.RestoreDirectory = True
'                openFileDialog.Title = "اختر ملف للإرسال"

'                If openFileDialog.ShowDialog() = DialogResult.OK Then
'                    txtFilePath.Text = openFileDialog.FileName
'                End If
'            End Using
'        Catch ex As Exception
'            MsgBox("خطأ في اختيار الملف: " & ex.Message & vbCrLf & "Error selecting file: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'            RecordRrrors(DescriptionRrrors:=ex.ToString)
'        End Try
'    End Sub
'End Class
