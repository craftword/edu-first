using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace edu_first.Models
{
    public class Role
    {
        [Required]
        public string RoleName { get; set; }

    }
}
