-- =============================================
-- View: dbo.sum_total_price
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[sum_total_price]
AS
CREATE VIEW dbo.sum_total_price
AS
SELECT     SUM(item_totalPrice) AS total_price, invoc_time
FROM         dbo.selInvoceDetels
GROUP BY invoc_time, Active
HAVING      (Active = 1)


