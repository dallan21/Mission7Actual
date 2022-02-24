using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission7.Infrastructure;
using Mission7.Models;

namespace Mission7.Pages
{


    public class CartModel : PageModel
    {
       
        private BookListRepository repo { get; set; }

        public CartModel (BookListRepository temp)
        {
            repo = temp;
        }

        public ShoppingCart shoppingCart { get; set; }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            shoppingCart = HttpContext.Session.GetJson<ShoppingCart>("shoppingCart") ?? new ShoppingCart();

        }


        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            shoppingCart = HttpContext.Session.GetJson<ShoppingCart>("shoppingCart") ?? new ShoppingCart();
            shoppingCart.AddItem(b, 1);

            HttpContext.Session.SetJson("shoppingCart", shoppingCart);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        
    }
}
