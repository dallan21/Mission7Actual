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

        //pulling in the information in the purchase repository (purhcase info and book info)
        //also pulling in the Shopping cart info
        public PurchaseController(PurchaseRepository temp, ShoppingCart sc)
        {
            repo = temp;
            shoppingCart = sc;
        }

        [HttpGet]
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            //return a new instance of a purchase
            return View(new Purchase());
        }

        [HttpPost]

        //going to receive a purchase object and name it purchase
        public IActionResult Checkout(Purchase purchase)
        {
            if (shoppingCart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your shopping cart is empty!");
            }

            //if there is stuff in the cart
            if (ModelState.IsValid)
            {
                //go to the items in the shopping cart and add those to the lines 
                purchase.Lines = shoppingCart.Items.ToArray();
                //Save the changes that are passed in by the purchase line
                repo.SavePurchase(purchase);
                //After, we want to clear the cart so we can make a new cart 
                shoppingCart.ClearBasket();

                return RedirectToPage("/PurchaseComplete");
            }
            else
            {
                //if nothing is there, just return them to the page
                return View();
            }
        }
    }
}
