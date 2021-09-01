sp_help students

sp_helpdb dbstudy

sp_helptext sp_databases

sp_databases

select * from students

select * 
from Students
--Creating the store procedure
alter proc getallstudents
as
begin
select name [Student Name],age [Student Age] from students
end

getallstudents

--Making changes to sp
alter procedure getstudentbyname(@startname nvarchar(30)=null)
as 
begin
--select id,name ,age from students where name like 'K%'
if(@startname is null)
select id,name,age from students
else
select id,name ,age from students where name like @startname+'%'
end

alter proc AddStudent(@name nvarchar(50),@age int)
as
begin
if(@name is not null and @age between 4 and 35)
insert students values(@name,@age)
else
print 'Name cannot be null or Age should be (4-35) only'

end

addstudent null,9
addstudent 'Saahithya',3

getstudentbyname 'S'

getstudentbyname

--Advantage of Stored Procedures
--Precompiled set of sql statements with optimised query plan which can be reused