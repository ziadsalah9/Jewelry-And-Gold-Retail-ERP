Imports System.IO
Imports System.Drawing
Module ICONS_MODULE
    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ' دالة مساعدة لتحميل الصور بشكل آمن
    Private Function LoadImage(imagePath As String) As Image
        Try
            Dim fullPath As String = Application.StartupPath & "\Images\" & imagePath
            If File.Exists(fullPath) Then
                Return Image.FromFile(fullPath)
            Else
                ' إنشاء صورة فارغة بديلة (1x1 pixel transparent)
                Return New Bitmap(1, 1)
            End If
        Catch ex As Exception
            ' في حالة الخطأ، إرجاع صورة فارغة
            Return New Bitmap(1, 1)
        End Try
    End Function

    Private Function LoadIcon(iconPath As String) As Icon
        Try
            Dim fullPath As String = Application.StartupPath & "\Images\" & iconPath
            If File.Exists(fullPath) Then
                Return New Icon(fullPath)
            Else
                ' إرجاع أيقونة افتراضية
                Return SystemIcons.Application
            End If
        Catch ex As Exception
            Return SystemIcons.Application
        End Try
    End Function
    '.png
    Public ReadOnly imgDeleteGrid As Image = LoadImage("DeleteGrid.png")
    Public ReadOnly imgInvRet As Image = LoadImage("InvRet.png")
    Public ReadOnly imgModifyGrid As Image = LoadImage("ModifyGrid.png")
    Public ReadOnly imgDelete As Image = LoadImage("Delete.png")
    Public ReadOnly imgModify As Image = LoadImage("Modify.png")
    Public ReadOnly imgSave As Image = LoadImage("Save.png")
    Public ReadOnly imgPrint As Image = LoadImage("Prinet.png")
    Public ReadOnly imgPDF As Image = LoadImage("PDF.png")
    Public ReadOnly imgPayPrint As Image = LoadImage("PayPrint.png")
    Public ReadOnly imgSearch As Image = LoadImage("Search.png")
    Public ReadOnly imgSaveEdite As Image = LoadImage("SaveEdite.png")
    Public ReadOnly imgShowReport As Image = LoadImage("ShowReportButton.png")
    Public ReadOnly imgSearchBetweenDates As Image = LoadImage("SearchBetweenDates.png")
    Public ReadOnly imgViewAll As Image = LoadImage("ShowReportButton.png")
    Public ReadOnly imgPreview As Image = LoadImage("Preview.png")
    Public ReadOnly imgCancelPreview As Image = LoadImage("CancelPreview.png")
    Public ReadOnly imgDate As Image = LoadImage("Date.png")
    Public ReadOnly imgAddGold As Image = LoadImage("AddGoldItem.png")
    Public ReadOnly imgAddSupl = LoadImage("AddSupl.Png")
    Public ReadOnly imgFirstItem = LoadImage("DoubleUp.png")
    Public ReadOnly imgPreviousItem = LoadImage("Up.png")
    Public ReadOnly imgNextItem = LoadImage("Down.png")
    Public ReadOnly imgLastItem = LoadImage("DoubleDown.png")
    Public ReadOnly imgBtnAdd = LoadImage("BtnAdd.png")
    Public ReadOnly imgStartLogo = LoadImage("StartLogo.png")
    'BtnAdd.png
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '.icon
    Public ReadOnly imgFrmSndGold = LoadIcon("FrmSndGoldIcon.ico")
    Public ReadOnly imgFrmCompanyInfo = LoadIcon("CompanyInfo.ico")
    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ''' <param name="parent"></param>
    Public Sub ApplyIconsToContainer(parent As ReportDiamondSellShort)
        'تقرير الالماس المختصر
        With parent
            .btnViewAll.Image = imgViewAll
            .btnPrint.Image = imgPrint
            .btnPreview.Image = imgPreview
            .btnCancelPreview.Image = imgCancelPreview
            .btnDate.Image = imgDate
            .btnSearch.Image = imgSearchBetweenDates
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As ReportGoldSellDetailed)
        'تقرير الذهب تفصيلي
        With parent
            .btnViewAll.Image = imgViewAll
            .btnPrint.Image = imgPrint
            .btnPreview.Image = imgPreview
            .btnCancelPreview.Image = imgCancelPreview
            .btnDate.Image = imgDate
            .btnSearch.Image = imgSearchBetweenDates
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As ReportGoldSellShort)
        'تقرير الذهب مختصر
        With parent
            .btnViewAll.Image = imgViewAll
            .btnPrint.Image = imgPrint
            .btnPreview.Image = imgPreview
            .btnCancelPreview.Image = imgCancelPreview
            .btnDate.Image = imgDate
            .btnSearch.Image = imgSearchBetweenDates
        End With
    End Sub

    'FrmSndGold
    Public Sub ApplyIconsToContainer(parent As frmSuppliers)
        'الموردين
        With frmSuppliers
            .btnSearch.Image = imgSearch
            .btnFirstItem.Image = imgFirstItem
            .btnPreviousItem.Image = imgPreviousItem
            .btnNextItem.Image = imgNextItem
            .btnLastItem.Image = imgLastItem
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As FrmSndGold)
        'تقرير الذهب تفصيلي
        With parent
            .BtnAdd.Image = imgBtnAdd
            .BtnSave.Image = imgSave
            .Icon = imgFrmSndGold
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As FrmCompanyInfo)
        'اضافة بينات الشركه
        With parent
            .BtnAdd.Image = imgBtnAdd
            .BtnSave.Image = imgSave
            .Icon = imgFrmCompanyInfo
            Dim btnAddReceiptPath As String = Application.StartupPath & "\Images\BtnAddReceipt.png"
            .BtnAddLicenseImage.Image = If(.BtnAddLicenseImage.Image Is Nothing AndAlso File.Exists(btnAddReceiptPath), Image.FromFile(btnAddReceiptPath), imgDelete)
        End With
    End Sub

    Public Sub ApplyIconsToContainer(parent As frmLogin)
        'فورم تسجيل الدخول
        With parent
            .BackgroundImage = imgStartLogo
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As ReportGoldProfit)
        'ReportGoldProfit
        With parent
            With parent
                .btnViewAll.Image = imgViewAll
                .btnPrint.Image = imgPrint
                .btnPreview.Image = imgPreview
                .btnCancelPreview.Image = imgCancelPreview
                .btnDate.Image = imgDate
                .btnSearch.Image = imgSearchBetweenDates
            End With
        End With
    End Sub
    Public Sub ApplyIconsToContainer(parent As ReportSilverProfit)
        'ReportSilverProfit
        With parent
            With parent
                .btnViewAll.Image = imgViewAll
                .btnPrint.Image = imgPrint
                .btnPreview.Image = imgPreview
                .btnCancelPreview.Image = imgCancelPreview
                .btnDate.Image = imgDate
                .btnSearch.Image = imgSearchBetweenDates
            End With
        End With
    End Sub
    'frmLogin
    Public Sub ApplyIconsToContainer(parent As Control)
        For Each ctrl As Control In parent.Controls
            ' لو زر عادي
            If TypeOf ctrl Is Button Then
                Dim btn = CType(ctrl, Button)
                'المحازاه
                If btn.Image IsNot Nothing Then
                    btn.ImageAlign = ContentAlignment.MiddleLeft
                    btn.TextAlign = ContentAlignment.MiddleRight
                End If
                Select Case btn.Name.ToLower
                    Case "btnDate"
                        btn.Image = imgDate
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnCancelPreview"
                        btn.Image = imgPreview
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnPreview"
                        btn.Image = imgPreview
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnDate"
                        btn.Image = imgSearchBetweenDates
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnSearch"
                        btn.Image = imgSearch
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnSaveEdite"
                        btn.Image = imgSaveEdite
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnView"
                        btn.Image = imgSearch
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnsave"
                        btn.Image = imgSave
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnprint"
                        btn.Image = imgPrint
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnpdf"
                        btn.Image = imgPDF
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btndelete"
                        btn.Image = imgDelete
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnmodify"
                        btn.Image = imgModify
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                    Case "btnPayPrint"
                        btn.Image = imgPayPrint
                        btn.ImageAlign = ContentAlignment.MiddleLeft
                End Select
            End If
            ' لو الكنترول ده جواه كنترولز تانية، ادخل جوّاه
            If ctrl.HasChildren Then
                ApplyIconsToContainer(ctrl)
            End If
        Next
        With GoldInvoicePay
            Dim btnAddReceiptPath1 As String = Application.StartupPath & "\Images\BtnAddReceipt.png"
            .BtnAddReceipt.Image = If(.PicAddReceipt.Image Is Nothing AndAlso File.Exists(btnAddReceiptPath1), Image.FromFile(btnAddReceiptPath1), imgDelete)
        End With
        With SilverInvoicePay
            Dim btnAddReceiptPath2 As String = Application.StartupPath & "\Images\BtnAddReceipt.png"
            .BtnAddReceipt.Image = If(.PicAddReceipt.Image Is Nothing AndAlso File.Exists(btnAddReceiptPath2), Image.FromFile(btnAddReceiptPath2), imgDelete)
        End With
        With GoldInvoice
            '.BtnAddPur.Image = Image.FromFile(Application.StartupPath & "\Images\AddGoldItem.png")
            .btnPayPrint.Image = imgPayPrint
            .BtnAddPur.Image = imgAddGold
        End With

        With frmGoldVoucherReceive

        End With






    End Sub












    ' دالة عامة تستقبل الفورم
    Public Sub ApplyIconsToButtons(frm As Form)
        ApplyIconsToContainer(frm)
    End Sub
End Module
