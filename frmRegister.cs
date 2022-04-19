using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == txtConfirm.Text)
            {
                try
                {
                    string idnumEntered = txtIDNum.Text;
                    string name = txtName.Text;
                    string sur = txtSur.Text;
                    string username = txtUsername.Text;
                    string password = txtConfirm.Text;

                    User u = new User(idnumEntered, name, sur, username, password);
                    
                    if(!User.RegisterNewUser(u))
                    {
                        throw new InterfaceException("Failed To Register User.");
                    }
                    else
                    {
                        frmLogin frmlog = new frmLogin(u);
                        this.Hide();
                        frmlog.Show();
                    }
                  



                }
                catch (InterfaceException err) { MessageBox.Show(err.ToString()); }
                catch (InvalidValueProvided err) { MessageBox.Show(err.ToString()); }
                catch (Exception err) { MessageBox.Show(err.ToString()); }



            }
            else
            {
                MessageBox.Show("Sorry Passwords dont match!!!");
                txtConfirm.Focus();
            }
        }
    }
}
