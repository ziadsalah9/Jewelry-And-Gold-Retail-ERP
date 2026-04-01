-- =============================================
-- View: dbo.ReportGoldProfitPerPurchaseCost
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldProfitPerPurchaseCost]
AS
CREATE VIEW [ReportGoldProfitPerPurchaseCost] AS 
SELECT selInvoceDetels.itemID, selInvoceDetels.item_name, selInvoceDetels.item_totalPrice AS GoldSellPrice, selInvoceDetels.invoc_time AS InvoiceNo, 
selInvoceDetels.sroom_name, selInvoceDetels.date, selInvoceDetels.item_GramPrice, selInvoceDetels.item_gram AS GoldWeight, cacher.cacher_name, FO_min.Gram_valu, 
selInvoceDetels.item_totalPrice + selInvoceDetels.item_extrasPRICE + selInvoceDetels.StonePrice2 + selInvoceDetels.StonePrice3 AS TotalSellPrice, 
FO_min.FO_GramPrice AS Supplier, FO_min.FO_totalPrice AS TotalPurcaseCost, FO_min.BarCode 
FROM selInvoceDetels INNER JOIN FO_min ON selInvoceDetels.itemID = FO_min.ID LEFT OUTER JOIN cacher ON selInvoceDetels.cacher = cacher.svil_id 
WHERE (selInvoceDetels.Active = 1)

