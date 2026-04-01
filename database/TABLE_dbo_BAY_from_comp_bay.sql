-- =============================================
-- Table: dbo.BAY_from_comp_bay
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[BAY_from_comp_bay] (

    [COMP_ID] int(10,0) NOT NULL,
    [COMP_saryil] int(10,0) NOT NULL,
    [COMP_TOTAL] numeric(18,3),
    [COMP_CACH] numeric(18,3),
    [COMP_KENT] numeric(18,3),
    [COMP_aribc] nvarchar(550),
    [blance] numeric(18,3),
    [date_baya] nvarchar(250),
    [staytes1] nvarchar(250)

);

ALTER TABLE [dbo].[BAY_from_comp_bay]
ADD CONSTRAINT [PK_BAY_from_comp_bay] PRIMARY KEY ([COMP_ID], [COMP_saryil]);

