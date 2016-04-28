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
    public partial class FloorPlans : Form
    {
        User mainUser;
        SelectFloorPlan sfp;
        FindSensor fs;
        public FloorPlans(User user)
        {
            mainUser = user;
            InitializeComponent();
            sfp = new SelectFloorPlan(user);
            fs = new FindSensor(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfp.ShowDialog(this);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fs.ShowDialog(this);
        }
    }
}
