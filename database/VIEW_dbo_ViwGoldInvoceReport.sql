-- =============================================
-- View: dbo.ViwGoldInvoceReport
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwGoldInvoceReport]
AS
CREATE VIEW [dbo].[ViwGoldInvoceReport]AS SELECT dbo.selInvoceDetels.item_name, dbo.selInvoceDetels.Castomerid, dbo.selInvoceDetels.itemID, dbo.selInvoceDetels.item_GramPrice, dbo.selInvoceDetels.item_gram, dbo.selInvoceDetels.item_gramMade, 
dbo.selInvoceDetels.item_extrasPRICE, dbo.selInvoceDetels.item_extrasMAZAN, dbo.selInvoceDetels.item_totalPrice, dbo.selInvoceDetels.item_cantrey, dbo.selInvoceDetels.MetalPrice, dbo.selInvoceDetels.userID, 
dbo.BAY.TOTAL_mony, dbo.BAY.KENT, dbo.BAY.CACH, dbo.BAY.arbic_tayb, dbo.BAY.balance, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, 
dbo.CastomerDETELS.CastomerNA, dbo.BAY.staytes, dbo.CastomerDETELS.foto, dbo.selInvoceDetels.invoc_date_time, dbo.FO_min.Gram_valu, dbo.selInvoceDetels.qunt, dbo.selInvoceDetels.nots, dbo.cacher.cacher_name,
dbo.selInvoceDetels.date, dbo.BAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, dbo.selInvoceDetels.item_gramMade * dbo.selInvoceDetels.item_gram AS Total_gramMade, dbo.BAY.English_tayb, 
dbo.selInvoceDetels.Active, dbo.BAY.Notes, dbo.BAY.PayMethod, dbo.cacher.CashierSignature, dbo.selInvoceDetels.StoneWeight2, dbo.selInvoceDetels.StoneWeight3, dbo.selInvoceDetels.StonePrice2, 
dbo.selInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.FO_min.BarCode, dbo.selInvoceDetels.item_desp, dbo.selInvoceDetels.cacher, dbo.selInvoceDetels.Cash, 
dbo.selInvoceDetels.sroom_name, dbo.selInvoceDetels.invoc_time, dbo.selInvoceDetels.StoneName1, dbo.selInvoceDetels.StoneColor1, dbo.selInvoceDetels.StoneName2, dbo.selInvoceDetels.StoneColor2, 
dbo.selInvoceDetels.StoneName3, dbo.selInvoceDetels.StoneColor3, dbo.selInvoceDetels.ID, dbo.selInvoceDetels.StonePriceType1, dbo.selInvoceDetels.StonePriceType2, dbo.selInvoceDetels.StonePriceType3, 
dbo.selInvoceDetels.GoledKarat, dbo.FO_min.ITEM_IMGE, dbo.FO_min.FO_desp, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, PayMethod_1.PayMethodAr AS PayMethodAr1, 
PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.BAY.PayMethod1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, dbo.BAY.PayMethod2, 
PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, dbo.BAY.PayMethod3, PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4,
dbo.BAY.PayMethod4, dbo.BAY.Bank1, dbo.BAY.Bank2, dbo.BAY.Bank3, dbo.BAY.Bank4, dbo.BAY.Active AS BAYActive, dbo.BAY.BAY_ID, dbo.selInvoceDetels.ItemVatType, dbo.selInvoceDetels.ItemVat, dbo.BAY.InvVatType,
dbo.BAY.InvVat, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, dbo.FO_min.GoldCaret999, dbo.FO_min.GoldWeight999, dbo.BAY.PurchaseInvNumber,dbo.BAY.PaymentReceipt,dbo.BAY.PaymentTransNumber, 
dbo.BAY.PurchaseGold
FROM dbo.BAY INNER JOIN
dbo.selInvoceDetels ON dbo.BAY.BAY_SARYAL = dbo.selInvoceDetels.invoc_time INNER JOIN
dbo.CastomerDETELS ON dbo.selInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
dbo.cacher ON dbo.selInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN
dbo.PayMethod ON dbo.BAY.PayMethod = dbo.PayMethod.ID INNER JOIN
dbo.PayMethod AS PayMethod_1 ON dbo.BAY.PayMethod1 = PayMethod_1.ID INNER JOIN
dbo.PayMethod AS PayMethod_2 ON dbo.BAY.PayMethod2 = PayMethod_2.ID INNER JOIN
dbo.PayMethod AS PayMethod_3 ON dbo.BAY.PayMethod3 = PayMethod_3.ID INNER JOIN
dbo.PayMethod AS PayMethod_4 ON dbo.BAY.PayMethod4 = PayMethod_4.ID LEFT OUTER JOIN
dbo.FO_min ON dbo.selInvoceDetels.itemID = dbo.FO_min.BarCode CROSS JOIN
dbo.Settings CROSS JOIN
dbo.comp_inform
WHERE(dbo.BAY.Active = 1) AND (dbo.selInvoceDetels.Active = 1)

