-- =============================================
-- Table: dbo.BAYWholesale
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[BAYWholesale] (

    [ID] int(10,0) NOT NULL,
    [InvIDAuto] nvarchar(250) NOT NULL,
    [InvID] nvarchar(250),
    [TOTAL_mony] decimal(18,3),
    [KENT] decimal(18,3),
    [CACH] decimal(18,3),
    [arbic_tayb] nvarchar(250),
    [balance] decimal(18,3),
    [English_tayb] nvarchar(250),
    [Notes] nvarchar(250),
    [Active] int(10,0),
    [PayMethod] int(10,0),
    [InvType] int(10,0)

);

ALTER TABLE [dbo].[BAYWholesale]
ADD CONSTRAINT [PK_BAYWholesale] PRIMARY KEY ([ID]);

