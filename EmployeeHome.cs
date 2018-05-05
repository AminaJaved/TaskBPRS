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
    public partial class EmployeeHome : Form
    {
        private static EmployeeHome l = null;
        public EmployeeHome()
        {
            InitializeComponent();
        }
        public static EmployeeHome getInstance()
        {
            if (l == null)
            {
                l = new EmployeeHome();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void EmployeeHome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            myserver.ShowMyTasks(label1.Text);
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getTaskList();
            dataGridView1.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            myserver.calculateSalary();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
