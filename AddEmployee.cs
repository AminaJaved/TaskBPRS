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
    public partial class AddEmployee : Form
    {
        private static AddEmployee l = null;
        public AddEmployee()
        {
            InitializeComponent();
        }
        public static AddEmployee getInstance()
        {
            if (l == null)
            {
                l = new AddEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Employee p = new Employee();

            p.EmployeeName = txtEmployeeName.Text;
            p.EmployeePassword = txtEmployeePassword.Text;
            p.EmployeeID = txtEmployeeID.Text;
            p.EmployeeDesignation = txtEmployeeDesignation.Text;
            Service1 server = new Service1();
            server.addemployee(p);
            
            
            MessageBox.Show("Employee Added");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminHome l = AdminHome.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
