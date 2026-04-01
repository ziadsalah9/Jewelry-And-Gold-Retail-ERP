-- =============================================
-- Table: dbo.Auction_AddItemDetails
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_AddItemDetails] (

    [Auction_ID] int(10,0) NOT NULL,
    [Name] nvarchar(255),
    [Brand] nvarchar(255),
    [Model] nvarchar(255),
    [SerialNo] nvarchar(255),
    [ItemNewUsed] nvarchar(255),
    [GuaranteeStatus] nvarchar(255),
    [GuaranteeDate] nvarchar(10),
    [ReceiveDate] date,
    [Details] nvarchar(255),
    [ItemPhoto] image(2147483647),
    [Price] decimal(18,3),
    [CastomerID] nvarchar(50),
    [CacherID] int(10,0)

);

ALTER TABLE [dbo].[Auction_AddItemDetails]
ADD CONSTRAINT [PK_Auction_AddItemDetails] PRIMARY KEY ([Auction_ID]);

