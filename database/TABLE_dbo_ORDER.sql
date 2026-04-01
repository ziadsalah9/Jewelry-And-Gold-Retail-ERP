-- =============================================
-- Table: dbo.ORDER
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[ORDER] (

    [id] int(10,0) NOT NULL,
    [OR_ID] nvarchar(255),
    [OR_name] nvarchar(255),
    [OR_qunt] int(10,0),
    [OR_price] money(19,4),
    [OR_totalPrice] money(19,4)

);

ALTER TABLE [dbo].[ORDER]
ADD CONSTRAINT [PK_ORDER] PRIMARY KEY ([id]);

