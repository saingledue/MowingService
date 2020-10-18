CREATE PROCEDURE [dbo].[spEmployee_DeleteByEmployeeId]
	@EmployeeId int

AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Employee]
	WHERE EmployeeId = @EmployeeId;

END