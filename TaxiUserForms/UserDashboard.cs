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
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using HelperLiabrary;


namespace UserManagement.TaxiUserForms
{
    public partial class UserDashboard : Form
    {
        private User currentClient;
        private List<User> lstUsers = new List<User>(); 
        public UserDashboard(User client)
        {
            InitializeComponent();
            this.currentClient = client;
            NameOfUser.Text = currentClient.Username;


        }

        
        Socket clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void UserDashboard_Load(object sender, EventArgs e)
        {
          
            clientsocket.Connect(new IPEndPoint(IPAddress.Loopback, 3128));
            currentClient.Clientsocket = clientsocket;
            Thread recieve = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    clientsocket.Receive(buffer);
                    MessageDetails md = (MessageDetails)buffer.DeserializeObject();
                    // rtbMessage.AppendText(md.Messagetext);
                    // Console.WriteLine(md.ToString());
                    SolveRitchProblem("Server said: "+ md.ToString());
                    //later implement chatroom 
                    //aswell as custom user identification
                }
            }));
            recieve.Start();


        }

        delegate void Action(string mes);
        public void SolveRitchProblem(string messageToAdd)
        {
            if (this.rtbxMemo.InvokeRequired)
            {
                Action ac = new Action(SolveRitchProblem);
                this.Invoke(ac, new object[] { messageToAdd });
            }
            else
            {
                rtbxMemo.AppendText(messageToAdd + "\n");
            }
        }


    

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageDetails md = new MessageDetails(txtMessage.Text, "MessageSendRecieve");
          
            this.clientsocket.Send(md.DoBinarySerialization());
            rtbxMemo.AppendText(this.currentClient.Username + " said: " + txtMessage.Text);
            txtMessage.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void checkMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finder find = new Finder(this.currentClient);
            this.Hide();
            find.Show();
        }

        private void MenuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

