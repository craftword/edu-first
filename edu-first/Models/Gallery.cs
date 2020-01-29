using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace edu_first.Models
{
    public class Gallery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string ImagePath { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Description cannot be more than 50 characters")]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }
        public User User { get; set; }

    }
}
