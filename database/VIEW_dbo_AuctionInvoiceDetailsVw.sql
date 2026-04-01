-- =============================================
-- View: dbo.AuctionInvoiceDetailsVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AuctionInvoiceDetailsVw]
AS
CREATE VIEW dbo.AuctionInvoiceDetailsVw
AS
SELECT     dbo.AuctionInvoiceDetails.ID, dbo.AuctionInvoiceDetails.Castomerid, dbo.AuctionInvoiceDetails.Auction_ID, dbo.AuctionInvoiceDetails.userID, dbo.AuctionInvoiceDetails.Name, 
                      dbo.AuctionInvoiceDetails.Brand, dbo.AuctionInvoiceDetails.Model, dbo.AuctionInvoiceDetails.SerialNo, dbo.AuctionInvoiceDetails.ItemNewUsed, dbo.AuctionInvoiceDetails.GuaranteeStatus, 
                      dbo.AuctionInvoiceDetails.GuaranteeDate, dbo.AuctionInvoiceDetails.Details, dbo.AuctionInvoiceDetails.ReceiveDate, dbo.AuctionInvoiceDetails.TotalPrice, dbo.AuctionInvoiceDetails.K_Net, 
                      dbo.AuctionInvoiceDetails.Cash, dbo.AuctionInvoiceDetails.cacher, dbo.AuctionInvoiceDetails.SellDate, dbo.AuctionInvoiceDetails.invoic_date_time, dbo.AuctionInvoiceDetails.Quantity, 
                      dbo.AuctionInvoiceDetails.Notes, dbo.AuctionInvoiceDetails.sroom_name, dbo.AuctionInvoiceDetails.Invoic_No, dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerNAme, 
                      dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, 
                      dbo.Auction_AddItemDetails.ItemPhoto, dbo.Auction_AddItemDetails.Price, dbo.cacher.cacher_name, dbo.AuctionInvoiceDetails.TotalPriceAr, dbo.AuctionInvoiceDetails.Link, 
                      dbo.cacher.CashierSignature, dbo.comp_inform.comp_name, dbo.comp_inform.comp_adrs, dbo.comp_inform.comp_note11, dbo.comp_inform.comp_note13, dbo.comp_inform.logo, 
                      dbo.AuctionInvoiceDetails.Cheque
FROM         dbo.AuctionInvoiceDetails INNER JOIN
                      dbo.Auction_AddItemDetails ON dbo.AuctionInvoiceDetails.Auction_ID = dbo.Auction_AddItemDetails.Auction_ID INNER JOIN
                      dbo.CastomerDETELS ON dbo.AuctionInvoiceDetails.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
                      dbo.cacher ON dbo.AuctionInvoiceDetails.cacher = dbo.cacher.cacherID CROSS JOIN
                      dbo.comp_inform


