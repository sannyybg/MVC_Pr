using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_PersonManagment.Service.Models
{
    public class PersonServiceModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Age { get; set; }

        public string Email { get; set; }
    }
}
