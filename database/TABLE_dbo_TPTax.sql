-- =============================================
-- Table: dbo.TPTax
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPTax] (

    [ID] int(10,0) NOT NULL,
    [TaxType] decimal(18,3),
    [TaxActiv] int(10,0)

);

ALTER TABLE [dbo].[TPTax]
ADD CONSTRAINT [PK_TPTax] PRIMARY KEY ([ID]);

