-- =============================================
-- Table: dbo.BAY
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[BAY] (

    [BAY_ID] int(10,0) NOT NULL,
    [BAY_SARYAL] nvarchar(500) NOT NULL,
    [TOTAL_mony] decimal(18,3) NOT NULL,
    [KENT] decimal(18,3),
    [CACH] decimal(18,3),
    [arbic_tayb] nvarchar(200),
    [balance] decimal(18,3),
    [staytes] nvarchar(50),
    [English_tayb] nvarchar(200),
    [Notes] nvarchar(250),
    [PayMethod] nvarchar(50) NOT NULL,
    [Active] bit,
    [PayMethod1] nvarchar(50),
    [PayMethod2] nvarchar(50),
    [PayMethod3] nvarchar(50),
    [PayMethod4] nvarchar(50),
    [Bank1] decimal(18,3),
    [Bank2] decimal(18,3),
    [Bank3] decimal(18,3),
    [Bank4] decimal(18,3),
    [InvVatType] decimal(18,3) DEFAULT ((14)),
    [InvVat] decimal(18,3) DEFAULT ((0)),
    [MaxID] bigint(19,0),
    [PurchaseInvNumber] nvarchar(500),
    [PurchaseGold] decimal(18,3),
    [PaymentReceipt] image(2147483647),
    [PaymentTransNumber] nvarchar(100)

);

ALTER TABLE [dbo].[BAY]
ADD CONSTRAINT [PK_BAY] PRIMARY KEY ([BAY_ID]);

