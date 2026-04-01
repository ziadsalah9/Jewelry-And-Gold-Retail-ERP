-- =============================================
-- Table: dbo.user
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[user] (

    [user_id] int(10,0) NOT NULL,
    [user_name] nvarchar(255),
    [password] nvarchar(255),
    [DateCreated] datetime,
    [chkSell] bit,
    [chkBarCode] bit,
    [chkModify] bit,
    [chkGramPrice] bit,
    [chkSalary] bit,
    [chkWholeSaleBuy] bit,
    [chkUsers] bit,
    [chkCashier] bit,
    [chkWholesale] bit,
    [chkReports] bit,
    [chkExpenses] bit,
    [chkStock] bit,
    [Active] bit,
    [chkLimitStock] bit,
    [chkItem] bit,
    [chkModifyInvoce] bit,
    [chkInvPayInstallment] bit,
    [chkDelItem] bit DEFAULT ((1)),
    [chkItemSelectInvo] bit DEFAULT ((1))

);

ALTER TABLE [dbo].[user]
ADD CONSTRAINT [PK_user] PRIMARY KEY ([user_id]);

