using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBratsk.Models {
    public class RouteItem {
        public int Id { get; set; }
        public string Path { get; set; }
        public int Distance { get; set; }
        public decimal Price { get; set; }
    }
}
