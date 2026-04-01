-- =============================================
-- View: dbo.casher_total_sel
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[casher_total_sel]
AS
CREATE VIEW dbo.casher_total_sel
AS
SELECT     TOP (2147483647) dbo.cacher.cacher_name, dbo.cacher.start_wark, dbo.cacher.full_name, dbo.cacher.adr, dbo.cacher.svil_id, dbo.CastomerDETELS.CastomerNAme, 
                      dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.selInvoceDetels.item_name, 
                      dbo.selInvoceDetels.item_desp, dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram, dbo.selInvoceDetels.item_gramMade, dbo.selInvoceDetels.item_extrasPRICE, 
                      dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_totalPrice, dbo.selInvoceDetels.item_cantrey, dbo.selInvoceDetels.invoc_date_time, dbo.selInvoceDetels.invoc_time, 
                      dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.qunt, dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.nots, dbo.BAY.TOTAL_mony, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.arbic_tayb, 
                      dbo.BAY.balance, dbo.BAY.staytes
FROM         dbo.selInvoceDetels INNER JOIN
                      dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN
                      dbo.BAY ON dbo.selInvoceDetels.invoc_time = dbo.BAY.BAY_SARYAL INNER JOIN
                      dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid
ORDER BY dbo.cacher.cacher_name


