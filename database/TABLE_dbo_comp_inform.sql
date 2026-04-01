-- =============================================
-- Table: dbo.comp_inform
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[comp_inform] (

    [comp_id] int(10,0) NOT NULL,
    [comp_name] nvarchar(500),
    [comp_adrs] nvarchar(250),
    [comp_fax] nvarchar(250),
    [comp_email] nvarchar(250),
    [comp_note1] nvarchar(250),
    [comp_note11] nvarchar(250),
    [comp_note12] nvarchar(250),
    [comp_note13] nvarchar(250),
    [comp_note14] nvarchar(250),
    [comp_note15] nvarchar(250),
    [comp_note16] nvarchar(250),
    [comp_note17] nvarchar(250),
    [comp_note18] nvarchar(250),
    [comp_note19] nvarchar(250),
    [comp_note110] nvarchar(250),
    [logo] image(2147483647),
    [logo1] image(2147483647),
    [logo2] image(2147483647),
    [logo3] image(2147483647),
    [logo4] image(2147483647),
    [logo5] image(2147483647),
    [logo6] image(2147483647),
    [logo7] image(2147483647),
    [logo8] image(2147483647),
    [logo9] image(2147483647),
    [logo10] image(2147483647)

);

ALTER TABLE [dbo].[comp_inform]
ADD CONSTRAINT [PK_comp_inform] PRIMARY KEY ([comp_id]);

