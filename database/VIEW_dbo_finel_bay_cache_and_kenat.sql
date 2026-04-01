-- =============================================
-- View: dbo.finel_bay_cache_and_kenat
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[finel_bay_cache_and_kenat]
AS
CREATE VIEW dbo.finel_bay_cache_and_kenat
AS
SELECT     TOP (2147483647) CastomerNAme, CastomerADr, CastomerTE, CastomerNA, castomer_id, cach, kenet, date, inv_id
FROM         dbo.BAY_report_for_castomer
GROUP BY CastomerNAme, CastomerADr, CastomerTE, CastomerNA, castomer_id, cach, kenet, date, inv_id
ORDER BY inv_id, date


