-- =============================================
-- View: dbo.ReportGoldBuyShort
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldBuyShort]
AS
 CREATE VIEW  [ReportGoldBuyShort] AS SELECT   Buy_Gold.castomer_id,  CastomerDETELS.CastomerNAme,  CastomerDETELS.CastomerADr, 
 CastomerDETELS.CastomerTE,  CastomerDETELS.CastomerNA, 
 SUM( Buy_Gold.bay_mazan) AS bay_mazan,  bay_goled_mony.total_price,  bay_goled_mony.cach,
  bay_goled_mony.kenet,  bay_goled_mony.arabik,  Buy_Gold.inv_id, 
 bay_goled_mony.date, bay_goled_mony.INV_Actv, cacher.cacher_name
 FROM Buy_Gold INNER JOIN
CastomerDETELS ON Buy_Gold.castomer_id = CastomerDETELS.CastomerCAIVELid INNER JOIN
 bay_goled_mony ON Buy_Gold.inv_id = bay_goled_mony.saryal INNER JOIN
 cacher ON bay_goled_mony.Cashier = cacher.cacherID
 GROUP BY Buy_Gold.castomer_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr,
CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, 
 bay_goled_mony.arabik, Buy_Gold.inv_id, bay_goled_mony.date, bay_goled_mony.kenet, 
 bay_goled_mony.cach, bay_goled_mony.total_price, 
 bay_goled_mony.INV_Actv, cacher.cacher_name
 HAVING (bay_goled_mony.INV_Actv = 1)

