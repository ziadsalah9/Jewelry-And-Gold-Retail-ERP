-- =============================================
-- View: dbo.ReportGoldItemAvailable
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldItemAvailable]
AS
CREATE VIEW [dbo].[ReportGoldItemAvailable] AS SELECT DISTINCT  dbo.FO_min.ID, dbo.FO_min.userID,  
dbo.FO_min.FO_name, dbo.FO_min.FO_desp, dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade,  
dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.FO_min.date_care,  
dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram AS FO_TotalgramMade, dbo.FO_min.FO_desp * dbo.FO_min.FO_gram AS FO_TotaldespMade, dbo.FO_min.BarCode 
FROM dbo.FO_min LEFT OUTER JOIN 
dbo.selInvoceDetels ON dbo.FO_min.BarCode = dbo.selInvoceDetels.ItemID 
WHERE (dbo.selInvoceDetels.ItemID IS NULL) OR 
(dbo.selInvoceDetels.ItemID NOT IN 
(SELECT     ItemID 
FROM  dbo.selInvoceDetels AS selInvoceDetels_1 
WHERE      (Active = 1))) AND (dbo.selInvoceDetels.Active = 0) 
GROUP BY dbo.FO_min.ID, dbo.FO_min.userID, dbo.FO_min.FO_name, dbo.FO_min.FO_desp, 
 dbo.FO_min.FO_price, dbo.FO_min.FO_GramPrice, dbo.FO_min.FO_gram, dbo.FO_min.FO_gramMade,  
dbo.FO_min.FO_made, dbo.FO_min.FO_extras, dbo.FO_min.FO_totalPrice, dbo.FO_min.Gram_valu, dbo.FO_min.date_care, dbo.FO_min.FO_gramMade * dbo.FO_min.FO_gram,  
dbo.FO_min.FO_desp * dbo.FO_min.FO_gram, dbo.FO_min.BarCode, dbo.FO_min.Item_Actv 
HAVING  (dbo.FO_min.Item_Actv > 0)

