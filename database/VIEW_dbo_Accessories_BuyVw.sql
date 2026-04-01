-- =============================================
-- View: dbo.Accessories_BuyVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_BuyVw]
AS
 CREATE VIEW [dbo].[Accessories_BuyVw] AS 
 SELECT     AccessoriesID, Accessories_NAME, Accessories_BRAND, 
 Accessories_DESC, Accessories_ItemStatus, Accessories_CAT, 
 Accessories_DEP, Accessories_model_no, Accessories_nom, 
 Accessories_TIME, Accessories_DATE_CRE, Accessories_USER_CRET, 
 Accessories_CID, Accessories_Price, Accessories_InvoiceNo, 
 Accessories_YearOfWarr, Accessories_Attachments FROM  dbo.Accessories_Buy 

