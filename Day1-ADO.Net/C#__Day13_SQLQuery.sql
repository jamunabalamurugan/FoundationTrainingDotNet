create database dbADOExample

use dbADOExample

Create table tblStudent
(id int identity(1,1) primary key,
name varchar(20),
age int)

--sp_rename 'tblStudent.sage','age','COLUMN'

--sp_help tblStudent
sp_helpdb
sp_helpdb dbStudy
--To know the contents of any procedure
sp_helptext getstudentDetails 

select * from tblStudent

select min(age) from tblStudent

insert into tblStudent(name,age) 
values('Kavin',21),('Kanav',22)

insert into tblStudent(name,age) 
values('Sumedha',24)

alter procedure getstudentDetails as
begin
		select id,name, age from tblstudent
		
end

execute getstudentdetails

select * from tblstudent

select id,name,age
from tblstudent
order by name,age



create proc proc_UpdateStudentName(@sid int,@sname varchar(20))
as
begin 
  update tblStudent set name = @sname where id = @sid
end

insert into tblStudent(name,age) 
values('Saadhana',null)

create proc proc_DeleteStudent(@sid int)
as
begin 
  delete from tblStudent where id = @sid
  --update tblStudent set status="inactive" where id=@sid
end

create table tblCourse
(id int identity(101,1) primary key,
name varchar(20),
fees float)

create proc proc_InsertCourse(@cname varchar(20),@cfees float)
as
begin
  Insert into tblCourse(name,fees) values(@cname,@cfees)
end
select * from tblCourse
proc_InsertCourse 'Java',10000
proc_InsertCourse 'Dotnet',10000
proc_InsertCourse 'SQL',5000

create proc proc_GetAllCourse
as
begin
   select * from tblCourse
end

proc_GetAllCourse

select * from tblCourse
select * from tblStudent
select * from tblDummy

create table tblDummy
(f1 int primary key,
fe varchar(10))
sp_rename 'tblDummy.fe','pin','COLUMN'
grant select,Update on tblDummy to user1

Revoke Update on tblDummy to USer1

deny Update on tblDummy to USer1

