-- =============================================
-- View: dbo.ITEM_Available_Diamond
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ITEM_Available_Diamond]
AS
CREATE VIEW [dbo].[ITEM_Available_Diamond] AS SELECT DIMOND_ID, DIMO_dep, DIM_na9awa, 
DIMO_mezan, ext_coler, qult, sarual, val_gold, GOLD_mezan, test_1, test_11, test_12, 
test_13, test_14, test_15, test_16, test_17, test_18, test_19, test_110, 
test_111, test_112, test_113, test_114, test_115, test_116, test_117, test_118, 
test_119, date_creted, DIMON_detels_Item_Actv, SUM(dimon_invce_Item_Actv) AS dimon_invce_Item_Actv, 
CostToSeller, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3 FROM dbo.ITEMAvailableDiamond 
GROUP BY DIMOND_ID, DIMO_dep, DIM_na9awa, DIMO_mezan, ext_coler, qult, sarual, val_gold,  
GOLD_mezan, test_1, test_11, test_12, test_13, test_14, test_15, test_16, test_17, test_18, test_19, 
test_110, test_111, test_112, test_113, test_114, test_115, test_116, test_117, test_118, 
test_119, date_creted, DIMON_detels_Item_Actv, CostToSeller, Cut1, Clarity1, Cut2, Clarity2, Cut3, Clarity3 
HAVING (DIMON_detels_Item_Actv > 0) AND (SUM(dimon_invce_Item_Actv) = 0) OR (SUM(dimon_invce_Item_Actv) IS NULL) 

