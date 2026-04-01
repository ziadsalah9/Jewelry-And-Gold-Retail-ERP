-- =============================================
-- Table: dbo.cacher
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[cacher] (

    [cacherID] int(10,0) NOT NULL,
    [cacher_name] nvarchar(255),
    [start_wark] datetime,
    [full_name] nvarchar(255),
    [adr] nvarchar(255),
    [svil_id] nvarchar(50),
    [CashierSignature] image(2147483647),
    [Active] bit

);

ALTER TABLE [dbo].[cacher]
ADD CONSTRAINT [PK_cacher] PRIMARY KEY ([cacherID]);

