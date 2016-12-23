using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPantryFinderMVC.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Display(Name = "Street Address")]
        public string Street { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int ZipCodeId { get; set; }
        public int CountyId { get; set; }
        public int OrganizationId { get; set; }
        public virtual City City { get; set; }
        public virtual State State { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public virtual County County { get; set; }
        [Required]
        public virtual Organization Organization { get; set; }

    }
}