-- =============================================
-- Table: dbo.TPTransfer
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[TPTransfer] (

    [TransferID] int(10,0) NOT NULL,
    [BarCodeTransfer] nvarchar(50),
    [DateBarCode] date,
    [TimeBarCode] datetime,
    [TransferStatus] int(10,0)

);

ALTER TABLE [dbo].[TPTransfer]
ADD CONSTRAINT [PK_TPTransfer] PRIMARY KEY ([TransferID]);

