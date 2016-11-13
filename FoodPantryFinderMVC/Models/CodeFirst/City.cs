using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPantryFinderMVC.Models
{
    public class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        [Display(Name = "City")]
        public string Name { get; set; }
        public City()
        {
            this.Addresses = new HashSet<Address>();
        }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual State State { get; set; }
    }
}