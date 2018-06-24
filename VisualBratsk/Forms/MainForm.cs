using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VisualBratsk.Models;
using VisualBratsk.Repositories;

namespace VisualBratsk.Forms {
    public partial class MainForm : Form {
        IEnumerable<RouteItem> routes;
        IRouteRepository routeRepository;
        public MainForm() {
            InitializeComponent();
        
            routeRepository = new SQliteRouteRepository();
            routes = routeRepository.GetRotes();
            cmbxRoutes.DataSource = routes;
            cmbxRoutes.DisplayMember = "Path";
            cmbxRoutes.SelectedIndexChanged += CmbxRoutes_SelectedIndexChanged;
        }

        private void CmbxRoutes_SelectedIndexChanged(object sender, EventArgs e) {
            RouteItem route = routes.Where(r => r.Path == cmbxRoutes.Text).FirstOrDefault();
            if (route != null) {
                txtDistance.Text = route.Distance.ToString();
                txtPrice.Text = route.Price.ToString("C");
            }
        }
    }
}
