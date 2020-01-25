using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public int RegId { get; set; }
        public int CA { get; set; }
        public int Exam { get; set; }
        public int Total { get; set; }
        public char Grade { get; set; }
    }
}
