-- =============================================
-- View: dbo.AccessoriesItemAllVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesItemAllVw]
AS
CREATE VIEW [AccessoriesItemAllVw] AS 
SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_DESC, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom,  Accessories_ITEM.Accessories_PIC, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET,  Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price, [user].user_name, Accessories_ITEM.Accessories_Supplier,  Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Code, Accessories_ITEM.Accessories_Year, Accessories_ITEM.Item_Actv FROM  Accessories_ITEM INNER JOIN [user] ON Accessories_ITEM.Accessories_USER_CRET = [user].user_id WHERE (Accessories_ITEM.Item_Actv = 1)

