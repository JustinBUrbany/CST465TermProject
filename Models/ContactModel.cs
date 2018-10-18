using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Models
{
    public class ContactModel
    {
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Display(Name ="PhoneNumber")]
        [Required(ErrorMessage = "PhoneNumber is Required")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message is Required")]
        public string Message { get; set; }
    }
}
