Module UpdateSqlCommend
    Public SuccessMessages As String = ""
    Public FailMessages As String = ""
    Dim Cart21 As Decimal = (Cart21 * "24" / "1000")
    Dim Cart18 As Decimal = (Cart18 * "24" / "1000")
    Dim Cart22 As Decimal = (Cart22 * "24" / "1000")
    Dim Cart24 As Decimal = (Cart24 * "24" / "1000")
    Public Sub BarcodDefault()
        'Dim Barcod As DataTable = GetRecordSet("select [ID] from [BarcodeSet]")
        'If Barcod.Rows.Count - 1 Then
        GlCommand.CommandText = "SET IDENTITY_INSERT [dbo].[BarcodeSet] ON " & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (1,1, N'عيار المعدن', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'40', N'260', N'40', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (2,1, N'اسم الصنف', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'23', N'180', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (3,1, N'وزن المعدن', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'55', N'290', N'55', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (4,1, N'المصنعيه', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'65', N'298', N'65', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (5,1, N'تكلفة الجرام', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (6,1, N'بلد المنشا', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'10', N'290', N'10', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (7,1, N'المورد', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'35', N'300', N'45', N'290', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (8,1, N'رقم فاتورت الشراء', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (9,1, N'الرمز', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (10,1, N'التكلفه للقطعه', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (11,1, N'العدد', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'75', N'308', N'75', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (12,1, N'وزن الفص', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'85', N'290', N'85', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (13,1, N'سعر الفص', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'95', N'290', N'95', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (14,1, N'عيار المعدن', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'80', N'20', N'80', N'7', N'1', N'2', N'3', N'4', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (15,1, N'اسم الصنف', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'118', N'100', N'0', N'0', N'105', N'50', N'105', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (16,1, N'وزن المعدن', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'100', N'46', N'100', N'10', N'110', N'50', N'110', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (17,1, N'المصنعيه', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'110', N'55', N'110', N'10', N'115', N'50', N'115', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (18,1, N'تكلفة الجرام', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'120', N'50', N'120', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (19,1, N'بلد المنشا', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'50', N'50', N'50', N'10', N'125', N'50', N'125', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (20,1, N'المورد', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'80', N'60', N'90', N'25', N'130', N'50', N'130', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (21,1, N'رقم فاتورت الشراء', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'135', N'50', N'135', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (22,1, N'الرمز', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'140', N'50', N'140', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (23,1, N'التكلفه للقطعه', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'145', N'50', N'145', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (24,1, N'العدد', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'120', N'65', N'120', N'10', N'150', N'50', N'150', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (25,1, N'وزن الاحجار', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'130', N'45', N'130', N'10', N'155', N'50', N'155', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (26,1, N'سعر الاحجار', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'140', N'45', N'140', N'10', N'160', N'50', N'160', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (28,1, N'باركود', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'21', N'250', N'32', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (29,1, N'باركود', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'60', N'7', N'70', N'7', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (58,2, N'عيار المعدن', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'40', N'260', N'40', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (59,2, N'اسم الصنف', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'23', N'180', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (60,2, N'وزن المعدن', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'55', N'290', N'55', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (61,2, N'المصنعيه', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'65', N'298', N'65', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (62,2, N'تكلفة الجرام', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (63,2, N'بلد المنشا', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'10', N'290', N'10', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (64,2, N'المورد', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'35', N'300', N'45', N'290', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (65,2, N'رقم فاتورت الشراء', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (66,2, N'الرمز', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (67,2, N'التكلفه للقطعه', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (68,2, N'العدد', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'75', N'308', N'75', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (69,2, N'وزن الفص', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'85', N'290', N'85', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (70,2, N'سعر الفص', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'95', N'290', N'95', N'250', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (71,2, N'عيار المعدن', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'80', N'20', N'80', N'7', N'1', N'2', N'3', N'4', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (72,2, N'اسم الصنف', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'118', N'100', N'0', N'0', N'105', N'50', N'105', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (73,2, N'وزن المعدن', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'100', N'46', N'100', N'10', N'110', N'50', N'110', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (74,2, N'المصنعيه', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'110', N'55', N'110', N'10', N'115', N'50', N'115', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (75,2, N'تكلفة الجرام', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'120', N'50', N'120', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (76,2, N'بلد المنشا', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'50', N'50', N'50', N'10', N'125', N'50', N'125', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (77,2, N'المورد', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'80', N'60', N'90', N'25', N'130', N'50', N'130', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (78,2, N'رقم فاتورت الشراء', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'135', N'50', N'135', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (79,2, N'الرمز', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'140', N'50', N'140', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (80,2, N'التكلفه للقطعه', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'0', N'0', N'0', N'0', N'145', N'50', N'145', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (81,2, N'العدد', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'120', N'65', N'120', N'10', N'150', N'50', N'150', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (82,2, N'وزن الاحجار', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'130', N'45', N'130', N'10', N'155', N'50', N'155', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (83,2, N'سعر الاحجار', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'140', N'45', N'140', N'10', N'160', N'50', N'160', N'8', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (84,2, N'باركود', N'R', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'21', N'250', N'32', N'248', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'118', N'190', N'50', N'130', NULL, N'50')" & vbCrLf &
                                    "INSERT [dbo].[BarcodeSet] ([ID], [CategoryType], [FiledName], [RightLeft], [BarcodFontName], [FontName], [TextFontSize], [TextFontShape], [txtCompFont], [cmbCompFontTyp], [cmbCompFontShape], [txtCountryFont], [cmbCountryFontTyp], [txtBarCodeFont], [cmbBarCodeFontTyp], [CountryFontShape], [cmbPrinter], [txtUpDoR], [txtRtLfR], [txtValuUpDoR], [txtValuRtLfR], [txtUpDoL], [txtRtLfL], [txtValuUpDoL], [txtValuRtLfL], [txtCode], [txtCostPerItem], [txtQty], [txtStoneWeight], [txtShoromName], [txtShroomUpDo], [txtShroomRtLf], [txtLogoUpDo], [txtLogoRtLf], [txtImge], [txtImgeSize]) VALUES (85,2, N'باركود يسار', N'L', N'3 of 9 Barcode', N'Calibri', N'6', N'B', N'6', N'Calibri', N'B', N'6', N'Arial', N'10', N'Regular', N'B', N'ZDesigner ZT230-200dpi ZPL', N'60', N'7', N'70', N'7', N'0', N'0', N'0', N'0', NULL, NULL, NULL, NULL, N'صندوق الجواهر', N'23', N'70', N'-50', N'-50', NULL, N'50')" & vbCrLf &
                                    "SET IDENTITY_INSERT [dbo].[BarcodeSet] OFF"
        GlCommand.ExecuteNonQuery()
        'End If
    End Sub

    Public Sub UpdateDatabase()
        'تحديث جدول العملاء اضافة المستفيد العلي 
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerCAIVELidKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerCAIVELidKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.Parameters.Clear()
        GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerNAmeKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerNAmeKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.Parameters.Clear()
        GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerADrKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerADrKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.Parameters.Clear()
        GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerTEKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerTEKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.Parameters.Clear()
        GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerNAKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerNAKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.Parameters.Clear()
        GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerNameEnKYC') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerNameEnKYC] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
            Try
                GlCommand.Parameters.Clear()
                GlCommand.CommandText = "IF OBJECT_ID('[viwCompanyNameAndBranches]') IS NOT NULL " &
                                    "DROP VIEW [viwCompanyNameAndBranches] "
                GlCommand.ExecuteNonQuery()
            Catch ex As Exception
                FailMessages &= ex.Message
            End Try

            Try
                GlCommand.Parameters.Clear()
                GlCommand.CommandText = "UPDATE [dbo].[CastomerDETELS] SET [CastomerCAIVELidKYC] = CastomerCAIVELid" & vbCrLf &
                                        ",[CastomerNAmeKYC] = CastomerNAme" & vbCrLf &
                                        ",[CastomerADrKYC] = CastomerADr" & vbCrLf &
                                        ",[CastomerTEKYC] = CastomerTE" & vbCrLf &
                                        ",[CastomerNAKYC] = CastomerNA" & vbCrLf &
                                        ",[CastomerNameEnKYC] = CastomerNameEn" & vbCrLf &
                                        " WHERE CastomerCAIVELidKYC IS NULL"
                GlCommand.ExecuteNonQuery()
            Catch ex As Exception
                FailMessages &= ex.Message
        End Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText = "CREATE VIEW [dbo].[viwCompanyNameAndBranches] AS SELECT dbo.TPCompanyInfo.CompanyName," & vbCrLf &
                         "dbo.TPCompanyBranches.BranchName, dbo.TPCompanyInfo.CompanyAddress," & vbCrLf &
                         "dbo.TPCompanyInfo.LicenseNumber, dbo.TPCompanyInfo.CommercialRegisterNo, " & vbCrLf &
                         "dbo.TPCompanyInfo.LicenseImage, dbo.TPCompanyInfo.CreationDate," & vbCrLf &
                         "dbo.TPCompanyInfo.LastEditDate, dbo.TPCompanyInfo.Activite," & vbCrLf &
                         "dbo.TPCompanyBranches.CompanyID, dbo.TPCompanyBranches.SalesCivilID, " & vbCrLf &
                         "dbo.TPCompanyBranches.BranchAddress, dbo.TPCompanyBranches.TelNumber," & vbCrLf &
                         "dbo.TPCompanyBranches.BranchID, dbo.TPCompanyBranches.LicenseNumber AS BranchesLicenseNumber, " & vbCrLf &
                         "dbo.TPCompanyBranches.CommercialRegisterNo AS BranchesCommercialRegisterNo," & vbCrLf &
                         "dbo.TPCompanyBranches.LicenseImage AS BranchesLicenseImage, dbo.TPCompanyBranches.CreationDate AS BranchesCreationDate, " & vbCrLf &
                         "dbo.TPCompanyBranches.LastEditDate AS BranchesLastEditDate, dbo.TPCompanyBranches.Activite AS BranchesActivite" & vbCrLf &
                         "FROM dbo.TPCompanyBranches INNER JOIN" & vbCrLf &
                         "dbo.TPCompanyInfo ON dbo.TPCompanyBranches.CompanyID = dbo.TPCompanyInfo.CompanyID" & vbCrLf &
                         "WHERE (dbo.TPCompanyBranches.Activite = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try

            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldVoucherReceive]') IS NOT NULL " &
                                "DROP VIEW [ViwGoldVoucherReceive] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldVoucherReceive] AS SELECT dbo.TPGoldVoucherReceive.GoldVoucherReceiveID," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.CivilID, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEn, dbo.[user].user_name, dbo.cacher.cacher_name, " & vbCrLf &
                         "dbo.cacher.CashierSignature, dbo.TPGoldVoucherReceive.VoucherNumber, dbo.TPGoldVoucherReceive.GoldKarat," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.PurKarat, dbo.TPGoldVoucherReceive.GoldWeight, " & vbCrLf &
                         "dbo.TPGoldVoucherReceive.PurWeight, dbo.TPGoldVoucherReceive.Qunt, dbo.TPGoldVoucherReceive.CreationDate," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.LastEditDate, dbo.TPGoldVoucherReceive.Time, " & vbCrLf &
                         "dbo.TPGoldVoucherReceive.Note, dbo.TPGoldVoucherReceive.Activite, dbo.TPGoldVoucherReceive.MakeCharge," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.TotalMakeCharge, dbo.TPGoldVoucherReceive.WeightArletters, " & vbCrLf &
                         "dbo.TPGoldVoucherReceive.WeightEnletters, dbo.TPGoldVoucherReceive.GramPrice, dbo.TPGoldVoucherReceive.GoldPrice," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.TotalPrice, dbo.TPGoldVoucherReceive.TotalPriceArletters, " & vbCrLf &
                         "dbo.TPGoldVoucherReceive.TotalPriceEnletters, dbo.TBBondGoldType.BondTypeArName, dbo.TBBondGoldType.BondTypeEnName," & vbCrLf &
                         "dbo.TPGoldVoucherReceive.PurWeightArletters, " & vbCrLf &
                         "dbo.TPGoldVoucherReceive.PurWeightEnletters, dbo.comp_inform.logo1, dbo.comp_inform.logo2," & vbCrLf &
                         "dbo.comp_inform.comp_name AS ComPnameAsInvoce, dbo.comp_inform.comp_note1, " & vbCrLf &
                         "dbo.viwCompanyNameAndBranches.CompanyName, dbo.viwCompanyNameAndBranches.BranchName" & vbCrLf &
                         "FROM dbo.TPGoldVoucherReceive INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.TPGoldVoucherReceive.CivilID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.[user] ON dbo.TPGoldVoucherReceive.UserID = dbo.[user].user_id INNER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.TPGoldVoucherReceive.Casher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                         "dbo.TBBondGoldType ON dbo.TPGoldVoucherReceive.VoucherType = dbo.TBBondGoldType.BondGoldTypeID INNER JOIN" & vbCrLf &
                         "dbo.viwCompanyNameAndBranches ON dbo.TPGoldVoucherReceive.Supplier = dbo.viwCompanyNameAndBranches.BranchID CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
                "IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name='TPBank_Info' AND schema_id=SCHEMA_ID('dbo')) " &
                "BEGIN " &
                "CREATE TABLE dbo.TPBank_Info " &
                "( " &
                "BankID [int] IDENTITY(1,1) NOT NULL," &
                "BankCode NVARCHAR(50) NULL, " &
                "BankName_AR NVARCHAR(200) NULL, " &
                "BankName_EN NVARCHAR(200) NULL, " &
                "BankAddress NVARCHAR(300) NULL, " &
                "SwiftCode NVARCHAR(50) NULL, " &
                "CONSTRAINT PK_TPBank_Info PRIMARY KEY (BankID) " &
                "); " &
                "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name='TPCompanyInfo' AND schema_id=SCHEMA_ID('dbo')) " &
            "BEGIN " &
            "CREATE TABLE dbo.TPCompanyInfo " &
            "( " &
            "CompanyID [int] IDENTITY(1,1) NOT NULL, " &
            "CompanyName NVARCHAR(200) NOT NULL, " &
            "CompanyAddress NVARCHAR(300) NULL, " &
            "LicenseNumber NVARCHAR(50) NULL, " &
            "CommercialRegisterNo NVARCHAR(50) NULL, " &
            "LicenseImage IMAGE NULL, " &
            "CreationDate DATE NOT NULL, " &
            "LastEditDate DATE NULL, " &
            "Activite INT NULL, " &
            "CONSTRAINT PK_TPCompanyInfo PRIMARY KEY (CompanyID) " &
            "); " &
            "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF NOT EXISTS (SELECT 1 FROM sys.tables WHERE name='TPCompanyBranches' AND schema_id=SCHEMA_ID('dbo')) " &
            "BEGIN " &
            "CREATE TABLE dbo.TPCompanyBranches " &
            "( " &
            "BranchID [int] IDENTITY(1,1) NOT NULL, " &
            "CompanyID INT NOT NULL, " &
            "BranchName NVARCHAR(200) NOT NULL, " &
            "BranchAddress NVARCHAR(300) NULL, " &
            "TelNumber NVARCHAR(50) NULL, " &
            "LicenseNumber NVARCHAR(50) NULL, " &
            "CommercialRegisterNo NVARCHAR(50) NULL, " &
            "LicenseImage IMAGE NULL, " &
            "CreationDate DATE NOT NULL, " &
            "LastEditDate DATE NULL, " &
            "SalesCivilID NVARCHAR(250) NULL, " &
            "Activite INT NULL, " &
            "CONSTRAINT PK_TPCompanyBranches PRIMARY KEY (BranchID), " &
            "CONSTRAINT FK_TPCompanyBranches_TPCompanyInfo FOREIGN KEY (CompanyID) REFERENCES dbo.TPCompanyInfo(CompanyID) " &
            "); " &
            "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','Bank1') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD Bank1 DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','Bank2') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD Bank2 DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','Bank3') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD Bank3 DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','Bank4') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD Bank4 DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','InvVatType') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD InvVatType DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','InvVat') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD InvVat DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PaymentReceipt') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PaymentReceipt IMAGE NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PaymentTransNumber') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PaymentTransNumber NVARCHAR(100) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PayMethod1') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PayMethod1 NVARCHAR(50) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PayMethod2') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PayMethod2 NVARCHAR(50) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PayMethod3') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PayMethod3 NVARCHAR(50) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PayMethod4') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PayMethod4 NVARCHAR(50) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PurchaseGold') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PurchaseGold DECIMAL(18,3) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PurchaseGoldKarat') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PurchaseGoldKarat NVARCHAR(100) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.Parameters.Clear()
            GlCommand.CommandText =
            "IF COL_LENGTH('dbo.BAYWholesale','PurchaseInvNumber') IS NULL " &
            "ALTER TABLE dbo.BAYWholesale ADD PurchaseInvNumber NVARCHAR(500) NULL;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        GlCommand.Parameters.Clear()
        GlCommand.CommandText =
                               "IF EXISTS (SELECT 1 FROM sys.columns " &
                               "WHERE Name = 'CashierID' AND Object_ID = OBJECT_ID('dbo.TPSellBuyWholesale')) " &
                               "ALTER TABLE dbo.TPSellBuyWholesale ALTER COLUMN CashierID NVARCHAR(50) NULL;"
        GlCommand.ExecuteNonQuery()
        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'SalesInvNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [SalesInvNumber] nvarchar(500) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PurchaseInvNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PurchaseInvNumber] nvarchar(500) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PurchaseGold') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PurchaseGold] decimal(18, 3) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PaymentReceipt') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [bay_goled_mony] ADD [PaymentReceipt] [image] NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PaymentTransNumber') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [bay_goled_mony] ADD [PaymentTransNumber] nvarchar(100) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PurchaseInvNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [BAY] ADD [PurchaseInvNumber] nvarchar(500) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PurchaseGold') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [BAY] ADD [PurchaseGold] decimal(18, 3) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PaymentReceipt') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [BAY] ADD [PaymentReceipt] [image] NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()


            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PaymentTransNumber') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [BAY] ADD [PaymentTransNumber] nvarchar(100) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'PurchaseInvNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverBAY] ADD [PurchaseInvNumber] nvarchar(500) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'PurchaseGold') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverBAY] ADD [PurchaseGold] decimal(18, 3) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'PaymentReceipt') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [SilverBAY] ADD [PaymentReceipt] [image] NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()


            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'PaymentTransNumber') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [SilverBAY] ADD [PaymentTransNumber] nvarchar(100) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'شراء الساعات والمركات
        Try





            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PaymentReceipt') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [Accessories_Buy_Pay] ADD [PaymentReceipt] [image] NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()


            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PaymentTransNumber') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [Accessories_Buy_Pay] ADD [PaymentTransNumber] nvarchar(100) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PayMethod') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [PayMethod] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PayMethod1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [PayMethod1] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PayMethod2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [PayMethod2] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PayMethod3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [PayMethod3] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'PayMethod4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [PayMethod4] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'Bank') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [Bank] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'Bank1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [Bank1] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'Bank2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [Bank2] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'Bank3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [Bank3] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy_Pay', 'Bank4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_Buy_Pay] ADD [Bank4] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [PayMethod] = '1' WHERE [PayMethod] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [PayMethod1] = '1' WHERE [PayMethod1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [PayMethod2] = '1' WHERE [PayMethod2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [PayMethod3] = '1' WHERE [PayMethod3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [PayMethod4] = '1' WHERE [PayMethod4] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [Bank1] = '0' WHERE [Bank1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [Bank2] = '0' WHERE [Bank2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [Bank3] = '0' WHERE [Bank3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy_Pay] SET [Bank4] = '0' WHERE [Bank4] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        GlCommand.CommandText = "IF COL_LENGTH('COMPANY_BAY_DETELS', 'CreationDate') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [COMPANY_BAY_DETELS] ADD [CreationDate] [date] NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "IF COL_LENGTH('COMPANY_BAY_DETELS', 'LastEditDate') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [COMPANY_BAY_DETELS] ADD [LastEditDate] [date] NULL " & vbCrLf &
                                    "END"
        GlCommand.ExecuteNonQuery()

        GlCommand.CommandText = "ALTER TABLE [dbo].[COMPANY_BAY_DETELS] ALTER COLUMN  [DATE_CRETED] [nvarchar](255)  NULL "
        GlCommand.ExecuteNonQuery()
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwAccessoriesInvoceReport]') IS NOT NULL " &
                                "DROP VIEW [ViwAccessoriesInvoceReport] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwAccessoriesInvoceReport] AS SELECT dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.Accessories_BAY.Accessories_BAY_SARYAL, " & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_TOTAL_mony AS TotalPrice, dbo.Accessories_BAY.Accessories_KENT AS KNET," & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_CACH AS Cash, dbo.cacher.cacher_name, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE," & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_staytes, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, " & vbCrLf &
                         "dbo.Accessories_INV.Accessories_INV_TIME" & vbCrLf &
                         "FROM dbo.CastomerDETELS RIGHT OUTER JOIN" & vbCrLf &
                         "dbo.Accessories_BAY INNER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.Accessories_BAY.Accessories_PayMethod = dbo.PayMethod.ID RIGHT OUTER JOIN" & vbCrLf &
                         "dbo.Accessories_INV ON dbo.Accessories_BAY.Accessories_BAY_SARYAL = dbo.Accessories_INV.Accessories_INV_NO_ID ON " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerCAIVELid = dbo.Accessories_INV.Accessories_INV_CASTOMER_ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.Accessories_BAY.Accessories_Casher = dbo.cacher.svil_id" & vbCrLf &
                         "GROUP BY dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA," & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.cacher.cacher_name, " & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_TOTAL_mony, dbo.Accessories_BAY.Accessories_KENT," & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_CACH, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE, " & vbCrLf &
                         "dbo.Accessories_BAY.Accessories_staytes, dbo.Accessories_INV.Accessories_Active," & vbCrLf &
                         "dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Accessories_INV.Accessories_INV_TIME" & vbCrLf &
                         "HAVING (dbo.Accessories_BAY.Accessories_staytes = 1) AND (dbo.Accessories_INV.Accessories_Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldPurchaseInvoice]') IS NOT NULL " &
                                "DROP VIEW [ViwGoldPurchaseInvoice] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldPurchaseInvoice] AS SELECT dbo.Buy_Gold.castomer_id, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, " & vbCrLf &
                         "dbo.Buy_Gold.bay_val, dbo.Buy_Gold.bay_mazan, dbo.Buy_Gold.bay_gram_price, dbo.Buy_Gold.bay_total_price," & vbCrLf &
                         "dbo.bay_goled_mony.total_price, dbo.bay_goled_mony.cach, dbo.bay_goled_mony.kenet, " & vbCrLf &
                         "dbo.bay_goled_mony.arabik, dbo.Buy_Gold.inv_id, dbo.bay_goled_mony.date, dbo.CastomerDETELS.Signature," & vbCrLf &
                         "dbo.Settings.PIC1, dbo.bay_goled_mony.English, dbo.Buy_Gold.Item_Des, dbo.Buy_Gold.INV_Actv, " & vbCrLf &
                         "dbo.CastomerDETELS.fotoBack, dbo.bay_goled_mony.INV_Actv AS INV_Actv_bay, dbo.bay_goled_mony.TIME_INV," & vbCrLf &
                         "dbo.bay_goled_mony.Cashier, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, " & vbCrLf &
                         "dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Buy_Gold.AddToItem, dbo.Buy_Gold.Note," & vbCrLf &
                         "dbo.Buy_Gold.GoldWeight999, dbo.Buy_Gold.Qunt, dbo.Buy_Gold.GoldCaret999, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEn, dbo.bay_goled_mony.PayMethod, dbo.Buy_Gold.B_gold_id, dbo.comp_inform.logo1," & vbCrLf &
                         "dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, " & vbCrLf &
                         "dbo.bay_goled_mony.Bank1, dbo.bay_goled_mony.Bank2, dbo.bay_goled_mony.Bank3, dbo.bay_goled_mony.Bank4," & vbCrLf &
                         "dbo.bay_goled_mony.PayMethod1, dbo.bay_goled_mony.PayMethod2, dbo.bay_goled_mony.PayMethod3, " & vbCrLf &
                         "dbo.bay_goled_mony.PayMethod4, PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_2.PayMethodAr AS PayMethodAr2," & vbCrLf &
                         "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_4.PayMethodAr AS PayMethodAr4, " & vbCrLf &
                         "dbo.bay_goled_mony.PaymentReceipt, dbo.bay_goled_mony.PaymentTransNumber, dbo.bay_goled_mony.SalesInvNumber," & vbCrLf &
                         "dbo.bay_goled_mony.PurchaseInvNumber, dbo.bay_goled_mony.PurchaseGold" & vbCrLf &
                         "FROM dbo.Buy_Gold INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.Buy_Gold.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.bay_goled_mony ON dbo.Buy_Gold.inv_id = dbo.bay_goled_mony.saryal LEFT OUTER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.bay_goled_mony.Cashier = dbo.cacher.svil_id LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.bay_goled_mony.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.bay_goled_mony.PayMethod1 = PayMethod_1.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.bay_goled_mony.PayMethod2 = PayMethod_2.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.bay_goled_mony.PayMethod3 = PayMethod_3.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.bay_goled_mony.PayMethod4 = PayMethod_4.ID CROSS JOIN" & vbCrLf &
                         "dbo.Settings CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try



        'Try
        GlCommand.CommandText = "IF OBJECT_ID('[ViwDeletGoldPurchaseInvoice]') IS NOT NULL " &
                                "DROP VIEW [ViwDeletGoldPurchaseInvoice] "
            GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "CREATE VIEW [dbo].[ViwDeletGoldPurchaseInvoice] AS SELECT dbo.Buy_Gold.castomer_id, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, " & vbCrLf &
                         "dbo.Buy_Gold.bay_val, dbo.Buy_Gold.bay_mazan, dbo.Buy_Gold.bay_gram_price, dbo.Buy_Gold.bay_total_price," & vbCrLf &
                         "dbo.bay_goled_mony.total_price, dbo.bay_goled_mony.cach, dbo.bay_goled_mony.kenet, " & vbCrLf &
                         "dbo.bay_goled_mony.arabik, dbo.Buy_Gold.inv_id, dbo.bay_goled_mony.date, dbo.CastomerDETELS.Signature," & vbCrLf &
                         "dbo.Settings.PIC1, dbo.bay_goled_mony.English, dbo.Buy_Gold.Item_Des, dbo.Buy_Gold.INV_Actv, " & vbCrLf &
                         "dbo.CastomerDETELS.fotoBack, dbo.bay_goled_mony.INV_Actv AS INV_Actv_bay, dbo.bay_goled_mony.TIME_INV," & vbCrLf &
                         "dbo.bay_goled_mony.Cashier, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, " & vbCrLf &
                         "dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Buy_Gold.AddToItem, dbo.Buy_Gold.Note," & vbCrLf &
                         "dbo.Buy_Gold.GoldWeight999, dbo.Buy_Gold.Qunt, dbo.Buy_Gold.GoldCaret999, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEn, dbo.bay_goled_mony.PayMethod, dbo.Buy_Gold.B_gold_id, dbo.comp_inform.logo1," & vbCrLf &
                         "dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, " & vbCrLf &
                         "dbo.bay_goled_mony.Bank1, dbo.bay_goled_mony.Bank2, dbo.bay_goled_mony.Bank3, dbo.bay_goled_mony.Bank4," & vbCrLf &
                         "dbo.bay_goled_mony.PayMethod1, dbo.bay_goled_mony.PayMethod2, dbo.bay_goled_mony.PayMethod3, " & vbCrLf &
                         "dbo.bay_goled_mony.PayMethod4, PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_2.PayMethodAr AS PayMethodAr2," & vbCrLf &
                         "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_4.PayMethodAr AS PayMethodAr4, " & vbCrLf &
                         "dbo.bay_goled_mony.PaymentReceipt, dbo.bay_goled_mony.PaymentTransNumber, dbo.bay_goled_mony.SalesInvNumber," & vbCrLf &
                         "dbo.bay_goled_mony.PurchaseInvNumber, dbo.bay_goled_mony.PurchaseGold" & vbCrLf &
                         "FROM dbo.Buy_Gold INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.Buy_Gold.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.bay_goled_mony ON dbo.Buy_Gold.inv_id = dbo.bay_goled_mony.saryal LEFT OUTER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.bay_goled_mony.Cashier = dbo.cacher.svil_id LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.bay_goled_mony.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.bay_goled_mony.PayMethod1 = PayMethod_1.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.bay_goled_mony.PayMethod2 = PayMethod_2.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.bay_goled_mony.PayMethod3 = PayMethod_3.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.bay_goled_mony.PayMethod4 = PayMethod_4.ID CROSS JOIN " & vbCrLf &
                         "dbo.Settings CROSS JOIN " & vbCrLf &
                         "dbo.comp_inform where bay_goled_mony.INV_Actv=0"
        GlCommand.ExecuteNonQuery()
            'Catch ex As Exception
            '    FailMessages &= ex.Message
            'End Try






































            Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPGoldVoucherReceive]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[TPGoldVoucherReceive](" & vbCrLf &
                                    "[GoldVoucherReceiveID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[VoucherNumber] [nvarchar](50) NOT NULL," & vbCrLf &
                                    "[CivilID] [nvarchar](50) NULL," & vbCrLf &
                                    "[UserID] [nvarchar](50) NULL," & vbCrLf &
                                    "[Casher] [nvarchar](50) NULL," & vbCrLf &
                                    "[VoucherType] [nvarchar](50) NULL," & vbCrLf &
                                    "[Supplier] [nvarchar](50) NULL," & vbCrLf &
                                    "[GoldKarat] [nvarchar](50) NULL," & vbCrLf &
                                    "[PurKarat] [nvarchar](50) NULL," & vbCrLf &
                                    "[GoldWeight] [decimal](18, 3) NULL," & vbCrLf &
                                    "[PurWeight] [decimal](18, 3) NULL," & vbCrLf &
                                    "[GramPrice] [decimal](18, 3) NULL," & vbCrLf &
                                    "[GoldPrice] [decimal](18, 3) NULL," & vbCrLf &
                                    "[MakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                    "[TotalMakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                    "[TotalPrice] [decimal](18, 3) NULL," & vbCrLf &
                                    "[Qunt] [nvarchar](50) NULL," & vbCrLf &
                                    "[WeightArletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[WeightEnletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[TotalPriceArletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[TotalPriceEnletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[PurWeightArletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[PurWeightEnletters] [nvarchar](255) NOT NULL," & vbCrLf &
                                    "[CreationDate] [date] NULL," & vbCrLf &
                                    "[LastEditDate] [date] NULL," & vbCrLf &
                                    "[Time] [nvarchar](50) NULL," & vbCrLf &
                                    "[Note] [nvarchar](500) NULL," & vbCrLf &
                                    "[Activite] [int] NULL," & vbCrLf &
                                    "CONSTRAINT [PK_TPGoldVoucherReceive] PRIMARY KEY CLUSTERED ([GoldVoucherReceiveID] ASC" & vbCrLf &
                                    ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF," & vbCrLf &
                                    "ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل الترقيم للذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'MaxID') IS NULL" & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [BAY] ADD [MaxID] nvarchar(250)" & vbCrLf &
                                    "END"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE BAY SET MaxID=BAY_ID WHERE MaxID IS NULL"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل الترقيم للالماس
        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_bay', 'MaxID') IS NULL" & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_bay] ADD [MaxID] nvarchar(250)" & vbCrLf &
                                    "END"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE dimon_bay SET MaxID=BAY_SARYAL WHERE MaxID IS NULL"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'اضافة حقل الترقيم للفضه
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'MaxID') IS NULL" & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverBAY] ADD [MaxID] nvarchar(250)" & vbCrLf &
                                    "END"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE SilverBAY SET MaxID=BAY_SARYAL WHERE MaxID IS NULL"
            GlCommand.CommandTimeout = 50 : GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try



        Try
            GlCommand.CommandText = "IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[bay_price_report_kenet_cach]'))" & vbCrLf &
                                "DROP VIEW [dbo].[bay_price_report_kenet_cach] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dbo].[bay_goled_mony]" & vbCrLf &
                                    "SET [dbo].[bay_goled_mony].[Cashier] = [dbo].[cacher].[svil_id]" & vbCrLf &
                                    "FROM [dbo].[bay_goled_mony]" & vbCrLf &
                                    "INNER JOIN [dbo].[cacher]" & vbCrLf &
                                    "ON CONVERT(NVARCHAR(50), [dbo].[bay_goled_mony].[Cashier]) =" & vbCrLf &
                                    "CONVERT(NVARCHAR(50), [dbo].[cacher].[cacherID])" & vbCrLf &
                                    "WHERE [dbo].[cacher].[Active] = 1"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [dbo].[bay_goled_mony]" & vbCrLf &
                                    "SET [dbo].[bay_goled_mony].[Cashier] = [dbo].[cacher].[svil_id]" & vbCrLf &
                                    "FROM [dbo].[bay_goled_mony]" & vbCrLf &
                                    "INNER JOIN [dbo].[cacher]" & vbCrLf &
                                    "ON CONVERT(NVARCHAR(50), [dbo].[bay_goled_mony].[Cashier]) = CONVERT(NVARCHAR(50), [dbo].[cacher].[cacherID])" & vbCrLf &
                                    "WHERE [dbo].[cacher].[Active] = 1"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'جدول الاصناف المحوله
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPTransfer]') IS NULL " & vbCrLf &
                                "CREATE TABLE [dbo].[TPTransfer](" & vbCrLf &
                                "[TransferID] [int]  IDENTITY(1,1) NOT NULL," & vbCrLf &
                                "[BarCodeTransfer] [nvarchar](50) NULL," & vbCrLf &
                                "[DateBarCode] [date] NULL," & vbCrLf &
                                "[TimeBarCode] [datetime] NULL," & vbCrLf &
                                "[TransferStatus] [int] NULL," & vbCrLf &
                                "CONSTRAINT [PK_TpTransfer] " & vbCrLf &
                                "PRIMARY KEY CLUSTERED ([TransferID] ASC" & vbCrLf &
                                ")WITH (PAD_INDEX  = OFF, " & vbCrLf &
                                "STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & vbCrLf &
                                ")ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'ViwDiamondInvoceReport
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwDiamondInvoceReport]') IS NOT NULL " &
                                    "DROP VIEW [ViwDiamondInvoceReport] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwDiamondInvoceReport] AS SELECT" & vbCrLf &
                                    "dbo.dimon_invce.castomr_id, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                                    "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerNA," & vbCrLf &
                                    "dbo.CastomerDETELS.foto, dbo.dimon_invce.descont, dbo.dimon_invce.total, " & vbCrLf &
                                    "dbo.dimon_invce.ar_taype, dbo.dimon_invce.DIMO_Type," & vbCrLf &
                                    "dbo.dimon_invce.DIM_na9awa, dbo.dimon_invce.DIMO_mezan," & vbCrLf &
                                    "dbo.dimon_invce.DIMO_coler, dbo.dimon_invce.DIMO_qult, dbo.dimon_invce.sarual, " & vbCrLf &
                                    "dbo.dimon_invce.val_gold, dbo.dimon_invce.GOLD_mezan, dbo.dimon_invce.user_creted," & vbCrLf &
                                    "dbo.dimon_invce.date_creted, dbo.dimon_invce.time, dbo.dimon_invce.dim_foto, dbo.cacher.cacher_name, " & vbCrLf &
                                    "dbo.dimon_bay.BAY_SARYAL, dbo.dimon_bay.TOTAL_mony, dbo.dimon_bay.CACH AS dimon_bay_cach," & vbCrLf &
                                    "dbo.dimon_bay.KENT, dbo.dimon_bay.arbic_tayb, dbo.dimon_bay.balance, dbo.dimon_bay.staytes, " & vbCrLf &
                                    "dbo.dimon_invce.dimo_id, dbo.cacher.svil_id, dbo.dimon_invce.notes, dbo.Settings.PIC1," & vbCrLf &
                                    "dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.CastomerTE," & vbCrLf &
                                    "dbo.DIMON_detels.test_12, dbo.dimon_invce.test_13, " & vbCrLf &
                                    "dbo.dimon_invce.test_14, dbo.dimon_invce.test_15," & vbCrLf &
                                    "dbo.dimon_invce.test_16, dbo.dimon_invce.test_17," & vbCrLf &
                                    "dbo.dimon_invce.test_18, dbo.dimon_invce.test_19, dbo.dimon_invce.test_110, dbo.dimon_invce.test_111, " & vbCrLf &
                                    "dbo.dimon_invce.test_112, dbo.dimon_invce.test_116, dbo.dimon_invce.test_117, dbo.dimon_invce.test_118," & vbCrLf &
                                    "dbo.dimon_invce.test_119, dbo.dimon_bay.English_tayb, dbo.dimon_bay.PayMethod, dbo.PayMethod.PayMethodAr," & vbCrLf &
                                    "dbo.PayMethod.PayMethodEn, dbo.dimon_invce.GramPrice, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn," & vbCrLf &
                                    "dbo.dimon_invce.SoldItem, dbo.comp_inform.comp_name, dbo.dimon_invce.Item_Actv, " & vbCrLf &
                                    "dbo.dimon_invce.staytes AS Expr1, dbo.dimon_invce.Cut1, dbo.dimon_invce.Clarity1, dbo.dimon_invce.Cut2," & vbCrLf &
                                    "dbo.dimon_invce.Clarity2, dbo.dimon_invce.Cut3, dbo.dimon_invce.Clarity3, dbo.dimon_invce.IsDiamond1, " & vbCrLf &
                                    "dbo.dimon_invce.IsDiamond2, dbo.dimon_invce.IsDiamond3, dbo.dimon_invce.CertificateNumber," & vbCrLf &
                                    "dbo.cacher.CashierSignature, dbo.DIMON_detels.MetalType, dbo.DIMON_detels.ITEM_IMGE, dbo.comp_inform.comp_note1," & vbCrLf &
                                    "dbo.comp_inform.logo1, dbo.comp_inform.logo2" & vbCrLf &
                                    "FROM dbo.dimon_invce INNER JOIN" & vbCrLf &
                                    "dbo.CastomerDETELS ON dbo.dimon_invce.castomr_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                                    "dbo.dimon_bay ON dbo.dimon_invce.descont = dbo.dimon_bay.BAY_SARYAL INNER JOIN" & vbCrLf &
                                    "dbo.PayMethod ON dbo.dimon_bay.PayMethod = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                                    "dbo.DIMON_detels ON dbo.dimon_invce.dimo_id = dbo.DIMON_detels.test_119 LEFT OUTER JOIN" & vbCrLf &
                                    "dbo.cacher ON dbo.dimon_invce.test_118 = dbo.cacher.svil_id CROSS JOIN" & vbCrLf &
                                    "dbo.Settings CROSS JOIN" & vbCrLf &
                                    "dbo.comp_inform WHERE (dbo.dimon_invce.Item_Actv = 1) AND (dbo.dimon_bay.Item_Actv = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwDiamondInvoceReportShort]') IS NOT NULL " &
                                "DROP VIEW [ViwDiamondInvoceReportShort] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwDiamondInvoceReportShort] AS  SELECT castomr_id," & vbCrLf &
                             "CastomerNAme, CastomerADr, CastomerNA, BAY_SARYAL, TOTAL_mony," & vbCrLf &
                             "date_creted, time, cacher_name, KENT, balance, CastomerTE," & vbCrLf &
                             "CastomerNameEn, dimon_bay_cach, SUM(DIMO_mezan) " & vbCrLf &
                             "AS DiamondCarat, SUM(GOLD_mezan) AS GoldWeight, SUM(test_13) AS Ston1," & vbCrLf &
                             "SUM(test_16) AS Ston2, SUM(test_19) AS Ston3, SUM(test_116) AS TotalWeight" & vbCrLf &
                             "FROM dbo.ViwDiamondInvoceReport" & vbCrLf &
                             "GROUP BY castomr_id, CastomerNAme, CastomerADr, CastomerNA, BAY_SARYAL," & vbCrLf &
                             "TOTAL_mony, date_creted, time, cacher_name, KENT, balance, CastomerTE, CastomerNameEn, dimon_bay_cach"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldInvoceReport]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [ViwGoldInvoceReport]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldInvoceReport]AS SELECT dbo.selInvoceDetels.item_name," & vbCrLf &
                         "dbo.selInvoceDetels.Castomerid, dbo.selInvoceDetels.itemID, dbo.selInvoceDetels.item_GramPrice," & vbCrLf &
                         "dbo.selInvoceDetels.item_gram, dbo.selInvoceDetels.item_gramMade, " & vbCrLf &
                         "dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_totalPrice," & vbCrLf &
                         "dbo.selInvoceDetels.item_cantrey, dbo.selInvoceDetels.MetalPrice, dbo.selInvoceDetels.userID, " & vbCrLf &
                         "dbo.BAY.TOTAL_mony, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.arbic_tayb, dbo.BAY.balance, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNA, dbo.BAY.staytes, dbo.CastomerDETELS.foto, dbo.selInvoceDetels.invoc_date_time," & vbCrLf &
                         "dbo.FO_min.Gram_valu, dbo.selInvoceDetels.qunt, dbo.selInvoceDetels.nots, dbo.cacher.cacher_name, " & vbCrLf &
                         "dbo.selInvoceDetels.date, dbo.BAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, dbo.selInvoceDetels.item_gramMade *" & vbCrLf &
                         "dbo.selInvoceDetels.item_gram AS Total_gramMade, dbo.BAY.English_tayb, " & vbCrLf &
                         "dbo.selInvoceDetels.Active, dbo.BAY.Notes, dbo.BAY.PayMethod, dbo.cacher.CashierSignature, dbo.selInvoceDetels.StoneWeight2," & vbCrLf &
                         "dbo.selInvoceDetels.StoneWeight3, dbo.selInvoceDetels.StonePrice2, " & vbCrLf &
                         "dbo.selInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.FO_min.BarCode, dbo.selInvoceDetels.item_desp," & vbCrLf &
                         "dbo.selInvoceDetels.cacher, dbo.selInvoceDetels.Cash, " & vbCrLf &
                         "dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.StoneName1, dbo.selInvoceDetels.StoneColor1," & vbCrLf &
                         "dbo.selInvoceDetels.StoneName2, dbo.selInvoceDetels.StoneColor2, " & vbCrLf &
                         "dbo.selInvoceDetels.StoneName3, dbo.selInvoceDetels.StoneColor3, dbo.selInvoceDetels.ID, dbo.selInvoceDetels.StonePriceType1, " & vbCrLf &
                         "dbo.selInvoceDetels.StonePriceType2, dbo.selInvoceDetels.StonePriceType3, " & vbCrLf &
                         "dbo.selInvoceDetels.GoledKarat, dbo.FO_min.ITEM_IMGE, dbo.FO_min.FO_desp, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn," & vbCrLf &
                         "PayMethod_1.PayMethodAr AS PayMethodAr1, " & vbCrLf &
                         "PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.BAY.PayMethod1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS" & vbCrLf &
                         "PayMethodEn2, dbo.BAY.PayMethod2, " & vbCrLf &
                         "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, dbo.BAY.PayMethod3, PayMethod_4.PayMethodAr AS" & vbCrLf &
                         "PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, " & vbCrLf &
                         "dbo.BAY.PayMethod4, dbo.BAY.Bank1, dbo.BAY.Bank2, dbo.BAY.Bank3, dbo.BAY.Bank4, dbo.BAY.Active AS BAYActive, dbo.BAY.BAY_ID," & vbCrLf &
                         "dbo.selInvoceDetels.ItemVatType, dbo.selInvoceDetels.ItemVat, dbo.BAY.InvVatType, " & vbCrLf &
                         "dbo.BAY.InvVat, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, dbo.FO_min.GoldCaret999," & vbCrLf &
                         "dbo.FO_min.GoldWeight999, dbo.BAY.PurchaseInvNumber, " & vbCrLf &
                         "dbo.BAY.PaymentReceipt, dbo.BAY.PaymentTransNumber, dbo.BAY.PurchaseGold, dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp AS" & vbCrLf &
                         "GramProfit, (dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp) " & vbCrLf &
                         "* dbo.FO_min.FO_gram AS TotalGramProfit, dbo.selInvoceDetels.item_gramMade * dbo.FO_min.FO_gram AS TotalMake, dbo.FO_min.FO_desp *" & vbCrLf &
                         "dbo.FO_min.FO_gram AS TotalCost, dbo.FO_min.FO_GramPrice AS Supplier, " & vbCrLf &
                         "dbo.FO_min.FO_gram AS EnteredWeight, dbo.FO_min.FO_desp AS Cost, dbo.selInvoceDetels.item_gram AS SellWeight, dbo.selInvoceDetels.item_gramMade AS" & vbCrLf &
                         "MakingCharge, dbo.CastomerDETELS.CastomerCAIVELidKYC, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNAmeKYC, dbo.CastomerDETELS.CastomerADrKYC, dbo.CastomerDETELS.CastomerTEKYC, dbo.CastomerDETELS.CastomerNAKYC," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEnKYC" & vbCrLf &
                         "FROM dbo.BAY INNER JOIN" & vbCrLf &
                         "dbo.selInvoceDetels ON dbo.BAY.BAY_SARYAL = dbo.selInvoceDetels.invoc_time INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.BAY.PayMethod = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.BAY.PayMethod1 = PayMethod_1.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.BAY.PayMethod2 = PayMethod_2.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.BAY.PayMethod3 = PayMethod_3.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.BAY.PayMethod4 = PayMethod_4.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.FO_min ON dbo.selInvoceDetels.itemID = dbo.FO_min.BarCode CROSS JOIN" & vbCrLf &
                         "dbo.Settings CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform" & vbCrLf &
                         "WHERE(dbo.BAY.Active = 1) AND (dbo.selInvoceDetels.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldInvoceDeletReport]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [ViwGoldInvoceDeletReport]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldInvoceDeletReport]AS SELECT dbo.selInvoceDetels.item_name," & vbCrLf &
                         "dbo.selInvoceDetels.Castomerid, dbo.selInvoceDetels.itemID, dbo.selInvoceDetels.item_GramPrice," & vbCrLf &
                         "dbo.selInvoceDetels.item_gram, dbo.selInvoceDetels.item_gramMade, " & vbCrLf &
                         "dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_totalPrice," & vbCrLf &
                         "dbo.selInvoceDetels.item_cantrey, dbo.selInvoceDetels.MetalPrice, dbo.selInvoceDetels.userID, " & vbCrLf &
                         "dbo.BAY.TOTAL_mony, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.arbic_tayb, dbo.BAY.balance, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNA, dbo.BAY.staytes, dbo.CastomerDETELS.foto, dbo.selInvoceDetels.invoc_date_time," & vbCrLf &
                         "dbo.FO_min.Gram_valu, dbo.selInvoceDetels.qunt, dbo.selInvoceDetels.nots, dbo.cacher.cacher_name, " & vbCrLf &
                         "dbo.selInvoceDetels.date, dbo.BAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, dbo.selInvoceDetels.item_gramMade *" & vbCrLf &
                         "dbo.selInvoceDetels.item_gram AS Total_gramMade, dbo.BAY.English_tayb, " & vbCrLf &
                         "dbo.selInvoceDetels.Active, dbo.BAY.Notes, dbo.BAY.PayMethod, dbo.cacher.CashierSignature, dbo.selInvoceDetels.StoneWeight2," & vbCrLf &
                         "dbo.selInvoceDetels.StoneWeight3, dbo.selInvoceDetels.StonePrice2, " & vbCrLf &
                         "dbo.selInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.FO_min.BarCode, dbo.selInvoceDetels.item_desp," & vbCrLf &
                         "dbo.selInvoceDetels.cacher, dbo.selInvoceDetels.Cash, " & vbCrLf &
                         "dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.StoneName1, dbo.selInvoceDetels.StoneColor1," & vbCrLf &
                         "dbo.selInvoceDetels.StoneName2, dbo.selInvoceDetels.StoneColor2, " & vbCrLf &
                         "dbo.selInvoceDetels.StoneName3, dbo.selInvoceDetels.StoneColor3, dbo.selInvoceDetels.ID, dbo.selInvoceDetels.StonePriceType1, " & vbCrLf &
                         "dbo.selInvoceDetels.StonePriceType2, dbo.selInvoceDetels.StonePriceType3, " & vbCrLf &
                         "dbo.selInvoceDetels.GoledKarat, dbo.FO_min.ITEM_IMGE, dbo.FO_min.FO_desp, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn," & vbCrLf &
                         "PayMethod_1.PayMethodAr AS PayMethodAr1, " & vbCrLf &
                         "PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.BAY.PayMethod1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS" & vbCrLf &
                         "PayMethodEn2, dbo.BAY.PayMethod2, " & vbCrLf &
                         "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, dbo.BAY.PayMethod3, PayMethod_4.PayMethodAr AS" & vbCrLf &
                         "PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, " & vbCrLf &
                         "dbo.BAY.PayMethod4, dbo.BAY.Bank1, dbo.BAY.Bank2, dbo.BAY.Bank3, dbo.BAY.Bank4, dbo.BAY.Active AS BAYActive, dbo.BAY.BAY_ID," & vbCrLf &
                         "dbo.selInvoceDetels.ItemVatType, dbo.selInvoceDetels.ItemVat, dbo.BAY.InvVatType, " & vbCrLf &
                         "dbo.BAY.InvVat, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, dbo.FO_min.GoldCaret999," & vbCrLf &
                         "dbo.FO_min.GoldWeight999, dbo.BAY.PurchaseInvNumber, " & vbCrLf &
                         "dbo.BAY.PaymentReceipt, dbo.BAY.PaymentTransNumber, dbo.BAY.PurchaseGold, dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp AS" & vbCrLf &
                         "GramProfit, (dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp) " & vbCrLf &
                         "* dbo.FO_min.FO_gram AS TotalGramProfit, dbo.selInvoceDetels.item_gramMade * dbo.FO_min.FO_gram AS TotalMake, dbo.FO_min.FO_desp *" & vbCrLf &
                         "dbo.FO_min.FO_gram AS TotalCost, dbo.FO_min.FO_GramPrice AS Supplier, " & vbCrLf &
                         "dbo.FO_min.FO_gram AS EnteredWeight, dbo.FO_min.FO_desp AS Cost, dbo.selInvoceDetels.item_gram AS SellWeight, dbo.selInvoceDetels.item_gramMade AS" & vbCrLf &
                         "MakingCharge, dbo.CastomerDETELS.CastomerCAIVELidKYC, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNAmeKYC, dbo.CastomerDETELS.CastomerADrKYC, dbo.CastomerDETELS.CastomerTEKYC, dbo.CastomerDETELS.CastomerNAKYC," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEnKYC" & vbCrLf &
                         "FROM dbo.BAY INNER JOIN" & vbCrLf &
                         "dbo.selInvoceDetels ON dbo.BAY.BAY_SARYAL = dbo.selInvoceDetels.invoc_time INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.BAY.PayMethod = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.BAY.PayMethod1 = PayMethod_1.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.BAY.PayMethod2 = PayMethod_2.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.BAY.PayMethod3 = PayMethod_3.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.BAY.PayMethod4 = PayMethod_4.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.FO_min ON dbo.selInvoceDetels.itemID = dbo.FO_min.BarCode CROSS JOIN" & vbCrLf &
                         "dbo.Settings CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform" & vbCrLf &
                         "WHERE(dbo.BAY.Active = 0)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'تقرير المبيعات المختصر ذهب
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldInvoceReportShort]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ViwGoldInvoceReportShort]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldInvoceReportShort] AS SELECT  CastomerNAme, Castomerid," & vbCrLf &
                                          "CastomerNA, cacher_name, SUM(item_gram) AS item_gram, SUM(item_gramMade) AS item_gramMade," & vbCrLf &
                                          "SUM(item_extrasMAZAN) AS item_extrasMAZAN, SUM(StoneWeight2) " & vbCrLf &
                                          "AS StoneWeight2, SUM(StoneWeight3) AS StoneWeight3, SUM(MetalPrice) AS MetalPrice, KENT, Bank1," & vbCrLf &
                                          "Bank2, Bank3, Bank4, CACH, TOTAL_mony, BAY_SARYAL, invoc_date_time, date, CastomerADr, CastomerTE, " & vbCrLf &
                                          "CastomerNameEn, PayMethodAr, PayMethodEn, CastomerCAIVELidKYC, CastomerNAmeKYC, CastomerADrKYC," & vbCrLf &
                                         "CastomerTEKYC, CastomerNAKYC, CastomerNameEnKYC" & vbCrLf &
                                         "FROM dbo.ViwGoldInvoceReport" & vbCrLf &
                                         "GROUP BY CastomerNAme, Castomerid, CastomerNA, cacher_name, KENT, Bank1, Bank2, Bank3, Bank4, CACH," & vbCrLf &
                                         "TOTAL_mony, BAY_SARYAL, invoc_date_time, date, CastomerADr, CastomerTE, CastomerNameEn, PayMethodAr, " & vbCrLf &
                                         "PayMethodEn, CastomerCAIVELidKYC, CastomerNAmeKYC, CastomerADrKYC, CastomerTEKYC, CastomerNAKYC, CastomerNameEnKYC"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'الاصناف المتوفره ذهب
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldIItemAvailableReport]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ViwGoldIItemAvailableReport]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldIItemAvailableReport] AS SELECT" & vbCrLf &
                                    "f.ID, f.userID, f.FO_name, f.FO_desp, f.FO_price, f.FO_GramPrice," & vbCrLf &
                                    "f.FO_gram, f.FO_gramMade, f.FO_made, f.FO_extras, f.FO_totalPrice, " & vbCrLf &
                                    "f.Gram_valu, f.ITEM_IMGE, f.date_care, f.FO_ItemNo, f.Item_Actv, " & vbCrLf &
                                    "f.StoneColor1, f.StonePrice1, f.StoneWeight2, f.StoneName2, " & vbCrLf &
                                    "f.StoneColor2, f.StonePrice2, f.StoneWeight3, f.StoneName3, f.StoneColor3, f.StonePrice3, f.Qty, f.BarCode, f.LastEditDate, f.ItemNote, " & vbCrLf &
                                    "f.PurInvNumber, f.MultiItem, f.GoldCaret999, f.GoldWeight999, f.BarCodeNote" & vbCrLf &
                                    "FROM dbo.FO_min AS f LEFT OUTER JOIN" & vbCrLf &
                                    "dbo.selInvoceDetels AS s ON f.BarCode = s.itemID AND s.Active = 1" & vbCrLf &
                                    "WHERE (f.Item_Actv = 1) AND (s.itemID IS NULL)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'الاصناف المتوفره فضه
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwSilverIItemAvailableReport]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ViwSilverIItemAvailableReport]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwSilverIItemAvailableReport] AS" & vbCrLf &
                                    "SELECT f.ID, f.userID, f.FO_name, f.FO_desp, f.FO_price, f.FO_GramPrice, f.FO_gram," & vbCrLf &
                                    "f.FO_gramMade, f.FO_made, f.FO_extras, f.FO_totalPrice, f.Gram_valu, f.ITEM_IMGE, " & vbCrLf &
                                    "f.date_care, f.FO_ItemNo, f.Item_Actv, " & vbCrLf &
                                    "f.StoneColor1, f.StonePrice1, f.StoneWeight2, f.StoneName2, f.StoneColor2, " & vbCrLf &
                                    "f.StonePrice2, f.StoneWeight3, f.StoneName3, f.StoneColor3, f.StonePrice3, f.Qty, f.BarCode, f.LastEditDate, f.ItemNote, " & vbCrLf &
                                    "f.PurInvNumber, f.MultiItem, f.GoldCaret999, f.GoldWeight999, f.BarCodeNote" & vbCrLf &
                                    "FROM dbo.SilverItem AS f LEFT OUTER JOIN" & vbCrLf &
                                    "dbo.SilverInvoceDetels AS s ON f.BarCode = s.itemID AND s.Active = 1" & vbCrLf &
                                    "WHERE (f.Item_Actv = 1) AND (s.itemID IS NULL)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        '''''''''''''''''''''''''''''''''''''''TABLES'''''''''''''''''''''''''''''''''Note_
        '''
        'جدول اسماء المعارض
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPBranchDetails]') IS NULL " & vbCrLf &
                              "CREATE TABLE [dbo].[TPBranchDetails](" & vbCrLf &
                              "[BranchID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                              "[BranchDT] [nvarchar](50) NULL," & vbCrLf &
                              "[BranchServerNa] [nvarchar](50) NULL," & vbCrLf &
                              "[BranchUser] [nvarchar](50) NULL," & vbCrLf &
                              "[BranchPassword] [nvarchar](50) NULL," & vbCrLf &
                              "[BranchPublic] [nvarchar](60) NULL," & vbCrLf &
                              "[BranchActive] [int] NULL," & vbCrLf &
                              "CONSTRAINT [PK_TPBranchDetails] PRIMARY KEY CLUSTERED([BranchID] ASC " & vbCrLf &
                              ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = " & vbCrLf &
                              "OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'اضافة حقل نص الي الباركود للذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('FO_min', 'BarCodeNote') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [FO_min] ADD [BarCodeNote] nvarchar(250) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        ' اضافة حقل نص الي الباركود للفضه

        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverItem', 'BarCodeNote') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverItem] ADD [BarCodeNote] nvarchar(250) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل نص الي الباركود للذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('FO_min', 'BarCodeNote') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [FO_min] ADD [BarCodeNote] nvarchar(250) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        ' اضافة حقل نص الي الباركود للفضه

        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverItem', 'BarCodeNote') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverItem] ADD [BarCodeNote] nvarchar(250) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        ' حقل نص الي الباركود في الاعدادات
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'BarCodeNote') IS NULL " & vbCrLf &
                                        "BEGIN " & vbCrLf &
                                        "ALTER TABLE [Settings] ADD [BarCodeNote] nvarchar(50) NULL" & vbCrLf &
                                        "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportSilvertemAvailable]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ReportSilvertemAvailable]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportSilvertemAvailable] AS SELECT DISTINCT " & vbCrLf &
                      "dbo.SilverItem.ID, dbo.SilverItem.userID, dbo.SilverItem.FO_name," & vbCrLf &
                      "dbo.SilverItem.FO_desp, dbo.SilverItem.FO_price, " & vbCrLf &
                      "dbo.SilverItem.FO_GramPrice, dbo.SilverItem.FO_gram, " & vbCrLf &
                      "dbo.SilverItem.FO_gramMade, dbo.SilverItem.FO_made, " & vbCrLf &
                      "dbo.SilverItem.FO_extras, dbo.SilverItem.FO_totalPrice, " & vbCrLf &
                      "dbo.SilverItem.Gram_valu, dbo.SilverItem.date_care, " & vbCrLf &
                      "dbo.SilverItem.FO_gramMade * dbo.SilverItem.FO_gram AS " & vbCrLf &
                      "FO_TotalgramMade, dbo.SilverItem.FO_desp * " & vbCrLf &
                      "dbo.SilverItem.FO_gram AS FO_TotaldespMade, dbo.SilverItem.BarCode, " & vbCrLf &
                      "dbo.SilverItem.StoneColor1, dbo.SilverItem.StonePrice1, " & vbCrLf &
                      "dbo.SilverItem.StoneWeight2, dbo.SilverItem.StoneName2, " & vbCrLf &
                      "dbo.SilverItem.StoneColor2, dbo.SilverItem.StonePrice2, " & vbCrLf &
                      "dbo.SilverItem.StoneWeight3, " & vbCrLf &
                      "dbo.SilverItem.StoneName3, dbo.SilverItem.StoneColor3," & vbCrLf &
                      "dbo.SilverItem.StonePrice3, dbo.SilverItem.Qty, " & vbCrLf &
                      "dbo.SilverItem.LastEditDate, dbo.SilverItem.ItemNote, dbo.SilverItem.PurInvNumber," & vbCrLf &
                      "dbo.SilverItem.MultiItem, dbo.SilverItem.GoldCaret999, dbo.SilverItem.GoldWeight999" & vbCrLf &
                      "FROM dbo.SilverItem LEFT OUTER JOIN" & vbCrLf &
                      "dbo.SilverInvoceDetels ON dbo.SilverItem.BarCode = dbo.SilverInvoceDetels.itemID" & vbCrLf &
                      "WHERE (dbo.SilverInvoceDetels.itemID IS NULL) OR" & vbCrLf &
                      "(dbo.SilverInvoceDetels.itemID NOT IN" & vbCrLf &
                      "(SELECT     itemID" & vbCrLf &
                      "FROM dbo.SilverInvoceDetels AS SilverInvoceDetels_1" & vbCrLf &
                      "WHERE (Active = 1))) AND (dbo.SilverInvoceDetels.Active = 0)" & vbCrLf &
                      "GROUP BY dbo.SilverItem.ID, dbo.SilverItem.userID, dbo.SilverItem.FO_name," & vbCrLf &
                      "dbo.SilverItem.FO_desp, dbo.SilverItem.FO_price, " & vbCrLf &
                      "dbo.SilverItem.FO_GramPrice, dbo.SilverItem.FO_gram, " & vbCrLf &
                      "dbo.SilverItem.FO_gramMade, dbo.SilverItem.FO_made, dbo.SilverItem.FO_extras," & vbCrLf &
                      "dbo.SilverItem.FO_totalPrice, dbo.SilverItem.Gram_valu, dbo.SilverItem.date_care, " & vbCrLf &
                      "dbo.SilverItem.FO_gramMade * dbo.SilverItem.FO_gram, dbo.SilverItem.FO_desp * " & vbCrLf &
                      "dbo.SilverItem.FO_gram, dbo.SilverItem.BarCode, dbo.SilverItem.Item_Actv, dbo.SilverItem.StoneColor1," & vbCrLf &
                      "dbo.SilverItem.StonePrice1, dbo.SilverItem.StoneWeight2, dbo.SilverItem.StoneName2, " & vbCrLf &
                      "dbo.SilverItem.StoneColor2, dbo.SilverItem.StonePrice2, dbo.SilverItem.StoneWeight3, dbo.SilverItem.StoneName3," & vbCrLf &
                      "dbo.SilverItem.StoneColor3, dbo.SilverItem.StonePrice3, dbo.SilverItem.Qty, " & vbCrLf &
                      "dbo.SilverItem.LastEditDate, dbo.SilverItem.ItemNote, dbo.SilverItem.PurInvNumber, dbo.SilverItem.MultiItem," & vbCrLf &
                      "dbo.SilverItem.GoldCaret999, dbo.SilverItem.GoldWeight999" & vbCrLf &
                      "HAVING (dbo.SilverItem.Item_Actv > 0)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'تتبع الاخطاء البرمجيه
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TBErrorDescription]') IS NULL " & vbCrLf &
                                     "CREATE TABLE [dbo].[TBErrorDescription](" & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[ErrorTime] [nvarchar](50) NULL," & vbCrLf &
                                    "[ErrorDescription] [nvarchar](1050) NULL," & vbCrLf &
                                    "CONSTRAINT [PK_TBErrorDescription] PRIMARY KEY CLUSTERED " & vbCrLf &
                                    "([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [BAY] SET [staytes]=1 where [staytes]like N'نقدا'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [staytes]=0 where [staytes]like N'اجل'"
            GlCommand.ExecuteNonQuery()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "UPDATE [SilverBAY] SET [staytes]=1 where [staytes]like N'نقدا'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SilverBAY] SET [staytes]=0 where [staytes]like N'اجل'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try




        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Supplier') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndToCustomer] ADD [Supplier] [int] NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        GlCommand.CommandText = "ALTER TABLE [TBErrorDescription] ALTER COLUMN [ErrorDescription] [text] NULL "
        GlCommand.ExecuteNonQuery()
        ''تحديث حقل التاريخ في الالماس
        GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [time] nvarchar(250)  NULL "
        GlCommand.ExecuteNonQuery()

        'ErrorDescription
        Try
            GlCommand.CommandText = "IF COL_LENGTH('COMPANY_BAY_DETELS', 'Active') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [COMPANY_BAY_DETELS] ADD [Active] [bit] NULL DEFAULT 1 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('COMPANY_BAY_DETELS', 'cacher') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [COMPANY_BAY_DETELS] ADD [cacher] nvarchar(50) NULL" & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('COMPANY_BAY_DETELS', 'SalesCivilID') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [COMPANY_BAY_DETELS] ADD [SalesCivilID] nvarchar(50) NULL" & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [FO_min] SET [BarCode]=ID WHERE [BarCode] IS NULL OR [BarCode]=''"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TBBondGoldType]') IS NULL " & vbCrLf &
                                      "CREATE TABLE [dbo].[TBBondGoldType]( " & vbCrLf &
                                      "[BondGoldTypeID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                      "[BondTypeArName] [nvarchar](50) NULL," & vbCrLf &
                                      "[BondTypeEnName] [nvarchar](50) NULL," & vbCrLf &
                                      "[BondTypeActiv] [int] NULL," & vbCrLf &
                                      "CONSTRAINT [PK_TBBondGoldType] PRIMARY KEY CLUSTERED " & vbCrLf &
                                      "([BondGoldTypeID] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  =" & vbCrLf &
                                      "OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('TBBondGoldType', 'BondType') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [TBBondGoldType] ADD [BondType] [int] NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            Dim DTBondType As DataTable = GetRecordSet("select * from TBBondGoldType")
            If DTBondType.Rows.Count = Nothing Then
                GlCommand.CommandText = "INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند قبض ذهب','Gold receipt voucher','1','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند صرف ذهب','Gold Payment voucher','1','0')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند استلام ذهب ','Gold Received voucher','1','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondGoldType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند تسليم ذهب','Gold Delivered voucher ','1','0')"
                GlCommand.ExecuteNonQuery()
            End If
            GlCommand.CommandText = "UPDATE [TBBondGoldType] SET  BondType=1 WHERE [BondTypeArName]LIKE N'سند قبض ذهب'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondGoldType] SET  BondType=0 WHERE [BondTypeArName]LIKE N'سند صرف ذهب'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondGoldType] SET  BondType=1 WHERE [BondTypeArName]LIKE N'سند استلام ذهب'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondGoldType] SET  BondType=0 WHERE [BondTypeArName]LIKE N'سند تسليم ذهب'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'تقرير سند الصرقف والقبض ذهب
        Try
            GlCommand.CommandText = "If OBJECT_ID('[TPGoldVoucher]') IS NULL  CREATE TABLE [dbo].[TPGoldVoucher](" & vbCrLf &
                                  "[GoldVoucherID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                  "[VoucherNumber] [nvarchar](50) NOT NULL," & vbCrLf &
                                  "[CivilID] [nvarchar](50) NULL," & vbCrLf &
                                  "[UserID] [nvarchar](50) NULL," & vbCrLf &
                                  "[Casher] [nvarchar](50) NULL," & vbCrLf &
                                  "[VoucherType] [nvarchar](50) NULL," & vbCrLf &
                                  "[Supplier] [nvarchar](50) NULL," & vbCrLf &
                                  "[GoldKarat] [nvarchar](50) NULL," & vbCrLf &
                                  "[PurKarat] [nvarchar](50) NULL," & vbCrLf &
                                  "[GoldWeight] [decimal](18, 3) NULL," & vbCrLf &
                                  "[PurWeight] [decimal](18, 3) NULL," & vbCrLf &
                                  "[GramPrice] [decimal](18, 3) NULL," & vbCrLf &
                                  "[GoldPrice] [decimal](18, 3) NULL," & vbCrLf &
                                  "[MakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                  "[TotalMakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                  "[TotalPrice] [decimal](18, 3) NULL," & vbCrLf &
                                  "[Qunt] [nvarchar](50) NULL," & vbCrLf &
                                  "[WeightArletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[WeightEnletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[TotalPriceArletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[TotalPriceEnletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[PurWeightArletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[PurWeightEnletters] [nvarchar](250) NULL," & vbCrLf &
                                  "[CreationDate] [date] NULL," & vbCrLf &
                                  "[LastEditDate] [date] NULL," & vbCrLf &
                                  "[Time] [nvarchar](50) NULL," & vbCrLf &
                                  "[Note] [nvarchar](500) NULL," & vbCrLf &
                                  "[Activite] [int] NULL," & vbCrLf &
                                  "CONSTRAINT [PK_GoldVoucher] PRIMARY KEY CLUSTERED([GoldVoucherID] ASC )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message

        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [WeightArletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [WeightEnletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [TotalPriceArletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [TotalPriceEnletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [PurWeightArletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            GlCommand.CommandText = "ALTER TABLE [TPGoldVoucher] ALTER COLUMN [PurWeightEnletters] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwGoldVoucher]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ViwGoldVoucher]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwGoldVoucher] AS SELECT dbo.TPGoldVoucher.GoldVoucherID, dbo.TPGoldVoucher.CivilID," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, " & vbCrLf &
                         "dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn," & vbCrLf &
                         "dbo.[user].user_name, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, " & vbCrLf &
                         "dbo.TPGoldVoucher.VoucherNumber, dbo.TPGoldVoucher.GoldKarat, dbo.TPGoldVoucher.PurKarat, dbo.TPGoldVoucher.GoldWeight," & vbCrLf &
                         "dbo.TPGoldVoucher.PurWeight, dbo.TPGoldVoucher.Qunt, dbo.TPGoldVoucher.CreationDate, " & vbCrLf &
                         "dbo.TPGoldVoucher.LastEditDate, dbo.TPGoldVoucher.Time, dbo.TPGoldVoucher.Note, dbo.TPGoldVoucher.Activite," & vbCrLf &
                         "dbo.TPGoldVoucher.MakeCharge, dbo.TPGoldVoucher.TotalMakeCharge, dbo.TPGoldVoucher.WeightArletters, " & vbCrLf &
                         "dbo.TPGoldVoucher.WeightEnletters, dbo.TPGoldVoucher.GramPrice, dbo.TPGoldVoucher.GoldPrice," & vbCrLf &
                         "dbo.TPGoldVoucher.TotalPrice, dbo.TPGoldVoucher.TotalPriceArletters, dbo.TPGoldVoucher.TotalPriceEnletters, " & vbCrLf &
                         "dbo.TBBondGoldType.BondTypeArName, dbo.TBBondGoldType.BondTypeEnName, dbo.TPGoldVoucher.PurWeightArletters," & vbCrLf &
                         "dbo.TPGoldVoucher.PurWeightEnletters, dbo.comp_inform.logo1, dbo.comp_inform.logo2, " & vbCrLf &
                         "dbo.comp_inform.comp_name AS ComPnameAsInvoce, dbo.comp_inform.comp_note1, dbo.viwCompanyNameAndBranches.CompanyName, dbo.viwCompanyNameAndBranches.BranchName" & vbCrLf &
                         "FROM dbo.TPGoldVoucher INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.TPGoldVoucher.CivilID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.[user] ON dbo.TPGoldVoucher.UserID = dbo.[user].user_id INNER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.TPGoldVoucher.Casher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                         "dbo.TBBondGoldType ON dbo.TPGoldVoucher.VoucherType = dbo.TBBondGoldType.BondGoldTypeID INNER JOIN" & vbCrLf &
                         "dbo.viwCompanyNameAndBranches ON dbo.TPGoldVoucher.Supplier = dbo.viwCompanyNameAndBranches.BranchID CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ''' اضافة الضريبه للذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'InvVatType') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [BAY] ADD [InvVatType] [decimal](18, 3)NULL DEFAULT 14 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'InvVat') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [BAY] ADD [InvVat] [decimal](18, 3)NULL  DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'ItemVatType') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [selInvoceDetels] ADD [ItemVatType] [decimal](18, 3)NULL  DEFAULT 14 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'ItemVat') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [selInvoceDetels] ADD [ItemVat] [decimal](18, 3)NULL  DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''' اضافة الضريبه للفضه
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'InvVatType') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverBAY] ADD [InvVatType] [decimal](18, 3)NULL DEFAULT 14 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('SilverBAY', 'InvVat') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverBAY] ADD [InvVat] [decimal](18, 3)NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SilverInvoceDetels', 'ItemVatType') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverInvoceDetels] ADD [ItemVatType] [decimal](18, 3)NULL DEFAULT 14 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('SilverInvoceDetels', 'ItemVat') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SilverInvoceDetels] ADD [ItemVat] [decimal](18, 3)NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ''''''''''جدول الضريبه
        Try
            GlCommand.CommandText = "If OBJECT_ID('[TPTax]') IS NULL  CREATE TABLE [dbo].[TPTax](" & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[TaxType] [decimal](18, 3) NULL," & vbCrLf &
                                    "[TaxActiv] [int] NULL," & vbCrLf &
                                    "CONSTRAINT [PK_TPTax] PRIMARY KEY CLUSTERED " & vbCrLf &
                                    "(" & vbCrLf &
                                    "[ID] ASC" & vbCrLf &
                                    ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]" & vbCrLf &
                                    ")ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Dim DataQunt As DataTable = GetRecordSet("Select * from TPTax")
        If DataQunt.Rows.Count = Nothing Then
            GlCommand.CommandText = "INSERT INTO [TPTax]([TaxType],[TaxActiv])VALUES(0,0)"
            GlCommand.ExecuteNonQuery()
        Else
        End If

        '''''''جدول اعدادات الباركود ذهب وفضه
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[BarcodeSet]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[BarcodeSet](" & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[CategoryType] [nchar](10) NULL," & vbCrLf &
                                    "[FiledName] [nvarchar](50) NULL," & vbCrLf &
                                    "[RightLeft] [nchar](10) NULL," & vbCrLf &
                                    "[BarcodFontName] [nvarchar](50) NULL," & vbCrLf &
                                    "[FontName] [nvarchar](50) NULL," & vbCrLf &
                                    "[TextFontSize] [nvarchar](50) NULL," & vbCrLf &
                                    "[TextFontShape] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtCompFont] [nvarchar](50) NULL," & vbCrLf &
                                    "[cmbCompFontTyp] [nvarchar](50) NULL," & vbCrLf &
                                    "[cmbCompFontShape] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtCountryFont] [nvarchar](50) NULL," & vbCrLf &
                                    "[cmbCountryFontTyp] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtBarCodeFont] [nvarchar](50) NULL," & vbCrLf &
                                    "[cmbBarCodeFontTyp] [nvarchar](50) NULL," & vbCrLf &
                                    "[CountryFontShape] [nvarchar](50) NULL," & vbCrLf &
                                    "[cmbPrinter] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtUpDoR] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtRtLfR] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtValuUpDoR] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtValuRtLfR] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtUpDoL] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtRtLfL] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtValuUpDoL] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtValuRtLfL] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtCode] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtCostPerItem] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtQty] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtStoneWeight] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtShoromName] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtShroomUpDo] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtShroomRtLf] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtLogoUpDo] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtLogoRtLf] [nvarchar](50) NULL," & vbCrLf &
                                    "[txtImge] [image] NULL," & vbCrLf &
                                    "[txtImgeSize] [nvarchar](50) NULL," & vbCrLf &
                                    "CONSTRAINT [PK_BarcodeSet] PRIMARY KEY CLUSTERED ([ID] ASC)WITH (PAD_INDEX  = OFF," & vbCrLf &
                                    "STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)" & vbCrLf &
                                    "ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        '''''''بيانات  اعدادات الباركود ذهب وفضه


        ''''''''''''''''''''''''''''''''اضافة حقل نوع المعدن في الالماس
        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'MetalType') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [MetalType] [int] NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE DIMON_detels SET MetalType=0 WHERE MetalType IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('EXTR_NAME', 'Activ') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [EXTR_NAME] ADD [Activ] [int] NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE EXTR_NAME SET Activ=1 WHERE Activ IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        '''''''جدول بيانات العمله والدوله
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[CurrencyType]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[CurrencyType](" & vbCrLf &
                                    "[CurrencyID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[CurrencyCountry] [nvarchar](50) NULL," & vbCrLf &
                                    "[CurrencyTypeMin] [nvarchar](50) NULL," & vbCrLf &
                                    "[CurrencyType] [nvarchar](50) NULL," & vbCrLf &
                                    "CONSTRAINT [PK_CurrencyType] PRIMARY KEY CLUSTERED([CurrencyID] ASC)WITH " & vbCrLf &
                                    "(PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Dim CurrencyTb As DataTable = GetRecordSet("SELECT * FROM CurrencyType")
        If CurrencyTb.Rows.Count <= 0 Then
            GlCommand.CommandText = "INSERT INTO [CurrencyType]([CurrencyCountry],[CurrencyTypeMin],[CurrencyType])VALUES(N'كويتي',N'دينار',N'فلس')"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "INSERT INTO [CurrencyType]([CurrencyCountry],[CurrencyTypeMin],[CurrencyType])VALUES(N'Kuwaiti',N'Dinar',N' Fils')"
            GlCommand.ExecuteNonQuery()
        End If
        '''''''''''''''''''''''''''''''''''''''

        '''''''جدول بيانات الدفع الخاص  بالفضه

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[SilverBAY]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [SilverBAY](" & vbCrLf &
                                    "[BAY_ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[BAY_SARYAL] [nvarchar](500) NOT NULL," & vbCrLf &
                                    "[TOTAL_mony] [decimal](18, 3) NOT NULL," & vbCrLf &
                                    "[KENT] [decimal](18, 3) NULL," & vbCrLf &
                                    "[CACH] [decimal](18, 3) NULL," & vbCrLf &
                                    "[arbic_tayb] [nvarchar](200) NULL," & vbCrLf &
                                    "[balance] [decimal](18, 3) NULL," & vbCrLf &
                                    "[staytes] [nvarchar](50) NULL," & vbCrLf &
                                    "[English_tayb] [nvarchar](200) NULL," & vbCrLf &
                                    "[Notes] [nvarchar](250) NULL," & vbCrLf &
                                    "[PayMethod] [nvarchar](50) NOT NULL," & vbCrLf &
                                    "[Active] [bit] NULL," & vbCrLf &
                                    "[PayMethod1] [nvarchar](50) NULL," & vbCrLf &
                                    "[PayMethod2] [nvarchar](50) NULL," & vbCrLf &
                                    "[PayMethod3] [nvarchar](50) NULL," & vbCrLf &
                                    "[PayMethod4] [nvarchar](50) NULL," & vbCrLf &
                                    "[Bank1] [decimal](18, 3) NULL," & vbCrLf &
                                    "[Bank2] [decimal](18, 3) NULL," & vbCrLf &
                                    "[Bank3] [decimal](18, 3) NULL," & vbCrLf &
                                    "[Bank4] [decimal](18, 3) NULL," & vbCrLf &
                                    "CONSTRAINT [PK_SilverBAY] PRIMARY KEY CLUSTERED ([BAY_ID] ASC)WITH (PAD_INDEX" & vbCrLf &
                                    "= OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS" & vbCrLf &
                                    "= ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        ''''''''جدول فواتير  الذهب
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[SilverInvoceDetels]') IS NULL " & vbCrLf &
                                                "CREATE TABLE [SilverInvoceDetels](" & vbCrLf &
                                                "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                                "[Castomerid] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[itemID] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[userID] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[item_name] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[item_desp] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[item_GramPrice] [decimal](18, 3) NOT NULL," & vbCrLf &
                                                "[item_gram] [decimal](18, 3) NOT NULL," & vbCrLf &
                                                "[item_gramMade] [decimal](18, 3) NOT NULL," & vbCrLf &
                                                "[item_extrasPRICE] [decimal](18, 3) NULL," & vbCrLf &
                                                "[item_extrasMAZAN] [decimal](18, 3) NULL," & vbCrLf &
                                                "[item_totalPrice] [decimal](18, 3) NOT NULL," & vbCrLf &
                                                "[item_cantrey] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[K_net] [decimal](18, 3) NULL," & vbCrLf &
                                                "[cacher] [nvarchar](50) NOT NULL," & vbCrLf &
                                                "[date] [date] NOT NULL," & vbCrLf &
                                                "[invoc_date_time] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[Cash] [nvarchar](255) NOT NULL," & vbCrLf &
                                                "[qunt] [int] NULL," & vbCrLf &
                                                "[nots] [nvarchar](1000) NULL," & vbCrLf &
                                                "[sroom_name] [nvarchar](250) NULL," & vbCrLf &
                                                "[invoc_time] [nvarchar](500) NOT NULL," & vbCrLf &
                                                "[Active] [int] NULL," & vbCrLf &
                                                "[StoneName1] [nvarchar](50) NULL," & vbCrLf &
                                                "[StoneColor1] [nvarchar](50) NULL," & vbCrLf &
                                                "[StonePriceType1] [int] NULL," & vbCrLf &
                                                "[StoneWeight2] [decimal](18, 3) NULL," & vbCrLf &
                                                "[StoneName2] [nvarchar](50) NULL," & vbCrLf &
                                                "[StoneColor2] [nvarchar](50) NULL," & vbCrLf &
                                                "[StonePrice2] [decimal](18, 3) NULL," & vbCrLf &
                                                "[StonePriceType2] [int] NULL," & vbCrLf &
                                                "[StoneWeight3] [decimal](18, 3) NULL," & vbCrLf &
                                                "[StoneName3] [nvarchar](50) NULL," & vbCrLf &
                                                "[StoneColor3] [nvarchar](50) NULL," & vbCrLf &
                                                "[StonePrice3] [decimal](18, 3) NULL," & vbCrLf &
                                                "[StonePriceType3] [int] NULL," & vbCrLf &
                                                "[GoledKarat] [nvarchar](50) NULL," & vbCrLf &
                                                "[MetalPrice] [decimal](18, 3) NULL," & vbCrLf &
                                                "CONSTRAINT [PK_SilverInvoceDetels] " & vbCrLf &
                                                "PRIMARY KEY NONCLUSTERED([ID] ASC )WITH (PAD_INDEX" & vbCrLf &
                                                "= OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY " & vbCrLf &
                                                "= OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) " & vbCrLf &
                                                "ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try          '''''''''''جدول اصناف الفضه
            GlCommand.CommandText = "IF OBJECT_ID('[SilverItem]') IS NULL " & vbCrLf &
                                      "CREATE TABLE [SilverItem](" & vbCrLf &
                                     "[ID] [int] IDENTITY(100,1) NOT NULL," & vbCrLf &
                                     "[userID] [nvarchar](max) NOT NULL," & vbCrLf &
                                     "[FO_name] [nvarchar](max) NOT NULL," & vbCrLf &
                                     "[FO_desp] [decimal](18, 3) NOT NULL," & vbCrLf &
                                     "[FO_price] [nvarchar](50) NULL," & vbCrLf &
                                     "[FO_GramPrice] [nvarchar](50) NULL," & vbCrLf &
                                     "[FO_gram] [decimal](18, 3) NOT NULL," & vbCrLf &
                                     "[FO_gramMade] [decimal](18, 3) NOT NULL," & vbCrLf &
                                     "[FO_made] [nvarchar](255) NOT NULL," & vbCrLf &
                                     "[FO_extras] [decimal](18, 3) NOT NULL," & vbCrLf &
                                     "[FO_totalPrice] [decimal](18, 3) NOT NULL," & vbCrLf &
                                     "[Gram_valu] [nvarchar](255) NOT NULL," & vbCrLf &
                                     "[ITEM_IMGE] [image] NULL," & vbCrLf &
                                     "[date_care] [date] NULL," & vbCrLf &
                                     "[FO_ItemNo] [nvarchar](50) NULL," & vbCrLf &
                                     "[Item_Actv] [int] NULL," & vbCrLf &
                                     "[StoneColor1] [nvarchar](50) NULL," & vbCrLf &
                                     "[StonePrice1] [decimal](18, 3) NULL," & vbCrLf &
                                     "[StoneWeight2] [decimal](18, 3) NULL," & vbCrLf &
                                     "[StoneName2] [nvarchar](50) NULL," & vbCrLf &
                                     "[StoneColor2] [nvarchar](50) NULL," & vbCrLf &
                                     "[StonePrice2] [decimal](18, 3) NULL," & vbCrLf &
                                     "[StoneWeight3] [decimal](18, 3) NULL," & vbCrLf &
                                     "[StoneName3] [nvarchar](50) NULL," & vbCrLf &
                                     "[StoneColor3] [nvarchar](50) NULL," & vbCrLf &
                                     "[StonePrice3] [decimal](18, 3) NULL," & vbCrLf &
                                     "[Qty] [int] NULL," & vbCrLf &
                                     "[BarCode] [nvarchar](50) NULL," & vbCrLf &
                                     "[LastEditDate] [datetime] NULL," & vbCrLf &
                                     "[ItemNote] [nvarchar](1000) NULL," & vbCrLf &
                                     "[PurInvNumber] [nvarchar](250) NULL," & vbCrLf &
                                     "[MultiItem] [int] NOT NULL," & vbCrLf &
                                     "[GoldCaret999] [nvarchar](255) NOT NULL," & vbCrLf &
                                     "[GoldWeight999] [decimal](18, 3) NULL," & vbCrLf &
                                     "CONSTRAINT [PK_SilverItem] PRIMARY KEY CLUSTERED ([ID] ASC)WITH (PAD_INDEX  = " & vbCrLf &
                                     "OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = " & vbCrLf &
                                     "ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwSilverInvoceReport]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [ViwSilverInvoceReport]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwSilverInvoceReport] AS SELECT dbo.SilverInvoceDetels.item_name, dbo.SilverInvoceDetels.Castomerid, dbo.SilverInvoceDetels.itemID, dbo.SilverInvoceDetels.item_GramPrice," & vbCrLf &
                         "dbo.SilverInvoceDetels.item_gram, dbo.SilverInvoceDetels.item_gramMade, " & vbCrLf &
                         "dbo.SilverInvoceDetels.item_extrasPRICE, dbo.SilverInvoceDetels.item_extrasMAZAN, dbo.SilverInvoceDetels.item_totalPrice, dbo.SilverInvoceDetels.item_cantrey, dbo.SilverInvoceDetels.MetalPrice, " & vbCrLf &
                         "dbo.SilverInvoceDetels.userID, dbo.SilverBAY.TOTAL_mony, dbo.SilverBAY.KENT, dbo.SilverBAY.CACH, dbo.SilverBAY.arbic_tayb, dbo.SilverBAY.balance, dbo.CastomerDETELS.CastomerNAme, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.SilverBAY.staytes, dbo.CastomerDETELS.foto, dbo.SilverInvoceDetels.invoc_date_time, " & vbCrLf &
                         "dbo.SilverInvoceDetels.qunt, dbo.SilverInvoceDetels.nots, dbo.cacher.cacher_name, dbo.SilverInvoceDetels.date, dbo.SilverBAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, " & vbCrLf &
                         "dbo.SilverInvoceDetels.item_gramMade * dbo.SilverInvoceDetels.item_gram AS Total_gramMade, dbo.SilverBAY.English_tayb, dbo.SilverInvoceDetels.Active, dbo.SilverBAY.Notes, dbo.SilverBAY.PayMethod, " & vbCrLf &
                         "dbo.cacher.CashierSignature, dbo.SilverInvoceDetels.StoneWeight2, dbo.SilverInvoceDetels.StoneWeight3, dbo.SilverInvoceDetels.StonePrice2, dbo.SilverInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, " & vbCrLf &
                         "dbo.PayMethod.PayMethodEn, dbo.SilverInvoceDetels.item_desp, dbo.SilverInvoceDetels.cacher, dbo.SilverInvoceDetels.Cash, dbo.SilverInvoceDetels.sroom_name, dbo.SilverInvoceDetels.invoc_time, " & vbCrLf &
                         "dbo.SilverInvoceDetels.StoneName1, dbo.SilverInvoceDetels.StoneColor1, dbo.SilverInvoceDetels.StoneName2, dbo.SilverInvoceDetels.StoneColor2, dbo.SilverInvoceDetels.StoneName3, dbo.SilverInvoceDetels.StoneColor3, " & vbCrLf &
                         "dbo.SilverInvoceDetels.ID, dbo.SilverInvoceDetels.StonePriceType1, dbo.SilverInvoceDetels.StonePriceType2, dbo.SilverInvoceDetels.StonePriceType3, dbo.SilverInvoceDetels.GoledKarat, dbo.CastomerDETELS.fotoBack, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEn, PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.SilverBAY.PayMethod1, PayMethod_2.PayMethodAr AS PayMethodAr2, " & vbCrLf &
                         "PayMethod_2.PayMethodEn AS PayMethodEn2, dbo.SilverBAY.PayMethod2, PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, dbo.SilverBAY.PayMethod3, " & vbCrLf &
                         "PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, dbo.SilverBAY.PayMethod4, dbo.SilverBAY.Bank1, dbo.SilverBAY.Bank2, dbo.SilverBAY.Bank3, dbo.SilverBAY.Bank4, " & vbCrLf &
                         "dbo.SilverBAY.Active AS SilverBAYActive, dbo.SilverBAY.BAY_ID, dbo.SilverInvoceDetels.ItemVatType, dbo.SilverInvoceDetels.ItemVat, dbo.SilverBAY.InvVatType, dbo.SilverBAY.InvVat, dbo.comp_inform.logo1, " & vbCrLf &
                         "dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, dbo.SilverBAY.PurchaseInvNumber, dbo.SilverBAY.PaymentReceipt, dbo.SilverBAY.PaymentTransNumber, dbo.SilverBAY.PurchaseGold, " & vbCrLf &
                         "dbo.SilverItem.FO_GramPrice AS Supplier, dbo.SilverItem.FO_desp AS Cost, dbo.SilverItem.FO_gram AS EnteredWeight, dbo.SilverInvoceDetels.item_gramMade - dbo.SilverItem.FO_desp AS GramProfit, " & vbCrLf &
                         "(dbo.SilverInvoceDetels.item_gramMade - dbo.SilverItem.FO_desp) * dbo.SilverItem.FO_gram AS TotalGramProfit, dbo.SilverInvoceDetels.item_gramMade * dbo.SilverItem.FO_gram AS TotalMake, " & vbCrLf &
                         "dbo.SilverItem.FO_desp * dbo.SilverItem.FO_gram AS TotalCost, dbo.SilverInvoceDetels.item_gram AS SellWeight, dbo.SilverInvoceDetels.item_gramMade AS MakingCharge, dbo.CastomerDETELS.CastomerCAIVELidKYC, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNAmeKYC, dbo.CastomerDETELS.CastomerADrKYC, dbo.CastomerDETELS.CastomerTEKYC, dbo.CastomerDETELS.CastomerNAKYC, dbo.CastomerDETELS.CastomerNameEnKYC, " & vbCrLf &
                         "dbo.SilverItem.Gram_valu, dbo.SilverItem.ITEM_IMGE, dbo.SilverItem.BarCode, dbo.SilverItem.GoldCaret999, dbo.SilverItem.GoldWeight999, dbo.SilverItem.BarCodeNote" & vbCrLf &
                         "FROM dbo.SilverBAY INNER JOIN" & vbCrLf &
                         "dbo.SilverInvoceDetels ON dbo.SilverBAY.BAY_SARYAL = dbo.SilverInvoceDetels.invoc_time INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.SilverInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.SilverInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.SilverBAY.PayMethod = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.SilverBAY.PayMethod1 = PayMethod_1.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.SilverBAY.PayMethod2 = PayMethod_2.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.SilverBAY.PayMethod3 = PayMethod_3.ID INNER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.SilverBAY.PayMethod4 = PayMethod_4.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.SilverItem ON dbo.SilverInvoceDetels.itemID = dbo.SilverItem.BarCode CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform CROSS JOIN" & vbCrLf &
                         "dbo.Settings WHERE (dbo.SilverBAY.Active = 1) AND (dbo.SilverInvoceDetels.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'اضافة تاريخ التعديل في جدول الاصناف ذهب وفضه
        'Try

        Try
            GlCommand.CommandText = "If COL_LENGTH('Fo_min', 'LastEditDate') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Fo_min] ADD [LastEditDate] [datetime] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('Fo_min', 'ItemNote') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [Fo_min] ADD [ItemNote] nvarchar(1000) NULL " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Fo_min', 'PurInvNumber') IS NULL " & vbCrLf &
                                 "BEGIN " & vbCrLf &
                                 "ALTER TABLE [Fo_min] ADD [PurInvNumber] nvarchar(250) NULL " & vbCrLf &
                                 "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Fo_min', 'MultiItem') IS NULL " & vbCrLf &
                                 "BEGIN " & vbCrLf &
                                 "ALTER TABLE [Fo_min] ADD [MultiItem] [int] NOT NULL DEFAULT 0 WITH VALUES " & vbCrLf &
                                 "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل العيار الصافي الي جدول الاصناف ذهب  / فضه  

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Fo_min', 'GoldCaret999') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Fo_min] ADD [GoldCaret999] nvarchar(255)NOT NULL DEFAULT 999 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل الوزن الصافي الي فاتورة الشراء ذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Fo_min', 'GoldWeight999') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Fo_min] ADD [GoldWeight999] [decimal](18, 3)NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            'عيار 21
            GlCommand.CommandText = " UPDATE [FO_min] SET [GoldWeight999]= (0.875) * [FO_gram]   where  [GoldWeight999] IS NULL AND [Gram_valu]=21"
            GlCommand.ExecuteNonQuery()

            'عيار 22
            GlCommand.CommandText = " UPDATE [FO_min] SET [GoldWeight999]= (0.915) * [FO_gram]   where  [GoldWeight999] IS NULL AND [Gram_valu]=22"
            GlCommand.ExecuteNonQuery()


            'عيار 18
            GlCommand.CommandText = " UPDATE [FO_min] SET [GoldWeight999]= (0.750) * [FO_gram]   where  [GoldWeight999] IS NULL AND [Gram_valu]=18"
            GlCommand.ExecuteNonQuery()

            'عيار 24
            GlCommand.CommandText = " UPDATE [FO_min] SET [GoldWeight999]= (1) * [FO_gram]   where  [GoldWeight999] IS NULL AND [Gram_valu]=24"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'جدول رسايل الوتساب
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPWhatsAppMessages]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[TPWhatsAppMessages](" & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[TextMessages] [nvarchar](1000) NULL," & vbCrLf &
                                    "[FillPath] [nvarchar](250) NULL," & vbCrLf &
                                    "[DateCreated] [date] NULL," & vbCrLf &
                                    "CONSTRAINT [PK_TPWhatsAppMessages] PRIMARY KEY CLUSTERED " & vbCrLf &
                                    "([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
            'RecordRrrors(ex.ToString)
        End Try

        'تعديل الجرامات الي العيارات العشريه
        Try
            GlCommand.CommandText = "UPDATE [Gram_val] SET [FractionValues] = '999' WHERE Gram_valu='24'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Gram_val] SET [FractionValues] = '875' WHERE Gram_valu='21'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Gram_val] SET [FractionValues] = '915' WHERE Gram_valu='22'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Gram_val] SET [FractionValues] = '750' WHERE Gram_valu='18'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "DELETE FROM [Gram_val] WHERE Gram_valu IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [selInvoceDetels] ALTER COLUMN [nots] nvarchar(1000) NULL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'تعديل فاتورت الساعات والماركات
        Try
            GlCommand.CommandText = "ALTER TABLE [Accessories_INV] ALTER COLUMN [Accessories_INV_USER] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [Accessories_INV] ALTER COLUMN [Accessories_INV_TIME] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'ItemNo') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [ItemNo] nvarchar(255)  NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'IMG') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [IMG] [image] NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'ItemName') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [ItemName] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Code') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Code] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Supplier') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Supplier] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Department') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Department] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Category') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Category] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Attachment') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Attachment] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Cost') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Cost] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Cashier') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Cashier] [nvarchar](255) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'AccessoriesInvoceDESC') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [AccessoriesInvoceDESC] [nvarchar](700) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'AccessoriesBrand_ID') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [AccessoriesBrand_ID] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'AccessoriesGUARRANTYYEAR') IS NULL " & vbCrLf &
                                             "BEGIN " & vbCrLf &
                                             "ALTER TABLE [Accessories_INV] ADD [AccessoriesGUARRANTYYEAR] [nvarchar](50) NULL" & vbCrLf &
                                             "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'AccessoriesType_ID') IS NULL " & vbCrLf &
                                            "BEGIN " & vbCrLf &
                                            "ALTER TABLE [Accessories_INV] ADD [AccessoriesType_ID] [nvarchar](50) NULL" & vbCrLf &
                                            "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'ModelNo') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [ModelNo]  [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_INV', 'Note') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [Accessories_INV] ADD [Note]  [nvarchar](250) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'تعديل جدول الفاتوره اضافة العيار ذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'GoledKarat') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [selInvoceDetels] ADD [GoledKarat] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ViwAccReport]') IS NOT NULL " &
                                    "DROP VIEW [ViwAccReport] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwAccReport] AS SELECT dbo.Accessories_INV.Accessories_INV_CASTOMER_ID, " & vbCrLf &
                                    "dbo.Accessories_INV.Accessories_INV_ID, dbo.Accessories_INV.Accessories_INV_ITEM_ID, dbo.Accessories_INV.Accessories_INV_QUNT, " & vbCrLf &
                                    "dbo.Accessories_INV.Accessories_INV_un_price, dbo.Accessories_INV.Accessories_INV_total_price, dbo.Accessories_INV.Accessories_INV_DATE, dbo.Accessories_INV.Accessories_INV_TIME, " & vbCrLf &
                                    "dbo.Accessories_INV.Accessories_INV_USER, dbo.Accessories_INV.Accessories_INV_NO_ID, dbo.Accessories_INV.Accessories_Active, dbo.Accessories_INV.AccessoriesInvoceDESC, " & vbCrLf &
                                    "dbo.Accessories_INV.AccessoriesBrand_ID, dbo.Accessories_INV.AccessoriesGUARRANTYYEAR, dbo.Accessories_INV.AccessoriesType_ID, dbo.Accessories_INV.ItemName, " & vbCrLf &
                                    "dbo.Accessories_INV.Code, dbo.Accessories_INV.Supplier, dbo.Accessories_INV.Department, dbo.Accessories_INV.Category, dbo.Accessories_INV.Attachment, dbo.Accessories_INV.Cost, " & vbCrLf &
                                    "dbo.Accessories_INV.Cashier, dbo.Accessories_INV.IMG, dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.Accessories_BAY.Accessories_TOTAL_mony, dbo.Accessories_BAY.Accessories_KENT," & vbCrLf &
                                    "dbo.Accessories_BAY.Accessories_CACH, dbo.Accessories_BAY.Accessories_arbic_tayb, dbo.Accessories_BAY.Accessories_balance, dbo.Accessories_BAY.Accessories_staytes, " & vbCrLf &
                                    "dbo.Accessories_BAY.Accessories_Casher, dbo.Accessories_BAY.Accessories_PaymentType, dbo.Accessories_BAY.Accessories_Active AS AccessoriesInvActive, dbo.Accessories_BAY.Accessories_Notes, " & vbCrLf &
                                    "dbo.Accessories_BAY.Accessories_PayMethod, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, " & vbCrLf &
                                    "dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.PayMethod.PayMethodAr, " & vbCrLf &
                                    "dbo.PayMethod.PayMethodEn , dbo.Accessories_INV.ModelNo,dbo.Accessories_INV.Note, dbo.Accessories_INV.ItemNo " & vbCrLf &
                                    "FROM  dbo.Accessories_INV INNER JOIN" & vbCrLf &
                                    "dbo.Accessories_BAY ON dbo.Accessories_INV.Accessories_INV_NO_ID = dbo.Accessories_BAY.Accessories_BAY_SARYAL INNER JOIN" & vbCrLf &
                                    "dbo.CastomerDETELS ON dbo.Accessories_INV.Accessories_INV_CASTOMER_ID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                                    "dbo.PayMethod ON dbo.Accessories_BAY.Accessories_PayMethod = dbo.PayMethod.ID"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        '''''''''''''''''''''''''''''''''''تعديل جدول سندات الصرف القبض اضافة الدفع المتعدد
        ''تعديل جول الدفع ذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'PayMethod1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [PayMethod1] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'PayMethod2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [PayMethod2] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'PayMethod3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [PayMethod3] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'PayMethod4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [PayMethod4] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Bank1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [Bank1] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Bank2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [Bank2] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Bank3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [Bank3] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Bank4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [Bank4] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [PayMethod1] = '1' WHERE [PayMethod1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [PayMethod2] = '1' WHERE [PayMethod2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [PayMethod3] = '1' WHERE [PayMethod3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [PayMethod4] = '1' WHERE [PayMethod4] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [Bank1] = '0' WHERE [Bank1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [Bank2] = '0' WHERE [Bank2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [Bank3] = '0' WHERE [Bank3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [SndToCustomer] SET [Bank4] = '0' WHERE [Bank4] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try

            Dim PayMethodSet As DataTable = GetRecordSet(" select * from [Settings]")
            If PayMethodSet.Rows.Count > 0 Then
                If (IsDBNull(PayMethodSet.Rows(0)("SET5"))) Then
                    GlCommand.CommandText = ("UPDATE [Settings] SET [SET5] = '0'")
                    GlCommand.ExecuteNonQuery()
                End If
                If (IsDBNull(PayMethodSet.Rows(0)("SET6"))) Then
                    GlCommand.CommandText = ("UPDATE [Settings] SET [SET6] = '1'")
                    GlCommand.ExecuteNonQuery()
                End If
                If (IsDBNull(PayMethodSet.Rows(0)("SET7"))) Then
                    GlCommand.CommandText = ("UPDATE [Settings] SET [SET7] = '2'")
                    GlCommand.ExecuteNonQuery()
                End If
                If (IsDBNull(PayMethodSet.Rows(0)("SET8"))) Then
                    GlCommand.CommandText = ("UPDATE [Settings] SET [SET8] = '3'")
                    GlCommand.ExecuteNonQuery()
                End If
                If (IsDBNull(PayMethodSet.Rows(0)("SET9"))) Then
                    GlCommand.CommandText = ("UPDATE [Settings] SET [SET9] = '0'")
                    GlCommand.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        ''تعديل جول الدفع ذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PayMethod1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [PayMethod1] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PayMethod2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [PayMethod2] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PayMethod3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [PayMethod3] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'PayMethod4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [PayMethod4] [nvarchar](50) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'Bank1') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [Bank1] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'Bank2') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [Bank2] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'Bank3') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [Bank3] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('BAY', 'Bank4') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [BAY] ADD [Bank4] decimal(18, 3) NULL" & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod1] = '1' WHERE [PayMethod1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod2] = '1' WHERE [PayMethod2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod3] = '1' WHERE [PayMethod3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod4] = '1' WHERE [PayMethod4] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [Bank1] = '0' WHERE [Bank1] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [Bank2] = '0' WHERE [Bank2] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [Bank3] = '0' WHERE [Bank3] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [Bank4] = '0' WHERE [Bank4] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'Try
        GlCommand.CommandText = "IF OBJECT_ID('[TBBondType]') IS NULL " & vbCrLf &
                                      "CREATE TABLE [dbo].[TBBondType]( " & vbCrLf &
                                      "[BondTypeID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                      "[BondTypeArName] [nvarchar](50) NULL," & vbCrLf &
                                      "[BondTypeEnName] [nvarchar](50) NULL," & vbCrLf &
                                      "[BondTypeActiv] [int] NULL," & vbCrLf &
                                      "CONSTRAINT [PK_TBBondType] PRIMARY KEY CLUSTERED " & vbCrLf &
                                      "([BondTypeID] ASC) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  =" & vbCrLf &
                                      "OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
        GlCommand.ExecuteNonQuery()
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('TBBondType', 'BondType') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [TBBondType] ADD [BondType] [int] NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            Dim DTBondType As DataTable = GetRecordSet("select * from TBBondType")
            If DTBondType.Rows.Count = Nothing Then
                GlCommand.CommandText = "INSERT INTO [TBBondType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند قبض نقدي','Cash receipt voucher','1','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند صرف نقدي','Cash Payment voucher','1','0')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند صرف شيك','Cheque Payment voucher','1','0')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [TBBondType]([BondTypeArName],[BondTypeEnName],[BondTypeActiv],[BondType])VALUES(N'سند قبض شيك','Cheque receipt voucher ','1','1')"
                GlCommand.ExecuteNonQuery()
            End If

            GlCommand.CommandText = "UPDATE [TBBondType] SET  BondType=1 WHERE [BondTypeArName]LIKE N'سند قبض نقدي'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondType] SET  BondType=0 WHERE [BondTypeArName]LIKE N'سند صرف نقدي'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondType] SET  BondType=1 WHERE [BondTypeArName]LIKE N'سند صرف شيك '"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [TBBondType] SET  BondType=0 WHERE [BondTypeArName]LIKE N'سند قبض شيك'"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'MetalPrice') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [selInvoceDetels] ADD [MetalPrice]  decimal(18, 3) NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Supplier') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [DIMON_detels] ADD [Supplier]  nvarchar(50) NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'ItemNote') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [DIMON_detels] ADD [ItemNote]  nvarchar(255) NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Expenses', 'PayMethod') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Expenses] ADD [PayMethod] [int] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Expenses','Cacher') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [Expenses] ADD [Cacher] nvarchar(50) NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Expenses','Active') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "ALTER TABLE [Expenses] ADD [Active] [int] NULL " & vbCrLf &
                                   "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Expenses','CashVoucherNo') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [Expenses] ADD [CashVoucherNo] nvarchar(MAX) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
            'ExpensesInvID
            GlCommand.CommandText = "IF COL_LENGTH('Expenses','ExpensesInvID') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [Expenses] ADD [ExpensesInvID] nvarchar(200) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
            'ExpensesDate
            GlCommand.CommandText = "IF COL_LENGTH('Expenses','ExpensesDateTime') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [Expenses] ADD [ExpensesDateTime] nvarchar(255) " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Expenses]SET [Active]='1' WHERE [Active] is null"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportExpensesAllData]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ReportExpensesAllData]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportExpensesAllData] AS SELECT dbo.Expenses.ExpensesID, " & vbCrLf &
                      "dbo.Expenses.ExpensesType, dbo.Expenses.ExpensesDate, dbo.Expenses.ExpensesUserID, " & vbCrLf &
                      "dbo.Expenses.ExpensesCashValue, dbo.Expenses.ExpensesKNETValue, " & vbCrLf &
                      "dbo.Expenses.ExpensesPhoto, dbo.Expenses.ExpensesDescription, dbo.Expenses.PayMethod, " & vbCrLf &
                      "dbo.Expenses.Active, dbo.Expenses.CashVoucherNo, dbo.Expenses.ExpensesInvID, " & vbCrLf &
                      "dbo.Expenses.ExpensesDateTime, dbo.Expenses.Cacher, dbo.[user].user_name, " & vbCrLf &
                      "dbo.cacher.cacher_name, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, " & vbCrLf &
                      "dbo.Expenses.ExpensesCashValue + dbo.Expenses.ExpensesKNETValue AS ExpensesTotalValue " & vbCrLf &
                      "FROM dbo.Expenses LEFT OUTER JOIN " & vbCrLf &
                      "dbo.[user] ON dbo.Expenses.ExpensesUserID = dbo.[user].user_id LEFT OUTER JOIN " & vbCrLf &
                      "dbo.PayMethod ON dbo.Expenses.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN " & vbCrLf &
                      "dbo.cacher ON dbo.Expenses.Cacher = dbo.cacher.svil_id " & vbCrLf &
                      "WHERE (dbo.Expenses.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('send_mony', 'Active') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [send_mony] ADD [Active] [int] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [send_mony]SET [Active]='1' WHERE [Active] is null"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        ''''''''''انشاء جدول حفظ معلومات الدخول'''''''''''''''''''''''''''''''''''''''
        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'CertificateNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [CertificateNumber] NVARCHAR (200)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[LICENSE_T]') IS NULL " & vbCrLf &
                                      "CREATE TABLE [dbo].[LICENSE_T](" & vbCrLf &
                                     "[LICENSE_ID] [nvarchar](50) NULL," & vbCrLf &
                                      "[LICENSE_SHOP_NAME] [nvarchar](250) NULL," & vbCrLf &
                                      "[LICENSE_START_DATAE][nvarchar](250) NULL," & vbCrLf &
                                      "[LICENSE_END_DATAE] [nvarchar](250) NULL," & vbCrLf &
                                      "[status] [nvarchar](250) NULL," & vbCrLf &
                                      "[LICENSEContact_Code] [nvarchar](250) NULL," & vbCrLf &
                                      "[PriceLinek] [nvarchar](250) NULL," & vbCrLf &
                                      "[PriceCurrency] [nvarchar](250) NULL," & vbCrLf &
                                      "[CivilIDactivation] [nvarchar](250) NULL," & vbCrLf &
                                      "[GoledPriveActivation] [nvarchar](250) NULL," & vbCrLf &
                                      "[WhatsApp_API_LINK] [nvarchar](250) NULL," & vbCrLf &
                                      "[Pay_API_LINK] [nvarchar](250) NULL," & vbCrLf &
                                      "[Pay_API_Trader_ID] [nvarchar](250) NULL," & vbCrLf &
                                      "[Pay_API_Activ] [nvarchar](250) NULL," & vbCrLf &
                                      "[LastUpdated] [nvarchar](250) NULL," & vbCrLf &
                                      "[Opencount] [nvarchar](250) NULL" & vbCrLf &
                                         ") ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ADS_SERVICES]') IS NULL " & vbCrLf &
                                      "CREATE TABLE [dbo].[ADS_SERVICES]([ID] [int] NULL, " & vbCrLf &
                                      "[IMGE1] [nvarchar](255) NULL, " & vbCrLf &
                                      "[IMGE2] [nvarchar](255) NULL, " & vbCrLf &
                                      "[IMGE3] [nvarchar](255) NULL, " & vbCrLf &
                                      "[IMGE4] [nvarchar](255) NULL, " & vbCrLf &
                                      "[IMGE5] [nvarchar](255) NULL, " & vbCrLf &
                                      "[IMGE6] [nvarchar](255) NULL, " & vbCrLf &
                                      "[TEXT_LINE] [text] NULL, " & vbCrLf &
                                      "[TEL] [nvarchar](400) NULL, " & vbCrLf &
                                      "[TEL2] [nvarchar](100) NULL, " & vbCrLf &
                                      "[Update_url] [nvarchar](250) NULL " & vbCrLf &
                                       ") ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPCompanylicenseID]') IS NULL " & vbCrLf &
                                    "CREATE TABLE[TPCompanylicenseID]( " & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL, " & vbCrLf &
                                    "[CompanylicenseID] [nvarchar](255) NULL, " & vbCrLf &
                                    "CONSTRAINT [PK_CompanylicenseID] PRIMARY KEY CLUSTERED " & vbCrLf &
                                    "([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  " & vbCrLf &
                                    "= OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [BAY] ALTER COLUMN [PayMethod] nvarchar(50) NOT NULL "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_116]=0 WHERE [test_116]= '' OR [test_116] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_16]=0 WHERE [test_16]= '' OR [test_16] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_13]=0 WHERE [test_13]= '' OR [test_116] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_19]=0 WHERE [test_19]= '' OR [test_19] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[for_print_dimon_finel_short]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [for_print_dimon_finel_short]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[for_print_dimon_finel_short] AS SELECT dbo.dimon_invce.castomr_id, " & vbCrLf &
                                    "dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, " & vbCrLf &
                                    "dbo.CastomerDETELS.CastomerNA, dbo.dimon_invce.descont, dbo.dimon_invce.total, " & vbCrLf &
                                    "dbo.dimon_invce.ar_taype, dbo.dimon_invce.DIMO_Type, dbo.dimon_invce.DIM_na9awa, " & vbCrLf &
                                    "dbo.dimon_invce.DIMO_mezan, dbo.dimon_invce.DIMO_coler, dbo.dimon_invce.DIMO_qult, " & vbCrLf &
                                    "dbo.dimon_invce.sarual, dbo.dimon_invce.val_gold, dbo.dimon_invce.GOLD_mezan, " & vbCrLf &
                                    "dbo.dimon_invce.user_creted, dbo.dimon_invce.date_creted, dbo.dimon_invce.time, dbo.cacher.cacher_name, " & vbCrLf &
                                    "dbo.dimon_bay.BAY_SARYAL, dbo.dimon_bay.TOTAL_mony, " & vbCrLf &
                                    "dbo.dimon_bay.CACH AS dimon_bay_cach, dbo.dimon_bay.KENT, dbo.dimon_bay.balance, dbo.dimon_bay.staytes, " & vbCrLf &
                                    "dbo.dimon_invce.dimo_id, dbo.DIMON_detels.test_12, dbo.cacher.svil_id, " & vbCrLf &
                                    "dbo.dimon_invce.notes, dbo.CastomerDETELS.CastomerTE, dbo.dimon_invce.test_13, dbo.dimon_invce.test_14, " & vbCrLf &
                                    "dbo.dimon_invce.test_15, dbo.dimon_invce.test_16, dbo.dimon_invce.test_17, " & vbCrLf &
                                    "dbo.dimon_invce.test_18, dbo.dimon_invce.test_19, dbo.dimon_invce.test_110, dbo.dimon_invce.test_111, " & vbCrLf &
                                    "dbo.dimon_invce.test_112, dbo.dimon_invce.test_116, " & vbCrLf &
                                    "dbo.dimon_invce.test_117, dbo.dimon_invce.test_118, dbo.dimon_invce.test_119, dbo.dimon_bay.arbic_tayb, " & vbCrLf &
                                    "dbo.dimon_bay.Item_Actv " & vbCrLf &
                                    "FROM dbo.dimon_invce INNER JOIN " & vbCrLf &
                                    "dbo.CastomerDETELS ON dbo.dimon_invce.castomr_id = " & vbCrLf &
                                    "dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN " & vbCrLf &
                                    "dbo.dimon_bay ON dbo.dimon_invce.descont = dbo.dimon_bay.BAY_SARYAL INNER JOIN " & vbCrLf &
                                    "dbo.DIMON_detels ON dbo.dimon_invce.dimo_id = dbo.DIMON_detels.test_119 LEFT OUTER JOIN " & vbCrLf &
                                    "dbo.cacher ON dbo.dimon_invce.test_118 = dbo.cacher.svil_id " & vbCrLf &
                                    "WHERE (dbo.dimon_invce.Item_Actv = 1) AND (dbo.dimon_bay.Item_Actv = 1) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [dbo].[Settings]  SET [SET4] = '0' WHERE [SET4] IS NULL OR [SET4]=''"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [val_gold] [nvarchar](50) NOT NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [test_116] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [test_16] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [test_13] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [test_19] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message : MsgBox(ex.ToString) : MsgBox(ex.ToString)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'LastEditDate') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [LastEditDate] [datetime] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'CreationDate') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [DIMON_detels] ADD [CreationDate][datetime] NULL " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkModifyInvoce') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkModifyInvoce] [bit] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [user] SET [chkModifyInvoce] ='True' WHERE [chkModifyInvoce] is null"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDiamondItemAll]') IS NOT NULL " &
                                    "DROP VIEW [ReportDiamondItemAll] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = " CREATE VIEW [dbo].[ReportDiamondItemAll] AS " & vbCrLf &
                         " SELECT DIMOND_ID, DIMO_dep, DIM_na9awa, DIMO_mezan, ext_coler, " & vbCrLf &
                         " qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, " & vbCrLf &
                         " test_13, test_14, test_15, test_16, test_17, test_18, test_19, test_110, " & vbCrLf &
                         " test_111, test_112, test_113, test_114, " & vbCrLf &
                         " test_115, test_116, test_117, test_118, " & vbCrLf &
                         " test_119, date_creted, ITEM_IMGE, Item_Actv, " & vbCrLf &
                        "  CostToSeller, TaxExempt, Documents, Cut1, Clarity1, Cut2, Clarity2, " & vbCrLf &
                         " Cut3, Clarity3, IsDiamond1, IsDiamond2, IsDiamond3 " & vbCrLf &
                         " FROM dbo.DIMON_detels " & vbCrLf &
                         " WHERE (Item_Actv = 1) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'DefaultBarcode') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Settings] ADD [DefaultBarcode] nvarchar (255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDiamondProfit]') IS NOT NULL " &
                                    "DROP VIEW [ReportDiamondProfit] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportDiamondProfit] AS SELECT     TOP (100) PERCENT DIMO_Type, DIMO_mezan, " & vbCrLf &
                                    "DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id AS sarual, test_119, cacher_name, " & vbCrLf &
                                    "test_117, test_118 " & vbCrLf &
                                    "FROM  dbo.finel_parfct_dimon " & vbCrLf &
                                    "GROUP BY DIMO_Type, DIMO_mezan, DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id, test_119, cacher_name, test_117, test_118 " & vbCrLf &
                                    "ORDER BY BAY_SARYAL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message

        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ITEM_Sold_Diamond]') IS NOT NULL " &
                                    "DROP VIEW [ITEM_Sold_Diamond] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText =
                                    "CREATE VIEW [dbo].[ITEM_Sold_Diamond] AS  " & vbCrLf &
                                    "SELECT  dbo.DIMON_detels.DIMOND_ID, dbo.DIMON_detels.DIMO_dep,   " & vbCrLf &
                                    "dbo.DIMON_detels.DIM_na9awa, dbo.DIMON_detels.DIMO_mezan,   " & vbCrLf &
                                    "dbo.DIMON_detels.ext_coler, dbo.DIMON_detels.qult,   " & vbCrLf &
                                    "dbo.DIMON_detels.sarual, dbo.DIMON_detels.val_gold,  " & vbCrLf &
                                    "dbo.DIMON_detels.GOLD_mezan, dbo.DIMON_detels.test_1,   " & vbCrLf &
                                   " dbo.DIMON_detels.test_11, dbo.DIMON_detels.test_12,   " & vbCrLf &
                                   "dbo.DIMON_detels.date_creted, dbo.DIMON_detels.test_119,   " & vbCrLf &
                                    "dbo.DIMON_detels.ITEM_IMGE, dbo.dimon_invce.Item_Actv  " & vbCrLf &
                                    "FROM  dbo.DIMON_detels INNER JOIN  " & vbCrLf &
                                    "dbo.dimon_invce ON dbo.DIMON_detels.test_119 = dbo.dimon_invce.dimo_id  " & vbCrLf &
                                   "WHERE (dbo.dimon_invce.Item_Actv = 1)"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message

        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [selInvoceDetels] ALTER COLUMN [ItemID] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Diamond', 'Active') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Diamond] ADD [Active] [int] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Bay_Diamond_mony', 'Active') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Bay_Diamond_mony] ADD [Active] [int] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('Bay_Diamond_mony', 'PayMethod') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Bay_Diamond_mony] ADD [PayMethod] [int] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TpSetGoledPriceDiff]') IS NULL " & vbCrLf &
                                    " CREATE TABLE [dbo].[TpSetGoledPriceDiff](" & vbCrLf &
                                   "	[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                   "	[TEX24BUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX22BUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX21BUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX18BUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX925BUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEXOnceBUY] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX24Sell] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX22Sell] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX21Sell] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX18Sell] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEX925Sell] [decimal](18, 3) NULL," & vbCrLf &
                                   "	[TEXOnceSell] [decimal](18, 3) NULL," & vbCrLf &
                                   "   CONSTRAINT [PK_TpSetGoledPriceDiff] PRIMARY KEY CLUSTERED " & vbCrLf &
                                   "  ([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('TpSetGoledPriceDiff', 'TEXOnceSellUsd') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [TpSetGoledPriceDiff] ADD [TEXOnceSellUsd] [decimal](18, 3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('TpSetGoledPriceDiff', 'TEXOnceBUYUsd') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [TpSetGoledPriceDiff] ADD [TEXOnceBUYUsd] [decimal](18, 3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            Dim TpSetGoledPriceDiff_MAX_ID As DataTable = GetRecordSet("SELECT * FROM [TpSetGoledPriceDiff]")
            If TpSetGoledPriceDiff_MAX_ID.Rows.Count = Nothing Then
                GlCommand.CommandText = " INSERT INTO [TpSetGoledPriceDiff] " & vbCrLf &
                                        "([TEX24BUY]," & vbCrLf &
                                        "[TEX22BUY]," & vbCrLf &
                                        "[TEX21BUY]," & vbCrLf &
                                        "[TEX18BUY]," & vbCrLf &
                                        "[TEX925BUY]," & vbCrLf &
                                        "[TEXOnceBUY]," & vbCrLf &
                                         "[TEX24Sell]," & vbCrLf &
                                         "[TEX22Sell]," & vbCrLf &
                                         "[TEX21Sell]," & vbCrLf &
                                         "[TEX18Sell]," & vbCrLf &
                                         "[TEX925Sell]," & vbCrLf &
                                         "[TEXOnceSell]," & vbCrLf &
                                         "[TEXOnceSellUsd]," & vbCrLf &
                                         "[TEXOnceBUYUsd]) " & vbCrLf &
                                          " VALUES('0','0','0','0','0','0','0','0','0','0','0','0','0','0')"
                GlCommand.ExecuteNonQuery()
            Else
            End If

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[SndGold]') IS NULL " & vbCrLf &
                                    "   CREATE TABLE [dbo].[SndGold]( " & vbCrLf &
                                    "       [Id] [int] IDENTITY(1,1) NOT NULL, " & vbCrLf &
                                    "   	[PayMID] [nvarchar](255) NULL, " & vbCrLf &
                                    "      [SndNumber] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [Amount] [decimal](18, 3) NULL, " & vbCrLf &
                                    "       [Cash] [decimal](18, 3) NULL, " & vbCrLf &
                                    "       [Kent] [decimal](18, 3) NULL, " & vbCrLf &
                                    "       [Date_] [datetime] NULL, " & vbCrLf &
                                    "       [Time_] [datetime] NULL, " & vbCrLf &
                                    "       [Note_] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [NumToWorld_AR] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [NumToWorld_EN] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [Activite] [int] NULL, " & vbCrLf &
                                    "       [SndType] [nvarchar](50) NULL, " & vbCrLf &
                                    "       [Casher] [nvarchar](50) NULL, " & vbCrLf &
                                    "       [UserID] [int] NULL, " & vbCrLf &
                                    "       [CivilID] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [GrossWeight] [decimal](18, 3) NULL, " & vbCrLf &
                                    "       [Karat] nvarchar(50) NULL, " & vbCrLf &
                                    "       [SandWeight] [decimal](18, 3), " & vbCrLf &
                                    "       [Weight] [decimal](18, 3) NULL, " & vbCrLf &
                                    "       [Supplier] [nvarchar](255) NULL, " & vbCrLf &
                                    "       [ReciviedName] [nvarchar](255) NULL, " & vbCrLf &
                                    "    Constraint [PK_SndGold] PRIMARY KEY CLUSTERED  " & vbCrLf &
                                    "   ( " & vbCrLf &
                                    "       [Id] Asc  " & vbCrLf &
                                    "   )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] " & vbCrLf &
                                    "   ) ON [PRIMARY] "

            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[SndToCustomer]') IS NULL " & vbCrLf &
                                            " CREATE TABLE [SndToCustomer](" & vbCrLf &
                                            " [Id] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                            " [SndNumber] [nvarchar](255) NULL," & vbCrLf &
                                            " [Amount] [decimal](18, 3) NULL," & vbCrLf &
                                            " [Cash] [decimal](18, 3) NULL," & vbCrLf &
                                            " [Kent] [decimal](18, 3) NULL," & vbCrLf &
                                            " [Date_] [date] NULL," & vbCrLf &
                                            " [Time_] [datetime] NULL," & vbCrLf &
                                             " [Note_] [nvarchar](255) NULL," & vbCrLf &
                                            " [NumToWorld_AR] [nvarchar](255) NULL," & vbCrLf &
                                            " [NumToWorld_EN] [nvarchar](255) NULL," & vbCrLf &
                                            " [PayMID] [int] NULL," & vbCrLf &
                                            " [Activite] [int] NULL," & vbCrLf &
                                             " [SndType] [nvarchar](255) NULL," & vbCrLf &
                                             " [Casher] [nvarchar](50) NULL," & vbCrLf &
                                            " [UserId] [int] NULL," & vbCrLf &
                                            "CONSTRAINT [PK_SndToCustomer] PRIMARY KEY CLUSTERED ([Id] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [Amount] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [Cash] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [Kent] [decimal](18, 3) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [Casher] nvarchar(50) NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [UserId] [int] NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [SndToCustomer] ALTER COLUMN [Time_] nvarchar(50) NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'SndPhoto') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [SndPhoto]  [image] NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'TypeTransaction') IS NULL " & vbCrLf &
                                              "BEGIN " & vbCrLf &
                                              "ALTER TABLE [SndToCustomer] ADD [TypeTransaction]  [int] NULL " & vbCrLf &
                                              "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'LastEditDate') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndToCustomer] ADD [LastEditDate] [datetime] NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'CreationDate') IS NULL " & vbCrLf &
                                  "BEGIN " & vbCrLf &
                                  "ALTER TABLE [SndToCustomer] ADD [CreationDate][datetime] NULL " & vbCrLf &
                                  "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[TPSellBuyWholesale]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[TPSellBuyWholesale](" & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                   "[InvIDAuto] [nvarchar](250) NULL," & vbCrLf &
                                   "[InvID] [nvarchar](250) NULL," & vbCrLf &
                                    "[CashierID] [int] NULL," & vbCrLf &
                                   "[CastomerCAIVELid] [nvarchar](255) NULL," & vbCrLf &
                                   "[COM_ID] [int] NULL," & vbCrLf &
                                   "[ItemDes] [nvarchar](2000) NULL," & vbCrLf &
                                   "[ItemImage] [image] NULL," & vbCrLf &
                                   "[GoldCaretBasic] [nvarchar](50) NULL," & vbCrLf &
                                   "[GoldCaretBasicValue] [decimal](18, 3) NULL," & vbCrLf &
                                  "[GoldCaretTrans] [nvarchar](50) NULL," & vbCrLf &
                                   "[GoldCaretTransValue] [decimal](18, 3) NULL," & vbCrLf &
                                  "[GoldCaretPrice] [decimal](18, 3) NULL," & vbCrLf &
                                  "[TotalGoledPrice] [decimal](18, 3) NULL," & vbCrLf &
                                  "[MakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                "[TotalMakeCharge] [decimal](18, 3) NULL," & vbCrLf &
                                 "[InvDate] [date] NULL," & vbCrLf &
                                  "[InvDateTime] [nvarchar](250) NULL," & vbCrLf &
                                  "[ActualInvDateTime] [nvarchar](250) NULL," & vbCrLf &
                                 "[UserID] [int] NULL," & vbCrLf &
                                "[InvActive] [int] NULL," & vbCrLf &
                                "[ItemActive] [int] NULL," & vbCrLf &
                                 "[InvType] [int] NULL," & vbCrLf &
                                  "[InvActiveaComp] [int] NULL," & vbCrLf &
                                  "CONSTRAINT [PK_TPSellBuyWholesale] PRIMARY KEY CLUSTERED ([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[BAYWholesale]') IS  NULL " & vbCrLf &
                                    "CREATE TABLE [dbo].[BAYWholesale]([ID] [int] IDENTITY(1,1) NOT NULL," & vbCrLf &
                                    "[InvIDAuto] [nvarchar](250) NOT NULL," & vbCrLf &
                                     "[InvID] [nvarchar](250) NULL," & vbCrLf &
                                      "[TOTAL_mony] [decimal](18, 3) NULL," & vbCrLf &
                                       "[KENT] [decimal](18, 3) NULL," & vbCrLf &
                                        "[CACH] [decimal](18, 3) NULL," & vbCrLf &
                                         "[arbic_tayb] [nvarchar](250) NULL," & vbCrLf &
                                          "[balance] [decimal](18, 3) NULL," & vbCrLf &
                                           "[English_tayb] [nvarchar](250) NULL," & vbCrLf &
                                            "[Notes] [nvarchar](250) NULL," & vbCrLf &
                                             "[Active] [int] NULL," & vbCrLf &
                                              "[PayMethod] [int] NULL," & vbCrLf &
                                               "[InvType] [int] NULL," & vbCrLf &
                                                "CONSTRAINT [PK_BAYWholesale] PRIMARY KEY CLUSTERED ([ID] ASC )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDetailsWholesalePurchases]') IS NOT NULL " &
                                    "DROP VIEW [ReportDetailsWholesalePurchases] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [ReportDetailsWholesalePurchases] AS SELECT dbo.BAYWholesale.ID, dbo.BAYWholesale.InvIDAuto, dbo.BAYWholesale.InvID, dbo.BAYWholesale.TOTAL_mony, dbo.BAYWholesale.KENT, dbo.BAYWholesale.CACH, dbo.BAYWholesale.arbic_tayb,  " & vbCrLf &
                          "dbo.BAYWholesale.balance, dbo.BAYWholesale.English_tayb, dbo.BAYWholesale.Notes, dbo.BAYWholesale.Active, dbo.BAYWholesale.InvType, dbo.TPSellBuyWholesale.ID AS IDTPSellBuyWholesale,  " & vbCrLf &
                          "dbo.TPSellBuyWholesale.InvIDAuto AS InvIDAutoTPSellBuyWholesale, dbo.TPSellBuyWholesale.InvID AS InvIDTPSellBuyWholesale, dbo.TPSellBuyWholesale.CashierID, dbo.TPSellBuyWholesale.CastomerCAIVELid, " & vbCrLf &
                          "dbo.TPSellBuyWholesale.ItemDes, dbo.TPSellBuyWholesale.ItemImage, dbo.TPSellBuyWholesale.GoldCaretBasic, dbo.TPSellBuyWholesale.GoldCaretBasicValue, dbo.TPSellBuyWholesale.GoldCaretTrans,  " & vbCrLf &
                          "dbo.TPSellBuyWholesale.GoldCaretTransValue, dbo.TPSellBuyWholesale.GoldCaretPrice, dbo.TPSellBuyWholesale.TotalGoledPrice, dbo.TPSellBuyWholesale.MakeCharge, dbo.TPSellBuyWholesale.TotalMakeCharge,  " & vbCrLf &
                          "dbo.TPSellBuyWholesale.InvDate, dbo.TPSellBuyWholesale.InvDateTime, dbo.TPSellBuyWholesale.ActualInvDateTime, dbo.TPSellBuyWholesale.InvActive, dbo.TPSellBuyWholesale.ItemActive,  " & vbCrLf &
                          "dbo.TPSellBuyWholesale.InvType AS InvTypeTPSellBuyWholesale, dbo.TPSellBuyWholesale.InvActiveaComp, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                          "dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.[user].user_name, dbo.cacher.cacher_name,  " & vbCrLf &
                          "dbo.cacher.CashierSignature, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_1.PayMethodEn AS PayMethodEn1,  " & vbCrLf &
                          "PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3,  " & vbCrLf &
                          "PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, dbo.BAYWholesale.Bank1, dbo.BAYWholesale.Bank2, dbo.BAYWholesale.Bank3, dbo.BAYWholesale.Bank4, " & vbCrLf &
                          "dbo.BAYWholesale.InvVatType, dbo.BAYWholesale.InvVat, dbo.BAYWholesale.PaymentReceipt, dbo.BAYWholesale.PaymentTransNumber, dbo.BAYWholesale.PurchaseInvNumber, dbo.BAYWholesale.PurchaseGold, " & vbCrLf &
                          "dbo.BAYWholesale.PurchaseGoldKarat, dbo.BAYWholesale.PayMethod, dbo.TPCompanyBranches.SalesCivilID, dbo.TPCompanyBranches.BranchName, dbo.TPCompanyBranches.BranchAddress,  " & vbCrLf &
                          "dbo.TPCompanyBranches.TelNumber, dbo.TPCompanyBranches.LicenseNumber, dbo.TPCompanyBranches.CommercialRegisterNo, dbo.TPCompanyBranches.LicenseImage, dbo.TPCompanyInfo.CompanyName,  " & vbCrLf &
                          "dbo.TPCompanyInfo.CompanyAddress, dbo.TPCompanyInfo.LicenseNumber AS LicenseNumberompanyInfo " & vbCrLf &
                          "FROM dbo.CastomerDETELS RIGHT OUTER JOIN " & vbCrLf &
                          "dbo.TPCompanyBranches INNER JOIN " & vbCrLf &
                          "dbo.TPSellBuyWholesale ON dbo.TPCompanyBranches.BranchID = dbo.TPSellBuyWholesale.COM_ID INNER JOIN " & vbCrLf &
                          "dbo.TPCompanyInfo ON dbo.TPCompanyBranches.CompanyID = dbo.TPCompanyInfo.CompanyID LEFT OUTER JOIN " & vbCrLf &
                          "dbo.[user] ON dbo.TPSellBuyWholesale.UserID = dbo.[user].user_id ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.TPSellBuyWholesale.CastomerCAIVELid LEFT OUTER JOIN " & vbCrLf &
                          "dbo.cacher ON dbo.TPSellBuyWholesale.CashierID = dbo.cacher.svil_id FULL OUTER JOIN " & vbCrLf &
                          "dbo.PayMethod INNER JOIN " & vbCrLf &
                          "dbo.BAYWholesale ON dbo.PayMethod.ID = dbo.BAYWholesale.PayMethod INNER JOIN " & vbCrLf &
                          "dbo.PayMethod AS PayMethod_1 ON dbo.BAYWholesale.PayMethod1 = PayMethod_1.ID INNER JOIN " & vbCrLf &
                          "dbo.PayMethod AS PayMethod_2 ON dbo.BAYWholesale.PayMethod2 = PayMethod_2.ID INNER JOIN " & vbCrLf &
                          "dbo.PayMethod AS PayMethod_3 ON dbo.BAYWholesale.PayMethod3 = PayMethod_3.ID INNER JOIN " & vbCrLf &
                          "dbo.PayMethod AS PayMethod_4 ON dbo.BAYWholesale.PayMethod4 = PayMethod_4.ID ON dbo.TPSellBuyWholesale.InvID = dbo.BAYWholesale.InvID " & vbCrLf &
                          "WHERE (dbo.BAYWholesale.Active = 1) AND (dbo.TPSellBuyWholesale.InvActive = 1) AND (dbo.TPSellBuyWholesale.ItemActive = 1) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = " CREATE VIEW [dbo].[ReportWholesalePurchases] AS SELECT " & vbCrLf &
                                   " InvID, TOTAL_mony, KENT, CACH, arbic_tayb, balance, " & vbCrLf &
                                   " English_tayb, Notes, Active, InvType, CastomerCAIVELid, " & vbCrLf &
                                   " ItemDes, GoldCaretBasic, GoldCaretBasicValue, GoldCaretTrans, " & vbCrLf &
                                  " GoldCaretTransValue, GoldCaretPrice, TotalGoledPrice, " & vbCrLf &
                                   " MakeCharge, TotalMakeCharge, InvDateTime, CastomerNAme, " & vbCrLf &
                                  " CastomerADr, CastomerTE, CastomerNA, foto, Signature, fotoBack, " & vbCrLf &
                                 " CastomerNameEn, user_name, cacher_name, CashierSignature, " & vbCrLf &
                                " COMP_NAME, COMP_NAME_SHORT, SGAL_TAGARE, PHONE_NOMPER, FAX_NOMPER, PayMethodAr, PayMethodEn " & vbCrLf &
                                " FROM dbo.ReportDetailsWholesalePurchases "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            '  FailMessages &= ex.Message
            '  FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'DefaultBarcode') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Settings] ADD [DefaultBarcode] nvarchar (255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'SndNumber') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                                   "  ALTER TABLE [SndToCustomer] ADD [SndNumber] [nvarchar](255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Amount') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndToCustomer] ADD [Amount] [decimal](18, 3) NULL " & vbCrLf &
            "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Cash') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Cash] [decimal](18, 3) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Kent') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Kent] [decimal](18, 3) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Date_') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Date_] [date] NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Time_') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Time_] [datetime] NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Note_') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Note_] [nvarchar](255) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'NumToWorld_AR') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [NumToWorld_AR] [nvarchar](255) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'NumToWorld_EN') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [NumToWorld_EN] [nvarchar](255) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'PayMID') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [PayMID] [int] NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Activite') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Activite] [int] NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'SndType') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [SndType] [nvarchar](255) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'Casher') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [Casher] [nvarchar](50) NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'UserId') IS NULL " & vbCrLf &
                                   "BEGIN " & vbCrLf &
                "  ALTER TABLE [SndToCustomer] ADD [UserId] [int] NULL " & vbCrLf &
                "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'civilid') IS NULL " & vbCrLf &
                               "BEGIN " & vbCrLf &
                               "ALTER TABLE [SndToCustomer] ADD [civilid] nvarchar (255) NULL " & vbCrLf &
                               "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF COL_LENGTH('SndToCustomer', 'CompName') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndToCustomer] ADD [CompName] [nvarchar](250) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[dbo].[Accessories_BuyVw]') IS NOT NULL  " & vbCrLf &
           "DROP VIEW [dbo].[Accessories_BuyVw]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = " CREATE VIEW [dbo].[Accessories_BuyVw] AS " & vbCrLf &
                                  " SELECT     AccessoriesID, Accessories_NAME, Accessories_BRAND, " & vbCrLf &
                                  " Accessories_DESC, Accessories_ItemStatus, Accessories_CAT, " & vbCrLf &
                                " Accessories_DEP, Accessories_model_no, Accessories_nom, " & vbCrLf &
                                 " Accessories_TIME, Accessories_DATE_CRE, Accessories_USER_CRET, " & vbCrLf &
                               " Accessories_CID, Accessories_Price, Accessories_InvoiceNo, " & vbCrLf &
                              " Accessories_YearOfWarr, Accessories_Attachments FROM  dbo.Accessories_Buy "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[Accessories_Buy_PayVw]') IS NOT NULL  " & vbCrLf &
            "DROP VIEW [Accessories_Buy_PayVw]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = " CREATE VIEW [dbo].[Accessories_Buy_PayVw] AS " & vbCrLf &
                     "SELECT     dbo.Accessories_Buy_Pay.Accessories_Pay_ID, dbo.Accessories_Buy_Pay.Accessories_InvoiceNo, dbo.Accessories_Buy_Pay.Accessories_TOTAL_Price, " & vbCrLf &
                     " dbo.Accessories_Buy_Pay.Accessories_KNET, dbo.Accessories_Buy_Pay.Accessories_CASH, dbo.Accessories_Buy_Pay.Accessories_Arabic_tayb, " & vbCrLf &
                     " dbo.Accessories_Buy_Pay.Accessories_balance, dbo.Accessories_Buy_Pay.Accessories_staytes, dbo.Accessories_Buy_Pay.Accessories_PaymentType, " & vbCrLf &
                     " dbo.Accessories_Buy_Pay.Accessories_Casher, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, " & vbCrLf &
                     " dbo.Accessories_Buy.Accessories_DATE_CRE, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_Buy.Accessories_NAME, dbo.Accessories_Buy.Accessories_BRAND, " & vbCrLf &
                     " dbo.Accessories_Buy.Accessories_DESC, dbo.Accessories_Buy.Accessories_ItemStatus, dbo.Accessories_Buy.Accessories_model_no, dbo.Accessories_Buy.Accessories_nom, " & vbCrLf &
                     " dbo.Accessories_Buy.Accessories_Price, dbo.Accessories_Buy.AccessoriesID, dbo.cacher.cacher_name, dbo.Accessories_Buy.Accessories_TIME, dbo.CastomerDETELS.foto, " & vbCrLf &
                     "  dbo.CastomerDETELS.Signature, dbo.cacher.CashierSignature, dbo.CastomerDETELS.fotoBack, dbo.Accessories_Buy.Accessories_YearOfWarr, " & vbCrLf &
                     "  dbo.Accessories_Buy.Accessories_Attachments " & vbCrLf &
                     " FROM  dbo.CastomerDETELS INNER JOIN " & vbCrLf &
                     " dbo.Accessories_Buy ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.Accessories_Buy.Accessories_CID INNER JOIN " & vbCrLf &
                     " dbo.Accessories_Buy_Pay INNER JOIN " & vbCrLf &
                     "  dbo.cacher ON dbo.Accessories_Buy_Pay.Accessories_Casher = dbo.cacher.cacherID ON dbo.Accessories_Buy.Accessories_InvoiceNo = dbo.Accessories_Buy_Pay.Accessories_InvoiceNo "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message

        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy', 'Accessories_YearOfWarr') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_Buy] ADD [Accessories_YearOfWarr] nvarchar (50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy', 'Accessories_Attachments') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_Buy] ADD [Accessories_Attachments] nvarchar (1000) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_Buy', 'ItemNo') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_Buy] ADD [ItemNo] nvarchar (50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndGold', 'ReciviedName') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndGold] ADD [ReciviedName] nvarchar(255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndGold', 'SandWeight') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndGold] ADD [SandWeight] decimal(18, 3) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('SndGold', 'Supplier') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [SndGold] ADD [Supplier] NVARCHAR(255) NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Gram_val', 'FractionValues')  IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Gram_val] ADD [FractionValues] NVARCHAR (50)  NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ITEMAvailableDiamond]') IS NOT NULL  " & vbCrLf &
            "DROP VIEW [ITEMAvailableDiamond]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [ITEMAvailableDiamond]  AS SELECT  DIMON_detels.DIMOND_ID, DIMON_detels.DIMO_dep, " & vbCrLf &
                     "DIMON_detels.DIM_na9awa, DIMON_detels.DIMO_mezan, DIMON_detels.ext_coler, DIMON_detels.qult, " & vbCrLf &
                      "DIMON_detels.sarual, DIMON_detels.val_gold, DIMON_detels.GOLD_mezan, DIMON_detels.test_1, " & vbCrLf &
                      "DIMON_detels.test_11, DIMON_detels.test_12, " & vbCrLf &
                     " DIMON_detels.test_13, DIMON_detels.test_14, " & vbCrLf &
                      "DIMON_detels.test_15, DIMON_detels.test_16, " & vbCrLf &
                      "DIMON_detels.test_17, DIMON_detels.test_18, " & vbCrLf &
                      "DIMON_detels.test_19, " & vbCrLf &
                     " DIMON_detels.test_110, DIMON_detels.test_111, " & vbCrLf &
                     " DIMON_detels.test_112, DIMON_detels.test_113," & vbCrLf &
                      " DIMON_detels.test_114, DIMON_detels.test_115, " & vbCrLf &
                     " DIMON_detels.test_116, DIMON_detels.test_117, " & vbCrLf &
                      "DIMON_detels.test_118, DIMON_detels.test_119," & vbCrLf &
                     "  DIMON_detels.date_creted, DIMON_detels.ITEM_IMGE, " & vbCrLf &
                     " DIMON_detels.Item_Actv AS DIMON_detels_Item_Actv," & vbCrLf &
                     " dimon_invce.Item_Actv AS dimon_invce_Item_Actv, " & vbCrLf &
                     " DIMON_detels.CostToSeller, DIMON_detels.TaxExempt, " & vbCrLf &
                     " DIMON_detels.Documents, DIMON_detels.Cut1, " & vbCrLf &
                      "DIMON_detels.Clarity1, DIMON_detels.Cut2, " & vbCrLf &
                     " DIMON_detels.Clarity2, DIMON_detels.Cut3, DIMON_detels.Clarity3, " & vbCrLf &
                      "DIMON_detels.IsDiamond1, DIMON_detels.IsDiamond2, DIMON_detels.IsDiamond3 " & vbCrLf &
                     " FROM DIMON_detels LEFT OUTER JOIN " & vbCrLf &
                     " dimon_invce ON DIMON_detels.test_119 = dimon_invce.test_119 " & vbCrLf &
                     " WHERE (DIMON_detels.Item_Actv = 1) OR (dimon_invce.Item_Actv = 0) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ITEM_Available_Diamond]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [ITEM_Available_Diamond]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ITEM_Available_Diamond] AS SELECT DIMOND_ID, DIMO_dep, DIM_na9awa, " & vbCrLf &
                                    "DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, " & vbCrLf &
                                    "test_13, test_14, test_15, test_16, test_17, test_18, test_19, test_110, " & vbCrLf &
                                    "test_111, test_112, test_113, test_114, test_115, test_116, test_117, test_118, " & vbCrLf &
                                    "test_119, date_creted, DIMON_detels_Item_Actv, SUM(dimon_invce_Item_Actv) AS dimon_invce_Item_Actv, " & vbCrLf &
                                    "CostToSeller, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3 FROM dbo.ITEMAvailableDiamond " & vbCrLf &
                                    "GROUP BY DIMOND_ID, DIMO_dep, DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold,  " & vbCrLf &
                                    "GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, test_16, test_17, test_18, test_19, " & vbCrLf &
                                    "test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117, test_118, " & vbCrLf &
                                    "test_119, date_creted, DIMON_detels_Item_Actv, CostToSeller, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3 " & vbCrLf &
                                    "HAVING (DIMON_detels_Item_Actv > 0) AND (SUM(dimon_invce_Item_Actv) = 0) OR (SUM(dimon_invce_Item_Actv) IS NULL) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try



        Try
            GlCommand.CommandText = "IF COL_LENGTH('EXTR_NAME', 'AsGold') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [EXTR_NAME] ADD [AsGold] BIT NOT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('EXTR_NAME', 'IsDiamond') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [EXTR_NAME] ADD [IsDiamond] BIT NOT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('CastomerDETELS', 'CastomerNameEn') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CastomerDETELS] ADD [CastomerNameEn] NVARCHAR(255) NOT NULL DEFAULT N'' WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'GramPrice') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [GramPrice] decimal(18, 3) NOT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'SoldItem') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [SoldItem] NVARCHAR (200)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Cut1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Cut1] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Clarity1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Clarity1] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Cut2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Cut2] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Clarity2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Clarity2] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Cut3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Cut3] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Clarity3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Clarity3] NVARCHAR (50)  NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'IsDiamond1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [IsDiamond1] BIT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'IsDiamond2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [IsDiamond2] BIT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'IsDiamond3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [IsDiamond3] BIT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try

            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [dimo_id] [nvarchar](50) NOT NULL   UPDATE [dimon_invce] SET [dimo_id] = [test_119] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'TIME') IS NOT NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] DROP COLUMN [TIME] " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'TIME_INV') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [TIME_INV] DATETIME " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PayMethod') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PayMethod] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'ID_MAX') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [ID_MAX] nvarchar(255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE  [bay_goled_mony] SET [ID_MAX]=[saryal] WHERE [ID_MAX] IS NULL OR [ID_MAX]=''"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ' إضافة أعمدة طرق الدفع المتعددة
        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PayMethod1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PayMethod1] nvarchar(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PayMethod2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PayMethod2] nvarchar(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PayMethod3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PayMethod3] nvarchar(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PayMethod4') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PayMethod4] nvarchar(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'Bank1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [Bank1] decimal(18,3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'Bank2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [Bank2] decimal(18,3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'Bank3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [Bank3] decimal(18,3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'Bank4') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [Bank4] decimal(18,3) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PaymentReceipt') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PaymentReceipt] image NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'PaymentTransNumber') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [PaymentTransNumber] nvarchar(100) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [bay_goled_mony] ALTER COLUMN [TIME_INV] nvarchar(255)"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [bay_goled_mony] ALTER COLUMN [Saryal] nvarchar(255)"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [descont] nvarchar(50) "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [DIMO_qult] int NOT NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [dimon_bay] ALTER COLUMN [BAY_SARYAL] nvarchar(50)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [dimon_bay] ALTER COLUMN [PayMethod] nvarchar(50)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        ' اضافة حقل العدد لجدول شراء الذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'Qunt') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [Qunt] [int] NOT NULL DEFAULT 1 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'اذا كان الصنف مضاف الي اصناف الذهب =1 غير مضاف = 0

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'AddToItem') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [AddToItem] [int] NULL" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'اضافة حقل الملاحظات الي فاتورة الشراء ذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'Note') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [Note] nvarchar(400)NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'اضافة حقل العيار الصافي الي فاتورة الشراء ذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'GoldCaret999') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [GoldCaret999] nvarchar(255)NOT NULL DEFAULT 995 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل الوزن الصافي الي فاتورة الشراء ذهب

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'GoldWeight999') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [GoldWeight999] [decimal](18, 3)NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'اضافة حقل الوصف الي فاتورة الشراء ذهب
        '
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'Item_Des') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [Item_Des] nvarchar(255)NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        'اضافة حقل حالة الفاتوره الشراء ذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Buy_Gold', 'INV_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Buy_Gold] ADD [INV_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [Buy_Gold] ALTER COLUMN [inv_id] nvarchar(255) NOT NULL "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ' جدول الدفع اضافة حقل حالة الفاتوره الشراء ذهب
        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'INV_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD [INV_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "IF COL_LENGTH('Accessories_ITEM', 'Item_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_ITEM] ADD [Item_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Item_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Item_Actv] INT " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'CostToSeller') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [CostToSeller] DECIMAL(18, 3) NOT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'TaxExempt') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [TaxExempt] BIT NOT NULL DEFAULT 0 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Documents') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Documents] IMAGE NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Cut1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Cut1] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Clarity1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Clarity1] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Cut2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Cut2] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Clarity2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Clarity2] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Cut3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Cut3] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'Clarity3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [Clarity3] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'IsDiamond1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [IsDiamond1] BIT NOT NULL DEFAULT 0 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'IsDiamond2') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [IsDiamond2] BIT NOT NULL DEFAULT 0 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('DIMON_detels', 'IsDiamond3') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [DIMON_detels] ADD [IsDiamond3] BIT NOT NULL DEFAULT 0 WITH VALUES " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [sarual] NVARCHAR(50) NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'Item_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] ADD [Item_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_bay', 'staytes') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_bay] ADD [staytes] NVARCHAR(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_bay', 'Item_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_bay] ADD [Item_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [dimon_bay] ALTER COLUMN [TOTAL_mony] decimal(18, 3) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_bay] ALTER COLUMN [KENT] decimal(18, 3) NOT NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "ALTER TABLE [dimon_bay] ALTER COLUMN [CACH] decimal(18, 3) NOT NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_bay', 'user_id') IS NULL " & Environment.NewLine &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_bay] ADD [user_id] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [user_id] = '2' WHERE [user_id] IS NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('FO_min', 'Item_Actv') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [FO_min] ADD [Item_Actv] int " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [selInvoceDetels] ALTER COLUMN [date] [date] NOT NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [selInvoceDetels] ALTER COLUMN [Active] [int] NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_ITEM', 'Accessories_Supplier') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_ITEM] ADD [Accessories_Supplier] nvarchar(50) , [Accessories_Attachments] nvarchar(50) " & vbCrLf &
                                    "END"

            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_BarcodeConfig', 'L_SupplierValue_U') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    " ALTER TABLE [Accessories_BarcodeConfig] ADD " & vbCrLf &
                                    " [L_SupplierValue_U] nvarchar(50) , [L_SupplierValue_D] nvarchar(50) , " & vbCrLf &
                                    " [L_SupplierText_U] nvarchar(50) , [L_SupplierText_D] nvarchar(50) , " & vbCrLf &
                                    " [L_AttachmentValue_U] nvarchar(50) , [L_AttachmentValue_D] nvarchar(50) , " & vbCrLf &
                                    " [L_AttachmentText_U] nvarchar(50) , [L_AttachmentText_D] nvarchar(50) , " & vbCrLf &
                                    " [R_SupplierValue_U] nvarchar(50) , [R_SupplierValue_D] nvarchar(50) , " & vbCrLf &
                                    " [R_SupplierText_U] nvarchar(50) , [R_SupplierText_D] nvarchar(50) , " & vbCrLf &
                                    " [R_AttachmentValue_U] nvarchar(50) , [R_AttachmentValue_D] nvarchar(50) , " & vbCrLf &
                                    " [R_AttachmentText_U] nvarchar(50) , [R_AttachmentText_D] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_BarcodeConfig', 'CompanyTextFontValue') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    " ALTER TABLE [Accessories_BarcodeConfig] ADD " & vbCrLf &
                                    " [BarCodeFontValue] nvarchar(50) , [BarCodeFontStyle] nvarchar(50) , " & vbCrLf &
                                    " [BarCodeNoFontValue] nvarchar(50) , [BarCodeNoFontStyle] nvarchar(50) , " & vbCrLf &
                                    " [DataTextFontValue] nvarchar(50) , [DataTextFontStyle] nvarchar(50) , " & vbCrLf &
                                    " [CompanyTextFontValue] nvarchar(50) , [CompanyTextFontStyle] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = " ALTER TABLE [FO_min] ALTER COLUMN [FO_price] nvarchar(50) NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ' "
        Try
            GlCommand.CommandText = " ALTER TABLE [FO_min] ALTER COLUMN [FO_Gramprice] nvarchar(50) NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('dimon_invce', 'price') IS NOT NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [dimon_invce] DROP COLUMN [price] , [cach] , [kenet] " & vbCrLf &
                                    "END"

            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('CONFI_barcood', 'R_CodeValue_U') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CONFI_barcood] ADD " & vbCrLf &
                                    "[R_CodeValue_U] nvarchar(50) , " & vbCrLf &
                                    "[R_CodeValue_D] nvarchar(50) , " & vbCrLf &
                                    "[R_CodeText_U] nvarchar(50) , " & vbCrLf &
                                    "[R_CodeText_D] nvarchar(50) , " & vbCrLf &
                                    "[L_CodeValue_U] nvarchar(50) , " & vbCrLf &
                                    "[L_CodeValue_D] nvarchar(50) , " & vbCrLf &
                                    "[L_CodeText_U] nvarchar(50) , " & vbCrLf &
                                    "[L_CodeText_D] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('CONFI_barcood', 'R_Stone2Value_U') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CONFI_barcood] ADD " & vbCrLf &
                                    "[R_Stone2Value_U] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone2Value_D] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone2Text_U] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone2Text_D] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone2Value_U] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone2Value_D] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone2Text_U] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone2Text_D] nvarchar(50) ," & vbCrLf &
                                    "[R_Stone3Value_U] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone3Value_D] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone3Text_U] nvarchar(50) , " & vbCrLf &
                                    "[R_Stone3Text_D] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone3Value_U] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone3Value_D] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone3Text_U] nvarchar(50) , " & vbCrLf &
                                    "[L_Stone3Text_D] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('CONFI_barcood_dimon', 'Cut1_Leftup') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CONFI_barcood_dimon] ADD " & vbCrLf &
                                    "[Cut1_Leftup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut1_Left1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut1_Rightup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut1_Right1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut2_Leftup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut2_Left1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut2_Rightup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut2_Right1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut3_Leftup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut3_Left1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut3_Rightup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[Cut3_Right1up] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('CONFI_barcood_dimon', 'TotalStoneWeight_Leftup') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CONFI_barcood_dimon] ADD " & vbCrLf &
                                    "[TotalStoneWeight_Leftup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeight_Left1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeight_Rightup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeight_Right1up] NVARCHAR(50) NULL  " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('CONFI_barcood_dimon', 'TotalStoneWeightText_Leftup') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [CONFI_barcood_dimon] ADD " & vbCrLf &
                                    "[TotalStoneWeightText_Leftup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeightText_Left1up] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeightText_Rightup] NVARCHAR(50) NULL , " & vbCrLf &
                                    "[TotalStoneWeightText_Right1up] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF COL_LENGTH('Accessories_BAY', 'Accessories_Notes') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [Accessories_BAY] ADD " & vbCrLf &
                                    "[Accessories_Notes] nvarchar(200) , " & vbCrLf &
                                    "[Accessories_PayMethod] nvarchar(50) " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[PayMethod]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [PayMethod]( " & vbCrLf &
                                    "[ID] [int] IDENTITY(0,1) NOT NULL, " & vbCrLf &
                                    "[PayMethodAr] [nvarchar](50) NULL, " & vbCrLf &
                                    "[PayMethodEn] [nvarchar](50) NULL, " & vbCrLf &
                                    "[Active] [bit] NULL, " & vbCrLf &
                                    "CONSTRAINT [PK_PayMethod] PRIMARY KEY CLUSTERED ([ID] ASC) " & vbCrLf &
                                    "WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[StoneColor]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [StoneColor]( " & vbCrLf &
                                    "[ID] [int] IDENTITY(1,1) NOT NULL, " & vbCrLf &
                                    "[StoneColor] [nvarchar](50) NULL " & vbCrLf &
                                    "CONSTRAINT [PK_StoneColor] PRIMARY KEY CLUSTERED ([ID] ASC) " & vbCrLf &
                                    "WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID('[PayInstallment]') IS NULL " & vbCrLf &
                                    "CREATE TABLE [PayInstallment]( " & vbCrLf &
                                    "[ID] [Int] IDENTITY(1, 1) Not NULL, " & vbCrLf &
                                    "[InvoiceNo] [nvarchar](50) NULL, " & vbCrLf &
                                    "[InvoiceType] [nvarchar](50) NULL, " & vbCrLf &
                                    "[PayPrice] [Decimal](18, 3) Not NULL, " & vbCrLf &
                                    "[KNET] [Decimal](18, 3) NULL, " & vbCrLf &
                                    "[CASH] [Decimal](18, 3) NULL, " & vbCrLf &
                                    "[PayDateTime] [DateTime] NULL, " & vbCrLf &
                                    "[PayMethod] [Int] NULL, " & vbCrLf &
                                    "[Cashier] [nvarchar](50) NULL, " & vbCrLf &
                                    "[Item_Actv] [Int] NULL, " & vbCrLf &
                                    "Constraint [PK_DiamondPayInstallment] PRIMARY KEY CLUSTERED  " & vbCrLf &
                                    "([ID] ASC)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, " & vbCrLf &
                                    "ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]) ON [PRIMARY]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'Cashier') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] ADD " & vbCrLf &
                                    "[Cashier] nvarchar(255) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('bay_goled_mony', 'TIME') IS NOT NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [bay_goled_mony] " & vbCrLf &
                                    "DROP COLUMN [TIME] " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('FO_min', 'StoneColor1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [FO_min] ADD " & vbCrLf &
                                    "[StoneColor1] NVARCHAR(50) NULL, " & vbCrLf &
                                    "[StonePrice1] DECIMAL(18,3) NULL, " & vbCrLf &
                                    "[StoneWeight2] DECIMAL(18,3) NULL, " & vbCrLf &
                                    "[StoneName2] NVARCHAR(50) NULL, " & vbCrLf &
                                    "[StoneColor2] NVARCHAR(50) NULL, " & vbCrLf &
                                    "[StonePrice2] DECIMAL(18,3) NULL, " & vbCrLf &
                                    "[StoneWeight3] DECIMAL(18,3) NULL, " & vbCrLf &
                                    "[StoneName3] NVARCHAR(50) NULL, " & vbCrLf &
                                    "[StoneColor3] NVARCHAR(50) NULL, " & vbCrLf &
                                    "[StonePrice3] DECIMAL(18,3) NULL, " & vbCrLf &
                                    "[Qty] INT NULL, " & vbCrLf &
                                    "[BarCode] NVARCHAR(50) NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER TABLE [FO_min] ALTER COLUMN [StoneColor3] NVARCHAR(50) NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'StoneColor1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [selInvoceDetels] ADD " & vbCrLf &
                                    "[StoneName1] nvarchar(50) NULL, " & vbCrLf &
                                    "[StoneColor1] nvarchar(50) NULL, " & vbCrLf &
                                    "[StonePriceType1] INT NULL, " & vbCrLf &
                                    "[StoneWeight2] decimal(18,3) NULL, " & vbCrLf &
                                    "[StoneName2] nvarchar(50) NULL, " & vbCrLf &
                                    "[StoneColor2] nvarchar(50) NULL, " & vbCrLf &
                                    "[StonePrice2] decimal(18,3) NULL, " & vbCrLf &
                                    "[StonePriceType2] INT NULL, " & vbCrLf &
                                    "[StoneWeight3] decimal(18,3) NULL, " & vbCrLf &
                                    "[StoneName3] nvarchar(50) NULL, " & vbCrLf &
                                    "[StoneColor3] nvarchar(50) NULL, " & vbCrLf &
                                    "[StonePrice3] decimal(18,3) NULL, " & vbCrLf &
                                    "[StonePriceType3] INT NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('selInvoceDetels', 'StonePriceType1') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [selInvoceDetels] ADD " & vbCrLf &
                                    "[StonePriceType1] INT NULL, " & vbCrLf &
                                    "[StonePriceType2] INT NULL, " & vbCrLf &
                                    "[StonePriceType3] INT NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[bay_gold_id]') IS NOT NULL " & vbCrLf &
                                    "DROP TABLE [bay_gold_id] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception

        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[BAY_report_for_castomer]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [BAY_report_for_castomer] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[BAY_report_for_castomer_Diamond]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [BAY_report_for_castomer_Diamond] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[BAY_report_for_castomer_Short]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [BAY_report_for_castomer_Short] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[for-invoce-report-finel]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [for-invoce-report-finel] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[rptGoldItemSold]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [rptGoldItemSold] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[FO_min2]') IS NOT NULL " & vbCrLf &
                                    "DROP TABLE [FO_min2] "
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'تحديث استعلام الفواتير واضافة حقل صورة توقيع الكاشير
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldBuyInvoice]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldBuyInvoice] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportGoldBuyInvoice] AS SELECT dbo.Buy_Gold.castomer_id," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE," & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, " & vbCrLf &
                         "dbo.Buy_Gold.bay_val, dbo.Buy_Gold.bay_mazan, dbo.Buy_Gold.bay_gram_price," & vbCrLf &
                         "dbo.Buy_Gold.bay_total_price, dbo.bay_goled_mony.total_price, dbo.bay_goled_mony.cach, dbo.bay_goled_mony.kenet, " & vbCrLf &
                         "dbo.bay_goled_mony.arabik, dbo.Buy_Gold.inv_id, dbo.bay_goled_mony.date," & vbCrLf &
                         "dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, dbo.bay_goled_mony.English, dbo.Buy_Gold.Item_Des, dbo.Buy_Gold.INV_Actv, " & vbCrLf &
                         "dbo.CastomerDETELS.fotoBack, dbo.bay_goled_mony.INV_Actv AS INV_Actv_bay," & vbCrLf &
                         "dbo.bay_goled_mony.TIME_INV, dbo.bay_goled_mony.Cashier, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, " & vbCrLf &
                         "dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Buy_Gold.AddToItem," & vbCrLf &
                         "dbo.Buy_Gold.Note, dbo.Buy_Gold.GoldWeight999, dbo.Buy_Gold.Qunt, dbo.Buy_Gold.GoldCaret999, " & vbCrLf &
                         "dbo.CastomerDETELS.CastomerNameEn, dbo.bay_goled_mony.PayMethod, dbo.Buy_Gold.B_gold_id," & vbCrLf &
                         "dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1," & vbCrLf &
                         "dbo.bay_goled_mony.Bank1, dbo.bay_goled_mony.Bank2, dbo.bay_goled_mony.Bank3, dbo.bay_goled_mony.Bank4," & vbCrLf &
                         "dbo.bay_goled_mony.PayMethod1, dbo.bay_goled_mony.PayMethod2, dbo.bay_goled_mony.PayMethod3, dbo.bay_goled_mony.PayMethod4," & vbCrLf &
                         "PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_2.PayMethodAr AS PayMethodAr2," & vbCrLf &
                         "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_4.PayMethodAr AS PayMethodAr4," & vbCrLf &
                         "dbo.bay_goled_mony.PaymentReceipt, dbo.bay_goled_mony.PaymentTransNumber" & vbCrLf &
                         "FROM dbo.Buy_Gold INNER JOIN" & vbCrLf &
                         "dbo.CastomerDETELS ON dbo.Buy_Gold.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                         "dbo.bay_goled_mony ON dbo.Buy_Gold.inv_id = dbo.bay_goled_mony.saryal LEFT OUTER JOIN" & vbCrLf &
                         "dbo.cacher ON dbo.bay_goled_mony.Cashier = dbo.cacher.svil_id LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod ON dbo.bay_goled_mony.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_1 ON dbo.bay_goled_mony.PayMethod1 = PayMethod_1.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_2 ON dbo.bay_goled_mony.PayMethod2 = PayMethod_2.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_3 ON dbo.bay_goled_mony.PayMethod3 = PayMethod_3.ID LEFT OUTER JOIN" & vbCrLf &
                         "dbo.PayMethod AS PayMethod_4 ON dbo.bay_goled_mony.PayMethod4 = PayMethod_4.ID CROSS JOIN" & vbCrLf &
                         "dbo.Settings CROSS JOIN" & vbCrLf &
                         "dbo.comp_inform"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldProfit]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldProfit]"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [ReportGoldProfit] AS SELECT dbo.selInvoceDetels.ItemID, dbo.selInvoceDetels.item_name, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_gramMade AS made_invoce, dbo.selInvoceDetels.item_extrasMAZAN, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_totalPrice, " & vbCrLf &
                                    "dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.date AS date_seel, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram AS wazen_sell, " & vbCrLf &
                                    "dbo.cacher.cacher_name, dbo.FO_min.date_care, dbo.FO_min.Gram_valu, dbo.FO_min.FO_desp AS cost, " & vbCrLf &
                                    "dbo.FO_min.FO_gram AS wazen_stecar, dbo.selInvoceDetels.item_gramMade - " & vbCrLf &
                                    "dbo.FO_min.FO_desp AS parfet_for_gram, (dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp) " & vbCrLf &
                                    "* dbo.FO_min.FO_gram AS total_parfet_into_gram, dbo.selInvoceDetels.item_totalPrice - " & vbCrLf &
                                    "dbo.selInvoceDetels.item_extrasPRICE AS total_price_gold, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_gramMade * dbo.FO_min.FO_gram AS TotalMake, " & vbCrLf &
                                    "dbo.FO_min.FO_desp * dbo.FO_min.FO_gram AS TotalCost, dbo.FO_min.FO_GramPrice AS Supplier, " & vbCrLf &
                                    "dbo.FO_min.BarCode " & vbCrLf &
                                    "FROM dbo.selInvoceDetels INNER JOIN " & vbCrLf &
                                    "dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode LEFT OUTER JOIN " & vbCrLf &
                                    "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id " & vbCrLf &
                                    "WHERE (dbo.selInvoceDetels.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try

            GlCommand.CommandText = "IF OBJECT_ID('[goled_barfet_finel]') IS NOT NULL " &
                                    "DROP VIEW [goled_barfet_finel]"

            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [goled_barfet_finel] AS SELECT dbo.selInvoceDetels.ItemID, " & vbCrLf &
                      "dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.item_gramMade AS made_invoce, dbo.selInvoceDetels.item_extrasMAZAN, " & vbCrLf &
                      "dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_totalPrice, " & vbCrLf &
                      "dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.date AS date_seel, " & vbCrLf &
                      "dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram AS wazen_sell, dbo.cacher.cacher_name, " & vbCrLf &
                      "dbo.FO_min.date_care, dbo.FO_min.Gram_valu, dbo.FO_min.FO_desp AS cost, " & vbCrLf &
                      "dbo.FO_min.FO_gram AS wazen_stecar, dbo.selInvoceDetels.item_gramMade - " & vbCrLf &
                      "dbo.FO_min.FO_desp AS parfet_for_gram, (dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp) " & vbCrLf &
                      "* dbo.FO_min.FO_gram AS total_parfet_into_gram, dbo.selInvoceDetels.item_totalPrice - " & vbCrLf &
                      "dbo.selInvoceDetels.item_extrasPRICE AS total_price_gold, " & vbCrLf &
                      "dbo.selInvoceDetels.item_gramMade * dbo.FO_min.FO_gram AS TotalMake, dbo.FO_min.FO_desp * " & vbCrLf &
                      "dbo.FO_min.FO_gram AS TotalCost, dbo.FO_min.FO_GramPrice AS Supplier " & vbCrLf &
                      "FROM dbo.selInvoceDetels INNER JOIN " & vbCrLf &
                      "dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode LEFT OUTER JOIN " & vbCrLf &
                      "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id " & vbCrLf &
                      "WHERE (dbo.selInvoceDetels.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldBuyDetailed]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldBuyDetailed] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [ReportGoldBuyDetailed] AS " & vbCrLf &
                                    "SELECT TOP (2147483647) Buy_Gold.castomer_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, " & vbCrLf &
                                    "Buy_Gold.bay_val, Buy_Gold.bay_mazan, Buy_Gold.bay_gram_price, Buy_Gold.bay_total_price, bay_goled_mony.total_price, bay_goled_mony.cach,  " & vbCrLf &
                                    "bay_goled_mony.kenet, bay_goled_mony.arabik, Buy_Gold.inv_id, bay_goled_mony.date, bay_goled_mony.English " & vbCrLf &
                                    "FROM Buy_Gold INNER JOIN CastomerDETELS ON Buy_Gold.castomer_id = CastomerDETELS.CastomerCAIVELid INNER JOIN " & vbCrLf &
                                    "bay_goled_mony ON Buy_Gold.inv_id = bay_goled_mony.saryal " & vbCrLf &
                                    "WHERE (Buy_Gold.INV_Actv = 1)"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldBuyShort]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldBuyShort] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = " CREATE VIEW  [ReportGoldBuyShort] AS SELECT   Buy_Gold.castomer_id,  CastomerDETELS.CastomerNAme,  CastomerDETELS.CastomerADr, " & vbCrLf &
                     " CastomerDETELS.CastomerTE,  CastomerDETELS.CastomerNA, " & vbCrLf &
                      " SUM( Buy_Gold.bay_mazan) AS bay_mazan,  bay_goled_mony.total_price,  bay_goled_mony.cach," & vbCrLf &
                     "  bay_goled_mony.kenet,  bay_goled_mony.arabik,  Buy_Gold.inv_id, " & vbCrLf &
                      " bay_goled_mony.date, bay_goled_mony.INV_Actv, cacher.cacher_name" & vbCrLf &
                      " FROM Buy_Gold INNER JOIN" & vbCrLf &
                      "CastomerDETELS ON Buy_Gold.castomer_id = CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                     " bay_goled_mony ON Buy_Gold.inv_id = bay_goled_mony.saryal INNER JOIN" & vbCrLf &
                     " cacher ON bay_goled_mony.Cashier = cacher.cacherID" & vbCrLf &
                     " GROUP BY Buy_Gold.castomer_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr," & vbCrLf &
                     "CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, " & vbCrLf &
                     " bay_goled_mony.arabik, Buy_Gold.inv_id, bay_goled_mony.date, bay_goled_mony.kenet, " & vbCrLf &
                     " bay_goled_mony.cach, bay_goled_mony.total_price, " & vbCrLf &
                      " bay_goled_mony.INV_Actv, cacher.cacher_name" & vbCrLf &
                     " HAVING (bay_goled_mony.INV_Actv = 1)"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDiamondBuyInvoice]') IS NOT NULL " &
                                    "DROP VIEW [ReportDiamondBuyInvoice] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportDiamondBuyInvoice] AS SELECT dbo.Buy_Diamond.castomer_id, " & vbCrLf &
                          "dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, " & vbCrLf &
                          "dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.Buy_Diamond.val_gold, " & vbCrLf &
                          "dbo.Buy_Diamond.GOLD_mezan, dbo.Buy_Diamond.bay_total_price, dbo.Buy_Diamond.DIMO_dep, " & vbCrLf &
                          "dbo.Buy_Diamond.DIM_na9awa, dbo.Buy_Diamond.DIMO_mezan, dbo.Buy_Diamond.ext_coler, " & vbCrLf &
                          "dbo.Buy_Diamond.qult, dbo.Buy_Diamond.sarual, dbo.Buy_Diamond.test_12, " & vbCrLf &
                          "dbo.Buy_Diamond.test_11, dbo.Buy_Diamond.inv_id, dbo.Bay_Diamond_mony.total_price, " & vbCrLf &
                          "dbo.Bay_Diamond_mony.cach, dbo.Bay_Diamond_mony.kenet, dbo.Bay_Diamond_mony.arabik, " & vbCrLf &
                          "dbo.Bay_Diamond_mony.date, dbo.Settings.PIC1, dbo.Buy_Diamond.Notes, " & vbCrLf &
                          "dbo.Bay_Diamond_mony.English, dbo.Buy_Diamond.B_Diamond_id, dbo.Buy_Diamond.Active, " & vbCrLf &
                          "dbo.CastomerDETELS.CastomerID, dbo.CastomerDETELS.CastomerCAIVELid, " & vbCrLf &
                          "dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.Bay_Diamond_mony.bay_id, " & vbCrLf &
                          "dbo.Bay_Diamond_mony.saryal, dbo.Bay_Diamond_mony.Active AS ActiveBayDiamond_mony, " & vbCrLf &
                          "dbo.Bay_Diamond_mony.PayMethod, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, " & vbCrLf &
                          "dbo.cacher.CashierSignature FROM dbo.Buy_Diamond INNER JOIN " & vbCrLf &
                          "dbo.CastomerDETELS ON dbo.Buy_Diamond.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN " & vbCrLf &
                          "dbo.Bay_Diamond_mony ON dbo.Buy_Diamond.inv_id = dbo.Bay_Diamond_mony.saryal LEFT OUTER JOIN " & vbCrLf &
                          "dbo.cacher ON dbo.Buy_Diamond.qult = dbo.cacher.cacher_name LEFT OUTER JOIN " & vbCrLf &
                          "dbo.PayMethod ON dbo.Bay_Diamond_mony.PayMethod = dbo.PayMethod.ID CROSS JOIN " & vbCrLf &
                          "dbo.Settings WHERE (dbo.Buy_Diamond.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [CONVERT-DIMOND_ID] AS " &
                                    "SELECT CONVERT(nvarchar(MAX), DIMOND_ID) AS DIMOND_ID, DIMO_dep, DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, " &
                                    "test_16, test_17, test_18, test_19, test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117, test_118, test_119, CostToSeller, TaxExempt, Cut1, Clarity1, Cut2, Clarity2, Cut3, " &
                                    "Clarity3, IsDiamond1, IsDiamond2, IsDiamond3 " &
                                    "FROM DIMON_detels "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "IF OBJECT_ID('[DIMON_BARICOOD_LEFT]') IS NOT NULL " &
                                    "DROP VIEW [DIMON_BARICOOD_LEFT]"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [dbo].[DIMON_BARICOOD_LEFT] AS SELECT DIMOND_ID, DIMO_dep + SPACE(1) + test_119 AS DIMON_NAME," & vbCrLf &
                                    "DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, test_16, " & vbCrLf &
                                    "test_17, test_18, test_19, test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117," & vbCrLf &
                                    "test_118, test_119, CostToSeller, TaxExempt, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3, IsDiamond1, " & vbCrLf &
                                    "IsDiamond2, IsDiamond3" & vbCrLf &
                                    "FROM dbo.[CONVERT-DIMOND_ID]"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        GlCommand.CommandText = "IF OBJECT_ID('[DIMON_BARICOOD_RIGHT]') IS NOT NULL " &
                                    "DROP VIEW [DIMON_BARICOOD_RIGHT]"
        GlCommand.ExecuteNonQuery()
        Try
            GlCommand.CommandText = "CREATE VIEW [dbo].[DIMON_BARICOOD_RIGHT] AS SELECT DIMOND_ID, DIMO_dep + SPACE(1) + test_119 AS DIMON_NAME," & vbCrLf &
                                    "DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, test_16, " & vbCrLf &
                                    "test_17, test_18, test_19, test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117," & vbCrLf &
                                    "test_118, test_119, CostToSeller, TaxExempt, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3, IsDiamond1, " & vbCrLf &
                                    "IsDiamond2, IsDiamond3" & vbCrLf &
                                    "FROM dbo.[CONVERT-DIMOND_ID]"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        'تحديث استعلام الفواتير واضافة حقل صورة توقيع الكاشير
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[invoce_report]') IS NOT NULL " &
                                    "DROP VIEW [invoce_report]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW  [invoce_report] AS SELECT dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.Castomerid, dbo.selInvoceDetels.ItemID, dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram, dbo.selInvoceDetels.item_gramMade, " & vbCrLf &
                                                 "dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_totalPrice, dbo.selInvoceDetels.item_cantrey, dbo.selInvoceDetels.MetalPrice, " & vbCrLf &
                                                 "dbo.selInvoceDetels.userID, dbo.BAY.TOTAL_mony, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.arbic_tayb, dbo.BAY.balance, dbo.CastomerDETELS.CastomerNAme, " & vbCrLf &
                                                 "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.BAY.staytes, dbo.CastomerDETELS.foto, dbo.selInvoceDetels.invoc_date_time, " & vbCrLf &
                                                 "dbo.FO_min.Gram_valu, dbo.selInvoceDetels.qunt, dbo.selInvoceDetels.nots, dbo.cacher.cacher_name, dbo.selInvoceDetels.date, dbo.BAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, " & vbCrLf &
                                                 "dbo.Settings.PIC1, dbo.selInvoceDetels.item_gramMade * dbo.selInvoceDetels.item_gram AS Total_gramMade, dbo.BAY.English_tayb, dbo.selInvoceDetels.Active, dbo.BAY.Notes, dbo.BAY.PayMethod, " & vbCrLf &
                                                 "dbo.cacher.CashierSignature, dbo.selInvoceDetels.StoneWeight2, dbo.selInvoceDetels.StoneWeight3, dbo.selInvoceDetels.StonePrice2, dbo.selInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, " & vbCrLf &
                                                 "dbo.PayMethod.PayMethodEn, dbo.FO_min.BarCode, dbo.selInvoceDetels.item_desp, dbo.selInvoceDetels.cacher, dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.sroom_name, " & vbCrLf &
                                                 "dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.StoneName1, dbo.selInvoceDetels.StoneColor1, dbo.selInvoceDetels.StoneName2, dbo.selInvoceDetels.StoneColor2, " & vbCrLf &
                                                 "dbo.selInvoceDetels.StoneName3, dbo.selInvoceDetels.StoneColor3, dbo.selInvoceDetels.ID, dbo.selInvoceDetels.StonePriceType1, dbo.selInvoceDetels.StonePriceType2, " & vbCrLf &
                                                 "dbo.selInvoceDetels.StonePriceType3,dbo.selInvoceDetels.GoledKarat, dbo.FO_min.ITEM_IMGE, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, PayMethod_1.PayMethodAr AS PayMethodAr1, " & vbCrLf &
                                                 "PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.BAY.PayMethod1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, dbo.BAY.PayMethod2, " & vbCrLf &
                                                 "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, dbo.BAY.PayMethod3, PayMethod_4.PayMethodAr AS PayMethodAr4, " & vbCrLf &
                                                 "PayMethod_4.PayMethodEn AS PayMethodEn4, dbo.BAY.PayMethod4, dbo.BAY.Bank1, dbo.BAY.Bank2, dbo.BAY.Bank3, dbo.BAY.Bank4 ,dbo.BAY.Active AS ActiveBAY " & vbCrLf &
                                                 "FROM dbo.BAY INNER JOIN" & vbCrLf &
                                                 "dbo.selInvoceDetels ON dbo.BAY.BAY_SARYAL = dbo.selInvoceDetels.invoc_time INNER JOIN" & vbCrLf &
                                                 "dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                                                 "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                                                 "dbo.PayMethod ON dbo.BAY.PayMethod = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                                                 "dbo.PayMethod AS PayMethod_1 ON dbo.BAY.PayMethod1 = PayMethod_1.ID INNER JOIN" & vbCrLf &
                                                 "dbo.PayMethod AS PayMethod_2 ON dbo.BAY.PayMethod2 = PayMethod_2.ID INNER JOIN" & vbCrLf &
                                                 "dbo.PayMethod AS PayMethod_3 ON dbo.BAY.PayMethod3 = PayMethod_3.ID INNER JOIN" & vbCrLf &
                                                 "dbo.PayMethod AS PayMethod_4 ON dbo.BAY.PayMethod4 = PayMethod_4.ID LEFT OUTER JOIN" & vbCrLf &
                                                 "dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode CROSS JOIN" & vbCrLf &
                                                 "dbo.Settings"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [FO_min] SET [Item_Actv] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        'استبدال القيمة الفارغه في حقل التاريخ
        Try
            GlCommand.CommandText = "UPDATE [selInvoceDetels] SET [date] = CaSh WHERE [date] IS NULL"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ''\\\\\\\\\\\UPDATE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        Try
            GlCommand.CommandText = "UPDATE [bay_goled_mony] SET [TIME_INV] = [date] WHERE [TIME_INV] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            'تحديث أرقام العملاء من صفر إلي لايوجد رقم
            GlCommand.CommandText = "UPDATE [CastomerDETELS] SET CastomerTE = N'لايوجد رقم هاتف' WHERE CastomerTE = '0'"
            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try

            GlCommand.CommandText = "UPDATE [Buy_Gold] SET [Item_Des] = N'ــــــــــ' WHERE [Item_Des]  IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "UPDATE [Buy_Gold] SET [INV_Actv] = '1' WHERE [INV_Actv]  IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "UPDATE [bay_goled_mony] SET [INV_Actv] = '1' WHERE [INV_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "UPDATE [Accessories_ITEM] SET [Item_Actv] = '1' WHERE [Item_Actv]  IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [Item_Actv] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [staytes] = '1' WHERE [staytes] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [Item_Actv] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [staytes] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [DIMON_detels] SET [Item_Actv] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        ''''''''''''''''''''''''''''''''''معتصم''''''''''''''''''''''''''''''''''''

        Try
            GlCommand.CommandText = "UPDATE [FO_min] SET [FO_ItemNo] = '0' WHERE [FO_ItemNo] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = " ALTER VIEW [Accessories_ITEM_Available] AS " & vbCrLf &
                                    " SELECT     Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, " & vbCrLf &
                                    " Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom," &
                                    " Accessories_ITEM.Accessories_PIC, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET," &
                                    " Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier" &
                                    " FROM         Accessories_ITEM LEFT OUTER JOIN Accessories_INV" &
                                    " ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID" &
                                    " WHERE     (Accessories_INV.Accessories_INV_ITEM_ID IS NULL) " & vbCrLf &
                                    " OR (Accessories_INV.Accessories_Active = 0)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = " ALTER VIEW [Accessories_ITEMVw] AS" &
                                    " SELECT     AccessoriesID, Accessories_NAME, Accessories_BRAND, Accessories_DESC, Accessories_CAT, Accessories_DEP, Accessories_model_no, Accessories_nom, Accessories_PIC, Accessories_TIME, " & vbCrLf &
                                    " Accessories_DATE_CRE, Accessories_USER_CRET, Accessories_Cost, Accessories_Price, Accessories_Supplier, Accessories_Attachments " & vbCrLf &
                                    " FROM [Accessories_ITEM] "

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesItemAllVw] AS " & vbCrLf &
                                    "SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_CAT, " &
                                    "Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_DESC, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom,  " &
                                    "Accessories_ITEM.Accessories_PIC, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET,  " &
                                    "Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price, [user].user_name, Accessories_ITEM.Accessories_Supplier,  " &
                                    "Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Code, Accessories_ITEM.Accessories_Year, Accessories_ITEM.Item_Actv " &
                                    "FROM  Accessories_ITEM INNER JOIN [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id WHERE (Accessories_ITEM.Item_Actv = 1)"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesItemAvailableVw] AS " &
                                    "SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC,  " &
                                    "Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom,  " &
                                    "Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price,  " &
                                    "[user].user_name, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier,  Accessories_ITEM.Accessories_PIC " &
                                    "FROM Accessories_ITEM INNER JOIN [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id " &
                                    "LEFT OUTER JOIN Accessories_INV ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID " &
                                    "WHERE (Accessories_INV.Accessories_INV_ITEM_ID IS NULL) OR (Accessories_INV.Accessories_Active = 0) "

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesItemSoldVw] AS " & vbCrLf &
                                    " SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, " & vbCrLf &
                                    " Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom, " & vbCrLf &
                                    " Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, [user].user_name, " & vbCrLf &
                                    " COUNT (Accessories_ITEM.AccessoriesID) AS ItemCount, Accessories_ITEM.Accessories_Price, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, " & vbCrLf &
                                    " Accessories_ITEM.Accessories_Supplier " & vbCrLf &
                                    " FROM Accessories_ITEM INNER JOIN " & vbCrLf &
                                    " [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id INNER JOIN" &
                                    " Accessories_INV ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID" &
                                    " GROUP BY Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, " & vbCrLf &
                                    " Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom," &
                                    " Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, [user].user_name," &
                                    " Accessories_ITEM.Accessories_Price, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier" &
                                    " HAVING (Accessories_INV.Accessories_Active = 1)"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesSellDetailed] AS " & vbCrLf &
                                    "SELECT CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, " & vbCrLf &
                                    "Accessories_INV.Accessories_INV_CASTOMER_ID, [user].user_name, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, " &
                                    "Accessories_ITEM.Accessories_DESC, Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, " &
                                    "Accessories_ITEM.Accessories_nom, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET, " &
                                    "Accessories_INV.Accessories_INV_ITEM_ID, Accessories_INV.Accessories_INV_QUNT, Accessories_INV.Accessories_INV_un_price, Accessories_INV.Accessories_INV_total_price, " &
                                    "Accessories_INV.Accessories_INV_DATE, Accessories_INV.Accessories_INV_TIME, Accessories_INV.Accessories_INV_USER, Accessories_INV.Accessories_INV_NO_ID, " &
                                    "Accessories_BAY.Accessories_BAY_SARYAL, Accessories_BAY.Accessories_TOTAL_mony, Accessories_BAY.Accessories_KENT, Accessories_BAY.Accessories_CACH, " &
                                    "Accessories_BAY.Accessories_arbic_tayb, Accessories_BAY.Accessories_balance, Accessories_BAY.Accessories_staytes, Accessories_BAY.Accessories_Casher, " &
                                    "cacher.cacher_name, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier " &
                                    "FROM [user] RIGHT OUTER JOIN Accessories_INV INNER JOIN " &
                                    "Accessories_ITEM ON Accessories_INV.Accessories_INV_ITEM_ID = Accessories_ITEM.AccessoriesID ON " & vbCrLf &
                                    "[user].user_id = Accessories_INV.Accessories_INV_USER LEFT OUTER JOIN " &
                                    "CastomerDETELS ON Accessories_INV.Accessories_INV_CASTOMER_ID = CastomerDETELS.CastomerCAIVELid LEFT OUTER JOIN " &
                                    "cacher RIGHT OUTER JOIN " &
                                    "Accessories_BAY ON cacher.svil_id = Accessories_BAY.Accessories_Casher ON " & vbCrLf &
                                    "Accessories_INV.Accessories_INV_NO_ID = Accessories_BAY.Accessories_BAY_SARYAL " &
                                    "WHERE (Accessories_BAY.Accessories_staytes = 1) AND (Accessories_INV.Accessories_Active = 1)"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesBarCode1] AS " & vbCrLf &
                                    "SELECT AccessoriesID, Accessories_NAME, Accessories_BRAND, Accessories_DESC, " & vbCrLf &
                                    "Accessories_CAT, Accessories_DEP, Accessories_model_no, Accessories_nom, Accessories_Cost, " & vbCrLf &
                                    "Accessories_Price, Accessories_NAME + SPACE(1) + CONVERT(nvarchar, AccessoriesID) AS BarCode_ID1, " & vbCrLf &
                                    "Accessories_Code, Accessories_Year, Accessories_BRAND_SHORT, " & vbCrLf &
                                    "Accessories_Supplier, Accessories_Attachments " & vbCrLf &
                                    " FROM [Accessories_ITEM]"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [AccessoriesBarCode2] AS " & vbCrLf &
                                    "SELECT AccessoriesID, Accessories_NAME, Accessories_BRAND, Accessories_DESC, " & vbCrLf &
                                    "Accessories_CAT, Accessories_DEP, Accessories_model_no, Accessories_nom, Accessories_Cost, " & vbCrLf &
                                    "Accessories_Price, Accessories_NAME + SPACE(1) + CONVERT(nvarchar, AccessoriesID) AS BarCode_ID2, " & vbCrLf &
                                    "Accessories_Code, Accessories_Year, Accessories_BRAND_SHORT, " & vbCrLf &
                                    "Accessories_Supplier, Accessories_Attachments " & vbCrLf &
                                    " FROM [Accessories_ITEM]"

            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldByKarat]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldByKarat] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [ReportGoldByKarat] AS " & vbCrLf &
                                    "SELECT TOP 100 PERCENT (FO_min.Gram_valu), SUM(BAY.KENT) AS KENT, SUM(selInvoceDetels.item_gram) AS item_gram, selInvoceDetels.date, " & vbCrLf &
                                    "SUM(selInvoceDetels.item_GramPrice * selInvoceDetels.item_gram) AS total_price, selInvoceDetels.item_GramPrice " & vbCrLf &
                                    "FROM  selInvoceDetels INNER JOIN " & vbCrLf &
                                    "BAY ON selInvoceDetels.invoc_time = BAY.BAY_SARYAL INNER JOIN " & vbCrLf &
                                    "FO_min ON selInvoceDetels.itemID = FO_min.ID " & vbCrLf &
                                    "GROUP BY FO_min.Gram_valu, selInvoceDetels.date, selInvoceDetels.item_GramPrice " & vbCrLf &
                                    "ORDER BY FO_min.Gram_valu DESC, selInvoceDetels.date DESC"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[for_invoice]') IS NOT NULL " &
                                    "DROP VIEW [for_invoice] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [for_invoice] AS " & vbCrLf &
                                    "SELECT ID, userID, FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, ITEM_IMGE, date_care, BarCode " & vbCrLf &
                                    "FROM FO_min"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try


        Try
            GlCommand.CommandText = "IF OBJECT_ID('[PayInstallmentVw]') IS NOT NULL " &
                                    "DROP VIEW [PayInstallmentVw] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [PayInstallmentVw] AS " & vbCrLf &
                                    "SELECT PayInstallment.ID, PayInstallment.InvoiceNo, PayInstallment.InvoiceType, PayInstallment.PayPrice, PayInstallment.KNET, PayInstallment.CASH, " & vbCrLf &
                                    "PayInstallment.PayDateTime, PayInstallment.PayMethod, PayMethod.PayMethodAr, PayMethod.PayMethodEn, cacher.cacher_name, PayInstallment.Item_Actv " & vbCrLf &
                                    "FROM PayInstallment INNER JOIN " & vbCrLf &
                                    "PayMethod ON PayInstallment.PayMethod = PayMethod.ID INNER JOIN " & vbCrLf &
                                    "cacher ON PayInstallment.Cashier = cacher.cacherID " & vbCrLf &
                                    "WHERE (PayInstallment.Item_Actv = N'1') "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldProfitPerPurchaseCost]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldProfitPerPurchaseCost] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [ReportGoldProfitPerPurchaseCost] AS " & vbCrLf &
                                    "SELECT selInvoceDetels.itemID, selInvoceDetels.item_name, selInvoceDetels.item_totalPrice AS GoldSellPrice, selInvoceDetels.invoc_time AS InvoiceNo, " & vbCrLf &
                                    "selInvoceDetels.sroom_name, selInvoceDetels.date, selInvoceDetels.item_GramPrice, selInvoceDetels.item_gram AS GoldWeight, cacher.cacher_name, FO_min.Gram_valu, " & vbCrLf &
                                    "selInvoceDetels.item_totalPrice + selInvoceDetels.item_extrasPRICE + selInvoceDetels.StonePrice2 + selInvoceDetels.StonePrice3 AS TotalSellPrice, " & vbCrLf &
                                    "FO_min.FO_GramPrice AS Supplier, FO_min.FO_totalPrice AS TotalPurcaseCost, FO_min.BarCode " & vbCrLf &
                                    "FROM selInvoceDetels INNER JOIN FO_min ON selInvoceDetels.itemID = FO_min.ID LEFT OUTER JOIN cacher ON selInvoceDetels.cacher = cacher.svil_id " & vbCrLf &
                                    "WHERE (selInvoceDetels.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldSellDetailed]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldSellDetailed] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportGoldSellDetailed] AS SELECT dbo.selInvoceDetels.Castomerid, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.item_totalPrice, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_extrasPRICE, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_gramMade, dbo.selInvoceDetels.item_gram, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_desp, " & vbCrLf &
                                    "dbo.selInvoceDetels.invoc_date_time, " & vbCrLf &
                                    "dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.qunt, " & vbCrLf &
                                    "dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.nots, dbo.selInvoceDetels.date AS date_finel, dbo.CastomerDETELS.CastomerNAme, " & vbCrLf &
                                    "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                                    "dbo.FO_min.Gram_valu, dbo.FO_min.ID, " & vbCrLf &
                                    "dbo.selInvoceDetels.item_gramMade * dbo.selInvoceDetels.item_gram AS Total_gramMade, " & vbCrLf &
                                    "dbo.cacher.cacher_name, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_price, dbo.FO_min.BarCode, " & vbCrLf &
                                    "dbo.BAY.Active " & vbCrLf &
                                    "FROM dbo.selInvoceDetels INNER JOIN " & vbCrLf &
                                    "dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN " & vbCrLf &
                                    "dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN " & vbCrLf &
                                    "dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode INNER JOIN " & vbCrLf &
                                    "dbo.BAY ON dbo.selInvoceDetels.invoc_time = dbo.BAY.BAY_SARYAL " & vbCrLf &
                                    "WHERE (dbo.selInvoceDetels.Active = 1) AND (dbo.BAY.Active = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[for_dimon_inv]') IS NOT NULL " &
                                    "DROP VIEW [for_dimon_inv] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [for_dimon_inv] AS " & vbCrLf &
                                    "SELECT dimon_invce.castomr_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE AS d, CastomerDETELS.CastomerNA, " & vbCrLf &
                                    "CastomerDETELS.foto, dimon_invce.dimo_id, dimon_invce.descont, dimon_invce.total, dimon_invce.ar_taype, dimon_invce.DIMO_Type, dimon_invce.DIM_na9awa, " & vbCrLf &
                                    "dimon_invce.DIMO_mezan, dimon_invce.DIMO_coler, dimon_invce.DIMO_qult, dimon_invce.sarual, dimon_invce.val_gold, dimon_invce.GOLD_mezan, " & vbCrLf &
                                    "dimon_invce.user_creted, dimon_invce.date_creted, dimon_invce.time, dimon_invce.dim_foto, dimon_invce.test_13, dimon_invce.test_14, dimon_invce.test_15, " & vbCrLf &
                                    "dimon_invce.test_16, dimon_invce.test_17, dimon_invce.test_18, dimon_invce.test_19, dimon_invce.test_110, dimon_invce.test_111, dimon_invce.test_112, " & vbCrLf &
                                    "dimon_invce.test_116, dimon_invce.test_117, dimon_invce.test_118, dimon_invce.test_119, dimon_invce.notes, CastomerDETELS.CastomerTE " & vbCrLf &
                                    "FROM CastomerDETELS INNER JOIN " & vbCrLf &
                                    "dimon_invce ON CastomerDETELS.CastomerCAIVELid = dimon_invce.castomr_id"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try



        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDiamondSellDetailed]') IS NOT NULL " &
                                    "DROP VIEW [ReportDiamondSellDetailed] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportDiamondSellDetailed] AS SELECT TOP (100) PERCENT  " & vbCrLf &
                      "dbo.dimon_invce.castomr_id, dbo.CastomerDETELS.CastomerNAme,  " & vbCrLf &
                      "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerNA, dbo.dimon_invce.descont,  " & vbCrLf &
                      "dbo.dimon_invce.total, dbo.dimon_invce.ar_taype, dbo.dimon_invce.DIMO_Type,  " & vbCrLf &
                      "dbo.dimon_invce.DIM_na9awa, dbo.dimon_invce.DIMO_mezan, dbo.dimon_invce.DIMO_coler,  " & vbCrLf &
                      "dbo.dimon_invce.DIMO_qult, dbo.dimon_invce.sarual, dbo.dimon_invce.val_gold,  " & vbCrLf &
                      "dbo.dimon_invce.GOLD_mezan, dbo.dimon_invce.user_creted, dbo.dimon_invce.date_creted,  " & vbCrLf &
                      "dbo.dimon_invce.time, dbo.cacher.cacher_name, dbo.dimon_bay.BAY_SARYAL,  " & vbCrLf &
                      "dbo.dimon_bay.TOTAL_mony, dbo.dimon_bay.CACH AS dimon_bay_cach, dbo.dimon_bay.KENT,  " & vbCrLf &
                      "dbo.dimon_bay.balance, dbo.dimon_bay.staytes, dbo.dimon_invce.dimo_id,  " & vbCrLf &
                      "dbo.DIMON_detels.test_12, dbo.cacher.svil_id, dbo.dimon_invce.notes, dbo.CastomerDETELS.CastomerTE,  " & vbCrLf &
                      "dbo.dimon_invce.test_13, dbo.dimon_invce.test_14, dbo.dimon_invce.test_15,  " & vbCrLf &
                      "dbo.dimon_invce.test_16, dbo.dimon_invce.test_17, dbo.dimon_invce.test_18, dbo.dimon_invce.test_19,  " & vbCrLf &
                      "dbo.dimon_invce.test_110, dbo.dimon_invce.test_111, dbo.dimon_invce.test_112,  " & vbCrLf &
                      "dbo.dimon_invce.test_116, dbo.dimon_invce.test_117, dbo.dimon_invce.test_118, dbo.dimon_invce.test_119,  " & vbCrLf &
                      "dbo.dimon_bay.Item_Actv, dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerNameEn,  " & vbCrLf &
                      "dbo.dimon_invce.Cut1, dbo.dimon_invce.Clarity1, dbo.dimon_invce.Cut2,  " & vbCrLf &
                      "dbo.dimon_invce.Clarity2, dbo.dimon_invce.Cut3, dbo.dimon_invce.Clarity3,  " & vbCrLf &
                      "dbo.dimon_invce.IsDiamond1, dbo.dimon_invce.IsDiamond2, dbo.dimon_invce.IsDiamond3, dbo.dimon_invce.dim_foto,  " & vbCrLf &
                      "dbo.dimon_invce.GramPrice, dbo.dimon_invce.SoldItem,dbo.dimon_invce.CertificateNumber " & vbCrLf &
                      "FROM dbo.dimon_invce INNER JOIN  " & vbCrLf &
                      "dbo.CastomerDETELS ON dbo.dimon_invce.castomr_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN  " & vbCrLf &
                      "dbo.dimon_bay ON dbo.dimon_invce.descont = dbo.dimon_bay.BAY_SARYAL LEFT OUTER JOIN  " & vbCrLf &
                      "dbo.DIMON_detels ON dbo.dimon_invce.dimo_id = dbo.DIMON_detels.test_119 LEFT OUTER JOIN  " & vbCrLf &
                      "dbo.cacher ON dbo.dimon_invce.test_118 = dbo.cacher.svil_id  " & vbCrLf &
                      "WHERE (dbo.dimon_invce.Item_Actv = 1) AND (dbo.dimon_bay.Item_Actv = 1)  " & vbCrLf &
                      "ORDER BY LEN(dbo.dimon_invce.date_creted)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportDiamondSellShort]') IS NOT NULL " &
                                    "DROP VIEW [ReportDiamondSellShort] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportDiamondSellShort] AS SELECT castomr_id, CastomerNAme," & vbCrLf &
                                    "CastomerTE, SUM(DIMO_mezan) AS DIMO_mezan, SUM(GOLD_mezan) AS GOLD_mezan, date_creted," & vbCrLf &
                                    "cacher_name, KENT, TOTAL_mony, dimon_bay_cach AS CACH, BAY_SARYAL, SUM(test_116) " & vbCrLf &
                                    "AS test_116, SUM(test_13) AS test_13, SUM(test_16) AS test_16, SUM(test_19) AS test_19," & vbCrLf &
                                    "CastomerADr, CastomerNA, descont, total, ar_taype, DIMO_Type, DIM_na9awa, DIMO_coler," & vbCrLf &
                                    "DIMO_qult, sarual, val_gold, time, balance, " & vbCrLf &
                                    "staytes, test_12, svil_id, notes, test_14, test_15, test_17, test_18, test_110," & vbCrLf &
                                    "test_111, test_112, test_117, test_118, test_119, arbic_tayb" & vbCrLf &
                                    "FROM dbo.for_print_dimon_finel_short" & vbCrLf &
                                    "GROUP BY castomr_id, CastomerNAme, CastomerTE, date_creted, cacher_name," & vbCrLf &
                                    "BAY_SARYAL, KENT, TOTAL_mony, dimon_bay_cach, CastomerADr, CastomerNA, descont," & vbCrLf &
                                    "total, ar_taype, DIMO_Type, DIM_na9awa, DIMO_coler, " & vbCrLf &
                                    "DIMO_qult, sarual, val_gold, time, balance, staytes, test_12, svil_id, notes," & vbCrLf &
                                    "test_14, test_15, test_17, test_18, test_110, test_111, test_112, test_117, test_118, test_119, arbic_tayb"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try

            GlCommand.CommandText = "ALTER VIEW [convart_id] AS " &
                                    "SELECT CONVERT(nvarchar(MAX), ID) AS item_id, FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, " &
                                    "Gram_valu, userID, FO_ItemNo, BarCode, StoneWeight2, StoneName2, StoneWeight3, StoneName3 " &
                                    "From dbo.FO_min"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "ALTER VIEW [Print_Parcood1] AS " &
                                    "SELECT item_id AS ID, userID, FO_name + SPACE(1) + item_id AS FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, FO_ItemNo, " &
                                    "BarCode, StoneWeight2, StoneName2, StoneWeight3, StoneName3 " &
                                    "FROM convart_id "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "ALTER VIEW [Print_Parcood2] AS " &
                                    "SELECT item_id AS ID, userID, FO_name + SPACE(1) + item_id AS FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, FO_ItemNo, " &
                                    "BarCode, StoneWeight2, StoneName2, StoneWeight3, StoneName3 " &
                                    "FROM convart_id "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldSellShort]') IS NOT NULL " &
                                   "DROP VIEW [ReportGoldSellShort] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportGoldSellShort] AS SELECT TOP (100) PERCENT dbo.CastomerDETELS.CastomerNAme, " & vbCrLf &
                                   "dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerTE, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.TOTAL_mony, " & vbCrLf &
                                   "dbo.BAY.BAY_SARYAL, dbo.selInvoceDetels.Cash, " & vbCrLf &
                                   "SUM(dbo.selInvoceDetels.item_gram) AS item_gram, dbo.selInvoceDetels.date, dbo.selInvoceDetels.Active " & vbCrLf &
                                   "FROM dbo.CastomerDETELS INNER JOIN " & vbCrLf &
                                   "dbo.selInvoceDetels ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.selInvoceDetels.Castomerid INNER JOIN " & vbCrLf &
                                   "dbo.BAY ON dbo.selInvoceDetels.invoc_time = dbo.BAY.BAY_SARYAL INNER JOIN " & vbCrLf &
                                   "dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode " & vbCrLf &
                                   "WHERE(dbo.FO_min.Gram_valu <= N'24') OR (dbo.BAY.Active = 1) " & vbCrLf &
                                   "GROUP BY dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerCAIVELid, " & vbCrLf &
                                   "dbo.CastomerDETELS.CastomerTE, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.TOTAL_mony, " & vbCrLf &
                                   "dbo.BAY.BAY_SARYAL, dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.date, dbo.selInvoceDetels.Active " & vbCrLf &
                                   "HAVING(dbo.selInvoceDetels.Active = 1)" & vbCrLf &
                                   "ORDER BY dbo.selInvoceDetels.date"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "ALTER VIEW [GoldSilverAvailable] AS " &
                                    "SELECT FO_min.ID, FO_min.userID, FO_min.FO_name, FO_min.FO_desp, FO_min.FO_price, FO_min.FO_GramPrice, FO_min.FO_gram, FO_min.FO_gramMade,  " &
                                    "FO_min.FO_made, FO_min.FO_extras, FO_min.FO_totalPrice, FO_min.Gram_valu, FO_min.ITEM_IMGE, FO_min.date_care, FO_min.FO_ItemNo,  " &
                                    "FO_min.StoneColor1, FO_min.StonePrice1, FO_min.StoneWeight2, FO_min.StoneName2, FO_min.StoneColor2, FO_min.StonePrice2, FO_min.StoneWeight3,  " &
                                    "FO_min.StoneName3, FO_min.StoneColor3, FO_min.StonePrice3, FO_min.Qty, FO_min.BarCode, FO_min.Item_Actv " &
                                    "FROM FO_min LEFT OUTER JOIN " &
                                    "selInvoceDetels ON FO_min.ID = selInvoceDetels.itemID " &
                                    "WHERE (selInvoceDetels.itemID IS NULL) OR " &
                                    "(selInvoceDetels.Active = 0) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ITEM_Sold]') IS NOT NULL " &
                                    "DROP VIEW [ITEM_Sold] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "IF OBJECT_ID('[ITEM_Available]') IS NOT NULL " &
                                    "DROP VIEW [ITEM_Available] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try

            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldItemSold]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldItemSold] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = " CREATE VIEW [dbo].[ReportGoldItemSold] AS SELECT  dbo.FO_min.ID, COUNT(dbo.FO_min.ID) AS ItemCount, " & vbCrLf &
                                    " dbo.FO_min.userID, dbo.FO_min.FO_name, dbo.FO_min.FO_desp, dbo.FO_min.FO_price AS Stone, dbo.FO_min.FO_GramPrice AS Supplier, " & vbCrLf &
                                    " dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade, " & vbCrLf &
                                    " dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.selInvoceDetels.date AS date_care, " & vbCrLf &
                                    " dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram AS FO_TotalgramMade, dbo.FO_min.FO_desp * dbo.FO_min.FO_gram AS FO_TotaldespMade, dbo.selInvoceDetels.Active, " & vbCrLf &
                                    " dbo.FO_min.BarCode " & vbCrLf &
                                    " FROM dbo.FO_min INNER JOIN " & vbCrLf &
                                    " dbo.selInvoceDetels ON dbo.FO_min.BarCode = dbo.selInvoceDetels.ItemID " & vbCrLf &
                                    " GROUP BY dbo.FO_min.ID, dbo.FO_min.userID, dbo.FO_min.FO_name, " & vbCrLf &
                                    " dbo.FO_min.FO_desp, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade, dbo.FO_min.FO_made, dbo.FO_min.FO_extras, " & vbCrLf &
                                    " dbo.FO_min.FO_totalPrice, " & vbCrLf &
                                    " dbo.FO_min.Gram_valu, dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, " & vbCrLf &
                                    " dbo.selInvoceDetels.Active, dbo.FO_min.BarCode, dbo.selInvoceDetels.date " & vbCrLf &
                                    " HAVING (dbo.selInvoceDetels.Active = 1) "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportGoldItemAvailable]') IS NOT NULL " &
                                    "DROP VIEW [ReportGoldItemAvailable] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [dbo].[ReportGoldItemAvailable] AS SELECT DISTINCT  dbo.FO_min.ID, dbo.FO_min.userID,  " & vbCrLf &
                                    "dbo.FO_min.FO_name, dbo.FO_min.FO_desp, dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade,  " & vbCrLf &
                                    "dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.FO_min.date_care,  " & vbCrLf &
                                    "dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram AS FO_TotalgramMade, dbo.FO_min.FO_desp * dbo.FO_min.FO_gram AS FO_TotaldespMade, dbo.FO_min.BarCode " & vbCrLf &
                                   "FROM dbo.FO_min LEFT OUTER JOIN " & vbCrLf &
                                   "dbo.selInvoceDetels ON dbo.FO_min.BarCode = dbo.selInvoceDetels.ItemID " & vbCrLf &
                                   "WHERE (dbo.selInvoceDetels.ItemID IS NULL) OR " & vbCrLf &
                                  "(dbo.selInvoceDetels.ItemID NOT IN " & vbCrLf &
                                   "(SELECT     ItemID " & vbCrLf &
                                   "FROM  dbo.selInvoceDetels AS selInvoceDetels_1 " & vbCrLf &
                                  "WHERE      (Active = 1))) AND (dbo.selInvoceDetels.Active = 0) " & vbCrLf &
                                 "GROUP BY dbo.FO_min.ID, dbo.FO_min.userID, dbo.FO_min.FO_name, dbo.FO_min.FO_desp, " & vbCrLf &
                                  " dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade,  " & vbCrLf &
                                  "dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.FO_min.date_care, dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram,  " & vbCrLf &
                                     "dbo.FO_min.FO_desp * dbo.FO_min.FO_gram, dbo.FO_min.BarCode, dbo.FO_min.Item_Actv " & vbCrLf &
                                   "HAVING  (dbo.FO_min.Item_Actv > 0)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[report_for_kenat_and_cache]') IS NOT NULL " &
                                    "DROP VIEW [report_for_kenat_and_cache] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[gram_val_report]') IS NOT NULL " &
                                    "DROP VIEW [gram_val_report] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[Accessories_View_prinet_invoce]') IS NOT NULL " &
                                    "DROP VIEW [Accessories_View_prinet_invoce] "
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[Accessories_View_prinet_invoce] AS SELECT " & vbCrLf &
"dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, " & vbCrLf &
"dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, " & vbCrLf &
"dbo.CastomerDETELS.Signature, dbo.Accessories_INV.Accessories_INV_CASTOMER_ID, " & vbCrLf &
"dbo.[user].user_name, dbo.Accessories_ITEM.Accessories_NAME, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_BRAND, dbo.Accessories_ITEM.Accessories_DESC, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_CAT, dbo.Accessories_ITEM.Accessories_DEP, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_model_no, dbo.Accessories_ITEM.Accessories_nom, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_PIC, dbo.Accessories_ITEM.Accessories_TIME, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_DATE_CRE, dbo.Accessories_ITEM.Accessories_USER_CRET, " & vbCrLf &
"dbo.Accessories_INV.Accessories_INV_ITEM_ID, dbo.Accessories_INV.Accessories_INV_QUNT, " & vbCrLf &
"dbo.Accessories_INV.Accessories_INV_un_price, dbo.Accessories_INV.Accessories_INV_total_price, " & vbCrLf &
"dbo.Accessories_INV.Accessories_INV_DATE, dbo.Accessories_INV.Accessories_INV_TIME, " & vbCrLf &
"dbo.Accessories_INV.Accessories_INV_USER, dbo.Accessories_INV.Accessories_INV_NO_ID, " & vbCrLf &
"dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.Accessories_BAY.Accessories_TOTAL_mony, " & vbCrLf &
"dbo.Accessories_BAY.Accessories_KENT, dbo.Accessories_BAY.Accessories_CACH, dbo.Accessories_BAY.Accessories_arbic_tayb, dbo.Accessories_BAY.Accessories_balance, " & vbCrLf &
"dbo.Accessories_BAY.Accessories_staytes, dbo.Accessories_BAY.Accessories_Casher, dbo.cacher.cacher_name, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerCAIVELid, " & vbCrLf &
"dbo.Accessories_BAY.Accessories_Active, dbo.Accessories_BAY.Accessories_Notes, dbo.Accessories_BAY.Accessories_PayMethod, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, " & vbCrLf &
"dbo.Accessories_ITEM.Accessories_Year, dbo.Accessories_ITEM.Accessories_Attachments, dbo.cacher.CashierSignature, dbo.Accessories_INV.AccessoriesInvoceDESC, " & vbCrLf &
"dbo.Accessories_INV.AccessoriesBrand_ID, dbo.Accessories_INV.AccessoriesGUARRANTYYEAR, dbo.Accessories_INV.AccessoriesType_ID " & vbCrLf &
"FROM dbo.PayMethod INNER JOIN " & vbCrLf &
"dbo.Accessories_BAY ON dbo.PayMethod.ID = dbo.Accessories_BAY.Accessories_PayMethod RIGHT OUTER JOIN" & vbCrLf &
"dbo.Accessories_INV INNER JOIN" & vbCrLf &
"dbo.Accessories_ITEM ON dbo.Accessories_INV.Accessories_INV_ITEM_ID = dbo.Accessories_ITEM.AccessoriesID ON " & vbCrLf &
"dbo.Accessories_BAY.Accessories_BAY_SARYAL = dbo.Accessories_INV.Accessories_INV_NO_ID LEFT OUTER JOIN" & vbCrLf &
"dbo.cacher ON dbo.Accessories_BAY.Accessories_Casher = dbo.cacher.svil_id LEFT OUTER JOIN" & vbCrLf &
"dbo.[user] ON dbo.Accessories_INV.Accessories_INV_USER = dbo.[user].user_id LEFT OUTER JOIN" & vbCrLf &
"dbo.CastomerDETELS ON dbo.Accessories_INV.Accessories_INV_CASTOMER_ID = dbo.CastomerDETELS.CastomerCAIVELid" & vbCrLf &
"WHERE(dbo.Accessories_BAY.Accessories_staytes = 1)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "IF OBJECT_ID('[Accessories_ProfitVw]') IS NOT NULL " &
                                    "DROP VIEW [Accessories_ProfitVw] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [Accessories_ProfitVw] AS " & vbCrLf &
                                    "SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC,  " & vbCrLf &
                                    "Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_INV.Accessories_INV_total_price, Accessories_INV.Accessories_INV_DATE,  " & vbCrLf &
                                    "Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Supplier, Accessories_INV.Accessories_INV_NO_ID " & vbCrLf &
                                    "FROM Accessories_ITEM INNER JOIN Accessories_INV " & vbCrLf &
                                    "ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID ('[bay_gold_id_filter]') IS NOT NULL " & vbCrLf &
                                    "DROP VIEW [bay_gold_id_filter] "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF OBJECT_ID('[ReportSilverSellShort]') IS NOT NULL " &
                                    "DROP VIEW [ReportSilverSellShort] "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "CREATE VIEW [ReportSilverSellShort] AS " & vbCrLf &
                                    "SELECT TOP (100) PERCENT CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerCAIVELid, CastomerDETELS.CastomerTE, BAY.KENT, BAY.CACH, BAY.TOTAL_mony,  " & vbCrLf &
                                    "BAY.BAY_SARYAL, selInvoceDetels.Cash, SUM(selInvoceDetels.item_gram) AS item_gram, selInvoceDetels.date " & vbCrLf &
                                    "FROM CastomerDETELS INNER JOIN selInvoceDetels ON CastomerDETELS.CastomerCAIVELid = selInvoceDetels.Castomerid INNER JOIN " & vbCrLf &
                                    "BAY ON selInvoceDetels.invoc_time = BAY.BAY_SARYAL INNER JOIN " & vbCrLf &
                                    "FO_min ON selInvoceDetels.itemID = FO_min.ID " & vbCrLf &
                                    "WHERE (BAY.Active = 1) AND (FO_min.Gram_valu >= N'700') " & vbCrLf &
                                    "GROUP BY CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerCAIVELid, CastomerDETELS.CastomerTE, BAY.KENT, BAY.CACH, BAY.TOTAL_mony,  " & vbCrLf &
                                    "BAY.BAY_SARYAL, selInvoceDetels.Cash, selInvoceDetels.date ORDER BY selInvoceDetels.date"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [R_CodeValue_U] = N'0' WHERE [R_CodeValue_U] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [R_CodeValue_D] = N'0' WHERE [R_CodeValue_D] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [R_CodeText_U] = N'0' WHERE [R_CodeText_U] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [R_CodeText_D] = N'0' WHERE [R_CodeText_D] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [L_CodeValue_U] = N'0' WHERE [L_CodeValue_U] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [L_CodeValue_D] = N'0' WHERE [L_CodeValue_D] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [L_CodeText_U] = N'0' WHERE [L_CodeText_U] IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE [CONFI_barcood] SET  [L_CodeText_D] = N'0' WHERE [L_CodeText_D] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [PayMethod]")
            If dt1.Rows.Count = 0 Then
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'بنكي',N'Bank','0')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'كي نت',N'K-NET','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'ماستر',N'Master Card','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'فيزا',N'Visa','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'رابط',N'Link','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'تحويل بنكي',N'Bank Transfer','1')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [PayMethod] (PayMethodAr , PayMethodEn , Active) VALUES (N'شيك',N'Cheque','1')"
                GlCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod] = N'1' WHERE PayMethod = N'0'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [StoneColor]")
            If dt1.Rows.Count = 0 Then
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'أحمر')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'أخضر')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'أزرق')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'أصفر')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'Red')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'Green')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'Blue')"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "INSERT INTO [StoneColor] (StoneColor) VALUES (N'Yellow')"
                GlCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [DIMON_detels] SET [test_117] = N'1' WHERE [test_117] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [staytes] = N'0' WHERE [staytes] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [Fo_min] SET [Qty] = '1' WHERE [Qty] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [EXTR_NAME] SET  [AsGold] = '0' WHERE [AsGold] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [GramPrice] = '28' WHERE [GramPrice] = '0'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "IF NOT EXISTS ( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'DIMON_detels' AND COLUMN_NAME = 'DIMO_mezan')" & vbCrLf &
                                "BEGIN" & vbCrLf &
                                "ALTER TABLE [DIMON_detels] ADD [DIMO_mezan] decimal(18, 3) NULL" & vbCrLf &
                                "End"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "If OBJECT_ID('[ViwSndToCustomer]') IS NOT NULL " & vbCrLf &
              "DROP VIEW [ViwSndToCustomer]"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "CREATE VIEW [dbo].[ViwSndToCustomer] AS" & vbCrLf &
                       "SELECT TOP (100) PERCENT dbo.SndToCustomer.Id, dbo.SndToCustomer.SndNumber, dbo.SndToCustomer.Amount, dbo.SndToCustomer.Cash, dbo.SndToCustomer.Kent, dbo.SndToCustomer.Date_, " & vbCrLf &
                      "dbo.SndToCustomer.Time_, dbo.SndToCustomer.Note_, dbo.SndToCustomer.NumToWorld_AR, dbo.SndToCustomer.NumToWorld_EN, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, " & vbCrLf &
                      "dbo.SndToCustomer.Activite, dbo.cacher.cacher_name, dbo.[user].user_name, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, " & vbCrLf &
                      "dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, " & vbCrLf &
                      "dbo.CastomerDETELS.CastomerCAIVELid, dbo.SndToCustomer.CompName, dbo.TBBondType.BondTypeArName, dbo.TBBondType.BondTypeEnName, dbo.SndToCustomer.TypeTransaction, " & vbCrLf &
                      "PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_1.PayMethodEn AS PayMethodEn1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, " & vbCrLf &
                      "PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, " & vbCrLf &
                      "dbo.SndToCustomer.Bank1, dbo.SndToCustomer.Bank2, dbo.SndToCustomer.Bank3, dbo.SndToCustomer.Bank4, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, " & vbCrLf &
                      "dbo.comp_inform.comp_note1" & vbCrLf &
                      "FROM dbo.SndToCustomer INNER JOIN" & vbCrLf &
                      "dbo.PayMethod ON dbo.SndToCustomer.PayMID = dbo.PayMethod.ID INNER JOIN" & vbCrLf &
                      "dbo.CastomerDETELS ON dbo.SndToCustomer.civilid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN" & vbCrLf &
                      "dbo.cacher ON dbo.SndToCustomer.Casher = dbo.cacher.svil_id INNER JOIN" & vbCrLf &
                      "dbo.[user] ON dbo.SndToCustomer.UserId = dbo.[user].user_id INNER JOIN" & vbCrLf &
                      "dbo.TBBondType ON dbo.SndToCustomer.SndType = dbo.TBBondType.BondTypeID INNER JOIN" & vbCrLf &
                      "dbo.PayMethod AS PayMethod_1 ON dbo.SndToCustomer.PayMethod1 = PayMethod_1.ID INNER JOIN" & vbCrLf &
                      "dbo.PayMethod AS PayMethod_2 ON dbo.SndToCustomer.PayMethod2 = PayMethod_2.ID INNER JOIN" & vbCrLf &
                      "dbo.PayMethod AS PayMethod_3 ON dbo.SndToCustomer.PayMethod3 = PayMethod_3.ID INNER JOIN" & vbCrLf &
                      "dbo.PayMethod AS PayMethod_4 ON dbo.SndToCustomer.PayMethod4 = PayMethod_4.ID CROSS JOIN" & vbCrLf &
                      "dbo.comp_inform" & vbCrLf &
                      "WHERE (dbo.SndToCustomer.Activite = 1)" & vbCrLf &
                      "ORDER BY dbo.SndToCustomer.Id, dbo.SndToCustomer.Date_"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [BAY] SET [KENT] = '0' WHERE [KENT] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [CACH] = '0' WHERE [CACH] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [KENT] = '0' WHERE [KENT] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_bay] SET [CACH] = '0' WHERE [CACH] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [selInvoceDetels] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [FO_min] SET [BarCode] = [ID] WHERE [BarCode] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Buy_Diamond] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Bay_Diamond_mony] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Bay_Diamond_mony] SET [PayMethod] = '1' WHERE [PayMethod] IS NULL"
            GlCommand.ExecuteNonQuery()
            Try
                GlCommand.CommandText = "DELETE FROM [COMPANY_BAY_DETELS] WHERE [COMP_NAME_SHORT]='' OR  [COMP_NAME]='' OR [COMP_NAME_SHORT] IS NULL OR  [COMP_NAME] IS NULL"
                GlCommand.ExecuteNonQuery()
            Catch ex As Exception
                RecordRrrors(DescriptionRrrors:=FailMessages)
            End Try
            Try
                GlCommand.CommandText = "UPDATE [FO_min] SET [FO_GramPrice] = (SELECT [COMP_NAME_SHORT] FROM [COMPANY_BAY_DETELS] WHERE [COMP_NAME] = [FO_min].[FO_GramPrice])"
                GlCommand.ExecuteNonQuery()
            Catch ex As Exception
                RecordRrrors(DescriptionRrrors:=FailMessages)
            End Try

        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE BAY SET NOTES = (SELECT TOP 1 [nots] FROM [SelinvoceDetels] WHERE [invoc_time] = [BAY].[BAY_Saryal] AND [nots] IS NOT NULL ORDER BY [SelinvoceDetels].[ID] DESC) WHERE [Notes] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod] = '0' WHERE [PayMethod] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_bay]  SET [balance] = [TOTAL_mony]-[KENT] -[CACH] UPDATE [dimon_bay]  SET staytes='1' WHERE [balance]<>'0.00'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "ALTER TABLE [bay_goled_mony] ALTER COLUMN [PayMethod] nvarchar(50)"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText = "UPDATE Buy_Gold SET AddToItem = 0 WHERE AddToItem IS NULL"
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE Buy_Gold SET GoldCaret999 = '995' WHERE GoldCaret999 IS NULL "
            GlCommand.ExecuteNonQuery()

            GlCommand.CommandText = "UPDATE g SET g.GoldWeight999 = CAST(g.bay_mazan AS DECIMAL(18,6))* ((1000.0 / 24.0)* CAST(g.bay_val AS DECIMAL(18,6)))" & vbCrLf &
                                    "/NULLIF(CAST(g.GoldCaret999 AS DECIMAL(18,6)), 0)FROM Buy_Gold AS g WHERE g.GoldWeight999 IS NULL AND ISNUMERIC(g.bay_mazan)= 1" & vbCrLf &
                                    "AND ISNUMERIC(g.bay_val) = 1 AND ISNUMERIC(g.GoldCaret999) = 1;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText =
                                  "IF COL_LENGTH('dbo.comp_inform', 'MarginTop') IS NULL " & vbCrLf &
                                  "BEGIN ALTER TABLE dbo.comp_inform ADD MarginTop DECIMAL(10,2) NOT NULL CONSTRAINT DF_comp_inform_MarginTop DEFAULT 0 END;" & vbCrLf &
                                  "IF COL_LENGTH('dbo.comp_inform', 'MarginBottom') IS NULL " & vbCrLf &
                                  "BEGIN ALTER TABLE dbo.comp_inform ADD MarginBottom DECIMAL(10,2) NOT NULL CONSTRAINT DF_comp_inform_MarginBottom DEFAULT 0 END;" & vbCrLf &
                                  "IF COL_LENGTH('dbo.comp_inform', 'MarginLeft') IS NULL " & vbCrLf &
                                  "BEGIN ALTER TABLE dbo.comp_inform ADD MarginLeft DECIMAL(10,2) NOT NULL CONSTRAINT DF_comp_inform_MarginLeft DEFAULT 0 END;" & vbCrLf &
                                  "IF COL_LENGTH('dbo.comp_inform', 'MarginRight') IS NULL " & vbCrLf &
                                  "BEGIN ALTER TABLE dbo.comp_inform ADD MarginRight DECIMAL(10,2) NOT NULL CONSTRAINT DF_comp_inform_MarginRight DEFAULT 0 END;"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try

        Try
            GlCommand.CommandText =
        "IF COL_LENGTH('dbo.comp_inform', 'AuthKey') IS NULL " & vbCrLf &
        "BEGIN " & vbCrLf &
        "ALTER TABLE dbo.comp_inform ADD AuthKey NVARCHAR(255) NOT NULL CONSTRAINT DF_comp_inform_AuthKey DEFAULT '' " & vbCrLf &
        "END;" & vbCrLf &
        "IF COL_LENGTH('dbo.comp_inform', 'AppKey') IS NULL " & vbCrLf &
        "BEGIN " & vbCrLf &
        "ALTER TABLE dbo.comp_inform ADD AppKey NVARCHAR(255) NOT NULL CONSTRAINT DF_comp_inform_AppKey DEFAULT '' " & vbCrLf &
        "END;" & vbCrLf &
        "IF COL_LENGTH('dbo.comp_inform', 'UUID') IS NULL " & vbCrLf &
        "BEGIN " & vbCrLf &
        "ALTER TABLE dbo.comp_inform ADD UUID NVARCHAR(100) NOT NULL CONSTRAINT DF_comp_inform_UUID DEFAULT '' " & vbCrLf &
        "END;"

            GlCommand.ExecuteNonQuery()

        Catch ex As Exception
            FailMessages &= ex.Message & vbCrLf
        End Try





        If FailMessages.Trim = "" Then
            MsgBox("تم تحديث بنية الجداول بنجاح." & vbCrLf & "Schema Updated Successfully.", MsgBoxStyle.Information, "Schema Update")
        Else
            MsgBox(FailMessages)
            FailMessages.ToString()
            MsgBox(FailMessages.ToString())
            RecordRrrors(DescriptionRrrors:=FailMessages)
        End If


    End Sub
    Public Sub UpdateInsertDeletDate()
        Try
            GlCommand.CommandText = "UPDATE [dbo].[bay_goled_mony] SET [PayMethod]='1'where [PayMethod] IS NULL "
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
        Try
            GlCommand.CommandText = "UPDATE [selInvoceDetels] SET [GoledKarat] = (SELECT [Gram_valu] FROM [FO_min] WHERE [BarCode] = [selInvoceDetels].[itemID]) where [selInvoceDetels].[GoledKarat] IS NULL"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            FailMessages &= ex.Message
        End Try
    End Sub
End Module
