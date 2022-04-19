using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using HelperLiabrary;
using System.Device.Location;


namespace UserManagement.TaxiUserForms
{
    public partial class UserFrom : Form
    {
        private User currentUser;
        private string locationStr;
        private string dLatitude;
        private string dLong;
         void GetLocationProperty()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;
            
            if (coord.IsUnknown != true)
            {
                this.dLong = coord.Longitude.ToString();
                this.dLatitude = coord.Latitude.ToString();
            }
            else
            {
                MessageBox.Show("Sorry Invalid Coordinates");
            }
        }


        public UserFrom(User u)
        {
            InitializeComponent();
            lblWelcomeMSG.Text = "Welcome " + u.ToString();
            this.currentUser = u;

        }

        private void UserFrom_Load(object sender, EventArgs e)
        {
      
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            txtStringLocation.Focus();





        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.locationStr = txtStringLocation.Text;
            this.dLong = txtlongi.Text;
            this.dLatitude = txtLat.Text;

            currentUser.LocationIndex = locationStr;
            currentUser.Lat = dLatitude;
            currentUser.Lon = dLong;
            UserDashboard ud = new UserDashboard(currentUser);
            ud.Show();
            this.Hide();
        


        }


        private void label3_Click(object sender, EventArgs e)
        {

            txtStringLocation.Enabled = false;
            GetLocationProperty();
            txtlongi.Text = this.dLong;
            txtLat.Text = this.dLatitude;
           
           


        }
    }
}
