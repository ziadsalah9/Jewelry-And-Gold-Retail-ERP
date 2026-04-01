-- =============================================
-- View: dbo.cach_kenat
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[cach_kenat]
AS
CREATE VIEW [dbo].[cach_kenat]
AS
SELECT     dbo.selInvoceDetels.Cash, SUM(dbo.BAY.TOTAL_mony) AS TOTAL_mony, SUM(dbo.BAY.KENT) AS KENT, SUM(dbo.BAY.CACH) AS CACH
FROM         dbo.BAY INNER JOIN
                      dbo.selInvoceDetels ON dbo.BAY.BAY_SARYAL = dbo.selInvoceDetels.invoc_time
GROUP BY dbo.selInvoceDetels.Cash


