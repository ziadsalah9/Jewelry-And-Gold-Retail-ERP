-- =============================================
-- Table: dbo.Buy_Gold
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Buy_Gold] (

    [B_gold_id] int(10,0) NOT NULL,
    [castomer_id] nvarchar(255) NOT NULL,
    [bay_val] nvarchar(255) NOT NULL,
    [bay_mazan] decimal(18,3) NOT NULL,
    [bay_gram_price] decimal(18,3) NOT NULL,
    [bay_total_price] decimal(18,3) NOT NULL,
    [inv_id] nvarchar(255) NOT NULL,
    [Item_Des] nvarchar(255),
    [INV_Actv] int(10,0),
    [Qunt] int(10,0) NOT NULL DEFAULT ((1)),
    [AddToItem] int(10,0),
    [Note] nvarchar(400),
    [GoldCaret999] nvarchar(255) NOT NULL DEFAULT ((995)),
    [GoldWeight999] decimal(18,3)

);

ALTER TABLE [dbo].[Buy_Gold]
ADD CONSTRAINT [PK_Buy_Gold] PRIMARY KEY ([B_gold_id]);

