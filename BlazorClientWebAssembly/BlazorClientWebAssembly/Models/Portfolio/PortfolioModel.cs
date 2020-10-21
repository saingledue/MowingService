using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientWebAssembly.Models.Portfolio
{
    public class PortfolioModel
    {

        public int PortfolioId { get; set; }

        public int EmployeeId { get; set; }

        public byte[] WorkPic { get; set; }
    }
}
