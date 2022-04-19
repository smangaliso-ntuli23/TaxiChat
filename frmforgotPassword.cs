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
namespace UserManagement
{
    public partial class frmforgotPassword : Form
    {
        public frmforgotPassword()
        {
            InitializeComponent();
        }

        private void frmforgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string idn = txtbxIDnum.Text;
            string user = txtbxUsername.Text;
            string pass = txtPass.Text;
            User u = User.ChangePassword(idn, user, pass);
          if (u  == null)
            {
                MessageBox.Show("Failed to change password");

            }
          else
            {

                MessageBox.Show("Password changed on " + u.ToString());
                frmLogin log = new frmLogin(User.ChangePassword(idn, user, pass));
                this.Hide();
                log.Show();
               
            }
             


        }
    }
}
