CREATE PROCEDURE [dbo].[spPortfolio_InsertPortfolio]
	@EmployeeId INT,
	@WorkPic BINARY,
	@PortfolioId INT output

AS

BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.[Portfolio]([EmployeeId], [WorkPic])
	VALUES (@EmployeeId, @WorkPic);

	SET @PortfolioId = SCOPE_IDENTITY();

END
