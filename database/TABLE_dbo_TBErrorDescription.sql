-- =============================================
-- Table: dbo.TBErrorDescription
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TBErrorDescription] (

    [ID] int(10,0) NOT NULL,
    [ErrorTime] nvarchar(50),
    [ErrorDescription] text(2147483647)

);

ALTER TABLE [dbo].[TBErrorDescription]
ADD CONSTRAINT [PK_TBErrorDescription] PRIMARY KEY ([ID]);

