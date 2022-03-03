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

        public ShoppingCart shoppingCart { get; set; }
        public string ReturnUrl { get; set; }


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
            //find book that matches the id
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            //add that book to our shopping cart
            shoppingCart.AddItem(b, 1);
            //redirect back to the page 
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int BookId, string returnUrl)
        {
            //search for the book id that matches then grab the associated book 
            shoppingCart.RemoveItem(shoppingCart.Items.First(x => x.Book.BookId == BookId).Book);
            //redirect back to the returnUrl that was passed in to the object 
            return RedirectToPage(new {ReturnUrl = returnUrl});
        }
        
    }
}
