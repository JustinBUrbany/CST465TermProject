using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPTermProject.Models
{
    public class ContactModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [DisplayName("PhoneNumber")]
        [Required(ErrorMessage = "PhoneNumber is Required")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [DisplayName("Message")]
        [Required(ErrorMessage = "Message is Required")]
        public string Message { get; set; }
    }
}
