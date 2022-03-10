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

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
