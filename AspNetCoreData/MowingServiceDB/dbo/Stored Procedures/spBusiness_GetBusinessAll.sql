CREATE PROCEDURE [dbo].[spBusiness_GetBusinessAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [BusinessId], [Location], [OpenHours], [CloseHours] 
	FROM [Business]

END
