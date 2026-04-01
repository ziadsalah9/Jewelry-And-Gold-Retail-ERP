Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Windows.Forms


Module Button3DStyler


    '========================
    ' حالة لكل زر
    '========================
    Private Class VisualState
        Public Hover As Boolean
        Public Pressed As Boolean
        Public Radius As Integer
        Public Fore As Color

        ' لوحة الذهب
        Public UsePalette As Boolean
        Public PaletteTop As Color
        Public PaletteMid As Color
        Public PaletteBottom As Color
        Public PaletteBorder As Color

        ' أنيميشن
        Public ShinePos As Double    ' 0..1
        Public GlowPhase As Double   ' راديان (0..2π)
    End Class

    Private ReadOnly States As New Dictionary(Of Button, VisualState)

    ' مؤقّت عام للأنيميشن (UI Thread)
    Private ReadOnly AnimTimer As New Timer() With {.Interval = 30} ' ~33fps
    Private AnimTimerHooked As Boolean = False

    '========================
    ' تطبيق عام (أساس)
    '========================
    Public Sub Apply(btn As Button,
                     Optional baseColor As Color = Nothing,
                     Optional foreColor As Color = Nothing,
                     Optional radius As Integer = 10)

        If baseColor.IsEmpty Then baseColor = Color.FromArgb(0, 122, 204)
        If foreColor.IsEmpty Then foreColor = Color.White

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.UseVisualStyleBackColor = False

        ' شفافية تمنع أي سواد حول الزر
        btn.BackColor = Color.Transparent
        btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn.FlatAppearance.MouseDownBackColor = Color.Transparent

        btn.ForeColor = foreColor
        EnableDoubleBuffering(btn)

        Dim st As New VisualState With {
            .Hover = False,
            .Pressed = False,
            .Radius = Math.Max(0, radius),
            .Fore = foreColor,
            .UsePalette = False,
            .PaletteTop = Lighten(baseColor, 0.18),
            .PaletteMid = baseColor,
            .PaletteBottom = Lighten(baseColor, 0.02),
            .PaletteBorder = Blend(baseColor, Color.White, 0.25),
            .ShinePos = -0.2,
            .GlowPhase = 0.0
        }

        States(btn) = st

        AddHandler btn.Paint, AddressOf OnButtonPaint
        AddHandler btn.MouseEnter, AddressOf OnMouseEnter
        AddHandler btn.MouseLeave, AddressOf OnMouseLeave
        AddHandler btn.MouseDown, AddressOf OnMouseDown
        AddHandler btn.MouseUp, AddressOf OnMouseUp
        AddHandler btn.Resize, AddressOf OnResize
        AddHandler btn.Disposed, AddressOf OnButtonDisposed

        ' قصّ الزر على شكل pill
        UpdateRoundedRegion(btn, st.Radius)

        ' فعّل مؤقت الأنيميشن مرة واحدة
        EnsureAnimTimer()

        btn.Invalidate()
    End Sub

    '========================
    ' نمط ذهبي مطابق للعينة
    '========================
    Public Sub ApplyGold(btn As Button,
                         Optional radius As Integer = -1,
                         Optional fore As Color = Nothing)

        If fore.IsEmpty Then fore = Color.Black
        If radius < 0 Then radius = Math.Max(12, btn.Height \ 2) ' pill

        Apply(btn, baseColor:=Color.FromArgb(224, 184, 74), foreColor:=fore, radius:=radius)

        Dim st = States(btn)
        st.UsePalette = True
        st.PaletteTop = ColorTranslator.FromHtml("#F7E08A")
        st.PaletteMid = ColorTranslator.FromHtml("#E0B84A")
        st.PaletteBottom = ColorTranslator.FromHtml("#AD8217")
        st.PaletteBorder = ColorTranslator.FromHtml("#8C6A10")
        st.ShinePos = -0.2
        st.GlowPhase = 0.0

        btn.Font = New Font(btn.Font, FontStyle.Bold)
        UpdateRoundedRegion(btn, st.Radius)
        btn.Invalidate()
    End Sub

    Public Sub ApplyGoldToAll(container As Control)
        For Each c As Control In container.Controls
            If TypeOf c Is Button Then ApplyGold(DirectCast(c, Button))
            If c.HasChildren Then ApplyGoldToAll(c)
        Next
    End Sub

    ' إلغاء التطبيق (اختياري)
    Public Sub Unapply(btn As Button)
        If btn Is Nothing OrElse btn.IsDisposed Then Return
        OnButtonDisposed(btn, EventArgs.Empty)
        btn.Invalidate()
    End Sub

    '========================
    ' Events
    '========================
    Private Sub OnMouseEnter(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim st = States(btn)
        st.Hover = True
        st.ShinePos = -0.2
        StartAnim()
        btn.Invalidate()
    End Sub

    Private Sub OnMouseLeave(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim st = States(btn)
        st.Hover = False
        btn.Invalidate()
    End Sub

    Private Sub OnMouseDown(sender As Object, e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then Return
        Dim btn = DirectCast(sender, Button)
        Dim st = States(btn) : st.Pressed = True
        btn.Invalidate()
    End Sub

    Private Sub OnMouseUp(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim st = States(btn) : st.Pressed = False
        btn.Invalidate()
    End Sub

    Private Sub OnResize(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim st = States(btn)
        UpdateRoundedRegion(btn, st.Radius)
        btn.Invalidate()
    End Sub

    Private Sub OnButtonDisposed(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        RemoveHandler btn.Paint, AddressOf OnButtonPaint
        RemoveHandler btn.MouseEnter, AddressOf OnMouseEnter
        RemoveHandler btn.MouseLeave, AddressOf OnMouseLeave
        RemoveHandler btn.MouseDown, AddressOf OnMouseDown
        RemoveHandler btn.MouseUp, AddressOf OnMouseUp
        RemoveHandler btn.Resize, AddressOf OnResize
        RemoveHandler btn.Disposed, AddressOf OnButtonDisposed
        If States.ContainsKey(btn) Then States.Remove(btn)
    End Sub

    '========================
    ' الرسم المخصّص
    '========================
    Private Sub OnButtonPaint(sender As Object, e As PaintEventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim st As VisualState = Nothing
        If Not States.TryGetValue(btn, st) Then Return

        ' امسح الخلفية بلون الحاوي
        g.Clear(If(btn.Parent IsNot Nothing, btn.Parent.BackColor, SystemColors.Control))

        Dim rect = Rectangle.Inflate(btn.ClientRectangle, -1, -1)
        Dim path = RoundedRect(rect, st.Radius)

        '==== الخلفية الذهبية ====
        Dim topColor As Color, midColor As Color, bottomColor As Color

        If st.UsePalette Then
            topColor = st.PaletteTop
            midColor = st.PaletteMid
            bottomColor = st.PaletteBottom

            ' Hover: تفتيح ناعم
            If st.Hover Then
                topColor = Blend(topColor, Color.White, 0.08)
                midColor = Blend(midColor, Color.White, 0.06)
                bottomColor = Blend(bottomColor, Color.White, 0.04)
            End If
            ' Pressed: تغميق خفيف
            If st.Pressed Then
                topColor = Darken(topColor, 0.07)
                midColor = Darken(midColor, 0.07)
                bottomColor = Darken(bottomColor, 0.07)
            End If

            Using br As New LinearGradientBrush(rect, topColor, bottomColor, LinearGradientMode.Vertical)
                Dim cb As New ColorBlend() With {
                    .Positions = New Single() {0.0F, 0.5F, 1.0F},
                    .Colors = New Color() {topColor, midColor, bottomColor}
                }
                br.InterpolationColors = cb
                g.FillPath(br, path)
            End Using

            ' إطار ذهبي فاتح (ثابت)
            Using penBorder As New Pen(Blend(midColor, Color.White, 0.35), 1)
                penBorder.Alignment = PenAlignment.Inset
                g.DrawPath(penBorder, path)
            End Using

        Else
            Using br As New LinearGradientBrush(rect, Lighten(st.PaletteMid, 0.18), Lighten(st.PaletteMid, 0.02), LinearGradientMode.Vertical)
                g.FillPath(br, path)
            End Using
            Using penBorder As New Pen(Blend(st.PaletteMid, Color.White, 0.25), 1)
                penBorder.Alignment = PenAlignment.Inset
                g.DrawPath(penBorder, path)
            End Using
        End If

        '==== لمعان علوي نصف الزر ====
        Dim innerRect = Rectangle.Inflate(rect, -2, -2)
        Dim highlightRect = New Rectangle(innerRect.X, innerRect.Y, innerRect.Width, CInt(innerRect.Height / 2.0))
        Using pathHigh = RoundedRect(highlightRect, Math.Max(0, st.Radius - 2))
            Using brHigh As New LinearGradientBrush(highlightRect,
                                                    Color.FromArgb(110, Color.White),
                                                    Color.FromArgb(0, Color.White),
                                                    LinearGradientMode.Vertical)
                g.FillPath(brHigh, pathHigh)
            End Using
        End Using

        '==== لمعة متحركة (Shine) عند Hover ====
        If st.Hover Then
            DrawShine(g, path, rect, st)
            DrawGlow(g, path, rect, st, midColor) ' توهّج نابض على الإطار
        End If

        '==== المحتوى: صورة + نص ====
        Dim contentRect = Rectangle.Inflate(rect, -6, -6)
        Dim img As Image = GetButtonImage(btn)
        Dim text As String = btn.Text
        Dim spacing As Integer = 6

        Dim textSize As Size = If(String.IsNullOrEmpty(text), Size.Empty, TextRenderer.MeasureText(text, btn.Font))
        Dim imgSize As Size = If(img Is Nothing, Size.Empty, New Size(img.Width, img.Height))

        Dim imgRect As Rectangle = Rectangle.Empty
        Dim textRect As Rectangle = contentRect

        Select Case btn.TextImageRelation
            Case TextImageRelation.Overlay
                If img IsNot Nothing Then imgRect = CalcAlignedRect(imgSize, contentRect, btn.ImageAlign)
                Dim h As StringAlignment = StringAlignment.Center, v As StringAlignment = StringAlignment.Center
                MapAlignToStringFormat(btn.TextAlign, h, v)
                Dim sf As New StringFormat With {.Alignment = h, .LineAlignment = v, .FormatFlags = StringFormatFlags.NoWrap}
                If btn.RightToLeft = RightToLeft.Yes Then sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionRightToLeft
                Using txtBr As New SolidBrush(st.Fore)
                    g.DrawString(text, btn.Font, txtBr, contentRect, sf)
                End Using

            Case TextImageRelation.ImageBeforeText, TextImageRelation.TextBeforeImage
                Dim imageFirst As Boolean = (btn.TextImageRelation = TextImageRelation.ImageBeforeText)
                If btn.RightToLeft = RightToLeft.Yes Then imageFirst = Not imageFirst

                Dim totalW As Integer = imgSize.Width + If(img IsNot Nothing AndAlso textSize.Width > 0, spacing, 0) + textSize.Width
                Dim startX As Integer = contentRect.X + Math.Max(0, (contentRect.Width - totalW) \ 2)
                Dim imgY As Integer = contentRect.Y + (contentRect.Height - imgSize.Height) \ 2
                Dim txtY As Integer = contentRect.Y + (contentRect.Height - textSize.Height) \ 2

                If img IsNot Nothing AndAlso imageFirst Then
                    imgRect = New Rectangle(startX, imgY, imgSize.Width, imgSize.Height)
                    startX += imgSize.Width + spacing
                End If

                If textSize.Width > 0 Then
                    textRect = New Rectangle(startX, txtY, Math.Min(textSize.Width, contentRect.Right - startX), textSize.Height)
                    startX += textRect.Width
                End If

                If img IsNot Nothing AndAlso Not imageFirst Then
                    imgRect = New Rectangle(startX + spacing, imgY, imgSize.Width, imgSize.Height)
                End If

                TextRenderer.DrawText(g, text, btn.Font, textRect, st.Fore, TextFormatFlags.NoPadding)

            Case TextImageRelation.ImageAboveText, TextImageRelation.TextAboveImage
                Dim imageTop As Boolean = (btn.TextImageRelation = TextImageRelation.ImageAboveText)
                Dim totalH As Integer = imgSize.Height + If(img IsNot Nothing AndAlso textSize.Height > 0, spacing, 0) + textSize.Height
                Dim startY As Integer = contentRect.Y + Math.Max(0, (contentRect.Height - totalH) \ 2)

                Dim imgX As Integer = contentRect.X + (contentRect.Width - imgSize.Width) \ 2
                Dim txtX As Integer = contentRect.X + (contentRect.Width - textSize.Width) \ 2

                If img IsNot Nothing AndAlso imageTop Then
                    imgRect = New Rectangle(imgX, startY, imgSize.Width, imgSize.Height)
                    startY += imgSize.Height + spacing
                End If

                If textSize.Height > 0 Then
                    textRect = New Rectangle(txtX, startY, textSize.Width, textSize.Height)
                    startY += textSize.Height
                End If

                If img IsNot Nothing AndAlso Not imageTop Then
                    imgRect = New Rectangle(imgX, startY + spacing, imgSize.Width, imgSize.Height)
                End If

                TextRenderer.DrawText(g, text, btn.Font, textRect, st.Fore, TextFormatFlags.NoPadding)
        End Select

        ' إحساس الضغط: نزول 1px
        If st.Pressed Then
            If Not imgRect.IsEmpty Then imgRect.Offset(0, 1)
            textRect.Offset(0, 1)
        End If

        If img IsNot Nothing Then
            If btn.Enabled Then
                g.DrawImage(img, imgRect)
            Else
                ControlPaint.DrawImageDisabled(g, img, imgRect.X, imgRect.Y, btn.BackColor)
            End If
        End If

        ' تركيز خفيف
        If btn.Focused Then
            Using penFocus As New Pen(Color.FromArgb(120, Color.White))
                penFocus.DashStyle = DashStyle.Dot
                Dim fRect = Rectangle.Inflate(rect, -4, -4)
                g.DrawRectangle(penFocus, fRect)
            End Using
        End If
    End Sub

    '========================
    ' الأنيميشن
    '========================
    Private Sub EnsureAnimTimer()
        If Not AnimTimerHooked Then
            AddHandler AnimTimer.Tick, AddressOf AnimTimer_Tick
            AnimTimerHooked = True
        End If
    End Sub

    Private Sub StartAnim()
        If Not AnimTimer.Enabled Then AnimTimer.Start()
    End Sub

    Private Sub AnimTimer_Tick(sender As Object, e As EventArgs)
        Dim anyHover As Boolean = False

        For Each kv In States.ToArray()
            Dim btn = kv.Key
            If btn Is Nothing OrElse btn.IsDisposed Then Continue For
            Dim st = kv.Value

            If st.Hover Then
                anyHover = True
                st.ShinePos += 0.03
                If st.ShinePos > 1.2 Then st.ShinePos = -0.2

                ' نبض الإطار: 0..2π
                st.GlowPhase += 0.12 ' زود/قلّل للسرعة
                If st.GlowPhase > Math.PI * 2 Then st.GlowPhase -= Math.PI * 2

                btn.Invalidate()
            End If
        Next

        If Not anyHover Then AnimTimer.Stop()
    End Sub

    ' لمعة أفقية تمر عبر الزر
    Private Sub DrawShine(g As Graphics, clipPath As GraphicsPath, rect As Rectangle, st As VisualState)
        Dim center As Single = CSng(Math.Max(0.0, Math.Min(1.0, st.ShinePos)))
        Dim band As Single = 0.22F

        Dim leftPos As Single = Math.Max(0.0F, center - band / 2.0F)
        Dim rightPos As Single = Math.Min(1.0F, center + band / 2.0F)

        Dim cb As New ColorBlend()
        cb.Positions = New Single() {0.0F, leftPos, center, rightPos, 1.0F}
        cb.Colors = New Color() {
            Color.FromArgb(0, 255, 255, 255),
            Color.FromArgb(0, 255, 255, 255),
            Color.FromArgb(120, 255, 255, 255),
            Color.FromArgb(0, 255, 255, 255),
            Color.FromArgb(0, 255, 255, 255)
        }

        Using br As New LinearGradientBrush(rect, Color.Transparent, Color.Transparent, LinearGradientMode.Horizontal)
            br.InterpolationColors = cb
            Dim oldClip = g.Clip
            g.SetClip(clipPath)
            g.FillRectangle(br, rect)
            g.Clip = oldClip
        End Using
    End Sub

    ' توهج نابض على الإطار (بدون سواد)
    Private Sub DrawGlow(g As Graphics, clipPath As GraphicsPath, rect As Rectangle, st As VisualState, midColor As Color)
        ' شدة التوهّج 0..1
        Dim amp As Double = (Math.Sin(st.GlowPhase) + 1.0) / 2.0
        Dim a1 As Integer = CInt(60 + 80 * amp)   ' طبقة داخلية
        Dim a2 As Integer = CInt(25 + 40 * amp)   ' طبقة خارجية

        Dim glowBase As Color = Blend(midColor, Color.White, 0.75)

        ' طبقة عريضة شفافة
        Using penOuter As New Pen(Color.FromArgb(a2, glowBase), 8)
            penOuter.Alignment = PenAlignment.Inset
            g.DrawPath(penOuter, clipPath)
        End Using

        ' طبقة أضيق أشد سطوعًا
        Using penInner As New Pen(Color.FromArgb(a1, glowBase), 4)
            penInner.Alignment = PenAlignment.Inset
            g.DrawPath(penInner, clipPath)
        End Using
    End Sub

    '========================
    ' Helpers
    '========================
    Private Function GetButtonImage(btn As Button) As Image
        If btn.Image IsNot Nothing Then Return btn.Image
        If btn.ImageList IsNot Nothing Then
            Dim img As Image = Nothing
            If btn.ImageIndex >= 0 AndAlso btn.ImageIndex < btn.ImageList.Images.Count Then
                img = btn.ImageList.Images(btn.ImageIndex)
            End If
            If img Is Nothing AndAlso Not String.IsNullOrEmpty(btn.ImageKey) AndAlso btn.ImageList.Images.ContainsKey(btn.ImageKey) Then
                img = btn.ImageList.Images(btn.ImageKey)
            End If
            Return img
        End If
        Return Nothing
    End Function

    Private Sub MapAlignToStringFormat(align As ContentAlignment, ByRef h As StringAlignment, ByRef v As StringAlignment)
        Select Case align
            Case ContentAlignment.TopLeft : h = StringAlignment.Near : v = StringAlignment.Near
            Case ContentAlignment.TopCenter : h = StringAlignment.Center : v = StringAlignment.Near
            Case ContentAlignment.TopRight : h = StringAlignment.Far : v = StringAlignment.Near
            Case ContentAlignment.MiddleLeft : h = StringAlignment.Near : v = StringAlignment.Center
            Case ContentAlignment.MiddleCenter : h = StringAlignment.Center : v = StringAlignment.Center
            Case ContentAlignment.MiddleRight : h = StringAlignment.Far : v = StringAlignment.Center
            Case ContentAlignment.BottomLeft : h = StringAlignment.Near : v = StringAlignment.Far
            Case ContentAlignment.BottomCenter : h = StringAlignment.Center : v = StringAlignment.Far
            Case ContentAlignment.BottomRight : h = StringAlignment.Far : v = StringAlignment.Far
        End Select
    End Sub

    Private Function CalcAlignedRect(contentSize As Size, bounds As Rectangle, align As ContentAlignment) As Rectangle
        Dim x As Integer = bounds.X, y As Integer = bounds.Y
        Dim w As Integer = contentSize.Width, h As Integer = contentSize.Height

        Select Case align
            Case ContentAlignment.TopLeft
                x = bounds.Left : y = bounds.Top
            Case ContentAlignment.TopCenter
                x = bounds.Left + (bounds.Width - w) \ 2 : y = bounds.Top
            Case ContentAlignment.TopRight
                x = bounds.Right - w : y = bounds.Top
            Case ContentAlignment.MiddleLeft
                x = bounds.Left : y = bounds.Top + (bounds.Height - h) \ 2
            Case ContentAlignment.MiddleCenter
                x = bounds.Left + (bounds.Width - w) \ 2 : y = bounds.Top + (bounds.Height - h) \ 2
            Case ContentAlignment.MiddleRight
                x = bounds.Right - w : y = bounds.Top + (bounds.Height - h) \ 2
            Case ContentAlignment.BottomLeft
                x = bounds.Left : y = bounds.Bottom - h
            Case ContentAlignment.BottomCenter
                x = bounds.Left + (bounds.Width - w) \ 2 : y = bounds.Bottom - h
            Case ContentAlignment.BottomRight
                x = bounds.Right - w : y = bounds.Bottom - h
        End Select

        Return New Rectangle(x, y, w, h)
    End Function

    Private Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        If radius <= 0 Then
            path.AddRectangle(r)
            Return path
        End If
        Dim d = radius * 2
        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
        path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
        path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    ' مزج آمن (بدون Overflows)
    Private Function Blend(c1 As Color, c2 As Color, t As Double) As Color
        If Double.IsNaN(t) OrElse Double.IsInfinity(t) Then t = 0.0
        t = Math.Max(0.0, Math.Min(1.0, t))

        Dim rD As Double = CDbl(c1.R) + (CDbl(c2.R) - CDbl(c1.R)) * t
        Dim gD As Double = CDbl(c1.G) + (CDbl(c2.G) - CDbl(c1.G)) * t
        Dim bD As Double = CDbl(c1.B) + (CDbl(c2.B) - CDbl(c1.B)) * t

        rD = Math.Max(0.0, Math.Min(255.0, rD))
        gD = Math.Max(0.0, Math.Min(255.0, gD))
        bD = Math.Max(0.0, Math.Min(255.0, bD))

        Dim r As Integer = CInt(Math.Round(rD, MidpointRounding.AwayFromZero))
        Dim g As Integer = CInt(Math.Round(gD, MidpointRounding.AwayFromZero))
        Dim b As Integer = CInt(Math.Round(bD, MidpointRounding.AwayFromZero))
        Dim a As Integer = Math.Max(0, Math.Min(255, CInt(c1.A)))

        Return Color.FromArgb(a, r, g, b)
    End Function

    Private Function Lighten(c As Color, t As Double) As Color
        If Double.IsNaN(t) OrElse Double.IsInfinity(t) Then t = 0.0
        t = Math.Max(0.0, Math.Min(1.0, t))
        Return Blend(c, Color.White, t)
    End Function

    Private Function Darken(c As Color, t As Double) As Color
        If Double.IsNaN(t) OrElse Double.IsInfinity(t) Then t = 0.0
        t = Math.Max(0.0, Math.Min(1.0, t))
        Return Blend(c, Color.Black, t)
    End Function

    ' تفعيل DoubleBuffered
    Private Sub EnableDoubleBuffering(ctrl As Control)
        Try
            Dim pi = GetType(Control).GetProperty("DoubleBuffered",
                                                  BindingFlags.Instance Or BindingFlags.NonPublic)
            If pi IsNot Nothing Then pi.SetValue(ctrl, True, Nothing)
        Catch
        End Try
    End Sub

    ' قص الزر على شكل مستطيل مستدير
    Private Sub UpdateRoundedRegion(btn As Button, radius As Integer)
        Try
            Dim r = Rectangle.Inflate(btn.ClientRectangle, -1, -1)
            Dim gp = RoundedRect(r, Math.Max(0, radius))
            Dim rg As New Region(gp)
            btn.Region = rg
        Catch
        End Try
    End Sub
    Public Sub StartGoldStyleForAllForms()
        ' نشغّله مرة واحدة فقط
        Static hooked As Boolean
        If hooked Then Exit Sub
        hooked = True

        ' نخزن الفورمات التي تم تزيينها
        Static styled As System.Collections.Generic.HashSet(Of IntPtr)
        If styled Is Nothing Then styled = New System.Collections.Generic.HashSet(Of IntPtr)()

        ' هاندلر الزمن الخامل: يمر على الفورمات المفتوحة ويطبّق الستايل مرة واحدة لكل فورم
        AddHandler Application.Idle,
            Sub(sender As Object, e As EventArgs)
                For Each f As Form In Application.OpenForms
                    If f Is Nothing OrElse f.IsDisposed Then Continue For
                    Dim key = f.Handle
                    If Not styled.Contains(key) Then
                        ' طبّق الذهبي على كل الأزرار داخل الفورم
                        Button3DStyler.ApplyGoldToAll(f)
                        styled.Add(key)

                        ' أي كنترول يُضاف لاحقًا داخل الفورم
                        AddHandler f.ControlAdded,
                                Sub(s2 As Object, ce As ControlEventArgs)
                                    If ce.Control Is Nothing OrElse ce.Control.IsDisposed Then Return
                                    If TypeOf ce.Control Is Button Then
                                        Button3DStyler.ApplyGold(DirectCast(ce.Control, Button))
                                    ElseIf ce.Control.HasChildren Then
                                        Button3DStyler.ApplyGoldToAll(ce.Control)
                                    End If
                                    ' غطّي الإضافات المتداخلة داخل الحاوية نفسها
                                    AddHandler ce.Control.ControlAdded,
                                            Sub(s3 As Object, ce2 As ControlEventArgs)
                                                If ce2.Control Is Nothing OrElse ce2.Control.IsDisposed Then Return
                                                If TypeOf ce2.Control Is Button Then
                                                    Button3DStyler.ApplyGold(DirectCast(ce2.Control, Button))
                                                ElseIf ce2.Control.HasChildren Then
                                                    Button3DStyler.ApplyGoldToAll(ce2.Control)
                                                End If
                                            End Sub
                                End Sub

                        ' تنظيف عند التخلص من الفورم
                        AddHandler f.Disposed,
                                Sub()
                                    styled.Remove(key)
                                End Sub
                    End If
                Next
            End Sub
    End Sub
    ' ======== مُرسِم القائمة الذهبية ========
    Public Class GoldenToolStripRenderer
        Inherits ToolStripProfessionalRenderer
        ' لوحة ذهبية
        Private ReadOnly cTop As Color = ColorTranslator.FromHtml("#F7E08A")
        Private ReadOnly cMid As Color = ColorTranslator.FromHtml("#E0B84A")
        Private ReadOnly cBot As Color = ColorTranslator.FromHtml("#AD8217")

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            ' لا ترسم حدود إطار الشريط إطلاقاً
            ' (هذا يمنع الحواف السوداء حول MenuStrip/ToolStrip)
        End Sub

        Private Sub DrawItemGold(e As ToolStripItemRenderEventArgs, radius As Integer, Optional forceDark As Boolean = False)
            Dim g = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.PixelOffsetMode = PixelOffsetMode.HighQuality

            Dim r As Rectangle = Rectangle.Inflate(e.Item.ContentRectangle, -3, -2)
            If r.Width <= 4 OrElse r.Height <= 4 Then Return

            Dim enabled As Boolean = e.Item.Enabled
            Dim hover As Boolean = e.Item.Selected AndAlso enabled
            Dim pressed As Boolean = e.Item.Pressed AndAlso enabled

            Using path = RoundedRect(r, radius)
                ' الألوان الأساسية
                Dim top = cTop, mid = cMid, bot = cBot

                ' 2) منطق الذهبي الداكن للدروب-داون
                If forceDark Then
                    top = Darken(top, 0.18) : mid = Darken(mid, 0.18) : bot = Darken(bot, 0.18)
                Else
                    ' السلوك القديم (إضاءة طفيفة عند hover لعناصر الشريط العلوي)
                    If hover Then
                        top = Blend(top, Color.White, 0.08)
                        mid = Blend(mid, Color.White, 0.06)
                        bot = Blend(bot, Color.White, 0.04)
                    End If
                    If pressed Then
                        top = Darken(top, 0.07) : mid = Darken(mid, 0.07) : bot = Darken(bot, 0.07)
                    End If
                    If Not enabled Then
                        top = Blend(top, Color.White, 0.5)
                        mid = Blend(mid, Color.White, 0.5)
                        bot = Blend(bot, Color.White, 0.5)
                    End If
                End If

                ' تدرّج ذهبي
                Using br As New LinearGradientBrush(r, top, bot, LinearGradientMode.Vertical)
                    Dim cb As New ColorBlend() With {
                .Positions = New Single() {0.0F, 0.5F, 10.0F},
                .Colors = New Color() {top, mid, bot}
            }
                    br.InterpolationColors = cb
                    g.FillPath(br, path)
                End Using

                ' لمعة علوية خفيفة
                Dim inner = Rectangle.Inflate(r, -1, -1)
                Dim hl = New Rectangle(inner.X, inner.Y, inner.Width, CInt(inner.Height / 2.0))
                Using pathHigh = RoundedRect(hl, Math.Max(0, radius - 2))
                    Using brHigh As New LinearGradientBrush(hl, Color.FromArgb(110, Color.White), Color.FromArgb(0, Color.White), LinearGradientMode.Vertical)
                        g.FillPath(brHigh, pathHigh)
                    End Using
                End Using

                ' إطار
                Using pen As New Pen(Blend(mid, Color.White, 0.35), 1)
                    pen.Alignment = PenAlignment.Inset
                    g.DrawPath(pen, path)
                End Using
            End Using

            e.Item.ForeColor = Color.Black
        End Sub

        Protected Overrides Sub OnRenderToolStripBackground(e As ToolStripRenderEventArgs)
            ' اجعل الخلفية هي لون الحاوي (مثلاً الأسود في لقطة الشاشة)
            Dim back = If(e.ToolStrip.Parent IsNot Nothing, e.ToolStrip.Parent.BackColor, e.ToolStrip.BackColor)
            e.Graphics.Clear(back)
            If TypeOf e.ToolStrip Is ToolStripDropDownMenu Then
                Dim rc = e.AffectedBounds
                Using br As New LinearGradientBrush(rc, cTop, cBot, LinearGradientMode.Vertical)
                    Dim cb As New ColorBlend() With {
                        .Positions = New Single() {0.0F, 0.5F, 1.0F},
                        .Colors = New Color() {cTop, cMid, cBot}
                    }
                    br.InterpolationColors = cb
                    e.Graphics.FillRectangle(br, rc)
                End Using
            End If
        End Sub
        Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
            DrawItemGold(e, radius:=CInt(Math.Max(10, e.Item.Bounds.Height \ 2)))
        End Sub
        Protected Overrides Sub OnRenderDropDownButtonBackground(e As ToolStripItemRenderEventArgs)
            DrawItemGold(e, radius:=CInt(Math.Max(10, e.Item.Bounds.Height \ 2)))
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            ' عناصر المستوى الأعلى في MenuStrip بشكل pill
            Dim isTopLevel As Boolean = TypeOf e.ToolStrip Is MenuStrip AndAlso e.Item.OwnerItem Is Nothing
            Dim rad As Integer = If(isTopLevel, CInt(Math.Max(10, e.Item.Bounds.Height \ 2)), 6)
            DrawItemGold(e, radius:=rad)
        End Sub

        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            Dim g = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim rc = e.Item.ContentRectangle
            Using p As New Pen(Color.FromArgb(120, Color.White))
                If e.Vertical Then
                    g.DrawLine(p, rc.Left + rc.Width \ 2, rc.Top + 2, rc.Left + rc.Width \ 2, rc.Bottom - 2)
                Else
                    g.DrawLine(p, rc.Left + 4, rc.Top + rc.Height \ 2, rc.Right - 4, rc.Top + rc.Height \ 2)
                End If
            End Using
        End Sub

        ' ألغِ هوامش صورة النظام الرمادية في القوائم المنسدلة
        Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
            ' لا ترسم أي شيء هنا (بدون عمود ظلّ)
        End Sub

        ' لو حابب تتحكم في النص (للون/RTL) نرسمه يدويًا ليتوسّط داخل الـpill
        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            e.TextColor = Color.Black
            Dim flags As TextFormatFlags =
                TextFormatFlags.EndEllipsis Or TextFormatFlags.VerticalCenter Or TextFormatFlags.NoPadding

            If e.ToolStrip.RightToLeft = RightToLeft.Yes Then
                flags = flags Or TextFormatFlags.RightToLeft Or TextFormatFlags.Right
            Else
                flags = flags Or TextFormatFlags.HorizontalCenter
            End If

            Dim r = Rectangle.Inflate(e.TextRectangle, -6, 0)
            TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont, r, e.TextColor, flags)
        End Sub

        Private Sub DrawItemGold(e As ToolStripItemRenderEventArgs, radius As Integer)
            Dim g = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.PixelOffsetMode = PixelOffsetMode.HighQuality

            ' اعتبر العنصر بحجم محتواه مع هامش داخلي
            Dim r As Rectangle = Rectangle.Inflate(e.Item.ContentRectangle, -3, -2)
            If r.Width <= 4 OrElse r.Height <= 4 Then Return

            ' لا نلوّن العناصر المعطّلة (but حافظ على الـpill باهت لو حابب)
            Dim enabled As Boolean = e.Item.Enabled
            Dim hover As Boolean = e.Item.Selected AndAlso enabled
            Dim pressed As Boolean = e.Item.Pressed AndAlso enabled

            ' مسار مستدير
            Using path = RoundedRect(r, radius)

                ' ألوان مع تأثير Hover/Pressed (نفس الأزرار)
                Dim top = cTop, mid = cMid, bot = cBot
                If hover Then
                    top = Blend(top, Color.White, 0.08)
                    mid = Blend(mid, Color.White, 0.06)
                    bot = Blend(bot, Color.White, 0.04)
                End If
                If pressed Then
                    top = Darken(top, 0.07) : mid = Darken(mid, 0.07) : bot = Darken(bot, 0.07)
                End If
                If Not enabled Then
                    top = Blend(top, Color.White, 0.5)
                    mid = Blend(mid, Color.White, 0.5)
                    bot = Blend(bot, Color.White, 0.5)
                End If

                ' خلفية ذهبية ثلاثية
                Using br As New LinearGradientBrush(r, top, bot, LinearGradientMode.Vertical)
                    Dim cb As New ColorBlend() With {
                        .Positions = New Single() {0.0F, 0.5F, 1.0F},
                        .Colors = New Color() {top, mid, bot}
                    }
                    br.InterpolationColors = cb
                    g.FillPath(br, path)
                End Using

                ' لمعة علوية (بدون ظل أسود)
                Dim inner = Rectangle.Inflate(r, -1, -1)
                Dim hl = New Rectangle(inner.X, inner.Y, inner.Width, CInt(inner.Height / 2.0))
                Using pathHigh = RoundedRect(hl, Math.Max(0, radius - 2))
                    Using brHigh As New LinearGradientBrush(hl, Color.FromArgb(110, Color.White), Color.FromArgb(0, Color.White), LinearGradientMode.Vertical)
                        g.FillPath(brHigh, pathHigh)
                    End Using
                End Using

                ' إطار ذهبي فاتح
                Using pen As New Pen(Blend(mid, Color.White, 0.35), 1)
                    pen.Alignment = PenAlignment.Inset
                    g.DrawPath(pen, path)
                End Using
            End Using

            ' اجعل لون النص واضحًا
            e.Item.ForeColor = Color.Black
        End Sub

        ' ===== Helpers =====
        Private Shared Function RoundedRect(r As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            If radius <= 0 Then path.AddRectangle(r) : Return path
            Dim d = radius * 2
            path.AddArc(r.X, r.Y, d, d, 180, 90)
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90)
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
            path.CloseFigure()
            Return path
        End Function

        Private Shared Function Blend(c1 As Color, c2 As Color, t As Double) As Color
            If Double.IsNaN(t) OrElse Double.IsInfinity(t) Then t = 0.0
            t = Math.Max(0.0, Math.Min(1.0, t))
            Dim rD = CDbl(c1.R) + (CDbl(c2.R) - CDbl(c1.R)) * t
            Dim gD = CDbl(c1.G) + (CDbl(c2.G) - CDbl(c1.G)) * t
            Dim bD = CDbl(c1.B) + (CDbl(c2.B) - CDbl(c1.B)) * t
            Dim r = CInt(Math.Max(0, Math.Min(255, Math.Round(rD))))
            Dim g = CInt(Math.Max(0, Math.Min(255, Math.Round(gD))))
            Dim b = CInt(Math.Max(0, Math.Min(255, Math.Round(bD))))
            Return Color.FromArgb(c1.A, r, g, b)
        End Function

        Private Shared Function Darken(c As Color, t As Double) As Color
            Return Blend(c, Color.Black, Math.Max(0, Math.Min(1, t)))
        End Function
    End Class

    ' ====== دوال تطبيق سريعة ======

    ' طبق المُرسِم على MenuStrip/ToolStrip واحد
    Public Sub StyleGold(ts As ToolStrip)
        If ts Is Nothing OrElse ts.IsDisposed Then Exit Sub
        ts.Renderer = New GoldenToolStripRenderer()
        ts.RenderMode = ToolStripRenderMode.ManagerRenderMode
        ts.ForeColor = Color.Black
        ' تكبير الأيقونات قليلاً ليظهر الشكل مثل الأزرار
        If ts.ImageScalingSize.Width < 24 Then ts.ImageScalingSize = New Size(24, 24)
        ' حواف وهوامش مماثلة للأزرار
        For Each it As ToolStripItem In ts.Items
            it.Margin = New Padding(4, 4, 4, 4)
            it.Padding = New Padding(10, 4, 10, 4)
            it.ForeColor = Color.Black
        Next
        ' إخفاء Grip (في ToolStrip) لو موجود
        If TypeOf ts Is ToolStrip Then DirectCast(ts, ToolStrip).GripStyle = ToolStripGripStyle.Hidden
    End Sub

    ' طبق على كل القوائم داخل فورم/حاوية
    Public Sub StyleGoldMenusIn(root As Control)
        If root Is Nothing OrElse root.IsDisposed Then Exit Sub
        For Each c As Control In root.Controls
            If TypeOf c Is MenuStrip Then StyleGold(DirectCast(c, MenuStrip))
            If TypeOf c Is ToolStrip Then StyleGold(DirectCast(c, ToolStrip))
            If c.HasChildren Then StyleGoldMenusIn(c)
        Next
    End Sub
End Module
