-- =============================================
-- Table: dbo.PayMethod
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[PayMethod] (

    [ID] int(10,0) NOT NULL,
    [PayMethodAr] nvarchar(50),
    [PayMethodEn] nvarchar(50),
    [Active] bit

);

ALTER TABLE [dbo].[PayMethod]
ADD CONSTRAINT [PK_PayMethod] PRIMARY KEY ([ID]);

