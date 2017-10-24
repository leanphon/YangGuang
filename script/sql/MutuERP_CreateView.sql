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


go
drop view VIEW_SalaryBill_Query
go
create view VIEW_SalaryBill_Query
as
select StaffList.Name as PersonName,StaffList.StaffNumber,PostSalary,PerformanceSalary,BenefitSalary, 
SalaryBill.AttendanceSalary, SalaryBill.SenioritySalary, ReissueSalary,SalaryTotal,BelongMonth
from StaffList right join SalaryBill on SalaryBill.StaffId=StaffList.Id 


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
drop view VIEW_Order_Query
go
create view VIEW_Order_Query
as
select FlowSerial,CustomerId,Name,PriceTotal,TradeTime
from OrderList left join CustomerList 
on OrderList.CustomerId=CustomerList.Id

go
drop view VIEW_ItemConsume_Query
go
create view VIEW_ItemConsume_Query
as
select CustomerList.Name as CustomerName,CustomerList.Phone,CustomerList.BabyName,LessonList.Name as LessonName,StaffList.Name as TeacherName,LessonConsumeHistory.ConsumeTime 
from LessonConsumeHistory left join CustomerList on LessonConsumeHistory.CustomerId=CustomerList.Id
LEFT JOIN LessonList ON LessonList.Id=LessonConsumeHistory.LessonId 
LEFT JOIN StaffList ON StaffList.Id=LessonConsumeHistory.TeacherId

