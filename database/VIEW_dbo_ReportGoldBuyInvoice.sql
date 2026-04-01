-- =============================================
-- View: dbo.ReportGoldBuyInvoice
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldBuyInvoice]
AS
CREATE VIEW [dbo].[ReportGoldBuyInvoice] AS SELECT dbo.Buy_Gold.castomer_id,
dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE,
dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, 
dbo.Buy_Gold.bay_val, dbo.Buy_Gold.bay_mazan, dbo.Buy_Gold.bay_gram_price,
dbo.Buy_Gold.bay_total_price, dbo.bay_goled_mony.total_price, dbo.bay_goled_mony.cach, dbo.bay_goled_mony.kenet, 
dbo.bay_goled_mony.arabik, dbo.Buy_Gold.inv_id, dbo.bay_goled_mony.date,
dbo.CastomerDETELS.Signature, dbo.Settings.PIC1, dbo.bay_goled_mony.English, dbo.Buy_Gold.Item_Des, dbo.Buy_Gold.INV_Actv, 
dbo.CastomerDETELS.fotoBack, dbo.bay_goled_mony.INV_Actv AS INV_Actv_bay,
dbo.bay_goled_mony.TIME_INV, dbo.bay_goled_mony.Cashier, dbo.cacher.cacher_name, dbo.cacher.CashierSignature, 
dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, dbo.Buy_Gold.AddToItem,
dbo.Buy_Gold.Note, dbo.Buy_Gold.GoldWeight999, dbo.Buy_Gold.Qunt, dbo.Buy_Gold.GoldCaret999, 
dbo.CastomerDETELS.CastomerNameEn, dbo.bay_goled_mony.PayMethod, dbo.Buy_Gold.B_gold_id,
dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, dbo.comp_inform.comp_note1
FROM dbo.Buy_Gold INNER JOIN
dbo.CastomerDETELS ON dbo.Buy_Gold.castomer_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
dbo.bay_goled_mony ON dbo.Buy_Gold.inv_id = dbo.bay_goled_mony.saryal LEFT OUTER JOIN
dbo.cacher ON dbo.bay_goled_mony.Cashier = dbo.cacher.svil_id LEFT OUTER JOIN
dbo.PayMethod ON dbo.bay_goled_mony.PayMethod = dbo.PayMethod.ID CROSS JOIN
dbo.Settings CROSS JOIN
dbo.comp_inform

