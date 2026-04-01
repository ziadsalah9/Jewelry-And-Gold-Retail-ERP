-- =============================================
-- View: dbo.AccessoriesBuyShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesBuyShort]
AS
CREATE VIEW dbo.AccessoriesBuyShort
AS
SELECT     dbo.Accessories_Buy_Pay.Accessories_InvoiceNo, dbo.Accessories_Buy_Pay.Accessories_TOTAL_Price, dbo.Accessories_Buy_Pay.Accessories_KNET, 
                      dbo.Accessories_Buy_Pay.Accessories_CASH, dbo.Accessories_Buy_Pay.Accessories_Casher, dbo.cacher.cacher_name, dbo.CastomerDETELS.CastomerNAme, 
                      dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.Accessories_Buy.Accessories_DATE_CRE, 
                      dbo.CastomerDETELS.CastomerCAIVELid
FROM         dbo.CastomerDETELS INNER JOIN
                      dbo.Accessories_Buy ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.Accessories_Buy.Accessories_CID LEFT OUTER JOIN
                      dbo.cacher INNER JOIN
                      dbo.Accessories_Buy_Pay ON dbo.cacher.cacherID = dbo.Accessories_Buy_Pay.Accessories_Casher ON 
                      dbo.Accessories_Buy.Accessories_InvoiceNo = dbo.Accessories_Buy_Pay.Accessories_InvoiceNo
GROUP BY dbo.Accessories_Buy_Pay.Accessories_InvoiceNo, dbo.Accessories_Buy_Pay.Accessories_TOTAL_Price, dbo.Accessories_Buy_Pay.Accessories_KNET, 
                      dbo.Accessories_Buy_Pay.Accessories_CASH, dbo.Accessories_Buy_Pay.Accessories_Casher, dbo.cacher.cacher_name, dbo.CastomerDETELS.CastomerNAme, 
                      dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.Accessories_Buy.Accessories_DATE_CRE, 
                      dbo.CastomerDETELS.CastomerCAIVELid


