-- =============================================
-- Table: dbo.send_mony
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[send_mony] (

    [send_id] int(10,0) NOT NULL,
    [sent_to] nvarchar(250),
    [sent_date] date,
    [sent_detels] nvarchar(250),
    [sent_note] nvarchar(250),
    [cah_sent] decimal(18,2),
    [kent_sent] decimal(18,2),
    [total] decimal(18,2),
    [date] date,
    [user_id] int(10,0),
    [Active] int(10,0)

);

ALTER TABLE [dbo].[send_mony]
ADD CONSTRAINT [PK_send_mony] PRIMARY KEY ([send_id]);

