using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.ViewModels
{
    public class EditRoleViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Role Name is required")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
