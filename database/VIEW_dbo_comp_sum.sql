-- =============================================
-- View: dbo.comp_sum
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[comp_sum]
AS
CREATE VIEW [dbo].[comp_sum]
AS
SELECT     co_name, co_adress, co_shoname, co_nomp, co_fasx, co_dep
FROM         dbo.comp_detels
GROUP BY co_name, co_adress, co_shoname, co_nomp, co_fasx, co_dep


