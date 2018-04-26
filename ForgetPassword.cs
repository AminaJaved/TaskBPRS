using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP
{
    public partial class ForgetPassword : Form
    {
        private static ForgetPassword l = null;
        public ForgetPassword()
        {
            InitializeComponent();
        }
        public static ForgetPassword getInstance()
        {
            if (l == null)
            {
                l = new ForgetPassword();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            server.resetPassword(txtuser.Text, txtpass.Text, txtQues.Text, txtAns.Text);
            MessageBox.Show("Password Changed");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = Login.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
