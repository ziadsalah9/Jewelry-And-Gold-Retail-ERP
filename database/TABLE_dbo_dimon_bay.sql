-- =============================================
-- Table: dbo.dimon_bay
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[dimon_bay] (

    [BAY_ID] int(10,0) NOT NULL,
    [BAY_SARYAL] nvarchar(50),
    [TOTAL_mony] decimal(18,3) NOT NULL,
    [KENT] decimal(18,3) NOT NULL,
    [CACH] decimal(18,3) NOT NULL,
    [arbic_tayb] nvarchar(200),
    [balance] decimal(18,2),
    [staytes] nvarchar(50),
    [English_tayb] nvarchar(200),
    [PayMethod] nvarchar(50),
    [Item_Actv] int(10,0),
    [user_id] int(10,0),
    [MaxID] bigint(19,0)

);

ALTER TABLE [dbo].[dimon_bay]
ADD CONSTRAINT [PK_dimon_bay] PRIMARY KEY ([BAY_ID]);

