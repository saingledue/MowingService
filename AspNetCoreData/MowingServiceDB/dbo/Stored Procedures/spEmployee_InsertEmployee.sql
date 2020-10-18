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