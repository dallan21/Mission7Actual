using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;

namespace Mission7.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private BookListRepository repo { get; set; }

        public TypesViewComponent(BookListRepository options)
        {
            repo = options;
        }

        public IViewComponentResult Invoke()
        {
            //get the book category from the route then we can use the viewbag to pass it to default 
            ViewBag.SelectedType = RouteData?.Values["bookcategory"];


            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types);
        }


    }
}
