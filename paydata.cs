using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP
{
    public partial class paydata : UserControl
    {
        public paydata()
        {
            InitializeComponent();
        }
        public paydata(string Tasks, string TaskDetails)
        {
            InitializeComponent();
            label1.Text = Tasks;
            label2.Text = TaskDetails;
        }
        private void paydata_Load(object sender, EventArgs e)
        {

        }
    }
}
