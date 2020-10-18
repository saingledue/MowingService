using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class PortfolioModel
    {
        public int PortfolioId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public byte[] WorkPic { get; set; }
    }
}
