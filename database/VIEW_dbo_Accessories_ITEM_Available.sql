-- =============================================
-- View: dbo.Accessories_ITEM_Available
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_ITEM_Available]
AS
 CREATE VIEW [Accessories_ITEM_Available] AS 
 SELECT     Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC, 
 Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_ITEM.Accessories_model_no, Accessories_ITEM.Accessories_nom, Accessories_ITEM.Accessories_PIC, Accessories_ITEM.Accessories_TIME, Accessories_ITEM.Accessories_DATE_CRE, Accessories_ITEM.Accessories_USER_CRET, Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Price, Accessories_ITEM.Accessories_Attachments, Accessories_ITEM.Accessories_Supplier FROM         Accessories_ITEM LEFT OUTER JOIN Accessories_INV ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID WHERE     (Accessories_INV.Accessories_INV_ITEM_ID IS NULL) 
 OR (Accessories_INV.Accessories_Active = 0)

