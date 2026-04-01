-- =============================================
-- View: dbo.DIMON_NAME_AVAILABLE
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[DIMON_NAME_AVAILABLE]
AS
CREATE VIEW dbo.DIMON_NAME_AVAILABLE
AS
SELECT     dbo.DIMON_detels.DIMOND_ID, dbo.DIMON_detels.DIMO_dep, dbo.DIMON_detels.sarual, dbo.DIMON_detels.test_119
FROM         dbo.DIMON_detels LEFT OUTER JOIN
                      dbo.dimon_invce ON dbo.DIMON_detels.DIMOND_ID = dbo.dimon_invce.dimo_id
WHERE     (dbo.dimon_invce.dimo_id IS NULL)
GROUP BY dbo.DIMON_detels.DIMOND_ID, dbo.DIMON_detels.DIMO_dep, dbo.DIMON_detels.sarual, dbo.DIMON_detels.test_119


