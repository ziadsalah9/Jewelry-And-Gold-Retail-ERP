-- =============================================
-- View: dbo.ReportWholesalePurchases
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportWholesalePurchases]
AS
 CREATE VIEW [dbo].[ReportWholesalePurchases] AS SELECT 
 InvID, TOTAL_mony, KENT, CACH, arbic_tayb, balance, 
 English_tayb, Notes, Active, InvType, CastomerCAIVELid, 
 ItemDes, GoldCaretBasic, GoldCaretBasicValue, GoldCaretTrans, 
 GoldCaretTransValue, GoldCaretPrice, TotalGoledPrice, 
 MakeCharge, TotalMakeCharge, InvDateTime, CastomerNAme, 
 CastomerADr, CastomerTE, CastomerNA, foto, Signature, fotoBack, 
 CastomerNameEn, user_name, cacher_name, CashierSignature, 
 COMP_NAME, COMP_NAME_SHORT, SGAL_TAGARE, PHONE_NOMPER, FAX_NOMPER, PayMethodAr, PayMethodEn 
 FROM dbo.ReportDetailsWholesalePurchases 

