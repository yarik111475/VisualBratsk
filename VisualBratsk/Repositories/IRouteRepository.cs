using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VisualBratsk.Models;

namespace VisualBratsk.Repositories {
    public interface IRouteRepository {
        IEnumerable<RouteItem> GetRotes();
        RouteItem GetRouteById(int id);
        void AddRoute(RouteItem routeItem);
        void DeleteRoute(int id);
    }
}
