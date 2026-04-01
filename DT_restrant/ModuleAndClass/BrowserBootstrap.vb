'====================  BrowserBootstrap.vb  ====================
'Imports System.Windows.Forms
'Imports System.Threading.Tasks
'Imports Microsoft.Web.WebView2.WinForms
'Imports Microsoft.Web.WebView2.Core
'Imports System.Drawing

'Module BrowserBootstrap

'    ' حالة مبسّطة لكل مضيف
'    Private Class HostState
'        Public Host As Form
'        Public Wv As WebView2
'        Public HomeUrl As String
'    End Class

'    Private Function NormalizeUrl(url As String) As String
'        If String.IsNullOrWhiteSpace(url) Then Return "about:blank"
'        If Not url.Contains("://") Then url = "https://" & url
'        Return url
'    End Function

'    '==================== التهيئة (نفس الاسم القديم) ====================
'    ''' <summary>
'    ''' يهيّئ WebView2 داخل الفورم بدون أي عناصر واجهة إضافية.
'    ''' لا يستخدم WebBrowser، ولا أزرار، ولا شريط عنوان.
'    ''' التحكم في الوضع عبر Dock أو Bounds (viewX, viewY, viewW, viewH).
'    ''' معاملات maxRetries و delayMs موجودة فقط للتوافق ويتم تجاهلها.
'    ''' </summary>
'    Public Async Function InitSmartBrowserAsync(host As Form,
'                                                webViewLinek As WebView2,
'                                                Optional initialUrl As String = "https://www.sabprice.live/s",
'                                                Optional maxRetries As Integer = -1,   ' متروك للتوافق فقط
'                                                Optional delayMs As Integer = 2000,    ' متروك للتوافق فقط
'                                                Optional viewX As Integer = 0,
'                                                Optional viewY As Integer = 0,
'                                                Optional viewW As Integer = 0,
'                                                Optional viewH As Integer = 0) As Task
'        If host Is Nothing Then Throw New ArgumentNullException(NameOf(host))
'        If webViewLinek Is Nothing Then Throw New ArgumentNullException(NameOf(webViewLinek))

'        Dim S As New HostState With {
'            .Host = host,
'            .Wv = webViewLinek,
'            .HomeUrl = NormalizeUrl(initialUrl)
'        }

'        ' وضع WebView2 داخل المضيف
'        With webViewLinek
'            .Visible = True
'            .Tag = S

'            If viewW <= 0 OrElse viewH <= 0 Then
'                ' إن لم تُمرر أبعاد: املأ المضيف
'                .Dock = DockStyle.Fill
'            Else
'                .Dock = DockStyle.None
'                .Location = New Point(viewX, viewY)
'                .Size = New Size(viewW, viewH)
'                .Anchor = AnchorStyles.Top Or AnchorStyles.Left
'            End If

'            If .Parent Is Nothing OrElse Not Object.ReferenceEquals(.Parent, host) Then
'                host.Controls.Add(webViewLinek)
'            End If
'            .BringToFront()
'        End With

'        ' تهيئة WebView2
'        Await webViewLinek.EnsureCoreWebView2Async(Nothing)
'        If webViewLinek.CoreWebView2 Is Nothing Then Throw New Exception("CoreWebView2 غير متاح.")

'        ' إعدادات مناسبة
'        webViewLinek.CoreWebView2.Settings.IsStatusBarEnabled = True
'        webViewLinek.CoreWebView2.Settings.IsZoomControlEnabled = True

'        ' تنقّل أولي
'        webViewLinek.Source = New Uri(S.HomeUrl)
'    End Function

'    '==================== واجهة برمجية للتحكم ====================

'    ''' <summary>تنقّل لعنوان معيّن.</summary>
'    Public Sub Navigate(host As Form, url As String)
'        Dim S = FindState(host)
'        If S Is Nothing OrElse S.Wv Is Nothing Then Exit Sub
'        Dim u = NormalizeUrl(url)
'        S.HomeUrl = u
'        Try
'            S.Wv.Source = New Uri(u)
'        Catch
'            ' تجاهل أي خطأ تنقّل فوري
'        End Try
'    End Sub

'    ''' <summary>تحديث/إعادة تحميل الصفحة الحالية.</summary>
'    Public Sub Reload(host As Form)
'        Dim S = FindState(host)
'        If S?.Wv Is Nothing Then Exit Sub
'        S.Wv.Reload()
'    End Sub

'    ''' <summary>رجوع للأمام/للخلف إن أمكن (بدون أزرار واجهة).</summary>
'    Public Sub GoBack(host As Form)
'        Dim S = FindState(host)
'        If S?.Wv?.CoreWebView2 Is Nothing Then Exit Sub
'        If S.Wv.CoreWebView2.CanGoBack Then S.Wv.CoreWebView2.GoBack()
'    End Sub

'    Public Sub GoForward(host As Form)
'        Dim S = FindState(host)
'        If S?.Wv?.CoreWebView2 Is Nothing Then Exit Sub
'        If S.Wv.CoreWebView2.CanGoForward Then S.Wv.CoreWebView2.GoForward()
'    End Sub

'    ''' <summary>تغيير الوضع إلى Dock ديناميكيًا.</summary>
'    Public Sub SetDock(host As Form, dock As DockStyle)
'        Dim S = FindState(host)
'        If S?.Wv Is Nothing Then Exit Sub
'        With S.Wv
'            .Dock = dock
'            If dock <> DockStyle.None Then
'                .Anchor = AnchorStyles.Top Or AnchorStyles.Left
'            End If
'        End With
'    End Sub

'    ''' <summary>تحديد الموضع والحجم يدويًا مع Anchor (عند الحاجة).</summary>
'    Public Sub SetBounds(host As Form, x As Integer, y As Integer, w As Integer, h As Integer, Optional anchor As AnchorStyles = AnchorStyles.Top Or AnchorStyles.Left)
'        Dim S = FindState(host)
'        If S?.Wv Is Nothing Then Exit Sub
'        With S.Wv
'            .Dock = DockStyle.None
'            .Location = New Point(x, y)
'            .Size = New Size(Math.Max(0, w), Math.Max(0, h))
'            .Anchor = anchor
'        End With
'    End Sub

'    '==================== تنظيف ====================
'    Public Sub ShutdownSmartBrowser(host As Form,
'                                    Optional closeForm As Boolean = True,
'                                    Optional closeApp As Boolean = False)
'        Dim S = FindState(host)

'        Try
'            If S IsNot Nothing AndAlso S.Wv IsNot Nothing Then
'                Try
'                    If S.Wv.CoreWebView2 IsNot Nothing Then
'                        S.Wv.CoreWebView2.Navigate("about:blank")
'                    End If
'                Catch
'                End Try
'                'S.Swv?.Dispose()
'                S.Wv = Nothing
'            End If
'        Catch
'        End Try

'        If closeApp Then
'            Application.Exit()
'        ElseIf closeForm AndAlso host IsNot Nothing Then
'            host.Close()
'        End If
'    End Sub

'    '==================== مساعد داخلي ====================
'    Private Function FindState(root As Control) As HostState
'        If root Is Nothing Then Return Nothing
'        Dim st = TryCast(root.Tag, HostState)
'        If st IsNot Nothing Then Return st
'        For Each c As Control In root.Controls
'            Dim s2 = TryCast(c.Tag, HostState)
'            If s2 IsNot Nothing Then Return s2
'        Next
'        Return Nothing
'    End Function

'End Module
''==================  /BrowserBootstrap.vb  ====================
