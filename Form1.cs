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
using System.Web.Services;
namespace TBP
{
    public partial class Form1 : Form
    {
        private static Form1 l = null;
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 getInstance()
        {
            if (l == null)
            {
                l = new Form1();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void cmdSignup_Click(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            myserver.registration(txtUserName.Text,txtPassword.Text,combo_Q.Text,textAns.Text);         
                    

            txtUserName.Text = "";
            txtPassword.Text = "";
            combo_Q.Text = "";
            textAns.Text = "";
            MessageBox.Show("Registered");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = Login.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
