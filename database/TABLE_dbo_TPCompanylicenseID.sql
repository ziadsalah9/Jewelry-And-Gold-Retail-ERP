-- =============================================
-- Table: dbo.TPCompanylicenseID
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPCompanylicenseID] (

    [ID] int(10,0) NOT NULL,
    [CompanylicenseID] nvarchar(255)

);

ALTER TABLE [dbo].[TPCompanylicenseID]
ADD CONSTRAINT [PK_TPCompanylicenseID] PRIMARY KEY ([ID]);

