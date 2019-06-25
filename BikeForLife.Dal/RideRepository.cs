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

        private List<Ride> HandleData(DataTable dataTable)
        {
            if (dataTable == null)
                return null;

            List<Ride> rides = new List<Ride>();

            foreach (DataRow row in dataTable.Rows)
            {
                rides.Add(new Ride()
                {
                    Id = (int)row["RideId"],
                    Member = (Member)row["MemberId"],
                    Route = (BikeRoute)row["BikeRouteId"],
                    RideDate = (DateTime)row["RideDate"]
                });
            }
            return rides;
        }
    }
}
