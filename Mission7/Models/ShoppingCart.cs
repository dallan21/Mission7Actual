using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Mission7.Models
{
    public class ShoppingCart
    {
        // first part declares, second instantiates
        //creating a list of shopping cart items and getting the info and setting it as value 
       public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

       //Creating a method to add a new Shopping cart item. (passing in the Book model info and creating a new variable qty
       // "virtual" allows for the method to 
       public virtual void AddItem (Book book, int qty)
        {
            //setting an instance of a shopping cart = to the bookid passed in from the book object 
            ShoppingCartItem line = Items
                .Where(x => x.Book.BookId == book.BookId)
                .FirstOrDefault();
            //if the line is empty, it will create a new instance of Shoppingcart
            //if the line has the book info in it, it will add to the quantity
            if (line == null)
            {
                Items.Add(new ShoppingCartItem
                {
                    Book = book,
                    Quantity = qty
                });

            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book book)
        {
            //go out to the list of Items, find where the Book id is = to the bookid that we are looking at and remove it 
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearBasket()
        {
            //go to the list of Items and clear it 
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

   
    //Handeling the info for each item in the cart.
    // Creating a new class "ShoppingCartItem and giving it attributes
    //"Book" is pulling from the Book class/model
    public class ShoppingCartItem
    {
        [Key]
        public int ItemID { get; set; }

        public Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
