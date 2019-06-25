using System;
using System.Collections.Generic;
using System.Text;

namespace BikeForLife.Dal
{
    class MemberRepository
    {
        public List<BikeRoute> GetAll()
        {
            string sql = "SELECT * FROM BikeRoutes";
            DataTable dataTable = ExecuteQuery(sql);
            if (dataTable == null)
                throw new InvalidOperationException($"DataTable was null. SQL string is: {sql}");
            return HandleData(dataTable);
        }

        private List<BikeRoute> HandleData(DataTable dataTable)
        {
            if (dataTable == null)
                return null;

            List<BikeRoute> routes = new List<BikeRoute>();

            foreach (DataRow row in dataTable.Rows)
            {
                routes.Add(new BikeRoute()
                {
                    Id = (int)row["BikeRouteId"],
                    Name = (string)row["Name"],
                    Difficulty = (Difficulty)row["Difficulty"],
                    Length = (double)row["Length"],
                    Country = (string)row["Country"],
                    City = (string)row["City"]
                });
            }
            return routes;
        }
    }
}
