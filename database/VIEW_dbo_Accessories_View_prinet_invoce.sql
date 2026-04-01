-- =============================================
-- View: dbo.Accessories_View_prinet_invoce
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_View_prinet_invoce]
AS
CREATE VIEW [dbo].[Accessories_View_prinet_invoce] AS SELECT 
dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, 
dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, 
dbo.CastomerDETELS.Signature, dbo.Accessories_INV.Accessories_INV_CASTOMER_ID, 
dbo.[user].user_name, dbo.Accessories_ITEM.Accessories_NAME, 
dbo.Accessories_ITEM.Accessories_BRAND, dbo.Accessories_ITEM.Accessories_DESC, 
dbo.Accessories_ITEM.Accessories_CAT, dbo.Accessories_ITEM.Accessories_DEP, 
dbo.Accessories_ITEM.Accessories_model_no, dbo.Accessories_ITEM.Accessories_nom, 
dbo.Accessories_ITEM.Accessories_PIC, dbo.Accessories_ITEM.Accessories_TIME, 
dbo.Accessories_ITEM.Accessories_DATE_CRE, dbo.Accessories_ITEM.Accessories_USER_CRET, 
dbo.Accessories_INV.Accessories_INV_ITEM_ID, dbo.Accessories_INV.Accessories_INV_QUNT, 
dbo.Accessories_INV.Accessories_INV_un_price, dbo.Accessories_INV.Accessories_INV_total_price, 
dbo.Accessories_INV.Accessories_INV_DATE, dbo.Accessories_INV.Accessories_INV_TIME, 
dbo.Accessories_INV.Accessories_INV_USER, dbo.Accessories_INV.Accessories_INV_NO_ID, 
dbo.Accessories_BAY.Accessories_BAY_SARYAL, dbo.Accessories_BAY.Accessories_TOTAL_mony, 
dbo.Accessories_BAY.Accessories_KENT, dbo.Accessories_BAY.Accessories_CACH, dbo.Accessories_BAY.Accessories_arbic_tayb, dbo.Accessories_BAY.Accessories_balance, 
dbo.Accessories_BAY.Accessories_staytes, dbo.Accessories_BAY.Accessories_Casher, dbo.cacher.cacher_name, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerCAIVELid, 
dbo.Accessories_BAY.Accessories_Active, dbo.Accessories_BAY.Accessories_Notes, dbo.Accessories_BAY.Accessories_PayMethod, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, 
dbo.Accessories_ITEM.Accessories_Year, dbo.Accessories_ITEM.Accessories_Attachments, dbo.cacher.CashierSignature, dbo.Accessories_INV.AccessoriesInvoceDESC, 
dbo.Accessories_INV.AccessoriesBrand_ID, dbo.Accessories_INV.AccessoriesGUARRANTYYEAR, dbo.Accessories_INV.AccessoriesType_ID 
FROM dbo.PayMethod INNER JOIN 
dbo.Accessories_BAY ON dbo.PayMethod.ID = dbo.Accessories_BAY.Accessories_PayMethod RIGHT OUTER JOIN
dbo.Accessories_INV INNER JOIN
dbo.Accessories_ITEM ON dbo.Accessories_INV.Accessories_INV_ITEM_ID = dbo.Accessories_ITEM.AccessoriesID ON 
dbo.Accessories_BAY.Accessories_BAY_SARYAL = dbo.Accessories_INV.Accessories_INV_NO_ID LEFT OUTER JOIN
dbo.cacher ON dbo.Accessories_BAY.Accessories_Casher = dbo.cacher.svil_id LEFT OUTER JOIN
dbo.[user] ON dbo.Accessories_INV.Accessories_INV_USER = dbo.[user].user_id LEFT OUTER JOIN
dbo.CastomerDETELS ON dbo.Accessories_INV.Accessories_INV_CASTOMER_ID = dbo.CastomerDETELS.CastomerCAIVELid
WHERE(dbo.Accessories_BAY.Accessories_staytes = 1)

