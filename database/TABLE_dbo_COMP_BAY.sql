-- =============================================
-- Table: dbo.COMP_BAY
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[COMP_BAY] (

    [COMP_BAY_ID] int(10,0) NOT NULL,
    [COMP_INV_ID] int(10,0) NOT NULL,
    [TOTAL_PRICE] numeric(18,3) NOT NULL,
    [TOTAL_CACHE] numeric(18,3) NOT NULL,
    [TOTAL_KENT] numeric(18,3) NOT NULL,
    [BLANCE] numeric(18,3) NOT NULL,
    [ARBIC_total_taype] nvarchar(350) NOT NULL,
    [DATE_CRETED] int(10,0),
    [USER_CRETED] nvarchar(50)

);

ALTER TABLE [dbo].[COMP_BAY]
ADD CONSTRAINT [PK_COMP_BAY] PRIMARY KEY ([COMP_BAY_ID]);

