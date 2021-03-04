using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    //Set up model for each Book
    //Need to represent one-to-many relationship with Category in future, probably with List type--currently, I've simply normalized the data itself in order to keep it as a string.
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthFirstName { get; set; }
        [Required]
        public string AuthLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"978\d{10}$")]
        public long ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int NumPages { get; set; }
    }
}
