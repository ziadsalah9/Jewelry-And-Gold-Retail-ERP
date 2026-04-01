-- =============================================
-- Table: dbo.DIMON_detels
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[DIMON_detels] (

    [DIMOND_ID] int(10,0) NOT NULL,
    [DIMO_dep] nvarchar(250) NOT NULL,
    [DIM_na9awa] nvarchar(50) NOT NULL,
    [DIMO_mezan] decimal(18,3) NOT NULL,
    [ext_coler] nvarchar(50) NOT NULL,
    [qult] nvarchar(50) NOT NULL,
    [sarual] nvarchar(50),
    [val_gold] nvarchar(50) NOT NULL,
    [GOLD_mezan] decimal(18,3) NOT NULL,
    [test_1] nvarchar(50),
    [test_11] nvarchar(50),
    [test_12] decimal(18,3),
    [test_13] decimal(18,2),
    [test_14] nvarchar(50),
    [test_15] nvarchar(50),
    [test_16] decimal(18,2),
    [test_17] nvarchar(50),
    [test_18] nvarchar(50),
    [test_19] decimal(18,2),
    [test_110] nvarchar(50),
    [test_111] nvarchar(50),
    [test_112] nvarchar(50),
    [test_113] nvarchar(50),
    [test_114] nvarchar(50),
    [test_115] nvarchar(50),
    [test_116] nvarchar(50),
    [test_117] nvarchar(50),
    [test_118] nvarchar(50),
    [test_119] nvarchar(50),
    [date_creted] date,
    [ITEM_IMGE] image(2147483647),
    [Item_Actv] int(10,0),
    [CostToSeller] decimal(18,3) NOT NULL DEFAULT ((0)),
    [TaxExempt] bit NOT NULL DEFAULT ((0)),
    [Documents] image(2147483647),
    [Cut1] nvarchar(50),
    [Clarity1] nvarchar(50),
    [Cut2] nvarchar(50),
    [Clarity2] nvarchar(50),
    [Cut3] nvarchar(50),
    [Clarity3] nvarchar(50),
    [IsDiamond1] bit NOT NULL DEFAULT ((0)),
    [IsDiamond2] bit NOT NULL DEFAULT ((0)),
    [IsDiamond3] bit NOT NULL DEFAULT ((0)),
    [LastEditDate] datetime,
    [CreationDate] datetime,
    [Supplier] nvarchar(50),
    [ItemNote] nvarchar(255),
    [MetalType] int(10,0)

);

ALTER TABLE [dbo].[DIMON_detels]
ADD CONSTRAINT [PK_DIMON_detels] PRIMARY KEY ([DIMOND_ID]);

