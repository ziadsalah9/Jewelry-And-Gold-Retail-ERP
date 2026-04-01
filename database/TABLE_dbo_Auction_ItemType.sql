-- =============================================
-- Table: dbo.Auction_ItemType
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_ItemType] (

    [ID] int(10,0) NOT NULL,
    [Auction_Type] nvarchar(50)

);

ALTER TABLE [dbo].[Auction_ItemType]
ADD CONSTRAINT [PK_Auction_ItemType] PRIMARY KEY ([ID]);

