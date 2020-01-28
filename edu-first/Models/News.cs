using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class News
    {
        public int Id { get; set; }
        public string NewsDetails { get; set; }
        public string NewsTitle { get; set; }

        public string AddedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Tag { get; set; }
        public User User { get; set; }
    }
}
