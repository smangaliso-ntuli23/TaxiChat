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
using UserManagement.TaxiUserForms;

namespace UserManagement
{
    public partial class frmLogin : Form
    {
        private User user;
        public frmLogin(User use)
        {
            InitializeComponent();
            this.user = use;
            this.txtbxUsername.Text = user.Username.ToString();
            txtbxPassword.Focus();



        }
        public frmLogin()
        {
            InitializeComponent();



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;

           

            if(User.GetValidatedUser(username,password) == null)
            {
                MessageBox.Show("Sorry Invalid creditials.......");
            }else if(User.GetValidatedUser(username, password) != null)
            {
             
               UserFrom  mact = new UserFrom(User.GetValidatedUser(username, password));
                this.Hide();
                mact.Show();
               
            }



            


        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmReg = new frmRegister();
            this.Hide();
            frmReg.Show();

        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            frmforgotPassword frpf = new frmforgotPassword();
            frpf.Show();
            this.Hide();
        }
    }
}
