-- =============================================
-- Table: dbo.FO_min
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[FO_min] (

    [ID] int(10,0) NOT NULL,
    [userID] nvarchar NOT NULL,
    [FO_name] nvarchar NOT NULL,
    [FO_desp] decimal(18,3) NOT NULL,
    [FO_price] nvarchar(50),
    [FO_GramPrice] nvarchar(50),
    [FO_gram] decimal(18,3) NOT NULL,
    [FO_gramMade] decimal(18,3) NOT NULL,
    [FO_made] nvarchar(255) NOT NULL,
    [FO_extras] decimal(18,3) NOT NULL,
    [FO_totalPrice] decimal(18,3) NOT NULL,
    [Gram_valu] nvarchar(255) NOT NULL,
    [ITEM_IMGE] image(2147483647),
    [date_care] date,
    [FO_ItemNo] nvarchar(50),
    [Item_Actv] int(10,0),
    [StoneColor1] nvarchar(50),
    [StonePrice1] decimal(18,3),
    [StoneWeight2] decimal(18,3),
    [StoneName2] nvarchar(50),
    [StoneColor2] nvarchar(50),
    [StonePrice2] decimal(18,3),
    [StoneWeight3] decimal(18,3),
    [StoneName3] nvarchar(50),
    [StoneColor3] nvarchar(50),
    [StonePrice3] decimal(18,3),
    [Qty] int(10,0),
    [BarCode] nvarchar(50),
    [LastEditDate] datetime,
    [ItemNote] nvarchar(1000),
    [PurInvNumber] nvarchar(250),
    [MultiItem] int(10,0) NOT NULL DEFAULT ((0)),
    [GoldCaret999] nvarchar(255) NOT NULL DEFAULT ((999)),
    [GoldWeight999] decimal(18,3),
    [BarCodeNote] nvarchar(250)

);

ALTER TABLE [dbo].[FO_min]
ADD CONSTRAINT [PK_FO_min] PRIMARY KEY ([ID]);

