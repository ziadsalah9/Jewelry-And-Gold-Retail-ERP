-- =============================================
-- Table: dbo.licens
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[licens] (

    [id] int(10,0) NOT NULL,
    [date] datetime NOT NULL

);

ALTER TABLE [dbo].[licens]
ADD CONSTRAINT [PK_licens] PRIMARY KEY ([id]);

