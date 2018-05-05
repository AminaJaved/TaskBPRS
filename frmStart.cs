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
    public partial class frmStart : Form
    {
        private static frmStart l = null;
        public frmStart()
        {
            InitializeComponent();
        }
        public static frmStart getInstance()
        {
            if (l == null)
            {
                l = new frmStart();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = Login.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeLogin l = EmployeeLogin.getInstance();
            l.Show();
            this.Hide();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }
    }
}
