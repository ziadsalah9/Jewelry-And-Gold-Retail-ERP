-- =============================================
-- Table: dbo.resev_mony
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[resev_mony] (

    [rsev_mony_id] int(10,0) NOT NULL,
    [mony_from] nvarchar(250),
    [date_resev] date,
    [kach] decimal(18,2),
    [total_mone] decimal(18,2),
    [kent] decimal(18,2),
    [for_wont] nvarchar(250),
    [note] nvarchar(500),
    [user_id] int(10,0),
    [date] nvarchar(50)

);

ALTER TABLE [dbo].[resev_mony]
ADD CONSTRAINT [PK_resev_mony] PRIMARY KEY ([rsev_mony_id]);

