-- =============================================
-- View: dbo.convart_id
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[convart_id]
AS
CREATE VIEW [convart_id] AS SELECT CONVERT(nvarchar(MAX), ID) AS item_id, FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, userID, FO_ItemNo, BarCode, StoneWeight2, StoneName2, StoneWeight3, StoneName3 From dbo.FO_min

