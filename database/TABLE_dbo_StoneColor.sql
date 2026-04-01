-- =============================================
-- Table: dbo.StoneColor
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[StoneColor] (

    [ID] int(10,0) NOT NULL,
    [StoneColor] nvarchar(50)

);

ALTER TABLE [dbo].[StoneColor]
ADD CONSTRAINT [PK_StoneColor] PRIMARY KEY ([ID]);

