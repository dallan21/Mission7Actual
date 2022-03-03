using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class EFPurchaseRepository : PurchaseRepository

    {

        private BookstoreContext context;
        //Needs to receive the Bookstorecontext 
        public EFPurchaseRepository (BookstoreContext temp)
        {
            //create an instance of Bookstorecontext
            context = temp;
        }

        //this is looking into the list "IQueryable<Purchase> and getting the purchase along with the info about that book 
        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(Purchase purchase)
        {
            //go get the book associated with that line (purchase)
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.Purchases.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
