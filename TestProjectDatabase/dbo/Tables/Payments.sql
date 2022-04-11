CREATE TABLE [dbo].[Payments] (
    [order_id]    INT   NOT NULL,
    [transfer_id] INT   NOT NULL,
    [payment_sum] MONEY NOT NULL
);


GO
CREATE trigger [dbo].[pay2] 
on [dbo].[Payments] for insert
as
begin
	begin transaction
	declare @iorder_id int = (select order_id from inserted)
	declare @itransfer_id int = (select transfer_id from inserted)
	declare @ipayment_sum money = (select payment_sum from inserted)

	declare @order_sum money = (select order_sum from Orders where id = @iorder_id)
	declare @order_payment_sum money = (select payment_sum from Orders where id = @iorder_id)

	declare @transfer_sum money = (select transfer_sum from Transfers where id = @itransfer_id)
	declare @transfer_leftover money = (select leftover from Transfers where id = @itransfer_id)
	
	if @ipayment_sum < 0
	begin
		raiserror('Сумма перевода должна быть положительной', 16, 1)
		rollback transaction
		return
	end

	if @transfer_leftover - @ipayment_sum < 0
	begin
		raiserror('Сумма платежа превышает остаток', 16, 1)
		rollback transaction
		return
	end

	if @order_payment_sum + @ipayment_sum > @order_sum
	begin
		raiserror('Платеж превышает сумму заказа', 16, 1)
		rollback transaction
		return
	end

	update Orders
	set payment_sum = payment_sum + @ipayment_sum
	where id = (select order_id from inserted)

	update Transfers set leftover = leftover - @ipayment_sum
	where id = (select transfer_id from inserted)
	commit
end