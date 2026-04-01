-- =============================================
-- Table: dbo.TPWhatsAppMessages
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPWhatsAppMessages] (

    [ID] int(10,0) NOT NULL,
    [TextMessages] nvarchar(1000),
    [FillPath] nvarchar(250),
    [DateCreated] date

);

ALTER TABLE [dbo].[TPWhatsAppMessages]
ADD CONSTRAINT [PK_TPWhatsAppMessages] PRIMARY KEY ([ID]);

