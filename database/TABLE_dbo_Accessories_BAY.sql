-- =============================================
-- Table: dbo.Accessories_BAY
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_BAY] (

    [Accessories_BAY_ID] int(10,0) NOT NULL,
    [Accessories_BAY_SARYAL] int(10,0) NOT NULL,
    [Accessories_TOTAL_mony] decimal(18,3) NOT NULL,
    [Accessories_KENT] decimal(18,3),
    [Accessories_CACH] decimal(18,3),
    [Accessories_arbic_tayb] nvarchar(200),
    [Accessories_balance] decimal(18,3),
    [Accessories_staytes] nvarchar(50),
    [Accessories_PaymentType] nvarchar(50),
    [Accessories_Casher] nvarchar(50),
    [Accessories_Active] bit,
    [Accessories_Notes] nvarchar(200),
    [Accessories_PayMethod] nvarchar(1)

);

ALTER TABLE [dbo].[Accessories_BAY]
ADD CONSTRAINT [PK_Accessories_BAY] PRIMARY KEY ([Accessories_BAY_ID]);

