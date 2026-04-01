-- =============================================
-- Table: dbo.dimon_invce
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[dimon_invce] (

    [dim_inv_id] int(10,0) NOT NULL,
    [dimo_id] nvarchar(50) NOT NULL,
    [castomr_id] nvarchar(255) NOT NULL,
    [descont] nvarchar(50),
    [total] decimal(18,3) NOT NULL,
    [ar_taype] nvarchar(250) NOT NULL,
    [DIMO_Type] nvarchar(50) NOT NULL,
    [DIM_na9awa] nvarchar(50) NOT NULL,
    [DIMO_mezan] decimal(18,3) NOT NULL,
    [DIMO_coler] nvarchar(50) NOT NULL,
    [DIMO_qult] int(10,0) NOT NULL,
    [sarual] nvarchar(50) NOT NULL,
    [val_gold] decimal(18,0) NOT NULL,
    [GOLD_mezan] decimal(18,3) NOT NULL,
    [user_creted] int(10,0) NOT NULL,
    [date_creted] date,
    [time] nvarchar(250),
    [dim_foto] image(2147483647),
    [test_17] nvarchar(50),
    [test_18] nvarchar(50),
    [test_19] decimal(18,3),
    [test_110] nvarchar(50),
    [test_111] nvarchar(50),
    [test_112] nvarchar(50),
    [test_14] nvarchar(50),
    [test_15] nvarchar(50),
    [test_116] decimal(18,3),
    [test_117] nvarchar(50),
    [test_118] nvarchar(50),
    [test_119] nvarchar(50),
    [notes] nvarchar(250),
    [test_13] decimal(18,3),
    [test_16] decimal(18,3),
    [Item_Actv] int(10,0),
    [staytes] nvarchar(50),
    [GramPrice] decimal(18,3) NOT NULL DEFAULT ((0)),
    [SoldItem] nvarchar(200),
    [Cut1] nvarchar(50),
    [Clarity1] nvarchar(50),
    [Cut2] nvarchar(50),
    [Clarity2] nvarchar(50),
    [Cut3] nvarchar(50),
    [Clarity3] nvarchar(50),
    [IsDiamond1] bit DEFAULT ((0)),
    [IsDiamond2] bit DEFAULT ((0)),
    [IsDiamond3] bit DEFAULT ((0)),
    [CertificateNumber] nvarchar(200)

);

ALTER TABLE [dbo].[dimon_invce]
ADD CONSTRAINT [PK_dimon_invce] PRIMARY KEY ([dim_inv_id]);

