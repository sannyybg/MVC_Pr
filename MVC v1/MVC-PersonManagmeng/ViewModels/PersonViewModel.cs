using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_PersonManagmeng.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        [MinLength(5)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Address { get; set; }

        [Required]
        public string Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
