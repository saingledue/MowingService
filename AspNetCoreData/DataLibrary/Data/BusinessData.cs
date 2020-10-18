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
    public class BusinessData : IBusinessData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public BusinessData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<BusinessModel>> GetBusiness()
        {
            return _dataAccess.LoadData<BusinessModel, dynamic>("dbo.spBusiness_GetBusinessAll", new { }, _connectionString.SqlConnectionName);
        }

        public async Task<int> CreateBusiness(BusinessModel business)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("Location", business.Location);
            p.Add("OpenHours", business.OpenHours);
            p.Add("CloseHours", business.CloseHours);
            p.Add("BusinessId", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spBusiness_InsertBusiness", p, _connectionString.SqlConnectionName);

            return p.Get<int>("BusinessId");
        }

        public async Task<BusinessModel> GetBusinessByBusinessId(int businessId) 
        {
            var recs = await _dataAccess.LoadData<BusinessModel, dynamic>("dbo.spBusiness_GetBusinessByBusinessId", new { BusinessId = businessId },
                _connectionString.SqlConnectionName);
            return recs.FirstOrDefault();
        }

        public Task<int> UpdateBusinessByBusinessId(BusinessModel business)
        {
            return _dataAccess.SaveData("dbo.spBusiness_UpdateBusiness", new { BusinessId = business.BusinessId, 
                Location = business.Location, OpenHours = business.OpenHours, CloseHours = business.CloseHours }, _connectionString.SqlConnectionName);
        }

        public Task<int> DeleteBusinessByBusinessId(int businessId)
        {
            return _dataAccess.SaveData("dbo.spBusiness_DeleteByBusinessId", new { BusinessId = businessId }, _connectionString.SqlConnectionName);
        }
    }
}
