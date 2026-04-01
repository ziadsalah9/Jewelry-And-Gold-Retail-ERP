-- =============================================
-- View: dbo.GoldSilverAvailable
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[GoldSilverAvailable]
AS
CREATE VIEW [GoldSilverAvailable] AS SELECT FO_min.ID, FO_min.userID, FO_min.FO_name, FO_min.FO_desp, FO_min.FO_price, FO_min.FO_GramPrice, FO_min.FO_gram, FO_min.FO_gramMade,  FO_min.FO_made, FO_min.FO_extras, FO_min.FO_totalPrice, FO_min.Gram_valu, FO_min.ITEM_IMGE, FO_min.date_care, FO_min.FO_ItemNo,  FO_min.StoneColor1, FO_min.StonePrice1, FO_min.StoneWeight2, FO_min.StoneName2, FO_min.StoneColor2, FO_min.StonePrice2, FO_min.StoneWeight3,  FO_min.StoneName3, FO_min.StoneColor3, FO_min.StonePrice3, FO_min.Qty, FO_min.BarCode, FO_min.Item_Actv FROM FO_min LEFT OUTER JOIN selInvoceDetels ON FO_min.ID = selInvoceDetels.itemID WHERE (selInvoceDetels.itemID IS NULL) OR (selInvoceDetels.Active = 0) 

