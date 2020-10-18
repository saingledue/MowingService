CREATE PROCEDURE [dbo].[spPortfolio_GetPortfolioByPortfolioId]
	@PortfolioId int

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [PortfolioId], [EmployeeId], [WorkPic]
	FROM dbo.[Portfolio]
	WHERE PortfolioId = @PortfolioId

END
