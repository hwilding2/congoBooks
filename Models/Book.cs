using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set;}
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"978\d{10}$")]
        public long ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }

    }
}
