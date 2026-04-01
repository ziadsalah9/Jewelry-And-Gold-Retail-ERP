-- =============================================
-- Table: dbo.bay_goled_mony
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[bay_goled_mony] (

    [bay_id] int(10,0) NOT NULL,
    [saryal] nvarchar(255),
    [total_price] decimal(18,3),
    [cach] decimal(18,3),
    [kenet] decimal(18,3),
    [arabik] nvarchar(300),
    [date] date,
    [English] nvarchar(300),
    [TIME_INV] nvarchar(255),
    [INV_Actv] int(10,0),
    [Cashier] nvarchar(255),
    [PayMethod] nvarchar(50),
    [ID_MAX] nvarchar(255),
    [SalesInvNumber] nvarchar(500)

);

ALTER TABLE [dbo].[bay_goled_mony]
ADD CONSTRAINT [PK_bay_goled_mony] PRIMARY KEY ([bay_id]);

