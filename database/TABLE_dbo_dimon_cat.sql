-- =============================================
-- Table: dbo.dimon_cat
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[dimon_cat] (

    [Cat_id] int(10,0) NOT NULL,
    [dimon_cat_name] nvarchar(255)

);

ALTER TABLE [dbo].[dimon_cat]
ADD CONSTRAINT [PK_dimon_cat] PRIMARY KEY ([Cat_id]);

