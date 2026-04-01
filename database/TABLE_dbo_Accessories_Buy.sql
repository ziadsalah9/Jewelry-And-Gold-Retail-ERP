-- =============================================
-- Table: dbo.Accessories_Buy
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_Buy] (

    [AccessoriesID] int(10,0) NOT NULL,
    [Accessories_NAME] nvarchar(50),
    [Accessories_BRAND] nvarchar(50),
    [Accessories_DESC] nvarchar(700),
    [Accessories_ItemStatus] nvarchar(10),
    [Accessories_CAT] nvarchar(10),
    [Accessories_DEP] nvarchar(10),
    [Accessories_model_no] nvarchar(50),
    [Accessories_nom] nvarchar(50),
    [Accessories_PIC] image(2147483647),
    [Accessories_TIME] time,
    [Accessories_DATE_CRE] date,
    [Accessories_USER_CRET] int(10,0),
    [Accessories_CID] nvarchar(15),
    [Accessories_Price] decimal(18,3),
    [Accessories_InvoiceNo] int(10,0),
    [BarCode] int(10,0),
    [Accessories_YearOfWarr] nvarchar(50),
    [Accessories_Attachments] nvarchar(1000),
    [ItemNo] nvarchar(50)

);

ALTER TABLE [dbo].[Accessories_Buy]
ADD CONSTRAINT [PK_Accessories_Buy] PRIMARY KEY ([AccessoriesID]);

