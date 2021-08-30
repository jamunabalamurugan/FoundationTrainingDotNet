--Various type of integrities can be used to prevent the redundancy from the data stored in a table. 
--Avoids data redundancy
--Ensures that the data in a database is accurate, consistent, and reliable
--Is broadly classified into the following categories:
--Entity integrity: Ensures that each row can be uniquely identified by an attribute called the primary key
--Domain integrity: Ensures that only a valid range of values is allowed to be stored in a column
--Referential integrity: Ensures that the values of the foreign key match the value of the corresponding primary key
--User-defined integrity: Refers to a set of rules specified by a user, which do not belong to the entity, domain, and referential integrity categories



--Additional Inputs
--Domain integrity is implemented using the CHECK constraint. 
--Entity integrity is implemented using the PRIMARY KEY constraint.
--Referential integrity is implemented using the FOREIGN KEY and PRIMARY KEY constraints.
--User-defined integrity is implemented in the form of business rules using CHECK constraints or triggers. 

--Composite Primary Key
--CREATE TABLE tblEmployeeLeave
--(
--   EmployeeID int NOT NULL , 
--   LeaveStartDate datetime NOT NULL,
--   LeaveEndDate datetime NOT NULL,
--   LeaveReason varchar(100),
--   LeaveType char(2)NOT NULL
--)

--Check
CREATE TABLE tblEmployeeLeave
(
EmployeeID int CONSTRAINT fkEmployeeID
FOREIGN KEY REFERENCES tblEmployeeInfo(employeeID), 
LeaveStartDate datetime CONSTRAINT cpkEmployeeId
PRIMARY KEY(EmployeeID, LeaveStartDate),
LeaveEndDate datetime NOT NULL,
LeaveReason varchar(100),
LeaveType char(2) CONSTRAINT chkLeave
CHECK(LeaveType IN('CL','SL','PL'))
)
select employeeid from tblemployeeinfo
insert tblEmployeeLeave
values(1001,'4/8/2020',3/8/2020,'Rain','CL')

insert tblEmployeeLeave
values(1001,'5/8/2020','4/8/2020','Rain','CL')

--Error foreign Key violation...EmployeeId must exist
insert tblEmployeeLeave(employeeid,LeaveStartDate,LeaveEndDate,LeaveReason)
values(1004,'1/16/2020','1/16/2020','Pongal Festival')

insert tblEmployeeLeave(employeeid,LeaveStartDate,LeaveReason)
values(1004,'1/13/2020','Bogi Pongal Festival')

select * from tblemployeeleave

--Default
CREATE TABLE tblEmployeeLeave
(
EmployeeID int CONSTRAINT fkEmployeeID FOREIGN KEY REFERENCES tblEmployeeInfo(employeeID), 
LeaveStartDate datetime CONSTRAINT cpkLeaveStartDate 
PRIMARY KEY(EmployeeID, LeaveStartDate),
LeaveEndDate datetime NOT NULL ,
LeaveReason varchar(100),
LeaveType char(2) CONSTRAINT chkLeave 
CHECK(LeaveType IN('CL','SL','PL'))
CONSTRAINT chkDefLeave DEFAULT 'PL'
)

alter table tblEmployeeLeave
drop constraint chkDefLeave

CREATE TABLE SampleEmployeeLeave
(
EmployeeID int FOREIGN KEY REFERENCES tblEmployeeInfo(employeeID), 
LeaveStartDate datetime PRIMARY KEY(EmployeeID, LeaveStartDate),
LeaveEndDate datetime NOT NULL,
LeaveReason varchar(100),
LeaveType char(2) CHECK(LeaveType IN('CL','SL','PL'))
DEFAULT 'PL'
)
sp_help SampleEmployeeLeave
alter table sampleemployeeleave
drop constraint DF__SampleEmp__Leave__6383C8BA
--Or
alter table tblEmployeeLeave
add constraint chkDef1Leave DEFAULT 'PL' 
for leavetype
alter table tblEmployeeLeave
add constraint chkdfLeaveEnd DEFAULT getdate()
for LeaveEndDate

insert tblEmployeeLeave(EmployeeId,LeaveStartDate,
LeaveEndDate,LeaveReason,leavetype)
values(1005,'1/13/2021','1/19/2020','Bogi Pongal','CL')


select * from tblEmployeeLeave


CREATE RULE rulType
AS @LeaveType IN ('CL', 'SL', 'PL')

sp_bindrule rulType ,'tblEmployeeLeave.LeaveType'

sp_bindrule rulType,'SampleEmployeeLeave.LeaveType'

sp_bindrule rulType,DSCRP

sp_unbindrule 'tblEmployeeLeave.LeaveType'

alter table tblEmployeeLeave
drop constraint chkDef1Leave

drop rule rulType

select * from tblEmployeeInfo

create default location_default
as 'Mumbai'

sp_bindefault location_default,'tblEmployeeInfo.Location'

sp_bindefault location_default,'northwind.employees.city'

drop type dscrp

CREATE TYPE DSCRP
FROM varchar(100) NOT NULL 



ALTER TABLE tblEmployeeLeave
ADD ClaimDetails DSCRP not null
CONSTRAINT chkDefClaim DEFAULT 'No Claim'

alter table tblEmployeeLeave
drop constraint chkDefClaim


alter table tblEmployeeLeave
drop column ClaimDetails

select  distinct location from tblEmployeeInfo

select distinct (leavereason),employeeid from tblEmployeeLeave


select * from tblEmployeeLeave
where employeeid=1001
or leavereason='Unwell'

select * from tblEmployeeLeave
where employeeid=1001
and leavereason='Unwell'

update tblEmployeeLeave
set leavereason='Unwell'
where employeeid=1001


SELECT DISTINCT Title FROM Employee
WHERE Title LIKE 'PR%'

SELECT TOP 3 * FROM tblEmployeeInfo
WHERE HireDate >= '1/1/98' AND 
HireDate <= '1/1/2020' 
ORDER BY depid ASC

sp_help tblEmployeeinfo

update tblEmployeeInfo
set depid=2,salary=40000
where employeeid=1002

SELECT * FROM tblEmployeeInfo
ORDER BY location desc,name desc



SELECT TOP 3 * FROM tblEmployeeInfo
ORDER BY location,salary desc
or
SELECT * FROM tblEmployeeInfo
ORDER BY 2,5 desc


select * from tblEmployeeInfo
insert tblEmployeeInfo
values(1002,'Kanav','Chennai',1,60000,'6/1/2011')
--Update
 update tblEmployeeInfo 
 set Salary=55000 ,
 Hiredate='2011-01-03'
 where id=1001
 --To update the primary key we should have cascade option set while creating the table
 update tblEmployeeInfo
 set id=1005
 where id=1002

 delete tblEmployeeInfo
 where id=1002

 select * from tblEmployeeInfo
 where depid=1

 update tblEmployeeInfo set Salary=48000 ,Hiredate='2011-02-04'
 where id=1002

 update tblEmployeeInfo set Salary=45000 ,Hiredate='10-04-2012'
 where id=1003

 update tblEmployeeInfo set Salary=40000 ,Hiredate='15-10-2015'
 where id=1004

  update tblEmployeeInfo set Salary=46000 ,Hiredate='15-2-2011'
 where id=1005

 update tblEmployeeInfo set Salary=25000 ,Hiredate='20-7-2016'
 where id=1006



 select * from Sample
 update Sample set Descr='Welcome'

 --Delete
 delete from tblEmployeeInfo where Emp_id=1006

 select * from tblEmployeeInfo
 
 --DQL
 select Name,hiredate from tblEmployeeInfo
 
 select Name as [Employee Name],depid 'Department Id'
 from tblEmployeeInfo

 select top 50 percent * from tblEmployeeInfo
 --Relational Operators >,<,>=,<=,= ,Logical operators and ,or, between

 --whose salary>40000
 select Name,Salary from tblEmployeeInfo 
 where Salary>40000

 --salary>=40000
 select Name,Salary from tblEmployeeInfo
 where Salary>=55000

 update tblEmployeeInfo
 set hiredate='1/1/2020'
 where id=1005

 select Name,hiredate from tblEmployeeInfo
 where hiredate <='1/1/2020'


 --Salary>=40000 and Salary<48000
 select Name,Salary from tblEmployeeInfo where Salary>=40000 and Salary<48000

 --Hiredate of employee from '2011-2-1' to '2012-04-27'
 select * from tblEmployeeInfo where Hiredate 
 between '2011-1-1' and '2012-04-27'
 --or
  select * from tblEmployeeInfo where Hiredate 
 >= '2011-1-1' and hiredate < ='2012-04-27'

 --Negative Operator Not

 select * from tblEmployeeInfo where not
 Hiredate between '2011-1-1' and '2012-04-27'

 update tblEmployeeInfo
 set location=null
 where id=1005

 --Null Values
 select Name,Location from tblEmployeeInfo 
 where Location is null
 --Not Equal
 select * from tblEmployeeInfo
 where hiredate !='1/1/2020'

 update tblEmployeeInfo set hiredate=getdate() where location='Bangalore'

 select Name,location from tblEmployeeInfo 
 where location is not null

 --Should never use = for checking null....Very Bad Errors
select Name,Location from tblEmployeeInfo 
 where Location = null

 select * from tblEmployeeInfo

 update tblEmployeeInfo set Location='Pune'
 where id =1005

 --In Operator
 --Effecient
 select Name,Location from tblEmployeeInfo
 where location in('Mumbai','Pune','Chennai')

 select Name,Location from tblEmployeeInfo
 where location = 'Mumbai' or Location='Pune'

  select Name from tblEmployeeInfo
  where Salary=55000 or Salary<30000
  
  --Returns true if both conditions satisfy
  select Name from tblEmployeeInfo
  where Salary=55000 and location='Pune'

  select * from tblEmployeeInfo
  
  select * from tblEmployeeInfo 
  where Name ='Kavin'
  or location='Pune'

  --Arthimetic Operator +,-,*,/,%

  --Adding Bouns of 1000 to all employee

  update tblEmployeeInfo set Salary=Salary+1000 
  where location ='Pune' or Location='Mumbai'

   update tblEmployeeInfo set Salary=Salary+1000 
  where location in('Pune','Mumbai','Bangalore','Delhi')

  select Name,(Salary*12) CTC 
  from tblEmployeeInfo

 
  update tblEmployeeInfo set Salary=Salary-500 
  where Salary>46000

  --Like Operator wildcard Characters Percent(%),Underscore(_),Bracket[],Caret (^)
  --%
  select Name from tblEmployeeInfo 
  where soundex(Name) 
  like soundex('Kanav')

  insert tblemployeeinfo(employeeid,name,location,hiredate)
  values(1008,'Kayann','Chennai','1/1/2020')

   insert tblemployeeinfo(employeeid,name,location,hiredate)
  values(1010,'Kennav','Chennai','1/1/2020')


   select Name from tblEmployeeInfo where Name like '%i'

    select Name from tblEmployeeInfo where Name like '%i%' 
-- Underscore(_) Search for single charater
 select Name from tblEmployeeInfo where Name like '_a%'

  select Name from tblEmployeeInfo where Name like 'M__%'
  --[]
  --display name of employee whose firstletter a or m
   select Name from tblEmployeeInfo where Name like '[Am]%'

   select * from tblDepartment where Deptname like '[HD]%R'
   --Display the name of employee firstletter starts with c ,second letter a,
   --followed 0 or more charecter

    select Name from tblEmployeeInfo where Name like 'c[a]%'
	   select Name from tblEmployeeInfo where Name like '[B]a%'
    select Name from tblEmployeeInfo where Name like '[SB]a%'
   --Caret (^)

   select Name from tblEmployeeInfo where Name like 'kav[I]n'
    select Name from tblEmployeeInfo where Name like '[^A]%'
   ---------
   create table tblDepartment(Deptid int identity(10,1)
 constraint pk_dept primary key,Deptname nvarchar(10) unique) 
   --creating FK in Employee 
   alter table tblEmployeeInfo
   add Depid int references tblDepartment(Depid)

   sp_help tblEmployeeInfo
   select * from tblEmployeeInfo
   select * from tblDepartment
   --updating Did column in EmployeeInfo table
   update tblEmployeeInfo set Depid=13 where id=1001 
   update tblEmployeeInfo set Depid=12 where id=1002
   update tblEmployeeInfo set Depid=13 where id=1003
   update tblEmployeeInfo set Depid=14 where id=1004
   update tblEmployeeInfo set Depid=15 where id=1005
   --Table 3 tbl_Performance
   create table tblPerformance (Eid int references tblEmployeeInfo(Emp_id),
    Rating float(2))

	drop table  tblPerformance

	  create table tblPerformance (Eid int ,
    Rating float(2),constraint fk_eid foreign key (Eid)
	 references tblEmployeeInfo(Emp_id))

	 --distinct
	 select distinct(location) from tblEmployeeInfo

	set dateformat dmy
	
	select * from tblemployeeleave
	
	select dateadd(m,5,getdate())

	select day(hiredate) DateofHire ,
	month(hiredate) Month,year(hiredate) Year 
	from tblEmployeeInfo

	select day('2/3/2020'),month('2/3/2020')

	insert tblEmployeeLeave
	values(1001,'31/7/2020','1/8/2020','Health','CL')

	select convert(varchar(30),hiredate,113)
	from tblEmployeeInfo
	
	--Number Function
	select CEILING(125.40)
	select CEILING(5.7+7.1)

	select FLOOR(125.50)

	declare @value int
	set @value=25
	select SQUARE(@value)

	select SQUARE(Salary) from tblEmployeeInfo
	where id=1001

	--Area of circle pr2

	select PI(),TAN(45)

	--Character function
	select LOWER(name) from tblDepartment
	
	select Upper(name) from tblDepartment

	select name, Len(name) as Length from tblDepartment
	--               (input_string,start,length)
	select SUBSTRING(Name,1,3),Name
	from tblEmployeeInfo

	--charIndex(substring,string)
	select CHARINDEX('all','Hi all!!',0)as Position
	
	select CHARINDEX('v',Name),Name  Position from tblEmployeeInfo
	--Appends the string null if the value is unknown
	select name+' '+location as [Name City] from tblEmployeeInfo
	--Leave the string empty if the value is unknown
	select CONCAT(name,location) from tblEmployeeInfo
	--
	select * from tblPerformance

	insert tblPerformance values(1001,5)

	--DateTime Function

	select GETDATE() as [Currentdate and time]

	select DATEPART(DAY,GETDATE()) as Currentdate

	select DATEPART(MONTH,GETDATE()) as CurrentMonth

	select CONVERT(date,GETDATE()) as [todays's date]

	select DATEADD(day,29,GETDATE()) as [adding 7 with todays date]

	select convert(date,dateadd(month,4,getdate()))  [adding 7 with todays date]

	select * from tblEmployeeInfo where month(hiredate) = month('1/1/2020')
	select * from tblEmployeeInfo where month(hiredate) = month(getdate())

	---
	select * from Sample
	--Wrong
	alter table Sample alter column id nvarchar(10)
	--
	sp_help Sample

	alter table sample 
	add constraint pk_id primary key(id)

	insert sample values('Pune','good'),('GOA','Fair')

	
	alter table  sample drop constraint pk_id

	
	create table Test (testid int identity(101,1) primary key,
	Tname nvarchar(20) unique,tdate date)
	
	alter table test
	add constraint chkTname unique(tname)

	alter table test
	drop constraint chkTname
	
	--Not correct
	alter table test
	drop constraint unique(Tname)


	sp_help test

	set dateformat dmy
	
	insert Test(Tname,tdate)
	values('CSharp','06-8-2020')
	select * from Test

	alter table Test 
	add primary key(tid)


	--Aggregate Functions
	--Numerical Aggregate functions
	select avg(salary) average,
	max(salary) highest,
	min(salary) lowest
	from tblEmployeeInfo

	update tblEmployeeInfo set salary=100000 where employeeid=1001

	--Non Numerical Aggregate functions
	select 
	max(hiredate) highest,
	min(hiredate) lowest
	from tblEmployeeInfo
	--count function does not consider null values if the column name is passed 
	select count(hiredate) from tblEmployeeInfo
	--count function used with * includes null values
	select count(*) from tblEmployeeInfo

	select * from tblEmployeeLeave

	select count(LeaveType)
	from tblEmployeeLeave

	select distinct(leavetype) 
	from tblEmployeeLeave

	select count(distinct(leavetype))
	from tblEmployeeLeave

	select count(*) from tblEmployeeLeave
