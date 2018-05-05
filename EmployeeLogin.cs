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
    public partial class EmployeeLogin : Form
    {
        private static EmployeeLogin l = null;
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        public static EmployeeLogin getInstance()
        {
            if (l == null)
            {
                l = new EmployeeLogin();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            Boolean isvalid = false;
            Boolean isvalidpassed = false;
            //server.valid(txtUserName.Text, txtPassword.Text, out isvalid, out isvalidpassed);



            if (!isvalid)
            {
                EmployeeHome l = EmployeeHome.getInstance();
                l.Show();
                this.Hide();
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }


        }
    }
}
