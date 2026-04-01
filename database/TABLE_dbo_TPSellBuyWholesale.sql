-- =============================================
-- Table: dbo.TPSellBuyWholesale
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPSellBuyWholesale] (

    [ID] int(10,0) NOT NULL,
    [InvIDAuto] nvarchar(250),
    [InvID] nvarchar(250),
    [CashierID] int(10,0),
    [CastomerCAIVELid] nvarchar(255),
    [COM_ID] int(10,0),
    [ItemDes] nvarchar(2000),
    [ItemImage] image(2147483647),
    [GoldCaretBasic] nvarchar(50),
    [GoldCaretBasicValue] decimal(18,3),
    [GoldCaretTrans] nvarchar(50),
    [GoldCaretTransValue] decimal(18,3),
    [GoldCaretPrice] decimal(18,3),
    [TotalGoledPrice] decimal(18,3),
    [MakeCharge] decimal(18,3),
    [TotalMakeCharge] decimal(18,3),
    [InvDate] date,
    [InvDateTime] nvarchar(250),
    [ActualInvDateTime] nvarchar(250),
    [UserID] int(10,0),
    [InvActive] int(10,0),
    [ItemActive] int(10,0),
    [InvType] int(10,0),
    [InvActiveaComp] int(10,0)

);

ALTER TABLE [dbo].[TPSellBuyWholesale]
ADD CONSTRAINT [PK_TPSellBuyWholesale] PRIMARY KEY ([ID]);

