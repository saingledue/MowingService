using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientWebAssembly.Models.Employee
{
    public class EmployeeModel
    {
       
        public int EmployeeId { get; set; }

        [Required]
        [DisplayName("First Name")]
        [MaxLength(25, ErrorMessage = "A first name can only be 25 characters or less.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [MaxLength(50, ErrorMessage = "A first name can only be 50 characters or less.")]
        public string LastName { get; set; }

        [Required]
        public int BusinessId { get; set; }

        [Required]
        [Range(16, 100, ErrorMessage = "You must select an age from 16 to 100.")]
        [DisplayName("Age")]
        public int Age { get; set; }
        
    }
}
