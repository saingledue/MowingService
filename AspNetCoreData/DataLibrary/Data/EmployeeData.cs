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
    public class EmployeeData : IEmployeeData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public EmployeeData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<EmployeeModel>> GetEmployeeAll()
        {
            return _dataAccess.LoadData<EmployeeModel, dynamic>("dbo.spEmployee_GetEmployeeAll", new { }, _connectionString.SqlConnectionName);
        }

        public async Task<int> CreateEmployee(EmployeeModel employee)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("FirstName", employee.FirstName);
            p.Add("LastName", employee.LastName);
            p.Add("BusinessId", employee.BusinessId);
            p.Add("Age", employee.Age);
            p.Add("EmployeeId", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spEmployee_InsertEmployee", p, _connectionString.SqlConnectionName);

            return p.Get<int>("EmployeeId");
        }

        public async Task<EmployeeModel> GetEmployeeByEmployeeId(int employeeId)
        {
            var recs = await _dataAccess.LoadData<EmployeeModel, dynamic>("dbo.spEmployee_GetEmployeeByEmployeeId", new { EmployeeId = employeeId },
                _connectionString.SqlConnectionName);
            return recs.FirstOrDefault();
        }

        public Task<int> UpdateEmployeeByEmployeeId(EmployeeModel employee)
        {
            return _dataAccess.SaveData("dbo.spEmployee_UpdateEmployee", new { EmployeeId = employee.EmployeeId, FirstName = employee.FirstName, LastName = employee.LastName,
            BusinessId = employee.BusinessId, Age = employee.Age}, _connectionString.SqlConnectionName);
        }
        // TODO:
        public Task<int> DeleteEmployeeByEmployeeId(int employeeId)
        {
            return _dataAccess.SaveData("dbo.spEmployee_DeleteByEmployeeId", new { EmployeeId = employeeId }, _connectionString.SqlConnectionName);
        }
    }
}
