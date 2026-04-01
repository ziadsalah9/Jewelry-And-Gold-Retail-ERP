Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Module WhatspApi
    Public AutKey, UuserId, AccActiv As String
    Public Sub GetSQLWhatsappData()
        ' التحقق من وجود اتصال بالإنترنت قبل محاولة جلب البيانات
        'If Not HasOnlineConnection OrElse String.IsNullOrEmpty(OnLineSqlConnection) Then
        ' لا يوجد اتصال بالإنترنت - لا نحاول جلب البيانات
        Return
        'End If

        Try
            DataTab.Clear()
            SqlCon.ConnectionString = OnLineSqlConnection
            SqlCon.Open()
        Catch ex As Exception
            DataTab.Clear()
            SqlCon.ConnectionString = OnLineSqlConnection
            SqlCon.Open()
            RecordRrrors(ex.ToString)
        End Try
        Try
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "SELECT * FROM WhatsappCastomer WHERE LICENSECode= '" & CpuIdSystemSerialNumber & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            If DataTab.Rows.Count > 0 Then
                AutKey = DataTab.Rows(0)("WhatsApp_AuthKey").ToString
                UuserId = DataTab.Rows(0)("WhatsApp_Uuid").ToString
                AccActiv = DataTab.Rows(0)("AccActiv").ToString
            End If
        Catch ex As Exception
            RecordRrrors(ex.ToString)
        End Try
    End Sub
    Function api_login(ByVal authKey As String) As String
        ' API Endpoint URL

        'Dim apiUrl As String = WhatsappApiLinek & "/api/Check-auth/" & AutKey
        Dim apiUrl As String = WhatsappApiLinek & "/api/Check-auth/" & AutKey
        ' HttpClient to make the HTTP request
        ' HttpClient to make the HTTP request
        Dim httpClient As New HttpClient()

        ' Send GET request asynchronously
        Dim responseTask = httpClient.GetAsync(apiUrl)

        ' Await the response and read the content
        Dim responseContent = responseTask.Result.Content.ReadAsStringAsync().Result

        ' Return the response content
        Return responseContent
    End Function
    Public Sub notify()
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = client.GetAsync(WhatsappApiLinek & "/cron/notify-to-user").Result
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Catch e As HttpRequestException
                Console.WriteLine("Request error: " & e.Message)
            End Try
        End Using
    End Sub
    Function SignOut(ByVal authKey As String, ByVal uuid As String)
        Using client As New HttpClient()
            Try
                ' Make the GET request
                Dim response As HttpResponseMessage = client.GetAsync(WhatsappApiLinek & "/api/logout/?authkey=" & AutKey & "&device_id=" & uuid).Result
                response.EnsureSuccessStatusCode()
                ' Read and display the response body
                Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                Console.WriteLine(responseBody)
                MsgBox("تم تسجيل الخروج بنجاح" & vbCrLf & "You have successfully logged Out", , AppTitle)
            Catch e As HttpRequestException
                Console.WriteLine("Request error: " & e.Message)
                'MsgBox("Request error: " & e.Message)
            End Try
        End Using
        Return SignOut
    End Function

    Function api_getqr(ByVal authKey As String, ByVal uuid As String)
        Dim apiUrl As String = WhatsappApiLinek & "/api/qr/?device=" & uuid & "&authkey=" & AutKey
        Dim httpClient As New HttpClient()
        Dim payload As String = "User-Agent=PostmanRuntime/7.36.1" &
                                "&Connection=keep-alive"
        Dim req As String = String.Format(payload)
        Dim content As New StringContent(req, Encoding.UTF8, "application/x-www-form-urlencoded")
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(apiUrl).Result
            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
            If response.IsSuccessStatusCode Then
                If responseContent.ToString.Contains("qr") Then
                    Dim jsonResponse As JObject = JObject.Parse(responseContent)
                    If jsonResponse("qr").ToString() <> Nothing Then
                        Dim imageBytes As Byte() = Convert.FromBase64String(jsonResponse("qr").ToString().Replace("data:image/png;base64,", ""))
                        Using stream As New MemoryStream(imageBytes)
                            ' Create an Image from the MemoryStream
                            Dim image As Image = image.FromStream(stream)
                            Return image
                        End Using
                    Else
                        Return 1
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Using
    End Function
    Function api_get_devices(ByVal authKey As String) As String
        Dim apiUrl As String = WhatsappApiLinek & "/api/get_all?authkey=" & AutKey
        Dim httpClient As New HttpClient()
        Dim responseTask = httpClient.GetAsync(apiUrl)
        Dim responseContent = responseTask.Result.Content.ReadAsStringAsync().Result
        ' Return the response content
        Return responseContent
    End Function
    'Function api_send(ByVal num, ByVal mes, ByVal auth, ByVal app)
    '    Dim url As String = WhatsappApiLinek & "/api/create-message"
    '    Dim payload As String = "appkey=" & app & "&authkey=" & auth & "&to=+" & num & "&message=" & mes
    '    Dim req As String = String.Format(payload, num, mes)
    '    Dim content As New StringContent(req, Encoding.UTF8, "application/x-www-form-urlencoded")
    '    Using client As New HttpClient()
    '        Dim response As HttpResponseMessage = client.PostAsync(url, content).Result
    '        If response.IsSuccessStatusCode Then
    '            Dim responseContent As String = response.Content.ReadAsStringAsync().Result
    '            Return (responseContent)
    '        Else
    '        End If
    '    End Using
    'End Function
    Function api_send(ByVal num, ByVal mes, ByVal auth, ByVal app)
        Dim url As String = WhatsappApiLinek & "/api/create-message"
        ' Create a new instance of MultipartFormDataContent
        Dim formData As New MultipartFormDataContent()
        ' Add text parameters
        formData.Add(New StringContent(app), "appkey")
        formData.Add(New StringContent(auth), "authkey")
        formData.Add(New StringContent(num), "to")
        formData.Add(New StringContent(mes), "message")
        Return SendRequest(url, formData)
    End Function

    '-----------------------------------------------------------------------------------------------------------------
    ' Other Method 
    '-----------------------------------------------------------------------------------------------------------------
    Function send_apifile(ByVal num As String, ByVal mes As String, ByVal auth As String, ByVal app As String, ByVal filePath As String) As Task
        Dim url As String = WhatsappApiLinek & "/api/create-message"
        ' Create a new instance of MultipartFormDataContent
        Dim formData As New MultipartFormDataContent()
        ' Add text parameters
        formData.Add(New StringContent(app), "appkey")
        formData.Add(New StringContent(auth), "authkey")
        formData.Add(New StringContent(num), "to")
        formData.Add(New StringContent(mes), "message")
        ' Encode the file name
        'Dim encodedFileName As String = HttpUtility.UrlEncode(Path.GetFileName(filePath))
        Dim encodedFileName As String = (Path.GetFileName(filePath))
        ' Add file parameter
        Dim fileBytes As Byte() = File.ReadAllBytes(filePath)
        Dim fileContent As New ByteArrayContent(fileBytes)
        ' Add the encoded file name to the form data
        formData.Add(fileContent, "data", encodedFileName)
        Return SendRequest(url, formData)
    End Function
    Function SendRequest(ByVal url As String, ByVal content As HttpContent) As Task
        Dim client As New HttpClient()
        Return client.PostAsync(url, content).ContinueWith(
            Function(responseTask)
                Dim response = responseTask.Result
                If response.IsSuccessStatusCode Then
                    Dim responseContentTask = response.Content.ReadAsStringAsync()
                    Return responseContentTask.ContinueWith(
                        Function(contentTask)
                            MsgBox(contentTask.Result)
                        End Function)
                Else
                    MsgBox("Error: {response.StatusCode} - {response.ReasonPhrase}")
                End If
            End Function).Unwrap()
    End Function
End Module
