-- =============================================
-- Table: dbo.Buy_Diamond
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Buy_Diamond] (

    [B_Diamond_id] int(10,0) NOT NULL,
    [castomer_id] nvarchar(255) NOT NULL,
    [val_gold] nvarchar(255) NOT NULL,
    [GOLD_mezan] decimal(18,3) NOT NULL,
    [bay_total_price] decimal(18,3) NOT NULL,
    [DIMO_dep] nvarchar(50) NOT NULL,
    [DIM_na9awa] nvarchar(50) NOT NULL,
    [DIMO_mezan] decimal(18,3) NOT NULL,
    [ext_coler] nvarchar(50) NOT NULL,
    [qult] nvarchar(50) NOT NULL,
    [sarual] nvarchar(50) NOT NULL,
    [test_12] decimal(18,3) NOT NULL,
    [test_11] nvarchar(50) NOT NULL,
    [inv_id] int(10,0) NOT NULL,
    [Notes] nvarchar,
    [Active] int(10,0)

);

ALTER TABLE [dbo].[Buy_Diamond]
ADD CONSTRAINT [PK_Buy_Diamond] PRIMARY KEY ([B_Diamond_id]);

