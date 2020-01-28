using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
