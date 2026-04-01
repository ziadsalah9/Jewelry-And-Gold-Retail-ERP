-- =============================================
-- View: dbo.AccessoriesBuyDetailed
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesBuyDetailed]
AS
CREATE VIEW dbo.AccessoriesBuyDetailed
AS
SELECT     dbo.Accessories_Buy.AccessoriesID, dbo.Accessories_Buy.Accessories_NAME, dbo.Accessories_Buy.Accessories_BRAND, dbo.Accessories_Buy.Accessories_DESC, 
                      dbo.Accessories_Buy.Accessories_ItemStatus, dbo.Accessories_Buy.Accessories_CAT, dbo.Accessories_Buy.Accessories_DEP, dbo.Accessories_Buy.Accessories_model_no, 
                      dbo.Accessories_Buy.Accessories_nom, dbo.Accessories_Buy.Accessories_DATE_CRE, dbo.Accessories_Buy.Accessories_CID, dbo.Accessories_Buy.Accessories_Price, 
                      dbo.Accessories_Buy.Accessories_InvoiceNo, dbo.cacher.cacher_name, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, 
                      dbo.CastomerDETELS.CastomerNA
FROM         dbo.Accessories_Buy INNER JOIN
                      dbo.CastomerDETELS ON dbo.Accessories_Buy.Accessories_CID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
                      dbo.cacher ON dbo.Accessories_Buy.Accessories_USER_CRET = dbo.cacher.cacherID


