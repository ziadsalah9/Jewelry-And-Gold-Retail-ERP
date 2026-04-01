-- =============================================
-- View: dbo.Accessories_ITEMVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_ITEMVw]
AS
 CREATE VIEW [Accessories_ITEMVw] AS SELECT     AccessoriesID, Accessories_NAME, Accessories_BRAND, Accessories_DESC, Accessories_CAT, Accessories_DEP, Accessories_model_no, Accessories_nom, Accessories_PIC, Accessories_TIME, 
 Accessories_DATE_CRE, Accessories_USER_CRET, Accessories_Cost, Accessories_Price, Accessories_Supplier, Accessories_Attachments 
 FROM [Accessories_ITEM] 

