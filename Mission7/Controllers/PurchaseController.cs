using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission7.Controllers
{
    public class PurchaseController : Controller
    {
        private PurchaseRepository repo { get; set; }
        private ShoppingCart shoppingCart { get; set; }

        public PurchaseController(PurchaseRepository temp, ShoppingCart sc)
        {
            repo = temp;
            shoppingCart = sc;
        }

        [HttpGet]
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View(new Purchase());
        }

        [HttpPost]

        public IActionResult Checkout(Purchase purchase)
        {
            //if there are no items in the cart, return error
            if (shoppingCart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry your cart is empty!");
            }
            //if there are items in the basket, it will go get the items in the cart and at them to the lines 
            if (ModelState.IsValid)
            {
                purchase.Lines = shoppingCart.Items.ToArray();
                repo.SavePurchase(purchase);
                shoppingCart.ClearBasket();

                return RedirectToPage("/PurchaseComplete");

            }
            else
                return View();
        }
    }
}
