using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using BLL;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace UserManagement.TaxiUserForms
{
    public partial class Finder : Form
    {
        private List<PointLatLng> _point;
        private User CurrentUser;
        public Finder(User u)
        {
            InitializeComponent();
            _point = new List<PointLatLng>();
            this.CurrentUser = u;
            lblUserString.Text = CurrentUser.ToString();

        }

        private void Finder_Load(object sender, EventArgs e)
        {

            gMapCntrl.MapProvider = GMapProviders.GoogleMap;
            GMapProviders.GoogleMap.ApiKey = APIKey.Key;
            gMapCntrl.Zoom = 25;
            gMapCntrl.DragButton = MouseButtons.Left;
            gMapCntrl.ShowCenter = false;
            // Map.SetPositionByKeywords("Pretoria north,South Africa");
            if ((this.CurrentUser.Lat != "None") && (this.CurrentUser.Lon != "None"))
            {
                gMapCntrl.Position = new PointLatLng(Convert.ToDouble(this.CurrentUser.Lat), Convert.ToDouble(this.CurrentUser.Lon));
            }
            else if (this.CurrentUser.LocationIndex != "None")
            {
                gMapCntrl.SetPositionByKeywords(this.CurrentUser.LocationIndex);
            }
            else
            {
                MessageBox.Show("No Location/Coordinates given");
            }


        }
         
        private void GMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblUserString_Click(object sender, EventArgs e)
        {

        }
    }
}
