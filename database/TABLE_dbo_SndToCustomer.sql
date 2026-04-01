-- =============================================
-- Table: dbo.SndToCustomer
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[SndToCustomer] (

    [Id] int(10,0) NOT NULL,
    [SndNumber] nvarchar(255),
    [Amount] decimal(18,3),
    [Cash] decimal(18,3),
    [Kent] decimal(18,3),
    [Date_] date,
    [Time_] nvarchar(50),
    [Note_] nvarchar(255),
    [NumToWorld_AR] nvarchar(255),
    [NumToWorld_EN] nvarchar(255),
    [PayMID] int(10,0),
    [Activite] int(10,0),
    [SndType] nvarchar(255),
    [Casher] nvarchar(50),
    [UserId] int(10,0),
    [civilid] nvarchar(255),
    [CompName] nvarchar(250),
    [SndPhoto] image(2147483647),
    [TypeTransaction] int(10,0),
    [LastEditDate] datetime,
    [CreationDate] datetime,
    [PayMethod1] nvarchar(50),
    [PayMethod2] nvarchar(50),
    [PayMethod3] nvarchar(50),
    [PayMethod4] nvarchar(50),
    [Bank1] decimal(18,3),
    [Bank2] decimal(18,3),
    [Bank3] decimal(18,3),
    [Bank4] decimal(18,3),
    [Supplier] int(10,0)

);

ALTER TABLE [dbo].[SndToCustomer]
ADD CONSTRAINT [PK_SndToCustomer] PRIMARY KEY ([Id]);

