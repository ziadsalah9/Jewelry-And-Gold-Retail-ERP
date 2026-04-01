-- =============================================
-- View: dbo.ReportSilvertemAvailable
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportSilvertemAvailable]
AS
CREATE VIEW [dbo].[ReportSilvertemAvailable] AS SELECT DISTINCT 
dbo.SilverItem.ID, dbo.SilverItem.userID, dbo.SilverItem.FO_name,
dbo.SilverItem.FO_desp, dbo.SilverItem.FO_price, 
dbo.SilverItem.FO_GramPrice, dbo.SilverItem.FO_gram, 
dbo.SilverItem.FO_gramMade, dbo.SilverItem.FO_made, 
dbo.SilverItem.FO_extras, dbo.SilverItem.FO_totalPrice, 
dbo.SilverItem.Gram_valu, dbo.SilverItem.date_care, 
dbo.SilverItem.FO_gramMade * dbo.SilverItem.FO_gram AS 
FO_TotalgramMade, dbo.SilverItem.FO_desp * 
dbo.SilverItem.FO_gram AS FO_TotaldespMade, dbo.SilverItem.BarCode, 
dbo.SilverItem.StoneColor1, dbo.SilverItem.StonePrice1, 
dbo.SilverItem.StoneWeight2, dbo.SilverItem.StoneName2, 
dbo.SilverItem.StoneColor2, dbo.SilverItem.StonePrice2, 
dbo.SilverItem.StoneWeight3, 
dbo.SilverItem.StoneName3, dbo.SilverItem.StoneColor3,
dbo.SilverItem.StonePrice3, dbo.SilverItem.Qty, 
dbo.SilverItem.LastEditDate, dbo.SilverItem.ItemNote, dbo.SilverItem.PurInvNumber,
dbo.SilverItem.MultiItem, dbo.SilverItem.GoldCaret999, dbo.SilverItem.GoldWeight999
FROM dbo.SilverItem LEFT OUTER JOIN
dbo.SilverInvoceDetels ON dbo.SilverItem.BarCode = dbo.SilverInvoceDetels.itemID
WHERE (dbo.SilverInvoceDetels.itemID IS NULL) OR
(dbo.SilverInvoceDetels.itemID NOT IN
(SELECT     itemID
FROM dbo.SilverInvoceDetels AS SilverInvoceDetels_1
WHERE (Active = 1))) AND (dbo.SilverInvoceDetels.Active = 0)
GROUP BY dbo.SilverItem.ID, dbo.SilverItem.userID, dbo.SilverItem.FO_name,
dbo.SilverItem.FO_desp, dbo.SilverItem.FO_price, 
dbo.SilverItem.FO_GramPrice, dbo.SilverItem.FO_gram, 
dbo.SilverItem.FO_gramMade, dbo.SilverItem.FO_made, dbo.SilverItem.FO_extras,
dbo.SilverItem.FO_totalPrice, dbo.SilverItem.Gram_valu, dbo.SilverItem.date_care, 
dbo.SilverItem.FO_gramMade * dbo.SilverItem.FO_gram, dbo.SilverItem.FO_desp * 
dbo.SilverItem.FO_gram, dbo.SilverItem.BarCode, dbo.SilverItem.Item_Actv, dbo.SilverItem.StoneColor1,
dbo.SilverItem.StonePrice1, dbo.SilverItem.StoneWeight2, dbo.SilverItem.StoneName2, 
dbo.SilverItem.StoneColor2, dbo.SilverItem.StonePrice2, dbo.SilverItem.StoneWeight3, dbo.SilverItem.StoneName3,
dbo.SilverItem.StoneColor3, dbo.SilverItem.StonePrice3, dbo.SilverItem.Qty, 
dbo.SilverItem.LastEditDate, dbo.SilverItem.ItemNote, dbo.SilverItem.PurInvNumber, dbo.SilverItem.MultiItem,
dbo.SilverItem.GoldCaret999, dbo.SilverItem.GoldWeight999
HAVING (dbo.SilverItem.Item_Actv > 0)

