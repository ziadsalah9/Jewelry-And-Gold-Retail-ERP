-- =============================================
-- Table: dbo.CANTRY
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[CANTRY] (

    [ID] int(10,0) NOT NULL,
    [CANTRY_name] nvarchar(255)

);

ALTER TABLE [dbo].[CANTRY]
ADD CONSTRAINT [PK_CANTRY] PRIMARY KEY ([ID]);

