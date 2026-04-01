-- =============================================
-- View: dbo.ReportDetailsWholesalePurchases
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportDetailsWholesalePurchases]
AS
 CREATE VIEW [ReportDetailsWholesalePurchases] AS SELECT dbo.BAYWholesale.ID, 
 dbo.BAYWholesale.InvIDAuto, dbo.BAYWholesale.InvID, dbo.BAYWholesale.TOTAL_mony, dbo.BAYWholesale.KENT, dbo.BAYWholesale.CACH, 
 dbo.BAYWholesale.arbic_tayb, dbo.BAYWholesale.balance, dbo.BAYWholesale.English_tayb, 
 dbo.BAYWholesale.Notes, dbo.BAYWholesale.Active, dbo.BAYWholesale.InvType, 
 dbo.TPSellBuyWholesale.ID AS IDTPSellBuyWholesale, 
 dbo.TPSellBuyWholesale.InvIDAuto AS InvIDAutoTPSellBuyWholesale, dbo.TPSellBuyWholesale.InvID AS InvIDTPSellBuyWholesale, 
 dbo.TPSellBuyWholesale.CashierID, dbo.TPSellBuyWholesale.CastomerCAIVELid, 
 dbo.TPSellBuyWholesale.ItemDes, dbo.TPSellBuyWholesale.ItemImage, 
 dbo.TPSellBuyWholesale.GoldCaretBasic, dbo.TPSellBuyWholesale.GoldCaretBasicValue, 
 dbo.TPSellBuyWholesale.GoldCaretTrans, dbo.TPSellBuyWholesale.GoldCaretTransValue, 
 dbo.TPSellBuyWholesale.GoldCaretPrice, dbo.TPSellBuyWholesale.TotalGoledPrice, 
 dbo.TPSellBuyWholesale.MakeCharge, dbo.TPSellBuyWholesale.TotalMakeCharge, 
 dbo.TPSellBuyWholesale.InvDate, dbo.TPSellBuyWholesale.InvDateTime, 
 dbo.TPSellBuyWholesale.ActualInvDateTime, dbo.TPSellBuyWholesale.InvActive, dbo.TPSellBuyWholesale.ItemActive, 
 dbo.TPSellBuyWholesale.InvType AS InvTypeTPSellBuyWholesale, 
  dbo.TPSellBuyWholesale.InvActiveaComp, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, 
  dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, 
  dbo.CastomerDETELS.CastomerNameEn, dbo.[user].user_name, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, dbo.COMPANY_BAY_DETELS.COMP_NAME, 
  dbo.COMPANY_BAY_DETELS.COMP_NAME_SHORT, dbo.COMPANY_BAY_DETELS.SGAL_TAGARE, dbo.COMPANY_BAY_DETELS.PHONE_NOMPER, dbo.COMPANY_BAY_DETELS.FAX_NOMPER, 
  dbo.COMPANY_BAY_DETELS.LOC_NOMPER, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn 
  FROM  dbo.PayMethod INNER JOIN 
  dbo.BAYWholesale ON dbo.PayMethod.ID = dbo.BAYWholesale.PayMethod FULL OUTER JOIN 
  dbo.[user] RIGHT OUTER JOIN 
  dbo.TPSellBuyWholesale ON dbo.[user].user_id = dbo.TPSellBuyWholesale.UserID LEFT OUTER JOIN 
  dbo.CastomerDETELS ON dbo.TPSellBuyWholesale.CastomerCAIVELid = dbo.CastomerDETELS.CastomerCAIVELid LEFT OUTER JOIN 
  dbo.cacher ON dbo.TPSellBuyWholesale.CashierID = dbo.cacher.svil_id LEFT OUTER JOIN 
  dbo.COMPANY_BAY_DETELS ON dbo.TPSellBuyWholesale.COM_ID = dbo.COMPANY_BAY_DETELS.COM_ID ON dbo.BAYWholesale.InvID = dbo.TPSellBuyWholesale.InvID 
  WHERE (dbo.BAYWholesale.Active = 1) AND (dbo.TPSellBuyWholesale.InvActive = 1) AND (dbo.TPSellBuyWholesale.ItemActive = 1) 

