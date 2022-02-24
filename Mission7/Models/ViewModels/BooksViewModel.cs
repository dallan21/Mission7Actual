using System;
using System.Linq;

namespace Mission7.Models.ViewModels
{
    public class BooksViewModel
        //pass in the information about the books and the page information 
    {
        //information about the books
        public IQueryable<Book> Books { get; set; }
        //information about the pages
        public PageInfo PageInfo { get; set; }
    }
}
