CREATE PROCEDURE [dbo].[spBusiness_UpdateBusiness]
	@BusinessId INT,
	@Location VARCHAR(50),
	@OpenHours INT,
	@CloseHours INT

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Business]
		SET [Location] = @Location,
			[OpenHours] = @OpenHours,
			[CloseHours] = @CloseHours
		WHERE [BusinessId] = @BusinessId

END
	


