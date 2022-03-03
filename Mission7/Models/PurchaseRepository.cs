using System;
using System.Linq;

namespace Mission7.Models
{
    //this is going to be a template to build the info for each individual repository 
    public interface PurchaseRepository
    {
       IQueryable<Purchase> Purchases { get; }

        void SavePurchase(Purchase purchase);
    }
}
