Public Class frm_report_siting

    Private Sub frm_report_siting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' تهيئة القيم الافتراضية للهوامش
        Dim margins = GetReportMargins()
        nudTop.Value = margins.Top
        nudBottom.Value = margins.Bottom
        nudLeft.Value = margins.Left
        nudRight.Value = margins.Right
        ' تفعيل معاينة الهوامش
        UpdatePreview()
    End Sub
    ' تحديث معاينة الهوامش عند تغيير القيم
    Private Sub nudTop_ValueChanged(sender As Object, e As EventArgs) Handles nudTop.ValueChanged
        UpdatePreview()
    End Sub
    Private Sub nudBottom_ValueChanged(sender As Object, e As EventArgs) Handles nudBottom.ValueChanged
        UpdatePreview()
    End Sub

    Private Sub nudLeft_ValueChanged(sender As Object, e As EventArgs) Handles nudLeft.ValueChanged
        UpdatePreview()
    End Sub

    Private Sub nudRight_ValueChanged(sender As Object, e As EventArgs) Handles nudRight.ValueChanged
        UpdatePreview()
    End Sub

    ' رسم معاينة الهوامش
    Private Sub pnlPreview_Paint(sender As Object, e As PaintEventArgs) Handles pnlPreview.Paint
        DrawMarginPreview(e.Graphics)
    End Sub

    ' دالة رسم معاينة الهوامش
    Private Sub DrawMarginPreview(g As Graphics)
        Dim panelWidth As Integer = pnlPreview.Width - 2 ' نطرح 2 للحدود
        Dim panelHeight As Integer = pnlPreview.Height - 2
        ' حساب النسب (نحول من mm إلى pixels)
        ' نفترض أن القيمة القصوى 100mm = 100% من المساحة المتاحة
        Dim maxMargin As Decimal = 100
        Dim scaleX As Single = panelWidth / maxMargin
        Dim scaleY As Single = panelHeight / maxMargin
        ' حساب الهوامش بالبكسل
        Dim marginTop As Single = CSng(nudTop.Value) * scaleY
        Dim marginBottom As Single = CSng(nudBottom.Value) * scaleY
        Dim marginLeft As Single = CSng(nudLeft.Value) * scaleX
        Dim marginRight As Single = CSng(nudRight.Value) * scaleX

        ' التأكد من أن الهوامش لا تتجاوز حجم اللوحة
        marginTop = Math.Min(marginTop, panelHeight * 0.4F)
        marginBottom = Math.Min(marginBottom, panelHeight * 0.4F)
        marginLeft = Math.Min(marginLeft, panelWidth * 0.4F)
        marginRight = Math.Min(marginRight, panelWidth * 0.4F)

        ' مسح الخلفية
        g.Clear(Color.White)

        ' رسم منطقة الهوامش (الخلفية الرمادية)
        Using marginBrush As New SolidBrush(Color.FromArgb(240, 240, 240))
            ' الهامش العلوي
            g.FillRectangle(marginBrush, 1, 1, panelWidth, marginTop)

            ' الهامش السفلي
            g.FillRectangle(marginBrush, 1, panelHeight - marginBottom, panelWidth, marginBottom)

            ' الهامش الأيسر
            g.FillRectangle(marginBrush, 1, marginTop, marginLeft, panelHeight - marginTop - marginBottom)

            ' الهامش الأيمن
            g.FillRectangle(marginBrush, panelWidth - marginRight, marginTop, marginRight, panelHeight - marginTop - marginBottom)
        End Using

        ' رسم حدود منطقة المحتوى
        Dim contentX As Single = 1 + marginLeft
        Dim contentY As Single = 1 + marginTop
        Dim contentWidth As Single = panelWidth - marginLeft - marginRight
        Dim contentHeight As Single = panelHeight - marginTop - marginBottom

        Using contentPen As New Pen(Color.FromArgb(70, 130, 180), 2)
            g.DrawRectangle(contentPen, contentX, contentY, contentWidth, contentHeight)
        End Using

        ' رسم خطوط الهوامش
        Using marginPen As New Pen(Color.FromArgb(200, 200, 200), 1)
            ' خط الهامش العلوي
            If marginTop > 0 Then
                g.DrawLine(marginPen, 1, marginTop, panelWidth, marginTop)
            End If

            ' خط الهامش السفلي
            If marginBottom > 0 Then
                g.DrawLine(marginPen, 1, panelHeight - marginBottom, panelWidth, panelHeight - marginBottom)
            End If

            ' خط الهامش الأيسر
            If marginLeft > 0 Then
                g.DrawLine(marginPen, marginLeft, marginTop, marginLeft, panelHeight - marginBottom)
            End If

            ' خط الهامش الأيمن
            If marginRight > 0 Then
                g.DrawLine(marginPen, panelWidth - marginRight, marginTop, panelWidth - marginRight, panelHeight - marginBottom)
            End If
        End Using

        ' رسم نص في منطقة المحتوى
        Using textBrush As New SolidBrush(Color.FromArgb(100, 100, 100))
            Using textFont As New Font("Segoe UI", 8, FontStyle.Regular)
                Dim text As String = "منطقة المحتوى"
                Dim textSize As SizeF = g.MeasureString(text, textFont)
                Dim textX As Single = contentX + (contentWidth - textSize.Width) / 2
                Dim textY As Single = contentY + (contentHeight - textSize.Height) / 2
                g.DrawString(text, textFont, textBrush, textX, textY)
            End Using
        End Using

        ' رسم القيم على الهوامش
        Using valueFont As New Font("Segoe UI", 7, FontStyle.Regular)
            Using valueBrush As New SolidBrush(Color.FromArgb(150, 150, 150))
                ' قيمة الهامش العلوي
                If marginTop > 15 Then
                    Dim topText As String = nudTop.Value.ToString() & " mm"
                    g.DrawString(topText, valueFont, valueBrush, panelWidth / 2 - 20, marginTop / 2 - 6)
                End If

                ' قيمة الهامش السفلي
                If marginBottom > 15 Then
                    Dim bottomText As String = nudBottom.Value.ToString() & " mm"
                    g.DrawString(bottomText, valueFont, valueBrush, panelWidth / 2 - 20, panelHeight - marginBottom / 2 - 6)
                End If

                ' قيمة الهامش الأيسر
                If marginLeft > 20 Then
                    Dim leftText As String = nudLeft.Value.ToString() & " mm"
                    Dim leftSize As SizeF = g.MeasureString(leftText, valueFont)
                    g.DrawString(leftText, valueFont, valueBrush, marginLeft / 2 - leftSize.Width / 2, panelHeight / 2 - 6)
                End If

                ' قيمة الهامش الأيمن
                If marginRight > 20 Then
                    Dim rightText As String = nudRight.Value.ToString() & " mm"
                    Dim rightSize As SizeF = g.MeasureString(rightText, valueFont)
                    g.DrawString(rightText, valueFont, valueBrush, panelWidth - marginRight / 2 - rightSize.Width / 2, panelHeight / 2 - 6)
                End If
            End Using
        End Using
    End Sub

    ' تحديث المعاينة
    Private Sub UpdatePreview()
        pnlPreview.Invalidate()
    End Sub

    Private Sub LblPreviewTitle_Click(sender As Object, e As EventArgs) Handles lblPreviewTitle.Click

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        nudTop.Value = 0
        nudBottom.Value = 0
        nudLeft.Value = 0
        nudRight.Value = 0


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            UpdateReportMargins(
                nudTop.Value,
                nudBottom.Value,
                nudLeft.Value,
                nudRight.Value
            )

            MessageBox.Show("تم حفظ الهوامش بنجاح ✅", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("حصل خطأ أثناء الحفظ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function UpdateReportMargins(topM As Decimal, bottomM As Decimal, leftM As Decimal, rightM As Decimal) As Boolean
        Try
            GlCommand.Parameters.Clear()

            GlCommand.CommandText =
                "UPDATE dbo.comp_inform SET " &
                "MarginTop = @MarginTop, " &
                "MarginBottom = @MarginBottom, " &
                "MarginLeft = @MarginLeft, " &
                "MarginRight = @MarginRight"
            With GlCommand.Parameters
                .AddWithValue("@MarginTop", topM)
                .AddWithValue("@MarginBottom", bottomM)
                .AddWithValue("@MarginLeft", leftM)
                .AddWithValue("@MarginRight", rightM)
            End With
            GlCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class