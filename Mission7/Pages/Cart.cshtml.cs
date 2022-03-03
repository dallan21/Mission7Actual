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

        public ShoppingCart shoppingCart { get; set; }

        public string ReturnUrl { get; set; }



        private BookListRepository repo { get; set; }

        public CartModel (BookListRepository temp, ShoppingCart sc)
        {
            repo = temp;

            shoppingCart = sc;
        }

        public void OnGet(string returnUrl)

        {
            ReturnUrl = returnUrl ?? "/";

        }


        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            shoppingCart.AddItem(b, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)

        {
            //go out to the shopping cart, find the item that matches the bookid and remove all the info for it from the cart
            shoppingCart.RemoveItem(shoppingCart.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
        
    }
}
