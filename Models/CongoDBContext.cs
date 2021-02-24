using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public class CongoDBContext : DbContext
    {
        public CongoDBContext  (DbContextOptions<CongoDBContext> options) : base (options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
