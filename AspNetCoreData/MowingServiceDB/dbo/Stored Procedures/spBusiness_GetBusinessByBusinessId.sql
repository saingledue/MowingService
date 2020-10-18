CREATE PROCEDURE [dbo].[spBusiness_GetBusinessByBusinessId]
	@BusinessId int


AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [BusinessId], [Location], [OpenHours], [CloseHours]
	FROM dbo.[Business]
	WHERE BusinessId = @BusinessId

END