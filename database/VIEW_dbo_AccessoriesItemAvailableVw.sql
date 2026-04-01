-- =============================================
-- View: dbo.AccessoriesItemAvailableVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesItemAvailableVw]
AS
CREATE VIEW [AccessoriesItemAvailableVw] AS SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC,  Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom,  Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price,  [user].user_name, Accessories_INV.Accessories_Active, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier,  Accessories_ITEM.Accessories_PIC FROM Accessories_ITEM INNER JOIN [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id LEFT OUTER JOIN Accessories_INV ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID WHERE (Accessories_INV.Accessories_INV_ITEM_ID IS NULL) OR (Accessories_INV.Accessories_Active = 0) 

