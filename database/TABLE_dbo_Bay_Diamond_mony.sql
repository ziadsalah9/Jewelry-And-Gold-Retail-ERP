-- =============================================
-- Table: dbo.Bay_Diamond_mony
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Bay_Diamond_mony] (

    [bay_id] int(10,0) NOT NULL,
    [saryal] int(10,0),
    [total_price] decimal(18,3),
    [cach] decimal(18,3),
    [kenet] decimal(18,3),
    [arabik] nvarchar(300),
    [date] date,
    [English] nvarchar(300),
    [Active] int(10,0),
    [PayMethod] int(10,0)

);

ALTER TABLE [dbo].[Bay_Diamond_mony]
ADD CONSTRAINT [PK_Bay_Diamond_mony] PRIMARY KEY ([bay_id]);

