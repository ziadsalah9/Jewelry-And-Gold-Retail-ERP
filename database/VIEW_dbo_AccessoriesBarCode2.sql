-- =============================================
-- View: dbo.AccessoriesBarCode2
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesBarCode2]
AS
CREATE VIEW [AccessoriesBarCode2] AS 
SELECT AccessoriesID, Accessories_NAME, Accessories_BRAND, Accessories_DESC, 
Accessories_CAT, Accessories_DEP, Accessories_model_no, Accessories_nom, Accessories_Cost, 
Accessories_Price, Accessories_NAME + SPACE(1) + CONVERT(nvarchar, AccessoriesID) AS BarCode_ID2, 
Accessories_Code, Accessories_Year, Accessories_BRAND_SHORT, 
Accessories_Supplier, Accessories_Attachments 
 FROM [Accessories_ITEM]

