-- =============================================
-- Table: dbo.Item_Name
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Item_Name] (

    [Item_Name_ID] int(10,0) NOT NULL,
    [Item_Name] nvarchar(50)

);

ALTER TABLE [dbo].[Item_Name]
ADD CONSTRAINT [PK_Item_Name] PRIMARY KEY ([Item_Name_ID]);

