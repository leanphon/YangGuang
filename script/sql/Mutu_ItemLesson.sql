use MutuERP
go


drop table ItemLessonList         
create table ItemLessonList(
 FlowSerial varchar(30),
 LessonId int,
 ItemTotal int ,
 RemainCount int default 0,
 PriceDiscount float ,
 PriceTotal float 
);

go
drop view VIEW_ItemLesson_Query
go
create view VIEW_ItemLesson_Query
as
select FlowSerial,LessonId,LessonList.Name as LessonName,ItemTotal,Price as PriceOrigil,PriceDiscount,PriceTotal
from ItemLessonList left join LessonList 
on ItemLessonList.LessonId=LessonList.Id


go
drop view VIEW_ItemLessonList_Normal_Query
go
create view VIEW_ItemLessonList_Normal_Query
as
select CustomerId,ItemLessonList.FlowSerial,LessonId,LessonList.Name as LessonName,ItemTotal,RemainCount
from ItemLessonList left join LessonList 
on ItemLessonList.LessonId=LessonList.Id
left join OrderList on ItemLessonList.FlowSerial=OrderList.FlowSerial
where OrderList.Status='正常' and RemainCount>0

go
drop procedure PR_ItemLesson_Add
go
create procedure PR_ItemLesson_Add
@FlowSerial varchar(30),
@LessonId varchar(30),
@LessonCount varchar(30),
@PriceDiscount varchar(30),
@PriceTotal varchar(30)
as
BEGIN
	declare @stat varchar(250)= '';
	declare @value varchar(200) = '';

	
	set @value = ' VALUES(''' + @FlowSerial + ''',' + cast(@LessonId as varchar(100)) + ',' + cast(@LessonCount as varchar(100)) 
		 + ',' + cast(@LessonCount as varchar(100)) + ',' + cast(@PriceDiscount as varchar(100)) + ',' +  cast(@PriceTotal as varchar(100)) + ')';
	set @stat = 'INSERT ItemLessonList(FlowSerial,LessonId,ItemTotal,RemainCount,PriceDiscount,PriceTotal)' + @value;
	
	print(@stat)
	exec(@stat)
END

go
drop procedure PR_ItemLesson_GetAll
go
create procedure PR_ItemLesson_GetAll
@FlowSerial varchar(30)
as
BEGIN
	declare @stat varchar(250)= '';
	
	set @stat = 'SELECT FlowSerial,LessonId,ItemTotal,RemainCount,PriceOrigil,PriceDiscount,PriceTotal from VIEW_ItemLesson_Query WHERE FlowSerial=''' + @FlowSerial + '''';
	print(@stat)
	exec(@stat)
END

go
drop procedure PR_ItemLessonList_Normal_GetAll
go
create procedure PR_ItemLessonList_Normal_GetAll
@CustomerId int
as
BEGIN
	declare @stat varchar(250)= '';

	set @stat = 'SELECT CustomerId,FlowSerial,LessonId,LessonName,ItemTotal,RemainCount from VIEW_ItemLessonList_Normal_Query 
		WHERE CustomerId=' + cast(@CustomerId  as varchar(100));
	print(@stat)
	exec(@stat)
END

-- Order
go
drop table OrderList
go      
create table OrderList(
 FlowSerial varchar(30) primary key,
 PriceTotal float,
 TradeTime varchar(30),
 CustomerId int ,
 Status varchar(10) -- 正常、退费、结束
);


go
drop view VIEW_Order_Query
go
create view VIEW_Order_Query
as
select FlowSerial,CustomerId,Name,PriceTotal,TradeTime
from OrderList left join CustomerList 
on OrderList.CustomerId=CustomerList.Id

go
drop procedure PR_Order_GetAll
go
create procedure PR_Order_GetAll
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT FlowSerial,CustomerId,PriceTotal,TradeTime from VIEW_Order_Query';
	print(@stat)
	exec(@stat)
END


go
drop procedure PR_Order_Add
go
create procedure PR_Order_Add
@FlowSerial varchar(30) output,
@PriceTotal float ,
@CustomerId int
as
BEGIN
	declare @stat varchar(200)= '';
	declare @value varchar(200) = '';
	declare @dateStr varchar(30);
	declare @rand int;
	declare @randStr varchar(30);
	declare @date varchar(30);

	set @rand = cast( floor(rand()*100) as int);
	set @randStr=convert(varchar(100),@rand)
	set @randStr=isnull(replicate('0',3-len(@randStr)),'')+@randStr
 
	set @date = CONVERT(varchar(100), GETDATE(), 121);
	set @dateStr = replace(@date,'-','');
	set @dateStr = replace(@dateStr,' ','');
	set @dateStr = replace(@dateStr,':','');
	set @dateStr = replace(@dateStr,'.','');
	set @FlowSerial = @dateStr + @randStr;
	--set @FlowSerial = @CustomerId + '_' + CONVERT(varchar(100), GETDATE(), 112);
	--set @FlowSerial = NEWID();
	set @value = ' VALUES(''' + @FlowSerial + ''',''' + @date + ''',' + cast(@PriceTotal as varchar(100)) + ','
		+  cast(@CustomerId as varchar(100)) + ',''正常'')';
	set @stat = 'INSERT OrderList(FlowSerial,TradeTime,PriceTotal,CustomerId,Status)' + @value;
	print(@stat)
	exec(@stat)
END


go
drop table LessonConsumeHistory
go      
create table LessonConsumeHistory(
 FlowSerial varchar(30) primary key,
 OrderFlowSerial varchar(30),
 LessonId int,
 ItemTotal int,
 ConsumeCount int,
 RemainCount int,
 CustomerId int,
 TeacherId varchar(30) ,
 OperatorId int,
 ConsumeTime varchar(30),
 Remark varchar(100)
);

go
drop view VIEW_ItemConsume_Query
go
create view VIEW_ItemConsume_Query
as
select CustomerList.Name as CustomerName,CustomerList.Phone,CustomerList.BabyName,LessonList.Name as LessonName,StaffList.Name as TeacherName,LessonConsumeHistory.ConsumeTime 
from LessonConsumeHistory left join CustomerList on LessonConsumeHistory.CustomerId=CustomerList.Id
LEFT JOIN LessonList ON LessonList.Id=LessonConsumeHistory.LessonId 
LEFT JOIN StaffList ON StaffList.Id=LessonConsumeHistory.TeacherId 


go
drop procedure PR_ItemConsume_Add
go
create procedure PR_ItemConsume_Add
@OrderFlowSerial varchar(30),
@LessonId int,
@ItemTotal int,
@ConsumeCount int,
@RemainCount int,
@CustomerId int ,
@TeacherId int ,
@OperatorId int ,
@Remark varchar(100) = ''
as
BEGIN
	declare @stat nvarchar(1000)= '';
	declare @value nvarchar(1000) = '';
	declare @param nvarchar(1000) = '';
	
	declare @dateStr varchar(30);
	declare @rand int;
	declare @randStr varchar(30);
	declare @date varchar(30);
	declare @FlowSerial varchar(30);
	declare @cnt int = 0;
	declare @err int = 0;
	

	set @rand = cast( floor(rand()*100) as int);
	set @randStr=convert(varchar(100),@rand)
	set @randStr=isnull(replicate('0',3-len(@randStr)),'')+@randStr
 
	set @date = CONVERT(varchar(100), GETDATE(), 121);
	set @dateStr = replace(@date,'-','');
	set @dateStr = replace(@dateStr,' ','');
	set @dateStr = replace(@dateStr,':','');
	set @dateStr = replace(@dateStr,'.','');
	set @FlowSerial = @dateStr + @randStr;
	--set @FlowSerial = NEWID();

	begin transaction

	begin try

		-- 1、向消费历史表中插入记录
		set @stat = N'INSERT LessonConsumeHistory(FlowSerial,OrderFlowSerial,LessonId,ItemTotal,ConsumeCount,RemainCount,CustomerId,TeacherId,OperatorId,ConsumeTime,Remark)'
			+ ' VALUES(@FlowSerial,@OrderFlowSerial,@LessonId, @ItemTotal, @ConsumeCount, @RemainCount, @CustomerId, @TeacherId, @OperatorId, @date, @Remark)';
		set @param = N'@FlowSerial varchar(30),@OrderFlowSerial varchar(30),@LessonId int, @ItemTotal int, @ConsumeCount int, @RemainCount int, @CustomerId int, @TeacherId int, @OperatorId int, @date varchar(30), @Remark varchar(100)';
		exec sp_executesql @stat,@param,@FlowSerial,@OrderFlowSerial,@LessonId, @ItemTotal, @ConsumeCount, @RemainCount, @CustomerId, @TeacherId, @OperatorId, @date, @Remark


		-- 2、更新条目表中剩余数量
		set @stat = N'UPDATE ItemLessonList SET RemainCount=@RemainCount WHERE FlowSerial=@OrderFlowSerial AND LessonId=@LessonId';
		set @param = N'@OrderFlowSerial varchar(30),@LessonId int, @RemainCount int'
		exec sp_executesql @stat,@param,@OrderFlowSerial,@LessonId,@RemainCount

		-- 3、判断该order流水号下的所有条目是否都已经消费完并更新order的状态
		set @stat = N'SELECT @cnt=COUNT(*) FROM ItemLessonList WHERE FlowSerial=@OrderFlowSerial AND RemainCount>0';
		set @param = N'@OrderFlowSerial varchar(30),@cnt int output'
		exec sp_executesql @stat,@param,@OrderFlowSerial,@cnt output
		if (@cnt = 0) --更新
		begin
			set @stat = N'UPDATE OrderList SET status=''结束'' WHERE FlowSerial=@OrderFlowSerial';
			set @param = N'@OrderFlowSerial varchar(30)'
			exec sp_executesql @stat,@param,@OrderFlowSerial
		end

	end try
	begin catch
		set @err = 1;
	end catch

	if (@err = 1)
	begin
		rollback tran;
	end
	else
	begin
		commit tran;
	end

END 


go
drop procedure PR_ItemConsume_GetAll
go
create procedure PR_ItemConsume_GetAll
@CustomerName varchar(30) = null,
@LessonName varchar(30) = null,
@TeacherName varchar(30) = null,
@DateBegin varchar(30) = null,
@DateEnd varchar(30) = null
as
BEGIN
	declare @stat nvarchar(1000)= '';
	declare @value nvarchar(1000) = '';
	declare @param nvarchar(1000) = '';
	declare @CustomerId int;
	
	set @stat = N'SELECT CustomerName,Phone,BabyName,LessonName,TeacherName, ConsumeTime FROM VIEW_ItemConsume_Query WHERE 1=1';
	
	if @CustomerName is not null
	begin
		set @stat = @stat + ' AND CustomerName=''' + @CustomerName + '''';
	end
	if @LessonName is not null
	begin
		set @stat = @stat + ' AND LessonName=''' + @LessonName + '''';
	end
	if @TeacherName is not null
	begin
		set @stat = @stat + ' AND TeacherName=''' + @TeacherName + '''';
	end
	if @DateBegin is not null
	begin
		set @stat = @stat + ' AND DATEDIFF(day,'''+ @DateBegin + ''',ConsumeTime)>=0';
	end
	if @DateEnd is not null
	begin
		set @stat = @stat + ' AND DATEDIFF(day,'''+ @DateEnd + ''',ConsumeTime)<=0';
	end
		
	exec(@stat)

	return 0;

END 