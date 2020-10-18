using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class PortfolioData : IPortfolioData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public PortfolioData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<PortfolioModel>> GetPortfolio()
        {
            return _dataAccess.LoadData<PortfolioModel, dynamic>("dbo.spPortfolio_GetPortfolioAll", new { }, _connectionString.SqlConnectionName);
        }

        public async Task<int> CreatePortfolio(PortfolioModel portfolio)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("EmployeeId", portfolio.EmployeeId);
            p.Add("WorkPic", portfolio.WorkPic);
            p.Add("PortfolioId", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spPortfolio_InsertPortfolio", p, _connectionString.SqlConnectionName);

            return p.Get<int>("PortfolioId");
        }

        public async Task<PortfolioModel> GetPortfolioByPortfolioId(int portfolioId)
        {
            var recs = await _dataAccess.LoadData<PortfolioModel, dynamic>("dbo.spPortfolio_GetPortfolioByPortfolioId", new { PortfolioId = portfolioId },
                _connectionString.SqlConnectionName);
            return recs.FirstOrDefault();
        }

        public Task<int> UpdatePortfolioByPortfolioId(PortfolioModel portfolio)
        {
            return _dataAccess.SaveData("dbo.spPortfolio_UpdatePortfolio", new
            {
                PortfolioId = portfolio.PortfolioId,
                EmployeeId = portfolio.EmployeeId,
                WorkPic = portfolio.WorkPic
            }, _connectionString.SqlConnectionName);
        }

        public Task<int> DeletePortfolioByPortfolioId(int portfolioId)
        {
            return _dataAccess.SaveData("dbo.spPortfolio_DeleteByPortfolioId", new { PortfolioId = portfolioId }, _connectionString.SqlConnectionName);
        }
    }
}
