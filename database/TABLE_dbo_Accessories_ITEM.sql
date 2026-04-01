-- =============================================
-- Table: dbo.Accessories_ITEM
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_ITEM] (

    [AccessoriesID] int(10,0) NOT NULL,
    [Accessories_NAME] nvarchar(50),
    [Accessories_BRAND] nvarchar(50),
    [Accessories_BRAND_SHORT] nvarchar(10),
    [Accessories_DESC] nvarchar(700),
    [Accessories_CAT] nvarchar(10),
    [Accessories_DEP] nvarchar(10),
    [Accessories_model_no] nvarchar(50),
    [Accessories_nom] nvarchar(50),
    [Accessories_PIC] image(2147483647),
    [Accessories_TIME] datetime,
    [Accessories_DATE_CRE] date,
    [Accessories_USER_CRET] int(10,0),
    [Accessories_Cost] decimal(18,3),
    [Accessories_Price] decimal(18,3),
    [Accessories_Code] nvarchar(10),
    [Accessories_Year] nvarchar(10),
    [Item_Actv] int(10,0),
    [Accessories_Supplier] nvarchar(50),
    [Accessories_Attachments] nvarchar(50)

);

ALTER TABLE [dbo].[Accessories_ITEM]
ADD CONSTRAINT [PK_Accessories_ITEM] PRIMARY KEY ([AccessoriesID]);

