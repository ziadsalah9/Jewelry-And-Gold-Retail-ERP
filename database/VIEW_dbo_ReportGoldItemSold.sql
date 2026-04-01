-- =============================================
-- View: dbo.ReportGoldItemSold
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldItemSold]
AS
 CREATE VIEW [dbo].[ReportGoldItemSold] AS SELECT  dbo.FO_min.ID, COUNT(dbo.FO_min.ID) AS ItemCount, 
 dbo.FO_min.userID, dbo.FO_min.FO_name, dbo.FO_min.FO_desp, dbo.FO_min.FO_price AS Stone, dbo.FO_min.FO_GramPrice AS Supplier, 
 dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade, 
 dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.selInvoceDetels.date AS date_care, 
 dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram AS FO_TotalgramMade, dbo.FO_min.FO_desp * dbo.FO_min.FO_gram AS FO_TotaldespMade, dbo.selInvoceDetels.Active, 
 dbo.FO_min.BarCode 
 FROM dbo.FO_min INNER JOIN 
 dbo.selInvoceDetels ON dbo.FO_min.BarCode = dbo.selInvoceDetels.ItemID 
 GROUP BY dbo.FO_min.ID, dbo.FO_min.userID, dbo.FO_min.FO_name, 
 dbo.FO_min.FO_desp, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade, dbo.FO_min.FO_made, dbo.FO_min.FO_extras, 
 dbo.FO_min.FO_totalPrice, 
 dbo.FO_min.Gram_valu, dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, 
 dbo.selInvoceDetels.Active, dbo.FO_min.BarCode, dbo.selInvoceDetels.date 
 HAVING (dbo.selInvoceDetels.Active = 1) 

