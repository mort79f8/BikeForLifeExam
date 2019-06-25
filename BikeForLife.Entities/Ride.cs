using System;
using System.Collections.Generic;
using System.Text;

namespace BikeForLife.Entities
{
    public class Ride
    {
        public int Id { get; set; }
        public BikeRoute Route { get; set; }
        public Member Member { get; set; }
        public DateTime RideDate { get; set; }

        public (bool IsValid, string errMessage) IsvalidRide()
        {
            throw new NotImplementedException();
        }
    }
}
