-- =============================================
-- View: dbo.ReportDiamondProfit
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportDiamondProfit]
AS
CREATE VIEW [dbo].[ReportDiamondProfit] AS SELECT     TOP (100) PERCENT DIMO_Type, DIMO_mezan, 
DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id AS sarual, test_119, cacher_name, 
test_117, test_118 
FROM  dbo.finel_parfct_dimon 
GROUP BY DIMO_Type, DIMO_mezan, DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id, test_119, cacher_name, test_117, test_118 
ORDER BY BAY_SARYAL 

