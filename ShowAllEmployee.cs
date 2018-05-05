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
    public partial class ShowAllEmployee : Form
    {
        private static ShowAllEmployee l = null;
        public ShowAllEmployee()
        {
            InitializeComponent();
        }
        public static ShowAllEmployee getInstance()
        {
            if (l == null)
            {
                l = new ShowAllEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void ShowAllEmployee_Load(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getEmployeeList();
            dataGrid.DataSource = bs;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHome l = AdminHome.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
