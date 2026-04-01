-- =============================================
-- View: dbo.AccessoriesSellDetailed
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesSellDetailed]
AS
CREATE VIEW [AccessoriesSellDetailed] AS 
SELECT CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, 
Accessories_INV.Accessories_INV_CASTOMER_ID, [user].user_name, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET, Accessories_INV.Accessories_INV_ITEM_ID, Accessories_INV.Accessories_INV_QUNT, Accessories_INV.Accessories_INV_un_price, Accessories_INV.Accessories_INV_total_price, Accessories_INV.Accessories_INV_DATE, Accessories_INV.Accessories_INV_TIME, Accessories_INV.Accessories_INV_USER, Accessories_INV.Accessories_INV_NO_ID, Accessories_BAY.Accessories_BAY_SARYAL, Accessories_BAY.Accessories_TOTAL_mony, Accessories_BAY.Accessories_KENT, Accessories_BAY.Accessories_CACH, Accessories_BAY.Accessories_arbic_tayb, Accessories_BAY.Accessories_balance, Accessories_BAY.Accessories_staytes, Accessories_BAY.Accessories_Casher, cacher.cacher_name, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier FROM [user] RIGHT OUTER JOIN Accessories_INV INNER JOIN Accessories_ITEM ON Accessories_INV.Accessories_INV_ITEM_ID = Accessories_ITEM.AccessoriesID ON 
[user].user_id = Accessories_INV.Accessories_INV_USER LEFT OUTER JOIN CastomerDETELS ON Accessories_INV.Accessories_INV_CASTOMER_ID = CastomerDETELS.CastomerCAIVELid LEFT OUTER JOIN cacher RIGHT OUTER JOIN Accessories_BAY ON cacher.svil_id = Accessories_BAY.Accessories_Casher ON 
Accessories_INV.Accessories_INV_NO_ID = Accessories_BAY.Accessories_BAY_SARYAL WHERE (Accessories_BAY.Accessories_staytes = 1) AND (Accessories_INV.Accessories_Active = 1)

