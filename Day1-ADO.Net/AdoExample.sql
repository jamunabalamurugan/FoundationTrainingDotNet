USE [master]
GO
/****** Object:  Database [dbADOExample]    Script Date: 9/1/2021 4:13:23 PM ******/
CREATE DATABASE [dbADOExample]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbADOExample', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HBSQLEXPRESS\MSSQL\DATA\dbADOExample.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbADOExample_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.HBSQLEXPRESS\MSSQL\DATA\dbADOExample_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbADOExample] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbADOExample].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbADOExample] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbADOExample] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbADOExample] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbADOExample] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbADOExample] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbADOExample] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [dbADOExample] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbADOExample] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbADOExample] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbADOExample] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbADOExample] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbADOExample] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbADOExample] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbADOExample] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbADOExample] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbADOExample] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbADOExample] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbADOExample] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbADOExample] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbADOExample] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbADOExample] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbADOExample] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbADOExample] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbADOExample] SET  MULTI_USER 
GO
ALTER DATABASE [dbADOExample] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbADOExample] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbADOExample] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbADOExample] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbADOExample] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbADOExample] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbADOExample] SET QUERY_STORE = OFF
GO
USE [dbADOExample]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 9/1/2021 4:13:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CID] [varchar](10) NOT NULL,
	[CName] [varchar](30) NULL,
	[CDuration] [varchar](20) NULL,
	[CFees] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enroll]    Script Date: 9/1/2021 4:13:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enroll](
	[StudentId] [varchar](10) NOT NULL,
	[CourseId] [varchar](10) NOT NULL,
	[DateOfEnroll] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 9/1/2021 4:13:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [varchar](10) NOT NULL,
	[Name] [varchar](30) NULL,
	[DateOfBirth] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCourse]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourse](
	[id] [int] IDENTITY(101,1) NOT NULL,
	[name] [varchar](20) NULL,
	[fees] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDummy]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDummy](
	[f1] [int] NOT NULL,
	[pin] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[f1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStudent]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudent](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](20) NULL,
	[age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Course] ([CID], [CName], [CDuration], [CFees]) VALUES (N'CSHARP', N'CSHARP Fundmentals', N'20', 2000.0000)
INSERT [dbo].[Course] ([CID], [CName], [CDuration], [CFees]) VALUES (N'HTML', N'WEB', N'30', 1000.0000)
GO
INSERT [dbo].[Enroll] ([StudentId], [CourseId], [DateOfEnroll]) VALUES (N'KAVIN', N'CSHARP', CAST(N'2021-02-05' AS Date))
INSERT [dbo].[Enroll] ([StudentId], [CourseId], [DateOfEnroll]) VALUES (N'KAVIN', N'HTML', CAST(N'2021-05-06' AS Date))
GO
INSERT [dbo].[Student] ([ID], [Name], [DateOfBirth]) VALUES (N'KAVIN', N'KAVIN KUMAR', CAST(N'2011-01-06' AS Date))
GO
SET IDENTITY_INSERT [dbo].[tblCourse] ON 

INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (101, N'Java', 10000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (102, N'Dotnet', 10000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (103, N'SQL', 5000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (104, N'Java', 2000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (105, N'Java', 10000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (106, N'Dotnet', 10000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (107, N'EntityFramework', 100000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (108, N'HTML', 0)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (109, N'MVC.NET', 300000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (111, N'Angular', 400000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (112, N'HTML ADO.Net', 60000)
INSERT [dbo].[tblCourse] ([id], [name], [fees]) VALUES (113, N'StoreProc ADO.Net', 100000)
SET IDENTITY_INSERT [dbo].[tblCourse] OFF
GO
INSERT [dbo].[tblDummy] ([f1], [pin]) VALUES (20, N'Jamuna')
GO
SET IDENTITY_INSERT [dbo].[tblStudent] ON 

INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (1, N'Kavin', 21)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (2, N'Kanav', 22)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (3, N'Sumedha', 24)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (4, N'Saadhana', NULL)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (7, N'Joshitha', 21)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (8, N'Joshitha', 15)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (10, N'Banu', 21)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (11, N'Banu', 21)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (12, N'Banu', 21)
INSERT [dbo].[tblStudent] ([id], [name], [age]) VALUES (13, N'Banu', 21)
SET IDENTITY_INSERT [dbo].[tblStudent] OFF
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CID])
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[getstudentDetails]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getstudentDetails] as
begin
		select id,name, age from tblstudent
		
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteStudent]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteStudent](@sid int)
as
begin 
  delete from tblStudent where id = @sid
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteStudnet]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteStudnet](@sid int)
as
begin 
  delete from tblStudent where id = @sid
end
GO
/****** Object:  StoredProcedure [dbo].[proc_GetAllCourse]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_GetAllCourse]
as
begin
   select * from tblCourse
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertCourse]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_InsertCourse](@cname varchar(20),@cfees float)
as
begin
  Insert into tblCourse(name,fees) values(@cname,@cfees)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateStudentName]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateStudentName](@sid int,@sname varchar(20))
as
begin 
  update tblStudent set name = @sname where id = @sid
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateStudnetName]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateStudnetName](@sid int,@sname varchar(20))
as
begin 
  update tblStudent set name = @sname where id = @sid
end
GO
/****** Object:  StoredProcedure [dbo].[procCourseById]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procCourseById](@cid varchar(10)) as
begin
select * from Course where CID=@cid;
end;
GO
/****** Object:  StoredProcedure [dbo].[procEnroll]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procEnroll](@stid varchar(10),@cid varchar(10),@enrolldate date) as
begin
insert into Enroll values(@stid,@cid,@enrolldate);
end;
GO
/****** Object:  StoredProcedure [dbo].[procGetEnrollments]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procGetEnrollments](@stid varchar(10),@cid varchar(10))as
begin
select * from Student where ID=@stid;
select * from Course where CID=@cid;
end;
GO
/****** Object:  StoredProcedure [dbo].[procInsertCourse]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procInsertCourse](@cid varchar(10),@cname varchar(30),@cdur varchar(20), @cfees money) as
begin
insert into Course values(@cid,@cname,@cdur,@cfees);
end;
GO
/****** Object:  StoredProcedure [dbo].[procInsertStudent]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procInsertStudent](@stid varchar(10),@stname varchar(30),@stdob date) as
begin
insert into Student values(@stid,@stname,@stdob);
end;
GO
/****** Object:  StoredProcedure [dbo].[procStudentById]    Script Date: 9/1/2021 4:13:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procStudentById](@stid varchar(10)) as
begin
select * from Student where ID=@stid;
end;
GO
USE [master]
GO
ALTER DATABASE [dbADOExample] SET  READ_WRITE 
GO
