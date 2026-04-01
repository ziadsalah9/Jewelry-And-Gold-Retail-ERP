-- =============================================
-- View: dbo.for_invoice
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[for_invoice]
AS
CREATE VIEW [for_invoice] AS 
SELECT ID, userID, FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, ITEM_IMGE, date_care, BarCode 
FROM FO_min

