-- =============================================
-- Table: dbo.Accessories_DEP
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_DEP] (

    [Accessories_DEP_ID] int(10,0) NOT NULL,
    [Accessories_DEP_NAME] nvarchar(100),
    [Accessories_DEP_DESC] nvarchar(150),
    [Accessories_DEP_DATE_CR] date,
    [Accessories_DEP_TIME_CRE] date,
    [Accessories_DEP_USER] int(10,0)

);

ALTER TABLE [dbo].[Accessories_DEP]
ADD CONSTRAINT [PK_Accessories_DEP] PRIMARY KEY ([Accessories_DEP_ID]);

