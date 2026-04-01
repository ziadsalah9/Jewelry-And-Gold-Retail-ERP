-- =============================================
-- Table: dbo.TpSetGoledPriceDiff
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TpSetGoledPriceDiff] (

    [ID] int(10,0) NOT NULL,
    [TEX24BUY] decimal(18,3),
    [TEX22BUY] decimal(18,3),
    [TEX21BUY] decimal(18,3),
    [TEX18BUY] decimal(18,3),
    [TEX925BUY] decimal(18,3),
    [TEXOnceBUY] decimal(18,3),
    [TEX24Sell] decimal(18,3),
    [TEX22Sell] decimal(18,3),
    [TEX21Sell] decimal(18,3),
    [TEX18Sell] decimal(18,3),
    [TEX925Sell] decimal(18,3),
    [TEXOnceSell] decimal(18,3),
    [TEXOnceSellUsd] decimal(18,3),
    [TEXOnceBUYUsd] decimal(18,3)

);

ALTER TABLE [dbo].[TpSetGoledPriceDiff]
ADD CONSTRAINT [PK_TpSetGoledPriceDiff] PRIMARY KEY ([ID]);

