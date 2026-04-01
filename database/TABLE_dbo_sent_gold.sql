-- =============================================
-- Table: dbo.sent_gold
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[sent_gold] (

    [sent_gold_id] int(10,0) NOT NULL,
    [sent_val] nchar(50),
    [sent_mezan] decimal(18,3),
    [sent_to] nvarchar(150),
    [sent_date] nvarchar(50),
    [sent_tim] nvarchar(50),
    [sent_name] nvarchar(50),
    [user_id] int(10,0)

);

ALTER TABLE [dbo].[sent_gold]
ADD CONSTRAINT [PK_sent_gold] PRIMARY KEY ([sent_gold_id]);

