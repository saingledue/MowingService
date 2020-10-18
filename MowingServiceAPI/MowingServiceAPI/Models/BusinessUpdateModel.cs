using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MowingServiceAPI.Models
{
    public class BusinessUpdateModel
    {
        public int BusinessId { get; set; }

        
        public string Location { get; set; }

        
        public int OpenHours { get; set; }

        public int CloseHours { get; set; }
    }
}
