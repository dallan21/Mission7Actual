using System;
using System.Linq;

namespace Mission7.Models
{
    public class EFBookListRepository : BookListRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookListRepository (BookstoreContext options)
        {
            context = options;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
