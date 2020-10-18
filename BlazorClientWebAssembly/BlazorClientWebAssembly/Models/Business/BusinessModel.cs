using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClientWebAssembly.Models.Business
{
    public class BusinessModel
    {
        public int BusinessId { get; set; }

        [Required]
        [DisplayName("City, State")]
        public string Location { get; set; }

        [Required]
        [Range(1, 24, ErrorMessage = "You must select an hour within the 24-hour day. Example: 07:00, or 08:00")]
        [DisplayName("Opening Hour")]
        public int OpenHours { get; set; }

        [Required]
        [Range(1, 24, ErrorMessage = "You must select an hour within the 24-hour day. Example: 07:00, or 08:00")]
        [DisplayName("Closing Hour")]
        public int CloseHours { get; set; }
    }
}
