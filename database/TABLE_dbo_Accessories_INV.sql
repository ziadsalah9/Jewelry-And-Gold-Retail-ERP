-- =============================================
-- Table: dbo.Accessories_INV
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_INV] (

    [Accessories_INV_ID] int(10,0) NOT NULL,
    [Accessories_INV_ITEM_ID] int(10,0),
    [Accessories_INV_QUNT] int(10,0) NOT NULL,
    [Accessories_INV_un_price] decimal(18,3),
    [Accessories_INV_total_price] decimal(18,3),
    [Accessories_INV_CASTOMER_ID] nvarchar(255),
    [Accessories_INV_DATE] date,
    [Accessories_INV_TIME] nvarchar(255) NOT NULL,
    [Accessories_INV_USER] nvarchar(255) NOT NULL,
    [Accessories_INV_NO_ID] int(10,0) NOT NULL,
    [Accessories_Active] bit,
    [IMG] image(2147483647),
    [ItemName] nvarchar(255),
    [Code] nvarchar(255),
    [Supplier] nvarchar(255),
    [Department] nvarchar(255),
    [Category] nvarchar(255),
    [Attachment] nvarchar(255),
    [Cost] decimal(18,3),
    [Cashier] nvarchar(255),
    [AccessoriesInvoceDESC] nvarchar(700),
    [AccessoriesBrand_ID] nvarchar(50),
    [AccessoriesGUARRANTYYEAR] nvarchar(50),
    [AccessoriesType_ID] nvarchar(50),
    [ModelNo] nvarchar(50),
    [Note] nvarchar(250),
    [ItemNo] nvarchar(255)

);

ALTER TABLE [dbo].[Accessories_INV]
ADD CONSTRAINT [PK_Accessories_INV] PRIMARY KEY ([Accessories_INV_ID]);

