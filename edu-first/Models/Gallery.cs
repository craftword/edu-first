using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Gallery
    {
        public int id { get; set; }
        public string ImagePath { get; set; }
        public string Category { get; set; }
        public User User { get; set; }

    }
}
