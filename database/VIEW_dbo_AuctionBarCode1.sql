-- =============================================
-- View: dbo.AuctionBarCode1
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AuctionBarCode1]
AS
CREATE VIEW dbo.AuctionBarCode1
AS
SELECT     Auction_ID, Name, Brand, Model, SerialNo, ItemNewUsed, GuaranteeStatus, GuaranteeDate, ReceiveDate, Price, CastomerID, CacherID, Details, Name + SPACE(1) + CONVERT(nvarchar, Auction_ID) 
                      AS BarCode_ID
FROM         dbo.Auction_AddItemDetails


