-- =============================================
-- Table: dbo.TPGoldVoucherReceive
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPGoldVoucherReceive] (

    [GoldVoucherReceiveID] int(10,0) NOT NULL,
    [VoucherNumber] nvarchar(50) NOT NULL,
    [CivilID] nvarchar(50),
    [UserID] nvarchar(50),
    [Casher] nvarchar(50),
    [VoucherType] nvarchar(50),
    [Supplier] nvarchar(50),
    [GoldKarat] nvarchar(50),
    [PurKarat] nvarchar(50),
    [GoldWeight] decimal(18,3),
    [PurWeight] decimal(18,3),
    [GramPrice] decimal(18,3),
    [GoldPrice] decimal(18,3),
    [MakeCharge] decimal(18,3),
    [TotalMakeCharge] decimal(18,3),
    [TotalPrice] decimal(18,3),
    [Qunt] nvarchar(50),
    [WeightArletters] nvarchar(255) NOT NULL,
    [WeightEnletters] nvarchar(255) NOT NULL,
    [TotalPriceArletters] nvarchar(255) NOT NULL,
    [TotalPriceEnletters] nvarchar(255) NOT NULL,
    [PurWeightArletters] nvarchar(255) NOT NULL,
    [PurWeightEnletters] nvarchar(255) NOT NULL,
    [CreationDate] date,
    [LastEditDate] date,
    [Time] nvarchar(50),
    [Note] nvarchar(500),
    [Activite] int(10,0)

);

ALTER TABLE [dbo].[TPGoldVoucherReceive]
ADD CONSTRAINT [PK_TPGoldVoucherReceive] PRIMARY KEY ([GoldVoucherReceiveID]);

