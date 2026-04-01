-- =============================================
-- Table: dbo.bay_mony
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[bay_mony] (

    [BAY_ID] int(10,0) NOT NULL,
    [INV_namper] nvarchar(255) NOT NULL,
    [cach] decimal(18,2),
    [kenet] decimal(18,2),
    [total_bay] decimal(18,2),
    [arbac_bay] varchar(50),
    [wented_mony] decimal(18,2),
    [balance] decimal(18,2)

);

ALTER TABLE [dbo].[bay_mony]
ADD CONSTRAINT [PK_bay_mony] PRIMARY KEY ([BAY_ID]);

