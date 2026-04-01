-- =============================================
-- View: dbo.ViwSndToCustomer
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ViwSndToCustomer]
AS
CREATE VIEW [dbo].[ViwSndToCustomer] AS
SELECT TOP (100) PERCENT dbo.SndToCustomer.Id, dbo.SndToCustomer.SndNumber, dbo.SndToCustomer.Amount, dbo.SndToCustomer.Cash, dbo.SndToCustomer.Kent, dbo.SndToCustomer.Date_, 
dbo.SndToCustomer.Time_, dbo.SndToCustomer.Note_, dbo.SndToCustomer.NumToWorld_AR, dbo.SndToCustomer.NumToWorld_EN, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, 
dbo.SndToCustomer.Activite, dbo.cacher.cacher_name, dbo.[user].user_name, dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, 
dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, dbo.CastomerDETELS.Signature, dbo.CastomerDETELS.fotoBack, dbo.CastomerDETELS.CastomerNameEn, 
dbo.CastomerDETELS.CastomerCAIVELid, dbo.SndToCustomer.CompName, dbo.TBBondType.BondTypeArName, dbo.TBBondType.BondTypeEnName, dbo.SndToCustomer.TypeTransaction, 
PayMethod_1.PayMethodAr AS PayMethodAr1, PayMethod_1.PayMethodEn AS PayMethodEn1, PayMethod_2.PayMethodAr AS PayMethodAr2, PayMethod_2.PayMethodEn AS PayMethodEn2, 
PayMethod_3.PayMethodAr AS PayMethodAr3, PayMethod_3.PayMethodEn AS PayMethodEn3, PayMethod_4.PayMethodAr AS PayMethodAr4, PayMethod_4.PayMethodEn AS PayMethodEn4, 
dbo.SndToCustomer.Bank1, dbo.SndToCustomer.Bank2, dbo.SndToCustomer.Bank3, dbo.SndToCustomer.Bank4, dbo.comp_inform.logo1, dbo.comp_inform.logo2, dbo.comp_inform.comp_name, 
dbo.comp_inform.comp_note1
FROM dbo.SndToCustomer INNER JOIN
dbo.PayMethod ON dbo.SndToCustomer.PayMID = dbo.PayMethod.ID INNER JOIN
dbo.CastomerDETELS ON dbo.SndToCustomer.civilid = dbo.CastomerDETELS.CastomerCAIVELid INNER JOIN
dbo.cacher ON dbo.SndToCustomer.Casher = dbo.cacher.svil_id INNER JOIN
dbo.[user] ON dbo.SndToCustomer.UserId = dbo.[user].user_id INNER JOIN
dbo.TBBondType ON dbo.SndToCustomer.SndType = dbo.TBBondType.BondTypeID INNER JOIN
dbo.PayMethod AS PayMethod_1 ON dbo.SndToCustomer.PayMethod1 = PayMethod_1.ID INNER JOIN
dbo.PayMethod AS PayMethod_2 ON dbo.SndToCustomer.PayMethod2 = PayMethod_2.ID INNER JOIN
dbo.PayMethod AS PayMethod_3 ON dbo.SndToCustomer.PayMethod3 = PayMethod_3.ID INNER JOIN
dbo.PayMethod AS PayMethod_4 ON dbo.SndToCustomer.PayMethod4 = PayMethod_4.ID CROSS JOIN
dbo.comp_inform
WHERE (dbo.SndToCustomer.Activite = 1)
ORDER BY dbo.SndToCustomer.Id, dbo.SndToCustomer.Date_

