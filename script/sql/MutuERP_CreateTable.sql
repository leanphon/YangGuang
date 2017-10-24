
----- 角色表        
create table RoleList(
 Id int not null primary key identity(1,1),
 RoleId int not null,
 RoleName varchar(15) not null,
 Description varchar(30) default ''
);

INSERT RoleList(RoleId, RoleName,Description) VALUES(1, '超级管理员','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(2, '管理员','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(3, '财务专员','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(4, '薪酬专员','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(5, '业务专员','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(6, '普通员工','')
INSERT RoleList(RoleId, RoleName,Description) VALUES(7, '客户','')

----- 用户表 
create table UserList(
 Id int not null primary key identity(1,1),
 UserName varchar(15) not null,
 Passwd  varchar(100) not null,
 StaffNumber varchar(30),
);

----- 岗位层级表         
create table PostList(
 Id int not null primary key identity(1,1),
 Name varchar(30) not null,
 Level varchar(15) not null,
 BaseSalary int not null default 0
);

----- 绩效层级表
create table PerformanceList(
 Id int not null primary key identity(1,1),
 Level varchar(15) not null,
 BaseSalary int not null default 0
);
----- 效益层级表
create table BenefitList(
 Id int not null primary key identity(1,1),
 Level varchar(15) not null,
 BaseSalary int not null default 0
);

----- 部门表
drop table DepartmentList         
create table DepartmentList(
 Id int not null primary key identity(1,1),
 Name varchar(30) not null,
 Code varchar(15) not null,
 ParentID int not null default 0
);

----- 员工信息表
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

----- 教师表
create table TeacherList(
 Id int primary key ,
 Remark varchar(100) 
);


----- 工资表
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


----- 客户表
create table CustomerList(
 Id int not null primary key identity(1,1),
 Name varchar(15) not null,
 Phone varchar(15) not null,
 IdCard varchar(20) ,
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

----- 订单表
create table OrderList(
 FlowSerial varchar(30) primary key,
 PriceTotal float,
 TradeTime varchar(30),
 CustomerId int ,
 Status varchar(10) -- 正常、退费、结束
);

----- 订单条目表
drop table ItemLessonList         
create table ItemLessonList(
 FlowSerial varchar(30),
 LessonId int,
 ItemTotal int ,
 RemainCount int default 0,
 PriceDiscount float ,
 PriceTotal float 
);
----- 课程表
create table LessonList(
 Id int not null primary key identity(1,1),
 Name varchar(15) not null,
 Price float ,
 TimeLength float,
 Description varchar(15)
);
----- 课程消费表
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





