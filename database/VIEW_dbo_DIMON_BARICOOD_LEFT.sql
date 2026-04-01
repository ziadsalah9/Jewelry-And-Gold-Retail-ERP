-- =============================================
-- View: dbo.DIMON_BARICOOD_LEFT
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[DIMON_BARICOOD_LEFT]
AS
CREATE VIEW [dbo].[DIMON_BARICOOD_LEFT] AS SELECT DIMOND_ID, DIMO_dep + SPACE(1) + test_119 AS DIMON_NAME,
DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, test_16, 
test_17, test_18, test_19, test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117,
test_118, test_119, CostToSeller, TaxExempt, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3, IsDiamond1, 
IsDiamond2, IsDiamond3
FROM dbo.[CONVERT-DIMOND_ID]

