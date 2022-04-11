CREATE TABLE [dbo].[Transfers] (
    [id]            INT   IDENTITY (1, 1) NOT NULL,
    [transfer_date] DATE  NOT NULL,
    [transfer_sum]  MONEY NOT NULL,
    [leftover]      MONEY NOT NULL,
    CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED ([id] ASC)
);



