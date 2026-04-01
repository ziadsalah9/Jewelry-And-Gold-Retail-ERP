-- =============================================
-- View: dbo.ReportExpensesAllData
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ReportExpensesAllData]
AS
CREATE VIEW [dbo].[ReportExpensesAllData] AS SELECT dbo.Expenses.ExpensesID, 
dbo.Expenses.ExpensesType, dbo.Expenses.ExpensesDate, dbo.Expenses.ExpensesUserID, 
dbo.Expenses.ExpensesCashValue, dbo.Expenses.ExpensesKNETValue, 
dbo.Expenses.ExpensesPhoto, dbo.Expenses.ExpensesDescription, dbo.Expenses.PayMethod, 
dbo.Expenses.Active, dbo.Expenses.CashVoucherNo, dbo.Expenses.ExpensesInvID, 
dbo.Expenses.ExpensesDateTime, dbo.Expenses.Cacher, dbo.[user].user_name, 
dbo.cacher.cacher_name, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn, 
dbo.Expenses.ExpensesCashValue + dbo.Expenses.ExpensesKNETValue AS ExpensesTotalValue 
FROM dbo.Expenses LEFT OUTER JOIN 
dbo.[user] ON dbo.Expenses.ExpensesUserID = dbo.[user].user_id LEFT OUTER JOIN 
dbo.PayMethod ON dbo.Expenses.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN 
dbo.cacher ON dbo.Expenses.Cacher = dbo.cacher.svil_id 
WHERE (dbo.Expenses.Active = 1)

