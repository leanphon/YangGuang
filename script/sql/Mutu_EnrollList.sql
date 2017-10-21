use MutuERP
go

-- Order
drop table OrderList         
create table OrderList(
 FlowSerial int not null primary key identity(1,1),
 CustomerId varchar(15) not null,
 TradeTime varchar(20) not null,
 PriceDiscount float ,
 PriceTotal float 
);

go
drop procedure PR_Order_GetAll
go
create procedure PR_Order_GetAll
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Price,Description from OrderList';
	print(@stat)
	exec(@stat)
END
