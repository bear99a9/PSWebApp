using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {   
        [Required]
        [MinLength(2, ErrorMessage = "Name needs to be at least 2 characters long")]
        public string Name { get; set;  }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Message is too long max 250 characters")]
        public string Message { get; set; }

    }
}
