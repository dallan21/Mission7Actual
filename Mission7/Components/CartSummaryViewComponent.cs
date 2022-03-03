using System;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;
namespace Mission7.Components
{
    public class CartSummaryViewComponent : ViewComponent 
    {
        private ShoppingCart shoppingCart;

        public CartSummaryViewComponent(ShoppingCart sc)
        {
            shoppingCart = sc;
        }

        public IViewComponentResult Invoke()
        {
            return View(shoppingCart);
        }
    }
}
