
use MutuERP
go


------------------------------------------------------------ 创建表
/*
---------------------------------------------------------- 岗位表相关 --------------------------
----- 岗位层级表

drop table PostList         
create table PostList(
 Id int not null primary key identity(1,1),
 Name varchar(30) not null,
 Level varchar(15) not null,
 BaseSalary int not null default 0
);
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


---------------------------------------------------------- 绩效表相关 --------------------------
----- 绩效层级表
drop table PerformanceList         
create table PerformanceList(
 Id int not null primary key identity(1,1),
 Level varchar(15) not null,
 BaseSalary int not null default 0
);



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



---------------------------------------------------------- 效益表相关 --------------------------
----- 效益层级表
drop table BenefitList         
create table BenefitList(
 Id int not null primary key identity(1,1),
 Level varchar(15) not null,
 BaseSalary int not null default 0
);

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



---------------------------------------------------------- 员工表相关 --------------------------
----- 员工信息表
drop table StaffList
create table StaffList(
 Id int not null primary key identity(1,1),
 StaffNumber varchar(30),
 Name varchar(30) not null,
 Phone varchar(15),
 IdCard varchar(20),
 Sex varchar(1),
 Birthday varchar(15),
 BankCard varchar(20),
 DepartmentId int,
 Status varchar(10),
 DateEntry varchar(20),
 DateFormal varchar(20),
 DateLeave varchar(20),
 PostId int,
 PerformanceId int,
 BenefitId int,
 AttendanceSalary int,
 SenioritySalary int,
);






----- 员工工资组成查询视图
go
drop view VIEW_Staff_Salary_Info_Query
go
create view VIEW_Staff_Salary_Info_Query
as
select StaffList.Id as StaffId,StaffList.Name as PersonName,StaffList.StaffNumber,BenefitList.Level as BenefitLevel,BenefitList.BaseSalary as BenefitBaseSalary,
PostList.Name as PostName,PostList.Level as PostLevel,PostList.BaseSalary as PostBaseSalary,
PerformanceList.Level as PerformanceLevel,PerformanceList.BaseSalary as PerformanceBaseSalary,AttendanceSalary,SenioritySalary
from StaffList left join PostList on PostList.Id=StaffList.PostId 
left join PerformanceList on PerformanceList.Id=StaffList.PerformanceId 
left join BenefitList on BenefitList.Id=StaffList.BenefitId 
;
;



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



---------------------------------------------------------- 工资表相关 --------------------------
----- 工资表
go
drop table SalaryBill
go
create table SalaryBill(
 BillNumber varchar(30) not null primary key,
 StaffNumber varchar(30) not null,
 PostSalary int default 0,
 PerformanceSalary int default 0,
 BenefitSalary int default 0,
 AttendanceSalary int default 0,
 SenioritySalary int default 0,
 ReissueSalary int default 0,
 SalaryTotal int default 0,
 BelongMonth varchar(15),
 DateBegin varchar(15),
 DateEnd varchar(15),
 InputDate varchar(20),
 InputStaffNumber varchar(30)
);

go
drop view VIEW_SalaryBill_Query
go
create view VIEW_SalaryBill_Query
as
select StaffList.Name as PersonName,StaffList.StaffNumber,PostSalary,PerformanceSalary,BenefitSalary, 
SalaryBill.AttendanceSalary, SalaryBill.SenioritySalary, ReissueSalary,SalaryTotal,BelongMonth
from StaffList right join SalaryBill on SalaryBill.StaffId=StaffList.Id 


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




---------------------------------------------------------- 部门表相关 --------------------------
----- 部门表
drop table DepartmentList         
create table DepartmentList(
 Id int not null primary key identity(1,1),
 Name varchar(30) not null,
 Code varchar(15) not null,
 ParentID int not null default 0
);


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




drop table TeacherList         
create table TeacherList(
 Id int primary key ,
 Remark varchar(100) 
);

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
*/


---------------------------------------------------------- User表相关 --------------------------