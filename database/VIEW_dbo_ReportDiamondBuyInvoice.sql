-- =============================================
-- View: dbo.ReportDiamondBuyInvoice
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportDiamondBuyInvoice]
AS
CREATE VIEW [dbo].[ReportDiamondBuyInvoice] AS SELECT dbo.Buy_Diamond.castomer_id, 
dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, 
dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.Buy_Diamond.val_gold, 
dbo.Buy_Diamond.GOLD_mezan, dbo.Buy_Diamond.bay_total_price, dbo.Buy_Diamond.DIMO_dep, 
dbo.Buy_Diamond.DIM_na9awa, dbo.Buy_Diamond.DIMO_mezan, dbo.Buy_Diamond.ext_coler, 
dbo.Buy_Diamond.qult, dbo.Buy_Diamond.sarual, dbo.Buy_Diamond.test_12, 
dbo.Buy_Diamond.test_11, dbo.Buy_Diamond.inv_id, dbo.Bay_Diamond_mony.total_price, 
dbo.Bay_Diamond_mony.cach, dbo.Bay_Diamond_mony.kenet, dbo.Bay_Diamond_mony.arabik, 
dbo.Bay_Diamond_mony.date, dbo.Settings.PIC1, dbo.Buy_Diamond.Notes, 
dbo.Bay_Diamond_mony.English, dbo.Buy_Diamond.B_Diamond_id, dbo.Buy_Diamond.Active, 
dbo.CastomerDETELS.CastomerID, dbo.CastomerDETELS.CastomerCAIVELid, 
dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.Bay_Diamond_mony.bay_id, 
dbo.Bay_Diamond_mony.saryal, dbo.Bay_Diamond_mony.Active AS ActiveBayDiamond_mony, 
dbo.Bay_Diamond_mony.PayMethod, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, 
dbo.cacher.CashierSignature FROM dbo.Buy_Diamond INNER JOIN 
dbo.CastomerDETELS ON dbo.Buy_Diamond.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN 
dbo.Bay_Diamond_mony ON dbo.Buy_Diamond.inv_id = dbo.Bay_Diamond_mony.saryal LEFT OUTER JOIN 
dbo.cacher ON dbo.Buy_Diamond.qult = dbo.cacher.cacher_name LEFT OUTER JOIN 
dbo.PayMethod ON dbo.Bay_Diamond_mony.PayMethod = dbo.PayMethod.ID CROSS JOIN 
dbo.Settings WHERE (dbo.Buy_Diamond.Active = 1)

