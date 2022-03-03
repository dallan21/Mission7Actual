﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Mission7.Models
{
    public class ShoppingCart
    {
        // first part declares, second instantiates 
       public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

       public virtual void AddItem (Book book, int qty)
        {
            ShoppingCartItem line = Items
                .Where(x => x.Book.BookId == book.BookId)
                .FirstOrDefault();

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
            //go out to the book that matches the current book id that is selected 
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

   

    public class ShoppingCartItem
    {
        public int ItemID { get; set; }

        public Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
