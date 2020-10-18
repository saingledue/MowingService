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