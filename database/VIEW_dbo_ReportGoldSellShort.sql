-- =============================================
-- View: dbo.ReportGoldSellShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldSellShort]
AS
CREATE VIEW [dbo].[ReportGoldSellShort] AS SELECT TOP (100) PERCENT dbo.CastomerDETELS.CastomerNAme, 
dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerTE, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.TOTAL_mony, 
dbo.BAY.BAY_SARYAL, dbo.selInvoceDetels.Cash, 
SUM(dbo.selInvoceDetels.item_gram) AS item_gram, dbo.selInvoceDetels.date, dbo.selInvoceDetels.Active 
FROM dbo.CastomerDETELS INNER JOIN 
dbo.selInvoceDetels ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.selInvoceDetels.Castomerid INNER JOIN 
dbo.BAY ON dbo.selInvoceDetels.invoc_time = dbo.BAY.BAY_SARYAL INNER JOIN 
dbo.FO_min ON dbo.selInvoceDetels.ItemID = dbo.FO_min.BarCode 
WHERE(dbo.FO_min.Gram_valu <= N'24') OR (dbo.BAY.Active = 1) 
GROUP BY dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerCAIVELid, 
dbo.CastomerDETELS.CastomerTE, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.TOTAL_mony, 
dbo.BAY.BAY_SARYAL, dbo.selInvoceDetels.Cash, dbo.selInvoceDetels.date, dbo.selInvoceDetels.Active 
HAVING(dbo.selInvoceDetels.Active = 1)
ORDER BY dbo.selInvoceDetels.date

