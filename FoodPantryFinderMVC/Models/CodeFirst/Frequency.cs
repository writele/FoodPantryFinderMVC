using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPantryFinderMVC.Models
{
    public class Frequency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Frequency()
        {
            this.Organizations = new HashSet<Organization>();
        }

        public virtual ICollection<Organization> Organizations { get; set; }
    }
}