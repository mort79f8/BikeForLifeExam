using System;
using System.ComponentModel.DataAnnotations;

namespace BikeForLife.Entities
{
    public class BikeRoute
    {
        public int Id { get; set; }
        [Display(Name="Navn")]
        public string Name { get; set; }
        [Display(Name = "Længde")]
        public double Length { get; set; }
        [Display(Name = "Sværhedsgrad")]
        public Difficulty Difficulty { get; set; }
        [Display(Name = "Land")]
        public string Country { get; set; }
        [Display(Name = "By")]
        public string City { get; set; }
    }
}
