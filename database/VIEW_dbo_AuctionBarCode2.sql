-- =============================================
-- View: dbo.AuctionBarCode2
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AuctionBarCode2]
AS
CREATE VIEW dbo.AuctionBarCode2
AS
SELECT     Auction_ID, Name, Brand, Model, SerialNo, ItemNewUsed, GuaranteeStatus, GuaranteeDate, ReceiveDate, Price, CastomerID, CacherID, Details, Name + SPACE(1) + CONVERT(nvarchar, Auction_ID) 
                      AS BarCode_ID
FROM         dbo.Auction_AddItemDetails


