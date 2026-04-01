-- =============================================
-- Table: dbo.CastomerDETELS
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[CastomerDETELS] (

    [CastomerID] int(10,0) NOT NULL,
    [CastomerCAIVELid] nvarchar(255) NOT NULL,
    [CastomerNAme] nvarchar(255) NOT NULL,
    [CastomerADr] nvarchar(255) NOT NULL,
    [CastomerTE] nvarchar(255) NOT NULL,
    [CastomerNA] nvarchar(255) NOT NULL,
    [foto] image(2147483647),
    [Signature] image(2147483647),
    [fotoBack] image(2147483647),
    [CastomerNameEn] nvarchar(255) NOT NULL DEFAULT (N'')

);

ALTER TABLE [dbo].[CastomerDETELS]
ADD CONSTRAINT [PK_CastomerDETELS] PRIMARY KEY ([CastomerID]);

