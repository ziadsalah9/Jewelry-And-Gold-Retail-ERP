-- =============================================
-- View: dbo.AccessoriesItemSoldVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesItemSoldVw]
AS
CREATE VIEW [AccessoriesItemSoldVw] AS 
 SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, 
 Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom, 
 Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, [user].user_name, 
 COUNT (Accessories_ITEM.AccessoriesID) AS ItemCount, Accessories_ITEM.Accessories_Price, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, 
 Accessories_ITEM.Accessories_Supplier 
 FROM Accessories_ITEM INNER JOIN 
 [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id INNER JOIN Accessories_INV ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID GROUP BY Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, 
 Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, [user].user_name, Accessories_ITEM.Accessories_Price, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier HAVING (Accessories_INV.Accessories_Active = 1)

