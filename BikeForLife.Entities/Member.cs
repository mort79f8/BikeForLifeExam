using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BikeForLife.Entities
{
    public class Member
    {
        private List<Ride> rides;
        public int Id { get; set; }
        [Display(Name="Navn")]
        public string Name { get; set; }
        [Display(Name = "Tilmelding Dato")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Køreniveu")]
        public Difficulty RideLevel { get; }
        public IReadOnlyList<Ride> Rides { get; }


        public bool Add(Ride ride)
        {
            throw new NotImplementedException();
        }
    }
}
