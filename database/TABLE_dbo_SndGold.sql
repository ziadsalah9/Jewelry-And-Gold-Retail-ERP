-- =============================================
-- Table: dbo.SndGold
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[SndGold] (

    [Id] int(10,0) NOT NULL,
    [PayMID] nvarchar(255),
    [SndNumber] nvarchar(255),
    [Amount] decimal(18,3),
    [Cash] decimal(18,3),
    [Kent] decimal(18,3),
    [Date_] datetime,
    [Time_] datetime,
    [Note_] nvarchar(255),
    [NumToWorld_AR] nvarchar(255),
    [NumToWorld_EN] nvarchar(255),
    [Activite] int(10,0),
    [SndType] nvarchar(50),
    [Casher] nvarchar(50),
    [UserID] int(10,0),
    [CivilID] nvarchar(255),
    [GrossWeight] decimal(18,3),
    [Karat] nvarchar(50),
    [SandWeight] decimal(18,3),
    [Weight] decimal(18,3),
    [Supplier] nvarchar(255),
    [ReciviedName] nvarchar(255)

);

ALTER TABLE [dbo].[SndGold]
ADD CONSTRAINT [PK_SndGold] PRIMARY KEY ([Id]);

