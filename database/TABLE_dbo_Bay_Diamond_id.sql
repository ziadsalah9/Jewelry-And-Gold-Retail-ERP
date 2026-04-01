-- =============================================
-- Table: dbo.Bay_Diamond_id
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Bay_Diamond_id] (

    [Bay_Diamond_id] int(10,0) NOT NULL,
    [add] nchar(10)

);

ALTER TABLE [dbo].[Bay_Diamond_id]
ADD CONSTRAINT [PK_Bay_Diamond_id] PRIMARY KEY ([Bay_Diamond_id]);

