-- =============================================
-- View: dbo.Print_Parcood2
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[Print_Parcood2]
AS
CREATE VIEW [Print_Parcood2] AS SELECT item_id AS ID, userID, FO_name + SPACE(1) + item_id AS FO_name, FO_desp, FO_price, FO_GramPrice, FO_gram, FO_gramMade, FO_made, FO_extras, FO_totalPrice, Gram_valu, FO_ItemNo, BarCode, StoneWeight2, StoneName2, StoneWeight3, StoneName3 FROM convart_id 

