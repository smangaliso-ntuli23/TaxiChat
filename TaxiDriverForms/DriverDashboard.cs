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

namespace UserManagement.TaxiDriverForms
{
    public partial class DriverDashboard : Form
    {
        private User currentClient;
        public DriverDashboard(User client)
        {
            InitializeComponent();
            this.currentClient = client;
          
                   }
        
       
 
        private void DriverDashboard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
