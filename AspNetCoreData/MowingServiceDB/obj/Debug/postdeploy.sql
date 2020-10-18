/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (SELECT * FROM dbo.Business)
BEGIN
    INSERT INTO dbo.[Business]([Location], [OpenHours], [CloseHours])
	VALUES 
    ('Gretna Nebraska', '08:00', '17:00'),
    ('Lincoln Nebraska', '08:00', '17:00'),
    ('Omaha Nebraska', '08:00', '17:00'),
    ('Oors Nebraska', '08:00', '17:00')
END;

IF NOT EXISTS (SELECT * FROM dbo.Employee)
BEGIN
    INSERT INTO dbo.[Employee]([FirstName], [LastName], [Age], [BusinessId])
	VALUES
    ('John', 'Smith', 22, 1),
    ('Greg', 'Mcarthy', 25, 2),
    ('Hunter', 'Popo', 27, 3),
    ('Jim', 'Slim', 30, 4)
END;

IF NOT EXISTS (SELECT * FROM dbo.Portfolio)
BEGIN
    INSERT INTO dbo.[Portfolio]([EmployeeId], [WorkPic])
	VALUES
    (1, 0010),
    (2, 0010),
    (3, 1100),
    (4, 1100)
END;
GO
