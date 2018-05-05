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
    public partial class PaySlip : Form
    {
        private static PaySlip l = null;
        public PaySlip()
        {
            InitializeComponent();
        }
        public static PaySlip getInstance()
        {
            if (l == null)
            {
                l = new PaySlip();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void PaySlip_Load(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            foreach (Task1 t in TaskDL.tsk)
            {
                myserver.calculateSalary();
                paydata ctl = new paydata(t.Tasks, t.TaskDetails);
                flowLayoutPanel1.Controls.Add(ctl);
            }
            
            lblDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
