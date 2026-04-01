-- =============================================
-- Table: dbo.resev_gold
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[resev_gold] (

    [resv_id] int(10,0) NOT NULL,
    [res_from] nvarchar(150),
    [resv_mezan] decimal(18,3),
    [resv_date] nvarchar(50),
    [resv_tim] nvarchar(50),
    [resv_val] nvarchar(50),
    [resev_user] int(10,0)

);

ALTER TABLE [dbo].[resev_gold]
ADD CONSTRAINT [PK_resev_gold] PRIMARY KEY ([resv_id]);

