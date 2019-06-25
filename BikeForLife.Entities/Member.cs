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
                if (rides.Count >= 30 && CheckNumberOfHardDifficulty() >= 10 && BeenAYear())
                {
                    return Difficulty.Expert;
                }
                else if (rides.Count >= 12 && CheckNumberOfNormalDifficulty() >= 5)
                {
                    return Difficulty.Hard;
                }
                else if (rides.Count >= 5)
                {
                    return Difficulty.Normal;
                }
                else
                {
                    return Difficulty.Easy;
                }
            }
        }
        public IReadOnlyList<Ride> Rides { get => rides.AsReadOnly(); }

        private int CheckNumberOfHardDifficulty()
        {
            int numberOfHard = 0;
            foreach (var ride in rides)
            {
                if (ride.Route.Difficulty == Difficulty.Hard)
                {
                    numberOfHard++;
                }
            }
            return numberOfHard;
        }
        private int CheckNumberOfNormalDifficulty()
        {
            int numberOfNormal = 0;
            foreach (var ride in rides)
            {
                if (ride.Route.Difficulty == Difficulty.Normal)
                {
                    numberOfNormal++;
                }
            }
            return numberOfNormal;
        }
        private bool BeenAYear()
        {
            TimeSpan time = DateTime.Today - EnrollmentDate.Date;
            if (time.Days >= 365)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Add(Ride ride)
        {
            if (ride.Route.Difficulty <= RideLevel)
            {
                rides.Add(ride);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
