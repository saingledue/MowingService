using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MowingServiceAPI.Models
{
    public class EmployeeUpdateModelcs
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BusinessId { get; set; }

        public int Age { get; set; }
    }
}
