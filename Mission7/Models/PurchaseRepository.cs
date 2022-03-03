using System;
using System.Linq;

namespace Mission7.Models
{
    //serves as a template 
    public interface PurchaseRepository
    {
        IQueryable<Purchase> purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}
