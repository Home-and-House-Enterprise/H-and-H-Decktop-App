using Home_and_House_Security.Data_Entities;
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
        FloorPlan[] floorPlans;
        public FloorPlan selectedFloorPlan { get; set; }

        public SelectFloorPlan(User user)
        {
            InitializeComponent();
            main = user;
            nfp = new NewFloorPlan(main.id);
            updateList();
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
        private void updateList()
        {
            Message m = HNHWebServer.doJSONPost<Message>("get-floor-plans.php", "userid=" + main.id);
            if (m != null)
            {
                if (m.status == "success")
                {
                    foreach(FloorPlan fp in m.floorPlans)
                    {
                        fplist.Items.Add(fp.name);
                    }
                    floorPlans = m.floorPlans;
                }
            }
       
        }

        private void select_Click(object sender, EventArgs e)
        {
            this.selectedFloorPlan = floorPlans[fplist.SelectedIndex];
            this.Hide();
        }
    }
}
