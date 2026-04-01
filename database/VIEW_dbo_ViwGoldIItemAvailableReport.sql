-- =============================================
-- View: dbo.ViwGoldIItemAvailableReport
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwGoldIItemAvailableReport]
AS
CREATE VIEW [dbo].[ViwGoldIItemAvailableReport] AS SELECT
f.ID, f.userID, f.FO_name, f.FO_desp, f.FO_price, f.FO_GramPrice,
f.FO_gram, f.FO_gramMade, f.FO_made, f.FO_extras, f.FO_totalPrice, 
f.Gram_valu, f.ITEM_IMGE, f.date_care, f.FO_ItemNo, f.Item_Actv, 
f.StoneColor1, f.StonePrice1, f.StoneWeight2, f.StoneName2, 
f.StoneColor2, f.StonePrice2, f.StoneWeight3, f.StoneName3, f.StoneColor3, f.StonePrice3, f.Qty, f.BarCode, f.LastEditDate, f.ItemNote, 
f.PurInvNumber, f.MultiItem, f.GoldCaret999, f.GoldWeight999, f.BarCodeNote
FROM dbo.FO_min AS f LEFT OUTER JOIN
dbo.selInvoceDetels AS s ON f.BarCode = s.itemID AND s.Active = 1
WHERE (f.Item_Actv = 1) AND (s.itemID IS NULL)

