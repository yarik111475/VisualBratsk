using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SQLite;

using VisualBratsk.Models;

namespace VisualBratsk.Repositories {
    public class SQliteRouteRepository : IRouteRepository {
        static string connectionString;
        static SQliteRouteRepository() {
            connectionString = $"Data Source={(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "base.db"))}";
        }
        public void AddRoute(RouteItem routeItem) {
            throw new NotImplementedException();
        }

        public void DeleteRoute(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<RouteItem> GetRotes() {
            List<RouteItem> routes = new List<RouteItem>();
            string command = "SELECT * FROM Routes";
            using (SQLiteConnection cnn = new SQLiteConnection(connectionString)) {
                cnn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(command, cnn)) {
                    using (SQLiteDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            RouteItem route = new RouteItem {
                                Id=int.Parse(dr["Id"].ToString()),
                                Path=(string)dr["Path"].ToString(),
                                Distance=int.Parse(dr["Distance"].ToString()),
                                Price=decimal.Parse(dr["Price"].ToString())
                            };
                            routes.Add(route);
                        }
                    }
                }
            }
            return routes;
        }

        public RouteItem GetRouteById(int id) {
            throw new NotImplementedException();
        }
    }
}
