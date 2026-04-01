-- =============================================
-- Table: dbo.loc_name
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[loc_name] (

    [loc_id] int(10,0) NOT NULL,
    [loc_name] nvarchar(300)

);

ALTER TABLE [dbo].[loc_name]
ADD CONSTRAINT [PK_loc_name] PRIMARY KEY ([loc_id]);

