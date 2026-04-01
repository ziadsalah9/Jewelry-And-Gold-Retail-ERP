-- =============================================
-- View: dbo.ViwGoldVoucher
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwGoldVoucher]
AS
CREATE VIEW [dbo].[ViwGoldVoucher] AS SELECT 
dbo.TPGoldVoucher.GoldVoucherID, dbo.TPGoldVoucher.CivilID, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, 
dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, dbo.[user].user_name, 
dbo.cacher.cacher_name, dbo.cacher.CashierSignature, dbo.TPGoldVoucher.VoucherNumber, dbo.TPGoldVoucher.GoldKarat, dbo.TPGoldVoucher.PurKarat, dbo.TPGoldVoucher.GoldWeight, 
dbo.TPGoldVoucher.PurWeight, dbo.TPGoldVoucher.Qunt, dbo.TPGoldVoucher.CreationDate, dbo.TPGoldVoucher.LastEditDate, dbo.TPGoldVoucher.Time, dbo.TPGoldVoucher.Note, 
dbo.TPGoldVoucher.Activite, dbo.TPGoldVoucher.MakeCharge, dbo.TPGoldVoucher.TotalMakeCharge, dbo.TPGoldVoucher.WeightArletters, dbo.TPGoldVoucher.WeightEnletters, 
dbo.TPGoldVoucher.GramPrice, dbo.TPGoldVoucher.GoldPrice, dbo.TPGoldVoucher.TotalPrice, dbo.TPGoldVoucher.TotalPriceArletters, dbo.TPGoldVoucher.TotalPriceEnletters, 
dbo.TBBondGoldType.BondTypeArName, dbo.TBBondGoldType.BondTypeEnName, dbo.TPGoldVoucher.PurWeightArletters, dbo.TPGoldVoucher.PurWeightEnletters, 
dbo.COMPANY_BAY_DETELS.COMP_NAME, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name AS ComPnameAsInvoce, dbo.comp_inform.comp_note1 
FROM dbo.TPGoldVoucher INNER JOIN 
dbo.CastomerDETELS ON dbo.TPGoldVoucher.CivilID = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN 
dbo.[user] ON dbo.TPGoldVoucher.UserID = dbo.[user].user_id INNER JOIN 
dbo.cacher ON dbo.TPGoldVoucher.Casher = dbo.cacher.svil_id INNER JOIN 
dbo.TBBondGoldType ON dbo.TPGoldVoucher.VoucherType = dbo.TBBondGoldType.BondGoldTypeID INNER JOIN 
dbo.COMPANY_BAY_DETELS ON dbo.TPGoldVoucher.Supplier = dbo.COMPANY_BAY_DETELS.COM_ID CROSS JOIN 
dbo.comp_inform

