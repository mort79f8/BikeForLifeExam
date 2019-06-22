using System;

namespace BikeForLife.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Difficulty Difficulty { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
