CREATE PROCEDURE [dbo].[spPortfolio_DeleteByPortfolioId]
	@PortfolioId int

AS
	
BEGIN
	
	SET NOCOUNT ON;

	DELETE
	FROM dbo.[Portfolio]
	WHERE PortfolioId = @PortfolioId;

END
