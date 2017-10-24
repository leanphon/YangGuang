------ 岗位增删查改
go
drop procedure PR_Post_Add;
go
create procedure PR_Post_Add
@Name varchar(30) = null,
@Level varchar(30) = null,
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'INSERT PostList(Name,Level,BaseSalary) VALUES(@Name,@Level,@BaseSalary)';
	set @param = N'@Name varchar(30),@Level varchar(15),@BaseSalary int';
	exec sp_executesql @stat,@param,@Name,@Level,@BaseSalary

	return 0;
END

go
drop procedure PR_Post_Update
go
create procedure PR_Post_Update
@Id int,
@Name varchar(30),
@Level varchar(30),
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'UPDATE PostList SET Name=@Name,Level=@Level,BaseSalary=@BaseSalary WHERE Id=@Id';
	set @param = N'@Name varchar(30),@Level varchar(15),@BaseSalary int, @Id int';
	exec sp_executesql @stat,@param,@Name,@Level,@BaseSalary,@Id

	return 0;
END


go
drop procedure PR_Post_Delete
go
create procedure PR_Post_Delete
@Id int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'DELETE FROM PostList WHERE Id=@Id';
	set @param = N'@Id int';
	exec sp_executesql @stat,@param,@Id

	return 0;
END

go
drop procedure PR_Post_GetAll
go
create procedure PR_Post_GetAll
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'SELECT Id,Name,Level,BaseSalary from PostList';
	print(@stat)
	exec(@stat)
	return 0;
END

------ 绩效增删查改

go
drop procedure PR_Performance_Add;
go
create procedure PR_Performance_Add
@Level varchar(30) = null,
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'INSERT PerformanceList(Level,BaseSalary) VALUES(@Level,@BaseSalary)';
	set @param = N'@Level varchar(15),@BaseSalary int';
	exec sp_executesql @stat,@param,@Level,@BaseSalary

	return 0;
END

go
drop procedure PR_Performance_Update
go
create procedure PR_Performance_Update
@Id int,
@Level varchar(30),
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'UPDATE PerformanceList SET Level=@Level,BaseSalary=@BaseSalary WHERE Id=@Id';
	set @param = N'@Level varchar(15),@BaseSalary int, @Id int';
	exec sp_executesql @stat,@param,@Level,@BaseSalary,@Id

	return 0;
END


go
drop procedure PR_Performance_Delete
go
create procedure PR_Performance_Delete
@Id int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';

	set @stat = N'DELETE FROM PerformanceList WHERE Id=@Id';
	set @param = N'@Id int';
	exec sp_executesql @stat,@param,@Id

	return 0;
END

go
drop procedure PR_Performance_GetAll
go
create procedure PR_Performance_GetAll
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'SELECT Id,Level,BaseSalary from PerformanceList';
	print(@stat)
	exec(@stat)
	return 0;
END

------ 效益增删查改

go
drop procedure PR_Benefit_Add;
go
create procedure PR_Benefit_Add
@Name varchar(30) = null,
@Level varchar(30) = null,
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'INSERT BenefitList(Level,BaseSalary) VALUES(@Level,@BaseSalary)';
	set @param = N'@Level varchar(15),@BaseSalary int';
	exec sp_executesql @stat,@param,@Level,@BaseSalary

	return 0;
END

go
drop procedure PR_Benefit_Update
go
create procedure PR_Benefit_Update
@Id int,
@Level varchar(30),
@BaseSalary int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'UPDATE BenefitList SET Level=@Level,BaseSalary=@BaseSalary WHERE Id=@Id';
	set @param = N'@Level varchar(15),@BaseSalary int, @Id int';
	exec sp_executesql @stat,@param,@Level,@BaseSalary,@Id

	return 0;
END


go
drop procedure PR_Benefit_Delete
go
create procedure PR_Benefit_Delete
@Id int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'DELETE FROM BenefitList WHERE Id=@Id';
	set @param = N'@Id int';
	exec sp_executesql @stat,@param,@Id

	return 0;
END

go
drop procedure PR_Benefit_GetAll
go
create procedure PR_Benefit_GetAll
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'SELECT Id,Level,BaseSalary from BenefitList';
	print(@stat)
	exec(@stat)
	return 0;
END


------ 员工增删查改
go
drop procedure PR_Staff_Add
go
create procedure PR_Staff_Add
@Id int output,
@StaffNumber varchar(30),
@Name varchar(30),
@Phone varchar(15),
@IdCard varchar(20),
@Sex varchar(2) = null,
@Birthday varchar(15) = null,
@BankCard varchar(20) = null,
@DepartmentId int = 0,
@Status varchar(10),
@DateEntry varchar(20)
as
BEGIN
	declare @stat varchar(800)= '';
	declare @value varchar(800)='';

	set @value = ' VALUES(''' + @StaffNumber + ''',''' + @Name + ''',''' + @Phone + ''',''' + @IdCard + ''',''' + @Status + ''',''' + @DateEntry + '''';
	set @stat = 'INSERT StaffList(StaffNumber,Name,Phone,IdCard,Status,DateEntry';
	

	if @Sex is not null
	begin
		set @value = @value + ',''' + @Sex + '''';
		set @stat = @stat + ',Sex';
	end
	if @Birthday is not null
	begin
		set @value = @value + ',''' + @Birthday + '''';
		set @stat = @stat + ',Birthday';
	end
	if @BankCard is not null
	begin
		set @value = @value + ',''' + @BankCard + '''';
		set @stat = @stat + ',BankCard';
	end
	if @DepartmentId is not null
	begin
		set @value = @value + ',' + cast(@DepartmentId as varchar(20));
		set @stat = @stat + ',DepartmentId';
	end

	set @value = @value + ')';
	set @stat = @stat + ')' + @value;
	
	print(@stat)
	exec(@stat)

	select @Id = @@IDENTITY;

	return 0;
END


go
drop procedure PR_Staff_Update
go
create procedure PR_Staff_Update
@Id int,
@StaffNumber varchar(30),
@Name varchar(30),
@Phone varchar(15),
@IdCard varchar(20),
@Sex varchar(2) = null,
@Birthday varchar(15) = null,
@BankCard varchar(20) = null,
@DepartmentId int = 0,
@Status varchar(10) = null,
@DateEntry varchar(20) = null,
@DateFormal varchar(20) = null,
@DateLeave varchar(20) = null
as
BEGIN
	declare @stat varchar(800)= '';

	set @stat = 'UPDATE StaffList SET StaffNumber=''' + @StaffNumber + ''',Name='''+ @Name + ''',Phone=''' + @Phone +''',IdCard=''' + @IdCard + '''';
	
	if @Sex is not null
	begin
		set @stat = @stat + ',Sex=''' + @Sex + '''';
	end
	if @Birthday is not null
	begin
		set @stat = @stat + ',Birthday=''' + @Birthday + '''';
	end
	if @BankCard is not null
	begin
		set @stat = @stat + ',BankCard=''' + @BankCard + '''';
	end
	if @stat is not null
	begin
		set @stat = @stat + ',DepartmentId=' + cast(@DepartmentId as varchar(20));
	end
	if @Status is not null
	begin
		set @stat = @stat + ',Status=''' + @Status + '''';
	end
	if @DateEntry is not null
	begin
		set @stat = @stat + ',DateEntry=''' + @DateEntry + '''';
	end
	if @DateFormal is not null
	begin
		set @stat = @stat + ',DateFormal=''' + @DateFormal + '''';
	end
	if @DateEntry is not null
	begin
		set @stat = @stat + ',DateLeave=''' + @DateLeave + '''';
	end

	set @stat = @stat + ' WHERE Id=''' + @Id + ''''
	
	print(@stat)
	exec(@stat)
	return 0;
END

go
drop procedure PR_Staff_UpdateSalary
go
create procedure PR_Staff_UpdateSalary
@Id int,
@PostId int,
@PerformanceId int,
@BenefitId int,
@AttendanceSalary int,
@SenioritySalary int
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'UPDATE StaffList SET PostId='+ cast(@PostId as varchar) + ',PerformanceId=' + cast(@PerformanceId as varchar)
	   + ',BenefitId='+ cast(@BenefitId as varchar) + ',AttendanceSalary='+ cast(@AttendanceSalary as varchar) + ',SenioritySalary='+ cast(@SenioritySalary as varchar) 
	   + 'WHERE Id=' + cast(@Id as varchar(20))
	print(@stat)
	exec(@stat)
	return 0;
END



-- 按照部门进行查询
go
drop procedure PR_StaffList_GetAll_Department
go
create procedure PR_StaffList_GetAll_Department
as
BEGIN
	declare @stat varchar(1000)= '';

	set @stat = 'SELECT StaffList.Id as StaffId,StaffNumber,StaffList.Name AS StaffName,DepartmentList.Name AS DepartmentName'
		+ ' FROM StaffList LEFT JOIN DepartmentList ON StaffList.DepartmentId=DepartmentList.Id';
	
	print(@stat)
	exec(@stat)
	return 0;
END

go
drop procedure PR_Staff_GetAll
go
create procedure PR_Staff_GetAll
@message varchar(30) = null
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'SELECT Id,StaffNumber,Name,Sex,Birthday, Phone, IdCard, BankCard,DepartmentId,PostId,PerformanceId,BenefitId FROM StaffList';
	print(@stat)
	exec(@stat)
	return 0;
END

go
drop procedure PR_Staff_IsExist
go
create procedure PR_Staff_IsExist
@StaffNumber varchar(30)
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'SELECT StaffNumber,Name,Sex,Birthday, Phone, IdCard, BankCard,PostId,PerformanceId,BenefitId FROM StaffList WHERE StaffNumber='''+ @StaffNumber + '''';
	print(@stat)
	exec(@stat)
	return 0;
END


go
drop procedure PR_Staff_GetSalaryInfo
go
create procedure PR_Staff_GetSalaryInfo
as
BEGIN
	declare @stat varchar(500)= '';

	set @stat = 'SELECT StaffId,PersonName,StaffNumber,PostName,PostLevel,PostBaseSalary,PerformanceLevel,PerformanceBaseSalary,'
		+ 'BenefitLevel,BenefitBaseSalary,AttendanceSalary,SenioritySalary FROM VIEW_Staff_Salary_Info_Query';
	print(@stat)
	exec(@stat)
	return 0;
END


------ 工资条增删查改
go
drop procedure PR_SalaryBill_Add
go
create procedure PR_SalaryBill_Add
@BillNumber varchar(30) output,
@StaffId int,
@StaffNumber varchar(30),
@PostSalary int = 0,
@PerformanceSalary int = 0,
@BenefitSalary int = 0,
@AttendanceSalary int = 0,
@SenioritySalary int = 0,
@ReissueSalary int =0,
@SalaryTotal int = 0,
@BelongMonth varchar(15),
@DateBegin varchar(15),
@DateEnd varchar(15),
@InputStaffNumber varchar(30)
as
BEGIN
	declare @stat nvarchar(1000)= '';
	declare @param nvarchar(1000)= '';
	declare @vlaue varchar(400)='';
	declare @InputDate varchar(20);
	declare @cnt int = 0;

	set @stat = N'SELECT @cnt=COUNT(*) FROM SalaryBill WHERE StaffId=@StaffId AND BelongMonth=@BelongMonth';
	set @param = N'@StaffId int @BelongMonth varchar(15)，@cnt int output';
	exec sp_executesql @stat,@param,@StaffId, @BelongMonth, @cnt output;

	if @cnt > 0
	begin
		return 1;
	end

	set @InputDate = CONVERT(varchar(100), GETDATE(), 20);

	set @BillNumber = @StaffNumber + '_' + CONVERT(varchar(100), GETDATE(), 112);
	set @vlaue=' VALUES(''' + @BillNumber + ''',' + cast(@StaffId as varchar)+ ',''' + cast(@PostSalary as varchar) + ''',''' + cast(@PerformanceSalary as varchar) + ''',''' + cast(@BenefitSalary as varchar) +''','''
		+ cast(@AttendanceSalary as varchar) + ''',''' + cast(@SenioritySalary as varchar) + ''',''' + cast(@ReissueSalary as varchar) + ''',''' + cast(@SalaryTotal as varchar) + ''','''
		+ @BelongMonth + ''',''' + @DateBegin + ''',''' + @DateEnd + ''',''' + @InputStaffNumber + ''',''' + @InputDate + ''')';

	set @stat = 'INSERT SalaryBill(BillNumber,StaffId,PostSalary,PerformanceSalary,BenefitSalary, AttendanceSalary, SenioritySalary, ReissueSalary,SalaryTotal,BelongMonth,DateBegin,DateEnd,InputStaffNumber,InputDate)' + @vlaue;

	--print(@stat)
	exec(@stat)
	return 0;
END


go
drop procedure PR_SalaryBill_Update
go
create procedure PR_SalaryBill_Update
@BillNumber varchar(30),
@PostSalary int = 0,
@PerformanceSalary int = 0,
@BenefitSalary int = 0,
@AttendanceSalary int = 0,
@SenioritySalary int = 0,
@ReissueSalary int =0,
@SalaryTotal int = 0,
@InputStaffNumber varchar(30)
as
BEGIN
	declare @stat varchar(1000)= '';
	declare @vlaue varchar(400)='';
	declare @InputDate varchar(20);

	set @InputDate = CONVERT(varchar(100), GETDATE(), 20);

	set @stat = 'UPDATE SalaryBill SET PostSalary=''' + cast(@PostSalary as varchar) + ''',PerformanceSalary=''' + cast(@PerformanceSalary as varchar) + ''',BenefitSalary=''' + cast(@BenefitSalary as varchar)
		 + ''',AttendanceSalary='''+ cast(@AttendanceSalary as varchar) + ''',SenioritySalary=''' + cast(@SenioritySalary as varchar) + ''',ReissueSalary='''
		 + cast(@ReissueSalary as varchar) + ''',SalaryTotal=''' + cast(@SalaryTotal as varchar) + ''',InputStaffNumber=''' + @InputStaffNumber + ''' WHERE BillNumber=''' + @BillNumber + '';

	print(@stat)
	exec(@stat)
	return 0;
END


go
drop procedure PR_SalaryBill_GetAll
go
create procedure PR_SalaryBill_GetAll
@condition varchar(200) = null
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'select PersonName,StaffNumber,PostSalary,PerformanceSalary,BenefitSalary, AttendanceSalary, SenioritySalary, '
		+ 'ReissueSalary,SalaryTotal,BelongMonth from VIEW_SalaryBill_Query where 1=1';
	if @condition is not null
	begin
		set @stat = @stat + @condition;
	end
	print(@stat)
	exec(@stat)
	return 0;
END


go
drop procedure PR_Department_Add
go
create procedure PR_Department_Add
@Name varchar(30),
@Code varchar(30),
@ParentId int = 0
as
BEGIN
	declare @stat varchar(1000)= '';
	declare @vlaue varchar(400)='';

	--set @vlaue=' VALUES(''' + @Name + ''',''' + @Code + ''',''' + cast(@ParentId as varchar) + '';
	set @vlaue=' VALUES(''' + @Name + ''',''' + @Code + ''',' + cast(@ParentId as varchar) + ')';
	;
	set @stat = 'INSERT DepartmentList(Name,Code,ParentID)' + @vlaue;

	--print(@stat)
	exec(@stat)
	return 0;
END



go
drop procedure PR_Department_Update
go
create procedure PR_Department_Update
@Id int,
@Name varchar(30),
@Code varchar(30),
@ParentId int = 0
as
BEGIN
	declare @stat varchar(1000)= '';
	declare @vlaue varchar(400)='';


	set @stat = 'UPDATE DepartmentList SET Name=''' + @Name + ''',Code=''' + @Code + ''',ParentID=' + cast(@ParentId as varchar) + ' WHERE Id=' + cast(@Id as varchar);

	print(@stat)
	exec(@stat)
	return 0;
END


go
drop procedure PR_Department_GetAll
go
create procedure PR_Department_GetAll
as
BEGIN
	declare @stat varchar(200)= '';

	set @stat = 'select Id,Name,Code,ParentID from DepartmentList';
	
	print(@stat)
	exec(@stat)
	return 0;
END

go
drop procedure PR_Department_Delete
go
create procedure PR_Department_Delete
@Id int
as
BEGIN
	declare @stat nvarchar(1000)= '';
	declare @param nvarchar(400)='';
	declare @num int = 0;

	set @stat = 'SELECT @num=COUNT(*) FROM DepartmentList WHERE ParentId=@Id';
    set @param = '@Id int,@num int output';

	execute sp_executesql @stat,@param,@Id=@Id, @num=@num output
	if @num > 0
	begin
		return 0x00000010
	end

	set @stat = 'DELETE FROM DepartmentList WHERE Id=@Id';
    execute sp_executesql @stat,N'@Id int',@Id=@Id
	
	return 0
END


go
drop procedure PR_TeacherList_Add
go
create procedure PR_TeacherList_Add
@Id int,
@Remark varchar(100) = ''
as
BEGIN
	declare @stat varchar(1000)= '';
	declare @vlaue varchar(400)='';

	set @vlaue=' VALUES(' + cast(@Id as varchar(20))   + ',''' + @Remark + ''')';
	;
	set @stat = 'INSERT TeacherList(Id,Remark)' + @vlaue;

	--print(@stat)
	exec(@stat)
	return 0;
END



go
drop procedure PR_TeacherList_GetAll
go
create procedure PR_TeacherList_GetAll
as
BEGIN
	declare @stat varchar(1000)= '';

	set @stat = 'SELECT TeacherList.Id,StaffList.StaffNumber,Name FROM TeacherList LEFT JOIN StaffList ON StaffList.Id=TeacherList.Id';
	
	print(@stat)
	exec(@stat)
	return 0;
END

go
drop procedure PR_TeacherList_Delete
go
create procedure PR_TeacherList_Delete
@StaffNumber varchar(30)
as
BEGIN
	declare @stat nvarchar(100)= '';

	set @stat = 'DELETE FROM TeacherList WHERE StaffNumber=''' + @StaffNumber + '''';
    exec(@stat)
	
	return 0
END


------------------------ 客户相关

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
	
	set @stat = 'select Id,Name,Phone,IdCard from CustomerList right join OrderList on CustomerList.Id=OrderList.CustomerId WHERE OrderList.Status=''正常''';
	print(@stat)
	exec(@stat)
END


------------------ 订单相关

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

---------- 课程相关

go
drop procedure PR_Lesson_Add
go
create procedure PR_Lesson_Add
@Name varchar(30),
@Price float,
@TimeLength float,
@Discription varchar(100) = ''
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'INSERT LessonList(Name,Price,TimeLength,Description) VALUES(@Name,@Price,@TimeLength, @Description)';
	set @param = N'@Name varchar(30),@Price float,@TimeLength float, @Description varchar(100)';
	exec sp_executesql @stat,@param,@Name,@Price,@TimeLength, @Discription

END

go
drop procedure PR_Lesson_Update
go
create procedure PR_Lesson_Update
@Id int,
@Name varchar(30),
@Price float,
@TimeLength float,
@Discription varchar(100) = ''
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'UPDATE LessonList SET Name=@Name,Price=@Price,TimeLength=@TimeLength,Description=@Description WHERE Id=@Id';
	set @param = N'@Id int,@Name varchar(30),@Price float,@TimeLength float, @Description varchar(100)';
	exec sp_executesql @stat,@param,@Id,@Name,@Price,@TimeLength, @Discription

END

go
drop procedure PR_Lesson_Delete
go
create procedure PR_Lesson_Delete
@Id int
as
BEGIN
	declare @stat nvarchar(200)= '';
	declare @param nvarchar(200)= '';


	set @stat = N'DELETE FROM LessonList WHERE Id=@Id';
	set @param = N'@Id int';
	exec sp_executesql @stat,@param,@Id

END

go
drop procedure PR_Lesson_GetAll
go
create procedure PR_Lesson_GetAll
as
BEGIN
	declare @stat nvarchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Price,Description from LessonList';
	print(@stat)
	exec(@stat)
END


