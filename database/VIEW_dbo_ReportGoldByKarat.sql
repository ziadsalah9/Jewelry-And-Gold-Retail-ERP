-- =============================================
-- View: dbo.ReportGoldByKarat
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldByKarat]
AS
CREATE VIEW [ReportGoldByKarat] AS 
SELECT TOP 100 PERCENT (FO_min.Gram_valu), SUM(BAY.KENT) AS KENT, SUM(selInvoceDetels.item_gram) AS item_gram, selInvoceDetels.date, 
SUM(selInvoceDetels.item_GramPrice * selInvoceDetels.item_gram) AS total_price, selInvoceDetels.item_GramPrice 
FROM  selInvoceDetels INNER JOIN 
BAY ON selInvoceDetels.invoc_time = BAY.BAY_SARYAL INNER JOIN 
FO_min ON selInvoceDetels.itemID = FO_min.ID 
GROUP BY FO_min.Gram_valu, selInvoceDetels.date, selInvoceDetels.item_GramPrice 
ORDER BY FO_min.Gram_valu DESC, selInvoceDetels.date DESC

