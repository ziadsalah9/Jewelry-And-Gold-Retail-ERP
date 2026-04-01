-- =============================================
-- View: dbo.profit_finel_for_sho
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[profit_finel_for_sho]
AS
CREATE VIEW dbo.profit_finel_for_sho
AS
SELECT     TOP (100) PERCENT DIMO_Type, DIMO_mezan, DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id AS sarual, test_119
FROM         dbo.finel_parfct_dimon
GROUP BY DIMO_Type, DIMO_mezan, DIM_na9awa, DIMO_coler, val_gold, GOLD_mezan, BAY_SARYAL, cost, finel_paeret, date_creted, total, dimo_id, test_119
ORDER BY BAY_SARYAL


