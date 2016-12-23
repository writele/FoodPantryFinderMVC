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
        }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}