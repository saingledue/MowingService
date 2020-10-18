CREATE PROCEDURE [dbo].[spEmployee_GetEmployeeByEmployeeId]
	@EmployeeId int

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [EmployeeId], [FirstName], [LastName], [BusinessId], [Age]
	FROM dbo.[Employee]
	WHERE EmployeeId = @EmployeeId

END
