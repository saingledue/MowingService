CREATE PROCEDURE [dbo].[spPortfolio_UpdatePortfolio]
	@PortfolioId INT,
	@EmployeeId INT,
	@WorkPic BINARY

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE dbo.[Portfolio]
		SET [EmployeeId] = @EmployeeId,
			[WorkPic] = @WorkPic
		WHERE [PortfolioId] = @PortfolioId

END
