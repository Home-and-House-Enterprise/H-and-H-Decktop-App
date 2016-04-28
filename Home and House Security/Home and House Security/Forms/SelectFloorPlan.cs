using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_and_House_Security.Forms
{
    public partial class SelectFloorPlan : Form
    {
        NewFloorPlan nfp;
        User main;
        public SelectFloorPlan(User user)
        {
            InitializeComponent();
            main = user;
            nfp = new NewFloorPlan(main.id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nfp.ShowDialog(this);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
