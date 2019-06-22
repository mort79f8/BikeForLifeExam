using BikeForLife.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BikeForLife.Dal
{
    public class RouteRepository : BaseRepository
    {
        public List<Route> GetAll()
        {
            string sql = "SELECT * FROM Routes";
            DataTable dataTable = ExecuteQuery(sql);
            if (dataTable == null)
                throw new InvalidOperationException($"DataTable was null. SQL string is: {sql}");
            return HandleData(dataTable);
        }

        private List<Route> HandleData(DataTable dataTable)
        {
            if (dataTable == null)
                return null;

            List<Route> routes = new List<Route>();
            
            foreach (DataRow row in dataTable.Rows)
            {
                routes.Add(new Route()
                {
                    Id = (int)row["Id"],
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
