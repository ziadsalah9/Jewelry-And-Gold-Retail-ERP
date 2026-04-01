-- =============================================
-- Table: dbo.inv_start
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[inv_start] (

    [id_start] int(10,0) NOT NULL,
    [inv_start] int(10,0)

);

ALTER TABLE [dbo].[inv_start]
ADD CONSTRAINT [PK_inv_start] PRIMARY KEY ([id_start]);

