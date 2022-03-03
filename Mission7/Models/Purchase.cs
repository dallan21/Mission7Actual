using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mission7.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        //BindNever makes it so it cant be passed through the URL 
        public int PurchaseId { get; set; }

        [BindNever]

        public ICollection<ShoppingCartItem> Lines { get; set; }


        [Required(ErrorMessage = "Please enter a name:")]
        public string name { get; set;}

        [Required(ErrorMessage = "Please enter the first address line:")]
        public string addressLine1 { get; set; }

        public string addressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter a city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a country:")]
        public string Country { get; set; }

        public string Zipcode { get; set; }

    }
}
