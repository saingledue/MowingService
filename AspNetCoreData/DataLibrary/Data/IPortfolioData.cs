using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IPortfolioData
    {
        Task<List<PortfolioModel>> GetPortfolio();

        Task<int> CreatePortfolio(PortfolioModel portfolio);

        Task<PortfolioModel> GetPortfolioByPortfolioId(int portfolioId);

        Task<int> UpdatePortfolioByPortfolioId(PortfolioModel portfolio);

        Task<int> DeletePortfolioByPortfolioId(int portfolioId);
    }
}
