CREATE PROCEDURE [dbo].[spBusiness_InsertBusiness]
	@Location VARCHAR(50),
	@OpenHours INT,
	@CloseHours INT,
	@BusinessId INT output

AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Business]([Location], [OpenHours], [CloseHours])
	VALUES (@Location, @OpenHours, @CloseHours);

	SET @BusinessId = SCOPE_IDENTITY();

END