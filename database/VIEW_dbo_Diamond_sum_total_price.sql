-- =============================================
-- View: dbo.Diamond_sum_total_price
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Diamond_sum_total_price]
AS
CREATE VIEW dbo.Diamond_sum_total_price
AS
SELECT     SUM(total) AS total_price, descont
FROM         dbo.dimon_invce
GROUP BY descont


