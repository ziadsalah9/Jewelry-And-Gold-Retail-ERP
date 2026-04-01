-- =============================================
-- Table: dbo.Accessories_Buy_Pay
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Accessories_Buy_Pay] (

    [Accessories_Pay_ID] int(10,0) NOT NULL,
    [Accessories_InvoiceNo] nvarchar(50) NOT NULL,
    [Accessories_TOTAL_Price] decimal(18,3) NOT NULL,
    [Accessories_KNET] decimal(18,3),
    [Accessories_CASH] decimal(18,3),
    [Accessories_Arabic_tayb] nvarchar(200),
    [Accessories_balance] decimal(18,3),
    [Accessories_staytes] nvarchar(50),
    [Accessories_PaymentType] nvarchar(50),
    [Accessories_Casher] nvarchar(50),
    [PaymentReceipt] image(2147483647),
    [PaymentTransNumber] nvarchar(100),
    [PayMethod] nvarchar(50),
    [PayMethod1] nvarchar(50),
    [PayMethod2] nvarchar(50),
    [PayMethod3] nvarchar(50),
    [PayMethod4] nvarchar(50),
    [Bank] decimal(18,3),
    [Bank1] decimal(18,3),
    [Bank2] decimal(18,3),
    [Bank3] decimal(18,3),
    [Bank4] decimal(18,3)

);

ALTER TABLE [dbo].[Accessories_Buy_Pay]
ADD CONSTRAINT [PK_Accessories_Buy_Pay] PRIMARY KEY ([Accessories_Pay_ID]);

