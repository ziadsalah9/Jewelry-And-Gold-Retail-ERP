-- =============================================
-- Table: dbo.BarcodeSet
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[BarcodeSet] (

    [ID] int(10,0) NOT NULL,
    [CategoryType] nchar(10),
    [FiledName] nvarchar(50),
    [RightLeft] nchar(10),
    [BarcodFontName] nvarchar(50),
    [FontName] nvarchar(50),
    [TextFontSize] nvarchar(50),
    [TextFontShape] nvarchar(50),
    [txtCompFont] nvarchar(50),
    [cmbCompFontTyp] nvarchar(50),
    [cmbCompFontShape] nvarchar(50),
    [txtCountryFont] nvarchar(50),
    [cmbCountryFontTyp] nvarchar(50),
    [txtBarCodeFont] nvarchar(50),
    [cmbBarCodeFontTyp] nvarchar(50),
    [CountryFontShape] nvarchar(50),
    [cmbPrinter] nvarchar(50),
    [txtUpDoR] nvarchar(50),
    [txtRtLfR] nvarchar(50),
    [txtValuUpDoR] nvarchar(50),
    [txtValuRtLfR] nvarchar(50),
    [txtUpDoL] nvarchar(50),
    [txtRtLfL] nvarchar(50),
    [txtValuUpDoL] nvarchar(50),
    [txtValuRtLfL] nvarchar(50),
    [txtCode] nvarchar(50),
    [txtCostPerItem] nvarchar(50),
    [txtQty] nvarchar(50),
    [txtStoneWeight] nvarchar(50),
    [txtShoromName] nvarchar(50),
    [txtShroomUpDo] nvarchar(50),
    [txtShroomRtLf] nvarchar(50),
    [txtLogoUpDo] nvarchar(50),
    [txtLogoRtLf] nvarchar(50),
    [txtImge] image(2147483647),
    [txtImgeSize] nvarchar(50)

);

ALTER TABLE [dbo].[BarcodeSet]
ADD CONSTRAINT [PK_BarcodeSet] PRIMARY KEY ([ID]);

