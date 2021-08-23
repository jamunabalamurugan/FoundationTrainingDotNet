--use university;
use dbAdoExample

create table Student(ID varchar(10) primary key, Name varchar(30) , DateOfBirth date);


select * from Student;

select * from Course;

select * from Enroll;

create table Course(CID varchar(10) primary key, CName varchar(30), CDuration varchar(20), CFees money );

create table Enroll(StudentId varchar(10) references Student(ID),CourseId varchar (10) references Course(CID),DateOfEnroll date, primary key (StudentId,CourseId));

----------------------------------

create proc procInsertStudent(@stid varchar(10),@stname varchar(30),@stdob date) as
begin
insert into Student values(@stid,@stname,@stdob);
end;

---------------------------------------------

create proc procInsertCourse(@cid varchar(10),@cname varchar(30),@cdur varchar(20), @cfees money) as
begin
insert into Course values(@cid,@cname,@cdur,@cfees);
end;

----------------------------------------------------

create proc procEnroll(@stid varchar(10),@cid varchar(10),@enrolldate date) as
begin
insert into Enroll values(@stid,@cid,@enrolldate);
end;

----------------------------------------------------

create proc procStudentById(@stid varchar(10)) as
begin
select * from Student where ID=@stid;
end;

-----------------------------------------------------

create proc procCourseById(@cid varchar(10)) as
begin
select * from Course where CID=@cid;
end;

----------------------------------------------------

create proc procGetEnrollments(@stid varchar(10),@cid varchar(10))as
begin
select * from Student where ID=@stid;
select * from Course where CID=@cid;
end;