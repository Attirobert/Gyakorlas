USE [MasterDatailsDB]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type in (N'U'))
DROP TABLE [dbo].[Position]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
DROP TABLE [dbo].[Employee]
GO
/****** Object:  Table [dbo].[EmpCompany]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompany]') AND type in (N'U'))
DROP TABLE [dbo].[EmpCompany]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewByID]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeViewByID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmployeeViewByID]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewAll]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeViewAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmployeeViewAll]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeDelete]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmployeeDelete]
GO
/****** Object:  StoredProcedure [dbo].[EmployeeAddOrEdit]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeAddOrEdit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmployeeAddOrEdit]
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyDelete]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompanyDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmpCompanyDelete]
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyAddOrEdit]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompanyAddOrEdit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EmpCompanyAddOrEdit]
GO
USE [master]
GO
/****** Object:  Database [MasterDatailsDB]    Script Date: 12/22/2017 3:21:42 PM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'MasterDatailsDB')
DROP DATABASE [MasterDatailsDB]
GO
/****** Object:  Database [MasterDatailsDB]    Script Date: 12/22/2017 3:21:42 PM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MasterDatailsDB')
BEGIN
CREATE DATABASE [MasterDatailsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasterDatailsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLE2012\MSSQL\DATA\MasterDatailsDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MasterDatailsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLE2012\MSSQL\DATA\MasterDatailsDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [MasterDatailsDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasterDatailsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasterDatailsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MasterDatailsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasterDatailsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasterDatailsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasterDatailsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasterDatailsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MasterDatailsDB] SET  MULTI_USER 
GO
ALTER DATABASE [MasterDatailsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasterDatailsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasterDatailsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasterDatailsDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MasterDatailsDB]
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyAddOrEdit]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompanyAddOrEdit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmpCompanyAddOrEdit]
@EmpCmpID int,
@EmpID int,
@CompanyName varchar(100),
@PositionID int,
@ExpYear int
AS
	--Insert
	IF @EmpCmpID = 0
		INSERT INTO EmpCompany(EmpID,CompanyName,PositionID,ExpYear)
		VALUES (@EmpID,@CompanyName,@PositionID,@ExpYear)
	--Update
	ELSE
		UPDATE EmpCompany
		SET
			EmpID=@EmpID,
			CompanyName=@CompanyName,
			PositionID=@PositionID,
			ExpYear=@ExpYear
		WHERE EmpCmpID = @EmpCmpID' 
END
GO
/****** Object:  StoredProcedure [dbo].[EmpCompanyDelete]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompanyDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmpCompanyDelete]
@EmpCmpID int
AS
	DELETE FROM EmpCompany
	WHERE EmpCmpID = @EmpCmpID' 
END
GO
/****** Object:  StoredProcedure [dbo].[EmployeeAddOrEdit]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeAddOrEdit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmployeeAddOrEdit]
@EmpID int,
@EmpCode varchar(50),
@EmpName varchar(100),
@PositionID int,
@DOB date,
@Gender varchar(20),
@State varchar(15),
@ImagePath varchar(250)
AS

	--Insert
	IF @EmpID = 0 BEGIN
		INSERT INTO Employee(EmpCode,EmpName,PositionID,DOB,Gender,State,ImagePath)
		VALUES (@EmpCode,@EmpName,@PositionID,@DOB,@Gender,@State,@ImagePath)

		SELECT SCOPE_IDENTITY();

		END
	--Update
	ELSE BEGIN
		UPDATE Employee
		SET
			EmpCode=@EmpCode,
			EmpName=@EmpName,
			PositionID=@PositionID,
			DOB=@DOB,
			Gender=@Gender,
			State=@State,
			ImagePath=@ImagePath
		WHERE EmpID=@EmpID

		SELECT @EmpID;
		END' 
END
GO
/****** Object:  StoredProcedure [dbo].[EmployeeDelete]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeDelete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmployeeDelete]
@EmpID int
AS
	--Master
	DELETE FROM Employee
	WHERE EmpID = @EmpID
	--Details
	DELETE FROM EmpCompany
	WHERE EmpID = @EmpID' 
END
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewAll]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeViewAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmployeeViewAll]
AS
SELECT E.EmpID,E.EmpCode,E.EmpName,P.Position,E.DOB,E.State
FROM Employee E INNER JOIN Position P
					ON E.PositionID = P.PositionID' 
END
GO
/****** Object:  StoredProcedure [dbo].[EmployeeViewByID]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeeViewByID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[EmployeeViewByID]
@EmpID int
AS
	--Master
	SELECT *
	FROM Employee
	WHERE EmpID = @EmpID
	--Details
	SELECT *
	FROM EmpCompany
	WHERE EmpID = @EmpID' 
END
GO
/****** Object:  Table [dbo].[EmpCompany]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpCompany]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EmpCompany](
	[EmpCmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpID] [int] NULL,
	[CompanyName] [varchar](100) NULL,
	[PositionID] [int] NULL,
	[ExpYear] [int] NULL,
 CONSTRAINT [PK_EmpCompany] PRIMARY KEY CLUSTERED 
(
	[EmpCmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[EmpCode] [varchar](50) NULL,
	[EmpName] [varchar](100) NULL,
	[PositionID] [int] NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](20) NULL,
	[State] [varchar](15) NULL,
	[ImagePath] [varchar](250) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Position]    Script Date: 12/22/2017 3:21:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Position]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Position](
	[PositionID] [int] NOT NULL,
	[Position] [varchar](50) NULL,
 CONSTRAINT [PK_Poistion] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [MasterDatailsDB] SET  READ_WRITE 
GO
