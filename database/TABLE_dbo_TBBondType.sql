-- =============================================
-- Table: dbo.TBBondType
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TBBondType] (

    [BondTypeID] int(10,0) NOT NULL,
    [BondTypeArName] nvarchar(50),
    [BondTypeEnName] nvarchar(50),
    [BondTypeActiv] int(10,0),
    [BondType] int(10,0)

);

ALTER TABLE [dbo].[TBBondType]
ADD CONSTRAINT [PK_TBBondType] PRIMARY KEY ([BondTypeID]);

