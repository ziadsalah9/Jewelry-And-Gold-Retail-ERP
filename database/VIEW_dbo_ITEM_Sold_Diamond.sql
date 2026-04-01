-- =============================================
-- View: dbo.ITEM_Sold_Diamond
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ITEM_Sold_Diamond]
AS
CREATE VIEW [dbo].[ITEM_Sold_Diamond] AS  
SELECT  dbo.DIMON_detels.DIMOND_ID, dbo.DIMON_detels.DIMO_dep,   
dbo.DIMON_detels.DIM_na9awa, dbo.DIMON_detels.DIMO_mezan,   
dbo.DIMON_detels.ext_coler, dbo.DIMON_detels.qult,   
dbo.DIMON_detels.sarual, dbo.DIMON_detels.val_gold,  
dbo.DIMON_detels.GOLD_mezan, dbo.DIMON_detels.test_1,   
 dbo.DIMON_detels.test_11, dbo.DIMON_detels.test_12,   
dbo.DIMON_detels.date_creted, dbo.DIMON_detels.test_119,   
dbo.DIMON_detels.ITEM_IMGE, dbo.dimon_invce.Item_Actv  
FROM  dbo.DIMON_detels INNER JOIN  
dbo.dimon_invce ON dbo.DIMON_detels.test_119 = dbo.dimon_invce.dimo_id  
WHERE (dbo.dimon_invce.Item_Actv = 1)

