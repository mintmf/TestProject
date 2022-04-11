CREATE TABLE [dbo].[Orders] (
    [id]          INT   IDENTITY (1, 1) NOT NULL,
    [order_date]  DATE  NOT NULL,
    [order_sum]   MONEY NOT NULL,
    [payment_sum] MONEY NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([id] ASC)
);

