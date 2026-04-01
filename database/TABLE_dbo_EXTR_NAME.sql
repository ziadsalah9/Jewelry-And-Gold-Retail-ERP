-- =============================================
-- Table: dbo.EXTR_NAME
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[EXTR_NAME] (

    [EXTR_ID] int(10,0) NOT NULL,
    [EXTR_NAME] nvarchar(50),
    [AsGold] bit NOT NULL DEFAULT ((0)),
    [IsDiamond] bit NOT NULL DEFAULT ((0)),
    [Activ] int(10,0)

);

ALTER TABLE [dbo].[EXTR_NAME]
ADD CONSTRAINT [PK_EXTR_NAME] PRIMARY KEY ([EXTR_ID]);

