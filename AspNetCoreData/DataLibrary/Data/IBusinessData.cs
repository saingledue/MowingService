using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IBusinessData
    {

        Task<List<BusinessModel>> GetBusiness();

        Task<int> CreateBusiness(BusinessModel business);

        Task<BusinessModel> GetBusinessByBusinessId(int businessId);

        Task<int> UpdateBusinessByBusinessId(BusinessModel business);

        Task<int> DeleteBusinessByBusinessId(int businessId);
    }
}
