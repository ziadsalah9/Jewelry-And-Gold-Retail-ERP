-- =============================================
-- View: dbo.finel_parfct_dimon
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[finel_parfct_dimon]
AS
CREATE VIEW [finel_parfct_dimon] AS 
SELECT castomr_id, CastomerNAme, CastomerADr, CastomerTE, CastomerNA, descont, total, ar_taype, DIM_na9awa, DIMO_Type, DIMO_mezan, DIMO_coler, DIMO_qult, sarual, val_gold, GOLD_mezan, 
user_creted, date_creted, time, test_13, test_14, test_15, test_117, test_118, test_116, test_119, BAY_SARYAL, TOTAL_mony, dimon_bay_cach, arbic_tayb, KENT, balance, staytes, dimo_id, 
COALESCE (test_12, 0) AS cost, total - COALESCE (test_12, 0) AS finel_paeret, cacher_name 
FROM for_print_dimon_finel 
GROUP BY castomr_id, CastomerNAme, CastomerADr, CastomerTE, CastomerNA, descont, total, ar_taype, DIM_na9awa, DIMO_Type, DIMO_mezan, DIMO_coler, DIMO_qult, sarual, val_gold, GOLD_mezan, 
user_creted, date_creted, time, test_13, test_14, test_15, test_117, test_118, test_116, test_119, BAY_SARYAL, TOTAL_mony, dimon_bay_cach, arbic_tayb, KENT, balance, staytes, dimo_id, 
COALESCE (test_12, 0), total - COALESCE (test_12, 0), cacher_name

