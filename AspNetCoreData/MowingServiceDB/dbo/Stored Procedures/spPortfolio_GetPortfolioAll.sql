CREATE PROCEDURE [dbo].[spPortfolio_GetPortfolioAll]

AS
	
BEGIN

	SET NOCOUNT ON;

	SELECT [PortfolioId], [EmployeeId], [WorkPic] 
	FROM [Portfolio]

END
