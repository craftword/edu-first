using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegistratioId { get; set; }
        
        [Required]
        public int UserId { get; set; }

        [Required]
        public int SessionId { get; set; }

        [Required]
        public int CourseId { get; set; }
        public User User { get; set; }
        public Session Session { get; set; }
        public Course Course { get; set; }
    }
}
