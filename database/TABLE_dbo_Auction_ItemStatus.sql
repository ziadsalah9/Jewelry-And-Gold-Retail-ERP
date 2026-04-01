-- =============================================
-- Table: dbo.Auction_ItemStatus
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_ItemStatus] (

    [ItemStatus_ID] int(10,0) NOT NULL,
    [ItemStatus_Name] nvarchar(255)

);

ALTER TABLE [dbo].[Auction_ItemStatus]
ADD CONSTRAINT [PK_Auction_ItemStatus] PRIMARY KEY ([ItemStatus_ID]);

