using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPantryFinderMVC.Models
{
    public class State
    {
        public int Id { get; set; }
        [Display(Name = "State")]
        public string Name { get; set; }
        public State()
        {
            this.Addresses = new HashSet<Address>();
            this.Cities = new HashSet<City>();
            this.Counties = new HashSet<County>();
            this.ZipCodes = new HashSet<ZipCode>();
        }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<County> Counties { get; set; }
        public virtual ICollection<ZipCode> ZipCodes { get; set; }
    }
}