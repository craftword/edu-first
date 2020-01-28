using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Registration
    {
        public int UserId { get; set; }
        public int SessionId { get; set; }
        public int CourseId { get; set; }
        public User User { get; set; }
        public Session Session { get; set; }
        public Course Course { get; set; }
    }
}
