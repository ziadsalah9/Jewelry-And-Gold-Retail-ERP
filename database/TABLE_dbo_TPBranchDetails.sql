-- =============================================
-- Table: dbo.TPBranchDetails
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPBranchDetails] (

    [BranchID] int(10,0) NOT NULL,
    [BranchDT] nvarchar(50),
    [BranchServerNa] nvarchar(50),
    [BranchUser] nvarchar(50),
    [BranchPassword] nvarchar(50),
    [BranchPublic] nvarchar(60),
    [BranchActive] int(10,0)

);

ALTER TABLE [dbo].[TPBranchDetails]
ADD CONSTRAINT [PK_TPBranchDetails] PRIMARY KEY ([BranchID]);

