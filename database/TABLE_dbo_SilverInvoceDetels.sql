-- =============================================
-- Table: dbo.SilverInvoceDetels
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[SilverInvoceDetels] (

    [ID] int(10,0) NOT NULL,
    [Castomerid] nvarchar(255) NOT NULL,
    [itemID] nvarchar(255) NOT NULL,
    [userID] nvarchar(255) NOT NULL,
    [item_name] nvarchar(255) NOT NULL,
    [item_desp] nvarchar(255) NOT NULL,
    [item_GramPrice] decimal(18,3) NOT NULL,
    [item_gram] decimal(18,3) NOT NULL,
    [item_gramMade] decimal(18,3) NOT NULL,
    [item_extrasPRICE] decimal(18,3),
    [item_extrasMAZAN] decimal(18,3),
    [item_totalPrice] decimal(18,3) NOT NULL,
    [item_cantrey] nvarchar(255) NOT NULL,
    [K_net] decimal(18,3),
    [cacher] nvarchar(50) NOT NULL,
    [date] date NOT NULL,
    [invoc_date_time] nvarchar(255) NOT NULL,
    [Cash] nvarchar(255) NOT NULL,
    [qunt] int(10,0),
    [nots] nvarchar(1000),
    [sroom_name] nvarchar(250),
    [invoc_time] nvarchar(500) NOT NULL,
    [Active] int(10,0),
    [StoneName1] nvarchar(50),
    [StoneColor1] nvarchar(50),
    [StonePriceType1] int(10,0),
    [StoneWeight2] decimal(18,3),
    [StoneName2] nvarchar(50),
    [StoneColor2] nvarchar(50),
    [StonePrice2] decimal(18,3),
    [StonePriceType2] int(10,0),
    [StoneWeight3] decimal(18,3),
    [StoneName3] nvarchar(50),
    [StoneColor3] nvarchar(50),
    [StonePrice3] decimal(18,3),
    [StonePriceType3] int(10,0),
    [GoledKarat] nvarchar(50),
    [MetalPrice] decimal(18,3),
    [ItemVatType] decimal(18,3) DEFAULT ((14)),
    [ItemVat] decimal(18,3) DEFAULT ((0))

);

ALTER TABLE [dbo].[SilverInvoceDetels]
ADD CONSTRAINT [PK_SilverInvoceDetels] PRIMARY KEY ([ID]);

