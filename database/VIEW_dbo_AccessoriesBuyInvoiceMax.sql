-- =============================================
-- View: dbo.AccessoriesBuyInvoiceMax
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[AccessoriesBuyInvoiceMax]
AS
CREATE VIEW dbo.AccessoriesBuyInvoiceMax
AS
SELECT     MAX(Accessories_InvoiceNo) AS Accessories_InvoiceNoMax
FROM         dbo.Accessories_Buy


