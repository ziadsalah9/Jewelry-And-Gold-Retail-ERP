-- =============================================
-- Table: dbo.PayInstallment
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[PayInstallment] (

    [ID] int(10,0) NOT NULL,
    [InvoiceNo] nvarchar(50),
    [InvoiceType] nvarchar(50),
    [PayPrice] decimal(18,3) NOT NULL,
    [KNET] decimal(18,3),
    [CASH] decimal(18,3),
    [PayDateTime] datetime,
    [PayMethod] int(10,0),
    [Cashier] nvarchar(50),
    [Item_Actv] int(10,0)

);

ALTER TABLE [dbo].[PayInstallment]
ADD CONSTRAINT [PK_PayInstallment] PRIMARY KEY ([ID]);

