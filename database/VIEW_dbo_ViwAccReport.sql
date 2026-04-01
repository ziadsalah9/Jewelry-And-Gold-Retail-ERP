-- =============================================
-- View: dbo.ViwAccReport
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwAccReport]
AS
CREATE VIEW [dbo].[ViwAccReport] AS SELECT dbo.Accessories_INV.Accessories_INV_CASTOMER_ID, 
dbo.Accessories_INV.Accessories_INV_ID, dbo.Accessories_INV.Accessories_INV_ITEM_ID, dbo.Accessories_INV.Accessories_INV_QUNT, 
dbo.Accessories_INV.Accessories_INV_un_price, dbo.Accessories_INV.Accessories_INV_total_price, dbo.Accessories_INV.Accessories_INV_DATE, dbo.Accessories_INV.Accessories_INV_TIME, 
dbo.Accessories_INV.Accessories_INV_USER, dbo.Accessories_INV.Accessories_INV_NO_ID, dbo.Accessories_INV.Accessories_Active, dbo.Accessories_INV.AccessoriesInvoceDESC, 
dbo.Accessories_INV.AccessoriesBrand_ID, dbo.Accessories_INV.AccessoriesGUARRANTYYEAR, dbo.Accessories_INV.AccessoriesType_ID, dbo.Accessories_INV.ItemName, 
dbo.Accessories_INV.Code, dbo.Accessories_INV.Supplier, dbo.Accessories_INV.Department, dbo.Accessories_INV.Category, dbo.Accessories_INV.Attachment, dbo.Accessories_INV.Cost, 
dbo.Accessories_INV.Cashier, dbo.Accessories_INV.IMG, dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.Accessories_BAY.Accessories_TOTAL_mony, dbo.Accessories_BAY.Accessories_KENT,
dbo.Accessories_BAY.Accessories_CACH, dbo.Accessories_BAY.Accessories_arbic_tayb, dbo.Accessories_BAY.Accessories_balance, dbo.Accessories_BAY.Accessories_staytes, 
dbo.Accessories_BAY.Accessories_Casher, dbo.Accessories_BAY.Accessories_PaymentType, dbo.Accessories_BAY.Accessories_Active AS AccessoriesInvActive, dbo.Accessories_BAY.Accessories_Notes, 
dbo.Accessories_BAY.Accessories_PayMethod, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, 
dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.PayMethod.PayMethodAr, 
dbo.PayMethod.PayMethodEn , dbo.Accessories_INV.ModelNo,dbo.Accessories_INV.Note, dbo.Accessories_INV.ItemNo 
FROM  dbo.Accessories_INV INNER JOIN
dbo.Accessories_BAY ON dbo.Accessories_INV.Accessories_INV_NO_ID = dbo.Accessories_BAY.Accessories_BAY_SARYAL INNER JOIN
dbo.CastomerDETELS ON dbo.Accessories_INV.Accessories_INV_CASTOMER_ID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
dbo.PayMethod ON dbo.Accessories_BAY.Accessories_PayMethod = dbo.PayMethod.ID

