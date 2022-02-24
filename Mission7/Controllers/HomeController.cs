using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using Mission7.Models.ViewModels;

namespace Mission7.Controllers
{
    public class HomeController : Controller
    {
        private BookListRepository repo;

        public HomeController (BookListRepository options)
        {
            repo = options;
        }
        public IActionResult Index(string bookcategory, int pageNum = 1)
        {
            //set variable to know how many books to display per page
            int pageSize = 10;

            //create a new instance of BooksViewModel
            var x = new BooksViewModel
            {
                //pull in the information of the books from the repo, order it by book title, and set up the display 10 per page
                Books = repo.Books
                .Where(b => b.Category == bookcategory || bookcategory == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                // loads up all the info from the view model
                PageInfo = new PageInfo
                {
                    TotalNumProjects = (bookcategory == null
                            ? repo.Books.Count()
                            : repo.Books.Where(c => c.Category == bookcategory).Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }


            };


            
            return View(x);
        }

      
    }
}
