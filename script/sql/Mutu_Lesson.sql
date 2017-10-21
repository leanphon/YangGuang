use MutuERP
go

-- Lesson
/*
drop table LessonList         
create table LessonList(
 Id int not null primary key identity(1,1),
 Name varchar(15) not null,
 Price float ,
 TimeLength float,
 Description varchar(15)
);

*/

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