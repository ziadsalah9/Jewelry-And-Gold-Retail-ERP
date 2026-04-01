-- =============================================
-- View: dbo.ReportSilverSellShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportSilverSellShort]
AS
CREATE VIEW [ReportSilverSellShort] AS 
SELECT TOP (100) PERCENT CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerCAIVELid, CastomerDETELS.CastomerTE, BAY.KENT, BAY.CACH, BAY.TOTAL_mony,  
BAY.BAY_SARYAL, selInvoceDetels.Cash, SUM(selInvoceDetels.item_gram) AS item_gram, selInvoceDetels.date 
FROM CastomerDETELS INNER JOIN selInvoceDetels ON CastomerDETELS.CastomerCAIVELid = selInvoceDetels.Castomerid INNER JOIN 
BAY ON selInvoceDetels.invoc_time = BAY.BAY_SARYAL INNER JOIN 
FO_min ON selInvoceDetels.itemID = FO_min.ID 
WHERE (BAY.Active = 1) AND (FO_min.Gram_valu >= N'700') 
GROUP BY CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerCAIVELid, CastomerDETELS.CastomerTE, BAY.KENT, BAY.CACH, BAY.TOTAL_mony,  
BAY.BAY_SARYAL, selInvoceDetels.Cash, selInvoceDetels.date ORDER BY selInvoceDetels.date

