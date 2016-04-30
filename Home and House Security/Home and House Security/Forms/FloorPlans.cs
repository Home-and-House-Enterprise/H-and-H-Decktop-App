using Home_and_House_Security.Data_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        MediaStorageConnector media;
        EditSensors es;

        public FloorPlans(User user)
        {
            mainUser = user;
            InitializeComponent();
            sfp = new SelectFloorPlan(user);
            fs = new FindSensor(1);
            media = new MediaStorageConnector();
            es = new EditSensors();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfp.ShowDialog(this);
            //if (sfp.selectedFloorPlan==null)
           // {
                loadFloorPlan(sfp.selectedFloorPlan);
           // }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sfp.selectedFloorPlan != null)
            {
                fs.fpID = sfp.selectedFloorPlan.id;
                fs.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Must Select A floor Plan");
            }
        }

        private void loadFloorPlan(FloorPlan fp)
        {
            FileInfo f = new FileInfo(fp.picture);
            if(!f.Exists)
                fpView.Image = media.getImage(fp.picture);
            else
                fpView.Image = Image.FromFile(fp.picture);
        }

        private void editSensors_Click(object sender, EventArgs e)
        {
            if (sfp.selectedFloorPlan != null)
            {
                es.FloorPlanID = sfp.selectedFloorPlan.id;
                es.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Must Select A floor Plan");
            }
        }
    }
}
