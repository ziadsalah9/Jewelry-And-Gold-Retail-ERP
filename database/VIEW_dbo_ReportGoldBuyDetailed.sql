-- =============================================
-- View: dbo.ReportGoldBuyDetailed
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportGoldBuyDetailed]
AS
CREATE VIEW [ReportGoldBuyDetailed] AS 
SELECT TOP (2147483647) Buy_Gold.castomer_id, CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerTE, CastomerDETELS.CastomerNA, 
Buy_Gold.bay_val, Buy_Gold.bay_mazan, Buy_Gold.bay_gram_price, Buy_Gold.bay_total_price, bay_goled_mony.total_price, bay_goled_mony.cach,  
bay_goled_mony.kenet, bay_goled_mony.arabik, Buy_Gold.inv_id, bay_goled_mony.date, bay_goled_mony.English 
FROM Buy_Gold INNER JOIN CastomerDETELS ON Buy_Gold.castomer_id = CastomerDETELS.CastomerCAIVELid INNER JOIN 
bay_goled_mony ON Buy_Gold.inv_id = bay_goled_mony.saryal 
WHERE (Buy_Gold.INV_Actv = 1)

