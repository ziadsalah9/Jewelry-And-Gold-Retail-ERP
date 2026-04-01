-- =============================================
-- Table: dbo.COMPANY_BAY_DETELS
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[COMPANY_BAY_DETELS] (

    [COM_ID] int(10,0) NOT NULL,
    [COMP_NAME] nvarchar(2500) NOT NULL,
    [COMP_NAME_SHORT] nvarchar(2500),
    [SGAL_TAGARE] nvarchar(2500) NOT NULL,
    [PHONE_NOMPER] nvarchar(2500),
    [FAX_NOMPER] nvarchar(2500),
    [LOC_NOMPER] nvarchar(2500),
    [USER_ID] int(10,0) NOT NULL,
    [DATE_CRETED] nvarchar(2500) NOT NULL,
    [PIC1] image(2147483647),
    [PIC11] image(2147483647),
    [PIC12] image(2147483647),
    [PIC13] image(2147483647),
    [PIC14] image(2147483647),
    [PIC15] image(2147483647),
    [PIC16] image(2147483647),
    [PIC17] image(2147483647),
    [PIC18] image(2147483647),
    [PIC19] image(2147483647),
    [PIC110] image(2147483647),
    [PIC111] image(2147483647),
    [NOTE] nvarchar(500),
    [NOTE1] nvarchar(500),
    [NOTE2] nvarchar(500),
    [NOTE3] nvarchar(500),
    [NOTE4] nvarchar(500),
    [NOTE5] nvarchar(500),
    [NOTE6] nvarchar(500),
    [NOTE7] nvarchar(500),
    [NOTE8] nvarchar(500),
    [NOTE9] nvarchar(500),
    [NOTE10] nvarchar(500),
    [NOTE11] nvarchar(500),
    [Active] bit DEFAULT ((1)),
    [cacher] nvarchar(50),
    [SalesCivilID] nvarchar(50)

);

ALTER TABLE [dbo].[COMPANY_BAY_DETELS]
ADD CONSTRAINT [PK_COMPANY_BAY_DETELS] PRIMARY KEY ([COM_ID]);

