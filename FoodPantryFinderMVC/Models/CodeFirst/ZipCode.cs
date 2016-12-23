using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPantryFinderMVC.Models
{
    public class ZipCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public ZipCode()
        {
            this.Addresses = new HashSet<Address>();
        }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}