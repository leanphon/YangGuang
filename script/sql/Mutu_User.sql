use MutuERP
go

-- Lesson
drop table RoleList         
create table RoleList(
 RoleId int not null primary key identity(1,1),
 RoleName varchar(15) not null,
 Description varchar(30) default ''
);

INSERT RoleList(RoleName) VALUES('��������Ա','')
INSERT RoleList(RoleName) VALUES('����Ա','')
INSERT RoleList(RoleName) VALUES('н��רԱ','')
INSERT RoleList(RoleName) VALUES('ҵ�� רԱ','')

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
