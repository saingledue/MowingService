CREATE PROCEDURE [dbo].[spBusiness_DeleteByBusinessId]
	@BusinessId int


AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Business]
	WHERE BusinessId = @BusinessId;

END
