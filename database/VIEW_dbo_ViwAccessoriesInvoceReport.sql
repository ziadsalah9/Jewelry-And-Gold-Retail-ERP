-- =============================================
-- View: dbo.ViwAccessoriesInvoceReport
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwAccessoriesInvoceReport]
AS
CREATE VIEW [dbo].[ViwAccessoriesInvoceReport] AS SELECT dbo.CastomerDETELS.CastomerNAme,
dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.Accessories_BAY.Accessories_BAY_SARYAL, 
dbo.Accessories_BAY.Accessories_TOTAL_mony AS TotalPrice, dbo.Accessories_BAY.Accessories_KENT AS KNET,
dbo.Accessories_BAY.Accessories_CACH AS Cash, dbo.cacher.cacher_name, 
dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE,
dbo.Accessories_BAY.Accessories_staytes, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, 
dbo.Accessories_INV.Accessories_INV_TIME
FROM dbo.CastomerDETELS RIGHT OUTER JOIN
dbo.Accessories_BAY INNER JOIN
dbo.PayMethod ON dbo.Accessories_BAY.Accessories_PayMethod = dbo.PayMethod.ID RIGHT OUTER JOIN
dbo.Accessories_INV ON dbo.Accessories_BAY.Accessories_BAY_SARYAL = dbo.Accessories_INV.Accessories_INV_NO_ID ON 
dbo.CastomerDETELS.CastomerCAIVELid = dbo.Accessories_INV.Accessories_INV_CASTOMER_ID LEFT OUTER JOIN
dbo.cacher ON dbo.Accessories_BAY.Accessories_Casher = dbo.cacher.svil_id
GROUP BY dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr,
dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA,
dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.cacher.cacher_name, 
dbo.Accessories_BAY.Accessories_TOTAL_mony, dbo.Accessories_BAY.Accessories_KENT,
dbo.Accessories_BAY.Accessories_CACH, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_INV.Accessories_INV_DATE, 
dbo.Accessories_BAY.Accessories_staytes, dbo.Accessories_INV.Accessories_Active,
dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Accessories_INV.Accessories_INV_TIME
HAVING (dbo.Accessories_BAY.Accessories_staytes = 1) AND (dbo.Accessories_INV.Accessories_Active = 1)

