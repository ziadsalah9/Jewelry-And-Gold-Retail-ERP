-- =============================================
-- Table: dbo.ExpensesType
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[ExpensesType] (

    [ID] int(10,0) NOT NULL,
    [ExpensesType] nvarchar(50)

);

ALTER TABLE [dbo].[ExpensesType]
ADD CONSTRAINT [PK_ExpensesType] PRIMARY KEY ([ID]);

