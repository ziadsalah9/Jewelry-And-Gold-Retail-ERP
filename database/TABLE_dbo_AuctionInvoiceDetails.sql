-- =============================================
-- Table: dbo.AuctionInvoiceDetails
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[AuctionInvoiceDetails] (

    [ID] int(10,0) NOT NULL,
    [Castomerid] nvarchar(255) NOT NULL,
    [Auction_ID] int(10,0) NOT NULL,
    [userID] nvarchar(255) NOT NULL,
    [Name] nvarchar(255),
    [Brand] nvarchar(255),
    [Model] nvarchar(255),
    [SerialNo] nvarchar(255),
    [ItemNewUsed] nvarchar(255),
    [GuaranteeStatus] nvarchar(255) NOT NULL,
    [GuaranteeDate] nvarchar(10),
    [ReceiveDate] date NOT NULL,
    [Details] nvarchar(255),
    [TotalPrice] decimal(18,3) NOT NULL,
    [K_net] decimal(18,3),
    [Cash] decimal(18,3),
    [cacher] nvarchar(50) NOT NULL,
    [SellDate] date,
    [invoic_date_time] nvarchar(255) NOT NULL,
    [Quantity] int(10,0),
    [Notes] nvarchar(250),
    [sroom_name] nvarchar(250),
    [Invoic_No] nvarchar(500) NOT NULL,
    [TotalPriceAr] nvarchar,
    [Link] decimal(18,3),
    [Cheque] decimal(18,3)

);

ALTER TABLE [dbo].[AuctionInvoiceDetails]
ADD CONSTRAINT [PK_AuctionInvoiceDetails] PRIMARY KEY ([ID]);

