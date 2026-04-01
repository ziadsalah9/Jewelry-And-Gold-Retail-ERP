-- =============================================
-- Table: dbo.Expenses
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Expenses] (

    [ExpensesID] int(10,0) NOT NULL,
    [ExpensesType] nvarchar(50),
    [ExpensesDate] date,
    [ExpensesUserID] int(10,0),
    [ExpensesCashValue] decimal(18,3),
    [ExpensesKNETValue] decimal(18,3),
    [ExpensesPhoto] image(2147483647),
    [ExpensesDescription] nvarchar(255),
    [PayMethod] int(10,0),
    [Cacher] nvarchar(50),
    [Active] int(10,0),
    [CashVoucherNo] nvarchar,
    [ExpensesInvID] nvarchar(200),
    [ExpensesDateTime] nvarchar(255)

);

ALTER TABLE [dbo].[Expenses]
ADD CONSTRAINT [PK_Expenses] PRIMARY KEY ([ExpensesID]);

