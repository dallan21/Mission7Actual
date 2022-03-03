using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mission7.Models
{
    public class Purchase
    {
        [Key]
        //BindNever makes it so this info cannot be passed through the URL 
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<ShoppingCartItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the address line:")]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string State { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Country { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Zipcode { get; set; }
    }
}
