-- =============================================
-- View: dbo.ReportGoldSellDetailed
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldSellDetailed]
AS
CREATE VIEW [dbo].[ReportGoldSellDetailed] AS SELECT dbo.selInvoceDetels.Castomerid, 
dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.item_totalPrice, 
dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_extrasPRICE, 
dbo.selInvoceDetels.item_gramMade, dbo.selInvoceDetels.item_gram, 
dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_desp, 
dbo.selInvoceDetels.invoc_date_time, 
dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.qunt, 
dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.nots, dbo.selInvoceDetels.date AS date_finel, dbo.CastomerDETELS.CastomerNAme, 
dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, 
dbo.FO_min.Gram_valu, dbo.FO_min.ID, 
dbo.selInvoceDetels.item_gramMade * dbo.selInvoceDetels.item_gram AS Total_gramMade, 
dbo.cacher.cacher_name, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_price, dbo.FO_min.BarCode, 
dbo.BAY.Active 
FROM dbo.selInvoceDetels INNER JOIN 
dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN 
dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN 
dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode INNER JOIN 
dbo.BAY ON dbo.selInvoceDetels.invoc_time = dbo.BAY.BAY_SARYAL 
WHERE (dbo.selInvoceDetels.Active = 1) AND (dbo.BAY.Active = 1)

