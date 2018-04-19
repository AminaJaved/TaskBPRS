using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBPserver;

namespace TBP
{
    public partial class Login : Form
    {
        private static Login l = null;
        public Login()
        {
            InitializeComponent();
        }
        public static Login getInstance()
        {
            if (l == null)
            {
                l = new Login();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            Boolean isvalid=false;
            Boolean isvalidpassed=false;
            server.isvalid(txtUserName.Text, txtPassword.Text,out isvalid,out isvalidpassed);



            if (!isvalid)
            {
                AdminHome l = AdminHome.getInstance();
                l.Show();
                this.Hide();
                MessageBox.Show("valid");
            }
            else 
            {
                MessageBox.Show("invalid");
            }


            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword l = ForgetPassword.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 l = Form1.getInstance();
            l.Show();
            this.Hide();
        }
    }
}

