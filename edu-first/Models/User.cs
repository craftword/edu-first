﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace edu_first.Models
{
    public class User : IdentityUser
    {

        [Required]
        [MaxLength(15, ErrorMessage ="First name cannot be more than 15 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Last name cannot be more than 15 characters")]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "Address cannot be more than 200 characters")]
        public string Address { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<News> NewsDetails { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }


    }
}
