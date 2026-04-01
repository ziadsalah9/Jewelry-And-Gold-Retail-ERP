-- =============================================
-- View: dbo.ViwGoldInvoceReportShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwGoldInvoceReportShort]
AS
CREATE VIEW [dbo].[ViwGoldInvoceReportShort] AS SELECT TOP (100) PERCENT CastomerNAme, Castomerid,
CastomerNA, cacher_name, SUM(item_gram) AS item_gram, SUM(item_gramMade) AS item_gramMade, SUM(item_extrasMAZAN) AS
item_extrasMAZAN, SUM(StoneWeight2) 
AS StoneWeight2, SUM(StoneWeight3) AS StoneWeight3, SUM(MetalPrice) AS MetalPrice, KENT, Bank1, Bank2,
Bank3, Bank4, CACH, TOTAL_mony, BAY_SARYAL, invoc_date_time, date, CastomerADr, CastomerTE, 
CastomerNameEn, PayMethodAr, PayMethodEn
FROM dbo.ViwGoldInvoceReport
GROUP BY CastomerNAme, Castomerid, CastomerNA, cacher_name, KENT, Bank1, Bank2, Bank3, Bank4, CACH,
TOTAL_mony, BAY_SARYAL, invoc_date_time, date, CastomerADr, CastomerTE, CastomerNameEn, PayMethodAr, 
PayMethodEn
ORDER BY BAY_SARYAL DESC, date DESC

