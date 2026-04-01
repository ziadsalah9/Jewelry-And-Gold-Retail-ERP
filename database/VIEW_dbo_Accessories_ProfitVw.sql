-- =============================================
-- View: dbo.Accessories_ProfitVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_ProfitVw]
AS
CREATE VIEW [Accessories_ProfitVw] AS 
SELECT Accessories_ITEM.AccessoriesID, Accessories_ITEM.Accessories_NAME, Accessories_ITEM.Accessories_BRAND, Accessories_ITEM.Accessories_DESC,  
Accessories_ITEM.Accessories_CAT, Accessories_ITEM.Accessories_DEP, Accessories_INV.Accessories_INV_total_price, Accessories_INV.Accessories_INV_DATE,  
Accessories_ITEM.Accessories_Cost, Accessories_ITEM.Accessories_Supplier, Accessories_INV.Accessories_INV_NO_ID 
FROM Accessories_ITEM INNER JOIN Accessories_INV 
ON Accessories_ITEM.AccessoriesID = Accessories_INV.Accessories_INV_ITEM_ID 

