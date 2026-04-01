-- =============================================
-- View: dbo.ITEMAvailableDiamond
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ITEMAvailableDiamond]
AS
CREATE VIEW [ITEMAvailableDiamond]  AS SELECT  DIMON_detels.DIMOND_ID, DIMON_detels.DIMO_dep, 
DIMON_detels.DIM_na9awa, DIMON_detels.DIMO_mezan, DIMON_detels.ext_coler, DIMON_detels.qult, 
DIMON_detels.sarual, DIMON_detels.val_gold, DIMON_detels.GOLD_mezan, DIMON_detels.test_1, 
DIMON_detels.test_11, DIMON_detels.test_12, 
 DIMON_detels.test_13, DIMON_detels.test_14, 
DIMON_detels.test_15, DIMON_detels.test_16, 
DIMON_detels.test_17, DIMON_detels.test_18, 
DIMON_detels.test_19, 
 DIMON_detels.test_110, DIMON_detels.test_111, 
 DIMON_detels.test_112, DIMON_detels.test_113,
 DIMON_detels.test_114, DIMON_detels.test_115, 
 DIMON_detels.test_116, DIMON_detels.test_117, 
DIMON_detels.test_118, DIMON_detels.test_119,
  DIMON_detels.date_creted, DIMON_detels.ITEM_IMGE, 
 DIMON_detels.Item_Actv AS DIMON_detels_Item_Actv,
 dimon_invce.Item_Actv AS dimon_invce_Item_Actv, 
 DIMON_detels.CostToSeller, DIMON_detels.TaxExempt, 
 DIMON_detels.Documents, DIMON_detels.Cut1, 
DIMON_detels.Clarity1, DIMON_detels.Cut2, 
 DIMON_detels.Clarity2, DIMON_detels.Cut3, DIMON_detels.Clarity3, 
DIMON_detels.IsDiamond1, DIMON_detels.IsDiamond2, DIMON_detels.IsDiamond3 
 FROM DIMON_detels LEFT OUTER JOIN 
 dimon_invce ON DIMON_detels.test_119 = dimon_invce.test_119 
 WHERE (DIMON_detels.Item_Actv = 1) OR (dimon_invce.Item_Actv = 0) 

