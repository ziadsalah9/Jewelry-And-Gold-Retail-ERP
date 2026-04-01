-- =============================================
-- View: dbo.ReportDiamondSellDetailed
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportDiamondSellDetailed]
AS
CREATE VIEW [dbo].[ReportDiamondSellDetailed] AS SELECT TOP (100) PERCENT  
dbo.dimon_invce.castomr_id, dbo.CastomerDETELS.CastomerNAme,  
dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerNA, dbo.dimon_invce.descont,  
dbo.dimon_invce.total, dbo.dimon_invce.ar_taype, dbo.dimon_invce.DIMO_Type,  
dbo.dimon_invce.DIM_na9awa, dbo.dimon_invce.DIMO_mezan, dbo.dimon_invce.DIMO_coler,  
dbo.dimon_invce.DIMO_qult, dbo.dimon_invce.sarual, dbo.dimon_invce.val_gold,  
dbo.dimon_invce.GOLD_mezan, dbo.dimon_invce.user_creted, dbo.dimon_invce.date_creted,  
dbo.dimon_invce.time, dbo.cacher.cacher_name, dbo.dimon_bay.BAY_SARYAL,  
dbo.dimon_bay.TOTAL_mony, dbo.dimon_bay.CACH AS dimon_bay_cach, dbo.dimon_bay.KENT,  
dbo.dimon_bay.balance, dbo.dimon_bay.staytes, dbo.dimon_invce.dimo_id,  
dbo.DIMON_detels.test_12, dbo.cacher.svil_id, dbo.dimon_invce.notes, dbo.CastomerDETELS.CastomerTE,  
dbo.dimon_invce.test_13, dbo.dimon_invce.test_14, dbo.dimon_invce.test_15,  
dbo.dimon_invce.test_16, dbo.dimon_invce.test_17, dbo.dimon_invce.test_18, dbo.dimon_invce.test_19,  
dbo.dimon_invce.test_110, dbo.dimon_invce.test_111, dbo.dimon_invce.test_112,  
dbo.dimon_invce.test_116, dbo.dimon_invce.test_117, dbo.dimon_invce.test_118, dbo.dimon_invce.test_119,  
dbo.dimon_bay.Item_Actv, dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerNameEn,  
dbo.dimon_invce.Cut1, dbo.dimon_invce.Clarity1, dbo.dimon_invce.Cut2,  
dbo.dimon_invce.Clarity2, dbo.dimon_invce.Cut3, dbo.dimon_invce.Clarity3,  
dbo.dimon_invce.IsDiamond1, dbo.dimon_invce.IsDiamond2, dbo.dimon_invce.IsDiamond3, dbo.dimon_invce.dim_foto,  
dbo.dimon_invce.GramPrice, dbo.dimon_invce.SoldItem,dbo.dimon_invce.CertificateNumber 
FROM dbo.dimon_invce INNER JOIN  
dbo.CastomerDETELS ON dbo.dimon_invce.castomr_id = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN  
dbo.dimon_bay ON dbo.dimon_invce.descont = dbo.dimon_bay.BAY_SARYAL LEFT OUTER JOIN  
dbo.DIMON_detels ON dbo.dimon_invce.dimo_id = dbo.DIMON_detels.test_119 LEFT OUTER JOIN  
dbo.cacher ON dbo.dimon_invce.test_118 = dbo.cacher.svil_id  
WHERE (dbo.dimon_invce.Item_Actv = 1) AND (dbo.dimon_bay.Item_Actv = 1)  
ORDER BY LEN(dbo.dimon_invce.date_creted)

