-- =============================================
-- View: dbo.Accessories_Buy_PayVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Accessories_Buy_PayVw]
AS
 CREATE VIEW [dbo].[Accessories_Buy_PayVw] AS 
SELECT     dbo.Accessories_Buy_Pay.Accessories_Pay_ID, dbo.Accessories_Buy_Pay.Accessories_InvoiceNo, dbo.Accessories_Buy_Pay.Accessories_TOTAL_Price, 
 dbo.Accessories_Buy_Pay.Accessories_KNET, dbo.Accessories_Buy_Pay.Accessories_CASH, dbo.Accessories_Buy_Pay.Accessories_Arabic_tayb, 
 dbo.Accessories_Buy_Pay.Accessories_balance, dbo.Accessories_Buy_Pay.Accessories_staytes, dbo.Accessories_Buy_Pay.Accessories_PaymentType, 
 dbo.Accessories_Buy_Pay.Accessories_Casher, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, 
 dbo.Accessories_Buy.Accessories_DATE_CRE, dbo.CastomerDETELS.CastomerCAIVELid, dbo.Accessories_Buy.Accessories_NAME, dbo.Accessories_Buy.Accessories_BRAND, 
 dbo.Accessories_Buy.Accessories_DESC, dbo.Accessories_Buy.Accessories_ItemStatus, dbo.Accessories_Buy.Accessories_model_no, dbo.Accessories_Buy.Accessories_nom, 
 dbo.Accessories_Buy.Accessories_Price, dbo.Accessories_Buy.AccessoriesID, dbo.cacher.cacher_name, dbo.Accessories_Buy.Accessories_TIME, dbo.CastomerDETELS.foto, 
  dbo.CastomerDETELS.Signature, dbo.cacher.CashierSignature, dbo.CastomerDETELS.fotoBack, dbo.Accessories_Buy.Accessories_YearOfWarr, 
  dbo.Accessories_Buy.Accessories_Attachments 
 FROM  dbo.CastomerDETELS INNER JOIN 
 dbo.Accessories_Buy ON dbo.CastomerDETELS.CastomerCAIVELid = dbo.Accessories_Buy.Accessories_CID INNER JOIN 
 dbo.Accessories_Buy_Pay INNER JOIN 
  dbo.cacher ON dbo.Accessories_Buy_Pay.Accessories_Casher = dbo.cacher.cacherID ON dbo.Accessories_Buy.Accessories_InvoiceNo = dbo.Accessories_Buy_Pay.Accessories_InvoiceNo 

