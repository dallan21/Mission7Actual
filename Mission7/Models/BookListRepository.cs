using System;
using System.Linq;

namespace Mission7.Models
{
    public interface BookListRepository
    {
        IQueryable<Book> Books { get; }
    }
}
