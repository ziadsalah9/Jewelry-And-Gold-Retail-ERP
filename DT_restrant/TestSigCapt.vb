'#Region "Assembly Florentis.InteropFlSigCapt, Version=4.5.5.218, Culture=neutral, PublicKeyToken=20000022810869de"
'C:\Program Files (x86)\Common Files\WacomGSS\Florentis.InteropFlSigCapt.dll
'#End Region
Imports Florentis
Imports System.Environment
Namespace TestSigCapt
    Partial Public Class TestSigCapt
        Inherits Form
        Private sigCtl As SigCtl
        Private sigCt2 As SigCtl
        Private sigObj As SigObj

        Public Sub New()
            InitializeComponent()
            Try
                sigCtl = New SigCtl()
                sigCtl.Licence = "<<AgAkAMlv5nGdAQVXYWNvbQ1TaWduYXR1cmUgU0RLAgOBAgJkAACIAwEDZQA>>"
                sigCtl.Licence = "eyJhbGciOiJSUzUxMiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiI3YmM5Y2IxYWIxMGE0NmUxODI2N2E5MTJkYTA2ZTI3NiIsImV4cCI6MjE0NzQ4MzY0NywiaWF0IjoxNTYwOTUwMjcyLCJyaWdodHMiOlsiU0lHX1NES19DT1JFIiwiU0lHQ0FQVFhfQUNDRVNTIl0sImRldmljZXMiOlsiV0FDT01fQU5ZIl0sInR5cGUiOiJwcm9kIiwibGljX25hbWUiOiJTaWduYXR1cmUgU0RLIiwid2Fjb21faWQiOiI3YmM5Y2IxYWIxMGE0NmUxODI2N2E5MTJkYTA2ZTI3NiIsImxpY191aWQiOiJiODUyM2ViYi0xOGI3LTQ3OGEtYTlkZS04NDlmZTIyNmIwMDIiLCJhcHBzX3dpbmRvd3MiOltdLCJhcHBzX2lvcyI6W10sImFwcHNfYW5kcm9pZCI6W10sIm1hY2hpbmVfaWRzIjpbXX0.ONy3iYQ7lC6rQhou7rz4iJT_OJ20087gWz7GtCgYX3uNtKjmnEaNuP3QkjgxOK_vgOrTdwzD-nm-ysiTDs2GcPlOdUPErSp_bcX8kFBZVmGLyJtmeInAW6HuSp2-57ngoGFivTH_l1kkQ1KMvzDKHJbRglsPpd4nVHhx9WkvqczXyogldygvl0LRidyPOsS5H2GYmaPiyIp9In6meqeNQ1n9zkxSHo7B11mp_WXJXl0k1pek7py8XYCedCNW5qnLi4UCNlfTd6Mk9qz31arsiWsesPeR9PN121LBJtiPi023yQU8mgb9piw_a-ccciviJuNsEuRDN3sGnqONG3dMSA"
            Catch ex As Exception

            End Try

        End Sub


        Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
            Try
                print("btnSign was pressed")
                Dim dc As DynamicCapture = New DynamicCapture()
                Dim res As DynamicCaptureResult = dc.Capture(sigCtl, "(91111925-92297206-92273108-67715137)شركة ساب الدوليه للحلول المتكامله الحاسوبيه", "لإدارة معارض ومحلات الذهب والمجوهرات (SAP ACC) تطبيق", Nothing, Nothing)
                If res = DynamicCaptureResult.DynCaptOK Then
                    print("تم التوقيع بشكل صحيح")
                    sigObj = CType(sigCtl.Signature, SigObj)

                    sigObj.ExtraData("AdditionalData") = "C# test: Additional data"
                    Dim filename As String = "sig" & Date.Now.ToString("yyyy-MM-dd--HH-mm-ss") & ".png"
                    'sigObj.RenderBitmap(filename, 200, 150, "image/png", 1.2F, &HFF0000, &HFFFFFF, -1.0F, -1.0F, RBFlags.RenderOutputFilename Or RBFlags.RenderColor32BPP Or RBFlags.RenderBackgroundTransparent Or RBFlags.RenderColorAntiAlias Or RBFlags.RenderEncodeData)
                    sigObj.RenderBitmap(
    filename,
    200,
    150,
    "image/png",
    3.0F,          ' سمك أكبر للخط (Bold)
    &H0,      ' أسود داكن
    &HFFFFFF,      ' الخلفية (لن تظهر لأنها شفافة)
    -1.0F,
    -1.0F,
    RBFlags.RenderOutputFilename Or
    RBFlags.RenderColor32BPP Or
    RBFlags.RenderBackgroundTransparent Or
    RBFlags.RenderColorAntiAlias Or
    RBFlags.RenderEncodeData
)
                    sigImage.Load(filename)
                    SignatureImage = sigImage.Image
                    Close()
                Else
                    print("خطأ في التوقيع بسبب=" & CInt(res) & "  ( " & res & " )")
                    Select Case res
                        Case DynamicCaptureResult.DynCaptCancel
                            print("تم إلغاء التوقيع")
                            Close()
                        Case DynamicCaptureResult.DynCaptError
                            print("جهاز التوقيع غير موصل")
                        Case DynamicCaptureResult.DynCaptPadError
                            print("خطأ في جهاز التوقيع، تأكد من توصيل الجهاز بشكل صحيح")
                            MsgBox("خطأ في جهاز التوقيع، تأكد من توصيل الجهاز بشكل صحيح", MsgBoxStyle.Critical, "HOSAM-IT_ENG")
                            Close()
                        Case Else
                            print("خطأ غير محدد")
                    End Select
                End If
            Catch ex As Exception
                MsgBox("خطأ في لوح التوقيع", MsgBoxStyle.Critical, "HOSAM-IT_ENG")
                MsgBox(ex.ToString)
                Close()
            End Try
        End Sub

        Private Sub print(txt As String)
            txtDisplay.Text &= txt & vbCrLf
            txtDisplay.SelectionStart = txtDisplay.TextLength
            txtDisplay.ScrollToCaret()
        End Sub

        Private Sub TestSigCapt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            'Me.Dispose()
        End Sub

        Private Sub TestSigCapt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btnSign.PerformClick()
            Hide()
        End Sub
    End Class
End Namespace

