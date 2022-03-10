using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }
        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        //name
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        //address
        [Required(ErrorMessage = "Please enter an address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        //city, state, and country
        [Required(ErrorMessage = "Please enter a city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a country")]
        public string Country { get; set; }

        //This means that it is not attached to a form, for admin pages onlys
        [BindNever]
        public bool PurchaseReceived { get; set; }

    }
}
