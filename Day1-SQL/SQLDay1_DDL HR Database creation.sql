--Installation Steps
--https://learnsql.com/blog/how-to-install-sql-server-2017-windows/

--Click Next. You’ll now see the Database Engine Configuration settings. 
--If you’d like to have the option 
--to connect to databases through both Windows and SQL Server authentication,
--check Mixed Mode. Mixed Mode allows you connect to SQL Server 
--using both your Windows account password and 
--also a custom password you can set for SQL Server admin privileges.
--for sa password pls give newuser123

--SQL - DDL,DML,DCL

--Data Defition Language(DDL)
create database hrdb
go

use hrdb
--DDL Create,Alter,Truncate,Drop
--Creating Employee table
--Syntax for create table <tablename>()

Create table tblEmployee(
EmployeeId int not null ,
Name nvarchar(20) not null,
Location nvarchar(30),
)
go

--Alter,Adding Gender column to existing table
alter table tblEmployee 
add Gender nvarchar(10)
go
--check if the table  is altered
sp_help tblEmployee

--Alter the existing column
alter table tblEmployee 
alter column Location nvarchar(40)
go
--Drop a column
alter table tblEmployee
drop column Gender
go
--truncate,Removes all records,Structure Remains
truncate table tblEmployee
go
--Drop,Removes all records and Structure also

--This command will remove the table from databse
--It requires authority in real time
--So pls avoid using this drop
--drop table tblEmployee

--go


--sp_help in built store procedure
sp_help tblEmployee
go
--To see the records or contents of a table
select * from tblEmployee
go

select employeeid,Name from tblEmployee
go
--DML Select ,Insert,Update,Delete
--Insert records
insert tblEmployee(EmployeeId,Name,Location) 
values(1001,'Kavin','Chennai')
insert into tblEmployee
values(1002,'Kanav','Bangalore')
go
--Inserting Multiple Employee Record
insert into tblEmployee(EmployeeId,Name,Location)
values
(1003,'Harshitha','Mumbai'),
(1004,'Sumedha','Pune'),
(1005,'Saahithya','Bangalore')

insert into tblEmployee(Name,employeeId)
values('Sadhana',1006)

insert tblEmployee(employeeid,name)
values(1007,'Jamuna')

select employeeiD,name,Location
from tblEmployeeinfo
--Top
sp_rename 'tblemployeeinfo', 'tblemployee'
select top 2 * from tblEmployee

select top 50 percent * from tblEmployee

select * from tblEmployee

go
--Rename the table
sp_rename 'tblEmployee','tblEmployeeInfo'
go
select * from tblEmployeeInfo

alter table tblEmployeeInfo 
add Salary money,Hiredate Date

alter table tblEmployeeInfo
drop column Hiredate

alter table tblEmployeeInfo
add HireDate date not null

delete tblEmployeeInfo
where id=1007


create table northwind.dbo.ordersample
(
orderid int,
productid int,
unitprice money,
quantity int,
discount decimal
)
go
create table tblDepartment
(DepId int primary key,
Name nvarchar(30) not null,
dephead int unique)

alter table tblEmployeeInfo
   add DepId int references tblDepartment(Depid)

insert tblDepartment
values(1,'Admin',1)
insert tblDepartment

values(2,'Finance',2)
insert tblDepartment(Depid,name,dephead)
values(100,'HR',3)

select * from tblDepartment

drop table tblEmployeeInfo

Create table tblEmployeeInfo(Id int not null primary key ,
Name nvarchar(20) not null,
Location nvarchar(30),
DepId int foreign key 
references tblDepartment(DepId),
managerid int foreign key references tblEmployeeInfo(Id),
salary money
)


alter table tbldepartment
	add depheadid int  references tblemployeeinfo(employeeid)
insert tblEmployeeInfo(employeeid,name,location,depid)
values(1002,'Arvind','Bangalore',100)

drop table tbldepartment

drop table tblemployeeinfo

create table sampleEmployee(id int,name varchar(30))
insert sampleEmployee values(1,'Aa')
insert sampleEmployee values(2,'Ba')
insert sampleEmployee values(3,'Ca')

drop table sampleEmployee
truncate table sampleEmployee
truncate table tblEmployeeInfo
delete from sampleemployee where id=1

sp_help sampleemployee





