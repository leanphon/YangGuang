use MutuERP
go

-- Lesson
drop table RoleList         
create table RoleList(
 RoleId int not null primary key identity(1,1),
 RoleName varchar(15) not null,
 Description varchar(30) default ''
);

INSERT RoleList(RoleName) VALUES('超级管理员','')
INSERT RoleList(RoleName) VALUES('管理员','')
INSERT RoleList(RoleName) VALUES('薪酬专员','')
INSERT RoleList(RoleName) VALUES('业务 专员','')

go
drop procedure PR_Lesson_GetAll
go
create procedure PR_Lesson_GetAll
as
BEGIN
	declare @stat varchar(200)= '';
	
	set @stat = 'SELECT Id,Name,Price,Description from LessonList';
	print(@stat)
	exec(@stat)
END
