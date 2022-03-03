using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mission7.Infrastructure;

namespace Mission7.Models
{
    //Inherit from the shopping cart class
    public class SessionCart : ShoppingCart
    {
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            //this will go out and look at all the sessions 
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //Go look to see if there is an entry for our current Json object, if not, create a new session
            SessionCart ShoppingCart = session?.GetJson<SessionCart>("ShoppingCart") ?? new SessionCart();

            ShoppingCart.Session = session;

            return ShoppingCart;
        }

        [JsonIgnore]
        //A session allows the program to store data temporarily 
        public ISession Session { get; set; }

        //This will use the info form the parent class, but we are overriding it so we can do something a little differnt /
        // with the method 
        public override void AddItem(Book book, int qty)
        {
            base.AddItem(book, qty);
            //"this" refers to the first instance or use this specific instance
            Session.SetJson("ShoppingCart", this);
        }

        public override void RemoveItem(Book book)
        {
            base.RemoveItem(book);
            Session.SetJson("ShoppingCart", this);
        }

        public override void ClearBasket()
        {
            //remove the basket from the object 
            base.ClearBasket();
            Session.Remove("ShoppingCart");
        }
    }
}
