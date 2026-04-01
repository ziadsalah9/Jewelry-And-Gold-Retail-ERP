-- =============================================
-- Table: dbo.Accessories_CAT
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_CAT] (

    [Accessories_CAT_ID] int(10,0) NOT NULL,
    [Accessories_CAT_NAME] nvarchar(100),
    [Accessories_CAT_DESC] nvarchar(150),
    [Accessories_CAT_DATE_CR] date,
    [Accessories_CAT_TIME_CRE] date,
    [Accessories_CAT_USER] int(10,0)

);

ALTER TABLE [dbo].[Accessories_CAT]
ADD CONSTRAINT [PK_Accessories_CAT] PRIMARY KEY ([Accessories_CAT_ID]);

