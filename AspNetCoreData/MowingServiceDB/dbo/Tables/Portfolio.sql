CREATE TABLE [dbo].[Portfolio]
(
	[PortfolioId] INT NOT NULL PRIMARY KEY IDENTITY,
	[EmployeeId] INT NOT NULL,
	[WorkPic] VARBINARY(MAX) NOT NULL, 
    CONSTRAINT [FK_Portfolio_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee]([EmployeeId])
)