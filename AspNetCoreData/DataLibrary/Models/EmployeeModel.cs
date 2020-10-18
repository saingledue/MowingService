using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required]
        [DisplayName("First Name")]
        [MaxLength( (25), ErrorMessage = "Your first name needs to be 25 characters or less.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [MaxLength( (50), ErrorMessage = "Your last name needs to be 50 characters or less.")]
        public string LastName { get; set; }

        public int BusinessId { get; set; }

        [Required]
        [DisplayName("Age")]
        [Range(18, 70, ErrorMessage = "Your age needs to be from 18 to 70.")]
        public int Age { get; set; }
    }
}
