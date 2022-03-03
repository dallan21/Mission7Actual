using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class EFPurchaseRepository : PurchaseRepository

    {
        private BookstoreContext context;

        public EFPurchaseRepository (BookstoreContext temp)
        {
            context = temp;
        }

        //goes out into the list of purchases and grabs the ifo for it and then grabs then book info for the purchase
        public IQueryable<Purchase> purchases => context.purchases.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePurchase(Purchase purchase)
        {
            //goes and looks at the lines and finds the book
            context.AttachRange(purchase.Lines.Select(x => x.Book));

            if (purchase.PurchaseId == 0)
            {
                context.purchases.Add(purchase);
            }

            context.SaveChanges();
        }
    }
}
