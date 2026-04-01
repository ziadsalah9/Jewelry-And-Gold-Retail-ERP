-- =============================================
-- View: dbo.dimon_for_moi_report
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[dimon_for_moi_report]
AS
CREATE VIEW dbo.dimon_for_moi_report
AS
SELECT     CastomerNAme, CastomerADr, CastomerTE, castomr_id, CastomerNA, BAY_SARYAL, KENT, dimon_bay_cach, TOTAL_mony AS total_bay, balance AS blance, DIMO_mezan, val_gold, GOLD_mezan, 
                      date_creted
FROM         dbo.finel_parfct_dimon
GROUP BY CastomerNAme, CastomerADr, CastomerTE, castomr_id, CastomerNA, BAY_SARYAL, KENT, TOTAL_mony, dimon_bay_cach, balance, DIMO_mezan, val_gold, GOLD_mezan, date_creted


