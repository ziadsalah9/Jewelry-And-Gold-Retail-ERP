-- =============================================
-- View: dbo.PayInstallmentVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[PayInstallmentVw]
AS
CREATE VIEW [PayInstallmentVw] AS 
SELECT PayInstallment.ID, PayInstallment.InvoiceNo, PayInstallment.InvoiceType, PayInstallment.PayPrice, PayInstallment.KNET, PayInstallment.CASH, 
PayInstallment.PayDateTime, PayInstallment.PayMethod, PayMethod.PayMethodAr, PayMethod.PayMethodEn, cacher.cacher_name, PayInstallment.Item_Actv 
FROM PayInstallment INNER JOIN 
PayMethod ON PayInstallment.PayMethod = PayMethod.ID INNER JOIN 
cacher ON PayInstallment.Cashier = cacher.cacherID 
WHERE (PayInstallment.Item_Actv = N'1') 

