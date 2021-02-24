using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public class EFCongoRepository : ICongoRepository
    {
        private CongoDBContext _context;

        //Constructor
        public EFCongoRepository(CongoDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;

    }
}
