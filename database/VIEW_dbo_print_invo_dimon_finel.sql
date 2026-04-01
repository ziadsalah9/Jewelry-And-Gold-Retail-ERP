-- =============================================
-- View: dbo.print_invo_dimon_finel
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[print_invo_dimon_finel]
AS
CREATE VIEW dbo.print_invo_dimon_finel
AS
SELECT     TOP (2147483647) dbo.for_dimon_inv.sarual, dbo.dimon_bay.TOTAL_mony, dbo.dimon_bay.KENT, dbo.dimon_bay.CACH, dbo.dimon_bay.arbic_tayb, dbo.dimon_bay.balance, 
                      dbo.dimon_bay.staytes, dbo.for_dimon_inv.castomr_id, dbo.for_dimon_inv.CastomerNAme, dbo.for_dimon_inv.CastomerADr, dbo.for_dimon_inv.CastomerTE, dbo.for_dimon_inv.CastomerNA, 
                      dbo.for_dimon_inv.foto, dbo.for_dimon_inv.dimo_id, dbo.for_dimon_inv.price, dbo.for_dimon_inv.descont, dbo.for_dimon_inv.total, dbo.for_dimon_inv.DIMO_Type, dbo.for_dimon_inv.DIM_na9awa, 
                      dbo.for_dimon_inv.DIMO_mezan, dbo.for_dimon_inv.DIMO_coler, dbo.for_dimon_inv.DIMO_qult, dbo.for_dimon_inv.val_gold, dbo.for_dimon_inv.GOLD_mezan, dbo.for_dimon_inv.cach AS cach1, 
                      dbo.for_dimon_inv.kenet, dbo.for_dimon_inv.user_creted, dbo.for_dimon_inv.date_creted, dbo.for_dimon_inv.time, dbo.for_dimon_inv.dim_foto, dbo.for_dimon_inv.test_17, 
                      dbo.for_dimon_inv.test_18, dbo.for_dimon_inv.test_19, dbo.for_dimon_inv.test_110, dbo.for_dimon_inv.test_111, dbo.for_dimon_inv.test_112, dbo.for_dimon_inv.test_116, 
                      dbo.for_dimon_inv.test_117, dbo.for_dimon_inv.test_118, dbo.for_dimon_inv.test_119
FROM         dbo.dimon_bay INNER JOIN
                      dbo.for_dimon_inv ON dbo.dimon_bay.BAY_SARYAL = dbo.for_dimon_inv.descont


