-- =============================================
-- Table: dbo.CurrencyType
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[CurrencyType] (

    [CurrencyID] int(10,0) NOT NULL,
    [CurrencyCountry] nvarchar(50),
    [CurrencyTypeMin] nvarchar(50),
    [CurrencyType] nvarchar(50)

);

ALTER TABLE [dbo].[CurrencyType]
ADD CONSTRAINT [PK_CurrencyType] PRIMARY KEY ([CurrencyID]);

