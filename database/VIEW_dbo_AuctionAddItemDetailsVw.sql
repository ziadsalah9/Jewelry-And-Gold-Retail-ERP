-- =============================================
-- View: dbo.AuctionAddItemDetailsVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AuctionAddItemDetailsVw]
AS
CREATE VIEW dbo.AuctionAddItemDetailsVw
AS
SELECT     dbo.Auction_AddItemDetails.Auction_ID, dbo.Auction_AddItemDetails.Name, dbo.Auction_AddItemDetails.Brand, dbo.Auction_AddItemDetails.Model, dbo.Auction_AddItemDetails.SerialNo, 
                      dbo.Auction_AddItemDetails.GuaranteeStatus, dbo.Auction_AddItemDetails.ItemNewUsed, dbo.Auction_AddItemDetails.GuaranteeDate, dbo.Auction_AddItemDetails.ReceiveDate, 
                      dbo.Auction_AddItemDetails.Details, dbo.Auction_AddItemDetails.ItemPhoto, dbo.Auction_AddItemDetails.Price, dbo.Auction_AddItemDetails.CastomerID, dbo.CastomerDETELS.CastomerNAme, 
                      dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, 
                      dbo.Auction_AddItemDetails.CacherID, dbo.cacher.CashierSignature, dbo.cacher.cacher_name, dbo.comp_inform.comp_name, dbo.comp_inform.comp_adrs, dbo.comp_inform.comp_note11, 
                      dbo.comp_inform.comp_note13, dbo.comp_inform.logo
FROM         dbo.Auction_AddItemDetails INNER JOIN
                      dbo.CastomerDETELS ON dbo.Auction_AddItemDetails.CastomerID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
                      dbo.cacher ON dbo.Auction_AddItemDetails.CacherID = dbo.cacher.cacherID CROSS JOIN
                      dbo.comp_inform


