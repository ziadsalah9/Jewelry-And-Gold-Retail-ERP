-- =============================================
-- View: dbo.ExpensesVw
-- Database: DtUpdate
-- =============================================

CREATE VIEW [dbo].[ExpensesVw]
AS
CREATE VIEW dbo.ExpensesVw
AS
SELECT     dbo.Expenses.ExpensesID, dbo.Expenses.ExpensesType, dbo.Expenses.ExpensesDate, dbo.Expenses.ExpensesUserID, dbo.Expenses.ExpensesCashValue, dbo.Expenses.ExpensesKNETValue, 
                      dbo.Expenses.ExpensesPhoto, dbo.Expenses.ExpensesDescription, dbo.[user].user_name
FROM         dbo.Expenses INNER JOIN
                      dbo.[user] ON dbo.Expenses.ExpensesUserID = dbo.[user].user_id


