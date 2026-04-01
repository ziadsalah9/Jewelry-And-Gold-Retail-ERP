-- =============================================
-- View: dbo.AccessoriesSellShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesSellShort]
AS
CREATE VIEW dbo.AccessoriesSellShort
AS
SELECT     dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.[user].user_name, 
                      dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.Accessories_BAY.Accessories_TOTAL_mony AS TotalPrice, dbo.Accessories_BAY.Accessories_KENT AS KNET, 
                      dbo.Accessories_BAY.Accessories_CACH AS Cash, dbo.cacher.cacher_name, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE, 
                      dbo.Accessories_BAY.Accessories_staytes
FROM         dbo.cacher RIGHT OUTER JOIN
                      dbo.Accessories_BAY RIGHT OUTER JOIN
                      dbo.Accessories_INV ON dbo.Accessories_BAY.Accessories_BAY_SARYAL = dbo.Accessories_INV.Accessories_INV_NO_ID LEFT OUTER JOIN
                      dbo.[user] ON dbo.Accessories_INV.Accessories_INV_USER = dbo.[user].user_id LEFT OUTER JOIN
                      dbo.CastomerDETELS ON dbo.Accessories_INV.Accessories_INV_CASTOMER_ID = dbo.CastomerDETELS.CastomerCAIVELid ON 
                      dbo.cacher.svil_id = dbo.Accessories_BAY.Accessories_Casher
GROUP BY dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.[user].user_name, 
                      dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.cacher.cacher_name, dbo.Accessories_BAY.Accessories_TOTAL_mony, dbo.Accessories_BAY.Accessories_KENT, 
                      dbo.Accessories_BAY.Accessories_CACH, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE, dbo.Accessories_BAY.Accessories_staytes, 
                      dbo.Accessories_INV.Accessories_Active
HAVING      (dbo.Accessories_BAY.Accessories_staytes = 1) AND (dbo.Accessories_INV.Accessories_Active = 1)


