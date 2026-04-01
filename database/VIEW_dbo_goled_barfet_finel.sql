-- =============================================
-- View: dbo.goled_barfet_finel
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[goled_barfet_finel]
AS
CREATE VIEW [goled_barfet_finel] AS SELECT dbo.selInvoceDetels.ItemID, 
dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.item_gramMade AS made_invoce, dbo.selInvoceDetels.item_extrasMAZAN, 
dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_totalPrice, 
dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.date AS date_seel, 
dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram AS wazen_sell, dbo.cacher.cacher_name, 
dbo.FO_min.date_care, dbo.FO_min.Gram_valu, dbo.FO_min.FO_desp AS cost, 
dbo.FO_min.FO_gram AS wazen_stecar, dbo.selInvoceDetels.item_gramMade - 
dbo.FO_min.FO_desp AS parfet_for_gram, (dbo.selInvoceDetels.item_gramMade - dbo.FO_min.FO_desp) 
* dbo.FO_min.FO_gram AS total_parfet_into_gram, dbo.selInvoceDetels.item_totalPrice - 
dbo.selInvoceDetels.item_extrasPRICE AS total_price_gold, 
dbo.selInvoceDetels.item_gramMade * dbo.FO_min.FO_gram AS TotalMake, dbo.FO_min.FO_desp * 
dbo.FO_min.FO_gram AS TotalCost, dbo.FO_min.FO_GramPrice AS Supplier 
FROM dbo.selInvoceDetels INNER JOIN 
dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode LEFT OUTER JOIN 
dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id 
WHERE (dbo.selInvoceDetels.Active = 1)

