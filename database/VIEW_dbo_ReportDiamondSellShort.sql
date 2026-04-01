-- =============================================
-- View: dbo.ReportDiamondSellShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportDiamondSellShort]
AS
CREATE VIEW [dbo].[ReportDiamondSellShort] AS SELECT castomr_id, CastomerNAme, 
CastomerTE, SUM(DIMO_mezan) AS DIMO_mezan, SUM(GOLD_mezan) AS 
GOLD_mezan, date_creted, cacher_name, KENT, TOTAL_mony, dimon_bay_cach AS CACH, 
BAY_SARYAL, SUM(test_116) AS test_116, SUM(test_13) AS test_13, SUM(test_16) AS test_16, SUM(test_19) AS test_19 
FROM dbo.for_print_dimon_finel_short 
GROUP BY castomr_id, CastomerNAme, 
CastomerTE, date_creted, cacher_name, BAY_SARYAL, KENT, TOTAL_mony, dimon_bay_cach 

