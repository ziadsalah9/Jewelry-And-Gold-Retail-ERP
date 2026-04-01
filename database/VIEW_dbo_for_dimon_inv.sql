-- =============================================
-- View: dbo.for_dimon_inv
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[for_dimon_inv]
AS
CREATE VIEW [for_dimon_inv] AS 
SELECT dimon_invce.castomr_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE AS d, CastomerDETELS.CastomerNA, 
CastomerDETELS.foto, dimon_invce.dimo_id, dimon_invce.descont, dimon_invce.total, dimon_invce.ar_taype, dimon_invce.DIMO_Type, dimon_invce.DIM_na9awa, 
dimon_invce.DIMO_mezan, dimon_invce.DIMO_coler, dimon_invce.DIMO_qult, dimon_invce.sarual, dimon_invce.val_gold, dimon_invce.GOLD_mezan, 
dimon_invce.user_creted, dimon_invce.date_creted, dimon_invce.time, dimon_invce.dim_foto, dimon_invce.test_13, dimon_invce.test_14, dimon_invce.test_15, 
dimon_invce.test_16, dimon_invce.test_17, dimon_invce.test_18, dimon_invce.test_19, dimon_invce.test_110, dimon_invce.test_111, dimon_invce.test_112, 
dimon_invce.test_116, dimon_invce.test_117, dimon_invce.test_118, dimon_invce.test_119, dimon_invce.notes, CastomerDETELS.CastomerTE 
FROM CastomerDETELS INNER JOIN 
dimon_invce ON CastomerDETELS.CastomerCAIVELid = dimon_invce.castomr_id

