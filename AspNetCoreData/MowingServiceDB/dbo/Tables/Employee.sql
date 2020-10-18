CREATE TABLE [dbo].[Employee]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(25) NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[BusinessId] INT NOT NULL,
	[Age] INT NOT NULL, 
    CONSTRAINT [FK_Employee_Business] FOREIGN KEY ([BusinessId]) REFERENCES [Business]([BusinessId])
)