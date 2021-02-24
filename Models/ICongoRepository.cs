using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Models
{
    public interface ICongoRepository
    {
        IQueryable<Book> Books { get; }
    }
}
