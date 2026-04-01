-- =============================================
-- Table: dbo.Auction_GuaranteeStatus
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_GuaranteeStatus] (

    [Guarantee_ID] int(10,0) NOT NULL,
    [GuaranteeStatus] nvarchar(255)

);

ALTER TABLE [dbo].[Auction_GuaranteeStatus]
ADD CONSTRAINT [PK_Auction_GuaranteeStatus] PRIMARY KEY ([Guarantee_ID]);

