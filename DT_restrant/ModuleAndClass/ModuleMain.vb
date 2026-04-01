
Imports System.ServiceProcess
Imports PACICardLibrary
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text.Encoding
Imports Microsoft.Reporting.WinForms
Imports System.Net.Http
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports System.Net.NetworkInformation
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports System.Drawing.Printing
Imports System.Xml
Imports System.Text.RegularExpressions

Public Module TooltipHelper
    Private ReadOnly tt As New ToolTip() With {
        .AutoPopDelay = 10000,
        .InitialDelay = 200,
        .ReshowDelay = 100,
        .ShowAlways = True
    }
    Public Sub EnableTextBoxTooltips(root As Control)
        AttachToTextBoxes(root)
    End Sub
    Private Sub AttachToTextBoxes(root As Control)
        For Each c As Control In root.Controls
            If TypeOf c Is TextBox Then
                Dim tb = DirectCast(c, TextBox)
                RemoveHandler tb.MouseEnter, AddressOf TextBox_MouseEnter
                AddHandler tb.MouseEnter, AddressOf TextBox_MouseEnter
            End If
            If c.HasChildren Then AttachToTextBoxes(c)
        Next
    End Sub
    Private Sub TextBox_MouseEnter(sender As Object, e As EventArgs)
        Dim tb = DirectCast(sender, TextBox)
        Dim tip As String = ""
        If tb.Tag IsNot Nothing Then tip = tb.Tag.ToString().Trim()
        If tip = "" Then tip = tb.Text
        tt.SetToolTip(tb, tip)
    End Sub
End Module
'\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
Public Module FieldValidator
    Public Class FrmMessageDialog
        Public Enum MessageDialogButtons
            OkOnly
            YesNo
        End Enum
        Public Shared Function ShowMessage(owner As Form,
                                       titleAr As String,
                                       titleEn As String,
                                       arabicMsg As String,
                                       englishMsg As String,
                                       iconText As String,
                                       badgeText As String,
                                       footerText As String,
                                       headerColor As Color,
                                       accentColor As Color,
                                       buttons As MessageDialogButtons) As DialogResult
            Dim result As DialogResult
            Using frm As New Form()
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.FormBorderStyle = FormBorderStyle.FixedDialog
                frm.MaximizeBox = False
                frm.MinimizeBox = False
                frm.ShowInTaskbar = False
                frm.RightToLeft = RightToLeft.Yes
                frm.RightToLeftLayout = True
                frm.BackColor = Color.White
                frm.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular, GraphicsUnit.Point)
                frm.ClientSize = New Size(560, 260)
                frm.Text = titleEn
                Dim pnlHeader As New Panel() With {
                .Dock = DockStyle.Top,
                .Height = 70,
                .BackColor = headerColor
            }
                frm.Controls.Add(pnlHeader)
                AddHandler pnlHeader.Paint,
                Sub(sender As Object, e As PaintEventArgs)
                    Using p As New Pen(accentColor, 2)
                        e.Graphics.DrawLine(p, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1)
                    End Using
                End Sub
                Dim lblIcon As New Label() With {
                .AutoSize = False,
                .Width = 48,
                .Height = 48,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI Emoji", 24, FontStyle.Regular),
                .BackColor = Color.Transparent,
                .Text = iconText
            }
                lblIcon.Left = 20
                lblIcon.Top = (pnlHeader.Height - lblIcon.Height) \ 2
                pnlHeader.Controls.Add(lblIcon)
                Dim lblTitleAr As New Label() With {
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleRight,
                .Font = New Font("Segoe UI", 15, FontStyle.Bold),
                .ForeColor = Color.Black,
                .Text = titleAr
            }
                lblTitleAr.Left = lblIcon.Right + 10
                lblTitleAr.Top = 10
                lblTitleAr.Width = frm.ClientSize.Width - lblIcon.Right - 30
                lblTitleAr.Height = 24
                pnlHeader.Controls.Add(lblTitleAr)
                Dim lblTitleEn As New Label() With {
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleRight,
                .Font = New Font("Segoe UI", 15, FontStyle.Regular),
                .ForeColor = Color.Black,
                .Text = titleEn
            }
                lblTitleEn.Left = lblTitleAr.Left
                lblTitleEn.Top = lblTitleAr.Bottom + 2
                lblTitleEn.Width = lblTitleAr.Width
                lblTitleEn.Height = 20
                pnlHeader.Controls.Add(lblTitleEn)
                Dim pnlButtons As New Panel() With {
                .Dock = DockStyle.Bottom,
                .Height = 70,
                .Padding = New Padding(20, 10, 20, 15)
            }
                frm.Controls.Add(pnlButtons)
                Dim pnlBody As New Panel() With {
    .Dock = DockStyle.Fill,
    .Padding = New Padding(20, 10, 20, 10)
}
                frm.Controls.Add(pnlBody)
                Dim lblMessage As New Label() With {
    .AutoSize = False,
    .Dock = DockStyle.Fill,
    .TextAlign = ContentAlignment.MiddleCenter,
    .Font = New Font("Segoe UI", 12, FontStyle.Bold),
    .ForeColor = Color.Black,
    .RightToLeft = RightToLeft.Yes
}
                lblMessage.Text = arabicMsg & Environment.NewLine & englishMsg
                Dim lblBadge As New Label() With {
    .AutoSize = False,
    .Dock = DockStyle.Bottom,
    .Height = 30,
    .TextAlign = ContentAlignment.MiddleCenter,
    .Font = New Font("Segoe UI", 10.5!, FontStyle.Bold),
    .ForeColor = Color.Black,
    .BackColor = Color.FromArgb(255, 250, 210),
    .Padding = New Padding(10, 4, 10, 4),
    .Visible = False
}
                If Not String.IsNullOrWhiteSpace(badgeText) Then
                    lblBadge.Text = badgeText
                    lblBadge.Visible = True
                End If
                Dim lblFooter As New Label() With {
    .AutoSize = False,
    .Dock = DockStyle.Bottom,
    .Height = 40,
    .TextAlign = ContentAlignment.MiddleCenter,
    .Font = New Font("Segoe UI", 9.5!, FontStyle.Regular),
    .ForeColor = Color.Black,
    .BackColor = Color.FromArgb(245, 245, 245),
    .Padding = New Padding(8),
    .Visible = False
}
                If Not String.IsNullOrWhiteSpace(footerText) Then
                    lblFooter.Text = footerText
                    lblFooter.Visible = True
                End If
                pnlBody.Controls.Add(lblMessage)
                pnlBody.Controls.Add(lblFooter)
                pnlBody.Controls.Add(lblBadge)
                Dim btnOk As New Button() With {
                .Text = "حسناً / OK",
                .Width = 160,
                .Height = 34,
                .BackColor = Color.FromArgb(220, 38, 38),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
                btnOk.FlatAppearance.BorderSize = 0
                AddHandler btnOk.Click,
                Sub(sender As Object, e As EventArgs)
                    frm.DialogResult = DialogResult.OK
                    frm.Close()
                End Sub
                Dim btnYes As New Button() With {
                .Text = "نعم / Yes",
                .Width = 120,
                .Height = 34,
                .BackColor = Color.FromArgb(34, 197, 94),
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat
            }
                btnYes.FlatAppearance.BorderSize = 0
                AddHandler btnYes.Click,
                Sub(sender As Object, e As EventArgs)
                    frm.DialogResult = DialogResult.Yes
                    frm.Close()
                End Sub
                Dim btnNo As New Button() With {
                .Text = "لا / No",
                .Width = 120,
                .Height = 34,
                .BackColor = Color.White,
                .ForeColor = Color.Black,
                .FlatStyle = FlatStyle.Flat
            }
                btnNo.FlatAppearance.BorderColor = Color.Silver
                btnNo.FlatAppearance.BorderSize = 1
                AddHandler btnNo.Click,
                Sub(sender As Object, e As EventArgs)
                    frm.DialogResult = DialogResult.No
                    frm.Close()
                End Sub
                If buttons = MessageDialogButtons.OkOnly Then
                    btnOk.Left = (pnlButtons.ClientSize.Width - btnOk.Width) \ 2
                    btnOk.Top = (pnlButtons.ClientSize.Height - btnOk.Height) \ 2
                    pnlButtons.Controls.Add(btnOk)
                    frm.AcceptButton = btnOk
                    frm.CancelButton = btnOk
                Else
                    Dim totalWidth As Integer = btnYes.Width + 14 + btnNo.Width
                    Dim startX As Integer = (pnlButtons.ClientSize.Width - totalWidth) \ 2
                    btnYes.Left = startX
                    btnNo.Left = btnYes.Right + 14
                    btnYes.Top = (pnlButtons.ClientSize.Height - btnYes.Height) \ 2
                    btnNo.Top = btnYes.Top
                    pnlButtons.Controls.Add(btnYes)
                    pnlButtons.Controls.Add(btnNo)
                    frm.AcceptButton = btnYes
                    frm.CancelButton = btnNo
                End If
                If owner IsNot Nothing Then
                    result = frm.ShowDialog(owner)
                Else
                    result = frm.ShowDialog()
                End If
            End Using
            Return result
        End Function
    End Class
    Public Function ValidateField(txt As TextBox,
                                  arabicMsg As String,
                                  englishMsg As String,
                                  Optional isRequired As Boolean = False) As Boolean
        Try
            If txt Is Nothing OrElse txt.IsDisposed Then
                Return False
            End If
            If Not String.IsNullOrWhiteSpace(txt.Text) Then
                Return True
            End If
            Dim owner As Form = txt.FindForm()
            Dim titleAr As String
            Dim titleEn As String
            Dim badgeText As String = ""
            Dim headerColor As Color = Color.Goldenrod
            Dim accentColor As Color = Color.Goldenrod
            If isRequired Then
                titleAr = "حقل إجباري"
                titleEn = "Required Field"
                badgeText = "هذا الحقل يجب تعبئته قبل المتابعة"
            Else
                titleAr = "تنبيه"
                titleEn = "Warning"
            End If
            Dim buttonsMode = If(isRequired,
                                 FrmMessageDialog.MessageDialogButtons.OkOnly,
                                 FrmMessageDialog.MessageDialogButtons.YesNo)

            Dim result As DialogResult = FrmMessageDialog.ShowMessage(
                owner,
                titleAr,
                titleEn,
                arabicMsg,
                englishMsg,
                "⚠",
                badgeText,
                "",
                headerColor,
                accentColor,
                buttonsMode
            )
            txt.Focus()
            txt.SelectAll()
            If isRequired Then
                Return False
            Else
                Return (result = DialogResult.Yes)
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
Module ModuleIdentityWarning
    Public Sub ClearAllText(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If TypeOf c Is TextBox Then
                CType(c, TextBox).Clear()
            ElseIf c.HasChildren Then
                ClearAllText(c)
            End If
        Next
    End Sub
    Private frm As Form
    Public Sub ShowIdentityWarning()
        frm = New Form With {
            .Text = "🚨 تنبيه: خدمة مصادقة هويتي",
            .Size = New Size(650, 500),
            .StartPosition = FormStartPosition.CenterScreen,
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .MaximizeBox = False,
            .MinimizeBox = False,
            .BackColor = Color.White
        }

        Dim lblTitle As New Label With {
            .Text = "⚠️ أنت غير مشترك في خدمة مصادقة هويتي من قبل الهيئة العامة للمعلومات المدنية." & vbCrLf &
                    "You are not subscribed to the PACI identity verification service.",
            .Font = New Font("Cairo", 11, FontStyle.Bold),
            .ForeColor = Color.DarkRed,
            .AutoSize = False,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Height = 100
        }
        Dim txtMessage As New TextBox With {
            .Multiline = True,
            .ReadOnly = True,
            .ScrollBars = ScrollBars.Vertical,
            .Font = New Font("Cairo", 11, FontStyle.Bold),
            .Dock = DockStyle.Top,
            .Height = 350,
            .BackColor = Color.FromArgb(245, 245, 245), ' لون خلفية مريح
            .ForeColor = Color.FromArgb(50, 50, 50),   ' لون خط مريح
            .BorderStyle = BorderStyle.None,
            .Text =
"📝 يمكنك تفعيل الخدمة بعد الحصول على ترخيص الهيئة العامة للمعلومات المدنية:
You can activate the service after obtaining approval from the Public Authority for Civil Information (PACI):

✅ المستندات المطلوبة / Required Documents:
✔ صورة من الرخصة
  Copy of the license

✔ صورة البطاقة المدنية للمفوض بالتوقيع أو الكفيل
  Copy of the Civil ID of the authorized signatory or sponsor

✔ في حال عدم رغبة الكفيل بالحضور، يمكن إرسال مندوب عنه بكتاب تفويض خاص بالمعاملة
  If the sponsor is unwilling to attend, a representative can be sent with a special authorization letter

✔ تعبئة نموذج 'عدم إفشاء الأسرار' المقدم من الهيئة (مرفق مع الرسالة)
  Fill out the 'Non-Disclosure Agreement' form provided by PACI (attached with the message)

📥 ثم تقديم الطلب إلى الهيئة العامة للمعلومات المدنية.
Then, submit the request to PACI."
    }
        Dim btnDownload As New Button With {
            .Text = "📎 تحميل المرفقات",
            .Width = 180,
            .Height = 40,
            .BackColor = Color.FromArgb(52, 152, 219),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        btnDownload.FlatAppearance.BorderSize = 0
        btnDownload.Font = New Font("Cairo", 10, FontStyle.Bold)

        AddHandler btnDownload.Click, Sub()
                                          Process.Start(New ProcessStartInfo("https://cloud.sabpay.net/uploads/SAB/PACIPrivate.pdf") With {.UseShellExecute = True})
                                      End Sub

        Dim btnClose As New Button With {
            .Text = "❌ إغلاق",
            .Width = 120,
            .Height = 40,
            .BackColor = Color.FromArgb(231, 76, 60),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat
        }
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.Font = New Font("Cairo", 10, FontStyle.Bold)

        AddHandler btnClose.Click, Sub() frm.Close()

        ' ترتيب الأزرار أسفل النافذة
        Dim pnlButtons As New FlowLayoutPanel With {
            .Dock = DockStyle.Bottom,
            .Height = 60,
            .FlowDirection = FlowDirection.RightToLeft,
            .Padding = New Padding(10)
        }
        pnlButtons.Controls.Add(btnClose)
        pnlButtons.Controls.Add(btnDownload)
        frm.Controls.Add(pnlButtons)
        frm.Controls.Add(txtMessage)
        frm.Controls.Add(lblTitle)
        frm.ShowDialog()
    End Sub
End Module
Module ModuleMain
    Public MetalType As Boolean
    Public PrintRepeat As String
    Public SelectColor As New ColorDialog
    Public FontColor As New ColorDialog
    Public TrueFalse As Boolean = False
    Public ReportPath As String = "0"
    Public SqlComGetInv As String = "0"
    Public SqlFillCom As String = "0"
    Public ComInvNoDisplayMember As String = "0"
    Public ComInvNoValueMember As String = "0"
    Public licenseID As String 'رقم الرخصه او السجل التجاري لمنع تكرار ترخيص الجهاز
    'اضافة الفرق بين سعر السوق وسعر البرنامج بيع وشراء
    Dim TEXOnceSell As String
    Dim TEXOnceSellUsd As String
    Dim EX24Sell As String
    Dim TEX22Sell As String
    Dim TTEX21Sell As String
    Dim TEX18Sell As String
    Dim TEX925Sell As String
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Dim TEXOnceBUY As String
    Dim TEXOnceBUYUsd As String
    Dim TEX24BUY As String
    Dim TEX22BUY As String
    Dim TEX21BUY As String
    Dim TEX18BUY As String
    Dim TEX925BUY As String
    Public ShowEncrtext As String
    Public SqlServerConnectionString As String = My.MySettings.Default.DT_restrantConnectionString10
    Public InvID As String

    ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''' ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''' ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    '''الربط والاتصال بالداتا بيس التي يتم منها التحويل
    Public FromSQLServer As String
    Public FromSQLDatabase As String
    Public FromSQLUser As String
    Public FromSQLPassword As String
    Public FromSQLconnection As New SqlConnection
    Public FromSQLGlCommand As New SqlCommand
    Public FromSQLDatabaseconnection As String
    ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    ''' \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    '''الربط والاتصال بالداتا بيس التي يتم اليها التحويل
    Public TOSQLServer As String
    Public TOSQLDatabase As String
    Public TOSQLUser As String
    Public TOSQLPassword As String
    Public TOSQLconnection As New SqlConnection
    Public TOSQLGlCommand As New SqlCommand
    Public TOSQLDatabaseconnection As String
    Public Sub SetReportPaper(rv As Microsoft.Reporting.WinForms.ReportViewer)
        Try
            ' الحصول على مسار الـ RDLC
            Dim rdlcPath As String = rv.LocalReport.ReportPath

            If String.IsNullOrEmpty(rdlcPath) OrElse Not IO.File.Exists(rdlcPath) Then
                MessageBox.Show("ملف التقرير غير موجود!")
                Return
            End If

            ' قراءة الـ XML
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(rdlcPath)

            ' الحصول على الـ namespace الافتراضي من الملف
            Dim namespaceUri As String = xmlDoc.DocumentElement.GetAttribute("xmlns")
            If String.IsNullOrEmpty(namespaceUri) Then
                ' إذا لم يكن هناك namespace افتراضي، جرب الأسماءpaces المعروفة
                namespaceUri = "http://schemas.microsoft.com/sqlserver/reporting/2008/01/reportdefinition"
            End If

            ' إعداد الـ Namespace
            Dim nsmgr As New XmlNamespaceManager(xmlDoc.NameTable)
            nsmgr.AddNamespace("ns", namespaceUri)

            ' قراءة الأبعاد باستخدام namespace الديناميكي
            Dim pageHeightNode = xmlDoc.SelectSingleNode("//ns:PageHeight", nsmgr)
            Dim pageWidthNode = xmlDoc.SelectSingleNode("//ns:PageWidth", nsmgr)

            If pageHeightNode Is Nothing OrElse pageWidthNode Is Nothing Then
                MessageBox.Show("لم يتم العثور على أبعاد الصفحة في التقرير!")
                Return
            End If

            ' تحليل القيم - التعامل مع وحدات القياس المختلفة
            Dim pageHeightValue As String = pageHeightNode.InnerText.Trim()
            Dim pageWidthValue As String = pageWidthNode.InnerText.Trim()

            ' تحويل من cm إلى نقاط (points)
            Dim pageHeight As Decimal = ConvertToPoints(pageHeightValue)
            Dim pageWidth As Decimal = ConvertToPoints(pageWidthValue)

            ' تحديد الاتجاه
            Dim isLandscape As Boolean = (pageWidth > pageHeight)

            ' تحديد حجم الورقة
            Dim paperSizeName As String = GetPaperSizeName(pageWidth, pageHeight)
            ' تهيئة القيم الافتراضية للهوامش

            Dim margins = GetReportMargins()


            ' تطبيق الإعدادات
            Dim ps As New System.Drawing.Printing.PageSettings()

            Dim left As Integer = CInt(margins.Left / 25.4D * 100)
            Dim right As Integer = CInt(margins.Right / 25.4D * 100)
            Dim top As Integer = CInt(margins.Top / 25.4D * 100)
            Dim bottom As Integer = CInt(margins.Bottom / 25.4D * 100)

            ps.Margins = New System.Drawing.Printing.Margins(left, right, top, bottom)


            ps.Landscape = isLandscape

            ' البحث عن حجم الورقة أو إنشاءه
            Dim foundPaperSize As Boolean = False
            For Each pSize As System.Drawing.Printing.PaperSize In ps.PrinterSettings.PaperSizes
                If pSize.PaperName.ToUpper().Contains(paperSizeName.ToUpper()) Then
                    ps.PaperSize = pSize
                    foundPaperSize = True
                    Exit For
                End If
            Next

            ' لو مش لاقي الحجم، أنشئه يدوياً
            If Not foundPaperSize Then
                Select Case paperSizeName
                    Case "A4"
                        ps.PaperSize = New System.Drawing.Printing.PaperSize("A4", 827, 1169)
                    Case "A5"
                        ps.PaperSize = New System.Drawing.Printing.PaperSize("A5", 583, 827)
                    Case "A3"
                        ps.PaperSize = New System.Drawing.Printing.PaperSize("A3", 1169, 1654)
                End Select
            End If
            rv.SetPageSettings(ps)
        Catch ex As Exception
            MessageBox.Show("خطأ في إعداد التقرير: " & ex.Message)
        End Try
    End Sub
    Private Function ConvertToPoints(value As String) As Decimal
        ' تحويل القيم من cm إلى نقاط (1 cm = 28.3465 points)
        Dim numericValue As Decimal = Decimal.Parse(Regex.Replace(value, "[^0-9.]", ""))

        If value.Contains("cm") Then
            Return numericValue * 28.3465
        ElseIf value.Contains("in") Then
            Return numericValue * 72 ' 1 inch = 72 points
        Else
            Return numericValue
        End If
    End Function

    Private Function GetPaperSizeName(width As Decimal, height As Decimal) As String
        Dim minDim As Decimal = Math.Min(width, height)
        Dim maxDim As Decimal = Math.Max(width, height)

        ' A4: 21 × 29.7
        If Math.Abs(minDim - 21) < 0.5 AndAlso Math.Abs(maxDim - 29.7) < 0.5 Then
            Return "A4"
            ' A5: 14.8 × 21
        ElseIf Math.Abs(minDim - 14.8) < 0.5 AndAlso Math.Abs(maxDim - 21) < 0.5 Then
            Return "A5"
            ' A3: 29.7 × 42
        ElseIf Math.Abs(minDim - 29.7) < 0.5 AndAlso Math.Abs(maxDim - 42) < 0.5 Then
            Return "A3"
        Else
            Return "A5" ' Default
        End If
    End Function
    Public Function GetReportMargins() As (Top As Decimal, Bottom As Decimal, Left As Decimal, Right As Decimal)
        Dim result As (Top As Decimal, Bottom As Decimal, Left As Decimal, Right As Decimal) = (0D, 0D, 0D, 0D)

        Try
            Dim dt As DataTable = GetRecordSet("SELECT  MarginTop, MarginBottom, MarginLeft, MarginRight FROM dbo.comp_inform")

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                Dim row = dt.Rows(0)

                If Not IsDBNull(row("MarginTop")) Then Decimal.TryParse(row("MarginTop").ToString(), result.Top)
                If Not IsDBNull(row("MarginBottom")) Then Decimal.TryParse(row("MarginBottom").ToString(), result.Bottom)
                If Not IsDBNull(row("MarginLeft")) Then Decimal.TryParse(row("MarginLeft").ToString(), result.Left)
                If Not IsDBNull(row("MarginRight")) Then Decimal.TryParse(row("MarginRight").ToString(), result.Right)
            End If

        Catch ex As Exception

        End Try

        Return result
    End Function
    Public Function GetAppKeys() As (AuthKey As String, AppKey As String, UUID As String)

        Dim result As (AuthKey As String, AppKey As String, UUID As String) =
        (String.Empty, String.Empty, String.Empty)

        Try
            Dim dt As DataTable = GetRecordSet(
            "SELECT AuthKey, AppKey, UUID FROM dbo.comp_inform"
        )

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                Dim row = dt.Rows(0)

                If Not IsDBNull(row("AuthKey")) Then
                    result.AuthKey = row("AuthKey").ToString()
                End If

                If Not IsDBNull(row("AppKey")) Then
                    result.AppKey = row("AppKey").ToString()
                End If

                If Not IsDBNull(row("UUID")) Then
                    result.UUID = row("UUID").ToString()
                End If

            End If

        Catch ex As Exception

        End Try

        Return result

    End Function


    Public Sub Tooltip_Popup(sender As Object, e As PopupEventArgs)
        Dim f As New Font("Calibri", 10, FontStyle.Bold)
        Dim text As String = CType(sender, ToolTip).GetToolTip(e.AssociatedControl)
        Dim size As Size = TextRenderer.MeasureText(text, f)
        e.ToolTipSize = New Size(size.Width + 20, size.Height + 20)
    End Sub
    Public Sub Tooltip_Draw(sender As Object, e As DrawToolTipEventArgs)
        e.Graphics.FillRectangle(New SolidBrush(Color.White), e.Bounds)
        e.Graphics.DrawRectangle(New Pen(Color.Gray), New Rectangle(0, 0, e.Bounds.Width - 1, e.Bounds.Height - 1))
        Dim f As New Font("Calibri", 10, FontStyle.Bold)
        e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, New PointF(10, 5))
    End Sub
    Public Sub OpenDataBaselocal()
        If FromSQLconnection.State = ConnectionState.Open Then FromSQLconnection.Close()
        FromSQLconnection.ConnectionString = FromSQLDatabaseconnection
        FromSQLconnection.Open()
        FromSQLGlCommand.Connection = FromSQLconnection
    End Sub
    Public Function GetRecordSetLocal(ByVal strSQl As String) As DataTable
        Try
            Dim comd As New SqlCommand
            Dim reader As SqlDataAdapter
            Dim datSet As New DataSet
            OpenDataBaselocal()
            comd.Connection = FromSQLconnection
            comd.CommandType = CommandType.Text
            comd.CommandText = strSQl
            reader = New SqlDataAdapter(comd)
            reader.Fill(datSet)
            Return datSet.Tables(0)
        Catch ex As Exception
            Return GetRecordSetLocal
        End Try
    End Function
    Public Sub OpenDataBaseTolocal()
        If TOSQLconnection.State = ConnectionState.Open Then TOSQLconnection.Close()
        TOSQLconnection.ConnectionString = TOSQLDatabaseconnection
        TOSQLconnection.Open()
        TOSQLGlCommand.Connection = TOSQLconnection
    End Sub
    Public Function GetRecordSetToLocal(ByVal strSQl As String) As DataTable
        Try
            Dim comd As New SqlCommand
            Dim reader As SqlDataAdapter
            Dim datSet As New DataSet
            OpenDataBaseTolocal()
            comd.Connection = TOSQLconnection
            comd.CommandType = CommandType.Text
            comd.CommandText = strSQl
            reader = New SqlDataAdapter(comd)
            reader.Fill(datSet)
            Return datSet.Tables(0)
        Catch ex As Exception
            Return GetRecordSetToLocal
        End Try
    End Function
    Public OnLineSqlConnection As String
    Public Function GetAvailableSqlConnection() As String
        Dim candidates As String() = {"173.212.236.248", "37.34.181.64", "37.34.241.133", "173.212.236.248"}
        Dim chosenIP As String = Nothing
        For Each ip In candidates
            If IsTcpPortOpen(ip, 1433, 1500) Then ' مهلة 1.5 ثانية
                chosenIP = ip
                Exit For
            End If
        Next
        If chosenIP Is Nothing Then
            '  ShowServerError()
            Return Nothing
        End If
        OnLineSqlConnection = "Data Source=" & chosenIP & ";Initial Catalog=LICENSE_SAP;Persist Security Info=True;User ID=sa;Password=Hosam0113211587;Connection Timeout=500000000"
        'Try
        Using conn As New SqlConnection(OnLineSqlConnection)
            conn.Open()
            Dim currentServer As String = conn.DataSource
            UpdateServerStatus(currentServer)
        End Using
        'Catch ex As Exception
        '    MessageBox.Show("⚠️ المنفذ مفتوح لكن فشل اتصال SQL: " & ex.Message)
        'End Try
        Return OnLineSqlConnection
    End Function
    Public Function GetAvailableSqlConnection_new() As String
        'Dim candidates As String() = {"173.212.236.248", "37.34.181.64"}
        Dim candidates As String() = {"173.212.236.248", "37.34.181.64", "37.34.241.133", "173.212.236.248"}
        For Each ip In candidates
            If CanConnectToSql(ip, 5) Then ' مهلة 5 ثواني
                Dim connStr As String =
                $"Data Source={ip};Initial Catalog=LICENSE_SAP;User ID=sa;Password=Hosam0113211587;Connection Timeout=10"
                UpdateServerStatus(ip)
                OnLineSqlConnection = connStr
                Return connStr
            End If
        Next
        ShowServerError()
        Return Nothing
    End Function

    Private Function CanConnectToSql(ip As String, timeoutSec As Integer) As Boolean
        Dim connStr As String =
        $"Data Source={ip};Initial Catalog=LICENSE_SAP;User ID=sa;Password=Hosam0113211587;Connection Timeout={timeoutSec}"

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub UpdateServerStatus(serverIP As String)
        Select Case serverIP
            Case "173.212.236.248"
                frmMain.picServerStatus.SizeMode = PictureBoxSizeMode.StretchImage
                'frmMain.picServerStatus.Image = My.Resources.server_main
            Case "37.34.181.64"
                frmMain.picServerStatus.SizeMode = PictureBoxSizeMode.StretchImage
                'frmMain.picServerStatus.Image = My.Resources.server_backup
            Case "173.212.236.248"
                frmMain.picServerStatus.SizeMode = PictureBoxSizeMode.StretchImage
                'frmMain.picServerStatus.Image = My.Resources.server_backup
            Case Else
                frmMain.picServerStatus.Image = Nothing
        End Select
    End Sub
    Private Sub ShowServerError()
        Dim f As New Form()
        f.Text = "لايوجد اتصال مع خدمات الانترنت| No connection to the Internet services  🚨"
        f.Size = New Size(800, 150)
        f.FormBorderStyle = FormBorderStyle.FixedDialog
        f.StartPosition = FormStartPosition.CenterScreen
        f.MaximizeBox = False
        f.MinimizeBox = False
        Dim pic As New PictureBox()
        'pic.Image = My.Resources.icons8servererror100
        pic.SizeMode = PictureBoxSizeMode.Zoom
        pic.Size = New Size(64, 64)
        pic.Location = New Point(-2, -4)
        Dim lblAr As New Label With {
            .Text = "❌لايوجد اتصال مع خدمات الانترنت رجاء التواصل مع الدعم الفني 91111925-90083366-92297481-55181710)" & vbCrLf &
                    "No connection to the Internet services.Please contact technical support at 91111925-90083366-92297481-55181710 ❌",
            .Font = New Font("Cairo", 9, FontStyle.Bold),
            .ForeColor = Color.DarkRed,
            .AutoSize = False,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Top,
            .Height = 100
        }
        f.Controls.Add(pic)
        f.Controls.Add(lblAr)
        f.ShowDialog()
    End Sub
    Private Function IsTcpPortOpen(host As String, port As Integer, timeoutMs As Integer) As Boolean
        Try
            Using client As New TcpClient()
                Dim ar = client.BeginConnect(host, port, Nothing, Nothing)
                Dim ok = ar.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(timeoutMs))
                If Not ok Then Return False
                client.EndConnect(ar)
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function


    'ــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ
    Dim MYSQLgoldOunceUsd As String 'سعر اونص الذهب لالدولار
    Dim MYSQLgoldOunce As String 'سعر الأونصة الذهب
    Dim MYSQLCARET_21 As String 'الجرام عيار 21
    Dim MYSQLCARET_22 As String 'الجرام عيار 2
    Dim MYSQLCARET_23 As String 'الجرام عيار 23
    Dim MYSQLCARET_24 As String 'الجرام عيار 224
    Dim MYSQLSILVER_CARET_22 As String 'فضه
    Dim MYSQLCARET_18 As String 'الجرام عيار 18
    Public CivilIDactivat As String
    Public PriceActivation As String
    Public CpuIdSystemSerialNumber As String
    Public User As String = frmLogin.User_idTextBox.Text ' اليوزرid
    Public StartDate As Date
    Public GetByt As String = "0"
    Public EndDate As Date 'تاريخ انتهاء الترخيص
    ''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public SqlCon As New SqlConnection
    Public SqlCom As New SqlCommand
    Public SqlDataRe As SqlDataReader
    Public DataTab As New DataTable
    Public SqlDataAda As New SqlDataAdapter
    ''''''''''''''''''''''''''''''''''''''''''
    Public MYSQL_Registered_code As String
    '''''''''''''''''''''''''''''''''''''''السيرفر ال اون لاين '''''''''''''''''''''''''''''''''''''''
    Public OnLineSqlGlCom As New SqlCommand
    Public OnLineSqlDataAdapter As SqlDataAdapter
    Public OnLineSqlGlDataset As New DataSet
    Public OnLineSqlDB_conn As New SqlConnection
    Public OnLineSqlDataset As New DataSet
    '''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public LocSqlGlConnection As New SqlConnection
    Public LocSqlGlCom As New SqlCommand
    Public LocSqlDataReder As SqlDataReader
    Public LocSqlDataTable As New DataTable
    Public PrintingPapersNo As String
    Public WhatsappApiLinek As String
    Public UserPermissionsDT As DataTable
    Public UserAppLinkDT As DataTable
    Public GoldLink As String
    Public DigitalCivilIDactivation As Integer
    Public CivilIDactivation As Integer
    Public GoledPriveActivation As Integer

    '''''''''''''''''''''''
    ''خاص بالمصادر الخارجيه

#Region "PaymentMethodsControl"
    Public PaymentMethodsControlForm As PaymentMethodsControl
#End Region

    Public Sub ApiLinek()
        DataTab.Clear()
        SqlCon.ConnectionString = OnLineSqlConnection
        SqlCon.Open()
        SqlCom.Connection = SqlCon
        SqlCom.CommandText = "SELECT [DominName],[DominLink] FROM [TBDominLink] where [DominName] ='WhatsAppApi'"
        SqlDataRe = SqlCom.ExecuteReader
        DataTab.Load(SqlDataRe)
        SqlDataRe.Close()
        SqlCon.Close()
        If DataTab.Rows.Count > 0 Then
            WhatsappApiLinek = DataTab.Rows(0)("DominLink").ToString
        End If
    End Sub
    'مسار التقارير
    Public Sub GetInvoceReportPath(ByVal PathFiled As String)
        Dim ReporFiled As DataTable = GetRecordSet("select * from ReportPath")
        If ReporFiled.Rows.Count > 0 Then
            ReportPath = ReporFiled.Rows(0)(PathFiled).ToString
        End If
    End Sub


    'جدول الاعدادات
    Public Sub GetInvoceReportSettings(ByVal PathFiled As String)
        Dim ReporFiled As DataTable = GetRecordSet("select * from Settings")
        If ReporFiled IsNot Nothing AndAlso ReporFiled.Rows.Count > 0 Then
            ReportPath = ReporFiled.Rows(0)(PathFiled).ToString
        Else
        End If
    End Sub
    Public Function RecordRrrors(ByVal DescriptionRrrors As String) As Boolean
        Try
            GlCommand.CommandText = "INSERT INTO [TBErrorDescription] ([ErrorTime], [ErrorDescription]) VALUES (@ErrorTime, @ErrorDescription)"
            GlCommand.Parameters.Clear()
            GlCommand.Parameters.AddWithValue("@ErrorTime", Format(Date.Now, "dd/MM/yyyy hh:mm:ss tt"))
            GlCommand.Parameters.AddWithValue("@ErrorDescription", DescriptionRrrors)
            GlCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            ' من الأفضل تخزين رسالة الخطأ في ملف خارجي أو سجل داخلي آخر في حال فشل الإدخال في جدول الأخطاء.
            Return False
        End Try
    End Function
    Public Sub ClearControls(ByVal cControls As Windows.Forms.Control.ControlCollection)
        Dim ClearCont As Control
        For Each ClearCont In cControls
            If TypeOf ClearCont Is TextBox Then
                CType(ClearCont, TextBox).Text = ""
            ElseIf TypeOf ClearCont Is ComboBox Then
                CType(ClearCont, ComboBox).Items.Clear()
            ElseIf TypeOf ClearCont Is ListView Then
                CType(ClearCont, ListView).Items.Clear()
            ElseIf TypeOf ClearCont Is CheckBox Then
                CType(ClearCont, CheckBox).Checked = False
            ElseIf TypeOf ClearCont Is ListBox Then
                CType(ClearCont, ListBox).Items.Clear()
            End If
            If ClearCont.Controls.Count > 0 Then ClearControls(ClearCont.Controls)
        Next
    End Sub
    Public Function PrintingPapers()
        Dim DT_PrintingPapers As DataTable = GetRecordSet("SELECT * FROM Settings")
        If DT_PrintingPapers.Rows.Count > 0 Then
            PrintingPapersNo = DT_PrintingPapers.Rows(0)("SET_INVARCHR140").ToString
        End If
    End Function
    Public Function DeleteUpdateSqlCommend(ByVal SqlComm As String) As String
        Try
            If LocSqlGlConnection.State = ConnectionState.Open Then LocSqlGlConnection.Close()
            LocSqlDataTable.Clear()
            LocSqlGlConnection.ConnectionString = SqlServerConnectionString
            LocSqlGlConnection.Open()
            LocSqlGlCom.Connection = LocSqlGlConnection
            LocSqlGlCom.CommandText = SqlComm
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    'تغير لون الفوم
    Public Sub ControlsAsColor(ByVal ColorSelect As Object)
        ColorSelect.BackColor = My.MySettings.Default.ColorSet()
    End Sub
    'تغير لون الخط
    Public NotInheritable Class FontColorManager
        Private Sub New()
        End Sub
        Public Shared Property FontColor As Color
            Get
                Return My.MySettings.Default.FontColor
            End Get
            Set(value As Color)
                My.MySettings.Default.FontColor = value
                My.MySettings.Default.Save()
                RaiseEvent FontColorChanged(value)
            End Set
        End Property
        Public Shared Event FontColorChanged(newColor As Color)
    End Class

    Public Sub OnLineSqlOpenDataBase()
        On Error Resume Next
        If OnLineSqlDB_conn.State = ConnectionState.Open Then OnLineSqlDB_conn.Close()
        OnLineSqlDB_conn.ConnectionString = OnLineSqlConnection
        OnLineSqlDB_conn.Open()
        OnLineSqlGlCom.Connection = OnLineSqlDB_conn
    End Sub
    Public Sub GetCashier(ByVal cmbCashier As ComboBox)
        Dim dt1 As DataTable = GetRecordSet("SELECT [svil_id] , [cacher_name] FROM [cacher] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbCashier.DataSource = dt1
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Public Sub GetFillComboBox(ByVal ComboBoxName As ComboBox, ByVal SqlCom As String, ByVal DisMem As String, ByVal ValMem As String)
        Dim dt1 As DataTable = GetRecordSet(SqlCom)
        If dt1.Rows.Count > 0 Then
            ComboBoxName.DataSource = dt1
            ComboBoxName.DisplayMember = DisMem
            ComboBoxName.ValueMember = ValMem
            ComboBoxName.DropDownWidth = GetMaxDataSize(dt1, DisMem, ComboBoxName)
        End If
    End Sub
    Public Sub GetPayMethod(ByVal cmbPayMethod As ComboBox)
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Public Sub GredFill(ByVal GredFillData As Object, ByVal SqlCom As String)
        Dim dt1 As DataTable = GetRecordSet(SqlCom)
        If dt1.Rows.Count > 0 Then
            GredFillData.DataSource = dt1
        End If
    End Sub
    ''''''''''التشفير
    Public Function Encryptor(ByVal Encrtext As String) As String
        Try
            Dim txt() As Byte = UTF8.GetBytes(Encrtext)
            Dim md5 As New MD5CryptoServiceProvider
            Dim keymd5() As Byte = md5.ComputeHash(UTF8.GetBytes(GetByt))
            Dim trip As New TripleDESCryptoServiceProvider
            trip.Key = keymd5
            trip.Mode = CipherMode.ECB
            trip.Padding = PaddingMode.PKCS7
            Dim trans As ICryptoTransform = trip.CreateEncryptor
            Dim result() As Byte = trans.TransformFinalBlock(txt, 0, txt.Length)
            Encryptor = System.Convert.ToBase64String(result, 0, result.Length)
            Return Encryptor
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    '''''''''''''''''فك التشفيرEncryptor(Encrtext:=(CpuIdSystemSerialNumber))
    Public Function Decryption(ByVal DEncrtext As String) As String
        Try
            Dim txt() As Byte = System.Convert.FromBase64String(DEncrtext)
            Dim md5 As New MD5CryptoServiceProvider
            Dim keymd5() As Byte = md5.ComputeHash(UTF8.GetBytes(GetByt))
            Dim trip As New TripleDESCryptoServiceProvider
            trip.Key = keymd5
            trip.Mode = CipherMode.ECB
            trip.Padding = PaddingMode.PKCS7
            Dim trans As ICryptoTransform = trip.CreateDecryptor
            Dim result() As Byte = trans.TransformFinalBlock(txt, 0, txt.Length)
            Decryption = UTF8.GetString(result)
            Return Decryption
        Catch ex As Exception

        End Try
    End Function
    ''''' شاشه طباعه التقارير
    Public Sub lood_add_price()
        Try
            Dim DT_SetGo_Price As DataTable = GetRecordSet(" SELECT * FROM [TpSetGoledPriceDiff]")
            If DT_SetGo_Price.Rows.Count > 0 Then
                TEXOnceSellUsd = Val(DT_SetGo_Price.Rows(0)("TEXOnceSellUsd"))
                TEXOnceSell = Val(DT_SetGo_Price.Rows(0)("TEXOnceSell"))
                EX24Sell = Val(DT_SetGo_Price.Rows(0)("TEX24Sell"))
                TEX22Sell = Val(DT_SetGo_Price.Rows(0)("TEX22Sell"))
                TTEX21Sell = Val(DT_SetGo_Price.Rows(0)("TEX21Sell"))
                TEX18Sell = Val(DT_SetGo_Price.Rows(0)("TEX18Sell"))
                TEX925Sell = Val(DT_SetGo_Price.Rows(0)("TEX925Sell"))
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                TEXOnceBUYUsd = Val(DT_SetGo_Price.Rows(0)("TEXOnceBUYUsd"))
                TEXOnceBUY = Val(DT_SetGo_Price.Rows(0)("TEXOnceBUY"))
                TEX24BUY = Val(DT_SetGo_Price.Rows(0)("TEX24BUY"))
                TEX22BUY = Val(DT_SetGo_Price.Rows(0)("TEX22BUY"))
                TEX21BUY = Val(DT_SetGo_Price.Rows(0)("TEX21BUY"))
                TEX18BUY = Val(DT_SetGo_Price.Rows(0)("TEX18BUY"))
                TEX925BUY = Val(DT_SetGo_Price.Rows(0)("TEX925BUY"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ADD_CARET_PRICE()
        Try
            Dim SqlCon1 As New SqlConnection
            Dim SqlCom1 As New SqlCommand
            Dim SqlDataRe1 As SqlDataReader
            Dim DataTab1 As New DataTable
            Dim SqlDataAda1 As New SqlDataAdapter
            DataTab1.Clear()
            SqlCon1.ConnectionString = OnLineSqlConnection
            SqlCon1.Open()
            SqlCom1.Connection = SqlCon1
            SqlCom1.CommandText = "SELECT *  FROM ADD_CARET_PRICE"
            SqlDataRe1 = SqlCom1.ExecuteReader
            DataTab1.Load(SqlDataRe1)
            SqlDataRe1.Close()
            SqlCon1.Close()
            MYSQLgoldOunceUsd = DataTab1.Rows(0)("goldOunceUsd").ToString
            MYSQLgoldOunce = DataTab1.Rows(0)("goldOunce").ToString
            MYSQLCARET_18 = DataTab1.Rows(0)("CARET_18").ToString
            MYSQLCARET_21 = DataTab1.Rows(0)("CARET_21").ToString
            MYSQLCARET_22 = DataTab1.Rows(0)("CARET_22").ToString
            MYSQLCARET_23 = DataTab1.Rows(0)("CARET_23").ToString
            MYSQLCARET_24 = DataTab1.Rows(0)("CARET_24").ToString
            MYSQLSILVER_CARET_22 = DataTab1.Rows(0)("SILVER_CARET_22").ToString
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetMySQLData()
        Try
            DataTab.Clear()

            SqlCon.ConnectionString = OnLineSqlConnection
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "SELECT * FROM LICENSE_T WHERE LICENSECode= '" & CpuIdSystemSerialNumber & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            If DataTab.Rows.Count > 0 Then
                frmMain.LebMySqlShopNmae.Text = "(ID) " & (DataTab.Rows(0)("LICENSE_ID").ToString) & " " & (DataTab.Rows(0)("LICENSE_SHOP_NAME").ToString)
                StartDate = DataTab.Rows(0)("LICENSE_START_DATAE").ToString
                EndDate = DataTab.Rows(0)("LICENSE_END_DATAE").ToString
                frmMain.dtEndDate.Value = DataTab.Rows(0)("LICENSE_END_DATAE").ToString
                MYSQL_Registered_code = DataTab.Rows(0)("LICENSECode").ToString
                CivilIDactivat = DataTab.Rows(0)("CivilIDactivation").ToString
                PriceActivation = DataTab.Rows(0)("GoledPriveActivation").ToString
                PriceLinek = DataTab.Rows(0)("PriceLinek").ToString
                PriceCurrency = DataTab.Rows(0)("PriceCurrency").ToString
                GoldLink = DataTab.Rows(0)("Gold_LINK").ToString
                frmMain.lblVersion.Text = DataTab.Rows(0)("VersionNo").ToString
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                'Try
                GlCommand.CommandText = "DELETE FROM [LICENSE_T]"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [LICENSE_T]" & vbCrLf &
                                                   "([LICENSE_ID]" & vbCrLf &
                                                    ",[LICENSE_SHOP_NAME]" & vbCrLf &
                                                    ",[LICENSE_START_DATAE]" & vbCrLf &
                                                    ",[LICENSE_END_DATAE]" & vbCrLf &
                                                    ",[status]" & vbCrLf &
                                                    ",[LICENSEContact_Code]" & vbCrLf &
                                                    ",[PriceLinek]" & vbCrLf &
                                                    ",[PriceCurrency]" & vbCrLf &
                                                    ",[CivilIDactivation]" & vbCrLf &
                                                    ",[GoledPriveActivation]" & vbCrLf &
                                                    ",[WhatsApp_API_LINK]" & vbCrLf &
                                                    ",[Pay_API_LINK]" & vbCrLf &
                                                    ",[Pay_API_Trader_ID]" & vbCrLf &
                                                    ",[Pay_API_Activ]" & vbCrLf &
                                                    ",[LastUpdated]" & vbCrLf &
                                                    ",[Opencount])" & vbCrLf &
                                                     "VALUES " & vbCrLf &
                                                    "(@LICENSE_ID" & vbCrLf &
                                                    ",@LICENSE_SHOP_NAME" & vbCrLf &
                                                    ",@LICENSE_START_DATAE" & vbCrLf &
                                                    ",@LICENSE_END_DATAE" & vbCrLf &
                                                    ",@status" & vbCrLf &
                                                    ",@LICENSEContact_Code" & vbCrLf &
                                                    ",@PriceLinek" & vbCrLf &
                                                    ",@PriceCurrency" & vbCrLf &
                                                    ",@CivilIDactivation" & vbCrLf &
                                                    ",@GoledPriveActivation" & vbCrLf &
                                                    ",@WhatsApp_API_LINK" & vbCrLf &
                                                    ",@Pay_API_LINK" & vbCrLf &
                                                    ",@Pay_API_Trader_ID" & vbCrLf &
                                                    ",@Pay_API_Activ" & vbCrLf &
                                                    ",@LastUpdated" & vbCrLf &
                                                    ",@Opencount)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@LICENSE_ID", Encryptor(Encrtext:=DataTab.Rows(0)("LICENSE_ID").ToString))
                    .AddWithValue("@LICENSE_SHOP_NAME", Encryptor(Encrtext:=DataTab.Rows(0)("LICENSE_SHOP_NAME").ToString))
                    .AddWithValue("@LICENSE_START_DATAE", Encryptor(Encrtext:=DateToSave(StartDate)))
                    .AddWithValue("@LICENSE_END_DATAE", Encryptor(Encrtext:=DateToSave(EndDate)))
                    .AddWithValue("@status", Encryptor(Encrtext:=DataTab.Rows(0)("status").ToString))
                    .AddWithValue("@LICENSEContact_Code", Encryptor(Encrtext:=DataTab.Rows(0)("LICENSECode").ToString))
                    .AddWithValue("@PriceLinek", Encryptor(Encrtext:=DataTab.Rows(0)("PriceLinek").ToString))
                    .AddWithValue("@PriceCurrency", Encryptor(Encrtext:=DataTab.Rows(0)("PriceCurrency").ToString))
                    .AddWithValue("@CivilIDactivation", Encryptor(Encrtext:=DataTab.Rows(0)("CivilIDactivation").ToString))
                    .AddWithValue("@GoledPriveActivation", Encryptor(Encrtext:=DataTab.Rows(0)("GoledPriveActivation").ToString))
                    .AddWithValue("@WhatsApp_API_LINK", Encryptor(Encrtext:=DataTab.Rows(0)("WhatsApp_API_LINK").ToString))
                    .AddWithValue("@Pay_API_LINK", Encryptor(Encrtext:=DataTab.Rows(0)("Pay_API_LINK").ToString))
                    .AddWithValue("@Pay_API_Trader_ID", Encryptor(Encrtext:=DataTab.Rows(0)("Pay_API_Trader_ID").ToString))
                    .AddWithValue("@Pay_API_Activ", Encryptor(Encrtext:=DataTab.Rows(0)("Pay_API_Activ").ToString))
                    .AddWithValue("@LastUpdated", Encryptor(Encrtext:=DateToSave(Date.Now)))
                    .AddWithValue("@Opencount", Encryptor(Encrtext:="5614585"))
                End With
                GlCommand.ExecuteNonQuery()
            Else
                MsgBox("جهاز غير مسجل" & vbCrLf & "Computer not Registered", , AppTitle)
                frmCPUSerial.ShowDialog()
                frmMain.Close()
            End If
        Catch ex As Exception

            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [LICENSE_T] WHERE [LICENSEContact_Code] ='" & Encryptor(Encrtext:=(CpuIdSystemSerialNumber)) & "'")
            If dt1.Rows.Count > 0 Then
                CivilIDactivat = Decryption(dt1.Rows(0)("CivilIDactivation").ToString)
                PriceActivation = Decryption(dt1.Rows(0)("GoledPriveActivation").ToString)
                MYSQL_Registered_code = dt1.Rows(0)("LICENSEContact_Code").ToString
                EndDate = Decryption(dt1.Rows(0)("LICENSE_END_DATAE").ToString)
                PriceLinek = Decryption(dt1.Rows(0)("PriceLinek").ToString)
                PriceCurrency = Decryption(dt1.Rows(0)("PriceCurrency").ToString)
                frmMain.LebMySqlShopNmae.Text = Decryption(dt1.Rows(0)("LICENSE_SHOP_NAME").ToString)
                '''''''''''''''''''''''''''''''''''''''''تقيد عدد مرات الفتح'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim Opencount As Integer = Decryption(dt1.Rows(0)("Opencount").ToString)
                frmMain.LepOpencount.Text = Opencount - "5614575"
                If Opencount <= "5614575" Then
                    MsgBox("لا يوجد اتصال بلانترنت" & vbCrLf & "There is no connection to the Internet.")
                    End
                End If
                GlCommand.CommandText = "UPDATE [LICENSE_T] SET [Opencount]='" & Encryptor(Encrtext:=(Opencount - 1)) & "'"
                GlCommand.ExecuteNonQuery()
            Else
                MsgBox("جهاز غير مسجل" & vbCrLf & "Computer not Registered", , AppTitle)
                frmCPUSerial.ShowDialog()
                frmMain.Close()
            End If
        End Try
    End Sub
    Public Sub ADS_SERVICES_Get_Now()
        If HaveInternetConnection() = True Then
            Try
                Dim mysqlcon As New SqlConnection
                Dim mySqlcmd As New SqlCommand
                Dim myD_Reader As SqlDataReader
                Dim myD_Table As New DataTable
                Dim myD_Adapter As New SqlDataAdapter
                myD_Table.Clear()
                mysqlcon.ConnectionString = OnLineSqlConnection
                mysqlcon.Open()
                mySqlcmd.CommandText = "SELECT * FROM ADS_SERVICES"
                myD_Reader = mySqlcmd.ExecuteReader
                myD_Table.Load(myD_Reader)
                myD_Reader.Close()
                mysqlcon.Close()
                frmMain.lblTechSupport.Text = myD_Table.Rows(0)("TEL").ToString
                frmMain.Update_url = myD_Table.Rows(0)("Update_url").ToString
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                GlCommand.CommandText = "DELETE FROM [ADS_SERVICES]"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [ADS_SERVICES]" & vbCrLf &
                                                  "([ID]" & vbCrLf &
                                                  ",[IMGE1]" & vbCrLf &
                                                  ",[IMGE2]" & vbCrLf &
                                                  ",[IMGE3]" & vbCrLf &
                                                  ",[IMGE4]" & vbCrLf &
                                                  ",[IMGE5]" & vbCrLf &
                                                  ",[IMGE6]" & vbCrLf &
                                                  ",[TEXT_LINE]" & vbCrLf &
                                                  ",[TEL]" & vbCrLf &
                                                  ",[TEL2]" & vbCrLf &
                                                  ",[Update_url])" & vbCrLf &
                                                  "VALUES" & vbCrLf &
                                                  "(@ID" & vbCrLf &
                                                  ",@IMGE1" & vbCrLf &
                                                  ",@IMGE2" & vbCrLf &
                                                  ",@IMGE3" & vbCrLf &
                                                  ",@IMGE4" & vbCrLf &
                                                  ",@IMGE5" & vbCrLf &
                                                  ",@IMGE6" & vbCrLf &
                                                  ",@TEXT_LINE" & vbCrLf &
                                                  ",@TEL" & vbCrLf &
                                                  ",@TEL2" & vbCrLf &
                                                  ",@Update_url)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@ID", myD_Table.Rows(0)("ID").ToString)
                    .AddWithValue("@IMGE1", myD_Table.Rows(0)("IMGE1").ToString)
                    .AddWithValue("@IMGE2", myD_Table.Rows(0)("IMGE2").ToString)
                    .AddWithValue("@IMGE3", myD_Table.Rows(0)("IMGE3").ToString)
                    .AddWithValue("@IMGE4", myD_Table.Rows(0)("IMGE4").ToString)
                    .AddWithValue("@IMGE5", myD_Table.Rows(0)("IMGE5").ToString)
                    .AddWithValue("@IMGE6", myD_Table.Rows(0)("IMGE6").ToString)
                    .AddWithValue("@TEXT_LINE", myD_Table.Rows(0)("TEXT_LINE").ToString)
                    .AddWithValue("@TEL", myD_Table.Rows(0)("TEL").ToString)
                    .AddWithValue("@TEL2", myD_Table.Rows(0)("TEL2").ToString)
                    .AddWithValue("@Update_url", myD_Table.Rows(0)("Update_url").ToString)
                End With
                GlCommand.ExecuteNonQuery()
                Exit Sub
            Catch ex As Exception
                'MsgBox(ex.ToString)
            End Try
        ElseIf HaveInternetConnection() = False Then
            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM ADS_SERVICES ")
            If dt1.Rows.Count > 0 Then
                frmMain.lblTechSupport.Text = dt1.Rows(0)("TEL").ToString
                frmMain.Update_url = Decryption(dt1.Rows(0)("Update_url").ToString)
            Else
            End If
        End If
        Exit Sub
    End Sub
    Public Sub DaysRemaining(ByVal EndDate As Date, ByVal TodayDate As Date)
        Try
            Dim DaysRemaining As New TimeSpan()
            DaysRemaining = (TodayDate - EndDate)
            If DaysRemaining.TotalDays <= "10" Then
                frmMain.LabDayesLeft.Text = "سوف ينتهي اشتراك تشغيل النظام لديكم خلال  " & " " & DaysRemaining.TotalDays & " ايام قادمه." & vbCrLf & "Your System Operating Subscription Will Expire In" & " " & DaysRemaining.TotalDays & " Days Coming.  "
                frmMain.TimDayesLeft.Start()
                frmMain.LabDayesLeft.Visible = True
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub
    'هويتي
    Public Function PostCivilID(ByVal CivilID As String)
        Dim urlPost As String = $"https://pearl-kw.com/v2/api/rest/send-paci-request?token=2d8e14f3a91842cfae7b6b6d29b91d7a&civil_id=" & CivilID & ""
        Using client As HttpClient = New HttpClient()
            Dim post As HttpResponseMessage = client.GetAsync(urlPost).Result
        End Using
    End Function
    Public Function GetCivilID(ByVal GCivilID As String)
        Try
            Dim link As String = "https://pearl-kw.com/v2/api/rest/get-paci-details?token=2d8e14f3a91842cfae7b6b6d29b91d7a&civil_id=" & GCivilID & ""
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync(link).Result
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = response.Content.ReadAsStringAsync().Result
                Dim json = JObject.Parse(responseBody)
                Dim da = json("data")
                Dim da2 = da("civilid_details")
                Dim da3 = da2("MIDAuthSignResponse")
                Dim dafinal = da3("PersonalData")
                Dim dafinal3 = dafinal("Address")
                '''''''''''''''''''''''''''''''''''''''''''
                CivilIDForm.txtCID.Text = dafinal("CivilID").ToString()
                CivilIDForm.txtNameEn.Text = dafinal("FullNameEn").ToString()
                CivilIDForm.txtName.Text = dafinal("FullNameAr").ToString()
                CivilIDForm.txtNationality.Text = dafinal("NationalityAr").ToString()
                CivilIDForm.txtPhone.Text = dafinal("MobileNumber").ToString()
                Dim Area As String = dafinal3("Area").ToString()
                Dim Blok As String = dafinal3("BlockNumber").ToString()
                CivilIDForm.txtAddress.Text = "  المنطقه  " & Area & " " & "   القطعه   " & "   " & Blok
            End Using
        Catch ex As Exception
            RecordRrrors(ex.ToString)
        End Try
    End Function
    Public Sub GredDsin(ByVal GredName As Object)
        GredName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        For Each col As DataGridViewColumn In GredName.Columns
            col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
        GredName.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GredName.AllowUserToAddRows = False
        GredName.MultiSelect = False
        GredName.AllowUserToResizeColumns = False
        GredName.AllowUserToResizeRows = False
        GredName.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GredName.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        For i As Integer = 0 To GredName.Columns.Count - 1
            GredName.Columns(i).HeaderCell.Style.Font = New Font("Calibri", 12, FontStyle.Bold)
        Next
        GredName.RowHeadersVisible = False
        GredName.BorderStyle = BorderStyle.None
        GredName.EnableHeadersVisualStyles = False

        With GredName.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(0, 119, 84)
            .ForeColor = Color.White
            .Font = New Font("Calibri", 12, FontStyle.Bold)
        End With
        GredName.BackgroundColor = Color.LightGray

        With GredName.DefaultCellStyle
            .BackColor = Color.White
            .ForeColor = Color.Black
            .Font = New Font("Calibri", 12, FontStyle.Bold)
            .SelectionBackColor = Color.SteelBlue
            .SelectionForeColor = Color.White
        End With
        GredName.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        GredName.GridColor = Color.Gray
        GredName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        GredName.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
    End Sub
    Public Function HaveInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try
    End Function

    '\\\\\\\\\\\\\\\\\\\\\\\كود الهاردوير للجهار\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


    'تحويل الكود الي هاش
    'Public Function GetSHA256(input As String) As String
    '    Using sha As SHA256 = SHA256.Create()
    '        Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
    '        Dim hash As Byte() = sha.ComputeHash(bytes)
    '        Dim sb As New StringBuilder()
    '        For Each b As Byte In hash
    '            sb.Append(b.ToString("x2")) ' تحويل إلى hex (حروف صغيرة)
    '        Next
    '        Return sb.ToString()
    '    End Using
    'End Function

    Public Function SystemSerialNumber() As String
        Dim wmi As Object = GetObject("WinMgmts:")
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
            serial_numbers.Substring(2)
        Return serial_numbers
    End Function
    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("SELECT * FROM Win32_Processor")
        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
            cpu_ids.Substring(2)
        Return cpu_ids
    End Function
    Public Sub Companylicense()
        Dim dt1 As DataTable = GetRecordSet("SELECT CompanylicenseID FROM [TPCompanylicenseID]")
        If dt1.Rows.Count > 0 Then
            If Not IsDBNull(dt1.Rows(0)("CompanylicenseID")) Then
                licenseID = dt1.Rows(0)("CompanylicenseID").ToString()
            End If
        End If
    End Sub
    Public Sub Permissions()
        Try
            UserPermissionsDT = OnlinGetRecordSet("SELECT * FROM LICENSE_T WHERE LICENSECode= '" & CpuIdSystemSerialNumber & "'")
            If UserPermissionsDT.Rows.Count > 0 Then
                DigitalCivilIDactivation = If(IsDBNull(UserPermissionsDT.Rows(0)("DigitalCivilIDactivation")), 0, CInt(UserPermissionsDT.Rows(0)("DigitalCivilIDactivation")))
                CivilIDactivation = If(IsDBNull(UserPermissionsDT.Rows(0)("CivilIDactivation")), 0, CInt(UserPermissionsDT.Rows(0)("CivilIDactivation")))
                GoledPriveActivation = If(IsDBNull(UserPermissionsDT.Rows(0)("GoledPriveActivation")), 0, CInt(UserPermissionsDT.Rows(0)("GoledPriveActivation")))
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub
    Public Async Function UpdateLicenseIDGoldApiAsync(Optional ct As CancellationToken = Nothing) As Task(Of Integer)

        Try
            Const sql As String = "UPDATE [LICENSE_T]  SET [VersionNo] = @VersionNo, [PriceLinek] = @PriceLinek WHERE [LICENSECode] = @LICENSECode"
            If OnLineSqlGlCom Is Nothing Then
                Throw New InvalidOperationException("OnLineSqlGlCom لم يتم تهيئته.")
            End If
            If OnLineSqlGlCom.Connection Is Nothing Then
                Throw New InvalidOperationException("OnLineSqlGlCom.Connection = Nothing.")
            End If
            If OnLineSqlGlCom.Connection.State <> ConnectionState.Open Then
                Await OnLineSqlGlCom.Connection.OpenAsync(ct).ConfigureAwait(False)
            End If
            OnLineSqlGlCom.Parameters.Clear()
            OnLineSqlGlCom.CommandType = CommandType.Text
            OnLineSqlGlCom.CommandText = sql
            OnLineSqlGlCom.CommandTimeout = 0
            OnLineSqlGlCom.Parameters.Add("@VersionNo", SqlDbType.NVarChar, 50).Value = ("VersionNo" & Format(File.GetLastWriteTime(Application.ExecutablePath), "yyyyMMdd"))
            OnLineSqlGlCom.Parameters.Add("@PriceLinek", SqlDbType.NVarChar, 200).Value = "https://sabprice.live/api/gold-prices"
            OnLineSqlGlCom.Parameters.Add("@LICENSECode", SqlDbType.NVarChar, 100).Value = CpuIdSystemSerialNumber
            Dim affected As Integer =
        Await OnLineSqlGlCom.ExecuteNonQueryAsync(ct).ConfigureAwait(False)
            Return affected
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Function
    Public Async Function UpdateLastOpenAsync(Optional ct As CancellationToken = Nothing) As Task(Of Integer)
        Try
            Const sql As String = "UPDATE [LICENSE_T] Set [LastUpdated] = @LastUpdated WHERE [LICENSECode] = @LicenseCode"
            If OnLineSqlGlCom Is Nothing Then
                Throw New InvalidOperationException("OnLineSqlGlCom لم يتم تهيئته.")
            End If
            If OnLineSqlGlCom.Connection Is Nothing Then
                Throw New InvalidOperationException("OnLineSqlGlCom.Connection = Nothing.")
            End If
            If OnLineSqlGlCom.Connection.State <> ConnectionState.Open Then
                Await OnLineSqlGlCom.Connection.OpenAsync(ct).ConfigureAwait(False)
            End If
            OnLineSqlGlCom.Parameters.Clear()
            OnLineSqlGlCom.CommandType = CommandType.Text
            OnLineSqlGlCom.CommandText = sql
            OnLineSqlGlCom.CommandTimeout = 30
            OnLineSqlGlCom.Parameters.Add("@LastUpdated", SqlDbType.NVarChar, 50).Value = Format(Date.Now, "yyyy-MM-dd hh:mm:ss")
            OnLineSqlGlCom.Parameters.Add("@LICENSECode", SqlDbType.NVarChar, 100).Value = CpuIdSystemSerialNumber
            Dim affected As Integer =
            Await OnLineSqlGlCom.ExecuteNonQueryAsync(ct).ConfigureAwait(False)
            Return affected
        Catch ex As Exception
        End Try
    End Function
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Public PriceLinek As String
    Public PriceCurrency As String
    Public SHOP_NOMPER As String
    Public CurrentCompanyName As String 'اسم الشركة
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    Public CurrencyMainAr As String
    Public CurrencySubAr As String
    Public CurrencyMainEn As String
    Public CurrencySubEnr As String
    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    'تحويل العملة الي الانجليزيه للحفظ في الفاتورة الانجليزيه
    Public Sub GetCurrency()
        Select Case PriceCurrency
            Case ""
                CurrencyMainAr = "دينار كويتي"
                CurrencySubAr = "فلس"
                CurrencyMainEn = "Dinar"
                CurrencySubEnr = "Fils"
            Case "KD"
                CurrencyMainAr = "دينار كويتي"
                CurrencySubAr = "فلس"
                CurrencyMainEn = "Dinar"
                CurrencySubEnr = "Fils"
            Case "QAR"
                CurrencyMainAr = "ريال"
                CurrencySubAr = "درهم"
                CurrencyMainEn = "Riyal"
                CurrencySubEnr = "Dirham"
            Case "TUR"
                CurrencyMainAr = "ليرة"
                CurrencySubAr = "قرش"
                CurrencyMainEn = "Lira"
                CurrencySubEnr = "Piaster"
            Case "EMR"
                CurrencyMainAr = "درهم"
                CurrencySubAr = "فلس"
                CurrencyMainEn = "Dirham"
                CurrencySubEnr = "Fils"
            Case "EGP"
                CurrencyMainAr = "جنيه"
                CurrencySubAr = "قرش"
                CurrencyMainEn = "Pound"
                CurrencySubEnr = "Piaster"
        End Select
    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////
    Public ExcelImportType As String = "" 'لتحديد ملف الإكسل المراد استيراده
    Public Saved As Boolean = False 'للتأكد من الحفظ بعد عمل الفواتير
    Public NewForm As Boolean = False 'للتأكد من بدء تشغيل شاشة عرض الباركود ثم ينقل لآخر صنفين
    Public GoldOrSilver As Boolean = False 'للتحكم في شاشات الذهب أو الفضة
    Public AddItemOnly As Boolean = False 'لإضافة صنف بشكل سريع
    Public ItemBarCode As String 'باركود صنف بشكل سريع
    Public PayInstallmentType As String
    Public SignatureImage As Image
    Public GoldLowestCarat As Single = 18
    Public GoldHighestCarat As Single = 24
    Public SilverLowestCarat As Single = 700
    Public SilverHighestCarat As Single = 999
    Public AppTitle As String = "Golden SAP"
    Public UserName, UserID As String
    Public UILanguage As Char = ""
    Public DeletedInvoice As Boolean = False
    Public AutoUpdatePrice As String
    Public BackupPath As String
    Public BackupHour As String
    Public BackupMinute As String
    Public ManualBackup As Boolean 'للتفرقة بين النسخ الاحتياطي اليدوي والآلي
    Public EditForm As Boolean 'لتغيير حجم شاشة المدنية المعروضة عند التعديل
    'Database
    Public DB_conn As New SqlConnection
    Public datTable As New DataTable, datTableReport As New DataTable, datTableGrid As DataTable
    Public StrSQL, strField, strValue As String
    Public SaveSuccess As Boolean
    ' Counter
    Public Counter As Integer
    ' For Excel Connection
    Public connExcel As OleDbConnection
    Public cmdExcel As OleDbDataAdapter
    Public GlCommand As New SqlCommand
    Public GlDataAdapter As SqlDataAdapter
    Public GlDataset As New DataSet
    Public SQLServerEndDate As Date = CDate(GetRecordSet("SELECT [date] FROM [Licens]").Rows(0)(0).ToString)
    Public Function InvoiceStringNo(ByVal InvoiceNo As Integer) As String 'النص المضاف لرقم الفاتورة
        Dim fileReader As StreamReader
        Dim FileString As String = String.Empty
        Try
            fileReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\inv.txt")
            FileString = fileReader.ReadLine()
            Dim dt2 As DataTable = GetRecordSet("SELECT [SET_INVARCHR147] , [SET2] FROM [Settings]")
            Dim Separator As String = String.Empty
            If dt2.Rows.Count > 0 Then
                Separator = dt2.Rows(0)(0).ToString
                If dt2.Rows(0)(1).ToString = "1" Then
                    InvoiceStringNo = InvoiceNo & Separator & FileString
                Else
                    InvoiceStringNo = FileString & Separator & InvoiceNo
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Sub CheckMySqlDate(ByVal ShopNo As String)
        Dim EndDate As New Date
        EndDate = CDate(frmMain.dtEndDate.Value)
        SaveDataToDB("Licens", "date", Format(EndDate, "yyyy-MM-dd"), 3, "")
        If EndDate < Now.Date Then
            MsgBox("(انتهت فترة الاشتراك بالخدمة لديكم..الرجاء مراجعة الشركة المصممة (91111925,0096567715137," & vbCrLf & "Trial Period Expired, To Renew Please Contact Programmer (0096567715137)", , AppTitle)
            End
        End If
    End Sub
    Public Sub CheckPrivilage(ByVal userID As String)
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [user] WHERE [User_id] = '" & userID & "'")
        If dt1.Rows.Count > 0 Then
            With frmMain
                .btnSell.Enabled = dt1.Rows(0)("chkSell")
                .btnBarCode.Enabled = dt1.Rows(0)("chkBarCode")
                .mnuTransactions.Enabled = dt1.Rows(0)("chkModify")
                .btnKarat.Enabled = dt1.Rows(0)("chkGramPrice")
                '.btnExpense.Enabled = dt1.Rows(0)("chkSalary")
                .btnBuy.Enabled = dt1.Rows(0)("chkWholeSaleBuy")
                .tsUserManagementUser.Enabled = dt1.Rows(0)("chkUsers")
                .tsUserManagementCashier.Enabled = dt1.Rows(0)("chkCashier")
                .btnBulkSell.Enabled = dt1.Rows(0)("chkWholesale")
                .mnuReport.Enabled = dt1.Rows(0)("chkReports")
                .btnExpense.Enabled = dt1.Rows(0)("chkExpenses")
                .btnStock.Enabled = dt1.Rows(0)("chkStock")
                .btnItem.Enabled = dt1.Rows(0)("chkItem")

            End With
        End If
    End Sub
    Public Function ByteToImage(ByVal ByteImage As Byte()) As Image
        Try
            Dim ms As IO.MemoryStream = New IO.MemoryStream(ByteImage)
            Dim img As Image = Image.FromStream(ms)
            Return img
        Catch ex As Exception
        End Try
    End Function
    Public Function ImageToByte(ByVal ImageByte As Image) As Byte()
        Dim imageConverter As New ImageConverter()
        Dim byt As Byte() = DirectCast(imageConverter.ConvertTo(ImageByte, GetType(Byte())), Byte())
        Return byt
    End Function

    'Public Sub ResetIDSeed(ByVal TableName As String, ByVal FieldName As String)
    '    Dim dt1 As DataTable = GetRecordSet("SELECT MAX(" & FieldName & ") FROM " & TableName)
    '    If dt1.Rows.Count > 0 Then
    '        GlCommand.CommandText = "DBCC CHECKIDENT ('" & TableName & "', RESEED, " & If(dt1.Rows(0)(0).ToString = "", "0", dt1.Rows(0)(0).ToString) & ")"
    '        GlCommand.ExecuteNonQuery()
    '    End If
    'End Sub
    Public Sub ResetIDSeed(ByVal TableName As String, ByVal FieldName As String, Optional ByVal StartFrom As Integer = -1)
        Dim reseedValue As Integer
        If StartFrom > 0 Then
            reseedValue = StartFrom - 1
        Else
            Dim dt1 As DataTable = GetRecordSet("SELECT MAX(" & FieldName & ") FROM " & TableName)
            If dt1.Rows.Count > 0 Then
                reseedValue = If(dt1.Rows(0)(0).ToString = "", 0, CInt(dt1.Rows(0)(0)))
            Else
                reseedValue = 0
            End If
        End If
        GlCommand.CommandText = "DBCC CHECKIDENT ('" & TableName & "', RESEED, " & reseedValue & ")"
        GlCommand.ExecuteNonQuery()
    End Sub
    Public Sub GetBackupValues()
        ' قراءة إعدادات النسخ الاحتياطي
        Dim dtSettings As DataTable = GetRecordSet("SELECT [SET_INVARCHR159], [SET_INVARCHR160], [SET_INVARCHR161] FROM [Settings]")
        ' قيم افتراضية
        BackupPath = String.Empty
        BackupHour = "1"
        BackupMinute = "0"
        Dim BackupSet As Boolean = False
        If dtSettings.Rows.Count > 0 Then
            Dim row As DataRow = dtSettings.Rows(0)
            ' مسار النسخ الاحتياطي
            BackupPath = row("SET_INVARCHR159").ToString().Trim()
            ' قراءة الساعة والدقيقة بشكل آمن
            Dim hourVal As Integer
            Dim minuteVal As Integer
            Dim isHourOk As Boolean = Integer.TryParse(row("SET_INVARCHR160").ToString(), hourVal)
            Dim isMinuteOk As Boolean = Integer.TryParse(row("SET_INVARCHR161").ToString(), minuteVal)
            BackupSet = isHourOk AndAlso isMinuteOk
            If BackupSet Then
                ' تنسيق على شكل 00:00
                BackupHour = hourVal.ToString("00")
                BackupMinute = minuteVal.ToString("00")
            End If
        End If
        ' تحديث النص في اللابل حسب تفعيل النسخ الاحتياطي
        If BackupSet Then
            If frmLogin.rbtnAr.Checked = True Then
                frmMain.lblAutoBackup.Text = "النسخ الاحتياطي " & BackupHour & ":" & BackupMinute
            Else
                frmMain.lblAutoBackup.Text = "Auto Backup @ " & BackupHour & ":" & BackupMinute
            End If
        Else
            If frmLogin.rbtnAr.Checked = True Then
                frmMain.lblAutoBackup.Text = "النسخ الاحتياطي الآلي غير مفعل"
            Else
                frmMain.lblAutoBackup.Text = "Auto Backup Not Set"
            End If
        End If
        'Dim dt1 As DataTable = GetRecordSet("SELECT [SET_INVARCHR159] , [SET_INVARCHR160] , [SET_INVARCHR161] FROM [Settings]")
        'If dt1.Rows.Count > 0 Then
        '    BackupPath = dt1.Rows(0)(0).ToString
        '    BackupHour = If(IsNumeric(dt1.Rows(0)(1).ToString), dt1.Rows(0)(1).ToString, "1")
        '    BackupMinute = If(IsNumeric(dt1.Rows(0)(2).ToString), dt1.Rows(0)(2).ToString, "0")
        'End If
        'Dim BackupSet As Boolean = IsNumeric(dtSettings.Rows(0)(1).ToString)
        'If BackupSet Then
        '    If frmLogin.rbtnAr.Checked = True Then
        '        frmMain.lblAutoBackup.Text = " النسخ الاحتياطي " & BackupHour & ":" & BackupMinute
        '    Else
        '        frmMain.lblAutoBackup.Text = "Auto Backup @ " & BackupHour & ":" & BackupMinute
        '    End If
        'Else
        '    If frmLogin.rbtnAr.Checked = True Then
        '        frmMain.lblAutoBackup.Text = "النسخ الاحتياطي الآلي غير مفعل"
        '    Else
        '        frmMain.lblAutoBackup.Text = "Auto Backup Not Set"
        '    End If
        'End If
    End Sub

    Public Function GetMaxDataSize(ByVal dt As DataTable, ByVal FieldName As String, ByVal ComboBoxName As ComboBox) As Integer
        ' لتغيير عرض كومبوبوكس حسب أكبر عنصر فيها
        If ComboBoxName.Items.Count = 0 Then
            Return ComboBoxName.Width + SystemInformation.VerticalScrollBarWidth + 5
            Exit Function
        End If
        Try
            Dim longestItem = dt.AsEnumerable.Select(Function(q) q.Field(Of String)(FieldName)).OrderBy(Function(z) z.Length).Last()
            Dim longestSize = TextRenderer.MeasureText(longestItem, ComboBoxName.Font)
            Return longestSize.Width + SystemInformation.VerticalScrollBarWidth + 5
        Catch ex As Exception
            Return ComboBoxName.Width + SystemInformation.VerticalScrollBarWidth + 5
        End Try
    End Function
#Region "Civil ID"
    Public paci As PACMAN
    Public sc As ServiceController
    Public cardConnected As Boolean = False
    Public CivilIDForm As CivilID
    Public Sub CardServiceStart()
        Try
            sc = New ServiceController("SCardSvr")
            Select Case sc.Status
                Case ServiceControllerStatus.Running
                    paci = New PACMAN()
                    AddHandler paci.ReadersEvent, New PACMAN.ReadersStateChanged(AddressOf Paci_ReadersEvent)
                    AddHandler paci.CardConnectionEvent, New PACMAN.CardConnectionHandler(AddressOf Paci_ConnectionEvent)
                    AddHandler paci.CardDisconnectionEvent, New PACMAN.CardDisconnectionHandler(AddressOf Paci_DisconnectionEvent)
                    cardConnected = True
                Case ServiceControllerStatus.Stopped
                    cardConnected = False
            End Select
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try


    End Sub
    Public Sub Paci_ConnectionEvent(ByVal ReaderIndex As Integer)
        Try
            cardConnected = True
        Catch ex As SmartCardServiceUnavailableException
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Paci_DisconnectionEvent(ByVal ReaderIndex As Integer)
        Try
            cardConnected = False
        Catch ex As SmartCardServiceUnavailableException
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Paci_ReadersEvent()
        Try
            ' cardConnected = False
        Catch ex As SmartCardServiceUnavailableException
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "License"
    Public Sub ke()
        If frmMain.dtEndDate.Value < Now.Date Then
            MsgBox(" (انتهت فترة الصيانة الخاصة بالخدمة لديكم الرجاء مراجعة الشركة المصممة (0096567715137-91111925" & vbCrLf & "Trial Period Expired, To Renew Please Contact Programmer (0096567715137-91111925)", , AppTitle)
            Application.Exit()
        End If

    End Sub
#End Region
#Region "API"
    'Public webAPI As WebBrowser = New WebBrowser
    Public goldOunce As Decimal 'سعر الأونصة الذهب
    Public gold24 As Decimal 'الجرام عيار 24
    Public gold22 As Decimal 'الجرام عيار 22
    Public gold21 As Decimal 'الجرام عيار 21
    Public gold18 As Decimal 'الجرام عيار 18
    Public silverOunce As Decimal 'أونصة الفضة
    Public silverKg As Decimal   ' كيلو الفضه '
    Public OunceUsd As Decimal   'الاونصه بالدولار
    ''' <summary>
    ''' ''''''''''''''''''''''''
    Public goldOuncesell As Decimal 'سعر الأونصة الذهب
    Public gold24sell As Decimal 'الجرام عيار 24
    Public gold22sell As Decimal 'الجرام عيار 22
    Public gold21sell As Decimal 'الجرام عيار 21
    Public gold18sell As Decimal 'الجرام عيار 18
    Public silverOuncesell As Decimal 'أونصة الفضة
    Public silverKgsell As Decimal   ' كيلو الفضه '
    Public OunceUsdsell As Decimal   'الاونصه بالدولار
    ''' </summary>
    Public Sub method_api()

        'Try
        '    Dim client As New WebClient()
        '    Dim json As String = client.DownloadString(PriceLinek & "/" & PriceCurrency)
        '    Dim obj As JObject = JObject.Parse(json)
        '    gold24 = obj("24K_buy").ToString()
        '    gold22 = obj("22K_buy").ToString()
        '    gold21 = obj("21K_buy").ToString()
        '    gold18 = obj("18K_buy").ToString()
        '    OunceUsd = obj("OZK_buy").ToString()
        '    silverKg = obj("S999K_buy").ToString()
        '    '''''''''''''''''''''''''''''''''''''''''''
        '    gold24sell = obj("24K_sell").ToString()
        '    gold22sell = obj("22K_sell").ToString()
        '    gold21sell = obj("21K_sell").ToString()
        '    gold18sell = obj("18K_sell").ToString()
        '    OunceUsdsell = obj("OZK_sell").ToString()
        '    silverKgsell = obj("S999K_sell").ToString()
        '    ''''''''''''''''''''''''''''''''''''''''''''''''''
        '    frmMain.lblOunce.Text = goldOunce + Val(TEXOnceSell.Trim)
        '    frmMain.lbl24.Text = gold24 + Val(EX24Sell.Trim)
        '    frmMain.lbl22.Text = gold22 + Val(TEX22Sell.Trim)
        '    frmMain.lbl21.Text = gold21 + Val(TTEX21Sell.Trim)
        '    frmMain.lbl18.Text = gold18 + Val(TEX18Sell.Trim)
        '    frmMain.lblSilver925.Text = silverKg * 10 / 1000 + Val(TEX925Sell.Trim)
        '    frmMain.lblSellOunceUsd.Text = OunceUsd
        '    frmMain.lblOunce.Text = (gold24 * 31.1)
        '    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '    frmMain.lblOunceBUY.Text = goldOunce + Val(MYSQLgoldOunce.Trim) + Val(TEXOnceBUY.Trim)
        '    frmMain.lbl24BUY.Text = gold24sell + Val(TEX24BUY.Trim)
        '    frmMain.lbl22BUY.Text = gold22sell + Val(TEX22BUY.Trim)
        '    frmMain.lbl21BUY.Text = gold21sell + Val(TEX21BUY.Trim)
        '    frmMain.lbl18BUY.Text = gold18sell + Val(TEX18BUY.Trim)
        '    frmMain.lblSilver925BUY.Text = silverKgsell * 10 / 1000 + Val(TEX925BUY.Trim)
        '    frmMain.lblBuyOunceUsd.Text = OunceUsdsell
        '    frmMain.lblOunceBUY.Text = (gold24sell * 31.1)
        'Catch ex As Exception
        '    RecordRrrors(DescriptionRrrors:=ex.ToString)
        'End Try
    End Sub
    Public Sub GetPricesOffline()
        Dim dt1 As DataTable = GetRecordSet("SELECT [Gram_price] FROM [Gram_val] WHERE [Gram_valu] = N'24'")
        If dt1.Rows.Count > 0 Then
            gold24 = Val(dt1.Rows(0)(0).ToString)
            goldOunce = Math.Round(gold24 * 31.1034807, 3)
            gold22 = Math.Round(gold24 * 22 / 24, 3)
            gold21 = Math.Round(gold24 * 21 / 24, 3)
            gold18 = Math.Round(gold24 * 18 / 24, 3)
        End If
        Dim dt2 As DataTable = GetRecordSet("SELECT [Gram_price] FROM [Gram_val] WHERE [Gram_valu] = N'925'")
        If dt2.Rows.Count > 0 Then
            silverKg = Math.Round(Val(dt2.Rows(0)(0).ToString) * 1000, 4)
        End If

        frmMain.lblOunce.Text = goldOunce
        frmMain.lbl24.Text = gold24
        frmMain.lbl22.Text = gold22
        frmMain.lbl21.Text = gold21
        frmMain.lbl18.Text = gold18
        frmMain.lblSilver925.Text = silverKg / 1000

    End Sub
#End Region
    'Sub logof()
    '    MsgBox("سوف يتم تعطيل البرنامج اذا تم نسخه او نقله", , "تواصل مع مصمم البرنامج0096597715137 ")
    '    Application.Exit()
    'End Sub
    Public Sub msgdin()
        MsgBox("تم الحفظ بنجاح" & vbCrLf & "Saved Successfully", , AppTitle)
    End Sub
    Public Sub msgnotdin()
        MsgBox("لم يتم الحفظ بعض الحقول فارغة" & vbCrLf & "Not Saved, Some Data are Missing", , AppTitle)
    End Sub



    Public mseg_titel As String = AppTitle

    Public LongDateString As String = String.Empty

#Region " DateConverter (dateValue As String) As String "
    Public Function DateConvert(ByVal dateValue As String) As String

        LongDateString = ""

        ' الاحتفاظ بالإعدادت الحالية
        'Dim currentCulture As Globalization.CultureInfo = Threading.Thread.CurrentThread.CurrentCulture

        Dim con As String = ""
        If DateFormating(dateValue) <> "" Then
            dateValue = DateFormating(dateValue)
            '----------------------------------
            Dim y As String = IIf(dateValue <> "", dateValue.Split("/")(2), "")

            Dim mmm() As String
            If y > "1300" And y < "1451" Then
                con = GetGregorianDate(dateValue)
                mmm = Split(GetGregorianDate(dateValue), "/")
                LongDateString = ArabicWeekdayString(Weekday(GetGregorianDate(dateValue))) & " " & mmm(0) & " " & GregorianMonthString(Val(mmm(1))) & " " & mmm(2)
            End If

            If y > "1883" And y < "2029" Then
                con = GetHijriDate(dateValue)
                mmm = Split(con, "/")
                LongDateString = ArabicWeekdayString(Weekday(dateValue)) & " " & mmm(0) & " " & HiriMonthString(Val(mmm(1))) & " " & mmm(2)
            End If

        End If

        ' إستعادة الإعدادت
        'Threading.Thread.CurrentThread.CurrentCulture = currentCulture

        Return con
    End Function
#End Region

#Region " GetHijriDate(GregorianDate As String) As String "
    Private Function GetHijriDate(ByVal GregorianDate As String) As String
        Try

            'Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("ar-eg")

            Dim hijriDate As String = String.Empty

            'Start Date is 10-31-1883
            Dim DaysPan As Integer = DateDiff(DateInterval.Day, New DateTime(1883, 10, 31), CDate(GregorianDate)) + 1
            Dim i As Integer = 0
            Do While DaysPan > 29 + Val(UmmUlquraHijriMonths.Chars(i))
                DaysPan = DaysPan - 29 - Val(UmmUlquraHijriMonths.Chars(i))
                i += 1
            Loop
            hijriDate = Format$(DaysPan, "00") + "/" + Format((i Mod 12) + 1, "00") + "/" + CStr(1301 + (i \ 12))

            Return hijriDate

        Catch ex As Exception
            ' MessageBox.Show("تأكد من التاريخ الميلادي.", "خطأ في التاريخ الميلادي", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)
            Return Nothing
        End Try
    End Function
#End Region

#Region " GetGregorianDate(HijriDate As String) As Date "
    Private Function GetGregorianDate(ByVal HijriDate As String) As String
        Try

            'Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("ar-eg")

            Dim gregorianDate As String = String.Empty

            Dim MonthsPan As Integer
            MonthsPan = (12 * (CInt(Mid(HijriDate, 7, 4)) - 1301)) + CInt(Mid(HijriDate, 4, 2))
            Dim TempDaysPan As Integer
            Dim i As Integer
            For i = 0 To MonthsPan - 2
                TempDaysPan = TempDaysPan + 29 + Val(UmmUlquraHijriMonths.Chars(i))
            Next i
            If CInt(Mid(HijriDate, 1, 2)) > 29 + Val(UmmUlquraHijriMonths.Chars(i)) Then
                MessageBox.Show("رقم اليوم لهذا الشهر يجب أن لا يتجاوز 29", "خطأ اليوم الشهري للتاريخ الهجري", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)
                Return Nothing
            Else
                TempDaysPan += CInt(Mid(HijriDate, 1, 2))
            End If

            'Start Date is 10-31-1883
            gregorianDate = CStr(DateAdd(DateInterval.Day, TempDaysPan - 1, New DateTime(1883, 10, 31)))

            Return gregorianDate

        Catch ex As Exception
            ' MessageBox.Show("تأكد من التاريخ الهجري.", "خطأ في التاريخ الهجري", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign Or MessageBoxOptions.RtlReading)
            Return Nothing
        End Try
    End Function
#End Region

#Region " UmmUlquraHijriMonths "
    'UmmUlquraHijriMonths
    Private Function UmmUlquraHijriMonths() As String
        Dim HijriMonthSequence As String = ""
        'Create the Months data from 1301H to 1450H - (150years)
        HijriMonthSequence += "111010010011" 'Year 1301H
        HijriMonthSequence += "011101001001" 'Year 1302H
        HijriMonthSequence += "011101100100" 'Year 1303H
        HijriMonthSequence += "101101101010" 'Year 1304H
        HijriMonthSequence += "010101110101" 'Year 1305H
        HijriMonthSequence += "010010110110" 'Year 1306H
        HijriMonthSequence += "101001010110" 'Year 1307H
        HijriMonthSequence += "101101001010" 'Year 1308H
        HijriMonthSequence += "110110100100" 'Year 1309H
        HijriMonthSequence += "110111010010" 'Year 1310H
        HijriMonthSequence += "010111011001" 'Year 1311H
        HijriMonthSequence += "001011011100" 'Year 1312H
        HijriMonthSequence += "100101011101" 'Year 1313H
        HijriMonthSequence += "010010101101" 'Year 1314H
        HijriMonthSequence += "101001010101" 'Year 1315H
        HijriMonthSequence += "101101001010" 'Year 1316H
        HijriMonthSequence += "101101101001" 'Year 1317H
        HijriMonthSequence += "010101110100" 'Year 1318H
        HijriMonthSequence += "100101110110" 'Year 1319H
        HijriMonthSequence += "010010110111" 'Year 1320H
        HijriMonthSequence += "001001010111" 'Year 1321H
        HijriMonthSequence += "010100101011" 'Year 1322H
        HijriMonthSequence += "011010010101" 'Year 1323H
        HijriMonthSequence += "011011001010" 'Year 1324H
        HijriMonthSequence += "101011010101" 'Year 1325H
        HijriMonthSequence += "010101011011" 'Year 1326H
        HijriMonthSequence += "001001011101" 'Year 1327H
        HijriMonthSequence += "100100101101" 'Year 1328H
        HijriMonthSequence += "110010010101" 'Year 1329H
        HijriMonthSequence += "110101001010" 'Year 1330H
        HijriMonthSequence += "111010100101" 'Year 1331H
        HijriMonthSequence += "011011010010" 'Year 1332H
        HijriMonthSequence += "101011010101" 'Year 1333H
        HijriMonthSequence += "010101011010" 'Year 1334H
        HijriMonthSequence += "101010101011" 'Year 1335H
        HijriMonthSequence += "010101001011" 'Year 1336H
        HijriMonthSequence += "011010100101" 'Year 1337H
        HijriMonthSequence += "011101010010" 'Year 1338H
        HijriMonthSequence += "101110101001" 'Year 1339H
        HijriMonthSequence += "001101110100" 'Year 1340H
        HijriMonthSequence += "101010110110" 'Year 1341H
        HijriMonthSequence += "010101010110" 'Year 1342H
        HijriMonthSequence += "101010101010" 'Year 1343H
        HijriMonthSequence += "110101010010" 'Year 1344H
        HijriMonthSequence += "110110101001" 'Year 1345H
        HijriMonthSequence += "010111010100" 'Year 1346H
        HijriMonthSequence += "101011101010" 'Year 1347H
        HijriMonthSequence += "010011011101" 'Year 1348H
        HijriMonthSequence += "001001101110" 'Year 1349H
        HijriMonthSequence += "100100101110" 'Year 1350H
        HijriMonthSequence += "101010100110" 'Year 1351H
        HijriMonthSequence += "110101010100" 'Year 1352H
        HijriMonthSequence += "110110101010" 'Year 1353H
        HijriMonthSequence += "010110110101" 'Year 1354H
        HijriMonthSequence += "001010110110" 'Year 1355H
        HijriMonthSequence += "100100110111" 'Year 1356H
        HijriMonthSequence += "010010011011" 'Year 1357H
        HijriMonthSequence += "101001001011" 'Year 1358H
        HijriMonthSequence += "101100100101" 'Year 1359H
        HijriMonthSequence += "101101010100" 'Year 1360H
        HijriMonthSequence += "101101101010" 'Year 1361H
        HijriMonthSequence += "010101101101" 'Year 1362H
        HijriMonthSequence += "010010101101" 'Year 1363H
        HijriMonthSequence += "101001010101" 'Year 1364H
        HijriMonthSequence += "110100100101" 'Year 1365H
        HijriMonthSequence += "111010010010" 'Year 1366H
        HijriMonthSequence += "111011001001" 'Year 1367H
        HijriMonthSequence += "011011010100" 'Year 1368H
        HijriMonthSequence += "101011101010" 'Year 1369H
        HijriMonthSequence += "010101101011" 'Year 1370H
        HijriMonthSequence += "010010101011" 'Year 1371H
        HijriMonthSequence += "011010010101" 'Year 1372H
        HijriMonthSequence += "101101001001" 'Year 1373H
        HijriMonthSequence += "101110100100" 'Year 1374H
        HijriMonthSequence += "101110110010" 'Year 1375H
        HijriMonthSequence += "010110110101" 'Year 1376H
        HijriMonthSequence += "001010111010" 'Year 1377H
        HijriMonthSequence += "100101011011" 'Year 1378H
        HijriMonthSequence += "010010101011" 'Year 1379H
        HijriMonthSequence += "010101010101" 'Year 1380H
        HijriMonthSequence += "011010110010" 'Year 1381H
        HijriMonthSequence += "011011011001" 'Year 1382H
        HijriMonthSequence += "001011101100" 'Year 1383H
        HijriMonthSequence += "100101101110" 'Year 1384H
        HijriMonthSequence += "010010101110" 'Year 1385H
        HijriMonthSequence += "101001010110" 'Year 1386H
        HijriMonthSequence += "110100101010" 'Year 1387H
        HijriMonthSequence += "110101010101" 'Year 1388H
        HijriMonthSequence += "010110101010" 'Year 1389H
        HijriMonthSequence += "101010110101" 'Year 1390H
        HijriMonthSequence += "010010111011" 'Year 1391H
        HijriMonthSequence += "001001011011" 'Year 1392H
        HijriMonthSequence += "100100101011" 'Year 1393H
        HijriMonthSequence += "101010010101" 'Year 1394H
        HijriMonthSequence += "101101001010" 'Year 1395H
        HijriMonthSequence += "101110100101" 'Year 1396H
        HijriMonthSequence += "010110101010" 'Year 1397H
        HijriMonthSequence += "101010110101" 'Year 1398H
        HijriMonthSequence += "010101010110" 'Year 1399H
        HijriMonthSequence += "101010010110" 'Year 1400H
        HijriMonthSequence += "110101001010" 'Year 1401H
        HijriMonthSequence += "111010100101" 'Year 1402H
        HijriMonthSequence += "011101010010" 'Year 1403H
        HijriMonthSequence += "011011101001" 'Year 1404H
        HijriMonthSequence += "001101101010" 'Year 1405H
        HijriMonthSequence += "101010101101" 'Year 1406H
        HijriMonthSequence += "010101010101" 'Year 1407H
        HijriMonthSequence += "101010100101" 'Year 1408H
        HijriMonthSequence += "101101010010" 'Year 1409H
        HijriMonthSequence += "101110101001" 'Year 1410H
        HijriMonthSequence += "010110110100" 'Year 1411H
        HijriMonthSequence += "100110111010" 'Year 1412H
        HijriMonthSequence += "010011011011" 'Year 1413H
        HijriMonthSequence += "001001011101" 'Year 1414H
        HijriMonthSequence += "010100101101" 'Year 1415H
        HijriMonthSequence += "101010100101" 'Year 1416H
        HijriMonthSequence += "101011010100" 'Year 1417H
        HijriMonthSequence += "101011101010" 'Year 1418H
        HijriMonthSequence += "010101101101" 'Year 1419H
        HijriMonthSequence += "010010111101" 'Year 1420H
        HijriMonthSequence += "001000111101" 'Year 1421H
        HijriMonthSequence += "100100011101" 'Year 1422H
        HijriMonthSequence += "101010010101" 'Year 1423H
        HijriMonthSequence += "101101001010" 'Year 1424H
        HijriMonthSequence += "101101011010" 'Year 1425H
        HijriMonthSequence += "010101101101" 'Year 1426H
        HijriMonthSequence += "001010110110" 'Year 1427H
        HijriMonthSequence += "100100111011" 'Year 1428H
        HijriMonthSequence += "010010011011" 'Year 1429H
        HijriMonthSequence += "011001010101" 'Year 1430H
        HijriMonthSequence += "011010101001" 'Year 1431H
        HijriMonthSequence += "011101010100" 'Year 1432H
        HijriMonthSequence += "101101101010" 'Year 1433H
        HijriMonthSequence += "010101101100" 'Year 1434H
        HijriMonthSequence += "101010101101" 'Year 1435H
        HijriMonthSequence += "010101010101" 'Year 1436H
        HijriMonthSequence += "101100101001" 'Year 1437H
        HijriMonthSequence += "101110010010" 'Year 1438H
        HijriMonthSequence += "101110101001" 'Year 1439H
        HijriMonthSequence += "010111010100" 'Year 1440H
        HijriMonthSequence += "101011011010" 'Year 1441H
        HijriMonthSequence += "010101011010" 'Year 1442H
        HijriMonthSequence += "101010101011" 'Year 1443H
        HijriMonthSequence += "010110010101" 'Year 1444H
        HijriMonthSequence += "011101001001" 'Year 1445H
        HijriMonthSequence += "011101100100" 'Year 1446H
        HijriMonthSequence += "101110101010" 'Year 1447H
        HijriMonthSequence += "010110110101" 'Year 1448H
        HijriMonthSequence += "001010110110" 'Year 1449H
        HijriMonthSequence += "101001010110" 'Year 1450H
        Return HijriMonthSequence
    End Function
#End Region

#Region " DateFormating( _Date As String) As String "
    Public Function DateFormating(ByVal _Date As String) As String

        '  / تجزئة نص التاريخ من الفاصل 
        Dim dt() As String = Split(_Date, "/")

        '------------------------------------------------------
        ' في حالة عدم وجود فاصل تاريخ أصلا فيتم المغادرة
        If dt.Length <> 3 Then Return ""

        '------------------------------------------------------
        ' التأكد أن أجزاء التاريخ هي أرقام فعلا
        For i = 0 To dt.Length - 1
            If Not IsNumeric(dt(i)) Then
                Return ""
            End If
        Next i

        '------------------------------------------------------
        ' ترتيب التاريخ بحيث يبدأ باليوم وينتهي السنة
        If Val(dt(0)) > 999 And Val(dt(2)) < 99 Then
            Dim a As String = Val(dt(0))
            Dim b As String = Val(dt(2))
            dt(0) = b : dt(2) = a
        End If

        '------------------------------------------------------
        ' التأكد من عدم تجاوز كل جزء الحدود المسموح له
        If Val(dt(2)) < 1301 Or Val(dt(2)) > 2029 Then Return ""

        ' عدم تجاوز الشهر عن 12
        If Val(dt(1)) < 1 _
        Or Val(dt(1)) > 12 Then
            Return ""
        End If

        ' عدم تجاوز اليوم الهجري عن 30
        If Val(dt(2)) >= 1301 _
        And Val(dt(2)) <= 1450 Then
            If Val(dt(0)) < 1 Or Val(dt(0)) > 30 Then Return ""
        End If

        '------------------------------------------------------

        Dim y As Integer, m As Integer, d As Integer
        d = Val(dt(0)).ToString("00")
        m = Val(dt(1)).ToString("00")
        y = Val(dt(2)).ToString("0000")

        Return Val(dt(0)).ToString("00") _
       & "/" & Val(dt(1)).ToString("00") _
       & "/" & Val(dt(2)).ToString("0000")

    End Function

#End Region

#Region " ArabicWeekdayString "
    Private Function ArabicWeekdayString(ByVal weekdayValue As Integer)
        Dim w As String = String.Empty
        Select Case weekdayValue
            Case 7
                w = ""
            Case 1
                w = ""
            Case 2
                w = ""
            Case 3
                w = ""
            Case 4
                w = ""
            Case 5
                w = ""
            Case 6
                w = ""
        End Select
        Return w
    End Function
#End Region

#Region " HiriMonthString "
    Private Function HiriMonthString(ByVal hijriMonthValue As Integer)
        Dim m As String = String.Empty
        Select Case hijriMonthValue
            Case 1
                m = "محرم"
            Case 2
                m = "صفر"
            Case 3
                m = "ربيع الأول"
            Case 4
                m = "ربيع الثاني"
            Case 5
                m = "جمادى الأولى"
            Case 6
                m = "جمادى الثانية"
            Case 7
                m = "رجب"
            Case 8
                m = "شعبان"
            Case 9
                m = "رمضان"
            Case 10
                m = "شوال"
            Case 11
                m = "ذو القعدة"
            Case 12
                m = "ذو الحجة"
        End Select
        Return m
    End Function
#End Region

#Region " GregorianMonthString "
    Private Function GregorianMonthString(ByVal gregorianMonthValue As Integer)
        Dim m As String = String.Empty
        Select Case gregorianMonthValue
            Case 1
                m = "يناير/كانون الثاني"
            Case 2
                m = "فبراير/شباط"
            Case 3
                m = "مارس/آذار"
            Case 4
                m = "أبريل/نيسان"
            Case 5
                m = "مايو/أيار"
            Case 6
                m = "يونيو/حزيران"
            Case 7
                m = "يوليو/تموز"
            Case 8
                m = "أغسطس/آب"
            Case 9
                m = "سبتمبر/أيلول"
            Case 10
                m = "أكتوبر/تشرين الأول"
            Case 11
                m = "نوفمبر/تشرين الثاني"
            Case 12
                m = "ديسمبر/كانون الأول"
        End Select
        Return m
    End Function
#End Region
    Function kokotxt(ByVal TheNo As Double, ByVal MyCur As String, ByVal MySubCur As String, Optional ByVal Dec3 As Boolean = False) As String
        Dim MyArry1(0 To 9) As String
        Dim MyArry2(0 To 9) As String
        Dim MyArry3(0 To 9) As String
        Dim MyNo As String
        Dim GetNo As String
        Dim RdNo As String
        Dim My100 As String
        Dim My10 As String
        Dim My1 As String
        Dim My11 As String = ""
        Dim My12 As String = ""
        Dim GetTxt As String
        Dim Mybillion As String = ""
        Dim MyMillion As String = ""
        Dim MyThou As String = ""
        Dim MyHun As String = ""
        Dim MyFraction As String = ""
        Dim MyAnd As String
        Dim i As Integer
        Dim ReMark As String = ""
        If Dec3 Then
            If TheNo > 999999999999.999 Then
            End If
        Else
            If TheNo > 999999999999.99 Then

            End If
        End If
        If TheNo = 0 Then
            kokotxt = "صفر"
            Exit Function
        End If
        MyAnd = " و"
        MyArry1(0) = ""
        MyArry1(1) = "مائة"
        MyArry1(2) = "مائتان"
        MyArry1(3) = "ثلاثمائة"
        MyArry1(4) = "أربعمائة"
        MyArry1(5) = "خمسمائة"
        MyArry1(6) = "ستمائة"
        MyArry1(7) = "سبعمائة"
        MyArry1(8) = "ثمانمائة"
        MyArry1(9) = "تسعمائة"
        MyArry2(0) = ""
        MyArry2(1) = " عشر"
        MyArry2(2) = "عشرون"
        MyArry2(3) = "ثلاثون"
        MyArry2(4) = "أربعون"
        MyArry2(5) = "خمسون"
        MyArry2(6) = "ستون"
        MyArry2(7) = "سبعون"
        MyArry2(8) = "ثمانون"
        MyArry2(9) = "تسعون"
        MyArry3(0) = ""
        MyArry3(1) = "واحد"
        MyArry3(2) = "اثنان"
        MyArry3(3) = "ثلاثة"
        MyArry3(4) = "أربعة"
        MyArry3(5) = "خمسة"
        MyArry3(6) = "ستة"
        MyArry3(7) = "سبعة"
        MyArry3(8) = "ثمانية"
        MyArry3(9) = "تسعة"
        '======================
        If Dec3 Then
            GetNo = Format(TheNo, "000000000000.000")
        Else
            GetNo = Format(TheNo, "000000000000.00")
        End If
        i = 0
        Do While i < 15

            If i < 12 Then
                MyNo = Mid$(GetNo, i + 1, 3)
            Else

                If Dec3 Then
                    MyNo = Mid$(GetNo, i + 2, 3)
                Else
                    MyNo = "0" + Mid$(GetNo, i + 2, 3)
                End If
            End If

            If Mid$(MyNo, 1, 3) > 0 Then

                RdNo = Mid$(MyNo, 1, 1)
                My100 = MyArry1(RdNo)
                RdNo = Mid$(MyNo, 3, 1)
                My1 = MyArry3(RdNo)
                RdNo = Mid$(MyNo, 2, 1)
                My10 = MyArry2(RdNo)

                If Mid$(MyNo, 2, 2) = 11 Then My11 = "إحدى عشر"
                If Mid$(MyNo, 2, 2) = 12 Then My12 = "إثنى عشر"
                If Mid$(MyNo, 2, 2) = 10 Then My10 = "عشرة"

                If (Mid$(MyNo, 1, 1) > 0) And (Mid$(MyNo, 2, 2) > 0) Then My100 += MyAnd
                If (Mid$(MyNo, 3, 1) > 0) And (Mid$(MyNo, 2, 1) > 1) Then My1 += MyAnd

                GetTxt = My100 + My1 + My10

                If (Mid$(MyNo, 3, 1) = 1) And (Mid$(MyNo, 2, 1) = 1) Then
                    GetTxt = My100 + My11
                    If Mid$(MyNo, 1, 1) = 0 Then GetTxt = My11
                End If

                If (Mid$(MyNo, 3, 1) = 2) And (Mid$(MyNo, 2, 1) = 1) Then
                    GetTxt = My100 + My12
                    If Mid$(MyNo, 1, 1) = 0 Then GetTxt = My12
                End If

                If (i = 0) And (GetTxt <> "") Then
                    If Mid$(MyNo, 1, 3) > 10 Then
                        Mybillion = GetTxt + " مليار"
                    Else
                        Mybillion = GetTxt + " مليارات"
                        If Mid$(MyNo, 1, 3) = 2 Then Mybillion = " مليار"
                        If Mid$(MyNo, 1, 3) = 2 Then Mybillion = " ملياران"
                    End If
                End If

                If (i = 3) And (GetTxt <> "") Then

                    If Mid$(MyNo, 1, 3) > 10 Then
                        MyMillion = GetTxt + " مليون"
                    Else
                        MyMillion = GetTxt + " ملايين"
                        If Mid$(MyNo, 1, 3) = 1 Then MyMillion = " مليون"
                        If Mid$(MyNo, 1, 3) = 2 Then MyMillion = " مليونان"
                    End If
                End If

                If (i = 6) And (GetTxt <> "") Then
                    If Mid$(MyNo, 1, 3) > 10 Then
                        MyThou = GetTxt + " ألف"
                    Else
                        MyThou = GetTxt + " آلاف"
                        If Mid$(MyNo, 3, 1) = 1 Then MyThou = " ألف"
                        If Mid$(MyNo, 3, 1) = 2 Then MyThou = " ألفان"
                    End If
                End If

                If (i = 9) And (GetTxt <> "") Then MyHun = GetTxt
                If (i = 12) And (GetTxt <> "") Then MyFraction = GetTxt
            End If

            i += 3
        Loop

        If Mybillion <> "" Then
            If (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then Mybillion += MyAnd
        End If

        If MyMillion <> "" Then
            If (MyThou <> "") Or (MyHun <> "") Then MyMillion += MyAnd
        End If

        If MyThou <> "" Then
            If MyHun <> "" Then MyThou += MyAnd
        End If

        If MyFraction <> "" Then
            If (Mybillion <> "") Or (MyMillion <> "") Or (MyThou <> "") Or (MyHun <> "") Then
                kokotxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur + MyAnd + MyFraction + " " + MySubCur
            Else
                kokotxt = ReMark + MyFraction + " " + MySubCur
            End If
        Else
            kokotxt = ReMark + Mybillion + MyMillion + MyThou + MyHun + " " + MyCur
        End If
    End Function
#Region "NoToEnglish"
    Public Function ConvertNumberToENG(ByVal amount As String) As String
        Dim MinCurrency As String
        Dim MinCurrency2 As String
        Dim CurrencyTb As DataTable = GetRecordSet("SELECT * FROM CurrencyType")
        If CurrencyTb.Rows.Count >= 0 Then
            MinCurrency = CurrencyTb.Rows(1)("CurrencyTypeMin").ToString
            MinCurrency2 = CurrencyTb.Rows(1)("CurrencyType").ToString
        End If
        Dim KD As String = ""
        Dim Fils As String = ""
        Dim decimalPlace, count
        Dim place(9) As String
        place(2) = " Thousand "
        place(3) = " Million "
        place(4) = " Billion "
        place(5) = " Trillion "

        ' String representation of amount.
        amount = amount.Trim()
        amount = amount.Replace(",", "")
        ' Position of decimal place 0 if none.
        decimalPlace = amount.IndexOf(".")
        ' Convert cents and set string amount to dollar amount.
        If decimalPlace > 0 Then
            'Fils = GetTens(amount.Substring(decimalPlace + 1).PadRight(2, "0").Substring(0, 2))
            Fils = GetHundreds(amount.Substring(decimalPlace + 1).PadRight(3, "0").Substring(0, 3))
            amount = amount.Substring(0, decimalPlace).Trim()
        End If

        count = 1
        Do While amount <> ""
            Dim temp As String = GetHundreds(amount.Substring(Math.Max(amount.Length, 3) - 3))
            If temp <> "" Then KD = temp & place(count) & KD
            If amount.Length > 3 Then
                amount = amount.Substring(0, amount.Length - 3)
            Else
                amount = ""
            End If
            count += 1
        Loop

        Select Case KD
            Case ""
                KD = " "
            Case "One"
                KD = "One " & " " & MinCurrency
            Case Else
                KD &= " " & MinCurrency
        End Select

        Select Case Fils
            Case ""
                Fils = ""
            Case "One"
                Fils = " and One " & " " & MinCurrency2
            Case Else
                Fils = " and " & " " & Fils & MinCurrency2
        End Select

        ConvertNumberToENG = KD & Fils
    End Function
    Public Function ConvertWeightToENG(ByVal Weight As String) As String
        'Dim MinCurrency As String
        'Dim MinCurrency2 As String
        'Dim CurrencyTb As DataTable = GetRecordSet("SELECT * FROM CurrencyType")
        'If CurrencyTb.Rows.Count >= 0 Then
        '    MinCurrency = CurrencyTb.Rows(1)("CurrencyTypeMin").ToString
        '    MinCurrency2 = CurrencyTb.Rows(1)("CurrencyType").ToString
        'End If
        Dim KD As String = ""
        Dim Fils As String = ""
        Dim decimalPlace, count
        Dim place(9) As String
        place(2) = " Thousand "
        place(3) = " Million "
        place(4) = " Billion "
        place(5) = " Trillion "

        ' String representation of amount.
        Weight = Weight.Trim()
        Weight = Weight.Replace(",", "")
        ' Position of decimal place 0 if none.
        decimalPlace = Weight.IndexOf(".")
        ' Convert cents and set string amount to dollar amount.
        If decimalPlace > 0 Then
            'Fils = GetTens(amount.Substring(decimalPlace + 1).PadRight(2, "0").Substring(0, 2))
            Fils = GetHundreds(Weight.Substring(decimalPlace + 1).PadRight(3, "0").Substring(0, 3))
            Weight = Weight.Substring(0, decimalPlace).Trim()
        End If

        count = 1
        Do While Weight <> ""
            Dim temp As String = GetHundreds(Weight.Substring(Math.Max(Weight.Length, 3) - 3))
            If temp <> "" Then KD = temp & place(count) & KD
            If Weight.Length > 3 Then
                Weight = Weight.Substring(0, Weight.Length - 3)
            Else
                Weight = ""
            End If
            count += 1
        Loop

        Select Case KD
            Case ""
                KD = " "
            Case "One"
                KD = "One " & " " & "Gram"
            Case Else
                KD &= " " & "Gram"
        End Select

        Select Case Fils
            Case ""
                Fils = ""
            Case "One"
                Fils = " and One " & " " & "Milli"
            Case Else
                Fils = " and " & " " & Fils & "Milli"
        End Select

        ConvertWeightToENG = KD & Fils
    End Function


    ' Converts a number from 100-999 into text
    Function GetHundreds(ByVal amount As String) As String
        Dim Result As String = ""
        If Not Integer.Parse(amount) = 0 Then
            amount = amount.PadLeft(3, "0")
            ' Convert the hundreds place.
            If amount.Substring(0, 1) <> "0" Then
                Result = GetDigit(amount.Substring(0, 1)) & " Hundred "
            End If
            ' Convert the tens and ones place.
            If amount.Substring(1, 1) <> "0" Then
                Result &= GetTens(amount.Substring(1))
            Else
                Result &= GetDigit(amount.Substring(2))
            End If
            GetHundreds = Result
        Else
            GetHundreds = ""
        End If

    End Function

    ' Converts a number from 10 to 99 into text.
    Private Function GetTens(ByRef TensText As String) As String
        Dim Result As String
        Result = ""           ' Null out the temporary function value.
        If TensText.StartsWith("1") Then   ' If value between 10-19...
            Select Case Integer.Parse(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Integer.Parse(TensText.Substring(0, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result &= GetDigit(TensText.Substring(1, 1))  ' Retrieve ones place.
        End If
        GetTens = Result
    End Function

    ' Converts a number from 1 to 9 into text.
    Private Function GetDigit(ByRef Digit As String) As String
        Try
            Select Case Integer.Parse(Digit)
                Case 1 : GetDigit = "One"
                Case 2 : GetDigit = "Two"
                Case 3 : GetDigit = "Three"
                Case 4 : GetDigit = "Four"
                Case 5 : GetDigit = "Five"
                Case 6 : GetDigit = "Six"
                Case 7 : GetDigit = "Seven"
                Case 8 : GetDigit = "Eight"
                Case 9 : GetDigit = "Nine"
                Case Else : GetDigit = ""
            End Select
        Catch ex As Exception

        End Try

    End Function

#End Region


    Public Sub OpenDataBase()
        'On Error Resume Next
        If DB_conn.State = ConnectionState.Open Then DB_conn.Close()
        DB_conn.ConnectionString = SqlServerConnectionString
        DB_conn.Open()
        GlCommand.Connection = DB_conn
    End Sub



    Public Function GetRecordSet(ByVal strSQl As String) As DataTable
        Try
            Dim comd As New SqlCommand
            Dim reader As SqlDataAdapter
            Dim datSet As New DataSet
            OpenDataBase()
            comd.Connection = DB_conn
            comd.CommandType = CommandType.Text
            comd.CommandText = strSQl
            comd.CommandTimeout = 0
            reader = New SqlDataAdapter(comd)
            reader.Fill(datSet)
            Return datSet.Tables(0)
        Catch ex As Exception
            Return GetRecordSet
        End Try
    End Function


    Public Function OnlinGetRecordSet(ByVal strSQl As String) As DataTable
        Try
            Dim comd As New SqlCommand
            Dim reader As SqlDataAdapter
            Dim datSet As New DataSet
            OnLineSqlOpenDataBase()
            comd.Connection = OnLineSqlDB_conn
            comd.CommandType = CommandType.Text
            comd.CommandText = strSQl
            comd.CommandTimeout = 0
            reader = New SqlDataAdapter(comd)
            reader.Fill(datSet)
            Return datSet.Tables(0)
        Catch ex As Exception
            Return OnlinGetRecordSet
        End Try
    End Function
    Public Sub SaveDataToDB(ByVal TblName As String, ByVal TblFieldName As String, ByVal strDataValue As String, ByVal nOperationKind As Integer, ByVal strCondition As String)
        ' nOperationKind   0 UPDATE Or INSERT
        '                  1 DELETE
        '                  2 INSERT ONLY
        '                  3 UPDATE ONLY
        On Error GoTo 0
        If Left(TblName, 1) <> "[" Then
            TblName = "[" & TblName & "]"
        End If
        Dim strFiledAr() As String = Split(TblFieldName, ",")
        Dim strDataValueAr() As String = Split(strDataValue, ",")
        TblFieldName = ""
        strDataValue = ""
        For i As Integer = 0 To UBound(strFiledAr)
            If Left(strFiledAr(i), 1) <> "[" Then strFiledAr(i) = "[" & strFiledAr(i) & "]"
            If Left(strDataValueAr(i), 1) <> "[" Then strDataValueAr(i) = "'" & strDataValueAr(i) & "'"
            TblFieldName &= strFiledAr(i)
            strDataValue &= strDataValueAr(i)
        Next

        Select Case nOperationKind
            Case 0    ' for UPDATE or INSERT
                StrSQL = " UPDATE " & TblName & " SET  "
                For i = 0 To UBound(strFiledAr)
                    StrSQL = StrSQL & strFiledAr(i) & " = " & strDataValueAr(i) & ", "
                Next
                StrSQL = Left(StrSQL, Len(StrSQL) - 2)
                If Trim(strCondition) <> "" Then
                    StrSQL = StrSQL & " WHERE " & strCondition
                End If
                StrSQL &= vbCrLf & " IF @@ROWCOUNT = 0 " & vbCrLf & " INSERT INTO " & TblName & " (" & TblFieldName & ") VALUES (" & strDataValue & ")"
            Case 1    ' for DELETE
                If strCondition <> "" Then
                    StrSQL = " DELETE  FROM " & TblName & " WHERE " & strCondition
                Else
                    StrSQL = " DELETE  FROM " & TblName
                End If

            Case 2    ' for INSERT ONLY
                StrSQL = "INSERT INTO " & TblName & " (" & TblFieldName & ") VALUES (" & strDataValue & ")"
            Case 3    ' for UPDATE ONLY
                strFiledAr = Split(TblFieldName, ",")
                strDataValueAr = Split(strDataValue, ",")
                StrSQL = " UPDATE  " & TblName & " SET  "
                For i = 0 To UBound(strFiledAr)
                    StrSQL = StrSQL & strFiledAr(i) & " = " & strDataValueAr(i) & ", "
                Next
                StrSQL = Left(StrSQL, Len(StrSQL) - 2)
                If Trim(strCondition) <> "" Then
                    StrSQL = StrSQL & " WHERE " & strCondition
                End If
        End Select
        Dim comd As New SqlCommand
        comd.Connection = DB_conn
        OpenDataBase()
        comd.CommandType = CommandType.Text
        comd.CommandText = StrSQL
        Counter += comd.ExecuteNonQuery()
    End Sub

    Function GetNextCounter(ByVal strTable As String, ByVal strTableField As String, ByVal CondStr As String) As Integer
        StrSQL = "SELECT MAX(" & strTableField & ") FROM " & strTable & CondStr
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count() > 0 Then
            Dim dv As New DataView(datTable)
            If dv.Table.Rows.Count > 0 Then
                GetNextCounter = IIf(IsDBNull(dv(0)(0)), 0, dv(0)(0)) + 1
            Else
                GetNextCounter = 1
            End If
        Else
            GetNextCounter = 1
        End If
    End Function


    Function GetRecordCount(ByVal strTable As String, Optional ByVal CondStr As String = "") As Integer
        datTable = GetRecordSet("SELECT * FROM " & strTable & CondStr)
        GetRecordCount = datTable.Rows.Count()
    End Function

    Public Sub SQLFillListValue(ByRef LstName As ListBox, ByRef TabName As String, ByRef FieldName As String, ByRef ItemName As String, ByRef strCond As String)
        LstName.Items.Clear()
        StrSQL = "SELECT " & FieldName & "," & ItemName & " FROM " & TabName & " " & strCond
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count() > 0 Then
            Dim dv1 As New DataView(datTable)
            For icount As Integer = 0 To datTable.Rows.Count() - 1
                LstName.Items.Add(New MyList(dv1(icount)(FieldName), dv1(icount)(ItemName)))
            Next
        End If
    End Sub
    Public Sub SQLFillList(ByRef LstName As ListBox, ByRef TabName As String, ByRef FieldName As String, ByRef ItemName As String, ByRef strCond As String)
        LstName.Items.Clear()
        StrSQL = "SELECT " & FieldName & "," & ItemName & " FROM " & TabName & " " & strCond
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count() > 0 Then
            Dim dv1 As New DataView(datTable)
            For lcount As Integer = 0 To datTable.Rows.Count() - 1
                LstName.Items.Add(New MyList(dv1(lcount)(FieldName), ""))
            Next
        End If
    End Sub

    Public Sub FillList(ByVal lstBox As ListControl, ByVal TableName As String, ByVal FieldText As String, ByVal FieldValue As String, Optional ByVal Condition As String = "")
        StrSQL = "SELECT [" & FieldText & "] , [" & FieldValue & "] FROM " & TableName & " " & Condition
        Dim dast As New SqlDataAdapter(StrSQL, DB_conn)
        Dim dsst As New DataSet
        dast.Fill(dsst)
        With lstBox
            .DataSource = Nothing
            .DisplayMember = FieldText
            .ValueMember = FieldValue
            .DataSource = dsst.Tables(0)
        End With
    End Sub
    Public Sub SQLFillDataGridView(ByVal grid As DataGridView, ByVal TableName As String, ByVal FieldText As String, Optional ByVal Condition As String = "")
        StrSQL = "SELECT " & FieldText & " FROM " & TableName & " " & Condition
        If Left(TableName, 1) <> "[" Then
            TableName = "[" & TableName & "]"
        End If
        Dim FieldTextAr() As String = Split(FieldText, ",")
        FieldText = ""
        For i As Integer = 0 To UBound(FieldTextAr)
            If Left(FieldTextAr(i), 1) <> "[" Then FieldTextAr(i) = "[" & FieldTextAr(i) & "]"
            FieldText &= FieldTextAr(i)
        Next
        Dim dast As New SqlDataAdapter(StrSQL, DB_conn)
        Dim dsst As New DataSet
        dast.Fill(dsst)
        With grid
            .DataSource = Nothing
            .DataSource = dsst.Tables(0)
        End With
    End Sub

    Public Sub FillListDataGridView(ByVal lstBox As DataGridViewComboBoxColumn, ByVal TableName As String, ByVal FieldText As String, ByVal FieldValue As String, Optional ByVal Condition As String = "")
        StrSQL = "SELECT [" & FieldText & "] , [" & FieldValue & "] FROM " & TableName & " " & Condition
        Dim dast As New SqlDataAdapter(StrSQL, DB_conn)
        Dim dsst As New DataSet
        dast.Fill(dsst)
        With lstBox
            .DataSource = Nothing
            .DisplayMember = FieldText
            .ValueMember = FieldValue
            .DataSource = dsst.Tables(0)
        End With
    End Sub

    Public Sub FillcheckedList(ByVal lstBox As CheckedListBox, ByVal TableName As String, ByVal FieldText As String, ByVal FieldValue As String, Optional ByVal Condition As String = "")
        StrSQL = "SELECT [" & FieldText & "] , [" & FieldValue & "] FROM " & TableName & " " & Condition
        Dim dast As New SqlDataAdapter(StrSQL, DB_conn)
        Dim dsst As New DataSet
        dast.Fill(dsst)
        With lstBox
            .DisplayMember = FieldText
            .ValueMember = FieldValue
            .DataSource = dsst.Tables(0)
        End With
    End Sub

    Public Function TempImagePath(ByVal PictureBoxName As PictureBox) As String
        TempImagePath = Left(IO.Path.GetTempFileName, IO.Path.GetTempFileName.Length - 3) & "jpg"
        Dim TempPictureBox As New PictureBox
        If IsNothing(PictureBoxName.Image) = False Then
            With TempPictureBox
                .Image = New Bitmap(PictureBoxName.Image, 300, 300)
                .Image.Save(TempImagePath)
            End With
        End If
    End Function

    Private Function SHorof(ByVal X As Double) As String
        Dim n As String
        Dim c As String
        Dim C1 As Double
        Dim C2 As Double
        Dim C3 As Double
        Dim C4 As Double
        Dim C5 As Double
        Dim C6 As Double
        Dim Letter1 As String = ""
        Dim Letter2 As String = ""
        Dim Letter3 As String = ""
        Dim Letter4 As String = ""
        Dim Letter5 As String = ""
        Dim Letter6 As String = ""

        n = CStr(Int(X))
        c = Format(n, "000000000000")
        C1 = Val(Mid(c, 12, 1))
        Select Case C1
            Case Is = 1 : Letter1 = "واحد"
            Case Is = 2 : Letter1 = "اثنان"
            Case Is = 3 : Letter1 = "ثلاثة"
            Case Is = 4 : Letter1 = "اربعة"
            Case Is = 5 : Letter1 = "خمسة"
            Case Is = 6 : Letter1 = "ستة"
            Case Is = 7 : Letter1 = "سبعة"
            Case Is = 8 : Letter1 = "ثمانية"
            Case Is = 9 : Letter1 = "تسعة"
        End Select

        C2 = Val(Mid(c, 11, 1))
        Select Case C2
            Case Is = 1 : Letter2 = "عشر"
            Case Is = 2 : Letter2 = "عشرون"
            Case Is = 3 : Letter2 = "ثلاثون"
            Case Is = 4 : Letter2 = "اربعون"
            Case Is = 5 : Letter2 = "خمسون"
            Case Is = 6 : Letter2 = "ستون"
            Case Is = 7 : Letter2 = "سبعون"
            Case Is = 8 : Letter2 = "ثمانون"
            Case Is = 9 : Letter2 = "تسعون"
        End Select

        If Letter1 <> "" And C2 > 1 Then Letter2 = Letter1 + " و" + Letter2
        If Letter2 = "" Then Letter2 = Letter1
        If C1 = 0 And C2 = 1 Then Letter2 += " Thenة"
        If C1 = 1 And C2 = 1 Then Letter2 = "احدى عشر"
        If C1 = 2 And C2 = 1 Then Letter2 = " Thenاثنى عشر"
        If C1 > 2 And C2 = 1 Then Letter2 = Letter1 + " " + Letter2
        C3 = Val(Mid(c, 10, 1))
        Select Case C3
            Case Is = 1 : Letter3 = "مائة"
            Case Is = 2 : Letter3 = "مئتان"
            Case Is > 2 : Letter3 = Left(SHorof(C3), Len(SHorof(C3)) - 1) + "مائة"
        End Select
        If Letter3 <> "" And Letter2 <> "" Then Letter3 = Letter3 + " و" + Letter2
        If Letter3 = "" Then Letter3 = Letter2

        C4 = Val(Mid(c, 7, 3))
        Select Case C4
            Case Is = 1 : Letter4 = "الف"
            Case Is = 2 : Letter4 = "الفان"
            Case 3 To 10 : Letter4 = SHorof(C4) + " آلاف"
            Case Is > 10 : Letter4 = SHorof(C4) + " الف"
        End Select
        If Letter4 <> "" And Letter3 <> "" Then Letter4 = Letter4 + " و" + Letter3
        If Letter4 = "" Then Letter4 = Letter3
        C5 = Val(Mid(c, 4, 3))
        Select Case C5
            Case Is = 1 : Letter5 = "مليون"
            Case Is = 2 : Letter5 = "مليونان"
            Case 3 To 10 : Letter5 = SHorof(C5) + " ملايين"
            Case Is > 10 : Letter5 = SHorof(C5) + " مليون"
        End Select
        If Letter5 <> "" And Letter4 <> "" Then Letter5 = Letter5 + " و" + Letter4
        If Letter5 = "" Then Letter5 = Letter4

        C6 = Val(Mid(c, 1, 3))
        Select Case C6
            Case Is = 1 : Letter6 = "مليار"
            Case Is = 2 : Letter6 = "ملياران"
            Case Is > 2 : Letter6 = SHorof(C6) + " مليار"
        End Select
        If Letter6 <> "" And Letter5 <> "" Then Letter6 = Letter6 + " و" + Letter5
        If Letter6 = "" Then Letter6 = Letter5
        SHorof = Letter6

    End Function

    Public Function Horof(ByVal X As String) As String
        Dim Ma As String
        Dim Mi As String
        Dim ml As String
        Dim Mn As String
        Dim n As String
        Dim b As Double
        Dim r As String
        Dim b1 As String
        Dim result As Object = Nothing


        ' هذه المديول تقوم بكتابة الأرقام بالعربية بالدينار الكويتي
        Ma = " دينار"
        Mi = " فلس"
        ml = " فلسات"
        Mn = " دنانير"

        n = CStr(Int(X))
        b = Val(Right(Format(X, "000000000000.000"), 3))

        r = CStr(SHorof(n))         ' الصحيح
        b1 = SHorof(b)   'الكسر العشري

        If r <> "" And b >= 0 Then result = r & Ma & " و " & b1 & Mi & " فقط لا غير "
        If r <> "" And b <= 9 And b >= 1 Then result = r & Ma & " و" & b1 & ml & " فقط لا غير "
        If r = "" And b <> 0 Then result = b1 & Mi & " فقط لا غير "
        If r = "" And b = 0 Then result = " صفر"
        If r <> "" And b = 0 Then result = r & Ma & " فقط لا غير "
        Horof = CStr(result)

    End Function

    Public Function Question(ByVal MessageText As String) As MsgBoxResult
        Question = MsgBox(MessageText, vbQuestion Or MessageBoxOptions.RtlReading Or MessageBoxOptions.RightAlign Or vbYesNo, AppTitle)
    End Function
    Public Sub Message(ByVal MessageText As String, Optional ByVal MsgIcon As MessageBoxIcon = MessageBoxIcon.Information)
        MessageBox.Show(MessageText, AppTitle, MessageBoxButtons.OK, MsgIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading Or MessageBoxOptions.RightAlign)
    End Sub
    Public Sub Exclamation(ByVal MessageText As String, Optional ByVal MsgIcon As MessageBoxIcon = MessageBoxIcon.Exclamation)
        MessageBox.Show(MessageText, AppTitle, MessageBoxButtons.OK, MsgIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading Or MessageBoxOptions.RightAlign)
    End Sub
    Function GetLastRecord(ByVal strTable As String, ByVal strTableField As String, ByVal strIntNo As String, ByVal CondStr As String) As String
        StrSQL = "Select " & strTableField & " FROM " & strTable & CondStr & " ORDER BY " & strIntNo & " DESC"
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count() > 0 Then
            Dim dv As New DataView(datTable)
            If dv.Table.Rows.Count > 0 Then
                GetLastRecord = If(IsDBNull(dv(0)(0)), "", dv(0)(strTableField))
            Else
                GetLastRecord = ""
            End If
        Else
            GetLastRecord = ""
        End If
    End Function


    Public Function DateToSave(ByVal DString As String) As String
        If DString <> "" Then
            Return Format(Date.Parse(DString), "yyyy/MM/dd")
        Else
            Return Format(Date.Parse(Now), "yyyy/MM/dd")
        End If
    End Function
    Public Function DateToView(ByVal DString As String) As String
        If DString <> "" Then
            Return Format(Date.Parse(DString), "yyyy/MM/dd")
        Else
            Return Format(Date.Parse(Now), "yyyy/MM/dd")
        End If
    End Function
    Public Function DateTimeToView(ByVal DString As String) As String
        If DString <> "" Then
            Return Format(Date.Parse(DString), "dd/MM/yyyy hh:mm:ss tt")
        Else
            Return Format(Date.Parse(Now), "dd/MM/yyyy hh:mm:ss tt")
        End If
    End Function
    Public Function TimeToSave(ByVal DString As String) As String
        If DString <> "" Then
            Return Format(Date.Parse(DString), "HH:mm")
        Else
            Return Format(Date.Parse(Now), "HH:mm")
        End If
    End Function
    Public Function TimeToView(ByVal DString As String) As String
        If DString <> "" Then
            Return Format(Date.Parse(DString), "hh:mm t")
        Else
            Return Format(Date.Parse(Now), "hh:mm t")
        End If
    End Function
    Public Function TimeToDTPicker(ByVal DString As String) As String
        Return Now.Date & " " & CDate(DString).ToShortTimeString
    End Function
    Public Sub ValidateTextbox(ByVal Cntrl As Control, ByVal Type As Integer, ByRef e As KeyPressEventArgs)
        ''''Type''''
        ' 0 Default
        ' 1 Letters Only  احرف وارقام
        ' 2 Integer numbers Only    ارقام فقط
        ' 3 Decimal numbers    رقم عرشري
        Select Case Type
            Case 0
                If Char.IsLetterOrDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Then
                    e.Handled = False
                ElseIf Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "_" Or e.KeyChar = "@" _
                        Or e.KeyChar = "-" Or e.KeyChar = "/" Or e.KeyChar = "\" Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case 1
                If Not Char.IsLetter(e.KeyChar) Then
                    If e.KeyChar = ChrW(Keys.Back) Or Char.IsWhiteSpace(e.KeyChar) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            Case 2
                If Char.IsNumber(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            Case 3
                If e.KeyChar = "." Then
                    If CType(Cntrl, TextBox).Text = "" Then
                        CType(Cntrl, TextBox).Text = "0."
                        e.Handled = True
                        CType(Cntrl, TextBox).SelectionStart = Cntrl.Text.Length
                    Else
                        If CType(Cntrl, TextBox).Text.Contains(".") Then
                            e.Handled = True
                        End If
                    End If
                ElseIf Not (IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter)) Then
                    e.Handled = True
                End If
        End Select
    End Sub

    Public Function SelectData(ByVal nSelect As Integer, ByRef Datacounter As Integer, ByVal TableName As String, ByVal Condintion As String, ByVal OrderField As String, ByVal ReturnedFieldIntno As String) As Integer
        'nselect
        ' 1 for First record
        ' 2 for Next record
        ' 3 for previous record
        ' 4 for last record

        SelectData = 0
        If Trim(Condintion) = "" Then
            StrSQL = "SELECT * FROM " & TableName & " ORDER BY " & OrderField & " ASC"
        Else
            StrSQL = "SELECT * FROM " & TableName & " WHERE  " & Condintion & " ORDER BY " & OrderField & " ASC"
        End If
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count() > 0 Then
            Dim DV_Data As New DataView(datTable)
            Select Case nSelect
                Case 4 'Last Record
                    Datacounter = DV_Data.Count - 1
                Case 3 'Next  Record
                    If Datacounter < DV_Data.Count - 1 Then
                        Datacounter += 1
                    Else
                        Datacounter = 0
                    End If
                Case 2 'Previous Record
                    If Datacounter > 0 Then
                        Datacounter -= 1
                    Else
                        Datacounter = DV_Data.Count - 1
                    End If
                Case 1 'First Record
                    Datacounter = 0
            End Select
            SelectData = DV_Data(Datacounter)(ReturnedFieldIntno)
        End If
        Return SelectData
    End Function
    Public Sub TextLanguage(ByVal LanguageName As String)
        For Each Lng As InputLanguage In InputLanguage.InstalledInputLanguages
            Select Case LanguageName.ToUpper
                Case "ARABIC"
                    If Lng.Culture.EnglishName.ToUpper.StartsWith("ARA") Then
                        InputLanguage.CurrentInputLanguage = Lng
                        Exit For
                    End If
                Case "ENGLISH"
                    If Lng.Culture.EnglishName.ToUpper.StartsWith("EN") Then
                        InputLanguage.CurrentInputLanguage = Lng
                        Exit For
                    End If
            End Select
        Next
    End Sub
    Public Sub SQLFillCombo(ByRef LstName As ComboBox, ByRef TabName As String, ByRef FieldName As String, ByRef strCond As String)
        LstName.Items.Clear()
        StrSQL = "SELECT " & FieldName & " FROM " & TabName & " " & strCond
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        If dt1.Rows.Count > 0 Then
            For i As Integer = 0 To dt1.Rows.Count - 1
                LstName.Items.Add(dt1.Rows(i)(0).ToString)
            Next
        End If
    End Sub
    Public Sub SQLFillComboValue(ByRef LstName As ComboBox, ByRef TabName As String, ByRef FieldName As String, ByRef ItemName As String, ByRef strCond As String)
        LstName.Items.Clear()
        StrSQL = "SELECT " & FieldName & "," & ItemName & " FROM " & TabName & " " & strCond
        datTable = GetRecordSet(StrSQL)
        If datTable.Rows.Count > 0 Then
            Dim dv1 As New DataView(datTable)
            For i As Integer = 0 To datTable.Rows.Count - 1
                LstName.Items.Add(New MyList(dv1(i)(FieldName).ToString, dv1(i)(ItemName).ToString))
            Next
        End If
    End Sub
    Public Sub ClearControls(ByVal Container As Control)
        For Each cc As Control In Container.Controls
            If TypeOf cc Is TextBox Then CType(cc, TextBox).Text = ""
            If TypeOf cc Is ComboBox Then CType(cc, ComboBox).SelectedIndex = -1
            If TypeOf cc Is DateTimePicker Then CType(cc, DateTimePicker).Value = Now
            If TypeOf cc Is RichTextBox Then CType(cc, RichTextBox).Text = ""
            If TypeOf cc Is PictureBox Then CType(cc, PictureBox).Image = Nothing
        Next
    End Sub
    Public Sub ClearControlsOnlyTextBox(ByVal Container As Control)
        For Each cc As Control In Container.Controls
            If TypeOf cc Is TextBox Then CType(cc, TextBox).Text = ""
        Next
    End Sub
    Public Sub ClearTextBox(ByVal Container As Control)
        For Each cc As Control In Container.Controls
            If TypeOf cc Is TextBox Then CType(cc, TextBox).Text = ""
        Next
    End Sub
    Public Sub ClearInnerControls(ByVal Container As Control)
        For Each cc As Control In Container.Controls
            If TypeOf cc Is TextBox Then CType(cc, TextBox).Text = ""
            If TypeOf cc Is NumericUpDown Then CType(cc, NumericUpDown).Value = 0
            If TypeOf cc Is ComboBox Then CType(cc, ComboBox).SelectedIndex = -1
            If TypeOf cc Is DateTimePicker Then CType(cc, DateTimePicker).Value = Now
            If TypeOf cc Is RichTextBox Then CType(cc, RichTextBox).Text = ""
            If TypeOf cc Is PictureBox Then CType(cc, PictureBox).Image = Nothing
            If TypeOf cc Is GroupBox Then
                For Each ccc As Control In cc.Controls
                    If TypeOf ccc Is TextBox Then CType(ccc, TextBox).Text = ""
                    If TypeOf ccc Is NumericUpDown Then CType(ccc, NumericUpDown).Value = CType(ccc, NumericUpDown).Minimum
                    If TypeOf ccc Is ComboBox Then CType(ccc, ComboBox).SelectedIndex = -1
                    If TypeOf ccc Is DateTimePicker Then CType(ccc, DateTimePicker).Value = Now
                    If TypeOf ccc Is RichTextBox Then CType(ccc, RichTextBox).Text = ""
                    If TypeOf ccc Is PictureBox Then CType(ccc, PictureBox).Image = Nothing
                Next
            End If
        Next
    End Sub
    Public Class MyList
        Private sName As String
        Private iID As String

        Public Sub New()
            sName = ""
            iID = ""
        End Sub

        Public Sub New(ByVal Name As String, ByVal ID As String)
            sName = Name
            iID = ID
        End Sub

        Public Property Name() As String
            Get
                Return sName
            End Get

            Set(ByVal sValue As String)
                sName = sValue
            End Set
        End Property

        Public Property ItemData() As String
            Get
                Return iID
            End Get

            Set(ByVal iValue As String)
                iID = iValue
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return sName
        End Function
    End Class
    Public Function AddSpaceBetweenString(ByVal text As String, ByVal spacing As Integer, ByVal space As Char) As String
        Dim spaces As String = "".PadLeft(spacing, space)
        Dim sb As StringBuilder = New StringBuilder()

        For i As Integer = 0 To text.Length - 1
            sb.Append(text(i) & spaces)
        Next

        Return sb.ToString().Trim(space)
    End Function
    Public Sub select_scaner_med()
        AddCustomer.ShowDialog()
    End Sub
    Public Sub whatsAPPPsent()
        Dim data As New Date
        data = Date.Now
        Try

        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        ' الحفظ ولالرسال عبر الوتس اب
        Try

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"

            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True


        Catch ex As Exception
            MsgBox("PDF غير مثبت", MsgBoxStyle.Information, AppTitle)

            Exit Sub
        End Try
        Try
            Dim webAddress As String = "https://wa.me/ " & "+" & "00" & ""
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("خطأ انترنت غير متوفر", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub
    Public Sub UpdateSettings()
        'ALTER TABLE Settings ADD BarCodeNote NVARCHAR(255)
        Try
            GlCommand.CommandText = "ALTER TABLE Settings ADD BarCodeNote NVARCHAR(255)"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'DefaultBarcode') IS NULL " & vbCrLf &
                                                    "BEGIN " & vbCrLf &
                                                    "ALTER TABLE [Settings] ADD [DefaultBarcode] nvarchar (255) NULL " & vbCrLf &
                                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        'اضافة حقل (chkLimitStock) في جدول اليوزر

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkLimitStock') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkLimitStock] bit NULL  " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkInvPayInstallment') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkInvPayInstallment] bit NULL  " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "UPDATE [user] SET [chkInvPayInstallment] = '0' WHERE [chkLimitStock] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "UPDATE [user] SET [chkLimitStock] = '0' WHERE [chkLimitStock] IS NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkSell') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD " & vbCrLf &
                                    "[chkSell] bit NULL , " & vbCrLf &
                                    "[chkBarCode] bit NULL , " & vbCrLf &
                                    "[chkModify] bit NULL , " & vbCrLf &
                                    "[chkGramPrice] bit NULL , " & vbCrLf &
                                    "[chkSalary] bit NULL , " & vbCrLf &
                                    "[chkWholeSaleBuy] bit NULL , " & vbCrLf &
                                    "[chkUsers] bit NULL , " & vbCrLf &
                                    "[chkCashier] bit NULL , " & vbCrLf &
                                    "[chkWholesale] bit NULL , " & vbCrLf &
                                    "[chkReports] bit NULL , " & vbCrLf &
                                    "[chkExpenses] bit NULL , " & vbCrLf &
                                    "[chkStock] bit NULL , " & vbCrLf &
                                    "[chkItem] bit NULL , " & vbCrLf &
                                    "[Active] bit NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkItem') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkItem] bit NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkDelItem') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkDelItem] bit NULL DEFAULT 1 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkItemSelectInvo') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkItemSelectInvo] bit NULL DEFAULT 1 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkModifyInvoce') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkModifyInvoce] bit NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [user] SET [chkModifyInvoce]='TRUE' WHERE [chkModifyInvoce] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'DateCreated') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "EXEC sp_rename 'user.date_of_creaitd', 'DateCreated', 'COLUMN' " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF (OBJECT_ID('DF__user__User_stau1__3D5E1FD2') IS NOT NULL) " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [User] DROP CONSTRAINT " &
                                    "[DF__user__User_stau__4E88ABD4] , " & vbCrLf &
                                    "[DF__user__User_stau1__3D5E1FD2] , " & vbCrLf &
                                    "[DF__user__User_stau1__45F365D3] , " & vbCrLf &
                                    "[DF__user__User_stau1__46E78A0C] , " & vbCrLf &
                                    "[DF__user__User_stau1__47DBAE45] , " & vbCrLf &
                                    "[DF__user__User_stau1__48CFD27E] , " & vbCrLf &
                                    "[DF__user__User_stau1__49C3F6B7] , " & vbCrLf &
                                    "[DF__user__User_stau1__4AB81AF0] , " & vbCrLf &
                                    "[DF__user__User_stau1__4BAC3F29] , " & vbCrLf &
                                    "[DF__user__User_stau1__4CA06362] , " & vbCrLf &
                                    "[DF__user__User_stau1__4D94879B] , " & vbCrLf &
                                    "[DF__user__User_stau2__3E52440B] , " & vbCrLf &
                                    "[DF__user__User_stau3__3F466844] , " & vbCrLf &
                                    "[DF__user__User_stau4__403A8C7D] , " & vbCrLf &
                                    "[DF__user__User_stau5__412EB0B6] , " & vbCrLf &
                                    "[DF__user__User_stau6__4222D4EF] , " & vbCrLf &
                                    "[DF__user__User_stau7__4316F928] , " & vbCrLf &
                                    "[DF__user__User_stau8__440B1D61] , " & vbCrLf &
                                    "[DF__user__User_stau9__44FF419A]  " & vbCrLf &
                                    "END"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'User_stau1') IS NOT NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] DROP COLUMN [User_stau] , [User_stau1] , [User_stau2] , [User_stau3] , [User_stau4] , [User_stau5] , [User_stau6] , [User_stau7] , [User_stau8] , [User_stau9] , [User_stau10] , [User_stau11] , [User_stau12] , [User_stau13] , [User_stau14] , [User_stau15] , [User_stau16] , [User_stau17] , [User_stau18] " & vbCrLf &
                                    "END"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "UPDATE [user] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'SET_INVARCHR157') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Settings] ADD " & vbCrLf &
                                    "[SET_INVARCHR157] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR158] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR159] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR160] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR161] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR162] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR163] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR164] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR165] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR166] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR167] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR168] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR169] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR170] nvarchar(250) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            'SuccessMessages &= vbCrLf & GlCommand.CommandText & " Successfully"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'SET_INVARCHR171') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Settings] ADD " & vbCrLf &
                                    "[SET_INVARCHR171] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR172] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR173] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR174] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR175] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR176] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR177] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR178] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR179] nvarchar(250) , " & vbCrLf &
                                    "[SET_INVARCHR180] nvarchar(250)  " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            'SuccessMessages &= vbCrLf & GlCommand.CommandText & " Successfully"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    ''''''''''''''''''''''''''''''''''''''' اعدادات اتصال الوتساب

End Module
