Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Globalization
Imports System.Threading
Imports System.Threading.Tasks

Public Module GoldPrice

    '================ إعدادات عامة =================
    Public BlinkUpColor As Color = Color.FromArgb(0, 160, 0)
    Public BlinkDownColor As Color = Color.FromArgb(200, 0, 0)
    Public BlinkCycles As Integer = 3
    Public BlinkOnMs As Integer = 180
    Public BlinkOffMs As Integer = 120
    Public ChangeEpsilon As Decimal = 0.0001D
    Public NumberFormat As String = "0.000"

    ' مدة التحديث (افتراضي 30 ثانية)
    Public UpdateIntervalSeconds As Integer = 30
    
    ' دالة مساعدة للحصول على frmMain
    Private Function GetFrmMain() As frmMain
        Try
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is frmMain Then
                    Return CType(frm, frmMain)
                End If
            Next
        Catch
        End Try
        Return Nothing
    End Function

    ' آخر القيم لكل مفتاح
    Private ReadOnly LastVals As New Dictionary(Of String, Decimal)(StringComparer.OrdinalIgnoreCase)

    ' ربط Panel + Control بالمفتاح
    Private Class PriceBinding
        Public Property Key As String
        Public Property Panel As Panel
        Public Property ValueControl As Control
    End Class

    Private ReadOnly Bindings As New List(Of PriceBinding)

    '================ إدارة الربط =================
    Public Sub ClearBindings()
        Bindings.Clear()
    End Sub

    ' يقبل أي Control (Label/LinkLabel/TextBox…)
    Public Sub Bind(targetPanel As Panel, valueControl As Control, key As String)
        If targetPanel Is Nothing OrElse valueControl Is Nothing OrElse String.IsNullOrWhiteSpace(key) Then Return
        Bindings.Add(New PriceBinding With {.Key = key.Trim(), .Panel = targetPanel, .ValueControl = valueControl})
    End Sub

    '================ هيكل المعاملات =================
    Public Structure Adjustments
        Public EX24Sell, TEX22Sell, TTEX21Sell, TEX18Sell, TEX925Sell, TEXOnceSell, TEXOnceSellUsd As Decimal
        Public TEX24BUY, TEX22BUY, TEX21BUY, TEX18BUY, TEX925BUY, TEXOnceBUY, TEXOnceBUYUsd As Decimal
    End Structure

    '================ متغيرات وخيط التحديث =================
    Private _priceLinek As String
    Private _priceCurrency As String
    Private _adj As Adjustments
    Private updateThread As Thread
    Private stopRequested As Boolean = False

    Public Sub StartAutoUpdate(PriceLinek As String, PriceCurrency As String, Optional adj As Adjustments = Nothing)
        Dim mainForm As frmMain = GetFrmMain()
        Try
            'If mainForm IsNot Nothing Then
            '    mainForm.WriteLog(">>> StartAutoUpdate - PriceLinek: '" & PriceLinek & "', PriceCurrency: '" & PriceCurrency & "'")
            'End If
        Catch
        End Try
        
        _priceLinek = PriceLinek
        _priceCurrency = PriceCurrency
        _adj = adj
        StopAutoUpdate()
        stopRequested = False

        'Try
        '    If mainForm IsNot Nothing Then
        '        mainForm.WriteLog(">>> إنشاء Thread جديد للتحديث التلقائي...")
        '    End If
        'Catch
        'End Try

        System.Diagnostics.Debug.WriteLine(">>> StartAutoUpdate - إنشاء Thread جديد...")
        updateThread = New Thread(AddressOf AutoUpdateLoop) With {.IsBackground = True}
        System.Diagnostics.Debug.WriteLine(">>> StartAutoUpdate - بدء Thread...")
        updateThread.Start()
        System.Diagnostics.Debug.WriteLine(">>> StartAutoUpdate - Thread بدأ - IsAlive: " & updateThread.IsAlive.ToString() & ", ThreadState: " & updateThread.ThreadState.ToString())

        'Try
        '    If mainForm IsNot Nothing Then
        '        mainForm.WriteLog(">>> تم بدء thread التحديث التلقائي - Thread.IsAlive: " & updateThread.IsAlive.ToString() & ", ThreadState: " & updateThread.ThreadState.ToString())
        '    End If
        'Catch
        'End Try
    End Sub

    Public Sub StopAutoUpdate()
        stopRequested = True
        If updateThread IsNot Nothing AndAlso updateThread.IsAlive Then
            updateThread.Join(1000)
        End If
        updateThread = Nothing
    End Sub

    Private Sub AutoUpdateLoop()
        ' تسجيل مباشر في Debug أولاً
        System.Diagnostics.Debug.WriteLine(">>> AutoUpdateLoop - بدء Thread")
        System.Diagnostics.Debug.WriteLine(">>> AutoUpdateLoop - PriceLinek: '" & _priceLinek & "', PriceCurrency: '" & _priceCurrency & "'")
        
        ' انتظار قليل لضمان أن frmMain جاهز
        Thread.Sleep(500)
        
        Dim mainForm As frmMain = Nothing
        Try
            mainForm = GetFrmMain()
        Catch
        End Try
        
        ' تسجيل بدء الحلقة
        Try
            If mainForm IsNot Nothing Then
                'mainForm.WriteLog(">>> بدء AutoUpdateLoop - PriceLinek: '" & _priceLinek & "', PriceCurrency: '" & _priceCurrency & "'")
                System.Diagnostics.Debug.WriteLine(">>> AutoUpdateLoop - تم العثور على frmMain")
            Else
                System.Diagnostics.Debug.WriteLine(">>> AutoUpdateLoop - frmMain غير متاح - عدد Forms: " & Application.OpenForms.Count)
                For Each frm As Form In Application.OpenForms
                    System.Diagnostics.Debug.WriteLine(">>> AutoUpdateLoop - Form: " & frm.GetType().Name)
                Next
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(">>> خطأ في تسجيل بدء AutoUpdateLoop: " & ex.Message)
        End Try
        
        ' بدء التحديث الدوري مباشرة (تم إزالة التحديث الفوري لتجنب التكرار)
        Do Until stopRequested
            Try
                ' استخدام Task.Run لتشغيل async function بدون تجميد - بدون Wait
                Task.Run(Async Function()
                             Try
                                 Await UpdateFromApiAsync(_priceLinek, _priceCurrency, _adj).ConfigureAwait(False)
                             Catch ex As Exception
                                 ' معالجة الخطأ بدون إيقاف البرنامج
                                 Try
                                     Dim mainFormErr As frmMain = GetFrmMain()
                                     'If mainFormErr IsNot Nothing Then
                                     '    mainFormErr.WriteLog("!!! خطأ في التحديث الدوري: " & ex.Message)
                                     'End If
                                 Catch
                                 End Try
                                 System.Diagnostics.Debug.WriteLine("!!! خطأ في التحديث الدوري: " & ex.Message)
                             End Try
                         End Function)
                ' لا نستخدم .Wait() - نتركه يعمل في background بدون blocking
            Catch ex As Exception
                ' معالجة الخطأ بدون إيقاف البرنامج
                Try
                    Dim mainFormErr As frmMain = GetFrmMain()
                    'If mainFormErr IsNot Nothing Then
                    '    mainFormErr.WriteLog("!!! خطأ في التحديث الدوري: " & ex.Message)
                    'End If
                Catch
                End Try
                System.Diagnostics.Debug.WriteLine("!!! خطأ في التحديث الدوري: " & ex.Message)
            End Try

            ' انتظار قبل التحديث التالي
            For i = 1 To UpdateIntervalSeconds
                If stopRequested Then Exit Do
                Thread.Sleep(1000)
            Next
        Loop
    End Sub

    '================ جلب الأسعار من الـ API =================
    Public Async Function UpdateFromApiAsync(PriceLinek As String, PriceCurrency As String, Optional adj As Adjustments = Nothing) As Threading.Tasks.Task
        System.Diagnostics.Debug.WriteLine(">>> UpdateFromApiAsync - بدء - PriceLinek: '" & PriceLinek & "', PriceCurrency: '" & PriceCurrency & "'")

        ' معالجة شاملة لجميع الأخطاء - لا نريد أن يؤثر أي خطأ على البرنامج
        'Try
        Dim mainForm As frmMain = Nothing

            ' محاولة الحصول على frmMain بشكل آمن
            Try
                mainForm = GetFrmMain()
            Catch ex As Exception
                ' تجاهل أي خطأ في الحصول على frmMain
                System.Diagnostics.Debug.WriteLine(">>> UpdateFromApiAsync - خطأ في GetFrmMain: " & ex.Message)
            End Try

            ' تسجيل بدء الدالة بشكل آمن
            'Try
            '    If mainForm IsNot Nothing Then
            '        mainForm.WriteLog(">>> UpdateFromApiAsync - بدء - PriceLinek: '" & PriceLinek & "', PriceCurrency: '" & PriceCurrency & "'")
            '    Else
            '        System.Diagnostics.Debug.WriteLine(">>> UpdateFromApiAsync - frmMain غير متاح")
            '    End If
            'Catch ex As Exception
            '    ' تجاهل أي خطأ في التسجيل (قد يكون SqlException هنا)
            '    System.Diagnostics.Debug.WriteLine(">>> UpdateFromApiAsync - خطأ في التسجيل: " & ex.Message)
            'End Try

            ' التحقق من صحة PriceLinek
            'If String.IsNullOrWhiteSpace(PriceLinek) Then
            '    Try
            '        If mainForm IsNot Nothing Then
            '            mainForm.WriteLog("!!! PriceLinek فارغة في UpdateFromApiAsync")
            '        End If
            '    Catch
            '        ' تجاهل أي خطأ
            '    End Try
            '    Return
            'End If

            Dim url As String = PriceLinek.TrimEnd("/"c)
            ' التحقق من نوع API - sabprice.live لا يقبل Currency في URL
            Dim isSabPriceApi As Boolean = url.Contains("sabprice.live")

            If Not String.IsNullOrEmpty(PriceCurrency) AndAlso Not isSabPriceApi Then
                ' إضافة Currency فقط إذا لم يكن API من sabprice.live
                url = url & "/" & PriceCurrency.Trim()
            End If

            ' جلب البيانات من API مع معالجة الأخطاء
            Dim json As String = ""
            Try
                Try
                    'If mainForm IsNot Nothing Then
                    '    mainForm.WriteLog(">>> جلب الأسعار من: " & url)
                    '    If isSabPriceApi Then
                    '        mainForm.WriteLog(">>> API من sabprice.live - لا يتم إضافة Currency إلى URL")
                    '    End If
                    'End If
                Catch
                End Try

                ' استخدام HttpClient مع timeout
                Using httpClient As New HttpClient()
                    httpClient.Timeout = TimeSpan.FromSeconds(10) ' timeout 10 ثواني
                    ' استخدام ConfigureAwait(False) لتجنب العودة إلى UI Thread
                    json = Await httpClient.GetStringAsync(url).ConfigureAwait(False)
                End Using

                'Try
                '    If mainForm IsNot Nothing Then
                '        mainForm.WriteLog(">>> تم جلب JSON من API - الطول: " & json.Length & " حرف")
                '        mainForm.WriteLog(">>> محتوى JSON: " & json)
                '    End If
                'Catch
                'End Try
            Catch ex As Exception
                ' تسجيل خطأ الاتصال بالـ API
                'Try
                '    If mainForm IsNot Nothing Then
                '        mainForm.WriteLog("!!! خطأ في جلب البيانات من API: " & ex.Message)
                '    End If
                'Catch
                'End Try
                System.Diagnostics.Debug.WriteLine("!!! خطأ في جلب البيانات من API: " & ex.Message)
                Return ' الخروج من الدالة بدون إيقاف البرنامج
            End Try
            
            ' تحليل JSON مع معالجة الأخطاء
            Dim obj As JObject = Nothing
            Try
                obj = JObject.Parse(json)
            Catch ex As Exception
                'Try
                '    If mainForm IsNot Nothing Then
                '        mainForm.WriteLog("!!! خطأ في تحليل JSON: " & ex.Message)
                '    End If
                'Catch
                'End Try
                System.Diagnostics.Debug.WriteLine("!!! خطأ في تحليل JSON: " & ex.Message)
                Return ' الخروج من الدالة بدون إيقاف البرنامج
            End Try
            
            If obj Is Nothing Then
                Return
            End If

            'Try
            '    If mainForm IsNot Nothing Then
            '        mainForm.WriteLog(">>> تم تحليل JSON بنجاح")
            '    End If
            'Catch
            'End Try

            ' تحديد نوع الـ API بناءً على المفاتيح الموجودة
            Dim gold24 As Decimal, gold22 As Decimal, gold21 As Decimal, gold18 As Decimal
            Dim gold24sell As Decimal, gold22sell As Decimal, gold21sell As Decimal, gold18sell As Decimal
            Dim ounceBuy As Decimal, ounceSell As Decimal
            Dim silverKg As Decimal, silverKgsell As Decimal
            
            Dim isNewApi As Boolean = obj("gold24") IsNot Nothing

            'Try
            '    If mainForm IsNot Nothing Then
            '        mainForm.WriteLog(">>> نوع API: " & If(isNewApi, "saponlin.net (جديد)", "sabprice.live (أصلي)"))
            '    End If
            'Catch
            'End Try

            If isNewApi Then
                ' API الجديد (saponlin.net/kw/public/api/feed)
                gold24 = SafeVal(obj("gold24"))
                gold22 = SafeVal(obj("gold22"))
                gold21 = SafeVal(obj("gold21"))
                gold18 = SafeVal(obj("gold18"))
                ounceBuy = SafeVal(obj("goldOunce"))
                silverKg = SafeVal(obj("silverKg"))
                
                ' نفس القيم للبيع والشراء في API الجديد
                gold24sell = gold24
                gold22sell = gold22
                gold21sell = gold21
                gold18sell = gold18
                ounceSell = SafeVal(obj("goldOunceDollar"))
                silverKgsell = silverKg

                'Try
                '    If mainForm IsNot Nothing Then
                '        Dim goldOunceRaw As String = If(obj("goldOunce") IsNot Nothing, obj("goldOunce").ToString(), "Nothing")
                '        Dim goldOunceDollarRaw As String = If(obj("goldOunceDollar") IsNot Nothing, obj("goldOunceDollar").ToString(), "Nothing")
                '        'mainForm.WriteLog(String.Format(">>> API جديد - gold24: {0}, gold22: {1}, gold21: {2}, gold18: {3}, silverKg: {4}", 
                '        'gold24, gold22, gold21, gold18, silverKg))
                '        'mainForm.WriteLog(String.Format(">>> API جديد - goldOunce (raw): '{0}', goldOunceDollar (raw): '{1}'",
                '        'goldOunceRaw, goldOunceDollarRaw))
                '        'mainForm.WriteLog(String.Format(">>> API جديد - ounceBuy (parsed): {0}, ounceSell (parsed): {1}", 
                '        ounceBuy, ounceSell))
                '    End If
                'Catch
                'End Try
            Else
                ' API الأصلي (sabprice.live)
                gold24 = SafeVal(obj("24K_buy"))
                gold22 = SafeVal(obj("22K_buy"))
                gold21 = SafeVal(obj("21K_buy"))
                gold18 = SafeVal(obj("18K_buy"))
                ' استخراج OZK_buy و OZK_sell مع تسجيل مفصل
                Dim ozkBuyToken = obj("OZK_buy")
                Dim ozkSellToken = obj("OZK_sell")
                ounceBuy = SafeVal(ozkBuyToken)
                ounceSell = SafeVal(ozkSellToken)
                
                silverKg = SafeVal(obj("S999K_buy"))
                
                gold24sell = SafeVal(obj("24K_sell"))
                gold22sell = SafeVal(obj("22K_sell"))
                gold21sell = SafeVal(obj("21K_sell"))
                gold18sell = SafeVal(obj("18K_sell"))
                silverKgsell = SafeVal(obj("S999K_sell"))

            '    Try
            '        If mainForm IsNot Nothing Then
            '            mainForm.WriteLog(String.Format(">>> API أصلي - 24K_buy: {0}, 24K_sell: {1}, 22K_buy: {2}, 22K_sell: {3}", 
            '                gold24, gold24sell, gold22, gold22sell))
            '            mainForm.WriteLog(String.Format(">>> API أصلي - OZK_buy (raw): '{0}', OZK_sell (raw): '{1}'", 
            '                If(obj("OZK_buy") IsNot Nothing, obj("OZK_buy").ToString(), "Nothing"), 
            '                If(obj("OZK_sell") IsNot Nothing, obj("OZK_sell").ToString(), "Nothing")))
            '            mainForm.WriteLog(String.Format(">>> API أصلي - ounceBuy (parsed): {0}, ounceSell (parsed): {1}", 
            '                ounceBuy, ounceSell))
            '        End If
            '    Catch
            '    End Try
        End If

        ' البيع - استخدام gold24sell (سعر البيع) للبيع
        Dim v24_sell As Decimal = gold24sell + adj.EX24Sell
        Dim v22_sell As Decimal = gold22sell + adj.TEX22Sell
            Dim v21_sell As Decimal = gold21sell + adj.TTEX21Sell
            Dim v18_sell As Decimal = gold18sell + adj.TEX18Sell
            Dim vounceSell_sell As Decimal = ounceSell + adj.TEXOnceSellUsd

            Dim v925_sell As Decimal = (silverKgsell * 10D / 100D) + adj.TEX925Sell
            Dim vOunce_sell As Decimal = (gold24sell * 31.1D) + adj.TEXOnceSell

            ' الشراء - استخدام gold24 (سعر الشراء) للشراء
            Dim v24_buy As Decimal = gold24 + adj.TEX24BUY
            Dim v22_buy As Decimal = gold22 + adj.TEX22BUY
            Dim v21_buy As Decimal = gold21 + adj.TEX21BUY
            Dim v18_buy As Decimal = gold18 + adj.TEX18BUY
            Dim ounceSell_buy As Decimal = ounceBuy + adj.TEXOnceBUYUsd

            Dim v925_buy As Decimal = (silverKg * 10D / 100D) + adj.TEX925BUY
            Dim vOunce_buy As Decimal = (gold24 * 31.1D) + adj.TEXOnceBUY

                'Try
                '    If mainForm IsNot Nothing Then
                '        mainForm.WriteLog(String.Format(">>> القيم المحسوبة - v24_sell: {0}, v24_buy: {1}, v22_sell: {2}, v22_buy: {3}", 
                '            v24_sell, v24_buy, v22_sell, v22_buy))
                '        mainForm.WriteLog(String.Format(">>> التعديلات - EX24Sell: {0}, TEX24BUY: {1}", adj.EX24Sell, adj.TEX24BUY))
                '        mainForm.WriteLog(String.Format(">>> OZK من API - ounceBuy: {0}, ounceSell: {1}", ounceBuy, ounceSell))
                '        mainForm.WriteLog(String.Format(">>> OZK التعديلات - adj.TEXOnceBUYUsd: {0}, adj.TEXOnceSellUsd: {1}", 
                '            adj.TEXOnceBUYUsd, adj.TEXOnceSellUsd))
                '        mainForm.WriteLog(String.Format(">>> OZK المحسوبة النهائية - OZK_buy: {0} (ounceBuy {1} + adj {2} = {3}), OZK_sell: {4} (ounceSell {5} + adj {6} = {7})", 
                '            ounceSell_buy, ounceBuy, adj.TEXOnceBUYUsd, (ounceBuy + adj.TEXOnceBUYUsd), 
                '            vounceSell_sell, ounceSell, adj.TEXOnceSellUsd, (ounceSell + adj.TEXOnceSellUsd)))
                '    End If
                'Catch
                'End Try

                ' تحديث كل Binding
                '    Try
                '    If mainForm IsNot Nothing Then
                '        mainForm.WriteLog(">>> عدد Bindings: " & Bindings.Count)
                '    End If
                'Catch
                'End Try

                Dim updatedCount As Integer = 0
            For Each b In Bindings.ToArray()
                Try
                    Dim valueToSet As Decimal = 0
                    Dim keyFound As Boolean = True
                    
                    Select Case b.Key.ToLowerInvariant()
                        Case "24_sell" : valueToSet = v24_sell
                        Case "22_sell" : valueToSet = v22_sell
                        Case "21_sell" : valueToSet = v21_sell
                        Case "18_sell" : valueToSet = v18_sell
                        Case "silver925_sell" : valueToSet = v925_sell
                        Case "ounce_sell" : valueToSet = vOunce_sell
                        Case "OZK_sell" : valueToSet = vounceSell_sell

                        Case "24_buy" : valueToSet = v24_buy
                        Case "22_buy" : valueToSet = v22_buy
                        Case "21_buy" : valueToSet = v21_buy
                        Case "18_buy" : valueToSet = v18_buy
                        Case "silver925_buy" : valueToSet = v925_buy
                        Case "ounce_buy" : valueToSet = vOunce_buy
                        Case "OZK_buy" : valueToSet = ounceSell_buy
                        Case Else
                            keyFound = False
                    End Select
                    
                    If keyFound Then
                            'Try
                            '    If mainForm IsNot Nothing Then
                            '        Dim controlName As String = If(b.ValueControl IsNot Nothing, b.ValueControl.Name, "Nothing")
                            '            ط  mainForm.WriteLog(String.Format(">>> تحديث Binding - Key: {0}, Value: {1}, Panel: {2}, Control: {3}",
                            '            b.Key, valueToSet, If(b.Panel IsNot Nothing, b.Panel.Name, "Nothing"), controlName))
                            '        ' تسجيل خاص لـ OZK
                            '            If b.Key.ToLowerInvariant() = "OZK_buy" OrElse b.Key.ToLowerInvariant() = "OZK_sell" Then
                            '            mainForm.WriteLog(String.Format(">>> *** OZK Binding - Key: {0}, Value: {1}, Control: {2}", 
                            '                b.Key, valueToSet, controlName))
                            '        End If
                            '    End If
                            'Catch
                            'End Try
                            SetValueWithPanelBlink(b.Panel, b.ValueControl, b.Key, valueToSet)
                        updatedCount += 1
                    Else
                            'Try
                            '    If mainForm IsNot Nothing Then
                            '        mainForm.WriteLog("!!! مفتاح غير معروف: " & b.Key)
                            '    End If
                            'Catch
                            'End Try
                        End If
                Catch ex As Exception
                        ' معالجة خطأ في Binding واحد بدون إيقاف باقي Bindings
                        'Try
                        '    If mainForm IsNot Nothing Then
                        '        mainForm.WriteLog("!!! خطأ في Binding - Key: " & b.Key & ", Error: " & ex.Message)
                        '    End If
                        'Catch
                        'End Try
                        System.Diagnostics.Debug.WriteLine("!!! خطأ في Binding - Key: " & b.Key & ", Error: " & ex.Message)
                End Try
            Next

        'Try
        '    If mainForm IsNot Nothing Then
        '        mainForm.WriteLog(String.Format(">>> تم تحديث {0} من {1} عنصر", updatedCount, Bindings.Count))
        '    End If
        'Catch
        'End Try

        'Catch ex As Exception
        ' معالجة شاملة لجميع الأخطاء - لا نريد أن يؤثر أي خطأ على البرنامج
        'Try
        Dim mainFormErr As frmMain = Nothing
                Try
                    mainFormErr = GetFrmMain()
                Catch
                    ' تجاهل خطأ GetFrmMain
                End Try

        '    If mainFormErr IsNot Nothing Then
        '        Try
        '        'mainFormErr.WriteLog("!!! خطأ في UpdateFromApiAsync: " & ex.Message)
        '    Catch
        '            ' تجاهل أي خطأ في التسجيل (قد يكون SqlException)
        '        End Try
        '    End If
        'Catch
        '    ' تجاهل جميع الأخطاء
        'End Try

        'System.Diagnostics.Debug.WriteLine("!!! خطأ عام في UpdateFromApiAsync: " & ex.Message & vbCrLf & ex.StackTrace)
        ' لا نرمي الخطأ - نكتفي بالتسجيل
        'End Try
    End Function

    '================ وميض الألواح =================
    Private Sub SetValueWithPanelBlink(targetPanel As Panel, valueCtrl As Control, key As String, newVal As Decimal)
        Dim mainForm As frmMain = GetFrmMain()

        'If targetPanel Is Nothing OrElse targetPanel.IsDisposed OrElse valueCtrl Is Nothing OrElse valueCtrl.IsDisposed Then
        '    Try
        '        If mainForm IsNot Nothing Then
        '            mainForm.WriteLog("!!! SetValueWithPanelBlink - Control أو Panel غير متاح - Key: " & key)
        '        End If
        '    Catch
        '    End Try
        '    Return
        'End If

        Dim dir As Integer = 0
        Dim oldVal As Decimal = 0
        If LastVals.ContainsKey(key) Then
            oldVal = LastVals(key)
            If newVal > oldVal + ChangeEpsilon Then
                dir = 1
            ElseIf newVal < oldVal - ChangeEpsilon Then
                dir = -1
            End If
        End If
        LastVals(key) = newVal

        ' تعيين النص على أي Control يدعم .Text (Label/LinkLabel/TextBox/...)
        Dim valueStr As String = newVal.ToString(NumberFormat, CultureInfo.InvariantCulture)
        'Try
        '    If mainForm IsNot Nothing Then
        '        mainForm.WriteLog(String.Format(">>> SetValueWithPanelBlink - Key: {0}, OldValue: {1}, NewValue: {2}, ValueStr: '{3}', Control: {4}", 
        '            key, If(LastVals.ContainsKey(key), oldVal.ToString(), "N/A"), newVal, valueStr, If(valueCtrl IsNot Nothing, valueCtrl.Name, "Nothing")))
        '        ' تسجيل خاص لـ OZK
        '        If key.ToLowerInvariant() = "OZK_buy" OrElse key.ToLowerInvariant() = "OZK_sell" Then
        '            mainForm.WriteLog(String.Format(">>> *** SetValueWithPanelBlink OZK - Key: {0}, NewValue: {1}, ValueStr: '{2}', Control: {3}", 
        '                key, newVal, valueStr, If(valueCtrl IsNot Nothing, valueCtrl.Name, "Nothing")))
        '        End If
        '    End If
        'Catch
        'End Try

        SafeUI(valueCtrl, Sub() 
                              Dim oldText As String = valueCtrl.Text
                              valueCtrl.Text = valueStr
                              Try
                                  mainForm = GetFrmMain()
                                  If mainForm IsNot Nothing Then
                                      'mainForm.WriteLog(String.Format(">>> تم تعيين Text للـ Control '{0}' من '{1}' إلى '{2}'", valueCtrl.Name, oldText, valueStr))
                                      ' تسجيل خاص لـ OZK
                                      If key.ToLowerInvariant() = "OZK_buy" OrElse key.ToLowerInvariant() = "OZK_sell" Then
                                          'mainForm.WriteLog(String.Format(">>> *** تم تحديث OZK Control '{0}' - OldText: '{1}', NewText: '{2}', NewValue: {3}", 
                                          'valueCtrl.Name, oldText, valueStr, newVal))
                                      End If
                                  End If
                              Catch
                              End Try
                          End Sub)

        If dir <> 0 Then
            Dim color = If(dir = 1, BlinkUpColor, BlinkDownColor)
            BlinkPanelAsync(targetPanel, color)
        End If
    End Sub

    Private Async Function BlinkPanelAsync(pnl As Panel, flashColor As Color) As Threading.Tasks.Task
        If pnl Is Nothing OrElse pnl.IsDisposed Then Return
        Dim origBack As Color = Color.Empty
        Dim originalFore As New Dictionary(Of Control, Color)

        ' احفظ الخلفية ولون النص لكل العناصر النصية داخل البانل
        SafeUI(pnl, Sub()
                        origBack = pnl.BackColor
                        For Each c As Control In pnl.Controls
                            ' سنعتبر أي كنترول له Text مرشّحًا لتغيير اللون
                            If Not String.IsNullOrEmpty(c.Text) Then
                                originalFore(c) = c.ForeColor
                            End If
                        Next
                    End Sub)

        For i = 1 To BlinkCycles
            SafeUI(pnl, Sub()
                            pnl.BackColor = flashColor
                            For Each kv In originalFore
                                kv.Key.ForeColor = Color.White
                            Next
                        End Sub)
            Await Threading.Tasks.Task.Delay(BlinkOnMs)

            SafeUI(pnl, Sub()
                            pnl.BackColor = origBack
                            For Each kv In originalFore
                                kv.Key.ForeColor = kv.Value
                            Next
                        End Sub)
            Await Threading.Tasks.Task.Delay(BlinkOffMs)
        Next
    End Function

    '================ أدوات مساعدة =================
    Private Function SafeVal(tokenOrText As Object) As Decimal
        If tokenOrText Is Nothing Then Return 0D
        ' إزالة رموز العملات والفواصل
        Dim originalText As String = tokenOrText.ToString()
        ' إزالة جميع رموز العملات والمسافات أولاً
        Dim s As String = originalText.Trim() _
            .Replace(" ", "") _
            .Replace("٬", "") _
            .Replace(",", ".") _
            .Replace("$", "") _
            .Replace("€", "") _
            .Replace("£", "") _
            .Replace("¥", "") _
            .Replace("د.ك", "") _
            .Replace("KWD", "") _
            .Replace("USD", "") _
            .Replace("دولار", "") _
            .Replace("دولار أمريكي", "") _
            .Trim()
        
        ' تسجيل القيم المهمة (OZK) قبل التحليل
        Dim shouldLog As Boolean = originalText.Contains("OZK") OrElse originalText.Contains("4299") OrElse originalText.Contains("goldOunce") OrElse originalText.Contains("$")
        
        Dim v As Decimal
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, v) Then
            ' تسجيل القيم المهمة (OZK)
            If shouldLog Then
                Try
                    Dim mainForm As frmMain = GetFrmMain()
                    If mainForm IsNot Nothing Then
                        'mainForm.WriteLog(String.Format(">>> SafeVal - Original: '{0}', Cleaned: '{1}', Parsed: {2}", originalText, s, v))
                    End If
                Catch
                End Try
            End If
            Return v
        End If
        ' تسجيل في حالة الفشل
        Try
            Dim mainForm As frmMain = GetFrmMain()
            If mainForm IsNot Nothing Then
                'mainForm.WriteLog(String.Format("!!! SafeVal - فشل في تحليل: '{0}' -> '{1}'", originalText, s))
                If shouldLog Then
                    'mainForm.WriteLog(String.Format("!!! SafeVal - تفاصيل الفشل - Original: '{0}', Cleaned: '{1}', Length: {2}", 
                    'originalText, s, s.Length))
                End If
            End If
        Catch
        End Try
        Return 0D
    End Function

    Private Sub SafeUI(ctrl As Control, action As Action)
        If ctrl Is Nothing OrElse ctrl.IsDisposed Then Return
        If ctrl.InvokeRequired Then
            Try : ctrl.BeginInvoke(action) : Catch : End Try
        Else
            action()
        End If
    End Sub
End Module
