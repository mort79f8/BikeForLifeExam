using BikeForLife.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BikeForLife.Dal
{
    public class RideRepository : BaseRepository
    {
        public List<Ride> GetAll()
        {
            string sql = "SELECT * FROM Rides";
            DataTable dataTable = ExecuteQuery(sql);
            if (dataTable == null)
                throw new InvalidOperationException($"DataTable was null. SQL string is: {sql}");
            return HandleData(dataTable);
        }

        public List<Ride> GetRidesFromMember(Member member)
        {
            string sql = $"SELECT * FROM Rides JOIN BikeRoutes ON Rides.BikeRouteId = BikeRoutes.BikeRouteId WHERE MemberId={member.Id}";
            DataTable dataTable = ExecuteQuery(sql);

            return HandleData(dataTable, member);
        }

        private List<Ride> HandleData(DataTable dataTable, Member member = null)
        {
            if (dataTable == null)
                return null;

            List<Ride> rides = new List<Ride>();

            foreach (DataRow row in dataTable.Rows)
            {
                rides.Add(new Ride()
                {
                    Id = (int)row["RideId"],
                    Member = member,
                    Route = new BikeRoute()
                    {
                        Id = (int)row["BikeRouteId"],
                        Name = (string)row["Name"],
                        Length = (double)row["Length"],
                        Difficulty = (Difficulty)row["Difficulty"],
                        Country = (string)row["Country"],
                        City = (string)row["City"]
                    },
                    RideDate = (DateTime)row["RideDate"]
                });
            }
            return rides;
        }
    }
}
