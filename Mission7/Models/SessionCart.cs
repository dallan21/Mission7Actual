using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Mission7.Infrastructure;

namespace Mission7.Models
{
    public class SessionCart : ShoppingCart
    {

        public static ShoppingCart GetShoppingCart(IServiceProvider service)
        {
            //go out and look at all the sessions and pull the session info 
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            //check if there is a session, if so, use it. If not, create a new one 
            SessionCart shoppingCart = session?.GetJson<SessionCart>("ShoppingCart") ?? new SessionCart();

            shoppingCart.Session = session;

            return shoppingCart;
        }

        [JsonIgnore]
        //the current time that you are on the page. It will temporarily save your data 
        public ISession Session { get; set; }

        public override void AddItem(Book book, int qty)
        {
            base.AddItem(book, qty);
            //"this" refers to the current info in the session
            Session.SetJson("ShoppingCart", this);
        }

        public override void RemoveItem(Book book)
        {
            base.RemoveItem(book);
            Session.SetJson("ShoppingCart", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.SetJson("ShoppingCart", this);
        }

    }
}
