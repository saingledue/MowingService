using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IEmployeeData
    {
        Task<List<EmployeeModel>> GetEmployeeAll();

        Task<int> CreateEmployee(EmployeeModel employee);

        Task<EmployeeModel> GetEmployeeByEmployeeId(int employeeId);


        Task<int> UpdateEmployeeByEmployeeId(EmployeeModel employee);

        Task<int> DeleteEmployeeByEmployeeId(int employeeId);
    }
}
