use MutuERP
go

-- Customer
drop table CustomerList         
create table CustomerList(
 Id int not null primary key identity(1,1),
 Name varchar(15) not null,
 Phone varchar(15) not null,
 IdCard varchar(20) not null,
 Sex varchar(2) ,
 Age int,
 Email varchar (30),
 ChatId varchar(20),
 Address varchar(60),
 Password varchar(100),
 BabyName varchar(15),
 BabyAge int,
 Relation varchar(10),
 Remark varchar(100)
);


go
drop procedure PR_Customer_Add
go
create procedure PR_Customer_Add
@Id int output,
@Name varchar(30),
@Phone varchar(15),
@IdCard varchar(15),
@Password varchar(100),
@Sex varchar(2) = null,
@Age int  = null,
@Email varchar(30) = null,
@ChatId varchar(15) = null,
@Address varchar(60) = null,
@BabyName varchar(15) = null,
@BabyAge int  = null,
@Relation varchar(10)  = null,
@Remark varchar(100)  = null
as
BEGIN
	declare @stat varchar(500)= '';
	declare @value varchar(300) = '';

	set @value = ' VALUES(''' + @Name + ''',''' + @Phone + ''',''' + @IdCard + ''',''' + @Password + '''';
	set @stat = 'INSERT CustomerList(Name,Phone,IdCard,Password';
	
	if @Sex is not null
	begin
		set @value = @value + ',''' + @Sex + '''';
		set @stat = @stat + ',Sex';
	end
	if @Age is not null
	begin
		set @value = @value + ',' + cast(@Age as varchar(10));
		set @stat = @stat + ',Age';
	end
	if @Email is not null
	begin
		set @value = @value + ',''' + @Email + '''';
		set @stat = @stat + ',Email';
	end
	if @ChatId is not null
	begin
		set @value = @value + ',''' + @ChatId + '''';
		set @stat = @stat + ',ChatId';
	end	
	if @Address is not null
	begin
		set @value = @value + ',''' + @Address + '''';
		set @stat = @stat + ',Address';
	end	
	if @BabyName is not null
	begin
		set @value = @value + ',''' + @BabyName + '''';
		set @stat = @stat + ',BabyName';
	end	
	if @BabyAge is not null
	begin
		set @value = @value + ',' + cast(@BabyAge as varchar(10));
		set @stat = @stat + ',BabyAge';
	end	
	if @Relation is not null
	begin
		set @value = @value + ',''' + @Relation + '''';
		set @stat = @stat + ',Relation';
	end	
	if @Remark is not null
	begin
		set @value = @value + ',''' + @Remark + '''';
		set @stat = @stat + ',Remark';
	end
		
	set @value = @value + ')';
	set @stat = @stat + ')' + @value;
	
	print(@stat)
	exec(@stat)

	select @Id = @@IDENTITY;

END

go
drop procedure PR_Customer_GetAll
go
create procedure PR_Customer_GetAll
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Phone,IdCard,Password,Sex,Age,Email,ChatId,Address,BabyName,BabyAge,Relation from CustomerList';
	print(@stat)
	exec(@stat)
END
go
drop procedure PR_Customer_IsExist

go
create procedure PR_Customer_IsExist
@Name varchar(30),
@Phone varchar(15)
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Phone from CustomerList WHERE Name=''' + @Name + ''' and Phone=''' + @Phone + '''';
	print(@stat)
	exec(@stat)
END

go
drop procedure PR_Customer_Find

go
create procedure PR_Customer_Find
@Name varchar(30),
@Phone varchar(15)
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Phone,IdCard,Password,Sex,Age,Email,ChatId,Address,BabyName,BabyAge,Relation from CustomerList WHERE Name=''' + @Name + ''' and Phone=''' + @Phone + '''';
	print(@stat)
	exec(@stat)
END

go
drop procedure PR_Customer_FindOrder

go
create procedure PR_Customer_FindOrder
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'select Id,Name,Phone,IdCard from CustomerList right join OrderList on CustomerList.Id=OrderList.CustomerId WHERE OrderList.Status=''Õý³£''';
	print(@stat)
	exec(@stat)
END