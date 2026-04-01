-- =============================================
-- View: dbo.ViwSilverInvoceReport
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwSilverInvoceReport]
AS
CREATE VIEW dbo.ViwSilverInvoceReport
AS
SELECT        dbo.SilverInvoceDetels.item_name, dbo.SilverInvoceDetels.Castomerid, dbo.SilverInvoceDetels.itemID, dbo.SilverInvoceDetels.item_GramPrice, dbo.SilverInvoceDetels.item_gram, dbo.SilverInvoceDetels.item_gramMade, 
                         dbo.SilverInvoceDetels.item_extrasPRICE, dbo.SilverInvoceDetels.item_extrasMAZAN, dbo.SilverInvoceDetels.item_totalPrice, dbo.SilverInvoceDetels.item_cantrey, dbo.SilverInvoceDetels.MetalPrice, 
                         dbo.SilverInvoceDetels.userID, dbo.SilverBAY.TOTAL_mony, dbo.SilverBAY.KENT, dbo.SilverBAY.CACH, dbo.SilverBAY.arbic_tayb, dbo.SilverBAY.balance, dbo.CastomerDETELS.CastomerNAme, 
                         dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.SilverBAY.staytes, dbo.CastomerDETELS.foto, dbo.SilverInvoceDetels.invoc_date_time, 
                         dbo.SilverItem.Gram_valu, dbo.SilverInvoceDetels.qunt, dbo.SilverInvoceDetels.nots, dbo.cacher.cacher_name, dbo.SilverInvoceDetels.date, dbo.SilverBAY.BAY_SARYAL, dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, 
                         dbo.SilverInvoceDetels.item_gramMade * dbo.SilverInvoceDetels.item_gram AS Total_gramMade, dbo.SilverBAY.English_tayb, dbo.SilverInvoceDetels.Active, dbo.SilverBAY.Notes, dbo.SilverBAY.PayMethod, 
                         dbo.cacher.CashierSignature, dbo.SilverInvoceDetels.StoneWeight2, dbo.SilverInvoceDetels.StoneWeight3, dbo.SilverInvoceDetels.StonePrice2, dbo.SilverInvoceDetels.StonePrice3, dbo.PayMethod.PayMethodAr, 
                         dbo.PayMethod.PayMethodEn, dbo.SilverItem.BarCode, dbo.SilverInvoceDetels.item_desp, dbo.SilverInvoceDetels.cacher, dbo.SilverInvoceDetels.Cash, dbo.SilverInvoceDetels.sroom_name, 
                         dbo.SilverInvoceDetels.invoc_time, dbo.SilverInvoceDetels.StoneName1, dbo.SilverInvoceDetels.StoneColor1, dbo.SilverInvoceDetels.StoneName2, dbo.SilverInvoceDetels.StoneColor2, dbo.SilverInvoceDetels.StoneName3, 
                         dbo.SilverInvoceDetels.StoneColor3, dbo.SilverInvoceDetels.ID, dbo.SilverInvoceDetels.StonePriceType1, dbo.SilverInvoceDetels.StonePriceType2, dbo.SilverInvoceDetels.StonePriceType3, dbo.SilverInvoceDetels.GoledKarat, 
                         dbo.SilverItem.ITEM_IMGE, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_1.PayMethodEn AS PayMethodEn1, dbo.SilverBAY.PayMethod1, 
                         PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, dbo.SilverBAY.PayMethod2, PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, 
                         dbo.SilverBAY.PayMethod3, PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, dbo.SilverBAY.PayMethod4, dbo.SilverBAY.Bank1, dbo.SilverBAY.Bank2, dbo.SilverBAY.Bank3, 
                         dbo.SilverBAY.Bank4, dbo.SilverBAY.Active AS SilverBAYActive, dbo.SilverBAY.BAY_ID, dbo.SilverInvoceDetels.ItemVatType, dbo.SilverInvoceDetels.ItemVat, dbo.SilverBAY.InvVatType, dbo.SilverBAY.InvVat, 
                         dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1, dbo.SilverBAY.MaxID, dbo.SilverBAY.PurchaseInvNumber, dbo.SilverBAY.PurchaseGold, 
                         dbo.SilverBAY.PaymentReceipt, dbo.SilverBAY.PaymentTransNumber
FROM            dbo.SilverBAY INNER JOIN
                         dbo.SilverInvoceDetels ON dbo.SilverBAY.BAY_SARYAL = dbo.SilverInvoceDetels.invoc_time INNER JOIN
                         dbo.CastomerDETELS ON dbo.SilverInvoceDetels.Castomerid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
                         dbo.cacher ON dbo.SilverInvoceDetels.cacher = dbo.cacher.svil_id INNER JOIN
                         dbo.PayMethod ON dbo.SilverBAY.PayMethod = dbo.PayMethod.ID INNER JOIN
                        

