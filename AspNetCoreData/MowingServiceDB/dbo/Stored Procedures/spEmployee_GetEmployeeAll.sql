CREATE PROCEDURE [dbo].[spEmployee_GetEmployeeAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [EmployeeId], [FirstName], [LastName], [BusinessId], [Age] 
	FROM [Employee]

END

