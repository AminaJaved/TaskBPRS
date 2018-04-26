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
    public partial class AdminHome : Form
    {
        private static AdminHome l = null;
        public AdminHome()
        {
            InitializeComponent();
        }
        public static AdminHome getInstance()
        {
            if (l == null)
            {
                l = new AdminHome();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStart l = frmStart.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEmployee l = AddEmployee.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteEmployee l = DeleteEmployee.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowAllEmployee l = ShowAllEmployee.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTask l = AddTask.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
