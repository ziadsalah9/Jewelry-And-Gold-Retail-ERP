-- =============================================
-- Table: dbo.Gram_val
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Gram_val] (

    [ID_gram] int(10,0) NOT NULL,
    [Gram_valu] nvarchar(255),
    [Gram_price] money(19,4),
    [FractionValues] nvarchar(50)

);

ALTER TABLE [dbo].[Gram_val]
ADD CONSTRAINT [PK_Gram_val] PRIMARY KEY ([ID_gram]);

