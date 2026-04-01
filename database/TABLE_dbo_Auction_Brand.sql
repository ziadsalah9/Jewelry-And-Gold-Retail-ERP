-- =============================================
-- Table: dbo.Auction_Brand
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_Brand] (

    [Brand_ID] int(10,0) NOT NULL,
    [Brand_Name] nvarchar(255),
    [Brand_Name_Short] nvarchar(10)

);

ALTER TABLE [dbo].[Auction_Brand]
ADD CONSTRAINT [PK_Auction_Brand] PRIMARY KEY ([Brand_ID]);

