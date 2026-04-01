-- =============================================
-- View: dbo.company_pay_finel_prinet
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[company_pay_finel_prinet]
AS
CREATE VIEW dbo.company_pay_finel_prinet
AS
SELECT     dbo.COMPANY_BAY_DETELS.COMP_NAME, dbo.COMPANY_BAY_DETELS.COMP_NAME_SHORT, dbo.COMPANY_BAY_DETELS.SGAL_TAGARE, dbo.COMPANY_BAY_DETELS.PHONE_NOMPER, 
                      dbo.COMPANY_BAY_DETELS.FAX_NOMPER, dbo.COMPANY_BAY_DETELS.LOC_NOMPER, dbo.COMPANY_BAY_DETELS.USER_ID, dbo.COMPANY_BAY_DETELS.DATE_CRETED, 
                      dbo.COMPANY_BAY_DETELS.NOTE, dbo.BAY_from_comp_bay.COMP_TOTAL, dbo.BAY_from_comp_bay.COMP_CACH, dbo.BAY_from_comp_bay.COMP_KENT, 
                      dbo.BAY_from_comp_bay.COMP_aribc, dbo.BAY_from_comp_bay.blance, dbo.BAY_from_comp_bay.date_baya, dbo.BAY_from_comp_bay.staytes1, dbo.BAY_from_comp_bay.COMP_saryil, 
                      dbo.COMP_INVOCE_CACHE.GOLED_wazen, dbo.COMP_INVOCE_CACHE.GOLED_VALUS, dbo.COMP_INVOCE_CACHE.GOLED_GRAM_PRICE, dbo.COMP_INVOCE_CACHE.GOLED_TOTAL_PRICE, 
                      dbo.CastomerDETELS.CastomerNAme, dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA, dbo.CastomerDETELS.foto, 
                      dbo.CastomerDETELS.Signature, dbo.Settings.PIC1
FROM         dbo.BAY_from_comp_bay INNER JOIN
                      dbo.COMP_INVOCE_CACHE ON dbo.BAY_from_comp_bay.COMP_saryil = dbo.COMP_INVOCE_CACHE.BAY_id INNER JOIN
                      dbo.COMPANY_BAY_DETELS ON dbo.COMP_INVOCE_CACHE.COMP_ID = dbo.COMPANY_BAY_DETELS.COM_ID LEFT OUTER JOIN
                      dbo.CastomerDETELS ON dbo.COMP_INVOCE_CACHE.CASTOMER_ID_t = dbo.CastomerDETELS.CastomerCAIVELid CROSS JOIN
                      dbo.Settings


