using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BikeForLife.Entities
{
    public class Member
    {
        private List<Ride> rides = new List<Ride>();

        public int Id { get; set; }
        [Display(Name="Navn")]
        public string Name { get; set; }
        [Display(Name = "Tilmelding Dato")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Køreniveu")]
        public Difficulty RideLevel { get
            {
                if (rides.Count >= 5)
                {
                    return Difficulty.Normal;
                }
                else if (rides.Count >= 12 && CheckNumberOfNormalDifficulty() >= 5)
                {
                    return Difficulty.Hard;
                }
                else if (Rides.Count >= 30 && CheckNumberOfHardDifficulty() >= 10 && BeenAYear())
                {
                    return Difficulty.Expert;
                }
                else
                {
                    return Difficulty.Easy;
                }
            }
        }

        private int CheckNumberOfHardDifficulty()
        {
            throw new NotImplementedException();
        }

        private bool BeenAYear()
        {
            throw new NotImplementedException();
        }

        private int CheckNumberOfNormalDifficulty()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Ride> Rides { get => rides; }

        public bool Add(Ride ride)
        {
               
        }


    }
}
