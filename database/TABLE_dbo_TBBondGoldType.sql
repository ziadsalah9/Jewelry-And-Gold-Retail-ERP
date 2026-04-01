-- =============================================
-- Table: dbo.TBBondGoldType
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TBBondGoldType] (

    [BondGoldTypeID] int(10,0) NOT NULL,
    [BondTypeArName] nvarchar(50),
    [BondTypeEnName] nvarchar(50),
    [BondTypeActiv] int(10,0),
    [BondType] int(10,0)

);

ALTER TABLE [dbo].[TBBondGoldType]
ADD CONSTRAINT [PK_TBBondGoldType] PRIMARY KEY ([BondGoldTypeID]);

