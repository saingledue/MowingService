﻿/*
Deployment script for MowingServiceDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MowingServiceDB"
:setvar DefaultFilePrefix "MowingServiceDB"
:setvar DefaultDataPath "C:\Users\saing\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\saing\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
USE [$(DatabaseName)];


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Business]...';


GO
CREATE TABLE [dbo].[Business] (
    [BusinessId] INT          IDENTITY (1, 1) NOT NULL,
    [Location]   VARCHAR (50) NOT NULL,
    [OpenHours]  TIME (7)     NOT NULL,
    [CloseHours] TIME (7)     NOT NULL,
    PRIMARY KEY CLUSTERED ([BusinessId] ASC)
);


GO
PRINT N'Creating [dbo].[Employee]...';


GO
CREATE TABLE [dbo].[Employee] (
    [EmployeeId] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (25) NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [BusinessId] INT           NOT NULL,
    [Age]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);


GO
PRINT N'Creating [dbo].[Portfolio]...';


GO
CREATE TABLE [dbo].[Portfolio] (
    [PortfolioId] INT             IDENTITY (1, 1) NOT NULL,
    [EmployeeId]  INT             NOT NULL,
    [WorkPic]     VARBINARY (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PortfolioId] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Employee_Business]...';


GO
ALTER TABLE [dbo].[Employee]
    ADD CONSTRAINT [FK_Employee_Business] FOREIGN KEY ([BusinessId]) REFERENCES [dbo].[Business] ([BusinessId]);


GO
PRINT N'Creating [dbo].[FK_Portfolio_Employee]...';


GO
ALTER TABLE [dbo].[Portfolio]
    ADD CONSTRAINT [FK_Portfolio_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]);


GO
PRINT N'Creating [dbo].[spBusiness_DeleteByBusinessId]...';


GO
CREATE PROCEDURE [dbo].[spBusiness_DeleteByBusinessId]
	@BusinessId int


AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Business]
	WHERE BusinessId = @BusinessId;

END
GO
PRINT N'Creating [dbo].[spBusiness_GetBusinessAll]...';


GO
CREATE PROCEDURE [dbo].[spBusiness_GetBusinessAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [BusinessId], [Location], [OpenHours], [CloseHours] 
	FROM [Business]

END
GO
PRINT N'Creating [dbo].[spBusiness_GetBusinessByBusinessId]...';


GO
CREATE PROCEDURE [dbo].[spBusiness_GetBusinessByBusinessId]
	@BusinessId int


AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [BusinessId], [Location], [OpenHours], [CloseHours]
	FROM dbo.[Business]
	WHERE BusinessId = @BusinessId

END
GO
PRINT N'Creating [dbo].[spBusiness_InsertBusiness]...';


GO
CREATE PROCEDURE [dbo].[spBusiness_InsertBusiness]
	@Location VARCHAR(50),
	@OpenHours TIME,
	@CloseHours TIME,
	@BusinessId INT output

AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Business]([Location], [OpenHours], [CloseHours])
	VALUES (@Location, @OpenHours, @CloseHours);

	SET @BusinessId = SCOPE_IDENTITY();

END
GO
PRINT N'Creating [dbo].[spBusiness_UpdateBusiness]...';


GO
CREATE PROCEDURE [dbo].[spBusiness_UpdateBusiness]
	@BusinessId INT,
	@Location VARCHAR(50),
	@OpenHours TIME,
	@CloseHours TIME

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Business]
		SET [Location] = @Location,
			[OpenHours] = @OpenHours,
			[CloseHours] = @CloseHours
		WHERE [BusinessId] = @BusinessId

END
GO
PRINT N'Creating [dbo].[spEmployee_DeleteByEmployeeId]...';


GO
CREATE PROCEDURE [dbo].[spEmployee_DeleteByEmployeeId]
	@EmployeeId int

AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Employee]
	WHERE EmployeeId = @EmployeeId;

END
GO
PRINT N'Creating [dbo].[spEmployee_GetEmployeeAll]...';


GO
CREATE PROCEDURE [dbo].[spEmployee_GetEmployeeAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [EmployeeId], [FirstName], [LastName], [BusinessId], [Age] 
	FROM [Employee]

END
GO
PRINT N'Creating [dbo].[spEmployee_GetEmployeeByEmployeeId]...';


GO
CREATE PROCEDURE [dbo].[spEmployee_GetEmployeeByEmployeeId]
	@EmployeeId int

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [EmployeeId], [FirstName], [LastName], [BusinessId], [Age]
	FROM dbo.[Employee]
	WHERE EmployeeId = @EmployeeId

END
GO
PRINT N'Creating [dbo].[spEmployee_InsertEmployee]...';


GO
CREATE PROCEDURE [dbo].[spEmployee_InsertEmployee]
	@FirstName VARCHAR (25),
	@LastName VARCHAR(50),
	@Age INT,
	@BusinessId INT,
	@EmployeeId INT output

AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Employee]([FirstName], [LastName], [Age], [BusinessId])
	VALUES (@FirstName, @LastName, @Age, @BusinessId);

	SET @EmployeeId = SCOPE_IDENTITY();

END
GO
PRINT N'Creating [dbo].[spEmployee_UpdateEmployee]...';


GO
CREATE PROCEDURE [dbo].[spEmployee_UpdateEmployee]
	@EmployeeId INT,
	@FirstName VARCHAR (25),
	@LastName VARCHAR(50),
	@BusinessId INT,
	@Age INT

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Employee]
		SET [FirstName] = @FirstName,
			[LastName] = @LastName,
			[BusinessId] = @BusinessId,
			[Age] = @Age
		WHERE [EmployeeId] = @EmployeeId

END
GO
PRINT N'Creating [dbo].[spPortfolio_DeleteByPortfolio]...';


GO
CREATE PROCEDURE [dbo].[spPortfolio_DeleteByPortfolio]
	@PortfolioId int

AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Portfolio]
	WHERE PortfolioId = @PortfolioId;

END
GO
PRINT N'Creating [dbo].[spPortfolio_GetPortfolioAll]...';


GO
CREATE PROCEDURE [dbo].[spPortfolio_GetPortfolioAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [PortfolioId], [EmployeeId], [WorkPic] 
	FROM [Portfolio]

END
GO
PRINT N'Creating [dbo].[spPortfolio_GetPortfolioByPortfolioId]...';


GO
CREATE PROCEDURE [dbo].[spPortfolio_GetPortfolioByPortfolioId]
	@PortfolioId int

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [PortfolioId], [EmployeeId], [WorkPic]
	FROM dbo.[Portfolio]
	WHERE PortfolioId = @PortfolioId

END
GO
PRINT N'Creating [dbo].[spPortfolio_InsertPortfolio]...';


GO
CREATE PROCEDURE [dbo].[spPortfolio_InsertPortfolio]
	@EmployeeId INT,
	@WorkPic BINARY,
	@PortfolioId INT output

AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Portfolio]([EmployeeId], [WorkPic])
	VALUES (@EmployeeId, @WorkPic);

	SET @PortfolioId = SCOPE_IDENTITY();

END
GO
PRINT N'Creating [dbo].[spPortfolio_UpdatePortfolio]...';


GO
CREATE PROCEDURE [dbo].[spPortfolio_UpdatePortfolio]
	@PortfolioId INT,
	@EmployeeId INT,
	@WorkPic BINARY

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Portfolio]
		SET [EmployeeId] = @EmployeeId,
			[WorkPic] = @WorkPic
		WHERE [PortfolioId] = @PortfolioId

END
GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
