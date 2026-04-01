-- =============================================
-- Table: dbo.COMP_detels_for_bay
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[COMP_detels_for_bay] (

    [comp_id] int(10,0) NOT NULL,
    [comp_name] nvarchar(200) NOT NULL,
    [comp_adre] nvarchar(200) NOT NULL,
    [comp_tel] nvarchar(200) NOT NULL,
    [comp_fax] nvarchar(200),
    [comp_licen_nomp] nvarchar(200),
    [comp_note1] nvarchar(200) NOT NULL,
    [comp_note11] nvarchar(200) NOT NULL,
    [comp_note12] nvarchar(200) NOT NULL,
    [comp_note13] nvarchar(200) NOT NULL,
    [comp_note14] nvarchar(200) NOT NULL

);

ALTER TABLE [dbo].[COMP_detels_for_bay]
ADD CONSTRAINT [PK_COMP_detels_for_bay] PRIMARY KEY ([comp_id]);

