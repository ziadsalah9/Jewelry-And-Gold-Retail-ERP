-- =============================================
-- View: dbo.resev_mony_rebort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[resev_mony_rebort]
AS
CREATE VIEW [dbo].[resev_mony_rebort]
AS
SELECT     dbo.resev_mony.rsev_mony_id, dbo.resev_mony.mony_from, dbo.resev_mony.for_wont, dbo.resev_mony.note, dbo.resev_mony.date, dbo.resev_mony.kach, 
                      dbo.resev_mony.kent, dbo.[user].user_name, dbo.resev_mony.kach + dbo.resev_mony.kent AS total_mony
FROM         dbo.resev_mony INNER JOIN
                      dbo.[user] ON dbo.resev_mony.user_id = dbo.[user].user_id


