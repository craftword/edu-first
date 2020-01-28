using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace edu_first.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<News> NewsDetails { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }


    }
}
