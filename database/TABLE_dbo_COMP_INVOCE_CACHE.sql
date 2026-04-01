-- =============================================
-- Table: dbo.COMP_INVOCE_CACHE
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[COMP_INVOCE_CACHE] (

    [COM_INV_id] int(10,0) NOT NULL,
    [COMP_ID] int(10,0),
    [BAY_id] int(10,0),
    [CASTOMER_ID_t] nvarchar(255),
    [GOLED_wazen] numeric(18,3),
    [GOLED_VALUS] int(10,0),
    [GOLED_GRAM_PRICE] numeric(18,3),
    [GOLED_TOTAL_PRICE] numeric(18,3),
    [PIC1] image(2147483647),
    [note1] nvarchar(255),
    [note2] nvarchar(255),
    [note3] nvarchar(255)

);

ALTER TABLE [dbo].[COMP_INVOCE_CACHE]
ADD CONSTRAINT [PK_COMP_INVOCE_CACHE] PRIMARY KEY ([COM_INV_id]);

