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
    public partial class DeleteEmployee : Form
    {
        private static DeleteEmployee l = null;
        public DeleteEmployee()
        {
            InitializeComponent();
        }
        public static DeleteEmployee getInstance()
        {
            if (l == null)
            {
                l = new DeleteEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHome l = AdminHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            myserver.DeleteEmp(txtName.Text,txtID.Text);
            MessageBox.Show("Employee Removed Successfully");
        }
    }
}
