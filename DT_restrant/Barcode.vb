Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Barcode
    Public TPCategory As String
    Public SQLTP As String
    Public BarcodTxtR As String
    Public KaratR As String
    Public ItemNameR As String
    Public MetalWeightR As String
    Public MakeChargeR As String
    Public CostPerGramR As String
    Public CountryR As String
    Public SupplierR As String
    Public PurInvNumberR As String
    Public CodeR As String
    Public CostPerItemR As String
    Public QtyR As String
    Public StoneWeightR As String
    Public StonePriceR As String
    ''''''''''''''''''''''''''''''''''''''''
    Public BarcodTxtL As String
    Public KaratL As String
    Public ItemNameL As String
    Public MetalWeightL As String
    Public MakeChargeL As String
    Public CostPerGramL As String
    Public CountryL As String
    Public SupplierL As String
    Public PurInvNumberL As String
    Public CodeL As String
    Public CostPerItemL As String
    Public QtyL As String
    Public StoneWeightL As String
    Public StonePriceL As String
    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''
    Public ShroomName As String
    ''' </summary>
    Public Goldselectdata As DataTable
    Public Silverselectdata As DataTable
    Public GetItemDataFromSQLR As DataTable
    Public GetItemDataFromSQLL As DataTable


    Public GetItemDataFromSQLRPrint As DataTable
    Public GetItemDataFromSQLLPrint As DataTable

    Public ListR As New DataGrid
    Public Listl As New DataGrid



    Private Function GetFontStyle(StringStyle As String) As FontStyle
        Select Case StringStyle.ToUpper
            Case "B"
                Return FontStyle.Bold
            Case "I"
                Return FontStyle.Italic
            Case "R"
                Return FontStyle.Regular
            Case "S"
                Return FontStyle.Strikeout
            Case "U"
                Return FontStyle.Underline
            Case Else
                Return FontStyle.Regular
        End Select
    End Function


    Public Function GetItemData(TpName As String)
        GetItemDataFromSQLR = GetRecordSet("SELECT * FROM " & TpName & " WHERE [Item_Actv]=1")
        '''SILVER R
        If GetItemDataFromSQLR.Rows.Count > 0 Then
            cmbRightItem.DataBindings.Clear()
            cmbRightItem.DisplayMember = "FO_name"
            cmbRightItem.ValueMember = "BarCode"
            cmbRightItem.SelectedValue = "BarCode"
            cmbRightItem.DataSource = GetItemDataFromSQLR
            cmbRightItem.DropDownWidth = GetMaxDataSize(GetItemDataFromSQLR, "FO_name", cmbRightItem)

        End If
        GetItemDataFromSQLL = GetRecordSet("SELECT * FROM " & TpName & " WHERE [Item_Actv]=1")
        '''SILVER L
        If GetItemDataFromSQLL.Rows.Count > 0 Then
            cmbLeftItem.DataBindings.Clear()
            cmbLeftItem.DisplayMember = "FO_name"
            cmbLeftItem.ValueMember = "BarCode"
            cmbLeftItem.SelectedValue = "BarCode"
            cmbLeftItem.DataSource = GetItemDataFromSQLL
            cmbLeftItem.DropDownWidth = GetMaxDataSize(GetItemDataFromSQLL, "FO_name", cmbLeftItem)

        End If
    End Function
    Public Sub PrintRange()
        Try
            Dim RepeatPrinting As DataTable = GetRecordSet("SELECT * FROM " & SQLTP & " WHERE(Item_Actv = 1)")
            If RepeatPrinting.Rows.Count > 0 Then
                cmbPrintRange.DataBindings.Clear()
                cmbPrintRange.DisplayMember = "BarCode"
                cmbPrintRange.SelectedValue = "BarCode"
                cmbPrintRange.DataSource = RepeatPrinting
                cmbPrintRange.DropDownWidth = GetMaxDataSize(RepeatPrinting, "FO_name", cmbPrintRange)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SelectNextItemR()

        Try
            cmbRightItem.SelectedIndex = cmbRightItem.SelectedIndex + 1
        Catch ex As Exception
        End Try
        Try
            cmbRightItem.SelectedIndex = cmbRightItem.SelectedIndex + 1
        Catch ex As Exception

        End Try
        txtBarCodeRight.Text = cmbRightItem.SelectedValue

    End Sub
    Private Sub SelectNextItemL()
        Try
            cmbLeftItem.SelectedIndex = cmbRightItem.SelectedIndex + 1
        Catch ex As Exception
        End Try
        Try
            cmbLeftItem.SelectedIndex = cmbRightItem.SelectedIndex + 1
        Catch ex As Exception
        End Try
        txtBarCodeLeft.Text = cmbLeftItem.SelectedValue

    End Sub

    Public Sub RepeatPrinting()
        Do While -1
            SelectNextItemR()
            SelectNextItemL()
            PrintBarCode()
            If txtBarCodeRight.Text.Trim >= cmbPrintRange.Text.Trim Then
                MsgBox("انتهت الطباعه المحدده" & vbCrLf & "The Specified Print Has Ended.", , AppTitle)
                Exit Do
                Exit Sub
            ElseIf txtBarCodeLeft.Text.Trim >= cmbPrintRange.Text.Trim Then
                MsgBox("انتهت الطباعه المحدده" & vbCrLf & "The Specified Print Has Ended.", , AppTitle)
                Exit Do
                Exit Sub
            End If
        Loop
    End Sub

    Public Function GetItemPrintDataR()
        Try
            'GetItemDataFromSQLRPrint.Clear()
            GetItemDataFromSQLRPrint = GetRecordSet("SELECT * FROM  " & SQLTP & " WHERE(BarCode LIKE '" & txtBarCodeRight.Text.Trim & "') AND (Item_Actv = 1)")
            If GetItemDataFromSQLRPrint.Rows.Count > 0 Then
                ItemNameR = GetItemDataFromSQLRPrint.Rows(0)("FO_name").ToString()
                KaratR = GetItemDataFromSQLRPrint.Rows(0)("Gram_valu").ToString()
                MetalWeightR = GetItemDataFromSQLRPrint.Rows(0)("FO_gram").ToString()
                MakeChargeR = GetItemDataFromSQLRPrint.Rows(0)("FO_gramMade").ToString()
                CostPerGramR = GetItemDataFromSQLRPrint.Rows(0)("FO_desp").ToString()
                CountryR = GetItemDataFromSQLRPrint.Rows(0)("FO_made").ToString()
                SupplierR = GetItemDataFromSQLRPrint.Rows(0)("FO_GramPrice").ToString()
                PurInvNumberR = GetItemDataFromSQLRPrint.Rows(0)("PurInvNumber").ToString()
                CodeR = GetItemDataFromSQLRPrint.Rows(0)("FO_ItemNo").ToString()
                CostPerItemR = GetItemDataFromSQLRPrint.Rows(0)("FO_totalPrice").ToString()
                QtyR = GetItemDataFromSQLRPrint.Rows(0)("Qty").ToString()
                StoneWeightR = (GetItemDataFromSQLRPrint.Rows(0)("FO_extras") + GetItemDataFromSQLRPrint.Rows(0)("StoneWeight2") + GetItemDataFromSQLRPrint.Rows(0)("StoneWeight3")).ToString()
                StonePriceR = (GetItemDataFromSQLRPrint.Rows(0)("StonePrice1") + GetItemDataFromSQLRPrint.Rows(0)("StonePrice2") + GetItemDataFromSQLRPrint.Rows(0)("StonePrice3")).ToString()
            End If
        Catch ex As Exception
            ' RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Function
    Public Sub GetItemPrintDataL()
        Try
            'GetItemDataFromSQLLPrint.Clear()
            GetItemDataFromSQLLPrint = GetRecordSet("SELECT * FROM  " & SQLTP & " WHERE(BarCode LIKE '" & txtBarCodeLeft.Text.Trim & "') AND (Item_Actv = 1)")
            If GetItemDataFromSQLLPrint.Rows.Count > 0 Then
            ItemNameL = GetItemDataFromSQLLPrint.Rows(0)("FO_name").ToString()
            KaratL = GetItemDataFromSQLLPrint.Rows(0)("Gram_valu").ToString()
            MetalWeightL = GetItemDataFromSQLLPrint.Rows(0)("FO_gram").ToString()
            MakeChargeL = GetItemDataFromSQLLPrint.Rows(0)("FO_gramMade").ToString()
            CostPerGramL = GetItemDataFromSQLLPrint.Rows(0)("FO_desp").ToString()
            CountryL = GetItemDataFromSQLLPrint.Rows(0)("FO_made").ToString()
            SupplierL = GetItemDataFromSQLLPrint.Rows(0)("FO_GramPrice").ToString()
            PurInvNumberL = GetItemDataFromSQLLPrint.Rows(0)("PurInvNumber").ToString()
            CodeL = GetItemDataFromSQLLPrint.Rows(0)("FO_ItemNo").ToString()
            CostPerItemL = GetItemDataFromSQLLPrint.Rows(0)("FO_totalPrice").ToString()
            QtyL = GetItemDataFromSQLLPrint.Rows(0)("Qty").ToString()
            StoneWeightL = (GetItemDataFromSQLLPrint.Rows(0)("FO_extras") + GetItemDataFromSQLLPrint.Rows(0)("StoneWeight2") + GetItemDataFromSQLLPrint.Rows(0)("StoneWeight3")).ToString()
            StonePriceL = (GetItemDataFromSQLLPrint.Rows(0)("StonePrice1") + GetItemDataFromSQLLPrint.Rows(0)("StonePrice2") + GetItemDataFromSQLLPrint.Rows(0)("StonePrice3")).ToString()
        End If
        Catch ex As Exception
            ' RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub
    Private Sub Preview()
        Try
            Me.CreateGraphics().Clear(Color.Teal)
            '''الاستيكر 
            Me.CreateGraphics().DrawRectangle(Pens.Black, 5, 5, 320, 145)
            'الشريط الايمن
            Me.CreateGraphics().DrawRectangle(Pens.Black, 5, 23, 240, 7)
            'الشريط الايسر
            Me.CreateGraphics().DrawRectangle(Pens.Black, 83, 119, 242, 7)

            'الجزء العلوي يمين
            Me.CreateGraphics().DrawRectangle(Pens.Black, 245, 5, 80, 50)
            'الجزء السفلي يمين
            Me.CreateGraphics().DrawRectangle(Pens.Black, 245, 55, 80, 50)
            'الجزء العلوي يسار
            Me.CreateGraphics().DrawRectangle(Pens.Black, 5, 48, 78, 51)
            'الجزء السفلي يسار
            Me.CreateGraphics().DrawRectangle(Pens.Black, 5, 99, 78, 51)

            Dim BarCodeFont As New Font(cmbBarCodeFontTyp.Text, CSng(txtBarCodeFont.Text.Trim), GetFontStyle("Regular"))
            Dim DataTextFont As New Font(cmbDataTextFontTyp.Text, CSng(txtDataTextFont.Text.Trim), GetFontStyle(cmbTextBoldRegular.Text.Trim))
            Dim CompFont As New Font(cmbCompFontTyp.Text, CSng(txtCompFont.Text.Trim), GetFontStyle(StringStyle:=cmbCompFontBoldRegular.Text.Trim))
            Dim CountryFontTyp As New Font(cmbCountryFontTyp.Text, CSng(txtCountryFont.Text.Trim), GetFontStyle(StringStyle:=cmbCountryFontBoldRegular.Text.Trim))

            'رقم الباركود يمين
            Me.CreateGraphics().DrawString("*" & txtBarCodeRight.Text.Trim & "*", BarCodeFont, Brushes.Black, txtBarcodLfRtR.Text.Trim, txtBarcodUpDoR.Text.Trim)
            Me.CreateGraphics().DrawString(txtBarCodeRight.Text.Trim, DataTextFont, Brushes.Black, txtBarcodLfRtRV.Text, txtBarcodUpDoRV.Text)
            'رقم الباركود يسار 
            Me.CreateGraphics().DrawString("*" & txtBarCodeLeft.Text.Trim & "*", BarCodeFont, Brushes.Black, txtBarcodLfRtL.Text.Trim, txtBarcodUpDoL.Text.Trim)
            Me.CreateGraphics().DrawString(txtBarCodeLeft.Text.Trim, DataTextFont, Brushes.Black, txtBarcodLfRtLV.Text, txtBarcodUpDoLV.Text)

            ''''اسم الصنف الجه اليمني

            Me.CreateGraphics().DrawString(ItemNameR, DataTextFont, Brushes.Black, txtItemNameRtLfR.Text, txtItemNameUpDoR.Text)
            'اسم الصنف الجه اليسري
            Me.CreateGraphics().DrawString(ItemNameL, DataTextFont, Brushes.Black, txtItemNameRtLfL.Text, txtItemNameUpDoL.Text)





            'عيار الجه اليمني رقم
            Me.CreateGraphics().DrawString(KaratR, DataTextFont, Brushes.Black, txtKaratRtLfRV.Text, txtKaratUpDoRVu.Text)
            ' عيار الجه اليسري
            Me.CreateGraphics().DrawString(KaratL, DataTextFont, Brushes.Black, txtKaratRtLfLV.Text, txtKaratUpDoLVu.Text)

            'نص عيار الجه اليمني
            Me.CreateGraphics().DrawString(txtKaratR.Text.Trim, DataTextFont, Brushes.Black, txtKaratRtLfR.Text, txtKaratUpDoR.Text)
            'نص عيار الجه اليسري 
            Me.CreateGraphics().DrawString(txtKaratL.Text.Trim, DataTextFont, Brushes.Black, txtKaratRtLfL.Text, txtKaratUpDoL.Text)




            ' وزن الجه اليمني رقم
            Me.CreateGraphics().DrawString(MetalWeightR, DataTextFont, Brushes.Black, txtMetalWeightRtLfRV.Text, txtMetalWeightUpDoRV.Text)
            ' وزن الجه اليسري رقم 
            Me.CreateGraphics().DrawString(MetalWeightL, DataTextFont, Brushes.Black, txtMetalWeightRtLfLV.Text, txtMetalWeightUpDoLV.Text)
            'نص وزن الجه اليمني 
            Me.CreateGraphics().DrawString(txtMetalWeightR.Text.Trim, DataTextFont, Brushes.Black, txtMetalWeightRtLfR.Text, txtMetalWeightUpDoR.Text)
            'نص وزن الجه اليسري 
            Me.CreateGraphics().DrawString(txtMetalWeightL.Text.Trim, DataTextFont, Brushes.Black, txtMetalWeightRtLfL.Text, txtMetalWeightUpDoL.Text)




            'نص المصنيعه الجه اليمني 
            Me.CreateGraphics().DrawString(txtMakeChargeR.Text.Trim, DataTextFont, Brushes.Black, txtMakeChargeRtLfR.Text, txtMakeChargeUpDoR.Text)
            'نص المصنعيه الجه اليسري 
            Me.CreateGraphics().DrawString(txtMakeChargeL.Text.Trim, DataTextFont, Brushes.Black, txtMakeChargeRtLfL.Text, txtMakeChargeUpDoL.Text)
            'رقم المصنيعه الجه اليمني 
            Me.CreateGraphics().DrawString(MakeChargeR, DataTextFont, Brushes.Black, txtMakeChargeRtLfRV.Text, txtMakeChargeUpDoRV.Text)
            'رقم المصنعيه الجه اليسري 
            Me.CreateGraphics().DrawString(MakeChargeL, DataTextFont, Brushes.Black, txtMakeChargeRtLfLV.Text, txtMakeChargeUpDoLV.Text)




            'نص التكلفه للجرام الجه اليمني 
            Me.CreateGraphics().DrawString(txtCostPerGramR.Text.Trim, DataTextFont, Brushes.Black, txtCostPerGramRtLfR.Text, txtCostPerGramUpDoR.Text)
            'نص التكلفه للجرام الجه اليسري 
            Me.CreateGraphics().DrawString(txtCostPerGramL.Text.Trim, DataTextFont, Brushes.Black, txtCostPerGramRtLfL.Text, txtCostPerGramUpDoL.Text)
            'رقم التكلفه للجرام الجه اليمني 
            Me.CreateGraphics().DrawString(CostPerGramR, DataTextFont, Brushes.Black, txtCostPerGramRtLfRV.Text, txtCostPerGramUpDoRV.Text)
            'رقم التكلفه للجرام الجه اليسري 
            Me.CreateGraphics().DrawString(CostPerGramL, DataTextFont, Brushes.Black, txtCostPerGramRtLfLV.Text, txtCostPerGramUpDoLV.Text)



            'نص بلد المنشأ الجه اليمني 
            Me.CreateGraphics().DrawString(txtCountryR.Text.Trim, CountryFontTyp, Brushes.Black, txtCountryRtLfR.Text, txtCountryUpDoR.Text)
            'نص بلد المنشأ الجه اليسري 
            Me.CreateGraphics().DrawString(txtCountryL.Text.Trim, CountryFontTyp, Brushes.Black, txtCountryRtLfL.Text, txtCountryUpDoL.Text)
            ' بلد المنشأ الجه اليمني 
            Me.CreateGraphics().DrawString(CountryR, CountryFontTyp, Brushes.Black, txtCountryLfRtRV.Text, txtCountryUpDoRV.Text)
            ' بلد المنشأ الجه اليسري 
            Me.CreateGraphics().DrawString(CountryL, CountryFontTyp, Brushes.Black, txtCountryLfRtLV.Text, txtCountryUpDoLV.Text)




            'نص المورد  الجه اليمني 
            Me.CreateGraphics().DrawString(txtSupplierR.Text.Trim, DataTextFont, Brushes.Black, txtSupplierRtLfR.Text, txtSupplierUpDoR.Text)
            'نص المورد  الجه اليسري 
            Me.CreateGraphics().DrawString(txtSupplierL.Text.Trim, DataTextFont, Brushes.Black, txtSupplierRtLfL.Text, txtSupplierUpDoL.Text)
            ' المورد  الجه اليمني 
            Me.CreateGraphics().DrawString(SupplierR, DataTextFont, Brushes.Black, txtSupplierRtLfRV.Text, txtSupplierUpDoRV.Text)
            ' المورد  الجه اليسري 
            Me.CreateGraphics().DrawString(SupplierL, DataTextFont, Brushes.Black, txtSupplierRtLfLV.Text, txtSupplierUpDoLV.Text)

            'نص رقم فاتورة الشراء  الجه اليمني 
            Me.CreateGraphics().DrawString(txtPurInvNumberR.Text.Trim, DataTextFont, Brushes.Black, txtPurInvNumberRtLfR.Text, txtPurInvNumberUpDoR.Text)
            'نص رقم فاتورة الشراء  الجه اليسري 
            Me.CreateGraphics().DrawString(txtPurInvNumberL.Text.Trim, DataTextFont, Brushes.Black, txtPurInvNumberRtLfL.Text, txtPurInvNumberUpDoL.Text)
            'رقم فاتورة الشراء  الجه اليمني 
            Me.CreateGraphics().DrawString(PurInvNumberR, DataTextFont, Brushes.Black, txtPurInvNumberRtLfRV.Text, txtPurInvNumberUpDoRV.Text)
            'نص رقم فاتورة الشراء  الجه اليسري 
            Me.CreateGraphics().DrawString(PurInvNumberL, DataTextFont, Brushes.Black, txtPurInvNumberRtLfLV.Text, txtPurInvNumberUpDoLV.Text)

            'نص رقم القطعه   الجه اليمني   
            Me.CreateGraphics().DrawString(txtCodeR.Text.Trim, DataTextFont, Brushes.Black, txtCodeRtLfR.Text, txtCodeUpDoR.Text)
            'نص رقم القطعه   الجه اليسري 
            Me.CreateGraphics().DrawString(txtCodeL.Text.Trim, DataTextFont, Brushes.Black, txtCodeRtLfL.Text, txtCodeUpDoL.Text)
            'رقم القطعه   الجه اليمني 
            Me.CreateGraphics().DrawString(CodeR, DataTextFont, Brushes.Black, txtCodeRtLfRV.Text, txtCodeUpDoRV.Text)
            'رقم القطعه الجه اليسري 
            Me.CreateGraphics().DrawString(CodeL, DataTextFont, Brushes.Black, txtCodeRtLfLV.Text, txtCodeUpDoLV.Text)

            'نص تكلفة القطعه اليمني
            Me.CreateGraphics().DrawString(txtCostPerItemR.Text.Trim, DataTextFont, Brushes.Black, txtCostPerItemRtLfR.Text, txtCostPerItemUpDoR.Text)
            'نص تكلفة القطعه اليسري
            Me.CreateGraphics().DrawString(txtCostPerItemL.Text.Trim, DataTextFont, Brushes.Black, txtCostPerItemRtLfL.Text, txtCostPerItemUpDoL.Text)
            ' رقم تكلفة القطعه اليمني
            Me.CreateGraphics().DrawString(CostPerItemR, DataTextFont, Brushes.Black, txtCostPerItemRtLfRV.Text, txtCostPerItemUpDoRV.Text)
            ' رقم تكلفة القطعه اليسري
            Me.CreateGraphics().DrawString(CostPerItemL, DataTextFont, Brushes.Black, txtCostPerItemRtLfLV.Text, txtCostPerItemUpDoLV.Text)

            'نص العدد  اليمني
            Me.CreateGraphics().DrawString(txtQtyR.Text.Trim, DataTextFont, Brushes.Black, txtQtyRtLfR.Text, txtQtyUpDoR.Text)
            'نص العدد  اليسري
            Me.CreateGraphics().DrawString(txtQtyL.Text.Trim, DataTextFont, Brushes.Black, txtQtyRtLfL.Text, txtQtyUpDoL.Text)
            ' رقم العدد  اليمني
            Me.CreateGraphics().DrawString(QtyR, DataTextFont, Brushes.Black, txtQtyRtLfRV.Text, txtQtyUpDoRV.Text)
            ' رقم العدد  اليسري
            Me.CreateGraphics().DrawString(QtyL, DataTextFont, Brushes.Black, txtQtyRtLfLV.Text, txtQtyUpDoLV.Text)

            'اسم الحجر الجه اليمني
            Me.CreateGraphics().DrawString(txtStoneWeightR.Text.Trim, DataTextFont, Brushes.Black, txtStoneWeightRtLfR.Text, txtStoneWeightUpDoR.Text)
            'اسم الحجر الجه اليسري
            Me.CreateGraphics().DrawString(txtStoneWeightL.Text.Trim, DataTextFont, Brushes.Black, txtStoneWeightRtLfL.Text, txtStoneWeightUpDoL.Text)
            'قيمة الحجر الجه اليمني
            Me.CreateGraphics().DrawString(StoneWeightR, DataTextFont, Brushes.Black, txtStoneWeightRtLfRV.Text, txtStoneWeightUpDoRV.Text)
            'قيمة الحجر الجه اليسري
            Me.CreateGraphics().DrawString(StoneWeightL, DataTextFont, Brushes.Black, txtStoneWeightRtLfLV.Text, txtStoneWeightUpDoLV.Text)

            'اسم سعر  الحجر الجه اليمني
            Me.CreateGraphics().DrawString(txtStonePriceR.Text.Trim, DataTextFont, Brushes.Black, txtStonePriceRtLfR.Text, txtStonePriceUpDoR.Text)
            'اسم سعر الحجر الجه اليسري
            Me.CreateGraphics().DrawString(txtStonePriceL.Text.Trim, DataTextFont, Brushes.Black, txtStonePriceRtLfl.Text, txtStonePriceUpDoL.Text)
            'قيمة سعرالحجر الجه اليمني
            Me.CreateGraphics().DrawString(StonePriceR, DataTextFont, Brushes.Black, txtStonePriceRtLfRV.Text, txtStonePriceUpDoRV.Text)
            'قيمة سعرالحجر الجه اليسري
            Me.CreateGraphics().DrawString(StonePriceL, DataTextFont, Brushes.Black, txtStonePriceRtLfLV.Text, txtStonePriceUpDoLV.Text)

            ' ' الفرع  الجه اليمني
            Me.CreateGraphics().DrawString(cmbCompany.Text.Trim, DataTextFont, Brushes.Black, txtShroomRtLfR.Text, txtShroomUpDoR.Text)
            'اسم الفرع الجه اليسري
            Me.CreateGraphics().DrawString(cmbCompany.Text.Trim, DataTextFont, Brushes.Black, txtShroomRtLfL.Text, txtShroomUpDoL.Text)

            Me.CreateGraphics().DrawImage(PicLogo.Image, CSng(txtLogoRtLfR.Text.Trim), CSng(txtLogoUpDoR.Text.Trim), CSng(txtImgeSize.Text.Trim), CSng(txtImgeSize.Text.Trim))
            Me.CreateGraphics().DrawImage(PicLogo.Image, CSng(txtLogoRtLfL.Text.Trim), CSng(txtLogoUpDoL.Text.Trim), CSng(txtImgeSize.Text.Trim), CSng(txtImgeSize.Text.Trim))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PrintDocumentBarcod_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentBarcod.PrintPage
        Try


            Dim BarCodeFont As New Font(cmbBarCodeFontTyp.Text, CSng(txtBarCodeFont.Text.Trim), GetFontStyle("Regular"))
            Dim DataTextFont As New Font(cmbDataTextFontTyp.Text, CSng(txtDataTextFont.Text.Trim), GetFontStyle(cmbTextBoldRegular.Text.Trim))
            Dim CompFont As New Font(cmbCompFontTyp.Text, CSng(txtCompFont.Text.Trim), GetFontStyle(StringStyle:=cmbCompFontBoldRegular.Text.Trim))
            Dim CountryFontTyp As New Font(cmbCountryFontTyp.Text, CSng(txtCountryFont.Text.Trim), GetFontStyle(StringStyle:=cmbCountryFontBoldRegular.Text.Trim))
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'رقم الباركود يمين
            e.Graphics.DrawString("*" & txtBarCodeRight.Text.Trim & "*", BarCodeFont, Brushes.Black, txtBarcodLfRtR.Text.Trim, txtBarcodUpDoR.Text.Trim)
            e.Graphics.DrawString(txtBarCodeRight.Text.Trim, DataTextFont, Brushes.Black, txtBarcodLfRtRV.Text, txtBarcodUpDoRV.Text)
            'رقم الباركود يسار 
            e.Graphics.DrawString("*" & txtBarCodeLeft.Text.Trim & "*", BarCodeFont, Brushes.Black, txtBarcodLfRtL.Text.Trim, txtBarcodUpDoL.Text.Trim)
            e.Graphics.DrawString(txtBarCodeLeft.Text.Trim, DataTextFont, Brushes.Black, txtBarcodLfRtLV.Text, txtBarcodUpDoLV.Text)
            'اسم الصنف الجه اليمني
            e.Graphics.DrawString(ItemNameR, DataTextFont, Brushes.Black, txtItemNameRtLfR.Text, txtItemNameUpDoR.Text)
            'اسم الصنف الجه اليسري
            e.Graphics.DrawString(ItemNameL, DataTextFont, Brushes.Black, txtItemNameRtLfL.Text, txtItemNameUpDoL.Text)

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'عيار الجه اليمني رقم
            e.Graphics.DrawString(KaratR, DataTextFont, Brushes.Black, txtKaratRtLfRV.Text, txtKaratUpDoRVu.Text)
            ' عيار الجه اليسري رقم
            e.Graphics.DrawString(KaratL, DataTextFont, Brushes.Black, txtKaratRtLfLV.Text, txtKaratUpDoLVu.Text)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'نص  عيار الجه اليمني 
            e.Graphics.DrawString(txtKaratR.Text.Trim, DataTextFont, Brushes.Black, txtKaratRtLfR.Text, txtKaratUpDoR.Text)
            'نص عيار   الجه اليسري 
            e.Graphics.DrawString(txtKaratL.Text.Trim, DataTextFont, Brushes.Black, txtKaratRtLfL.Text, txtKaratUpDoL.Text)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' وزن الجه اليمني رقم
            e.Graphics.DrawString(MetalWeightR, DataTextFont, Brushes.Black, txtMetalWeightRtLfRV.Text, txtMetalWeightUpDoRV.Text)
            ' وزن الجه اليسري رقم 
            e.Graphics.DrawString(MetalWeightL, DataTextFont, Brushes.Black, txtMetalWeightRtLfLV.Text, txtMetalWeightUpDoLV.Text)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'نص وزن الجه اليمني 
            e.Graphics.DrawString(txtMetalWeightR.Text.Trim, DataTextFont, Brushes.Black, txtMetalWeightRtLfR.Text, txtMetalWeightUpDoR.Text)
            'نص وزن الجه اليسري 
            e.Graphics.DrawString(txtMetalWeightL.Text.Trim, DataTextFont, Brushes.Black, txtMetalWeightRtLfL.Text, txtMetalWeightUpDoL.Text)

            'نص المصنيعه الجه اليمني 
            e.Graphics.DrawString(txtMakeChargeR.Text.Trim, DataTextFont, Brushes.Black, txtMakeChargeRtLfR.Text, txtMakeChargeUpDoR.Text)
            'نص المصنعيه الجه اليسري 
            e.Graphics.DrawString(txtMakeChargeL.Text.Trim, DataTextFont, Brushes.Black, txtMakeChargeRtLfL.Text, txtMakeChargeUpDoL.Text)
            'رقم المصنيعه الجه اليمني 
            e.Graphics.DrawString(MakeChargeR, DataTextFont, Brushes.Black, txtMakeChargeRtLfRV.Text, txtMakeChargeUpDoRV.Text)
            'رقم المصنعيه الجه اليسري 
            e.Graphics.DrawString(MakeChargeL, DataTextFont, Brushes.Black, txtMakeChargeRtLfLV.Text, txtMakeChargeUpDoLV.Text)




            'نص التكلفه للجرام الجه اليمني 
            e.Graphics.DrawString(txtCostPerGramR.Text.Trim, DataTextFont, Brushes.Black, txtCostPerGramRtLfR.Text, txtCostPerGramUpDoR.Text)
            'نص التكلفه للجرام الجه اليسري 
            e.Graphics.DrawString(txtCostPerGramL.Text.Trim, DataTextFont, Brushes.Black, txtCostPerGramRtLfL.Text, txtCostPerGramUpDoL.Text)
            'رقم التكلفه للجرام الجه اليمني 
            e.Graphics.DrawString(CostPerGramR, DataTextFont, Brushes.Black, txtCostPerGramRtLfRV.Text, txtCostPerGramUpDoRV.Text)
            'رقم التكلفه للجرام الجه اليسري 
            e.Graphics.DrawString(CostPerGramL, DataTextFont, Brushes.Black, txtCostPerGramRtLfLV.Text, txtCostPerGramUpDoLV.Text)



            'نص بلد المنشأ الجه اليمني 
            e.Graphics.DrawString(txtCountryR.Text.Trim, CountryFontTyp, Brushes.Black, txtCountryRtLfR.Text, txtCountryUpDoR.Text)
            'نص بلد المنشأ الجه اليسري 
            e.Graphics.DrawString(txtCountryL.Text.Trim, CountryFontTyp, Brushes.Black, txtCountryRtLfL.Text, txtCountryUpDoL.Text)
            ' بلد المنشأ الجه اليمني 
            e.Graphics.DrawString(CountryR, CountryFontTyp, Brushes.Black, txtCountryLfRtRV.Text, txtCountryUpDoRV.Text)
            ' بلد المنشأ الجه اليسري 
            e.Graphics.DrawString(CountryL, CountryFontTyp, Brushes.Black, txtCountryLfRtLV.Text, txtCountryUpDoLV.Text)




            'نص المورد  الجه اليمني 
            e.Graphics.DrawString(txtSupplierR.Text.Trim, DataTextFont, Brushes.Black, txtSupplierRtLfR.Text, txtSupplierUpDoR.Text)
            'نص المورد  الجه اليسري 
            e.Graphics.DrawString(txtSupplierL.Text.Trim, DataTextFont, Brushes.Black, txtSupplierRtLfL.Text, txtSupplierUpDoL.Text)
            ' المورد  الجه اليمني 
            e.Graphics.DrawString(SupplierR, DataTextFont, Brushes.Black, txtSupplierRtLfRV.Text, txtSupplierUpDoRV.Text)
            ' المورد  الجه اليسري 
            e.Graphics.DrawString(SupplierL, DataTextFont, Brushes.Black, txtSupplierRtLfLV.Text, txtSupplierUpDoLV.Text)



            'نص رقم فاتورة الشراء  الجه اليمني 
            e.Graphics.DrawString(txtPurInvNumberR.Text.Trim, DataTextFont, Brushes.Black, txtPurInvNumberRtLfR.Text, txtPurInvNumberUpDoR.Text)
            'نص رقم فاتورة الشراء  الجه اليسري 
            e.Graphics.DrawString(txtPurInvNumberL.Text.Trim, DataTextFont, Brushes.Black, txtPurInvNumberRtLfL.Text, txtPurInvNumberUpDoL.Text)
            'رقم فاتورة الشراء  الجه اليمني 
            e.Graphics.DrawString(PurInvNumberR, DataTextFont, Brushes.Black, txtPurInvNumberRtLfRV.Text, txtPurInvNumberUpDoRV.Text)
            'نص رقم فاتورة الشراء  الجه اليسري 
            e.Graphics.DrawString(PurInvNumberL, DataTextFont, Brushes.Black, txtPurInvNumberRtLfLV.Text, txtPurInvNumberUpDoLV.Text)



            'نص رقم القطعه   الجه اليمني   
            e.Graphics.DrawString(txtCodeR.Text.Trim, DataTextFont, Brushes.Black, txtCodeRtLfR.Text, txtCodeUpDoR.Text)
            'نص رقم القطعه   الجه اليسري 
            e.Graphics.DrawString(txtCodeL.Text.Trim, DataTextFont, Brushes.Black, txtCodeRtLfL.Text, txtCodeUpDoL.Text)
            'رقم القطعه   الجه اليمني 
            e.Graphics.DrawString(CodeR, DataTextFont, Brushes.Black, txtCodeRtLfRV.Text, txtCodeUpDoRV.Text)
            'رقم القطعه الجه اليسري 
            e.Graphics.DrawString(CodeL, DataTextFont, Brushes.Black, txtCodeRtLfLV.Text, txtCodeUpDoLV.Text)






            'نص تكلفة القطعه اليمني
            e.Graphics.DrawString(txtCostPerItemR.Text.Trim, DataTextFont, Brushes.Black, txtCostPerItemRtLfR.Text, txtCostPerItemUpDoR.Text)
            'نص تكلفة القطعه اليسري
            e.Graphics.DrawString(txtCostPerItemL.Text.Trim, DataTextFont, Brushes.Black, txtCostPerItemRtLfL.Text, txtCostPerItemUpDoL.Text)
            ' رقم تكلفة القطعه اليمني
            e.Graphics.DrawString(CostPerItemR, DataTextFont, Brushes.Black, txtCostPerItemRtLfRV.Text, txtCostPerItemUpDoRV.Text)
            ' رقم تكلفة القطعه اليسري
            e.Graphics.DrawString(CostPerItemL, DataTextFont, Brushes.Black, txtCostPerItemRtLfLV.Text, txtCostPerItemUpDoLV.Text)






            'نص العدد  اليمني
            e.Graphics.DrawString(txtQtyR.Text.Trim, DataTextFont, Brushes.Black, txtQtyRtLfR.Text, txtQtyUpDoR.Text)
            'نص العدد  اليسري
            e.Graphics.DrawString(txtQtyL.Text.Trim, DataTextFont, Brushes.Black, txtQtyRtLfL.Text, txtQtyUpDoL.Text)
            ' رقم العدد  اليمني
            e.Graphics.DrawString(QtyR, DataTextFont, Brushes.Black, txtQtyRtLfRV.Text, txtQtyUpDoRV.Text)
            ' رقم العدد  اليسري
            e.Graphics.DrawString(QtyL, DataTextFont, Brushes.Black, txtQtyRtLfLV.Text, txtQtyUpDoLV.Text)






            'اسم الحجر الجه اليمني
            e.Graphics.DrawString(txtStoneWeightR.Text.Trim, DataTextFont, Brushes.Black, txtStoneWeightRtLfR.Text, txtStoneWeightUpDoR.Text)
            'اسم الحجر الجه اليسري
            e.Graphics.DrawString(txtStoneWeightL.Text.Trim, DataTextFont, Brushes.Black, txtStoneWeightRtLfL.Text, txtStoneWeightUpDoL.Text)
            'قيمة الحجر الجه اليمني
            e.Graphics.DrawString(StoneWeightR, DataTextFont, Brushes.Black, txtStoneWeightRtLfRV.Text, txtStoneWeightUpDoRV.Text)
            'قيمة الحجر الجه اليسري
            e.Graphics.DrawString(StoneWeightL, DataTextFont, Brushes.Black, txtStoneWeightRtLfLV.Text, txtStoneWeightUpDoLV.Text)





            'اسم سعر  الحجر الجه اليمني
            e.Graphics.DrawString(txtStonePriceR.Text.Trim, DataTextFont, Brushes.Black, txtStonePriceRtLfR.Text, txtStonePriceUpDoR.Text)
            'اسم سعر الحجر الجه اليسري
            e.Graphics.DrawString(txtStonePriceL.Text.Trim, DataTextFont, Brushes.Black, txtStonePriceRtLfl.Text, txtStonePriceUpDoL.Text)
            'قيمة سعرالحجر الجه اليمني
            e.Graphics.DrawString(StonePriceR, DataTextFont, Brushes.Black, txtStonePriceRtLfRV.Text, txtStonePriceUpDoRV.Text)
            'قيمة سعرالحجر الجه اليسري
            e.Graphics.DrawString(StonePriceL, DataTextFont, Brushes.Black, txtStonePriceRtLfLV.Text, txtStonePriceUpDoLV.Text)



            'الفرع  الجه اليمني
            e.Graphics.DrawString(cmbCompany.Text.Trim, CompFont, Brushes.Black, txtShroomRtLfR.Text, txtShroomUpDoR.Text)
            'اسم الفرع الجه اليسري
            e.Graphics.DrawString(cmbCompany.Text.Trim, CompFont, Brushes.Black, txtShroomRtLfL.Text, txtShroomUpDoL.Text)




            e.Graphics.DrawImage(PicLogo.Image, CSng(txtLogoRtLfR.Text.Trim), CSng(txtLogoUpDoR.Text.Trim), CSng(txtImgeSize.Text.Trim), CSng(txtImgeSize.Text.Trim))

            e.Graphics.DrawImage(PicLogo.Image, CSng(txtLogoRtLfL.Text.Trim), CSng(txtLogoUpDoL.Text.Trim), CSng(txtImgeSize.Text.Trim), CSng(txtImgeSize.Text.Trim))

        Catch ex As Exception
        End Try
    End Sub
#Region "SILVER"
    Public Sub SilverGettData(ByVal Category As String)
        Silverselectdata = GetRecordSet("SELECT * FROM [BarcodeSet] WHERE [CategoryType]=" & Category & "")
        If Silverselectdata.Rows.Count > 0 Then
            '''''''' سميات الجه اليمني
            txtKaratR.Text = Silverselectdata.Rows(0)("FiledName").ToString()
            txtItemNameR.Text = Silverselectdata.Rows(1)("FiledName").ToString()
            txtMetalWeightR.Text = Silverselectdata.Rows(2)("FiledName").ToString()
            txtMakeChargeR.Text = Silverselectdata.Rows(3)("FiledName").ToString()
            txtCostPerGramR.Text = Silverselectdata.Rows(4)("FiledName").ToString()
            txtCountryR.Text = Silverselectdata.Rows(5)("FiledName").ToString()
            txtSupplierR.Text = Silverselectdata.Rows(6)("FiledName").ToString()
            txtPurInvNumberR.Text = Silverselectdata.Rows(7)("FiledName").ToString()
            txtCodeR.Text = Silverselectdata.Rows(8)("FiledName").ToString()
            txtCostPerItemR.Text = Silverselectdata.Rows(9)("FiledName").ToString()
            txtQtyR.Text = Silverselectdata.Rows(10)("FiledName").ToString()
            txtStoneWeightR.Text = Silverselectdata.Rows(11)("FiledName").ToString()
            txtStonePriceR.Text = Silverselectdata.Rows(12)("FiledName").ToString()
            txtBarcodTxtR.Text = Silverselectdata.Rows(26)("FiledName").ToString()
            ''''''''''''''''''قياس مسميات الجه اليمني افقي 
            txtKaratUpDoR.Text = Silverselectdata.Rows(0)("txtUpDoR").ToString()
            txtItemNameUpDoR.Text = Silverselectdata.Rows(1)("txtUpDoR").ToString()
            txtMetalWeightUpDoR.Text = Silverselectdata.Rows(2)("txtUpDoR").ToString()
            txtMakeChargeUpDoR.Text = Silverselectdata.Rows(3)("txtUpDoR").ToString()
            txtCostPerGramUpDoR.Text = Silverselectdata.Rows(4)("txtUpDoR").ToString()
            txtCountryUpDoR.Text = Silverselectdata.Rows(5)("txtUpDoR").ToString()
            txtSupplierUpDoR.Text = Silverselectdata.Rows(6)("txtUpDoR").ToString()
            txtPurInvNumberUpDoR.Text = Silverselectdata.Rows(7)("txtUpDoR").ToString()
            txtCodeUpDoR.Text = Silverselectdata.Rows(8)("txtUpDoR").ToString()
            txtCostPerItemUpDoR.Text = Silverselectdata.Rows(9)("txtUpDoR").ToString()
            txtQtyUpDoR.Text = Silverselectdata.Rows(10)("txtUpDoR").ToString()
            txtStoneWeightUpDoR.Text = Silverselectdata.Rows(11)("txtUpDoR").ToString()
            txtStonePriceUpDoR.Text = Silverselectdata.Rows(12)("txtUpDoR").ToString()
            txtBarcodUpDoR.Text = Silverselectdata.Rows(26)("txtUpDoR").ToString()
            ''''''''''''''''''قياس مسميات الجه اليمني رأسي 
            txtKaratRtLfR.Text = Silverselectdata.Rows(0)("txtRtLfR").ToString()
            txtItemNameRtLfR.Text = Silverselectdata.Rows(1)("txtRtLfR").ToString()
            txtMetalWeightRtLfR.Text = Silverselectdata.Rows(2)("txtRtLfR").ToString()
            txtMakeChargeRtLfR.Text = Silverselectdata.Rows(3)("txtRtLfR").ToString()
            txtCostPerGramRtLfR.Text = Silverselectdata.Rows(4)("txtRtLfR").ToString()
            txtCountryRtLfR.Text = Silverselectdata.Rows(5)("txtRtLfR").ToString()
            txtSupplierRtLfR.Text = Silverselectdata.Rows(6)("txtRtLfR").ToString()
            txtPurInvNumberRtLfR.Text = Silverselectdata.Rows(7)("txtRtLfR").ToString()
            txtCodeRtLfR.Text = Silverselectdata.Rows(8)("txtRtLfR").ToString()
            txtCostPerItemRtLfR.Text = Silverselectdata.Rows(9)("txtRtLfR").ToString()
            txtQtyRtLfR.Text = Silverselectdata.Rows(10)("txtRtLfR").ToString()
            txtStoneWeightRtLfR.Text = Silverselectdata.Rows(11)("txtRtLfR").ToString()
            txtStonePriceRtLfR.Text = Silverselectdata.Rows(12)("txtRtLfR").ToString()
            txtBarcodLfRtR.Text = Silverselectdata.Rows(26)("txtRtLfR").ToString()
            '''''''''''''''''''''''''قياس الارقام الجه اليمني افقي
            txtKaratUpDoRVu.Text = Silverselectdata.Rows(0)("txtValuUpDoR").ToString()
            txtItemNameUpDoRV.Text = Silverselectdata.Rows(1)("txtValuUpDoR").ToString()
            txtMetalWeightUpDoRV.Text = Silverselectdata.Rows(2)("txtValuUpDoR").ToString()
            txtMakeChargeUpDoRV.Text = Silverselectdata.Rows(3)("txtValuUpDoR").ToString()
            txtCostPerGramUpDoRV.Text = Silverselectdata.Rows(4)("txtValuUpDoR").ToString()
            txtCountryUpDoRV.Text = Silverselectdata.Rows(5)("txtValuUpDoR").ToString()
            txtSupplierUpDoRV.Text = Silverselectdata.Rows(6)("txtValuUpDoR").ToString()
            txtPurInvNumberUpDoRV.Text = Silverselectdata.Rows(7)("txtValuUpDoR").ToString()
            txtCodeUpDoRV.Text = Silverselectdata.Rows(8)("txtValuUpDoR").ToString()
            txtCostPerItemUpDoRV.Text = Silverselectdata.Rows(9)("txtValuUpDoR").ToString()
            txtQtyUpDoRV.Text = Silverselectdata.Rows(10)("txtValuUpDoR").ToString()
            txtStoneWeightUpDoRV.Text = Silverselectdata.Rows(11)("txtValuUpDoR").ToString()
            txtStonePriceUpDoRV.Text = Silverselectdata.Rows(12)("txtValuUpDoR").ToString()
            txtBarcodUpDoRV.Text = Silverselectdata.Rows(26)("txtValuUpDoR").ToString()
            '''''''''''''''''''''''''قياس الارقام الجه اليمني رأس
            txtKaratRtLfRV.Text = Silverselectdata.Rows(0)("txtValuRtLfR").ToString()
            txtItemNameRtLfRV.Text = Silverselectdata.Rows(1)("txtValuRtLfR").ToString()
            txtMetalWeightRtLfRV.Text = Silverselectdata.Rows(2)("txtValuRtLfR").ToString()
            txtMakeChargeRtLfRV.Text = Silverselectdata.Rows(3)("txtValuRtLfR").ToString()
            txtCostPerGramRtLfRV.Text = Silverselectdata.Rows(4)("txtValuRtLfR").ToString()
            txtCountryLfRtRV.Text = Silverselectdata.Rows(5)("txtValuRtLfR").ToString()
            txtSupplierRtLfRV.Text = Silverselectdata.Rows(6)("txtValuRtLfR").ToString()
            txtPurInvNumberRtLfRV.Text = Silverselectdata.Rows(7)("txtValuRtLfR").ToString()
            txtCodeRtLfRV.Text = Silverselectdata.Rows(8)("txtValuRtLfR").ToString()
            txtCostPerItemRtLfRV.Text = Silverselectdata.Rows(9)("txtValuRtLfR").ToString()
            txtQtyRtLfRV.Text = Silverselectdata.Rows(10)("txtValuRtLfR").ToString()
            txtStoneWeightRtLfRV.Text = Silverselectdata.Rows(11)("txtValuRtLfR").ToString()
            txtStonePriceRtLfRV.Text = Silverselectdata.Rows(12)("txtValuRtLfR").ToString()
            txtBarcodLfRtRV.Text = Silverselectdata.Rows(26)("txtValuRtLfR").ToString()
            ''اسم المعرض يمين
            txtShroomUpDoR.Text = Silverselectdata.Rows(0)("txtShroomUpDo").ToString()
            txtShroomRtLfR.Text = Silverselectdata.Rows(0)("txtShroomRtLf").ToString()
            'لوقو المعرض يمين 
            txtLogoUpDoR.Text = Silverselectdata.Rows(0)("txtLogoUpDo").ToString()
            txtLogoRtLfR.Text = Silverselectdata.Rows(0)("txtLogoRtLf").ToString()


            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\مسميات الجه اليسري\\\\\\\\\\\\\\\\\\\\\\\\
            '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            '''''''''''''' سميات الجه اليسري
            txtKaratL.Text = Silverselectdata.Rows(13)("FiledName").ToString()
            txtItemNameL.Text = Silverselectdata.Rows(14)("FiledName").ToString()
            txtMetalWeightL.Text = Silverselectdata.Rows(15)("FiledName").ToString()
            txtMakeChargeL.Text = Silverselectdata.Rows(16)("FiledName").ToString()
            txtCostPerGramL.Text = Silverselectdata.Rows(17)("FiledName").ToString()
            txtCountryL.Text = Silverselectdata.Rows(18)("FiledName").ToString()
            txtSupplierL.Text = Silverselectdata.Rows(19)("FiledName").ToString()
            txtPurInvNumberL.Text = Silverselectdata.Rows(20)("FiledName").ToString()
            txtCodeL.Text = Silverselectdata.Rows(21)("FiledName").ToString()
            txtCostPerItemL.Text = Silverselectdata.Rows(22)("FiledName").ToString()
            txtQtyL.Text = Silverselectdata.Rows(23)("FiledName").ToString()
            txtStoneWeightL.Text = Silverselectdata.Rows(24)("FiledName").ToString()
            txtStonePriceL.Text = Silverselectdata.Rows(25)("FiledName").ToString()
            txtBarcodTxtL.Text = Silverselectdata.Rows(27)("FiledName").ToString()

            ''''''''''''''''''قياس مسميات الجه اليسري افقي 
            txtKaratUpDoL.Text = Silverselectdata.Rows(13)("txtUpDoR").ToString()
            txtItemNameUpDoL.Text = Silverselectdata.Rows(14)("txtUpDoR").ToString()
            txtMetalWeightUpDoL.Text = Silverselectdata.Rows(15)("txtUpDoR").ToString()
            txtMakeChargeUpDoL.Text = Silverselectdata.Rows(16)("txtUpDoR").ToString()
            txtCostPerGramUpDoL.Text = Silverselectdata.Rows(17)("txtUpDoR").ToString()
            txtCountryUpDoL.Text = Silverselectdata.Rows(18)("txtUpDoR").ToString()
            txtSupplierUpDoL.Text = Silverselectdata.Rows(19)("txtUpDoR").ToString()
            txtPurInvNumberUpDoL.Text = Silverselectdata.Rows(20)("txtUpDoR").ToString()
            txtCodeUpDoL.Text = Silverselectdata.Rows(21)("txtUpDoR").ToString()
            txtCostPerItemUpDoL.Text = Silverselectdata.Rows(22)("txtUpDoR").ToString()
            txtQtyUpDoL.Text = Silverselectdata.Rows(23)("txtUpDoR").ToString()
            txtStoneWeightUpDoL.Text = Silverselectdata.Rows(24)("txtUpDoR").ToString()
            txtStonePriceUpDoL.Text = Silverselectdata.Rows(25)("txtUpDoR").ToString()
            txtBarcodUpDoL.Text = Silverselectdata.Rows(27)("txtUpDoR").ToString()
            '''''''''''''''''''قياس مسميات الجه اليسري رأسي 
            txtKaratRtLfL.Text = Silverselectdata.Rows(13)("txtRtLfR").ToString()
            txtItemNameRtLfL.Text = Silverselectdata.Rows(14)("txtRtLfR").ToString()
            txtMetalWeightRtLfL.Text = Silverselectdata.Rows(15)("txtRtLfR").ToString()
            txtMakeChargeRtLfL.Text = Silverselectdata.Rows(16)("txtRtLfR").ToString()
            txtCostPerGramRtLfL.Text = Silverselectdata.Rows(17)("txtRtLfR").ToString()
            txtCountryRtLfL.Text = Silverselectdata.Rows(18)("txtRtLfR").ToString()
            txtSupplierRtLfL.Text = Silverselectdata.Rows(19)("txtRtLfR").ToString()
            txtPurInvNumberRtLfL.Text = Silverselectdata.Rows(20)("txtRtLfR").ToString()
            txtCodeRtLfL.Text = Silverselectdata.Rows(21)("txtRtLfR").ToString()
            txtCostPerItemRtLfL.Text = Silverselectdata.Rows(22)("txtRtLfR").ToString()
            txtQtyRtLfL.Text = Silverselectdata.Rows(23)("txtRtLfR").ToString()
            txtStoneWeightRtLfL.Text = Silverselectdata.Rows(24)("txtRtLfR").ToString()
            txtStonePriceRtLfl.Text = Silverselectdata.Rows(25)("txtRtLfR").ToString()
            txtBarcodLfRtL.Text = Silverselectdata.Rows(27)("txtRtLfR").ToString()
            '''''''''''''''''''''''''قياس الارقام الجه اليسري افقي
            txtKaratUpDoLVu.Text = Silverselectdata.Rows(13)("txtValuUpDoR").ToString()
            txtItemNameUpDoLV.Text = Silverselectdata.Rows(14)("txtValuUpDoR").ToString()
            txtMetalWeightUpDoLV.Text = Silverselectdata.Rows(15)("txtValuUpDoR").ToString()
            txtMakeChargeUpDoLV.Text = Silverselectdata.Rows(16)("txtValuUpDoR").ToString()
            txtCostPerGramUpDoLV.Text = Silverselectdata.Rows(17)("txtValuUpDoR").ToString()
            txtCountryUpDoLV.Text = Silverselectdata.Rows(18)("txtValuUpDoR").ToString()
            txtSupplierUpDoLV.Text = Silverselectdata.Rows(19)("txtValuUpDoR").ToString()
            txtPurInvNumberUpDoLV.Text = Silverselectdata.Rows(20)("txtValuUpDoR").ToString()
            txtCodeUpDoLV.Text = Silverselectdata.Rows(21)("txtValuUpDoR").ToString()
            txtCostPerItemUpDoLV.Text = Silverselectdata.Rows(22)("txtValuUpDoR").ToString()
            txtQtyUpDoLV.Text = Silverselectdata.Rows(23)("txtValuUpDoR").ToString()
            txtStoneWeightUpDoLV.Text = Silverselectdata.Rows(24)("txtValuUpDoR").ToString()
            txtStonePriceUpDoLV.Text = Silverselectdata.Rows(25)("txtValuUpDoR").ToString()
            txtBarcodUpDoLV.Text = Silverselectdata.Rows(27)("txtValuUpDoR").ToString()
            '''''''''''''''''''''''''قياس الارقام الجه اليسري رأس
            txtKaratRtLfLV.Text = Silverselectdata.Rows(13)("txtValuRtLfR").ToString()
            txtItemNameRtLfLV.Text = Silverselectdata.Rows(14)("txtValuRtLfR").ToString()
            txtMetalWeightRtLfLV.Text = Silverselectdata.Rows(15)("txtValuRtLfR").ToString()
            txtMakeChargeRtLfLV.Text = Silverselectdata.Rows(16)("txtValuRtLfR").ToString()
            txtCostPerGramRtLfLV.Text = Silverselectdata.Rows(17)("txtValuRtLfR").ToString()
            txtCountryLfRtLV.Text = Silverselectdata.Rows(18)("txtValuRtLfR").ToString()
            txtSupplierRtLfLV.Text = Silverselectdata.Rows(19)("txtValuRtLfR").ToString()
            txtPurInvNumberRtLfLV.Text = Silverselectdata.Rows(20)("txtValuRtLfR").ToString()
            txtCodeRtLfLV.Text = Silverselectdata.Rows(21)("txtValuRtLfR").ToString()
            txtCostPerItemRtLfLV.Text = Silverselectdata.Rows(22)("txtValuRtLfR").ToString()
            txtQtyRtLfLV.Text = Silverselectdata.Rows(23)("txtValuRtLfR").ToString()
            txtStoneWeightRtLfLV.Text = Silverselectdata.Rows(24)("txtValuRtLfR").ToString()
            txtStonePriceRtLfLV.Text = Silverselectdata.Rows(25)("txtValuRtLfR").ToString()
            txtBarcodLfRtLV.Text = Silverselectdata.Rows(27)("txtValuRtLfR").ToString()
            'اسم المعرض يسار
            txtShroomUpDoL.Text = Silverselectdata.Rows(14)("txtShroomUpDo").ToString()
            txtShroomRtLfL.Text = Silverselectdata.Rows(14)("txtShroomRtLf").ToString()
            'لوقو المعرض يسار 
            txtLogoUpDoL.Text = Silverselectdata.Rows(14)("txtLogoUpDo").ToString()
            txtLogoRtLfL.Text = Silverselectdata.Rows(14)("txtLogoRtLf").ToString()

            ''''' عام '''''''''''''''''''''
            txtImgeSize.Text = Silverselectdata.Rows(1)("txtImgeSize").ToString()
        End If

    End Sub


#End Region
#Region "Gold"
    Public Sub GoldGettData()

    End Sub
#End Region
    Public Sub FontSet()
        Dim DtFontSet As DataTable = GetRecordSet("SELECT BarcodFontName, FontName, TextFontSize, TextFontShape, " & vbCrLf &
                                                  "txtCompFont, cmbCompFontTyp, cmbCompFontShape, " & vbCrLf &
                                                  "txtCountryFont, cmbCountryFontTyp, txtBarCodeFont, cmbBarCodeFontTyp, " & vbCrLf &
                                                  "CountryFontShape, cmbPrinter,txtShoromName" & vbCrLf &
                                                  "FROM dbo.BarcodeSet" & vbCrLf &
                                                  "GROUP BY BarcodFontName, FontName, " & vbCrLf &
                                                  "TextFontSize, TextFontShape, txtCompFont, " & vbCrLf &
                                                  "cmbCompFontTyp, cmbCompFontShape, txtCountryFont, cmbCountryFontTyp, txtBarCodeFont, cmbBarCodeFontTyp, " & vbCrLf &
                                                  "CountryFontShape, cmbPrinter,txtShoromName")
        If DtFontSet.Rows.Count > 0 Then
            ''''''''الخط العام
            cmbDataTextFontTyp.Text = DtFontSet.Rows(0)(1).ToString()
            txtDataTextFont.Text = DtFontSet.Rows(0)(2).ToString()
            cmbTextBoldRegular.Text = DtFontSet.Rows(0)(3).ToString()
            '''''''''''''''''''''خط الباركود
            cmbBarCodeFontTyp.Text = DtFontSet.Rows(0)(0).ToString()
            txtBarCodeFont.Text = DtFontSet.Rows(0)(9).ToString()
            ''''''''''''''''خط المعرض
            txtCompFont.Text = DtFontSet.Rows(0)(4).ToString()
            cmbCompFontTyp.Text = DtFontSet.Rows(0)(5).ToString()
            cmbCompFontBoldRegular.Text = DtFontSet.Rows(0)(6).ToString()
            ''''''''بلد المنشاء
            txtCountryFont.Text = DtFontSet.Rows(0)(7).ToString()
            cmbCountryFontTyp.Text = DtFontSet.Rows(0)(8).ToString()
            cmbCountryFontBoldRegular.Text = DtFontSet.Rows(0)(11).ToString()
            ''''''''''تحديد الطابعه واسم المعرض
            cmbPrinter.Text = DtFontSet.Rows(0)(12).ToString()
            cmbCompany.Text = DtFontSet.Rows(0)(13).ToString()
        End If
    End Sub

    Private Sub gbRightText_Enter(sender As Object, e As EventArgs) Handles gbRightText.Enter
        Preview()
    End Sub

    Private Sub gbLeftValue_Enter(sender As Object, e As EventArgs) Handles gbLeftValue.Enter
        Preview()
    End Sub

    Private Sub txtPupName()
        'TolTIPtxtName.SetToolTip(txtBarcodTxtR, "رقم الباركود" & vbCrLf & "Barcod.")
        TolTIPtxtName.SetToolTip(txtBarcodTxtR, "باركود" & vbCrLf & "Barcod.")
        TolTIPtxtName.SetToolTip(txtKaratR, "عيار" & vbCrLf & "Karat")
        TolTIPtxtName.SetToolTip(txtItemNameR, "اسم الصنف" & vbCrLf & "Item Name")
        TolTIPtxtName.SetToolTip(txtMetalWeightR, "وزن المعدن" & vbCrLf & "Metal Weight")
        TolTIPtxtName.SetToolTip(txtMakeChargeR, "المصنعيه" & vbCrLf & "Make Charge")
        TolTIPtxtName.SetToolTip(txtCostPerGramR, "تكلفة الجرام" & vbCrLf & "Cost Per Gram")
        TolTIPtxtName.SetToolTip(txtCountryR, "بلد المنشا" & vbCrLf & "Country")
        TolTIPtxtName.SetToolTip(txtSupplierR, "المورد" & vbCrLf & "Supplier")
        TolTIPtxtName.SetToolTip(txtPurInvNumberR, "رقم فاتورة الشراء" & vbCrLf & "PurInv Number")
        TolTIPtxtName.SetToolTip(txtCodeR, "الرمز" & vbCrLf & "Code")
        TolTIPtxtName.SetToolTip(txtCostPerItemR, "تكلفة القطعه" & vbCrLf & "Cost Per Item")
        TolTIPtxtName.SetToolTip(txtQtyR, "العدد" & vbCrLf & "Qty")
        TolTIPtxtName.SetToolTip(txtStoneWeightR, "وزن الاحجار" & vbCrLf & "Stone Weight")
        TolTIPtxtName.SetToolTip(txtStonePriceR, "سعر الاحجار" & vbCrLf & "Stone Price")
        TolTIPtxtName.SetToolTip(txtBarcodTxtL, "باركود" & vbCrLf & "Barcod")
        TolTIPtxtName.SetToolTip(txtKaratL, "عيار" & vbCrLf & "Karat")
        TolTIPtxtName.SetToolTip(txtItemNameL, "اسم الصنف" & vbCrLf & "Item Name")
        TolTIPtxtName.SetToolTip(txtMetalWeightL, "وزن المعدن" & vbCrLf & "Metal Weight")
        TolTIPtxtName.SetToolTip(txtMakeChargeL, "المصنعيه" & vbCrLf & "Make Charge")
        TolTIPtxtName.SetToolTip(txtCostPerGramL, "تكلفة الجرام" & vbCrLf & "Cost Per Gram")
        TolTIPtxtName.SetToolTip(txtCountryL, "بلد المنشا" & vbCrLf & "Country")
        TolTIPtxtName.SetToolTip(txtSupplierL, "المورد" & vbCrLf & "Supplier")
        TolTIPtxtName.SetToolTip(txtPurInvNumberL, "رقم فاتورة الشراء" & vbCrLf & "PurInv Number")
        TolTIPtxtName.SetToolTip(txtCodeL, "الرمز" & vbCrLf & "Code")
        TolTIPtxtName.SetToolTip(txtCostPerItemL, "تكلفة القطعه" & vbCrLf & "Cost PerI tem")
        TolTIPtxtName.SetToolTip(txtQtyL, "العدد" & vbCrLf & "Qty")
        TolTIPtxtName.SetToolTip(txtStoneWeightL, "وزن الاحجار" & vbCrLf & "Stone Weight")
        TolTIPtxtName.SetToolTip(txtStonePriceL, "سعر الاحجار" & vbCrLf & "Stone Price")
    End Sub
    Private Sub SilverBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        SilverGettData(Category:=TPCategory)
        FontSet()
        GetItemData(TpName:=SQLTP)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        txtPupName()
        GetImg()
        PrintRange()

    End Sub
    Private Sub cmbPrinter_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbPrinter.MouseClick
        cmbPrinter.Items.Clear()
        For Each InstalledPrinter As String In Printing.PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(InstalledPrinter)
        Next
    End Sub
    Private Sub txtKaratRtLfLV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierUpDoRV.KeyPress, txtSupplierUpDoR.KeyPress, txtSupplierUpDoLV.KeyPress, txtSupplierUpDoL.KeyPress, txtSupplierRtLfRV.KeyPress, txtSupplierRtLfR.KeyPress, txtSupplierRtLfLV.KeyPress, txtSupplierRtLfL.KeyPress, txtStoneWeightUpDoRV.KeyPress, txtStoneWeightUpDoR.KeyPress, txtStoneWeightUpDoLV.KeyPress, txtStoneWeightUpDoL.KeyPress, txtStoneWeightRtLfRV.KeyPress, txtStoneWeightRtLfR.KeyPress, txtStoneWeightRtLfLV.KeyPress, txtStoneWeightRtLfL.KeyPress, txtStonePriceUpDoRV.KeyPress, txtStonePriceUpDoR.KeyPress, txtStonePriceUpDoLV.KeyPress, txtStonePriceUpDoL.KeyPress, txtStonePriceRtLfRV.KeyPress, txtStonePriceRtLfR.KeyPress, txtStonePriceRtLfLV.KeyPress, txtStonePriceRtLfl.KeyPress, txtQtyUpDoRV.KeyPress, txtQtyUpDoR.KeyPress, txtQtyUpDoLV.KeyPress, txtQtyUpDoL.KeyPress, txtQtyRtLfRV.KeyPress, txtQtyRtLfR.KeyPress, txtQtyRtLfLV.KeyPress, txtQtyRtLfL.KeyPress, txtPurInvNumberUpDoRV.KeyPress, txtPurInvNumberUpDoR.KeyPress, txtPurInvNumberUpDoLV.KeyPress, txtPurInvNumberUpDoL.KeyPress, txtPurInvNumberRtLfRV.KeyPress, txtPurInvNumberRtLfR.KeyPress, txtPurInvNumberRtLfLV.KeyPress, txtPurInvNumberRtLfL.KeyPress, txtMetalWeightUpDoRV.KeyPress, txtMetalWeightUpDoR.KeyPress, txtMetalWeightUpDoLV.KeyPress, txtMetalWeightUpDoL.KeyPress, txtMetalWeightRtLfRV.KeyPress, txtMetalWeightRtLfR.KeyPress, txtMetalWeightRtLfLV.KeyPress, txtMetalWeightRtLfL.KeyPress, txtMakeChargeUpDoRV.KeyPress, txtMakeChargeUpDoR.KeyPress, txtMakeChargeUpDoLV.KeyPress, txtMakeChargeUpDoL.KeyPress, txtMakeChargeRtLfRV.KeyPress, txtMakeChargeRtLfR.KeyPress, txtMakeChargeRtLfLV.KeyPress, txtMakeChargeRtLfL.KeyPress, txtKaratUpDoRVu.KeyPress, txtKaratUpDoR.KeyPress, txtKaratUpDoLVu.KeyPress, txtKaratUpDoL.KeyPress, txtKaratRtLfRV.KeyPress, txtKaratRtLfR.KeyPress, txtKaratRtLfLV.KeyPress, txtKaratRtLfL.KeyPress, txtItemNameUpDoRV.KeyPress, txtItemNameUpDoR.KeyPress, txtItemNameUpDoLV.KeyPress, txtItemNameUpDoL.KeyPress, txtItemNameRtLfRV.KeyPress, txtItemNameRtLfR.KeyPress, txtItemNameRtLfLV.KeyPress, txtItemNameRtLfL.KeyPress, txtCountryUpDoRV.KeyPress, txtCountryUpDoR.KeyPress, txtCountryUpDoLV.KeyPress, txtCountryUpDoL.KeyPress, txtCountryRtLfL.KeyPress, txtCountryLfRtRV.KeyPress, txtCountryRtLfR.KeyPress, txtCountryLfRtLV.KeyPress, txtCostPerItemUpDoRV.KeyPress, txtCostPerItemUpDoR.KeyPress, txtCostPerItemUpDoLV.KeyPress, txtCostPerItemUpDoL.KeyPress, txtCostPerItemRtLfRV.KeyPress, txtCostPerItemRtLfR.KeyPress, txtCostPerItemRtLfLV.KeyPress, txtCostPerItemRtLfL.KeyPress, txtCostPerGramUpDoRV.KeyPress, txtCostPerGramUpDoR.KeyPress, txtCostPerGramUpDoLV.KeyPress, txtCostPerGramUpDoL.KeyPress, txtCostPerGramRtLfRV.KeyPress, txtCostPerGramRtLfR.KeyPress, txtCostPerGramRtLfLV.KeyPress, txtCostPerGramRtLfL.KeyPress, txtCodeUpDoRV.KeyPress, txtCodeUpDoR.KeyPress, txtCodeUpDoLV.KeyPress, txtCodeUpDoL.KeyPress, txtCodeRtLfRV.KeyPress, txtCodeRtLfR.KeyPress, txtCodeRtLfLV.KeyPress, txtCodeRtLfL.KeyPress, TextBox90.KeyPress, TextBox88.KeyPress, TextBox86.KeyPress, txtBarcodUpDoLV.KeyPress, TextBox56.KeyPress, TextBox54.KeyPress, TextBox52.KeyPress, txtBarcodUpDoRV.KeyPress, txtBarcodLfRtR.KeyPress, TextBox20.KeyPress, txtBarcodLfRtLV.KeyPress, TextBox192.KeyPress, TextBox190.KeyPress, TextBox19.KeyPress, TextBox188.KeyPress, TextBox18.KeyPress, txtBarcodLfRtL.KeyPress, TextBox175.KeyPress, TextBox173.KeyPress, TextBox171.KeyPress, txtBarcodLfRtRV.KeyPress, TextBox146.KeyPress, TextBox144.KeyPress, TextBox142.KeyPress, txtBarcodUpDoR.KeyPress, TextBox139.KeyPress, TextBox138.KeyPress, TextBox137.KeyPress, TextBox124.KeyPress, TextBox122.KeyPress, TextBox120.KeyPress, txtBarcodUpDoL.KeyPress, gbLeftValue.KeyPress, gbLeftText.KeyPress, txtStonePriceRtLfLV.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub cmbCompFontTyp_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbCompFontTyp.MouseClick
        cmbCompFontTyp.Items.Clear()
        Dim installed_fonts As New InstalledFontCollection
        For Each FontFamily As FontFamily In installed_fonts.Families
            cmbCompFontTyp.Items.Add(FontFamily.Name)
        Next FontFamily
    End Sub

    Private Sub cmbCountryFontTyp_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbCountryFontTyp.MouseClick
        cmbCountryFontTyp.Items.Clear()
        Dim installed_fonts As New InstalledFontCollection
        For Each FontFamily As FontFamily In installed_fonts.Families
            cmbCountryFontTyp.Items.Add(FontFamily.Name)
        Next FontFamily
    End Sub

    Private Sub cmbBarCodeFontTyp_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbBarCodeFontTyp.MouseClick
        cmbBarCodeFontTyp.Items.Clear()
        Dim installed_fonts As New InstalledFontCollection
        For Each FontFamily As FontFamily In installed_fonts.Families
            cmbBarCodeFontTyp.Items.Add(FontFamily.Name)
        Next FontFamily
    End Sub

    Private Sub cmbDataTextFontTyp_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbDataTextFontTyp.MouseClick
        cmbDataTextFontTyp.Items.Clear()
        Dim installed_fonts As New InstalledFontCollection
        For Each FontFamily As FontFamily In installed_fonts.Families
            cmbDataTextFontTyp.Items.Add(FontFamily.Name)
        Next FontFamily
    End Sub

    Private Sub cmbCompany_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbCompany.MouseClick
        Dim GetShroom As DataTable = GetRecordSet("SELECT [comp_name] FROM [comp_inform]")
        If GetShroom.Rows.Count > 0 Then
            cmbCompany.DataSource = GetShroom
            cmbCompany.DisplayMember = "comp_name"
            cmbCompany.ValueMember = "comp_name"
            cmbCompany.DropDownWidth = GetMaxDataSize(GetShroom, "comp_name", cmbCompany)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtBarCodeRight.Text = Val(cmbRightItem.SelectedValue).ToString
    End Sub

    Private Sub cmbRightItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRightItem.SelectedIndexChanged
        If cmbRightItem.SelectedIndex = -1 OrElse cmbRightItem.ValueMember = "" Then
            Exit Sub
        End If
        If cmbRightItem.Focused = True Then
            txtBarCodeRight.Text = cmbRightItem.SelectedValue
        End If
        Preview()
        GetItemPrintDataR()
    End Sub

    Private Sub txtBarCodeRight_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeRight.TextChanged
        Try
            cmbRightItem.SelectedValue = txtBarCodeRight.Text.Trim
        Catch ex As Exception
            cmbRightItem.SelectedIndex = -1
        End Try
        Preview()
        GetItemPrintDataR()
    End Sub

    Private Sub txtBarCodeLeft_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeLeft.TextChanged
        Try
            cmbLeftItem.SelectedValue = txtBarCodeLeft.Text.Trim
        Catch ex As Exception
            cmbLeftItem.SelectedIndex = -1
        End Try
        Preview()
        GetItemPrintDataL()
    End Sub

    Private Sub cmbLeftItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLeftItem.SelectedIndexChanged
        If cmbLeftItem.SelectedIndex = -1 OrElse cmbLeftItem.ValueMember = "" Then
            Exit Sub
        End If
        If cmbLeftItem.Focused = True Then
            txtBarCodeLeft.Text = cmbLeftItem.SelectedValue
        End If
        Preview()
        GetItemPrintDataL()
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If chkPrintRange.Checked = False Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodePreview()
            Else
                PrintBarCode()
            End If
        ElseIf chkPrintRange.Checked = True Then
            RepeatPrinting()
        End If
    End Sub

    Private Sub PrintBarCodePreview()
        With PrintPreviewDialogBarcod
            .Size = New Size(800, 400)
            .StartPosition = FormStartPosition.CenterScreen
            .Document = PrintDocumentBarcod
            .PrintPreviewControl.Zoom = 1
            .ShowDialog()
        End With
    End Sub
    Public Sub PrintBarCode()
        If IsNumeric(txtQty.Text.Trim) = False Then
            MsgBox("أدخل عدد ملصقات صحيح" & vbCrLf & "Enter Valid Label Qty.", , AppTitle)
            txtQty.Focus()
            txtQty.SelectAll()
            Exit Sub
        End If
        Try
            For x As Integer = 1 To txtQty.Text
                PrintDialogBarcod.PrinterSettings.PrinterName = cmbPrinter.Text.Trim
                PrintDocumentBarcod.Print()
            Next
        Catch ex As Exception
            MsgBox("خطأ في إدخال قيم ضبط الباركود" & vbCrLf & "Error in BarCode Data", , AppTitle)
        End Try
    End Sub
    Private Sub GoldFiledSave()
        GlCommand.CommandText = " UPDATE [BarcodeSet] SET [BarcodFontName] = '" & cmbBarCodeFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[FontName]= '" & cmbDataTextFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[TextFontSize]='" & txtDataTextFont.Text.Trim & "'" & vbCrLf &
                                ",[TextFontShape] ='" & cmbTextBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[txtCompFont] = '" & txtCompFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbCompFontTyp] = '" & cmbCompFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[cmbCompFontShape] = '" & cmbCompFontBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[txtCountryFont] = '" & txtCountryFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbCountryFontTyp] ='" & cmbCountryFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[txtBarCodeFont] ='" & txtBarCodeFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbBarCodeFontTyp] ='Regular'" & vbCrLf &
                                ",[CountryFontShape] ='" & cmbCountryFontBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[cmbPrinter] = '" & cmbPrinter.Text.Trim & "'" & vbCrLf &
                                ",[txtImgeSize] = '" & txtImgeSize.Text.Trim & "'" & vbCrLf &
                                ",[txtShoromName] =N'" & cmbCompany.Text.Trim & "'"

        GlCommand.ExecuteNonQuery()



        'اعدادات الجه اليمني
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''العيار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtKaratR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtKaratUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtKaratRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtKaratUpDoRVu.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtKaratRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='1'"
        GlCommand.ExecuteNonQuery()

        ''''اسم الصنف
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtItemNameR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtItemNameUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtItemNameRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtItemNameUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtItemNameRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='2'"
        GlCommand.ExecuteNonQuery()

        '''''وزن المعدن
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMetalWeightR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMetalWeightUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMetalWeightRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMetalWeightUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMetalWeightRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='3'"
        GlCommand.ExecuteNonQuery()

        '''''المصنعيه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMakeChargeR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMakeChargeUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMakeChargeRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMakeChargeUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMakeChargeRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='4'"
        GlCommand.ExecuteNonQuery()


        '''''التكلفه بالجرام
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerGramR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerGramUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerGramRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerGramUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerGramRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='5'"
        GlCommand.ExecuteNonQuery()


        ''' بلد النشأ
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCountryR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCountryUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCountryRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCountryUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCountryLfRtRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='6'"
        GlCommand.ExecuteNonQuery()


        ''' المورد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtSupplierR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtSupplierUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtSupplierRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtSupplierUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtSupplierRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='7'"
        GlCommand.ExecuteNonQuery()


        ''' رقم فاتورة الشراء
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtPurInvNumberR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtPurInvNumberUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtPurInvNumberRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtPurInvNumberUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtPurInvNumberRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='8'"
        GlCommand.ExecuteNonQuery()


        '''الرمز
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCodeR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCodeUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCodeRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCodeUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCodeRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='9'"
        GlCommand.ExecuteNonQuery()


        '''التكلفه للقطعه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerItemR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerItemUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerItemRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerItemUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerItemRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='10'"
        GlCommand.ExecuteNonQuery()


        '''العدد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtQtyR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtQtyUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtQtyRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtQtyUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtQtyRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='11'"
        GlCommand.ExecuteNonQuery()

        '''وزن الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStoneWeightR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStoneWeightUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStoneWeightRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStoneWeightUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStoneWeightRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='12'"
        GlCommand.ExecuteNonQuery()


        '''سعر الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStonePriceR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStonePriceUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStonePriceRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStonePriceUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStonePriceRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='13'"
        GlCommand.ExecuteNonQuery()



        '''الباركود
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtBarcodTxtR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtBarcodUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtBarcodLfRtR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtBarcodUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtBarcodLfRtRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='28'"
        GlCommand.ExecuteNonQuery()
        'اسم المعرض واللوقو الجه اليمني

        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [txtShroomUpDo] = N'" & txtShroomUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtShroomRtLf] = '" & txtShroomRtLfR.Text.Trim & "'" & vbCrLf &
                                ",[txtLogoUpDo] ='" & txtLogoUpDoR.Text & "'" & vbCrLf &
                                ",[txtLogoRtLf] = '" & txtLogoRtLfR.Text & "'" & vbCrLf &
                                "WHERE  RightLeft = N'R'"
        GlCommand.ExecuteNonQuery()

        'اللوقو الجه اليمني
        GlCommand.CommandText = "UPDATE [BarcodeSet] SET [txtImge] = @txtImge  WHERE  RightLeft = N'R'"
        With GlCommand.Parameters
            .Clear()
            .Add("@txtImge", SqlDbType.Image).Value = If(PicLogo.Image Is Nothing, DBNull.Value, ImageToByte(PicLogo.Image))
        End With
        GlCommand.ExecuteNonQuery()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''العيار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtKaratL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtKaratUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtKaratRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtKaratUpDoLVu.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtKaratRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='14'"
        GlCommand.ExecuteNonQuery()
        ''''اسم الصنف
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtItemNameL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtItemNameUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtItemNameRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtItemNameUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtItemNameRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='15'"
        GlCommand.ExecuteNonQuery()

        '''''وزن المعدن
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMetalWeightL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMetalWeightUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMetalWeightRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMetalWeightUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMetalWeightRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='16'"
        GlCommand.ExecuteNonQuery()

        '''''المصنعيه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMakeChargeL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMakeChargeUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMakeChargeRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMakeChargeUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMakeChargeRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='17'"
        GlCommand.ExecuteNonQuery()


        '''''التكلفه بالجرام
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerGramL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerGramUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerGramRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerGramUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerGramRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='18'"
        GlCommand.ExecuteNonQuery()


        ''' بلد النشأ
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCountryL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCountryUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCountryRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCountryUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCountryLfRtLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='19'"
        GlCommand.ExecuteNonQuery()


        ''' المورد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtSupplierL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtSupplierUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtSupplierRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtSupplierUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtSupplierRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='20'"
        GlCommand.ExecuteNonQuery()


        ''' رقم فاتورة الشراء
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtPurInvNumberL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtPurInvNumberUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtPurInvNumberRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtPurInvNumberUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtPurInvNumberRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='21'"
        GlCommand.ExecuteNonQuery()


        '''الرمز
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCodeL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCodeUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCodeRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCodeUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCodeRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='22'"
        GlCommand.ExecuteNonQuery()


        '''التكلفه للقطعه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerItemL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerItemUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerItemRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerItemUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerItemRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='23'"
        GlCommand.ExecuteNonQuery()


        '''العدد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtQtyL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtQtyUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtQtyRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtQtyUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtQtyRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='24'"
        GlCommand.ExecuteNonQuery()

        '''وزن الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStoneWeightL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStoneWeightUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStoneWeightRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStoneWeightUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStoneWeightRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='25'"
        GlCommand.ExecuteNonQuery()


        '''سعر الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStonePriceL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStonePriceUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStonePriceRtLfl.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStonePriceUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStonePriceRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='26'"
        GlCommand.ExecuteNonQuery()



        '''الباركود
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtBarcodTxtL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtBarcodUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtBarcodLfRtL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtBarcodUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtBarcodLfRtLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='29'"
        GlCommand.ExecuteNonQuery()


        'اسم المعرض واللوق الجه اليمني

        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [txtShroomUpDo] = '" & txtShroomUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtShroomRtLf] = '" & txtShroomRtLfL.Text.Trim & "'" & vbCrLf &
                                ",[txtLogoUpDo] ='" & txtLogoUpDoL.Text & "'" & vbCrLf &
                                ",[txtLogoRtLf] = '" & txtLogoRtLfL.Text & "'" & vbCrLf &
                                "WHERE  RightLeft = N'L'"
        GlCommand.ExecuteNonQuery()


        'اللوقو الجه اليسري
        GlCommand.CommandText = "UPDATE [BarcodeSet] SET [txtImge] = @txtImge  WHERE  RightLeft = N'L'"
        With GlCommand.Parameters
            .Clear()
            .Add("@txtImge", SqlDbType.Image).Value = If(PicLogo.Image Is Nothing, DBNull.Value, ImageToByte(PicLogo.Image))
        End With
        GlCommand.ExecuteNonQuery()
    End Sub
    Private Sub SilverFiledSave()
        GlCommand.CommandText = " UPDATE [BarcodeSet] SET [BarcodFontName] = '" & cmbBarCodeFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[FontName]= '" & cmbDataTextFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[TextFontSize]='" & txtDataTextFont.Text.Trim & "'" & vbCrLf &
                                ",[TextFontShape] ='" & cmbTextBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[txtCompFont] = '" & txtCompFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbCompFontTyp] = '" & cmbCompFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[cmbCompFontShape] = '" & cmbCompFontBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[txtCountryFont] = '" & txtCountryFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbCountryFontTyp] ='" & cmbCountryFontTyp.Text.Trim & "'" & vbCrLf &
                                ",[txtBarCodeFont] ='" & txtBarCodeFont.Text.Trim & "'" & vbCrLf &
                                ",[cmbBarCodeFontTyp] ='Regular'" & vbCrLf &
                                ",[CountryFontShape] ='" & cmbCountryFontBoldRegular.Text.Trim & "'" & vbCrLf &
                                ",[cmbPrinter] = '" & cmbPrinter.Text.Trim & "'" & vbCrLf &
                                ",[txtImgeSize] = '" & txtImgeSize.Text.Trim & "'" & vbCrLf &
                                ",[txtShoromName] =N'" & cmbCompany.Text.Trim & "'"

        GlCommand.ExecuteNonQuery()



        'اعدادات الجه اليمني
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '''العيار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtKaratR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtKaratUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtKaratRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtKaratUpDoRVu.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtKaratRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='58'"
        GlCommand.ExecuteNonQuery()

        ''''اسم الصنف
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtItemNameR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtItemNameUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtItemNameRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtItemNameUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtItemNameRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='59'"
        GlCommand.ExecuteNonQuery()

        '''''وزن المعدن
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMetalWeightR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMetalWeightUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMetalWeightRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMetalWeightUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMetalWeightRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='60'"
        GlCommand.ExecuteNonQuery()

        '''''المصنعيه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMakeChargeR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMakeChargeUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMakeChargeRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMakeChargeUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMakeChargeRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='61'"
        GlCommand.ExecuteNonQuery()


        '''''التكلفه بالجرام
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerGramR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerGramUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerGramRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerGramUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerGramRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='62'"
        GlCommand.ExecuteNonQuery()


        ''' بلد النشأ
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCountryR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCountryUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCountryRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCountryUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCountryLfRtRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='63'"
        GlCommand.ExecuteNonQuery()


        ''' المورد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtSupplierR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtSupplierUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtSupplierRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtSupplierUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtSupplierRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='64'"
        GlCommand.ExecuteNonQuery()


        ''' رقم فاتورة الشراء
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtPurInvNumberR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtPurInvNumberUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtPurInvNumberRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtPurInvNumberUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtPurInvNumberRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='65'"
        GlCommand.ExecuteNonQuery()


        '''الرمز
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCodeR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCodeUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCodeRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCodeUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCodeRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='66'"
        GlCommand.ExecuteNonQuery()


        '''التكلفه للقطعه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerItemR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerItemUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerItemRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerItemUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerItemRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='67'"
        GlCommand.ExecuteNonQuery()


        '''العدد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtQtyR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtQtyUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtQtyRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtQtyUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtQtyRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='68'"
        GlCommand.ExecuteNonQuery()

        '''وزن الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStoneWeightR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStoneWeightUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStoneWeightRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStoneWeightUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStoneWeightRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='69'"
        GlCommand.ExecuteNonQuery()


        '''سعر الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStonePriceR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStonePriceUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStonePriceRtLfR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStonePriceUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStonePriceRtLfRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='70'"
        GlCommand.ExecuteNonQuery()



        '''الباركود
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtBarcodTxtR.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtBarcodUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtBarcodLfRtR.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtBarcodUpDoRV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtBarcodLfRtRV.Text & "'" & vbCrLf &
                                "WHERE [ID]='84'"
        GlCommand.ExecuteNonQuery()
        'اسم المعرض واللوقو الجه اليمني

        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [txtShroomUpDo] = N'" & txtShroomUpDoR.Text.Trim & "'" & vbCrLf &
                                ",[txtShroomRtLf] = '" & txtShroomRtLfR.Text.Trim & "'" & vbCrLf &
                                ",[txtLogoUpDo] ='" & txtLogoUpDoR.Text & "'" & vbCrLf &
                                ",[txtLogoRtLf] = '" & txtLogoRtLfR.Text & "'" & vbCrLf &
                                "WHERE  RightLeft = N'R'"
        GlCommand.ExecuteNonQuery()

        'اللوقو الجه اليمني
        GlCommand.CommandText = "UPDATE [BarcodeSet] SET [txtImge] = @txtImge  WHERE  RightLeft = N'R'"
        With GlCommand.Parameters
            .Clear()
            .Add("@txtImge", SqlDbType.Image).Value = If(PicLogo.Image Is Nothing, DBNull.Value, ImageToByte(PicLogo.Image))
        End With
        GlCommand.ExecuteNonQuery()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''العيار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtKaratL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtKaratUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtKaratRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtKaratUpDoLVu.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtKaratRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='71'"
        GlCommand.ExecuteNonQuery()
        ''''اسم الصنف
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtItemNameL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtItemNameUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtItemNameRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtItemNameUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtItemNameRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='72'"
        GlCommand.ExecuteNonQuery()

        '''''وزن المعدن
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMetalWeightL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMetalWeightUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMetalWeightRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMetalWeightUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMetalWeightRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='73'"
        GlCommand.ExecuteNonQuery()

        '''''المصنعيه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtMakeChargeL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtMakeChargeUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtMakeChargeRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtMakeChargeUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtMakeChargeRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='74'"
        GlCommand.ExecuteNonQuery()


        '''''التكلفه بالجرام
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerGramL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerGramUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerGramRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerGramUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerGramRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='75'"
        GlCommand.ExecuteNonQuery()


        ''' بلد النشأ
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCountryL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCountryUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCountryRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCountryUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCountryLfRtLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='76'"
        GlCommand.ExecuteNonQuery()


        ''' المورد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtSupplierL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtSupplierUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtSupplierRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtSupplierUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtSupplierRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='77'"
        GlCommand.ExecuteNonQuery()


        ''' رقم فاتورة الشراء
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtPurInvNumberL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtPurInvNumberUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtPurInvNumberRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtPurInvNumberUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtPurInvNumberRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='78'"
        GlCommand.ExecuteNonQuery()


        '''الرمز
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCodeL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCodeUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCodeRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCodeUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCodeRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='79'"
        GlCommand.ExecuteNonQuery()


        '''التكلفه للقطعه
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtCostPerItemL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtCostPerItemUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtCostPerItemRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtCostPerItemUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtCostPerItemRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='80'"
        GlCommand.ExecuteNonQuery()


        '''العدد
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtQtyL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtQtyUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtQtyRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtQtyUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtQtyRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='81'"
        GlCommand.ExecuteNonQuery()

        '''وزن الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStoneWeightL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStoneWeightUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStoneWeightRtLfL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStoneWeightUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStoneWeightRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='82'"
        GlCommand.ExecuteNonQuery()


        '''سعر الاحجار
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtStonePriceL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtStonePriceUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtStonePriceRtLfl.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtStonePriceUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtStonePriceRtLfLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='83'"
        GlCommand.ExecuteNonQuery()



        '''الباركود
        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [FiledName] = N'" & txtBarcodTxtL.Text.Trim & "'" & vbCrLf &
                                ",[txtUpDoR] = '" & txtBarcodUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtRtLfR] ='" & txtBarcodLfRtL.Text & "'" & vbCrLf &
                                ",[txtValuUpDoR] = '" & txtBarcodUpDoLV.Text & "'" & vbCrLf &
                                ",[txtValuRtLfR] = '" & txtBarcodLfRtLV.Text & "'" & vbCrLf &
                                "WHERE [ID]='85'"
        GlCommand.ExecuteNonQuery()
        'اسم المعرض واللوق الجه اليمني

        GlCommand.CommandText = "UPDATE [BarcodeSet]SET  [txtShroomUpDo] = '" & txtShroomUpDoL.Text.Trim & "'" & vbCrLf &
                                ",[txtShroomRtLf] = '" & txtShroomRtLfL.Text.Trim & "'" & vbCrLf &
                                ",[txtLogoUpDo] ='" & txtLogoUpDoL.Text & "'" & vbCrLf &
                                ",[txtLogoRtLf] = '" & txtLogoRtLfL.Text & "'" & vbCrLf &
                                "WHERE  RightLeft = N'L'"
        GlCommand.ExecuteNonQuery()

        'اللوقو الجه اليسري
        GlCommand.CommandText = "UPDATE [BarcodeSet] SET [txtImge] = @txtImge  WHERE  RightLeft = N'L'"
        With GlCommand.Parameters
            .Clear()
            .Add("@txtImge", SqlDbType.Image).Value = If(PicLogo.Image Is Nothing, DBNull.Value, ImageToByte(PicLogo.Image))
        End With
        GlCommand.ExecuteNonQuery()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbPrinter.Text = "" Then
            MsgBox("لايمكن حفظ الإعدادات دون تحديد طابعة" & vbCrLf & "Can't Save Setting Without Selecting a Printer", , AppTitle)
            Exit Sub
        Else
            Try
                If GoldOrSilver = True Then
                    GoldFiledSave()
                ElseIf GoldOrSilver = False Then
                    SilverFiledSave()
                End If
                Preview()
                MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Setting Saved Successfully", , AppTitle)
            Catch ex As Exception
                MsgBox(ex.ToString)
                RecordRrrors(DescriptionRrrors:=ex.ToString)
            End Try
        End If

    End Sub

    Private Sub GetImg()
        PicLogo.Image = Nothing
        Dim GetImge As DataTable = GetRecordSet("SELECT [txtImge] FROM [BarcodeSet] ")
        If GetImge.Rows.Count > 0 Then
            If Not IsDBNull((GetImge.Rows(0)("txtImge"))) Then
                PicLogo.Image = ByteToImage(GetImge.Rows(0)("txtImge"))
            ElseIf IsDBNull((GetImge.Rows(0)("txtImge"))) Then
            End If
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        GetItemPrintDataR()
        'GetItemPrintDataL()

    End Sub

    Private Sub gbLeftText_Enter(sender As Object, e As EventArgs) Handles gbLeftText.Enter
        Preview()
    End Sub



    Private Sub txtKaratUpDoLVu_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoLV.KeyUp, txtSupplierRtLfLV.KeyUp, txtStoneWeightUpDoLV.KeyUp, txtStoneWeightRtLfLV.KeyUp, txtStonePriceUpDoLV.KeyUp, txtStonePriceRtLfLV.KeyUp, txtQtyUpDoLV.KeyUp, txtQtyRtLfLV.KeyUp, txtPurInvNumberUpDoLV.KeyUp, txtPurInvNumberRtLfLV.KeyUp, txtMetalWeightUpDoLV.KeyUp, txtMetalWeightRtLfLV.KeyUp, txtMakeChargeUpDoLV.KeyUp, txtMakeChargeRtLfLV.KeyUp, txtKaratUpDoLVu.KeyUp, txtKaratRtLfLV.KeyUp, txtItemNameUpDoLV.KeyUp, txtItemNameRtLfLV.KeyUp, txtCountryUpDoLV.KeyUp, txtCountryLfRtLV.KeyUp, txtCostPerItemUpDoLV.KeyUp, txtCostPerItemRtLfLV.KeyUp, txtCostPerGramUpDoLV.KeyUp, txtCostPerGramRtLfLV.KeyUp, txtCodeUpDoLV.KeyUp, txtCodeRtLfLV.KeyUp, txtBarcodUpDoLV.KeyUp, txtBarcodLfRtLV.KeyUp, TextBox90.KeyUp, TextBox88.KeyUp, TextBox86.KeyUp, TextBox192.KeyUp, TextBox190.KeyUp, TextBox188.KeyUp
        Preview()
    End Sub

    Private Sub txtKaratUpDoLVu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoLV.KeyDown, txtSupplierRtLfLV.KeyDown, txtStoneWeightUpDoLV.KeyDown, txtStoneWeightRtLfLV.KeyDown, txtStonePriceUpDoLV.KeyDown, txtStonePriceRtLfLV.KeyDown, txtQtyUpDoLV.KeyDown, txtQtyRtLfLV.KeyDown, txtPurInvNumberUpDoLV.KeyDown, txtPurInvNumberRtLfLV.KeyDown, txtMetalWeightUpDoLV.KeyDown, txtMetalWeightRtLfLV.KeyDown, txtMakeChargeUpDoLV.KeyDown, txtMakeChargeRtLfLV.KeyDown, txtKaratUpDoLVu.KeyDown, txtKaratRtLfLV.KeyDown, txtItemNameUpDoLV.KeyDown, txtItemNameRtLfLV.KeyDown, txtCountryUpDoLV.KeyDown, txtCountryLfRtLV.KeyDown, txtCostPerItemUpDoLV.KeyDown, txtCostPerItemRtLfLV.KeyDown, txtCostPerGramUpDoLV.KeyDown, txtCostPerGramRtLfLV.KeyDown, txtCodeUpDoLV.KeyDown, txtCodeRtLfLV.KeyDown, txtBarcodUpDoLV.KeyDown, txtBarcodLfRtLV.KeyDown, TextBox90.KeyDown, TextBox88.KeyDown, TextBox86.KeyDown, TextBox192.KeyDown, TextBox190.KeyDown, TextBox188.KeyDown
        Preview()
    End Sub

    Private Sub txtKaratUpDoL_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoL.KeyUp, txtSupplierRtLfL.KeyUp, txtStoneWeightUpDoL.KeyUp, txtStoneWeightRtLfL.KeyUp, txtStonePriceUpDoL.KeyUp, txtStonePriceRtLfl.KeyUp, txtQtyUpDoL.KeyUp, txtQtyRtLfL.KeyUp, txtPurInvNumberUpDoL.KeyUp, txtPurInvNumberRtLfL.KeyUp, txtMetalWeightUpDoL.KeyUp, txtMetalWeightRtLfL.KeyUp, txtMakeChargeUpDoL.KeyUp, txtMakeChargeRtLfL.KeyUp, txtKaratUpDoL.KeyUp, txtKaratRtLfL.KeyUp, txtItemNameUpDoL.KeyUp, txtItemNameRtLfL.KeyUp, txtCountryUpDoL.KeyUp, txtCountryRtLfL.KeyUp, txtCostPerItemUpDoL.KeyUp, txtCostPerItemRtLfL.KeyUp, txtCostPerGramUpDoL.KeyUp, txtCostPerGramRtLfL.KeyUp, txtCodeUpDoL.KeyUp, txtCodeRtLfL.KeyUp, txtBarcodUpDoL.KeyUp, txtBarcodLfRtL.KeyUp, TextBox175.KeyUp, TextBox173.KeyUp, TextBox171.KeyUp, TextBox124.KeyUp, TextBox122.KeyUp, TextBox120.KeyUp
        Preview()
    End Sub

    Private Sub txtKaratUpDoL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoL.KeyDown, txtSupplierRtLfL.KeyDown, txtStoneWeightUpDoL.KeyDown, txtStoneWeightRtLfL.KeyDown, txtStonePriceUpDoL.KeyDown, txtStonePriceRtLfl.KeyDown, txtQtyUpDoL.KeyDown, txtQtyRtLfL.KeyDown, txtPurInvNumberUpDoL.KeyDown, txtPurInvNumberRtLfL.KeyDown, txtMetalWeightUpDoL.KeyDown, txtMetalWeightRtLfL.KeyDown, txtMakeChargeUpDoL.KeyDown, txtMakeChargeRtLfL.KeyDown, txtKaratUpDoL.KeyDown, txtKaratRtLfL.KeyDown, txtItemNameUpDoL.KeyDown, txtItemNameRtLfL.KeyDown, txtCountryUpDoL.KeyDown, txtCountryRtLfL.KeyDown, txtCostPerItemUpDoL.KeyDown, txtCostPerItemRtLfL.KeyDown, txtCostPerGramUpDoL.KeyDown, txtCostPerGramRtLfL.KeyDown, txtCodeUpDoL.KeyDown, txtCodeRtLfL.KeyDown, txtBarcodUpDoL.KeyDown, txtBarcodLfRtL.KeyDown, TextBox175.KeyDown, TextBox173.KeyDown, TextBox171.KeyDown, TextBox124.KeyDown, TextBox122.KeyDown, TextBox120.KeyDown
        Preview()
    End Sub

    Private Sub txtKaratUpDoRVu_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoRV.KeyUp, txtSupplierRtLfRV.KeyUp, txtStoneWeightUpDoRV.KeyUp, txtStoneWeightRtLfRV.KeyUp, txtStonePriceUpDoRV.KeyUp, txtStonePriceRtLfRV.KeyUp, txtQtyUpDoRV.KeyUp, txtQtyRtLfRV.KeyUp, txtPurInvNumberUpDoRV.KeyUp, txtPurInvNumberRtLfRV.KeyUp, txtMetalWeightUpDoRV.KeyUp, txtMetalWeightRtLfRV.KeyUp, txtMakeChargeUpDoRV.KeyUp, txtMakeChargeRtLfRV.KeyUp, txtKaratUpDoRVu.KeyUp, txtKaratRtLfRV.KeyUp, txtItemNameUpDoRV.KeyUp, txtItemNameRtLfRV.KeyUp, txtCountryUpDoRV.KeyUp, txtCountryLfRtRV.KeyUp, txtCostPerItemUpDoRV.KeyUp, txtCostPerItemRtLfRV.KeyUp, txtCostPerGramUpDoRV.KeyUp, txtCostPerGramRtLfRV.KeyUp, txtCodeUpDoRV.KeyUp, txtCodeRtLfRV.KeyUp, txtBarcodUpDoRV.KeyUp, txtBarcodLfRtRV.KeyUp, TextBox56.KeyUp, TextBox54.KeyUp, TextBox52.KeyUp, TextBox146.KeyUp, TextBox144.KeyUp, TextBox142.KeyUp
        Preview()
    End Sub

    Private Sub txtKaratUpDoRVu_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoRV.KeyDown, txtSupplierRtLfRV.KeyDown, txtStoneWeightUpDoRV.KeyDown, txtStoneWeightRtLfRV.KeyDown, txtStonePriceUpDoRV.KeyDown, txtStonePriceRtLfRV.KeyDown, txtQtyUpDoRV.KeyDown, txtQtyRtLfRV.KeyDown, txtPurInvNumberUpDoRV.KeyDown, txtPurInvNumberRtLfRV.KeyDown, txtMetalWeightUpDoRV.KeyDown, txtMetalWeightRtLfRV.KeyDown, txtMakeChargeUpDoRV.KeyDown, txtMakeChargeRtLfRV.KeyDown, txtKaratUpDoRVu.KeyDown, txtKaratRtLfRV.KeyDown, txtItemNameUpDoRV.KeyDown, txtItemNameRtLfRV.KeyDown, txtCountryUpDoRV.KeyDown, txtCountryLfRtRV.KeyDown, txtCostPerItemUpDoRV.KeyDown, txtCostPerItemRtLfRV.KeyDown, txtCostPerGramUpDoRV.KeyDown, txtCostPerGramRtLfRV.KeyDown, txtCodeUpDoRV.KeyDown, txtCodeRtLfRV.KeyDown, txtBarcodUpDoRV.KeyDown, txtBarcodLfRtRV.KeyDown, TextBox56.KeyDown, TextBox54.KeyDown, TextBox52.KeyDown, TextBox146.KeyDown, TextBox144.KeyDown, TextBox142.KeyDown
        Preview()
    End Sub

    Private Sub txtKaratUpDoR_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoR.KeyDown, txtSupplierRtLfR.KeyDown, txtStoneWeightUpDoR.KeyDown, txtStoneWeightRtLfR.KeyDown, txtStonePriceUpDoR.KeyDown, txtStonePriceRtLfR.KeyDown, txtQtyUpDoR.KeyDown, txtQtyRtLfR.KeyDown, txtPurInvNumberUpDoR.KeyDown, txtPurInvNumberRtLfR.KeyDown, txtMetalWeightUpDoR.KeyDown, txtMetalWeightRtLfR.KeyDown, txtMakeChargeUpDoR.KeyDown, txtMakeChargeRtLfR.KeyDown, txtKaratUpDoR.KeyDown, txtKaratRtLfR.KeyDown, txtItemNameUpDoR.KeyDown, txtItemNameRtLfR.KeyDown, txtCountryUpDoR.KeyDown, txtCountryRtLfR.KeyDown, txtCostPerItemUpDoR.KeyDown, txtCostPerItemRtLfR.KeyDown, txtCostPerGramUpDoR.KeyDown, txtCostPerGramRtLfR.KeyDown, txtCodeUpDoR.KeyDown, txtCodeRtLfR.KeyDown, txtBarcodUpDoR.KeyDown, txtBarcodLfRtR.KeyDown, TextBox20.KeyDown, TextBox19.KeyDown, TextBox18.KeyDown, TextBox139.KeyDown, TextBox138.KeyDown, TextBox137.KeyDown
        Preview()
    End Sub

    Private Sub txtKaratUpDoR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSupplierUpDoR.KeyUp, txtSupplierRtLfR.KeyUp, txtStoneWeightUpDoR.KeyUp, txtStoneWeightRtLfR.KeyUp, txtStonePriceUpDoR.KeyUp, txtStonePriceRtLfR.KeyUp, txtQtyUpDoR.KeyUp, txtQtyRtLfR.KeyUp, txtPurInvNumberUpDoR.KeyUp, txtPurInvNumberRtLfR.KeyUp, txtMetalWeightUpDoR.KeyUp, txtMetalWeightRtLfR.KeyUp, txtMakeChargeUpDoR.KeyUp, txtMakeChargeRtLfR.KeyUp, txtKaratUpDoR.KeyUp, txtKaratRtLfR.KeyUp, txtItemNameUpDoR.KeyUp, txtItemNameRtLfR.KeyUp, txtCountryUpDoR.KeyUp, txtCountryRtLfR.KeyUp, txtCostPerItemUpDoR.KeyUp, txtCostPerItemRtLfR.KeyUp, txtCostPerGramUpDoR.KeyUp, txtCostPerGramRtLfR.KeyUp, txtCodeUpDoR.KeyUp, txtCodeRtLfR.KeyUp, txtBarcodUpDoR.KeyUp, txtBarcodLfRtR.KeyUp, TextBox20.KeyUp, TextBox19.KeyUp, TextBox18.KeyUp, TextBox139.KeyUp, TextBox138.KeyUp, TextBox137.KeyUp
        Preview()
    End Sub

    Private Sub SilverBarcode_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Me.Dispose()
    End Sub

    Private Sub SilverBarcode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Me.Dispose()
    End Sub

    Private Sub btnImge_Click(sender As Object, e As EventArgs) Handles btnImge.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                PicLogo.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        PicLogo.BackgroundImageLayout = ImageLayout.Stretch
        Preview()
    End Sub

    Private Sub txtLogoUpDoR_TextChanged(sender As Object, e As EventArgs) Handles txtLogoUpDoR.TextChanged
        Preview()
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [BarcodeSet]")
            LocSqlGlCom.ExecuteReader()
            ResetIDSeed(TableName:="BarcodeSet", FieldName:="[ID]")
        Catch ex As Exception
            ex.ToString()
        End Try
        BarcodDefault()
        SilverGettData(Category:=TPCategory)
        FontSet()
        GetItemData(TpName:=SQLTP)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        txtPupName()
        GetImg()
        Preview()
    End Sub

    Private Sub chkPrintRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrintRange.CheckedChanged
        cmbPrintRange.Enabled = chkPrintRange.Checked
        If chkPrintRange.Checked = True Then
            cmbLeftItem.Enabled = False
            txtBarCodeLeft.Enabled = False
            txtBarCodeLeft.Text = txtBarCodeRight.Text + 1
        ElseIf chkPrintRange.Checked = False Then
            cmbLeftItem.Enabled = True
            txtBarCodeLeft.Enabled = True
        End If
    End Sub

    Private Sub cmbPrintRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrintRange.SelectedIndexChanged

    End Sub

End Class