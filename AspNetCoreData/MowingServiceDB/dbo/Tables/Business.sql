CREATE TABLE [dbo].[Business]
(
	[BusinessId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Location] VARCHAR(50) NOT NULL,
	[OpenHours] INT NOT NULL,
	[CloseHours] INT NOT NULL
)
